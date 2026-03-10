<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_KHIYO_JOKEN

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
        Me.txt_DURATION = New System.Windows.Forms.TextBox()
        Me.lbl_To = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.lbl_GETU = New System.Windows.Forms.Label()
        Me.lbl_Description = New System.Windows.Forms.Label()
        Me.ラベル485 = New System.Windows.Forms.Label()
        Me.chk_REC_KBN_5 = New System.Windows.Forms.CheckBox()
        Me.chk_REC_KBN_6 = New System.Windows.Forms.CheckBox()
        Me.chk_REC_KBN_1 = New System.Windows.Forms.CheckBox()
        Me.chk_REC_KBN_3 = New System.Windows.Forms.CheckBox()
        Me.chk_REC_KBN_2 = New System.Windows.Forms.CheckBox()
        Me.chk_REC_KBN_4 = New System.Windows.Forms.CheckBox()
        Me.radio_MINUS = New System.Windows.Forms.RadioButton()
        Me.radio_PLUS = New System.Windows.Forms.RadioButton()
        Me.radio_SHIME = New System.Windows.Forms.RadioButton()
        Me.radio_PAYMENT = New System.Windows.Forms.RadioButton()
        Me.txt_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.txt_DT_TO = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_REC_KBN_7 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.cmd_CANCEL.Location = New System.Drawing.Point(149, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CANCEL.TabIndex = 3
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(636, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(170, 39)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'txt_DURATION
        '
        Me.txt_DURATION.Location = New System.Drawing.Point(596, 97)
        Me.txt_DURATION.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_DURATION.Name = "txt_DURATION"
        Me.txt_DURATION.Size = New System.Drawing.Size(81, 25)
        Me.txt_DURATION.TabIndex = 5
        '
        'lbl_To
        '
        Me.lbl_To.AutoSize = True
        Me.lbl_To.Location = New System.Drawing.Point(340, 97)
        Me.lbl_To.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_To.Name = "lbl_To"
        Me.lbl_To.Size = New System.Drawing.Size(26, 18)
        Me.lbl_To.TabIndex = 6
        Me.lbl_To.Text = "～"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(57, 97)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(80, 18)
        Me.Lbl.TabIndex = 7
        Me.Lbl.Text = "集計期間"
        '
        'lbl_GETU
        '
        Me.lbl_GETU.AutoSize = True
        Me.lbl_GETU.Location = New System.Drawing.Point(676, 100)
        Me.lbl_GETU.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_GETU.Name = "lbl_GETU"
        Me.lbl_GETU.Size = New System.Drawing.Size(38, 18)
        Me.lbl_GETU.TabIndex = 8
        Me.lbl_GETU.Text = "ヶ月"
        '
        'lbl_Description
        '
        Me.lbl_Description.AutoSize = True
        Me.lbl_Description.Location = New System.Drawing.Point(215, 137)
        Me.lbl_Description.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Description.Name = "lbl_Description"
        Me.lbl_Description.Size = New System.Drawing.Size(263, 18)
        Me.lbl_Description.TabIndex = 9
        Me.lbl_Description.Text = "yyyy/mm の形式で入力してください"
        '
        'ラベル485
        '
        Me.ラベル485.AutoSize = True
        Me.ラベル485.Location = New System.Drawing.Point(41, 44)
        Me.ラベル485.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル485.Name = "ラベル485"
        Me.ラベル485.Size = New System.Drawing.Size(223, 18)
        Me.ラベル485.TabIndex = 21
        Me.ラベル485.Text = "計上ﾀｲﾐﾝｸﾞ(支払額・保守料)"
        '
        'chk_REC_KBN_5
        '
        Me.chk_REC_KBN_5.AutoSize = True
        Me.chk_REC_KBN_5.Location = New System.Drawing.Point(58, 181)
        Me.chk_REC_KBN_5.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_5.Name = "chk_REC_KBN_5"
        Me.chk_REC_KBN_5.Size = New System.Drawing.Size(142, 22)
        Me.chk_REC_KBN_5.TabIndex = 4
        Me.chk_REC_KBN_5.Text = "維持管理費用"
        Me.chk_REC_KBN_5.UseVisualStyleBackColor = True
        '
        'chk_REC_KBN_6
        '
        Me.chk_REC_KBN_6.AutoSize = True
        Me.chk_REC_KBN_6.Location = New System.Drawing.Point(58, 211)
        Me.chk_REC_KBN_6.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_6.Name = "chk_REC_KBN_6"
        Me.chk_REC_KBN_6.Size = New System.Drawing.Size(106, 22)
        Me.chk_REC_KBN_6.TabIndex = 5
        Me.chk_REC_KBN_6.Text = "減損損失"
        Me.chk_REC_KBN_6.UseVisualStyleBackColor = True
        '
        'chk_REC_KBN_1
        '
        Me.chk_REC_KBN_1.AutoSize = True
        Me.chk_REC_KBN_1.Location = New System.Drawing.Point(58, 61)
        Me.chk_REC_KBN_1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_1.Name = "chk_REC_KBN_1"
        Me.chk_REC_KBN_1.Size = New System.Drawing.Size(378, 22)
        Me.chk_REC_KBN_1.TabIndex = 0
        Me.chk_REC_KBN_1.Text = "支払額（※計上区分 ＝ 費用の場合のみ出力）"
        Me.chk_REC_KBN_1.UseVisualStyleBackColor = True
        '
        'chk_REC_KBN_3
        '
        Me.chk_REC_KBN_3.AutoSize = True
        Me.chk_REC_KBN_3.Location = New System.Drawing.Point(58, 121)
        Me.chk_REC_KBN_3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_3.Name = "chk_REC_KBN_3"
        Me.chk_REC_KBN_3.Size = New System.Drawing.Size(88, 22)
        Me.chk_REC_KBN_3.TabIndex = 2
        Me.chk_REC_KBN_3.Text = "償却費"
        Me.chk_REC_KBN_3.UseVisualStyleBackColor = True
        '
        'chk_REC_KBN_2
        '
        Me.chk_REC_KBN_2.AutoSize = True
        Me.chk_REC_KBN_2.Checked = True
        Me.chk_REC_KBN_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_REC_KBN_2.Location = New System.Drawing.Point(58, 91)
        Me.chk_REC_KBN_2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_2.Name = "chk_REC_KBN_2"
        Me.chk_REC_KBN_2.Size = New System.Drawing.Size(88, 22)
        Me.chk_REC_KBN_2.TabIndex = 1
        Me.chk_REC_KBN_2.Text = "保守料"
        Me.chk_REC_KBN_2.UseVisualStyleBackColor = True
        '
        'chk_REC_KBN_4
        '
        Me.chk_REC_KBN_4.AutoSize = True
        Me.chk_REC_KBN_4.Location = New System.Drawing.Point(58, 151)
        Me.chk_REC_KBN_4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_4.Name = "chk_REC_KBN_4"
        Me.chk_REC_KBN_4.Size = New System.Drawing.Size(106, 22)
        Me.chk_REC_KBN_4.TabIndex = 3
        Me.chk_REC_KBN_4.Text = "支払利息"
        Me.chk_REC_KBN_4.UseVisualStyleBackColor = True
        '
        'radio_MINUS
        '
        Me.radio_MINUS.AutoSize = True
        Me.radio_MINUS.Checked = True
        Me.radio_MINUS.Location = New System.Drawing.Point(119, 299)
        Me.radio_MINUS.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_MINUS.Name = "radio_MINUS"
        Me.radio_MINUS.Size = New System.Drawing.Size(124, 22)
        Me.radio_MINUS.TabIndex = 7
        Me.radio_MINUS.TabStop = True
        Me.radio_MINUS.Text = "マイナス金額"
        Me.radio_MINUS.UseVisualStyleBackColor = True
        '
        'radio_PLUS
        '
        Me.radio_PLUS.AutoSize = True
        Me.radio_PLUS.Location = New System.Drawing.Point(279, 299)
        Me.radio_PLUS.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_PLUS.Name = "radio_PLUS"
        Me.radio_PLUS.Size = New System.Drawing.Size(109, 22)
        Me.radio_PLUS.TabIndex = 32
        Me.radio_PLUS.Text = "プラス金額"
        Me.radio_PLUS.UseVisualStyleBackColor = True
        '
        'radio_SHIME
        '
        Me.radio_SHIME.AutoSize = True
        Me.radio_SHIME.Checked = True
        Me.radio_SHIME.Location = New System.Drawing.Point(307, 42)
        Me.radio_SHIME.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_SHIME.Name = "radio_SHIME"
        Me.radio_SHIME.Size = New System.Drawing.Size(185, 22)
        Me.radio_SHIME.TabIndex = 0
        Me.radio_SHIME.TabStop = True
        Me.radio_SHIME.Text = "〆ベース(請求ベース)"
        Me.radio_SHIME.UseVisualStyleBackColor = True
        '
        'radio_PAYMENT
        '
        Me.radio_PAYMENT.AutoSize = True
        Me.radio_PAYMENT.Location = New System.Drawing.Point(531, 42)
        Me.radio_PAYMENT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_PAYMENT.Name = "radio_PAYMENT"
        Me.radio_PAYMENT.Size = New System.Drawing.Size(167, 22)
        Me.radio_PAYMENT.TabIndex = 34
        Me.radio_PAYMENT.Text = "約定支払日ベース"
        Me.radio_PAYMENT.UseVisualStyleBackColor = True
        '
        'txt_DT_FROM
        '
        Me.txt_DT_FROM.CustomFormat = "yyyy/MM"
        Me.txt_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DT_FROM.Location = New System.Drawing.Point(157, 93)
        Me.txt_DT_FROM.Name = "txt_DT_FROM"
        Me.txt_DT_FROM.Size = New System.Drawing.Size(175, 25)
        Me.txt_DT_FROM.TabIndex = 0
        '
        'txt_DT_TO
        '
        Me.txt_DT_TO.CustomFormat = "yyyy/MM"
        Me.txt_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DT_TO.Location = New System.Drawing.Point(374, 95)
        Me.txt_DT_TO.Name = "txt_DT_TO"
        Me.txt_DT_TO.Size = New System.Drawing.Size(175, 25)
        Me.txt_DT_TO.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ラベル485)
        Me.GroupBox1.Controls.Add(Me.radio_SHIME)
        Me.GroupBox1.Controls.Add(Me.radio_PAYMENT)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 100)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "計算方法"
        '
        'chk_REC_KBN_7
        '
        Me.chk_REC_KBN_7.AutoSize = True
        Me.chk_REC_KBN_7.Location = New System.Drawing.Point(58, 241)
        Me.chk_REC_KBN_7.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_REC_KBN_7.Name = "chk_REC_KBN_7"
        Me.chk_REC_KBN_7.Size = New System.Drawing.Size(160, 22)
        Me.chk_REC_KBN_7.TabIndex = 6
        Me.chk_REC_KBN_7.Text = "減損勘定取崩額"
        Me.chk_REC_KBN_7.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_7)
        Me.GroupBox2.Controls.Add(Me.radio_MINUS)
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_1)
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_5)
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_2)
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_3)
        Me.GroupBox2.Controls.Add(Me.radio_PLUS)
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_6)
        Me.GroupBox2.Controls.Add(Me.chk_REC_KBN_4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 369)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "出力対象"
        '
        'Form_f_KHIYO_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 750)
        Me.Controls.Add(Me.txt_DT_TO)
        Me.Controls.Add(Me.txt_DT_FROM)
        Me.Controls.Add(Me.lbl_To)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.lbl_GETU)
        Me.Controls.Add(Me.lbl_Description)
        Me.Controls.Add(Me.txt_DURATION)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_KHIYO_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "期間費用計上明細表　条件設定"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_ZENKAI As System.Windows.Forms.Button
    Friend WithEvents txt_DURATION As System.Windows.Forms.TextBox
    Friend WithEvents lbl_To As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents lbl_GETU As System.Windows.Forms.Label
    Friend WithEvents lbl_Description As System.Windows.Forms.Label
    Friend WithEvents ラベル485 As System.Windows.Forms.Label
    Friend WithEvents chk_REC_KBN_5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_REC_KBN_6 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_REC_KBN_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_REC_KBN_3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_REC_KBN_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_REC_KBN_4 As System.Windows.Forms.CheckBox
    Friend WithEvents radio_MINUS As System.Windows.Forms.RadioButton
    Friend WithEvents radio_PLUS As System.Windows.Forms.RadioButton
    Friend WithEvents radio_SHIME As System.Windows.Forms.RadioButton
    Friend WithEvents radio_PAYMENT As System.Windows.Forms.RadioButton
    Friend WithEvents txt_DT_FROM As DateTimePicker
    Friend WithEvents txt_DT_TO As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_REC_KBN_7 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class