Imports System.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Enum OmissionCriteria
    Follow      ' 従う(注記)
    Ignore      ' 無視する(注記、省略、資産)
    Omission    ' 省略物件のみ(省略)
End Enum

Partial Public Class Form_f_flx_CHUKI
    Inherits Form

    Public Property LabelText As String
    Public Property WhereClause As String
    Public Property Prms As List(Of NpgsqlParameter)

    Private Const FMT_CURRENCY As String = "#,##0"
    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_CHUKI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_CONDITION.Text = LabelText

        SearchData()
    End Sub

    Private Sub SearchData()
        Try
            Dim sql = BuildSql(Prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            dgv_LIST.DataSource = _crud.GetDataTable(sql, Prms)

            ApplyGridStyle()

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(ByRef prms As List(Of NpgsqlParameter))
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
        sb.AppendLine("  LEAST(kykm.b_knyukn, kykm.b_gnzai_kt) AS 取得価額相当額, ")
        ' sb.AppendLine(" AS 減価償却累計額相当額, ")        ' todo
        ' sb.AppendLine(" AS 減損損失累計額相当額, ")
        ' sb.AppendLine(" AS 期末残高相当額, ")
        ' sb.AppendLine(" AS 未経過リース料期末残高相当額(1年内), ")
        ' sb.AppendLine(" AS 未経過リース料期末残高相当額(1年超), ")
        ' sb.AppendLine(" AS 未経過リース料期末残高相当額(合計), ")
        ' sb.AppendLine(" AS リース資産減損勘定の残高, ")
        ' sb.AppendLine(" AS 当期支払リース料, ")
        ' sb.AppendLine(" AS リース資産減損勘定の取崩額, ")
        ' sb.AppendLine(" AS 減価償却費相当額, ")
        ' sb.AppendLine(" AS 支払利息相当額, ")
        ' sb.AppendLine(" AS 減損損失の金額, ")
        sb.AppendLine("kykm.b_knyukn AS 現金購入価額, ")
        ' sb.AppendLine(" AS 増加・取得価額, ")
        ' sb.AppendLine(" AS 減少・償却累計, ")
        sb.AppendLine("kykm.b_slsryo AS 総額リース料, ")
        ' sb.AppendLine(" AS 減少・取得価額, ")
        ' sb.AppendLine(" AS 減少・損失累計, ")
        sb.AppendLine("chu_hnti.chu_hnti_nm AS 注記判定結果, ")
        sb.AppendLine("chuum.chuum_nm AS 注記or省略 ")

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN c_leakbn leakbn ON kykm.leakbn_id = leakbn.leakbn_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN m_skmk skmk ON kykm.skmk_id = skmk.skmk_id ")
        sb.AppendLine("LEFT JOIN m_bkind bkind ON kykm.bkind_id = bkind.bkind_id ")
        sb.AppendLine("LEFT JOIN c_chu_hnti chu_hnti ON kykm.chu_hnti_id = chu_hnti.chu_hnti_id ")
        sb.AppendLine("LEFT JOIN c_chuum chuum ON kykm.chuum_id = chuum.chuum_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
        sb.AppendLine("LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id ")

        sb.AppendLine(WhereClause)

        sb.AppendLine("ORDER BY kykm.kykm_no")

        Return sb.ToString()
    End Function

    Private Sub ApplyGridStyle()
        dgv_LIST.HideColumns("kykm_id", "kykh_id")

        dgv_LIST.FormatColumn("取得価額相当額", FMT_CURRENCY)
        dgv_LIST.FormatColumn("現金購入価額", FMT_CURRENCY)
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [再計算]ボタン
    Private Sub cmd_RECALCULATE_Click(sender As Object, e As EventArgs) Handles cmd_RECALCULATE.Click
        Me.Close()
    End Sub

    ' [様式集計]ボタン
    Private Sub cmd_YOUSHIKI_Click(sender As Object, e As EventArgs) Handles cmd_YOUSHIKI.Click
        Dim frm As New Form_f_CHUKI_YOUSHIKI()

        frm.ShowDialog()
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
    Private Sub cmd_Output_Click(sender As Object, e As EventArgs) Handles cmd_Output.Click
        Dim frm As New Form_f_FlexOutputDLG

        frm.Dgv = dgv_LIST
        frm.ShowDialog()
    End Sub

    ' [検索]ボタン
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        SearchData()
    End Sub

    ' エンターキーが押されたら次のコントロールへ遷移
    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        HandleEnterKeyNavigation(Me, e)
    End Sub
End Class