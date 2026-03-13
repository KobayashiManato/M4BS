<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SNKO_仕訳出力_JOKEN

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
        Me.cmd_選択 = New System.Windows.Forms.Button()
        Me.txt_支払月 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FOLDER_NM = New System.Windows.Forms.TextBox()
        Me.txt_計上日 = New System.Windows.Forms.TextBox()
        Me.txt_計上日_曜日 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FILE_NM = New System.Windows.Forms.TextBox()
        Me.txt_使用者社員番号 = New System.Windows.Forms.TextBox()
        Me.txt_未払_科目 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FPATH = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル514 = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル523 = New System.Windows.Forms.Label()
        Me.ラベル525 = New System.Windows.Forms.Label()
        Me.ラベル527 = New System.Windows.Forms.Label()
        Me.ラベル529 = New System.Windows.Forms.Label()
        Me.ラベル549 = New System.Windows.Forms.Label()
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
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(600, 461)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 2
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_支払月
        '
        Me.txt_支払月.Location = New System.Drawing.Point(113, 49)
        Me.txt_支払月.Name = "txt_支払月"
        Me.txt_支払月.Size = New System.Drawing.Size(75, 19)
        Me.txt_支払月.TabIndex = 3
        '
        ' txt_OUTPUT_FOLDER_NM
        '
        Me.txt_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(113, 461)
        Me.txt_OUTPUT_FOLDER_NM.Name = "txt_OUTPUT_FOLDER_NM"
        Me.txt_OUTPUT_FOLDER_NM.Size = New System.Drawing.Size(483, 19)
        Me.txt_OUTPUT_FOLDER_NM.TabIndex = 4
        '
        ' txt_計上日
        '
        Me.txt_計上日.Location = New System.Drawing.Point(283, 49)
        Me.txt_計上日.Name = "txt_計上日"
        Me.txt_計上日.Size = New System.Drawing.Size(75, 19)
        Me.txt_計上日.TabIndex = 5
        '
        ' txt_計上日_曜日
        '
        Me.txt_計上日_曜日.Location = New System.Drawing.Point(359, 49)
        Me.txt_計上日_曜日.Name = "txt_計上日_曜日"
        Me.txt_計上日_曜日.Size = New System.Drawing.Size(50, 19)
        Me.txt_計上日_曜日.TabIndex = 6
        '
        ' txt_OUTPUT_FILE_NM
        '
        Me.txt_OUTPUT_FILE_NM.Location = New System.Drawing.Point(113, 480)
        Me.txt_OUTPUT_FILE_NM.Name = "txt_OUTPUT_FILE_NM"
        Me.txt_OUTPUT_FILE_NM.Size = New System.Drawing.Size(483, 19)
        Me.txt_OUTPUT_FILE_NM.TabIndex = 7
        '
        ' txt_使用者社員番号
        '
        Me.txt_使用者社員番号.Location = New System.Drawing.Point(207, 506)
        Me.txt_使用者社員番号.Name = "txt_使用者社員番号"
        Me.txt_使用者社員番号.Size = New System.Drawing.Size(75, 19)
        Me.txt_使用者社員番号.TabIndex = 8
        '
        ' txt_未払_科目
        '
        Me.txt_未払_科目.Location = New System.Drawing.Point(476, 506)
        Me.txt_未払_科目.Name = "txt_未払_科目"
        Me.txt_未払_科目.Size = New System.Drawing.Size(132, 19)
        Me.txt_未払_科目.TabIndex = 9
        '
        ' txt_OUTPUT_FPATH
        '
        Me.txt_OUTPUT_FPATH.Location = New System.Drawing.Point(604, 480)
        Me.txt_OUTPUT_FPATH.Name = "txt_OUTPUT_FPATH"
        Me.txt_OUTPUT_FPATH.Size = New System.Drawing.Size(75, 19)
        Me.txt_OUTPUT_FPATH.TabIndex = 10
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(18, 49)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 11
        Me.Lbl.Text = "対象支払月"
        '
        ' ラベル514
        '
        Me.ラベル514.AutoSize = True
        Me.ラベル514.Location = New System.Drawing.Point(18, 461)
        Me.ラベル514.Name = "ラベル514"
        Me.ラベル514.TabIndex = 12
        Me.ラベル514.Text = "出力先ﾌｫﾙﾀﾞ名"
        '
        ' ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(188, 11)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.TabIndex = 13
        Me.ラベル512.Text = "確定仕訳データを作成します。"
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(188, 49)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 14
        Me.ラベル521.Text = "計上日"
        '
        ' ラベル523
        '
        Me.ラベル523.AutoSize = True
        Me.ラベル523.Location = New System.Drawing.Point(18, 480)
        Me.ラベル523.Name = "ラベル523"
        Me.ラベル523.TabIndex = 15
        Me.ラベル523.Text = "出力先ﾌｧｲﾙ名"
        '
        ' ラベル525
        '
        Me.ラベル525.AutoSize = True
        Me.ラベル525.Location = New System.Drawing.Point(113, 506)
        Me.ラベル525.Name = "ラベル525"
        Me.ラベル525.TabIndex = 16
        Me.ラベル525.Text = "使用者社員番号"
        '
        ' ラベル527
        '
        Me.ラベル527.AutoSize = True
        Me.ラベル527.Location = New System.Drawing.Point(302, 506)
        Me.ラベル527.Name = "ラベル527"
        Me.ラベル527.TabIndex = 17
        Me.ラベル527.Text = "未払金"
        '
        ' ラベル529
        '
        Me.ラベル529.AutoSize = True
        Me.ラベル529.Location = New System.Drawing.Point(359, 506)
        Me.ラベル529.Name = "ラベル529"
        Me.ラベル529.TabIndex = 18
        Me.ラベル529.Text = "勘定科目"
        '
        ' ラベル549
        '
        Me.ラベル549.AutoSize = True
        Me.ラベル549.Location = New System.Drawing.Point(18, 506)
        Me.ラベル549.Name = "ラベル549"
        Me.ラベル549.TabIndex = 19
        Me.ラベル549.Text = "＜固定値＞"
        '
        ' Form_fc_SNKO_仕訳出力_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 574)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル514)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル523)
        Me.Controls.Add(Me.ラベル525)
        Me.Controls.Add(Me.ラベル527)
        Me.Controls.Add(Me.ラベル529)
        Me.Controls.Add(Me.ラベル549)
        Me.Controls.Add(Me.txt_支払月)
        Me.Controls.Add(Me.txt_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.txt_計上日)
        Me.Controls.Add(Me.txt_計上日_曜日)
        Me.Controls.Add(Me.txt_OUTPUT_FILE_NM)
        Me.Controls.Add(Me.txt_使用者社員番号)
        Me.Controls.Add(Me.txt_未払_科目)
        Me.Controls.Add(Me.txt_OUTPUT_FPATH)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_SNKO_仕訳出力_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_支払月 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FOLDER_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日_曜日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FILE_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_使用者社員番号 As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払_科目 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FPATH As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル514 As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル523 As System.Windows.Forms.Label
    Friend WithEvents ラベル525 As System.Windows.Forms.Label
    Friend WithEvents ラベル527 As System.Windows.Forms.Label
    Friend WithEvents ラベル529 As System.Windows.Forms.Label
    Friend WithEvents ラベル549 As System.Windows.Forms.Label

End Class