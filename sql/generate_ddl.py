import json, sys

# Read schema JSON
with open(r"C:\Users\小谷拓郎\.claude\projects\c--project-lease-migration\6ed83f84-8235-4021-9b29-8a12b5e64088\tool-results\bqogoqiqh.txt", "r") as f:
    schema = json.load(f)

# Table metadata: name -> (pk_cols, comment)
table_meta = {
    # Code tables
    "C_KJKBN": (["kjkbn_id"], "計上区分"),
    "C_SZEI_KJKBN": (["szei_kjkbn_id"], "消費税計上区分"),
    "C_SKYAK_HO": (["skyak_ho_id"], "償却方法"),
    "C_LEAKBN": (["leakbn_id"], "リース区分"),
    "C_KKBN": (["kkbn_id"], "契約区分"),
    "C_KJTAISYO": (["kjkbn_id"], "計上対象"),
    "C_CHU_HNTI": (["chu_hnti_id"], "注記単位"),
    "C_CHUUM": (["chuum_id"], "注記有無"),
    "C_RCALC": (["rcalc_id"], "再計算区分"),
    "C_SETTEI_IDFLD": ([], "設定IDフィールド"),
    # Master tables
    "M_BCAT": (["bcat_id"], "管理部署"),
    "M_BKIND": (["bkind_id"], "物件種別"),
    "M_BKNRI": (["bknri_id"], "物件分類"),
    "M_GSHA": (["gsha_id"], "購入先・業者"),
    "M_HKMK": (["hkmk_id"], "費用区分"),
    "M_KKNRI": (["kknri_id"], "契約管理単位"),
    "M_MCPT": (["mcpt_id"], "メーカー"),
    "M_SKMK": (["skmk_id"], "集計区分"),
    "M_RSRVB1": (["rsrvb1_id"], "物件予備1"),
    "M_RSRVH1": (["rsrvh1_id"], "配賦予備1"),
    "M_RSRVK1": (["rsrvk1_id"], "契約予備1"),
    "M_LCPT": (["lcpt_id"], "リース会社・支払先"),
    "M_CORP": (["corp_id"], "法人"),
    "M_SWPTN": (["swptn_id"], "仕訳パターン"),
    "M_GENK": (["genk_id"], "原価分類"),
    "M_HKHO": (["hkho_id"], "返却方法"),
    "M_KOZA": (["koza_id"], "口座"),
    "M_SHHO": (["shho_id"], "支払方法"),
    "M_SKTI": (["skti_id"], "事業体"),
    # Data tables
    "D_KYKH": (["kykh_id"], "契約ヘッダ"),
    "D_KYKM": (["kykm_id"], "物件明細"),
    "D_HAIF": (["kykm_id","line_id"], "配賦"),
    "D_GSON": (["kykm_id","line_id"], "減損"),
    "D_HENF": (["kykm_id","line_id"], "変更ファイナンス"),
    "D_HENL": (["kykm_id","line_id"], "変更リース"),
    # Security
    "SEC_USER": (["user_id"], "ユーザー"),
    "SEC_KNGN": (["kngn_id"], "権限"),
    "SEC_KNGN_BKNRI": (["kngn_id","bknri_id"], "権限別物件分類"),
    "SEC_KNGN_KKNRI": (["kngn_id","kknri_id"], "権限別契約管理単位"),
    # System
    "T_SYSTEM": ([], "システム情報"),
    "T_OPT": ([], "オプション設定"),
    "T_SEQ": (["field_nm","table_nm"], "採番管理"),
    "T_DB_VERSION": ([], "DBバージョン"),
    "T_KARI_RITU": ([], "仮リース料率"),
    "T_ZEI_KAISEI": ([], "税制改正"),
    "T_KYKBNJ_SEQ": ([], "契約番号採番"),
    "T_HOLIDAY": ([], "休日"),
    "T_MSTK": ([], "マスタチェック"),
    "T_SZEI_KMK": ([], "消費税科目"),
    "T_SWK_NM": ([], "仕訳名称"),
    # Log
    "L_BKLOG": ([], "バックアップログ"),
    "L_SLOG": (["slog_no"], "セッションログ"),
    "L_ULOG": ([], "更新ログ"),
    # Transaction
    "TC_HREL": ([], "配賦連動"),
    "TC_REC_SHRI": ([], "支払実績"),
}

