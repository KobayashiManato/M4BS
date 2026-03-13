<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_0開発ツール

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
        Me.cmd_1PSCtl_Evt設定 = New System.Windows.Forms.Button()
        Me.txt_FormNm = New System.Windows.Forms.TextBox()
        Me.txt_FlexListNm = New System.Windows.Forms.TextBox()
        Me.ラベル29 = New System.Windows.Forms.Label()
        Me.ラベル2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_1PSCtl_Evt設定
        '
        Me.cmd_1PSCtl_Evt設定.Location = New System.Drawing.Point(226, 90)
        Me.cmd_1PSCtl_Evt設定.Name = "cmd_1PSCtl_Evt設定"
        Me.cmd_1PSCtl_Evt設定.Size = New System.Drawing.Size(265, 37)
        Me.cmd_1PSCtl_Evt設定.TabIndex = 0
        Me.cmd_1PSCtl_Evt設定.Text = "ワンプッシュソートイベントプロパティ設定"
        Me.cmd_1PSCtl_Evt設定.UseVisualStyleBackColor = True
        '
        ' txt_FormNm
        '
        Me.txt_FormNm.Location = New System.Drawing.Point(264, 56)
        Me.txt_FormNm.Name = "txt_FormNm"
        Me.txt_FormNm.Size = New System.Drawing.Size(226, 19)
        Me.txt_FormNm.TabIndex = 1
        '
        ' txt_FlexListNm
        '
        Me.txt_FlexListNm.Location = New System.Drawing.Point(264, 37)
        Me.txt_FlexListNm.Name = "txt_FlexListNm"
        Me.txt_FlexListNm.Size = New System.Drawing.Size(226, 19)
        Me.txt_FlexListNm.TabIndex = 2
        '
        ' ラベル29
        '
        Me.ラベル29.AutoSize = True
        Me.ラベル29.Location = New System.Drawing.Point(37, 56)
        Me.ラベル29.Name = "ラベル29"
        Me.ラベル29.TabIndex = 3
        Me.ラベル29.Text = "フォーム名"
        '
        ' ラベル2
        '
        Me.ラベル2.AutoSize = True
        Me.ラベル2.Location = New System.Drawing.Point(37, 37)
        Me.ラベル2.Name = "ラベル2"
        Me.ラベル2.TabIndex = 4
        Me.ラベル2.Text = "ﾌﾚｯｸｽﾘｽﾄNo"
        '
        ' Form_f_0開発ツール
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 200)
        Me.Controls.Add(Me.ラベル29)
        Me.Controls.Add(Me.ラベル2)
        Me.Controls.Add(Me.txt_FormNm)
        Me.Controls.Add(Me.txt_FlexListNm)
        Me.Controls.Add(Me.cmd_1PSCtl_Evt設定)
        Me.Name = "Form_f_0開発ツール"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ワンプッシュソートイベントプロパティ設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_1PSCtl_Evt設定 As System.Windows.Forms.Button
    Friend WithEvents txt_FormNm As System.Windows.Forms.TextBox
    Friend WithEvents txt_FlexListNm As System.Windows.Forms.TextBox
    Friend WithEvents ラベル29 As System.Windows.Forms.Label
    Friend WithEvents ラベル2 As System.Windows.Forms.Label

End Class