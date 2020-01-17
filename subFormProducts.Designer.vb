<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subFormProducts
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
        Me.txtProductsSearch = New System.Windows.Forms.TextBox()
        Me.dgProducts = New Guna.UI.WinForms.GunaDataGridView()
        Me.panelAddProducts = New System.Windows.Forms.Panel()
        Me.bttnProductsCancel = New System.Windows.Forms.Button()
        Me.bttnProductsSubmit = New System.Windows.Forms.Button()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProductRate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnAddProducts = New Guna.UI.WinForms.GunaCircleButton()
        Me.bttnProductsSearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.bttnProductsSave = New System.Windows.Forms.Button()
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAddProducts.SuspendLayout()
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
        Me.Label2.Size = New System.Drawing.Size(278, 78)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Products"
        '
        'txtProductsSearch
        '
        Me.txtProductsSearch.BackColor = System.Drawing.Color.White
        Me.txtProductsSearch.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductsSearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtProductsSearch.Location = New System.Drawing.Point(356, 133)
        Me.txtProductsSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductsSearch.MaxLength = 50
        Me.txtProductsSearch.Multiline = True
        Me.txtProductsSearch.Name = "txtProductsSearch"
        Me.txtProductsSearch.Size = New System.Drawing.Size(1264, 98)
        Me.txtProductsSearch.TabIndex = 6
        Me.txtProductsSearch.Text = "Search by Product Name"
        '
        'dgProducts
        '
        Me.dgProducts.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProducts.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgProducts.ColumnHeadersHeight = 50
        Me.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgProducts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgProducts.EnableHeadersVisualStyles = False
        Me.dgProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgProducts.Location = New System.Drawing.Point(38, 302)
        Me.dgProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgProducts.Name = "dgProducts"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgProducts.RowHeadersVisible = False
        Me.dgProducts.RowHeadersWidth = 82
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgProducts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgProducts.RowTemplate.Height = 33
        Me.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProducts.Size = New System.Drawing.Size(1812, 962)
        Me.dgProducts.TabIndex = 8
        Me.dgProducts.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dgProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgProducts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgProducts.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite
        Me.dgProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgProducts.ThemeStyle.HeaderStyle.Height = 50
        Me.dgProducts.ThemeStyle.ReadOnly = False
        Me.dgProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgProducts.ThemeStyle.RowsStyle.Height = 33
        Me.dgProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'panelAddProducts
        '
        Me.panelAddProducts.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelAddProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelAddProducts.Controls.Add(Me.bttnProductsCancel)
        Me.panelAddProducts.Controls.Add(Me.bttnProductsSubmit)
        Me.panelAddProducts.Controls.Add(Me.txtProductDescription)
        Me.panelAddProducts.Controls.Add(Me.Label6)
        Me.panelAddProducts.Controls.Add(Me.txtProductRate)
        Me.panelAddProducts.Controls.Add(Me.Label5)
        Me.panelAddProducts.Controls.Add(Me.txtProductUnit)
        Me.panelAddProducts.Controls.Add(Me.Label4)
        Me.panelAddProducts.Controls.Add(Me.txtProductName)
        Me.panelAddProducts.Controls.Add(Me.Label3)
        Me.panelAddProducts.Controls.Add(Me.txtProductID)
        Me.panelAddProducts.Controls.Add(Me.Label1)
        Me.panelAddProducts.Controls.Add(Me.Label7)
        Me.panelAddProducts.Location = New System.Drawing.Point(306, 167)
        Me.panelAddProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelAddProducts.Name = "panelAddProducts"
        Me.panelAddProducts.Size = New System.Drawing.Size(1350, 850)
        Me.panelAddProducts.TabIndex = 10
        '
        'bttnProductsCancel
        '
        Me.bttnProductsCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnProductsCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnProductsCancel.ForeColor = System.Drawing.Color.White
        Me.bttnProductsCancel.Location = New System.Drawing.Point(754, 710)
        Me.bttnProductsCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnProductsCancel.Name = "bttnProductsCancel"
        Me.bttnProductsCancel.Size = New System.Drawing.Size(488, 79)
        Me.bttnProductsCancel.TabIndex = 18
        Me.bttnProductsCancel.Text = "Cancel"
        Me.bttnProductsCancel.UseVisualStyleBackColor = False
        '
        'bttnProductsSubmit
        '
        Me.bttnProductsSubmit.BackColor = System.Drawing.Color.Peru
        Me.bttnProductsSubmit.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnProductsSubmit.ForeColor = System.Drawing.Color.White
        Me.bttnProductsSubmit.Location = New System.Drawing.Point(106, 710)
        Me.bttnProductsSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnProductsSubmit.Name = "bttnProductsSubmit"
        Me.bttnProductsSubmit.Size = New System.Drawing.Size(488, 79)
        Me.bttnProductsSubmit.TabIndex = 17
        Me.bttnProductsSubmit.Text = "Submit"
        Me.bttnProductsSubmit.UseVisualStyleBackColor = False
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.Location = New System.Drawing.Point(944, 165)
        Me.txtProductDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductDescription.MaxLength = 40
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(352, 164)
        Me.txtProductDescription.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(640, 150)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(292, 65)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Description :"
        '
        'txtProductRate
        '
        Me.txtProductRate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductRate.Location = New System.Drawing.Point(232, 544)
        Me.txtProductRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductRate.MaxLength = 10
        Me.txtProductRate.Multiline = True
        Me.txtProductRate.Name = "txtProductRate"
        Me.txtProductRate.Size = New System.Drawing.Size(352, 37)
        Me.txtProductRate.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 529)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 65)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Rate :"
        '
        'txtProductUnit
        '
        Me.txtProductUnit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductUnit.Location = New System.Drawing.Point(232, 413)
        Me.txtProductUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductUnit.MaxLength = 10
        Me.txtProductUnit.Multiline = True
        Me.txtProductUnit.Name = "txtProductUnit"
        Me.txtProductUnit.Size = New System.Drawing.Size(352, 37)
        Me.txtProductUnit.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(40, 398)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 65)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Unit :"
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(230, 287)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductName.MaxLength = 20
        Me.txtProductName.Multiline = True
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(352, 37)
        Me.txtProductName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 271)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 65)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Name :"
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(230, 158)
        Me.txtProductID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductID.Multiline = True
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(352, 37)
        Me.txtProductID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 142)
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
        Me.Label7.Location = New System.Drawing.Point(440, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(431, 78)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Add a Product"
        '
        'bttnAddProducts
        '
        Me.bttnAddProducts.AnimationHoverSpeed = 0.07!
        Me.bttnAddProducts.AnimationSpeed = 0.03!
        Me.bttnAddProducts.BackColor = System.Drawing.Color.White
        Me.bttnAddProducts.BaseColor = System.Drawing.Color.White
        Me.bttnAddProducts.BorderColor = System.Drawing.Color.Black
        Me.bttnAddProducts.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnAddProducts.FocusedColor = System.Drawing.Color.Empty
        Me.bttnAddProducts.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnAddProducts.ForeColor = System.Drawing.Color.White
        Me.bttnAddProducts.Image = Global.Srinath.My.Resources.Resources.Button_Add_1_512
        Me.bttnAddProducts.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnAddProducts.Location = New System.Drawing.Point(1642, 127)
        Me.bttnAddProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnAddProducts.Name = "bttnAddProducts"
        Me.bttnAddProducts.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnAddProducts.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAddProducts.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAddProducts.OnHoverImage = Nothing
        Me.bttnAddProducts.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAddProducts.Size = New System.Drawing.Size(144, 121)
        Me.bttnAddProducts.TabIndex = 9
        '
        'bttnProductsSearch
        '
        Me.bttnProductsSearch.AnimationHoverSpeed = 0.07!
        Me.bttnProductsSearch.AnimationSpeed = 0.03!
        Me.bttnProductsSearch.BackColor = System.Drawing.Color.Transparent
        Me.bttnProductsSearch.BaseColor = System.Drawing.Color.Transparent
        Me.bttnProductsSearch.BorderColor = System.Drawing.Color.Transparent
        Me.bttnProductsSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnProductsSearch.FocusedColor = System.Drawing.Color.Empty
        Me.bttnProductsSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnProductsSearch.ForeColor = System.Drawing.Color.White
        Me.bttnProductsSearch.Image = Global.Srinath.My.Resources.Resources.search
        Me.bttnProductsSearch.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnProductsSearch.Location = New System.Drawing.Point(1502, 142)
        Me.bttnProductsSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnProductsSearch.Name = "bttnProductsSearch"
        Me.bttnProductsSearch.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnProductsSearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnProductsSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnProductsSearch.OnHoverImage = Nothing
        Me.bttnProductsSearch.OnPressedColor = System.Drawing.Color.Black
        Me.bttnProductsSearch.Size = New System.Drawing.Size(108, 83)
        Me.bttnProductsSearch.TabIndex = 7
        '
        'bttnProductsSave
        '
        Me.bttnProductsSave.BackColor = System.Drawing.Color.Peru
        Me.bttnProductsSave.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnProductsSave.ForeColor = System.Drawing.Color.White
        Me.bttnProductsSave.Location = New System.Drawing.Point(820, 1294)
        Me.bttnProductsSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnProductsSave.Name = "bttnProductsSave"
        Me.bttnProductsSave.Size = New System.Drawing.Size(244, 79)
        Me.bttnProductsSave.TabIndex = 19
        Me.bttnProductsSave.Text = "Save"
        Me.bttnProductsSave.UseVisualStyleBackColor = False
        '
        'subFormProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1832, 1500)
        Me.Controls.Add(Me.bttnProductsSave)
        Me.Controls.Add(Me.panelAddProducts)
        Me.Controls.Add(Me.bttnAddProducts)
        Me.Controls.Add(Me.dgProducts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnProductsSearch)
        Me.Controls.Add(Me.txtProductsSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "subFormProducts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAddProducts.ResumeLayout(False)
        Me.panelAddProducts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductsSearch As TextBox
    Friend WithEvents dgProducts As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents bttnAddProducts As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents bttnProductsSearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents panelAddProducts As Panel
    Friend WithEvents bttnProductsCancel As Button
    Friend WithEvents bttnProductsSubmit As Button
    Friend WithEvents txtProductDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents bttnProductsSave As Button
End Class
