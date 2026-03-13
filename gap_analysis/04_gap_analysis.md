# Access版 vs VB.NET版 Gap分析レポート（充足率算出）

**分析日**: 2026-03-13
**分析対象**: LeaseM4BS (リース資産管理システム)
**入力ドキュメント**: 01_access_inventory.md, 02_vbnet_inventory.md, 03_checklist.md
**分析チーム**: 自動分析

---

## 1. カテゴリ別充足率

チェックリスト（03_checklist.md）のカテゴリA〜Gに基づく充足率。

### A. データベース層（DDL/テーブル定義）

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| A-1. コードテーブル（c_*） | 10 | 10 | 0 | 0 | 100% |
| A-2. マスタテーブル（m_*） | 19 | 19 | 0 | 0 | 100% |
| A-3. データテーブル（d_*） | 6 | 6 | 0 | 0 | 100% |
| A-4. セキュリティテーブル（sec_*） | 4 | 4 | 0 | 0 | 100% |
| A-5. システムテーブル（t_*） | 11 | 11 | 0 | 0 | 100% |
| A-6. ログテーブル（l_*） | 3 | 3 | 0 | 0 | 100% |
| A-7. トランザクションテーブル（tc_*） | 2 | 2 | 0 | 0 | 100% |
| A-8. インデックス・制約 | 4 | 3 | 0 | 1 | 75% |
| **A合計** | **59** | **58** | **0** | **1** | **98.3%** |

備考: 55テーブルのDDL（sql/001_create_tables.sql）は全て定義済み。PK/UNIQUEインデックスも定義済み。外部キー制約のみ未追加（A-8-04）。

### B. 画面（UI層）

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| B-1. メインナビゲーション | 3 | 3 | 0 | 0 | 100% |
| B-2. 契約管理フォーム | 9 | 2 | 0 | 7 | 22.2% |
| B-3. 注記判定フォーム | 6 | 0 | 2 | 4 | 16.7% |
| B-4. 変更管理フォーム | 3 | 0 | 0 | 3 | 0% |
| B-5. 参照フォーム | 6 | 0 | 0 | 6 | 0% |
| B-6. フレックス一覧（台帳タブ） | 9 | 2 | 0 | 7 | 22.2% |
| B-7. フレックス共通ダイアログ | 10 | 1 | 0 | 9 | 10.0% |
| B-8. マスタメンテナンスフォーム | 19 | 3 | 0 | 16 | 15.8% |
| B-9. 共通コンボ基底フォーム | 6 | 1 | 0 | 5 | 16.7% |
| **B合計** | **71** | **12** | **2** | **57** | **18.3%** |

備考: Designer.vb（UI配置）は約250画面全てに存在するが、ロジック（.vb）実装済みは約20画面のみ。残り約160画面はスタブ（New()+InitializeComponent()のみ）。

### C. ビジネスロジック層

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| C-1. 契約管理 | 5 | 2 | 1 | 2 | 50.0% |
| C-2. 物件管理 | 7 | 1 | 1 | 5 | 21.4% |
| C-3. 再リース処理 | 3 | 0 | 0 | 3 | 0% |
| C-4. 中途解約処理 | 4 | 0 | 0 | 4 | 0% |
| C-5. 注記判定・計算 | 6 | 1 | 2 | 3 | 33.3% |
| C-6. 返済スケジュール計算 | 6 | 0 | 0 | 6 | 0% |
| C-7. 資産管理・償却計算 | 6 | 0 | 0 | 6 | 0% |
| C-8. 各種集計処理 | 15 | 0 | 4 | 11 | 13.3% |
| C-9. 仕訳出力（標準） | 10 | 1 | 0 | 9 | 10.0% |
| C-10. 仕訳出力（カスタム14社） | 14 | 0 | 0 | 14 | 0% |
| C-11. 仕訳共通 | 3 | 0 | 0 | 3 | 0% |
| **C合計** | **79** | **5** | **8** | **66** | **11.4%** |

