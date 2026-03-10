Imports System.Drawing.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_M_SHHO_INP
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        Dim _crud As crudHelper = New crudHelper()

        ' 必須項目が未入力
        If txt_SHHO_CD.Text = "" Or txt_SHHO_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim shho As New Dictionary(Of String, Object)
        ' 最大ID + 1
        shho("shho_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(shho_id), 0) + 1 FROM m_shho")
        shho("shho_cd") = txt_SHHO_CD.Text
        shho("shho_nm") = txt_SHHO_NM.Text
        shho("biko") = txt_BIKO.Text
        shho("create_id") = 0
        shho("create_dt") = DateTime.Now
        shho("update_id") = 0
        shho("update_dt") = DateTime.Now
        shho("update_cnt") = 0
        shho("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_shho", shho)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class