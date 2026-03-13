Imports System.Data
Imports Npgsql
Imports LeaseM4BS.DataAccess ' DataAccessプロジェクトの機能を使う

Partial Public Class Form1

    ' ---------------------------------------------------------
    ' ボタン1: 接続テスト
    ' ---------------------------------------------------------
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim connMgr As New DbConnectionManager()
        Dim errMsg As String = String.Empty

        ' DbConnectionManagerのTestConnectionメソッドを呼び出す
        If connMgr.TestConnection(errMsg) Then
            MessageBox.Show("接続成功！", "テスト結果", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show($"接続失敗..." & vbCrLf & errMsg, "テスト結果", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ---------------------------------------------------------
    ' ボタン2: データ取得（テーブル数のカウント）
    ' ---------------------------------------------------------
    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        Dim connMgr As New DbConnectionManager()
        Dim dt As New DataTable()

        Try
            Using conn As NpgsqlConnection = connMgr.GetConnection()
                ' 全テーブル数をカウントするSQL
                Dim sql As String = "SELECT count(*) as table_count FROM information_schema.tables WHERE table_schema = 'public'"

                ' 実行して結果を取得
                Using cmd As New NpgsqlCommand(sql, conn)
                    Dim count As Object = cmd.ExecuteScalar()
                    MessageBox.Show($"データベース内のテーブル数: {count}", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                ' ついでにテーブル一覧をグリッドに表示してみる
                Dim sqlList As String = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'public' ORDER BY table_name"
                Using adapter As New NpgsqlDataAdapter(sqlList, conn)
                    adapter.Fill(dt)
                End Using
            End Using

            ' DataGridViewに表示
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("エラー: " & ex.Message)
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' ボタン3: クエリ実行（テキストボックスの内容を実行）
    ' ---------------------------------------------------------
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ' テキストボックスが空なら何もしない
        If String.IsNullOrWhiteSpace(txtQuery.Text) Then
            MessageBox.Show("SQLを入力してください")
            Return
        End If

        Dim connMgr As New DbConnectionManager()
        Dim dt As New DataTable()

        Try
            Using conn As NpgsqlConnection = connMgr.GetConnection()
                ' テキストボックスのSQLを実行
                Using adapter As New NpgsqlDataAdapter(txtQuery.Text, conn)
                    adapter.Fill(dt)
                End Using
            End Using

            ' 結果をグリッドに表示
            DataGridView1.DataSource = dt
            MessageBox.Show("実行完了", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("SQLエラー: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' ボタン4: _crudテスト実行
    ' ---------------------------------------------------------
    Private Sub btnCrudTest_Click(sender As Object, e As EventArgs) Handles btnCrudTest.Click
        txtResults.Clear()
        Dim results As New System.Text.StringBuilder()
        results.AppendLine("=== _crudテスト開始 ===")
        results.AppendLine()

        Try
            Using helper As New crudHelper()
                Dim testUserId As Integer = 99999
                Dim testUserName As String = "テストユーザー"
                Dim updatedUserName As String = "更新後ユーザー"

                results.AppendLine("【ステップ1】INSERT - テストレコードを挿入")
                Dim insertValues As New Dictionary(Of String, Object) From {
                    {"user_id", testUserId},
                    {"user_name", testUserName},
                    {"user_kana", "テストユーザー"},
                    {"create_date", DateTime.Now},
                    {"update_date", DateTime.Now}
                }

                Dim insertedRows As Integer = helper.Insert("tw_m_user", insertValues)
                results.AppendLine($"  → {insertedRows} 件挿入されました")
                results.AppendLine()

                results.AppendLine("【ステップ2】SELECT - 挿入したレコードを確認")
                Dim selectParams As New List(Of NpgsqlParameter) From {
                    New NpgsqlParameter("@userId", testUserId)
                }
                Dim dt As DataTable = helper.GetDataTable("SELECT user_id, user_name, user_kana FROM tw_m_user WHERE user_id = @userId", selectParams)

                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    results.AppendLine($"  → user_id: {row("user_id")}")
                    results.AppendLine($"  → user_name: {row("user_name")}")
                    results.AppendLine($"  → user_kana: {row("user_kana")}")
                Else
                    results.AppendLine("  → レコードが見つかりませんでした")
                End If
                results.AppendLine()

                results.AppendLine("【ステップ3】UPDATE - レコードを更新")
                Dim updateValues As New Dictionary(Of String, Object) From {
                    {"user_name", updatedUserName},
                    {"update_date", DateTime.Now}
                }
                Dim whereParams As New List(Of NpgsqlParameter) From {
                    New NpgsqlParameter("@userId", testUserId)
                }
                Dim updatedRows As Integer = helper.Update("tw_m_user", updateValues, "user_id = @userId", whereParams)
                results.AppendLine($"  → {updatedRows} 件更新されました")
                results.AppendLine()

                results.AppendLine("【ステップ4】SELECT - 更新後のレコードを確認")
                dt = helper.GetDataTable("SELECT user_id, user_name, user_kana FROM tw_m_user WHERE user_id = @userId", selectParams)

                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = dt.Rows(0)
                    results.AppendLine($"  → user_id: {row("user_id")}")
                    results.AppendLine($"  → user_name: {row("user_name")}")
                    results.AppendLine($"  → user_kana: {row("user_kana")}")
                Else
                    results.AppendLine("  → レコードが見つかりませんでした")
                End If
                results.AppendLine()

                results.AppendLine("【ステップ5】DELETE - レコードを削除")
                Dim deletedRows As Integer = helper.Delete("tw_m_user", "user_id = @userId", whereParams)
                results.AppendLine($"  → {deletedRows} 件削除されました")
                results.AppendLine()

                results.AppendLine("【ステップ6】SELECT - 削除後の確認")
                dt = helper.GetDataTable("SELECT user_id, user_name FROM tw_m_user WHERE user_id = @userId", selectParams)
                results.AppendLine($"  → 検索結果: {dt.Rows.Count} 件")
                results.AppendLine()

                results.AppendLine("=== _crudテスト完了 ===")
                results.AppendLine("すべてのステップが正常に実行されました。")

            End Using

        Catch ex As Exception
            results.AppendLine()
            results.AppendLine("=== エラー発生 ===")
            results.AppendLine($"エラー: {ex.Message}")
            results.AppendLine($"スタックトレース: {ex.StackTrace}")
        End Try

        txtResults.Text = results.ToString()
    End Sub

    ' ---------------------------------------------------------
    ' ボタン5: トランザクションテスト
    ' ---------------------------------------------------------
    Private Sub btnTransactionTest_Click(sender As Object, e As EventArgs) Handles btnTransactionTest.Click
        txtResults.Clear()
        Dim results As New System.Text.StringBuilder()
        results.AppendLine("=== トランザクションテスト開始 ===")
        results.AppendLine()

        Try
            Using helper As New crudHelper()
                Dim testUserId1 As Integer = 88888
                Dim testUserId2 As Integer = 88889

                results.AppendLine("【準備】既存のテストデータを削除")
                Try
                    helper.Delete("tw_m_user", "user_id IN (88888, 88889)", Nothing)
                    results.AppendLine("  → クリーンアップ完了")
                Catch
                    results.AppendLine("  → クリーンアップ不要（データなし）")
                End Try
                results.AppendLine()

                results.AppendLine("【テスト1】トランザクション開始")
                helper.BeginTransaction()
                results.AppendLine("  → トランザクション開始しました")
                results.AppendLine($"  → IsInTransaction: {helper.IsInTransaction}")
                results.AppendLine()

                results.AppendLine("【テスト2】1件目のINSERT")
                Dim insertValues1 As New Dictionary(Of String, Object) From {
                    {"user_id", testUserId1},
                    {"user_name", "トランザクションテスト1"},
                    {"user_kana", "トランザクションテスト1"},
                    {"create_date", DateTime.Now},
                    {"update_date", DateTime.Now}
                }
                helper.Insert("tw_m_user", insertValues1)
                results.AppendLine("  → 1件目を挿入しました")
                results.AppendLine()

                results.AppendLine("【テスト3】2件目のINSERT")
                Dim insertValues2 As New Dictionary(Of String, Object) From {
                    {"user_id", testUserId2},
                    {"user_name", "トランザクションテスト2"},
                    {"user_kana", "トランザクションテスト2"},
                    {"create_date", DateTime.Now},
                    {"update_date", DateTime.Now}
                }
                helper.Insert("tw_m_user", insertValues2)
                results.AppendLine("  → 2件目を挿入しました")
                results.AppendLine()

                results.AppendLine("【テスト4】意図的にエラーを発生させる")
                results.AppendLine("  → 同じuser_idで再度INSERTを試みます（主キー制約違反）")
                Try
                    helper.Insert("tw_m_user", insertValues1)
                    results.AppendLine("  → エラーが発生しませんでした（予期しない動作）")
                Catch ex As Exception
                    results.AppendLine($"  → 期待通りエラーが発生: {ex.Message}")
                End Try
                results.AppendLine()

                results.AppendLine("【テスト5】ロールバック実行")
                helper.Rollback()
                results.AppendLine("  → ロールバックしました")
                results.AppendLine($"  → IsInTransaction: {helper.IsInTransaction}")
                results.AppendLine()

                results.AppendLine("【テスト6】ロールバック後の確認")
                Dim selectParams As New List(Of NpgsqlParameter) From {
                    New NpgsqlParameter("@userId1", testUserId1),
                    New NpgsqlParameter("@userId2", testUserId2)
                }
                Dim dt As DataTable = helper.GetDataTable("SELECT user_id, user_name FROM tw_m_user WHERE user_id IN (@userId1, @userId2)", selectParams)
                results.AppendLine($"  → 検索結果: {dt.Rows.Count} 件")

                If dt.Rows.Count = 0 Then
                    results.AppendLine("  → ロールバックが正常に機能しました！")
                    results.AppendLine("  → トランザクション内の全ての変更が取り消されました。")
                Else
                    results.AppendLine("  → 警告: データが残っています（ロールバック失敗の可能性）")
                    For Each row As DataRow In dt.Rows
                        results.AppendLine($"     - user_id: {row("user_id")}, user_name: {row("user_name")}")
                    Next
                End If
                results.AppendLine()

                results.AppendLine("=== トランザクションテスト完了 ===")
                results.AppendLine("トランザクション制御が正常に動作しています。")

            End Using

        Catch ex As Exception
            results.AppendLine()
            results.AppendLine("=== エラー発生 ===")
            results.AppendLine($"エラー: {ex.Message}")
            results.AppendLine($"スタックトレース: {ex.StackTrace}")
        End Try

        txtResults.Text = results.ToString()
    End Sub
End Class
