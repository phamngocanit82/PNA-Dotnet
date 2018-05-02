<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContainFormChildButtonPNA
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
        Me.btnClose = New componentPNA.ButtonStylePNA(Me.components)
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(204, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(11, 9)
        Me.btnClose.Skin = componentPNA.ButtonStylePNA.EnumSkin.Skins1
        Me.btnClose.TabIndex = 3
        Me.btnClose.ToolTip = "Close"
        Me.btnClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None
        Me.btnClose.ToolTipTitle = ""
        Me.btnClose.Type = componentPNA.ButtonStylePNA.EnumType.AExit
        '
        'ContainFormChildButtonPNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClose)
        Me.Name = "ContainFormChildButtonPNA"
        Me.Size = New System.Drawing.Size(219, 26)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As componentPNA.ButtonStylePNA

End Class