備考: 契約書入力(Form_ContractEntry.vb)と物件入力(Form_BuknEntry.vb)のロジックが最も進んでいるが、保存処理等に未実装(todo)あり。注記条件(CHUKI_JOKEN)は完全実装。月次処理はSQL構築まで進んでいるが計算列にtodo多数。

### D. 帳票・レポート層

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| D-01〜D-12. 各種帳票 | 12 | 0 | 1 | 11 | 4.2% |
| D-13. Excel出力（共通） | 1 | 1 | 0 | 0 | 100% |
| D-14. CSV出力（共通） | 1 | 1 | 0 | 0 | 100% |
| D-15. 固定長出力（共通） | 1 | 0 | 1 | 0 | 50.0% |
| **D合計** | **15** | **2** | **2** | **11** | **20.0%** |

備考: ファイル出力基盤（FileHelper.vb）のExcel/CSVは実装済み。固定長ファイル出力は未完成。注記スケジュール帳票（CHUKI_SCH）のみ一部実装。

### E. データ取込・連携

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| E-1. Excel取込 | 11 | 0 | 0 | 11 | 0% |
| E-2. マスタ取込 | 4 | 0 | 0 | 4 | 0% |
| E-3. バックアップ/復元 | 2 | 0 | 0 | 2 | 0% |
| **E合計** | **17** | **0** | **0** | **17** | **0%** |

### F. システム管理

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| F-1. ログイン/認証 | 3 | 0 | 0 | 3 | 0% |
| F-2. ログ管理 | 9 | 0 | 0 | 9 | 0% |
| F-3. セキュリティ管理 | 6 | 0 | 0 | 6 | 0% |
| F-4. システム設定 | 8 | 0 | 0 | 8 | 0% |
| F-5. マスタメンテ（テーブル管理） | 6 | 0 | 0 | 6 | 0% |
| F-6. 開発・管理ツール | 4 | 0 | 0 | 4 | 0% |
| **F合計** | **36** | **0** | **0** | **36** | **0%** |

### G. 共通機能（データアクセス層・ユーティリティ）

| サブカテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| G-1. データアクセス基盤 | 5 | 4 | 0 | 1 | 80.0% |
| G-2. 共通ユーティリティ関数 | 6 | 6 | 0 | 0 | 100% |
| G-3. 未実装・要追加の共通機能 | 9 | 0 | 0 | 9 | 0% |
| **G合計** | **20** | **10** | **0** | **10** | **50.0%** |

### カテゴリ別充足率サマリー

| カテゴリ | 総項目数 | 実装済み | 一部実装 | 未実装 | 充足率 |
|---|---|---|---|---|---|
| **A. データベース層** | 59 | 58 | 0 | 1 | **98.3%** |
| **B. 画面（UI層）** | 71 | 12 | 2 | 57 | **18.3%** |
| **C. ビジネスロジック層** | 79 | 5 | 8 | 66 | **11.4%** |
| **D. 帳票・レポート層** | 15 | 2 | 2 | 11 | **20.0%** |
| **E. データ取込・連携** | 17 | 0 | 0 | 17 | **0%** |
| **F. システム管理** | 36 | 0 | 0 | 36 | **0%** |
| **G. 共通機能** | 20 | 10 | 0 | 10 | **50.0%** |
| **合計** | **297** | **87** | **12** | **198** | **31.3%** |

注: 一部実装を0.5としてカウントした場合の充足率 = (87 + 12*0.5) / 297 = **31.3%**

---

## 2. 画面別対応表

### 2.1 メイン・ナビゲーション

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 1 | Form_MAIN | Form_MAIN.vb | 済 | 済（メニュークリック30個） | 100% |
| 2 | Form_Switchboard | Form_Switchboard.vb | 済 | スタブ | 30% |
| 3 | Form_0F_SYSTEM | Form_0F_SYSTEM.vb | 済 | スタブ | 30% |
| 4 | Form_0F_SYSTEM管理 | Form_0F_SYSTEM管理.vb | 済 | スタブ | 30% |
| 5 | Form_f_0開発ツール | Form_f_0開発ツール.vb | 済 | スタブ | 30% |

