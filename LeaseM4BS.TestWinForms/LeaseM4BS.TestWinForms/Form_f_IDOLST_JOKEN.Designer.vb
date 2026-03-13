<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_IDOLST_JOKEN

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
        Me.cmd_EXECUTE = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_ZENKAI = New System.Windows.Forms.Button()
        Me.ラベル513 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.lbl_Category = New System.Windows.Forms.Label()
        Me.lbl_BCAT1_F = New System.Windows.Forms.Label()
        Me.lbl_BCAT2_F = New System.Windows.Forms.Label()
        Me.lbl_BCAT3_F = New System.Windows.Forms.Label()
        Me.lbl_BCAT4_F = New System.Windows.Forms.Label()
        Me.lbl_BCAT5_F = New System.Windows.Forms.Label()
        Me.ラベル512 = New System.Windows.Forms.Label()
        Me.chk_BCAT1_F = New System.Windows.Forms.CheckBox()
        Me.chk_BCAT2_F = New System.Windows.Forms.CheckBox()
        Me.chk_BCAT3_F = New System.Windows.Forms.CheckBox()
        Me.chk_BCAT4_F = New System.Windows.Forms.CheckBox()
        Me.chk_BCAT5_F = New System.Windows.Forms.CheckBox()
        Me.txt_IDO_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.txt_IDO_DT_TO = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'cmd_EXECUTE
        '
        Me.cmd_EXECUTE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_EXECUTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXECUTE.Name = "cmd_EXECUTE"
        Me.cmd_EXECUTE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_EXECUTE.TabIndex = 2
        Me.cmd_EXECUTE.Text = "実行(&R)"
        Me.cmd_EXECUTE.UseVisualStyleBackColor = True
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(152, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CANCEL.TabIndex = 3
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(612, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(170, 39)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'ラベル513
        '
        Me.ラベル513.AutoSize = True
        Me.ラベル513.Location = New System.Drawing.Point(315, 87)
        Me.ラベル513.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル513.Name = "ラベル513"
        Me.ラベル513.Size = New System.Drawing.Size(26, 18)
        Me.ラベル513.TabIndex = 5
        Me.ラベル513.Text = "～"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(29, 82)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(62, 18)
        Me.Lbl.TabIndex = 6
        Me.Lbl.Text = "移動日"
        '
        'lbl_Category
        '
        Me.lbl_Category.AutoSize = True
        Me.lbl_Category.Location = New System.Drawing.Point(64, 173)
        Me.lbl_Category.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Category.Name = "lbl_Category"
        Me.lbl_Category.Size = New System.Drawing.Size(451, 18)
        Me.lbl_Category.TabIndex = 7
        Me.lbl_Category.Text = "管理部署カテゴリのうち、移動とみなすものにチェックして下さい。"
        '
        'lbl_BCAT1_F
        '
        Me.lbl_BCAT1_F.AutoSize = True
        Me.lbl_BCAT1_F.Location = New System.Drawing.Point(64, 211)
        Me.lbl_BCAT1_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_BCAT1_F.Name = "lbl_BCAT1_F"
        Me.lbl_BCAT1_F.Size = New System.Drawing.Size(92, 18)
        Me.lbl_BCAT1_F.TabIndex = 8
        Me.lbl_BCAT1_F.Text = "管理部署１"
        '
        'lbl_BCAT2_F
        '
        Me.lbl_BCAT2_F.AutoSize = True
        Me.lbl_BCAT2_F.Location = New System.Drawing.Point(64, 240)
        Me.lbl_BCAT2_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_BCAT2_F.Name = "lbl_BCAT2_F"
        Me.lbl_BCAT2_F.Size = New System.Drawing.Size(92, 18)
        Me.lbl_BCAT2_F.TabIndex = 9
        Me.lbl_BCAT2_F.Text = "管理部署２"
        '
        'lbl_BCAT3_F
        '
        Me.lbl_BCAT3_F.AutoSize = True
        Me.lbl_BCAT3_F.Location = New System.Drawing.Point(64, 269)
        Me.lbl_BCAT3_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_BCAT3_F.Name = "lbl_BCAT3_F"
        Me.lbl_BCAT3_F.Size = New System.Drawing.Size(92, 18)
        Me.lbl_BCAT3_F.TabIndex = 10
        Me.lbl_BCAT3_F.Text = "管理部署３"
        '
        'lbl_BCAT4_F
        '
        Me.lbl_BCAT4_F.AutoSize = True
        Me.lbl_BCAT4_F.Location = New System.Drawing.Point(64, 297)
        Me.lbl_BCAT4_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_BCAT4_F.Name = "lbl_BCAT4_F"
        Me.lbl_BCAT4_F.Size = New System.Drawing.Size(92, 18)
        Me.lbl_BCAT4_F.TabIndex = 11
        Me.lbl_BCAT4_F.Text = "管理部署４"
        '
        'lbl_BCAT5_F
        '
        Me.lbl_BCAT5_F.AutoSize = True
        Me.lbl_BCAT5_F.Location = New System.Drawing.Point(64, 325)
        Me.lbl_BCAT5_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_BCAT5_F.Name = "lbl_BCAT5_F"
        Me.lbl_BCAT5_F.Size = New System.Drawing.Size(92, 18)
        Me.lbl_BCAT5_F.TabIndex = 12
        Me.lbl_BCAT5_F.Text = "管理部署５"
        '
        'ラベル512
        '
        Me.ラベル512.AutoSize = True
        Me.ラベル512.Location = New System.Drawing.Point(190, 127)
        Me.ラベル512.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル512.Name = "ラベル512"
        Me.ラベル512.Size = New System.Drawing.Size(290, 18)
        Me.ラベル512.TabIndex = 13
        Me.ラベル512.Text = "yyyy/mm/dd の形式で入力してください"
        '
        'chk_BCAT1_F
        '
        Me.chk_BCAT1_F.AutoSize = True
        Me.chk_BCAT1_F.Checked = True
        Me.chk_BCAT1_F.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_BCAT1_F.Location = New System.Drawing.Point(247, 217)
        Me.chk_BCAT1_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_BCAT1_F.Name = "chk_BCAT1_F"
        Me.chk_BCAT1_F.Size = New System.Drawing.Size(22, 21)
        Me.chk_BCAT1_F.TabIndex = 5
        Me.chk_BCAT1_F.UseVisualStyleBackColor = True
        '
        'chk_BCAT2_F
        '
        Me.chk_BCAT2_F.AutoSize = True
        Me.chk_BCAT2_F.Checked = True
        Me.chk_BCAT2_F.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_BCAT2_F.Location = New System.Drawing.Point(247, 246)
        Me.chk_BCAT2_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_BCAT2_F.Name = "chk_BCAT2_F"
        Me.chk_BCAT2_F.Size = New System.Drawing.Size(22, 21)
        Me.chk_BCAT2_F.TabIndex = 6
        Me.chk_BCAT2_F.UseVisualStyleBackColor = True
        '
        'chk_BCAT3_F
        '
        Me.chk_BCAT3_F.AutoSize = True
        Me.chk_BCAT3_F.Checked = True
        Me.chk_BCAT3_F.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_BCAT3_F.Location = New System.Drawing.Point(247, 275)
        Me.chk_BCAT3_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_BCAT3_F.Name = "chk_BCAT3_F"
        Me.chk_BCAT3_F.Size = New System.Drawing.Size(22, 21)
        Me.chk_BCAT3_F.TabIndex = 7
        Me.chk_BCAT3_F.UseVisualStyleBackColor = True
        '
        'chk_BCAT4_F
        '
        Me.chk_BCAT4_F.AutoSize = True
        Me.chk_BCAT4_F.Location = New System.Drawing.Point(247, 303)
        Me.chk_BCAT4_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_BCAT4_F.Name = "chk_BCAT4_F"
        Me.chk_BCAT4_F.Size = New System.Drawing.Size(22, 21)
        Me.chk_BCAT4_F.TabIndex = 8
        Me.chk_BCAT4_F.UseVisualStyleBackColor = True
        '
        'chk_BCAT5_F
        '
        Me.chk_BCAT5_F.AutoSize = True
        Me.chk_BCAT5_F.Location = New System.Drawing.Point(247, 331)
        Me.chk_BCAT5_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_BCAT5_F.Name = "chk_BCAT5_F"
        Me.chk_BCAT5_F.Size = New System.Drawing.Size(22, 21)
        Me.chk_BCAT5_F.TabIndex = 9
        Me.chk_BCAT5_F.UseVisualStyleBackColor = True
        '
        'txt_IDO_DT_FROM
        '
        Me.txt_IDO_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_IDO_DT_FROM.Location = New System.Drawing.Point(132, 82)
        Me.txt_IDO_DT_FROM.Name = "txt_IDO_DT_FROM"
        Me.txt_IDO_DT_FROM.Size = New System.Drawing.Size(175, 25)
        Me.txt_IDO_DT_FROM.TabIndex = 0
        '
        'txt_IDO_DT_TO
        '
        Me.txt_IDO_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_IDO_DT_TO.Location = New System.Drawing.Point(349, 82)
        Me.txt_IDO_DT_TO.Name = "txt_IDO_DT_TO"
        Me.txt_IDO_DT_TO.Size = New System.Drawing.Size(175, 25)
        Me.txt_IDO_DT_TO.TabIndex = 1
        '
        'Form_f_IDOLST_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 426)
        Me.Controls.Add(Me.txt_IDO_DT_TO)
        Me.Controls.Add(Me.txt_IDO_DT_FROM)
        Me.Controls.Add(Me.chk_BCAT1_F)
        Me.Controls.Add(Me.chk_BCAT2_F)
        Me.Controls.Add(Me.chk_BCAT3_F)
        Me.Controls.Add(Me.chk_BCAT4_F)
        Me.Controls.Add(Me.chk_BCAT5_F)
        Me.Controls.Add(Me.ラベル513)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.lbl_Category)
        Me.Controls.Add(Me.lbl_BCAT1_F)
        Me.Controls.Add(Me.lbl_BCAT2_F)
        Me.Controls.Add(Me.lbl_BCAT3_F)
        Me.Controls.Add(Me.lbl_BCAT4_F)
        Me.Controls.Add(Me.lbl_BCAT5_F)
        Me.Controls.Add(Me.ラベル512)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_IDOLST_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "移動物件一覧表　期間設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_ZENKAI As System.Windows.Forms.Button
    Friend WithEvents ラベル513 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents lbl_Category As System.Windows.Forms.Label
    Friend WithEvents lbl_BCAT1_F As System.Windows.Forms.Label
    Friend WithEvents lbl_BCAT2_F As System.Windows.Forms.Label
    Friend WithEvents lbl_BCAT3_F As System.Windows.Forms.Label
    Friend WithEvents lbl_BCAT4_F As System.Windows.Forms.Label
    Friend WithEvents lbl_BCAT5_F As System.Windows.Forms.Label
    Friend WithEvents ラベル512 As System.Windows.Forms.Label
    Friend WithEvents chk_BCAT1_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BCAT2_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BCAT3_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BCAT4_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_BCAT5_F As System.Windows.Forms.CheckBox
    Friend WithEvents txt_IDO_DT_FROM As DateTimePicker
    Friend WithEvents txt_IDO_DT_TO As DateTimePicker
End Class