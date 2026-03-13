<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_MYCOM_支払伝票印刷

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
        Me.cmd_印刷 = New System.Windows.Forms.Button()
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_実際支払日 = New System.Windows.Forms.Button()
        Me.cmd_AllSet = New System.Windows.Forms.Button()
        Me.cmd_AllReset = New System.Windows.Forms.Button()
        Me.cmd_取消 = New System.Windows.Forms.Button()
        Me.txt_起票日 = New System.Windows.Forms.TextBox()
        Me.txt_経過勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_経過勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_部門CD = New System.Windows.Forms.TextBox()
        Me.txt_部門名 = New System.Windows.Forms.TextBox()
        Me.txt_仮勘定補助CD = New System.Windows.Forms.TextBox()
        Me.txt_仮勘定補助名 = New System.Windows.Forms.TextBox()
        Me.txt_仮勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_仮勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_未払金勘定補助CD = New System.Windows.Forms.TextBox()
        Me.txt_未払金勘定補助名 = New System.Windows.Forms.TextBox()
        Me.txt_未払金勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_未払金勘定名 = New System.Windows.Forms.TextBox()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル576 = New System.Windows.Forms.Label()
        Me.ラベル580 = New System.Windows.Forms.Label()
        Me.ラベル583 = New System.Windows.Forms.Label()
        Me.ラベル586 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.ラベル601 = New System.Windows.Forms.Label()
        Me.ラベル604 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_印刷
        '
        Me.cmd_印刷.Location = New System.Drawing.Point(86, 3)
        Me.cmd_印刷.Name = "cmd_印刷"
        Me.cmd_印刷.Size = New System.Drawing.Size(75, 26)
        Me.cmd_印刷.TabIndex = 0
        Me.cmd_印刷.Text = "印刷(&P)"
        Me.cmd_印刷.UseVisualStyleBackColor = True
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(3, 3)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(75, 26)
        Me.cmd_閉じる.TabIndex = 1
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_実際支払日
        '
        Me.cmd_実際支払日.Location = New System.Drawing.Point(211, 502)
        Me.cmd_実際支払日.Name = "cmd_実際支払日"
        Me.cmd_実際支払日.Size = New System.Drawing.Size(151, 23)
        Me.cmd_実際支払日.TabIndex = 2
        Me.cmd_実際支払日.Text = "実際支払日一括ｾｯﾄ(&I)"
        Me.cmd_実際支払日.UseVisualStyleBackColor = True
        '
        ' cmd_AllSet
        '
        Me.cmd_AllSet.Location = New System.Drawing.Point(15, 502)
        Me.cmd_AllSet.Name = "cmd_AllSet"
        Me.cmd_AllSet.Size = New System.Drawing.Size(94, 23)
        Me.cmd_AllSet.TabIndex = 3
        Me.cmd_AllSet.Text = "全ﾁｪｯｸOn(&1)"
        Me.cmd_AllSet.UseVisualStyleBackColor = True
        '
        ' cmd_AllReset
        '
        Me.cmd_AllReset.Location = New System.Drawing.Point(113, 502)
        Me.cmd_AllReset.Name = "cmd_AllReset"
        Me.cmd_AllReset.Size = New System.Drawing.Size(94, 23)
        Me.cmd_AllReset.TabIndex = 4
        Me.cmd_AllReset.Text = "全ﾁｪｯｸOff(&2)"
        Me.cmd_AllReset.UseVisualStyleBackColor = True
        '
        ' cmd_取消
        '
        Me.cmd_取消.Location = New System.Drawing.Point(162, 3)
        Me.cmd_取消.Name = "cmd_取消"
        Me.cmd_取消.Size = New System.Drawing.Size(75, 26)
        Me.cmd_取消.TabIndex = 5
        Me.cmd_取消.Text = "取消(&T)"
        Me.cmd_取消.UseVisualStyleBackColor = True
        '
        ' txt_起票日
        '
        Me.txt_起票日.Location = New System.Drawing.Point(86, 45)
        Me.txt_起票日.Name = "txt_起票日"
        Me.txt_起票日.Size = New System.Drawing.Size(75, 19)
        Me.txt_起票日.TabIndex = 6
        '
        ' txt_経過勘定CD
        '
        Me.txt_経過勘定CD.Location = New System.Drawing.Point(264, 79)
        Me.txt_経過勘定CD.Name = "txt_経過勘定CD"
        Me.txt_経過勘定CD.Size = New System.Drawing.Size(56, 19)
        Me.txt_経過勘定CD.TabIndex = 7
        '
        ' txt_経過勘定名
        '
        Me.txt_経過勘定名.Location = New System.Drawing.Point(321, 79)
        Me.txt_経過勘定名.Name = "txt_経過勘定名"
        Me.txt_経過勘定名.Size = New System.Drawing.Size(151, 19)
        Me.txt_経過勘定名.TabIndex = 8
        '
        ' txt_部門CD
        '
        Me.txt_部門CD.Location = New System.Drawing.Point(566, 79)
        Me.txt_部門CD.Name = "txt_部門CD"
        Me.txt_部門CD.Size = New System.Drawing.Size(56, 19)
        Me.txt_部門CD.TabIndex = 9
        '
        ' txt_部門名
        '
        Me.txt_部門名.Location = New System.Drawing.Point(623, 79)
        Me.txt_部門名.Name = "txt_部門名"
        Me.txt_部門名.Size = New System.Drawing.Size(151, 19)
        Me.txt_部門名.TabIndex = 10
        '
        ' txt_仮勘定補助CD
        '
        Me.txt_仮勘定補助CD.Location = New System.Drawing.Point(264, 60)
        Me.txt_仮勘定補助CD.Name = "txt_仮勘定補助CD"
        Me.txt_仮勘定補助CD.Size = New System.Drawing.Size(56, 19)
        Me.txt_仮勘定補助CD.TabIndex = 11
        '
        ' txt_仮勘定補助名
        '
        Me.txt_仮勘定補助名.Location = New System.Drawing.Point(321, 60)
        Me.txt_仮勘定補助名.Name = "txt_仮勘定補助名"
        Me.txt_仮勘定補助名.Size = New System.Drawing.Size(151, 19)
        Me.txt_仮勘定補助名.TabIndex = 12
        '
        ' txt_仮勘定CD
        '
        Me.txt_仮勘定CD.Location = New System.Drawing.Point(264, 45)
        Me.txt_仮勘定CD.Name = "txt_仮勘定CD"
        Me.txt_仮勘定CD.Size = New System.Drawing.Size(56, 19)
        Me.txt_仮勘定CD.TabIndex = 13
        '
        ' txt_仮勘定名
        '
        Me.txt_仮勘定名.Location = New System.Drawing.Point(321, 45)
        Me.txt_仮勘定名.Name = "txt_仮勘定名"
        Me.txt_仮勘定名.Size = New System.Drawing.Size(151, 19)
        Me.txt_仮勘定名.TabIndex = 14
        '
        ' txt_未払金勘定補助CD
        '
        Me.txt_未払金勘定補助CD.Location = New System.Drawing.Point(566, 60)
        Me.txt_未払金勘定補助CD.Name = "txt_未払金勘定補助CD"
        Me.txt_未払金勘定補助CD.Size = New System.Drawing.Size(56, 19)
        Me.txt_未払金勘定補助CD.TabIndex = 15
        '
        ' txt_未払金勘定補助名
        '
        Me.txt_未払金勘定補助名.Location = New System.Drawing.Point(623, 60)
        Me.txt_未払金勘定補助名.Name = "txt_未払金勘定補助名"
        Me.txt_未払金勘定補助名.Size = New System.Drawing.Size(151, 19)
        Me.txt_未払金勘定補助名.TabIndex = 16
        '
        ' txt_未払金勘定CD
        '
        Me.txt_未払金勘定CD.Location = New System.Drawing.Point(566, 45)
        Me.txt_未払金勘定CD.Name = "txt_未払金勘定CD"
        Me.txt_未払金勘定CD.Size = New System.Drawing.Size(56, 19)
        Me.txt_未払金勘定CD.TabIndex = 17
        '
        ' txt_未払金勘定名
        '
        Me.txt_未払金勘定名.Location = New System.Drawing.Point(623, 45)
        Me.txt_未払金勘定名.Name = "txt_未払金勘定名"
        Me.txt_未払金勘定名.Size = New System.Drawing.Size(151, 19)
        Me.txt_未払金勘定名.TabIndex = 18
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(11, 45)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 19
        Me.ラベル521.Text = "起票日"
        '
        ' ラベル576
        '
        Me.ラベル576.AutoSize = True
        Me.ラベル576.Location = New System.Drawing.Point(177, 79)
        Me.ラベル576.Name = "ラベル576"
        Me.ラベル576.TabIndex = 20
        Me.ラベル576.Text = "貸借経過勘定"
        '
        ' ラベル580
        '
        Me.ラベル580.AutoSize = True
        Me.ラベル580.Location = New System.Drawing.Point(480, 79)
        Me.ラベル580.Name = "ラベル580"
        Me.ラベル580.TabIndex = 21
        Me.ラベル580.Text = "部門"
        '
        ' ラベル583
        '
        Me.ラベル583.AutoSize = True
        Me.ラベル583.Location = New System.Drawing.Point(177, 60)
        Me.ラベル583.Name = "ラベル583"
        Me.ラベル583.TabIndex = 22
        Me.ラベル583.Text = "仮払勘定補助"
        '
        ' ラベル586
        '
        Me.ラベル586.AutoSize = True
        Me.ラベル586.Location = New System.Drawing.Point(177, 45)
        Me.ラベル586.Name = "ラベル586"
        Me.ラベル586.TabIndex = 23
        Me.ラベル586.Text = "仮払勘定"
        '
        ' lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.Location = New System.Drawing.Point(7, 540)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.TabIndex = 24
        Me.lbl_Msg.Text = ""
        '
        ' ラベル601
        '
        Me.ラベル601.AutoSize = True
        Me.ラベル601.Location = New System.Drawing.Point(480, 60)
        Me.ラベル601.Name = "ラベル601"
        Me.ラベル601.TabIndex = 25
        Me.ラベル601.Text = "未払勘定補助"
        '
        ' ラベル604
        '
        Me.ラベル604.AutoSize = True
        Me.ラベル604.Location = New System.Drawing.Point(480, 45)
        Me.ラベル604.Name = "ラベル604"
        Me.ラベル604.TabIndex = 26
        Me.ラベル604.Text = "未払勘定"
        '
        ' Form_fc_MYCOM_支払伝票印刷
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 735)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル576)
        Me.Controls.Add(Me.ラベル580)
        Me.Controls.Add(Me.ラベル583)
        Me.Controls.Add(Me.ラベル586)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.ラベル601)
        Me.Controls.Add(Me.ラベル604)
        Me.Controls.Add(Me.txt_起票日)
        Me.Controls.Add(Me.txt_経過勘定CD)
        Me.Controls.Add(Me.txt_経過勘定名)
        Me.Controls.Add(Me.txt_部門CD)
        Me.Controls.Add(Me.txt_部門名)
        Me.Controls.Add(Me.txt_仮勘定補助CD)
        Me.Controls.Add(Me.txt_仮勘定補助名)
        Me.Controls.Add(Me.txt_仮勘定CD)
        Me.Controls.Add(Me.txt_仮勘定名)
        Me.Controls.Add(Me.txt_未払金勘定補助CD)
        Me.Controls.Add(Me.txt_未払金勘定補助名)
        Me.Controls.Add(Me.txt_未払金勘定CD)
        Me.Controls.Add(Me.txt_未払金勘定名)
        Me.Controls.Add(Me.cmd_印刷)
        Me.Controls.Add(Me.cmd_閉じる)
        Me.Controls.Add(Me.cmd_実際支払日)
        Me.Controls.Add(Me.cmd_AllSet)
        Me.Controls.Add(Me.cmd_AllReset)
        Me.Controls.Add(Me.cmd_取消)
        Me.Name = "Form_fc_MYCOM_支払伝票印刷"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YYYY年MM月分　支払伝票印刷"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_印刷 As System.Windows.Forms.Button
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_実際支払日 As System.Windows.Forms.Button
    Friend WithEvents cmd_AllSet As System.Windows.Forms.Button
    Friend WithEvents cmd_AllReset As System.Windows.Forms.Button
    Friend WithEvents cmd_取消 As System.Windows.Forms.Button
    Friend WithEvents txt_起票日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_経過勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_経過勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_部門CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_部門名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮勘定補助CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮勘定補助名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金勘定補助CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金勘定補助名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル576 As System.Windows.Forms.Label
    Friend WithEvents ラベル580 As System.Windows.Forms.Label
    Friend WithEvents ラベル583 As System.Windows.Forms.Label
    Friend WithEvents ラベル586 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents ラベル601 As System.Windows.Forms.Label
    Friend WithEvents ラベル604 As System.Windows.Forms.Label

End Class