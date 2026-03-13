<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_預金

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
        Me.cmd_Del = New System.Windows.Forms.Button()
        Me.txt_現金預金科目CD = New System.Windows.Forms.TextBox()
        Me.txt_現金預金科目 = New System.Windows.Forms.TextBox()
        Me.ラベル3 = New System.Windows.Forms.Label()
        Me.ラベル4 = New System.Windows.Forms.Label()
        Me.ラベル533 = New System.Windows.Forms.Label()
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
        ' cmd_Del
        '
        Me.cmd_Del.Location = New System.Drawing.Point(264, 3)
        Me.cmd_Del.Name = "cmd_Del"
        Me.cmd_Del.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Del.TabIndex = 1
        Me.cmd_Del.Text = "行削除(&D)"
        Me.cmd_Del.UseVisualStyleBackColor = True
        '
        ' txt_現金預金科目CD
        '
        Me.txt_現金預金科目CD.Location = New System.Drawing.Point(3, 0)
        Me.txt_現金預金科目CD.Name = "txt_現金預金科目CD"
        Me.txt_現金預金科目CD.Size = New System.Drawing.Size(94, 19)
        Me.txt_現金預金科目CD.TabIndex = 2
        '
        ' txt_現金預金科目
        '
        Me.txt_現金預金科目.Location = New System.Drawing.Point(98, 0)
        Me.txt_現金預金科目.Name = "txt_現金預金科目"
        Me.txt_現金預金科目.Size = New System.Drawing.Size(242, 19)
        Me.txt_現金預金科目.TabIndex = 3
        '
        ' ラベル3
        '
        Me.ラベル3.AutoSize = True
        Me.ラベル3.Location = New System.Drawing.Point(3, 37)
        Me.ラベル3.Name = "ラベル3"
        Me.ラベル3.TabIndex = 4
        Me.ラベル3.Text = "預金科目CD"
        '
        ' ラベル4
        '
        Me.ラベル4.AutoSize = True
        Me.ラベル4.Location = New System.Drawing.Point(98, 37)
        Me.ラベル4.Name = "ラベル4"
        Me.ラベル4.TabIndex = 5
        Me.ラベル4.Text = "預金科目"
        '
        ' ラベル533
        '
        Me.ラベル533.AutoSize = True
        Me.ラベル533.Location = New System.Drawing.Point(3, 3)
        Me.ラベル533.Name = "ラベル533"
        Me.ラベル533.TabIndex = 6
        Me.ラベル533.Text = "※ここで設定した内容はデータベースには反映されません。\015\012　（当該クライアントにのみ反映）"
        '
        ' Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_預金
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 535)
        Me.Controls.Add(Me.ラベル3)
        Me.Controls.Add(Me.ラベル4)
        Me.Controls.Add(Me.ラベル533)
        Me.Controls.Add(Me.txt_現金預金科目CD)
        Me.Controls.Add(Me.txt_現金預金科目)
        Me.Controls.Add(Me.cmd_閉じる)
        Me.Controls.Add(Me.cmd_Del)
        Me.Name = "Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_預金"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "預金科目の登録"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_Del As System.Windows.Forms.Button
    Friend WithEvents txt_現金預金科目CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_現金預金科目 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル3 As System.Windows.Forms.Label
    Friend WithEvents ラベル4 As System.Windows.Forms.Label
    Friend WithEvents ラベル533 As System.Windows.Forms.Label

End Class