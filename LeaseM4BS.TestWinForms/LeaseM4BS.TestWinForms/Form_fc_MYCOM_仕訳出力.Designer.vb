<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_MYCOM_仕訳出力

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
        Me.cmd_FolderSel = New System.Windows.Forms.Button()
        Me.cmd_減損以外ON = New System.Windows.Forms.Button()
        Me.cmd_減損のみON = New System.Windows.Forms.Button()
        Me.cmd_会社追加 = New System.Windows.Forms.Button()
        Me.cmd_会社変更 = New System.Windows.Forms.Button()
        Me.txt_FolderNm = New System.Windows.Forms.TextBox()
        Me.txt_計上曜日 = New System.Windows.Forms.TextBox()
        Me.txt_計上日 = New System.Windows.Forms.TextBox()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01_F = New System.Windows.Forms.Label()
        Me.lbl_CHK_1 = New System.Windows.Forms.Label()
        Me.lbl_CHK_2 = New System.Windows.Forms.Label()
        Me.lbl_CHK_3 = New System.Windows.Forms.Label()
        Me.lbl_CHK_4 = New System.Windows.Forms.Label()
        Me.lbl_CHK_5 = New System.Windows.Forms.Label()
        Me.lbl_出力対象仕訳 = New System.Windows.Forms.Label()
        Me.lbl_CHK_7 = New System.Windows.Forms.Label()
        Me.lbl_CHK_8 = New System.Windows.Forms.Label()
        Me.lbl_CHK_9 = New System.Windows.Forms.Label()
        Me.lbl_CHK_10 = New System.Windows.Forms.Label()
        Me.lbl_CHK_11 = New System.Windows.Forms.Label()
        Me.lbl_CHK_12 = New System.Windows.Forms.Label()
        Me.lbl_CHK_13 = New System.Windows.Forms.Label()
        Me.lbl_CHK_14 = New System.Windows.Forms.Label()
        Me.lbl_CHK_15 = New System.Windows.Forms.Label()
        Me.lbl_CHK_16 = New System.Windows.Forms.Label()
        Me.lbl_CHK_17 = New System.Windows.Forms.Label()
        Me.lbl_CHK_18 = New System.Windows.Forms.Label()
        Me.lbl_CHK_19 = New System.Windows.Forms.Label()
        Me.chk_検索条件加味F = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_1 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_2 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_3 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_4 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_5 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_7 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_8 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_9 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_10 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_11 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_12 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_13 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_14 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_15 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_16 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_17 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_18 = New System.Windows.Forms.CheckBox()
        Me.chk_PTN_NO_19 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(90, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' cmd_FolderSel
        '
        Me.cmd_FolderSel.Location = New System.Drawing.Point(7, 377)
        Me.cmd_FolderSel.Name = "cmd_FolderSel"
        Me.cmd_FolderSel.Size = New System.Drawing.Size(94, 23)
        Me.cmd_FolderSel.TabIndex = 2
        Me.cmd_FolderSel.Text = "出力ﾌｫﾙﾀﾞ設定"
        Me.cmd_FolderSel.UseVisualStyleBackColor = True
        '
        ' cmd_減損以外ON
        '
        Me.cmd_減損以外ON.Location = New System.Drawing.Point(151, 434)
        Me.cmd_減損以外ON.Name = "cmd_減損以外ON"
        Me.cmd_減損以外ON.Size = New System.Drawing.Size(75, 23)
        Me.cmd_減損以外ON.TabIndex = 3
        Me.cmd_減損以外ON.Text = "減損以外On"
        Me.cmd_減損以外ON.UseVisualStyleBackColor = True
        '
        ' cmd_減損のみON
        '
        Me.cmd_減損のみON.Location = New System.Drawing.Point(151, 453)
        Me.cmd_減損のみON.Name = "cmd_減損のみON"
        Me.cmd_減損のみON.Size = New System.Drawing.Size(75, 23)
        Me.cmd_減損のみON.TabIndex = 4
        Me.cmd_減損のみON.Text = "減損のみOn"
        Me.cmd_減損のみON.UseVisualStyleBackColor = True
        '
        ' cmd_会社追加
        '
        Me.cmd_会社追加.Location = New System.Drawing.Point(718, 37)
        Me.cmd_会社追加.Name = "cmd_会社追加"
        Me.cmd_会社追加.Size = New System.Drawing.Size(75, 26)
        Me.cmd_会社追加.TabIndex = 5
        Me.cmd_会社追加.Text = "会社追加"
        Me.cmd_会社追加.UseVisualStyleBackColor = True
        '
        ' cmd_会社変更
        '
        Me.cmd_会社変更.Location = New System.Drawing.Point(793, 37)
        Me.cmd_会社変更.Name = "cmd_会社変更"
        Me.cmd_会社変更.Size = New System.Drawing.Size(75, 26)
        Me.cmd_会社変更.TabIndex = 6
        Me.cmd_会社変更.Text = "会社変更"
        Me.cmd_会社変更.UseVisualStyleBackColor = True
        '
        ' txt_FolderNm
        '
        Me.txt_FolderNm.Location = New System.Drawing.Point(105, 381)
        Me.txt_FolderNm.Name = "txt_FolderNm"
        Me.txt_FolderNm.Size = New System.Drawing.Size(759, 19)
        Me.txt_FolderNm.TabIndex = 7
        '
        ' txt_計上曜日
        '
        Me.txt_計上曜日.Location = New System.Drawing.Point(177, 41)
        Me.txt_計上曜日.Name = "txt_計上曜日"
        Me.txt_計上曜日.Size = New System.Drawing.Size(50, 19)
        Me.txt_計上曜日.TabIndex = 8
        '
        ' txt_計上日
        '
        Me.txt_計上日.Location = New System.Drawing.Point(102, 41)
        Me.txt_計上日.Name = "txt_計上日"
        Me.txt_計上日.Size = New System.Drawing.Size(75, 19)
        Me.txt_計上日.TabIndex = 9
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(7, 41)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 10
        Me.ラベル521.Text = "計上日"
        '
        ' lbl_CHK_01
        '
        Me.lbl_CHK_01.AutoSize = True
        Me.lbl_CHK_01.Location = New System.Drawing.Point(264, 41)
        Me.lbl_CHK_01.Name = "lbl_CHK_01"
        Me.lbl_CHK_01.TabIndex = 11
        Me.lbl_CHK_01.Text = "出力元の抽出"
        '
        ' lbl_CHK_01_F
        '
        Me.lbl_CHK_01_F.AutoSize = True
        Me.lbl_CHK_01_F.Location = New System.Drawing.Point(415, 41)
        Me.lbl_CHK_01_F.Name = "lbl_CHK_01_F"
        Me.lbl_CHK_01_F.TabIndex = 12
        Me.lbl_CHK_01_F.Text = "検索条件を加味する"
        '
        ' lbl_CHK_1
        '
        Me.lbl_CHK_1.AutoSize = True
        Me.lbl_CHK_1.Location = New System.Drawing.Point(264, 408)
        Me.lbl_CHK_1.Name = "lbl_CHK_1"
        Me.lbl_CHK_1.TabIndex = 13
        Me.lbl_CHK_1.Text = "資産_開始"
        '
        ' lbl_CHK_2
        '
        Me.lbl_CHK_2.AutoSize = True
        Me.lbl_CHK_2.Location = New System.Drawing.Point(264, 423)
        Me.lbl_CHK_2.Name = "lbl_CHK_2"
        Me.lbl_CHK_2.TabIndex = 14
        Me.lbl_CHK_2.Text = "資産_償却"
        '
        ' lbl_CHK_3
        '
        Me.lbl_CHK_3.AutoSize = True
        Me.lbl_CHK_3.Location = New System.Drawing.Point(264, 438)
        Me.lbl_CHK_3.Name = "lbl_CHK_3"
        Me.lbl_CHK_3.TabIndex = 15
        Me.lbl_CHK_3.Text = "資産_返済"
        '
        ' lbl_CHK_4
        '
        Me.lbl_CHK_4.AutoSize = True
        Me.lbl_CHK_4.Location = New System.Drawing.Point(264, 453)
        Me.lbl_CHK_4.Name = "lbl_CHK_4"
        Me.lbl_CHK_4.TabIndex = 16
        Me.lbl_CHK_4.Text = "資産_減損"
        '
        ' lbl_CHK_5
        '
        Me.lbl_CHK_5.AutoSize = True
        Me.lbl_CHK_5.Location = New System.Drawing.Point(264, 468)
        Me.lbl_CHK_5.Name = "lbl_CHK_5"
        Me.lbl_CHK_5.TabIndex = 17
        Me.lbl_CHK_5.Text = "資産_終了"
        '
        ' lbl_出力対象仕訳
        '
        Me.lbl_出力対象仕訳.AutoSize = True
        Me.lbl_出力対象仕訳.Location = New System.Drawing.Point(113, 408)
        Me.lbl_出力対象仕訳.Name = "lbl_出力対象仕訳"
        Me.lbl_出力対象仕訳.TabIndex = 18
        Me.lbl_出力対象仕訳.Text = "出力対象仕訳"
        '
        ' lbl_CHK_7
        '
        Me.lbl_CHK_7.AutoSize = True
        Me.lbl_CHK_7.Location = New System.Drawing.Point(415, 408)
        Me.lbl_CHK_7.Name = "lbl_CHK_7"
        Me.lbl_CHK_7.TabIndex = 19
        Me.lbl_CHK_7.Text = "費用_開始"
        '
        ' lbl_CHK_8
        '
        Me.lbl_CHK_8.AutoSize = True
        Me.lbl_CHK_8.Location = New System.Drawing.Point(415, 423)
        Me.lbl_CHK_8.Name = "lbl_CHK_8"
        Me.lbl_CHK_8.TabIndex = 20
        Me.lbl_CHK_8.Text = "費用_費用"
        '
        ' lbl_CHK_9
        '
        Me.lbl_CHK_9.AutoSize = True
        Me.lbl_CHK_9.Location = New System.Drawing.Point(415, 438)
        Me.lbl_CHK_9.Name = "lbl_CHK_9"
        Me.lbl_CHK_9.TabIndex = 21
        Me.lbl_CHK_9.Text = "費用_減損"
        '
        ' lbl_CHK_10
        '
        Me.lbl_CHK_10.AutoSize = True
        Me.lbl_CHK_10.Location = New System.Drawing.Point(415, 453)
        Me.lbl_CHK_10.Name = "lbl_CHK_10"
        Me.lbl_CHK_10.TabIndex = 22
        Me.lbl_CHK_10.Text = "費用_減損取崩"
        '
        ' lbl_CHK_11
        '
        Me.lbl_CHK_11.AutoSize = True
        Me.lbl_CHK_11.Location = New System.Drawing.Point(415, 468)
        Me.lbl_CHK_11.Name = "lbl_CHK_11"
        Me.lbl_CHK_11.TabIndex = 23
        Me.lbl_CHK_11.Text = "費用_解約"
        '
        ' lbl_CHK_12
        '
        Me.lbl_CHK_12.AutoSize = True
        Me.lbl_CHK_12.Location = New System.Drawing.Point(566, 408)
        Me.lbl_CHK_12.Name = "lbl_CHK_12"
        Me.lbl_CHK_12.TabIndex = 24
        Me.lbl_CHK_12.Text = "関係会社立替"
        '
        ' lbl_CHK_13
        '
        Me.lbl_CHK_13.AutoSize = True
        Me.lbl_CHK_13.Location = New System.Drawing.Point(566, 423)
        Me.lbl_CHK_13.Name = "lbl_CHK_13"
        Me.lbl_CHK_13.TabIndex = 25
        Me.lbl_CHK_13.Text = "経過勘定振替_仮払金"
        '
        ' lbl_CHK_14
        '
        Me.lbl_CHK_14.AutoSize = True
        Me.lbl_CHK_14.Location = New System.Drawing.Point(566, 438)
        Me.lbl_CHK_14.Name = "lbl_CHK_14"
        Me.lbl_CHK_14.TabIndex = 26
        Me.lbl_CHK_14.Text = "経過勘定振替_未払金"
        '
        ' lbl_CHK_15
        '
        Me.lbl_CHK_15.AutoSize = True
        Me.lbl_CHK_15.Location = New System.Drawing.Point(566, 453)
        Me.lbl_CHK_15.Name = "lbl_CHK_15"
        Me.lbl_CHK_15.TabIndex = 27
        Me.lbl_CHK_15.Text = "経過非資金_未払シス外"
        '
        ' lbl_CHK_16
        '
        Me.lbl_CHK_16.AutoSize = True
        Me.lbl_CHK_16.Location = New System.Drawing.Point(566, 468)
        Me.lbl_CHK_16.Name = "lbl_CHK_16"
        Me.lbl_CHK_16.TabIndex = 28
        Me.lbl_CHK_16.Text = "未収Cash外_経過非資金"
        '
        ' lbl_CHK_17
        '
        Me.lbl_CHK_17.AutoSize = True
        Me.lbl_CHK_17.Location = New System.Drawing.Point(718, 408)
        Me.lbl_CHK_17.Name = "lbl_CHK_17"
        Me.lbl_CHK_17.TabIndex = 29
        Me.lbl_CHK_17.Text = "関係会社立替_未収Cash外"
        '
        ' lbl_CHK_18
        '
        Me.lbl_CHK_18.AutoSize = True
        Me.lbl_CHK_18.Location = New System.Drawing.Point(718, 423)
        Me.lbl_CHK_18.Name = "lbl_CHK_18"
        Me.lbl_CHK_18.TabIndex = 30
        Me.lbl_CHK_18.Text = "経過非資金_未払Cash外"
        '
        ' lbl_CHK_19
        '
        Me.lbl_CHK_19.AutoSize = True
        Me.lbl_CHK_19.Location = New System.Drawing.Point(718, 438)
        Me.lbl_CHK_19.Name = "lbl_CHK_19"
        Me.lbl_CHK_19.TabIndex = 31
        Me.lbl_CHK_19.Text = "未払Cash外_未払シス外"
        '
        ' chk_検索条件加味F
        '
        Me.chk_検索条件加味F.AutoSize = True
        Me.chk_検索条件加味F.Location = New System.Drawing.Point(400, 45)
        Me.chk_検索条件加味F.Name = "chk_検索条件加味F"
        Me.chk_検索条件加味F.TabIndex = 32
        Me.chk_検索条件加味F.Text = ""
        Me.chk_検索条件加味F.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_1
        '
        Me.chk_PTN_NO_1.AutoSize = True
        Me.chk_PTN_NO_1.Location = New System.Drawing.Point(249, 408)
        Me.chk_PTN_NO_1.Name = "chk_PTN_NO_1"
        Me.chk_PTN_NO_1.TabIndex = 33
        Me.chk_PTN_NO_1.Text = ""
        Me.chk_PTN_NO_1.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_2
        '
        Me.chk_PTN_NO_2.AutoSize = True
        Me.chk_PTN_NO_2.Location = New System.Drawing.Point(249, 423)
        Me.chk_PTN_NO_2.Name = "chk_PTN_NO_2"
        Me.chk_PTN_NO_2.TabIndex = 34
        Me.chk_PTN_NO_2.Text = ""
        Me.chk_PTN_NO_2.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_3
        '
        Me.chk_PTN_NO_3.AutoSize = True
        Me.chk_PTN_NO_3.Location = New System.Drawing.Point(249, 438)
        Me.chk_PTN_NO_3.Name = "chk_PTN_NO_3"
        Me.chk_PTN_NO_3.TabIndex = 35
        Me.chk_PTN_NO_3.Text = ""
        Me.chk_PTN_NO_3.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_4
        '
        Me.chk_PTN_NO_4.AutoSize = True
        Me.chk_PTN_NO_4.Location = New System.Drawing.Point(249, 453)
        Me.chk_PTN_NO_4.Name = "chk_PTN_NO_4"
        Me.chk_PTN_NO_4.TabIndex = 36
        Me.chk_PTN_NO_4.Text = ""
        Me.chk_PTN_NO_4.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_5
        '
        Me.chk_PTN_NO_5.AutoSize = True
        Me.chk_PTN_NO_5.Location = New System.Drawing.Point(249, 468)
        Me.chk_PTN_NO_5.Name = "chk_PTN_NO_5"
        Me.chk_PTN_NO_5.TabIndex = 37
        Me.chk_PTN_NO_5.Text = ""
        Me.chk_PTN_NO_5.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_7
        '
        Me.chk_PTN_NO_7.AutoSize = True
        Me.chk_PTN_NO_7.Location = New System.Drawing.Point(400, 408)
        Me.chk_PTN_NO_7.Name = "chk_PTN_NO_7"
        Me.chk_PTN_NO_7.TabIndex = 38
        Me.chk_PTN_NO_7.Text = ""
        Me.chk_PTN_NO_7.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_8
        '
        Me.chk_PTN_NO_8.AutoSize = True
        Me.chk_PTN_NO_8.Location = New System.Drawing.Point(400, 423)
        Me.chk_PTN_NO_8.Name = "chk_PTN_NO_8"
        Me.chk_PTN_NO_8.TabIndex = 39
        Me.chk_PTN_NO_8.Text = ""
        Me.chk_PTN_NO_8.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_9
        '
        Me.chk_PTN_NO_9.AutoSize = True
        Me.chk_PTN_NO_9.Location = New System.Drawing.Point(400, 438)
        Me.chk_PTN_NO_9.Name = "chk_PTN_NO_9"
        Me.chk_PTN_NO_9.TabIndex = 40
        Me.chk_PTN_NO_9.Text = ""
        Me.chk_PTN_NO_9.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_10
        '
        Me.chk_PTN_NO_10.AutoSize = True
        Me.chk_PTN_NO_10.Location = New System.Drawing.Point(400, 453)
        Me.chk_PTN_NO_10.Name = "chk_PTN_NO_10"
        Me.chk_PTN_NO_10.TabIndex = 41
        Me.chk_PTN_NO_10.Text = ""
        Me.chk_PTN_NO_10.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_11
        '
        Me.chk_PTN_NO_11.AutoSize = True
        Me.chk_PTN_NO_11.Location = New System.Drawing.Point(400, 468)
        Me.chk_PTN_NO_11.Name = "chk_PTN_NO_11"
        Me.chk_PTN_NO_11.TabIndex = 42
        Me.chk_PTN_NO_11.Text = ""
        Me.chk_PTN_NO_11.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_12
        '
        Me.chk_PTN_NO_12.AutoSize = True
        Me.chk_PTN_NO_12.Location = New System.Drawing.Point(551, 408)
        Me.chk_PTN_NO_12.Name = "chk_PTN_NO_12"
        Me.chk_PTN_NO_12.TabIndex = 43
        Me.chk_PTN_NO_12.Text = ""
        Me.chk_PTN_NO_12.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_13
        '
        Me.chk_PTN_NO_13.AutoSize = True
        Me.chk_PTN_NO_13.Location = New System.Drawing.Point(551, 423)
        Me.chk_PTN_NO_13.Name = "chk_PTN_NO_13"
        Me.chk_PTN_NO_13.TabIndex = 44
        Me.chk_PTN_NO_13.Text = ""
        Me.chk_PTN_NO_13.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_14
        '
        Me.chk_PTN_NO_14.AutoSize = True
        Me.chk_PTN_NO_14.Location = New System.Drawing.Point(551, 438)
        Me.chk_PTN_NO_14.Name = "chk_PTN_NO_14"
        Me.chk_PTN_NO_14.TabIndex = 45
        Me.chk_PTN_NO_14.Text = ""
        Me.chk_PTN_NO_14.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_15
        '
        Me.chk_PTN_NO_15.AutoSize = True
        Me.chk_PTN_NO_15.Location = New System.Drawing.Point(551, 453)
        Me.chk_PTN_NO_15.Name = "chk_PTN_NO_15"
        Me.chk_PTN_NO_15.TabIndex = 46
        Me.chk_PTN_NO_15.Text = ""
        Me.chk_PTN_NO_15.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_16
        '
        Me.chk_PTN_NO_16.AutoSize = True
        Me.chk_PTN_NO_16.Location = New System.Drawing.Point(551, 468)
        Me.chk_PTN_NO_16.Name = "chk_PTN_NO_16"
        Me.chk_PTN_NO_16.TabIndex = 47
        Me.chk_PTN_NO_16.Text = ""
        Me.chk_PTN_NO_16.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_17
        '
        Me.chk_PTN_NO_17.AutoSize = True
        Me.chk_PTN_NO_17.Location = New System.Drawing.Point(702, 408)
        Me.chk_PTN_NO_17.Name = "chk_PTN_NO_17"
        Me.chk_PTN_NO_17.TabIndex = 48
        Me.chk_PTN_NO_17.Text = ""
        Me.chk_PTN_NO_17.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_18
        '
        Me.chk_PTN_NO_18.AutoSize = True
        Me.chk_PTN_NO_18.Location = New System.Drawing.Point(702, 423)
        Me.chk_PTN_NO_18.Name = "chk_PTN_NO_18"
        Me.chk_PTN_NO_18.TabIndex = 49
        Me.chk_PTN_NO_18.Text = ""
        Me.chk_PTN_NO_18.UseVisualStyleBackColor = True
        '
        ' chk_PTN_NO_19
        '
        Me.chk_PTN_NO_19.AutoSize = True
        Me.chk_PTN_NO_19.Location = New System.Drawing.Point(702, 438)
        Me.chk_PTN_NO_19.Name = "chk_PTN_NO_19"
        Me.chk_PTN_NO_19.TabIndex = 50
        Me.chk_PTN_NO_19.Text = ""
        Me.chk_PTN_NO_19.UseVisualStyleBackColor = True
        '
        ' Form_fc_MYCOM_仕訳出力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 533)
        Me.Controls.Add(Me.chk_検索条件加味F)
        Me.Controls.Add(Me.chk_PTN_NO_1)
        Me.Controls.Add(Me.chk_PTN_NO_2)
        Me.Controls.Add(Me.chk_PTN_NO_3)
        Me.Controls.Add(Me.chk_PTN_NO_4)
        Me.Controls.Add(Me.chk_PTN_NO_5)
        Me.Controls.Add(Me.chk_PTN_NO_7)
        Me.Controls.Add(Me.chk_PTN_NO_8)
        Me.Controls.Add(Me.chk_PTN_NO_9)
        Me.Controls.Add(Me.chk_PTN_NO_10)
        Me.Controls.Add(Me.chk_PTN_NO_11)
        Me.Controls.Add(Me.chk_PTN_NO_12)
        Me.Controls.Add(Me.chk_PTN_NO_13)
        Me.Controls.Add(Me.chk_PTN_NO_14)
        Me.Controls.Add(Me.chk_PTN_NO_15)
        Me.Controls.Add(Me.chk_PTN_NO_16)
        Me.Controls.Add(Me.chk_PTN_NO_17)
        Me.Controls.Add(Me.chk_PTN_NO_18)
        Me.Controls.Add(Me.chk_PTN_NO_19)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.lbl_CHK_01)
        Me.Controls.Add(Me.lbl_CHK_01_F)
        Me.Controls.Add(Me.lbl_CHK_1)
        Me.Controls.Add(Me.lbl_CHK_2)
        Me.Controls.Add(Me.lbl_CHK_3)
        Me.Controls.Add(Me.lbl_CHK_4)
        Me.Controls.Add(Me.lbl_CHK_5)
        Me.Controls.Add(Me.lbl_出力対象仕訳)
        Me.Controls.Add(Me.lbl_CHK_7)
        Me.Controls.Add(Me.lbl_CHK_8)
        Me.Controls.Add(Me.lbl_CHK_9)
        Me.Controls.Add(Me.lbl_CHK_10)
        Me.Controls.Add(Me.lbl_CHK_11)
        Me.Controls.Add(Me.lbl_CHK_12)
        Me.Controls.Add(Me.lbl_CHK_13)
        Me.Controls.Add(Me.lbl_CHK_14)
        Me.Controls.Add(Me.lbl_CHK_15)
        Me.Controls.Add(Me.lbl_CHK_16)
        Me.Controls.Add(Me.lbl_CHK_17)
        Me.Controls.Add(Me.lbl_CHK_18)
        Me.Controls.Add(Me.lbl_CHK_19)
        Me.Controls.Add(Me.txt_FolderNm)
        Me.Controls.Add(Me.txt_計上曜日)
        Me.Controls.Add(Me.txt_計上日)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_FolderSel)
        Me.Controls.Add(Me.cmd_減損以外ON)
        Me.Controls.Add(Me.cmd_減損のみON)
        Me.Controls.Add(Me.cmd_会社追加)
        Me.Controls.Add(Me.cmd_会社変更)
        Me.Name = "Form_fc_MYCOM_仕訳出力"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "YYYY年MM月分　計上仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_FolderSel As System.Windows.Forms.Button
    Friend WithEvents cmd_減損以外ON As System.Windows.Forms.Button
    Friend WithEvents cmd_減損のみON As System.Windows.Forms.Button
    Friend WithEvents cmd_会社追加 As System.Windows.Forms.Button
    Friend WithEvents cmd_会社変更 As System.Windows.Forms.Button
    Friend WithEvents txt_FolderNm As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上曜日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01_F As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_4 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_5 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力対象仕訳 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_7 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_8 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_9 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_10 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_11 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_12 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_13 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_14 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_15 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_16 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_17 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_18 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_19 As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_3 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_4 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_7 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_8 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_9 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_10 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_11 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_12 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_13 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_14 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_15 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_16 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_17 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_18 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PTN_NO_19 As System.Windows.Forms.CheckBox

End Class