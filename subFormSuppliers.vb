Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class subFormSuppliers
    Dim condg As SqlConnection
    Dim sqlquerydg As String
    Dim adpdg As SqlDataAdapter
    Dim dsdg As DataSet
    Private Sub subFormSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelAddSuppliers.Visible = False
        txtSuppliersID.Enabled = False
        Call Load_Data_Suppliers()

    End Sub
    Public Sub Load_Data_Suppliers()
        'Binding Data Grid

        condg = New SqlConnection(loginForm.dbpath)
        condg.Open()
        sqlquerydg = "SELECT Supplier_ID As ID, Supplier_Name As Name, Supplier_Mobile As Mobile, Supplier_Email As Email, Supplier_Address As Address FROM Suppliers"
        adpdg = New SqlDataAdapter(sqlquerydg, condg)
        dsdg = New DataSet()
        adpdg.Fill(dsdg)
        dgSuppliers.DataSource = dsdg.Tables(0)
        dgSuppliers.Refresh()
        condg.Close()
    End Sub
    Private Sub bttnSuppliersCancel_Click(sender As Object, e As EventArgs) Handles bttnSuppliersCancel.Click
        panelAddSuppliers.Visible = False
        ProductsForm.bttnProducts.Enabled = True
        ProductsForm.bttnCustomers.Enabled = True
        ProductsForm.bttnInventory.Enabled = True
        ProductsForm.bttnPurchases.Enabled = True
        ProductsForm.bttnSales.Enabled = True
        ProductsForm.bttnSuppliers.Enabled = True
        ProductsForm.bttnSettings.Enabled = True
    End Sub

    Private Sub bttnSuppliersSearch_Click(sender As Object, e As EventArgs) Handles bttnSuppliersSearch.Click
        bttnSuppliersSearch.Enabled = True
        Dim textvalue As String
        textvalue = txtSuppliersSearch.Text
        Dim i = 0
        Try
            For i = 0 To dgSuppliers.Rows.Count - 1
                Dim targetvalue As String = dgSuppliers.Rows(i).Cells(1).Value
                If targetvalue = textvalue Then
                    dgSuppliers.Rows(i).Selected = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to find record. Please check the filter values and try again. ", vbOKOnly + vbExclamation, "FetchDataError")
        End Try
    End Sub

    Private Sub bttnAddSuppliers_Click(sender As Object, e As EventArgs) Handles bttnAddSuppliers.Click
        panelAddSuppliers.Visible = True
        txtSuppliersAddress.Text = ""
        txtSuppliersName.Text = ""
        txtSuppliersID.Text = ""
        txtSuppliersMobile.Text = ""
        txtSuppliersEmail.Text = ""
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
        Try
            con = New SqlConnection(loginForm.dbpath)
            con.Open()
            sqlquery = New SqlCommand("SELECT MAX(Supplier_ID) from Suppliers", con)
            Dim MaxID = 0
            Try
                MaxID = Integer.Parse(sqlquery.ExecuteScalar())
                txtSuppliersID.Text = MaxID + 1
                con.Close()
            Catch ex As Exception
                MaxID = 0
                txtSuppliersID.Text = MaxID + 1
            End Try
        Catch ex As Exception
            MsgBox("Failed to connect to database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB error")
            Exit Sub
        End Try
    End Sub

    Private Sub bttnSuppliersSubmit_Click(sender As Object, e As EventArgs) Handles bttnSuppliersSubmit.Click
        If txtSuppliersMobile.TextLength = 10 Then
            If txtSuppliersName.Text = "" Then
                MsgBox("Name cannot be empty.", vbOKOnly + vbExclamation)
            ElseIf txtSuppliersMobile.Text = "" Then
                MsgBox("Mobile Number cannot be empty.", vbOKOnly + vbExclamation)
            Else
                Dim par As String
                par = "^([0-9a-zA=Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
                If Regex.IsMatch(txtSuppliersEmail.Text, par) Or txtSuppliersEmail.Text = "" Then
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


                        sqlquery = New SqlCommand("INSERT INTO Suppliers VALUES(@id,@name,@mobile,@email,@address)", con)
                        sqlquery.Parameters.Add("@id", SqlDbType.Int).Value = txtSuppliersID.Text
                        sqlquery.Parameters.Add("@name", SqlDbType.VarChar).Value = txtSuppliersName.Text
                        sqlquery.Parameters.Add("@mobile", SqlDbType.VarChar).Value = txtSuppliersMobile.Text
                        sqlquery.Parameters.Add("@email", SqlDbType.VarChar).Value = txtSuppliersEmail.Text
                        sqlquery.Parameters.Add("@address", SqlDbType.VarChar).Value = txtSuppliersAddress.Text

                        If sqlquery.ExecuteNonQuery() = 1 Then
                            MsgBox("Data Successfully added. ", vbOKOnly + vbInformation, "Success!")
                            panelAddSuppliers.Visible = False
                            txtSuppliersAddress.Text = ""
                            txtSuppliersName.Text = ""
                            txtSuppliersID.Text = ""
                            txtSuppliersMobile.Text = ""
                            txtSuppliersEmail.Text = ""
                            ProductsForm.bttnProducts.Enabled = True
                            ProductsForm.bttnCustomers.Enabled = True
                            ProductsForm.bttnInventory.Enabled = True
                            ProductsForm.bttnPurchases.Enabled = True
                            ProductsForm.bttnSales.Enabled = True
                            ProductsForm.bttnSuppliers.Enabled = True
                            ProductsForm.bttnSettings.Enabled = True
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
        Call Load_Data_Suppliers()
    End Sub

    Private Sub txtSuppliersMobile_TextChanged(sender As Object, e As EventArgs) Handles txtSuppliersMobile.TextChanged


        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtSuppliersMobile.Text = digitsOnly.Replace(txtSuppliersMobile.Text, "")
    End Sub

    Private Sub txtSuppliersAddress_TextChanged(sender As Object, e As EventArgs) Handles txtSuppliersAddress.TextChanged

    End Sub

    Private Sub txtSuppliersMobile_KeyPress(sender As Object, e As EventArgs) Handles txtSuppliersMobile.KeyPress

    End Sub

    Private Sub txtSuppliersName_TextChanged(sender As Object, e As EventArgs) Handles txtSuppliersName.TextChanged

    End Sub

    Private Sub txtSuppliersName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuppliersName.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtSuppliersSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSuppliersSearch.TextChanged

    End Sub

    Private Sub txtSuppliersSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuppliersSearch.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub
    Private Sub UpdateDg()
        Try
            adpdg.UpdateCommand = New SqlCommandBuilder(adpdg).GetUpdateCommand
            adpdg.Update(dsdg)
            MsgBox("Changes Updated to database successfully!", vbOKOnly + vbInformation, "Update Successful")
        Catch ex As Exception
            MsgBox("Failed to Update changes made to database. Try again later.", vbOKOnly + vbExclamation, "UpdateDataError")
        End Try
    End Sub

    Private Sub dgSuppliers_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgSuppliers.CellValueChanged

    End Sub

    Private Sub bttnSuppliersSave_Click(sender As Object, e As EventArgs) Handles bttnSuppliersSave.Click

        Call UpdateDg()
    End Sub

    Private Sub dgSuppliers_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgSuppliers.UserDeletedRow

    End Sub

End Class