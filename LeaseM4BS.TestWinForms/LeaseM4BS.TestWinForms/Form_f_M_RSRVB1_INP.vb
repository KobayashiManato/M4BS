Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_RSRVB1_INP
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
        If txt_RSRVB1_CD.Text = "" Or txt_RSRVB1_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim _crud As CrudHelper = New CrudHelper()

        Dim rsrvb1 As New Dictionary(Of String, Object)
        ' 最大ID + 1
        rsrvb1("rsrvb1_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(rsrvb1_id), 0) + 1 FROM m_rsrvb1")
        rsrvb1("rsrvb1_cd") = txt_RSRVB1_CD.Text
        rsrvb1("rsrvb1_nm") = txt_RSRVB1_NM.Text

        rsrvb1("biko") = txt_BIKO.Text
        rsrvb1("create_id") = 0
        rsrvb1("create_dt") = DateTime.Now
        rsrvb1("update_id") = 0
        rsrvb1("update_dt") = DateTime.Now
        rsrvb1("update_cnt") = 0
        rsrvb1("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_rsrvb1", rsrvb1)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class