Imports LeaseM4BS.DataAccess
Imports Npgsql

Partial Public Class FrmBuknList
    Inherits Form

    Private Sub FrmPropertyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初期表示：全件検索
        SearchData()
    End Sub

    ' ---------------------------------------------------------
    ' データ検索・一覧表示機能
    ' ---------------------------------------------------------
    Private Sub SearchData()
        Dim _crud As New crudHelper()
        Try
            ' todo: 項目が正しいか確認
            Dim sb As New System.Text.StringBuilder()

            sb.AppendLine("SELECT DISTINCT ON (d_kykm.kykm_no) ")
            sb.AppendLine("  d_kykm.kykm_id, ")
            sb.AppendLine("  d_kykh.kykh_id, ")
            sb.AppendLine("  d_kykm.kykm_no AS 物件No, ")
            sb.AppendLine("  c_kjkbn.kjkbn_nm AS 計上区分, ")
            sb.AppendLine("  d_kykm.saikaisu AS 再リース回数, ")
            sb.AppendLine("  d_kykm.bukn_bango1 AS 資産番号1, ")
            sb.AppendLine("  m_lcpt.lcpt1_nm AS 支払先, ")
            sb.AppendLine("  d_kykh.kykbnl AS 契約番号, ")
            sb.AppendLine("  d_kykh.kykbnj AS 自社管理番号, ")
            sb.AppendLine("  d_kykh.rng_bango AS 稟議番号, ")
            sb.AppendLine("  d_kykm.bukn_nm AS 物件名, ")
            sb.AppendLine("  m_kknri.kknri1_nm AS 管理単位, ")
            sb.AppendLine("  m_bcat.bcat1_cd AS 管理部署番号, ")
            sb.AppendLine("  m_bcat.bcat1_nm AS 管理部署, ")
            sb.AppendLine("  d_kykh.start_dt AS 開始日, ")
            sb.AppendLine("  d_kykh.end_dt AS 終了日, ")
            sb.AppendLine("  d_kykm.ckaiyk_dt AS 中途解約日, ")
            sb.AppendLine("  d_kykm.b_knyukn AS 現金購入価額, ")
            sb.AppendLine("  d_kykm.b_slsryo AS 総額リース料, ")
            sb.AppendLine("  d_kykm.b_glsryo AS 月額リース料, ")
            sb.AppendLine("  d_kykm.b_klsryo AS 支払額1, ")
            sb.AppendLine("  d_kykm.b_mlsryo AS 前払リース料, ")
            ' sb.AppendLine(" AS 保守料, ")    ' todo 該当項目不明 
            sb.AppendLine("  m_bkind_shisan.bkind_nm AS 資産区分, ")
            sb.AppendLine("  m_bkind_bukn.bkind_nm AS 物件種別, ")
            sb.AppendLine("  c_leakbn.leakbn_nm AS リース区分, ")
            sb.AppendLine("  c_chu_hnti.chu_hnti_nm AS 注記判定結果, ")
            sb.AppendLine("  c_chuum.chuum_nm AS 注記省略, ")
            sb.AppendLine("  d_kykm.b_zokusei1 AS 備考, ")
            sb.AppendLine("  CASE WHEN d_kykm.b_seigou_f = FALSE THEN 'あり' ELSE NULL END AS 整合 ")

            sb.AppendLine("FROM d_kykm ")
            sb.AppendLine("LEFT JOIN c_kjkbn ON d_kykm.kjkbn_id = c_kjkbn.kjkbn_id ")
            sb.AppendLine("LEFT JOIN d_kykh ON d_kykm.kykh_id = d_kykh.kykh_id ")
            sb.AppendLine("LEFT JOIN m_lcpt ON d_kykh.lcpt_id = m_lcpt.lcpt_id ")
            sb.AppendLine("LEFT JOIN m_kknri ON d_kykh.kknri_id = m_kknri.kknri_id ")
            sb.AppendLine("LEFT JOIN m_bcat ON d_kykm.b_bcat_id = m_bcat.bcat_id ")
            sb.AppendLine("LEFT JOIN m_bkind AS m_bkind_shisan ON d_kykm.skmk_id = m_bkind_shisan.bkind_id ")
            sb.AppendLine("LEFT JOIN m_bkind AS m_bkind_bukn ON d_kykm.bkind_id = m_bkind_bukn.bkind_id")
            sb.AppendLine("LEFT JOIN c_leakbn ON d_kykm.leakbn_id = c_leakbn.leakbn_id ")
            sb.AppendLine("LEFT JOIN c_chu_hnti ON d_kykm.chu_hnti_id = c_chu_hnti.chu_hnti_id ")
            sb.AppendLine("LEFT JOIN c_chuum ON d_kykm.chuum_id = c_chuum.chuum_id ")

            ' --- 検索条件 (WHERE) ---
            ' テキストボックスに入力があれば、契約番号で検索
            If txt_SEARCH.Text.Trim() <> "" Then
                sb.AppendLine("WHERE d_kykh.kykbnj LIKE @search OR d_kykh.kykbnl LIKE @search ")
            End If

            ' kykm_noが重複している場合、kykm_idが最大の行を抽出する
            sb.AppendLine("ORDER BY d_kykm.kykm_no, d_kykm.kykm_id DESC")

            ' パラメータ設定
            Dim prms As New List(Of NpgsqlParameter)
            If txt_SEARCH.Text.Trim() <> "" Then
                prms.Add(New NpgsqlParameter("@search", "%" & txt_SEARCH.Text.Trim() & "%"))
            End If

            ' 1. デザイナーで作った固定列をいったん全部消す（これをしないとSQLの増えた項目が出ません）
            dgv_LIST.Columns.Clear()

            ' 2. 自動生成をONにする
            dgv_LIST.AutoGenerateColumns = True

            ' 3. データをセット（ここで勝手に列が作られます）
            dgv_LIST.DataSource = _crud.GetDataTable(sb.ToString(), prms)

            ' --- グリッドの見た目調整 ---
            ' ID列は隠す
            If dgv_LIST.Columns.Contains("kykm_id") Then
                dgv_LIST.Columns("kykm_id").Visible = False
            End If
            If dgv_LIST.Columns.Contains("kykh_id") Then
                dgv_LIST.Columns("kykh_id").Visible = False
            End If

            ' 金額を通貨形式に
            dgv_LIST.FormatColumn("現金購入価額", "#,##0")
            dgv_LIST.FormatColumn("総額リース料", "#,##0")
            dgv_LIST.FormatColumn("月額リース料", "#,##0")
            dgv_LIST.FormatColumn("支払額1", "#,##0")
            dgv_LIST.FormatColumn("前払リース料", "#,##0")

            ' 日付を短い形式に
            dgv_LIST.FormatColumn("開始日", "yyyy/MM/dd")
            dgv_LIST.FormatColumn("終了日", "yyyy/MM/dd")

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
        ShowSelectedBukn()

        ' 契約書フォームも出力
        Dim frm As New FrmContractEntry()
        frm.KykhId = Convert.ToDouble(dgv_LIST.GetSelectedRow().Cells("kykh_id").Value)
        frm.ShowDialog()
    End Sub

    ' [物件変更] ボタン
    Private Sub cmd_CHANGE_BUKN_Click(sender As Object, e As EventArgs) Handles cmd_CHANGE_BUKN.Click
        ShowSelectedBukn()
    End Sub

    ' [照会] ボタン
    Private Sub cmd_REF_Click(sender As Object, e As EventArgs) Handles cmd_REF.Click
        Dim selectedRow = dgv_LIST.GetSelectedRow()

        If selectedRow Is Nothing Then
            Return
        End If

        ShowSelectedBukn()

        ' 契約書フォームも出力
        Dim frm As New FrmContractEntry()
        frm.KykhId = Convert.ToDouble(selectedRow.Cells("kykh_id").Value)
        frm.ShowDialog()
    End Sub

    ' グリッドのダブルクリック (Accessの txt_KKNRI1_NM_DblClick 相当)
    Private Sub dgv_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_LIST.CellDoubleClick
        If e.RowIndex >= 0 Then
            ShowSelectedBukn()
        End If
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' ---------------------------------------------------------
    ' 画面遷移ロジック (修正版: 確実に行を取得する)
    ' ---------------------------------------------------------
    Private Sub ShowSelectedBukn()
        Try
            ' 詳細画面を開く
            Dim frm As New FrmBuknEntry()

            ' 選択された行の ID (kykm_id) を渡す
            frm.KykmId = Convert.ToDouble(dgv_LIST.GetSelectedRow().Cells("kykm_id").Value)

            frm.ShowDialog()

            ' 戻ってきたら一覧更新
            SearchData()

        Catch ex As Exception
            MessageBox.Show("画面を開く際にエラーが発生しました: " & ex.Message)
        End Try
    End Sub
End Class