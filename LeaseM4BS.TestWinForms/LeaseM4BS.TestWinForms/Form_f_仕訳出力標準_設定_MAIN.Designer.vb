<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_仕訳出力標準_設定_MAIN

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
        Me.cmd_SWKSH = New System.Windows.Forms.Button()
        Me.cmd_SWKKJ = New System.Windows.Forms.Button()
        Me.cmd_SWKSM = New System.Windows.Forms.Button()
        Me.cmd_TOUROKU = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.ラベル1284 = New System.Windows.Forms.Label()
        Me.ラベル1290 = New System.Windows.Forms.Label()
        Me.chk_SWKKY_KMKNM_HOKAN = New System.Windows.Forms.CheckBox()
        Me.chk_SWKKY_DC_BETU_F = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_SWKSH
        '
        Me.cmd_SWKSH.Location = New System.Drawing.Point(37, 56)
        Me.cmd_SWKSH.Name = "cmd_SWKSH"
        Me.cmd_SWKSH.Size = New System.Drawing.Size(340, 26)
        Me.cmd_SWKSH.TabIndex = 0
        Me.cmd_SWKSH.Text = "月次支払照合フレックス"
        Me.cmd_SWKSH.UseVisualStyleBackColor = True
        '
        ' cmd_SWKKJ
        '
        Me.cmd_SWKKJ.Location = New System.Drawing.Point(37, 94)
        Me.cmd_SWKKJ.Name = "cmd_SWKKJ"
        Me.cmd_SWKKJ.Size = New System.Drawing.Size(340, 26)
        Me.cmd_SWKKJ.TabIndex = 1
        Me.cmd_SWKKJ.Text = "月次仕訳計上フレックス"
        Me.cmd_SWKKJ.UseVisualStyleBackColor = True
        '
        ' cmd_SWKSM
        '
        Me.cmd_SWKSM.Location = New System.Drawing.Point(37, 132)
        Me.cmd_SWKSM.Name = "cmd_SWKSM"
        Me.cmd_SWKSM.Size = New System.Drawing.Size(340, 26)
        Me.cmd_SWKSM.TabIndex = 2
        Me.cmd_SWKSM.Text = "リース債務返済明細表"
        Me.cmd_SWKSM.UseVisualStyleBackColor = True
        '
        ' cmd_TOUROKU
        '
        Me.cmd_TOUROKU.Location = New System.Drawing.Point(90, 7)
        Me.cmd_TOUROKU.Name = "cmd_TOUROKU"
        Me.cmd_TOUROKU.Size = New System.Drawing.Size(75, 26)
        Me.cmd_TOUROKU.TabIndex = 3
        Me.cmd_TOUROKU.Text = "登録(&T)"
        Me.cmd_TOUROKU.UseVisualStyleBackColor = True
        '
        ' cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(7, 7)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CLOSE.TabIndex = 4
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        ' ラベル1284
        '
        Me.ラベル1284.AutoSize = True
        Me.ラベル1284.Location = New System.Drawing.Point(37, 189)
        Me.ラベル1284.Name = "ラベル1284"
        Me.ラベル1284.TabIndex = 5
        Me.ラベル1284.Text = "科目コードおよび名称がどちらもブランクの場合、科目名称にデフォルトの値をセット"
        '
        ' ラベル1290
        '
        Me.ラベル1290.AutoSize = True
        Me.ラベル1290.Location = New System.Drawing.Point(37, 207)
        Me.ラベル1290.Name = "ラベル1290"
        Me.ラベル1290.TabIndex = 6
        Me.ラベル1290.Text = "貸借を別行に出力"
        '
        ' chk_SWKKY_KMKNM_HOKAN
        '
        Me.chk_SWKKY_KMKNM_HOKAN.AutoSize = True
        Me.chk_SWKKY_KMKNM_HOKAN.Location = New System.Drawing.Point(502, 192)
        Me.chk_SWKKY_KMKNM_HOKAN.Name = "chk_SWKKY_KMKNM_HOKAN"
        Me.chk_SWKKY_KMKNM_HOKAN.TabIndex = 7
        Me.chk_SWKKY_KMKNM_HOKAN.Text = ""
        Me.chk_SWKKY_KMKNM_HOKAN.UseVisualStyleBackColor = True
        '
        ' chk_SWKKY_DC_BETU_F
        '
        Me.chk_SWKKY_DC_BETU_F.AutoSize = True
        Me.chk_SWKKY_DC_BETU_F.Location = New System.Drawing.Point(502, 211)
        Me.chk_SWKKY_DC_BETU_F.Name = "chk_SWKKY_DC_BETU_F"
        Me.chk_SWKKY_DC_BETU_F.TabIndex = 8
        Me.chk_SWKKY_DC_BETU_F.Text = ""
        Me.chk_SWKKY_DC_BETU_F.UseVisualStyleBackColor = True
        '
        ' Form_f_仕訳出力標準_設定_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 410)
        Me.Controls.Add(Me.chk_SWKKY_KMKNM_HOKAN)
        Me.Controls.Add(Me.chk_SWKKY_DC_BETU_F)
        Me.Controls.Add(Me.ラベル1284)
        Me.Controls.Add(Me.ラベル1290)
        Me.Controls.Add(Me.cmd_SWKSH)
        Me.Controls.Add(Me.cmd_SWKKJ)
        Me.Controls.Add(Me.cmd_SWKSM)
        Me.Controls.Add(Me.cmd_TOUROKU)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Name = "Form_f_仕訳出力標準_設定_MAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳出力設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_SWKSH As System.Windows.Forms.Button
    Friend WithEvents cmd_SWKKJ As System.Windows.Forms.Button
    Friend WithEvents cmd_SWKSM As System.Windows.Forms.Button
    Friend WithEvents cmd_TOUROKU As System.Windows.Forms.Button
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents ラベル1284 As System.Windows.Forms.Label
    Friend WithEvents ラベル1290 As System.Windows.Forms.Label
    Friend WithEvents chk_SWKKY_KMKNM_HOKAN As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SWKKY_DC_BETU_F As System.Windows.Forms.CheckBox

End Class