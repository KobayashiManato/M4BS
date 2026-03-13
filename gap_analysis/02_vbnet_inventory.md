# VB.NET版 全機能棚卸調査レポート

調査日: 2026-03-13
調査対象: /c/project_lease_migration/

---

## 1. プロジェクト構成

### ソリューション構成

ソリューションファイル(.sln)は存在しない。プロジェクトファイル(.vbproj)が複数存在。

### プロジェクト一覧と役割

| プロジェクト | パス | 役割 |
|---|---|---|
| LeaseM4BS.DataAccess | LeaseM4BS/LeaseM4BS.DataAccess/ | データアクセス層（PostgreSQL接続、CRUD操作） |
| LeaseM4BS.TestWinForms | LeaseM4BS.TestWinForms/LeaseM4BS.TestWinForms/ | WinFormsメインプロジェクト（画面、ヘルパー） |
| LeaseM4BS.DataAccess (コピー) | LeaseM4BS/LeaseM4BS/LeaseM4BS.DataAccess/ | DataAccessの重複コピー |
| LeaseM4BS.TestWinForms (コピー) | LeaseM4BS/LeaseM4BS.TestWinForms/LeaseM4BS.TestWinForms/ | TestWinFormsの重複コピー |

注記: LeaseM4BS/ ディレクトリ内にプロジェクトが二重に存在する。また「（没）LeaseM4BS.DataAccess.vbproj」という没ファイルも存在する。

---

## 2. 画面（Form）一覧

### 2.1 主要画面（ロジック実装済み）-- 約20画面

| ファイル名 | 画面名 | 実装状況 | 推定行数 | 主なメソッド/ハンドラ |
|---|---|---|---|---|
| Form1.vb | DB接続テスト画面 | 完全実装 | 282 | btnConnect_Click, btnLoadData_Click, btnExecute_Click, btnCrudTest_Click, btnTransactionTest_Click |
| Form_MAIN.vb | メインメニュー画面 | 完全実装 | 306 | 約30個のメニューClickハンドラ（台帳/月次/期間/決算/マスタ/一括更新タブ） |
| Form_ContractEntry.vb | 契約書入力画面 | 完全実装 | 900+ | FrmContractEntry_Load, SetupGridColumns, BindCombos, LoadContractById, ClearScreen, 保存/削除処理 |
| Form_BuknEntry.vb | 物件入力画面 | ロジック実装済み | 380 | FrmBuknEntry_Load, BindCombos, LoadBuknById, AddFirstHaif, AddHaif, RemoveHaif, ReCalculateRowAmounts, コンボ連動多数 |
| Form_JournalEntry.vb | 仕訳入力画面 | 完全実装 | 133 | FrmJournalEntry_Load, SetupComboBoxColumn, btnSearch_Click, btnSave_Click (トランザクション対応) |
| Form_f_flx_CONTRACT.vb | 契約書フレックス一覧 | 完全実装 | 160 | Load, SearchData (複合JOIN SQL), cmd_SEARCH/CLOSE/NEW/REF_Click, dgv_LIST_CellDoubleClick |
| Form_f_flx_BUKN.vb | 物件フレックス一覧 | 完全実装 | 183 | Load, SearchData (9テーブルJOIN SQL), cmd_SEARCH/CLOSE/CHANGE/CHANGE_BUKN/REF_Click, DoubleClick |
| Form_f_flx_M_CORP.vb | 会社マスタ一覧 | 完全実装 | 107 | Load, SearchData, BuildSql, cmd_SEARCH/CLOSE/NEW/CHANGE/OUTPUT_FILE_Click |
| Form_f_flx_M_LCPT.vb | 支払先マスタ一覧 | 完全実装 | 121 | Load, SearchData, BuildSql, cmd_SEARCH/CLOSE/NEW/CHANGE/OUTPUT_FILE_Click |
| Form_f_flx_M_KKNRI.vb | 契約管理単位マスタ一覧 | 完全実装 | 109 | Load, SearchData, BuildSql, cmd_SEARCH/CLOSE/NEW/CHANGE/OUTPUT_FILE_Click |
| Form_f_M_CORP_INP.vb | 会社マスタ新規入力 | 完全実装 | 54 | cmd_CLOSE_Click, cmd_CREATE_Click (INSERT処理) |
| Form_f_M_CORP_CHANGE.vb | 会社マスタ変更 | 完全実装 | 104 | Load (データロード), cmd_CREATE_Click (UPDATE), cmd_DELETE_Click (DELETE) |
| Form_f_M_LCPT_INP.vb | 支払先マスタ新規入力 | 完全実装 | 132 | Load, cmd_CREATE_Click (INSERT), コンボ連動多数 |
| Form_LCPT.vb | 支払先ベースクラス | 完全実装 | 51 | LoadLcptCombo, LoadSumCombos (継承用共通メソッド) |
| Form_f_CHUKI_SCH.vb | 注記スケジュール | ロジック実装済み | 323 | Load, LoadKykmDetails, BuildSql (UNION ALL動的生成), ApplyGridStyle, LoadDgvTotal, CalcKlsryo, CalcGhassei, 印刷処理 |
| Form_f_flx_KEIJO.vb | 月次計上フレックス | 一部実装 | 149 | Load, SearchData, BuildSql (多テーブルJOIN、todoコメント多数), cmd_CLOSE/RECALCULATE/REF/OUTPUT_FILE_Click |
| Form_f_flx_TOUGETSU.vb | 月次支払照合フレックス | 一部実装 | 110 | Load, SearchData, BuildSql (多テーブルJOIN、todoコメント多数), cmd_CLOSE/RECALCULATE/OUTPUT_FILE_Click |
| Form_f_TOUGETSU_JOKEN.vb | 月次計上条件指定 | 一部実装 | 84 | cmd_EXECUTE/CANCEL/HOLIDAY/ZENKAI_Click, GetLabelText |
| Form_f_KEIJO_JOKEN.vb | 月次支払照合条件指定 | 一部実装 | 82 | Load, DATE_ValueChanged, cmd_EXECUTE/CANCEL/ZENKAI_Click, GetLabelText |
| Form_f_FlexOutputDLG.vb | ファイル出力ダイアログ | 完全実装 | 37 | Load (列一覧読み込み), cmd_EXECUTE_Click (Excel/CSV/固定長) |

