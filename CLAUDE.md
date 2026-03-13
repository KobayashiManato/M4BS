# LeaseM4BS Migration - チーム運用ルール

## プロジェクト概要
Access版 LeaseM4BS を VB.NET/WinForms へマイグレーションするプロジェクト。

- マイグレーション元: `C:\access_LeaseM4BS`（Access版）
- マイグレーション先: `C:\kobayashi_LeaseM4BS`（VB.NET版、本リポジトリ）
- リポジトリ: `M4BS-Organization/M4BS`

## タスク管理（GitHub Issues）

### タスクの確認
```bash
# 自分にアサインされたタスクを確認
gh issue list --repo M4BS-Organization/M4BS --assignee @me

# 未アサインのタスクを確認
gh issue list --repo M4BS-Organization/M4BS --no-assignee

# ラベルで絞り込み
gh issue list --repo M4BS-Organization/M4BS --label "form-migration"
gh issue list --repo M4BS-Organization/M4BS --label "priority:high"
```

### 作業開始
1. Issueを自分にアサイン
   ```bash
   gh issue edit <ISSUE番号> --repo M4BS-Organization/M4BS --add-assignee @me
   ```
2. ブランチを作成（命名規則に従う）
3. 作業開始

### 完了時
1. PRを作成し、Issueを紐づけ
   ```bash
   gh pr create --repo M4BS-Organization/M4BS --title "タイトル" --body "Closes #<ISSUE番号>"
   ```
2. レビュー依頼

## ブランチ命名規則
```
feature/<Issue番号>-<簡潔な説明>
例: feature/12-form-bcat-migration

bugfix/<Issue番号>-<簡潔な説明>
例: bugfix/15-fix-date-calculation
```

## ラベル一覧

### 分類
| ラベル | 用途 |
|--------|------|
| `form-migration` | フォーム移植 |
| `data-access` | DB/データアクセス層 |
| `business-logic` | 計算・業務ロジック |
| `ui` | 画面レイアウト・UX |
| `testing` | テスト |

### 優先度
| ラベル | 意味 |
|--------|------|
| `priority:high` | 優先度:高 |
| `priority:medium` | 優先度:中 |
| `priority:low` | 優先度:低 |

## 開発スケジュール（4.5日間: 3/13 PM 〜 3/19）

担当: 中村(`nkshn1726fgu`) / 小谷(`kodani-t`)

### Phase 1: 基盤修正（3/13 PM 〜 3/16）
- #2 FileHelper.ToFixedLengthFile 完成（中村）
- #3 FileHelper.ToCsvFile デリミタ修正（中村）
- #4 f_flx_KEIJO 計算ロジック（中村）
- #5 ログイン画面 JET 基本実装（小谷）
- #6 メインメニュー遷移確認（小谷）
- #7 f_flx_KHIYO 期間計算（小谷）

### Phase 2: 仕訳出力検証 + 計算TODO消化（3/17 〜 3/18）
- #8 f_flx_KLSRYO 取引分類（中村）
- #9 f_KEIJO_JOKEN 条件ロジック（中村）
- #10 f_CHUKI_JOKEN + f_IDOLST_JOKEN（中村）
- #11 標準仕訳出力_KJ 検証（小谷）
- #12 標準仕訳出力_SM/SH 検証（小谷）
- #13 仕訳出力設定画面 検証（小谷）

### Phase 3: 動作確認 + バグ修正（3/19）
- #14 E2Eフロー確認（中村）
- #15 バグ修正 + 型安全性（中村）
- #16 出力結果検証（小谷）
- #17 バグ修正 + 残TODO（小谷）

## 進捗報告
- Slackチャンネル `#m4bs-progress` に毎朝自動投稿
- 手動で進捗確認したい場合: Claudeに「進捗教えて」と聞く

