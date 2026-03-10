' --- 予算実績集計 ---
Partial Public Class Form_f_YOSAN_JOKEN
    Private _prevForm As Form_f_flx_YOSAN

    Private Sub Form_f_YOSAN_JOKEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_DT_FROM_ValueChanged(Nothing, Nothing)
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' 変額リース料のチェック確認
        If chk_KOSHIN_YOSO_HENF_F.Checked Then
            If MessageBox.Show("「変額リース料の更新予想額を算出する」がONになっています。よろしいですか？", "選択確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        Else
            If MessageBox.Show("「変額リース料の更新予想額を算出する」がOFFになっています。よろしいですか？", "選択確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If

        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_YOSAN
        frm.DtFrom = txt_DT_FROM.Value
        frm.DtTo = txt_DT_TO.Value
        frm.NextDtFrom = txt_NEXT_DT_FROM.Value
        frm.NextDtTo = txt_NEXT_DT_TO.Value

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

    Private Sub txt_DT_FROM_ValueChanged(sender As Object, e As EventArgs) Handles txt_DT_FROM.ValueChanged
        txt_DT_TO.Value = DateAdd("m", 11, txt_DT_FROM.Value)
        txt_NEXT_DT_FROM.Value = DateAdd("m", 12, txt_DT_FROM.Value)
        txt_NEXT_DT_TO.Value = DateAdd("m", 23, txt_DT_FROM.Value)
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class