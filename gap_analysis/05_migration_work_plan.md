# LeaseM4BS 移行作業計画書（完全版）

> **作成日**: 2026-03-13
> **対象システム**: LeaseM4BS (リース資産管理システム)
> **移行元**: Microsoft Access VBA + JET/DAO
> **移行先**: VB.NET WinForms + PostgreSQL (Npgsql)
> **現状実装率**: 約15-20%（基盤層は完成、画面ロジックの大半が未実装）

---

## 1. 移行方針書

### 1.1 移行の全体方針

本移行プロジェクトは、Microsoft Access VBA で構築されたリース資産管理システム「LeaseM4BS」を、VB.NET WinForms + PostgreSQL へ完全に移行するものである。

**基本原則**:
- **機能完全再現**: Access版の全249画面・55テーブル・28帳票を漏れなくVB.NET版で再現する
- **段階的移行**: 業務影響度と技術依存関係に基づくフェーズ分割で、早期に中核機能を稼働させる
- **既存資産最大活用**: 既に完成しているデータアクセス層（CrudHelper/DbConnectionManager）・DDL・UI Designer定義を土台として活用する
- **アーキテクチャ改善**: 移行を機に3層分離を実施し、保守性・拡張性を向上させる

**移行対象の規模**:
| 区分 | 総数 | 実装済み | 残作業 |
|------|------|---------|--------|
| 画面 | 249 | 約20（ロジック実装済み） | 約229 |
| テーブル | 55 | 55（DDL定義済み） | 初期データ投入 |
| 帳票 | 28 | 1（注記SCH骨格のみ） | 27 |
| 共通モジュール | 15 | 8 | 7 |
| カスタム仕訳（顧客別） | 約50画面 | 0 | 約50 |

### 1.2 アーキテクチャ方針

#### 現行（Access版）
```
[Access Form] ──直接──> [DAO.Recordset / DAO.Database] ──> [JET DB / Access MDB]
     ↑                         ↑
     └── VBA コードビハインド ──┘  （UI・ロジック・データアクセスが一体）
```

#### 新アーキテクチャ（VB.NET版）
```
[プレゼンテーション層]          [ビジネスロジック層]         [データアクセス層]
  WinForms (Form_*.vb)   ──>   Service / Logic クラス  ──>  CrudHelper.vb
  FormHelper.vb                  (pc_*, g_* 相当)            DbConnectionManager.vb
  Utils/UtilControl/UtilDate     CalcEngine (計算エンジン)    Npgsql (ADO.NET)
  FileHelper.vb                                                  ↓
                                                            [PostgreSQL]
                                                            55テーブル (DDL定義済み)
```

**層間の責務分離ルール**:
- **プレゼンテーション層**: UI操作、入力バリデーション、画面遷移のみ
- **ビジネスロジック層**: 計算ロジック、業務ルール、トランザクション制御
- **データアクセス層**: SQL発行、DB接続管理（既に CrudHelper で完成済み）

### 1.3 技術スタック対応表

| Access版 | VB.NET版 | 備考 |
|----------|---------|------|
| DAO.Database | DbConnectionManager (NpgsqlConnection) | 実装済み |
| DAO.Recordset | CrudHelper.GetDataTable() → DataTable | 実装済み |
| DAO.Recordset.AddNew/Edit/Update | CrudHelper.Insert()/Update()/Delete() | 実装済み |
| CurrentDb.Execute (SQL) | CrudHelper.ExecuteNonQuery() | 実装済み |
| DLookup/DCount/DSum | CrudHelper.ExecuteScalar(Of T) | 実装済み |
| DAO.BeginTrans/CommitTrans | CrudHelper.BeginTransaction()/Commit() | 実装済み |
| Access Form | WinForms Form (Designer.vb + .vb) | Designer定義済み、ロジック大半未実装 |
| Access SubForm | DataGridView / Panel内Form | パターン確立済み |
| Access ComboBox (複数列表示) | ComboBox + FormHelper.Bind() + Combo_DrawItem() | 実装済み（3列描画対応） |
| Access フレックスグリッド | DataGridView + FormHelper | 実装済み |
| DoCmd.OpenForm | form.Show() / form.ShowDialog() | パターン確立済み |
| DoCmd.TransferSpreadsheet | FileHelper.ToExcelFile() | 実装済み |
| DoCmd.OutputTo (CSV) | FileHelper.ToCsvFile() | 実装済み |
| DoCmd.OutputTo (固定長) | FileHelper.ToFixedLengthFile() | 骨格のみ、要完成 |
| Access Report (印刷) | PrintDocument / PrintPreviewDialog | 未実装（要設計） |
| Nz() | Utils.NzInt()/NzDate()/NzDec() | 実装済み |
| DateAdd/DateDiff | UtilDate.GetDuration()/GetMonthStart()/GetMonthEnd() | 実装済み |
| ワークテーブル (tcon_*, W_*) | DataTable（メモリ上）またはPostgreSQL一時テーブル | 要設計 |
| JET SQL方言 | PostgreSQL SQL | 変換ルール策定済み |
| VBA Err.Number | Try/Catch (Exception) | パターン確立済み |
| Access Security (MDW/MDB) | sec_user / sec_kngn テーブル + カスタム認証 | DDL定義済み、ロジック未実装 |

---

## 2. フェーズ別作業計画

### フェーズ1: 基盤整備（1.5ヶ月 / 推定30-40人日）

**目的**: 全画面で共通利用する基盤機能を確立し、以降のフェーズの生産性を最大化する。

#### 対象スコープ
- 共通モジュール（未実装分7件）
- ログイン・認証
- システム設定画面
- 初期データ投入スクリプト

#### 具体的な作業項目

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 1-01 | 定数定義モジュール新規作成 | Constants.vb（新規） | Access版のc_*テーブル値に対応する定数Enum定義。KjkbnId, KkbnId, LeakbnId, ChuumId等 | 2人日 |
| 1-02 | セッション管理クラス新規作成 | SessionManager.vb（新規） | ログインユーザー情報保持、権限情報キャッシュ。Shared(Static)プロパティで全画面からアクセス可能に | 2人日 |
| 1-03 | 権限チェック共通処理 | SecurityHelper.vb（新規） | sec_kngn/sec_kngn_bknri/sec_kngn_kknriテーブルからの権限判定。HasPermission(funcName), CheckAccess(kknriId)等 | 3人日 |
| 1-04 | ログ記録共通処理 | LogHelper.vb（新規） | l_slog（セッションログ）、l_ulog（更新ログ）への書き込み。WriteSessionLog(), WriteUpdateLog() | 2人日 |
| 1-05 | 採番処理 | SequenceHelper.vb（新規） | t_seqテーブルからのID自動採番。GetNextId(tableName), GetNextKykbnj(kknriId) | 2人日 |
| 1-06 | 楽観的排他制御 | CrudHelper.vb（拡張） | update_cntカラムによるレコードロック検知。UpdateWithOptimisticLock()追加 | 1人日 |
| 1-07 | グローバルエラーハンドリング | Program.vb / ErrorHandler.vb（新規） | Application.ThreadException, AppDomain.UnhandledException の共通処理 | 1人日 |
| 1-08 | メッセージ管理 | Messages.vb（新規） | 確認・エラー・警告メッセージの集中管理。MessageHelper.Confirm(), .Error() | 1人日 |
| 1-09 | ログイン画面実装 | Form_f_LOGIN_JET.vb | sec_userテーブルによる認証処理。パスワードハッシュ化、ログイン試行回数制限、セッションログ記録 | 3人日 |
| 1-10 | パスワード変更 | Form_f_CHANGE_PASSWORD.vb | パスワード変更処理。旧パスワード検証、ポリシーチェック | 1人日 |
| 1-11 | システム情報画面 | Form_0F_SYSTEM.vb | t_systemテーブル表示。ap_version, db_version, カスタマイズタイプ表示 | 1人日 |
| 1-12 | システム管理画面 | Form_0F_SYSTEM管理.vb | t_system, t_optの管理者編集。slog/ulog有効化設定 | 2人日 |
| 1-13 | システムオプション | Form_f_00SystemOPT.vb | t_optテーブルの設定画面 | 1人日 |
| 1-14 | 設定画面 | Form_f_SETTEI.vb | 各種設定の一元管理 | 2人日 |
| 1-15 | 印刷制御基盤 | PrintHelper.vb（新規） | PrintDocument/PrintPreviewDialog のラッパークラス。DataGridView→印刷変換 | 3人日 |
| 1-16 | 固定長ファイル出力完成 | FileHelper.vb | ToFixedLengthFile()の完成。PadRightByte()を活用した固定長出力 | 1人日 |
| 1-17 | 初期データ投入SQL | sql/002_initial_data.sql（新規） | c_*テーブル（コードマスタ10件）の初期値INSERT。t_system, t_opt, t_seq初期値 | 2人日 |

