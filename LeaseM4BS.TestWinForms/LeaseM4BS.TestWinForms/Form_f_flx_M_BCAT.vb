Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 部署 ---
Partial Public Class Form_f_flx_M_BCAT
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_M_BCAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchData()
    End Sub

    Private Sub SearchData()
        Dim _crud As New CrudHelper()

        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter))
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  bcat.bcat1_cd AS 部署コード, ")
        sb.AppendLine("  bcat.bcat1_nm AS 部署名, ")
        sb.AppendLine("  bcat.bcat2_cd AS 部署コード2, ")
        sb.AppendLine("  bcat.bcat2_nm AS 部署名2, ")
        sb.AppendLine("  bcat.bcat3_cd AS 部署コード3, ")
        sb.AppendLine("  bcat.bcat3_nm AS 部署名3, ")
        sb.AppendLine("  bcat.bcat4_cd AS 部署コード4, ")
        sb.AppendLine("  bcat.bcat4_nm AS 部署名4, ")
        sb.AppendLine("  bcat.bcat5_cd AS 部署コード5, ")
        sb.AppendLine("  bcat.bcat5_nm AS 部署名5, ")
        sb.AppendLine("  genk.genk_nm AS 原価区分, ")
        sb.AppendLine("  bcat.sum1_cd AS 集計区分1コード, ")
        sb.AppendLine("  bcat.sum1_nm AS 集計区分1, ")
        sb.AppendLine("  bcat.sum2_cd AS 集計区分2コード, ")
        sb.AppendLine("  bcat.sum2_nm AS 集計区分2, ")
        sb.AppendLine("  bcat.sum3_cd AS 集計区分3コード, ")
        sb.AppendLine("  bcat.sum3_nm AS 集計区分3, ")
        sb.AppendLine("  bknri.bknri1_nm AS 物件管理単位, ")
        sb.AppendLine("  bcat.biko AS 備考, ")
        sb.AppendLine("  bcat.create_dt AS 作成日時, ")
        sb.AppendLine("  bcat.update_dt AS 更新日時, ")
        sb.AppendLine("  bcat.bcat_id AS ID")

        sb.AppendLine("FROM m_bcat bcat ")
        sb.AppendLine("LEFT JOIN m_genk genk ON bcat.genk_id = genk.genk_id ")
        sb.AppendLine("LEFT JOIN m_bknri bknri ON bcat.bknri_id = bknri.bknri_id ")
        sb.AppendLine("WHERE bcat.bcat_id <> 0 ")

        ' --- 検索条件 (WHERE) ---
        ' テキストボックスに入力があれば、支払先コードで検索
        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("AND bcat.bcat1_cd LIKE @search ")
            prms.Add(New NpgsqlParameter("@search", $"%{searchText}%"))
        End If

        sb.AppendLine("ORDER BY bcat.bcat_id;")

        Return sb.ToString()
    End Function

    ' [検索] ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [新規] ボタン
    Private Sub cmd_NEW_Click(sender As Object, e As EventArgs) Handles cmd_NEW.Click
        Dim frm As New Form_f_M_BCAT_INP()
        frm.ShowDialog()

        SearchData()
    End Sub

    ' [変更] ボタン
    Private Sub cmd_CHANGE_Click(sender As Object, e As EventArgs) Handles cmd_CHANGE.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frm As New Form_f_M_BCAT_CHANGE()
        frm.BcatId = Convert.ToDouble(selectedRow.Cells("id").Value)
        frm.ShowDialog()

        SearchData()
    End Sub

    ' [ファイル出力] ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG()
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class