### 2.2 契約書管理

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 6 | Form_ContractEntry | Form_ContractEntry.vb | 済 | 済（900+行、CRUD完備） | 90% |
| 7 | Form_f_KYKH | Form_f_KYKH.vb | 済 | スタブ | 30% |
| 8 | Form_f_KYKH_SUB | Form_f_KYKH_SUB.vb | 済 | スタブ | 30% |
| 9 | Form_f_flx_CONTRACT | Form_f_flx_CONTRACT.vb | 済 | 済（160行、複合JOIN） | 100% |
| 10 | Form_f_flx_D_KYKH | Form_f_flx_D_KYKH.vb | 済 | スタブ | 30% |
| 11 | Form_f_REF_D_KYKH | Form_f_REF_D_KYKH.vb | 済 | スタブ | 30% |
| 12 | Form_f_REF_D_KYKH_SUB | Form_f_REF_D_KYKH_SUB.vb | 済 | スタブ | 30% |

### 2.3 物件管理

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 13 | Form_BuknEntry | Form_BuknEntry.vb | 済 | 済（380行、配賦計算あり） | 80% |
| 14 | Form_f_KYKM | Form_f_KYKM.vb | 済 | スタブ | 30% |
| 15 | Form_f_KYKM_SUB | Form_f_KYKM_SUB.vb | 済 | スタブ | 30% |
| 16 | Form_f_KYKM_BKN | Form_f_KYKM_BKN.vb | 済 | スタブ | 30% |
| 17 | Form_f_KYKM_SUB_BKN | Form_f_KYKM_SUB_BKN.vb | 済 | スタブ | 30% |
| 18 | Form_f_KYKM_BUNKATSU | Form_f_KYKM_BUNKATSU.vb | 済 | スタブ | 30% |
| 19 | Form_f_KYKM_CHUUKI | Form_f_KYKM_CHUUKI.vb | 済 | スタブ | 30% |
| 20 | Form_f_KYKM_CHUUKI_SUB_GSON | Form_f_KYKM_CHUUKI_SUB_GSON.vb | 済 | スタブ | 30% |
| 21 | Form_f_KYKM_CHUUKI_拡張設定 | Form_f_KYKM_CHUUKI_拡張設定.vb | 済 | スタブ | 30% |
| 22 | Form_f_flx_BUKN | Form_f_flx_BUKN.vb | 済 | 済（183行、9テーブルJOIN） | 100% |
| 23 | Form_f_flx_D_KYKM | Form_f_flx_D_KYKM.vb | 済 | スタブ | 30% |
| 24 | Form_f_flx_D_KYKM_BKN | Form_f_flx_D_KYKM_BKN.vb | 済 | スタブ | 30% |
| 25 | Form_f_REF_D_KYKM | Form_f_REF_D_KYKM.vb | 済 | スタブ | 30% |
| 26 | Form_f_REF_D_KYKM_SUB | Form_f_REF_D_KYKM_SUB.vb | 済 | スタブ | 30% |
| 27 | Form_f_REF_D_KYKM_CHUUKI | Form_f_REF_D_KYKM_CHUUKI.vb | 済 | スタブ | 30% |
| 28 | Form_f_REF_D_KYKM_CHUUKI_SUB_GSON | Form_f_REF_D_KYKM_CHUUKI_SUB_GSON.vb | 済 | スタブ | 30% |
| 29 | Form_f_REF_D_KYKM_CHUUKI_拡張設定 | Form_f_REF_D_KYKM_CHUUKI_拡張設定.vb | 済 | スタブ | 30% |

### 2.4 配賦・変更・減損

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 30 | Form_f_flx_D_HAIF | Form_f_flx_D_HAIF.vb | 済 | スタブ | 30% |
| 31 | Form_f_flx_D_HAIF_SNKO | Form_f_flx_D_HAIF_SNKO.vb | 済 | スタブ | 30% |
| 32 | Form_f_flx_D_HENF | Form_f_flx_D_HENF.vb | 済 | スタブ | 30% |
| 33 | Form_f_flx_D_GSON | Form_f_flx_D_GSON.vb | 済 | スタブ | 30% |
| 34 | Form_f_HENF | Form_f_HENF.vb | 済 | スタブ | 30% |
| 35 | Form_f_HENL | Form_f_HENL.vb | 済 | スタブ | 30% |
| 36 | Form_f_HEN_SCH | Form_f_HEN_SCH.vb | 済 | スタブ | 30% |
| 37 | Form_f_REF_D_HENF | Form_f_REF_D_HENF.vb | 済 | スタブ | 30% |
| 38 | Form_f_REF_D_HENL | Form_f_REF_D_HENL.vb | 済 | スタブ | 30% |

