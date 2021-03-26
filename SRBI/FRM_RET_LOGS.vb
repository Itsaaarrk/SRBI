Imports System.IO
Imports System.Net.Mail
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class FRM_RET_LOGS

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

#Region "LOAD"
    Private Sub FRM_RET_LOGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CB_FILTERBY.SelectedIndex = 0
            CB_DATE_BY.SelectedIndex = 0
            Me.DT_SERVERDATETableAdapter.Fill(DS_STOREDPROC.DT_SERVERDATE)
            SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text, CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
            If DGV_TRP_LIST.Rows.Count = 0 Then
                PNL_NODATA.Visible = True
            Else
                PNL_NODATA.Visible = False
            End If
            LBL_TOT.Text = DGV_TRP_LIST.Rows.Count
        Catch ex As Exception
            ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "FRM_RET_LOGS_Load")
        End Try
    End Sub
#End Region

#Region "CLICK"
    Private Sub BTN_SEARCH_Click(sender As Object, e As EventArgs) Handles BTN_SEARCH.Click,
                                                                            WTXT_FROM.Click,
                                                                            WTXT_TO.Click,
                                                                            BTN_GEN_REP.Click,
                                                                            BTN_F_CLOSE.Click,
                                                                            BTN_F_MINIMIZE.Click,
                                                                            BTN_SEND_2BI.Click

        Dim btn As Button = Nothing
        Dim txt As TextBox = Nothing
        If TypeOf sender Is Button Then
            btn = CType(sender, Button)
        ElseIf TypeOf sender Is TextBox Then
            txt = CType(sender, TextBox)
        End If

        If btn Is BTN_SEARCH Then
            Try
                SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text, CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
                LBL_TOT.Text = DGV_TRP_LIST.Rows.Count
                If DGV_TRP_LIST.Rows.Count = 0 Then
                    PNL_NODATA.Visible = True
                Else
                    PNL_NODATA.Visible = False
                End If
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "BTN_SEARCH_Click")
            End Try
        ElseIf txt Is WTXT_FROM Or txt Is WTXT_TO Then
            TXTDATE = CType(sender, TextBox)
            FRM_DATAENTRY.ShowDialog()
            SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text, CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
            LBL_TOT.Text = DGV_TRP_LIST.Rows.Count
            If DGV_TRP_LIST.Rows.Count = 0 Then
                PNL_NODATA.Visible = True
            Else
                PNL_NODATA.Visible = False
            End If
        ElseIf btn Is BTN_GEN_REP Then
            P_TXT_SEARCH = TXT_SEARCH.Text
            P_WTXT_FROM = WTXT_FROM.Text
            P_WTXT_TO = WTXT_TO.Text
            P_INDEX = CB_FILTERBY.SelectedIndex
            P_CBY = CB_DATE_BY.Text
            FRM_PREVIEW.ShowDialog()
        ElseIf btn Is BTN_F_CLOSE Then
            Me.Close()
            FRM_LOGIN.Show()
            FRM_LOGIN.TXT_USERNAME.Clear()
            FRM_LOGIN.TXT_PASSWORD.Clear()
        ElseIf btn Is BTN_F_MINIMIZE Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

#End Region

#Region "KEY EVENT"
    Private Sub TXT_SEARCH_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_SEARCH.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text, CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
                LBL_TOT.Text = DGV_TRP_LIST.Rows.Count
                If DGV_TRP_LIST.Rows.Count = 0 Then
                    PNL_NODATA.Visible = True
                Else
                    PNL_NODATA.Visible = False
                End If
            Catch ex As Exception
                ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, "TXT_SEARCH_KeyDown")
            End Try
        End If
    End Sub
#End Region

#Region "CELL CLICK"
    Private Sub DGV_TRP_LIST_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_TRP_LIST.CellClick
        If DGV_TRP_LIST.SelectedRows.Count >= 0 Then

            If e.ColumnIndex = 9 Then
                Dim row As New DataGridViewRow()
                row = DGV_TRP_LIST.Rows(e.RowIndex)
                Dim refno As String = row.Cells(0).Value
                SPV1_SQ_TRAVEL_CERTTableAdapter.Fill(DS_STOREDPROC.SPV1_SQ_TRAVEL_CERT, refno)

