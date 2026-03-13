<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_BEPPYO2_JOKEN

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
        Me.cmd_EXECUTE = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.cmd_ZENKAI = New System.Windows.Forms.Button()
        Me.txt_DT_FROM = New System.Windows.Forms.TextBox()
        Me.txt_DT_TO = New System.Windows.Forms.TextBox()
        Me.txt_FISCAL_YEAR = New System.Windows.Forms.TextBox()
        Me.ラベル471 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル497 = New System.Windows.Forms.Label()
        Me.chk_FULL_YEAR = New System.Windows.Forms.RadioButton()
        Me.chk_HALF_YEAR = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
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
        'cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(149, 13)
        Me.cmd_CANCEL.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CANCEL.TabIndex = 3
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(648, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(170, 39)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'txt_DT_FROM
        '
        Me.txt_DT_FROM.Location = New System.Drawing.Point(480, 138)
        Me.txt_DT_FROM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_DT_FROM.Name = "txt_DT_FROM"
        Me.txt_DT_FROM.ReadOnly = True
        Me.txt_DT_FROM.Size = New System.Drawing.Size(122, 25)
        Me.txt_DT_FROM.TabIndex = 3
        '
        'txt_DT_TO
        '
        Me.txt_DT_TO.Location = New System.Drawing.Point(636, 138)
        Me.txt_DT_TO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_DT_TO.Name = "txt_DT_TO"
        Me.txt_DT_TO.ReadOnly = True
        Me.txt_DT_TO.Size = New System.Drawing.Size(122, 25)
        Me.txt_DT_TO.TabIndex = 4
        '
        'txt_FISCAL_YEAR
        '
        Me.txt_FISCAL_YEAR.Location = New System.Drawing.Point(149, 81)
        Me.txt_FISCAL_YEAR.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_FISCAL_YEAR.Name = "txt_FISCAL_YEAR"
        Me.txt_FISCAL_YEAR.Size = New System.Drawing.Size(122, 25)
        Me.txt_FISCAL_YEAR.TabIndex = 0
        Me.txt_FISCAL_YEAR.Text = "2025"
        Me.txt_FISCAL_YEAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ラベル471
        '
        Me.ラベル471.AutoSize = True
        Me.ラベル471.Location = New System.Drawing.Point(606, 138)
        Me.ラベル471.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル471.Name = "ラベル471"
        Me.ラベル471.Size = New System.Drawing.Size(26, 18)
        Me.ラベル471.TabIndex = 6
        Me.ラベル471.Text = "～"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(30, 84)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(80, 18)
        Me.Lbl.TabIndex = 7
        Me.Lbl.Text = "事業年度"
        '
        'ラベル497
        '
        Me.ラベル497.AutoSize = True
        Me.ラベル497.Location = New System.Drawing.Point(30, 141)
        Me.ラベル497.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル497.Name = "ラベル497"
        Me.ラベル497.Size = New System.Drawing.Size(80, 18)
        Me.ラベル497.TabIndex = 8
        Me.ラベル497.Text = "集計期間"
        '
        'chk_FULL_YEAR
        '
        Me.chk_FULL_YEAR.AutoSize = True
        Me.chk_FULL_YEAR.Checked = True
        Me.chk_FULL_YEAR.Location = New System.Drawing.Point(158, 139)
        Me.chk_FULL_YEAR.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_FULL_YEAR.Name = "chk_FULL_YEAR"
        Me.chk_FULL_YEAR.Size = New System.Drawing.Size(69, 22)
        Me.chk_FULL_YEAR.TabIndex = 1
        Me.chk_FULL_YEAR.TabStop = True
        Me.chk_FULL_YEAR.Text = "通期"
        Me.chk_FULL_YEAR.UseVisualStyleBackColor = True
        '
        'chk_HALF_YEAR
        '
        Me.chk_HALF_YEAR.AutoSize = True
        Me.chk_HALF_YEAR.Location = New System.Drawing.Point(289, 139)
        Me.chk_HALF_YEAR.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chk_HALF_YEAR.Name = "chk_HALF_YEAR"
        Me.chk_HALF_YEAR.Size = New System.Drawing.Size(69, 22)
        Me.chk_HALF_YEAR.TabIndex = 12
        Me.chk_HALF_YEAR.Text = "中間"
        Me.chk_HALF_YEAR.UseVisualStyleBackColor = True
        '
        'Form_f_BEPPYO2_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 233)
        Me.Controls.Add(Me.chk_FULL_YEAR)
        Me.Controls.Add(Me.chk_HALF_YEAR)
        Me.Controls.Add(Me.ラベル471)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル497)
        Me.Controls.Add(Me.txt_DT_FROM)
        Me.Controls.Add(Me.txt_DT_TO)
        Me.Controls.Add(Me.txt_FISCAL_YEAR)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_BEPPYO2_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "別表16(4)期間設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_ZENKAI As System.Windows.Forms.Button
    Friend WithEvents txt_DT_FROM As System.Windows.Forms.TextBox
    Friend WithEvents txt_DT_TO As System.Windows.Forms.TextBox
    Friend WithEvents txt_FISCAL_YEAR As System.Windows.Forms.TextBox
    Friend WithEvents ラベル471 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル497 As System.Windows.Forms.Label
    Friend WithEvents chk_FULL_YEAR As System.Windows.Forms.RadioButton
    Friend WithEvents chk_HALF_YEAR As System.Windows.Forms.RadioButton

End Class