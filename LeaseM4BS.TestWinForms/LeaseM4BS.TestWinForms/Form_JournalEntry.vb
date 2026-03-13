Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_JournalEntry
    ' 作成済みのDBヘルパーを利用
    Private _crud As crudHelper

    ' コンボボックス用のデータソース（科目一覧）
    Private _dtAccounts As DataTable

    Private Sub FrmJournalEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _crud = New crudHelper()

            ' 1. グリッドの初期設定（Accessっぽく入力しやすくする）
            dgvJournal.AutoGenerateColumns = False
            dgvJournal.EditMode = DataGridViewEditMode.EditOnEnter

            ' 2. 作成したビューから科目一覧を取得
            '    コードと名称を結合して表示用テキストを作ります
            Dim sqlMasters As String = "SELECT code, name, code || ':' || name AS display_text FROM v_account_list ORDER BY code"
            _dtAccounts = _crud.GetDataTable(sqlMasters)

            ' 3. グリッドのコンボボックス列（借方・貸方）に設定
            SetupComboBoxColumn("colDebitAcct")
            SetupComboBoxColumn("colCreditAcct")

        Catch ex As Exception
            MessageBox.Show("初期化エラー: " & ex.Message)
        End Try
    End Sub

    ' コンボボックス列の設定ヘルパー
    Private Sub SetupComboBoxColumn(colName As String)
        If dgvJournal.Columns.Contains(colName) Then
            Dim col As DataGridViewComboBoxColumn = CType(dgvJournal.Columns(colName), DataGridViewComboBoxColumn)
            col.DataSource = _dtAccounts
            col.DisplayMember = "display_text" ' 画面表示: "111:現金"
            col.ValueMember = "code"           ' 裏の値: "111"
        End If
    End Sub

    ' 検索ボタン：指定した年月のデータを表示
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            ' 年月で検索（t_shwak_d テーブル）
            Dim sql As String = "SELECT * FROM t_shwak_d " &
                                "WHERE to_char(process_date, 'YYYYMM') = @ym " &
                                "ORDER BY process_date, shwak_id"

            Dim p As New List(Of NpgsqlParameter)
            ' DateTimePickerから YYYYMM 文字列を取得
            p.Add(New NpgsqlParameter("@ym", dtpProcessDate.Value.ToString("yyyyMM")))

            Dim dt As DataTable = _crud.GetDataTable(sql, p)
            dgvJournal.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("検索エラー: " & ex.Message)
        End Try
    End Sub

    ' 保存ボタン：変更分をデータベースに反映
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dgvJournal.EndEdit() ' 編集中のセルを確定

        Try
            ' トランザクション開始 [cite: 50]
            _crud.BeginTransaction()

            For Each row As DataGridViewRow In dgvJournal.Rows
                ' 新規入力用の空行は無視
                If row.IsNewRow Then Continue For

                ' --- 入力値の収集 ---
                Dim values As New Dictionary(Of String, Object)
                ' 日付が空なら処理対象の年月日で補完
                Dim pDate = If(row.Cells("colDate").Value, dtpProcessDate.Value)
                values.Add("process_date", Convert.ToDateTime(pDate))

                values.Add("debit_acct_cd", row.Cells("colDebitAcct").Value)
                values.Add("debit_amount", ToDecimal(row.Cells("colDebitAmt").Value))
                values.Add("credit_acct_cd", row.Cells("colCreditAcct").Value)
                values.Add("credit_amount", ToDecimal(row.Cells("colCreditAmt").Value))
                values.Add("description", row.Cells("colDesc").Value)

                ' 必須項目の補完 (Access互換用)
                values.Add("kykh_id", 0)

                ' --- 新規・更新判定 ---
                Dim idVal = row.Cells("colId").Value

                If idVal Is Nothing OrElse IsDBNull(idVal) Then
                    ' IDがない = 新規登録 (INSERT) [cite: 41]
                    _crud.Insert("t_shwak_d", values)
                Else
                    ' IDがある = 更新 (UPDATE) [cite: 44]
                    Dim where As String = "shwak_id = @id"
                    Dim pKey As New List(Of NpgsqlParameter)
                    pKey.Add(New NpgsqlParameter("@id", idVal))

                    values.Add("updated_at", DateTime.Now)
                    _crud.Update("t_shwak_d", values, where, pKey)
                End If
            Next

            ' コミット [cite: 52]
            _crud.Commit()
            MessageBox.Show("保存しました。")

            ' 最新データを再表示
            btnSearch.PerformClick()

        Catch ex As Exception
            ' ロールバック [cite: 53]
            _crud.Rollback()
            MessageBox.Show("保存エラー: " & ex.Message)
        End Try
    End Sub

    ' 数値変換用ヘルパー関数
    Private Function ToDecimal(val As Object) As Decimal
        If val Is Nothing OrElse IsDBNull(val) OrElse String.IsNullOrWhiteSpace(val.ToString()) Then
            Return 0
        End If
        Return Convert.ToDecimal(val)
    End Function

    ' 終了時にリソース解放
    Private Sub FrmJournalEntry_formHelperClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If _crud IsNot Nothing Then _crud.Dispose()
    End Sub
End Class