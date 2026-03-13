"""Access → PostgreSQL 移行精密検証スクリプト
テーブル数・行数・カラム数・サンプルデータを比較
"""
import os
import pyodbc
import psycopg2

MDB_PATH = r"c:\access_LeaseM4BS\Data\LM4BSdat.mdb"
PG_CONN = {
    "host": "localhost",
    "port": 5432,
    "database": "lease_m4bs",
    "user": "lease_m4bs_user",
    "password": os.environ.get("PGPASSWORD", "iltex_mega_pass_m4"),
}


def get_access_tables(ac):
    return sorted([t.table_name for t in ac.tables(tableType="TABLE")])


def get_pg_tables(pg):
    pg.execute("SELECT tablename FROM pg_tables WHERE schemaname='public' ORDER BY tablename")
    return [r[0] for r in pg.fetchall()]


def get_access_columns(ac, table):
    ac.execute(f"SELECT TOP 1 * FROM [{table}]")
    return [d[0] for d in ac.description]


def get_pg_columns(pg, table):
    pg.execute(
        "SELECT column_name FROM information_schema.columns "
        "WHERE table_schema='public' AND table_name=%s ORDER BY ordinal_position",
        (table,),
    )
    return [r[0] for r in pg.fetchall()]


def get_row_count_access(ac, table):
    try:
        ac.execute(f"SELECT COUNT(*) FROM [{table}]")
        return ac.fetchone()[0]
    except:
        return -1


def get_row_count_pg(pg, table):
    pg.execute(f"SELECT COUNT(*) FROM {table}")
    return pg.fetchone()[0]


def convert_val(v):
    if v is None:
        return None
    if isinstance(v, bytes):
        return v.decode("cp932", errors="replace")
    if isinstance(v, float):
        if v == int(v):
            return int(v)
    return v


def compare_sample_data(ac, pg, ac_table, pg_table, matched_cols, limit=5):
    """先頭N行のデータを比較"""
    ac_names = [m[0] for m in matched_cols]
    pg_names = [m[1] for m in matched_cols]

    sel_ac = ", ".join([f"[{c}]" for c in ac_names])
    try:
        ac.execute(f"SELECT TOP {limit} {sel_ac} FROM [{ac_table}]")
        ac_rows = ac.fetchall()
    except:
        return None, "Access読取エラー"

    sel_pg = ", ".join(pg_names)
    pg.execute(f"SELECT {sel_pg} FROM {pg_table} LIMIT {limit}")
    pg_rows = pg.fetchall()

    mismatches = []
    for i, (ar, pr) in enumerate(zip(ac_rows, pg_rows)):
        for j, (av, pv) in enumerate(zip(ar, pr)):
            av2 = convert_val(av)
            pv2 = convert_val(pv)
            # 型を揃えて比較
            if av2 is None and pv2 is None:
                continue
            if av2 is None or pv2 is None:
                mismatches.append((i, ac_names[j], av2, pv2))
                continue
            # 数値比較
            try:
                if abs(float(av2) - float(pv2)) < 0.0001:
                    continue
            except (ValueError, TypeError):
                pass
            # 文字列比較
            if str(av2).strip() != str(pv2).strip():
                mismatches.append((i, ac_names[j], av2, pv2))

    return mismatches, None


