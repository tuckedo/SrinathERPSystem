
Public Class Invoice

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblGrandTotal_Click(sender As Object, e As EventArgs) Handles lblGrandTotal.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PrintInvoice()
        Try
            Me.PrintForm2.Print()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgInvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgInvoice.CellContentClick

    End Sub

    Private Sub Invoice_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        ContextMenuStripInvoice.Show(e.X, e.Y)
    End Sub

    Private Sub PrintInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintInvoiceToolStripMenuItem.Click
        Call PrintInvoice()
    End Sub

    Private Sub MailInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailInvoiceToolStripMenuItem.Click
        Srinath.MailInvoice.Show()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub lblCustomerName_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub lblCustomerMobile_Click(sender As Object, e As EventArgs) Handles lblCustomerMobile.Click

    End Sub

    Private Sub lblCustomerEmail_Click(sender As Object, e As EventArgs) Handles lblCustomerEmail.Click

    End Sub

    Private Sub lblCustomerAddress_Click(sender As Object, e As EventArgs) Handles lblCustomerAddress.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblBillNo_Click(sender As Object, e As EventArgs) Handles lblBillNo.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub lblCustomerID_Click(sender As Object, e As EventArgs) Handles lblCustomerID.Click

    End Sub
End Class