<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_SUB

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
        Me.契約管理単位CD = New System.Windows.Forms.TextBox()
        Me.契約管理単位 = New System.Windows.Forms.TextBox()
        Me.txt_現金預金科目 = New System.Windows.Forms.TextBox()
        Me.ラベル0 = New System.Windows.Forms.Label()
        Me.ラベル1 = New System.Windows.Forms.Label()
        Me.ラベル3 = New System.Windows.Forms.Label()
        Me.ラベル4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' 契約管理単位CD
        '
        Me.契約管理単位CD.Location = New System.Drawing.Point(3, 0)
        Me.契約管理単位CD.Name = "契約管理単位CD"
        Me.契約管理単位CD.Size = New System.Drawing.Size(94, 19)
        Me.契約管理単位CD.TabIndex = 0
        '
        ' 契約管理単位
        '
        Me.契約管理単位.Location = New System.Drawing.Point(98, 0)
        Me.契約管理単位.Name = "契約管理単位"
        Me.契約管理単位.Size = New System.Drawing.Size(151, 19)
        Me.契約管理単位.TabIndex = 1
        '
        ' txt_現金預金科目
        '
        Me.txt_現金預金科目.Location = New System.Drawing.Point(343, 0)
        Me.txt_現金預金科目.Name = "txt_現金預金科目"
        Me.txt_現金預金科目.Size = New System.Drawing.Size(151, 19)
        Me.txt_現金預金科目.TabIndex = 2
        '
        ' ラベル0
        '
        Me.ラベル0.AutoSize = True
        Me.ラベル0.Location = New System.Drawing.Point(3, 0)
        Me.ラベル0.Name = "ラベル0"
        Me.ラベル0.TabIndex = 3
        Me.ラベル0.Text = "契約管理単位CD"
        '
        ' ラベル1
        '
        Me.ラベル1.AutoSize = True
        Me.ラベル1.Location = New System.Drawing.Point(98, 0)
        Me.ラベル1.Name = "ラベル1"
        Me.ラベル1.TabIndex = 4
        Me.ラベル1.Text = "契約管理単位"
        '
        ' ラベル3
        '
        Me.ラベル3.AutoSize = True
        Me.ラベル3.Location = New System.Drawing.Point(249, 0)
        Me.ラベル3.Name = "ラベル3"
        Me.ラベル3.TabIndex = 5
        Me.ラベル3.Text = "預金科目CD"
        '
        ' ラベル4
        '
        Me.ラベル4.AutoSize = True
        Me.ラベル4.Location = New System.Drawing.Point(343, 0)
        Me.ラベル4.Name = "ラベル4"
        Me.ラベル4.TabIndex = 6
        Me.ラベル4.Text = "預金科目"
        '
        ' Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_SUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 393)
        Me.Controls.Add(Me.ラベル0)
        Me.Controls.Add(Me.ラベル1)
        Me.Controls.Add(Me.ラベル3)
        Me.Controls.Add(Me.ラベル4)
        Me.Controls.Add(Me.契約管理単位CD)
        Me.Controls.Add(Me.契約管理単位)
        Me.Controls.Add(Me.txt_現金預金科目)
        Me.Name = "Form_fc_SANKO_AIR_振替伝票_支払用_出力指示_SUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "契約管理単位CD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 契約管理単位CD As System.Windows.Forms.TextBox
    Friend WithEvents 契約管理単位 As System.Windows.Forms.TextBox
    Friend WithEvents txt_現金預金科目 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル0 As System.Windows.Forms.Label
    Friend WithEvents ラベル1 As System.Windows.Forms.Label
    Friend WithEvents ラベル3 As System.Windows.Forms.Label
    Friend WithEvents ラベル4 As System.Windows.Forms.Label

End Class