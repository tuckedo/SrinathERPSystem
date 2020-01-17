Imports System.Net.Mail
Imports System.IO
Public Class forgotpassword
    Dim currOTP As Integer
    Private Sub forgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewPassword.Enabled = False
        txtConfirmPassword.Enabled = False
        txtOTP.Enabled = False
        bttnVerify.Enabled = False
        bttnResetPassword.Enabled = False
    End Sub

    Private Sub GunaPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnSend_Click(sender As Object, e As EventArgs) Handles bttnSend.Click
        bttnSend.Enabled = False
        If (SendOTP()) Then
            MsgBox("Please check your mail for OTP. ", vbOKOnly + vbInformation, "OTP Verification")
            bttnVerify.Enabled = True
            txtOTP.Enabled = True
        Else
            bttnSend.Enabled = True
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Public Function SendOTP() As Boolean
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Call loginForm.ReadCredentials()
            Smtp_Server.Credentials = New Net.NetworkCredential("neerajmalwal10@gmail.com", "9545earthafter")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("neerajmalwal10@gmail.com")
            e_mail.To.Add(loginForm.username)
            e_mail.Subject = "OTP Verification"
            e_mail.IsBodyHtml = False
            currOTP = GenerateOTP()
            e_mail.Body = currOTP
            Smtp_Server.Send(e_mail)
            Return True
        Catch ex As Exception
            MsgBox("Couldn't generate OTP. " & ex.Message, vbOKOnly + vbExclamation, "OTP Verification Error")
            Return False
            Exit Function
        End Try
    End Function

    Private Sub bttnResetPassword_Click(sender As Object, e As EventArgs) Handles bttnResetPassword.Click
        If txtNewPassword.Text = txtConfirmPassword.Text Then
            Call loginForm.UpdateCredentials(txtConfirmPassword.Text)
            MsgBox("Password Successfully changed. ", vbOKOnly + vbInformation, "OTP Verification")
            loginForm.Show()
            Me.Hide()
        Else
            MsgBox("The Password and Confirmation Password do not match.", vbOK + vbExclamation)
        End If

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtOTP_TextChanged(sender As Object, e As EventArgs) Handles txtOTP.TextChanged

    End Sub

    Private Sub bttnVerify_Click(sender As Object, e As EventArgs) Handles bttnVerify.Click
        bttnVerify.Enabled = False
        If txtOTP.Text = currOTP Then
            MsgBox("OTP Successfully Verified!. ", vbOKOnly + vbInformation, "OTP Verification")
            txtNewPassword.Enabled = True
            txtConfirmPassword.Enabled = True
            bttnResetPassword.Enabled = True
        Else
            MsgBox("Incorrect OTP! Try Again. ", vbOKOnly + vbExclamation, "OTP Verification Error")
            bttnSend.Enabled = True
            bttnSend.Enabled = True
        End If
    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs) Handles bttnBack.Click
        Me.Hide()
        loginForm.Show()
    End Sub
    Private Function GenerateOTP() As Integer
        Dim otp As Integer
        Dim rs As New Random
        otp = rs.Next(111, 999)
        Return otp
    End Function

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class