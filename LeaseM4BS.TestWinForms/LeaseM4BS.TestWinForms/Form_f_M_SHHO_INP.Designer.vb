<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_M_SHHO_INP

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
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.txt_SHHO_CD = New System.Windows.Forms.TextBox()
        Me.txt_SHHO_NM = New System.Windows.Forms.TextBox()
        Me.txt_BIKO = New System.Windows.Forms.TextBox()
        Me.txt_SHHO_ID = New System.Windows.Forms.TextBox()
        Me.txt_CREATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_UPDATE_DT = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル38 = New System.Windows.Forms.Label()
        Me.ラベル43 = New System.Windows.Forms.Label()
        Me.ラベル45 = New System.Windows.Forms.Label()
        Me.ラベル352 = New System.Windows.Forms.Label()
        Me.ラベル354 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 4
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(149, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CREATE.TabIndex = 3
        Me.cmd_CREATE.Text = "登録(&S)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmd_DELETE.Location = New System.Drawing.Point(284, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_DELETE.TabIndex = 2
        Me.cmd_DELETE.TabStop = False
        Me.cmd_DELETE.Text = "削除(&D)"
        Me.cmd_DELETE.UseVisualStyleBackColor = False
        '
        'txt_SHHO_CD
        '
        Me.txt_SHHO_CD.Location = New System.Drawing.Point(204, 98)
        Me.txt_SHHO_CD.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHHO_CD.Name = "txt_SHHO_CD"
        Me.txt_SHHO_CD.Size = New System.Drawing.Size(154, 25)
        Me.txt_SHHO_CD.TabIndex = 0
        '
        'txt_SHHO_NM
        '
        Me.txt_SHHO_NM.Location = New System.Drawing.Point(204, 138)
        Me.txt_SHHO_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHHO_NM.Name = "txt_SHHO_NM"
        Me.txt_SHHO_NM.Size = New System.Drawing.Size(437, 25)
        Me.txt_SHHO_NM.TabIndex = 1
        '
        'txt_BIKO
        '
        Me.txt_BIKO.Location = New System.Drawing.Point(204, 178)
        Me.txt_BIKO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.Size = New System.Drawing.Size(437, 25)
        Me.txt_BIKO.TabIndex = 2
        '
        'txt_SHHO_ID
        '
        Me.txt_SHHO_ID.Location = New System.Drawing.Point(621, 292)
        Me.txt_SHHO_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SHHO_ID.Name = "txt_SHHO_ID"
        Me.txt_SHHO_ID.ReadOnly = True
        Me.txt_SHHO_ID.Size = New System.Drawing.Size(122, 25)
        Me.txt_SHHO_ID.TabIndex = 7
        Me.txt_SHHO_ID.TabStop = False
        '
        'txt_CREATE_DT
        '
        Me.txt_CREATE_DT.Location = New System.Drawing.Point(621, 234)
        Me.txt_CREATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_CREATE_DT.TabIndex = 8
        Me.txt_CREATE_DT.TabStop = False
        '
        'txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.Location = New System.Drawing.Point(621, 263)
        Me.txt_UPDATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_UPDATE_DT.TabIndex = 9
        Me.txt_UPDATE_DT.TabStop = False
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(16, 98)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(114, 18)
        Me.Lbl.TabIndex = 13
        Me.Lbl.Text = "支払方法ｺｰﾄﾞ"
        '
        'ラベル38
        '
        Me.ラベル38.AutoSize = True
        Me.ラベル38.Location = New System.Drawing.Point(16, 138)
        Me.ラベル38.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル38.Name = "ラベル38"
        Me.ラベル38.Size = New System.Drawing.Size(98, 18)
        Me.ラベル38.TabIndex = 14
        Me.ラベル38.Text = "支払方法名"
        '
        'ラベル43
        '
        Me.ラベル43.AutoSize = True
        Me.ラベル43.Location = New System.Drawing.Point(16, 178)
        Me.ラベル43.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル43.Name = "ラベル43"
        Me.ラベル43.Size = New System.Drawing.Size(44, 18)
        Me.ラベル43.TabIndex = 15
        Me.ラベル43.Text = "備考"
        '
        'ラベル45
        '
        Me.ラベル45.AutoSize = True
        Me.ラベル45.Location = New System.Drawing.Point(462, 292)
        Me.ラベル45.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル45.Name = "ラベル45"
        Me.ラベル45.Size = New System.Drawing.Size(24, 18)
        Me.ラベル45.TabIndex = 16
        Me.ラベル45.Text = "ID"
        '
        'ラベル352
        '
        Me.ラベル352.AutoSize = True
        Me.ラベル352.Location = New System.Drawing.Point(462, 234)
        Me.ラベル352.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル352.Name = "ラベル352"
        Me.ラベル352.Size = New System.Drawing.Size(80, 18)
        Me.ラベル352.TabIndex = 17
        Me.ラベル352.Text = "作成日時"
        '
        'ラベル354
        '
        Me.ラベル354.AutoSize = True
        Me.ラベル354.Location = New System.Drawing.Point(462, 263)
        Me.ラベル354.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル354.Name = "ラベル354"
        Me.ラベル354.Size = New System.Drawing.Size(80, 18)
        Me.ラベル354.TabIndex = 18
        Me.ラベル354.Text = "更新日時"
        '
        'Form_f_M_SHHO_INP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 372)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル38)
        Me.Controls.Add(Me.ラベル43)
        Me.Controls.Add(Me.ラベル45)
        Me.Controls.Add(Me.ラベル352)
        Me.Controls.Add(Me.ラベル354)
        Me.Controls.Add(Me.txt_SHHO_CD)
        Me.Controls.Add(Me.txt_SHHO_NM)
        Me.Controls.Add(Me.txt_BIKO)
        Me.Controls.Add(Me.txt_SHHO_ID)
        Me.Controls.Add(Me.txt_CREATE_DT)
        Me.Controls.Add(Me.txt_UPDATE_DT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_DELETE)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_f_M_SHHO_INP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "支払方法マスタ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_CREATE As System.Windows.Forms.Button
    Friend WithEvents cmd_DELETE As System.Windows.Forms.Button
    Friend WithEvents txt_SHHO_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_SHHO_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_BIKO As System.Windows.Forms.TextBox
    Friend WithEvents txt_SHHO_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_CREATE_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_UPDATE_DT As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル38 As System.Windows.Forms.Label
    Friend WithEvents ラベル43 As System.Windows.Forms.Label
    Friend WithEvents ラベル45 As System.Windows.Forms.Label
    Friend WithEvents ラベル352 As System.Windows.Forms.Label
    Friend WithEvents ラベル354 As System.Windows.Forms.Label

End Class