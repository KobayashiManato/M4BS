<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_VALQUA_長短振替仕訳

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
        Me.txt_FNAME_長短振替 = New System.Windows.Forms.TextBox()
        Me.txt_FNAME_短長戻し = New System.Windows.Forms.TextBox()
        Me.txt_KEIJYO_DT_戻し = New System.Windows.Forms.TextBox()
        Me.ラベル528 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.ラベル515 = New System.Windows.Forms.Label()
        Me.ラベル522 = New System.Windows.Forms.Label()
        Me.ラベル526 = New System.Windows.Forms.Label()
        Me.ラベル536 = New System.Windows.Forms.Label()
        Me.ラベル537 = New System.Windows.Forms.Label()
        Me.chk_長短振替F = New System.Windows.Forms.CheckBox()
        Me.chk_短長戻しF = New System.Windows.Forms.CheckBox()
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
        Me.cmd_選択.Location = New System.Drawing.Point(498, 113)
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
        Me.txt_FOLDER.Location = New System.Drawing.Point(117, 113)
        Me.txt_FOLDER.Name = "txt_FOLDER"
        Me.txt_FOLDER.Size = New System.Drawing.Size(377, 30)
        Me.txt_FOLDER.TabIndex = 4
        '
        ' txt_FNAME_長短振替
        '
        Me.txt_FNAME_長短振替.Location = New System.Drawing.Point(268, 173)
        Me.txt_FNAME_長短振替.Name = "txt_FNAME_長短振替"
        Me.txt_FNAME_長短振替.Size = New System.Drawing.Size(226, 19)
        Me.txt_FNAME_長短振替.TabIndex = 5
        '
        ' txt_FNAME_短長戻し
        '
        Me.txt_FNAME_短長戻し.Location = New System.Drawing.Point(268, 192)
        Me.txt_FNAME_短長戻し.Name = "txt_FNAME_短長戻し"
        Me.txt_FNAME_短長戻し.Size = New System.Drawing.Size(226, 19)
        Me.txt_FNAME_短長戻し.TabIndex = 6
        '
        ' txt_KEIJYO_DT_戻し
        '
        Me.txt_KEIJYO_DT_戻し.Location = New System.Drawing.Point(117, 75)
        Me.txt_KEIJYO_DT_戻し.Name = "txt_KEIJYO_DT_戻し"
        Me.txt_KEIJYO_DT_戻し.Size = New System.Drawing.Size(75, 19)
        Me.txt_KEIJYO_DT_戻し.TabIndex = 7
        '
        ' ラベル528
        '
        Me.ラベル528.AutoSize = True
        Me.ラベル528.Location = New System.Drawing.Point(18, 154)
        Me.ラベル528.Name = "ラベル528"
        Me.ラベル528.TabIndex = 8
        Me.ラベル528.Text = "ファイル名"
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(18, 56)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 9
        Me.Lbl.Text = "伝票計上日"
        '
        ' ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(215, 56)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.TabIndex = 10
        Me.ラベル512.Text = "yyyy/mm/dd の形式で入力してください"
        '
        ' ラベル515
        '
        Me.ラベル515.AutoSize = True
        Me.ラベル515.Location = New System.Drawing.Point(18, 113)
        Me.ラベル515.Name = "ラベル515"
        Me.ラベル515.TabIndex = 11
        Me.ラベル515.Text = "出力先フォルダ"
        '
        ' ラベル522
        '
        Me.ラベル522.AutoSize = True
        Me.ラベル522.Location = New System.Drawing.Point(18, 173)
        Me.ラベル522.Name = "ラベル522"
        Me.ラベル522.TabIndex = 12
        Me.ラベル522.Text = "No.6 長期⇒短期振替"
        '
        ' ラベル526
        '
        Me.ラベル526.AutoSize = True
        Me.ラベル526.Location = New System.Drawing.Point(18, 192)
        Me.ラベル526.Name = "ラベル526"
        Me.ラベル526.TabIndex = 13
        Me.ラベル526.Text = "No.7 短期⇒長期戻し"
        '
        ' ラベル536
        '
        Me.ラベル536.AutoSize = True
        Me.ラベル536.Location = New System.Drawing.Point(18, 75)
        Me.ラベル536.Name = "ラベル536"
        Me.ラベル536.TabIndex = 14
        Me.ラベル536.Text = "伝票計上日(戻し)"
        '
        ' ラベル537
        '
        Me.ラベル537.AutoSize = True
        Me.ラベル537.Location = New System.Drawing.Point(215, 75)
        Me.ラベル537.Name = "ラベル537"
        Me.ラベル537.TabIndex = 15
        Me.ラベル537.Text = "yyyy/mm/dd の形式で入力してください"
        '
        ' chk_長短振替F
        '
        Me.chk_長短振替F.AutoSize = True
        Me.chk_長短振替F.Location = New System.Drawing.Point(502, 177)
        Me.chk_長短振替F.Name = "chk_長短振替F"
        Me.chk_長短振替F.TabIndex = 16
        Me.chk_長短振替F.Text = ""
        Me.chk_長短振替F.UseVisualStyleBackColor = True
        '
        ' chk_短長戻しF
        '
        Me.chk_短長戻しF.AutoSize = True
        Me.chk_短長戻しF.Location = New System.Drawing.Point(502, 196)
        Me.chk_短長戻しF.Name = "chk_短長戻しF"
        Me.chk_短長戻しF.TabIndex = 17
        Me.chk_短長戻しF.Text = ""
        Me.chk_短長戻しF.UseVisualStyleBackColor = True
        '
        ' Form_fc_VALQUA_長短振替仕訳
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 443)
        Me.Controls.Add(Me.chk_長短振替F)
        Me.Controls.Add(Me.chk_短長戻しF)
        Me.Controls.Add(Me.ラベル528)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.ラベル515)
        Me.Controls.Add(Me.ラベル522)
        Me.Controls.Add(Me.ラベル526)
        Me.Controls.Add(Me.ラベル536)
        Me.Controls.Add(Me.ラベル537)
        Me.Controls.Add(Me.txt_KEIJYO_DT)
        Me.Controls.Add(Me.txt_FOLDER)
        Me.Controls.Add(Me.txt_FNAME_長短振替)
        Me.Controls.Add(Me.txt_FNAME_短長戻し)
        Me.Controls.Add(Me.txt_KEIJYO_DT_戻し)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_VALQUA_長短振替仕訳"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "リース債務返済明細一覧表　－　仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_KEIJYO_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_FOLDER As System.Windows.Forms.TextBox
    Friend WithEvents txt_FNAME_長短振替 As System.Windows.Forms.TextBox
    Friend WithEvents txt_FNAME_短長戻し As System.Windows.Forms.TextBox
    Friend WithEvents txt_KEIJYO_DT_戻し As System.Windows.Forms.TextBox
    Friend WithEvents ラベル528 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents ラベル515 As System.Windows.Forms.Label
    Friend WithEvents ラベル522 As System.Windows.Forms.Label
    Friend WithEvents ラベル526 As System.Windows.Forms.Label
    Friend WithEvents ラベル536 As System.Windows.Forms.Label
    Friend WithEvents ラベル537 As System.Windows.Forms.Label
    Friend WithEvents chk_長短振替F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_短長戻しF As System.Windows.Forms.CheckBox

End Class