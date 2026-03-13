<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_f_CHUKI_SCH
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_PRINT = New System.Windows.Forms.Button()
        Me.cmd_OUTPUT_EXCEL_FILE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_BUKN_NM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_KYKM_NO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_LEAKBN_NM = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_SKMK_NM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_SKYAK_HO_NM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_SKYAK_RITU = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_BKIND_NM = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_LKIKAN = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_SHRI_KN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_MKAISU = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_SHRI_CNT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_SHRI_DT3 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_KLSRYO = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_SLSRYO = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_IJIKNR = New System.Windows.Forms.TextBox()
        Me.txt_ZANRYO = New System.Windows.Forms.TextBox()
        Me.txt_KNYUKN = New System.Windows.Forms.TextBox()
        Me.txt_ZEI = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_KARI_RITU = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_GNZAI_KT = New System.Windows.Forms.TextBox()
        Me.txt_SYUTOK = New System.Windows.Forms.TextBox()
        Me.txt_KSAN_RITU = New System.Windows.Forms.TextBox()
        Me.txt_LB = New System.Windows.Forms.TextBox()
        Me.dgv_TOTAL = New System.Windows.Forms.DataGridView()
        Me.txt_CKAIYK_ESDT = New System.Windows.Forms.TextBox()
        Me.txt_CKAIYK_DT = New System.Windows.Forms.TextBox()
        Me.txt_SHRI_EN_DT = New System.Windows.Forms.TextBox()
        Me.txt_SHRI_DT2 = New System.Windows.Forms.TextBox()
        Me.txt_SHRI_DT1 = New System.Windows.Forms.TextBox()
        Me.txt_MAE_DT = New System.Windows.Forms.TextBox()
        Me.txt_END_DT = New System.Windows.Forms.TextBox()
        Me.txt_START_DT = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_LIST
        '
        Me.dgv_LIST.AllowUserToAddRows = False
        Me.dgv_LIST.AllowUserToDeleteRows = False
        Me.dgv_LIST.AllowUserToResizeColumns = False
        Me.dgv_LIST.AllowUserToResizeRows = False
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_DT, Me.col_KLSRYO, Me.col_HLSRYO})
        Me.dgv_LIST.Location = New System.Drawing.Point(14, 401)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.ReadOnly = True
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(1720, 459)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_DT
        '
        Me.col_DT.HeaderText = "年月"
        Me.col_DT.MinimumWidth = 8
        Me.col_DT.Name = "col_DT"
        Me.col_DT.ReadOnly = True
        Me.col_DT.Width = 150
        '
        'col_KLSRYO
        '
        Me.col_KLSRYO.HeaderText = "支払リース料"
        Me.col_KLSRYO.MinimumWidth = 8
        Me.col_KLSRYO.Name = "col_KLSRYO"
        Me.col_KLSRYO.ReadOnly = True
        Me.col_KLSRYO.Width = 150
        '
        'col_HLSRYO
        '
        Me.col_HLSRYO.HeaderText = "発生リース料"
        Me.col_HLSRYO.MinimumWidth = 8
        Me.col_HLSRYO.Name = "col_HLSRYO"
        Me.col_HLSRYO.ReadOnly = True
        Me.col_HLSRYO.Width = 150
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(15, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_PRINT
        '
        Me.cmd_PRINT.Location = New System.Drawing.Point(198, 13)
        Me.cmd_PRINT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(173, 45)
        Me.cmd_PRINT.TabIndex = 1
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Text = "印刷(&P)"
        Me.cmd_PRINT.UseVisualStyleBackColor = True
        '
        'cmd_OUTPUT_EXCEL_FILE
        '
        Me.cmd_OUTPUT_EXCEL_FILE.Location = New System.Drawing.Point(507, 13)
        Me.cmd_OUTPUT_EXCEL_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_EXCEL_FILE.Name = "cmd_OUTPUT_EXCEL_FILE"
        Me.cmd_OUTPUT_EXCEL_FILE.Size = New System.Drawing.Size(173, 45)
        Me.cmd_OUTPUT_EXCEL_FILE.TabIndex = 2
        Me.cmd_OUTPUT_EXCEL_FILE.TabStop = False
        Me.cmd_OUTPUT_EXCEL_FILE.Text = "Excel出力(&F)"
        Me.cmd_OUTPUT_EXCEL_FILE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "物件No"
        '
        'txt_BUKN_NM
        '
        Me.txt_BUKN_NM.Location = New System.Drawing.Point(299, 77)
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.ReadOnly = True
        Me.txt_BUKN_NM.Size = New System.Drawing.Size(717, 25)
        Me.txt_BUKN_NM.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "物件名称"
        '
        'txt_KYKM_NO
        '
        Me.txt_KYKM_NO.Location = New System.Drawing.Point(104, 77)
        Me.txt_KYKM_NO.Name = "txt_KYKM_NO"
        Me.txt_KYKM_NO.ReadOnly = True
        Me.txt_KYKM_NO.Size = New System.Drawing.Size(100, 25)
        Me.txt_KYKM_NO.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "リース区分"
        '
        'txt_LEAKBN_NM
        '
        Me.txt_LEAKBN_NM.Location = New System.Drawing.Point(104, 111)
        Me.txt_LEAKBN_NM.Name = "txt_LEAKBN_NM"
        Me.txt_LEAKBN_NM.ReadOnly = True
        Me.txt_LEAKBN_NM.Size = New System.Drawing.Size(410, 25)
        Me.txt_LEAKBN_NM.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "資産区分"
        '
        'txt_SKMK_NM
        '
        Me.txt_SKMK_NM.Location = New System.Drawing.Point(102, 147)
        Me.txt_SKMK_NM.Name = "txt_SKMK_NM"
        Me.txt_SKMK_NM.ReadOnly = True
        Me.txt_SKMK_NM.Size = New System.Drawing.Size(410, 25)
        Me.txt_SKMK_NM.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(520, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "償却方法"
        '
        'txt_SKYAK_HO_NM
        '
        Me.txt_SKYAK_HO_NM.Location = New System.Drawing.Point(611, 106)
        Me.txt_SKYAK_HO_NM.Name = "txt_SKYAK_HO_NM"
        Me.txt_SKYAK_HO_NM.ReadOnly = True
        Me.txt_SKYAK_HO_NM.Size = New System.Drawing.Size(193, 25)
        Me.txt_SKYAK_HO_NM.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(810, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "償却率"
        '
        'txt_SKYAK_RITU
        '
        Me.txt_SKYAK_RITU.Location = New System.Drawing.Point(896, 106)
        Me.txt_SKYAK_RITU.Name = "txt_SKYAK_RITU"
        Me.txt_SKYAK_RITU.ReadOnly = True
        Me.txt_SKYAK_RITU.Size = New System.Drawing.Size(193, 25)
        Me.txt_SKYAK_RITU.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "物件種別"
        '
        'txt_BKIND_NM
        '
        Me.txt_BKIND_NM.Location = New System.Drawing.Point(611, 147)
        Me.txt_BKIND_NM.Name = "txt_BKIND_NM"
        Me.txt_BKIND_NM.ReadOnly = True
        Me.txt_BKIND_NM.Size = New System.Drawing.Size(405, 25)
        Me.txt_BKIND_NM.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "開始日"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "終了日"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "契約期間"
        '
        'txt_LKIKAN
        '
        Me.txt_LKIKAN.Location = New System.Drawing.Point(123, 246)
        Me.txt_LKIKAN.Name = "txt_LKIKAN"
        Me.txt_LKIKAN.ReadOnly = True
        Me.txt_LKIKAN.Size = New System.Drawing.Size(81, 25)
        Me.txt_LKIKAN.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "支払間隔"
        '
        'txt_SHRI_KN
        '
        Me.txt_SHRI_KN.Location = New System.Drawing.Point(123, 277)
        Me.txt_SHRI_KN.Name = "txt_SHRI_KN"
        Me.txt_SHRI_KN.ReadOnly = True
        Me.txt_SHRI_KN.Size = New System.Drawing.Size(81, 25)
        Me.txt_SHRI_KN.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 311)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "前払回数"
        '
        'txt_MKAISU
        '
        Me.txt_MKAISU.Location = New System.Drawing.Point(123, 308)
        Me.txt_MKAISU.Name = "txt_MKAISU"
        Me.txt_MKAISU.ReadOnly = True
        Me.txt_MKAISU.Size = New System.Drawing.Size(81, 25)
        Me.txt_MKAISU.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 342)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "支払回数"
        '
        'txt_SHRI_CNT
        '
        Me.txt_SHRI_CNT.Location = New System.Drawing.Point(123, 339)
        Me.txt_SHRI_CNT.Name = "txt_SHRI_CNT"
        Me.txt_SHRI_CNT.ReadOnly = True
        Me.txt_SHRI_CNT.Size = New System.Drawing.Size(81, 25)
        Me.txt_SHRI_CNT.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 373)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 18)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "前払日"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(210, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 18)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "ヶ月"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(210, 280)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 18)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "ヶ月"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(210, 311)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 18)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "回"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(210, 342)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 18)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "回"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(380, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 18)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "第1回支払日"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(380, 218)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 18)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "第2回支払日"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(380, 249)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 18)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "第3回以降"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(380, 280)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 18)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "最終支払日"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(380, 342)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(98, 18)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "中途解約日"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(380, 373)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(134, 18)
        Me.Label25.TabIndex = 10
        Me.Label25.Text = "解約最終支払日"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(624, 249)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 18)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "日"
        '
        'txt_SHRI_DT3
        '
        Me.txt_SHRI_DT3.Location = New System.Drawing.Point(537, 246)
        Me.txt_SHRI_DT3.Name = "txt_SHRI_DT3"
        Me.txt_SHRI_DT3.ReadOnly = True
        Me.txt_SHRI_DT3.Size = New System.Drawing.Size(81, 25)
        Me.txt_SHRI_DT3.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(794, 187)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 18)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "1回分リース料"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(794, 218)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(102, 18)
        Me.Label28.TabIndex = 10
        Me.Label28.Text = "総額リース料"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(794, 249)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(134, 18)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "内維持管理費用"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(794, 280)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 18)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "残価保証額"
        '
        'txt_KLSRYO
        '
        Me.txt_KLSRYO.Location = New System.Drawing.Point(967, 184)
        Me.txt_KLSRYO.Name = "txt_KLSRYO"
        Me.txt_KLSRYO.ReadOnly = True
        Me.txt_KLSRYO.Size = New System.Drawing.Size(143, 25)
        Me.txt_KLSRYO.TabIndex = 11
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(794, 311)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 18)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "現金購入価額"
        '
        'txt_SLSRYO
        '
        Me.txt_SLSRYO.Location = New System.Drawing.Point(967, 215)
        Me.txt_SLSRYO.Name = "txt_SLSRYO"
        Me.txt_SLSRYO.ReadOnly = True
        Me.txt_SLSRYO.Size = New System.Drawing.Size(143, 25)
        Me.txt_SLSRYO.TabIndex = 11
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(794, 342)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(152, 18)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "消費税一括計上額"
        '
        'txt_IJIKNR
        '
        Me.txt_IJIKNR.Location = New System.Drawing.Point(967, 246)
        Me.txt_IJIKNR.Name = "txt_IJIKNR"
        Me.txt_IJIKNR.ReadOnly = True
        Me.txt_IJIKNR.Size = New System.Drawing.Size(143, 25)
        Me.txt_IJIKNR.TabIndex = 11
        '
        'txt_ZANRYO
        '
        Me.txt_ZANRYO.Location = New System.Drawing.Point(967, 277)
        Me.txt_ZANRYO.Name = "txt_ZANRYO"
        Me.txt_ZANRYO.ReadOnly = True
        Me.txt_ZANRYO.Size = New System.Drawing.Size(143, 25)
        Me.txt_ZANRYO.TabIndex = 11
        '
        'txt_KNYUKN
        '
        Me.txt_KNYUKN.Location = New System.Drawing.Point(967, 308)
        Me.txt_KNYUKN.Name = "txt_KNYUKN"
        Me.txt_KNYUKN.ReadOnly = True
        Me.txt_KNYUKN.Size = New System.Drawing.Size(143, 25)
        Me.txt_KNYUKN.TabIndex = 11
        '
        'txt_ZEI
        '
        Me.txt_ZEI.Location = New System.Drawing.Point(967, 339)
        Me.txt_ZEI.Name = "txt_ZEI"
        Me.txt_ZEI.ReadOnly = True
        Me.txt_ZEI.Size = New System.Drawing.Size(143, 25)
        Me.txt_ZEI.TabIndex = 11
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(1243, 191)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(134, 18)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "追加借入利子率"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(1253, 222)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 18)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "現在価値"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(1243, 253)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(134, 18)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "取得価額相当額"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(1253, 284)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(98, 18)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "計算利子率"
        '
        'txt_KARI_RITU
        '
        Me.txt_KARI_RITU.Location = New System.Drawing.Point(1416, 188)
        Me.txt_KARI_RITU.Name = "txt_KARI_RITU"
        Me.txt_KARI_RITU.ReadOnly = True
        Me.txt_KARI_RITU.Size = New System.Drawing.Size(143, 25)
        Me.txt_KARI_RITU.TabIndex = 11
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(1243, 315)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(157, 18)
        Me.Label36.TabIndex = 10
        Me.Label36.Text = "リースバック繰延損益"
        '
        'txt_GNZAI_KT
        '
        Me.txt_GNZAI_KT.Location = New System.Drawing.Point(1416, 219)
        Me.txt_GNZAI_KT.Name = "txt_GNZAI_KT"
        Me.txt_GNZAI_KT.ReadOnly = True
        Me.txt_GNZAI_KT.Size = New System.Drawing.Size(143, 25)
        Me.txt_GNZAI_KT.TabIndex = 11
        '
        'txt_SYUTOK
        '
        Me.txt_SYUTOK.Location = New System.Drawing.Point(1416, 250)
        Me.txt_SYUTOK.Name = "txt_SYUTOK"
        Me.txt_SYUTOK.ReadOnly = True
        Me.txt_SYUTOK.Size = New System.Drawing.Size(143, 25)
        Me.txt_SYUTOK.TabIndex = 11
        '
        'txt_KSAN_RITU
        '
        Me.txt_KSAN_RITU.Location = New System.Drawing.Point(1416, 281)
        Me.txt_KSAN_RITU.Name = "txt_KSAN_RITU"
        Me.txt_KSAN_RITU.ReadOnly = True
        Me.txt_KSAN_RITU.Size = New System.Drawing.Size(143, 25)
        Me.txt_KSAN_RITU.TabIndex = 11
        '
        'txt_LB
        '
        Me.txt_LB.Location = New System.Drawing.Point(1416, 312)
        Me.txt_LB.Name = "txt_LB"
        Me.txt_LB.ReadOnly = True
        Me.txt_LB.Size = New System.Drawing.Size(143, 25)
        Me.txt_LB.TabIndex = 11
        '
        'dgv_TOTAL
        '
        Me.dgv_TOTAL.AllowUserToAddRows = False
        Me.dgv_TOTAL.AllowUserToDeleteRows = False
        Me.dgv_TOTAL.AllowUserToResizeColumns = False
        Me.dgv_TOTAL.AllowUserToResizeRows = False
        Me.dgv_TOTAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_TOTAL.ColumnHeadersVisible = False
        Me.dgv_TOTAL.Location = New System.Drawing.Point(15, 880)
        Me.dgv_TOTAL.Name = "dgv_TOTAL"
        Me.dgv_TOTAL.ReadOnly = True
        Me.dgv_TOTAL.RowHeadersWidth = 62
        Me.dgv_TOTAL.RowTemplate.Height = 27
        Me.dgv_TOTAL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgv_TOTAL.Size = New System.Drawing.Size(1719, 108)
        Me.dgv_TOTAL.TabIndex = 12
        '
        'txt_CKAIYK_ESDT
        '
        Me.txt_CKAIYK_ESDT.Location = New System.Drawing.Point(537, 370)
        Me.txt_CKAIYK_ESDT.Name = "txt_CKAIYK_ESDT"
        Me.txt_CKAIYK_ESDT.ReadOnly = True
        Me.txt_CKAIYK_ESDT.Size = New System.Drawing.Size(143, 25)
        Me.txt_CKAIYK_ESDT.TabIndex = 11
        '
        'txt_CKAIYK_DT
        '
        Me.txt_CKAIYK_DT.Location = New System.Drawing.Point(537, 339)
        Me.txt_CKAIYK_DT.Name = "txt_CKAIYK_DT"
        Me.txt_CKAIYK_DT.ReadOnly = True
        Me.txt_CKAIYK_DT.Size = New System.Drawing.Size(143, 25)
        Me.txt_CKAIYK_DT.TabIndex = 11
        '
        'txt_SHRI_EN_DT
        '
        Me.txt_SHRI_EN_DT.Location = New System.Drawing.Point(537, 277)
        Me.txt_SHRI_EN_DT.Name = "txt_SHRI_EN_DT"
        Me.txt_SHRI_EN_DT.ReadOnly = True
        Me.txt_SHRI_EN_DT.Size = New System.Drawing.Size(143, 25)
        Me.txt_SHRI_EN_DT.TabIndex = 11
        '
        'txt_SHRI_DT2
        '
        Me.txt_SHRI_DT2.Location = New System.Drawing.Point(537, 215)
        Me.txt_SHRI_DT2.Name = "txt_SHRI_DT2"
        Me.txt_SHRI_DT2.ReadOnly = True
        Me.txt_SHRI_DT2.Size = New System.Drawing.Size(143, 25)
        Me.txt_SHRI_DT2.TabIndex = 11
        '
        'txt_SHRI_DT1
        '
        Me.txt_SHRI_DT1.Location = New System.Drawing.Point(537, 184)
        Me.txt_SHRI_DT1.Name = "txt_SHRI_DT1"
        Me.txt_SHRI_DT1.ReadOnly = True
        Me.txt_SHRI_DT1.Size = New System.Drawing.Size(143, 25)
        Me.txt_SHRI_DT1.TabIndex = 11
        '
        'txt_MAE_DT
        '
        Me.txt_MAE_DT.Location = New System.Drawing.Point(123, 370)
        Me.txt_MAE_DT.Name = "txt_MAE_DT"
        Me.txt_MAE_DT.ReadOnly = True
        Me.txt_MAE_DT.Size = New System.Drawing.Size(143, 25)
        Me.txt_MAE_DT.TabIndex = 11
        '
        'txt_END_DT
        '
        Me.txt_END_DT.Location = New System.Drawing.Point(123, 215)
        Me.txt_END_DT.Name = "txt_END_DT"
        Me.txt_END_DT.ReadOnly = True
        Me.txt_END_DT.Size = New System.Drawing.Size(143, 25)
        Me.txt_END_DT.TabIndex = 11
        '
        'txt_START_DT
        '
        Me.txt_START_DT.Location = New System.Drawing.Point(123, 184)
        Me.txt_START_DT.Name = "txt_START_DT"
        Me.txt_START_DT.ReadOnly = True
        Me.txt_START_DT.Size = New System.Drawing.Size(143, 25)
        Me.txt_START_DT.TabIndex = 11
        '
        'PrintDocument1
        '
        '
        'Form_f_CHUKI_SCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1746, 1000)
        Me.Controls.Add(Me.dgv_TOTAL)
        Me.Controls.Add(Me.txt_SKMK_NM)
        Me.Controls.Add(Me.txt_SKYAK_RITU)
        Me.Controls.Add(Me.txt_BKIND_NM)
        Me.Controls.Add(Me.txt_SKYAK_HO_NM)
        Me.Controls.Add(Me.txt_LEAKBN_NM)
        Me.Controls.Add(Me.txt_ZEI)
        Me.Controls.Add(Me.txt_LB)
        Me.Controls.Add(Me.txt_KNYUKN)
        Me.Controls.Add(Me.txt_CKAIYK_ESDT)
        Me.Controls.Add(Me.txt_CKAIYK_DT)
        Me.Controls.Add(Me.txt_KSAN_RITU)
        Me.Controls.Add(Me.txt_MAE_DT)
        Me.Controls.Add(Me.txt_ZANRYO)
        Me.Controls.Add(Me.txt_SHRI_CNT)
        Me.Controls.Add(Me.txt_SYUTOK)
        Me.Controls.Add(Me.txt_SHRI_EN_DT)
        Me.Controls.Add(Me.txt_IJIKNR)
        Me.Controls.Add(Me.txt_MKAISU)
        Me.Controls.Add(Me.txt_SHRI_DT3)
        Me.Controls.Add(Me.txt_SHRI_KN)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txt_LKIKAN)
        Me.Controls.Add(Me.txt_GNZAI_KT)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_SLSRYO)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txt_SHRI_DT2)
        Me.Controls.Add(Me.txt_KARI_RITU)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txt_KLSRYO)
        Me.Controls.Add(Me.txt_END_DT)
        Me.Controls.Add(Me.txt_SHRI_DT1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txt_START_DT)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txt_KYKM_NO)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txt_BUKN_NM)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_OUTPUT_EXCEL_FILE)
        Me.Controls.Add(Me.cmd_PRINT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.dgv_LIST)
        Me.KeyPreview = True
        Me.Name = "Form_f_CHUKI_SCH"
        Me.Text = "Form_f_CHUKI_SCH"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents cmd_PRINT As Button
    Friend WithEvents cmd_OUTPUT_EXCEL_FILE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_BUKN_NM As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_KYKM_NO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_LEAKBN_NM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_SKMK_NM As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_SKYAK_HO_NM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_SKYAK_RITU As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_BKIND_NM As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_LKIKAN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_SHRI_KN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_MKAISU As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_SHRI_CNT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_SHRI_DT3 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_KLSRYO As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_SLSRYO As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_IJIKNR As TextBox
    Friend WithEvents txt_ZANRYO As TextBox
    Friend WithEvents txt_KNYUKN As TextBox
    Friend WithEvents txt_ZEI As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_KARI_RITU As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txt_GNZAI_KT As TextBox
    Friend WithEvents txt_SYUTOK As TextBox
    Friend WithEvents txt_KSAN_RITU As TextBox
    Friend WithEvents txt_LB As TextBox
    Friend WithEvents col_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_HLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents dgv_TOTAL As DataGridView
    Friend WithEvents txt_CKAIYK_ESDT As TextBox
    Friend WithEvents txt_CKAIYK_DT As TextBox
    Friend WithEvents txt_SHRI_EN_DT As TextBox
    Friend WithEvents txt_SHRI_DT2 As TextBox
    Friend WithEvents txt_SHRI_DT1 As TextBox
    Friend WithEvents txt_MAE_DT As TextBox
    Friend WithEvents txt_END_DT As TextBox
    Friend WithEvents txt_START_DT As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
