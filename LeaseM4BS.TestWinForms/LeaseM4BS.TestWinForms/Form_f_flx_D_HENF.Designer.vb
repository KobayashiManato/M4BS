<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_D_HENF

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
        Me.cmd_OUTPUT_FILE = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_CHANGE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LINE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KJKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_F_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_F_GSHA_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SHRI_CNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SHRI_KN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_SEIGOU_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SHRI_DT1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SHRI_EN_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_F_HKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SHHO_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KKNRI1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_CKAIYK_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_CHANGE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(2000, 119)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(811, 51)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 10
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(991, 43)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1335, 35)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(503, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(153, 45)
        Me.cmd_OUTPUT_FILE.TabIndex = 7
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(340, 13)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(153, 45)
        Me.cmd_REF.TabIndex = 2
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = True
        '
        'cmd_CHANGE
        '
        Me.cmd_CHANGE.Location = New System.Drawing.Point(177, 13)
        Me.cmd_CHANGE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CHANGE.Name = "cmd_CHANGE"
        Me.cmd_CHANGE.Size = New System.Drawing.Size(153, 45)
        Me.cmd_CHANGE.TabIndex = 1
        Me.cmd_CHANGE.TabStop = False
        Me.cmd_CHANGE.Text = "変更(&U)"
        Me.cmd_CHANGE.UseVisualStyleBackColor = True
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(10, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(157, 45)
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
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_KYKM_NO, Me.txt_LINE_ID, Me.txt_KJKBN_NM, Me.txt_BUKN_NM, Me.txt_F_LCPT1_NM, Me.txt_F_GSHA_NM, Me.txt_KYKH_ID, Me.txt_START_DT, Me.txt_SHRI_CNT, Me.txt_SHRI_KN, Me.txt_K_HISTORY_F, Me.txt_K_SEIGOU_F, Me.txt_KLSRYO, Me.txt_SHRI_DT1, Me.txt_SHRI_EN_DT, Me.txt_F_HKMK_NM, Me.txt_SHHO_NM, Me.txt_KKNRI1_NM, Me.txt_B_BCAT1_NM, Me.txt_KKBN_NM, Me.txt_K_LCPT1_NM, Me.txt_KYKBNL, Me.txt_SAIKAISU, Me.txt_K_START_DT, Me.txt_B_CKAIYK_F, Me.txt_ID})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 119)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(2000, 723)
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
        'txt_LINE_ID
        '
        Me.txt_LINE_ID.DataPropertyName = "LINE_ID"
        Me.txt_LINE_ID.HeaderText = "保守行No"
        Me.txt_LINE_ID.MinimumWidth = 8
        Me.txt_LINE_ID.Name = "txt_LINE_ID"
        Me.txt_LINE_ID.ReadOnly = True
        Me.txt_LINE_ID.Width = 60
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
        'txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "物件名"
        Me.txt_BUKN_NM.MinimumWidth = 8
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 75
        '
        'txt_F_LCPT1_NM
        '
        Me.txt_F_LCPT1_NM.DataPropertyName = "F_LCPT1_NM"
        Me.txt_F_LCPT1_NM.HeaderText = "保守支払先"
        Me.txt_F_LCPT1_NM.MinimumWidth = 8
        Me.txt_F_LCPT1_NM.Name = "txt_F_LCPT1_NM"
        Me.txt_F_LCPT1_NM.ReadOnly = True
        Me.txt_F_LCPT1_NM.Width = 75
        '
        'txt_F_GSHA_NM
        '
        Me.txt_F_GSHA_NM.DataPropertyName = "F_GSHA_NM"
        Me.txt_F_GSHA_NM.HeaderText = "保守契約先"
        Me.txt_F_GSHA_NM.MinimumWidth = 8
        Me.txt_F_GSHA_NM.Name = "txt_F_GSHA_NM"
        Me.txt_F_GSHA_NM.ReadOnly = True
        Me.txt_F_GSHA_NM.Width = 113
        '
        'txt_KYKH_ID
        '
        Me.txt_KYKH_ID.DataPropertyName = "KYKH_ID"
        Me.txt_KYKH_ID.HeaderText = "保守契約番号"
        Me.txt_KYKH_ID.MinimumWidth = 8
        Me.txt_KYKH_ID.Name = "txt_KYKH_ID"
        Me.txt_KYKH_ID.ReadOnly = True
        Me.txt_KYKH_ID.Width = 60
        '
        'txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "保守開始日"
        Me.txt_START_DT.MinimumWidth = 8
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 75
        '
        'txt_SHRI_CNT
        '
        Me.txt_SHRI_CNT.DataPropertyName = "SHRI_CNT"
        Me.txt_SHRI_CNT.HeaderText = "支払回数"
        Me.txt_SHRI_CNT.MinimumWidth = 8
        Me.txt_SHRI_CNT.Name = "txt_SHRI_CNT"
        Me.txt_SHRI_CNT.ReadOnly = True
        Me.txt_SHRI_CNT.Width = 60
        '
        'txt_SHRI_KN
        '
        Me.txt_SHRI_KN.DataPropertyName = "SHRI_KN"
        Me.txt_SHRI_KN.HeaderText = "支払間隔"
        Me.txt_SHRI_KN.MinimumWidth = 8
        Me.txt_SHRI_KN.Name = "txt_SHRI_KN"
        Me.txt_SHRI_KN.ReadOnly = True
        Me.txt_SHRI_KN.Width = 60
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
        'txt_K_SEIGOU_F
        '
        Me.txt_K_SEIGOU_F.DataPropertyName = "K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.HeaderText = "K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.MinimumWidth = 8
        Me.txt_K_SEIGOU_F.Name = "txt_K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.ReadOnly = True
        Me.txt_K_SEIGOU_F.Width = 60
        '
        'txt_KLSRYO
        '
        Me.txt_KLSRYO.DataPropertyName = "KLSRYO"
        Me.txt_KLSRYO.HeaderText = "1支払額"
        Me.txt_KLSRYO.MinimumWidth = 8
        Me.txt_KLSRYO.Name = "txt_KLSRYO"
        Me.txt_KLSRYO.ReadOnly = True
        Me.txt_KLSRYO.Width = 94
        '
        'txt_SHRI_DT1
        '
        Me.txt_SHRI_DT1.DataPropertyName = "SHRI_DT1"
        Me.txt_SHRI_DT1.HeaderText = "保守初回支払日"
        Me.txt_SHRI_DT1.MinimumWidth = 8
        Me.txt_SHRI_DT1.Name = "txt_SHRI_DT1"
        Me.txt_SHRI_DT1.ReadOnly = True
        Me.txt_SHRI_DT1.Width = 75
        '
        'txt_SHRI_EN_DT
        '
        Me.txt_SHRI_EN_DT.DataPropertyName = "SHRI_EN_DT"
        Me.txt_SHRI_EN_DT.HeaderText = "保守最終支払日"
        Me.txt_SHRI_EN_DT.MinimumWidth = 8
        Me.txt_SHRI_EN_DT.Name = "txt_SHRI_EN_DT"
        Me.txt_SHRI_EN_DT.ReadOnly = True
        Me.txt_SHRI_EN_DT.Width = 75
        '
        'txt_F_HKMK_NM
        '
        Me.txt_F_HKMK_NM.DataPropertyName = "F_HKMK_NM"
        Me.txt_F_HKMK_NM.HeaderText = "保守費用区分"
        Me.txt_F_HKMK_NM.MinimumWidth = 8
        Me.txt_F_HKMK_NM.Name = "txt_F_HKMK_NM"
        Me.txt_F_HKMK_NM.ReadOnly = True
        Me.txt_F_HKMK_NM.Width = 75
        '
        'txt_SHHO_NM
        '
        Me.txt_SHHO_NM.DataPropertyName = "SHHO_NM"
        Me.txt_SHHO_NM.HeaderText = "保守支払方法"
        Me.txt_SHHO_NM.MinimumWidth = 8
        Me.txt_SHHO_NM.Name = "txt_SHHO_NM"
        Me.txt_SHHO_NM.ReadOnly = True
        Me.txt_SHHO_NM.Width = 75
        '
        'txt_KKNRI1_NM
        '
        Me.txt_KKNRI1_NM.DataPropertyName = "KKNRI1_NM"
        Me.txt_KKNRI1_NM.HeaderText = "管理単位"
        Me.txt_KKNRI1_NM.MinimumWidth = 8
        Me.txt_KKNRI1_NM.Name = "txt_KKNRI1_NM"
        Me.txt_KKNRI1_NM.ReadOnly = True
        Me.txt_KKNRI1_NM.Width = 60
        '
        'txt_B_BCAT1_NM
        '
        Me.txt_B_BCAT1_NM.DataPropertyName = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.HeaderText = "管理部署"
        Me.txt_B_BCAT1_NM.MinimumWidth = 8
        Me.txt_B_BCAT1_NM.Name = "txt_B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.ReadOnly = True
        Me.txt_B_BCAT1_NM.Width = 75
        '
        'txt_KKBN_NM
        '
        Me.txt_KKBN_NM.DataPropertyName = "KKBN_NM"
        Me.txt_KKBN_NM.HeaderText = "契約区分"
        Me.txt_KKBN_NM.MinimumWidth = 8
        Me.txt_KKBN_NM.Name = "txt_KKBN_NM"
        Me.txt_KKBN_NM.ReadOnly = True
        Me.txt_KKBN_NM.Width = 60
        '
        'txt_K_LCPT1_NM
        '
        Me.txt_K_LCPT1_NM.DataPropertyName = "K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.HeaderText = "支払先(ﾘｰｽ会社)"
        Me.txt_K_LCPT1_NM.MinimumWidth = 8
        Me.txt_K_LCPT1_NM.Name = "txt_K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.ReadOnly = True
        Me.txt_K_LCPT1_NM.Width = 113
        '
        'txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "ﾘｰｽ契約番号"
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
        'txt_K_START_DT
        '
        Me.txt_K_START_DT.DataPropertyName = "K_START_DT"
        Me.txt_K_START_DT.HeaderText = "ﾘｰｽ開始日"
        Me.txt_K_START_DT.MinimumWidth = 8
        Me.txt_K_START_DT.Name = "txt_K_START_DT"
        Me.txt_K_START_DT.ReadOnly = True
        Me.txt_K_START_DT.Width = 75
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
        'Form_f_flx_D_HENF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2000, 842)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_D_HENF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "保守フレックス（物件付随保守料）"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_CHANGE As System.Windows.Forms.Button
    Friend WithEvents cmd_REF As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents txt_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents txt_LINE_ID As DataGridViewTextBoxColumn
    Friend WithEvents txt_KJKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_F_LCPT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_F_GSHA_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKH_ID As DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_SHRI_CNT As DataGridViewTextBoxColumn
    Friend WithEvents txt_SHRI_KN As DataGridViewTextBoxColumn
    Friend WithEvents txt_K_HISTORY_F As DataGridViewTextBoxColumn
    Friend WithEvents txt_K_SEIGOU_F As DataGridViewTextBoxColumn
    Friend WithEvents txt_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents txt_SHRI_DT1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_SHRI_EN_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_F_HKMK_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_SHHO_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KKNRI1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KKBN_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_K_LCPT1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents txt_SAIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents txt_K_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_B_CKAIYK_F As DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
End Class