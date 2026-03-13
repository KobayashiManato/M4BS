Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Class Form_f_flx_KEIJO
    Public Property LabelText As String

    Private Const FMT_CURRENCY As String = "#,##0"
    Private Const FMT_DATE As String = "yyyy/MM/dd"
    Private _crud As New CrudHelper()

    Private Sub Form_f_flx_MONTHLY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_CONDITION.Text = LabelText

        SearchData()
    End Sub

    Private Sub SearchData()
        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

            ApplyGridStyle()

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter))
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  kykm.kykm_id, ")                                 ' 契約明細ID(D_KYKM)
        sb.AppendLine("  kykh.kykh_id, ")                                 ' 契約ID(D_KYKH)
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")                       ' 契約明細No(D_KYKM)
        sb.AppendLine("  kykm.saikaisu AS 再回, ")                        ' 再リース回数(D_KYKM)
        sb.AppendLine("  haif.line_id AS 配No, ")                         ' 行ID(D_HAIF)
        sb.AppendLine("  kkbn.kkbn_nm AS 契区, ")                         ' 契約区分名(C_KKBN)
        sb.AppendLine("  kjkbn_h.kjkbn_nm AS 計上区分, ")                 ' 契約ヘッダの計上区分(C_KJKBN)

        ' 法令区分: Access版 gCalc法令判定(START_DT, KYAK_DT, SEKOU_DT) に準拠
        ' 契約日(KYAK_DT)があればそれを、なければ開始日(START_DT)を施行日(t_settei.SEKOU_DT=2008/04/01)と比較
        ' 施行日以降 → 新法、施行日より前 → 旧法
        sb.AppendLine("  CASE ")
        sb.AppendLine("    WHEN kykh.start_dt IS NULL THEN '' ")
        sb.AppendLine("    WHEN COALESCE(kykh.kyak_dt, kykh.start_dt) >= (SELECT val_datetime FROM t_settei WHERE settei_nm = 'SEKOU_DT') THEN '新法' ")
        sb.AppendLine("    ELSE '旧法' ")
        sb.AppendLine("  END AS 法令区分, ")
        sb.AppendLine("  leakbn.leakbn_nm AS リース区分, ")               ' リース区分(C_LEAKBN)
        sb.AppendLine("  kykh.kykbnl AS 契約番号, ")                      ' 契約番号(D_KYKH)
        sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")                      ' 支払先(M_LCPT)
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")                       ' 物件名(D_KYKM)
        sb.AppendLine("  b_bcat.bcat1_nm AS 管理部署, ")                  ' 管理部署名(M_BCAT)
        sb.AppendLine("  h_bcat.bcat1_nm AS 費用負担部署, ")              ' 費用負担部署名(M_BCAT)
        sb.AppendLine("  hkmk.hkmk_nm AS 費用区分, ")                     ' 費用区分名(M_HKMK)
        sb.AppendLine("  kykh.start_dt AS 開始日, ")                      ' 開始日(D_KYKH)
        sb.AppendLine("  kykh.end_dt AS 終了日, ")                        ' 終了日(D_KYKH)

        ' 請求月: 現在日ベースで請求対象月を算出
        sb.AppendLine("  TO_CHAR(date_trunc('month', CURRENT_DATE), 'YYYY/MM') AS 請求月, ")

        sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")                 ' 中途解約日(D_KYKM)

        ' 回数済/総: 計上済支払回数 / 総支払回数
        sb.AppendLine("  CONCAT(COALESCE(kykh.kj_shri_cnt, 0), '/', COALESCE(kykh.mkaisu, 0)) AS ""回数済/総"", ")

        sb.AppendLine("  kykh.k_knyukn AS 現金購入価額_物件, ")           ' 現金購入価額(D_KYKH)
        sb.AppendLine("  kykh.k_slsryo AS 総支払額, ")                    ' 総支払額(D_KYKH)

        ' 前月末残高: 総支払額 - (月額リース料 × 計上済回数)
        ' 月額リース料 = 総支払額 / 総回数（均等割）
        sb.AppendLine("  CASE WHEN COALESCE(kykh.mkaisu, 0) > 0 THEN ")
        sb.AppendLine("    ROUND(CAST(kykh.k_slsryo - (kykh.k_slsryo / kykh.mkaisu) * COALESCE(kykh.kj_shri_cnt, 0) AS NUMERIC), 0) ")
        sb.AppendLine("  ELSE COALESCE(kykh.k_slsryo, 0) END AS 前月末残高, ")

        ' 当月計上額（税抜き）= 月額リース料（均等割）
        sb.AppendLine("  CASE WHEN COALESCE(kykh.mkaisu, 0) > 0 THEN ")
        sb.AppendLine("    ROUND(CAST(kykh.k_slsryo / kykh.mkaisu AS NUMERIC), 0) ")
        sb.AppendLine("  ELSE 0 END AS 当月計上額_税抜き, ")

        ' 当月計上額（消費税）= 月額 × 消費税率
        sb.AppendLine("  CASE WHEN COALESCE(kykh.mkaisu, 0) > 0 THEN ")
        sb.AppendLine("    ROUND(CAST((kykh.k_slsryo / kykh.mkaisu) * COALESCE(kykh.zritu, 0) / 100 AS NUMERIC), 0) ")
        sb.AppendLine("  ELSE 0 END AS 当月計上額_消費税, ")

        ' 当月計上額（税込み）= 月額 + 消費税
        sb.AppendLine("  CASE WHEN COALESCE(kykh.mkaisu, 0) > 0 THEN ")
        sb.AppendLine("    ROUND(CAST((kykh.k_slsryo / kykh.mkaisu) * (1 + COALESCE(kykh.zritu, 0) / 100) AS NUMERIC), 0) ")
        sb.AppendLine("  ELSE 0 END AS 当月計上額_税込み, ")

        ' 当月末残高: 前月末残高 - 当月計上額（税抜き）
        sb.AppendLine("  CASE WHEN COALESCE(kykh.mkaisu, 0) > 0 THEN ")
        sb.AppendLine("    ROUND(CAST(kykh.k_slsryo - (kykh.k_slsryo / kykh.mkaisu) * (COALESCE(kykh.kj_shri_cnt, 0) + 1) AS NUMERIC), 0) ")
        sb.AppendLine("  ELSE COALESCE(kykh.k_slsryo, 0) END AS 当月末残高, ")

        ' 内1年内: 月額 × MIN(12, 残回数)
        sb.AppendLine("  CASE WHEN COALESCE(kykh.mkaisu, 0) > 0 THEN ")
        sb.AppendLine("    ROUND(CAST((kykh.k_slsryo / kykh.mkaisu) * LEAST(12, GREATEST(kykh.mkaisu - COALESCE(kykh.kj_shri_cnt, 0) - 1, 0)) AS NUMERIC), 0) ")
        sb.AppendLine("  ELSE 0 END AS 内1年内, ")

        sb.AppendLine("  kykh.zritu AS 消費税率, ")                       ' 消費税率(D_KYKH)

        ' 支払日: 第3回以降支払日(日)を現在月に適用
        sb.AppendLine("  CASE WHEN kykh.shri_dt3 IS NOT NULL THEN ")
        sb.AppendLine("    CASE WHEN kykh.shri_dt3 >= 28 THEN ")
        sb.AppendLine("      (date_trunc('month', CURRENT_DATE) + INTERVAL '1 month' - INTERVAL '1 day')::DATE ")
        sb.AppendLine("    ELSE ")
        sb.AppendLine("      (date_trunc('month', CURRENT_DATE) + (kykh.shri_dt3 - 1) * INTERVAL '1 day')::DATE ")
        sb.AppendLine("    END ")
        sb.AppendLine("  END AS 支払日, ")

        sb.AppendLine("  shho.shho_nm AS 支払方法 ")                      ' 支払方法名(M_SHHO)

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN d_haif haif ON kykm.kykm_id = haif.kykm_id ")
        sb.AppendLine("LEFT JOIN c_kkbn kkbn ON kykh.kkbn_id = kkbn.kkbn_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn_h ON kykh.kjkbn_id = kjkbn_h.kjkbn_id ")   ' 契約ヘッダの計上区分
        sb.AppendLine("LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
        sb.AppendLine("LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_bcat h_bcat ON haif.h_bcat_id = h_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_hkmk hkmk ON haif.hkmk_id = hkmk.hkmk_id ")
        sb.AppendLine("LEFT JOIN m_shho shho ON kykh.shho_3_id = shho.shho_id ")          ' 第3回以降の支払方法

        ' --- 検索条件 (WHERE) ---
        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("WHERE kykh.kykbnl LIKE @search ")
            prms.Add(New NpgsqlParameter("@search", $"%{searchText}%"))
        End If

        sb.AppendLine("ORDER BY kykm.kykm_id;")

        Return sb.ToString()
    End Function

    ' --- グリッドの見た目調整 ---
    Private Sub ApplyGridStyle()
        dgv_LIST.HideColumns("kykm_id", "kykh_id")

        dgv_LIST.FormatColumn("現金購入価額_物件", FMT_CURRENCY)
        dgv_LIST.FormatColumn("総支払額", FMT_CURRENCY)
        dgv_LIST.FormatColumn("前月末残高", FMT_CURRENCY)
        dgv_LIST.FormatColumn("当月計上額_税抜き", FMT_CURRENCY)
        dgv_LIST.FormatColumn("当月計上額_消費税", FMT_CURRENCY)
        dgv_LIST.FormatColumn("当月計上額_税込み", FMT_CURRENCY)
        dgv_LIST.FormatColumn("当月末残高", FMT_CURRENCY)
        dgv_LIST.FormatColumn("内1年内", FMT_CURRENCY)

        dgv_LIST.FormatColumn("開始日", FMT_DATE)
        dgv_LIST.FormatColumn("終了日", FMT_DATE)
        dgv_LIST.FormatColumn("中途解約日", FMT_DATE)
        dgv_LIST.FormatColumn("支払日", FMT_DATE)
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [再計算]ボタン
    Private Sub cmd_RECALCULATE_Click(sender As Object, e As EventArgs) Handles cmd_RECALCULATE.Click
        Me.Close()
    End Sub

    ' [照会]ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

        Dim frmBukn As New Form_BuknEntry
        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)

        frmBukn.ShowDialog()

        Dim frmContract As New Form_ContractEntry
        frmContract.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)

        frmContract.ShowDialog()
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