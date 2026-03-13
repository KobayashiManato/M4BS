<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_JournalEntry
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
        Me.dtpProcessDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvJournal = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDebitAcct = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colDebitAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreditAcct = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colCreditAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpProcessDate
        '
        Me.dtpProcessDate.Location = New System.Drawing.Point(30, 51)
        Me.dtpProcessDate.Name = "dtpProcessDate"
        Me.dtpProcessDate.Size = New System.Drawing.Size(200, 19)
        Me.dtpProcessDate.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(293, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(427, 47)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvJournal
        '
        Me.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colDate, Me.colDebitAcct, Me.colDebitAmt, Me.colCreditAcct, Me.colCreditAmt, Me.colDesc})
        Me.dgvJournal.Location = New System.Drawing.Point(30, 133)
        Me.dgvJournal.Name = "dgvJournal"
        Me.dgvJournal.RowTemplate.Height = 21
        Me.dgvJournal.Size = New System.Drawing.Size(472, 250)
        Me.dgvJournal.TabIndex = 3
        '
        'colId
        '
        Me.colId.DataPropertyName = "shwak_id"
        Me.colId.HeaderText = "ID"
        Me.colId.Name = "colId"
        Me.colId.Visible = False
        '
        'colDate
        '
        Me.colDate.DataPropertyName = "process_date"
        Me.colDate.HeaderText = "日付"
        Me.colDate.Name = "colDate"
        '
        'colDebitAcct
        '
        Me.colDebitAcct.DataPropertyName = "debit_acct_cd"
        Me.colDebitAcct.HeaderText = "借方科目"
        Me.colDebitAcct.Name = "colDebitAcct"
        '
        'colDebitAmt
        '
        Me.colDebitAmt.DataPropertyName = "debit_amount"
        Me.colDebitAmt.HeaderText = "借方金額"
        Me.colDebitAmt.Name = "colDebitAmt"
        '
        'colCreditAcct
        '
        Me.colCreditAcct.DataPropertyName = "credit_acct_cd"
        Me.colCreditAcct.HeaderText = "貸方科目"
        Me.colCreditAcct.Name = "colCreditAcct"
        '
        'colCreditAmt
        '
        Me.colCreditAmt.DataPropertyName = "credit_amount"
        Me.colCreditAmt.HeaderText = "貸方金額"
        Me.colCreditAmt.Name = "colCreditAmt"
        '
        'colDesc
        '
        Me.colDesc.DataPropertyName = "description"
        Me.colDesc.HeaderText = "摘要"
        Me.colDesc.Name = "colDesc"
        '
        'FrmJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvJournal)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dtpProcessDate)
        Me.Name = "FrmJournalEntry"
        Me.Text = "FrmJournalEntry"
        CType(Me.dgvJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpProcessDate As DateTimePicker
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvJournal As DataGridView
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colDebitAcct As DataGridViewComboBoxColumn
    Friend WithEvents colDebitAmt As DataGridViewTextBoxColumn
    Friend WithEvents colCreditAcct As DataGridViewComboBoxColumn
    Friend WithEvents colCreditAmt As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
End Class
