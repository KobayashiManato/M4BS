<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_VALQUA_計上仕訳

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
        Me.txt_KEIJYO_DT = New System.Windows.Forms.TextBox()
        Me.txt_FOLDER = New System.Windows.Forms.TextBox()
        Me.txt_FNAME_資産計上 = New System.Windows.Forms.TextBox()
        Me.txt_FNAME_債務取崩 = New System.Windows.Forms.TextBox()
        Me.ラベル528 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.ラベル515 = New System.Windows.Forms.Label()
        Me.ラベル522 = New System.Windows.Forms.Label()
        Me.ラベル526 = New System.Windows.Forms.Label()
        Me.chk_資産計上F = New System.Windows.Forms.CheckBox()
        Me.chk_債務取崩F = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 30)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(90, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 30)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(498, 90)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 30)
        Me.cmd_選択.TabIndex = 2
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_KEIJYO_DT
        '
        Me.txt_KEIJYO_DT.Location = New System.Drawing.Point(117, 56)
        Me.txt_KEIJYO_DT.Name = "txt_KEIJYO_DT"
        Me.txt_KEIJYO_DT.Size = New System.Drawing.Size(75, 19)
        Me.txt_KEIJYO_DT.TabIndex = 3
        '
        ' txt_FOLDER
        '
        Me.txt_FOLDER.Location = New System.Drawing.Point(117, 90)
        Me.txt_FOLDER.Name = "txt_FOLDER"
        Me.txt_FOLDER.Size = New System.Drawing.Size(377, 30)
        Me.txt_FOLDER.TabIndex = 4
        '
        ' txt_FNAME_資産計上
        '
        Me.txt_FNAME_資産計上.Location = New System.Drawing.Point(268, 151)
        Me.txt_FNAME_資産計上.Name = "txt_FNAME_資産計上"
        Me.txt_FNAME_資産計上.Size = New System.Drawing.Size(207, 19)
        Me.txt_FNAME_資産計上.TabIndex = 5
        '
        ' txt_FNAME_債務取崩
        '
        Me.txt_FNAME_債務取崩.Location = New System.Drawing.Point(268, 170)
        Me.txt_FNAME_債務取崩.Name = "txt_FNAME_債務取崩"
        Me.txt_FNAME_債務取崩.Size = New System.Drawing.Size(207, 19)
        Me.txt_FNAME_債務取崩.TabIndex = 6
        '
        ' ラベル528
        '
        Me.ラベル528.AutoSize = True
        Me.ラベル528.Location = New System.Drawing.Point(18, 132)
        Me.ラベル528.Name = "ラベル528"
        Me.ラベル528.TabIndex = 7
        Me.ラベル528.Text = "ファイル名"
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(18, 56)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 8
        Me.Lbl.Text = "伝票計上日"
        '
        ' ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(215, 56)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.TabIndex = 9
        Me.ラベル512.Text = "yyyy/mm/dd の形式で入力してください"
        '
        ' ラベル515
        '
        Me.ラベル515.AutoSize = True
        Me.ラベル515.Location = New System.Drawing.Point(18, 90)
        Me.ラベル515.Name = "ラベル515"
        Me.ラベル515.TabIndex = 10
        Me.ラベル515.Text = "出力先フォルダ"
        '
        ' ラベル522
        '
        Me.ラベル522.AutoSize = True
        Me.ラベル522.Location = New System.Drawing.Point(18, 151)
        Me.ラベル522.Name = "ラベル522"
        Me.ラベル522.TabIndex = 11
        Me.ラベル522.Text = "No.3 リース資産計上"
        '
        ' ラベル526
        '
        Me.ラベル526.AutoSize = True
        Me.ラベル526.Location = New System.Drawing.Point(18, 170)
        Me.ラベル526.Name = "ラベル526"
        Me.ラベル526.TabIndex = 12
        Me.ラベル526.Text = "No.5 未払計上 リース債務取崩、支払利息計上"
        '
        ' chk_資産計上F
        '
        Me.chk_資産計上F.AutoSize = True
        Me.chk_資産計上F.Location = New System.Drawing.Point(483, 154)
        Me.chk_資産計上F.Name = "chk_資産計上F"
        Me.chk_資産計上F.TabIndex = 13
        Me.chk_資産計上F.Text = ""
        Me.chk_資産計上F.UseVisualStyleBackColor = True
        '
        ' chk_債務取崩F
        '
        Me.chk_債務取崩F.AutoSize = True
        Me.chk_債務取崩F.Location = New System.Drawing.Point(483, 174)
        Me.chk_債務取崩F.Name = "chk_債務取崩F"
        Me.chk_債務取崩F.TabIndex = 14
        Me.chk_債務取崩F.Text = ""
        Me.chk_債務取崩F.UseVisualStyleBackColor = True
        '
        ' Form_fc_VALQUA_計上仕訳
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 443)
        Me.Controls.Add(Me.chk_資産計上F)
        Me.Controls.Add(Me.chk_債務取崩F)
        Me.Controls.Add(Me.ラベル528)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.ラベル515)
        Me.Controls.Add(Me.ラベル522)
        Me.Controls.Add(Me.ラベル526)
        Me.Controls.Add(Me.txt_KEIJYO_DT)
        Me.Controls.Add(Me.txt_FOLDER)
        Me.Controls.Add(Me.txt_FNAME_資産計上)
        Me.Controls.Add(Me.txt_FNAME_債務取崩)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_VALQUA_計上仕訳"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次仕訳計上フレックス　－　仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_KEIJYO_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_FOLDER As System.Windows.Forms.TextBox
    Friend WithEvents txt_FNAME_資産計上 As System.Windows.Forms.TextBox
    Friend WithEvents txt_FNAME_債務取崩 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル528 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents ラベル515 As System.Windows.Forms.Label
    Friend WithEvents ラベル522 As System.Windows.Forms.Label
    Friend WithEvents ラベル526 As System.Windows.Forms.Label
    Friend WithEvents chk_資産計上F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_債務取崩F As System.Windows.Forms.CheckBox

End Class