<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_KJKBN_DLG

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
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル537 = New System.Windows.Forms.Label()
        Me.ラベル541 = New System.Windows.Forms.Label()
        Me.ラベル543 = New System.Windows.Forms.Label()
        Me.chk_KJKBN_MS_F = New System.Windows.Forms.CheckBox()
        Me.chk_LEAKBN_MS_F = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "設定(&R)"
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
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(3, 109)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 2
        Me.Lbl.Text = "リース区分"
        '
        ' ラベル537
        '
        Me.ラベル537.AutoSize = True
        Me.ラベル537.Location = New System.Drawing.Point(19, 87)
        Me.ラベル537.Name = "ラベル537"
        Me.ラベル537.TabIndex = 3
        Me.ラベル537.Text = "計上区分自動設定禁止フラグ"
        '
        ' ラベル541
        '
        Me.ラベル541.AutoSize = True
        Me.ラベル541.Location = New System.Drawing.Point(19, 61)
        Me.ラベル541.Name = "ラベル541"
        Me.ラベル541.TabIndex = 4
        Me.ラベル541.Text = "計上区分"
        '
        ' ラベル543
        '
        Me.ラベル543.AutoSize = True
        Me.ラベル543.Location = New System.Drawing.Point(18, 109)
        Me.ラベル543.Name = "ラベル543"
        Me.ラベル543.TabIndex = 5
        Me.ラベル543.Text = "リース区分自動禁止設定フラグ"
        '
        ' chk_KJKBN_MS_F
        '
        Me.chk_KJKBN_MS_F.AutoSize = True
        Me.chk_KJKBN_MS_F.Location = New System.Drawing.Point(233, 88)
        Me.chk_KJKBN_MS_F.Name = "chk_KJKBN_MS_F"
        Me.chk_KJKBN_MS_F.TabIndex = 6
        Me.chk_KJKBN_MS_F.Text = ""
        Me.chk_KJKBN_MS_F.UseVisualStyleBackColor = True
        '
        ' chk_LEAKBN_MS_F
        '
        Me.chk_LEAKBN_MS_F.AutoSize = True
        Me.chk_LEAKBN_MS_F.Location = New System.Drawing.Point(234, 111)
        Me.chk_LEAKBN_MS_F.Name = "chk_LEAKBN_MS_F"
        Me.chk_LEAKBN_MS_F.TabIndex = 7
        Me.chk_LEAKBN_MS_F.Text = ""
        Me.chk_LEAKBN_MS_F.UseVisualStyleBackColor = True
        '
        ' Form_f_KJKBN_DLG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.chk_KJKBN_MS_F)
        Me.Controls.Add(Me.chk_LEAKBN_MS_F)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル537)
        Me.Controls.Add(Me.ラベル541)
        Me.Controls.Add(Me.ラベル543)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_KJKBN_DLG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "計上区分設定ダイアログ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル537 As System.Windows.Forms.Label
    Friend WithEvents ラベル541 As System.Windows.Forms.Label
    Friend WithEvents ラベル543 As System.Windows.Forms.Label
    Friend WithEvents chk_KJKBN_MS_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_LEAKBN_MS_F As System.Windows.Forms.CheckBox

End Class