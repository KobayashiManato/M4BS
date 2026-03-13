Imports System.Windows.Forms

Partial Public Class Form_f_FlexOutputDLG
    Inherits Form

    Public Dgv As DataGridView

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_FlexOutputDLG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each col As DataGridViewColumn In Dgv.Columns
            If col.Visible Then
                lst_FieldList.Items.Add(col.HeaderText)
            End If
        Next
        If cmb_DELIMITER.Items.Count > 0 Then cmb_DELIMITER.SelectedIndex = 0
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        Dim fileHelper As FileHelper = New FileHelper()

        If radio_EXCEL.Checked Then
            fileHelper.ToExcelFile(Dgv)
        ElseIf radio_CSV.Checked Then
            Dim qualifier As String = If(cmb_DELIMITER.SelectedItem?.ToString(), """")
            If qualifier = "なし" Then qualifier = ""
            fileHelper.ToCsvFile(Dgv, ",", qualifier)
        Else
            fileHelper.ToFixedLengthFile(Dgv)
        End If
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub
End Class