<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_ZANDAKA

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.lbl_CONDITION = New System.Windows.Forms.Label()
        Me.cmd_OUTPUT_FILE = New System.Windows.Forms.Button()
        Me.cmd_PRINT = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_SCH = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.txt_KKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_BANGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KISYU_SKYAK_RUIKEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KISYU_GEN_RUIKEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KISYU_BOKA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KON_SKYAK_RUIKEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KON_GEN_RUIKEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KJKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期首超過額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZOU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_GEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LKIKAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KON_MASYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_ZAN_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAT_GEN_RUIKEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAT_BOKA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期中超過額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期中不足額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期末超過額 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KISYU_SKYAK_RUIKEI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KISYU_GEN_RUIKEI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KISYU_BOKA_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KON_SKYAK_RUIKEI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KON_GEN_RUIKEI_CNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期首超過額_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZOU_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_GEN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BOKA_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAT_SKYAK_RUIKEI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAT_GEN_RUIKEI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KON_MASYO_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期中超過額_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期中不足額_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_期末超過額_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_TOTAL = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Controls.Add(Me.txt_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_SEARCH)
        Me.pnlHeader.Controls.Add(Me.lbl_CONDITION)
        Me.pnlHeader.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.pnlHeader.Controls.Add(Me.cmd_PRINT)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_SCH)
        Me.pnlHeader.Controls.Add(Me.cmd_RECALCULATE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2000, 117)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1192, 47)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 39
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1372, 39)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1716, 31)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'lbl_CONDITION
        '
        Me.lbl_CONDITION.AutoSize = True
        Me.lbl_CONDITION.Location = New System.Drawing.Point(12, 81)
        Me.lbl_CONDITION.Name = "lbl_CONDITION"
        Me.lbl_CONDITION.Size = New System.Drawing.Size(89, 18)
        Me.lbl_CONDITION.TabIndex = 8
        Me.lbl_CONDITION.Text = "決算期間："
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(929, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_OUTPUT_FILE.TabIndex = 7
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_PRINT
        '
        Me.cmd_PRINT.Location = New System.Drawing.Point(746, 13)
        Me.cmd_PRINT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(173, 45)
        Me.cmd_PRINT.TabIndex = 6
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Text = "印刷(&R)"
        Me.cmd_PRINT.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(563, 13)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(173, 45)
        Me.cmd_REF.TabIndex = 3
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = True
        '
        'cmd_SCH
        '
        Me.cmd_SCH.Location = New System.Drawing.Point(380, 13)
        Me.cmd_SCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SCH.Name = "cmd_SCH"
        Me.cmd_SCH.Size = New System.Drawing.Size(173, 45)
        Me.cmd_SCH.TabIndex = 2
        Me.cmd_SCH.TabStop = False
        Me.cmd_SCH.Text = "返済ｽｹｼﾞｭｰﾙ(&H)"
        Me.cmd_SCH.UseVisualStyleBackColor = True
        '
        'cmd_RECALCULATE
        '
        Me.cmd_RECALCULATE.Location = New System.Drawing.Point(197, 13)
        Me.cmd_RECALCULATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_RECALCULATE.Name = "cmd_RECALCULATE"
        Me.cmd_RECALCULATE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_RECALCULATE.TabIndex = 1
        Me.cmd_RECALCULATE.TabStop = False
        Me.cmd_RECALCULATE.Text = "再計算(&D)"
        Me.cmd_RECALCULATE.UseVisualStyleBackColor = True
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'dgv_LIST
        '
        Me.dgv_LIST.AllowUserToAddRows = False
        Me.dgv_LIST.AllowUserToDeleteRows = False
        Me.dgv_LIST.AllowUserToResizeColumns = False
        Me.dgv_LIST.AllowUserToResizeRows = False
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_KKBN_NM, Me.txt_KYKM_NO, Me.txt_SKMK_NM, Me.txt_BUKN_BANGO, Me.txt_BUKN_NM, Me.txt_SYUTOK_ZZAN, Me.txt_KISYU_SKYAK_RUIKEI, Me.txt_KYKH_ID, Me.txt_B_BCAT1_NM, Me.txt_KISYU_GEN_RUIKEI, Me.txt_KISYU_BOKA, Me.txt_KON_SKYAK_RUIKEI, Me.txt_KON_GEN_RUIKEI, Me.txt_LCPT1_NM, Me.txt_KYKBNL, Me.txt_START_DT, Me.txt_CKAIYK_DT, Me.txt_KJKBN_NM, Me.txt_期首超過額, Me.txt_SYUTOK_ZOU, Me.txt_SYUTOK_GEN, Me.txt_LKIKAN, Me.txt_KON_MASYO, Me.txt_GRUIKEI_ZAN_, Me.txt_MAT_GEN_RUIKEI, Me.txt_MAT_BOKA, Me.txt_期中超過額, Me.txt_期中不足額, Me.txt_期末超過額, Me.txt_SYUTOK_ZAN, Me.txt_SYUTOK_ZZAN_SUM, Me.txt_KISYU_SKYAK_RUIKEI_SUM, Me.txt_KISYU_GEN_RUIKEI_SUM, Me.txt_KISYU_BOKA_SUM, Me.txt_KON_SKYAK_RUIKEI_SUM, Me.txt_KON_GEN_RUIKEI_CNT, Me.txt_期首超過額_SUM, Me.txt_SYUTOK_ZOU_SUM, Me.txt_SYUTOK_GEN_SUM, Me.txt_BOKA_ZAN_SUM, Me.txt_MAT_SKYAK_RUIKEI_SUM, Me.txt_MAT_GEN_RUIKEI_SUM, Me.txt_KON_MASYO_SUM, Me.txt_期中超過額_SUM, Me.txt_期中不足額_SUM, Me.txt_期末超過額_SUM, Me.txt_SYUTOK_ZAN_SUM, Me.txt_ID})
        Me.dgv_LIST.Location = New System.Drawing.Point(14, 117)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(1974, 604)
        Me.dgv_LIST.TabIndex = 0
        '
        'txt_KKBN_NM
        '
        Me.txt_KKBN_NM.DataPropertyName = "KKBN_NM"
        Me.txt_KKBN_NM.HeaderText = "契約区分"
        Me.txt_KKBN_NM.MinimumWidth = 8
        Me.txt_KKBN_NM.Name = "txt_KKBN_NM"
        Me.txt_KKBN_NM.ReadOnly = True
        Me.txt_KKBN_NM.Width = 75
        '
        'txt_KYKM_NO
        '
        Me.txt_KYKM_NO.DataPropertyName = "KYKM_NO"
        Me.txt_KYKM_NO.HeaderText = "物件No"
        Me.txt_KYKM_NO.MinimumWidth = 8
        Me.txt_KYKM_NO.Name = "txt_KYKM_NO"
        Me.txt_KYKM_NO.ReadOnly = True
        Me.txt_KYKM_NO.Width = 60
        '
        'txt_SKMK_NM
        '
        Me.txt_SKMK_NM.DataPropertyName = "SKMK_NM"
        Me.txt_SKMK_NM.HeaderText = "資産区分"
        Me.txt_SKMK_NM.MinimumWidth = 8
        Me.txt_SKMK_NM.Name = "txt_SKMK_NM"
        Me.txt_SKMK_NM.ReadOnly = True
        Me.txt_SKMK_NM.Width = 90
        '
        'txt_BUKN_BANGO
        '
        Me.txt_BUKN_BANGO.DataPropertyName = "BUKN_BANGO"
        Me.txt_BUKN_BANGO.HeaderText = "BUKN_BANGO"
        Me.txt_BUKN_BANGO.MinimumWidth = 8
        Me.txt_BUKN_BANGO.Name = "txt_BUKN_BANGO"
        Me.txt_BUKN_BANGO.ReadOnly = True
        Me.txt_BUKN_BANGO.Width = 90
        '
        'txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "物件名"
        Me.txt_BUKN_NM.MinimumWidth = 8
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 113
        '
        'txt_SYUTOK_ZZAN
        '
        Me.txt_SYUTOK_ZZAN.DataPropertyName = "SYUTOK_ZZAN"
        Me.txt_SYUTOK_ZZAN.HeaderText = "期首取得価格"
        Me.txt_SYUTOK_ZZAN.MinimumWidth = 8
        Me.txt_SYUTOK_ZZAN.Name = "txt_SYUTOK_ZZAN"
        Me.txt_SYUTOK_ZZAN.ReadOnly = True
        Me.txt_SYUTOK_ZZAN.Width = 90
        '
        'txt_KISYU_SKYAK_RUIKEI
        '
        Me.txt_KISYU_SKYAK_RUIKEI.DataPropertyName = "KISYU_SKYAK_RUIKEI"
        Me.txt_KISYU_SKYAK_RUIKEI.HeaderText = "期首償却累計"
        Me.txt_KISYU_SKYAK_RUIKEI.MinimumWidth = 8
        Me.txt_KISYU_SKYAK_RUIKEI.Name = "txt_KISYU_SKYAK_RUIKEI"
        Me.txt_KISYU_SKYAK_RUIKEI.ReadOnly = True
        Me.txt_KISYU_SKYAK_RUIKEI.Width = 90
        '
        'txt_KYKH_ID
        '
        Me.txt_KYKH_ID.DataPropertyName = "KYKH_ID"
        Me.txt_KYKH_ID.HeaderText = "KYKH_ID"
        Me.txt_KYKH_ID.MinimumWidth = 8
        Me.txt_KYKH_ID.Name = "txt_KYKH_ID"
        Me.txt_KYKH_ID.ReadOnly = True
        Me.txt_KYKH_ID.Width = 60
        '
        'txt_B_BCAT1_NM
        '
        Me.txt_B_BCAT1_NM.DataPropertyName = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.HeaderText = "管理部署"
        Me.txt_B_BCAT1_NM.MinimumWidth = 8
        Me.txt_B_BCAT1_NM.Name = "txt_B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.ReadOnly = True
        Me.txt_B_BCAT1_NM.Width = 109
        '
        'txt_KISYU_GEN_RUIKEI
        '
        Me.txt_KISYU_GEN_RUIKEI.DataPropertyName = "KISYU_GEN_RUIKEI"
        Me.txt_KISYU_GEN_RUIKEI.HeaderText = "期首減損累計"
        Me.txt_KISYU_GEN_RUIKEI.MinimumWidth = 8
        Me.txt_KISYU_GEN_RUIKEI.Name = "txt_KISYU_GEN_RUIKEI"
        Me.txt_KISYU_GEN_RUIKEI.ReadOnly = True
        Me.txt_KISYU_GEN_RUIKEI.Width = 90
        '
        'txt_KISYU_BOKA
        '
        Me.txt_KISYU_BOKA.DataPropertyName = "KISYU_BOKA"
        Me.txt_KISYU_BOKA.HeaderText = "期首簿価"
        Me.txt_KISYU_BOKA.MinimumWidth = 8
        Me.txt_KISYU_BOKA.Name = "txt_KISYU_BOKA"
        Me.txt_KISYU_BOKA.ReadOnly = True
        Me.txt_KISYU_BOKA.Width = 90
        '
        'txt_KON_SKYAK_RUIKEI
        '
        Me.txt_KON_SKYAK_RUIKEI.DataPropertyName = "KON_SKYAK_RUIKEI"
        Me.txt_KON_SKYAK_RUIKEI.HeaderText = "期中償却額"
        Me.txt_KON_SKYAK_RUIKEI.MinimumWidth = 8
        Me.txt_KON_SKYAK_RUIKEI.Name = "txt_KON_SKYAK_RUIKEI"
        Me.txt_KON_SKYAK_RUIKEI.ReadOnly = True
        Me.txt_KON_SKYAK_RUIKEI.Width = 90
        '
        'txt_KON_GEN_RUIKEI
        '
        Me.txt_KON_GEN_RUIKEI.DataPropertyName = "KON_GEN_RUIKEI"
        Me.txt_KON_GEN_RUIKEI.HeaderText = "期中減損額"
        Me.txt_KON_GEN_RUIKEI.MinimumWidth = 8
        Me.txt_KON_GEN_RUIKEI.Name = "txt_KON_GEN_RUIKEI"
        Me.txt_KON_GEN_RUIKEI.ReadOnly = True
        Me.txt_KON_GEN_RUIKEI.Width = 90
        '
        'txt_LCPT1_NM
        '
        Me.txt_LCPT1_NM.DataPropertyName = "LCPT1_NM"
        Me.txt_LCPT1_NM.HeaderText = "支払先"
        Me.txt_LCPT1_NM.MinimumWidth = 8
        Me.txt_LCPT1_NM.Name = "txt_LCPT1_NM"
        Me.txt_LCPT1_NM.ReadOnly = True
        Me.txt_LCPT1_NM.Width = 90
        '
        'txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "契約番号"
        Me.txt_KYKBNL.MinimumWidth = 8
        Me.txt_KYKBNL.Name = "txt_KYKBNL"
        Me.txt_KYKBNL.ReadOnly = True
        Me.txt_KYKBNL.Width = 64
        '
        'txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "開始日"
        Me.txt_START_DT.MinimumWidth = 8
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 68
        '
        'txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.HeaderText = "中途解約日"
        Me.txt_CKAIYK_DT.MinimumWidth = 8
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Width = 68
        '
        'txt_KJKBN_NM
        '
        Me.txt_KJKBN_NM.DataPropertyName = "KJKBN_NM"
        Me.txt_KJKBN_NM.HeaderText = "計上区分"
        Me.txt_KJKBN_NM.MinimumWidth = 8
        Me.txt_KJKBN_NM.Name = "txt_KJKBN_NM"
        Me.txt_KJKBN_NM.ReadOnly = True
        Me.txt_KJKBN_NM.Width = 60
        '
        'txt_期首超過額
        '
        Me.txt_期首超過額.DataPropertyName = "期首超過額"
        Me.txt_期首超過額.HeaderText = "期首超過額"
        Me.txt_期首超過額.MinimumWidth = 8
        Me.txt_期首超過額.Name = "txt_期首超過額"
        Me.txt_期首超過額.ReadOnly = True
        Me.txt_期首超過額.Width = 90
        '
        'txt_SYUTOK_ZOU
        '
        Me.txt_SYUTOK_ZOU.DataPropertyName = "SYUTOK_ZOU"
        Me.txt_SYUTOK_ZOU.HeaderText = "期中増加額"
        Me.txt_SYUTOK_ZOU.MinimumWidth = 8
        Me.txt_SYUTOK_ZOU.Name = "txt_SYUTOK_ZOU"
        Me.txt_SYUTOK_ZOU.ReadOnly = True
        Me.txt_SYUTOK_ZOU.Width = 90
        '
        'txt_SYUTOK_GEN
        '
        Me.txt_SYUTOK_GEN.DataPropertyName = "SYUTOK_GEN"
        Me.txt_SYUTOK_GEN.HeaderText = "期中減少額"
        Me.txt_SYUTOK_GEN.MinimumWidth = 8
        Me.txt_SYUTOK_GEN.Name = "txt_SYUTOK_GEN"
        Me.txt_SYUTOK_GEN.ReadOnly = True
        Me.txt_SYUTOK_GEN.Width = 90
        '
        'txt_LKIKAN
        '
        Me.txt_LKIKAN.DataPropertyName = "LKIKAN"
        Me.txt_LKIKAN.HeaderText = "期間"
        Me.txt_LKIKAN.MinimumWidth = 8
        Me.txt_LKIKAN.Name = "txt_LKIKAN"
        Me.txt_LKIKAN.ReadOnly = True
        Me.txt_LKIKAN.Width = 68
        '
        'txt_KON_MASYO
        '
        Me.txt_KON_MASYO.DataPropertyName = "KON_MASYO"
        Me.txt_KON_MASYO.HeaderText = "期中抹消額"
        Me.txt_KON_MASYO.MinimumWidth = 8
        Me.txt_KON_MASYO.Name = "txt_KON_MASYO"
        Me.txt_KON_MASYO.ReadOnly = True
        Me.txt_KON_MASYO.Width = 90
        '
        'txt_GRUIKEI_ZAN_
        '
        Me.txt_GRUIKEI_ZAN_.DataPropertyName = "GRUIKEI_ZAN_"
        Me.txt_GRUIKEI_ZAN_.HeaderText = "GRUIKEI_ZAN_"
        Me.txt_GRUIKEI_ZAN_.MinimumWidth = 8
        Me.txt_GRUIKEI_ZAN_.Name = "txt_GRUIKEI_ZAN_"
        Me.txt_GRUIKEI_ZAN_.ReadOnly = True
        Me.txt_GRUIKEI_ZAN_.Width = 90
        '
        'txt_MAT_GEN_RUIKEI
        '
        Me.txt_MAT_GEN_RUIKEI.DataPropertyName = "MAT_GEN_RUIKEI"
        Me.txt_MAT_GEN_RUIKEI.HeaderText = "期末減損累計"
        Me.txt_MAT_GEN_RUIKEI.MinimumWidth = 8
        Me.txt_MAT_GEN_RUIKEI.Name = "txt_MAT_GEN_RUIKEI"
        Me.txt_MAT_GEN_RUIKEI.ReadOnly = True
        Me.txt_MAT_GEN_RUIKEI.Width = 90
        '
        'txt_MAT_BOKA
        '
        Me.txt_MAT_BOKA.DataPropertyName = "MAT_BOKA"
        Me.txt_MAT_BOKA.HeaderText = "期末簿価"
        Me.txt_MAT_BOKA.MinimumWidth = 8
        Me.txt_MAT_BOKA.Name = "txt_MAT_BOKA"
        Me.txt_MAT_BOKA.ReadOnly = True
        Me.txt_MAT_BOKA.Width = 90
        '
        'txt_期中超過額
        '
        Me.txt_期中超過額.DataPropertyName = "期中超過額"
        Me.txt_期中超過額.HeaderText = "期中超過額"
        Me.txt_期中超過額.MinimumWidth = 8
        Me.txt_期中超過額.Name = "txt_期中超過額"
        Me.txt_期中超過額.ReadOnly = True
        Me.txt_期中超過額.Width = 90
        '
        'txt_期中不足額
        '
        Me.txt_期中不足額.DataPropertyName = "期中不足額"
        Me.txt_期中不足額.HeaderText = "期中不足額"
        Me.txt_期中不足額.MinimumWidth = 8
        Me.txt_期中不足額.Name = "txt_期中不足額"
        Me.txt_期中不足額.ReadOnly = True
        Me.txt_期中不足額.Width = 90
        '
        'txt_期末超過額
        '
        Me.txt_期末超過額.DataPropertyName = "期末超過額"
        Me.txt_期末超過額.HeaderText = "期末超過額"
        Me.txt_期末超過額.MinimumWidth = 8
        Me.txt_期末超過額.Name = "txt_期末超過額"
        Me.txt_期末超過額.ReadOnly = True
        Me.txt_期末超過額.Width = 90
        '
        'txt_SYUTOK_ZAN
        '
        Me.txt_SYUTOK_ZAN.DataPropertyName = "SYUTOK_ZAN"
        Me.txt_SYUTOK_ZAN.HeaderText = "期末取得価格"
        Me.txt_SYUTOK_ZAN.MinimumWidth = 8
        Me.txt_SYUTOK_ZAN.Name = "txt_SYUTOK_ZAN"
        Me.txt_SYUTOK_ZAN.ReadOnly = True
        Me.txt_SYUTOK_ZAN.Width = 90
        '
        'txt_SYUTOK_ZZAN_SUM
        '
        Me.txt_SYUTOK_ZZAN_SUM.DataPropertyName = "SYUTOK_ZZAN_SUM"
        Me.txt_SYUTOK_ZZAN_SUM.HeaderText = "SYUTOK_ZZAN_SUM"
        Me.txt_SYUTOK_ZZAN_SUM.MinimumWidth = 8
        Me.txt_SYUTOK_ZZAN_SUM.Name = "txt_SYUTOK_ZZAN_SUM"
        Me.txt_SYUTOK_ZZAN_SUM.ReadOnly = True
        Me.txt_SYUTOK_ZZAN_SUM.Width = 90
        '
        'txt_KISYU_SKYAK_RUIKEI_SUM
        '
        Me.txt_KISYU_SKYAK_RUIKEI_SUM.DataPropertyName = "KISYU_SKYAK_RUIKEI_SUM"
        Me.txt_KISYU_SKYAK_RUIKEI_SUM.HeaderText = "KISYU_SKYAK_RUIKEI_SUM"
        Me.txt_KISYU_SKYAK_RUIKEI_SUM.MinimumWidth = 8
        Me.txt_KISYU_SKYAK_RUIKEI_SUM.Name = "txt_KISYU_SKYAK_RUIKEI_SUM"
        Me.txt_KISYU_SKYAK_RUIKEI_SUM.ReadOnly = True
        Me.txt_KISYU_SKYAK_RUIKEI_SUM.Width = 90
        '
        'txt_KISYU_GEN_RUIKEI_SUM
        '
        Me.txt_KISYU_GEN_RUIKEI_SUM.DataPropertyName = "KISYU_GEN_RUIKEI_SUM"
        Me.txt_KISYU_GEN_RUIKEI_SUM.HeaderText = "KISYU_GEN_RUIKEI_SUM"
        Me.txt_KISYU_GEN_RUIKEI_SUM.MinimumWidth = 8
        Me.txt_KISYU_GEN_RUIKEI_SUM.Name = "txt_KISYU_GEN_RUIKEI_SUM"
        Me.txt_KISYU_GEN_RUIKEI_SUM.ReadOnly = True
        Me.txt_KISYU_GEN_RUIKEI_SUM.Width = 90
        '
        'txt_KISYU_BOKA_SUM
        '
        Me.txt_KISYU_BOKA_SUM.DataPropertyName = "KISYU_BOKA_SUM"
        Me.txt_KISYU_BOKA_SUM.HeaderText = "KISYU_BOKA_SUM"
        Me.txt_KISYU_BOKA_SUM.MinimumWidth = 8
        Me.txt_KISYU_BOKA_SUM.Name = "txt_KISYU_BOKA_SUM"
        Me.txt_KISYU_BOKA_SUM.ReadOnly = True
        Me.txt_KISYU_BOKA_SUM.Width = 90
        '
        'txt_KON_SKYAK_RUIKEI_SUM
        '
        Me.txt_KON_SKYAK_RUIKEI_SUM.DataPropertyName = "KON_SKYAK_RUIKEI_SUM"
        Me.txt_KON_SKYAK_RUIKEI_SUM.HeaderText = "KON_SKYAK_RUIKEI_SUM"
        Me.txt_KON_SKYAK_RUIKEI_SUM.MinimumWidth = 8
        Me.txt_KON_SKYAK_RUIKEI_SUM.Name = "txt_KON_SKYAK_RUIKEI_SUM"
        Me.txt_KON_SKYAK_RUIKEI_SUM.ReadOnly = True
        Me.txt_KON_SKYAK_RUIKEI_SUM.Width = 90
        '
        'txt_KON_GEN_RUIKEI_CNT
        '
        Me.txt_KON_GEN_RUIKEI_CNT.DataPropertyName = "KON_GEN_RUIKEI_CNT"
        Me.txt_KON_GEN_RUIKEI_CNT.HeaderText = "KON_GEN_RUIKEI_CNT"
        Me.txt_KON_GEN_RUIKEI_CNT.MinimumWidth = 8
        Me.txt_KON_GEN_RUIKEI_CNT.Name = "txt_KON_GEN_RUIKEI_CNT"
        Me.txt_KON_GEN_RUIKEI_CNT.ReadOnly = True
        Me.txt_KON_GEN_RUIKEI_CNT.Width = 90
        '
        'txt_期首超過額_SUM
        '
        Me.txt_期首超過額_SUM.DataPropertyName = "期首超過額_SUM"
        Me.txt_期首超過額_SUM.HeaderText = "期首超過額_SUM"
        Me.txt_期首超過額_SUM.MinimumWidth = 8
        Me.txt_期首超過額_SUM.Name = "txt_期首超過額_SUM"
        Me.txt_期首超過額_SUM.ReadOnly = True
        Me.txt_期首超過額_SUM.Width = 90
        '
        'txt_SYUTOK_ZOU_SUM
        '
        Me.txt_SYUTOK_ZOU_SUM.DataPropertyName = "SYUTOK_ZOU_SUM"
        Me.txt_SYUTOK_ZOU_SUM.HeaderText = "SYUTOK_ZOU_SUM"
        Me.txt_SYUTOK_ZOU_SUM.MinimumWidth = 8
        Me.txt_SYUTOK_ZOU_SUM.Name = "txt_SYUTOK_ZOU_SUM"
        Me.txt_SYUTOK_ZOU_SUM.ReadOnly = True
        Me.txt_SYUTOK_ZOU_SUM.Width = 90
        '
        'txt_SYUTOK_GEN_SUM
        '
        Me.txt_SYUTOK_GEN_SUM.DataPropertyName = "SYUTOK_GEN_SUM"
        Me.txt_SYUTOK_GEN_SUM.HeaderText = "SYUTOK_GEN_SUM"
        Me.txt_SYUTOK_GEN_SUM.MinimumWidth = 8
        Me.txt_SYUTOK_GEN_SUM.Name = "txt_SYUTOK_GEN_SUM"
        Me.txt_SYUTOK_GEN_SUM.ReadOnly = True
        Me.txt_SYUTOK_GEN_SUM.Width = 90
        '
        'txt_BOKA_ZAN_SUM
        '
        Me.txt_BOKA_ZAN_SUM.DataPropertyName = "BOKA_ZAN_SUM"
        Me.txt_BOKA_ZAN_SUM.HeaderText = "BOKA_ZAN_SUM"
        Me.txt_BOKA_ZAN_SUM.MinimumWidth = 8
        Me.txt_BOKA_ZAN_SUM.Name = "txt_BOKA_ZAN_SUM"
        Me.txt_BOKA_ZAN_SUM.ReadOnly = True
        Me.txt_BOKA_ZAN_SUM.Width = 90
        '
        'txt_MAT_SKYAK_RUIKEI_SUM
        '
        Me.txt_MAT_SKYAK_RUIKEI_SUM.DataPropertyName = "MAT_SKYAK_RUIKEI_SUM"
        Me.txt_MAT_SKYAK_RUIKEI_SUM.HeaderText = "MAT_SKYAK_RUIKEI_SUM"
        Me.txt_MAT_SKYAK_RUIKEI_SUM.MinimumWidth = 8
        Me.txt_MAT_SKYAK_RUIKEI_SUM.Name = "txt_MAT_SKYAK_RUIKEI_SUM"
        Me.txt_MAT_SKYAK_RUIKEI_SUM.ReadOnly = True
        Me.txt_MAT_SKYAK_RUIKEI_SUM.Width = 90
        '
        'txt_MAT_GEN_RUIKEI_SUM
        '
        Me.txt_MAT_GEN_RUIKEI_SUM.DataPropertyName = "MAT_GEN_RUIKEI_SUM"
        Me.txt_MAT_GEN_RUIKEI_SUM.HeaderText = "MAT_GEN_RUIKEI_SUM"
        Me.txt_MAT_GEN_RUIKEI_SUM.MinimumWidth = 8
        Me.txt_MAT_GEN_RUIKEI_SUM.Name = "txt_MAT_GEN_RUIKEI_SUM"
        Me.txt_MAT_GEN_RUIKEI_SUM.ReadOnly = True
        Me.txt_MAT_GEN_RUIKEI_SUM.Width = 90
        '
        'txt_KON_MASYO_SUM
        '
        Me.txt_KON_MASYO_SUM.DataPropertyName = "KON_MASYO_SUM"
        Me.txt_KON_MASYO_SUM.HeaderText = "KON_MASYO_SUM"
        Me.txt_KON_MASYO_SUM.MinimumWidth = 8
        Me.txt_KON_MASYO_SUM.Name = "txt_KON_MASYO_SUM"
        Me.txt_KON_MASYO_SUM.ReadOnly = True
        Me.txt_KON_MASYO_SUM.Width = 90
        '
        'txt_期中超過額_SUM
        '
        Me.txt_期中超過額_SUM.DataPropertyName = "期中超過額_SUM"
        Me.txt_期中超過額_SUM.HeaderText = "期中超過額_SUM"
        Me.txt_期中超過額_SUM.MinimumWidth = 8
        Me.txt_期中超過額_SUM.Name = "txt_期中超過額_SUM"
        Me.txt_期中超過額_SUM.ReadOnly = True
        Me.txt_期中超過額_SUM.Width = 90
        '
        'txt_期中不足額_SUM
        '
        Me.txt_期中不足額_SUM.DataPropertyName = "期中不足額_SUM"
        Me.txt_期中不足額_SUM.HeaderText = "期中不足額_SUM"
        Me.txt_期中不足額_SUM.MinimumWidth = 8
        Me.txt_期中不足額_SUM.Name = "txt_期中不足額_SUM"
        Me.txt_期中不足額_SUM.ReadOnly = True
        Me.txt_期中不足額_SUM.Width = 90
        '
        'txt_期末超過額_SUM
        '
        Me.txt_期末超過額_SUM.DataPropertyName = "期末超過額_SUM"
        Me.txt_期末超過額_SUM.HeaderText = "期末超過額_SUM"
        Me.txt_期末超過額_SUM.MinimumWidth = 8
        Me.txt_期末超過額_SUM.Name = "txt_期末超過額_SUM"
        Me.txt_期末超過額_SUM.ReadOnly = True
        Me.txt_期末超過額_SUM.Width = 90
        '
        'txt_SYUTOK_ZAN_SUM
        '
        Me.txt_SYUTOK_ZAN_SUM.DataPropertyName = "SYUTOK_ZAN_SUM"
        Me.txt_SYUTOK_ZAN_SUM.HeaderText = "SYUTOK_ZAN_SUM"
        Me.txt_SYUTOK_ZAN_SUM.MinimumWidth = 8
        Me.txt_SYUTOK_ZAN_SUM.Name = "txt_SYUTOK_ZAN_SUM"
        Me.txt_SYUTOK_ZAN_SUM.ReadOnly = True
        Me.txt_SYUTOK_ZAN_SUM.Width = 90
        '
        'txt_ID
        '
        Me.txt_ID.DataPropertyName = "ID"
        Me.txt_ID.HeaderText = "ID"
        Me.txt_ID.MinimumWidth = 8
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Visible = False
        Me.txt_ID.Width = 150
        '
        'dgv_TOTAL
        '
        Me.dgv_TOTAL.AllowUserToAddRows = False
        Me.dgv_TOTAL.AllowUserToDeleteRows = False
        Me.dgv_TOTAL.AllowUserToResizeColumns = False
        Me.dgv_TOTAL.AllowUserToResizeRows = False
        Me.dgv_TOTAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TOTAL.ColumnHeadersVisible = False
        Me.dgv_TOTAL.Location = New System.Drawing.Point(12, 728)
        Me.dgv_TOTAL.Name = "dgv_TOTAL"
        Me.dgv_TOTAL.ReadOnly = True
        Me.dgv_TOTAL.RowHeadersVisible = False
        Me.dgv_TOTAL.RowHeadersWidth = 62
        Me.dgv_TOTAL.RowTemplate.Height = 27
        Me.dgv_TOTAL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_TOTAL.Size = New System.Drawing.Size(1973, 102)
        Me.dgv_TOTAL.TabIndex = 9
        '
        'Form_f_flx_ZANDAKA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2000, 841)
        Me.Controls.Add(Me.dgv_TOTAL)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_ZANDAKA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "リース資産残高一覧"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_RECALCULATE As System.Windows.Forms.Button
    Friend WithEvents cmd_SCH As System.Windows.Forms.Button
    Friend WithEvents cmd_REF As System.Windows.Forms.Button
    Friend WithEvents cmd_PRINT As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents txt_KKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKMK_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_BANGO As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_KISYU_SKYAK_RUIKEI As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKH_ID As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KISYU_GEN_RUIKEI As DataGridViewTextBoxColumn
    Friend WithEvents txt_KISYU_BOKA As DataGridViewTextBoxColumn
    Friend WithEvents txt_KON_SKYAK_RUIKEI As DataGridViewTextBoxColumn
    Friend WithEvents txt_KON_GEN_RUIKEI As DataGridViewTextBoxColumn
    Friend WithEvents txt_LCPT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_CKAIYK_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_KJKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_期首超過額 As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZOU As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_GEN As DataGridViewTextBoxColumn
    Friend WithEvents txt_LKIKAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_KON_MASYO As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_ZAN_ As DataGridViewTextBoxColumn
    Friend WithEvents txt_MAT_GEN_RUIKEI As DataGridViewTextBoxColumn
    Friend WithEvents txt_MAT_BOKA As DataGridViewTextBoxColumn
    Friend WithEvents txt_期中超過額 As DataGridViewTextBoxColumn
    Friend WithEvents txt_期中不足額 As DataGridViewTextBoxColumn
    Friend WithEvents txt_期末超過額 As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KISYU_SKYAK_RUIKEI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KISYU_GEN_RUIKEI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KISYU_BOKA_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KON_SKYAK_RUIKEI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KON_GEN_RUIKEI_CNT As DataGridViewTextBoxColumn
    Friend WithEvents txt_期首超過額_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZOU_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_GEN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BOKA_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_MAT_SKYAK_RUIKEI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_MAT_GEN_RUIKEI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KON_MASYO_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_期中超過額_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_期中不足額_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_期末超過額_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As DataGridViewTextBoxColumn
    Friend WithEvents lbl_CONDITION As Label
    Friend WithEvents dgv_TOTAL As DataGridView
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
End Class