### 2.5 物件移動・解約・再リース

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 39 | Form_f_IDO | Form_f_IDO.vb | 済 | スタブ | 30% |
| 40 | Form_f_IDO_SUB | Form_f_IDO_SUB.vb | 済 | スタブ | 30% |
| 41 | Form_f_flx_IDOLST | Form_f_flx_IDOLST.vb | 済 | スタブ | 30% |
| 42 | Form_f_IDOLST_JOKEN | Form_f_IDOLST_JOKEN.vb | 済 | スタブ | 30% |
| 43 | Form_f_KAIYAK | Form_f_KAIYAK.vb | 済 | スタブ | 30% |
| 44 | Form_f_KAIYAK_ALL | Form_f_KAIYAK_ALL.vb | 済 | スタブ | 30% |
| 45 | Form_f_KAIYAK_SUB | Form_f_KAIYAK_SUB.vb | 済 | スタブ | 30% |
| 46 | Form_f_SAILEASE | Form_f_SAILEASE.vb | 済 | スタブ | 30% |
| 47 | Form_f_SAILEASE_SUB | Form_f_SAILEASE_SUB.vb | 済 | スタブ | 30% |
| 48 | Form_f_KIRIKAE | Form_f_KIRIKAE.vb | 済 | スタブ | 30% |

### 2.6 月次処理

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 49 | Form_f_TOUGETSU_JOKEN | Form_f_TOUGETSU_JOKEN.vb | 済 | 一部実装（84行） | 60% |
| 50 | Form_f_flx_TOUGETSU | Form_f_flx_TOUGETSU.vb | 済 | 一部実装（110行、todo多） | 50% |
| 51 | Form_f_KEIJO_JOKEN | Form_f_KEIJO_JOKEN.vb | 済 | 一部実装（82行） | 60% |
| 52 | Form_f_flx_KEIJO | Form_f_flx_KEIJO.vb | 済 | 一部実装（149行、todo多） | 50% |
| 53 | Form_JournalEntry | Form_JournalEntry.vb | 済 | 済（133行、トランザクション対応） | 100% |

### 2.7 期間帳票

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 54-63 | Form_f_TANA_JOKEN 他10画面 | 全画面.vb存在 | 済 | 全てスタブ | 30% |
| 64 | Form_f_flx_経費明細表 | Form_f_flx_経費明細表.vb | 済 | スタブ | 30% |

### 2.8 決算処理

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 65 | Form_f_CHUKI_JOKEN | Form_f_CHUKI_JOKEN.vb | 済 | 済（207行、WHERE動的生成） | 100% |
| 66 | Form_f_CHUKI_SCH | Form_f_CHUKI_SCH.vb | 済 | 一部実装（323行、月別計算） | 70% |
| 67-78 | 注記様式、残高、債務、別表 他12画面 | 全画面.vb存在 | 済 | 全てスタブ | 30% |

### 2.9 マスタメンテナンス（抜粋: 実装済みのみ）

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 79 | Form_f_flx_M_CORP | Form_f_flx_M_CORP.vb | 済 | 済（107行） | 100% |
| 80 | Form_f_M_CORP_INP | Form_f_M_CORP_INP.vb | 済 | 済（54行） | 100% |
| 81 | Form_f_M_CORP_CHANGE | Form_f_M_CORP_CHANGE.vb | 済 | 済（104行） | 100% |
| 82 | Form_f_flx_M_KKNRI | Form_f_flx_M_KKNRI.vb | 済 | 済（109行） | 100% |
| 83 | Form_f_flx_M_LCPT | Form_f_flx_M_LCPT.vb | 済 | 済（121行） | 100% |
| 84 | Form_f_M_LCPT_INP | Form_f_M_LCPT_INP.vb | 済 | 済（132行） | 100% |
| - | 残り約44画面 | 全画面.vb存在 | 済 | 全てスタブ | 30% |

