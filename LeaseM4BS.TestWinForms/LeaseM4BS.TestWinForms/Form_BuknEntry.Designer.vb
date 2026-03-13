<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_BuknEntry
    Inherits Form

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
        Me.cmd_KJHNTI = New System.Windows.Forms.Button()
        Me.cmd_MAINTANANCECOST = New System.Windows.Forms.Button()
        Me.cmd_CHANGE = New System.Windows.Forms.Button()
        Me.cmd_DEVIDE = New System.Windows.Forms.Button()
        Me.cmd_COPYZ = New System.Windows.Forms.Button()
        Me.cmd_COPYA = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.cmd_ADD_HAIF = New System.Windows.Forms.Button()
        Me.txt_SKMK_NM = New System.Windows.Forms.TextBox()
        Me.cmb_SKMK_ID = New System.Windows.Forms.ComboBox()
        Me.txt_TAIYO_NEN = New System.Windows.Forms.TextBox()
        Me.txt_KYKM_NO = New System.Windows.Forms.TextBox()
        Me.txt_BUKN_NM = New System.Windows.Forms.TextBox()
        Me.Label_M2 = New System.Windows.Forms.Label()
        Me.cmb_SKYAK_HO_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_SZEI_KJKBN_ID = New System.Windows.Forms.ComboBox()
        Me.lbl_計上区分 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_KJKBN_ID = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.pnlDetail = New System.Windows.Forms.Panel()
        Me.dgv_DETAILS = New System.Windows.Forms.DataGridView()
        Me.col_HAIF_RATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_MLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BCAT1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_BCAT1_NM = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.col_HIYOKBN_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_HIYOKBN_NM = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.col_kzei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mzei = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_biko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_現金購入価額 = New System.Windows.Forms.Label()
        Me.txt_KNYUKN = New System.Windows.Forms.TextBox()
        Me.lbl_月額 = New System.Windows.Forms.Label()
        Me.txt_GLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_期間額 = New System.Windows.Forms.Label()
        Me.txt_KLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_前払 = New System.Windows.Forms.Label()
        Me.txt_MLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_総額 = New System.Windows.Forms.Label()
        Me.txt_SLSRYO = New System.Windows.Forms.TextBox()
        Me.lbl_税抜き = New System.Windows.Forms.Label()
        Me.lbl_消費税 = New System.Windows.Forms.Label()
        Me.txt_GZEI = New System.Windows.Forms.TextBox()
        Me.txt_KZEI = New System.Windows.Forms.TextBox()
        Me.txt_MZEI = New System.Windows.Forms.TextBox()
        Me.lbl_税込み = New System.Windows.Forms.Label()
        Me.txt_GLSRYO_ZKOMI = New System.Windows.Forms.TextBox()
        Me.txt_KLSRYO_ZKOMI = New System.Windows.Forms.TextBox()
        Me.txt_MLSRYO_ZKOMI = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_維持管理費用 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.txt_IJIKNR = New System.Windows.Forms.TextBox()
        Me.lbl_残価保証額 = New System.Windows.Forms.Label()
        Me.txt_ZANRYO = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_ZOKUSEI4 = New System.Windows.Forms.TextBox()
        Me.txt_ZOKUSEI3 = New System.Windows.Forms.TextBox()
        Me.txt_ZOKUSEI2 = New System.Windows.Forms.TextBox()
        Me.txt_ZOKUSEI1 = New System.Windows.Forms.TextBox()
        Me.txt_SETTI_DT = New System.Windows.Forms.TextBox()
        Me.txt_BUKN_BANGO3 = New System.Windows.Forms.TextBox()
        Me.txt_SUURYO = New System.Windows.Forms.TextBox()
        Me.txt_BUKN_BANGO2 = New System.Windows.Forms.TextBox()
        Me.txt_BUKN_BANGO = New System.Windows.Forms.TextBox()
        Me.txt_KEDABAN = New System.Windows.Forms.TextBox()
        Me.txt_OLDBCAT1_NM = New System.Windows.Forms.TextBox()
        Me.txt_OLDBCAT5_NM = New System.Windows.Forms.TextBox()
        Me.txt_OLDBCAT4_NM = New System.Windows.Forms.TextBox()
        Me.txt_BCAT5_NM = New System.Windows.Forms.TextBox()
        Me.txt_OLDBCAT3_NM = New System.Windows.Forms.TextBox()
        Me.txt_BCAT4_NM = New System.Windows.Forms.TextBox()
        Me.txt_OLDBCAT2_NM = New System.Windows.Forms.TextBox()
        Me.txt_BCAT3_NM = New System.Windows.Forms.TextBox()
        Me.txt_BCAT2_NM = New System.Windows.Forms.TextBox()
        Me.txt_BCAT1_NM = New System.Windows.Forms.TextBox()
        Me.cmb_OLDBCAT_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_BCAT_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_RSRVB1_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_MCPT_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_GSHA_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_BKIND_ID = New System.Windows.Forms.ComboBox()
        Me.txt_RSRVB1_NM = New System.Windows.Forms.TextBox()
        Me.txt_MCPT_NM = New System.Windows.Forms.TextBox()
        Me.txt_GSHA_NM = New System.Windows.Forms.TextBox()
        Me.txt_BKIND_NM = New System.Windows.Forms.TextBox()
        Me.cmd_REMOVE_HAIF = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlDetail.SuspendLayout()
        CType(Me.dgv_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_KJHNTI
        '
        Me.cmd_KJHNTI.Location = New System.Drawing.Point(1099, 13)
        Me.cmd_KJHNTI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_KJHNTI.Name = "cmd_KJHNTI"
        Me.cmd_KJHNTI.Size = New System.Drawing.Size(141, 45)
        Me.cmd_KJHNTI.TabIndex = 8
        Me.cmd_KJHNTI.TabStop = False
        Me.cmd_KJHNTI.Text = "計上判定(&T)"
        '
        'cmd_MAINTANANCECOST
        '
        Me.cmd_MAINTANANCECOST.Location = New System.Drawing.Point(972, 13)
        Me.cmd_MAINTANANCECOST.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_MAINTANANCECOST.Name = "cmd_MAINTANANCECOST"
        Me.cmd_MAINTANANCECOST.Size = New System.Drawing.Size(117, 45)
        Me.cmd_MAINTANANCECOST.TabIndex = 7
        Me.cmd_MAINTANANCECOST.TabStop = False
        Me.cmd_MAINTANANCECOST.Text = "保守料(&U)"
        '
        'cmd_CHANGE
        '
        Me.cmd_CHANGE.Location = New System.Drawing.Point(845, 13)
        Me.cmd_CHANGE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CHANGE.Name = "cmd_CHANGE"
        Me.cmd_CHANGE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_CHANGE.TabIndex = 6
        Me.cmd_CHANGE.TabStop = False
        Me.cmd_CHANGE.Text = "変額(&H)"
        '
        'cmd_DEVIDE
        '
        Me.cmd_DEVIDE.Location = New System.Drawing.Point(547, 13)
        Me.cmd_DEVIDE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DEVIDE.Name = "cmd_DEVIDE"
        Me.cmd_DEVIDE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_DEVIDE.TabIndex = 4
        Me.cmd_DEVIDE.TabStop = False
        Me.cmd_DEVIDE.Text = "分割(&S)"
        '
        'cmd_COPYZ
        '
        Me.cmd_COPYZ.Location = New System.Drawing.Point(395, 13)
        Me.cmd_COPYZ.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_COPYZ.Name = "cmd_COPYZ"
        Me.cmd_COPYZ.Size = New System.Drawing.Size(142, 45)
        Me.cmd_COPYZ.TabIndex = 3
        Me.cmd_COPYZ.TabStop = False
        Me.cmd_COPYZ.Text = "残額複写(&Z)"
        '
        'cmd_COPYA
        '
        Me.cmd_COPYA.Location = New System.Drawing.Point(268, 13)
        Me.cmd_COPYA.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_COPYA.Name = "cmd_COPYA"
        Me.cmd_COPYA.Size = New System.Drawing.Size(117, 45)
        Me.cmd_COPYA.TabIndex = 2
        Me.cmd_COPYA.TabStop = False
        Me.cmd_COPYA.Text = "複写(&A)"
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(141, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_DELETE.TabIndex = 1
        Me.cmd_DELETE.TabStop = False
        Me.cmd_DELETE.Text = "削除(&D)"
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(117, 45)
        Me.cmd_CLOSE.TabIndex = 0
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.cmd_CLOSE)
        Me.pnlHeader.Controls.Add(Me.cmd_DELETE)
        Me.pnlHeader.Controls.Add(Me.cmd_COPYA)
        Me.pnlHeader.Controls.Add(Me.cmd_COPYZ)
        Me.pnlHeader.Controls.Add(Me.cmd_DEVIDE)
        Me.pnlHeader.Controls.Add(Me.cmd_CHANGE)
        Me.pnlHeader.Controls.Add(Me.cmd_MAINTANANCECOST)
        Me.pnlHeader.Controls.Add(Me.cmd_KJHNTI)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1505, 71)
        Me.pnlHeader.TabIndex = 15
        '
        'cmd_ADD_HAIF
        '
        Me.cmd_ADD_HAIF.Location = New System.Drawing.Point(69, 576)
        Me.cmd_ADD_HAIF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ADD_HAIF.Name = "cmd_ADD_HAIF"
        Me.cmd_ADD_HAIF.Size = New System.Drawing.Size(145, 30)
        Me.cmd_ADD_HAIF.TabIndex = 97
        Me.cmd_ADD_HAIF.TabStop = False
        Me.cmd_ADD_HAIF.Text = "配賦行追加"
        '
        'txt_SKMK_NM
        '
        Me.txt_SKMK_NM.Location = New System.Drawing.Point(298, 232)
        Me.txt_SKMK_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SKMK_NM.Name = "txt_SKMK_NM"
        Me.txt_SKMK_NM.ReadOnly = True
        Me.txt_SKMK_NM.Size = New System.Drawing.Size(365, 25)
        Me.txt_SKMK_NM.TabIndex = 92
        Me.txt_SKMK_NM.TabStop = False
        '
        'cmb_SKMK_ID
        '
        Me.cmb_SKMK_ID.Location = New System.Drawing.Point(143, 230)
        Me.cmb_SKMK_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SKMK_ID.Name = "cmb_SKMK_ID"
        Me.cmb_SKMK_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_SKMK_ID.TabIndex = 18
        '
        'txt_TAIYO_NEN
        '
        Me.txt_TAIYO_NEN.BackColor = System.Drawing.SystemColors.Control
        Me.txt_TAIYO_NEN.Location = New System.Drawing.Point(328, 55)
        Me.txt_TAIYO_NEN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_TAIYO_NEN.Name = "txt_TAIYO_NEN"
        Me.txt_TAIYO_NEN.ReadOnly = True
        Me.txt_TAIYO_NEN.Size = New System.Drawing.Size(104, 25)
        Me.txt_TAIYO_NEN.TabIndex = 56
        Me.txt_TAIYO_NEN.TabStop = False
        Me.txt_TAIYO_NEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_KYKM_NO
        '
        Me.txt_KYKM_NO.BackColor = System.Drawing.SystemColors.Control
        Me.txt_KYKM_NO.Location = New System.Drawing.Point(282, 96)
        Me.txt_KYKM_NO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KYKM_NO.Name = "txt_KYKM_NO"
        Me.txt_KYKM_NO.ReadOnly = True
        Me.txt_KYKM_NO.Size = New System.Drawing.Size(104, 25)
        Me.txt_KYKM_NO.TabIndex = 56
        Me.txt_KYKM_NO.TabStop = False
        Me.txt_KYKM_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BUKN_NM
        '
        Me.txt_BUKN_NM.Location = New System.Drawing.Point(284, 139)
        Me.txt_BUKN_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BUKN_NM.Name = "txt_BUKN_NM"
        Me.txt_BUKN_NM.Size = New System.Drawing.Size(706, 25)
        Me.txt_BUKN_NM.TabIndex = 6
        '
        'Label_M2
        '
        Me.Label_M2.Location = New System.Drawing.Point(99, 13)
        Me.Label_M2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_M2.Name = "Label_M2"
        Me.Label_M2.Size = New System.Drawing.Size(111, 23)
        Me.Label_M2.TabIndex = 28
        '
        'cmb_SKYAK_HO_ID
        '
        Me.cmb_SKYAK_HO_ID.BackColor = System.Drawing.SystemColors.Control
        Me.cmb_SKYAK_HO_ID.Location = New System.Drawing.Point(555, 54)
        Me.cmb_SKYAK_HO_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SKYAK_HO_ID.Name = "cmb_SKYAK_HO_ID"
        Me.cmb_SKYAK_HO_ID.Size = New System.Drawing.Size(150, 26)
        Me.cmb_SKYAK_HO_ID.TabIndex = 10
        Me.cmb_SKYAK_HO_ID.TabStop = False
        '
        'cmb_SZEI_KJKBN_ID
        '
        Me.cmb_SZEI_KJKBN_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_SZEI_KJKBN_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_SZEI_KJKBN_ID.Location = New System.Drawing.Point(687, 15)
        Me.cmb_SZEI_KJKBN_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_SZEI_KJKBN_ID.Name = "cmb_SZEI_KJKBN_ID"
        Me.cmb_SZEI_KJKBN_ID.Size = New System.Drawing.Size(193, 26)
        Me.cmb_SZEI_KJKBN_ID.TabIndex = 1
        '
        'lbl_計上区分
        '
        Me.lbl_計上区分.Location = New System.Drawing.Point(184, 19)
        Me.lbl_計上区分.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_計上区分.Name = "lbl_計上区分"
        Me.lbl_計上区分.Size = New System.Drawing.Size(88, 20)
        Me.lbl_計上区分.TabIndex = 2
        Me.lbl_計上区分.Text = "計上区分"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(230, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "償却期間"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(185, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "物件No"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(457, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "償却方法"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(543, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "消費税計上区分"
        '
        'cmb_KJKBN_ID
        '
        Me.cmb_KJKBN_ID.FormattingEnabled = True
        Me.cmb_KJKBN_ID.Location = New System.Drawing.Point(280, 16)
        Me.cmb_KJKBN_ID.Name = "cmb_KJKBN_ID"
        Me.cmb_KJKBN_ID.Size = New System.Drawing.Size(75, 26)
        Me.cmb_KJKBN_ID.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(499, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox1.TabIndex = 101
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Location = New System.Drawing.Point(1014, 21)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox2.TabIndex = 101
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'pnlDetail
        '
        Me.pnlDetail.AutoScroll = True
        Me.pnlDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlDetail.Controls.Add(Me.dgv_DETAILS)
        Me.pnlDetail.Controls.Add(Me.DateTimePicker2)
        Me.pnlDetail.Controls.Add(Me.DateTimePicker1)
        Me.pnlDetail.Controls.Add(Me.lbl_現金購入価額)
        Me.pnlDetail.Controls.Add(Me.txt_KNYUKN)
        Me.pnlDetail.Controls.Add(Me.lbl_月額)
        Me.pnlDetail.Controls.Add(Me.txt_GLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_期間額)
        Me.pnlDetail.Controls.Add(Me.txt_KLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_前払)
        Me.pnlDetail.Controls.Add(Me.txt_MLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_総額)
        Me.pnlDetail.Controls.Add(Me.txt_SLSRYO)
        Me.pnlDetail.Controls.Add(Me.lbl_税抜き)
        Me.pnlDetail.Controls.Add(Me.lbl_消費税)
        Me.pnlDetail.Controls.Add(Me.txt_GZEI)
        Me.pnlDetail.Controls.Add(Me.txt_KZEI)
        Me.pnlDetail.Controls.Add(Me.txt_MZEI)
        Me.pnlDetail.Controls.Add(Me.lbl_税込み)
        Me.pnlDetail.Controls.Add(Me.txt_GLSRYO_ZKOMI)
        Me.pnlDetail.Controls.Add(Me.txt_KLSRYO_ZKOMI)
        Me.pnlDetail.Controls.Add(Me.txt_MLSRYO_ZKOMI)
        Me.pnlDetail.Controls.Add(Me.Label18)
        Me.pnlDetail.Controls.Add(Me.Label12)
        Me.pnlDetail.Controls.Add(Me.Label19)
        Me.pnlDetail.Controls.Add(Me.lbl_維持管理費用)
        Me.pnlDetail.Controls.Add(Me.TextBox15)
        Me.pnlDetail.Controls.Add(Me.TextBox13)
        Me.pnlDetail.Controls.Add(Me.TextBox14)
        Me.pnlDetail.Controls.Add(Me.txt_IJIKNR)
        Me.pnlDetail.Controls.Add(Me.lbl_残価保証額)
        Me.pnlDetail.Controls.Add(Me.txt_ZANRYO)
        Me.pnlDetail.Controls.Add(Me.CheckBox3)
        Me.pnlDetail.Controls.Add(Me.CheckBox2)
        Me.pnlDetail.Controls.Add(Me.CheckBox1)
        Me.pnlDetail.Controls.Add(Me.cmb_KJKBN_ID)
        Me.pnlDetail.Controls.Add(Me.Label11)
        Me.pnlDetail.Controls.Add(Me.Label8)
        Me.pnlDetail.Controls.Add(Me.Label7)
        Me.pnlDetail.Controls.Add(Me.Label6)
        Me.pnlDetail.Controls.Add(Me.Label30)
        Me.pnlDetail.Controls.Add(Me.Label29)
        Me.pnlDetail.Controls.Add(Me.Label28)
        Me.pnlDetail.Controls.Add(Me.Label1)
        Me.pnlDetail.Controls.Add(Me.Label10)
        Me.pnlDetail.Controls.Add(Me.Label5)
        Me.pnlDetail.Controls.Add(Me.Label3)
        Me.pnlDetail.Controls.Add(Me.Label25)
        Me.pnlDetail.Controls.Add(Me.Label24)
        Me.pnlDetail.Controls.Add(Me.Label23)
        Me.pnlDetail.Controls.Add(Me.Label22)
        Me.pnlDetail.Controls.Add(Me.Label21)
        Me.pnlDetail.Controls.Add(Me.Label20)
        Me.pnlDetail.Controls.Add(Me.Label17)
        Me.pnlDetail.Controls.Add(Me.Label16)
        Me.pnlDetail.Controls.Add(Me.Label15)
        Me.pnlDetail.Controls.Add(Me.Label14)
        Me.pnlDetail.Controls.Add(Me.Label13)
        Me.pnlDetail.Controls.Add(Me.Label27)
        Me.pnlDetail.Controls.Add(Me.Label26)
        Me.pnlDetail.Controls.Add(Me.Label9)
        Me.pnlDetail.Controls.Add(Me.Label4)
        Me.pnlDetail.Controls.Add(Me.Label2)
        Me.pnlDetail.Controls.Add(Me.lbl_計上区分)
        Me.pnlDetail.Controls.Add(Me.cmb_SZEI_KJKBN_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_SKYAK_HO_ID)
        Me.pnlDetail.Controls.Add(Me.Label_M2)
        Me.pnlDetail.Controls.Add(Me.txt_ZOKUSEI4)
        Me.pnlDetail.Controls.Add(Me.txt_ZOKUSEI3)
        Me.pnlDetail.Controls.Add(Me.txt_ZOKUSEI2)
        Me.pnlDetail.Controls.Add(Me.txt_ZOKUSEI1)
        Me.pnlDetail.Controls.Add(Me.txt_BUKN_NM)
        Me.pnlDetail.Controls.Add(Me.txt_SETTI_DT)
        Me.pnlDetail.Controls.Add(Me.txt_BUKN_BANGO3)
        Me.pnlDetail.Controls.Add(Me.txt_SUURYO)
        Me.pnlDetail.Controls.Add(Me.txt_BUKN_BANGO2)
        Me.pnlDetail.Controls.Add(Me.txt_BUKN_BANGO)
        Me.pnlDetail.Controls.Add(Me.txt_KEDABAN)
        Me.pnlDetail.Controls.Add(Me.txt_OLDBCAT1_NM)
        Me.pnlDetail.Controls.Add(Me.txt_OLDBCAT5_NM)
        Me.pnlDetail.Controls.Add(Me.txt_OLDBCAT4_NM)
        Me.pnlDetail.Controls.Add(Me.txt_BCAT5_NM)
        Me.pnlDetail.Controls.Add(Me.txt_OLDBCAT3_NM)
        Me.pnlDetail.Controls.Add(Me.txt_BCAT4_NM)
        Me.pnlDetail.Controls.Add(Me.txt_OLDBCAT2_NM)
        Me.pnlDetail.Controls.Add(Me.txt_BCAT3_NM)
        Me.pnlDetail.Controls.Add(Me.txt_BCAT2_NM)
        Me.pnlDetail.Controls.Add(Me.txt_BCAT1_NM)
        Me.pnlDetail.Controls.Add(Me.txt_KYKM_NO)
        Me.pnlDetail.Controls.Add(Me.txt_TAIYO_NEN)
        Me.pnlDetail.Controls.Add(Me.cmb_OLDBCAT_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_BCAT_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_RSRVB1_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_MCPT_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_GSHA_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_BKIND_ID)
        Me.pnlDetail.Controls.Add(Me.cmb_SKMK_ID)
        Me.pnlDetail.Controls.Add(Me.txt_RSRVB1_NM)
        Me.pnlDetail.Controls.Add(Me.txt_MCPT_NM)
        Me.pnlDetail.Controls.Add(Me.txt_GSHA_NM)
        Me.pnlDetail.Controls.Add(Me.txt_BKIND_NM)
        Me.pnlDetail.Controls.Add(Me.txt_SKMK_NM)
        Me.pnlDetail.Controls.Add(Me.cmd_REMOVE_HAIF)
        Me.pnlDetail.Controls.Add(Me.cmd_ADD_HAIF)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetail.Location = New System.Drawing.Point(0, 71)
        Me.pnlDetail.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(1505, 829)
        Me.pnlDetail.TabIndex = 16
        '
        'dgv_DETAILS
        '
        Me.dgv_DETAILS.AllowUserToAddRows = False
        Me.dgv_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DETAILS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_HAIF_RATE, Me.col_KLSRYO, Me.col_MLSRYO, Me.col_BCAT1_CD, Me.cmb_BCAT1_NM, Me.col_HIYOKBN_CD, Me.cmb_HIYOKBN_NM, Me.col_kzei, Me.col_mzei, Me.col_biko})
        Me.dgv_DETAILS.Location = New System.Drawing.Point(58, 614)
        Me.dgv_DETAILS.Name = "dgv_DETAILS"
        Me.dgv_DETAILS.RowHeadersWidth = 62
        Me.dgv_DETAILS.RowTemplate.Height = 27
        Me.dgv_DETAILS.Size = New System.Drawing.Size(1376, 175)
        Me.dgv_DETAILS.TabIndex = 29
        '
        'col_HAIF_RATE
        '
        Me.col_HAIF_RATE.HeaderText = "配賦率"
        Me.col_HAIF_RATE.MinimumWidth = 8
        Me.col_HAIF_RATE.Name = "col_HAIF_RATE"
        Me.col_HAIF_RATE.Width = 60
        '
        'col_KLSRYO
        '
        Me.col_KLSRYO.HeaderText = "1支払額"
        Me.col_KLSRYO.MinimumWidth = 8
        Me.col_KLSRYO.Name = "col_KLSRYO"
        Me.col_KLSRYO.Width = 80
        '
        'col_MLSRYO
        '
        Me.col_MLSRYO.HeaderText = "前払"
        Me.col_MLSRYO.MinimumWidth = 8
        Me.col_MLSRYO.Name = "col_MLSRYO"
        Me.col_MLSRYO.Width = 80
        '
        'col_BCAT1_CD
        '
        Me.col_BCAT1_CD.HeaderText = "費用負担部署CD"
        Me.col_BCAT1_CD.MinimumWidth = 8
        Me.col_BCAT1_CD.Name = "col_BCAT1_CD"
        Me.col_BCAT1_CD.Width = 150
        '
        'cmb_BCAT1_NM
        '
        Me.cmb_BCAT1_NM.HeaderText = "費用負担部署"
        Me.cmb_BCAT1_NM.MinimumWidth = 8
        Me.cmb_BCAT1_NM.Name = "cmb_BCAT1_NM"
        Me.cmb_BCAT1_NM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmb_BCAT1_NM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmb_BCAT1_NM.Width = 180
        '
        'col_HIYOKBN_CD
        '
        Me.col_HIYOKBN_CD.HeaderText = "費用区分CD"
        Me.col_HIYOKBN_CD.MinimumWidth = 8
        Me.col_HIYOKBN_CD.Name = "col_HIYOKBN_CD"
        Me.col_HIYOKBN_CD.Width = 150
        '
        'cmb_HIYOKBN_NM
        '
        Me.cmb_HIYOKBN_NM.HeaderText = "費用区分"
        Me.cmb_HIYOKBN_NM.MinimumWidth = 8
        Me.cmb_HIYOKBN_NM.Name = "cmb_HIYOKBN_NM"
        Me.cmb_HIYOKBN_NM.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmb_HIYOKBN_NM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmb_HIYOKBN_NM.Width = 180
        '
        'col_kzei
        '
        Me.col_kzei.HeaderText = "1支払消費税"
        Me.col_kzei.MinimumWidth = 8
        Me.col_kzei.Name = "col_kzei"
        Me.col_kzei.Width = 80
        '
        'col_mzei
        '
        Me.col_mzei.HeaderText = "前払消費税"
        Me.col_mzei.MinimumWidth = 8
        Me.col_mzei.Name = "col_mzei"
        Me.col_mzei.Width = 80
        '
        'col_biko
        '
        Me.col_biko.HeaderText = "備考"
        Me.col_biko.MinimumWidth = 8
        Me.col_biko.Name = "col_biko"
        Me.col_biko.Width = 150
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(1294, 501)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(140, 25)
        Me.DateTimePicker2.TabIndex = 125
        Me.DateTimePicker2.Value = New Date(2026, 1, 20, 0, 0, 0, 0)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1294, 528)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 25)
        Me.DateTimePicker1.TabIndex = 125
        Me.DateTimePicker1.Value = New Date(2026, 1, 20, 0, 0, 0, 0)
        '
        'lbl_現金購入価額
        '
        Me.lbl_現金購入価額.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_現金購入価額.ForeColor = System.Drawing.Color.White
        Me.lbl_現金購入価額.Location = New System.Drawing.Point(56, 184)
        Me.lbl_現金購入価額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_現金購入価額.Name = "lbl_現金購入価額"
        Me.lbl_現金購入価額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_現金購入価額.TabIndex = 123
        Me.lbl_現金購入価額.Text = "現金購入価額"
        '
        'txt_KNYUKN
        '
        Me.txt_KNYUKN.Location = New System.Drawing.Point(214, 184)
        Me.txt_KNYUKN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KNYUKN.Name = "txt_KNYUKN"
        Me.txt_KNYUKN.Size = New System.Drawing.Size(156, 25)
        Me.txt_KNYUKN.TabIndex = 9
        Me.txt_KNYUKN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_月額
        '
        Me.lbl_月額.BackColor = System.Drawing.Color.Blue
        Me.lbl_月額.ForeColor = System.Drawing.Color.White
        Me.lbl_月額.Location = New System.Drawing.Point(804, 210)
        Me.lbl_月額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_月額.Name = "lbl_月額"
        Me.lbl_月額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_月額.TabIndex = 102
        Me.lbl_月額.Text = "月額"
        '
        'txt_GLSRYO
        '
        Me.txt_GLSRYO.BackColor = System.Drawing.SystemColors.Control
        Me.txt_GLSRYO.Location = New System.Drawing.Point(963, 210)
        Me.txt_GLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GLSRYO.Name = "txt_GLSRYO"
        Me.txt_GLSRYO.ReadOnly = True
        Me.txt_GLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_GLSRYO.TabIndex = 103
        Me.txt_GLSRYO.TabStop = False
        Me.txt_GLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_期間額
        '
        Me.lbl_期間額.BackColor = System.Drawing.Color.Blue
        Me.lbl_期間額.ForeColor = System.Drawing.Color.White
        Me.lbl_期間額.Location = New System.Drawing.Point(804, 232)
        Me.lbl_期間額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_期間額.Name = "lbl_期間額"
        Me.lbl_期間額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_期間額.TabIndex = 104
        Me.lbl_期間額.Text = "１支払額"
        '
        'txt_KLSRYO
        '
        Me.txt_KLSRYO.Location = New System.Drawing.Point(963, 232)
        Me.txt_KLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KLSRYO.Name = "txt_KLSRYO"
        Me.txt_KLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_KLSRYO.TabIndex = 10
        Me.txt_KLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_前払
        '
        Me.lbl_前払.BackColor = System.Drawing.Color.Blue
        Me.lbl_前払.ForeColor = System.Drawing.Color.White
        Me.lbl_前払.Location = New System.Drawing.Point(804, 256)
        Me.lbl_前払.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_前払.Name = "lbl_前払"
        Me.lbl_前払.Size = New System.Drawing.Size(158, 22)
        Me.lbl_前払.TabIndex = 106
        Me.lbl_前払.Text = "前払"
        '
        'txt_MLSRYO
        '
        Me.txt_MLSRYO.Location = New System.Drawing.Point(963, 256)
        Me.txt_MLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MLSRYO.Name = "txt_MLSRYO"
        Me.txt_MLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_MLSRYO.TabIndex = 13
        Me.txt_MLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_総額
        '
        Me.lbl_総額.BackColor = System.Drawing.Color.Blue
        Me.lbl_総額.ForeColor = System.Drawing.Color.White
        Me.lbl_総額.Location = New System.Drawing.Point(804, 278)
        Me.lbl_総額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_総額.Name = "lbl_総額"
        Me.lbl_総額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_総額.TabIndex = 108
        Me.lbl_総額.Text = "総額"
        '
        'txt_SLSRYO
        '
        Me.txt_SLSRYO.BackColor = System.Drawing.SystemColors.Control
        Me.txt_SLSRYO.Location = New System.Drawing.Point(963, 278)
        Me.txt_SLSRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SLSRYO.Name = "txt_SLSRYO"
        Me.txt_SLSRYO.ReadOnly = True
        Me.txt_SLSRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_SLSRYO.TabIndex = 109
        Me.txt_SLSRYO.TabStop = False
        Me.txt_SLSRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_税抜き
        '
        Me.lbl_税抜き.Location = New System.Drawing.Point(963, 187)
        Me.lbl_税抜き.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_税抜き.Name = "lbl_税抜き"
        Me.lbl_税抜き.Size = New System.Drawing.Size(158, 22)
        Me.lbl_税抜き.TabIndex = 110
        Me.lbl_税抜き.Text = "税抜き"
        '
        'lbl_消費税
        '
        Me.lbl_消費税.Location = New System.Drawing.Point(1121, 187)
        Me.lbl_消費税.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_消費税.Name = "lbl_消費税"
        Me.lbl_消費税.Size = New System.Drawing.Size(158, 22)
        Me.lbl_消費税.TabIndex = 111
        Me.lbl_消費税.Text = "消費税"
        '
        'txt_GZEI
        '
        Me.txt_GZEI.BackColor = System.Drawing.SystemColors.Control
        Me.txt_GZEI.Location = New System.Drawing.Point(1119, 210)
        Me.txt_GZEI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GZEI.Name = "txt_GZEI"
        Me.txt_GZEI.ReadOnly = True
        Me.txt_GZEI.Size = New System.Drawing.Size(156, 25)
        Me.txt_GZEI.TabIndex = 112
        Me.txt_GZEI.TabStop = False
        Me.txt_GZEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_KZEI
        '
        Me.txt_KZEI.Location = New System.Drawing.Point(1119, 232)
        Me.txt_KZEI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KZEI.Name = "txt_KZEI"
        Me.txt_KZEI.Size = New System.Drawing.Size(156, 25)
        Me.txt_KZEI.TabIndex = 11
        Me.txt_KZEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MZEI
        '
        Me.txt_MZEI.Location = New System.Drawing.Point(1119, 256)
        Me.txt_MZEI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MZEI.Name = "txt_MZEI"
        Me.txt_MZEI.Size = New System.Drawing.Size(156, 25)
        Me.txt_MZEI.TabIndex = 14
        Me.txt_MZEI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_税込み
        '
        Me.lbl_税込み.Location = New System.Drawing.Point(1278, 187)
        Me.lbl_税込み.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_税込み.Name = "lbl_税込み"
        Me.lbl_税込み.Size = New System.Drawing.Size(158, 22)
        Me.lbl_税込み.TabIndex = 115
        Me.lbl_税込み.Text = "税込み"
        '
        'txt_GLSRYO_ZKOMI
        '
        Me.txt_GLSRYO_ZKOMI.BackColor = System.Drawing.SystemColors.Control
        Me.txt_GLSRYO_ZKOMI.Location = New System.Drawing.Point(1278, 210)
        Me.txt_GLSRYO_ZKOMI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GLSRYO_ZKOMI.Name = "txt_GLSRYO_ZKOMI"
        Me.txt_GLSRYO_ZKOMI.ReadOnly = True
        Me.txt_GLSRYO_ZKOMI.Size = New System.Drawing.Size(156, 25)
        Me.txt_GLSRYO_ZKOMI.TabIndex = 116
        Me.txt_GLSRYO_ZKOMI.TabStop = False
        Me.txt_GLSRYO_ZKOMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_KLSRYO_ZKOMI
        '
        Me.txt_KLSRYO_ZKOMI.Location = New System.Drawing.Point(1278, 232)
        Me.txt_KLSRYO_ZKOMI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KLSRYO_ZKOMI.Name = "txt_KLSRYO_ZKOMI"
        Me.txt_KLSRYO_ZKOMI.Size = New System.Drawing.Size(156, 25)
        Me.txt_KLSRYO_ZKOMI.TabIndex = 12
        Me.txt_KLSRYO_ZKOMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MLSRYO_ZKOMI
        '
        Me.txt_MLSRYO_ZKOMI.Location = New System.Drawing.Point(1278, 256)
        Me.txt_MLSRYO_ZKOMI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MLSRYO_ZKOMI.Name = "txt_MLSRYO_ZKOMI"
        Me.txt_MLSRYO_ZKOMI.Size = New System.Drawing.Size(156, 25)
        Me.txt_MLSRYO_ZKOMI.TabIndex = 15
        Me.txt_MLSRYO_ZKOMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Blue
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1121, 348)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 25)
        Me.Label18.TabIndex = 119
        Me.Label18.Text = "保守料"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Blue
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1121, 348)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 22)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "総額(変額)"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Blue
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(804, 348)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 22)
        Me.Label19.TabIndex = 119
        Me.Label19.Text = "総額(変額)"
        '
        'lbl_維持管理費用
        '
        Me.lbl_維持管理費用.BackColor = System.Drawing.Color.Blue
        Me.lbl_維持管理費用.ForeColor = System.Drawing.Color.White
        Me.lbl_維持管理費用.Location = New System.Drawing.Point(804, 301)
        Me.lbl_維持管理費用.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_維持管理費用.Name = "lbl_維持管理費用"
        Me.lbl_維持管理費用.Size = New System.Drawing.Size(158, 22)
        Me.lbl_維持管理費用.TabIndex = 119
        Me.lbl_維持管理費用.Text = "内維持管理費用"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox15.Location = New System.Drawing.Point(1280, 348)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(156, 25)
        Me.TextBox15.TabIndex = 120
        Me.TextBox15.TabStop = False
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(1280, 348)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(156, 25)
        Me.TextBox13.TabIndex = 120
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox14.Location = New System.Drawing.Point(961, 348)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(160, 25)
        Me.TextBox14.TabIndex = 120
        Me.TextBox14.TabStop = False
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_IJIKNR
        '
        Me.txt_IJIKNR.Location = New System.Drawing.Point(963, 301)
        Me.txt_IJIKNR.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_IJIKNR.Name = "txt_IJIKNR"
        Me.txt_IJIKNR.Size = New System.Drawing.Size(156, 25)
        Me.txt_IJIKNR.TabIndex = 16
        Me.txt_IJIKNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_残価保証額
        '
        Me.lbl_残価保証額.BackColor = System.Drawing.Color.Blue
        Me.lbl_残価保証額.ForeColor = System.Drawing.Color.White
        Me.lbl_残価保証額.Location = New System.Drawing.Point(804, 324)
        Me.lbl_残価保証額.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_残価保証額.Name = "lbl_残価保証額"
        Me.lbl_残価保証額.Size = New System.Drawing.Size(158, 22)
        Me.lbl_残価保証額.TabIndex = 121
        Me.lbl_残価保証額.Text = "残価保証額"
        '
        'txt_ZANRYO
        '
        Me.txt_ZANRYO.Location = New System.Drawing.Point(963, 324)
        Me.txt_ZANRYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZANRYO.Name = "txt_ZANRYO"
        Me.txt_ZANRYO.Size = New System.Drawing.Size(156, 25)
        Me.txt_ZANRYO.TabIndex = 17
        Me.txt_ZANRYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox3.Location = New System.Drawing.Point(1399, 577)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox3.TabIndex = 101
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(1184, 142)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 22)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "設置日"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1185, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 22)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "資産番号3"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(893, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "資産番号2"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(612, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "資産番号1"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(1275, 576)
        Me.Label30.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(128, 22)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "廃止部署選択"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(890, 17)
        Me.Label29.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(128, 22)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "自動設定禁止"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(363, 17)
        Me.Label28.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(128, 22)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "自動設定禁止"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(1021, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 22)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "数量"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(396, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "枝番"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(56, 528)
        Me.Label25.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 20)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "旧"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(56, 502)
        Me.Label24.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 20)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "管理部署"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(55, 476)
        Me.Label23.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 20)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "備考4"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(55, 449)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 20)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "備考3"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(55, 422)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 20)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "備考2"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(55, 395)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 20)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "備考"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(55, 348)
        Me.Label17.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 20)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "物件予備"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(55, 304)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 20)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "メーカー"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(55, 281)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "購入先"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(55, 258)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "物件種別"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(55, 234)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "資産区分"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(1231, 531)
        Me.Label27.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 22)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "移動日"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(1231, 503)
        Me.Label26.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 22)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "移動日"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(186, 139)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "物件名称"
        '
        'txt_ZOKUSEI4
        '
        Me.txt_ZOKUSEI4.Location = New System.Drawing.Point(143, 473)
        Me.txt_ZOKUSEI4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZOKUSEI4.Name = "txt_ZOKUSEI4"
        Me.txt_ZOKUSEI4.Size = New System.Drawing.Size(1291, 25)
        Me.txt_ZOKUSEI4.TabIndex = 26
        '
        'txt_ZOKUSEI3
        '
        Me.txt_ZOKUSEI3.Location = New System.Drawing.Point(143, 446)
        Me.txt_ZOKUSEI3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZOKUSEI3.Name = "txt_ZOKUSEI3"
        Me.txt_ZOKUSEI3.Size = New System.Drawing.Size(1291, 25)
        Me.txt_ZOKUSEI3.TabIndex = 25
        '
        'txt_ZOKUSEI2
        '
        Me.txt_ZOKUSEI2.Location = New System.Drawing.Point(143, 419)
        Me.txt_ZOKUSEI2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZOKUSEI2.Name = "txt_ZOKUSEI2"
        Me.txt_ZOKUSEI2.Size = New System.Drawing.Size(1291, 25)
        Me.txt_ZOKUSEI2.TabIndex = 24
        '
        'txt_ZOKUSEI1
        '
        Me.txt_ZOKUSEI1.Location = New System.Drawing.Point(143, 392)
        Me.txt_ZOKUSEI1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZOKUSEI1.Name = "txt_ZOKUSEI1"
        Me.txt_ZOKUSEI1.Size = New System.Drawing.Size(1291, 25)
        Me.txt_ZOKUSEI1.TabIndex = 23
        '
        'txt_SETTI_DT
        '
        Me.txt_SETTI_DT.Location = New System.Drawing.Point(1308, 142)
        Me.txt_SETTI_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SETTI_DT.Name = "txt_SETTI_DT"
        Me.txt_SETTI_DT.Size = New System.Drawing.Size(128, 25)
        Me.txt_SETTI_DT.TabIndex = 8
        Me.txt_SETTI_DT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BUKN_BANGO3
        '
        Me.txt_BUKN_BANGO3.Location = New System.Drawing.Point(1306, 99)
        Me.txt_BUKN_BANGO3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BUKN_BANGO3.Name = "txt_BUKN_BANGO3"
        Me.txt_BUKN_BANGO3.Size = New System.Drawing.Size(128, 25)
        Me.txt_BUKN_BANGO3.TabIndex = 5
        Me.txt_BUKN_BANGO3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SUURYO
        '
        Me.txt_SUURYO.Location = New System.Drawing.Point(1088, 139)
        Me.txt_SUURYO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SUURYO.Name = "txt_SUURYO"
        Me.txt_SUURYO.Size = New System.Drawing.Size(86, 25)
        Me.txt_SUURYO.TabIndex = 7
        Me.txt_SUURYO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BUKN_BANGO2
        '
        Me.txt_BUKN_BANGO2.Location = New System.Drawing.Point(1014, 99)
        Me.txt_BUKN_BANGO2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BUKN_BANGO2.Name = "txt_BUKN_BANGO2"
        Me.txt_BUKN_BANGO2.Size = New System.Drawing.Size(128, 25)
        Me.txt_BUKN_BANGO2.TabIndex = 4
        Me.txt_BUKN_BANGO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_BUKN_BANGO
        '
        Me.txt_BUKN_BANGO.Location = New System.Drawing.Point(733, 96)
        Me.txt_BUKN_BANGO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BUKN_BANGO.Name = "txt_BUKN_BANGO"
        Me.txt_BUKN_BANGO.Size = New System.Drawing.Size(128, 25)
        Me.txt_BUKN_BANGO.TabIndex = 3
        Me.txt_BUKN_BANGO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_KEDABAN
        '
        Me.txt_KEDABAN.Location = New System.Drawing.Point(482, 96)
        Me.txt_KEDABAN.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KEDABAN.Name = "txt_KEDABAN"
        Me.txt_KEDABAN.Size = New System.Drawing.Size(104, 25)
        Me.txt_KEDABAN.TabIndex = 2
        Me.txt_KEDABAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_OLDBCAT1_NM
        '
        Me.txt_OLDBCAT1_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_OLDBCAT1_NM.Location = New System.Drawing.Point(298, 526)
        Me.txt_OLDBCAT1_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_OLDBCAT1_NM.Name = "txt_OLDBCAT1_NM"
        Me.txt_OLDBCAT1_NM.ReadOnly = True
        Me.txt_OLDBCAT1_NM.Size = New System.Drawing.Size(351, 25)
        Me.txt_OLDBCAT1_NM.TabIndex = 56
        Me.txt_OLDBCAT1_NM.TabStop = False
        '
        'txt_OLDBCAT5_NM
        '
        Me.txt_OLDBCAT5_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_OLDBCAT5_NM.Location = New System.Drawing.Point(1088, 527)
        Me.txt_OLDBCAT5_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_OLDBCAT5_NM.Name = "txt_OLDBCAT5_NM"
        Me.txt_OLDBCAT5_NM.ReadOnly = True
        Me.txt_OLDBCAT5_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_OLDBCAT5_NM.TabIndex = 56
        Me.txt_OLDBCAT5_NM.TabStop = False
        '
        'txt_OLDBCAT4_NM
        '
        Me.txt_OLDBCAT4_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_OLDBCAT4_NM.Location = New System.Drawing.Point(944, 527)
        Me.txt_OLDBCAT4_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_OLDBCAT4_NM.Name = "txt_OLDBCAT4_NM"
        Me.txt_OLDBCAT4_NM.ReadOnly = True
        Me.txt_OLDBCAT4_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_OLDBCAT4_NM.TabIndex = 56
        Me.txt_OLDBCAT4_NM.TabStop = False
        '
        'txt_BCAT5_NM
        '
        Me.txt_BCAT5_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_BCAT5_NM.Location = New System.Drawing.Point(1087, 499)
        Me.txt_BCAT5_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BCAT5_NM.Name = "txt_BCAT5_NM"
        Me.txt_BCAT5_NM.ReadOnly = True
        Me.txt_BCAT5_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_BCAT5_NM.TabIndex = 56
        Me.txt_BCAT5_NM.TabStop = False
        '
        'txt_OLDBCAT3_NM
        '
        Me.txt_OLDBCAT3_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_OLDBCAT3_NM.Location = New System.Drawing.Point(800, 527)
        Me.txt_OLDBCAT3_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_OLDBCAT3_NM.Name = "txt_OLDBCAT3_NM"
        Me.txt_OLDBCAT3_NM.ReadOnly = True
        Me.txt_OLDBCAT3_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_OLDBCAT3_NM.TabIndex = 56
        Me.txt_OLDBCAT3_NM.TabStop = False
        '
        'txt_BCAT4_NM
        '
        Me.txt_BCAT4_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_BCAT4_NM.Location = New System.Drawing.Point(943, 499)
        Me.txt_BCAT4_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BCAT4_NM.Name = "txt_BCAT4_NM"
        Me.txt_BCAT4_NM.ReadOnly = True
        Me.txt_BCAT4_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_BCAT4_NM.TabIndex = 56
        Me.txt_BCAT4_NM.TabStop = False
        '
        'txt_OLDBCAT2_NM
        '
        Me.txt_OLDBCAT2_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_OLDBCAT2_NM.Location = New System.Drawing.Point(656, 527)
        Me.txt_OLDBCAT2_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_OLDBCAT2_NM.Name = "txt_OLDBCAT2_NM"
        Me.txt_OLDBCAT2_NM.ReadOnly = True
        Me.txt_OLDBCAT2_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_OLDBCAT2_NM.TabIndex = 56
        Me.txt_OLDBCAT2_NM.TabStop = False
        '
        'txt_BCAT3_NM
        '
        Me.txt_BCAT3_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_BCAT3_NM.Location = New System.Drawing.Point(799, 499)
        Me.txt_BCAT3_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BCAT3_NM.Name = "txt_BCAT3_NM"
        Me.txt_BCAT3_NM.ReadOnly = True
        Me.txt_BCAT3_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_BCAT3_NM.TabIndex = 56
        Me.txt_BCAT3_NM.TabStop = False
        '
        'txt_BCAT2_NM
        '
        Me.txt_BCAT2_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_BCAT2_NM.Location = New System.Drawing.Point(655, 499)
        Me.txt_BCAT2_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BCAT2_NM.Name = "txt_BCAT2_NM"
        Me.txt_BCAT2_NM.ReadOnly = True
        Me.txt_BCAT2_NM.Size = New System.Drawing.Size(134, 25)
        Me.txt_BCAT2_NM.TabIndex = 56
        Me.txt_BCAT2_NM.TabStop = False
        '
        'txt_BCAT1_NM
        '
        Me.txt_BCAT1_NM.BackColor = System.Drawing.SystemColors.Control
        Me.txt_BCAT1_NM.Location = New System.Drawing.Point(298, 499)
        Me.txt_BCAT1_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BCAT1_NM.Name = "txt_BCAT1_NM"
        Me.txt_BCAT1_NM.ReadOnly = True
        Me.txt_BCAT1_NM.Size = New System.Drawing.Size(351, 25)
        Me.txt_BCAT1_NM.TabIndex = 56
        Me.txt_BCAT1_NM.TabStop = False
        '
        'cmb_OLDBCAT_ID
        '
        Me.cmb_OLDBCAT_ID.Location = New System.Drawing.Point(143, 526)
        Me.cmb_OLDBCAT_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_OLDBCAT_ID.Name = "cmb_OLDBCAT_ID"
        Me.cmb_OLDBCAT_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_OLDBCAT_ID.TabIndex = 28
        '
        'cmb_BCAT_ID
        '
        Me.cmb_BCAT_ID.Location = New System.Drawing.Point(143, 500)
        Me.cmb_BCAT_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_BCAT_ID.Name = "cmb_BCAT_ID"
        Me.cmb_BCAT_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_BCAT_ID.TabIndex = 27
        '
        'cmb_RSRVB1_ID
        '
        Me.cmb_RSRVB1_ID.Location = New System.Drawing.Point(143, 344)
        Me.cmb_RSRVB1_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_RSRVB1_ID.Name = "cmb_RSRVB1_ID"
        Me.cmb_RSRVB1_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_RSRVB1_ID.TabIndex = 22
        '
        'cmb_MCPT_ID
        '
        Me.cmb_MCPT_ID.Location = New System.Drawing.Point(143, 300)
        Me.cmb_MCPT_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_MCPT_ID.Name = "cmb_MCPT_ID"
        Me.cmb_MCPT_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_MCPT_ID.TabIndex = 21
        '
        'cmb_GSHA_ID
        '
        Me.cmb_GSHA_ID.Location = New System.Drawing.Point(143, 277)
        Me.cmb_GSHA_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_GSHA_ID.Name = "cmb_GSHA_ID"
        Me.cmb_GSHA_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_GSHA_ID.TabIndex = 20
        '
        'cmb_BKIND_ID
        '
        Me.cmb_BKIND_ID.Location = New System.Drawing.Point(143, 254)
        Me.cmb_BKIND_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmb_BKIND_ID.Name = "cmb_BKIND_ID"
        Me.cmb_BKIND_ID.Size = New System.Drawing.Size(145, 26)
        Me.cmb_BKIND_ID.TabIndex = 19
        '
        'txt_RSRVB1_NM
        '
        Me.txt_RSRVB1_NM.Location = New System.Drawing.Point(298, 345)
        Me.txt_RSRVB1_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_RSRVB1_NM.Name = "txt_RSRVB1_NM"
        Me.txt_RSRVB1_NM.ReadOnly = True
        Me.txt_RSRVB1_NM.Size = New System.Drawing.Size(365, 25)
        Me.txt_RSRVB1_NM.TabIndex = 92
        Me.txt_RSRVB1_NM.TabStop = False
        '
        'txt_MCPT_NM
        '
        Me.txt_MCPT_NM.Location = New System.Drawing.Point(298, 301)
        Me.txt_MCPT_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_MCPT_NM.Name = "txt_MCPT_NM"
        Me.txt_MCPT_NM.ReadOnly = True
        Me.txt_MCPT_NM.Size = New System.Drawing.Size(365, 25)
        Me.txt_MCPT_NM.TabIndex = 92
        Me.txt_MCPT_NM.TabStop = False
        '
        'txt_GSHA_NM
        '
        Me.txt_GSHA_NM.Location = New System.Drawing.Point(298, 278)
        Me.txt_GSHA_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_GSHA_NM.Name = "txt_GSHA_NM"
        Me.txt_GSHA_NM.ReadOnly = True
        Me.txt_GSHA_NM.Size = New System.Drawing.Size(365, 25)
        Me.txt_GSHA_NM.TabIndex = 92
        Me.txt_GSHA_NM.TabStop = False
        '
        'txt_BKIND_NM
        '
        Me.txt_BKIND_NM.Location = New System.Drawing.Point(298, 255)
        Me.txt_BKIND_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BKIND_NM.Name = "txt_BKIND_NM"
        Me.txt_BKIND_NM.ReadOnly = True
        Me.txt_BKIND_NM.Size = New System.Drawing.Size(365, 25)
        Me.txt_BKIND_NM.TabIndex = 92
        Me.txt_BKIND_NM.TabStop = False
        '
        'cmd_REMOVE_HAIF
        '
        Me.cmd_REMOVE_HAIF.Location = New System.Drawing.Point(224, 576)
        Me.cmd_REMOVE_HAIF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REMOVE_HAIF.Name = "cmd_REMOVE_HAIF"
        Me.cmd_REMOVE_HAIF.Size = New System.Drawing.Size(145, 30)
        Me.cmd_REMOVE_HAIF.TabIndex = 97
        Me.cmd_REMOVE_HAIF.TabStop = False
        Me.cmd_REMOVE_HAIF.Text = "配賦行削除"
        '
        'Form_BuknEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 900)
        Me.Controls.Add(Me.pnlDetail)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_BuknEntry"
        Me.Text = "物件"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlDetail.ResumeLayout(False)
        Me.pnlDetail.PerformLayout()
        CType(Me.dgv_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_KJHNTI As Button
    Friend WithEvents cmd_MAINTANANCECOST As Button
    Friend WithEvents cmd_CHANGE As Button
    Friend WithEvents cmd_DEVIDE As Button
    Friend WithEvents cmd_COPYZ As Button
    Friend WithEvents cmd_COPYA As Button
    Friend WithEvents cmd_DELETE As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents cmd_ADD_HAIF As Button
    Friend WithEvents txt_SKMK_NM As TextBox
    Friend WithEvents cmb_SKMK_ID As ComboBox
    Friend WithEvents txt_TAIYO_NEN As TextBox
    Friend WithEvents txt_KYKM_NO As TextBox
    Friend WithEvents txt_BUKN_NM As TextBox
    Friend WithEvents Label_M2 As Label
    Friend WithEvents cmb_SKYAK_HO_ID As ComboBox
    Friend WithEvents cmb_SZEI_KJKBN_ID As ComboBox
    Friend WithEvents lbl_計上区分 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_KJKBN_ID As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents pnlDetail As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_BUKN_BANGO3 As TextBox
    Friend WithEvents txt_BUKN_BANGO2 As TextBox
    Friend WithEvents txt_BUKN_BANGO As TextBox
    Friend WithEvents txt_KEDABAN As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_SETTI_DT As TextBox
    Friend WithEvents txt_SUURYO As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_MCPT_ID As ComboBox
    Friend WithEvents cmb_GSHA_ID As ComboBox
    Friend WithEvents cmb_BKIND_ID As ComboBox
    Friend WithEvents txt_MCPT_NM As TextBox
    Friend WithEvents txt_GSHA_NM As TextBox
    Friend WithEvents txt_BKIND_NM As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmb_RSRVB1_ID As ComboBox
    Friend WithEvents txt_RSRVB1_NM As TextBox
    Friend WithEvents lbl_月額 As Label
    Friend WithEvents txt_GLSRYO As TextBox
    Friend WithEvents lbl_期間額 As Label
    Friend WithEvents txt_KLSRYO As TextBox
    Friend WithEvents lbl_前払 As Label
    Friend WithEvents txt_MLSRYO As TextBox
    Friend WithEvents lbl_総額 As Label
    Friend WithEvents txt_SLSRYO As TextBox
    Friend WithEvents lbl_税抜き As Label
    Friend WithEvents lbl_消費税 As Label
    Friend WithEvents txt_GZEI As TextBox
    Friend WithEvents txt_KZEI As TextBox
    Friend WithEvents txt_MZEI As TextBox
    Friend WithEvents lbl_税込み As Label
    Friend WithEvents txt_GLSRYO_ZKOMI As TextBox
    Friend WithEvents txt_KLSRYO_ZKOMI As TextBox
    Friend WithEvents txt_MLSRYO_ZKOMI As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_維持管理費用 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents txt_IJIKNR As TextBox
    Friend WithEvents lbl_残価保証額 As Label
    Friend WithEvents txt_ZANRYO As TextBox
    Friend WithEvents lbl_現金購入価額 As Label
    Friend WithEvents txt_KNYUKN As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_ZOKUSEI4 As TextBox
    Friend WithEvents txt_ZOKUSEI3 As TextBox
    Friend WithEvents txt_ZOKUSEI2 As TextBox
    Friend WithEvents txt_ZOKUSEI1 As TextBox
    Friend WithEvents cmb_BCAT_ID As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_OLDBCAT1_NM As TextBox
    Friend WithEvents txt_OLDBCAT5_NM As TextBox
    Friend WithEvents txt_OLDBCAT4_NM As TextBox
    Friend WithEvents txt_BCAT5_NM As TextBox
    Friend WithEvents txt_OLDBCAT3_NM As TextBox
    Friend WithEvents txt_BCAT4_NM As TextBox
    Friend WithEvents txt_OLDBCAT2_NM As TextBox
    Friend WithEvents txt_BCAT3_NM As TextBox
    Friend WithEvents txt_BCAT2_NM As TextBox
    Friend WithEvents txt_BCAT1_NM As TextBox
    Friend WithEvents cmb_OLDBCAT_ID As ComboBox
    Friend WithEvents cmd_REMOVE_HAIF As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dgv_DETAILS As DataGridView
    Friend WithEvents col_HAIF_RATE As DataGridViewTextBoxColumn
    Friend WithEvents col_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_MLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_BCAT1_CD As DataGridViewTextBoxColumn
    Friend WithEvents cmb_BCAT1_NM As DataGridViewComboBoxColumn
    Friend WithEvents col_HIYOKBN_CD As DataGridViewTextBoxColumn
    Friend WithEvents cmb_HIYOKBN_NM As DataGridViewComboBoxColumn
    Friend WithEvents col_kzei As DataGridViewTextBoxColumn
    Friend WithEvents col_mzei As DataGridViewTextBoxColumn
    Friend WithEvents col_biko As DataGridViewTextBoxColumn
End Class
