Imports System.Runtime.CompilerServices
Imports DataAccess
Imports DocumentFormat.OpenXml.Wordprocessing
Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Module FormHelper
    Private _crud As New CrudHelper()

    <Extension()>
    Public Sub Bind(cmb As ComboBox, sql As String, display As String, value As String, Optional prms As List(Of NpgsqlParameter) = Nothing)
        cmb.DisplayMember = display
        cmb.ValueMember = value

        If prms Is Nothing Then
            cmb.DataSource = _crud.GetDataTable(sql)
        Else
            cmb.DataSource = _crud.GetDataTable(sql, prms)
        End If
    End Sub

    <Extension()>
    Public Sub Bind(cmb As DataGridViewComboBoxColumn, sql As String, display As String, value As String, Optional prms As List(Of NpgsqlParameter) = Nothing)
        cmb.DisplayMember = display
        cmb.ValueMember = value

        If prms Is Nothing Then
            cmb.DataSource = _crud.GetDataTable(sql)
        Else
            cmb.DataSource = _crud.GetDataTable(sql, prms)
        End If
    End Sub

    <Extension()>
    Public Sub AdjustSize(cmb As ComboBox, Optional width As Integer = 600, Optional height As Integer = 16)
        ' ドロップダウンの全体幅 (各列の合計+スクロールバー分)
        cmb.DropDownWidth = width
        cmb.DrawMode = DrawMode.OwnerDrawVariable
        cmb.ItemHeight = height
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================
    <Extension()>
    Public Sub SyncTo(cmb As ComboBox, columnName As String, targetTextBox As TextBox)
        Dim drv = TryCast(cmb.SelectedItem, DataRowView)

        Dim text As String = If(drv IsNot Nothing, drv(columnName).ToString(), "")

        If targetTextBox IsNot Nothing Then
            targetTextBox.Text = text
        End If
    End Sub

    <Extension()>
    Public Sub SyncTo(cmb As ComboBox, columnName As String, targetCmb As ComboBox)
        If targetCmb Is Nothing Then Return

        Dim drv = TryCast(cmb.SelectedItem, DataRowView)

        If drv IsNot Nothing Then
            ' 指定された列の値をセット
            targetCmb.SelectedValue = If(drv(columnName), DBNull.Value)
        Else
            targetCmb.SelectedValue = DBNull.Value
        End If
    End Sub

    <Extension()>
    Public Sub SyncTo(cmb As DataGridViewComboBoxColumn, rowIndex As Integer, fromColumn As String, toColumn As String)
        Dim dgv = cmb.DataGridView
        If dgv Is Nothing OrElse rowIndex < 0 Then Return

        Dim row = dgv.Rows(rowIndex)
        Dim cellValue = row.Cells(cmb.Name).Value
        Dim dt = TryCast(cmb.DataSource, DataTable)

        If cellValue IsNot Nothing AndAlso dt IsNot Nothing Then
            Dim found = dt.Select($"{cmb.ValueMember} = '{cellValue}'")

            row.Cells(toColumn).Value = If(found.Length > 0, found(0)(fromColumn), DBNull.Value)
        Else
            row.Cells(toColumn).Value = DBNull.Value
        End If
    End Sub

    ' 列を隠す
    <Extension()>
    Public Sub HideColumns(dgv As DataGridView, ParamArray columnNames As String())
        If dgv Is Nothing Then Return
        If columnNames Is Nothing OrElse columnNames.Length = 0 Then Return

        For Each columnName In columnNames
            If dgv.Columns.Contains(columnName) Then
                dgv.Columns(columnName).Visible = False
            End If
        Next
    End Sub

    ' 列フォーマット用(fmt="yyyy-MM-dd"等)
    <Extension()>
    Public Sub FormatColumn(dgv As DataGridView, columnName As String, fmt As String)
        If dgv.Columns.Contains(columnName) Then
            dgv.Columns(columnName).DefaultCellStyle.Format = fmt
        End If
    End Sub

    ' 選択行を返す
    <Extension()>
    Public Function GetSelectedRow(dgv As DataGridView) As DataGridViewRow
        ' 1. 「青く選択されている行」を優先して探す
        If dgv.SelectedRows.Count > 0 Then
            Return dgv.SelectedRows(0)
        End If

        ' 2. なければ「カーソルがある行」を探す
        If dgv.CurrentRow IsNot Nothing Then
            Return dgv.CurrentRow
        End If

        ' 3. それでも取れない、または無効な行（新規行やインデックス異常）ならエラー
        MessageBox.Show("行を選択してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return Nothing
    End Function

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Public Sub Combo_DrawItem(sender As Object, e As DrawItemEventArgs, columnNames As String())
        Dim cmb As ComboBox = CType(sender, ComboBox)

        e.DrawBackground()

        If e.Index < 0 Then Return

        ' データ行を取り出す (DataRowViewとして取得できる)
        Dim drv As DataRowView = CType(cmb.Items(e.Index), DataRowView)

        ' --- 列幅の設定 (AccessのTwipsを参考にPixel換算) ---
        ' 管理単位: 1419;3969;2268 (約 95px, 265px, 150px)
        ' 支払先  : 1421;3402;1701 (約 95px, 225px, 115px)
        ' w2 = 225 : w3 = 115 ' 支払先用の幅調整
        Dim w As Integer = 115

        ' --- 描画ブラシ設定 ---
        Dim textBrush As Brush = If((e.State And DrawItemState.Selected) = DrawItemState.Selected, SystemBrushes.HighlightText, SystemBrushes.WindowText)
        Dim linePen As Pen = SystemPens.ControlDark ' 区切り線の色

        ' 1列目のX座標
        Dim currentX = e.Bounds.X

        For i = 0 To columnNames.Length - 1
            Dim columnName = drv(columnNames(i)).ToString()

            Dim rect As New Rectangle(currentX, e.Bounds.Y, w, e.Bounds.Height)

            e.Graphics.DrawString(columnName, e.Font, textBrush, rect)

            ' 間の区切り線
            If i < columnNames.Length - 1 Then
                e.Graphics.DrawLine(linePen, rect.Right, rect.Top, rect.Right, rect.Bottom) ' 縦線
            End If

            currentX = rect.Right + 2
        Next

        e.DrawFocusRectangle()
    End Sub

    ' 横スクロール位置を同期させる（重要）
    <Extension()>
    Public Sub SyncDgvScroll(dgvMain As DataGridView, dgvTotal As DataGridView)
        dgvTotal.HorizontalScrollingOffset = dgvMain.HorizontalScrollingOffset
    End Sub

    ' 列幅と可視状態を同期させる
    <Extension()>
    Public Sub SyncDgvColumnWidths(dgvMain As DataGridView, dgvTotal As DataGridView)
        For i As Integer = 0 To dgvMain.ColumnCount - 1
            dgvTotal.Columns(i).Width = dgvMain.Columns(i).Width
            dgvTotal.Columns(i).Visible = dgvMain.Columns(i).Visible
        Next
    End Sub

    <Extension()>
    Public Sub SetText(target As TextBox, value As Object)
        target.Text = If(value Is Nothing OrElse IsDBNull(value), "", value.ToString())
    End Sub

    <Extension()>
    Public Sub SetAmount(target As TextBox, value As Object)
        target.Text = ToCurrency(value)
    End Sub
End Module