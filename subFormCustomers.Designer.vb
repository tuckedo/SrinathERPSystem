<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subFormCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomersSearch = New System.Windows.Forms.TextBox()
        Me.panelAddCustomers = New System.Windows.Forms.Panel()
        Me.txtCustomersAddress = New System.Windows.Forms.TextBox()
        Me.bttnCustomersCancel = New System.Windows.Forms.Button()
        Me.bttnCustomersSubmit = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomersEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomersMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomersName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomersID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnCustomersSearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.bttnAddCustomers = New Guna.UI.WinForms.GunaCircleButton()
        Me.dgCustomers = New Guna.UI.WinForms.GunaDataGridView()
        Me.bttnCustomersSave = New System.Windows.Forms.Button()
        Me.panelAddCustomers.SuspendLayout()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Size = New System.Drawing.Size(166, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customers"
        '
        'txtCustomersSearch
        '
        Me.txtCustomersSearch.BackColor = System.Drawing.Color.White
        Me.txtCustomersSearch.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtCustomersSearch.Location = New System.Drawing.Point(178, 69)
        Me.txtCustomersSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomersSearch.MaxLength = 50
        Me.txtCustomersSearch.Multiline = True
        Me.txtCustomersSearch.Name = "txtCustomersSearch"
        Me.txtCustomersSearch.Size = New System.Drawing.Size(634, 53)
        Me.txtCustomersSearch.TabIndex = 7
        Me.txtCustomersSearch.Text = "Search by Customers Name"
        '
        'panelAddCustomers
        '
        Me.panelAddCustomers.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelAddCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelAddCustomers.Controls.Add(Me.txtCustomersAddress)
        Me.panelAddCustomers.Controls.Add(Me.bttnCustomersCancel)
        Me.panelAddCustomers.Controls.Add(Me.bttnCustomersSubmit)
        Me.panelAddCustomers.Controls.Add(Me.Label6)
        Me.panelAddCustomers.Controls.Add(Me.txtCustomersEmail)
        Me.panelAddCustomers.Controls.Add(Me.Label5)
        Me.panelAddCustomers.Controls.Add(Me.txtCustomersMobile)
        Me.panelAddCustomers.Controls.Add(Me.Label4)
        Me.panelAddCustomers.Controls.Add(Me.txtCustomersName)
        Me.panelAddCustomers.Controls.Add(Me.Label3)
        Me.panelAddCustomers.Controls.Add(Me.txtCustomersID)
        Me.panelAddCustomers.Controls.Add(Me.Label1)
        Me.panelAddCustomers.Controls.Add(Me.Label7)
        Me.panelAddCustomers.Location = New System.Drawing.Point(153, 87)
        Me.panelAddCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.panelAddCustomers.Name = "panelAddCustomers"
        Me.panelAddCustomers.Size = New System.Drawing.Size(677, 444)
        Me.panelAddCustomers.TabIndex = 12
        '
        'txtCustomersAddress
        '
        Me.txtCustomersAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersAddress.Location = New System.Drawing.Point(470, 79)
        Me.txtCustomersAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomersAddress.MaxLength = 300
        Me.txtCustomersAddress.Multiline = True
        Me.txtCustomersAddress.Name = "txtCustomersAddress"
        Me.txtCustomersAddress.Size = New System.Drawing.Size(178, 98)
        Me.txtCustomersAddress.TabIndex = 16
        '
        'bttnCustomersCancel
        '
        Me.bttnCustomersCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnCustomersCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCustomersCancel.ForeColor = System.Drawing.Color.White
        Me.bttnCustomersCancel.Location = New System.Drawing.Point(377, 369)
        Me.bttnCustomersCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCustomersCancel.Name = "bttnCustomersCancel"
        Me.bttnCustomersCancel.Size = New System.Drawing.Size(244, 41)
        Me.bttnCustomersCancel.TabIndex = 18
        Me.bttnCustomersCancel.Text = "Cancel"
        Me.bttnCustomersCancel.UseVisualStyleBackColor = False
        '
        'bttnCustomersSubmit
        '
        Me.bttnCustomersSubmit.BackColor = System.Drawing.Color.Peru
        Me.bttnCustomersSubmit.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCustomersSubmit.ForeColor = System.Drawing.Color.White
        Me.bttnCustomersSubmit.Location = New System.Drawing.Point(63, 369)
        Me.bttnCustomersSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCustomersSubmit.Name = "bttnCustomersSubmit"
        Me.bttnCustomersSubmit.Size = New System.Drawing.Size(244, 41)
        Me.bttnCustomersSubmit.TabIndex = 17
        Me.bttnCustomersSubmit.Text = "Submit"
        Me.bttnCustomersSubmit.UseVisualStyleBackColor = False
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
        'txtCustomersEmail
        '
        Me.txtCustomersEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersEmail.Location = New System.Drawing.Point(116, 286)
        Me.txtCustomersEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomersEmail.MaxLength = 100
        Me.txtCustomersEmail.Multiline = True
        Me.txtCustomersEmail.Name = "txtCustomersEmail"
        Me.txtCustomersEmail.Size = New System.Drawing.Size(178, 21)
        Me.txtCustomersEmail.TabIndex = 14
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
        'txtCustomersMobile
        '
        Me.txtCustomersMobile.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersMobile.Location = New System.Drawing.Point(116, 212)
        Me.txtCustomersMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomersMobile.MaxLength = 10
        Me.txtCustomersMobile.Multiline = True
        Me.txtCustomersMobile.Name = "txtCustomersMobile"
        Me.txtCustomersMobile.Size = New System.Drawing.Size(178, 21)
        Me.txtCustomersMobile.TabIndex = 12
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
        'txtCustomersName
        '
        Me.txtCustomersName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersName.Location = New System.Drawing.Point(116, 146)
        Me.txtCustomersName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomersName.MaxLength = 20
        Me.txtCustomersName.Multiline = True
        Me.txtCustomersName.Name = "txtCustomersName"
        Me.txtCustomersName.Size = New System.Drawing.Size(178, 21)
        Me.txtCustomersName.TabIndex = 10
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
        'txtCustomersID
        '
        Me.txtCustomersID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomersID.Location = New System.Drawing.Point(116, 78)
        Me.txtCustomersID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCustomersID.Multiline = True
        Me.txtCustomersID.Name = "txtCustomersID"
        Me.txtCustomersID.Size = New System.Drawing.Size(178, 21)
        Me.txtCustomersID.TabIndex = 8
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
        Me.Label7.Size = New System.Drawing.Size(244, 41)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Add a Customer"
        '
        'bttnCustomersSearch
        '
        Me.bttnCustomersSearch.AnimationHoverSpeed = 0.07!
        Me.bttnCustomersSearch.AnimationSpeed = 0.03!
        Me.bttnCustomersSearch.BackColor = System.Drawing.Color.Transparent
        Me.bttnCustomersSearch.BaseColor = System.Drawing.Color.Transparent
        Me.bttnCustomersSearch.BorderColor = System.Drawing.Color.Transparent
        Me.bttnCustomersSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnCustomersSearch.FocusedColor = System.Drawing.Color.Empty
        Me.bttnCustomersSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnCustomersSearch.ForeColor = System.Drawing.Color.White
        Me.bttnCustomersSearch.Image = Global.Srinath.My.Resources.Resources.search
        Me.bttnCustomersSearch.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnCustomersSearch.Location = New System.Drawing.Point(752, 74)
        Me.bttnCustomersSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCustomersSearch.Name = "bttnCustomersSearch"
        Me.bttnCustomersSearch.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnCustomersSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnCustomersSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnCustomersSearch.OnHoverImage = Nothing
        Me.bttnCustomersSearch.OnPressedColor = System.Drawing.Color.Black
        Me.bttnCustomersSearch.Size = New System.Drawing.Size(54, 43)
        Me.bttnCustomersSearch.TabIndex = 13
        '
        'bttnAddCustomers
        '
        Me.bttnAddCustomers.AnimationHoverSpeed = 0.07!
        Me.bttnAddCustomers.AnimationSpeed = 0.03!
        Me.bttnAddCustomers.BackColor = System.Drawing.Color.White
        Me.bttnAddCustomers.BaseColor = System.Drawing.Color.White
        Me.bttnAddCustomers.BorderColor = System.Drawing.Color.Black
        Me.bttnAddCustomers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnAddCustomers.FocusedColor = System.Drawing.Color.Empty
        Me.bttnAddCustomers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnAddCustomers.ForeColor = System.Drawing.Color.White
        Me.bttnAddCustomers.Image = Global.Srinath.My.Resources.Resources.Button_Add_1_512
        Me.bttnAddCustomers.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnAddCustomers.Location = New System.Drawing.Point(821, 66)
        Me.bttnAddCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnAddCustomers.Name = "bttnAddCustomers"
        Me.bttnAddCustomers.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnAddCustomers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAddCustomers.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAddCustomers.OnHoverImage = Nothing
        Me.bttnAddCustomers.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAddCustomers.Size = New System.Drawing.Size(72, 63)
        Me.bttnAddCustomers.TabIndex = 10
        '
        'dgCustomers
        '
        Me.dgCustomers.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCustomers.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgCustomers.ColumnHeadersHeight = 50
        Me.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCustomers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgCustomers.EnableHeadersVisualStyles = False
        Me.dgCustomers.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgCustomers.Location = New System.Drawing.Point(19, 157)
        Me.dgCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.dgCustomers.Name = "dgCustomers"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCustomers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgCustomers.RowHeadersVisible = False
        Me.dgCustomers.RowHeadersWidth = 82
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgCustomers.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgCustomers.RowTemplate.Height = 33
        Me.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCustomers.Size = New System.Drawing.Size(906, 500)
        Me.dgCustomers.TabIndex = 14
        Me.dgCustomers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dgCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgCustomers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgCustomers.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite
        Me.dgCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgCustomers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCustomers.ThemeStyle.HeaderStyle.Height = 50
        Me.dgCustomers.ThemeStyle.ReadOnly = False
        Me.dgCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgCustomers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgCustomers.ThemeStyle.RowsStyle.Height = 33
        Me.dgCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'bttnCustomersSave
        '
        Me.bttnCustomersSave.BackColor = System.Drawing.Color.Peru
        Me.bttnCustomersSave.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCustomersSave.ForeColor = System.Drawing.Color.White
        Me.bttnCustomersSave.Location = New System.Drawing.Point(410, 673)
        Me.bttnCustomersSave.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCustomersSave.Name = "bttnCustomersSave"
        Me.bttnCustomersSave.Size = New System.Drawing.Size(122, 41)
        Me.bttnCustomersSave.TabIndex = 18
        Me.bttnCustomersSave.Text = "Save"
        Me.bttnCustomersSave.UseVisualStyleBackColor = False
        '
        'subFormCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 772)
        Me.Controls.Add(Me.bttnCustomersSave)
        Me.Controls.Add(Me.panelAddCustomers)
        Me.Controls.Add(Me.bttnCustomersSearch)
        Me.Controls.Add(Me.bttnAddCustomers)
        Me.Controls.Add(Me.txtCustomersSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgCustomers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "subFormCustomers"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelAddCustomers.ResumeLayout(False)
        Me.panelAddCustomers.PerformLayout()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustomersSearch As TextBox
    Friend WithEvents bttnAddCustomers As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents panelAddCustomers As Panel
    Friend WithEvents bttnCustomersCancel As Button
    Friend WithEvents bttnCustomersSubmit As Button
    Friend WithEvents txtCustomersAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCustomersEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCustomersMobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomersName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustomersID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bttnCustomersSearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents dgCustomers As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents bttnCustomersSave As Button
End Class
