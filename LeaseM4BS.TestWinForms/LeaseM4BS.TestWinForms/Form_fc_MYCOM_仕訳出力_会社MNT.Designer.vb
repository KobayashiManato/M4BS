<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_MYCOM_仕訳出力_会社MNT

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
        Me.cmd_Close = New System.Windows.Forms.Button()
        Me.cmd_Touroku = New System.Windows.Forms.Button()
        Me.cmd_Del = New System.Windows.Forms.Button()
        Me.txt_会社CD = New System.Windows.Forms.TextBox()
        Me.txt_会社名 = New System.Windows.Forms.TextBox()
        Me.txt_Mode = New System.Windows.Forms.TextBox()
        Me.txt_起票部門CD = New System.Windows.Forms.TextBox()
        Me.txt_起票部門名 = New System.Windows.Forms.TextBox()
        Me.txt_計上部門CD = New System.Windows.Forms.TextBox()
        Me.txt_計上部門名 = New System.Windows.Forms.TextBox()
        Me.txt_仮払勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_仮払勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_仮払内訳CD = New System.Windows.Forms.TextBox()
        Me.txt_仮払内訳名 = New System.Windows.Forms.TextBox()
        Me.txt_関係会社立替勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_関係会社立替勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_経過勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_経過勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_伝票摘要 = New System.Windows.Forms.TextBox()
        Me.txt_明細摘要 = New System.Windows.Forms.TextBox()
        Me.txt_会社CD_SAVE = New System.Windows.Forms.TextBox()
        Me.txt_内訳名 = New System.Windows.Forms.TextBox()
        Me.txt_未払金勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_未払金勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_未払金内訳CD = New System.Windows.Forms.TextBox()
        Me.txt_未払金内訳名 = New System.Windows.Forms.TextBox()
        Me.txt_関係会社未収入金勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_関係会社未収入金勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_関係会社未払勘定CASH外名 = New System.Windows.Forms.TextBox()
        Me.txt_関係会社未払勘定CASH外CD = New System.Windows.Forms.TextBox()
        Me.txt_関係会社未払勘定名 = New System.Windows.Forms.TextBox()
        Me.txt_関係会社未払勘定CD = New System.Windows.Forms.TextBox()
        Me.txt_経過勘定2CD = New System.Windows.Forms.TextBox()
        Me.txt_経過勘定2名 = New System.Windows.Forms.TextBox()
        Me.txt_伝票摘要2 = New System.Windows.Forms.TextBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル38 = New System.Windows.Forms.Label()
        Me.ラベル63 = New System.Windows.Forms.Label()
        Me.ラベル68 = New System.Windows.Forms.Label()
        Me.ラベル71 = New System.Windows.Forms.Label()
        Me.ラベル74 = New System.Windows.Forms.Label()
        Me.ラベル77 = New System.Windows.Forms.Label()
        Me.ラベル79 = New System.Windows.Forms.Label()
        Me.ラベル86 = New System.Windows.Forms.Label()
        Me.ラベル93 = New System.Windows.Forms.Label()
        Me.ラベル95 = New System.Windows.Forms.Label()
        Me.ラベル98 = New System.Windows.Forms.Label()
        Me.ラベル100 = New System.Windows.Forms.Label()
        Me.ラベル103 = New System.Windows.Forms.Label()
        Me.ラベル104 = New System.Windows.Forms.Label()
        Me.ラベル105 = New System.Windows.Forms.Label()
        Me.ラベル107 = New System.Windows.Forms.Label()
        Me.ラベル110 = New System.Windows.Forms.Label()
        Me.ラベル112 = New System.Windows.Forms.Label()
        Me.ラベル115 = New System.Windows.Forms.Label()
        Me.ラベル116 = New System.Windows.Forms.Label()
        Me.ラベル118 = New System.Windows.Forms.Label()
        Me.ラベル121 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Close
        '
        Me.cmd_Close.Location = New System.Drawing.Point(3, 3)
        Me.cmd_Close.Name = "cmd_Close"
        Me.cmd_Close.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Close.TabIndex = 0
        Me.cmd_Close.Text = "閉じる(&C)"
        Me.cmd_Close.UseVisualStyleBackColor = True
        '
        ' cmd_Touroku
        '
        Me.cmd_Touroku.Location = New System.Drawing.Point(83, 3)
        Me.cmd_Touroku.Name = "cmd_Touroku"
        Me.cmd_Touroku.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Touroku.TabIndex = 1
        Me.cmd_Touroku.Text = "登録(&S)"
        Me.cmd_Touroku.UseVisualStyleBackColor = True
        '
        ' cmd_Del
        '
        Me.cmd_Del.Location = New System.Drawing.Point(162, 3)
        Me.cmd_Del.Name = "cmd_Del"
        Me.cmd_Del.Size = New System.Drawing.Size(75, 26)
        Me.cmd_Del.TabIndex = 2
        Me.cmd_Del.Text = "削除(&D)"
        Me.cmd_Del.UseVisualStyleBackColor = True
        '
        ' txt_会社CD
        '
        Me.txt_会社CD.Location = New System.Drawing.Point(215, 56)
        Me.txt_会社CD.Name = "txt_会社CD"
        Me.txt_会社CD.Size = New System.Drawing.Size(94, 19)
        Me.txt_会社CD.TabIndex = 3
        '
        ' txt_会社名
        '
        Me.txt_会社名.Location = New System.Drawing.Point(215, 102)
        Me.txt_会社名.Name = "txt_会社名"
        Me.txt_会社名.Size = New System.Drawing.Size(264, 19)
        Me.txt_会社名.TabIndex = 4
        '
        ' txt_Mode
        '
        Me.txt_Mode.Location = New System.Drawing.Point(472, 7)
        Me.txt_Mode.Name = "txt_Mode"
        Me.txt_Mode.Size = New System.Drawing.Size(56, 19)
        Me.txt_Mode.TabIndex = 5
        '
        ' txt_起票部門CD
        '
        Me.txt_起票部門CD.Location = New System.Drawing.Point(215, 200)
        Me.txt_起票部門CD.Name = "txt_起票部門CD"
        Me.txt_起票部門CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_起票部門CD.TabIndex = 6
        '
        ' txt_起票部門名
        '
        Me.txt_起票部門名.Location = New System.Drawing.Point(291, 200)
        Me.txt_起票部門名.Name = "txt_起票部門名"
        Me.txt_起票部門名.Size = New System.Drawing.Size(189, 19)
        Me.txt_起票部門名.TabIndex = 7
        '
        ' txt_計上部門CD
        '
        Me.txt_計上部門CD.Location = New System.Drawing.Point(215, 226)
        Me.txt_計上部門CD.Name = "txt_計上部門CD"
        Me.txt_計上部門CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_計上部門CD.TabIndex = 8
        '
        ' txt_計上部門名
        '
        Me.txt_計上部門名.Location = New System.Drawing.Point(291, 226)
        Me.txt_計上部門名.Name = "txt_計上部門名"
        Me.txt_計上部門名.Size = New System.Drawing.Size(189, 19)
        Me.txt_計上部門名.TabIndex = 9
        '
        ' txt_仮払勘定CD
        '
        Me.txt_仮払勘定CD.Location = New System.Drawing.Point(215, 253)
        Me.txt_仮払勘定CD.Name = "txt_仮払勘定CD"
        Me.txt_仮払勘定CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_仮払勘定CD.TabIndex = 10
        '
        ' txt_仮払勘定名
        '
        Me.txt_仮払勘定名.Location = New System.Drawing.Point(291, 253)
        Me.txt_仮払勘定名.Name = "txt_仮払勘定名"
        Me.txt_仮払勘定名.Size = New System.Drawing.Size(189, 19)
        Me.txt_仮払勘定名.TabIndex = 11
        '
        ' txt_仮払内訳CD
        '
        Me.txt_仮払内訳CD.Location = New System.Drawing.Point(215, 272)
        Me.txt_仮払内訳CD.Name = "txt_仮払内訳CD"
        Me.txt_仮払内訳CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_仮払内訳CD.TabIndex = 12
        '
        ' txt_仮払内訳名
        '
        Me.txt_仮払内訳名.Location = New System.Drawing.Point(291, 272)
        Me.txt_仮払内訳名.Name = "txt_仮払内訳名"
        Me.txt_仮払内訳名.Size = New System.Drawing.Size(189, 19)
        Me.txt_仮払内訳名.TabIndex = 13
        '
        ' txt_関係会社立替勘定CD
        '
        Me.txt_関係会社立替勘定CD.Location = New System.Drawing.Point(215, 343)
        Me.txt_関係会社立替勘定CD.Name = "txt_関係会社立替勘定CD"
        Me.txt_関係会社立替勘定CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_関係会社立替勘定CD.TabIndex = 14
        '
        ' txt_関係会社立替勘定名
        '
        Me.txt_関係会社立替勘定名.Location = New System.Drawing.Point(291, 343)
        Me.txt_関係会社立替勘定名.Name = "txt_関係会社立替勘定名"
        Me.txt_関係会社立替勘定名.Size = New System.Drawing.Size(189, 19)
        Me.txt_関係会社立替勘定名.TabIndex = 15
        '
        ' txt_経過勘定CD
        '
        Me.txt_経過勘定CD.Location = New System.Drawing.Point(215, 449)
        Me.txt_経過勘定CD.Name = "txt_経過勘定CD"
        Me.txt_経過勘定CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_経過勘定CD.TabIndex = 16
        '
        ' txt_経過勘定名
        '
        Me.txt_経過勘定名.Location = New System.Drawing.Point(291, 449)
        Me.txt_経過勘定名.Name = "txt_経過勘定名"
        Me.txt_経過勘定名.Size = New System.Drawing.Size(189, 19)
        Me.txt_経過勘定名.TabIndex = 17
        '
        ' txt_伝票摘要
        '
        Me.txt_伝票摘要.Location = New System.Drawing.Point(215, 502)
        Me.txt_伝票摘要.Name = "txt_伝票摘要"
        Me.txt_伝票摘要.Size = New System.Drawing.Size(264, 19)
        Me.txt_伝票摘要.TabIndex = 18
        '
        ' txt_明細摘要
        '
        Me.txt_明細摘要.Location = New System.Drawing.Point(215, 559)
        Me.txt_明細摘要.Name = "txt_明細摘要"
        Me.txt_明細摘要.Size = New System.Drawing.Size(264, 19)
        Me.txt_明細摘要.TabIndex = 19
        '
        ' txt_会社CD_SAVE
        '
        Me.txt_会社CD_SAVE.Location = New System.Drawing.Point(321, 56)
        Me.txt_会社CD_SAVE.Name = "txt_会社CD_SAVE"
        Me.txt_会社CD_SAVE.Size = New System.Drawing.Size(75, 19)
        Me.txt_会社CD_SAVE.TabIndex = 20
        '
        ' txt_内訳名
        '
        Me.txt_内訳名.Location = New System.Drawing.Point(215, 128)
        Me.txt_内訳名.Name = "txt_内訳名"
        Me.txt_内訳名.Size = New System.Drawing.Size(264, 19)
        Me.txt_内訳名.TabIndex = 21
        '
        ' txt_未払金勘定CD
        '
        Me.txt_未払金勘定CD.Location = New System.Drawing.Point(215, 298)
        Me.txt_未払金勘定CD.Name = "txt_未払金勘定CD"
        Me.txt_未払金勘定CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_未払金勘定CD.TabIndex = 22
        '
        ' txt_未払金勘定名
        '
        Me.txt_未払金勘定名.Location = New System.Drawing.Point(291, 298)
        Me.txt_未払金勘定名.Name = "txt_未払金勘定名"
        Me.txt_未払金勘定名.Size = New System.Drawing.Size(189, 19)
        Me.txt_未払金勘定名.TabIndex = 23
        '
        ' txt_未払金内訳CD
        '
        Me.txt_未払金内訳CD.Location = New System.Drawing.Point(215, 317)
        Me.txt_未払金内訳CD.Name = "txt_未払金内訳CD"
        Me.txt_未払金内訳CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_未払金内訳CD.TabIndex = 24
        '
        ' txt_未払金内訳名
        '
        Me.txt_未払金内訳名.Location = New System.Drawing.Point(291, 317)
        Me.txt_未払金内訳名.Name = "txt_未払金内訳名"
        Me.txt_未払金内訳名.Size = New System.Drawing.Size(189, 19)
        Me.txt_未払金内訳名.TabIndex = 25
        '
        ' txt_関係会社未収入金勘定CD
        '
        Me.txt_関係会社未収入金勘定CD.Location = New System.Drawing.Point(215, 370)
        Me.txt_関係会社未収入金勘定CD.Name = "txt_関係会社未収入金勘定CD"
        Me.txt_関係会社未収入金勘定CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_関係会社未収入金勘定CD.TabIndex = 26
        '
        ' txt_関係会社未収入金勘定名
        '
        Me.txt_関係会社未収入金勘定名.Location = New System.Drawing.Point(291, 370)
        Me.txt_関係会社未収入金勘定名.Name = "txt_関係会社未収入金勘定名"
        Me.txt_関係会社未収入金勘定名.Size = New System.Drawing.Size(189, 19)
        Me.txt_関係会社未収入金勘定名.TabIndex = 27
        '
        ' txt_関係会社未払勘定CASH外名
        '
        Me.txt_関係会社未払勘定CASH外名.Location = New System.Drawing.Point(291, 423)
        Me.txt_関係会社未払勘定CASH外名.Name = "txt_関係会社未払勘定CASH外名"
        Me.txt_関係会社未払勘定CASH外名.Size = New System.Drawing.Size(189, 19)
        Me.txt_関係会社未払勘定CASH外名.TabIndex = 28
        '
        ' txt_関係会社未払勘定CASH外CD
        '
        Me.txt_関係会社未払勘定CASH外CD.Location = New System.Drawing.Point(215, 423)
        Me.txt_関係会社未払勘定CASH外CD.Name = "txt_関係会社未払勘定CASH外CD"
        Me.txt_関係会社未払勘定CASH外CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_関係会社未払勘定CASH外CD.TabIndex = 29
        '
        ' txt_関係会社未払勘定名
        '
        Me.txt_関係会社未払勘定名.Location = New System.Drawing.Point(291, 396)
        Me.txt_関係会社未払勘定名.Name = "txt_関係会社未払勘定名"
        Me.txt_関係会社未払勘定名.Size = New System.Drawing.Size(189, 19)
        Me.txt_関係会社未払勘定名.TabIndex = 30
        '
        ' txt_関係会社未払勘定CD
        '
        Me.txt_関係会社未払勘定CD.Location = New System.Drawing.Point(215, 396)
        Me.txt_関係会社未払勘定CD.Name = "txt_関係会社未払勘定CD"
        Me.txt_関係会社未払勘定CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_関係会社未払勘定CD.TabIndex = 31
        '
        ' txt_経過勘定2CD
        '
        Me.txt_経過勘定2CD.Location = New System.Drawing.Point(215, 476)
        Me.txt_経過勘定2CD.Name = "txt_経過勘定2CD"
        Me.txt_経過勘定2CD.Size = New System.Drawing.Size(75, 19)
        Me.txt_経過勘定2CD.TabIndex = 32
        '
        ' txt_経過勘定2名
        '
        Me.txt_経過勘定2名.Location = New System.Drawing.Point(291, 476)
        Me.txt_経過勘定2名.Name = "txt_経過勘定2名"
        Me.txt_経過勘定2名.Size = New System.Drawing.Size(189, 19)
        Me.txt_経過勘定2名.TabIndex = 33
        '
        ' txt_伝票摘要2
        '
        Me.txt_伝票摘要2.Location = New System.Drawing.Point(215, 529)
        Me.txt_伝票摘要2.Name = "txt_伝票摘要2"
        Me.txt_伝票摘要2.Size = New System.Drawing.Size(264, 19)
        Me.txt_伝票摘要2.TabIndex = 34
        '
        ' Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(7, 56)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.TabIndex = 35
        Me.Lbl.Text = "会社ｺｰﾄﾞ"
        '
        ' ラベル38
        '
        Me.ラベル38.AutoSize = True
        Me.ラベル38.Location = New System.Drawing.Point(7, 102)
        Me.ラベル38.Name = "ラベル38"
        Me.ラベル38.TabIndex = 36
        Me.ラベル38.Text = "会社名"
        '
        ' ラベル63
        '
        Me.ラベル63.AutoSize = True
        Me.ラベル63.Location = New System.Drawing.Point(7, 173)
        Me.ラベル63.Name = "ラベル63"
        Me.ラベル63.TabIndex = 37
        Me.ラベル63.Text = "会社区分"
        '
        ' ラベル68
        '
        Me.ラベル68.AutoSize = True
        Me.ラベル68.Location = New System.Drawing.Point(7, 200)
        Me.ラベル68.Name = "ラベル68"
        Me.ラベル68.TabIndex = 38
        Me.ラベル68.Text = "起票部門"
        '
        ' ラベル71
        '
        Me.ラベル71.AutoSize = True
        Me.ラベル71.Location = New System.Drawing.Point(7, 226)
        Me.ラベル71.Name = "ラベル71"
        Me.ラベル71.TabIndex = 39
        Me.ラベル71.Text = "計上部門"
        '
        ' ラベル74
        '
        Me.ラベル74.AutoSize = True
        Me.ラベル74.Location = New System.Drawing.Point(7, 253)
        Me.ラベル74.Name = "ラベル74"
        Me.ラベル74.TabIndex = 40
        Me.ラベル74.Text = "仮払金"
        '
        ' ラベル77
        '
        Me.ラベル77.AutoSize = True
        Me.ラベル77.Location = New System.Drawing.Point(120, 272)
        Me.ラベル77.Name = "ラベル77"
        Me.ラベル77.TabIndex = 41
        Me.ラベル77.Text = "内訳"
        '
        ' ラベル79
        '
        Me.ラベル79.AutoSize = True
        Me.ラベル79.Location = New System.Drawing.Point(120, 253)
        Me.ラベル79.Name = "ラベル79"
        Me.ラベル79.TabIndex = 42
        Me.ラベル79.Text = "勘定科目"
        '
        ' ラベル86
        '
        Me.ラベル86.AutoSize = True
        Me.ラベル86.Location = New System.Drawing.Point(7, 343)
        Me.ラベル86.Name = "ラベル86"
        Me.ラベル86.TabIndex = 43
        Me.ラベル86.Text = "関係会社立替金勘定科目"
        '
        ' ラベル93
        '
        Me.ラベル93.AutoSize = True
        Me.ラベル93.Location = New System.Drawing.Point(7, 396)
        Me.ラベル93.Name = "ラベル93"
        Me.ラベル93.TabIndex = 44
        Me.ラベル93.Text = "関係会社未払金(ｼｽﾃﾑ外)勘定科目"
        '
        ' ラベル95
        '
        Me.ラベル95.AutoSize = True
        Me.ラベル95.Location = New System.Drawing.Point(7, 449)
        Me.ラベル95.Name = "ラベル95"
        Me.ラベル95.TabIndex = 45
        Me.ラベル95.Text = "貸借経過(資金)勘定科目"
        '
        ' ラベル98
        '
        Me.ラベル98.AutoSize = True
        Me.ラベル98.Location = New System.Drawing.Point(7, 502)
        Me.ラベル98.Name = "ラベル98"
        Me.ラベル98.TabIndex = 46
        Me.ラベル98.Text = "伝票摘要"
        '
        ' ラベル100
        '
        Me.ラベル100.AutoSize = True
        Me.ラベル100.Location = New System.Drawing.Point(7, 559)
        Me.ラベル100.Name = "ラベル100"
        Me.ラベル100.TabIndex = 47
        Me.ラベル100.Text = "明細摘要(集計出力用)"
        '
        ' ラベル103
        '
        Me.ラベル103.AutoSize = True
        Me.ラベル103.Location = New System.Drawing.Point(7, 128)
        Me.ラベル103.Name = "ラベル103"
        Me.ラベル103.TabIndex = 48
        Me.ラベル103.Text = "内訳名(会社略称)"
        '
        ' ラベル104
        '
        Me.ラベル104.AutoSize = True
        Me.ラベル104.Location = New System.Drawing.Point(75, 151)
        Me.ラベル104.Name = "ラベル104"
        Me.ラベル104.TabIndex = 49
        Me.ラベル104.Text = "関係会社立替金、関係会社未収入金、関係会社未払金 の内訳名に使用します。"
        '
        ' ラベル105
        '
        Me.ラベル105.AutoSize = True
        Me.ラベル105.Location = New System.Drawing.Point(75, 79)
        Me.ラベル105.Name = "ラベル105"
        Me.ラベル105.TabIndex = 50
        Me.ラベル105.Text = "関係会社立替金、関係会社未収入金、関係会社未払金 の内訳CDに使用します。"
        '
        ' ラベル107
        '
        Me.ラベル107.AutoSize = True
        Me.ラベル107.Location = New System.Drawing.Point(7, 298)
        Me.ラベル107.Name = "ラベル107"
        Me.ラベル107.TabIndex = 51
        Me.ラベル107.Text = "未払金"
        '
        ' ラベル110
        '
        Me.ラベル110.AutoSize = True
        Me.ラベル110.Location = New System.Drawing.Point(120, 317)
        Me.ラベル110.Name = "ラベル110"
        Me.ラベル110.TabIndex = 52
        Me.ラベル110.Text = "内訳"
        '
        ' ラベル112
        '
        Me.ラベル112.AutoSize = True
        Me.ラベル112.Location = New System.Drawing.Point(120, 298)
        Me.ラベル112.Name = "ラベル112"
        Me.ラベル112.TabIndex = 53
        Me.ラベル112.Text = "勘定科目"
        '
        ' ラベル115
        '
        Me.ラベル115.AutoSize = True
        Me.ラベル115.Location = New System.Drawing.Point(7, 370)
        Me.ラベル115.Name = "ラベル115"
        Me.ラベル115.TabIndex = 54
        Me.ラベル115.Text = "関係会社未収入金勘定科目"
        '
        ' ラベル116
        '
        Me.ラベル116.AutoSize = True
        Me.ラベル116.Location = New System.Drawing.Point(7, 423)
        Me.ラベル116.Name = "ラベル116"
        Me.ラベル116.TabIndex = 55
        Me.ラベル116.Text = "関係会社未払金(CASH外)勘定科目"
        '
        ' ラベル118
        '
        Me.ラベル118.AutoSize = True
        Me.ラベル118.Location = New System.Drawing.Point(7, 476)
        Me.ラベル118.Name = "ラベル118"
        Me.ラベル118.TabIndex = 56
        Me.ラベル118.Text = "貸借経過(非資金)勘定科目"
        '
        ' ラベル121
        '
        Me.ラベル121.AutoSize = True
        Me.ラベル121.Location = New System.Drawing.Point(7, 529)
        Me.ラベル121.Name = "ラベル121"
        Me.ラベル121.TabIndex = 57
        Me.ラベル121.Text = "伝票摘要(翌月支払用)"
        '
        ' Form_fc_MYCOM_仕訳出力_会社MNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 627)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル38)
        Me.Controls.Add(Me.ラベル63)
        Me.Controls.Add(Me.ラベル68)
        Me.Controls.Add(Me.ラベル71)
        Me.Controls.Add(Me.ラベル74)
        Me.Controls.Add(Me.ラベル77)
        Me.Controls.Add(Me.ラベル79)
        Me.Controls.Add(Me.ラベル86)
        Me.Controls.Add(Me.ラベル93)
        Me.Controls.Add(Me.ラベル95)
        Me.Controls.Add(Me.ラベル98)
        Me.Controls.Add(Me.ラベル100)
        Me.Controls.Add(Me.ラベル103)
        Me.Controls.Add(Me.ラベル104)
        Me.Controls.Add(Me.ラベル105)
        Me.Controls.Add(Me.ラベル107)
        Me.Controls.Add(Me.ラベル110)
        Me.Controls.Add(Me.ラベル112)
        Me.Controls.Add(Me.ラベル115)
        Me.Controls.Add(Me.ラベル116)
        Me.Controls.Add(Me.ラベル118)
        Me.Controls.Add(Me.ラベル121)
        Me.Controls.Add(Me.txt_会社CD)
        Me.Controls.Add(Me.txt_会社名)
        Me.Controls.Add(Me.txt_Mode)
        Me.Controls.Add(Me.txt_起票部門CD)
        Me.Controls.Add(Me.txt_起票部門名)
        Me.Controls.Add(Me.txt_計上部門CD)
        Me.Controls.Add(Me.txt_計上部門名)
        Me.Controls.Add(Me.txt_仮払勘定CD)
        Me.Controls.Add(Me.txt_仮払勘定名)
        Me.Controls.Add(Me.txt_仮払内訳CD)
        Me.Controls.Add(Me.txt_仮払内訳名)
        Me.Controls.Add(Me.txt_関係会社立替勘定CD)
        Me.Controls.Add(Me.txt_関係会社立替勘定名)
        Me.Controls.Add(Me.txt_経過勘定CD)
        Me.Controls.Add(Me.txt_経過勘定名)
        Me.Controls.Add(Me.txt_伝票摘要)
        Me.Controls.Add(Me.txt_明細摘要)
        Me.Controls.Add(Me.txt_会社CD_SAVE)
        Me.Controls.Add(Me.txt_内訳名)
        Me.Controls.Add(Me.txt_未払金勘定CD)
        Me.Controls.Add(Me.txt_未払金勘定名)
        Me.Controls.Add(Me.txt_未払金内訳CD)
        Me.Controls.Add(Me.txt_未払金内訳名)
        Me.Controls.Add(Me.txt_関係会社未収入金勘定CD)
        Me.Controls.Add(Me.txt_関係会社未収入金勘定名)
        Me.Controls.Add(Me.txt_関係会社未払勘定CASH外名)
        Me.Controls.Add(Me.txt_関係会社未払勘定CASH外CD)
        Me.Controls.Add(Me.txt_関係会社未払勘定名)
        Me.Controls.Add(Me.txt_関係会社未払勘定CD)
        Me.Controls.Add(Me.txt_経過勘定2CD)
        Me.Controls.Add(Me.txt_経過勘定2名)
        Me.Controls.Add(Me.txt_伝票摘要2)
        Me.Controls.Add(Me.cmd_Close)
        Me.Controls.Add(Me.cmd_Touroku)
        Me.Controls.Add(Me.cmd_Del)
        Me.Name = "Form_fc_MYCOM_仕訳出力_会社MNT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳固定値設定テーブルメンテナンス"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Close As System.Windows.Forms.Button
    Friend WithEvents cmd_Touroku As System.Windows.Forms.Button
    Friend WithEvents cmd_Del As System.Windows.Forms.Button
    Friend WithEvents txt_会社CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_会社名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mode As System.Windows.Forms.TextBox
    Friend WithEvents txt_起票部門CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_起票部門名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上部門CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上部門名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮払勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮払勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮払内訳CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_仮払内訳名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社立替勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社立替勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_経過勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_経過勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_伝票摘要 As System.Windows.Forms.TextBox
    Friend WithEvents txt_明細摘要 As System.Windows.Forms.TextBox
    Friend WithEvents txt_会社CD_SAVE As System.Windows.Forms.TextBox
    Friend WithEvents txt_内訳名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金内訳CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_未払金内訳名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社未収入金勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社未収入金勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社未払勘定CASH外名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社未払勘定CASH外CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社未払勘定名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_関係会社未払勘定CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_経過勘定2CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_経過勘定2名 As System.Windows.Forms.TextBox
    Friend WithEvents txt_伝票摘要2 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents ラベル38 As System.Windows.Forms.Label
    Friend WithEvents ラベル63 As System.Windows.Forms.Label
    Friend WithEvents ラベル68 As System.Windows.Forms.Label
    Friend WithEvents ラベル71 As System.Windows.Forms.Label
    Friend WithEvents ラベル74 As System.Windows.Forms.Label
    Friend WithEvents ラベル77 As System.Windows.Forms.Label
    Friend WithEvents ラベル79 As System.Windows.Forms.Label
    Friend WithEvents ラベル86 As System.Windows.Forms.Label
    Friend WithEvents ラベル93 As System.Windows.Forms.Label
    Friend WithEvents ラベル95 As System.Windows.Forms.Label
    Friend WithEvents ラベル98 As System.Windows.Forms.Label
    Friend WithEvents ラベル100 As System.Windows.Forms.Label
    Friend WithEvents ラベル103 As System.Windows.Forms.Label
    Friend WithEvents ラベル104 As System.Windows.Forms.Label
    Friend WithEvents ラベル105 As System.Windows.Forms.Label
    Friend WithEvents ラベル107 As System.Windows.Forms.Label
    Friend WithEvents ラベル110 As System.Windows.Forms.Label
    Friend WithEvents ラベル112 As System.Windows.Forms.Label
    Friend WithEvents ラベル115 As System.Windows.Forms.Label
    Friend WithEvents ラベル116 As System.Windows.Forms.Label
    Friend WithEvents ラベル118 As System.Windows.Forms.Label
    Friend WithEvents ラベル121 As System.Windows.Forms.Label

End Class