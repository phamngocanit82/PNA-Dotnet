<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonShuffle
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tipButton = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrButtonForm = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ButtonClose"
        Me.Size = New System.Drawing.Size(14, 14)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tipButton As System.Windows.Forms.ToolTip
    Friend WithEvents tmrButtonForm As System.Windows.Forms.Timer

End Class
