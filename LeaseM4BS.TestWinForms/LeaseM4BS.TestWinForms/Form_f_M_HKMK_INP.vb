Imports System.Windows.Forms

Partial Public Class Form_f_M_HKMK_INP
    Inherits Form_HKMK

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_HKMK_INP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSumCombos(cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD)
        LoadPtnCombos(cmb_PTN_CD3)
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_HKMK_CD.Text = "" Or txt_HKMK_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim hkmk As New Dictionary(Of String, Object)
        ' 最大ID + 1
        hkmk("hkmk_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(hkmk_id), 0) + 1 FROM m_hkmk")
        hkmk("hkmk_cd") = txt_HKMK_CD.Text
        hkmk("hkmk_nm") = txt_HKMK_NM.Text
        hkmk("knjkb_id") = 4

        hkmk("sum1_cd") = cmb_SUM1_CD.SelectedValue
        hkmk("sum1_nm") = txt_SUM1_NM.Text
        hkmk("sum2_cd") = cmb_SUM2_CD.SelectedValue
        hkmk("sum2_nm") = txt_SUM2_NM.Text
        hkmk("sum3_cd") = cmb_SUM3_CD.SelectedValue
        hkmk("sum3_nm") = txt_SUM3_NM.Text

        hkmk("hrel_ptn_cd3") = cmb_PTN_CD3.SelectedValue
        hkmk("hrel_ptn_nm3") = txt_PTN_NM3.Text
        hkmk("biko") = txt_BIKO.Text
        hkmk("create_id") = 0
        hkmk("create_dt") = DateTime.Now
        hkmk("update_id") = 0
        hkmk("update_dt") = DateTime.Now
        hkmk("update_cnt") = 0
        hkmk("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_hkmk", hkmk)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_SUM1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM1_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum1_cd", "sum1_nm"})
    End Sub

    Private Sub Combo_SUM2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM2_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum2_cd", "sum2_nm"})
    End Sub

    Private Sub Combo_SUM3_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM3_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum3_cd", "sum3_nm"})
    End Sub

    Private Sub Combo_PTN_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_PTN_CD3.DrawItem
        Combo_DrawItem(sender, e, {"ptn_cd3", "ptn_nm3"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    Private Sub cmb_SUM1_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM1_CD.SelectedIndexChanged
        cmb_SUM1_CD.SyncTo("sum1_nm", txt_SUM1_NM)
    End Sub

    Private Sub cmb_SUM2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM2_CD.SelectedIndexChanged
        cmb_SUM2_CD.SyncTo("sum2_nm", txt_SUM2_NM)
    End Sub

    Private Sub cmb_SUM3_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM3_CD.SelectedIndexChanged
        cmb_SUM3_CD.SyncTo("sum3_nm", txt_SUM3_NM)
    End Sub

    Private Sub cmb_PTN_CD3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_PTN_CD3.SelectedIndexChanged
        cmb_PTN_CD3.SyncTo("ptn_nm3", txt_PTN_NM3)
    End Sub
End Class