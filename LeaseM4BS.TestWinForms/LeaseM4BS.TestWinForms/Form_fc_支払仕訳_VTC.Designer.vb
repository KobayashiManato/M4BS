<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_fc_支払仕訳_VTC

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
        Me.cmd_支払日確認 = New System.Windows.Forms.Button()
        Me.txt_SLIP_DT = New System.Windows.Forms.TextBox()
        Me.txt_1C_支払リース仮勘定 = New System.Windows.Forms.TextBox()
        Me.txt_2D_未払費用 = New System.Windows.Forms.TextBox()
        Me.txt_3C_支払リース仮勘定 = New System.Windows.Forms.TextBox()
        Me.txt_1D_リース未払金 = New System.Windows.Forms.TextBox()
        Me.txt_2C_支払リース仮勘定 = New System.Windows.Forms.TextBox()
        Me.txt_2C_前払費用 = New System.Windows.Forms.TextBox()
        Me.txt_4C_支払リース仮勘定 = New System.Windows.Forms.TextBox()
        Me.lbl_EXPLANATION2 = New System.Windows.Forms.Label()
        Me.lbl_SLIP_DT = New System.Windows.Forms.Label()
        Me.lbl_EXPLANATION1 = New System.Windows.Forms.Label()
        Me.lbl_出力元の抽出 = New System.Windows.Forms.Label()
        Me.lbl_検索条件加味F = New System.Windows.Forms.Label()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.lbl_Title1 = New System.Windows.Forms.Label()
        Me.lbl_1D = New System.Windows.Forms.Label()
        Me.lbl_1C = New System.Windows.Forms.Label()
        Me.lbl_1D_ﾘｰｽ未払金 = New System.Windows.Forms.Label()
        Me.lbl_1C_支払ﾘｰｽ仮勘定 = New System.Windows.Forms.Label()
        Me.lbl_Title2 = New System.Windows.Forms.Label()
        Me.lbl_2D = New System.Windows.Forms.Label()
        Me.lbl_2C = New System.Windows.Forms.Label()
        Me.lbl_2D_未払費用 = New System.Windows.Forms.Label()
        Me.lbl_2C_支払ﾘｰｽ仮勘定 = New System.Windows.Forms.Label()
        Me.lbl_Title3 = New System.Windows.Forms.Label()
        Me.lbl_3D = New System.Windows.Forms.Label()
        Me.lbl_3C = New System.Windows.Forms.Label()
        Me.lbl_3D_ﾘｰｽ料 = New System.Windows.Forms.Label()
        Me.lbl_3C_支払ﾘｰｽ仮勘定 = New System.Windows.Forms.Label()
        Me.lbl_Title4 = New System.Windows.Forms.Label()
        Me.lbl_2D_ﾘｰｽ料 = New System.Windows.Forms.Label()
        Me.lbl_2C_前払費用 = New System.Windows.Forms.Label()
        Me.lbl_4D = New System.Windows.Forms.Label()
        Me.lbl_4C = New System.Windows.Forms.Label()
        Me.lbl_4D_ﾘｰｽ料_保守料 = New System.Windows.Forms.Label()
        Me.lbl_4C_支払ﾘｰｽ仮勘定 = New System.Windows.Forms.Label()
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
        ' cmd_支払日確認
        '
        Me.cmd_支払日確認.Location = New System.Drawing.Point(264, 3)
        Me.cmd_支払日確認.Name = "cmd_支払日確認"
        Me.cmd_支払日確認.Size = New System.Drawing.Size(86, 26)
        Me.cmd_支払日確認.TabIndex = 2
        Me.cmd_支払日確認.Text = "支払日確認"
        Me.cmd_支払日確認.UseVisualStyleBackColor = True
        '
        ' txt_SLIP_DT
        '
        Me.txt_SLIP_DT.Location = New System.Drawing.Point(136, 45)
        Me.txt_SLIP_DT.Name = "txt_SLIP_DT"
        Me.txt_SLIP_DT.Size = New System.Drawing.Size(94, 19)
        Me.txt_SLIP_DT.TabIndex = 3
        '
        ' txt_1C_支払リース仮勘定
        '
        Me.txt_1C_支払リース仮勘定.Location = New System.Drawing.Point(404, 211)
        Me.txt_1C_支払リース仮勘定.Name = "txt_1C_支払リース仮勘定"
        Me.txt_1C_支払リース仮勘定.Size = New System.Drawing.Size(56, 19)
        Me.txt_1C_支払リース仮勘定.TabIndex = 4
        '
        ' txt_2D_未払費用
        '
        Me.txt_2D_未払費用.Location = New System.Drawing.Point(192, 423)
        Me.txt_2D_未払費用.Name = "txt_2D_未払費用"
        Me.txt_2D_未払費用.Size = New System.Drawing.Size(56, 19)
        Me.txt_2D_未払費用.TabIndex = 5
        '
        ' txt_3C_支払リース仮勘定
        '
        Me.txt_3C_支払リース仮勘定.Location = New System.Drawing.Point(404, 283)
        Me.txt_3C_支払リース仮勘定.Name = "txt_3C_支払リース仮勘定"
        Me.txt_3C_支払リース仮勘定.Size = New System.Drawing.Size(56, 19)
        Me.txt_3C_支払リース仮勘定.TabIndex = 6
        '
        ' txt_1D_リース未払金
        '
        Me.txt_1D_リース未払金.Location = New System.Drawing.Point(192, 211)
        Me.txt_1D_リース未払金.Name = "txt_1D_リース未払金"
        Me.txt_1D_リース未払金.Size = New System.Drawing.Size(56, 19)
        Me.txt_1D_リース未払金.TabIndex = 7
        '
        ' txt_2C_支払リース仮勘定
        '
        Me.txt_2C_支払リース仮勘定.Location = New System.Drawing.Point(404, 423)
        Me.txt_2C_支払リース仮勘定.Name = "txt_2C_支払リース仮勘定"
        Me.txt_2C_支払リース仮勘定.Size = New System.Drawing.Size(56, 19)
        Me.txt_2C_支払リース仮勘定.TabIndex = 8
        '
        ' txt_2C_前払費用
        '
        Me.txt_2C_前払費用.Location = New System.Drawing.Point(404, 442)
        Me.txt_2C_前払費用.Name = "txt_2C_前払費用"
        Me.txt_2C_前払費用.Size = New System.Drawing.Size(56, 19)
        Me.txt_2C_前払費用.TabIndex = 9
        '
        ' txt_4C_支払リース仮勘定
        '
        Me.txt_4C_支払リース仮勘定.Location = New System.Drawing.Point(404, 351)
        Me.txt_4C_支払リース仮勘定.Name = "txt_4C_支払リース仮勘定"
        Me.txt_4C_支払リース仮勘定.Size = New System.Drawing.Size(56, 19)
        Me.txt_4C_支払リース仮勘定.TabIndex = 10
        '
        ' lbl_EXPLANATION2
        '
        Me.lbl_EXPLANATION2.AutoSize = True
        Me.lbl_EXPLANATION2.Location = New System.Drawing.Point(124, 120)
        Me.lbl_EXPLANATION2.Name = "lbl_EXPLANATION2"
        Me.lbl_EXPLANATION2.TabIndex = 11
        Me.lbl_EXPLANATION2.Text = "   仕訳ﾃﾞｰﾀを作成します。部分出力以外に使用しないでください。"
        '
        ' lbl_SLIP_DT
        '
        Me.lbl_SLIP_DT.AutoSize = True
        Me.lbl_SLIP_DT.Location = New System.Drawing.Point(26, 45)
        Me.lbl_SLIP_DT.Name = "lbl_SLIP_DT"
        Me.lbl_SLIP_DT.TabIndex = 12
        Me.lbl_SLIP_DT.Text = "処理年月"
        '
        ' lbl_EXPLANATION1
        '
        Me.lbl_EXPLANATION1.AutoSize = True
        Me.lbl_EXPLANATION1.Location = New System.Drawing.Point(124, 102)
        Me.lbl_EXPLANATION1.Name = "lbl_EXPLANATION1"
        Me.lbl_EXPLANATION1.TabIndex = 13
        Me.lbl_EXPLANATION1.Text = "※月次支払照合ﾌﾚｯｸｽを検索条件で抽出した結果に対して"
        '
        ' lbl_出力元の抽出
        '
        Me.lbl_出力元の抽出.AutoSize = True
        Me.lbl_出力元の抽出.Location = New System.Drawing.Point(26, 75)
        Me.lbl_出力元の抽出.Name = "lbl_出力元の抽出"
        Me.lbl_出力元の抽出.TabIndex = 14
        Me.lbl_出力元の抽出.Text = "出力元の抽出"
        '
        ' lbl_検索条件加味F
        '
        Me.lbl_検索条件加味F.AutoSize = True
        Me.lbl_検索条件加味F.Location = New System.Drawing.Point(170, 75)
        Me.lbl_検索条件加味F.Name = "lbl_検索条件加味F"
        Me.lbl_検索条件加味F.TabIndex = 15
        Me.lbl_検索条件加味F.Text = "検索条件を加味する"
        '
        ' lbl_Title
        '
        Me.lbl_Title.AutoSize = True
        Me.lbl_Title.Location = New System.Drawing.Point(22, 151)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.TabIndex = 16
        Me.lbl_Title.Text = "本機能で出力する仕訳データ"
        '
        ' lbl_Title1
        '
        Me.lbl_Title1.AutoSize = True
        Me.lbl_Title1.Location = New System.Drawing.Point(37, 170)
        Me.lbl_Title1.Name = "lbl_Title1"
        Me.lbl_Title1.TabIndex = 17
        Me.lbl_Title1.Text = "(1) 所有権移転外ﾌｧｲﾅﾝｽ･ﾘｰｽ　売買取引"
        '
        ' lbl_1D
        '
        Me.lbl_1D.AutoSize = True
        Me.lbl_1D.Location = New System.Drawing.Point(90, 192)
        Me.lbl_1D.Name = "lbl_1D"
        Me.lbl_1D.TabIndex = 18
        Me.lbl_1D.Text = "<借方>"
        '
        ' lbl_1C
        '
        Me.lbl_1C.AutoSize = True
        Me.lbl_1C.Location = New System.Drawing.Point(302, 192)
        Me.lbl_1C.Name = "lbl_1C"
        Me.lbl_1C.TabIndex = 19
        Me.lbl_1C.Text = "<貸方>"
        '
        ' lbl_1D_ﾘｰｽ未払金
        '
        Me.lbl_1D_ﾘｰｽ未払金.AutoSize = True
        Me.lbl_1D_ﾘｰｽ未払金.Location = New System.Drawing.Point(90, 211)
        Me.lbl_1D_ﾘｰｽ未払金.Name = "lbl_1D_ﾘｰｽ未払金"
        Me.lbl_1D_ﾘｰｽ未払金.TabIndex = 20
        Me.lbl_1D_ﾘｰｽ未払金.Text = "ﾘｰｽ未払金"
        '
        ' lbl_1C_支払ﾘｰｽ仮勘定
        '
        Me.lbl_1C_支払ﾘｰｽ仮勘定.AutoSize = True
        Me.lbl_1C_支払ﾘｰｽ仮勘定.Location = New System.Drawing.Point(302, 211)
        Me.lbl_1C_支払ﾘｰｽ仮勘定.Name = "lbl_1C_支払ﾘｰｽ仮勘定"
        Me.lbl_1C_支払ﾘｰｽ仮勘定.TabIndex = 21
        Me.lbl_1C_支払ﾘｰｽ仮勘定.Text = "支払ﾘｰｽ仮勘定"
        '
        ' lbl_Title2
        '
        Me.lbl_Title2.AutoSize = True
        Me.lbl_Title2.Location = New System.Drawing.Point(37, 381)
        Me.lbl_Title2.Name = "lbl_Title2"
        Me.lbl_Title2.TabIndex = 22
        Me.lbl_Title2.Text = "(2) 所有権移転外ﾌｧｲﾅﾝｽ･ﾘｰｽ　賃貸借取引　会計基準適用後契約"
        '
        ' lbl_2D
        '
        Me.lbl_2D.AutoSize = True
        Me.lbl_2D.Location = New System.Drawing.Point(90, 404)
        Me.lbl_2D.Name = "lbl_2D"
        Me.lbl_2D.TabIndex = 23
        Me.lbl_2D.Text = "<借方>"
        '
        ' lbl_2C
        '
        Me.lbl_2C.AutoSize = True
        Me.lbl_2C.Location = New System.Drawing.Point(302, 404)
        Me.lbl_2C.Name = "lbl_2C"
        Me.lbl_2C.TabIndex = 24
        Me.lbl_2C.Text = "<貸方>"
        '
        ' lbl_2D_未払費用
        '
        Me.lbl_2D_未払費用.AutoSize = True
        Me.lbl_2D_未払費用.Location = New System.Drawing.Point(90, 423)
        Me.lbl_2D_未払費用.Name = "lbl_2D_未払費用"
        Me.lbl_2D_未払費用.TabIndex = 25
        Me.lbl_2D_未払費用.Text = "未払費用"
        '
        ' lbl_2C_支払ﾘｰｽ仮勘定
        '
        Me.lbl_2C_支払ﾘｰｽ仮勘定.AutoSize = True
        Me.lbl_2C_支払ﾘｰｽ仮勘定.Location = New System.Drawing.Point(302, 423)
        Me.lbl_2C_支払ﾘｰｽ仮勘定.Name = "lbl_2C_支払ﾘｰｽ仮勘定"
        Me.lbl_2C_支払ﾘｰｽ仮勘定.TabIndex = 26
        Me.lbl_2C_支払ﾘｰｽ仮勘定.Text = "支払ﾘｰｽ仮勘定"
        '
        ' lbl_Title3
        '
        Me.lbl_Title3.AutoSize = True
        Me.lbl_Title3.Location = New System.Drawing.Point(37, 241)
        Me.lbl_Title3.Name = "lbl_Title3"
        Me.lbl_Title3.TabIndex = 27
        Me.lbl_Title3.Text = "(2) 所有権移転外ﾌｧｲﾅﾝｽ･ﾘｰｽ　賃貸借取引"
        '
        ' lbl_3D
        '
        Me.lbl_3D.AutoSize = True
        Me.lbl_3D.Location = New System.Drawing.Point(90, 264)
        Me.lbl_3D.Name = "lbl_3D"
        Me.lbl_3D.TabIndex = 28
        Me.lbl_3D.Text = "<借方>"
        '
        ' lbl_3C
        '
        Me.lbl_3C.AutoSize = True
        Me.lbl_3C.Location = New System.Drawing.Point(302, 264)
        Me.lbl_3C.Name = "lbl_3C"
        Me.lbl_3C.TabIndex = 29
        Me.lbl_3C.Text = "<貸方>"
        '
        ' lbl_3D_ﾘｰｽ料
        '
        Me.lbl_3D_ﾘｰｽ料.AutoSize = True
        Me.lbl_3D_ﾘｰｽ料.Location = New System.Drawing.Point(90, 283)
        Me.lbl_3D_ﾘｰｽ料.Name = "lbl_3D_ﾘｰｽ料"
        Me.lbl_3D_ﾘｰｽ料.TabIndex = 30
        Me.lbl_3D_ﾘｰｽ料.Text = "ﾘｰｽ料"
        '
        ' lbl_3C_支払ﾘｰｽ仮勘定
        '
        Me.lbl_3C_支払ﾘｰｽ仮勘定.AutoSize = True
        Me.lbl_3C_支払ﾘｰｽ仮勘定.Location = New System.Drawing.Point(302, 283)
        Me.lbl_3C_支払ﾘｰｽ仮勘定.Name = "lbl_3C_支払ﾘｰｽ仮勘定"
        Me.lbl_3C_支払ﾘｰｽ仮勘定.TabIndex = 31
        Me.lbl_3C_支払ﾘｰｽ仮勘定.Text = "支払ﾘｰｽ仮勘定"
        '
        ' lbl_Title4
        '
        Me.lbl_Title4.AutoSize = True
        Me.lbl_Title4.Location = New System.Drawing.Point(37, 313)
        Me.lbl_Title4.Name = "lbl_Title4"
        Me.lbl_Title4.TabIndex = 32
        Me.lbl_Title4.Text = "(3) ｵﾍﾟﾚｰﾃｨﾝｸﾞ･ﾘｰｽ、保守料、その他"
        '
        ' lbl_2D_ﾘｰｽ料
        '
        Me.lbl_2D_ﾘｰｽ料.AutoSize = True
        Me.lbl_2D_ﾘｰｽ料.Location = New System.Drawing.Point(90, 442)
        Me.lbl_2D_ﾘｰｽ料.Name = "lbl_2D_ﾘｰｽ料"
        Me.lbl_2D_ﾘｰｽ料.TabIndex = 33
        Me.lbl_2D_ﾘｰｽ料.Text = "ﾘｰｽ料"
        '
        ' lbl_2C_前払費用
        '
        Me.lbl_2C_前払費用.AutoSize = True
        Me.lbl_2C_前払費用.Location = New System.Drawing.Point(302, 442)
        Me.lbl_2C_前払費用.Name = "lbl_2C_前払費用"
        Me.lbl_2C_前払費用.TabIndex = 34
        Me.lbl_2C_前払費用.Text = "前払費用"
        '
        ' lbl_4D
        '
        Me.lbl_4D.AutoSize = True
        Me.lbl_4D.Location = New System.Drawing.Point(90, 332)
        Me.lbl_4D.Name = "lbl_4D"
        Me.lbl_4D.TabIndex = 35
        Me.lbl_4D.Text = "<借方>"
        '
        ' lbl_4C
        '
        Me.lbl_4C.AutoSize = True
        Me.lbl_4C.Location = New System.Drawing.Point(302, 332)
        Me.lbl_4C.Name = "lbl_4C"
        Me.lbl_4C.TabIndex = 36
        Me.lbl_4C.Text = "<貸方>"
        '
        ' lbl_4D_ﾘｰｽ料_保守料
        '
        Me.lbl_4D_ﾘｰｽ料_保守料.AutoSize = True
        Me.lbl_4D_ﾘｰｽ料_保守料.Location = New System.Drawing.Point(90, 351)
        Me.lbl_4D_ﾘｰｽ料_保守料.Name = "lbl_4D_ﾘｰｽ料_保守料"
        Me.lbl_4D_ﾘｰｽ料_保守料.TabIndex = 37
        Me.lbl_4D_ﾘｰｽ料_保守料.Text = "ﾘｰｽ料/保守料"
        '
        ' lbl_4C_支払ﾘｰｽ仮勘定
        '
        Me.lbl_4C_支払ﾘｰｽ仮勘定.AutoSize = True
        Me.lbl_4C_支払ﾘｰｽ仮勘定.Location = New System.Drawing.Point(302, 351)
        Me.lbl_4C_支払ﾘｰｽ仮勘定.Name = "lbl_4C_支払ﾘｰｽ仮勘定"
        Me.lbl_4C_支払ﾘｰｽ仮勘定.TabIndex = 38
        Me.lbl_4C_支払ﾘｰｽ仮勘定.Text = "支払ﾘｰｽ仮勘定"
        '
        ' chk_検索条件加味F
        '
        Me.chk_検索条件加味F.AutoSize = True
        Me.chk_検索条件加味F.Location = New System.Drawing.Point(154, 79)
        Me.chk_検索条件加味F.Name = "chk_検索条件加味F"
        Me.chk_検索条件加味F.TabIndex = 39
        Me.chk_検索条件加味F.Text = ""
        Me.chk_検索条件加味F.UseVisualStyleBackColor = True
        '
        ' Form_fc_支払仕訳_VTC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 507)
        Me.Controls.Add(Me.chk_検索条件加味F)
        Me.Controls.Add(Me.lbl_EXPLANATION2)
        Me.Controls.Add(Me.lbl_SLIP_DT)
        Me.Controls.Add(Me.lbl_EXPLANATION1)
        Me.Controls.Add(Me.lbl_出力元の抽出)
        Me.Controls.Add(Me.lbl_検索条件加味F)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.lbl_Title1)
        Me.Controls.Add(Me.lbl_1D)
        Me.Controls.Add(Me.lbl_1C)
        Me.Controls.Add(Me.lbl_1D_ﾘｰｽ未払金)
        Me.Controls.Add(Me.lbl_1C_支払ﾘｰｽ仮勘定)
        Me.Controls.Add(Me.lbl_Title2)
        Me.Controls.Add(Me.lbl_2D)
        Me.Controls.Add(Me.lbl_2C)
        Me.Controls.Add(Me.lbl_2D_未払費用)
        Me.Controls.Add(Me.lbl_2C_支払ﾘｰｽ仮勘定)
        Me.Controls.Add(Me.lbl_Title3)
        Me.Controls.Add(Me.lbl_3D)
        Me.Controls.Add(Me.lbl_3C)
        Me.Controls.Add(Me.lbl_3D_ﾘｰｽ料)
        Me.Controls.Add(Me.lbl_3C_支払ﾘｰｽ仮勘定)
        Me.Controls.Add(Me.lbl_Title4)
        Me.Controls.Add(Me.lbl_2D_ﾘｰｽ料)
        Me.Controls.Add(Me.lbl_2C_前払費用)
        Me.Controls.Add(Me.lbl_4D)
        Me.Controls.Add(Me.lbl_4C)
        Me.Controls.Add(Me.lbl_4D_ﾘｰｽ料_保守料)
        Me.Controls.Add(Me.lbl_4C_支払ﾘｰｽ仮勘定)
        Me.Controls.Add(Me.txt_SLIP_DT)
        Me.Controls.Add(Me.txt_1C_支払リース仮勘定)
        Me.Controls.Add(Me.txt_2D_未払費用)
        Me.Controls.Add(Me.txt_3C_支払リース仮勘定)
        Me.Controls.Add(Me.txt_1D_リース未払金)
        Me.Controls.Add(Me.txt_2C_支払リース仮勘定)
        Me.Controls.Add(Me.txt_2C_前払費用)
        Me.Controls.Add(Me.txt_4C_支払リース仮勘定)
        Me.Controls.Add(Me.cmd_実行)
        Me.Controls.Add(Me.cmd_CANCEL)
        Me.Controls.Add(Me.cmd_支払日確認)
        Me.Name = "Form_fc_支払仕訳_VTC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "月次支払照合ﾌﾚｯｸｽ － 仕訳出力"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_実行 As System.Windows.Forms.Button
    Friend WithEvents cmd_CANCEL As System.Windows.Forms.Button
    Friend WithEvents cmd_支払日確認 As System.Windows.Forms.Button
    Friend WithEvents txt_SLIP_DT As System.Windows.Forms.TextBox
    Friend WithEvents txt_1C_支払リース仮勘定 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2D_未払費用 As System.Windows.Forms.TextBox
    Friend WithEvents txt_3C_支払リース仮勘定 As System.Windows.Forms.TextBox
    Friend WithEvents txt_1D_リース未払金 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2C_支払リース仮勘定 As System.Windows.Forms.TextBox
    Friend WithEvents txt_2C_前払費用 As System.Windows.Forms.TextBox
    Friend WithEvents txt_4C_支払リース仮勘定 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_EXPLANATION2 As System.Windows.Forms.Label
    Friend WithEvents lbl_SLIP_DT As System.Windows.Forms.Label
    Friend WithEvents lbl_EXPLANATION1 As System.Windows.Forms.Label
    Friend WithEvents lbl_出力元の抽出 As System.Windows.Forms.Label
    Friend WithEvents lbl_検索条件加味F As System.Windows.Forms.Label
    Friend WithEvents lbl_Title As System.Windows.Forms.Label
    Friend WithEvents lbl_Title1 As System.Windows.Forms.Label
    Friend WithEvents lbl_1D As System.Windows.Forms.Label
    Friend WithEvents lbl_1C As System.Windows.Forms.Label
    Friend WithEvents lbl_1D_ﾘｰｽ未払金 As System.Windows.Forms.Label
    Friend WithEvents lbl_1C_支払ﾘｰｽ仮勘定 As System.Windows.Forms.Label
    Friend WithEvents lbl_Title2 As System.Windows.Forms.Label
    Friend WithEvents lbl_2D As System.Windows.Forms.Label
    Friend WithEvents lbl_2C As System.Windows.Forms.Label
    Friend WithEvents lbl_2D_未払費用 As System.Windows.Forms.Label
    Friend WithEvents lbl_2C_支払ﾘｰｽ仮勘定 As System.Windows.Forms.Label
    Friend WithEvents lbl_Title3 As System.Windows.Forms.Label
    Friend WithEvents lbl_3D As System.Windows.Forms.Label
    Friend WithEvents lbl_3C As System.Windows.Forms.Label
    Friend WithEvents lbl_3D_ﾘｰｽ料 As System.Windows.Forms.Label
    Friend WithEvents lbl_3C_支払ﾘｰｽ仮勘定 As System.Windows.Forms.Label
    Friend WithEvents lbl_Title4 As System.Windows.Forms.Label
    Friend WithEvents lbl_2D_ﾘｰｽ料 As System.Windows.Forms.Label
    Friend WithEvents lbl_2C_前払費用 As System.Windows.Forms.Label
    Friend WithEvents lbl_4D As System.Windows.Forms.Label
    Friend WithEvents lbl_4C As System.Windows.Forms.Label
    Friend WithEvents lbl_4D_ﾘｰｽ料_保守料 As System.Windows.Forms.Label
    Friend WithEvents lbl_4C_支払ﾘｰｽ仮勘定 As System.Windows.Forms.Label
    Friend WithEvents chk_検索条件加味F As System.Windows.Forms.CheckBox

End Class