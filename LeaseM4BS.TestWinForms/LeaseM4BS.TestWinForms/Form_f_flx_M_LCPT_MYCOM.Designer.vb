<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_M_LCPT_MYCOM

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
        Me.cmd_変更 = New System.Windows.Forms.Button()
        Me.cmd_再表示 = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_LCPT1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LCPT1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LCPT2_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LCPT2_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CREATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_UPDATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SUM1_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SUM1_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SUM2_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_SUM2_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        ' cmd_変更
        '
        Me.cmd_変更.Location = New System.Drawing.Point(216, 4)
        Me.cmd_変更.Name = "cmd_変更"
        Me.cmd_変更.Size = New System.Drawing.Size(92, 30)
        Me.cmd_変更.TabIndex = 2
        Me.cmd_変更.Text = "変更(&U)"
        Me.cmd_変更.UseVisualStyleBackColor = True
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
            Me.txt_LCPT1_CD, Me.txt_LCPT1_NM, Me.txt_LCPT2_CD, Me.txt_LCPT2_NM, Me.txt_BIKO, Me.txt_CREATE_DT, Me.txt_UPDATE_DT, Me.txt_ID, Me.txt_HISTORY_F, Me.txt_SUM1_CD, Me.txt_SUM1_NM, Me.txt_SUM2_CD, Me.txt_SUM2_NM})
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
        ' txt_LCPT1_CD
        '
        Me.txt_LCPT1_CD.DataPropertyName = "LCPT1_CD"
        Me.txt_LCPT1_CD.HeaderText = "支払先ｺｰﾄﾞ"
        Me.txt_LCPT1_CD.Name = "txt_LCPT1_CD"
        Me.txt_LCPT1_CD.ReadOnly = True
        Me.txt_LCPT1_CD.Width = 79
        '
        ' txt_LCPT1_NM
        '
        Me.txt_LCPT1_NM.DataPropertyName = "LCPT1_NM"
        Me.txt_LCPT1_NM.HeaderText = "支払先名"
        Me.txt_LCPT1_NM.Name = "txt_LCPT1_NM"
        Me.txt_LCPT1_NM.ReadOnly = True
        Me.txt_LCPT1_NM.Width = 151
        '
        ' txt_LCPT2_CD
        '
        Me.txt_LCPT2_CD.DataPropertyName = "LCPT2_CD"
        Me.txt_LCPT2_CD.HeaderText = "支払先ｺｰﾄﾞ2"
        Me.txt_LCPT2_CD.Name = "txt_LCPT2_CD"
        Me.txt_LCPT2_CD.ReadOnly = True
        Me.txt_LCPT2_CD.Width = 79
        '
        ' txt_LCPT2_NM
        '
        Me.txt_LCPT2_NM.DataPropertyName = "LCPT2_NM"
        Me.txt_LCPT2_NM.HeaderText = "支払先名2"
        Me.txt_LCPT2_NM.Name = "txt_LCPT2_NM"
        Me.txt_LCPT2_NM.ReadOnly = True
        Me.txt_LCPT2_NM.Width = 151
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
        ' txt_SUM1_CD
        '
        Me.txt_SUM1_CD.DataPropertyName = "SUM1_CD"
        Me.txt_SUM1_CD.HeaderText = "SUM1_CD"
        Me.txt_SUM1_CD.Name = "txt_SUM1_CD"
        Me.txt_SUM1_CD.ReadOnly = True
        Me.txt_SUM1_CD.Width = 79
        '
        ' txt_SUM1_NM
        '
        Me.txt_SUM1_NM.DataPropertyName = "SUM1_NM"
        Me.txt_SUM1_NM.HeaderText = "SUM1_NM"
        Me.txt_SUM1_NM.Name = "txt_SUM1_NM"
        Me.txt_SUM1_NM.ReadOnly = True
        Me.txt_SUM1_NM.Width = 151
        '
        ' txt_SUM2_CD
        '
        Me.txt_SUM2_CD.DataPropertyName = "SUM2_CD"
        Me.txt_SUM2_CD.HeaderText = "SUM2_CD"
        Me.txt_SUM2_CD.Name = "txt_SUM2_CD"
        Me.txt_SUM2_CD.ReadOnly = True
        Me.txt_SUM2_CD.Width = 79
        '
        ' txt_SUM2_NM
        '
        Me.txt_SUM2_NM.DataPropertyName = "SUM2_NM"
        Me.txt_SUM2_NM.HeaderText = "SUM2_NM"
        Me.txt_SUM2_NM.Name = "txt_SUM2_NM"
        Me.txt_SUM2_NM.ReadOnly = True
        Me.txt_SUM2_NM.Width = 151
        '
        ' Form_f_flx_M_LCPT_MYCOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_M_LCPT_MYCOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "支払先マスタ"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_新規 As System.Windows.Forms.Button
    Friend WithEvents cmd_変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_再表示 As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_LCPT1_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LCPT1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LCPT2_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LCPT2_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BIKO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CREATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_UPDATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_HISTORY_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SUM1_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SUM1_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SUM2_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_SUM2_NM As System.Windows.Forms.DataGridViewTextBoxColumn

End Class