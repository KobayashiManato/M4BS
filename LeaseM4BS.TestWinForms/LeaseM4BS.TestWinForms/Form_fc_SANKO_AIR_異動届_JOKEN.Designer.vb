<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_SANKO_AIR_異動届_JOKEN

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
        Me.cmd_実行 = New System.Windows.Forms.Button()
        Me.cmd_CANCEL = New System.Windows.Forms.Button()
        Me.txt_KIKAN_FROM = New System.Windows.Forms.TextBox()
        Me.txt_KIKAN_TO = New System.Windows.Forms.TextBox()
        Me.txt_ADDRESS1 = New System.Windows.Forms.TextBox()
        Me.txt_ADDRESS2 = New System.Windows.Forms.TextBox()
        Me.txt_ADDRESS3 = New System.Windows.Forms.TextBox()
        Me.ラベル471 = New System.Windows.Forms.Label()
        Me.lbl_終了日 = New System.Windows.Forms.Label()
        Me.ラベル513 = New System.Windows.Forms.Label()
        Me.ラベル488 = New System.Windows.Forms.Label()
        Me.ラベル490 = New System.Windows.Forms.Label()
        Me.lbl_出力元の抽出 = New System.Windows.Forms.Label()
        Me.lbl_CHK_01 = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.ラベル1 = New System.Windows.Forms.Label()
        Me.ラベル23 = New System.Windows.Forms.Label()
        Me.ラベル2 = New System.Windows.Forms.Label()
        Me.ラベル0 = New System.Windows.Forms.Label()
        Me.ラベル3 = New System.Windows.Forms.Label()
        Me.ラベル4 = New System.Windows.Forms.Label()
        Me.ラベル5 = New System.Windows.Forms.Label()
        Me.ラベル6 = New System.Windows.Forms.Label()
        Me.ラベル7 = New System.Windows.Forms.Label()
        Me.chk_KJOKEN_KAMI_F = New System.Windows.Forms.CheckBox()
        Me.chk_OUTPUT_KYKH_MS_F = New System.Windows.Forms.CheckBox()
        Me.オプション487 = New System.Windows.Forms.RadioButton()
        Me.オプション489 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        ' cmd_実行
        '
        Me.cmd_実行.Location = New System.Drawing.Point(3, 3)
        Me.cmd_実行.Name = "cmd_実行"
        Me.cmd_実行.Size = New System.Drawing.Size(75, 26)
        Me.cmd_実行.TabIndex = 0
        Me.cmd_実行.Text = "実行(&R)"
        Me.cmd_実行.UseVisualStyleBackColor = True
        '
        ' cmd_CANCEL
        '
        Me.cmd_CANCEL.Location = New System.Drawing.Point(86, 3)
        Me.cmd_CANCEL.Name = "cmd_CANCEL"
        Me.cmd_CANCEL.Size = New System.Drawing.Size(75, 26)
        Me.cmd_CANCEL.TabIndex = 1
        Me.cmd_CANCEL.Text = "ｷｬﾝｾﾙ(&C)"
        Me.cmd_CANCEL.UseVisualStyleBackColor = True
        '
        ' txt_KIKAN_FROM
        '
        Me.txt_KIKAN_FROM.Location = New System.Drawing.Point(151, 94)
        Me.txt_KIKAN_FROM.Name = "txt_KIKAN_FROM"
        Me.txt_KIKAN_FROM.Size = New System.Drawing.Size(75, 19)
        Me.txt_KIKAN_FROM.TabIndex = 2
        '
        ' txt_KIKAN_TO
        '
        Me.txt_KIKAN_TO.Location = New System.Drawing.Point(245, 94)
        Me.txt_KIKAN_TO.Name = "txt_KIKAN_TO"
        Me.txt_KIKAN_TO.Size = New System.Drawing.Size(75, 19)
        Me.txt_KIKAN_TO.TabIndex = 3
        '
        ' txt_ADDRESS1
        '
        Me.txt_ADDRESS1.Location = New System.Drawing.Point(151, 245)
        Me.txt_ADDRESS1.Name = "txt_ADDRESS1"
        Me.txt_ADDRESS1.Size = New System.Drawing.Size(264, 19)
        Me.txt_ADDRESS1.TabIndex = 4
        '
        ' txt_ADDRESS2
        '
        Me.txt_ADDRESS2.Location = New System.Drawing.Point(151, 264)
        Me.txt_ADDRESS2.Name = "txt_ADDRESS2"
        Me.txt_ADDRESS2.Size = New System.Drawing.Size(264, 19)
        Me.txt_ADDRESS2.TabIndex = 5
        '
        ' txt_ADDRESS3
        '
        Me.txt_ADDRESS3.Location = New System.Drawing.Point(151, 283)
        Me.txt_ADDRESS3.Name = "txt_ADDRESS3"
        Me.txt_ADDRESS3.Size = New System.Drawing.Size(117, 26)
        Me.txt_ADDRESS3.TabIndex = 6
        '
        ' ラベル471
        '
        Me.ラベル471.AutoSize = True
        Me.ラベル471.Location = New System.Drawing.Point(226, 94)
        Me.ラベル471.Name = "ラベル471"
        Me.ラベル471.TabIndex = 7
        Me.ラベル471.Text = "～"
        '
        ' lbl_終了日
        '
        Me.lbl_終了日.AutoSize = True
        Me.lbl_終了日.Location = New System.Drawing.Point(37, 94)
        Me.lbl_終了日.Name = "lbl_終了日"
        Me.lbl_終了日.TabIndex = 8
        Me.lbl_終了日.Text = "終了日"
        '
        ' ラベル513
        '
        Me.ラベル513.AutoSize = True
        Me.ラベル513.Location = New System.Drawing.Point(151, 117)
        Me.ラベル513.Name = "ラベル513"
        Me.ラベル513.TabIndex = 9
        Me.ラベル513.Text = "yyyy/mm/dd の形式で入力してください"
        '
        ' ラベル488
        '
        Me.ラベル488.AutoSize = True
        Me.ラベル488.Location = New System.Drawing.Point(181, 60)
        Me.ラベル488.Name = "ラベル488"
        Me.ラベル488.TabIndex = 10
        Me.ラベル488.Text = "再ﾘｰｽ/返却"
        '
        ' ラベル490
        '
        Me.ラベル490.AutoSize = True
        Me.ラベル490.Location = New System.Drawing.Point(294, 60)
        Me.ラベル490.Name = "ラベル490"
        Me.ラベル490.TabIndex = 11
        Me.ラベル490.Text = "中途解約"
        '
        ' lbl_出力元の抽出
        '
        Me.lbl_出力元の抽出.AutoSize = True
        Me.lbl_出力元の抽出.Location = New System.Drawing.Point(37, 188)
        Me.lbl_出力元の抽出.Name = "lbl_出力元の抽出"
        Me.lbl_出力元の抽出.TabIndex = 12
        Me.lbl_出力元の抽出.Text = "出力元の抽出"
        '
        ' lbl_CHK_01
        '
        Me.lbl_CHK_01.AutoSize = True
        Me.lbl_CHK_01.Location = New System.Drawing.Point(181, 192)
        Me.lbl_CHK_01.Name = "lbl_CHK_01"
        Me.lbl_CHK_01.TabIndex = 13
        Me.lbl_CHK_01.Text = "検索条件を加味する"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(151, 211)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 14
        Me.lbl_EXPLANATION1.Text = "※契約書ﾌﾚｯｸｽを検索条件で抽出した結果に対して上記終了日による\015\012　抽出を行います。"
        '
        ' ラベル1
        '
        Me.ラベル1.AutoSize = True
        Me.ラベル1.Location = New System.Drawing.Point(37, 245)
        Me.ラベル1.Name = "ラベル1"
        Me.ラベル1.TabIndex = 15
        Me.ラベル1.Text = "届先"
        '
        ' ラベル23
        '
        Me.ラベル23.AutoSize = True
        Me.ラベル23.Location = New System.Drawing.Point(181, 325)
        Me.ラベル23.Name = "ラベル23"
        Me.ラベル23.TabIndex = 16
        Me.ラベル23.Text = "契約書を印刷しない"
        '
        ' ラベル2
        '
        Me.ラベル2.AutoSize = True
        Me.ラベル2.Location = New System.Drawing.Point(37, 321)
        Me.ラベル2.Name = "ラベル2"
        Me.ラベル2.TabIndex = 17
        Me.ラベル2.Text = "契約書印刷"
        '
        ' ラベル0
        '
        Me.ラベル0.AutoSize = True
        Me.ラベル0.Location = New System.Drawing.Point(37, 56)
        Me.ラベル0.Name = "ラベル0"
        Me.ラベル0.TabIndex = 18
        Me.ラベル0.Text = "処理種別"
        '
        ' ラベル3
        '
        Me.ラベル3.AutoSize = True
        Me.ラベル3.Location = New System.Drawing.Point(151, 139)
        Me.ラベル3.Name = "ラベル3"
        Me.ラベル3.TabIndex = 19
        Me.ラベル3.Text = "- 処理種別が「再ﾘｰｽ/返却」の場合、契約終了日を検索"
        '
        ' ラベル4
        '
        Me.ラベル4.AutoSize = True
        Me.ラベル4.Location = New System.Drawing.Point(151, 158)
        Me.ラベル4.Name = "ラベル4"
        Me.ラベル4.TabIndex = 20
        Me.ラベル4.Text = "- 処理種別が「中途解約」の場合、中途解約日を検索"
        '
        ' ラベル5
        '
        Me.ラベル5.AutoSize = True
        Me.ラベル5.Location = New System.Drawing.Point(151, 343)
        Me.ラベル5.Name = "ラベル5"
        Me.ラベル5.TabIndex = 21
        Me.ラベル5.Text = "※チェックを外すと「リース契約の内容」欄に　\"
        '
        ' ラベル6
        '
        Me.ラベル6.AutoSize = True
        Me.ラベル6.Location = New System.Drawing.Point(37, 283)
        Me.ラベル6.Name = "ラベル6"
        Me.ラベル6.TabIndex = 22
        Me.ラベル6.Text = "検印欄見出し(左)"
        '
        ' ラベル7
        '
        Me.ラベル7.AutoSize = True
        Me.ラベル7.Location = New System.Drawing.Point(272, 287)
        Me.ラベル7.Name = "ラベル7"
        Me.ラベル7.TabIndex = 23
        Me.ラベル7.Text = "※CTRL+ENTERキーで改行を入力できます。"
        '
        ' chk_KJOKEN_KAMI_F
        '
        Me.chk_KJOKEN_KAMI_F.AutoSize = True
        Me.chk_KJOKEN_KAMI_F.Location = New System.Drawing.Point(166, 192)
        Me.chk_KJOKEN_KAMI_F.Name = "chk_KJOKEN_KAMI_F"
        Me.chk_KJOKEN_KAMI_F.TabIndex = 24
        Me.chk_KJOKEN_KAMI_F.Text = ""
        Me.chk_KJOKEN_KAMI_F.UseVisualStyleBackColor = True
        '
        ' chk_OUTPUT_KYKH_MS_F
        '
        Me.chk_OUTPUT_KYKH_MS_F.AutoSize = True
        Me.chk_OUTPUT_KYKH_MS_F.Location = New System.Drawing.Point(166, 325)
        Me.chk_OUTPUT_KYKH_MS_F.Name = "chk_OUTPUT_KYKH_MS_F"
        Me.chk_OUTPUT_KYKH_MS_F.TabIndex = 25
        Me.chk_OUTPUT_KYKH_MS_F.Text = ""
        Me.chk_OUTPUT_KYKH_MS_F.UseVisualStyleBackColor = True
        '
        ' オプション487
        '
        Me.オプション487.AutoSize = True
        Me.オプション487.Location = New System.Drawing.Point(166, 60)
        Me.オプション487.Name = "オプション487"
        Me.オプション487.TabIndex = 26
        Me.オプション487.Text = ""
        Me.オプション487.UseVisualStyleBackColor = True
        '
        ' オプション489
        '
        Me.オプション489.AutoSize = True
        Me.オプション489.Location = New System.Drawing.Point(279, 60)
        Me.オプション489.Name = "オプション489"
        Me.オプション489.TabIndex = 27
        Me.オプション489.Text = ""
        Me.オプション489.UseVisualStyleBackColor = True
        '
        ' Form_fc_SANKO_AIR_異動届_JOKEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 612)
        Me.Controls.Add(Me.オプション487)
        Me.Controls.Add(Me.オプション489)
        Me.Controls.Add(Me.chk_KJOKEN_KAMI_F)
        Me.Controls.Add(Me.chk_OUTPUT_KYKH_MS_F)
        Me.Controls.Add(Me.ラベル471)
        Me.Controls.Add(Me.lbl_終了日)
        Me.Controls.Add(Me.ラベル513)
        Me.Controls.Add(Me.ラベル488)
        Me.Controls.Add(Me.ラベル490)
        Me.Controls.Add(Me.lbl_出力元の抽出)
        Me.Controls.Add(Me.lbl_CHK_01)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.ラベル1)
        Me.Controls.Add(Me.ラベル23)
        Me.Controls.Add(Me.ラベル2)
        Me.Controls.Add(Me.ラベル0)
        Me.Controls.Add(Me.ラベル3)
        Me.Controls.Add(Me.ラベル4)
        Me.Controls.Add(Me.ラベル5)
        Me.Controls.Add(Me.ラベル6)
        Me.Controls.Add(Me.ラベル7)
        Me.Controls.Add(Me.txt_KIKAN_FROM)
        Me.Controls.Add(Me.txt_KIKAN_TO)
        Me.Controls.Add(Me.txt_ADDRESS1)
        Me.Controls.Add(Me.txt_ADDRESS2)
        Me.Controls.Add(Me.txt_ADDRESS3)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Name = "Form_fc_SANKO_AIR_異動届_JOKEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "リース契約　異動届"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents txt_KIKAN_FROM As System.Windows.Forms.TextBox
    Friend WithEvents txt_KIKAN_TO As System.Windows.Forms.TextBox
    Friend WithEvents txt_ADDRESS1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ADDRESS2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_ADDRESS3 As System.Windows.Forms.TextBox
    Friend WithEvents ラベル471 As System.Windows.Forms.Label
    Friend WithEvents lbl_終了日 As System.Windows.Forms.Label
    Friend WithEvents ラベル513 As System.Windows.Forms.Label
    Friend WithEvents ラベル488 As System.Windows.Forms.Label
    Friend WithEvents ラベル490 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力元の抽出 As System.Windows.Forms.Label
    Friend WithEvents lbl_CHK_01 As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents ラベル1 As System.Windows.Forms.Label
    Friend WithEvents ラベル23 As System.Windows.Forms.Label
    Friend WithEvents ラベル2 As System.Windows.Forms.Label
    Friend WithEvents ラベル0 As System.Windows.Forms.Label
    Friend WithEvents ラベル3 As System.Windows.Forms.Label
    Friend WithEvents ラベル4 As System.Windows.Forms.Label
    Friend WithEvents ラベル5 As System.Windows.Forms.Label
    Friend WithEvents ラベル6 As System.Windows.Forms.Label
    Friend WithEvents ラベル7 As System.Windows.Forms.Label
    Friend WithEvents chk_KJOKEN_KAMI_F As System.Windows.Forms.CheckBox
    Friend WithEvents chk_OUTPUT_KYKH_MS_F As System.Windows.Forms.CheckBox
    Friend WithEvents オプション487 As System.Windows.Forms.RadioButton
    Friend WithEvents オプション489 As System.Windows.Forms.RadioButton

End Class