Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_T_KARI_RITU_INP
    Inherits Form

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If START_DT.Text = "" Or txt_KARI_RITU.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim _crud As crudHelper = New crudHelper()

        Dim kari_ritu As New Dictionary(Of String, Object)
        ' 最大ID + 1
        kari_ritu("kari_ritu_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(kari_ritu_id), 0) + 1 FROM t_kari_ritu")
        kari_ritu("start_dt") = START_DT.Value
        kari_ritu("kari_ritu") = Double.Parse(txt_KARI_RITU.Text)

        kari_ritu("create_id") = 0
        kari_ritu("create_dt") = DateTime.Now
        kari_ritu("update_id") = 0
        kari_ritu("update_dt") = DateTime.Now
        kari_ritu("update_cnt") = 0
        kari_ritu("history_f") = False

        ' 新規行を追加
        _crud.Insert("t_kari_ritu", kari_ritu)

        Me.Close()
    End Sub
End Class