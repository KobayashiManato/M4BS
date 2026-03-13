<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_BEPPYO2

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
        Me.cmd_PRINT_BEPPYO = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.txt_KISYU_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KIMAT_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_JKYAK_F_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_JKYAK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_JNINYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_JKYAK_BOKA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYAKDT_04 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KASHIDT_05 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RKSYTK_17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RKZANK_18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RKKISO_19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMBOKA_20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KIKAN_24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_TKIKAN_25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ZSKYAK_26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KSKYAK_31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKYAKHS_32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKYAKTK_33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ZENKKR_34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_TSNYHS_35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_YOKKURI_37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_JNINYO_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_JKYAK_BOKA_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RKSYTK_17_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RKZANK_18_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RKKISO_19_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMBOKA_20_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ZSKYAK_26_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KSKYAK_31_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKYAKHS_32_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKYAKTK_33_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ZENKKR_34_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_TSNYHS_35_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_YOKKURI_37_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_PRINT_BEPPYO)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_RECALCULATE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2000, 133)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1080, 61)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 42
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1260, 53)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1604, 45)
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
        Me.lbl_CONDITION.Size = New System.Drawing.Size(89, 18)
        Me.lbl_CONDITION.TabIndex = 7
        Me.lbl_CONDITION.Text = "事業年度："
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
        'cmd_PRINT_BEPPYO
        '
        Me.cmd_PRINT_BEPPYO.Location = New System.Drawing.Point(380, 13)
        Me.cmd_PRINT_BEPPYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_PRINT_BEPPYO.Name = "cmd_PRINT_BEPPYO"
        Me.cmd_PRINT_BEPPYO.Size = New System.Drawing.Size(173, 45)
        Me.cmd_PRINT_BEPPYO.TabIndex = 3
        Me.cmd_PRINT_BEPPYO.TabStop = False
        Me.cmd_PRINT_BEPPYO.Text = "別表印刷(&P)"
        Me.cmd_PRINT_BEPPYO.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(563, 13)
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
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_KISYU_DT, Me.txt_KIMAT_DT, Me.txt_KYKM_NO, Me.txt_BUKN_NM, Me.txt_SKMK_NM, Me.txt_KYKBNL, Me.txt_JKYAK_F_NM, Me.txt_JKYAK_DT, Me.txt_JNINYO, Me.txt_JKYAK_BOKA, Me.txt_KYAKDT_04, Me.txt_KASHIDT_05, Me.txt_RKSYTK_17, Me.txt_RKZANK_18, Me.txt_RKKISO_19, Me.txt_KMBOKA_20, Me.txt_KIKAN_24, Me.txt_TKIKAN_25, Me.txt_ZSKYAK_26, Me.txt_KSKYAK_31, Me.txt_SKYAKHS_32, Me.txt_SKYAKTK_33, Me.txt_ZENKKR_34, Me.txt_TSNYHS_35, Me.txt_YOKKURI_37, Me.txt_JNINYO_SUM, Me.txt_JKYAK_BOKA_SUM, Me.txt_RKSYTK_17_SUM, Me.txt_RKZANK_18_SUM, Me.txt_RKKISO_19_SUM, Me.txt_KMBOKA_20_SUM, Me.txt_ZSKYAK_26_SUM, Me.txt_KSKYAK_31_SUM, Me.txt_SKYAKHS_32_SUM, Me.txt_SKYAKTK_33_SUM, Me.txt_ZENKKR_34_SUM, Me.txt_TSNYHS_35_SUM, Me.txt_YOKKURI_37_SUM, Me.txt_ID})
        Me.dgv_LIST.Location = New System.Drawing.Point(14, 141)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersVisible = False
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(1986, 580)
        Me.dgv_LIST.TabIndex = 0
        '
        'txt_KISYU_DT
        '
        Me.txt_KISYU_DT.DataPropertyName = "KISYU_DT"
        Me.txt_KISYU_DT.HeaderText = "期首日"
        Me.txt_KISYU_DT.MinimumWidth = 8
        Me.txt_KISYU_DT.Name = "txt_KISYU_DT"
        Me.txt_KISYU_DT.ReadOnly = True
        Me.txt_KISYU_DT.Width = 68
        '
        'txt_KIMAT_DT
        '
        Me.txt_KIMAT_DT.DataPropertyName = "KIMAT_DT"
        Me.txt_KIMAT_DT.HeaderText = "期末日"
        Me.txt_KIMAT_DT.MinimumWidth = 8
        Me.txt_KIMAT_DT.Name = "txt_KIMAT_DT"
        Me.txt_KIMAT_DT.ReadOnly = True
        Me.txt_KIMAT_DT.Width = 68
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
        'txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "物件名"
        Me.txt_BUKN_NM.MinimumWidth = 8
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 75
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
        'txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "契約番号"
        Me.txt_KYKBNL.MinimumWidth = 8
        Me.txt_KYKBNL.Name = "txt_KYKBNL"
        Me.txt_KYKBNL.ReadOnly = True
        Me.txt_KYKBNL.Width = 75
        '
        'txt_JKYAK_F_NM
        '
        Me.txt_JKYAK_F_NM.DataPropertyName = "JKYAK_F_NM"
        Me.txt_JKYAK_F_NM.HeaderText = "JKYAK_F_NM"
        Me.txt_JKYAK_F_NM.MinimumWidth = 8
        Me.txt_JKYAK_F_NM.Name = "txt_JKYAK_F_NM"
        Me.txt_JKYAK_F_NM.ReadOnly = True
        Me.txt_JKYAK_F_NM.Width = 60
        '
        'txt_JKYAK_DT
        '
        Me.txt_JKYAK_DT.DataPropertyName = "JKYAK_DT"
        Me.txt_JKYAK_DT.HeaderText = "JKYAK_DT"
        Me.txt_JKYAK_DT.MinimumWidth = 8
        Me.txt_JKYAK_DT.Name = "txt_JKYAK_DT"
        Me.txt_JKYAK_DT.ReadOnly = True
        Me.txt_JKYAK_DT.Width = 68
        '
        'txt_JNINYO
        '
        Me.txt_JNINYO.DataPropertyName = "JNINYO"
        Me.txt_JNINYO.HeaderText = "JNINYO"
        Me.txt_JNINYO.MinimumWidth = 8
        Me.txt_JNINYO.Name = "txt_JNINYO"
        Me.txt_JNINYO.ReadOnly = True
        Me.txt_JNINYO.Width = 86
        '
        'txt_JKYAK_BOKA
        '
        Me.txt_JKYAK_BOKA.DataPropertyName = "JKYAK_BOKA"
        Me.txt_JKYAK_BOKA.HeaderText = "JKYAK_BOKA"
        Me.txt_JKYAK_BOKA.MinimumWidth = 8
        Me.txt_JKYAK_BOKA.Name = "txt_JKYAK_BOKA"
        Me.txt_JKYAK_BOKA.ReadOnly = True
        Me.txt_JKYAK_BOKA.Width = 86
        '
        'txt_KYAKDT_04
        '
        Me.txt_KYAKDT_04.DataPropertyName = "KYAKDT_04"
        Me.txt_KYAKDT_04.HeaderText = "契約日"
        Me.txt_KYAKDT_04.MinimumWidth = 8
        Me.txt_KYAKDT_04.Name = "txt_KYAKDT_04"
        Me.txt_KYAKDT_04.ReadOnly = True
        Me.txt_KYAKDT_04.Width = 68
        '
        'txt_KASHIDT_05
        '
        Me.txt_KASHIDT_05.DataPropertyName = "KASHIDT_05"
        Me.txt_KASHIDT_05.HeaderText = "KASHIDT_05"
        Me.txt_KASHIDT_05.MinimumWidth = 8
        Me.txt_KASHIDT_05.Name = "txt_KASHIDT_05"
        Me.txt_KASHIDT_05.ReadOnly = True
        Me.txt_KASHIDT_05.Width = 68
        '
        'txt_RKSYTK_17
        '
        Me.txt_RKSYTK_17.DataPropertyName = "RKSYTK_17"
        Me.txt_RKSYTK_17.HeaderText = "RKSYTK_17"
        Me.txt_RKSYTK_17.MinimumWidth = 8
        Me.txt_RKSYTK_17.Name = "txt_RKSYTK_17"
        Me.txt_RKSYTK_17.ReadOnly = True
        Me.txt_RKSYTK_17.Width = 86
        '
        'txt_RKZANK_18
        '
        Me.txt_RKZANK_18.DataPropertyName = "RKZANK_18"
        Me.txt_RKZANK_18.HeaderText = "残価保証額"
        Me.txt_RKZANK_18.MinimumWidth = 8
        Me.txt_RKZANK_18.Name = "txt_RKZANK_18"
        Me.txt_RKZANK_18.ReadOnly = True
        Me.txt_RKZANK_18.Width = 86
        '
        'txt_RKKISO_19
        '
        Me.txt_RKKISO_19.DataPropertyName = "RKKISO_19"
        Me.txt_RKKISO_19.HeaderText = "償却計算基礎金額"
        Me.txt_RKKISO_19.MinimumWidth = 8
        Me.txt_RKKISO_19.Name = "txt_RKKISO_19"
        Me.txt_RKKISO_19.ReadOnly = True
        Me.txt_RKKISO_19.Width = 86
        '
        'txt_KMBOKA_20
        '
        Me.txt_KMBOKA_20.DataPropertyName = "KMBOKA_20"
        Me.txt_KMBOKA_20.HeaderText = "期末簿価"
        Me.txt_KMBOKA_20.MinimumWidth = 8
        Me.txt_KMBOKA_20.Name = "txt_KMBOKA_20"
        Me.txt_KMBOKA_20.ReadOnly = True
        Me.txt_KMBOKA_20.Width = 86
        '
        'txt_KIKAN_24
        '
        Me.txt_KIKAN_24.DataPropertyName = "KIKAN_24"
        Me.txt_KIKAN_24.HeaderText = "KIKAN_24"
        Me.txt_KIKAN_24.MinimumWidth = 8
        Me.txt_KIKAN_24.Name = "txt_KIKAN_24"
        Me.txt_KIKAN_24.ReadOnly = True
        Me.txt_KIKAN_24.Width = 60
        '
        'txt_TKIKAN_25
        '
        Me.txt_TKIKAN_25.DataPropertyName = "TKIKAN_25"
        Me.txt_TKIKAN_25.HeaderText = "TKIKAN_25"
        Me.txt_TKIKAN_25.MinimumWidth = 8
        Me.txt_TKIKAN_25.Name = "txt_TKIKAN_25"
        Me.txt_TKIKAN_25.ReadOnly = True
        Me.txt_TKIKAN_25.Width = 60
        '
        'txt_ZSKYAK_26
        '
        Me.txt_ZSKYAK_26.DataPropertyName = "ZSKYAK_26"
        Me.txt_ZSKYAK_26.HeaderText = "ZSKYAK_26"
        Me.txt_ZSKYAK_26.MinimumWidth = 8
        Me.txt_ZSKYAK_26.Name = "txt_ZSKYAK_26"
        Me.txt_ZSKYAK_26.ReadOnly = True
        Me.txt_ZSKYAK_26.Width = 86
        '
        'txt_KSKYAK_31
        '
        Me.txt_KSKYAK_31.DataPropertyName = "KSKYAK_31"
        Me.txt_KSKYAK_31.HeaderText = "KSKYAK_31"
        Me.txt_KSKYAK_31.MinimumWidth = 8
        Me.txt_KSKYAK_31.Name = "txt_KSKYAK_31"
        Me.txt_KSKYAK_31.ReadOnly = True
        Me.txt_KSKYAK_31.Width = 86
        '
        'txt_SKYAKHS_32
        '
        Me.txt_SKYAKHS_32.DataPropertyName = "SKYAKHS_32"
        Me.txt_SKYAKHS_32.HeaderText = "SKYAKHS_32"
        Me.txt_SKYAKHS_32.MinimumWidth = 8
        Me.txt_SKYAKHS_32.Name = "txt_SKYAKHS_32"
        Me.txt_SKYAKHS_32.ReadOnly = True
        Me.txt_SKYAKHS_32.Width = 86
        '
        'txt_SKYAKTK_33
        '
        Me.txt_SKYAKTK_33.DataPropertyName = "SKYAKTK_33"
        Me.txt_SKYAKTK_33.HeaderText = "SKYAKTK_33"
        Me.txt_SKYAKTK_33.MinimumWidth = 8
        Me.txt_SKYAKTK_33.Name = "txt_SKYAKTK_33"
        Me.txt_SKYAKTK_33.ReadOnly = True
        Me.txt_SKYAKTK_33.Width = 86
        '
        'txt_ZENKKR_34
        '
        Me.txt_ZENKKR_34.DataPropertyName = "ZENKKR_34"
        Me.txt_ZENKKR_34.HeaderText = "ZENKKR_34"
        Me.txt_ZENKKR_34.MinimumWidth = 8
        Me.txt_ZENKKR_34.Name = "txt_ZENKKR_34"
        Me.txt_ZENKKR_34.ReadOnly = True
        Me.txt_ZENKKR_34.Width = 86
        '
        'txt_TSNYHS_35
        '
        Me.txt_TSNYHS_35.DataPropertyName = "TSNYHS_35"
        Me.txt_TSNYHS_35.HeaderText = "TSNYHS_35"
        Me.txt_TSNYHS_35.MinimumWidth = 8
        Me.txt_TSNYHS_35.Name = "txt_TSNYHS_35"
        Me.txt_TSNYHS_35.ReadOnly = True
        Me.txt_TSNYHS_35.Width = 86
        '
        'txt_YOKKURI_37
        '
        Me.txt_YOKKURI_37.DataPropertyName = "YOKKURI_37"
        Me.txt_YOKKURI_37.HeaderText = "YOKKURI_37"
        Me.txt_YOKKURI_37.MinimumWidth = 8
        Me.txt_YOKKURI_37.Name = "txt_YOKKURI_37"
        Me.txt_YOKKURI_37.ReadOnly = True
        Me.txt_YOKKURI_37.Width = 86
        '
        'txt_JNINYO_SUM
        '
        Me.txt_JNINYO_SUM.DataPropertyName = "JNINYO_SUM"
        Me.txt_JNINYO_SUM.HeaderText = "JNINYO_SUM"
        Me.txt_JNINYO_SUM.MinimumWidth = 8
        Me.txt_JNINYO_SUM.Name = "txt_JNINYO_SUM"
        Me.txt_JNINYO_SUM.ReadOnly = True
        Me.txt_JNINYO_SUM.Width = 86
        '
        'txt_JKYAK_BOKA_SUM
        '
        Me.txt_JKYAK_BOKA_SUM.DataPropertyName = "JKYAK_BOKA_SUM"
        Me.txt_JKYAK_BOKA_SUM.HeaderText = "JKYAK_BOKA_SUM"
        Me.txt_JKYAK_BOKA_SUM.MinimumWidth = 8
        Me.txt_JKYAK_BOKA_SUM.Name = "txt_JKYAK_BOKA_SUM"
        Me.txt_JKYAK_BOKA_SUM.ReadOnly = True
        Me.txt_JKYAK_BOKA_SUM.Width = 86
        '
        'txt_RKSYTK_17_SUM
        '
        Me.txt_RKSYTK_17_SUM.DataPropertyName = "RKSYTK_17_SUM"
        Me.txt_RKSYTK_17_SUM.HeaderText = "RKSYTK_17_SUM"
        Me.txt_RKSYTK_17_SUM.MinimumWidth = 8
        Me.txt_RKSYTK_17_SUM.Name = "txt_RKSYTK_17_SUM"
        Me.txt_RKSYTK_17_SUM.ReadOnly = True
        Me.txt_RKSYTK_17_SUM.Width = 86
        '
        'txt_RKZANK_18_SUM
        '
        Me.txt_RKZANK_18_SUM.DataPropertyName = "RKZANK_18_SUM"
        Me.txt_RKZANK_18_SUM.HeaderText = "RKZANK_18_SUM"
        Me.txt_RKZANK_18_SUM.MinimumWidth = 8
        Me.txt_RKZANK_18_SUM.Name = "txt_RKZANK_18_SUM"
        Me.txt_RKZANK_18_SUM.ReadOnly = True
        Me.txt_RKZANK_18_SUM.Width = 86
        '
        'txt_RKKISO_19_SUM
        '
        Me.txt_RKKISO_19_SUM.DataPropertyName = "RKKISO_19_SUM"
        Me.txt_RKKISO_19_SUM.HeaderText = "RKKISO_19_SUM"
        Me.txt_RKKISO_19_SUM.MinimumWidth = 8
        Me.txt_RKKISO_19_SUM.Name = "txt_RKKISO_19_SUM"
        Me.txt_RKKISO_19_SUM.ReadOnly = True
        Me.txt_RKKISO_19_SUM.Width = 86
        '
        'txt_KMBOKA_20_SUM
        '
        Me.txt_KMBOKA_20_SUM.DataPropertyName = "KMBOKA_20_SUM"
        Me.txt_KMBOKA_20_SUM.HeaderText = "KMBOKA_20_SUM"
        Me.txt_KMBOKA_20_SUM.MinimumWidth = 8
        Me.txt_KMBOKA_20_SUM.Name = "txt_KMBOKA_20_SUM"
        Me.txt_KMBOKA_20_SUM.ReadOnly = True
        Me.txt_KMBOKA_20_SUM.Width = 86
        '
        'txt_ZSKYAK_26_SUM
        '
        Me.txt_ZSKYAK_26_SUM.DataPropertyName = "ZSKYAK_26_SUM"
        Me.txt_ZSKYAK_26_SUM.HeaderText = "ZSKYAK_26_SUM"
        Me.txt_ZSKYAK_26_SUM.MinimumWidth = 8
        Me.txt_ZSKYAK_26_SUM.Name = "txt_ZSKYAK_26_SUM"
        Me.txt_ZSKYAK_26_SUM.ReadOnly = True
        Me.txt_ZSKYAK_26_SUM.Width = 86
        '
        'txt_KSKYAK_31_SUM
        '
        Me.txt_KSKYAK_31_SUM.DataPropertyName = "KSKYAK_31_SUM"
        Me.txt_KSKYAK_31_SUM.HeaderText = "KSKYAK_31_SUM"
        Me.txt_KSKYAK_31_SUM.MinimumWidth = 8
        Me.txt_KSKYAK_31_SUM.Name = "txt_KSKYAK_31_SUM"
        Me.txt_KSKYAK_31_SUM.ReadOnly = True
        Me.txt_KSKYAK_31_SUM.Width = 86
        '
        'txt_SKYAKHS_32_SUM
        '
        Me.txt_SKYAKHS_32_SUM.DataPropertyName = "SKYAKHS_32_SUM"
        Me.txt_SKYAKHS_32_SUM.HeaderText = "SKYAKHS_32_SUM"
        Me.txt_SKYAKHS_32_SUM.MinimumWidth = 8
        Me.txt_SKYAKHS_32_SUM.Name = "txt_SKYAKHS_32_SUM"
        Me.txt_SKYAKHS_32_SUM.ReadOnly = True
        Me.txt_SKYAKHS_32_SUM.Width = 86
        '
        'txt_SKYAKTK_33_SUM
        '
        Me.txt_SKYAKTK_33_SUM.DataPropertyName = "SKYAKTK_33_SUM"
        Me.txt_SKYAKTK_33_SUM.HeaderText = "SKYAKTK_33_SUM"
        Me.txt_SKYAKTK_33_SUM.MinimumWidth = 8
        Me.txt_SKYAKTK_33_SUM.Name = "txt_SKYAKTK_33_SUM"
        Me.txt_SKYAKTK_33_SUM.ReadOnly = True
        Me.txt_SKYAKTK_33_SUM.Width = 86
        '
        'txt_ZENKKR_34_SUM
        '
        Me.txt_ZENKKR_34_SUM.DataPropertyName = "ZENKKR_34_SUM"
        Me.txt_ZENKKR_34_SUM.HeaderText = "ZENKKR_34_SUM"
        Me.txt_ZENKKR_34_SUM.MinimumWidth = 8
        Me.txt_ZENKKR_34_SUM.Name = "txt_ZENKKR_34_SUM"
        Me.txt_ZENKKR_34_SUM.ReadOnly = True
        Me.txt_ZENKKR_34_SUM.Width = 86
        '
        'txt_TSNYHS_35_SUM
        '
        Me.txt_TSNYHS_35_SUM.DataPropertyName = "TSNYHS_35_SUM"
        Me.txt_TSNYHS_35_SUM.HeaderText = "TSNYHS_35_SUM"
        Me.txt_TSNYHS_35_SUM.MinimumWidth = 8
        Me.txt_TSNYHS_35_SUM.Name = "txt_TSNYHS_35_SUM"
        Me.txt_TSNYHS_35_SUM.ReadOnly = True
        Me.txt_TSNYHS_35_SUM.Width = 86
        '
        'txt_YOKKURI_37_SUM
        '
        Me.txt_YOKKURI_37_SUM.DataPropertyName = "YOKKURI_37_SUM"
        Me.txt_YOKKURI_37_SUM.HeaderText = "YOKKURI_37_SUM"
        Me.txt_YOKKURI_37_SUM.MinimumWidth = 8
        Me.txt_YOKKURI_37_SUM.Name = "txt_YOKKURI_37_SUM"
        Me.txt_YOKKURI_37_SUM.ReadOnly = True
        Me.txt_YOKKURI_37_SUM.Width = 86
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
        Me.dgv_TOTAL.Location = New System.Drawing.Point(15, 728)
        Me.dgv_TOTAL.Name = "dgv_TOTAL"
        Me.dgv_TOTAL.ReadOnly = True
        Me.dgv_TOTAL.RowHeadersVisible = False
        Me.dgv_TOTAL.RowHeadersWidth = 62
        Me.dgv_TOTAL.RowTemplate.Height = 27
        Me.dgv_TOTAL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_TOTAL.Size = New System.Drawing.Size(1973, 102)
        Me.dgv_TOTAL.TabIndex = 12
        '
        'Form_f_flx_BEPPYO2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2000, 842)
        Me.Controls.Add(Me.dgv_TOTAL)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_BEPPYO2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "別表十六(四)"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_RECALCULATE As System.Windows.Forms.Button
    Friend WithEvents cmd_REF As System.Windows.Forms.Button
    Friend WithEvents cmd_PRINT_BEPPYO As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_CONDITION As Label
    Friend WithEvents dgv_TOTAL As DataGridView
    Friend WithEvents txt_KISYU_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_KIMAT_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKMK_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents txt_JKYAK_F_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_JKYAK_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_JNINYO As DataGridViewTextBoxColumn
    Friend WithEvents txt_JKYAK_BOKA As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYAKDT_04 As DataGridViewTextBoxColumn
    Friend WithEvents txt_KASHIDT_05 As DataGridViewTextBoxColumn
    Friend WithEvents txt_RKSYTK_17 As DataGridViewTextBoxColumn
    Friend WithEvents txt_RKZANK_18 As DataGridViewTextBoxColumn
    Friend WithEvents txt_RKKISO_19 As DataGridViewTextBoxColumn
    Friend WithEvents txt_KMBOKA_20 As DataGridViewTextBoxColumn
    Friend WithEvents txt_KIKAN_24 As DataGridViewTextBoxColumn
    Friend WithEvents txt_TKIKAN_25 As DataGridViewTextBoxColumn
    Friend WithEvents txt_ZSKYAK_26 As DataGridViewTextBoxColumn
    Friend WithEvents txt_KSKYAK_31 As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKYAKHS_32 As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKYAKTK_33 As DataGridViewTextBoxColumn
    Friend WithEvents txt_ZENKKR_34 As DataGridViewTextBoxColumn
    Friend WithEvents txt_TSNYHS_35 As DataGridViewTextBoxColumn
    Friend WithEvents txt_YOKKURI_37 As DataGridViewTextBoxColumn
    Friend WithEvents txt_JNINYO_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_JKYAK_BOKA_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_RKSYTK_17_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_RKZANK_18_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_RKKISO_19_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KMBOKA_20_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_ZSKYAK_26_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KSKYAK_31_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKYAKHS_32_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SKYAKTK_33_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_ZENKKR_34_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_TSNYHS_35_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_YOKKURI_37_SUM As DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
End Class