<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SNKO_仕訳出力_最終確認

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
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_選択 = New System.Windows.Forms.Button()
        Me.txt_計上日 = New System.Windows.Forms.TextBox()
        Me.txt_計上日_曜日 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FPATH = New System.Windows.Forms.TextBox()
        Me.txt_仕訳_ID = New System.Windows.Forms.TextBox()
        Me.LINE_ID = New System.Windows.Forms.TextBox()
        Me.貸借区分 = New System.Windows.Forms.TextBox()
        Me.勘定科目CD = New System.Windows.Forms.TextBox()
        Me.勘定科目 = New System.Windows.Forms.TextBox()
        Me.予算組織CD = New System.Windows.Forms.TextBox()
        Me.予算組織 = New System.Windows.Forms.TextBox()
        Me.使用者社員番号 = New System.Windows.Forms.TextBox()
        Me.MAPCD = New System.Windows.Forms.TextBox()
        Me.MAP = New System.Windows.Forms.TextBox()
        Me.品目CD = New System.Windows.Forms.TextBox()
        Me.品目 = New System.Windows.Forms.TextBox()
        Me.金額 = New System.Windows.Forms.TextBox()
        Me.消費税CD = New System.Windows.Forms.TextBox()
        Me.消費税額 = New System.Windows.Forms.TextBox()
        Me.個別摘要 = New System.Windows.Forms.TextBox()
        Me.txt_借方金額_SUM = New System.Windows.Forms.TextBox()
        Me.txt_貸方金額_SUM = New System.Windows.Forms.TextBox()
        Me.LINE_ID_ラベル = New System.Windows.Forms.Label()
        Me.貸借区分_ラベル = New System.Windows.Forms.Label()
        Me.勘定科目CD_ラベル = New System.Windows.Forms.Label()
        Me.勘定科目_ラベル = New System.Windows.Forms.Label()
        Me.予算組織CD_ラベル = New System.Windows.Forms.Label()
        Me.予算組織_ラベル = New System.Windows.Forms.Label()
        Me.使用者社員番号_ラベル = New System.Windows.Forms.Label()
        Me.MAPCD_ラベル = New System.Windows.Forms.Label()
        Me.MAP_ラベル = New System.Windows.Forms.Label()
        Me.品目CD_ラベル = New System.Windows.Forms.Label()
        Me.品目_ラベル = New System.Windows.Forms.Label()
        Me.金額_ラベル = New System.Windows.Forms.Label()
        Me.消費税CD_ラベル = New System.Windows.Forms.Label()
        Me.消費税額_ラベル = New System.Windows.Forms.Label()
        Me.個別摘要_ラベル = New System.Windows.Forms.Label()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル523 = New System.Windows.Forms.Label()
        Me.ラベル34 = New System.Windows.Forms.Label()
        Me.ラベル35 = New System.Windows.Forms.Label()
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
        ' cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(264, 7)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(75, 26)
        Me.cmd_FlexReportDLG.TabIndex = 2
        Me.cmd_FlexReportDLG.Text = "印刷(&P)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(702, 56)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 3
        Me.cmd_選択.Text = "選択"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_計上日
        '
        Me.txt_計上日.Location = New System.Drawing.Point(113, 56)
        Me.txt_計上日.Name = "txt_計上日"
        Me.txt_計上日.Size = New System.Drawing.Size(75, 19)
        Me.txt_計上日.TabIndex = 4
        '
        ' txt_計上日_曜日
        '
        Me.txt_計上日_曜日.Location = New System.Drawing.Point(188, 56)
        Me.txt_計上日_曜日.Name = "txt_計上日_曜日"
        Me.txt_計上日_曜日.Size = New System.Drawing.Size(50, 19)
        Me.txt_計上日_曜日.TabIndex = 5
        '
        ' txt_OUTPUT_FPATH
        '
        Me.txt_OUTPUT_FPATH.Location = New System.Drawing.Point(321, 56)
        Me.txt_OUTPUT_FPATH.Name = "txt_OUTPUT_FPATH"
        Me.txt_OUTPUT_FPATH.Size = New System.Drawing.Size(378, 19)
        Me.txt_OUTPUT_FPATH.TabIndex = 6
        '
        ' txt_仕訳_ID
        '
        Me.txt_仕訳_ID.Location = New System.Drawing.Point(377, 11)
        Me.txt_仕訳_ID.Name = "txt_仕訳_ID"
        Me.txt_仕訳_ID.Size = New System.Drawing.Size(75, 19)
        Me.txt_仕訳_ID.TabIndex = 7
        '
        ' LINE_ID
        '
        Me.LINE_ID.Location = New System.Drawing.Point(3, 0)
        Me.LINE_ID.Name = "LINE_ID"
        Me.LINE_ID.Size = New System.Drawing.Size(50, 19)
        Me.LINE_ID.TabIndex = 8
        '
        ' 貸借区分
        '
        Me.貸借区分.Location = New System.Drawing.Point(41, 0)
        Me.貸借区分.Name = "貸借区分"
        Me.貸借区分.Size = New System.Drawing.Size(50, 19)
        Me.貸借区分.TabIndex = 9
        '
        ' 勘定科目CD
        '
        Me.勘定科目CD.Location = New System.Drawing.Point(79, 0)
        Me.勘定科目CD.Name = "勘定科目CD"
        Me.勘定科目CD.Size = New System.Drawing.Size(56, 19)
        Me.勘定科目CD.TabIndex = 10
        '
        ' 勘定科目
        '
        Me.勘定科目.Location = New System.Drawing.Point(136, 0)
        Me.勘定科目.Name = "勘定科目"
        Me.勘定科目.Size = New System.Drawing.Size(132, 19)
        Me.勘定科目.TabIndex = 11
        '
        ' 予算組織CD
        '
        Me.予算組織CD.Location = New System.Drawing.Point(268, 0)
        Me.予算組織CD.Name = "予算組織CD"
        Me.予算組織CD.Size = New System.Drawing.Size(56, 19)
        Me.予算組織CD.TabIndex = 12
        '
        ' 予算組織
        '
        Me.予算組織.Location = New System.Drawing.Point(325, 0)
        Me.予算組織.Name = "予算組織"
        Me.予算組織.Size = New System.Drawing.Size(132, 19)
        Me.予算組織.TabIndex = 13
        '
        ' 使用者社員番号
        '
        Me.使用者社員番号.Location = New System.Drawing.Point(457, 0)
        Me.使用者社員番号.Name = "使用者社員番号"
        Me.使用者社員番号.Size = New System.Drawing.Size(86, 19)
        Me.使用者社員番号.TabIndex = 14
        '
        ' MAPCD
        '
        Me.MAPCD.Location = New System.Drawing.Point(544, 0)
        Me.MAPCD.Name = "MAPCD"
        Me.MAPCD.Size = New System.Drawing.Size(56, 19)
        Me.MAPCD.TabIndex = 15
        '
        ' MAP
        '
        Me.MAP.Location = New System.Drawing.Point(600, 0)
        Me.MAP.Name = "MAP"
        Me.MAP.Size = New System.Drawing.Size(132, 19)
        Me.MAP.TabIndex = 16
        '
        ' 品目CD
        '
        Me.品目CD.Location = New System.Drawing.Point(733, 0)
        Me.品目CD.Name = "品目CD"
        Me.品目CD.Size = New System.Drawing.Size(56, 19)
        Me.品目CD.TabIndex = 17
        '
        ' 品目
        '
        Me.品目.Location = New System.Drawing.Point(789, 0)
        Me.品目.Name = "品目"
        Me.品目.Size = New System.Drawing.Size(132, 19)
        Me.品目.TabIndex = 18
        '
        ' 金額
        '
        Me.金額.Location = New System.Drawing.Point(922, 0)
        Me.金額.Name = "金額"
        Me.金額.Size = New System.Drawing.Size(94, 19)
        Me.金額.TabIndex = 19
        '
        ' 消費税CD
        '
        Me.消費税CD.Location = New System.Drawing.Point(1016, 0)
        Me.消費税CD.Name = "消費税CD"
        Me.消費税CD.Size = New System.Drawing.Size(50, 19)
        Me.消費税CD.TabIndex = 20
        '
        ' 消費税額
        '
        Me.消費税額.Location = New System.Drawing.Point(1062, 0)
        Me.消費税額.Name = "消費税額"
        Me.消費税額.Size = New System.Drawing.Size(75, 19)
        Me.消費税額.TabIndex = 21
        '
        ' 個別摘要
        '
        Me.個別摘要.Location = New System.Drawing.Point(1137, 0)
        Me.個別摘要.Name = "個別摘要"
        Me.個別摘要.Size = New System.Drawing.Size(189, 19)
        Me.個別摘要.TabIndex = 22
        '
        ' txt_借方金額_SUM
        '
        Me.txt_借方金額_SUM.Location = New System.Drawing.Point(922, 3)
        Me.txt_借方金額_SUM.Name = "txt_借方金額_SUM"
        Me.txt_借方金額_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_借方金額_SUM.TabIndex = 23
        '
        ' txt_貸方金額_SUM
        '
        Me.txt_貸方金額_SUM.Location = New System.Drawing.Point(922, 22)
        Me.txt_貸方金額_SUM.Name = "txt_貸方金額_SUM"
        Me.txt_貸方金額_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_貸方金額_SUM.TabIndex = 24
        '
        ' LINE_ID_ラベル
        '
        Me.LINE_ID_ラベル.AutoSize = True
        Me.LINE_ID_ラベル.Location = New System.Drawing.Point(3, 83)
        Me.LINE_ID_ラベル.Name = "LINE_ID_ラベル"
        Me.LINE_ID_ラベル.TabIndex = 25
        Me.LINE_ID_ラベル.Text = "No."
        '
        ' 貸借区分_ラベル
        '
        Me.貸借区分_ラベル.AutoSize = True
        Me.貸借区分_ラベル.Location = New System.Drawing.Point(41, 83)
        Me.貸借区分_ラベル.Name = "貸借区分_ラベル"
        Me.貸借区分_ラベル.TabIndex = 26
        Me.貸借区分_ラベル.Text = "貸借\015\012区分"
        '
        ' 勘定科目CD_ラベル
        '
        Me.勘定科目CD_ラベル.AutoSize = True
        Me.勘定科目CD_ラベル.Location = New System.Drawing.Point(79, 83)
        Me.勘定科目CD_ラベル.Name = "勘定科目CD_ラベル"
        Me.勘定科目CD_ラベル.TabIndex = 27
        Me.勘定科目CD_ラベル.Text = "勘定科目\015\012CD"
        '
        ' 勘定科目_ラベル
        '
        Me.勘定科目_ラベル.AutoSize = True
        Me.勘定科目_ラベル.Location = New System.Drawing.Point(136, 83)
        Me.勘定科目_ラベル.Name = "勘定科目_ラベル"
        Me.勘定科目_ラベル.TabIndex = 28
        Me.勘定科目_ラベル.Text = "(勘定科目)"
        '
        ' 予算組織CD_ラベル
        '
        Me.予算組織CD_ラベル.AutoSize = True
        Me.予算組織CD_ラベル.Location = New System.Drawing.Point(268, 83)
        Me.予算組織CD_ラベル.Name = "予算組織CD_ラベル"
        Me.予算組織CD_ラベル.TabIndex = 29
        Me.予算組織CD_ラベル.Text = "予算組織\015\012CD"
        '
        ' 予算組織_ラベル
        '
        Me.予算組織_ラベル.AutoSize = True
        Me.予算組織_ラベル.Location = New System.Drawing.Point(325, 83)
        Me.予算組織_ラベル.Name = "予算組織_ラベル"
        Me.予算組織_ラベル.TabIndex = 30
        Me.予算組織_ラベル.Text = "(予算組織)"
        '
        ' 使用者社員番号_ラベル
        '
        Me.使用者社員番号_ラベル.AutoSize = True
        Me.使用者社員番号_ラベル.Location = New System.Drawing.Point(457, 83)
        Me.使用者社員番号_ラベル.Name = "使用者社員番号_ラベル"
        Me.使用者社員番号_ラベル.TabIndex = 31
        Me.使用者社員番号_ラベル.Text = "使用者\015\012社員番号"
        '
        ' MAPCD_ラベル
        '
        Me.MAPCD_ラベル.AutoSize = True
        Me.MAPCD_ラベル.Location = New System.Drawing.Point(544, 83)
        Me.MAPCD_ラベル.Name = "MAPCD_ラベル"
        Me.MAPCD_ラベル.TabIndex = 32
        Me.MAPCD_ラベル.Text = "MAP\015\012CD"
        '
        ' MAP_ラベル
        '
        Me.MAP_ラベル.AutoSize = True
        Me.MAP_ラベル.Location = New System.Drawing.Point(600, 83)
        Me.MAP_ラベル.Name = "MAP_ラベル"
        Me.MAP_ラベル.TabIndex = 33
        Me.MAP_ラベル.Text = "(MAP)"
        '
        ' 品目CD_ラベル
        '
        Me.品目CD_ラベル.AutoSize = True
        Me.品目CD_ラベル.Location = New System.Drawing.Point(733, 83)
        Me.品目CD_ラベル.Name = "品目CD_ラベル"
        Me.品目CD_ラベル.TabIndex = 34
        Me.品目CD_ラベル.Text = "品目\015\012CD"
        '
        ' 品目_ラベル
        '
        Me.品目_ラベル.AutoSize = True
        Me.品目_ラベル.Location = New System.Drawing.Point(789, 83)
        Me.品目_ラベル.Name = "品目_ラベル"
        Me.品目_ラベル.TabIndex = 35
        Me.品目_ラベル.Text = "(品目)"
        '
        ' 金額_ラベル
        '
        Me.金額_ラベル.AutoSize = True
        Me.金額_ラベル.Location = New System.Drawing.Point(922, 83)
        Me.金額_ラベル.Name = "金額_ラベル"
        Me.金額_ラベル.TabIndex = 36
        Me.金額_ラベル.Text = "金額"
        '
        ' 消費税CD_ラベル
        '
        Me.消費税CD_ラベル.AutoSize = True
        Me.消費税CD_ラベル.Location = New System.Drawing.Point(1016, 83)
        Me.消費税CD_ラベル.Name = "消費税CD_ラベル"
        Me.消費税CD_ラベル.TabIndex = 37
        Me.消費税CD_ラベル.Text = "消費税\015\012CD"
        '
        ' 消費税額_ラベル
        '
        Me.消費税額_ラベル.AutoSize = True
        Me.消費税額_ラベル.Location = New System.Drawing.Point(1062, 83)
        Me.消費税額_ラベル.Name = "消費税額_ラベル"
        Me.消費税額_ラベル.TabIndex = 38
        Me.消費税額_ラベル.Text = "消費税額"
        '
        ' 個別摘要_ラベル
        '
        Me.個別摘要_ラベル.AutoSize = True
        Me.個別摘要_ラベル.Location = New System.Drawing.Point(1137, 83)
        Me.個別摘要_ラベル.Name = "個別摘要_ラベル"
        Me.個別摘要_ラベル.TabIndex = 39
        Me.個別摘要_ラベル.Text = "個別摘要"
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(18, 56)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 40
        Me.ラベル521.Text = "計上日"
        '
        ' ラベル523
        '
        Me.ラベル523.AutoSize = True
        Me.ラベル523.Location = New System.Drawing.Point(226, 56)
        Me.ラベル523.Name = "ラベル523"
        Me.ラベル523.TabIndex = 41
        Me.ラベル523.Text = "出力先ﾌｧｲﾙ名"
        '
        ' ラベル34
        '
        Me.ラベル34.AutoSize = True
        Me.ラベル34.Location = New System.Drawing.Point(865, 3)
        Me.ラベル34.Name = "ラベル34"
        Me.ラベル34.TabIndex = 42
        Me.ラベル34.Text = "借方合計"
        '
        ' ラベル35
        '
        Me.ラベル35.AutoSize = True
        Me.ラベル35.Location = New System.Drawing.Point(865, 22)
        Me.ラベル35.Name = "ラベル35"
        Me.ラベル35.TabIndex = 43
        Me.ラベル35.Text = "貸方合計"
        '
        ' Form_fc_SNKO_仕訳出力_最終確認
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 438)
        Me.Controls.Add(Me.LINE_ID_ラベル)
        Me.Controls.Add(Me.貸借区分_ラベル)
        Me.Controls.Add(Me.勘定科目CD_ラベル)
        Me.Controls.Add(Me.勘定科目_ラベル)
        Me.Controls.Add(Me.予算組織CD_ラベル)
        Me.Controls.Add(Me.予算組織_ラベル)
        Me.Controls.Add(Me.使用者社員番号_ラベル)
        Me.Controls.Add(Me.MAPCD_ラベル)
        Me.Controls.Add(Me.MAP_ラベル)
        Me.Controls.Add(Me.品目CD_ラベル)
        Me.Controls.Add(Me.品目_ラベル)
        Me.Controls.Add(Me.金額_ラベル)
        Me.Controls.Add(Me.消費税CD_ラベル)
        Me.Controls.Add(Me.消費税額_ラベル)
        Me.Controls.Add(Me.個別摘要_ラベル)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル523)
        Me.Controls.Add(Me.ラベル34)
        Me.Controls.Add(Me.ラベル35)
        Me.Controls.Add(Me.txt_計上日)
        Me.Controls.Add(Me.txt_計上日_曜日)
        Me.Controls.Add(Me.txt_OUTPUT_FPATH)
        Me.Controls.Add(Me.txt_仕訳_ID)
        Me.Controls.Add(Me.LINE_ID)
        Me.Controls.Add(Me.貸借区分)
        Me.Controls.Add(Me.勘定科目CD)
        Me.Controls.Add(Me.勘定科目)
        Me.Controls.Add(Me.予算組織CD)
        Me.Controls.Add(Me.予算組織)
        Me.Controls.Add(Me.使用者社員番号)
        Me.Controls.Add(Me.MAPCD)
        Me.Controls.Add(Me.MAP)
        Me.Controls.Add(Me.品目CD)
        Me.Controls.Add(Me.品目)
        Me.Controls.Add(Me.金額)
        Me.Controls.Add(Me.消費税CD)
        Me.Controls.Add(Me.消費税額)
        Me.Controls.Add(Me.個別摘要)
        Me.Controls.Add(Me.txt_借方金額_SUM)
        Me.Controls.Add(Me.txt_貸方金額_SUM)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_FlexReportDLG)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_SNKO_仕訳出力_最終確認"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳出力　最終確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_計上日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日_曜日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FPATH As System.Windows.Forms.TextBox
    Friend WithEvents txt_仕訳_ID As System.Windows.Forms.TextBox
    Friend WithEvents LINE_ID As System.Windows.Forms.TextBox
    Friend WithEvents 貸借区分 As System.Windows.Forms.TextBox
    Friend WithEvents 勘定科目CD As System.Windows.Forms.TextBox
    Friend WithEvents 勘定科目 As System.Windows.Forms.TextBox
    Friend WithEvents 予算組織CD As System.Windows.Forms.TextBox
    Friend WithEvents 予算組織 As System.Windows.Forms.TextBox
    Friend WithEvents 使用者社員番号 As System.Windows.Forms.TextBox
    Friend WithEvents MAPCD As System.Windows.Forms.TextBox
    Friend WithEvents MAP As System.Windows.Forms.TextBox
    Friend WithEvents 品目CD As System.Windows.Forms.TextBox
    Friend WithEvents 品目 As System.Windows.Forms.TextBox
    Friend WithEvents 金額 As System.Windows.Forms.TextBox
    Friend WithEvents 消費税CD As System.Windows.Forms.TextBox
    Friend WithEvents 消費税額 As System.Windows.Forms.TextBox
    Friend WithEvents 個別摘要 As System.Windows.Forms.TextBox
    Friend WithEvents txt_借方金額_SUM As System.Windows.Forms.TextBox
    Friend WithEvents txt_貸方金額_SUM As System.Windows.Forms.TextBox
    Friend WithEvents LINE_ID_ラベル As System.Windows.Forms.Label
    Friend WithEvents 貸借区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 勘定科目CD_ラベル As System.Windows.Forms.Label
    Friend WithEvents 勘定科目_ラベル As System.Windows.Forms.Label
    Friend WithEvents 予算組織CD_ラベル As System.Windows.Forms.Label
    Friend WithEvents 予算組織_ラベル As System.Windows.Forms.Label
    Friend WithEvents 使用者社員番号_ラベル As System.Windows.Forms.Label
    Friend WithEvents MAPCD_ラベル As System.Windows.Forms.Label
    Friend WithEvents MAP_ラベル As System.Windows.Forms.Label
    Friend WithEvents 品目CD_ラベル As System.Windows.Forms.Label
    Friend WithEvents 品目_ラベル As System.Windows.Forms.Label
    Friend WithEvents 金額_ラベル As System.Windows.Forms.Label
    Friend WithEvents 消費税CD_ラベル As System.Windows.Forms.Label
    Friend WithEvents 消費税額_ラベル As System.Windows.Forms.Label
    Friend WithEvents 個別摘要_ラベル As System.Windows.Forms.Label
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル523 As System.Windows.Forms.Label
    Friend WithEvents ラベル34 As System.Windows.Forms.Label
    Friend WithEvents ラベル35 As System.Windows.Forms.Label

End Class