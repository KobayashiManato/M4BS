<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_更新解約取込_LOG

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
        Me.txt_KIND = New System.Windows.Forms.TextBox()
        Me.txt_MSG = New System.Windows.Forms.TextBox()
        Me.txt_ROW_NO = New System.Windows.Forms.TextBox()
        Me.txt_COL_NM = New System.Windows.Forms.TextBox()
        Me.txt_FLD_VAL = New System.Windows.Forms.TextBox()
        Me.ラベル694 = New System.Windows.Forms.Label()
        Me.ラベル697 = New System.Windows.Forms.Label()
        Me.ラベル754 = New System.Windows.Forms.Label()
        Me.ラベル762 = New System.Windows.Forms.Label()
        Me.ラベル764 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(3, 3)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(75, 26)
        Me.cmd_閉じる.TabIndex = 0
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' txt_KIND
        '
        Me.txt_KIND.Location = New System.Drawing.Point(3, 0)
        Me.txt_KIND.Name = "txt_KIND"
        Me.txt_KIND.Size = New System.Drawing.Size(56, 22)
        Me.txt_KIND.TabIndex = 1
        '
        ' txt_MSG
        '
        Me.txt_MSG.Location = New System.Drawing.Point(60, 0)
        Me.txt_MSG.Name = "txt_MSG"
        Me.txt_MSG.Size = New System.Drawing.Size(377, 22)
        Me.txt_MSG.TabIndex = 2
        '
        ' txt_ROW_NO
        '
        Me.txt_ROW_NO.Location = New System.Drawing.Point(532, 0)
        Me.txt_ROW_NO.Name = "txt_ROW_NO"
        Me.txt_ROW_NO.Size = New System.Drawing.Size(50, 22)
        Me.txt_ROW_NO.TabIndex = 3
        '
        ' txt_COL_NM
        '
        Me.txt_COL_NM.Location = New System.Drawing.Point(438, 0)
        Me.txt_COL_NM.Name = "txt_COL_NM"
        Me.txt_COL_NM.Size = New System.Drawing.Size(94, 22)
        Me.txt_COL_NM.TabIndex = 4
        '
        ' txt_FLD_VAL
        '
        Me.txt_FLD_VAL.Location = New System.Drawing.Point(570, 0)
        Me.txt_FLD_VAL.Name = "txt_FLD_VAL"
        Me.txt_FLD_VAL.Size = New System.Drawing.Size(75, 22)
        Me.txt_FLD_VAL.TabIndex = 5
        '
        ' ラベル694
        '
        Me.ラベル694.AutoSize = True
        Me.ラベル694.Location = New System.Drawing.Point(3, 37)
        Me.ラベル694.Name = "ラベル694"
        Me.ラベル694.TabIndex = 6
        Me.ラベル694.Text = "種別"
        '
        ' ラベル697
        '
        Me.ラベル697.AutoSize = True
        Me.ラベル697.Location = New System.Drawing.Point(60, 37)
        Me.ラベル697.Name = "ラベル697"
        Me.ラベル697.TabIndex = 7
        Me.ラベル697.Text = "内容"
        '
        ' ラベル754
        '
        Me.ラベル754.AutoSize = True
        Me.ラベル754.Location = New System.Drawing.Point(532, 37)
        Me.ラベル754.Name = "ラベル754"
        Me.ラベル754.TabIndex = 8
        Me.ラベル754.Text = "行\015\012番号"
        '
        ' ラベル762
        '
        Me.ラベル762.AutoSize = True
        Me.ラベル762.Location = New System.Drawing.Point(438, 37)
        Me.ラベル762.Name = "ラベル762"
        Me.ラベル762.TabIndex = 9
        Me.ラベル762.Text = "項目名"
        '
        ' ラベル764
        '
        Me.ラベル764.AutoSize = True
        Me.ラベル764.Location = New System.Drawing.Point(570, 37)
        Me.ラベル764.Name = "ラベル764"
        Me.ラベル764.TabIndex = 10
        Me.ラベル764.Text = "値"
        '
        ' Form_f_更新解約取込_LOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 785)
        Me.Controls.Add(Me.ラベル694)
        Me.Controls.Add(Me.ラベル697)
        Me.Controls.Add(Me.ラベル754)
        Me.Controls.Add(Me.ラベル762)
        Me.Controls.Add(Me.ラベル764)
        Me.Controls.Add(Me.txt_KIND)
        Me.Controls.Add(Me.txt_MSG)
        Me.Controls.Add(Me.txt_ROW_NO)
        Me.Controls.Add(Me.txt_COL_NM)
        Me.Controls.Add(Me.txt_FLD_VAL)
        Me.Controls.Add(Me.cmd_閉じる)
        Me.Name = "Form_f_更新解約取込_LOG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "一括再リース／返却　本登録ログ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents txt_KIND As System.Windows.Forms.TextBox
    Friend WithEvents txt_MSG As System.Windows.Forms.TextBox
    Friend WithEvents txt_ROW_NO As System.Windows.Forms.TextBox
    Friend WithEvents txt_COL_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_FLD_VAL As System.Windows.Forms.TextBox
    Friend WithEvents ラベル694 As System.Windows.Forms.Label
    Friend WithEvents ラベル697 As System.Windows.Forms.Label
    Friend WithEvents ラベル754 As System.Windows.Forms.Label
    Friend WithEvents ラベル762 As System.Windows.Forms.Label
    Friend WithEvents ラベル764 As System.Windows.Forms.Label

End Class