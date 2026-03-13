Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 財務諸表注記 ---
Partial Public Class Form_f_CHUKI_JOKEN
    Inherits Form

    Private _prevForm As Form_f_flx_CHUKI

    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_CHUKI_JOKEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlSkmk As String = "SELECT skmk_cd, skmk_nm FROM m_skmk WHERE skmk_id <> 0 ORDER BY skmk_cd;"
        Dim sqlLcpt As String = "SELECT lcpt1_cd, lcpt1_nm FROM m_lcpt WHERE lcpt_id <> 0 ORDER BY lcpt1_cd;"
        Dim sqlBcat As String = "SELECT bcat1_cd, bcat1_nm FROM m_bcat WHERE bcat_id <> 0 ORDER BY bcat1_cd;"

        cmb_SKMK_CD.Bind(sqlSkmk, "skmk_cd", "skmk_cd")
        cmb_LCPT1_CD.Bind(sqlLcpt, "lcpt1_cd", "lcpt1_cd")
        cmb_BCAT1_CD.Bind(sqlBcat, "bcat1_cd", "bcat1_cd")

        For Each cmb In {cmb_SKMK_CD, cmb_LCPT1_CD, cmb_BCAT1_CD}
            cmb.AdjustSize()
            cmb.SelectedIndex = -1
        Next
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        If txt_DT_FROM.Value = Nothing OrElse txt_DT_TO.Value = Nothing Then
            MessageBox.Show("必須項目が未入力です。", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If chk_LEAKBN_ITENGAI_F.Checked = False And chk_LEAKBN_OPE_F.Checked = False Then
            MessageBox.Show("リース区分が設定されていません。", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim frm As New Form_f_flx_CHUKI()

        ' 値の順番を正しくする
        SwapIf(txt_DT_FROM, txt_DT_TO)
        SwapIf(txt_KYKM_NO_FROM, txt_KYKM_NO_TO)

        frm.labelText = GenerateLabelText()

        Dim prms As New List(Of NpgsqlParameter)

        frm.WhereClause = GenerateWhereClause(prms)
        frm.Prms = prms

        frm.ShowDialog()

        _prevForm = frm    ' 前回集計結果表示用
    End Sub

    ' [設定クリア]ボタン
    Private Sub cmd_CLEAR_Click(sender As Object, e As EventArgs) Handles cmd_CLEAR.Click
        ' 初期化
        chk_LEAKBN_ITENGAI_F.Checked = True
        chk_LEAKBN_OPE_F.Checked = True
        radio_FOLLOW.Checked = True

        txt_KYKM_NO_FROM.Text = ""
        txt_KYKM_NO_TO.Text = ""

        cmb_SKMK_CD.SelectedIndex = -1
        cmb_LCPT1_CD.SelectedIndex = -1
        cmb_BCAT1_CD.SelectedIndex = -1
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

    ' エンターキーが押されたら次のコントロールへ移動
    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        HandleEnterKeyNavigation(Me, e)
    End Sub

    Private Function GenerateWhereClause(ByRef prms As List(Of NpgsqlParameter)) As String
        Dim whereClause As String

        whereClause &= "WHERE (kykh.start_dt <= @dtTo AND kykh.end_dt >= @dtFrom) "

        prms.Add(New NpgsqlParameter("@dtFrom", GetMonthStart(txt_DT_FROM.Value)))
        prms.Add(New NpgsqlParameter("@dtTo", GetMonthEnd(txt_DT_TO.Value)))

        ' リース区分
        If chk_LEAKBN_ITENGAI_F.Checked And chk_LEAKBN_OPE_F.Checked Then
            whereClause &= "AND kykm.leakbn_id IN (1, 2) "
        ElseIf chk_LEAKBN_ITENGAI_F.Checked Then
            whereClause &= "AND kykm.leakbn_id = 1 "
        ElseIf chk_LEAKBN_OPE_F.Checked Then
            whereClause &= "AND kykm.leakbn_id = 2 "
        End If

        ' 省略基準
        If radio_FOLLOW.Checked Then
            whereClause &= "AND kykm.chuum_id = 1 "
        ElseIf radio_OMISSION.Checked Then
            whereClause &= "AND kykm.chuum_id = 2 "
        End If

        ' 物件No
        Dim kyknNo As Integer
        If Integer.TryParse(txt_KYKM_NO_FROM.Text, kyknNo) Then
            whereClause &= "AND kykm.kykm_no >= @kyknNoFrom "
            prms.Add(New NpgsqlParameter("@kyknNoFrom", kyknNo))
        End If

        If Integer.TryParse(txt_KYKM_NO_TO.Text, kyknNo) Then
            whereClause &= "AND kykm.kykm_no <= @kyknNoTo "
            prms.Add(New NpgsqlParameter("@kyknNoTo", kyknNo))
        End If

        ' 資産科目
        If cmb_SKMK_CD.SelectedValue IsNot Nothing Then
            whereClause &= "AND skmk.skmk_cd = @skmkCd "
            prms.Add(New NpgsqlParameter("@skmkCd", cmb_SKMK_CD.SelectedValue))
        End If

        ' リース会社
        If cmb_LCPT1_CD.SelectedValue IsNot Nothing Then
            whereClause &= "AND lcpt.lcpt1_cd = @lcptCd "
            prms.Add(New NpgsqlParameter("@lcptCd", cmb_LCPT1_CD.SelectedValue))
        End If

        ' 管理部署
        If cmb_BCAT1_CD.SelectedValue IsNot Nothing Then
            whereClause &= "AND b_bcat.bcat_cd = @bcatCd "
            prms.Add(New NpgsqlParameter("@bcatCd", cmb_BCAT1_CD.SelectedValue))
        End If

        Return whereClause
    End Function

    Private Function GenerateLabelText() As String
        Dim labelText = "決算期間："

        labelText &= txt_DT_FROM.Value.ToString("yyyy/MM") & "～" & txt_DT_TO.Value.ToString("yyyy/MM") & "  "

        ' todo どの条件でもなぜか表示されるテキスト
        labelText &= "所有権移転外ファイナンスリースの計算条件  "

        If radio_TEIGAKU.Checked Then
            labelText &= "償却方法：リース定額  "
        Else
            labelText &= "償却方法：近似定率  "
        End If

        If radio_RISOKU.Checked Then
            labelText &= "利息計算：利息法  "
        Else
            labelText &= "利息計算：利子込法  "
        End If

        Return labelText
    End Function

    ' =========================================================
    '  コンボボックスの2列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_SKMK_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SKMK_CD.DrawItem
        Combo_DrawItem(sender, e, {"skmk_cd", "skmk_nm"})
    End Sub

    Private Sub Combo_LCPT_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_LCPT1_CD.DrawItem
        Combo_DrawItem(sender, e, {"lcpt1_cd", "lcpt1_nm"})
    End Sub

    Private Sub Combo_BCAT_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BCAT1_CD.DrawItem
        Combo_DrawItem(sender, e, {"bcat1_cd", "bcat1_nm"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    Private Sub cmb_SKMK_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SKMK_CD.SelectedIndexChanged
        cmb_SKMK_CD.SyncTo("skmk_nm", txt_SKMK_NM)
    End Sub

    Private Sub cmb_LCPT1_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_LCPT1_CD.SelectedIndexChanged
        cmb_LCPT1_CD.SyncTo("lcpt1_nm", txt_LCPT1_NM)
    End Sub

    Private Sub cmb_BCAT1_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BCAT1_CD.SelectedIndexChanged
        cmb_BCAT1_CD.SyncTo("bcat1_nm", txt_BCAT1_NM)
    End Sub
End Class