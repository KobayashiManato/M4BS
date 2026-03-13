Module UtilControl
    Public Sub HandleEnterKeyNavigation(frm As Form, e As KeyEventArgs)
        Dim ctrl = frm.ActiveControl
        If ctrl Is Nothing Then Return

        ' --- DGV上にいるときは遷移させない ---
        If TypeOf ctrl Is DataGridView OrElse TypeOf ctrl.Parent Is DataGridView Then
            Return
        End If

        ' --- CtrlやShiftが押されているときは遷移させない ---
        If e.Control OrElse e.Shift Then Return

        Select Case e.KeyCode
            Case Keys.Enter
                ' Enterは常に移動
                If frm.SelectNextControl(ctrl, True, True, True, True) Then
                    e.SuppressKeyPress = True
                End If

            Case Keys.Right, Keys.Down
                ' テキストボックスにいる時は矢印移動を無効化（カーソル移動を優先）
                If TypeOf ctrl Is TextBox Then Return

                If frm.SelectNextControl(ctrl, True, True, True, True) Then
                    e.SuppressKeyPress = True
                End If

            Case Keys.Left, Keys.Up
                ' テキストボックスにいる時は矢印移動を無効化
                If TypeOf ctrl Is TextBox Then Return

                ' 逆戻り
                If frm.SelectNextControl(ctrl, False, True, True, True) Then
                    e.SuppressKeyPress = True
                End If
        End Select
    End Sub

    ' Dateの順番を正しくする
    Public Sub SwapIf(dtFrom As DateTimePicker, dtTo As DateTimePicker)
        If dtFrom.Value > dtTo.Value Then
            ' 入れ替え
            Dim tmp = dtFrom.Value
            dtFrom.Value = dtTo.Value
            dtTo.Value = tmp
        End If
    End Sub

    ' Noの順番を正しくする
    Public Sub SwapIf(noFrom As TextBox, noTo As TextBox)
        Dim _valFrom As Integer
        Dim _valTo As Integer

        If Integer.TryParse(noFrom.Text, _valFrom) AndAlso Integer.TryParse(noTo.Text, _valTo) Then
            If _valFrom > _valTo Then
                ' 入れ替え
                noFrom.Text = _valTo.ToString()
                noTo.Text = _valFrom.ToString()
            End If
        End If
    End Sub
End Module
