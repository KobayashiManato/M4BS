<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_仕訳出力標準_KJ

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
        Me.txt_KEIJO_DT = New System.Windows.Forms.TextBox()
        Me.txt_対象年月 = New System.Windows.Forms.TextBox()
        Me.lbl_GUIDE3 = New System.Windows.Forms.Label()
        Me.ラベル514 = New System.Windows.Forms.Label()
        Me.lbl_GUIDE1 = New System.Windows.Forms.Label()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.lbl_GUIDE2 = New System.Windows.Forms.Label()
        Me.ラベル253 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(619, 170)
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
        Me.txt_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(132, 170)
        Me.txt_OUTPUT_FOLDER_NM.Name = "txt_OUTPUT_FOLDER_NM"
        Me.txt_OUTPUT_FOLDER_NM.Size = New System.Drawing.Size(483, 19)
        Me.txt_OUTPUT_FOLDER_NM.TabIndex = 4
        '
        ' txt_KEIJO_DT
        '
        Me.txt_KEIJO_DT.Location = New System.Drawing.Point(132, 139)
        Me.txt_KEIJO_DT.Name = "txt_KEIJO_DT"
        Me.txt_KEIJO_DT.Size = New System.Drawing.Size(75, 19)
        Me.txt_KEIJO_DT.TabIndex = 5
        '
        ' txt_対象年月
        '
        Me.txt_対象年月.Location = New System.Drawing.Point(132, 113)
        Me.txt_対象年月.Name = "txt_対象年月"
        Me.txt_対象年月.Size = New System.Drawing.Size(75, 19)
        Me.txt_対象年月.TabIndex = 6
        '
        ' lbl_GUIDE3
        '
        Me.lbl_GUIDE3.AutoSize = True
        Me.lbl_GUIDE3.Location = New System.Drawing.Point(75, 192)
        Me.lbl_GUIDE3.Name = "lbl_GUIDE3"
        Me.lbl_GUIDE3.TabIndex = 7
        Me.lbl_GUIDE3.Text = "YYYYMM_月次仕訳計上フレックス_仕訳_YYYYMMDDHHMM.xls の名前でファイルが生成されます。"
        '
        ' ラベル514
        '
        Me.ラベル514.AutoSize = True
        Me.ラベル514.Location = New System.Drawing.Point(37, 170)
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
        Me.lbl_GUIDE1.Text = "月次仕訳計上フレックスに表示中のデータから仕訳データを作成します。"
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(37, 139)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 10
        Me.ラベル521.Text = "計上日"
        '
        ' lbl_GUIDE2
        '
        Me.lbl_GUIDE2.AutoSize = True
        Me.lbl_GUIDE2.Location = New System.Drawing.Point(75, 75)
        Me.lbl_GUIDE2.Name = "lbl_GUIDE2"
        Me.lbl_GUIDE2.TabIndex = 11
        Me.lbl_GUIDE2.Text = "※検索条件が加味されます（検索条件が入力されている場合、検索条件で抽出された結果を元に仕訳データを作成します。）"
        '
        ' ラベル253
        '
        Me.ラベル253.AutoSize = True
        Me.ラベル253.Location = New System.Drawing.Point(37, 113)
        Me.ラベル253.Name = "ラベル253"
        Me.ラベル253.TabIndex = 12
        Me.ラベル253.Text = "対象年月"
        '
        ' Form_f_仕訳出力標準_KJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 260)
        Me.Controls.Add(Me.lbl_GUIDE3)
        Me.Controls.Add(Me.ラベル514)
        Me.Controls.Add(Me.lbl_GUIDE1)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.lbl_GUIDE2)
        Me.Controls.Add(Me.ラベル253)
        Me.Controls.Add(Me.txt_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.txt_KEIJO_DT)
        Me.Controls.Add(Me.txt_対象年月)
        Me.Controls.Add(Me.cmd_選択)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_設定)
        Me.Name = "Form_f_仕訳出力標準_KJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次仕訳計上フレックス 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_設定 As System.Windows.Forms.Button
    Friend WithEvents txt_OUTPUT_FOLDER_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_KEIJO_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_対象年月 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GUIDE3 As System.Windows.Forms.Label
    Friend WithEvents ラベル514 As System.Windows.Forms.Label
    Friend WithEvents lbl_GUIDE1 As System.Windows.Forms.Label
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents lbl_GUIDE2 As System.Windows.Forms.Label
    Friend WithEvents ラベル253 As System.Windows.Forms.Label

End Class