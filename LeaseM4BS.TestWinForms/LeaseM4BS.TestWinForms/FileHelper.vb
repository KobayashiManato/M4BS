Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop ' クラスの先頭に追加

Public Class FileHelper
    ' Excelファイルとして出力
    Public Sub ToExcelFile(dgv As DataGridView)
        ' 保存ダイアログを表示
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excelブック(*.xlsx)|*.xlsx"
        sfd.FileName = dgv.FindForm().Text & ".xlsx"    ' フォーム名.拡張子

        If sfd.ShowDialog() <> DialogResult.OK Then Return

        Dim xlApp As Excel.Application = Nothing
        Dim xlBooks As Excel.Workbooks = Nothing
        Dim xlBook As Excel.Workbook = Nothing
        Dim xlSheets As Excel.Sheets = Nothing
        Dim xlSheet As Excel.Worksheet = Nothing

        Try
            xlApp = New Excel.Application()
            xlBooks = xlApp.Workbooks
            xlBook = xlBooks.Add()
            xlSheets = xlBook.Worksheets
            xlSheet = DirectCast(xlSheets(1), Excel.Worksheet)

            ' 1. ヘッダー（列名）の書き込み
            Dim colCount As Integer = 0
            For i As Integer = 0 To dgv.Columns.Count - 1
                ' 非表示の列（col_IS_OLDなど）は出力しない
                If dgv.Columns(i).Visible Then
                    colCount += 1
                    xlSheet.Cells(1, colCount) = dgv.Columns(i).HeaderText
                End If
            Next

            ' 2. データの書き込み
            For r As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows(r).IsNewRow Then Continue For

                Dim excelCol As Integer = 0
                For c As Integer = 0 To dgv.Columns.Count - 1
                    If dgv.Columns(c).Visible Then
                        excelCol += 1
                        ' セルの値（FormattedValueを使うと画面上の見た目通りに出ます）
                        xlSheet.Cells(r + 2, excelCol) = dgv.Rows(r).Cells(c).FormattedValue
                    End If
                Next
            Next

            ' 3. ファイルを保存
            xlBook.SaveAs(sfd.FileName)
            MessageBox.Show("Excel出力を完了しました。")

        Catch ex As Exception
            MessageBox.Show("Excel出力エラー: " & ex.Message)
        Finally
            ' Excelプロセスを確実に終了させる
            If xlBook IsNot Nothing Then xlBook.Close(False)
            If xlApp IsNot Nothing Then xlApp.Quit()

            ' COMオブジェクトの解放（これをしないとExcelプロセスがタスクマネージャに残ります）
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheets)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBooks)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
        End Try
    End Sub

    ' Csvファイルとして出力
    ' todo delimiter(区切り文字)にカンマ以外(", 'など)を指定すると、正しく出力されない
    Public Sub ToCsvFile(dgv As DataGridView, Optional delimiter As String = ",")
        ' 保存ダイアログ
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "CSVファイル(*.csv)|*.csv"
        sfd.FileName = dgv.FindForm().Text & ".csv"

        If sfd.ShowDialog() <> DialogResult.OK Then Return

        Try
            ' Shift-JIS (Excelでそのまま開ける文字コード) で書き出し
            ' ※ .NET Core/5+ の場合は Encoding.RegisterProvider(CodePagesEncodingProvider.Instance) が必要
            Dim sjis As Encoding = Encoding.GetEncoding("Shift_JIS")

            Using sw As New StreamWriter(sfd.FileName, False, sjis)
                ' 1. ヘッダーの書き込み
                Dim headerList As New List(Of String)
                For Each col As DataGridViewColumn In dgv.Columns
                    If col.Visible Then
                        headerList.Add($"""{col.HeaderText}""")
                    End If
                Next
                sw.WriteLine(String.Join(delimiter, headerList))

                ' 2. データの書き込み
                For Each row As DataGridViewRow In dgv.Rows
                    If row.IsNewRow Then Continue For

                    Dim dataList As New List(Of String)
                    For Each col As DataGridViewColumn In dgv.Columns
                        If col.Visible Then
                            ' セルの値を取得（Nothingなら空文字、ダブルクォーテーションで囲む）
                            Dim val As String = If(row.Cells(col.Index).FormattedValue?.ToString(), "")
                            dataList.Add($"""{val.Replace("""", """""")}""") ' 値の中の " を "" にエスケープ
                        End If
                    Next

                    sw.WriteLine(String.Join(delimiter, dataList))
                Next
            End Using

            MessageBox.Show("CSV出力を完了しました。")

        Catch ex As Exception
            MessageBox.Show("CSV出力エラー: " & ex.Message)
        End Try
    End Sub

    ' 固定長ファイルとして出力
    ' columnByteWidths: 列名→バイト幅の辞書（未指定時は col.Tag または自動算出）
    Public Sub ToFixedLengthFile(dgv As DataGridView, Optional columnByteWidths As Dictionary(Of String, Integer) = Nothing)
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "テキストファイル(*.txt)|*.txt"
        sfd.FileName = dgv.FindForm().Text & ".txt"

        If sfd.ShowDialog() <> DialogResult.OK Then Return

        Try
            Dim sjis As Encoding = Encoding.GetEncoding("Shift_JIS")

            Using sw As New StreamWriter(sfd.FileName, False, sjis)
                For Each row As DataGridViewRow In dgv.Rows
                    If row.IsNewRow Then Continue For

                    Dim line As New StringBuilder()

                    For Each col As DataGridViewColumn In dgv.Columns
                        If col.Visible Then
                            Dim rawValue As String = row.Cells(col.Name).FormattedValue?.ToString()
                            Dim byteWidth As Integer = GetColumnByteWidth(col, columnByteWidths)
                            line.Append(PadRightByte(rawValue, byteWidth))
                        End If
                    Next

                    sw.WriteLine(line.ToString())
                Next
            End Using

            MessageBox.Show("固定長ファイルの出力を完了しました。")

        Catch ex As Exception
            MessageBox.Show("出力エラー: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 列のバイト幅を取得します（辞書 → Tag → デフォルトの優先順位）
    ''' </summary>
    Private Function GetColumnByteWidth(col As DataGridViewColumn, columnByteWidths As Dictionary(Of String, Integer)) As Integer
        ' 優先1: 呼び出し元から指定された辞書
        If columnByteWidths IsNot Nothing AndAlso columnByteWidths.ContainsKey(col.Name) Then
            Return columnByteWidths(col.Name)
        End If

        ' 優先2: Column.Tag に Integer が設定されている場合
        If col.Tag IsNot Nothing AndAlso TypeOf col.Tag Is Integer Then
            Return CInt(col.Tag)
        End If

        ' 優先3: ヘッダーテキストのバイト長ベースのデフォルト（最低10バイト）
        Dim sjis As Encoding = Encoding.GetEncoding("Shift_JIS")
        Dim headerBytes As Integer = sjis.GetByteCount(If(col.HeaderText, ""))
        Return Math.Max(headerBytes + 2, 10)
    End Function

    ''' <summary>
    ''' 文字列をバイト数指定でパディング（または切り捨て）します
    ''' </summary>
    Private Function PadRightByte(text As String, byteLen As Integer) As String
        Dim sjis As Encoding = Encoding.GetEncoding("Shift_JIS")
        Dim val As String = If(text, "")
        Dim currentBytes As Byte() = sjis.GetBytes(val)

        If currentBytes.Length >= byteLen Then
            ' 指定サイズ以上の場合は切り捨て
            Return sjis.GetString(currentBytes, 0, byteLen)
        Else
            ' 足りない分を半角スペースで埋める
            Return val & New String(" "c, byteLen - currentBytes.Length)
        End If
    End Function
End Class
