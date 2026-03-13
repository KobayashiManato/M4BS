<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_T_ZEI_KAISEI_CHANGE
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
        Me.KKYAK_DT_TO = New System.Windows.Forms.DateTimePicker()
        Me.KKYAK_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.TEKI_DT_TO = New System.Windows.Forms.DateTimePicker()
        Me.TEKI_DT_FROM = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_CD = New System.Windows.Forms.Label()
        Me.lbl_NM = New System.Windows.Forms.Label()
        Me.ラベル45 = New System.Windows.Forms.Label()
        Me.ラベル352 = New System.Windows.Forms.Label()
        Me.ラベル354 = New System.Windows.Forms.Label()
        Me.txt_ZRITU = New System.Windows.Forms.TextBox()
        Me.txt_ZEI_KAISEI_ID = New System.Windows.Forms.TextBox()
        Me.txt_CREATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_UPDATE_DT = New System.Windows.Forms.TextBox()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'KKYAK_DT_TO
        '
        Me.KKYAK_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.KKYAK_DT_TO.Location = New System.Drawing.Point(279, 263)
        Me.KKYAK_DT_TO.Name = "KKYAK_DT_TO"
        Me.KKYAK_DT_TO.Size = New System.Drawing.Size(200, 25)
        Me.KKYAK_DT_TO.TabIndex = 66
        Me.KKYAK_DT_TO.TabStop = False
        '
        'KKYAK_DT_FROM
        '
        Me.KKYAK_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.KKYAK_DT_FROM.Location = New System.Drawing.Point(279, 216)
        Me.KKYAK_DT_FROM.Name = "KKYAK_DT_FROM"
        Me.KKYAK_DT_FROM.Size = New System.Drawing.Size(200, 25)
        Me.KKYAK_DT_FROM.TabIndex = 65
        Me.KKYAK_DT_FROM.TabStop = False
        '
        'TEKI_DT_TO
        '
        Me.TEKI_DT_TO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TEKI_DT_TO.Location = New System.Drawing.Point(279, 129)
        Me.TEKI_DT_TO.Name = "TEKI_DT_TO"
        Me.TEKI_DT_TO.Size = New System.Drawing.Size(200, 25)
        Me.TEKI_DT_TO.TabIndex = 64
        Me.TEKI_DT_TO.TabStop = False
        '
        'TEKI_DT_FROM
        '
        Me.TEKI_DT_FROM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TEKI_DT_FROM.Location = New System.Drawing.Point(279, 88)
        Me.TEKI_DT_FROM.Name = "TEKI_DT_FROM"
        Me.TEKI_DT_FROM.Size = New System.Drawing.Size(200, 25)
        Me.TEKI_DT_FROM.TabIndex = 63
        Me.TEKI_DT_FROM.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 18)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "経過措置適用契約日・自"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 270)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "経過措置適用契約日・至"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "適用日・至"
        '
        'lbl_CD
        '
        Me.lbl_CD.AutoSize = True
        Me.lbl_CD.Location = New System.Drawing.Point(21, 93)
        Me.lbl_CD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_CD.Name = "lbl_CD"
        Me.lbl_CD.Size = New System.Drawing.Size(89, 18)
        Me.lbl_CD.TabIndex = 58
        Me.lbl_CD.Text = "適用日・自"
        '
        'lbl_NM
        '
        Me.lbl_NM.AutoSize = True
        Me.lbl_NM.Location = New System.Drawing.Point(21, 178)
        Me.lbl_NM.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_NM.Name = "lbl_NM"
        Me.lbl_NM.Size = New System.Drawing.Size(80, 18)
        Me.lbl_NM.TabIndex = 59
        Me.lbl_NM.Text = "消費税率"
        '
        'ラベル45
        '
        Me.ラベル45.AutoSize = True
        Me.ラベル45.Location = New System.Drawing.Point(457, 406)
        Me.ラベル45.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル45.Name = "ラベル45"
        Me.ラベル45.Size = New System.Drawing.Size(24, 18)
        Me.ラベル45.TabIndex = 60
        Me.ラベル45.Text = "ID"
        '
        'ラベル352
        '
        Me.ラベル352.AutoSize = True
        Me.ラベル352.Location = New System.Drawing.Point(457, 348)
        Me.ラベル352.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル352.Name = "ラベル352"
        Me.ラベル352.Size = New System.Drawing.Size(80, 18)
        Me.ラベル352.TabIndex = 61
        Me.ラベル352.Text = "作成日時"
        '
        'ラベル354
        '
        Me.ラベル354.AutoSize = True
        Me.ラベル354.Location = New System.Drawing.Point(457, 377)
        Me.ラベル354.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル354.Name = "ラベル354"
        Me.ラベル354.Size = New System.Drawing.Size(80, 18)
        Me.ラベル354.TabIndex = 62
        Me.ラベル354.Text = "更新日時"
        '
        'txt_ZRITU
        '
        Me.txt_ZRITU.Location = New System.Drawing.Point(279, 175)
        Me.txt_ZRITU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZRITU.Name = "txt_ZRITU"
        Me.txt_ZRITU.Size = New System.Drawing.Size(200, 25)
        Me.txt_ZRITU.TabIndex = 51
        '
        'txt_ZEI_KAISEI_ID
        '
        Me.txt_ZEI_KAISEI_ID.Location = New System.Drawing.Point(616, 406)
        Me.txt_ZEI_KAISEI_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_ZEI_KAISEI_ID.Name = "txt_ZEI_KAISEI_ID"
        Me.txt_ZEI_KAISEI_ID.ReadOnly = True
        Me.txt_ZEI_KAISEI_ID.Size = New System.Drawing.Size(122, 25)
        Me.txt_ZEI_KAISEI_ID.TabIndex = 52
        '
        'txt_CREATE_DT
        '
        Me.txt_CREATE_DT.Location = New System.Drawing.Point(616, 348)
        Me.txt_CREATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_CREATE_DT.TabIndex = 53
        '
        'txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.Location = New System.Drawing.Point(616, 377)
        Me.txt_UPDATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_UPDATE_DT.TabIndex = 54
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 48
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(147, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CREATE.TabIndex = 49
        Me.cmd_CREATE.Text = "変更登録(&S)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(279, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_DELETE.TabIndex = 50
        Me.cmd_DELETE.Text = "削除(&D)"
        Me.cmd_DELETE.UseVisualStyleBackColor = True
        '
        'Form_f_T_ZEI_KAISEI_CHANGE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 457)
        Me.Controls.Add(Me.KKYAK_DT_TO)
        Me.Controls.Add(Me.KKYAK_DT_FROM)
        Me.Controls.Add(Me.TEKI_DT_TO)
        Me.Controls.Add(Me.TEKI_DT_FROM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_CD)
        Me.Controls.Add(Me.lbl_NM)
        Me.Controls.Add(Me.ラベル45)
        Me.Controls.Add(Me.ラベル352)
        Me.Controls.Add(Me.ラベル354)
        Me.Controls.Add(Me.txt_ZRITU)
        Me.Controls.Add(Me.txt_ZEI_KAISEI_ID)
        Me.Controls.Add(Me.txt_CREATE_DT)
        Me.Controls.Add(Me.txt_UPDATE_DT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_DELETE)
        Me.Name = "Form_f_T_ZEI_KAISEI_CHANGE"
        Me.Text = "Form_f_T_ZEI_KAISEI_CHANGE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KKYAK_DT_TO As DateTimePicker
    Friend WithEvents KKYAK_DT_FROM As DateTimePicker
    Friend WithEvents TEKI_DT_TO As DateTimePicker
    Friend WithEvents TEKI_DT_FROM As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_CD As Label
    Friend WithEvents lbl_NM As Label
    Friend WithEvents ラベル45 As Label
    Friend WithEvents ラベル352 As Label
    Friend WithEvents ラベル354 As Label
    Friend WithEvents txt_ZRITU As TextBox
    Friend WithEvents txt_ZEI_KAISEI_ID As TextBox
    Friend WithEvents txt_CREATE_DT As TextBox
    Friend WithEvents txt_UPDATE_DT As TextBox
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents cmd_CREATE As Button
    Friend WithEvents cmd_DELETE As Button
End Class
