# Access VBA → VB.NET 移行 完全網羅チェックリスト

**作成日**: 2026-03-13
**対象**: LeaseM4BS (リース資産管理システム)
**移行元**: Access VBA → **移行先**: VB.NET WinForms + PostgreSQL

---

## 凡例

| 記号 | 意味 |
|------|------|
| 工数 S | 0.5〜1人日 |
| 工数 M | 2〜3人日 |
| 工数 L | 5〜8人日 |
| 工数 XL | 10人日以上 |
| 必須 | システム稼働に不可欠 |
| 推奨 | 業務上必要だが段階的対応可 |
| 任意 | なくても運用可 |

---

## A. データベース層

### A-1. コードテーブル（c_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-1-01 | [ ] | c_chuum | 注記有無 | sql/001_create_tables.sql | S | 必須 |
| A-1-02 | [ ] | c_chu_hnti | 注記単位 | sql/001_create_tables.sql | S | 必須 |
| A-1-03 | [ ] | c_kjkbn | 計上区分 | sql/001_create_tables.sql | S | 必須 |
| A-1-04 | [ ] | c_kjtaisyo | 計上対象 | sql/001_create_tables.sql | S | 必須 |
| A-1-05 | [ ] | c_kkbn | 契約区分 | sql/001_create_tables.sql | S | 必須 |
| A-1-06 | [ ] | c_leakbn | リース区分 | sql/001_create_tables.sql | S | 必須 |
| A-1-07 | [ ] | c_rcalc | 再計算区分 | sql/001_create_tables.sql | S | 必須 |
| A-1-08 | [ ] | c_settei_idfld | 設定IDフィールド | sql/001_create_tables.sql | S | 必須 |
| A-1-09 | [ ] | c_skyak_ho | 償却方法 | sql/001_create_tables.sql | S | 必須 |
| A-1-10 | [ ] | c_szei_kjkbn | 消費税計上区分 | sql/001_create_tables.sql | S | 必須 |

### A-2. マスタテーブル（m_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-2-01 | [ ] | m_bcat | 管理部署 | sql/001_create_tables.sql | S | 必須 |
| A-2-02 | [ ] | m_bkind | 物件種別 | sql/001_create_tables.sql | S | 必須 |
| A-2-03 | [ ] | m_bknri | 物件分類 | sql/001_create_tables.sql | S | 必須 |
| A-2-04 | [ ] | m_corp | 法人 | sql/001_create_tables.sql | S | 必須 |
| A-2-05 | [ ] | m_genk | 原価分類 | sql/001_create_tables.sql | S | 必須 |
| A-2-06 | [ ] | m_gsha | 購入先・業者 | sql/001_create_tables.sql | S | 必須 |
| A-2-07 | [ ] | m_hkho | 返却方法 | sql/001_create_tables.sql | S | 必須 |
| A-2-08 | [ ] | m_hkmk | 費用区分 | sql/001_create_tables.sql | S | 必須 |
| A-2-09 | [ ] | m_kknri | 契約管理単位 | sql/001_create_tables.sql | S | 必須 |
| A-2-10 | [ ] | m_koza | 口座 | sql/001_create_tables.sql | S | 必須 |
| A-2-11 | [ ] | m_lcpt | リース会社・支払先 | sql/001_create_tables.sql | M | 必須 |
| A-2-12 | [ ] | m_mcpt | メーカー | sql/001_create_tables.sql | S | 必須 |
| A-2-13 | [ ] | m_rsrvb1 | 物件予備1 | sql/001_create_tables.sql | S | 推奨 |
| A-2-14 | [ ] | m_rsrvh1 | 配賦予備1 | sql/001_create_tables.sql | S | 推奨 |
| A-2-15 | [ ] | m_rsrvk1 | 契約予備1 | sql/001_create_tables.sql | S | 推奨 |
| A-2-16 | [ ] | m_shho | 支払方法 | sql/001_create_tables.sql | S | 必須 |
| A-2-17 | [ ] | m_skmk | 集計区分（資産科目） | sql/001_create_tables.sql | M | 必須 |
| A-2-18 | [ ] | m_skti | 事業体 | sql/001_create_tables.sql | S | 必須 |
| A-2-19 | [ ] | m_swptn | 仕訳パターン | sql/001_create_tables.sql | M | 必須 |

### A-3. データテーブル（d_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-3-01 | [ ] | d_gson | 減損 | sql/001_create_tables.sql | M | 必須 |
| A-3-02 | [ ] | d_haif | 配賦 | sql/001_create_tables.sql | M | 必須 |
| A-3-03 | [ ] | d_henf | 変更ファイナンス | sql/001_create_tables.sql | M | 必須 |
| A-3-04 | [ ] | d_henl | 変更リース | sql/001_create_tables.sql | M | 必須 |
| A-3-05 | [ ] | d_kykh | 契約ヘッダ（約90列） | sql/001_create_tables.sql | L | 必須 |
| A-3-06 | [ ] | d_kykm | 物件明細（約120列） | sql/001_create_tables.sql | XL | 必須 |

### A-4. セキュリティテーブル（sec_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-4-01 | [ ] | sec_kngn | 権限 | sql/001_create_tables.sql | M | 必須 |
| A-4-02 | [ ] | sec_kngn_bknri | 権限別物件分類 | sql/001_create_tables.sql | S | 必須 |
| A-4-03 | [ ] | sec_kngn_kknri | 権限別契約管理単位 | sql/001_create_tables.sql | S | 必須 |
| A-4-04 | [ ] | sec_user | ユーザー | sql/001_create_tables.sql | M | 必須 |

### A-5. システム・設定テーブル（t_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-5-01 | [ ] | t_db_version | DBバージョン | sql/001_create_tables.sql | S | 必須 |
| A-5-02 | [ ] | t_holiday | 休日 | sql/001_create_tables.sql | S | 推奨 |
| A-5-03 | [ ] | t_kari_ritu | 仮リース料率 | sql/001_create_tables.sql | M | 必須 |
| A-5-04 | [ ] | t_kykbnj_seq | 契約番号採番 | sql/001_create_tables.sql | M | 必須 |
| A-5-05 | [ ] | t_mstk | マスタチェック | sql/001_create_tables.sql | S | 推奨 |
| A-5-06 | [ ] | t_opt | オプション設定 | sql/001_create_tables.sql | S | 必須 |
| A-5-07 | [ ] | t_seq | 採番管理 | sql/001_create_tables.sql | M | 必須 |
| A-5-08 | [ ] | t_swk_nm | 仕訳名称 | sql/001_create_tables.sql | S | 必須 |
| A-5-09 | [ ] | t_system | システム情報 | sql/001_create_tables.sql | S | 必須 |
| A-5-10 | [ ] | t_szei_kmk | 消費税科目 | sql/001_create_tables.sql | M | 必須 |
| A-5-11 | [ ] | t_zei_kaisei | 税制改正 | sql/001_create_tables.sql | M | 必須 |

