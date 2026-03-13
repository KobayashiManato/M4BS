Public Class Form_f_ZENKAI_LOG
    Private Sub Form_f_SAI_LEASE_LOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 列インデックスを定義
        Dim blueCols = {0, 1, 2, 3, 4}

        ' 青色の設定
        For Each idx In blueCols
            With dgv_LIST.Columns(idx).HeaderCell.Style
                .BackColor = Color.Blue
                .ForeColor = Color.White
            End With
        Next
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub
End Class