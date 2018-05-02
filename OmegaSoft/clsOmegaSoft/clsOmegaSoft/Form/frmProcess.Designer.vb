<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcess))
        Me.FrmProcessPNA1 = New OmegaSkins2.FrmProcessPNA
        Me.SuspendLayout()
        '
        'FrmProcessPNA1
        '
        Me.FrmProcessPNA1.BackgroundImage = CType(resources.GetObject("FrmProcessPNA1.BackgroundImage"), System.Drawing.Image)
        Me.FrmProcessPNA1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmProcessPNA1.Location = New System.Drawing.Point(0, 0)
        Me.FrmProcessPNA1.Name = "FrmProcessPNA1"
        Me.FrmProcessPNA1.Size = New System.Drawing.Size(328, 72)
        Me.FrmProcessPNA1.TabIndex = 0
        Me.FrmProcessPNA1.Value = 0
        '
        'frmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 72)
        Me.Controls.Add(Me.FrmProcessPNA1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProcess"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProcess"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmProcessPNA1 As OmegaSkins2.FrmProcessPNA
End Class