### A-6. ログテーブル（l_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-6-01 | [ ] | l_bklog | バックアップログ | sql/001_create_tables.sql | S | 推奨 |
| A-6-02 | [ ] | l_slog | セッションログ | sql/001_create_tables.sql | M | 必須 |
| A-6-03 | [ ] | l_ulog | 更新ログ | sql/001_create_tables.sql | M | 必須 |

### A-7. トランザクションテーブル（tc_ テーブル）

| # | チェック | テーブル名 | 説明 | DDLファイル | 工数 | 優先度 |
|---|----------|-----------|------|------------|------|--------|
| A-7-01 | [ ] | tc_hrel | 配賦連動 | sql/001_create_tables.sql | L | 必須 |
| A-7-02 | [ ] | tc_rec_shri | 支払実績 | sql/001_create_tables.sql | L | 必須 |

### A-8. インデックス・制約

| # | チェック | 項目 | 工数 | 優先度 |
|---|----------|------|------|--------|
| A-8-01 | [ ] | 全テーブルのPRIMARY KEY（DDLに定義済み） | S | 必須 |
| A-8-02 | [ ] | ユニークインデックス（c_chuum, c_chu_hnti, c_kkbn等 8件） | S | 必須 |
| A-8-03 | [ ] | 参照用インデックス（m_bcat, m_bkind等のFKインデックス 約30件） | M | 必須 |
| A-8-04 | [ ] | 外部キー制約の追加検討（Access版では暗黙的） | M | 推奨 |

---

## B. 画面（UI層）

### B-1. メインナビゲーション

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-1-01 | [ ] | Form_MAIN | メインメニュー（タブ構成） | Form_MAIN.vb | menu_*_Click (約30個) | L | 必須 |
| B-1-02 | [ ] | Form_Switchboard | スイッチボード | Form_Switchboard.vb | New() | S | 必須 |
| B-1-03 | [ ] | Form1 | 起動フォーム | Form1.vb | - | S | 必須 |

### B-2. 契約管理フォーム

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-2-01 | [ ] | Form_ContractEntry | 契約書新規入力 | Form_ContractEntry.Designer.vb | (Designer のみ - ロジック未実装) | XL | 必須 |
| B-2-02 | [ ] | Form_BuknEntry | 物件入力 | Form_BuknEntry.Designer.vb | (Designer のみ) | XL | 必須 |
| B-2-03 | [ ] | Form_f_KYKH | 契約ヘッダ編集 | Form_f_KYKH.vb | New() | L | 必須 |
| B-2-04 | [ ] | Form_f_KYKH_SUB | 契約ヘッダサブ | Form_f_KYKH_SUB.vb | New() | M | 必須 |
| B-2-05 | [ ] | Form_f_KYKM | 物件明細 | Form_f_KYKM.vb | New() | L | 必須 |
| B-2-06 | [ ] | Form_f_KYKM_SUB | 物件明細サブ | Form_f_KYKM_SUB.vb | New() | M | 必須 |
| B-2-07 | [ ] | Form_f_KYKM_SUB_BKN | 物件明細サブ（物件） | Form_f_KYKM_SUB_BKN.vb | New() | M | 必須 |
| B-2-08 | [ ] | Form_f_KYKM_BKN | 物件管理 | Form_f_KYKM_BKN.vb | New() | M | 必須 |
| B-2-09 | [ ] | Form_f_KYKM_BUNKATSU | 物件分割 | Form_f_KYKM_BUNKATSU.vb | New() | L | 必須 |

### B-3. 注記判定フォーム

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-3-01 | [ ] | Form_f_KYKM_CHUUKI | 物件注記判定 | Form_f_KYKM_CHUUKI.vb | New() | L | 必須 |
| B-3-02 | [ ] | Form_f_KYKM_CHUUKI_拡張設定 | 注記拡張設定 | Form_f_KYKM_CHUUKI_拡張設定.vb | New() | M | 必須 |
| B-3-03 | [ ] | Form_f_KYKM_CHUUKI_SUB_GSON | 注記減損サブ | Form_f_KYKM_CHUUKI_SUB_GSON.vb | New() | M | 推奨 |
| B-3-04 | [ ] | Form_f_REF_D_KYKM_CHUUKI | 参照用注記判定 | Form_f_REF_D_KYKM_CHUUKI.vb | New() | M | 必須 |
| B-3-05 | [ ] | Form_f_REF_D_KYKM_CHUUKI_拡張設定 | 参照用注記拡張設定 | Form_f_REF_D_KYKM_CHUUKI_拡張設定.vb | New() | M | 推奨 |
| B-3-06 | [ ] | Form_f_REF_D_KYKM_CHUUKI_SUB_GSON | 参照用注記減損 | Form_f_REF_D_KYKM_CHUUKI_SUB_GSON.vb | New() | S | 推奨 |

### B-4. 変更管理フォーム

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-4-01 | [ ] | Form_f_HENF | 変更ファイナンス | Form_f_HENF.vb | New() | L | 必須 |
| B-4-02 | [ ] | Form_f_HENL | 変更リース | Form_f_HENL.vb | New() | L | 必須 |
| B-4-03 | [ ] | Form_f_HEN_SCH | 返済スケジュール | Form_f_HEN_SCH.vb | New() | L | 必須 |

### B-5. 参照フォーム

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-5-01 | [ ] | Form_f_REF_D_KYKH | 契約ヘッダ参照 | Form_f_REF_D_KYKH.vb | New() | M | 必須 |
| B-5-02 | [ ] | Form_f_REF_D_KYKH_SUB | 契約ヘッダ参照サブ | Form_f_REF_D_KYKH_SUB.vb | New() | M | 必須 |
| B-5-03 | [ ] | Form_f_REF_D_KYKM | 物件明細参照 | Form_f_REF_D_KYKM.vb | New() | M | 必須 |
| B-5-04 | [ ] | Form_f_REF_D_KYKM_SUB | 物件明細参照サブ | Form_f_REF_D_KYKM_SUB.vb | New() | M | 必須 |
| B-5-05 | [ ] | Form_f_REF_D_HENF | 変更ファイナンス参照 | Form_f_REF_D_HENF.vb | New() | M | 推奨 |
| B-5-06 | [ ] | Form_f_REF_D_HENL | 変更リース参照 | Form_f_REF_D_HENL.vb | New() | M | 推奨 |

