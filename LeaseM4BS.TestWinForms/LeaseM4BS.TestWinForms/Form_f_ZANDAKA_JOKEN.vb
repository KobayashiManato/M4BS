Imports System.Windows.Forms

' --- リース残高一覧表 ---
Partial Public Class Form_f_ZANDAKA_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_ZANDAKA

    Public Sub New()
        InitializeComponent()
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' 必須項目が未入力
        If txt_DT_FROM.Checked = False OrElse txt_DT_TO.Checked = False Then
            MessageBox.Show("必須項目が未入力です。", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 日付の順番を正しくする
        SwapIf(txt_DT_FROM, txt_DT_TO)

        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_ZANDAKA
        frm.DtFrom = GetMonthStart(txt_DT_FROM.Value)
        frm.DtTo = GetMonthEnd(txt_DT_TO.Value)

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

        txt_DURATION.Text = If(duration = 0, "", duration.ToString())
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class