Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 支払先 ---
Partial Public Class Form_f_flx_M_LCPT
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_M_LCPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sb.AppendLine("  lcpt1_cd AS 支払先コード, ")
        sb.AppendLine("  lcpt1_nm AS 支払先名, ")
        sb.AppendLine("  lcpt2_cd AS 支払先コード2, ")
        sb.AppendLine("  lcpt2_nm AS 支払先名2, ")
        sb.AppendLine("  shime_day_1 AS 契約締結（日締め）1, ")
        sb.AppendLine("  sshri_kn1_1 AS 初回支払（ヶ月後）1, ")
        sb.AppendLine("  shri_day1_1 AS 初回支払（日）1, ")
        sb.AppendLine("  sshri_kn2_1 AS 二回目支払（ヶ月後）1, ")
        sb.AppendLine("  shri_day2_1 AS 二回目支払（日）1, ")
        sb.AppendLine("  shime_day_2 AS 契約締結（日締め）2, ")
        sb.AppendLine("  sshri_kn1_2 AS 初回支払（ヶ月後）2, ")
        sb.AppendLine("  shri_day1_2 AS 初回支払（日）2, ")
        sb.AppendLine("  sshri_kn2_2 AS 二回目支払（ヶ月後）2, ")
        sb.AppendLine("  shri_day2_2 AS 二回目支払（日）2, ")
        sb.AppendLine("  shime_day_3 AS 契約締結（日締め）3, ")
        sb.AppendLine("  sshri_kn1_3 AS 初回支払（ヶ月後）3, ")
        sb.AppendLine("  shri_day1_3 AS 初回支払（日）3, ")
        sb.AppendLine("  sshri_kn2_3 AS 二回目支払（ヶ月後）3, ")
        sb.AppendLine("  shri_day2_3 AS 二回目支払（日）3, ")
        sb.AppendLine("  sai_denomi AS 再リースパラメータ, ")
        sb.AppendLine("  biko AS 備考, ")
        sb.AppendLine("  create_dt AS 作成日時, ")
        sb.AppendLine("  update_dt AS 更新日時, ")
        sb.AppendLine("  lcpt_id AS ID")

        sb.AppendLine("FROM m_lcpt ")
        sb.AppendLine("WHERE lcpt_id <> 0 ")

        ' --- 検索条件 (WHERE) ---
        ' テキストボックスに入力があれば、支払先コードで検索
        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("AND lcpt1_cd LIKE @search OR lcpt2_cd LIKE @search ")
            prms.Add(New NpgsqlParameter("@search", $"%{searchText}%"))
        End If

        sb.AppendLine("ORDER BY lcpt_id;")

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
        Dim frm As New Form_f_M_LCPT_INP()
        frm.ShowDialog()

        SearchData()
    End Sub

    ' [変更] ボタン
    Private Sub cmd_CHANGE_Click(sender As Object, e As EventArgs) Handles cmd_CHANGE.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frm As New Form_f_M_LCPT_CHANGE()
        frm.LcptId = Convert.ToDouble(selectedRow.Cells("id").Value)
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