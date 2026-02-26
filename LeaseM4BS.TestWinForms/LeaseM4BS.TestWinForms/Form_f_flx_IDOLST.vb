Imports System.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class Form_f_flx_IDOLST
    Inherits Form

    Public Property LabelText As String
    Public Property DtFrom As Date
    Public Property DtTo As Date
    Public Property CheckBcatFlags As Boolean() = New Boolean(4) {}

    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_IDOLST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ' --- グリッドの見た目調整 ---
            dgv_LIST.HideColumns("kykm_id", "kykh_id")

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
        End Try
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter)) As String
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("SELECT ")
        sb.AppendLine("  kykm.kykm_id, ")
        sb.AppendLine("  kykh.kykh_id, ")
        sb.AppendLine("  kykm.kykm_no AS 物件No, ")
        sb.AppendLine("  kjkbn.kjkbn_nm AS 計上区分, ")
        sb.AppendLine("  kykm.bukn_bango1 AS 資産番号1, ")
        sb.AppendLine("  kykm.bukn_nm AS 物件名, ")
        sb.AppendLine("  kykm.ido_dt AS 移動日, ")
        sb.AppendLine("  b_bcat.bcat1_nm AS 管理部署1, ")
        sb.AppendLine("  b_bcat.bcat2_nm AS 管理部署2, ")
        sb.AppendLine("  b_bcat.bcat3_nm AS 管理部署3, ")
        sb.AppendLine("  b_bcat.bcat4_nm AS 管理部署4, ")
        sb.AppendLine("  b_bcat.bcat5_nm AS 管理部署5, ")
        sb.AppendLine("  r1_bcat.bcat1_nm AS 移動前・管理部署1, ")
        sb.AppendLine("  r1_bcat.bcat2_nm AS 移動前・管理部署2, ")
        sb.AppendLine("  r1_bcat.bcat3_nm AS 移動前・管理部署3, ")
        sb.AppendLine("  r1_bcat.bcat4_nm AS 移動前・管理部署4, ")
        sb.AppendLine("  r1_bcat.bcat5_nm AS 移動前・管理部署5, ")
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
        sb.AppendLine("  kykm.b_zokusei1 AS 備考 ")

        sb.AppendLine("FROM d_kykm kykm ")
        sb.AppendLine("LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id ")
        sb.AppendLine("LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id ")
        sb.AppendLine("LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_bcat r1_bcat ON kykm.b_bcat_id_r1 = r1_bcat.bcat_id ")
        sb.AppendLine("LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id ")
        sb.AppendLine("WHERE kykm.ido_dt >= @dtFrom AND kykm.ido_dt <= @dtTo ")

        ' CheckBcatFlagsの状態を条件式に反映
        sb.AppendLine(GetBcatConditions())

        prms.Add(New NpgsqlParameter("@dtFrom", DtFrom))
        prms.Add(New NpgsqlParameter("@dtTo", DtTo))

        If searchText <> "" Then
            sb.AppendLine("AND kykm.kykm_no = @search ")
            prms.Add(New NpgsqlParameter("@search", Double.Parse(searchText)))
        End If

        sb.AppendLine("ORDER BY kykm.kykm_id;")

        Return sb.ToString()
    End Function

    ' [閉じるボタン]
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

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then Return

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

    Private Function GetBcatConditions() As String
        ' Trueが1つもなければReturn
        If CheckBcatFlags Is Nothing OrElse Not CheckBcatFlags.Any(Function(f) f = True) Then
            Return String.Empty
        End If

        Dim trueList = New List(Of String)

        For i As Integer = 0 To CheckBcatFlags.Length - 1
            If CheckBcatFlags(i) Then
                ' 部署コードがnullの行も出力(Access版に準拠)
                trueList.Add($"b_bcat.bcat{i + 1}_cd <> r1_bcat.bcat{i + 1}_cd OR b_bcat.bcat{i + 1}_cd IS NULL OR r1_bcat.bcat{i + 1}_cd IS NULL")
            End If
        Next

        ' ORで結合
        Return $"AND ( {String.Join(" OR ", trueList)} )"
    End Function
End Class