### 2.10 カスタマイズ仕訳出力（約50画面）

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 175-224 | Form_fc_支払仕訳_*, Form_fc_計上仕訳_* 他 | 全画面.vb存在 | 済 | 全てスタブ | 30% |

### 2.11 フレックス共通ダイアログ

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 229 | Form_f_FlexOutputDLG | Form_f_FlexOutputDLG.vb | 済 | 済（37行、出力実行） | 100% |
| 225-234 | 残り9画面 | 全画面.vb存在 | 済 | 全てスタブ | 30% |

### 2.12 セキュリティ・ログ（約20画面）

| # | Access版ファイル | VB.NET版ファイル | UI実装 | ロジック実装 | 充足率 |
|---|---|---|---|---|---|
| 155-174 | LOGIN, SEC_USER, SEC_KNGN, SLOG, ULOG 他 | 全画面.vb存在 | 済 | 全てスタブ | 30% |

---

## 3. ビジネスロジック対応表

Access版の推定モジュール（pc_*, p_*, g_*）とVB.NET版の対応状況。

| # | Access版モジュール | 機能 | VB.NET対応 | 状態 |
|---|---|---|---|---|
| 1 | pc_KYKH | 契約ヘッダ処理（CRUD） | Form_ContractEntry.vb | **実装済み**（新規/変更/削除/保存） |
| 2 | pc_KYKM | 物件明細処理（CRUD） | Form_BuknEntry.vb | **一部実装**（閲覧/配賦計算済、保存todo） |
| 3 | pc_HAIF | 配賦処理 | Form_BuknEntry.vb内 | **一部実装**（追加/削除/再計算のみ） |
| 4 | pc_IDO | 物件移動処理 | Form_f_IDO.vb | **未実装**（スタブ） |
| 5 | pc_KAIYAK | 解約処理 | Form_f_KAIYAK.vb | **未実装**（スタブ） |
| 6 | pc_SAILEASE | 再リース処理 | Form_f_SAILEASE.vb | **未実装**（スタブ） |
| 7 | pc_HENF | 変更ファイナンス処理 | Form_f_HENF.vb | **未実装**（スタブ） |
| 8 | pc_HENL | 変更リース処理 | Form_f_HENL.vb | **未実装**（スタブ） |
| 9 | pc_CHUKI | 注記計算処理 | Form_f_CHUKI_JOKEN.vb, Form_f_CHUKI_SCH.vb | **一部実装**（条件生成済、集計ロジック一部todo） |
| 10 | pc_KEIJO | 月次仕訳計上処理 | Form_f_flx_KEIJO.vb | **一部実装**（SQL構築済、計算列todo） |
| 11 | pc_TOUGETSU | 月次支払照合処理 | Form_f_flx_TOUGETSU.vb | **一部実装**（SQL構築済、計算列todo） |
| 12 | pc_IMPORT | データ取込処理 | Form_f_IMPORT_*.vb | **未実装**（全スタブ） |
| 13 | pc_SWK | 仕訳出力処理 | Form_JournalEntry.vb, Form_fc_*.vb | **一部実装**（仕訳入力のみ実装、出力は全スタブ） |
| 14 | p_FlexSearch | フレックス検索エンジン | Form_f_FlexSearchDLG.vb | **未実装**（スタブ） |
| 15 | p_FlexReport | フレックス帳票エンジン | Form_f_FlexReportDLG.vb | **未実装**（スタブ） |
| 16 | g_Common | 共通関数群 | Utils.vb, UtilDate.vb, UtilControl.vb, FormHelper.vb | **実装済み** |
| 17 | g_Security | セキュリティ共通 | （該当なし） | **未実装** |
| 18 | g_Log | ログ記録 | （該当なし） | **未実装** |

