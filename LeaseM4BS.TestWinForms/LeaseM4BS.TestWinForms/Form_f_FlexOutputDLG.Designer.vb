<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_FlexOutputDLG

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
        Me.cmd_Def = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_EXECUTE = New System.Windows.Forms.Button()
        Me.ラベル12 = New System.Windows.Forms.Label()
        Me.ラベル17 = New System.Windows.Forms.Label()
        Me.ラベル19 = New System.Windows.Forms.Label()
        Me.ラベル24 = New System.Windows.Forms.Label()
        Me.lbl_TextSeparateSymbol = New System.Windows.Forms.Label()
        Me.lbl_ColNmOut_F = New System.Windows.Forms.Label()
        Me.lbl_CRLFOut_F = New System.Windows.Forms.Label()
        Me.chk_ColNmOut_F = New System.Windows.Forms.CheckBox()
        Me.lst_SaveNo = New System.Windows.Forms.ListBox()
        Me.lst_FieldList = New System.Windows.Forms.ListBox()
        Me.radio_EXCEL = New System.Windows.Forms.RadioButton()
        Me.radio_CSV = New System.Windows.Forms.RadioButton()
        Me.radio_FIXED_LENGTH = New System.Windows.Forms.RadioButton()
        Me.cmb_DELIMITER = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmd_Def
        '
        Me.cmd_Def.Location = New System.Drawing.Point(34, 541)
        Me.cmd_Def.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_Def.Name = "cmd_Def"
        Me.cmd_Def.Size = New System.Drawing.Size(225, 34)
        Me.cmd_Def.TabIndex = 0
        Me.cmd_Def.Text = "ﾌｧｲﾙ出力項目設定(&S)"
        Me.cmd_Def.UseVisualStyleBackColor = True
        '
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(147, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
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
        'ラベル12
        '
        Me.ラベル12.AutoSize = True
        Me.ラベル12.Location = New System.Drawing.Point(470, 21)
        Me.ラベル12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル12.Name = "ラベル12"
        Me.ラベル12.Size = New System.Drawing.Size(80, 18)
        Me.ラベル12.TabIndex = 7
        Me.ラベル12.Text = "出力形式"
        '
        'ラベル17
        '
        Me.ラベル17.AutoSize = True
        Me.ラベル17.Location = New System.Drawing.Point(635, 21)
        Me.ラベル17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル17.Name = "ラベル17"
        Me.ラベル17.Size = New System.Drawing.Size(69, 18)
        Me.ラベル17.TabIndex = 8
        Me.ラベル17.Text = "Excel(&X)"
        '
        'ラベル19
        '
        Me.ラベル19.AutoSize = True
        Me.ラベル19.Location = New System.Drawing.Point(760, 21)
        Me.ラベル19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル19.Name = "ラベル19"
        Me.ラベル19.Size = New System.Drawing.Size(63, 18)
        Me.ラベル19.TabIndex = 9
        Me.ラベル19.Text = "CSV(&V)"
        '
        'ラベル24
        '
        Me.ラベル24.AutoSize = True
        Me.ラベル24.Location = New System.Drawing.Point(893, 21)
        Me.ラベル24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル24.Name = "ラベル24"
        Me.ラベル24.Size = New System.Drawing.Size(83, 18)
        Me.ラベル24.TabIndex = 10
        Me.ラベル24.Text = "固定長(&K)"
        '
        'lbl_TextSeparateSymbol
        '
        Me.lbl_TextSeparateSymbol.AutoSize = True
        Me.lbl_TextSeparateSymbol.Location = New System.Drawing.Point(722, 63)
        Me.lbl_TextSeparateSymbol.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_TextSeparateSymbol.Name = "lbl_TextSeparateSymbol"
        Me.lbl_TextSeparateSymbol.Size = New System.Drawing.Size(154, 18)
        Me.lbl_TextSeparateSymbol.TabIndex = 11
        Me.lbl_TextSeparateSymbol.Text = "ﾃｷｽﾄ区切り記号(&T)"
        '
        'lbl_ColNmOut_F
        '
        Me.lbl_ColNmOut_F.AutoSize = True
        Me.lbl_ColNmOut_F.Location = New System.Drawing.Point(470, 61)
        Me.lbl_ColNmOut_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_ColNmOut_F.Name = "lbl_ColNmOut_F"
        Me.lbl_ColNmOut_F.Size = New System.Drawing.Size(66, 18)
        Me.lbl_ColNmOut_F.TabIndex = 12
        Me.lbl_ColNmOut_F.Text = "列名(&N)"
        '
        'lbl_CRLFOut_F
        '
        Me.lbl_CRLFOut_F.AutoSize = True
        Me.lbl_CRLFOut_F.Location = New System.Drawing.Point(608, 61)
        Me.lbl_CRLFOut_F.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_CRLFOut_F.Name = "lbl_CRLFOut_F"
        Me.lbl_CRLFOut_F.Size = New System.Drawing.Size(66, 18)
        Me.lbl_CRLFOut_F.TabIndex = 13
        Me.lbl_CRLFOut_F.Text = "改行(&G)"
        '
        'chk_ColNmOut_F
        '
        Me.chk_ColNmOut_F.AutoSize = True
        Me.chk_ColNmOut_F.Location = New System.Drawing.Point(578, 63)
        Me.chk_ColNmOut_F.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_ColNmOut_F.Name = "chk_ColNmOut_F"
        Me.chk_ColNmOut_F.Size = New System.Drawing.Size(22, 21)
        Me.chk_ColNmOut_F.TabIndex = 14
        Me.chk_ColNmOut_F.UseVisualStyleBackColor = True
        '
        'lst_SaveNo
        '
        Me.lst_SaveNo.FormattingEnabled = True
        Me.lst_SaveNo.ItemHeight = 18
        Me.lst_SaveNo.Location = New System.Drawing.Point(34, 133)
        Me.lst_SaveNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lst_SaveNo.Name = "lst_SaveNo"
        Me.lst_SaveNo.Size = New System.Drawing.Size(456, 382)
        Me.lst_SaveNo.TabIndex = 16
        '
        'lst_FieldList
        '
        Me.lst_FieldList.FormattingEnabled = True
        Me.lst_FieldList.ItemHeight = 18
        Me.lst_FieldList.Location = New System.Drawing.Point(519, 101)
        Me.lst_FieldList.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lst_FieldList.Name = "lst_FieldList"
        Me.lst_FieldList.Size = New System.Drawing.Size(501, 472)
        Me.lst_FieldList.TabIndex = 17
        '
        'radio_EXCEL
        '
        Me.radio_EXCEL.AutoSize = True
        Me.radio_EXCEL.Checked = True
        Me.radio_EXCEL.Location = New System.Drawing.Point(608, 21)
        Me.radio_EXCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_EXCEL.Name = "radio_EXCEL"
        Me.radio_EXCEL.Size = New System.Drawing.Size(21, 20)
        Me.radio_EXCEL.TabIndex = 18
        Me.radio_EXCEL.TabStop = True
        Me.radio_EXCEL.UseVisualStyleBackColor = True
        '
        'radio_CSV
        '
        Me.radio_CSV.AutoSize = True
        Me.radio_CSV.Location = New System.Drawing.Point(735, 21)
        Me.radio_CSV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_CSV.Name = "radio_CSV"
        Me.radio_CSV.Size = New System.Drawing.Size(21, 20)
        Me.radio_CSV.TabIndex = 19
        Me.radio_CSV.UseVisualStyleBackColor = True
        '
        'radio_FIXED_LENGTH
        '
        Me.radio_FIXED_LENGTH.AutoSize = True
        Me.radio_FIXED_LENGTH.Location = New System.Drawing.Point(867, 21)
        Me.radio_FIXED_LENGTH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radio_FIXED_LENGTH.Name = "radio_FIXED_LENGTH"
        Me.radio_FIXED_LENGTH.Size = New System.Drawing.Size(21, 20)
        Me.radio_FIXED_LENGTH.TabIndex = 20
        Me.radio_FIXED_LENGTH.UseVisualStyleBackColor = True
        '
        'cmb_DELIMITER
        '
        Me.cmb_DELIMITER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DELIMITER.FormattingEnabled = True
        Me.cmb_DELIMITER.Items.AddRange(New Object() {"""", "'", "なし"})
        Me.cmb_DELIMITER.Location = New System.Drawing.Point(894, 58)
        Me.cmb_DELIMITER.Name = "cmb_DELIMITER"
        Me.cmb_DELIMITER.Size = New System.Drawing.Size(126, 26)
        Me.cmb_DELIMITER.TabIndex = 21
        '
        'Form_f_FlexOutputDLG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 918)
        Me.Controls.Add(Me.cmb_DELIMITER)
        Me.Controls.Add(Me.radio_EXCEL)
        Me.Controls.Add(Me.radio_CSV)
        Me.Controls.Add(Me.radio_FIXED_LENGTH)
        Me.Controls.Add(Me.lst_SaveNo)
        Me.Controls.Add(Me.lst_FieldList)
        Me.Controls.Add(Me.chk_ColNmOut_F)
        Me.Controls.Add(Me.ラベル12)
        Me.Controls.Add(Me.ラベル17)
        Me.Controls.Add(Me.ラベル19)
        Me.Controls.Add(Me.ラベル24)
        Me.Controls.Add(Me.lbl_TextSeparateSymbol)
        Me.Controls.Add(Me.lbl_ColNmOut_F)
        Me.Controls.Add(Me.lbl_CRLFOut_F)
        Me.Controls.Add(Me.cmd_Def)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_FlexOutputDLG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " ﾌｧｲﾙ出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Def As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_EXECUTE As System.Windows.Forms.Button
    Friend WithEvents ラベル12 As System.Windows.Forms.Label
    Friend WithEvents ラベル17 As System.Windows.Forms.Label
    Friend WithEvents ラベル19 As System.Windows.Forms.Label
    Friend WithEvents ラベル24 As System.Windows.Forms.Label
    Friend WithEvents lbl_TextSeparateSymbol As System.Windows.Forms.Label
    Friend WithEvents lbl_ColNmOut_F As System.Windows.Forms.Label
    Friend WithEvents lbl_CRLFOut_F As System.Windows.Forms.Label
    Friend WithEvents chk_ColNmOut_F As System.Windows.Forms.CheckBox
    Friend WithEvents lst_SaveNo As System.Windows.Forms.ListBox
    Friend WithEvents lst_FieldList As System.Windows.Forms.ListBox
    Friend WithEvents radio_EXCEL As System.Windows.Forms.RadioButton
    Friend WithEvents radio_CSV As System.Windows.Forms.RadioButton
    Friend WithEvents radio_FIXED_LENGTH As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_DELIMITER As ComboBox
End Class