Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess

Partial Public Class Form_f_M_BKIND_INP
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_M_BKIND_INP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        Dim _crud As crudHelper = New crudHelper()

        ' 必須項目が未入力
        If txt_BKIND_CD.Text = "" Or txt_BKIND_NM.Text = "" Then
            MessageBox.Show("必須項目が未入力です", "登録不可", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Dim bkind As New Dictionary(Of String, Object)
        ' 最大ID + 1
        bkind("bkind_id") = _crud.ExecuteScalar(Of Integer)("SELECT COALESCE(MAX(bkind_id), 0) + 1 FROM m_bkind")
        bkind("bkind_cd") = txt_BKIND_CD.Text
        bkind("bkind_nm") = txt_BKIND_NM.Text

        bkind("biko") = txt_BIKO.Text
        bkind("create_id") = 0
        bkind("create_dt") = DateTime.Now
        bkind("update_id") = 0
        bkind("update_dt") = DateTime.Now
        bkind("update_cnt") = 0
        bkind("history_f") = False

        ' 新規行を追加
        _crud.Insert("m_bkind", bkind)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class