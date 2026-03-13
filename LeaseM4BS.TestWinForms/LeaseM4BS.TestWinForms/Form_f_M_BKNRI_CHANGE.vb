Imports Npgsql

Partial Public Class Form_f_M_BKNRI_CHANGE
    Inherits Form_BKNRI

    Public Property BknriId As Double = 0

    Private Sub Form_f_M_BKNRI_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBknriCombos(cmb_BKNRI2_CD, cmb_BKNRI3_CD)

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql = "SELECT * FROM m_bknri WHERE bknri_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", BknriId)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_BKNRI1_CD.SetText(row("bknri1_cd"))
            txt_BKNRI1_NM.SetText(row("bknri1_nm"))
            cmb_BKNRI2_CD.SelectedValue = row("bknri2_cd").ToString()
            txt_BKNRI2_NM.SetText(row("bknri2_nm"))
            cmb_BKNRI3_CD.SelectedValue = row("bknri3_cd").ToString()
            txt_BKNRI3_NM.SetText(row("bknri3_nm"))

            txt_BIKO.SetText(row("biko"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_BKNRI_ID.SetText(row("bknri_id"))

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
        If txt_BKNRI1_CD.Text = "" Or txt_BKNRI1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim bknri As New Dictionary(Of String, Object)
        bknri("bknri1_cd") = txt_BKNRI1_CD.Text
        bknri("bknri1_nm") = txt_BKNRI1_NM.Text
        bknri("bknri2_cd") = cmb_BKNRI2_CD.SelectedValue
        bknri("bknri2_nm") = txt_BKNRI2_NM.Text
        bknri("bknri3_cd") = cmb_BKNRI3_CD.SelectedValue
        bknri("bknri3_nm") = txt_BKNRI3_NM.Text

        bknri("biko") = txt_BIKO.Text

        bknri("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_bknri WHERE bknri_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_BKNRI_ID.Text))})
        bknri("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_BKNRI_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_bknri", bknri, "bknri_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_BKNRI_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_BKNRI_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_bknri", "bknri_id = @id", prms)

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