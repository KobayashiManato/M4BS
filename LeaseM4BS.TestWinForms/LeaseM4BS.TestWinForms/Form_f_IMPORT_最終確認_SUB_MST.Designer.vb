<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_IMPORT_最終確認_SUB_MST

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
        Me.txt_TBLNMJPN = New System.Windows.Forms.TextBox()
        Me.txt_CD = New System.Windows.Forms.TextBox()
        Me.txt_NM = New System.Windows.Forms.TextBox()
        Me.ラベル694 = New System.Windows.Forms.Label()
        Me.ラベル697 = New System.Windows.Forms.Label()
        Me.ラベル766 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' txt_TBLNMJPN
        '
        Me.txt_TBLNMJPN.Location = New System.Drawing.Point(3, 0)
        Me.txt_TBLNMJPN.Name = "txt_TBLNMJPN"
        Me.txt_TBLNMJPN.Size = New System.Drawing.Size(151, 19)
        Me.txt_TBLNMJPN.TabIndex = 0
        '
        ' txt_CD
        '
        Me.txt_CD.Location = New System.Drawing.Point(154, 0)
        Me.txt_CD.Name = "txt_CD"
        Me.txt_CD.Size = New System.Drawing.Size(94, 19)
        Me.txt_CD.TabIndex = 1
        '
        ' txt_NM
        '
        Me.txt_NM.Location = New System.Drawing.Point(249, 0)
        Me.txt_NM.Name = "txt_NM"
        Me.txt_NM.Size = New System.Drawing.Size(189, 19)
        Me.txt_NM.TabIndex = 2
        '
        ' ラベル694
        '
        Me.ラベル694.AutoSize = True
        Me.ラベル694.Location = New System.Drawing.Point(3, 0)
        Me.ラベル694.Name = "ラベル694"
        Me.ラベル694.TabIndex = 3
        Me.ラベル694.Text = "マスタ名"
        '
        ' ラベル697
        '
        Me.ラベル697.AutoSize = True
        Me.ラベル697.Location = New System.Drawing.Point(154, 0)
        Me.ラベル697.Name = "ラベル697"
        Me.ラベル697.TabIndex = 4
        Me.ラベル697.Text = "コード"
        '
        ' ラベル766
        '
        Me.ラベル766.AutoSize = True
        Me.ラベル766.Location = New System.Drawing.Point(249, 0)
        Me.ラベル766.Name = "ラベル766"
        Me.ラベル766.TabIndex = 5
        Me.ラベル766.Text = "名称"
        '
        ' Form_f_IMPORT_最終確認_SUB_MST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 400)
        Me.Controls.Add(Me.ラベル694)
        Me.Controls.Add(Me.ラベル697)
        Me.Controls.Add(Me.ラベル766)
        Me.Controls.Add(Me.txt_TBLNMJPN)
        Me.Controls.Add(Me.txt_CD)
        Me.Controls.Add(Me.txt_NM)
        Me.Name = "Form_f_IMPORT_最終確認_SUB_MST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Excel取り込み 本登録ログ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_TBLNMJPN As System.Windows.Forms.TextBox
    Friend WithEvents txt_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_NM As System.Windows.Forms.TextBox
    Friend WithEvents ラベル694 As System.Windows.Forms.Label
    Friend WithEvents ラベル697 As System.Windows.Forms.Label
    Friend WithEvents ラベル766 As System.Windows.Forms.Label

End Class