<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subFormSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSalesSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelAddSales = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtChallan = New System.Windows.Forms.TextBox()
        Me.txtSalesDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.txtSalesAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSalesProductQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bttnSalesCancel = New System.Windows.Forms.Button()
        Me.bttnSalesSubmit = New System.Windows.Forms.Button()
        Me.txtSalesProductUnit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSalesRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalesID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnAddSales = New Guna.UI.WinForms.GunaCircleButton()
        Me.bttnSalesSearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.dgSales = New Guna.UI.WinForms.GunaDataGridView()
        Me.cmbSalesFilter = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.SrinathDBDataSet = New Srinath.SrinathDBDataSet()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New Srinath.SrinathDBDataSetTableAdapters.SalesTableAdapter()
        Me.bttnSalesSave = New System.Windows.Forms.Button()
        Me.bttnSalesGenerateReport = New System.Windows.Forms.Button()
        Me.panelAddSales.SuspendLayout()
        CType(Me.dgSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SrinathDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSalesSearch
        '
        Me.txtSalesSearch.BackColor = System.Drawing.Color.White
        Me.txtSalesSearch.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSalesSearch.Location = New System.Drawing.Point(178, 69)
        Me.txtSalesSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesSearch.MaxLength = 50
        Me.txtSalesSearch.Multiline = True
        Me.txtSalesSearch.Name = "txtSalesSearch"
        Me.txtSalesSearch.Size = New System.Drawing.Size(634, 53)
        Me.txtSalesSearch.TabIndex = 20
        Me.txtSalesSearch.Text = "Select Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(423, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 41)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sales"
        '
        'panelAddSales
        '
        Me.panelAddSales.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelAddSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelAddSales.Controls.Add(Me.Label11)
        Me.panelAddSales.Controls.Add(Me.txtChallan)
        Me.panelAddSales.Controls.Add(Me.txtSalesDate)
        Me.panelAddSales.Controls.Add(Me.Label10)
        Me.panelAddSales.Controls.Add(Me.cmbProductName)
        Me.panelAddSales.Controls.Add(Me.cmbCustomerName)
        Me.panelAddSales.Controls.Add(Me.txtSalesAmount)
        Me.panelAddSales.Controls.Add(Me.Label9)
        Me.panelAddSales.Controls.Add(Me.txtSalesProductQty)
        Me.panelAddSales.Controls.Add(Me.Label8)
        Me.panelAddSales.Controls.Add(Me.bttnSalesCancel)
        Me.panelAddSales.Controls.Add(Me.bttnSalesSubmit)
        Me.panelAddSales.Controls.Add(Me.txtSalesProductUnit)
        Me.panelAddSales.Controls.Add(Me.Label6)
        Me.panelAddSales.Controls.Add(Me.txtSalesRate)
        Me.panelAddSales.Controls.Add(Me.Label5)
        Me.panelAddSales.Controls.Add(Me.Label4)
        Me.panelAddSales.Controls.Add(Me.Label3)
        Me.panelAddSales.Controls.Add(Me.txtSalesID)
        Me.panelAddSales.Controls.Add(Me.Label1)
        Me.panelAddSales.Controls.Add(Me.Label7)
        Me.panelAddSales.Location = New System.Drawing.Point(153, 87)
        Me.panelAddSales.Margin = New System.Windows.Forms.Padding(2)
        Me.panelAddSales.Name = "panelAddSales"
        Me.panelAddSales.Size = New System.Drawing.Size(755, 444)
        Me.panelAddSales.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(404, 263)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 32)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Challan No:"
        '
        'txtChallan
        '
        Me.txtChallan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallan.Location = New System.Drawing.Point(560, 274)
        Me.txtChallan.Margin = New System.Windows.Forms.Padding(2)
        Me.txtChallan.MaxLength = 10
        Me.txtChallan.Multiline = True
        Me.txtChallan.Name = "txtChallan"
        Me.txtChallan.Size = New System.Drawing.Size(178, 21)
        Me.txtChallan.TabIndex = 28
        '
        'txtSalesDate
        '
        Me.txtSalesDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesDate.Location = New System.Drawing.Point(198, 85)
        Me.txtSalesDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesDate.Multiline = True
        Me.txtSalesDate.Name = "txtSalesDate"
        Me.txtSalesDate.Size = New System.Drawing.Size(178, 21)
        Me.txtSalesDate.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(24, 83)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 32)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Date :"
        '
        'cmbProductName
        '
        Me.cmbProductName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(198, 251)
        Me.cmbProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(178, 28)
        Me.cmbProductName.TabIndex = 25
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(198, 197)
        Me.cmbCustomerName.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(178, 28)
        Me.cmbCustomerName.TabIndex = 24
        '
        'txtSalesAmount
        '
        Me.txtSalesAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesAmount.Location = New System.Drawing.Point(560, 210)
        Me.txtSalesAmount.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesAmount.Multiline = True
        Me.txtSalesAmount.Name = "txtSalesAmount"
        Me.txtSalesAmount.Size = New System.Drawing.Size(178, 21)
        Me.txtSalesAmount.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(404, 198)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 32)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Amount :"
        '
        'txtSalesProductQty
        '
        Me.txtSalesProductQty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesProductQty.Location = New System.Drawing.Point(560, 147)
        Me.txtSalesProductQty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesProductQty.Multiline = True
        Me.txtSalesProductQty.Name = "txtSalesProductQty"
        Me.txtSalesProductQty.Size = New System.Drawing.Size(178, 21)
        Me.txtSalesProductQty.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(404, 136)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 32)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Quantity :"
        '
        'bttnSalesCancel
        '
        Me.bttnSalesCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnSalesCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSalesCancel.ForeColor = System.Drawing.Color.White
        Me.bttnSalesCancel.Location = New System.Drawing.Point(403, 369)
        Me.bttnSalesCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSalesCancel.Name = "bttnSalesCancel"
        Me.bttnSalesCancel.Size = New System.Drawing.Size(244, 41)
        Me.bttnSalesCancel.TabIndex = 18
        Me.bttnSalesCancel.Text = "Cancel"
        Me.bttnSalesCancel.UseVisualStyleBackColor = False
        '
        'bttnSalesSubmit
        '
        Me.bttnSalesSubmit.BackColor = System.Drawing.Color.Peru
        Me.bttnSalesSubmit.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSalesSubmit.ForeColor = System.Drawing.Color.White
        Me.bttnSalesSubmit.Location = New System.Drawing.Point(105, 369)
        Me.bttnSalesSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSalesSubmit.Name = "bttnSalesSubmit"
        Me.bttnSalesSubmit.Size = New System.Drawing.Size(244, 41)
        Me.bttnSalesSubmit.TabIndex = 17
        Me.bttnSalesSubmit.Text = "Submit"
        Me.bttnSalesSubmit.UseVisualStyleBackColor = False
        '
        'txtSalesProductUnit
        '
        Me.txtSalesProductUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesProductUnit.Location = New System.Drawing.Point(560, 85)
        Me.txtSalesProductUnit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesProductUnit.MaxLength = 10
        Me.txtSalesProductUnit.Multiline = True
        Me.txtSalesProductUnit.Name = "txtSalesProductUnit"
        Me.txtSalesProductUnit.Size = New System.Drawing.Size(178, 21)
        Me.txtSalesProductUnit.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(404, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Unit :"
        '
        'txtSalesRate
        '
        Me.txtSalesRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesRate.Location = New System.Drawing.Point(198, 305)
        Me.txtSalesRate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesRate.MaxLength = 10
        Me.txtSalesRate.Multiline = True
        Me.txtSalesRate.Name = "txtSalesRate"
        Me.txtSalesRate.Size = New System.Drawing.Size(178, 21)
        Me.txtSalesRate.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 295)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sales Rate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Product name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "To :"
        '
        'txtSalesID
        '
        Me.txtSalesID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesID.Location = New System.Drawing.Point(198, 139)
        Me.txtSalesID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSalesID.Multiline = True
        Me.txtSalesID.Name = "txtSalesID"
        Me.txtSalesID.Size = New System.Drawing.Size(178, 21)
        Me.txtSalesID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(273, 13)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 41)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Sales Entry"
        '
        'bttnAddSales
        '
        Me.bttnAddSales.AnimationHoverSpeed = 0.07!
        Me.bttnAddSales.AnimationSpeed = 0.03!
        Me.bttnAddSales.BackColor = System.Drawing.Color.White
        Me.bttnAddSales.BaseColor = System.Drawing.Color.White
        Me.bttnAddSales.BorderColor = System.Drawing.Color.Black
        Me.bttnAddSales.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnAddSales.FocusedColor = System.Drawing.Color.Empty
        Me.bttnAddSales.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnAddSales.ForeColor = System.Drawing.Color.White
        Me.bttnAddSales.Image = Global.Srinath.My.Resources.Resources.Button_Add_1_512
        Me.bttnAddSales.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnAddSales.Location = New System.Drawing.Point(821, 66)
        Me.bttnAddSales.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnAddSales.Name = "bttnAddSales"
        Me.bttnAddSales.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnAddSales.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAddSales.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAddSales.OnHoverImage = Nothing
        Me.bttnAddSales.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAddSales.Size = New System.Drawing.Size(72, 63)
        Me.bttnAddSales.TabIndex = 22
        '
        'bttnSalesSearch
        '
        Me.bttnSalesSearch.AnimationHoverSpeed = 0.07!
        Me.bttnSalesSearch.AnimationSpeed = 0.03!
        Me.bttnSalesSearch.BackColor = System.Drawing.Color.White
        Me.bttnSalesSearch.BaseColor = System.Drawing.Color.Transparent
        Me.bttnSalesSearch.BorderColor = System.Drawing.Color.Transparent
        Me.bttnSalesSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnSalesSearch.FocusedColor = System.Drawing.Color.Empty
        Me.bttnSalesSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnSalesSearch.ForeColor = System.Drawing.Color.White
        Me.bttnSalesSearch.Image = Global.Srinath.My.Resources.Resources.search
        Me.bttnSalesSearch.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnSalesSearch.Location = New System.Drawing.Point(750, 74)
        Me.bttnSalesSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSalesSearch.Name = "bttnSalesSearch"
        Me.bttnSalesSearch.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnSalesSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnSalesSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnSalesSearch.OnHoverImage = Nothing
        Me.bttnSalesSearch.OnPressedColor = System.Drawing.Color.Black
        Me.bttnSalesSearch.Size = New System.Drawing.Size(54, 43)
        Me.bttnSalesSearch.TabIndex = 21
        '
        'dgSales
        '
        Me.dgSales.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgSales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSales.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSales.ColumnHeadersHeight = 50
        Me.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSales.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSales.EnableHeadersVisualStyles = False
        Me.dgSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgSales.Location = New System.Drawing.Point(19, 157)
        Me.dgSales.Margin = New System.Windows.Forms.Padding(2)
        Me.dgSales.Name = "dgSales"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSales.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgSales.RowHeadersVisible = False
        Me.dgSales.RowHeadersWidth = 82
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgSales.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgSales.RowTemplate.Height = 33
        Me.dgSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSales.Size = New System.Drawing.Size(906, 500)
        Me.dgSales.TabIndex = 25
        Me.dgSales.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dgSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgSales.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgSales.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite
        Me.dgSales.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgSales.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgSales.ThemeStyle.HeaderStyle.Height = 50
        Me.dgSales.ThemeStyle.ReadOnly = False
        Me.dgSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSales.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgSales.ThemeStyle.RowsStyle.Height = 33
        Me.dgSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cmbSalesFilter
        '
        Me.cmbSalesFilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSalesFilter.FormattingEnabled = True
        Me.cmbSalesFilter.Location = New System.Drawing.Point(40, 68)
        Me.cmbSalesFilter.Name = "cmbSalesFilter"
        Me.cmbSalesFilter.Size = New System.Drawing.Size(133, 25)
        Me.cmbSalesFilter.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(37, 48)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Search Filters :"
        '
        'SrinathDBDataSet
        '
        Me.SrinathDBDataSet.DataSetName = "SrinathDBDataSet"
        Me.SrinathDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.SrinathDBDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'bttnSalesSave
        '
        Me.bttnSalesSave.BackColor = System.Drawing.Color.Peru
        Me.bttnSalesSave.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSalesSave.ForeColor = System.Drawing.Color.White
        Me.bttnSalesSave.Location = New System.Drawing.Point(313, 676)
        Me.bttnSalesSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSalesSave.Name = "bttnSalesSave"
        Me.bttnSalesSave.Size = New System.Drawing.Size(122, 41)
        Me.bttnSalesSave.TabIndex = 30
        Me.bttnSalesSave.Text = "Save"
        Me.bttnSalesSave.UseVisualStyleBackColor = False
        '
        'bttnSalesGenerateReport
        '
        Me.bttnSalesGenerateReport.BackColor = System.Drawing.Color.SaddleBrown
        Me.bttnSalesGenerateReport.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSalesGenerateReport.ForeColor = System.Drawing.Color.White
        Me.bttnSalesGenerateReport.Location = New System.Drawing.Point(456, 676)
        Me.bttnSalesGenerateReport.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSalesGenerateReport.Name = "bttnSalesGenerateReport"
        Me.bttnSalesGenerateReport.Size = New System.Drawing.Size(244, 41)
        Me.bttnSalesGenerateReport.TabIndex = 31
        Me.bttnSalesGenerateReport.Text = "Generate Invoice"
        Me.bttnSalesGenerateReport.UseVisualStyleBackColor = False
        '
        'subFormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 772)
        Me.Controls.Add(Me.panelAddSales)
        Me.Controls.Add(Me.bttnSalesGenerateReport)
        Me.Controls.Add(Me.bttnSalesSave)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbSalesFilter)
        Me.Controls.Add(Me.bttnAddSales)
        Me.Controls.Add(Me.bttnSalesSearch)
        Me.Controls.Add(Me.txtSalesSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "subFormSales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelAddSales.ResumeLayout(False)
        Me.panelAddSales.PerformLayout()
        CType(Me.dgSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SrinathDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnAddSales As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents bttnSalesSearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txtSalesSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents panelAddSales As Panel
    Friend WithEvents txtSalesAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSalesProductQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents bttnSalesCancel As Button
    Friend WithEvents bttnSalesSubmit As Button
    Friend WithEvents txtSalesProductUnit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSalesRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSalesID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents cmbCustomerName As ComboBox
    Friend WithEvents txtSalesDate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtChallan As TextBox
    Friend WithEvents dgSales As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cmbSalesFilter As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
    Friend WithEvents SrinathDBDataSet As SrinathDBDataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As SrinathDBDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents bttnSalesSave As Button
    Friend WithEvents bttnSalesGenerateReport As Button
End Class