**ロジック実装サマリー**: 18モジュール中、実装済み2、一部実装6、未実装10

---

## 4. テーブル対応表

Access版で参照されるテーブル（55テーブル）とSQL DDL（001_create_tables.sql）の対応。

### 4.1 コードテーブル（c_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 1 | c_chuum | 済（UNIQUE INDEX付き） | 定義済み |
| 2 | c_chu_hnti | 済（UNIQUE INDEX付き） | 定義済み |
| 3 | c_kjkbn | 済（UNIQUE INDEX付き） | 定義済み |
| 4 | c_kjtaisyo | 済 | 定義済み |
| 5 | c_kkbn | 済（UNIQUE INDEX付き） | 定義済み |
| 6 | c_leakbn | 済（UNIQUE INDEX付き） | 定義済み |
| 7 | c_rcalc | 済（UNIQUE INDEX付き） | 定義済み |
| 8 | c_settei_idfld | 済 | 定義済み |
| 9 | c_skyak_ho | 済（UNIQUE INDEX付き） | 定義済み |
| 10 | c_szei_kjkbn | 済（UNIQUE INDEX付き） | 定義済み |

### 4.2 マスタテーブル（m_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 11 | m_bcat | 済（INDEX 8件付き） | 定義済み |
| 12 | m_bkind | 済（INDEX付き） | 定義済み |
| 13 | m_bknri | 済（INDEX付き） | 定義済み |
| 14 | m_corp | 済（INDEX付き） | 定義済み |
| 15 | m_genk | 済（INDEX付き） | 定義済み |
| 16 | m_gsha | 済（INDEX付き） | 定義済み |
| 17 | m_hkho | 済（INDEX付き） | 定義済み |
| 18 | m_hkmk | 済（INDEX付き） | 定義済み |
| 19 | m_kknri | 済（INDEX付き） | 定義済み |
| 20 | m_koza | 済（INDEX付き） | 定義済み |
| 21 | m_lcpt | 済（INDEX付き） | 定義済み |
| 22 | m_mcpt | 済（INDEX付き） | 定義済み |
| 23 | m_rsrvb1 | 済（INDEX付き） | 定義済み |
| 24 | m_rsrvh1 | 済（INDEX付き） | 定義済み |
| 25 | m_rsrvk1 | 済（INDEX付き） | 定義済み |
| 26 | m_shho | 済（INDEX付き） | 定義済み |
| 27 | m_skmk | 済（INDEX付き） | 定義済み |
| 28 | m_skti | 済 | 定義済み |
| 29 | m_swptn | 済 | 定義済み |

### 4.3 データテーブル（d_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 30 | d_kykh | 済（約90列） | 定義済み |
| 31 | d_kykm | 済（約120列） | 定義済み |
| 32 | d_haif | 済（約25列） | 定義済み |
| 33 | d_gson | 済（約15列） | 定義済み |
| 34 | d_henf | 済（約20列） | 定義済み |
| 35 | d_henl | 済（約20列） | 定義済み |

### 4.4 セキュリティテーブル（sec_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 36 | sec_user | 済 | 定義済み |
| 37 | sec_kngn | 済 | 定義済み |
| 38 | sec_kngn_bknri | 済 | 定義済み |
| 39 | sec_kngn_kknri | 済 | 定義済み |

### 4.5 システム・設定テーブル（t_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 40 | t_system | 済 | 定義済み |
| 41 | t_opt | 済 | 定義済み |
| 42 | t_seq | 済 | 定義済み |
| 43 | t_db_version | 済 | 定義済み |
| 44 | t_kari_ritu | 済 | 定義済み |
| 45 | t_zei_kaisei | 済 | 定義済み |
| 46 | t_kykbnj_seq | 済 | 定義済み |
| 47 | t_holiday | 済 | 定義済み |
| 48 | t_mstk | 済 | 定義済み |
| 49 | t_szei_kmk | 済 | 定義済み |
| 50 | t_swk_nm | 済 | 定義済み |

### 4.6 ログテーブル（l_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 51 | l_bklog | 済 | 定義済み |
| 52 | l_slog | 済 | 定義済み |
| 53 | l_ulog | 済 | 定義済み |

