Imports Npgsql

Partial Public Class Form_f_M_LCPT_CHANGE
    Inherits Form_LCPT

    Public Property LcptId As Double = 0

    Private Sub Form_f_M_LCPT_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLcptCombo(cmb_LCPT2_CD)
        LoadSumCombos(cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD)

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM m_lcpt WHERE lcpt_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", LcptId)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_LCPT1_CD.SetText(row("lcpt1_cd"))
            txt_LCPT1_NM.SetText(row("lcpt1_nm"))
            cmb_LCPT2_CD.SelectedValue = row("lcpt2_cd").ToString()
            txt_LCPT2_NM.SetText(row("lcpt2_nm"))
            cmb_SUM1_CD.SelectedValue = row("sum1_cd").ToString()
            txt_SUM1_NM.SetText(row("sum1_nm"))
            cmb_SUM2_CD.SelectedValue = row("sum2_cd").ToString()
            txt_SUM2_NM.SetText(row("sum2_nm"))
            cmb_SUM3_CD.SelectedValue = row("sum3_cd").ToString()
            txt_SUM3_NM.SetText(row("sum3_nm"))

            ' 1行目
            txt_SHIME_DAY_1.SetText(row("shime_day_1"))
            txt_SSHRI_KN1_1.SetText(row("sshri_kn1_1"))
            txt_SHRI_DAY1_1.SetText(row("shri_day1_1"))
            txt_SSHRI_KN2_1.SetText(row("sshri_kn2_1"))
            txt_SHRI_DAY2_1.SetText(row("shri_day2_1"))

            ' 2行目
            txt_SHIME_DAY_2.SetText(row("shime_day_2"))
            txt_SSHRI_KN1_2.SetText(row("sshri_kn1_2"))
            txt_SHRI_DAY1_2.SetText(row("shri_day1_2"))
            txt_SSHRI_KN2_2.SetText(row("sshri_kn2_2"))
            txt_SHRI_DAY2_2.SetText(row("shri_day2_2"))

            ' 3行目
            txt_SHIME_DAY_3.SetText(row("shime_day_3"))
            txt_SSHRI_KN1_3.SetText(row("sshri_kn1_3"))
            txt_SHRI_DAY1_3.SetText(row("shri_day1_3"))
            txt_SSHRI_KN2_3.SetText(row("sshri_kn2_3"))
            txt_SHRI_DAY2_3.SetText(row("shri_day2_3"))

            txt_SAI_DENOMI.SetText(row("sai_denomi"))
            txt_BIKO.SetText(row("biko"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_LCPT_ID.SetText(row("lcpt_id"))

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
        If txt_LCPT1_CD.Text = "" Or txt_LCPT1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim lcpt As New Dictionary(Of String, Object)
        lcpt("lcpt1_cd") = txt_LCPT1_CD.Text
        lcpt("lcpt1_nm") = txt_LCPT1_NM.Text
        lcpt("lcpt2_cd") = cmb_LCPT2_CD.SelectedValue
        lcpt("lcpt2_nm") = txt_LCPT2_NM.Text
        lcpt("sum1_cd") = cmb_SUM1_CD.SelectedValue
        lcpt("sum1_nm") = txt_SUM1_NM.Text
        lcpt("sum2_cd") = cmb_SUM2_CD.SelectedValue
        lcpt("sum2_nm") = txt_SUM2_NM.Text
        lcpt("sum3_cd") = cmb_SUM3_CD.SelectedValue
        lcpt("sum3_nm") = txt_SUM3_NM.Text

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

        lcpt("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_kknri WHERE kknri_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_LCPT_ID.Text))})
        lcpt("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_LCPT_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_lcpt", lcpt, "lcpt_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_LCPT_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_LCPT_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_lcpt", "lcpt_id = @id", prms)

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