def map_type(col):
    pytype = col.get("pytype", "")
    size = col.get("size", 0)
    precision = col.get("precision", 0)

    if pytype == "float":
        return "DOUBLE PRECISION"
    elif pytype == "int":
        if precision <= 5 or size <= 5:
            return "SMALLINT"
        else:
            return "INTEGER"
    elif pytype == "str":
        if size and size > 255:
            return "TEXT"
        elif size and size > 0:
            return "VARCHAR(%d)" % size
        else:
            return "VARCHAR(255)"
    elif pytype == "datetime":
        return "TIMESTAMP"
    elif pytype == "bool":
        return "BOOLEAN"
    elif pytype == "Decimal":
        return "NUMERIC"
    elif pytype == "bytes":
        return "BYTEA"
    else:
        return "TEXT"

def get_default(col, colname):
    pytype = col.get("pytype", "")
    if pytype == "bool":
        return " DEFAULT FALSE"
    if colname.endswith("_cnt"):
        return " DEFAULT 0"
    return ""

# Ordering
order_prefixes = ["C_", "M_", "D_", "SEC_", "T_", "L_", "TC_"]

def sort_key(tbl):
    for i, prefix in enumerate(order_prefixes):
        if tbl.upper().startswith(prefix):
            return (i, tbl)
    return (len(order_prefixes), tbl)

sorted_tables = sorted(table_meta.keys(), key=sort_key)

lines = []
lines.append("-- ============================================================")
lines.append("-- LeaseM4BS PostgreSQL DDL")
lines.append("-- Access DB -> PostgreSQL 移行用テーブル定義")
lines.append("-- Generated: 2026-03-13")
lines.append("-- ============================================================")
lines.append("")
lines.append("BEGIN;")
lines.append("")

# DROP statements
lines.append("-- ==========================================================")
lines.append("-- テーブル削除（依存関係の逆順）")
lines.append("-- ==========================================================")
for tbl in reversed(sorted_tables):
    lines.append("DROP TABLE IF EXISTS %s CASCADE;" % tbl.lower())
lines.append("")

# Section headers
section_names = {
    "C_": "コードテーブル",
    "M_": "マスタテーブル",
    "D_": "データテーブル",
    "SEC_": "セキュリティテーブル",
    "T_": "システム・設定テーブル",
    "L_": "ログテーブル",
    "TC_": "トランザクションテーブル",
}

def parse_fallback_cols(cols_fb):
    cols = []
    for c in cols_fb:
        type_name = c.get("type_name", "VARCHAR")
        sz = c.get("size", 255)
        pytype = "str"
        prec = sz
        if "SMALL" in type_name.upper():
            pytype = "int"
            sz = 5
            prec = 5
        elif "INTEGER" in type_name.upper() or "COUNTER" in type_name.upper():
            pytype = "int"
            sz = 10
            prec = 10
        elif "DOUBLE" in type_name.upper() or "FLOAT" in type_name.upper():
            pytype = "float"
            sz = 53
            prec = 53
        elif "DATETIME" in type_name.upper() or "DATE" in type_name.upper():
            pytype = "datetime"
            sz = 19
            prec = 19
        elif "BIT" in type_name.upper():
            pytype = "bool"
            sz = 1
            prec = 1
        elif "LONGCHAR" in type_name.upper() or "MEMO" in type_name.upper():
            pytype = "str"
            sz = 10000
            prec = 10000
        nullable = c.get("nullable", "YES") == "YES"
        cols.append({"name": c["name"], "pytype": pytype, "size": sz, "precision": prec, "nullable": nullable})
    return cols

current_section = None
table_count = 0

