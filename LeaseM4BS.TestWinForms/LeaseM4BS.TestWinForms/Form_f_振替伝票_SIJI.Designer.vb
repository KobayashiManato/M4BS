<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_振替伝票_SIJI

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
        Me.txt_TAISYOKENSU = New System.Windows.Forms.TextBox()
        Me.txt_KENSAKUKENSU = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル0 = New System.Windows.Forms.Label()
        Me.ラベル23 = New System.Windows.Forms.Label()
        Me.ラベル25 = New System.Windows.Forms.Label()
        Me.chk_EXCEL_OUT = New System.Windows.Forms.CheckBox()
        Me.chk_KENSAKU = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(0, 0)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(82, 0)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' txt_TAISYOKENSU
        '
        Me.txt_TAISYOKENSU.Location = New System.Drawing.Point(139, 45)
        Me.txt_TAISYOKENSU.Name = "txt_TAISYOKENSU"
        Me.txt_TAISYOKENSU.Size = New System.Drawing.Size(75, 19)
        Me.txt_TAISYOKENSU.TabIndex = 2
        '
        ' txt_KENSAKUKENSU
        '
        Me.txt_KENSAKUKENSU.Location = New System.Drawing.Point(139, 71)
        Me.txt_KENSAKUKENSU.Name = "txt_KENSAKUKENSU"
        Me.txt_KENSAKUKENSU.Size = New System.Drawing.Size(75, 19)
        Me.txt_KENSAKUKENSU.TabIndex = 3
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(45, 45)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 4
        Me.Lbl.Text = "対象件数"
        '
        ' ラベル0
        '
        Me.ラベル0.AutoSize = True
        Me.ラベル0.Location = New System.Drawing.Point(45, 71)
        Me.ラベル0.Name = "ラベル0"
        Me.ラベル0.TabIndex = 5
        Me.ラベル0.Text = "内検索件数"
        '
        ' ラベル23
        '
        Me.ラベル23.AutoSize = True
        Me.ラベル23.Location = New System.Drawing.Point(90, 102)
        Me.ラベル23.Name = "ラベル23"
        Me.ラベル23.TabIndex = 6
        Me.ラベル23.Text = "明細のEXCEL出力を行う"
        '
        ' ラベル25
        '
        Me.ラベル25.AutoSize = True
        Me.ラベル25.Location = New System.Drawing.Point(90, 124)
        Me.ラベル25.Name = "ラベル25"
        Me.ラベル25.TabIndex = 7
        Me.ラベル25.Text = "月次仕訳計上フレックスの検索条件に従う"
        '
        ' chk_EXCEL_OUT
        '
        Me.chk_EXCEL_OUT.AutoSize = True
        Me.chk_EXCEL_OUT.Location = New System.Drawing.Point(75, 104)
        Me.chk_EXCEL_OUT.Name = "chk_EXCEL_OUT"
        Me.chk_EXCEL_OUT.TabIndex = 8
        Me.chk_EXCEL_OUT.Text = ""
        Me.chk_EXCEL_OUT.UseVisualStyleBackColor = True
        '
        ' chk_KENSAKU
        '
        Me.chk_KENSAKU.AutoSize = True
        Me.chk_KENSAKU.Location = New System.Drawing.Point(75, 126)
        Me.chk_KENSAKU.Name = "chk_KENSAKU"
        Me.chk_KENSAKU.TabIndex = 9
        Me.chk_KENSAKU.Text = ""
        Me.chk_KENSAKU.UseVisualStyleBackColor = True
        '
        ' Form_f_振替伝票_SIJI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 200)
        Me.Controls.Add(Me.chk_EXCEL_OUT)
        Me.Controls.Add(Me.chk_KENSAKU)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル0)
        Me.Controls.Add(Me.ラベル23)
        Me.Controls.Add(Me.ラベル25)
        Me.Controls.Add(Me.txt_TAISYOKENSU)
        Me.Controls.Add(Me.txt_KENSAKUKENSU)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_f_振替伝票_SIJI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "振替伝票印刷"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_TAISYOKENSU As System.Windows.Forms.TextBox
    Friend WithEvents txt_KENSAKUKENSU As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル0 As System.Windows.Forms.Label
    Friend WithEvents ラベル23 As System.Windows.Forms.Label
    Friend WithEvents ラベル25 As System.Windows.Forms.Label
    Friend WithEvents chk_EXCEL_OUT As System.Windows.Forms.CheckBox
    Friend WithEvents chk_KENSAKU As System.Windows.Forms.CheckBox

End Class