Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_MCPT_INP
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
        If txt_MCPT_CD.Text = "" Or txt_MCPT_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim _crud As crudHelper = New crudHelper()

        Dim mcpt As New Dictionary(Of String, Object)
        ' 最大ID + 1
        mcpt("mcpt_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(mcpt_id), 0) + 1 FROM m_mcpt")
        mcpt("mcpt_cd") = txt_MCPT_CD.Text
        mcpt("mcpt_nm") = txt_MCPT_NM.Text

        mcpt("biko") = txt_BIKO.Text
        mcpt("create_id") = 0
        mcpt("create_dt") = DateTime.Now
        mcpt("update_id") = 0
        mcpt("update_dt") = DateTime.Now
        mcpt("update_cnt") = 0
        mcpt("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_mcpt", mcpt)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class