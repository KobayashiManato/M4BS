<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_TANA

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
        Me.lbl_TANA_DATE = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.cmd_OUTPUT_FILE = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_BANGO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_BANGO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_BANGO3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LKIKAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_KNYUKN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_SLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_HENF_KLSRYO_NEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_ZOKUSEI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lbl_TANA_DATE)
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Controls.Add(Me.txt_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexReportDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_RECALCULATE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2000, 132)
        Me.pnlHeader.TabIndex = 0
        '
        'lbl_TANA_DATE
        '
        Me.lbl_TANA_DATE.AutoSize = True
        Me.lbl_TANA_DATE.Location = New System.Drawing.Point(32, 91)
        Me.lbl_TANA_DATE.Name = "lbl_TANA_DATE"
        Me.lbl_TANA_DATE.Size = New System.Drawing.Size(66, 18)
        Me.lbl_TANA_DATE.TabIndex = 13
        Me.lbl_TANA_DATE.Text = "棚卸日:"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(994, 52)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 12
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1174, 44)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1518, 36)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(563, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_OUTPUT_FILE.TabIndex = 5
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(380, 13)
        Me.cmd_FlexReportDLG.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(173, 45)
        Me.cmd_FlexReportDLG.TabIndex = 4
        Me.cmd_FlexReportDLG.TabStop = False
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
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
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_KYKM_NO, Me.col_BUKN_BANGO1, Me.col_BUKN_BANGO2, Me.col_BUKN_BANGO3, Me.col_BUKN_NM, Me.col_B_BCAT1_NM, Me.col_LCPT1_NM, Me.col_KYKBNL, Me.col_SAIKAISU, Me.col_START_DT, Me.col_LKIKAN, Me.col_CKAIYK_DT, Me.col_B_KNYUKN, Me.col_B_KLSRYO, Me.col_B_SLSRYO, Me.col_B_HENF_KLSRYO_NEW, Me.col_B_ZOKUSEI1})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 132)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(2000, 710)
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
        'col_BUKN_BANGO1
        '
        Me.col_BUKN_BANGO1.DataPropertyName = "BUKN_BANGO1"
        Me.col_BUKN_BANGO1.HeaderText = "資産番号1"
        Me.col_BUKN_BANGO1.MinimumWidth = 8
        Me.col_BUKN_BANGO1.Name = "col_BUKN_BANGO1"
        Me.col_BUKN_BANGO1.ReadOnly = True
        Me.col_BUKN_BANGO1.Width = 75
        '
        'col_BUKN_BANGO2
        '
        Me.col_BUKN_BANGO2.DataPropertyName = "BUKN_BANGO2"
        Me.col_BUKN_BANGO2.HeaderText = "資産番号2"
        Me.col_BUKN_BANGO2.MinimumWidth = 8
        Me.col_BUKN_BANGO2.Name = "col_BUKN_BANGO2"
        Me.col_BUKN_BANGO2.ReadOnly = True
        Me.col_BUKN_BANGO2.Width = 75
        '
        'col_BUKN_BANGO3
        '
        Me.col_BUKN_BANGO3.DataPropertyName = "BUKN_BANGO3"
        Me.col_BUKN_BANGO3.HeaderText = "資産番号3"
        Me.col_BUKN_BANGO3.MinimumWidth = 8
        Me.col_BUKN_BANGO3.Name = "col_BUKN_BANGO3"
        Me.col_BUKN_BANGO3.ReadOnly = True
        Me.col_BUKN_BANGO3.Width = 75
        '
        'col_BUKN_NM
        '
        Me.col_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.col_BUKN_NM.HeaderText = "物件名"
        Me.col_BUKN_NM.MinimumWidth = 8
        Me.col_BUKN_NM.Name = "col_BUKN_NM"
        Me.col_BUKN_NM.ReadOnly = True
        Me.col_BUKN_NM.Width = 113
        '
        'col_B_BCAT1_NM
        '
        Me.col_B_BCAT1_NM.DataPropertyName = "B_BCAT1_NM"
        Me.col_B_BCAT1_NM.HeaderText = "管理部署"
        Me.col_B_BCAT1_NM.MinimumWidth = 8
        Me.col_B_BCAT1_NM.Name = "col_B_BCAT1_NM"
        Me.col_B_BCAT1_NM.ReadOnly = True
        Me.col_B_BCAT1_NM.Width = 75
        '
        'col_LCPT1_NM
        '
        Me.col_LCPT1_NM.DataPropertyName = "K_LCPT1_NM"
        Me.col_LCPT1_NM.HeaderText = "支払先"
        Me.col_LCPT1_NM.MinimumWidth = 8
        Me.col_LCPT1_NM.Name = "col_LCPT1_NM"
        Me.col_LCPT1_NM.ReadOnly = True
        Me.col_LCPT1_NM.Width = 75
        '
        'col_KYKBNL
        '
        Me.col_KYKBNL.DataPropertyName = "KYKBNL"
        Me.col_KYKBNL.HeaderText = "契約番号"
        Me.col_KYKBNL.MinimumWidth = 8
        Me.col_KYKBNL.Name = "col_KYKBNL"
        Me.col_KYKBNL.ReadOnly = True
        Me.col_KYKBNL.Width = 75
        '
        'col_SAIKAISU
        '
        Me.col_SAIKAISU.DataPropertyName = "SAIKAISU"
        Me.col_SAIKAISU.HeaderText = "再ﾘｰｽ回数"
        Me.col_SAIKAISU.MinimumWidth = 8
        Me.col_SAIKAISU.Name = "col_SAIKAISU"
        Me.col_SAIKAISU.ReadOnly = True
        Me.col_SAIKAISU.Width = 60
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
        'col_LKIKAN
        '
        Me.col_LKIKAN.DataPropertyName = "LKIKAN"
        Me.col_LKIKAN.HeaderText = "契約期間"
        Me.col_LKIKAN.MinimumWidth = 8
        Me.col_LKIKAN.Name = "col_LKIKAN"
        Me.col_LKIKAN.ReadOnly = True
        Me.col_LKIKAN.Width = 60
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
        'col_B_KNYUKN
        '
        Me.col_B_KNYUKN.DataPropertyName = "B_KNYUKN"
        Me.col_B_KNYUKN.HeaderText = "現金購入価額"
        Me.col_B_KNYUKN.MinimumWidth = 8
        Me.col_B_KNYUKN.Name = "col_B_KNYUKN"
        Me.col_B_KNYUKN.ReadOnly = True
        Me.col_B_KNYUKN.Width = 94
        '
        'col_B_KLSRYO
        '
        Me.col_B_KLSRYO.DataPropertyName = "B_KLSRYO"
        Me.col_B_KLSRYO.HeaderText = "1支払額"
        Me.col_B_KLSRYO.MinimumWidth = 8
        Me.col_B_KLSRYO.Name = "col_B_KLSRYO"
        Me.col_B_KLSRYO.ReadOnly = True
        Me.col_B_KLSRYO.Width = 94
        '
        'col_B_SLSRYO
        '
        Me.col_B_SLSRYO.DataPropertyName = "B_SLSRYO"
        Me.col_B_SLSRYO.HeaderText = "総額ﾘｰｽ料"
        Me.col_B_SLSRYO.MinimumWidth = 8
        Me.col_B_SLSRYO.Name = "col_B_SLSRYO"
        Me.col_B_SLSRYO.ReadOnly = True
        Me.col_B_SLSRYO.Width = 94
        '
        'col_B_HENF_KLSRYO_NEW
        '
        Me.col_B_HENF_KLSRYO_NEW.DataPropertyName = "B_HENF_KLSRYO_NEW"
        Me.col_B_HENF_KLSRYO_NEW.HeaderText = "保守料"
        Me.col_B_HENF_KLSRYO_NEW.MinimumWidth = 8
        Me.col_B_HENF_KLSRYO_NEW.Name = "col_B_HENF_KLSRYO_NEW"
        Me.col_B_HENF_KLSRYO_NEW.ReadOnly = True
        Me.col_B_HENF_KLSRYO_NEW.Width = 94
        '
        'col_B_ZOKUSEI1
        '
        Me.col_B_ZOKUSEI1.DataPropertyName = "B_ZOKUSEI1"
        Me.col_B_ZOKUSEI1.HeaderText = "備考"
        Me.col_B_ZOKUSEI1.MinimumWidth = 8
        Me.col_B_ZOKUSEI1.Name = "col_B_ZOKUSEI1"
        Me.col_B_ZOKUSEI1.ReadOnly = True
        Me.col_B_ZOKUSEI1.Width = 75
        '
        'Form_f_flx_TANA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2000, 842)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_TANA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "棚卸明細表"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_RECALCULATE As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents col_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_BANGO1 As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_BANGO2 As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_BANGO3 As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_B_BCAT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_LCPT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents col_SAIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents col_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_LKIKAN As DataGridViewTextBoxColumn
    Friend WithEvents col_CKAIYK_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_B_KNYUKN As DataGridViewTextBoxColumn
    Friend WithEvents col_B_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_B_SLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_B_HENF_KLSRYO_NEW As DataGridViewTextBoxColumn
    Friend WithEvents col_B_ZOKUSEI1 As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
    Friend WithEvents lbl_TANA_DATE As Label
End Class