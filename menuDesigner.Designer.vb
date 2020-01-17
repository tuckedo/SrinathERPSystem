<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuDesigner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuDesigner))
        Me.panelSettings = New System.Windows.Forms.Panel()
        Me.bttnCustomersCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.bttnLogout = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnResetPassword = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.bttnAbout = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.panelSettings.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSettings
        '
        Me.panelSettings.BackColor = System.Drawing.Color.SaddleBrown
        Me.panelSettings.Controls.Add(Me.bttnAbout)
        Me.panelSettings.Controls.Add(Me.bttnResetPassword)
        Me.panelSettings.Controls.Add(Me.bttnLogout)
        Me.panelSettings.Controls.Add(Me.GunaCirclePictureBox1)
        Me.panelSettings.Controls.Add(Me.bttnCustomersCancel)
        Me.panelSettings.Controls.Add(Me.Label2)
        Me.panelSettings.Location = New System.Drawing.Point(82, 32)
        Me.panelSettings.Name = "panelSettings"
        Me.panelSettings.Size = New System.Drawing.Size(540, 876)
        Me.panelSettings.TabIndex = 0
        '
        'bttnCustomersCancel
        '
        Me.bttnCustomersCancel.BackColor = System.Drawing.Color.Peru
        Me.bttnCustomersCancel.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCustomersCancel.ForeColor = System.Drawing.Color.White
        Me.bttnCustomersCancel.Location = New System.Drawing.Point(138, 738)
        Me.bttnCustomersCancel.Name = "bttnCustomersCancel"
        Me.bttnCustomersCancel.Size = New System.Drawing.Size(263, 78)
        Me.bttnCustomersCancel.TabIndex = 18
        Me.bttnCustomersCancel.Text = "Cancel"
        Me.bttnCustomersCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 22.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(141, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 78)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Settings"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = Global.Srinath.My.Resources.Resources.white_gear_icon_png_10
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(41, 42)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 22
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
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
        Me.bttnLogout.Location = New System.Drawing.Point(0, 164)
        Me.bttnLogout.Name = "bttnLogout"
        Me.bttnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnLogout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnLogout.OnHoverImage = Nothing
        Me.bttnLogout.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.bttnLogout.Size = New System.Drawing.Size(540, 130)
        Me.bttnLogout.TabIndex = 23
        Me.bttnLogout.Text = "Logout"
        Me.bttnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.bttnResetPassword.Location = New System.Drawing.Point(0, 360)
        Me.bttnResetPassword.Name = "bttnResetPassword"
        Me.bttnResetPassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnResetPassword.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnResetPassword.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnResetPassword.OnHoverImage = Nothing
        Me.bttnResetPassword.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnResetPassword.OnPressedColor = System.Drawing.Color.Black
        Me.bttnResetPassword.Size = New System.Drawing.Size(540, 130)
        Me.bttnResetPassword.TabIndex = 24
        Me.bttnResetPassword.Text = "Reset Password"
        Me.bttnResetPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.bttnAbout.Location = New System.Drawing.Point(-3, 551)
        Me.bttnAbout.Name = "bttnAbout"
        Me.bttnAbout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttnAbout.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnAbout.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnAbout.OnHoverImage = Nothing
        Me.bttnAbout.OnHoverLineColor = System.Drawing.Color.White
        Me.bttnAbout.OnPressedColor = System.Drawing.Color.Black
        Me.bttnAbout.Size = New System.Drawing.Size(540, 130)
        Me.bttnAbout.TabIndex = 25
        Me.bttnAbout.Text = "About"
        Me.bttnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'menuDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 1002)
        Me.Controls.Add(Me.panelSettings)
        Me.Name = "menuDesigner"
        Me.Text = "menuDesigner"
        Me.panelSettings.ResumeLayout(False)
        Me.panelSettings.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSettings As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents bttnCustomersCancel As Button
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents bttnAbout As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnResetPassword As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bttnLogout As Guna.UI.WinForms.GunaAdvenceButton
End Class
