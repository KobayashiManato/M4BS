#!/bin/bash
# =============================================================================
# assign-issues.sh
# イシューの一括アサインスクリプト
#
# 使い方:
#   ./assign-issues.sh <開発者名> <イシュー番号...>
#   ./assign-issues.sh nakamura 2 3 4 5
#   ./assign-issues.sh kodani 8 9 10
#   ./assign-issues.sh nkshn1726fgu 2 3 4
#   ./assign-issues.sh --list
#
# 開発者名には以下のいずれかを指定可能:
#   - GitHub ID（例: nkshn1726fgu, kodani-t）
#   - 短縮名（例: nakamura, kodani）
#   - 日本語名（例: 中村, 小谷）
#
# 前提条件:
#   - GitHub CLI (gh) がインストール・認証済みであること
#   - M4BS-Organization/M4BS リポジトリへのアクセス権があること
# =============================================================================

set -euo pipefail

# ─── 設定 ───
REPO="M4BS-Organization/M4BS"

# ─── 開発者名からGitHub IDへのマッピング ───
resolve_assignee() {
  local input="$1"
  case "$input" in
    # 中村さん
    nkshn1726fgu|nakamura|中村)
      echo "nkshn1726fgu"
      ;;
    # 小谷さん
    kodani-t|kodani|小谷)
      echo "kodani-t"
      ;;
    *)
      # マッピングに該当しない場合はそのままGitHub IDとして扱う
      echo "$input"
      ;;
  esac
}

# ─── 担当者一覧の表示 ───
show_assignee_list() {
  echo "登録済み担当者一覧:"
  echo ""
  echo "  GitHub ID          短縮名      日本語名"
  echo "  ─────────────────  ──────────  ────────"
  echo "  nkshn1726fgu       nakamura    中村"
  echo "  kodani-t           kodani      小谷"
  echo ""
  echo "※ 上記以外のGitHub IDも直接指定可能です。"
}

# ─── ヘルプ表示 ───
show_help() {
  echo "使い方: $0 <開発者名> <イシュー番号...>"
  echo ""
  echo "引数:"
  echo "  開発者名       GitHub ID、短縮名、または日本語名"
  echo "  イシュー番号   アサインするイシュー番号（複数指定可能）"
  echo ""
  echo "オプション:"
  echo "  --list         登録済み担当者一覧を表示"
  echo "  --unassign     指定イシューからアサインを解除"
  echo "  --help, -h     このヘルプを表示"
  echo ""
  echo "例:"
  echo "  $0 nakamura 2 3 4 5       # 中村さんにイシュー#2-#5をアサイン"
  echo "  $0 kodani 8 9 10          # 小谷さんにイシュー#8-#10をアサイン"
  echo "  $0 中村 2 3 4             # 日本語名でも指定可能"
  echo "  $0 --unassign 2 3 4       # イシュー#2-#4のアサインを解除"
}

# ─── 引数チェック ───
if [ $# -eq 0 ]; then
  show_help
  exit 1
fi

# ─── オプション処理 ───
case "$1" in
  --help|-h)
    show_help
    exit 0
    ;;
  --list)
    show_assignee_list
    exit 0
    ;;
  --unassign)
    # アサイン解除モード
    shift
    if [ $# -eq 0 ]; then
      echo "エラー: イシュー番号を指定してください。"
      exit 1
    fi

    echo "アサイン解除を実行します..."
    echo ""

    SUCCESS=0
    FAIL=0

    for issue_num in "$@"; do
      # 数値チェック
      if ! [[ "$issue_num" =~ ^[0-9]+$ ]]; then
        echo "  ⚠ スキップ: '$issue_num' は有効なイシュー番号ではありません"
        ((FAIL++)) || true
        continue
      fi

      # 現在のアサインを取得
      current=$(gh issue view "$issue_num" --repo "$REPO" \
        --json assignees --jq '.assignees | map(.login) | join(", ")' 2>/dev/null || echo "")

      if [ -z "$current" ]; then
        echo "  - #$issue_num: アサインなし（変更不要）"
        ((SUCCESS++)) || true
        continue
      fi

      # アサイン解除を実行
      # gh では --remove-assignee で解除可能
      if gh issue edit "$issue_num" --repo "$REPO" --remove-assignee "$current" 2>/dev/null; then
        echo "  ✓ #$issue_num: アサイン解除完了 (元: $current)"
        ((SUCCESS++)) || true
      else
        echo "  ✗ #$issue_num: アサイン解除に失敗しました"
        ((FAIL++)) || true
      fi
    done

    echo ""
    echo "完了: 成功=$SUCCESS, 失敗=$FAIL"
    exit 0
    ;;
esac

# ─── 通常のアサインモード ───
DEVELOPER="$1"
shift

if [ $# -eq 0 ]; then
  echo "エラー: イシュー番号を1つ以上指定してください。"
  echo ""
  show_help
  exit 1
fi

# 開発者名をGitHub IDに変換
GITHUB_ID=$(resolve_assignee "$DEVELOPER")

echo "アサイン実行:"
echo "  担当者: $GITHUB_ID"
echo "  対象イシュー: $*"
echo ""

SUCCESS=0
FAIL=0

for issue_num in "$@"; do
  # 数値チェック
  if ! [[ "$issue_num" =~ ^[0-9]+$ ]]; then
    echo "  ⚠ スキップ: '$issue_num' は有効なイシュー番号ではありません"
    ((FAIL++)) || true
    continue
  fi

  # イシューの存在確認とアサイン実行
  if gh issue edit "$issue_num" --repo "$REPO" --add-assignee "$GITHUB_ID" 2>/dev/null; then
    # アサイン後のイシュータイトルを取得して表示
    title=$(gh issue view "$issue_num" --repo "$REPO" --json title --jq '.title' 2>/dev/null || echo "(タイトル取得不可)")
    echo "  ✓ #$issue_num: $title → $GITHUB_ID"
    ((SUCCESS++)) || true
  else
    echo "  ✗ #$issue_num: アサインに失敗しました（イシューが存在しないか権限不足）"
    ((FAIL++)) || true
  fi
done

# ─── 結果サマリー ───
echo ""
echo "────────────────────────────────"
echo "結果: 成功=$SUCCESS, 失敗=$FAIL (合計=$((SUCCESS + FAIL)))"

if [ "$FAIL" -gt 0 ]; then
  echo ""
  echo "※ 失敗したイシューについては以下を確認してください:"
  echo "  - イシュー番号が正しいか"
  echo "  - リポジトリへのアクセス権があるか"
  echo "  - GitHub CLIの認証が有効か (gh auth status)"
  exit 1
fi

echo "────────────────────────────────"