**前提条件**: なし（最初のフェーズ）
**成果物**: 全画面から利用可能な共通基盤、ログイン可能な最小システム

---

### フェーズ2: コア業務 - 台帳管理（3ヶ月 / 推定120-150人日）

**目的**: リース契約書・物件の登録・変更・照会という中核業務を完成させる。

#### 対象スコープ
- 契約書管理（入力・変更・削除・照会・一覧）
- 物件管理（入力・変更・分割・照会・一覧）
- 配賦管理
- 変更リース・変更ファイナンス
- 物件移動・解約・再リース
- 必須マスタメンテナンス（19マスタ中10マスタ）
- 減損管理
- フレックス共通ダイアログ

#### 具体的な作業項目

**A. リース計算エンジン新規作成**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 2-01 | リース料計算エンジン | CalcEngine.vb（新規） | 年金現価計算、利息計算、元本残高計算、月別リース料配分。tcon_年金現価の計算式テーブル参照 | 8人日 |
| 2-02 | 消費税計算 | TaxCalcHelper.vb（新規） | t_zei_kaiseiテーブルからの税率取得、税額計算（一括/分割/控除対象外）、銀行丸め | 3人日 |
| 2-03 | 償却計算 | DepreciationCalc.vb（新規） | 定額法・定率法の減価償却額計算。c_skyak_hoによる方法切替 | 3人日 |
| 2-04 | 注記判定ロジック | ChuukiCalc.vb（新規） | c_chuum/c_chu_hntiによる注記要否判定、注記金額の自動計算 | 5人日 |
| 2-05 | 支払日計算 | PaymentDateCalc.vb（新規） | t_holidayテーブル参照の休日判定、支払日の営業日シフト | 2人日 |

**B. 契約書管理**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 2-06 | 契約書入力ロジック完成 | Form_ContractEntry.vb | cmd_CREATE（新規登録）, cmd_REVISE（改定）, cmd_DELETE（削除）の完全実装。d_kykhへのINSERT/UPDATE、採番処理、入力バリデーション | 8人日 |
| 2-07 | 再リース処理 | Form_ContractEntry.vb:cmd_SAILEASE | 再リース条件設定、d_kykh/d_kykmの更新、リース料再計算 | 3人日 |
| 2-08 | 解約処理 | Form_ContractEntry.vb:cmd_KAIYAKU | 中途解約フラグ設定、解約損益計算、d_kykh更新 | 3人日 |
| 2-09 | ロールバック処理 | Form_ContractEntry.vb:cmd_ROLLBACK_SAI | 再リースの取消処理 | 2人日 |
| 2-10 | Excel取込 | Form_ContractEntry.vb:cmd_取込 | Excel→契約ヘッダ取込処理 | 3人日 |
| 2-11 | 契約ヘッダ編集画面 | Form_f_KYKH.vb, Form_f_KYKH_SUB.vb | d_kykhの全カラム編集。約90列のフィールドバインド、コンボ連動 | 8人日 |
| 2-12 | 契約ヘッダ参照画面 | Form_f_REF_D_KYKH.vb, Form_f_REF_D_KYKH_SUB.vb | 読取専用表示。編集画面のコピーでReadOnlyモード | 3人日 |
| 2-13 | 契約書フレックス一覧改修 | Form_f_flx_CONTRACT.vb | 検索条件の充実、フレックス検索ダイアログ連携 | 2人日 |
| 2-14 | 契約ヘッダフレックス | Form_f_flx_D_KYKH.vb | d_kykhの全列フレックス一覧表示 | 3人日 |

**C. 物件管理**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 2-15 | 物件入力ロジック完成 | Form_BuknEntry.vb | cmd_KJHNTI(計上変更), cmd_MAINTANANCECOST(保守料), cmd_CHANGE(変更), cmd_DEVIDE(分割), cmd_COPYZ/COPYA(複写), cmd_DELETE(削除), cmd_ADD_HAIF(配賦追加) | 10人日 |
| 2-16 | 物件明細編集画面 | Form_f_KYKM.vb, Form_f_KYKM_SUB.vb | d_kykmの全カラム編集。約100列のフィールドバインド | 8人日 |
| 2-17 | 物件分割画面 | Form_f_KYKM_BKN.vb, Form_f_KYKM_SUB_BKN.vb, Form_f_KYKM_BUNKATSU.vb | 物件分割ロジック。金額按分計算、新物件レコード作成 | 5人日 |
| 2-18 | 物件注記画面 | Form_f_KYKM_CHUUKI.vb, Form_f_KYKM_CHUUKI_SUB_GSON.vb, Form_f_KYKM_CHUUKI_拡張設定.vb | 注記判定条件の表示・編集、減損注記サブ画面 | 5人日 |
| 2-19 | 物件参照画面群 | Form_f_REF_D_KYKM.vb, _SUB.vb, _CHUUKI.vb, _CHUUKI_SUB_GSON.vb, _拡張設定.vb | 読取専用表示（5画面セット） | 4人日 |
| 2-20 | 物件フレックス群 | Form_f_flx_D_KYKM.vb, Form_f_flx_D_KYKM_BKN.vb, Form_f_flx_BUKN.vb改修 | 物件一覧の検索・表示 | 4人日 |

**D. 配賦・変更・減損**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 2-21 | 配賦管理 | Form_f_flx_D_HAIF.vb, Form_f_flx_D_HAIF_SNKO.vb | d_haifテーブルの一覧表示・検索 | 3人日 |
| 2-22 | 変更ファイナンス | Form_f_HENF.vb, Form_f_REF_D_HENF.vb, Form_f_flx_D_HENF.vb | d_henfテーブルの入力・参照・一覧 | 5人日 |
| 2-23 | 変更リース | Form_f_HENL.vb, Form_f_REF_D_HENL.vb | d_henlテーブルの入力・参照 | 5人日 |
| 2-24 | 変更スケジュール | Form_f_HEN_SCH.vb | 変更履歴の時系列表示 | 3人日 |
| 2-25 | 減損管理 | Form_f_flx_D_GSON.vb | d_gsonテーブルの一覧表示 | 2人日 |

