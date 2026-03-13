<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_ZENKAI_LOG
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_KIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_NAIYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ROW_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_VALUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 2
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'dgv_LIST
        '
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_KIND, Me.col_NAIYO, Me.col_NM, Me.col_ROW_NO, Me.col_VALUE})
        Me.dgv_LIST.EnableHeadersVisualStyles = False
        Me.dgv_LIST.Location = New System.Drawing.Point(14, 85)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(1520, 526)
        Me.dgv_LIST.TabIndex = 3
        '
        'col_KIND
        '
        Me.col_KIND.HeaderText = "種別"
        Me.col_KIND.MinimumWidth = 8
        Me.col_KIND.Name = "col_KIND"
        Me.col_KIND.Width = 150
        '
        'col_NAIYO
        '
        Me.col_NAIYO.HeaderText = "内容"
        Me.col_NAIYO.MinimumWidth = 8
        Me.col_NAIYO.Name = "col_NAIYO"
        Me.col_NAIYO.Width = 150
        '
        'col_NM
        '
        Me.col_NM.HeaderText = "項目名"
        Me.col_NM.MinimumWidth = 8
        Me.col_NM.Name = "col_NM"
        Me.col_NM.Width = 150
        '
        'col_ROW_NO
        '
        Me.col_ROW_NO.HeaderText = "行番号"
        Me.col_ROW_NO.MinimumWidth = 8
        Me.col_ROW_NO.Name = "col_ROW_NO"
        Me.col_ROW_NO.Width = 150
        '
        'col_VALUE
        '
        Me.col_VALUE.HeaderText = "値"
        Me.col_VALUE.MinimumWidth = 8
        Me.col_VALUE.Name = "col_VALUE"
        Me.col_VALUE.Width = 150
        '
        'Form_f_SAI_LEASE_LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1546, 626)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Name = "Form_f_SAI_LEASE_LOG"
        Me.Text = "Form_f_SAI_LEASE_LOG"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents col_KIND As DataGridViewTextBoxColumn
    Friend WithEvents col_NAIYO As DataGridViewTextBoxColumn
    Friend WithEvents col_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_ROW_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_VALUE As DataGridViewTextBoxColumn
End Class
