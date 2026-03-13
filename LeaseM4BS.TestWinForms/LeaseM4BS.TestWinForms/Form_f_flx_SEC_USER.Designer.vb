<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_flx_SEC_USER

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
        Me.cmd_LOGIN_ATTEMPTS = New System.Windows.Forms.Button()
        Me.cmd_PWD_LIFE_TIME = New System.Windows.Forms.Button()
        Me.cmd_PWD_GRACE_TIME = New System.Windows.Forms.Button()
        Me.cmd_PWD_MIN = New System.Windows.Forms.Button()
        Me.cmd_PWD_MOJI_CHK = New System.Windows.Forms.Button()
        Me.cmd_ERR_CT = New System.Windows.Forms.Button()
        Me.cmd_LAST_ERR_DT = New System.Windows.Forms.Button()
        Me.cmd_新規 = New System.Windows.Forms.Button()
        Me.cmd_変更 = New System.Windows.Forms.Button()
        Me.cmd_再表示 = New System.Windows.Forms.Button()
        Me.cmd_FlexSearchDLG = New System.Windows.Forms.Button()
        Me.cmd_FlexSortDLG = New System.Windows.Forms.Button()
        Me.cmd_Output = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.txt_USER_CD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_USER_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KNGN_NM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_BIKO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_CREATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_UPDATE_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_HISTORY_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LOGIN_ATTEMPTS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_PWD_LIFE_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_PWD_GRACE_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_PWD_MIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_ERR_CT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_LAST_ERR_DT = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.pnlHeader.Controls.Add(Me.cmd_LAST_ERR_DT)
        Me.pnlHeader.Controls.Add(Me.cmd_ERR_CT)
        Me.pnlHeader.Controls.Add(Me.cmd_PWD_MOJI_CHK)
        Me.pnlHeader.Controls.Add(Me.cmd_PWD_MIN)
        Me.pnlHeader.Controls.Add(Me.cmd_PWD_GRACE_TIME)
        Me.pnlHeader.Controls.Add(Me.cmd_PWD_LIFE_TIME)
        Me.pnlHeader.Controls.Add(Me.cmd_LOGIN_ATTEMPTS)
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
        ' cmd_LOGIN_ATTEMPTS
        '
        Me.cmd_LOGIN_ATTEMPTS.Location = New System.Drawing.Point(116, 4)
        Me.cmd_LOGIN_ATTEMPTS.Name = "cmd_LOGIN_ATTEMPTS"
        Me.cmd_LOGIN_ATTEMPTS.Size = New System.Drawing.Size(75, 30)
        Me.cmd_LOGIN_ATTEMPTS.TabIndex = 1
        Me.cmd_LOGIN_ATTEMPTS.Text = " "
        Me.cmd_LOGIN_ATTEMPTS.UseVisualStyleBackColor = True
        '
        ' cmd_PWD_LIFE_TIME
        '
        Me.cmd_PWD_LIFE_TIME.Location = New System.Drawing.Point(199, 4)
        Me.cmd_PWD_LIFE_TIME.Name = "cmd_PWD_LIFE_TIME"
        Me.cmd_PWD_LIFE_TIME.Size = New System.Drawing.Size(75, 30)
        Me.cmd_PWD_LIFE_TIME.TabIndex = 2
        Me.cmd_PWD_LIFE_TIME.Text = " "
        Me.cmd_PWD_LIFE_TIME.UseVisualStyleBackColor = True
        '
        ' cmd_PWD_GRACE_TIME
        '
        Me.cmd_PWD_GRACE_TIME.Location = New System.Drawing.Point(282, 4)
        Me.cmd_PWD_GRACE_TIME.Name = "cmd_PWD_GRACE_TIME"
        Me.cmd_PWD_GRACE_TIME.Size = New System.Drawing.Size(75, 30)
        Me.cmd_PWD_GRACE_TIME.TabIndex = 3
        Me.cmd_PWD_GRACE_TIME.Text = " "
        Me.cmd_PWD_GRACE_TIME.UseVisualStyleBackColor = True
        '
        ' cmd_PWD_MIN
        '
        Me.cmd_PWD_MIN.Location = New System.Drawing.Point(365, 4)
        Me.cmd_PWD_MIN.Name = "cmd_PWD_MIN"
        Me.cmd_PWD_MIN.Size = New System.Drawing.Size(75, 30)
        Me.cmd_PWD_MIN.TabIndex = 4
        Me.cmd_PWD_MIN.Text = " "
        Me.cmd_PWD_MIN.UseVisualStyleBackColor = True
        '
        ' cmd_PWD_MOJI_CHK
        '
        Me.cmd_PWD_MOJI_CHK.Location = New System.Drawing.Point(448, 4)
        Me.cmd_PWD_MOJI_CHK.Name = "cmd_PWD_MOJI_CHK"
        Me.cmd_PWD_MOJI_CHK.Size = New System.Drawing.Size(75, 30)
        Me.cmd_PWD_MOJI_CHK.TabIndex = 5
        Me.cmd_PWD_MOJI_CHK.Text = " "
        Me.cmd_PWD_MOJI_CHK.UseVisualStyleBackColor = True
        '
        ' cmd_ERR_CT
        '
        Me.cmd_ERR_CT.Location = New System.Drawing.Point(531, 4)
        Me.cmd_ERR_CT.Name = "cmd_ERR_CT"
        Me.cmd_ERR_CT.Size = New System.Drawing.Size(75, 30)
        Me.cmd_ERR_CT.TabIndex = 6
        Me.cmd_ERR_CT.Text = " "
        Me.cmd_ERR_CT.UseVisualStyleBackColor = True
        '
        ' cmd_LAST_ERR_DT
        '
        Me.cmd_LAST_ERR_DT.Location = New System.Drawing.Point(614, 4)
        Me.cmd_LAST_ERR_DT.Name = "cmd_LAST_ERR_DT"
        Me.cmd_LAST_ERR_DT.Size = New System.Drawing.Size(75, 30)
        Me.cmd_LAST_ERR_DT.TabIndex = 7
        Me.cmd_LAST_ERR_DT.Text = " "
        Me.cmd_LAST_ERR_DT.UseVisualStyleBackColor = True
        '
        ' cmd_新規
        '
        Me.cmd_新規.Location = New System.Drawing.Point(697, 4)
        Me.cmd_新規.Name = "cmd_新規"
        Me.cmd_新規.Size = New System.Drawing.Size(92, 30)
        Me.cmd_新規.TabIndex = 8
        Me.cmd_新規.Text = "新規(&N)"
        Me.cmd_新規.UseVisualStyleBackColor = True
        '
        ' cmd_変更
        '
        Me.cmd_変更.Location = New System.Drawing.Point(797, 4)
        Me.cmd_変更.Name = "cmd_変更"
        Me.cmd_変更.Size = New System.Drawing.Size(92, 30)
        Me.cmd_変更.TabIndex = 9
        Me.cmd_変更.Text = "変更(&U)"
        Me.cmd_変更.UseVisualStyleBackColor = True
        '
        ' cmd_再表示
        '
        Me.cmd_再表示.Location = New System.Drawing.Point(897, 4)
        Me.cmd_再表示.Name = "cmd_再表示"
        Me.cmd_再表示.Size = New System.Drawing.Size(104, 30)
        Me.cmd_再表示.TabIndex = 10
        Me.cmd_再表示.Text = "再表示(&L)"
        Me.cmd_再表示.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSearchDLG
        '
        Me.cmd_FlexSearchDLG.Location = New System.Drawing.Point(1009, 4)
        Me.cmd_FlexSearchDLG.Name = "cmd_FlexSearchDLG"
        Me.cmd_FlexSearchDLG.Size = New System.Drawing.Size(92, 30)
        Me.cmd_FlexSearchDLG.TabIndex = 11
        Me.cmd_FlexSearchDLG.Text = "検索(&S)"
        Me.cmd_FlexSearchDLG.UseVisualStyleBackColor = True
        '
        ' cmd_FlexSortDLG
        '
        Me.cmd_FlexSortDLG.Location = New System.Drawing.Point(1109, 4)
        Me.cmd_FlexSortDLG.Name = "cmd_FlexSortDLG"
        Me.cmd_FlexSortDLG.Size = New System.Drawing.Size(116, 30)
        Me.cmd_FlexSortDLG.TabIndex = 12
        Me.cmd_FlexSortDLG.Text = "並べ替え(&O)"
        Me.cmd_FlexSortDLG.UseVisualStyleBackColor = True
        '
        ' cmd_Output
        '
        Me.cmd_Output.Location = New System.Drawing.Point(1233, 4)
        Me.cmd_Output.Name = "cmd_Output"
        Me.cmd_Output.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Output.TabIndex = 13
        Me.cmd_Output.Text = "ﾌｧｲﾙ出力(&F)"
        Me.cmd_Output.UseVisualStyleBackColor = True
        '
        ' dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToDeleteRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.txt_USER_CD, Me.txt_USER_NM, Me.txt_KNGN_NM, Me.txt_BIKO, Me.txt_CREATE_DT, Me.txt_UPDATE_DT, Me.txt_ID, Me.txt_HISTORY_F, Me.txt_LOGIN_ATTEMPTS, Me.txt_PWD_LIFE_TIME, Me.txt_PWD_GRACE_TIME, Me.txt_PWD_MIN, Me.txt_ERR_CT, Me.txt_LAST_ERR_DT})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 40)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowTemplate.Height = 21
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(1200, 521)
        Me.dgvMain.TabIndex = 14
        '
        ' txt_USER_CD
        '
        Me.txt_USER_CD.DataPropertyName = "USER_CD"
        Me.txt_USER_CD.HeaderText = "利用者名"
        Me.txt_USER_CD.Name = "txt_USER_CD"
        Me.txt_USER_CD.ReadOnly = True
        Me.txt_USER_CD.Width = 79
        '
        ' txt_USER_NM
        '
        Me.txt_USER_NM.DataPropertyName = "USER_NM"
        Me.txt_USER_NM.HeaderText = "利用者ｺｰﾄﾞ"
        Me.txt_USER_NM.Name = "txt_USER_NM"
        Me.txt_USER_NM.ReadOnly = True
        Me.txt_USER_NM.Width = 151
        '
        ' txt_KNGN_NM
        '
        Me.txt_KNGN_NM.DataPropertyName = "KNGN_NM"
        Me.txt_KNGN_NM.HeaderText = "権限名"
        Me.txt_KNGN_NM.Name = "txt_KNGN_NM"
        Me.txt_KNGN_NM.ReadOnly = True
        Me.txt_KNGN_NM.Width = 151
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
        ' txt_LOGIN_ATTEMPTS
        '
        Me.txt_LOGIN_ATTEMPTS.DataPropertyName = "LOGIN_ATTEMPTS"
        Me.txt_LOGIN_ATTEMPTS.HeaderText = "LOGIN_ATTEMPTS"
        Me.txt_LOGIN_ATTEMPTS.Name = "txt_LOGIN_ATTEMPTS"
        Me.txt_LOGIN_ATTEMPTS.ReadOnly = True
        Me.txt_LOGIN_ATTEMPTS.Width = 60
        '
        ' txt_PWD_LIFE_TIME
        '
        Me.txt_PWD_LIFE_TIME.DataPropertyName = "PWD_LIFE_TIME"
        Me.txt_PWD_LIFE_TIME.HeaderText = "PWD_LIFE_TIME"
        Me.txt_PWD_LIFE_TIME.Name = "txt_PWD_LIFE_TIME"
        Me.txt_PWD_LIFE_TIME.ReadOnly = True
        Me.txt_PWD_LIFE_TIME.Width = 75
        '
        ' txt_PWD_GRACE_TIME
        '
        Me.txt_PWD_GRACE_TIME.DataPropertyName = "PWD_GRACE_TIME"
        Me.txt_PWD_GRACE_TIME.HeaderText = "PWD_GRACE_TIME"
        Me.txt_PWD_GRACE_TIME.Name = "txt_PWD_GRACE_TIME"
        Me.txt_PWD_GRACE_TIME.ReadOnly = True
        Me.txt_PWD_GRACE_TIME.Width = 75
        '
        ' txt_PWD_MIN
        '
        Me.txt_PWD_MIN.DataPropertyName = "PWD_MIN"
        Me.txt_PWD_MIN.HeaderText = "PWD_MIN"
        Me.txt_PWD_MIN.Name = "txt_PWD_MIN"
        Me.txt_PWD_MIN.ReadOnly = True
        Me.txt_PWD_MIN.Width = 60
        '
        ' txt_ERR_CT
        '
        Me.txt_ERR_CT.DataPropertyName = "ERR_CT"
        Me.txt_ERR_CT.HeaderText = "ERR_CT"
        Me.txt_ERR_CT.Name = "txt_ERR_CT"
        Me.txt_ERR_CT.ReadOnly = True
        Me.txt_ERR_CT.Width = 60
        '
        ' txt_LAST_ERR_DT
        '
        Me.txt_LAST_ERR_DT.DataPropertyName = "LAST_ERR_DT"
        Me.txt_LAST_ERR_DT.HeaderText = "最終エラー日時"
        Me.txt_LAST_ERR_DT.Name = "txt_LAST_ERR_DT"
        Me.txt_LAST_ERR_DT.ReadOnly = True
        Me.txt_LAST_ERR_DT.Width = 124
        '
        ' Form_f_flx_SEC_USER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 561)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.KeyPreview = True
        Me.Name = "Form_f_flx_SEC_USER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "システム利用者"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_LOGIN_ATTEMPTS As System.Windows.Forms.Button
    Friend WithEvents cmd_PWD_LIFE_TIME As System.Windows.Forms.Button
    Friend WithEvents cmd_PWD_GRACE_TIME As System.Windows.Forms.Button
    Friend WithEvents cmd_PWD_MIN As System.Windows.Forms.Button
    Friend WithEvents cmd_PWD_MOJI_CHK As System.Windows.Forms.Button
    Friend WithEvents cmd_ERR_CT As System.Windows.Forms.Button
    Friend WithEvents cmd_LAST_ERR_DT As System.Windows.Forms.Button
    Friend WithEvents cmd_新規 As System.Windows.Forms.Button
    Friend WithEvents cmd_変更 As System.Windows.Forms.Button
    Friend WithEvents cmd_再表示 As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSearchDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_FlexSortDLG As System.Windows.Forms.Button
    Friend WithEvents cmd_Output As System.Windows.Forms.Button
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents txt_USER_CD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_USER_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_KNGN_NM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_BIKO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_CREATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_UPDATE_DT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_HISTORY_F As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LOGIN_ATTEMPTS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_PWD_LIFE_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_PWD_GRACE_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_PWD_MIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_ERR_CT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_LAST_ERR_DT As System.Windows.Forms.DataGridViewTextBoxColumn

End Class