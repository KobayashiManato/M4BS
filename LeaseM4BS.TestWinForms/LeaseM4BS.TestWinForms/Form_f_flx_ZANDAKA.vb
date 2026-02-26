Imports System.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_flx_ZANDAKA
    Inherits Form

    Public Property DtFrom As Date
    Public Property DtTo As Date

    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_ZANDAKA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_CONDITION.Text = "決算期間；" + DtFrom.ToString("yyyy/MM") + "～" + DtTo.ToString("yyyy/MM")

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

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter))
        Dim sb As New StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  kykm.kykm_id, ")
        sb.AppendLine("  kykh.kykh_id, ")
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")
        sb.AppendLine("  kkbn.kkbn_nm AS 契約区分, ")
        sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")
        sb.AppendLine("  kykm.bukn_bango1 AS 資産番号, ")
        sb.AppendLine("  skmk.skmk_nm AS 資産区分, ")
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
        sb.AppendLine("  b_bcat.bcat1_nm AS 管理部署, ")
        sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")
        sb.AppendLine("  kykh.kykbnl AS 契約番号, ")
        sb.AppendLine("  kykh.start_dt AS 開始日, ")
        sb.AppendLine("  kykh.end_dt AS 終了日, ")
        sb.AppendLine("  kykh.lkikan AS 期間, ")
        sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")
        sb.AppendLine("  kykm.b_syutok AS 期首取得価格 ")
        ' sb.AppendLine("  AS 期首償却累計, ")
        ' sb.AppendLine("  AS 期首減損累計, ")
        ' sb.AppendLine("  AS 期首簿価, ")
        ' sb.AppendLine("  AS 期首超過額, ")
        ' sb.AppendLine("  AS 期中増加額, ")
        ' sb.AppendLine("  AS 期中償却額, ")
        ' sb.AppendLine("  AS 期中減損額, ")
        ' sb.AppendLine("  AS 期中減少額, ")
        ' sb.AppendLine("  AS 期中超過額, ")
        ' sb.AppendLine("  AS 期中抹消額, ")
        ' sb.AppendLine("  AS 期末償却累計, ")
        ' sb.AppendLine("  AS 期末減損累計, ")
        ' sb.AppendLine("  AS 期末簿価, ")
        ' sb.AppendLine("  AS 期中不足額, ")
        ' sb.AppendLine("  AS 期末超過額, ")
        ' sb.AppendLine("  AS 期末取得価格, ")

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN c_kkbn kkbn ON kykh.kkbn_id = kkbn.kkbn_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN m_skmk skmk ON kykm.skmk_id = skmk.skmk_id ")
        sb.AppendLine("LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")

        sb.AppendLine("WHERE kykh.start_dt <= @dtTo AND kykh.end_dt >= @dtFrom ")
        sb.AppendLine("AND kykm.b_syutok IS NOT NULL ")

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
                totalSyutok += NzInt(row.Cells("期首取得価格").Value)
            End If
        Next

        Dim dtTotal As New DataTable()
        For Each col As DataGridViewColumn In dgv_LIST.Columns
            dtTotal.Columns.Add(col.Name)
        Next

        Dim totalRow As DataRow = dtTotal.NewRow()
        totalRow("期首取得価格") = totalSyutok

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

    ' [返済スケジュール]ボタン
    Private Sub cmd_SCH_Click(sender As Object, e As EventArgs) Handles cmd_SCH.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frm As New Form_f_CHUKI_SCH
        frm.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)

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