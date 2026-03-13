<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_返済SCH_JOKEN_FROM注記判定画面

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
        Me.cmd_実行 = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.ラベル473 = New System.Windows.Forms.Label()
        Me.lbl_RCALC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(86, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' ラベル473
        '
        Me.ラベル473.AutoSize = True
        Me.ラベル473.Location = New System.Drawing.Point(37, 56)
        Me.ラベル473.Name = "ラベル473"
        Me.ラベル473.TabIndex = 2
        Me.ラベル473.Text = "償却方法"
        '
        ' lbl_RCALC
        '
        Me.lbl_RCALC.AutoSize = True
        Me.lbl_RCALC.Location = New System.Drawing.Point(37, 86)
        Me.lbl_RCALC.Name = "lbl_RCALC"
        Me.lbl_RCALC.TabIndex = 3
        Me.lbl_RCALC.Text = "利息計算"
        '
        ' Form_f_返済SCH_JOKEN_FROM注記判定画面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 568)
        Me.Controls.Add(Me.ラベル473)
        Me.Controls.Add(Me.lbl_RCALC)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_返済SCH_JOKEN_FROM注記判定画面"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "返済スケジュール 条件設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents ラベル473 As System.Windows.Forms.Label
    Friend WithEvents lbl_RCALC As System.Windows.Forms.Label

End Class