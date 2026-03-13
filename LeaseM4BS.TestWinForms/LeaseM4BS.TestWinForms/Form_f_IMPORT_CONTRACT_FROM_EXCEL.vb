Imports System.Windows.Forms

' --- 契約書変更情報Excel取込 ---
Partial Public Class Form_f_IMPORT_CONTRACT_FROM_EXCEL
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_IMPORT_CONTRACT_FROM_EXCEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 列インデックスを定義
        Dim blueCols = {0, 1}
        Dim yellowCols = {4, 6, 8, 9, 10, 15, 17, 19, 21, 23, 25, 27, 28}

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