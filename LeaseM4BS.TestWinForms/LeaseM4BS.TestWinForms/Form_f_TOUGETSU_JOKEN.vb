' --- 月次仕訳計上フレックス ---
Partial Public Class Form_f_TOUGETSU_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_KEIJO

    Private Sub Form_f_FlexMonthlyPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_KEIJO()

        frm.LabelText = GetLabelText()
        frm.ShowDialog()

        _prevForm = frm
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub

    ' [祝日]ボタン
    Private Sub cmd_HOLIDAY_Click(sender As Object, e As EventArgs) Handles cmd_HOLIDAY.Click
        Dim frm As New Form_f_T_HOLIDAY

        frm.ShowDialog()
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

    ' ラベルテキストを生成
    Private Function GetLabelText()
        Dim labelText As String = "集計月:  " & txt_TARGET_MONTH.Text & "  "

        ' 計上タイミング
        If radio_SHIME_BASE.Checked Then
            labelText &= radio_SHIME_BASE.Text & "  "
        ElseIf radio_CONTRACT_BASE.Checked Then
            labelText &= radio_CONTRACT_BASE.Text & "  "
        ElseIf radio_CONTRACT_BASE.Checked Then
            labelText &= radio_CONTRACT_BASE.Text & "  "
        End If

        ' 集計対象
        If radio_LEASE.Checked Then
            labelText &= radio_LEASE.Text & "  "
        ElseIf radio_HENF.Checked Then
            labelText &= radio_HENF.Text & "  "
        ElseIf radio_ALL.Checked Then
            labelText &= radio_ALL.Text & "  "
        End If

        ' 明細
        If radio_BUKN.Checked Then
            labelText &= radio_BUKN.Text & "  "
        ElseIf radio_HAIF.Checked Then
            labelText &= radio_HAIF.Text & "  "
        End If

        ' 元本・利息計算
        If chk_CALCULATE.Checked Then
            labelText &= "元本・利息を計算"
        End If

        Return labelText
    End Function
End Class