### B-6. フレックス一覧フォーム（台帳タブ）

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-6-01 | [ ] | Form_f_flx_CONTRACT | 契約書フレックス一覧 | Form_f_flx_CONTRACT.vb | New() | L | 必須 |
| B-6-02 | [ ] | Form_f_flx_BUKN | 物件フレックス一覧 | Form_f_flx_BUKN.vb | New() | L | 必須 |
| B-6-03 | [ ] | Form_f_flx_D_HAIF | 配賦フレックス一覧 | Form_f_flx_D_HAIF.vb | New() | M | 必須 |
| B-6-04 | [ ] | Form_f_flx_D_HENF | 変更ファイナンスフレックス | Form_f_flx_D_HENF.vb | New() | M | 必須 |
| B-6-05 | [ ] | Form_f_flx_D_GSON | 減損フレックス一覧 | Form_f_flx_D_GSON.vb | New() | M | 推奨 |
| B-6-06 | [ ] | Form_f_flx_D_KYKH | 契約ヘッダフレックス | Form_f_flx_D_KYKH.vb | New() | M | 必須 |
| B-6-07 | [ ] | Form_f_flx_D_KYKM | 物件明細フレックス | Form_f_flx_D_KYKM.vb | New() | M | 必須 |
| B-6-08 | [ ] | Form_f_flx_D_KYKM_BKN | 物件明細（物件付き）フレックス | Form_f_flx_D_KYKM_BKN.vb | New() | M | 推奨 |
| B-6-09 | [ ] | Form_f_flx_D_HAIF_SNKO | 配賦フレックス（三光エアー用） | Form_f_flx_D_HAIF_SNKO.vb | New() | M | 推奨 |

### B-7. フレックス共通ダイアログ

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-7-01 | [ ] | Form_f_FlexSearchDLG | 検索ダイアログ | Form_f_FlexSearchDLG.vb | New() | L | 必須 |
| B-7-02 | [ ] | Form_f_FlexSearchDLG_Fld | 検索フィールド選択 | Form_f_FlexSearchDLG_Fld.vb | New() | M | 必須 |
| B-7-03 | [ ] | Form_f_FlexSearchDLG_Sub | 検索サブ条件 | Form_f_FlexSearchDLG_Sub.vb | New() | M | 必須 |
| B-7-04 | [ ] | Form_f_FlexSearchDLG_Save | 検索条件保存 | Form_f_FlexSearchDLG_Save.vb | New() | M | 推奨 |
| B-7-05 | [ ] | Form_f_FlexSortDLG | ソートダイアログ | Form_f_FlexSortDLG.vb | New() | M | 必須 |
| B-7-06 | [ ] | Form_f_FlexOutputDLG | 出力ダイアログ | Form_f_FlexOutputDLG.vb | New() | M | 必須 |
| B-7-07 | [ ] | Form_f_FlexOutputDLG_Def | 出力定義 | Form_f_FlexOutputDLG_Def.vb | New() | M | 推奨 |
| B-7-08 | [ ] | Form_f_FlexOutputDLG_Def_Sub | 出力定義サブ | Form_f_FlexOutputDLG_Def_Sub.vb | New() | S | 推奨 |
| B-7-09 | [ ] | Form_f_FlexReportDLG | レポートダイアログ | Form_f_FlexReportDLG.vb | New() | M | 推奨 |
| B-7-10 | [ ] | Form_f_FlexReportDLG_Save | レポート保存 | Form_f_FlexReportDLG_Save.vb | New() | M | 推奨 |

### B-8. マスタメンテナンスフォーム（一覧+入力+変更 各マスタ）

| # | チェック | マスタ名 | 一覧フォーム | 入力フォーム | 変更フォーム | 工数(合計) | 優先度 |
|---|----------|---------|-------------|------------|------------|-----------|--------|
| B-8-01 | [ ] | 会社 | Form_f_flx_M_CORP | Form_f_M_CORP_INP | Form_f_M_CORP_CHANGE | M | 必須 |
| B-8-02 | [ ] | 契約管理単位 | Form_f_flx_M_KKNRI | Form_f_M_KKNRI_INP | Form_f_M_KKNRI_CHANGE | M | 必須 |
| B-8-03 | [ ] | 支払先（リース会社） | Form_f_flx_M_LCPT | Form_f_M_LCPT_INP | Form_f_M_LCPT_CHANGE | L | 必須 |
| B-8-04 | [ ] | 支払先（MYCOM用） | Form_f_flx_M_LCPT_MYCOM | Form_f_M_LCPT_INP_MYCOM | - | M | 推奨 |
| B-8-05 | [ ] | 支払方法 | Form_f_flx_M_SHHO | Form_f_M_SHHO_INP | Form_f_M_SHHO_CHANGE | M | 必須 |
| B-8-06 | [ ] | 原価区分 | Form_f_flx_M_GENK | Form_f_M_GENK_INP | Form_f_M_GENK_CHANGE | M | 必須 |
| B-8-07 | [ ] | 部署 | Form_f_flx_M_BCAT | Form_f_M_BCAT_INP | Form_f_M_BCAT_CHANGE | M | 必須 |
| B-8-08 | [ ] | 物件管理単位 | Form_f_flx_M_BKNRI | Form_f_M_BKNRI_INP | Form_f_M_BKNRI_CHANGE | M | 必須 |
| B-8-09 | [ ] | 費用区分 | Form_f_flx_M_HKMK | Form_f_M_HKMK_INP | Form_f_M_HKMK_CHANGE | M | 必須 |
| B-8-10 | [ ] | 資産区分（集計区分） | Form_f_flx_M_SKMK | Form_f_M_SKMK_INP | Form_f_M_SKMK_CHANGE | M | 必須 |
| B-8-11 | [ ] | 物件種別 | Form_f_flx_M_BKIND | Form_f_M_BKIND_INP | Form_f_M_BKIND_CHANGE | M | 必須 |
| B-8-12 | [ ] | 銀行口座 | Form_f_flx_M_KOZA | Form_f_M_KOZA_INP | Form_f_M_KOZA_CHANGE | M | 推奨 |
| B-8-13 | [ ] | 業者 | Form_f_flx_M_GSHA | Form_f_M_GSHA_INP | Form_f_M_GSHA_CHANGE | M | 推奨 |
| B-8-14 | [ ] | メーカー | Form_f_flx_M_MCPT | Form_f_M_MCPT_INP | Form_f_M_MCPT_CHANGE | M | 推奨 |
| B-8-15 | [ ] | 廃棄方法 | Form_f_flx_M_HKHO | Form_f_M_HKHO_INP | Form_f_M_HKHO_CHANGE | M | 推奨 |
| B-8-16 | [ ] | 予備（契約書用） | Form_f_flx_M_RSRVK1 | Form_f_M_RSRVK1_INP | Form_f_M_RSRVK1_CHANGE | M | 推奨 |
| B-8-17 | [ ] | 予備（物件用） | Form_f_flx_M_RSRVB1 | Form_f_M_RSRVB1_INP | Form_f_M_RSRVB1_CHANGE | M | 推奨 |
| B-8-18 | [ ] | 予備（配賦用） | Form_f_flx_M_RSRVH1 | Form_f_M_RSRVH1_INP_SNKO | - | M | 推奨 |
| B-8-19 | [ ] | 仕訳パターン | Form_f_flx_M_SWPTN | Form_f_M_SWPTN_INP | - | M | 必須 |

