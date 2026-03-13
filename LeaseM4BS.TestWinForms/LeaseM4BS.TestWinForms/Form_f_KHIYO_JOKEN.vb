Imports System.Windows.Forms
Imports UtilDate

' --- 期間費用計上明細表 ---
Partial Public Class Form_f_KHIYO_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_KHIYO

    Public Sub New()
        InitializeComponent()
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' チェックが1つもされていない場合
        If Not (chk_REC_KBN_1.Checked Or chk_REC_KBN_2.Checked Or chk_REC_KBN_3.Checked Or chk_REC_KBN_4.Checked Or chk_REC_KBN_5.Checked Or chk_REC_KBN_6.Checked Or chk_REC_KBN_7.Checked) Then
            MessageBox.Show("出力対象が未入力です", "チェック", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 日付の順番を正しくする
        SwapIf(txt_DT_FROM, txt_DT_TO)

        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_KHIYO
        frm.DtFrom = txt_DT_FROM.Value
        frm.DtTo = txt_DT_TO.Value

        frm.CheckRecFlags = {chk_REC_KBN_1.Checked, chk_REC_KBN_2.Checked, chk_REC_KBN_3.Checked, chk_REC_KBN_4.Checked, chk_REC_KBN_5.Checked, chk_REC_KBN_6.Checked, chk_REC_KBN_7.Checked}

        frm.RadioSymbol = If(radio_MINUS.Checked, Symbol.Minus, Symbol.Plus)

        frm.ShowDialog()
        _prevForm = frm
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub

    ' [前回集計結果]ボタン
    Private Sub cmd_ZENKAI_Click(sender As Object, e As EventArgs) Handles cmd_ZENKAI.Click
        If _prevForm IsNot Nothing Then
            _prevForm.ShowDialog()
        End If
    End Sub

    Private Sub DATE_ValueChanged(sender As Object, e As EventArgs) Handles txt_DT_FROM.ValueChanged, txt_DT_TO.ValueChanged
        ' 期間計算(ヶ月)
        Dim duration As Integer = GetDuration(txt_DT_FROM.Value, txt_DT_TO.Value)

        If duration = 0 Then
            txt_DURATION.Text = ""
        Else
            txt_DURATION.Text = duration.ToString()
        End If
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class