### 4.7 トランザクションテーブル（tc_*）

| # | Access版テーブル | DDL定義 | 状態 |
|---|---|---|---|
| 54 | tc_hrel | 済 | 定義済み |
| 55 | tc_rec_shri | 済 | 定義済み |

**テーブル対応サマリー**: Access版55テーブル中、DDL定義済み **55テーブル（100%）**

---

## 5. Gap サマリー

### 5.1 全体充足率

| 指標 | 値 |
|---|---|
| チェックリスト全項目数 | 297 |
| 実装済み | 87 (29.3%) |
| 一部実装 | 12 (4.0%) |
| 未実装 | 198 (66.7%) |
| **加重充足率（一部=0.5換算）** | **31.3%** |

### 5.2 最も進んでいる領域

1. **A. データベース層 (98.3%)** -- DDL 55テーブル全て定義済み。インデックス/コメントも含む
2. **G-2. 共通ユーティリティ (100%)** -- Utils, UtilDate, UtilControl, FormHelper, FileHelper, CalendarColumn
3. **G-1. データアクセス基盤 (80%)** -- CrudHelper(458行), DbConnectionManager(200行) は本格的・堅牢
4. **B-1. メインナビゲーション (100%)** -- Form_MAIN.vb で全メニュー遷移が実装済み

### 5.3 最も遅れている領域

1. **E. データ取込・連携 (0%)** -- Excel取込5種、マスタ取込、バックアップ/復元 全て未着手
2. **F. システム管理 (0%)** -- ログイン/認証、セキュリティ、ログ管理、システム設定 全て未着手
3. **C-3. 再リース処理 (0%)** -- スタブのみ
4. **C-4. 中途解約処理 (0%)** -- スタブのみ
5. **C-6. 返済スケジュール計算 (0%)** -- スタブのみ
6. **C-7. 資産管理・償却計算 (0%)** -- スタブのみ
7. **C-10. 仕訳出力カスタム14社 (0%)** -- 約50画面全てスタブ

### 5.4 クリティカルな未実装機能トップ10

優先度「必須」かつ充足率0%の機能を業務影響度順にランキング。

| 順位 | 機能 | カテゴリ | 影響度 | 理由 |
|---|---|---|---|---|
| 1 | **ログイン/認証** (F-1) | システム管理 | 最高 | 認証なしでは本番運用不可 |
| 2 | **セキュリティ管理** (F-3) | システム管理 | 最高 | 権限制御がないとデータ保護不可 |
| 3 | **定数定義・セッション管理** (G-3-01, G-3-04) | 共通機能 | 最高 | 全画面の前提条件 |
| 4 | **採番処理** (G-3-07) | 共通機能 | 高 | 契約番号・物件番号の自動採番が不可 |
| 5 | **中途解約処理** (C-4) | 契約管理 | 高 | 日常業務で頻発するライフサイクルイベント |
| 6 | **再リース処理** (C-3) | 契約管理 | 高 | 期末に集中する必須業務 |
| 7 | **物件移動処理** (C-2-04) | 物件管理 | 高 | 部署再編時に必須 |
| 8 | **返済スケジュール計算** (C-6) | 決算処理 | 高 | リース債務管理の根幹 |
| 9 | **変更リース/変更ファイナンス** (B-4, C-6-05/06) | 変更管理 | 高 | 契約条件変更時の必須機能 |
| 10 | **データ取込（Excel取込）** (E-1) | データ連携 | 高 | 契約移行・一括変更で必須 |

---

## 6. 定量サマリー

### 6.1 コード行数比較

| 指標 | Access版（推定） | VB.NET版（実測） | 比率 |
|---|---|---|---|
| 総画面数 | 249 | 249（.vbファイル存在） | 100% |
| ロジック実装済み画面数 | 249 | 約20 | 8.0% |
| スタブのみ画面数 | 0 | 約160 | - |
| データアクセス層 | （DAO組込み） | 約1,063行（3ファイル） | 新規 |
| ヘルパー/ユーティリティ | （組込み） | 約685行（6ファイル） | 新規 |
| SQL DDL | （Access内蔵スキーマ） | 約2,000行（1ファイル） | 新規 |

