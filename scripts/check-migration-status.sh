#!/usr/bin/env bash
# check-migration-status.sh - マイグレーション進捗レポートスクリプト
# LeaseM4BS.DataAccess および WinForms の .vb ファイルを走査し、
# TODO/FIXME/NotImplemented をカウントしてカバレッジレポートを出力する
# 使い方: ./scripts/check-migration-status.sh

set -euo pipefail

REPO_ROOT="$(cd "$(dirname "$0")/.." && pwd)"

# スキャン対象ディレクトリ
DATA_ACCESS_DIR="${REPO_ROOT}/LeaseM4BS/LeaseM4BS.DataAccess"
WINFORMS_DIR="${REPO_ROOT}/LeaseM4BS.TestWinForms/LeaseM4BS.TestWinForms"

echo "============================================"
echo "  リースM4BS マイグレーション進捗レポート"
echo "  $(date '+%Y-%m-%d %H:%M:%S')"
echo "============================================"
echo ""

# --- 集計用カウンタ ---
TOTAL_FILES=0
FILES_WITH_ISSUES=0
TOTAL_TODO=0
TOTAL_FIXME=0
TOTAL_NOT_IMPL=0
TOTAL_THROW_NOT_IMPL=0

# --- レポート一時ファイル ---
REPORT_TMP=$(mktemp)
trap "rm -f '$REPORT_TMP'" EXIT

# --- ファイルスキャン関数 ---
scan_directory() {
    local DIR="$1"
    local SECTION_NAME="$2"

    if [ ! -d "$DIR" ]; then
        echo "  [スキップ] ${SECTION_NAME}: ディレクトリが見つかりません (${DIR})"
        echo ""
        return
    fi

    echo "--- ${SECTION_NAME} ---"
    echo ""

    local SECTION_FILES=0
    local SECTION_ISSUES=0
    local SECTION_TODO=0
    local SECTION_FIXME=0
    local SECTION_NOT_IMPL=0

    # .vbファイルを検索 (.Designer.vb は除外)
    while IFS= read -r -d '' VB_FILE; do
        SECTION_FILES=$((SECTION_FILES + 1))
        TOTAL_FILES=$((TOTAL_FILES + 1))

        local BASENAME=$(basename "$VB_FILE" .vb)
        local FILE_TODO=0
        local FILE_FIXME=0
        local FILE_NOT_IMPL=0
        local FILE_DETAILS=""

        # TODO カウント
        local COUNT
        COUNT=$(grep -ci 'TODO' "$VB_FILE" 2>/dev/null || echo 0)
        FILE_TODO=$COUNT
        SECTION_TODO=$((SECTION_TODO + COUNT))
        TOTAL_TODO=$((TOTAL_TODO + COUNT))

        # FIXME カウント
        COUNT=$(grep -ci 'FIXME' "$VB_FILE" 2>/dev/null || echo 0)
        FILE_FIXME=$COUNT
        SECTION_FIXME=$((SECTION_FIXME + COUNT))
        TOTAL_FIXME=$((TOTAL_FIXME + COUNT))

        # NotImplemented / NotImplementedException カウント
        COUNT=$(grep -ci 'NotImplemented' "$VB_FILE" 2>/dev/null || echo 0)
        FILE_NOT_IMPL=$COUNT
        SECTION_NOT_IMPL=$((SECTION_NOT_IMPL + COUNT))
        TOTAL_NOT_IMPL=$((TOTAL_NOT_IMPL + COUNT))

        # Throw New NotImplementedException カウント (未実装メソッド)
        COUNT=$(grep -c 'Throw New NotImplementedException' "$VB_FILE" 2>/dev/null || echo 0)
        TOTAL_THROW_NOT_IMPL=$((TOTAL_THROW_NOT_IMPL + COUNT))

        local FILE_TOTAL=$((FILE_TODO + FILE_FIXME + FILE_NOT_IMPL))

        if [ "$FILE_TOTAL" -gt 0 ]; then
            SECTION_ISSUES=$((SECTION_ISSUES + 1))
            FILES_WITH_ISSUES=$((FILES_WITH_ISSUES + 1))

            printf "  %-45s  TODO:%2d  FIXME:%2d  NotImpl:%2d\n" \
                "$BASENAME" "$FILE_TODO" "$FILE_FIXME" "$FILE_NOT_IMPL"

            # 詳細行を表示 (TODO/FIXME の内容)
            grep -n -i 'TODO\|FIXME' "$VB_FILE" 2>/dev/null | head -5 | while read -r LINE; do
                echo "    $LINE"
            done
        fi

    done < <(find "$DIR" -name '*.vb' ! -name '*.Designer.vb' -print0 2>/dev/null | sort -z)

    # セクションサマリー
    local COMPLETED=$((SECTION_FILES - SECTION_ISSUES))
    local COVERAGE=0
    if [ "$SECTION_FILES" -gt 0 ]; then
        COVERAGE=$(( (COMPLETED * 100) / SECTION_FILES ))
    fi

    echo ""
    echo "  [サマリー] ${SECTION_NAME}"
    echo "    総ファイル数:    ${SECTION_FILES}"
    echo "    課題ありファイル: ${SECTION_ISSUES}"
    echo "    課題なしファイル: ${COMPLETED}"
    echo "    カバレッジ:      ${COVERAGE}% (${COMPLETED}/${SECTION_FILES})"
    echo "    TODO:            ${SECTION_TODO}件"
    echo "    FIXME:           ${SECTION_FIXME}件"
    echo "    NotImplemented:  ${SECTION_NOT_IMPL}件"
    echo ""
}

# --- 各ディレクトリのスキャン ---
scan_directory "$DATA_ACCESS_DIR" "DataAccess層"
scan_directory "$WINFORMS_DIR" "WinForms (フォーム/UI層)"

# --- 全体サマリー ---
COMPLETED_FILES=$((TOTAL_FILES - FILES_WITH_ISSUES))
OVERALL_COVERAGE=0
if [ "$TOTAL_FILES" -gt 0 ]; then
    OVERALL_COVERAGE=$(( (COMPLETED_FILES * 100) / TOTAL_FILES ))
fi

TOTAL_ISSUES=$((TOTAL_TODO + TOTAL_FIXME + TOTAL_NOT_IMPL))

echo "============================================"
echo "  全体サマリー"
echo "============================================"
echo "  総 .vb ファイル数:   ${TOTAL_FILES}"
echo "  課題ありファイル:     ${FILES_WITH_ISSUES}"
echo "  課題なしファイル:     ${COMPLETED_FILES}"
echo "  全体カバレッジ:       ${OVERALL_COVERAGE}%"
echo ""
echo "  課題の内訳:"
echo "    TODO:              ${TOTAL_TODO}件"
echo "    FIXME:             ${TOTAL_FIXME}件"
echo "    NotImplemented:    ${TOTAL_NOT_IMPL}件"
echo "    (うちThrow New):   ${TOTAL_THROW_NOT_IMPL}件"
echo "    合計:              ${TOTAL_ISSUES}件"
echo "============================================"
echo ""

# --- カバレッジバー表示 ---
BAR_WIDTH=40
FILLED=$(( (OVERALL_COVERAGE * BAR_WIDTH) / 100 ))
EMPTY=$((BAR_WIDTH - FILLED))

printf "  進捗: ["
for ((i=0; i<FILLED; i++)); do printf "#"; done
for ((i=0; i<EMPTY; i++)); do printf "."; done
printf "] %d%%\n" "$OVERALL_COVERAGE"
echo ""
echo "[完了] マイグレーション進捗レポートを出力しました。"
