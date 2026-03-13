Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 追加借入利子率テーブル ---
Partial Public Class Form_f_T_KARI_RITU
    Inherits Form

    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_T_KARI_RITU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchData()
    End Sub

    Private Sub SearchData()
        Try
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("SELECT * FROM t_kari_ritu ")

            ' --- 検索条件 (WHERE) ---
            ' テキストボックスに入力があれば、支払先コードで検索
            If txt_SEARCH.Text.Trim() = "" Then
                sb.AppendLine("WHERE kari_ritu_id <> 0 ")
            Else
                sb.AppendLine("WHERE kari_ritu_id <> 0 ")   ' todo 検索項目考える
            End If

            sb.AppendLine("ORDER BY kari_ritu_id")

            ' パラメータ設定
            Dim prms As New List(Of NpgsqlParameter)
            If txt_SEARCH.Text.Trim() <> "" Then
                prms.Add(New NpgsqlParameter("@search", "%" & txt_SEARCH.Text.Trim() & "%"))
            End If

            dgv_LIST.AutoGenerateColumns = False

            dgv_LIST.Columns("col_KARI_RITU_ID").DataPropertyName = "kari_ritu_id"
            dgv_LIST.Columns("col_START_DT").DataPropertyName = "start_dt"
            dgv_LIST.Columns("col_KARI_RITU").DataPropertyName = "kari_ritu"
            dgv_LIST.Columns("col_CREATE_ID").DataPropertyName = "create_id"
            dgv_LIST.Columns("col_CREATE_DT").DataPropertyName = "create_dt"
            dgv_LIST.Columns("col_UPDATE_ID").DataPropertyName = "update_id"
            dgv_LIST.Columns("col_UPDATE_DT").DataPropertyName = "update_dt"
            dgv_LIST.Columns("col_UPDATE_CNT").DataPropertyName = "update_cnt"
            dgv_LIST.Columns("col_HISTORY_F").DataPropertyName = "history_f"

            dgv_LIST.DataSource = _crud.GetDataTable(sb.ToString(), prms)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    ' [検索] ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' DBを更新
        SaveAllData()
    End Sub

    ' [行削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        ' データが選択されていないとき
        If dgv_LIST.CurrentRow Is Nothing OrElse dgv_LIST.RowCount = 0 Then
            Return
        End If

        ' 画面(DataGridView)から削除
        dgv_LIST.Rows.Remove(dgv_LIST.CurrentRow)
    End Sub

    ' [ファイル出力] ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG()
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    Private Sub SaveAllData()
        dgv_LIST.EndEdit()

        _crud.BeginTransaction()

        Dim dt As DataTable = DirectCast(dgv_LIST.DataSource, DataTable)

        Dim changeDt As DataTable = dt.GetChanges()
        If changeDt Is Nothing Then Return

        Try
            ' 削除行などでインデックスが変わるため、後ろからループを回す
            For i = dt.Rows.Count - 1 To 0 Step -1
                Dim row As DataRow = dt.Rows(i)

                ' 新規
                If row.RowState = DataRowState.Added Then
                    Dim newKariRitu = GetKariRituDictionary(row)

                    newKariRitu("kari_ritu_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(kari_ritu_id), 0) FROM t_kari_ritu") + 1
                    newKariRitu("create_id") = 0
                    newKariRitu("update_id") = 0
                    newKariRitu("update_cnt") = 0
                    newKariRitu("history_f") = False

                    _crud.Insert("t_kari_ritu", newKariRitu)

                    ' 削除
                ElseIf row.RowState = DataRowState.Deleted Then
                    Dim id = row("kari_ritu_id", DataRowVersion.Original)

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter) From {
                        {New NpgsqlParameter("@id", id)}
                    }

                    _crud.Delete("t_kari_ritu", "kari_ritu_id = @id", prms)

                    ' 更新
                ElseIf row.RowState = DataRowState.Modified Then
                    Dim kariRitu = GetKariRituDictionary(row)

                    kariRitu("update_cnt") += 1

                    Dim id = row("kari_ritu_id", DataRowVersion.Original)

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter) From {
                        {New NpgsqlParameter("@id", id)}
                    }

                    _crud.Update("t_kari_ritu", kariRitu, "kari_ritu_id = @id", prms)
                End If
            Next

            ' SQL実行
            _crud.Commit()

        Catch ex As Exception
            _crud.Rollback()
            MessageBox.Show("登録エラー: " & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetKariRituDictionary(row As DataRow) As Dictionary(Of String, Object)
        Dim kariRitu = New Dictionary(Of String, Object)

        For Each col As DataColumn In row.Table.Columns
            kariRitu(col.ColumnName) = row(col.ColumnName)
        Next

        Return kariRitu
    End Function

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class