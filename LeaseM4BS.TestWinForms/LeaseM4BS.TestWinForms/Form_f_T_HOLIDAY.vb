Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_T_HOLIDAY
    Inherits Form

    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_T_HOLIDAY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sqlHolidays = "SELECT id, h_date, biko FROM t_holiday ORDER BY h_date"

        dgv_LIST.AutoGenerateColumns = False

        dgv_LIST.Columns("col_H_DATE").DataPropertyName = "h_date"
        dgv_LIST.Columns("col_BIKO").DataPropertyName = "biko"
        dgv_LIST.Columns("col_ID").DataPropertyName = "id"

        dgv_LIST.DataSource = _crud.GetDataTable(sqlHolidays)
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録]ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        'DBを更新
        SaveAllData()
    End Sub

    ' [行削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        ' データが選択されていないとき
        If dgv_LIST.CurrentRow Is Nothing OrElse dgv_LIST.RowCount = 0 Then
            Return
        End If

        ' 画面（DataGridView）から行を削除(DB空の削除は登録ボタンクリック時)
        dgv_LIST.Rows.Remove(dgv_LIST.CurrentRow)
    End Sub

    Private Sub SaveAllData()
        dgv_LIST.EndEdit()

        _crud.BeginTransaction()

        Dim dt As DataTable = DirectCast(dgv_LIST.DataSource, DataTable)

        Dim changeDt As DataTable = dt.GetChanges()
        If changeDt Is Nothing Then
            Return
        End If

        Try
            ' 削除行などでインデックスが変わるため、後ろからループを回す
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                Dim row As DataRow = dt.Rows(i)

                ' 新規
                If row.RowState = DataRowState.Added Then
                    Dim newHoliday As New Dictionary(Of String, Object)

                    newHoliday("id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(id), 0) FROM t_holiday") + 1
                    newHoliday("h_date") = row("h_date")
                    newHoliday("biko") = row("biko")

                    _crud.Insert("t_holiday", newHoliday)

                    ' 削除
                ElseIf row.RowState = DataRowState.Deleted Then
                    Dim id = row("id", DataRowVersion.Original)

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter) From {
                        {New NpgsqlParameter("@id", id)}
                    }

                    _crud.Delete("t_holiday", "id = @id", prms)

                    ' 更新
                ElseIf row.RowState = DataRowState.Modified Then
                    Dim holiday As New Dictionary(Of String, Object)

                    holiday("id") = row("id")
                    holiday("h_date") = row("h_date")
                    holiday("biko") = row("biko")

                    Dim id = row("id", DataRowVersion.Original)

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter) From {
                        {New NpgsqlParameter("@id", id)}
                    }

                    _crud.Update("t_holiday", holiday, "id = @id", prms)
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
End Class