**E. 物件移動・解約・再リース**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 2-26 | 物件移動 | Form_f_IDO.vb, Form_f_IDO_SUB.vb | 部署間移動処理。d_haifの配賦先変更、移動履歴記録 | 5人日 |
| 2-27 | 移動物件一覧 | Form_f_flx_IDOLST.vb, Form_f_IDOLST_JOKEN.vb | 移動履歴検索・一覧 | 3人日 |
| 2-28 | 中途解約 | Form_f_KAIYAK.vb, Form_f_KAIYAK_SUB.vb | 中途解約処理。解約損益計算、フラグ更新、残リース料精算 | 5人日 |
| 2-29 | 一括解約 | Form_f_KAIYAK_ALL.vb | 複数物件の一括解約処理 | 3人日 |
| 2-30 | 再リース | Form_f_SAILEASE.vb, Form_f_SAILEASE_SUB.vb | 再リース条件入力、リース料再計算、d_kykh/d_kykm更新 | 5人日 |
| 2-31 | 切替 | Form_f_KIRIKAE.vb | 契約切替処理 | 2人日 |

**F. マスタメンテナンス（必須10マスタ）**

| # | 作業項目 | 対象マスタ | 画面数 | 工数 |
|---|---------|-----------|-------|------|
| 2-32 | 支払方法マスタ | m_shho: flx/INP/CHANGE | 3 | 2人日 |
| 2-33 | 原価区分マスタ | m_genk: flx/INP/CHANGE | 3 | 2人日 |
| 2-34 | 部署マスタ | m_bcat: flx/INP/CHANGE + IMPORT | 4 | 3人日 |
| 2-35 | 物件管理単位マスタ | m_bknri: flx/INP/CHANGE | 3 | 2人日 |
| 2-36 | 費用区分マスタ | m_hkmk: flx/INP/CHANGE | 3 | 2人日 |
| 2-37 | 資産区分マスタ | m_skmk: flx/INP/CHANGE | 3 | 2人日 |
| 2-38 | 物件種別マスタ | m_bkind: flx/INP/CHANGE | 3 | 2人日 |
| 2-39 | 契約管理単位CHANGE | Form_f_M_KKNRI_CHANGE.vb | 1 | 1人日 |
| 2-40 | 仕訳パターンマスタ | m_swptn: flx/INP | 2 | 2人日 |
| 2-41 | 事業体マスタ（新規） | m_skti: 画面未定義→要新規作成 | 3 | 2人日 |

**G. フレックス共通ダイアログ**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 2-42 | フレックス検索エンジン | Form_f_FlexSearchDLG.vb, _Fld.vb, _Sub.vb, _Save.vb | 汎用検索条件構築。フィールド選択、条件式組立、条件保存/復元 | 8人日 |
| 2-43 | フレックスソート | Form_f_FlexSortDLG.vb | 汎用ソート条件設定 | 2人日 |
| 2-44 | フレックス出力 | Form_f_FlexOutputDLG.vb改修, _Def.vb, _Def_Sub.vb | 出力列定義、Excel/CSV/固定長出力 | 3人日 |
| 2-45 | フレックスレポート | Form_f_FlexReportDLG.vb, _Save.vb | 帳票レイアウト定義・保存 | 3人日 |

**前提条件**: フェーズ1完了（共通基盤、認証機能）
**依存関係**: CalcEngine（2-01〜2-05）は契約書・物件の保存処理に必須
**成果物**: 契約書・物件のフルCRUD、マスタメンテナンス、台帳照会機能

---

### フェーズ3: 月次・決算処理（2.5ヶ月 / 推定80-100人日）

**目的**: 月次締め処理、決算帳票出力の全機能を実装する。

#### 対象スコープ
- 月次支払照合・仕訳計上
- 標準仕訳出力（計上/支払/消費税）
- 決算帳票（注記、残高、債務、別表16）
- 期間帳票（棚卸、リース料、費用、予算、経費）

#### 具体的な作業項目

**A. 月次処理**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 3-01 | 月次支払照合ロジック完成 | Form_f_TOUGETSU_JOKEN.vb, Form_f_flx_TOUGETSU.vb | 当月支払データの照合処理。tc_rec_shriテーブルへの書き込み、BuildSqlのtodo解消 | 8人日 |
| 3-02 | 月次仕訳計上ロジック完成 | Form_f_KEIJO_JOKEN.vb, Form_f_flx_KEIJO.vb | 月次仕訳の自動生成。利息・元本・減価償却・消費税の仕訳計算、BuildSqlのtodo解消 | 8人日 |
| 3-03 | 仕訳入力画面改修 | Form_JournalEntry.vb | 既存ロジックの拡張。仕訳パターン(m_swptn)連動、消費税科目(t_szei_kmk)連動 | 3人日 |
| 3-04 | 計上区分ダイアログ | Form_f_KJKBN_DLG.vb | 計上区分(c_kjkbn)の選択ダイアログ | 1人日 |

**B. 標準仕訳出力**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 3-05 | 標準仕訳出力（計上） | Form_f_仕訳出力標準_KJ.vb | 計上仕訳のファイル出力。tc_hrelテーブル参照の科目マッピング | 5人日 |
| 3-06 | 標準仕訳出力（支払） | Form_f_仕訳出力標準_SH.vb | 支払仕訳のファイル出力 | 5人日 |
| 3-07 | 標準仕訳出力（消費税） | Form_f_仕訳出力標準_SM.vb | 消費税仕訳のファイル出力 | 5人日 |
| 3-08 | 仕訳出力設定群 | Form_f_仕訳出力標準_設定_MAIN/KJ/SH/SM.vb | 仕訳出力の設定画面（4画面） | 4人日 |
| 3-09 | 仕訳定義共通 | Form_fc_TC_SWK_DEF_COM.vb | 仕訳定義の共通設定 | 2人日 |
| 3-10 | 配賦連動テーブル管理 | Form_fc_TC_HREL.vb, Form_fc_TC_HREL_YOBI.vb | tc_hrelテーブルの15パターン設定画面 | 4人日 |

**C. 決算帳票**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 3-11 | 注記条件入力 | Form_f_CHUKI_JOKEN.vb（ロジック実装済み→完成） | 注記出力条件の入力。WHERE句動的生成 | 2人日 |
| 3-12 | 注記スケジュール完成 | Form_f_CHUKI_SCH.vb | todoコメント箇所の完成。月別リース料計算、集計行、印刷処理 | 5人日 |
| 3-13 | 注記様式（新） | Form_f_CHUKI_YOUSHIKI.vb | 財務諸表注記の様式出力。PrintDocument利用 | 5人日 |
| 3-14 | 注記様式（旧） | Form_f_CHUKI_YOUSHIKI_OLD.vb | 旧様式との互換出力 | 3人日 |
| 3-15 | 注記判定再計算 | Form_f_CHUKI_RECALC.vb | d_kykmの注記判定フラグ一括再計算バッチ | 3人日 |
| 3-16 | 注記フレックス | Form_f_flx_CHUKI.vb | 注記対象物件の一覧表示 | 2人日 |
| 3-17 | リース残高条件・一覧 | Form_f_ZANDAKA_JOKEN.vb, Form_f_ZANDAKA_SCH.vb, Form_f_flx_ZANDAKA.vb | リース残高の照会・スケジュール表示 | 5人日 |
| 3-18 | リース債務返済 | Form_f_SAIMU_JOKEN.vb, Form_f_SAIMU_SCH.vb, Form_f_flx_SAIMU.vb | 債務返済スケジュールの計算・表示 | 5人日 |
| 3-19 | 別表16(4) | Form_f_BEPPYO2_JOKEN.vb, Form_f_BEPPYO2_REP.vb, Form_f_flx_BEPPYO2.vb | 税務申告用帳票の計算・出力 | 5人日 |