### B-9. 共通コンボボックス用の基底フォーム

| # | チェック | フォーム名 | 説明 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|-----------|------|---------------|---------|------|--------|
| B-9-01 | [ ] | Form_BCAT | 部署コンボ基底 | Form_BCAT.vb | LoadBcatCombos(), LoadGenkCombo() | M | 必須 |
| B-9-02 | [ ] | Form_BKNRI | 物件分類コンボ基底 | Form_BKNRI.vb | LoadBknriCombos() | M | 必須 |
| B-9-03 | [ ] | Form_KKNRI | 契約管理単位コンボ基底 | Form_KKNRI.vb | - | M | 必須 |
| B-9-04 | [ ] | Form_LCPT | 支払先コンボ基底 | Form_LCPT.vb | - | M | 必須 |
| B-9-05 | [ ] | Form_HKMK | 費用区分コンボ基底 | Form_HKMK.vb | - | M | 必須 |
| B-9-06 | [ ] | Form_SKMK | 資産区分コンボ基底 | Form_SKMK.vb | - | M | 必須 |

---

## C. ビジネスロジック層

### C-1. 契約管理

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-1-01 | [ ] | 契約新規登録 | Form_ContractEntry.Designer.vb | (未実装 - 要実装) | XL | 必須 |
| C-1-02 | [ ] | 契約変更 | Form_f_KYKH.vb, Form_f_KYKH_SUB.vb | New() | L | 必須 |
| C-1-03 | [ ] | 契約削除 | Form_f_KYKH.vb | (要実装) | M | 必須 |
| C-1-04 | [ ] | 契約照会（参照） | Form_f_REF_D_KYKH.vb | New() | M | 必須 |
| C-1-05 | [ ] | 契約一覧検索 | Form_f_flx_CONTRACT.vb | New() | L | 必須 |

### C-2. 物件管理

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-2-01 | [ ] | 物件新規登録 | Form_BuknEntry.Designer.vb | (未実装 - 要実装) | XL | 必須 |
| C-2-02 | [ ] | 物件変更 | Form_f_KYKM.vb, Form_f_KYKM_SUB.vb | New() | L | 必須 |
| C-2-03 | [ ] | 物件一覧検索 | Form_f_flx_BUKN.vb | New() | L | 必須 |
| C-2-04 | [ ] | 物件移動 | Form_f_IDO.vb, Form_f_IDO_SUB.vb | New() | L | 必須 |
| C-2-05 | [ ] | 物件分割 | Form_f_KYKM_BUNKATSU.vb | New() | L | 必須 |
| C-2-06 | [ ] | 物件複写 | (要調査) | - | L | 推奨 |
| C-2-07 | [ ] | 配賦管理 | Form_f_flx_D_HAIF.vb | New() | M | 必須 |

### C-3. 再リース処理

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-3-01 | [ ] | 再リース条件入力 | Form_f_SAILEASE.vb | New() | L | 必須 |
| C-3-02 | [ ] | 再リースサブ画面 | Form_f_SAILEASE_SUB.vb | New() | M | 必須 |
| C-3-03 | [ ] | 再リースExcel取込 | Form_f_IMPORT_SAILEASE_FROM_EXCEL.vb | New() | L | 必須 |

### C-4. 中途解約処理

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-4-01 | [ ] | 中途解約 | Form_f_KAIYAK.vb | New() | L | 必須 |
| C-4-02 | [ ] | 中途解約サブ | Form_f_KAIYAK_SUB.vb | New() | M | 必須 |
| C-4-03 | [ ] | 中途解約一括 | Form_f_KAIYAK_ALL.vb | New() | L | 推奨 |
| C-4-04 | [ ] | 中途解約ツール | Form_f_中途解約ツール.vb | New() | M | 推奨 |

### C-5. 注記判定・計算

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-5-01 | [ ] | 注記判定条件入力 | Form_f_CHUKI_JOKEN.vb | Form_Load, cmd_EXECUTE_Click, GenerateWhereClause, GenerateLabelText | L | 必須 |
| C-5-02 | [ ] | 注記様式（新） | Form_f_CHUKI_YOUSHIKI.vb | New() | L | 必須 |
| C-5-03 | [ ] | 注記様式（旧） | Form_f_CHUKI_YOUSHIKI_OLD.vb | New() | M | 推奨 |
| C-5-04 | [ ] | 注記集計スケジュール | Form_f_CHUKI_SCH.vb | New() | L | 必須 |
| C-5-05 | [ ] | 注記判定再計算 | Form_f_CHUKI_RECALC.vb | New() | L | 必須 |
| C-5-06 | [ ] | 注記結果フレックス一覧 | Form_f_flx_CHUKI.vb | New() | M | 必須 |

