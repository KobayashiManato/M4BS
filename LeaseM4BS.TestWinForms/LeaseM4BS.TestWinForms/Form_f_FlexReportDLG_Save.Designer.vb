<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_FlexReportDLG_Save

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
        Me.cmd_Save = New System.Windows.Forms.Button()
        Me.cmd_Close = New System.Windows.Forms.Button()
        Me.cmd_Delete = New System.Windows.Forms.Button()
        Me.txt_SaveNo = New System.Windows.Forms.TextBox()
        Me.テキスト13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Save
        '
        Me.cmd_Save.Location = New System.Drawing.Point(83, 3)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Save.TabIndex = 0
        Me.cmd_Save.Text = "登録(&S)"
        Me.cmd_Save.UseVisualStyleBackColor = True
        '
        ' cmd_Close
        '
        Me.cmd_Close.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Close.Name = "cmd_Close"
        Me.cmd_Close.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Close.TabIndex = 1
        Me.cmd_Close.Text = "閉じる(&C)"
        Me.cmd_Close.UseVisualStyleBackColor = True
        '
        ' cmd_Delete
        '
        Me.cmd_Delete.Location = New System.Drawing.Point(158, 3)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Delete.TabIndex = 2
        Me.cmd_Delete.Text = "削除(&D)"
        Me.cmd_Delete.UseVisualStyleBackColor = True
        '
        ' txt_SaveNo
        '
        Me.txt_SaveNo.Location = New System.Drawing.Point(302, 75)
        Me.txt_SaveNo.Name = "txt_SaveNo"
        Me.txt_SaveNo.Size = New System.Drawing.Size(50, 19)
        Me.txt_SaveNo.TabIndex = 3
        '
        ' テキスト13
        '
        Me.テキスト13.AutoSize = True
        Me.テキスト13.Location = New System.Drawing.Point(7, 56)
        Me.テキスト13.Name = "テキスト13"
        Me.テキスト13.TabIndex = 4
        Me.テキスト13.Text = "記 録 名"
        '
        ' Form_f_FlexReportDLG_Save
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 213)
        Me.Controls.Add(Me.テキスト13)
        Me.Controls.Add(Me.txt_SaveNo)
        Me.Controls.Add(Me.cmd_Save)
        Me.Controls.Add(Me.cmd_Close)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Name = "Form_f_FlexReportDLG_Save"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "記録名の登録／削除"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Save As System.Windows.Forms.Button
    Friend WithEvents cmd_Close As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents txt_SaveNo As System.Windows.Forms.TextBox
    Friend WithEvents テキスト13 As System.Windows.Forms.Label

End Class