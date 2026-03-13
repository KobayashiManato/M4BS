# Access版VBAシステム 全機能棚卸調査

> **調査対象**: LeaseM4BS (リース資産管理システム)
> **調査日**: 2026-03-13
> **ソース**: `C:\project_lease_migration\LeaseM4BS.TestWinForms\` (VB.NET移行後) + `sql\001_create_tables.sql` (DDL)
> **備考**: 元のAccess VBAコードは既にVB.NET WinFormsに変換済み。本調査はその変換後コードおよびDDLを基に、元Access版の全機能を網羅的にリストアップする。

---

## 1. 画面（Form）一覧

### 1.1 メイン画面・ナビゲーション

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 1 | Form_MAIN | メインメニュー | メニュー/ナビゲーション | 全機能への入口。台帳/月次/期間/決算/マスタ/一括更新タブ |
| 2 | Form_Switchboard | スイッチボード | ナビゲーション | メニュー切替 |
| 3 | Form_0F_SYSTEM | システム情報 | 照会 | システム設定表示 |
| 4 | Form_0F_SYSTEM管理 | システム管理 | 設定 | システム管理者用 |
| 5 | Form_f_0開発ツール | 開発ツール | ユーティリティ | 開発者用ツール |

### 1.2 台帳系画面 - 契約書

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 主要メソッド数 |
|---|-----------|---------------------|---------|--------------|
| 6 | Form_ContractEntry | 契約書入力 | CRUD | cmd_CREATE, cmd_REVISE, cmd_SAILEASE, cmd_KAIYAKU, cmd_ROLLBACK_SAI, cmd_DELETE, cmd_取込 |
| 7 | Form_f_KYKH | 契約ヘッダ | 照会/入力 | スタブ |
| 8 | Form_f_KYKH_SUB | 契約ヘッダ詳細 | サブ画面 | スタブ |
| 9 | Form_f_flx_CONTRACT | 契約書フレックス一覧 | 照会 | フレックス検索 |
| 10 | Form_f_flx_D_KYKH | 契約ヘッダフレックス | 照会 | フレックス検索 |
| 11 | Form_f_REF_D_KYKH | 契約ヘッダ参照 | 照会 | 読取専用 |
| 12 | Form_f_REF_D_KYKH_SUB | 契約ヘッダ参照詳細 | 照会 | 読取専用 |

### 1.3 台帳系画面 - 物件

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 13 | Form_BuknEntry | 物件入力 | CRUD | cmd_KJHNTI, cmd_MAINTANANCECOST, cmd_CHANGE, cmd_DEVIDE, cmd_COPYZ, cmd_COPYA, cmd_DELETE, cmd_ADD_HAIF |
| 14 | Form_f_KYKM | 物件明細 | 照会/入力 | スタブ |
| 15 | Form_f_KYKM_SUB | 物件明細詳細 | サブ画面 | スタブ |
| 16 | Form_f_KYKM_BKN | 物件分割 | 入力 | 物件の分割処理 |
| 17 | Form_f_KYKM_SUB_BKN | 物件分割詳細 | サブ画面 | スタブ |
| 18 | Form_f_KYKM_BUNKATSU | 物件分割 | 入力 | 分割処理 |
| 19 | Form_f_KYKM_CHUUKI | 物件注記 | 入力 | 注記情報 |
| 20 | Form_f_KYKM_CHUUKI_SUB_GSON | 物件注記（減損サブ） | サブ画面 | 減損注記 |
| 21 | Form_f_KYKM_CHUUKI_拡張設定 | 物件注記拡張設定 | 設定 | 注記拡張 |
| 22 | Form_f_flx_BUKN | 物件フレックス一覧 | 照会 | フレックス検索 |
| 23 | Form_f_flx_D_KYKM | 物件明細フレックス | 照会 | フレックス検索 |
| 24 | Form_f_flx_D_KYKM_BKN | 物件分割フレックス | 照会 | フレックス検索 |
| 25 | Form_f_REF_D_KYKM | 物件明細参照 | 照会 | 読取専用 |
| 26 | Form_f_REF_D_KYKM_SUB | 物件明細参照詳細 | 照会 | 読取専用 |
| 27 | Form_f_REF_D_KYKM_CHUUKI | 物件注記参照 | 照会 | 読取専用 |
| 28 | Form_f_REF_D_KYKM_CHUUKI_SUB_GSON | 物件注記（減損）参照 | 照会 | 読取専用 |
| 29 | Form_f_REF_D_KYKM_CHUUKI_拡張設定 | 物件注記拡張設定参照 | 照会 | 読取専用 |

### 1.4 台帳系画面 - 配賦・変更・減損

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 30 | Form_f_flx_D_HAIF | 配賦フレックス | 照会 | 配賦行単位 |
| 31 | Form_f_flx_D_HAIF_SNKO | 配賦フレックス（戦考） | 照会 | 配賦行単位 |
| 32 | Form_f_flx_D_HENF | 変更ファイナンスフレックス | 照会 | 保守/変更リース |
| 33 | Form_f_flx_D_GSON | 減損フレックス | 照会 | 減損情報 |
| 34 | Form_f_HENF | 変更ファイナンス入力 | 入力 | 保守料変更 |
| 35 | Form_f_HENL | 変更リース入力 | 入力 | リース条件変更 |
| 36 | Form_f_HEN_SCH | 変更スケジュール | 照会 | 変更一覧 |
| 37 | Form_f_REF_D_HENF | 変更ファイナンス参照 | 照会 | 読取専用 |
| 38 | Form_f_REF_D_HENL | 変更リース参照 | 照会 | 読取専用 |

### 1.5 物件移動・解約・再リース

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 39 | Form_f_IDO | 物件移動 | 入力 | 部署間移動処理 |
| 40 | Form_f_IDO_SUB | 物件移動詳細 | サブ画面 | 移動詳細 |
| 41 | Form_f_flx_IDOLST | 移動物件フレックス一覧 | 照会 | フレックス検索 |
| 42 | Form_f_IDOLST_JOKEN | 移動物件一覧条件 | 検索条件 | 期間指定 |
| 43 | Form_f_KAIYAK | 解約 | 入力 | 中途解約処理 |
| 44 | Form_f_KAIYAK_ALL | 一括解約 | 入力 | 一括解約 |
| 45 | Form_f_KAIYAK_SUB | 解約詳細 | サブ画面 | 解約明細 |
| 46 | Form_f_SAILEASE | 再リース | 入力 | 再リース処理 |
| 47 | Form_f_SAILEASE_SUB | 再リース詳細 | サブ画面 | 再リース明細 |
| 48 | Form_f_KIRIKAE | 切替 | 入力 | 契約切替処理 |

### 1.6 月次処理画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 49 | Form_f_TOUGETSU_JOKEN | 月次支払照合条件 | 検索条件 | 月次照合 |
| 50 | Form_f_flx_TOUGETSU | 月次支払照合フレックス | 照会 | 当月支払一覧 |
| 51 | Form_f_KEIJO_JOKEN | 月次仕訳計上条件 | 検索条件 | 計上処理 |
| 52 | Form_f_flx_KEIJO | 月次仕訳計上フレックス | 照会 | 計上一覧 |
| 53 | Form_JournalEntry | 仕訳入力 | CRUD | 仕訳データの入力・編集（PostgreSQL対応済） |

### 1.7 期間帳票画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 54 | Form_f_TANA_JOKEN | 棚卸明細条件 | 検索条件 | 棚卸報告 |
| 55 | Form_f_flx_TANA | 棚卸明細フレックス | 照会 | 棚卸一覧 |
| 56 | Form_f_KLSRYO_JOKEN | 期間リース料支払明細条件 | 検索条件 | リース料支払 |
| 57 | Form_f_flx_KLSRYO | 期間リース料支払明細フレックス | 照会 | リース料一覧 |
| 58 | Form_f_KHIYO_JOKEN | 期間費用計上明細条件 | 検索条件 | 費用計上 |
| 59 | Form_f_flx_KHIYO | 期間費用計上明細フレックス | 照会 | 費用一覧 |
| 60 | Form_f_YOSAN_JOKEN | 予算実績集計条件 | 検索条件 | 予算管理 |
| 61 | Form_f_YOSAN_JOKEN_MYCOM | 予算実績集計条件（MYCOM向け） | 検索条件 | カスタマイズ版 |
| 62 | Form_f_YOSAN_JOKEN_OLD | 予算実績集計条件（旧版） | 検索条件 | 旧バージョン |
| 63 | Form_f_flx_YOSAN | 予算実績集計フレックス | 照会 | 予算一覧 |
| 64 | Form_f_flx_経費明細表 | 経費明細表フレックス | 照会 | 経費一覧 |

### 1.8 決算画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 | 備考 |
|---|-----------|---------------------|---------|------|
| 65 | Form_f_CHUKI_JOKEN | 財務諸表注記条件 | 検索条件 | 注記データ出力 |
| 66 | Form_f_CHUKI_SCH | 注記スケジュール | 照会 | 注記一覧 |
| 67 | Form_f_CHUKI_YOUSHIKI | 注記様式 | 帳票出力 | 様式出力 |
| 68 | Form_f_CHUKI_YOUSHIKI_OLD | 注記様式（旧版） | 帳票出力 | 旧バージョン |
| 69 | Form_f_flx_CHUKI | 注記フレックス | 照会 | 注記一覧 |
| 70 | Form_f_ZANDAKA_JOKEN | リース残高一覧条件 | 検索条件 | 残高照会 |
| 71 | Form_f_ZANDAKA_SCH | リース残高スケジュール | 照会 | 残高一覧 |
| 72 | Form_f_flx_ZANDAKA | リース残高フレックス | 照会 | 残高一覧 |
| 73 | Form_f_SAIMU_JOKEN | リース債務返済明細条件 | 検索条件 | 債務管理 |
| 74 | Form_f_SAIMU_SCH | リース債務返済スケジュール | 照会 | 返済一覧 |
| 75 | Form_f_flx_SAIMU | リース債務フレックス | 照会 | 債務一覧 |
| 76 | Form_f_BEPPYO2_JOKEN | 別表16(4)条件 | 検索条件 | 税務申告用 |
| 77 | Form_f_BEPPYO2_REP | 別表16(4)帳票 | 帳票出力 | 税務申告帳票 |
| 78 | Form_f_flx_BEPPYO2 | 別表16(4)フレックス | 照会 | 別表一覧 |

### 1.9 マスタメンテナンス画面

各マスタに「フレックス一覧 (flx)」「入力 (INP)」「変更 (CHANGE)」の3画面セットあり。

| # | マスタ名 | flx一覧 | 入力(INP) | 変更(CHANGE) | その他 |
|---|---------|---------|----------|-------------|-------|
| 79-81 | 会社 (CORP) | Form_f_flx_M_CORP | Form_f_M_CORP_INP | Form_f_M_CORP_CHANGE | - |
| 82-84 | 契約管理単位 (KKNRI) | Form_f_flx_M_KKNRI | Form_f_M_KKNRI_INP | Form_f_M_KKNRI_CHANGE | - |
| 85-87 | 支払先 (LCPT) | Form_f_flx_M_LCPT | Form_f_M_LCPT_INP | Form_f_M_LCPT_CHANGE | Form_f_M_LCPT_INP_MYCOM, Form_f_flx_M_LCPT_MYCOM |
| 88-90 | 支払方法 (SHHO) | Form_f_flx_M_SHHO | Form_f_M_SHHO_INP | Form_f_M_SHHO_CHANGE | - |
| 91-93 | 原価区分 (GENK) | Form_f_flx_M_GENK | Form_f_M_GENK_INP | Form_f_M_GENK_CHANGE | - |
| 94-96 | 部署 (BCAT) | Form_f_flx_M_BCAT | Form_f_M_BCAT_INP | Form_f_M_BCAT_CHANGE | Form_f_M_BCAT_IMPORT |
| 97-99 | 物件管理単位 (BKNRI) | Form_f_flx_M_BKNRI | Form_f_M_BKNRI_INP | Form_f_M_BKNRI_CHANGE | - |
| 100-102 | 費用区分 (HKMK) | Form_f_flx_M_HKMK | Form_f_M_HKMK_INP | Form_f_M_HKMK_CHANGE | - |
| 103-105 | 資産区分 (SKMK) | Form_f_flx_M_SKMK | Form_f_M_SKMK_INP | Form_f_M_SKMK_CHANGE | - |
| 106-108 | 物件種別 (BKIND) | Form_f_flx_M_BKIND | Form_f_M_BKIND_INP | Form_f_M_BKIND_CHANGE | - |
| 109-111 | 銀行口座 (KOZA) | Form_f_flx_M_KOZA | Form_f_M_KOZA_INP | Form_f_M_KOZA_CHANGE | - |
| 112-114 | 業者 (GSHA) | Form_f_flx_M_GSHA | Form_f_M_GSHA_INP | Form_f_M_GSHA_CHANGE | - |
| 115-117 | メーカー (MCPT) | Form_f_flx_M_MCPT | Form_f_M_MCPT_INP | Form_f_M_MCPT_CHANGE | - |
| 118-120 | 廃棄方法 (HKHO) | Form_f_flx_M_HKHO | Form_f_M_HKHO_INP | Form_f_M_HKHO_CHANGE | - |
| 121-123 | 予備・契約書用 (RSRVK1) | Form_f_flx_M_RSRVK1 | Form_f_M_RSRVK1_INP | Form_f_M_RSRVK1_CHANGE | - |
| 124-126 | 予備・物件用 (RSRVB1) | Form_f_flx_M_RSRVB1 | Form_f_M_RSRVB1_INP | Form_f_M_RSRVB1_CHANGE | - |
| 127-128 | 予備・配賦用 (RSRVH1) | Form_f_flx_M_RSRVH1 | Form_f_M_RSRVH1_INP_SNKO | - | Form_f_M_RSRVH1_IMPORT_1, Form_f_M_RSRVH1_IMPORT_2 |
| 129 | 仕訳パターン (SWPTN) | Form_f_flx_M_SWPTN | Form_f_M_SWPTN_INP | - | - |

### 1.10 設定・テーブルメンテナンス画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 |
|---|-----------|---------------------|---------|
| 130 | Form_f_T_KARI_RITU | 追加借入利子率テーブル | 一覧 |
| 131 | Form_f_T_KARI_RITU_INP | 追加借入利子率入力 | 新規入力 |
| 132 | Form_f_T_KARI_RITU_CHANGE | 追加借入利子率変更 | 変更 |
| 133 | Form_f_T_ZEI_KAISEI | 消費税率テーブル | 一覧 |
| 134 | Form_f_T_ZEI_KAISEI_INP | 消費税率入力 | 新規入力 |
| 135 | Form_f_T_ZEI_KAISEI_CHANGE | 消費税率変更 | 変更 |
| 136 | Form_f_T_HOLIDAY | 休日テーブル | CRUD |
| 137 | Form_f_T_KYKBNJ_SEQ | 契約番号採番設定 | 設定 |
| 138 | Form_fc_TC_HREL | 費用関連テーブル | CRUD |
| 139 | Form_fc_TC_HREL_YOBI | 費用関連テーブル（予備） | CRUD |
| 140 | Form_fc_TC_SWK_DEF_COM | 仕訳定義共通 | 設定 |
| 141 | Form_f_SETTEI | 設定 | 各種設定 |
| 142 | Form_f_00SystemOPT | システムオプション | 設定 |

### 1.11 一括更新画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 |
|---|-----------|---------------------|---------|
| 143 | Form_f_CHUKI_RECALC | 注記判定再計算 | バッチ処理 |
| 144 | Form_f_IMPORT | インポート | データ取込 |
| 145 | Form_f_IMPORT_CONTRACT_FROM_EXCEL | 契約書変更情報Excel取込 | Excel取込 |
| 146 | Form_f_IMPORT_IDO_FROM_EXCEL | 物件移動Excel取込 | Excel取込 |
| 147 | Form_f_IMPORT_SAILEASE_FROM_EXCEL | 再リース/返却Excel取込 | Excel取込 |
| 148 | Form_f_IMPORT_GSON_FROM_EXCEL | 減損損失Excel取込 | Excel取込 |
| 149 | Form_f_IMPORT_LOG | インポートログ | ログ照会 |
| 150 | Form_f_IMPORT_最終確認 | インポート最終確認 | 確認画面 |
| 151 | Form_f_IMPORT_最終確認_SUB_KYKH | インポート最終確認（契約ヘッダ） | サブ画面 |
| 152 | Form_f_IMPORT_最終確認_SUB_MST | インポート最終確認（マスタ） | サブ画面 |
| 153 | Form_0f_一括削除_JOKEN | 一括削除条件 | バッチ削除 |
| 154 | Form_0f_MNT_tcon_年金現価の計算式 | 年金現価計算式メンテ | 計算式管理 |

### 1.12 セキュリティ画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 |
|---|-----------|---------------------|---------|
| 155 | Form_f_LOGIN_JET | ログイン（JET版） | 認証 |
| 156 | Form_f_LOGIN_ORACLE | ログイン（Oracle版） | 認証 |
| 157 | Form_f_flx_SEC_USER | ユーザー一覧 | 照会 |
| 158 | Form_f_SEC_USER_INP | ユーザー入力 | CRUD |
| 159 | Form_f_flx_SEC_KNGN | 権限一覧 | 照会 |
| 160 | Form_f_SEC_KNGN_INP | 権限入力 | CRUD |
| 161 | Form_f_SEC_KNGN_INP_SUB | 権限入力詳細 | サブ画面 |
| 162 | Form_f_SEC_KNGN_INP_B_SUB | 権限入力（物件分類別） | サブ画面 |
| 163 | Form_f_CHANGE_PASSWORD | パスワード変更 | セキュリティ |
| 164 | Form_f_BKUP_PASSWORD | バックアップパスワード | セキュリティ |
| 165 | Form_f_RESTORE_PASSWORD | パスワード復元 | セキュリティ |

### 1.13 ログ画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 |
|---|-----------|---------------------|---------|
| 166 | Form_f_00SLOG | セッションログ | 照会 |
| 167 | Form_f_00SLOG_JOKEN | セッションログ条件 | 検索条件 |
| 168 | Form_f_00SLOG_M | セッションログ詳細 | 照会 |
| 169 | Form_f_00ULOG | 更新ログ | 照会 |
| 170 | Form_f_00ULOG_JOKEN | 更新ログ条件 | 検索条件 |
| 171 | Form_f_00ULOG_M | 更新ログ詳細 | 照会 |
| 172 | Form_f_00BKLOG | バックアップログ | 照会 |
| 173 | Form_f_00LOGDEL | ログ削除 | 管理 |
| 174 | Form_f_ZENKAI_LOG | 前回ログ | 照会 |

### 1.14 カスタマイズ仕訳出力画面

#### 支払仕訳
| # | ファイル名 | 顧客/パターン | 種別 |
|---|-----------|-------------|------|
| 175 | Form_fc_支払仕訳_JOT | JOT | 支払仕訳 |
| 176 | Form_fc_支払仕訳_JOT_伝票番号 | JOT伝票番号 | 支払仕訳 |
| 177 | Form_fc_支払仕訳_KITOKU | KITOKU | 支払仕訳 |
| 178 | Form_fc_支払仕訳_KITOKU_SUB | KITOKU詳細 | 支払仕訳 |
| 179 | Form_fc_支払仕訳_KYOTO | KYOTO | 支払仕訳 |
| 180 | Form_fc_支払仕訳_NKSOL | NKSOL | 支払仕訳 |
| 181 | Form_fc_支払仕訳_RISO | RISO | 支払仕訳 |
| 182 | Form_fc_支払仕訳_VTC | VTC | 支払仕訳 |
| 183 | Form_fc_支払仕訳_VTC_支払先確認 | VTC支払先確認 | 支払仕訳 |
| 184 | Form_fc_支払仕訳_YAMASHIN | YAMASHIN | 支払仕訳 |

#### 計上仕訳
| # | ファイル名 | 顧客/パターン | 種別 |
|---|-----------|-------------|------|
| 185 | Form_fc_計上仕訳_KITOKU | KITOKU | 計上仕訳 |
| 186 | Form_fc_計上仕訳_KYOTO | KYOTO | 計上仕訳 |
| 187 | Form_fc_計上仕訳_MARUZEN | MARUZEN | 計上仕訳 |
| 188 | Form_fc_計上仕訳_MARUZEN_SUB | MARUZEN詳細 | 計上仕訳 |
| 189 | Form_fc_計上仕訳_NIFS | NIFS | 計上仕訳 |
| 190 | Form_fc_計上仕訳_NKSOL | NKSOL | 計上仕訳 |
| 191 | Form_fc_計上仕訳_RISO | RISO | 計上仕訳 |
| 192 | Form_fc_計上仕訳_VTC | VTC | 計上仕訳 |
| 193 | Form_fc_計上仕訳_YAMASHIN | YAMASHIN | 計上仕訳 |

#### 経費仕訳
| # | ファイル名 | 顧客/パターン | 種別 |
|---|-----------|-------------|------|
| 194 | Form_fc_経費仕訳_NIFS | NIFS | 経費仕訳 |
| 195 | Form_fc_経費仕訳_NKSOL | NKSOL | 経費仕訳 |

#### その他仕訳出力
| # | ファイル名 | 画面名（日本語推定） | 備考 |
|---|-----------|---------------------|------|
| 196 | Form_fc_JOT_支払仕訳 | JOT支払仕訳 | JOT専用 |
| 197 | Form_fc_JOT_計上仕訳 | JOT計上仕訳 | JOT専用 |
| 198 | Form_fc_MYCOM_仕訳出力 | MYCOM仕訳出力 | MYCOM専用 |
| 199 | Form_fc_MYCOM_仕訳出力Sub | MYCOM仕訳出力サブ | MYCOM専用 |
| 200 | Form_fc_MYCOM_仕訳出力_会社MNT | MYCOM仕訳出力会社メンテ | MYCOM専用 |
| 201 | Form_fc_MYCOM_支払伝票印刷 | MYCOM支払伝票印刷 | MYCOM専用 |
| 202 | Form_fc_MYCOM_支払伝票印刷Sub | MYCOM支払伝票印刷サブ | MYCOM専用 |
| 203 | Form_fc_MYCOM_支払伝票印刷_一括設定 | MYCOM支払伝票印刷一括設定 | MYCOM専用 |
| 204 | Form_fc_VALQUA_支払仕訳 | VALQUA支払仕訳 | VALQUA専用 |
| 205 | Form_fc_VALQUA_計上仕訳 | VALQUA計上仕訳 | VALQUA専用 |
| 206 | Form_fc_VALQUA_長短振替仕訳 | VALQUA長短振替仕訳 | VALQUA専用 |
| 207 | Form_fc_TSYSCOM_支払仕訳 | TSYSCOM支払仕訳 | TSYSCOM専用 |
| 208 | Form_fc_TSYSCOM_計上仕訳 | TSYSCOM計上仕訳 | TSYSCOM専用 |
| 209 | Form_fc_TSYSCOM_移動仕訳 | TSYSCOM移動仕訳 | TSYSCOM専用 |
| 210 | Form_fc_SNKO_仕訳出力_JOKEN | 戦考仕訳出力条件 | 戦考専用 |
| 211 | Form_fc_SNKO_仕訳出力_JOKEN_SUB | 戦考仕訳出力条件サブ | 戦考専用 |
| 212 | Form_fc_SNKO_仕訳出力_最終確認 | 戦考仕訳出力最終確認 | 戦考専用 |
| 213 | Form_fc_SNKO_計上仕訳出力_JOKEN | 戦考計上仕訳出力条件 | 戦考専用 |
| 214 | Form_fc_SNKO_計上仕訳出力_最終確認 | 戦考計上仕訳出力最終確認 | 戦考専用 |
| 215 | Form_fc_SANKO_AIR_振替伝票_支払用_出力指示 | 三幸AIR振替伝票支払用 | 三幸AIR専用 |
| 216 | Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_SUB | 三幸AIR振替伝票支払用サブ | 三幸AIR専用 |
| 217 | Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_修正 | 三幸AIR振替伝票支払用修正 | 三幸AIR専用 |
| 218 | Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_預金 | 三幸AIR振替伝票支払用預金 | 三幸AIR専用 |
| 219 | Form_fc_SANKO_AIR_振替伝票_計上用_出力指示 | 三幸AIR振替伝票計上用 | 三幸AIR専用 |
| 220 | Form_fc_SANKO_AIR_異動届_JOKEN | 三幸AIR異動届条件 | 三幸AIR専用 |
| 221 | Form_fc_SANKO_AIR_登録変更願_JOKEN | 三幸AIR登録変更願条件 | 三幸AIR専用 |
| 222 | Form_fc_SANKO_AIR_登録届_JOKEN | 三幸AIR登録届条件 | 三幸AIR専用 |
| 223 | Form_fc_仕訳出力_VTC_明細 | VTC仕訳出力明細 | VTC専用 |
| 224 | Form_fc_仕訳出力_最終確認_RISO | RISO仕訳出力最終確認 | RISO専用 |

### 1.15 フレックス共通ダイアログ

| # | ファイル名 | 画面名（日本語推定） | 主な機能 |
|---|-----------|---------------------|---------|
| 225 | Form_f_FlexSearchDLG | フレックス検索ダイアログ | 汎用検索 |
| 226 | Form_f_FlexSearchDLG_Fld | フレックス検索フィールド | フィールド選択 |
| 227 | Form_f_FlexSearchDLG_Save | フレックス検索条件保存 | 条件保存 |
| 228 | Form_f_FlexSearchDLG_Sub | フレックス検索サブ | サブ条件 |
| 229 | Form_f_FlexOutputDLG | フレックス出力ダイアログ | 出力設定 |
| 230 | Form_f_FlexOutputDLG_Def | フレックス出力定義 | 定義設定 |
| 231 | Form_f_FlexOutputDLG_Def_Sub | フレックス出力定義サブ | 定義詳細 |
| 232 | Form_f_FlexReportDLG | フレックスレポートダイアログ | 帳票設定 |
| 233 | Form_f_FlexReportDLG_Save | フレックスレポート保存 | 保存 |
| 234 | Form_f_FlexSortDLG | フレックスソートダイアログ | ソート設定 |

### 1.16 その他画面

| # | ファイル名 | 画面名（日本語推定） | 主な機能 |
|---|-----------|---------------------|---------|
| 235 | Form_f_KJKBN_DLG | 計上区分ダイアログ | 選択 |
| 236 | Form_f_LINK_KAKUNIN | リンク確認 | 確認 |
| 237 | Form_f_00DataPass | データパス | データ連携 |
| 238 | Form_f_00VerInfo | バージョン情報 | 情報表示 |
| 239 | Form_f_StatusMeter | ステータスメーター | 進捗表示 |
| 240 | Form_f_Dummy | ダミー | ユーティリティ |
| 241 | Form_f_Dummy2 | ダミー2 | ユーティリティ |
| 242 | Form_f_Dummy_DoEvents_1000msec | ダミー(1秒遅延) | ユーティリティ |
| 243 | Form_BCAT | 部署（簡易版） | 照会 |
| 244 | Form_BKNRI | 物件管理単位（簡易版） | 照会 |
| 245 | Form_HKMK | 費用区分（簡易版） | 照会 |
| 246 | Form_KKNRI | 契約管理単位（簡易版） | 照会 |
| 247 | Form_LCPT | 支払先（簡易版） | 照会 |
| 248 | Form_SKMK | 資産区分（簡易版） | 照会 |
| 249 | Form1 | テスト用フォーム | テスト |

**画面合計: 約249画面（Designer.vbを除いたユニークフォーム数）**

---

## 2. ビジネスロジック・モジュール一覧

### 2.1 データアクセス層 (LeaseM4BS.DataAccess)

| # | ファイル名 | 機能概要 | 主要Publicメソッド |
|---|-----------|---------|------------------|
| 1 | CrudHelper.vb | PostgreSQL汎用CRUD操作ヘルパー | GetDataTable(), ExecuteNonQuery(), BeginTransaction(), CommitTransaction(), RollbackTransaction(), ExecuteScalar(), InsertRecord(), UpdateRecord(), DeleteRecord() |
| 2 | DbConnectionManager.vb | DB接続管理（DAO.Database代替） | GetConnection(), GetConnectionString() |
| 3 | UsageExamples.vb | DAOからNpgsqlへの移行パターン例 | Example1_BasicSelect(), Example2_ParameterizedQuery(), Example3_InsertData() |

### 2.2 ユーティリティクラス

| # | ファイル名 | 機能概要 | 主要Publicメソッド |
|---|-----------|---------|------------------|
| 4 | FileHelper.vb | ファイル出力ヘルパー | ToExcelFile(), ToCsvFile(), ToFixedLengthFile() |
| 5 | CalendarColumn.vb | DataGridViewカレンダー列カスタムコントロール | CalendarColumn, CalendarCell, CalendarEditingControl |

### 2.3 元Access版で想定されるビジネスロジックモジュール (pc_*/p_*/g_*)

元のAccess VBAでは以下のモジュールが存在すると推定される（画面名・テーブル構造から推定）:

| 推定モジュール名 | 機能概要 | 根拠 |
|---------------|---------|------|
| pc_KYKH | 契約ヘッダ処理 | Form_ContractEntry の CRUD操作 |
| pc_KYKM | 物件明細処理 | Form_BuknEntry の CRUD操作 |
| pc_HAIF | 配賦処理 | d_haif テーブル操作 |
| pc_IDO | 物件移動処理 | Form_f_IDO, Excel取込 |
| pc_KAIYAK | 解約処理 | Form_f_KAIYAK |
| pc_SAILEASE | 再リース処理 | Form_f_SAILEASE |
| pc_HENF | 変更ファイナンス処理 | Form_f_HENF |
| pc_HENL | 変更リース処理 | Form_f_HENL |
| pc_CHUKI | 注記計算処理 | Form_f_CHUKI_RECALC |
| pc_KEIJO | 月次仕訳計上処理 | Form_f_KEIJO_JOKEN |
| pc_TOUGETSU | 月次支払照合処理 | Form_f_TOUGETSU_JOKEN |
| pc_IMPORT | データ取込処理 | Form_f_IMPORT_* |
| pc_SWK | 仕訳出力処理 | Form_fc_*仕訳* |
| p_FlexSearch | フレックス検索エンジン | Form_f_FlexSearchDLG |
| p_FlexReport | フレックス帳票エンジン | Form_f_FlexReportDLG |
| g_Common | 共通関数群 | 全画面で使用 |
| g_Security | セキュリティ共通 | SEC_*テーブル |
| g_Log | ログ記録 | L_*テーブル |

---

## 3. レポート一覧

元Access版のレポート(Report_*)は、VB.NET移行後はフレックス画面 + FileHelper による出力に置き換えられている。元の帳票機能を推定:

| # | 帳票名 | 対応画面 | 出力形式 |
|---|--------|---------|---------|
| 1 | 月次支払照合表 | Form_f_flx_TOUGETSU | フレックス/Excel/CSV |
| 2 | 月次仕訳計上一覧 | Form_f_flx_KEIJO | フレックス/Excel/CSV |
| 3 | 棚卸明細表 | Form_f_flx_TANA | フレックス/Excel/CSV |
| 4 | 期間リース料支払明細表 | Form_f_flx_KLSRYO | フレックス/Excel/CSV |
| 5 | 移動物件一覧表 | Form_f_flx_IDOLST | フレックス/Excel/CSV |
| 6 | 期間費用計上明細表 | Form_f_flx_KHIYO | フレックス/Excel/CSV |
| 7 | 予算実績集計表 | Form_f_flx_YOSAN | フレックス/Excel/CSV |
| 8 | 経費明細表 | Form_f_flx_経費明細表 | フレックス/Excel/CSV |
| 9 | 財務諸表注記 | Form_f_CHUKI_YOUSHIKI | 帳票印刷/Excel |
| 10 | 財務諸表注記（旧） | Form_f_CHUKI_YOUSHIKI_OLD | 帳票印刷/Excel |
| 11 | リース残高一覧表 | Form_f_flx_ZANDAKA | フレックス/Excel/CSV |
| 12 | リース債務返済明細 | Form_f_flx_SAIMU | フレックス/Excel/CSV |
| 13 | 別表16(4) | Form_f_BEPPYO2_REP | 帳票印刷/Excel |
| 14 | 契約書一覧 | Form_f_flx_CONTRACT | フレックス/Excel/CSV |
| 15 | 物件一覧 | Form_f_flx_BUKN | フレックス/Excel/CSV |
| 16 | 配賦一覧 | Form_f_flx_D_HAIF | フレックス/Excel/CSV |
| 17 | 変更ファイナンス一覧 | Form_f_flx_D_HENF | フレックス/Excel/CSV |
| 18 | 減損一覧 | Form_f_flx_D_GSON | フレックス/Excel/CSV |
| 19 | 注記スケジュール | Form_f_CHUKI_SCH | 帳票印刷/Excel |
| 20 | 残高スケジュール | Form_f_ZANDAKA_SCH | 帳票印刷/Excel |
| 21 | 債務返済スケジュール | Form_f_SAIMU_SCH | 帳票印刷/Excel |
| 22 | 変更スケジュール | Form_f_HEN_SCH | 帳票印刷/Excel |
| 23 | 各社カスタマイズ仕訳出力 | Form_fc_*仕訳* (約30画面) | 固定長/CSV/Excel |
| 24 | MYCOM支払伝票 | Form_fc_MYCOM_支払伝票印刷 | 帳票印刷 |
| 25 | 三幸AIR振替伝票 | Form_fc_SANKO_AIR_振替伝票_* | 帳票印刷 |
| 26 | 三幸AIR登録届 | Form_fc_SANKO_AIR_登録届_JOKEN | 帳票出力 |
| 27 | 三幸AIR登録変更願 | Form_fc_SANKO_AIR_登録変更願_JOKEN | 帳票出力 |
| 28 | 三幸AIR異動届 | Form_fc_SANKO_AIR_異動届_JOKEN | 帳票出力 |

---

## 4. テーブル一覧

### 4.1 コードテーブル (C_*)

| # | テーブル名 | 日本語名 | PK | 備考 |
|---|-----------|---------|-----|------|
| 1 | c_chuum | 注記有無 | chuum_id | SMALLINT |
| 2 | c_chu_hnti | 注記単位 | chu_hnti_id | SMALLINT |
| 3 | c_kjkbn | 計上区分 | kjkbn_id | SMALLINT |
| 4 | c_kjtaisyo | 計上対象 | kjkbn_id | SMALLINT |
| 5 | c_kkbn | 契約区分 | kkbn_id | SMALLINT |
| 6 | c_leakbn | リース区分 | leakbn_id | SMALLINT |
| 7 | c_rcalc | 再計算区分 | rcalc_id | SMALLINT |
| 8 | c_settei_idfld | 設定IDフィールド | settei_id, val_id | 設定マスタ |
| 9 | c_skyak_ho | 償却方法 | skyak_ho_id | SMALLINT |
| 10 | c_szei_kjkbn | 消費税計上区分 | szei_kjkbn_id | 消費税処理区分 |

### 4.2 マスタテーブル (M_*)

| # | テーブル名 | 日本語名 | PK | 主要カラム |
|---|-----------|---------|-----|-----------|
| 11 | m_bcat | 管理部署 | bcat_id | bcat1_cd～bcat5_cd/nm, genk_id, skti_id, bknri_id, sum1～sum3 |
| 12 | m_bkind | 物件種別 | bkind_id | bkind_cd/nm, bkind2/3_cd/nm |
| 13 | m_bknri | 物件分類 | bknri_id | bknri1_cd～bknri3_cd/nm |
| 14 | m_corp | 法人 | corp_id | corp1_cd～corp3_cd/nm |
| 15 | m_genk | 原価分類 | genk_id | genk_cd/nm |
| 16 | m_gsha | 購入先・業者 | gsha_id | gsha_cd/nm |
| 17 | m_hkho | 返却方法 | hkho_id | hkho_cd/nm |
| 18 | m_hkmk | 費用区分 | hkmk_id | hkmk_cd/nm, knjkb_id, sum1～sum3, hrel_ptn |
| 19 | m_kknri | 契約管理単位 | kknri_id | kknri1_cd～kknri3_cd/nm, corp_id, hrel_ptn_cd4 |
| 20 | m_koza | 口座 | koza_id | koza_cd/nm |
| 21 | m_lcpt | リース会社・支払先 | lcpt_id | lcpt1_cd/nm, lcpt2_cd/nm, shime_day, sshri_kn, shri_day, sai_denomi等 |
| 22 | m_mcpt | メーカー | mcpt_id | mcpt_cd/nm |
| 23 | m_rsrvb1 | 物件予備1 | rsrvb1_id | rsrvb1_cd/nm, num |
| 24 | m_rsrvh1 | 配賦予備1 | rsrvh1_id | rsrvh1_cd/nm, num |
| 25 | m_rsrvk1 | 契約予備1 | rsrvk1_id | rsrvk1_cd/nm, num |
| 26 | m_shho | 支払方法 | shho_id | shho_cd/nm |
| 27 | m_skmk | 集計区分（資産科目） | skmk_id | skmk_cd/nm, knjkb_id, sum1～sum15, hrel_ptn_cd1 |
| 28 | m_skti | 事業体 | skti_id | skti_cd/nm, sktsyt, jgsyonm/pst/adr/tel |
| 29 | m_swptn | 仕訳パターン | swptn_id | swptn_cd/nm, kmk1～kmk10_cd/nm |

### 4.3 データテーブル (D_*)

| # | テーブル名 | 日本語名 | PK | 主要カラム数 | 備考 |
|---|-----------|---------|-----|------------|------|
| 30 | d_kykh | 契約ヘッダ | kykh_id | 約90列 | 契約書情報。金額・期間・支払条件・計上区分等 |
| 31 | d_kykm | 物件明細 | kykm_id | 約100列 | 物件情報。金額・利率・償却・注記・移動履歴等 |
| 32 | d_haif | 配賦 | kykm_id, line_id | 約25列 | 配賦率・費用区分・部署別按分 |
| 33 | d_gson | 減損 | kykm_id, line_id | 約15列 | 減損日・減損額・減損累計 |
| 34 | d_henf | 変更ファイナンス | kykm_id, line_id | 約20列 | 保守料変更情報 |
| 35 | d_henl | 変更リース | kykm_id, line_id | 約20列 | リース条件変更情報 |

### 4.4 セキュリティテーブル (SEC_*)

| # | テーブル名 | 日本語名 | PK | 備考 |
|---|-----------|---------|-----|------|
| 36 | sec_user | ユーザー | user_id | ログイン試行・パスワードポリシー対応 |
| 37 | sec_kngn | 権限 | kngn_id | admin, master_update, file_output, print, log_ref, approval |
| 38 | sec_kngn_bknri | 権限別物件分類 | kngn_id, bknri_id | 物件分類単位のアクセス制御 |
| 39 | sec_kngn_kknri | 権限別契約管理単位 | kngn_id, kknri_id | 管理単位のアクセス制御 |

### 4.5 システム・設定テーブル (T_*)

| # | テーブル名 | 日本語名 | PK | 備考 |
|---|-----------|---------|-----|------|
| 40 | t_system | システム情報 | ap_version | バージョン・カスタマイズタイプ |
| 41 | t_opt | オプション設定 | - | slog, ulog, recopt, cnvlog |
| 42 | t_seq | 採番管理 | field_nm | 各テーブルの採番管理 |
| 43 | t_db_version | DBバージョン | db_version | DB構造バージョン |
| 44 | t_kari_ritu | 追加借入利子率 | kari_ritu_id | 期間別利率 |
| 45 | t_zei_kaisei | 税制改正 | zei_kaisei_id | 消費税率・適用期間 |
| 46 | t_kykbnj_seq | 契約番号採番 | key | 契約番号の自動採番 |
| 47 | t_holiday | 休日 | id | 休日マスタ |
| 48 | t_mstk | マスタチェック | mstk_id | マスタ整合性チェック |
| 49 | t_szei_kmk | 消費税科目 | - | 税率別・区分別の科目マッピング |
| 50 | t_swk_nm | 仕訳名称 | swk_kbn | 仕訳区分名称 |

### 4.6 ログテーブル (L_*)

| # | テーブル名 | 日本語名 | PK | 備考 |
|---|-----------|---------|-----|------|
| 51 | l_bklog | バックアップログ | op_dt | バックアップ操作記録 |
| 52 | l_slog | セッションログ | slog_no | ログイン・操作記録 |
| 53 | l_ulog | 更新ログ | slog_no, ulog_no | データ変更前後の記録 |

### 4.7 トランザクションテーブル (TC_*)

| # | テーブル名 | 日本語名 | PK | 備考 |
|---|-----------|---------|-----|------|
| 54 | tc_hrel | 配賦連動 | - | 配賦パターン→科目マッピング (15パターン) |
| 55 | tc_rec_shri | 支払実績 | - | 支払月・支払日・仕訳区分別集計 |

**テーブル合計: 55テーブル**

---

## 5. 定数・列挙値（enum相当）

コードテーブルにより定義される列挙値:

| # | テーブル | 定数名 | 説明 | 推定値例 |
|---|---------|-------|------|---------|
| 1 | c_kjkbn | 計上区分 | オンバランス/オフバランス | 0:オフバランス, 1:オンバランス等 |
| 2 | c_kkbn | 契約区分 | リース種別 | ファイナンスリース, オペレーティングリース等 |
| 3 | c_leakbn | リース区分 | リース詳細分類 | 所有権移転, 所有権移転外等 |
| 4 | c_chuum | 注記有無 | 注記要否 | 0:不要, 1:要 |
| 5 | c_chu_hnti | 注記単位 | 注記の計算単位 | 契約単位, 物件単位等 |
| 6 | c_rcalc | 再計算区分 | 再計算要否 | 0:不要, 1:要 |
| 7 | c_skyak_ho | 償却方法 | 償却計算方法 | 定額法, 定率法等 |
| 8 | c_szei_kjkbn | 消費税計上区分 | 消費税処理方法 | 一括, 分割, 控除対象外等 |
| 9 | c_kjtaisyo | 計上対象 | 計上対象区分 | - |
| 10 | c_settei_idfld | 設定IDフィールド | 汎用設定値 | 各種設定パラメータ |

### 画面側で使用される主要フラグ・区分

| フラグ名 | テーブル | 型 | 説明 |
|---------|---------|-----|------|
| kjkbn_id | d_kykh, d_kykm | SMALLINT | 計上区分（オン/オフバランス） |
| leakbn_id | d_kykm | SMALLINT | リース区分 |
| chuum_id | d_kykm | SMALLINT | 注記有無 |
| kkbn_id | d_kykh | SMALLINT | 契約区分 |
| szei_kjkbn_id | d_kykm | SMALLINT | 消費税計上区分 |
| history_f | 全マスタ | BOOLEAN | 履歴フラグ（論理削除） |
| k_henl_f | d_kykh | BOOLEAN | 変更リースフラグ |
| k_henf_f | d_kykh | BOOLEAN | 変更ファイナンスフラグ |
| kyak_end_f | d_kykh | BOOLEAN | 契約終了フラグ |
| k_ckaiyk_f | d_kykh | BOOLEAN | 中途解約フラグ |
| b_ckaiyk_f | d_kykm | BOOLEAN | 物件中途解約フラグ |
| b_henl_f | d_kykm | BOOLEAN | 物件変更リースフラグ |
| b_henf_f | d_kykm | BOOLEAN | 物件変更ファイナンスフラグ |
| b_gson_f | d_kykm | BOOLEAN | 減損フラグ |
| genson_f | d_kykm | BOOLEAN | 減損実施フラグ |
| jencho_f | d_kykh | BOOLEAN | 延長フラグ |
| suuryo_sum_f | d_kykm | BOOLEAN | 数量合計フラグ |
| kari_ritu_ms_f | d_kykm | BOOLEAN | 追加借入利子率手動設定フラグ |
| kjkbn_ms_f | d_kykh | BOOLEAN | 計上区分手動設定フラグ |

---

## 6. 共通関数・ユーティリティ

### 6.1 VB.NET移行済み共通クラス

| # | クラス名 | ファイル | 機能概要 |
|---|---------|---------|---------|
| 1 | CrudHelper | CrudHelper.vb | PostgreSQL汎用CRUD操作（DAO.Recordset代替） |
| 2 | DbConnectionManager | DbConnectionManager.vb | DB接続管理（DAO.Database代替） |
| 3 | FileHelper | FileHelper.vb | ファイル出力（Excel/CSV/固定長） |
| 4 | CalendarColumn | CalendarColumn.vb | DataGridView用カレンダー列 |
| 5 | CalendarCell | CalendarColumn.vb | カレンダーセル |
| 6 | CalendarEditingControl | CalendarColumn.vb | カレンダー編集コントロール |

### 6.2 元Access版で想定される共通関数群 (g_* プレフィックス)

| 推定関数名 | 機能概要 | 使用箇所 |
|-----------|---------|---------|
| gfnc_GetNextID | 採番（t_seq利用） | 全テーブルのID自動採番 |
| gfnc_GetNextKYKBNJ | 契約番号採番（t_kykbnj_seq利用） | 契約書作成 |
| gfnc_DateAdd / gfnc_DateDiff | 日付計算 | リース期間計算 |
| gfnc_CalcLeaseFee | リース料計算 | 契約入力・再計算 |
| gfnc_CalcPresentValue | 年金現価計算 | リース判定・注記計算 |
| gfnc_CalcDepreciation | 償却額計算 | 計上処理 |
| gfnc_IsHoliday | 休日判定（t_holiday利用） | 支払日計算 |
| gfnc_GetPayDate | 支払日計算 | 月次支払照合 |
| gfnc_GetTaxRate | 消費税率取得（t_zei_kaisei利用） | 税額計算 |
| gfnc_CalcTax | 消費税額計算 | 全税額計算箇所 |
| gfnc_CheckSecurity | 権限チェック | 全画面アクセス制御 |
| gfnc_WriteLog | ログ書き込み（l_slog/l_ulog利用） | 全更新操作 |
| gfnc_GetMasterName | マスタ名称取得 | コンボボックス表示 |
| gfnc_FormatNumber | 数値フォーマット | 金額表示 |
| gfnc_RoundBank | 銀行丸め | 金額端数処理 |

---

## 7. 機能分類サマリー

| カテゴリ | 画面数 | 説明 |
|---------|-------|------|
| メイン・ナビゲーション | 5 | メニュー、スイッチボード、システム情報 |
| 契約書管理 | 7 | 契約ヘッダの入力・照会・参照 |
| 物件管理 | 17 | 物件明細の入力・分割・注記・照会 |
| 配賦・変更・減損 | 9 | 配賦設定、変更リース、変更ファイナンス、減損 |
| 物件移動・解約・再リース | 10 | 移動、解約、再リース、切替 |
| 月次処理 | 5 | 支払照合、仕訳計上、仕訳入力 |
| 期間帳票 | 11 | 棚卸、リース料、移動、費用、予算、経費 |
| 決算処理 | 14 | 注記、残高、債務返済、別表16 |
| マスタメンテナンス | 約50 | 19種類のマスタ x flx/INP/CHANGE |
| 設定・テーブルメンテ | 13 | 利子率、消費税率、休日、費用関連等 |
| 一括更新・取込 | 12 | 注記再計算、Excel取込5種、一括削除 |
| セキュリティ | 11 | ログイン、ユーザー、権限、パスワード |
| ログ管理 | 9 | セッション、更新、バックアップログ |
| カスタマイズ仕訳出力 | 約50 | 10社以上の顧客別仕訳出力 |
| フレックス共通 | 10 | 検索、ソート、出力、レポートダイアログ |
| その他・ユーティリティ | 約16 | ダミー、簡易表示、テスト等 |
| **合計** | **約249** | |

---

## 8. 主要業務フロー

### 8.1 契約書登録フロー
1. Form_ContractEntry で契約ヘッダ(d_kykh)を作成
2. Form_BuknEntry で物件明細(d_kykm)を追加
3. 配賦行(d_haif)を設定
4. リース区分(leakbn_id)・注記判定(chuum_id)を自動/手動設定
5. 計上区分(kjkbn_id)を判定

### 8.2 月次処理フロー
1. Form_f_TOUGETSU_JOKEN で当月支払照合を実行
2. Form_f_KEIJO_JOKEN で仕訳計上を実行
3. カスタマイズ仕訳(Form_fc_*)で各社向け仕訳ファイルを出力

### 8.3 決算処理フロー
1. Form_f_CHUKI_JOKEN で注記データ作成
2. Form_f_CHUKI_YOUSHIKI で注記帳票出力
3. Form_f_ZANDAKA_JOKEN でリース残高一覧作成
4. Form_f_SAIMU_JOKEN で債務返済明細作成
5. Form_f_BEPPYO2_JOKEN で別表16(4)作成

### 8.4 物件ライフサイクル
1. **新規登録**: 契約書入力 → 物件入力
2. **変更**: 変更リース(HENL) / 変更ファイナンス(HENF)
3. **移動**: 物件移動(IDO) - 部署間
4. **解約**: 中途解約(KAIYAK)
5. **再リース**: 再リース(SAILEASE)
6. **減損**: 減損損失取込(GSON)