### 2.2 スタブのみの画面（コンストラクタ+InitializeComponent()のみ）-- 約160画面

以下の画面は全てクラス定義とコンストラクタのみで、ビジネスロジックは未実装（約10行）。
ただし、対応する Designer.vb にはUI配置定義が存在する。

**データ入力系（スタブ）: 22画面**
- Form_f_KYKH.vb（契約書ヘッダ）、Form_f_KYKM.vb（物件明細）
- Form_f_KYKH_SUB.vb、Form_f_KYKM_SUB.vb、Form_f_KYKM_BKN.vb、Form_f_KYKM_BUNKATSU.vb
- Form_f_KYKM_CHUUKI.vb、Form_f_KYKM_CHUUKI_SUB_GSON.vb、Form_f_KYKM_CHUUKI_拡張設定.vb、Form_f_KYKM_SUB_BKN.vb
- Form_f_HENF.vb、Form_f_HENL.vb、Form_f_HEN_SCH.vb
- Form_f_IDO.vb、Form_f_IDO_SUB.vb、Form_f_KAIYAK.vb、Form_f_KAIYAK_SUB.vb、Form_f_KAIYAK_ALL.vb
- Form_f_SAILEASE.vb、Form_f_SAILEASE_SUB.vb、Form_f_KIRIKAE.vb、Form_f_LINK_KAKUNIN.vb

**参照系（スタブ）: 9画面**
- Form_f_REF_D_KYKH.vb/SUB.vb、Form_f_REF_D_KYKM.vb/CHUUKI.vb/CHUUKI_SUB_GSON.vb/拡張設定.vb/SUB.vb
- Form_f_REF_D_HENF.vb、Form_f_REF_D_HENL.vb

**フレックス一覧系（スタブ）: 約20画面**
- Form_f_flx_D_KYKH/KYKM/KYKM_BKN/HAIF/HAIF_SNKO/HENF/GSON.vb
- Form_f_flx_IDOLST/CHUKI/SAIMU/TANA/ZANDAKA/YOSAN/BEPPYO2/KHIYO/KLSRYO/経費明細表.vb

**マスタ一覧系（スタブ）: 約18画面**
- Form_f_flx_M_BCAT/BKIND/BKNRI/GENK/GSHA/HKHO/HKMK/KOZA/MCPT/LCPT_MYCOM.vb
- Form_f_flx_M_RSRVB1/RSRVH1/RSRVK1/SHHO/SKMK/SWPTN/SEC_KNGN/SEC_USER.vb

**マスタ入力/変更系（スタブ）: 約30画面**
- 部署、物件種別、物件分類、原価区分、業者、廃棄方法、費用区分、契約管理単位
- 銀行口座、メーカー、予備マスタ、支払方法、集計区分、仕訳パターンのINP/CHANGE画面

**帳票条件/スケジュール系（スタブ）: 約15画面**
- 別表16、注記、移動一覧、費用、リース料、債務、棚卸、予算、残高、経費明細表、返済スケジュール

