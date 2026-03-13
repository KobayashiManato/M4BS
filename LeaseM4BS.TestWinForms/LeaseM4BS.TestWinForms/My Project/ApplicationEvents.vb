Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    Partial Friend Class MyApplication

        ''' <summary>
        ''' アプリ起動時にログインフォームを表示する。
        ''' 認証成功(DialogResult.OK)ならメインメニューへ進む。
        ''' それ以外はアプリを終了する。
        ''' </summary>
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim loginForm As New Form_f_LOGIN_JET()
            Dim result = loginForm.ShowDialog()

            If result <> System.Windows.Forms.DialogResult.OK Then
                ' ログインキャンセル → アプリ終了
                e.Cancel = True
            End If
        End Sub

    End Class

End Namespace
