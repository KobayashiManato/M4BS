"""Access MDB → PostgreSQL データ移行スクリプト
FK制約を一時DROP → データ投入 → DDLから制約再作成
"""
import os
import pyodbc
import psycopg2  # type: ignore


MDB_PATH = r"c:\access_LeaseM4BS\Data\LM4BSdat.mdb"
PG_CONN = {
    "host": os.environ.get("PGHOST", "localhost"),
    "port": int(os.environ.get("PGPORT", "5432")),
    "database": os.environ.get("PGDATABASE", "lease_m4bs"),
    "user": os.environ.get("PGUSER", "lease_m4bs_user"),
    "password": os.environ.get("PGPASSWORD", ""),
}


def get_access_tables(cursor):
    return sorted([t.table_name for t in cursor.tables(tableType="TABLE")])


def get_pg_tables(cursor):
    cursor.execute("SELECT tablename FROM pg_tables WHERE schemaname='public'")
    return [r[0] for r in cursor.fetchall()]


def get_pg_columns(cursor, table):
    cursor.execute(
        "SELECT column_name FROM information_schema.columns "
        "WHERE table_schema='public' AND table_name=%s ORDER BY ordinal_position",
        (table,),
    )
    return [r[0] for r in cursor.fetchall()]


def convert_value(val):
    if val is None:
        return None
    if isinstance(val, bytes):
        return val.decode("cp932", errors="replace")
    return val


def drop_fk_constraints(pg_cursor):
    """FK制約を取得・DROP し、再作成用SQLを返す"""
    pg_cursor.execute("""
        SELECT conname, conrelid::regclass::text,
               pg_get_constraintdef(oid)
        FROM pg_constraint WHERE contype = 'f'
    """)
    fks = pg_cursor.fetchall()
    recreate_sqls = []
    for conname, relname, condef in fks:
        recreate_sqls.append(
            f"ALTER TABLE {relname} ADD CONSTRAINT {conname} {condef}"
        )
        pg_cursor.execute(f"ALTER TABLE {relname} DROP CONSTRAINT {conname}")
    return recreate_sqls


def migrate():
    # Access接続
    access_conn = pyodbc.connect(
        r"DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + MDB_PATH
    )
    ac = access_conn.cursor()

    # PostgreSQL接続
    pg_conn = psycopg2.connect(**PG_CONN)
    pg = pg_conn.cursor()

    # Step 1: FK制約を一時DROP
    recreate_sqls = drop_fk_constraints(pg)
    pg_conn.commit()
    print(f"FK制約を一時DROP ({len(recreate_sqls)}件)\n")

    migrated = 0
    skipped = 0
    errors = []

    try:
        access_tables = get_access_tables(ac)
        pg_table_set = {t.lower(): t for t in get_pg_tables(pg)}

        # Step 2: データ移行
        for at in access_tables:
            pt = pg_table_set.get(at.lower())
            if not pt:
                print(f"  SKIP: {at} (PGにテーブルなし)")
                skipped += 1
                continue

            try:
                ac.execute(f"SELECT COUNT(*) FROM [{at}]")
                cnt = ac.fetchone()[0]
                if cnt == 0:
                    print(f"  SKIP: {at} (empty)")
                    skipped += 1
                    continue
            except Exception as e:
                errors.append((at, str(e)))
                continue

            pg_cols = get_pg_columns(pg, pt)
            if not pg_cols:
                errors.append((at, "PGカラム取得失敗"))
                continue

            ac.execute(f"SELECT TOP 1 * FROM [{at}]")
            ac_cols = [d[0] for d in ac.description]

            pg_col_map = {c.lower(): c for c in pg_cols}
            matched = [(a, pg_col_map[a.lower()]) for a in ac_cols if a.lower() in pg_col_map]

            if not matched:
                errors.append((at, "マッチするカラムなし"))
                continue

            ac_names = [m[0] for m in matched]
            pg_names = [m[1] for m in matched]

            pg.execute(f"TRUNCATE {pt}")

            sel = ", ".join([f"[{c}]" for c in ac_names])
            ac.execute(f"SELECT {sel} FROM [{at}]")

            ph = ", ".join(["%s"] * len(pg_names))
            ins = f"INSERT INTO {pt} ({', '.join(pg_names)}) VALUES ({ph})"

            row_count = 0
            for row in ac.fetchall():
                vals = [convert_value(v) for v in row]
                try:
                    pg.execute(ins, vals)
                    row_count += 1
                except Exception as e:
                    pg_conn.rollback()
                    errors.append((at, f"insert error: {e}"))
                    row_count = -1
                    break

            if row_count > 0:
                pg_conn.commit()
                print(f"  OK: {at} -> {pt} ({row_count} rows)")
                migrated += 1
            elif row_count == 0:
                pg_conn.commit()
    finally:
        # Step 3: FK制約を再作成（異常終了時も必ず実行）
        print(f"\nFK制約を再作成中...")
        fk_errors = []
        for sql in recreate_sqls:
            try:
                pg.execute(sql)
                pg_conn.commit()
            except Exception as e:
                pg_conn.rollback()
                fk_errors.append(f"  {sql[:80]}... -> {e}")

        if fk_errors:
            print(f"FK再作成エラー ({len(fk_errors)}件):")
            for fe in fk_errors:
                print(fe)
        else:
            print(f"FK制約を全て再作成しました ({len(recreate_sqls)}件)")

    print(f"\n=== 結果 ===")
    print(f"移行成功: {migrated} テーブル")
    print(f"スキップ: {skipped} テーブル")
    print(f"エラー: {len(errors)} テーブル")
    if errors:
        print("\nエラー詳細:")
        for t, e in errors:
            print(f"  {t}: {e}")

    access_conn.close()
    pg_conn.close()


if __name__ == "__main__":
    print("=== Access -> PostgreSQL データ移行 ===")
    print(f"元: {MDB_PATH}")
    print(f"先: {PG_CONN['database']}@{PG_CONN['host']}\n")
    migrate()
