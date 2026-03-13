<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_支払仕訳_JOT_伝票番号

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
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_Touroku = New System.Windows.Forms.Button()
        Me.txt_BIKO = New System.Windows.Forms.TextBox()
        Me.txt_KEY = New System.Windows.Forms.TextBox()
        Me.txt_NEXTVAL = New System.Windows.Forms.TextBox()
        Me.lbl_NEXTVAL = New System.Windows.Forms.Label()
        Me.lbl_KEY = New System.Windows.Forms.Label()
        Me.lbl_BIKO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(7, 7)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(75, 26)
        Me.cmd_閉じる.TabIndex = 0
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_Touroku
        '
        Me.cmd_Touroku.Location = New System.Drawing.Point(86, 7)
        Me.cmd_Touroku.Name = "cmd_Touroku"
        Me.cmd_Touroku.Size = New System.Drawing.Size(76, 26)
        Me.cmd_Touroku.TabIndex = 1
        Me.cmd_Touroku.Text = "登録(&T)"
        Me.cmd_Touroku.UseVisualStyleBackColor = True
        '
        ' txt_BIKO
        '
        Me.txt_BIKO.Location = New System.Drawing.Point(113, 0)
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.Size = New System.Drawing.Size(109, 19)
        Me.txt_BIKO.TabIndex = 2
        '
        ' txt_KEY
        '
        Me.txt_KEY.Location = New System.Drawing.Point(3, 0)
        Me.txt_KEY.Name = "txt_KEY"
        Me.txt_KEY.Size = New System.Drawing.Size(109, 19)
        Me.txt_KEY.TabIndex = 3
        '
        ' txt_NEXTVAL
        '
        Me.txt_NEXTVAL.Location = New System.Drawing.Point(222, 0)
        Me.txt_NEXTVAL.Name = "txt_NEXTVAL"
        Me.txt_NEXTVAL.Size = New System.Drawing.Size(151, 19)
        Me.txt_NEXTVAL.TabIndex = 4
        '
        ' lbl_NEXTVAL
        '
        Me.lbl_NEXTVAL.AutoSize = True
        Me.lbl_NEXTVAL.Location = New System.Drawing.Point(222, 45)
        Me.lbl_NEXTVAL.Name = "lbl_NEXTVAL"
        Me.lbl_NEXTVAL.TabIndex = 5
        Me.lbl_NEXTVAL.Text = "次回採番値\015\012(3～7桁目)"
        '
        ' lbl_KEY
        '
        Me.lbl_KEY.AutoSize = True
        Me.lbl_KEY.Location = New System.Drawing.Point(3, 45)
        Me.lbl_KEY.Name = "lbl_KEY"
        Me.lbl_KEY.TabIndex = 6
        Me.lbl_KEY.Text = "年度"
        '
        ' lbl_BIKO
        '
        Me.lbl_BIKO.AutoSize = True
        Me.lbl_BIKO.Location = New System.Drawing.Point(113, 45)
        Me.lbl_BIKO.Name = "lbl_BIKO"
        Me.lbl_BIKO.TabIndex = 7
        Me.lbl_BIKO.Text = "年度記号\015\012（1桁目）"
        '
        ' Form_fc_支払仕訳_JOT_伝票番号
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 602)
        Me.Controls.Add(Me.lbl_NEXTVAL)
        Me.Controls.Add(Me.lbl_KEY)
        Me.Controls.Add(Me.lbl_BIKO)
        Me.Controls.Add(Me.txt_BIKO)
        Me.Controls.Add(Me.txt_KEY)
        Me.Controls.Add(Me.txt_NEXTVAL)
        Me.Controls.Add(Me.cmd_閉じる)
        Me.Controls.Add(Me.cmd_Touroku)
        Me.Name = "Form_fc_支払仕訳_JOT_伝票番号"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "支払日確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_Touroku As System.Windows.Forms.Button
    Friend WithEvents txt_BIKO As System.Windows.Forms.TextBox
    Friend WithEvents txt_KEY As System.Windows.Forms.TextBox
    Friend WithEvents txt_NEXTVAL As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NEXTVAL As System.Windows.Forms.Label
    Friend WithEvents lbl_KEY As System.Windows.Forms.Label
    Friend WithEvents lbl_BIKO As System.Windows.Forms.Label

End Class