for tbl in sorted_tables:
    tbl_upper = tbl.upper()

    # Section header
    for prefix, section_name in section_names.items():
        if tbl_upper.startswith(prefix):
            if current_section != prefix:
                current_section = prefix
                lines.append("-- ==========================================================")
                lines.append("-- %s" % section_name)
                lines.append("-- ==========================================================")
                lines.append("")
            break

    pk_cols, comment = table_meta[tbl]
    tbl_lower = tbl.lower()

    cols = []
    if tbl_upper in schema:
        data = schema[tbl_upper]
        cols = data.get("columns", [])
        if not cols:
            cols_fb = data.get("columns_fallback", [])
            if cols_fb:
                cols = parse_fallback_cols(cols_fb)

    # Handle M_RSRVK1 (not in Access, copy from M_RSRVB1)
    if not cols and tbl_upper == "M_RSRVK1":
        if "M_RSRVB1" in schema:
            src = schema["M_RSRVB1"]["columns"]
            cols = []
            for c in src:
                new_c = dict(c)
                new_c["name"] = c["name"].replace("RSRVB1", "RSRVK1")
                cols.append(new_c)

    if not cols:
        lines.append("-- %s: スキーマ情報未取得" % tbl_lower)
        lines.append("")
        continue

    lines.append("-- %s" % comment)
    lines.append("CREATE TABLE %s (" % tbl_lower)

    col_defs = []
    for col in cols:
        cname = col["name"].lower()
        ctype = map_type(col)
        default = get_default(col, cname)
        nullable = col.get("nullable", True)
        null_str = "" if nullable else " NOT NULL"
        col_defs.append("    %-35s %s%s%s" % (cname, ctype, default, null_str))

    if pk_cols:
        pk_str = ", ".join(pk_cols)
        col_defs.append("    PRIMARY KEY (%s)" % pk_str)

    lines.append(",\n".join(col_defs))
    lines.append(");")
    lines.append("")
    table_count += 1

# Indexes
lines.append("-- ==========================================================")
lines.append("-- インデックス")
lines.append("-- ==========================================================")
lines.append("")

created_indexes = set()
for tbl in sorted_tables:
    tbl_upper = tbl.upper()
    if tbl_upper in schema:
        data = schema[tbl_upper]
        indexes = data.get("indexes", [])
        pk_cols_meta = table_meta.get(tbl, ([], ""))[0]
        pk_cols_lower = [p.lower() for p in pk_cols_meta]

        # Group index columns by index name
        idx_groups = {}
        for idx in indexes:
            idx_name = idx.get("name", "")
            idx_col = idx.get("col", "").lower()
            is_unique = idx.get("unique", False)
            if not idx_name or not idx_col:
                continue
            if idx_name not in idx_groups:
                idx_groups[idx_name] = {"cols": [], "unique": is_unique}
            idx_groups[idx_name]["cols"].append(idx_col)

        for idx_name, idx_info in idx_groups.items():
            cols_list = idx_info["cols"]
            # Skip if it is just the PK
            if cols_list == pk_cols_lower:
                continue

            col_str = "_".join(cols_list)
            pg_idx_name = "idx_%s_%s" % (tbl.lower(), col_str)
            if pg_idx_name in created_indexes:
                continue
            created_indexes.add(pg_idx_name)

            unique_str = "UNIQUE " if idx_info["unique"] else ""
            lines.append("CREATE %sINDEX %s ON %s (%s);" % (unique_str, pg_idx_name, tbl.lower(), ", ".join(cols_list)))

lines.append("")

# Comments
lines.append("-- ==========================================================")
lines.append("-- テーブルコメント")
lines.append("-- ==========================================================")
lines.append("")

for tbl in sorted_tables:
    pk_cols, comment = table_meta[tbl]
    lines.append("COMMENT ON TABLE %s IS '%s';" % (tbl.lower(), comment))

lines.append("")
lines.append("COMMIT;")

# Write file
output_path = r"c:\project_lease_migration\sql\001_create_tables.sql"
with open(output_path, "w", encoding="utf-8") as f:
    f.write("\n".join(lines))

print("Written %d lines to %s" % (len(lines), output_path))
print("Tables created: %d" % table_count)
