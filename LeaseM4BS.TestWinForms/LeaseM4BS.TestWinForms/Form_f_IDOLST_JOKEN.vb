Imports System.Windows.Forms

Partial Public Class Form_f_IDOLST_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_IDOLST

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_IDOLST_JOKEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' チェックが1つもされていない場合
        If Not (chk_BCAT1_F.Checked Or chk_BCAT2_F.Checked Or chk_BCAT3_F.Checked Or chk_BCAT4_F.Checked Or chk_BCAT5_F.Checked) Then
            MessageBox.Show("管理部署1～5のうち少なくとも1つにチェックしてください。", "チェック", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 集計期間の順番を正しくする
        SwapIf(txt_IDO_DT_FROM, txt_IDO_DT_TO)

        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_IDOLST
        frm.LabelText = GetLabelText()
        frm.DtFrom = txt_IDO_DT_FROM.Value
        frm.DtTo = txt_IDO_DT_TO.Value

        frm.CheckBcatFlags = {chk_BCAT1_F.Checked, chk_BCAT2_F.Checked, chk_BCAT3_F.Checked, chk_BCAT4_F.Checked, chk_BCAT5_F.Checked}

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

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' ラベルテキストを生成
    Private Function GetLabelText()
        ' 移動日
        Dim labelText As String = "移動日:　" & txt_IDO_DT_FROM.Text & "～" & txt_IDO_DT_TO.Text

        ' 管理部署
        labelText &= " 移動チェックカテゴリ："

        If chk_BCAT1_F.Checked Then
            labelText &= " 管理部署1"
        End If

        If chk_BCAT2_F.Checked Then
            labelText &= "、管理部署2"
        End If

        If chk_BCAT3_F.Checked Then
            labelText &= "、管理部署3"
        End If

        If chk_BCAT4_F.Checked Then
            labelText &= "、管理部署4"
        End If

        If chk_BCAT5_F.Checked Then
            labelText &= "、管理部署5"
        End If

        Return labelText
    End Function
End Class