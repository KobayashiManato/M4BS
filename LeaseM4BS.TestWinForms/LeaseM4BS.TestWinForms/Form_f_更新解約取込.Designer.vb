<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_更新解約取込

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
        Me.cmd_EXCEL_IMPORT = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_TOUROKU = New System.Windows.Forms.Button()
        Me.cmd_LOG = New System.Windows.Forms.Button()
        Me.新_K契約番号 = New System.Windows.Forms.TextBox()
        Me.K契約No = New System.Windows.Forms.TextBox()
        Me.新_K契約日 = New System.Windows.Forms.TextBox()
        Me.新_K開始日 = New System.Windows.Forms.TextBox()
        Me.B契約内連番 = New System.Windows.Forms.TextBox()
        Me.B物件No = New System.Windows.Forms.TextBox()
        Me.新_K契約期間 = New System.Windows.Forms.TextBox()
        Me.新_K支払間隔 = New System.Windows.Forms.TextBox()
        Me.新_K支払回数 = New System.Windows.Forms.TextBox()
        Me.新_K第1回支払日 = New System.Windows.Forms.TextBox()
        Me.新_K第2回支払日 = New System.Windows.Forms.TextBox()
        Me.新_K第3回以降支払日 = New System.Windows.Forms.TextBox()
        Me.新_K消費税率 = New System.Windows.Forms.TextBox()
        Me.新_K1支払額 = New System.Windows.Forms.TextBox()
        Me.新_K1支払額消費税 = New System.Windows.Forms.TextBox()
        Me.新_K維持管理費用 = New System.Windows.Forms.TextBox()
        Me.新_B1支払額 = New System.Windows.Forms.TextBox()
        Me.新_B1支払額消費税 = New System.Windows.Forms.TextBox()
        Me.新_B維持管理費用 = New System.Windows.Forms.TextBox()
        Me.現_K契約番号 = New System.Windows.Forms.TextBox()
        Me.現_K契約日 = New System.Windows.Forms.TextBox()
        Me.現_K開始日 = New System.Windows.Forms.TextBox()
        Me.現_K契約期間 = New System.Windows.Forms.TextBox()
        Me.現_K支払間隔 = New System.Windows.Forms.TextBox()
        Me.現_K支払回数 = New System.Windows.Forms.TextBox()
        Me.現_K第1回支払日 = New System.Windows.Forms.TextBox()
        Me.現_K第2回支払日 = New System.Windows.Forms.TextBox()
        Me.現_K第3回以降支払日 = New System.Windows.Forms.TextBox()
        Me.現_K消費税率 = New System.Windows.Forms.TextBox()
        Me.現_K1支払額 = New System.Windows.Forms.TextBox()
        Me.現_K1支払額消費税 = New System.Windows.Forms.TextBox()
        Me.現_K維持管理費用 = New System.Windows.Forms.TextBox()
        Me.現_B1支払額 = New System.Windows.Forms.TextBox()
        Me.現_B1支払額消費税 = New System.Windows.Forms.TextBox()
        Me.現_B維持管理費用 = New System.Windows.Forms.TextBox()
        Me.現_K終了日 = New System.Windows.Forms.TextBox()
        Me.現_K再リース回数 = New System.Windows.Forms.TextBox()
        Me.現_K最終支払日 = New System.Windows.Forms.TextBox()
        Me.K支払先 = New System.Windows.Forms.TextBox()
        Me.B物件名 = New System.Windows.Forms.TextBox()
        Me.B管理部署CD = New System.Windows.Forms.TextBox()
        Me.B管理部署 = New System.Windows.Forms.TextBox()
        Me.txt_LINE_ID = New System.Windows.Forms.TextBox()
        Me.K契約区分 = New System.Windows.Forms.TextBox()
        Me.B更新解約 = New System.Windows.Forms.TextBox()
        Me.現_B総額リース料 = New System.Windows.Forms.TextBox()
        Me.現_K総額リース料 = New System.Windows.Forms.TextBox()
        Me.B物件No_ラベル = New System.Windows.Forms.Label()
        Me.K契約区分_ラベル = New System.Windows.Forms.Label()
        Me.K契約No_ラベル = New System.Windows.Forms.Label()
        Me.B契約内連番_ラベル = New System.Windows.Forms.Label()
        Me.B更新解約_ラベル = New System.Windows.Forms.Label()
        Me.K契約番号_ラベル = New System.Windows.Forms.Label()
        Me.K契約日_ラベル = New System.Windows.Forms.Label()
        Me.K開始日_ラベル = New System.Windows.Forms.Label()
        Me.K契約期間_ラベル = New System.Windows.Forms.Label()
        Me.K支払間隔_ラベル = New System.Windows.Forms.Label()
        Me.K支払回数_ラベル = New System.Windows.Forms.Label()
        Me.K第1回支払日_ラベル = New System.Windows.Forms.Label()
        Me.K第2回支払日_ラベル = New System.Windows.Forms.Label()
        Me.K第3回以降支払日_ラベル = New System.Windows.Forms.Label()
        Me.K消費税率_ラベル = New System.Windows.Forms.Label()
        Me.K1支払額_ラベル = New System.Windows.Forms.Label()
        Me.K1支払額消費税_ラベル = New System.Windows.Forms.Label()
        Me.K維持管理費用_ラベル = New System.Windows.Forms.Label()
        Me.B1支払額_ラベル = New System.Windows.Forms.Label()
        Me.B1支払額消費税_ラベル = New System.Windows.Forms.Label()
        Me.B維持管理費用_ラベル = New System.Windows.Forms.Label()
        Me.K終了日_ラベル = New System.Windows.Forms.Label()
        Me.K再リース回数_ラベル = New System.Windows.Forms.Label()
        Me.現_K最終支払日_ラベル = New System.Windows.Forms.Label()
        Me.K支払先_ラベル = New System.Windows.Forms.Label()
        Me.B物件名_ラベル = New System.Windows.Forms.Label()
        Me.B管理部署CD_ラベル = New System.Windows.Forms.Label()
        Me.B管理部署_ラベル = New System.Windows.Forms.Label()
        Me.B総額リース料_ラベル = New System.Windows.Forms.Label()
        Me.K総額リース料_ラベル = New System.Windows.Forms.Label()
        Me.ラベル299 = New System.Windows.Forms.Label()
        Me.ラベル300 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_EXCEL_IMPORT
        '
        Me.cmd_EXCEL_IMPORT.Location = New System.Drawing.Point(86, 3)
        Me.cmd_EXCEL_IMPORT.Name = "cmd_EXCEL_IMPORT"
        Me.cmd_EXCEL_IMPORT.Size = New System.Drawing.Size(207, 26)
        Me.cmd_EXCEL_IMPORT.TabIndex = 0
        Me.cmd_EXCEL_IMPORT.Text = "Excelをﾜｰｸﾃｰﾌﾞﾙに取り込む(&I)"
        Me.cmd_EXCEL_IMPORT.UseVisualStyleBackColor = True
        '
        ' cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(3, 3)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CLOSE.TabIndex = 1
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        ' cmd_TOUROKU
        '
        Me.cmd_TOUROKU.Location = New System.Drawing.Point(294, 3)
        Me.cmd_TOUROKU.Name = "cmd_TOUROKU"
        Me.cmd_TOUROKU.Size = New System.Drawing.Size(113, 26)
        Me.cmd_TOUROKU.TabIndex = 2
        Me.cmd_TOUROKU.Text = "本登録(&A)"
        Me.cmd_TOUROKU.UseVisualStyleBackColor = True
        '
        ' cmd_LOG
        '
        Me.cmd_LOG.Location = New System.Drawing.Point(408, 3)
        Me.cmd_LOG.Name = "cmd_LOG"
        Me.cmd_LOG.Size = New System.Drawing.Size(75, 26)
        Me.cmd_LOG.TabIndex = 3
        Me.cmd_LOG.Text = "前回本登録ログ(&L)"
        Me.cmd_LOG.UseVisualStyleBackColor = True
        '
        ' 新_K契約番号
        '
        Me.新_K契約番号.Location = New System.Drawing.Point(260, 0)
        Me.新_K契約番号.Name = "新_K契約番号"
        Me.新_K契約番号.Size = New System.Drawing.Size(56, 19)
        Me.新_K契約番号.TabIndex = 4
        '
        ' K契約No
        '
        Me.K契約No.Location = New System.Drawing.Point(41, 7)
        Me.K契約No.Name = "K契約No"
        Me.K契約No.Size = New System.Drawing.Size(50, 19)
        Me.K契約No.TabIndex = 5
        '
        ' 新_K契約日
        '
        Me.新_K契約日.Location = New System.Drawing.Point(317, 0)
        Me.新_K契約日.Name = "新_K契約日"
        Me.新_K契約日.Size = New System.Drawing.Size(64, 19)
        Me.新_K契約日.TabIndex = 6
        '
        ' 新_K開始日
        '
        Me.新_K開始日.Location = New System.Drawing.Point(381, 0)
        Me.新_K開始日.Name = "新_K開始日"
        Me.新_K開始日.Size = New System.Drawing.Size(64, 19)
        Me.新_K開始日.TabIndex = 7
        '
        ' B契約内連番
        '
        Me.B契約内連番.Location = New System.Drawing.Point(86, 7)
        Me.B契約内連番.Name = "B契約内連番"
        Me.B契約内連番.Size = New System.Drawing.Size(50, 19)
        Me.B契約内連番.TabIndex = 8
        '
        ' B物件No
        '
        Me.B物件No.Location = New System.Drawing.Point(132, 7)
        Me.B物件No.Name = "B物件No"
        Me.B物件No.Size = New System.Drawing.Size(50, 19)
        Me.B物件No.TabIndex = 9
        '
        ' 新_K契約期間
        '
        Me.新_K契約期間.Location = New System.Drawing.Point(445, 0)
        Me.新_K契約期間.Name = "新_K契約期間"
        Me.新_K契約期間.Size = New System.Drawing.Size(50, 19)
        Me.新_K契約期間.TabIndex = 10
        '
        ' 新_K支払間隔
        '
        Me.新_K支払間隔.Location = New System.Drawing.Point(585, 0)
        Me.新_K支払間隔.Name = "新_K支払間隔"
        Me.新_K支払間隔.Size = New System.Drawing.Size(50, 19)
        Me.新_K支払間隔.TabIndex = 11
        '
        ' 新_K支払回数
        '
        Me.新_K支払回数.Location = New System.Drawing.Point(623, 0)
        Me.新_K支払回数.Name = "新_K支払回数"
        Me.新_K支払回数.Size = New System.Drawing.Size(50, 19)
        Me.新_K支払回数.TabIndex = 12
        '
        ' 新_K第1回支払日
        '
        Me.新_K第1回支払日.Location = New System.Drawing.Point(661, 0)
        Me.新_K第1回支払日.Name = "新_K第1回支払日"
        Me.新_K第1回支払日.Size = New System.Drawing.Size(64, 19)
        Me.新_K第1回支払日.TabIndex = 13
        '
        ' 新_K第2回支払日
        '
        Me.新_K第2回支払日.Location = New System.Drawing.Point(725, 0)
        Me.新_K第2回支払日.Name = "新_K第2回支払日"
        Me.新_K第2回支払日.Size = New System.Drawing.Size(64, 19)
        Me.新_K第2回支払日.TabIndex = 14
        '
        ' 新_K第3回以降支払日
        '
        Me.新_K第3回以降支払日.Location = New System.Drawing.Point(789, 0)
        Me.新_K第3回以降支払日.Name = "新_K第3回以降支払日"
        Me.新_K第3回以降支払日.Size = New System.Drawing.Size(50, 19)
        Me.新_K第3回以降支払日.TabIndex = 15
        '
        ' 新_K消費税率
        '
        Me.新_K消費税率.Location = New System.Drawing.Point(899, 0)
        Me.新_K消費税率.Name = "新_K消費税率"
        Me.新_K消費税率.Size = New System.Drawing.Size(50, 19)
        Me.新_K消費税率.TabIndex = 16
        '
        ' 新_K1支払額
        '
        Me.新_K1支払額.Location = New System.Drawing.Point(944, 0)
        Me.新_K1支払額.Name = "新_K1支払額"
        Me.新_K1支払額.Size = New System.Drawing.Size(56, 19)
        Me.新_K1支払額.TabIndex = 17
        '
        ' 新_K1支払額消費税
        '
        Me.新_K1支払額消費税.Location = New System.Drawing.Point(1001, 0)
        Me.新_K1支払額消費税.Name = "新_K1支払額消費税"
        Me.新_K1支払額消費税.Size = New System.Drawing.Size(56, 19)
        Me.新_K1支払額消費税.TabIndex = 18
        '
        ' 新_K維持管理費用
        '
        Me.新_K維持管理費用.Location = New System.Drawing.Point(1114, 0)
        Me.新_K維持管理費用.Name = "新_K維持管理費用"
        Me.新_K維持管理費用.Size = New System.Drawing.Size(56, 19)
        Me.新_K維持管理費用.TabIndex = 19
        '
        ' 新_B1支払額
        '
        Me.新_B1支払額.Location = New System.Drawing.Point(1171, 0)
        Me.新_B1支払額.Name = "新_B1支払額"
        Me.新_B1支払額.Size = New System.Drawing.Size(56, 19)
        Me.新_B1支払額.TabIndex = 20
        '
        ' 新_B1支払額消費税
        '
        Me.新_B1支払額消費税.Location = New System.Drawing.Point(1228, 0)
        Me.新_B1支払額消費税.Name = "新_B1支払額消費税"
        Me.新_B1支払額消費税.Size = New System.Drawing.Size(56, 19)
        Me.新_B1支払額消費税.TabIndex = 21
        '
        ' 新_B維持管理費用
        '
        Me.新_B維持管理費用.Location = New System.Drawing.Point(1341, 0)
        Me.新_B維持管理費用.Name = "新_B維持管理費用"
        Me.新_B維持管理費用.Size = New System.Drawing.Size(56, 19)
        Me.新_B維持管理費用.TabIndex = 22
        '
        ' 現_K契約番号
        '
        Me.現_K契約番号.Location = New System.Drawing.Point(260, 18)
        Me.現_K契約番号.Name = "現_K契約番号"
        Me.現_K契約番号.Size = New System.Drawing.Size(56, 19)
        Me.現_K契約番号.TabIndex = 23
        '
        ' 現_K契約日
        '
        Me.現_K契約日.Location = New System.Drawing.Point(317, 18)
        Me.現_K契約日.Name = "現_K契約日"
        Me.現_K契約日.Size = New System.Drawing.Size(64, 19)
        Me.現_K契約日.TabIndex = 24
        '
        ' 現_K開始日
        '
        Me.現_K開始日.Location = New System.Drawing.Point(381, 18)
        Me.現_K開始日.Name = "現_K開始日"
        Me.現_K開始日.Size = New System.Drawing.Size(64, 19)
        Me.現_K開始日.TabIndex = 25
        '
        ' 現_K契約期間
        '
        Me.現_K契約期間.Location = New System.Drawing.Point(445, 18)
        Me.現_K契約期間.Name = "現_K契約期間"
        Me.現_K契約期間.Size = New System.Drawing.Size(50, 19)
        Me.現_K契約期間.TabIndex = 26
        '
        ' 現_K支払間隔
        '
        Me.現_K支払間隔.Location = New System.Drawing.Point(585, 18)
        Me.現_K支払間隔.Name = "現_K支払間隔"
        Me.現_K支払間隔.Size = New System.Drawing.Size(50, 19)
        Me.現_K支払間隔.TabIndex = 27
        '
        ' 現_K支払回数
        '
        Me.現_K支払回数.Location = New System.Drawing.Point(623, 18)
        Me.現_K支払回数.Name = "現_K支払回数"
        Me.現_K支払回数.Size = New System.Drawing.Size(50, 19)
        Me.現_K支払回数.TabIndex = 28
        '
        ' 現_K第1回支払日
        '
        Me.現_K第1回支払日.Location = New System.Drawing.Point(661, 18)
        Me.現_K第1回支払日.Name = "現_K第1回支払日"
        Me.現_K第1回支払日.Size = New System.Drawing.Size(64, 19)
        Me.現_K第1回支払日.TabIndex = 29
        '
        ' 現_K第2回支払日
        '
        Me.現_K第2回支払日.Location = New System.Drawing.Point(725, 18)
        Me.現_K第2回支払日.Name = "現_K第2回支払日"
        Me.現_K第2回支払日.Size = New System.Drawing.Size(64, 19)
        Me.現_K第2回支払日.TabIndex = 30
        '
        ' 現_K第3回以降支払日
        '
        Me.現_K第3回以降支払日.Location = New System.Drawing.Point(789, 18)
        Me.現_K第3回以降支払日.Name = "現_K第3回以降支払日"
        Me.現_K第3回以降支払日.Size = New System.Drawing.Size(50, 19)
        Me.現_K第3回以降支払日.TabIndex = 31
        '
        ' 現_K消費税率
        '
        Me.現_K消費税率.Location = New System.Drawing.Point(899, 18)
        Me.現_K消費税率.Name = "現_K消費税率"
        Me.現_K消費税率.Size = New System.Drawing.Size(50, 19)
        Me.現_K消費税率.TabIndex = 32
        '
        ' 現_K1支払額
        '
        Me.現_K1支払額.Location = New System.Drawing.Point(944, 18)
        Me.現_K1支払額.Name = "現_K1支払額"
        Me.現_K1支払額.Size = New System.Drawing.Size(56, 19)
        Me.現_K1支払額.TabIndex = 33
        '
        ' 現_K1支払額消費税
        '
        Me.現_K1支払額消費税.Location = New System.Drawing.Point(1001, 18)
        Me.現_K1支払額消費税.Name = "現_K1支払額消費税"
        Me.現_K1支払額消費税.Size = New System.Drawing.Size(56, 19)
        Me.現_K1支払額消費税.TabIndex = 34
        '
        ' 現_K維持管理費用
        '
        Me.現_K維持管理費用.Location = New System.Drawing.Point(1114, 18)
        Me.現_K維持管理費用.Name = "現_K維持管理費用"
        Me.現_K維持管理費用.Size = New System.Drawing.Size(56, 19)
        Me.現_K維持管理費用.TabIndex = 35
        '
        ' 現_B1支払額
        '
        Me.現_B1支払額.Location = New System.Drawing.Point(1171, 18)
        Me.現_B1支払額.Name = "現_B1支払額"
        Me.現_B1支払額.Size = New System.Drawing.Size(56, 19)
        Me.現_B1支払額.TabIndex = 36
        '
        ' 現_B1支払額消費税
        '
        Me.現_B1支払額消費税.Location = New System.Drawing.Point(1228, 18)
        Me.現_B1支払額消費税.Name = "現_B1支払額消費税"
        Me.現_B1支払額消費税.Size = New System.Drawing.Size(56, 19)
        Me.現_B1支払額消費税.TabIndex = 37
        '
        ' 現_B維持管理費用
        '
        Me.現_B維持管理費用.Location = New System.Drawing.Point(1341, 18)
        Me.現_B維持管理費用.Name = "現_B維持管理費用"
        Me.現_B維持管理費用.Size = New System.Drawing.Size(56, 19)
        Me.現_B維持管理費用.TabIndex = 38
        '
        ' 現_K終了日
        '
        Me.現_K終了日.Location = New System.Drawing.Point(483, 18)
        Me.現_K終了日.Name = "現_K終了日"
        Me.現_K終了日.Size = New System.Drawing.Size(64, 19)
        Me.現_K終了日.TabIndex = 39
        '
        ' 現_K再リース回数
        '
        Me.現_K再リース回数.Location = New System.Drawing.Point(548, 18)
        Me.現_K再リース回数.Name = "現_K再リース回数"
        Me.現_K再リース回数.Size = New System.Drawing.Size(50, 19)
        Me.現_K再リース回数.TabIndex = 40
        '
        ' 現_K最終支払日
        '
        Me.現_K最終支払日.Location = New System.Drawing.Point(835, 18)
        Me.現_K最終支払日.Name = "現_K最終支払日"
        Me.現_K最終支払日.Size = New System.Drawing.Size(64, 19)
        Me.現_K最終支払日.TabIndex = 41
        '
        ' K支払先
        '
        Me.K支払先.Location = New System.Drawing.Point(1402, 7)
        Me.K支払先.Name = "K支払先"
        Me.K支払先.Size = New System.Drawing.Size(75, 19)
        Me.K支払先.TabIndex = 42
        '
        ' B物件名
        '
        Me.B物件名.Location = New System.Drawing.Point(1515, 7)
        Me.B物件名.Name = "B物件名"
        Me.B物件名.Size = New System.Drawing.Size(113, 19)
        Me.B物件名.TabIndex = 43
        '
        ' B管理部署CD
        '
        Me.B管理部署CD.Location = New System.Drawing.Point(1628, 7)
        Me.B管理部署CD.Name = "B管理部署CD"
        Me.B管理部署CD.Size = New System.Drawing.Size(56, 19)
        Me.B管理部署CD.TabIndex = 44
        '
        ' B管理部署
        '
        Me.B管理部署.Location = New System.Drawing.Point(1685, 7)
        Me.B管理部署.Name = "B管理部署"
        Me.B管理部署.Size = New System.Drawing.Size(113, 19)
        Me.B管理部署.TabIndex = 45
        '
        ' txt_LINE_ID
        '
        Me.txt_LINE_ID.Location = New System.Drawing.Point(132, 26)
        Me.txt_LINE_ID.Name = "txt_LINE_ID"
        Me.txt_LINE_ID.Size = New System.Drawing.Size(50, 19)
        Me.txt_LINE_ID.TabIndex = 46
        '
        ' K契約区分
        '
        Me.K契約区分.Location = New System.Drawing.Point(3, 7)
        Me.K契約区分.Name = "K契約区分"
        Me.K契約区分.Size = New System.Drawing.Size(50, 19)
        Me.K契約区分.TabIndex = 47
        '
        ' B更新解約
        '
        Me.B更新解約.Location = New System.Drawing.Point(177, 7)
        Me.B更新解約.Name = "B更新解約"
        Me.B更新解約.Size = New System.Drawing.Size(50, 19)
        Me.B更新解約.TabIndex = 48
        '
        ' 現_B総額リース料
        '
        Me.現_B総額リース料.Location = New System.Drawing.Point(1285, 18)
        Me.現_B総額リース料.Name = "現_B総額リース料"
        Me.現_B総額リース料.Size = New System.Drawing.Size(56, 19)
        Me.現_B総額リース料.TabIndex = 49
        '
        ' 現_K総額リース料
        '
        Me.現_K総額リース料.Location = New System.Drawing.Point(1058, 18)
        Me.現_K総額リース料.Name = "現_K総額リース料"
        Me.現_K総額リース料.Size = New System.Drawing.Size(56, 19)
        Me.現_K総額リース料.TabIndex = 50
        '
        ' B物件No_ラベル
        '
        Me.B物件No_ラベル.AutoSize = True
        Me.B物件No_ラベル.Location = New System.Drawing.Point(132, 56)
        Me.B物件No_ラベル.Name = "B物件No_ラベル"
        Me.B物件No_ラベル.TabIndex = 51
        Me.B物件No_ラベル.Text = "B物件No"
        '
        ' K契約区分_ラベル
        '
        Me.K契約区分_ラベル.AutoSize = True
        Me.K契約区分_ラベル.Location = New System.Drawing.Point(3, 56)
        Me.K契約区分_ラベル.Name = "K契約区分_ラベル"
        Me.K契約区分_ラベル.TabIndex = 52
        Me.K契約区分_ラベル.Text = "K契約区分"
        '
        ' K契約No_ラベル
        '
        Me.K契約No_ラベル.AutoSize = True
        Me.K契約No_ラベル.Location = New System.Drawing.Point(41, 56)
        Me.K契約No_ラベル.Name = "K契約No_ラベル"
        Me.K契約No_ラベル.TabIndex = 53
        Me.K契約No_ラベル.Text = "K契約No"
        '
        ' B契約内連番_ラベル
        '
        Me.B契約内連番_ラベル.AutoSize = True
        Me.B契約内連番_ラベル.Location = New System.Drawing.Point(86, 56)
        Me.B契約内連番_ラベル.Name = "B契約内連番_ラベル"
        Me.B契約内連番_ラベル.TabIndex = 54
        Me.B契約内連番_ラベル.Text = "B契約内連番"
        '
        ' B更新解約_ラベル
        '
        Me.B更新解約_ラベル.AutoSize = True
        Me.B更新解約_ラベル.Location = New System.Drawing.Point(177, 56)
        Me.B更新解約_ラベル.Name = "B更新解約_ラベル"
        Me.B更新解約_ラベル.TabIndex = 55
        Me.B更新解約_ラベル.Text = "B更新解約"
        '
        ' K契約番号_ラベル
        '
        Me.K契約番号_ラベル.AutoSize = True
        Me.K契約番号_ラベル.Location = New System.Drawing.Point(260, 56)
        Me.K契約番号_ラベル.Name = "K契約番号_ラベル"
        Me.K契約番号_ラベル.TabIndex = 56
        Me.K契約番号_ラベル.Text = "K契約番号"
        '
        ' K契約日_ラベル
        '
        Me.K契約日_ラベル.AutoSize = True
        Me.K契約日_ラベル.Location = New System.Drawing.Point(317, 56)
        Me.K契約日_ラベル.Name = "K契約日_ラベル"
        Me.K契約日_ラベル.TabIndex = 57
        Me.K契約日_ラベル.Text = "K契約日"
        '
        ' K開始日_ラベル
        '
        Me.K開始日_ラベル.AutoSize = True
        Me.K開始日_ラベル.Location = New System.Drawing.Point(381, 56)
        Me.K開始日_ラベル.Name = "K開始日_ラベル"
        Me.K開始日_ラベル.TabIndex = 58
        Me.K開始日_ラベル.Text = "K開始日"
        '
        ' K契約期間_ラベル
        '
        Me.K契約期間_ラベル.AutoSize = True
        Me.K契約期間_ラベル.Location = New System.Drawing.Point(445, 56)
        Me.K契約期間_ラベル.Name = "K契約期間_ラベル"
        Me.K契約期間_ラベル.TabIndex = 59
        Me.K契約期間_ラベル.Text = "K契約期間"
        '
        ' K支払間隔_ラベル
        '
        Me.K支払間隔_ラベル.AutoSize = True
        Me.K支払間隔_ラベル.Location = New System.Drawing.Point(585, 56)
        Me.K支払間隔_ラベル.Name = "K支払間隔_ラベル"
        Me.K支払間隔_ラベル.TabIndex = 60
        Me.K支払間隔_ラベル.Text = "K支払間隔"
        '
        ' K支払回数_ラベル
        '
        Me.K支払回数_ラベル.AutoSize = True
        Me.K支払回数_ラベル.Location = New System.Drawing.Point(623, 56)
        Me.K支払回数_ラベル.Name = "K支払回数_ラベル"
        Me.K支払回数_ラベル.TabIndex = 61
        Me.K支払回数_ラベル.Text = "K支払回数"
        '
        ' K第1回支払日_ラベル
        '
        Me.K第1回支払日_ラベル.AutoSize = True
        Me.K第1回支払日_ラベル.Location = New System.Drawing.Point(661, 56)
        Me.K第1回支払日_ラベル.Name = "K第1回支払日_ラベル"
        Me.K第1回支払日_ラベル.TabIndex = 62
        Me.K第1回支払日_ラベル.Text = "K第1回支払日"
        '
        ' K第2回支払日_ラベル
        '
        Me.K第2回支払日_ラベル.AutoSize = True
        Me.K第2回支払日_ラベル.Location = New System.Drawing.Point(725, 56)
        Me.K第2回支払日_ラベル.Name = "K第2回支払日_ラベル"
        Me.K第2回支払日_ラベル.TabIndex = 63
        Me.K第2回支払日_ラベル.Text = "K第2回支払日"
        '
        ' K第3回以降支払日_ラベル
        '
        Me.K第3回以降支払日_ラベル.AutoSize = True
        Me.K第3回以降支払日_ラベル.Location = New System.Drawing.Point(789, 56)
        Me.K第3回以降支払日_ラベル.Name = "K第3回以降支払日_ラベル"
        Me.K第3回以降支払日_ラベル.TabIndex = 64
        Me.K第3回以降支払日_ラベル.Text = "K第3回以降支払日"
        '
        ' K消費税率_ラベル
        '
        Me.K消費税率_ラベル.AutoSize = True
        Me.K消費税率_ラベル.Location = New System.Drawing.Point(899, 56)
        Me.K消費税率_ラベル.Name = "K消費税率_ラベル"
        Me.K消費税率_ラベル.TabIndex = 65
        Me.K消費税率_ラベル.Text = "K消費税率"
        '
        ' K1支払額_ラベル
        '
        Me.K1支払額_ラベル.AutoSize = True
        Me.K1支払額_ラベル.Location = New System.Drawing.Point(944, 56)
        Me.K1支払額_ラベル.Name = "K1支払額_ラベル"
        Me.K1支払額_ラベル.TabIndex = 66
        Me.K1支払額_ラベル.Text = "K1支払額"
        '
        ' K1支払額消費税_ラベル
        '
        Me.K1支払額消費税_ラベル.AutoSize = True
        Me.K1支払額消費税_ラベル.Location = New System.Drawing.Point(1001, 56)
        Me.K1支払額消費税_ラベル.Name = "K1支払額消費税_ラベル"
        Me.K1支払額消費税_ラベル.TabIndex = 67
        Me.K1支払額消費税_ラベル.Text = "K1支払額消費税"
        '
        ' K維持管理費用_ラベル
        '
        Me.K維持管理費用_ラベル.AutoSize = True
        Me.K維持管理費用_ラベル.Location = New System.Drawing.Point(1114, 56)
        Me.K維持管理費用_ラベル.Name = "K維持管理費用_ラベル"
        Me.K維持管理費用_ラベル.TabIndex = 68
        Me.K維持管理費用_ラベル.Text = "K維持管理費用"
        '
        ' B1支払額_ラベル
        '
        Me.B1支払額_ラベル.AutoSize = True
        Me.B1支払額_ラベル.Location = New System.Drawing.Point(1171, 56)
        Me.B1支払額_ラベル.Name = "B1支払額_ラベル"
        Me.B1支払額_ラベル.TabIndex = 69
        Me.B1支払額_ラベル.Text = "B1支払額"
        '
        ' B1支払額消費税_ラベル
        '
        Me.B1支払額消費税_ラベル.AutoSize = True
        Me.B1支払額消費税_ラベル.Location = New System.Drawing.Point(1228, 56)
        Me.B1支払額消費税_ラベル.Name = "B1支払額消費税_ラベル"
        Me.B1支払額消費税_ラベル.TabIndex = 70
        Me.B1支払額消費税_ラベル.Text = "B1支払額消費税"
        '
        ' B維持管理費用_ラベル
        '
        Me.B維持管理費用_ラベル.AutoSize = True
        Me.B維持管理費用_ラベル.Location = New System.Drawing.Point(1341, 56)
        Me.B維持管理費用_ラベル.Name = "B維持管理費用_ラベル"
        Me.B維持管理費用_ラベル.TabIndex = 71
        Me.B維持管理費用_ラベル.Text = "B維持管理費用"
        '
        ' K終了日_ラベル
        '
        Me.K終了日_ラベル.AutoSize = True
        Me.K終了日_ラベル.Location = New System.Drawing.Point(483, 56)
        Me.K終了日_ラベル.Name = "K終了日_ラベル"
        Me.K終了日_ラベル.TabIndex = 72
        Me.K終了日_ラベル.Text = "K終了日"
        '
        ' K再リース回数_ラベル
        '
        Me.K再リース回数_ラベル.AutoSize = True
        Me.K再リース回数_ラベル.Location = New System.Drawing.Point(548, 56)
        Me.K再リース回数_ラベル.Name = "K再リース回数_ラベル"
        Me.K再リース回数_ラベル.TabIndex = 73
        Me.K再リース回数_ラベル.Text = "K再リース回数"
        '
        ' 現_K最終支払日_ラベル
        '
        Me.現_K最終支払日_ラベル.AutoSize = True
        Me.現_K最終支払日_ラベル.Location = New System.Drawing.Point(835, 56)
        Me.現_K最終支払日_ラベル.Name = "現_K最終支払日_ラベル"
        Me.現_K最終支払日_ラベル.TabIndex = 74
        Me.現_K最終支払日_ラベル.Text = "K最終支払日"
        '
        ' K支払先_ラベル
        '
        Me.K支払先_ラベル.AutoSize = True
        Me.K支払先_ラベル.Location = New System.Drawing.Point(1402, 56)
        Me.K支払先_ラベル.Name = "K支払先_ラベル"
        Me.K支払先_ラベル.TabIndex = 75
        Me.K支払先_ラベル.Text = "K支払先"
        '
        ' B物件名_ラベル
        '
        Me.B物件名_ラベル.AutoSize = True
        Me.B物件名_ラベル.Location = New System.Drawing.Point(1515, 56)
        Me.B物件名_ラベル.Name = "B物件名_ラベル"
        Me.B物件名_ラベル.TabIndex = 76
        Me.B物件名_ラベル.Text = "B物件名"
        '
        ' B管理部署CD_ラベル
        '
        Me.B管理部署CD_ラベル.AutoSize = True
        Me.B管理部署CD_ラベル.Location = New System.Drawing.Point(1628, 56)
        Me.B管理部署CD_ラベル.Name = "B管理部署CD_ラベル"
        Me.B管理部署CD_ラベル.TabIndex = 77
        Me.B管理部署CD_ラベル.Text = "B管理部署CD"
        '
        ' B管理部署_ラベル
        '
        Me.B管理部署_ラベル.AutoSize = True
        Me.B管理部署_ラベル.Location = New System.Drawing.Point(1685, 56)
        Me.B管理部署_ラベル.Name = "B管理部署_ラベル"
        Me.B管理部署_ラベル.TabIndex = 78
        Me.B管理部署_ラベル.Text = "B管理部署"
        '
        ' B総額リース料_ラベル
        '
        Me.B総額リース料_ラベル.AutoSize = True
        Me.B総額リース料_ラベル.Location = New System.Drawing.Point(1285, 56)
        Me.B総額リース料_ラベル.Name = "B総額リース料_ラベル"
        Me.B総額リース料_ラベル.TabIndex = 79
        Me.B総額リース料_ラベル.Text = "B総額リース料"
        '
        ' K総額リース料_ラベル
        '
        Me.K総額リース料_ラベル.AutoSize = True
        Me.K総額リース料_ラベル.Location = New System.Drawing.Point(1058, 56)
        Me.K総額リース料_ラベル.Name = "K総額リース料_ラベル"
        Me.K総額リース料_ラベル.TabIndex = 80
        Me.K総額リース料_ラベル.Text = "K総額リース料"
        '
        ' ラベル299
        '
        Me.ラベル299.AutoSize = True
        Me.ラベル299.Location = New System.Drawing.Point(219, 0)
        Me.ラベル299.Name = "ラベル299"
        Me.ラベル299.TabIndex = 81
        Me.ラベル299.Text = "新"
        '
        ' ラベル300
        '
        Me.ラベル300.AutoSize = True
        Me.ラベル300.Location = New System.Drawing.Point(219, 18)
        Me.ラベル300.Name = "ラベル300"
        Me.ラベル300.TabIndex = 82
        Me.ラベル300.Text = "現"
        '
        ' Form_f_更新解約取込
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.B物件No_ラベル)
        Me.Controls.Add(Me.K契約区分_ラベル)
        Me.Controls.Add(Me.K契約No_ラベル)
        Me.Controls.Add(Me.B契約内連番_ラベル)
        Me.Controls.Add(Me.B更新解約_ラベル)
        Me.Controls.Add(Me.K契約番号_ラベル)
        Me.Controls.Add(Me.K契約日_ラベル)
        Me.Controls.Add(Me.K開始日_ラベル)
        Me.Controls.Add(Me.K契約期間_ラベル)
        Me.Controls.Add(Me.K支払間隔_ラベル)
        Me.Controls.Add(Me.K支払回数_ラベル)
        Me.Controls.Add(Me.K第1回支払日_ラベル)
        Me.Controls.Add(Me.K第2回支払日_ラベル)
        Me.Controls.Add(Me.K第3回以降支払日_ラベル)
        Me.Controls.Add(Me.K消費税率_ラベル)
        Me.Controls.Add(Me.K1支払額_ラベル)
        Me.Controls.Add(Me.K1支払額消費税_ラベル)
        Me.Controls.Add(Me.K維持管理費用_ラベル)
        Me.Controls.Add(Me.B1支払額_ラベル)
        Me.Controls.Add(Me.B1支払額消費税_ラベル)
        Me.Controls.Add(Me.B維持管理費用_ラベル)
        Me.Controls.Add(Me.K終了日_ラベル)
        Me.Controls.Add(Me.K再リース回数_ラベル)
        Me.Controls.Add(Me.現_K最終支払日_ラベル)
        Me.Controls.Add(Me.K支払先_ラベル)
        Me.Controls.Add(Me.B物件名_ラベル)
        Me.Controls.Add(Me.B管理部署CD_ラベル)
        Me.Controls.Add(Me.B管理部署_ラベル)
        Me.Controls.Add(Me.B総額リース料_ラベル)
        Me.Controls.Add(Me.K総額リース料_ラベル)
        Me.Controls.Add(Me.ラベル299)
        Me.Controls.Add(Me.ラベル300)
        Me.Controls.Add(Me.新_K契約番号)
        Me.Controls.Add(Me.K契約No)
        Me.Controls.Add(Me.新_K契約日)
        Me.Controls.Add(Me.新_K開始日)
        Me.Controls.Add(Me.B契約内連番)
        Me.Controls.Add(Me.B物件No)
        Me.Controls.Add(Me.新_K契約期間)
        Me.Controls.Add(Me.新_K支払間隔)
        Me.Controls.Add(Me.新_K支払回数)
        Me.Controls.Add(Me.新_K第1回支払日)
        Me.Controls.Add(Me.新_K第2回支払日)
        Me.Controls.Add(Me.新_K第3回以降支払日)
        Me.Controls.Add(Me.新_K消費税率)
        Me.Controls.Add(Me.新_K1支払額)
        Me.Controls.Add(Me.新_K1支払額消費税)
        Me.Controls.Add(Me.新_K維持管理費用)
        Me.Controls.Add(Me.新_B1支払額)
        Me.Controls.Add(Me.新_B1支払額消費税)
        Me.Controls.Add(Me.新_B維持管理費用)
        Me.Controls.Add(Me.現_K契約番号)
        Me.Controls.Add(Me.現_K契約日)
        Me.Controls.Add(Me.現_K開始日)
        Me.Controls.Add(Me.現_K契約期間)
        Me.Controls.Add(Me.現_K支払間隔)
        Me.Controls.Add(Me.現_K支払回数)
        Me.Controls.Add(Me.現_K第1回支払日)
        Me.Controls.Add(Me.現_K第2回支払日)
        Me.Controls.Add(Me.現_K第3回以降支払日)
        Me.Controls.Add(Me.現_K消費税率)
        Me.Controls.Add(Me.現_K1支払額)
        Me.Controls.Add(Me.現_K1支払額消費税)
        Me.Controls.Add(Me.現_K維持管理費用)
        Me.Controls.Add(Me.現_B1支払額)
        Me.Controls.Add(Me.現_B1支払額消費税)
        Me.Controls.Add(Me.現_B維持管理費用)
        Me.Controls.Add(Me.現_K終了日)
        Me.Controls.Add(Me.現_K再リース回数)
        Me.Controls.Add(Me.現_K最終支払日)
        Me.Controls.Add(Me.K支払先)
        Me.Controls.Add(Me.B物件名)
        Me.Controls.Add(Me.B管理部署CD)
        Me.Controls.Add(Me.B管理部署)
        Me.Controls.Add(Me.txt_LINE_ID)
        Me.Controls.Add(Me.K契約区分)
        Me.Controls.Add(Me.B更新解約)
        Me.Controls.Add(Me.現_B総額リース料)
        Me.Controls.Add(Me.現_K総額リース料)
        Me.Controls.Add(Me.cmd_EXCEL_IMPORT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_TOUROKU)
        Me.Controls.Add(Me.cmd_LOG)
        Me.Name = "Form_f_更新解約取込"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "一括再リース／返却"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_EXCEL_IMPORT As System.Windows.Forms.Button
    Friend WithEvents cmd_CLOSE As System.Windows.Forms.Button
    Friend WithEvents cmd_TOUROKU As System.Windows.Forms.Button
    Friend WithEvents cmd_LOG As System.Windows.Forms.Button
    Friend WithEvents 新_K契約番号 As System.Windows.Forms.TextBox
    Friend WithEvents K契約No As System.Windows.Forms.TextBox
    Friend WithEvents 新_K契約日 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K開始日 As System.Windows.Forms.TextBox
    Friend WithEvents B契約内連番 As System.Windows.Forms.TextBox
    Friend WithEvents B物件No As System.Windows.Forms.TextBox
    Friend WithEvents 新_K契約期間 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K支払間隔 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K支払回数 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K第1回支払日 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K第2回支払日 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K第3回以降支払日 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K消費税率 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K1支払額 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K1支払額消費税 As System.Windows.Forms.TextBox
    Friend WithEvents 新_K維持管理費用 As System.Windows.Forms.TextBox
    Friend WithEvents 新_B1支払額 As System.Windows.Forms.TextBox
    Friend WithEvents 新_B1支払額消費税 As System.Windows.Forms.TextBox
    Friend WithEvents 新_B維持管理費用 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K契約番号 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K契約日 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K開始日 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K契約期間 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K支払間隔 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K支払回数 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K第1回支払日 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K第2回支払日 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K第3回以降支払日 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K消費税率 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K1支払額 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K1支払額消費税 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K維持管理費用 As System.Windows.Forms.TextBox
    Friend WithEvents 現_B1支払額 As System.Windows.Forms.TextBox
    Friend WithEvents 現_B1支払額消費税 As System.Windows.Forms.TextBox
    Friend WithEvents 現_B維持管理費用 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K終了日 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K再リース回数 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K最終支払日 As System.Windows.Forms.TextBox
    Friend WithEvents K支払先 As System.Windows.Forms.TextBox
    Friend WithEvents B物件名 As System.Windows.Forms.TextBox
    Friend WithEvents B管理部署CD As System.Windows.Forms.TextBox
    Friend WithEvents B管理部署 As System.Windows.Forms.TextBox
    Friend WithEvents txt_LINE_ID As System.Windows.Forms.TextBox
    Friend WithEvents K契約区分 As System.Windows.Forms.TextBox
    Friend WithEvents B更新解約 As System.Windows.Forms.TextBox
    Friend WithEvents 現_B総額リース料 As System.Windows.Forms.TextBox
    Friend WithEvents 現_K総額リース料 As System.Windows.Forms.TextBox
    Friend WithEvents B物件No_ラベル As System.Windows.Forms.Label
    Friend WithEvents K契約区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents K契約No_ラベル As System.Windows.Forms.Label
    Friend WithEvents B契約内連番_ラベル As System.Windows.Forms.Label
    Friend WithEvents B更新解約_ラベル As System.Windows.Forms.Label
    Friend WithEvents K契約番号_ラベル As System.Windows.Forms.Label
    Friend WithEvents K契約日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K開始日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K契約期間_ラベル As System.Windows.Forms.Label
    Friend WithEvents K支払間隔_ラベル As System.Windows.Forms.Label
    Friend WithEvents K支払回数_ラベル As System.Windows.Forms.Label
    Friend WithEvents K第1回支払日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K第2回支払日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K第3回以降支払日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K消費税率_ラベル As System.Windows.Forms.Label
    Friend WithEvents K1支払額_ラベル As System.Windows.Forms.Label
    Friend WithEvents K1支払額消費税_ラベル As System.Windows.Forms.Label
    Friend WithEvents K維持管理費用_ラベル As System.Windows.Forms.Label
    Friend WithEvents B1支払額_ラベル As System.Windows.Forms.Label
    Friend WithEvents B1支払額消費税_ラベル As System.Windows.Forms.Label
    Friend WithEvents B維持管理費用_ラベル As System.Windows.Forms.Label
    Friend WithEvents K終了日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K再リース回数_ラベル As System.Windows.Forms.Label
    Friend WithEvents 現_K最終支払日_ラベル As System.Windows.Forms.Label
    Friend WithEvents K支払先_ラベル As System.Windows.Forms.Label
    Friend WithEvents B物件名_ラベル As System.Windows.Forms.Label
    Friend WithEvents B管理部署CD_ラベル As System.Windows.Forms.Label
    Friend WithEvents B管理部署_ラベル As System.Windows.Forms.Label
    Friend WithEvents B総額リース料_ラベル As System.Windows.Forms.Label
    Friend WithEvents K総額リース料_ラベル As System.Windows.Forms.Label
    Friend WithEvents ラベル299 As System.Windows.Forms.Label
    Friend WithEvents ラベル300 As System.Windows.Forms.Label

End Class