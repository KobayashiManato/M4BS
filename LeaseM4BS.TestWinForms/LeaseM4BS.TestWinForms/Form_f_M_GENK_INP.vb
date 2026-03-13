Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_GENK_INP
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
        Dim _crud As CrudHelper = New CrudHelper()

        ' 必須項目が未入力
        If txt_GENK_CD.Text = "" Or txt_GENK_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim genk As New Dictionary(Of String, Object)
        ' 最大ID + 1
        genk("genk_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(genk_id), 0) + 1 FROM m_genk")
        genk("genk_cd") = txt_GENK_CD.Text
        genk("genk_nm") = txt_GENK_NM.Text
        genk("biko") = txt_BIKO.Text
        genk("create_id") = 0
        genk("create_dt") = DateTime.Now
        genk("update_id") = 0
        genk("update_dt") = DateTime.Now
        genk("update_cnt") = 0
        genk("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_genk", genk)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class