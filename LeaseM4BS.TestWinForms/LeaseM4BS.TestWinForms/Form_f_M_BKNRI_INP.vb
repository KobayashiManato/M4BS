Imports System.Windows.Forms
Imports Npgsql

Partial Public Class Form_f_M_BKNRI_INP
    Inherits Form_BKNRI

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_BKNRI_INP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBknriCombos(cmb_BKNRI2_CD, cmb_BKNRI3_CD)
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_BKNRI1_CD.Text = "" Or txt_BKNRI1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim bknri As New Dictionary(Of String, Object)
        ' 最大ID + 1
        bknri("bknri_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(bknri_id), 0) + 1 FROM m_bknri")
        bknri("bknri1_cd") = txt_BKNRI1_CD.Text
        bknri("bknri1_nm") = txt_BKNRI1_NM.Text
        bknri("bknri2_cd") = cmb_BKNRI2_CD.SelectedValue
        bknri("bknri2_nm") = txt_BKNRI2_NM.Text
        bknri("bknri3_cd") = cmb_BKNRI3_CD.SelectedValue
        bknri("bknri3_nm") = txt_BKNRI3_NM.Text

        bknri("biko") = txt_BIKO.Text
        bknri("create_id") = 0
        bknri("create_dt") = DateTime.Now
        bknri("update_id") = 0
        bknri("update_dt") = DateTime.Now
        bknri("update_cnt") = 0
        bknri("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_bknri", bknri)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_BKNRI2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BKNRI2_CD.DrawItem
        Combo_DrawItem(sender, e, {"bknri2_cd", "bknri2_nm"})
    End Sub

    Private Sub Combo_BKNRI3_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BKNRI3_CD.DrawItem
        Combo_DrawItem(sender, e, {"bknri3_cd", "bknri3_nm"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    Private Sub cmb_bknri2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BKNRI2_CD.SelectedIndexChanged
        cmb_BKNRI2_CD.SyncTo("bknri2_nm", txt_BKNRI2_NM)
    End Sub

    Private Sub cmb_BKNRI3_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BKNRI3_CD.SelectedIndexChanged
        cmb_BKNRI3_CD.SyncTo("bknri3_nm", txt_BKNRI3_NM)
    End Sub
End Class