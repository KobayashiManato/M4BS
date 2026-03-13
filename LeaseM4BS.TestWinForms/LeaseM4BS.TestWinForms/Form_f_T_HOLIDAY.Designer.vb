<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_T_HOLIDAY

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
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.ラベル929 = New System.Windows.Forms.Label()
        Me.lbl_BIKO = New System.Windows.Forms.Label()
        Me.lbl_DATE = New System.Windows.Forms.Label()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_H_DATE = New CalendarColumn()
        Me.col_BIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(149, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CREATE.TabIndex = 1
        Me.cmd_CREATE.Text = "登録(&T)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(284, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_DELETE.TabIndex = 2
        Me.cmd_DELETE.Text = "行削除(&D)"
        Me.cmd_DELETE.UseVisualStyleBackColor = True
        '
        'ラベル929
        '
        Me.ラベル929.AutoSize = True
        Me.ラベル929.Location = New System.Drawing.Point(30, 74)
        Me.ラベル929.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル929.Name = "ラベル929"
        Me.ラベル929.Size = New System.Drawing.Size(235, 18)
        Me.ラベル929.TabIndex = 8
        Me.ラベル929.Text = "土日以外の休日を設定します。"
        '
        'lbl_BIKO
        '
        Me.lbl_BIKO.AutoSize = True
        Me.lbl_BIKO.Location = New System.Drawing.Point(174, 139)
        Me.lbl_BIKO.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_BIKO.Name = "lbl_BIKO"
        Me.lbl_BIKO.Size = New System.Drawing.Size(44, 18)
        Me.lbl_BIKO.TabIndex = 7
        Me.lbl_BIKO.Text = "備考"
        '
        'lbl_DATE
        '
        Me.lbl_DATE.AutoSize = True
        Me.lbl_DATE.Location = New System.Drawing.Point(30, 139)
        Me.lbl_DATE.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_DATE.Name = "lbl_DATE"
        Me.lbl_DATE.Size = New System.Drawing.Size(44, 18)
        Me.lbl_DATE.TabIndex = 6
        Me.lbl_DATE.Text = "日付"
        '
        'dgv_LIST
        '
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_H_DATE, Me.col_BIKO, Me.col_ID})
        Me.dgv_LIST.Location = New System.Drawing.Point(14, 182)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(574, 162)
        Me.dgv_LIST.TabIndex = 9
        '
        'col_H_DATE
        '
        Me.col_H_DATE.HeaderText = "祝日"
        Me.col_H_DATE.MinimumWidth = 8
        Me.col_H_DATE.Name = "col_H_DATE"
        Me.col_H_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_H_DATE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_H_DATE.Width = 150
        '
        'col_BIKO
        '
        Me.col_BIKO.HeaderText = "備考"
        Me.col_BIKO.MinimumWidth = 8
        Me.col_BIKO.Name = "col_BIKO"
        Me.col_BIKO.Width = 150
        '
        'col_ID
        '
        Me.col_ID.HeaderText = "ID"
        Me.col_ID.MinimumWidth = 8
        Me.col_ID.Name = "col_ID"
        Me.col_ID.Visible = False
        Me.col_ID.Width = 150
        '
        'Form_f_T_HOLIDAY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 647)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.lbl_DATE)
        Me.Controls.Add(Me.lbl_BIKO)
        Me.Controls.Add(Me.ラベル929)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_DELETE)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_T_HOLIDAY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "祝日テーブル"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_CREATE As System.Windows.Forms.Button
    Friend WithEvents cmd_DELETE As System.Windows.Forms.Button
    Friend WithEvents ラベル929 As System.Windows.Forms.Label
    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents lbl_BIKO As Label
    Friend WithEvents lbl_DATE As Label
    Friend WithEvents col_H_DATE As CalendarColumn
    Friend WithEvents col_BIKO As DataGridViewTextBoxColumn
    Friend WithEvents col_ID As DataGridViewTextBoxColumn
End Class