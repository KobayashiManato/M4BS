Imports System.Text
Imports LeaseM4BS.DataAccess
Imports Npgsql.Replication.PgOutput.Messages

' --- 注記判定再計算 ---
Partial Public Class Form_f_CHUKI_RECALC
    Inherits Form

    Private _crud As New CrudHelper()

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        If MessageBox.Show("実行してもよろしいですか？", "実行確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ResetChukiData()
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' todo 危険(実装不明、要確認)
    Private Sub ResetChukiData()
        Dim sb As New StringBuilder()

        _crud.BeginTransaction()

        Try
            Dim rsokTmg = _crud.ExecuteScalar(Of Integer)("SELECT val_number FROM t_settei WHERE settei_id = 1;")
            Dim gkCalcKind = _crud.ExecuteScalar(Of Integer)("SELECT val_number FROM t_settei WHERE settei_id = 3;")
            Dim hensaiKind = _crud.ExecuteScalar(Of Integer)("SELECT val_number FROM t_settei WHERE settei_id = 4;")
            Dim kariRitu = "(SELECT kari_ritu FROM t_kari_ritu sub WHERE sub.start_dt <= kykh.start_dt ORDER BY sub.start_dt DESC LIMIT 1)"

            ' Dim gnzaiKt = ""
            Dim syutok = "(LEAST(kykm.b_knyukn, kykm.b_gnzai_kt)) "
            ' Dim ksanRitu = ""

            Dim taiyoNen = "(kykh.lkikan / 12)"

            Dim rslt90p = "(kykm.b_gnzai_kt / NULLIF(kykm.b_knyukn, 0.0) * 100.0) "
            Dim rslt75p = "(kykh.lkikan / (NULLIF(kykm.taiyo_nen, 0.0) * 12) * 100.0) "
            ' Dim chuHntiId = ""

            Dim leakbnId = _crud.ExecuteScalar(Of Integer)("SELECT val_number FROM t_settei WHERE settei_id = 17;")
            ' Dim chuumId = ""
            ' Dim kjkbnId = ""
            Dim tekiyoDt = _crud.ExecuteScalar(Of DateTime)("SELECT val_datetime FROM t_settei WHERE settei_id = 10;")
            Dim kjHo = _crud.ExecuteScalar(Of Integer)("SELECT val_number FROM t_settei WHERE settei_id = 16;")
            ' Dim szeiKjkbnId = ""

            ExecuteUpdateKykm(chk_1, "rsok_tmg", rsokTmg, radio_DYNAMIC_1)
            ExecuteUpdateKykm(chk_2, "gk_calc_kind", gkCalcKind, radio_DYNAMIC_2)
            ExecuteUpdateKykm(chk_3, "hensai_kind", hensaiKind, radio_DYNAMIC_3)
            ExecuteUpdateKykm(chk_4, "kari_ritu", kariRitu, radio_DYNAMIC_4)

            ' ExecuteUpdateKykm(chk_5, "b_gnzai_kt", gnzaiKt)
            ExecuteUpdateKykm(chk_5, "b_syutok", syutok)
            ' ExecuteUpdateKykm(chk_5, "ksan_ritu", ksanRitu)

            ExecuteUpdateKykm(chk_6, "taiyo_nen", taiyoNen, radio_DYNAMIC_6)

            ExecuteUpdateKykm(chk_7, "rslt90p", rslt90p)
            ExecuteUpdateKykm(chk_7, "rslt90p_str", $"(round(({rslt90p})::numeric, 1)::text || '%')")   ' 00.0%形式
            ExecuteUpdateKykm(chk_7, "rslt75p", rslt75p)
            ExecuteUpdateKykm(chk_7, "rslt75p_str", $"(round(({rslt75p})::numeric, 1)::text || '%')")   ' 00.0%形式
            ' ExecuteUpdateKykm(chk_7, "chu_hnti_id", chuHntiId)

            ExecuteUpdateKykm(chk_8, "leakbn_id", leakbnId, radio_DYNAMIC_8)
            ' ExecuteUpdateKykm(chk_9, "chuum_id", chuumId, radio_DYNAMIC_9)
            ' ExecuteUpdateKykm(chk_10, "kjkbn_id", kjkbnId, radio_DYNAMIC_10)
            ExecuteUpdateKykh(chk_11, "kj_tekiyo_dt", tekiyoDt)
            ExecuteUpdateKykm(chk_12, "kj_ho", kjHo)
            ' ExecuteUpdateKykm(chk_13, "szei_kjkbn_id", szeiKjkbnId, radio_DYNAMIC_13)

            _crud.Commit()

            Me.Close()
        Catch ex As Exception
            _crud.Rollback()
            MessageBox.Show("データの更新に失敗しました。", "更新失敗", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.Print(ex.ToString())
        End Try
    End Sub

    Private Sub ExecuteUpdateKykm(chk As CheckBox, updateCol As String, defaultValue As Object, Optional radioDynamic As RadioButton = Nothing)
        If Not chk.Checked Then Return

        defaultValue = FormatSqlValue(defaultValue)

        Dim sql = $"UPDATE d_kykm kykm " &
                  $"SET {updateCol} = {defaultValue} " &
                  $"FROM d_kykh kykh " &
                  $"WHERE kykm.kykh_id = kykh.kykh_id " &
                  $"AND kykh.kkbn_id = 1 AND kykm.saikaisu = 0 "    ' リース原契約

        If radioDynamic IsNot Nothing AndAlso radioDynamic.Checked Then
            ' kjkbn_idだけ例外で_ms_fをつけるだけじゃない
            If updateCol = "kjkbn_id" Then
                sql &= $"AND kykm.kjkbn_ms_f = FALSE "
            Else
                sql &= $"AND kykm.{updateCol}_ms_f = FALSE "
            End If
        End If

        _crud.ExecuteNonQuery(sql)
    End Sub

    Private Sub ExecuteUpdateKykh(chk As CheckBox, updateCol As String, defaultValue As Object, Optional radioDynamic As RadioButton = Nothing)
        If Not chk.Checked Then Return

        defaultValue = FormatSqlValue(defaultValue)

        Dim sql = $"UPDATE d_kykh " &
                  $"SET {updateCol} = {defaultValue} " &
                  $"WHERE kkbn_id = 1 AND saikaisu = 0 "

        If radioDynamic IsNot Nothing AndAlso radioDynamic.Checked Then
            sql &= $"AND {updateCol}_ms_f = FALSE "
        End If

        Debug.Print(sql)

        _crud.ExecuteNonQuery(sql)
    End Sub

    ' オブジェクトをSQLリテラル形式の文字列に変換する
    Private Function FormatSqlValue(val As Object) As String
        If val Is Nothing OrElse IsDBNull(val) Then
            Return "NULL"
        End If

        ' 文字列型の場合
        If TypeOf val Is String Then
            Dim strVal As String = DirectCast(val, String)

            If String.IsNullOrEmpty(strVal) Then Return "NULL"

            ' サブクエリはそのまま返す
            If strVal.StartsWith("(") Then
                Return strVal
            End If

            ' シングルクォーテーションをエスケープして囲む
            Return $"'{strVal.Replace("'", "''")}'"
        End If

        ' 日付型の場合
        If TypeOf val Is DateTime Then
            ' yyyy-MM-dd形式に
            Return $"'{DirectCast(val, DateTime):yyyy-MM-dd}'"
        End If

        ' 数値型の場合
        If IsNumeric(val) Then
            Return val.ToString()
        End If

        ' それ以外（Booleanなど）
        Return $"'{val.ToString().Replace("'", "''")}'"
    End Function
End Class