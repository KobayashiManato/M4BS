<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_M_CORP_CHANGE
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
        Me.cmb_CORP2_CD = New System.Windows.Forms.ComboBox()
        Me.cmb_CORP3_CD = New System.Windows.Forms.ComboBox()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.ラベル38 = New System.Windows.Forms.Label()
        Me.ラベル43 = New System.Windows.Forms.Label()
        Me.ラベル45 = New System.Windows.Forms.Label()
        Me.ラベル352 = New System.Windows.Forms.Label()
        Me.ラベル354 = New System.Windows.Forms.Label()
        Me.ラベル63 = New System.Windows.Forms.Label()
        Me.ラベル67 = New System.Windows.Forms.Label()
        Me.txt_CORP1_CD = New System.Windows.Forms.TextBox()
        Me.txt_CORP1_NM = New System.Windows.Forms.TextBox()
        Me.txt_BIKO = New System.Windows.Forms.TextBox()
        Me.txt_CORP_ID = New System.Windows.Forms.TextBox()
        Me.txt_CREATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_UPDATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_CORP2_NM = New System.Windows.Forms.TextBox()
        Me.txt_CORP3_NM = New System.Windows.Forms.TextBox()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_CORP2_CD
        '
        Me.cmb_CORP2_CD.FormattingEnabled = True
        Me.cmb_CORP2_CD.Location = New System.Drawing.Point(200, 164)
        Me.cmb_CORP2_CD.Name = "cmb_CORP2_CD"
        Me.cmb_CORP2_CD.Size = New System.Drawing.Size(169, 26)
        Me.cmb_CORP2_CD.TabIndex = 2
        '
        'cmb_CORP3_CD
        '
        Me.cmb_CORP3_CD.FormattingEnabled = True
        Me.cmb_CORP3_CD.Location = New System.Drawing.Point(200, 203)
        Me.cmb_CORP3_CD.Name = "cmb_CORP3_CD"
        Me.cmb_CORP3_CD.Size = New System.Drawing.Size(169, 26)
        Me.cmb_CORP3_CD.TabIndex = 4
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Location = New System.Drawing.Point(12, 84)
        Me.Lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(78, 18)
        Me.Lbl.TabIndex = 37
        Me.Lbl.Text = "会社ｺｰﾄﾞ"
        '
        'ラベル38
        '
        Me.ラベル38.AutoSize = True
        Me.ラベル38.Location = New System.Drawing.Point(12, 124)
        Me.ラベル38.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル38.Name = "ラベル38"
        Me.ラベル38.Size = New System.Drawing.Size(62, 18)
        Me.ラベル38.TabIndex = 38
        Me.ラベル38.Text = "会社名"
        '
        'ラベル43
        '
        Me.ラベル43.AutoSize = True
        Me.ラベル43.Location = New System.Drawing.Point(12, 243)
        Me.ラベル43.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル43.Name = "ラベル43"
        Me.ラベル43.Size = New System.Drawing.Size(44, 18)
        Me.ラベル43.TabIndex = 39
        Me.ラベル43.Text = "備考"
        '
        'ラベル45
        '
        Me.ラベル45.AutoSize = True
        Me.ラベル45.Location = New System.Drawing.Point(458, 357)
        Me.ラベル45.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル45.Name = "ラベル45"
        Me.ラベル45.Size = New System.Drawing.Size(24, 18)
        Me.ラベル45.TabIndex = 40
        Me.ラベル45.Text = "ID"
        '
        'ラベル352
        '
        Me.ラベル352.AutoSize = True
        Me.ラベル352.Location = New System.Drawing.Point(458, 300)
        Me.ラベル352.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル352.Name = "ラベル352"
        Me.ラベル352.Size = New System.Drawing.Size(80, 18)
        Me.ラベル352.TabIndex = 41
        Me.ラベル352.Text = "作成日時"
        '
        'ラベル354
        '
        Me.ラベル354.AutoSize = True
        Me.ラベル354.Location = New System.Drawing.Point(458, 328)
        Me.ラベル354.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル354.Name = "ラベル354"
        Me.ラベル354.Size = New System.Drawing.Size(80, 18)
        Me.ラベル354.TabIndex = 42
        Me.ラベル354.Text = "更新日時"
        '
        'ラベル63
        '
        Me.ラベル63.AutoSize = True
        Me.ラベル63.Location = New System.Drawing.Point(12, 164)
        Me.ラベル63.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル63.Name = "ラベル63"
        Me.ラベル63.Size = New System.Drawing.Size(53, 18)
        Me.ラベル63.TabIndex = 43
        Me.ラベル63.Text = "会社2"
        '
        'ラベル67
        '
        Me.ラベル67.AutoSize = True
        Me.ラベル67.Location = New System.Drawing.Point(12, 204)
        Me.ラベル67.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル67.Name = "ラベル67"
        Me.ラベル67.Size = New System.Drawing.Size(53, 18)
        Me.ラベル67.TabIndex = 44
        Me.ラベル67.Text = "会社3"
        '
        'txt_CORP1_CD
        '
        Me.txt_CORP1_CD.Location = New System.Drawing.Point(200, 84)
        Me.txt_CORP1_CD.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CORP1_CD.Name = "txt_CORP1_CD"
        Me.txt_CORP1_CD.Size = New System.Drawing.Size(154, 25)
        Me.txt_CORP1_CD.TabIndex = 0
        '
        'txt_CORP1_NM
        '
        Me.txt_CORP1_NM.Location = New System.Drawing.Point(200, 124)
        Me.txt_CORP1_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CORP1_NM.Name = "txt_CORP1_NM"
        Me.txt_CORP1_NM.Size = New System.Drawing.Size(437, 25)
        Me.txt_CORP1_NM.TabIndex = 1
        '
        'txt_BIKO
        '
        Me.txt_BIKO.Location = New System.Drawing.Point(200, 243)
        Me.txt_BIKO.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_BIKO.Name = "txt_BIKO"
        Me.txt_BIKO.Size = New System.Drawing.Size(437, 25)
        Me.txt_BIKO.TabIndex = 6
        '
        'txt_CORP_ID
        '
        Me.txt_CORP_ID.Location = New System.Drawing.Point(617, 357)
        Me.txt_CORP_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CORP_ID.Name = "txt_CORP_ID"
        Me.txt_CORP_ID.ReadOnly = True
        Me.txt_CORP_ID.Size = New System.Drawing.Size(122, 25)
        Me.txt_CORP_ID.TabIndex = 32
        Me.txt_CORP_ID.TabStop = False
        '
        'txt_CREATE_DT
        '
        Me.txt_CREATE_DT.Location = New System.Drawing.Point(617, 300)
        Me.txt_CREATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_CREATE_DT.TabIndex = 33
        Me.txt_CREATE_DT.TabStop = False
        '
        'txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.Location = New System.Drawing.Point(617, 328)
        Me.txt_UPDATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_UPDATE_DT.TabIndex = 34
        Me.txt_UPDATE_DT.TabStop = False
        '
        'txt_CORP2_NM
        '
        Me.txt_CORP2_NM.Location = New System.Drawing.Point(377, 164)
        Me.txt_CORP2_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CORP2_NM.Name = "txt_CORP2_NM"
        Me.txt_CORP2_NM.Size = New System.Drawing.Size(437, 25)
        Me.txt_CORP2_NM.TabIndex = 3
        '
        'txt_CORP3_NM
        '
        Me.txt_CORP3_NM.Location = New System.Drawing.Point(377, 204)
        Me.txt_CORP3_NM.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CORP3_NM.Name = "txt_CORP3_NM"
        Me.txt_CORP3_NM.Size = New System.Drawing.Size(437, 25)
        Me.txt_CORP3_NM.TabIndex = 5
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 9
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(149, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(157, 39)
        Me.cmd_CREATE.TabIndex = 7
        Me.cmd_CREATE.Text = "変更登録(&S)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(316, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_DELETE.TabIndex = 8
        Me.cmd_DELETE.Text = "削除(&D)"
        Me.cmd_DELETE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 18)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "既存コードを指定すると統合できます。"
        '
        'Form_f_M_CORP_CHANGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_CORP2_CD)
        Me.Controls.Add(Me.cmb_CORP3_CD)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.ラベル38)
        Me.Controls.Add(Me.ラベル43)
        Me.Controls.Add(Me.ラベル45)
        Me.Controls.Add(Me.ラベル352)
        Me.Controls.Add(Me.ラベル354)
        Me.Controls.Add(Me.ラベル63)
        Me.Controls.Add(Me.ラベル67)
        Me.Controls.Add(Me.txt_CORP1_CD)
        Me.Controls.Add(Me.txt_CORP1_NM)
        Me.Controls.Add(Me.txt_BIKO)
        Me.Controls.Add(Me.txt_CORP_ID)
        Me.Controls.Add(Me.txt_CREATE_DT)
        Me.Controls.Add(Me.txt_UPDATE_DT)
        Me.Controls.Add(Me.txt_CORP2_NM)
        Me.Controls.Add(Me.txt_CORP3_NM)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_DELETE)
        Me.KeyPreview = True
        Me.Name = "Form_f_M_CORP_CHANGE"
        Me.Text = "会社マスタ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_CORP2_CD As ComboBox
    Friend WithEvents cmb_CORP3_CD As ComboBox
    Friend WithEvents Lbl As Label
    Friend WithEvents ラベル38 As Label
    Friend WithEvents ラベル43 As Label
    Friend WithEvents ラベル45 As Label
    Friend WithEvents ラベル352 As Label
    Friend WithEvents ラベル354 As Label
    Friend WithEvents ラベル63 As Label
    Friend WithEvents ラベル67 As Label
    Friend WithEvents txt_CORP1_CD As TextBox
    Friend WithEvents txt_CORP1_NM As TextBox
    Friend WithEvents txt_BIKO As TextBox
    Friend WithEvents txt_CORP_ID As TextBox
    Friend WithEvents txt_CREATE_DT As TextBox
    Friend WithEvents txt_UPDATE_DT As TextBox
    Friend WithEvents txt_CORP2_NM As TextBox
    Friend WithEvents txt_CORP3_NM As TextBox
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents cmd_CREATE As Button
    Friend WithEvents cmd_DELETE As Button
    Friend WithEvents Label1 As Label
End Class
