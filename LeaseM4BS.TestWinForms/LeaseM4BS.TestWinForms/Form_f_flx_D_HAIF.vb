Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 物件フレックス（配賦行単位） ---
Partial Public Class Form_f_flx_D_HAIF
    Inherits Form

    Private Const FMT_CURRENCY As String = "#,##0"
    Private Const FMT_DATE As String = "yyyy/MM/dd"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_D_HAIF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初期表示：全件検索
        SearchData()
    End Sub

    Private Sub SearchData()
        Dim _crud As New CrudHelper()

        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            ' データをセット（ここで勝手に列が作られます）
            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

            ApplyGridStyle()

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    ' --- SQLの作成 ---
    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter)) As String
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT DISTINCT ON (haif.kykm_no) ")
        sb.AppendLine("  haif.kykm_id, ")
        sb.AppendLine("  kykh.kykh_id, ")
        sb.AppendLine("  haif.kykm_no AS 物件No, ")
        sb.AppendLine("  haif.line_id AS 配賦行No, ")
        sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")
        sb.AppendLine("  haif.saikaisu AS 再リース回数, ")
        sb.AppendLine("  kykm.bukn_bango1 AS 資産番号1, ")
        sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")
        sb.AppendLine("  kykh.kykbnl AS 契約番号, ")
        sb.AppendLine("  kykh.kykbnj AS 自社管理番号, ")
        sb.AppendLine("  kykh.rng_bango AS 稟議番号, ")
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
        sb.AppendLine("  kknri.kknri1_nm AS 管理単位, ")
        sb.AppendLine("  b_bcat.bcat1_cd AS 管理部署番号, ")
        sb.AppendLine("  b_bcat.bcat1_nm AS 管理部署, ")
        sb.AppendLine("  h_bcat.bcat1_cd AS 費用負担部署番号, ")
        sb.AppendLine("  h_bcat.bcat1_nm AS 費用負担部署, ")
        sb.AppendLine("  hkmk.hkmk_nm AS 費用区分, ")
        sb.AppendLine("  kykh.start_dt AS 開始日, ")
        sb.AppendLine("  kykh.end_dt AS 終了日, ")
        sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")
        sb.AppendLine("  haif.haifritu AS 配賦率, ")
        sb.AppendLine("  haif.h_klsryo AS 支払額1, ")
        sb.AppendLine("  haif.h_mlsryo AS 前払リース料, ")
        sb.AppendLine("  bkind_shisan.bkind_nm AS 資産区分, ")
        sb.AppendLine("  bkind_bukn.bkind_nm AS 物件種別, ")
        sb.AppendLine("  leakbn.leakbn_nm AS リース区分, ")
        sb.AppendLine("  chu_hnti.chu_hnti_nm AS 注記判定結果, ")
        sb.AppendLine("  chuum.chuum_nm AS 注記省略, ")
        sb.AppendLine("  haif.h_zokusei1 AS 備考, ")
        sb.AppendLine("  CASE WHEN kykm.b_seigou_f = FALSE THEN 'あり' ELSE NULL END AS 整合 ")

        sb.AppendLine("FROM d_haif haif ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON haif.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN d_kykm kykm ON haif.kykm_id = kykm.kykm_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
        sb.AppendLine("LEFT JOIN m_kknri kknri ON kykh.kknri_id = kknri.kknri_id ")
        sb.AppendLine("LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_bcat h_bcat ON haif.h_bcat_id = h_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_hkmk hkmk ON haif.hkmk_id = hkmk.hkmk_id ")
        sb.AppendLine("LEFT JOIN m_bkind bkind_shisan ON kykm.bkind_id = bkind_shisan.bkind_id ")
        sb.AppendLine("LEFT JOIN m_bkind bkind_bukn ON kykm.bkind_id = bkind_bukn.bkind_id ")
        sb.AppendLine("LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id ")
        sb.AppendLine("LEFT JOIN c_chu_hnti chu_hnti ON kykm.chu_hnti_id = chu_hnti.chu_hnti_id ")
        sb.AppendLine("LEFT JOIN c_chuum chuum ON kykm.chuum_id = chuum.chuum_id ")

        ' --- 検索条件 (WHERE) ---
        If searchText <> "" Then
            sb.AppendLine("WHERE kykh.kykbnj LIKE @search OR kykh.kykbnl LIKE @search ")
            prms.Add(New NpgsqlParameter("@search", $"%{searchText}%"))
        End If

        sb.AppendLine("ORDER BY haif.kykm_no, kykm.kykm_id DESC;")

        Return sb.ToString()
    End Function

    ' --- グリッドの見た目調整 ---
    Private Sub ApplyGridStyle()
        dgv_LIST.HideColumns("kykm_id", "kykh_id")

        dgv_LIST.FormatColumn("支払額1", FMT_CURRENCY)
        dgv_LIST.FormatColumn("前払リース料", FMT_CURRENCY)
        dgv_LIST.FormatColumn("開始日", FMT_DATE)
        dgv_LIST.FormatColumn("終了日", FMT_DATE)
    End Sub

    ' [検索] ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' [閉じる] ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [変更] ボタン
    Private Sub cmd_CHANGE_Click(sender As Object, e As EventArgs) Handles cmd_CHANGE.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        ShowBuknDialog(selectedRow)
        ShowContractDialog(selectedRow)
    End Sub

    ' [照会] ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        ShowBuknDialog(selectedRow)
        ShowContractDialog(selectedRow)
    End Sub

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        ShowBuknDialog(selectedRow)
        ShowContractDialog(selectedRow)
    End Sub

    ' [ファイル出力] ボタン
    Private Sub cmd_OUTPUT_FILE_Click(sender As Object, e As EventArgs) Handles cmd_OUTPUT_FILE.Click
        Dim frm As New Form_f_FlexOutputDLG
        frm.Dgv = dgv_LIST

        frm.ShowDialog()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' 契約明細フォームを表示
    Private Sub ShowBuknDialog(selectedRow As DataGridViewRow)
        Dim frmBukn As New Form_BuknEntry
        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)

        frmBukn.ShowDialog()
    End Sub

    ' 契約書フォームを表示
    Private Sub ShowContractDialog(selectedRow As DataGridViewRow)
        Dim frmContract As New Form_ContractEntry
        frmContract.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)

        frmContract.ShowDialog()
    End Sub
End Class