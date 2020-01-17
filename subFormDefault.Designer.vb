<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subFormDefault
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblcurrtime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDayDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(305, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1289, 170)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Welcome back User!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(533, 267)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(802, 142)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select a module from the panel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on the right to begin."
        '
        'lblcurrtime
        '
        Me.lblcurrtime.AutoSize = True
        Me.lblcurrtime.BackColor = System.Drawing.Color.Transparent
        Me.lblcurrtime.Font = New System.Drawing.Font("Lucida Console", 100.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrtime.ForeColor = System.Drawing.Color.Black
        Me.lblcurrtime.Location = New System.Drawing.Point(234, 641)
        Me.lblcurrtime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcurrtime.Name = "lblcurrtime"
        Me.lblcurrtime.Size = New System.Drawing.Size(756, 267)
        Me.lblcurrtime.TabIndex = 8
        Me.lblcurrtime.Text = "TIME"
        '
        'Timer1
        '
        '
        'lblDayDate
        '
        Me.lblDayDate.AutoSize = True
        Me.lblDayDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDayDate.Font = New System.Drawing.Font("Lucida Console", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDayDate.ForeColor = System.Drawing.Color.DimGray
        Me.lblDayDate.Location = New System.Drawing.Point(532, 957)
        Me.lblDayDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDayDate.Name = "lblDayDate"
        Me.lblDayDate.Size = New System.Drawing.Size(347, 75)
        Me.lblDayDate.TabIndex = 10
        Me.lblDayDate.Text = "DayDate"
        '
        'subFormDefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1860, 1585)
        Me.Controls.Add(Me.lblDayDate)
        Me.Controls.Add(Me.lblcurrtime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "subFormDefault"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblcurrtime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDayDate As Label
End Class
