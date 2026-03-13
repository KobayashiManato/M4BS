<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SANKO_AIR_振替伝票_計上用_出力指示

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
        Me.txt_担当CD = New System.Windows.Forms.TextBox()
        Me.txt_連番開始値 = New System.Windows.Forms.TextBox()
        Me.txt_発行日 = New System.Windows.Forms.TextBox()
        Me.txt_発行者名 = New System.Windows.Forms.TextBox()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル549 = New System.Windows.Forms.Label()
        Me.lbl_OUTPUT_FOLDER_NM = New System.Windows.Forms.Label()
        Me.ラベル538 = New System.Windows.Forms.Label()
        Me.ラベル539 = New System.Windows.Forms.Label()
        Me.ラベル540 = New System.Windows.Forms.Label()
        Me.ラベル556 = New System.Windows.Forms.Label()
        Me.ラベル558 = New System.Windows.Forms.Label()
        Me.ラベル559 = New System.Windows.Forms.Label()
        Me.ラベル552 = New System.Windows.Forms.Label()
        Me.chk_検索条件加味_F = New System.Windows.Forms.CheckBox()
        Me.chk_EXCEL出力_F = New System.Windows.Forms.CheckBox()
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
        Me.cmd_選択.Location = New System.Drawing.Point(495, 113)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 2
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_OUTPUT_FOLDER_NM
        '
        Me.txt_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(151, 113)
        Me.txt_OUTPUT_FOLDER_NM.Name = "txt_OUTPUT_FOLDER_NM"
        Me.txt_OUTPUT_FOLDER_NM.Size = New System.Drawing.Size(340, 19)
        Me.txt_OUTPUT_FOLDER_NM.TabIndex = 3
        '
        ' txt_担当CD
        '
        Me.txt_担当CD.Location = New System.Drawing.Point(151, 173)
        Me.txt_担当CD.Name = "txt_担当CD"
        Me.txt_担当CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_担当CD.TabIndex = 4
        '
        ' txt_連番開始値
        '
        Me.txt_連番開始値.Location = New System.Drawing.Point(453, 173)
        Me.txt_連番開始値.Name = "txt_連番開始値"
        Me.txt_連番開始値.Size = New System.Drawing.Size(75, 19)
        Me.txt_連番開始値.TabIndex = 5
        '
        ' txt_発行日
        '
        Me.txt_発行日.Location = New System.Drawing.Point(302, 173)
        Me.txt_発行日.Name = "txt_発行日"
        Me.txt_発行日.Size = New System.Drawing.Size(75, 19)
        Me.txt_発行日.TabIndex = 6
        '
        ' txt_発行者名
        '
        Me.txt_発行者名.Location = New System.Drawing.Point(377, 83)
        Me.txt_発行者名.Name = "txt_発行者名"
        Me.txt_発行者名.Size = New System.Drawing.Size(75, 19)
        Me.txt_発行者名.TabIndex = 7
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(75, 83)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 8
        Me.ラベル521.Text = "フレックスリストの検索条件を加味する"
        '
        ' ラベル549
        '
        Me.ラベル549.AutoSize = True
        Me.ラベル549.Location = New System.Drawing.Point(18, 56)
        Me.ラベル549.Name = "ラベル549"
        Me.ラベル549.TabIndex = 9
        Me.ラベル549.Text = "振替伝票（計上用）を印刷します。"
        '
        ' lbl_OUTPUT_FOLDER_NM
        '
        Me.lbl_OUTPUT_FOLDER_NM.AutoSize = True
        Me.lbl_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(37, 113)
        Me.lbl_OUTPUT_FOLDER_NM.Name = "lbl_OUTPUT_FOLDER_NM"
        Me.lbl_OUTPUT_FOLDER_NM.TabIndex = 10
        Me.lbl_OUTPUT_FOLDER_NM.Text = "出力先ﾌｫﾙﾀﾞ"
        '
        ' ラベル538
        '
        Me.ラベル538.AutoSize = True
        Me.ラベル538.Location = New System.Drawing.Point(75, 173)
        Me.ラベル538.Name = "ラベル538"
        Me.ラベル538.TabIndex = 11
        Me.ラベル538.Text = "担当CD"
        '
        ' ラベル539
        '
        Me.ラベル539.AutoSize = True
        Me.ラベル539.Location = New System.Drawing.Point(56, 136)
        Me.ラベル539.Name = "ラベル539"
        Me.ラベル539.TabIndex = 12
        Me.ラベル539.Text = "伝票ファイル名 － ファイル名は [担当CD] + \"
        '
        ' ラベル540
        '
        Me.ラベル540.AutoSize = True
        Me.ラベル540.Location = New System.Drawing.Point(377, 173)
        Me.ラベル540.Name = "ラベル540"
        Me.ラベル540.TabIndex = 13
        Me.ラベル540.Text = "連番開始値"
        '
        ' ラベル556
        '
        Me.ラベル556.AutoSize = True
        Me.ラベル556.Location = New System.Drawing.Point(226, 173)
        Me.ラベル556.Name = "ラベル556"
        Me.ラベル556.TabIndex = 14
        Me.ラベル556.Text = "発行日"
        '
        ' ラベル558
        '
        Me.ラベル558.AutoSize = True
        Me.ラベル558.Location = New System.Drawing.Point(56, 154)
        Me.ラベル558.Name = "ラベル558"
        Me.ラベル558.TabIndex = 15
        Me.ラベル558.Text = "明細ファイル名 － ファイル名は [担当CD] + \"
        '
        ' ラベル559
        '
        Me.ラベル559.AutoSize = True
        Me.ラベル559.Location = New System.Drawing.Point(302, 83)
        Me.ラベル559.Name = "ラベル559"
        Me.ラベル559.TabIndex = 16
        Me.ラベル559.Text = "発行者名"
        '
        ' ラベル552
        '
        Me.ラベル552.AutoSize = True
        Me.ラベル552.Location = New System.Drawing.Point(18, 0)
        Me.ラベル552.Name = "ラベル552"
        Me.ラベル552.TabIndex = 17
        Me.ラベル552.Text = "明細のEXCEL出力を行う"
        '
        ' chk_検索条件加味_F
        '
        Me.chk_検索条件加味_F.AutoSize = True
        Me.chk_検索条件加味_F.Location = New System.Drawing.Point(56, 83)
        Me.chk_検索条件加味_F.Name = "chk_検索条件加味_F"
        Me.chk_検索条件加味_F.TabIndex = 18
        Me.chk_検索条件加味_F.Text = ""
        Me.chk_検索条件加味_F.UseVisualStyleBackColor = True
        '
        ' chk_EXCEL出力_F
        '
        Me.chk_EXCEL出力_F.AutoSize = True
        Me.chk_EXCEL出力_F.Location = New System.Drawing.Point(0, 0)
        Me.chk_EXCEL出力_F.Name = "chk_EXCEL出力_F"
        Me.chk_EXCEL出力_F.TabIndex = 19
        Me.chk_EXCEL出力_F.Text = ""
        Me.chk_EXCEL出力_F.UseVisualStyleBackColor = True
        '
        ' Form_fc_SANKO_AIR_振替伝票_計上用_出力指示
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 404)
        Me.Controls.Add(Me.chk_検索条件加味_F)
        Me.Controls.Add(Me.chk_EXCEL出力_F)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル549)
        Me.Controls.Add(Me.lbl_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.ラベル538)
        Me.Controls.Add(Me.ラベル539)
        Me.Controls.Add(Me.ラベル540)
        Me.Controls.Add(Me.ラベル556)
        Me.Controls.Add(Me.ラベル558)
        Me.Controls.Add(Me.ラベル559)
        Me.Controls.Add(Me.ラベル552)
        Me.Controls.Add(Me.txt_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.txt_担当CD)
        Me.Controls.Add(Me.txt_連番開始値)
        Me.Controls.Add(Me.txt_発行日)
        Me.Controls.Add(Me.txt_発行者名)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_SANKO_AIR_振替伝票_計上用_出力指示"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "振替伝票（計上用）出力指示"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_OUTPUT_FOLDER_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_担当CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_連番開始値 As System.Windows.Forms.TextBox
    Friend WithEvents txt_発行日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_発行者名 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル549 As System.Windows.Forms.Label
    Friend WithEvents lbl_OUTPUT_FOLDER_NM As System.Windows.Forms.Label
    Friend WithEvents ラベル538 As System.Windows.Forms.Label
    Friend WithEvents ラベル539 As System.Windows.Forms.Label
    Friend WithEvents ラベル540 As System.Windows.Forms.Label
    Friend WithEvents ラベル556 As System.Windows.Forms.Label
    Friend WithEvents ラベル558 As System.Windows.Forms.Label
    Friend WithEvents ラベル559 As System.Windows.Forms.Label
    Friend WithEvents ラベル552 As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_EXCEL出力_F As System.Windows.Forms.CheckBox

End Class