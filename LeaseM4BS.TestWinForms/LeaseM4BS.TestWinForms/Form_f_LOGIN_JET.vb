Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_LOGIN_JET
    Inherits Form

    Private ReadOnly _crud As New CrudHelper()

    ' デフォルトのログイン試行上限 (sec_user.login_attempts が NULL の場合)
    Private Const DEFAULT_LOGIN_ATTEMPTS As Integer = 5

    Public Sub New()
        InitializeComponent()
    End Sub

    ' =========================================================
    '  フォーム初期化
    ' =========================================================
    Private Sub Form_f_LOGIN_JET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' パスワードマスク
        txt_PWD.PasswordChar = "*"c
        txt_PWD.MaxLength = 255

        ' ユーザーコード入力欄
        txt_USER_CD.MaxLength = 12

        ' 保存用フィールドは非表示
        txt_USER_CD_SAVE.Visible = False

        ' 前回ログインしたユーザーコードを復元
        If txt_USER_CD_SAVE.Text <> "" Then
            txt_USER_CD.Text = txt_USER_CD_SAVE.Text
            txt_PWD.Focus()
        Else
            txt_USER_CD.Focus()
        End If

        ' 接続先パスを表示
        Try
            Dim dbMgr As New DbConnectionManager()
            txt_PATH.Text = dbMgr.GetMaskedConnectionString()
        Catch
            txt_PATH.Text = "(接続情報取得エラー)"
        End Try
        txt_PATH.ReadOnly = True

        ' Enterキーでログイン実行
        Me.AcceptButton = cmd_Jikko
        Me.CancelButton = cmd_Cancel
    End Sub

    ' =========================================================
    '  実行ボタン (認証処理)
    ' =========================================================
    Private Sub cmd_Jikko_Click(sender As Object, e As EventArgs) Handles cmd_Jikko.Click
        ' --- 入力チェック ---
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

        ' --- ユーザー検索 ---
        Dim sql As String = "SELECT user_id, user_cd, user_nm, pwd, kngn_id, " &
                            "err_ct, login_attempts, d_first_login " &
                            "FROM sec_user " &
                            "WHERE user_cd = @user_cd AND history_f = FALSE"
        Dim prms As New List(Of NpgsqlParameter) From {
            New NpgsqlParameter("@user_cd", userCd)
        }

        Dim dt = _crud.GetDataTable(sql, prms)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("利用者コードが見つかりません。", "認証エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_USER_CD.Focus()
            Return
        End If

        Dim row = dt.Rows(0)
        Dim userId As Integer = CInt(row("user_id"))
        Dim userNm As String = If(row("user_nm") IsNot DBNull.Value, row("user_nm").ToString(), "")
        Dim storedPwd As String = If(row("pwd") IsNot DBNull.Value, row("pwd").ToString(), "")
        Dim kngnId As Integer = CInt(row("kngn_id"))
        Dim errCt As Integer = If(row("err_ct") IsNot DBNull.Value, CInt(row("err_ct")), 0)
        Dim loginAttempts As Integer = If(row("login_attempts") IsNot DBNull.Value,
                                          CInt(row("login_attempts")), DEFAULT_LOGIN_ATTEMPTS)

        ' --- アカウントロック判定 ---
        If loginAttempts > 0 AndAlso errCt >= loginAttempts Then
            MessageBox.Show("ログイン試行回数の上限に達しました。" & vbCrLf &
                            "システム管理者に連絡してください。",
                            "アカウントロック",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --- パスワード照合 ---
        ' TODO: Access版のpc_Encryptに相当する暗号化処理を実装後、ハッシュ比較に変更
        If storedPwd <> pwd Then
            ' 失敗: err_ct をインクリメント + last_err_dt を更新
            errCt += 1
            Dim updateSql As String = "UPDATE sec_user SET err_ct = @err_ct, last_err_dt = @now WHERE user_id = @user_id"
            Dim updatePrms As New List(Of NpgsqlParameter) From {
                New NpgsqlParameter("@err_ct", errCt),
                New NpgsqlParameter("@now", DateTime.Now),
                New NpgsqlParameter("@user_id", userId)
            }
            _crud.ExecuteNonQuery(updateSql, updatePrms)

            Dim remaining As Integer = loginAttempts - errCt
            If remaining > 0 Then
                MessageBox.Show("パスワードが正しくありません。" & vbCrLf &
                                $"残り試行回数: {remaining} 回",
                                "認証エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("パスワードが正しくありません。" & vbCrLf &
                                "ログイン試行回数の上限に達しました。" & vbCrLf &
                                "システム管理者に連絡してください。",
                                "アカウントロック",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            txt_PWD.Clear()
            txt_PWD.Focus()
            Return
        End If

        ' --- 認証成功 ---

        ' err_ct リセット + last_err_dt クリア + 初回ログイン記録
        Dim successSql As String
        Dim successPrms As New List(Of NpgsqlParameter)

        Dim isFirstLogin As Boolean = (row("d_first_login") Is DBNull.Value)
        If isFirstLogin Then
            successSql = "UPDATE sec_user SET err_ct = 0, last_err_dt = NULL, d_first_login = @now WHERE user_id = @user_id"
            successPrms.Add(New NpgsqlParameter("@now", DateTime.Now))
        Else
            successSql = "UPDATE sec_user SET err_ct = 0, last_err_dt = NULL WHERE user_id = @user_id"
        End If
        successPrms.Add(New NpgsqlParameter("@user_id", userId))
        _crud.ExecuteNonQuery(successSql, successPrms)

        ' グローバルセッションにユーザー情報をセット
        LoginSession.LoggedInUserId = userId
        LoginSession.LoggedInUserCd = userCd
        LoginSession.LoggedInUserNm = userNm

        ' 権限情報をロード
        LoginSession.LoadPermissions(kngnId)

        ' 次回用にユーザーコードを保存
        txt_USER_CD_SAVE.Text = userCd

        ' ダイアログ結果をOKにしてフォームを閉じる
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' =========================================================
    '  キャンセルボタン
    ' =========================================================
    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
