<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_支払照合

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
        Me.cmd_照合 = New System.Windows.Forms.Button()
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_実際支払日 = New System.Windows.Forms.Button()
        Me.cmd_照合取消 = New System.Windows.Forms.Button()
        Me.cmd_初期化 = New System.Windows.Forms.Button()
        Me.cmd_AllSet = New System.Windows.Forms.Button()
        Me.cmd_AllReset = New System.Windows.Forms.Button()
        Me.txt_照合日 = New System.Windows.Forms.TextBox()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.ラベル601 = New System.Windows.Forms.Label()
        Me.ラベル606 = New System.Windows.Forms.Label()
        Me.chk_更新可能のみ = New System.Windows.Forms.CheckBox()
        Me.chk_連動入力 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_照合
        '
        Me.cmd_照合.Location = New System.Drawing.Point(94, 7)
        Me.cmd_照合.Name = "cmd_照合"
        Me.cmd_照合.Size = New System.Drawing.Size(75, 26)
        Me.cmd_照合.TabIndex = 0
        Me.cmd_照合.Text = "照合(&R)"
        Me.cmd_照合.UseVisualStyleBackColor = True
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(11, 7)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(75, 26)
        Me.cmd_閉じる.TabIndex = 1
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_実際支払日
        '
        Me.cmd_実際支払日.Location = New System.Drawing.Point(215, 476)
        Me.cmd_実際支払日.Name = "cmd_実際支払日"
        Me.cmd_実際支払日.Size = New System.Drawing.Size(132, 23)
        Me.cmd_実際支払日.TabIndex = 2
        Me.cmd_実際支払日.Text = "実際支払日一括ｾｯﾄ(&I)"
        Me.cmd_実際支払日.UseVisualStyleBackColor = True
        '
        ' cmd_照合取消
        '
        Me.cmd_照合取消.Location = New System.Drawing.Point(616, 476)
        Me.cmd_照合取消.Name = "cmd_照合取消"
        Me.cmd_照合取消.Size = New System.Drawing.Size(75, 23)
        Me.cmd_照合取消.TabIndex = 3
        Me.cmd_照合取消.Text = "照合取消"
        Me.cmd_照合取消.UseVisualStyleBackColor = True
        '
        ' cmd_初期化
        '
        Me.cmd_初期化.Location = New System.Drawing.Point(699, 476)
        Me.cmd_初期化.Name = "cmd_初期化"
        Me.cmd_初期化.Size = New System.Drawing.Size(75, 23)
        Me.cmd_初期化.TabIndex = 4
        Me.cmd_初期化.Text = "初期化"
        Me.cmd_初期化.UseVisualStyleBackColor = True
        '
        ' cmd_AllSet
        '
        Me.cmd_AllSet.Location = New System.Drawing.Point(15, 476)
        Me.cmd_AllSet.Name = "cmd_AllSet"
        Me.cmd_AllSet.Size = New System.Drawing.Size(94, 23)
        Me.cmd_AllSet.TabIndex = 5
        Me.cmd_AllSet.Text = "全ﾁｪｯｸOn(&1)"
        Me.cmd_AllSet.UseVisualStyleBackColor = True
        '
        ' cmd_AllReset
        '
        Me.cmd_AllReset.Location = New System.Drawing.Point(113, 476)
        Me.cmd_AllReset.Name = "cmd_AllReset"
        Me.cmd_AllReset.Size = New System.Drawing.Size(94, 23)
        Me.cmd_AllReset.TabIndex = 6
        Me.cmd_AllReset.Text = "全ﾁｪｯｸOff(&2)"
        Me.cmd_AllReset.UseVisualStyleBackColor = True
        '
        ' txt_照合日
        '
        Me.txt_照合日.Location = New System.Drawing.Point(86, 45)
        Me.txt_照合日.Name = "txt_照合日"
        Me.txt_照合日.Size = New System.Drawing.Size(75, 19)
        Me.txt_照合日.TabIndex = 7
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(11, 45)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 8
        Me.ラベル521.Text = "照合日"
        '
        ' lbl_Msg
        '
        Me.lbl_Msg.AutoSize = True
        Me.lbl_Msg.Location = New System.Drawing.Point(7, 514)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.TabIndex = 9
        Me.lbl_Msg.Text = ""
        '
        ' ラベル601
        '
        Me.ラベル601.AutoSize = True
        Me.ラベル601.Location = New System.Drawing.Point(472, 18)
        Me.ラベル601.Name = "ラベル601"
        Me.ラベル601.TabIndex = 10
        Me.ラベル601.Text = "更新可能な管理単位のみ表示"
        '
        ' ラベル606
        '
        Me.ラベル606.AutoSize = True
        Me.ラベル606.Location = New System.Drawing.Point(472, 41)
        Me.ラベル606.Name = "ラベル606"
        Me.ラベル606.TabIndex = 11
        Me.ラベル606.Text = "入力内容を他行に反映\015\012（支払予定日・支払先・支払方法が同じ行）"
        '
        ' chk_更新可能のみ
        '
        Me.chk_更新可能のみ.AutoSize = True
        Me.chk_更新可能のみ.Location = New System.Drawing.Point(453, 22)
        Me.chk_更新可能のみ.Name = "chk_更新可能のみ"
        Me.chk_更新可能のみ.TabIndex = 12
        Me.chk_更新可能のみ.Text = ""
        Me.chk_更新可能のみ.UseVisualStyleBackColor = True
        '
        ' chk_連動入力
        '
        Me.chk_連動入力.AutoSize = True
        Me.chk_連動入力.Location = New System.Drawing.Point(453, 45)
        Me.chk_連動入力.Name = "chk_連動入力"
        Me.chk_連動入力.TabIndex = 13
        Me.chk_連動入力.Text = ""
        Me.chk_連動入力.UseVisualStyleBackColor = True
        '
        ' Form_f_支払照合
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 676)
        Me.Controls.Add(Me.chk_更新可能のみ)
        Me.Controls.Add(Me.chk_連動入力)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.ラベル601)
        Me.Controls.Add(Me.ラベル606)
        Me.Controls.Add(Me.txt_照合日)
        Me.Controls.Add(Me.cmd_照合)
        Me.Controls.Add(Me.cmd_閉じる)
        Me.Controls.Add(Me.cmd_実際支払日)
        Me.Controls.Add(Me.cmd_照合取消)
        Me.Controls.Add(Me.cmd_初期化)
        Me.Controls.Add(Me.cmd_AllSet)
        Me.Controls.Add(Me.cmd_AllReset)
        Me.Name = "Form_f_支払照合"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YYYY年MM月分　支払照合"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_照合 As System.Windows.Forms.Button
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_実際支払日 As System.Windows.Forms.Button
    Friend WithEvents cmd_照合取消 As System.Windows.Forms.Button
    Friend WithEvents cmd_初期化 As System.Windows.Forms.Button
    Friend WithEvents cmd_AllSet As System.Windows.Forms.Button
    Friend WithEvents cmd_AllReset As System.Windows.Forms.Button
    Friend WithEvents txt_照合日 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents ラベル601 As System.Windows.Forms.Label
    Friend WithEvents ラベル606 As System.Windows.Forms.Label
    Friend WithEvents chk_更新可能のみ As System.Windows.Forms.CheckBox
    Friend WithEvents chk_連動入力 As System.Windows.Forms.CheckBox

End Class