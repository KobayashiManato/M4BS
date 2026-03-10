Imports Npgsql

Partial Public Class Form_f_M_BCAT_CHANGE
    Inherits Form_BCAT

    Public Property BcatId As Double = 0

    Private Sub Form_f_M_BCAT_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBcatCombos(cmb_BCAT2_CD, cmb_BCAT3_CD, cmb_BCAT4_CD, cmb_BCAT5_CD)
        LoadGenkCombo(cmb_GENK_CD)
        LoadSumCombos(cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD)
        LoadBknriCombo(cmb_BKNRI_CD)

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql = "SELECT * FROM m_bcat " &
                      "LEFT JOIN m_genk ON m_bcat.genk_id = m_genk.genk_id " &
                      "LEFT JOIN m_bknri ON m_bcat.bknri_id = m_bknri.bknri_id " &
                      "WHERE bcat_id = @id;"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", BcatId)
            }

            Dim dt As DataTable = _crud.GetDataTable(Sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_BCAT1_CD.SetText(row("bcat1_cd"))
            txt_BCAT1_NM.SetText(row("bcat1_nm"))
            cmb_BCAT2_CD.SelectedValue = row("bcat2_cd").ToString()
            txt_BCAT2_NM.SetText(row("bcat2_nm"))
            cmb_BCAT3_CD.SelectedValue = row("bcat3_cd").ToString()
            txt_BCAT3_NM.SetText(row("bcat3_nm"))
            cmb_BCAT4_CD.SelectedValue = row("bcat4_cd").ToString()
            txt_BCAT4_NM.SetText(row("bcat4_nm"))
            cmb_BCAT5_CD.SelectedValue = row("bcat5_cd").ToString()
            txt_BCAT5_NM.SetText(row("bcat5_nm"))

            cmb_GENK_CD.SelectedValue = row("genk_cd").ToString()
            txt_GENK_NM.SetText(row("genk_nm"))

            cmb_SUM1_CD.SelectedValue = row("sum1_cd").ToString()
            txt_SUM1_NM.SetText(row("sum1_nm"))
            cmb_SUM2_CD.SelectedValue = row("sum2_cd").ToString()
            txt_SUM2_NM.SetText(row("sum2_nm"))
            cmb_SUM3_CD.SelectedValue = row("sum3_cd").ToString()
            txt_SUM3_NM.SetText(row("sum3_nm"))

            cmb_BKNRI_CD.SelectedValue = row("bknri1_cd").ToString()
            txt_BKNRI_NM.SetText(row("bknri1_nm"))

            chk_KBF_KB.Checked = row("kbf_kb")
            chk_KBF_FB.Checked = row("kbf_fb")
            chk_KBF_SB.Checked = row("kbf_sb")
            chk_GENSONF.Checked = row("gensonf")

            txt_BIKO.SetText(row("biko"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_BCAT_ID.SetText(row("bcat_id"))

        Catch ex As Exception
            MessageBox.Show("詳細読込エラー: " & ex.Message)
        End Try
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [変更登録] ボタン
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

        If cmb_GENK_CD.SelectedValue Is Nothing Then
            bcat("genk_id") = 0
        Else
            ' genk_cdに対応したgenk_idを取得する
            bcat("genk_id") = _crud.ExecuteScalar(Of Integer)("SELECT genk_id FROM m_genk WHERE genk_cd = @cd",
                                                               New List(Of NpgsqlParameter) From {New NpgsqlParameter("@cd", cmb_GENK_CD.SelectedValue)})
        End If

        bcat("sum1_cd") = cmb_SUM1_CD.SelectedValue
        bcat("sum1_nm") = txt_SUM1_NM.Text
        bcat("sum2_cd") = cmb_SUM2_CD.SelectedValue
        bcat("sum2_nm") = txt_SUM2_NM.Text
        bcat("sum3_cd") = cmb_SUM3_CD.SelectedValue
        bcat("sum3_nm") = txt_SUM3_NM.Text

        If cmb_BKNRI_CD.SelectedValue Is Nothing Then
            bcat("bknri_id") = 0
        Else
            bcat("bknri_id") = _crud.ExecuteScalar(Of Integer)("SELECT bknri_id FROM m_bknri WHERE bknri1_cd = @cd",
                                                               New List(Of NpgsqlParameter) From {New NpgsqlParameter("@cd", cmb_BKNRI_CD.SelectedValue)})
        End If

        bcat("kbf_kb") = chk_KBF_KB.Checked
        bcat("kbf_fb") = chk_KBF_FB.Checked
        bcat("kbf_sb") = chk_KBF_SB.Checked
        bcat("gensonf") = chk_GENSONF.Checked

        bcat("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_bcat WHERE bcat_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_BCAT_ID.Text))})
        bcat("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_BCAT_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_bcat", bcat, "bcat_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_BCAT_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_BCAT_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_bcat", "bcat_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
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
End Class