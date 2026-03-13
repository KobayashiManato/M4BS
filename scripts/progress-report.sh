#!/bin/bash
# =============================================================================
# progress-report.sh
# M4BS移行プロジェクトの開発進捗レポート生成スクリプト
#
# 使い方:
#   ./progress-report.sh              # 通常のテキスト出力
#   ./progress-report.sh --markdown   # Markdown形式で出力
#
# 前提条件:
#   - GitHub CLI (gh) がインストール・認証済みであること
#   - M4BS-Organization/M4BS リポジトリへのアクセス権があること
# =============================================================================

set -euo pipefail

# ─── 設定 ───
REPO="M4BS-Organization/M4BS"
MARKDOWN=false

# フェーズ定義（イシュー番号範囲）
PHASE1_NAME="基盤修正"
PHASE1_ISSUES=(2 3 4 5 6 7)

PHASE2_NAME="仕訳出力検証"
PHASE2_ISSUES=(8 9 10 11 12 13)

PHASE3_NAME="動作確認"
PHASE3_ISSUES=(14 15 16 17)

# ラベル一覧
LABELS=("form-migration" "business-logic" "data-access" "ui" "testing" "bug")

# 担当者マッピング
declare -A ASSIGNEE_NAMES
ASSIGNEE_NAMES["nkshn1726fgu"]="中村"
ASSIGNEE_NAMES["kodani-t"]="小谷"
ASSIGNEES=("nkshn1726fgu" "kodani-t")

# ─── 引数解析 ───
for arg in "$@"; do
  case "$arg" in
    --markdown)
      MARKDOWN=true
      ;;
    --help|-h)
      echo "使い方: $0 [--markdown]"
      echo "  --markdown  Markdown形式で出力"
      exit 0
      ;;
  esac
done

# ─── ユーティリティ関数 ───

# イシュー数を取得する関数
# 引数: gh issue list に渡す追加オプション
count_issues() {
  gh issue list --repo "$REPO" --limit 1000 "$@" --json number --jq 'length' 2>/dev/null || echo "0"
}

# 区切り線を出力する関数
print_separator() {
  if $MARKDOWN; then
    echo ""
  else
    echo "────────────────────────────────────────────────────────────"
  fi
}

# セクションヘッダーを出力する関数
print_header() {
  local title="$1"
  if $MARKDOWN; then
    echo ""
    echo "## $title"
    echo ""
  else
    echo ""
    print_separator
    echo "  $title"
    print_separator
  fi
}

# テーブルヘッダーを出力する関数（Markdown用）
print_table_header() {
  if $MARKDOWN; then
    echo "| $1 |"
    # ヘッダーの列数に応じた区切り行を生成
    local cols
    cols=$(echo "$1" | awk -F'|' '{print NF}')
    local sep="|"
    for ((i = 1; i <= cols; i++)); do
      sep+=" --- |"
    done
    echo "$sep"
  fi
}

# ─── レポート生成日時 ───
REPORT_DATE=$(date '+%Y年%m月%d日 %H:%M')

if $MARKDOWN; then
  echo "# M4BS移行プロジェクト 進捗レポート"
  echo ""
  echo "**生成日時:** $REPORT_DATE"
  echo ""
  echo "**リポジトリ:** \`$REPO\`"
else
  echo "╔══════════════════════════════════════════════════════════╗"
  echo "║    M4BS移行プロジェクト 進捗レポート                     ║"
  echo "╚══════════════════════════════════════════════════════════╝"
  echo ""
  echo "  生成日時: $REPORT_DATE"
  echo "  リポジトリ: $REPO"
fi

# ─── 1. 全体サマリー ───
print_header "1. 全体サマリー"

TOTAL_OPEN=$(count_issues --state open)
TOTAL_CLOSED=$(count_issues --state closed)
TOTAL=$((TOTAL_OPEN + TOTAL_CLOSED))

if [ "$TOTAL" -gt 0 ]; then
  OVERALL_PCT=$((TOTAL_CLOSED * 100 / TOTAL))
else
  OVERALL_PCT=0
fi

if $MARKDOWN; then
  echo "| 項目 | 件数 |"
  echo "| --- | --- |"
  echo "| 総イシュー数 | $TOTAL |"
  echo "| オープン | $TOTAL_OPEN |"
  echo "| クローズ済み | $TOTAL_CLOSED |"
  echo "| **全体進捗率** | **${OVERALL_PCT}%** |"
