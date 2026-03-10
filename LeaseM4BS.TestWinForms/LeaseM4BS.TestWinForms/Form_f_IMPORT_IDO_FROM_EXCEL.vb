' --- 物件移動情報取り込み ---
Partial Public Class Form_f_IMPORT_IDO_FROM_EXCEL
    Private Sub Form_f_IMPORT_IDO_FROM_EXCEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 列インデックスを定義
        Dim blueCols = {1, 2, 3, 4}
        Dim yellowCols = {6, 7, 8, 9, 10, 11, 12, 20, 21, 22, 24, 26, 28, 30, 32, 34, 35, 36, 37, 38, 40, 42, 43, 48, 50, 52}

        ' 青色の設定
        For Each idx In blueCols
            With dgv_LIST.Columns(idx).HeaderCell.Style
                .BackColor = Color.Blue
                .ForeColor = Color.White
            End With
        Next

        ' 黄色の設定
        For Each idx In yellowCols
            dgv_LIST.Columns(idx).HeaderCell.Style.BackColor = Color.Yellow
        Next
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' [Excelをワークテーブルに取り込む]ボタン
    Private Sub cmd_INPUT_Click(sender As Object, e As EventArgs) Handles cmd_INPUT.Click
        Dim fileHelper As New FileHelper()

        'todo ファイル入力
    End Sub
End Class