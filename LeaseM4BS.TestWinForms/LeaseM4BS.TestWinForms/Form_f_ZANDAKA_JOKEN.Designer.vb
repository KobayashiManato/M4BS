<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_ZANDAKA_JOKEN

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
        Me.txt_DURATION = New System.Windows.Forms.TextBox()
        Me.ラベル478 = New System.Windows.Forms.Label()
        Me.ラベル471 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル513 = New System.Windows.Forms.Label()
        Me.txt_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.txt_DT_TO = New System.Windows.Forms.DateTimePicker()
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
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(618, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(170, 39)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.Text = "前回集計結果(&Z)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
        '
        'txt_DURATION
        '
        Me.txt_DURATION.Location = New System.Drawing.Point(512, 82)
        Me.txt_DURATION.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_DURATION.Name = "txt_DURATION"
        Me.txt_DURATION.ReadOnly = True
        Me.txt_DURATION.Size = New System.Drawing.Size(81, 25)
        Me.txt_DURATION.TabIndex = 5
        '
        'ラベル478
        '
        Me.ラベル478.AutoSize = True
        Me.ラベル478.Location = New System.Drawing.Point(603, 87)
        Me.ラベル478.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル478.Name = "ラベル478"
        Me.ラベル478.Size = New System.Drawing.Size(38, 18)
        Me.ラベル478.TabIndex = 6
        Me.ラベル478.Text = "ヶ月"
        '
        'ラベル471
        '
        Me.ラベル471.AutoSize = True
        Me.ラベル471.Location = New System.Drawing.Point(302, 84)
        Me.ラベル471.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル471.Name = "ラベル471"
        Me.ラベル471.Size = New System.Drawing.Size(26, 18)
        Me.ラベル471.TabIndex = 7
        Me.ラベル471.Text = "～"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(30, 84)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(80, 18)
        Me.Lbl.TabIndex = 8
        Me.Lbl.Text = "決算期間"
        '
        'ラベル513
        '
        Me.ラベル513.AutoSize = True
        Me.ラベル513.Location = New System.Drawing.Point(188, 124)
        Me.ラベル513.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル513.Name = "ラベル513"
        Me.ラベル513.Size = New System.Drawing.Size(263, 18)
        Me.ラベル513.TabIndex = 9
        Me.ラベル513.Text = "yyyy/mm の形式で入力してください"
        '
        'txt_DT_FROM
        '
        Me.txt_DT_FROM.CustomFormat = "yyyy/MM"
        Me.txt_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DT_FROM.Location = New System.Drawing.Point(138, 82)
        Me.txt_DT_FROM.Name = "txt_DT_FROM"
        Me.txt_DT_FROM.Size = New System.Drawing.Size(156, 25)
        Me.txt_DT_FROM.TabIndex = 0
        '
        'txt_DT_TO
        '
        Me.txt_DT_TO.CustomFormat = "yyyy/MM"
        Me.txt_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DT_TO.Location = New System.Drawing.Point(336, 82)
        Me.txt_DT_TO.Name = "txt_DT_TO"
        Me.txt_DT_TO.Size = New System.Drawing.Size(156, 25)
        Me.txt_DT_TO.TabIndex = 1
        '
        'Form_f_ZANDAKA_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 258)
        Me.Controls.Add(Me.txt_DT_TO)
        Me.Controls.Add(Me.txt_DT_FROM)
        Me.Controls.Add(Me.ラベル478)
        Me.Controls.Add(Me.ラベル471)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル513)
        Me.Controls.Add(Me.txt_DURATION)
        Me.Controls.Add(Me.cmd_EXECUTE)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_ZANDAKA_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "リース残高一覧表　決算条件設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXECUTE As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_ZENKAI As System.Windows.Forms.Button
    Friend WithEvents txt_DURATION As System.Windows.Forms.TextBox
    Friend WithEvents ラベル478 As System.Windows.Forms.Label
    Friend WithEvents ラベル471 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル513 As Label
    Friend WithEvents txt_DT_FROM As DateTimePicker
    Friend WithEvents txt_DT_TO As DateTimePicker
End Class