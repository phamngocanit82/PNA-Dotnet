<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSlidebar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSlidebar))
        Me.CalculatorPNA11 = New OmegaSkins1.CalculatorPNA1
        Me.ClockPNA11 = New OmegaSkins1.ClockPNA1
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonPNA41 = New OmegaSkins1.ButtonPNA4
        Me.CalendarPNA11 = New OmegaSkins1.CalendarPNA1
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CalculatorPNA11
        '
        Me.CalculatorPNA11.BackgroundImage = CType(resources.GetObject("CalculatorPNA11.BackgroundImage"), System.Drawing.Image)
        Me.CalculatorPNA11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorPNA11.Location = New System.Drawing.Point(8, 192)
        Me.CalculatorPNA11.Name = "CalculatorPNA11"
        Me.CalculatorPNA11.Size = New System.Drawing.Size(157, 175)
        Me.CalculatorPNA11.TabIndex = 10
        '
        'ClockPNA11
        '
        Me.ClockPNA11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClockPNA11.BackColor = System.Drawing.Color.Transparent
        Me.ClockPNA11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockPNA11.Location = New System.Drawing.Point(2, 378)
        Me.ClockPNA11.Name = "ClockPNA11"
        Me.ClockPNA11.Size = New System.Drawing.Size(170, 132)
        Me.ClockPNA11.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 397)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 185)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.ButtonPNA41)
        Me.Panel1.Location = New System.Drawing.Point(4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 22)
        Me.Panel1.TabIndex = 12
        '
        'ButtonPNA41
        '
        Me.ButtonPNA41.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPNA41.BackgroundImage = CType(resources.GetObject("ButtonPNA41.BackgroundImage"), System.Drawing.Image)
        Me.ButtonPNA41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPNA41.Location = New System.Drawing.Point(145, 2)
        Me.ButtonPNA41.Name = "ButtonPNA41"
        Me.ButtonPNA41.Size = New System.Drawing.Size(17, 17)
        Me.ButtonPNA41.Style = OmegaSkins1.ButtonPNA4.StyleButton.Style1
        Me.ButtonPNA41.TabIndex = 6
        Me.ButtonPNA41.TText = Nothing
        '
        'CalendarPNA11
        '
        Me.CalendarPNA11.BackgroundImage = CType(resources.GetObject("CalendarPNA11.BackgroundImage"), System.Drawing.Image)
        Me.CalendarPNA11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CalendarPNA11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendarPNA11.Location = New System.Drawing.Point(8, 33)
        Me.CalendarPNA11.Name = "CalendarPNA11"
        Me.CalendarPNA11.Size = New System.Drawing.Size(157, 128)
        Me.CalendarPNA11.TabIndex = 13
        '
        'FrmSlidebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OmegaSkins1.My.Resources.Resources.FormSlideBar
        Me.Controls.Add(Me.CalendarPNA11)
        Me.Controls.Add(Me.CalculatorPNA11)
        Me.Controls.Add(Me.ClockPNA11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmSlidebar"
        Me.Size = New System.Drawing.Size(172, 535)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CalculatorPNA11 As OmegaSkins1.CalculatorPNA1
    Friend WithEvents ClockPNA11 As OmegaSkins1.ClockPNA1
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ButtonPNA41 As OmegaSkins1.ButtonPNA4
    Friend WithEvents CalendarPNA11 As OmegaSkins1.CalendarPNA1

End Class
