<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_flx_TOUGETSU
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
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txt_SEARCH = New System.Windows.Forms.TextBox()
        Me.cmd_SEARCH = New System.Windows.Forms.Button()
        Me.lbl_CONDITION = New System.Windows.Forms.Label()
        Me.cmd_OUTPUT_FILE = New System.Windows.Forms.Button()
        Me.cmd_FlexReportDLG = New System.Windows.Forms.Button()
        Me.cmd_支払照合 = New System.Windows.Forms.Button()
        Me.cmd_REF = New System.Windows.Forms.Button()
        Me.cmd_RECALCULATE = New System.Windows.Forms.Button()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.dgv_LIST = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(1094, 55)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(148, 18)
        Me.lblSearch.TabIndex = 34
        Me.lblSearch.Text = "検索(契約番号等):"
        '
        'txt_SEARCH
        '
        Me.txt_SEARCH.AllowDrop = True
        Me.txt_SEARCH.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_SEARCH.Location = New System.Drawing.Point(1274, 47)
        Me.txt_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_SEARCH.Name = "txt_SEARCH"
        Me.txt_SEARCH.Size = New System.Drawing.Size(331, 29)
        Me.txt_SEARCH.TabIndex = 1
        '
        'cmd_SEARCH
        '
        Me.cmd_SEARCH.AllowDrop = True
        Me.cmd_SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmd_SEARCH.Location = New System.Drawing.Point(1618, 39)
        Me.cmd_SEARCH.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_SEARCH.Name = "cmd_SEARCH"
        Me.cmd_SEARCH.Size = New System.Drawing.Size(167, 51)
        Me.cmd_SEARCH.TabIndex = 2
        Me.cmd_SEARCH.Text = "検索(&S)"
        Me.cmd_SEARCH.UseVisualStyleBackColor = False
        '
        'lbl_CONDITION
        '
        Me.lbl_CONDITION.AutoSize = True
        Me.lbl_CONDITION.Location = New System.Drawing.Point(12, 80)
        Me.lbl_CONDITION.Name = "lbl_CONDITION"
        Me.lbl_CONDITION.Size = New System.Drawing.Size(84, 18)
        Me.lbl_CONDITION.TabIndex = 31
        Me.lbl_CONDITION.Text = "集計期間:"
        '
        'cmd_OUTPUT_FILE
        '
        Me.cmd_OUTPUT_FILE.Location = New System.Drawing.Point(831, 13)
        Me.cmd_OUTPUT_FILE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_OUTPUT_FILE.Name = "cmd_OUTPUT_FILE"
        Me.cmd_OUTPUT_FILE.Size = New System.Drawing.Size(153, 45)
        Me.cmd_OUTPUT_FILE.TabIndex = 30
        Me.cmd_OUTPUT_FILE.TabStop = False
        Me.cmd_OUTPUT_FILE.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_OUTPUT_FILE.UseVisualStyleBackColor = True
        '
        'cmd_FlexReportDLG
        '
        Me.cmd_FlexReportDLG.Location = New System.Drawing.Point(668, 13)
        Me.cmd_FlexReportDLG.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_FlexReportDLG.Name = "cmd_FlexReportDLG"
        Me.cmd_FlexReportDLG.Size = New System.Drawing.Size(153, 45)
        Me.cmd_FlexReportDLG.TabIndex = 29
        Me.cmd_FlexReportDLG.TabStop = False
        Me.cmd_FlexReportDLG.Text = "印刷(&R)"
        Me.cmd_FlexReportDLG.UseVisualStyleBackColor = True
        '
        'cmd_支払照合
        '
        Me.cmd_支払照合.Location = New System.Drawing.Point(505, 13)
        Me.cmd_支払照合.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_支払照合.Name = "cmd_支払照合"
        Me.cmd_支払照合.Size = New System.Drawing.Size(153, 45)
        Me.cmd_支払照合.TabIndex = 28
        Me.cmd_支払照合.TabStop = False
        Me.cmd_支払照合.Text = "支払照合(&P)"
        Me.cmd_支払照合.UseVisualStyleBackColor = True
        '
        'cmd_REF
        '
        Me.cmd_REF.Location = New System.Drawing.Point(342, 13)
        Me.cmd_REF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_REF.Name = "cmd_REF"
        Me.cmd_REF.Size = New System.Drawing.Size(153, 45)
        Me.cmd_REF.TabIndex = 27
        Me.cmd_REF.TabStop = False
        Me.cmd_REF.Text = "照会(&M)"
        Me.cmd_REF.UseVisualStyleBackColor = True
        '
        'cmd_RECALCULATE
        '
        Me.cmd_RECALCULATE.Location = New System.Drawing.Point(178, 13)
        Me.cmd_RECALCULATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_RECALCULATE.Name = "cmd_RECALCULATE"
        Me.cmd_RECALCULATE.Size = New System.Drawing.Size(154, 45)
        Me.cmd_RECALCULATE.TabIndex = 26
        Me.cmd_RECALCULATE.TabStop = False
        Me.cmd_RECALCULATE.Text = "再計算(&D)"
        Me.cmd_RECALCULATE.UseVisualStyleBackColor = True
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(154, 45)
        Me.cmd_CLOSE.TabIndex = 25
        Me.cmd_CLOSE.TabStop = False
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'dgv_LIST
        '
        Me.dgv_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_LIST.Location = New System.Drawing.Point(15, 145)
        Me.dgv_LIST.Name = "dgv_LIST"
        Me.dgv_LIST.RowHeadersWidth = 62
        Me.dgv_LIST.RowTemplate.Height = 27
        Me.dgv_LIST.Size = New System.Drawing.Size(2253, 652)
        Me.dgv_LIST.TabIndex = 0
        '
        'Form_f_flx_MONTHLY_JOURNAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2280, 809)
        Me.Controls.Add(Me.dgv_LIST)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txt_SEARCH)
        Me.Controls.Add(Me.cmd_SEARCH)
        Me.Controls.Add(Me.lbl_CONDITION)
        Me.Controls.Add(Me.cmd_OUTPUT_FILE)
        Me.Controls.Add(Me.cmd_FlexReportDLG)
        Me.Controls.Add(Me.cmd_支払照合)
        Me.Controls.Add(Me.cmd_REF)
        Me.Controls.Add(Me.cmd_RECALCULATE)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_MONTHLY_JOURNAL"
        Me.Text = "Form_f_flx_MONTHLY_JOURNAL"
        CType(Me.dgv_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txt_SEARCH As TextBox
    Friend WithEvents cmd_SEARCH As Button
    Friend WithEvents lbl_CONDITION As Label
    Friend WithEvents cmd_OUTPUT_FILE As Button
    Friend WithEvents cmd_FlexReportDLG As Button
    Friend WithEvents cmd_支払照合 As Button
    Friend WithEvents cmd_REF As Button
    Friend WithEvents cmd_RECALCULATE As Button
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents dgv_LIST As DataGridView
End Class
