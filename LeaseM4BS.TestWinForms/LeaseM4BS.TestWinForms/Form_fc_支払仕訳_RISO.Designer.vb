<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_支払仕訳_RISO

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
        Me.cmd_支払日確認 = New System.Windows.Forms.Button()
        Me.cmd_振込 = New System.Windows.Forms.Button()
        Me.cmd_選択 = New System.Windows.Forms.Button()
        Me.txt_SLIP_DT = New System.Windows.Forms.TextBox()
        Me.txt_未払費用 = New System.Windows.Forms.TextBox()
        Me.txt_伝票日付 = New System.Windows.Forms.TextBox()
        Me.txt_部署コード = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FPATH = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_SLIP_DT = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_出力元の抽出 = New System.Windows.Forms.Label()
        Me.lbl_検索条件加味F = New System.Windows.Forms.Label()
        Me.lbl_伝票日付 = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION3 = New System.Windows.Forms.Label()
        Me.lbl_部署ｺｰﾄﾞ = New System.Windows.Forms.Label()
        Me.lbl_未払費用 = New System.Windows.Forms.Label()
        Me.ラベル68 = New System.Windows.Forms.Label()
        Me.lbl_OUTPUT_FPATH = New System.Windows.Forms.Label()
        Me.chk_検索条件加味F = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(3, 3)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(94, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "仕訳ﾃﾞｰﾀ出力"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(207, 3)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_支払日確認
        '
        Me.cmd_支払日確認.Location = New System.Drawing.Point(385, 3)
        Me.cmd_支払日確認.Name = "cmd_支払日確認"
        Me.cmd_支払日確認.Size = New System.Drawing.Size(86, 26)
        Me.cmd_支払日確認.TabIndex = 2
        Me.cmd_支払日確認.Text = "支払日確認"
        Me.cmd_支払日確認.UseVisualStyleBackColor = True
        '
        ' cmd_振込
        '
        Me.cmd_振込.Location = New System.Drawing.Point(105, 3)
        Me.cmd_振込.Name = "cmd_振込"
        Me.cmd_振込.Size = New System.Drawing.Size(94, 26)
        Me.cmd_振込.TabIndex = 3
        Me.cmd_振込.Text = "振込ﾃﾞｰﾀ出力"
        Me.cmd_振込.UseVisualStyleBackColor = True
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(461, 287)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 4
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_SLIP_DT
        '
        Me.txt_SLIP_DT.Location = New System.Drawing.Point(136, 45)
        Me.txt_SLIP_DT.Name = "txt_SLIP_DT"
        Me.txt_SLIP_DT.Size = New System.Drawing.Size(94, 19)
        Me.txt_SLIP_DT.TabIndex = 5
        '
        ' txt_未払費用
        '
        Me.txt_未払費用.Location = New System.Drawing.Point(136, 238)
        Me.txt_未払費用.Name = "txt_未払費用"
        Me.txt_未払費用.Size = New System.Drawing.Size(94, 19)
        Me.txt_未払費用.TabIndex = 6
        '
        ' txt_伝票日付
        '
        Me.txt_伝票日付.Location = New System.Drawing.Point(136, 151)
        Me.txt_伝票日付.Name = "txt_伝票日付"
        Me.txt_伝票日付.Size = New System.Drawing.Size(94, 19)
        Me.txt_伝票日付.TabIndex = 7
        '
        ' txt_部署コード
        '
        Me.txt_部署コード.Location = New System.Drawing.Point(136, 207)
        Me.txt_部署コード.Name = "txt_部署コード"
        Me.txt_部署コード.Size = New System.Drawing.Size(94, 19)
        Me.txt_部署コード.TabIndex = 8
        '
        ' txt_OUTPUT_FPATH
        '
        Me.txt_OUTPUT_FPATH.Location = New System.Drawing.Point(136, 287)
        Me.txt_OUTPUT_FPATH.Name = "txt_OUTPUT_FPATH"
        Me.txt_OUTPUT_FPATH.Size = New System.Drawing.Size(321, 19)
        Me.txt_OUTPUT_FPATH.TabIndex = 9
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(136, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 10
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀ･振込ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_SLIP_DT
        '
        Me.lbl_SLIP_DT.AutoSize = True
        Me.lbl_SLIP_DT.Location = New System.Drawing.Point(26, 45)
        Me.lbl_SLIP_DT.Name = "lbl_SLIP_DT"
        Me.lbl_SLIP_DT.TabIndex = 11
        Me.lbl_SLIP_DT.Text = "処理年月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(136, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 12
        Me.lbl_EXPLANATION1.Text = "※月次支払照合ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_出力元の抽出
        '
        Me.lbl_出力元の抽出.AutoSize = True
        Me.lbl_出力元の抽出.Location = New System.Drawing.Point(26, 75)
        Me.lbl_出力元の抽出.Name = "lbl_出力元の抽出"
        Me.lbl_出力元の抽出.TabIndex = 13
        Me.lbl_出力元の抽出.Text = "出力元の抽出"
        '
        ' lbl_検索条件加味F
        '
        Me.lbl_検索条件加味F.AutoSize = True
        Me.lbl_検索条件加味F.Location = New System.Drawing.Point(170, 75)
        Me.lbl_検索条件加味F.Name = "lbl_検索条件加味F"
        Me.lbl_検索条件加味F.TabIndex = 14
        Me.lbl_検索条件加味F.Text = "検索条件を加味する"
        '
        ' lbl_伝票日付
        '
        Me.lbl_伝票日付.AutoSize = True
        Me.lbl_伝票日付.Location = New System.Drawing.Point(26, 151)
        Me.lbl_伝票日付.Name = "lbl_伝票日付"
        Me.lbl_伝票日付.TabIndex = 15
        Me.lbl_伝票日付.Text = "伝票日付"
        '
        ' lbl_EXPLANATION3
        '
        Me.lbl_EXPLANATION3.AutoSize = True
        Me.lbl_EXPLANATION3.Location = New System.Drawing.Point(136, 177)
        Me.lbl_EXPLANATION3.Name = "lbl_EXPLANATION3"
        Me.lbl_EXPLANATION3.TabIndex = 16
        Me.lbl_EXPLANATION3.Text = "※未払計上時の伝票日付"
        '
        ' lbl_部署ｺｰﾄﾞ
        '
        Me.lbl_部署ｺｰﾄﾞ.AutoSize = True
        Me.lbl_部署ｺｰﾄﾞ.Location = New System.Drawing.Point(26, 207)
        Me.lbl_部署ｺｰﾄﾞ.Name = "lbl_部署ｺｰﾄﾞ"
        Me.lbl_部署ｺｰﾄﾞ.TabIndex = 17
        Me.lbl_部署ｺｰﾄﾞ.Text = "部署ｺｰﾄﾞ(一括用)"
        '
        ' lbl_未払費用
        '
        Me.lbl_未払費用.AutoSize = True
        Me.lbl_未払費用.Location = New System.Drawing.Point(26, 238)
        Me.lbl_未払費用.Name = "lbl_未払費用"
        Me.lbl_未払費用.TabIndex = 18
        Me.lbl_未払費用.Text = "科目ｺｰﾄﾞ(未払費用)"
        '
        ' ラベル68
        '
        Me.ラベル68.AutoSize = True
        Me.ラベル68.Location = New System.Drawing.Point(26, 268)
        Me.ラベル68.Name = "ラベル68"
        Me.ラベル68.TabIndex = 19
        Me.ラベル68.Text = "振込ﾃﾞｰﾀ特有情報"
        '
        ' lbl_OUTPUT_FPATH
        '
        Me.lbl_OUTPUT_FPATH.AutoSize = True
        Me.lbl_OUTPUT_FPATH.Location = New System.Drawing.Point(26, 287)
        Me.lbl_OUTPUT_FPATH.Name = "lbl_OUTPUT_FPATH"
        Me.lbl_OUTPUT_FPATH.TabIndex = 20
        Me.lbl_OUTPUT_FPATH.Text = "出力先ﾌｧｲﾙ名"
        '
        ' chk_検索条件加味F
        '
        Me.chk_検索条件加味F.AutoSize = True
        Me.chk_検索条件加味F.Location = New System.Drawing.Point(154, 79)
        Me.chk_検索条件加味F.Name = "chk_検索条件加味F"
        Me.chk_検索条件加味F.TabIndex = 21
        Me.chk_検索条件加味F.Text = ""
        Me.chk_検索条件加味F.UseVisualStyleBackColor = True
        '
        ' Form_fc_支払仕訳_RISO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 355)
        Me.Controls.Add(Me.chk_検索条件加味F)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_SLIP_DT)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_出力元の抽出)
        Me.Controls.Add(Me.lbl_検索条件加味F)
        Me.Controls.Add(Me.lbl_伝票日付)
        Me.Controls.Add(Me.lbl_EXPLANATION3)
        Me.Controls.Add(Me.lbl_部署ｺｰﾄﾞ)
        Me.Controls.Add(Me.lbl_未払費用)
        Me.Controls.Add(Me.ラベル68)
        Me.Controls.Add(Me.lbl_OUTPUT_FPATH)
        Me.Controls.Add(Me.txt_SLIP_DT)
        Me.Controls.Add(Me.txt_未払費用)
        Me.Controls.Add(Me.txt_伝票日付)
        Me.Controls.Add(Me.txt_部署コード)
        Me.Controls.Add(Me.txt_OUTPUT_FPATH)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_支払日確認)
        Me.Controls.Add(Me.cmd_振込)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_支払仕訳_RISO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次支払照合ﾌﾚｯｸｽ － 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_支払日確認 As System.Windows.Forms.Button
    Friend WithEvents cmd_振込 As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_SLIP_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払費用 As System.Windows.Forms.TextBox
    Friend WithEvents txt_伝票日付 As System.Windows.Forms.TextBox
    Friend WithEvents txt_部署コード As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FPATH As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_SLIP_DT As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力元の抽出 As System.Windows.Forms.Label
    Friend WithEvents lbl_検索条件加味F As System.Windows.Forms.Label
    Friend WithEvents lbl_伝票日付 As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION3 As System.Windows.Forms.Label
    Friend WithEvents lbl_部署ｺｰﾄﾞ As System.Windows.Forms.Label
    Friend WithEvents lbl_未払費用 As System.Windows.Forms.Label
    Friend WithEvents ラベル68 As System.Windows.Forms.Label
    Friend WithEvents lbl_OUTPUT_FPATH As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味F As System.Windows.Forms.CheckBox

End Class