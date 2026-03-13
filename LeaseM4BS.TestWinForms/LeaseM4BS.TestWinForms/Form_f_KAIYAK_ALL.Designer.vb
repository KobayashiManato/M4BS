<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_KAIYAK_ALL

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
        Me.txt_CKAIYK_DT = New System.Windows.Forms.TextBox()
        Me.txt_CKAIYK_ESDT_T = New System.Windows.Forms.TextBox()
        Me.Lbl中途解約日 = New System.Windows.Forms.Label()
        Me.Lbl解約最終支払日 = New System.Windows.Forms.Label()
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
        Me.cmd_CANCEL.Location = New System.Drawing.Point(90, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.Location = New System.Drawing.Point(151, 60)
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.Size = New System.Drawing.Size(75, 19)
        Me.txt_CKAIYK_DT.TabIndex = 2
        '
        ' txt_CKAIYK_ESDT_T
        '
        Me.txt_CKAIYK_ESDT_T.Location = New System.Drawing.Point(151, 98)
        Me.txt_CKAIYK_ESDT_T.Name = "txt_CKAIYK_ESDT_T"
        Me.txt_CKAIYK_ESDT_T.Size = New System.Drawing.Size(75, 19)
        Me.txt_CKAIYK_ESDT_T.TabIndex = 3
        '
        ' Lbl中途解約日
        '
        Me.Lbl中途解約日.AutoSize = True
        Me.Lbl中途解約日.Location = New System.Drawing.Point(37, 60)
        Me.Lbl中途解約日.Name = "Lbl中途解約日"
        Me.Lbl中途解約日.TabIndex = 4
        Me.Lbl中途解約日.Text = "中途解約日"
        '
        ' Lbl解約最終支払日
        '
        Me.Lbl解約最終支払日.AutoSize = True
        Me.Lbl解約最終支払日.Location = New System.Drawing.Point(37, 98)
        Me.Lbl解約最終支払日.Name = "Lbl解約最終支払日"
        Me.Lbl解約最終支払日.TabIndex = 5
        Me.Lbl解約最終支払日.Text = "最終支払日・定額"
        '
        ' Form_f_KAIYAK_ALL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 595)
        Me.Controls.Add(Me.Lbl中途解約日)
        Me.Controls.Add(Me.Lbl解約最終支払日)
        Me.Controls.Add(Me.txt_CKAIYK_DT)
        Me.Controls.Add(Me.txt_CKAIYK_ESDT_T)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_KAIYAK_ALL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "一括中途解約"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_CKAIYK_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_CKAIYK_ESDT_T As System.Windows.Forms.TextBox
    Friend WithEvents Lbl中途解約日 As System.Windows.Forms.Label
    Friend WithEvents Lbl解約最終支払日 As System.Windows.Forms.Label

End Class