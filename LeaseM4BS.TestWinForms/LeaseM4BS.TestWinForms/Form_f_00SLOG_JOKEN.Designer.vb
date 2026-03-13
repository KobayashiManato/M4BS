<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_00SLOG_JOKEN

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
        Me.txt_KIKAN_FROM = New System.Windows.Forms.TextBox()
        Me.txt_KIKAN_TO = New System.Windows.Forms.TextBox()
        Me.txt_DATE_CNT = New System.Windows.Forms.TextBox()
        Me.ラベル571 = New System.Windows.Forms.Label()
        Me.ラベル478 = New System.Windows.Forms.Label()
        Me.ラベル471 = New System.Windows.Forms.Label()
        Me.ラベル577 = New System.Windows.Forms.Label()
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
        ' txt_KIKAN_FROM
        '
        Me.txt_KIKAN_FROM.Location = New System.Drawing.Point(113, 57)
        Me.txt_KIKAN_FROM.Name = "txt_KIKAN_FROM"
        Me.txt_KIKAN_FROM.Size = New System.Drawing.Size(94, 19)
        Me.txt_KIKAN_FROM.TabIndex = 2
        '
        ' txt_KIKAN_TO
        '
        Me.txt_KIKAN_TO.Location = New System.Drawing.Point(226, 57)
        Me.txt_KIKAN_TO.Name = "txt_KIKAN_TO"
        Me.txt_KIKAN_TO.Size = New System.Drawing.Size(94, 19)
        Me.txt_KIKAN_TO.TabIndex = 3
        '
        ' txt_DATE_CNT
        '
        Me.txt_DATE_CNT.Location = New System.Drawing.Point(328, 56)
        Me.txt_DATE_CNT.Name = "txt_DATE_CNT"
        Me.txt_DATE_CNT.Size = New System.Drawing.Size(60, 19)
        Me.txt_DATE_CNT.TabIndex = 4
        '
        ' ラベル571
        '
        Me.ラベル571.AutoSize = True
        Me.ラベル571.Location = New System.Drawing.Point(18, 56)
        Me.ラベル571.Name = "ラベル571"
        Me.ラベル571.TabIndex = 5
        Me.ラベル571.Text = "抽出期間"
        '
        ' ラベル478
        '
        Me.ラベル478.AutoSize = True
        Me.ラベル478.Location = New System.Drawing.Point(393, 56)
        Me.ラベル478.Name = "ラベル478"
        Me.ラベル478.TabIndex = 6
        Me.ラベル478.Text = "日"
        '
        ' ラベル471
        '
        Me.ラベル471.AutoSize = True
        Me.ラベル471.Location = New System.Drawing.Point(207, 56)
        Me.ラベル471.Name = "ラベル471"
        Me.ラベル471.TabIndex = 7
        Me.ラベル471.Text = "～"
        '
        ' ラベル577
        '
        Me.ラベル577.AutoSize = True
        Me.ラベル577.Location = New System.Drawing.Point(75, 83)
        Me.ラベル577.Name = "ラベル577"
        Me.ラベル577.TabIndex = 8
        Me.ラベル577.Text = "抽出対象期間をyyyy/mm/dd の形式で入力してください。"
        '
        ' Form_f_00SLOG_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 313)
        Me.Controls.Add(Me.ラベル571)
        Me.Controls.Add(Me.ラベル478)
        Me.Controls.Add(Me.ラベル471)
        Me.Controls.Add(Me.ラベル577)
        Me.Controls.Add(Me.txt_KIKAN_FROM)
        Me.Controls.Add(Me.txt_KIKAN_TO)
        Me.Controls.Add(Me.txt_DATE_CNT)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_00SLOG_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "操作ログ抽出条件"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_KIKAN_FROM As System.Windows.Forms.TextBox
    Friend WithEvents txt_KIKAN_TO As System.Windows.Forms.TextBox
    Friend WithEvents txt_DATE_CNT As System.Windows.Forms.TextBox
    Friend WithEvents ラベル571 As System.Windows.Forms.Label
    Friend WithEvents ラベル478 As System.Windows.Forms.Label
    Friend WithEvents ラベル471 As System.Windows.Forms.Label
    Friend WithEvents ラベル577 As System.Windows.Forms.Label

End Class