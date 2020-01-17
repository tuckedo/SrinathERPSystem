Imports System.Data.SqlClient
Public Class subFormInventory
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtSalesearch_TextChanged(sender As Object, e As EventArgs) Handles txtInventorySearch.TextChanged


    End Sub

    Private Sub bttnAddSales_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttnSalesSearch_Click(sender As Object, e As EventArgs) Handles bttnInventorySearch.Click
        Try
            Dim con As New SqlConnection(loginForm.dbpath)
            con.Open()
            Dim sqlquery As New SqlCommand("Select DISTINCT I.Inventory_Date, P.Product_ID, P.Product_Name, P.Product_Unit, I.Available_Stock From Inventory_Master I, Products P  where I.Product_ID = P.Product_ID", con)
            Dim adp As New SqlDataAdapter(sqlquery)
            Dim ds As New DataSet()
            adp.Fill(ds)
            dgInventory.DataSource = ds.Tables(0)
            dgInventory.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox("Failed to load Bills table. Try again later or contact developer for further support.", vbOKOnly + vbExclamation, "FetchDataError")
        End Try
    End Sub
    Public Sub Load_Data_Inventory()
        Dim idval As Integer
        Dim stock As Integer
        'Delete previous data
        'Clear duplicates from Inventory_Master
        Call ClearDuplicates()
        Try
            Dim con1 As New SqlConnection(loginForm.dbpath)
            con1.Open()
            Dim sqlquery As New SqlCommand("Delete From Inventory", con1)
            sqlquery.ExecuteNonQuery()
            con1.Close()
        Catch ex As Exception
        End Try
        'Adding new data
        Dim currdate As String = Format(Date.Now, "dd/MM/yyyy")
        'connecting to datagrid
        Dim con As New SqlConnection(loginForm.dbpath)
        con.Open()

        Dim dsInventory As New DataSet()
        Dim adpInventory = New SqlDataAdapter("Select I.Inventory_Date As Date, P.Product_ID, P.Product_Name, P.Product_Unit,I.Available_Stock From Products P, Inventory I where P.Product_ID = I.Product_ID", con)
        adpInventory.Fill(dsInventory)
        Dim bindingsrc As New BindingSource()
        Dim dsProducts As New DataSet()
        Dim adpProducts As New SqlDataAdapter("Select * from Products", con)
        adpProducts.Fill(dsProducts)
        For Each ProductRow As DataRow In dsProducts.Tables(0).Rows
            idval = Integer.Parse(ProductRow("Product_ID").ToString())
            'calculating available_stock
            Dim sqlcommpurchases As New SqlCommand("Select SUM(Purchase_Qty) From Purchases where Product_ID = " & idval, con)
            sqlcommpurchases.ExecuteNonQuery()
            Dim purchaseqty As Integer = 0
            Dim salesqty As Integer = 0
            Try
                purchaseqty = Integer.Parse(sqlcommpurchases.ExecuteScalar())
            Catch ex As Exception
                Exit Try
            End Try
            Dim sqlcommsales As New SqlCommand("Select SUM(Sales_Qty) From Sales where Product_ID = " & idval, con)
            sqlcommsales.ExecuteNonQuery()

            Try
                salesqty = Integer.Parse(sqlcommsales.ExecuteScalar())
            Catch ex As Exception
                Exit Try
            End Try
            stock = purchaseqty - salesqty
            Dim sqlcomm As New SqlCommand("insert into Inventory Values(@date,@id,@stock)", con)
            sqlcomm.Parameters.Add("@id", SqlDbType.Int).Value = idval
            sqlcomm.Parameters.Add("@date", SqlDbType.VarChar).Value = currdate
            sqlcomm.Parameters.Add("@stock", SqlDbType.Int).Value = stock
            'Update Inventory_Master
            Call UpdateInventoryMaster(currdate, idval, stock)
            sqlcomm.ExecuteNonQuery()
            stock = 0
            purchaseqty = 0
            salesqty = 0
        Next
        con.Close()
        'Reload DataGridView
        Try
            Dim con2 As New SqlConnection(loginForm.dbpath)
            con2.Open()
            Dim ds As New DataSet()
            Dim adp As New SqlDataAdapter("Select I.Inventory_Date As Date, P.Product_ID, P.Product_Name, P.Product_Unit,I.Available_Stock From Products P, Inventory I where P.Product_ID = I.Product_ID", con2)
            adp.Fill(ds)
            bindingsrc.DataSource = ds.Tables(0)
            dgInventory.DataSource = ds.Tables(0)
            dgInventory.Refresh()
            con2.Close()
        Catch ex As Exception
            MsgBox("Failed to connect to Database. " & ex.Message, vbOKOnly + vbExclamation, "ConnectToDB Error")
            Exit Sub
        End Try
    End Sub
    Private Sub subFormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_Inventory()
    End Sub

    Private Sub bttnInventoryGenerateReport_Click(sender As Object, e As EventArgs) 
        Cursor = Cursors.WaitCursor
        'Connecting DataSet
        Dim ds As New DataSetInventoryReport
        Dim adp As New DataSetInventoryReportTableAdapters.DataTableInventoryTableAdapter
        adp.Fill(ds.DataTableInventory)
        'Connecting Report
        Dim rpt As New CRInventory
        rpt.SetDataSource(ds)
        ReportViewerInventory.CRViewerInventory.ReportSource = rpt
        'Displaying Report Viewer
        ReportViewerInventory.ShowDialog()
        Cursor = Cursors.Default
    End Sub
    Private Sub UpdateInventoryMaster(ByVal paramcurrdate As String, ByVal paramid As Integer, ByVal paramstock As Integer)
        Try
            Dim con As New SqlConnection(loginForm.dbpath)
            con.Open()
            Dim sqlcomm As New SqlCommand("insert into Inventory_Master Values(@date,@id,@stock)", con)
            sqlcomm.Parameters.Add("@id", SqlDbType.Int).Value = paramid
            sqlcomm.Parameters.Add("@date", SqlDbType.VarChar).Value = paramcurrdate
            sqlcomm.Parameters.Add("@stock", SqlDbType.Int).Value = paramstock
            sqlcomm.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ClearDuplicates()
        Try

            Dim connect As New SqlConnection(loginForm.dbpath)
            connect.Open()
            Dim sqlcomm1 As New SqlCommand("WITH cte AS (Select  *, ROW_NUMBER() OVER (Partition BY Inventory_Date Order by  Inventory_Date ) As row_num FROM Inventory_Master) Delete From cte where row_num > 1", connect)
            sqlcomm1.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub subFormInventory_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

    End Sub
End Class