<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_TOUGETSU_JOKEN
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd_EXECUTE = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_ZENKAI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_TARGET_MONTH = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radio_SHIME_BASE = New System.Windows.Forms.RadioButton()
        Me.radio_CONTRACT_BASE = New System.Windows.Forms.RadioButton()
        Me.radio_ACTUAL_BASE = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radio_ALL = New System.Windows.Forms.RadioButton()
        Me.radio_LEASE = New System.Windows.Forms.RadioButton()
        Me.radio_HENF = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radio_BUKN = New System.Windows.Forms.RadioButton()
        Me.radio_HAIF = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chk_CALCULATE = New System.Windows.Forms.CheckBox()
        Me.cmd_HOLIDAY = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_EXECUTE
        '
        Me.cmd_EXECUTE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_EXECUTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXECUTE.Name = "cmd_EXECUTE"
        Me.cmd_EXECUTE.Size = New System.Drawing.Size(157, 45)
        Me.cmd_EXECUTE.TabIndex = 1
        Me.cmd_EXECUTE.Text = "実行(&R)"
        Me.cmd_EXECUTE.UseVisualStyleBackColor = True
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(181, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(153, 45)
        Me.cmd_CANCEL.TabIndex = 2
        Me.cmd_CANCEL.Text = "キャンセル(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(784, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(188, 45)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "集計月"
        '
        'txt_TARGET_MONTH
        '
        Me.txt_TARGET_MONTH.CustomFormat = "yyyy/MM"
        Me.txt_TARGET_MONTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_TARGET_MONTH.Location = New System.Drawing.Point(170, 97)
        Me.txt_TARGET_MONTH.Name = "txt_TARGET_MONTH"
        Me.txt_TARGET_MONTH.Size = New System.Drawing.Size(200, 25)
        Me.txt_TARGET_MONTH.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "yyyy/mmの形式で入力してください"
        '
        'radio_SHIME_BASE
        '
        Me.radio_SHIME_BASE.AutoSize = True
        Me.radio_SHIME_BASE.Checked = True
        Me.radio_SHIME_BASE.Location = New System.Drawing.Point(17, 21)
        Me.radio_SHIME_BASE.Name = "radio_SHIME_BASE"
        Me.radio_SHIME_BASE.Size = New System.Drawing.Size(185, 22)
        Me.radio_SHIME_BASE.TabIndex = 7
        Me.radio_SHIME_BASE.TabStop = True
        Me.radio_SHIME_BASE.Text = "〆ベース(請求ベース)"
        Me.radio_SHIME_BASE.UseVisualStyleBackColor = True
        '
        'radio_CONTRACT_BASE
        '
        Me.radio_CONTRACT_BASE.AutoSize = True
        Me.radio_CONTRACT_BASE.Location = New System.Drawing.Point(231, 21)
        Me.radio_CONTRACT_BASE.Name = "radio_CONTRACT_BASE"
        Me.radio_CONTRACT_BASE.Size = New System.Drawing.Size(167, 22)
        Me.radio_CONTRACT_BASE.TabIndex = 7
        Me.radio_CONTRACT_BASE.Text = "約定支払日ベース"
        Me.radio_CONTRACT_BASE.UseVisualStyleBackColor = True
        '
        'radio_ACTUAL_BASE
        '
        Me.radio_ACTUAL_BASE.AutoSize = True
        Me.radio_ACTUAL_BASE.Location = New System.Drawing.Point(433, 21)
        Me.radio_ACTUAL_BASE.Name = "radio_ACTUAL_BASE"
        Me.radio_ACTUAL_BASE.Size = New System.Drawing.Size(167, 22)
        Me.radio_ACTUAL_BASE.TabIndex = 7
        Me.radio_ACTUAL_BASE.Text = "実際支払日ベース"
        Me.radio_ACTUAL_BASE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radio_ACTUAL_BASE)
        Me.Panel1.Controls.Add(Me.radio_SHIME_BASE)
        Me.Panel1.Controls.Add(Me.radio_CONTRACT_BASE)
        Me.Panel1.Location = New System.Drawing.Point(200, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 65)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "計上タイミング"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.radio_ALL)
        Me.Panel2.Controls.Add(Me.radio_LEASE)
        Me.Panel2.Controls.Add(Me.radio_HENF)
        Me.Panel2.Location = New System.Drawing.Point(200, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 65)
        Me.Panel2.TabIndex = 7
        '
        'radio_ALL
        '
        Me.radio_ALL.AutoSize = True
        Me.radio_ALL.Location = New System.Drawing.Point(287, 21)
        Me.radio_ALL.Name = "radio_ALL"
        Me.radio_ALL.Size = New System.Drawing.Size(69, 22)
        Me.radio_ALL.TabIndex = 7
        Me.radio_ALL.Text = "全部"
        Me.radio_ALL.UseVisualStyleBackColor = True
        '
        'radio_LEASE
        '
        Me.radio_LEASE.AutoSize = True
        Me.radio_LEASE.Location = New System.Drawing.Point(17, 21)
        Me.radio_LEASE.Name = "radio_LEASE"
        Me.radio_LEASE.Size = New System.Drawing.Size(91, 22)
        Me.radio_LEASE.TabIndex = 7
        Me.radio_LEASE.Text = "リース料"
        Me.radio_LEASE.UseVisualStyleBackColor = True
        '
        'radio_HENF
        '
        Me.radio_HENF.AutoSize = True
        Me.radio_HENF.Checked = True
        Me.radio_HENF.Location = New System.Drawing.Point(157, 21)
        Me.radio_HENF.Name = "radio_HENF"
        Me.radio_HENF.Size = New System.Drawing.Size(87, 22)
        Me.radio_HENF.TabIndex = 7
        Me.radio_HENF.TabStop = True
        Me.radio_HENF.Text = "保守料"
        Me.radio_HENF.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "集計対象"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radio_BUKN)
        Me.Panel3.Controls.Add(Me.radio_HAIF)
        Me.Panel3.Location = New System.Drawing.Point(200, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(626, 65)
        Me.Panel3.TabIndex = 7
        '
        'radio_BUKN
        '
        Me.radio_BUKN.AutoSize = True
        Me.radio_BUKN.Checked = True
        Me.radio_BUKN.Location = New System.Drawing.Point(14, 20)
        Me.radio_BUKN.Name = "radio_BUKN"
        Me.radio_BUKN.Size = New System.Drawing.Size(105, 22)
        Me.radio_BUKN.TabIndex = 7
        Me.radio_BUKN.TabStop = True
        Me.radio_BUKN.Text = "物件単位"
        Me.radio_BUKN.UseVisualStyleBackColor = True
        '
        'radio_HAIF
        '
        Me.radio_HAIF.AutoSize = True
        Me.radio_HAIF.Location = New System.Drawing.Point(157, 20)
        Me.radio_HAIF.Name = "radio_HAIF"
        Me.radio_HAIF.Size = New System.Drawing.Size(105, 22)
        Me.radio_HAIF.TabIndex = 7
        Me.radio_HAIF.Text = "配賦単位"
        Me.radio_HAIF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "明細"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "その他"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(197, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "元本・利息を計算"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(513, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "※計上区分=資産で返済方法=(約定支払いベース または 請求ベース)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(197, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "のデータが対象"
        '
        'chk_CALCULATE
        '
        Me.chk_CALCULATE.AutoSize = True
        Me.chk_CALCULATE.Checked = True
        Me.chk_CALCULATE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CALCULATE.Location = New System.Drawing.Point(141, 223)
        Me.chk_CALCULATE.Name = "chk_CALCULATE"
        Me.chk_CALCULATE.Size = New System.Drawing.Size(22, 21)
        Me.chk_CALCULATE.TabIndex = 8
        Me.chk_CALCULATE.UseVisualStyleBackColor = True
        '
        'cmd_HOLIDAY
        '
        Me.cmd_HOLIDAY.Location = New System.Drawing.Point(621, 13)
        Me.cmd_HOLIDAY.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_HOLIDAY.Name = "cmd_HOLIDAY"
        Me.cmd_HOLIDAY.Size = New System.Drawing.Size(153, 45)
        Me.cmd_HOLIDAY.TabIndex = 3
        Me.cmd_HOLIDAY.Text = "祝日(&M)"
        Me.cmd_HOLIDAY.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 135)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "計算方法"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_CALCULATE)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(921, 347)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "計算対象"
        '
        'Form_f_TOUGETSU_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 666)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_TARGET_MONTH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_HOLIDAY)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.KeyPreview = True
        Me.Name = "Form_f_TOUGETSU_JOKEN"
        Me.Text = "Form_f_FlexMonthlyPayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As Button
    Friend WithEvents cmd_CANCEL As Button
    Friend WithEvents cmd_ZENKAI As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_TARGET_MONTH As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents radio_CONTRACT_BASE As RadioButton
    Friend WithEvents radio_SHIME_BASE As RadioButton
    Friend WithEvents radio_ACTUAL_BASE As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radio_ALL As RadioButton
    Friend WithEvents radio_LEASE As RadioButton
    Friend WithEvents radio_HENF As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents radio_BUKN As RadioButton
    Friend WithEvents radio_HAIF As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents chk_CALCULATE As CheckBox
    Friend WithEvents cmd_HOLIDAY As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
