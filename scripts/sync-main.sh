#!/usr/bin/env bash
# sync-main.sh - mainブランチの最新をリベースするスクリプト
# 使い方: ./scripts/sync-main.sh

set -euo pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
cd "$REPO_ROOT"

CURRENT_BRANCH=$(git branch --show-current)

echo "=== mainブランチとの同期 ==="
echo "  現在のブランチ: ${CURRENT_BRANCH}"
echo ""

# --- mainブランチの場合は単純にpull ---
if [ "$CURRENT_BRANCH" = "main" ]; then
    echo "=== mainブランチを最新に更新中... ==="
    git pull origin main
    echo ""
    echo "[完了] mainブランチを最新に更新しました。"
    exit 0
fi

# --- 未コミットの変更を確認 ---
if ! git diff --quiet || ! git diff --cached --quiet; then
    echo "[警告] 未コミットの変更があります。stashしてからリベースします。"
    git stash push -m "sync-main: auto-stash $(date +%Y%m%d_%H%M%S)"
    STASHED=true
else
    STASHED=false
fi

# --- mainブランチをフェッチ ---
echo "=== origin/main をフェッチ中... ==="
git fetch origin main
echo "  -> フェッチ完了"

# --- リベースの実行 ---
echo "=== ${CURRENT_BRANCH} を origin/main にリベース中... ==="
if git rebase origin/main; then
    echo "  -> リベース完了"
else
    echo ""
    echo "============================================"
    echo "  [コンフリクト発生]"
    echo "============================================"
    echo ""
    echo "  コンフリクトが発生しました。以下の手順で解決してください:"
    echo ""
    echo "  1. コンフリクトしているファイルを確認:"
    echo "     git status"
    echo ""
    echo "  2. コンフリクトを手動で解決"
    echo ""
    echo "  3. 解決後にリベースを続行:"
    echo "     git add <解決したファイル>"
    echo "     git rebase --continue"
    echo ""
    echo "  4. リベースを中止する場合:"
    echo "     git rebase --abort"
    echo ""

    # コンフリクトしているファイルを一覧表示
    echo "  コンフリクトファイル:"
    git diff --name-only --diff-filter=U 2>/dev/null | sed 's/^/    - /' || true
    echo ""

    if [ "$STASHED" = true ]; then
        echo "  [注意] stashした変更があります。リベース完了後に以下を実行してください:"
        echo "     git stash pop"
    fi
    exit 1
fi

# --- stashした変更を復元 ---
if [ "$STASHED" = true ]; then
    echo "=== stashした変更を復元中... ==="
    if git stash pop; then
        echo "  -> 復元完了"
    else
        echo "  [警告] stashの復元でコンフリクトが発生しました。手動で解決してください。"
        echo "     git stash show -p | git apply"
    fi
fi

# --- 結果表示 ---
AHEAD=$(git rev-list --count origin/main..HEAD 2>/dev/null || echo "?")
echo ""
echo "============================================"
echo "  同期完了"
echo "============================================"
echo "  ブランチ:         ${CURRENT_BRANCH}"
echo "  origin/mainとの差: ${AHEAD} コミット先行"
echo "============================================"
echo ""
echo "[完了] mainブランチとの同期が完了しました。"