else
  printf "  %-20s %s\n" "総イシュー数:" "$TOTAL"
  printf "  %-20s %s\n" "オープン:" "$TOTAL_OPEN"
  printf "  %-20s %s\n" "クローズ済み:" "$TOTAL_CLOSED"
  printf "  %-20s %s\n" "全体進捗率:" "${OVERALL_PCT}%"
fi

# ─── 2. ラベル別内訳 ───
print_header "2. ラベル別内訳"

if $MARKDOWN; then
  echo "| ラベル | オープン | クローズ | 合計 |"
  echo "| --- | --- | --- | --- |"
fi

for label in "${LABELS[@]}"; do
  label_open=$(count_issues --state open --label "$label")
  label_closed=$(count_issues --state closed --label "$label")
  label_total=$((label_open + label_closed))

  if $MARKDOWN; then
    echo "| \`$label\` | $label_open | $label_closed | $label_total |"
  else
    printf "  %-20s  オープン: %-4s  クローズ: %-4s  合計: %s\n" \
      "$label" "$label_open" "$label_closed" "$label_total"
  fi
done

# ─── 3. 担当者別内訳 ───
print_header "3. 担当者別内訳"

if $MARKDOWN; then
  echo "| 担当者 | GitHub ID | オープン | クローズ | 合計 |"
  echo "| --- | --- | --- | --- | --- |"
fi

for assignee in "${ASSIGNEES[@]}"; do
  display_name="${ASSIGNEE_NAMES[$assignee]}"
  a_open=$(count_issues --state open --assignee "$assignee")
  a_closed=$(count_issues --state closed --assignee "$assignee")
  a_total=$((a_open + a_closed))

  if $MARKDOWN; then
    echo "| $display_name | \`$assignee\` | $a_open | $a_closed | $a_total |"
  else
    printf "  %-8s (%-15s)  オープン: %-4s  クローズ: %-4s  合計: %s\n" \
      "$display_name" "$assignee" "$a_open" "$a_closed" "$a_total"
  fi
done

# ─── 4. 最近クローズされたイシュー（過去7日間） ───
print_header "4. 最近クローズされたイシュー（過去7日間）"

# 7日前の日付を取得
SINCE_DATE=$(date -d '7 days ago' '+%Y-%m-%dT00:00:00Z' 2>/dev/null || \
             date -v-7d '+%Y-%m-%dT00:00:00Z' 2>/dev/null || \
             echo "")

if [ -n "$SINCE_DATE" ]; then
  # gh の search を利用して最近クローズされたイシューを取得
  RECENT_CLOSED=$(gh issue list --repo "$REPO" --state closed --limit 50 \
    --json number,title,closedAt,assignees \
    --jq ".[] | select(.closedAt >= \"$SINCE_DATE\") | \"#\\(.number) \\(.title) [\\(.assignees | map(.login) | join(\", \"))]\"" \
    2>/dev/null || echo "")
else
  # 日付計算が使えない場合はフォールバック
  RECENT_CLOSED=$(gh issue list --repo "$REPO" --state closed --limit 10 \
    --json number,title,closedAt,assignees \
    --jq '.[] | "#\(.number) \(.title) [\(.assignees | map(.login) | join(", "))]"' \
    2>/dev/null || echo "")
fi

if [ -z "$RECENT_CLOSED" ]; then
  echo "  （過去7日間にクローズされたイシューはありません）"
else
  if $MARKDOWN; then
    echo "$RECENT_CLOSED" | while IFS= read -r line; do
      echo "- $line"
    done
  else
    echo "$RECENT_CLOSED" | while IFS= read -r line; do
      echo "  $line"
    done
  fi
fi

# ─── 5. オープン中のプルリクエスト ───
print_header "5. オープン中のプルリクエスト"

OPEN_PRS=$(gh pr list --repo "$REPO" --state open --limit 50 \
  --json number,title,author,reviewDecision,isDraft,headRefName \
  2>/dev/null || echo "[]")

PR_COUNT=$(echo "$OPEN_PRS" | gh api --input - --method POST /graphql 2>/dev/null | jq 'length' 2>/dev/null || \
           echo "$OPEN_PRS" | python3 -c "import sys,json; print(len(json.load(sys.stdin)))" 2>/dev/null || \
           echo "0")

