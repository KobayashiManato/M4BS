<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_経費仕訳_NIFS

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
        Me.txt_部署コード_一括 = New System.Windows.Forms.TextBox()
        Me.txt_長期前払費用 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FPATH = New System.Windows.Forms.TextBox()
        Me.txt_販管費リース料 = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_03 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_SLIP_DT = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_出力元の抽出 = New System.Windows.Forms.Label()
        Me.lbl_検索条件加味F = New System.Windows.Forms.Label()
        Me.ラベル51 = New System.Windows.Forms.Label()
        Me.lbl_未払費用 = New System.Windows.Forms.Label()
        Me.ラベル68 = New System.Windows.Forms.Label()
        Me.lbl_OUTPUT_FPATH = New System.Windows.Forms.Label()
        Me.ラベル62 = New System.Windows.Forms.Label()
        Me.ラベル63 = New System.Windows.Forms.Label()
        Me.ラベル65 = New System.Windows.Forms.Label()
        Me.ラベル67 = New System.Windows.Forms.Label()
        Me.ラベル69 = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_03 = New System.Windows.Forms.Label()
        Me.chk_検索条件加味F = New System.Windows.Forms.CheckBox()
        Me.chk_長期 = New System.Windows.Forms.CheckBox()
        Me.chk_販管費 = New System.Windows.Forms.CheckBox()
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
        Me.cmd_選択.Location = New System.Drawing.Point(510, 344)
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
        ' txt_部署コード_一括
        '
        Me.txt_部署コード_一括.Location = New System.Drawing.Point(132, 158)
        Me.txt_部署コード_一括.Name = "txt_部署コード_一括"
        Me.txt_部署コード_一括.Size = New System.Drawing.Size(90, 19)
        Me.txt_部署コード_一括.TabIndex = 4
        '
        ' txt_長期前払費用
        '
        Me.txt_長期前払費用.Location = New System.Drawing.Point(241, 188)
        Me.txt_長期前払費用.Name = "txt_長期前払費用"
        Me.txt_長期前払費用.Size = New System.Drawing.Size(94, 19)
        Me.txt_長期前払費用.TabIndex = 5
        '
        ' txt_OUTPUT_FPATH
        '
        Me.txt_OUTPUT_FPATH.Location = New System.Drawing.Point(132, 343)
        Me.txt_OUTPUT_FPATH.Name = "txt_OUTPUT_FPATH"
        Me.txt_OUTPUT_FPATH.Size = New System.Drawing.Size(378, 19)
        Me.txt_OUTPUT_FPATH.TabIndex = 6
        '
        ' txt_販管費リース料
        '
        Me.txt_販管費リース料.Location = New System.Drawing.Point(241, 207)
        Me.txt_販管費リース料.Name = "txt_販管費リース料"
        Me.txt_販管費リース料.Size = New System.Drawing.Size(94, 19)
        Me.txt_販管費リース料.TabIndex = 7
        '
        ' txt_KAMOKU_CD_03
        '
        Me.txt_KAMOKU_CD_03.Location = New System.Drawing.Point(241, 226)
        Me.txt_KAMOKU_CD_03.Name = "txt_KAMOKU_CD_03"
        Me.txt_KAMOKU_CD_03.Size = New System.Drawing.Size(94, 19)
        Me.txt_KAMOKU_CD_03.TabIndex = 8
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(124, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 9
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_SLIP_DT
        '
        Me.lbl_SLIP_DT.AutoSize = True
        Me.lbl_SLIP_DT.Location = New System.Drawing.Point(26, 45)
        Me.lbl_SLIP_DT.Name = "lbl_SLIP_DT"
        Me.lbl_SLIP_DT.TabIndex = 10
        Me.lbl_SLIP_DT.Text = "対象月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(124, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 11
        Me.lbl_EXPLANATION1.Text = "※経費明細表ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_出力元の抽出
        '
        Me.lbl_出力元の抽出.AutoSize = True
        Me.lbl_出力元の抽出.Location = New System.Drawing.Point(26, 75)
        Me.lbl_出力元の抽出.Name = "lbl_出力元の抽出"
        Me.lbl_出力元の抽出.TabIndex = 12
        Me.lbl_出力元の抽出.Text = "出力元の抽出"
        '
        ' lbl_検索条件加味F
        '
        Me.lbl_検索条件加味F.AutoSize = True
        Me.lbl_検索条件加味F.Location = New System.Drawing.Point(170, 75)
        Me.lbl_検索条件加味F.Name = "lbl_検索条件加味F"
        Me.lbl_検索条件加味F.TabIndex = 13
        Me.lbl_検索条件加味F.Text = "検索条件を加味する"
        '
        ' ラベル51
        '
        Me.ラベル51.AutoSize = True
        Me.ラベル51.Location = New System.Drawing.Point(22, 158)
        Me.ラベル51.Name = "ラベル51"
        Me.ラベル51.TabIndex = 14
        Me.ラベル51.Text = "部署ｺｰﾄﾞ(一括)"
        '
        ' lbl_未払費用
        '
        Me.lbl_未払費用.AutoSize = True
        Me.lbl_未払費用.Location = New System.Drawing.Point(22, 188)
        Me.lbl_未払費用.Name = "lbl_未払費用"
        Me.lbl_未払費用.TabIndex = 15
        Me.lbl_未払費用.Text = "科目ｺｰﾄﾞ"
        '
        ' ラベル68
        '
        Me.ラベル68.AutoSize = True
        Me.ラベル68.Location = New System.Drawing.Point(22, 279)
        Me.ラベル68.Name = "ラベル68"
        Me.ラベル68.TabIndex = 16
        Me.ラベル68.Text = "通常ﾘｰｽ"
        '
        ' lbl_OUTPUT_FPATH
        '
        Me.lbl_OUTPUT_FPATH.AutoSize = True
        Me.lbl_OUTPUT_FPATH.Location = New System.Drawing.Point(22, 343)
        Me.lbl_OUTPUT_FPATH.Name = "lbl_OUTPUT_FPATH"
        Me.lbl_OUTPUT_FPATH.TabIndex = 17
        Me.lbl_OUTPUT_FPATH.Text = "出力先ﾌｧｲﾙ名"
        '
        ' ラベル62
        '
        Me.ラベル62.AutoSize = True
        Me.ラベル62.Location = New System.Drawing.Point(132, 188)
        Me.ラベル62.Name = "ラベル62"
        Me.ラベル62.TabIndex = 18
        Me.ラベル62.Text = "長期前払費用(ﾘｰｽ)"
        '
        ' ラベル63
        '
        Me.ラベル63.AutoSize = True
        Me.ラベル63.Location = New System.Drawing.Point(132, 207)
        Me.ラベル63.Name = "ラベル63"
        Me.ラベル63.TabIndex = 19
        Me.ラベル63.Text = "販管費ﾘｰｽ料"
        '
        ' ラベル65
        '
        Me.ラベル65.AutoSize = True
        Me.ラベル65.Location = New System.Drawing.Point(22, 257)
        Me.ラベル65.Name = "ラベル65"
        Me.ラベル65.TabIndex = 20
        Me.ラベル65.Text = "出力対象仕訳"
        '
        ' ラベル67
        '
        Me.ラベル67.AutoSize = True
        Me.ラベル67.Location = New System.Drawing.Point(170, 283)
        Me.ラベル67.Name = "ラベル67"
        Me.ラベル67.TabIndex = 21
        Me.ラベル67.Text = "月次入力(長期前払費用→販管費ﾘｰｽ料)"
        '
        ' ラベル69
        '
        Me.ラベル69.AutoSize = True
        Me.ラベル69.Location = New System.Drawing.Point(170, 302)
        Me.ラベル69.Name = "ラベル69"
        Me.ラベル69.TabIndex = 22
        Me.ラベル69.Text = "月次入力(販管費ﾘｰｽ料→本来のﾘｰｽ料)"
        '
        ' lbl_KAMOKU_CD_03
        '
        Me.lbl_KAMOKU_CD_03.AutoSize = True
        Me.lbl_KAMOKU_CD_03.Location = New System.Drawing.Point(132, 226)
        Me.lbl_KAMOKU_CD_03.Name = "lbl_KAMOKU_CD_03"
        Me.lbl_KAMOKU_CD_03.TabIndex = 23
        Me.lbl_KAMOKU_CD_03.Text = "転ﾘｰｽ原価"
        '
        ' chk_検索条件加味F
        '
        Me.chk_検索条件加味F.AutoSize = True
        Me.chk_検索条件加味F.Location = New System.Drawing.Point(154, 79)
        Me.chk_検索条件加味F.Name = "chk_検索条件加味F"
        Me.chk_検索条件加味F.TabIndex = 24
        Me.chk_検索条件加味F.Text = ""
        Me.chk_検索条件加味F.UseVisualStyleBackColor = True
        '
        ' chk_長期
        '
        Me.chk_長期.AutoSize = True
        Me.chk_長期.Location = New System.Drawing.Point(154, 287)
        Me.chk_長期.Name = "chk_長期"
        Me.chk_長期.TabIndex = 25
        Me.chk_長期.Text = ""
        Me.chk_長期.UseVisualStyleBackColor = True
        '
        ' chk_販管費
        '
        Me.chk_販管費.AutoSize = True
        Me.chk_販管費.Location = New System.Drawing.Point(154, 306)
        Me.chk_販管費.Name = "chk_販管費"
        Me.chk_販管費.TabIndex = 26
        Me.chk_販管費.Text = ""
        Me.chk_販管費.UseVisualStyleBackColor = True
        '
        ' Form_fc_経費仕訳_NIFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 527)
        Me.Controls.Add(Me.chk_検索条件加味F)
        Me.Controls.Add(Me.chk_長期)
        Me.Controls.Add(Me.chk_販管費)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_SLIP_DT)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_出力元の抽出)
        Me.Controls.Add(Me.lbl_検索条件加味F)
        Me.Controls.Add(Me.ラベル51)
        Me.Controls.Add(Me.lbl_未払費用)
        Me.Controls.Add(Me.ラベル68)
        Me.Controls.Add(Me.lbl_OUTPUT_FPATH)
        Me.Controls.Add(Me.ラベル62)
        Me.Controls.Add(Me.ラベル63)
        Me.Controls.Add(Me.ラベル65)
        Me.Controls.Add(Me.ラベル67)
        Me.Controls.Add(Me.ラベル69)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_03)
        Me.Controls.Add(Me.txt_SLIP_DT)
        Me.Controls.Add(Me.txt_部署コード_一括)
        Me.Controls.Add(Me.txt_長期前払費用)
        Me.Controls.Add(Me.txt_OUTPUT_FPATH)
        Me.Controls.Add(Me.txt_販管費リース料)
        Me.Controls.Add(Me.txt_KAMOKU_CD_03)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_経費仕訳_NIFS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "経費明細表 － 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_SLIP_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_部署コード_一括 As System.Windows.Forms.TextBox
    Friend WithEvents txt_長期前払費用 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FPATH As System.Windows.Forms.TextBox
    Friend WithEvents txt_販管費リース料 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_03 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_SLIP_DT As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力元の抽出 As System.Windows.Forms.Label
    Friend WithEvents lbl_検索条件加味F As System.Windows.Forms.Label
    Friend WithEvents ラベル51 As System.Windows.Forms.Label
    Friend WithEvents lbl_未払費用 As System.Windows.Forms.Label
    Friend WithEvents ラベル68 As System.Windows.Forms.Label
    Friend WithEvents lbl_OUTPUT_FPATH As System.Windows.Forms.Label
    Friend WithEvents ラベル62 As System.Windows.Forms.Label
    Friend WithEvents ラベル63 As System.Windows.Forms.Label
    Friend WithEvents ラベル65 As System.Windows.Forms.Label
    Friend WithEvents ラベル67 As System.Windows.Forms.Label
    Friend WithEvents ラベル69 As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_03 As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_長期 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_販管費 As System.Windows.Forms.CheckBox

End Class