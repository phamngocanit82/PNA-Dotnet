<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskbar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.cmnuOmega = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AaaaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaximizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnOmega = New OmegaSkins.ButtonPNA
        Me.cmnuOmega.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmnuOmega
        '
        Me.cmnuOmega.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AaaaToolStripMenuItem, Me.MinimizeToolStripMenuItem, Me.MaximizeToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.cmnuOmega.Name = "cmnuOmega"
        Me.cmnuOmega.Size = New System.Drawing.Size(153, 114)
        '
        'AaaaToolStripMenuItem
        '
        Me.AaaaToolStripMenuItem.Name = "AaaaToolStripMenuItem"
        Me.AaaaToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AaaaToolStripMenuItem.Text = "Restore"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'MaximizeToolStripMenuItem
        '
        Me.MaximizeToolStripMenuItem.Name = "MaximizeToolStripMenuItem"
        Me.MaximizeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MaximizeToolStripMenuItem.Text = "Maximize"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Thoát hihi"
        '
        'btnOmega
        '
        Me.btnOmega.BackColor = System.Drawing.SystemColors.Info
        Me.btnOmega.BToolTip = Nothing
        Me.btnOmega.ContextMenuStrip = Me.cmnuOmega
        Me.btnOmega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOmega.Location = New System.Drawing.Point(1, 1)
        Me.btnOmega.Name = "btnOmega"
        Me.btnOmega.Size = New System.Drawing.Size(115, 28)
        Me.btnOmega.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnOmega.TabIndex = 1
        Me.btnOmega.Text = "Phần mềm Omega"
        Me.btnOmega.UseVisualStyleBackColor = True
        '
        'frmTaskbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(117, 32)
        Me.Controls.Add(Me.btnOmega)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTaskbar"
        Me.Text = "frmTaskbar"
        Me.cmnuOmega.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmnuOmega As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnOmega As OmegaSkins.ButtonPNA
    Friend WithEvents AaaaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaximizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
