Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_fc_TC_HREL
    Inherits Form

    Private _crud As crudHelper = New crudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_fc_TC_HREL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchData()
    End Sub

    Private Sub SearchData()
        BindCombos()

        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(prms)

            dgv_LIST.AutoGenerateColumns = False

            For i = 1 To 4
                dgv_LIST.Columns($"col_PTN_CD{i}").DataPropertyName = $"ptn_cd{i}"
                dgv_LIST.Columns($"col_PTN_NM{i}").DataPropertyName = $"ptn_cd{i}"  ' ptn_nmでなくptn_cd
            Next

            For i = 1 To 15
                dgv_LIST.Columns($"col_KMK_CD{i}").DataPropertyName = $"kmk_cd{i}"
                dgv_LIST.Columns($"col_KMK_NM{i}").DataPropertyName = $"kmk_nm{i}"
            Next

            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    ' コンボボックスの設定
    Private Sub BindCombos()
        Dim sql1 As String = "SELECT DISTINCT ptn_cd1, ptn_nm1 FROM tc_hrel ORDER BY ptn_cd1;"
        Dim sql2 As String = "SELECT DISTINCT genk_cd, genk_nm FROM m_genk WHERE genk_cd <> '' ORDER BY genk_cd;"
        Dim sql3 As String = "SELECT DISTINCT hkmk_cd, hkmk_nm FROM m_hkmk WHERE hkmk_cd <> '' ORDER BY hkmk_cd;"
        Dim sql4 As String = "SELECT DISTINCT kknri1_cd, kknri1_nm FROM m_kknri WHERE kknri1_cd <> '' ORDER BY kknri1_cd;"

        Dim cmbPtnNm1 = DirectCast(dgv_LIST.Columns("col_PTN_NM1"), DataGridViewComboBoxColumn)
        Dim cmbPtnNm2 = DirectCast(dgv_LIST.Columns("col_PTN_NM2"), DataGridViewComboBoxColumn)
        Dim cmbPtnNm3 = DirectCast(dgv_LIST.Columns("col_PTN_NM3"), DataGridViewComboBoxColumn)
        Dim cmbPtnNm4 = DirectCast(dgv_LIST.Columns("col_PTN_NM4"), DataGridViewComboBoxColumn)

        cmbPtnNm1.Bind(sql1, "ptn_nm1", "ptn_cd1")
        cmbPtnNm2.Bind(sql2, "genk_nm", "genk_cd")
        cmbPtnNm3.Bind(sql3, "hkmk_nm", "hkmk_cd")
        cmbPtnNm4.Bind(sql4, "kknri1_nm", "kknri1_cd")
    End Sub

    Private Function BuildSql(ByRef prms As List(Of NpgsqlParameter))
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT * FROM tc_hrel ")

        ' --- 検索条件 (WHERE) ---
        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("WHERE ptn_cd1 LIKE @search OR ptn_cd2 LIKE @search OR ptn_cd3 LIKE @search OR ptn_cd4 LIKE @search ")
            prms.Add(New NpgsqlParameter("@search", $"%{txt_SEARCH.Text.Trim()}%"))
        End If

        sb.AppendLine("ORDER BY ptn_cd1, ptn_cd2, ptn_cd3, ptn_cd4;")

        Return sb.ToString()
    End Function

    ' todo 適切なメソッド名
    Private Sub SyncCodeColumn(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellValueChanged
        ' ヘッダーや、コンボボックス以外の列の場合は抜ける
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgv_LIST.Rows(e.RowIndex)

        ' 対象のコンボボックス列かチェック
        Select Case dgv_LIST.Columns(e.ColumnIndex).Name
            Case "col_PTN_NM1"
                ' 選択された現在のセルを取得
                Dim comboCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD1").Value = comboCell.Value.ToString()

            Case "col_PTN_NM2"
                ' 選択された現在のセルを取得
                Dim comboCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD2").Value = comboCell.Value.ToString()

            Case "col_PTN_NM3"
                ' 選択された現在のセルを取得
                Dim comboCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD3").Value = comboCell.Value.ToString()

            Case "col_PTN_NM4"
                ' 選択された現在のセルを取得
                Dim comboCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD4").Value = comboCell.Value.ToString()
        End Select
    End Sub

    ' [検索] ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [登録] ボタン
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        If MessageBox.Show("登録してもよろしいですか？", "登録確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        'DBを更新
        SaveAllData()
    End Sub

    ' [行削除] ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        ' データが選択されていないとき
        If dgv_LIST.CurrentRow Is Nothing OrElse dgv_LIST.RowCount = 0 Then
            Return
        End If

        ' 画面（DataGridView）から行を削除(DB空の削除は登録ボタン実行時)
        dgv_LIST.Rows.Remove(dgv_LIST.CurrentRow)
    End Sub

    ' [ファイル出力] ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG()
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    ' DataGridViewの状態をDBに反映する(全行入れ替え方式で更新)
    ' todo 全入れ替え方式は自動採番の時不具合になる可能性あり
    Private Sub SaveAllData()
        dgv_LIST.EndEdit()

        ' --- 1. 画面上での主キー重複チェック ---
        If IsDuplicate() Then
            MessageBox.Show("主キーが重複しています)", "入力エラー")    ' todo どの主キーが重複しているか出力したい
            Return
        End If

        Me.Cursor = Cursors.WaitCursor  ' カーソルを砂時計アイコンにする

        ' トランザクション開始
        _crud.BeginTransaction()

        Try
            ' 1. テーブルを一旦空にする
            _crud.ExecuteNonQuery("DELETE FROM tc_hrel")

            ' 2. 画面上の全行をループして登録
            For Each dgvRow As DataGridViewRow In dgv_LIST.Rows
                ' 未入力行の場合スキップ
                If dgvRow.IsNewRow Then Continue For

                Dim hrel As New Dictionary(Of String, Object)

                For i As Integer = 1 To 4
                    hrel($"ptn_cd{i}") = dgvRow.Cells($"col_PTN_CD{i}").Value
                    hrel($"ptn_nm{i}") = dgvRow.Cells($"col_PTN_NM{i}").FormattedValue
                Next

                For i As Integer = 1 To 15
                    hrel($"kmk_cd{i}") = dgvRow.Cells($"col_KMK_CD{i}").Value
                    hrel($"kmk_nm{i}") = dgvRow.Cells($"col_KMK_NM{i}").Value
                Next

                _crud.Insert("tc_hrel", hrel)
            Next

            ' SQL実行
            _crud.Commit()

        Catch ex As Exception
            _crud.Rollback()
            MessageBox.Show("登録・削除エラー: " & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function IsDuplicate() As Boolean
        ' Dictionaryを使って、ptn_cd1〜4の組み合わせが重複していないか確認
        Dim keyCheck As New HashSet(Of String)

        For Each dgvRow As DataGridViewRow In dgv_LIST.Rows
            If dgvRow.IsNewRow Then Continue For

            ' 複合主キーを1つの文字列に連結
            Dim compositeKey As String = $"{dgvRow.Cells("col_PTN_CD1").Value}_{dgvRow.Cells("col_PTN_CD2").Value}_{dgvRow.Cells("col_PTN_CD3").Value}_{dgvRow.Cells("col_PTN_CD4").Value}"

            If keyCheck.Contains(compositeKey) Then
                Return True
            End If
            keyCheck.Add(compositeKey)
        Next

        Return False
    End Function

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class