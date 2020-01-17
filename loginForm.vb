Imports System.IO

Public Class loginForm
    Public Const dbpath As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TechUp\Srinath\SrinathDB.mdf;Integrated Security=True"
    Private eye As Boolean
    Public username As String
    Public password As String
    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "neerajmalwal10@gmail.com"
        Me.BackgroundImage = Srinath.My.Resources.cement
        GunaPictureBox1.Image = Srinath.My.Resources.newuser
        GunaCirclePictureBox2.Image = Srinath.My.Resources.eyeClose
        txtPassword.PasswordChar = "*"
        GunaCirclePictureBox3.Image = Srinath.My.Resources.login
        GunaCirclePictureBox4.Image = Srinath.My.Resources.password
        eye = False

    End Sub

    Private Sub GunaCirclePictureBox2_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox2.Click
        If eye = False Then
            GunaCirclePictureBox2.Image = Srinath.My.Resources.eyeOpen
            eye = True
            txtPassword.PasswordChar = ""
        Else
            GunaCirclePictureBox2.Image = Srinath.My.Resources.eyeClose
            eye = False
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub bttnForgotPassword_Click(sender As Object, e As EventArgs) Handles bttnForgotPassword.Click
        forgotpassword.Show()
        Me.Hide()
    End Sub

    Private Sub bttnLogin_Click(sender As Object, e As EventArgs) Handles bttnLogin.Click
        ReadCredentials()
        If txtUsername.Text = username And txtPassword.Text = password Then
            ProductsForm.Show()
            Me.Hide()
        Else
            MsgBox("incorrect username or password!", vbOKOnly + vbExclamation, "incorrect credentials error")
            Exit Sub
        End If
    End Sub
    Public Sub ReadCredentials()
        Try
            Using sr As StreamReader = New StreamReader("D:/TechUp/Srinath/bin/UsernamePassword/protected.txt")
                Dim line As String
                line = sr.ReadLine()
                username = line
                line = sr.ReadLine()
                password = line
            End Using
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub UpdateCredentials(ByVal strpass As String)
        Try
            password = strpass
            Using sw As StreamWriter = New StreamWriter("D:/TechUp/Srinath/bin/UsernamePassword/protected.txt")
                sw.WriteLine(username)
                sw.WriteLine(password)
            End Using
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub bttnBack_Click(sender As Object, e As EventArgs)

    End Sub
End Class