#Region "PDF"
                Dim pdfpath As String = Application.StartupPath() + "\Media_Files\PDFs\"
                Dim imagepath As String = Application.StartupPath() + "\Media_Files\pra_favcon\"
                Dim doc As New Document(PageSize.A4, 60, 60, 100, 0)
                Dim logo_size As Integer = 80
                Dim sign_size As Integer = 80
                Dim par_indent As Integer = 30
                Dim qr_size As Integer = 100
                Dim bf As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
                Dim par_body As iTextSharp.text.Font = New iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL)
                Dim details_font As iTextSharp.text.Font = New iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.NORMAL)
                Dim qr_font As iTextSharp.text.Font = New iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD)

                Dim page_num As Integer = 0
                Dim page_count As Integer = SPV1_SQ_TRAVEL_CERTBindingSource.Count

                If (Not Directory.Exists(pdfpath)) Then
                    Directory.CreateDirectory(pdfpath)
                End If

                PdfWriter.GetInstance(doc, New FileStream(pdfpath & "/" & refno & ".pdf", FileMode.Create))
                doc.Open()
                Dim jpg As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(imagepath & "logo.png")
                jpg.ScaleToFit(logo_size, logo_size)
                jpg.Alignment = iTextSharp.text.Image.ALIGN_CENTER



                For x = 0 To page_count - 1
                    Try
                        Dim par1 As New Paragraph(New Chunk("        This is to certify that the foreign national whose details are provided below has officially informed this agency of his departure from the Philippines on " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 1) & " and committed to notify our office within three (3) days from his date of return to the Philippines by sending electronic copies of his passport bio-page, visa sticker and latest Philippine Immigration arrival stamp to our official e-mail address.", par_body)) With {
                    .SpacingBefore = 40,
                    .Alignment = Element.ALIGN_JUSTIFIED
                }

                        Dim par_name As New Paragraph(New Chunk("Name : " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 2) & "", details_font)) With {
                    .SpacingBefore = 40,
                    .Alignment = Element.ALIGN_JUSTIFIED,
                    .IndentationLeft = par_indent
                }

                        Dim par_dob As New Paragraph(New Chunk("Date of Birth : " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 3) & "", details_font)) With {
                    .Alignment = Element.ALIGN_JUSTIFIED,
                    .IndentationLeft = par_indent
                }
                        Dim par_nationality As New Paragraph(New Chunk("Nationality : " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 4) & "", details_font)) With {
                    .Alignment = Element.ALIGN_JUSTIFIED,
                    .IndentationLeft = par_indent
                }
                        Dim par_pport As New Paragraph(New Chunk("Passport Number : " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 5) & "", details_font)) With {
                    .Alignment = Element.ALIGN_JUSTIFIED,
                    .IndentationLeft = par_indent
                }
                        Dim par_immig_stat As New Paragraph(New Chunk("Immigration Status/Visa : " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 6) & "", details_font)) With {
                    .Alignment = Element.ALIGN_JUSTIFIED,
                    .IndentationLeft = par_indent
                }

                        Dim par_footer As New Paragraph(New Chunk("        This Travel Pass is issued on " & BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 7) & " and is valid for thirty (30) days from date of issuance.", par_body)) With {
                    .SpacingBefore = 40,
                    .Alignment = Element.ALIGN_JUSTIFIED
                }

                        Dim Sign As Image = Image.GetInstance(imagepath & "LGA_Sign.png")
                        Sign.ScaleToFit(sign_size, sign_size)
                        Sign.SetAbsolutePosition(430, 230)

                        Dim par_fcl_pers As New Paragraph(New Chunk(BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 9), par_body)) With {
                    .SpacingBefore = 60,
                    .Alignment = Element.ALIGN_RIGHT
                }
                        Dim par_pra As New Paragraph(New Chunk(BS(SPV1_SQ_TRAVEL_CERTBindingSource, x, 10), par_body)) With {
                    .Alignment = Element.ALIGN_RIGHT
                }

                        Dim qr_code As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(GenerateCode(refno))
                        qr_code.ScaleToFit(qr_size, qr_size)
                        qr_code.SetAbsolutePosition(250, 103)



                        Dim qr_text As New Paragraph(New Chunk(refno, qr_font)) With {
                  .SpacingBefore = 98,
                    .Alignment = Element.ALIGN_CENTER
                }

                        'jpg.ScaleToFit(50.0F, 50.0F)
                        'jpg.Alignment = Image.TEXTWRAP Or Image.ALIGN_CENTER
                        'jpg.IndentationLeft = 9.0F
                        'jpg.SpacingAfter = 9.0F
                        'jpg.BorderWidthTop = 36.0F
                        'jpg.BorderColorTop = Color.White
                        If page_num > 0 Then
                            doc.NewPage()
                        End If
                        doc.Add(jpg)
                        doc.Add(par1)
                        doc.Add(par_name)
                        doc.Add(par_dob)
                        doc.Add(par_nationality)
                        doc.Add(par_pport)
                        doc.Add(par_immig_stat)
                        doc.Add(par_footer)
                        doc.Add(Sign)
                        doc.Add(par_fcl_pers)
                        doc.Add(par_pra)
                        doc.Add(qr_code)
                        doc.Add(qr_text)

                        page_num += 1
                        page_count -= 1

                    Catch ex As Exception
                        NotificationManager.Show(Me, "PDF Failed" & vbNewLine & ex.Message, Color.Red, 6000)
                        ERRLOG.WriteToErrorLog(ex.Message, ex.StackTrace, " e.ColumnIndex = 9")
                    Finally
                        If page_count = 0 Then
                            doc.Close()
                        End If
                    End Try
                Next
