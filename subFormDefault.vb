Public Class subFormDefault
    Private Sub subFormDefault_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcurrtime.Text = Now
        Dim today = DateTime.Now
        lblDayDate.Text = String.Format("{0:dddd, MMMM d}", today)
        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblcurrtime.Text = Format(String.Format("{0:hh:mm tt}", Now)
)
    End Sub

    Private Sub lblDayDate_Click(sender As Object, e As EventArgs) Handles lblDayDate.Click

    End Sub
End Class