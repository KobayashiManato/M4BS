<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_IMPORT_最終確認

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
        Me.cmd_TOUROKU = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.B物件No_ラベル = New System.Windows.Forms.Label()
        Me.ラベル245 = New System.Windows.Forms.Label()
        Me.lbl_func = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_TOUROKU
        '
        Me.cmd_TOUROKU.Location = New System.Drawing.Point(3, 3)
        Me.cmd_TOUROKU.Name = "cmd_TOUROKU"
        Me.cmd_TOUROKU.Size = New System.Drawing.Size(75, 26)
        Me.cmd_TOUROKU.TabIndex = 0
        Me.cmd_TOUROKU.Text = "本登録(&T)"
        Me.cmd_TOUROKU.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(86, 3)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' B物件No_ラベル
        '
        Me.B物件No_ラベル.AutoSize = True
        Me.B物件No_ラベル.Location = New System.Drawing.Point(3, 56)
        Me.B物件No_ラベル.Name = "B物件No_ラベル"
        Me.B物件No_ラベル.TabIndex = 2
        Me.B物件No_ラベル.Text = "＜追加契約書＞"
        '
        ' ラベル245
        '
        Me.ラベル245.AutoSize = True
        Me.ラベル245.Location = New System.Drawing.Point(3, 279)
        Me.ラベル245.Name = "ラベル245"
        Me.ラベル245.TabIndex = 3
        Me.ラベル245.Text = "＜追加マスタ＞"
        '
        ' lbl_func
        '
        Me.lbl_func.AutoSize = True
        Me.lbl_func.Location = New System.Drawing.Point(3, 37)
        Me.lbl_func.Name = "lbl_func"
        Me.lbl_func.TabIndex = 4
        Me.lbl_func.Text = "<追加取込>"
        '
        ' Form_f_IMPORT_最終確認
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 535)
        Me.Controls.Add(Me.B物件No_ラベル)
        Me.Controls.Add(Me.ラベル245)
        Me.Controls.Add(Me.lbl_func)
        Me.Controls.Add(Me.cmd_TOUROKU)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_IMPORT_最終確認"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Excel取り込み 最終確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_TOUROKU As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents B物件No_ラベル As System.Windows.Forms.Label
    Friend WithEvents ラベル245 As System.Windows.Forms.Label
    Friend WithEvents lbl_func As System.Windows.Forms.Label

End Class