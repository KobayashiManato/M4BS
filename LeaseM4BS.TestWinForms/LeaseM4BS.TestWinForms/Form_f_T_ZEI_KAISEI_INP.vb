Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_T_ZEI_KAISEI_INP
    Inherits Form

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If TEKI_DT_FROM.Text = "" Or TEKI_DT_TO.Text = "" Or txt_ZRITU.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim _crud As crudHelper = New crudHelper()

        Dim zei_kaisei As New Dictionary(Of String, Object)
        ' 最大ID + 1
        zei_kaisei("zei_kaisei_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(zei_kaisei_id), 0) + 1 FROM t_zei_kaisei")
        zei_kaisei("teki_dt_from") = TEKI_DT_FROM.Value
        zei_kaisei("teki_dt_to") = TEKI_DT_TO.Value
        zei_kaisei("zritu") = Double.Parse(txt_ZRITU.Text)
        zei_kaisei("kkyak_dt_from") = KKYAK_DT_FROM.Value
        zei_kaisei("kkyak_dt_to") = KKYAK_DT_TO.Value

        zei_kaisei("create_id") = 0
        zei_kaisei("create_dt") = DateTime.Now
        zei_kaisei("update_id") = 0
        zei_kaisei("update_dt") = DateTime.Now
        zei_kaisei("update_cnt") = 0
        zei_kaisei("history_f") = False

        ' 新規行を追加
        _crud.Insert("t_zei_kaisei", zei_kaisei)

        Me.Close()
    End Sub
End Class