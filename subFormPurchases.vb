Imports System.Data.SqlClient
Imports System.Globalization
Public Class subFormPurchases
    Dim condg As SqlConnection
    Dim sqlquerydg As String
    Dim adpdg As SqlDataAdapter
    Dim dsdg As DataSet
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtProductDescription_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasesProductUnit.TextChanged

    End Sub

    Private Sub bttnProductsSubmit_Click(sender As Object, e As EventArgs) Handles bttnPurchasesSubmit.Click
        txtPurchasesRate.Text = Math.Round(Val(txtPurchasesRate.Text), 2)
        txtPurchasesAmount.Text = Math.Round(Val(txtPurchasesAmount.Text), 2)
        If txtPurchasesRate.Text = "" Then
            MsgBox("Please enter the Purchase Rate.")
        ElseIf txtPurchasesProductQty.Text = "" Then
            MsgBox("Please enter the Quantity.")
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim con As SqlConnection
            Dim con2 As SqlConnection
            Dim sqlquery As SqlCommand
            Dim sqlquery2 As SqlCommand
            Dim sqlquery3 As SqlCommand

            Dim supplier_id As Integer
            Dim product_id As Integer

            'Fetch supplier id
            Try
                con2 = New SqlConnection(loginForm.dbpath)
                con2.Open()
                Dim supplier_name As String = "'" & cmbSupplierName.Text & "'"
                sqlquery2 = New SqlCommand("Select Supplier_ID From Suppliers Where Supplier_Name = " & supplier_name, con2)
                sqlquery2.ExecuteNonQuery()
                supplier_id = sqlquery2.ExecuteScalar()
                con2.Close()
            Catch ex As Exception
                MsgBox("Failed to fetch data. Try Again. " & ex.Message, vbOKOnly + vbExclamation, "Error")
                Exit Sub
            End Try

            'Fetch product details
            Try
                con2.Open()
                Dim product_name As String = "'" & cmbProductName.Text & "'"
                sqlquery3 = New SqlCommand("Select Product_ID From Products Where Product_Name = " & product_name, con2)
                sqlquery3.ExecuteNonQuery()
                product_id = sqlquery3.ExecuteScalar()
                con2.Close()
            Catch ex As Exception
                MsgBox("Failed to fetch data. Try Again. " & ex.Message, vbOKOnly + vbExclamation, "Error")
                Exit Sub
            End Try


            'Insert Data into Purchase Table
            Try
                con = New SqlConnection()
                con.ConnectionString = loginForm.dbpath
                con.Open()
            Catch ex As Exception
                MsgBox("Failed to connect to Service Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
                Exit Sub
            End Try
            Try


                sqlquery = New SqlCommand("INSERT INTO Purchases VALUES(@id,@date,@sid,@pid,@qty,@prate,@total)", con)
                sqlquery.Parameters.Add("@id", SqlDbType.Int).Value = txtPurchasesID.Text
                sqlquery.Parameters.Add("@date", SqlDbType.VarChar).Value = txtPurchasesDate.Text
                sqlquery.Parameters.Add("@sid", SqlDbType.Int).Value = supplier_id
                sqlquery.Parameters.Add("@pid", SqlDbType.Int).Value = product_id
                sqlquery.Parameters.Add("@qty", SqlDbType.Int).Value = txtPurchasesProductQty.Text
                sqlquery.Parameters.Add("@prate", SqlDbType.Real).Value = txtPurchasesRate.Text
                sqlquery.Parameters.Add("@total", SqlDbType.Real).Value = txtPurchasesAmount.Text

                If sqlquery.ExecuteNonQuery() = 1 Then
                    MsgBox("Data Successfully added. ", vbOKOnly + vbInformation, "Success!")
                    txtPurchasesID.Text = ""
                    cmbSupplierName.Text = ""
                    cmbProductName.Text = ""
                    txtPurchasesAmount.Text = ""
                    txtPurchasesProductQty.Text = ""
                    txtPurchasesProductUnit.Text = ""
                    txtPurchasesRate.Text = ""
                    ProductsForm.bttnProducts.Enabled = True
                    ProductsForm.bttnCustomers.Enabled = True
                    ProductsForm.bttnInventory.Enabled = True
                    ProductsForm.bttnPurchases.Enabled = True
                    ProductsForm.bttnSales.Enabled = True
                    ProductsForm.bttnSuppliers.Enabled = True
                    ProductsForm.bttnSettings.Enabled = True
                    panelAddPurchases.Visible = False
                End If
                con.Close()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                MsgBox("Failed to Insert data in the database. " & ex.Message, vbOKOnly + vbExclamation, "AddToDB Error")
                con.Close()
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try
        End If
        Call Load_Data_Purchases()
    End Sub

    Private Sub bttnPurchasesSearch_Click(sender As Object, e As EventArgs) Handles bttnPurchasesSearch.Click
        Dim filter As Integer
        If cmbPurchasesFilter.Text = "Search By Product" Then
            filter = 0
        ElseIf cmbPurchasesFilter.Text = "Search By Supplier" Then
            filter = 1
        ElseIf cmbPurchasesFilter.Text = "Search By Date" Then
            filter = 2
        End If
        Dim textvalue As String = txtPurchasesSearch.Text
        Select Case filter
            Case 0
                textvalue = "'" + textvalue + "'"
                Try
                    Dim con As New SqlConnection(loginForm.dbpath)
                    con.Open()
                    Dim sqlquery As New SqlCommand("Select PUR.Purchase_ID, PUR.Purchase_Date,P.Product_ID, P.Product_Name, PUR.Purchase_Qty, PUR.Purchase_Rate,  S.Supplier_ID, S.Supplier_Name, PUR.Total_Purchases_Amt From Suppliers S, Products P, Purchases PUR Where P.Product_ID = PUR.Product_ID and PUR.Supplier_ID = S.Supplier_ID and P.Product_Name =" & textvalue, con)
                    Dim adp As New SqlDataAdapter(sqlquery)
                    Dim ds As New DataSet()
                    adp.Fill(ds)
                    dgPurchases.DataSource = ds.Tables(0)
                    dgPurchases.Refresh()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Failed to find record. Please check the filter values and try again. " & ex.Message, vbOKOnly + vbExclamation, "FetchDataError")
                End Try
            Case 1
                textvalue = "'" + textvalue + "'"
                Try
                    Dim con As New SqlConnection(loginForm.dbpath)
                    con.Open()
                    Dim sqlquery As New SqlCommand("Select PUR.Purchase_ID, PUR.Purchase_Date, S.Supplier_ID, S.Supplier_Name, PUR.Purchase_Qty, PUR.Purchase_Rate, P.Product_ID, P.Product_Name, PUR.Total_Purchases_Amt From Suppliers S, Products P, Purchases PUR Where P.Product_ID = PUR.Product_ID and PUR.Supplier_ID = S.Supplier_ID and S.Supplier_Name =" & textvalue, con)
                    Dim adp As New SqlDataAdapter(sqlquery)
                    Dim ds As New DataSet()
                    adp.Fill(ds)
                    dgPurchases.DataSource = ds.Tables(0)
                    dgPurchases.Refresh()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Failed to find record. Please check the filter values and try again. " & ex.Message, vbOKOnly + vbExclamation, "FetchDataError")
                End Try
            Case 2

                textvalue = "'" + textvalue + "'"
                Try
                    Dim con As New SqlConnection(loginForm.dbpath)
                    con.Open()
                    Dim sqlquery As New SqlCommand("Select PUR.Purchase_ID, PUR.Purchase_Date, S.Supplier_ID, S.Supplier_Name, PUR.Purchase_Qty, PUR.Purchase_Rate, P.Product_ID, P.Product_Name, PUR.Total_Purchases_Amt From Suppliers S, Products P, Purchases PUR Where P.Product_ID = PUR.Product_ID and PUR.Supplier_ID = S.Supplier_ID and PUR.Purchase_Date = " & textvalue, con)
                    Dim adp As New SqlDataAdapter(sqlquery)
                    Dim ds As New DataSet()
                    adp.Fill(ds)
                    dgPurchases.DataSource = ds.Tables(0)
                    dgPurchases.Refresh()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Failed to find record. Please check the filter values and try again. " & ex.Message, vbOKOnly + vbExclamation, "FetchDataError")
                End Try
        End Select

    End Sub

    Private Sub bttnAddPurchases_Click(sender As Object, e As EventArgs) Handles bttnAddPurchases.Click
        panelAddPurchases.Visible = True

        txtPurchasesID.Text = ""
        cmbSupplierName.Text = ""
        cmbProductName.Text = ""
        txtPurchasesAmount.Text = ""
        txtPurchasesProductQty.Text = ""
        txtPurchasesProductUnit.Text = ""
        txtPurchasesRate.Text = ""

        ProductsForm.bttnProducts.Enabled = False
        ProductsForm.bttnCustomers.Enabled = False
        ProductsForm.bttnInventory.Enabled = False
        ProductsForm.bttnPurchases.Enabled = False
        ProductsForm.bttnSales.Enabled = False
        ProductsForm.bttnSuppliers.Enabled = False
        ProductsForm.bttnSettings.Enabled = False

        'Displaying data in AddPurchases Panel, cmbSupplierName
        Dim con1 As SqlConnection
        Dim adp1 As SqlDataAdapter
        Dim query1 As String
        Dim ds1 As DataSet
        Try
            con1 = New SqlConnection(loginForm.dbpath)
            query1 = "Select * from Suppliers"
            adp1 = New SqlDataAdapter(query1, con1)
            ds1 = New DataSet()

            adp1.Fill(ds1)
            cmbSupplierName.DataSource = ds1.Tables(0)
            cmbSupplierName.ValueMember = "Supplier_ID"
            cmbSupplierName.DisplayMember = "Supplier_Name"

        Catch ex As Exception
            MsgBox("Failed to Connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try

        'Displaying data in AddPurchases Panel, cmbProductName
        Dim con2 As SqlConnection
        Dim adp2 As SqlDataAdapter
        Dim query2 As String
        Dim ds2 As DataSet
        Try
            con2 = New SqlConnection(loginForm.dbpath)
            query2 = "Select * from Products"
            adp2 = New SqlDataAdapter(query2, con2)
            ds2 = New DataSet()

            adp2.Fill(ds2)
            cmbProductName.DataSource = ds2.Tables(0)
            cmbProductName.ValueMember = "Product_ID"
            cmbProductName.DisplayMember = "Product_Name"

        Catch ex As Exception
            MsgBox("Failed to Connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try

        'Auto-Generate Product-ID
        Dim con As SqlConnection
        Dim sqlquery As SqlCommand
        Try
            con = New SqlConnection(loginForm.dbpath)
            con.Open()
            sqlquery = New SqlCommand("SELECT MAX(Purchase_ID) from Purchases", con)
            Dim MaxID = 0
            Try
                MaxID = Integer.Parse(sqlquery.ExecuteScalar())
                txtPurchasesID.Text = MaxID + 1
                con.Close()
            Catch ex As Exception
                MaxID = 0
                txtPurchasesID.Text = MaxID + 1
            End Try
        Catch ex As Exception
            MsgBox("Failed to connect to database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB error")
            Exit Sub
        End Try


        ' Displaying current date in textbox
        Dim currdate As Date = DateTime.Now
        Dim currdatestr As String = currdate.ToString("dd/MM/yyyy")
        txtPurchasesDate.Text = currdatestr
    End Sub

    Private Sub subFormPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelAddPurchases.Visible = False
        txtPurchasesID.Enabled = False
        txtPurchasesAmount.Enabled = False
        cmbPurchasesFilter.Items.Add("Search By Product")
        cmbPurchasesFilter.Items.Add("Search By Supplier")
        cmbPurchasesFilter.Items.Add("Search By Date")
        Call Load_Data_Purchases()

    End Sub
    Public Sub Load_Data_Purchases()
        'connecting datagrid 

        Try
            condg = New SqlConnection(loginForm.dbpath)
            condg.Open()
            sqlquerydg = "SELECT PUR.Purchase_ID As ID,PUR.Purchase_Date As Date, S.Supplier_Name As Name, P.Product_Name , P.Product_Unit As Unit, PUR.Purchase_Qty As Quantity, PUR.Purchase_Rate As Purchase_Rate,PUR.Total_Purchases_Amt As Total_Amount FROM Suppliers S, Products P, Purchases PUR Where P.Product_ID = PUR.Product_ID and S.Supplier_ID = PUR.Supplier_ID"
            adpdg = New SqlDataAdapter(sqlquerydg, condg)
            dsdg = New DataSet()
            adpdg.Fill(dsdg)
            dgPurchases.DataSource = dsdg.Tables(0)
            dgPurchases.Refresh()
            condg.Close()
        Catch ex As Exception
            MsgBox("Failed to connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try
    End Sub
    Private Sub bttnPurchasesCancel_Click(sender As Object, e As EventArgs) Handles bttnPurchasesCancel.Click
        panelAddPurchases.Visible = False
        ProductsForm.bttnProducts.Enabled = True
        ProductsForm.bttnCustomers.Enabled = True
        ProductsForm.bttnInventory.Enabled = True
        ProductsForm.bttnPurchases.Enabled = True
        ProductsForm.bttnSales.Enabled = True
        ProductsForm.bttnSuppliers.Enabled = True
        ProductsForm.bttnSettings.Enabled = True
    End Sub


    Private Sub cmbProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductName.SelectedIndexChanged
        ' Displaying Product unit in textbox 
        Dim con3 As SqlConnection
        Dim sqlquery4 As SqlCommand
        Try
            con3 = New SqlConnection(loginForm.dbpath)
            con3.Open()
            Dim product_name As String = "'" & cmbProductName.Text & "'"
            sqlquery4 = New SqlCommand("Select Product_Unit From Products Where Product_Name = " & product_name, con3)
            sqlquery4.ExecuteNonQuery()
            txtPurchasesProductUnit.Text = sqlquery4.ExecuteScalar()
            con3.Close()
        Catch ex As Exception
            MsgBox("Failed to fetch data. Try Again. " & ex.Message, vbOKOnly + vbExclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub txtPurchasesProductQty_TextChanged(sender As Object, e As EventArgs) Handles txtPurchasesProductQty.TextChanged
        Try
            Dim result As Decimal
            result = CDec(txtPurchasesRate.Text) * CDec(txtPurchasesProductQty.Text)
            txtPurchasesAmount.Text = result
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub cmbPurchasesFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPurchasesFilter.SelectedIndexChanged
        If cmbPurchasesFilter.Text = "Search By Product" Then
            txtPurchasesSearch.Text = "Search By Product Name"
        ElseIf cmbPurchasesFilter.Text = "Search By Supplier" Then
            txtPurchasesSearch.Text = "Search By Supplier Name"
        ElseIf cmbPurchasesFilter.Text = "Search By Date" Then
            txtPurchasesSearch.Text = "Search By Date"
        End If
    End Sub
    Private Sub UpdateDg()
        Try
            adpdg.UpdateCommand = New SqlCommandBuilder(adpdg).GetUpdateCommand
            adpdg.Update(dsdg)
            MsgBox("Changes Updated to database successfully!", vbOKOnly + vbInformation, "Update Successful")
        Catch ex As Exception
            MsgBox("Purchases table cannot be deleted completely. Delete data from Suppliers or Products tables first and try again. Data is unique in other tables and contains relations, please contact developer for further support.", vbOKOnly + vbExclamation, "UpdateDataError")
        End Try
    End Sub

    Private Sub dgPurchases_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgPurchases.CellValueChanged

    End Sub

    Private Sub bttnPurchasesSave_Click(sender As Object, e As EventArgs) Handles bttnPurchasesSave.Click
        Call UpdateDg()
    End Sub

    Private Sub dgPurchases_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgPurchases.UserDeletedRow

    End Sub

    Private Sub dgPurchases_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgPurchases.UserDeletingRow
        MsgBox("Be Careful while deleting data from Purchases Table. Might generate errors. Proceed with Caution.", vbOKOnly + vbExclamation, "Caution")
    End Sub

    Private Sub bttnPurchasesGenerateReport_Click(sender As Object, e As EventArgs) 
        Cursor = Cursors.WaitCursor
        'Connecting DataSet
        Dim ds As New DataSetReportPurchases
        Dim adp As New DataSetReportPurchasesTableAdapters.DataTable1PurchasesTableAdapter
        adp.Fill(ds.DataTablePurchases)
        'Connecting Report
        Dim rpt As New CRPurchases
        rpt.SetDataSource(ds)
        ReportViewerPurchases.CRViewerPurchases.ReportSource = rpt
        'Displaying Report Viewer
        ReportViewerPurchases.ShowDialog()
        Cursor = Cursors.Default
    End Sub
End Class