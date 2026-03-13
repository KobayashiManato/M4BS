<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_f_T_KARI_RITU_INP
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
        Me.lbl_CD = New System.Windows.Forms.Label()
        Me.lbl_NM = New System.Windows.Forms.Label()
        Me.ラベル45 = New System.Windows.Forms.Label()
        Me.ラベル352 = New System.Windows.Forms.Label()
        Me.ラベル354 = New System.Windows.Forms.Label()
        Me.txt_KARI_RITU = New System.Windows.Forms.TextBox()
        Me.txt_KARI_RITU_ID = New System.Windows.Forms.TextBox()
        Me.txt_CREATE_DT = New System.Windows.Forms.TextBox()
        Me.txt_UPDATE_DT = New System.Windows.Forms.TextBox()
        Me.cmd_CLOSE = New System.Windows.Forms.Button()
        Me.cmd_CREATE = New System.Windows.Forms.Button()
        Me.cmd_DELETE = New System.Windows.Forms.Button()
        Me.START_DT = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lbl_CD
        '
        Me.lbl_CD.AutoSize = True
        Me.lbl_CD.Location = New System.Drawing.Point(21, 93)
        Me.lbl_CD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_CD.Name = "lbl_CD"
        Me.lbl_CD.Size = New System.Drawing.Size(98, 18)
        Me.lbl_CD.TabIndex = 28
        Me.lbl_CD.Text = "適用開始日"
        '
        'lbl_NM
        '
        Me.lbl_NM.AutoSize = True
        Me.lbl_NM.Location = New System.Drawing.Point(21, 133)
        Me.lbl_NM.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_NM.Name = "lbl_NM"
        Me.lbl_NM.Size = New System.Drawing.Size(134, 18)
        Me.lbl_NM.TabIndex = 29
        Me.lbl_NM.Text = "追加借入利子率"
        '
        'ラベル45
        '
        Me.ラベル45.AutoSize = True
        Me.ラベル45.Location = New System.Drawing.Point(467, 287)
        Me.ラベル45.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル45.Name = "ラベル45"
        Me.ラベル45.Size = New System.Drawing.Size(24, 18)
        Me.ラベル45.TabIndex = 31
        Me.ラベル45.Text = "ID"
        '
        'ラベル352
        '
        Me.ラベル352.AutoSize = True
        Me.ラベル352.Location = New System.Drawing.Point(467, 229)
        Me.ラベル352.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル352.Name = "ラベル352"
        Me.ラベル352.Size = New System.Drawing.Size(80, 18)
        Me.ラベル352.TabIndex = 32
        Me.ラベル352.Text = "作成日時"
        '
        'ラベル354
        '
        Me.ラベル354.AutoSize = True
        Me.ラベル354.Location = New System.Drawing.Point(467, 258)
        Me.ラベル354.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ラベル354.Name = "ラベル354"
        Me.ラベル354.Size = New System.Drawing.Size(80, 18)
        Me.ラベル354.TabIndex = 33
        Me.ラベル354.Text = "更新日時"
        '
        'txt_KARI_RITU
        '
        Me.txt_KARI_RITU.Location = New System.Drawing.Point(223, 133)
        Me.txt_KARI_RITU.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KARI_RITU.Name = "txt_KARI_RITU"
        Me.txt_KARI_RITU.Size = New System.Drawing.Size(423, 25)
        Me.txt_KARI_RITU.TabIndex = 23
        '
        'txt_KARI_RITU_ID
        '
        Me.txt_KARI_RITU_ID.Location = New System.Drawing.Point(626, 287)
        Me.txt_KARI_RITU_ID.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_KARI_RITU_ID.Name = "txt_KARI_RITU_ID"
        Me.txt_KARI_RITU_ID.ReadOnly = True
        Me.txt_KARI_RITU_ID.Size = New System.Drawing.Size(122, 25)
        Me.txt_KARI_RITU_ID.TabIndex = 25
        '
        'txt_CREATE_DT
        '
        Me.txt_CREATE_DT.Location = New System.Drawing.Point(626, 229)
        Me.txt_CREATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_CREATE_DT.Name = "txt_CREATE_DT"
        Me.txt_CREATE_DT.ReadOnly = True
        Me.txt_CREATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_CREATE_DT.TabIndex = 26
        '
        'txt_UPDATE_DT
        '
        Me.txt_UPDATE_DT.Location = New System.Drawing.Point(626, 258)
        Me.txt_UPDATE_DT.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_UPDATE_DT.Name = "txt_UPDATE_DT"
        Me.txt_UPDATE_DT.ReadOnly = True
        Me.txt_UPDATE_DT.Size = New System.Drawing.Size(204, 25)
        Me.txt_UPDATE_DT.TabIndex = 27
        '
        'cmd_CLOSE
        '
        Me.cmd_CLOSE.Location = New System.Drawing.Point(14, 13)
        Me.cmd_CLOSE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CLOSE.Name = "cmd_CLOSE"
        Me.cmd_CLOSE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CLOSE.TabIndex = 19
        Me.cmd_CLOSE.Text = "閉じる(&C)"
        Me.cmd_CLOSE.UseVisualStyleBackColor = True
        '
        'cmd_CREATE
        '
        Me.cmd_CREATE.Location = New System.Drawing.Point(147, 13)
        Me.cmd_CREATE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_CREATE.Name = "cmd_CREATE"
        Me.cmd_CREATE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_CREATE.TabIndex = 20
        Me.cmd_CREATE.Text = "登録(&S)"
        Me.cmd_CREATE.UseVisualStyleBackColor = True
        '
        'cmd_DELETE
        '
        Me.cmd_DELETE.Location = New System.Drawing.Point(279, 13)
        Me.cmd_DELETE.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmd_DELETE.Name = "cmd_DELETE"
        Me.cmd_DELETE.Size = New System.Drawing.Size(125, 39)
        Me.cmd_DELETE.TabIndex = 21
        Me.cmd_DELETE.Text = "削除(&D)"
        Me.cmd_DELETE.UseVisualStyleBackColor = True
        '
        'START_DT
        '
        Me.START_DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.START_DT.Location = New System.Drawing.Point(223, 88)
        Me.START_DT.Name = "START_DT"
        Me.START_DT.Size = New System.Drawing.Size(200, 25)
        Me.START_DT.TabIndex = 34
        Me.START_DT.TabStop = False
        '
        'Form_f_T_KARI_RITU_INP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 365)
        Me.Controls.Add(Me.START_DT)
        Me.Controls.Add(Me.lbl_CD)
        Me.Controls.Add(Me.lbl_NM)
        Me.Controls.Add(Me.ラベル45)
        Me.Controls.Add(Me.ラベル352)
        Me.Controls.Add(Me.ラベル354)
        Me.Controls.Add(Me.txt_KARI_RITU)
        Me.Controls.Add(Me.txt_KARI_RITU_ID)
        Me.Controls.Add(Me.txt_CREATE_DT)
        Me.Controls.Add(Me.txt_UPDATE_DT)
        Me.Controls.Add(Me.cmd_CLOSE)
        Me.Controls.Add(Me.cmd_CREATE)
        Me.Controls.Add(Me.cmd_DELETE)
        Me.Name = "Form_f_T_KARI_RITU_INP"
        Me.Text = "Form_f_T_KARI_RITU_INP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_CD As Label
    Friend WithEvents lbl_NM As Label
    Friend WithEvents ラベル45 As Label
    Friend WithEvents ラベル352 As Label
    Friend WithEvents ラベル354 As Label
    Friend WithEvents txt_KARI_RITU As TextBox
    Friend WithEvents txt_KARI_RITU_ID As TextBox
    Friend WithEvents txt_CREATE_DT As TextBox
    Friend WithEvents txt_UPDATE_DT As TextBox
    Friend WithEvents cmd_CLOSE As Button
    Friend WithEvents cmd_CREATE As Button
    Friend WithEvents cmd_DELETE As Button
    Friend WithEvents START_DT As DateTimePicker
End Class
