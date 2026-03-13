<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_MYCOM_支払伝票印刷_一括設定

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
        Me.cmd_設定 = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.txt_支払予定日 = New System.Windows.Forms.TextBox()
        Me.txt_実支払日 = New System.Windows.Forms.TextBox()
        Me.txt_実支払曜日 = New System.Windows.Forms.TextBox()
        Me.ラベル83 = New System.Windows.Forms.Label()
        Me.ラベル127 = New System.Windows.Forms.Label()
        Me.ラベル31 = New System.Windows.Forms.Label()
        Me.chk_CHECK_F = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_設定
        '
        Me.cmd_設定.Location = New System.Drawing.Point(3, 3)
        Me.cmd_設定.Name = "cmd_設定"
        Me.cmd_設定.Size = New System.Drawing.Size(75, 26)
        Me.cmd_設定.TabIndex = 0
        Me.cmd_設定.Text = "設定(&R)"
        Me.cmd_設定.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(83, 3)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' txt_支払予定日
        '
        Me.txt_支払予定日.Location = New System.Drawing.Point(30, 0)
        Me.txt_支払予定日.Name = "txt_支払予定日"
        Me.txt_支払予定日.Size = New System.Drawing.Size(94, 19)
        Me.txt_支払予定日.TabIndex = 2
        '
        ' txt_実支払日
        '
        Me.txt_実支払日.Location = New System.Drawing.Point(124, 0)
        Me.txt_実支払日.Name = "txt_実支払日"
        Me.txt_実支払日.Size = New System.Drawing.Size(71, 19)
        Me.txt_実支払日.TabIndex = 3
        '
        ' txt_実支払曜日
        '
        Me.txt_実支払曜日.Location = New System.Drawing.Point(196, 0)
        Me.txt_実支払曜日.Name = "txt_実支払曜日"
        Me.txt_実支払曜日.Size = New System.Drawing.Size(50, 19)
        Me.txt_実支払曜日.TabIndex = 4
        '
        ' ラベル83
        '
        Me.ラベル83.AutoSize = True
        Me.ラベル83.Location = New System.Drawing.Point(3, 37)
        Me.ラベル83.Name = "ラベル83"
        Me.ラベル83.TabIndex = 5
        Me.ラベル83.Text = "処理"
        '
        ' ラベル127
        '
        Me.ラベル127.AutoSize = True
        Me.ラベル127.Location = New System.Drawing.Point(124, 37)
        Me.ラベル127.Name = "ラベル127"
        Me.ラベル127.TabIndex = 6
        Me.ラベル127.Text = "実際支払日"
        '
        ' ラベル31
        '
        Me.ラベル31.AutoSize = True
        Me.ラベル31.Location = New System.Drawing.Point(30, 37)
        Me.ラベル31.Name = "ラベル31"
        Me.ラベル31.TabIndex = 7
        Me.ラベル31.Text = "支払予定日"
        '
        ' chk_CHECK_F
        '
        Me.chk_CHECK_F.AutoSize = True
        Me.chk_CHECK_F.Location = New System.Drawing.Point(11, 3)
        Me.chk_CHECK_F.Name = "chk_CHECK_F"
        Me.chk_CHECK_F.TabIndex = 8
        Me.chk_CHECK_F.Text = ""
        Me.chk_CHECK_F.UseVisualStyleBackColor = True
        '
        ' Form_fc_MYCOM_支払伝票印刷_一括設定
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 470)
        Me.Controls.Add(Me.chk_CHECK_F)
        Me.Controls.Add(Me.ラベル83)
        Me.Controls.Add(Me.ラベル127)
        Me.Controls.Add(Me.ラベル31)
        Me.Controls.Add(Me.txt_支払予定日)
        Me.Controls.Add(Me.txt_実支払日)
        Me.Controls.Add(Me.txt_実支払曜日)
        Me.Controls.Add(Me.cmd_設定)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_fc_MYCOM_支払伝票印刷_一括設定"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "実際支払日別設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_設定 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_支払予定日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_実支払日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_実支払曜日 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル83 As System.Windows.Forms.Label
    Friend WithEvents ラベル127 As System.Windows.Forms.Label
    Friend WithEvents ラベル31 As System.Windows.Forms.Label
    Friend WithEvents chk_CHECK_F As System.Windows.Forms.CheckBox

End Class