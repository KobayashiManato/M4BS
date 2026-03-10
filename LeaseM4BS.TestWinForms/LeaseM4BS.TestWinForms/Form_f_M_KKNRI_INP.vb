Imports System.Web.UI.WebControls.Expressions
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_KKNRI_INP
    Inherits Form_KKNRI

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_KKNRI_INP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKknriCombos(cmb_KKNRI2_CD, cmb_KKNRI3_CD)
        LoadCorpCombo(cmb_CORP1_CD)
        LoadPtnCombo(cmb_PTN_CD4)
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_KKNRI1_CD.Text = "" Or txt_KKNRI1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim kknri As New Dictionary(Of String, Object)
        ' 最大ID + 1
        kknri("kknri_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(kknri_id), 0) + 1 FROM m_kknri")
        kknri("kknri1_cd") = txt_KKNRI1_CD.Text
        kknri("kknri1_nm") = txt_KKNRI1_NM.Text
        kknri("kknri2_cd") = cmb_KKNRI2_CD.SelectedValue
        kknri("kknri2_nm") = txt_KKNRI2_NM.Text
        kknri("kknri3_cd") = cmb_KKNRI3_CD.SelectedValue
        kknri("kknri3_nm") = txt_KKNRI3_NM.Text

        ' 非null制約対策
        If cmb_CORP1_CD.SelectedValue Is Nothing Then
            kknri("corp_id") = 0
        Else
            ' corp1_cdに対応したcorp_idを取得する
            kknri("corp_id") = _crud.ExecuteScalar(Of Integer)("SELECT corp_id FROM m_corp WHERE corp1_cd = @cd",
                                                               New List(Of NpgsqlParameter) From {New NpgsqlParameter("@cd", cmb_CORP1_CD.SelectedValue)})
        End If

        kknri("create_id") = 0
        kknri("create_dt") = DateTime.Now
        kknri("update_id") = 0
        kknri("update_dt") = DateTime.Now
        kknri("update_cnt") = 0
        kknri("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_kknri", kknri)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_KKNRI2_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_KKNRI2_CD.DrawItem
        Combo_DrawItem(sender, e, {"kknri2_cd", "kknri2_nm"})
    End Sub

    Private Sub Combo_KKNRI3_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_KKNRI3_CD.DrawItem
        Combo_DrawItem(sender, e, {"kknri3_cd", "kknri3_nm"})
    End Sub

    Private Sub Combo_CORP_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_CORP1_CD.DrawItem
        Combo_DrawItem(sender, e, {"corp1_cd", "corp1_nm"})
    End Sub

    Private Sub Combo_PTN_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_PTN_CD4.DrawItem
        Combo_DrawItem(sender, e, {"hrel_ptn_cd4", "hrel_ptn_nm4"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    Private Sub cmb_KKNRI2_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_KKNRI2_CD.SelectedIndexChanged
        cmb_KKNRI2_CD.SyncTo("kknri2_nm", txt_KKNRI2_NM)
    End Sub

    Private Sub cmb_KKNRI3_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_KKNRI3_CD.SelectedIndexChanged
        cmb_KKNRI3_CD.SyncTo("kknri3_nm", txt_KKNRI3_NM)
    End Sub

    Private Sub cmb_CORP1_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_CORP1_CD.SelectedIndexChanged
        cmb_CORP1_CD.SyncTo("corp1_nm", txt_CORP1_NM)
    End Sub

    Private Sub cmb_PTN_CD4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_PTN_CD4.SelectedIndexChanged
        cmb_PTN_CD4.SyncTo("hrel_ptn_nm4", txt_PTN_NM4)
    End Sub
End Class