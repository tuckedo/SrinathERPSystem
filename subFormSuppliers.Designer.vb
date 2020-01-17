<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subFormSuppliers
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
        Me.txtSuppliersSearch = New System.Windows.Forms.TextBox()
        Me.panelAddSuppliers = New System.Windows.Forms.Panel()
        Me.txtSuppliersAddress = New System.Windows.Forms.TextBox()
        Me.bttnSuppliersCancel = New System.Windows.Forms.Button()
        Me.bttnSuppliersSubmit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSuppliersEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSuppliersMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuppliersName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSuppliersID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnAddSuppliers = New Guna.UI.WinForms.GunaCircleButton()
        Me.bttnSuppliersSearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.dgSuppliers = New Guna.UI.WinForms.GunaDataGridView()
        Me.bttnSuppliersSave = New System.Windows.Forms.Button()
        Me.panelAddSuppliers.SuspendLayout()
        CType(Me.dgSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(390, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 41)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Suppliers"
        '
        'txtSuppliersSearch
        '
        Me.txtSuppliersSearch.BackColor = System.Drawing.Color.White
        Me.txtSuppliersSearch.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliersSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtSuppliersSearch.Location = New System.Drawing.Point(178, 69)
        Me.txtSuppliersSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuppliersSearch.MaxLength = 50
        Me.txtSuppliersSearch.Multiline = True
        Me.txtSuppliersSearch.Name = "txtSuppliersSearch"
        Me.txtSuppliersSearch.Size = New System.Drawing.Size(634, 53)
        Me.txtSuppliersSearch.TabIndex = 11
        Me.txtSuppliersSearch.Text = "Search by Suppliers Name"
        '
        'panelAddSuppliers
        '
        Me.panelAddSuppliers.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelAddSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelAddSuppliers.Controls.Add(Me.txtSuppliersAddress)
        Me.panelAddSuppliers.Controls.Add(Me.bttnSuppliersCancel)
        Me.panelAddSuppliers.Controls.Add(Me.bttnSuppliersSubmit)
        Me.panelAddSuppliers.Controls.Add(Me.Label6)
        Me.panelAddSuppliers.Controls.Add(Me.txtSuppliersEmail)
        Me.panelAddSuppliers.Controls.Add(Me.Label5)
        Me.panelAddSuppliers.Controls.Add(Me.txtSuppliersMobile)
        Me.panelAddSuppliers.Controls.Add(Me.Label4)
        Me.panelAddSuppliers.Controls.Add(Me.txtSuppliersName)
        Me.panelAddSuppliers.Controls.Add(Me.Label3)
        Me.panelAddSuppliers.Controls.Add(Me.txtSuppliersID)
        Me.panelAddSuppliers.Controls.Add(Me.Label1)
        Me.panelAddSuppliers.Controls.Add(Me.Label7)
        Me.panelAddSuppliers.Location = New System.Drawing.Point(153, 88)
        Me.panelAddSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.panelAddSuppliers.Name = "panelAddSuppliers"
        Me.panelAddSuppliers.Size = New System.Drawing.Size(677, 444)
        Me.panelAddSuppliers.TabIndex = 16
        '
        'txtSuppliersAddress
        '
        Me.txtSuppliersAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliersAddress.Location = New System.Drawing.Point(470, 79)
        Me.txtSuppliersAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuppliersAddress.MaxLength = 300
        Me.txtSuppliersAddress.Multiline = True
        Me.txtSuppliersAddress.Name = "txtSuppliersAddress"
        Me.txtSuppliersAddress.Size = New System.Drawing.Size(178, 98)
        Me.txtSuppliersAddress.TabIndex = 16
        '
        'bttnSuppliersCancel
        '
        Me.bttnSuppliersCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnSuppliersCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSuppliersCancel.ForeColor = System.Drawing.Color.White
        Me.bttnSuppliersCancel.Location = New System.Drawing.Point(377, 369)
        Me.bttnSuppliersCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSuppliersCancel.Name = "bttnSuppliersCancel"
        Me.bttnSuppliersCancel.Size = New System.Drawing.Size(244, 41)
        Me.bttnSuppliersCancel.TabIndex = 18
        Me.bttnSuppliersCancel.Text = "Cancel"
        Me.bttnSuppliersCancel.UseVisualStyleBackColor = False
        '
        'bttnSuppliersSubmit
        '
        Me.bttnSuppliersSubmit.BackColor = System.Drawing.Color.Peru
        Me.bttnSuppliersSubmit.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSuppliersSubmit.ForeColor = System.Drawing.Color.White
        Me.bttnSuppliersSubmit.Location = New System.Drawing.Point(53, 369)
        Me.bttnSuppliersSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSuppliersSubmit.Name = "bttnSuppliersSubmit"
        Me.bttnSuppliersSubmit.Size = New System.Drawing.Size(244, 41)
        Me.bttnSuppliersSubmit.TabIndex = 17
        Me.bttnSuppliersSubmit.Text = "Submit"
        Me.bttnSuppliersSubmit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(320, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Address :"
        '
        'txtSuppliersEmail
        '
        Me.txtSuppliersEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliersEmail.Location = New System.Drawing.Point(115, 286)
        Me.txtSuppliersEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuppliersEmail.MaxLength = 100
        Me.txtSuppliersEmail.Multiline = True
        Me.txtSuppliersEmail.Name = "txtSuppliersEmail"
        Me.txtSuppliersEmail.Size = New System.Drawing.Size(178, 21)
        Me.txtSuppliersEmail.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 275)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 32)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email :"
        '
        'txtSuppliersMobile
        '
        Me.txtSuppliersMobile.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliersMobile.Location = New System.Drawing.Point(116, 218)
        Me.txtSuppliersMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuppliersMobile.MaxLength = 10
        Me.txtSuppliersMobile.Multiline = True
        Me.txtSuppliersMobile.Name = "txtSuppliersMobile"
        Me.txtSuppliersMobile.Size = New System.Drawing.Size(178, 21)
        Me.txtSuppliersMobile.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mobile :"
        '
        'txtSuppliersName
        '
        Me.txtSuppliersName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliersName.Location = New System.Drawing.Point(115, 152)
        Me.txtSuppliersName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuppliersName.MaxLength = 20
        Me.txtSuppliersName.Multiline = True
        Me.txtSuppliersName.Name = "txtSuppliersName"
        Me.txtSuppliersName.Size = New System.Drawing.Size(178, 21)
        Me.txtSuppliersName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Name :"
        '
        'txtSuppliersID
        '
        Me.txtSuppliersID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppliersID.Location = New System.Drawing.Point(115, 86)
        Me.txtSuppliersID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuppliersID.Multiline = True
        Me.txtSuppliersID.Name = "txtSuppliersID"
        Me.txtSuppliersID.Size = New System.Drawing.Size(178, 21)
        Me.txtSuppliersID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 74)
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
        Me.Label7.Location = New System.Drawing.Point(220, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(228, 41)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Add a Supplier"
        '
        'bttnAddSuppliers
        '
        Me.bttnAddSuppliers.AnimationHoverSpeed = 0.07!
        Me.bttnAddSuppliers.AnimationSpeed = 0.03!
        Me.bttnAddSuppliers.BackColor = System.Drawing.Color.White
        Me.bttnAddSuppliers.BaseColor = System.Drawing.Color.White
        Me.bttnAddSuppliers.BorderColor = System.Drawing.Color.Black
        Me.bttnAddSuppliers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnAddSuppliers.FocusedColor = System.Drawing.Color.Empty
        Me.bttnAddSuppliers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnAddSuppliers.ForeColor = System.Drawing.Color.White
        Me.bttnAddSuppliers.Image = Global.Srinath.My.Resources.Resources.Button_Add_1_512
        Me.bttnAddSuppliers.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnAddSuppliers.Location = New System.Drawing.Point(821, 66)
        Me.bttnAddSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnAddSuppliers.Name = "bttnAddSuppliers"
        Me.bttnAddSuppliers.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnAddSuppliers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAddSuppliers.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAddSuppliers.OnHoverImage = Nothing
        Me.bttnAddSuppliers.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAddSuppliers.Size = New System.Drawing.Size(72, 63)
        Me.bttnAddSuppliers.TabIndex = 15
        '
        'bttnSuppliersSearch
        '
        Me.bttnSuppliersSearch.AnimationHoverSpeed = 0.07!
        Me.bttnSuppliersSearch.AnimationSpeed = 0.03!
        Me.bttnSuppliersSearch.BackColor = System.Drawing.Color.White
        Me.bttnSuppliersSearch.BaseColor = System.Drawing.Color.Transparent
        Me.bttnSuppliersSearch.BorderColor = System.Drawing.Color.Transparent
        Me.bttnSuppliersSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnSuppliersSearch.FocusedColor = System.Drawing.Color.Empty
        Me.bttnSuppliersSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnSuppliersSearch.ForeColor = System.Drawing.Color.White
        Me.bttnSuppliersSearch.Image = Global.Srinath.My.Resources.Resources.search
        Me.bttnSuppliersSearch.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnSuppliersSearch.Location = New System.Drawing.Point(752, 74)
        Me.bttnSuppliersSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSuppliersSearch.Name = "bttnSuppliersSearch"
        Me.bttnSuppliersSearch.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnSuppliersSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnSuppliersSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnSuppliersSearch.OnHoverImage = Nothing
        Me.bttnSuppliersSearch.OnPressedColor = System.Drawing.Color.Black
        Me.bttnSuppliersSearch.Size = New System.Drawing.Size(54, 43)
        Me.bttnSuppliersSearch.TabIndex = 14
        '
        'dgSuppliers
        '
        Me.dgSuppliers.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgSuppliers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSuppliers.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSuppliers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgSuppliers.ColumnHeadersHeight = 50
        Me.dgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSuppliers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSuppliers.EnableHeadersVisualStyles = False
        Me.dgSuppliers.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgSuppliers.Location = New System.Drawing.Point(19, 157)
        Me.dgSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.dgSuppliers.Name = "dgSuppliers"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSuppliers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgSuppliers.RowHeadersVisible = False
        Me.dgSuppliers.RowHeadersWidth = 82
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgSuppliers.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgSuppliers.RowTemplate.Height = 33
        Me.dgSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSuppliers.Size = New System.Drawing.Size(906, 500)
        Me.dgSuppliers.TabIndex = 17
        Me.dgSuppliers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dgSuppliers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgSuppliers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgSuppliers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgSuppliers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgSuppliers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgSuppliers.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite
        Me.dgSuppliers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgSuppliers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgSuppliers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgSuppliers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgSuppliers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgSuppliers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgSuppliers.ThemeStyle.HeaderStyle.Height = 50
        Me.dgSuppliers.ThemeStyle.ReadOnly = False
        Me.dgSuppliers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgSuppliers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgSuppliers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgSuppliers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgSuppliers.ThemeStyle.RowsStyle.Height = 33
        Me.dgSuppliers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgSuppliers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'bttnSuppliersSave
        '
        Me.bttnSuppliersSave.BackColor = System.Drawing.Color.Peru
        Me.bttnSuppliersSave.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSuppliersSave.ForeColor = System.Drawing.Color.White
        Me.bttnSuppliersSave.Location = New System.Drawing.Point(410, 673)
        Me.bttnSuppliersSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSuppliersSave.Name = "bttnSuppliersSave"
        Me.bttnSuppliersSave.Size = New System.Drawing.Size(122, 41)
        Me.bttnSuppliersSave.TabIndex = 19
        Me.bttnSuppliersSave.Text = "Save"
        Me.bttnSuppliersSave.UseVisualStyleBackColor = False
        '
        'subFormSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(989, 772)
        Me.Controls.Add(Me.bttnSuppliersSave)
        Me.Controls.Add(Me.panelAddSuppliers)
        Me.Controls.Add(Me.bttnAddSuppliers)
        Me.Controls.Add(Me.bttnSuppliersSearch)
        Me.Controls.Add(Me.txtSuppliersSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgSuppliers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "subFormSuppliers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelAddSuppliers.ResumeLayout(False)
        Me.panelAddSuppliers.PerformLayout()
        CType(Me.dgSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSuppliersSearch As TextBox
    Friend WithEvents bttnSuppliersSearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents bttnAddSuppliers As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents panelAddSuppliers As Panel
    Friend WithEvents txtSuppliersAddress As TextBox
    Friend WithEvents bttnSuppliersCancel As Button
    Friend WithEvents bttnSuppliersSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSuppliersEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSuppliersMobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSuppliersName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSuppliersID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgSuppliers As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents bttnSuppliersSave As Button
End Class
