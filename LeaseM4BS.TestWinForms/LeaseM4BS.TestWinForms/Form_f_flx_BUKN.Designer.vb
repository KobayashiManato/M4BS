<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_f_flx_BUKN
    Inherits Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_kykm_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kykh_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kykm_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kjkbn_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_saikaisu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bukn_bango1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lcpt1_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kykbnl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kykbnj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_rng_bango = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bukn_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kknri1_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bcat1_cd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bcat1_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_start_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_end_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_knyukn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_b_slsryo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_b_glsryo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_b_klsryo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_b_mlsryo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bkind_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_bkind_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_leakbn_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_chu_hnti_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_chuum_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_b_zokusei1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_seigou_f = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.cmd_EXCEL_LOSS = New System.Windows.Forms.Button()
        Me.cmd_EXCEL_CHANGE = New System.Windows.Forms.Button()
        Me.cmd_CSV = New System.Windows.Forms.Button()
        Me.cmd_PRINT = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.cmd_CHANGE_BUKN = New System.Windows.Forms.Button()
        Me.cmd_CHANGE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_LIST
        '
        Me.dgv_LIST.AllowUserToAddRows = False
        Me.dgv_LIST.AllowUserToDeleteRows = False
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_kykm_id, Me.kykh_id, Me.col_kykm_no, Me.col_kjkbn_nm, Me.col_saikaisu, Me.col_bukn_bango1, Me.col_lcpt1_nm, Me.col_kykbnl, Me.col_kykbnj, Me.col_rng_bango, Me.col_bukn_nm, Me.col_kknri1_nm, Me.col_bcat1_cd, Me.col_bcat1_nm, Me.col_start_dt, Me.col_end_dt, Me.col_knyukn, Me.col_b_slsryo, Me.col_b_glsryo, Me.col_b_klsryo, Me.col_b_mlsryo, Me.col_bkind_nm, Me.col_bkind_id, Me.col_leakbn_nm, Me.col_chu_hnti_nm, Me.col_chuum_nm, Me.col_b_zokusei1, Me.col_seigou_f})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 110)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(1924, 724)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_kykm_id
        '
        Me.col_kykm_id.DataPropertyName = "kykm_id"
        Me.col_kykm_id.HeaderText = "KykmID"
        Me.col_kykm_id.MinimumWidth = 8
        Me.col_kykm_id.Name = "col_kykm_id"
        Me.col_kykm_id.ReadOnly = True
        Me.col_kykm_id.Visible = False
        Me.col_kykm_id.Width = 150
        '
        'kykh_id
        '
        Me.kykh_id.HeaderText = "KykhID"
        Me.kykh_id.MinimumWidth = 8
        Me.kykh_id.Name = "kykh_id"
        Me.kykh_id.ReadOnly = True
        Me.kykh_id.Visible = False
        Me.kykh_id.Width = 150
        '
        'col_kykm_no
        '
        Me.col_kykm_no.DataPropertyName = "物件No"
        Me.col_kykm_no.HeaderText = "物件No"
        Me.col_kykm_no.MinimumWidth = 8
        Me.col_kykm_no.Name = "col_kykm_no"
        Me.col_kykm_no.ReadOnly = True
        Me.col_kykm_no.Width = 150
        '
        'col_kjkbn_nm
        '
        Me.col_kjkbn_nm.DataPropertyName = "計上区分"
        Me.col_kjkbn_nm.HeaderText = "計上区分"
        Me.col_kjkbn_nm.MinimumWidth = 8
        Me.col_kjkbn_nm.Name = "col_kjkbn_nm"
        Me.col_kjkbn_nm.ReadOnly = True
        Me.col_kjkbn_nm.Width = 80
        '
        'col_saikaisu
        '
        Me.col_saikaisu.DataPropertyName = "再リース回数"
        Me.col_saikaisu.HeaderText = "再リース回数"
        Me.col_saikaisu.MinimumWidth = 8
        Me.col_saikaisu.Name = "col_saikaisu"
        Me.col_saikaisu.ReadOnly = True
        Me.col_saikaisu.Width = 150
        '
        'col_bukn_bango1
        '
        Me.col_bukn_bango1.DataPropertyName = "資産番号1"
        Me.col_bukn_bango1.HeaderText = "資産番号1"
        Me.col_bukn_bango1.MinimumWidth = 8
        Me.col_bukn_bango1.Name = "col_bukn_bango1"
        Me.col_bukn_bango1.ReadOnly = True
        Me.col_bukn_bango1.Width = 150
        '
        'col_lcpt1_nm
        '
        Me.col_lcpt1_nm.DataPropertyName = "支払先"
        Me.col_lcpt1_nm.HeaderText = "支払先"
        Me.col_lcpt1_nm.MinimumWidth = 8
        Me.col_lcpt1_nm.Name = "col_lcpt1_nm"
        Me.col_lcpt1_nm.ReadOnly = True
        Me.col_lcpt1_nm.Width = 150
        '
        'col_kykbnl
        '
        Me.col_kykbnl.DataPropertyName = "契約番号"
        Me.col_kykbnl.HeaderText = "契約番号"
        Me.col_kykbnl.MinimumWidth = 8
        Me.col_kykbnl.Name = "col_kykbnl"
        Me.col_kykbnl.ReadOnly = True
        Me.col_kykbnl.Width = 150
        '
        'col_kykbnj
        '
        Me.col_kykbnj.DataPropertyName = "自社管理番号"
        DataGridViewCellStyle1.Format = "d"
        Me.col_kykbnj.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_kykbnj.HeaderText = "自社管理番号"
        Me.col_kykbnj.MinimumWidth = 8
        Me.col_kykbnj.Name = "col_kykbnj"
        Me.col_kykbnj.ReadOnly = True
        Me.col_kykbnj.Width = 90
        '
        'col_rng_bango
        '
        Me.col_rng_bango.DataPropertyName = "稟議番号"
        DataGridViewCellStyle2.Format = "d"
        Me.col_rng_bango.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_rng_bango.HeaderText = "稟議番号"
        Me.col_rng_bango.MinimumWidth = 8
        Me.col_rng_bango.Name = "col_rng_bango"
        Me.col_rng_bango.ReadOnly = True
        Me.col_rng_bango.Width = 90
        '
        'col_bukn_nm
        '
        Me.col_bukn_nm.DataPropertyName = "物件名"
        DataGridViewCellStyle3.Format = "d"
        Me.col_bukn_nm.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_bukn_nm.HeaderText = "物件名"
        Me.col_bukn_nm.MinimumWidth = 8
        Me.col_bukn_nm.Name = "col_bukn_nm"
        Me.col_bukn_nm.ReadOnly = True
        Me.col_bukn_nm.Width = 90
        '
        'col_kknri1_nm
        '
        Me.col_kknri1_nm.DataPropertyName = "管理単位"
        Me.col_kknri1_nm.HeaderText = "管理単位"
        Me.col_kknri1_nm.MinimumWidth = 8
        Me.col_kknri1_nm.Name = "col_kknri1_nm"
        Me.col_kknri1_nm.ReadOnly = True
        Me.col_kknri1_nm.Width = 150
        '
        'col_bcat1_cd
        '
        Me.col_bcat1_cd.DataPropertyName = "管理部署番号"
        Me.col_bcat1_cd.HeaderText = "管理部署番号"
        Me.col_bcat1_cd.MinimumWidth = 8
        Me.col_bcat1_cd.Name = "col_bcat1_cd"
        Me.col_bcat1_cd.ReadOnly = True
        Me.col_bcat1_cd.Width = 150
        '
        'col_bcat1_nm
        '
        Me.col_bcat1_nm.DataPropertyName = "管理部署"
        Me.col_bcat1_nm.HeaderText = "管理部署"
        Me.col_bcat1_nm.MinimumWidth = 8
        Me.col_bcat1_nm.Name = "col_bcat1_nm"
        Me.col_bcat1_nm.ReadOnly = True
        Me.col_bcat1_nm.Width = 150
        '
        'col_start_dt
        '
        Me.col_start_dt.DataPropertyName = "開始日"
        Me.col_start_dt.HeaderText = "開始日"
        Me.col_start_dt.MinimumWidth = 8
        Me.col_start_dt.Name = "col_start_dt"
        Me.col_start_dt.ReadOnly = True
        Me.col_start_dt.Width = 150
        '
        'col_end_dt
        '
        Me.col_end_dt.DataPropertyName = "終了日"
        Me.col_end_dt.HeaderText = "終了日"
        Me.col_end_dt.MinimumWidth = 8
        Me.col_end_dt.Name = "col_end_dt"
        Me.col_end_dt.ReadOnly = True
        Me.col_end_dt.Width = 150
        '
        'col_knyukn
        '
        Me.col_knyukn.DataPropertyName = "現金購入価額"
        Me.col_knyukn.HeaderText = "現金購入価額"
        Me.col_knyukn.MinimumWidth = 8
        Me.col_knyukn.Name = "col_knyukn"
        Me.col_knyukn.ReadOnly = True
        Me.col_knyukn.Width = 150
        '
        'col_b_slsryo
        '
        Me.col_b_slsryo.DataPropertyName = "総額リース料"
        Me.col_b_slsryo.HeaderText = "総額リース料"
        Me.col_b_slsryo.MinimumWidth = 8
        Me.col_b_slsryo.Name = "col_b_slsryo"
        Me.col_b_slsryo.ReadOnly = True
        Me.col_b_slsryo.Width = 150
        '
        'col_b_glsryo
        '
        Me.col_b_glsryo.DataPropertyName = "月額リース料"
        Me.col_b_glsryo.HeaderText = "月額リース料"
        Me.col_b_glsryo.MinimumWidth = 8
        Me.col_b_glsryo.Name = "col_b_glsryo"
        Me.col_b_glsryo.ReadOnly = True
        Me.col_b_glsryo.Width = 150
        '
        'col_b_klsryo
        '
        Me.col_b_klsryo.DataPropertyName = "1支払額"
        Me.col_b_klsryo.HeaderText = "1支払額"
        Me.col_b_klsryo.MinimumWidth = 8
        Me.col_b_klsryo.Name = "col_b_klsryo"
        Me.col_b_klsryo.ReadOnly = True
        Me.col_b_klsryo.Width = 150
        '
        'col_b_mlsryo
        '
        Me.col_b_mlsryo.DataPropertyName = "前払リース料"
        Me.col_b_mlsryo.HeaderText = "前払リース料"
        Me.col_b_mlsryo.MinimumWidth = 8
        Me.col_b_mlsryo.Name = "col_b_mlsryo"
        Me.col_b_mlsryo.ReadOnly = True
        Me.col_b_mlsryo.Width = 150
        '
        'col_bkind_nm
        '
        Me.col_bkind_nm.DataPropertyName = "資産区分"
        Me.col_bkind_nm.HeaderText = "資産区分"
        Me.col_bkind_nm.MinimumWidth = 8
        Me.col_bkind_nm.Name = "col_bkind_nm"
        Me.col_bkind_nm.ReadOnly = True
        Me.col_bkind_nm.Width = 150
        '
        'col_bkind_id
        '
        Me.col_bkind_id.DataPropertyName = "物件種別"
        Me.col_bkind_id.HeaderText = "物件種別"
        Me.col_bkind_id.MinimumWidth = 8
        Me.col_bkind_id.Name = "col_bkind_id"
        Me.col_bkind_id.ReadOnly = True
        Me.col_bkind_id.Width = 150
        '
        'col_leakbn_nm
        '
        Me.col_leakbn_nm.DataPropertyName = "リース区分"
        Me.col_leakbn_nm.HeaderText = "リース区分"
        Me.col_leakbn_nm.MinimumWidth = 8
        Me.col_leakbn_nm.Name = "col_leakbn_nm"
        Me.col_leakbn_nm.ReadOnly = True
        Me.col_leakbn_nm.Width = 150
        '
        'col_chu_hnti_nm
        '
        Me.col_chu_hnti_nm.DataPropertyName = "注記判定結果"
        Me.col_chu_hnti_nm.HeaderText = "注記判定結果"
        Me.col_chu_hnti_nm.MinimumWidth = 8
        Me.col_chu_hnti_nm.Name = "col_chu_hnti_nm"
        Me.col_chu_hnti_nm.ReadOnly = True
        Me.col_chu_hnti_nm.Width = 150
        '
        'col_chuum_nm
        '
        Me.col_chuum_nm.DataPropertyName = "注記/省略"
        Me.col_chuum_nm.HeaderText = "注記/省略"
        Me.col_chuum_nm.MinimumWidth = 8
        Me.col_chuum_nm.Name = "col_chuum_nm"
        Me.col_chuum_nm.ReadOnly = True
        Me.col_chuum_nm.Width = 150
        '
        'col_b_zokusei1
        '
        Me.col_b_zokusei1.DataPropertyName = "備考"
        Me.col_b_zokusei1.HeaderText = "備考"
        Me.col_b_zokusei1.MinimumWidth = 8
        Me.col_b_zokusei1.Name = "col_b_zokusei1"
        Me.col_b_zokusei1.ReadOnly = True
        Me.col_b_zokusei1.Width = 150
        '
        'col_seigou_f
        '
        Me.col_seigou_f.DataPropertyName = "整合"
        Me.col_seigou_f.HeaderText = "整合"
        Me.col_seigou_f.MinimumWidth = 8
        Me.col_seigou_f.Name = "col_seigou_f"
        Me.col_seigou_f.ReadOnly = True
        Me.col_seigou_f.Width = 150
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.cmd_EXCEL_LOSS)
        Me.pnlFooter.Controls.Add(Me.cmd_EXCEL_CHANGE)
        Me.pnlFooter.Controls.Add(Me.cmd_CSV)
        Me.pnlFooter.Controls.Add(Me.cmd_PRINT)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 834)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1924, 82)
        Me.pnlFooter.TabIndex = 4
        '
        'cmd_EXCEL_LOSS
        '
        Me.cmd_EXCEL_LOSS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_EXCEL_LOSS.Location = New System.Drawing.Point(1571, 12)
        Me.cmd_EXCEL_LOSS.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXCEL_LOSS.Name = "cmd_EXCEL_LOSS"
        Me.cmd_EXCEL_LOSS.Size = New System.Drawing.Size(333, 51)
        Me.cmd_EXCEL_LOSS.TabIndex = 3
        Me.cmd_EXCEL_LOSS.Text = "減損損失取込用データExcel"
        Me.cmd_EXCEL_LOSS.UseVisualStyleBackColor = True
        '
        'cmd_EXCEL_CHANGE
        '
        Me.cmd_EXCEL_CHANGE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_EXCEL_CHANGE.Location = New System.Drawing.Point(1228, 12)
        Me.cmd_EXCEL_CHANGE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXCEL_CHANGE.Name = "cmd_EXCEL_CHANGE"
        Me.cmd_EXCEL_CHANGE.Size = New System.Drawing.Size(333, 51)
        Me.cmd_EXCEL_CHANGE.TabIndex = 2
        Me.cmd_EXCEL_CHANGE.Text = "物件移動取込用データExcel"
        Me.cmd_EXCEL_CHANGE.UseVisualStyleBackColor = True
        '
        'cmd_CSV
        '
        Me.cmd_CSV.Location = New System.Drawing.Point(223, 12)
        Me.cmd_CSV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CSV.Name = "cmd_CSV"
        Me.cmd_CSV.Size = New System.Drawing.Size(200, 51)
        Me.cmd_CSV.TabIndex = 1
        Me.cmd_CSV.Text = "ファイル出力(&F)"
        Me.cmd_CSV.UseVisualStyleBackColor = True
        '
        'cmd_PRINT
        '
        Me.cmd_PRINT.Location = New System.Drawing.Point(20, 12)
        Me.cmd_PRINT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(193, 51)
        Me.cmd_PRINT.TabIndex = 0
        Me.cmd_PRINT.Text = "印刷(&R)"
        Me.cmd_PRINT.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Controls.Add(Me.txt_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_CHANGE_BUKN)
        Me.pnlHeader.Controls.Add(Me.cmd_CHANGE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1924, 110)
        Me.pnlHeader.TabIndex = 3
        '
        'cmd_REF
        '
        Me.cmd_REF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_REF.Location = New System.Drawing.Point(545, 18)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(167, 51)
        Me.cmd_REF.TabIndex = 6
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = False
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1096, 34)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1276, 26)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1620, 18)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'cmd_CHANGE_BUKN
        '
        Me.cmd_CHANGE_BUKN.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_CHANGE_BUKN.Location = New System.Drawing.Point(368, 18)
        Me.cmd_CHANGE_BUKN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CHANGE_BUKN.Name = "cmd_CHANGE_BUKN"
        Me.cmd_CHANGE_BUKN.Size = New System.Drawing.Size(167, 51)
        Me.cmd_CHANGE_BUKN.TabIndex = 2
        Me.cmd_CHANGE_BUKN.TabStop = False
        Me.cmd_CHANGE_BUKN.Text = "物件変更(&B)"
        Me.cmd_CHANGE_BUKN.UseVisualStyleBackColor = False
        '
        'cmd_CHANGE
        '
        Me.cmd_CHANGE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_CHANGE.Location = New System.Drawing.Point(191, 17)
        Me.cmd_CHANGE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CHANGE.Name = "cmd_CHANGE"
        Me.cmd_CHANGE.Size = New System.Drawing.Size(167, 51)
        Me.cmd_CHANGE.TabIndex = 1
        Me.cmd_CHANGE.TabStop = False
        Me.cmd_CHANGE.Text = "変更(&U)"
        Me.cmd_CHANGE.UseVisualStyleBackColor = False
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 17)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(167, 51)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'FrmBuknList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 916)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "FrmBuknList"
        Me.Text = "物件一覧"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents cmd_EXCEL_LOSS As Button
    Friend WithEvents cmd_EXCEL_CHANGE As Button
    Friend WithEvents cmd_CSV As Button
    Friend WithEvents cmd_PRINT As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
    Friend WithEvents cmd_CHANGE_BUKN As Button
    Friend WithEvents cmd_CHANGE As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents cmd_REF As Button
    Friend WithEvents col_kykm_id As DataGridViewTextBoxColumn
    Friend WithEvents kykh_id As DataGridViewTextBoxColumn
    Friend WithEvents col_kykm_no As DataGridViewTextBoxColumn
    Friend WithEvents col_kjkbn_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_saikaisu As DataGridViewTextBoxColumn
    Friend WithEvents col_bukn_bango1 As DataGridViewTextBoxColumn
    Friend WithEvents col_lcpt1_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_kykbnl As DataGridViewTextBoxColumn
    Friend WithEvents col_kykbnj As DataGridViewTextBoxColumn
    Friend WithEvents col_rng_bango As DataGridViewTextBoxColumn
    Friend WithEvents col_bukn_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_kknri1_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_bcat1_cd As DataGridViewTextBoxColumn
    Friend WithEvents col_bcat1_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_start_dt As DataGridViewTextBoxColumn
    Friend WithEvents col_end_dt As DataGridViewTextBoxColumn
    Friend WithEvents col_knyukn As DataGridViewTextBoxColumn
    Friend WithEvents col_b_slsryo As DataGridViewTextBoxColumn
    Friend WithEvents col_b_glsryo As DataGridViewTextBoxColumn
    Friend WithEvents col_b_klsryo As DataGridViewTextBoxColumn
    Friend WithEvents col_b_mlsryo As DataGridViewTextBoxColumn
    Friend WithEvents col_bkind_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_bkind_id As DataGridViewTextBoxColumn
    Friend WithEvents col_leakbn_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_chu_hnti_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_chuum_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_b_zokusei1 As DataGridViewTextBoxColumn
    Friend WithEvents col_seigou_f As DataGridViewTextBoxColumn
End Class
