Imports System.Data
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_LOGIN_JET
    Inherits Form

    ''' <summary>
    ''' ログイン成功フラグ（呼び出し元で参照）
    ''' </summary>
    Public Property LoginSuccess As Boolean = False

    ''' <summary>
    ''' ログインしたユーザーコード
    ''' </summary>
    Public Property LoggedInUserCd As String = ""

    ''' <summary>
    ''' ログインしたユーザー名
    ''' </summary>
    Public Property LoggedInUserNm As String = ""

    ''' <summary>
    ''' ログインしたユーザーID
    ''' </summary>
    Public Property LoggedInUserId As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_LOGIN_JET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' パスワードフィールドをマスク
        txt_PWD.PasswordChar = "*"c
        txt_PWD.MaxLength = 255

        ' ユーザーコード保存値があれば復元（txt_USER_CD_SAVEに保持）
        txt_USER_CD_SAVE.Visible = False
        If Not String.IsNullOrEmpty(txt_USER_CD_SAVE.Text) Then
            txt_USER_CD.Text = txt_USER_CD_SAVE.Text
            txt_PWD.Focus()
        Else
            txt_USER_CD.Focus()
        End If

        ' データファイルパス（PostgreSQL接続のため表示用のみ）
        txt_PATH.Text = "(PostgreSQL)"
        txt_PATH.ReadOnly = True
        txt_PATH.Enabled = False

        ' キャンセルボタンにESCキーを割り当て
        Me.CancelButton = cmd_Cancel
        Me.AcceptButton = cmd_Jikko
    End Sub

    ''' <summary>
    ''' 実行ボタンクリック - ログイン認証
    ''' </summary>
    Private Sub cmd_Jikko_Click(sender As Object, e As EventArgs) Handles cmd_Jikko.Click
        ' 入力チェック
        Dim userCd As String = txt_USER_CD.Text.Trim()
        Dim pwd As String = txt_PWD.Text

        If String.IsNullOrEmpty(userCd) Then
            MessageBox.Show("利用者コードを入力してください。", "入力エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_USER_CD.Focus()
            Return
        End If

        If String.IsNullOrEmpty(pwd) Then
            MessageBox.Show("パスワードを入力してください。", "入力エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_PWD.Focus()
            Return
        End If

        ' データベース認証
        Try
            Using db As New CrudHelper()
                ' ユーザー検索
                Dim sql As String = "SELECT user_id, user_cd, user_nm, pwd, err_ct, login_attempts, d_first_login FROM sec_user WHERE user_cd = @user_cd AND history_f = FALSE"
                Dim params As New List(Of NpgsqlParameter) From {
                    New NpgsqlParameter("@user_cd", userCd)
                }

                Dim dt As DataTable = db.GetDataTable(sql, params)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("利用者コードが見つかりません。", "認証エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_USER_CD.Focus()
                    Return
                End If

                Dim row As DataRow = dt.Rows(0)
                Dim storedPwd As String = db.SafeConvert(Of String)(row("pwd"), "")
                Dim errCt As Short = db.SafeConvert(Of Short)(row("err_ct"), 0)
                Dim loginAttempts As Short = db.SafeConvert(Of Short)(row("login_attempts"), 5)
                Dim userId As Integer = db.SafeConvert(Of Integer)(row("user_id"), 0)
                Dim userNm As String = db.SafeConvert(Of String)(row("user_nm"), "")

                ' ログイン試行回数チェック
                If loginAttempts > 0 AndAlso errCt >= loginAttempts Then
                    MessageBox.Show("ログイン試行回数の上限に達しました。" & vbCrLf &
                                    "管理者にお問い合わせください。", "認証エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' パスワード照合（最小限実装: 平文比較）
                ' TODO: Access版のpc_Encryptに相当する暗号化処理を実装後、ハッシュ比較に変更
                If storedPwd <> pwd Then
                    ' エラーカウントを更新
                    Dim updateParams As New List(Of NpgsqlParameter) From {
                        New NpgsqlParameter("@wh_user_id", userId)
                    }
                    db.Update("sec_user",
                              New Dictionary(Of String, Object) From {
                                  {"err_ct", CObj(CShort(errCt + 1))},
                                  {"last_err_dt", CObj(DateTime.Now)}
                              },
                              "user_id = @wh_user_id", updateParams)

                    Dim remaining As Integer = If(loginAttempts > 0, CInt(loginAttempts) - CInt(errCt) - 1, -1)
                    Dim msg As String = "パスワードが正しくありません。"
                    If remaining >= 0 Then
                        msg &= vbCrLf & $"残り試行回数: {remaining}"
                    End If
                    MessageBox.Show(msg, "認証エラー",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_PWD.Text = ""
                    txt_PWD.Focus()
                    Return
                End If

                ' ログイン成功: エラーカウントリセット＆初回ログイン日時記録
                Dim successValues As New Dictionary(Of String, Object) From {
                    {"err_ct", CObj(CShort(0))},
                    {"last_err_dt", DBNull.Value}
                }

                ' 初回ログインの場合、日時を記録
                Dim firstLogin As Object = row("d_first_login")
                If firstLogin Is Nothing OrElse IsDBNull(firstLogin) Then
                    successValues.Add("d_first_login", CObj(DateTime.Now))
                End If

                Dim successParams As New List(Of NpgsqlParameter) From {
                    New NpgsqlParameter("@wh_user_id", userId)
                }
                db.Update("sec_user", successValues, "user_id = @wh_user_id", successParams)

                ' ログイン情報を保持
                LoggedInUserId = userId
                LoggedInUserCd = userCd
                LoggedInUserNm = userNm
                LoginSuccess = True

                ' ユーザーコードを保存（次回起動時の復元用）
                txt_USER_CD_SAVE.Text = userCd

                Me.DialogResult = DialogResult.OK
                Me.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("データベース接続エラー:" & vbCrLf & ex.Message, "エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' キャンセルボタンクリック
    ''' </summary>
    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        LoginSuccess = False
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' フォームを閉じるとき
    ''' </summary>
    Private Sub Form_f_LOGIN_JET_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.DialogResult <> DialogResult.OK Then
            LoginSuccess = False
        End If
    End Sub
End Class
