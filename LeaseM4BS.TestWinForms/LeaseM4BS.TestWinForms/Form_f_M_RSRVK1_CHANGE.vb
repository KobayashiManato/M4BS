Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_RSRVK1_CHANGE
    Inherits Form

    Public Property Rsrvk1Id As Double = 0
    Private _crud As crudHelper = New crudHelper()

    Private Sub Form_f_M_RSRVK1_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM m_rsrvk1 WHERE rsrvk1_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", Rsrvk1Id)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_RSRVK1_CD.Text = row("rsrvk1_cd").ToString()
            txt_RSRVK1_NM.Text = row("rsrvk1_nm").ToString()

            txt_BIKO.Text = row("biko").ToString()
            txt_CREATE_DT.Text = row("create_dt").ToString()
            txt_UPDATE_DT.Text = row("update_dt").ToString()
            txt_RSRVK1_ID.Text = row("rsrvk1_id").ToString()
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
        If txt_RSRVK1_CD.Text = "" Or txt_RSRVK1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim rsrvk As New Dictionary(Of String, Object)
        rsrvk("rsrvk1_cd") = txt_RSRVK1_CD.Text
        rsrvk("rsrvk1_nm") = txt_RSRVK1_NM.Text

        rsrvk("biko") = txt_BIKO.Text
        rsrvk("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_rsrvk1 WHERE rsrvk1_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_RSRVK1_ID.Text))})
        rsrvk("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_RSRVK1_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_rsrvk1", rsrvk, "rsrvk1_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_RSRVK1_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_RSRVK1_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_rsrvk1", "rsrvk1_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class