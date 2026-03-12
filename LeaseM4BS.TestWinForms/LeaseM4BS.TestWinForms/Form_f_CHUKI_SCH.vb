Imports System.Data.Common
Imports System.Drawing.Printing
Imports System.Net.Mail
Imports System.Text
Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Class Form_f_CHUKI_SCH
    Public Property KykmId As Double

    Private Const FMT_CURRENCY As String = "#,##0"
    Private _crud As New CrudHelper()
    Private m_rowIndex As Integer = 0

    Private Sub Form_f_CHUKI_SCH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKykmDetails(KykmId)

        Dim prms As New List(Of NpgsqlParameter)
        Dim sql = BuildSql(prms)

        dgv_LIST.Columns.Clear()
        dgv_LIST.AutoGenerateColumns = True

        dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        ApplyGridStyle()

        LoadDgvTotal()
    End Sub

    Private Sub LoadKykmDetails(kykmId As Double)
        Dim sql = "SELECT * FROM d_kykm kykm " &
                  "LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id " &
                  "LEFT JOIN c_skyak_ho skyak_ho ON kykm.skyak_ho_id = skyak_ho.skyak_ho_id " &
                  "LEFT JOIN m_skmk skmk ON kykm.skmk_id = skmk.skmk_id " &
                  "LEFT JOIN m_bkind bkind ON kykm.bkind_id = bkind.bkind_id " &
                  "LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id " &
                  "WHERE kykm.kykm_id = @kykmId"

        Dim prms As New List(Of NpgsqlParameter)
        prms.Add(New NpgsqlParameter("@kykmId", kykmId))

        Try
            Dim dt = _crud.GetDataTable(sql, prms)

            If dt.Rows.Count = 0 Then Return

            Dim row As DataRow = dt.Rows(0)

            txt_KYKM_NO.SetText(row("kykm_no"))
            txt_BUKN_NM.SetText(row("bukn_nm"))
            txt_LEAKBN_NM.SetText(row("leakbn_nm"))
            txt_SKYAK_HO_NM.SetText(row("skyak_ho_nm"))
            ' txt_SKYAK_RITU.SetText(row(""))
            txt_SKMK_NM.SetText(row("skmk_nm"))
            txt_BKIND_NM.SetText(row("bkind_nm"))
            txt_START_DT.Text = ToDateStr(row("start_dt"))
            txt_END_DT.Text = ToDateStr(row("end_dt"))
            txt_LKIKAN.SetText(row("lkikan"))
            txt_MKAISU.SetText(row("mkaisu"))
            txt_SHRI_CNT.SetText(row("shri_cnt"))
            txt_MAE_DT.Text = ToDateStr(row("mae_dt"))
            txt_SHRI_DT1.Text = ToDateStr(row("shri_dt1"))
            txt_SHRI_DT2.Text = ToDateStr(row("shri_dt2"))
            txt_SHRI_DT3.SetText(row("shri_dt3"))
            txt_SHRI_EN_DT.Text = ToDateStr(row("shri_en_dt"))
            txt_CKAIYK_DT.Text = ToDateStr(row("ckaiyk_dt"))
            txt_CKAIYK_ESDT.SetText(row("ckaiyk_esdt_t"))       ' ckaiyk_esdt_hかも
            txt_KLSRYO.SetAmount(row("b_klsryo"))
            txt_SLSRYO.SetAmount(row("b_slsryo"))
            txt_IJIKNR.SetAmount(row("b_ijiknr"))
            txt_ZANRYO.SetAmount(row("b_zanryo"))
            txt_KNYUKN.SetAmount(row("b_knyukn"))
            ' txt_ZEI.SetText(row(""))
            txt_KARI_RITU.SetText(row("kari_ritu"))
            txt_GNZAI_KT.SetAmount(row("b_gnzai_kt"))
            txt_SYUTOK.SetAmount(row("b_syutok"))
            txt_KSAN_RITU.SetText(row("ksan_ritu"))
            txt_LB.SetAmount(row("b_lb_soneki"))

        Catch ex As Exception
            MessageBox.Show("詳細読込エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(ByRef prms As List(Of NpgsqlParameter)) As String
        Dim sb As New StringBuilder()

        Dim currentDt As Date = GetMonthStart(txt_START_DT.Text)
        Dim endDt As Date = GetMonthStart(txt_SHRI_EN_DT.Text)
        Dim i As Integer = 0

        Dim rlsryo = GetSlsryo()

        While currentDt <= endDt
            If i > 0 Then sb.AppendLine("UNION ALL ")

            sb.AppendLine("SELECT ")
            sb.AppendLine($"  @dt{i} AS 年月, ")
            sb.AppendLine($"  @klsryo{i} AS 支払リース料, ")
            sb.AppendLine($"  @ghassei{i} AS 発生リース料, ")    ' todo
            ' sb.AppendLine("  AS 発生利息相当額, ")
            ' sb.AppendLine("  AS 支払利息相当額, ")
            ' sb.AppendLine("  AS 変換元本相当額, ")
            sb.AppendLine($"  @rlsryo{i} AS 未経過リース料残高相当額, ")
            ' sb.AppendLine("  AS リース資産減損勘定の取崩額, ")
            ' sb.AppendLine("  AS リース資産減損勘定の残高, ")
            ' sb.AppendLine("  AS 未払利息残高相当額, ")
            ' sb.AppendLine("  AS 減価償却費相当額, ")
            ' sb.AppendLine("  AS 減損損失の金額, ")
            sb.AppendLine("  gson.gson_rkei AS 減価償却累計額相当額, ")
            ' sb.AppendLine("  AS 残高相当額, ")
            ' sb.AppendLine("  AS 未払消費税取崩額, ")
            ' sb.AppendLine("  AS 未払消費税残高, ")
            ' sb.AppendLine("  AS リースバック繰延損益, ")
            sb.AppendLine("  kykm.b_ijiknr AS 維持管理費用, ")
            sb.AppendLine("  kykm.b_ckaiyk_f AS 解約状態")

            sb.AppendLine("FROM d_kykm kykm ")
            sb.AppendLine("LEFT JOIN d_gson gson ON kykm.kykm_id = gson.kykm_id ")
            sb.AppendLine("WHERE kykm.kykm_id = @kykmId ")

            Dim klsryo As Integer = CalcKlsryo(currentDt)
            Dim ghassei As Integer = CalcGhassei(currentDt)
            rlsryo -= klsryo

            prms.Add(New NpgsqlParameter($"@dt{i}", currentDt.ToString("yyyy/MM")))
            prms.Add(New NpgsqlParameter($"@klsryo{i}", klsryo))
            prms.Add(New NpgsqlParameter($"@ghassei{i}", ghassei))
            prms.Add(New NpgsqlParameter($"@rlsryo{i}", rlsryo))

            currentDt = currentDt.AddMonths(1)
            i += 1
        End While

        prms.Add(New NpgsqlParameter("@kykmId", KykmId))

        Return sb.ToString()
    End Function

    Private Sub ApplyGridStyle()
        dgv_LIST.FormatColumn("支払リース料", FMT_CURRENCY)
        dgv_LIST.FormatColumn("発生リース料", FMT_CURRENCY)
        dgv_LIST.FormatColumn("未経過リース料残高相当額", FMT_CURRENCY)
        dgv_LIST.FormatColumn("減価償却累計額相当額", FMT_CURRENCY)
        dgv_LIST.FormatColumn("維持管理費用", FMT_CURRENCY)
    End Sub

    Private Sub LoadDgvTotal()
        Dim totalKlsryo As Integer = 0
        Dim totalGhassei As Integer = 0
        Dim totalIjiknr As Integer = 0

        ' メインのdgvをループして集計
        For Each row As DataGridViewRow In dgv_LIST.Rows
            If Not row.IsNewRow Then
                totalKlsryo += NzInt(row.Cells("支払リース料").Value)
                totalGhassei += NzInt(row.Cells("発生リース料").Value)
                totalIjiknr += NzInt(row.Cells("維持管理費用").Value)
            End If
        Next

        Dim dtTotal As New DataTable()
        For Each col As DataGridViewColumn In dgv_LIST.Columns
            dtTotal.Columns.Add(col.Name)
        Next

        Dim totalRow As DataRow = dtTotal.NewRow()
        Dim totalRow2 As DataRow = dtTotal.NewRow()

        totalRow("年月") = "計"
        totalRow("支払リース料") = totalKlsryo.ToString(FMT_CURRENCY)
        totalRow("発生リース料") = totalGhassei.ToString(FMT_CURRENCY)
        totalRow("維持管理費用") = totalIjiknr.ToString(FMT_CURRENCY)

        dtTotal.Rows.Add(totalRow)  ' 計

        totalRow2("年月") = "解約含む"
        totalRow2("支払リース料") = totalKlsryo.ToString(FMT_CURRENCY)
        totalRow2("発生リース料") = totalGhassei.ToString(FMT_CURRENCY)
        totalRow2("維持管理費用") = totalIjiknr.ToString(FMT_CURRENCY)

        dtTotal.Rows.Add(totalRow2)  ' 解約含む

        dgv_TOTAL.DataSource = dtTotal
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [印刷]ボタン
    Private Sub cmd_PRINT_Click(sender As Object, e As EventArgs) Handles cmd_PRINT.Click
        ' 印刷プレビューを表示する場合
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = PrintDocument1
        ppd.ShowDialog()
    End Sub

    Private Function CalcKlsryo(dt As Date) As Integer
        Dim sql = "SELECT * FROM d_kykm kykm " &
                  "LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id " &
                  "WHERE kykm.kykm_id = @kykmId"

        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@kykmId", KykmId)}
        }

        Dim row As DataRow = _crud.GetDataTable(sql, prms).Rows(0)

        dt = GetMonthStart(dt)
        Dim shriDt1 = GetMonthStart(row("shri_dt1"))
        Dim shriDt2 = GetMonthStart(row("shri_dt2"))

        ' 支払開始前は0
        If dt < shriDt1 Then
            Return 0
        End If

        ' 支払月か判定
        Dim diffMonths As Integer = ((dt.Year - shriDt1.Year) * 12) + (dt.Month - shriDt1.Month)
        Dim interval As Integer = CInt(row("shri_kn"))

        If diffMonths Mod interval <> 0 Then
            Return 0
        End If

        If dt = shriDt1 AndAlso dt = shriDt2 Then
            Return CInt(row("k_klsryo")) * 2
        Else
            Return CInt(row("k_klsryo"))
        End If
    End Function

    ' todo
    Private Function CalcGhassei(dt As Date) As Integer
        Return CalcKlsryo(dt)
    End Function

    Private Function GetSlsryo() As Integer
        Dim sql = "SELECT b_slsryo FROM d_kykm kykm WHERE kykm.kykm_id = @kykmId "

        Dim prms As New List(Of NpgsqlParameter) From {
            {New NpgsqlParameter("@kykmId", KykmId)}
        }

        Dim row As DataRow = _crud.GetDataTable(sql, prms).Rows(0)

        Return CInt(row("b_slsryo"))
    End Function

    ' [Excel出力]ボタン
    Private Sub cmd_OUTPUT_EXCEL_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_EXCEL_FILE.Click
        Dim _fileHelper As New FileHelper()

        _fileHelper.ToExcelFile(dgv_LIST)
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' 描画処理本体 todo印刷
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g = e.Graphics
        Dim fontTitle As New Font("MS UI Gothic", 16, FontStyle.Bold)
        Dim fontBody As New Font("MS UI Gothic", 10)
        Dim x As Integer = 50
        Dim y As Integer = 50

        ' --- 1ページ目だけにタイトルを表示したい場合 ---
        If m_rowIndex = 0 Then
            g.DrawString("リース料計算書", fontTitle, Brushes.Black, x, y)
            y += 40
            g.DrawString($"契約番号：{txt_KYKM_NO.Text}", fontBody, Brushes.Black, x, y)
            y += 20
            g.DrawString($"物件名：{txt_BUKN_NM.Text}", fontBody, Brushes.Black, x, y)
            y += 40
        End If

        ' --- ヘッダー印刷（全ページに出したい場合はここ） ---
        Dim currentX As Integer = x
        For Each col As DataGridViewColumn In dgv_LIST.Columns
            If col.Visible Then
                g.DrawRectangle(Pens.Black, currentX, y, col.Width, 25)
                g.DrawString(col.HeaderText, fontBody, Brushes.Black, currentX + 2, y + 5)
                currentX += col.Width
            End If
        Next
        y += 25

        ' --- データの印刷（続きから開始） ---
        For i As Integer = m_rowIndex To dgv_LIST.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_LIST.Rows(i)
            If row.IsNewRow Then Continue For

            currentX = x
            For Each cell As DataGridViewCell In row.Cells
                If cell.OwningColumn.Visible Then
                    g.DrawRectangle(Pens.Black, currentX, y, cell.OwningColumn.Width, 20)
                    Dim val As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                    g.DrawString(val, fontBody, Brushes.Black, currentX + 2, y + 3)
                    currentX += cell.OwningColumn.Width
                End If
            Next
            y += 20

            ' ページ末尾の判定
            If y > e.MarginBounds.Bottom - 40 Then ' 余白を考慮
                m_rowIndex = i + 1 ' 次回はこの行から開始
                e.HasMorePages = True ' 次のページがある
                Return ' 一旦抜ける（イベントが再発行される）
            End If
        Next

        ' --- すべて印刷し終えたら合計行（dgv_TOTAL）を印刷 ---
        ' ここに dgv_TOTAL のループ処理を同様に書く...

        e.HasMorePages = False ' これで印刷終了！
    End Sub
End Class

