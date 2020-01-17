Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class subFormProducts
    Dim dgcon As SqlConnection
    Dim dgsqlquery As String
    Dim dgadp As SqlDataAdapter
    Dim dgds As DataSet
    Private Sub bttnAddProducts_Click(sender As Object, e As EventArgs) Handles bttnAddProducts.Click
        panelAddProducts.Visible = True

        txtProductDescription.Text = ""
        txtProductName.Text = ""
        txtProductUnit.Text = ""
        txtProductRate.Text = ""
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
        Dim maxid As Integer
        Try
            con = New SqlConnection(loginForm.dbpath)
            con.Open()
            sqlquery = New SqlCommand("SELECT MAX(Product_ID) from Products", con)
            Try
                maxid = Integer.Parse(sqlquery.ExecuteScalar())
                txtProductID.Text = maxid + 1
                con.Close()
            Catch ex As Exception
                maxid = 0
                txtProductID.Text = maxid + 1
            End Try
        Catch ex As Exception
            MsgBox("Failed to connect to database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB error")
            Exit Sub
        End Try
    End Sub
    Private Sub subFormProducts_Load(sender As Object, e As EventArgs) Handles Me.Load
        panelAddProducts.Visible = False
        Call Load_Data_Products()
        txtProductID.Enabled = False
    End Sub
    Public Sub Load_Data_Products()
        Call BindDataGrid()
    End Sub

    Private Sub txtProductsSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductsSearch.TextChanged
        bttnProductsSearch.Enabled = True
    End Sub

    Private Sub bttnProductsCancel_Click_1(sender As Object, e As EventArgs) Handles bttnProductsCancel.Click
        panelAddProducts.Visible = False
        ProductsForm.bttnProducts.Enabled = True
        ProductsForm.bttnCustomers.Enabled = True
        ProductsForm.bttnInventory.Enabled = True
        ProductsForm.bttnPurchases.Enabled = True
        ProductsForm.bttnSales.Enabled = True
        ProductsForm.bttnSuppliers.Enabled = True
        ProductsForm.bttnSettings.Enabled = True
    End Sub

    Private Sub bttnProductsSubmit_Click(sender As Object, e As EventArgs) Handles bttnProductsSubmit.Click
        If txtProductName.Text = "" Then
            MsgBox("Name cannot be empty.", vbOKOnly + vbExclamation)
        ElseIf txtProductRate.Text = "" Then
            MsgBox("Rate Number cannot be empty.", vbOKOnly + vbExclamation)
        ElseIf txtProductUnit.Text = "" Then
            MsgBox("Unit Number cannot be empty.", vbOKOnly + vbExclamation)
        Else
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

                sqlquery = New SqlCommand("INSERT INTO Products(Product_ID, Product_Name, Product_Unit, Product_Base_Rate, Product_Desc) VALUES(@id,@name,@unit,@rate,@desc)", con)
                sqlquery.Parameters.Add("@id", SqlDbType.Int).Value = txtProductID.Text
                sqlquery.Parameters.Add("@name", SqlDbType.VarChar).Value = txtProductName.Text
                sqlquery.Parameters.Add("@unit", SqlDbType.Char).Value = txtProductUnit.Text
                sqlquery.Parameters.Add("@rate", SqlDbType.Real).Value = txtProductRate.Text
                sqlquery.Parameters.Add("@desc", SqlDbType.VarChar).Value = txtProductDescription.Text
                If sqlquery.ExecuteNonQuery() = 1 Then
                    MsgBox("Data Successfully added. ", vbOKOnly + vbInformation, "Success!")
                    txtProductID.Text = ""
                    txtProductDescription.Text = ""
                    txtProductName.Text = ""
                    txtProductUnit.Text = ""
                    txtProductRate.Text = ""
                    ProductsForm.bttnProducts.Enabled = True
                    ProductsForm.bttnCustomers.Enabled = True
                    ProductsForm.bttnInventory.Enabled = True
                    ProductsForm.bttnPurchases.Enabled = True
                    ProductsForm.bttnSales.Enabled = True
                    ProductsForm.bttnSuppliers.Enabled = True
                    ProductsForm.bttnSettings.Enabled = True
                    panelAddProducts.Visible = False
                End If
                con.Close()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                MsgBox("Failed to Insert data in the database. " & ex.Message, vbOKOnly + vbExclamation, "AddToDB Error")
                con.Close()
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
            Call BindDataGrid()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Call Load_Data_Products()
    End Sub

    Private Sub bttnProductsSearch_Click(sender As Object, e As EventArgs) Handles bttnProductsSearch.Click
        Dim textvalue As String
        textvalue = txtProductsSearch.Text
        Dim i = 0
        Try
            For i = 0 To dgProducts.Rows.Count - 1
                Dim targetvalue As String = dgProducts.Rows(i).Cells(1).Value
                If targetvalue = textvalue Then
                    dgProducts.Rows(i).Selected = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to find record. Please check the filter values and try again. ", vbOKOnly + vbExclamation, "FetchDataError")
        End Try
    End Sub
    Private Sub UpdateDg()
        Try
            dgadp.UpdateCommand = New SqlCommandBuilder(dgadp).GetUpdateCommand
            dgadp.Update(dgds)
            MsgBox("Changes Updated to database successfully!", vbOKOnly + vbInformation, "Update Successful")
        Catch ex As Exception
            MsgBox("Failed to Update changes made to database. Try again later.", vbOKOnly + vbExclamation, "UpdateDataError")
        End Try
    End Sub

    Private Sub dgProducts_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducts.CellValueChanged

    End Sub

    Private Sub bttnProductsSave_Click(sender As Object, e As EventArgs) Handles bttnProductsSave.Click

        Call UpdateDg()
    End Sub

    Private Sub dgProducts_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgProducts.UserDeletedRow

    End Sub

    Private Sub txtProductUnit_TextChanged(sender As Object, e As EventArgs) Handles txtProductUnit.TextChanged

    End Sub

    Private Sub txtProductUnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductUnit.KeyPress
        If Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub



    Private Sub txtProductRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProductRate.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 32 Or Asc(e.KeyChar) = 8 Then
            Exit Sub
        Else
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtProductRate_TextChanged(sender As Object, e As EventArgs) Handles txtProductRate.TextChanged

    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged

    End Sub
    Private Sub BindDataGrid()
        'Binding Data Grid

        Try
            dgcon = New SqlConnection(loginForm.dbpath)
            dgcon.Open()
            dgsqlquery = "SELECT Product_ID As ID, Product_Name As Name, Product_Unit As Unit, Product_Base_Rate As Rate, Product_Desc As Description FROM Products"
            dgadp = New SqlDataAdapter(dgsqlquery, dgcon)
            dgds = New DataSet()
            dgadp.Fill(dgds)
            dgProducts.DataSource = dgds.Tables(0)
            dgProducts.Refresh()
            dgcon.Close()
        Catch ex As Exception
            MsgBox("Failed to connect to database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB error")
            Exit Sub
        End Try
    End Sub

    Private Sub panelAddProducts_Paint(sender As Object, e As PaintEventArgs) Handles panelAddProducts.Paint

    End Sub
End Class