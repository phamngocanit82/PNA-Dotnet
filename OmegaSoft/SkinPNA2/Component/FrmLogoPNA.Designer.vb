<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogoPNA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogoPNA))
        Me.ButtonLogoOk1 = New OmegaSkins2.ButtonLogoOk
        Me.ButtonLogoClose1 = New OmegaSkins2.ButtonLogoClose
        Me.SuspendLayout()
        '
        'ButtonLogoOk1
        '
        Me.ButtonLogoOk1.BToolTip = Nothing
        Me.ButtonLogoOk1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogoOk1.Location = New System.Drawing.Point(124, 104)
        Me.ButtonLogoOk1.Name = "ButtonLogoOk1"
        Me.ButtonLogoOk1.Size = New System.Drawing.Size(69, 21)
        Me.ButtonLogoOk1.Style = OmegaSkins2.ButtonLogoOk.StyleButton.Style1
        Me.ButtonLogoOk1.TabIndex = 1
        Me.ButtonLogoOk1.TText = "&Ok"
        '
        'ButtonLogoClose1
        '
        Me.ButtonLogoClose1.BToolTip = Nothing
        Me.ButtonLogoClose1.Location = New System.Drawing.Point(264, 2)
        Me.ButtonLogoClose1.Name = "ButtonLogoClose1"
        Me.ButtonLogoClose1.Size = New System.Drawing.Size(46, 19)
        Me.ButtonLogoClose1.Style = OmegaSkins2.ButtonLogoClose.StyleButton.Style1
        Me.ButtonLogoClose1.TabIndex = 0
        '
        'frmLogoPNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.ButtonLogoOk1)
        Me.Controls.Add(Me.ButtonLogoClose1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmLogoPNA"
        Me.Size = New System.Drawing.Size(317, 144)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ButtonLogoClose1 As OmegaSkins2.ButtonLogoClose
    Public WithEvents ButtonLogoOk1 As OmegaSkins2.ButtonLogoOk

End Class
