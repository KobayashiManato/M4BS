Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_RSRVB1_CHANGE
    Inherits Form

    Public Property Rsrvb1Id As Double = 0
    Private _crud As crudHelper = New crudHelper()

    Private Sub Form_f_M_RSRVB1_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM m_rsrvb1 WHERE rsrvb1_id = @id"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", Rsrvb1Id)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            ' 画面項目に値をセット
            txt_RSRVB1_CD.SetText(row("rsrvb1_cd"))
            txt_RSRVB1_NM.SetText(row("rsrvb1_nm"))

            txt_BIKO.SetText(row("biko"))
            txt_CREATE_DT.SetText(row("create_dt"))
            txt_UPDATE_DT.SetText(row("update_dt"))
            txt_RSRVB1_ID.SetText(row("rsrvb1_id"))

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
        If txt_RSRVB1_CD.Text = "" Or txt_RSRVB1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim rsrvb As New Dictionary(Of String, Object)
        rsrvb("rsrvb1_cd") = txt_RSRVB1_CD.Text
        rsrvb("rsrvb1_nm") = txt_RSRVB1_NM.Text

        rsrvb("biko") = txt_BIKO.Text

        rsrvb("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM m_rsrvb1 WHERE rsrvb1_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_RSRVB1_ID.Text))})
        rsrvb("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_RSRVB1_ID.Text))}
        }

        ' 行を更新
        _crud.Update("m_rsrvb1", rsrvb, "rsrvb1_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_RSRVB1_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@id", Integer.Parse(txt_RSRVB1_ID.Text))}
        }

        ' 行を削除
        _crud.Delete("m_rsrvb1", "rsrvb1_id = @id", prms)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class