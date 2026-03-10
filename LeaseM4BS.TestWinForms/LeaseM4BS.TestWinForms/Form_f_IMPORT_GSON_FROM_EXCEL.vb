Imports System.Windows.Forms

' --- 減損損失の取り込み ---
Partial Public Class Form_f_IMPORT_GSON_FROM_EXCEL
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_IMPORT_GSON_FROM_EXCEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 列インデックスを定義
        Dim blueCols = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26}

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

    ' [Excelをワークテーブルに取り込む]ボタン
    Private Sub cmd_INPUT_Click(sender As Object, e As EventArgs) Handles cmd_INPUT.Click
        Dim fileHelper As New FileHelper()

        'todo ファイル入力
    End Sub

    ' [前回本登録ログ]ボタン
    Private Sub cmd_ZENKAI_Click(sender As Object, e As EventArgs) Handles cmd_ZENKAI.Click
        Dim frm As New Form_f_ZENKAI_LOG

        frm.ShowDialog()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class