### C-6. 返済スケジュール計算

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-6-01 | [ ] | 返済スケジュール | Form_f_HEN_SCH.vb | New() | L | 必須 |
| C-6-02 | [ ] | 返済SCH条件（注記画面から） | Form_f_返済SCH_JOKEN_FROM注記判定画面.vb | New() | M | 必須 |
| C-6-03 | [ ] | 返済SCH条件（旧） | Form_f_返済SCH_JOKEN_FROM注記判定画面_OLD.vb | New() | S | 任意 |
| C-6-04 | [ ] | 年金現価の計算式 | Form_0f_MNT_tcon_年金現価の計算式.vb | New() | M | 必須 |
| C-6-05 | [ ] | 変更ファイナンス管理 | Form_f_HENF.vb | New() | L | 必須 |
| C-6-06 | [ ] | 変更リース管理 | Form_f_HENL.vb | New() | L | 必須 |

### C-7. 資産管理・償却計算

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| C-7-01 | [ ] | 別表16(4) 条件入力 | Form_f_BEPPYO2_JOKEN.vb | New() | L | 必須 |
| C-7-02 | [ ] | 別表16(4) レポート | Form_f_BEPPYO2_REP.vb | New() | L | 必須 |
| C-7-03 | [ ] | 別表16(4) フレックス | Form_f_flx_BEPPYO2.vb | New() | M | 必須 |
| C-7-04 | [ ] | 減損損失管理 | Form_f_flx_D_GSON.vb | New() | M | 推奨 |
| C-7-05 | [ ] | 減損損失Excel出力 | Form_f_減損損失取込用データEXCEL出力_JOKEN.vb | New() | M | 推奨 |
| C-7-06 | [ ] | 物件減損損失Excel出力 | Form_f_物件_減損損失取込用データEXCEL出力_JOKEN.vb | New() | M | 推奨 |

### C-8. 各種集計処理

| # | チェック | 機能 | VB.NETファイル（条件入力→結果表示） | 工数 | 優先度 |
|---|----------|------|-----------------------------------|------|--------|
| C-8-01 | [ ] | 月次支払照合 | Form_f_TOUGETSU_JOKEN → Form_f_flx_TOUGETSU | L | 必須 |
| C-8-02 | [ ] | 月次仕訳計上 | Form_f_KEIJO_JOKEN → Form_f_flx_KEIJO | L | 必須 |
| C-8-03 | [ ] | 棚卸明細表 | Form_f_TANA_JOKEN → Form_f_flx_TANA | L | 必須 |
| C-8-04 | [ ] | 期間リース料支払明細 | Form_f_KLSRYO_JOKEN → Form_f_flx_KLSRYO | L | 必須 |
| C-8-05 | [ ] | 移動物件一覧表 | Form_f_IDOLST_JOKEN → Form_f_flx_IDOLST | M | 必須 |
| C-8-06 | [ ] | 期間費用計上明細表 | Form_f_KHIYO_JOKEN → Form_f_flx_KHIYO | L | 必須 |
| C-8-07 | [ ] | 予算実績集計 | Form_f_YOSAN_JOKEN → Form_f_flx_YOSAN | L | 必須 |
| C-8-08 | [ ] | 予算実績集計（MYCOM用） | Form_f_YOSAN_JOKEN_MYCOM | M | 推奨 |
| C-8-09 | [ ] | 予算実績集計（旧） | Form_f_YOSAN_JOKEN_OLD | S | 任意 |
| C-8-10 | [ ] | リース残高一覧表 | Form_f_ZANDAKA_JOKEN → Form_f_flx_ZANDAKA | L | 必須 |
| C-8-11 | [ ] | リース債務返済明細一覧 | Form_f_SAIMU_JOKEN → Form_f_SAIMU_SCH → Form_f_flx_SAIMU | L | 必須 |
| C-8-12 | [ ] | 経費明細表 | Form_f_経費明細表_JOKEN → Form_f_flx_経費明細表 | M | 推奨 |
| C-8-13 | [ ] | 支払照合 | Form_f_支払照合.vb, Form_f_支払照合_SUB.vb | L | 必須 |
| C-8-14 | [ ] | 合算処理 | Form_f_合算.vb, Form_f_合算_SUB.vb | M | 推奨 |
| C-8-15 | [ ] | 残高スケジュール | Form_f_ZANDAKA_SCH.Designer.vb | M | 推奨 |

### C-9. 仕訳出力（標準）

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| C-9-01 | [ ] | 仕訳入力画面 | Form_JournalEntry.vb | FrmJournalEntry_Load, btnSearch_Click, btnSave_Click, SetupComboBoxColumn, ToDecimal | L | 必須 |
| C-9-02 | [ ] | 標準仕訳出力（計上） | Form_f_仕訳出力標準_KJ.vb | New() | L | 必須 |
| C-9-03 | [ ] | 標準仕訳出力（支払） | Form_f_仕訳出力標準_SH.vb | New() | L | 必須 |
| C-9-04 | [ ] | 標準仕訳出力（消費税） | Form_f_仕訳出力標準_SM.vb | New() | L | 必須 |
| C-9-05 | [ ] | 標準仕訳設定（メイン） | Form_f_仕訳出力標準_設定_MAIN.vb | New() | M | 必須 |
| C-9-06 | [ ] | 標準仕訳設定（計上） | Form_f_仕訳出力標準_設定_KJ.vb | New() | M | 必須 |
| C-9-07 | [ ] | 標準仕訳設定（支払） | Form_f_仕訳出力標準_設定_SH.vb | New() | M | 必須 |
| C-9-08 | [ ] | 標準仕訳設定（消費税） | Form_f_仕訳出力標準_設定_SM.vb | New() | M | 必須 |
| C-9-09 | [ ] | 計上区分ダイアログ | Form_f_KJKBN_DLG.vb | New() | S | 必須 |
| C-9-10 | [ ] | 振替伝票指示 | Form_f_振替伝票_SIJI.vb | New() | M | 推奨 |

### C-10. 仕訳出力（カスタム14社）