### 6.2 VB.NET版実装済みコード行数（主要ファイル）

| ファイル | 行数 | 内容 |
|---|---|---|
| CrudHelper.vb | 458 | PostgreSQL CRUD基盤 |
| UsageExamples.vb | 405 | 移行パターン例 |
| Form_ContractEntry.vb | 900+ | 契約書入力（最大画面） |
| Form_BuknEntry.vb | 380 | 物件入力 |
| Form_f_CHUKI_SCH.vb | 323 | 注記スケジュール |
| Form_MAIN.vb | 306 | メインメニュー |
| Form1.vb | 282 | DB接続テスト |
| DbConnectionManager.vb | 200 | DB接続管理 |
| FormHelper.vb | 195 | フォームヘルパー |
| Form_f_flx_BUKN.vb | 183 | 物件フレックス一覧 |
| FileHelper.vb | 176 | ファイル出力 |
| Form_f_flx_CONTRACT.vb | 160 | 契約書フレックス一覧 |
| CalendarColumn.vb | 153 | カレンダー列 |
| Form_f_CHUKI_JOKEN.vb | 207 | 注記条件入力 |
| Form_f_flx_KEIJO.vb | 149 | 月次計上フレックス |
| Form_JournalEntry.vb | 133 | 仕訳入力 |
| Form_f_flx_M_LCPT.vb | 121 | 支払先マスタ一覧 |
| Form_f_flx_TOUGETSU.vb | 110 | 月次支払照合 |
| Form_f_flx_M_KKNRI.vb | 109 | 契約管理単位一覧 |
| Form_f_flx_M_CORP.vb | 107 | 会社マスタ一覧 |
| Form_f_M_CORP_CHANGE.vb | 104 | 会社マスタ変更 |
| Form_f_TOUGETSU_JOKEN.vb | 84 | 月次計上条件 |
| Form_f_KEIJO_JOKEN.vb | 82 | 月次支払照合条件 |
| UtilControl.vb | 63 | コントロールユーティリティ |
| Form_f_M_CORP_INP.vb | 54 | 会社マスタ新規入力 |
| Form_LCPT.vb | 51 | 支払先基底 |
| UtilDate.vb | 51 | 日付ユーティリティ |
| Utils.vb | 47 | Null安全変換 |
| Form_f_FlexOutputDLG.vb | 37 | ファイル出力DLG |
| スタブ画面 x 約160 | 約10行x160 = 1,600 | New()+InitializeComponent()のみ |
| **実装コード合計（推定）** | **約5,700行** | Designer.vb除く |

### 6.3 関数数比較

| 指標 | Access版（推定） | VB.NET版（実測） |
|---|---|---|
| 画面イベントハンドラ（推定） | 約2,000〜3,000 | 約150（実装済み） |
| ビジネスロジック関数（推定） | 約500〜800 | 約40（実装済み） |
| 共通関数 | 約100〜200 | 約40（実装済み） |
| **合計（推定）** | **約2,600〜4,000** | **約230** |

備考: Access版の関数数はAccess VBAソースが`/tmp/zip_extract/AccessVBA/`に存在しなかったため、画面数・テーブル構造から推定。VB.NET版は`Sub|Function|Property`のgrep結果から実装済みコードのみをカウント。

---

## 付録: 充足率の計算方法

- **実装済み**: ロジックが完全に動作する状態（todoなし、主要機能を全て実装）→ 1.0
- **一部実装**: ロジックの骨格は存在するがtodoが残る、または主要機能の一部のみ実装 → 0.5
- **スタブのみ**: New()+InitializeComponent()のみ、Designer.vbのUI配置は済 → 0.0（UI配置は充足率に含めない）
- **充足率** = (実装済み数 + 一部実装数 * 0.5) / 総項目数 * 100

---

*本分析は 01_access_inventory.md, 02_vbnet_inventory.md, 03_checklist.md の3ドキュメント、および C:/project_lease_migration/ 以下の実コード検査に基づく*
