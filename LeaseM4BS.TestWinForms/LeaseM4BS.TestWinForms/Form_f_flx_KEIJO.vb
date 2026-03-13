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

        ' todo 項目が正しいか
        sb.AppendLine("SELECT ")
        sb.AppendLine("  kykm.kykm_id, ")                                 ' 契約明細ID(D_KYKM)
        sb.AppendLine("  kykh.kykh_id, ")                                 ' 契約ID(D_KYKH)
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")                       ' 契約明細No(D_KYKM)
        sb.AppendLine("  kykm.saikaisu AS 再回, ")                        ' 再リース回数D_KYKM)
        sb.AppendLine("  haif.line_id AS 配No, ")                         ' 行ID(D_HAIF)
        sb.AppendLine("  kkbn.kkbn_nm AS 契区, ")                         ' 契約区分名(C_KKBN)
        sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")                   ' 計上区分名(C_KJKBN)
        ' sb.AppendLine(" AS 法令区分, ")                               ' 法令区分(todo 場所不明、多分計算で判定する)
        sb.AppendLine("  leakbn.leakbn_nm AS リース区分, ")               ' リース区分(C_LEAKBN)
        sb.AppendLine("  kykh.kykbnl AS 契約番号, ")                      ' 契約番号(D_KYKH)
        sb.AppendLine("  lcpt.lcpt1_nm AS 支払先, ")                       ' 支払先(M_LCPT)
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")                       ' 物件名(D_KYKM)
        sb.AppendLine("  b_bcat.bcat1_nm AS 管理部署, ")                  ' 管理部署名(M_BCAT)
        sb.AppendLine("  h_bcat.bcat1_nm AS 費用負担部署, ")              ' 費用負担部署名(M_BCAT)
        sb.AppendLine("  hkmk.hkmk_nm AS 費用区分, ")                     ' 費用区分名(M_HKMK)
        sb.AppendLine("  kykh.start_dt AS 開始日, ")                      ' 開始日(D_KYKH)
        sb.AppendLine("  kykh.end_dt AS 終了日, ")                        ' 終了日(D_KYKH)
        ' sb.AppendLine("")                                             ' 請求月(todo 場所不明、集計月？(開始日から終了日まで毎月ある可能性))
        sb.AppendLine("  kykm.ckaiyk_dt AS 中途解約日, ")                 ' 中途解約日(D_KYKM)
        ' sb.AppendLine("AS 回数済/総, ")                               ' 支払済み回数と総支払回数
        sb.AppendLine("  kykh.k_knyukn AS 現金購入価額_物件, ")          ' 現金購入価額(D_KYKH)
        sb.AppendLine("  kykh.k_slsryo AS 総支払額, ")                    ' 総支払額(D_KYKH)
        ' sb.AppendLine(" AS 前月末残高, ")                             ' todo 計算
        sb.AppendLine("  kykh.k_glsryo AS 当月計上額_税抜き, ")          ' 当月計上額(税抜き)(D_KYKH)
        sb.AppendLine("  kykh.k_gzei AS 当月計上額_消費税, ")            ' 当月計上額(消費税)(D_KYKH)
        sb.AppendLine("  kykh.k_glsryo_zkomi AS 当月計上額_税込み, ")    ' 当月計上額(税込み)(D_KYKH)
        ' sb.AppendLine(" AS 当月末残高, ")                             ' todo 前月末残高 - 当月計上額(税抜き) 多分
        ' sb.AppendLine("AS 内1年内, ")                                 ' todo 不明
        sb.AppendLine("  kykh.zritu AS 消費税率, ")                       ' 消費税率(D_KYKH)
        ' sb.AppendLine(" AS 支払日, ")                                 ' 集計月とSHRI_DT3から計算できそう
        sb.AppendLine("  shho.shho_nm AS 支払方法 ")                      ' 支払方法名(M_SHHO)

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN d_haif haif ON kykm.kykm_id = haif.kykm_id ")
        sb.AppendLine("LEFT JOIN c_kkbn kkbn ON kykh.kkbn_id = kkbn.kkbn_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykh.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
        sb.AppendLine("LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_bcat h_bcat ON haif.h_bcat_id = h_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_hkmk hkmk ON haif.hkmk_id = hkmk.hkmk_id ")
        sb.AppendLine("LEFT JOIN m_shho shho ON kykh.shho_3_id = shho.shho_id ")    ' todo 第3回以降の支払方法で良いの？

        ' --- 検索条件 (WHERE) ---
        ' テキストボックスに入力があれば、契約番号で検索
        ' todo 集計月、開始日、終了日、中途解約日で条件増えるはず
        If txt_SEARCH.Text.Trim() <> "" Then
            sb.AppendLine("WHERE kykm.kykm_id LIKE @search ")
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
        dgv_LIST.FormatColumn("当月計上額_税抜き", FMT_CURRENCY)
        dgv_LIST.FormatColumn("当月計上額_消費税", FMT_CURRENCY)
        dgv_LIST.FormatColumn("当月計上額_税込み", FMT_CURRENCY)

        dgv_LIST.FormatColumn("開始日", FMT_DATE)
        dgv_LIST.FormatColumn("終了日", FMT_DATE)
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