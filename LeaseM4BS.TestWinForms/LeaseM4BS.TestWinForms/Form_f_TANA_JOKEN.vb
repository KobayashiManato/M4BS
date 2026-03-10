Imports System.Windows.Forms

' --- 棚卸明細表 ---
Partial Public Class Form_f_TANA_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_TANA

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_TANA_JOKEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_TANA()
        frm.TanaDate = txt_TANA_DATE.Value

        frm.ShowDialog()
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

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class