**D. 期間帳票**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 3-20 | 棚卸明細 | Form_f_TANA_JOKEN.vb, Form_f_flx_TANA.vb | 棚卸報告用データ抽出 | 4人日 |
| 3-21 | 期間リース料支払明細 | Form_f_KLSRYO_JOKEN.vb, Form_f_flx_KLSRYO.vb | 期間別リース料の集計 | 4人日 |
| 3-22 | 期間費用計上明細 | Form_f_KHIYO_JOKEN.vb, Form_f_flx_KHIYO.vb | 期間別費用計上の集計 | 4人日 |
| 3-23 | 予算実績集計 | Form_f_YOSAN_JOKEN.vb, Form_f_flx_YOSAN.vb | 予算vs実績の対比集計 | 4人日 |
| 3-24 | 経費明細表 | Form_f_経費明細表_JOKEN.vb, Form_f_flx_経費明細表.vb | 経費の明細集計 | 3人日 |

**前提条件**: フェーズ2のCalcEngine完成（リース計算・消費税計算が必須）
**依存関係**: 仕訳出力はtc_hrelの設定が必要
**成果物**: 月次締め・決算処理の全機能、帳票出力

---

### フェーズ4: データ連携・セキュリティ・ログ（2ヶ月 / 推定50-70人日）

**目的**: Excel取込、セキュリティ管理、ログ管理の全機能を実装する。

#### 具体的な作業項目

**A. Excel取込・インポート**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 4-01 | 取込共通基盤 | ImportHelper.vb（新規） | EPPlus/ClosedXMLによるExcel読込共通処理、バリデーション共通ルール、取込ログ記録 | 5人日 |
| 4-02 | 取込メイン画面 | Form_f_IMPORT.vb | 取込種別選択、実行制御 | 2人日 |
| 4-03 | 契約書変更Excel取込 | Form_f_IMPORT_CONTRACT_FROM_EXCEL.vb | Excel→d_kykh更新。カラムマッピング、バリデーション | 5人日 |
| 4-04 | 物件移動Excel取込 | Form_f_IMPORT_IDO_FROM_EXCEL.vb | Excel→物件移動処理。d_haif更新 | 4人日 |
| 4-05 | 再リース/返却Excel取込 | Form_f_IMPORT_SAILEASE_FROM_EXCEL.vb | Excel→再リース処理 | 4人日 |
| 4-06 | 減損損失Excel取込 | Form_f_IMPORT_GSON_FROM_EXCEL.vb | Excel→d_gson登録 | 4人日 |
| 4-07 | 取込確認画面群 | Form_f_IMPORT_最終確認.vb, _SUB_MST.vb, _SUB_KYKH.vb | 取込前の最終確認・差分表示 | 4人日 |
| 4-08 | 取込ログ | Form_f_IMPORT_LOG.vb | 取込結果の履歴照会 | 2人日 |
| 4-09 | 部署マスタ取込 | Form_f_M_BCAT_IMPORT.vb | 部署マスタの一括取込 | 2人日 |
| 4-10 | 配賦予備マスタ取込 | Form_f_M_RSRVH1_IMPORT_1.vb, _2.vb | 配賦予備マスタの取込 | 2人日 |

**B. セキュリティ管理**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 4-11 | ユーザー管理 | Form_f_flx_SEC_USER.vb, Form_f_SEC_USER_INP.vb | sec_userテーブルのCRUD。パスワードポリシー管理 | 4人日 |
| 4-12 | 権限管理 | Form_f_flx_SEC_KNGN.vb, Form_f_SEC_KNGN_INP.vb, _SUB.vb, _B_SUB.vb | sec_kngn/sec_kngn_bknri/sec_kngn_kknriのCRUD | 5人日 |

**C. ログ管理**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 4-13 | セッションログ | Form_f_00SLOG.vb, _JOKEN.vb, _M.vb | l_slogテーブルの検索・表示 | 3人日 |
| 4-14 | 更新ログ | Form_f_00ULOG.vb, _JOKEN.vb, _M.vb | l_ulogテーブルの検索・表示 | 3人日 |
| 4-15 | バックアップログ | Form_f_00BKLOG.vb | l_bklogテーブルの照会 | 1人日 |
| 4-16 | ログ削除 | Form_f_00LOGDEL.vb | 古いログの一括削除 | 1人日 |
| 4-17 | 前回ログ | Form_f_ZENKAI_LOG.vb | 前回集計時の情報表示 | 1人日 |

**D. テーブルメンテナンス**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 4-18 | 追加借入利子率 | Form_f_T_KARI_RITU.vb, _INP.vb, _CHANGE.vb | t_kari_rituテーブルのCRUD | 2人日 |
| 4-19 | 消費税率テーブル | Form_f_T_ZEI_KAISEI.vb, _INP.vb, _CHANGE.vb | t_zei_kaiseiテーブルのCRUD | 2人日 |
| 4-20 | 休日テーブル | Form_f_T_HOLIDAY.vb | t_holidayテーブルのCRUD | 1人日 |
| 4-21 | 契約番号採番設定 | Form_f_T_KYKBNJ_SEQ.vb | t_kykbnj_seqテーブルの設定 | 1人日 |
| 4-22 | 年金現価計算式 | Form_0f_MNT_tcon_年金現価の計算式.vb | 計算式パラメータの管理 | 2人日 |
| 4-23 | 一括削除 | Form_0f_一括削除_JOKEN.vb | 条件指定によるデータ一括削除 | 2人日 |

**前提条件**: フェーズ1の認証基盤、フェーズ2のマスタメンテナンス
**成果物**: データ取込、セキュリティ管理、監査ログ機能

---

### フェーズ5: カスタム仕訳・推奨マスタ・仕上げ（2.5ヶ月 / 推定80-100人日）

**目的**: 顧客別カスタム仕訳出力、残りのマスタ、その他全機能を完成させる。

#### 具体的な作業項目

**A. カスタム仕訳出力（14社）**

| # | 作業項目 | 対象会社 | 画面数 | 工数 |
|---|---------|---------|-------|------|
| 5-01 | YAMASHIN | 計上+支払 | 2 | 4人日 |
| 5-02 | VTC | 計上+支払+支払先確認+明細 | 4 | 5人日 |
| 5-03 | RISO | 計上+支払+最終確認 | 3 | 4人日 |
| 5-04 | NKSOL | 計上+支払+経費 | 3 | 4人日 |
| 5-05 | NIFS | 計上+経費 | 2 | 3人日 |
| 5-06 | MARUZEN | 計上+SUB | 2 | 4人日 |
| 5-07 | KYOTO | 計上+支払 | 2 | 4人日 |
| 5-08 | KITOKU | 計上+支払+SUB | 3 | 4人日 |
| 5-09 | JOT | 計上+支払+伝票番号 | 3 | 5人日 |
| 5-10 | VALQUA | 計上+支払+長短振替 | 3 | 5人日 |
| 5-11 | TSYSCOM | 計上+支払+移動 | 3 | 4人日 |
| 5-12 | SANKO_AIR | 振替伝票(5種)+登録届+変更願+異動届+計上用 | 9 | 10人日 |
| 5-13 | MYCOM | 仕訳出力+Sub+会社MNT+伝票印刷(3種) | 6 | 10人日 |
| 5-14 | SNKO | 計上条件+支払条件+SUB+最終確認(2種) | 5 | 5人日 |

