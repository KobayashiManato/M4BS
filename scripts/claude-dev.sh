#!/usr/bin/env bash
# claude-dev.sh - Claude Code自動開発用ラッパースクリプト
# 未アサインのIssueを取得し、start-task.shを実行し、関連ファイルのコンテキストを提示する
# 使い方: ./scripts/claude-dev.sh [issue番号]
#   引数なし: 次の未アサインIssueを自動選択
#   引数あり: 指定されたIssue番号を使用

set -euo pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"
SCRIPTS_DIR="${REPO_ROOT}/scripts"
cd "$REPO_ROOT"

# --- gh CLIの存在確認 ---
if ! command -v gh &>/dev/null; then
    echo "[エラー] GitHub CLI (gh) がインストールされていません。"
    exit 1
fi

# --- Issue番号の決定 ---
if [ $# -ge 1 ]; then
    ISSUE_NUM="$1"
    echo "=== 指定されたIssue #${ISSUE_NUM} を使用します ==="
else
    echo "=== 次の未アサインIssueを検索中... ==="

    # 未アサインかつopenなIssueを優先度順(ラベル/作成日)で取得
    ISSUE_NUM=$(gh issue list \
        --state open \
        --assignee "" \
        --json number,title,labels \
        --limit 20 \
        -q '.[0].number // empty' 2>/dev/null)

    if [ -z "$ISSUE_NUM" ]; then
        # アサインされていないIssueがない場合、全openIssueから探す
        ISSUE_NUM=$(gh issue list \
            --state open \
            --json number,title \
            --limit 1 \
            -q '.[0].number // empty' 2>/dev/null)
    fi

    if [ -z "$ISSUE_NUM" ]; then
        echo "[情報] 未処理のIssueがありません。全てのIssueが完了しています。"
        exit 0
    fi

    echo "  -> Issue #${ISSUE_NUM} を選択しました。"
fi

# --- Issue情報の取得 ---
ISSUE_JSON=$(gh issue view "$ISSUE_NUM" --json title,body,labels 2>/dev/null) || {
    echo "[エラー] Issue #${ISSUE_NUM} が見つかりません。"
    exit 1
}

ISSUE_TITLE=$(echo "$ISSUE_JSON" | gh issue view "$ISSUE_NUM" --json title -q '.title')
ISSUE_BODY=$(gh issue view "$ISSUE_NUM" --json body -q '.body' 2>/dev/null)
ISSUE_LABELS=$(gh issue view "$ISSUE_NUM" --json labels -q '.labels[].name' 2>/dev/null)

echo ""
echo "============================================"
echo "  自動開発タスク: Issue #${ISSUE_NUM}"
echo "  タイトル: ${ISSUE_TITLE}"
echo "  ラベル: ${ISSUE_LABELS:-なし}"
echo "============================================"
echo ""

# --- start-task.sh の実行 ---
echo "=== タスクを開始します... ==="
bash "${SCRIPTS_DIR}/start-task.sh" "$ISSUE_NUM"
echo ""

# --- ラベルに基づく関連ファイルの特定 ---
echo "=== 関連ファイルの検索中... ==="

RELEVANT_FILES=()

# ラベルからフォーム名やモジュール名を抽出
for LABEL in $ISSUE_LABELS; do
    case "$LABEL" in
        form:*|Form:*)
            FORM_NAME="${LABEL#*:}"
            echo "  -> フォーム '${FORM_NAME}' に関連するファイルを検索中..."
            while IFS= read -r -d '' F; do
                RELEVANT_FILES+=("$F")
            done < <(find "$REPO_ROOT" -name "*${FORM_NAME}*" -name "*.vb" -print0 2>/dev/null)
            ;;
        module:*|Module:*)
            MOD_NAME="${LABEL#*:}"
            echo "  -> モジュール '${MOD_NAME}' に関連するファイルを検索中..."
            while IFS= read -r -d '' F; do
                RELEVANT_FILES+=("$F")
            done < <(find "$REPO_ROOT" -name "*${MOD_NAME}*" -name "*.vb" -print0 2>/dev/null)
            ;;
        dataaccess|DataAccess)
            echo "  -> DataAccess層のファイルを検索中..."
            while IFS= read -r -d '' F; do
                RELEVANT_FILES+=("$F")
            done < <(find "$REPO_ROOT/LeaseM4BS/LeaseM4BS.DataAccess" -name "*.vb" -print0 2>/dev/null)
            ;;
    esac
