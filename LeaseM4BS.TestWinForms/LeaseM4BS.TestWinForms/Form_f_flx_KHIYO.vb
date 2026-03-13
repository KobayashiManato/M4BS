Imports System.Text
Imports System.Windows.Forms
Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Enum RecTiming
    SmdtBase    '〆日ベース
    ShdtBase    ' 約定支払日ベース
End Enum

Public Enum Symbol
    Minus
    Plus
End Enum

Partial Public Class Form_f_flx_KHIYO
    Inherits Form

    Public Property DtFrom As Date
    Public Property DtTo As Date
    Public Property NextDtTo As Date
    Public Property RecBase As RecTiming
    Public Property CheckRecFlags As Boolean() = New Boolean(6) {}
    Public Property RadioSymbol As Symbol

    Private Const FMT_CURRENCY As String = "#,##0"
    Private _crud As New CrudHelper()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_flx_KHIYO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_CONDITION.Text = GetLabelText()

        SearchData()
    End Sub

    Private Sub SearchData()
        Try
            Dim prms As New List(Of NpgsqlParameter)
            Dim sql = BuildSql(txt_SEARCH.Text.Trim(), prms)

            dgv_LIST.Columns.Clear()
            dgv_LIST.AutoGenerateColumns = True

            ' todo グレーアウトの条件を探す(Access版はグレーアウト行がある。条件不明)
            dgv_LIST.DataSource = _crud.GetDataTable(sql, prms)

            ApplyGridStyle()

        Catch ex As Exception
            MessageBox.Show("一覧取得エラー: " & ex.Message)
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Function BuildSql(searchText As String, ByRef prms As List(Of NpgsqlParameter)) As String
        Dim selectPart1 As String = "kykm.kykm_id, " &                      ' 契約明細ID(D_KYKM)
                                    "kykh.kykh_id, " &                      ' 契約ID(D_KYKH)
                                    "kykm.kykm_no AS 物件No, " &            ' 契約明細No(D_KYKM)
                                    "haif.line_id AS 配No, " &              ' 配賦行No(D_HAIF)
                                    "kjkbn.kjkbn_nm AS 計上区分, "          ' 計上区分(C_KJKBN)

        Dim selectPart2 As String = "kykh.kykbnl AS 契約番号, " &           ' 契約番号(D_KYKH)
                                    "lcpt.lcpt1_nm AS 支払先, " &           ' 支払先(M_LCPT)
                                    "kykm.bukn_nm AS 物件名, " &            ' 物件名(D_KYKM)
                                    "b_bcat.bcat1_nm AS 管理部署, " &       ' 管理部署(M_BCAT)
                                    "h_bcat.bcat1_nm AS 費用負担部署, " &   ' 費用負担部署(M_BCAT)
                                    "haif.haifritu AS 配賦率, " &           ' 配賦率(D_HAIF)
                                    "kykh.start_dt AS 開始日, " &           ' 開始日(D_KYKH)
                                    "kykh.end_dt AS 終了日, " &             ' 終了日(D_KYKH)
                                    "kykh.lkikan AS 期間, " &               ' 契約期間(D_KYKH)
                                    "kykm.ckaiyk_dt AS 中途解約日, "        ' 中途解約日(D_KYKM)

        Dim fromClause As String = "FROM d_kykm kykm " &
                                   "LEFT JOIN d_kykh kykh ON kykm.kykh_id = kykh.kykh_id " &
                                   "LEFT JOIN d_haif haif ON kykm.kykm_id = haif.kykm_id " &
                                   "LEFT JOIN c_kjkbn kjkbn ON kykm.kjkbn_id = kjkbn.kjkbn_id " &
                                   "LEFT JOIN m_lcpt lcpt ON kykh.lcpt_id = lcpt.lcpt_id " &
                                   "LEFT JOIN m_bcat b_bcat ON kykm.b_bcat_id = b_bcat.bcat_id " &
                                   "LEFT JOIN m_bcat h_bcat ON haif.h_bcat_id = h_bcat.bcat_id "

        Dim whereClause As String = "WHERE ((kykh.start_dt <= @NextDtTo AND kykh.end_dt <= @dtFrom) " &
                                    "OR (kykm.b_shdt_fst_sum BETWEEN @dtFrom AND @dtTo))"

        prms.Add(New NpgsqlParameter("@dtFrom", GetMonthStart(DtFrom)))
        prms.Add(New NpgsqlParameter("@dtTo", GetMonthEnd(DtTo)))
        prms.Add(New NpgsqlParameter("@NextDtTo", GetMonthEnd(NextDtTo)))

        If searchText <> "" Then
            whereClause &= "WHERE kykm.kykm_no = @search "
            prms.Add(New NpgsqlParameter("@search", Double.Parse(txt_SEARCH.Text.Trim())))
        End If

        Dim sqls As New List(Of String)

        If CheckRecFlags(0) Then
            Dim sql1 As String = "SELECT " &
                                  selectPart1 &
                                  "'支払額' AS 行区, " &
                                  selectPart2 &
                                  "haif.h_klsryo AS 期間計上額 " &
                                  fromClause &
                                  whereClause &
                                  "AND kykm.kjkbn_id = 1"

            sqls.Add(sql1)
        End If

        If CheckRecFlags(1) Then
            Dim sql2 As String = "SELECT " &
                                 selectPart1 &
                                 "'保守料' AS 行区, " &
                                 selectPart2 &
                                 "haif.h_klsryo AS 期間計上額 " &
                                 fromClause &
                                 whereClause                        ' todo
        End If

        If CheckRecFlags(2) Then
            Dim sql3 As String = "SELECT " &
                                 selectPart1 &
                                 "'償却費' AS 行区, " &
                                 selectPart2 &
                                 "kykm.b_syutok AS 期間計上額 " &
                                 fromClause &
                                 whereClause &
                                 "AND kykm.kjkbn_id = 2"    ' todo WHERE句不明

            sqls.Add(sql3)
        End If

        If CheckRecFlags(3) Then
            Dim sql4 As String = "SELECT " &
                                 selectPart1 &
                                 "'支払利息' AS 行区, " &
                                 selectPart2 &
                                 "(kykm.b_slsryo - kykm.b_knyukn) AS 期間計上額 " &     ' todo 計算方法不明
                                 fromClause &
                                 whereClause &
                                 "AND kykm.kjkbn_id = 2 AND kykm.kari_ritu_ms_f = True "

            If RecBase = RecTiming.SmdtBase Then
                sql4 &= "AND kykm.b_smdt_fst_sum <= @dtTo"
            Else
                sql4 &= "AND kykm.b_shdt_fst_sum <= @dtTo"
            End If

            sqls.Add(sql4)
        End If

        If CheckRecFlags(4) Then
            Dim sql5 As String = "SELECT " &
                                 selectPart1 &
                                 "'維持管理費用' AS 行区, " &
                                 selectPart2 &
                                 "(kykm.b_ijiknr * 1) AS 期間計上額 " &                  ' todo 集計期間から割合算出
                                 fromClause &
                                 whereClause &
                                 "AND kykm.b_ijiknr IS NOT NULL"

            sqls.Add(sql5)
        End If

        If CheckRecFlags(5) Then
            Dim sql6 As String = "SELECT " &
                                 selectPart1 &
                                 "'減損損失' AS 行区, " &
                                 selectPart2 &
                                 "haif.h_klsryo AS 期間計上額 " &                          ' todo テストデータになくて分からない
                                 fromClause &
                                 whereClause &
                                 "AND kykm.b_gson_f = True"

            sqls.Add(sql6)
        End If

        If CheckRecFlags(6) Then
            Dim sql7 As String = "SELECT " &
                                 selectPart1 &
                                 "'減損勘定取崩額' AS 行区, " &
                                 selectPart2 &
                                 "haif.h_klsryo AS 期間計上額 " &                         ' todo テストデータになくて分からない
                                 fromClause &
                                 whereClause &
                                 "AND kykm.b_gson_f = True"

            sqls.Add(sql7)
        End If

        Dim sql = String.Join(" UNION ALL ", sqls)

        sql &= " "
        sql &= "ORDER BY kykm_id;"   'kykm.にするとエラーが出る

        Return sql
    End Function

    Private Sub ApplyGridStyle()
        dgv_LIST.HideColumns("kykm_id", "kykh_id")

        dgv_LIST.FormatColumn("期間計上額", FMT_CURRENCY)
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' ラベルテキストを生成
    Private Function GetLabelText()
        ' 移動日
        Dim labelText As String = "移動日:　" & DtFrom.ToString("yyyy/MM") & "～" & DtTo.ToString("yyyy/MM")

        ' 出力対象
        If CheckRecFlags(0) Then
            labelText &= "　支払額"
        End If

        If CheckRecFlags(1) Then
            labelText &= "　保守料"
        End If

        If CheckRecFlags(2) Then
            labelText &= "　償却費"
        End If

        If CheckRecFlags(3) Then
            labelText &= "　支払利息"
        End If

        If CheckRecFlags(4) Then
            labelText &= "　維持管理費用"
        End If

        If CheckRecFlags(5) Then
            labelText &= "　減損損失"
        End If

        If CheckRecFlags(6) Then
            labelText &= "　減損勘定取崩額"
        End If

        If RadioSymbol = Symbol.Minus Then
            labelText &= "　マイナス金額"
        Else
            labelText &= "　プラス金額"
        End If

        Return labelText
    End Function

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

        Dim frmBukn As New Form_BuknEntry

        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)
        frmBukn.ShowDialog()

        Dim frmContract As New Form_ContractEntry

        frmContract.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)
        frmContract.ShowDialog()
    End Sub

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then
            Return
        End If

        Dim frmBukn As New Form_BuknEntry

        frmBukn.KykmId = Convert.ToDouble(selectedRow.Cells("kykm_id").Value)
        frmBukn.ShowDialog()

        Dim frmContract As New Form_ContractEntry

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

    Private Sub AddRecConditions(ByRef sb As StringBuilder)
        ' Trueが1つもなければReturn
        If CheckRecFlags Is Nothing OrElse Not CheckRecFlags.Any(Function(f) f = True) Then
            Return
        End If

        Dim whereClause = "AND ("
        Dim trueList = New List(Of String)

        ' 1. 支払額
        If CheckRecFlags(0) Then
            trueList.Add("kykm.kjkbn_id = 1")
        End If

        ' 3. 償却費
        If CheckRecFlags(2) Then
            trueList.Add("kykm.kjkbn_id = 2 AND kykm.taiyo_nen_ms_f = -1")
        End If

        ' 4. 支払利息
        If CheckRecFlags(3) Then
        End If

        ' 5. 維持管理費用
        If CheckRecFlags(4) Then
            trueList.Add("kykm.kjkbn_id = 2 AND kykm.ijiknr IS NOT NULL")
        End If

        ' 6, 7. 減損
        If CheckRecFlags(5) OrElse CheckRecFlags(6) Then
            trueList.Add("kykm.b_gson_f = True")
        End If

        ' ORで結合
        sb.AppendLine($"AND ( {String.Join(" OR ", trueList)} )")
    End Sub
End Class