Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class subFormCustomers
    Dim conDg As SqlConnection
    Dim sqlqueryDg As String
    Dim adpDg As SqlDataAdapter
    Dim dsDg As DataSet
    Private Sub subFormCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelAddCustomers.Visible = False
        Call Load_Data_Customers()
        txtCustomersID.Enabled = False

    End Sub
    Public Sub Load_Data_Customers()
        'Binding Data Grid

        Try
            conDg = New SqlConnection(loginForm.dbpath)
            conDg.Open()
            sqlqueryDg = "Select Customer_ID As ID, Customer_Name As Name, Customer_Mobile As Mobile, Customer_Email As Email, Customer_Address As Address FROM Customers"
            adpDg = New SqlDataAdapter(sqlqueryDg, conDg)
            dsDg = New DataSet()
            adpDg.Fill(dsDg)
            dgCustomers.DataSource = dsDg.Tables(0)
            dgCustomers.Refresh()

            conDg.Close()
        Catch ex As Exception
            MsgBox("Failed To connect To Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try
    End Sub
    Private Sub bttnAddCustomers_Click(sender As Object, e As EventArgs) Handles bttnAddCustomers.Click
        panelAddCustomers.Visible = True

        txtCustomersAddress.Text = ""
        txtCustomersName.Text = ""
        txtCustomersID.Text = ""
        txtCustomersMobile.Text = ""
        txtCustomersEmail.Text = ""
        ProductsForm.bttnProducts.Enabled = False
        ProductsForm.bttnCustomers.Enabled = False
        ProductsForm.bttnInventory.Enabled = False
        ProductsForm.bttnPurchases.Enabled = False
        ProductsForm.bttnSales.Enabled = False
        ProductsForm.bttnSuppliers.Enabled = False
        ProductsForm.bttnSettings.Enabled = False
        'Auto-Generate Product-ID
        Dim con As SqlConnection
        Dim sqlquery As SqlCommand
        Dim MaxID = 0
        Try
            con = New SqlConnection(loginForm.dbpath)
            con.Open()
            sqlquery = New SqlCommand("SELECT MAX(Customer_ID) from Customers", con)

            Try
                MaxID = Integer.Parse(sqlquery.ExecuteScalar())
                txtCustomersID.Text = MaxID + 1
                con.Close()
            Catch ex As Exception
                MaxID = 0
                txtCustomersID.Text = MaxID + 1
            End Try
        Catch ex As Exception
            MsgBox("Failed to connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try
    End Sub

    Private Sub bttnCustomersCancel_Click(sender As Object, e As EventArgs) Handles bttnCustomersCancel.Click
        panelAddCustomers.Visible = False
        ProductsForm.bttnProducts.Enabled = True
        ProductsForm.bttnCustomers.Enabled = True
        ProductsForm.bttnInventory.Enabled = True
        ProductsForm.bttnPurchases.Enabled = True
        ProductsForm.bttnSales.Enabled = True
        ProductsForm.bttnSuppliers.Enabled = True
        ProductsForm.bttnSettings.Enabled = True
    End Sub

    Private Sub bttnCustomersSubmit_Click(sender As Object, e As EventArgs) Handles bttnCustomersSubmit.Click
        If txtCustomersMobile.TextLength = 10 Then

            If txtCustomersName.Text = "" Then
                MsgBox("Name cannot be empty.", vbOKOnly + vbExclamation)
            ElseIf txtCustomersMobile.Text = "" Then
                MsgBox("Mobile Number cannot be empty.", vbOKOnly + vbExclamation)
            Else
                Dim par As String
                par = "^([0-9a-zA=Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
                If Regex.IsMatch(txtCustomersEmail.Text, par) Or txtCustomersEmail.Text = "" Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim con As SqlConnection
                    Dim sqlquery As SqlCommand
                    Try
                        con = New SqlConnection()
                        con.ConnectionString = loginForm.dbpath
                        con.Open()
                    Catch ex As Exception
                        MsgBox("Failed to connect to Service Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
                        Exit Sub
                    End Try
                    Try

                        sqlquery = New SqlCommand("INSERT INTO Customers VALUES(@id,@name,@mobile,@email,@address)", con)
                        sqlquery.Parameters.Add("@id", SqlDbType.Int).Value = txtCustomersID.Text
                        sqlquery.Parameters.Add("@name", SqlDbType.VarChar).Value = txtCustomersName.Text
                        sqlquery.Parameters.Add("@mobile", SqlDbType.VarChar).Value = txtCustomersMobile.Text
                        sqlquery.Parameters.Add("@email", SqlDbType.VarChar).Value = txtCustomersEmail.Text
                        sqlquery.Parameters.Add("@address", SqlDbType.VarChar).Value = txtCustomersAddress.Text
                        If sqlquery.ExecuteNonQuery() = 1 Then
                            MsgBox("Data Successfully added. ", vbOKOnly + vbInformation, "Success!")

                            txtCustomersAddress.Text = ""
                            txtCustomersName.Text = ""
                            txtCustomersID.Text = ""
                            txtCustomersMobile.Text = ""
                            txtCustomersEmail.Text = ""
                            ProductsForm.bttnProducts.Enabled = True
                            ProductsForm.bttnCustomers.Enabled = True
                            ProductsForm.bttnInventory.Enabled = True
                            ProductsForm.bttnPurchases.Enabled = True
                            ProductsForm.bttnSales.Enabled = True
                            ProductsForm.bttnSuppliers.Enabled = True
                            ProductsForm.bttnSettings.Enabled = True
                            panelAddCustomers.Visible = False
                        End If
                        con.Close()
                        Me.Cursor = Cursors.Default
                    Catch ex As Exception
                        MsgBox("Failed to Insert data in the database. " & ex.Message, vbOKOnly + vbExclamation, "AddToDB Error")
                        con.Close()
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End Try

                Else
                    MsgBox("Please enter a valid Email Id.", vbOKOnly + vbExclamation)
                End If


            End If
        Else
            MsgBox("Please enter a valid Mobile Number.", vbOKOnly + vbExclamation)
        End If
        Call Load_Data_Customers()
    End Sub

    Private Sub txtCustomersMobile_TextChanged(sender As Object, e As EventArgs) Handles txtCustomersMobile.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtCustomersMobile.Text = digitsOnly.Replace(txtCustomersMobile.Text, "")
    End Sub

    Private Sub txtCustomersSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCustomersSearch.TextChanged

    End Sub

    Private Sub bttnCustomersSearch_Click(sender As Object, e As EventArgs) Handles bttnCustomersSearch.Click
        Dim textvalue As String
        textvalue = txtCustomersSearch.Text
        Dim i = 0
        Try
            For i = 0 To dgCustomers.Rows.Count - 1
                Dim targetvalue As String = dgCustomers.Rows(i).Cells(1).Value
                If targetvalue = textvalue Then
                    dgCustomers.Rows(i).Selected = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to find record. Please check the filter values and try again. ", vbOKOnly + vbExclamation, "FetchDataError")
        End Try
    End Sub

    Private Sub txtCustomersEmail_TextChanged(sender As Object, e As EventArgs) Handles txtCustomersEmail.TextChanged

    End Sub



    Private Sub txtCustomersAddress_TextChanged(sender As Object, e As EventArgs) Handles txtCustomersAddress.TextChanged

    End Sub

    Private Sub txtCustomersMobile_TabIndexChanged(sender As Object, e As EventArgs) Handles txtCustomersMobile.TabIndexChanged

    End Sub

    Private Sub txtCustomersName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomersName.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtCustomersSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustomersSearch.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub UpdateDg()
        Try
            adpDg.UpdateCommand = New SqlCommandBuilder(adpDg).GetUpdateCommand
            adpDg.Update(dsDg)
            MsgBox("Changes Updated to database successfully!", vbOKOnly + vbInformation, "Update Successful")
        Catch ex As Exception
            MsgBox("Failed to Update changes made to database. Try again later.", vbOKOnly + vbExclamation, "UpdateDataError")
        End Try
    End Sub

    Private Sub dgCustomers_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgCustomers.CellValueChanged

    End Sub

    Private Sub bttnCustomersSave_Click(sender As Object, e As EventArgs) Handles bttnCustomersSave.Click

        Call UpdateDg()
    End Sub

    Private Sub dgCustomers_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgCustomers.UserDeletedRow

    End Sub

    Private Sub txtCustomersName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomersName.TextChanged

    End Sub
End Class