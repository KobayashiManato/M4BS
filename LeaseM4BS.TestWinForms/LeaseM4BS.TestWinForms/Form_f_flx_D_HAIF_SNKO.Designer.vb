<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_D_HAIF_SNKO

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
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_変更 = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.cmd_照会 = New System.Windows.Forms.Button()
        Me.cmd_再表示 = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LINE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_BANGO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KKNRI1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_H_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_H_HKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RSRVH1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_HAIFRITU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_H_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_H_MLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_SEIGOU_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BKIND_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_CKAIYK_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CHU_HNTI_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LEAKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CHUUM_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_H_ZOKUSEI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_SEIGOU_F_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.cmd_再表示)
        Me.pnlHeader.Controls.Add(Me.cmd_照会)
        Me.pnlHeader.Controls.Add(Me.cmd_Output)
        Me.pnlHeader.Controls.Add(Me.cmd_変更)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexReportDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexSortDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexSearchDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_閉じる)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 40)
        Me.pnlHeader.TabIndex = 0
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(4, 4)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(104, 30)
        Me.cmd_閉じる.TabIndex = 0
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSearchDLG
        '
        Me.cmd_FlexSearchDLG.Location = New System.Drawing.Point(116, 4)
        Me.cmd_FlexSearchDLG.Name = "cmd_FlexSearchDLG"
        Me.cmd_FlexSearchDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexSearchDLG.TabIndex = 1
        Me.cmd_FlexSearchDLG.Text = "検索(&S)"
        Me.cmd_FlexSearchDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSortDLG
        '
        Me.cmd_FlexSortDLG.Location = New System.Drawing.Point(216, 4)
        Me.cmd_FlexSortDLG.Name = "cmd_FlexSortDLG"
        Me.cmd_FlexSortDLG.Size = New System.Drawing.Size(116, 30)
        Me.cmd_FlexSortDLG.TabIndex = 2
        Me.cmd_FlexSortDLG.Text = "並べ替え(&O)"
        Me.cmd_FlexSortDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(340, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexReportDLG.TabIndex = 3
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        ' cmd_変更
        '
        Me.cmd_変更.Location = New System.Drawing.Point(440, 4)
        Me.cmd_変更.Name = "cmd_変更"
        Me.cmd_変更.Size = New System.Drawing.Size(92, 30)
        Me.cmd_変更.TabIndex = 4
        Me.cmd_変更.Text = "変更(&U)"
        Me.cmd_変更.UseVisualStyleBackColor = True
        '
        ' cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(540, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Output.TabIndex = 5
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        ' cmd_照会
        '
        Me.cmd_照会.Location = New System.Drawing.Point(688, 4)
        Me.cmd_照会.Name = "cmd_照会"
        Me.cmd_照会.Size = New System.Drawing.Size(92, 30)
        Me.cmd_照会.TabIndex = 6
        Me.cmd_照会.Text = "照会(&M)"
        Me.cmd_照会.UseVisualStyleBackColor = True
        '
        ' cmd_再表示
        '
        Me.cmd_再表示.Location = New System.Drawing.Point(788, 4)
        Me.cmd_再表示.Name = "cmd_再表示"
        Me.cmd_再表示.Size = New System.Drawing.Size(104, 30)
        Me.cmd_再表示.TabIndex = 7
        Me.cmd_再表示.Text = "再表示(&L)"
        Me.cmd_再表示.UseVisualStyleBackColor = True
        '
        ' dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.txt_KYKM_NO, Me.txt_LINE_ID, Me.txt_SAIKAISU, Me.txt_BUKN_BANGO1, Me.txt_K_LCPT1_NM, Me.txt_KYKBNL, Me.txt_BUKN_NM, Me.txt_KKNRI1_NM, Me.txt_B_BCAT1_NM, Me.txt_H_BCAT1_NM, Me.txt_H_HKMK_NM, Me.txt_RSRVH1_NM, Me.txt_START_DT, Me.txt_K_HISTORY_F, Me.txt_CKAIYK_DT, Me.txt_HAIFRITU, Me.txt_H_KLSRYO, Me.txt_H_MLSRYO, Me.txt_K_SEIGOU_F, Me.txt_SKMK_NM, Me.txt_BKIND_NM, Me.txt_KYKH_ID, Me.txt_B_CKAIYK_F, Me.txt_CHU_HNTI_NM, Me.txt_LEAKBN_NM, Me.txt_CHUUM_NM, Me.txt_H_ZOKUSEI1, Me.txt_K_SEIGOU_F_NM, Me.txt_ID})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 40)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowTemplate.Height = 21
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(1200, 521)
        Me.dgvMain.TabIndex = 8
        '
        ' txt_KYKM_NO
        '
        Me.txt_KYKM_NO.DataPropertyName = "KYKM_NO"
        Me.txt_KYKM_NO.HeaderText = "KYKM_NO"
        Me.txt_KYKM_NO.Name = "txt_KYKM_NO"
        Me.txt_KYKM_NO.ReadOnly = True
        Me.txt_KYKM_NO.Width = 60
        '
        ' txt_LINE_ID
        '
        Me.txt_LINE_ID.DataPropertyName = "LINE_ID"
        Me.txt_LINE_ID.HeaderText = "LINE_ID"
        Me.txt_LINE_ID.Name = "txt_LINE_ID"
        Me.txt_LINE_ID.ReadOnly = True
        Me.txt_LINE_ID.Width = 60
        '
        ' txt_SAIKAISU
        '
        Me.txt_SAIKAISU.DataPropertyName = "SAIKAISU"
        Me.txt_SAIKAISU.HeaderText = "SAIKAISU"
        Me.txt_SAIKAISU.Name = "txt_SAIKAISU"
        Me.txt_SAIKAISU.ReadOnly = True
        Me.txt_SAIKAISU.Width = 60
        '
        ' txt_BUKN_BANGO1
        '
        Me.txt_BUKN_BANGO1.DataPropertyName = "BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.HeaderText = "BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.Name = "txt_BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.ReadOnly = True
        Me.txt_BUKN_BANGO1.Width = 75
        '
        ' txt_K_LCPT1_NM
        '
        Me.txt_K_LCPT1_NM.DataPropertyName = "K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.HeaderText = "K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.Name = "txt_K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.ReadOnly = True
        Me.txt_K_LCPT1_NM.Width = 75
        '
        ' txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "KYKBNL"
        Me.txt_KYKBNL.Name = "txt_KYKBNL"
        Me.txt_KYKBNL.ReadOnly = True
        Me.txt_KYKBNL.Width = 75
        '
        ' txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "BUKN_NM"
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 75
        '
        ' txt_KKNRI1_NM
        '
        Me.txt_KKNRI1_NM.DataPropertyName = "KKNRI1_NM"
        Me.txt_KKNRI1_NM.HeaderText = "KKNRI1_NM"
        Me.txt_KKNRI1_NM.Name = "txt_KKNRI1_NM"
        Me.txt_KKNRI1_NM.ReadOnly = True
        Me.txt_KKNRI1_NM.Width = 60
        '
        ' txt_B_BCAT1_NM
        '
        Me.txt_B_BCAT1_NM.DataPropertyName = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.HeaderText = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.Name = "txt_B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.ReadOnly = True
        Me.txt_B_BCAT1_NM.Width = 113
        '
        ' txt_H_BCAT1_NM
        '
        Me.txt_H_BCAT1_NM.DataPropertyName = "H_BCAT1_NM"
        Me.txt_H_BCAT1_NM.HeaderText = "H_BCAT1_NM"
        Me.txt_H_BCAT1_NM.Name = "txt_H_BCAT1_NM"
        Me.txt_H_BCAT1_NM.ReadOnly = True
        Me.txt_H_BCAT1_NM.Width = 75
        '
        ' txt_H_HKMK_NM
        '
        Me.txt_H_HKMK_NM.DataPropertyName = "H_HKMK_NM"
        Me.txt_H_HKMK_NM.HeaderText = "H_HKMK_NM"
        Me.txt_H_HKMK_NM.Name = "txt_H_HKMK_NM"
        Me.txt_H_HKMK_NM.ReadOnly = True
        Me.txt_H_HKMK_NM.Width = 75
        '
        ' txt_RSRVH1_NM
        '
        Me.txt_RSRVH1_NM.DataPropertyName = "RSRVH1_NM"
        Me.txt_RSRVH1_NM.HeaderText = "RSRVH1_NM"
        Me.txt_RSRVH1_NM.Name = "txt_RSRVH1_NM"
        Me.txt_RSRVH1_NM.ReadOnly = True
        Me.txt_RSRVH1_NM.Width = 75
        '
        ' txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "START_DT"
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 75
        '
        ' txt_K_HISTORY_F
        '
        Me.txt_K_HISTORY_F.DataPropertyName = "K_HISTORY_F"
        Me.txt_K_HISTORY_F.HeaderText = "K_HISTORY_F"
        Me.txt_K_HISTORY_F.Name = "txt_K_HISTORY_F"
        Me.txt_K_HISTORY_F.ReadOnly = True
        Me.txt_K_HISTORY_F.Width = 60
        '
        ' txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.HeaderText = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Width = 75
        '
        ' txt_HAIFRITU
        '
        Me.txt_HAIFRITU.DataPropertyName = "HAIFRITU"
        Me.txt_HAIFRITU.HeaderText = "HAIFRITU"
        Me.txt_HAIFRITU.Name = "txt_HAIFRITU"
        Me.txt_HAIFRITU.ReadOnly = True
        Me.txt_HAIFRITU.Width = 60
        '
        ' txt_H_KLSRYO
        '
        Me.txt_H_KLSRYO.DataPropertyName = "H_KLSRYO"
        Me.txt_H_KLSRYO.HeaderText = "H_KLSRYO"
        Me.txt_H_KLSRYO.Name = "txt_H_KLSRYO"
        Me.txt_H_KLSRYO.ReadOnly = True
        Me.txt_H_KLSRYO.Width = 94
        '
        ' txt_H_MLSRYO
        '
        Me.txt_H_MLSRYO.DataPropertyName = "H_MLSRYO"
        Me.txt_H_MLSRYO.HeaderText = "H_MLSRYO"
        Me.txt_H_MLSRYO.Name = "txt_H_MLSRYO"
        Me.txt_H_MLSRYO.ReadOnly = True
        Me.txt_H_MLSRYO.Width = 94
        '
        ' txt_K_SEIGOU_F
        '
        Me.txt_K_SEIGOU_F.DataPropertyName = "K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.HeaderText = "K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.Name = "txt_K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.ReadOnly = True
        Me.txt_K_SEIGOU_F.Width = 60
        '
        ' txt_SKMK_NM
        '
        Me.txt_SKMK_NM.DataPropertyName = "SKMK_NM"
        Me.txt_SKMK_NM.HeaderText = "SKMK_NM"
        Me.txt_SKMK_NM.Name = "txt_SKMK_NM"
        Me.txt_SKMK_NM.ReadOnly = True
        Me.txt_SKMK_NM.Width = 75
        '
        ' txt_BKIND_NM
        '
        Me.txt_BKIND_NM.DataPropertyName = "BKIND_NM"
        Me.txt_BKIND_NM.HeaderText = "BKIND_NM"
        Me.txt_BKIND_NM.Name = "txt_BKIND_NM"
        Me.txt_BKIND_NM.ReadOnly = True
        Me.txt_BKIND_NM.Width = 75
        '
        ' txt_KYKH_ID
        '
        Me.txt_KYKH_ID.DataPropertyName = "KYKH_ID"
        Me.txt_KYKH_ID.HeaderText = "KYKH_ID"
        Me.txt_KYKH_ID.Name = "txt_KYKH_ID"
        Me.txt_KYKH_ID.ReadOnly = True
        Me.txt_KYKH_ID.Width = 60
        '
        ' txt_B_CKAIYK_F
        '
        Me.txt_B_CKAIYK_F.DataPropertyName = "B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.HeaderText = "B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.Name = "txt_B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.ReadOnly = True
        Me.txt_B_CKAIYK_F.Width = 60
        '
        ' txt_CHU_HNTI_NM
        '
        Me.txt_CHU_HNTI_NM.DataPropertyName = "CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.HeaderText = "CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.Name = "txt_CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.ReadOnly = True
        Me.txt_CHU_HNTI_NM.Width = 113
        '
        ' txt_LEAKBN_NM
        '
        Me.txt_LEAKBN_NM.DataPropertyName = "LEAKBN_NM"
        Me.txt_LEAKBN_NM.HeaderText = "LEAKBN_NM"
        Me.txt_LEAKBN_NM.Name = "txt_LEAKBN_NM"
        Me.txt_LEAKBN_NM.ReadOnly = True
        Me.txt_LEAKBN_NM.Width = 75
        '
        ' txt_CHUUM_NM
        '
        Me.txt_CHUUM_NM.DataPropertyName = "CHUUM_NM"
        Me.txt_CHUUM_NM.HeaderText = "CHUUM_NM"
        Me.txt_CHUUM_NM.Name = "txt_CHUUM_NM"
        Me.txt_CHUUM_NM.ReadOnly = True
        Me.txt_CHUUM_NM.Width = 60
        '
        ' txt_H_ZOKUSEI1
        '
        Me.txt_H_ZOKUSEI1.DataPropertyName = "H_ZOKUSEI1"
        Me.txt_H_ZOKUSEI1.HeaderText = "H_ZOKUSEI1"
        Me.txt_H_ZOKUSEI1.Name = "txt_H_ZOKUSEI1"
        Me.txt_H_ZOKUSEI1.ReadOnly = True
        Me.txt_H_ZOKUSEI1.Width = 75
        '
        ' txt_K_SEIGOU_F_NM
        '
        Me.txt_K_SEIGOU_F_NM.DataPropertyName = "K_SEIGOU_F_NM"
        Me.txt_K_SEIGOU_F_NM.HeaderText = "K_SEIGOU_F_NM"
        Me.txt_K_SEIGOU_F_NM.Name = "txt_K_SEIGOU_F_NM"
        Me.txt_K_SEIGOU_F_NM.ReadOnly = True
        Me.txt_K_SEIGOU_F_NM.Width = 60
        '
        ' txt_ID
        '
        Me.txt_ID.DataPropertyName = "ID"
        Me.txt_ID.HeaderText = "ID"
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Visible = False
        '
        ' Form_f_flx_D_HAIF_SNKO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_D_HAIF_SNKO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "物件フレックス（配賦行単位）"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents cmd_照会 As System.Windows.Forms.Button
    Friend WithEvents cmd_再表示 As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_KYKM_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LINE_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SAIKAISU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_BANGO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_LCPT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KKNRI1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_H_BCAT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_H_HKMK_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_RSRVH1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_HISTORY_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CKAIYK_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_HAIFRITU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_H_KLSRYO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_H_MLSRYO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_SEIGOU_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SKMK_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BKIND_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKH_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_CKAIYK_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CHU_HNTI_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LEAKBN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CHUUM_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_H_ZOKUSEI1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_SEIGOU_F_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class