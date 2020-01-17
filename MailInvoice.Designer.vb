<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MailInvoice
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
        Me.bttnSendInvoice = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReceiverEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAttachment = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bttnSelectInvoice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bttnSendInvoice
        '
        Me.bttnSendInvoice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSendInvoice.Location = New System.Drawing.Point(103, 190)
        Me.bttnSendInvoice.Name = "bttnSendInvoice"
        Me.bttnSendInvoice.Size = New System.Drawing.Size(135, 34)
        Me.bttnSendInvoice.TabIndex = 0
        Me.bttnSendInvoice.Text = "&Mail Invoice"
        Me.bttnSendInvoice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type Receiver Email Address :"
        '
        'txtReceiverEmail
        '
        Me.txtReceiverEmail.Location = New System.Drawing.Point(42, 42)
        Me.txtReceiverEmail.Name = "txtReceiverEmail"
        Me.txtReceiverEmail.Size = New System.Drawing.Size(242, 20)
        Me.txtReceiverEmail.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Invoice :"
        '
        'txtAttachment
        '
        Me.txtAttachment.Location = New System.Drawing.Point(42, 124)
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.Size = New System.Drawing.Size(242, 20)
        Me.txtAttachment.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'bttnSelectInvoice
        '
        Me.bttnSelectInvoice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSelectInvoice.Location = New System.Drawing.Point(290, 119)
        Me.bttnSelectInvoice.Name = "bttnSelectInvoice"
        Me.bttnSelectInvoice.Size = New System.Drawing.Size(40, 25)
        Me.bttnSelectInvoice.TabIndex = 5
        Me.bttnSelectInvoice.Text = "..."
        Me.bttnSelectInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bttnSelectInvoice.UseVisualStyleBackColor = True
        '
        'MailInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 236)
        Me.Controls.Add(Me.bttnSelectInvoice)
        Me.Controls.Add(Me.txtAttachment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReceiverEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttnSendInvoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MailInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnSendInvoice As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReceiverEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAttachment As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents bttnSelectInvoice As Button
End Class
