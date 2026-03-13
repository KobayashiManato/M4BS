Imports System.Data
Imports LeaseM4BS.DataAccess
Imports Npgsql

' --- 新規入力 ---
Partial Public Class Form_ContractEntry
    Inherits Form

    ' ▼▼▼ 1. クラスの先頭付近（変数の定義場所）に追加 ▼▼▼
    ' 一覧画面から受け取るためのID変数（プロパティ）
    Public Property KykhId As Double = 0
    ' ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

    Private Const FMT_CURRENCY As String = "#,##0"
    Private _crud As CrudHelper = New CrudHelper()

    ' コンストラクタ
    Public Sub New()
        InitializeComponent()
    End Sub

    ' -------------------------------------------------------------------------
    ' フォームロード時の処理
    ' -------------------------------------------------------------------------
    Private Sub FrmContractEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. グリッド(明細)の列を Access画面に合わせて定義
            SetupGridColumns()

            ' 2. コンボボックスの選択肢をロード
            BindCombos()

            ' 3. 画面の初期化
            ' ▼▼▼ 3. ここを修正（IDがあればデータを読み込む） ▼▼▼
            If KykhId > 0 Then
                ' IDが渡されていれば、そのデータをデータベースから取得して表示
                LoadContractById(KykhId)
            Else
                ' IDがなければ（0なら）、新規登録として画面をクリア
                ClearScreen()
            End If
            ' ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲
        Catch ex As Exception
            MessageBox.Show("初期化エラー: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------
    ' グリッドの列定義 (Accessのサブフォーム f_KYKH_SUB を再現)
    ' -------------------------------------------------------------------------
    Private Sub SetupGridColumns()
        dgv_DETAILS.AutoGenerateColumns = False
        dgv_DETAILS.Columns.Clear()

        ' ▼▼▼ ★追加: IDを保持するための隠し列を作る ▼▼▼
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "col_KYKM_ID"  ' プログラムで使う名前
        colId.Visible = False       ' 画面には出さない
        dgv_DETAILS.Columns.Add(colId)        ' 列の定義 (メソッド呼び出しに変更)
        AddGridColumn("bukn_nm", "物件名称", 200)
        AddGridColumn("b_suuryo", "数量", 60, "N0")
        AddGridColumn("kanri_busho", "管理部署", 100)
        AddGridColumn("b_knyukn", "現金購入価額", 100, "N0")
        AddGridColumn("b_klsryo", "1支払額", 100, "N0")
        AddGridColumn("b_glsryo", "月額リース料", 100, "N0")
        AddGridColumn("skmk_id", "資産区分", 80)
        AddGridColumn("bkind_id", "物件種別", 80)

        ' グリッドの見た目をAccess風に
        dgv_DETAILS.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub

    ' 列追加用のヘルパーメソッド (Lambdaから通常のメソッドに変更)
    Private Sub AddGridColumn(name As String, header As String, width As Integer, Optional format As String = "")
        Dim col As New DataGridViewTextBoxColumn()
        col.Name = name
        col.HeaderText = header
        col.Width = width
        col.DataPropertyName = name ' DB列名と一致させる想定
        If format <> "" Then col.DefaultCellStyle.Format = format
        dgv_DETAILS.Columns.Add(col)
    End Sub

    ' -------------------------------------------------------------------------
    ' マスタデータのロード
    ' -------------------------------------------------------------------------
    Private Sub BindCombos()
        Dim _crud As New CrudHelper()
        ' -----------------------------------------------------
        ' 1. 管理単位 (KKNRI) - m_corp(会社)を結合して取得
        ' -----------------------------------------------------
        Dim sqlKknri = "SELECT * " &
                       "FROM m_kknri kknri " &
                       "LEFT JOIN m_corp corp ON kknri.corp_id = corp.corp_id " &
                       "ORDER BY kknri.kknri1_cd;"

        cmb_KKNRI_ID.Bind(sqlKknri, "kknri1_cd", "kknri_id")

        cmb_KKNRI_ID.AdjustSize()
        cmb_KKNRI_ID.SelectedIndex = -1

        ' -----------------------------------------------------
        ' 2. 支払先 (LCPT)
        ' -----------------------------------------------------
        Dim sqlLcpt As String = "SELECT * FROM m_lcpt ORDER BY lcpt1_cd;"

        cmb_LCPT_ID.Bind(sqlLcpt, "lcpt1_cd", "lcpt_id")

        cmb_LCPT_ID.AdjustSize()
        cmb_LCPT_ID.SelectedIndex = -1

        ' 契約区分 (Accessの値を再現)
        cmb_KKBN_ID.Items.Clear()
        cmb_KKBN_ID.Items.Add("リース")
        cmb_KKBN_ID.Items.Add("レンタル")
        cmb_KKBN_ID.Items.Add("保守")
        cmb_KKBN_ID.Items.Add("その他")
        cmb_KKBN_ID.Text = "リース"

        ' 消費税率
        cmb_ZRITU.Items.Clear()
        cmb_ZRITU.Items.AddRange(New String() {"0.10", "0.08", "0.05"})
        cmb_ZRITU.Text = "0.10"
    End Sub

    ' =========================================================
    '  コンボボックスの3列描画 (Access完全再現・罫線付き)
    ' =========================================================
    Private Sub Combo_KKNRI_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_KKNRI_ID.DrawItem
        Combo_DrawItem(sender, e, {"kknri1_cd", "kknri1_nm", "corp1_nm"})
    End Sub

    Private Sub Combo_LCPT_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmb_LCPT_ID.DrawItem
        Combo_DrawItem(sender, e, {"lcpt1_cd", "lcpt1_nm", "lcpt2_nm"})
    End Sub


    ' =========================================================
    '  コンボボックス選択時の連動 (Accessの =Column(x) 再現)
    ' =========================================================

    ' 管理単位が変わったら
    Private Sub cmb_KKNRI_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_KKNRI_ID.SelectedIndexChanged
        cmb_KKNRI_ID.SyncTo("kknri1_nm", txt_KKNRI_NM)
        cmb_KKNRI_ID.SyncTo("corp1_nm", txt_CORP_NM)
    End Sub

    ' 支払先が変わったら
    Private Sub cmb_LCPT_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_LCPT_ID.SelectedIndexChanged
        cmb_LCPT_ID.SyncTo("lcpt1_nm", txt_LCPT_NM)
    End Sub

    ' =========================================================
    '  ドロップダウンリストの行の高さを決める (MeasureItem)
    ' =========================================================
    Private Sub Combo_MeasureItem(sender As Object, e As MeasureItemEventArgs) Handles cmb_KKNRI_ID.MeasureItem, cmb_LCPT_ID.MeasureItem
        ' リストの行の高さ (ここを広めにする)
        e.ItemHeight = 18
    End Sub

    ' -------------------------------------------------------------------------
    ' 自動計算ロジック (Accessの mZGAKUandZKOMI_CALC 相当)
    ' -------------------------------------------------------------------------
    ' 現金購入価額が変わったとき
    Private Sub txt_KNYUKN_Leave(sender As Object, e As EventArgs) Handles txt_KNYUKN.Leave
        CalculateAmount()
    End Sub

    ' 料率が変わったとき
    Private Sub txt_RYORITU_Leave(sender As Object, e As EventArgs) Handles txt_RYORITU.Leave
        CalculateAmount()
    End Sub

    Private Sub CalculateAmount()
        ' 数値変換
        Dim price As Decimal = NzDec(txt_KNYUKN.Text)
        Dim rate As Decimal = NzDec(txt_RYORITU.Text)

        If price > 0 And rate > 0 Then
            ' 月額 = 購入価額 * 料率 (Accessロジック: 切り捨て)
            Dim monthly As Decimal = Math.Floor(price * rate)
            txt_GLSRYO.Text = monthly.ToString(FMT_CURRENCY)

            ' 消費税計算
            Dim taxRate As Decimal = NzDec(cmb_ZRITU.Text)
            Dim tax As Decimal = Math.Floor(monthly * taxRate)

            txt_GZEI.Text = tax.ToString(FMT_CURRENCY) ' 月額消費税
            txt_GLSRYO_ZEIKOMI.Text = (monthly + tax).ToString(FMT_CURRENCY) ' 税込み
        End If
    End Sub

    ' -------------------------------------------------------------------------
    ' 登録(S) ボタンクリック (新規・修正 両対応版)
    ' -------------------------------------------------------------------------
    Private Sub cmd_CREATE_Click(sender As Object, e As EventArgs) Handles cmd_CREATE.Click
        ' 1. 入力チェック
        If Not ValidateInput() Then Return

        Dim _crud As New CrudHelper()

        ' ★重要: 新規か修正かの判定
        ' txt_KYKH_ID (隠し項目) が 0 なら新規、それ以外なら修正
        Dim currentKykhId As Double = NzDec(txt_KYKH_ID.Text)
        Dim isNewMode As Boolean = (currentKykhId = 0)

        Try
            ' ---------------------------------------------------------
            ' 2. 契約ヘッダ (d_kykh) の保存
            ' ---------------------------------------------------------
            Dim valKykh As New Dictionary(Of String, Object)

            ' --- IDの発番 (新規の場合のみ) ---
            If isNewMode Then
                Dim sqlMaxId As String = "SELECT COALESCE(MAX(kykh_id), 0) FROM d_kykh"
                currentKykhId = Convert.ToDouble(_crud.ExecuteScalar(Of Object)(sqlMaxId)) + 1
                valKykh.Add("kykh_id", currentKykhId) ' 新しいID
            Else
                ' 修正の場合はIDを発番せず、WHERE句で使用する
                ' (Dictionaryには含めないか、Updateメソッドの仕様に合わせる)
            End If

            ' --- 基本情報 ---
            valKykh.Add("kykbnj", txt_KYAK_NO.Text)

            valKykh.Add("kyak_nm", txt_KYAK_NM.Text.Trim())


            ' ▼▼▼ ★追加: 稟議番号と自社管理用番号 (ここが抜けていました) ▼▼▼
            valKykh.Add("rng_bango", txt_RNG_BANGO.Text)
            valKykh.Add("kykbnl", txt_JISH_KYAK_NO.Text)  ' Access定義では「kykbnl」が自社管理用/相手番号に使われます
            ' ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

            valKykh.Add("kyak_dt", dtp_KYAK_DT.Value)
            valKykh.Add("start_dt", dtp_START_DT.Value)
            valKykh.Add("end_dt", dtp_END_DT.Value)
            valKykh.Add("k_rend_dt", dtp_END_DT.Value)

            ' --- 契約区分 ---
            Dim kkbnId As Integer = 1
            If cmb_KKBN_ID.Text = "レンタル" Then kkbnId = 2
            valKykh.Add("kkbn_id", kkbnId)

            ' --- 金額 ---
            valKykh.Add("k_knyukn", NzDec(txt_KNYUKN.Text))
            valKykh.Add("ryoritu", NzDec(txt_RYORITU.Text))
            valKykh.Add("k_glsryo", NzDec(txt_GLSRYO.Text))
            valKykh.Add("zritu", NzDec(cmb_ZRITU.Text))
            valKykh.Add("k_gzei", NzDec(txt_GZEI.Text))
            valKykh.Add("k_glsryo_zkomi", NzDec(txt_GLSRYO_ZEIKOMI.Text))

            ' --- 必須項目の穴埋め ---
            valKykh.Add("saikaisu", 0)
            valKykh.Add("lkikan", NzDec(txt_LKIKAN.Text)) ' 画面値を使う
            valKykh.Add("shri_kn", NzDec(txt_SHRI_KN.Text))
            valKykh.Add("shri_cnt", NzDec(txt_SHRI_CNT.Text))
            valKykh.Add("k_suuryo", 0)
            valKykh.Add("k_klsryo", NzDec(txt_KLSRYO.Text))
            valKykh.Add("k_mlsryo", NzDec(txt_MLSRYO.Text))
            valKykh.Add("k_slsryo", NzDec(txt_SLSRYO.Text))
            valKykh.Add("k_kzei", NzDec(txt_KZEI.Text))
            valKykh.Add("k_mzei", NzDec(txt_MZEI.Text))
            valKykh.Add("k_klsryo_zkomi", NzDec(txt_KLSRYO_ZKOMI.Text))
            valKykh.Add("k_mlsryo_zkomi", NzDec(txt_MLSRYO_ZKOMI.Text))
            valKykh.Add("k_ijiknr", 0)
            valKykh.Add("k_zanryo", 0)

            ' --- ID系 ---
            valKykh.Add("kknri_id", If(cmb_KKNRI_ID.SelectedValue, 0))
            valKykh.Add("lcpt_id", If(cmb_LCPT_ID.SelectedValue, 0))
            valKykh.Add("koza_id", If(cmb_KOZA_ID.SelectedValue, 0))
            valKykh.Add("rsrvk1_id", If(cmb_RSRVK1_ID.SelectedValue, 0))
            valKykh.Add("shho_m_id", If(cmb_SHHO_M_ID.SelectedValue, 0))
            valKykh.Add("shho_1_id", If(cmb_SHHO_1_ID.SelectedValue, 0))
            valKykh.Add("shho_2_id", If(cmb_SHHO_2_ID.SelectedValue, 0))
            valKykh.Add("shho_3_id", If(cmb_SHHO_3_ID.SelectedValue, 0))
            valKykh.Add("kjkbn_id", 1)

            ' --- システム項目 ---
            ' ▼▼▼ ★この1行を追加してください！ ▼▼▼
            valKykh.Add("update_cnt", NzDec(txt_UPDATE_CNT.Text))

            ' ▼▼▼ ★この2行を追加してください！ ▼▼▼
            ' ※本来はログインユーザーIDを使いますが、ひとまず 0 をセットします
            valKykh.Add("k_create_id", 0)
            valKykh.Add("k_update_id", 0)

            ' ▼▼▼ ★このブロックを追加してください！(フラグ項目の穴埋め) ▼▼▼
            ' ※NULL禁止のフラグ項目に値をセットします
            valKykh.Add("jencho_f", chk_JENCHO_F.Checked)     ' 自動延長
            valKykh.Add("k_henl_f", chk_K_HENL_F.Checked)     ' 変額
            valKykh.Add("k_henf_f", chk_K_HENF_F.Checked)     ' 保守料
            valKykh.Add("k_seigou_f", chk_K_SEIGOU_F.Checked) ' 整合
            valKykh.Add("k_ckaiyk_f", chk_CKAIYK_F.Checked)   ' 中途解約

            ' 画面にない内部フラグは False (0) で埋める
            valKykh.Add("k_history_f", False)
            valKykh.Add("kjkbn_ms_f", False)

            valKykh.Add("k_update_dt", DateTime.Now)
            If isNewMode Then
                valKykh.Add("k_create_dt", DateTime.Now)
            End If

            ' --- フラグ項目 ---
            valKykh.Add("kyak_end_f", chk_KYAK_END_F.Checked)
            valKykh.Add("skyu_kj_f", If(chk_SKYU_KJ_F.Checked, 1, 0))
            ' (他のフラグは初期値Falseで省略可、または必要に応じて追加)

            ' ★実行分岐: 新規ならInsert、修正ならUpdate
            If isNewMode Then
                _crud.Insert("d_kykh", valKykh)
                ' 新規登録したIDを画面にセットしておく（連打防止）
                txt_KYKH_ID.Text = currentKykhId.ToString()
            Else
                ' Updateメソッドがない場合はSQLで実行
                ' _crud.Update("d_kykh", valKykh, "kykh_id", currentKykhId) 
                ' ※Updateヘルパーがない場合のSQL例:
                Dim updateSql As String = "UPDATE d_kykh SET " &
                                          "kykbnj=@kykbnj, k_glsryo=@k_glsryo, k_update_dt=@k_update_dt " &
                                          "WHERE kykh_id = @id"
                ' (ここではDictionaryを使ったUpdateメソッドがある前提とします)
                ' もし無ければ、Insertと同じキー違反になるので、Updateロジックが必要です
                MessageBox.Show("修正モードですが、Update処理が未実装のためInsertしようとしています。重複エラーになります。", "警告")
                ' ★とりあえずInsertを実行してエラーを確認する場合はこのままでOK
                ' _crud.Insert("d_kykh", valKykh) 
            End If

            ' ---------------------------------------------------------
            ' 3. 契約明細 (d_kykm) の保存
            ' ---------------------------------------------------------
            ' 明細IDの現在最大値を取得
            Dim sqlMaxDetailId As String = "SELECT COALESCE(MAX(kykm_id), 0) FROM d_kykm"
            Dim nextKykmId As Double = Convert.ToDouble(_crud.ExecuteScalar(Of Object)(sqlMaxDetailId)) + 1

            Dim detailNo As Integer = 1

            For Each row As DataGridViewRow In dgv_DETAILS.Rows
                If row.IsNewRow Then Continue For

                ' 行が持っているIDを取得 (隠し列 col_KYKM_ID がある前提)
                ' ※なければ 0 になる
                Dim rowKykmId As Double = NzDec(row.Cells("col_KYKM_ID").Value)
                Dim isDetailNew As Boolean = (rowKykmId = 0)

                Dim valKykm As New Dictionary(Of String, Object)

                ' 親ID
                valKykm.Add("kykh_id", currentKykhId)
                valKykm.Add("kykm_no", detailNo)

                ' 画面値 (番号 0,1,3... ではなく "名前" で指定する)
                valKykm.Add("bukn_nm", If(row.Cells("bukn_nm").Value, ""))
                valKykm.Add("b_suuryo", NzDec(row.Cells("b_suuryo").Value))
                valKykm.Add("b_knyukn", NzDec(row.Cells("b_knyukn").Value))
                valKykm.Add("b_klsryo", NzDec(row.Cells("b_klsryo").Value))
                valKykm.Add("b_glsryo", NzDec(row.Cells("b_glsryo").Value))

                ' 必須値埋め
                valKykm.Add("b_update_dt", DateTime.Now)
                ' ▼▼▼ ★この2行を追加してください！(ここが抜けていました) ▼▼▼
                valKykm.Add("b_create_id", 0)
                valKykm.Add("b_update_id", 0)

                ' ▼▼▼ ★このブロックを追加してください！(不足しているフラグ項目) ▼▼▼
                valKykm.Add("suuryo_sum_f", False)      ' 数量集計
                valKykm.Add("kari_ritu_ms_f", False)    ' 仮リース料率
                valKykm.Add("taiyo_nen_ms_f", False)    ' 耐用年数
                valKykm.Add("leakbn_id_ms_f", False)    ' リース区分
                valKykm.Add("chuum_id_ms_f", False)     ' 注文区分
                valKykm.Add("lb_chuki_f", False)        ' 長期借入金
                valKykm.Add("b_ckaiyk_f", False)        ' 中途解約
                valKykm.Add("b_henl_f", False)          ' 変額
                valKykm.Add("b_henf_f", False)          ' 変額(保守)
                valKykm.Add("genson_f", False)          ' 減損
                valKykm.Add("b_seigou_f", False)        ' 整合
                valKykm.Add("b_gson_f", False)          ' 減損(予備)
                valKykm.Add("rsok_tmg_ms_f", False)     ' 利息手形
                valKykm.Add("gk_calc_kind_ms_f", False) ' 減価償却計算方法
                valKykm.Add("hensai_kind_ms_f", False)  ' 返済方法
                valKykm.Add("ij_kjyo_kind_ms_f", False) ' 維持管理計上方法
                valKykm.Add("gson_tk_kind_ms_f", False) ' 減損特例
                valKykm.Add("lb_kjyo_kind_ms_f", False) ' リース負債計上
                valKykm.Add("kjkbn_ms_f", False)        ' 計上区分
                valKykm.Add("szei_kjkbn_id_ms_f", False) ' 消費税計上区分
                valKykm.Add("hszei_kjkbn_id_ms_f", False) ' 支払消費税計上区分

                ' ▼▼▼ ★このブロックを追加してください！(ID・区分の穴埋め) ▼▼▼
                valKykm.Add("leakbn_id", 0)     ' リース区分
                valKykm.Add("chuum_id", 0)      ' 注文区分
                valKykm.Add("chu_hnti_id", 0)   ' 注文判定
                valKykm.Add("hkho_id", 0)       ' 保険方法
                valKykm.Add("hk_gsha_id", 0)    ' 保険会社
                valKykm.Add("f_lcpt_id", 0)     ' 振込先
                valKykm.Add("f_hkmk_id", 0)     ' 振込費目
                valKykm.Add("f_gsha_id", 0)     ' 振込業者
                valKykm.Add("skmk_id", 0)       ' 償却科目
                valKykm.Add("b_bcat_id", 0)     ' 物件分類
                valKykm.Add("b_bcat_id_r1", 0)  ' 分類R1
                valKykm.Add("b_bcat_id_r2", 0)  ' 分類R2
                valKykm.Add("b_bcat_id_r3", 0)  ' 分類R3
                valKykm.Add("k_gsha_id", 0)     ' 契約業者
                valKykm.Add("bkind_id", 0)      ' 物件種別
                valKykm.Add("mcpt_id", 0)       ' 前払先
                valKykm.Add("rsrvb1_id", 0)     ' 予備ID
                valKykm.Add("rsok_tmg", 0)      ' 利息手形
                valKykm.Add("gk_calc_kind", 0)  ' 償却計算
                valKykm.Add("hensai_kind", 0)   ' 返済方法
                valKykm.Add("ij_kjyo_kind", 0)  ' 維持計上
                valKykm.Add("gson_tk_kind", 0)  ' 減損特例
                valKykm.Add("lb_kjyo_kind", 0)  ' 負債計上
                valKykm.Add("kjkbn_id", 1)      ' 計上区分 (初期値1)
                valKykm.Add("skyak_ho_id", 0)   ' 遡及方法
                valKykm.Add("kj_flg", 0)        ' 計上フラグ

                ' ★明細の分岐
                If isDetailNew Then
                    ' 新規行: IDを発番してInsert
                    valKykm.Add("kykm_id", nextKykmId)
                    valKykm.Add("b_create_dt", DateTime.Now)
                    _crud.Insert("d_kykm", valKykm)

                    ' 発番したIDをグリッドに書き戻す（連打防止）
                    row.Cells("col_KYKM_ID").Value = nextKykmId
                    nextKykmId += 1
                Else
                    ' 既存行: IDを指定してUpdate
                    Dim updSql As String = "UPDATE d_kykm SET " &
                                           "kykm_no=@no, bukn_nm=@nm, b_suuryo=@su, b_knyukn=@kn, " &
                                           "b_klsryo=@kl, b_glsryo=@gl, b_update_dt=@upd " &
                                           "WHERE kykm_id = @id"

                    ' ★修正: Dictionary ではなく List(Of NpgsqlParameter) を使う
                    Dim pList As New List(Of Npgsql.NpgsqlParameter)
                    pList.Add(New Npgsql.NpgsqlParameter("@no", detailNo))
                    pList.Add(New Npgsql.NpgsqlParameter("@nm", If(row.Cells(0).Value, "")))
                    pList.Add(New Npgsql.NpgsqlParameter("@su", NzDec(row.Cells(1).Value)))
                    pList.Add(New Npgsql.NpgsqlParameter("@kn", NzDec(row.Cells(3).Value)))
                    pList.Add(New Npgsql.NpgsqlParameter("@kl", NzDec(row.Cells(4).Value)))
                    pList.Add(New Npgsql.NpgsqlParameter("@gl", NzDec(row.Cells(5).Value)))
                    pList.Add(New Npgsql.NpgsqlParameter("@upd", DateTime.Now))
                    pList.Add(New Npgsql.NpgsqlParameter("@id", rowKykmId))

                    _crud.ExecuteNonQuery(updSql, pList)
                End If
                detailNo += 1
            Next

            MessageBox.Show("保存しました！", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("保存エラー: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================
    '  データ読込機能 (検索)
    ' =========================================================

    ' 契約番号のテキストボックスで [Enter] キーを押したら実行
    Private Sub txt_KYAK_NO_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_KYAK_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' ★追加：動いているか確認するメッセージ
            MessageBox.Show("検索を開始します: " & txt_KYAK_NO.Text)

            ' 入力が空でなければ検索実行
            If txt_KYAK_NO.Text <> "" Then
                LoadContractData(txt_KYAK_NO.Text)
            End If
        End If
    End Sub

    ' =========================================================
    '  実際のデータ読込処理 (検索)
    ' =========================================================
    Private Sub LoadContractData(kyakNo As String)
        Dim _crud As New CrudHelper()
        Try
            ' 前後の空白を削除
            kyakNo = kyakNo.Trim()

            ' -----------------------------------------------------
            ' 1. ヘッダ情報 (d_kykh) の取得
            ' -----------------------------------------------------
            ' ★修正ポイント: TRIM(kykbnj) にして、DB側の余計な空白を無視して比較する
            Dim sql As String = "SELECT * FROM d_kykh WHERE TRIM(kykbnj) = @no ORDER BY kykh_id DESC LIMIT 1"

            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@no", kyakNo)
            }
            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            ' デバッグ用: 何件見つかったか表示（確認後、削除してOK）
            ' MessageBox.Show("検索SQL実行結果: " & dt.Rows.Count & "件 見つかりました。")

            If dt.Rows.Count = 0 Then
                MessageBox.Show("契約番号 [" & kyakNo & "] は登録されていません。", "検索結果", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim row As DataRow = dt.Rows(0)

            ' --- 画面にセット (ヘッダ) ---
            ' IDをタグなどに隠し持っておく（後でUPDATEするときに使うため）
            txt_KYAK_NO.Tag = row("kykh_id")

            ' 隠し項目もセット（これがないと修正登録時にエラーになる）
            txt_KYKH_ID.SetText(row("kykh_id"))
            txt_UPDATE_CNT.SetText(row("update_cnt"))

            ' 日付 (DBがNULLでなければセット)
            dtp_KYAK_DT.Value = NzDate(row("kyak_dt"))
            dtp_START_DT.Value = NzDate(row("start_dt"))
            dtp_END_DT.Value = NzDate(row("end_dt"))

            ' 金額・数値
            txt_KNYUKN.SetAmount(row("k_knyukn"))
            txt_RYORITU.Text = NzDec(row("ryoritu")).ToString("0.000000")

            txt_GLSRYO.SetAmount(row("k_glsryo"))
            cmb_ZRITU.SelectedValue = NzDec(row("zritu")).ToString()
            txt_GZEI.SetAmount(row("k_gzei"))
            txt_GLSRYO_ZEIKOMI.SetAmount(row("k_glsryo_zkomi"))

            ' コンボボックス (IDから選択状態を復元)
            cmb_KKNRI_ID.SelectedValue = row("kknri_id")
            cmb_LCPT_ID.SelectedValue = row("lcpt_id")
            cmb_KOZA_ID.SelectedValue = row("koza_id")
            cmb_RSRVK1_ID.SelectedValue = row("rsrvk1_id")

            ' 支払方法
            cmb_SHHO_M_ID.SelectedValue = row("shho_m_id")
            cmb_SHHO_1_ID.SelectedValue = row("shho_1_id")
            cmb_SHHO_2_ID.SelectedValue = row("shho_2_id")
            cmb_SHHO_3_ID.SelectedValue = row("shho_3_id")

            ' 契約区分 (画面の文字に戻す)
            Dim kId As Integer = Convert.ToInt32(row("kkbn_id"))
            cmb_KKBN_ID.Text = If(kId = 2, "レンタル", "リース")

            ' フラグ
            chk_KYAK_END_F.Checked = Convert.ToBoolean(row("kyak_end_f"))
            chk_SKYU_KJ_F.Checked = (Convert.ToInt32(row("skyu_kj_f")) = 1)

            ' -----------------------------------------------------
            ' 2. 明細情報 (d_kykm) の取得
            ' -----------------------------------------------------
            Dim kykhId As Object = row("kykh_id")
            Dim sqlDetail As String = "SELECT * FROM d_kykm WHERE kykh_id = @kykhId ORDER BY kykm_no"
            ' パラメータ名が違うので新しく作る
            Dim prmDetail As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@kykhId", kykhId)
            }
            Dim dtDetail As DataTable = _crud.GetDataTable(sqlDetail, prmDetail)

            ' グリッドをクリアして再表示
            dgv_DETAILS.Rows.Clear()
            For Each dRow As DataRow In dtDetail.Rows
                dgv_DETAILS.Rows.Add(
                    dRow("kykm_id"),    ' 隠しID
                    dRow("bukn_nm"),    ' 物件名
                    ToCurrency(dRow("b_suuryo")),   ' 数量
                    "",                 ' 管理部署
                    ToCurrency(dRow("b_knyukn")),   ' 購入価額
                    ToCurrency(dRow("b_klsryo")),   ' 1支払額
                    ToCurrency(dRow("b_glsryo"))    ' 月額
                )
            Next

            MessageBox.Show("読み込み完了！", "照会完了", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("読込エラー: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' =========================================================
    '  修正 (UPDATE) ボタン (完全版)
    ' =========================================================
    Private Sub cmd_REVISE_Click(sender As Object, e As EventArgs) Handles cmd_REVISE.Click
        ' 1. 修正モードかチェック
        If txt_KYAK_NO.Tag Is Nothing OrElse String.IsNullOrEmpty(txt_KYAK_NO.Tag.ToString()) Then
            MessageBox.Show("修正するデータが読み込まれていません。" & vbCrLf & "先に契約番号を入力してEnterキーで検索してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ★ここに追加
        If Not ValidateInput() Then Return ' 入力チェックNGなら中断

        Dim targetId As Double = Convert.ToDouble(txt_KYAK_NO.Tag)
        Dim _crud As New CrudHelper()

        Try
            ' -----------------------------------------------------
            ' 2. ヘッダ (d_kykh) の更新 (UPDATE)
            ' -----------------------------------------------------
            Dim valKykh As New Dictionary(Of String, Object)

            ' 更新項目
            valKykh.Add("kykbnj", txt_KYAK_NO.Text)
            valKykh.Add("kyak_dt", dtp_KYAK_DT.Value)
            valKykh.Add("start_dt", dtp_START_DT.Value)
            valKykh.Add("end_dt", dtp_END_DT.Value)
            valKykh.Add("k_rend_dt", dtp_END_DT.Value)

            ' 金額・数値
            valKykh.Add("k_knyukn", NzDec(txt_KNYUKN.Text))
            valKykh.Add("ryoritu", NzDec(txt_RYORITU.Text))
            valKykh.Add("k_glsryo", NzDec(txt_GLSRYO.Text))
            valKykh.Add("zritu", NzDec(cmb_ZRITU.Text))
            valKykh.Add("k_gzei", NzDec(txt_GZEI.Text))
            valKykh.Add("k_glsryo_zkomi", NzDec(txt_GLSRYO_ZEIKOMI.Text))

            ' コンボボックス系 (未選択なら0)
            valKykh.Add("kknri_id", If(cmb_KKNRI_ID.SelectedValue, 0))
            valKykh.Add("lcpt_id", If(cmb_LCPT_ID.SelectedValue, 0))
            valKykh.Add("koza_id", If(cmb_KOZA_ID.SelectedValue, 0))
            valKykh.Add("rsrvk1_id", If(cmb_RSRVK1_ID.SelectedValue, 0))
            valKykh.Add("shho_m_id", If(cmb_SHHO_M_ID.SelectedValue, 0))
            valKykh.Add("shho_1_id", If(cmb_SHHO_1_ID.SelectedValue, 0))
            valKykh.Add("shho_2_id", If(cmb_SHHO_2_ID.SelectedValue, 0))
            valKykh.Add("shho_3_id", If(cmb_SHHO_3_ID.SelectedValue, 0))

            ' 更新情報
            valKykh.Add("k_update_dt", DateTime.Now)

            ' ★UPDATE実行
            _crud.Update("d_kykh", valKykh, "kykh_id = " & targetId)


            ' -----------------------------------------------------
            ' 3. 明細 (d_kykm) の更新 (洗い替え: 全削除 -> 全登録)
            ' -----------------------------------------------------
            ' A. 古い明細を削除
            Dim sqlDel As String = "DELETE FROM d_kykm WHERE kykh_id = @id"
            Dim prmDel As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", targetId)
            }
            _crud.ExecuteNonQuery(sqlDel, prmDel)

            ' B. 新しい明細IDの採番準備
            Dim sqlMaxDetailId As String = "SELECT COALESCE(MAX(kykm_id), 0) FROM d_kykm"
            Dim currentKykmId As Double = Convert.ToDouble(_crud.ExecuteScalar(Of Object)(sqlMaxDetailId))

            ' C. グリッドの内容を登録 (INSERT)
            ' ※ここからは登録ボタンと全く同じ「完全なリスト」が必要です
            Dim detailNo As Integer = 1
            For Each row As DataGridViewRow In dgv_DETAILS.Rows
                If row.IsNewRow Then Continue For
                currentKykmId += 1

                Dim valKykm As New Dictionary(Of String, Object)

                ' --- ID ---
                valKykm.Add("kykm_id", currentKykmId)
                valKykm.Add("kykh_id", targetId)  ' IDは既存のヘッダID
                valKykm.Add("kykm_no", detailNo)
                valKykm.Add("saikaisu", 0)

                ' --- 画面入力値 ---
                valKykm.Add("bukn_nm", If(row.Cells(0).Value, ""))
                valKykm.Add("b_suuryo", NzDec(row.Cells(1).Value))
                valKykm.Add("b_knyukn", NzDec(row.Cells(3).Value))
                valKykm.Add("b_klsryo", NzDec(row.Cells(4).Value))
                valKykm.Add("b_glsryo", NzDec(row.Cells(5).Value))

                ' --- 必須項目の初期値埋め (省略不可！) ---
                valKykm.Add("b_create_id", 0)
                valKykm.Add("b_create_dt", DateTime.Now)
                valKykm.Add("b_update_id", 0)
                valKykm.Add("b_update_dt", DateTime.Now)

                ' --- フラグ(Boolean) 完全版 ---
                valKykm.Add("suuryo_sum_f", False)
                valKykm.Add("kari_ritu_ms_f", False) ' ←エラーの原因だった項目
                valKykm.Add("taiyo_nen_ms_f", False)
                valKykm.Add("leakbn_id_ms_f", False)
                valKykm.Add("chuum_id_ms_f", False)
                valKykm.Add("lb_chuki_f", False)
                valKykm.Add("b_ckaiyk_f", False)
                valKykm.Add("b_henl_f", False)
                valKykm.Add("b_henf_f", False)
                valKykm.Add("genson_f", False)
                valKykm.Add("b_seigou_f", False)
                valKykm.Add("b_gson_f", False)
                valKykm.Add("rsok_tmg_ms_f", False)
                valKykm.Add("gk_calc_kind_ms_f", False)
                valKykm.Add("hensai_kind_ms_f", False)
                valKykm.Add("ij_kjyo_kind_ms_f", False)
                valKykm.Add("gson_tk_kind_ms_f", False)
                valKykm.Add("lb_kjyo_kind_ms_f", False)
                valKykm.Add("kjkbn_ms_f", False)
                valKykm.Add("szei_kjkbn_id_ms_f", False)
                valKykm.Add("hszei_kjkbn_id_ms_f", False)

                ' --- ID・区分(Integer=0) 完全版 ---
                valKykm.Add("leakbn_id", 0)
                valKykm.Add("chuum_id", 0)
                valKykm.Add("chu_hnti_id", 0)
                valKykm.Add("hkho_id", 0)
                valKykm.Add("hk_gsha_id", 0)
                valKykm.Add("f_lcpt_id", 0)
                valKykm.Add("f_hkmk_id", 0)
                valKykm.Add("f_gsha_id", 0)
                valKykm.Add("skmk_id", 0)
                valKykm.Add("b_bcat_id", 0)
                valKykm.Add("b_bcat_id_r1", 0)
                valKykm.Add("b_bcat_id_r2", 0)
                valKykm.Add("b_bcat_id_r3", 0)
                valKykm.Add("k_gsha_id", 0)
                valKykm.Add("bkind_id", 0)
                valKykm.Add("mcpt_id", 0)
                valKykm.Add("rsrvb1_id", 0)
                valKykm.Add("rsok_tmg", 0)
                valKykm.Add("gk_calc_kind", 0)
                valKykm.Add("hensai_kind", 0)
                valKykm.Add("ij_kjyo_kind", 0)
                valKykm.Add("gson_tk_kind", 0)
                valKykm.Add("lb_kjyo_kind", 0)
                valKykm.Add("kjkbn_id", 1)
                valKykm.Add("skyak_ho_id", 0)
                valKykm.Add("kj_flg", 0)

                ' 保存
                _crud.Insert("d_kykm", valKykm)
                detailNo += 1
            Next

            MessageBox.Show("修正しました！", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("修正エラー: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================
    '  削除 (DELETE) ボタン
    ' =========================================================
    Private Sub cmd_DELETE_Click(sender As Object, e As EventArgs) Handles cmd_DELETE.Click
        ' 1. 削除対象の特定
        If txt_KYAK_NO.Tag Is Nothing OrElse String.IsNullOrEmpty(txt_KYAK_NO.Tag.ToString()) Then
            MessageBox.Show("削除するデータが読み込まれていません。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim targetId As Double = Convert.ToDouble(txt_KYAK_NO.Tag)
        Dim kyakNo As String = txt_KYAK_NO.Text

        ' 2. 確認メッセージ
        If MessageBox.Show("契約番号: " & kyakNo & vbCrLf & "このデータを完全に削除しますか？" & vbCrLf & "(元に戻すことはできません)",
                           "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
            Return
        End If

        Dim _crud As New CrudHelper()
        Try
            ' -----------------------------------------------------
            ' 3. 削除実行 (子テーブル -> 親テーブルの順)
            ' -----------------------------------------------------

            ' A. 明細 (d_kykm) の削除
            Dim sqlDelDetail As String = "DELETE FROM d_kykm WHERE kykh_id = @id"
            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@id", targetId)
            }
            _crud.ExecuteNonQuery(sqlDelDetail, prm)

            ' B. ヘッダ (d_kykh) の削除
            Dim sqlDelHead As String = "DELETE FROM d_kykh WHERE kykh_id = @id"
            ' パラメータは同じものが使えるので再利用
            _crud.ExecuteNonQuery(sqlDelHead, prm)

            ' 4. 完了処理
            MessageBox.Show("削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 画面を閉じる (一覧に戻る)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("削除エラー: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' [閉じる]ボタン
    Private Sub cmd_CLOSE_Click(sender As Object, e As EventArgs) Handles cmd_CLOSE.Click
        Me.Close()
    End Sub

    ' -------------------------------------------------------------------------
    ' ユーティリティ
    ' -------------------------------------------------------------------------
    Private Sub ClearScreen()
        txt_KYAK_NO.Clear()
        txt_KNYUKN.Text = "0"
        txt_RYORITU.Text = "0"
        dgv_DETAILS.Rows.Clear()
    End Sub


    Private Sub FrmContractEntry_formHelperClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _crud.Dispose()
    End Sub

    ' =========================================================
    '  [共通] 入力チェック (バリデーション)
    ' =========================================================
    Private Function ValidateInput() As Boolean
        ' 1. 契約番号 (必須)
        ' ※もし「新規登録時は空欄（自動採番）」なら、このブロックは削除してください
        If String.IsNullOrWhiteSpace(txt_KYAK_NO.Text) Then
            MessageBox.Show("「契約番号」を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_KYAK_NO.Focus()
            Return False
        End If

        ' 2. コンボボックス (必須選択)
        ' ※ SelectedValue が Nothing または 0 の場合をチェック
        If cmb_KKNRI_ID.SelectedValue Is Nothing OrElse Convert.ToInt32(cmb_KKNRI_ID.SelectedValue) = 0 Then
            MessageBox.Show("「管理単位」を選択してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_KKNRI_ID.Focus()
            Return False
        End If

        If cmb_LCPT_ID.SelectedValue Is Nothing OrElse Convert.ToInt32(cmb_LCPT_ID.SelectedValue) = 0 Then
            MessageBox.Show("「支払先」を選択してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_LCPT_ID.Focus()
            Return False
        End If

        ' 3. 金額チェック (リース料が0円や空欄はNGとする場合)
        If NzDec(txt_GLSRYO.Text) = 0 Then
            MessageBox.Show("「月額リース料」を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_GLSRYO.Focus()
            Return False
        End If

        ' 4. 日付の前後関係 (開始日が終了日より後になっていないか)
        Dim dtStart As DateTime
        Dim dtEnd As DateTime
        ' 日付型に変換できるかチェックしつつ比較
        If DateTime.TryParse(dtp_START_DT.Text, dtStart) AndAlso DateTime.TryParse(dtp_END_DT.Text, dtEnd) Then
            If dtStart > dtEnd Then
                MessageBox.Show("「開始日」が「終了日」より後になっています。" & vbCrLf & "日付を確認してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dtp_START_DT.Focus()
                Return False
            End If
        End If

        ' =========================================================
        ' 5. 明細行のチェック (有効化しました)
        ' =========================================================
        Dim detailCount As Integer = 0
        For Each row As DataGridViewRow In dgv_DETAILS.Rows
            If Not row.IsNewRow Then detailCount += 1
        Next

        If detailCount = 0 Then
            MessageBox.Show("物件明細が入力されていません。" & vbCrLf & "少なくとも1件以上の物件を登録してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgv_DETAILS.Focus()
            Return False
        End If

        For Each row As DataGridViewRow In dgv_DETAILS.Rows
            If row.IsNewRow Then Continue For

            Dim buknName As String = If(row.Cells("bukn_nm").Value, "").ToString()

            If String.IsNullOrWhiteSpace(buknName) Then
                MessageBox.Show("物件名称が入力されていない行があります。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgv_DETAILS.CurrentCell = row.Cells("bukn_nm")
                dgv_DETAILS.BeginEdit(True)
                Return False
            End If
        Next

        ' すべてクリアしたらOK
        Return True
    End Function

    ' =========================================================
    '  外部（一覧画面）から呼び出されるメソッド
    ' =========================================================
    Public Sub LoadContractById(kykhId As Double)
        ' 1. IDを画面のタグなどに保存（修正ボタンなどで使うため）
        txt_KYAK_NO.Tag = kykhId

        ' 2. データベースからこのIDのデータを取得して表示
        ' ※以前作った LoadContractData は「番号(String)」で検索するものでした。
        '   ここでは「ID(Double)」で検索するロジックが必要です。

        Dim _crud As New CrudHelper()
        Try
            ' --- ヘッダ取得 (ID指定) ---
            Dim sql As String = "SELECT * FROM d_kykh WHERE kykh_id = @kykhId"
            Dim prm As New List(Of Npgsql.NpgsqlParameter) From {
                New Npgsql.NpgsqlParameter("@kykhId", kykhId)
            }
            Dim dt As DataTable = _crud.GetDataTable(sql, prm)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)

                ' 画面項目にセット（以前のコードと同じロジック）
                txt_KYAK_NO.SetText(row("kykbnj"))      ' 契約番号

                ' ▼▼▼ ★追加: 読み込み時もここが抜けていました ▼▼▼
                txt_KYAK_NM.SetText(row("kyak_nm"))      ' 契約名
                txt_RNG_BANGO.SetText(row("rng_bango"))  ' 稟議番号
                txt_JISH_KYAK_NO.SetText(row("kykbnl"))  ' 自社管理用

                ' 日付
                dtp_KYAK_DT.Value = NzDate(row("kyak_dt"))
                dtp_START_DT.Value = NzDate(row("start_dt"))
                dtp_END_DT.Value = NzDate(row("end_dt"))

                ' 金額
                txt_KNYUKN.SetAmount(row("k_knyukn"))
                txt_RYORITU.SetAmount(row("ryoritu"))
                txt_GLSRYO.SetAmount(row("k_glsryo"))
                cmb_ZRITU.SelectedValue = row("zritu").ToString()
                txt_GZEI.SetAmount(row("k_gzei"))
                txt_GLSRYO_ZEIKOMI.SetAmount(row("k_glsryo_zkomi"))

                ' ID系
                cmb_KKNRI_ID.SelectedValue = row("kknri_id")
                cmb_LCPT_ID.SelectedValue = row("lcpt_id")
                cmb_KOZA_ID.SelectedValue = row("koza_id")
                cmb_RSRVK1_ID.SelectedValue = row("rsrvk1_id")

                ' 支払日
                txt_SHRI_DT1.Value = NzDate(row("shri_dt1"))
                txt_SHRI_DT2.Value = NzDate(row("shri_dt2"))
                txt_SHRI_DT3.SetText(row("shri_dt3"))

                ' 支払方法
                cmb_SHHO_M_ID.SelectedValue = row("shho_m_id")
                cmb_SHHO_1_ID.SelectedValue = row("shho_1_id")
                cmb_SHHO_2_ID.SelectedValue = row("shho_2_id")
                cmb_SHHO_3_ID.SelectedValue = row("shho_3_id")

                ' 契約区分
                Dim kId As Integer = Convert.ToInt32(row("kkbn_id"))
                cmb_KKBN_ID.Text = If(kId = 2, "レンタル", "リース")

                ' フラグ
                chk_KYAK_END_F.Checked = Convert.ToBoolean(row("kyak_end_f"))
                chk_SKYU_KJ_F.Checked = (Convert.ToInt32(row("skyu_kj_f")) = 1)

                ' --- 明細取得 (ID指定) ---
                Dim sqlDetail As String = "SELECT * FROM d_kykm WHERE kykh_id = @kykhId ORDER BY kykm_no"
                Dim dtDetail As DataTable = _crud.GetDataTable(sqlDetail, prm) ' パラメータは同じ@idでOK

                dgv_DETAILS.Rows.Clear()
                For Each dRow As DataRow In dtDetail.Rows
                    ' ▼▼▼ 修正後（先頭にIDを追加） ▼▼▼
                    dgv_DETAILS.Rows.Add(
                        dRow("kykm_id"),                ' ★隠し列(Index 0)にIDを入れる
                        dRow("bukn_nm"),                ' Index 1: 物件名
                        ToCurrency(dRow("b_suuryo")),   ' Index 2: 数量
                        "",                             ' Index 3: 管理部署
                        ToCurrency(dRow("b_knyukn")),   ' Index 4: 購入価額
                        ToCurrency(dRow("b_klsryo")),   ' Index 5: 1支払額
                        ToCurrency(dRow("b_glsryo"))    ' Index 6: 月額
                    )
                Next
            End If

        Catch ex As Exception
            MessageBox.Show("詳細読込エラー: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    '  [共通] 消費税・税込金額の自動計算ロジック
    '  引数: (金額テキスト, 税額テキスト, 税込テキスト)
    ' =========================================================
    Private Sub CalcTaxAndTotal(txtAmount As TextBox, txtTax As TextBox, txtTotal As TextBox)
        ' 1. 金額と税率を取得
        Dim amount As Decimal = NzDec(txtAmount.Text)
        Dim rate As Decimal = NzDec(cmb_ZRITU.Text) ' コンボボックスの表示値(0.10など)を使用

        ' 2. 計算 (Accessのロジック: Int(金額 * 税率))
        ' ※Math.Floorで切り捨て計算します
        Dim tax As Decimal = Math.Floor(amount * rate)
        Dim total As Decimal = amount + tax

        ' 3. 結果を表示 (3桁カンマ区切り)
        txtAmount.SetAmount(amount) ' 入力値も整形する
        txtTax.SetAmount(tax)
        txtTotal.SetAmount(total)
    End Sub

    ' ---------------------------------------------------------
    ' 1. 月額リース料 入力完了時
    ' ---------------------------------------------------------
    Private Sub txt_GLSRYO_Leave(sender As Object, e As EventArgs) Handles txt_GLSRYO.Leave
        ' 月額のセット(金額, 税, 税込)を計算
        CalcTaxAndTotal(txt_GLSRYO, txt_GZEI, txt_GLSRYO_ZEIKOMI)
    End Sub

    ' ---------------------------------------------------------
    ' 2. 1支払額 (期間額) 入力完了時
    ' ---------------------------------------------------------
    Private Sub txt_KLSRYO_Leave(sender As Object, e As EventArgs) Handles txt_KLSRYO.Leave
        ' Findで見つけたコントロール(0番目)を直接使う
        Dim tAmount = Me.Controls.Find("txt_KLSRYO", True)
        Dim tTax = Me.Controls.Find("txt_KZEI", True)
        Dim tTotal = Me.Controls.Find("txt_KLSRYO_ZKOMI", True)

        ' 全部見つかった場合のみ計算する
        If tAmount.Length > 0 AndAlso tTax.Length > 0 AndAlso tTotal.Length > 0 Then
            CalcTaxAndTotal(CType(tAmount(0), TextBox), CType(tTax(0), TextBox), CType(tTotal(0), TextBox))
        End If
    End Sub

    ' ---------------------------------------------------------
    ' 3. 前払金 入力完了時
    ' ---------------------------------------------------------
    Private Sub txt_MLSRYO_Leave(sender As Object, e As EventArgs) Handles txt_MLSRYO.Leave
        Dim tAmount = Me.Controls.Find("txt_MLSRYO", True)
        Dim tTax = Me.Controls.Find("txt_MZEI", True)
        Dim tTotal = Me.Controls.Find("txt_MLSRYO_ZKOMI", True)

        If tAmount.Length > 0 AndAlso tTax.Length > 0 AndAlso tTotal.Length > 0 Then
            CalcTaxAndTotal(CType(tAmount(0), TextBox), CType(tTax(0), TextBox), CType(tTotal(0), TextBox))
        End If
    End Sub

    ' ---------------------------------------------------------
    ' 4. 税率変更時 -> 全部の金額を再計算
    ' ---------------------------------------------------------
    Private Sub cmb_ZRITU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ZRITU.SelectedIndexChanged, cmb_ZRITU.Leave
        ' 1. 月額 (これは画面にあるはずなので直接指定)
        If Me.Controls.Find("txt_GLSRYO", True).Length > 0 Then
            CalcTaxAndTotal(txt_GLSRYO, txt_GZEI, txt_GLSRYO_ZEIKOMI)
        End If

        ' 2. 1支払額 (Findの結果を使う)
        Dim kAmount = Me.Controls.Find("txt_KLSRYO", True)
        Dim kTax = Me.Controls.Find("txt_KZEI", True)
        Dim kTotal = Me.Controls.Find("txt_KLSRYO_ZKOMI", True)

        If kAmount.Length > 0 AndAlso kTax.Length > 0 AndAlso kTotal.Length > 0 Then
            CalcTaxAndTotal(CType(kAmount(0), TextBox), CType(kTax(0), TextBox), CType(kTotal(0), TextBox))
        End If

        ' 3. 前払 (Findの結果を使う)
        Dim mAmount = Me.Controls.Find("txt_MLSRYO", True)
        Dim mTax = Me.Controls.Find("txt_MZEI", True)
        Dim mTotal = Me.Controls.Find("txt_MLSRYO_ZKOMI", True)

        If mAmount.Length > 0 AndAlso mTax.Length > 0 AndAlso mTotal.Length > 0 Then
            CalcTaxAndTotal(CType(mAmount(0), TextBox), CType(mTax(0), TextBox), CType(mTotal(0), TextBox))
        End If
    End Sub

    ' =========================================================
    '  [共通] 終了日の自動計算ロジック
    '  計算式: 開始日 + 契約期間(月) - 1日
    ' =========================================================
    Private Sub CalcEndDate()
        ' 1. 画面の入力値を取得
        Dim dtStart As DateTime
        Dim months As Integer

        ' 日付と数値が正しく入力されているかチェック
        If dtp_START_DT.Text Is Nothing OrElse IsDBNull(dtp_START_DT.Text) Then Return
        If Not DateTime.TryParse(dtp_START_DT.Text, dtStart) Then Return
        If Not Integer.TryParse(txt_LKIKAN.Text, months) Then Return

        ' 2. 計算実行 (月を加算して、1日引く)
        Dim dtEnd As DateTime = dtStart.AddMonths(months).AddDays(-1)

        ' 3. 結果をセット
        dtp_END_DT.Value = dtEnd
    End Sub

    ' ---------------------------------------------------------
    ' イベント: 開始日を変更したとき
    ' ---------------------------------------------------------
    Private Sub dtp_START_DT_ValueChanged(sender As Object, e As EventArgs) Handles dtp_START_DT.ValueChanged
        CalcEndDate()
    End Sub

    ' ---------------------------------------------------------
    ' イベント: 契約期間を入力して離れたとき
    ' ---------------------------------------------------------
    Private Sub txt_LKIKAN_Leave(sender As Object, e As EventArgs) Handles txt_LKIKAN.Leave
        CalcEndDate()
    End Sub

    ' =========================================================
    '  Enterキーで次の項目へ移動 (Access風操作)
    ' =========================================================
    Private Sub FrmContractEntry_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Enterキーが押されたら
        If e.KeyCode = Keys.Enter Then

            ' ▼▼▼ ★追加: 契約番号(txt_KYAK_NO)にいる時は、ここでの処理を中断する ▼▼▼
            ' これにより、txt_KYAK_NO_KeyDown イベント側が動くようになります
            If Me.ActiveControl Is txt_KYAK_NO Then
                Return
            End If
            ' ▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

            ' 複数行入力のテキストボックスなどでなければ移動
            e.Handled = True ' ビープ音を消す

            ' 次のコントロールへフォーカス移動 (Tabキーと同じ動き)
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If
    End Sub

    ' =========================================================
    '  [共通] 支払回数・1支払額・総額の自動計算
    ' =========================================================
    Private Sub CalcPaymentInfo()
        ' -----------------------------------------------------
        ' 1. 支払回数の計算 (期間 ÷ 間隔)
        ' -----------------------------------------------------
        Dim kikan As Decimal = NzDec(txt_LKIKAN.Text) ' 契約期間
        Dim kankaku As Decimal = NzDec(txt_SHRI_KN.Text) ' 支払間隔

        If kankaku = 0 Then kankaku = 1

        ' 回数 = 期間 / 間隔
        Dim count As Decimal = Math.Floor(kikan / kankaku)

        Dim txtCount = Me.Controls.Find("txt_SHRI_CNT", True)
        If txtCount.Length > 0 Then
            txtCount(0).Text = count.ToString()
        End If

        ' -----------------------------------------------------
        ' 2. ★追加: 1支払額の計算 (月額 × 支払間隔)
        ' -----------------------------------------------------
        Dim monthlyFee As Decimal = NzDec(txt_GLSRYO.Text) ' 月額

        ' 1支払額 = 月額 × 支払間隔
        Dim oneTimeFee As Decimal = monthlyFee * kankaku

        Dim txtOneTime = Me.Controls.Find("txt_KLSRYO", True)
        If txtOneTime.Length > 0 Then
            txtOneTime(0).Text = oneTimeFee.ToString("#,##0")

            ' ついでに消費税・税込も計算する
            Dim txtTax = Me.Controls.Find("txt_KZEI", True)
            Dim txtTotal = Me.Controls.Find("txt_KLSRYO_ZKOMI", True)

            If txtTax.Length > 0 AndAlso txtTotal.Length > 0 Then
                CalcTaxAndTotal(CType(txtOneTime(0), TextBox), CType(txtTax(0), TextBox), CType(txtTotal(0), TextBox))
            End If
        End If

        ' -----------------------------------------------------
        ' 3. 総額リース料の計算
        ' -----------------------------------------------------
        Dim prepayCount As Decimal = NzDec(txt_MKAISU.Text) ' 前払回数
        Dim prepayAmount As Decimal = NzDec(txt_MLSRYO.Text) ' 前払金

        ' 通常の支払回数 = 全回数 - 前払回数
        Dim normalCount As Decimal = count - prepayCount
        If normalCount < 0 Then normalCount = 0

        ' 総額 = (1支払額 × 通常回数) + 前払金
        ' ※Accessでは「月額×回数」ではなく「1支払額×回数」で計算するのが一般的です
        Dim totalLease As Decimal = (oneTimeFee * normalCount) + prepayAmount

        Dim txtTotalLease = Me.Controls.Find("txt_SLSRYO", True)
        If txtTotalLease.Length > 0 Then
            txtTotalLease(0).Text = totalLease.ToString(FMT_CURRENCY)
        End If
    End Sub
    ' ---------------------------------------------------------
    ' イベント: 値が変わったら再計算
    ' ---------------------------------------------------------
    ' 契約期間、支払間隔、月額、前払回数、前払金 のいずれかが変わったら計算
    Private Sub CalcTrigger_Leave(sender As Object, e As EventArgs) Handles _
        txt_LKIKAN.Leave, txt_SHRI_KN.Leave, txt_GLSRYO.Leave,
        txt_MKAISU.Leave, txt_MLSRYO.Leave

        CalcPaymentInfo()

        ' ついでに終了日計算も呼んでおく(期間が変わった場合のため)
        CalcEndDate()
    End Sub
End Class
