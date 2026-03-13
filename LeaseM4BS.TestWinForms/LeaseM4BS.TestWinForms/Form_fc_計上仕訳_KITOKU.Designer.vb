<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_計上仕訳_KITOKU

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
        Me.cmd_選択 = New System.Windows.Forms.Button()
        Me.txt_SLIP_DT = New System.Windows.Forms.TextBox()
        Me.txt_SLIP_NO_START_VAL = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FOLDER_NM = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FILE_NM = New System.Windows.Forms.TextBox()
        Me.lbl_SLIP_DT = New System.Windows.Forms.Label()
        Me.lbl_SLIP_NO_START_VAL = New System.Windows.Forms.Label()
        Me.lbl_OUTPUT_FOLDER_NM = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION3 = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION4 = New System.Windows.Forms.Label()
        Me.lbl_OUTPUT_FILE_NM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(3, 3)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(86, 3)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(480, 105)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 2
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_SLIP_DT
        '
        Me.txt_SLIP_DT.Location = New System.Drawing.Point(136, 45)
        Me.txt_SLIP_DT.Name = "txt_SLIP_DT"
        Me.txt_SLIP_DT.Size = New System.Drawing.Size(94, 19)
        Me.txt_SLIP_DT.TabIndex = 3
        '
        ' txt_SLIP_NO_START_VAL
        '
        Me.txt_SLIP_NO_START_VAL.Location = New System.Drawing.Point(136, 75)
        Me.txt_SLIP_NO_START_VAL.Name = "txt_SLIP_NO_START_VAL"
        Me.txt_SLIP_NO_START_VAL.Size = New System.Drawing.Size(94, 19)
        Me.txt_SLIP_NO_START_VAL.TabIndex = 4
        '
        ' txt_OUTPUT_FOLDER_NM
        '
        Me.txt_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(136, 105)
        Me.txt_OUTPUT_FOLDER_NM.Name = "txt_OUTPUT_FOLDER_NM"
        Me.txt_OUTPUT_FOLDER_NM.Size = New System.Drawing.Size(340, 19)
        Me.txt_OUTPUT_FOLDER_NM.TabIndex = 5
        '
        ' txt_OUTPUT_FILE_NM
        '
        Me.txt_OUTPUT_FILE_NM.Location = New System.Drawing.Point(283, 177)
        Me.txt_OUTPUT_FILE_NM.Name = "txt_OUTPUT_FILE_NM"
        Me.txt_OUTPUT_FILE_NM.Size = New System.Drawing.Size(132, 19)
        Me.txt_OUTPUT_FILE_NM.TabIndex = 6
        '
        ' lbl_SLIP_DT
        '
        Me.lbl_SLIP_DT.AutoSize = True
        Me.lbl_SLIP_DT.Location = New System.Drawing.Point(26, 45)
        Me.lbl_SLIP_DT.Name = "lbl_SLIP_DT"
        Me.lbl_SLIP_DT.TabIndex = 7
        Me.lbl_SLIP_DT.Text = "伝票日付"
        '
        ' lbl_SLIP_NO_START_VAL
        '
        Me.lbl_SLIP_NO_START_VAL.AutoSize = True
        Me.lbl_SLIP_NO_START_VAL.Location = New System.Drawing.Point(26, 75)
        Me.lbl_SLIP_NO_START_VAL.Name = "lbl_SLIP_NO_START_VAL"
        Me.lbl_SLIP_NO_START_VAL.TabIndex = 8
        Me.lbl_SLIP_NO_START_VAL.Text = "伝票番号開始値"
        '
        ' lbl_OUTPUT_FOLDER_NM
        '
        Me.lbl_OUTPUT_FOLDER_NM.AutoSize = True
        Me.lbl_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(26, 105)
        Me.lbl_OUTPUT_FOLDER_NM.Name = "lbl_OUTPUT_FOLDER_NM"
        Me.lbl_OUTPUT_FOLDER_NM.TabIndex = 9
        Me.lbl_OUTPUT_FOLDER_NM.Text = "出力先ﾌｫﾙﾀﾞ"
        '
        ' lbl_EXPLANATION3
        '
        Me.lbl_EXPLANATION3.AutoSize = True
        Me.lbl_EXPLANATION3.Location = New System.Drawing.Point(26, 139)
        Me.lbl_EXPLANATION3.Name = "lbl_EXPLANATION3"
        Me.lbl_EXPLANATION3.TabIndex = 10
        Me.lbl_EXPLANATION3.Text = "ﾌｧｲﾙ名"
        '
        ' lbl_EXPLANATION4
        '
        Me.lbl_EXPLANATION4.AutoSize = True
        Me.lbl_EXPLANATION4.Location = New System.Drawing.Point(75, 158)
        Me.lbl_EXPLANATION4.Name = "lbl_EXPLANATION4"
        Me.lbl_EXPLANATION4.TabIndex = 11
        Me.lbl_EXPLANATION4.Text = "CORE"
        '
        ' lbl_OUTPUT_FILE_NM
        '
        Me.lbl_OUTPUT_FILE_NM.AutoSize = True
        Me.lbl_OUTPUT_FILE_NM.Location = New System.Drawing.Point(75, 177)
        Me.lbl_OUTPUT_FILE_NM.Name = "lbl_OUTPUT_FILE_NM"
        Me.lbl_OUTPUT_FILE_NM.TabIndex = 12
        Me.lbl_OUTPUT_FILE_NM.Text = "その他システム用仕訳ワーク"
        '
        ' Form_fc_計上仕訳_KITOKU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 245)
        Me.Controls.Add(Me.lbl_SLIP_DT)
        Me.Controls.Add(Me.lbl_SLIP_NO_START_VAL)
        Me.Controls.Add(Me.lbl_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.lbl_EXPLANATION3)
        Me.Controls.Add(Me.lbl_EXPLANATION4)
        Me.Controls.Add(Me.lbl_OUTPUT_FILE_NM)
        Me.Controls.Add(Me.txt_SLIP_DT)
        Me.Controls.Add(Me.txt_SLIP_NO_START_VAL)
        Me.Controls.Add(Me.txt_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.txt_OUTPUT_FILE_NM)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_計上仕訳_KITOKU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "計上仕訳出力画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_SLIP_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_SLIP_NO_START_VAL As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FOLDER_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FILE_NM As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SLIP_DT As System.Windows.Forms.Label
    Friend WithEvents lbl_SLIP_NO_START_VAL As System.Windows.Forms.Label
    Friend WithEvents lbl_OUTPUT_FOLDER_NM As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION3 As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION4 As System.Windows.Forms.Label
    Friend WithEvents lbl_OUTPUT_FILE_NM As System.Windows.Forms.Label

End Class