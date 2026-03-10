<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_f_IMPORT_IDO_FROM_EXCEL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_PRE_CREATE = New System.Windows.Forms.Button()
        Me.cmd_INPUT = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_SHORI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKH_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LINE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KEDABAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_BANGO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_BANGO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_BANGO3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SUURYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SETTI_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_END_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_CKAIYK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KZEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_MLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_MZEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHORI_KIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_IDO_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_BCAT_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SKMK_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BKIND_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BKIND_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_GSHA_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_GSHA_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_MCPT_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_MCPT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_RSRVB1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_RSRVB1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZOKUSEI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZOKUSEI2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZOKUSEI3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZOKUSEI4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HKHO_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HKHO_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HK_GSHA_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HK_GSHA_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HAIFRITU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_KZEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_MLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_MZEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_BCAT_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HKMK_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_HKMK_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_H_ZOKUSEI1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(806, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "物件フレックスの「物件移動取込用データExcel出力」で出力したデータに記入した物件移動情報を取り込みます。"
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(720, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(176, 39)
        Me.cmd_CREATE.TabIndex = 4
        Me.cmd_CREATE.TabStop = False
        Me.cmd_CREATE.Text = "本登録(&A)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_PRE_CREATE
        '
        Me.cmd_PRE_CREATE.Location = New System.Drawing.Point(534, 13)
        Me.cmd_PRE_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_PRE_CREATE.Name = "cmd_PRE_CREATE"
        Me.cmd_PRE_CREATE.Size = New System.Drawing.Size(176, 39)
        Me.cmd_PRE_CREATE.TabIndex = 3
        Me.cmd_PRE_CREATE.TabStop = False
        Me.cmd_PRE_CREATE.Text = "本登録の準備(&P)"
        Me.cmd_PRE_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_INPUT
        '
        Me.cmd_INPUT.Location = New System.Drawing.Point(149, 13)
        Me.cmd_INPUT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_INPUT.Name = "cmd_INPUT"
        Me.cmd_INPUT.Size = New System.Drawing.Size(375, 39)
        Me.cmd_INPUT.TabIndex = 2
        Me.cmd_INPUT.TabStop = False
        Me.cmd_INPUT.Text = "Excelをワークテーブルに取り込む(&I)"
        Me.cmd_INPUT.UseVisualStyleBackColor = True
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 1
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'dgv_LIST
        '
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_SHORI, Me.col_KYKH_NO, Me.col_KYKM_NO, Me.col_SAIKAISU, Me.col_LINE_ID, Me.col_KYKBNL, Me.col_KEDABAN, Me.col_BUKN_BANGO1, Me.col_BUKN_BANGO2, Me.col_BUKN_BANGO3, Me.col_BUKN_NM, Me.col_SUURYO, Me.col_SETTI_DT, Me.col_START_DT, Me.col_END_DT, Me.col_CKAIYK_DT, Me.col_KLSRYO, Me.col_KZEI, Me.col_MLSRYO, Me.col_MZEI, Me.col_SHORI_KIND, Me.col_IDO_DT, Me.col_B_BCAT_CD, Me.col_B_BCAT_NM, Me.col_SKMK_CD, Me.col_SKMK_NM, Me.col_BKIND_CD, Me.col_BKIND_NM, Me.col_GSHA_CD, Me.col_GSHA_NM, Me.col_MCPT_CD, Me.col_MCPT_NM, Me.col_RSRVB1_CD, Me.col_RSRVB1_NM, Me.col_ZOKUSEI1, Me.col_ZOKUSEI2, Me.col_ZOKUSEI3, Me.col_ZOKUSEI4, Me.col_HKHO_CD, Me.col_HKHO_NM, Me.col_HK_GSHA_CD, Me.col_HK_GSHA_NM, Me.col_HK_DT, Me.col_HAIFRITU, Me.col_H_KLSRYO, Me.col_H_KZEI, Me.col_H_MLSRYO, Me.col_H_MZEI, Me.col_H_BCAT_CD, Me.col_H_BCAT_NM, Me.col_HKMK_CD, Me.col_HKMK_NM, Me.col_H_ZOKUSEI1})
        Me.dgv_LIST.EnableHeadersVisualStyles = False
        Me.dgv_LIST.Location = New System.Drawing.Point(15, 103)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(1978, 526)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_SHORI
        '
        Me.col_SHORI.HeaderText = "処理内容"
        Me.col_SHORI.MinimumWidth = 8
        Me.col_SHORI.Name = "col_SHORI"
        Me.col_SHORI.Width = 150
        '
        'col_KYKH_NO
        '
        Me.col_KYKH_NO.HeaderText = "K契約No"
        Me.col_KYKH_NO.MinimumWidth = 8
        Me.col_KYKH_NO.Name = "col_KYKH_NO"
        Me.col_KYKH_NO.Width = 150
        '
        'col_KYKM_NO
        '
        Me.col_KYKM_NO.HeaderText = "B物件No"
        Me.col_KYKM_NO.MinimumWidth = 8
        Me.col_KYKM_NO.Name = "col_KYKM_NO"
        Me.col_KYKM_NO.Width = 150
        '
        'col_SAIKAISU
        '
        Me.col_SAIKAISU.HeaderText = "K再リース回数"
        Me.col_SAIKAISU.MinimumWidth = 8
        Me.col_SAIKAISU.Name = "col_SAIKAISU"
        Me.col_SAIKAISU.Width = 150
        '
        'col_LINE_ID
        '
        Me.col_LINE_ID.HeaderText = "A配賦行No"
        Me.col_LINE_ID.MinimumWidth = 8
        Me.col_LINE_ID.Name = "col_LINE_ID"
        Me.col_LINE_ID.Width = 150
        '
        'col_KYKBNL
        '
        Me.col_KYKBNL.HeaderText = "K契約番号"
        Me.col_KYKBNL.MinimumWidth = 8
        Me.col_KYKBNL.Name = "col_KYKBNL"
        Me.col_KYKBNL.Width = 150
        '
        'col_KEDABAN
        '
        Me.col_KEDABAN.HeaderText = "B枝番"
        Me.col_KEDABAN.MinimumWidth = 8
        Me.col_KEDABAN.Name = "col_KEDABAN"
        Me.col_KEDABAN.Width = 150
        '
        'col_BUKN_BANGO1
        '
        Me.col_BUKN_BANGO1.HeaderText = "B資産番号1"
        Me.col_BUKN_BANGO1.MinimumWidth = 8
        Me.col_BUKN_BANGO1.Name = "col_BUKN_BANGO1"
        Me.col_BUKN_BANGO1.Width = 150
        '
        'col_BUKN_BANGO2
        '
        Me.col_BUKN_BANGO2.HeaderText = "B資産番号2"
        Me.col_BUKN_BANGO2.MinimumWidth = 8
        Me.col_BUKN_BANGO2.Name = "col_BUKN_BANGO2"
        Me.col_BUKN_BANGO2.Width = 150
        '
        'col_BUKN_BANGO3
        '
        Me.col_BUKN_BANGO3.HeaderText = "B資産番号3"
        Me.col_BUKN_BANGO3.MinimumWidth = 8
        Me.col_BUKN_BANGO3.Name = "col_BUKN_BANGO3"
        Me.col_BUKN_BANGO3.Width = 150
        '
        'col_BUKN_NM
        '
        Me.col_BUKN_NM.HeaderText = "B物件名"
        Me.col_BUKN_NM.MinimumWidth = 8
        Me.col_BUKN_NM.Name = "col_BUKN_NM"
        Me.col_BUKN_NM.Width = 150
        '
        'col_SUURYO
        '
        Me.col_SUURYO.HeaderText = "B数量"
        Me.col_SUURYO.MinimumWidth = 8
        Me.col_SUURYO.Name = "col_SUURYO"
        Me.col_SUURYO.Width = 150
        '
        'col_SETTI_DT
        '
        Me.col_SETTI_DT.HeaderText = "B設置日"
        Me.col_SETTI_DT.MinimumWidth = 8
        Me.col_SETTI_DT.Name = "col_SETTI_DT"
        Me.col_SETTI_DT.Width = 150
        '
        'col_START_DT
        '
        Me.col_START_DT.HeaderText = "K開始日"
        Me.col_START_DT.MinimumWidth = 8
        Me.col_START_DT.Name = "col_START_DT"
        Me.col_START_DT.Width = 150
        '
        'col_END_DT
        '
        Me.col_END_DT.HeaderText = "K終了日"
        Me.col_END_DT.MinimumWidth = 8
        Me.col_END_DT.Name = "col_END_DT"
        Me.col_END_DT.Width = 150
        '
        'col_CKAIYK_DT
        '
        Me.col_CKAIYK_DT.HeaderText = "B中途解約日"
        Me.col_CKAIYK_DT.MinimumWidth = 8
        Me.col_CKAIYK_DT.Name = "col_CKAIYK_DT"
        Me.col_CKAIYK_DT.Width = 150
        '
        'col_KLSRYO
        '
        Me.col_KLSRYO.HeaderText = "B1支払額"
        Me.col_KLSRYO.MinimumWidth = 8
        Me.col_KLSRYO.Name = "col_KLSRYO"
        Me.col_KLSRYO.Width = 150
        '
        'col_KZEI
        '
        Me.col_KZEI.HeaderText = "B1支払消費税"
        Me.col_KZEI.MinimumWidth = 8
        Me.col_KZEI.Name = "col_KZEI"
        Me.col_KZEI.Width = 150
        '
        'col_MLSRYO
        '
        Me.col_MLSRYO.HeaderText = "B前払"
        Me.col_MLSRYO.MinimumWidth = 8
        Me.col_MLSRYO.Name = "col_MLSRYO"
        Me.col_MLSRYO.Width = 150
        '
        'col_MZEI
        '
        Me.col_MZEI.HeaderText = "B前払消費税"
        Me.col_MZEI.MinimumWidth = 8
        Me.col_MZEI.Name = "col_MZEI"
        Me.col_MZEI.Width = 150
        '
        'col_SHORI_KIND
        '
        Me.col_SHORI_KIND.HeaderText = "B管理部署処理種別"
        Me.col_SHORI_KIND.MinimumWidth = 8
        Me.col_SHORI_KIND.Name = "col_SHORI_KIND"
        Me.col_SHORI_KIND.Width = 150
        '
        'col_IDO_DT
        '
        Me.col_IDO_DT.HeaderText = "B移動日"
        Me.col_IDO_DT.MinimumWidth = 8
        Me.col_IDO_DT.Name = "col_IDO_DT"
        Me.col_IDO_DT.Width = 150
        '
        'col_B_BCAT_CD
        '
        Me.col_B_BCAT_CD.HeaderText = "B管理部署CD"
        Me.col_B_BCAT_CD.MinimumWidth = 8
        Me.col_B_BCAT_CD.Name = "col_B_BCAT_CD"
        Me.col_B_BCAT_CD.Width = 150
        '
        'col_B_BCAT_NM
        '
        Me.col_B_BCAT_NM.HeaderText = "B管理部署"
        Me.col_B_BCAT_NM.MinimumWidth = 8
        Me.col_B_BCAT_NM.Name = "col_B_BCAT_NM"
        Me.col_B_BCAT_NM.Width = 150
        '
        'col_SKMK_CD
        '
        Me.col_SKMK_CD.HeaderText = "B資産区分CD"
        Me.col_SKMK_CD.MinimumWidth = 8
        Me.col_SKMK_CD.Name = "col_SKMK_CD"
        Me.col_SKMK_CD.Width = 150
        '
        'col_SKMK_NM
        '
        Me.col_SKMK_NM.HeaderText = "B資産区分"
        Me.col_SKMK_NM.MinimumWidth = 8
        Me.col_SKMK_NM.Name = "col_SKMK_NM"
        Me.col_SKMK_NM.Width = 150
        '
        'col_BKIND_CD
        '
        Me.col_BKIND_CD.HeaderText = "B物件種別CD"
        Me.col_BKIND_CD.MinimumWidth = 8
        Me.col_BKIND_CD.Name = "col_BKIND_CD"
        Me.col_BKIND_CD.Width = 150
        '
        'col_BKIND_NM
        '
        Me.col_BKIND_NM.HeaderText = "B物件種別"
        Me.col_BKIND_NM.MinimumWidth = 8
        Me.col_BKIND_NM.Name = "col_BKIND_NM"
        Me.col_BKIND_NM.Width = 150
        '
        'col_GSHA_CD
        '
        Me.col_GSHA_CD.HeaderText = "B購入先CD"
        Me.col_GSHA_CD.MinimumWidth = 8
        Me.col_GSHA_CD.Name = "col_GSHA_CD"
        Me.col_GSHA_CD.Width = 150
        '
        'col_GSHA_NM
        '
        Me.col_GSHA_NM.HeaderText = "B購入先"
        Me.col_GSHA_NM.MinimumWidth = 8
        Me.col_GSHA_NM.Name = "col_GSHA_NM"
        Me.col_GSHA_NM.Width = 150
        '
        'col_MCPT_CD
        '
        Me.col_MCPT_CD.HeaderText = "BメーカーCD"
        Me.col_MCPT_CD.MinimumWidth = 8
        Me.col_MCPT_CD.Name = "col_MCPT_CD"
        Me.col_MCPT_CD.Width = 150
        '
        'col_MCPT_NM
        '
        Me.col_MCPT_NM.HeaderText = "Bメーカー"
        Me.col_MCPT_NM.MinimumWidth = 8
        Me.col_MCPT_NM.Name = "col_MCPT_NM"
        Me.col_MCPT_NM.Width = 150
        '
        'col_RSRVB1_CD
        '
        Me.col_RSRVB1_CD.HeaderText = "B物件予備CD"
        Me.col_RSRVB1_CD.MinimumWidth = 8
        Me.col_RSRVB1_CD.Name = "col_RSRVB1_CD"
        Me.col_RSRVB1_CD.Width = 150
        '
        'col_RSRVB1_NM
        '
        Me.col_RSRVB1_NM.HeaderText = "B物件予備"
        Me.col_RSRVB1_NM.MinimumWidth = 8
        Me.col_RSRVB1_NM.Name = "col_RSRVB1_NM"
        Me.col_RSRVB1_NM.Width = 150
        '
        'col_ZOKUSEI1
        '
        Me.col_ZOKUSEI1.HeaderText = "B物件備考1"
        Me.col_ZOKUSEI1.MinimumWidth = 8
        Me.col_ZOKUSEI1.Name = "col_ZOKUSEI1"
        Me.col_ZOKUSEI1.Width = 150
        '
        'col_ZOKUSEI2
        '
        Me.col_ZOKUSEI2.HeaderText = "B物件備考2"
        Me.col_ZOKUSEI2.MinimumWidth = 8
        Me.col_ZOKUSEI2.Name = "col_ZOKUSEI2"
        Me.col_ZOKUSEI2.Width = 150
        '
        'col_ZOKUSEI3
        '
        Me.col_ZOKUSEI3.HeaderText = "B物件備考3"
        Me.col_ZOKUSEI3.MinimumWidth = 8
        Me.col_ZOKUSEI3.Name = "col_ZOKUSEI3"
        Me.col_ZOKUSEI3.Width = 150
        '
        'col_ZOKUSEI4
        '
        Me.col_ZOKUSEI4.HeaderText = "B物件備考4"
        Me.col_ZOKUSEI4.MinimumWidth = 8
        Me.col_ZOKUSEI4.Name = "col_ZOKUSEI4"
        Me.col_ZOKUSEI4.Width = 150
        '
        'col_HKHO_CD
        '
        Me.col_HKHO_CD.HeaderText = "B廃棄方法CD"
        Me.col_HKHO_CD.MinimumWidth = 8
        Me.col_HKHO_CD.Name = "col_HKHO_CD"
        Me.col_HKHO_CD.Width = 150
        '
        'col_HKHO_NM
        '
        Me.col_HKHO_NM.HeaderText = "B廃棄方法"
        Me.col_HKHO_NM.MinimumWidth = 8
        Me.col_HKHO_NM.Name = "col_HKHO_NM"
        Me.col_HKHO_NM.Width = 150
        '
        'col_HK_GSHA_CD
        '
        Me.col_HK_GSHA_CD.HeaderText = "B廃棄業者CD"
        Me.col_HK_GSHA_CD.MinimumWidth = 8
        Me.col_HK_GSHA_CD.Name = "col_HK_GSHA_CD"
        Me.col_HK_GSHA_CD.Width = 150
        '
        'col_HK_GSHA_NM
        '
        Me.col_HK_GSHA_NM.HeaderText = "B廃棄業者"
        Me.col_HK_GSHA_NM.MinimumWidth = 8
        Me.col_HK_GSHA_NM.Name = "col_HK_GSHA_NM"
        Me.col_HK_GSHA_NM.Width = 150
        '
        'col_HK_DT
        '
        Me.col_HK_DT.HeaderText = "B廃棄日"
        Me.col_HK_DT.MinimumWidth = 8
        Me.col_HK_DT.Name = "col_HK_DT"
        Me.col_HK_DT.Width = 150
        '
        'col_HAIFRITU
        '
        Me.col_HAIFRITU.HeaderText = "A配賦率"
        Me.col_HAIFRITU.MinimumWidth = 8
        Me.col_HAIFRITU.Name = "col_HAIFRITU"
        Me.col_HAIFRITU.Width = 150
        '
        'col_H_KLSRYO
        '
        Me.col_H_KLSRYO.HeaderText = "A1支払額"
        Me.col_H_KLSRYO.MinimumWidth = 8
        Me.col_H_KLSRYO.Name = "col_H_KLSRYO"
        Me.col_H_KLSRYO.Width = 150
        '
        'col_H_KZEI
        '
        Me.col_H_KZEI.HeaderText = "A1支払消費税"
        Me.col_H_KZEI.MinimumWidth = 8
        Me.col_H_KZEI.Name = "col_H_KZEI"
        Me.col_H_KZEI.Width = 150
        '
        'col_H_MLSRYO
        '
        Me.col_H_MLSRYO.HeaderText = "A前払"
        Me.col_H_MLSRYO.MinimumWidth = 8
        Me.col_H_MLSRYO.Name = "col_H_MLSRYO"
        Me.col_H_MLSRYO.Width = 150
        '
        'col_H_MZEI
        '
        Me.col_H_MZEI.HeaderText = "A前払消費税"
        Me.col_H_MZEI.MinimumWidth = 8
        Me.col_H_MZEI.Name = "col_H_MZEI"
        Me.col_H_MZEI.Width = 150
        '
        'col_H_BCAT_CD
        '
        Me.col_H_BCAT_CD.HeaderText = "A費用負担部署CD"
        Me.col_H_BCAT_CD.MinimumWidth = 8
        Me.col_H_BCAT_CD.Name = "col_H_BCAT_CD"
        Me.col_H_BCAT_CD.Width = 150
        '
        'col_H_BCAT_NM
        '
        Me.col_H_BCAT_NM.HeaderText = "A費用負担部署"
        Me.col_H_BCAT_NM.MinimumWidth = 8
        Me.col_H_BCAT_NM.Name = "col_H_BCAT_NM"
        Me.col_H_BCAT_NM.Width = 150
        '
        'col_HKMK_CD
        '
        Me.col_HKMK_CD.HeaderText = "A費用区分CD"
        Me.col_HKMK_CD.MinimumWidth = 8
        Me.col_HKMK_CD.Name = "col_HKMK_CD"
        Me.col_HKMK_CD.Width = 150
        '
        'col_HKMK_NM
        '
        Me.col_HKMK_NM.HeaderText = "A費用区分"
        Me.col_HKMK_NM.MinimumWidth = 8
        Me.col_HKMK_NM.Name = "col_HKMK_NM"
        Me.col_HKMK_NM.Width = 150
        '
        'col_H_ZOKUSEI1
        '
        Me.col_H_ZOKUSEI1.HeaderText = "A配賦備考"
        Me.col_H_ZOKUSEI1.MinimumWidth = 8
        Me.col_H_ZOKUSEI1.Name = "col_H_ZOKUSEI1"
        Me.col_H_ZOKUSEI1.Width = 150
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 659)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "変更対象項目"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 659)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "キー項目"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Yellow
        Me.TextBox2.Location = New System.Drawing.Point(337, 656)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(74, 25)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(149, 656)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 25)
        Me.TextBox1.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 707)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "・「A配賦行No」が１の行の物件項目(*)を物件変更に使用します。"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 734)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1659, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "(*)B枝番,B資産番号1～3,B物件名,B数量,B設置日,B管理部署処理種別,B移動日,B管理部署CD,B資産区分CD,B物件種別CD,B購入先CD,Bメーカー" &
    "CD,B物件予備CD,B物件備考1～4,B廃棄方法CD,B廃棄業者CD,B廃棄日"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 775)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "・配賦行を追加する場合の注意事項"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 802)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(891, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "①「K契約No」「B物件No」「K再リース回数」を既存行と同じ西、「A配賦行No」に既存行の最大値+1からの連番をセットする。"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(160, 829)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(878, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "②同一物件(*)の「A配賦率」の物件単位合計を100とする。(*)「B物件No」「K再リース回数」が同じ行を同一物件とみなす。"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(146, 865)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(794, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "・「B管理部署処理種別」を'変更前情報を残す'とした場合、変更前管理部署が旧・管理部署に記録されます。"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "処理内容"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "K契約No"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "B物件No"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "K再リース回数"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "A配賦行No"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "K契約番号"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "B枝番"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "B資産番号1"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "B資産番号2"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "B資産番号3"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "B物件名"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "B数量"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "B設置日"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "K開始日"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "K終了日"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "B中途解約日"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "B1支払額"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "B1支払消費税"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 150
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "B前払"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 150
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "B前払消費税"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "B管理部署処理種別"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 150
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "B移動日"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 150
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "B管理部署CD"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 150
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "B管理部署"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 150
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "B資産区分CD"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 150
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "B資産区分"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 150
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "B物件種別CD"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 150
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "B物件種別"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 150
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "B購入先CD"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 150
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "B購入先"
        Me.DataGridViewTextBoxColumn30.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 150
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "BメーカーCD"
        Me.DataGridViewTextBoxColumn31.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 150
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "Bメーカー"
        Me.DataGridViewTextBoxColumn32.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Width = 150
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "B物件予備CD"
        Me.DataGridViewTextBoxColumn33.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Width = 150
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "B物件予備"
        Me.DataGridViewTextBoxColumn34.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 150
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.HeaderText = "B物件備考1"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 150
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.HeaderText = "B物件備考2"
        Me.DataGridViewTextBoxColumn36.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Width = 150
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.HeaderText = "B物件備考3"
        Me.DataGridViewTextBoxColumn37.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 150
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.HeaderText = "B物件備考4"
        Me.DataGridViewTextBoxColumn38.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Width = 150
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.HeaderText = "B廃棄方法CD"
        Me.DataGridViewTextBoxColumn39.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Width = 150
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.HeaderText = "B廃棄方法"
        Me.DataGridViewTextBoxColumn40.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Width = 150
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.HeaderText = "B廃棄業者CD"
        Me.DataGridViewTextBoxColumn41.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 150
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.HeaderText = "B廃棄業者"
        Me.DataGridViewTextBoxColumn42.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 150
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.HeaderText = "B廃棄日"
        Me.DataGridViewTextBoxColumn43.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 150
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.HeaderText = "A配賦率"
        Me.DataGridViewTextBoxColumn44.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 150
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.HeaderText = "A1支払額"
        Me.DataGridViewTextBoxColumn45.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 150
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.HeaderText = "A1支払消費税"
        Me.DataGridViewTextBoxColumn46.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 150
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.HeaderText = "A前払"
        Me.DataGridViewTextBoxColumn47.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 150
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.HeaderText = "A前払消費税"
        Me.DataGridViewTextBoxColumn48.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Width = 150
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.HeaderText = "A費用負担部署CD"
        Me.DataGridViewTextBoxColumn49.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 150
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.HeaderText = "A費用負担部署"
        Me.DataGridViewTextBoxColumn50.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 150
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.HeaderText = "A費用区分CD"
        Me.DataGridViewTextBoxColumn51.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.Width = 150
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.HeaderText = "A費用区分"
        Me.DataGridViewTextBoxColumn52.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Width = 150
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.HeaderText = "A配賦備考"
        Me.DataGridViewTextBoxColumn53.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.Width = 150
        '
        'Form_f_IMPORT_IDO_FROM_EXCEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2005, 915)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_PRE_CREATE)
        Me.Controls.Add(Me.cmd_INPUT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.KeyPreview = True
        Me.Name = "Form_f_IMPORT_IDO_FROM_EXCEL"
        Me.Text = "物件移動情報取り込み"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_CREATE As Button
    Friend WithEvents cmd_PRE_CREATE As Button
    Friend WithEvents cmd_INPUT As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents col_SHORI As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKH_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_SAIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents col_LINE_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents col_KEDABAN As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_BANGO1 As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_BANGO2 As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_BANGO3 As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_SUURYO As DataGridViewTextBoxColumn
    Friend WithEvents col_SETTI_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_END_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_CKAIYK_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_KZEI As DataGridViewTextBoxColumn
    Friend WithEvents col_MLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_MZEI As DataGridViewTextBoxColumn
    Friend WithEvents col_SHORI_KIND As DataGridViewTextBoxColumn
    Friend WithEvents col_IDO_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_B_BCAT_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_B_BCAT_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_SKMK_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_SKMK_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_BKIND_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_BKIND_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_GSHA_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_GSHA_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_MCPT_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_MCPT_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_RSRVB1_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_RSRVB1_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_ZOKUSEI1 As DataGridViewTextBoxColumn
    Friend WithEvents col_ZOKUSEI2 As DataGridViewTextBoxColumn
    Friend WithEvents col_ZOKUSEI3 As DataGridViewTextBoxColumn
    Friend WithEvents col_ZOKUSEI4 As DataGridViewTextBoxColumn
    Friend WithEvents col_HKHO_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_HKHO_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_HK_GSHA_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_HK_GSHA_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_HK_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_HAIFRITU As DataGridViewTextBoxColumn
    Friend WithEvents col_H_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_H_KZEI As DataGridViewTextBoxColumn
    Friend WithEvents col_H_MLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_H_MZEI As DataGridViewTextBoxColumn
    Friend WithEvents col_H_BCAT_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_H_BCAT_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_HKMK_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_HKMK_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_H_ZOKUSEI1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
End Class