**B. 推奨マスタメンテナンス（残り9マスタ）**

| # | 作業項目 | 対象マスタ | 画面数 | 工数 |
|---|---------|-----------|-------|------|
| 5-15 | 銀行口座マスタ | m_koza: flx/INP/CHANGE | 3 | 2人日 |
| 5-16 | 業者マスタ | m_gsha: flx/INP/CHANGE | 3 | 2人日 |
| 5-17 | メーカーマスタ | m_mcpt: flx/INP/CHANGE | 3 | 2人日 |
| 5-18 | 廃棄方法マスタ | m_hkho: flx/INP/CHANGE | 3 | 2人日 |
| 5-19 | 予備（契約書用） | m_rsrvk1: flx/INP/CHANGE | 3 | 2人日 |
| 5-20 | 予備（物件用） | m_rsrvb1: flx/INP/CHANGE | 3 | 2人日 |
| 5-21 | 予備（配賦用） | m_rsrvh1: flx/INP_SNKO | 2 | 2人日 |
| 5-22 | 支払先MYCOM用 | m_lcpt MYCOM: flx/INP | 2 | 2人日 |
| 5-23 | 予算旧版 | Form_f_YOSAN_JOKEN_OLD.vb, _MYCOM.vb | 2 | 2人日 |

**C. その他残機能**

| # | 作業項目 | 対象ファイル | 詳細 | 工数 |
|---|---------|-------------|------|------|
| 5-24 | バックアップ/復元 | Form_f_BKUP_PASSWORD.vb, Form_f_RESTORE_PASSWORD.vb | データバックアップ・復元 | 2人日 |
| 5-25 | バージョン情報 | Form_f_00VerInfo.vb | t_systemからのバージョン表示 | 0.5人日 |
| 5-26 | データパス設定 | Form_f_00DataPass.vb | 出力先パスの設定 | 1人日 |
| 5-27 | リンク確認 | Form_f_LINK_KAKUNIN.vb | DB接続リンクの確認 | 1人日 |
| 5-28 | ステータスメーター | Form_f_StatusMeter.vb | 長時間処理の進捗表示 | 1人日 |
| 5-29 | 開発ツール | Form_f_0開発ツール.vb | 開発者用管理ツール | 1人日 |
| 5-30 | 共通コンボ基底改修 | Form_BCAT.vb, Form_BKNRI.vb, Form_KKNRI.vb, Form_HKMK.vb, Form_SKMK.vb | 基底フォームのロジック完成 | 3人日 |

**前提条件**: フェーズ3の仕訳出力基盤が完成していること
**成果物**: 全機能の完全実装、Access版との完全互換

---

## 3. 未実装機能の詳細作業リスト

### 3.1 共通基盤（未実装7件）

| 機能名 | Access版実装場所 | VB.NET推奨実装先 | 実装詳細 | 注意点 | 推定行数 |
|--------|----------------|-----------------|---------|--------|---------|
| 定数定義 | VBA定数 / c_*テーブル値 | Constants.vb（新規） | Enum定義 (KjkbnId, KkbnId, LeakbnId, ChuumId, RcalcId, SkyakHoId, SzeiKjkbnId) | c_*テーブルの値と完全一致させること | 200行 |
| セッション管理 | Access CurrentUser / TempVars | SessionManager.vb（新規） | Sharedプロパティ: CurrentUserId, CurrentUserName, KngnId, LoginTime | スレッドセーフにする必要なし（WinFormsはシングルスレッド） | 150行 |
| 権限チェック | g_Security モジュール推定 | SecurityHelper.vb（新規） | HasPermission(funcName), GetAccessibleKknriIds(), GetAccessibleBknriIds(), IsAdmin() | sec_kngn_bknri/sec_kngn_kknriの両方をチェック | 250行 |
| ログ記録 | g_Log モジュール推定 | LogHelper.vb（新規） | WriteSessionLog(action, detail), WriteUpdateLog(tableName, recordId, beforeJson, afterJson) | l_slog.slog_noは自動採番、l_ulogはslog_noとulog_noの複合PK | 200行 |
| 採番処理 | gfnc_GetNextID推定 | SequenceHelper.vb（新規） | GetNextId(fieldName)でt_seq.current_valをインクリメント。GetNextKykbnj()でt_kykbnj_seq参照 | 排他制御が必要（SELECT FOR UPDATE） | 100行 |
| 楽観的排他制御 | DAO.RecordsetのEdit/Update | CrudHelper.vb 拡張 | UpdateWithOptimisticLock(table, values, where, expectedUpdateCnt) | update_cnt不一致時は「他ユーザーが更新済み」エラー | 50行 |
| エラーハンドリング | VBA On Error GoTo | ErrorHandler.vb（新規） + Program.vb | HandleGlobalException(), ShowFriendlyError() | Application.ThreadException + AppDomain.UnhandledException | 100行 |

### 3.2 リース計算エンジン（未実装5件）

| 機能名 | Access版実装場所（推定） | VB.NET推奨実装先 | 実装詳細 | 注意点 | 推定行数 |
|--------|----------------------|-----------------|---------|--------|---------|
| 年金現価計算 | gfnc_CalcPresentValue | CalcEngine.vb:CalcPresentValue() | PV = PMT * [(1-(1+r)^-n)/r]。tcon_年金現価テーブルのパラメータ参照 | 浮動小数点誤差回避のためDecimal型必須 | 200行 |
| リース料計算 | gfnc_CalcLeaseFee | CalcEngine.vb:CalcLeaseFee() | 月額リース料、利息額、元本返済額の月別按分計算 | 端数処理は銀行丸め（RoundBank）を適用 | 300行 |
| 償却額計算 | gfnc_CalcDepreciation | DepreciationCalc.vb:Calc() | 定額法: (取得価額-残存価額)/耐用年数、定率法: 未償却残高*償却率 | c_skyak_hoの値に応じた分岐 | 200行 |
| 消費税計算 | gfnc_CalcTax | TaxCalcHelper.vb:CalcTax() | t_zei_kaiseiからの税率取得、c_szei_kjkbnに応じた計算方法分岐 | 軽減税率・経過措置の対応が必要 | 150行 |
| 支払日計算 | gfnc_GetPayDate | PaymentDateCalc.vb:GetPayDate() | m_lcpt.shime_day/shri_dayからの支払日算出、t_holiday参照の営業日シフト | 月末日の扱い（28日/29日/30日/31日）に注意 | 100行 |

### 3.3 セキュリティ機能（未実装3画面 + ロジック）

| 機能名 | Access版実装場所 | VB.NET推奨実装先 | 実装詳細 | 注意点 | 推定行数 |
|--------|----------------|-----------------|---------|--------|---------|
| ログイン | Form_f_LOGIN_JET | Form_f_LOGIN_JET.vb | sec_userテーブル認証、パスワードハッシュ(BCrypt推奨)、ログイン試行回数管理、セッションログ記録 | Access版はMD5相当の可能性→移行時にハッシュ方式変更が必要 | 200行 |
| ユーザー管理 | Form_f_SEC_USER_INP | Form_f_flx_SEC_USER.vb + Form_f_SEC_USER_INP.vb | ユーザーCRUD、権限割当、パスワードリセット | パスワードポリシー（長さ/複雑さ/有効期限）の実装 | 300行(2画面合計) |
| 権限管理 | Form_f_SEC_KNGN_INP | Form_f_flx_SEC_KNGN.vb + Form_f_SEC_KNGN_INP.vb + _SUB.vb + _B_SUB.vb | 権限グループCRUD、機能別権限設定、物件分類別/管理単位別アクセス制御 | admin/master_update/file_output/print/log_ref/approvalの6機能フラグ | 500行(4画面合計) |

