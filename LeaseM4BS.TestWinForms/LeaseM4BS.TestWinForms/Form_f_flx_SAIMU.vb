Imports System.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_flx_SAIMU
    Inherits Form

    Public Property DtFrom As Date
    Public Property DtTo As Date

    Private Const FMT_CURRENCY As String = "#,##0"
    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_SAIMU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_CONDITION.Text = "決算期間：" + DtFrom.ToString("yyyy/MM") + "～" + DtTo.ToString("yyyy/MM")

        SearchData()

        LoadDgvTotal()
    End Sub

    Private Sub SearchData()
        Dim prms As New List(Of NpgsqlParameter)
        Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

        dgv_LIST.Columns.Clear()
        dgv_LIST.AutoGenerateColumns = True

        dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        ApplyGridStyle(dgv_LIST)
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter)) As String
        Dim sb As New StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  kykm.kykm_id, ")
        sb.AppendLine("  kykh.kykh_id, ")
        sb.AppendLine("  leakbn.leakbn_nm AS リース区分, ")
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")
        sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")
        sb.AppendLine("  skmk.skmk_nm AS 資産区分, ")
        sb.AppendLine("  bkind.bkind_nm AS 物件種別, ")
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
        sb.AppendLine("  kykh.start_dt AS 開始日, ")
        sb.AppendLine("  kykh.end_dt AS 終了日, ")
        sb.AppendLine("  kykh.lkikan AS 期間, ")
        sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")
        sb.AppendLine("  kykm.b_syutok AS 取得価額 ")
        ' sb.AppendLine("AS 期首リース債務残高, ")
        ' sb.AppendLine("AS 今季増加債務, ")
        ' sb.AppendLine("AS 今期支払利息, ")
        ' sb.AppendLine("AS 今季返済元本, ")
        ' sb.AppendLine("AS 今季減少取得価額, ")
        ' sb.AppendLine("AS 短期リース債務, ")
        ' sb.AppendLine("AS 長期リース債務, ")
        ' sb.AppendLine("AS 期末リース債務残高, ")
        ' sb.AppendLine("AS 消費税(計上), ")
        ' sb.AppendLine("AS 消費税(取崩), ")
        ' sb.AppendLine("AS 消費税(1年内), ")
        ' sb.AppendLine("AS 消費税(期首), ")
        ' sb.AppendLine("AS 消費税(期末), ")
        ' sb.AppendLine("AS 消費税(1年超), ")
        ' sb.AppendLine("AS 抹消・消費税, ")
        ' sb.AppendLine("AS 減損勘定残(期首), ")
        ' sb.AppendLine("AS 減損勘定残高, ")
        ' sb.AppendLine("AS 抹消・減損勘定, ")
        ' sb.AppendLine("AS 減損勘定取崩額, ")
        ' sb.AppendLine("AS 減損勘定残(1年内), ")
        ' sb.AppendLine("AS 減損損失 ")

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN m_skmk skmk ON kykm.skmk_id = skmk.skmk_id ")
        sb.AppendLine("LEFT JOIN m_bkind bkind ON kykm.bkind_id = bkind.bkind_id ")
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

        ' dgvをループして集計
        For Each row As DataGridViewRow In dgv_LIST.Rows
            If Not row.IsNewRow Then
                totalSyutok += NzInt(row.Cells("取得価額").Value)
            End If
        Next

        Dim dtTotal As New DataTable()
        For Each col As DataGridViewColumn In dgv_LIST.Columns
            dtTotal.Columns.Add(col.Name)
        Next

        Dim totalRow As DataRow = dtTotal.NewRow()
        totalRow("取得価額") = ToCurrency(totalSyutok)

        dtTotal.Rows.Add(totalRow)

        dgv_TOTAL.DataSource = dtTotal

        ApplyGridStyle(dgv_TOTAL)
    End Sub

    Private Sub ApplyGridStyle(dgv As DataGridView)
        dgv.HideColumns("kykm_id", "kykh_id")

        dgv.FormatColumn("取得価額", FMT_CURRENCY)
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [再計算]ボタン
    Private Sub cmd_RECALCULATE_Click(sender As Object, e As EventArgs) Handles cmd_RECALCULATE.Click
        Me.Close()
    End Sub

    ' [返済スケジュール]ボタン
    Private Sub cmd_SCH_Click(sender As Object, e As EventArgs) Handles cmd_SCH.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frm As New Form_f_CHUKI_SCH()
        frm.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)

        frm.ShowDialog()
    End Sub

    ' [照会]ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frmBukn As New Form_BuknEntry()
        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)

        frmBukn.ShowDialog()

        Dim frmContract As New Form_ContractEntry()
        frmContract.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)

        frmContract.ShowDialog()
    End Sub

    ' [ファイル出力]ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG()
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