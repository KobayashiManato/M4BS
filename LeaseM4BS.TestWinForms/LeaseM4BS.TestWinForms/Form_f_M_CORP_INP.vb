Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_CORP_INP
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
        Dim _crud As New crudHelper()

        ' 必須項目が未入力
        If txt_CORP1_CD.Text = "" Or txt_CORP1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim corp As New Dictionary(Of String, Object)
        ' 最大ID + 1
        corp("corp_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(corp_id), 0) + 1 FROM m_corp")
        corp("corp1_cd") = txt_CORP1_CD.Text
        corp("corp1_nm") = txt_CORP1_NM.Text
        corp("corp2_cd") = cmb_CORP2_CD.SelectedValue
        corp("corp2_nm") = txt_CORP2_NM.Text
        corp("corp3_cd") = cmb_CORP3_CD.SelectedValue
        corp("corp3_nm") = txt_CORP3_NM.Text
        corp("create_id") = 0
        corp("create_dt") = DateTime.Now
        corp("update_id") = 0
        corp("update_dt") = DateTime.Now
        corp("update_cnt") = 0
        corp("history_f") = False

        _crud.Insert("m_corp", corp)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class