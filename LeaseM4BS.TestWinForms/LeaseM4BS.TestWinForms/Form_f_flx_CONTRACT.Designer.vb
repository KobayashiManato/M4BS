<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_f_flx_CONTRACT
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_NEW = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.cmd_EXCEL_RENEW = New System.Windows.Forms.Button()
        Me.cmd_EXCEL_CHANGE = New System.Windows.Forms.Button()
        Me.cmd_CSV = New System.Windows.Forms.Button()
        Me.cmd_PRINT = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_kykh_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kknri1_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kkbn_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lcpt1_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kykbnj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kykbnl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kyak_nm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kyak_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_start_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_end_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_k_glsryo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_k_slsryo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSearch)
        Me.pnlHeader.Controls.Add(Me.txt_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_SEARCH)
        Me.pnlHeader.Controls.Add(Me.cmd_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_NEW)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1973, 90)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(783, 34)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(963, 26)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1307, 18)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'cmd_REF
        '
        Me.cmd_REF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_REF.Location = New System.Drawing.Point(433, 18)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(200, 51)
        Me.cmd_REF.TabIndex = 2
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会 / 変更(&U)"
        Me.cmd_REF.UseVisualStyleBackColor = False
        '
        'cmd_NEW
        '
        Me.cmd_NEW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_NEW.Location = New System.Drawing.Point(223, 18)
        Me.cmd_NEW.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_NEW.Name = "cmd_NEW"
        Me.cmd_NEW.Size = New System.Drawing.Size(200, 51)
        Me.cmd_NEW.TabIndex = 1
        Me.cmd_NEW.TabStop = False
        Me.cmd_NEW.Text = "新規登録(&N)"
        Me.cmd_NEW.UseVisualStyleBackColor = False
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(20, 18)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(167, 51)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'pnlFooter
        '
        Me.pnlFooter.Controls.Add(Me.cmd_EXCEL_RENEW)
        Me.pnlFooter.Controls.Add(Me.cmd_EXCEL_CHANGE)
        Me.pnlFooter.Controls.Add(Me.cmd_CSV)
        Me.pnlFooter.Controls.Add(Me.cmd_PRINT)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 841)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1973, 75)
        Me.pnlFooter.TabIndex = 1
        '
        'cmd_EXCEL_RENEW
        '
        Me.cmd_EXCEL_RENEW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_EXCEL_RENEW.Location = New System.Drawing.Point(1620, 12)
        Me.cmd_EXCEL_RENEW.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXCEL_RENEW.Name = "cmd_EXCEL_RENEW"
        Me.cmd_EXCEL_RENEW.Size = New System.Drawing.Size(333, 51)
        Me.cmd_EXCEL_RENEW.TabIndex = 3
        Me.cmd_EXCEL_RENEW.TabStop = False
        Me.cmd_EXCEL_RENEW.Text = "再リース/返却予定Excel"
        Me.cmd_EXCEL_RENEW.UseVisualStyleBackColor = True
        '
        'cmd_EXCEL_CHANGE
        '
        Me.cmd_EXCEL_CHANGE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_EXCEL_CHANGE.Location = New System.Drawing.Point(1277, 12)
        Me.cmd_EXCEL_CHANGE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXCEL_CHANGE.Name = "cmd_EXCEL_CHANGE"
        Me.cmd_EXCEL_CHANGE.Size = New System.Drawing.Size(333, 51)
        Me.cmd_EXCEL_CHANGE.TabIndex = 2
        Me.cmd_EXCEL_CHANGE.TabStop = False
        Me.cmd_EXCEL_CHANGE.Text = "契約書変更情報Excel"
        Me.cmd_EXCEL_CHANGE.UseVisualStyleBackColor = True
        '
        'cmd_CSV
        '
        Me.cmd_CSV.Location = New System.Drawing.Point(223, 12)
        Me.cmd_CSV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CSV.Name = "cmd_CSV"
        Me.cmd_CSV.Size = New System.Drawing.Size(200, 51)
        Me.cmd_CSV.TabIndex = 1
        Me.cmd_CSV.TabStop = False
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
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Text = "印刷(&R)"
        Me.cmd_PRINT.UseVisualStyleBackColor = True
        '
        'dgv_LIST
        '
        Me.dgv_LIST.AllowUserToAddRows = False
        Me.dgv_LIST.AllowUserToDeleteRows = False
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_kykh_id, Me.col_kknri1_nm, Me.col_kkbn_nm, Me.col_lcpt1_nm, Me.col_kykbnj, Me.col_kykbnl, Me.col_kyak_nm, Me.col_kyak_dt, Me.col_start_dt, Me.col_end_dt, Me.col_k_glsryo, Me.col_k_slsryo})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 90)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(1973, 751)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_kykh_id
        '
        Me.col_kykh_id.DataPropertyName = "kykh_id"
        Me.col_kykh_id.HeaderText = "ID"
        Me.col_kykh_id.MinimumWidth = 8
        Me.col_kykh_id.Name = "col_kykh_id"
        Me.col_kykh_id.ReadOnly = True
        Me.col_kykh_id.Visible = False
        Me.col_kykh_id.Width = 150
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
        'col_kkbn_nm
        '
        Me.col_kkbn_nm.DataPropertyName = "契約区分"
        Me.col_kkbn_nm.HeaderText = "契約区分"
        Me.col_kkbn_nm.MinimumWidth = 8
        Me.col_kkbn_nm.Name = "col_kkbn_nm"
        Me.col_kkbn_nm.ReadOnly = True
        Me.col_kkbn_nm.Width = 80
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
        'col_kykbnj
        '
        Me.col_kykbnj.DataPropertyName = "自社契約番号"
        Me.col_kykbnj.HeaderText = "自社契約番号"
        Me.col_kykbnj.MinimumWidth = 8
        Me.col_kykbnj.Name = "col_kykbnj"
        Me.col_kykbnj.ReadOnly = True
        Me.col_kykbnj.Width = 150
        '
        'col_kykbnl
        '
        Me.col_kykbnl.DataPropertyName = "相手契約番号"
        Me.col_kykbnl.HeaderText = "相手契約番号"
        Me.col_kykbnl.MinimumWidth = 8
        Me.col_kykbnl.Name = "col_kykbnl"
        Me.col_kykbnl.ReadOnly = True
        Me.col_kykbnl.Width = 150
        '
        'col_kyak_nm
        '
        Me.col_kyak_nm.DataPropertyName = "契約名"
        Me.col_kyak_nm.HeaderText = "契約名"
        Me.col_kyak_nm.MinimumWidth = 8
        Me.col_kyak_nm.Name = "col_kyak_nm"
        Me.col_kyak_nm.ReadOnly = True
        Me.col_kyak_nm.Width = 150
        '
        'col_kyak_dt
        '
        Me.col_kyak_dt.DataPropertyName = "契約日"
        DataGridViewCellStyle1.Format = "d"
        Me.col_kyak_dt.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_kyak_dt.HeaderText = "契約日"
        Me.col_kyak_dt.MinimumWidth = 8
        Me.col_kyak_dt.Name = "col_kyak_dt"
        Me.col_kyak_dt.ReadOnly = True
        Me.col_kyak_dt.Width = 90
        '
        'col_start_dt
        '
        Me.col_start_dt.DataPropertyName = "開始日"
        DataGridViewCellStyle2.Format = "d"
        Me.col_start_dt.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_start_dt.HeaderText = "開始日"
        Me.col_start_dt.MinimumWidth = 8
        Me.col_start_dt.Name = "col_start_dt"
        Me.col_start_dt.ReadOnly = True
        Me.col_start_dt.Width = 90
        '
        'col_end_dt
        '
        Me.col_end_dt.DataPropertyName = "終了日"
        DataGridViewCellStyle3.Format = "d"
        Me.col_end_dt.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_end_dt.HeaderText = "終了日"
        Me.col_end_dt.MinimumWidth = 8
        Me.col_end_dt.Name = "col_end_dt"
        Me.col_end_dt.ReadOnly = True
        Me.col_end_dt.Width = 90
        '
        'col_k_glsryo
        '
        Me.col_k_glsryo.DataPropertyName = "月額リース料"
        Me.col_k_glsryo.HeaderText = "月額リース料"
        Me.col_k_glsryo.MinimumWidth = 8
        Me.col_k_glsryo.Name = "col_k_glsryo"
        Me.col_k_glsryo.ReadOnly = True
        Me.col_k_glsryo.Width = 150
        '
        'col_k_slsryo
        '
        Me.col_k_slsryo.DataPropertyName = "総額リース料"
        Me.col_k_slsryo.HeaderText = "総額リース料"
        Me.col_k_slsryo.MinimumWidth = 8
        Me.col_k_slsryo.Name = "col_k_slsryo"
        Me.col_k_slsryo.ReadOnly = True
        Me.col_k_slsryo.Width = 150
        '
        'FrmContractList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1973, 916)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FrmContractList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "契約書一覧"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents cmd_NEW As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents cmd_REF As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
    Friend WithEvents cmd_EXCEL_RENEW As Button
    Friend WithEvents cmd_EXCEL_CHANGE As Button
    Friend WithEvents cmd_CSV As Button
    Friend WithEvents cmd_PRINT As Button
    Friend WithEvents col_kykh_id As DataGridViewTextBoxColumn
    Friend WithEvents col_kknri1_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_kkbn_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_lcpt1_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_kykbnj As DataGridViewTextBoxColumn
    Friend WithEvents col_kykbnl As DataGridViewTextBoxColumn
    Friend WithEvents col_kyak_nm As DataGridViewTextBoxColumn
    Friend WithEvents col_kyak_dt As DataGridViewTextBoxColumn
    Friend WithEvents col_start_dt As DataGridViewTextBoxColumn
    Friend WithEvents col_end_dt As DataGridViewTextBoxColumn
    Friend WithEvents col_k_glsryo As DataGridViewTextBoxColumn
    Friend WithEvents col_k_slsryo As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
End Class