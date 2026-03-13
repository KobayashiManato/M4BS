<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_FlexSearchDLG

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
        Me.cmd_Go = New System.Windows.Forms.Button()
        Me.cmd_Cancel = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.cmd_Add = New System.Windows.Forms.Button()
        Me.cmd_記録 = New System.Windows.Forms.Button()
        Me.txt_SaveNo = New System.Windows.Forms.TextBox()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_Kihon = New System.Windows.Forms.Label()
        Me.lbl_ColNmOut_F = New System.Windows.Forms.Label()
        Me.chk_DLGSakiFlag = New System.Windows.Forms.CheckBox()
        Me.lst_FieldList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        ' cmd_Go
        '
        Me.cmd_Go.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Go.Name = "cmd_Go"
        Me.cmd_Go.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Go.TabIndex = 0
        Me.cmd_Go.Text = "実行(&R)"
        Me.cmd_Go.UseVisualStyleBackColor = True
        '
        ' cmd_Cancel
        '
        Me.cmd_Cancel.Location = New System.Drawing.Point(158, 3)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        ' cmd_Clear
        '
        Me.cmd_Clear.Location = New System.Drawing.Point(79, 3)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Clear.TabIndex = 2
        Me.cmd_Clear.Text = "設定ｸﾘｱ(&L)"
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        ' cmd_Add
        '
        Me.cmd_Add.Location = New System.Drawing.Point(136, 56)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Add.TabIndex = 3
        Me.cmd_Add.Text = "追加(&A)"
        Me.cmd_Add.UseVisualStyleBackColor = True
        '
        ' cmd_記録
        '
        Me.cmd_記録.Location = New System.Drawing.Point(612, 461)
        Me.cmd_記録.Name = "cmd_記録"
        Me.cmd_記録.Size = New System.Drawing.Size(75, 23)
        Me.cmd_記録.TabIndex = 4
        Me.cmd_記録.Text = "記録(&K)"
        Me.cmd_記録.UseVisualStyleBackColor = True
        '
        ' txt_SaveNo
        '
        Me.txt_SaveNo.Location = New System.Drawing.Point(408, 461)
        Me.txt_SaveNo.Name = "txt_SaveNo"
        Me.txt_SaveNo.Size = New System.Drawing.Size(50, 19)
        Me.txt_SaveNo.TabIndex = 5
        '
        ' lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(3, 56)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.TabIndex = 6
        Me.lbl_1.Text = "項目名(&I)"
        '
        ' lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Location = New System.Drawing.Point(3, 37)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.TabIndex = 7
        Me.lbl_3.Text = "検索条件"
        '
        ' lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Location = New System.Drawing.Point(200, 461)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.TabIndex = 8
        Me.lbl_2.Text = "条件記録(&S)"
        '
        ' lbl_Kihon
        '
        Me.lbl_Kihon.AutoSize = True
        Me.lbl_Kihon.Location = New System.Drawing.Point(136, 37)
        Me.lbl_Kihon.Name = "lbl_Kihon"
        Me.lbl_Kihon.TabIndex = 9
        Me.lbl_Kihon.Text = "基本条件(&B)"
        '
        ' lbl_ColNmOut_F
        '
        Me.lbl_ColNmOut_F.AutoSize = True
        Me.lbl_ColNmOut_F.Location = New System.Drawing.Point(453, 11)
        Me.lbl_ColNmOut_F.Name = "lbl_ColNmOut_F"
        Me.lbl_ColNmOut_F.TabIndex = 10
        Me.lbl_ColNmOut_F.Text = "検索ﾀﾞｲｱﾛｸﾞを先出しする(&M)"
        '
        ' chk_DLGSakiFlag
        '
        Me.chk_DLGSakiFlag.AutoSize = True
        Me.chk_DLGSakiFlag.Location = New System.Drawing.Point(630, 13)
        Me.chk_DLGSakiFlag.Name = "chk_DLGSakiFlag"
        Me.chk_DLGSakiFlag.TabIndex = 11
        Me.chk_DLGSakiFlag.Text = ""
        Me.chk_DLGSakiFlag.UseVisualStyleBackColor = True
        '
        ' lst_FieldList
        '
        Me.lst_FieldList.FormattingEnabled = True
        Me.lst_FieldList.Location = New System.Drawing.Point(3, 75)
        Me.lst_FieldList.Name = "lst_FieldList"
        Me.lst_FieldList.Size = New System.Drawing.Size(189, 404)
        Me.lst_FieldList.TabIndex = 12
        '
        ' Form_f_FlexSearchDLG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 607)
        Me.Controls.Add(Me.lst_FieldList)
        Me.Controls.Add(Me.chk_DLGSakiFlag)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.lbl_3)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_Kihon)
        Me.Controls.Add(Me.lbl_ColNmOut_F)
        Me.Controls.Add(Me.txt_SaveNo)
        Me.Controls.Add(Me.cmd_Go)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_Add)
        Me.Controls.Add(Me.cmd_記録)
        Me.Name = "Form_f_FlexSearchDLG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "検索条件設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Go As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_記録 As System.Windows.Forms.Button
    Friend WithEvents txt_SaveNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Kihon As System.Windows.Forms.Label
    Friend WithEvents lbl_ColNmOut_F As System.Windows.Forms.Label
    Friend WithEvents chk_DLGSakiFlag As System.Windows.Forms.CheckBox
    Friend WithEvents lst_FieldList As System.Windows.Forms.ListBox

End Class