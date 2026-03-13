<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_FlexSearchDLG_Sub

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
        Me.cmd_Del = New System.Windows.Forms.Button()
        Me.cmd_UP = New System.Windows.Forms.Button()
        Me.cmd_DOWN = New System.Windows.Forms.Button()
        Me.cmd_Henkou = New System.Windows.Forms.Button()
        Me.txt_FldNmJPN = New System.Windows.Forms.TextBox()
        Me.txt_Jouken = New System.Windows.Forms.TextBox()
        Me.txt_Ketugou = New System.Windows.Forms.TextBox()
        Me.txt_SearchNo = New System.Windows.Forms.TextBox()
        Me.txt_FldNo = New System.Windows.Forms.TextBox()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_4 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Del
        '
        Me.cmd_Del.Location = New System.Drawing.Point(377, 3)
        Me.cmd_Del.Name = "cmd_Del"
        Me.cmd_Del.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Del.TabIndex = 0
        Me.cmd_Del.Text = "行削除(&D)"
        Me.cmd_Del.UseVisualStyleBackColor = True
        '
        ' cmd_UP
        '
        Me.cmd_UP.Location = New System.Drawing.Point(260, 3)
        Me.cmd_UP.Name = "cmd_UP"
        Me.cmd_UP.Size = New System.Drawing.Size(75, 23)
        Me.cmd_UP.TabIndex = 1
        Me.cmd_UP.Text = "▲"
        Me.cmd_UP.UseVisualStyleBackColor = True
        '
        ' cmd_DOWN
        '
        Me.cmd_DOWN.Location = New System.Drawing.Point(283, 3)
        Me.cmd_DOWN.Name = "cmd_DOWN"
        Me.cmd_DOWN.Size = New System.Drawing.Size(75, 23)
        Me.cmd_DOWN.TabIndex = 2
        Me.cmd_DOWN.Text = "▼"
        Me.cmd_DOWN.UseVisualStyleBackColor = True
        '
        ' cmd_Henkou
        '
        Me.cmd_Henkou.Location = New System.Drawing.Point(313, 3)
        Me.cmd_Henkou.Name = "cmd_Henkou"
        Me.cmd_Henkou.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Henkou.TabIndex = 3
        Me.cmd_Henkou.Text = "変更(&U)"
        Me.cmd_Henkou.UseVisualStyleBackColor = True
        '
        ' txt_FldNmJPN
        '
        Me.txt_FldNmJPN.Location = New System.Drawing.Point(3, 0)
        Me.txt_FldNmJPN.Name = "txt_FldNmJPN"
        Me.txt_FldNmJPN.Size = New System.Drawing.Size(136, 19)
        Me.txt_FldNmJPN.TabIndex = 4
        '
        ' txt_Jouken
        '
        Me.txt_Jouken.Location = New System.Drawing.Point(139, 0)
        Me.txt_Jouken.Name = "txt_Jouken"
        Me.txt_Jouken.Size = New System.Drawing.Size(241, 19)
        Me.txt_Jouken.TabIndex = 5
        '
        ' txt_Ketugou
        '
        Me.txt_Ketugou.Location = New System.Drawing.Point(381, 0)
        Me.txt_Ketugou.Name = "txt_Ketugou"
        Me.txt_Ketugou.Size = New System.Drawing.Size(60, 19)
        Me.txt_Ketugou.TabIndex = 6
        '
        ' txt_SearchNo
        '
        Me.txt_SearchNo.Location = New System.Drawing.Point(56, 0)
        Me.txt_SearchNo.Name = "txt_SearchNo"
        Me.txt_SearchNo.Size = New System.Drawing.Size(50, 19)
        Me.txt_SearchNo.TabIndex = 7
        '
        ' txt_FldNo
        '
        Me.txt_FldNo.Location = New System.Drawing.Point(204, 0)
        Me.txt_FldNo.Name = "txt_FldNo"
        Me.txt_FldNo.Size = New System.Drawing.Size(50, 19)
        Me.txt_FldNo.TabIndex = 8
        '
        ' lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.Location = New System.Drawing.Point(3, 26)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.TabIndex = 9
        Me.lbl_2.Text = "項目名"
        '
        ' lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.Location = New System.Drawing.Point(139, 26)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.TabIndex = 10
        Me.lbl_3.Text = "条件"
        '
        ' lbl_4
        '
        Me.lbl_4.AutoSize = True
        Me.lbl_4.Location = New System.Drawing.Point(381, 26)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.TabIndex = 11
        Me.lbl_4.Text = "結合"
        '
        ' lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.Location = New System.Drawing.Point(3, 0)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.TabIndex = 12
        Me.lbl_1.Text = "実行リスト"
        '
        ' Form_f_FlexSearchDLG_Sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 649)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_3)
        Me.Controls.Add(Me.lbl_4)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.txt_FldNmJPN)
        Me.Controls.Add(Me.txt_Jouken)
        Me.Controls.Add(Me.txt_Ketugou)
        Me.Controls.Add(Me.txt_SearchNo)
        Me.Controls.Add(Me.txt_FldNo)
        Me.Controls.Add(Me.cmd_Del)
        Me.Controls.Add(Me.cmd_UP)
        Me.Controls.Add(Me.cmd_DOWN)
        Me.Controls.Add(Me.cmd_Henkou)
        Me.Name = "Form_f_FlexSearchDLG_Sub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "検索実行ﾘｽﾄ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Del As System.Windows.Forms.Button
    Friend WithEvents cmd_UP As System.Windows.Forms.Button
    Friend WithEvents cmd_DOWN As System.Windows.Forms.Button
    Friend WithEvents cmd_Henkou As System.Windows.Forms.Button
    Friend WithEvents txt_FldNmJPN As System.Windows.Forms.TextBox
    Friend WithEvents txt_Jouken As System.Windows.Forms.TextBox
    Friend WithEvents txt_Ketugou As System.Windows.Forms.TextBox
    Friend WithEvents txt_SearchNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_FldNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_4 As System.Windows.Forms.Label
    Friend WithEvents lbl_1 As System.Windows.Forms.Label

End Class