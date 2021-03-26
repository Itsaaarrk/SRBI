Imports System.Drawing.Printing

Public Class FRM_PREVIEW
    Private Sub CRV_PREVIEW_Load(sender As Object, e As EventArgs) Handles CRV_PREVIEW.Load
        rptDoc = New RPT_TPL
        SPM4_TRP_LISTTableAdapter.Fill(DS_STOREDPROC.SPM4_TRP_LIST, P_TXT_SEARCH, P_WTXT_FROM, P_WTXT_TO, P_INDEX, P_CBY)
        rptDoc.SetDataSource(DS_STOREDPROC.SPM4_TRP_LIST.DataSet)
        CRV_PREVIEW.ReportSource = rptDoc
    End Sub

    Private Sub BTN_F_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_F_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTN_VIEW_LOGS_Click(sender As Object, e As EventArgs) Handles BTN_VIEW_LOGS.Click
        PrintDialog.Document = PrintDocument
        PrintDialog.PrinterSettings = PrintDocument.PrinterSettings
        If PrintDialog.ShowDialog = DialogResult.OK Then
            Try
                Dim PrinterName As String = PrintDocument.PrinterSettings.PrinterName
                rptDoc.PrintOptions.PrinterName = PrinterName
                rptDoc.PrintToPrinter(1, False, PrintDialog.PrinterSettings.FromPage, PrintDialog.PrinterSettings.ToPage)

                Me.Close()
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "BTN_VIEW_LOGS_Click")
            End Try
        End If
    End Sub
End Class