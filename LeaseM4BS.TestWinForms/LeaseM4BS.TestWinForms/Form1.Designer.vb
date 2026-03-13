<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnLoadData = New System.Windows.Forms.Button()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnCrudTest = New System.Windows.Forms.Button()
        Me.btnTransactionTest = New System.Windows.Forms.Button()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 154)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(655, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'txtQuery
        '
        Me.txtQuery.Location = New System.Drawing.Point(12, 23)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(296, 112)
        Me.txtQuery.TabIndex = 1
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(412, 23)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "接続テスト"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnLoadData
        '
        Me.btnLoadData.Location = New System.Drawing.Point(412, 65)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadData.TabIndex = 3
        Me.btnLoadData.Text = "データ取得"
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(412, 106)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "クエリ実行"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'btnCrudTest
        '
        Me.btnCrudTest.Location = New System.Drawing.Point(520, 23)
        Me.btnCrudTest.Name = "btnCrudTest"
        Me.btnCrudTest.Size = New System.Drawing.Size(120, 30)
        Me.btnCrudTest.TabIndex = 5
        Me.btnCrudTest.Text = "CRUDテスト実行"
        Me.btnCrudTest.UseVisualStyleBackColor = True
        '
        'btnTransactionTest
        '
        Me.btnTransactionTest.Location = New System.Drawing.Point(520, 65)
        Me.btnTransactionTest.Name = "btnTransactionTest"
        Me.btnTransactionTest.Size = New System.Drawing.Size(120, 30)
        Me.btnTransactionTest.TabIndex = 6
        Me.btnTransactionTest.Text = "トランザクションテスト"
        Me.btnTransactionTest.UseVisualStyleBackColor = True
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(664, 23)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ReadOnly = True
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(400, 415)
        Me.txtResults.TabIndex = 7
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Location = New System.Drawing.Point(662, 8)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(53, 12)
        Me.lblResults.TabIndex = 8
        Me.lblResults.Text = "実行結果"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 450)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.btnTransactionTest)
        Me.Controls.Add(Me.btnCrudTest)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtQuery)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "LeaseM4BS - crudHelper テストフォーム"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtQuery As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnLoadData As Button
    Friend WithEvents btnExecute As Button
    Friend WithEvents btnCrudTest As Button
    Friend WithEvents btnTransactionTest As Button
    Friend WithEvents txtResults As TextBox
    Friend WithEvents lblResults As Label
End Class
