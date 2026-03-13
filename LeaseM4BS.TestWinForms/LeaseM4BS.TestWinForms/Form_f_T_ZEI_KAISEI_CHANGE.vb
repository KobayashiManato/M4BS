Imports System.Data.Common
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_T_ZEI_KAISEI_CHANGE
    Inherits Form

    Public Property ZeiKaiseiId As Double = 0
    Private _crud As crudHelper = New crudHelper()

    Private Sub Form_f_T_ZEI_KAISEI_CHANGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sqlHead As String = "SELECT * FROM t_zei_kaisei WHERE zei_kaisei_id = @id"

            Dim prmHead As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", ZeiKaiseiId)
            }

            Dim dtHead As DataTable = _crud.GetDataTable(sqlHead, prmHead)

            If dtHead.Rows.Count > 0 Then
                Dim row As DataRow = dtHead.Rows(0)

                ' 画面項目に値をセット
                TEKI_DT_FROM.Value = row("teki_dt_from")
                TEKI_DT_TO.Value = row("teki_dt_to")
                txt_ZRITU.Text = row("zritu").ToString()
                KKYAK_DT_FROM.Value = row("kkyak_dt_from")
                KKYAK_DT_TO.Value = row("kkyak_dt_to")

                txt_CREATE_DT.Text = row("create_dt").ToString()
                txt_UPDATE_DT.Text = row("update_dt").ToString()
                txt_ZEI_KAISEI_ID.Text = row("zei_kaisei_id").ToString()
            End If
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
        If TEKI_DT_FROM.Text = "" Or TEKI_DT_TO.Text = "" Or txt_ZRITU.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim zei_kaisei As New Dictionary(Of String, Object)
        zei_kaisei("teki_dt_from") = TEKI_DT_FROM.Value
        zei_kaisei("teki_dt_to") = TEKI_DT_TO.Value
        zei_kaisei("zritu") = Double.Parse(txt_ZRITU.Text)
        zei_kaisei("kkyak_dt_from") = KKYAK_DT_FROM.Value
        zei_kaisei("kkyak_dt_to") = KKYAK_DT_TO.Value

        zei_kaisei("update_dt") = DateTime.Now

        Dim currentCnt As Integer = _crud.ExecuteScalar(Of Integer)("SELECT update_cnt FROM t_zei_kaisei WHERE zei_kaisei_id = @id",
                                    New List(Of NpgsqlParameter) From {New NpgsqlParameter("@id", CInt(txt_ZEI_KAISEI_ID.Text))})
        zei_kaisei("update_cnt") = currentCnt + 1

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@id", Integer.Parse(txt_ZEI_KAISEI_ID.Text)))

        ' 行を更新
        _crud.Update("t_zei_kaisei", zei_kaisei, "zei_kaisei_id = @id", prms)

        Me.Close()
    End Sub

    ' [削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If String.IsNullOrWhiteSpace(txt_ZEI_KAISEI_ID.Text) Then
            MessageBox.Show("削除対象が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' パラメータ設定
        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@id", Integer.Parse(txt_ZEI_KAISEI_ID.Text)))

        ' 行を削除
        _crud.Delete("t_zei_kaisei", "zei_kaisei_id = @id", prms)

        Me.Close()
    End Sub
End Class