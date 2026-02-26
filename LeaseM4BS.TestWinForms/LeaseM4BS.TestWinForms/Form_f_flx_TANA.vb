Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_flx_TANA
    Inherits Form

    Public Property TanaDate As Date
    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_TANA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_TANA_DATE.Text = "棚卸日：" + TanaDate.ToString("yyyy/MM/dd")

        SearchData()
    End Sub

    Private Sub SearchData()
        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter))
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT DISTINCT ON (kykm.kykm_no) ")
        sb.AppendLine("  kykm.kykm_id, ")
        sb.AppendLine("  kykh.kykh_id, ")
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")
        sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")
        sb.AppendLine("  kykm.bukn_bango1 AS 資産番号1, ")
        sb.AppendLine("  kykm.bukn_bango2 AS 資産番号2, ")
        sb.AppendLine("  kykm.bukn_bango3 AS 資産番号3, ")
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
        sb.AppendLine("  bcat.bcat1_nm AS 管理部署, ")
        sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")
        sb.AppendLine("  kykh.kykbnl AS 契約番号, ")
        sb.AppendLine("  kykm.saikaisu AS 再リース回数, ")
        sb.AppendLine("  kykh.start_dt AS 開始日, ")
        sb.AppendLine("  kykh.lkikan AS 契約期間, ")
        sb.AppendLine("  kykh.end_dt AS 終了日, ")
        sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")
        sb.AppendLine("  kykm.b_knyukn AS 現金購入価額, ")
        sb.AppendLine("  kykm.b_klsryo AS 支払額1, ")
        sb.AppendLine("  kykm.b_slsryo AS 総額リース料, ")
        sb.AppendLine("  henf.klsryo AS 保守料, ")
        sb.AppendLine("  kykm.b_zokusei1 AS 備考 ")

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN m_bcat bcat ON kykm.b_bcat_id = bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
        sb.AppendLine("LEFT JOIN d_henf henf ON kykm.kykm_id = henf.kykm_id ")

        ' --- 検索条件 (WHERE) ---
        ' 中途解約日があったら、それも判定
        sb.AppendLine("WHERE kykh.start_dt <= @dt AND kykh.end_dt >= @dt AND (kykm.ckaiyk_dt IS NULL OR kykm.ckaiyk_dt >= @dt) ")

        prms.Add(New NpgsqlParameter("dt", TanaDate))

        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("AND kykm.kykm_no = @search ")
            prms.Add(New NpgsqlParameter("@search", Double.Parse(searchText)))
        End If

        ' kykm_noが重複している場合、kykm_idが最大の行を抽出する
        sb.AppendLine("ORDER BY kykm.kykm_no, kykm.kykm_id DESC;")

        Return sb.ToString()
    End Function

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [再計算]ボタン
    Private Sub cmd_RECALCULATE_Click(sender As Object, e As EventArgs) Handles cmd_RECALCULATE.Click
        Me.Close()
    End Sub

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow = dgv_LIST.GetSelectedRow()
        If selectedRow Is Nothing Then
            Return
        End If

        Dim frmBukn As New FrmBuknEntry

        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)
        frmBukn.ShowDialog()

        Dim frmContract As New FrmContractEntry

        frmContract.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)
        frmContract.ShowDialog()
    End Sub

    ' [検索]ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' [ファイル出力]ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class