# jq を使ってPR数を取得（より確実な方法）
PR_COUNT=$(echo "$OPEN_PRS" | jq 'length' 2>/dev/null || echo "0")

if [ "$PR_COUNT" = "0" ] || [ "$PR_COUNT" = "" ]; then
  echo "  （オープン中のプルリクエストはありません）"
else
  if $MARKDOWN; then
    echo "| PR | タイトル | 作成者 | ブランチ | ステータス |"
    echo "| --- | --- | --- | --- | --- |"
  fi

  echo "$OPEN_PRS" | jq -r '.[] | @json' 2>/dev/null | while IFS= read -r pr_json; do
    pr_num=$(echo "$pr_json" | jq -r '.number')
    pr_title=$(echo "$pr_json" | jq -r '.title')
    pr_author=$(echo "$pr_json" | jq -r '.author.login')
    pr_review=$(echo "$pr_json" | jq -r '.reviewDecision // "PENDING"')
    pr_draft=$(echo "$pr_json" | jq -r '.isDraft')
    pr_branch=$(echo "$pr_json" | jq -r '.headRefName')

    # レビューステータスを日本語に変換
    case "$pr_review" in
      "APPROVED")           status="承認済み" ;;
      "CHANGES_REQUESTED")  status="変更要求" ;;
      "REVIEW_REQUIRED")    status="レビュー待ち" ;;
      *)                    status="未レビュー" ;;
    esac

    if [ "$pr_draft" = "true" ]; then
      status="下書き"
    fi

    if $MARKDOWN; then
      echo "| #$pr_num | $pr_title | \`$pr_author\` | \`$pr_branch\` | $status |"
    else
      printf "  #%-5s %-30s  作成者: %-15s  ステータス: %s\n" \
        "$pr_num" "$pr_title" "$pr_author" "$status"
      printf "         ブランチ: %s\n" "$pr_branch"
    fi
  done
fi

# ─── 6. フェーズ別進捗 ───
print_header "6. フェーズ別進捗"

# フェーズの進捗を計算する関数
# 引数: フェーズ名、イシュー番号の配列
calculate_phase_progress() {
  local phase_name="$1"
  shift
  local issues=("$@")
  local total=${#issues[@]}
  local closed=0

  for issue_num in "${issues[@]}"; do
    # イシューの状態を取得
    state=$(gh issue view "$issue_num" --repo "$REPO" --json state --jq '.state' 2>/dev/null || echo "UNKNOWN")
    if [ "$state" = "CLOSED" ]; then
      ((closed++)) || true
    fi
  done

  local pct=0
  if [ "$total" -gt 0 ]; then
    pct=$((closed * 100 / total))
  fi

  # プログレスバーを生成
  local bar_len=20
  local filled=$((pct * bar_len / 100))
  local empty=$((bar_len - filled))
  local bar=""
  for ((i = 0; i < filled; i++)); do bar+="█"; done
  for ((i = 0; i < empty; i++)); do bar+="░"; done

  if $MARKDOWN; then
    local issue_range="${issues[0]}-${issues[${#issues[@]}-1]}"
    echo "| $phase_name | #$issue_range | $closed/$total | ${pct}% | \`$bar\` |"
  else
    printf "  %-16s  #%-7s  %d/%d完了  %3d%%  %s\n" \
      "$phase_name" "${issues[0]}-${issues[${#issues[@]}-1]}" \
      "$closed" "$total" "$pct" "$bar"
  fi
}

if $MARKDOWN; then
  echo "| フェーズ | イシュー | 完了 | 進捗率 | プログレス |"
  echo "| --- | --- | --- | --- | --- |"
fi

calculate_phase_progress "$PHASE1_NAME" "${PHASE1_ISSUES[@]}"
calculate_phase_progress "$PHASE2_NAME" "${PHASE2_ISSUES[@]}"
calculate_phase_progress "$PHASE3_NAME" "${PHASE3_ISSUES[@]}"

# ─── フッター ───
echo ""
if $MARKDOWN; then
  echo "---"
  echo ""
  echo "*このレポートは \`progress-report.sh\` により自動生成されました。*"
else
  print_separator
  echo "  このレポートは progress-report.sh により自動生成されました。"
  print_separator
fi
