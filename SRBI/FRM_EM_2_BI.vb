Imports System.Net
Imports System.Net.Mail
Imports CrystalDecisions.Shared

Public Class FRM_EM_2_BI
    Dim pdfpath As String

#Region "START ##### FORM DRAG AND DROP, MINIMIZE, CLOSE"
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PNL_DoubleClick(sender As Object, e As EventArgs) Handles PNL1.DoubleClick,
                                                                            PNL2.DoubleClick,
                                                                            PNL3.DoubleClick,
                                                                            PNL_LBL.DoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL1.MouseDown,
                                                                                                                PNL2.MouseDown,
                                                                                                                PNL3.MouseDown,
                                                                                                                PNL_LBL.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL1.MouseMove,
                                                                                                                PNL2.MouseMove,
                                                                                                                PNL3.MouseMove,
                                                                                                                PNL_LBL.MouseMove

        If drag Then
            Top = Cursor.Position.Y - mousey
            Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PNL1.MouseUp,
                                                                                                                PNL2.MouseUp,
                                                                                                                PNL3.MouseUp,
                                                                                                                PNL_LBL.MouseUp
        drag = False
    End Sub

#End Region

#Region "FUNCTION"


#Region "TO PDF"
    Sub TOPDF()
        ' Dim strExportFile As String = Application.StartupPath() & RandomCode() & ".pdf"
        pdfpath = Application.StartupPath() & "\Media_Files\PDFs\" & RandomCode() & ".xlsx"
        Try
            rptDoc = New RPT_TPL
            rptDoc.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
            rptDoc.ExportOptions.ExportFormatType = ExportFormatType.Excel

            Dim objOptions As DiskFileDestinationOptions = New DiskFileDestinationOptions()
            objOptions.DiskFileName = pdfpath
            rptDoc.ExportOptions.DestinationOptions = objOptions
            '   SPM4_TRP_LISTTableAdapter.Fill(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text)
            rptDoc.SetDataSource(DS_STOREDPROC.SPM4_TRP_LIST.DataSet)
            CR_VIEWER.ReportSource = rptDoc
            rptDoc.Export()
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "REGION: EXPORT AS DOC")
            NotificationManager.Show(Me, "Sending email failed" & vbNewLine & ex.Message, Color.Red, 6000)
        End Try
    End Sub
#End Region

    Sub EMAILCONTENT()
        Try


            Dim EmailMessage As New MailMessage()
            Dim AttachmentFile As String = pdfpath
            With EmailMessage
                .From = New MailAddress(Trim("pra.entryexit@gmail.com"))
                '  .To.Add(Trim("von.0030@gmail.com"))
                .To.Add(Trim("mxaidocnv8@gmail.com"))
                .Subject = "LIST OF SRRV HOLDERS ISSUED WITH TRAVEL PASS"
                .IsBodyHtml = True
                .Body = " <html>
                            <head>
                            <style>
                             h3{font-family:Arial, Helvetica, sans-serif;}
                                .psign{font-size:13pt;font-family:Georgia;padding-top:18px;}
                                .gaz{text-decoration:none;}
                                ol.let {list-style-type: lower-latin;font-weight:bold;font-size:13pt;font-family:Georgia}
                            </style>
                            </head>
                            <body>
                                <p class=""psign"">This refers to the list of retiree members who were issued Travel Pass as part of the requirement by the Bureau of Immigration for departing SRRV Holder!
                                </p>
                                <p class=""psign"">For your reference and information.</p>

                                <p class=""psign"">LERMA G. ABESAMIS.</p>
                            </body>
                        </html>                     "
                .Attachments.Add(New Attachment(AttachmentFile))
            End With

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New Net.NetworkCredential("pra.entryexit@gmail.com", "pr@@dm1n2017507")
            Try
                SMTP.Send(EmailMessage)
                NotificationManager.Show(Me, "Email Sent!", Color.Green, 3000)
                ' Label1.Text = "Message sent"
            Catch ex As Exception
                NotificationManager.Show(Me, "Sending Failed!", Color.Red, 3000)
            End Try

        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "REGION: SEND EMAIL")
            NotificationManager.Show(Me, "Sending email failed" & vbNewLine & ex.Message, Color.Red, 6000)
        End Try
    End Sub



#Region "REPORT"
    Sub LOAD_RPT()
        rptDoc = New RPT_TPL
        '    SPM4_TRP_LISTTableAdapter.Fill(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text)
        rptDoc.SetDataSource(DS_STOREDPROC.SPM4_TRP_LIST.DataSet)
        CR_VIEWER.ReportSource = rptDoc
    End Sub
#End Region



#End Region

#Region "CLICK"
    Private Sub BTN_INVENTORY_MINIMIZE_Click(sender As Object, e As EventArgs) Handles BTN_F_MINIMIZE.Click,
                                                                                        BTN_F_CLOSE.Click,
                                                                                        BTN_SEND_EMAIL.Click,
                                                                                        WTXT_FROM.Click,
                                                                                        WTXT_TO.Click,
                                                                                        BTN_VIEW_LOGS.Click,
                                                                                        BTN_SEARCH.Click

        Dim btn As Button = Nothing
        Dim txt As TextBox = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is TextBox Then
            txt = CType(sender, TextBox)
        End If


        If btn Is BTN_F_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf btn Is BTN_F_CLOSE Then
            Me.Close()
            FRM_LOGIN.Show()
            FRM_LOGIN.TXT_USERNAME.Clear()
            FRM_LOGIN.TXT_PASSWORD.Clear()
        ElseIf btn Is BTN_SEND_EMAIL Then
            TOPDF()
            '  EMAILCONTENT()
            If MsgBox("Are you sure you want to send this list?", vbYesNo, "CONFIRMATION") = vbYes Then

            End If
        ElseIf txt Is WTXT_FROM Or txt Is WTXT_TO Then
            TXTDATE = CType(sender, TextBox)
            FRM_DATAENTRY.ShowDialog()
        ElseIf btn Is BTN_VIEW_LOGS Then
            Me.Hide()
            FRM_RET_LOGS.Show()
        ElseIf btn Is BTN_SEARCH Then
            LOAD_RPT()
        End If

    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_EM_2_BI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DT_SERVERDATETableAdapter.Fill(Me.DS_STOREDPROC.DT_SERVERDATE)
        CB_FILTERBY.SelectedIndex = 0
    End Sub

#End Region

#Region "SELECTED INDEX"
    Private Sub CB_FILTERBY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FILTERBY.SelectedIndexChanged
        If CB_FILTERBY.SelectedIndex = 3 Then
            PNL_CUSTOM.Visible = True
        Else
            PNL_CUSTOM.Visible = False
        End If
    End Sub
#End Region

#Region "KEYPRESS/KEYDOWN"
    Private Sub WTXT_FROM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_TO.KeyPress, WTXT_FROM.KeyPress
        e.Handled = True
    End Sub

    Private Sub TXT_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            LOAD_RPT()
        End If
    End Sub
#End Region

End Class
