<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_flx_KEIJO
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LINE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_REC_KBN_STR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KJKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HOREI_KBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LEAKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HKMK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_END_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SEIKYU_MONTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SUMIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_KNYUKN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LSRYO_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LSRYO_ZZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LSRYO_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZEI_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZKOMI_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LSRYO_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LSRYO_ZAN1NAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZRITU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHRI_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHHO_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.lbl_CONDITION = New System.Windows.Forms.Label()
        Me.cmd_OUTPUT_FILE = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_支払照合 = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_LIST
        '
        Me.dgv_LIST.AllowUserToAddRows = False
        Me.dgv_LIST.AllowUserToDeleteRows = False
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_KYKM_NO, Me.col_SAIKAISU, Me.col_LINE_ID, Me.col_KKBN_NM, Me.col_REC_KBN_STR, Me.col_KJKBN_NM, Me.col_HOREI_KBN, Me.col_LEAKBN_NM, Me.col_KYKBNL, Me.col_LCPT1_NM, Me.col_BUKN_NM, Me.col_B_BCAT_NM, Me.col_H_BCAT_NM, Me.col_HKMK, Me.col_START_DT, Me.col_END_DT, Me.col_SEIKYU_MONTH, Me.col_CKAIYK_DT, Me.col_SUMIKAISU, Me.col_B_KNYUKN, Me.col_LSRYO_TOTAL, Me.col_LSRYO_ZZAN, Me.col_LSRYO_TOKI, Me.col_ZEI_TOKI, Me.col_ZKOMI_TOKI, Me.col_LSRYO_ZAN, Me.col_LSRYO_ZAN1NAI, Me.col_ZRITU, Me.col_SHRI_DT, Me.col_SHHO_NM})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 124)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(2267, 718)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_KYKM_NO
        '
        Me.col_KYKM_NO.DataPropertyName = "KYKM_NO"
        Me.col_KYKM_NO.HeaderText = "物件No"
        Me.col_KYKM_NO.MinimumWidth = 8
        Me.col_KYKM_NO.Name = "col_KYKM_NO"
        Me.col_KYKM_NO.ReadOnly = True
        Me.col_KYKM_NO.Width = 60
        '
        'col_SAIKAISU
        '
        Me.col_SAIKAISU.DataPropertyName = "SAIKAISU"
        Me.col_SAIKAISU.HeaderText = "再回"
        Me.col_SAIKAISU.MinimumWidth = 8
        Me.col_SAIKAISU.Name = "col_SAIKAISU"
        Me.col_SAIKAISU.ReadOnly = True
        Me.col_SAIKAISU.Width = 60
        '
        'col_LINE_ID
        '
        Me.col_LINE_ID.DataPropertyName = "LINE_ID"
        Me.col_LINE_ID.HeaderText = "配No"
        Me.col_LINE_ID.MinimumWidth = 8
        Me.col_LINE_ID.Name = "col_LINE_ID"
        Me.col_LINE_ID.ReadOnly = True
        Me.col_LINE_ID.Width = 60
        '
        'col_KKBN_NM
        '
        Me.col_KKBN_NM.DataPropertyName = "KKBN_NM"
        Me.col_KKBN_NM.HeaderText = "契区"
        Me.col_KKBN_NM.MinimumWidth = 8
        Me.col_KKBN_NM.Name = "col_KKBN_NM"
        Me.col_KKBN_NM.ReadOnly = True
        Me.col_KKBN_NM.Width = 60
        '
        'col_REC_KBN_STR
        '
        Me.col_REC_KBN_STR.DataPropertyName = "REC_KBN_STR"
        Me.col_REC_KBN_STR.HeaderText = "行区"
        Me.col_REC_KBN_STR.MinimumWidth = 8
        Me.col_REC_KBN_STR.Name = "col_REC_KBN_STR"
        Me.col_REC_KBN_STR.ReadOnly = True
        Me.col_REC_KBN_STR.Width = 60
        '
        'col_KJKBN_NM
        '
        Me.col_KJKBN_NM.HeaderText = "計上区分"
        Me.col_KJKBN_NM.MinimumWidth = 8
        Me.col_KJKBN_NM.Name = "col_KJKBN_NM"
        Me.col_KJKBN_NM.ReadOnly = True
        Me.col_KJKBN_NM.Width = 150
        '
        'col_HOREI_KBN
        '
        Me.col_HOREI_KBN.HeaderText = "法令区分"
        Me.col_HOREI_KBN.MinimumWidth = 8
        Me.col_HOREI_KBN.Name = "col_HOREI_KBN"
        Me.col_HOREI_KBN.ReadOnly = True
        Me.col_HOREI_KBN.Width = 150
        '
        'col_LEAKBN_NM
        '
        Me.col_LEAKBN_NM.HeaderText = "リース区分"
        Me.col_LEAKBN_NM.MinimumWidth = 8
        Me.col_LEAKBN_NM.Name = "col_LEAKBN_NM"
        Me.col_LEAKBN_NM.ReadOnly = True
        Me.col_LEAKBN_NM.Width = 150
        '
        'col_KYKBNL
        '
        Me.col_KYKBNL.HeaderText = "契約番号"
        Me.col_KYKBNL.MinimumWidth = 8
        Me.col_KYKBNL.Name = "col_KYKBNL"
        Me.col_KYKBNL.ReadOnly = True
        Me.col_KYKBNL.Width = 150
        '
        'col_LCPT1_NM
        '
        Me.col_LCPT1_NM.HeaderText = "支払先"
        Me.col_LCPT1_NM.MinimumWidth = 8
        Me.col_LCPT1_NM.Name = "col_LCPT1_NM"
        Me.col_LCPT1_NM.ReadOnly = True
        Me.col_LCPT1_NM.Width = 150
        '
        'col_BUKN_NM
        '
        Me.col_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.col_BUKN_NM.HeaderText = "物件名"
        Me.col_BUKN_NM.MinimumWidth = 8
        Me.col_BUKN_NM.Name = "col_BUKN_NM"
        Me.col_BUKN_NM.ReadOnly = True
        Me.col_BUKN_NM.Width = 75
        '
        'col_B_BCAT_NM
        '
        Me.col_B_BCAT_NM.HeaderText = "管理部署"
        Me.col_B_BCAT_NM.MinimumWidth = 8
        Me.col_B_BCAT_NM.Name = "col_B_BCAT_NM"
        Me.col_B_BCAT_NM.ReadOnly = True
        Me.col_B_BCAT_NM.Width = 150
        '
        'col_H_BCAT_NM
        '
        Me.col_H_BCAT_NM.HeaderText = "費用負担部署"
        Me.col_H_BCAT_NM.MinimumWidth = 8
        Me.col_H_BCAT_NM.Name = "col_H_BCAT_NM"
        Me.col_H_BCAT_NM.ReadOnly = True
        Me.col_H_BCAT_NM.Width = 150
        '
        'col_HKMK
        '
        Me.col_HKMK.HeaderText = "費用区分"
        Me.col_HKMK.MinimumWidth = 8
        Me.col_HKMK.Name = "col_HKMK"
        Me.col_HKMK.ReadOnly = True
        Me.col_HKMK.Width = 150
        '
        'col_START_DT
        '
        Me.col_START_DT.DataPropertyName = "START_DT"
        Me.col_START_DT.HeaderText = "開始日"
        Me.col_START_DT.MinimumWidth = 8
        Me.col_START_DT.Name = "col_START_DT"
        Me.col_START_DT.ReadOnly = True
        Me.col_START_DT.Width = 75
        '
        'col_END_DT
        '
        Me.col_END_DT.HeaderText = "終了日"
        Me.col_END_DT.MinimumWidth = 8
        Me.col_END_DT.Name = "col_END_DT"
        Me.col_END_DT.ReadOnly = True
        Me.col_END_DT.Width = 150
        '
        'col_SEIKYU_MONTH
        '
        Me.col_SEIKYU_MONTH.HeaderText = "請求月"
        Me.col_SEIKYU_MONTH.MinimumWidth = 8
        Me.col_SEIKYU_MONTH.Name = "col_SEIKYU_MONTH"
        Me.col_SEIKYU_MONTH.ReadOnly = True
        Me.col_SEIKYU_MONTH.Width = 150
        '
        'col_CKAIYK_DT
        '
        Me.col_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.col_CKAIYK_DT.HeaderText = "中途解約日"
        Me.col_CKAIYK_DT.MinimumWidth = 8
        Me.col_CKAIYK_DT.Name = "col_CKAIYK_DT"
        Me.col_CKAIYK_DT.ReadOnly = True
        Me.col_CKAIYK_DT.Width = 75
        '
        'col_SUMIKAISU
        '
        Me.col_SUMIKAISU.DataPropertyName = "SUMIKAISU"
        Me.col_SUMIKAISU.HeaderText = "回数済/総"
        Me.col_SUMIKAISU.MinimumWidth = 8
        Me.col_SUMIKAISU.Name = "col_SUMIKAISU"
        Me.col_SUMIKAISU.ReadOnly = True
        Me.col_SUMIKAISU.Width = 60
        '
        'col_B_KNYUKN
        '
        Me.col_B_KNYUKN.DataPropertyName = "B_KNYUKN"
        Me.col_B_KNYUKN.HeaderText = "現金購入価額(物件)"
        Me.col_B_KNYUKN.MinimumWidth = 8
        Me.col_B_KNYUKN.Name = "col_B_KNYUKN"
        Me.col_B_KNYUKN.ReadOnly = True
        Me.col_B_KNYUKN.Width = 94
        '
        'col_LSRYO_TOTAL
        '
        Me.col_LSRYO_TOTAL.DataPropertyName = "LSRYO_TOTAL"
        Me.col_LSRYO_TOTAL.HeaderText = "総支払額"
        Me.col_LSRYO_TOTAL.MinimumWidth = 8
        Me.col_LSRYO_TOTAL.Name = "col_LSRYO_TOTAL"
        Me.col_LSRYO_TOTAL.ReadOnly = True
        Me.col_LSRYO_TOTAL.Width = 94
        '
        'col_LSRYO_ZZAN
        '
        Me.col_LSRYO_ZZAN.DataPropertyName = "LSRYO_ZZAN"
        Me.col_LSRYO_ZZAN.HeaderText = "前月末残高"
        Me.col_LSRYO_ZZAN.MinimumWidth = 8
        Me.col_LSRYO_ZZAN.Name = "col_LSRYO_ZZAN"
        Me.col_LSRYO_ZZAN.ReadOnly = True
        Me.col_LSRYO_ZZAN.Width = 94
        '
        'col_LSRYO_TOKI
        '
        Me.col_LSRYO_TOKI.DataPropertyName = "LSRYO_TOKI"
        Me.col_LSRYO_TOKI.HeaderText = "税抜き"
        Me.col_LSRYO_TOKI.MinimumWidth = 8
        Me.col_LSRYO_TOKI.Name = "col_LSRYO_TOKI"
        Me.col_LSRYO_TOKI.ReadOnly = True
        Me.col_LSRYO_TOKI.Width = 94
        '
        'col_ZEI_TOKI
        '
        Me.col_ZEI_TOKI.DataPropertyName = "ZEI_TOKI"
        Me.col_ZEI_TOKI.HeaderText = "消費税"
        Me.col_ZEI_TOKI.MinimumWidth = 8
        Me.col_ZEI_TOKI.Name = "col_ZEI_TOKI"
        Me.col_ZEI_TOKI.ReadOnly = True
        Me.col_ZEI_TOKI.Width = 94
        '
        'col_ZKOMI_TOKI
        '
        Me.col_ZKOMI_TOKI.DataPropertyName = "ZKOMI_TOKI"
        Me.col_ZKOMI_TOKI.HeaderText = "税込み"
        Me.col_ZKOMI_TOKI.MinimumWidth = 8
        Me.col_ZKOMI_TOKI.Name = "col_ZKOMI_TOKI"
        Me.col_ZKOMI_TOKI.ReadOnly = True
        Me.col_ZKOMI_TOKI.Width = 94
        '
        'col_LSRYO_ZAN
        '
        Me.col_LSRYO_ZAN.DataPropertyName = "LSRYO_ZAN"
        Me.col_LSRYO_ZAN.HeaderText = "当月末残高"
        Me.col_LSRYO_ZAN.MinimumWidth = 8
        Me.col_LSRYO_ZAN.Name = "col_LSRYO_ZAN"
        Me.col_LSRYO_ZAN.ReadOnly = True
        Me.col_LSRYO_ZAN.Width = 94
        '
        'col_LSRYO_ZAN1NAI
        '
        Me.col_LSRYO_ZAN1NAI.DataPropertyName = "LSRYO_ZAN1NAI"
        Me.col_LSRYO_ZAN1NAI.HeaderText = "内１年内"
        Me.col_LSRYO_ZAN1NAI.MinimumWidth = 8
        Me.col_LSRYO_ZAN1NAI.Name = "col_LSRYO_ZAN1NAI"
        Me.col_LSRYO_ZAN1NAI.ReadOnly = True
        Me.col_LSRYO_ZAN1NAI.Width = 94
        '
        'col_ZRITU
        '
        Me.col_ZRITU.DataPropertyName = "ZRITU"
        Me.col_ZRITU.HeaderText = "消費税率"
        Me.col_ZRITU.MinimumWidth = 8
        Me.col_ZRITU.Name = "col_ZRITU"
        Me.col_ZRITU.ReadOnly = True
        Me.col_ZRITU.Width = 60
        '
        'col_SHRI_DT
        '
        Me.col_SHRI_DT.DataPropertyName = "SHRI_DT"
        Me.col_SHRI_DT.HeaderText = "支払日"
        Me.col_SHRI_DT.MinimumWidth = 8
        Me.col_SHRI_DT.Name = "col_SHRI_DT"
        Me.col_SHRI_DT.ReadOnly = True
        Me.col_SHRI_DT.Width = 75
        '
        'col_SHHO_NM
        '
        Me.col_SHHO_NM.HeaderText = "支払方法"
        Me.col_SHHO_NM.MinimumWidth = 8
        Me.col_SHHO_NM.Name = "col_SHHO_NM"
        Me.col_SHHO_NM.ReadOnly = True
        Me.col_SHHO_NM.Width = 150
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Controls.Add(Me.txt_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_SEARCH)
        Me.pnlHeader.Controls.Add(Me.lbl_CONDITION)
        Me.pnlHeader.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexReportDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_支払照合)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_RECALCULATE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2267, 124)
        Me.pnlHeader.TabIndex = 13
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1094, 55)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 24
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1274, 47)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1618, 39)
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
        Me.lbl_CONDITION.Location = New System.Drawing.Point(12, 80)
        Me.lbl_CONDITION.Name = "lbl_CONDITION"
        Me.lbl_CONDITION.Size = New System.Drawing.Size(66, 18)
        Me.lbl_CONDITION.TabIndex = 12
        Me.lbl_CONDITION.Text = "集計月:"
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(831, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(153, 45)
        Me.cmd_OUTPUT_FILE.TabIndex = 11
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(668, 13)
        Me.cmd_FlexReportDLG.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(153, 45)
        Me.cmd_FlexReportDLG.TabIndex = 10
        Me.cmd_FlexReportDLG.TabStop = False
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        'cmd_支払照合
        '
        Me.cmd_支払照合.Location = New System.Drawing.Point(505, 13)
        Me.cmd_支払照合.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_支払照合.Name = "cmd_支払照合"
        Me.cmd_支払照合.Size = New System.Drawing.Size(153, 45)
        Me.cmd_支払照合.TabIndex = 3
        Me.cmd_支払照合.TabStop = False
        Me.cmd_支払照合.Text = "支払照合(&P)"
        Me.cmd_支払照合.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(342, 13)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(153, 45)
        Me.cmd_REF.TabIndex = 2
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = True
        '
        'cmd_RECALCULATE
        '
        Me.cmd_RECALCULATE.Location = New System.Drawing.Point(178, 13)
        Me.cmd_RECALCULATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_RECALCULATE.Name = "cmd_RECALCULATE"
        Me.cmd_RECALCULATE.Size = New System.Drawing.Size(154, 45)
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
        Me.cmd_CLOSE.Size = New System.Drawing.Size(154, 45)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'Form_f_flx_MONTHLY_PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2267, 842)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_MONTHLY_PAYMENT"
        Me.Text = "月次支払照合フレックス"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents cmd_OUTPUT_FILE As Button
    Friend WithEvents cmd_FlexReportDLG As Button
    Friend WithEvents cmd_支払照合 As Button
    Friend WithEvents cmd_REF As Button
    Friend WithEvents cmd_RECALCULATE As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents lbl_CONDITION As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
    Friend WithEvents col_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_SAIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents col_LINE_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_KKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_REC_KBN_STR As DataGridViewTextBoxColumn
    Friend WithEvents col_KJKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_HOREI_KBN As DataGridViewTextBoxColumn
    Friend WithEvents col_LEAKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents col_LCPT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_B_BCAT_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_H_BCAT_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_HKMK As DataGridViewTextBoxColumn
    Friend WithEvents col_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_END_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_SEIKYU_MONTH As DataGridViewTextBoxColumn
    Friend WithEvents col_CKAIYK_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_SUMIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents col_B_KNYUKN As DataGridViewTextBoxColumn
    Friend WithEvents col_LSRYO_TOTAL As DataGridViewTextBoxColumn
    Friend WithEvents col_LSRYO_ZZAN As DataGridViewTextBoxColumn
    Friend WithEvents col_LSRYO_TOKI As DataGridViewTextBoxColumn
    Friend WithEvents col_ZEI_TOKI As DataGridViewTextBoxColumn
    Friend WithEvents col_ZKOMI_TOKI As DataGridViewTextBoxColumn
    Friend WithEvents col_LSRYO_ZAN As DataGridViewTextBoxColumn
    Friend WithEvents col_LSRYO_ZAN1NAI As DataGridViewTextBoxColumn
    Friend WithEvents col_ZRITU As DataGridViewTextBoxColumn
    Friend WithEvents col_SHRI_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_SHHO_NM As DataGridViewTextBoxColumn
End Class
