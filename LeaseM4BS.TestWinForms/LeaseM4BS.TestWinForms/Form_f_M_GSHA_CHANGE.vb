Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_GSHA_CHANGE
    Inherits Form

    Public Property GshaId As Double = 0
    Private _crud As crudHelper = New crudHelper()

    Private Sub Form_f_M_GSHA_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM m_gsha WHERE gsha_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", GshaId)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_GSHA_CD.SetText(row("gsha_cd"))
            txt_GSHA_NM.SetText(row("gsha_nm"))

            txt_BIKO.SetText(row("biko"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_GSHA_ID.SetText(row("gsha_id"))

        Catch ex As Exception
            MessageBox.Show("詳細読込エラー: " & ex.Message)
        End Try
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [変更登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_GSHA_CD.Text = "" Or txt_GSHA_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim gsha As New Dictionary(Of String, Object)
        gsha("gsha_cd") = txt_GSHA_CD.Text
        gsha("gsha_nm") = txt_GSHA_NM.Text

        gsha("biko") = txt_BIKO.Text
        gsha("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_gsha WHERE gsha_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_GSHA_ID.Text))})
        gsha("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_GSHA_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_gsha", gsha, "gsha_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_GSHA_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_GSHA_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_gsha", "gsha_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class