### 3.4 インポート機能（未実装11画面）

| 機能名 | Access版実装場所（推定） | VB.NET推奨実装先 | 実装詳細 | 注意点 | 推定行数 |
|--------|----------------------|-----------------|---------|--------|---------|
| 取込共通基盤 | pc_IMPORT モジュール | ImportHelper.vb（新規） | Excel読込(EPPlus)、カラムマッピング、バリデーションルール、エラー行収集、取込ログ記録 | Access版のTransferSpreadsheet相当の汎用処理 | 400行 |
| 契約書変更取込 | Form_f_IMPORT_CONTRACT_FROM_EXCEL | 同名.vb | Excelテンプレート→d_kykh UPDATE。変更前後の差分表示 | 既存契約のロック状態チェック | 300行 |
| 物件移動取込 | Form_f_IMPORT_IDO_FROM_EXCEL | 同名.vb | Excel→物件移動処理。移動元/移動先部署の妥当性チェック | d_haifの按分率再計算が必要 | 300行 |
| 再リース取込 | Form_f_IMPORT_SAILEASE_FROM_EXCEL | 同名.vb | Excel→再リース/返却処理。リース料再計算 | 再リース期間の妥当性チェック | 300行 |
| 減損損失取込 | Form_f_IMPORT_GSON_FROM_EXCEL | 同名.vb | Excel→d_gson INSERT。減損額の妥当性チェック | 減損累計額の上限チェック | 250行 |

### 3.5 決算帳票（未実装14画面）

| 機能名 | Access版実装場所 | VB.NET推奨実装先 | 実装詳細 | 注意点 | 推定行数 |
|--------|----------------|-----------------|---------|--------|---------|
| 注記様式出力 | Form_f_CHUKI_YOUSHIKI | 同名.vb | IAS17/IFRS16準拠の注記様式帳票。1年内/1年超のリース料分類、PrintDocument描画 | 会計基準の正確な反映が必須 | 400行 |
| リース残高一覧 | Form_f_ZANDAKA系(3画面) | 同名.vb(3件) | 物件別のリース資産残高/減価償却累計額/帳簿価額の計算・表示 | 月次減価償却との整合性確認 | 500行(3画面) |
| 債務返済明細 | Form_f_SAIMU系(3画面) | 同名.vb(3件) | リース債務の元本/利息内訳、1年内/1年超分類 | 変更リース・再リースの影響を正確に反映 | 500行(3画面) |
| 別表16(4) | Form_f_BEPPYO2系(3画面) | 同名.vb(3件) | 税務申告書「別表16(4)」の様式に準拠した帳票出力 | 税法上の要件に厳密に準拠 | 500行(3画面) |

### 3.6 カスタム仕訳出力（未実装約50画面）

各社のカスタム仕訳は、共通の仕訳出力基盤の上に顧客固有のフォーマット・ルールを追加する構造。

| 会社名 | 画面数 | 固有ロジック | 推定行数(合計) |
|--------|-------|-------------|--------------|
| YAMASHIN | 2 | 計上+支払仕訳の独自フォーマット | 300行 |
| VTC | 4 | 支払先確認画面、明細出力、独自帳票フォーマット | 500行 |
| RISO | 3 | 最終確認画面付き | 400行 |
| NKSOL | 3 | 経費仕訳あり | 400行 |
| NIFS | 2 | 経費仕訳あり | 250行 |
| MARUZEN | 2 | サブ画面付き | 350行 |
| KYOTO | 2 | 計上+支払 | 300行 |
| KITOKU | 3 | サブ画面付き | 400行 |
| JOT | 3 | 伝票番号管理 | 400行 |
| VALQUA | 3 | 長短振替仕訳 | 400行 |
| TSYSCOM | 3 | 移動仕訳 | 400行 |
| SANKO_AIR | 9 | 振替伝票5種類+登録届+変更願+異動届+計上用 | 1200行 |
| MYCOM | 6 | 仕訳出力+伝票印刷3種+会社MNT | 1000行 |
| SNKO | 5 | 計上+支払条件+サブ+最終確認2種 | 600行 |

---

## 4. テーブル追加・修正リスト

### 4.1 DDLに未定義だが必要と推定されるテーブル

| # | テーブル名（推定） | 用途 | 根拠 | 対応方針 |
|---|------------------|------|------|---------|
| 1 | tcon_nenkin_genka | 年金現価の計算式パラメータ | Form_0f_MNT_tcon_年金現価の計算式.vb が存在 | 新規DDL作成が必要 |
| 2 | w_tougetsu | 月次支払照合ワークテーブル | Form_f_flx_TOUGETSU.vbのBuildSqlで参照される可能性 | DataTable（メモリ上）で代替可能か、PostgreSQL一時テーブルで対応 |
| 3 | w_keijo | 月次仕訳計上ワークテーブル | Form_f_flx_KEIJO.vbのBuildSqlで参照される可能性 | 同上 |
| 4 | w_chuki | 注記計算ワークテーブル | Form_f_CHUKI_SCH.vbのBuildSqlでUNION ALL動的生成 | 同上 |
| 5 | w_zandaka | 残高計算ワークテーブル | 残高スケジュール計算の中間データ | 同上 |
| 6 | w_saimu | 債務返済計算ワークテーブル | 債務返済スケジュール計算の中間データ | 同上 |
| 7 | w_beppyo | 別表16(4)計算ワークテーブル | 別表計算の中間データ | 同上 |
| 8 | t_import_log | 取込ログ詳細 | Form_f_IMPORT_LOG.vb が参照するログテーブル | 新規DDL作成が必要 |
| 9 | t_flex_search_save | フレックス検索条件保存 | Form_f_FlexSearchDLG_Save.vb の条件保存先 | 新規DDL作成が必要 |
| 10 | t_flex_output_def | フレックス出力定義 | Form_f_FlexOutputDLG_Def.vb の定義保存先 | 新規DDL作成が必要 |
| 11 | t_flex_report_save | フレックスレポート定義 | Form_f_FlexReportDLG_Save.vb のレポート保存先 | 新規DDL作成が必要 |

### 4.2 既存テーブルで追加が必要と推定されるカラム

| # | テーブル名 | 追加カラム（推定） | 型 | 用途 |
|---|-----------|------------------|-----|------|
| 1 | sec_user | password_hash | VARCHAR(256) | パスワードハッシュ値（Access版のパスワード方式から変更） |
| 2 | sec_user | login_fail_count | INTEGER | ログイン失敗回数（アカウントロック用） |
| 3 | sec_user | last_login_dt | TIMESTAMP | 最終ログイン日時 |
| 4 | sec_user | password_changed_dt | TIMESTAMP | パスワード最終変更日時 |
| 5 | 全データテーブル | update_cnt | INTEGER DEFAULT 0 | 楽観的排他制御用カウンタ（一部テーブルに既存の場合あり） |

### 4.3 追加が必要なDDLファイル

