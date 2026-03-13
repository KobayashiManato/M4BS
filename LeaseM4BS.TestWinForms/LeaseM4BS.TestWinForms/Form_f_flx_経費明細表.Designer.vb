<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_経費明細表

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
        Me.cmd_設定 = New System.Windows.Forms.Button()
        Me.cmd_照会 = New System.Windows.Forms.Button()
        Me.cmd_仕訳 = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_JOKEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LINE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_REC_KBN_STR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_H_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_HKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_KJYO_ST_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KJYO_EN_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_TOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAE_ZZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_ZZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_TOKI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAE_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KAIYAK_MAE_ZAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KAIYAK_KEIHI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG02 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG03 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG04 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG05 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG06 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG07 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG08 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG09 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_TOTAL_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAE_ZZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_ZZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_TOKI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_MAE_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LSRYO_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KAIYAK_MAE_ZAN_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KAIYAK_KEIHI_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG01_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG02_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG03_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG04_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG05_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG06_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG07_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG08_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG09_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG10_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG11_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KEIHI_TOKIG12_SUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.cmd_Output)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexReportDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexSortDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexSearchDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_仕訳)
        Me.pnlHeader.Controls.Add(Me.cmd_照会)
        Me.pnlHeader.Controls.Add(Me.cmd_設定)
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
        ' cmd_設定
        '
        Me.cmd_設定.Location = New System.Drawing.Point(116, 4)
        Me.cmd_設定.Name = "cmd_設定"
        Me.cmd_設定.Size = New System.Drawing.Size(92, 30)
        Me.cmd_設定.TabIndex = 1
        Me.cmd_設定.Text = "設定(&D)"
        Me.cmd_設定.UseVisualStyleBackColor = True
        '
        ' cmd_照会
        '
        Me.cmd_照会.Location = New System.Drawing.Point(216, 4)
        Me.cmd_照会.Name = "cmd_照会"
        Me.cmd_照会.Size = New System.Drawing.Size(92, 30)
        Me.cmd_照会.TabIndex = 2
        Me.cmd_照会.Text = "照会(&M)"
        Me.cmd_照会.UseVisualStyleBackColor = True
        '
        ' cmd_仕訳
        '
        Me.cmd_仕訳.Location = New System.Drawing.Point(316, 4)
        Me.cmd_仕訳.Name = "cmd_仕訳"
        Me.cmd_仕訳.Size = New System.Drawing.Size(116, 30)
        Me.cmd_仕訳.TabIndex = 3
        Me.cmd_仕訳.Text = "仕訳出力(&F)"
        Me.cmd_仕訳.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSearchDLG
        '
        Me.cmd_FlexSearchDLG.Location = New System.Drawing.Point(440, 4)
        Me.cmd_FlexSearchDLG.Name = "cmd_FlexSearchDLG"
        Me.cmd_FlexSearchDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexSearchDLG.TabIndex = 4
        Me.cmd_FlexSearchDLG.Text = "検索(&S)"
        Me.cmd_FlexSearchDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSortDLG
        '
        Me.cmd_FlexSortDLG.Location = New System.Drawing.Point(540, 4)
        Me.cmd_FlexSortDLG.Name = "cmd_FlexSortDLG"
        Me.cmd_FlexSortDLG.Size = New System.Drawing.Size(116, 30)
        Me.cmd_FlexSortDLG.TabIndex = 5
        Me.cmd_FlexSortDLG.Text = "並べ替え(&O)"
        Me.cmd_FlexSortDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(664, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexReportDLG.TabIndex = 6
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        ' cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(764, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Output.TabIndex = 7
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        ' dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.txt_JOKEN, Me.txt_KYKM_NO, Me.txt_SAIKAISU, Me.txt_LINE_ID, Me.txt_KKBN_NM, Me.txt_REC_KBN_STR, Me.txt_BUKN_NM, Me.txt_START_DT, Me.txt_CKAIYK_DT, Me.txt_KYKBNL, Me.txt_LCPT1_NM, Me.txt_B_BCAT_NM, Me.txt_H_BCAT_NM, Me.txt_HKMK_NM, Me.txt_K_KJYO_ST_DT, Me.txt_B_KJYO_EN_DT, Me.txt_LSRYO_TOTAL, Me.txt_MAE_ZZAN, Me.txt_LSRYO_ZZAN, Me.txt_KEIHI_TOKI, Me.txt_LSRYO_TOKI, Me.txt_MAE_ZAN, Me.txt_LSRYO_ZAN, Me.txt_KAIYAK_MAE_ZAN, Me.txt_KAIYAK_KEIHI, Me.txt_KEIHI_TOKIG01, Me.txt_KEIHI_TOKIG02, Me.txt_KEIHI_TOKIG03, Me.txt_KEIHI_TOKIG04, Me.txt_KEIHI_TOKIG05, Me.txt_KEIHI_TOKIG06, Me.txt_KEIHI_TOKIG07, Me.txt_KEIHI_TOKIG08, Me.txt_KEIHI_TOKIG09, Me.txt_KEIHI_TOKIG10, Me.txt_KEIHI_TOKIG11, Me.txt_KEIHI_TOKIG12, Me.txt_LSRYO_TOTAL_SUM, Me.txt_MAE_ZZAN_SUM, Me.txt_LSRYO_ZZAN_SUM, Me.txt_KEIHI_TOKI_SUM, Me.txt_LSRYO_TOKI_SUM, Me.txt_MAE_ZAN_SUM, Me.txt_LSRYO_ZAN_SUM, Me.txt_KAIYAK_MAE_ZAN_SUM, Me.txt_KAIYAK_KEIHI_SUM, Me.txt_KEIHI_TOKIG01_SUM, Me.txt_KEIHI_TOKIG02_SUM, Me.txt_KEIHI_TOKIG03_SUM, Me.txt_KEIHI_TOKIG04_SUM, Me.txt_KEIHI_TOKIG05_SUM, Me.txt_KEIHI_TOKIG06_SUM, Me.txt_KEIHI_TOKIG07_SUM, Me.txt_KEIHI_TOKIG08_SUM, Me.txt_KEIHI_TOKIG09_SUM, Me.txt_KEIHI_TOKIG10_SUM, Me.txt_KEIHI_TOKIG11_SUM, Me.txt_KEIHI_TOKIG12_SUM, Me.txt_ID})
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
        ' txt_JOKEN
        '
        Me.txt_JOKEN.DataPropertyName = "JOKEN"
        Me.txt_JOKEN.HeaderText = "JOKEN"
        Me.txt_JOKEN.Name = "txt_JOKEN"
        Me.txt_JOKEN.ReadOnly = True
        Me.txt_JOKEN.Width = 200
        '
        ' txt_KYKM_NO
        '
        Me.txt_KYKM_NO.DataPropertyName = "KYKM_NO"
        Me.txt_KYKM_NO.HeaderText = "KYKM_NO"
        Me.txt_KYKM_NO.Name = "txt_KYKM_NO"
        Me.txt_KYKM_NO.ReadOnly = True
        Me.txt_KYKM_NO.Width = 60
        '
        ' txt_SAIKAISU
        '
        Me.txt_SAIKAISU.DataPropertyName = "SAIKAISU"
        Me.txt_SAIKAISU.HeaderText = "SAIKAISU"
        Me.txt_SAIKAISU.Name = "txt_SAIKAISU"
        Me.txt_SAIKAISU.ReadOnly = True
        Me.txt_SAIKAISU.Width = 60
        '
        ' txt_LINE_ID
        '
        Me.txt_LINE_ID.DataPropertyName = "LINE_ID"
        Me.txt_LINE_ID.HeaderText = "LINE_ID"
        Me.txt_LINE_ID.Name = "txt_LINE_ID"
        Me.txt_LINE_ID.ReadOnly = True
        Me.txt_LINE_ID.Width = 60
        '
        ' txt_KKBN_NM
        '
        Me.txt_KKBN_NM.DataPropertyName = "KKBN_NM"
        Me.txt_KKBN_NM.HeaderText = "KKBN_NM"
        Me.txt_KKBN_NM.Name = "txt_KKBN_NM"
        Me.txt_KKBN_NM.ReadOnly = True
        Me.txt_KKBN_NM.Width = 60
        '
        ' txt_REC_KBN_STR
        '
        Me.txt_REC_KBN_STR.DataPropertyName = "REC_KBN_STR"
        Me.txt_REC_KBN_STR.HeaderText = "REC_KBN_STR"
        Me.txt_REC_KBN_STR.Name = "txt_REC_KBN_STR"
        Me.txt_REC_KBN_STR.ReadOnly = True
        Me.txt_REC_KBN_STR.Width = 60
        '
        ' txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "BUKN_NM"
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 75
        '
        ' txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "START_DT"
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 68
        '
        ' txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.HeaderText = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Width = 68
        '
        ' txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "KYKBNL"
        Me.txt_KYKBNL.Name = "txt_KYKBNL"
        Me.txt_KYKBNL.ReadOnly = True
        Me.txt_KYKBNL.Width = 75
        '
        ' txt_LCPT1_NM
        '
        Me.txt_LCPT1_NM.DataPropertyName = "LCPT1_NM"
        Me.txt_LCPT1_NM.HeaderText = "LCPT1_NM"
        Me.txt_LCPT1_NM.Name = "txt_LCPT1_NM"
        Me.txt_LCPT1_NM.ReadOnly = True
        Me.txt_LCPT1_NM.Width = 94
        '
        ' txt_B_BCAT_NM
        '
        Me.txt_B_BCAT_NM.DataPropertyName = "B_BCAT_NM"
        Me.txt_B_BCAT_NM.HeaderText = "B_BCAT_NM"
        Me.txt_B_BCAT_NM.Name = "txt_B_BCAT_NM"
        Me.txt_B_BCAT_NM.ReadOnly = True
        Me.txt_B_BCAT_NM.Width = 75
        '
        ' txt_H_BCAT_NM
        '
        Me.txt_H_BCAT_NM.DataPropertyName = "H_BCAT_NM"
        Me.txt_H_BCAT_NM.HeaderText = "H_BCAT_NM"
        Me.txt_H_BCAT_NM.Name = "txt_H_BCAT_NM"
        Me.txt_H_BCAT_NM.ReadOnly = True
        Me.txt_H_BCAT_NM.Width = 75
        '
        ' txt_HKMK_NM
        '
        Me.txt_HKMK_NM.DataPropertyName = "HKMK_NM"
        Me.txt_HKMK_NM.HeaderText = "HKMK_NM"
        Me.txt_HKMK_NM.Name = "txt_HKMK_NM"
        Me.txt_HKMK_NM.ReadOnly = True
        Me.txt_HKMK_NM.Width = 75
        '
        ' txt_K_KJYO_ST_DT
        '
        Me.txt_K_KJYO_ST_DT.DataPropertyName = "K_KJYO_ST_DT"
        Me.txt_K_KJYO_ST_DT.HeaderText = "K_KJYO_ST_DT"
        Me.txt_K_KJYO_ST_DT.Name = "txt_K_KJYO_ST_DT"
        Me.txt_K_KJYO_ST_DT.ReadOnly = True
        Me.txt_K_KJYO_ST_DT.Width = 60
        '
        ' txt_B_KJYO_EN_DT
        '
        Me.txt_B_KJYO_EN_DT.DataPropertyName = "B_KJYO_EN_DT"
        Me.txt_B_KJYO_EN_DT.HeaderText = "B_KJYO_EN_DT"
        Me.txt_B_KJYO_EN_DT.Name = "txt_B_KJYO_EN_DT"
        Me.txt_B_KJYO_EN_DT.ReadOnly = True
        Me.txt_B_KJYO_EN_DT.Width = 60
        '
        ' txt_LSRYO_TOTAL
        '
        Me.txt_LSRYO_TOTAL.DataPropertyName = "LSRYO_TOTAL"
        Me.txt_LSRYO_TOTAL.HeaderText = "LSRYO_TOTAL"
        Me.txt_LSRYO_TOTAL.Name = "txt_LSRYO_TOTAL"
        Me.txt_LSRYO_TOTAL.ReadOnly = True
        Me.txt_LSRYO_TOTAL.Width = 83
        '
        ' txt_MAE_ZZAN
        '
        Me.txt_MAE_ZZAN.DataPropertyName = "MAE_ZZAN"
        Me.txt_MAE_ZZAN.HeaderText = "前期末残高・前払"
        Me.txt_MAE_ZZAN.Name = "txt_MAE_ZZAN"
        Me.txt_MAE_ZZAN.ReadOnly = True
        Me.txt_MAE_ZZAN.Width = 83
        '
        ' txt_LSRYO_ZZAN
        '
        Me.txt_LSRYO_ZZAN.DataPropertyName = "LSRYO_ZZAN"
        Me.txt_LSRYO_ZZAN.HeaderText = "LSRYO_ZZAN"
        Me.txt_LSRYO_ZZAN.Name = "txt_LSRYO_ZZAN"
        Me.txt_LSRYO_ZZAN.ReadOnly = True
        Me.txt_LSRYO_ZZAN.Width = 83
        '
        ' txt_KEIHI_TOKI
        '
        Me.txt_KEIHI_TOKI.DataPropertyName = "KEIHI_TOKI"
        Me.txt_KEIHI_TOKI.HeaderText = "KEIHI_TOKI"
        Me.txt_KEIHI_TOKI.Name = "txt_KEIHI_TOKI"
        Me.txt_KEIHI_TOKI.ReadOnly = True
        Me.txt_KEIHI_TOKI.Width = 83
        '
        ' txt_LSRYO_TOKI
        '
        Me.txt_LSRYO_TOKI.DataPropertyName = "LSRYO_TOKI"
        Me.txt_LSRYO_TOKI.HeaderText = "LSRYO_TOKI"
        Me.txt_LSRYO_TOKI.Name = "txt_LSRYO_TOKI"
        Me.txt_LSRYO_TOKI.ReadOnly = True
        Me.txt_LSRYO_TOKI.Width = 83
        '
        ' txt_MAE_ZAN
        '
        Me.txt_MAE_ZAN.DataPropertyName = "MAE_ZAN"
        Me.txt_MAE_ZAN.HeaderText = "MAE_ZAN"
        Me.txt_MAE_ZAN.Name = "txt_MAE_ZAN"
        Me.txt_MAE_ZAN.ReadOnly = True
        Me.txt_MAE_ZAN.Width = 83
        '
        ' txt_LSRYO_ZAN
        '
        Me.txt_LSRYO_ZAN.DataPropertyName = "LSRYO_ZAN"
        Me.txt_LSRYO_ZAN.HeaderText = "LSRYO_ZAN"
        Me.txt_LSRYO_ZAN.Name = "txt_LSRYO_ZAN"
        Me.txt_LSRYO_ZAN.ReadOnly = True
        Me.txt_LSRYO_ZAN.Width = 83
        '
        ' txt_KAIYAK_MAE_ZAN
        '
        Me.txt_KAIYAK_MAE_ZAN.DataPropertyName = "KAIYAK_MAE_ZAN"
        Me.txt_KAIYAK_MAE_ZAN.HeaderText = "KAIYAK_MAE_ZAN"
        Me.txt_KAIYAK_MAE_ZAN.Name = "txt_KAIYAK_MAE_ZAN"
        Me.txt_KAIYAK_MAE_ZAN.ReadOnly = True
        Me.txt_KAIYAK_MAE_ZAN.Width = 83
        '
        ' txt_KAIYAK_KEIHI
        '
        Me.txt_KAIYAK_KEIHI.DataPropertyName = "KAIYAK_KEIHI"
        Me.txt_KAIYAK_KEIHI.HeaderText = "KAIYAK_KEIHI"
        Me.txt_KAIYAK_KEIHI.Name = "txt_KAIYAK_KEIHI"
        Me.txt_KAIYAK_KEIHI.ReadOnly = True
        Me.txt_KAIYAK_KEIHI.Width = 83
        '
        ' txt_KEIHI_TOKIG01
        '
        Me.txt_KEIHI_TOKIG01.DataPropertyName = "KEIHI_TOKIG01"
        Me.txt_KEIHI_TOKIG01.HeaderText = "KEIHI_TOKIG01"
        Me.txt_KEIHI_TOKIG01.Name = "txt_KEIHI_TOKIG01"
        Me.txt_KEIHI_TOKIG01.ReadOnly = True
        Me.txt_KEIHI_TOKIG01.Width = 83
        '
        ' txt_KEIHI_TOKIG02
        '
        Me.txt_KEIHI_TOKIG02.DataPropertyName = "KEIHI_TOKIG02"
        Me.txt_KEIHI_TOKIG02.HeaderText = "KEIHI_TOKIG02"
        Me.txt_KEIHI_TOKIG02.Name = "txt_KEIHI_TOKIG02"
        Me.txt_KEIHI_TOKIG02.ReadOnly = True
        Me.txt_KEIHI_TOKIG02.Width = 83
        '
        ' txt_KEIHI_TOKIG03
        '
        Me.txt_KEIHI_TOKIG03.DataPropertyName = "KEIHI_TOKIG03"
        Me.txt_KEIHI_TOKIG03.HeaderText = "KEIHI_TOKIG03"
        Me.txt_KEIHI_TOKIG03.Name = "txt_KEIHI_TOKIG03"
        Me.txt_KEIHI_TOKIG03.ReadOnly = True
        Me.txt_KEIHI_TOKIG03.Width = 83
        '
        ' txt_KEIHI_TOKIG04
        '
        Me.txt_KEIHI_TOKIG04.DataPropertyName = "KEIHI_TOKIG04"
        Me.txt_KEIHI_TOKIG04.HeaderText = "KEIHI_TOKIG04"
        Me.txt_KEIHI_TOKIG04.Name = "txt_KEIHI_TOKIG04"
        Me.txt_KEIHI_TOKIG04.ReadOnly = True
        Me.txt_KEIHI_TOKIG04.Width = 83
        '
        ' txt_KEIHI_TOKIG05
        '
        Me.txt_KEIHI_TOKIG05.DataPropertyName = "KEIHI_TOKIG05"
        Me.txt_KEIHI_TOKIG05.HeaderText = "KEIHI_TOKIG05"
        Me.txt_KEIHI_TOKIG05.Name = "txt_KEIHI_TOKIG05"
        Me.txt_KEIHI_TOKIG05.ReadOnly = True
        Me.txt_KEIHI_TOKIG05.Width = 83
        '
        ' txt_KEIHI_TOKIG06
        '
        Me.txt_KEIHI_TOKIG06.DataPropertyName = "KEIHI_TOKIG06"
        Me.txt_KEIHI_TOKIG06.HeaderText = "KEIHI_TOKIG06"
        Me.txt_KEIHI_TOKIG06.Name = "txt_KEIHI_TOKIG06"
        Me.txt_KEIHI_TOKIG06.ReadOnly = True
        Me.txt_KEIHI_TOKIG06.Width = 83
        '
        ' txt_KEIHI_TOKIG07
        '
        Me.txt_KEIHI_TOKIG07.DataPropertyName = "KEIHI_TOKIG07"
        Me.txt_KEIHI_TOKIG07.HeaderText = "KEIHI_TOKIG07"
        Me.txt_KEIHI_TOKIG07.Name = "txt_KEIHI_TOKIG07"
        Me.txt_KEIHI_TOKIG07.ReadOnly = True
        Me.txt_KEIHI_TOKIG07.Width = 83
        '
        ' txt_KEIHI_TOKIG08
        '
        Me.txt_KEIHI_TOKIG08.DataPropertyName = "KEIHI_TOKIG08"
        Me.txt_KEIHI_TOKIG08.HeaderText = "KEIHI_TOKIG08"
        Me.txt_KEIHI_TOKIG08.Name = "txt_KEIHI_TOKIG08"
        Me.txt_KEIHI_TOKIG08.ReadOnly = True
        Me.txt_KEIHI_TOKIG08.Width = 83
        '
        ' txt_KEIHI_TOKIG09
        '
        Me.txt_KEIHI_TOKIG09.DataPropertyName = "KEIHI_TOKIG09"
        Me.txt_KEIHI_TOKIG09.HeaderText = "KEIHI_TOKIG09"
        Me.txt_KEIHI_TOKIG09.Name = "txt_KEIHI_TOKIG09"
        Me.txt_KEIHI_TOKIG09.ReadOnly = True
        Me.txt_KEIHI_TOKIG09.Width = 83
        '
        ' txt_KEIHI_TOKIG10
        '
        Me.txt_KEIHI_TOKIG10.DataPropertyName = "KEIHI_TOKIG10"
        Me.txt_KEIHI_TOKIG10.HeaderText = "KEIHI_TOKIG10"
        Me.txt_KEIHI_TOKIG10.Name = "txt_KEIHI_TOKIG10"
        Me.txt_KEIHI_TOKIG10.ReadOnly = True
        Me.txt_KEIHI_TOKIG10.Width = 83
        '
        ' txt_KEIHI_TOKIG11
        '
        Me.txt_KEIHI_TOKIG11.DataPropertyName = "KEIHI_TOKIG11"
        Me.txt_KEIHI_TOKIG11.HeaderText = "KEIHI_TOKIG11"
        Me.txt_KEIHI_TOKIG11.Name = "txt_KEIHI_TOKIG11"
        Me.txt_KEIHI_TOKIG11.ReadOnly = True
        Me.txt_KEIHI_TOKIG11.Width = 83
        '
        ' txt_KEIHI_TOKIG12
        '
        Me.txt_KEIHI_TOKIG12.DataPropertyName = "KEIHI_TOKIG12"
        Me.txt_KEIHI_TOKIG12.HeaderText = "KEIHI_TOKIG12"
        Me.txt_KEIHI_TOKIG12.Name = "txt_KEIHI_TOKIG12"
        Me.txt_KEIHI_TOKIG12.ReadOnly = True
        Me.txt_KEIHI_TOKIG12.Width = 83
        '
        ' txt_LSRYO_TOTAL_SUM
        '
        Me.txt_LSRYO_TOTAL_SUM.DataPropertyName = "LSRYO_TOTAL_SUM"
        Me.txt_LSRYO_TOTAL_SUM.HeaderText = "LSRYO_TOTAL_SUM"
        Me.txt_LSRYO_TOTAL_SUM.Name = "txt_LSRYO_TOTAL_SUM"
        Me.txt_LSRYO_TOTAL_SUM.ReadOnly = True
        Me.txt_LSRYO_TOTAL_SUM.Width = 83
        '
        ' txt_MAE_ZZAN_SUM
        '
        Me.txt_MAE_ZZAN_SUM.DataPropertyName = "MAE_ZZAN_SUM"
        Me.txt_MAE_ZZAN_SUM.HeaderText = "MAE_ZZAN_SUM"
        Me.txt_MAE_ZZAN_SUM.Name = "txt_MAE_ZZAN_SUM"
        Me.txt_MAE_ZZAN_SUM.ReadOnly = True
        Me.txt_MAE_ZZAN_SUM.Width = 83
        '
        ' txt_LSRYO_ZZAN_SUM
        '
        Me.txt_LSRYO_ZZAN_SUM.DataPropertyName = "LSRYO_ZZAN_SUM"
        Me.txt_LSRYO_ZZAN_SUM.HeaderText = "LSRYO_ZZAN_SUM"
        Me.txt_LSRYO_ZZAN_SUM.Name = "txt_LSRYO_ZZAN_SUM"
        Me.txt_LSRYO_ZZAN_SUM.ReadOnly = True
        Me.txt_LSRYO_ZZAN_SUM.Width = 83
        '
        ' txt_KEIHI_TOKI_SUM
        '
        Me.txt_KEIHI_TOKI_SUM.DataPropertyName = "KEIHI_TOKI_SUM"
        Me.txt_KEIHI_TOKI_SUM.HeaderText = "KEIHI_TOKI_SUM"
        Me.txt_KEIHI_TOKI_SUM.Name = "txt_KEIHI_TOKI_SUM"
        Me.txt_KEIHI_TOKI_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKI_SUM.Width = 83
        '
        ' txt_LSRYO_TOKI_SUM
        '
        Me.txt_LSRYO_TOKI_SUM.DataPropertyName = "LSRYO_TOKI_SUM"
        Me.txt_LSRYO_TOKI_SUM.HeaderText = "LSRYO_TOKI_SUM"
        Me.txt_LSRYO_TOKI_SUM.Name = "txt_LSRYO_TOKI_SUM"
        Me.txt_LSRYO_TOKI_SUM.ReadOnly = True
        Me.txt_LSRYO_TOKI_SUM.Width = 83
        '
        ' txt_MAE_ZAN_SUM
        '
        Me.txt_MAE_ZAN_SUM.DataPropertyName = "MAE_ZAN_SUM"
        Me.txt_MAE_ZAN_SUM.HeaderText = "MAE_ZAN_SUM"
        Me.txt_MAE_ZAN_SUM.Name = "txt_MAE_ZAN_SUM"
        Me.txt_MAE_ZAN_SUM.ReadOnly = True
        Me.txt_MAE_ZAN_SUM.Width = 83
        '
        ' txt_LSRYO_ZAN_SUM
        '
        Me.txt_LSRYO_ZAN_SUM.DataPropertyName = "LSRYO_ZAN_SUM"
        Me.txt_LSRYO_ZAN_SUM.HeaderText = "LSRYO_ZAN_SUM"
        Me.txt_LSRYO_ZAN_SUM.Name = "txt_LSRYO_ZAN_SUM"
        Me.txt_LSRYO_ZAN_SUM.ReadOnly = True
        Me.txt_LSRYO_ZAN_SUM.Width = 83
        '
        ' txt_KAIYAK_MAE_ZAN_SUM
        '
        Me.txt_KAIYAK_MAE_ZAN_SUM.DataPropertyName = "KAIYAK_MAE_ZAN_SUM"
        Me.txt_KAIYAK_MAE_ZAN_SUM.HeaderText = "KAIYAK_MAE_ZAN_SUM"
        Me.txt_KAIYAK_MAE_ZAN_SUM.Name = "txt_KAIYAK_MAE_ZAN_SUM"
        Me.txt_KAIYAK_MAE_ZAN_SUM.ReadOnly = True
        Me.txt_KAIYAK_MAE_ZAN_SUM.Width = 83
        '
        ' txt_KAIYAK_KEIHI_SUM
        '
        Me.txt_KAIYAK_KEIHI_SUM.DataPropertyName = "KAIYAK_KEIHI_SUM"
        Me.txt_KAIYAK_KEIHI_SUM.HeaderText = "KAIYAK_KEIHI_SUM"
        Me.txt_KAIYAK_KEIHI_SUM.Name = "txt_KAIYAK_KEIHI_SUM"
        Me.txt_KAIYAK_KEIHI_SUM.ReadOnly = True
        Me.txt_KAIYAK_KEIHI_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG01_SUM
        '
        Me.txt_KEIHI_TOKIG01_SUM.DataPropertyName = "KEIHI_TOKIG01_SUM"
        Me.txt_KEIHI_TOKIG01_SUM.HeaderText = "KEIHI_TOKIG01_SUM"
        Me.txt_KEIHI_TOKIG01_SUM.Name = "txt_KEIHI_TOKIG01_SUM"
        Me.txt_KEIHI_TOKIG01_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG01_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG02_SUM
        '
        Me.txt_KEIHI_TOKIG02_SUM.DataPropertyName = "KEIHI_TOKIG02_SUM"
        Me.txt_KEIHI_TOKIG02_SUM.HeaderText = "KEIHI_TOKIG02_SUM"
        Me.txt_KEIHI_TOKIG02_SUM.Name = "txt_KEIHI_TOKIG02_SUM"
        Me.txt_KEIHI_TOKIG02_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG02_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG03_SUM
        '
        Me.txt_KEIHI_TOKIG03_SUM.DataPropertyName = "KEIHI_TOKIG03_SUM"
        Me.txt_KEIHI_TOKIG03_SUM.HeaderText = "KEIHI_TOKIG03_SUM"
        Me.txt_KEIHI_TOKIG03_SUM.Name = "txt_KEIHI_TOKIG03_SUM"
        Me.txt_KEIHI_TOKIG03_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG03_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG04_SUM
        '
        Me.txt_KEIHI_TOKIG04_SUM.DataPropertyName = "KEIHI_TOKIG04_SUM"
        Me.txt_KEIHI_TOKIG04_SUM.HeaderText = "KEIHI_TOKIG04_SUM"
        Me.txt_KEIHI_TOKIG04_SUM.Name = "txt_KEIHI_TOKIG04_SUM"
        Me.txt_KEIHI_TOKIG04_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG04_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG05_SUM
        '
        Me.txt_KEIHI_TOKIG05_SUM.DataPropertyName = "KEIHI_TOKIG05_SUM"
        Me.txt_KEIHI_TOKIG05_SUM.HeaderText = "KEIHI_TOKIG05_SUM"
        Me.txt_KEIHI_TOKIG05_SUM.Name = "txt_KEIHI_TOKIG05_SUM"
        Me.txt_KEIHI_TOKIG05_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG05_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG06_SUM
        '
        Me.txt_KEIHI_TOKIG06_SUM.DataPropertyName = "KEIHI_TOKIG06_SUM"
        Me.txt_KEIHI_TOKIG06_SUM.HeaderText = "KEIHI_TOKIG06_SUM"
        Me.txt_KEIHI_TOKIG06_SUM.Name = "txt_KEIHI_TOKIG06_SUM"
        Me.txt_KEIHI_TOKIG06_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG06_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG07_SUM
        '
        Me.txt_KEIHI_TOKIG07_SUM.DataPropertyName = "KEIHI_TOKIG07_SUM"
        Me.txt_KEIHI_TOKIG07_SUM.HeaderText = "KEIHI_TOKIG07_SUM"
        Me.txt_KEIHI_TOKIG07_SUM.Name = "txt_KEIHI_TOKIG07_SUM"
        Me.txt_KEIHI_TOKIG07_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG07_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG08_SUM
        '
        Me.txt_KEIHI_TOKIG08_SUM.DataPropertyName = "KEIHI_TOKIG08_SUM"
        Me.txt_KEIHI_TOKIG08_SUM.HeaderText = "KEIHI_TOKIG08_SUM"
        Me.txt_KEIHI_TOKIG08_SUM.Name = "txt_KEIHI_TOKIG08_SUM"
        Me.txt_KEIHI_TOKIG08_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG08_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG09_SUM
        '
        Me.txt_KEIHI_TOKIG09_SUM.DataPropertyName = "KEIHI_TOKIG09_SUM"
        Me.txt_KEIHI_TOKIG09_SUM.HeaderText = "KEIHI_TOKIG09_SUM"
        Me.txt_KEIHI_TOKIG09_SUM.Name = "txt_KEIHI_TOKIG09_SUM"
        Me.txt_KEIHI_TOKIG09_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG09_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG10_SUM
        '
        Me.txt_KEIHI_TOKIG10_SUM.DataPropertyName = "KEIHI_TOKIG10_SUM"
        Me.txt_KEIHI_TOKIG10_SUM.HeaderText = "KEIHI_TOKIG10_SUM"
        Me.txt_KEIHI_TOKIG10_SUM.Name = "txt_KEIHI_TOKIG10_SUM"
        Me.txt_KEIHI_TOKIG10_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG10_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG11_SUM
        '
        Me.txt_KEIHI_TOKIG11_SUM.DataPropertyName = "KEIHI_TOKIG11_SUM"
        Me.txt_KEIHI_TOKIG11_SUM.HeaderText = "KEIHI_TOKIG11_SUM"
        Me.txt_KEIHI_TOKIG11_SUM.Name = "txt_KEIHI_TOKIG11_SUM"
        Me.txt_KEIHI_TOKIG11_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG11_SUM.Width = 83
        '
        ' txt_KEIHI_TOKIG12_SUM
        '
        Me.txt_KEIHI_TOKIG12_SUM.DataPropertyName = "KEIHI_TOKIG12_SUM"
        Me.txt_KEIHI_TOKIG12_SUM.HeaderText = "KEIHI_TOKIG12_SUM"
        Me.txt_KEIHI_TOKIG12_SUM.Name = "txt_KEIHI_TOKIG12_SUM"
        Me.txt_KEIHI_TOKIG12_SUM.ReadOnly = True
        Me.txt_KEIHI_TOKIG12_SUM.Width = 83
        '
        ' txt_ID
        '
        Me.txt_ID.DataPropertyName = "ID"
        Me.txt_ID.HeaderText = "ID"
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Visible = False
        '
        ' Form_f_flx_経費明細表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_経費明細表"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "経費明細表"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_設定 As System.Windows.Forms.Button
    Friend WithEvents cmd_照会 As System.Windows.Forms.Button
    Friend WithEvents cmd_仕訳 As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_JOKEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKM_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SAIKAISU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LINE_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KKBN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_REC_KBN_STR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CKAIYK_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LCPT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_H_BCAT_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_HKMK_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_KJYO_ST_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KJYO_EN_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_TOTAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_MAE_ZZAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_ZZAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_TOKI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_MAE_ZAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_ZAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KAIYAK_MAE_ZAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KAIYAK_KEIHI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG01 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG02 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG03 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG04 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG05 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG06 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG07 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG08 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG09 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_TOTAL_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_MAE_ZZAN_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_ZZAN_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKI_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_TOKI_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_MAE_ZAN_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LSRYO_ZAN_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KAIYAK_MAE_ZAN_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KAIYAK_KEIHI_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG01_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG02_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG03_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG04_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG05_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG06_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG07_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG08_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG09_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG10_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG11_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KEIHI_TOKIG12_SUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class