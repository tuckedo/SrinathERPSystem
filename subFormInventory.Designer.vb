<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class subFormInventory
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
        Me.txtInventorySearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnInventorySearch = New Guna.UI.WinForms.GunaCircleButton()
        Me.dgInventory = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.dgInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInventorySearch
        '
        Me.txtInventorySearch.BackColor = System.Drawing.Color.White
        Me.txtInventorySearch.Font = New System.Drawing.Font("Segoe UI", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInventorySearch.ForeColor = System.Drawing.Color.DimGray
        Me.txtInventorySearch.Location = New System.Drawing.Point(356, 133)
        Me.txtInventorySearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInventorySearch.MaxLength = 10
        Me.txtInventorySearch.Multiline = True
        Me.txtInventorySearch.Name = "txtInventorySearch"
        Me.txtInventorySearch.Size = New System.Drawing.Size(1264, 98)
        Me.txtInventorySearch.TabIndex = 24
        Me.txtInventorySearch.Text = "Search by date"
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
        Me.Label2.Size = New System.Drawing.Size(303, 78)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Inventory"
        '
        'bttnInventorySearch
        '
        Me.bttnInventorySearch.AnimationHoverSpeed = 0.07!
        Me.bttnInventorySearch.AnimationSpeed = 0.03!
        Me.bttnInventorySearch.BackColor = System.Drawing.Color.White
        Me.bttnInventorySearch.BaseColor = System.Drawing.Color.Transparent
        Me.bttnInventorySearch.BorderColor = System.Drawing.Color.Transparent
        Me.bttnInventorySearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bttnInventorySearch.FocusedColor = System.Drawing.Color.Empty
        Me.bttnInventorySearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bttnInventorySearch.ForeColor = System.Drawing.Color.White
        Me.bttnInventorySearch.Image = Global.Srinath.My.Resources.Resources.search
        Me.bttnInventorySearch.ImageSize = New System.Drawing.Size(52, 52)
        Me.bttnInventorySearch.Location = New System.Drawing.Point(1500, 140)
        Me.bttnInventorySearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bttnInventorySearch.Name = "bttnInventorySearch"
        Me.bttnInventorySearch.OnHoverBaseColor = System.Drawing.Color.Gainsboro
        Me.bttnInventorySearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bttnInventorySearch.OnHoverForeColor = System.Drawing.Color.White
        Me.bttnInventorySearch.OnHoverImage = Nothing
        Me.bttnInventorySearch.OnPressedColor = System.Drawing.Color.Black
        Me.bttnInventorySearch.Size = New System.Drawing.Size(108, 83)
        Me.bttnInventorySearch.TabIndex = 25
        '
        'dgInventory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgInventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgInventory.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInventory.ColumnHeadersHeight = 50
        Me.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgInventory.EnableHeadersVisualStyles = False
        Me.dgInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgInventory.Location = New System.Drawing.Point(38, 302)
        Me.dgInventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgInventory.Name = "dgInventory"
        Me.dgInventory.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInventory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgInventory.RowHeadersVisible = False
        Me.dgInventory.RowHeadersWidth = 82
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgInventory.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgInventory.RowTemplate.Height = 33
        Me.dgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInventory.Size = New System.Drawing.Size(1812, 962)
        Me.dgInventory.TabIndex = 29
        Me.dgInventory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Carrot
        Me.dgInventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.dgInventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgInventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgInventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgInventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgInventory.ThemeStyle.BackColor = System.Drawing.Color.NavajoWhite
        Me.dgInventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgInventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.dgInventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgInventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgInventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgInventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgInventory.ThemeStyle.HeaderStyle.Height = 50
        Me.dgInventory.ThemeStyle.ReadOnly = True
        Me.dgInventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.dgInventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgInventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgInventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgInventory.ThemeStyle.RowsStyle.Height = 33
        Me.dgInventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.dgInventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'subFormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1976, 1452)
        Me.Controls.Add(Me.dgInventory)
        Me.Controls.Add(Me.bttnInventorySearch)
        Me.Controls.Add(Me.txtInventorySearch)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "subFormInventory"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttnInventorySearch As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents txtInventorySearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgInventory As Guna.UI.WinForms.GunaDataGridView
End Class