| # | チェック | 会社名 | 計上仕訳 | 支払仕訳 | 経費仕訳 | その他 | 工数(合計) | 優先度 |
|---|----------|--------|---------|---------|---------|-------|-----------|--------|
| C-10-01 | [ ] | YAMASHIN | Form_fc_計上仕訳_YAMASHIN | Form_fc_支払仕訳_YAMASHIN | - | - | L | 推奨 |
| C-10-02 | [ ] | VTC | Form_fc_計上仕訳_VTC | Form_fc_支払仕訳_VTC | - | 支払先確認, VTC_明細 | L | 推奨 |
| C-10-03 | [ ] | RISO | Form_fc_計上仕訳_RISO | Form_fc_支払仕訳_RISO | - | 仕訳出力_最終確認_RISO | L | 推奨 |
| C-10-04 | [ ] | NKSOL | Form_fc_計上仕訳_NKSOL | Form_fc_支払仕訳_NKSOL | Form_fc_経費仕訳_NKSOL | - | L | 推奨 |
| C-10-05 | [ ] | NIFS | Form_fc_計上仕訳_NIFS | - | Form_fc_経費仕訳_NIFS | - | M | 推奨 |
| C-10-06 | [ ] | MARUZEN | Form_fc_計上仕訳_MARUZEN | - | - | MARUZEN_SUB | L | 推奨 |
| C-10-07 | [ ] | KYOTO | Form_fc_計上仕訳_KYOTO | Form_fc_支払仕訳_KYOTO | - | - | L | 推奨 |
| C-10-08 | [ ] | KITOKU | Form_fc_計上仕訳_KITOKU | Form_fc_支払仕訳_KITOKU | - | KITOKU_SUB | L | 推奨 |
| C-10-09 | [ ] | JOT | Form_fc_JOT_計上仕訳 | Form_fc_JOT_支払仕訳 | - | JOT_伝票番号 | L | 推奨 |
| C-10-10 | [ ] | VALQUA | Form_fc_VALQUA_計上仕訳 | Form_fc_VALQUA_支払仕訳 | - | VALQUA_長短振替仕訳 | L | 推奨 |
| C-10-11 | [ ] | TSYSCOM | Form_fc_TSYSCOM_計上仕訳 | Form_fc_TSYSCOM_支払仕訳 | - | TSYSCOM_移動仕訳 | L | 推奨 |
| C-10-12 | [ ] | SANKO_AIR | - | 振替伝票_支払用_出力指示(5種) | - | 登録届, 登録変更願, 異動届, 振替伝票_計上用 | XL | 推奨 |
| C-10-13 | [ ] | MYCOM | Form_fc_MYCOM_仕訳出力 | - | - | 仕訳出力Sub, 会社MNT, 支払伝票印刷(3種) | XL | 推奨 |
| C-10-14 | [ ] | SNKO | Form_fc_SNKO_計上仕訳出力_JOKEN | Form_fc_SNKO_仕訳出力_JOKEN | - | 仕訳出力_JOKEN_SUB, 最終確認(2種) | L | 推奨 |

### C-11. 仕訳共通

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| C-11-01 | [ ] | 仕訳定義共通 | Form_fc_TC_SWK_DEF_COM.vb | M | 必須 |
| C-11-02 | [ ] | 配賦連動テーブル管理 | Form_fc_TC_HREL.vb | L | 必須 |
| C-11-03 | [ ] | 配賦連動予備 | Form_fc_TC_HREL_YOBI.vb | M | 推奨 |

---

## D. 帳票・レポート層

| # | チェック | 帳票名 | 条件フォーム | 結果表示フォーム | 工数 | 優先度 |
|---|----------|-------|------------|----------------|------|--------|
| D-01 | [ ] | 財務諸表注記 | Form_f_CHUKI_JOKEN | Form_f_flx_CHUKI / Form_f_CHUKI_YOUSHIKI | L | 必須 |
| D-02 | [ ] | リース残高一覧表 | Form_f_ZANDAKA_JOKEN | Form_f_flx_ZANDAKA | L | 必須 |
| D-03 | [ ] | リース債務返済明細 | Form_f_SAIMU_JOKEN | Form_f_flx_SAIMU | L | 必須 |
| D-04 | [ ] | 別表16(4) | Form_f_BEPPYO2_JOKEN | Form_f_BEPPYO2_REP / Form_f_flx_BEPPYO2 | L | 必須 |
| D-05 | [ ] | 月次支払照合表 | Form_f_TOUGETSU_JOKEN | Form_f_flx_TOUGETSU | L | 必須 |
| D-06 | [ ] | 月次仕訳計上表 | Form_f_KEIJO_JOKEN | Form_f_flx_KEIJO | L | 必須 |
| D-07 | [ ] | 棚卸明細表 | Form_f_TANA_JOKEN | Form_f_flx_TANA | L | 必須 |
| D-08 | [ ] | 期間リース料支払明細表 | Form_f_KLSRYO_JOKEN | Form_f_flx_KLSRYO | L | 必須 |
| D-09 | [ ] | 移動物件一覧表 | Form_f_IDOLST_JOKEN | Form_f_flx_IDOLST | M | 必須 |
| D-10 | [ ] | 期間費用計上明細表 | Form_f_KHIYO_JOKEN | Form_f_flx_KHIYO | L | 必須 |
| D-11 | [ ] | 予算実績集計表 | Form_f_YOSAN_JOKEN | Form_f_flx_YOSAN | L | 必須 |
| D-12 | [ ] | 経費明細表 | Form_f_経費明細表_JOKEN | Form_f_flx_経費明細表 | M | 推奨 |
| D-13 | [ ] | Excel出力機能（共通） | FileHelper.vb | ToExcelFile() | M | 必須 |
| D-14 | [ ] | CSV出力機能（共通） | FileHelper.vb | ToCsvFile() | M | 必須 |
| D-15 | [ ] | 固定長ファイル出力（共通） | FileHelper.vb | ToFixedLengthFile() ※未完成 | M | 推奨 |

---

## E. データ取込・連携

### E-1. Excel取込

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| E-1-01 | [ ] | 取込メイン画面 | Form_f_IMPORT.vb | L | 必須 |
| E-1-02 | [ ] | 契約書変更情報Excel取込 | Form_f_IMPORT_CONTRACT_FROM_EXCEL.vb | L | 必須 |
| E-1-03 | [ ] | 物件移動Excel取込 | Form_f_IMPORT_IDO_FROM_EXCEL.vb | L | 必須 |
| E-1-04 | [ ] | 再リース/返却Excel取込 | Form_f_IMPORT_SAILEASE_FROM_EXCEL.vb | L | 必須 |
| E-1-05 | [ ] | 減損損失Excel取込 | Form_f_IMPORT_GSON_FROM_EXCEL.vb | L | 推奨 |
| E-1-06 | [ ] | 取込最終確認 | Form_f_IMPORT_最終確認.vb | M | 必須 |
| E-1-07 | [ ] | 取込最終確認サブ（MST） | Form_f_IMPORT_最終確認_SUB_MST.vb | M | 必須 |
| E-1-08 | [ ] | 取込最終確認サブ（KYKH） | Form_f_IMPORT_最終確認_SUB_KYKH.vb | M | 必須 |
| E-1-09 | [ ] | 取込ログ | Form_f_IMPORT_LOG.vb | M | 推奨 |
| E-1-10 | [ ] | 更新解約取込 | Form_f_更新解約取込.vb | L | 推奨 |
| E-1-11 | [ ] | 更新解約取込ログ | Form_f_更新解約取込_LOG.vb | M | 推奨 |

