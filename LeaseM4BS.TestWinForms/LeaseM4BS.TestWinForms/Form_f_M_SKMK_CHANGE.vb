Imports Npgsql

Partial Public Class Form_f_M_SKMK_CHANGE
    Inherits Form_SKMK

    Public Property SkmkId As Double = 0

    Private Sub Form_f_M_SKMK_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 集計区分1から15
        LoadSumCombos({cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD, cmb_SUM4_CD, cmb_SUM5_CD, cmb_SUM6_CD, cmb_SUM7_CD, cmb_SUM8_CD, cmb_SUM9_CD, cmb_SUM10_CD, cmb_SUM11_CD, cmb_SUM12_CD, cmb_SUM13_CD, cmb_SUM14_CD, cmb_SUM15_CD})
        LoadPtnCombo(cmb_PTN_CD1)

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sqlHead As String = "SELECT * FROM m_skmk WHERE skmk_id = @id"

            Dim prmHead As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", SkmkId)
            }

            Dim dtHead As DataTable = _crud.GetDataTable(sqlHead, prmHead)

            If dtHead.Rows.Count > 0 Then
                Dim row As DataRow = dtHead.Rows(0)

                ' 画面項目に値をセット
                txt_SKMK_CD.Text = row("skmk_cd").ToString()
                txt_SKMK_NM.Text = row("skmk_nm").ToString()

                cmb_SUM1_CD.SelectedValue = row("sum1_cd").ToString()
                cmb_SUM2_CD.SelectedValue = row("sum2_cd").ToString()
                cmb_SUM3_CD.SelectedValue = row("sum3_cd").ToString()
                cmb_SUM4_CD.SelectedValue = row("sum4_cd").ToString()
                cmb_SUM5_CD.SelectedValue = row("sum5_cd").ToString()
                cmb_SUM6_CD.SelectedValue = row("sum6_cd").ToString()
                cmb_SUM7_CD.SelectedValue = row("sum7_cd").ToString()
                cmb_SUM8_CD.SelectedValue = row("sum8_cd").ToString()
                cmb_SUM9_CD.SelectedValue = row("sum9_cd").ToString()
                cmb_SUM10_CD.SelectedValue = row("sum10_cd").ToString()
                cmb_SUM11_CD.SelectedValue = row("sum11_cd").ToString()
                cmb_SUM12_CD.SelectedValue = row("sum12_cd").ToString()
                cmb_SUM13_CD.SelectedValue = row("sum13_cd").ToString()
                cmb_SUM14_CD.SelectedValue = row("sum14_cd").ToString()
                cmb_SUM15_CD.SelectedValue = row("sum15_cd").ToString()

                txt_SUM1_NM.Text = row("sum1_nm").ToString()
                txt_SUM2_NM.Text = row("sum2_nm").ToString()
                txt_SUM3_NM.Text = row("sum3_nm").ToString()
                txt_SUM4_NM.Text = row("sum4_nm").ToString()
                txt_SUM5_NM.Text = row("sum5_nm").ToString()
                txt_SUM6_NM.Text = row("sum6_nm").ToString()
                txt_SUM7_NM.Text = row("sum7_nm").ToString()
                txt_SUM8_NM.Text = row("sum8_nm").ToString()
                txt_SUM9_NM.Text = row("sum9_nm").ToString()
                txt_SUM10_NM.Text = row("sum10_nm").ToString()
                txt_SUM11_NM.Text = row("sum11_nm").ToString()
                txt_SUM12_NM.Text = row("sum12_nm").ToString()
                txt_SUM13_NM.Text = row("sum13_nm").ToString()
                txt_SUM14_NM.Text = row("sum14_nm").ToString()
                txt_SUM15_NM.Text = row("sum15_nm").ToString()

                cmb_PTN_CD1.SelectedValue = row("hrel_ptn_cd1").ToString()
                txt_PTN_NM1.Text = row("hrel_ptn_nm1").ToString()

                txt_BIKO.Text = row("biko").ToString()
                txt_CREATE_DT.Text = row("create_dt").ToString()
                txt_UPDATE_DT.Text = row("update_dt").ToString()
                txt_SKMK_ID.Text = row("skmk_id").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("詳細読込エラー: " & ex.Message)
        End Try
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
    Private Sub Combo_SUM4_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM4_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum4_cd", "sum4_nm"})
    End Sub
    Private Sub Combo_SUM5_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM5_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum5_cd", "sum5_nm"})
    End Sub
    Private Sub Combo_SUM6_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM6_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum6_cd", "sum6_nm"})
    End Sub
    Private Sub Combo_SUM7_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM7_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum7_cd", "sum7_nm"})
    End Sub
    Private Sub Combo_SUM8_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM8_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum8_cd", "sum8_nm"})
    End Sub
    Private Sub Combo_SUM9_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM9_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum9_cd", "sum9_nm"})
    End Sub
    Private Sub Combo_SUM10_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM10_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum10_cd", "sum10_nm"})
    End Sub
    Private Sub Combo_SUM11_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM11_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum11_cd", "sum11_nm"})
    End Sub
    Private Sub Combo_SUM12_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM12_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum12_cd", "sum12_nm"})
    End Sub
    Private Sub Combo_SUM13_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM13_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum13_cd", "sum13_nm"})
    End Sub
    Private Sub Combo_SUM14_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM14_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum14_cd", "sum14_nm"})
    End Sub
    Private Sub Combo_SUM15_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SUM15_CD.DrawItem
        Combo_DrawItem(sender, e, {"sum15_cd", "sum15_nm"})
    End Sub
    Private Sub Combo_PTN_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_PTN_CD1.DrawItem
        Combo_DrawItem(sender, e, {"hrel_ptn_cd1", "hrel_ptn_nm1"})
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
    Private Sub cmb_SUM4_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM4_CD.SelectedIndexChanged
        cmb_SUM4_CD.SyncTo("sum4_nm", txt_SUM4_NM)
    End Sub
    Private Sub cmb_SUM5_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM5_CD.SelectedIndexChanged
        cmb_SUM5_CD.SyncTo("sum5_nm", txt_SUM5_NM)
    End Sub
    Private Sub cmb_SUM6_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM6_CD.SelectedIndexChanged
        cmb_SUM6_CD.SyncTo("sum6_nm", txt_SUM6_NM)
    End Sub
    Private Sub cmb_SUM7_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM7_CD.SelectedIndexChanged
        cmb_SUM7_CD.SyncTo("sum7_nm", txt_SUM7_NM)
    End Sub
    Private Sub cmb_SUM8_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM8_CD.SelectedIndexChanged
        cmb_SUM8_CD.SyncTo("sum8_nm", txt_SUM8_NM)
    End Sub
    Private Sub cmb_SUM9_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM9_CD.SelectedIndexChanged
        cmb_SUM9_CD.SyncTo("sum9_nm", txt_SUM9_NM)
    End Sub
    Private Sub cmb_SUM10_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM10_CD.SelectedIndexChanged
        cmb_SUM10_CD.SyncTo("sum10_nm", txt_SUM10_NM)
    End Sub
    Private Sub cmb_SUM11_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM11_CD.SelectedIndexChanged
        cmb_SUM11_CD.SyncTo("sum11_nm", txt_SUM11_NM)
    End Sub
    Private Sub cmb_SUM12_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM12_CD.SelectedIndexChanged
        cmb_SUM12_CD.SyncTo("sum12_nm", txt_SUM12_NM)
    End Sub
    Private Sub cmb_SUM13_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM13_CD.SelectedIndexChanged
        cmb_SUM13_CD.SyncTo("sum13_nm", txt_SUM13_NM)
    End Sub
    Private Sub cmb_SUM14_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM14_CD.SelectedIndexChanged
        cmb_SUM14_CD.SyncTo("sum14_nm", txt_SUM14_NM)
    End Sub
    Private Sub cmb_SUM15_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SUM15_CD.SelectedIndexChanged
        cmb_SUM15_CD.SyncTo("sum15_nm", txt_SUM15_NM)
    End Sub
    Private Sub cmb_PTN_CD1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_PTN_CD1.SelectedIndexChanged
        cmb_PTN_CD1.SyncTo("hrel_ptn_nm1", txt_PTN_NM1)
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 必須項目が未入力
        If txt_SKMK_CD.Text = "" Or txt_SKMK_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim skmk As New Dictionary(Of String, Object)
        skmk("skmk_cd") = txt_SKMK_CD.Text
        skmk("skmk_nm") = txt_SKMK_NM.Text

        skmk("sum1_cd") = cmb_SUM1_CD.SelectedValue
        skmk("sum2_cd") = cmb_SUM2_CD.SelectedValue
        skmk("sum3_cd") = cmb_SUM3_CD.SelectedValue
        skmk("sum4_cd") = cmb_SUM4_CD.SelectedValue
        skmk("sum5_cd") = cmb_SUM5_CD.SelectedValue
        skmk("sum6_cd") = cmb_SUM6_CD.SelectedValue
        skmk("sum7_cd") = cmb_SUM7_CD.SelectedValue
        skmk("sum8_cd") = cmb_SUM8_CD.SelectedValue
        skmk("sum9_cd") = cmb_SUM9_CD.SelectedValue
        skmk("sum10_cd") = cmb_SUM10_CD.SelectedValue
        skmk("sum11_cd") = cmb_SUM11_CD.SelectedValue
        skmk("sum12_cd") = cmb_SUM12_CD.SelectedValue
        skmk("sum13_cd") = cmb_SUM13_CD.SelectedValue
        skmk("sum14_cd") = cmb_SUM14_CD.SelectedValue
        skmk("sum15_cd") = cmb_SUM15_CD.SelectedValue

        skmk("sum1_nm") = txt_SUM1_NM.Text
        skmk("sum2_nm") = txt_SUM2_NM.Text
        skmk("sum3_nm") = txt_SUM3_NM.Text
        skmk("sum4_nm") = txt_SUM4_NM.Text
        skmk("sum5_nm") = txt_SUM5_NM.Text
        skmk("sum6_nm") = txt_SUM6_NM.Text
        skmk("sum7_nm") = txt_SUM7_NM.Text
        skmk("sum8_nm") = txt_SUM8_NM.Text
        skmk("sum9_nm") = txt_SUM9_NM.Text
        skmk("sum10_nm") = txt_SUM10_NM.Text
        skmk("sum11_nm") = txt_SUM11_NM.Text
        skmk("sum12_nm") = txt_SUM12_NM.Text
        skmk("sum13_nm") = txt_SUM13_NM.Text
        skmk("sum14_nm") = txt_SUM14_NM.Text
        skmk("sum15_nm") = txt_SUM15_NM.Text

        skmk("hrel_ptn_cd1") = cmb_PTN_CD1.SelectedValue
        skmk("hrel_ptn_nm1") = txt_PTN_NM1.Text

        skmk("biko") = txt_BIKO.Text
        skmk("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_skmk WHERE skmk_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_SKMK_ID.Text))})
        skmk("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@id", Integer.Parse(txt_SKMK_ID.Text)))

        ' 行を更新
        _crud.Update("m_skmk", skmk, "skmk_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_SKMK_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@id", Integer.Parse(txt_SKMK_ID.Text)))

        ' 行を削除
        _crud.Delete("m_skmk", "skmk_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class