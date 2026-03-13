Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_HKHO_INP
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
        ' 必須項目が未入力
        If txt_HKHO_CD.Text = "" Or txt_HKHO_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim _crud As crudHelper = New crudHelper()

        Dim hkho As New Dictionary(Of String, Object)
        ' 最大ID + 1
        hkho("hkho_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(hkho_id), 0) + 1 FROM m_hkho")
        hkho("hkho_cd") = txt_HKHO_CD.Text
        hkho("hkho_nm") = txt_HKHO_NM.Text

        hkho("biko") = txt_BIKO.Text
        hkho("create_id") = 0
        hkho("create_dt") = DateTime.Now
        hkho("update_id") = 0
        hkho("update_dt") = DateTime.Now
        hkho("update_cnt") = 0
        hkho("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_hkho", hkho)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class