Partial Public Class Form_f_MONTHLY_JORNAL_JOKEN

    Private _prevForm As Form_f_flx_MONTHLY_JOURNAL

    Private Sub Form_f_FlexMonthlyJornalEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' コンボボックスの設定
        Dim sqlSettei As String = "SELECT settei_id, val_short_nm FROM c_settei_idfld WHERE settei_id = 19 AND val_short_nm <> '';"

        cmb_SETTEI.Bind(sqlSettei, "val_short_nm", "settei_id")
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        If txt_DATE_FROM.Text = "" OrElse txt_DATE_TO.Text = "" Then
            MessageBox.Show("必須項目が未入力です。")
            Return
        End If

        ' 集計期間の指定を正しくする
        SwapIf(txt_DATE_FROM, txt_DATE_TO)

        Dim frm As New Form_f_flx_MONTHLY_JOURNAL
        frm.ShowDialog()

        _prevForm = frm
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub DATE_FROM_ValueChanged(sender As Object, e As EventArgs) Handles txt_DATE_FROM.ValueChanged
        txt_DATE_TO.Value = txt_DATE_FROM.Value
    End Sub

    Private Sub DATE_ValueChanged(sender As Object, e As EventArgs) Handles txt_DATE_FROM.ValueChanged, txt_DATE_TO.ValueChanged
        ' 期間計算(ヶ月)
        Dim duration As Integer = GetDuration(txt_DATE_FROM.Value, txt_DATE_TO.Value)

        If duration = 0 Then
            txt_DURATION.Text = ""
        Else
            txt_DURATION.Text = duration.ToString()
        End If
    End Sub

    ' [前回集計結果]ボタン
    Private Sub cmd_ZENKAI_Click(sender As Object, e As EventArgs) Handles cmd_ZENKAI.Click
        If _prevForm IsNot Nothing Then
            _prevForm.ShowDialog()
        End If
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class