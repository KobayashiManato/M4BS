<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_T_ZEI_KAISEI

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
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_OUTPUT_FILE = New System.Windows.Forms.Button()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_TEKI_DT_FROM = New CalendarColumn()
        Me.col_TEKI_DT_TO = New CalendarColumn()
        Me.col_ZRITU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KKYAK_DT_FROM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KKYAK_DT_TO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CREATE_DT = New CalendarColumn()
        Me.col_UPDATE_DT = New CalendarColumn()
        Me.col_CREATE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_UPDATE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_UPDATE_CNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZEI_KAISEI_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(419, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(178, 39)
        Me.cmd_OUTPUT_FILE.TabIndex = 3
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(149, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CREATE.TabIndex = 5
        Me.cmd_CREATE.TabStop = False
        Me.cmd_CREATE.Text = "登録(&T)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(284, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_DELETE.TabIndex = 6
        Me.cmd_DELETE.TabStop = False
        Me.cmd_DELETE.Text = "行削除(&D)"
        Me.cmd_DELETE.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(658, 43)
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
        Me.txt_SEARCH.Location = New System.Drawing.Point(838, 35)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1182, 27)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'dgv_LIST
        '
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_TEKI_DT_FROM, Me.col_TEKI_DT_TO, Me.col_ZRITU, Me.col_KKYAK_DT_FROM, Me.col_KKYAK_DT_TO, Me.col_CREATE_DT, Me.col_UPDATE_DT, Me.col_CREATE_ID, Me.col_UPDATE_ID, Me.col_UPDATE_CNT, Me.col_HISTORY_F, Me.col_ZEI_KAISEI_ID})
        Me.dgv_LIST.Location = New System.Drawing.Point(12, 120)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(1337, 824)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_TEKI_DT_FROM
        '
        Me.col_TEKI_DT_FROM.HeaderText = "適用日・自"
        Me.col_TEKI_DT_FROM.MinimumWidth = 8
        Me.col_TEKI_DT_FROM.Name = "col_TEKI_DT_FROM"
        Me.col_TEKI_DT_FROM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_TEKI_DT_FROM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_TEKI_DT_FROM.Width = 150
        '
        'col_TEKI_DT_TO
        '
        Me.col_TEKI_DT_TO.HeaderText = "適用日・至"
        Me.col_TEKI_DT_TO.MinimumWidth = 8
        Me.col_TEKI_DT_TO.Name = "col_TEKI_DT_TO"
        Me.col_TEKI_DT_TO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_TEKI_DT_TO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_TEKI_DT_TO.Width = 150
        '
        'col_ZRITU
        '
        Me.col_ZRITU.HeaderText = "消費税率"
        Me.col_ZRITU.MinimumWidth = 8
        Me.col_ZRITU.Name = "col_ZRITU"
        Me.col_ZRITU.Width = 150
        '
        'col_KKYAK_DT_FROM
        '
        Me.col_KKYAK_DT_FROM.HeaderText = "経過措置適用契約日・自"
        Me.col_KKYAK_DT_FROM.MinimumWidth = 8
        Me.col_KKYAK_DT_FROM.Name = "col_KKYAK_DT_FROM"
        Me.col_KKYAK_DT_FROM.Width = 150
        '
        'col_KKYAK_DT_TO
        '
        Me.col_KKYAK_DT_TO.HeaderText = "経過措置適用契約日・至"
        Me.col_KKYAK_DT_TO.MinimumWidth = 8
        Me.col_KKYAK_DT_TO.Name = "col_KKYAK_DT_TO"
        Me.col_KKYAK_DT_TO.Width = 150
        '
        'col_CREATE_DT
        '
        Me.col_CREATE_DT.HeaderText = "作成日時"
        Me.col_CREATE_DT.MinimumWidth = 8
        Me.col_CREATE_DT.Name = "col_CREATE_DT"
        Me.col_CREATE_DT.ReadOnly = True
        Me.col_CREATE_DT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_CREATE_DT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_CREATE_DT.Width = 150
        '
        'col_UPDATE_DT
        '
        Me.col_UPDATE_DT.HeaderText = "更新日時"
        Me.col_UPDATE_DT.MinimumWidth = 8
        Me.col_UPDATE_DT.Name = "col_UPDATE_DT"
        Me.col_UPDATE_DT.ReadOnly = True
        Me.col_UPDATE_DT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_UPDATE_DT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_UPDATE_DT.Width = 150
        '
        'col_CREATE_ID
        '
        Me.col_CREATE_ID.HeaderText = "CREATE_ID"
        Me.col_CREATE_ID.MinimumWidth = 8
        Me.col_CREATE_ID.Name = "col_CREATE_ID"
        Me.col_CREATE_ID.ReadOnly = True
        Me.col_CREATE_ID.Visible = False
        Me.col_CREATE_ID.Width = 150
        '
        'col_UPDATE_ID
        '
        Me.col_UPDATE_ID.HeaderText = "UPDATE_ID"
        Me.col_UPDATE_ID.MinimumWidth = 8
        Me.col_UPDATE_ID.Name = "col_UPDATE_ID"
        Me.col_UPDATE_ID.ReadOnly = True
        Me.col_UPDATE_ID.Visible = False
        Me.col_UPDATE_ID.Width = 150
        '
        'col_UPDATE_CNT
        '
        Me.col_UPDATE_CNT.HeaderText = "UPDATE_CNT"
        Me.col_UPDATE_CNT.MinimumWidth = 8
        Me.col_UPDATE_CNT.Name = "col_UPDATE_CNT"
        Me.col_UPDATE_CNT.ReadOnly = True
        Me.col_UPDATE_CNT.Visible = False
        Me.col_UPDATE_CNT.Width = 150
        '
        'col_HISTORY_F
        '
        Me.col_HISTORY_F.HeaderText = "HISTORY_F"
        Me.col_HISTORY_F.MinimumWidth = 8
        Me.col_HISTORY_F.Name = "col_HISTORY_F"
        Me.col_HISTORY_F.ReadOnly = True
        Me.col_HISTORY_F.Visible = False
        Me.col_HISTORY_F.Width = 150
        '
        'col_ZEI_KAISEI_ID
        '
        Me.col_ZEI_KAISEI_ID.HeaderText = "ZEI_KAISEI_ID"
        Me.col_ZEI_KAISEI_ID.MinimumWidth = 8
        Me.col_ZEI_KAISEI_ID.Name = "col_ZEI_KAISEI_ID"
        Me.col_ZEI_KAISEI_ID.ReadOnly = True
        Me.col_ZEI_KAISEI_ID.Visible = False
        Me.col_ZEI_KAISEI_ID.Width = 150
        '
        'Form_f_T_ZEI_KAISEI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 1200)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txt_SEARCH)
        Me.Controls.Add(Me.cmd_SEARCH)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_DELETE)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_T_ZEI_KAISEI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "消費税率テーブル"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_OUTPUT_FILE As System.Windows.Forms.Button
    Friend WithEvents cmd_CREATE As System.Windows.Forms.Button
    Friend WithEvents cmd_DELETE As System.Windows.Forms.Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents col_TEKI_DT_FROM As CalendarColumn
    Friend WithEvents col_TEKI_DT_TO As CalendarColumn
    Friend WithEvents col_ZRITU As DataGridViewTextBoxColumn
    Friend WithEvents col_KKYAK_DT_FROM As DataGridViewTextBoxColumn
    Friend WithEvents col_KKYAK_DT_TO As DataGridViewTextBoxColumn
    Friend WithEvents col_CREATE_DT As CalendarColumn
    Friend WithEvents col_UPDATE_DT As CalendarColumn
    Friend WithEvents col_CREATE_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_UPDATE_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_UPDATE_CNT As DataGridViewTextBoxColumn
    Friend WithEvents col_HISTORY_F As DataGridViewTextBoxColumn
    Friend WithEvents col_ZEI_KAISEI_ID As DataGridViewTextBoxColumn
End Class