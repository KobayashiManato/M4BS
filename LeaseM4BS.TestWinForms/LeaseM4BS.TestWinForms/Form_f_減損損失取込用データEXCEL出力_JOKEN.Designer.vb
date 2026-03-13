<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_減損損失取込用データEXCEL出力_JOKEN

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
        Me.txt_GSON_TMG = New System.Windows.Forms.TextBox()
        Me.txt_GSON_RYO = New System.Windows.Forms.TextBox()
        Me.txt_GSON_RYO_既存 = New System.Windows.Forms.TextBox()
        Me.txt_BOKA_ZAN = New System.Windows.Forms.TextBox()
        Me.txt_LGNPN_ZAN = New System.Windows.Forms.TextBox()
        Me.txt_GSON_ZAN = New System.Windows.Forms.TextBox()
        Me.txt_KIKAN_TO = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル515 = New System.Windows.Forms.Label()
        Me.ラベル516 = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.ラベル523 = New System.Windows.Forms.Label()
        Me.ラベル539 = New System.Windows.Forms.Label()
        Me.ラベル524 = New System.Windows.Forms.Label()
        Me.ラベル527 = New System.Windows.Forms.Label()
        Me.ラベル528 = New System.Windows.Forms.Label()
        Me.ラベル530 = New System.Windows.Forms.Label()
        Me.ラベル532 = New System.Windows.Forms.Label()
        Me.ラベル537 = New System.Windows.Forms.Label()
        Me.chk_入力配分F = New System.Windows.Forms.CheckBox()
        Me.オプション522 = New System.Windows.Forms.RadioButton()
        Me.オプション538 = New System.Windows.Forms.RadioButton()
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
        ' txt_GSON_TMG
        '
        Me.txt_GSON_TMG.Location = New System.Drawing.Point(264, 56)
        Me.txt_GSON_TMG.Name = "txt_GSON_TMG"
        Me.txt_GSON_TMG.Size = New System.Drawing.Size(56, 19)
        Me.txt_GSON_TMG.TabIndex = 2
        '
        ' txt_GSON_RYO
        '
        Me.txt_GSON_RYO.Location = New System.Drawing.Point(147, 245)
        Me.txt_GSON_RYO.Name = "txt_GSON_RYO"
        Me.txt_GSON_RYO.Size = New System.Drawing.Size(94, 19)
        Me.txt_GSON_RYO.TabIndex = 3
        '
        ' txt_GSON_RYO_既存
        '
        Me.txt_GSON_RYO_既存.Location = New System.Drawing.Point(491, 56)
        Me.txt_GSON_RYO_既存.Name = "txt_GSON_RYO_既存"
        Me.txt_GSON_RYO_既存.Size = New System.Drawing.Size(113, 19)
        Me.txt_GSON_RYO_既存.TabIndex = 4
        '
        ' txt_BOKA_ZAN
        '
        Me.txt_BOKA_ZAN.Location = New System.Drawing.Point(359, 113)
        Me.txt_BOKA_ZAN.Name = "txt_BOKA_ZAN"
        Me.txt_BOKA_ZAN.Size = New System.Drawing.Size(75, 19)
        Me.txt_BOKA_ZAN.TabIndex = 5
        '
        ' txt_LGNPN_ZAN
        '
        Me.txt_LGNPN_ZAN.Location = New System.Drawing.Point(359, 132)
        Me.txt_LGNPN_ZAN.Name = "txt_LGNPN_ZAN"
        Me.txt_LGNPN_ZAN.Size = New System.Drawing.Size(75, 19)
        Me.txt_LGNPN_ZAN.TabIndex = 6
        '
        ' txt_GSON_ZAN
        '
        Me.txt_GSON_ZAN.Location = New System.Drawing.Point(359, 151)
        Me.txt_GSON_ZAN.Name = "txt_GSON_ZAN"
        Me.txt_GSON_ZAN.Size = New System.Drawing.Size(75, 19)
        Me.txt_GSON_ZAN.TabIndex = 7
        '
        ' txt_KIKAN_TO
        '
        Me.txt_KIKAN_TO.Location = New System.Drawing.Point(113, 113)
        Me.txt_KIKAN_TO.Name = "txt_KIKAN_TO"
        Me.txt_KIKAN_TO.Size = New System.Drawing.Size(75, 19)
        Me.txt_KIKAN_TO.TabIndex = 8
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(18, 56)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 9
        Me.Lbl.Text = "処理年月"
        '
        ' ラベル515
        '
        Me.ラベル515.AutoSize = True
        Me.ラベル515.Location = New System.Drawing.Point(188, 56)
        Me.ラベル515.Name = "ラベル515"
        Me.ラベル515.TabIndex = 10
        Me.ラベル515.Text = "処理ﾀｲﾐﾝｸﾞ"
        '
        ' ラベル516
        '
        Me.ラベル516.AutoSize = True
        Me.ラベル516.Location = New System.Drawing.Point(52, 245)
        Me.ラベル516.Name = "ラベル516"
        Me.ラベル516.TabIndex = 11
        Me.ラベル516.Text = "減損損失"
        '
        ' ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(294, 207)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.TabIndex = 12
        Me.ラベル512.Text = "※減損損失は出力したExcel上でも入力できますので、\015\012　ここでの入力は必須ではありません。"
        '
        ' ラベル523
        '
        Me.ラベル523.AutoSize = True
        Me.ラベル523.Location = New System.Drawing.Point(86, 287)
        Me.ラベル523.Name = "ラベル523"
        Me.ラベル523.TabIndex = 13
        Me.ラベル523.Text = "「残高相当額」の比率に従い配分"
        '
        ' ラベル539
        '
        Me.ラベル539.AutoSize = True
        Me.ラベル539.Location = New System.Drawing.Point(86, 309)
        Me.ラベル539.Name = "ラベル539"
        Me.ラベル539.TabIndex = 14
        Me.ラベル539.Text = "「未経過ﾘｰｽ料残高相当額」（－「ﾘｰｽ資産減損勘定の残高」）\015\012の比率に従い配分"
        '
        ' ラベル524
        '
        Me.ラベル524.AutoSize = True
        Me.ラベル524.Location = New System.Drawing.Point(321, 56)
        Me.ラベル524.Name = "ラベル524"
        Me.ラベル524.TabIndex = 15
        Me.ラベル524.Text = "減損損失（当該月・既入力分）"
        '
        ' ラベル527
        '
        Me.ラベル527.AutoSize = True
        Me.ラベル527.Location = New System.Drawing.Point(34, 207)
        Me.ラベル527.Name = "ラベル527"
        Me.ラベル527.TabIndex = 16
        Me.ラベル527.Text = "減損損失を入力し各物件に配分する"
        '
        ' ラベル528
        '
        Me.ラベル528.AutoSize = True
        Me.ラベル528.Location = New System.Drawing.Point(207, 113)
        Me.ラベル528.Name = "ラベル528"
        Me.ラベル528.TabIndex = 17
        Me.ラベル528.Text = "残高相当額"
        '
        ' ラベル530
        '
        Me.ラベル530.AutoSize = True
        Me.ラベル530.Location = New System.Drawing.Point(207, 132)
        Me.ラベル530.Name = "ラベル530"
        Me.ラベル530.TabIndex = 18
        Me.ラベル530.Text = "未経過ﾘｰｽ料残高相当額"
        '
        ' ラベル532
        '
        Me.ラベル532.AutoSize = True
        Me.ラベル532.Location = New System.Drawing.Point(207, 151)
        Me.ラベル532.Name = "ラベル532"
        Me.ラベル532.TabIndex = 19
        Me.ラベル532.Text = "ﾘｰｽ資産減損勘定の残高"
        '
        ' ラベル537
        '
        Me.ラベル537.AutoSize = True
        Me.ラベル537.Location = New System.Drawing.Point(18, 113)
        Me.ラベル537.Name = "ラベル537"
        Me.ラベル537.TabIndex = 20
        Me.ラベル537.Text = "決算日"
        '
        ' chk_入力配分F
        '
        Me.chk_入力配分F.AutoSize = True
        Me.chk_入力配分F.Location = New System.Drawing.Point(272, 211)
        Me.chk_入力配分F.Name = "chk_入力配分F"
        Me.chk_入力配分F.TabIndex = 21
        Me.chk_入力配分F.Text = ""
        Me.chk_入力配分F.UseVisualStyleBackColor = True
        '
        ' オプション522
        '
        Me.オプション522.AutoSize = True
        Me.オプション522.Location = New System.Drawing.Point(68, 291)
        Me.オプション522.Name = "オプション522"
        Me.オプション522.TabIndex = 22
        Me.オプション522.Text = ""
        Me.オプション522.UseVisualStyleBackColor = True
        '
        ' オプション538
        '
        Me.オプション538.AutoSize = True
        Me.オプション538.Location = New System.Drawing.Point(68, 313)
        Me.オプション538.Name = "オプション538"
        Me.オプション538.TabIndex = 23
        Me.オプション538.Text = ""
        Me.オプション538.UseVisualStyleBackColor = True
        '
        ' Form_f_減損損失取込用データEXCEL出力_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 518)
        Me.Controls.Add(Me.オプション522)
        Me.Controls.Add(Me.オプション538)
        Me.Controls.Add(Me.chk_入力配分F)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル515)
        Me.Controls.Add(Me.ラベル516)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.ラベル523)
        Me.Controls.Add(Me.ラベル539)
        Me.Controls.Add(Me.ラベル524)
        Me.Controls.Add(Me.ラベル527)
        Me.Controls.Add(Me.ラベル528)
        Me.Controls.Add(Me.ラベル530)
        Me.Controls.Add(Me.ラベル532)
        Me.Controls.Add(Me.ラベル537)
        Me.Controls.Add(Me.txt_GSON_TMG)
        Me.Controls.Add(Me.txt_GSON_RYO)
        Me.Controls.Add(Me.txt_GSON_RYO_既存)
        Me.Controls.Add(Me.txt_BOKA_ZAN)
        Me.Controls.Add(Me.txt_LGNPN_ZAN)
        Me.Controls.Add(Me.txt_GSON_ZAN)
        Me.Controls.Add(Me.txt_KIKAN_TO)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_減損損失取込用データEXCEL出力_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "減損損失取込用データExcel出力　条件設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_GSON_TMG As System.Windows.Forms.TextBox
    Friend WithEvents txt_GSON_RYO As System.Windows.Forms.TextBox
    Friend WithEvents txt_GSON_RYO_既存 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BOKA_ZAN As System.Windows.Forms.TextBox
    Friend WithEvents txt_LGNPN_ZAN As System.Windows.Forms.TextBox
    Friend WithEvents txt_GSON_ZAN As System.Windows.Forms.TextBox
    Friend WithEvents txt_KIKAN_TO As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル515 As System.Windows.Forms.Label
    Friend WithEvents ラベル516 As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents ラベル523 As System.Windows.Forms.Label
    Friend WithEvents ラベル539 As System.Windows.Forms.Label
    Friend WithEvents ラベル524 As System.Windows.Forms.Label
    Friend WithEvents ラベル527 As System.Windows.Forms.Label
    Friend WithEvents ラベル528 As System.Windows.Forms.Label
    Friend WithEvents ラベル530 As System.Windows.Forms.Label
    Friend WithEvents ラベル532 As System.Windows.Forms.Label
    Friend WithEvents ラベル537 As System.Windows.Forms.Label
    Friend WithEvents chk_入力配分F As System.Windows.Forms.CheckBox
    Friend WithEvents オプション522 As System.Windows.Forms.RadioButton
    Friend WithEvents オプション538 As System.Windows.Forms.RadioButton

End Class