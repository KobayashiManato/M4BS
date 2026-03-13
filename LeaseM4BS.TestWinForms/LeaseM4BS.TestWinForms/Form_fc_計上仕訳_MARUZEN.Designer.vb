<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_計上仕訳_MARUZEN

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
        Me.cmd_選択2 = New System.Windows.Forms.Button()
        Me.cmd_選択1 = New System.Windows.Forms.Button()
        Me.txt_出力年月 = New System.Windows.Forms.TextBox()
        Me.txt_伝票日付 = New System.Windows.Forms.TextBox()
        Me.txt_部署コード_一括用 = New System.Windows.Forms.TextBox()
        Me.txt_FileNM = New System.Windows.Forms.TextBox()
        Me.txt_FolderNM = New System.Windows.Forms.TextBox()
        Me.txt_承認日付 = New System.Windows.Forms.TextBox()
        Me.txt_科目コード_未払金 = New System.Windows.Forms.TextBox()
        Me.txt_部署コード_減損用 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_SLIP_DT = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_TITL = New System.Windows.Forms.Label()
        Me.ラベル22 = New System.Windows.Forms.Label()
        Me.ラベル49 = New System.Windows.Forms.Label()
        Me.ラベル51 = New System.Windows.Forms.Label()
        Me.lbl_出力先EXCELﾌｧｲﾙ名 = New System.Windows.Forms.Label()
        Me.lbl_OUTPUT_FOLDER_NM = New System.Windows.Forms.Label()
        Me.ラベル53 = New System.Windows.Forms.Label()
        Me.ラベル55 = New System.Windows.Forms.Label()
        Me.ラベル57 = New System.Windows.Forms.Label()
        Me.ラベル59 = New System.Windows.Forms.Label()
        Me.ラベル60 = New System.Windows.Forms.Label()
        Me.chk_検索条件加味F = New System.Windows.Forms.CheckBox()
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
        ' cmd_選択2
        '
        Me.cmd_選択2.Location = New System.Drawing.Point(521, 498)
        Me.cmd_選択2.Name = "cmd_選択2"
        Me.cmd_選択2.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択2.TabIndex = 2
        Me.cmd_選択2.Text = "選択(&S)"
        Me.cmd_選択2.UseVisualStyleBackColor = True
        '
        ' cmd_選択1
        '
        Me.cmd_選択1.Location = New System.Drawing.Point(521, 377)
        Me.cmd_選択1.Name = "cmd_選択1"
        Me.cmd_選択1.Size = New System.Drawing.Size(75, 23)
        Me.cmd_選択1.TabIndex = 3
        Me.cmd_選択1.Text = "選択(&F)"
        Me.cmd_選択1.UseVisualStyleBackColor = True
        '
        ' txt_出力年月
        '
        Me.txt_出力年月.Location = New System.Drawing.Point(139, 45)
        Me.txt_出力年月.Name = "txt_出力年月"
        Me.txt_出力年月.Size = New System.Drawing.Size(78, 19)
        Me.txt_出力年月.TabIndex = 4
        '
        ' txt_伝票日付
        '
        Me.txt_伝票日付.Location = New System.Drawing.Point(139, 151)
        Me.txt_伝票日付.Name = "txt_伝票日付"
        Me.txt_伝票日付.Size = New System.Drawing.Size(90, 19)
        Me.txt_伝票日付.TabIndex = 5
        '
        ' txt_部署コード_一括用
        '
        Me.txt_部署コード_一括用.Location = New System.Drawing.Point(139, 204)
        Me.txt_部署コード_一括用.Name = "txt_部署コード_一括用"
        Me.txt_部署コード_一括用.Size = New System.Drawing.Size(90, 19)
        Me.txt_部署コード_一括用.TabIndex = 6
        '
        ' txt_FileNM
        '
        Me.txt_FileNM.Location = New System.Drawing.Point(139, 498)
        Me.txt_FileNM.Name = "txt_FileNM"
        Me.txt_FileNM.Size = New System.Drawing.Size(378, 19)
        Me.txt_FileNM.TabIndex = 7
        '
        ' txt_FolderNM
        '
        Me.txt_FolderNM.Location = New System.Drawing.Point(139, 377)
        Me.txt_FolderNM.Name = "txt_FolderNM"
        Me.txt_FolderNM.Size = New System.Drawing.Size(378, 19)
        Me.txt_FolderNM.TabIndex = 8
        '
        ' txt_承認日付
        '
        Me.txt_承認日付.Location = New System.Drawing.Point(139, 170)
        Me.txt_承認日付.Name = "txt_承認日付"
        Me.txt_承認日付.Size = New System.Drawing.Size(90, 19)
        Me.txt_承認日付.TabIndex = 9
        '
        ' txt_科目コード_未払金
        '
        Me.txt_科目コード_未払金.Location = New System.Drawing.Point(139, 241)
        Me.txt_科目コード_未払金.Name = "txt_科目コード_未払金"
        Me.txt_科目コード_未払金.Size = New System.Drawing.Size(90, 19)
        Me.txt_科目コード_未払金.TabIndex = 10
        '
        ' txt_部署コード_減損用
        '
        Me.txt_部署コード_減損用.Location = New System.Drawing.Point(139, 222)
        Me.txt_部署コード_減損用.Name = "txt_部署コード_減損用"
        Me.txt_部署コード_減損用.Size = New System.Drawing.Size(90, 19)
        Me.txt_部署コード_減損用.TabIndex = 11
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(143, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 12
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_SLIP_DT
        '
        Me.lbl_SLIP_DT.AutoSize = True
        Me.lbl_SLIP_DT.Location = New System.Drawing.Point(26, 45)
        Me.lbl_SLIP_DT.Name = "lbl_SLIP_DT"
        Me.lbl_SLIP_DT.TabIndex = 13
        Me.lbl_SLIP_DT.Text = "出力年月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(143, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 14
        Me.lbl_EXPLANATION1.Text = "※月次仕訳計上ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_TITL
        '
        Me.lbl_TITL.AutoSize = True
        Me.lbl_TITL.Location = New System.Drawing.Point(26, 75)
        Me.lbl_TITL.Name = "lbl_TITL"
        Me.lbl_TITL.TabIndex = 15
        Me.lbl_TITL.Text = "出力元の抽出"
        '
        ' ラベル22
        '
        Me.ラベル22.AutoSize = True
        Me.ラベル22.Location = New System.Drawing.Point(181, 75)
        Me.ラベル22.Name = "ラベル22"
        Me.ラベル22.TabIndex = 16
        Me.ラベル22.Text = "検索条件を加味する"
        '
        ' ラベル49
        '
        Me.ラベル49.AutoSize = True
        Me.ラベル49.Location = New System.Drawing.Point(26, 151)
        Me.ラベル49.Name = "ラベル49"
        Me.ラベル49.TabIndex = 17
        Me.ラベル49.Text = "伝票日付"
        '
        ' ラベル51
        '
        Me.ラベル51.AutoSize = True
        Me.ラベル51.Location = New System.Drawing.Point(26, 204)
        Me.ラベル51.Name = "ラベル51"
        Me.ラベル51.TabIndex = 18
        Me.ラベル51.Text = "部署ｺｰﾄﾞ(一括用)"
        '
        ' lbl_出力先EXCELﾌｧｲﾙ名
        '
        Me.lbl_出力先EXCELﾌｧｲﾙ名.AutoSize = True
        Me.lbl_出力先EXCELﾌｧｲﾙ名.Location = New System.Drawing.Point(26, 498)
        Me.lbl_出力先EXCELﾌｧｲﾙ名.Name = "lbl_出力先EXCELﾌｧｲﾙ名"
        Me.lbl_出力先EXCELﾌｧｲﾙ名.TabIndex = 19
        Me.lbl_出力先EXCELﾌｧｲﾙ名.Text = "出力先EXCELﾌｧｲﾙ名"
        '
        ' lbl_OUTPUT_FOLDER_NM
        '
        Me.lbl_OUTPUT_FOLDER_NM.AutoSize = True
        Me.lbl_OUTPUT_FOLDER_NM.Location = New System.Drawing.Point(26, 377)
        Me.lbl_OUTPUT_FOLDER_NM.Name = "lbl_OUTPUT_FOLDER_NM"
        Me.lbl_OUTPUT_FOLDER_NM.TabIndex = 20
        Me.lbl_OUTPUT_FOLDER_NM.Text = "出力先ﾌｫﾙﾀﾞ"
        '
        ' ラベル53
        '
        Me.ラベル53.AutoSize = True
        Me.ラベル53.Location = New System.Drawing.Point(26, 408)
        Me.ラベル53.Name = "ラベル53"
        Me.ラベル53.TabIndex = 21
        Me.ラベル53.Text = "M4BS_YYYYMMDD_HHMM_MM月_資産_開始_振替.txt\015\012M4BS_YYYYMMDD_HHMM_MM月_資産_償却_振替.txt\015"
        '
        ' ラベル55
        '
        Me.ラベル55.AutoSize = True
        Me.ラベル55.Location = New System.Drawing.Point(26, 170)
        Me.ラベル55.Name = "ラベル55"
        Me.ラベル55.TabIndex = 22
        Me.ラベル55.Text = "承認日付"
        '
        ' ラベル57
        '
        Me.ラベル57.AutoSize = True
        Me.ラベル57.Location = New System.Drawing.Point(26, 241)
        Me.ラベル57.Name = "ラベル57"
        Me.ラベル57.TabIndex = 23
        Me.ラベル57.Text = "科目ｺｰﾄﾞ(未払金)"
        '
        ' ラベル59
        '
        Me.ラベル59.AutoSize = True
        Me.ラベル59.Location = New System.Drawing.Point(26, 222)
        Me.ラベル59.Name = "ラベル59"
        Me.ラベル59.TabIndex = 24
        Me.ラベル59.Text = "部署ｺｰﾄﾞ(減損用)"
        '
        ' ラベル60
        '
        Me.ラベル60.AutoSize = True
        Me.ラベル60.Location = New System.Drawing.Point(332, 408)
        Me.ラベル60.Name = "ラベル60"
        Me.ラベル60.TabIndex = 25
        Me.ラベル60.Text = "M4BS_YYYYMMDD_HHMM_MM月_資産_開始_付替.txt\015\012M4BS_YYYYMMDD_HHMM_MM月_資産_償却_付替.txt\015"
        '
        ' chk_検索条件加味F
        '
        Me.chk_検索条件加味F.AutoSize = True
        Me.chk_検索条件加味F.Location = New System.Drawing.Point(166, 77)
        Me.chk_検索条件加味F.Name = "chk_検索条件加味F"
        Me.chk_検索条件加味F.TabIndex = 26
        Me.chk_検索条件加味F.Text = ""
        Me.chk_検索条件加味F.UseVisualStyleBackColor = True
        '
        ' Form_fc_計上仕訳_MARUZEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 566)
        Me.Controls.Add(Me.chk_検索条件加味F)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_SLIP_DT)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_TITL)
        Me.Controls.Add(Me.ラベル22)
        Me.Controls.Add(Me.ラベル49)
        Me.Controls.Add(Me.ラベル51)
        Me.Controls.Add(Me.lbl_出力先EXCELﾌｧｲﾙ名)
        Me.Controls.Add(Me.lbl_OUTPUT_FOLDER_NM)
        Me.Controls.Add(Me.ラベル53)
        Me.Controls.Add(Me.ラベル55)
        Me.Controls.Add(Me.ラベル57)
        Me.Controls.Add(Me.ラベル59)
        Me.Controls.Add(Me.ラベル60)
        Me.Controls.Add(Me.txt_出力年月)
        Me.Controls.Add(Me.txt_伝票日付)
        Me.Controls.Add(Me.txt_部署コード_一括用)
        Me.Controls.Add(Me.txt_FileNM)
        Me.Controls.Add(Me.txt_FolderNM)
        Me.Controls.Add(Me.txt_承認日付)
        Me.Controls.Add(Me.txt_科目コード_未払金)
        Me.Controls.Add(Me.txt_部署コード_減損用)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_選択2)
        Me.Controls.Add(Me.cmd_選択1)
        Me.Name = "Form_fc_計上仕訳_MARUZEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次仕訳計上ﾌﾚｯｸｽ - 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_選択2 As System.Windows.Forms.Button
    Friend WithEvents cmd_選択1 As System.Windows.Forms.Button
    Friend WithEvents txt_出力年月 As System.Windows.Forms.TextBox
    Friend WithEvents txt_伝票日付 As System.Windows.Forms.TextBox
    Friend WithEvents txt_部署コード_一括用 As System.Windows.Forms.TextBox
    Friend WithEvents txt_FileNM As System.Windows.Forms.TextBox
    Friend WithEvents txt_FolderNM As System.Windows.Forms.TextBox
    Friend WithEvents txt_承認日付 As System.Windows.Forms.TextBox
    Friend WithEvents txt_科目コード_未払金 As System.Windows.Forms.TextBox
    Friend WithEvents txt_部署コード_減損用 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_SLIP_DT As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_TITL As System.Windows.Forms.Label
    Friend WithEvents ラベル22 As System.Windows.Forms.Label
    Friend WithEvents ラベル49 As System.Windows.Forms.Label
    Friend WithEvents ラベル51 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力先EXCELﾌｧｲﾙ名 As System.Windows.Forms.Label
    Friend WithEvents lbl_OUTPUT_FOLDER_NM As System.Windows.Forms.Label
    Friend WithEvents ラベル53 As System.Windows.Forms.Label
    Friend WithEvents ラベル55 As System.Windows.Forms.Label
    Friend WithEvents ラベル57 As System.Windows.Forms.Label
    Friend WithEvents ラベル59 As System.Windows.Forms.Label
    Friend WithEvents ラベル60 As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味F As System.Windows.Forms.CheckBox

End Class