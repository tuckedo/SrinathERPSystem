Imports System.Data.SqlClient

Public Class subFormSales
    Public firstbill As Boolean
    Public billno As Integer
    Dim condg As SqlConnection
    Dim sqlquerydg As String
    Dim adpdg As SqlDataAdapter
    Dim dsdg As DataSet

    Private Sub bttnAddSales_Click(sender As Object, e As EventArgs) Handles bttnAddSales.Click
        Try
            Dim con As New SqlConnection(loginForm.dbpath)
            con.Open()
            Dim sqlcomm As New SqlCommand("Select * from Inventory_Master", con)
            Dim datareader As SqlDataReader = sqlcomm.ExecuteReader()
            If datareader.HasRows() = False Then
                MsgBox("You do not have adequate stock to make a sale. Please purchase stock, reload Inventory module and try again!")
                Exit Sub
            Else
                Call LoadAddSalesPanel(False)
                firstbill = True
            End If
            con.Close()
        Catch ex As Exception
        End Try

    End Sub
    Public Sub Load_Data_Sales()
        'connecting datagrid 

        Try
            condg = New SqlConnection(loginForm.dbpath)
            condg.Open()
            sqlquerydg = "SELECT S.Sales_ID As ID,S.Sales_Date, C.Customer_Name As Name, P.Product_Name , P.Product_Unit As Unit, S.Sales_Qty As Quantity, S.Sales_Rate As Sales_Rate,S.Total_Sales_Amt As Total_Amount,Challan_No,Bill_No FROM Customers C, Products P, Sales S Where P.Product_ID = S.Product_ID and C.Customer_ID = S.Customer_ID"
            adpdg = New SqlDataAdapter(sqlquerydg, condg)
            dsdg = New DataSet()
            adpdg.Fill(dsdg)
            dgSales.DataSource = dsdg.Tables(0)
            dgSales.Refresh()
            condg.Close()
        Catch ex As Exception
            MsgBox("Failed to connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try
    End Sub
    Private Sub subFormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelAddSales.Visible = False
        txtSalesID.Enabled = False
        txtSalesDate.Enabled = True
        cmbSalesFilter.Items.Add("Search By Product")
        cmbSalesFilter.Items.Add("Search By Customer")
        cmbSalesFilter.Items.Add("Search By Date")
        Call Load_Data_Sales()
        bttnSalesGenerateReport.Enabled = False
    End Sub

    Private Sub bttnSalesCancel_Click(sender As Object, e As EventArgs) Handles bttnSalesCancel.Click
        panelAddSales.Visible = False
        ProductsForm.bttnProducts.Enabled = True
        ProductsForm.bttnCustomers.Enabled = True
        ProductsForm.bttnInventory.Enabled = True
        ProductsForm.bttnPurchases.Enabled = True
        ProductsForm.bttnSales.Enabled = True
        ProductsForm.bttnSuppliers.Enabled = True
        ProductsForm.bttnSettings.Enabled = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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
            txtSalesProductUnit.Text = sqlquery4.ExecuteScalar()
            con3.Close()
        Catch ex As Exception
            MsgBox("Failed to fetch data. Try Again. " & ex.Message, vbOKOnly + vbExclamation, "Error")
            Exit Sub
        End Try
    End Sub

    Private Sub txtSalesProductQty_TextChanged(sender As Object, e As EventArgs) Handles txtSalesProductQty.TextChanged
        Try
            Dim result As Decimal
            result = CDec(txtSalesRate.Text) * CDec(txtSalesProductQty.Text)
            txtSalesAmount.Text = result
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub bttnSalesSubmit_Click(sender As Object, e As EventArgs) Handles bttnSalesSubmit.Click

        txtSalesRate.Text = Math.Round(Val(txtSalesRate.Text), 2)
        txtSalesAmount.Text = Math.Round(Val(txtSalesAmount.Text), 2)
        'check for quantity in Inventory
        Dim conqtycheck As SqlConnection
        Dim sqlqueryqtycheck As SqlCommand
        Dim sqlqueryIDfetch As SqlCommand
        Try
            conqtycheck = New SqlConnection(loginForm.dbpath)
            conqtycheck.Open()
            Dim product_name As String = "'" & cmbProductName.Text & "'"
            sqlqueryIDfetch = New SqlCommand("Select Product_ID From Products Where Product_Name = " & product_name, conqtycheck)
            Dim product_ID As Integer
            product_ID = Integer.Parse(sqlqueryIDfetch.ExecuteScalar())
            sqlqueryqtycheck = New SqlCommand("Select Max(Available_Stock) From Inventory_Master Where Product_ID = " & product_ID, conqtycheck)
            Dim available_stock As Integer = Integer.Parse(sqlqueryqtycheck.ExecuteScalar())
            If Integer.Parse(txtSalesProductQty.Text) > available_stock Then
                MsgBox("You do not have adequate stock for this product. Please purchase stock for this product and try again!")
                Exit Sub
            End If
            conqtycheck.Close()
        Catch ex As Exception
            Exit Sub
        End Try
        If txtSalesRate.Text = "" Then
            MsgBox("Please enter the sale Rate.")
        ElseIf txtSalesProductQty.Text = "" Then
            MsgBox("Please enter the Quantity.")
        ElseIf txtChallan.Text = "" Then
            MsgBox("Please enter challan no or 0 if not applicable.")
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim con As SqlConnection
            Dim con2 As SqlConnection
            Dim sqlquery As SqlCommand
            Dim sqlquery2 As SqlCommand
            Dim sqlquery3 As SqlCommand
            Dim customer_id As Integer
            Dim product_id As Integer

            Dim salesid As Integer
            'Fetch customer id
            Try
                con2 = New SqlConnection(loginForm.dbpath)
                con2.Open()
                Dim customer_name As String = "'" & cmbCustomerName.Text & "'"
                sqlquery2 = New SqlCommand("Select Customer_ID From Customers Where Customer_Name = " & customer_name, con2)
                sqlquery2.ExecuteNonQuery()
                customer_id = sqlquery2.ExecuteScalar()
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

            'Insert Data into Sales Table
            Try
                con = New SqlConnection()
                con.ConnectionString = loginForm.dbpath
                con.Open()
            Catch ex As Exception
                MsgBox("Failed to connect to Service Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
                Exit Sub
            End Try
            Try

                salesid = txtSalesID.Text
                sqlquery = New SqlCommand("INSERT INTO Sales(Sales_ID,Sales_Date,Customer_ID,Product_ID,Sales_Qty,Sales_Rate,Total_Sales_Amt,Challan_No,Bill_No) VALUES(@id,@date,@cid,@pid,@qty,@srate,@total,@challan,@bill)", con)
                sqlquery.Parameters.Add("@id", SqlDbType.Int).Value = txtSalesID.Text
                'generating bill no
                Dim billno = GetBillNo()
                sqlquery.Parameters.Add("@date", SqlDbType.VarChar).Value = txtSalesDate.Text
                sqlquery.Parameters.Add("@cid", SqlDbType.Int).Value = customer_id
                sqlquery.Parameters.Add("@pid", SqlDbType.Int).Value = product_id
                sqlquery.Parameters.Add("@qty", SqlDbType.Int).Value = txtSalesProductQty.Text
                sqlquery.Parameters.Add("@srate", SqlDbType.Real).Value = txtSalesRate.Text
                sqlquery.Parameters.Add("@total", SqlDbType.Real).Value = txtSalesAmount.Text
                sqlquery.Parameters.Add("@challan", SqlDbType.Int).Value = txtChallan.Text
                sqlquery.Parameters.Add("@bill", SqlDbType.Int).Value = billno

                If sqlquery.ExecuteNonQuery() = 1 Then
                    MsgBox("Data Successfully added. ", vbOKOnly + vbInformation, "Success!")
                    panelAddSales.Visible = False
                    txtSalesID.Text = ""
                    'cmbCustomerName.Text = ""
                    cmbProductName.Text = ""
                    txtSalesAmount.Text = ""
                    txtSalesProductQty.Text = ""
                    txtSalesProductUnit.Text = ""
                    txtSalesRate.Text = ""
                    txtSalesDate.Text = ""
                End If
                con.Close()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                MsgBox("Failed to Insert data. " & ex.Message, vbOKOnly + vbExclamation, "AddToDB error")
                Exit Sub
            End Try


            'New Entry
            Dim check As Integer = MsgBox("Do you want to add another product?", vbYesNo + vbInformation, "Sales")
            If check = vbYes Then
                Call LoadAddSalesPanel(True)
                cmbCustomerName.Enabled = False
                txtChallan.Enabled = True
                txtSalesDate.Enabled = False
                txtSalesID.Enabled = False
                cmbProductName.Text = ""
            Else
                cmbCustomerName.Text = ""
                Call InitializeInvoice()
                txtChallan.Text = ""
                txtChallan.Enabled = True
                cmbCustomerName.Enabled = True
                panelAddSales.Visible = False
                ProductsForm.bttnProducts.Enabled = True
                ProductsForm.bttnCustomers.Enabled = True
                ProductsForm.bttnInventory.Enabled = True
                ProductsForm.bttnPurchases.Enabled = True
                ProductsForm.bttnSales.Enabled = True
                ProductsForm.bttnSuppliers.Enabled = True
                ProductsForm.bttnSettings.Enabled = True
                bttnSalesGenerateReport.Enabled = True
            End If
        End If
        Call Load_Data_Sales()
    End Sub

    Private Sub txtSalesID_TextChanged(sender As Object, e As EventArgs) Handles txtSalesID.TextChanged

    End Sub

    Private Sub txtSalesAmount_TextChanged(sender As Object, e As EventArgs) Handles txtSalesAmount.TextChanged

    End Sub

    Private Sub bttnSalesSearch_Click(sender As Object, e As EventArgs) Handles bttnSalesSearch.Click
        Dim filter As Integer
        If cmbSalesFilter.Text = "Search By Product" Then
            filter = 0
        ElseIf cmbSalesFilter.Text = "Search By Customer" Then
            filter = 1
        ElseIf cmbSalesFilter.Text = "Search By Date" Then
            filter = 2

        End If
        Dim textvalue As String = txtSalesSearch.Text
        Select Case filter
            Case 0

                textvalue = "'" + textvalue + "'"
                Try
                    Dim con As New SqlConnection(loginForm.dbpath)
                    con.Open()
                    Dim sqlquery As New SqlCommand("Select S.Sales_ID, S.Sales_Date, P.Product_ID, P.Product_Name, S.Sales_Qty, S.Sales_Rate, C.Customer_ID, C.Customer_Name, S.Total_Sales_Amt, S.Challan_No,S.Bill_No From Customers C, Products P, Sales S Where P.Product_ID = S.Product_ID and C.Customer_ID = S.Customer_ID and Product_Name =" & textvalue, con)
                    Dim adp As New SqlDataAdapter(sqlquery)
                    Dim ds As New DataSet()
                    adp.Fill(ds)
                    dgSales.DataSource = ds.Tables(0)
                    dgSales.Refresh()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Failed to find record. Please check the filter values and try again. " & ex.Message, vbOKOnly + vbExclamation, "FetchDataError")
                End Try
            Case 1

                textvalue = "'" + textvalue + "'"
                Try
                    Dim con As New SqlConnection(loginForm.dbpath)
                    con.Open()
                    Dim sqlquery As New SqlCommand("Select S.Sales_ID, S.Sales_Date, C.Customer_ID, C.Customer_Name, S.Sales_Qty, S.Sales_Rate, P.Product_ID, P.Product_Name, S.Total_Sales_Amt, S.Challan_No,S.Bill_No  From Customers C, Products P, Sales S Where P.Product_ID = S.Product_ID and C.Customer_ID = S.Customer_ID and Customer_Name =" & textvalue, con)
                    Dim adp As New SqlDataAdapter(sqlquery)
                    Dim ds As New DataSet()
                    adp.Fill(ds)
                    dgSales.DataSource = ds.Tables(0)
                    dgSales.Refresh()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Failed to find record. Please check the filter values and try again. " & ex.Message, vbOKOnly + vbExclamation, "FetchDataError")
                End Try
            Case 2

                textvalue = "'" + textvalue + "'"
                Try
                    Dim con As New SqlConnection(loginForm.dbpath)
                    con.Open()
                    Dim sqlquery As New SqlCommand("Select S.Sales_ID, S.Sales_Date, C.Customer_ID, C.Customer_Name, P.Product_ID, P.Product_Name, S.Sales_Qty, S.Sales_Rate, S.Total_Sales_Amt, S.Challan_No, S.Bill_No  From Customers C, Products P, Sales S Where P.Product_ID = S.Product_ID and C.Customer_ID = S.Customer_ID and S.Sales_Date =" & textvalue, con)
                    Dim adp As New SqlDataAdapter(sqlquery)
                    Dim ds As New DataSet()
                    adp.Fill(ds)
                    dgSales.DataSource = ds.Tables(0)
                    dgSales.Refresh()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Failed to find record. Please check the filter values and try again. " & ex.Message, vbOKOnly + vbExclamation, "FetchDataError")
                End Try
        End Select

    End Sub

    Private Sub bttnSalesGenerateReport_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub LoadAddSalesPanel(newentry As Boolean)
        panelAddSales.Visible = True
        txtSalesID.Text = ""
        txtSalesID.Enabled = False
        cmbProductName.Text = ""
        txtSalesAmount.Text = ""
        txtSalesAmount.Enabled = False
        txtSalesProductQty.Text = ""
        txtSalesProductUnit.Text = ""
        txtSalesProductUnit.Enabled = False
        txtSalesRate.Text = ""
        txtSalesDate.Text = ""
        txtSalesDate.Enabled = True


        ProductsForm.bttnProducts.Enabled = False
        ProductsForm.bttnCustomers.Enabled = False
        ProductsForm.bttnInventory.Enabled = False
        ProductsForm.bttnPurchases.Enabled = False
        ProductsForm.bttnSales.Enabled = False
        ProductsForm.bttnSuppliers.Enabled = False
        ProductsForm.bttnSettings.Enabled = False
        If newentry = False Then
            'Displaying data in AddPurchases Panel, cmbSupplierName
            Dim con1 As SqlConnection
            Dim adp1 As SqlDataAdapter
            Dim query1 As String
            Dim ds1 As DataSet
            Try
                con1 = New SqlConnection(loginForm.dbpath)
                query1 = "Select * from Customers"
                adp1 = New SqlDataAdapter(query1, con1)
                ds1 = New DataSet()

                adp1.Fill(ds1)
                cmbCustomerName.DataSource = ds1.Tables(0)
                cmbCustomerName.ValueMember = "Customer_ID"
                cmbCustomerName.DisplayMember = "Customer_Name"

            Catch ex As Exception
                MsgBox("Failed to Connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
                Exit Sub
            End Try
        End If
        'Displaying data in AddSales Panel, cmbProductName
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
            sqlquery = New SqlCommand("SELECT MAX(Sales_ID) from Sales", con)
            Dim MaxID = 0
            Try
                MaxID = Integer.Parse(sqlquery.ExecuteScalar())
                txtSalesID.Text = MaxID + 1
                con.Close()
            Catch ex As Exception
                MaxID = 0
                txtSalesID.Text = MaxID + 1
            End Try
        Catch ex As Exception
            MsgBox("Failed to connect to database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB error")
            Exit Sub
        End Try


        ' Displaying current date in textbox
        Dim currdate As Date = DateTime.Now
        Dim currdatestr As String = currdate.ToString("dd/MM/yyyy")
        txtSalesDate.Text = currdatestr
    End Sub
    Public Function GetBillNo()
        Dim billno As Integer
        'Auto-Generate Bill no
        Dim con1 As SqlConnection = New SqlConnection(loginForm.dbpath)
        Dim sqlquery1 As SqlCommand
        Try
            If firstbill = True Then
                con1.Open()
                sqlquery1 = New SqlCommand("SELECT MAX(Bill_No) from Sales", con1)
                Dim MaxID = 0

                Try
                    MaxID = Integer.Parse(sqlquery1.ExecuteScalar())
                    billno = MaxID + 1
                    con1.Close()
                Catch ex As Exception
                    MaxID = 0
                    billno = MaxID + 1
                End Try
                firstbill = False
                Return billno
            Else
                Try
                    con1.Open()
                    sqlquery1 = New SqlCommand("SELECT MAX(Bill_No) from Sales", con1)
                    Dim MaxID = Integer.Parse(sqlquery1.ExecuteScalar())
                    billno = MaxID
                    con1.Close()
                    Return billno
                Catch ex As Exception
                End Try
            End If

        Catch ex As Exception

        End Try

    End Function
    Public Sub InitializeInvoice()

        Dim con As SqlConnection
        Dim adp As SqlDataAdapter
        Dim query As String
        Dim ds As DataSet
        'BillNo
        con = New SqlConnection(loginForm.dbpath)
        con.Open()
        Dim MaxID As Integer
        Dim sqlcomm As New SqlCommand("Select Max(Bill_No) from Sales", con)
        MaxID = Integer.Parse(sqlcomm.ExecuteScalar())
        Srinath.Invoice.lblBillNo.Text = MaxID
        'Connecting data grid
        Try
            con = New SqlConnection(loginForm.dbpath)
            con.Open()
            query = "Select P.Product_ID As ID, P.Product_Name As Name, Challan_No As Challan,S.Sales_Qty As Qty, S.Sales_Rate As Rate, P.Product_Unit As Unit, S.Total_Sales_Amt As Amount From Sales S, Products P where S.Product_ID = P.Product_ID and Bill_No = " & MaxID
            adp = New SqlDataAdapter(query, con)
            ds = New DataSet()
            adp.Fill(ds)
            Srinath.Invoice.dgInvoice.DataSource = ds.Tables(0)
            Srinath.Invoice.dgInvoice.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox("Failed to Connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try
        'setting values for labels
        con.Open()
        'Customer Details
        'Customer Name
        Dim sqlcomm2 As New SqlCommand("Select C.Customer_Name from Customers C, Sales S where S.Customer_ID = C.Customer_ID and Bill_No = " & MaxID, con)
        Srinath.Invoice.lblCustomerName.Text = sqlcomm2.ExecuteScalar()
        'Customer ID
        Dim sqlcomm3 As New SqlCommand("Select C.Customer_ID from Customers C, Sales S where S.Customer_ID = C.Customer_ID and Bill_No = " & MaxID, con)
        Srinath.Invoice.lblCustomerID.Text = sqlcomm3.ExecuteScalar()
        'Customer Mobile
        Dim sqlcomm4 As New SqlCommand("Select C.Customer_Mobile from Customers C, Sales S where S.Customer_ID = C.Customer_ID and Bill_No = " & MaxID, con)
        Srinath.Invoice.lblCustomerMobile.Text = sqlcomm4.ExecuteScalar()
        'Customer Email
        Dim sqlcomm5 As New SqlCommand("Select C.Customer_Email from Customers C, Sales S where S.Customer_ID = C.Customer_ID and Bill_No = " & MaxID, con)
        Srinath.Invoice.lblCustomerEmail.Text = sqlcomm5.ExecuteScalar()
        'Customer Address 
        Dim sqlcomm6 As New SqlCommand("Select C.Customer_Address from Customers C, Sales S where S.Customer_ID = C.Customer_ID and Bill_No = " & MaxID, con)
        Srinath.Invoice.lblCustomerAddress.Text = sqlcomm6.ExecuteScalar()

        'Date
        Srinath.Invoice.lblDate.Text = Format(Date.Now, "dd/MM/yyyy")
        'Grand Total
        Dim sqlcomm7 As New SqlCommand("Select Sum(Total_Sales_Amt) from Sales where Bill_No = " & MaxID, con)
        Srinath.Invoice.lblGrandTotal.Text = sqlcomm7.ExecuteScalar()
        con.Close()
    End Sub

    Private Sub cmbSalesFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSalesFilter.SelectedIndexChanged
        If cmbSalesFilter.Text = "Search By Product" Then
            bttnSalesSearch.Enabled = True
            txtSalesSearch.Text = "Search By Product Name"
        ElseIf cmbSalesFilter.Text = "Search By Customer" Then
            bttnSalesSearch.Enabled = True
            txtSalesSearch.Text = "Search By Customer Name"
        ElseIf cmbSalesFilter.Text = "Search By Date" Then
            bttnSalesSearch.Enabled = True
            txtSalesSearch.Text = "Search By Date"

        End If
    End Sub
    Private Sub UpdateDg()
        Try
            adpdg.UpdateCommand = New SqlCommandBuilder(adpdg).GetUpdateCommand
            adpdg.Update(dsdg)
            MsgBox("Changes Updated to database successfully!", vbOKOnly + vbInformation, "Update Successful")
        Catch ex As Exception
            MsgBox("Sales table cannot be Updated or deleted completely. Update or Delete data from Customers or Products tables first and try again. Data is unique in other tables and contains relations, please contact developer for further support.", vbOKOnly + vbExclamation, "UpdateDataError")
        End Try
    End Sub

    Private Sub dgSales_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgSales.CellValueChanged

    End Sub

    Private Sub bttnSalesSave_Click(sender As Object, e As EventArgs) Handles bttnSalesSave.Click

        Call UpdateDg()
    End Sub

    Private Sub dgSales_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgSales.UserDeletedRow

    End Sub

    Private Sub dgSales_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgSales.UserDeletingRow
        MsgBox("Be Careful while deleting data from Sales Table. Might generate errors. Proceed with Caution.", vbOKOnly + vbExclamation, "Caution")
    End Sub

    Private Sub txtSalesRate_TextChanged(sender As Object, e As EventArgs) Handles txtSalesRate.TextChanged

    End Sub

    Private Sub txtSalesRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesRate.KeyPress

    End Sub

    Private Sub bttnSalesGenerateReport_Click_1(sender As Object, e As EventArgs) Handles bttnSalesGenerateReport.Click
        Cursor = Cursors.WaitCursor
        bttnSalesGenerateReport.Enabled = False
        Invoice.Show()
        Cursor = Cursors.Default
    End Sub
End Class