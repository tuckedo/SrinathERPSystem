Imports System.ComponentModel
Imports System.Net.Mail

Public Class MailInvoice
    Private Sub bttnSelectInvoice_Click(sender As Object, e As EventArgs) Handles bttnSelectInvoice.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles OpenFileDialog1.FileOk
        bttnSendInvoice.Enabled = True
        txtAttachment.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub bttnSendInvoice_Click(sender As Object, e As EventArgs) Handles bttnSendInvoice.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Call loginForm.ReadCredentials()
            Smtp_Server.Credentials = New Net.NetworkCredential("tuckedoclay@gmail.com", "afterearth9545")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("tuckedoclay@gmail.com")
            e_mail.To.Add(txtReceiverEmail.Text)
            e_mail.Subject = "Invoice"
            e_mail.IsBodyHtml = False
            e_mail.Body = "Dear Client," & vbCrLf & "Please find attached copy of Invoice with this mail." & vbCrLf & "Warm Regards," & vbCrLf & "Srinath Building Materials and Suppliers"
            Dim attach As New Attachment(txtAttachment.Text)
            e_mail.Attachments.Add(attach)
            Smtp_Server.Send(e_mail)
            MsgBox("Mail sent successfully to client.", vbOKOnly + vbInformation, "Invoice Mail")
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Couldn't send Mail. Please check your network connection and try again. " & ex.Message, vbOKOnly + vbExclamation, "Mail")
            Cursor = Cursors.Default
            Exit Sub
        End Try
    End Sub

    Private Sub MailInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bttnSendInvoice.Enabled = False
        txtReceiverEmail.Text = "neerajmalwal10@gmail.com"
    End Sub
End Class