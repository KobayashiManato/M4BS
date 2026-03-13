<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_TANA_JOKEN

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
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.txt_TANA_DATE = New System.Windows.Forms.DateTimePicker()
        Me.cmd_ZENKAI = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_EXECUTE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(64, 107)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(62, 18)
        Me.Lbl.TabIndex = 4
        Me.Lbl.Text = "棚卸日"
        '
        'ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(354, 107)
        Me.ラベル512.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.Size = New System.Drawing.Size(290, 18)
        Me.ラベル512.TabIndex = 5
        Me.ラベル512.Text = "yyyy/mm/dd の形式で入力してください"
        '
        'txt_TANA_DATE
        '
        Me.txt_TANA_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_TANA_DATE.Location = New System.Drawing.Point(153, 102)
        Me.txt_TANA_DATE.Name = "txt_TANA_DATE"
        Me.txt_TANA_DATE.Size = New System.Drawing.Size(182, 25)
        Me.txt_TANA_DATE.TabIndex = 0
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(611, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(188, 45)
        Me.cmd_ZENKAI.TabIndex = 3
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(181, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(153, 45)
        Me.cmd_CANCEL.TabIndex = 2
        Me.cmd_CANCEL.Text = "キャンセル(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_EXECUTE
        '
        Me.cmd_EXECUTE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_EXECUTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXECUTE.Name = "cmd_EXECUTE"
        Me.cmd_EXECUTE.Size = New System.Drawing.Size(157, 45)
        Me.cmd_EXECUTE.TabIndex = 1
        Me.cmd_EXECUTE.Text = "実行(&R)"
        Me.cmd_EXECUTE.UseVisualStyleBackColor = True
        '
        'Form_f_TANA_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 211)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.txt_TANA_DATE)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル512)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_TANA_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "棚卸明細表　期間設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents txt_TANA_DATE As DateTimePicker
    Friend WithEvents cmd_ZENKAI As Button
    Friend WithEvents cmd_CANCEL As Button
    Friend WithEvents cmd_EXECUTE As Button
End Class