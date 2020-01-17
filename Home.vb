Imports System.Data.SqlClient
Public Class ProductsForm



    Private Sub buttnAddProducts_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnProductsSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnProductsCancel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnCustomers_Click(sender As Object, e As EventArgs) Handles bttnCustomers.Click
        Cursor = Cursors.WaitCursor
        bttnCustomers.LineLeft = 10
        bttnProducts.LineLeft = 0
        bttnSuppliers.LineLeft = 0
        bttnSales.LineLeft = 0
        bttnPurchases.LineLeft = 0
        bttnInventory.LineLeft = 0
        subFormProducts.Hide()
        subFormSuppliers.Hide()
        subFormPurchases.Hide()
        subFormSales.Hide()
        subFormInventory.Hide()
        Panel3.Controls.Remove(subFormProducts)
        Panel3.Controls.Remove(subFormSuppliers)
        Panel3.Controls.Remove(subFormPurchases)
        Panel3.Controls.Remove(subFormSales)
        Panel3.Controls.Remove(subFormInventory)
        With subFormCustomers
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormCustomers)
            .Show()
        End With
        Call subFormCustomers.Load_Data_Customers()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttnProducts_Click(sender As Object, e As EventArgs) Handles bttnProducts.Click
        Cursor = Cursors.WaitCursor
        bttnCustomers.LineLeft = 0
        bttnSuppliers.LineLeft = 0
        bttnProducts.LineLeft = 10
        bttnPurchases.LineLeft = 0
        bttnSales.LineLeft = 0
        bttnInventory.LineLeft = 0
        subFormCustomers.Hide()
        subFormSuppliers.Hide()
        subFormPurchases.Hide()
        subFormInventory.Hide()
        subFormDefault.Hide()
        subFormSales.Hide()
        Panel3.Controls.Remove(subFormDefault)
        Panel3.Controls.Remove(subFormCustomers)
        Panel3.Controls.Remove(subFormSuppliers)
        Panel3.Controls.Remove(subFormPurchases)
        Panel3.Controls.Remove(subFormSales)
        Panel3.Controls.Remove(subFormInventory)

        With subFormProducts
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormProducts)
            .Show()
        End With
        subFormProducts.Load_Data_Products()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttnSuppliers_Click(sender As Object, e As EventArgs) Handles bttnSuppliers.Click
        Cursor = Cursors.WaitCursor
        bttnCustomers.LineLeft = 0
        bttnSuppliers.LineLeft = 10
        bttnProducts.LineLeft = 0
        bttnPurchases.LineLeft = 0
        bttnSales.LineLeft = 0
        bttnInventory.LineLeft = 0
        subFormCustomers.Hide()
        subFormProducts.Hide()
        subFormPurchases.Hide()
        subFormInventory.Hide()
        subFormSales.Hide()
        subFormDefault.Hide()
        Panel3.Controls.Remove(subFormDefault)
        Panel3.Controls.Remove(subFormCustomers)
        Panel3.Controls.Remove(subFormProducts)
        Panel3.Controls.Remove(subFormPurchases)
        Panel3.Controls.Remove(subFormSales)
        Panel3.Controls.Remove(subFormInventory)
        With subFormSuppliers
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormSuppliers)
            .Show()
        End With
        Call subFormSuppliers.Load_Data_Suppliers()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttnPurchases_Click(sender As Object, e As EventArgs) Handles bttnPurchases.Click
        Cursor = Cursors.WaitCursor
        bttnCustomers.LineLeft = 0
        bttnSuppliers.LineLeft = 0
        bttnProducts.LineLeft = 0
        bttnPurchases.LineLeft = 10
        bttnSales.LineLeft = 0
        bttnInventory.LineLeft = 0
        subFormCustomers.Hide()
        subFormProducts.Hide()
        subFormSuppliers.Hide()
        subFormInventory.Hide()
        subFormSales.Hide()
        subFormDefault.Hide()
        Panel3.Controls.Remove(subFormDefault)
        Panel3.Controls.Remove(subFormCustomers)
        Panel3.Controls.Remove(subFormProducts)
        Panel3.Controls.Remove(subFormSuppliers)
        Panel3.Controls.Remove(subFormSales)
        Panel3.Controls.Remove(subFormInventory)
        With subFormPurchases
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormPurchases)
            .Show()
        End With
        Call subFormPurchases.Load_Data_Purchases()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttnSales_Click(sender As Object, e As EventArgs) Handles bttnSales.Click
        Cursor = Cursors.WaitCursor
        bttnCustomers.LineLeft = 0
        bttnSuppliers.LineLeft = 0
        bttnProducts.LineLeft = 0
        bttnPurchases.LineLeft = 0
        bttnSales.LineLeft = 10
        bttnInventory.LineLeft = 0
        subFormCustomers.Hide()
        subFormProducts.Hide()
        subFormSuppliers.Hide()
        subFormPurchases.Hide()
        subFormInventory.Hide()
        subFormDefault.Hide()
        Panel3.Controls.Remove(subFormDefault)
        Panel3.Controls.Remove(subFormCustomers)
        Panel3.Controls.Remove(subFormProducts)
        Panel3.Controls.Remove(subFormSuppliers)
        Panel3.Controls.Remove(subFormPurchases)
        Panel3.Controls.Remove(subFormInventory)
        With subFormSales
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormSales)
            .Show()
        End With
        Call subFormSales.Load_Data_Sales()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttnInventory_Click(sender As Object, e As EventArgs) Handles bttnInventory.Click
        Cursor = Cursors.WaitCursor
        bttnCustomers.LineLeft = 0
        bttnSuppliers.LineLeft = 0
        bttnProducts.LineLeft = 0
        bttnPurchases.LineLeft = 0
        bttnSales.LineLeft = 0
        bttnInventory.LineLeft = 10
        subFormCustomers.Hide()
        subFormProducts.Hide()
        subFormSuppliers.Hide()
        subFormPurchases.Hide()
        subFormSales.Hide()
        subFormDefault.Hide()
        Panel3.Controls.Remove(subFormDefault)
        Panel3.Controls.Remove(subFormCustomers)
        Panel3.Controls.Remove(subFormProducts)
        Panel3.Controls.Remove(subFormSuppliers)
        Panel3.Controls.Remove(subFormPurchases)
        Panel3.Controls.Remove(subFormSales)

        With subFormInventory
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormInventory)
            .Show()
        End With
        Call subFormInventory.Load_Data_Inventory()
        Cursor = Cursors.Default
    End Sub

    Private Sub bttnSettings_Click(sender As Object, e As EventArgs) Handles bttnSettings.Click
        panelSettings.Visible = True
        panelSettings.BringToFront()
        subFormProducts.panelAddProducts.Enabled = False
    End Sub

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelSettings.Visible = False
        With subFormDefault
            .BringToFront()
            .TopLevel = False
            Panel3.Controls.Add(subFormDefault)
            .Show()
        End With
    End Sub

    Private Sub bttnSettingsCancel_Click(sender As Object, e As EventArgs) Handles bttnSettingsCancel.Click
        panelSettings.Visible = False
        subFormProducts.panelAddProducts.Enabled = True
    End Sub

    Private Sub bttnLogout_Click(sender As Object, e As EventArgs) Handles bttnLogout.Click

        If (MsgBox("Are you sure you want to Log out ? (You will be re-directed to the Login Screen)", vbYesNo + vbInformation, "Log Out") = vbYes) Then
            loginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub bttnResetPassword_Click(sender As Object, e As EventArgs) Handles bttnResetPassword.Click
        If (MsgBox("Are you sure you want to Reset Password ? (You will be re-directed to the Forgot Password Screen)", vbYesNo + vbQuestion, "Reset Password") = vbYes) Then
            forgotpassword.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub bttnAbout_Click(sender As Object, e As EventArgs) Handles bttnAbout.Click
        MsgBox("Software created by Tuckedo Software Solutions. Software created for Srinath Building Materials And Suppliers." + vbCrLf + "All Rights Reserved. @2019. Any attempt to copy this software or use it without consent shall invite legal action. ", vbOKOnly + vbInformation, "About")
    End Sub

    Private Sub bttnResetDB_Click(sender As Object, e As EventArgs) Handles bttnResetDB.Click
        If (MsgBox("Are you sure you want to Reset the database ? (All the data from all the tables in the data would be deleted. Proceed with caution.)", vbYesNo + vbQuestion, "Reset Password") = vbYes) Then

            Try
                Dim con As New SqlConnection(loginForm.dbpath)
                con.Open()
                Dim sqlcomm As New SqlCommand("Delete from Products", con)
                Dim sqlcomm2 As New SqlCommand("Delete from Customers", con)
                Dim sqlcomm3 As New SqlCommand("Delete from Suppliers", con)
                Dim sqlcomm4 As New SqlCommand("Delete from Sales", con)
                Dim sqlcomm5 As New SqlCommand("Delete from Purchases", con)
                Dim sqlcomm7 As New SqlCommand("Delete from Inventory_Master", con)
                sqlcomm.ExecuteNonQuery()
                sqlcomm2.ExecuteNonQuery()
                sqlcomm3.ExecuteNonQuery()
                sqlcomm4.ExecuteNonQuery()
                sqlcomm5.ExecuteNonQuery()
                sqlcomm7.ExecuteNonQuery()
                MsgBox("Database Reset Successful.", vbOKOnly + vbInformation, "Reset Database")
                con.Close()
            Catch ex As Exception
                MsgBox("Could not Reset Database.", vbOKOnly + vbExclamation, "Reset Database")
            End Try

        End If
    End Sub



    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class