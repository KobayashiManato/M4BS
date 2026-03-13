<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_D_KYKM_BKN

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
        Me.cmd_変更 = New System.Windows.Forms.Button()
        Me.cmd_物件照会 = New System.Windows.Forms.Button()
        Me.cmd_REP_KYKM = New System.Windows.Forms.Button()
        Me.cmd_物件変更 = New System.Windows.Forms.Button()
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_再表示 = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KJKBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_BANGO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_SEIGOU_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKH_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KYKBNJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RNG_BANGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KKNRI1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_CKAIYK_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_BCAT1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KNYUKN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_SLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_GLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_MLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_HENF_KLSRYO_NEW = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BKIND_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LEAKBN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CHU_HNTI_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CHUUM_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_B_ZOKUSEI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_K_SEIGOU_F_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_再表示)
        Me.pnlHeader.Controls.Add(Me.cmd_閉じる)
        Me.pnlHeader.Controls.Add(Me.cmd_物件変更)
        Me.pnlHeader.Controls.Add(Me.cmd_REP_KYKM)
        Me.pnlHeader.Controls.Add(Me.cmd_物件照会)
        Me.pnlHeader.Controls.Add(Me.cmd_変更)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 40)
        Me.pnlHeader.TabIndex = 0
        '
        ' cmd_変更
        '
        Me.cmd_変更.Location = New System.Drawing.Point(4, 4)
        Me.cmd_変更.Name = "cmd_変更"
        Me.cmd_変更.Size = New System.Drawing.Size(92, 30)
        Me.cmd_変更.TabIndex = 0
        Me.cmd_変更.Text = "変更(&U)"
        Me.cmd_変更.UseVisualStyleBackColor = True
        '
        ' cmd_物件照会
        '
        Me.cmd_物件照会.Location = New System.Drawing.Point(104, 4)
        Me.cmd_物件照会.Name = "cmd_物件照会"
        Me.cmd_物件照会.Size = New System.Drawing.Size(116, 30)
        Me.cmd_物件照会.TabIndex = 1
        Me.cmd_物件照会.Text = "物件照会(&M)"
        Me.cmd_物件照会.UseVisualStyleBackColor = True
        '
        ' cmd_REP_KYKM
        '
        Me.cmd_REP_KYKM.Location = New System.Drawing.Point(228, 4)
        Me.cmd_REP_KYKM.Name = "cmd_REP_KYKM"
        Me.cmd_REP_KYKM.Size = New System.Drawing.Size(75, 30)
        Me.cmd_REP_KYKM.TabIndex = 2
        Me.cmd_REP_KYKM.Text = "物件印刷"
        Me.cmd_REP_KYKM.UseVisualStyleBackColor = True
        '
        ' cmd_物件変更
        '
        Me.cmd_物件変更.Location = New System.Drawing.Point(311, 4)
        Me.cmd_物件変更.Name = "cmd_物件変更"
        Me.cmd_物件変更.Size = New System.Drawing.Size(116, 30)
        Me.cmd_物件変更.TabIndex = 3
        Me.cmd_物件変更.Text = "物件変更(&B)"
        Me.cmd_物件変更.UseVisualStyleBackColor = True
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(435, 4)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(104, 30)
        Me.cmd_閉じる.TabIndex = 4
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_再表示
        '
        Me.cmd_再表示.Location = New System.Drawing.Point(547, 4)
        Me.cmd_再表示.Name = "cmd_再表示"
        Me.cmd_再表示.Size = New System.Drawing.Size(104, 30)
        Me.cmd_再表示.TabIndex = 5
        Me.cmd_再表示.Text = "再表示(&L)"
        Me.cmd_再表示.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSearchDLG
        '
        Me.cmd_FlexSearchDLG.Location = New System.Drawing.Point(659, 4)
        Me.cmd_FlexSearchDLG.Name = "cmd_FlexSearchDLG"
        Me.cmd_FlexSearchDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexSearchDLG.TabIndex = 6
        Me.cmd_FlexSearchDLG.Text = "検索(&S)"
        Me.cmd_FlexSearchDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSortDLG
        '
        Me.cmd_FlexSortDLG.Location = New System.Drawing.Point(759, 4)
        Me.cmd_FlexSortDLG.Name = "cmd_FlexSortDLG"
        Me.cmd_FlexSortDLG.Size = New System.Drawing.Size(116, 30)
        Me.cmd_FlexSortDLG.TabIndex = 7
        Me.cmd_FlexSortDLG.Text = "並べ替え(&O)"
        Me.cmd_FlexSortDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(883, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexReportDLG.TabIndex = 8
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        ' cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(983, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Output.TabIndex = 9
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        ' dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.txt_KYKM_NO, Me.txt_KJKBN, Me.txt_SAIKAISU, Me.txt_BUKN_BANGO1, Me.txt_K_LCPT1_NM, Me.txt_KYKBNL, Me.txt_B_BCAT1_NM, Me.txt_K_SEIGOU_F, Me.txt_KYKH_ID, Me.txt_KYKBNJ, Me.txt_RNG_BANGO, Me.txt_BUKN_NM, Me.txt_KKNRI1_NM, Me.txt_K_HISTORY_F, Me.txt_B_CKAIYK_F, Me.txt_B_BCAT1_CD, Me.txt_START_DT, Me.txt_CKAIYK_DT, Me.txt_B_KNYUKN, Me.txt_B_SLSRYO, Me.txt_B_GLSRYO, Me.txt_B_KLSRYO, Me.txt_B_MLSRYO, Me.txt_B_HENF_KLSRYO_NEW, Me.txt_SKMK_NM, Me.txt_BKIND_NM, Me.txt_LEAKBN_NM, Me.txt_CHU_HNTI_NM, Me.txt_CHUUM_NM, Me.txt_B_ZOKUSEI1, Me.txt_K_SEIGOU_F_NM, Me.txt_ID})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 40)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowTemplate.Height = 21
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(1200, 521)
        Me.dgvMain.TabIndex = 10
        '
        ' txt_KYKM_NO
        '
        Me.txt_KYKM_NO.DataPropertyName = "KYKM_NO"
        Me.txt_KYKM_NO.HeaderText = "物件No"
        Me.txt_KYKM_NO.Name = "txt_KYKM_NO"
        Me.txt_KYKM_NO.ReadOnly = True
        Me.txt_KYKM_NO.Width = 60
        '
        ' txt_KJKBN
        '
        Me.txt_KJKBN.DataPropertyName = "KJKBN"
        Me.txt_KJKBN.HeaderText = "KJKBN"
        Me.txt_KJKBN.Name = "txt_KJKBN"
        Me.txt_KJKBN.ReadOnly = True
        Me.txt_KJKBN.Width = 60
        '
        ' txt_SAIKAISU
        '
        Me.txt_SAIKAISU.DataPropertyName = "SAIKAISU"
        Me.txt_SAIKAISU.HeaderText = "再ﾘｰｽ回数"
        Me.txt_SAIKAISU.Name = "txt_SAIKAISU"
        Me.txt_SAIKAISU.ReadOnly = True
        Me.txt_SAIKAISU.Width = 60
        '
        ' txt_BUKN_BANGO1
        '
        Me.txt_BUKN_BANGO1.DataPropertyName = "BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.HeaderText = "資産番号1"
        Me.txt_BUKN_BANGO1.Name = "txt_BUKN_BANGO1"
        Me.txt_BUKN_BANGO1.ReadOnly = True
        Me.txt_BUKN_BANGO1.Width = 75
        '
        ' txt_K_LCPT1_NM
        '
        Me.txt_K_LCPT1_NM.DataPropertyName = "K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.HeaderText = "支払先"
        Me.txt_K_LCPT1_NM.Name = "txt_K_LCPT1_NM"
        Me.txt_K_LCPT1_NM.ReadOnly = True
        Me.txt_K_LCPT1_NM.Width = 132
        '
        ' txt_KYKBNL
        '
        Me.txt_KYKBNL.DataPropertyName = "KYKBNL"
        Me.txt_KYKBNL.HeaderText = "契約番号"
        Me.txt_KYKBNL.Name = "txt_KYKBNL"
        Me.txt_KYKBNL.ReadOnly = True
        Me.txt_KYKBNL.Width = 132
        '
        ' txt_B_BCAT1_NM
        '
        Me.txt_B_BCAT1_NM.DataPropertyName = "B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.HeaderText = "管理部署"
        Me.txt_B_BCAT1_NM.Name = "txt_B_BCAT1_NM"
        Me.txt_B_BCAT1_NM.ReadOnly = True
        Me.txt_B_BCAT1_NM.Width = 132
        '
        ' txt_K_SEIGOU_F
        '
        Me.txt_K_SEIGOU_F.DataPropertyName = "K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.HeaderText = "整合"
        Me.txt_K_SEIGOU_F.Name = "txt_K_SEIGOU_F"
        Me.txt_K_SEIGOU_F.ReadOnly = True
        Me.txt_K_SEIGOU_F.Width = 60
        '
        ' txt_KYKH_ID
        '
        Me.txt_KYKH_ID.DataPropertyName = "KYKH_ID"
        Me.txt_KYKH_ID.HeaderText = "KYKH_ID"
        Me.txt_KYKH_ID.Name = "txt_KYKH_ID"
        Me.txt_KYKH_ID.ReadOnly = True
        Me.txt_KYKH_ID.Width = 60
        '
        ' txt_KYKBNJ
        '
        Me.txt_KYKBNJ.DataPropertyName = "KYKBNJ"
        Me.txt_KYKBNJ.HeaderText = "KYKBNJ"
        Me.txt_KYKBNJ.Name = "txt_KYKBNJ"
        Me.txt_KYKBNJ.ReadOnly = True
        Me.txt_KYKBNJ.Width = 94
        '
        ' txt_RNG_BANGO
        '
        Me.txt_RNG_BANGO.DataPropertyName = "RNG_BANGO"
        Me.txt_RNG_BANGO.HeaderText = "RNG_BANGO"
        Me.txt_RNG_BANGO.Name = "txt_RNG_BANGO"
        Me.txt_RNG_BANGO.ReadOnly = True
        Me.txt_RNG_BANGO.Width = 94
        '
        ' txt_BUKN_NM
        '
        Me.txt_BUKN_NM.DataPropertyName = "BUKN_NM"
        Me.txt_BUKN_NM.HeaderText = "物件名"
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Width = 75
        '
        ' txt_KKNRI1_NM
        '
        Me.txt_KKNRI1_NM.DataPropertyName = "KKNRI1_NM"
        Me.txt_KKNRI1_NM.HeaderText = "管理単位"
        Me.txt_KKNRI1_NM.Name = "txt_KKNRI1_NM"
        Me.txt_KKNRI1_NM.ReadOnly = True
        Me.txt_KKNRI1_NM.Width = 60
        '
        ' txt_K_HISTORY_F
        '
        Me.txt_K_HISTORY_F.DataPropertyName = "K_HISTORY_F"
        Me.txt_K_HISTORY_F.HeaderText = "K_HISTORY_F"
        Me.txt_K_HISTORY_F.Name = "txt_K_HISTORY_F"
        Me.txt_K_HISTORY_F.ReadOnly = True
        Me.txt_K_HISTORY_F.Width = 60
        '
        ' txt_B_CKAIYK_F
        '
        Me.txt_B_CKAIYK_F.DataPropertyName = "B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.HeaderText = "B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.Name = "txt_B_CKAIYK_F"
        Me.txt_B_CKAIYK_F.ReadOnly = True
        Me.txt_B_CKAIYK_F.Width = 60
        '
        ' txt_B_BCAT1_CD
        '
        Me.txt_B_BCAT1_CD.DataPropertyName = "B_BCAT1_CD"
        Me.txt_B_BCAT1_CD.HeaderText = "B_BCAT1_CD"
        Me.txt_B_BCAT1_CD.Name = "txt_B_BCAT1_CD"
        Me.txt_B_BCAT1_CD.ReadOnly = True
        Me.txt_B_BCAT1_CD.Width = 132
        '
        ' txt_START_DT
        '
        Me.txt_START_DT.DataPropertyName = "START_DT"
        Me.txt_START_DT.HeaderText = "開始日"
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Width = 75
        '
        ' txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.DataPropertyName = "CKAIYK_DT"
        Me.txt_CKAIYK_DT.HeaderText = "中途解約日"
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Width = 75
        '
        ' txt_B_KNYUKN
        '
        Me.txt_B_KNYUKN.DataPropertyName = "B_KNYUKN"
        Me.txt_B_KNYUKN.HeaderText = "現金購入価額"
        Me.txt_B_KNYUKN.Name = "txt_B_KNYUKN"
        Me.txt_B_KNYUKN.ReadOnly = True
        Me.txt_B_KNYUKN.Width = 102
        '
        ' txt_B_SLSRYO
        '
        Me.txt_B_SLSRYO.DataPropertyName = "B_SLSRYO"
        Me.txt_B_SLSRYO.HeaderText = "総額ﾘｰｽ料"
        Me.txt_B_SLSRYO.Name = "txt_B_SLSRYO"
        Me.txt_B_SLSRYO.ReadOnly = True
        Me.txt_B_SLSRYO.Width = 102
        '
        ' txt_B_GLSRYO
        '
        Me.txt_B_GLSRYO.DataPropertyName = "B_GLSRYO"
        Me.txt_B_GLSRYO.HeaderText = "月額ﾘｰｽ料"
        Me.txt_B_GLSRYO.Name = "txt_B_GLSRYO"
        Me.txt_B_GLSRYO.ReadOnly = True
        Me.txt_B_GLSRYO.Width = 102
        '
        ' txt_B_KLSRYO
        '
        Me.txt_B_KLSRYO.DataPropertyName = "B_KLSRYO"
        Me.txt_B_KLSRYO.HeaderText = "1支払額"
        Me.txt_B_KLSRYO.Name = "txt_B_KLSRYO"
        Me.txt_B_KLSRYO.ReadOnly = True
        Me.txt_B_KLSRYO.Width = 102
        '
        ' txt_B_MLSRYO
        '
        Me.txt_B_MLSRYO.DataPropertyName = "B_MLSRYO"
        Me.txt_B_MLSRYO.HeaderText = "前払ﾘｰｽ料"
        Me.txt_B_MLSRYO.Name = "txt_B_MLSRYO"
        Me.txt_B_MLSRYO.ReadOnly = True
        Me.txt_B_MLSRYO.Width = 102
        '
        ' txt_B_HENF_KLSRYO_NEW
        '
        Me.txt_B_HENF_KLSRYO_NEW.DataPropertyName = "B_HENF_KLSRYO_NEW"
        Me.txt_B_HENF_KLSRYO_NEW.HeaderText = "保守料"
        Me.txt_B_HENF_KLSRYO_NEW.Name = "txt_B_HENF_KLSRYO_NEW"
        Me.txt_B_HENF_KLSRYO_NEW.ReadOnly = True
        Me.txt_B_HENF_KLSRYO_NEW.Width = 102
        '
        ' txt_SKMK_NM
        '
        Me.txt_SKMK_NM.DataPropertyName = "SKMK_NM"
        Me.txt_SKMK_NM.HeaderText = "資産区分"
        Me.txt_SKMK_NM.Name = "txt_SKMK_NM"
        Me.txt_SKMK_NM.ReadOnly = True
        Me.txt_SKMK_NM.Width = 113
        '
        ' txt_BKIND_NM
        '
        Me.txt_BKIND_NM.DataPropertyName = "BKIND_NM"
        Me.txt_BKIND_NM.HeaderText = "物件種別"
        Me.txt_BKIND_NM.Name = "txt_BKIND_NM"
        Me.txt_BKIND_NM.ReadOnly = True
        Me.txt_BKIND_NM.Width = 75
        '
        ' txt_LEAKBN_NM
        '
        Me.txt_LEAKBN_NM.DataPropertyName = "LEAKBN_NM"
        Me.txt_LEAKBN_NM.HeaderText = "LEAKBN_NM"
        Me.txt_LEAKBN_NM.Name = "txt_LEAKBN_NM"
        Me.txt_LEAKBN_NM.ReadOnly = True
        Me.txt_LEAKBN_NM.Width = 189
        '
        ' txt_CHU_HNTI_NM
        '
        Me.txt_CHU_HNTI_NM.DataPropertyName = "CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.HeaderText = "注記判定結果"
        Me.txt_CHU_HNTI_NM.Name = "txt_CHU_HNTI_NM"
        Me.txt_CHU_HNTI_NM.ReadOnly = True
        Me.txt_CHU_HNTI_NM.Width = 189
        '
        ' txt_CHUUM_NM
        '
        Me.txt_CHUUM_NM.DataPropertyName = "CHUUM_NM"
        Me.txt_CHUUM_NM.HeaderText = "注記/省略"
        Me.txt_CHUUM_NM.Name = "txt_CHUUM_NM"
        Me.txt_CHUUM_NM.ReadOnly = True
        Me.txt_CHUUM_NM.Width = 60
        '
        ' txt_B_ZOKUSEI1
        '
        Me.txt_B_ZOKUSEI1.DataPropertyName = "B_ZOKUSEI1"
        Me.txt_B_ZOKUSEI1.HeaderText = "備考"
        Me.txt_B_ZOKUSEI1.Name = "txt_B_ZOKUSEI1"
        Me.txt_B_ZOKUSEI1.ReadOnly = True
        Me.txt_B_ZOKUSEI1.Width = 75
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
        ' Form_f_flx_D_KYKM_BKN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_D_KYKM_BKN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "物件フレックス(物件管理者用)"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_物件照会 As System.Windows.Forms.Button
    Friend WithEvents cmd_REP_KYKM As System.Windows.Forms.Button
    Friend WithEvents cmd_物件変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_再表示 As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_KYKM_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KJKBN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SAIKAISU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_BANGO1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_LCPT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_SEIGOU_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKH_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KYKBNJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_RNG_BANGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BUKN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KKNRI1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_HISTORY_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_CKAIYK_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_BCAT1_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_START_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CKAIYK_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KNYUKN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_SLSRYO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_GLSRYO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_KLSRYO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_MLSRYO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_HENF_KLSRYO_NEW As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SKMK_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BKIND_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LEAKBN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CHU_HNTI_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CHUUM_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_B_ZOKUSEI1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_K_SEIGOU_F_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class