done

# --- IssueのBodyからファイル名やVBAモジュール名を抽出 ---
if [ -n "$ISSUE_BODY" ]; then
    echo "  -> Issue本文からキーワードを抽出中..."

    # .vb ファイル名の参照を検出
    VB_REFS=$(echo "$ISSUE_BODY" | grep -oE '[A-Za-z0-9_]+\.vb' | sort -u || true)
    for REF in $VB_REFS; do
        BASENAME="${REF%.vb}"
        while IFS= read -r -d '' F; do
            RELEVANT_FILES+=("$F")
        done < <(find "$REPO_ROOT" -name "${REF}" -print0 2>/dev/null)
    done

    # Form_ や f_ プレフィックスのフォーム名を検出
    FORM_REFS=$(echo "$ISSUE_BODY" | grep -oE '(Form_|f_)[A-Za-z0-9_]+' | sort -u || true)
    for REF in $FORM_REFS; do
        while IFS= read -r -d '' F; do
            RELEVANT_FILES+=("$F")
        done < <(find "$REPO_ROOT" -name "*${REF}*" -name "*.vb" ! -name "*.Designer.vb" -print0 2>/dev/null)
    done

    # Access VBAソースファイルの参照を検出 (docs配下)
    echo "  -> Access VBAソースファイルの参照を検索中..."
    VBA_REFS=$(echo "$ISSUE_BODY" | grep -oE '[A-Za-z0-9_]+\.(bas|cls|frm)' | sort -u || true)
    for REF in $VBA_REFS; do
        while IFS= read -r -d '' F; do
            RELEVANT_FILES+=("$F")
            echo "    [VBA参照] ${F}"
        done < <(find "$REPO_ROOT/docs" -name "${REF}" -print0 2>/dev/null)
    done
fi

# --- 重複を除去してファイルリストを表示 ---
echo ""
if [ ${#RELEVANT_FILES[@]} -gt 0 ]; then
    echo "=== 関連ファイル一覧 ==="
    printf '%s\n' "${RELEVANT_FILES[@]}" | sort -u | while read -r F; do
        # ファイルパスをリポジトリルートからの相対パスに変換
        REL_PATH="${F#$REPO_ROOT/}"
        echo "  - ${REL_PATH}"
    done
else
    echo "  [情報] ラベルやIssue本文から関連ファイルを特定できませんでした。"
    echo "  以下のディレクトリを確認してください:"
    echo "    - LeaseM4BS/LeaseM4BS.DataAccess/"
    echo "    - LeaseM4BS.TestWinForms/LeaseM4BS.TestWinForms/"
fi

# --- 開発コンテキストの出力 ---
echo ""
echo "============================================"
echo "  開発コンテキスト"
echo "============================================"
echo "  Issue:      #${ISSUE_NUM} - ${ISSUE_TITLE}"
echo "  ブランチ:   $(git branch --show-current)"
echo "  ラベル:     ${ISSUE_LABELS:-なし}"
echo ""
echo "  プロジェクト構成:"
echo "    LeaseM4BS/LeaseM4BS.DataAccess/  - データアクセス層 (VB.NET)"
echo "    LeaseM4BS.TestWinForms/          - WinFormsフォーム (VB.NET)"
echo "    docs/                            - Access VBA元ソース・設計資料"
echo "    sql/                             - SQLスクリプト"
echo ""
echo "  完了後は以下を実行してください:"
echo "    ./scripts/finish-task.sh"
echo "============================================"
echo ""
echo "[完了] 開発環境の準備ができました。Claude Codeによる開発を開始してください。"
