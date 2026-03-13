<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_IDOLST

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
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_BANGO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT2_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT3_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT4_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT5_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_IDO_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_NM_R1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT2_NM_R1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT3_NM_R1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT4_NM_R1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT5_NM_R1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LKIKAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KNYUKN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_SLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_ZOKUSEI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_CKAIYK_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KJKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexReportDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_RECALCULATE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2000, 125)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1066, 59)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 27
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1246, 51)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1590, 43)
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
        Me.lbl_CONDITION.Location = New System.Drawing.Point(12, 82)
        Me.lbl_CONDITION.Name = "lbl_CONDITION"
        Me.lbl_CONDITION.Size = New System.Drawing.Size(71, 18)
        Me.lbl_CONDITION.TabIndex = 7
        Me.lbl_CONDITION.Text = "移動日："
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(746, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_OUTPUT_FILE.TabIndex = 6
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(563, 13)
        Me.cmd_FlexReportDLG.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(173, 45)
        Me.cmd_FlexReportDLG.TabIndex = 5
        Me.cmd_FlexReportDLG.TabStop = False
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(380, 13)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(173, 45)
        Me.cmd_REF.TabIndex = 2
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = True
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
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_KYKM_NO, Me.txt_BUKN_BANGO1, Me.txt_BUKN_NM, Me.txt_B_BCAT1_NM, Me.txt_B_BCAT2_NM, Me.txt_B_BCAT3_NM, Me.txt_B_BCAT4_NM, Me.txt_B_BCAT5_NM, Me.txt_IDO_DT, Me.txt_B_BCAT1_NM_R1, Me.txt_B_BCAT2_NM_R1, Me.txt_B_BCAT3_NM_R1, Me.txt_B_BCAT4_NM_R1, Me.txt_B_BCAT5_NM_R1, Me.txt_K_LCPT1_NM, Me.txt_KYKBNL, Me.txt_SAIKAISU, Me.txt_START_DT, Me.txt_LKIKAN, Me.txt_K_HISTORY_F, Me.txt_CKAIYK_DT, Me.txt_B_KNYUKN, Me.txt_B_KLSRYO, Me.txt_B_SLSRYO, Me.txt_KYKH_ID, Me.txt_B_ZOKUSEI1, Me.txt_B_CKAIYK_F, Me.txt_KJKBN_NM, Me.txt_ID})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 125)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(2000, 717)
        Me.dgv_LIST.TabIndex = 0
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
        'txt_BUKN_BANGO1
        '
        Me.txt_BUKN_BANGO1.DataPropertyName = "BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.HeaderText = "資産番号1"
        Me.txt_BUKN_BANGO1.MinimumWidth = 8
        Me.txt_BUKN_BANGO1.Name = "txt_BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.ReadOnly = True
        Me.txt_BUKN_BANGO1.Width = 75
        '
        'txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "物件名"
        Me.txt_BUKN_NM.MinimumWidth = 8
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 75
        '
        'txt_B_BCAT1_NM
        '
        Me.txt_B_BCAT1_NM.DataPropertyName = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.HeaderText = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.MinimumWidth = 8
        Me.txt_B_BCAT1_NM.Name = "txt_B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.ReadOnly = True
        Me.txt_B_BCAT1_NM.Width = 151
        '
        'txt_B_BCAT2_NM
        '
        Me.txt_B_BCAT2_NM.DataPropertyName = "B_BCAT2_NM"
        Me.txt_B_BCAT2_NM.HeaderText = "B_BCAT2_NM"
        Me.txt_B_BCAT2_NM.MinimumWidth = 8
        Me.txt_B_BCAT2_NM.Name = "txt_B_BCAT2_NM"
        Me.txt_B_BCAT2_NM.ReadOnly = True
        Me.txt_B_BCAT2_NM.Width = 94
        '
        'txt_B_BCAT3_NM
        '
        Me.txt_B_BCAT3_NM.DataPropertyName = "B_BCAT3_NM"
        Me.txt_B_BCAT3_NM.HeaderText = "B_BCAT3_NM"
        Me.txt_B_BCAT3_NM.MinimumWidth = 8
        Me.txt_B_BCAT3_NM.Name = "txt_B_BCAT3_NM"
        Me.txt_B_BCAT3_NM.ReadOnly = True
        Me.txt_B_BCAT3_NM.Width = 94
        '
        'txt_B_BCAT4_NM
        '
        Me.txt_B_BCAT4_NM.DataPropertyName = "B_BCAT4_NM"
        Me.txt_B_BCAT4_NM.HeaderText = "B_BCAT4_NM"
        Me.txt_B_BCAT4_NM.MinimumWidth = 8
        Me.txt_B_BCAT4_NM.Name = "txt_B_BCAT4_NM"
        Me.txt_B_BCAT4_NM.ReadOnly = True
        Me.txt_B_BCAT4_NM.Width = 94
        '
        'txt_B_BCAT5_NM
        '
        Me.txt_B_BCAT5_NM.DataPropertyName = "B_BCAT5_NM"
        Me.txt_B_BCAT5_NM.HeaderText = "B_BCAT5_NM"
        Me.txt_B_BCAT5_NM.MinimumWidth = 8
        Me.txt_B_BCAT5_NM.Name = "txt_B_BCAT5_NM"
        Me.txt_B_BCAT5_NM.ReadOnly = True
        Me.txt_B_BCAT5_NM.Width = 94
        '
        'txt_IDO_DT
        '
        Me.txt_IDO_DT.DataPropertyName = "IDO_DT"
        Me.txt_IDO_DT.HeaderText = "移動日"
        Me.txt_IDO_DT.MinimumWidth = 8
        Me.txt_IDO_DT.Name = "txt_IDO_DT"
        Me.txt_IDO_DT.ReadOnly = True
        Me.txt_IDO_DT.Width = 75
        '
        'txt_B_BCAT1_NM_R1
        '
        Me.txt_B_BCAT1_NM_R1.DataPropertyName = "B_BCAT1_NM_R1"
        Me.txt_B_BCAT1_NM_R1.HeaderText = "B_BCAT1_NM_R1"
        Me.txt_B_BCAT1_NM_R1.MinimumWidth = 8
        Me.txt_B_BCAT1_NM_R1.Name = "txt_B_BCAT1_NM_R1"
        Me.txt_B_BCAT1_NM_R1.ReadOnly = True
        Me.txt_B_BCAT1_NM_R1.Width = 151
        '
        'txt_B_BCAT2_NM_R1
        '
        Me.txt_B_BCAT2_NM_R1.DataPropertyName = "B_BCAT2_NM_R1"
        Me.txt_B_BCAT2_NM_R1.HeaderText = "B_BCAT2_NM_R1"
        Me.txt_B_BCAT2_NM_R1.MinimumWidth = 8
        Me.txt_B_BCAT2_NM_R1.Name = "txt_B_BCAT2_NM_R1"
        Me.txt_B_BCAT2_NM_R1.ReadOnly = True
        Me.txt_B_BCAT2_NM_R1.Width = 94
        '
        'txt_B_BCAT3_NM_R1
        '
        Me.txt_B_BCAT3_NM_R1.DataPropertyName = "B_BCAT3_NM_R1"
        Me.txt_B_BCAT3_NM_R1.HeaderText = "B_BCAT3_NM_R1"
        Me.txt_B_BCAT3_NM_R1.MinimumWidth = 8
        Me.txt_B_BCAT3_NM_R1.Name = "txt_B_BCAT3_NM_R1"
        Me.txt_B_BCAT3_NM_R1.ReadOnly = True
        Me.txt_B_BCAT3_NM_R1.Width = 94
        '
        'txt_B_BCAT4_NM_R1
        '
        Me.txt_B_BCAT4_NM_R1.DataPropertyName = "B_BCAT4_NM_R1"
        Me.txt_B_BCAT4_NM_R1.HeaderText = "B_BCAT4_NM_R1"
        Me.txt_B_BCAT4_NM_R1.MinimumWidth = 8
        Me.txt_B_BCAT4_NM_R1.Name = "txt_B_BCAT4_NM_R1"
        Me.txt_B_BCAT4_NM_R1.ReadOnly = True
        Me.txt_B_BCAT4_NM_R1.Width = 94
        '
        'txt_B_BCAT5_NM_R1
        '
        Me.txt_B_BCAT5_NM_R1.DataPropertyName = "B_BCAT5_NM_R1"
        Me.txt_B_BCAT5_NM_R1.HeaderText = "B_BCAT5_NM_R1"
        Me.txt_B_BCAT5_NM_R1.MinimumWidth = 8
        Me.txt_B_BCAT5_NM_R1.Name = "txt_B_BCAT5_NM_R1"
        Me.txt_B_BCAT5_NM_R1.ReadOnly = True
        Me.txt_B_BCAT5_NM_R1.Width = 94
        '
        'txt_K_LCPT1_NM
        '
        Me.txt_K_LCPT1_NM.DataPropertyName = "K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.HeaderText = "支払先"
        Me.txt_K_LCPT1_NM.MinimumWidth = 8
        Me.txt_K_LCPT1_NM.Name = "txt_K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.ReadOnly = True
        Me.txt_K_LCPT1_NM.Width = 113
        '
        'txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "契約番号"
        Me.txt_KYKBNL.MinimumWidth = 8
        Me.txt_KYKBNL.Name = "txt_KYKBNL"
        Me.txt_KYKBNL.ReadOnly = True
        Me.txt_KYKBNL.Width = 75
        '
        'txt_SAIKAISU
        '
        Me.txt_SAIKAISU.DataPropertyName = "SAIKAISU"
        Me.txt_SAIKAISU.HeaderText = "再ﾘｰｽ回数"
        Me.txt_SAIKAISU.MinimumWidth = 8
        Me.txt_SAIKAISU.Name = "txt_SAIKAISU"
        Me.txt_SAIKAISU.ReadOnly = True
        Me.txt_SAIKAISU.Width = 60
        '
        'txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "開始日"
        Me.txt_START_DT.MinimumWidth = 8
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 75
        '
        'txt_LKIKAN
        '
        Me.txt_LKIKAN.DataPropertyName = "LKIKAN"
        Me.txt_LKIKAN.HeaderText = "契約期間"
        Me.txt_LKIKAN.MinimumWidth = 8
        Me.txt_LKIKAN.Name = "txt_LKIKAN"
        Me.txt_LKIKAN.ReadOnly = True
        Me.txt_LKIKAN.Width = 60
        '
        'txt_K_HISTORY_F
        '
        Me.txt_K_HISTORY_F.DataPropertyName = "K_HISTORY_F"
        Me.txt_K_HISTORY_F.HeaderText = "K_HISTORY_F"
        Me.txt_K_HISTORY_F.MinimumWidth = 8
        Me.txt_K_HISTORY_F.Name = "txt_K_HISTORY_F"
        Me.txt_K_HISTORY_F.ReadOnly = True
        Me.txt_K_HISTORY_F.Width = 60
        '
        'txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.HeaderText = "中途解約日"
        Me.txt_CKAIYK_DT.MinimumWidth = 8
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Width = 75
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
        'txt_B_KLSRYO
        '
        Me.txt_B_KLSRYO.DataPropertyName = "B_KLSRYO"
        Me.txt_B_KLSRYO.HeaderText = "1支払額"
        Me.txt_B_KLSRYO.MinimumWidth = 8
        Me.txt_B_KLSRYO.Name = "txt_B_KLSRYO"
        Me.txt_B_KLSRYO.ReadOnly = True
        Me.txt_B_KLSRYO.Width = 94
        '
        'txt_B_SLSRYO
        '
        Me.txt_B_SLSRYO.DataPropertyName = "B_SLSRYO"
        Me.txt_B_SLSRYO.HeaderText = "総額ﾘｰｽ料"
        Me.txt_B_SLSRYO.MinimumWidth = 8
        Me.txt_B_SLSRYO.Name = "txt_B_SLSRYO"
        Me.txt_B_SLSRYO.ReadOnly = True
        Me.txt_B_SLSRYO.Width = 94
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
        'txt_B_ZOKUSEI1
        '
        Me.txt_B_ZOKUSEI1.DataPropertyName = "B_ZOKUSEI1"
        Me.txt_B_ZOKUSEI1.HeaderText = "備考"
        Me.txt_B_ZOKUSEI1.MinimumWidth = 8
        Me.txt_B_ZOKUSEI1.Name = "txt_B_ZOKUSEI1"
        Me.txt_B_ZOKUSEI1.ReadOnly = True
        Me.txt_B_ZOKUSEI1.Width = 75
        '
        'txt_B_CKAIYK_F
        '
        Me.txt_B_CKAIYK_F.DataPropertyName = "B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.HeaderText = "B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.MinimumWidth = 8
        Me.txt_B_CKAIYK_F.Name = "txt_B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.ReadOnly = True
        Me.txt_B_CKAIYK_F.Width = 60
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
        'Form_f_flx_IDOLST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2000, 842)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_IDOLST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "移動物件一覧表"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_RECALCULATE As System.Windows.Forms.Button
    Friend WithEvents cmd_REF As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents txt_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_BANGO1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT2_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT3_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT4_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT5_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_IDO_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_NM_R1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT2_NM_R1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT3_NM_R1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT4_NM_R1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT5_NM_R1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_K_LCPT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents txt_SAIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_LKIKAN As DataGridViewTextBoxColumn
    Friend WithEvents txt_K_HISTORY_F As DataGridViewTextBoxColumn
    Friend WithEvents txt_CKAIYK_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KNYUKN As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_SLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKH_ID As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_ZOKUSEI1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_CKAIYK_F As DataGridViewTextBoxColumn
    Friend WithEvents txt_KJKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As DataGridViewTextBoxColumn
    Friend WithEvents lbl_CONDITION As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
End Class