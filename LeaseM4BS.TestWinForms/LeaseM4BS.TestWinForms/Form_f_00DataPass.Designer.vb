<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_00DataPass

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
        Me.txt_OLD_PWD = New System.Windows.Forms.TextBox()
        Me.txt_NEW_PWD = New System.Windows.Forms.TextBox()
        Me.txt_NEW_PWD_RETRY = New System.Windows.Forms.TextBox()
        Me.ラベル81 = New System.Windows.Forms.Label()
        Me.ラベル82 = New System.Windows.Forms.Label()
        Me.ラベル88 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Jikko
        '
        Me.cmd_Jikko.Location = New System.Drawing.Point(7, 7)
        Me.cmd_Jikko.Name = "cmd_Jikko"
        Me.cmd_Jikko.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Jikko.TabIndex = 0
        Me.cmd_Jikko.Text = "実行"
        Me.cmd_Jikko.UseVisualStyleBackColor = True
        '
        ' cmd_Cancel
        '
        Me.cmd_Cancel.Location = New System.Drawing.Point(90, 7)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "ｷｬﾝｾﾙ"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        ' txt_OLD_PWD
        '
        Me.txt_OLD_PWD.Location = New System.Drawing.Point(132, 45)
        Me.txt_OLD_PWD.Name = "txt_OLD_PWD"
        Me.txt_OLD_PWD.Size = New System.Drawing.Size(151, 19)
        Me.txt_OLD_PWD.TabIndex = 2
        '
        ' txt_NEW_PWD
        '
        Me.txt_NEW_PWD.Location = New System.Drawing.Point(132, 75)
        Me.txt_NEW_PWD.Name = "txt_NEW_PWD"
        Me.txt_NEW_PWD.Size = New System.Drawing.Size(151, 19)
        Me.txt_NEW_PWD.TabIndex = 3
        '
        ' txt_NEW_PWD_RETRY
        '
        Me.txt_NEW_PWD_RETRY.Location = New System.Drawing.Point(132, 105)
        Me.txt_NEW_PWD_RETRY.Name = "txt_NEW_PWD_RETRY"
        Me.txt_NEW_PWD_RETRY.Size = New System.Drawing.Size(151, 19)
        Me.txt_NEW_PWD_RETRY.TabIndex = 4
        '
        ' ラベル81
        '
        Me.ラベル81.AutoSize = True
        Me.ラベル81.Location = New System.Drawing.Point(18, 45)
        Me.ラベル81.Name = "ラベル81"
        Me.ラベル81.TabIndex = 5
        Me.ラベル81.Text = "古いﾊﾟｽﾜｰﾄﾞﾞ"
        '
        ' ラベル82
        '
        Me.ラベル82.AutoSize = True
        Me.ラベル82.Location = New System.Drawing.Point(18, 75)
        Me.ラベル82.Name = "ラベル82"
        Me.ラベル82.TabIndex = 6
        Me.ラベル82.Text = "新しいﾊﾟｽﾜｰﾄﾞ"
        '
        ' ラベル88
        '
        Me.ラベル88.AutoSize = True
        Me.ラベル88.Location = New System.Drawing.Point(18, 105)
        Me.ラベル88.Name = "ラベル88"
        Me.ラベル88.TabIndex = 7
        Me.ラベル88.Text = "新ﾊﾟｽﾜｰﾄﾞ（確認）"
        '
        ' Form_f_00DataPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 287)
        Me.Controls.Add(Me.ラベル81)
        Me.Controls.Add(Me.ラベル82)
        Me.Controls.Add(Me.ラベル88)
        Me.Controls.Add(Me.txt_OLD_PWD)
        Me.Controls.Add(Me.txt_NEW_PWD)
        Me.Controls.Add(Me.txt_NEW_PWD_RETRY)
        Me.Controls.Add(Me.cmd_Jikko)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Name = "Form_f_00DataPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "データパスワード設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Jikko As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents txt_OLD_PWD As System.Windows.Forms.TextBox
    Friend WithEvents txt_NEW_PWD As System.Windows.Forms.TextBox
    Friend WithEvents txt_NEW_PWD_RETRY As System.Windows.Forms.TextBox
    Friend WithEvents ラベル81 As System.Windows.Forms.Label
    Friend WithEvents ラベル82 As System.Windows.Forms.Label
    Friend WithEvents ラベル88 As System.Windows.Forms.Label

End Class