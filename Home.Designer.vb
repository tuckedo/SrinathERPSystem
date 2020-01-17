<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttnInventory = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnSales = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnPurchases = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnSuppliers = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnCustomers = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnProducts = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bttnSettings = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panelSettings = New System.Windows.Forms.Panel()
        Me.bttnResetDB = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnAbout = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnResetPassword = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnLogout = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaCirclePictureBox2 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.bttnSettingsCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.panelSettings.SuspendLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.bttnInventory)
        Me.Panel1.Controls.Add(Me.bttnSales)
        Me.Panel1.Controls.Add(Me.bttnPurchases)
        Me.Panel1.Controls.Add(Me.bttnSuppliers)
        Me.Panel1.Controls.Add(Me.bttnCustomers)
        Me.Panel1.Controls.Add(Me.bttnProducts)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 905)
        Me.Panel1.TabIndex = 0
        '
        'bttnInventory
        '
        Me.bttnInventory.AnimationHoverSpeed = 0.07!
        Me.bttnInventory.AnimationSpeed = 0.03!
        Me.bttnInventory.BackColor = System.Drawing.Color.Bisque
        Me.bttnInventory.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnInventory.BorderColor = System.Drawing.Color.Black
        Me.bttnInventory.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnInventory.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnInventory.CheckedForeColor = System.Drawing.Color.White
        Me.bttnInventory.CheckedImage = CType(resources.GetObject("bttnInventory.CheckedImage"), System.Drawing.Image)
        Me.bttnInventory.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnInventory.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnInventory.FocusedColor = System.Drawing.Color.Empty
        Me.bttnInventory.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnInventory.ForeColor = System.Drawing.Color.White
        Me.bttnInventory.Image = Nothing
        Me.bttnInventory.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnInventory.LineColor = System.Drawing.Color.White
        Me.bttnInventory.Location = New System.Drawing.Point(-4, 631)
        Me.bttnInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnInventory.Name = "bttnInventory"
        Me.bttnInventory.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnInventory.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnInventory.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnInventory.OnHoverImage = Nothing
        Me.bttnInventory.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnInventory.OnPressedColor = System.Drawing.Color.Black
        Me.bttnInventory.Size = New System.Drawing.Size(344, 68)
        Me.bttnInventory.TabIndex = 6
        Me.bttnInventory.Text = "Inventory"
        Me.bttnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnSales
        '
        Me.bttnSales.AnimationHoverSpeed = 0.07!
        Me.bttnSales.AnimationSpeed = 0.03!
        Me.bttnSales.BackColor = System.Drawing.Color.Bisque
        Me.bttnSales.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnSales.BorderColor = System.Drawing.Color.Black
        Me.bttnSales.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnSales.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnSales.CheckedForeColor = System.Drawing.Color.White
        Me.bttnSales.CheckedImage = CType(resources.GetObject("bttnSales.CheckedImage"), System.Drawing.Image)
        Me.bttnSales.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnSales.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnSales.FocusedColor = System.Drawing.Color.Empty
        Me.bttnSales.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSales.ForeColor = System.Drawing.Color.White
        Me.bttnSales.Image = Nothing
        Me.bttnSales.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnSales.LineColor = System.Drawing.Color.White
        Me.bttnSales.Location = New System.Drawing.Point(-4, 534)
        Me.bttnSales.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSales.Name = "bttnSales"
        Me.bttnSales.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnSales.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnSales.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnSales.OnHoverImage = Nothing
        Me.bttnSales.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnSales.OnPressedColor = System.Drawing.Color.Black
        Me.bttnSales.Size = New System.Drawing.Size(344, 68)
        Me.bttnSales.TabIndex = 5
        Me.bttnSales.Text = "Sales"
        Me.bttnSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnPurchases
        '
        Me.bttnPurchases.AnimationHoverSpeed = 0.07!
        Me.bttnPurchases.AnimationSpeed = 0.03!
        Me.bttnPurchases.BackColor = System.Drawing.Color.Bisque
        Me.bttnPurchases.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnPurchases.BorderColor = System.Drawing.Color.Black
        Me.bttnPurchases.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnPurchases.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnPurchases.CheckedForeColor = System.Drawing.Color.White
        Me.bttnPurchases.CheckedImage = CType(resources.GetObject("bttnPurchases.CheckedImage"), System.Drawing.Image)
        Me.bttnPurchases.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnPurchases.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnPurchases.FocusedColor = System.Drawing.Color.Empty
        Me.bttnPurchases.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnPurchases.ForeColor = System.Drawing.Color.White
        Me.bttnPurchases.Image = Nothing
        Me.bttnPurchases.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnPurchases.LineColor = System.Drawing.Color.White
        Me.bttnPurchases.Location = New System.Drawing.Point(-4, 433)
        Me.bttnPurchases.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnPurchases.Name = "bttnPurchases"
        Me.bttnPurchases.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnPurchases.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnPurchases.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnPurchases.OnHoverImage = Nothing
        Me.bttnPurchases.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnPurchases.OnPressedColor = System.Drawing.Color.Black
        Me.bttnPurchases.Size = New System.Drawing.Size(344, 68)
        Me.bttnPurchases.TabIndex = 4
        Me.bttnPurchases.Text = "Purchases"
        Me.bttnPurchases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnSuppliers
        '
        Me.bttnSuppliers.AnimationHoverSpeed = 0.07!
        Me.bttnSuppliers.AnimationSpeed = 0.03!
        Me.bttnSuppliers.BackColor = System.Drawing.Color.Bisque
        Me.bttnSuppliers.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnSuppliers.BorderColor = System.Drawing.Color.Black
        Me.bttnSuppliers.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnSuppliers.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnSuppliers.CheckedForeColor = System.Drawing.Color.White
        Me.bttnSuppliers.CheckedImage = CType(resources.GetObject("bttnSuppliers.CheckedImage"), System.Drawing.Image)
        Me.bttnSuppliers.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnSuppliers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnSuppliers.FocusedColor = System.Drawing.Color.Empty
        Me.bttnSuppliers.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSuppliers.ForeColor = System.Drawing.Color.White
        Me.bttnSuppliers.Image = Nothing
        Me.bttnSuppliers.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnSuppliers.LineColor = System.Drawing.Color.White
        Me.bttnSuppliers.Location = New System.Drawing.Point(-4, 341)
        Me.bttnSuppliers.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSuppliers.Name = "bttnSuppliers"
        Me.bttnSuppliers.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnSuppliers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnSuppliers.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnSuppliers.OnHoverImage = Nothing
        Me.bttnSuppliers.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnSuppliers.OnPressedColor = System.Drawing.Color.Black
        Me.bttnSuppliers.Size = New System.Drawing.Size(344, 68)
        Me.bttnSuppliers.TabIndex = 3
        Me.bttnSuppliers.Text = "Suppliers"
        Me.bttnSuppliers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnCustomers
        '
        Me.bttnCustomers.AnimationHoverSpeed = 0.07!
        Me.bttnCustomers.AnimationSpeed = 0.03!
        Me.bttnCustomers.BackColor = System.Drawing.Color.Bisque
        Me.bttnCustomers.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnCustomers.BorderColor = System.Drawing.Color.Black
        Me.bttnCustomers.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnCustomers.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnCustomers.CheckedForeColor = System.Drawing.Color.White
        Me.bttnCustomers.CheckedImage = CType(resources.GetObject("bttnCustomers.CheckedImage"), System.Drawing.Image)
        Me.bttnCustomers.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnCustomers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnCustomers.FocusedColor = System.Drawing.Color.Empty
        Me.bttnCustomers.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCustomers.ForeColor = System.Drawing.Color.White
        Me.bttnCustomers.Image = Nothing
        Me.bttnCustomers.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnCustomers.LineColor = System.Drawing.Color.White
        Me.bttnCustomers.Location = New System.Drawing.Point(-4, 241)
        Me.bttnCustomers.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnCustomers.Name = "bttnCustomers"
        Me.bttnCustomers.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnCustomers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnCustomers.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnCustomers.OnHoverImage = Nothing
        Me.bttnCustomers.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnCustomers.OnPressedColor = System.Drawing.Color.Black
        Me.bttnCustomers.Size = New System.Drawing.Size(344, 68)
        Me.bttnCustomers.TabIndex = 2
        Me.bttnCustomers.Text = "Customers"
        Me.bttnCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnProducts
        '
        Me.bttnProducts.AnimationHoverSpeed = 0.07!
        Me.bttnProducts.AnimationSpeed = 0.03!
        Me.bttnProducts.BackColor = System.Drawing.Color.Bisque
        Me.bttnProducts.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnProducts.BorderColor = System.Drawing.Color.Black
        Me.bttnProducts.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnProducts.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnProducts.CheckedForeColor = System.Drawing.Color.White
        Me.bttnProducts.CheckedImage = CType(resources.GetObject("bttnProducts.CheckedImage"), System.Drawing.Image)
        Me.bttnProducts.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnProducts.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnProducts.FocusedColor = System.Drawing.Color.Empty
        Me.bttnProducts.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnProducts.ForeColor = System.Drawing.Color.White
        Me.bttnProducts.Image = Nothing
        Me.bttnProducts.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnProducts.LineColor = System.Drawing.Color.White
        Me.bttnProducts.LineLeft = 10
        Me.bttnProducts.Location = New System.Drawing.Point(-4, 145)
        Me.bttnProducts.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnProducts.Name = "bttnProducts"
        Me.bttnProducts.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnProducts.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnProducts.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnProducts.OnHoverImage = Nothing
        Me.bttnProducts.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnProducts.OnPressedColor = System.Drawing.Color.Black
        Me.bttnProducts.Size = New System.Drawing.Size(344, 68)
        Me.bttnProducts.TabIndex = 1
        Me.bttnProducts.Text = "Products"
        Me.bttnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.bttnSettings)
        Me.Panel2.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-4, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 92)
        Me.Panel2.TabIndex = 0
        '
        'bttnSettings
        '
        Me.bttnSettings.AnimationHoverSpeed = 0.07!
        Me.bttnSettings.AnimationSpeed = 0.03!
        Me.bttnSettings.BaseColor = System.Drawing.Color.Black
        Me.bttnSettings.BorderColor = System.Drawing.Color.Black
        Me.bttnSettings.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnSettings.FocusedColor = System.Drawing.Color.Empty
        Me.bttnSettings.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnSettings.ForeColor = System.Drawing.Color.White
        Me.bttnSettings.Image = Global.Srinath.My.Resources.Resources.white_gear_icon_png_10
        Me.bttnSettings.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnSettings.Location = New System.Drawing.Point(264, 24)
        Me.bttnSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSettings.Name = "bttnSettings"
        Me.bttnSettings.OnHoverBaseColor = System.Drawing.Color.White
        Me.bttnSettings.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnSettings.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnSettings.OnHoverImage = Nothing
        Me.bttnSettings.OnPressedColor = System.Drawing.Color.Black
        Me.bttnSettings.Size = New System.Drawing.Size(52, 57)
        Me.bttnSettings.TabIndex = 6
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.Srinath.My.Resources.Resources.Tick_Mark_Dark_512
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(10, 24)
        Me.GunaCirclePictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(42, 51)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 5
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "System Admin "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(592, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 41)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Settings"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.panelSettings)
        Me.Panel3.Location = New System.Drawing.Point(381, 6)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(930, 824)
        Me.Panel3.TabIndex = 1
        '
        'panelSettings
        '
        Me.panelSettings.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelSettings.Controls.Add(Me.bttnResetDB)
        Me.panelSettings.Controls.Add(Me.bttnAbout)
        Me.panelSettings.Controls.Add(Me.bttnResetPassword)
        Me.panelSettings.Controls.Add(Me.bttnLogout)
        Me.panelSettings.Controls.Add(Me.GunaCirclePictureBox2)
        Me.panelSettings.Controls.Add(Me.bttnSettingsCancel)
        Me.panelSettings.Controls.Add(Me.Label4)
        Me.panelSettings.Location = New System.Drawing.Point(316, 18)
        Me.panelSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.panelSettings.Name = "panelSettings"
        Me.panelSettings.Size = New System.Drawing.Size(297, 502)
        Me.panelSettings.TabIndex = 0
        '
        'bttnResetDB
        '
        Me.bttnResetDB.AnimationHoverSpeed = 0.07!
        Me.bttnResetDB.AnimationSpeed = 0.03!
        Me.bttnResetDB.BackColor = System.Drawing.Color.Bisque
        Me.bttnResetDB.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnResetDB.BorderColor = System.Drawing.Color.Black
        Me.bttnResetDB.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnResetDB.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnResetDB.CheckedForeColor = System.Drawing.Color.White
        Me.bttnResetDB.CheckedImage = CType(resources.GetObject("bttnResetDB.CheckedImage"), System.Drawing.Image)
        Me.bttnResetDB.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnResetDB.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnResetDB.FocusedColor = System.Drawing.Color.Empty
        Me.bttnResetDB.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnResetDB.ForeColor = System.Drawing.Color.White
        Me.bttnResetDB.Image = Nothing
        Me.bttnResetDB.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnResetDB.LineColor = System.Drawing.Color.White
        Me.bttnResetDB.Location = New System.Drawing.Point(-2, 242)
        Me.bttnResetDB.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnResetDB.Name = "bttnResetDB"
        Me.bttnResetDB.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnResetDB.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnResetDB.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnResetDB.OnHoverImage = Nothing
        Me.bttnResetDB.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnResetDB.OnPressedColor = System.Drawing.Color.Black
        Me.bttnResetDB.Size = New System.Drawing.Size(302, 52)
        Me.bttnResetDB.TabIndex = 31
        Me.bttnResetDB.Text = "Reset Database"
        Me.bttnResetDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnAbout
        '
        Me.bttnAbout.AnimationHoverSpeed = 0.07!
        Me.bttnAbout.AnimationSpeed = 0.03!
        Me.bttnAbout.BackColor = System.Drawing.Color.Bisque
        Me.bttnAbout.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnAbout.BorderColor = System.Drawing.Color.Black
        Me.bttnAbout.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnAbout.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnAbout.CheckedForeColor = System.Drawing.Color.White
        Me.bttnAbout.CheckedImage = CType(resources.GetObject("bttnAbout.CheckedImage"), System.Drawing.Image)
        Me.bttnAbout.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnAbout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnAbout.FocusedColor = System.Drawing.Color.Empty
        Me.bttnAbout.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnAbout.ForeColor = System.Drawing.Color.White
        Me.bttnAbout.Image = Nothing
        Me.bttnAbout.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnAbout.LineColor = System.Drawing.Color.White
        Me.bttnAbout.Location = New System.Drawing.Point(-4, 318)
        Me.bttnAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnAbout.Name = "bttnAbout"
        Me.bttnAbout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnAbout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAbout.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAbout.OnHoverImage = Nothing
        Me.bttnAbout.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnAbout.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAbout.Size = New System.Drawing.Size(302, 52)
        Me.bttnAbout.TabIndex = 31
        Me.bttnAbout.Text = "About"
        Me.bttnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnResetPassword
        '
        Me.bttnResetPassword.AnimationHoverSpeed = 0.07!
        Me.bttnResetPassword.AnimationSpeed = 0.03!
        Me.bttnResetPassword.BackColor = System.Drawing.Color.Bisque
        Me.bttnResetPassword.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnResetPassword.BorderColor = System.Drawing.Color.Black
        Me.bttnResetPassword.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnResetPassword.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnResetPassword.CheckedForeColor = System.Drawing.Color.White
        Me.bttnResetPassword.CheckedImage = CType(resources.GetObject("bttnResetPassword.CheckedImage"), System.Drawing.Image)
        Me.bttnResetPassword.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnResetPassword.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnResetPassword.FocusedColor = System.Drawing.Color.Empty
        Me.bttnResetPassword.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnResetPassword.ForeColor = System.Drawing.Color.White
        Me.bttnResetPassword.Image = Nothing
        Me.bttnResetPassword.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnResetPassword.LineColor = System.Drawing.Color.White
        Me.bttnResetPassword.Location = New System.Drawing.Point(-2, 170)
        Me.bttnResetPassword.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnResetPassword.Name = "bttnResetPassword"
        Me.bttnResetPassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnResetPassword.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnResetPassword.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnResetPassword.OnHoverImage = Nothing
        Me.bttnResetPassword.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnResetPassword.OnPressedColor = System.Drawing.Color.Black
        Me.bttnResetPassword.Size = New System.Drawing.Size(302, 52)
        Me.bttnResetPassword.TabIndex = 30
        Me.bttnResetPassword.Text = "Reset Password"
        Me.bttnResetPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bttnLogout
        '
        Me.bttnLogout.AnimationHoverSpeed = 0.07!
        Me.bttnLogout.AnimationSpeed = 0.03!
        Me.bttnLogout.BackColor = System.Drawing.Color.Bisque
        Me.bttnLogout.BaseColor = System.Drawing.Color.SaddleBrown
        Me.bttnLogout.BorderColor = System.Drawing.Color.Black
        Me.bttnLogout.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bttnLogout.CheckedBorderColor = System.Drawing.Color.Black
        Me.bttnLogout.CheckedForeColor = System.Drawing.Color.White
        Me.bttnLogout.CheckedImage = CType(resources.GetObject("bttnLogout.CheckedImage"), System.Drawing.Image)
        Me.bttnLogout.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bttnLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnLogout.FocusedColor = System.Drawing.Color.Empty
        Me.bttnLogout.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnLogout.ForeColor = System.Drawing.Color.White
        Me.bttnLogout.Image = Nothing
        Me.bttnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.bttnLogout.LineColor = System.Drawing.Color.White
        Me.bttnLogout.Location = New System.Drawing.Point(-4, 97)
        Me.bttnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnLogout.Name = "bttnLogout"
        Me.bttnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnLogout.OnHoverImage = Nothing
        Me.bttnLogout.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.bttnLogout.Size = New System.Drawing.Size(302, 52)
        Me.bttnLogout.TabIndex = 29
        Me.bttnLogout.Text = "Logout"
        Me.bttnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaCirclePictureBox2
        '
        Me.GunaCirclePictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox2.Image = Global.Srinath.My.Resources.Resources.white_gear_icon_png_10
        Me.GunaCirclePictureBox2.Location = New System.Drawing.Point(22, 14)
        Me.GunaCirclePictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaCirclePictureBox2.Name = "GunaCirclePictureBox2"
        Me.GunaCirclePictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.GunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox2.TabIndex = 28
        Me.GunaCirclePictureBox2.TabStop = False
        Me.GunaCirclePictureBox2.UseTransfarantBackground = False
        '
        'bttnSettingsCancel
        '
        Me.bttnSettingsCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnSettingsCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSettingsCancel.ForeColor = System.Drawing.Color.White
        Me.bttnSettingsCancel.Location = New System.Drawing.Point(84, 404)
        Me.bttnSettingsCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnSettingsCancel.Name = "bttnSettingsCancel"
        Me.bttnSettingsCancel.Size = New System.Drawing.Size(132, 41)
        Me.bttnSettingsCancel.TabIndex = 27
        Me.bttnSettingsCancel.Text = "Cancel"
        Me.bttnSettingsCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(92, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 41)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Settings"
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1048, 685)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProductsForm"
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.panelSettings.ResumeLayout(False)
        Me.panelSettings.PerformLayout()
        CType(Me.GunaCirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bttnProducts As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnInventory As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnSales As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnPurchases As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnSuppliers As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnCustomers As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents bttnSettings As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelSettings As Panel
    Friend WithEvents bttnAbout As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnResetPassword As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnLogout As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaCirclePictureBox2 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents bttnSettingsCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents bttnResetDB As Guna.UI.WinForms.GunaAdvenceButton
End Class
