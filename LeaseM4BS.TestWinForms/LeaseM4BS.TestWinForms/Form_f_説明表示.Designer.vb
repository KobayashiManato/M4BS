<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_説明表示

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
        Me.cmd_Close = New System.Windows.Forms.Button()
        Me.txt_HYOJ_TEXT = New System.Windows.Forms.TextBox()
        Me.txt_TOPICS = New System.Windows.Forms.TextBox()
        Me.txt_HYOJ_KIND = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        ' cmd_Close
        '
        Me.cmd_Close.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Close.Name = "cmd_Close"
        Me.cmd_Close.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Close.TabIndex = 0
        Me.cmd_Close.Text = "閉じる(&C)"
        Me.cmd_Close.UseVisualStyleBackColor = True
        '
        ' txt_HYOJ_TEXT
        '
        Me.txt_HYOJ_TEXT.Location = New System.Drawing.Point(18, 0)
        Me.txt_HYOJ_TEXT.Name = "txt_HYOJ_TEXT"
        Me.txt_HYOJ_TEXT.Size = New System.Drawing.Size(548, 19)
        Me.txt_HYOJ_TEXT.TabIndex = 1
        '
        ' txt_TOPICS
        '
        Me.txt_TOPICS.Location = New System.Drawing.Point(415, 0)
        Me.txt_TOPICS.Name = "txt_TOPICS"
        Me.txt_TOPICS.Size = New System.Drawing.Size(50, 19)
        Me.txt_TOPICS.TabIndex = 2
        '
        ' txt_HYOJ_KIND
        '
        Me.txt_HYOJ_KIND.Location = New System.Drawing.Point(377, 0)
        Me.txt_HYOJ_KIND.Name = "txt_HYOJ_KIND"
        Me.txt_HYOJ_KIND.Size = New System.Drawing.Size(50, 19)
        Me.txt_HYOJ_KIND.TabIndex = 3
        '
        ' Form_f_説明表示
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 800)
        Me.Controls.Add(Me.txt_HYOJ_TEXT)
        Me.Controls.Add(Me.txt_TOPICS)
        Me.Controls.Add(Me.txt_HYOJ_KIND)
        Me.Controls.Add(Me.cmd_Close)
        Me.Name = "Form_f_説明表示"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Close As System.Windows.Forms.Button
    Friend WithEvents txt_HYOJ_TEXT As System.Windows.Forms.TextBox
    Friend WithEvents txt_TOPICS As System.Windows.Forms.TextBox
    Friend WithEvents txt_HYOJ_KIND As System.Windows.Forms.TextBox

End Class