<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_FlexOutputDLG_Def

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
        Me.cmd_Add = New System.Windows.Forms.Button()
        Me.cmd_LineDel = New System.Windows.Forms.Button()
        Me.cmd_UP = New System.Windows.Forms.Button()
        Me.cmd_DOWN = New System.Windows.Forms.Button()
        Me.cmd_Save = New System.Windows.Forms.Button()
        Me.cmd_Delete = New System.Windows.Forms.Button()
        Me.cmd_Close = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.cmd_AddAll = New System.Windows.Forms.Button()
        Me.txt_SaveNo = New System.Windows.Forms.TextBox()
        Me.ラベル18 = New System.Windows.Forms.Label()
        Me.ラベル19 = New System.Windows.Forms.Label()
        Me.ラベル21 = New System.Windows.Forms.Label()
        Me.ラベル32 = New System.Windows.Forms.Label()
        Me.ラベル37 = New System.Windows.Forms.Label()
        Me.ラベル39 = New System.Windows.Forms.Label()
        Me.ラベル27 = New System.Windows.Forms.Label()
        Me.lbl_ColNmOut_F = New System.Windows.Forms.Label()
        Me.chk_AllHyoj_F = New System.Windows.Forms.CheckBox()
        Me.lst_FldLst = New System.Windows.Forms.ListBox()
        Me.opt_Dtl = New System.Windows.Forms.RadioButton()
        Me.opt_Sum = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        ' cmd_Add
        '
        Me.cmd_Add.Location = New System.Drawing.Point(204, 151)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Add.TabIndex = 0
        Me.cmd_Add.Text = "＞"
        Me.cmd_Add.UseVisualStyleBackColor = True
        '
        ' cmd_LineDel
        '
        Me.cmd_LineDel.Location = New System.Drawing.Point(207, 181)
        Me.cmd_LineDel.Name = "cmd_LineDel"
        Me.cmd_LineDel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_LineDel.TabIndex = 1
        Me.cmd_LineDel.Text = "行削除"
        Me.cmd_LineDel.UseVisualStyleBackColor = True
        '
        ' cmd_UP
        '
        Me.cmd_UP.Location = New System.Drawing.Point(219, 226)
        Me.cmd_UP.Name = "cmd_UP"
        Me.cmd_UP.Size = New System.Drawing.Size(75, 23)
        Me.cmd_UP.TabIndex = 2
        Me.cmd_UP.Text = "▲"
        Me.cmd_UP.UseVisualStyleBackColor = True
        '
        ' cmd_DOWN
        '
        Me.cmd_DOWN.Location = New System.Drawing.Point(219, 272)
        Me.cmd_DOWN.Name = "cmd_DOWN"
        Me.cmd_DOWN.Size = New System.Drawing.Size(75, 23)
        Me.cmd_DOWN.TabIndex = 3
        Me.cmd_DOWN.Text = "▼"
        Me.cmd_DOWN.UseVisualStyleBackColor = True
        '
        ' cmd_Save
        '
        Me.cmd_Save.Location = New System.Drawing.Point(83, 3)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Save.TabIndex = 4
        Me.cmd_Save.Text = "登録(&S)"
        Me.cmd_Save.UseVisualStyleBackColor = True
        '
        ' cmd_Delete
        '
        Me.cmd_Delete.Location = New System.Drawing.Point(158, 3)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Delete.TabIndex = 5
        Me.cmd_Delete.Text = "削除(&D)"
        Me.cmd_Delete.UseVisualStyleBackColor = True
        '
        ' cmd_Close
        '
        Me.cmd_Close.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Close.Name = "cmd_Close"
        Me.cmd_Close.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Close.TabIndex = 6
        Me.cmd_Close.Text = "閉じる(&C)"
        Me.cmd_Close.UseVisualStyleBackColor = True
        '
        ' cmd_Clear
        '
        Me.cmd_Clear.Location = New System.Drawing.Point(612, 3)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Clear.TabIndex = 7
        Me.cmd_Clear.Text = "クリア(&L)"
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        ' cmd_AddAll
        '
        Me.cmd_AddAll.Location = New System.Drawing.Point(204, 124)
        Me.cmd_AddAll.Name = "cmd_AddAll"
        Me.cmd_AddAll.Size = New System.Drawing.Size(75, 23)
        Me.cmd_AddAll.TabIndex = 8
        Me.cmd_AddAll.Text = "＞＞"
        Me.cmd_AddAll.UseVisualStyleBackColor = True
        '
        ' txt_SaveNo
        '
        Me.txt_SaveNo.Location = New System.Drawing.Point(302, 37)
        Me.txt_SaveNo.Name = "txt_SaveNo"
        Me.txt_SaveNo.Size = New System.Drawing.Size(50, 19)
        Me.txt_SaveNo.TabIndex = 9
        '
        ' ラベル18
        '
        Me.ラベル18.AutoSize = True
        Me.ラベル18.Location = New System.Drawing.Point(7, 79)
        Me.ラベル18.Name = "ラベル18"
        Me.ラベル18.TabIndex = 10
        Me.ラベル18.Text = "出力項目候補"
        '
        ' ラベル19
        '
        Me.ラベル19.AutoSize = True
        Me.ラベル19.Location = New System.Drawing.Point(260, 79)
        Me.ラベル19.Name = "ラベル19"
        Me.ラベル19.TabIndex = 11
        Me.ラベル19.Text = "出力項目定義"
        '
        ' ラベル21
        '
        Me.ラベル21.AutoSize = True
        Me.ラベル21.Location = New System.Drawing.Point(207, 253)
        Me.ラベル21.Name = "ラベル21"
        Me.ラベル21.TabIndex = 12
        Me.ラベル21.Text = "優先順"
        '
        ' ラベル32
        '
        Me.ラベル32.AutoSize = True
        Me.ラベル32.Location = New System.Drawing.Point(423, 56)
        Me.ラベル32.Name = "ラベル32"
        Me.ラベル32.TabIndex = 13
        Me.ラベル32.Text = "定義種類"
        '
        ' ラベル37
        '
        Me.ラベル37.AutoSize = True
        Me.ラベル37.Location = New System.Drawing.Point(525, 56)
        Me.ラベル37.Name = "ラベル37"
        Me.ラベル37.TabIndex = 14
        Me.ラベル37.Text = "明細(&M)"
        '
        ' ラベル39
        '
        Me.ラベル39.AutoSize = True
        Me.ラベル39.Location = New System.Drawing.Point(600, 56)
        Me.ラベル39.Name = "ラベル39"
        Me.ラベル39.TabIndex = 15
        Me.ラベル39.Text = "集計(&T)"
        '
        ' ラベル27
        '
        Me.ラベル27.AutoSize = True
        Me.ラベル27.Location = New System.Drawing.Point(7, 56)
        Me.ラベル27.Name = "ラベル27"
        Me.ラベル27.TabIndex = 16
        Me.ラベル27.Text = "定義名(&N)"
        '
        ' lbl_ColNmOut_F
        '
        Me.lbl_ColNmOut_F.AutoSize = True
        Me.lbl_ColNmOut_F.Location = New System.Drawing.Point(7, 325)
        Me.lbl_ColNmOut_F.Name = "lbl_ColNmOut_F"
        Me.lbl_ColNmOut_F.TabIndex = 17
        Me.lbl_ColNmOut_F.Text = "定義済み項目を消さない"
        '
        ' chk_AllHyoj_F
        '
        Me.chk_AllHyoj_F.AutoSize = True
        Me.chk_AllHyoj_F.Location = New System.Drawing.Point(154, 325)
        Me.chk_AllHyoj_F.Name = "chk_AllHyoj_F"
        Me.chk_AllHyoj_F.TabIndex = 18
        Me.chk_AllHyoj_F.Text = ""
        Me.chk_AllHyoj_F.UseVisualStyleBackColor = True
        '
        ' lst_FldLst
        '
        Me.lst_FldLst.FormattingEnabled = True
        Me.lst_FldLst.Location = New System.Drawing.Point(7, 98)
        Me.lst_FldLst.Name = "lst_FldLst"
        Me.lst_FldLst.Size = New System.Drawing.Size(189, 219)
        Me.lst_FldLst.TabIndex = 19
        '
        ' opt_Dtl
        '
        Me.opt_Dtl.AutoSize = True
        Me.opt_Dtl.Location = New System.Drawing.Point(510, 56)
        Me.opt_Dtl.Name = "opt_Dtl"
        Me.opt_Dtl.TabIndex = 20
        Me.opt_Dtl.Text = ""
        Me.opt_Dtl.UseVisualStyleBackColor = True
        '
        ' opt_Sum
        '
        Me.opt_Sum.AutoSize = True
        Me.opt_Sum.Location = New System.Drawing.Point(585, 56)
        Me.opt_Sum.Name = "opt_Sum"
        Me.opt_Sum.TabIndex = 21
        Me.opt_Sum.Text = ""
        Me.opt_Sum.UseVisualStyleBackColor = True
        '
        ' Form_f_FlexOutputDLG_Def
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 593)
        Me.Controls.Add(Me.opt_Dtl)
        Me.Controls.Add(Me.opt_Sum)
        Me.Controls.Add(Me.lst_FldLst)
        Me.Controls.Add(Me.chk_AllHyoj_F)
        Me.Controls.Add(Me.ラベル18)
        Me.Controls.Add(Me.ラベル19)
        Me.Controls.Add(Me.ラベル21)
        Me.Controls.Add(Me.ラベル32)
        Me.Controls.Add(Me.ラベル37)
        Me.Controls.Add(Me.ラベル39)
        Me.Controls.Add(Me.ラベル27)
        Me.Controls.Add(Me.lbl_ColNmOut_F)
        Me.Controls.Add(Me.txt_SaveNo)
        Me.Controls.Add(Me.cmd_Add)
        Me.Controls.Add(Me.cmd_LineDel)
        Me.Controls.Add(Me.cmd_UP)
        Me.Controls.Add(Me.cmd_DOWN)
        Me.Controls.Add(Me.cmd_Save)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_Close)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_AddAll)
        Me.Name = "Form_f_FlexOutputDLG_Def"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "＞"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_LineDel As System.Windows.Forms.Button
    Friend WithEvents cmd_UP As System.Windows.Forms.Button
    Friend WithEvents cmd_DOWN As System.Windows.Forms.Button
    Friend WithEvents cmd_Save As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_Close As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_AddAll As System.Windows.Forms.Button
    Friend WithEvents txt_SaveNo As System.Windows.Forms.TextBox
    Friend WithEvents ラベル18 As System.Windows.Forms.Label
    Friend WithEvents ラベル19 As System.Windows.Forms.Label
    Friend WithEvents ラベル21 As System.Windows.Forms.Label
    Friend WithEvents ラベル32 As System.Windows.Forms.Label
    Friend WithEvents ラベル37 As System.Windows.Forms.Label
    Friend WithEvents ラベル39 As System.Windows.Forms.Label
    Friend WithEvents ラベル27 As System.Windows.Forms.Label
    Friend WithEvents lbl_ColNmOut_F As System.Windows.Forms.Label
    Friend WithEvents chk_AllHyoj_F As System.Windows.Forms.CheckBox
    Friend WithEvents lst_FldLst As System.Windows.Forms.ListBox
    Friend WithEvents opt_Dtl As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Sum As System.Windows.Forms.RadioButton

End Class