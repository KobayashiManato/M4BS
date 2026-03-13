Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 物件フレックス ---
Partial Public Class Form_f_flx_BUKN
    Inherits Form

    Private Const FMT_CURRENCY As String = "#,##0"
    Private Const FMT_DATE As String = "yyyy/MM/dd"

    Private Sub FrmPropertyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初期表示：全件検索
        SearchData()
    End Sub

    ' ---------------------------------------------------------
    ' データ検索・一覧表示機能
    ' ---------------------------------------------------------
    Private Sub SearchData()
        Dim _crud As New CrudHelper()
        Try
            ' todo: 項目が正しいか確認
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("SELECT DISTINCT ON (kykm.kykm_no) ")
            sb.AppendLine("  kykm.kykm_id, ")
            sb.AppendLine("  kykh.kykh_id, ")
            sb.AppendLine("  kykm.kykm_no AS 物件No, ")
            sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")
            sb.AppendLine("  kykm.saikaisu AS 再リース回数, ")
            sb.AppendLine("  kykm.bukn_bango1 AS 資産番号1, ")
            sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")
            sb.AppendLine("  kykh.kykbnl AS 契約番号, ")
            sb.AppendLine("  kykh.kykbnj AS 自社管理番号, ")
            sb.AppendLine("  kykh.rng_bango AS 稟議番号, ")
            sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
            sb.AppendLine("  kknri.kknri1_nm AS 管理単位, ")
            sb.AppendLine("  bcat.bcat1_cd AS 管理部署番号, ")
            sb.AppendLine("  bcat.bcat1_nm AS 管理部署, ")
            sb.AppendLine("  kykh.start_dt AS 開始日, ")
            sb.AppendLine("  kykh.end_dt AS 終了日, ")
            sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")
            sb.AppendLine("  kykm.b_knyukn AS 現金購入価額, ")
            sb.AppendLine("  kykm.b_slsryo AS 総額リース料, ")
            sb.AppendLine("  kykm.b_glsryo AS 月額リース料, ")
            sb.AppendLine("  kykm.b_klsryo AS 支払額1, ")
            sb.AppendLine("  kykm.b_mlsryo AS 前払リース料, ")
            ' sb.AppendLine(" AS 保守料, ")    ' todo 該当項目不明 
            sb.AppendLine("  bkind_shisan.bkind_nm AS 資産区分, ")
            sb.AppendLine("  bkind_bukn.bkind_nm AS 物件種別, ")
            sb.AppendLine("  leakbn.leakbn_nm AS リース区分, ")
            sb.AppendLine("  chu_hnti.chu_hnti_nm AS 注記判定結果, ")
            sb.AppendLine("  chuum.chuum_nm AS 注記省略, ")
            sb.AppendLine("  kykm.b_zokusei1 AS 備考, ")
            sb.AppendLine("  CASE WHEN kykm.b_seigou_f = FALSE THEN 'あり' ELSE NULL END AS 整合 ")

            sb.AppendLine("FROM d_kykm kykm")
            sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
            sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
            sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
            sb.AppendLine("LEFT JOIN m_kknri kknri ON kykh.kknri_id = kknri.kknri_id ")
            sb.AppendLine("LEFT JOIN m_bcat bcat ON kykm.b_bcat_id = bcat.bcat_id ")
            sb.AppendLine("LEFT JOIN m_bkind bkind_shisan ON kykm.skmk_id = bkind_shisan.bkind_id ")
            sb.AppendLine("LEFT JOIN m_bkind bkind_bukn ON kykm.bkind_id = bkind_bukn.bkind_id")
            sb.AppendLine("LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id ")
            sb.AppendLine("LEFT JOIN c_chu_hnti chu_hnti ON kykm.chu_hnti_id = chu_hnti.chu_hnti_id ")
            sb.AppendLine("LEFT JOIN c_chuum chuum ON kykm.chuum_id = chuum.chuum_id ")

            ' --- 検索条件 (WHERE) ---
            If txt_SEARCH.Text.Trim() <> "" Then
                sb.AppendLine("WHERE kykh.kykbnj LIKE @search OR kykh.kykbnl LIKE @search ")
            End If

            ' kykm_noが重複している場合、kykm_idが最大の行を抽出する
            sb.AppendLine("ORDER BY kykm.kykm_no, kykm.kykm_id DESC")

            ' パラメータ設定
            Dim prms As New List(Of NpgsqlParameter)
            If txt_SEARCH.Text.Trim() <> "" Then
                prms.Add(New NpgsqlParameter("@search", "%" & txt_SEARCH.Text.Trim() & "%"))
            End If

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            dgv_LIST.DataSource = _crud.GetDataTable(sb.ToString(), prms)

            ' --- グリッドの見た目調整 ---
            dgv_LIST.HideColumns("kykm_id", "kykh_id")

            dgv_LIST.FormatColumn("現金購入価額", FMT_CURRENCY)
            dgv_LIST.FormatColumn("総額リース料", FMT_CURRENCY)
            dgv_LIST.FormatColumn("月額リース料", FMT_CURRENCY)
            dgv_LIST.FormatColumn("支払額1", FMT_CURRENCY)
            dgv_LIST.FormatColumn("前払リース料", FMT_CURRENCY)

            dgv_LIST.FormatColumn("開始日", FMT_DATE)
            dgv_LIST.FormatColumn("終了日", FMT_DATE)

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
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

        ' 物件入力フォーム
        Dim frm1 As New Form_BuknEntry()
        frm1.KykmId = Convert.ToDouble(dgv_LIST.GetSelectedRow().Cells("kykm_id").Value)

        frm1.ShowDialog()

        ' 契約書入力フォーム
        Dim frm2 As New Form_ContractEntry()
        frm2.KykhId = Convert.ToDouble(dgv_LIST.GetSelectedRow().Cells("kykh_id").Value)

        frm2.ShowDialog()

        SearchData()
    End Sub

    ' [物件変更] ボタン
    Private Sub cmd_CHANGE_BUKN_Click(sender As Object, e As EventArgs) Handles cmd_CHANGE_BUKN.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        ' 物件入力フォーム
        Dim frm As New Form_BuknEntry()
        frm.KykmId = Convert.ToDouble(dgv_LIST.GetSelectedRow().Cells("kykm_id").Value)

        frm.ShowDialog()
    End Sub

    ' [照会] ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        ' 物件入力フォーム
        Dim frm1 As New Form_BuknEntry()
        frm1.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)

        frm1.ShowDialog()

        ' 契約書入力フォーム
        Dim frm2 As New Form_ContractEntry()
        frm2.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)

        frm2.ShowDialog()
    End Sub

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        If e.RowIndex >= 0 Then
            ' 物件入力フォーム
            Dim frm As New Form_BuknEntry()
            frm.KykmId = Convert.ToDouble(dgv_LIST.GetSelectedRow().Cells("kykm_id").Value)

            frm.ShowDialog()
        End If
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class