| # | ファイル名 | 内容 |
|---|-----------|------|
| 1 | sql/002_initial_data.sql | c_*テーブル初期データ、t_system/t_opt初期値 |
| 2 | sql/003_add_tables.sql | tcon_nenkin_genka, t_import_log, t_flex_*テーブル |
| 3 | sql/004_alter_tables.sql | sec_userへのカラム追加、update_cntカラム追加 |
| 4 | sql/005_create_indexes.sql | パフォーマンス用追加インデックス |
| 5 | sql/006_create_views.sql | フレックス一覧用のビュー定義（JOINの効率化） |

---

## 5. 技術的課題と対策

### 5.1 Access固有機能の代替方法

| Access固有機能 | 課題 | VB.NET代替方法 | 実装難度 |
|--------------|------|--------------|---------|
| DoCmd.OpenForm (acDialog) | モーダル/モードレス制御 | Form.ShowDialog() / Form.Show() | 低 |
| DoCmd.OpenForm (WhereCondition) | フォームにSQL条件渡し | コンストラクタ引数 or プロパティ設定 | 低 |
| Me.Recordset / RecordsetClone | フォームバインドRecordset | DataTable + CrudHelper.GetDataTable() | 中 |
| DLookup() / DCount() / DSum() | ドメイン集計関数 | CrudHelper.ExecuteScalar(Of T)() | 低（実装済み） |
| Nz() | Null安全変換 | Utils.NzInt()/NzDate()/NzDec() | 低（実装済み） |
| Access Report | 帳票印刷 | PrintDocument + PrintPreviewDialog | 高 |
| DoCmd.TransferSpreadsheet | Excel入出力 | FileHelper + EPPlus/ClosedXML | 中 |
| TempVars | グローバル変数 | SessionManager (Sharedプロパティ) | 低 |
| Access Security (MDW) | ワークグループセキュリティ | sec_user/sec_kngnテーブル + カスタム認証 | 中 |
| CurrentDb.TableDefs | テーブル構造参照 | NpgsqlのInformation_Schema | 低 |
| Access Macro | マクロ自動化 | VB.NETイベントハンドラ | 低 |
| Eval() | 動的式評価 | DataTable.Compute() or ScriptEngine | 高 |
| Access Query (CrossTab) | クロス集計クエリ | PostgreSQL CROSSTAB or CASE WHEN + PIVOT | 中 |

### 5.2 DAOからADO.NETへの変換パターン

**パターン1: 単純SELECT**
```
' Access VBA (DAO)
Dim rs As DAO.Recordset
Set rs = CurrentDb.OpenRecordset("SELECT * FROM m_corp WHERE history_f = False")
Do While Not rs.EOF
    Debug.Print rs!corp_id & " " & rs!corp1_nm
    rs.MoveNext
Loop
rs.Close

' VB.NET (CrudHelper)
Dim dt As DataTable = _crud.GetDataTable(
    "SELECT * FROM m_corp WHERE history_f = FALSE")
For Each row As DataRow In dt.Rows
    Console.WriteLine(row("corp_id") & " " & row("corp1_nm"))
Next
```

**パターン2: パラメータ付きSELECT**
```
' Access VBA (DAO)
Dim rs As DAO.Recordset
Set rs = CurrentDb.OpenRecordset("SELECT * FROM d_kykh WHERE kykh_id = " & lngId)

' VB.NET (CrudHelper)
Dim dt As DataTable = _crud.GetDataTable(
    "SELECT * FROM d_kykh WHERE kykh_id = @id",
    New NpgsqlParameter("@id", kykhId))
```

**パターン3: INSERT（Dictionary指定）**
```
' Access VBA (DAO)
Dim rs As DAO.Recordset
Set rs = CurrentDb.OpenRecordset("d_kykh")
rs.AddNew
rs!kykbnj = strKykbnj
rs!lcpt_id = lngLcptId
rs.Update

' VB.NET (CrudHelper)
Dim values As New Dictionary(Of String, Object) From {
    {"kykbnj", kykbnj},
    {"lcpt_id", lcptId}
}
_crud.Insert("d_kykh", values)
```

**パターン4: トランザクション**
```
' Access VBA (DAO)
DBEngine.Workspaces(0).BeginTrans
On Error GoTo ErrHandler
    CurrentDb.Execute "INSERT INTO ..."
    CurrentDb.Execute "UPDATE ..."
DBEngine.Workspaces(0).CommitTrans
Exit Sub
ErrHandler:
    DBEngine.Workspaces(0).Rollback

' VB.NET (CrudHelper)
_crud.BeginTransaction()
Try
    _crud.ExecuteNonQuery("INSERT INTO ...")
    _crud.ExecuteNonQuery("UPDATE ...")
    _crud.Commit()
Catch ex As Exception
    _crud.Rollback()
    Throw
End Try
```

**パターン5: DLookup → ExecuteScalar**
```
' Access VBA
Dim strName As String
strName = Nz(DLookup("corp1_nm", "m_corp", "corp_id = " & lngId), "")

' VB.NET
Dim corpName As String = _crud.ExecuteScalar(Of String)(
    "SELECT corp1_nm FROM m_corp WHERE corp_id = @id",
    New NpgsqlParameter("@id", corpId))
```

### 5.3 ワークテーブル方式の代替設計

Access版では中間計算結果をワークテーブル（tcon_*, W_*）に書き込む方式が多用されていると推定される。VB.NET版では以下の3パターンで対応する。

| パターン | 適用場面 | 実装方法 | メリット | デメリット |
|---------|---------|---------|---------|-----------|
| **A. メモリ上DataTable** | 計算結果が小規模（数千行以下）| DataTable dt = CalcEngine.Calc(); dgv.DataSource = dt; | DB負荷なし、高速 | メモリ消費、永続化不可 |
| **B. PostgreSQL一時テーブル** | 計算結果が大規模、SQLで後続処理 | CREATE TEMP TABLE w_xxx AS SELECT ...; | 大量データ対応、SQL結合可能 | DB負荷、セッション管理 |
| **C. PostgreSQLマテリアライズドビュー** | 定期的に参照される集計結果 | CREATE MATERIALIZED VIEW mv_xxx AS ...; | 高速参照、自動更新 | リフレッシュタイミング管理 |

**推奨適用**:
- 月次支払照合 (w_tougetsu) → **パターンA**（1ヶ月分のデータ量は限定的）
- 月次仕訳計上 (w_keijo) → **パターンA**
- 注記計算 (w_chuki) → **パターンB**（UNION ALL動的生成のため複雑なSQL）
- 残高計算 (w_zandaka) → **パターンB**（全物件の残高計算で大量データ）
- 債務返済計算 (w_saimu) → **パターンB**
- 別表16計算 (w_beppyo) → **パターンB**

### 5.4 レポート出力の代替方法

Access Reportの代替として、以下の3段階のアプローチを採用する。

**段階1: DataGridView → Excel出力（既に基盤あり）**
- FileHelper.ToExcelFile() で DataGridView の内容をExcel出力
- 大半のフレックス一覧帳票はこの方式で対応可能
- 実装コスト: 低

**段階2: PrintDocument による印刷**
- 注記様式、別表16(4)、支払伝票など定型帳票に使用
- PrintHelper.vb（新規作成）で共通化
- Graphics.DrawString() によるテキスト描画、罫線描画
- 実装コスト: 中〜高

**段階3: Excelテンプレート出力（推奨）**
- EPPlus/ClosedXML でExcelテンプレートにデータ埋め込み
- 複雑な帳票レイアウトの再現が容易
- ユーザーがExcel上で加工可能
- 実装コスト: 中

