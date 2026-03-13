<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_00SystemOPT

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
        Me.cmd_Close = New System.Windows.Forms.Button()
        Me.cmd_Save = New System.Windows.Forms.Button()
        Me.ラベル171 = New System.Windows.Forms.Label()
        Me.ラベル173 = New System.Windows.Forms.Label()
        Me.ラベル58 = New System.Windows.Forms.Label()
        Me.ラベル60 = New System.Windows.Forms.Label()
        Me.chk_ULOG = New System.Windows.Forms.CheckBox()
        Me.chk_SLOG = New System.Windows.Forms.CheckBox()
        Me.chk_RECOPT = New System.Windows.Forms.CheckBox()
        Me.chk_CNVLOG = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_Close
        '
        Me.cmd_Close.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Close.Name = "cmd_Close"
        Me.cmd_Close.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Close.TabIndex = 0
        Me.cmd_Close.Text = "閉じる"
        Me.cmd_Close.UseVisualStyleBackColor = True
        '
        ' cmd_Save
        '
        Me.cmd_Save.Location = New System.Drawing.Point(83, 3)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Save.TabIndex = 1
        Me.cmd_Save.Text = "登録"
        Me.cmd_Save.UseVisualStyleBackColor = True
        '
        ' ラベル171
        '
        Me.ラベル171.AutoSize = True
        Me.ラベル171.Location = New System.Drawing.Point(38, 94)
        Me.ラベル171.Name = "ラベル171"
        Me.ラベル171.TabIndex = 2
        Me.ラベル171.Text = "更新ログを出力する"
        '
        ' ラベル173
        '
        Me.ラベル173.AutoSize = True
        Me.ラベル173.Location = New System.Drawing.Point(38, 52)
        Me.ラベル173.Name = "ラベル173"
        Me.ラベル173.TabIndex = 3
        Me.ラベル173.Text = "操作ログを出力する"
        '
        ' ラベル58
        '
        Me.ラベル58.AutoSize = True
        Me.ラベル58.Location = New System.Drawing.Point(38, 131)
        Me.ラベル58.Name = "ラベル58"
        Me.ラベル58.TabIndex = 4
        Me.ラベル58.Text = "ﾚｺｰﾄﾞ内容を更新ﾛｸﾞに出力する"
        '
        ' ラベル60
        '
        Me.ラベル60.AutoSize = True
        Me.ラベル60.Location = New System.Drawing.Point(38, 170)
        Me.ラベル60.Name = "ラベル60"
        Me.ラベル60.TabIndex = 5
        Me.ラベル60.Text = "データｺﾝﾊﾞｰﾄ時、元ﾛｸﾞも読み込む"
        '
        ' chk_ULOG
        '
        Me.chk_ULOG.AutoSize = True
        Me.chk_ULOG.Location = New System.Drawing.Point(22, 98)
        Me.chk_ULOG.Name = "chk_ULOG"
        Me.chk_ULOG.TabIndex = 6
        Me.chk_ULOG.Text = ""
        Me.chk_ULOG.UseVisualStyleBackColor = True
        '
        ' chk_SLOG
        '
        Me.chk_SLOG.AutoSize = True
        Me.chk_SLOG.Location = New System.Drawing.Point(22, 52)
        Me.chk_SLOG.Name = "chk_SLOG"
        Me.chk_SLOG.TabIndex = 7
        Me.chk_SLOG.Text = ""
        Me.chk_SLOG.UseVisualStyleBackColor = True
        '
        ' chk_RECOPT
        '
        Me.chk_RECOPT.AutoSize = True
        Me.chk_RECOPT.Location = New System.Drawing.Point(22, 135)
        Me.chk_RECOPT.Name = "chk_RECOPT"
        Me.chk_RECOPT.TabIndex = 8
        Me.chk_RECOPT.Text = ""
        Me.chk_RECOPT.UseVisualStyleBackColor = True
        '
        ' chk_CNVLOG
        '
        Me.chk_CNVLOG.AutoSize = True
        Me.chk_CNVLOG.Location = New System.Drawing.Point(22, 173)
        Me.chk_CNVLOG.Name = "chk_CNVLOG"
        Me.chk_CNVLOG.TabIndex = 9
        Me.chk_CNVLOG.Text = ""
        Me.chk_CNVLOG.UseVisualStyleBackColor = True
        '
        ' Form_f_00SystemOPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 361)
        Me.Controls.Add(Me.chk_ULOG)
        Me.Controls.Add(Me.chk_SLOG)
        Me.Controls.Add(Me.chk_RECOPT)
        Me.Controls.Add(Me.chk_CNVLOG)
        Me.Controls.Add(Me.ラベル171)
        Me.Controls.Add(Me.ラベル173)
        Me.Controls.Add(Me.ラベル58)
        Me.Controls.Add(Me.ラベル60)
        Me.Controls.Add(Me.cmd_Close)
        Me.Controls.Add(Me.cmd_Save)
        Me.Name = "Form_f_00SystemOPT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "オプション設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Close As System.Windows.Forms.Button
    Friend WithEvents cmd_Save As System.Windows.Forms.Button
    Friend WithEvents ラベル171 As System.Windows.Forms.Label
    Friend WithEvents ラベル173 As System.Windows.Forms.Label
    Friend WithEvents ラベル58 As System.Windows.Forms.Label
    Friend WithEvents ラベル60 As System.Windows.Forms.Label
    Friend WithEvents chk_ULOG As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SLOG As System.Windows.Forms.CheckBox
    Friend WithEvents chk_RECOPT As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CNVLOG As System.Windows.Forms.CheckBox

End Class