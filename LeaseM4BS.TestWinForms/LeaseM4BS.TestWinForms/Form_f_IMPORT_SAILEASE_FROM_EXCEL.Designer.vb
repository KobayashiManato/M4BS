<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_IMPORT_SAILEASE_FROM_EXCEL
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_ZENKAI = New System.Windows.Forms.Button()
        Me.cmd_INPUT = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        Me.col_KKBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKH_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKM_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKM_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SAI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYKBNL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_KYAK_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_START_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LKIKAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_END_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SAIKAISU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHRI_KN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHRI_DT1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHRI_DT2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHRI_DT3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_SHRI_EN_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ZRITU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_K_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_K_KZEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_K_SLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_K_IJIKNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_KLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_KZEI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_SLSRYO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_IJIKNR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_LCPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_BUKN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_BCAT_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_B_BCAT_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(534, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(176, 39)
        Me.cmd_CREATE.TabIndex = 3
        Me.cmd_CREATE.TabStop = False
        Me.cmd_CREATE.Text = "本登録(&A)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_ZENKAI
        '
        Me.cmd_ZENKAI.Location = New System.Drawing.Point(720, 13)
        Me.cmd_ZENKAI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_ZENKAI.Name = "cmd_ZENKAI"
        Me.cmd_ZENKAI.Size = New System.Drawing.Size(176, 39)
        Me.cmd_ZENKAI.TabIndex = 4
        Me.cmd_ZENKAI.TabStop = False
        Me.cmd_ZENKAI.Text = "前回本登録ログ(&L)"
        Me.cmd_ZENKAI.UseVisualStyleBackColor = True
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
        Me.dgv_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_KKBN, Me.col_KYKH_NO, Me.col_KYKM_ID, Me.col_KYKM_NO, Me.col_SAI, Me.col_KYKBNL, Me.col_KYAK_DT, Me.col_START_DT, Me.col_LKIKAN, Me.col_END_DT, Me.col_SAIKAISU, Me.col_SHRI_KN, Me.col_SHRI_DT1, Me.col_SHRI_DT2, Me.col_SHRI_DT3, Me.col_SHRI_EN_DT, Me.col_ZRITU, Me.col_K_KLSRYO, Me.col_K_KZEI, Me.col_K_SLSRYO, Me.col_K_IJIKNR, Me.col_B_KLSRYO, Me.col_B_KZEI, Me.col_B_SLSRYO, Me.col_B_IJIKNR, Me.col_LCPT, Me.col_BUKN_NM, Me.col_B_BCAT_CD, Me.col_B_BCAT_NM})
        Me.dgv_LIST.EnableHeadersVisualStyles = False
        Me.dgv_LIST.Location = New System.Drawing.Point(14, 100)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(1978, 526)
        Me.dgv_LIST.TabIndex = 0
        '
        'col_KKBN
        '
        Me.col_KKBN.HeaderText = "K契約区分"
        Me.col_KKBN.MinimumWidth = 8
        Me.col_KKBN.Name = "col_KKBN"
        Me.col_KKBN.Width = 150
        '
        'col_KYKH_NO
        '
        Me.col_KYKH_NO.HeaderText = "K契約No"
        Me.col_KYKH_NO.MinimumWidth = 8
        Me.col_KYKH_NO.Name = "col_KYKH_NO"
        Me.col_KYKH_NO.Width = 150
        '
        'col_KYKM_ID
        '
        Me.col_KYKM_ID.HeaderText = "B契約内連番"
        Me.col_KYKM_ID.MinimumWidth = 8
        Me.col_KYKM_ID.Name = "col_KYKM_ID"
        Me.col_KYKM_ID.Width = 150
        '
        'col_KYKM_NO
        '
        Me.col_KYKM_NO.HeaderText = "B物件No"
        Me.col_KYKM_NO.MinimumWidth = 8
        Me.col_KYKM_NO.Name = "col_KYKM_NO"
        Me.col_KYKM_NO.Width = 150
        '
        'col_SAI
        '
        Me.col_SAI.HeaderText = "B更新解約"
        Me.col_SAI.MinimumWidth = 8
        Me.col_SAI.Name = "col_SAI"
        Me.col_SAI.Width = 150
        '
        'col_KYKBNL
        '
        Me.col_KYKBNL.HeaderText = "K契約番号"
        Me.col_KYKBNL.MinimumWidth = 8
        Me.col_KYKBNL.Name = "col_KYKBNL"
        Me.col_KYKBNL.Width = 150
        '
        'col_KYAK_DT
        '
        Me.col_KYAK_DT.HeaderText = "K契約日"
        Me.col_KYAK_DT.MinimumWidth = 8
        Me.col_KYAK_DT.Name = "col_KYAK_DT"
        Me.col_KYAK_DT.Width = 150
        '
        'col_START_DT
        '
        Me.col_START_DT.HeaderText = "K開始日"
        Me.col_START_DT.MinimumWidth = 8
        Me.col_START_DT.Name = "col_START_DT"
        Me.col_START_DT.Width = 150
        '
        'col_LKIKAN
        '
        Me.col_LKIKAN.HeaderText = "K契約期間"
        Me.col_LKIKAN.MinimumWidth = 8
        Me.col_LKIKAN.Name = "col_LKIKAN"
        Me.col_LKIKAN.Width = 150
        '
        'col_END_DT
        '
        Me.col_END_DT.HeaderText = "K終了日"
        Me.col_END_DT.MinimumWidth = 8
        Me.col_END_DT.Name = "col_END_DT"
        Me.col_END_DT.Width = 150
        '
        'col_SAIKAISU
        '
        Me.col_SAIKAISU.HeaderText = "K再リース回数"
        Me.col_SAIKAISU.MinimumWidth = 8
        Me.col_SAIKAISU.Name = "col_SAIKAISU"
        Me.col_SAIKAISU.Width = 150
        '
        'col_SHRI_KN
        '
        Me.col_SHRI_KN.HeaderText = "K支払間隔"
        Me.col_SHRI_KN.MinimumWidth = 8
        Me.col_SHRI_KN.Name = "col_SHRI_KN"
        Me.col_SHRI_KN.Width = 150
        '
        'col_SHRI_DT1
        '
        Me.col_SHRI_DT1.HeaderText = "K第1回支払日"
        Me.col_SHRI_DT1.MinimumWidth = 8
        Me.col_SHRI_DT1.Name = "col_SHRI_DT1"
        Me.col_SHRI_DT1.Width = 150
        '
        'col_SHRI_DT2
        '
        Me.col_SHRI_DT2.HeaderText = "K第2回支払日"
        Me.col_SHRI_DT2.MinimumWidth = 8
        Me.col_SHRI_DT2.Name = "col_SHRI_DT2"
        Me.col_SHRI_DT2.Width = 150
        '
        'col_SHRI_DT3
        '
        Me.col_SHRI_DT3.HeaderText = "K第3回以降支払日"
        Me.col_SHRI_DT3.MinimumWidth = 8
        Me.col_SHRI_DT3.Name = "col_SHRI_DT3"
        Me.col_SHRI_DT3.Width = 150
        '
        'col_SHRI_EN_DT
        '
        Me.col_SHRI_EN_DT.HeaderText = "K最終支払日"
        Me.col_SHRI_EN_DT.MinimumWidth = 8
        Me.col_SHRI_EN_DT.Name = "col_SHRI_EN_DT"
        Me.col_SHRI_EN_DT.Width = 150
        '
        'col_ZRITU
        '
        Me.col_ZRITU.HeaderText = "K消費税率"
        Me.col_ZRITU.MinimumWidth = 8
        Me.col_ZRITU.Name = "col_ZRITU"
        Me.col_ZRITU.Width = 150
        '
        'col_K_KLSRYO
        '
        Me.col_K_KLSRYO.HeaderText = "K1支払額"
        Me.col_K_KLSRYO.MinimumWidth = 8
        Me.col_K_KLSRYO.Name = "col_K_KLSRYO"
        Me.col_K_KLSRYO.Width = 150
        '
        'col_K_KZEI
        '
        Me.col_K_KZEI.HeaderText = "K1支払額消費税"
        Me.col_K_KZEI.MinimumWidth = 8
        Me.col_K_KZEI.Name = "col_K_KZEI"
        Me.col_K_KZEI.Width = 150
        '
        'col_K_SLSRYO
        '
        Me.col_K_SLSRYO.HeaderText = "K総額リース料"
        Me.col_K_SLSRYO.MinimumWidth = 8
        Me.col_K_SLSRYO.Name = "col_K_SLSRYO"
        Me.col_K_SLSRYO.Width = 150
        '
        'col_K_IJIKNR
        '
        Me.col_K_IJIKNR.HeaderText = "K維持管理費用"
        Me.col_K_IJIKNR.MinimumWidth = 8
        Me.col_K_IJIKNR.Name = "col_K_IJIKNR"
        Me.col_K_IJIKNR.Width = 150
        '
        'col_B_KLSRYO
        '
        Me.col_B_KLSRYO.HeaderText = "B1支払額"
        Me.col_B_KLSRYO.MinimumWidth = 8
        Me.col_B_KLSRYO.Name = "col_B_KLSRYO"
        Me.col_B_KLSRYO.Width = 150
        '
        'col_B_KZEI
        '
        Me.col_B_KZEI.HeaderText = "B1支払額消費税"
        Me.col_B_KZEI.MinimumWidth = 8
        Me.col_B_KZEI.Name = "col_B_KZEI"
        Me.col_B_KZEI.Width = 150
        '
        'col_B_SLSRYO
        '
        Me.col_B_SLSRYO.HeaderText = "B総額リース料"
        Me.col_B_SLSRYO.MinimumWidth = 8
        Me.col_B_SLSRYO.Name = "col_B_SLSRYO"
        Me.col_B_SLSRYO.Width = 150
        '
        'col_B_IJIKNR
        '
        Me.col_B_IJIKNR.HeaderText = "B維持管理費用"
        Me.col_B_IJIKNR.MinimumWidth = 8
        Me.col_B_IJIKNR.Name = "col_B_IJIKNR"
        Me.col_B_IJIKNR.Width = 150
        '
        'col_LCPT
        '
        Me.col_LCPT.HeaderText = "K支払先"
        Me.col_LCPT.MinimumWidth = 8
        Me.col_LCPT.Name = "col_LCPT"
        Me.col_LCPT.Width = 150
        '
        'col_BUKN_NM
        '
        Me.col_BUKN_NM.HeaderText = "B物件名"
        Me.col_BUKN_NM.MinimumWidth = 8
        Me.col_BUKN_NM.Name = "col_BUKN_NM"
        Me.col_BUKN_NM.Width = 150
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "K契約区分"
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
        Me.DataGridViewTextBoxColumn3.HeaderText = "B契約内連番"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "B物件No"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "B更新解約"
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
        Me.DataGridViewTextBoxColumn7.HeaderText = "K契約日"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "K開始日"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "K契約期間"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "K終了日"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "K再リース回数"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "K支払間隔"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "K第1回支払日"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 150
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "K第2回支払日"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "K第3回以降支払日"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 150
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "K最終支払日"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "K消費税率"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "K1支払額"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 150
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "K1支払額消費税"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 150
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "K総額リース料"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 150
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "K維持管理費用"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 150
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "B1支払額"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 150
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "B1支払額消費税"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 150
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "B総額リース料"
        Me.DataGridViewTextBoxColumn24.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 150
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "B維持管理費用"
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 150
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "K支払先"
        Me.DataGridViewTextBoxColumn26.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 150
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "B物件名"
        Me.DataGridViewTextBoxColumn27.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 150
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "B管理部署CD"
        Me.DataGridViewTextBoxColumn28.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 150
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "B管理部署"
        Me.DataGridViewTextBoxColumn29.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 150
        '
        'Form_f_IMPORT_SAILEASE_FROM_EXCEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2003, 795)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_ZENKAI)
        Me.Controls.Add(Me.cmd_INPUT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.KeyPreview = True
        Me.Name = "Form_f_IMPORT_SAILEASE_FROM_EXCEL"
        Me.Text = "一括再リース/返却"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_CREATE As Button
    Friend WithEvents cmd_ZENKAI As Button
    Friend WithEvents cmd_INPUT As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents dgv_LIST As DataGridView
    Friend WithEvents col_KKBN As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKH_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKM_ID As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKM_NO As DataGridViewTextBoxColumn
    Friend WithEvents col_SAI As DataGridViewTextBoxColumn
    Friend WithEvents col_KYKBNL As DataGridViewTextBoxColumn
    Friend WithEvents col_KYAK_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_START_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_LKIKAN As DataGridViewTextBoxColumn
    Friend WithEvents col_END_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_SAIKAISU As DataGridViewTextBoxColumn
    Friend WithEvents col_SHRI_KN As DataGridViewTextBoxColumn
    Friend WithEvents col_SHRI_DT1 As DataGridViewTextBoxColumn
    Friend WithEvents col_SHRI_DT2 As DataGridViewTextBoxColumn
    Friend WithEvents col_SHRI_DT3 As DataGridViewTextBoxColumn
    Friend WithEvents col_SHRI_EN_DT As DataGridViewTextBoxColumn
    Friend WithEvents col_ZRITU As DataGridViewTextBoxColumn
    Friend WithEvents col_K_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_K_KZEI As DataGridViewTextBoxColumn
    Friend WithEvents col_K_SLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_K_IJIKNR As DataGridViewTextBoxColumn
    Friend WithEvents col_B_KLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_B_KZEI As DataGridViewTextBoxColumn
    Friend WithEvents col_B_SLSRYO As DataGridViewTextBoxColumn
    Friend WithEvents col_B_IJIKNR As DataGridViewTextBoxColumn
    Friend WithEvents col_LCPT As DataGridViewTextBoxColumn
    Friend WithEvents col_BUKN_NM As DataGridViewTextBoxColumn
    Friend WithEvents col_B_BCAT_CD As DataGridViewTextBoxColumn
    Friend WithEvents col_B_BCAT_NM As DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
End Class
