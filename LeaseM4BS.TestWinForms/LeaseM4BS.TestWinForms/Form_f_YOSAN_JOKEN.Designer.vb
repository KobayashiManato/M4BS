<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_YOSAN_JOKEN
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
        Me.txt_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NEXT_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_DT_TO = New System.Windows.Forms.DateTimePicker()
        Me.txt_NEXT_DT_TO = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_KOSHIN_YOSO_F = New System.Windows.Forms.CheckBox()
        Me.chk_KOSHIN_YOSO_HENF_F = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_EXECUTE
        '
        Me.cmd_EXECUTE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_EXECUTE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_EXECUTE.Name = "cmd_EXECUTE"
        Me.cmd_EXECUTE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_EXECUTE.TabIndex = 1
        Me.cmd_EXECUTE.Text = "実行(&R)"
        Me.cmd_EXECUTE.UseVisualStyleBackColor = True
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(152, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CANCEL.TabIndex = 2
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(950, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(170, 39)
        Me.cmd_ZENKAI.TabIndex = 3
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'txt_DT_FROM
        '
        Me.txt_DT_FROM.CustomFormat = "yyyy/MM"
        Me.txt_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DT_FROM.Location = New System.Drawing.Point(230, 92)
        Me.txt_DT_FROM.Name = "txt_DT_FROM"
        Me.txt_DT_FROM.Size = New System.Drawing.Size(175, 25)
        Me.txt_DT_FROM.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.65248!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.34752!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox15, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox14, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox13, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox12, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox11, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox16, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox17, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox18, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox19, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox20, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox21, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox22, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox24, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox25, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox35, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox37, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox36, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox34, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox31, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox26, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox27, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox28, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox29, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox32, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox33, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox30, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox23, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 397)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.67647!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.32353!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1109, 592)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"「元データの年額」の12分の1", "「元データの年額」の10分の1"})
        Me.ComboBox1.Location = New System.Drawing.Point(190, 422)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(292, 26)
        Me.ComboBox1.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox5.Location = New System.Drawing.Point(818, 3)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(281, 25)
        Me.TextBox5.TabIndex = 22
        Me.TextBox5.Text = "変額保守"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox2.Location = New System.Drawing.Point(190, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(292, 25)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.Text = "リース原契約"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox6.Location = New System.Drawing.Point(3, 3)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(181, 25)
        Me.TextBox6.TabIndex = 0
        Me.TextBox6.Text = "更新後項目"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox1.Location = New System.Drawing.Point(3, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(181, 25)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "開始日"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox4, 3)
        Me.TextBox4.Location = New System.Drawing.Point(190, 35)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(913, 25)
        Me.TextBox4.TabIndex = 22
        Me.TextBox4.Text = "「元データの終了日」の翌日"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox3.Location = New System.Drawing.Point(488, 3)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(324, 25)
        Me.TextBox3.TabIndex = 23
        Me.TextBox3.Text = "再リース・レンタル・保守・その他"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox15.Location = New System.Drawing.Point(3, 422)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(181, 25)
        Me.TextBox15.TabIndex = 0
        Me.TextBox15.Text = "1支払額"
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox14.Location = New System.Drawing.Point(3, 394)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(181, 25)
        Me.TextBox14.TabIndex = 0
        Me.TextBox14.Text = "前払額"
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox13.Location = New System.Drawing.Point(3, 334)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(181, 25)
        Me.TextBox13.TabIndex = 0
        Me.TextBox13.Text = "第2回支払日"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox12.Location = New System.Drawing.Point(3, 278)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(181, 48)
        Me.TextBox12.TabIndex = 0
        Me.TextBox12.Text = "第1回支払日(初回支払日)"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox11.Location = New System.Drawing.Point(3, 214)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(181, 25)
        Me.TextBox11.TabIndex = 0
        Me.TextBox11.Text = "前払日"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox10.Location = New System.Drawing.Point(3, 151)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(181, 25)
        Me.TextBox10.TabIndex = 0
        Me.TextBox10.Text = "支払回数"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox9.Location = New System.Drawing.Point(3, 121)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(181, 25)
        Me.TextBox9.TabIndex = 0
        Me.TextBox9.Text = "支払間隔"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox8.Location = New System.Drawing.Point(3, 90)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(181, 25)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.Text = "終了日"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox7.Location = New System.Drawing.Point(3, 62)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(181, 25)
        Me.TextBox7.TabIndex = 0
        Me.TextBox7.Text = "契約期間"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(190, 62)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(292, 25)
        Me.TextBox16.TabIndex = 0
        Me.TextBox16.Text = "12"
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(488, 62)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(324, 25)
        Me.TextBox17.TabIndex = 0
        Me.TextBox17.Text = "元データの契約期間"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(818, 62)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(281, 25)
        Me.TextBox18.TabIndex = 0
        Me.TextBox18.Text = "ー"
        Me.TextBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox19
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox19, 2)
        Me.TextBox19.Location = New System.Drawing.Point(190, 90)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(622, 25)
        Me.TextBox19.TabIndex = 0
        Me.TextBox19.Text = "「開始日」の「契約期間」月数後の前日"
        Me.TextBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(818, 90)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(281, 25)
        Me.TextBox20.TabIndex = 0
        Me.TextBox20.Text = "ー"
        Me.TextBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(190, 121)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(292, 25)
        Me.TextBox21.TabIndex = 0
        Me.TextBox21.Text = "12"
        Me.TextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox22
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox22, 2)
        Me.TextBox22.Location = New System.Drawing.Point(488, 121)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.ReadOnly = True
        Me.TextBox22.Size = New System.Drawing.Size(611, 25)
        Me.TextBox22.TabIndex = 0
        Me.TextBox22.Text = "元データの支払間隔"
        Me.TextBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(488, 151)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.ReadOnly = True
        Me.TextBox24.Size = New System.Drawing.Size(324, 25)
        Me.TextBox24.TabIndex = 0
        Me.TextBox24.Text = "元データの支払回数"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(818, 151)
        Me.TextBox25.Multiline = True
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.ReadOnly = True
        Me.TextBox25.Size = New System.Drawing.Size(281, 57)
        Me.TextBox25.TabIndex = 0
        Me.TextBox25.Text = "集計期間の最終付きまで支払が発生するよう設定"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(818, 394)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.ReadOnly = True
        Me.TextBox35.Size = New System.Drawing.Size(281, 25)
        Me.TextBox35.TabIndex = 0
        Me.TextBox35.Text = "ー"
        Me.TextBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox37
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox37, 2)
        Me.TextBox37.Location = New System.Drawing.Point(488, 422)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.ReadOnly = True
        Me.TextBox37.Size = New System.Drawing.Size(611, 25)
        Me.TextBox37.TabIndex = 0
        Me.TextBox37.Text = "元データの1支払額"
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox36
        '
        Me.TextBox36.Location = New System.Drawing.Point(488, 394)
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.ReadOnly = True
        Me.TextBox36.Size = New System.Drawing.Size(324, 25)
        Me.TextBox36.TabIndex = 0
        Me.TextBox36.Text = "元データの前払額"
        Me.TextBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox34
        '
        Me.TextBox34.Location = New System.Drawing.Point(190, 394)
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.ReadOnly = True
        Me.TextBox34.Size = New System.Drawing.Size(292, 25)
        Me.TextBox34.TabIndex = 0
        Me.TextBox34.Text = "ー"
        Me.TextBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(190, 334)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.ReadOnly = True
        Me.TextBox31.Size = New System.Drawing.Size(292, 25)
        Me.TextBox31.TabIndex = 0
        Me.TextBox31.Text = "ー"
        Me.TextBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(190, 214)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(292, 25)
        Me.TextBox26.TabIndex = 0
        Me.TextBox26.Text = "ー"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(488, 214)
        Me.TextBox27.Multiline = True
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.ReadOnly = True
        Me.TextBox27.Size = New System.Drawing.Size(324, 58)
        Me.TextBox27.TabIndex = 0
        Me.TextBox27.Text = "「元データの前払日」の「元データの契約期間」月数後"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(818, 214)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.ReadOnly = True
        Me.TextBox28.Size = New System.Drawing.Size(281, 25)
        Me.TextBox28.TabIndex = 0
        Me.TextBox28.Text = "ー"
        Me.TextBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox29
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox29, 2)
        Me.TextBox29.Location = New System.Drawing.Point(190, 278)
        Me.TextBox29.Multiline = True
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.ReadOnly = True
        Me.TextBox29.Size = New System.Drawing.Size(622, 50)
        Me.TextBox29.TabIndex = 0
        Me.TextBox29.Text = "「元データの第1回支払日」の「元データの契約期間」月数後"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox32
        '
        Me.TextBox32.Location = New System.Drawing.Point(488, 334)
        Me.TextBox32.Multiline = True
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.ReadOnly = True
        Me.TextBox32.Size = New System.Drawing.Size(324, 54)
        Me.TextBox32.TabIndex = 0
        Me.TextBox32.Text = "「元データの第1回支払日」の「元データの契約期間」月数後"
        Me.TextBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(818, 334)
        Me.TextBox33.Multiline = True
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.ReadOnly = True
        Me.TextBox33.Size = New System.Drawing.Size(281, 54)
        Me.TextBox33.TabIndex = 0
        Me.TextBox33.Text = "「初回支払日」の「支払間隔」月数後"
        Me.TextBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(818, 278)
        Me.TextBox30.Multiline = True
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.ReadOnly = True
        Me.TextBox30.Size = New System.Drawing.Size(276, 48)
        Me.TextBox30.TabIndex = 0
        Me.TextBox30.Text = "「元データの初回支払日」の「元データの契約期間」月数後"
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(190, 151)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.ReadOnly = True
        Me.TextBox23.Size = New System.Drawing.Size(292, 25)
        Me.TextBox23.TabIndex = 0
        Me.TextBox23.Text = "1"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "集計期間"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "今期実績"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "来季予算"
        '
        'txt_NEXT_DT_FROM
        '
        Me.txt_NEXT_DT_FROM.CustomFormat = "yyyy/MM"
        Me.txt_NEXT_DT_FROM.Enabled = False
        Me.txt_NEXT_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_NEXT_DT_FROM.Location = New System.Drawing.Point(230, 127)
        Me.txt_NEXT_DT_FROM.Name = "txt_NEXT_DT_FROM"
        Me.txt_NEXT_DT_FROM.Size = New System.Drawing.Size(175, 25)
        Me.txt_NEXT_DT_FROM.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "～"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "～"
        '
        'txt_DT_TO
        '
        Me.txt_DT_TO.CustomFormat = "yyyy/MM"
        Me.txt_DT_TO.Enabled = False
        Me.txt_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DT_TO.Location = New System.Drawing.Point(443, 92)
        Me.txt_DT_TO.Name = "txt_DT_TO"
        Me.txt_DT_TO.Size = New System.Drawing.Size(175, 25)
        Me.txt_DT_TO.TabIndex = 20
        '
        'txt_NEXT_DT_TO
        '
        Me.txt_NEXT_DT_TO.CustomFormat = "yyyy/MM"
        Me.txt_NEXT_DT_TO.Enabled = False
        Me.txt_NEXT_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_NEXT_DT_TO.Location = New System.Drawing.Point(443, 127)
        Me.txt_NEXT_DT_TO.Name = "txt_NEXT_DT_TO"
        Me.txt_NEXT_DT_TO.Size = New System.Drawing.Size(175, 25)
        Me.txt_NEXT_DT_TO.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(651, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "yyyy/mm形式で入力してください"
        '
        'chk_KOSHIN_YOSO_F
        '
        Me.chk_KOSHIN_YOSO_F.AutoSize = True
        Me.chk_KOSHIN_YOSO_F.Location = New System.Drawing.Point(40, 174)
        Me.chk_KOSHIN_YOSO_F.Name = "chk_KOSHIN_YOSO_F"
        Me.chk_KOSHIN_YOSO_F.Size = New System.Drawing.Size(203, 22)
        Me.chk_KOSHIN_YOSO_F.TabIndex = 4
        Me.chk_KOSHIN_YOSO_F.Text = "更新予想額を算出する"
        Me.chk_KOSHIN_YOSO_F.UseVisualStyleBackColor = True
        '
        'chk_KOSHIN_YOSO_HENF_F
        '
        Me.chk_KOSHIN_YOSO_HENF_F.AutoSize = True
        Me.chk_KOSHIN_YOSO_HENF_F.Location = New System.Drawing.Point(288, 174)
        Me.chk_KOSHIN_YOSO_HENF_F.Name = "chk_KOSHIN_YOSO_HENF_F"
        Me.chk_KOSHIN_YOSO_HENF_F.Size = New System.Drawing.Size(312, 22)
        Me.chk_KOSHIN_YOSO_HENF_F.TabIndex = 5
        Me.chk_KOSHIN_YOSO_HENF_F.Text = "変額リース料の更新予想額を算出する"
        Me.chk_KOSHIN_YOSO_HENF_F.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "更新対象"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "更新回数"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(183, 301)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 22)
        Me.RadioButton1.TabIndex = 25
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1回"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(288, 301)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(811, 22)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "初回支払(または前払)が翌期末を越えるまで更新を繰り返す※変額保守の更新回数は本設定に拘わらず1回"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(166, 224)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(175, 25)
        Me.DateTimePicker4.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(356, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(520, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "以降に終了日の到来する契約　※yyyy/mm/dd形式で入力してください"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(356, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(487, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "※中途解約および契約終了がなされているデータは更新予想しない"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(66, 367)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "＜更新条件＞"
        '
        'Form_f_YOSAN_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 1001)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.chk_KOSHIN_YOSO_HENF_F)
        Me.Controls.Add(Me.chk_KOSHIN_YOSO_F)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.txt_NEXT_DT_FROM)
        Me.Controls.Add(Me.txt_NEXT_DT_TO)
        Me.Controls.Add(Me.txt_DT_TO)
        Me.Controls.Add(Me.txt_DT_FROM)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.KeyPreview = True
        Me.Name = "Form_f_YOSAN_JOKEN"
        Me.Text = "Form_f_YOSAN_JOKEN"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As Button
    Friend WithEvents cmd_CANCEL As Button
    Friend WithEvents cmd_ZENKAI As Button
    Friend WithEvents txt_DT_FROM As DateTimePicker
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_NEXT_DT_FROM As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_DT_TO As DateTimePicker
    Friend WithEvents txt_NEXT_DT_TO As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_KOSHIN_YOSO_F As CheckBox
    Friend WithEvents chk_KOSHIN_YOSO_HENF_F As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
