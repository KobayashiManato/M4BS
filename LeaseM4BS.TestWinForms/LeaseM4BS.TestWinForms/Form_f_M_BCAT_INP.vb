Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports Npgsql

Partial Public Class Form_f_M_BCAT_INP
    Inherits Form_BCAT

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_BCAT_INP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBcatCombos(cmb_BCAT2_CD, cmb_BCAT3_CD, cmb_BCAT4_CD, cmb_BCAT5_CD)
        LoadGenkCombo(cmb_GENK_CD)
        LoadSumCombos(cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD)
        LoadBknriCombo(cmb_BKNRI_CD)
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_BCAT2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BCAT2_CD.DrawItem
        Combo_DrawItem(sender, e, {"bcat2_cd", "bcat2_nm"})
    End Sub

    Private Sub Combo_BCAT3_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BCAT3_CD.DrawItem
        Combo_DrawItem(sender, e, {"bcat3_cd", "bcat3_nm"})
    End Sub

    Private Sub Combo_BCAT4_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BCAT4_CD.DrawItem
        Combo_DrawItem(sender, e, {"bcat4_cd", "bcat4_nm"})
    End Sub

    Private Sub Combo_BCAT5_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BCAT5_CD.DrawItem
        Combo_DrawItem(sender, e, {"bcat5_cd", "bcat5_nm"})
    End Sub

    Private Sub Combo_GENK_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_GENK_CD.DrawItem
        Combo_DrawItem(sender, e, {"genk_cd", "genk_nm"})
    End Sub

    Private Sub Combo_SUM1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM1_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum1_cd", "sum1_nm"})
    End Sub

    Private Sub Combo_SUM2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM2_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum2_cd", "sum2_nm"})
    End Sub

    Private Sub Combo_SUM3_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM3_CD.DrawItem, cmb_BKNRI_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum3_cd", "sum3_nm"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    Private Sub cmb_BCAT2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BCAT2_CD.SelectedIndexChanged
        cmb_BCAT2_CD.SyncTo("bcat2_nm", txt_BCAT2_NM)
    End Sub

    Private Sub cmb_BCAT3_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BCAT3_CD.SelectedIndexChanged
        cmb_BCAT3_CD.SyncTo("bcat3_nm", txt_BCAT3_NM)
    End Sub

    Private Sub cmb_BCAT4_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BCAT4_CD.SelectedIndexChanged
        cmb_BCAT4_CD.SyncTo("bcat4_nm", txt_BCAT4_NM)
    End Sub

    Private Sub cmb_BCAT5_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BCAT5_CD.SelectedIndexChanged
        cmb_BCAT5_CD.SyncTo("bcat5_nm", txt_BCAT5_NM)
    End Sub

    Private Sub cmb_GENK_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_GENK_CD.SelectedIndexChanged
        cmb_GENK_CD.SyncTo("genk_nm", txt_GENK_NM)
    End Sub

    Private Sub cmb_SUM1_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM1_CD.SelectedIndexChanged
        cmb_SUM1_CD.SyncTo("sum1_nm", txt_SUM1_NM)
    End Sub

    Private Sub cmb_SUM2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM2_CD.SelectedIndexChanged
        cmb_SUM2_CD.SyncTo("sum2_nm", txt_SUM2_NM)
    End Sub

    Private Sub cmb_SUM3_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM3_CD.SelectedIndexChanged, cmb_BKNRI_CD.SelectedIndexChanged
        cmb_SUM3_CD.SyncTo("sum3_nm", txt_SUM3_NM)
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_BCAT1_CD.Text = "" Or txt_BCAT1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim bcat As New Dictionary(Of String, Object)
        ' 最大ID + 1
        bcat("bcat_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(bcat_id), 0) + 1 FROM m_bcat")
        bcat("bcat1_cd") = txt_BCAT1_CD.Text
        bcat("bcat1_nm") = txt_BCAT1_NM.Text
        bcat("bcat2_cd") = cmb_BCAT2_CD.SelectedValue
        bcat("bcat2_nm") = txt_BCAT2_NM.Text
        bcat("bcat3_cd") = cmb_BCAT3_CD.SelectedValue
        bcat("bcat3_nm") = txt_BCAT3_NM.Text
        bcat("bcat4_cd") = cmb_BCAT4_CD.SelectedValue
        bcat("bcat4_nm") = txt_BCAT4_NM.Text
        bcat("bcat5_cd") = cmb_BCAT5_CD.SelectedValue
        bcat("bcat5_nm") = txt_BCAT5_NM.Text

        ' 非null制約対策
        If cmb_GENK_CD.SelectedValue Is Nothing Then
            bcat("genk_id") = 0
        Else
            ' genk_cdに対応したgenk_idを取得する
            bcat("genk_id") = _crud.ExecuteScalar(Of Integer)("SELECT genk_id FROM m_genk WHERE genk_cd = @cd",
                                                               New List(Of NpgsqlParameter) From {New NpgsqlParameter("@cd", cmb_GENK_CD.SelectedValue)})
        End If

        bcat("skti_id") = 0
        bcat("sum1_cd") = cmb_SUM1_CD.SelectedValue
        bcat("sum1_nm") = txt_SUM1_NM.Text
        bcat("sum2_cd") = cmb_SUM2_CD.SelectedValue
        bcat("sum2_nm") = txt_SUM2_NM.Text
        bcat("sum3_cd") = cmb_SUM3_CD.SelectedValue
        bcat("sum3_nm") = txt_SUM3_NM.Text

        ' 非null制約対策
        If cmb_BKNRI_CD.SelectedValue Is Nothing Then
            bcat("bknri_id") = 0
        Else
            ' bknri1_cdに対応したbknri_idを取得する
            bcat("bknri_id") = _crud.ExecuteScalar(Of Integer)("SELECT bknri_id FROM m_bknri WHERE bknri1_cd = @cd",
                                                               New List(Of NpgsqlParameter) From {New NpgsqlParameter("@cd", cmb_BKNRI_CD.SelectedValue)})
        End If

        bcat("kbf_kb") = chk_KBF_KB.Checked
        bcat("kbf_fb") = chk_KBF_FB.Checked
        bcat("kbf_sb") = chk_KBF_SB.Checked
        bcat("gensonf") = chk_GENSONF.Checked

        bcat("create_id") = 0
        bcat("create_dt") = DateTime.Now
        bcat("update_id") = 0
        bcat("update_dt") = DateTime.Now
        bcat("update_cnt") = 0
        bcat("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_bcat", bcat)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class