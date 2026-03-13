<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_支払仕訳_KYOTO

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
        Me.txt_YMD_01 = New System.Windows.Forms.TextBox()
        Me.txt_TEXT_01 = New System.Windows.Forms.TextBox()
        Me.txt_YMD_02 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_YMD_01 = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_出力元の抽出 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01 = New System.Windows.Forms.Label()
        Me.lbl_出力ﾌｧｲﾙ名 = New System.Windows.Forms.Label()
        Me.lbl_YMD_02 = New System.Windows.Forms.Label()
        Me.chk_CHK_01 = New System.Windows.Forms.CheckBox()
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
        Me.cmd_選択.Location = New System.Drawing.Point(502, 181)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 2
        Me.cmd_選択.Text = "選択(&S)"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_YMD_01
        '
        Me.txt_YMD_01.Location = New System.Drawing.Point(139, 45)
        Me.txt_YMD_01.Name = "txt_YMD_01"
        Me.txt_YMD_01.Size = New System.Drawing.Size(79, 19)
        Me.txt_YMD_01.TabIndex = 3
        '
        ' txt_TEXT_01
        '
        Me.txt_TEXT_01.Location = New System.Drawing.Point(139, 181)
        Me.txt_TEXT_01.Name = "txt_TEXT_01"
        Me.txt_TEXT_01.Size = New System.Drawing.Size(359, 19)
        Me.txt_TEXT_01.TabIndex = 4
        '
        ' txt_YMD_02
        '
        Me.txt_YMD_02.Location = New System.Drawing.Point(139, 151)
        Me.txt_YMD_02.Name = "txt_YMD_02"
        Me.txt_YMD_02.Size = New System.Drawing.Size(90, 19)
        Me.txt_YMD_02.TabIndex = 5
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(143, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 6
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_YMD_01
        '
        Me.lbl_YMD_01.AutoSize = True
        Me.lbl_YMD_01.Location = New System.Drawing.Point(26, 45)
        Me.lbl_YMD_01.Name = "lbl_YMD_01"
        Me.lbl_YMD_01.TabIndex = 7
        Me.lbl_YMD_01.Text = "対象月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(143, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 8
        Me.lbl_EXPLANATION1.Text = "※月次支払照合ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_出力元の抽出
        '
        Me.lbl_出力元の抽出.AutoSize = True
        Me.lbl_出力元の抽出.Location = New System.Drawing.Point(26, 75)
        Me.lbl_出力元の抽出.Name = "lbl_出力元の抽出"
        Me.lbl_出力元の抽出.TabIndex = 9
        Me.lbl_出力元の抽出.Text = "出力元の抽出"
        '
        ' lbl_CHK_01
        '
        Me.lbl_CHK_01.AutoSize = True
        Me.lbl_CHK_01.Location = New System.Drawing.Point(181, 75)
        Me.lbl_CHK_01.Name = "lbl_CHK_01"
        Me.lbl_CHK_01.TabIndex = 10
        Me.lbl_CHK_01.Text = "検索条件を加味する"
        '
        ' lbl_出力ﾌｧｲﾙ名
        '
        Me.lbl_出力ﾌｧｲﾙ名.AutoSize = True
        Me.lbl_出力ﾌｧｲﾙ名.Location = New System.Drawing.Point(26, 181)
        Me.lbl_出力ﾌｧｲﾙ名.Name = "lbl_出力ﾌｧｲﾙ名"
        Me.lbl_出力ﾌｧｲﾙ名.TabIndex = 11
        Me.lbl_出力ﾌｧｲﾙ名.Text = "出力ﾌｧｲﾙ名"
        '
        ' lbl_YMD_02
        '
        Me.lbl_YMD_02.AutoSize = True
        Me.lbl_YMD_02.Location = New System.Drawing.Point(26, 151)
        Me.lbl_YMD_02.Name = "lbl_YMD_02"
        Me.lbl_YMD_02.TabIndex = 12
        Me.lbl_YMD_02.Text = "処理日付"
        '
        ' chk_CHK_01
        '
        Me.chk_CHK_01.AutoSize = True
        Me.chk_CHK_01.Location = New System.Drawing.Point(166, 75)
        Me.chk_CHK_01.Name = "chk_CHK_01"
        Me.chk_CHK_01.TabIndex = 13
        Me.chk_CHK_01.Text = ""
        Me.chk_CHK_01.UseVisualStyleBackColor = True
        '
        ' Form_fc_支払仕訳_KYOTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 249)
        Me.Controls.Add(Me.chk_CHK_01)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_YMD_01)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_出力元の抽出)
        Me.Controls.Add(Me.lbl_CHK_01)
        Me.Controls.Add(Me.lbl_出力ﾌｧｲﾙ名)
        Me.Controls.Add(Me.lbl_YMD_02)
        Me.Controls.Add(Me.txt_YMD_01)
        Me.Controls.Add(Me.txt_TEXT_01)
        Me.Controls.Add(Me.txt_YMD_02)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_支払仕訳_KYOTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次支払照合ﾌﾚｯｸｽ - 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_YMD_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TEXT_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_YMD_02 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_YMD_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力元の抽出 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力ﾌｧｲﾙ名 As System.Windows.Forms.Label
    Friend WithEvents lbl_YMD_02 As System.Windows.Forms.Label
    Friend WithEvents chk_CHK_01 As System.Windows.Forms.CheckBox

End Class