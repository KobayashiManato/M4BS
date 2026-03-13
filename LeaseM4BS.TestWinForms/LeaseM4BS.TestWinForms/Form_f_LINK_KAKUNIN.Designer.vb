<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_LINK_KAKUNIN

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
        Me.cmd_LINK_DEL = New System.Windows.Forms.Button()
        Me.txt_DBNAME = New System.Windows.Forms.TextBox()
        Me.ラベル86 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(18, 18)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        ' cmd_LINK_DEL
        '
        Me.cmd_LINK_DEL.Location = New System.Drawing.Point(498, 75)
        Me.cmd_LINK_DEL.Name = "cmd_LINK_DEL"
        Me.cmd_LINK_DEL.Size = New System.Drawing.Size(75, 23)
        Me.cmd_LINK_DEL.TabIndex = 1
        Me.cmd_LINK_DEL.Text = "解除(&D)"
        Me.cmd_LINK_DEL.UseVisualStyleBackColor = True
        '
        ' txt_DBNAME
        '
        Me.txt_DBNAME.Location = New System.Drawing.Point(169, 75)
        Me.txt_DBNAME.Name = "txt_DBNAME"
        Me.txt_DBNAME.Size = New System.Drawing.Size(321, 22)
        Me.txt_DBNAME.TabIndex = 2
        '
        ' ラベル86
        '
        Me.ラベル86.AutoSize = True
        Me.ラベル86.Location = New System.Drawing.Point(37, 75)
        Me.ラベル86.Name = "ラベル86"
        Me.ラベル86.TabIndex = 3
        Me.ラベル86.Text = "接続先データベース"
        '
        ' Form_f_LINK_KAKUNIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 541)
        Me.Controls.Add(Me.ラベル86)
        Me.Controls.Add(Me.txt_DBNAME)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_LINK_DEL)
        Me.Name = "Form_f_LINK_KAKUNIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "リンク先の確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_LINK_DEL As System.Windows.Forms.Button
    Friend WithEvents txt_DBNAME As System.Windows.Forms.TextBox
    Friend WithEvents ラベル86 As System.Windows.Forms.Label

End Class