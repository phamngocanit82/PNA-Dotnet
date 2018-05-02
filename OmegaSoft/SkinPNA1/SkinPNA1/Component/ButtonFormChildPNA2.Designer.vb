<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonFormChildPNA2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ButtonFormChildPNA2))
        Me.btnClose = New OmegaSkins1.ButtonFormChildPNA1
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BIndex = 0
        Me.btnClose.BToolTip = Nothing
        Me.btnClose.Location = New System.Drawing.Point(205, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.SendBack = False
        Me.btnClose.Size = New System.Drawing.Size(10, 9)
        Me.btnClose.State = OmegaSkins1.ButtonFormChildPNA1.StateButton.Normal
        Me.btnClose.Style = OmegaSkins1.ButtonFormChildPNA1.StyleButton.Style1
        Me.btnClose.TabIndex = 1
        '
        'ButtonFormChildPNA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ButtonFormChildPNA2"
        Me.Size = New System.Drawing.Size(219, 26)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As OmegaSkins1.ButtonFormChildPNA1

End Class
