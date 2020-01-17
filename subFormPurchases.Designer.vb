<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subFormPurchases
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPurchasesSearch = New System.Windows.Forms.TextBox()
        Me.panelAddPurchases = New System.Windows.Forms.Panel()
        Me.txtPurchasesDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbProductName = New System.Windows.Forms.ComboBox()
        Me.cmbSupplierName = New System.Windows.Forms.ComboBox()
        Me.txtPurchasesAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPurchasesProductQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bttnPurchasesCancel = New System.Windows.Forms.Button()
        Me.bttnPurchasesSubmit = New System.Windows.Forms.Button()
        Me.txtPurchasesProductUnit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPurchasesRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPurchasesID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgPurchases = New Guna.UI.WinForms.GunaDataGridView()
        Me.cmbPurchasesFilter = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bttnPurchasesSave = New System.Windows.Forms.Button()
        Me.bttnAddPurchases = New Guna.UI.WinForms.GunaCircleButton()
        Me.bttnPurchasesSearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.panelAddPurchases.SuspendLayout()
        CType(Me.dgPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(780, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 78)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Purchases"
        '
        'txtPurchasesSearch
        '
        Me.txtPurchasesSearch.BackColor = System.Drawing.Color.White
        Me.txtPurchasesSearch.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtPurchasesSearch.Location = New System.Drawing.Point(356, 133)
        Me.txtPurchasesSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesSearch.MaxLength = 50
        Me.txtPurchasesSearch.Multiline = True
        Me.txtPurchasesSearch.Name = "txtPurchasesSearch"
        Me.txtPurchasesSearch.Size = New System.Drawing.Size(1264, 98)
        Me.txtPurchasesSearch.TabIndex = 12
        Me.txtPurchasesSearch.Text = "Select Filter"
        '
        'panelAddPurchases
        '
        Me.panelAddPurchases.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelAddPurchases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelAddPurchases.Controls.Add(Me.txtPurchasesDate)
        Me.panelAddPurchases.Controls.Add(Me.Label10)
        Me.panelAddPurchases.Controls.Add(Me.cmbProductName)
        Me.panelAddPurchases.Controls.Add(Me.cmbSupplierName)
        Me.panelAddPurchases.Controls.Add(Me.txtPurchasesAmount)
        Me.panelAddPurchases.Controls.Add(Me.Label9)
        Me.panelAddPurchases.Controls.Add(Me.txtPurchasesProductQty)
        Me.panelAddPurchases.Controls.Add(Me.Label8)
        Me.panelAddPurchases.Controls.Add(Me.bttnPurchasesCancel)
        Me.panelAddPurchases.Controls.Add(Me.bttnPurchasesSubmit)
        Me.panelAddPurchases.Controls.Add(Me.txtPurchasesProductUnit)
        Me.panelAddPurchases.Controls.Add(Me.Label6)
        Me.panelAddPurchases.Controls.Add(Me.txtPurchasesRate)
        Me.panelAddPurchases.Controls.Add(Me.Label5)
        Me.panelAddPurchases.Controls.Add(Me.Label4)
        Me.panelAddPurchases.Controls.Add(Me.Label3)
        Me.panelAddPurchases.Controls.Add(Me.txtPurchasesID)
        Me.panelAddPurchases.Controls.Add(Me.Label1)
        Me.panelAddPurchases.Controls.Add(Me.Label7)
        Me.panelAddPurchases.Location = New System.Drawing.Point(306, 167)
        Me.panelAddPurchases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelAddPurchases.Name = "panelAddPurchases"
        Me.panelAddPurchases.Size = New System.Drawing.Size(1506, 850)
        Me.panelAddPurchases.TabIndex = 19
        '
        'txtPurchasesDate
        '
        Me.txtPurchasesDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesDate.Location = New System.Drawing.Point(400, 154)
        Me.txtPurchasesDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesDate.Multiline = True
        Me.txtPurchasesDate.Name = "txtPurchasesDate"
        Me.txtPurchasesDate.Size = New System.Drawing.Size(352, 37)
        Me.txtPurchasesDate.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(40, 154)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 65)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Date :"
        '
        'cmbProductName
        '
        Me.cmbProductName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(400, 487)
        Me.cmbProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(352, 49)
        Me.cmbProductName.TabIndex = 24
        '
        'cmbSupplierName
        '
        Me.cmbSupplierName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplierName.FormattingEnabled = True
        Me.cmbSupplierName.Location = New System.Drawing.Point(400, 373)
        Me.cmbSupplierName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSupplierName.Name = "cmbSupplierName"
        Me.cmbSupplierName.Size = New System.Drawing.Size(352, 49)
        Me.cmbSupplierName.TabIndex = 23
        '
        'txtPurchasesAmount
        '
        Me.txtPurchasesAmount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesAmount.Location = New System.Drawing.Point(1120, 381)
        Me.txtPurchasesAmount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesAmount.Multiline = True
        Me.txtPurchasesAmount.Name = "txtPurchasesAmount"
        Me.txtPurchasesAmount.Size = New System.Drawing.Size(352, 37)
        Me.txtPurchasesAmount.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(808, 373)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 65)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Amount :"
        '
        'txtPurchasesProductQty
        '
        Me.txtPurchasesProductQty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesProductQty.Location = New System.Drawing.Point(1120, 262)
        Me.txtPurchasesProductQty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesProductQty.MaxLength = 10
        Me.txtPurchasesProductQty.Multiline = True
        Me.txtPurchasesProductQty.Name = "txtPurchasesProductQty"
        Me.txtPurchasesProductQty.Size = New System.Drawing.Size(352, 37)
        Me.txtPurchasesProductQty.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(808, 260)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 65)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Quantity :"
        '
        'bttnPurchasesCancel
        '
        Me.bttnPurchasesCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnPurchasesCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPurchasesCancel.ForeColor = System.Drawing.Color.White
        Me.bttnPurchasesCancel.Location = New System.Drawing.Point(806, 710)
        Me.bttnPurchasesCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnPurchasesCancel.Name = "bttnPurchasesCancel"
        Me.bttnPurchasesCancel.Size = New System.Drawing.Size(488, 79)
        Me.bttnPurchasesCancel.TabIndex = 18
        Me.bttnPurchasesCancel.Text = "Cancel"
        Me.bttnPurchasesCancel.UseVisualStyleBackColor = False
        '
        'bttnPurchasesSubmit
        '
        Me.bttnPurchasesSubmit.BackColor = System.Drawing.Color.Peru
        Me.bttnPurchasesSubmit.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPurchasesSubmit.ForeColor = System.Drawing.Color.White
        Me.bttnPurchasesSubmit.Location = New System.Drawing.Point(210, 710)
        Me.bttnPurchasesSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnPurchasesSubmit.Name = "bttnPurchasesSubmit"
        Me.bttnPurchasesSubmit.Size = New System.Drawing.Size(488, 79)
        Me.bttnPurchasesSubmit.TabIndex = 17
        Me.bttnPurchasesSubmit.Text = "Submit"
        Me.bttnPurchasesSubmit.UseVisualStyleBackColor = False
        '
        'txtPurchasesProductUnit
        '
        Me.txtPurchasesProductUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesProductUnit.Location = New System.Drawing.Point(1120, 154)
        Me.txtPurchasesProductUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesProductUnit.MaxLength = 10
        Me.txtPurchasesProductUnit.Multiline = True
        Me.txtPurchasesProductUnit.Name = "txtPurchasesProductUnit"
        Me.txtPurchasesProductUnit.Size = New System.Drawing.Size(352, 37)
        Me.txtPurchasesProductUnit.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(808, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 65)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Unit :"
        '
        'txtPurchasesRate
        '
        Me.txtPurchasesRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesRate.Location = New System.Drawing.Point(400, 606)
        Me.txtPurchasesRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesRate.MaxLength = 10
        Me.txtPurchasesRate.Multiline = True
        Me.txtPurchasesRate.Name = "txtPurchasesRate"
        Me.txtPurchasesRate.Size = New System.Drawing.Size(352, 37)
        Me.txtPurchasesRate.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 583)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(347, 65)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Purchase Rate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 465)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(346, 65)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Product name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 358)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 65)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "From :"
        '
        'txtPurchasesID
        '
        Me.txtPurchasesID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchasesID.Location = New System.Drawing.Point(400, 262)
        Me.txtPurchasesID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchasesID.MaxLength = 10
        Me.txtPurchasesID.Multiline = True
        Me.txtPurchasesID.Name = "txtPurchasesID"
        Me.txtPurchasesID.Size = New System.Drawing.Size(352, 37)
        Me.txtPurchasesID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 262)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 65)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(526, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(445, 78)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Purchase Entry"
        '
        'dgPurchases
        '
        Me.dgPurchases.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgPurchases.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPurchases.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPurchases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPurchases.ColumnHeadersHeight = 50
        Me.dgPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPurchases.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgPurchases.EnableHeadersVisualStyles = False
        Me.dgPurchases.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgPurchases.Location = New System.Drawing.Point(38, 302)
        Me.dgPurchases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgPurchases.Name = "dgPurchases"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPurchases.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgPurchases.RowHeadersVisible = False
        Me.dgPurchases.RowHeadersWidth = 82
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgPurchases.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgPurchases.RowTemplate.Height = 33
        Me.dgPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPurchases.Size = New System.Drawing.Size(1812, 962)
        Me.dgPurchases.TabIndex = 20
        Me.dgPurchases.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dgPurchases.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgPurchases.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgPurchases.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgPurchases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgPurchases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgPurchases.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite
        Me.dgPurchases.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgPurchases.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgPurchases.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgPurchases.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgPurchases.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgPurchases.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPurchases.ThemeStyle.HeaderStyle.Height = 50
        Me.dgPurchases.ThemeStyle.ReadOnly = False
        Me.dgPurchases.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgPurchases.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgPurchases.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgPurchases.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgPurchases.ThemeStyle.RowsStyle.Height = 33
        Me.dgPurchases.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgPurchases.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'cmbPurchasesFilter
        '
        Me.cmbPurchasesFilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPurchasesFilter.FormattingEnabled = True
        Me.cmbPurchasesFilter.Location = New System.Drawing.Point(80, 133)
        Me.cmbPurchasesFilter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cmbPurchasesFilter.Name = "cmbPurchasesFilter"
        Me.cmbPurchasesFilter.Size = New System.Drawing.Size(262, 44)
        Me.cmbPurchasesFilter.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(74, 94)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(190, 36)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Search Filters :"
        '
        'bttnPurchasesSave
        '
        Me.bttnPurchasesSave.BackColor = System.Drawing.Color.Peru
        Me.bttnPurchasesSave.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPurchasesSave.ForeColor = System.Drawing.Color.White
        Me.bttnPurchasesSave.Location = New System.Drawing.Point(816, 1315)
        Me.bttnPurchasesSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnPurchasesSave.Name = "bttnPurchasesSave"
        Me.bttnPurchasesSave.Size = New System.Drawing.Size(244, 79)
        Me.bttnPurchasesSave.TabIndex = 31
        Me.bttnPurchasesSave.Text = "Save"
        Me.bttnPurchasesSave.UseVisualStyleBackColor = False
        '
        'bttnAddPurchases
        '
        Me.bttnAddPurchases.AnimationHoverSpeed = 0.07!
        Me.bttnAddPurchases.AnimationSpeed = 0.03!
        Me.bttnAddPurchases.BackColor = System.Drawing.Color.White
        Me.bttnAddPurchases.BaseColor = System.Drawing.Color.White
        Me.bttnAddPurchases.BorderColor = System.Drawing.Color.Black
        Me.bttnAddPurchases.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnAddPurchases.FocusedColor = System.Drawing.Color.Empty
        Me.bttnAddPurchases.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnAddPurchases.ForeColor = System.Drawing.Color.White
        Me.bttnAddPurchases.Image = Global.Srinath.My.Resources.Resources.Button_Add_1_512
        Me.bttnAddPurchases.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnAddPurchases.Location = New System.Drawing.Point(1642, 127)
        Me.bttnAddPurchases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnAddPurchases.Name = "bttnAddPurchases"
        Me.bttnAddPurchases.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnAddPurchases.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAddPurchases.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAddPurchases.OnHoverImage = Nothing
        Me.bttnAddPurchases.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAddPurchases.Size = New System.Drawing.Size(144, 121)
        Me.bttnAddPurchases.TabIndex = 16
        '
        'bttnPurchasesSearch
        '
        Me.bttnPurchasesSearch.AnimationHoverSpeed = 0.07!
        Me.bttnPurchasesSearch.AnimationSpeed = 0.03!
        Me.bttnPurchasesSearch.BackColor = System.Drawing.Color.White
        Me.bttnPurchasesSearch.BaseColor = System.Drawing.Color.Transparent
        Me.bttnPurchasesSearch.BorderColor = System.Drawing.Color.Transparent
        Me.bttnPurchasesSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnPurchasesSearch.FocusedColor = System.Drawing.Color.Empty
        Me.bttnPurchasesSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnPurchasesSearch.ForeColor = System.Drawing.Color.White
        Me.bttnPurchasesSearch.Image = Global.Srinath.My.Resources.Resources.search
        Me.bttnPurchasesSearch.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnPurchasesSearch.Location = New System.Drawing.Point(1504, 142)
        Me.bttnPurchasesSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnPurchasesSearch.Name = "bttnPurchasesSearch"
        Me.bttnPurchasesSearch.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnPurchasesSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnPurchasesSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnPurchasesSearch.OnHoverImage = Nothing
        Me.bttnPurchasesSearch.OnPressedColor = System.Drawing.Color.Black
        Me.bttnPurchasesSearch.Size = New System.Drawing.Size(108, 83)
        Me.bttnPurchasesSearch.TabIndex = 15
        '
        'subFormPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(2162, 1485)
        Me.Controls.Add(Me.panelAddPurchases)
        Me.Controls.Add(Me.bttnPurchasesSave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbPurchasesFilter)
        Me.Controls.Add(Me.bttnAddPurchases)
        Me.Controls.Add(Me.bttnPurchasesSearch)
        Me.Controls.Add(Me.txtPurchasesSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgPurchases)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "subFormPurchases"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelAddPurchases.ResumeLayout(False)
        Me.panelAddPurchases.PerformLayout()
        CType(Me.dgPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtPurchasesSearch As TextBox
    Friend WithEvents bttnPurchasesSearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents bttnAddPurchases As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents panelAddPurchases As Panel
    Friend WithEvents bttnPurchasesCancel As Button
    Friend WithEvents bttnPurchasesSubmit As Button
    Friend WithEvents txtPurchasesProductUnit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPurchasesRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPurchasesID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPurchasesAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPurchasesProductQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbProductName As ComboBox
    Friend WithEvents cmbSupplierName As ComboBox
    Friend WithEvents txtPurchasesDate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgPurchases As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents cmbPurchasesFilter As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents bttnPurchasesSave As Button
End Class