def main():
    access_conn = pyodbc.connect(
        r"DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};DBQ=" + MDB_PATH
    )
    ac = access_conn.cursor()

    pg_conn = psycopg2.connect(**PG_CONN)
    pg = pg_conn.cursor()

    access_tables = get_access_tables(ac)
    pg_table_set = {t.lower(): t for t in get_pg_tables(pg)}

    print("=" * 80)
    print("ACCESS → PostgreSQL 移行精密検証")
    print("=" * 80)

    # --- テーブルマッピング確認 ---
    print(f"\n■ Access テーブル数: {len(access_tables)}")
    print(f"■ PostgreSQL テーブル数: {len(pg_table_set)}")

    missing_in_pg = []
    results = []
    total_ac_rows = 0
    total_pg_rows = 0
    total_mismatch_tables = 0
    data_mismatch_tables = []

    for at in access_tables:
        pt = pg_table_set.get(at.lower())
        if not pt:
            missing_in_pg.append(at)
            continue

        ac_count = get_row_count_access(ac, at)
        pg_count = get_row_count_pg(pg, pt)
        total_ac_rows += max(ac_count, 0)
        total_pg_rows += pg_count

        # カラムマッチング
        try:
            ac_cols = get_access_columns(ac, at)
        except:
            ac_cols = []
        pg_cols = get_pg_columns(pg, pt)

        pg_col_map = {c.lower(): c for c in pg_cols}
        matched = [(a, pg_col_map[a.lower()]) for a in ac_cols if a.lower() in pg_col_map]
        unmatched_ac = [a for a in ac_cols if a.lower() not in pg_col_map]

        row_match = "OK" if ac_count == pg_count else "MISMATCH"
        if ac_count != pg_count:
            total_mismatch_tables += 1

        # サンプルデータ比較
        data_issues = []
        if ac_count > 0 and pg_count > 0 and matched:
            mismatches, err = compare_sample_data(ac, pg, at, pt, matched)
            if err:
                data_issues.append(err)
            elif mismatches:
                data_mismatch_tables.append(at)
                for row_i, col, av, pv in mismatches[:3]:
                    data_issues.append(f"  row{row_i} [{col}] Access={av} / PG={pv}")

        results.append({
            "access": at,
            "pg": pt,
            "ac_count": ac_count,
            "pg_count": pg_count,
            "row_match": row_match,
            "ac_cols": len(ac_cols),
            "pg_cols": len(pg_cols),
            "matched_cols": len(matched),
            "unmatched_ac": unmatched_ac,
            "data_issues": data_issues,
        })

    # --- 結果出力 ---
    print(f"\n{'='*80}")
    print(f"{'テーブル':<20} {'Access行数':>10} {'PG行数':>10} {'行数':>8} {'Acol':>5} {'Pcol':>5} {'Match':>5}")
    print(f"{'='*80}")

    for r in results:
        mark = "OK" if r["row_match"] == "OK" else "NG"
        print(f"{r['access']:<20} {r['ac_count']:>10} {r['pg_count']:>10} {mark:>8} {r['ac_cols']:>5} {r['pg_cols']:>5} {r['matched_cols']:>5}")
        if r["unmatched_ac"]:
            print(f"  -> Access固有カラム: {', '.join(r['unmatched_ac'])}")
        for di in r["data_issues"]:
            print(f"  -> DATA: {di}")

    # --- サマリ ---
    print(f"\n{'='*80}")
    print("検証サマリ")
    print(f"{'='*80}")
    print(f"Accessテーブル数      : {len(access_tables)}")
    print(f"PGにマッピング済み    : {len(results)}")
    print(f"PGに未存在            : {len(missing_in_pg)}")
    if missing_in_pg:
        print(f"  -> {', '.join(missing_in_pg)}")
    print(f"Access総行数          : {total_ac_rows}")
    print(f"PG総行数              : {total_pg_rows}")
    print(f"行数一致テーブル      : {len(results) - total_mismatch_tables}/{len(results)}")
    print(f"行数不一致テーブル    : {total_mismatch_tables}")
    print(f"データ値不一致テーブル: {len(data_mismatch_tables)}")
    if data_mismatch_tables:
        print(f"  -> {', '.join(data_mismatch_tables)}")

    match_rate = (len(results) - total_mismatch_tables) / len(results) * 100 if results else 0
    print(f"\n行数一致率: {match_rate:.1f}%")

    if total_mismatch_tables == 0 and len(missing_in_pg) == 0 and len(data_mismatch_tables) == 0:
        print("\n*** 移行検証: PASS - 完全一致 ***")
    elif total_mismatch_tables == 0 and len(data_mismatch_tables) == 0:
        print(f"\n*** 移行検証: PASS (データ一致) - PG未存在テーブル {len(missing_in_pg)}件は要確認 ***")
    else:
        print(f"\n*** 移行検証: 要確認 ***")

    access_conn.close()
    pg_conn.close()


if __name__ == "__main__":
    main()
