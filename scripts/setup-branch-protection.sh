#!/bin/bash
# =============================================================================
# ブランチ保護ルール＋ラベル設定スクリプト
# リポジトリ: M4BS-Organization/M4BS
# =============================================================================

REPO="M4BS-Organization/M4BS"

echo "=========================================="
echo " M4BS リポジトリ初期設定"
echo "=========================================="

# ---------------------------------------------------------------------------
# 1. ブランチ保護ルール (main)
# ---------------------------------------------------------------------------
echo ""
echo "[1/2] main ブランチの保護ルールを設定中..."

gh api repos/${REPO}/branches/main/protection \
  --method PUT \
  --input - <<'EOF'
{
  "required_status_checks": {
    "strict": true,
    "contexts": ["build"]
  },
  "enforce_admins": false,
  "required_pull_request_reviews": {
    "required_approving_review_count": 1,
    "dismiss_stale_reviews": true
  },
  "restrictions": null,
  "allow_force_pushes": false,
  "allow_deletions": false
}
EOF

if [ $? -eq 0 ]; then
  echo "  ✓ ブランチ保護ルールを設定しました"
else
  echo "  ✗ ブランチ保護ルールの設定に失敗しました"
  echo "    → リポジトリの管理者権限が必要です"
fi

# ---------------------------------------------------------------------------
# 2. ラベル作成
# ---------------------------------------------------------------------------
echo ""
echo "[2/2] ラベルを作成中..."

# ラベル定義: "名前|色|説明"
LABELS=(
  "form-migration|0075ca|フォーム移植タスク"
  "data-access|e4e669|DB・データアクセス層"
  "business-logic|d73a4a|計算・業務ロジック"
  "ui|7057ff|画面レイアウト・UX"
  "testing|0e8a16|テスト関連"
  "bug|fc2929|バグ報告"
  "documentation|0075ca|ドキュメント"
  "priority:high|b60205|優先度:高"
  "priority:medium|fbca04|優先度:中"
  "priority:low|c5def5|優先度:低"
  "claude-code|6f42c1|Claude Code 自動生成PR"
  "wontfix|ffffff|対応不要"
  "duplicate|cfd3d7|重複"
  "good first issue|7057ff|初心者向け"
)

for LABEL_DEF in "${LABELS[@]}"; do
  IFS='|' read -r NAME COLOR DESC <<< "$LABEL_DEF"

  # 既存ラベルの確認（存在すればスキップ）
  EXISTING=$(gh label list --repo "$REPO" --search "$NAME" --json name -q ".[].name" 2>/dev/null)

  if [ "$EXISTING" = "$NAME" ]; then
    echo "  - ${NAME} (既に存在・スキップ)"
  else
    gh label create "$NAME" \
      --repo "$REPO" \
      --color "$COLOR" \
      --description "$DESC" \
      2>/dev/null

    if [ $? -eq 0 ]; then
      echo "  ✓ ${NAME}"
    else
      echo "  ✗ ${NAME} (作成失敗)"
    fi
  fi
done

echo ""
echo "=========================================="
echo " 設定完了"
echo "=========================================="
echo ""
echo "次のステップ:"
echo "  1. GitHub Settings > Secrets に SLACK_WEBHOOK_URL を追加"
echo "  2. scripts/start-task.sh で開発を開始"
echo "  3. gh issue list --repo $REPO で Issue を確認"
