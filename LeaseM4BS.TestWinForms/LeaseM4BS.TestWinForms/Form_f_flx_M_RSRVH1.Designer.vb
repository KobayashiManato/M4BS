<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_M_RSRVH1

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
        Me.cmd_NEW = New System.Windows.Forms.Button()
        Me.cmd_CHANGE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.txt_RSRVH1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_RSRVH1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CREATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_UPDATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_NEW)
        Me.pnlHeader.Controls.Add(Me.cmd_CHANGE)
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1537, 105)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(819, 37)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 30
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(999, 29)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1343, 21)
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
        Me.cmd_OUTPUT_FILE.TabIndex = 5
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_NEW
        '
        Me.cmd_NEW.Location = New System.Drawing.Point(177, 13)
        Me.cmd_NEW.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_NEW.Name = "cmd_NEW"
        Me.cmd_NEW.Size = New System.Drawing.Size(153, 45)
        Me.cmd_NEW.TabIndex = 4
        Me.cmd_NEW.TabStop = False
        Me.cmd_NEW.Text = "新規(&N)"
        Me.cmd_NEW.UseVisualStyleBackColor = True
        '
        'cmd_CHANGE
        '
        Me.cmd_CHANGE.Location = New System.Drawing.Point(340, 13)
        Me.cmd_CHANGE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CHANGE.Name = "cmd_CHANGE"
        Me.cmd_CHANGE.Size = New System.Drawing.Size(153, 45)
        Me.cmd_CHANGE.TabIndex = 3
        Me.cmd_CHANGE.TabStop = False
        Me.cmd_CHANGE.Text = "変更(&U)"
        Me.cmd_CHANGE.UseVisualStyleBackColor = True
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(153, 45)
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
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txt_RSRVH1_CD, Me.txt_RSRVH1_NM, Me.txt_BIKO, Me.txt_CREATE_DT, Me.txt_UPDATE_DT, Me.txt_ID})
        Me.dgv_LIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_LIST.Location = New System.Drawing.Point(0, 105)
        Me.dgv_LIST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgv_LIST.MultiSelect = False
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 21
        Me.dgv_LIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_LIST.Size = New System.Drawing.Size(1537, 737)
        Me.dgv_LIST.TabIndex = 0
        '
        'txt_RSRVH1_CD
        '
        Me.txt_RSRVH1_CD.DataPropertyName = "RSRVH1_CD"
        Me.txt_RSRVH1_CD.HeaderText = "RSRVH1_CD"
        Me.txt_RSRVH1_CD.MinimumWidth = 8
        Me.txt_RSRVH1_CD.Name = "txt_RSRVH1_CD"
        Me.txt_RSRVH1_CD.ReadOnly = True
        Me.txt_RSRVH1_CD.Width = 79
        '
        'txt_RSRVH1_NM
        '
        Me.txt_RSRVH1_NM.DataPropertyName = "RSRVH1_NM"
        Me.txt_RSRVH1_NM.HeaderText = "RSRVH1_NM"
        Me.txt_RSRVH1_NM.MinimumWidth = 8
        Me.txt_RSRVH1_NM.Name = "txt_RSRVH1_NM"
        Me.txt_RSRVH1_NM.ReadOnly = True
        Me.txt_RSRVH1_NM.Width = 151
        '
        'txt_BIKO
        '
        Me.txt_BIKO.DataPropertyName = "BIKO"
        Me.txt_BIKO.HeaderText = "BIKO"
        Me.txt_BIKO.MinimumWidth = 8
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.ReadOnly = True
        Me.txt_BIKO.Width = 151
        '
        'txt_CREATE_DT
        '
        Me.txt_CREATE_DT.DataPropertyName = "CREATE_DT"
        Me.txt_CREATE_DT.HeaderText = "CREATE_DT"
        Me.txt_CREATE_DT.MinimumWidth = 8
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Width = 124
        '
        'txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.DataPropertyName = "UPDATE_DT"
        Me.txt_UPDATE_DT.HeaderText = "UPDATE_DT"
        Me.txt_UPDATE_DT.MinimumWidth = 8
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Width = 124
        '
        'txt_ID
        '
        Me.txt_ID.DataPropertyName = "ID"
        Me.txt_ID.HeaderText = "ID"
        Me.txt_ID.MinimumWidth = 8
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Width = 60
        '
        'Form_f_flx_M_RSRVH1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1537, 842)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_flx_M_RSRVH1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "品目マスタ"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_CHANGE As System.Windows.Forms.Button
    Friend WithEvents cmd_NEW As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents dgv_LIST As System.Windows.Forms.DataGridView
    Friend WithEvents txt_RSRVH1_CD As DataGridViewTextBoxColumn
    Friend WithEvents txt_RSRVH1_NM As DataGridViewTextBoxColumn
    Friend WithEvents txt_BIKO As DataGridViewTextBoxColumn
    Friend WithEvents txt_CREATE_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_UPDATE_DT As DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
End Class