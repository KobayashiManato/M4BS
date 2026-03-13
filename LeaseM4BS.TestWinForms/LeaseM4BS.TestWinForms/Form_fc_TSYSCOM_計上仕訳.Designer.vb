<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_TSYSCOM_計上仕訳

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
        Me.cmd_選択1 = New System.Windows.Forms.Button()
        Me.cmd_選択2 = New System.Windows.Forms.Button()
        Me.cmd_祝日 = New System.Windows.Forms.Button()
        Me.txt_YMD_01 = New System.Windows.Forms.TextBox()
        Me.txt_YMD_02 = New System.Windows.Forms.TextBox()
        Me.txt_TEXT_02 = New System.Windows.Forms.TextBox()
        Me.txt_TEXT_01 = New System.Windows.Forms.TextBox()
        Me.txt_BUMON_NM_01 = New System.Windows.Forms.TextBox()
        Me.txt_VAL_01 = New System.Windows.Forms.TextBox()
        Me.テキスト105 = New System.Windows.Forms.TextBox()
        Me.txt_BUMON_NM_02 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_YMD_01 = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01_F = New System.Windows.Forms.Label()
        Me.lbl_YMD_02 = New System.Windows.Forms.Label()
        Me.lbl_TEXT_02 = New System.Windows.Forms.Label()
        Me.lbl_TEXT_01 = New System.Windows.Forms.Label()
        Me.lbl_BUMON_CD_01 = New System.Windows.Forms.Label()
        Me.ラベル104 = New System.Windows.Forms.Label()
        Me.ラベル106 = New System.Windows.Forms.Label()
        Me.ラベル107 = New System.Windows.Forms.Label()
        Me.ラベル108 = New System.Windows.Forms.Label()
        Me.lbl_出力対象仕訳 = New System.Windows.Forms.Label()
        Me.ラベル110 = New System.Windows.Forms.Label()
        Me.ラベル111 = New System.Windows.Forms.Label()
        Me.ラベル112 = New System.Windows.Forms.Label()
        Me.ラベル113 = New System.Windows.Forms.Label()
        Me.ラベル114 = New System.Windows.Forms.Label()
        Me.ラベル115 = New System.Windows.Forms.Label()
        Me.ラベル124 = New System.Windows.Forms.Label()
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
        Me.cmd_CANCEL.Location = New System.Drawing.Point(83, 3)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_選択1
        '
        Me.cmd_選択1.Location = New System.Drawing.Point(529, 283)
        Me.cmd_選択1.Name = "cmd_選択1"
        Me.cmd_選択1.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択1.TabIndex = 2
        Me.cmd_選択1.Text = "選択"
        Me.cmd_選択1.UseVisualStyleBackColor = True
        '
        ' cmd_選択2
        '
        Me.cmd_選択2.Location = New System.Drawing.Point(529, 309)
        Me.cmd_選択2.Name = "cmd_選択2"
        Me.cmd_選択2.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択2.TabIndex = 3
        Me.cmd_選択2.Text = "選択"
        Me.cmd_選択2.UseVisualStyleBackColor = True
        '
        ' cmd_祝日
        '
        Me.cmd_祝日.Location = New System.Drawing.Point(196, 3)
        Me.cmd_祝日.Name = "cmd_祝日"
        Me.cmd_祝日.Size = New System.Drawing.Size(75, 26)
        Me.cmd_祝日.TabIndex = 4
        Me.cmd_祝日.Text = "祝日(&M)"
        Me.cmd_祝日.UseVisualStyleBackColor = True
        '
        ' txt_YMD_01
        '
        Me.txt_YMD_01.Location = New System.Drawing.Point(143, 45)
        Me.txt_YMD_01.Name = "txt_YMD_01"
        Me.txt_YMD_01.Size = New System.Drawing.Size(94, 19)
        Me.txt_YMD_01.TabIndex = 5
        '
        ' txt_YMD_02
        '
        Me.txt_YMD_02.Location = New System.Drawing.Point(143, 170)
        Me.txt_YMD_02.Name = "txt_YMD_02"
        Me.txt_YMD_02.Size = New System.Drawing.Size(94, 19)
        Me.txt_YMD_02.TabIndex = 6
        '
        ' txt_TEXT_02
        '
        Me.txt_TEXT_02.Location = New System.Drawing.Point(143, 309)
        Me.txt_TEXT_02.Name = "txt_TEXT_02"
        Me.txt_TEXT_02.Size = New System.Drawing.Size(377, 19)
        Me.txt_TEXT_02.TabIndex = 7
        '
        ' txt_TEXT_01
        '
        Me.txt_TEXT_01.Location = New System.Drawing.Point(143, 283)
        Me.txt_TEXT_01.Name = "txt_TEXT_01"
        Me.txt_TEXT_01.Size = New System.Drawing.Size(377, 19)
        Me.txt_TEXT_01.TabIndex = 8
        '
        ' txt_BUMON_NM_01
        '
        Me.txt_BUMON_NM_01.Location = New System.Drawing.Point(238, 223)
        Me.txt_BUMON_NM_01.Name = "txt_BUMON_NM_01"
        Me.txt_BUMON_NM_01.Size = New System.Drawing.Size(283, 19)
        Me.txt_BUMON_NM_01.TabIndex = 9
        '
        ' txt_VAL_01
        '
        Me.txt_VAL_01.Location = New System.Drawing.Point(143, 196)
        Me.txt_VAL_01.Name = "txt_VAL_01"
        Me.txt_VAL_01.Size = New System.Drawing.Size(94, 19)
        Me.txt_VAL_01.TabIndex = 10
        '
        ' テキスト105
        '
        Me.テキスト105.Location = New System.Drawing.Point(241, 170)
        Me.テキスト105.Name = "テキスト105"
        Me.テキスト105.Size = New System.Drawing.Size(50, 19)
        Me.テキスト105.TabIndex = 11
        '
        ' txt_BUMON_NM_02
        '
        Me.txt_BUMON_NM_02.Location = New System.Drawing.Point(377, 136)
        Me.txt_BUMON_NM_02.Name = "txt_BUMON_NM_02"
        Me.txt_BUMON_NM_02.Size = New System.Drawing.Size(143, 19)
        Me.txt_BUMON_NM_02.TabIndex = 12
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(143, 113)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 13
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_YMD_01
        '
        Me.lbl_YMD_01.AutoSize = True
        Me.lbl_YMD_01.Location = New System.Drawing.Point(26, 45)
        Me.lbl_YMD_01.Name = "lbl_YMD_01"
        Me.lbl_YMD_01.TabIndex = 14
        Me.lbl_YMD_01.Text = "対象年月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(143, 98)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 15
        Me.lbl_EXPLANATION1.Text = "※月次仕訳計上ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_CHK_01
        '
        Me.lbl_CHK_01.AutoSize = True
        Me.lbl_CHK_01.Location = New System.Drawing.Point(26, 75)
        Me.lbl_CHK_01.Name = "lbl_CHK_01"
        Me.lbl_CHK_01.TabIndex = 16
        Me.lbl_CHK_01.Text = "出力元の抽出"
        '
        ' lbl_CHK_01_F
        '
        Me.lbl_CHK_01_F.AutoSize = True
        Me.lbl_CHK_01_F.Location = New System.Drawing.Point(177, 75)
        Me.lbl_CHK_01_F.Name = "lbl_CHK_01_F"
        Me.lbl_CHK_01_F.TabIndex = 17
        Me.lbl_CHK_01_F.Text = "検索条件を加味する"
        '
        ' lbl_YMD_02
        '
        Me.lbl_YMD_02.AutoSize = True
        Me.lbl_YMD_02.Location = New System.Drawing.Point(26, 170)
        Me.lbl_YMD_02.Name = "lbl_YMD_02"
        Me.lbl_YMD_02.TabIndex = 18
        Me.lbl_YMD_02.Text = "伝票日付"
        '
        ' lbl_TEXT_02
        '
        Me.lbl_TEXT_02.AutoSize = True
        Me.lbl_TEXT_02.Location = New System.Drawing.Point(26, 309)
        Me.lbl_TEXT_02.Name = "lbl_TEXT_02"
        Me.lbl_TEXT_02.TabIndex = 19
        Me.lbl_TEXT_02.Text = "エビデンス用"
        '
        ' lbl_TEXT_01
        '
        Me.lbl_TEXT_01.AutoSize = True
        Me.lbl_TEXT_01.Location = New System.Drawing.Point(26, 283)
        Me.lbl_TEXT_01.Name = "lbl_TEXT_01"
        Me.lbl_TEXT_01.TabIndex = 20
        Me.lbl_TEXT_01.Text = "BEST連携用"
        '
        ' lbl_BUMON_CD_01
        '
        Me.lbl_BUMON_CD_01.AutoSize = True
        Me.lbl_BUMON_CD_01.Location = New System.Drawing.Point(26, 223)
        Me.lbl_BUMON_CD_01.Name = "lbl_BUMON_CD_01"
        Me.lbl_BUMON_CD_01.TabIndex = 21
        Me.lbl_BUMON_CD_01.Text = "部署(全社経費)"
        '
        ' ラベル104
        '
        Me.ラベル104.AutoSize = True
        Me.ラベル104.Location = New System.Drawing.Point(26, 196)
        Me.ラベル104.Name = "ラベル104"
        Me.ラベル104.TabIndex = 22
        Me.ラベル104.Text = "伝票番号連番部分"
        '
        ' ラベル106
        '
        Me.ラベル106.AutoSize = True
        Me.ラベル106.Location = New System.Drawing.Point(26, 264)
        Me.ラベル106.Name = "ラベル106"
        Me.ラベル106.TabIndex = 23
        Me.ラベル106.Text = "＜出力ファイル（Excel）＞"
        '
        ' ラベル107
        '
        Me.ラベル107.AutoSize = True
        Me.ラベル107.Location = New System.Drawing.Point(143, 332)
        Me.ラベル107.Name = "ラベル107"
        Me.ラベル107.TabIndex = 24
        Me.ラベル107.Text = "※BEST連携用ファイルに部署名や科目名を付与する事で見やすくしたものです。"
        '
        ' ラベル108
        '
        Me.ラベル108.AutoSize = True
        Me.ラベル108.Location = New System.Drawing.Point(26, 359)
        Me.ラベル108.Name = "ラベル108"
        Me.ラベル108.TabIndex = 25
        Me.ラベル108.Text = "＜出力対象仕訳＞"
        '
        ' lbl_出力対象仕訳
        '
        Me.lbl_出力対象仕訳.AutoSize = True
        Me.lbl_出力対象仕訳.Location = New System.Drawing.Point(37, 374)
        Me.lbl_出力対象仕訳.Name = "lbl_出力対象仕訳"
        Me.lbl_出力対象仕訳.TabIndex = 26
        Me.lbl_出力対象仕訳.Text = "資産_開始"
        '
        ' ラベル110
        '
        Me.ラベル110.AutoSize = True
        Me.ラベル110.Location = New System.Drawing.Point(37, 389)
        Me.ラベル110.Name = "ラベル110"
        Me.ラベル110.TabIndex = 27
        Me.ラベル110.Text = "資産_償却"
        '
        ' ラベル111
        '
        Me.ラベル111.AutoSize = True
        Me.ラベル111.Location = New System.Drawing.Point(37, 404)
        Me.ラベル111.Name = "ラベル111"
        Me.ラベル111.TabIndex = 28
        Me.ラベル111.Text = "資産_債務長短振替"
        '
        ' ラベル112
        '
        Me.ラベル112.AutoSize = True
        Me.ラベル112.Location = New System.Drawing.Point(37, 419)
        Me.ラベル112.Name = "ラベル112"
        Me.ラベル112.TabIndex = 29
        Me.ラベル112.Text = "資産_終了"
        '
        ' ラベル113
        '
        Me.ラベル113.AutoSize = True
        Me.ラベル113.Location = New System.Drawing.Point(37, 434)
        Me.ラベル113.Name = "ラベル113"
        Me.ラベル113.TabIndex = 30
        Me.ラベル113.Text = "資産_債務解約抹消"
        '
        ' ラベル114
        '
        Me.ラベル114.AutoSize = True
        Me.ラベル114.Location = New System.Drawing.Point(37, 449)
        Me.ラベル114.Name = "ラベル114"
        Me.ラベル114.TabIndex = 31
        Me.ラベル114.Text = "費用_開始"
        '
        ' ラベル115
        '
        Me.ラベル115.AutoSize = True
        Me.ラベル115.Location = New System.Drawing.Point(37, 464)
        Me.ラベル115.Name = "ラベル115"
        Me.ラベル115.TabIndex = 32
        Me.ラベル115.Text = "費用_解約"
        '
        ' ラベル124
        '
        Me.ラベル124.AutoSize = True
        Me.ラベル124.Location = New System.Drawing.Point(143, 136)
        Me.ラベル124.Name = "ラベル124"
        Me.ラベル124.TabIndex = 33
        Me.ラベル124.Text = "除外する契約管理単位"
        '
        ' chk_CHK_01
        '
        Me.chk_CHK_01.AutoSize = True
        Me.chk_CHK_01.Location = New System.Drawing.Point(162, 79)
        Me.chk_CHK_01.Name = "chk_CHK_01"
        Me.chk_CHK_01.TabIndex = 34
        Me.chk_CHK_01.Text = ""
        Me.chk_CHK_01.UseVisualStyleBackColor = True
        '
        ' Form_fc_TSYSCOM_計上仕訳
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 529)
        Me.Controls.Add(Me.chk_CHK_01)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_YMD_01)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_CHK_01)
        Me.Controls.Add(Me.lbl_CHK_01_F)
        Me.Controls.Add(Me.lbl_YMD_02)
        Me.Controls.Add(Me.lbl_TEXT_02)
        Me.Controls.Add(Me.lbl_TEXT_01)
        Me.Controls.Add(Me.lbl_BUMON_CD_01)
        Me.Controls.Add(Me.ラベル104)
        Me.Controls.Add(Me.ラベル106)
        Me.Controls.Add(Me.ラベル107)
        Me.Controls.Add(Me.ラベル108)
        Me.Controls.Add(Me.lbl_出力対象仕訳)
        Me.Controls.Add(Me.ラベル110)
        Me.Controls.Add(Me.ラベル111)
        Me.Controls.Add(Me.ラベル112)
        Me.Controls.Add(Me.ラベル113)
        Me.Controls.Add(Me.ラベル114)
        Me.Controls.Add(Me.ラベル115)
        Me.Controls.Add(Me.ラベル124)
        Me.Controls.Add(Me.txt_YMD_01)
        Me.Controls.Add(Me.txt_YMD_02)
        Me.Controls.Add(Me.txt_TEXT_02)
        Me.Controls.Add(Me.txt_TEXT_01)
        Me.Controls.Add(Me.txt_BUMON_NM_01)
        Me.Controls.Add(Me.txt_VAL_01)
        Me.Controls.Add(Me.テキスト105)
        Me.Controls.Add(Me.txt_BUMON_NM_02)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択1)
        Me.Controls.Add(Me.cmd_選択2)
        Me.Controls.Add(Me.cmd_祝日)
        Me.Name = "Form_fc_TSYSCOM_計上仕訳"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次仕訳計上フレックス - 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択1 As System.Windows.Forms.Button
    Friend WithEvents cmd_選択2 As System.Windows.Forms.Button
    Friend WithEvents cmd_祝日 As System.Windows.Forms.Button
    Friend WithEvents txt_YMD_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_YMD_02 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TEXT_02 As System.Windows.Forms.TextBox
    Friend WithEvents txt_TEXT_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BUMON_NM_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_VAL_01 As System.Windows.Forms.TextBox
    Friend WithEvents テキスト105 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BUMON_NM_02 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_YMD_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01_F As System.Windows.Forms.Label
    Friend WithEvents lbl_YMD_02 As System.Windows.Forms.Label
    Friend WithEvents lbl_TEXT_02 As System.Windows.Forms.Label
    Friend WithEvents lbl_TEXT_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_BUMON_CD_01 As System.Windows.Forms.Label
    Friend WithEvents ラベル104 As System.Windows.Forms.Label
    Friend WithEvents ラベル106 As System.Windows.Forms.Label
    Friend WithEvents ラベル107 As System.Windows.Forms.Label
    Friend WithEvents ラベル108 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力対象仕訳 As System.Windows.Forms.Label
    Friend WithEvents ラベル110 As System.Windows.Forms.Label
    Friend WithEvents ラベル111 As System.Windows.Forms.Label
    Friend WithEvents ラベル112 As System.Windows.Forms.Label
    Friend WithEvents ラベル113 As System.Windows.Forms.Label
    Friend WithEvents ラベル114 As System.Windows.Forms.Label
    Friend WithEvents ラベル115 As System.Windows.Forms.Label
    Friend WithEvents ラベル124 As System.Windows.Forms.Label
    Friend WithEvents chk_CHK_01 As System.Windows.Forms.CheckBox

End Class