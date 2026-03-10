Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports LeaseM4BS.DataAccess

Partial Public Class Form_BuknEntry
    Inherits Form

    Public Property KykmId As Double = 0
    Public Property KykhId As Double = 0

    Private _crud As CrudHelper = New CrudHelper()

    ' コンストラクタ
    Public Sub New()
        InitializeComponent()
    End Sub

    ' -------------------------------------------------------------------------
    ' フォームロード時の処理
    ' -------------------------------------------------------------------------
    Private Sub FrmBuknEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BindCombos()

            ' 画面の初期化
            If KykmId > 0 Then
                LoadBuknById(KykmId)
            End If
        Catch ex As Exception
            MessageBox.Show("初期化エラー: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' マスタデータのロード
    ' -------------------------------------------------------------------------
    Private Sub BindCombos()
        Dim _crud As New CrudHelper()

        ' 計上区分 (KJKBN)
        Dim sqlKjkbn = "SELECT * FROM c_kjkbn WHERE kjkbn_id <> 0 ORDER BY kjkbn_id;"

        cmb_KJKBN_ID.Bind(sqlKjkbn, "kjkbn_nm", "kjkbn_id")
        cmb_KJKBN_ID.SelectedIndex = -1

        ' 消費税計上区分
        Dim sqlSzeiKjkbn = "SELECT * FROM c_szei_kjkbn WHERE szei_kjkbn_id <> 0 ORDER BY szei_kjkbn_id;"

        cmb_SZEI_KJKBN_ID.Bind(sqlSzeiKjkbn, "szei_kjkbn_nm", "szei_kjkbn_id")
        cmb_SZEI_KJKBN_ID.SelectedIndex = -1

        ' 償却方法
        Dim sqlSkyakHo = "SELECT * FROM c_skyak_ho WHERE skyak_ho_id <> 0 ORDER BY skyak_ho_id;"

        cmb_SKYAK_HO_ID.Bind(sqlSkyakHo, "skyak_ho_nm", "skyak_ho_id")
        cmb_SKYAK_HO_ID.SelectedIndex = -1

        ' 資産区分、物件種別
        Dim sqlBkind = "SELECT * FROM m_bkind WHERE bkind_id <> 0 ORDER BY bkind_cd;"

        cmb_SKMK_ID.Bind(sqlBkind, "bkind_cd", "bkind_id")
        cmb_BKIND_ID.Bind(sqlBkind, "bkind_cd", "bkind_id")

        cmb_SKMK_ID.AdjustSize()
        cmb_BKIND_ID.AdjustSize()
        cmb_SKMK_ID.SelectedIndex = -1
        cmb_BKIND_ID.SelectedIndex = -1

        ' 購入先
        Dim sqlGsha = "SELECT * FROM m_gsha ORDER BY gsha_cd;"

        cmb_GSHA_ID.Bind(sqlGsha, "gsha_cd", "gsha_id")
        cmb_GSHA_ID.AdjustSize()
        cmb_GSHA_ID.SelectedIndex = -1

        ' メーカー
        Dim sqlMcpt = "SELECT * FROM m_mcpt WHERE mcpt_id <> 0 ORDER BY mcpt_cd;"

        cmb_MCPT_ID.Bind(sqlMcpt, "mcpt_cd", "mcpt_id")
        cmb_MCPT_ID.AdjustSize()
        cmb_MCPT_ID.SelectedIndex = -1

        ' 物件予備
        Dim sqlRsrvb1 = "SELECT * FROM m_rsrvb1 WHERE rsrvb1_id <> 0 ORDER BY rsrvb1_id;"

        cmb_RSRVB1_ID.Bind(sqlRsrvb1, "rsrvb1_cd", "rsrvb1_nm")
        cmb_RSRVB1_ID.AdjustSize()
        cmb_RSRVB1_ID.SelectedIndex = -1

        ' 管理部署、旧
        Dim sqlBcat = "SELECT * FROM m_bcat WHERE bcat_id <> 0 ORDER BY bcat1_cd;"

        cmb_BCAT_ID.Bind(sqlBcat, "bcat1_cd", "bcat_id")
        cmb_OLDBCAT_ID.Bind(sqlBcat, "bcat1_cd", "bcat_id")

        cmb_BCAT_ID.AdjustSize()
        cmb_OLDBCAT_ID.AdjustSize()
        cmb_BCAT_ID.SelectedIndex = -1
        cmb_OLDBCAT_ID.SelectedIndex = -1
    End Sub

    ' =========================================================
    '  外部（一覧画面）から呼び出されるメソッド
    ' =========================================================
    Public Sub LoadBuknById(kykmId As Double)
        ' 1. IDを画面のタグなどに保存（修正ボタンなどで使うため）
        txt_KYKM_NO.Tag = kykmId

        ' 2. データベースからこのIDのデータを取得して表示
        ' ※以前作った LoadContractData は「番号(String)」で検索するものでした。
        '   ここでは「ID(Double)」で検索するロジックが必要です。

        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM d_kykm WHERE kykm_id = @kykmid"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@kykmid", kykmId)
            }

            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                txt_KYKM_NO.SetText(row("kykm_no"))                ' 物件No

                txt_KEDABAN.SetText(row("b_kedaban"))              ' 枝番 
                txt_BUKN_BANGO.SetText(row("bukn_bango1"))         ' 資産番号1
                txt_BUKN_BANGO2.SetText(row("bukn_bango2"))        ' 資産番号2
                txt_BUKN_BANGO3.SetText(row("bukn_bango3"))        ' 資産番号3
                txt_TAIYO_NEN.SetText(row("taiyo_nen") * 12)       ' 償却期間(月単位に)
                txt_BUKN_NM.SetText(row("bukn_nm"))                ' 物件名称
                txt_SUURYO.SetText(row("b_suuryo"))                ' 数量

                ' 金額
                txt_KNYUKN.SetAmount(row("b_knyukn"))              ' 購入価額
                txt_GLSRYO.SetAmount(row("b_glsryo"))              ' 月額リース料
                txt_KLSRYO.SetAmount(row("b_klsryo"))              ' 1支払額
                txt_MLSRYO.SetAmount(row("b_mlsryo"))              ' 前払リース料
                txt_SLSRYO.SetAmount(row("b_slsryo"))              ' 総額

                txt_GZEI.SetAmount(row("b_gzei"))                  ' 月額税
                txt_KZEI.SetAmount(row("b_kzei"))                  ' 1支払税
                txt_MZEI.SetAmount(row("b_mzei"))                  ' 前払税

                txt_GLSRYO_ZKOMI.SetAmount(row("b_glsryo_zkomi"))  ' 月額リース料(税込)
                txt_KLSRYO_ZKOMI.SetAmount(row("b_klsryo_zkomi"))  ' 1支払額(税込)
                txt_MLSRYO_ZKOMI.SetAmount(row("b_mlsryo_zkomi"))  ' 前払リース料(税込)

                ' 備考
                txt_ZOKUSEI1.SetText(row("b_zokusei1"))            ' 備考1
                txt_ZOKUSEI2.SetText(row("b_zokusei2"))            ' 備考2
                txt_ZOKUSEI3.SetText(row("b_zokusei3"))            ' 備考3
                txt_ZOKUSEI4.SetText(row("b_zokusei4"))            ' 備考4

                ' ID系
                cmb_KJKBN_ID.SelectedValue = row("kjkbn_id")                ' 計上区分
                cmb_SZEI_KJKBN_ID.SelectedValue = row("szei_kjkbn_id")      ' 消費税計上区分
                cmb_SKYAK_HO_ID.SelectedValue = row("skyak_ho_id")          ' 償却期間
                cmb_SKMK_ID.SelectedValue = row("skmk_id")                 ' 資産区分
                cmb_GSHA_ID.SelectedValue = row("k_gsha_id")                ' 購入先
                cmb_MCPT_ID.SelectedValue = row("mcpt_id")                  ' メーカー
                cmb_RSRVB1_ID.SelectedValue = row("rsrvb1_id")              ' 物件予備
                cmb_BCAT_ID.SelectedValue = row("b_bcat_id")                ' 管理部署


                ' コンボボックスの設定
                Dim cmbBcat = DirectCast(dgv_DETAILS.Columns("cmb_BCAT1_NM"), DataGridViewComboBoxColumn)

                Dim sqlBcat As String = "SELECT * FROM m_bcat WHERE bcat_id <> 0 ORDER BY bcat1_cd;"
                cmbBcat.Bind(sqlBcat, "bcat1_nm", "bcat1_cd")

                Dim cmbHiyokbn = DirectCast(dgv_DETAILS.Columns("cmb_HIYOKBN_NM"), DataGridViewComboBoxColumn)

                Dim sqlHiyokbn As String = "SELECT * FROM m_hkmk WHERE hkmk_id <> 0 ORDER BY hkmk_id;"
                cmbHiyokbn.Bind(sqlHiyokbn, "hkmk_nm", "hkmk_cd")

                ' 配賦率
                AddFirstHaif(kykmId)
            End If

        Catch ex As Exception
            MessageBox.Show("詳細読込エラー: " & ex.Message)
        End Try
    End Sub

    ' todo 適切なメソッド名
    Private Sub SyncDgvComboToText(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DETAILS.CellValueChanged
        ' ヘッダーや、コンボボックス以外の列の場合は抜ける
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgv_DETAILS.Rows(e.RowIndex)

        ' 対象のコンボボックス列かチェック
        Select Case dgv_DETAILS.Columns(e.ColumnIndex).Name
            Case "cmb_BCAT1_NM"
                ' 選択された現在のセルを取得
                Dim comboCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_BCAT1_CD").Value = comboCell.Value.ToString()

            Case "cmb_HIYOKBN_NM"
                ' 選択された現在のセルを取得
                Dim comboCell = DirectCast(row.Cells(e.ColumnIndex), DataGridViewComboBoxCell)

                ' テキストボックスを書き換え
                row.Cells("col_HIYOKBN_CD").Value = comboCell.Value.ToString()

            Case "col_Haif_RATE"
                ReCalculateRowAmounts(e.RowIndex)
        End Select
    End Sub

    Private Sub AddFirstHaif(kykmId As Double)
        If dgv_DETAILS.Rows.Count <> 0 Then Return

        ' --- ヘッダ取得 (ID指定) ---
        Dim sql As String = "SELECT * FROM d_kykm " &
                                "INNER JOIN m_bcat ON d_kykm.b_bcat_id = m_bcat.bcat_id " &
                                "INNER JOIN m_hkmk ON d_kykm.f_hkmk_id = m_hkmk.hkmk_id " &
                                "WHERE kykm_id = @kykmid;"

        Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
            New Npgsql.NpgsqlParameter("@kykmid", kykmId)
        }

        Dim dt As DataTable = _crud.GetDataTable(sql, prm)

        Dim row As DataRow = dt.Rows(0)

        ' --- 配賦率 ---
        dgv_DETAILS.Rows.Add(
            "100",                                  ' 配賦率(%)
            ToCurrency(row("b_klsryo")),            ' 1支払額
            ToCurrency(row("b_mlsryo")),            ' 前払
            row("bcat1_cd").ToString(),             ' 費用負担部署cd
            row("bcat1_cd").ToString(),             ' 費用負担部署名(なぜか引数はbcat1_cd)
            row("hkmk_cd").ToString(),              ' 費用区分cd
            row("hkmk_nm").ToString(),              ' 費用区分名
            ToCurrency(row("b_kzei")),              ' 1支払税
            ToCurrency(row("b_mzei")),              ' 前払税
            row("b_zokusei1").ToString()            ' 備考
            )
    End Sub

    Private Sub AddHaif(sender As Object, e As EventArgs) Handles cmd_ADD_HAIF.Click
        If dgv_DETAILS.Rows.Count = 0 Then
            AddFirstHaif(txt_KYKM_NO.Tag)
            Return
        End If

        Dim HaifRate = 100 - CalculateTotalHaifRate()

        Dim rowIndex = dgv_DETAILS.Rows.Add(HaifRate.ToString())
        ReCalculateRowAmounts(rowIndex)

    End Sub

    Private Sub RemoveHaif(sender As Object, e As EventArgs) Handles cmd_REMOVE_HAIF.Click
        Dim lastIndex = dgv_DETAILS.Rows.Count - 1

        If lastIndex >= 0 Then
            dgv_DETAILS.Rows.RemoveAt(lastIndex)
        End If
    End Sub

    Private Function CalculateTotalHaifRate() As Integer
        Dim total As Integer = 0

        For Each row In dgv_DETAILS.Rows
            total += row.Cells("col_HAIF_RATE").Value
        Next

        Return total
    End Function

    Private Sub ReCalculateRowAmounts(rowIndex As Integer)
        If rowIndex < 0 OrElse rowIndex >= dgv_DETAILS.Rows.Count Then Return

        Dim row As DataGridViewRow = dgv_DETAILS.Rows(rowIndex)

        Dim HaifRate = Decimal.Parse(row.Cells("col_Haif_RATE").Value)
        Dim klsryo = Decimal.Parse(txt_KLSRYO.Text)
        Dim kzei = Decimal.Parse(txt_KZEI.Text)

        row.Cells("col_KLSRYO").Value = Math.Floor(klsryo * HaifRate / 100).ToString()
        row.Cells("col_KZEI").Value = Math.Floor(kzei * HaifRate / 100).ToString()
        row.Cells("col_MLSRYO").Value = ""
        row.Cells("col_MZEI").Value = ""
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' [削除]ボタン
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        If MessageBox.Show("物件を削除してもよろしいですか？", "削除確認", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        ' todo 削除処理

        MessageBox.Show("削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_BKIND_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_SKMK_ID.DrawItem, cmb_BKIND_ID.DrawItem
        Combo_DrawItem(sender, e, {"bkind_cd", "bkind_nm"})
    End Sub

    Private Sub Combo_GSHA_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_GSHA_ID.DrawItem
        Combo_DrawItem(sender, e, {"gsha_cd", "gsha_nm"})
    End Sub

    Private Sub Combo_MCPT_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_MCPT_ID.DrawItem
        Combo_DrawItem(sender, e, {"mcpt_cd", "mcpt_nm"})
    End Sub

    Private Sub Combo_RSRVB1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_RSRVB1_ID.DrawItem
        Combo_DrawItem(sender, e, {"rsrvb1_cd", "rsrvb1_nm"})
    End Sub

    Private Sub Combo_BCAT_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_BCAT_ID.DrawItem, cmb_OLDBCAT_ID.DrawItem
        Combo_DrawItem(sender, e, {"bcat1_cd", "bcat1_nm", "bcat2_nm", "bcat3_nm", "bcat4_nm", "bcat5_nm"})
    End Sub

    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================

    ' 資産区分が変わったら
    Private Sub cmb_SKMK_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SKMK_ID.SelectedIndexChanged
        cmb_SKMK_ID.SyncTo("bkind_nm", txt_SKMK_NM)
    End Sub

    Private Sub cmb_BKIND_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BKIND_ID.SelectedIndexChanged
        cmb_BKIND_ID.SyncTo("bkind_nm", txt_BKIND_NM)
    End Sub

    Private Sub cmb_GSHA_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_GSHA_ID.SelectedIndexChanged
        cmb_GSHA_ID.SyncTo("gsha_nm", txt_GSHA_NM)
    End Sub

    Private Sub cmb_MCPT_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_MCPT_ID.SelectedIndexChanged
        cmb_MCPT_ID.SyncTo("mcpt_nm", txt_MCPT_NM)
    End Sub

    Private Sub cmb_RSRVB1_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_RSRVB1_ID.SelectedIndexChanged
        cmb_RSRVB1_ID.SyncTo("rsrvb1_nm", txt_RSRVB1_NM)
    End Sub

    Private Sub cmb_BCAT_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BCAT_ID.SelectedIndexChanged
        cmb_BCAT_ID.SyncTo("bcat1_nm", txt_BCAT1_NM)
        cmb_BCAT_ID.SyncTo("bcat2_nm", txt_BCAT2_NM)
        cmb_BCAT_ID.SyncTo("bcat3_nm", txt_BCAT3_NM)
        cmb_BCAT_ID.SyncTo("bcat4_nm", txt_BCAT4_NM)
        cmb_BCAT_ID.SyncTo("bcat5_nm", txt_BCAT5_NM)
    End Sub

    Private Sub cmb_OLDBCAT_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_OLDBCAT_ID.SelectedIndexChanged
        cmb_OLDBCAT_ID.SyncTo("bcat1_nm", txt_OLDBCAT1_NM)
        cmb_OLDBCAT_ID.SyncTo("bcat2_nm", txt_OLDBCAT2_NM)
        cmb_OLDBCAT_ID.SyncTo("bcat3_nm", txt_OLDBCAT3_NM)
        cmb_OLDBCAT_ID.SyncTo("bcat4_nm", txt_OLDBCAT4_NM)
        cmb_OLDBCAT_ID.SyncTo("bcat5_nm", txt_OLDBCAT5_NM)
    End Sub
End Class