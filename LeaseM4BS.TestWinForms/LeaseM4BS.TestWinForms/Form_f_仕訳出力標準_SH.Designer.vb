<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_仕訳出力標準_SH

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
        Me.cmd_選択 = New System.Windows.Forms.Button()
        Me.cmd_実行 = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_設定 = New System.Windows.Forms.Button()
        Me.txt_OUTPUT_FOLDER_NM = New System.Windows.Forms.TextBox()
        Me.txt_対象年月 = New System.Windows.Forms.TextBox()
        Me.txt_KEIJO_DT = New System.Windows.Forms.TextBox()
        Me.lbl_GUIDE3 = New System.Windows.Forms.Label()
        Me.ラベル514 = New System.Windows.Forms.Label()
        Me.lbl_GUIDE1 = New System.Windows.Forms.Label()
        Me.lbl_GUIDE2 = New System.Windows.Forms.Label()
        Me.ラベル253 = New System.Windows.Forms.Label()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル484 = New System.Windows.Forms.Label()
        Me.ラベル522 = New System.Windows.Forms.Label()
        Me.ラベル256 = New System.Windows.Forms.Label()
        Me.オプション481 = New System.Windows.Forms.RadioButton()
        Me.オプション483 = New System.Windows.Forms.RadioButton()
        Me.オプション521 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(619, 222)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 0
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 1
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(90, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 2
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_設定
        '
        Me.cmd_設定.Location = New System.Drawing.Point(600, 7)
        Me.cmd_設定.Name = "cmd_設定"
        Me.cmd_設定.Size = New System.Drawing.Size(75, 26)
        Me.cmd_設定.TabIndex = 3
        Me.cmd_設定.Text = "設定(&D)"
        Me.cmd_設定.UseVisualStyleBackColor = True
        '
        ' txt_OUTPUT_FOLDER_NM
        '
        Me.txt_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(132, 222)
        Me.txt_OUTPUT_FOLDER_NM.Name = "txt_OUTPUT_FOLDER_NM"
        Me.txt_OUTPUT_FOLDER_NM.Size = New System.Drawing.Size(483, 19)
        Me.txt_OUTPUT_FOLDER_NM.TabIndex = 4
        '
        ' txt_対象年月
        '
        Me.txt_対象年月.Location = New System.Drawing.Point(132, 113)
        Me.txt_対象年月.Name = "txt_対象年月"
        Me.txt_対象年月.Size = New System.Drawing.Size(75, 19)
        Me.txt_対象年月.TabIndex = 5
        '
        ' txt_KEIJO_DT
        '
        Me.txt_KEIJO_DT.Location = New System.Drawing.Point(170, 143)
        Me.txt_KEIJO_DT.Name = "txt_KEIJO_DT"
        Me.txt_KEIJO_DT.Size = New System.Drawing.Size(75, 19)
        Me.txt_KEIJO_DT.TabIndex = 6
        '
        ' lbl_GUIDE3
        '
        Me.lbl_GUIDE3.AutoSize = True
        Me.lbl_GUIDE3.Location = New System.Drawing.Point(75, 245)
        Me.lbl_GUIDE3.Name = "lbl_GUIDE3"
        Me.lbl_GUIDE3.TabIndex = 7
        Me.lbl_GUIDE3.Text = "YYYYMM_月次支払照合フレックス_仕訳_YYYYMMDDHHMM.xls の名前でファイルが生成されます。"
        '
        ' ラベル514
        '
        Me.ラベル514.AutoSize = True
        Me.ラベル514.Location = New System.Drawing.Point(37, 222)
        Me.ラベル514.Name = "ラベル514"
        Me.ラベル514.TabIndex = 8
        Me.ラベル514.Text = "出力先ﾌｫﾙﾀﾞ名"
        '
        ' lbl_GUIDE1
        '
        Me.lbl_GUIDE1.AutoSize = True
        Me.lbl_GUIDE1.Location = New System.Drawing.Point(37, 56)
        Me.lbl_GUIDE1.Name = "lbl_GUIDE1"
        Me.lbl_GUIDE1.TabIndex = 9
        Me.lbl_GUIDE1.Text = "月次支払照合フレックスに表示中のデータから仕訳データを作成します。"
        '
        ' lbl_GUIDE2
        '
        Me.lbl_GUIDE2.AutoSize = True
        Me.lbl_GUIDE2.Location = New System.Drawing.Point(75, 75)
        Me.lbl_GUIDE2.Name = "lbl_GUIDE2"
        Me.lbl_GUIDE2.TabIndex = 10
        Me.lbl_GUIDE2.Text = "※検索条件が加味されます（検索条件が入力されている場合、検索条件で抽出された結果を元に仕訳データを作成します。）"
        '
        ' ラベル253
        '
        Me.ラベル253.AutoSize = True
        Me.ラベル253.Location = New System.Drawing.Point(37, 113)
        Me.ラベル253.Name = "ラベル253"
        Me.ラベル253.TabIndex = 11
        Me.ラベル253.Text = "対象年月"
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(37, 139)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 12
        Me.ラベル521.Text = "計上日"
        '
        ' ラベル484
        '
        Me.ラベル484.AutoSize = True
        Me.ラベル484.Location = New System.Drawing.Point(170, 166)
        Me.ラベル484.Name = "ラベル484"
        Me.ラベル484.TabIndex = 13
        Me.ラベル484.Text = "支払日"
        '
        ' ラベル522
        '
        Me.ラベル522.AutoSize = True
        Me.ラベル522.Location = New System.Drawing.Point(170, 188)
        Me.ラベル522.Name = "ラベル522"
        Me.ラベル522.TabIndex = 14
        Me.ラベル522.Text = "実際支払日"
        '
        ' ラベル256
        '
        Me.ラベル256.AutoSize = True
        Me.ラベル256.Location = New System.Drawing.Point(268, 139)
        Me.ラベル256.Name = "ラベル256"
        Me.ラベル256.TabIndex = 15
        Me.ラベル256.Text = "選択肢を変更する場合は「設定」をクリックします。"
        '
        ' オプション481
        '
        Me.オプション481.AutoSize = True
        Me.オプション481.Location = New System.Drawing.Point(143, 147)
        Me.オプション481.Name = "オプション481"
        Me.オプション481.TabIndex = 16
        Me.オプション481.Text = ""
        Me.オプション481.UseVisualStyleBackColor = True
        '
        ' オプション483
        '
        Me.オプション483.AutoSize = True
        Me.オプション483.Location = New System.Drawing.Point(143, 170)
        Me.オプション483.Name = "オプション483"
        Me.オプション483.TabIndex = 17
        Me.オプション483.Text = ""
        Me.オプション483.UseVisualStyleBackColor = True
        '
        ' オプション521
        '
        Me.オプション521.AutoSize = True
        Me.オプション521.Location = New System.Drawing.Point(143, 192)
        Me.オプション521.Name = "オプション521"
        Me.オプション521.TabIndex = 18
        Me.オプション521.Text = ""
        Me.オプション521.UseVisualStyleBackColor = True
        '
        ' Form_f_仕訳出力標準_SH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 313)
        Me.Controls.Add(Me.オプション481)
        Me.Controls.Add(Me.オプション483)
        Me.Controls.Add(Me.オプション521)
        Me.Controls.Add(Me.lbl_GUIDE3)
        Me.Controls.Add(Me.ラベル514)
        Me.Controls.Add(Me.lbl_GUIDE1)
        Me.Controls.Add(Me.lbl_GUIDE2)
        Me.Controls.Add(Me.ラベル253)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル484)
        Me.Controls.Add(Me.ラベル522)
        Me.Controls.Add(Me.ラベル256)
        Me.Controls.Add(Me.txt_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.txt_対象年月)
        Me.Controls.Add(Me.txt_KEIJO_DT)
        Me.Controls.Add(Me.cmd_選択)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_設定)
        Me.Name = "Form_f_仕訳出力標準_SH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次支払照合フレックス 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_設定 As System.Windows.Forms.Button
    Friend WithEvents txt_OUTPUT_FOLDER_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_対象年月 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KEIJO_DT As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GUIDE3 As System.Windows.Forms.Label
    Friend WithEvents ラベル514 As System.Windows.Forms.Label
    Friend WithEvents lbl_GUIDE1 As System.Windows.Forms.Label
    Friend WithEvents lbl_GUIDE2 As System.Windows.Forms.Label
    Friend WithEvents ラベル253 As System.Windows.Forms.Label
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル484 As System.Windows.Forms.Label
    Friend WithEvents ラベル522 As System.Windows.Forms.Label
    Friend WithEvents ラベル256 As System.Windows.Forms.Label
    Friend WithEvents オプション481 As System.Windows.Forms.RadioButton
    Friend WithEvents オプション483 As System.Windows.Forms.RadioButton
    Friend WithEvents オプション521 As System.Windows.Forms.RadioButton

End Class