**帳票別の推奨方式**:

| 帳票 | 推奨方式 | 理由 |
|------|---------|------|
| フレックス一覧系（16種） | 段階1 (Excel直接出力) | 一覧表で十分 |
| 注記様式 | 段階3 (Excelテンプレート) | 定型帳票だがレイアウトが複雑 |
| 別表16(4) | 段階3 (Excelテンプレート) | 税務様式に準拠が必要 |
| 支払伝票 (MYCOM等) | 段階2 (PrintDocument) | 印刷が主用途 |
| 振替伝票 (SANKO_AIR) | 段階2 (PrintDocument) | 印刷が主用途 |
| 仕訳ファイル出力 | FileHelper (CSV/固定長) | ファイル連携 |

### 5.5 JET SQL → PostgreSQL SQL変換の主要パターン

| JET SQL | PostgreSQL | 備考 |
|---------|-----------|------|
| `IIf(条件, 真, 偽)` | `CASE WHEN 条件 THEN 真 ELSE 偽 END` | -- |
| `Nz(値, 代替)` | `COALESCE(値, 代替)` | -- |
| `True/False` | `TRUE/FALSE` | 大文字小文字問わず |
| `#2026/01/01#` | `'2026-01-01'::DATE` | 日付リテラル |
| `Format(日付, "yyyy/mm")` | `TO_CHAR(日付, 'YYYY/MM')` | -- |
| `DateAdd("m", 1, 日付)` | `日付 + INTERVAL '1 month'` | -- |
| `DateDiff("m", 日付1, 日付2)` | `EXTRACT(YEAR FROM AGE(日付2, 日付1))*12 + EXTRACT(MONTH FROM AGE(日付2, 日付1))` | 月数差 |
| `Left(文字列, n)` | `LEFT(文字列, n)` | 同一 |
| `Mid(文字列, s, n)` | `SUBSTRING(文字列 FROM s FOR n)` | -- |
| `Val(文字列)` | `CAST(文字列 AS NUMERIC)` | -- |
| `TRANSFORM ... PIVOT` | `CROSSTAB()` or 動的CASE WHEN | 拡張機能 |
| `& (文字列結合)` | `||` | -- |
| テーブル名にスペース `[Table Name]` | `"table_name"` (ダブルクォート) | 命名規則で回避済み |

---

## 6. 移行優先度マトリクス

### 6.1 マトリクス図

```
                        技術難易度
                  低              中              高
            ┌─────────────┬─────────────┬─────────────┐
            │             │             │             │
   高       │  マスタ      │  契約書管理  │  リース計算   │
            │  メンテナンス │  物件管理   │  エンジン     │
  ビ        │  (19マスタ)  │  月次処理   │  注記判定     │
  ジ        │  ログイン    │  仕訳出力   │  別表16(4)   │
  ネ        │             │  (標準)     │  年金現価計算  │
  ス        ├─────────────┼─────────────┼─────────────┤
            │             │             │             │
  イ  中    │  ログ管理    │  解約処理   │  カスタム仕訳  │
  ン        │  テーブル    │  再リース   │  (14社)      │
  パ        │  メンテナンス │  物件移動   │  フレックス   │
  ク        │  パスワード  │  Excel取込  │  検索エンジン  │
  ト        │  管理       │             │  帳票印刷     │
            ├─────────────┼─────────────┼─────────────┤
            │             │             │             │
   低       │  ダミー画面  │  バックアップ │  開発ツール   │
            │  バージョン  │  復元       │  Eval代替    │
            │  情報       │  予算旧版   │              │
            │  ステータス  │  MYCOM版    │              │
            │  メーター   │             │              │
            └─────────────┴─────────────┴─────────────┘
```

### 6.2 優先度別の推奨実装順

**最優先（ビジネスインパクト高 x 技術難易度低〜中）: フェーズ1-2**
| # | 機能 | BI | 難易度 | フェーズ |
|---|------|-----|--------|---------|
| 1 | 共通基盤（認証・権限・ログ・採番） | 高 | 低 | 1 |
| 2 | マスタメンテナンス（必須10マスタ） | 高 | 低 | 2 |
| 3 | 契約書管理（CRUD全般） | 高 | 中 | 2 |
| 4 | 物件管理（CRUD・分割・移動） | 高 | 中 | 2 |
| 5 | リース計算エンジン | 高 | 高 | 2 |
| 6 | 注記判定・計算 | 高 | 高 | 2 |

**高優先（ビジネスインパクト高 x 技術難易度中〜高）: フェーズ3**
| # | 機能 | BI | 難易度 | フェーズ |
|---|------|-----|--------|---------|
| 7 | 月次支払照合 | 高 | 中 | 3 |
| 8 | 月次仕訳計上 | 高 | 中 | 3 |
| 9 | 標準仕訳出力 | 高 | 中 | 3 |
| 10 | 別表16(4) | 高 | 高 | 3 |
| 11 | リース残高一覧 | 高 | 中 | 3 |
| 12 | リース債務返済明細 | 高 | 中 | 3 |
| 13 | 棚卸明細 | 高 | 中 | 3 |

**中優先（ビジネスインパクト中 x 技術難易度中）: フェーズ4**
| # | 機能 | BI | 難易度 | フェーズ |
|---|------|-----|--------|---------|
| 14 | 解約処理 | 中 | 中 | 4 |
| 15 | 再リース処理 | 中 | 中 | 4 |
| 16 | Excel取込（4種） | 中 | 中 | 4 |
| 17 | セキュリティ管理（ユーザー・権限） | 中 | 中 | 4 |
| 18 | ログ管理（セッション・更新） | 中 | 低 | 4 |

**低優先（ビジネスインパクト中 x 技術難易度高、またはBI低）: フェーズ5**
| # | 機能 | BI | 難易度 | フェーズ |
|---|------|-----|--------|---------|
| 19 | カスタム仕訳出力（14社） | 中 | 高 | 5 |
| 20 | フレックス検索エンジン | 中 | 高 | 2 |
| 21 | 推奨マスタ（9マスタ） | 中 | 低 | 5 |
| 22 | 帳票印刷（PrintDocument） | 中 | 高 | 5 |
| 23 | 予算旧版・MYCOM版 | 低 | 中 | 5 |
| 24 | 開発ツール・ダミー画面 | 低 | 低 | 5 |

### 6.3 全体工数サマリ

| フェーズ | 期間 | 推定工数 | 累計 |
|---------|------|---------|------|
| フェーズ1: 基盤整備 | 1.5ヶ月 | 30-40人日 | 30-40 |
| フェーズ2: コア業務 | 3ヶ月 | 120-150人日 | 150-190 |
| フェーズ3: 月次・決算 | 2.5ヶ月 | 80-100人日 | 230-290 |
| フェーズ4: データ連携・セキュリティ | 2ヶ月 | 50-70人日 | 280-360 |
| フェーズ5: カスタム・仕上げ | 2.5ヶ月 | 80-100人日 | 360-460 |
| **合計** | **約11.5ヶ月** | **360-460人日** | |

**注記**: 上記工数にはテスト工数（単体テスト・結合テスト・ユーザー受入テスト）は含まれていない。テスト工数は実装工数の40-60%を見込む必要がある。テスト込みの総工数は **500-740人日** と推定される。

---

*本文書は gap_analysis/01_access_inventory.md, 02_vbnet_inventory.md, 03_checklist.md の分析結果、および実際のVB.NETソースコード・SQLの調査に基づいて作成された。*
