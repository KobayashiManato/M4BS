<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_中途解約ツール

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
        Me.cmd_貼付 = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_CHECK = New System.Windows.Forms.Button()
        Me.cmd_中途解約 = New System.Windows.Forms.Button()
        Me.ラベル2 = New System.Windows.Forms.Label()
        Me.ラベル4 = New System.Windows.Forms.Label()
        Me.ラベル6 = New System.Windows.Forms.Label()
        Me.ラベル7 = New System.Windows.Forms.Label()
        Me.ラベル8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_貼付
        '
        Me.cmd_貼付.Location = New System.Drawing.Point(37, 75)
        Me.cmd_貼付.Name = "cmd_貼付"
        Me.cmd_貼付.Size = New System.Drawing.Size(189, 38)
        Me.cmd_貼付.TabIndex = 0
        Me.cmd_貼付.Text = "変更情報の貼り付け"
        Me.cmd_貼付.UseVisualStyleBackColor = True
        '
        ' cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(18, 18)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CLOSE.TabIndex = 1
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        ' cmd_CHECK
        '
        Me.cmd_CHECK.Location = New System.Drawing.Point(37, 151)
        Me.cmd_CHECK.Name = "cmd_CHECK"
        Me.cmd_CHECK.Size = New System.Drawing.Size(189, 38)
        Me.cmd_CHECK.TabIndex = 2
        Me.cmd_CHECK.Text = "チェック"
        Me.cmd_CHECK.UseVisualStyleBackColor = True
        '
        ' cmd_中途解約
        '
        Me.cmd_中途解約.Location = New System.Drawing.Point(37, 226)
        Me.cmd_中途解約.Name = "cmd_中途解約"
        Me.cmd_中途解約.Size = New System.Drawing.Size(189, 38)
        Me.cmd_中途解約.TabIndex = 3
        Me.cmd_中途解約.Text = "中途解約"
        Me.cmd_中途解約.UseVisualStyleBackColor = True
        '
        ' ラベル2
        '
        Me.ラベル2.AutoSize = True
        Me.ラベル2.Location = New System.Drawing.Point(113, 120)
        Me.ラベル2.Name = "ラベル2"
        Me.ラベル2.TabIndex = 4
        Me.ラベル2.Text = "↓"
        '
        ' ラベル4
        '
        Me.ラベル4.AutoSize = True
        Me.ラベル4.Location = New System.Drawing.Point(113, 196)
        Me.ラベル4.Name = "ラベル4"
        Me.ラベル4.TabIndex = 5
        Me.ラベル4.Text = "↓"
        '
        ' ラベル6
        '
        Me.ラベル6.AutoSize = True
        Me.ラベル6.Location = New System.Drawing.Point(245, 170)
        Me.ラベル6.Name = "ラベル6"
        Me.ラベル6.TabIndex = 6
        Me.ラベル6.Text = "・物件No(KYKM_NO)、再ﾘｰｽ回数(SAIKAISU) が同じ行が複数行ある場合、2行目以降は削除されます。"
        '
        ' ラベル7
        '
        Me.ラベル7.AutoSize = True
        Me.ラベル7.Location = New System.Drawing.Point(245, 75)
        Me.ラベル7.Name = "ラベル7"
        Me.ラベル7.TabIndex = 7
        Me.ラベル7.Text = "・契約No(KYKH_NO) はセット不要です。"
        '
        ' ラベル8
        '
        Me.ラベル8.AutoSize = True
        Me.ラベル8.Location = New System.Drawing.Point(245, 151)
        Me.ラベル8.Name = "ラベル8"
        Me.ラベル8.TabIndex = 8
        Me.ラベル8.Text = "・契約No(KYKH_NO) がセットされます。"
        '
        ' Form_f_中途解約ツール
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 314)
        Me.Controls.Add(Me.ラベル2)
        Me.Controls.Add(Me.ラベル4)
        Me.Controls.Add(Me.ラベル6)
        Me.Controls.Add(Me.ラベル7)
        Me.Controls.Add(Me.ラベル8)
        Me.Controls.Add(Me.cmd_貼付)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_CHECK)
        Me.Controls.Add(Me.cmd_中途解約)
        Me.Name = "Form_f_中途解約ツール"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "中途解約ツール"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_貼付 As System.Windows.Forms.Button
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_CHECK As System.Windows.Forms.Button
    Friend WithEvents cmd_中途解約 As System.Windows.Forms.Button
    Friend WithEvents ラベル2 As System.Windows.Forms.Label
    Friend WithEvents ラベル4 As System.Windows.Forms.Label
    Friend WithEvents ラベル6 As System.Windows.Forms.Label
    Friend WithEvents ラベル7 As System.Windows.Forms.Label
    Friend WithEvents ラベル8 As System.Windows.Forms.Label

End Class