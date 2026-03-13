<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_LOGIN_JET

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
        Me.txt_USER_CD = New System.Windows.Forms.TextBox()
        Me.txt_PWD = New System.Windows.Forms.TextBox()
        Me.txt_PATH = New System.Windows.Forms.TextBox()
        Me.txt_USER_CD_SAVE = New System.Windows.Forms.TextBox()
        Me.ラベル81 = New System.Windows.Forms.Label()
        Me.ラベル82 = New System.Windows.Forms.Label()
        Me.ラベル88 = New System.Windows.Forms.Label()
        Me.ラベル94 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Jikko
        '
        Me.cmd_Jikko.Location = New System.Drawing.Point(18, 18)
        Me.cmd_Jikko.Name = "cmd_Jikko"
        Me.cmd_Jikko.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Jikko.TabIndex = 0
        Me.cmd_Jikko.Text = "実行(&R)"
        Me.cmd_Jikko.UseVisualStyleBackColor = True
        '
        ' cmd_Cancel
        '
        Me.cmd_Cancel.Location = New System.Drawing.Point(102, 18)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        ' txt_USER_CD
        '
        Me.txt_USER_CD.Location = New System.Drawing.Point(170, 75)
        Me.txt_USER_CD.Name = "txt_USER_CD"
        Me.txt_USER_CD.Size = New System.Drawing.Size(151, 22)
        Me.txt_USER_CD.TabIndex = 2
        '
        ' txt_PWD
        '
        Me.txt_PWD.Location = New System.Drawing.Point(170, 113)
        Me.txt_PWD.Name = "txt_PWD"
        Me.txt_PWD.Size = New System.Drawing.Size(151, 22)
        Me.txt_PWD.TabIndex = 3
        '
        ' txt_PATH
        '
        Me.txt_PATH.Location = New System.Drawing.Point(170, 177)
        Me.txt_PATH.Name = "txt_PATH"
        Me.txt_PATH.Size = New System.Drawing.Size(378, 22)
        Me.txt_PATH.TabIndex = 4
        '
        ' txt_USER_CD_SAVE
        '
        Me.txt_USER_CD_SAVE.Location = New System.Drawing.Point(332, 79)
        Me.txt_USER_CD_SAVE.Name = "txt_USER_CD_SAVE"
        Me.txt_USER_CD_SAVE.Size = New System.Drawing.Size(50, 19)
        Me.txt_USER_CD_SAVE.TabIndex = 5
        '
        ' ラベル81
        '
        Me.ラベル81.AutoSize = True
        Me.ラベル81.Location = New System.Drawing.Point(37, 75)
        Me.ラベル81.Name = "ラベル81"
        Me.ラベル81.TabIndex = 6
        Me.ラベル81.Text = "利用者ｺｰﾄﾞ"
        '
        ' ラベル82
        '
        Me.ラベル82.AutoSize = True
        Me.ラベル82.Location = New System.Drawing.Point(37, 113)
        Me.ラベル82.Name = "ラベル82"
        Me.ラベル82.TabIndex = 7
        Me.ラベル82.Text = "ﾊﾟｽﾜｰﾄﾞ"
        '
        ' ラベル88
        '
        Me.ラベル88.AutoSize = True
        Me.ラベル88.Location = New System.Drawing.Point(37, 177)
        Me.ラベル88.Name = "ラベル88"
        Me.ラベル88.TabIndex = 8
        Me.ラベル88.Text = "ﾃﾞｰﾀﾌｧｲﾙ"
        '
        ' ラベル94
        '
        Me.ラベル94.AutoSize = True
        Me.ラベル94.Location = New System.Drawing.Point(37, 154)
        Me.ラベル94.Name = "ラベル94"
        Me.ラベル94.TabIndex = 9
        Me.ラベル94.Text = "利用者ｺｰﾄﾞの記録"
        '
        ' Form_f_LOGIN_JET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 354)
        Me.Controls.Add(Me.ラベル81)
        Me.Controls.Add(Me.ラベル82)
        Me.Controls.Add(Me.ラベル88)
        Me.Controls.Add(Me.ラベル94)
        Me.Controls.Add(Me.txt_USER_CD)
        Me.Controls.Add(Me.txt_PWD)
        Me.Controls.Add(Me.txt_PATH)
        Me.Controls.Add(Me.txt_USER_CD_SAVE)
        Me.Controls.Add(Me.cmd_Jikko)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Name = "Form_f_LOGIN_JET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "リースＭ４ＢＳ　ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Jikko As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents txt_USER_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_PWD As System.Windows.Forms.TextBox
    Friend WithEvents txt_PATH As System.Windows.Forms.TextBox
    Friend WithEvents txt_USER_CD_SAVE As System.Windows.Forms.TextBox
    Friend WithEvents ラベル81 As System.Windows.Forms.Label
    Friend WithEvents ラベル82 As System.Windows.Forms.Label
    Friend WithEvents ラベル88 As System.Windows.Forms.Label
    Friend WithEvents ラベル94 As System.Windows.Forms.Label

End Class