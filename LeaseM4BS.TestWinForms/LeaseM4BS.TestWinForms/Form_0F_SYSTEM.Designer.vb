<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_0F_SYSTEM

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
        Me.cmd_Start = New System.Windows.Forms.Button()
        Me.txt_PWD = New System.Windows.Forms.TextBox()
        Me.ラベル22 = New System.Windows.Forms.Label()
        Me.ラベル9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Start
        '
        Me.cmd_Start.Location = New System.Drawing.Point(102, 75)
        Me.cmd_Start.Name = "cmd_Start"
        Me.cmd_Start.Size = New System.Drawing.Size(189, 23)
        Me.cmd_Start.TabIndex = 0
        Me.cmd_Start.Text = "開始"
        Me.cmd_Start.UseVisualStyleBackColor = True
        '
        ' txt_PWD
        '
        Me.txt_PWD.Location = New System.Drawing.Point(102, 41)
        Me.txt_PWD.Name = "txt_PWD"
        Me.txt_PWD.Size = New System.Drawing.Size(188, 19)
        Me.txt_PWD.TabIndex = 1
        '
        ' ラベル22
        '
        Me.ラベル22.AutoSize = True
        Me.ラベル22.Location = New System.Drawing.Point(18, 41)
        Me.ラベル22.Name = "ラベル22"
        Me.ラベル22.TabIndex = 2
        Me.ラベル22.Text = "パスワード"
        '
        ' ラベル9
        '
        Me.ラベル9.AutoSize = True
        Me.ラベル9.Location = New System.Drawing.Point(18, 7)
        Me.ラベル9.Name = "ラベル9"
        Me.ラベル9.TabIndex = 3
        Me.ラベル9.Text = "AutoExecマクロを実行を先に実行して下さい。\015\012"
        '
        ' Form_0F_SYSTEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 213)
        Me.Controls.Add(Me.ラベル22)
        Me.Controls.Add(Me.ラベル9)
        Me.Controls.Add(Me.txt_PWD)
        Me.Controls.Add(Me.cmd_Start)
        Me.Name = "Form_0F_SYSTEM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "開始"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Start As System.Windows.Forms.Button
    Friend WithEvents txt_PWD As System.Windows.Forms.TextBox
    Friend WithEvents ラベル22 As System.Windows.Forms.Label
    Friend WithEvents ラベル9 As System.Windows.Forms.Label

End Class