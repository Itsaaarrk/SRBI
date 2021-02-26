Imports System.Net
Imports System.Net.Mail

Public Class FRM_EM_2_BI


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
    Sub EMAILCONTENT()
        Try
            'Dim EmailMessage As New MailMessage()
            '   Dim FULLIMG As LinkedResource = New LinkedResource(strExportFileIMG & ".png", "image/png")

            'FULLIMG.ContentId = "FULLIMG"

            'EmailMessage.From = New MailAddress(Trim(My.Settings.HOSTEMAILADD))
            'EmailMessage.To.Add(Trim(WTXT_APPEMAILADD.Text))
            'EmailMessage.Subject = My.Settings.EMAILSUBJECT
            'EmailMessage.IsBodyHtml = True

            'EmailMessage.Body = " <div style='width: 100%;'>
            '                                                     <img src=cid:FULLIMG width='100%'>
            '                                                          </div>"
            '' CREATE ALTERNATIVE VIEW AS HTML
            'Dim av1 As AlternateView = AlternateView.CreateAlternateViewFromString(EmailMessage.Body, Nothing, MediaTypeNames.Text.Html)
            'av1.LinkedResources.Add(FULLIMG)
            'EmailMessage.AlternateViews.Add(av1)

            'Dim SMTP As New SmtpClient("smtp.gmail.com")
            'SMTP.Port = 587
            'SMTP.EnableSsl = True
            'SMTP.Credentials = New System.Net.NetworkCredential(Trim(My.Settings.HOSTEMAILADD), Trim(My.Settings.HOSTEMAILPASS))
            'SMTP.Send(EmailMessage)



            'SMTP2GO
            Dim EmailMessage As New MailMessage()
            Dim AttachmentFile As String = "C:\Users\M.A. De Castro\Documents\GitHub\SRBI\SRBI\SRBI\TRAVELPASS.pdf"
            With EmailMessage
                .From = New MailAddress(Trim("entryexit@pra.gov.ph"))
                .To.Add(Trim("mxaidocnv8@gmail.com"))
                .Subject = "LIST OF SRRV HOLDERS ISSUED WITH TRAVEL PASS"
                .IsBodyHtml = True
                .Body = "<html>
                            <head>
                            <title>Page Title</title>
                            </head>
                            <body>
                               <p style=""font-size:18pt;font-family:Georgia"">This refers to the list of retiree members who were issued Travel Pass as part of the requirement by the Beareau of Immigration for departing SRRV Holder.
                                </p>
                                <p style=""font-size:18pt;font-family:Georgia;padding-top:8%;"">For your reference and information.</p>
                                </p>
                                <p style=""font-size:18pt;font-family:Georgia;padding-top:8%;"">LERMA G. ABESAMIS<br>
                                Division Chief III - Servicing</p>
                            </body>
                        </html>"
                .Attachments.Add(New Attachment(AttachmentFile))
            End With

            Dim SMTP As New SmtpClient("mail.smtp2go.com")
            SMTP.Port = 2525
            SMTP.EnableSsl = True
            SMTP.Credentials = New Net.NetworkCredential("pramail.gov.ph", "pr@@Dm1n2017507")
            Try
                SMTP.Send(EmailMessage)
                NotificationManager.Show(Me, "Message Sent!", Color.Green, 3000)
                ' Label1.Text = "Message sent"
            Catch ex As Exception
                NotificationManager.Show(Me, "Sending Failed!", Color.Red, 3000)
            End Try
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "REGION: SEND EMAIL")
            NotificationManager.Show(Me, "Sending email failed" & vbNewLine & ex.Message, Color.Red, 6000)
        End Try

    End Sub

#End Region

#Region "CLICK"
    Private Sub BTN_INVENTORY_MINIMIZE_Click(sender As Object, e As EventArgs) Handles BTN_F_MINIMIZE.Click,
                                                                                        BTN_F_CLOSE.Click,
                                                                                        BTN_SEND_EMAIL.Click
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
        ElseIf btn Is BTN_SEND_EMAIL Then
            EMAILCONTENT()
        ElseIf txt Is WTXT_FROM Or txt Is WTXT_TO Then
            TXTDATE = CType(sender, TextBox)
            FRM_DATAENTRY.ShowDialog()
        End If

    End Sub
#End Region

#Region "LOAD"
    Private Sub FRM_EM_2_BI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_FILTERBY.SelectedIndex = 0
    End Sub

#End Region

#Region "SELECTED INDEX"
    Private Sub CB_FILTERBY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FILTERBY.SelectedIndexChanged
        If CB_FILTERBY.SelectedIndex = 3 Then
            PNL_CUSTOM.Visible = True
            WTXT_FROM.Clear()
            WTXT_TO.Clear()
        Else
            PNL_CUSTOM.Visible = False
        End If
    End Sub
#End Region

#Region "KEYPRESS"
    Private Sub WTXT_FROM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WTXT_TO.KeyPress, WTXT_FROM.KeyPress
        e.Handled = True
    End Sub
#End Region

End Class
