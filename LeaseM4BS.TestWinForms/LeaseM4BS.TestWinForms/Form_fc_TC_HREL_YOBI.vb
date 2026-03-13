Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_fc_TC_HREL_YOBI
    Inherits Form

    Private _crud As CrudHelper = New CrudHelper()
    Private _formHelper As FormHelper = New FormHelper()
    Private _whereClause As String = "ptn_cd1 IS NOT DISTINCT FROM @p1 AND " &
                                     "ptn_cd2 IS NOT DISTINCT FROM @p2 AND " &
                                     "ptn_cd3 IS NOT DISTINCT FROM @p3 AND " &
                                     "ptn_cd4 IS NOT DISTINCT FROM @p4"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_fc_TC_HREL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchData()
    End Sub

    Private Sub SearchData()
        ' コンボボックスの設定
        Dim sqlPtnNm1 As String = "SELECT DISTINCT ptn_cd1, ptn_nm1 " &
                                        "FROM tc_hrel " &
                                        "ORDER BY ptn_cd1"

        Dim cmbPtnNm1 As DataGridViewComboBoxColumn = DirectCast(dgv_LIST.Columns("col_PTN_NM1"), DataGridViewComboBoxColumn)

        _formHelper.BindCombo(cmbPtnNm1, sqlPtnNm1, "ptn_nm1", "ptn_cd1")

        Dim sqlPtnNm2 As String = "SELECT DISTINCT genk_cd, genk_nm " &
                                        "FROM m_genk " &
                                        "WHERE genk_cd <> '' " &
                                        "ORDER BY genk_cd"

        Dim cmbPtnNm2 As DataGridViewComboBoxColumn = DirectCast(dgv_LIST.Columns("col_PTN_NM2"), DataGridViewComboBoxColumn)

        _formHelper.BindCombo(cmbPtnNm2, sqlPtnNm2, "genk_nm", "genk_cd")

        Dim sqlPtnNm3 As String = "SELECT DISTINCT hkmk_cd, hkmk_nm " &
                                        "FROM m_hkmk " &
                                        "WHERE hkmk_cd <> '' " &
                                        "ORDER BY hkmk_cd"

        Dim cmbPtnNm3 As DataGridViewComboBoxColumn = DirectCast(dgv_LIST.Columns("col_PTN_NM3"), DataGridViewComboBoxColumn)

        _formHelper.BindCombo(cmbPtnNm3, sqlPtnNm3, "hkmk_nm", "hkmk_cd")

        Dim sqlPtnNm4 As String = "SELECT DISTINCT kknri1_cd, kknri1_nm " &
                                        "FROM m_kknri " &
                                        "WHERE kknri1_cd <> '' " &
                                        "ORDER BY kknri1_cd"

        Dim cmbPtnNm4 As DataGridViewComboBoxColumn = DirectCast(dgv_LIST.Columns("col_PTN_NM4"), DataGridViewComboBoxColumn)

        _formHelper.BindCombo(cmbPtnNm4, sqlPtnNm4, "kknri1_nm", "kknri1_cd")

        Try
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("SELECT * FROM tc_hrel ")

            ' --- 検索条件 (WHERE) ---
            ' テキストボックスに入力があれば、検索
            If txt_SEARCH.Text.Trim() <> "" Then
                sb.AppendLine("WHERE ptn_cd1 LIKE @search OR ptn_cd2 LIKE @search OR ptn_cd3 LIKE @search OR ptn_cd4 LIKE @search ")
            End If

            sb.AppendLine("ORDER BY ptn_cd1, ptn_cd2, ptn_cd3, ptn_cd4")

            ' パラメータ設定
            Dim prms As New List(Of NpgsqlParameter)
            If txt_SEARCH.Text.Trim() <> "" Then
                prms.Add(New NpgsqlParameter("@search", "%" & txt_SEARCH.Text.Trim() & "%"))
            End If

            dgv_LIST.AutoGenerateColumns = False

            dgv_LIST.Columns("col_PTN_CD1").DataPropertyName = "ptn_cd1"
            dgv_LIST.Columns("col_PTN_NM1").DataPropertyName = "ptn_cd1"
            dgv_LIST.Columns("col_PTN_CD2").DataPropertyName = "ptn_cd2"
            dgv_LIST.Columns("col_PTN_NM2").DataPropertyName = "ptn_cd2"
            dgv_LIST.Columns("col_PTN_CD3").DataPropertyName = "ptn_cd3"
            dgv_LIST.Columns("col_PTN_NM3").DataPropertyName = "ptn_cd3"
            dgv_LIST.Columns("col_PTN_CD4").DataPropertyName = "ptn_cd4"
            dgv_LIST.Columns("col_PTN_NM4").DataPropertyName = "ptn_cd4"

            dgv_LIST.Columns("col_KMK_CD1").DataPropertyName = "kmk_cd1"
            dgv_LIST.Columns("col_KMK_CD2").DataPropertyName = "kmk_cd2"
            dgv_LIST.Columns("col_KMK_CD3").DataPropertyName = "kmk_cd3"
            dgv_LIST.Columns("col_KMK_CD4").DataPropertyName = "kmk_cd4"
            dgv_LIST.Columns("col_KMK_CD5").DataPropertyName = "kmk_cd5"
            dgv_LIST.Columns("col_KMK_CD6").DataPropertyName = "kmk_cd6"
            dgv_LIST.Columns("col_KMK_CD7").DataPropertyName = "kmk_cd7"
            dgv_LIST.Columns("col_KMK_CD8").DataPropertyName = "kmk_cd8"
            dgv_LIST.Columns("col_KMK_CD9").DataPropertyName = "kmk_cd9"
            dgv_LIST.Columns("col_KMK_CD10").DataPropertyName = "kmk_cd10"
            dgv_LIST.Columns("col_KMK_CD11").DataPropertyName = "kmk_cd11"
            dgv_LIST.Columns("col_KMK_CD12").DataPropertyName = "kmk_cd12"
            dgv_LIST.Columns("col_KMK_CD13").DataPropertyName = "kmk_cd13"
            dgv_LIST.Columns("col_KMK_CD14").DataPropertyName = "kmk_cd14"
            dgv_LIST.Columns("col_KMK_CD15").DataPropertyName = "kmk_cd15"

            dgv_LIST.Columns("col_KMK_NM1").DataPropertyName = "kmk_nm1"
            dgv_LIST.Columns("col_KMK_NM2").DataPropertyName = "kmk_nm2"
            dgv_LIST.Columns("col_KMK_NM3").DataPropertyName = "kmk_nm3"
            dgv_LIST.Columns("col_KMK_NM4").DataPropertyName = "kmk_nm4"
            dgv_LIST.Columns("col_KMK_NM5").DataPropertyName = "kmk_nm5"
            dgv_LIST.Columns("col_KMK_NM6").DataPropertyName = "kmk_nm6"
            dgv_LIST.Columns("col_KMK_NM7").DataPropertyName = "kmk_nm7"
            dgv_LIST.Columns("col_KMK_NM8").DataPropertyName = "kmk_nm8"
            dgv_LIST.Columns("col_KMK_NM9").DataPropertyName = "kmk_nm9"
            dgv_LIST.Columns("col_KMK_NM10").DataPropertyName = "kmk_nm10"
            dgv_LIST.Columns("col_KMK_NM11").DataPropertyName = "kmk_nm11"
            dgv_LIST.Columns("col_KMK_NM12").DataPropertyName = "kmk_nm12"
            dgv_LIST.Columns("col_KMK_NM13").DataPropertyName = "kmk_nm13"
            dgv_LIST.Columns("col_KMK_NM14").DataPropertyName = "kmk_nm14"
            dgv_LIST.Columns("col_KMK_NM15").DataPropertyName = "kmk_nm15"

            dgv_LIST.DataSource = _crud.GetDataTable(sb.ToString(), prms)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    ' todo 適切なメソッド名
    Private Sub SyncDgvcomboToText(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellValueChanged
        ' ヘッダーや、コンボボックス以外の列の場合は抜ける
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgv_LIST.Rows(e.RowIndex)

        ' 対象のコンボボックス列かチェック
        Select Case dgv_LIST.Columns(e.ColumnIndex).Name
            Case "col_PTN_NM1"
                ' 選択された現在のセルを取得
                Dim comboCell As DataGridViewComboBoxCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD1").Value = comboCell.Value.ToString()

            Case "col_PTN_NM2"
                ' 選択された現在のセルを取得
                Dim comboCell As DataGridViewComboBoxCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD2").Value = comboCell.Value.ToString()

            Case "col_PTN_NM3"
                ' 選択された現在のセルを取得
                Dim comboCell As DataGridViewComboBoxCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_PTN_CD3").Value = comboCell.Value.ToString()

            Case "col_PTN_NM4"
                ' 選択された現在のセルを取得
                Dim comboCell As DataGridViewComboBoxCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

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

        Try
            'DBを更新
            SaveAllData()
        Catch ex As Exception
            MessageBox.Show("登録反映エラー: " & ex.Message)
        End Try
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
        Dim frm As New Form_f_FlexOutputDLG
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    ' DataGridViewの状態をDBに反映する(全行入れ替え方式で更新)
    Private Sub SaveAllData()
        dgv_LIST.EndEdit()

        Dim dt As DataTable = DirectCast(dgv_LIST.DataSource, DataTable)

        Dim changeDt As DataTable = dt.GetChanges()
        If changeDt Is Nothing Then
            Return
        End If


        Me.Cursor = Cursors.WaitCursor  ' カーソルを砂時計アイコンにする

        ' トランザクション開始
        _crud.BeginTransaction()

        Try
            ' 削除行などでインデックスが変わるため、後ろからループを回す
            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                Dim row As DataRow = dt.Rows(i)

                ' 新規
                If row.RowState = DataRowState.Added Then
                    Dim newHrel = GetHrelDictionary(row)

                    Dim p1 = row("ptn_cd1")
                    Dim p2 = row("ptn_cd2")
                    Dim p3 = row("ptn_cd3")
                    Dim p4 = row("ptn_cd4")

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter)
                    prms.Add(New NpgsqlParameter("@p1", p1))
                    prms.Add(New NpgsqlParameter("@p2", p2))
                    prms.Add(New NpgsqlParameter("@p3", p3))
                    prms.Add(New NpgsqlParameter("@p4", p4))

                    ' 主キーが重複する場合、登録しない
                    If _crud.Exists("tc_hrel", _whereClause, prms) Then
                        MessageBox.Show("重複するデータが入力されています。")    ' todo 重複箇所がどこか出力
                        Return
                    End If

                    _crud.Insert("tc_hrel", newHrel)

                    ' 削除
                ElseIf row.RowState = DataRowState.Deleted Then
                    Dim p1 = row("ptn_cd1", DataRowVersion.Original)
                    Dim p2 = row("ptn_cd2", DataRowVersion.Original)
                    Dim p3 = row("ptn_cd3", DataRowVersion.Original)
                    Dim p4 = row("ptn_cd4", DataRowVersion.Original)

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter)
                    prms.Add(New NpgsqlParameter("@p1", p1))
                    prms.Add(New NpgsqlParameter("@p2", p2))
                    prms.Add(New NpgsqlParameter("@p3", p3))
                    prms.Add(New NpgsqlParameter("@p4", p4))

                    _crud.Delete("tc_hrel", _whereClause, prms)

                    ' 更新
                ElseIf row.RowState = DataRowState.Modified Then
                    Dim hrel = GetHrelDictionary(row)

                    Dim p1 = row("ptn_cd1", DataRowVersion.Original)
                    Dim p2 = row("ptn_cd2", DataRowVersion.Original)
                    Dim p3 = row("ptn_cd3", DataRowVersion.Original)
                    Dim p4 = row("ptn_cd4", DataRowVersion.Original)

                    ' パラメータ設定
                    Dim prms As New List(Of NpgsqlParameter)
                    prms.Add(New NpgsqlParameter("@p1", p1))
                    prms.Add(New NpgsqlParameter("@p2", p2))
                    prms.Add(New NpgsqlParameter("@p3", p3))
                    prms.Add(New NpgsqlParameter("@p4", p4))

                    ' 主キーが重複する場合、更新しない
                    If _crud.Exists("tc_hrel", _whereClause, prms) Then
                        MessageBox.Show("重複するデータが入力されています。")    ' todo 重複箇所がどこか出力
                        Return
                    End If

                    _crud.Update("tc_hrel", hrel, _whereClause, prms)
                End If
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

    Private Function GetHrelDictionary(row As DataRow) As Dictionary(Of String, Object)
        Dim hrel As New Dictionary(Of String, Object)

        For Each col As DataColumn In row.Table.Columns
            hrel(col.ColumnName) = row(col.ColumnName)
        Next

        Return hrel
    End Function
End Class