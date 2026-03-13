Imports System.ComponentModel
Imports System.Windows.Forms
Imports Npgsql

Partial Public Class Form_f_M_LCPT_INP
    Inherits Form_LCPT

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_LCPT_INP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLcptCombo(cmb_LCPT2_CD)
        LoadSumCombos(cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD)
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_LCPT1_CD.Text = "" Or txt_LCPT1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim lcpt As New Dictionary(Of String, Object)
        ' 最大ID + 1
        lcpt("lcpt_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(lcpt_id), 0) + 1 FROM m_lcpt")
        lcpt("lcpt1_cd") = txt_LCPT1_CD.Text
        lcpt("lcpt1_nm") = txt_LCPT1_NM.Text
        lcpt("lcpt2_cd") = cmb_LCPT2_CD.SelectedValue
        lcpt("lcpt2_nm") = txt_LCPT2_NM.Text

        ' 1行目
        lcpt("shime_day_1") = NzInt(txt_SHIME_DAY_1.Text, DBNull.Value)
        lcpt("sshri_kn1_1") = NzInt(txt_SSHRI_KN1_1.Text, DBNull.Value)
        lcpt("shri_day1_1") = NzInt(txt_SHRI_DAY1_1.Text, DBNull.Value)
        lcpt("sshri_kn2_1") = NzInt(txt_SSHRI_KN2_1.Text, DBNull.Value)
        lcpt("shri_day2_1") = NzInt(txt_SHRI_DAY2_1.Text, DBNull.Value)

        ' 2行目
        lcpt("shime_day_2") = NzInt(txt_SHIME_DAY_2.Text, DBNull.Value)
        lcpt("sshri_kn1_2") = NzInt(txt_SSHRI_KN1_2.Text, DBNull.Value)
        lcpt("shri_day1_2") = NzInt(txt_SHRI_DAY1_2.Text, DBNull.Value)
        lcpt("sshri_kn2_2") = NzInt(txt_SSHRI_KN2_2.Text, DBNull.Value)
        lcpt("shri_day2_2") = NzInt(txt_SHRI_DAY2_2.Text, DBNull.Value)

        ' 3行目
        lcpt("shime_day_3") = NzInt(txt_SHIME_DAY_3.Text, DBNull.Value)
        lcpt("sshri_kn1_3") = NzInt(txt_SSHRI_KN1_3.Text, DBNull.Value)
        lcpt("shri_day1_3") = NzInt(txt_SHRI_DAY1_3.Text, DBNull.Value)
        lcpt("sshri_kn2_3") = NzInt(txt_SSHRI_KN2_3.Text, DBNull.Value)
        lcpt("shri_day2_3") = NzInt(txt_SHRI_DAY2_3.Text, DBNull.Value)

        lcpt("create_id") = 0
        lcpt("create_dt") = DateTime.Now
        lcpt("update_id") = 0
        lcpt("update_dt") = DateTime.Now
        lcpt("update_cnt") = 0
        lcpt("history_f") = False

        lcpt("sum1_cd") = cmb_SUM1_CD.SelectedValue
        lcpt("sum1_nm") = txt_SUM1_NM.Text
        lcpt("sum2_cd") = cmb_SUM2_CD.SelectedValue
        lcpt("sum2_nm") = txt_SUM2_NM.Text
        lcpt("sum3_cd") = cmb_SUM3_CD.SelectedValue
        lcpt("sum3_nm") = txt_SUM3_NM.Text

        ' Not Null項目
        lcpt("shho_id_s_1") = 0
        lcpt("shho_id_n_1") = 0
        lcpt("shho_id_s_2") = 0
        lcpt("shho_id_n_2") = 0
        lcpt("shho_id_s_3") = 0
        lcpt("shho_id_n_3") = 0

        ' 新規行を追加
        _crud.Insert("m_lcpt", lcpt)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_LCPT2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_LCPT2_CD.DrawItem
        Combo_DrawItem(sender, e, {"lcpt2_cd", "lcpt2_nm"})
    End Sub

    Private Sub Combo_SUM1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM1_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum1_cd", "sum1_nm"})
    End Sub

    Private Sub Combo_SUM2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM2_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum2_cd", "sum2_nm"})
    End Sub

    Private Sub Combo_SUM3_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM3_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum3_cd", "sum3_nm"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    Private Sub cmb_LCPT2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_LCPT2_CD.SelectedIndexChanged
        cmb_LCPT2_CD.SyncTo("lcpt2_nm", txt_LCPT2_NM)
    End Sub

    Private Sub cmb_SUM1_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM1_CD.SelectedIndexChanged
        cmb_SUM1_CD.SyncTo("sum1_nm", txt_SUM1_NM)
    End Sub

    Private Sub cmb_SUM2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM2_CD.SelectedIndexChanged
        cmb_SUM2_CD.SyncTo("sum2_nm", txt_SUM2_NM)
    End Sub

    Private Sub cmb_SUM3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM3_CD.SelectedIndexChanged
        cmb_SUM3_CD.SyncTo("sum3_nm", txt_SUM3_NM)
    End Sub
End Class