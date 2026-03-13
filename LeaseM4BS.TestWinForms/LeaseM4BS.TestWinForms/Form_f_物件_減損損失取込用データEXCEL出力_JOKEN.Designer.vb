<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_物件_減損損失取込用データEXCEL出力_JOKEN

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
        Me.txt_KIKAN_TO = New System.Windows.Forms.TextBox()
        Me.txt_GSON_RYO_既存 = New System.Windows.Forms.TextBox()
        Me.txt_GSON_DT = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル537 = New System.Windows.Forms.Label()
        Me.ラベル541 = New System.Windows.Forms.Label()
        Me.ラベル524 = New System.Windows.Forms.Label()
        Me.ラベル545 = New System.Windows.Forms.Label()
        Me.ラベル547 = New System.Windows.Forms.Label()
        Me.ラベル548 = New System.Windows.Forms.Label()
        Me.ラベル550 = New System.Windows.Forms.Label()
        Me.chk_リース会計基準 = New System.Windows.Forms.CheckBox()
        Me.chk_一般重要性原則 = New System.Windows.Forms.CheckBox()
        Me.opt_Syoryaku1 = New System.Windows.Forms.RadioButton()
        Me.opt_Syoryaku2 = New System.Windows.Forms.RadioButton()
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
        ' txt_KIKAN_TO
        '
        Me.txt_KIKAN_TO.Location = New System.Drawing.Point(132, 121)
        Me.txt_KIKAN_TO.Name = "txt_KIKAN_TO"
        Me.txt_KIKAN_TO.Size = New System.Drawing.Size(56, 19)
        Me.txt_KIKAN_TO.TabIndex = 2
        '
        ' txt_GSON_RYO_既存
        '
        Me.txt_GSON_RYO_既存.Location = New System.Drawing.Point(102, 45)
        Me.txt_GSON_RYO_既存.Name = "txt_GSON_RYO_既存"
        Me.txt_GSON_RYO_既存.Size = New System.Drawing.Size(113, 19)
        Me.txt_GSON_RYO_既存.TabIndex = 3
        '
        ' txt_GSON_DT
        '
        Me.txt_GSON_DT.Location = New System.Drawing.Point(132, 64)
        Me.txt_GSON_DT.Name = "txt_GSON_DT"
        Me.txt_GSON_DT.Size = New System.Drawing.Size(132, 19)
        Me.txt_GSON_DT.TabIndex = 4
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(19, 64)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 5
        Me.Lbl.Text = "減損計上年度"
        '
        ' ラベル537
        '
        Me.ラベル537.AutoSize = True
        Me.ラベル537.Location = New System.Drawing.Point(19, 121)
        Me.ラベル537.Name = "ラベル537"
        Me.ラベル537.TabIndex = 6
        Me.ラベル537.Text = "前回決算日"
        '
        ' ラベル541
        '
        Me.ラベル541.AutoSize = True
        Me.ラベル541.Location = New System.Drawing.Point(19, 91)
        Me.ラベル541.Name = "ラベル541"
        Me.ラベル541.TabIndex = 7
        Me.ラベル541.Text = "減損計上月度"
        '
        ' ラベル524
        '
        Me.ラベル524.AutoSize = True
        Me.ラベル524.Location = New System.Drawing.Point(30, 37)
        Me.ラベル524.Name = "ラベル524"
        Me.ラベル524.TabIndex = 8
        Me.ラベル524.Text = "減損損失（当該月・既入力分）"
        '
        ' ラベル545
        '
        Me.ラベル545.AutoSize = True
        Me.ラベル545.Location = New System.Drawing.Point(79, 185)
        Me.ラベル545.Name = "ラベル545"
        Me.ラベル545.TabIndex = 9
        Me.ラベル545.Text = "省略物件は出力しない"
        '
        ' ラベル547
        '
        Me.ラベル547.AutoSize = True
        Me.ラベル547.Location = New System.Drawing.Point(79, 207)
        Me.ラベル547.Name = "ラベル547"
        Me.ラベル547.TabIndex = 10
        Me.ラベル547.Text = "出力する省略基準適用を指定する"
        '
        ' ラベル548
        '
        Me.ラベル548.AutoSize = True
        Me.ラベル548.Location = New System.Drawing.Point(79, 249)
        Me.ラベル548.Name = "ラベル548"
        Me.ラベル548.TabIndex = 11
        Me.ラベル548.Text = "リース会計基準の省略物件も出力する"
        '
        ' ラベル550
        '
        Me.ラベル550.AutoSize = True
        Me.ラベル550.Location = New System.Drawing.Point(79, 272)
        Me.ラベル550.Name = "ラベル550"
        Me.ラベル550.TabIndex = 12
        Me.ラベル550.Text = "一般重要性原則の省略物件も出力する"
        '
        ' chk_リース会計基準
        '
        Me.chk_リース会計基準.AutoSize = True
        Me.chk_リース会計基準.Location = New System.Drawing.Point(64, 251)
        Me.chk_リース会計基準.Name = "chk_リース会計基準"
        Me.chk_リース会計基準.TabIndex = 13
        Me.chk_リース会計基準.Text = ""
        Me.chk_リース会計基準.UseVisualStyleBackColor = True
        '
        ' chk_一般重要性原則
        '
        Me.chk_一般重要性原則.AutoSize = True
        Me.chk_一般重要性原則.Location = New System.Drawing.Point(64, 274)
        Me.chk_一般重要性原則.Name = "chk_一般重要性原則"
        Me.chk_一般重要性原則.TabIndex = 14
        Me.chk_一般重要性原則.Text = ""
        Me.chk_一般重要性原則.UseVisualStyleBackColor = True
        '
        ' opt_Syoryaku1
        '
        Me.opt_Syoryaku1.AutoSize = True
        Me.opt_Syoryaku1.Location = New System.Drawing.Point(64, 187)
        Me.opt_Syoryaku1.Name = "opt_Syoryaku1"
        Me.opt_Syoryaku1.TabIndex = 15
        Me.opt_Syoryaku1.Text = ""
        Me.opt_Syoryaku1.UseVisualStyleBackColor = True
        '
        ' opt_Syoryaku2
        '
        Me.opt_Syoryaku2.AutoSize = True
        Me.opt_Syoryaku2.Location = New System.Drawing.Point(64, 209)
        Me.opt_Syoryaku2.Name = "opt_Syoryaku2"
        Me.opt_Syoryaku2.TabIndex = 16
        Me.opt_Syoryaku2.Text = ""
        Me.opt_Syoryaku2.UseVisualStyleBackColor = True
        '
        ' Form_f_物件_減損損失取込用データEXCEL出力_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 400)
        Me.Controls.Add(Me.opt_Syoryaku1)
        Me.Controls.Add(Me.opt_Syoryaku2)
        Me.Controls.Add(Me.chk_リース会計基準)
        Me.Controls.Add(Me.chk_一般重要性原則)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル537)
        Me.Controls.Add(Me.ラベル541)
        Me.Controls.Add(Me.ラベル524)
        Me.Controls.Add(Me.ラベル545)
        Me.Controls.Add(Me.ラベル547)
        Me.Controls.Add(Me.ラベル548)
        Me.Controls.Add(Me.ラベル550)
        Me.Controls.Add(Me.txt_KIKAN_TO)
        Me.Controls.Add(Me.txt_GSON_RYO_既存)
        Me.Controls.Add(Me.txt_GSON_DT)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_物件_減損損失取込用データEXCEL出力_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "物件_減損損失取込用データExcel出力　条件設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_KIKAN_TO As System.Windows.Forms.TextBox
    Friend WithEvents txt_GSON_RYO_既存 As System.Windows.Forms.TextBox
    Friend WithEvents txt_GSON_DT As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル537 As System.Windows.Forms.Label
    Friend WithEvents ラベル541 As System.Windows.Forms.Label
    Friend WithEvents ラベル524 As System.Windows.Forms.Label
    Friend WithEvents ラベル545 As System.Windows.Forms.Label
    Friend WithEvents ラベル547 As System.Windows.Forms.Label
    Friend WithEvents ラベル548 As System.Windows.Forms.Label
    Friend WithEvents ラベル550 As System.Windows.Forms.Label
    Friend WithEvents chk_リース会計基準 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_一般重要性原則 As System.Windows.Forms.CheckBox
    Friend WithEvents opt_Syoryaku1 As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Syoryaku2 As System.Windows.Forms.RadioButton

End Class