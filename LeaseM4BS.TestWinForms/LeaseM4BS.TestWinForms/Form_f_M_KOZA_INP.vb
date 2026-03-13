Imports System.Linq.Expressions
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_KOZA_INP
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
        If txt_KOZA_CD.Text = "" Or txt_KOZA_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim _crud As crudHelper = New crudHelper()

        Dim koza As New Dictionary(Of String, Object)
        ' 最大ID + 1
        koza("koza_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(koza_id), 0) + 1 FROM m_koza")
        koza("koza_cd") = txt_KOZA_CD.Text
        koza("koza_nm") = txt_KOZA_NM.Text

        koza("biko") = txt_BIKO.Text
        koza("create_id") = 0
        koza("create_dt") = DateTime.Now
        koza("update_id") = 0
        koza("update_dt") = DateTime.Now
        koza("update_cnt") = 0
        koza("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_koza", koza)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class