#!/usr/bin/env bash
# start-task.sh - GitHub Issueからタスクを開始するスクリプト
# 使い方: ./scripts/start-task.sh <issue番号>

set -euo pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
cd "$REPO_ROOT"

# --- 引数チェック ---
if [ $# -lt 1 ]; then
    echo "[エラー] Issue番号を指定してください。"
    echo "使い方: $0 <issue番号>"
    exit 1
fi

ISSUE_NUM="$1"

# --- gh CLIの存在確認 ---
if ! command -v gh &>/dev/null; then
    echo "[エラー] GitHub CLI (gh) がインストールされていません。"
    exit 1
fi

# --- Issue情報の取得 ---
echo "=== Issue #${ISSUE_NUM} の情報を取得中... ==="
ISSUE_JSON=$(gh issue view "$ISSUE_NUM" --json title,body,labels,assignees 2>/dev/null) || {
    echo "[エラー] Issue #${ISSUE_NUM} が見つかりません。"
    exit 1
}

ISSUE_TITLE=$(echo "$ISSUE_JSON" | gh issue view "$ISSUE_NUM" --json title -q '.title')
ISSUE_BODY=$(echo "$ISSUE_JSON" | gh issue view "$ISSUE_NUM" --json body -q '.body')
ISSUE_LABELS=$(gh issue view "$ISSUE_NUM" --json labels -q '.labels[].name' 2>/dev/null | tr '\n' ', ' | sed 's/,$//')

# --- 現在のユーザーにアサイン ---
echo "=== Issue #${ISSUE_NUM} を自分にアサイン中... ==="
CURRENT_USER=$(gh api user -q '.login' 2>/dev/null) || CURRENT_USER=""
if [ -n "$CURRENT_USER" ]; then
    gh issue edit "$ISSUE_NUM" --add-assignee "$CURRENT_USER" 2>/dev/null || true
    echo "  -> ${CURRENT_USER} にアサインしました。"
else
    echo "  [警告] ユーザー情報を取得できませんでした。アサインをスキップします。"
fi

# --- ブランチ名の生成 (issue番号-タイトルslug) ---
# タイトルから英数字とハイフンのslugを生成
SLUG=$(echo "$ISSUE_TITLE" \
    | tr '[:upper:]' '[:lower:]' \
    | sed 's/[^a-z0-9 _-]//g' \
    | sed 's/[ _]/-/g' \
    | sed 's/--*/-/g' \
    | sed 's/^-//;s/-$//' \
    | cut -c1-50)

# slugが空の場合(日本語タイトルのみ等)はissue番号のみ使用
if [ -z "$SLUG" ]; then
    BRANCH_NAME="feature/${ISSUE_NUM}-task"
else
    BRANCH_NAME="feature/${ISSUE_NUM}-${SLUG}"
fi

# --- ブランチの作成とチェックアウト ---
echo "=== ブランチを作成中: ${BRANCH_NAME} ==="

# mainブランチが最新であることを確認
git fetch origin main 2>/dev/null || true

# ブランチが既に存在するか確認
if git rev-parse --verify "$BRANCH_NAME" &>/dev/null; then
    echo "  -> ブランチ '${BRANCH_NAME}' は既に存在します。チェックアウトします。"
    git checkout "$BRANCH_NAME"
else
    git checkout -b "$BRANCH_NAME" origin/main 2>/dev/null || git checkout -b "$BRANCH_NAME"
    echo "  -> ブランチ '${BRANCH_NAME}' を作成しました。"
fi

# --- タスクサマリーの表示 ---
echo ""
echo "============================================"
echo "  タスク開始: Issue #${ISSUE_NUM}"
echo "============================================"
echo "  タイトル: ${ISSUE_TITLE}"
echo "  ラベル:   ${ISSUE_LABELS:-なし}"
echo "  ブランチ: ${BRANCH_NAME}"
echo "--------------------------------------------"
if [ -n "$ISSUE_BODY" ]; then
    echo "  概要:"
    echo "$ISSUE_BODY" | sed 's/^/    /'
else
    echo "  概要: (なし)"
fi
echo "============================================"
echo ""
echo "[完了] タスクの準備ができました。開発を開始してください。"
