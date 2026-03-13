<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_計上仕訳_MARUZEN_SUB

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
        Me.txt_ZRITU = New System.Windows.Forms.TextBox()
        Me.txt_ZEI_KBN = New System.Windows.Forms.TextBox()
        Me.テキスト48 = New System.Windows.Forms.Label()
        Me.テキスト63 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' txt_ZRITU
        '
        Me.txt_ZRITU.Location = New System.Drawing.Point(3, 0)
        Me.txt_ZRITU.Name = "txt_ZRITU"
        Me.txt_ZRITU.Size = New System.Drawing.Size(83, 19)
        Me.txt_ZRITU.TabIndex = 0
        '
        ' txt_ZEI_KBN
        '
        Me.txt_ZEI_KBN.Location = New System.Drawing.Point(86, 0)
        Me.txt_ZEI_KBN.Name = "txt_ZEI_KBN"
        Me.txt_ZEI_KBN.Size = New System.Drawing.Size(83, 19)
        Me.txt_ZEI_KBN.TabIndex = 1
        '
        ' テキスト48
        '
        Me.テキスト48.AutoSize = True
        Me.テキスト48.Location = New System.Drawing.Point(3, 0)
        Me.テキスト48.Name = "テキスト48"
        Me.テキスト48.TabIndex = 2
        Me.テキスト48.Text = "消費税率"
        '
        ' テキスト63
        '
        Me.テキスト63.AutoSize = True
        Me.テキスト63.Location = New System.Drawing.Point(86, 0)
        Me.テキスト63.Name = "テキスト63"
        Me.テキスト63.TabIndex = 3
        Me.テキスト63.Text = "税率区分"
        '
        ' Form_fc_計上仕訳_MARUZEN_SUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.Controls.Add(Me.テキスト48)
        Me.Controls.Add(Me.テキスト63)
        Me.Controls.Add(Me.txt_ZRITU)
        Me.Controls.Add(Me.txt_ZEI_KBN)
        Me.Name = "Form_fc_計上仕訳_MARUZEN_SUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "消費税率"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ZRITU As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZEI_KBN As System.Windows.Forms.TextBox
    Friend WithEvents テキスト48 As System.Windows.Forms.Label
    Friend WithEvents テキスト63 As System.Windows.Forms.Label

End Class