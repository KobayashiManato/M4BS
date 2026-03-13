<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_合算

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
        Me.cmd_実行 = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_行追加 = New System.Windows.Forms.Button()
        Me.cmd_行削除 = New System.Windows.Forms.Button()
        Me.ラベル472 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(90, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_行追加
        '
        Me.cmd_行追加.Location = New System.Drawing.Point(502, 45)
        Me.cmd_行追加.Name = "cmd_行追加"
        Me.cmd_行追加.Size = New System.Drawing.Size(75, 23)
        Me.cmd_行追加.TabIndex = 2
        Me.cmd_行追加.Text = "行追加(&A)"
        Me.cmd_行追加.UseVisualStyleBackColor = True
        '
        ' cmd_行削除
        '
        Me.cmd_行削除.Location = New System.Drawing.Point(578, 45)
        Me.cmd_行削除.Name = "cmd_行削除"
        Me.cmd_行削除.Size = New System.Drawing.Size(75, 23)
        Me.cmd_行削除.TabIndex = 3
        Me.cmd_行削除.Text = "行削除(&D)"
        Me.cmd_行削除.UseVisualStyleBackColor = True
        '
        ' ラベル472
        '
        Me.ラベル472.AutoSize = True
        Me.ラベル472.Location = New System.Drawing.Point(7, 52)
        Me.ラベル472.Name = "ラベル472"
        Me.ラベル472.TabIndex = 4
        Me.ラベル472.Text = "＜合算リスト＞"
        '
        ' Form_f_合算
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 515)
        Me.Controls.Add(Me.ラベル472)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_行追加)
        Me.Controls.Add(Me.cmd_行削除)
        Me.Name = "Form_f_合算"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "拠点データ合算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_行追加 As System.Windows.Forms.Button
    Friend WithEvents cmd_行削除 As System.Windows.Forms.Button
    Friend WithEvents ラベル472 As System.Windows.Forms.Label

End Class