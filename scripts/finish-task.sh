#!/usr/bin/env bash
# finish-task.sh - 現在のタスクを完了してPRを作成するスクリプト
# 使い方: ./scripts/finish-task.sh [コミットメッセージ]

set -euo pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
cd "$REPO_ROOT"

# --- gh CLIの存在確認 ---
if ! command -v gh &>/dev/null; then
    echo "[エラー] GitHub CLI (gh) がインストールされていません。"
    exit 1
fi

# --- 現在のブランチからIssue番号を抽出 ---
CURRENT_BRANCH=$(git branch --show-current)

if [[ ! "$CURRENT_BRANCH" =~ ^feature/([0-9]+)- ]]; then
    echo "[エラー] 現在のブランチ '${CURRENT_BRANCH}' はfeature/ブランチではありません。"
    echo "  期待されるフォーマット: feature/<issue番号>-<slug>"
    exit 1
fi

ISSUE_NUM="${BASH_REMATCH[1]}"
echo "=== Issue #${ISSUE_NUM} のタスクを完了します ==="

# --- Issue情報の取得 ---
ISSUE_TITLE=$(gh issue view "$ISSUE_NUM" --json title -q '.title' 2>/dev/null) || ISSUE_TITLE="Issue #${ISSUE_NUM}"

# --- 変更の確認 ---
if git diff --quiet && git diff --cached --quiet && [ -z "$(git ls-files --others --exclude-standard)" ]; then
    echo "[警告] コミットする変更がありません。"
    echo "  PRの作成のみ行いますか? (y/N)"
    read -r ANSWER
    if [[ "$ANSWER" != "y" && "$ANSWER" != "Y" ]]; then
        echo "[中止] 処理を中止しました。"
        exit 0
    fi
else
    # --- 全変更をステージング ---
    echo "=== 変更をステージング中... ==="
    git add -A
    git status --short
    echo ""

    # --- コミットメッセージの生成 ---
    if [ $# -ge 1 ]; then
        COMMIT_MSG="$1"
    else
        # Conventional Commit形式で自動生成
        COMMIT_MSG="feat(#${ISSUE_NUM}): ${ISSUE_TITLE}"
    fi

    # コミットメッセージにIssue参照を追加
    FULL_COMMIT_MSG="${COMMIT_MSG}

Refs #${ISSUE_NUM}"

    echo "=== コミット中... ==="
    echo "  メッセージ: ${COMMIT_MSG}"
    git commit -m "$FULL_COMMIT_MSG"
    echo "  -> コミット完了"
fi

# --- リモートへプッシュ ---
echo "=== リモートへプッシュ中... ==="
git push -u origin "$CURRENT_BRANCH" 2>&1 || {
    echo "[エラー] プッシュに失敗しました。"
    echo "  'scripts/sync-main.sh' を実行してからリトライしてください。"
    exit 1
}
echo "  -> プッシュ完了"

# --- PRが既に存在するか確認 ---
EXISTING_PR=$(gh pr list --head "$CURRENT_BRANCH" --json number -q '.[0].number' 2>/dev/null)

if [ -n "$EXISTING_PR" ]; then
    echo ""
    echo "=== 既存のPR #${EXISTING_PR} が見つかりました ==="
    PR_URL=$(gh pr view "$EXISTING_PR" --json url -q '.url')
    echo "  URL: ${PR_URL}"
else
    # --- PR作成 ---
    echo "=== PRを作成中... ==="

    PR_TITLE="feat(#${ISSUE_NUM}): ${ISSUE_TITLE}"

    # PRのタイトルを70文字に制限
    if [ ${#PR_TITLE} -gt 70 ]; then
        PR_TITLE="${PR_TITLE:0:67}..."
    fi

    PR_BODY="## 概要
- Issue #${ISSUE_NUM}: ${ISSUE_TITLE}

## 変更内容
$(git log origin/main..HEAD --oneline 2>/dev/null | sed 's/^/- /' || echo "- 初回コミット")

## テスト
- [ ] ビルド確認
- [ ] 動作確認

Closes #${ISSUE_NUM}"

    PR_URL=$(gh pr create \
        --title "$PR_TITLE" \
        --body "$PR_BODY" \
        --base main 2>&1) || {
        echo "[エラー] PR作成に失敗しました。"
        echo "$PR_URL"
        exit 1
    }
    echo "  -> PR作成完了"
    echo "  URL: ${PR_URL}"
fi

echo ""
echo "============================================"
echo "  タスク完了: Issue #${ISSUE_NUM}"
echo "============================================"
echo "  タイトル:   ${ISSUE_TITLE}"
echo "  ブランチ:   ${CURRENT_BRANCH}"
echo "  PR:         ${PR_URL:-N/A}"
echo "============================================"
echo ""
echo "[完了] レビューをお願いしてください。"