## ディレクトリ構成
```
C:\kobayashi_LeaseM4BS/
├── .claude/                      # Claude Code 設定
│   ├── hooks.json                # Pre-commit/Post-push/PreToolUse フック
│   └── settings.json             # プロジェクト設定
├── .github/
│   ├── labeler.yml               # 自動ラベリング設定
│   ├── pull_request_template.md  # PR テンプレート
│   ├── ISSUE_TEMPLATE/           # Issue テンプレート (3種)
│   └── workflows/
│       ├── ci.yml                # CI ビルド・テスト (MSBuild)
│       ├── auto-label.yml        # PR 自動ラベリング
│       ├── pr-review.yml         # PR 自動レビュー (6項目チェック)
│       ├── assign-reviewer.yml   # レビュアー自動アサイン
│       ├── slack-notify.yml      # Slack 通知 (push/PR/issue)
│       ├── daily-progress.yml    # 日次進捗レポート (平日 JST 9:00)
│       ├── release.yml           # タグ push でリリース作成
│       └── stale.yml             # 非アクティブ Issue 自動管理
├── scripts/
│   ├── setup-branch-protection.sh # ブランチ保護 + ラベル初期設定
│   ├── start-task.sh              # Issue → ブランチ作成 → 作業開始
│   ├── finish-task.sh             # コミット → push → PR 作成
│   ├── sync-main.sh               # main リベース
│   ├── progress-report.sh         # 進捗レポート生成 (Phase別)
│   ├── assign-issues.sh           # Issue 一括アサイン
│   ├── check-migration-status.sh  # TODO/未実装スキャン
│   └── claude-dev.sh              # Claude Code 自動開発ワークフロー
├── LeaseM4BS/                     # メインソリューション
│   ├── LeaseM4BS.DataAccess/      # データアクセス層
│   └── LeaseM4BS.slnx             # ソリューションファイル
└── LeaseM4BS.TestWinForms/        # テスト用WinFormsプロジェクト
```

## CI/CD パイプライン

### GitHub Actions Workflows
| Workflow | トリガー | 内容 |
|----------|----------|------|
| `ci.yml` | push to main, PR | MSBuild ビルド + テスト |
| `auto-label.yml` | PR | 変更ファイルに応じたラベル自動付与 |
| `pr-review.yml` | PR | サイズ/Designer.vb/接続文字列/TODO/命名規則チェック |
| `assign-reviewer.yml` | PR opened | 中村↔小谷 相互レビュアーアサイン |
| `slack-notify.yml` | push/PR/issue | `#m4bs-progress` に通知 |
| `daily-progress.yml` | 平日 JST 9:00 | Phase別進捗レポート自動送信 |
| `release.yml` | tag `v*` push | Release ビルド + 成果物配布 |
| `stale.yml` | 毎週月曜 | 14日非アクティブ Issue を stale 化 |

### 必要な GitHub Secrets
- `SLACK_WEBHOOK_URL` - Slack Incoming Webhook URL

### 初期セットアップ
```bash
# ブランチ保護 + ラベル作成 (1回のみ)
./scripts/setup-branch-protection.sh
```

## 開発ワークフロー (Claude Code ドリブン)

### 手動フロー
```bash
# 1. タスク開始 (Issue → ブランチ作成)
./scripts/start-task.sh <ISSUE番号>

# 2. 開発作業 (Claude Code で実装)

# 3. タスク完了 (コミット → PR 作成)
./scripts/finish-task.sh <ISSUE番号>

# 4. 進捗確認
./scripts/progress-report.sh
./scripts/progress-report.sh --markdown  # Markdown 出力
```

### 自動フロー (Claude Code 完全自動)
```bash
# 未アサイン Issue を自動取得 → ブランチ作成 → コンテキスト準備
./scripts/claude-dev.sh
```

### Claude Code hooks
- **PreCommit**: CRITICAL TODO / ハードコード接続文字列 / ブランチ命名規則チェック
- **PostPush**: CI ステータス確認リマインダー
- **PreToolUse**: Designer.vb 編集時に確認プロンプト
