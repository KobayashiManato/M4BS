<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_CHANGE_PASSWORD

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
        Me.txt_NEW_PWD = New System.Windows.Forms.TextBox()
        Me.txt_NEW_PWD_RETRY = New System.Windows.Forms.TextBox()
        Me.txt_OLD_PWD = New System.Windows.Forms.TextBox()
        Me.txt_USER_CD = New System.Windows.Forms.TextBox()
        Me.txt_USER_NM = New System.Windows.Forms.TextBox()
        Me.ラベル82 = New System.Windows.Forms.Label()
        Me.ラベル96 = New System.Windows.Forms.Label()
        Me.ラベル98 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル38 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Jikko
        '
        Me.cmd_Jikko.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Jikko.Name = "cmd_Jikko"
        Me.cmd_Jikko.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Jikko.TabIndex = 0
        Me.cmd_Jikko.Text = "実行(&R)"
        Me.cmd_Jikko.UseVisualStyleBackColor = True
        '
        ' cmd_Cancel
        '
        Me.cmd_Cancel.Location = New System.Drawing.Point(86, 3)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        ' txt_NEW_PWD
        '
        Me.txt_NEW_PWD.Location = New System.Drawing.Point(151, 147)
        Me.txt_NEW_PWD.Name = "txt_NEW_PWD"
        Me.txt_NEW_PWD.Size = New System.Drawing.Size(150, 19)
        Me.txt_NEW_PWD.TabIndex = 2
        '
        ' txt_NEW_PWD_RETRY
        '
        Me.txt_NEW_PWD_RETRY.Location = New System.Drawing.Point(151, 177)
        Me.txt_NEW_PWD_RETRY.Name = "txt_NEW_PWD_RETRY"
        Me.txt_NEW_PWD_RETRY.Size = New System.Drawing.Size(150, 19)
        Me.txt_NEW_PWD_RETRY.TabIndex = 3
        '
        ' txt_OLD_PWD
        '
        Me.txt_OLD_PWD.Location = New System.Drawing.Point(151, 117)
        Me.txt_OLD_PWD.Name = "txt_OLD_PWD"
        Me.txt_OLD_PWD.Size = New System.Drawing.Size(150, 19)
        Me.txt_OLD_PWD.TabIndex = 4
        '
        ' txt_USER_CD
        '
        Me.txt_USER_CD.Location = New System.Drawing.Point(151, 56)
        Me.txt_USER_CD.Name = "txt_USER_CD"
        Me.txt_USER_CD.Size = New System.Drawing.Size(94, 19)
        Me.txt_USER_CD.TabIndex = 5
        '
        ' txt_USER_NM
        '
        Me.txt_USER_NM.Location = New System.Drawing.Point(151, 86)
        Me.txt_USER_NM.Name = "txt_USER_NM"
        Me.txt_USER_NM.Size = New System.Drawing.Size(264, 19)
        Me.txt_USER_NM.TabIndex = 6
        '
        ' ラベル82
        '
        Me.ラベル82.AutoSize = True
        Me.ラベル82.Location = New System.Drawing.Point(37, 147)
        Me.ラベル82.Name = "ラベル82"
        Me.ラベル82.TabIndex = 7
        Me.ラベル82.Text = "新ﾊﾟｽﾜｰﾄﾞ"
        '
        ' ラベル96
        '
        Me.ラベル96.AutoSize = True
        Me.ラベル96.Location = New System.Drawing.Point(37, 177)
        Me.ラベル96.Name = "ラベル96"
        Me.ラベル96.TabIndex = 8
        Me.ラベル96.Text = "新ﾊﾟｽﾜｰﾄﾞ（確認）"
        '
        ' ラベル98
        '
        Me.ラベル98.AutoSize = True
        Me.ラベル98.Location = New System.Drawing.Point(37, 117)
        Me.ラベル98.Name = "ラベル98"
        Me.ラベル98.TabIndex = 9
        Me.ラベル98.Text = "旧ﾊﾟｽﾜｰﾄﾞ"
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(37, 56)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 10
        Me.Lbl.Text = "利用者ｺｰﾄﾞ"
        '
        ' ラベル38
        '
        Me.ラベル38.AutoSize = True
        Me.ラベル38.Location = New System.Drawing.Point(37, 86)
        Me.ラベル38.Name = "ラベル38"
        Me.ラベル38.TabIndex = 11
        Me.ラベル38.Text = "利用者名"
        '
        ' Form_f_CHANGE_PASSWORD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 410)
        Me.Controls.Add(Me.ラベル82)
        Me.Controls.Add(Me.ラベル96)
        Me.Controls.Add(Me.ラベル98)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル38)
        Me.Controls.Add(Me.txt_NEW_PWD)
        Me.Controls.Add(Me.txt_NEW_PWD_RETRY)
        Me.Controls.Add(Me.txt_OLD_PWD)
        Me.Controls.Add(Me.txt_USER_CD)
        Me.Controls.Add(Me.txt_USER_NM)
        Me.Controls.Add(Me.cmd_Jikko)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Name = "Form_f_CHANGE_PASSWORD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "利用者パスワードの変更"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Jikko As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents txt_NEW_PWD As System.Windows.Forms.TextBox
    Friend WithEvents txt_NEW_PWD_RETRY As System.Windows.Forms.TextBox
    Friend WithEvents txt_OLD_PWD As System.Windows.Forms.TextBox
    Friend WithEvents txt_USER_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_USER_NM As System.Windows.Forms.TextBox
    Friend WithEvents ラベル82 As System.Windows.Forms.Label
    Friend WithEvents ラベル96 As System.Windows.Forms.Label
    Friend WithEvents ラベル98 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル38 As System.Windows.Forms.Label

End Class