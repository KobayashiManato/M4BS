<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_仕訳出力_VTC_明細

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
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_選択 = New System.Windows.Forms.Button()
        Me.cmd_実行 = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.txt_FOLDER = New System.Windows.Forms.TextBox()
        Me.txt_FILE_NM接頭辞 = New System.Windows.Forms.TextBox()
        Me.txt_FILE_NM = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_GETSUDO = New System.Windows.Forms.TextBox()
        Me.txt_D_KAMOKU = New System.Windows.Forms.TextBox()
        Me.txt_D_KINGAKU = New System.Windows.Forms.TextBox()
        Me.txt_SEIKYU_NO = New System.Windows.Forms.TextBox()
        Me.txt_DATA_KBN = New System.Windows.Forms.TextBox()
        Me.txt_CORP_CD = New System.Windows.Forms.TextBox()
        Me.txt_HASSEI_BASHO = New System.Windows.Forms.TextBox()
        Me.txt_KANJO_BASHO = New System.Windows.Forms.TextBox()
        Me.txt_KESSAI_KBN = New System.Windows.Forms.TextBox()
        Me.txt_KEIJO_DT = New System.Windows.Forms.TextBox()
        Me.txt_C_KAMOKU = New System.Windows.Forms.TextBox()
        Me.txt_D_KESSAI_BASHO = New System.Windows.Forms.TextBox()
        Me.txt_C_KESSAI_BASHO = New System.Windows.Forms.TextBox()
        Me.txt_D_KOUMOKU = New System.Windows.Forms.TextBox()
        Me.txt_C_KOUMOKU = New System.Windows.Forms.TextBox()
        Me.txt_D_YOUKEN = New System.Windows.Forms.TextBox()
        Me.txt_C_YOUKEN = New System.Windows.Forms.TextBox()
        Me.txt_D_SAIMOKU_A = New System.Windows.Forms.TextBox()
        Me.txt_C_SAIMOKU_A = New System.Windows.Forms.TextBox()
        Me.txt_D_SAIMOKU_B = New System.Windows.Forms.TextBox()
        Me.txt_C_SAIMOKU_B = New System.Windows.Forms.TextBox()
        Me.txt_C_KINGAKU = New System.Windows.Forms.TextBox()
        Me.txt_D_GN_KBN = New System.Windows.Forms.TextBox()
        Me.txt_C_GN_KBN = New System.Windows.Forms.TextBox()
        Me.txt_D_ZEI_KBN = New System.Windows.Forms.TextBox()
        Me.txt_C_ZEI_KBN = New System.Windows.Forms.TextBox()
        Me.txt_TEKIYO_CD = New System.Windows.Forms.TextBox()
        Me.txt_ZEI = New System.Windows.Forms.TextBox()
        Me.txt_ZRITU = New System.Windows.Forms.TextBox()
        Me.txt_INPUT_KBN = New System.Windows.Forms.TextBox()
        Me.txt_SWK_KBN_NM = New System.Windows.Forms.TextBox()
        Me.txt_D_KINGAKU_SUM = New System.Windows.Forms.TextBox()
        Me.txt_C_KINGAKU_SUM = New System.Windows.Forms.TextBox()
        Me.txt_ZEI_SUM = New System.Windows.Forms.TextBox()
        Me.貸借区分_ラベル = New System.Windows.Forms.Label()
        Me.勘定科目CD_ラベル = New System.Windows.Forms.Label()
        Me.金額_ラベル = New System.Windows.Forms.Label()
        Me.ラベル523 = New System.Windows.Forms.Label()
        Me.ラベル37 = New System.Windows.Forms.Label()
        Me.ラベル39 = New System.Windows.Forms.Label()
        Me.ラベル41 = New System.Windows.Forms.Label()
        Me.ラベル43 = New System.Windows.Forms.Label()
        Me.ラベル45 = New System.Windows.Forms.Label()
        Me.ラベル47 = New System.Windows.Forms.Label()
        Me.ラベル49 = New System.Windows.Forms.Label()
        Me.ラベル54 = New System.Windows.Forms.Label()
        Me.ラベル57 = New System.Windows.Forms.Label()
        Me.ラベル60 = New System.Windows.Forms.Label()
        Me.ラベル63 = New System.Windows.Forms.Label()
        Me.ラベル66 = New System.Windows.Forms.Label()
        Me.ラベル72 = New System.Windows.Forms.Label()
        Me.ラベル73 = New System.Windows.Forms.Label()
        Me.ラベル78 = New System.Windows.Forms.Label()
        Me.ラベル81 = New System.Windows.Forms.Label()
        Me.ラベル83 = New System.Windows.Forms.Label()
        Me.ラベル85 = New System.Windows.Forms.Label()
        Me.ラベル87 = New System.Windows.Forms.Label()
        Me.ラベル88 = New System.Windows.Forms.Label()
        Me.ラベル89 = New System.Windows.Forms.Label()
        Me.ラベル90 = New System.Windows.Forms.Label()
        Me.ラベル91 = New System.Windows.Forms.Label()
        Me.ラベル92 = New System.Windows.Forms.Label()
        Me.ラベル93 = New System.Windows.Forms.Label()
        Me.ラベル94 = New System.Windows.Forms.Label()
        Me.ラベル95 = New System.Windows.Forms.Label()
        Me.ラベル96 = New System.Windows.Forms.Label()
        Me.ラベル97 = New System.Windows.Forms.Label()
        Me.ラベル526 = New System.Windows.Forms.Label()
        Me.ラベル548 = New System.Windows.Forms.Label()
        Me.ラベル103 = New System.Windows.Forms.Label()
        Me.ラベル105 = New System.Windows.Forms.Label()
        Me.lbl_固定ファイル名 = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.ラベル34 = New System.Windows.Forms.Label()
        Me.ラベル35 = New System.Windows.Forms.Label()
        Me.ラベル101 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(907, 0)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(75, 26)
        Me.cmd_FlexReportDLG.TabIndex = 0
        Me.cmd_FlexReportDLG.Text = "印刷(&P)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        ' cmd_選択
        '
        Me.cmd_選択.Location = New System.Drawing.Point(480, 98)
        Me.cmd_選択.Name = "cmd_選択"
        Me.cmd_選択.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択.TabIndex = 1
        Me.cmd_選択.Text = "選択(&S)"
        Me.cmd_選択.UseVisualStyleBackColor = True
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(7, 7)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 2
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(90, 7)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 3
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' txt_FOLDER
        '
        Me.txt_FOLDER.Location = New System.Drawing.Point(98, 98)
        Me.txt_FOLDER.Name = "txt_FOLDER"
        Me.txt_FOLDER.Size = New System.Drawing.Size(377, 19)
        Me.txt_FOLDER.TabIndex = 4
        '
        ' txt_FILE_NM接頭辞
        '
        Me.txt_FILE_NM接頭辞.Location = New System.Drawing.Point(98, 56)
        Me.txt_FILE_NM接頭辞.Name = "txt_FILE_NM接頭辞"
        Me.txt_FILE_NM接頭辞.Size = New System.Drawing.Size(113, 19)
        Me.txt_FILE_NM接頭辞.TabIndex = 5
        '
        ' txt_FILE_NM
        '
        Me.txt_FILE_NM.Location = New System.Drawing.Point(1001, 37)
        Me.txt_FILE_NM.Name = "txt_FILE_NM"
        Me.txt_FILE_NM.Size = New System.Drawing.Size(226, 19)
        Me.txt_FILE_NM.TabIndex = 6
        '
        ' txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(805, 0)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(64, 19)
        Me.txt_ID.TabIndex = 7
        '
        ' txt_GETSUDO
        '
        Me.txt_GETSUDO.Location = New System.Drawing.Point(102, 0)
        Me.txt_GETSUDO.Name = "txt_GETSUDO"
        Me.txt_GETSUDO.Size = New System.Drawing.Size(52, 19)
        Me.txt_GETSUDO.TabIndex = 8
        '
        ' txt_D_KAMOKU
        '
        Me.txt_D_KAMOKU.Location = New System.Drawing.Point(457, 0)
        Me.txt_D_KAMOKU.Name = "txt_D_KAMOKU"
        Me.txt_D_KAMOKU.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_KAMOKU.TabIndex = 9
        '
        ' txt_D_KINGAKU
        '
        Me.txt_D_KINGAKU.Location = New System.Drawing.Point(684, 0)
        Me.txt_D_KINGAKU.Name = "txt_D_KINGAKU"
        Me.txt_D_KINGAKU.Size = New System.Drawing.Size(94, 19)
        Me.txt_D_KINGAKU.TabIndex = 10
        '
        ' txt_SEIKYU_NO
        '
        Me.txt_SEIKYU_NO.Location = New System.Drawing.Point(154, 0)
        Me.txt_SEIKYU_NO.Name = "txt_SEIKYU_NO"
        Me.txt_SEIKYU_NO.Size = New System.Drawing.Size(50, 19)
        Me.txt_SEIKYU_NO.TabIndex = 11
        '
        ' txt_DATA_KBN
        '
        Me.txt_DATA_KBN.Location = New System.Drawing.Point(192, 0)
        Me.txt_DATA_KBN.Name = "txt_DATA_KBN"
        Me.txt_DATA_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_DATA_KBN.TabIndex = 12
        '
        ' txt_CORP_CD
        '
        Me.txt_CORP_CD.Location = New System.Drawing.Point(230, 0)
        Me.txt_CORP_CD.Name = "txt_CORP_CD"
        Me.txt_CORP_CD.Size = New System.Drawing.Size(50, 19)
        Me.txt_CORP_CD.TabIndex = 13
        '
        ' txt_HASSEI_BASHO
        '
        Me.txt_HASSEI_BASHO.Location = New System.Drawing.Point(268, 0)
        Me.txt_HASSEI_BASHO.Name = "txt_HASSEI_BASHO"
        Me.txt_HASSEI_BASHO.Size = New System.Drawing.Size(50, 19)
        Me.txt_HASSEI_BASHO.TabIndex = 14
        '
        ' txt_KANJO_BASHO
        '
        Me.txt_KANJO_BASHO.Location = New System.Drawing.Point(306, 0)
        Me.txt_KANJO_BASHO.Name = "txt_KANJO_BASHO"
        Me.txt_KANJO_BASHO.Size = New System.Drawing.Size(50, 19)
        Me.txt_KANJO_BASHO.TabIndex = 15
        '
        ' txt_KESSAI_KBN
        '
        Me.txt_KESSAI_KBN.Location = New System.Drawing.Point(343, 0)
        Me.txt_KESSAI_KBN.Name = "txt_KESSAI_KBN"
        Me.txt_KESSAI_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_KESSAI_KBN.TabIndex = 16
        '
        ' txt_KEIJO_DT
        '
        Me.txt_KEIJO_DT.Location = New System.Drawing.Point(381, 0)
        Me.txt_KEIJO_DT.Name = "txt_KEIJO_DT"
        Me.txt_KEIJO_DT.Size = New System.Drawing.Size(71, 19)
        Me.txt_KEIJO_DT.TabIndex = 17
        '
        ' txt_C_KAMOKU
        '
        Me.txt_C_KAMOKU.Location = New System.Drawing.Point(857, 0)
        Me.txt_C_KAMOKU.Name = "txt_C_KAMOKU"
        Me.txt_C_KAMOKU.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_KAMOKU.TabIndex = 18
        '
        ' txt_D_KESSAI_BASHO
        '
        Me.txt_D_KESSAI_BASHO.Location = New System.Drawing.Point(495, 0)
        Me.txt_D_KESSAI_BASHO.Name = "txt_D_KESSAI_BASHO"
        Me.txt_D_KESSAI_BASHO.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_KESSAI_BASHO.TabIndex = 19
        '
        ' txt_C_KESSAI_BASHO
        '
        Me.txt_C_KESSAI_BASHO.Location = New System.Drawing.Point(895, 0)
        Me.txt_C_KESSAI_BASHO.Name = "txt_C_KESSAI_BASHO"
        Me.txt_C_KESSAI_BASHO.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_KESSAI_BASHO.TabIndex = 20
        '
        ' txt_D_KOUMOKU
        '
        Me.txt_D_KOUMOKU.Location = New System.Drawing.Point(532, 0)
        Me.txt_D_KOUMOKU.Name = "txt_D_KOUMOKU"
        Me.txt_D_KOUMOKU.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_KOUMOKU.TabIndex = 21
        '
        ' txt_C_KOUMOKU
        '
        Me.txt_C_KOUMOKU.Location = New System.Drawing.Point(933, 0)
        Me.txt_C_KOUMOKU.Name = "txt_C_KOUMOKU"
        Me.txt_C_KOUMOKU.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_KOUMOKU.TabIndex = 22
        '
        ' txt_D_YOUKEN
        '
        Me.txt_D_YOUKEN.Location = New System.Drawing.Point(570, 0)
        Me.txt_D_YOUKEN.Name = "txt_D_YOUKEN"
        Me.txt_D_YOUKEN.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_YOUKEN.TabIndex = 23
        '
        ' txt_C_YOUKEN
        '
        Me.txt_C_YOUKEN.Location = New System.Drawing.Point(971, 0)
        Me.txt_C_YOUKEN.Name = "txt_C_YOUKEN"
        Me.txt_C_YOUKEN.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_YOUKEN.TabIndex = 24
        '
        ' txt_D_SAIMOKU_A
        '
        Me.txt_D_SAIMOKU_A.Location = New System.Drawing.Point(608, 0)
        Me.txt_D_SAIMOKU_A.Name = "txt_D_SAIMOKU_A"
        Me.txt_D_SAIMOKU_A.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_SAIMOKU_A.TabIndex = 25
        '
        ' txt_C_SAIMOKU_A
        '
        Me.txt_C_SAIMOKU_A.Location = New System.Drawing.Point(1009, 0)
        Me.txt_C_SAIMOKU_A.Name = "txt_C_SAIMOKU_A"
        Me.txt_C_SAIMOKU_A.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_SAIMOKU_A.TabIndex = 26
        '
        ' txt_D_SAIMOKU_B
        '
        Me.txt_D_SAIMOKU_B.Location = New System.Drawing.Point(646, 0)
        Me.txt_D_SAIMOKU_B.Name = "txt_D_SAIMOKU_B"
        Me.txt_D_SAIMOKU_B.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_SAIMOKU_B.TabIndex = 27
        '
        ' txt_C_SAIMOKU_B
        '
        Me.txt_C_SAIMOKU_B.Location = New System.Drawing.Point(1046, 0)
        Me.txt_C_SAIMOKU_B.Name = "txt_C_SAIMOKU_B"
        Me.txt_C_SAIMOKU_B.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_SAIMOKU_B.TabIndex = 28
        '
        ' txt_C_KINGAKU
        '
        Me.txt_C_KINGAKU.Location = New System.Drawing.Point(1084, 0)
        Me.txt_C_KINGAKU.Name = "txt_C_KINGAKU"
        Me.txt_C_KINGAKU.Size = New System.Drawing.Size(94, 19)
        Me.txt_C_KINGAKU.TabIndex = 29
        '
        ' txt_D_GN_KBN
        '
        Me.txt_D_GN_KBN.Location = New System.Drawing.Point(778, 0)
        Me.txt_D_GN_KBN.Name = "txt_D_GN_KBN"
        Me.txt_D_GN_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_GN_KBN.TabIndex = 30
        '
        ' txt_C_GN_KBN
        '
        Me.txt_C_GN_KBN.Location = New System.Drawing.Point(1179, 0)
        Me.txt_C_GN_KBN.Name = "txt_C_GN_KBN"
        Me.txt_C_GN_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_GN_KBN.TabIndex = 31
        '
        ' txt_D_ZEI_KBN
        '
        Me.txt_D_ZEI_KBN.Location = New System.Drawing.Point(816, 0)
        Me.txt_D_ZEI_KBN.Name = "txt_D_ZEI_KBN"
        Me.txt_D_ZEI_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_D_ZEI_KBN.TabIndex = 32
        '
        ' txt_C_ZEI_KBN
        '
        Me.txt_C_ZEI_KBN.Location = New System.Drawing.Point(1217, 0)
        Me.txt_C_ZEI_KBN.Name = "txt_C_ZEI_KBN"
        Me.txt_C_ZEI_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_C_ZEI_KBN.TabIndex = 33
        '
        ' txt_TEKIYO_CD
        '
        Me.txt_TEKIYO_CD.Location = New System.Drawing.Point(1258, 0)
        Me.txt_TEKIYO_CD.Name = "txt_TEKIYO_CD"
        Me.txt_TEKIYO_CD.Size = New System.Drawing.Size(50, 19)
        Me.txt_TEKIYO_CD.TabIndex = 34
        '
        ' txt_ZEI
        '
        Me.txt_ZEI.Location = New System.Drawing.Point(1296, 0)
        Me.txt_ZEI.Name = "txt_ZEI"
        Me.txt_ZEI.Size = New System.Drawing.Size(94, 19)
        Me.txt_ZEI.TabIndex = 35
        '
        ' txt_ZRITU
        '
        Me.txt_ZRITU.Location = New System.Drawing.Point(1390, 0)
        Me.txt_ZRITU.Name = "txt_ZRITU"
        Me.txt_ZRITU.Size = New System.Drawing.Size(50, 19)
        Me.txt_ZRITU.TabIndex = 36
        '
        ' txt_INPUT_KBN
        '
        Me.txt_INPUT_KBN.Location = New System.Drawing.Point(1428, 0)
        Me.txt_INPUT_KBN.Name = "txt_INPUT_KBN"
        Me.txt_INPUT_KBN.Size = New System.Drawing.Size(50, 19)
        Me.txt_INPUT_KBN.TabIndex = 37
        '
        ' txt_SWK_KBN_NM
        '
        Me.txt_SWK_KBN_NM.Location = New System.Drawing.Point(3, 0)
        Me.txt_SWK_KBN_NM.Name = "txt_SWK_KBN_NM"
        Me.txt_SWK_KBN_NM.Size = New System.Drawing.Size(98, 19)
        Me.txt_SWK_KBN_NM.TabIndex = 38
        '
        ' txt_D_KINGAKU_SUM
        '
        Me.txt_D_KINGAKU_SUM.Location = New System.Drawing.Point(684, 3)
        Me.txt_D_KINGAKU_SUM.Name = "txt_D_KINGAKU_SUM"
        Me.txt_D_KINGAKU_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_D_KINGAKU_SUM.TabIndex = 39
        '
        ' txt_C_KINGAKU_SUM
        '
        Me.txt_C_KINGAKU_SUM.Location = New System.Drawing.Point(1084, 3)
        Me.txt_C_KINGAKU_SUM.Name = "txt_C_KINGAKU_SUM"
        Me.txt_C_KINGAKU_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_C_KINGAKU_SUM.TabIndex = 40
        '
        ' txt_ZEI_SUM
        '
        Me.txt_ZEI_SUM.Location = New System.Drawing.Point(1296, 3)
        Me.txt_ZEI_SUM.Name = "txt_ZEI_SUM"
        Me.txt_ZEI_SUM.Size = New System.Drawing.Size(94, 19)
        Me.txt_ZEI_SUM.TabIndex = 41
        '
        ' 貸借区分_ラベル
        '
        Me.貸借区分_ラベル.AutoSize = True
        Me.貸借区分_ラベル.Location = New System.Drawing.Point(102, 120)
        Me.貸借区分_ラベル.Name = "貸借区分_ラベル"
        Me.貸借区分_ラベル.TabIndex = 42
        Me.貸借区分_ラベル.Text = "処理\015\012年月"
        '
        ' 勘定科目CD_ラベル
        '
        Me.勘定科目CD_ラベル.AutoSize = True
        Me.勘定科目CD_ラベル.Location = New System.Drawing.Point(457, 136)
        Me.勘定科目CD_ラベル.Name = "勘定科目CD_ラベル"
        Me.勘定科目CD_ラベル.TabIndex = 43
        Me.勘定科目CD_ラベル.Text = "勘定\015\012科目"
        '
        ' 金額_ラベル
        '
        Me.金額_ラベル.AutoSize = True
        Me.金額_ラベル.Location = New System.Drawing.Point(684, 136)
        Me.金額_ラベル.Name = "金額_ラベル"
        Me.金額_ラベル.TabIndex = 44
        Me.金額_ラベル.Text = "金額"
        '
        ' ラベル523
        '
        Me.ラベル523.AutoSize = True
        Me.ラベル523.Location = New System.Drawing.Point(3, 98)
        Me.ラベル523.Name = "ラベル523"
        Me.ラベル523.TabIndex = 45
        Me.ラベル523.Text = "出力先ﾌｫﾙﾀﾞ名"
        '
        ' ラベル37
        '
        Me.ラベル37.AutoSize = True
        Me.ラベル37.Location = New System.Drawing.Point(154, 120)
        Me.ラベル37.Name = "ラベル37"
        Me.ラベル37.TabIndex = 46
        Me.ラベル37.Text = "請求\015\012No."
        '
        ' ラベル39
        '
        Me.ラベル39.AutoSize = True
        Me.ラベル39.Location = New System.Drawing.Point(192, 120)
        Me.ラベル39.Name = "ラベル39"
        Me.ラベル39.TabIndex = 47
        Me.ラベル39.Text = "ﾃﾞｰﾀ\015\012区分"
        '
        ' ラベル41
        '
        Me.ラベル41.AutoSize = True
        Me.ラベル41.Location = New System.Drawing.Point(230, 120)
        Me.ラベル41.Name = "ラベル41"
        Me.ラベル41.TabIndex = 48
        Me.ラベル41.Text = "会社\015\012CD"
        '
        ' ラベル43
        '
        Me.ラベル43.AutoSize = True
        Me.ラベル43.Location = New System.Drawing.Point(268, 120)
        Me.ラベル43.Name = "ラベル43"
        Me.ラベル43.TabIndex = 49
        Me.ラベル43.Text = "発生\015\012場所"
        '
        ' ラベル45
        '
        Me.ラベル45.AutoSize = True
        Me.ラベル45.Location = New System.Drawing.Point(306, 120)
        Me.ラベル45.Name = "ラベル45"
        Me.ラベル45.TabIndex = 50
        Me.ラベル45.Text = "勘定\015\012場所"
        '
        ' ラベル47
        '
        Me.ラベル47.AutoSize = True
        Me.ラベル47.Location = New System.Drawing.Point(343, 120)
        Me.ラベル47.Name = "ラベル47"
        Me.ラベル47.TabIndex = 51
        Me.ラベル47.Text = "決済\015\012区分"
        '
        ' ラベル49
        '
        Me.ラベル49.AutoSize = True
        Me.ラベル49.Location = New System.Drawing.Point(381, 120)
        Me.ラベル49.Name = "ラベル49"
        Me.ラベル49.TabIndex = 52
        Me.ラベル49.Text = "処理\015\012年月日"
        '
        ' ラベル54
        '
        Me.ラベル54.AutoSize = True
        Me.ラベル54.Location = New System.Drawing.Point(495, 136)
        Me.ラベル54.Name = "ラベル54"
        Me.ラベル54.TabIndex = 53
        Me.ラベル54.Text = "決済\015\012場所"
        '
        ' ラベル57
        '
        Me.ラベル57.AutoSize = True
        Me.ラベル57.Location = New System.Drawing.Point(532, 136)
        Me.ラベル57.Name = "ラベル57"
        Me.ラベル57.TabIndex = 54
        Me.ラベル57.Text = "項目"
        '
        ' ラベル60
        '
        Me.ラベル60.AutoSize = True
        Me.ラベル60.Location = New System.Drawing.Point(570, 136)
        Me.ラベル60.Name = "ラベル60"
        Me.ラベル60.TabIndex = 55
        Me.ラベル60.Text = "要件"
        '
        ' ラベル63
        '
        Me.ラベル63.AutoSize = True
        Me.ラベル63.Location = New System.Drawing.Point(608, 136)
        Me.ラベル63.Name = "ラベル63"
        Me.ラベル63.TabIndex = 56
        Me.ラベル63.Text = "細目\015\012A"
        '
        ' ラベル66
        '
        Me.ラベル66.AutoSize = True
        Me.ラベル66.Location = New System.Drawing.Point(646, 136)
        Me.ラベル66.Name = "ラベル66"
        Me.ラベル66.TabIndex = 57
        Me.ラベル66.Text = "細目\015\012B"
        '
        ' ラベル72
        '
        Me.ラベル72.AutoSize = True
        Me.ラベル72.Location = New System.Drawing.Point(778, 136)
        Me.ラベル72.Name = "ラベル72"
        Me.ラベル72.TabIndex = 58
        Me.ラベル72.Text = "GN\015\012区分"
        '
        ' ラベル73
        '
        Me.ラベル73.AutoSize = True
        Me.ラベル73.Location = New System.Drawing.Point(816, 136)
        Me.ラベル73.Name = "ラベル73"
        Me.ラベル73.TabIndex = 59
        Me.ラベル73.Text = "税\015\012区分"
        '
        ' ラベル78
        '
        Me.ラベル78.AutoSize = True
        Me.ラベル78.Location = New System.Drawing.Point(1258, 120)
        Me.ラベル78.Name = "ラベル78"
        Me.ラベル78.TabIndex = 60
        Me.ラベル78.Text = "摘要\015\012ｺｰﾄﾞ"
        '
        ' ラベル81
        '
        Me.ラベル81.AutoSize = True
        Me.ラベル81.Location = New System.Drawing.Point(1296, 120)
        Me.ラベル81.Name = "ラベル81"
        Me.ラベル81.TabIndex = 61
        Me.ラベル81.Text = "税額"
        '
        ' ラベル83
        '
        Me.ラベル83.AutoSize = True
        Me.ラベル83.Location = New System.Drawing.Point(1390, 120)
        Me.ラベル83.Name = "ラベル83"
        Me.ラベル83.TabIndex = 62
        Me.ラベル83.Text = "税率"
        '
        ' ラベル85
        '
        Me.ラベル85.AutoSize = True
        Me.ラベル85.Location = New System.Drawing.Point(1428, 120)
        Me.ラベル85.Name = "ラベル85"
        Me.ラベル85.TabIndex = 63
        Me.ラベル85.Text = "入力\015\012区分"
        '
        ' ラベル87
        '
        Me.ラベル87.AutoSize = True
        Me.ラベル87.Location = New System.Drawing.Point(457, 120)
        Me.ラベル87.Name = "ラベル87"
        Me.ラベル87.TabIndex = 64
        Me.ラベル87.Text = "借方"
        '
        ' ラベル88
        '
        Me.ラベル88.AutoSize = True
        Me.ラベル88.Location = New System.Drawing.Point(857, 120)
        Me.ラベル88.Name = "ラベル88"
        Me.ラベル88.TabIndex = 65
        Me.ラベル88.Text = "借方"
        '
        ' ラベル89
        '
        Me.ラベル89.AutoSize = True
        Me.ラベル89.Location = New System.Drawing.Point(857, 136)
        Me.ラベル89.Name = "ラベル89"
        Me.ラベル89.TabIndex = 66
        Me.ラベル89.Text = "勘定\015\012科目"
        '
        ' ラベル90
        '
        Me.ラベル90.AutoSize = True
        Me.ラベル90.Location = New System.Drawing.Point(1084, 136)
        Me.ラベル90.Name = "ラベル90"
        Me.ラベル90.TabIndex = 67
        Me.ラベル90.Text = "金額"
        '
        ' ラベル91
        '
        Me.ラベル91.AutoSize = True
        Me.ラベル91.Location = New System.Drawing.Point(895, 136)
        Me.ラベル91.Name = "ラベル91"
        Me.ラベル91.TabIndex = 68
        Me.ラベル91.Text = "決済\015\012場所"
        '
        ' ラベル92
        '
        Me.ラベル92.AutoSize = True
        Me.ラベル92.Location = New System.Drawing.Point(933, 136)
        Me.ラベル92.Name = "ラベル92"
        Me.ラベル92.TabIndex = 69
        Me.ラベル92.Text = "項目"
        '
        ' ラベル93
        '
        Me.ラベル93.AutoSize = True
        Me.ラベル93.Location = New System.Drawing.Point(971, 136)
        Me.ラベル93.Name = "ラベル93"
        Me.ラベル93.TabIndex = 70
        Me.ラベル93.Text = "要件"
        '
        ' ラベル94
        '
        Me.ラベル94.AutoSize = True
        Me.ラベル94.Location = New System.Drawing.Point(1009, 136)
        Me.ラベル94.Name = "ラベル94"
        Me.ラベル94.TabIndex = 71
        Me.ラベル94.Text = "細目\015\012A"
        '
        ' ラベル95
        '
        Me.ラベル95.AutoSize = True
        Me.ラベル95.Location = New System.Drawing.Point(1046, 136)
        Me.ラベル95.Name = "ラベル95"
        Me.ラベル95.TabIndex = 72
        Me.ラベル95.Text = "細目\015\012B"
        '
        ' ラベル96
        '
        Me.ラベル96.AutoSize = True
        Me.ラベル96.Location = New System.Drawing.Point(1179, 136)
        Me.ラベル96.Name = "ラベル96"
        Me.ラベル96.TabIndex = 73
        Me.ラベル96.Text = "GN\015\012区分"
        '
        ' ラベル97
        '
        Me.ラベル97.AutoSize = True
        Me.ラベル97.Location = New System.Drawing.Point(1217, 136)
        Me.ラベル97.Name = "ラベル97"
        Me.ラベル97.TabIndex = 74
        Me.ラベル97.Text = "税\015\012区分"
        '
        ' ラベル526
        '
        Me.ラベル526.AutoSize = True
        Me.ラベル526.Location = New System.Drawing.Point(3, 56)
        Me.ラベル526.Name = "ラベル526"
        Me.ラベル526.TabIndex = 75
        Me.ラベル526.Text = "ﾌｧｲﾙ名接頭辞"
        '
        ' ラベル548
        '
        Me.ラベル548.AutoSize = True
        Me.ラベル548.Location = New System.Drawing.Point(219, 56)
        Me.ラベル548.Name = "ラベル548"
        Me.ラベル548.TabIndex = 76
        Me.ラベル548.Text = "[ﾌｧｲﾙ名接頭辞] + _yyyymmdd_hhmm.txt という名前でﾌｧｲﾙが生成されます。"
        '
        ' ラベル103
        '
        Me.ラベル103.AutoSize = True
        Me.ラベル103.Location = New System.Drawing.Point(907, 37)
        Me.ラベル103.Name = "ラベル103"
        Me.ラベル103.TabIndex = 77
        Me.ラベル103.Text = "ﾌｧｲﾙ名"
        '
        ' ラベル105
        '
        Me.ラベル105.AutoSize = True
        Me.ラベル105.Location = New System.Drawing.Point(3, 120)
        Me.ラベル105.Name = "ラベル105"
        Me.ラベル105.TabIndex = 78
        Me.ラベル105.Text = "仕訳区分"
        '
        ' lbl_固定ファイル名
        '
        Me.lbl_固定ファイル名.AutoSize = True
        Me.lbl_固定ファイル名.Location = New System.Drawing.Point(219, 75)
        Me.lbl_固定ファイル名.Name = "lbl_固定ファイル名"
        Me.lbl_固定ファイル名.TabIndex = 79
        Me.lbl_固定ファイル名.Text = "上記ﾌｧｲﾙと内容が同じ siwake_m4bs2.txt という名前のﾌｧｲﾙも生成されます。"
        '
        ' lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(771, 0)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.TabIndex = 80
        Me.lbl_ID.Text = "ID"
        '
        ' ラベル34
        '
        Me.ラベル34.AutoSize = True
        Me.ラベル34.Location = New System.Drawing.Point(627, 3)
        Me.ラベル34.Name = "ラベル34"
        Me.ラベル34.TabIndex = 81
        Me.ラベル34.Text = "借方合計"
        '
        ' ラベル35
        '
        Me.ラベル35.AutoSize = True
        Me.ラベル35.Location = New System.Drawing.Point(1028, 3)
        Me.ラベル35.Name = "ラベル35"
        Me.ラベル35.TabIndex = 82
        Me.ラベル35.Text = "貸方合計"
        '
        ' ラベル101
        '
        Me.ラベル101.AutoSize = True
        Me.ラベル101.Location = New System.Drawing.Point(1239, 3)
        Me.ラベル101.Name = "ラベル101"
        Me.ラベル101.TabIndex = 83
        Me.ラベル101.Text = "税額合計"
        '
        ' Form_fc_仕訳出力_VTC_明細
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 638)
        Me.Controls.Add(Me.貸借区分_ラベル)
        Me.Controls.Add(Me.勘定科目CD_ラベル)
        Me.Controls.Add(Me.金額_ラベル)
        Me.Controls.Add(Me.ラベル523)
        Me.Controls.Add(Me.ラベル37)
        Me.Controls.Add(Me.ラベル39)
        Me.Controls.Add(Me.ラベル41)
        Me.Controls.Add(Me.ラベル43)
        Me.Controls.Add(Me.ラベル45)
        Me.Controls.Add(Me.ラベル47)
        Me.Controls.Add(Me.ラベル49)
        Me.Controls.Add(Me.ラベル54)
        Me.Controls.Add(Me.ラベル57)
        Me.Controls.Add(Me.ラベル60)
        Me.Controls.Add(Me.ラベル63)
        Me.Controls.Add(Me.ラベル66)
        Me.Controls.Add(Me.ラベル72)
        Me.Controls.Add(Me.ラベル73)
        Me.Controls.Add(Me.ラベル78)
        Me.Controls.Add(Me.ラベル81)
        Me.Controls.Add(Me.ラベル83)
        Me.Controls.Add(Me.ラベル85)
        Me.Controls.Add(Me.ラベル87)
        Me.Controls.Add(Me.ラベル88)
        Me.Controls.Add(Me.ラベル89)
        Me.Controls.Add(Me.ラベル90)
        Me.Controls.Add(Me.ラベル91)
        Me.Controls.Add(Me.ラベル92)
        Me.Controls.Add(Me.ラベル93)
        Me.Controls.Add(Me.ラベル94)
        Me.Controls.Add(Me.ラベル95)
        Me.Controls.Add(Me.ラベル96)
        Me.Controls.Add(Me.ラベル97)
        Me.Controls.Add(Me.ラベル526)
        Me.Controls.Add(Me.ラベル548)
        Me.Controls.Add(Me.ラベル103)
        Me.Controls.Add(Me.ラベル105)
        Me.Controls.Add(Me.lbl_固定ファイル名)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.ラベル34)
        Me.Controls.Add(Me.ラベル35)
        Me.Controls.Add(Me.ラベル101)
        Me.Controls.Add(Me.txt_FOLDER)
        Me.Controls.Add(Me.txt_FILE_NM接頭辞)
        Me.Controls.Add(Me.txt_FILE_NM)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.txt_GETSUDO)
        Me.Controls.Add(Me.txt_D_KAMOKU)
        Me.Controls.Add(Me.txt_D_KINGAKU)
        Me.Controls.Add(Me.txt_SEIKYU_NO)
        Me.Controls.Add(Me.txt_DATA_KBN)
        Me.Controls.Add(Me.txt_CORP_CD)
        Me.Controls.Add(Me.txt_HASSEI_BASHO)
        Me.Controls.Add(Me.txt_KANJO_BASHO)
        Me.Controls.Add(Me.txt_KESSAI_KBN)
        Me.Controls.Add(Me.txt_KEIJO_DT)
        Me.Controls.Add(Me.txt_C_KAMOKU)
        Me.Controls.Add(Me.txt_D_KESSAI_BASHO)
        Me.Controls.Add(Me.txt_C_KESSAI_BASHO)
        Me.Controls.Add(Me.txt_D_KOUMOKU)
        Me.Controls.Add(Me.txt_C_KOUMOKU)
        Me.Controls.Add(Me.txt_D_YOUKEN)
        Me.Controls.Add(Me.txt_C_YOUKEN)
        Me.Controls.Add(Me.txt_D_SAIMOKU_A)
        Me.Controls.Add(Me.txt_C_SAIMOKU_A)
        Me.Controls.Add(Me.txt_D_SAIMOKU_B)
        Me.Controls.Add(Me.txt_C_SAIMOKU_B)
        Me.Controls.Add(Me.txt_C_KINGAKU)
        Me.Controls.Add(Me.txt_D_GN_KBN)
        Me.Controls.Add(Me.txt_C_GN_KBN)
        Me.Controls.Add(Me.txt_D_ZEI_KBN)
        Me.Controls.Add(Me.txt_C_ZEI_KBN)
        Me.Controls.Add(Me.txt_TEKIYO_CD)
        Me.Controls.Add(Me.txt_ZEI)
        Me.Controls.Add(Me.txt_ZRITU)
        Me.Controls.Add(Me.txt_INPUT_KBN)
        Me.Controls.Add(Me.txt_SWK_KBN_NM)
        Me.Controls.Add(Me.txt_D_KINGAKU_SUM)
        Me.Controls.Add(Me.txt_C_KINGAKU_SUM)
        Me.Controls.Add(Me.txt_ZEI_SUM)
        Me.Controls.Add(Me.cmd_FlexReportDLG)
        Me.Controls.Add(Me.cmd_選択)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_fc_仕訳出力_VTC_明細"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳出力　最終確認"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_FlexReportDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_選択 As System.Windows.Forms.Button
    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_FOLDER As System.Windows.Forms.TextBox
    Friend WithEvents txt_FILE_NM接頭辞 As System.Windows.Forms.TextBox
    Friend WithEvents txt_FILE_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_GETSUDO As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_KAMOKU As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_KINGAKU As System.Windows.Forms.TextBox
    Friend WithEvents txt_SEIKYU_NO As System.Windows.Forms.TextBox
    Friend WithEvents txt_DATA_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_CORP_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_HASSEI_BASHO As System.Windows.Forms.TextBox
    Friend WithEvents txt_KANJO_BASHO As System.Windows.Forms.TextBox
    Friend WithEvents txt_KESSAI_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_KEIJO_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_KAMOKU As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_KESSAI_BASHO As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_KESSAI_BASHO As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_KOUMOKU As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_KOUMOKU As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_YOUKEN As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_YOUKEN As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_SAIMOKU_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_SAIMOKU_A As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_SAIMOKU_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_SAIMOKU_B As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_KINGAKU As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_GN_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_GN_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_ZEI_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_ZEI_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_TEKIYO_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZEI As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZRITU As System.Windows.Forms.TextBox
    Friend WithEvents txt_INPUT_KBN As System.Windows.Forms.TextBox
    Friend WithEvents txt_SWK_KBN_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_D_KINGAKU_SUM As System.Windows.Forms.TextBox
    Friend WithEvents txt_C_KINGAKU_SUM As System.Windows.Forms.TextBox
    Friend WithEvents txt_ZEI_SUM As System.Windows.Forms.TextBox
    Friend WithEvents 貸借区分_ラベル As System.Windows.Forms.Label
    Friend WithEvents 勘定科目CD_ラベル As System.Windows.Forms.Label
    Friend WithEvents 金額_ラベル As System.Windows.Forms.Label
    Friend WithEvents ラベル523 As System.Windows.Forms.Label
    Friend WithEvents ラベル37 As System.Windows.Forms.Label
    Friend WithEvents ラベル39 As System.Windows.Forms.Label
    Friend WithEvents ラベル41 As System.Windows.Forms.Label
    Friend WithEvents ラベル43 As System.Windows.Forms.Label
    Friend WithEvents ラベル45 As System.Windows.Forms.Label
    Friend WithEvents ラベル47 As System.Windows.Forms.Label
    Friend WithEvents ラベル49 As System.Windows.Forms.Label
    Friend WithEvents ラベル54 As System.Windows.Forms.Label
    Friend WithEvents ラベル57 As System.Windows.Forms.Label
    Friend WithEvents ラベル60 As System.Windows.Forms.Label
    Friend WithEvents ラベル63 As System.Windows.Forms.Label
    Friend WithEvents ラベル66 As System.Windows.Forms.Label
    Friend WithEvents ラベル72 As System.Windows.Forms.Label
    Friend WithEvents ラベル73 As System.Windows.Forms.Label
    Friend WithEvents ラベル78 As System.Windows.Forms.Label
    Friend WithEvents ラベル81 As System.Windows.Forms.Label
    Friend WithEvents ラベル83 As System.Windows.Forms.Label
    Friend WithEvents ラベル85 As System.Windows.Forms.Label
    Friend WithEvents ラベル87 As System.Windows.Forms.Label
    Friend WithEvents ラベル88 As System.Windows.Forms.Label
    Friend WithEvents ラベル89 As System.Windows.Forms.Label
    Friend WithEvents ラベル90 As System.Windows.Forms.Label
    Friend WithEvents ラベル91 As System.Windows.Forms.Label
    Friend WithEvents ラベル92 As System.Windows.Forms.Label
    Friend WithEvents ラベル93 As System.Windows.Forms.Label
    Friend WithEvents ラベル94 As System.Windows.Forms.Label
    Friend WithEvents ラベル95 As System.Windows.Forms.Label
    Friend WithEvents ラベル96 As System.Windows.Forms.Label
    Friend WithEvents ラベル97 As System.Windows.Forms.Label
    Friend WithEvents ラベル526 As System.Windows.Forms.Label
    Friend WithEvents ラベル548 As System.Windows.Forms.Label
    Friend WithEvents ラベル103 As System.Windows.Forms.Label
    Friend WithEvents ラベル105 As System.Windows.Forms.Label
    Friend WithEvents lbl_固定ファイル名 As System.Windows.Forms.Label
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents ラベル34 As System.Windows.Forms.Label
    Friend WithEvents ラベル35 As System.Windows.Forms.Label
    Friend WithEvents ラベル101 As System.Windows.Forms.Label

End Class