Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_flx_M_SHHO
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_M_LCPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchData()
    End Sub

    Private Sub SearchData()
        Dim _crud As New crudHelper()

        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            ' 3. データをセット（ここで勝手に列が作られます）
            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter))
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  shho_cd AS 支払方法コード, ")
        sb.AppendLine("  shho_nm AS 支払方法名, ")
        sb.AppendLine("  biko AS 備考, ")
        sb.AppendLine("  create_dt AS 作成日時, ")
        sb.AppendLine("  update_dt AS 更新日時, ")
        sb.AppendLine("  shho_id AS ID")

        sb.AppendLine("FROM m_shho ")
        sb.AppendLine("WHERE shho_id <> 0 ")

        ' --- 検索条件 (WHERE) ---
        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("AND shho_cd LIKE @search ")
            prms.Add(New NpgsqlParameter("@search", $"%{searchText}%"))
        End If

        sb.AppendLine("ORDER BY shho_id;")

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
        Dim frm As New Form_f_M_SHHO_INP
        frm.ShowDialog()

        SearchData()
    End Sub

    ' [変更] ボタン
    Private Sub cmd_CHANGE_Click(sender As Object, e As EventArgs) Handles cmd_CHANGE.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        Dim frm As New Form_f_M_SHHO_CHANGE
        frm.ShhoId = Convert.ToDouble(selectedRow.Cells("id").Value)
        frm.ShowDialog()

        SearchData()
    End Sub

    ' [ファイル出力] ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class