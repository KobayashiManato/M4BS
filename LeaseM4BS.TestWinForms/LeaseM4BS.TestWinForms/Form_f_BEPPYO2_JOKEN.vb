Imports System.Windows.Forms

' --- 別表16（4） ---
Partial Public Class Form_f_BEPPYO2_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_BEPPYO2

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_BEPPYO_JOKEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 今年度を設定
        txt_FISCAL_YEAR.Text = DateTime.Today.AddMonths(-3).Year
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' 必須項目が未入力
        If txt_FISCAL_YEAR.Text = "" Then
            MessageBox.Show("必須項目が未入力です。", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim year As Integer
        If Integer.TryParse(txt_FISCAL_YEAR.Text, year) = False Then
            MessageBox.Show("数値を入力してください", "入力数値", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 年度が正しくない(9999もだめ(+1するとyyyyに収まらないから))
        If year <= 0 OrElse year >= 9999 Then
            MessageBox.Show("正しい年度を入力してください", "入力年度", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_BEPPYO2()
        frm.FiscalYear = year

        If chk_FULL_YEAR.Checked Then
            frm.FiscalPeriod = PeriodType.FullYear
        Else
            frm.FiscalPeriod = PeriodType.HalfYear
        End If

        frm.DtFrom = GetMonthStart(txt_DT_FROM.Text)
        frm.DtTo = GetMonthEnd(txt_DT_TO.Text)

        frm.ShowDialog()

        _prevForm = frm
    End Sub

    Private Sub txt_FISCAL_YEAR_Changed(sender As Object, e As EventArgs) Handles txt_FISCAL_YEAR.TextChanged, chk_FULL_YEAR.CheckedChanged, chk_HALF_YEAR.CheckedChanged
        Dim year As Integer

        If Integer.TryParse(txt_FISCAL_YEAR.Text, year) AndAlso year >= 1 AndAlso year <= 9998 Then
            ' 年度開始月と終了月
            txt_DT_FROM.Text = New Date(year, 4, 1).ToString("yyyy/MM")

            ' 通期か中間
            If chk_FULL_YEAR.Checked Then
                txt_DT_TO.Text = New Date(year + 1, 3, 31).ToString("yyyy/MM")
            Else
                txt_DT_TO.Text = New Date(year, 9, 30).ToString("yyyy/MM")
            End If
        End If
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