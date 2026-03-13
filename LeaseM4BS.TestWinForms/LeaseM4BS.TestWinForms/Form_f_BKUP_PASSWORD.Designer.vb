<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_BKUP_PASSWORD

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
        Me.cmd_Jikko = New System.Windows.Forms.Button()
        Me.cmd_Cancel = New System.Windows.Forms.Button()
        Me.txt_PWD = New System.Windows.Forms.TextBox()
        Me.txt_PWD_RETRY = New System.Windows.Forms.TextBox()
        Me.ラベル96 = New System.Windows.Forms.Label()
        Me.ラベル100 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Jikko
        '
        Me.cmd_Jikko.Location = New System.Drawing.Point(196, 3)
        Me.cmd_Jikko.Name = "cmd_Jikko"
        Me.cmd_Jikko.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Jikko.TabIndex = 0
        Me.cmd_Jikko.Text = "実行(&R)"
        Me.cmd_Jikko.UseVisualStyleBackColor = True
        '
        ' cmd_Cancel
        '
        Me.cmd_Cancel.Location = New System.Drawing.Point(196, 37)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        ' txt_PWD
        '
        Me.txt_PWD.Location = New System.Drawing.Point(7, 22)
        Me.txt_PWD.Name = "txt_PWD"
        Me.txt_PWD.Size = New System.Drawing.Size(181, 19)
        Me.txt_PWD.TabIndex = 2
        '
        ' txt_PWD_RETRY
        '
        Me.txt_PWD_RETRY.Location = New System.Drawing.Point(7, 68)
        Me.txt_PWD_RETRY.Name = "txt_PWD_RETRY"
        Me.txt_PWD_RETRY.Size = New System.Drawing.Size(181, 19)
        Me.txt_PWD_RETRY.TabIndex = 3
        '
        ' ラベル96
        '
        Me.ラベル96.AutoSize = True
        Me.ラベル96.Location = New System.Drawing.Point(7, 49)
        Me.ラベル96.Name = "ラベル96"
        Me.ラベル96.TabIndex = 4
        Me.ラベル96.Text = "ﾊﾟｽﾜｰﾄﾞ（確認）"
        '
        ' ラベル100
        '
        Me.ラベル100.AutoSize = True
        Me.ラベル100.Location = New System.Drawing.Point(7, 3)
        Me.ラベル100.Name = "ラベル100"
        Me.ラベル100.TabIndex = 5
        Me.ラベル100.Text = "ﾊﾟｽﾜｰﾄﾞ"
        '
        ' Form_f_BKUP_PASSWORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.ラベル96)
        Me.Controls.Add(Me.ラベル100)
        Me.Controls.Add(Me.txt_PWD)
        Me.Controls.Add(Me.txt_PWD_RETRY)
        Me.Controls.Add(Me.cmd_Jikko)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Name = "Form_f_BKUP_PASSWORD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "保存用MDBのパスワード指定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Jikko As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents txt_PWD As System.Windows.Forms.TextBox
    Friend WithEvents txt_PWD_RETRY As System.Windows.Forms.TextBox
    Friend WithEvents ラベル96 As System.Windows.Forms.Label
    Friend WithEvents ラベル100 As System.Windows.Forms.Label

End Class