<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_M_SWPTN

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
        Me.cmd_変更 = New System.Windows.Forms.Button()
        Me.cmd_新規 = New System.Windows.Forms.Button()
        Me.cmd_再表示 = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_SWPTN_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SWPTN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK2_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK2_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK3_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK3_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CREATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_UPDATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK4_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK4_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK5_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK5_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK6_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK6_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK7__CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK7__NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK8_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK8_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK9_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK9_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK10_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KMK10_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_新規)
        Me.pnlHeader.Controls.Add(Me.cmd_変更)
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
        ' cmd_変更
        '
        Me.cmd_変更.Location = New System.Drawing.Point(116, 4)
        Me.cmd_変更.Name = "cmd_変更"
        Me.cmd_変更.Size = New System.Drawing.Size(92, 30)
        Me.cmd_変更.TabIndex = 1
        Me.cmd_変更.Text = "変更(&U)"
        Me.cmd_変更.UseVisualStyleBackColor = True
        '
        ' cmd_新規
        '
        Me.cmd_新規.Location = New System.Drawing.Point(216, 4)
        Me.cmd_新規.Name = "cmd_新規"
        Me.cmd_新規.Size = New System.Drawing.Size(92, 30)
        Me.cmd_新規.TabIndex = 2
        Me.cmd_新規.Text = "新規(&N)"
        Me.cmd_新規.UseVisualStyleBackColor = True
        '
        ' cmd_再表示
        '
        Me.cmd_再表示.Location = New System.Drawing.Point(316, 4)
        Me.cmd_再表示.Name = "cmd_再表示"
        Me.cmd_再表示.Size = New System.Drawing.Size(104, 30)
        Me.cmd_再表示.TabIndex = 3
        Me.cmd_再表示.Text = "再表示(&L)"
        Me.cmd_再表示.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSearchDLG
        '
        Me.cmd_FlexSearchDLG.Location = New System.Drawing.Point(428, 4)
        Me.cmd_FlexSearchDLG.Name = "cmd_FlexSearchDLG"
        Me.cmd_FlexSearchDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexSearchDLG.TabIndex = 4
        Me.cmd_FlexSearchDLG.Text = "検索(&S)"
        Me.cmd_FlexSearchDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSortDLG
        '
        Me.cmd_FlexSortDLG.Location = New System.Drawing.Point(528, 4)
        Me.cmd_FlexSortDLG.Name = "cmd_FlexSortDLG"
        Me.cmd_FlexSortDLG.Size = New System.Drawing.Size(116, 30)
        Me.cmd_FlexSortDLG.TabIndex = 5
        Me.cmd_FlexSortDLG.Text = "並べ替え(&O)"
        Me.cmd_FlexSortDLG.UseVisualStyleBackColor = True
        '
        ' cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(652, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Output.TabIndex = 6
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        ' dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.txt_SWPTN_CD, Me.txt_SWPTN_NM, Me.txt_KMK1_CD, Me.txt_KMK1_NM, Me.txt_KMK2_CD, Me.txt_KMK2_NM, Me.txt_KMK3_CD, Me.txt_KMK3_NM, Me.txt_BIKO, Me.txt_CREATE_DT, Me.txt_UPDATE_DT, Me.txt_ID, Me.txt_HISTORY_F, Me.txt_KMK4_CD, Me.txt_KMK4_NM, Me.txt_KMK5_CD, Me.txt_KMK5_NM, Me.txt_KMK6_CD, Me.txt_KMK6_NM, Me.txt_KMK7__CD, Me.txt_KMK7__NM, Me.txt_KMK8_CD, Me.txt_KMK8_NM, Me.txt_KMK9_CD, Me.txt_KMK9_NM, Me.txt_KMK10_CD, Me.txt_KMK10_NM})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 40)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowTemplate.Height = 21
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(1200, 521)
        Me.dgvMain.TabIndex = 7
        '
        ' txt_SWPTN_CD
        '
        Me.txt_SWPTN_CD.DataPropertyName = "SWPTN_CD"
        Me.txt_SWPTN_CD.HeaderText = "仕訳ﾊﾟﾀｰﾝｺｰﾄﾞ"
        Me.txt_SWPTN_CD.Name = "txt_SWPTN_CD"
        Me.txt_SWPTN_CD.ReadOnly = True
        Me.txt_SWPTN_CD.Width = 72
        '
        ' txt_SWPTN_NM
        '
        Me.txt_SWPTN_NM.DataPropertyName = "SWPTN_NM"
        Me.txt_SWPTN_NM.HeaderText = "仕訳ﾊﾟﾀｰﾝ"
        Me.txt_SWPTN_NM.Name = "txt_SWPTN_NM"
        Me.txt_SWPTN_NM.ReadOnly = True
        Me.txt_SWPTN_NM.Width = 136
        '
        ' txt_KMK1_CD
        '
        Me.txt_KMK1_CD.DataPropertyName = "KMK1_CD"
        Me.txt_KMK1_CD.HeaderText = "科目1CD"
        Me.txt_KMK1_CD.Name = "txt_KMK1_CD"
        Me.txt_KMK1_CD.ReadOnly = True
        Me.txt_KMK1_CD.Width = 66
        '
        ' txt_KMK1_NM
        '
        Me.txt_KMK1_NM.DataPropertyName = "KMK1_NM"
        Me.txt_KMK1_NM.HeaderText = "科目1名称"
        Me.txt_KMK1_NM.Name = "txt_KMK1_NM"
        Me.txt_KMK1_NM.ReadOnly = True
        Me.txt_KMK1_NM.Width = 81
        '
        ' txt_KMK2_CD
        '
        Me.txt_KMK2_CD.DataPropertyName = "KMK2_CD"
        Me.txt_KMK2_CD.HeaderText = "科目2CD"
        Me.txt_KMK2_CD.Name = "txt_KMK2_CD"
        Me.txt_KMK2_CD.ReadOnly = True
        Me.txt_KMK2_CD.Width = 66
        '
        ' txt_KMK2_NM
        '
        Me.txt_KMK2_NM.DataPropertyName = "KMK2_NM"
        Me.txt_KMK2_NM.HeaderText = "科目2名称"
        Me.txt_KMK2_NM.Name = "txt_KMK2_NM"
        Me.txt_KMK2_NM.ReadOnly = True
        Me.txt_KMK2_NM.Width = 81
        '
        ' txt_KMK3_CD
        '
        Me.txt_KMK3_CD.DataPropertyName = "KMK3_CD"
        Me.txt_KMK3_CD.HeaderText = "科目3CD"
        Me.txt_KMK3_CD.Name = "txt_KMK3_CD"
        Me.txt_KMK3_CD.ReadOnly = True
        Me.txt_KMK3_CD.Width = 66
        '
        ' txt_KMK3_NM
        '
        Me.txt_KMK3_NM.DataPropertyName = "KMK3_NM"
        Me.txt_KMK3_NM.HeaderText = "科目3名称"
        Me.txt_KMK3_NM.Name = "txt_KMK3_NM"
        Me.txt_KMK3_NM.ReadOnly = True
        Me.txt_KMK3_NM.Width = 81
        '
        ' txt_BIKO
        '
        Me.txt_BIKO.DataPropertyName = "BIKO"
        Me.txt_BIKO.HeaderText = "備考"
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.ReadOnly = True
        Me.txt_BIKO.Width = 134
        '
        ' txt_CREATE_DT
        '
        Me.txt_CREATE_DT.DataPropertyName = "CREATE_DT"
        Me.txt_CREATE_DT.HeaderText = "作成日時"
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Width = 121
        '
        ' txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.DataPropertyName = "UPDATE_DT"
        Me.txt_UPDATE_DT.HeaderText = "更新日時"
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Width = 121
        '
        ' txt_ID
        '
        Me.txt_ID.DataPropertyName = "ID"
        Me.txt_ID.HeaderText = "ID"
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Width = 60
        '
        ' txt_HISTORY_F
        '
        Me.txt_HISTORY_F.DataPropertyName = "HISTORY_F"
        Me.txt_HISTORY_F.HeaderText = "HISTORY_F"
        Me.txt_HISTORY_F.Name = "txt_HISTORY_F"
        Me.txt_HISTORY_F.ReadOnly = True
        Me.txt_HISTORY_F.Width = 60
        '
        ' txt_KMK4_CD
        '
        Me.txt_KMK4_CD.DataPropertyName = "KMK4_CD"
        Me.txt_KMK4_CD.HeaderText = "KMK4_CD"
        Me.txt_KMK4_CD.Name = "txt_KMK4_CD"
        Me.txt_KMK4_CD.ReadOnly = True
        Me.txt_KMK4_CD.Width = 66
        '
        ' txt_KMK4_NM
        '
        Me.txt_KMK4_NM.DataPropertyName = "KMK4_NM"
        Me.txt_KMK4_NM.HeaderText = "KMK4_NM"
        Me.txt_KMK4_NM.Name = "txt_KMK4_NM"
        Me.txt_KMK4_NM.ReadOnly = True
        Me.txt_KMK4_NM.Width = 81
        '
        ' txt_KMK5_CD
        '
        Me.txt_KMK5_CD.DataPropertyName = "KMK5_CD"
        Me.txt_KMK5_CD.HeaderText = "KMK5_CD"
        Me.txt_KMK5_CD.Name = "txt_KMK5_CD"
        Me.txt_KMK5_CD.ReadOnly = True
        Me.txt_KMK5_CD.Width = 66
        '
        ' txt_KMK5_NM
        '
        Me.txt_KMK5_NM.DataPropertyName = "KMK5_NM"
        Me.txt_KMK5_NM.HeaderText = "KMK5_NM"
        Me.txt_KMK5_NM.Name = "txt_KMK5_NM"
        Me.txt_KMK5_NM.ReadOnly = True
        Me.txt_KMK5_NM.Width = 81
        '
        ' txt_KMK6_CD
        '
        Me.txt_KMK6_CD.DataPropertyName = "KMK6_CD"
        Me.txt_KMK6_CD.HeaderText = "KMK6_CD"
        Me.txt_KMK6_CD.Name = "txt_KMK6_CD"
        Me.txt_KMK6_CD.ReadOnly = True
        Me.txt_KMK6_CD.Width = 66
        '
        ' txt_KMK6_NM
        '
        Me.txt_KMK6_NM.DataPropertyName = "KMK6_NM"
        Me.txt_KMK6_NM.HeaderText = "KMK6_NM"
        Me.txt_KMK6_NM.Name = "txt_KMK6_NM"
        Me.txt_KMK6_NM.ReadOnly = True
        Me.txt_KMK6_NM.Width = 81
        '
        ' txt_KMK7__CD
        '
        Me.txt_KMK7__CD.DataPropertyName = "KMK7__CD"
        Me.txt_KMK7__CD.HeaderText = "KMK7__CD"
        Me.txt_KMK7__CD.Name = "txt_KMK7__CD"
        Me.txt_KMK7__CD.ReadOnly = True
        Me.txt_KMK7__CD.Width = 66
        '
        ' txt_KMK7__NM
        '
        Me.txt_KMK7__NM.DataPropertyName = "KMK7__NM"
        Me.txt_KMK7__NM.HeaderText = "KMK7__NM"
        Me.txt_KMK7__NM.Name = "txt_KMK7__NM"
        Me.txt_KMK7__NM.ReadOnly = True
        Me.txt_KMK7__NM.Width = 81
        '
        ' txt_KMK8_CD
        '
        Me.txt_KMK8_CD.DataPropertyName = "KMK8_CD"
        Me.txt_KMK8_CD.HeaderText = "KMK8_CD"
        Me.txt_KMK8_CD.Name = "txt_KMK8_CD"
        Me.txt_KMK8_CD.ReadOnly = True
        Me.txt_KMK8_CD.Width = 66
        '
        ' txt_KMK8_NM
        '
        Me.txt_KMK8_NM.DataPropertyName = "KMK8_NM"
        Me.txt_KMK8_NM.HeaderText = "KMK8_NM"
        Me.txt_KMK8_NM.Name = "txt_KMK8_NM"
        Me.txt_KMK8_NM.ReadOnly = True
        Me.txt_KMK8_NM.Width = 81
        '
        ' txt_KMK9_CD
        '
        Me.txt_KMK9_CD.DataPropertyName = "KMK9_CD"
        Me.txt_KMK9_CD.HeaderText = "KMK9_CD"
        Me.txt_KMK9_CD.Name = "txt_KMK9_CD"
        Me.txt_KMK9_CD.ReadOnly = True
        Me.txt_KMK9_CD.Width = 66
        '
        ' txt_KMK9_NM
        '
        Me.txt_KMK9_NM.DataPropertyName = "KMK9_NM"
        Me.txt_KMK9_NM.HeaderText = "KMK9_NM"
        Me.txt_KMK9_NM.Name = "txt_KMK9_NM"
        Me.txt_KMK9_NM.ReadOnly = True
        Me.txt_KMK9_NM.Width = 81
        '
        ' txt_KMK10_CD
        '
        Me.txt_KMK10_CD.DataPropertyName = "KMK10_CD"
        Me.txt_KMK10_CD.HeaderText = "KMK10_CD"
        Me.txt_KMK10_CD.Name = "txt_KMK10_CD"
        Me.txt_KMK10_CD.ReadOnly = True
        Me.txt_KMK10_CD.Width = 66
        '
        ' txt_KMK10_NM
        '
        Me.txt_KMK10_NM.DataPropertyName = "KMK10_NM"
        Me.txt_KMK10_NM.HeaderText = "KMK10_NM"
        Me.txt_KMK10_NM.Name = "txt_KMK10_NM"
        Me.txt_KMK10_NM.ReadOnly = True
        Me.txt_KMK10_NM.Width = 81
        '
        ' Form_f_flx_M_SWPTN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_M_SWPTN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "仕訳パターンマスタ"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_新規 As System.Windows.Forms.Button
    Friend WithEvents cmd_再表示 As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_SWPTN_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SWPTN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK1_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK2_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK2_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK3_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK3_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BIKO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CREATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_UPDATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_HISTORY_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK4_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK4_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK5_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK5_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK6_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK6_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK7__CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK7__NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK8_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK8_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK9_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK9_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK10_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KMK10_NM As System.Windows.Forms.DataGridViewTextBoxColumn

End Class