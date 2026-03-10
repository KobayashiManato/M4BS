' --- 月次支払照合フレックス ---
Partial Public Class Form_f_KEIJO_JOKEN

    Private _prevForm As Form_f_flx_TOUGETSU

    Private Sub Form_f_FlexMonthlyJornalEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' コンボボックスの設定
        Dim sqlSettei As String = "SELECT settei_id, val_short_nm FROM c_settei_idfld WHERE settei_id = 19 AND val_short_nm <> '';"

        cmb_SETTEI.Bind(sqlSettei, "val_short_nm", "settei_id")
    End Sub

    Private Sub DATE_FROM_ValueChanged(sender As Object, e As EventArgs) Handles txt_DATE_FROM.ValueChanged
        txt_DATE_TO.Value = txt_DATE_FROM.Value
    End Sub

    Private Sub DATE_ValueChanged(sender As Object, e As EventArgs) Handles txt_DATE_FROM.ValueChanged, txt_DATE_TO.ValueChanged
        ' 期間計算(ヶ月)
        Dim duration As Integer = GetDuration(txt_DATE_FROM.Value, txt_DATE_TO.Value)

        txt_DURATION.Text = If(duration = 0, "", duration.ToString())
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' todo 機能していない判定
        If txt_DATE_FROM.Text = "" OrElse txt_DATE_TO.Text = "" Then
            MessageBox.Show("必須項目が未入力です。")
            Return
        End If

        ' 集計期間の指定を正しくする
        SwapIf(txt_DATE_FROM, txt_DATE_TO)

        Dim frm As New Form_f_flx_TOUGETSU()
        frm.LabelText = GetLabelText()

        frm.ShowDialog()

        _prevForm = frm
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub

    ' [前回集計結果]ボタン
    Private Sub cmd_ZENKAI_Click(sender As Object, e As EventArgs) Handles cmd_ZENKAI.Click
        If _prevForm IsNot Nothing Then
            _prevForm.ShowDialog()
        End If
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' ラベルテキストを生成
    Private Function GetLabelText()
        Dim labelText As String = "集計期間:  " & txt_DATE_FROM.Text & "～" & txt_DATE_TO.Text & "  "

        ' 明細
        If radio_BUKN.Checked Then
            labelText &= "物件単位  "
        Else
            labelText &= "配賦単位  "
        End If

        If chk_KEIJO.Checked Then
            labelText &= "資産計上データ  "
        End If

        If chk_SHORI.Checked Then
            labelText &= "賃貸借処理データ"
        End If

        Return labelText
    End Function
End Class