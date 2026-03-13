Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_KKNRI_CHANGE
    Inherits Form_KKNRI

    Public Property KknriId As Double = 0

    Private Sub Form_f_M_KKNRI_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKknriCombos(cmb_KKNRI2_CD, cmb_KKNRI3_CD)
        LoadCorpCombo(cmb_CORP1_CD)
        LoadPtnCombo(cmb_PTN_CD4)

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql = "SELECT * FROM m_kknri kknri LEFT JOIN m_corp corp ON kknri.corp_id = corp.corp_id WHERE kknri_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", KknriId)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_KKNRI1_CD.SetText(row("kknri1_cd"))
            txt_KKNRI1_NM.SetText(row("kknri1_nm"))
            txt_KKNRI2_NM.SetText(row("kknri2_nm"))
            txt_KKNRI3_NM.SetText(row("kknri3_nm"))
            cmb_KKNRI2_CD.SelectedValue = row("kknri2_cd").ToString()
            cmb_KKNRI3_CD.SelectedValue = row("kknri3_cd").ToString()
            cmb_CORP1_CD.SelectedValue = row("corp1_cd").ToString()
            txt_CORP1_NM.SetText(row("corp1_nm"))
            cmb_PTN_CD4.SelectedValue = row("hrel_ptn_cd4").ToString()
            txt_PTN_NM4.SetText(row("hrel_ptn_nm4"))
            txt_BIKO.SetText(row("biko"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_KKNRI_ID.SetText(row("kknri_id"))
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
        If txt_KKNRI1_CD.Text = "" Or txt_KKNRI1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim kknri As New Dictionary(Of String, Object)
        kknri("kknri1_cd") = txt_KKNRI1_CD.Text
        kknri("kknri1_nm") = txt_KKNRI1_NM.Text
        kknri("kknri2_cd") = cmb_KKNRI2_CD.SelectedValue
        kknri("kknri2_nm") = txt_KKNRI2_NM.Text
        kknri("kknri3_cd") = cmb_KKNRI3_CD.SelectedValue
        kknri("kknri3_nm") = txt_KKNRI3_NM.Text

        ' corp1_cdに対応したcorp_idを取得する
        If cmb_CORP1_CD.SelectedValue Is Nothing Then
            kknri("corp_id") = 0
        Else
            kknri("corp_id") = _crud.ExecuteScalar(Of Integer)("SELECT corp_id FROM m_corp WHERE corp1_cd = @cd",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@cd", cmb_CORP1_CD.SelectedValue)})
        End If

        kknri("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_kknri WHERE kknri_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_KKNRI_ID.Text))})
        kknri("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_KKNRI_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_kknri", kknri, "kknri_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_KKNRI_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_KKNRI_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_kknri", "kknri_id = @id", prms)

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