#End Region

#Region "EMAIL"
                Dim EmailMessage As New MailMessage()
                Dim AttachmentFile As String = pdfpath & refno & ".pdf"
                With EmailMessage
                    .From = New MailAddress(Trim("pra.entryexit@gmail.com"))
                    '.To.Add(Trim("von.0030@gmail.com"))
                    .To.Add(Trim(row.Cells(8).Value))
                    .Subject = "TRAVEL PASS"
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
                                <h3> REMINDER!!</h3>

                                <p class=""psign"">This Travel Pass Is Intended for <b>DEPARTURE</b> Purposes only!
                                </p>

                                <p class=""psign""> For <b>Entry</b> To the Philippines by SRR Visa Holders <a href=""https://www.officialgazette.gov.ph/downloads/2021/02feb/20210205-IATF-RESO-98-RRD.pdf"" class=""gaz""> (per IATF Resolution No. 98, S. 2021 dated 04 February 2021 </a>, the issuance of Entry Exemption Document (EED) Is necessary.</p>
                                <p Class=""psign""> The EED maybe obtained directly to PRA using the Re-Entry
                                                Form <a href=""https://forms.gle/58kNknEMBZECUTz9A"">https://forms.gle/58kNknEMBZECUTz9A</a> and send through <a href=""mailto:reentryrequest@pra.gov.ph"">reentryrequest@pra.gov.ph</a>. The said form shall be
                                                accompanied with photocopies of</p>

                                <ol class=""let"">
                                    <li> Bio-page of current passport;</li>
                                    <li> P.R.A. ID Card;</li>
                                    <li> SRR Visa Sticker</li>
                                    <li> SRR Visa Sticker</li>
                                    <li> Order issued by the Bureau of Immigration (for SRRV implemented on the Order (Chinese PROC National only))</li> 
                                </ol>

                                <p class=""psign"">For your guidance.</p>
                            </body>
                        </html>

                                                     "
                    .Attachments.Add(New Attachment(AttachmentFile))
                End With

                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.Credentials = New Net.NetworkCredential("pra.entryexit@gmail.com", "pr@@dm1n2017507")
                Try
                    SMTP.Send(EmailMessage)
#Region "EMAIL HISTORY"
                    TbML4_EMAIL_HISTTableAdapter.IQ_EMAIL_HIST(row.Cells(0).Value, row.Cells(8).Value)
#End Region
                    NotificationManager.Show(Me, "Email Sent!", Color.Green, 5000)
                    ' Label1.Text = "Message sent"
                Catch ex As Exception
                    NotificationManager.Show(Me, "Sending Failed!", Color.Red, 3000)
                End Try
#End Region

            End If
        End If
    End Sub
#End Region

#Region "SELECTED INDEX"
    Private Sub CB_FILTERBY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FILTERBY.SelectedIndexChanged

        If CB_FILTERBY.SelectedIndex = 3 Then
            SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text, CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
            PNL_CUSTOM.Visible = True
        Else
            SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, "", "", CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
            PNL_CUSTOM.Visible = False
        End If
        If DGV_TRP_LIST.Rows.Count = 0 Then
            PNL_NODATA.Visible = True
        Else
            PNL_NODATA.Visible = False
        End If

        LBL_TOT.Text = DGV_TRP_LIST.Rows.Count
    End Sub

    Private Sub CB_DATE_BY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_DATE_BY.SelectedIndexChanged
        If CB_FILTERBY.SelectedIndex = 3 Then
            SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, WTXT_FROM.Text, WTXT_TO.Text, CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
        Else
            SPM4_TRP_LISTTableAdapter.FillBySEARCH(DS_STOREDPROC.SPM4_TRP_LIST, TXT_SEARCH.Text, "", "", CB_FILTERBY.SelectedIndex, CB_DATE_BY.Text)
        End If
        If DGV_TRP_LIST.Rows.Count = 0 Then
            PNL_NODATA.Visible = True
        Else
            PNL_NODATA.Visible = False
        End If
        LBL_TOT.Text = DGV_TRP_LIST.Rows.Count
    End Sub


#End Region


End Class