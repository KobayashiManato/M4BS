<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_計上仕訳_NIFS

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
        Me.txt_KAMOKU_CD_01 = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_02 = New System.Windows.Forms.TextBox()
        Me.txt_FileNM = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_03 = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_04 = New System.Windows.Forms.TextBox()
        Me.txt_BUMON_CD_01 = New System.Windows.Forms.TextBox()
        Me.txt_BUMON_CD_02 = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_05 = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_06 = New System.Windows.Forms.TextBox()
        Me.txt_KAMOKU_CD_07 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_YMD_01 = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_出力元の抽出 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01 = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_01 = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_02 = New System.Windows.Forms.Label()
        Me.lbl_科目ｺｰﾄﾞ = New System.Windows.Forms.Label()
        Me.lbl_出力対象仕訳 = New System.Windows.Forms.Label()
        Me.lbl_出力ﾌｧｲﾙ名 = New System.Windows.Forms.Label()
        Me.lbl_CHK_02 = New System.Windows.Forms.Label()
        Me.lbl_CHK_03 = New System.Windows.Forms.Label()
        Me.lbl_CHK_04 = New System.Windows.Forms.Label()
        Me.lbl_CHK_05 = New System.Windows.Forms.Label()
        Me.lbl_CHK_06 = New System.Windows.Forms.Label()
        Me.lbl_CHK_07 = New System.Windows.Forms.Label()
        Me.lbl_CHK_08 = New System.Windows.Forms.Label()
        Me.lbl_CHK_09 = New System.Windows.Forms.Label()
        Me.lbl_通常ﾘｰｽ = New System.Windows.Forms.Label()
        Me.lbl_資産ﾘｰｽ = New System.Windows.Forms.Label()
        Me.lbl_転ﾘｰｽ = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_03 = New System.Windows.Forms.Label()
        Me.ラベル77 = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_04 = New System.Windows.Forms.Label()
        Me.lbl_BUMON_CD_01 = New System.Windows.Forms.Label()
        Me.ラベル82 = New System.Windows.Forms.Label()
        Me.lbl_BUMON_CD_02 = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_05 = New System.Windows.Forms.Label()
        Me.lbl_KAMOKU_CD_06 = New System.Windows.Forms.Label()
        Me.ラベル90 = New System.Windows.Forms.Label()
        Me.chk_CHK_01 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_02 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_03 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_04 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_05 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_06 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_07 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_08 = New System.Windows.Forms.CheckBox()
        Me.chk_CHK_09 = New System.Windows.Forms.CheckBox()
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
        Me.cmd_選択.Location = New System.Drawing.Point(502, 563)
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
        ' txt_KAMOKU_CD_01
        '
        Me.txt_KAMOKU_CD_01.Location = New System.Drawing.Point(139, 151)
        Me.txt_KAMOKU_CD_01.Name = "txt_KAMOKU_CD_01"
        Me.txt_KAMOKU_CD_01.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_01.TabIndex = 4
        '
        ' txt_KAMOKU_CD_02
        '
        Me.txt_KAMOKU_CD_02.Location = New System.Drawing.Point(291, 181)
        Me.txt_KAMOKU_CD_02.Name = "txt_KAMOKU_CD_02"
        Me.txt_KAMOKU_CD_02.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_02.TabIndex = 5
        '
        ' txt_FileNM
        '
        Me.txt_FileNM.Location = New System.Drawing.Point(139, 563)
        Me.txt_FileNM.Name = "txt_FileNM"
        Me.txt_FileNM.Size = New System.Drawing.Size(359, 19)
        Me.txt_FileNM.TabIndex = 6
        '
        ' txt_KAMOKU_CD_03
        '
        Me.txt_KAMOKU_CD_03.Location = New System.Drawing.Point(291, 211)
        Me.txt_KAMOKU_CD_03.Name = "txt_KAMOKU_CD_03"
        Me.txt_KAMOKU_CD_03.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_03.TabIndex = 7
        '
        ' txt_KAMOKU_CD_04
        '
        Me.txt_KAMOKU_CD_04.Location = New System.Drawing.Point(291, 249)
        Me.txt_KAMOKU_CD_04.Name = "txt_KAMOKU_CD_04"
        Me.txt_KAMOKU_CD_04.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_04.TabIndex = 8
        '
        ' txt_BUMON_CD_01
        '
        Me.txt_BUMON_CD_01.Location = New System.Drawing.Point(291, 279)
        Me.txt_BUMON_CD_01.Name = "txt_BUMON_CD_01"
        Me.txt_BUMON_CD_01.Size = New System.Drawing.Size(90, 19)
        Me.txt_BUMON_CD_01.TabIndex = 9
        '
        ' txt_BUMON_CD_02
        '
        Me.txt_BUMON_CD_02.Location = New System.Drawing.Point(291, 298)
        Me.txt_BUMON_CD_02.Name = "txt_BUMON_CD_02"
        Me.txt_BUMON_CD_02.Size = New System.Drawing.Size(90, 19)
        Me.txt_BUMON_CD_02.TabIndex = 10
        '
        ' txt_KAMOKU_CD_05
        '
        Me.txt_KAMOKU_CD_05.Location = New System.Drawing.Point(291, 317)
        Me.txt_KAMOKU_CD_05.Name = "txt_KAMOKU_CD_05"
        Me.txt_KAMOKU_CD_05.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_05.TabIndex = 11
        '
        ' txt_KAMOKU_CD_06
        '
        Me.txt_KAMOKU_CD_06.Location = New System.Drawing.Point(291, 336)
        Me.txt_KAMOKU_CD_06.Name = "txt_KAMOKU_CD_06"
        Me.txt_KAMOKU_CD_06.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_06.TabIndex = 12
        '
        ' txt_KAMOKU_CD_07
        '
        Me.txt_KAMOKU_CD_07.Location = New System.Drawing.Point(291, 230)
        Me.txt_KAMOKU_CD_07.Name = "txt_KAMOKU_CD_07"
        Me.txt_KAMOKU_CD_07.Size = New System.Drawing.Size(90, 19)
        Me.txt_KAMOKU_CD_07.TabIndex = 13
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(143, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 14
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_YMD_01
        '
        Me.lbl_YMD_01.AutoSize = True
        Me.lbl_YMD_01.Location = New System.Drawing.Point(26, 45)
        Me.lbl_YMD_01.Name = "lbl_YMD_01"
        Me.lbl_YMD_01.TabIndex = 15
        Me.lbl_YMD_01.Text = "対象月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(143, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 16
        Me.lbl_EXPLANATION1.Text = "※月次仕訳計上ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_出力元の抽出
        '
        Me.lbl_出力元の抽出.AutoSize = True
        Me.lbl_出力元の抽出.Location = New System.Drawing.Point(26, 75)
        Me.lbl_出力元の抽出.Name = "lbl_出力元の抽出"
        Me.lbl_出力元の抽出.TabIndex = 17
        Me.lbl_出力元の抽出.Text = "出力元の抽出"
        '
        ' lbl_CHK_01
        '
        Me.lbl_CHK_01.AutoSize = True
        Me.lbl_CHK_01.Location = New System.Drawing.Point(181, 75)
        Me.lbl_CHK_01.Name = "lbl_CHK_01"
        Me.lbl_CHK_01.TabIndex = 18
        Me.lbl_CHK_01.Text = "検索条件を加味する"
        '
        ' lbl_KAMOKU_CD_01
        '
        Me.lbl_KAMOKU_CD_01.AutoSize = True
        Me.lbl_KAMOKU_CD_01.Location = New System.Drawing.Point(26, 151)
        Me.lbl_KAMOKU_CD_01.Name = "lbl_KAMOKU_CD_01"
        Me.lbl_KAMOKU_CD_01.TabIndex = 19
        Me.lbl_KAMOKU_CD_01.Text = "部署ｺｰﾄﾞ(一括)"
        '
        ' lbl_KAMOKU_CD_02
        '
        Me.lbl_KAMOKU_CD_02.AutoSize = True
        Me.lbl_KAMOKU_CD_02.Location = New System.Drawing.Point(139, 181)
        Me.lbl_KAMOKU_CD_02.Name = "lbl_KAMOKU_CD_02"
        Me.lbl_KAMOKU_CD_02.TabIndex = 20
        Me.lbl_KAMOKU_CD_02.Text = "長期前払費用(ﾘｰｽ)"
        '
        ' lbl_科目ｺｰﾄﾞ
        '
        Me.lbl_科目ｺｰﾄﾞ.AutoSize = True
        Me.lbl_科目ｺｰﾄﾞ.Location = New System.Drawing.Point(26, 181)
        Me.lbl_科目ｺｰﾄﾞ.Name = "lbl_科目ｺｰﾄﾞ"
        Me.lbl_科目ｺｰﾄﾞ.TabIndex = 21
        Me.lbl_科目ｺｰﾄﾞ.Text = "科目ｺｰﾄﾞ"
        '
        ' lbl_出力対象仕訳
        '
        Me.lbl_出力対象仕訳.AutoSize = True
        Me.lbl_出力対象仕訳.Location = New System.Drawing.Point(26, 370)
        Me.lbl_出力対象仕訳.Name = "lbl_出力対象仕訳"
        Me.lbl_出力対象仕訳.TabIndex = 22
        Me.lbl_出力対象仕訳.Text = "出力対象仕訳"
        '
        ' lbl_出力ﾌｧｲﾙ名
        '
        Me.lbl_出力ﾌｧｲﾙ名.AutoSize = True
        Me.lbl_出力ﾌｧｲﾙ名.Location = New System.Drawing.Point(26, 563)
        Me.lbl_出力ﾌｧｲﾙ名.Name = "lbl_出力ﾌｧｲﾙ名"
        Me.lbl_出力ﾌｧｲﾙ名.TabIndex = 23
        Me.lbl_出力ﾌｧｲﾙ名.Text = "出力ﾌｧｲﾙ名"
        '
        ' lbl_CHK_02
        '
        Me.lbl_CHK_02.AutoSize = True
        Me.lbl_CHK_02.Location = New System.Drawing.Point(181, 396)
        Me.lbl_CHK_02.Name = "lbl_CHK_02"
        Me.lbl_CHK_02.TabIndex = 24
        Me.lbl_CHK_02.Text = "減損時"
        '
        ' lbl_CHK_03
        '
        Me.lbl_CHK_03.AutoSize = True
        Me.lbl_CHK_03.Location = New System.Drawing.Point(181, 412)
        Me.lbl_CHK_03.Name = "lbl_CHK_03"
        Me.lbl_CHK_03.TabIndex = 25
        Me.lbl_CHK_03.Text = "月次入力(減損分)"
        '
        ' lbl_CHK_04
        '
        Me.lbl_CHK_04.AutoSize = True
        Me.lbl_CHK_04.Location = New System.Drawing.Point(181, 442)
        Me.lbl_CHK_04.Name = "lbl_CHK_04"
        Me.lbl_CHK_04.TabIndex = 26
        Me.lbl_CHK_04.Text = "開始時"
        '
        ' lbl_CHK_05
        '
        Me.lbl_CHK_05.AutoSize = True
        Me.lbl_CHK_05.Location = New System.Drawing.Point(181, 457)
        Me.lbl_CHK_05.Name = "lbl_CHK_05"
        Me.lbl_CHK_05.TabIndex = 27
        Me.lbl_CHK_05.Text = "支払時"
        '
        ' lbl_CHK_06
        '
        Me.lbl_CHK_06.AutoSize = True
        Me.lbl_CHK_06.Location = New System.Drawing.Point(181, 472)
        Me.lbl_CHK_06.Name = "lbl_CHK_06"
        Me.lbl_CHK_06.TabIndex = 28
        Me.lbl_CHK_06.Text = "月次入力(債務返済)"
        '
        ' lbl_CHK_07
        '
        Me.lbl_CHK_07.AutoSize = True
        Me.lbl_CHK_07.Location = New System.Drawing.Point(181, 487)
        Me.lbl_CHK_07.Name = "lbl_CHK_07"
        Me.lbl_CHK_07.TabIndex = 29
        Me.lbl_CHK_07.Text = "月次入力(減価償却)"
        '
        ' lbl_CHK_08
        '
        Me.lbl_CHK_08.AutoSize = True
        Me.lbl_CHK_08.Location = New System.Drawing.Point(181, 502)
        Me.lbl_CHK_08.Name = "lbl_CHK_08"
        Me.lbl_CHK_08.TabIndex = 30
        Me.lbl_CHK_08.Text = "減損時"
        '
        ' lbl_CHK_09
        '
        Me.lbl_CHK_09.AutoSize = True
        Me.lbl_CHK_09.Location = New System.Drawing.Point(181, 532)
        Me.lbl_CHK_09.Name = "lbl_CHK_09"
        Me.lbl_CHK_09.TabIndex = 31
        Me.lbl_CHK_09.Text = "月次入力(債務返済)"
        '
        ' lbl_通常ﾘｰｽ
        '
        Me.lbl_通常ﾘｰｽ.AutoSize = True
        Me.lbl_通常ﾘｰｽ.Location = New System.Drawing.Point(26, 396)
        Me.lbl_通常ﾘｰｽ.Name = "lbl_通常ﾘｰｽ"
        Me.lbl_通常ﾘｰｽ.TabIndex = 32
        Me.lbl_通常ﾘｰｽ.Text = "通常ﾘｰｽ"
        '
        ' lbl_資産ﾘｰｽ
        '
        Me.lbl_資産ﾘｰｽ.AutoSize = True
        Me.lbl_資産ﾘｰｽ.Location = New System.Drawing.Point(26, 442)
        Me.lbl_資産ﾘｰｽ.Name = "lbl_資産ﾘｰｽ"
        Me.lbl_資産ﾘｰｽ.TabIndex = 33
        Me.lbl_資産ﾘｰｽ.Text = "資産ﾘｰｽ"
        '
        ' lbl_転ﾘｰｽ
        '
        Me.lbl_転ﾘｰｽ.AutoSize = True
        Me.lbl_転ﾘｰｽ.Location = New System.Drawing.Point(26, 532)
        Me.lbl_転ﾘｰｽ.Name = "lbl_転ﾘｰｽ"
        Me.lbl_転ﾘｰｽ.TabIndex = 34
        Me.lbl_転ﾘｰｽ.Text = "転ﾘｰｽ"
        '
        ' lbl_KAMOKU_CD_03
        '
        Me.lbl_KAMOKU_CD_03.AutoSize = True
        Me.lbl_KAMOKU_CD_03.Location = New System.Drawing.Point(139, 211)
        Me.lbl_KAMOKU_CD_03.Name = "lbl_KAMOKU_CD_03"
        Me.lbl_KAMOKU_CD_03.TabIndex = 35
        Me.lbl_KAMOKU_CD_03.Text = "ﾘｰｽ債務(資産ﾘｰｽ)"
        '
        ' ラベル77
        '
        Me.ラベル77.AutoSize = True
        Me.ラベル77.Location = New System.Drawing.Point(26, 211)
        Me.ラベル77.Name = "ラベル77"
        Me.ラベル77.TabIndex = 36
        Me.ラベル77.Text = "細目ｺｰﾄﾞ"
        '
        ' lbl_KAMOKU_CD_04
        '
        Me.lbl_KAMOKU_CD_04.AutoSize = True
        Me.lbl_KAMOKU_CD_04.Location = New System.Drawing.Point(139, 249)
        Me.lbl_KAMOKU_CD_04.Name = "lbl_KAMOKU_CD_04"
        Me.lbl_KAMOKU_CD_04.TabIndex = 37
        Me.lbl_KAMOKU_CD_04.Text = "長期未払金"
        '
        ' lbl_BUMON_CD_01
        '
        Me.lbl_BUMON_CD_01.AutoSize = True
        Me.lbl_BUMON_CD_01.Location = New System.Drawing.Point(139, 279)
        Me.lbl_BUMON_CD_01.Name = "lbl_BUMON_CD_01"
        Me.lbl_BUMON_CD_01.TabIndex = 38
        Me.lbl_BUMON_CD_01.Text = "上位部門CD"
        '
        ' ラベル82
        '
        Me.ラベル82.AutoSize = True
        Me.ラベル82.Location = New System.Drawing.Point(26, 279)
        Me.ラベル82.Name = "ラベル82"
        Me.ラベル82.TabIndex = 39
        Me.ラベル82.Text = "本社減損"
        '
        ' lbl_BUMON_CD_02
        '
        Me.lbl_BUMON_CD_02.AutoSize = True
        Me.lbl_BUMON_CD_02.Location = New System.Drawing.Point(139, 298)
        Me.lbl_BUMON_CD_02.Name = "lbl_BUMON_CD_02"
        Me.lbl_BUMON_CD_02.TabIndex = 40
        Me.lbl_BUMON_CD_02.Text = "部門CD"
        '
        ' lbl_KAMOKU_CD_05
        '
        Me.lbl_KAMOKU_CD_05.AutoSize = True
        Me.lbl_KAMOKU_CD_05.Location = New System.Drawing.Point(139, 317)
        Me.lbl_KAMOKU_CD_05.Name = "lbl_KAMOKU_CD_05"
        Me.lbl_KAMOKU_CD_05.TabIndex = 41
        Me.lbl_KAMOKU_CD_05.Text = "減損勘定取崩科目CD"
        '
        ' lbl_KAMOKU_CD_06
        '
        Me.lbl_KAMOKU_CD_06.AutoSize = True
        Me.lbl_KAMOKU_CD_06.Location = New System.Drawing.Point(139, 336)
        Me.lbl_KAMOKU_CD_06.Name = "lbl_KAMOKU_CD_06"
        Me.lbl_KAMOKU_CD_06.TabIndex = 42
        Me.lbl_KAMOKU_CD_06.Text = "減損勘定取崩ｾｸﾞﾒﾝﾄCD"
        '
        ' ラベル90
        '
        Me.ラベル90.AutoSize = True
        Me.ラベル90.Location = New System.Drawing.Point(139, 230)
        Me.ラベル90.Name = "ラベル90"
        Me.ラベル90.TabIndex = 43
        Me.ラベル90.Text = "ﾘｰｽ債務(転ﾘｰｽ)"
        '
        ' chk_CHK_01
        '
        Me.chk_CHK_01.AutoSize = True
        Me.chk_CHK_01.Location = New System.Drawing.Point(166, 75)
        Me.chk_CHK_01.Name = "chk_CHK_01"
        Me.chk_CHK_01.TabIndex = 44
        Me.chk_CHK_01.Text = ""
        Me.chk_CHK_01.UseVisualStyleBackColor = True
        '
        ' chk_CHK_02
        '
        Me.chk_CHK_02.AutoSize = True
        Me.chk_CHK_02.Location = New System.Drawing.Point(166, 396)
        Me.chk_CHK_02.Name = "chk_CHK_02"
        Me.chk_CHK_02.TabIndex = 45
        Me.chk_CHK_02.Text = ""
        Me.chk_CHK_02.UseVisualStyleBackColor = True
        '
        ' chk_CHK_03
        '
        Me.chk_CHK_03.AutoSize = True
        Me.chk_CHK_03.Location = New System.Drawing.Point(166, 412)
        Me.chk_CHK_03.Name = "chk_CHK_03"
        Me.chk_CHK_03.TabIndex = 46
        Me.chk_CHK_03.Text = ""
        Me.chk_CHK_03.UseVisualStyleBackColor = True
        '
        ' chk_CHK_04
        '
        Me.chk_CHK_04.AutoSize = True
        Me.chk_CHK_04.Location = New System.Drawing.Point(166, 442)
        Me.chk_CHK_04.Name = "chk_CHK_04"
        Me.chk_CHK_04.TabIndex = 47
        Me.chk_CHK_04.Text = ""
        Me.chk_CHK_04.UseVisualStyleBackColor = True
        '
        ' chk_CHK_05
        '
        Me.chk_CHK_05.AutoSize = True
        Me.chk_CHK_05.Location = New System.Drawing.Point(166, 457)
        Me.chk_CHK_05.Name = "chk_CHK_05"
        Me.chk_CHK_05.TabIndex = 48
        Me.chk_CHK_05.Text = ""
        Me.chk_CHK_05.UseVisualStyleBackColor = True
        '
        ' chk_CHK_06
        '
        Me.chk_CHK_06.AutoSize = True
        Me.chk_CHK_06.Location = New System.Drawing.Point(166, 472)
        Me.chk_CHK_06.Name = "chk_CHK_06"
        Me.chk_CHK_06.TabIndex = 49
        Me.chk_CHK_06.Text = ""
        Me.chk_CHK_06.UseVisualStyleBackColor = True
        '
        ' chk_CHK_07
        '
        Me.chk_CHK_07.AutoSize = True
        Me.chk_CHK_07.Location = New System.Drawing.Point(166, 487)
        Me.chk_CHK_07.Name = "chk_CHK_07"
        Me.chk_CHK_07.TabIndex = 50
        Me.chk_CHK_07.Text = ""
        Me.chk_CHK_07.UseVisualStyleBackColor = True
        '
        ' chk_CHK_08
        '
        Me.chk_CHK_08.AutoSize = True
        Me.chk_CHK_08.Location = New System.Drawing.Point(166, 502)
        Me.chk_CHK_08.Name = "chk_CHK_08"
        Me.chk_CHK_08.TabIndex = 51
        Me.chk_CHK_08.Text = ""
        Me.chk_CHK_08.UseVisualStyleBackColor = True
        '
        ' chk_CHK_09
        '
        Me.chk_CHK_09.AutoSize = True
        Me.chk_CHK_09.Location = New System.Drawing.Point(166, 532)
        Me.chk_CHK_09.Name = "chk_CHK_09"
        Me.chk_CHK_09.TabIndex = 52
        Me.chk_CHK_09.Text = ""
        Me.chk_CHK_09.UseVisualStyleBackColor = True
        '
        ' Form_fc_計上仕訳_NIFS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 631)
        Me.Controls.Add(Me.chk_CHK_01)
        Me.Controls.Add(Me.chk_CHK_02)
        Me.Controls.Add(Me.chk_CHK_03)
        Me.Controls.Add(Me.chk_CHK_04)
        Me.Controls.Add(Me.chk_CHK_05)
        Me.Controls.Add(Me.chk_CHK_06)
        Me.Controls.Add(Me.chk_CHK_07)
        Me.Controls.Add(Me.chk_CHK_08)
        Me.Controls.Add(Me.chk_CHK_09)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_YMD_01)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_出力元の抽出)
        Me.Controls.Add(Me.lbl_CHK_01)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_01)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_02)
        Me.Controls.Add(Me.lbl_科目ｺｰﾄﾞ)
        Me.Controls.Add(Me.lbl_出力対象仕訳)
        Me.Controls.Add(Me.lbl_出力ﾌｧｲﾙ名)
        Me.Controls.Add(Me.lbl_CHK_02)
        Me.Controls.Add(Me.lbl_CHK_03)
        Me.Controls.Add(Me.lbl_CHK_04)
        Me.Controls.Add(Me.lbl_CHK_05)
        Me.Controls.Add(Me.lbl_CHK_06)
        Me.Controls.Add(Me.lbl_CHK_07)
        Me.Controls.Add(Me.lbl_CHK_08)
        Me.Controls.Add(Me.lbl_CHK_09)
        Me.Controls.Add(Me.lbl_通常ﾘｰｽ)
        Me.Controls.Add(Me.lbl_資産ﾘｰｽ)
        Me.Controls.Add(Me.lbl_転ﾘｰｽ)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_03)
        Me.Controls.Add(Me.ラベル77)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_04)
        Me.Controls.Add(Me.lbl_BUMON_CD_01)
        Me.Controls.Add(Me.ラベル82)
        Me.Controls.Add(Me.lbl_BUMON_CD_02)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_05)
        Me.Controls.Add(Me.lbl_KAMOKU_CD_06)
        Me.Controls.Add(Me.ラベル90)
        Me.Controls.Add(Me.txt_YMD_01)
        Me.Controls.Add(Me.txt_KAMOKU_CD_01)
        Me.Controls.Add(Me.txt_KAMOKU_CD_02)
        Me.Controls.Add(Me.txt_FileNM)
        Me.Controls.Add(Me.txt_KAMOKU_CD_03)
        Me.Controls.Add(Me.txt_KAMOKU_CD_04)
        Me.Controls.Add(Me.txt_BUMON_CD_01)
        Me.Controls.Add(Me.txt_BUMON_CD_02)
        Me.Controls.Add(Me.txt_KAMOKU_CD_05)
        Me.Controls.Add(Me.txt_KAMOKU_CD_06)
        Me.Controls.Add(Me.txt_KAMOKU_CD_07)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_計上仕訳_NIFS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次仕訳計上ﾌﾚｯｸｽ - 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_YMD_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_02 As System.Windows.Forms.TextBox
    Friend WithEvents txt_FileNM As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_03 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_04 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BUMON_CD_01 As System.Windows.Forms.TextBox
    Friend WithEvents txt_BUMON_CD_02 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_05 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_06 As System.Windows.Forms.TextBox
    Friend WithEvents txt_KAMOKU_CD_07 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_YMD_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力元の抽出 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_02 As System.Windows.Forms.Label
    Friend WithEvents lbl_科目ｺｰﾄﾞ As System.Windows.Forms.Label
    Friend WithEvents lbl_出力対象仕訳 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力ﾌｧｲﾙ名 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_02 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_03 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_04 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_05 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_06 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_07 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_08 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_09 As System.Windows.Forms.Label
    Friend WithEvents lbl_通常ﾘｰｽ As System.Windows.Forms.Label
    Friend WithEvents lbl_資産ﾘｰｽ As System.Windows.Forms.Label
    Friend WithEvents lbl_転ﾘｰｽ As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_03 As System.Windows.Forms.Label
    Friend WithEvents ラベル77 As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_04 As System.Windows.Forms.Label
    Friend WithEvents lbl_BUMON_CD_01 As System.Windows.Forms.Label
    Friend WithEvents ラベル82 As System.Windows.Forms.Label
    Friend WithEvents lbl_BUMON_CD_02 As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_05 As System.Windows.Forms.Label
    Friend WithEvents lbl_KAMOKU_CD_06 As System.Windows.Forms.Label
    Friend WithEvents ラベル90 As System.Windows.Forms.Label
    Friend WithEvents chk_CHK_01 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_02 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_03 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_04 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_05 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_06 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_07 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_08 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CHK_09 As System.Windows.Forms.CheckBox

End Class