### E-2. マスタ取込

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| E-2-01 | [ ] | 部署マスタ取込 | Form_f_部署取込.vb | M | 推奨 |
| E-2-02 | [ ] | 部署マスタ一括取込 | Form_f_M_BCAT_IMPORT.vb | M | 推奨 |
| E-2-03 | [ ] | 配賦予備1マスタ取込(1) | Form_f_M_RSRVH1_IMPORT_1.vb | M | 推奨 |
| E-2-04 | [ ] | 配賦予備1マスタ取込(2) | Form_f_M_RSRVH1_IMPORT_2.vb | M | 推奨 |

### E-3. バックアップ/復元

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| E-3-01 | [ ] | バックアップパスワード | Form_f_BKUP_PASSWORD.vb | M | 推奨 |
| E-3-02 | [ ] | 復元パスワード | Form_f_RESTORE_PASSWORD.vb | M | 推奨 |

---

## F. システム管理

### F-1. ログイン/認証

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| F-1-01 | [ ] | ログイン（JET） | Form_f_LOGIN_JET.vb | M | 必須 |
| F-1-02 | [ ] | ログイン（Oracle） | Form_f_LOGIN_ORACLE.vb | M | 任意 |
| F-1-03 | [ ] | パスワード変更 | Form_f_CHANGE_PASSWORD.vb | M | 必須 |

### F-2. ログ管理

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| F-2-01 | [ ] | セッションログ一覧 | Form_f_00SLOG.vb | M | 必須 |
| F-2-02 | [ ] | セッションログ条件 | Form_f_00SLOG_JOKEN.vb | M | 必須 |
| F-2-03 | [ ] | セッションログ明細 | Form_f_00SLOG_M.vb | M | 必須 |
| F-2-04 | [ ] | 更新ログ一覧 | Form_f_00ULOG.vb | M | 必須 |
| F-2-05 | [ ] | 更新ログ条件 | Form_f_00ULOG_JOKEN.vb | M | 必須 |
| F-2-06 | [ ] | 更新ログ明細 | Form_f_00ULOG_M.vb | M | 必須 |
| F-2-07 | [ ] | バックアップログ | Form_f_00BKLOG.vb | M | 推奨 |
| F-2-08 | [ ] | ログ削除 | Form_f_00LOGDEL.vb | M | 推奨 |
| F-2-09 | [ ] | 前回集計ログ | Form_f_ZENKAI_LOG.vb | M | 推奨 |

### F-3. セキュリティ管理

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| F-3-01 | [ ] | ユーザー一覧 | Form_f_flx_SEC_USER.vb | M | 必須 |
| F-3-02 | [ ] | ユーザー登録 | Form_f_SEC_USER_INP.vb | M | 必須 |
| F-3-03 | [ ] | 権限一覧 | Form_f_flx_SEC_KNGN.vb | M | 必須 |
| F-3-04 | [ ] | 権限登録 | Form_f_SEC_KNGN_INP.vb | M | 必須 |
| F-3-05 | [ ] | 権限登録サブ | Form_f_SEC_KNGN_INP_SUB.vb | M | 必須 |
| F-3-06 | [ ] | 権限登録サブ（物件分類別） | Form_f_SEC_KNGN_INP_B_SUB.vb | M | 必須 |

### F-4. システム設定

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| F-4-01 | [ ] | SYSTEM管理 | Form_0F_SYSTEM.vb | M | 必須 |
| F-4-02 | [ ] | SYSTEM管理（管理者用） | Form_0F_SYSTEM管理.vb | M | 必須 |
| F-4-03 | [ ] | システムオプション | Form_f_00SystemOPT.vb | M | 必須 |
| F-4-04 | [ ] | データパス設定 | Form_f_00DataPass.vb | M | 推奨 |
| F-4-05 | [ ] | バージョン情報 | Form_f_00VerInfo.vb | S | 推奨 |
| F-4-06 | [ ] | 設定画面 | Form_f_SETTEI.vb | M | 必須 |
| F-4-07 | [ ] | 切替画面 | Form_f_KIRIKAE.vb | M | 推奨 |
| F-4-08 | [ ] | リンク確認 | Form_f_LINK_KAKUNIN.vb | M | 推奨 |

### F-5. マスタメンテナンス（テーブル管理）

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| F-5-01 | [ ] | 追加借入利子率テーブル | Form_f_T_KARI_RITU.vb, _INP.vb, _CHANGE.vb | M | 必須 |
| F-5-02 | [ ] | 消費税率テーブル | Form_f_T_ZEI_KAISEI.vb, _INP.vb, _CHANGE.vb | M | 必須 |
| F-5-03 | [ ] | 休日テーブル | Form_f_T_HOLIDAY.vb | M | 推奨 |
| F-5-04 | [ ] | 契約番号採番 | Form_f_T_KYKBNJ_SEQ.vb | M | 必須 |
| F-5-05 | [ ] | 税率変更ツール | Form_f_税率変更ツール.vb | M | 推奨 |
| F-5-06 | [ ] | 一括削除（条件指定） | Form_0f_一括削除_JOKEN.vb | M | 推奨 |

### F-6. 開発・管理ツール

| # | チェック | 機能 | VB.NETファイル | 工数 | 優先度 |
|---|----------|------|---------------|------|--------|
| F-6-01 | [ ] | 開発ツール | Form_f_0開発ツール.vb | M | 任意 |
| F-6-02 | [ ] | 説明表示 | Form_f_説明表示.vb | S | 任意 |
| F-6-03 | [ ] | ステータスメーター | Form_f_StatusMeter.vb | S | 推奨 |
| F-6-04 | [ ] | Dummy(DoEvents用) | Form_f_Dummy.vb, Form_f_Dummy2.vb, Form_f_Dummy_DoEvents_1000msec.vb | S | 任意 |

---

## G. 共通機能（データアクセス層・ユーティリティ）

