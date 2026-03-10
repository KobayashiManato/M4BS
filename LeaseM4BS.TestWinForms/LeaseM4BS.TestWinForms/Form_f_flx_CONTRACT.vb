Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 契約書フレックス ---
Partial Public Class Form_f_flx_CONTRACT
    Inherits Form

    Private Const FMT_CURRENCY As String = "#,##0"
    Private Const FMT_DATE As String = "yyyy/MM/dd"

    ' 画面ロード時（AccessのForm_Open/Load）
    Private Sub FrmContractList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初期表示：全件検索
        SearchData()
    End Sub

    ' ---------------------------------------------------------
    ' データ検索・一覧表示機能
    ' ---------------------------------------------------------
    Private Sub SearchData()
        Dim _crud As New crudHelper()
        Try
            ' SQL作成：Accessのクエリ「qsel_df_flx_D_KYKH」を再現
            ' ※マスタテーブルをJOINして、IDではなく「名称」を表示します
            ' SQL作成：Accessの表示項目をほぼ再現
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("SELECT ")
            sb.AppendLine("  kykh.kykh_id, ")
            sb.AppendLine("  kknri.kknri1_nm AS 管理単位, ")
            sb.AppendLine("  kkbn.kkbn_nm AS 契約区分, ")
            ' 計上区分IDから判定（簡易的なCASE文）
            sb.AppendLine("  CASE WHEN kykh.kjkbn_id = 1 THEN '対象外' ELSE '対象' END AS 計上対象, ")
            sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")
            sb.AppendLine("  kykh.kykbnl AS 相手契約番号, ") ' Accessの並び順に合わせ変更
            sb.AppendLine("  kykh.kykbnj AS 自社契約番号, ")
            sb.AppendLine("  kykh.rng_bango AS 稟議番号, ")  ' ★追加
            sb.AppendLine("  kykh.saikaisu AS 再リース回数, ") ' ★追加
            sb.AppendLine("  kykh.kyak_nm AS 契約名, ")
            sb.AppendLine("  kykh.start_dt AS 開始日, ")
            sb.AppendLine("  kykh.end_dt AS 終了日, ")
            sb.AppendLine("  kykh.lkikan AS 契約期間, ")      ' ★追加
            sb.AppendLine("  kykh.shri_cnt AS 支払回数, ")    ' ★追加
            sb.AppendLine("  kykh.shri_kn || 'ヶ月' AS 支払間隔, ") ' ★追加(単位結合)
            sb.AppendLine("  kykh.shri_dt1 AS 第1回支払日, ") ' ★追加
            sb.AppendLine("  kykh.shri_dt2 AS 第2回支払日, ") ' ★追加
            sb.AppendLine("  kykh.shri_en_dt AS 最終支払日, ") ' ★追加
            sb.AppendLine("  kykh.k_knyukn AS 現金購入価額, ") ' ★追加
            sb.AppendLine("  kykh.k_glsryo AS 月額リース料 ")

            sb.AppendLine("FROM d_kykh kykh ")
            ' --- 結合 (JOIN) ---
            sb.AppendLine("LEFT JOIN m_kknri kknri ON kykh.kknri_id = kknri.kknri_id ")
            sb.AppendLine("LEFT JOIN c_kkbn kkbn ON kykh.kkbn_id = kkbn.kkbn_id ")
            sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")

            ' --- 検索条件 (WHERE) ---
            ' テキストボックスに入力があれば、契約番号で検索
            If txt_SEARCH.Text.Trim() <> "" Then
                sb.AppendLine("WHERE kykh.kykbnj LIKE @search OR kykh.kykbnl LIKE @search ")
            End If

            sb.AppendLine("ORDER BY kykh.kykh_id DESC") ' 新しい順

            ' パラメータ設定
            Dim prms As New List(Of NpgsqlParameter)
            If txt_SEARCH.Text.Trim() <> "" Then
                prms.Add(New NpgsqlParameter("@search", "%" & txt_SEARCH.Text.Trim() & "%"))
            End If

            ' データ取得＆表示
            Dim dt As DataTable = _crud.GetDataTable(sb.ToString(), prms)
            ' ★★★ ここを追加・変更 ★★★
            ' 1. デザイナーで作った固定列をいったん全部消す（これをしないとSQLの増えた項目が出ません）
            dgv_LIST.Columns.Clear()

            ' 2. 自動生成をONにする
            dgv_LIST.AutoGenerateColumns = True

            ' 3. データをセット（ここで勝手に列が作られます）
            dgv_LIST.DataSource = dt
            ' ★★★★★★★★★★★★★★★
            ' --- グリッドの見た目調整 ---
            ' ID列は隠す
            If dgv_LIST.Columns.Contains("kykh_id") Then
                dgv_LIST.Columns("kykh_id").Visible = False
            End If
            ' 金額を通貨形式に
            dgv_LIST.FormatColumn("現金購入価額", FMT_CURRENCY)
            dgv_LIST.FormatColumn("月額リース料", FMT_CURRENCY)
            dgv_LIST.FormatColumn("総額リース料", FMT_CURRENCY)
            ' 日付を短い形式に
            dgv_LIST.FormatColumn("契約日", FMT_DATE)
            dgv_LIST.FormatColumn("開始日", FMT_DATE)
            dgv_LIST.FormatColumn("終了日", FMT_DATE)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' ボタンイベント
    ' ---------------------------------------------------------

    ' [検索] ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [新規登録] ボタン
    Private Sub cmd_NEW_Click(sender As Object, e As EventArgs) Handles cmd_NEW.Click
        ' 詳細画面を「新規モード」で開く
        Dim frm As New Form_ContractEntry()
        frm.ShowDialog()

        SearchData()
    End Sub

    ' [照会/変更] ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        ' 詳細画面を開く
        Dim frm As New Form_ContractEntry()
        frm.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)

        frm.ShowDialog()

        ' 戻ってきたら一覧更新
        SearchData()
    End Sub

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frm As New Form_ContractEntry()
        frm.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)

        frm.ShowDialog()

        ' 戻ってきたら一覧更新
        SearchData()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class