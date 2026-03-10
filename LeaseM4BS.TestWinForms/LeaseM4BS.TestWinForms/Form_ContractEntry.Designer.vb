<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ContractEntry
    Inherits Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_REVISE = New System.Windows.Forms.Button()
        Me.cmd_SAILEASE = New System.Windows.Forms.Button()
        Me.cmd_KAIYAKU = New System.Windows.Forms.Button()
        Me.cmd_ROLLBACK_SAI = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.cmd_MODE_RESET = New System.Windows.Forms.Button()
        Me.cmd_取込 = New System.Windows.Forms.Button()
        Me.cmd_CLEAR = New System.Windows.Forms.Button()
        Me.pnlDetail = New System.Windows.Forms.Panel()
        Me.txt_CORP_NM = New System.Windows.Forms.TextBox()
        Me.Label_M1 = New System.Windows.Forms.Label()
        Me.txt_Mode = New System.Windows.Forms.TextBox()
        Me.lbl_計上区分 = New System.Windows.Forms.Label()
        Me.txt_KJKBN_NM = New System.Windows.Forms.TextBox()
        Me.lbl_適用日 = New System.Windows.Forms.Label()
        Me.txt_TEKIYO_DT = New System.Windows.Forms.DateTimePicker()
        Me.lbl_管理単位 = New System.Windows.Forms.Label()
        Me.cmb_KKNRI_ID = New System.Windows.Forms.ComboBox()
        Me.txt_KKNRI_NM = New System.Windows.Forms.TextBox()
        Me.lbl_契約区分 = New System.Windows.Forms.Label()
        Me.cmb_KKBN_ID = New System.Windows.Forms.ComboBox()
        Me.lbl_支払先 = New System.Windows.Forms.Label()
        Me.cmb_LCPT_ID = New System.Windows.Forms.ComboBox()
        Me.txt_LCPT_NM = New System.Windows.Forms.TextBox()
        Me.lbl_契約番号 = New System.Windows.Forms.Label()
        Me.txt_KYAK_NO = New System.Windows.Forms.TextBox()
        Me.lbl_契約日 = New System.Windows.Forms.Label()
        Me.dtp_KYAK_DT = New System.Windows.Forms.DateTimePicker()
        Me.lbl_再リース回数 = New System.Windows.Forms.Label()
        Me.txt_SAIKAISU = New System.Windows.Forms.TextBox()
        Me.lbl_契約終了 = New System.Windows.Forms.Label()
        Me.chk_KYAK_END_F = New System.Windows.Forms.CheckBox()
        Me.lbl_自社管理用 = New System.Windows.Forms.Label()
        Me.txt_JISH_KYAK_NO = New System.Windows.Forms.TextBox()
        Me.lbl_開始日 = New System.Windows.Forms.Label()
        Me.dtp_START_DT = New System.Windows.Forms.DateTimePicker()
        Me.lbl_契約期間 = New System.Windows.Forms.Label()
        Me.txt_LKIKAN = New System.Windows.Forms.TextBox()
        Me.Label_M2 = New System.Windows.Forms.Label()
        Me.lbl_稟議番号 = New System.Windows.Forms.Label()
        Me.txt_RNG_BANGO = New System.Windows.Forms.TextBox()
        Me.lbl_終了日 = New System.Windows.Forms.Label()
        Me.dtp_END_DT = New System.Windows.Forms.DateTimePicker()
        Me.lbl_遡及計上 = New System.Windows.Forms.Label()
        Me.chk_SKYU_KJ_F = New System.Windows.Forms.CheckBox()
        Me.lbl_支払間隔 = New System.Windows.Forms.Label()
        Me.txt_SHRI_KN = New System.Windows.Forms.TextBox()
        Me.Label_M3 = New System.Windows.Forms.Label()
        Me.lbl_前払回数 = New System.Windows.Forms.Label()
        Me.txt_MKAISU = New System.Windows.Forms.TextBox()
        Me.Label_M4 = New System.Windows.Forms.Label()
        Me.lbl_支払回数 = New System.Windows.Forms.Label()
        Me.txt_SHRI_CNT = New System.Windows.Forms.TextBox()
        Me.Label_M5 = New System.Windows.Forms.Label()
        Me.lbl_前払日 = New System.Windows.Forms.Label()
        Me.txt_MAE_DT = New System.Windows.Forms.DateTimePicker()
        Me.lbl_第1回支払日 = New System.Windows.Forms.Label()
        Me.txt_SHRI_DT1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_第2回支払日 = New System.Windows.Forms.Label()
        Me.txt_SHRI_DT2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_第3回以降 = New System.Windows.Forms.Label()
        Me.txt_SHRI_DT3 = New System.Windows.Forms.TextBox()
        Me.Label_M6 = New System.Windows.Forms.Label()
        Me.lbl_最終支払日 = New System.Windows.Forms.Label()
        Me.txt_SHRI_EN_DT = New System.Windows.Forms.DateTimePicker()
        Me.lbl_現金購入価額 = New System.Windows.Forms.Label()
        Me.txt_KNYUKN = New System.Windows.Forms.TextBox()
        Me.cmd_料率 = New System.Windows.Forms.Button()
        Me.txt_RYORITU = New System.Windows.Forms.TextBox()
        Me.cmd_税率 = New System.Windows.Forms.Button()
        Me.cmb_ZRITU = New System.Windows.Forms.ComboBox()
        Me.lbl_支払方法 = New System.Windows.Forms.Label()
        Me.cmb_SHHO_M_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_SHHO_1_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_SHHO_2_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_SHHO_3_ID = New System.Windows.Forms.ComboBox()
        Me.lbl_月額 = New System.Windows.Forms.Label()
        Me.txt_GLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_期間額 = New System.Windows.Forms.Label()
        Me.txt_KLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_前払 = New System.Windows.Forms.Label()
        Me.txt_MLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_総額 = New System.Windows.Forms.Label()
        Me.txt_SLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_税抜き = New System.Windows.Forms.Label()
        Me.lbl_消費税 = New System.Windows.Forms.Label()
        Me.txt_GZEI = New System.Windows.Forms.TextBox()
        Me.txt_KZEI = New System.Windows.Forms.TextBox()
        Me.txt_MZEI = New System.Windows.Forms.TextBox()
        Me.lbl_税込み = New System.Windows.Forms.Label()
        Me.txt_GLSRYO_ZEIKOMI = New System.Windows.Forms.TextBox()
        Me.txt_KLSRYO_ZKOMI = New System.Windows.Forms.TextBox()
        Me.txt_MLSRYO_ZKOMI = New System.Windows.Forms.TextBox()
        Me.lbl_維持管理費用 = New System.Windows.Forms.Label()
        Me.txt_IJIKNR = New System.Windows.Forms.TextBox()
        Me.lbl_残価保証額 = New System.Windows.Forms.Label()
        Me.txt_ZANRYO = New System.Windows.Forms.TextBox()
        Me.lbl_銀行口座 = New System.Windows.Forms.Label()
        Me.cmb_KOZA_ID = New System.Windows.Forms.ComboBox()
        Me.txt_KOZA_NM = New System.Windows.Forms.TextBox()
        Me.lbl_契約予備 = New System.Windows.Forms.Label()
        Me.cmb_RSRVK1_ID = New System.Windows.Forms.ComboBox()
        Me.txt_RSRVK1_NM = New System.Windows.Forms.TextBox()
        Me.lbl_備考 = New System.Windows.Forms.Label()
        Me.txt_K_ZOKUSEI1 = New System.Windows.Forms.TextBox()
        Me.lbl_契約名 = New System.Windows.Forms.Label()
        Me.txt_KYAK_NM = New System.Windows.Forms.TextBox()
        Me.cmd_物件画面 = New System.Windows.Forms.Button()
        Me.tab_f_KYKH_SUB = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_DETAILS = New System.Windows.Forms.DataGridView()
        Me.col_KYKM_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SUURYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KNYUKN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_GLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.TextBox()
        Me.txt_KYKH_NO = New System.Windows.Forms.TextBox()
        Me.txt_UPDATE_CNT = New System.Windows.Forms.TextBox()
        Me.txt_K_CREATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_K_UPDATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_REND_DT = New System.Windows.Forms.TextBox()
        Me.txt_K_KJYO_ST_DT = New System.Windows.Forms.TextBox()
        Me.txt_K_KJYO_EN_DT = New System.Windows.Forms.TextBox()
        Me.chk_CKAIYK_F = New System.Windows.Forms.CheckBox()
        Me.chk_K_SEIGOU_F = New System.Windows.Forms.CheckBox()
        Me.chk_K_HENF_F = New System.Windows.Forms.CheckBox()
        Me.chk_K_HENL_F = New System.Windows.Forms.CheckBox()
        Me.chk_JENCHO_F = New System.Windows.Forms.CheckBox()
        Me.pnlHeader.SuspendLayout()
        Me.pnlDetail.SuspendLayout()
        Me.tab_f_KYKH_SUB.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Controls.Add(Me.cmd_CREATE)
        Me.pnlHeader.Controls.Add(Me.cmd_REVISE)
        Me.pnlHeader.Controls.Add(Me.cmd_SAILEASE)
        Me.pnlHeader.Controls.Add(Me.cmd_KAIYAKU)
        Me.pnlHeader.Controls.Add(Me.cmd_ROLLBACK_SAI)
        Me.pnlHeader.Controls.Add(Me.cmd_DELETE)
        Me.pnlHeader.Controls.Add(Me.cmd_MODE_RESET)
        Me.pnlHeader.Controls.Add(Me.cmd_取込)
        Me.pnlHeader.Controls.Add(Me.cmd_CLEAR)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1500, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(8, 8)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(133, 8)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(133, 45)
        Me.cmd_CREATE.TabIndex = 1
        Me.cmd_CREATE.TabStop = False
        Me.cmd_CREATE.Text = "登録(&S)"
        '
        'cmd_REVISE
        '
        Me.cmd_REVISE.Location = New System.Drawing.Point(275, 8)
        Me.cmd_REVISE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REVISE.Name = "cmd_REVISE"
        Me.cmd_REVISE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_REVISE.TabIndex = 2
        Me.cmd_REVISE.TabStop = False
        Me.cmd_REVISE.Text = "修正(&V)"
        '
        'cmd_SAILEASE
        '
        Me.cmd_SAILEASE.Location = New System.Drawing.Point(400, 8)
        Me.cmd_SAILEASE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SAILEASE.Name = "cmd_SAILEASE"
        Me.cmd_SAILEASE.Size = New System.Drawing.Size(167, 45)
        Me.cmd_SAILEASE.TabIndex = 3
        Me.cmd_SAILEASE.TabStop = False
        Me.cmd_SAILEASE.Text = "再ﾘｰｽ/返却(&H)"
        '
        'cmd_KAIYAKU
        '
        Me.cmd_KAIYAKU.Location = New System.Drawing.Point(575, 8)
        Me.cmd_KAIYAKU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_KAIYAKU.Name = "cmd_KAIYAKU"
        Me.cmd_KAIYAKU.Size = New System.Drawing.Size(150, 45)
        Me.cmd_KAIYAKU.TabIndex = 4
        Me.cmd_KAIYAKU.TabStop = False
        Me.cmd_KAIYAKU.Text = "中途解約(&K)"
        '
        'cmd_ROLLBACK_SAI
        '
        Me.cmd_ROLLBACK_SAI.Location = New System.Drawing.Point(733, 8)
        Me.cmd_ROLLBACK_SAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ROLLBACK_SAI.Name = "cmd_ROLLBACK_SAI"
        Me.cmd_ROLLBACK_SAI.Size = New System.Drawing.Size(167, 45)
        Me.cmd_ROLLBACK_SAI.TabIndex = 5
        Me.cmd_ROLLBACK_SAI.TabStop = False
        Me.cmd_ROLLBACK_SAI.Text = "再ﾘｰｽ取消(&T)"
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(908, 8)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_DELETE.TabIndex = 6
        Me.cmd_DELETE.TabStop = False
        Me.cmd_DELETE.Text = "削除(&D)"
        '
        'cmd_MODE_RESET
        '
        Me.cmd_MODE_RESET.Location = New System.Drawing.Point(1033, 8)
        Me.cmd_MODE_RESET.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_MODE_RESET.Name = "cmd_MODE_RESET"
        Me.cmd_MODE_RESET.Size = New System.Drawing.Size(150, 45)
        Me.cmd_MODE_RESET.TabIndex = 7
        Me.cmd_MODE_RESET.TabStop = False
        Me.cmd_MODE_RESET.Text = "ﾓｰﾄﾞﾘｾｯﾄ(&M)"
        '
        'cmd_取込
        '
        Me.cmd_取込.Location = New System.Drawing.Point(1192, 8)
        Me.cmd_取込.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_取込.Name = "cmd_取込"
        Me.cmd_取込.Size = New System.Drawing.Size(117, 45)
        Me.cmd_取込.TabIndex = 8
        Me.cmd_取込.TabStop = False
        Me.cmd_取込.Text = "取込み(&I)"
        '
        'cmd_CLEAR
        '
        Me.cmd_CLEAR.Location = New System.Drawing.Point(1317, 8)
        Me.cmd_CLEAR.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLEAR.Name = "cmd_CLEAR"
        Me.cmd_CLEAR.Size = New System.Drawing.Size(117, 45)
        Me.cmd_CLEAR.TabIndex = 9
        Me.cmd_CLEAR.TabStop = False
        Me.cmd_CLEAR.Text = "クリア(&L)"
        '
        'pnlDetail
        '
        Me.pnlDetail.AutoScroll = True
        Me.pnlDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDetail.Controls.Add(Me.txt_CORP_NM)
        Me.pnlDetail.Controls.Add(Me.Label_M1)
        Me.pnlDetail.Controls.Add(Me.txt_Mode)
        Me.pnlDetail.Controls.Add(Me.lbl_計上区分)
        Me.pnlDetail.Controls.Add(Me.txt_KJKBN_NM)
        Me.pnlDetail.Controls.Add(Me.lbl_適用日)
        Me.pnlDetail.Controls.Add(Me.txt_TEKIYO_DT)
        Me.pnlDetail.Controls.Add(Me.lbl_管理単位)
        Me.pnlDetail.Controls.Add(Me.cmb_KKNRI_ID)
        Me.pnlDetail.Controls.Add(Me.txt_KKNRI_NM)
        Me.pnlDetail.Controls.Add(Me.lbl_契約区分)
        Me.pnlDetail.Controls.Add(Me.cmb_KKBN_ID)
        Me.pnlDetail.Controls.Add(Me.lbl_支払先)
        Me.pnlDetail.Controls.Add(Me.cmb_LCPT_ID)
        Me.pnlDetail.Controls.Add(Me.txt_LCPT_NM)
        Me.pnlDetail.Controls.Add(Me.lbl_契約番号)
        Me.pnlDetail.Controls.Add(Me.txt_KYAK_NO)
        Me.pnlDetail.Controls.Add(Me.lbl_契約日)
        Me.pnlDetail.Controls.Add(Me.dtp_KYAK_DT)
        Me.pnlDetail.Controls.Add(Me.lbl_再リース回数)
        Me.pnlDetail.Controls.Add(Me.txt_SAIKAISU)
        Me.pnlDetail.Controls.Add(Me.lbl_契約終了)
        Me.pnlDetail.Controls.Add(Me.chk_KYAK_END_F)
        Me.pnlDetail.Controls.Add(Me.lbl_自社管理用)
        Me.pnlDetail.Controls.Add(Me.txt_JISH_KYAK_NO)
        Me.pnlDetail.Controls.Add(Me.lbl_開始日)
        Me.pnlDetail.Controls.Add(Me.dtp_START_DT)
        Me.pnlDetail.Controls.Add(Me.lbl_契約期間)
        Me.pnlDetail.Controls.Add(Me.txt_LKIKAN)
        Me.pnlDetail.Controls.Add(Me.Label_M2)
        Me.pnlDetail.Controls.Add(Me.lbl_稟議番号)
        Me.pnlDetail.Controls.Add(Me.txt_RNG_BANGO)
        Me.pnlDetail.Controls.Add(Me.lbl_終了日)
        Me.pnlDetail.Controls.Add(Me.dtp_END_DT)
        Me.pnlDetail.Controls.Add(Me.lbl_遡及計上)
        Me.pnlDetail.Controls.Add(Me.chk_SKYU_KJ_F)
        Me.pnlDetail.Controls.Add(Me.lbl_支払間隔)
        Me.pnlDetail.Controls.Add(Me.txt_SHRI_KN)
        Me.pnlDetail.Controls.Add(Me.Label_M3)
        Me.pnlDetail.Controls.Add(Me.lbl_前払回数)
        Me.pnlDetail.Controls.Add(Me.txt_MKAISU)
        Me.pnlDetail.Controls.Add(Me.Label_M4)
        Me.pnlDetail.Controls.Add(Me.lbl_支払回数)
        Me.pnlDetail.Controls.Add(Me.txt_SHRI_CNT)
        Me.pnlDetail.Controls.Add(Me.Label_M5)
        Me.pnlDetail.Controls.Add(Me.lbl_前払日)
        Me.pnlDetail.Controls.Add(Me.txt_MAE_DT)
        Me.pnlDetail.Controls.Add(Me.lbl_第1回支払日)
        Me.pnlDetail.Controls.Add(Me.txt_SHRI_DT1)
        Me.pnlDetail.Controls.Add(Me.lbl_第2回支払日)
        Me.pnlDetail.Controls.Add(Me.txt_SHRI_DT2)
        Me.pnlDetail.Controls.Add(Me.lbl_第3回以降)
        Me.pnlDetail.Controls.Add(Me.txt_SHRI_DT3)
        Me.pnlDetail.Controls.Add(Me.Label_M6)
        Me.pnlDetail.Controls.Add(Me.lbl_最終支払日)
        Me.pnlDetail.Controls.Add(Me.txt_SHRI_EN_DT)
        Me.pnlDetail.Controls.Add(Me.lbl_現金購入価額)
        Me.pnlDetail.Controls.Add(Me.txt_KNYUKN)
        Me.pnlDetail.Controls.Add(Me.cmd_料率)
        Me.pnlDetail.Controls.Add(Me.txt_RYORITU)
        Me.pnlDetail.Controls.Add(Me.cmd_税率)
        Me.pnlDetail.Controls.Add(Me.cmb_ZRITU)
        Me.pnlDetail.Controls.Add(Me.lbl_支払方法)
        Me.pnlDetail.Controls.Add(Me.cmb_SHHO_M_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_SHHO_1_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_SHHO_2_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_SHHO_3_ID)
        Me.pnlDetail.Controls.Add(Me.lbl_月額)
        Me.pnlDetail.Controls.Add(Me.txt_GLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_期間額)
        Me.pnlDetail.Controls.Add(Me.txt_KLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_前払)
        Me.pnlDetail.Controls.Add(Me.txt_MLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_総額)
        Me.pnlDetail.Controls.Add(Me.txt_SLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_税抜き)
        Me.pnlDetail.Controls.Add(Me.lbl_消費税)
        Me.pnlDetail.Controls.Add(Me.txt_GZEI)
        Me.pnlDetail.Controls.Add(Me.txt_KZEI)
        Me.pnlDetail.Controls.Add(Me.txt_MZEI)
        Me.pnlDetail.Controls.Add(Me.lbl_税込み)
        Me.pnlDetail.Controls.Add(Me.txt_GLSRYO_ZEIKOMI)
        Me.pnlDetail.Controls.Add(Me.txt_KLSRYO_ZKOMI)
        Me.pnlDetail.Controls.Add(Me.txt_MLSRYO_ZKOMI)
        Me.pnlDetail.Controls.Add(Me.lbl_維持管理費用)
        Me.pnlDetail.Controls.Add(Me.txt_IJIKNR)
        Me.pnlDetail.Controls.Add(Me.lbl_残価保証額)
        Me.pnlDetail.Controls.Add(Me.txt_ZANRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_銀行口座)
        Me.pnlDetail.Controls.Add(Me.cmb_KOZA_ID)
        Me.pnlDetail.Controls.Add(Me.txt_KOZA_NM)
        Me.pnlDetail.Controls.Add(Me.lbl_契約予備)
        Me.pnlDetail.Controls.Add(Me.cmb_RSRVK1_ID)
        Me.pnlDetail.Controls.Add(Me.txt_RSRVK1_NM)
        Me.pnlDetail.Controls.Add(Me.lbl_備考)
        Me.pnlDetail.Controls.Add(Me.txt_K_ZOKUSEI1)
        Me.pnlDetail.Controls.Add(Me.lbl_契約名)
        Me.pnlDetail.Controls.Add(Me.txt_KYAK_NM)
        Me.pnlDetail.Controls.Add(Me.cmd_物件画面)
        Me.pnlDetail.Controls.Add(Me.tab_f_KYKH_SUB)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetail.Location = New System.Drawing.Point(0, 60)
        Me.pnlDetail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(1500, 840)
        Me.pnlDetail.TabIndex = 0
        '
        'txt_CORP_NM
        '
        Me.txt_CORP_NM.Location = New System.Drawing.Point(848, 34)
        Me.txt_CORP_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CORP_NM.Name = "txt_CORP_NM"
        Me.txt_CORP_NM.ReadOnly = True
        Me.txt_CORP_NM.Size = New System.Drawing.Size(161, 25)
        Me.txt_CORP_NM.TabIndex = 99
        Me.txt_CORP_NM.TabStop = False
        '
        'Label_M1
        '
        Me.Label_M1.Location = New System.Drawing.Point(1030, 120)
        Me.Label_M1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M1.Name = "Label_M1"
        Me.Label_M1.Size = New System.Drawing.Size(50, 22)
        Me.Label_M1.TabIndex = 0
        Me.Label_M1.Text = "ヶ月"
        '
        'txt_Mode
        '
        Me.txt_Mode.BackColor = System.Drawing.Color.Red
        Me.txt_Mode.ForeColor = System.Drawing.Color.White
        Me.txt_Mode.Location = New System.Drawing.Point(7, 6)
        Me.txt_Mode.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_Mode.Name = "txt_Mode"
        Me.txt_Mode.Size = New System.Drawing.Size(91, 25)
        Me.txt_Mode.TabIndex = 1
        Me.txt_Mode.Text = "新規"
        '
        'lbl_計上区分
        '
        Me.lbl_計上区分.Location = New System.Drawing.Point(127, 6)
        Me.lbl_計上区分.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_計上区分.Name = "lbl_計上区分"
        Me.lbl_計上区分.Size = New System.Drawing.Size(127, 22)
        Me.lbl_計上区分.TabIndex = 2
        Me.lbl_計上区分.Text = "計上対象"
        '
        'txt_KJKBN_NM
        '
        Me.txt_KJKBN_NM.Location = New System.Drawing.Point(252, 6)
        Me.txt_KJKBN_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KJKBN_NM.Name = "txt_KJKBN_NM"
        Me.txt_KJKBN_NM.ReadOnly = True
        Me.txt_KJKBN_NM.Size = New System.Drawing.Size(67, 25)
        Me.txt_KJKBN_NM.TabIndex = 0
        Me.txt_KJKBN_NM.TabStop = False
        '
        'lbl_適用日
        '
        Me.lbl_適用日.Location = New System.Drawing.Point(327, 6)
        Me.lbl_適用日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_適用日.Name = "lbl_適用日"
        Me.lbl_適用日.Size = New System.Drawing.Size(83, 22)
        Me.lbl_適用日.TabIndex = 4
        Me.lbl_適用日.Text = "適用日"
        '
        'txt_TEKIYO_DT
        '
        Me.txt_TEKIYO_DT.Enabled = False
        Me.txt_TEKIYO_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_TEKIYO_DT.Location = New System.Drawing.Point(412, 3)
        Me.txt_TEKIYO_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_TEKIYO_DT.Name = "txt_TEKIYO_DT"
        Me.txt_TEKIYO_DT.Size = New System.Drawing.Size(186, 25)
        Me.txt_TEKIYO_DT.TabIndex = 5
        Me.txt_TEKIYO_DT.TabStop = False
        '
        'lbl_管理単位
        '
        Me.lbl_管理単位.Location = New System.Drawing.Point(127, 34)
        Me.lbl_管理単位.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_管理単位.Name = "lbl_管理単位"
        Me.lbl_管理単位.Size = New System.Drawing.Size(127, 22)
        Me.lbl_管理単位.TabIndex = 6
        Me.lbl_管理単位.Text = "管理単位"
        '
        'cmb_KKNRI_ID
        '
        Me.cmb_KKNRI_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_KKNRI_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_KKNRI_ID.Location = New System.Drawing.Point(252, 34)
        Me.cmb_KKNRI_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_KKNRI_ID.Name = "cmb_KKNRI_ID"
        Me.cmb_KKNRI_ID.Size = New System.Drawing.Size(156, 26)
        Me.cmb_KKNRI_ID.TabIndex = 0
        '
        'txt_KKNRI_NM
        '
        Me.txt_KKNRI_NM.Location = New System.Drawing.Point(410, 34)
        Me.txt_KKNRI_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KKNRI_NM.Name = "txt_KKNRI_NM"
        Me.txt_KKNRI_NM.ReadOnly = True
        Me.txt_KKNRI_NM.Size = New System.Drawing.Size(437, 25)
        Me.txt_KKNRI_NM.TabIndex = 8
        Me.txt_KKNRI_NM.TabStop = False
        '
        'lbl_契約区分
        '
        Me.lbl_契約区分.Location = New System.Drawing.Point(127, 63)
        Me.lbl_契約区分.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約区分.Name = "lbl_契約区分"
        Me.lbl_契約区分.Size = New System.Drawing.Size(127, 22)
        Me.lbl_契約区分.TabIndex = 9
        Me.lbl_契約区分.Text = "契約区分"
        '
        'cmb_KKBN_ID
        '
        Me.cmb_KKBN_ID.Location = New System.Drawing.Point(252, 63)
        Me.cmb_KKBN_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_KKBN_ID.Name = "cmb_KKBN_ID"
        Me.cmb_KKBN_ID.Size = New System.Drawing.Size(187, 26)
        Me.cmb_KKBN_ID.TabIndex = 1
        '
        'lbl_支払先
        '
        Me.lbl_支払先.Location = New System.Drawing.Point(472, 63)
        Me.lbl_支払先.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_支払先.Name = "lbl_支払先"
        Me.lbl_支払先.Size = New System.Drawing.Size(127, 22)
        Me.lbl_支払先.TabIndex = 11
        Me.lbl_支払先.Text = "支払先"
        '
        'cmb_LCPT_ID
        '
        Me.cmb_LCPT_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_LCPT_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_LCPT_ID.Location = New System.Drawing.Point(598, 63)
        Me.cmb_LCPT_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_LCPT_ID.Name = "cmb_LCPT_ID"
        Me.cmb_LCPT_ID.Size = New System.Drawing.Size(156, 26)
        Me.cmb_LCPT_ID.TabIndex = 2
        '
        'txt_LCPT_NM
        '
        Me.txt_LCPT_NM.Location = New System.Drawing.Point(757, 63)
        Me.txt_LCPT_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_LCPT_NM.Name = "txt_LCPT_NM"
        Me.txt_LCPT_NM.ReadOnly = True
        Me.txt_LCPT_NM.Size = New System.Drawing.Size(374, 25)
        Me.txt_LCPT_NM.TabIndex = 13
        Me.txt_LCPT_NM.TabStop = False
        '
        'lbl_契約番号
        '
        Me.lbl_契約番号.Location = New System.Drawing.Point(125, 92)
        Me.lbl_契約番号.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約番号.Name = "lbl_契約番号"
        Me.lbl_契約番号.Size = New System.Drawing.Size(138, 22)
        Me.lbl_契約番号.TabIndex = 14
        Me.lbl_契約番号.Text = "契約番号"
        '
        'txt_KYAK_NO
        '
        Me.txt_KYAK_NO.Location = New System.Drawing.Point(263, 92)
        Me.txt_KYAK_NO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KYAK_NO.Name = "txt_KYAK_NO"
        Me.txt_KYAK_NO.Size = New System.Drawing.Size(186, 25)
        Me.txt_KYAK_NO.TabIndex = 3
        '
        'lbl_契約日
        '
        Me.lbl_契約日.Location = New System.Drawing.Point(472, 92)
        Me.lbl_契約日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約日.Name = "lbl_契約日"
        Me.lbl_契約日.Size = New System.Drawing.Size(127, 22)
        Me.lbl_契約日.TabIndex = 16
        Me.lbl_契約日.Text = "契約日"
        '
        'dtp_KYAK_DT
        '
        Me.dtp_KYAK_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_KYAK_DT.Location = New System.Drawing.Point(598, 92)
        Me.dtp_KYAK_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtp_KYAK_DT.Name = "dtp_KYAK_DT"
        Me.dtp_KYAK_DT.Size = New System.Drawing.Size(214, 25)
        Me.dtp_KYAK_DT.TabIndex = 6
        '
        'lbl_再リース回数
        '
        Me.lbl_再リース回数.Location = New System.Drawing.Point(842, 94)
        Me.lbl_再リース回数.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_再リース回数.Name = "lbl_再リース回数"
        Me.lbl_再リース回数.Size = New System.Drawing.Size(127, 22)
        Me.lbl_再リース回数.TabIndex = 18
        Me.lbl_再リース回数.Text = "再リース回数"
        '
        'txt_SAIKAISU
        '
        Me.txt_SAIKAISU.Location = New System.Drawing.Point(967, 92)
        Me.txt_SAIKAISU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SAIKAISU.Name = "txt_SAIKAISU"
        Me.txt_SAIKAISU.Size = New System.Drawing.Size(111, 25)
        Me.txt_SAIKAISU.TabIndex = 19
        Me.txt_SAIKAISU.TabStop = False
        Me.txt_SAIKAISU.Text = "0"
        Me.txt_SAIKAISU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_契約終了
        '
        Me.lbl_契約終了.Location = New System.Drawing.Point(1093, 94)
        Me.lbl_契約終了.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約終了.Name = "lbl_契約終了"
        Me.lbl_契約終了.Size = New System.Drawing.Size(127, 22)
        Me.lbl_契約終了.TabIndex = 20
        Me.lbl_契約終了.Text = "契約終了"
        '
        'chk_KYAK_END_F
        '
        Me.chk_KYAK_END_F.Location = New System.Drawing.Point(1232, 94)
        Me.chk_KYAK_END_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_KYAK_END_F.Name = "chk_KYAK_END_F"
        Me.chk_KYAK_END_F.Size = New System.Drawing.Size(25, 21)
        Me.chk_KYAK_END_F.TabIndex = 21
        '
        'lbl_自社管理用
        '
        Me.lbl_自社管理用.Location = New System.Drawing.Point(125, 114)
        Me.lbl_自社管理用.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_自社管理用.Name = "lbl_自社管理用"
        Me.lbl_自社管理用.Size = New System.Drawing.Size(138, 22)
        Me.lbl_自社管理用.TabIndex = 22
        Me.lbl_自社管理用.Text = "自社管理用"
        '
        'txt_JISH_KYAK_NO
        '
        Me.txt_JISH_KYAK_NO.Location = New System.Drawing.Point(263, 114)
        Me.txt_JISH_KYAK_NO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_JISH_KYAK_NO.Name = "txt_JISH_KYAK_NO"
        Me.txt_JISH_KYAK_NO.Size = New System.Drawing.Size(186, 25)
        Me.txt_JISH_KYAK_NO.TabIndex = 4
        '
        'lbl_開始日
        '
        Me.lbl_開始日.Location = New System.Drawing.Point(472, 114)
        Me.lbl_開始日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_開始日.Name = "lbl_開始日"
        Me.lbl_開始日.Size = New System.Drawing.Size(127, 22)
        Me.lbl_開始日.TabIndex = 24
        Me.lbl_開始日.Text = "開始日"
        '
        'dtp_START_DT
        '
        Me.dtp_START_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_START_DT.Location = New System.Drawing.Point(598, 114)
        Me.dtp_START_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtp_START_DT.Name = "dtp_START_DT"
        Me.dtp_START_DT.Size = New System.Drawing.Size(214, 25)
        Me.dtp_START_DT.TabIndex = 7
        '
        'lbl_契約期間
        '
        Me.lbl_契約期間.Location = New System.Drawing.Point(842, 120)
        Me.lbl_契約期間.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約期間.Name = "lbl_契約期間"
        Me.lbl_契約期間.Size = New System.Drawing.Size(127, 22)
        Me.lbl_契約期間.TabIndex = 26
        Me.lbl_契約期間.Text = "契約期間"
        '
        'txt_LKIKAN
        '
        Me.txt_LKIKAN.Location = New System.Drawing.Point(967, 114)
        Me.txt_LKIKAN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_LKIKAN.Name = "txt_LKIKAN"
        Me.txt_LKIKAN.Size = New System.Drawing.Size(61, 25)
        Me.txt_LKIKAN.TabIndex = 8
        Me.txt_LKIKAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_M2
        '
        Me.Label_M2.Location = New System.Drawing.Point(0, 0)
        Me.Label_M2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M2.Name = "Label_M2"
        Me.Label_M2.Size = New System.Drawing.Size(167, 34)
        Me.Label_M2.TabIndex = 28
        '
        'lbl_稟議番号
        '
        Me.lbl_稟議番号.Location = New System.Drawing.Point(125, 136)
        Me.lbl_稟議番号.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_稟議番号.Name = "lbl_稟議番号"
        Me.lbl_稟議番号.Size = New System.Drawing.Size(138, 22)
        Me.lbl_稟議番号.TabIndex = 29
        Me.lbl_稟議番号.Text = "稟議番号"
        '
        'txt_RNG_BANGO
        '
        Me.txt_RNG_BANGO.Location = New System.Drawing.Point(263, 136)
        Me.txt_RNG_BANGO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_RNG_BANGO.Name = "txt_RNG_BANGO"
        Me.txt_RNG_BANGO.Size = New System.Drawing.Size(186, 25)
        Me.txt_RNG_BANGO.TabIndex = 5
        '
        'lbl_終了日
        '
        Me.lbl_終了日.Location = New System.Drawing.Point(472, 136)
        Me.lbl_終了日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_終了日.Name = "lbl_終了日"
        Me.lbl_終了日.Size = New System.Drawing.Size(127, 22)
        Me.lbl_終了日.TabIndex = 31
        Me.lbl_終了日.Text = "終了日"
        '
        'dtp_END_DT
        '
        Me.dtp_END_DT.Enabled = False
        Me.dtp_END_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_END_DT.Location = New System.Drawing.Point(598, 136)
        Me.dtp_END_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtp_END_DT.Name = "dtp_END_DT"
        Me.dtp_END_DT.Size = New System.Drawing.Size(214, 25)
        Me.dtp_END_DT.TabIndex = 32
        Me.dtp_END_DT.TabStop = False
        '
        'lbl_遡及計上
        '
        Me.lbl_遡及計上.Location = New System.Drawing.Point(1093, 120)
        Me.lbl_遡及計上.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_遡及計上.Name = "lbl_遡及計上"
        Me.lbl_遡及計上.Size = New System.Drawing.Size(127, 22)
        Me.lbl_遡及計上.TabIndex = 33
        Me.lbl_遡及計上.Text = "遡及計上"
        '
        'chk_SKYU_KJ_F
        '
        Me.chk_SKYU_KJ_F.Location = New System.Drawing.Point(1232, 122)
        Me.chk_SKYU_KJ_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_SKYU_KJ_F.Name = "chk_SKYU_KJ_F"
        Me.chk_SKYU_KJ_F.Size = New System.Drawing.Size(25, 21)
        Me.chk_SKYU_KJ_F.TabIndex = 34
        '
        'lbl_支払間隔
        '
        Me.lbl_支払間隔.Location = New System.Drawing.Point(125, 164)
        Me.lbl_支払間隔.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_支払間隔.Name = "lbl_支払間隔"
        Me.lbl_支払間隔.Size = New System.Drawing.Size(127, 22)
        Me.lbl_支払間隔.TabIndex = 35
        Me.lbl_支払間隔.Text = "支払間隔"
        '
        'txt_SHRI_KN
        '
        Me.txt_SHRI_KN.Location = New System.Drawing.Point(125, 186)
        Me.txt_SHRI_KN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHRI_KN.Name = "txt_SHRI_KN"
        Me.txt_SHRI_KN.Size = New System.Drawing.Size(47, 25)
        Me.txt_SHRI_KN.TabIndex = 9
        Me.txt_SHRI_KN.Text = "1"
        Me.txt_SHRI_KN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_M3
        '
        Me.Label_M3.Location = New System.Drawing.Point(175, 186)
        Me.Label_M3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M3.Name = "Label_M3"
        Me.Label_M3.Size = New System.Drawing.Size(75, 22)
        Me.Label_M3.TabIndex = 37
        Me.Label_M3.Text = "ヶ月"
        '
        'lbl_前払回数
        '
        Me.lbl_前払回数.Location = New System.Drawing.Point(252, 164)
        Me.lbl_前払回数.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_前払回数.Name = "lbl_前払回数"
        Me.lbl_前払回数.Size = New System.Drawing.Size(127, 22)
        Me.lbl_前払回数.TabIndex = 38
        Me.lbl_前払回数.Text = "前払回数"
        '
        'txt_MKAISU
        '
        Me.txt_MKAISU.Location = New System.Drawing.Point(252, 186)
        Me.txt_MKAISU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MKAISU.Name = "txt_MKAISU"
        Me.txt_MKAISU.Size = New System.Drawing.Size(47, 25)
        Me.txt_MKAISU.TabIndex = 10
        Me.txt_MKAISU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_M4
        '
        Me.Label_M4.Location = New System.Drawing.Point(302, 186)
        Me.Label_M4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M4.Name = "Label_M4"
        Me.Label_M4.Size = New System.Drawing.Size(75, 22)
        Me.Label_M4.TabIndex = 40
        Me.Label_M4.Text = "回"
        '
        'lbl_支払回数
        '
        Me.lbl_支払回数.Location = New System.Drawing.Point(377, 164)
        Me.lbl_支払回数.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_支払回数.Name = "lbl_支払回数"
        Me.lbl_支払回数.Size = New System.Drawing.Size(127, 22)
        Me.lbl_支払回数.TabIndex = 41
        Me.lbl_支払回数.Text = "支払回数"
        '
        'txt_SHRI_CNT
        '
        Me.txt_SHRI_CNT.Location = New System.Drawing.Point(377, 186)
        Me.txt_SHRI_CNT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHRI_CNT.Name = "txt_SHRI_CNT"
        Me.txt_SHRI_CNT.Size = New System.Drawing.Size(47, 25)
        Me.txt_SHRI_CNT.TabIndex = 11
        Me.txt_SHRI_CNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_M5
        '
        Me.Label_M5.Location = New System.Drawing.Point(427, 186)
        Me.Label_M5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M5.Name = "Label_M5"
        Me.Label_M5.Size = New System.Drawing.Size(75, 22)
        Me.Label_M5.TabIndex = 43
        Me.Label_M5.Text = "回"
        '
        'lbl_前払日
        '
        Me.lbl_前払日.Location = New System.Drawing.Point(503, 164)
        Me.lbl_前払日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_前払日.Name = "lbl_前払日"
        Me.lbl_前払日.Size = New System.Drawing.Size(127, 22)
        Me.lbl_前払日.TabIndex = 44
        Me.lbl_前払日.Text = "前払日"
        '
        'txt_MAE_DT
        '
        Me.txt_MAE_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_MAE_DT.Location = New System.Drawing.Point(503, 186)
        Me.txt_MAE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MAE_DT.Name = "txt_MAE_DT"
        Me.txt_MAE_DT.ShowCheckBox = True
        Me.txt_MAE_DT.Size = New System.Drawing.Size(186, 25)
        Me.txt_MAE_DT.TabIndex = 12
        '
        'lbl_第1回支払日
        '
        Me.lbl_第1回支払日.Location = New System.Drawing.Point(697, 164)
        Me.lbl_第1回支払日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_第1回支払日.Name = "lbl_第1回支払日"
        Me.lbl_第1回支払日.Size = New System.Drawing.Size(132, 22)
        Me.lbl_第1回支払日.TabIndex = 46
        Me.lbl_第1回支払日.Text = "第1回支払日"
        '
        'txt_SHRI_DT1
        '
        Me.txt_SHRI_DT1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_SHRI_DT1.Location = New System.Drawing.Point(700, 184)
        Me.txt_SHRI_DT1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHRI_DT1.Name = "txt_SHRI_DT1"
        Me.txt_SHRI_DT1.Size = New System.Drawing.Size(162, 25)
        Me.txt_SHRI_DT1.TabIndex = 13
        '
        'lbl_第2回支払日
        '
        Me.lbl_第2回支払日.Location = New System.Drawing.Point(880, 164)
        Me.lbl_第2回支払日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_第2回支払日.Name = "lbl_第2回支払日"
        Me.lbl_第2回支払日.Size = New System.Drawing.Size(132, 22)
        Me.lbl_第2回支払日.TabIndex = 48
        Me.lbl_第2回支払日.Text = "第2回支払日"
        '
        'txt_SHRI_DT2
        '
        Me.txt_SHRI_DT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_SHRI_DT2.Location = New System.Drawing.Point(880, 183)
        Me.txt_SHRI_DT2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHRI_DT2.Name = "txt_SHRI_DT2"
        Me.txt_SHRI_DT2.Size = New System.Drawing.Size(159, 25)
        Me.txt_SHRI_DT2.TabIndex = 14
        '
        'lbl_第3回以降
        '
        Me.lbl_第3回以降.Location = New System.Drawing.Point(1050, 164)
        Me.lbl_第3回以降.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_第3回以降.Name = "lbl_第3回以降"
        Me.lbl_第3回以降.Size = New System.Drawing.Size(107, 22)
        Me.lbl_第3回以降.TabIndex = 50
        Me.lbl_第3回以降.Text = "第3回以降"
        '
        'txt_SHRI_DT3
        '
        Me.txt_SHRI_DT3.Location = New System.Drawing.Point(1050, 183)
        Me.txt_SHRI_DT3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHRI_DT3.Name = "txt_SHRI_DT3"
        Me.txt_SHRI_DT3.Size = New System.Drawing.Size(47, 25)
        Me.txt_SHRI_DT3.TabIndex = 51
        Me.txt_SHRI_DT3.TabStop = False
        Me.txt_SHRI_DT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label_M6
        '
        Me.Label_M6.Location = New System.Drawing.Point(1100, 189)
        Me.Label_M6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M6.Name = "Label_M6"
        Me.Label_M6.Size = New System.Drawing.Size(57, 28)
        Me.Label_M6.TabIndex = 52
        Me.Label_M6.Text = "日"
        '
        'lbl_最終支払日
        '
        Me.lbl_最終支払日.Location = New System.Drawing.Point(1152, 159)
        Me.lbl_最終支払日.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_最終支払日.Name = "lbl_最終支払日"
        Me.lbl_最終支払日.Size = New System.Drawing.Size(127, 22)
        Me.lbl_最終支払日.TabIndex = 53
        Me.lbl_最終支払日.Text = "最終支払日"
        '
        'txt_SHRI_EN_DT
        '
        Me.txt_SHRI_EN_DT.Enabled = False
        Me.txt_SHRI_EN_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_SHRI_EN_DT.Location = New System.Drawing.Point(1152, 184)
        Me.txt_SHRI_EN_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHRI_EN_DT.Name = "txt_SHRI_EN_DT"
        Me.txt_SHRI_EN_DT.Size = New System.Drawing.Size(164, 25)
        Me.txt_SHRI_EN_DT.TabIndex = 54
        Me.txt_SHRI_EN_DT.TabStop = False
        '
        'lbl_現金購入価額
        '
        Me.lbl_現金購入価額.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_現金購入価額.ForeColor = System.Drawing.Color.White
        Me.lbl_現金購入価額.Location = New System.Drawing.Point(12, 216)
        Me.lbl_現金購入価額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_現金購入価額.Name = "lbl_現金購入価額"
        Me.lbl_現金購入価額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_現金購入価額.TabIndex = 55
        Me.lbl_現金購入価額.Text = "現金購入価額"
        '
        'txt_KNYUKN
        '
        Me.txt_KNYUKN.Location = New System.Drawing.Point(170, 216)
        Me.txt_KNYUKN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KNYUKN.Name = "txt_KNYUKN"
        Me.txt_KNYUKN.Size = New System.Drawing.Size(156, 25)
        Me.txt_KNYUKN.TabIndex = 15
        Me.txt_KNYUKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmd_料率
        '
        Me.cmd_料率.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_料率.ForeColor = System.Drawing.Color.Yellow
        Me.cmd_料率.Location = New System.Drawing.Point(12, 249)
        Me.cmd_料率.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_料率.Name = "cmd_料率"
        Me.cmd_料率.Size = New System.Drawing.Size(158, 34)
        Me.cmd_料率.TabIndex = 57
        Me.cmd_料率.Text = "料率(&R)"
        Me.cmd_料率.UseVisualStyleBackColor = False
        '
        'txt_RYORITU
        '
        Me.txt_RYORITU.Location = New System.Drawing.Point(170, 249)
        Me.txt_RYORITU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_RYORITU.Name = "txt_RYORITU"
        Me.txt_RYORITU.Size = New System.Drawing.Size(124, 25)
        Me.txt_RYORITU.TabIndex = 58
        Me.txt_RYORITU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmd_税率
        '
        Me.cmd_税率.Location = New System.Drawing.Point(12, 278)
        Me.cmd_税率.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_税率.Name = "cmd_税率"
        Me.cmd_税率.Size = New System.Drawing.Size(158, 34)
        Me.cmd_税率.TabIndex = 59
        Me.cmd_税率.Text = "消費税率(&Z)"
        '
        'cmb_ZRITU
        '
        Me.cmb_ZRITU.Location = New System.Drawing.Point(170, 276)
        Me.cmb_ZRITU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_ZRITU.Name = "cmb_ZRITU"
        Me.cmb_ZRITU.Size = New System.Drawing.Size(124, 26)
        Me.cmb_ZRITU.TabIndex = 60
        '
        'lbl_支払方法
        '
        Me.lbl_支払方法.Location = New System.Drawing.Point(465, 214)
        Me.lbl_支払方法.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_支払方法.Name = "lbl_支払方法"
        Me.lbl_支払方法.Size = New System.Drawing.Size(127, 22)
        Me.lbl_支払方法.TabIndex = 61
        Me.lbl_支払方法.Text = "支払方法"
        '
        'cmb_SHHO_M_ID
        '
        Me.cmb_SHHO_M_ID.Location = New System.Drawing.Point(465, 237)
        Me.cmb_SHHO_M_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SHHO_M_ID.Name = "cmb_SHHO_M_ID"
        Me.cmb_SHHO_M_ID.Size = New System.Drawing.Size(124, 26)
        Me.cmb_SHHO_M_ID.TabIndex = 16
        '
        'cmb_SHHO_1_ID
        '
        Me.cmb_SHHO_1_ID.Location = New System.Drawing.Point(465, 260)
        Me.cmb_SHHO_1_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SHHO_1_ID.Name = "cmb_SHHO_1_ID"
        Me.cmb_SHHO_1_ID.Size = New System.Drawing.Size(124, 26)
        Me.cmb_SHHO_1_ID.TabIndex = 17
        '
        'cmb_SHHO_2_ID
        '
        Me.cmb_SHHO_2_ID.Location = New System.Drawing.Point(465, 284)
        Me.cmb_SHHO_2_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SHHO_2_ID.Name = "cmb_SHHO_2_ID"
        Me.cmb_SHHO_2_ID.Size = New System.Drawing.Size(124, 26)
        Me.cmb_SHHO_2_ID.TabIndex = 18
        '
        'cmb_SHHO_3_ID
        '
        Me.cmb_SHHO_3_ID.Location = New System.Drawing.Point(465, 306)
        Me.cmb_SHHO_3_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SHHO_3_ID.Name = "cmb_SHHO_3_ID"
        Me.cmb_SHHO_3_ID.Size = New System.Drawing.Size(124, 26)
        Me.cmb_SHHO_3_ID.TabIndex = 19
        '
        'lbl_月額
        '
        Me.lbl_月額.BackColor = System.Drawing.Color.Blue
        Me.lbl_月額.ForeColor = System.Drawing.Color.White
        Me.lbl_月額.Location = New System.Drawing.Point(723, 248)
        Me.lbl_月額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_月額.Name = "lbl_月額"
        Me.lbl_月額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_月額.TabIndex = 66
        Me.lbl_月額.Text = "月額"
        '
        'txt_GLSRYO
        '
        Me.txt_GLSRYO.Location = New System.Drawing.Point(882, 248)
        Me.txt_GLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GLSRYO.Name = "txt_GLSRYO"
        Me.txt_GLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_GLSRYO.TabIndex = 20
        Me.txt_GLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_期間額
        '
        Me.lbl_期間額.BackColor = System.Drawing.Color.Blue
        Me.lbl_期間額.ForeColor = System.Drawing.Color.White
        Me.lbl_期間額.Location = New System.Drawing.Point(723, 270)
        Me.lbl_期間額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_期間額.Name = "lbl_期間額"
        Me.lbl_期間額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_期間額.TabIndex = 68
        Me.lbl_期間額.Text = "１支払額"
        '
        'txt_KLSRYO
        '
        Me.txt_KLSRYO.Location = New System.Drawing.Point(882, 270)
        Me.txt_KLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KLSRYO.Name = "txt_KLSRYO"
        Me.txt_KLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_KLSRYO.TabIndex = 23
        Me.txt_KLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_前払
        '
        Me.lbl_前払.BackColor = System.Drawing.Color.Blue
        Me.lbl_前払.ForeColor = System.Drawing.Color.White
        Me.lbl_前払.Location = New System.Drawing.Point(723, 294)
        Me.lbl_前払.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_前払.Name = "lbl_前払"
        Me.lbl_前払.Size = New System.Drawing.Size(158, 22)
        Me.lbl_前払.TabIndex = 70
        Me.lbl_前払.Text = "前払"
        '
        'txt_MLSRYO
        '
        Me.txt_MLSRYO.Location = New System.Drawing.Point(882, 294)
        Me.txt_MLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MLSRYO.Name = "txt_MLSRYO"
        Me.txt_MLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_MLSRYO.TabIndex = 26
        Me.txt_MLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_総額
        '
        Me.lbl_総額.BackColor = System.Drawing.Color.Blue
        Me.lbl_総額.ForeColor = System.Drawing.Color.White
        Me.lbl_総額.Location = New System.Drawing.Point(723, 316)
        Me.lbl_総額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_総額.Name = "lbl_総額"
        Me.lbl_総額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_総額.TabIndex = 72
        Me.lbl_総額.Text = "総額"
        '
        'txt_SLSRYO
        '
        Me.txt_SLSRYO.Location = New System.Drawing.Point(882, 316)
        Me.txt_SLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SLSRYO.Name = "txt_SLSRYO"
        Me.txt_SLSRYO.ReadOnly = True
        Me.txt_SLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_SLSRYO.TabIndex = 73
        Me.txt_SLSRYO.TabStop = False
        Me.txt_SLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_税抜き
        '
        Me.lbl_税抜き.Location = New System.Drawing.Point(882, 225)
        Me.lbl_税抜き.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_税抜き.Name = "lbl_税抜き"
        Me.lbl_税抜き.Size = New System.Drawing.Size(158, 22)
        Me.lbl_税抜き.TabIndex = 74
        Me.lbl_税抜き.Text = "税抜き"
        '
        'lbl_消費税
        '
        Me.lbl_消費税.Location = New System.Drawing.Point(1040, 225)
        Me.lbl_消費税.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_消費税.Name = "lbl_消費税"
        Me.lbl_消費税.Size = New System.Drawing.Size(158, 22)
        Me.lbl_消費税.TabIndex = 75
        Me.lbl_消費税.Text = "消費税"
        '
        'txt_GZEI
        '
        Me.txt_GZEI.Location = New System.Drawing.Point(1038, 248)
        Me.txt_GZEI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GZEI.Name = "txt_GZEI"
        Me.txt_GZEI.Size = New System.Drawing.Size(156, 25)
        Me.txt_GZEI.TabIndex = 21
        Me.txt_GZEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_KZEI
        '
        Me.txt_KZEI.Location = New System.Drawing.Point(1038, 270)
        Me.txt_KZEI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KZEI.Name = "txt_KZEI"
        Me.txt_KZEI.Size = New System.Drawing.Size(156, 25)
        Me.txt_KZEI.TabIndex = 24
        Me.txt_KZEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MZEI
        '
        Me.txt_MZEI.Location = New System.Drawing.Point(1038, 294)
        Me.txt_MZEI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MZEI.Name = "txt_MZEI"
        Me.txt_MZEI.Size = New System.Drawing.Size(156, 25)
        Me.txt_MZEI.TabIndex = 27
        Me.txt_MZEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_税込み
        '
        Me.lbl_税込み.Location = New System.Drawing.Point(1197, 225)
        Me.lbl_税込み.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_税込み.Name = "lbl_税込み"
        Me.lbl_税込み.Size = New System.Drawing.Size(158, 22)
        Me.lbl_税込み.TabIndex = 79
        Me.lbl_税込み.Text = "税込み"
        '
        'txt_GLSRYO_ZEIKOMI
        '
        Me.txt_GLSRYO_ZEIKOMI.Location = New System.Drawing.Point(1197, 248)
        Me.txt_GLSRYO_ZEIKOMI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GLSRYO_ZEIKOMI.Name = "txt_GLSRYO_ZEIKOMI"
        Me.txt_GLSRYO_ZEIKOMI.Size = New System.Drawing.Size(156, 25)
        Me.txt_GLSRYO_ZEIKOMI.TabIndex = 22
        Me.txt_GLSRYO_ZEIKOMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_KLSRYO_ZKOMI
        '
        Me.txt_KLSRYO_ZKOMI.Location = New System.Drawing.Point(1197, 270)
        Me.txt_KLSRYO_ZKOMI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KLSRYO_ZKOMI.Name = "txt_KLSRYO_ZKOMI"
        Me.txt_KLSRYO_ZKOMI.Size = New System.Drawing.Size(156, 25)
        Me.txt_KLSRYO_ZKOMI.TabIndex = 25
        Me.txt_KLSRYO_ZKOMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MLSRYO_ZKOMI
        '
        Me.txt_MLSRYO_ZKOMI.Location = New System.Drawing.Point(1197, 294)
        Me.txt_MLSRYO_ZKOMI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MLSRYO_ZKOMI.Name = "txt_MLSRYO_ZKOMI"
        Me.txt_MLSRYO_ZKOMI.Size = New System.Drawing.Size(156, 25)
        Me.txt_MLSRYO_ZKOMI.TabIndex = 28
        Me.txt_MLSRYO_ZKOMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_維持管理費用
        '
        Me.lbl_維持管理費用.BackColor = System.Drawing.Color.Blue
        Me.lbl_維持管理費用.ForeColor = System.Drawing.Color.White
        Me.lbl_維持管理費用.Location = New System.Drawing.Point(723, 339)
        Me.lbl_維持管理費用.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_維持管理費用.Name = "lbl_維持管理費用"
        Me.lbl_維持管理費用.Size = New System.Drawing.Size(158, 22)
        Me.lbl_維持管理費用.TabIndex = 83
        Me.lbl_維持管理費用.Text = "内維持管理費用"
        '
        'txt_IJIKNR
        '
        Me.txt_IJIKNR.Location = New System.Drawing.Point(882, 339)
        Me.txt_IJIKNR.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_IJIKNR.Name = "txt_IJIKNR"
        Me.txt_IJIKNR.Size = New System.Drawing.Size(156, 25)
        Me.txt_IJIKNR.TabIndex = 29
        Me.txt_IJIKNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_残価保証額
        '
        Me.lbl_残価保証額.BackColor = System.Drawing.Color.Blue
        Me.lbl_残価保証額.ForeColor = System.Drawing.Color.White
        Me.lbl_残価保証額.Location = New System.Drawing.Point(723, 362)
        Me.lbl_残価保証額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_残価保証額.Name = "lbl_残価保証額"
        Me.lbl_残価保証額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_残価保証額.TabIndex = 85
        Me.lbl_残価保証額.Text = "残価保証額"
        '
        'txt_ZANRYO
        '
        Me.txt_ZANRYO.Location = New System.Drawing.Point(882, 362)
        Me.txt_ZANRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZANRYO.Name = "txt_ZANRYO"
        Me.txt_ZANRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_ZANRYO.TabIndex = 30
        Me.txt_ZANRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_銀行口座
        '
        Me.lbl_銀行口座.Location = New System.Drawing.Point(12, 339)
        Me.lbl_銀行口座.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_銀行口座.Name = "lbl_銀行口座"
        Me.lbl_銀行口座.Size = New System.Drawing.Size(127, 22)
        Me.lbl_銀行口座.TabIndex = 87
        Me.lbl_銀行口座.Text = "銀行口座"
        '
        'cmb_KOZA_ID
        '
        Me.cmb_KOZA_ID.Location = New System.Drawing.Point(138, 339)
        Me.cmb_KOZA_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_KOZA_ID.Name = "cmb_KOZA_ID"
        Me.cmb_KOZA_ID.Size = New System.Drawing.Size(156, 26)
        Me.cmb_KOZA_ID.TabIndex = 31
        '
        'txt_KOZA_NM
        '
        Me.txt_KOZA_NM.Location = New System.Drawing.Point(295, 339)
        Me.txt_KOZA_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KOZA_NM.Name = "txt_KOZA_NM"
        Me.txt_KOZA_NM.ReadOnly = True
        Me.txt_KOZA_NM.Size = New System.Drawing.Size(249, 25)
        Me.txt_KOZA_NM.TabIndex = 89
        Me.txt_KOZA_NM.TabStop = False
        '
        'lbl_契約予備
        '
        Me.lbl_契約予備.Location = New System.Drawing.Point(12, 368)
        Me.lbl_契約予備.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約予備.Name = "lbl_契約予備"
        Me.lbl_契約予備.Size = New System.Drawing.Size(127, 22)
        Me.lbl_契約予備.TabIndex = 90
        Me.lbl_契約予備.Text = "契約予備"
        '
        'cmb_RSRVK1_ID
        '
        Me.cmb_RSRVK1_ID.Location = New System.Drawing.Point(138, 368)
        Me.cmb_RSRVK1_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_RSRVK1_ID.Name = "cmb_RSRVK1_ID"
        Me.cmb_RSRVK1_ID.Size = New System.Drawing.Size(156, 26)
        Me.cmb_RSRVK1_ID.TabIndex = 32
        '
        'txt_RSRVK1_NM
        '
        Me.txt_RSRVK1_NM.Location = New System.Drawing.Point(295, 368)
        Me.txt_RSRVK1_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_RSRVK1_NM.Name = "txt_RSRVK1_NM"
        Me.txt_RSRVK1_NM.ReadOnly = True
        Me.txt_RSRVK1_NM.Size = New System.Drawing.Size(249, 25)
        Me.txt_RSRVK1_NM.TabIndex = 92
        Me.txt_RSRVK1_NM.TabStop = False
        '
        'lbl_備考
        '
        Me.lbl_備考.Location = New System.Drawing.Point(248, 402)
        Me.lbl_備考.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_備考.Name = "lbl_備考"
        Me.lbl_備考.Size = New System.Drawing.Size(127, 22)
        Me.lbl_備考.TabIndex = 93
        Me.lbl_備考.Text = "備考"
        '
        'txt_K_ZOKUSEI1
        '
        Me.txt_K_ZOKUSEI1.Location = New System.Drawing.Point(377, 399)
        Me.txt_K_ZOKUSEI1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_K_ZOKUSEI1.Name = "txt_K_ZOKUSEI1"
        Me.txt_K_ZOKUSEI1.Size = New System.Drawing.Size(766, 25)
        Me.txt_K_ZOKUSEI1.TabIndex = 33
        '
        'lbl_契約名
        '
        Me.lbl_契約名.Location = New System.Drawing.Point(248, 430)
        Me.lbl_契約名.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_契約名.Name = "lbl_契約名"
        Me.lbl_契約名.Size = New System.Drawing.Size(127, 22)
        Me.lbl_契約名.TabIndex = 95
        Me.lbl_契約名.Text = "契約名"
        '
        'txt_KYAK_NM
        '
        Me.txt_KYAK_NM.Location = New System.Drawing.Point(377, 430)
        Me.txt_KYAK_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KYAK_NM.Name = "txt_KYAK_NM"
        Me.txt_KYAK_NM.Size = New System.Drawing.Size(766, 25)
        Me.txt_KYAK_NM.TabIndex = 34
        '
        'cmd_物件画面
        '
        Me.cmd_物件画面.Location = New System.Drawing.Point(50, 430)
        Me.cmd_物件画面.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_物件画面.Name = "cmd_物件画面"
        Me.cmd_物件画面.Size = New System.Drawing.Size(158, 45)
        Me.cmd_物件画面.TabIndex = 35
        Me.cmd_物件画面.Text = "物件画面(&B)"
        '
        'tab_f_KYKH_SUB
        '
        Me.tab_f_KYKH_SUB.Controls.Add(Me.TabPage1)
        Me.tab_f_KYKH_SUB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tab_f_KYKH_SUB.Location = New System.Drawing.Point(0, 475)
        Me.tab_f_KYKH_SUB.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.tab_f_KYKH_SUB.Name = "tab_f_KYKH_SUB"
        Me.tab_f_KYKH_SUB.SelectedIndex = 0
        Me.tab_f_KYKH_SUB.Size = New System.Drawing.Size(1474, 375)
        Me.tab_f_KYKH_SUB.TabIndex = 98
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_DETAILS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1466, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "現在の物件(1)"
        '
        'dgv_DETAILS
        '
        Me.dgv_DETAILS.ColumnHeadersHeight = 34
        Me.dgv_DETAILS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_KYKM_ID, Me.col_BUKN_NM, Me.col_SUURYO, Me.col_KNYUKN, Me.col_GLSRYO})
        Me.dgv_DETAILS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_DETAILS.Location = New System.Drawing.Point(0, 0)
        Me.dgv_DETAILS.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_DETAILS.Name = "dgv_DETAILS"
        Me.dgv_DETAILS.RowHeadersWidth = 62
        Me.dgv_DETAILS.Size = New System.Drawing.Size(1466, 343)
        Me.dgv_DETAILS.TabIndex = 0
        '
        'col_KYKM_ID
        '
        Me.col_KYKM_ID.HeaderText = "物件ID"
        Me.col_KYKM_ID.MinimumWidth = 8
        Me.col_KYKM_ID.Name = "col_KYKM_ID"
        Me.col_KYKM_ID.Visible = False
        Me.col_KYKM_ID.Width = 150
        '
        'col_BUKN_NM
        '
        Me.col_BUKN_NM.HeaderText = "物件名称"
        Me.col_BUKN_NM.MinimumWidth = 8
        Me.col_BUKN_NM.Name = "col_BUKN_NM"
        Me.col_BUKN_NM.Width = 150
        '
        'col_SUURYO
        '
        Me.col_SUURYO.HeaderText = "数量"
        Me.col_SUURYO.MinimumWidth = 8
        Me.col_SUURYO.Name = "col_SUURYO"
        Me.col_SUURYO.Width = 150
        '
        'col_KNYUKN
        '
        Me.col_KNYUKN.HeaderText = "現金購入価額"
        Me.col_KNYUKN.MinimumWidth = 8
        Me.col_KNYUKN.Name = "col_KNYUKN"
        Me.col_KNYUKN.Width = 150
        '
        'col_GLSRYO
        '
        Me.col_GLSRYO.HeaderText = "月額リース料"
        Me.col_GLSRYO.MinimumWidth = 8
        Me.col_GLSRYO.Name = "col_GLSRYO"
        Me.col_GLSRYO.Width = 150
        '
        'txt_KYKH_ID
        '
        Me.txt_KYKH_ID.Location = New System.Drawing.Point(0, 0)
        Me.txt_KYKH_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KYKH_ID.Name = "txt_KYKH_ID"
        Me.txt_KYKH_ID.Size = New System.Drawing.Size(81, 25)
        Me.txt_KYKH_ID.TabIndex = 2
        Me.txt_KYKH_ID.Text = "0"
        Me.txt_KYKH_ID.Visible = False
        '
        'txt_KYKH_NO
        '
        Me.txt_KYKH_NO.Location = New System.Drawing.Point(0, 0)
        Me.txt_KYKH_NO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KYKH_NO.Name = "txt_KYKH_NO"
        Me.txt_KYKH_NO.Size = New System.Drawing.Size(164, 25)
        Me.txt_KYKH_NO.TabIndex = 3
        Me.txt_KYKH_NO.Text = "0"
        Me.txt_KYKH_NO.Visible = False
        '
        'txt_UPDATE_CNT
        '
        Me.txt_UPDATE_CNT.Location = New System.Drawing.Point(0, 0)
        Me.txt_UPDATE_CNT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_UPDATE_CNT.Name = "txt_UPDATE_CNT"
        Me.txt_UPDATE_CNT.Size = New System.Drawing.Size(164, 25)
        Me.txt_UPDATE_CNT.TabIndex = 4
        Me.txt_UPDATE_CNT.Text = "0"
        Me.txt_UPDATE_CNT.Visible = False
        '
        'txt_K_CREATE_DT
        '
        Me.txt_K_CREATE_DT.Location = New System.Drawing.Point(0, 0)
        Me.txt_K_CREATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_K_CREATE_DT.Name = "txt_K_CREATE_DT"
        Me.txt_K_CREATE_DT.Size = New System.Drawing.Size(164, 25)
        Me.txt_K_CREATE_DT.TabIndex = 5
        Me.txt_K_CREATE_DT.Visible = False
        '
        'txt_K_UPDATE_DT
        '
        Me.txt_K_UPDATE_DT.Location = New System.Drawing.Point(0, 0)
        Me.txt_K_UPDATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_K_UPDATE_DT.Name = "txt_K_UPDATE_DT"
        Me.txt_K_UPDATE_DT.Size = New System.Drawing.Size(164, 25)
        Me.txt_K_UPDATE_DT.TabIndex = 6
        Me.txt_K_UPDATE_DT.Visible = False
        '
        'txt_REND_DT
        '
        Me.txt_REND_DT.Location = New System.Drawing.Point(0, 0)
        Me.txt_REND_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_REND_DT.Name = "txt_REND_DT"
        Me.txt_REND_DT.Size = New System.Drawing.Size(164, 25)
        Me.txt_REND_DT.TabIndex = 7
        Me.txt_REND_DT.Visible = False
        '
        'txt_K_KJYO_ST_DT
        '
        Me.txt_K_KJYO_ST_DT.Location = New System.Drawing.Point(0, 0)
        Me.txt_K_KJYO_ST_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_K_KJYO_ST_DT.Name = "txt_K_KJYO_ST_DT"
        Me.txt_K_KJYO_ST_DT.Size = New System.Drawing.Size(164, 25)
        Me.txt_K_KJYO_ST_DT.TabIndex = 8
        Me.txt_K_KJYO_ST_DT.Visible = False
        '
        'txt_K_KJYO_EN_DT
        '
        Me.txt_K_KJYO_EN_DT.Location = New System.Drawing.Point(0, 0)
        Me.txt_K_KJYO_EN_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_K_KJYO_EN_DT.Name = "txt_K_KJYO_EN_DT"
        Me.txt_K_KJYO_EN_DT.Size = New System.Drawing.Size(164, 25)
        Me.txt_K_KJYO_EN_DT.TabIndex = 9
        Me.txt_K_KJYO_EN_DT.Visible = False
        '
        'chk_CKAIYK_F
        '
        Me.chk_CKAIYK_F.Location = New System.Drawing.Point(0, 0)
        Me.chk_CKAIYK_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_CKAIYK_F.Name = "chk_CKAIYK_F"
        Me.chk_CKAIYK_F.Size = New System.Drawing.Size(173, 36)
        Me.chk_CKAIYK_F.TabIndex = 10
        Me.chk_CKAIYK_F.Visible = False
        '
        'chk_K_SEIGOU_F
        '
        Me.chk_K_SEIGOU_F.Location = New System.Drawing.Point(0, 0)
        Me.chk_K_SEIGOU_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_K_SEIGOU_F.Name = "chk_K_SEIGOU_F"
        Me.chk_K_SEIGOU_F.Size = New System.Drawing.Size(173, 36)
        Me.chk_K_SEIGOU_F.TabIndex = 11
        Me.chk_K_SEIGOU_F.Visible = False
        '
        'chk_K_HENF_F
        '
        Me.chk_K_HENF_F.Location = New System.Drawing.Point(0, 0)
        Me.chk_K_HENF_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_K_HENF_F.Name = "chk_K_HENF_F"
        Me.chk_K_HENF_F.Size = New System.Drawing.Size(173, 36)
        Me.chk_K_HENF_F.TabIndex = 12
        Me.chk_K_HENF_F.Visible = False
        '
        'chk_K_HENL_F
        '
        Me.chk_K_HENL_F.Location = New System.Drawing.Point(0, 0)
        Me.chk_K_HENL_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_K_HENL_F.Name = "chk_K_HENL_F"
        Me.chk_K_HENL_F.Size = New System.Drawing.Size(173, 36)
        Me.chk_K_HENL_F.TabIndex = 13
        Me.chk_K_HENL_F.Visible = False
        '
        'chk_JENCHO_F
        '
        Me.chk_JENCHO_F.Location = New System.Drawing.Point(0, 0)
        Me.chk_JENCHO_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_JENCHO_F.Name = "chk_JENCHO_F"
        Me.chk_JENCHO_F.Size = New System.Drawing.Size(173, 36)
        Me.chk_JENCHO_F.TabIndex = 14
        Me.chk_JENCHO_F.Visible = False
        '
        'Form_ContractEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 900)
        Me.Controls.Add(Me.pnlDetail)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.txt_KYKH_ID)
        Me.Controls.Add(Me.txt_KYKH_NO)
        Me.Controls.Add(Me.txt_UPDATE_CNT)
        Me.Controls.Add(Me.txt_K_CREATE_DT)
        Me.Controls.Add(Me.txt_K_UPDATE_DT)
        Me.Controls.Add(Me.txt_REND_DT)
        Me.Controls.Add(Me.txt_K_KJYO_ST_DT)
        Me.Controls.Add(Me.txt_K_KJYO_EN_DT)
        Me.Controls.Add(Me.chk_CKAIYK_F)
        Me.Controls.Add(Me.chk_K_SEIGOU_F)
        Me.Controls.Add(Me.chk_K_HENF_F)
        Me.Controls.Add(Me.chk_K_HENL_F)
        Me.Controls.Add(Me.chk_JENCHO_F)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_ContractEntry"
        Me.Text = "契約書"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlDetail.ResumeLayout(False)
        Me.pnlDetail.PerformLayout()
        Me.tab_f_KYKH_SUB.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlDetail As System.Windows.Forms.Panel

    ' Header Buttons
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_CREATE As System.Windows.Forms.Button
    Friend WithEvents cmd_REVISE As System.Windows.Forms.Button
    Friend WithEvents cmd_SAILEASE As System.Windows.Forms.Button
    Friend WithEvents cmd_KAIYAKU As System.Windows.Forms.Button
    Friend WithEvents cmd_ROLLBACK_SAI As System.Windows.Forms.Button
    Friend WithEvents cmd_DELETE As System.Windows.Forms.Button
    Friend WithEvents cmd_MODE_RESET As System.Windows.Forms.Button
    Friend WithEvents cmd_取込 As System.Windows.Forms.Button
    Friend WithEvents cmd_CLEAR As System.Windows.Forms.Button

    ' Detail Controls (Access Names)
    Friend WithEvents txt_Mode As System.Windows.Forms.TextBox
    Friend WithEvents Label_M1 As System.Windows.Forms.Label
    Friend WithEvents lbl_計上区分 As System.Windows.Forms.Label
    Friend WithEvents txt_KJKBN_NM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_適用日 As System.Windows.Forms.Label
    Friend WithEvents txt_TEKIYO_DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_管理単位 As System.Windows.Forms.Label
    Friend WithEvents cmb_KKNRI_ID As System.Windows.Forms.ComboBox
    Friend WithEvents txt_KKNRI_NM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_契約区分 As System.Windows.Forms.Label
    Friend WithEvents cmb_KKBN_ID As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_支払先 As System.Windows.Forms.Label
    Friend WithEvents cmb_LCPT_ID As System.Windows.Forms.ComboBox
    Friend WithEvents txt_LCPT_NM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_契約番号 As System.Windows.Forms.Label
    Friend WithEvents txt_KYAK_NO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_契約日 As System.Windows.Forms.Label
    Friend WithEvents dtp_KYAK_DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_再リース回数 As System.Windows.Forms.Label
    Friend WithEvents txt_SAIKAISU As System.Windows.Forms.TextBox
    Friend WithEvents lbl_契約終了 As System.Windows.Forms.Label
    Friend WithEvents chk_KYAK_END_F As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_自社管理用 As System.Windows.Forms.Label
    Friend WithEvents txt_JISH_KYAK_NO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_開始日 As System.Windows.Forms.Label
    Friend WithEvents dtp_START_DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_契約期間 As System.Windows.Forms.Label
    Friend WithEvents txt_LKIKAN As System.Windows.Forms.TextBox
    Friend WithEvents Label_M2 As System.Windows.Forms.Label
    Friend WithEvents lbl_稟議番号 As System.Windows.Forms.Label
    Friend WithEvents txt_RNG_BANGO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_終了日 As System.Windows.Forms.Label
    Friend WithEvents dtp_END_DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_遡及計上 As System.Windows.Forms.Label
    Friend WithEvents chk_SKYU_KJ_F As System.Windows.Forms.CheckBox

    ' Payment Condition
    Friend WithEvents lbl_支払間隔 As System.Windows.Forms.Label
    Friend WithEvents txt_SHRI_KN As System.Windows.Forms.TextBox
    Friend WithEvents Label_M3 As System.Windows.Forms.Label
    Friend WithEvents lbl_前払回数 As System.Windows.Forms.Label
    Friend WithEvents txt_MKAISU As System.Windows.Forms.TextBox
    Friend WithEvents Label_M4 As System.Windows.Forms.Label
    Friend WithEvents lbl_支払回数 As System.Windows.Forms.Label
    Friend WithEvents txt_SHRI_CNT As System.Windows.Forms.TextBox
    Friend WithEvents Label_M5 As System.Windows.Forms.Label
    Friend WithEvents lbl_前払日 As System.Windows.Forms.Label
    Friend WithEvents txt_MAE_DT As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_第1回支払日 As System.Windows.Forms.Label
    Friend WithEvents txt_SHRI_DT1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_第2回支払日 As System.Windows.Forms.Label
    Friend WithEvents txt_SHRI_DT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_第3回以降 As System.Windows.Forms.Label
    Friend WithEvents txt_SHRI_DT3 As System.Windows.Forms.TextBox
    Friend WithEvents Label_M6 As System.Windows.Forms.Label
    Friend WithEvents lbl_最終支払日 As System.Windows.Forms.Label
    Friend WithEvents txt_SHRI_EN_DT As System.Windows.Forms.DateTimePicker

    ' Amount
    Friend WithEvents lbl_現金購入価額 As System.Windows.Forms.Label
    Friend WithEvents txt_KNYUKN As System.Windows.Forms.TextBox
    Friend WithEvents cmd_料率 As System.Windows.Forms.Button
    Friend WithEvents txt_RYORITU As System.Windows.Forms.TextBox
    Friend WithEvents cmd_税率 As System.Windows.Forms.Button
    Friend WithEvents cmb_ZRITU As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_支払方法 As System.Windows.Forms.Label
    Friend WithEvents cmb_SHHO_M_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_SHHO_1_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_SHHO_2_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_SHHO_3_ID As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_月額 As System.Windows.Forms.Label
    Friend WithEvents txt_GLSRYO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_期間額 As System.Windows.Forms.Label
    Friend WithEvents txt_KLSRYO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_前払 As System.Windows.Forms.Label
    Friend WithEvents txt_MLSRYO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_総額 As System.Windows.Forms.Label
    Friend WithEvents txt_SLSRYO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_税抜き As System.Windows.Forms.Label
    Friend WithEvents lbl_消費税 As System.Windows.Forms.Label
    Friend WithEvents txt_GZEI As System.Windows.Forms.TextBox
    Friend WithEvents txt_KZEI As System.Windows.Forms.TextBox
    Friend WithEvents txt_MZEI As System.Windows.Forms.TextBox
    Friend WithEvents lbl_税込み As System.Windows.Forms.Label
    Friend WithEvents txt_GLSRYO_ZEIKOMI As System.Windows.Forms.TextBox
    Friend WithEvents txt_KLSRYO_ZKOMI As System.Windows.Forms.TextBox
    Friend WithEvents txt_MLSRYO_ZKOMI As System.Windows.Forms.TextBox
    Friend WithEvents lbl_維持管理費用 As System.Windows.Forms.Label
    Friend WithEvents txt_IJIKNR As System.Windows.Forms.TextBox
    Friend WithEvents lbl_残価保証額 As System.Windows.Forms.Label
    Friend WithEvents txt_ZANRYO As System.Windows.Forms.TextBox

    ' Others
    Friend WithEvents lbl_銀行口座 As System.Windows.Forms.Label
    Friend WithEvents cmb_KOZA_ID As System.Windows.Forms.ComboBox
    Friend WithEvents txt_KOZA_NM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_契約予備 As System.Windows.Forms.Label
    Friend WithEvents cmb_RSRVK1_ID As System.Windows.Forms.ComboBox
    Friend WithEvents txt_RSRVK1_NM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_備考 As System.Windows.Forms.Label
    Friend WithEvents txt_K_ZOKUSEI1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_契約名 As System.Windows.Forms.Label
    Friend WithEvents txt_KYAK_NM As System.Windows.Forms.TextBox

    ' Subform Area
    Friend WithEvents cmd_物件画面 As System.Windows.Forms.Button
    Friend WithEvents tab_f_KYKH_SUB As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_DETAILS As System.Windows.Forms.DataGridView
    Friend WithEvents txt_CORP_NM As TextBox

    ' -------------------------------------------------------------
    '  Access定義に基づく 隠しコントロール (ID, フラグ, システム項目)
    ' -------------------------------------------------------------
    Friend WithEvents txt_KYKH_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_KYKH_NO As System.Windows.Forms.TextBox
    Friend WithEvents txt_UPDATE_CNT As System.Windows.Forms.TextBox
    Friend WithEvents txt_K_CREATE_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_K_UPDATE_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_REND_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_K_KJYO_ST_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_K_KJYO_EN_DT As System.Windows.Forms.TextBox

    Friend WithEvents chk_CKAIYK_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_K_SEIGOU_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_K_HENF_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_K_HENL_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_JENCHO_F As System.Windows.Forms.CheckBox
    Friend WithEvents col_KYKM_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_SUURYO As DataGridViewTextBoxColumn
    Friend WithEvents col_KNYUKN As DataGridViewTextBoxColumn
    Friend WithEvents col_GLSRYO As DataGridViewTextBoxColumn
End Class