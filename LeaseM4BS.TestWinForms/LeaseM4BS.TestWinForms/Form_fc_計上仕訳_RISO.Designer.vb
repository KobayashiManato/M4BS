<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_計上仕訳_RISO

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
        Me.txt_出力年月 = New System.Windows.Forms.TextBox()
        Me.txt_伝票日付 = New System.Windows.Forms.TextBox()
        Me.txt_部署コード_一括用 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_SLIP_DT = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_TITL = New System.Windows.Forms.Label()
        Me.ラベル22 = New System.Windows.Forms.Label()
        Me.ラベル49 = New System.Windows.Forms.Label()
        Me.ラベル51 = New System.Windows.Forms.Label()
        Me.chk_検索条件加味F = New System.Windows.Forms.CheckBox()
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
        ' txt_出力年月
        '
        Me.txt_出力年月.Location = New System.Drawing.Point(139, 45)
        Me.txt_出力年月.Name = "txt_出力年月"
        Me.txt_出力年月.Size = New System.Drawing.Size(78, 19)
        Me.txt_出力年月.TabIndex = 2
        '
        ' txt_伝票日付
        '
        Me.txt_伝票日付.Location = New System.Drawing.Point(139, 151)
        Me.txt_伝票日付.Name = "txt_伝票日付"
        Me.txt_伝票日付.Size = New System.Drawing.Size(90, 19)
        Me.txt_伝票日付.TabIndex = 3
        '
        ' txt_部署コード_一括用
        '
        Me.txt_部署コード_一括用.Location = New System.Drawing.Point(139, 185)
        Me.txt_部署コード_一括用.Name = "txt_部署コード_一括用"
        Me.txt_部署コード_一括用.Size = New System.Drawing.Size(90, 19)
        Me.txt_部署コード_一括用.TabIndex = 4
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(143, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 5
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_SLIP_DT
        '
        Me.lbl_SLIP_DT.AutoSize = True
        Me.lbl_SLIP_DT.Location = New System.Drawing.Point(26, 45)
        Me.lbl_SLIP_DT.Name = "lbl_SLIP_DT"
        Me.lbl_SLIP_DT.TabIndex = 6
        Me.lbl_SLIP_DT.Text = "出力年月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(143, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 7
        Me.lbl_EXPLANATION1.Text = "※月次仕訳計上ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_TITL
        '
        Me.lbl_TITL.AutoSize = True
        Me.lbl_TITL.Location = New System.Drawing.Point(26, 75)
        Me.lbl_TITL.Name = "lbl_TITL"
        Me.lbl_TITL.TabIndex = 8
        Me.lbl_TITL.Text = "出力元の抽出"
        '
        ' ラベル22
        '
        Me.ラベル22.AutoSize = True
        Me.ラベル22.Location = New System.Drawing.Point(181, 75)
        Me.ラベル22.Name = "ラベル22"
        Me.ラベル22.TabIndex = 9
        Me.ラベル22.Text = "検索条件を加味する"
        '
        ' ラベル49
        '
        Me.ラベル49.AutoSize = True
        Me.ラベル49.Location = New System.Drawing.Point(26, 151)
        Me.ラベル49.Name = "ラベル49"
        Me.ラベル49.TabIndex = 10
        Me.ラベル49.Text = "伝票日付"
        '
        ' ラベル51
        '
        Me.ラベル51.AutoSize = True
        Me.ラベル51.Location = New System.Drawing.Point(26, 185)
        Me.ラベル51.Name = "ラベル51"
        Me.ラベル51.TabIndex = 11
        Me.ラベル51.Text = "部署ｺｰﾄﾞ(一括用)"
        '
        ' chk_検索条件加味F
        '
        Me.chk_検索条件加味F.AutoSize = True
        Me.chk_検索条件加味F.Location = New System.Drawing.Point(166, 77)
        Me.chk_検索条件加味F.Name = "chk_検索条件加味F"
        Me.chk_検索条件加味F.TabIndex = 12
        Me.chk_検索条件加味F.Text = ""
        Me.chk_検索条件加味F.UseVisualStyleBackColor = True
        '
        ' Form_fc_計上仕訳_RISO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 253)
        Me.Controls.Add(Me.chk_検索条件加味F)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_SLIP_DT)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_TITL)
        Me.Controls.Add(Me.ラベル22)
        Me.Controls.Add(Me.ラベル49)
        Me.Controls.Add(Me.ラベル51)
        Me.Controls.Add(Me.txt_出力年月)
        Me.Controls.Add(Me.txt_伝票日付)
        Me.Controls.Add(Me.txt_部署コード_一括用)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_fc_計上仕訳_RISO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次仕訳計上ﾌﾚｯｸｽ - 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_出力年月 As System.Windows.Forms.TextBox
    Friend WithEvents txt_伝票日付 As System.Windows.Forms.TextBox
    Friend WithEvents txt_部署コード_一括用 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_SLIP_DT As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_TITL As System.Windows.Forms.Label
    Friend WithEvents ラベル22 As System.Windows.Forms.Label
    Friend WithEvents ラベル49 As System.Windows.Forms.Label
    Friend WithEvents ラベル51 As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味F As System.Windows.Forms.CheckBox

End Class