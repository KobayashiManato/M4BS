<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_CHUKI

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
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_SCH = New System.Windows.Forms.Button()
        Me.cmd_YOUSHIKI = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.txt_LEAKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BKIND_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_RKEI_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BOKA_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LGNPN_ZAN1NAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LGNPN_ZAN1CHO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LGNPN_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_TK_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_ZOU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RISOKU_HASSEI_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_RKEI_ZOU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KNYUKN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_SLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_GEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_GEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZOU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_RKEI_GEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CHU_HNTI_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CHUUM_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KJKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LKIKAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BOKA_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LGNPN_ZAN1NAI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LGNPN_ZAN1CHO_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LGNPN_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_RKEI_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_TOKI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_TK_TOKI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_ZOU_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RISOKU_HASSEI_TOKI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_RKEI_ZOU_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KNYUKN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_SLSRYO_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_GEN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GRUIKEI_GEN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SYUTOK_ZOU_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_GSON_RKEI_GEN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Controls.Add(Me.txt_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_SEARCH)
        Me.pnlHeader.Controls.Add(Me.lbl_CONDITION)
        Me.pnlHeader.Controls.Add(Me.cmd_Output)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexReportDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_SCH)
        Me.pnlHeader.Controls.Add(Me.cmd_YOUSHIKI)
        Me.pnlHeader.Controls.Add(Me.cmd_RECALCULATE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2639, 116)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1497, 53)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 36
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1677, 45)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(2021, 37)
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
        Me.lbl_CONDITION.Location = New System.Drawing.Point(12, 79)
        Me.lbl_CONDITION.Name = "lbl_CONDITION"
        Me.lbl_CONDITION.Size = New System.Drawing.Size(89, 18)
        Me.lbl_CONDITION.TabIndex = 10
        Me.lbl_CONDITION.Text = "決算期間；"
        '
        'cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(1192, 13)
        Me.cmd_Output.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(193, 45)
        Me.cmd_Output.TabIndex = 9
        Me.cmd_Output.TabStop = False
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        'cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(989, 13)
        Me.cmd_FlexReportDLG.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(193, 45)
        Me.cmd_FlexReportDLG.TabIndex = 8
        Me.cmd_FlexReportDLG.TabStop = False
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(786, 13)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(193, 45)
        Me.cmd_REF.TabIndex = 4
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = True
        '
        'cmd_SCH
        '
        Me.cmd_SCH.Location = New System.Drawing.Point(583, 13)
        Me.cmd_SCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SCH.Name = "cmd_SCH"
        Me.cmd_SCH.Size = New System.Drawing.Size(193, 45)
        Me.cmd_SCH.TabIndex = 3
        Me.cmd_SCH.TabStop = False
        Me.cmd_SCH.Text = "返済ｽｹｼﾞｭｰﾙ(&H)"
        Me.cmd_SCH.UseVisualStyleBackColor = True
        '
        'cmd_YOUSHIKI
        '
        Me.cmd_YOUSHIKI.Location = New System.Drawing.Point(380, 13)
        Me.cmd_YOUSHIKI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_YOUSHIKI.Name = "cmd_YOUSHIKI"
        Me.cmd_YOUSHIKI.Size = New System.Drawing.Size(193, 45)
        Me.cmd_YOUSHIKI.TabIndex = 2
        Me.cmd_YOUSHIKI.TabStop = False
        Me.cmd_YOUSHIKI.Text = "様式集計(&Y)"
        Me.cmd_YOUSHIKI.UseVisualStyleBackColor = True
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
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_LEAKBN_NM, Me.txt_KYKM_NO, Me.txt_SKMK_NM, Me.txt_BKIND_NM, Me.txt_BUKN_NM, Me.txt_START_DT, Me.txt_SYUTOK_ZAN, Me.txt_GRUIKEI_ZAN, Me.txt_KYKH_ID, Me.txt_CKAIYK_DT, Me.txt_GSON_RKEI_ZAN, Me.txt_BOKA_ZAN, Me.txt_LGNPN_ZAN1NAI, Me.txt_LGNPN_ZAN1CHO, Me.txt_LGNPN_ZAN, Me.txt_GSON_ZAN, Me.txt_LSRYO_TOKI, Me.txt_GSON_TK_TOKI, Me.txt_GRUIKEI_ZOU, Me.txt_RISOKU_HASSEI_TOKI, Me.txt_GSON_RKEI_ZOU, Me.txt_B_KNYUKN, Me.txt_B_SLSRYO, Me.txt_SYUTOK_GEN, Me.txt_GRUIKEI_GEN, Me.txt_SYUTOK_ZOU, Me.txt_GSON_RKEI_GEN, Me.txt_CHU_HNTI_NM, Me.txt_CHUUM_NM, Me.txt_KJKBN_NM, Me.txt_LKIKAN, Me.txt_SYUTOK_ZAN_SUM, Me.txt_GRUIKEI_ZAN_SUM, Me.txt_BOKA_ZAN_SUM, Me.txt_LGNPN_ZAN1NAI_SUM, Me.txt_LGNPN_ZAN1CHO_SUM, Me.txt_LGNPN_ZAN_SUM, Me.txt_GSON_RKEI_ZAN_SUM, Me.txt_GSON_ZAN_SUM, Me.txt_LSRYO_TOKI_SUM, Me.txt_GSON_TK_TOKI_SUM, Me.txt_GRUIKEI_ZOU_SUM, Me.txt_RISOKU_HASSEI_TOKI_SUM, Me.txt_GSON_RKEI_ZOU_SUM, Me.txt_B_KNYUKN_SUM, Me.txt_B_SLSRYO_SUM, Me.txt_SYUTOK_GEN_SUM, Me.txt_GRUIKEI_GEN_SUM, Me.txt_SYUTOK_ZOU_SUM, Me.txt_GSON_RKEI_GEN_SUM, Me.txt_ID})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 116)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(2639, 726)
        Me.dgv_LIST.TabIndex = 0
        '
        'txt_LEAKBN_NM
        '
        Me.txt_LEAKBN_NM.DataPropertyName = "LEAKBN_NM"
        Me.txt_LEAKBN_NM.HeaderText = "リース区分"
        Me.txt_LEAKBN_NM.MinimumWidth = 8
        Me.txt_LEAKBN_NM.Name = "txt_LEAKBN_NM"
        Me.txt_LEAKBN_NM.ReadOnly = True
        Me.txt_LEAKBN_NM.Width = 75
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
        Me.txt_SKMK_NM.Width = 75
        '
        'txt_BKIND_NM
        '
        Me.txt_BKIND_NM.DataPropertyName = "BKIND_NM"
        Me.txt_BKIND_NM.HeaderText = "物件種別"
        Me.txt_BKIND_NM.MinimumWidth = 8
        Me.txt_BKIND_NM.Name = "txt_BKIND_NM"
        Me.txt_BKIND_NM.ReadOnly = True
        Me.txt_BKIND_NM.Width = 75
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
        'txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "開始日"
        Me.txt_START_DT.MinimumWidth = 8
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 68
        '
        'txt_SYUTOK_ZAN
        '
        Me.txt_SYUTOK_ZAN.DataPropertyName = "SYUTOK_ZAN"
        Me.txt_SYUTOK_ZAN.HeaderText = "取得価額相当額"
        Me.txt_SYUTOK_ZAN.MinimumWidth = 8
        Me.txt_SYUTOK_ZAN.Name = "txt_SYUTOK_ZAN"
        Me.txt_SYUTOK_ZAN.ReadOnly = True
        Me.txt_SYUTOK_ZAN.Width = 90
        '
        'txt_GRUIKEI_ZAN
        '
        Me.txt_GRUIKEI_ZAN.DataPropertyName = "GRUIKEI_ZAN"
        Me.txt_GRUIKEI_ZAN.HeaderText = "減価償却累計額相当額"
        Me.txt_GRUIKEI_ZAN.MinimumWidth = 8
        Me.txt_GRUIKEI_ZAN.Name = "txt_GRUIKEI_ZAN"
        Me.txt_GRUIKEI_ZAN.ReadOnly = True
        Me.txt_GRUIKEI_ZAN.Width = 90
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
        'txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.HeaderText = "中途解約日"
        Me.txt_CKAIYK_DT.MinimumWidth = 8
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Width = 68
        '
        'txt_GSON_RKEI_ZAN
        '
        Me.txt_GSON_RKEI_ZAN.DataPropertyName = "GSON_RKEI_ZAN"
        Me.txt_GSON_RKEI_ZAN.HeaderText = "減損損失累計額相当額"
        Me.txt_GSON_RKEI_ZAN.MinimumWidth = 8
        Me.txt_GSON_RKEI_ZAN.Name = "txt_GSON_RKEI_ZAN"
        Me.txt_GSON_RKEI_ZAN.ReadOnly = True
        Me.txt_GSON_RKEI_ZAN.Width = 90
        '
        'txt_BOKA_ZAN
        '
        Me.txt_BOKA_ZAN.DataPropertyName = "BOKA_ZAN"
        Me.txt_BOKA_ZAN.HeaderText = "期末残高相当額"
        Me.txt_BOKA_ZAN.MinimumWidth = 8
        Me.txt_BOKA_ZAN.Name = "txt_BOKA_ZAN"
        Me.txt_BOKA_ZAN.ReadOnly = True
        Me.txt_BOKA_ZAN.Width = 90
        '
        'txt_LGNPN_ZAN1NAI
        '
        Me.txt_LGNPN_ZAN1NAI.DataPropertyName = "LGNPN_ZAN1NAI"
        Me.txt_LGNPN_ZAN1NAI.HeaderText = "１年内"
        Me.txt_LGNPN_ZAN1NAI.MinimumWidth = 8
        Me.txt_LGNPN_ZAN1NAI.Name = "txt_LGNPN_ZAN1NAI"
        Me.txt_LGNPN_ZAN1NAI.ReadOnly = True
        Me.txt_LGNPN_ZAN1NAI.Width = 90
        '
        'txt_LGNPN_ZAN1CHO
        '
        Me.txt_LGNPN_ZAN1CHO.DataPropertyName = "LGNPN_ZAN1CHO"
        Me.txt_LGNPN_ZAN1CHO.HeaderText = "１年超"
        Me.txt_LGNPN_ZAN1CHO.MinimumWidth = 8
        Me.txt_LGNPN_ZAN1CHO.Name = "txt_LGNPN_ZAN1CHO"
        Me.txt_LGNPN_ZAN1CHO.ReadOnly = True
        Me.txt_LGNPN_ZAN1CHO.Width = 90
        '
        'txt_LGNPN_ZAN
        '
        Me.txt_LGNPN_ZAN.DataPropertyName = "LGNPN_ZAN"
        Me.txt_LGNPN_ZAN.HeaderText = "合計"
        Me.txt_LGNPN_ZAN.MinimumWidth = 8
        Me.txt_LGNPN_ZAN.Name = "txt_LGNPN_ZAN"
        Me.txt_LGNPN_ZAN.ReadOnly = True
        Me.txt_LGNPN_ZAN.Width = 90
        '
        'txt_GSON_ZAN
        '
        Me.txt_GSON_ZAN.DataPropertyName = "GSON_ZAN"
        Me.txt_GSON_ZAN.HeaderText = "ﾘｰｽ資産減損勘定の残高"
        Me.txt_GSON_ZAN.MinimumWidth = 8
        Me.txt_GSON_ZAN.Name = "txt_GSON_ZAN"
        Me.txt_GSON_ZAN.ReadOnly = True
        Me.txt_GSON_ZAN.Width = 90
        '
        'txt_LSRYO_TOKI
        '
        Me.txt_LSRYO_TOKI.DataPropertyName = "LSRYO_TOKI"
        Me.txt_LSRYO_TOKI.HeaderText = "当期支払リース料"
        Me.txt_LSRYO_TOKI.MinimumWidth = 8
        Me.txt_LSRYO_TOKI.Name = "txt_LSRYO_TOKI"
        Me.txt_LSRYO_TOKI.ReadOnly = True
        Me.txt_LSRYO_TOKI.Width = 90
        '
        'txt_GSON_TK_TOKI
        '
        Me.txt_GSON_TK_TOKI.DataPropertyName = "GSON_TK_TOKI"
        Me.txt_GSON_TK_TOKI.HeaderText = "ﾘｰｽ資産減損勘定の取崩額"
        Me.txt_GSON_TK_TOKI.MinimumWidth = 8
        Me.txt_GSON_TK_TOKI.Name = "txt_GSON_TK_TOKI"
        Me.txt_GSON_TK_TOKI.ReadOnly = True
        Me.txt_GSON_TK_TOKI.Width = 90
        '
        'txt_GRUIKEI_ZOU
        '
        Me.txt_GRUIKEI_ZOU.DataPropertyName = "GRUIKEI_ZOU"
        Me.txt_GRUIKEI_ZOU.HeaderText = "減価償却費相当額"
        Me.txt_GRUIKEI_ZOU.MinimumWidth = 8
        Me.txt_GRUIKEI_ZOU.Name = "txt_GRUIKEI_ZOU"
        Me.txt_GRUIKEI_ZOU.ReadOnly = True
        Me.txt_GRUIKEI_ZOU.Width = 90
        '
        'txt_RISOKU_HASSEI_TOKI
        '
        Me.txt_RISOKU_HASSEI_TOKI.DataPropertyName = "RISOKU_HASSEI_TOKI"
        Me.txt_RISOKU_HASSEI_TOKI.HeaderText = "支払利息相当額"
        Me.txt_RISOKU_HASSEI_TOKI.MinimumWidth = 8
        Me.txt_RISOKU_HASSEI_TOKI.Name = "txt_RISOKU_HASSEI_TOKI"
        Me.txt_RISOKU_HASSEI_TOKI.ReadOnly = True
        Me.txt_RISOKU_HASSEI_TOKI.Width = 94
        '
        'txt_GSON_RKEI_ZOU
        '
        Me.txt_GSON_RKEI_ZOU.DataPropertyName = "GSON_RKEI_ZOU"
        Me.txt_GSON_RKEI_ZOU.HeaderText = "減損損失の金額"
        Me.txt_GSON_RKEI_ZOU.MinimumWidth = 8
        Me.txt_GSON_RKEI_ZOU.Name = "txt_GSON_RKEI_ZOU"
        Me.txt_GSON_RKEI_ZOU.ReadOnly = True
        Me.txt_GSON_RKEI_ZOU.Width = 94
        '
        'txt_B_KNYUKN
        '
        Me.txt_B_KNYUKN.DataPropertyName = "B_KNYUKN"
        Me.txt_B_KNYUKN.HeaderText = "現金購入価額"
        Me.txt_B_KNYUKN.MinimumWidth = 8
        Me.txt_B_KNYUKN.Name = "txt_B_KNYUKN"
        Me.txt_B_KNYUKN.ReadOnly = True
        Me.txt_B_KNYUKN.Width = 94
        '
        'txt_B_SLSRYO
        '
        Me.txt_B_SLSRYO.DataPropertyName = "B_SLSRYO"
        Me.txt_B_SLSRYO.HeaderText = "総額リース料"
        Me.txt_B_SLSRYO.MinimumWidth = 8
        Me.txt_B_SLSRYO.Name = "txt_B_SLSRYO"
        Me.txt_B_SLSRYO.ReadOnly = True
        Me.txt_B_SLSRYO.Width = 94
        '
        'txt_SYUTOK_GEN
        '
        Me.txt_SYUTOK_GEN.DataPropertyName = "SYUTOK_GEN"
        Me.txt_SYUTOK_GEN.HeaderText = "減少･取得価額"
        Me.txt_SYUTOK_GEN.MinimumWidth = 8
        Me.txt_SYUTOK_GEN.Name = "txt_SYUTOK_GEN"
        Me.txt_SYUTOK_GEN.ReadOnly = True
        Me.txt_SYUTOK_GEN.Width = 94
        '
        'txt_GRUIKEI_GEN
        '
        Me.txt_GRUIKEI_GEN.DataPropertyName = "GRUIKEI_GEN"
        Me.txt_GRUIKEI_GEN.HeaderText = "減少･償却累計"
        Me.txt_GRUIKEI_GEN.MinimumWidth = 8
        Me.txt_GRUIKEI_GEN.Name = "txt_GRUIKEI_GEN"
        Me.txt_GRUIKEI_GEN.ReadOnly = True
        Me.txt_GRUIKEI_GEN.Width = 94
        '
        'txt_SYUTOK_ZOU
        '
        Me.txt_SYUTOK_ZOU.DataPropertyName = "SYUTOK_ZOU"
        Me.txt_SYUTOK_ZOU.HeaderText = "増加･取得価額"
        Me.txt_SYUTOK_ZOU.MinimumWidth = 8
        Me.txt_SYUTOK_ZOU.Name = "txt_SYUTOK_ZOU"
        Me.txt_SYUTOK_ZOU.ReadOnly = True
        Me.txt_SYUTOK_ZOU.Width = 94
        '
        'txt_GSON_RKEI_GEN
        '
        Me.txt_GSON_RKEI_GEN.DataPropertyName = "GSON_RKEI_GEN"
        Me.txt_GSON_RKEI_GEN.HeaderText = "減少･損失累計"
        Me.txt_GSON_RKEI_GEN.MinimumWidth = 8
        Me.txt_GSON_RKEI_GEN.Name = "txt_GSON_RKEI_GEN"
        Me.txt_GSON_RKEI_GEN.ReadOnly = True
        Me.txt_GSON_RKEI_GEN.Width = 94
        '
        'txt_CHU_HNTI_NM
        '
        Me.txt_CHU_HNTI_NM.DataPropertyName = "CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.HeaderText = "注記判定結果"
        Me.txt_CHU_HNTI_NM.MinimumWidth = 8
        Me.txt_CHU_HNTI_NM.Name = "txt_CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.ReadOnly = True
        Me.txt_CHU_HNTI_NM.Width = 75
        '
        'txt_CHUUM_NM
        '
        Me.txt_CHUUM_NM.DataPropertyName = "CHUUM_NM"
        Me.txt_CHUUM_NM.HeaderText = "注記/省略"
        Me.txt_CHUUM_NM.MinimumWidth = 8
        Me.txt_CHUUM_NM.Name = "txt_CHUUM_NM"
        Me.txt_CHUUM_NM.ReadOnly = True
        Me.txt_CHUUM_NM.Width = 60
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
        'txt_LKIKAN
        '
        Me.txt_LKIKAN.DataPropertyName = "LKIKAN"
        Me.txt_LKIKAN.HeaderText = "期間"
        Me.txt_LKIKAN.MinimumWidth = 8
        Me.txt_LKIKAN.Name = "txt_LKIKAN"
        Me.txt_LKIKAN.ReadOnly = True
        Me.txt_LKIKAN.Width = 68
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
        'txt_GRUIKEI_ZAN_SUM
        '
        Me.txt_GRUIKEI_ZAN_SUM.DataPropertyName = "GRUIKEI_ZAN_SUM"
        Me.txt_GRUIKEI_ZAN_SUM.HeaderText = "GRUIKEI_ZAN_SUM"
        Me.txt_GRUIKEI_ZAN_SUM.MinimumWidth = 8
        Me.txt_GRUIKEI_ZAN_SUM.Name = "txt_GRUIKEI_ZAN_SUM"
        Me.txt_GRUIKEI_ZAN_SUM.ReadOnly = True
        Me.txt_GRUIKEI_ZAN_SUM.Width = 90
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
        'txt_LGNPN_ZAN1NAI_SUM
        '
        Me.txt_LGNPN_ZAN1NAI_SUM.DataPropertyName = "LGNPN_ZAN1NAI_SUM"
        Me.txt_LGNPN_ZAN1NAI_SUM.HeaderText = "LGNPN_ZAN1NAI_SUM"
        Me.txt_LGNPN_ZAN1NAI_SUM.MinimumWidth = 8
        Me.txt_LGNPN_ZAN1NAI_SUM.Name = "txt_LGNPN_ZAN1NAI_SUM"
        Me.txt_LGNPN_ZAN1NAI_SUM.ReadOnly = True
        Me.txt_LGNPN_ZAN1NAI_SUM.Width = 90
        '
        'txt_LGNPN_ZAN1CHO_SUM
        '
        Me.txt_LGNPN_ZAN1CHO_SUM.DataPropertyName = "LGNPN_ZAN1CHO_SUM"
        Me.txt_LGNPN_ZAN1CHO_SUM.HeaderText = "LGNPN_ZAN1CHO_SUM"
        Me.txt_LGNPN_ZAN1CHO_SUM.MinimumWidth = 8
        Me.txt_LGNPN_ZAN1CHO_SUM.Name = "txt_LGNPN_ZAN1CHO_SUM"
        Me.txt_LGNPN_ZAN1CHO_SUM.ReadOnly = True
        Me.txt_LGNPN_ZAN1CHO_SUM.Width = 90
        '
        'txt_LGNPN_ZAN_SUM
        '
        Me.txt_LGNPN_ZAN_SUM.DataPropertyName = "LGNPN_ZAN_SUM"
        Me.txt_LGNPN_ZAN_SUM.HeaderText = "LGNPN_ZAN_SUM"
        Me.txt_LGNPN_ZAN_SUM.MinimumWidth = 8
        Me.txt_LGNPN_ZAN_SUM.Name = "txt_LGNPN_ZAN_SUM"
        Me.txt_LGNPN_ZAN_SUM.ReadOnly = True
        Me.txt_LGNPN_ZAN_SUM.Width = 90
        '
        'txt_GSON_RKEI_ZAN_SUM
        '
        Me.txt_GSON_RKEI_ZAN_SUM.DataPropertyName = "GSON_RKEI_ZAN_SUM"
        Me.txt_GSON_RKEI_ZAN_SUM.HeaderText = "GSON_RKEI_ZAN_SUM"
        Me.txt_GSON_RKEI_ZAN_SUM.MinimumWidth = 8
        Me.txt_GSON_RKEI_ZAN_SUM.Name = "txt_GSON_RKEI_ZAN_SUM"
        Me.txt_GSON_RKEI_ZAN_SUM.ReadOnly = True
        Me.txt_GSON_RKEI_ZAN_SUM.Width = 90
        '
        'txt_GSON_ZAN_SUM
        '
        Me.txt_GSON_ZAN_SUM.DataPropertyName = "GSON_ZAN_SUM"
        Me.txt_GSON_ZAN_SUM.HeaderText = "GSON_ZAN_SUM"
        Me.txt_GSON_ZAN_SUM.MinimumWidth = 8
        Me.txt_GSON_ZAN_SUM.Name = "txt_GSON_ZAN_SUM"
        Me.txt_GSON_ZAN_SUM.ReadOnly = True
        Me.txt_GSON_ZAN_SUM.Width = 90
        '
        'txt_LSRYO_TOKI_SUM
        '
        Me.txt_LSRYO_TOKI_SUM.DataPropertyName = "LSRYO_TOKI_SUM"
        Me.txt_LSRYO_TOKI_SUM.HeaderText = "LSRYO_TOKI_SUM"
        Me.txt_LSRYO_TOKI_SUM.MinimumWidth = 8
        Me.txt_LSRYO_TOKI_SUM.Name = "txt_LSRYO_TOKI_SUM"
        Me.txt_LSRYO_TOKI_SUM.ReadOnly = True
        Me.txt_LSRYO_TOKI_SUM.Width = 90
        '
        'txt_GSON_TK_TOKI_SUM
        '
        Me.txt_GSON_TK_TOKI_SUM.DataPropertyName = "GSON_TK_TOKI_SUM"
        Me.txt_GSON_TK_TOKI_SUM.HeaderText = "GSON_TK_TOKI_SUM"
        Me.txt_GSON_TK_TOKI_SUM.MinimumWidth = 8
        Me.txt_GSON_TK_TOKI_SUM.Name = "txt_GSON_TK_TOKI_SUM"
        Me.txt_GSON_TK_TOKI_SUM.ReadOnly = True
        Me.txt_GSON_TK_TOKI_SUM.Width = 90
        '
        'txt_GRUIKEI_ZOU_SUM
        '
        Me.txt_GRUIKEI_ZOU_SUM.DataPropertyName = "GRUIKEI_ZOU_SUM"
        Me.txt_GRUIKEI_ZOU_SUM.HeaderText = "GRUIKEI_ZOU_SUM"
        Me.txt_GRUIKEI_ZOU_SUM.MinimumWidth = 8
        Me.txt_GRUIKEI_ZOU_SUM.Name = "txt_GRUIKEI_ZOU_SUM"
        Me.txt_GRUIKEI_ZOU_SUM.ReadOnly = True
        Me.txt_GRUIKEI_ZOU_SUM.Width = 90
        '
        'txt_RISOKU_HASSEI_TOKI_SUM
        '
        Me.txt_RISOKU_HASSEI_TOKI_SUM.DataPropertyName = "RISOKU_HASSEI_TOKI_SUM"
        Me.txt_RISOKU_HASSEI_TOKI_SUM.HeaderText = "RISOKU_HASSEI_TOKI_SUM"
        Me.txt_RISOKU_HASSEI_TOKI_SUM.MinimumWidth = 8
        Me.txt_RISOKU_HASSEI_TOKI_SUM.Name = "txt_RISOKU_HASSEI_TOKI_SUM"
        Me.txt_RISOKU_HASSEI_TOKI_SUM.ReadOnly = True
        Me.txt_RISOKU_HASSEI_TOKI_SUM.Width = 94
        '
        'txt_GSON_RKEI_ZOU_SUM
        '
        Me.txt_GSON_RKEI_ZOU_SUM.DataPropertyName = "GSON_RKEI_ZOU_SUM"
        Me.txt_GSON_RKEI_ZOU_SUM.HeaderText = "GSON_RKEI_ZOU_SUM"
        Me.txt_GSON_RKEI_ZOU_SUM.MinimumWidth = 8
        Me.txt_GSON_RKEI_ZOU_SUM.Name = "txt_GSON_RKEI_ZOU_SUM"
        Me.txt_GSON_RKEI_ZOU_SUM.ReadOnly = True
        Me.txt_GSON_RKEI_ZOU_SUM.Width = 94
        '
        'txt_B_KNYUKN_SUM
        '
        Me.txt_B_KNYUKN_SUM.DataPropertyName = "B_KNYUKN_SUM"
        Me.txt_B_KNYUKN_SUM.HeaderText = "B_KNYUKN_SUM"
        Me.txt_B_KNYUKN_SUM.MinimumWidth = 8
        Me.txt_B_KNYUKN_SUM.Name = "txt_B_KNYUKN_SUM"
        Me.txt_B_KNYUKN_SUM.ReadOnly = True
        Me.txt_B_KNYUKN_SUM.Width = 94
        '
        'txt_B_SLSRYO_SUM
        '
        Me.txt_B_SLSRYO_SUM.DataPropertyName = "B_SLSRYO_SUM"
        Me.txt_B_SLSRYO_SUM.HeaderText = "B_SLSRYO_SUM"
        Me.txt_B_SLSRYO_SUM.MinimumWidth = 8
        Me.txt_B_SLSRYO_SUM.Name = "txt_B_SLSRYO_SUM"
        Me.txt_B_SLSRYO_SUM.ReadOnly = True
        Me.txt_B_SLSRYO_SUM.Width = 94
        '
        'txt_SYUTOK_GEN_SUM
        '
        Me.txt_SYUTOK_GEN_SUM.DataPropertyName = "SYUTOK_GEN_SUM"
        Me.txt_SYUTOK_GEN_SUM.HeaderText = "SYUTOK_GEN_SUM"
        Me.txt_SYUTOK_GEN_SUM.MinimumWidth = 8
        Me.txt_SYUTOK_GEN_SUM.Name = "txt_SYUTOK_GEN_SUM"
        Me.txt_SYUTOK_GEN_SUM.ReadOnly = True
        Me.txt_SYUTOK_GEN_SUM.Width = 94
        '
        'txt_GRUIKEI_GEN_SUM
        '
        Me.txt_GRUIKEI_GEN_SUM.DataPropertyName = "GRUIKEI_GEN_SUM"
        Me.txt_GRUIKEI_GEN_SUM.HeaderText = "GRUIKEI_GEN_SUM"
        Me.txt_GRUIKEI_GEN_SUM.MinimumWidth = 8
        Me.txt_GRUIKEI_GEN_SUM.Name = "txt_GRUIKEI_GEN_SUM"
        Me.txt_GRUIKEI_GEN_SUM.ReadOnly = True
        Me.txt_GRUIKEI_GEN_SUM.Width = 94
        '
        'txt_SYUTOK_ZOU_SUM
        '
        Me.txt_SYUTOK_ZOU_SUM.DataPropertyName = "SYUTOK_ZOU_SUM"
        Me.txt_SYUTOK_ZOU_SUM.HeaderText = "SYUTOK_ZOU_SUM"
        Me.txt_SYUTOK_ZOU_SUM.MinimumWidth = 8
        Me.txt_SYUTOK_ZOU_SUM.Name = "txt_SYUTOK_ZOU_SUM"
        Me.txt_SYUTOK_ZOU_SUM.ReadOnly = True
        Me.txt_SYUTOK_ZOU_SUM.Width = 94
        '
        'txt_GSON_RKEI_GEN_SUM
        '
        Me.txt_GSON_RKEI_GEN_SUM.DataPropertyName = "GSON_RKEI_GEN_SUM"
        Me.txt_GSON_RKEI_GEN_SUM.HeaderText = "GSON_RKEI_GEN_SUM"
        Me.txt_GSON_RKEI_GEN_SUM.MinimumWidth = 8
        Me.txt_GSON_RKEI_GEN_SUM.Name = "txt_GSON_RKEI_GEN_SUM"
        Me.txt_GSON_RKEI_GEN_SUM.ReadOnly = True
        Me.txt_GSON_RKEI_GEN_SUM.Width = 94
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
        'Form_f_flx_CHUKI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2639, 842)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_CHUKI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "財務諸表注記・対象物件一覧"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_RECALCULATE As System.Windows.Forms.Button
    Friend WithEvents cmd_YOUSHIKI As System.Windows.Forms.Button
    Friend WithEvents cmd_SCH As System.Windows.Forms.Button
    Friend WithEvents cmd_REF As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents txt_LEAKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKMK_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BKIND_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKH_ID As DataGridViewTextBoxColumn
    Friend WithEvents txt_CKAIYK_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_RKEI_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_BOKA_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_LGNPN_ZAN1NAI As DataGridViewTextBoxColumn
    Friend WithEvents txt_LGNPN_ZAN1CHO As DataGridViewTextBoxColumn
    Friend WithEvents txt_LGNPN_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_TOKI As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_TK_TOKI As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_ZOU As DataGridViewTextBoxColumn
    Friend WithEvents txt_RISOKU_HASSEI_TOKI As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_RKEI_ZOU As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KNYUKN As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_SLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_GEN As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_GEN As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZOU As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_RKEI_GEN As DataGridViewTextBoxColumn
    Friend WithEvents txt_CHU_HNTI_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_CHUUM_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KJKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_LKIKAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BOKA_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_LGNPN_ZAN1NAI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_LGNPN_ZAN1CHO_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_LGNPN_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_RKEI_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_ZAN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_TOKI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_TK_TOKI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_ZOU_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_RISOKU_HASSEI_TOKI_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_RKEI_ZOU_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KNYUKN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_SLSRYO_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_GEN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GRUIKEI_GEN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SYUTOK_ZOU_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSON_RKEI_GEN_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As DataGridViewTextBoxColumn
    Friend WithEvents lbl_CONDITION As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
End Class