<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_仕訳出力_最終確認_RISO

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
        Me.txt_処理年月 = New System.Windows.Forms.TextBox()
        Me.txt_計上日_曜日 = New System.Windows.Forms.TextBox()
        Me.txt_OUTPUT_FPATH = New System.Windows.Forms.TextBox()
        Me.txt_仕訳_ID = New System.Windows.Forms.TextBox()
        Me.入力番号 = New System.Windows.Forms.TextBox()
        Me.細目コード識別区分 = New System.Windows.Forms.TextBox()
        Me.勘定科目コード = New System.Windows.Forms.TextBox()
        Me.会計部門コード = New System.Windows.Forms.TextBox()
        Me.取引先コード = New System.Windows.Forms.TextBox()
        Me.履歴物件コード = New System.Windows.Forms.TextBox()
        Me.セグメントコード = New System.Windows.Forms.TextBox()
        Me.取引通貨コード = New System.Windows.Forms.TextBox()
        Me.資金コード = New System.Windows.Forms.TextBox()
        Me.基本通貨発生金額 = New System.Windows.Forms.TextBox()
        Me.消費税区分コード = New System.Windows.Forms.TextBox()
        Me.参考消費税金額 = New System.Windows.Forms.TextBox()
        Me.文字摘要１ = New System.Windows.Forms.TextBox()
        Me.会社コード = New System.Windows.Forms.TextBox()
        Me.起票社員コード = New System.Windows.Forms.TextBox()
        Me.起票部門コード = New System.Windows.Forms.TextBox()
        Me.承認社員コード = New System.Windows.Forms.TextBox()
        Me.承認日付 = New System.Windows.Forms.TextBox()
        Me.承認状態区分 = New System.Windows.Forms.TextBox()
        Me.仕訳種別区分 = New System.Windows.Forms.TextBox()
        Me.伝票日付 = New System.Windows.Forms.TextBox()
        Me.伝票番号 = New System.Windows.Forms.TextBox()
        Me.伝票操作禁止区分 = New System.Windows.Forms.TextBox()
        Me.伝票備考 = New System.Windows.Forms.TextBox()
        Me.行番号 = New System.Windows.Forms.TextBox()
        Me.伝票明細貸借区分 = New System.Windows.Forms.TextBox()
        Me.細目コード = New System.Windows.Forms.TextBox()
        Me.集計拡張コード１識別区分 = New System.Windows.Forms.TextBox()
        Me.集計拡張コード１ = New System.Windows.Forms.TextBox()
        Me.課税区分 = New System.Windows.Forms.TextBox()
        Me.税率区分 = New System.Windows.Forms.TextBox()
        Me.取引通貨発生金額 = New System.Windows.Forms.TextBox()
        Me.入力システム区分 = New System.Windows.Forms.TextBox()
        Me.txt_借方金額_SUM = New System.Windows.Forms.TextBox()
        Me.txt_貸方金額_SUM = New System.Windows.Forms.TextBox()
        Me.入力番号_ラベル = New System.Windows.Forms.Label()
        Me.細目コード識別区分_ラベル = New System.Windows.Forms.Label()
        Me.勘定科目コード_ラベル = New System.Windows.Forms.Label()
        Me.会計部門コード_ラベル = New System.Windows.Forms.Label()
        Me.取引先コード_ラベル = New System.Windows.Forms.Label()
        Me.履歴物件コード_ラベル = New System.Windows.Forms.Label()
        Me.セグメントコード_ラベル = New System.Windows.Forms.Label()
        Me.取引通貨コード_ラベル = New System.Windows.Forms.Label()
        Me.資金コード_ラベル = New System.Windows.Forms.Label()
        Me.基本通貨発生金額_ラベル = New System.Windows.Forms.Label()
        Me.消費税区分コード_ラベル = New System.Windows.Forms.Label()
        Me.参考消費税金額_ラベル = New System.Windows.Forms.Label()
        Me.文字摘要１_ラベル = New System.Windows.Forms.Label()
        Me.ラベル521 = New System.Windows.Forms.Label()
        Me.ラベル523 = New System.Windows.Forms.Label()
        Me.会社コード_ラベル = New System.Windows.Forms.Label()
        Me.起票社員コード_ラベル = New System.Windows.Forms.Label()
        Me.起票部門コード_ラベル = New System.Windows.Forms.Label()
        Me.承認社員コード_ラベル = New System.Windows.Forms.Label()
        Me.承認日付_ラベル = New System.Windows.Forms.Label()
        Me.承認状態区分_ラベル = New System.Windows.Forms.Label()
        Me.仕訳種別区分_ラベル = New System.Windows.Forms.Label()
        Me.伝票日付_ラベル = New System.Windows.Forms.Label()
        Me.伝票番号_ラベル = New System.Windows.Forms.Label()
        Me.伝票操作禁止区分_ラベル = New System.Windows.Forms.Label()
        Me.伝票備考_ラベル = New System.Windows.Forms.Label()
        Me.行番号_ラベル = New System.Windows.Forms.Label()
        Me.伝票明細貸借区分_ラベル = New System.Windows.Forms.Label()
        Me.細目コード_ラベル = New System.Windows.Forms.Label()
        Me.集計拡張コード１識別区分_ラベル = New System.Windows.Forms.Label()
        Me.集計拡張コード１_ラベル = New System.Windows.Forms.Label()
        Me.課税区分_ラベル = New System.Windows.Forms.Label()
        Me.税率区分_ラベル = New System.Windows.Forms.Label()
        Me.取引通貨発生金額_ラベル = New System.Windows.Forms.Label()
        Me.入力システム区分_ラベル = New System.Windows.Forms.Label()
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
        Me.cmd_選択.Text = "選択(&S)"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' txt_処理年月
        '
        Me.txt_処理年月.Location = New System.Drawing.Point(113, 56)
        Me.txt_処理年月.Name = "txt_処理年月"
        Me.txt_処理年月.Size = New System.Drawing.Size(75, 19)
        Me.txt_処理年月.TabIndex = 4
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
        Me.txt_仕訳_ID.Location = New System.Drawing.Point(1020, 56)
        Me.txt_仕訳_ID.Name = "txt_仕訳_ID"
        Me.txt_仕訳_ID.Size = New System.Drawing.Size(75, 19)
        Me.txt_仕訳_ID.TabIndex = 7
        '
        ' 入力番号
        '
        Me.入力番号.Location = New System.Drawing.Point(3, 0)
        Me.入力番号.Name = "入力番号"
        Me.入力番号.Size = New System.Drawing.Size(56, 19)
        Me.入力番号.TabIndex = 8
        '
        ' 細目コード識別区分
        '
        Me.細目コード識別区分.Location = New System.Drawing.Point(934, 0)
        Me.細目コード識別区分.Name = "細目コード識別区分"
        Me.細目コード識別区分.Size = New System.Drawing.Size(56, 19)
        Me.細目コード識別区分.TabIndex = 9
        '
        ' 勘定科目コード
        '
        Me.勘定科目コード.Location = New System.Drawing.Point(820, 0)
        Me.勘定科目コード.Name = "勘定科目コード"
        Me.勘定科目コード.Size = New System.Drawing.Size(56, 19)
        Me.勘定科目コード.TabIndex = 10
        '
        ' 会計部門コード
        '
        Me.会計部門コード.Location = New System.Drawing.Point(877, 0)
        Me.会計部門コード.Name = "会計部門コード"
        Me.会計部門コード.Size = New System.Drawing.Size(56, 19)
        Me.会計部門コード.TabIndex = 11
        '
        ' 取引先コード
        '
        Me.取引先コード.Location = New System.Drawing.Point(1160, 0)
        Me.取引先コード.Name = "取引先コード"
        Me.取引先コード.Size = New System.Drawing.Size(56, 19)
        Me.取引先コード.TabIndex = 12
        '
        ' 履歴物件コード
        '
        Me.履歴物件コード.Location = New System.Drawing.Point(1792, 0)
        Me.履歴物件コード.Name = "履歴物件コード"
        Me.履歴物件コード.Size = New System.Drawing.Size(56, 19)
        Me.履歴物件コード.TabIndex = 13
        '
        ' セグメントコード
        '
        Me.セグメントコード.Location = New System.Drawing.Point(1217, 0)
        Me.セグメントコード.Name = "セグメントコード"
        Me.セグメントコード.Size = New System.Drawing.Size(56, 19)
        Me.セグメントコード.TabIndex = 14
        '
        ' 取引通貨コード
        '
        Me.取引通貨コード.Location = New System.Drawing.Point(1274, 0)
        Me.取引通貨コード.Name = "取引通貨コード"
        Me.取引通貨コード.Size = New System.Drawing.Size(56, 19)
        Me.取引通貨コード.TabIndex = 15
        '
        ' 資金コード
        '
        Me.資金コード.Location = New System.Drawing.Point(1331, 0)
        Me.資金コード.Name = "資金コード"
        Me.資金コード.Size = New System.Drawing.Size(56, 19)
        Me.資金コード.TabIndex = 16
        '
        ' 基本通貨発生金額
        '
        Me.基本通貨発生金額.Location = New System.Drawing.Point(1471, 0)
        Me.基本通貨発生金額.Name = "基本通貨発生金額"
        Me.基本通貨発生金額.Size = New System.Drawing.Size(94, 19)
        Me.基本通貨発生金額.TabIndex = 17
        '
        ' 消費税区分コード
        '
        Me.消費税区分コード.Location = New System.Drawing.Point(1387, 0)
        Me.消費税区分コード.Name = "消費税区分コード"
        Me.消費税区分コード.Size = New System.Drawing.Size(50, 19)
        Me.消費税区分コード.TabIndex = 18
        '
        ' 参考消費税金額
        '
        Me.参考消費税金額.Location = New System.Drawing.Point(1660, 0)
        Me.参考消費税金額.Name = "参考消費税金額"
        Me.参考消費税金額.Size = New System.Drawing.Size(94, 19)
        Me.参考消費税金額.TabIndex = 19
        '
        ' 文字摘要１
        '
        Me.文字摘要１.Location = New System.Drawing.Point(1849, 0)
        Me.文字摘要１.Name = "文字摘要１"
        Me.文字摘要１.Size = New System.Drawing.Size(253, 19)
        Me.文字摘要１.TabIndex = 20
        '
        ' 会社コード
        '
        Me.会社コード.Location = New System.Drawing.Point(98, 0)
        Me.会社コード.Name = "会社コード"
        Me.会社コード.Size = New System.Drawing.Size(56, 19)
        Me.会社コード.TabIndex = 21
        '
        ' 起票社員コード
        '
        Me.起票社員コード.Location = New System.Drawing.Point(155, 0)
        Me.起票社員コード.Name = "起票社員コード"
        Me.起票社員コード.Size = New System.Drawing.Size(56, 19)
        Me.起票社員コード.TabIndex = 22
        '
        ' 起票部門コード
        '
        Me.起票部門コード.Location = New System.Drawing.Point(211, 0)
        Me.起票部門コード.Name = "起票部門コード"
        Me.起票部門コード.Size = New System.Drawing.Size(56, 19)
        Me.起票部門コード.TabIndex = 23
        '
        ' 承認社員コード
        '
        Me.承認社員コード.Location = New System.Drawing.Point(268, 0)
        Me.承認社員コード.Name = "承認社員コード"
        Me.承認社員コード.Size = New System.Drawing.Size(56, 19)
        Me.承認社員コード.TabIndex = 24
        '
        ' 承認日付
        '
        Me.承認日付.Location = New System.Drawing.Point(325, 0)
        Me.承認日付.Name = "承認日付"
        Me.承認日付.Size = New System.Drawing.Size(68, 19)
        Me.承認日付.TabIndex = 25
        '
        ' 承認状態区分
        '
        Me.承認状態区分.Location = New System.Drawing.Point(393, 0)
        Me.承認状態区分.Name = "承認状態区分"
        Me.承認状態区分.Size = New System.Drawing.Size(50, 19)
        Me.承認状態区分.TabIndex = 26
        '
        ' 仕訳種別区分
        '
        Me.仕訳種別区分.Location = New System.Drawing.Point(431, 0)
        Me.仕訳種別区分.Name = "仕訳種別区分"
        Me.仕訳種別区分.Size = New System.Drawing.Size(50, 19)
        Me.仕訳種別区分.TabIndex = 27
        '
        ' 伝票日付
        '
        Me.伝票日付.Location = New System.Drawing.Point(468, 0)
        Me.伝票日付.Name = "伝票日付"
        Me.伝票日付.Size = New System.Drawing.Size(68, 19)
        Me.伝票日付.TabIndex = 28
        '
        ' 伝票番号
        '
        Me.伝票番号.Location = New System.Drawing.Point(536, 0)
        Me.伝票番号.Name = "伝票番号"
        Me.伝票番号.Size = New System.Drawing.Size(56, 19)
        Me.伝票番号.TabIndex = 29
        '
        ' 伝票操作禁止区分
        '
        Me.伝票操作禁止区分.Location = New System.Drawing.Point(593, 0)
        Me.伝票操作禁止区分.Name = "伝票操作禁止区分"
        Me.伝票操作禁止区分.Size = New System.Drawing.Size(50, 19)
        Me.伝票操作禁止区分.TabIndex = 30
        '
        ' 伝票備考
        '
        Me.伝票備考.Location = New System.Drawing.Point(631, 0)
        Me.伝票備考.Name = "伝票備考"
        Me.伝票備考.Size = New System.Drawing.Size(75, 19)
        Me.伝票備考.TabIndex = 31
        '
        ' 行番号
        '
        Me.行番号.Location = New System.Drawing.Point(707, 0)
        Me.行番号.Name = "行番号"
        Me.行番号.Size = New System.Drawing.Size(56, 19)
        Me.行番号.TabIndex = 32
        '
        ' 伝票明細貸借区分
        '
        Me.伝票明細貸借区分.Location = New System.Drawing.Point(763, 0)
        Me.伝票明細貸借区分.Name = "伝票明細貸借区分"
        Me.伝票明細貸借区分.Size = New System.Drawing.Size(56, 19)
        Me.伝票明細貸借区分.TabIndex = 33
        '
        ' 細目コード
        '
        Me.細目コード.Location = New System.Drawing.Point(990, 0)
        Me.細目コード.Name = "細目コード"
        Me.細目コード.Size = New System.Drawing.Size(56, 19)
        Me.細目コード.TabIndex = 34
        '
        ' 集計拡張コード１識別区分
        '
        Me.集計拡張コード１識別区分.Location = New System.Drawing.Point(1047, 0)
        Me.集計拡張コード１識別区分.Name = "集計拡張コード１識別区分"
        Me.集計拡張コード１識別区分.Size = New System.Drawing.Size(56, 19)
        Me.集計拡張コード１識別区分.TabIndex = 35
        '
        ' 集計拡張コード１
        '
        Me.集計拡張コード１.Location = New System.Drawing.Point(1104, 0)
        Me.集計拡張コード１.Name = "集計拡張コード１"
        Me.集計拡張コード１.Size = New System.Drawing.Size(56, 19)
        Me.集計拡張コード１.TabIndex = 36
        '
        ' 課税区分
        '
        Me.課税区分.Location = New System.Drawing.Point(1754, 0)
        Me.課税区分.Name = "課税区分"
        Me.課税区分.Size = New System.Drawing.Size(50, 19)
        Me.課税区分.TabIndex = 37
        '
        ' 税率区分
        '
        Me.税率区分.Location = New System.Drawing.Point(1433, 0)
        Me.税率区分.Name = "税率区分"
        Me.税率区分.Size = New System.Drawing.Size(50, 19)
        Me.税率区分.TabIndex = 38
        '
        ' 取引通貨発生金額
        '
        Me.取引通貨発生金額.Location = New System.Drawing.Point(1565, 0)
        Me.取引通貨発生金額.Name = "取引通貨発生金額"
        Me.取引通貨発生金額.Size = New System.Drawing.Size(94, 19)
        Me.取引通貨発生金額.TabIndex = 39
        '
        ' 入力システム区分
        '
        Me.入力システム区分.Location = New System.Drawing.Point(60, 0)
        Me.入力システム区分.Name = "入力システム区分"
        Me.入力システム区分.Size = New System.Drawing.Size(50, 19)
        Me.入力システム区分.TabIndex = 40
        '
        ' txt_借方金額_SUM
        '
        Me.txt_借方金額_SUM.Location = New System.Drawing.Point(1471, 0)
        Me.txt_借方金額_SUM.Name = "txt_借方金額_SUM"
        Me.txt_借方金額_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_借方金額_SUM.TabIndex = 41
        '
        ' txt_貸方金額_SUM
        '
        Me.txt_貸方金額_SUM.Location = New System.Drawing.Point(1471, 18)
        Me.txt_貸方金額_SUM.Name = "txt_貸方金額_SUM"
        Me.txt_貸方金額_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_貸方金額_SUM.TabIndex = 42
        '
        ' 入力番号_ラベル
        '
        Me.入力番号_ラベル.AutoSize = True
        Me.入力番号_ラベル.Location = New System.Drawing.Point(3, 83)
        Me.入力番号_ラベル.Name = "入力番号_ラベル"
        Me.入力番号_ラベル.TabIndex = 43
        Me.入力番号_ラベル.Text = "入力番号"
        '
        ' 細目コード識別区分_ラベル
        '
        Me.細目コード識別区分_ラベル.AutoSize = True
        Me.細目コード識別区分_ラベル.Location = New System.Drawing.Point(934, 83)
        Me.細目コード識別区分_ラベル.Name = "細目コード識別区分_ラベル"
        Me.細目コード識別区分_ラベル.TabIndex = 44
        Me.細目コード識別区分_ラベル.Text = "細目\015\012コード\015\012識別区分"
        '
        ' 勘定科目コード_ラベル
        '
        Me.勘定科目コード_ラベル.AutoSize = True
        Me.勘定科目コード_ラベル.Location = New System.Drawing.Point(820, 83)
        Me.勘定科目コード_ラベル.Name = "勘定科目コード_ラベル"
        Me.勘定科目コード_ラベル.TabIndex = 45
        Me.勘定科目コード_ラベル.Text = "勘定科目コード"
        '
        ' 会計部門コード_ラベル
        '
        Me.会計部門コード_ラベル.AutoSize = True
        Me.会計部門コード_ラベル.Location = New System.Drawing.Point(877, 83)
        Me.会計部門コード_ラベル.Name = "会計部門コード_ラベル"
        Me.会計部門コード_ラベル.TabIndex = 46
        Me.会計部門コード_ラベル.Text = "会計部門コード"
        '
        ' 取引先コード_ラベル
        '
        Me.取引先コード_ラベル.AutoSize = True
        Me.取引先コード_ラベル.Location = New System.Drawing.Point(1160, 83)
        Me.取引先コード_ラベル.Name = "取引先コード_ラベル"
        Me.取引先コード_ラベル.TabIndex = 47
        Me.取引先コード_ラベル.Text = "取引先\015\012コード"
        '
        ' 履歴物件コード_ラベル
        '
        Me.履歴物件コード_ラベル.AutoSize = True
        Me.履歴物件コード_ラベル.Location = New System.Drawing.Point(1792, 83)
        Me.履歴物件コード_ラベル.Name = "履歴物件コード_ラベル"
        Me.履歴物件コード_ラベル.TabIndex = 48
        Me.履歴物件コード_ラベル.Text = "履歴物件コード"
        '
        ' セグメントコード_ラベル
        '
        Me.セグメントコード_ラベル.AutoSize = True
        Me.セグメントコード_ラベル.Location = New System.Drawing.Point(1217, 83)
        Me.セグメントコード_ラベル.Name = "セグメントコード_ラベル"
        Me.セグメントコード_ラベル.TabIndex = 49
        Me.セグメントコード_ラベル.Text = "ｾｸﾞﾒﾝﾄ\015\012ｺｰﾄﾞ"
        '
        ' 取引通貨コード_ラベル
        '
        Me.取引通貨コード_ラベル.AutoSize = True
        Me.取引通貨コード_ラベル.Location = New System.Drawing.Point(1274, 83)
        Me.取引通貨コード_ラベル.Name = "取引通貨コード_ラベル"
        Me.取引通貨コード_ラベル.TabIndex = 50
        Me.取引通貨コード_ラベル.Text = "取引通貨コード"
        '
        ' 資金コード_ラベル
        '
        Me.資金コード_ラベル.AutoSize = True
        Me.資金コード_ラベル.Location = New System.Drawing.Point(1331, 83)
        Me.資金コード_ラベル.Name = "資金コード_ラベル"
        Me.資金コード_ラベル.TabIndex = 51
        Me.資金コード_ラベル.Text = "資金\015\012コード"
        '
        ' 基本通貨発生金額_ラベル
        '
        Me.基本通貨発生金額_ラベル.AutoSize = True
        Me.基本通貨発生金額_ラベル.Location = New System.Drawing.Point(1471, 83)
        Me.基本通貨発生金額_ラベル.Name = "基本通貨発生金額_ラベル"
        Me.基本通貨発生金額_ラベル.TabIndex = 52
        Me.基本通貨発生金額_ラベル.Text = "基本通貨発生金額"
        '
        ' 消費税区分コード_ラベル
        '
        Me.消費税区分コード_ラベル.AutoSize = True
        Me.消費税区分コード_ラベル.Location = New System.Drawing.Point(1387, 83)
        Me.消費税区分コード_ラベル.Name = "消費税区分コード_ラベル"
        Me.消費税区分コード_ラベル.TabIndex = 53
        Me.消費税区分コード_ラベル.Text = "消費税\015\012区分\015\012コード\015\012CD"
        '
        ' 参考消費税金額_ラベル
        '
        Me.参考消費税金額_ラベル.AutoSize = True
        Me.参考消費税金額_ラベル.Location = New System.Drawing.Point(1660, 83)
        Me.参考消費税金額_ラベル.Name = "参考消費税金額_ラベル"
        Me.参考消費税金額_ラベル.TabIndex = 54
        Me.参考消費税金額_ラベル.Text = "参考消費税\015\012金額"
        '
        ' 文字摘要１_ラベル
        '
        Me.文字摘要１_ラベル.AutoSize = True
        Me.文字摘要１_ラベル.Location = New System.Drawing.Point(1849, 83)
        Me.文字摘要１_ラベル.Name = "文字摘要１_ラベル"
        Me.文字摘要１_ラベル.TabIndex = 55
        Me.文字摘要１_ラベル.Text = "文字摘要１"
        '
        ' ラベル521
        '
        Me.ラベル521.AutoSize = True
        Me.ラベル521.Location = New System.Drawing.Point(18, 56)
        Me.ラベル521.Name = "ラベル521"
        Me.ラベル521.TabIndex = 56
        Me.ラベル521.Text = "処理年月"
        '
        ' ラベル523
        '
        Me.ラベル523.AutoSize = True
        Me.ラベル523.Location = New System.Drawing.Point(226, 56)
        Me.ラベル523.Name = "ラベル523"
        Me.ラベル523.TabIndex = 57
        Me.ラベル523.Text = "出力先ﾌｧｲﾙ名"
        '
        ' 会社コード_ラベル
        '
        Me.会社コード_ラベル.AutoSize = True
        Me.会社コード_ラベル.Location = New System.Drawing.Point(98, 83)
        Me.会社コード_ラベル.Name = "会社コード_ラベル"
        Me.会社コード_ラベル.TabIndex = 58
        Me.会社コード_ラベル.Text = "会社\015\012コード"
        '
        ' 起票社員コード_ラベル
        '
        Me.起票社員コード_ラベル.AutoSize = True
        Me.起票社員コード_ラベル.Location = New System.Drawing.Point(155, 83)
        Me.起票社員コード_ラベル.Name = "起票社員コード_ラベル"
        Me.起票社員コード_ラベル.TabIndex = 59
        Me.起票社員コード_ラベル.Text = "起票社員コード"
        '
        ' 起票部門コード_ラベル
        '
        Me.起票部門コード_ラベル.AutoSize = True
        Me.起票部門コード_ラベル.Location = New System.Drawing.Point(211, 83)
        Me.起票部門コード_ラベル.Name = "起票部門コード_ラベル"
        Me.起票部門コード_ラベル.TabIndex = 60
        Me.起票部門コード_ラベル.Text = "起票部門コード"
        '
        ' 承認社員コード_ラベル
        '
        Me.承認社員コード_ラベル.AutoSize = True
        Me.承認社員コード_ラベル.Location = New System.Drawing.Point(268, 83)
        Me.承認社員コード_ラベル.Name = "承認社員コード_ラベル"
        Me.承認社員コード_ラベル.TabIndex = 61
        Me.承認社員コード_ラベル.Text = "承認社員コード"
        '
        ' 承認日付_ラベル
        '
        Me.承認日付_ラベル.AutoSize = True
        Me.承認日付_ラベル.Location = New System.Drawing.Point(325, 83)
        Me.承認日付_ラベル.Name = "承認日付_ラベル"
        Me.承認日付_ラベル.TabIndex = 62
        Me.承認日付_ラベル.Text = "承認日付"
        '
        ' 承認状態区分_ラベル
        '
        Me.承認状態区分_ラベル.AutoSize = True
        Me.承認状態区分_ラベル.Location = New System.Drawing.Point(393, 83)
        Me.承認状態区分_ラベル.Name = "承認状態区分_ラベル"
        Me.承認状態区分_ラベル.TabIndex = 63
        Me.承認状態区分_ラベル.Text = "承認状態区分"
        '
        ' 仕訳種別区分_ラベル
        '
        Me.仕訳種別区分_ラベル.AutoSize = True
        Me.仕訳種別区分_ラベル.Location = New System.Drawing.Point(431, 83)
        Me.仕訳種別区分_ラベル.Name = "仕訳種別区分_ラベル"
        Me.仕訳種別区分_ラベル.TabIndex = 64
        Me.仕訳種別区分_ラベル.Text = "仕訳種別区分"
        '
        ' 伝票日付_ラベル
        '
        Me.伝票日付_ラベル.AutoSize = True
        Me.伝票日付_ラベル.Location = New System.Drawing.Point(468, 83)
        Me.伝票日付_ラベル.Name = "伝票日付_ラベル"
        Me.伝票日付_ラベル.TabIndex = 65
        Me.伝票日付_ラベル.Text = "伝票日付"
        '
        ' 伝票番号_ラベル
        '
        Me.伝票番号_ラベル.AutoSize = True
        Me.伝票番号_ラベル.Location = New System.Drawing.Point(536, 83)
        Me.伝票番号_ラベル.Name = "伝票番号_ラベル"
        Me.伝票番号_ラベル.TabIndex = 66
        Me.伝票番号_ラベル.Text = "伝票番号"
        '
        ' 伝票操作禁止区分_ラベル
        '
        Me.伝票操作禁止区分_ラベル.AutoSize = True
        Me.伝票操作禁止区分_ラベル.Location = New System.Drawing.Point(593, 83)
        Me.伝票操作禁止区分_ラベル.Name = "伝票操作禁止区分_ラベル"
        Me.伝票操作禁止区分_ラベル.TabIndex = 67
        Me.伝票操作禁止区分_ラベル.Text = "伝票操作禁止区分"
        '
        ' 伝票備考_ラベル
        '
        Me.伝票備考_ラベル.AutoSize = True
        Me.伝票備考_ラベル.Location = New System.Drawing.Point(631, 83)
        Me.伝票備考_ラベル.Name = "伝票備考_ラベル"
        Me.伝票備考_ラベル.TabIndex = 68
        Me.伝票備考_ラベル.Text = "伝票備考"
        '
        ' 行番号_ラベル
        '
        Me.行番号_ラベル.AutoSize = True
        Me.行番号_ラベル.Location = New System.Drawing.Point(707, 83)
        Me.行番号_ラベル.Name = "行番号_ラベル"
        Me.行番号_ラベル.TabIndex = 69
        Me.行番号_ラベル.Text = "行番号"
        '
        ' 伝票明細貸借区分_ラベル
        '
        Me.伝票明細貸借区分_ラベル.AutoSize = True
        Me.伝票明細貸借区分_ラベル.Location = New System.Drawing.Point(763, 83)
        Me.伝票明細貸借区分_ラベル.Name = "伝票明細貸借区分_ラベル"
        Me.伝票明細貸借区分_ラベル.TabIndex = 70
        Me.伝票明細貸借区分_ラベル.Text = "伝票明細貸借区分"
        '
        ' 細目コード_ラベル
        '
        Me.細目コード_ラベル.AutoSize = True
        Me.細目コード_ラベル.Location = New System.Drawing.Point(990, 83)
        Me.細目コード_ラベル.Name = "細目コード_ラベル"
        Me.細目コード_ラベル.TabIndex = 71
        Me.細目コード_ラベル.Text = "細目\015\012コード"
        '
        ' 集計拡張コード１識別区分_ラベル
        '
        Me.集計拡張コード１識別区分_ラベル.AutoSize = True
        Me.集計拡張コード１識別区分_ラベル.Location = New System.Drawing.Point(1047, 83)
        Me.集計拡張コード１識別区分_ラベル.Name = "集計拡張コード１識別区分_ラベル"
        Me.集計拡張コード１識別区分_ラベル.TabIndex = 72
        Me.集計拡張コード１識別区分_ラベル.Text = "集計拡張ｺｰﾄﾞ1識別区分"
        '
        ' 集計拡張コード１_ラベル
        '
        Me.集計拡張コード１_ラベル.AutoSize = True
        Me.集計拡張コード１_ラベル.Location = New System.Drawing.Point(1104, 83)
        Me.集計拡張コード１_ラベル.Name = "集計拡張コード１_ラベル"
        Me.集計拡張コード１_ラベル.TabIndex = 73
        Me.集計拡張コード１_ラベル.Text = "集計拡張\015\012ｺｰﾄﾞ1"
        '
        ' 課税区分_ラベル
        '
        Me.課税区分_ラベル.AutoSize = True
        Me.課税区分_ラベル.Location = New System.Drawing.Point(1754, 83)
        Me.課税区分_ラベル.Name = "課税区分_ラベル"
        Me.課税区分_ラベル.TabIndex = 74
        Me.課税区分_ラベル.Text = "課税区分"
        '
        ' 税率区分_ラベル
        '
        Me.税率区分_ラベル.AutoSize = True
        Me.税率区分_ラベル.Location = New System.Drawing.Point(1433, 83)
        Me.税率区分_ラベル.Name = "税率区分_ラベル"
        Me.税率区分_ラベル.TabIndex = 75
        Me.税率区分_ラベル.Text = "税率区分"
        '
        ' 取引通貨発生金額_ラベル
        '
        Me.取引通貨発生金額_ラベル.AutoSize = True
        Me.取引通貨発生金額_ラベル.Location = New System.Drawing.Point(1565, 83)
        Me.取引通貨発生金額_ラベル.Name = "取引通貨発生金額_ラベル"
        Me.取引通貨発生金額_ラベル.TabIndex = 76
        Me.取引通貨発生金額_ラベル.Text = "取引通貨発生金額"
        '
        ' 入力システム区分_ラベル
        '
        Me.入力システム区分_ラベル.AutoSize = True
        Me.入力システム区分_ラベル.Location = New System.Drawing.Point(60, 83)
        Me.入力システム区分_ラベル.Name = "入力システム区分_ラベル"
        Me.入力システム区分_ラベル.TabIndex = 77
        Me.入力システム区分_ラベル.Text = "入力\015\012ｼｽﾃﾑ\015\012区分"
        '
        ' ラベル34
        '
        Me.ラベル34.AutoSize = True
        Me.ラベル34.Location = New System.Drawing.Point(1409, 0)
        Me.ラベル34.Name = "ラベル34"
        Me.ラベル34.TabIndex = 78
        Me.ラベル34.Text = "借方合計"
        '
        ' ラベル35
        '
        Me.ラベル35.AutoSize = True
        Me.ラベル35.Location = New System.Drawing.Point(1409, 18)
        Me.ラベル35.Name = "ラベル35"
        Me.ラベル35.TabIndex = 79
        Me.ラベル35.Text = "貸方合計"
        '
        ' Form_fc_仕訳出力_最終確認_RISO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 724)
        Me.Controls.Add(Me.入力番号_ラベル)
        Me.Controls.Add(Me.細目コード識別区分_ラベル)
        Me.Controls.Add(Me.勘定科目コード_ラベル)
        Me.Controls.Add(Me.会計部門コード_ラベル)
        Me.Controls.Add(Me.取引先コード_ラベル)
        Me.Controls.Add(Me.履歴物件コード_ラベル)
        Me.Controls.Add(Me.セグメントコード_ラベル)
        Me.Controls.Add(Me.取引通貨コード_ラベル)
        Me.Controls.Add(Me.資金コード_ラベル)
        Me.Controls.Add(Me.基本通貨発生金額_ラベル)
        Me.Controls.Add(Me.消費税区分コード_ラベル)
        Me.Controls.Add(Me.参考消費税金額_ラベル)
        Me.Controls.Add(Me.文字摘要１_ラベル)
        Me.Controls.Add(Me.ラベル521)
        Me.Controls.Add(Me.ラベル523)
        Me.Controls.Add(Me.会社コード_ラベル)
        Me.Controls.Add(Me.起票社員コード_ラベル)
        Me.Controls.Add(Me.起票部門コード_ラベル)
        Me.Controls.Add(Me.承認社員コード_ラベル)
        Me.Controls.Add(Me.承認日付_ラベル)
        Me.Controls.Add(Me.承認状態区分_ラベル)
        Me.Controls.Add(Me.仕訳種別区分_ラベル)
        Me.Controls.Add(Me.伝票日付_ラベル)
        Me.Controls.Add(Me.伝票番号_ラベル)
        Me.Controls.Add(Me.伝票操作禁止区分_ラベル)
        Me.Controls.Add(Me.伝票備考_ラベル)
        Me.Controls.Add(Me.行番号_ラベル)
        Me.Controls.Add(Me.伝票明細貸借区分_ラベル)
        Me.Controls.Add(Me.細目コード_ラベル)
        Me.Controls.Add(Me.集計拡張コード１識別区分_ラベル)
        Me.Controls.Add(Me.集計拡張コード１_ラベル)
        Me.Controls.Add(Me.課税区分_ラベル)
        Me.Controls.Add(Me.税率区分_ラベル)
        Me.Controls.Add(Me.取引通貨発生金額_ラベル)
        Me.Controls.Add(Me.入力システム区分_ラベル)
        Me.Controls.Add(Me.ラベル34)
        Me.Controls.Add(Me.ラベル35)
        Me.Controls.Add(Me.txt_処理年月)
        Me.Controls.Add(Me.txt_計上日_曜日)
        Me.Controls.Add(Me.txt_OUTPUT_FPATH)
        Me.Controls.Add(Me.txt_仕訳_ID)
        Me.Controls.Add(Me.入力番号)
        Me.Controls.Add(Me.細目コード識別区分)
        Me.Controls.Add(Me.勘定科目コード)
        Me.Controls.Add(Me.会計部門コード)
        Me.Controls.Add(Me.取引先コード)
        Me.Controls.Add(Me.履歴物件コード)
        Me.Controls.Add(Me.セグメントコード)
        Me.Controls.Add(Me.取引通貨コード)
        Me.Controls.Add(Me.資金コード)
        Me.Controls.Add(Me.基本通貨発生金額)
        Me.Controls.Add(Me.消費税区分コード)
        Me.Controls.Add(Me.参考消費税金額)
        Me.Controls.Add(Me.文字摘要１)
        Me.Controls.Add(Me.会社コード)
        Me.Controls.Add(Me.起票社員コード)
        Me.Controls.Add(Me.起票部門コード)
        Me.Controls.Add(Me.承認社員コード)
        Me.Controls.Add(Me.承認日付)
        Me.Controls.Add(Me.承認状態区分)
        Me.Controls.Add(Me.仕訳種別区分)
        Me.Controls.Add(Me.伝票日付)
        Me.Controls.Add(Me.伝票番号)
        Me.Controls.Add(Me.伝票操作禁止区分)
        Me.Controls.Add(Me.伝票備考)
        Me.Controls.Add(Me.行番号)
        Me.Controls.Add(Me.伝票明細貸借区分)
        Me.Controls.Add(Me.細目コード)
        Me.Controls.Add(Me.集計拡張コード１識別区分)
        Me.Controls.Add(Me.集計拡張コード１)
        Me.Controls.Add(Me.課税区分)
        Me.Controls.Add(Me.税率区分)
        Me.Controls.Add(Me.取引通貨発生金額)
        Me.Controls.Add(Me.入力システム区分)
        Me.Controls.Add(Me.txt_借方金額_SUM)
        Me.Controls.Add(Me.txt_貸方金額_SUM)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_FlexReportDLG)
        Me.Controls.Add(Me.cmd_選択)
        Me.Name = "Form_fc_仕訳出力_最終確認_RISO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳出力　最終確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents txt_処理年月 As System.Windows.Forms.TextBox
    Friend WithEvents txt_計上日_曜日 As System.Windows.Forms.TextBox
    Friend WithEvents txt_OUTPUT_FPATH As System.Windows.Forms.TextBox
    Friend WithEvents txt_仕訳_ID As System.Windows.Forms.TextBox
    Friend WithEvents 入力番号 As System.Windows.Forms.TextBox
    Friend WithEvents 細目コード識別区分 As System.Windows.Forms.TextBox
    Friend WithEvents 勘定科目コード As System.Windows.Forms.TextBox
    Friend WithEvents 会計部門コード As System.Windows.Forms.TextBox
    Friend WithEvents 取引先コード As System.Windows.Forms.TextBox
    Friend WithEvents 履歴物件コード As System.Windows.Forms.TextBox
    Friend WithEvents セグメントコード As System.Windows.Forms.TextBox
    Friend WithEvents 取引通貨コード As System.Windows.Forms.TextBox
    Friend WithEvents 資金コード As System.Windows.Forms.TextBox
    Friend WithEvents 基本通貨発生金額 As System.Windows.Forms.TextBox
    Friend WithEvents 消費税区分コード As System.Windows.Forms.TextBox
    Friend WithEvents 参考消費税金額 As System.Windows.Forms.TextBox
    Friend WithEvents 文字摘要１ As System.Windows.Forms.TextBox
    Friend WithEvents 会社コード As System.Windows.Forms.TextBox
    Friend WithEvents 起票社員コード As System.Windows.Forms.TextBox
    Friend WithEvents 起票部門コード As System.Windows.Forms.TextBox
    Friend WithEvents 承認社員コード As System.Windows.Forms.TextBox
    Friend WithEvents 承認日付 As System.Windows.Forms.TextBox
    Friend WithEvents 承認状態区分 As System.Windows.Forms.TextBox
    Friend WithEvents 仕訳種別区分 As System.Windows.Forms.TextBox
    Friend WithEvents 伝票日付 As System.Windows.Forms.TextBox
    Friend WithEvents 伝票番号 As System.Windows.Forms.TextBox
    Friend WithEvents 伝票操作禁止区分 As System.Windows.Forms.TextBox
    Friend WithEvents 伝票備考 As System.Windows.Forms.TextBox
    Friend WithEvents 行番号 As System.Windows.Forms.TextBox
    Friend WithEvents 伝票明細貸借区分 As System.Windows.Forms.TextBox
    Friend WithEvents 細目コード As System.Windows.Forms.TextBox
    Friend WithEvents 集計拡張コード１識別区分 As System.Windows.Forms.TextBox
    Friend WithEvents 集計拡張コード１ As System.Windows.Forms.TextBox
    Friend WithEvents 課税区分 As System.Windows.Forms.TextBox
    Friend WithEvents 税率区分 As System.Windows.Forms.TextBox
    Friend WithEvents 取引通貨発生金額 As System.Windows.Forms.TextBox
    Friend WithEvents 入力システム区分 As System.Windows.Forms.TextBox
    Friend WithEvents txt_借方金額_SUM As System.Windows.Forms.TextBox
    Friend WithEvents txt_貸方金額_SUM As System.Windows.Forms.TextBox
    Friend WithEvents 入力番号_ラベル As System.Windows.Forms.Label
    Friend WithEvents 細目コード識別区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 勘定科目コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 会計部門コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 取引先コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 履歴物件コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents セグメントコード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 取引通貨コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 資金コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 基本通貨発生金額_ラベル As System.Windows.Forms.Label
    Friend WithEvents 消費税区分コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 参考消費税金額_ラベル As System.Windows.Forms.Label
    Friend WithEvents 文字摘要１_ラベル As System.Windows.Forms.Label
    Friend WithEvents ラベル521 As System.Windows.Forms.Label
    Friend WithEvents ラベル523 As System.Windows.Forms.Label
    Friend WithEvents 会社コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 起票社員コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 起票部門コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 承認社員コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 承認日付_ラベル As System.Windows.Forms.Label
    Friend WithEvents 承認状態区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 仕訳種別区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 伝票日付_ラベル As System.Windows.Forms.Label
    Friend WithEvents 伝票番号_ラベル As System.Windows.Forms.Label
    Friend WithEvents 伝票操作禁止区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 伝票備考_ラベル As System.Windows.Forms.Label
    Friend WithEvents 行番号_ラベル As System.Windows.Forms.Label
    Friend WithEvents 伝票明細貸借区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 細目コード_ラベル As System.Windows.Forms.Label
    Friend WithEvents 集計拡張コード１識別区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 集計拡張コード１_ラベル As System.Windows.Forms.Label
    Friend WithEvents 課税区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 税率区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 取引通貨発生金額_ラベル As System.Windows.Forms.Label
    Friend WithEvents 入力システム区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents ラベル34 As System.Windows.Forms.Label
    Friend WithEvents ラベル35 As System.Windows.Forms.Label

End Class