<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonFormMainPNA1
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
        Me.tipButtonForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrButtonForm = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'tmrButtonForm
        '
        '
        'ButtonFormMainPNA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ButtonFormMainPNA1"
        Me.Size = New System.Drawing.Size(30, 17)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tipButtonForm As System.Windows.Forms.ToolTip
    Friend WithEvents tmrButtonForm As System.Windows.Forms.Timer

End Class
