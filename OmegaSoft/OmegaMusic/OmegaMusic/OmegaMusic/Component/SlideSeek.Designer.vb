<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlideSeek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SlideSeek))
        Me.panelSeek2 = New System.Windows.Forms.Panel
        Me.panelSeek1 = New System.Windows.Forms.Panel
        Me.tipButton = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSeek = New OmegaMusic.ButtonSeek
        Me.SuspendLayout()
        '
        'panelSeek2
        '
        Me.panelSeek2.BackgroundImage = CType(resources.GetObject("panelSeek2.BackgroundImage"), System.Drawing.Image)
        Me.panelSeek2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSeek2.Location = New System.Drawing.Point(0, 2)
        Me.panelSeek2.Name = "panelSeek2"
        Me.panelSeek2.Size = New System.Drawing.Size(70, 3)
        Me.panelSeek2.TabIndex = 2
        Me.tipButton.SetToolTip(Me.panelSeek2, "Seek")
        '
        'panelSeek1
        '
        Me.panelSeek1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSeek1.BackgroundImage = CType(resources.GetObject("panelSeek1.BackgroundImage"), System.Drawing.Image)
        Me.panelSeek1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelSeek1.Location = New System.Drawing.Point(0, 2)
        Me.panelSeek1.Name = "panelSeek1"
        Me.panelSeek1.Size = New System.Drawing.Size(358, 3)
        Me.panelSeek1.TabIndex = 1
        Me.tipButton.SetToolTip(Me.panelSeek1, "Seek")
        '
        'btnSeek
        '
        Me.btnSeek.BToolTip = Nothing
        Me.btnSeek.Location = New System.Drawing.Point(174, -1)
        Me.btnSeek.Name = "btnSeek"
        Me.btnSeek.Size = New System.Drawing.Size(11, 9)
        Me.btnSeek.Style = OmegaMusic.ButtonSeek.StyleButton.Style1
        Me.btnSeek.TabIndex = 5
        Me.tipButton.SetToolTip(Me.btnSeek, "Seek")
        '
        'SlideSeek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnSeek)
        Me.Controls.Add(Me.panelSeek2)
        Me.Controls.Add(Me.panelSeek1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SlideSeek"
        Me.Size = New System.Drawing.Size(358, 54)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelSeek1 As System.Windows.Forms.Panel
    Friend WithEvents panelSeek2 As System.Windows.Forms.Panel
    Friend WithEvents tipButton As System.Windows.Forms.ToolTip
    Friend WithEvents btnSeek As OmegaMusic.ButtonSeek

End Class
