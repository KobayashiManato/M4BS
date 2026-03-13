<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_KEIJO_JOKEN
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
        Me.txt_DATE_FROM = New System.Windows.Forms.DateTimePicker()
        Me.txt_DATE_TO = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_DURATION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radio_BUKN = New System.Windows.Forms.RadioButton()
        Me.radio_HAIF = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chk_SHORI = New System.Windows.Forms.CheckBox()
        Me.chk_KEIJO = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmb_SETTEI = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_EXECUTE
        '
        Me.cmd_EXECUTE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_EXECUTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXECUTE.Name = "cmd_EXECUTE"
        Me.cmd_EXECUTE.Size = New System.Drawing.Size(157, 45)
        Me.cmd_EXECUTE.TabIndex = 2
        Me.cmd_EXECUTE.Text = "実行(&R)"
        Me.cmd_EXECUTE.UseVisualStyleBackColor = True
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(181, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(153, 45)
        Me.cmd_CANCEL.TabIndex = 3
        Me.cmd_CANCEL.Text = "キャンセル(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(790, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(188, 45)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'txt_DATE_FROM
        '
        Me.txt_DATE_FROM.CustomFormat = "yyyy/MM"
        Me.txt_DATE_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DATE_FROM.Location = New System.Drawing.Point(217, 115)
        Me.txt_DATE_FROM.Name = "txt_DATE_FROM"
        Me.txt_DATE_FROM.Size = New System.Drawing.Size(200, 25)
        Me.txt_DATE_FROM.TabIndex = 0
        '
        'txt_DATE_TO
        '
        Me.txt_DATE_TO.CustomFormat = "yyyy/MM"
        Me.txt_DATE_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DATE_TO.Location = New System.Drawing.Point(455, 115)
        Me.txt_DATE_TO.Name = "txt_DATE_TO"
        Me.txt_DATE_TO.Size = New System.Drawing.Size(200, 25)
        Me.txt_DATE_TO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "集計期間"
        '
        'txt_DURATION
        '
        Me.txt_DURATION.Location = New System.Drawing.Point(700, 113)
        Me.txt_DURATION.Name = "txt_DURATION"
        Me.txt_DURATION.ReadOnly = True
        Me.txt_DURATION.Size = New System.Drawing.Size(69, 25)
        Me.txt_DURATION.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(775, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ヶ月"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "yyyy/mmの形式で入力してください"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "明細"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.radio_BUKN)
        Me.Panel3.Controls.Add(Me.radio_HAIF)
        Me.Panel3.Location = New System.Drawing.Point(160, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(626, 65)
        Me.Panel3.TabIndex = 13
        '
        'radio_BUKN
        '
        Me.radio_BUKN.AutoSize = True
        Me.radio_BUKN.Location = New System.Drawing.Point(14, 20)
        Me.radio_BUKN.Name = "radio_BUKN"
        Me.radio_BUKN.Size = New System.Drawing.Size(105, 22)
        Me.radio_BUKN.TabIndex = 7
        Me.radio_BUKN.Text = "物件単位"
        Me.radio_BUKN.UseVisualStyleBackColor = True
        '
        'radio_HAIF
        '
        Me.radio_HAIF.AutoSize = True
        Me.radio_HAIF.Checked = True
        Me.radio_HAIF.Location = New System.Drawing.Point(157, 20)
        Me.radio_HAIF.Name = "radio_HAIF"
        Me.radio_HAIF.Size = New System.Drawing.Size(105, 22)
        Me.radio_HAIF.TabIndex = 7
        Me.radio_HAIF.TabStop = True
        Me.radio_HAIF.Text = "配賦単位"
        Me.radio_HAIF.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chk_SHORI)
        Me.Panel1.Controls.Add(Me.chk_KEIJO)
        Me.Panel1.Location = New System.Drawing.Point(160, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 65)
        Me.Panel1.TabIndex = 13
        '
        'chk_SHORI
        '
        Me.chk_SHORI.AutoSize = True
        Me.chk_SHORI.Checked = True
        Me.chk_SHORI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SHORI.Location = New System.Drawing.Point(218, 21)
        Me.chk_SHORI.Name = "chk_SHORI"
        Me.chk_SHORI.Size = New System.Drawing.Size(166, 22)
        Me.chk_SHORI.TabIndex = 14
        Me.chk_SHORI.Text = "賃貸借処理データ"
        Me.chk_SHORI.UseVisualStyleBackColor = True
        '
        'chk_KEIJO
        '
        Me.chk_KEIJO.AutoSize = True
        Me.chk_KEIJO.Checked = True
        Me.chk_KEIJO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_KEIJO.Location = New System.Drawing.Point(14, 21)
        Me.chk_KEIJO.Name = "chk_KEIJO"
        Me.chk_KEIJO.Size = New System.Drawing.Size(148, 22)
        Me.chk_KEIJO.TabIndex = 14
        Me.chk_KEIJO.Text = "資産計上データ"
        Me.chk_KEIJO.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmb_SETTEI)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(160, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 97)
        Me.Panel2.TabIndex = 13
        '
        'cmb_SETTEI
        '
        Me.cmb_SETTEI.FormattingEnabled = True
        Me.cmb_SETTEI.Location = New System.Drawing.Point(317, 17)
        Me.cmb_SETTEI.Name = "cmb_SETTEI"
        Me.cmb_SETTEI.Size = New System.Drawing.Size(294, 26)
        Me.cmb_SETTEI.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(84, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(434, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "未払消費税・リース資産減損勘定の取崩方法を指定します"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(252, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "新令・費用リースの債務取崩方法"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(423, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "～"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 135)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "計算対象"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Location = New System.Drawing.Point(57, 357)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(921, 135)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "仕訳出力対象"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Location = New System.Drawing.Point(57, 514)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(921, 135)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "その他"
        '
        'Form_f_KEIJO_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 671)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_DURATION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_DATE_TO)
        Me.Controls.Add(Me.txt_DATE_FROM)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form_f_KEIJO_JOKEN"
        Me.Text = "Form_f_FlexMonthlyJornalEntry"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As Button
    Friend WithEvents cmd_CANCEL As Button
    Friend WithEvents cmd_ZENKAI As Button
    Friend WithEvents txt_DATE_FROM As DateTimePicker
    Friend WithEvents txt_DATE_TO As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_DURATION As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents radio_BUKN As RadioButton
    Friend WithEvents radio_HAIF As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chk_KEIJO As CheckBox
    Friend WithEvents chk_SHORI As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_SETTEI As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
