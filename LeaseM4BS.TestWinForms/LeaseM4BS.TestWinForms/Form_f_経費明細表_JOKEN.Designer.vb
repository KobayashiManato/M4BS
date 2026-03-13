<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_経費明細表_JOKEN

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
        Me.cmd_ZEN = New System.Windows.Forms.Button()
        Me.txt_KIKAN_FROM = New System.Windows.Forms.TextBox()
        Me.txt_KIKAN_TO = New System.Windows.Forms.TextBox()
        Me.txt_GETU_CNT = New System.Windows.Forms.TextBox()
        Me.ラベル471 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル511 = New System.Windows.Forms.Label()
        Me.ラベル497 = New System.Windows.Forms.Label()
        Me.ラベル505 = New System.Windows.Forms.Label()
        Me.ラベル507 = New System.Windows.Forms.Label()
        Me.ラベル509 = New System.Windows.Forms.Label()
        Me.ラベル478 = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.オプション504 = New System.Windows.Forms.RadioButton()
        Me.オプション506 = New System.Windows.Forms.RadioButton()
        Me.オプション508 = New System.Windows.Forms.RadioButton()
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
        ' cmd_ZEN
        '
        Me.cmd_ZEN.Location = New System.Drawing.Point(366, 7)
        Me.cmd_ZEN.Name = "cmd_ZEN"
        Me.cmd_ZEN.Size = New System.Drawing.Size(102, 26)
        Me.cmd_ZEN.TabIndex = 2
        Me.cmd_ZEN.Text = "前回集計結果(&Z)"
        Me.cmd_ZEN.UseVisualStyleBackColor = True
        '
        ' txt_KIKAN_FROM
        '
        Me.txt_KIKAN_FROM.Location = New System.Drawing.Point(113, 56)
        Me.txt_KIKAN_FROM.Name = "txt_KIKAN_FROM"
        Me.txt_KIKAN_FROM.Size = New System.Drawing.Size(75, 19)
        Me.txt_KIKAN_FROM.TabIndex = 3
        '
        ' txt_KIKAN_TO
        '
        Me.txt_KIKAN_TO.Location = New System.Drawing.Point(207, 56)
        Me.txt_KIKAN_TO.Name = "txt_KIKAN_TO"
        Me.txt_KIKAN_TO.Size = New System.Drawing.Size(75, 19)
        Me.txt_KIKAN_TO.TabIndex = 4
        '
        ' txt_GETU_CNT
        '
        Me.txt_GETU_CNT.Location = New System.Drawing.Point(302, 56)
        Me.txt_GETU_CNT.Name = "txt_GETU_CNT"
        Me.txt_GETU_CNT.Size = New System.Drawing.Size(50, 19)
        Me.txt_GETU_CNT.TabIndex = 5
        '
        ' ラベル471
        '
        Me.ラベル471.AutoSize = True
        Me.ラベル471.Location = New System.Drawing.Point(188, 56)
        Me.ラベル471.Name = "ラベル471"
        Me.ラベル471.TabIndex = 6
        Me.ラベル471.Text = "～"
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(18, 56)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 7
        Me.Lbl.Text = "集計期間"
        '
        ' ラベル511
        '
        Me.ラベル511.AutoSize = True
        Me.ラベル511.Location = New System.Drawing.Point(26, 120)
        Me.ラベル511.Name = "ラベル511"
        Me.ラベル511.TabIndex = 8
        Me.ラベル511.Text = "計算対象"
        '
        ' ラベル497
        '
        Me.ラベル497.AutoSize = True
        Me.ラベル497.Location = New System.Drawing.Point(56, 147)
        Me.ラベル497.Name = "ラベル497"
        Me.ラベル497.TabIndex = 9
        Me.ラベル497.Text = "集計対象"
        '
        ' ラベル505
        '
        Me.ラベル505.AutoSize = True
        Me.ラベル505.Location = New System.Drawing.Point(185, 151)
        Me.ラベル505.Name = "ラベル505"
        Me.ラベル505.TabIndex = 10
        Me.ラベル505.Text = "ﾘｰｽ料"
        '
        ' ラベル507
        '
        Me.ラベル507.AutoSize = True
        Me.ラベル507.Location = New System.Drawing.Point(260, 151)
        Me.ラベル507.Name = "ラベル507"
        Me.ラベル507.TabIndex = 11
        Me.ラベル507.Text = "保守料"
        '
        ' ラベル509
        '
        Me.ラベル509.AutoSize = True
        Me.ラベル509.Location = New System.Drawing.Point(340, 151)
        Me.ラベル509.Name = "ラベル509"
        Me.ラベル509.TabIndex = 12
        Me.ラベル509.Text = "全部"
        '
        ' ラベル478
        '
        Me.ラベル478.AutoSize = True
        Me.ラベル478.Location = New System.Drawing.Point(340, 56)
        Me.ラベル478.Name = "ラベル478"
        Me.ラベル478.TabIndex = 13
        Me.ラベル478.Text = "ヶ月"
        '
        ' ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(113, 83)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.TabIndex = 14
        Me.ラベル512.Text = "yyyy/mm の形式で入力してください"
        '
        ' オプション504
        '
        Me.オプション504.AutoSize = True
        Me.オプション504.Location = New System.Drawing.Point(170, 151)
        Me.オプション504.Name = "オプション504"
        Me.オプション504.TabIndex = 15
        Me.オプション504.Text = ""
        Me.オプション504.UseVisualStyleBackColor = True
        '
        ' オプション506
        '
        Me.オプション506.AutoSize = True
        Me.オプション506.Location = New System.Drawing.Point(245, 151)
        Me.オプション506.Name = "オプション506"
        Me.オプション506.TabIndex = 16
        Me.オプション506.Text = ""
        Me.オプション506.UseVisualStyleBackColor = True
        '
        ' オプション508
        '
        Me.オプション508.AutoSize = True
        Me.オプション508.Location = New System.Drawing.Point(325, 151)
        Me.オプション508.Name = "オプション508"
        Me.オプション508.TabIndex = 17
        Me.オプション508.Text = ""
        Me.オプション508.UseVisualStyleBackColor = True
        '
        ' Form_f_経費明細表_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 216)
        Me.Controls.Add(Me.オプション504)
        Me.Controls.Add(Me.オプション506)
        Me.Controls.Add(Me.オプション508)
        Me.Controls.Add(Me.ラベル471)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル511)
        Me.Controls.Add(Me.ラベル497)
        Me.Controls.Add(Me.ラベル505)
        Me.Controls.Add(Me.ラベル507)
        Me.Controls.Add(Me.ラベル509)
        Me.Controls.Add(Me.ラベル478)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.txt_KIKAN_FROM)
        Me.Controls.Add(Me.txt_KIKAN_TO)
        Me.Controls.Add(Me.txt_GETU_CNT)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_ZEN)
        Me.Name = "Form_f_経費明細表_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "経費明細表　期間設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_ZEN As System.Windows.Forms.Button
    Friend WithEvents txt_KIKAN_FROM As System.Windows.Forms.TextBox
    Friend WithEvents txt_KIKAN_TO As System.Windows.Forms.TextBox
    Friend WithEvents txt_GETU_CNT As System.Windows.Forms.TextBox
    Friend WithEvents ラベル471 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル511 As System.Windows.Forms.Label
    Friend WithEvents ラベル497 As System.Windows.Forms.Label
    Friend WithEvents ラベル505 As System.Windows.Forms.Label
    Friend WithEvents ラベル507 As System.Windows.Forms.Label
    Friend WithEvents ラベル509 As System.Windows.Forms.Label
    Friend WithEvents ラベル478 As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents オプション504 As System.Windows.Forms.RadioButton
    Friend WithEvents オプション506 As System.Windows.Forms.RadioButton
    Friend WithEvents オプション508 As System.Windows.Forms.RadioButton

End Class