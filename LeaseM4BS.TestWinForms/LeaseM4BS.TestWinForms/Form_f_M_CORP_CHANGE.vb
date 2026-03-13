Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_CORP_CHANGE
    Public Property CorpId As Double = 0
    Private _crud As New crudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_CORP_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM m_corp WHERE corp_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", CorpId)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return
            Dim row As DataRow = dt.Rows(0)

            txt_CORP1_CD.SetText(row("corp1_cd"))
            txt_CORP1_NM.SetText(row("corp1_nm"))
            cmb_CORP2_CD.SelectedValue = row("corp2_cd").ToString()
            txt_CORP2_NM.SetText(row("corp2_nm"))
            cmb_CORP3_CD.SelectedValue = row("corp3_cd").ToString()
            txt_CORP3_NM.SetText(row("corp3_nm"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_CORP_ID.SetText(row("corp_id"))

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
        If txt_CORP1_CD.Text = "" Or txt_CORP1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim corp As New Dictionary(Of String, Object)
        corp("corp1_cd") = txt_CORP1_CD.Text
        corp("corp1_nm") = txt_CORP1_NM.Text
        corp("corp2_cd") = cmb_CORP2_CD.SelectedValue
        corp("corp2_nm") = txt_CORP2_NM.Text
        corp("corp3_cd") = cmb_CORP3_CD.SelectedValue
        corp("corp3_nm") = txt_CORP3_NM.Text
        corp("update_dt") = DateTime.Now
        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_corp WHERE corp_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_CORP_ID.Text))})
        corp("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_CORP_ID.Text))}
        }

        _crud.Update("m_corp", corp, "corp_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_CORP_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_CORP_ID.Text))}
        }

        _crud.Delete("m_corp", "corp_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class