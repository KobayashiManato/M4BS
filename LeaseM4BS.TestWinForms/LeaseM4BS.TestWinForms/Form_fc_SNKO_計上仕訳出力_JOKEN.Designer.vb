<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SNKO_計上仕訳出力_JOKEN

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
        Me.txt_OUTPUT_FOLDER_NM = New System.Windows.Forms.TextBox()
        Me.txt_計上日 = New System.Windows.Forms.TextBox()
        Me.txt_計上日_曜日 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FILE_NM = New System.Windows.Forms.TextBox()
        Me.txt_使用者社員番号 = New System.Windows.Forms.TextBox()
        Me.txt_仮払_科目 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FPATH = New System.Windows.Forms.TextBox()
        Me.txt_雑損_科目 = New System.Windows.Forms.TextBox()
        Me.txt_総額仮勘定_科目 = New System.Windows.Forms.TextBox()
        Me.ラベル514 = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル523 = New System.Windows.Forms.Label()
        Me.ラベル525 = New System.Windows.Forms.Label()
        Me.ラベル527 = New System.Windows.Forms.Label()
        Me.ラベル529 = New System.Windows.Forms.Label()
        Me.ラベル549 = New System.Windows.Forms.Label()
        Me.ラベル553 = New System.Windows.Forms.Label()
        Me.ラベル554 = New System.Windows.Forms.Label()
        Me.ラベル558 = New System.Windows.Forms.Label()
        Me.ラベル559 = New System.Windows.Forms.Label()
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
        Me.cmd_選択.Location = New System.Drawing.Point(601, 68)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 2
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_OUTPUT_FOLDER_NM
        '
        Me.txt_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(113, 68)
        Me.txt_OUTPUT_FOLDER_NM.Name = "txt_OUTPUT_FOLDER_NM"
        Me.txt_OUTPUT_FOLDER_NM.Size = New System.Drawing.Size(483, 19)
        Me.txt_OUTPUT_FOLDER_NM.TabIndex = 3
        '
        ' txt_計上日
        '
        Me.txt_計上日.Location = New System.Drawing.Point(113, 49)
        Me.txt_計上日.Name = "txt_計上日"
        Me.txt_計上日.Size = New System.Drawing.Size(75, 19)
        Me.txt_計上日.TabIndex = 4
        '
        ' txt_計上日_曜日
        '
        Me.txt_計上日_曜日.Location = New System.Drawing.Point(189, 49)
        Me.txt_計上日_曜日.Name = "txt_計上日_曜日"
        Me.txt_計上日_曜日.Size = New System.Drawing.Size(50, 19)
        Me.txt_計上日_曜日.TabIndex = 5
        '
        ' txt_OUTPUT_FILE_NM
        '
        Me.txt_OUTPUT_FILE_NM.Location = New System.Drawing.Point(113, 86)
        Me.txt_OUTPUT_FILE_NM.Name = "txt_OUTPUT_FILE_NM"
        Me.txt_OUTPUT_FILE_NM.Size = New System.Drawing.Size(483, 19)
        Me.txt_OUTPUT_FILE_NM.TabIndex = 6
        '
        ' txt_使用者社員番号
        '
        Me.txt_使用者社員番号.Location = New System.Drawing.Point(208, 113)
        Me.txt_使用者社員番号.Name = "txt_使用者社員番号"
        Me.txt_使用者社員番号.Size = New System.Drawing.Size(75, 19)
        Me.txt_使用者社員番号.TabIndex = 7
        '
        ' txt_仮払_科目
        '
        Me.txt_仮払_科目.Location = New System.Drawing.Point(521, 113)
        Me.txt_仮払_科目.Name = "txt_仮払_科目"
        Me.txt_仮払_科目.Size = New System.Drawing.Size(132, 19)
        Me.txt_仮払_科目.TabIndex = 8
        '
        ' txt_OUTPUT_FPATH
        '
        Me.txt_OUTPUT_FPATH.Location = New System.Drawing.Point(604, 86)
        Me.txt_OUTPUT_FPATH.Name = "txt_OUTPUT_FPATH"
        Me.txt_OUTPUT_FPATH.Size = New System.Drawing.Size(75, 19)
        Me.txt_OUTPUT_FPATH.TabIndex = 9
        '
        ' txt_雑損_科目
        '
        Me.txt_雑損_科目.Location = New System.Drawing.Point(521, 132)
        Me.txt_雑損_科目.Name = "txt_雑損_科目"
        Me.txt_雑損_科目.Size = New System.Drawing.Size(132, 19)
        Me.txt_雑損_科目.TabIndex = 10
        '
        ' txt_総額仮勘定_科目
        '
        Me.txt_総額仮勘定_科目.Location = New System.Drawing.Point(521, 151)
        Me.txt_総額仮勘定_科目.Name = "txt_総額仮勘定_科目"
        Me.txt_総額仮勘定_科目.Size = New System.Drawing.Size(132, 19)
        Me.txt_総額仮勘定_科目.TabIndex = 11
        '
        ' ラベル514
        '
        Me.ラベル514.AutoSize = True
        Me.ラベル514.Location = New System.Drawing.Point(19, 68)
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
        Me.ラベル521.Location = New System.Drawing.Point(19, 49)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 14
        Me.ラベル521.Text = "計上日"
        '
        ' ラベル523
        '
        Me.ラベル523.AutoSize = True
        Me.ラベル523.Location = New System.Drawing.Point(19, 86)
        Me.ラベル523.Name = "ラベル523"
        Me.ラベル523.TabIndex = 15
        Me.ラベル523.Text = "出力先ﾌｧｲﾙ名"
        '
        ' ラベル525
        '
        Me.ラベル525.AutoSize = True
        Me.ラベル525.Location = New System.Drawing.Point(113, 113)
        Me.ラベル525.Name = "ラベル525"
        Me.ラベル525.TabIndex = 16
        Me.ラベル525.Text = "使用者社員番号"
        '
        ' ラベル527
        '
        Me.ラベル527.AutoSize = True
        Me.ラベル527.Location = New System.Drawing.Point(302, 113)
        Me.ラベル527.Name = "ラベル527"
        Me.ラベル527.TabIndex = 17
        Me.ラベル527.Text = "国内仮払消費税"
        '
        ' ラベル529
        '
        Me.ラベル529.AutoSize = True
        Me.ラベル529.Location = New System.Drawing.Point(404, 113)
        Me.ラベル529.Name = "ラベル529"
        Me.ラベル529.TabIndex = 18
        Me.ラベル529.Text = "勘定科目"
        '
        ' ラベル549
        '
        Me.ラベル549.AutoSize = True
        Me.ラベル549.Location = New System.Drawing.Point(19, 113)
        Me.ラベル549.Name = "ラベル549"
        Me.ラベル549.TabIndex = 19
        Me.ラベル549.Text = "＜固定値＞"
        '
        ' ラベル553
        '
        Me.ラベル553.AutoSize = True
        Me.ラベル553.Location = New System.Drawing.Point(302, 132)
        Me.ラベル553.Name = "ラベル553"
        Me.ラベル553.TabIndex = 20
        Me.ラベル553.Text = "雑損失"
        '
        ' ラベル554
        '
        Me.ラベル554.AutoSize = True
        Me.ラベル554.Location = New System.Drawing.Point(404, 132)
        Me.ラベル554.Name = "ラベル554"
        Me.ラベル554.TabIndex = 21
        Me.ラベル554.Text = "勘定科目"
        '
        ' ラベル558
        '
        Me.ラベル558.AutoSize = True
        Me.ラベル558.Location = New System.Drawing.Point(302, 151)
        Me.ラベル558.Name = "ラベル558"
        Me.ラベル558.TabIndex = 22
        Me.ラベル558.Text = "リース総額仮勘定"
        '
        ' ラベル559
        '
        Me.ラベル559.AutoSize = True
        Me.ラベル559.Location = New System.Drawing.Point(404, 151)
        Me.ラベル559.Name = "ラベル559"
        Me.ラベル559.TabIndex = 23
        Me.ラベル559.Text = "勘定科目"
        '
        ' Form_fc_SNKO_計上仕訳出力_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 320)
        Me.Controls.Add(Me.ラベル514)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル523)
        Me.Controls.Add(Me.ラベル525)
        Me.Controls.Add(Me.ラベル527)
        Me.Controls.Add(Me.ラベル529)
        Me.Controls.Add(Me.ラベル549)
        Me.Controls.Add(Me.ラベル553)
        Me.Controls.Add(Me.ラベル554)
        Me.Controls.Add(Me.ラベル558)
        Me.Controls.Add(Me.ラベル559)
        Me.Controls.Add(Me.txt_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.txt_計上日)
        Me.Controls.Add(Me.txt_計上日_曜日)
        Me.Controls.Add(Me.txt_OUTPUT_FILE_NM)
        Me.Controls.Add(Me.txt_使用者社員番号)
        Me.Controls.Add(Me.txt_仮払_科目)
        Me.Controls.Add(Me.txt_OUTPUT_FPATH)
        Me.Controls.Add(Me.txt_雑損_科目)
        Me.Controls.Add(Me.txt_総額仮勘定_科目)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_SNKO_計上仕訳出力_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_OUTPUT_FOLDER_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日_曜日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FILE_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_使用者社員番号 As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮払_科目 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FPATH As System.Windows.Forms.TextBox
    Friend WithEvents txt_雑損_科目 As System.Windows.Forms.TextBox
    Friend WithEvents txt_総額仮勘定_科目 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル514 As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル523 As System.Windows.Forms.Label
    Friend WithEvents ラベル525 As System.Windows.Forms.Label
    Friend WithEvents ラベル527 As System.Windows.Forms.Label
    Friend WithEvents ラベル529 As System.Windows.Forms.Label
    Friend WithEvents ラベル549 As System.Windows.Forms.Label
    Friend WithEvents ラベル553 As System.Windows.Forms.Label
    Friend WithEvents ラベル554 As System.Windows.Forms.Label
    Friend WithEvents ラベル558 As System.Windows.Forms.Label
    Friend WithEvents ラベル559 As System.Windows.Forms.Label

End Class