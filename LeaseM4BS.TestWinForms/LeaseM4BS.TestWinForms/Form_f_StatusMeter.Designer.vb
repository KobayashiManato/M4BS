<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Form_f_StatusMeter

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
        Me.cmd_Cancel = New System.Windows.Forms.Button()
        Me.System = New System.Windows.Forms.Label()
        Me.lbl_ProcName = New System.Windows.Forms.Label()
        Me.lbl_ProcID = New System.Windows.Forms.Label()
        Me.lbl_recsts_Blue = New System.Windows.Forms.Label()
        Me.lbl_recsts_White = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' cmd_Cancel
        '
        Me.cmd_Cancel.Location = New System.Drawing.Point(170, 81)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancel.TabIndex = 0
        Me.cmd_Cancel.Text = "&Cancel"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        ' System
        '
        Me.System.AutoSize = True
        Me.System.Location = New System.Drawing.Point(0, 0)
        Me.System.Name = "System"
        Me.System.TabIndex = 1
        Me.System.Text = ""
        '
        ' lbl_ProcName
        '
        Me.lbl_ProcName.AutoSize = True
        Me.lbl_ProcName.Location = New System.Drawing.Point(45, 18)
        Me.lbl_ProcName.Name = "lbl_ProcName"
        Me.lbl_ProcName.TabIndex = 2
        Me.lbl_ProcName.Text = ""
        '
        ' lbl_ProcID
        '
        Me.lbl_ProcID.AutoSize = True
        Me.lbl_ProcID.Location = New System.Drawing.Point(343, 18)
        Me.lbl_ProcID.Name = "lbl_ProcID"
        Me.lbl_ProcID.TabIndex = 3
        Me.lbl_ProcID.Text = ""
        '
        ' lbl_recsts_Blue
        '
        Me.lbl_recsts_Blue.AutoSize = True
        Me.lbl_recsts_Blue.Location = New System.Drawing.Point(158, 59)
        Me.lbl_recsts_Blue.Name = "lbl_recsts_Blue"
        Me.lbl_recsts_Blue.TabIndex = 4
        Me.lbl_recsts_Blue.Text = "0% Completed"
        '
        ' lbl_recsts_White
        '
        Me.lbl_recsts_White.AutoSize = True
        Me.lbl_recsts_White.Location = New System.Drawing.Point(26, 78)
        Me.lbl_recsts_White.Name = "lbl_recsts_White"
        Me.lbl_recsts_White.TabIndex = 5
        Me.lbl_recsts_White.Text = "0%"
        '
        ' Form_f_StatusMeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.System)
        Me.Controls.Add(Me.lbl_ProcName)
        Me.Controls.Add(Me.lbl_ProcID)
        Me.Controls.Add(Me.lbl_recsts_Blue)
        Me.Controls.Add(Me.lbl_recsts_White)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Name = "Form_f_StatusMeter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Status Meter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents System As System.Windows.Forms.Label
    Friend WithEvents lbl_ProcName As System.Windows.Forms.Label
    Friend WithEvents lbl_ProcID As System.Windows.Forms.Label
    Friend WithEvents lbl_recsts_Blue As System.Windows.Forms.Label
    Friend WithEvents lbl_recsts_White As System.Windows.Forms.Label

End Class