**インポート系（スタブ）: 約10画面**
- Excel取込（契約書、減損、移動、再リース）、インポートログ、最終確認画面

**仕訳出力系（スタブ）: 約45画面**
- 標準仕訳出力（KJ/SH/SM）、設定画面
- 顧客別カスタム: JOT、MYCOM、SANKO_AIR、SNKO、TSYSCOM、VALQUA、KITOKU、KYOTO、NKSOL、RISO、VTC、YAMASHIN、MARUZEN、NIFS

**その他（スタブ）: 約25画面**
- Switchboard、システム設定、ログ管理、パスワード管理、検索/ソート/レポートダイアログ
- セキュリティ（ログイン、権限管理）、ダミー画面、開発ツール

---

## 3. データアクセス層

### 3.1 CrudHelper.vb（458行）-- 完全実装

PostgreSQL (Npgsql) に対する汎用CRUD操作ヘルパークラス。IDisposable実装。

| メソッド | 機能 | 実装状況 |
|---|---|---|
| GetDataTable() | SELECT結果をDataTableで返す | 完全実装 |
| ExecuteNonQuery() | INSERT/UPDATE/DELETE実行 | 完全実装 |
| ExecuteScalar(Of T)() | 単一値取得（NULL安全） | 完全実装 |
| SafeConvert(Of T)() | DB値の安全型変換 | 完全実装 |
| Insert() | Dictionary指定のINSERT | 完全実装 |
| Update() | Dictionary指定のUPDATE (WHERE必須) | 完全実装 |
| Delete() | WHERE指定のDELETE (WHERE必須) | 完全実装 |
| Exists() | レコード存在チェック | 完全実装 |
| BeginTransaction() | トランザクション開始 | 完全実装 |
| Commit() | コミット | 完全実装 |
| Rollback() | ロールバック | 完全実装 |
| IsInTransaction | トランザクション進行中チェック | 完全実装 |

### 3.2 DbConnectionManager.vb（200行）-- 完全実装

PostgreSQL接続管理クラス。IDisposable実装。

| メソッド | 機能 | 実装状況 |
|---|---|---|
| GetConnectionString() | App.config / 環境変数 / デフォルトから接続文字列取得 | 完全実装 |
| GetConnection() | NpgsqlConnection取得・Open | 完全実装 |
| TestConnection() | 接続テスト | 完全実装 |
| GetMaskedConnectionString() | パスワードマスク済み接続文字列取得 | 完全実装 |
| WriteError() | 簡易エラーログ書き出し | 完全実装 |

### 3.3 UsageExamples.vb（405行）-- 完全実装（サンプルコード集）

DAO から Npgsql への移行パターンを網羅した15個の使用例を提供。

---

## 4. ビジネスロジック

### 4.1 実装済みのビジネスロジック

| 場所 | 内容 | 実装状況 |
|---|---|---|
| Form_ContractEntry.vb | 契約書の新規登録・編集・保存・削除、明細グリッド操作 | ロジック実装済み |
| Form_BuknEntry.vb | 物件の閲覧・コンボ連動、配賦率計算・追加/削除 | ロジック実装済み（保存処理はtodo） |
| Form_JournalEntry.vb | 仕訳の検索・新規登録・更新（トランザクション対応） | 完全実装 |
| Form_f_CHUKI_SCH.vb | 注記スケジュール計算（月別リース料動的生成、集計行、印刷） | 一部実装（todoあり） |
| Form_f_flx_KEIJO.vb | 月次計上一覧のSQL構築（10テーブルJOIN） | 一部実装（計算列にtodo多数） |
| Form_f_flx_TOUGETSU.vb | 月次支払照合一覧のSQL構築（9テーブルJOIN） | 一部実装（計算列にtodo多数） |

### 4.2 未実装のビジネスロジック（スタブのみ）

- 解約処理、物件移動、再リース、リース債務返済、リース残高一覧
- 棚卸明細、予算実績、別表16（税務申告書）
- 仕訳出力（全顧客カスタム仕訳40+画面）
- インポート（Excel取込系5画面）
- セキュリティ（ログイン、権限管理）
- マスタメンテナンス（会社・支払先・管理単位以外の全マスタ）

---

## 5. SQL定義

### 5.1 001_create_tables.sql -- 55テーブル定義

generate_ddl.py により Access DBスキーマから自動生成されたPostgreSQL DDL。

