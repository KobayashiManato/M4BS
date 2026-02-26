Imports System.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Enum PeriodType
    FullYear
    HalfYear
End Enum

Partial Public Class Form_f_flx_BEPPYO
    Inherits Form

    Public Property FiscalYear As Integer
    Public Property FiscalPeriod As PeriodType
    Public Property DtFrom As Date
    Public Property DtTo As Date

    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_BEPPYO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FiscalPeriod = PeriodType.FullYear Then
            lbl_CONDITION.Text = "事業年度：" + FiscalYear.ToString() + " 通期(" + DtFrom.ToString("yyyy/MM") + "～" + DtTo.ToString("yyyy/MM") + ")"
        Else
            lbl_CONDITION.Text = "事業年度：" + FiscalYear.ToString() + " 中間(" + DtFrom.ToString("yyyy/MM") + "～" + DtTo.ToString("yyyy/MM") + ")"
        End If

        SearchData()

        LoadDgvTotal()
    End Sub

    Private Sub SearchData()
        Dim prms As New List(Of NpgsqlParameter)
        Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

        dgv_LIST.Columns.Clear()
        dgv_LIST.AutoGenerateColumns = True

        dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        dgv_LIST.HideColumns("kykm_id", "kykh_id")
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter)) As String
        Dim sb As New StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  kykm.kykm_id, ")
        sb.AppendLine("  kykh.kykh_id, ")
        sb.AppendLine("  @dtFrom AS 期首日, ")
        sb.AppendLine("  @dtTo AS 期末日, ")
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")
        sb.AppendLine("  kykh.kykbnl AS 契約番号, ")
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
        sb.AppendLine("  skmk.skmk_nm AS 資産区分, ")
        sb.AppendLine("  CASE ")
        sb.AppendLine("    WHEN kykm.b_rend_dt <= CURRENT_DATE THEN '抹消' ")
        sb.AppendLine("    ELSE '継続' ")
        sb.AppendLine("  END AS 継続抹消, ")
        sb.AppendLine("  kykh.kyak_dt AS 契約日, ")
        sb.AppendLine("  kykh.start_dt AS 開始日, ")
        sb.AppendLine("  kykm.b_syutok AS 取得価額, ")
        sb.AppendLine("  kykm.b_zanryo AS 残価保証額, ")
        ' sb.AppendLine("AS 償却計算基礎金額, ")
        ' sb.AppendLine("AS 期末簿価, ")
        sb.AppendLine("  kykh.lkikan AS 契約期間, ")

        ' 当期月数
        sb.AppendLine("  (EXTRACT(YEAR FROM AGE( ")
        sb.AppendLine("    LEAST(@dtTo, kykh.end_dt), ")            ' 期間終了 or 契約終了の早い方
        sb.AppendLine("    GREATEST(@dtFrom, kykh.start_dt) ")      ' 期間開始 or 契約開始の遅い方
        sb.AppendLine("  )) * 12 + ")
        sb.AppendLine("  EXTRACT(MONTH FROM AGE( ")
        sb.AppendLine("    LEAST(@dtTo, kykh.end_dt), ")
        sb.AppendLine("    GREATEST(@dtFrom, kykh.start_dt) ")
        sb.AppendLine("  )) + 1) AS 当期月数, ")

        ' sb.AppendLine("AS 普通償却限度額, ")
        ' sb.AppendLine("AS 当期償却額, ")
        ' sb.AppendLine("AS 当期不足額")
        ' sb.AppendLine("AS 当期超過額, ")
        ' sb.AppendLine("AS 前期からの繰越額, ")
        ' sb.AppendLine("AS 当期損金認容額, ")
        ' sb.AppendLine("AS 翌期への繰越額, ")
        sb.AppendLine("kykm.b_rend_dt AS 抹消日 ")
        ' sb.AppendLine("AS 抹消認容額, ")
        ' sb.AppendLine("AS 抹消簿価")

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN m_skmk skmk ON kykm.skmk_id = skmk.skmk_id ")
        sb.AppendLine("WHERE kykh.start_dt <= @dtTo AND kykh.end_dt >= @dtFrom ")

        prms.Add(New NpgsqlParameter("@dtFrom", DtFrom))
        prms.Add(New NpgsqlParameter("@dtTo", DtTo))

        If searchText <> "" Then
            sb.AppendLine("AND kykm_no = @search ")
            prms.Add(New NpgsqlParameter("@search", Double.Parse(searchText)))
        End If

        sb.AppendLine("ORDER BY kykm.kykm_no;")

        Return sb.ToString()
    End Function

    Private Sub LoadDgvTotal()
        Dim totalSyutok As Integer = 0
        Dim totalZanryo As Integer = 0

        ' dgvをループして集計
        For Each row As DataGridViewRow In dgv_LIST.Rows
            If Not row.IsNewRow Then
                totalSyutok += NzInt(row.Cells("取得価額").Value)
                totalZanryo += NzInt(row.Cells("残価保証額").Value)
            End If
        Next

        Dim dtTotal As New DataTable()
        For Each col As DataGridViewColumn In dgv_LIST.Columns
            dtTotal.Columns.Add(col.Name)
        Next

        Dim totalRow As DataRow = dtTotal.NewRow()
        totalRow("取得価額") = totalSyutok
        totalRow("残価保証額") = totalZanryo

        dtTotal.Rows.Add(totalRow)

        dgv_TOTAL.DataSource = dtTotal

        dgv_TOTAL.HideColumns("kykm_id", "kykh_id")
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [再計算]ボタン
    Private Sub cmd_RECALCULATE_Click(sender As Object, e As EventArgs) Handles cmd_RECALCULATE.Click
        Me.Close()
    End Sub

    ' [別表印刷]ボタン
    Private Sub cmd_PRINT_BEPPYO_Click(sender As Object, e As EventArgs) Handles cmd_PRINT_BEPPYO.Click
        Dim frm As New Form_f_BEPPYO_REP
        frm.FiscalYear = FiscalYear
        frm.DtFrom = DtFrom
        frm.DtTo = DtTo

        frm.ShowDialog()
    End Sub

    ' [照会]ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frmBukn As New FrmBuknEntry

        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)
        frmBukn.ShowDialog()

        Dim frmContract As New FrmContractEntry

        frmContract.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)
        frmContract.ShowDialog()
    End Sub

    ' [ファイル出力]ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    ' [検索]ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    Private Sub dgv_LIST_Scroll(sender As Object, e As ScrollEventArgs) Handles dgv_LIST.Scroll
        dgv_LIST.SyncDgvScroll(dgv_TOTAL)
    End Sub
End Class