### G-1. データアクセス基盤（LeaseM4BS.DataAccess プロジェクト）

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| G-1-01 | [x] | DB接続管理 | DbConnectionManager.vb | GetConnection(), GetConnectionString(), TestConnection() | 済 | 必須 |
| G-1-02 | [x] | CRUD操作ヘルパー | CrudHelper.vb | GetDataTable(), ExecuteNonQuery(), ExecuteScalar(), Insert(), Update(), Delete(), Exists() | 済 | 必須 |
| G-1-03 | [x] | トランザクション管理 | CrudHelper.vb | BeginTransaction(), Commit(), Rollback(), IsInTransaction | 済 | 必須 |
| G-1-04 | [ ] | エラーハンドリング | CrudHelper.vb | CreateErrorMessage() | 済 | 必須 |
| G-1-05 | [ ] | 使用例 | UsageExamples.vb | - | S | 任意 |

### G-2. 共通ユーティリティ関数

| # | チェック | 機能 | VB.NETファイル | 主要関数 | 工数 | 優先度 |
|---|----------|------|---------------|---------|------|--------|
| G-2-01 | [x] | Null安全変換 | Utils.vb | NzInt(), NzDate(), NzDec(), ToCurrency() | 済 | 必須 |
| G-2-02 | [x] | 日付ユーティリティ | UtilDate.vb | GetDuration(), GetMonthStart(), GetMonthEnd(), ToDateStr() | 済 | 必須 |
| G-2-03 | [x] | コントロールユーティリティ | UtilControl.vb | HandleEnterKeyNavigation(), SwapIf() | 済 | 必須 |
| G-2-04 | [x] | フォームヘルパー | FormHelper.vb | Bind(), AdjustSize(), SyncTo(), HideColumns(), FormatColumn(), GetSelectedRow(), Combo_DrawItem(), SyncDgvScroll(), SyncDgvColumnWidths(), SetText(), SetAmount() | 済 | 必須 |
| G-2-05 | [x] | ファイル出力ヘルパー | FileHelper.vb | ToExcelFile(), ToCsvFile(), ToFixedLengthFile(), PadRightByte() | 済 | 必須 |
| G-2-06 | [x] | カレンダー列 | CalendarColumn.vb | - | 済 | 推奨 |

### G-3. 未実装・要追加の共通機能

| # | チェック | 機能 | 説明 | 工数 | 優先度 |
|---|----------|------|------|------|--------|
| G-3-01 | [ ] | 定数定義モジュール | Access版の定数をVB.NET Moduleに集約 | M | 必須 |
| G-3-02 | [ ] | グローバルエラーハンドリング | Application.ThreadException等の共通処理 | M | 必須 |
| G-3-03 | [ ] | メッセージ管理 | エラー・確認メッセージの集中管理 | M | 推奨 |
| G-3-04 | [ ] | セッション管理 | ログインユーザー情報の保持 | M | 必須 |
| G-3-05 | [ ] | 権限チェック機能 | sec_kngn テーブルに基づくアクセス制御 | L | 必須 |
| G-3-06 | [ ] | ログ記録共通処理 | l_slog, l_ulog への書き込み共通化 | M | 必須 |
| G-3-07 | [ ] | 採番処理 | t_seq テーブルによるID自動採番 | M | 必須 |
| G-3-08 | [ ] | 楽観的排他制御 | update_cnt によるレコードロック | M | 必須 |
| G-3-09 | [ ] | 印刷制御 | WinForms印刷プレビュー・印刷処理 | L | 推奨 |

---

## H. 工数サマリ

| カテゴリ | 項目数 | 推定工数 |
|---------|-------|---------|
| A. データベース層 | 48項目 | 40〜50人日 |
| B. 画面（UI層） | 約90フォーム | 150〜200人日 |
| C. ビジネスロジック層 | 約80機能 | 200〜280人日 |
| D. 帳票・レポート層 | 15項目 | 40〜50人日 |
| E. データ取込・連携 | 15項目 | 30〜40人日 |
| F. システム管理 | 30項目 | 40〜50人日 |
| G. 共通機能 | 15項目（うち6済） | 20〜30人日 |
| **合計** | **約293項目** | **520〜700人日** |

### 済み（実装済み）の項目

- DbConnectionManager.vb (DB接続管理)
- CrudHelper.vb (CRUD操作)
- Utils.vb (Null安全変換)
- UtilDate.vb (日付ユーティリティ)
- UtilControl.vb (コントロールユーティリティ)
- FormHelper.vb (フォームヘルパー)
- FileHelper.vb (ファイル出力)
- CalendarColumn.vb (カレンダー列)
- Form_JournalEntry.vb (仕訳入力 - ロジック実装済み)
- Form_f_CHUKI_JOKEN.vb (注記条件入力 - ロジック実装済み)
- Form_MAIN.vb (メインメニュー - ナビゲーション実装済み)
- sql/001_create_tables.sql (DDL定義済み)
- 各フォームのDesigner.vb (コントロール配置済み)

### スタブ状態（フォーム枠のみ、ロジック未実装）の項目

大多数のフォーム（約250件）は `New()` + `InitializeComponent()` のみのスタブ状態。
Designer.vb でコントロール配置は済んでいるが、イベントハンドラ・ビジネスロジックの実装が必要。

---

## I. 推奨移行順序

### Phase 1: 基盤（1〜2ヶ月）
1. G-3: 共通機能の未実装分（定数, エラー処理, セッション, 権限, ログ, 採番）
2. F-1: ログイン/認証
3. F-4: システム設定

### Phase 2: コア業務（3〜5ヶ月）
4. C-1: 契約管理（新規/変更/削除/照会）
5. C-2: 物件管理（移動/分割）
6. C-5: 注記判定・計算
7. C-6: 返済スケジュール計算
8. B-8: マスタメンテナンス（必須マスタ10種）

### Phase 3: 月次・決算（2〜3ヶ月）
9. C-8: 各種集計処理（月次支払照合, 仕訳計上, 棚卸 等）
10. C-9: 仕訳出力（標準）
11. D: 帳票・レポート（主要7帳票）

### Phase 4: 拡張（2〜3ヶ月）
12. C-3: 再リース処理
13. C-4: 中途解約処理
14. C-7: 資産管理・償却計算
15. E: データ取込・連携

### Phase 5: カスタム（2〜3ヶ月）
16. C-10: 仕訳出力（カスタム14社）
17. B-8: マスタメンテナンス（推奨マスタ）
18. F-2, F-3: ログ管理・セキュリティ管理の完成

---

*本チェックリストはプロジェクト内の全562 VBファイル、DDL定義48テーブル、107カスタムフォームを調査の上作成*