- コードテーブル（C_*）: 10テーブル -- c_chuum, c_chu_hnti, c_kjkbn, c_kjtaisyo, c_kkbn, c_leakbn, c_rcalc, c_settei_idfld, c_skyak_ho, c_szei_kjkbn
- マスタテーブル（M_*）: 19テーブル -- m_bcat, m_bkind, m_bknri, m_corp, m_genk, m_gsha, m_hkho, m_hkmk, m_kknri, m_koza, m_lcpt, m_mcpt, m_rsrvb1, m_rsrvh1, m_rsrvk1, m_shho, m_skmk, m_skti, m_swptn
- データテーブル（D_*）: 6テーブル -- d_gson, d_haif, d_henf, d_henl, d_kykh, d_kykm
- セキュリティテーブル（SEC_*）: 4テーブル -- sec_kngn, sec_kngn_bknri, sec_kngn_kknri, sec_user
- システムテーブル（T_*）: 12テーブル -- t_db_version, t_holiday, t_kari_ritu, t_kykbnj_seq, t_mstk, t_opt, t_seq, t_swk_nm, t_system, t_szei_kmk, t_zei_kaisei
- ログテーブル（L_*）: 3テーブル -- l_bklog, l_slog, l_ulog
- トランザクションテーブル（TC_*）: 2テーブル -- tc_hrel, tc_rec_shri

DDLにはインデックス定義、テーブルコメントも含まれる。

### 5.2 generate_ddl.py（314行）

Access DBのスキーマJSONからPostgreSQL DDLを自動生成するPythonスクリプト。

---

## 6. ヘルパー・ユーティリティ

### 6.1 FormHelper.vb（195行）-- 完全実装
ComboBox.Bind(), SyncTo(), HideColumns(), FormatColumn(), GetSelectedRow(), Combo_DrawItem(Access風3列描画), SyncDgvScroll(), SetText(), SetAmount()

### 6.2 FileHelper.vb（176行）-- 一部実装
ToExcelFile()(完全), ToCsvFile()(完全), ToFixedLengthFile()(未完成)

### 6.3 CalendarColumn.vb（153行）-- 完全実装
DataGridView内DateTimePicker列のカスタムコントロール群

### 6.4 Utils.vb（47行）-- 完全実装
NzInt(), NzDate(), NzDec(), ToCurrency()

### 6.5 UtilControl.vb（63行）-- 完全実装
HandleEnterKeyNavigation(), SwapIf()

### 6.6 UtilDate.vb（51行）-- 完全実装
GetDuration(), GetMonthStart(), GetMonthEnd(), ToDateStr()

---

## 7. 実装充実度の評価

### 7.1 サマリー

| カテゴリ | 合計ファイル数 | 完全実装 | 一部実装 | スタブのみ |
|---|---|---|---|---|
| データアクセス層 | 3 | 3 | 0 | 0 |
| ヘルパー/ユーティリティ | 6 | 5 | 1 | 0 |
| 主要入力画面 | 5 | 3 | 2 | 0 |
| フレックス一覧（実装済み） | 5 | 5 | 0 | 0 |
| 条件指定画面（実装済み） | 2 | 0 | 2 | 0 |
| マスタINP/CHANGE（実装済み） | 3 | 3 | 0 | 0 |
| スタブのみの画面 | 約160 | 0 | 0 | 約160 |
| SQL | 2 | 2 | 0 | 0 |

### 7.2 カテゴリ別実装率

| カテゴリ | 実装率 |
|---|---|
| データアクセス層 | 100% |
| SQL/DB設計 | 100% |
| ヘルパー・ユーティリティ | 95% |
| メイン画面/ナビゲーション | 100% |
| 契約書関連 | 60% |
| 物件関連 | 50% |
| 仕訳関連 | 30% |
| マスタメンテナンス | 15%（19マスタ中3件実装） |
| 月次処理 | 20% |
| 決算処理 | 5% |
| 解約/移動/再リース | 0% |
| インポート/エクスポート | 10% |
| セキュリティ | 0% |
| ログ/監査 | 0% |

### 7.3 全体実装率

**推定全体実装率: 約15-20%**

**実装済みの部分:**
- データアクセス基盤（CrudHelper/DbConnectionManager）-- 堅牢で本格的
- DB設計（55テーブルDDL）-- 完成
- 基本的なCRUD画面パターン（一覧->詳細->登録/変更/削除）の実証
- UI基盤ヘルパー（コンボバインド、コンボ描画、グリッド操作等）

**未実装の部分:**
- 約160画面のビジネスロジック（全てスタブ）
- リース計算のコアロジック（元本・利息計算、減価償却、残高計算等）
- 顧客別カスタム仕訳出力（40+画面）
- セキュリティ（認証・認可）
- データインポート機能
- 帳票印刷（注記スケジュールの骨格以外）
