<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewerInventory
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
        Me.CRViewerInventory = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewerInventory
        '
        Me.CRViewerInventory.ActiveViewIndex = -1
        Me.CRViewerInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewerInventory.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewerInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewerInventory.Location = New System.Drawing.Point(0, 0)
        Me.CRViewerInventory.Name = "CRViewerInventory"
        Me.CRViewerInventory.Size = New System.Drawing.Size(967, 524)
        Me.CRViewerInventory.TabIndex = 0
        '
        'ReportViewerInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 524)
        Me.Controls.Add(Me.CRViewerInventory)
        Me.Name = "ReportViewerInventory"
        Me.Text = "ReportViewerInventory"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRViewerInventory As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
