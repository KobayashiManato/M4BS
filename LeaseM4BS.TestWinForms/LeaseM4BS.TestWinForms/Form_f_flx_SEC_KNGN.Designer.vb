<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_SEC_KNGN

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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_新規 = New System.Windows.Forms.Button()
        Me.cmd_ADMIN = New System.Windows.Forms.Button()
        Me.cmd_MASTER_UPDATE = New System.Windows.Forms.Button()
        Me.cmd_APPROVAL = New System.Windows.Forms.Button()
        Me.cmd_FILE_OUTPUT = New System.Windows.Forms.Button()
        Me.cmd_PRINT = New System.Windows.Forms.Button()
        Me.cmd_LOG_REF = New System.Windows.Forms.Button()
        Me.cmd_変更 = New System.Windows.Forms.Button()
        Me.cmd_再表示 = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_KNGN_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KNGN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ACCESS_KIND_STR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CREATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_UPDATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KNGN_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ACCESS_KIND_B_STR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.cmd_Output)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexSortDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_FlexSearchDLG)
        Me.pnlHeader.Controls.Add(Me.cmd_再表示)
        Me.pnlHeader.Controls.Add(Me.cmd_変更)
        Me.pnlHeader.Controls.Add(Me.cmd_LOG_REF)
        Me.pnlHeader.Controls.Add(Me.cmd_PRINT)
        Me.pnlHeader.Controls.Add(Me.cmd_FILE_OUTPUT)
        Me.pnlHeader.Controls.Add(Me.cmd_APPROVAL)
        Me.pnlHeader.Controls.Add(Me.cmd_MASTER_UPDATE)
        Me.pnlHeader.Controls.Add(Me.cmd_ADMIN)
        Me.pnlHeader.Controls.Add(Me.cmd_新規)
        Me.pnlHeader.Controls.Add(Me.cmd_閉じる)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 40)
        Me.pnlHeader.TabIndex = 0
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(4, 4)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(104, 30)
        Me.cmd_閉じる.TabIndex = 0
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_新規
        '
        Me.cmd_新規.Location = New System.Drawing.Point(116, 4)
        Me.cmd_新規.Name = "cmd_新規"
        Me.cmd_新規.Size = New System.Drawing.Size(92, 30)
        Me.cmd_新規.TabIndex = 1
        Me.cmd_新規.Text = "新規(&N)"
        Me.cmd_新規.UseVisualStyleBackColor = True
        '
        ' cmd_ADMIN
        '
        Me.cmd_ADMIN.Location = New System.Drawing.Point(216, 4)
        Me.cmd_ADMIN.Name = "cmd_ADMIN"
        Me.cmd_ADMIN.Size = New System.Drawing.Size(75, 30)
        Me.cmd_ADMIN.TabIndex = 2
        Me.cmd_ADMIN.Text = " "
        Me.cmd_ADMIN.UseVisualStyleBackColor = True
        '
        ' cmd_MASTER_UPDATE
        '
        Me.cmd_MASTER_UPDATE.Location = New System.Drawing.Point(299, 4)
        Me.cmd_MASTER_UPDATE.Name = "cmd_MASTER_UPDATE"
        Me.cmd_MASTER_UPDATE.Size = New System.Drawing.Size(75, 30)
        Me.cmd_MASTER_UPDATE.TabIndex = 3
        Me.cmd_MASTER_UPDATE.Text = " "
        Me.cmd_MASTER_UPDATE.UseVisualStyleBackColor = True
        '
        ' cmd_APPROVAL
        '
        Me.cmd_APPROVAL.Location = New System.Drawing.Point(382, 4)
        Me.cmd_APPROVAL.Name = "cmd_APPROVAL"
        Me.cmd_APPROVAL.Size = New System.Drawing.Size(75, 30)
        Me.cmd_APPROVAL.TabIndex = 4
        Me.cmd_APPROVAL.Text = " "
        Me.cmd_APPROVAL.UseVisualStyleBackColor = True
        '
        ' cmd_FILE_OUTPUT
        '
        Me.cmd_FILE_OUTPUT.Location = New System.Drawing.Point(465, 4)
        Me.cmd_FILE_OUTPUT.Name = "cmd_FILE_OUTPUT"
        Me.cmd_FILE_OUTPUT.Size = New System.Drawing.Size(75, 30)
        Me.cmd_FILE_OUTPUT.TabIndex = 5
        Me.cmd_FILE_OUTPUT.Text = " "
        Me.cmd_FILE_OUTPUT.UseVisualStyleBackColor = True
        '
        ' cmd_PRINT
        '
        Me.cmd_PRINT.Location = New System.Drawing.Point(548, 4)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(75, 30)
        Me.cmd_PRINT.TabIndex = 6
        Me.cmd_PRINT.Text = " "
        Me.cmd_PRINT.UseVisualStyleBackColor = True
        '
        ' cmd_LOG_REF
        '
        Me.cmd_LOG_REF.Location = New System.Drawing.Point(631, 4)
        Me.cmd_LOG_REF.Name = "cmd_LOG_REF"
        Me.cmd_LOG_REF.Size = New System.Drawing.Size(75, 30)
        Me.cmd_LOG_REF.TabIndex = 7
        Me.cmd_LOG_REF.Text = " "
        Me.cmd_LOG_REF.UseVisualStyleBackColor = True
        '
        ' cmd_変更
        '
        Me.cmd_変更.Location = New System.Drawing.Point(714, 4)
        Me.cmd_変更.Name = "cmd_変更"
        Me.cmd_変更.Size = New System.Drawing.Size(92, 30)
        Me.cmd_変更.TabIndex = 8
        Me.cmd_変更.Text = "変更(&U)"
        Me.cmd_変更.UseVisualStyleBackColor = True
        '
        ' cmd_再表示
        '
        Me.cmd_再表示.Location = New System.Drawing.Point(814, 4)
        Me.cmd_再表示.Name = "cmd_再表示"
        Me.cmd_再表示.Size = New System.Drawing.Size(104, 30)
        Me.cmd_再表示.TabIndex = 9
        Me.cmd_再表示.Text = "再表示(&L)"
        Me.cmd_再表示.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSearchDLG
        '
        Me.cmd_FlexSearchDLG.Location = New System.Drawing.Point(926, 4)
        Me.cmd_FlexSearchDLG.Name = "cmd_FlexSearchDLG"
        Me.cmd_FlexSearchDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexSearchDLG.TabIndex = 10
        Me.cmd_FlexSearchDLG.Text = "検索(&S)"
        Me.cmd_FlexSearchDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSortDLG
        '
        Me.cmd_FlexSortDLG.Location = New System.Drawing.Point(1026, 4)
        Me.cmd_FlexSortDLG.Name = "cmd_FlexSortDLG"
        Me.cmd_FlexSortDLG.Size = New System.Drawing.Size(116, 30)
        Me.cmd_FlexSortDLG.TabIndex = 11
        Me.cmd_FlexSortDLG.Text = "並べ替え(&O)"
        Me.cmd_FlexSortDLG.UseVisualStyleBackColor = True
        '
        ' cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(1150, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Output.TabIndex = 12
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        ' dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.txt_KNGN_CD, Me.txt_KNGN_NM, Me.txt_ACCESS_KIND_STR, Me.txt_BIKO, Me.txt_CREATE_DT, Me.txt_UPDATE_DT, Me.txt_KNGN_ID, Me.txt_ACCESS_KIND_B_STR, Me.txt_ID})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 40)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowTemplate.Height = 21
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(1200, 521)
        Me.dgvMain.TabIndex = 13
        '
        ' txt_KNGN_CD
        '
        Me.txt_KNGN_CD.DataPropertyName = "KNGN_CD"
        Me.txt_KNGN_CD.HeaderText = "権限ｺｰﾄﾞ"
        Me.txt_KNGN_CD.Name = "txt_KNGN_CD"
        Me.txt_KNGN_CD.ReadOnly = True
        Me.txt_KNGN_CD.Width = 79
        '
        ' txt_KNGN_NM
        '
        Me.txt_KNGN_NM.DataPropertyName = "KNGN_NM"
        Me.txt_KNGN_NM.HeaderText = "権限名"
        Me.txt_KNGN_NM.Name = "txt_KNGN_NM"
        Me.txt_KNGN_NM.ReadOnly = True
        Me.txt_KNGN_NM.Width = 151
        '
        ' txt_ACCESS_KIND_STR
        '
        Me.txt_ACCESS_KIND_STR.DataPropertyName = "ACCESS_KIND_STR"
        Me.txt_ACCESS_KIND_STR.HeaderText = "契約管理単位用ﾃﾞｰﾀｱｸｾｽ権"
        Me.txt_ACCESS_KIND_STR.Name = "txt_ACCESS_KIND_STR"
        Me.txt_ACCESS_KIND_STR.ReadOnly = True
        Me.txt_ACCESS_KIND_STR.Width = 151
        '
        ' txt_BIKO
        '
        Me.txt_BIKO.DataPropertyName = "BIKO"
        Me.txt_BIKO.HeaderText = "備考"
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.ReadOnly = True
        Me.txt_BIKO.Width = 151
        '
        ' txt_CREATE_DT
        '
        Me.txt_CREATE_DT.DataPropertyName = "CREATE_DT"
        Me.txt_CREATE_DT.HeaderText = "作成日時"
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Width = 124
        '
        ' txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.DataPropertyName = "UPDATE_DT"
        Me.txt_UPDATE_DT.HeaderText = "更新日時"
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Width = 124
        '
        ' txt_KNGN_ID
        '
        Me.txt_KNGN_ID.DataPropertyName = "KNGN_ID"
        Me.txt_KNGN_ID.HeaderText = "ID"
        Me.txt_KNGN_ID.Name = "txt_KNGN_ID"
        Me.txt_KNGN_ID.ReadOnly = True
        Me.txt_KNGN_ID.Width = 60
        '
        ' txt_ACCESS_KIND_B_STR
        '
        Me.txt_ACCESS_KIND_B_STR.DataPropertyName = "ACCESS_KIND_B_STR"
        Me.txt_ACCESS_KIND_B_STR.HeaderText = "物件管理単位用ﾃﾞｰﾀｱｸｾｽ権"
        Me.txt_ACCESS_KIND_B_STR.Name = "txt_ACCESS_KIND_B_STR"
        Me.txt_ACCESS_KIND_B_STR.ReadOnly = True
        Me.txt_ACCESS_KIND_B_STR.Width = 151
        '
        ' txt_ID
        '
        Me.txt_ID.DataPropertyName = "ID"
        Me.txt_ID.HeaderText = "ID"
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Visible = False
        '
        ' Form_f_flx_SEC_KNGN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_SEC_KNGN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "システム利用権限"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_新規 As System.Windows.Forms.Button
    Friend WithEvents cmd_ADMIN As System.Windows.Forms.Button
    Friend WithEvents cmd_MASTER_UPDATE As System.Windows.Forms.Button
    Friend WithEvents cmd_APPROVAL As System.Windows.Forms.Button
    Friend WithEvents cmd_FILE_OUTPUT As System.Windows.Forms.Button
    Friend WithEvents cmd_PRINT As System.Windows.Forms.Button
    Friend WithEvents cmd_LOG_REF As System.Windows.Forms.Button
    Friend WithEvents cmd_変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_再表示 As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_KNGN_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KNGN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ACCESS_KIND_STR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BIKO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CREATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_UPDATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KNGN_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ACCESS_KIND_B_STR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn

End Class