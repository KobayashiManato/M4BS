Imports Npgsql

Partial Public Class Form_f_M_HKMK_CHANGE
    Inherits Form_HKMK

    Public Property HkmkId As Double = 0

    Private Sub Form_f_M_HKMK_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSumCombos(cmb_SUM1_CD, cmb_SUM2_CD, cmb_SUM3_CD)
        LoadPtnCombos(cmb_PTN_CD3)

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sqlHead As String = "SELECT * FROM m_hkmk WHERE hkmk_id = @id"

            Dim prmHead As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", HkmkId)
            }

            Dim dtHead As DataTable = _crud.GetDataTable(sqlHead, prmHead)

            If dtHead.Rows.Count > 0 Then
                Dim row As DataRow = dtHead.Rows(0)

                ' 画面項目に値をセット
                txt_HKMK_CD.Text = row("hkmk_cd").ToString()
                txt_HKMK_NM.Text = row("hkmk_nm").ToString()
                cmb_SUM1_CD.SelectedValue = row("sum1_cd").ToString()
                txt_SUM1_NM.Text = row("sum1_nm").ToString()
                cmb_SUM2_CD.SelectedValue = row("sum2_cd").ToString()
                txt_SUM2_NM.Text = row("sum2_nm").ToString()
                cmb_SUM3_CD.SelectedValue = row("sum3_cd").ToString()
                txt_SUM3_NM.Text = row("sum3_nm").ToString()

                txt_BIKO.Text = row("biko").ToString()
                txt_CREATE_DT.Text = row("create_dt").ToString()
                txt_UPDATE_DT.Text = row("update_dt").ToString()
                txt_HKMK_ID.Text = row("hkmk_id").ToString()
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
        hkmk("hkmk_cd") = txt_HKMK_CD.Text
        hkmk("hkmk_nm") = txt_HKMK_NM.Text
        hkmk("sum1_cd") = cmb_SUM1_CD.SelectedValue
        hkmk("sum1_nm") = txt_SUM1_NM.Text
        hkmk("sum2_cd") = cmb_SUM2_CD.SelectedValue
        hkmk("sum2_nm") = txt_SUM2_NM.Text
        hkmk("sum3_cd") = cmb_SUM3_CD.SelectedValue
        hkmk("sum3_nm") = txt_SUM3_NM.Text

        hkmk("biko") = txt_BIKO.Text

        hkmk("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_hkmk WHERE hkmk_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_HKMK_ID.Text))})
        hkmk("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@id", Integer.Parse(txt_HKMK_ID.Text)))

        ' 行を更新
        _crud.Update("m_hkmk", hkmk, "hkmk_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_HKMK_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@id", Integer.Parse(txt_HKMK_ID.Text)))

        ' 行を削除
        _crud.Delete("m_hkmk", "hkmk_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class