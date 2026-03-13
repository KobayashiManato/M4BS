<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_M_RSRVH1_IMPORT_1

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
        Me.cmd_閉じる = New System.Windows.Forms.Button()
        Me.cmd_EXCEL_IMPORT = New System.Windows.Forms.Button()
        Me.cmd_登録 = New System.Windows.Forms.Button()
        Me.txt_RSRVH1_CD = New System.Windows.Forms.TextBox()
        Me.txt_RSRVH1_NM = New System.Windows.Forms.TextBox()
        Me.txt_BIKO = New System.Windows.Forms.TextBox()
        Me.ラベル694 = New System.Windows.Forms.Label()
        Me.ラベル697 = New System.Windows.Forms.Label()
        Me.ラベル754 = New System.Windows.Forms.Label()
        Me.ラベル826 = New System.Windows.Forms.Label()
        Me.ラベル764 = New System.Windows.Forms.Label()
        Me.ラベル763 = New System.Windows.Forms.Label()
        Me.ラベル762 = New System.Windows.Forms.Label()
        Me.ラベル765 = New System.Windows.Forms.Label()
        Me.ラベル766 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_閉じる
        '
        Me.cmd_閉じる.Location = New System.Drawing.Point(3, 3)
        Me.cmd_閉じる.Name = "cmd_閉じる"
        Me.cmd_閉じる.Size = New System.Drawing.Size(75, 26)
        Me.cmd_閉じる.TabIndex = 0
        Me.cmd_閉じる.Text = "閉じる(&C)"
        Me.cmd_閉じる.UseVisualStyleBackColor = True
        '
        ' cmd_EXCEL_IMPORT
        '
        Me.cmd_EXCEL_IMPORT.Location = New System.Drawing.Point(83, 3)
        Me.cmd_EXCEL_IMPORT.Name = "cmd_EXCEL_IMPORT"
        Me.cmd_EXCEL_IMPORT.Size = New System.Drawing.Size(207, 26)
        Me.cmd_EXCEL_IMPORT.TabIndex = 1
        Me.cmd_EXCEL_IMPORT.Text = "Excelをﾜｰｸﾃｰﾌﾞﾙに取り込む(&I)"
        Me.cmd_EXCEL_IMPORT.UseVisualStyleBackColor = True
        '
        ' cmd_登録
        '
        Me.cmd_登録.Location = New System.Drawing.Point(291, 3)
        Me.cmd_登録.Name = "cmd_登録"
        Me.cmd_登録.Size = New System.Drawing.Size(132, 26)
        Me.cmd_登録.TabIndex = 2
        Me.cmd_登録.Text = "本登録ﾃﾞｰﾀの作成(&A)"
        Me.cmd_登録.UseVisualStyleBackColor = True
        '
        ' txt_RSRVH1_CD
        '
        Me.txt_RSRVH1_CD.Location = New System.Drawing.Point(3, 0)
        Me.txt_RSRVH1_CD.Name = "txt_RSRVH1_CD"
        Me.txt_RSRVH1_CD.Size = New System.Drawing.Size(75, 22)
        Me.txt_RSRVH1_CD.TabIndex = 3
        '
        ' txt_RSRVH1_NM
        '
        Me.txt_RSRVH1_NM.Location = New System.Drawing.Point(117, 0)
        Me.txt_RSRVH1_NM.Name = "txt_RSRVH1_NM"
        Me.txt_RSRVH1_NM.Size = New System.Drawing.Size(264, 22)
        Me.txt_RSRVH1_NM.TabIndex = 4
        '
        ' txt_BIKO
        '
        Me.txt_BIKO.Location = New System.Drawing.Point(381, 0)
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.Size = New System.Drawing.Size(75, 22)
        Me.txt_BIKO.TabIndex = 5
        '
        ' ラベル694
        '
        Me.ラベル694.AutoSize = True
        Me.ラベル694.Location = New System.Drawing.Point(3, 94)
        Me.ラベル694.Name = "ラベル694"
        Me.ラベル694.TabIndex = 6
        Me.ラベル694.Text = "ﾀｽｸNo."
        '
        ' ラベル697
        '
        Me.ラベル697.AutoSize = True
        Me.ラベル697.Location = New System.Drawing.Point(117, 94)
        Me.ラベル697.Name = "ラベル697"
        Me.ラベル697.TabIndex = 7
        Me.ラベル697.Text = "ﾀｽｸ名"
        '
        ' ラベル754
        '
        Me.ラベル754.AutoSize = True
        Me.ラベル754.Location = New System.Drawing.Point(381, 94)
        Me.ラベル754.Name = "ラベル754"
        Me.ラベル754.TabIndex = 8
        Me.ラベル754.Text = "会計部門ｺｰﾄﾞ"
        '
        ' ラベル826
        '
        Me.ラベル826.AutoSize = True
        Me.ラベル826.Location = New System.Drawing.Point(3, 37)
        Me.ラベル826.Name = "ラベル826"
        Me.ラベル826.TabIndex = 9
        Me.ラベル826.Text = "マスタ取込"
        '
        ' ラベル764
        '
        Me.ラベル764.AutoSize = True
        Me.ラベル764.Location = New System.Drawing.Point(3, 75)
        Me.ラベル764.Name = "ラベル764"
        Me.ラベル764.TabIndex = 10
        Me.ラベル764.Text = "＜ﾜｰｸﾃｰﾌﾞﾙ＞"
        '
        ' ラベル763
        '
        Me.ラベル763.AutoSize = True
        Me.ラベル763.Location = New System.Drawing.Point(113, 37)
        Me.ラベル763.Name = "ラベル763"
        Me.ラベル763.TabIndex = 11
        Me.ラベル763.Text = "Excelﾃﾞｰﾀを以下のいずれかの方法でﾜｰｸﾃｰﾌﾞﾙに取り込みます。\015\012・「Excelをﾜｰｸﾃｰﾌﾞﾙに取り込む」で取り込む。\015\012"
        '
        ' ラベル762
        '
        Me.ラベル762.AutoSize = True
        Me.ラベル762.Location = New System.Drawing.Point(3, 3)
        Me.ラベル762.Name = "ラベル762"
        Me.ラベル762.TabIndex = 12
        Me.ラベル762.Text = "「Excelをﾜｰｸﾃｰﾌﾞﾙに取り込む」の取込元Excelの仕様：\015\012  1列名：ﾀｽｸNo.\015\012  2列目：ﾀｽｸ名\015\012"
        '
        ' ラベル765
        '
        Me.ラベル765.AutoSize = True
        Me.ラベル765.Location = New System.Drawing.Point(3, 79)
        Me.ラベル765.Name = "ラベル765"
        Me.ラベル765.TabIndex = 13
        Me.ラベル765.Text = "ｸﾘｯﾌﾟﾎﾞｰﾄﾞ経由で貼り付ける方法：\015\012・ExcelでﾀｽｸNo.、ﾀｽｸ名、会計部門ｺｰﾄﾞ をｸﾘｯﾌﾟﾎﾞｰﾄﾞにｺﾋﾟｰします。この際"
        '
        ' ラベル766
        '
        Me.ラベル766.AutoSize = True
        Me.ラベル766.Location = New System.Drawing.Point(3, 120)
        Me.ラベル766.Name = "ラベル766"
        Me.ラベル766.TabIndex = 14
        Me.ラベル766.Text = "・ﾚｺｰﾄﾞｾﾚｸﾀを選択(CTRL+Aｷｰ押下)し、貼り付け（CTRL+V）ます。「貼り付けようとしているﾃﾞｰﾀのﾌｨｰﾙﾄﾞ名が、ﾌｫｰﾑのﾌｨｰﾙﾄﾞ名"
        '
        ' Form_f_M_RSRVH1_IMPORT_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 800)
        Me.Controls.Add(Me.ラベル694)
        Me.Controls.Add(Me.ラベル697)
        Me.Controls.Add(Me.ラベル754)
        Me.Controls.Add(Me.ラベル826)
        Me.Controls.Add(Me.ラベル764)
        Me.Controls.Add(Me.ラベル763)
        Me.Controls.Add(Me.ラベル762)
        Me.Controls.Add(Me.ラベル765)
        Me.Controls.Add(Me.ラベル766)
        Me.Controls.Add(Me.txt_RSRVH1_CD)
        Me.Controls.Add(Me.txt_RSRVH1_NM)
        Me.Controls.Add(Me.txt_BIKO)
        Me.Controls.Add(Me.cmd_閉じる)
        Me.Controls.Add(Me.cmd_EXCEL_IMPORT)
        Me.Controls.Add(Me.cmd_登録)
        Me.Name = "Form_f_M_RSRVH1_IMPORT_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "タスクNo.マスタ取込・貼付"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_閉じる As System.Windows.Forms.Button
    Friend WithEvents cmd_EXCEL_IMPORT As System.Windows.Forms.Button
    Friend WithEvents cmd_登録 As System.Windows.Forms.Button
    Friend WithEvents txt_RSRVH1_CD As System.Windows.Forms.TextBox
    Friend WithEvents txt_RSRVH1_NM As System.Windows.Forms.TextBox
    Friend WithEvents txt_BIKO As System.Windows.Forms.TextBox
    Friend WithEvents ラベル694 As System.Windows.Forms.Label
    Friend WithEvents ラベル697 As System.Windows.Forms.Label
    Friend WithEvents ラベル754 As System.Windows.Forms.Label
    Friend WithEvents ラベル826 As System.Windows.Forms.Label
    Friend WithEvents ラベル764 As System.Windows.Forms.Label
    Friend WithEvents ラベル763 As System.Windows.Forms.Label
    Friend WithEvents ラベル762 As System.Windows.Forms.Label
    Friend WithEvents ラベル765 As System.Windows.Forms.Label
    Friend WithEvents ラベル766 As System.Windows.Forms.Label

End Class