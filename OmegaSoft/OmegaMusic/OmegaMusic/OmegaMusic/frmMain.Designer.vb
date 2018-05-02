<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenUrlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlaypauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblCaption = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ButtonMinimize1 = New OmegaMusic.ButtonMinimize
        Me.ButtonMaximize1 = New OmegaMusic.ButtonMaximize
        Me.ButtonClose1 = New OmegaMusic.ButtonClose
        Me.ButtonPlayPause2 = New OmegaMusic.ButtonPlayPause
        Me.SlideSeek1 = New OmegaMusic.SlideSeek
        Me.SlideSeek2 = New OmegaMusic.SlideSeek
        Me.ButtonNoSound1 = New OmegaMusic.ButtonNoSound
        Me.ButtonView1 = New OmegaMusic.ButtonView
        Me.ButtonNext1 = New OmegaMusic.ButtonNext
        Me.ButtonSwitch1 = New OmegaMusic.ButtonSwitch
        Me.ButtonStop1 = New OmegaMusic.ButtonStop
        Me.ButtonShuffle1 = New OmegaMusic.ButtonShuffle
        Me.ButtonPrevious1 = New OmegaMusic.ButtonPrevious
        Me.ButtonRepeat1 = New OmegaMusic.ButtonRepeat
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "OMEGA MUSIC"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.ButtonMinimize1)
        Me.Panel1.Controls.Add(Me.ButtonMaximize1)
        Me.Panel1.Controls.Add(Me.ButtonClose1)
        Me.Panel1.Controls.Add(Me.lblCaption)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 26)
        Me.Panel1.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.PlayToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(146, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(250, 26)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenUrlToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripMenuItem1.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenUrlToolStripMenuItem
        '
        Me.OpenUrlToolStripMenuItem.Name = "OpenUrlToolStripMenuItem"
        Me.OpenUrlToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OpenUrlToolStripMenuItem.Text = "Open Url"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripMenuItem2.Text = "&Edit"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaypauseToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.PlayToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PlaypauseToolStripMenuItem
        '
        Me.PlaypauseToolStripMenuItem.Name = "PlaypauseToolStripMenuItem"
        Me.PlaypauseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PlaypauseToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PlaypauseToolStripMenuItem.Text = "Play/Pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(45, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.Color.Transparent
        Me.lblCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(592, 26)
        Me.lblCaption.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(592, 190)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.ButtonPlayPause2)
        Me.Panel2.Controls.Add(Me.SlideSeek1)
        Me.Panel2.Controls.Add(Me.SlideSeek2)
        Me.Panel2.Controls.Add(Me.ButtonNoSound1)
        Me.Panel2.Controls.Add(Me.ButtonView1)
        Me.Panel2.Controls.Add(Me.ButtonNext1)
        Me.Panel2.Controls.Add(Me.ButtonSwitch1)
        Me.Panel2.Controls.Add(Me.ButtonStop1)
        Me.Panel2.Controls.Add(Me.ButtonShuffle1)
        Me.Panel2.Controls.Add(Me.ButtonPrevious1)
        Me.Panel2.Controls.Add(Me.ButtonRepeat1)
        Me.Panel2.Location = New System.Drawing.Point(0, 216)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 62)
        Me.Panel2.TabIndex = 6
        '
        'ButtonMinimize1
        '
        Me.ButtonMinimize1.BToolTip = "Minimize"
        Me.ButtonMinimize1.Location = New System.Drawing.Point(524, 9)
        Me.ButtonMinimize1.Name = "ButtonMinimize1"
        Me.ButtonMinimize1.Size = New System.Drawing.Size(18, 11)
        Me.ButtonMinimize1.Style = OmegaMusic.ButtonMinimize.StyleButton.Style1
        Me.ButtonMinimize1.TabIndex = 4
        '
        'ButtonMaximize1
        '
        Me.ButtonMaximize1.BToolTip = "Maximize"
        Me.ButtonMaximize1.Location = New System.Drawing.Point(546, 6)
        Me.ButtonMaximize1.Name = "ButtonMaximize1"
        Me.ButtonMaximize1.Size = New System.Drawing.Size(19, 15)
        Me.ButtonMaximize1.Style = OmegaMusic.ButtonMaximize.StyleButton.Style1
        Me.ButtonMaximize1.TabIndex = 4
        '
        'ButtonClose1
        '
        Me.ButtonClose1.BackgroundImage = CType(resources.GetObject("ButtonClose1.BackgroundImage"), System.Drawing.Image)
        Me.ButtonClose1.BToolTip = "Close"
        Me.ButtonClose1.Location = New System.Drawing.Point(570, 6)
        Me.ButtonClose1.Name = "ButtonClose1"
        Me.ButtonClose1.Size = New System.Drawing.Size(14, 14)
        Me.ButtonClose1.Style = OmegaMusic.ButtonClose.StyleButton.Style1
        Me.ButtonClose1.TabIndex = 4
        '
        'ButtonPlayPause2
        '
        Me.ButtonPlayPause2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPlayPause2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPlayPause2.BToolTip = Nothing
        Me.ButtonPlayPause2.Location = New System.Drawing.Point(290, 16)
        Me.ButtonPlayPause2.Name = "ButtonPlayPause2"
        Me.ButtonPlayPause2.PlayPause = OmegaMusic.ButtonPlayPause.PlayPauseButton.Play
        Me.ButtonPlayPause2.Size = New System.Drawing.Size(36, 36)
        Me.ButtonPlayPause2.Style = OmegaMusic.ButtonPlayPause.StyleButton.Style1
        Me.ButtonPlayPause2.TabIndex = 14
        '
        'SlideSeek1
        '
        Me.SlideSeek1.BackColor = System.Drawing.Color.Transparent
        Me.SlideSeek1.BToolTip = "Seek"
        Me.SlideSeek1.Distance = 0
        Me.SlideSeek1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlideSeek1.Location = New System.Drawing.Point(217, 7)
        Me.SlideSeek1.Max = 100
        Me.SlideSeek1.Min = 0
        Me.SlideSeek1.Name = "SlideSeek1"
        Me.SlideSeek1.Position = 0
        Me.SlideSeek1.Size = New System.Drawing.Size(207, 7)
        Me.SlideSeek1.TabIndex = 11
        '
        'SlideSeek2
        '
        Me.SlideSeek2.BackColor = System.Drawing.Color.Transparent
        Me.SlideSeek2.BToolTip = Nothing
        Me.SlideSeek2.Distance = 0
        Me.SlideSeek2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlideSeek2.Location = New System.Drawing.Point(469, 30)
        Me.SlideSeek2.Max = 85
        Me.SlideSeek2.Min = 0
        Me.SlideSeek2.Name = "SlideSeek2"
        Me.SlideSeek2.Position = 0
        Me.SlideSeek2.Size = New System.Drawing.Size(96, 7)
        Me.SlideSeek2.TabIndex = 12
        '
        'ButtonNoSound1
        '
        Me.ButtonNoSound1.BToolTip = Nothing
        Me.ButtonNoSound1.Location = New System.Drawing.Point(443, 24)
        Me.ButtonNoSound1.Name = "ButtonNoSound1"
        Me.ButtonNoSound1.Size = New System.Drawing.Size(20, 20)
        Me.ButtonNoSound1.Style = OmegaMusic.ButtonNoSound.StyleButton.Style1
        Me.ButtonNoSound1.TabIndex = 7
        '
        'ButtonView1
        '
        Me.ButtonView1.BToolTip = "View"
        Me.ButtonView1.Location = New System.Drawing.Point(567, 6)
        Me.ButtonView1.Name = "ButtonView1"
        Me.ButtonView1.Size = New System.Drawing.Size(21, 21)
        Me.ButtonView1.Style = OmegaMusic.ButtonView.StyleButton.Style1
        Me.ButtonView1.TabIndex = 9
        '
        'ButtonNext1
        '
        Me.ButtonNext1.BToolTip = "Next"
        Me.ButtonNext1.Location = New System.Drawing.Point(327, 24)
        Me.ButtonNext1.Name = "ButtonNext1"
        Me.ButtonNext1.Size = New System.Drawing.Size(46, 21)
        Me.ButtonNext1.Style = OmegaMusic.ButtonNext.StyleButton.Style1
        Me.ButtonNext1.TabIndex = 10
        '
        'ButtonSwitch1
        '
        Me.ButtonSwitch1.BToolTip = "Switch"
        Me.ButtonSwitch1.Location = New System.Drawing.Point(567, 37)
        Me.ButtonSwitch1.Name = "ButtonSwitch1"
        Me.ButtonSwitch1.Size = New System.Drawing.Size(21, 21)
        Me.ButtonSwitch1.Style = OmegaMusic.ButtonSwitch.StyleButton.Style1
        Me.ButtonSwitch1.TabIndex = 7
        '
        'ButtonStop1
        '
        Me.ButtonStop1.BToolTip = "Stop"
        Me.ButtonStop1.Location = New System.Drawing.Point(377, 24)
        Me.ButtonStop1.Name = "ButtonStop1"
        Me.ButtonStop1.Size = New System.Drawing.Size(21, 21)
        Me.ButtonStop1.Style = OmegaMusic.ButtonStop.StyleButton.Style1
        Me.ButtonStop1.TabIndex = 8
        '
        'ButtonShuffle1
        '
        Me.ButtonShuffle1.BToolTip = "Shuffle"
        Me.ButtonShuffle1.Location = New System.Drawing.Point(403, 24)
        Me.ButtonShuffle1.Name = "ButtonShuffle1"
        Me.ButtonShuffle1.Size = New System.Drawing.Size(21, 21)
        Me.ButtonShuffle1.Style = OmegaMusic.ButtonShuffle.StyleButton.Style1
        Me.ButtonShuffle1.TabIndex = 7
        '
        'ButtonPrevious1
        '
        Me.ButtonPrevious1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPrevious1.BToolTip = "Previous"
        Me.ButtonPrevious1.Location = New System.Drawing.Point(242, 24)
        Me.ButtonPrevious1.Name = "ButtonPrevious1"
        Me.ButtonPrevious1.Size = New System.Drawing.Size(46, 21)
        Me.ButtonPrevious1.Style = OmegaMusic.ButtonPrevious.StyleButton.Style1
        Me.ButtonPrevious1.TabIndex = 3
        '
        'ButtonRepeat1
        '
        Me.ButtonRepeat1.BToolTip = "Repeat"
        Me.ButtonRepeat1.Location = New System.Drawing.Point(217, 24)
        Me.ButtonRepeat1.Name = "ButtonRepeat1"
        Me.ButtonRepeat1.Size = New System.Drawing.Size(21, 21)
        Me.ButtonRepeat1.Style = OmegaMusic.ButtonRepeat.StyleButton.Style1
        Me.ButtonRepeat1.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(592, 278)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MUSIC2008"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents ButtonClose1 As OmegaMusic.ButtonClose
    Friend WithEvents ButtonMaximize1 As OmegaMusic.ButtonMaximize
    Friend WithEvents ButtonMinimize1 As OmegaMusic.ButtonMinimize
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonPrevious1 As OmegaMusic.ButtonPrevious
    Friend WithEvents ButtonRepeat1 As OmegaMusic.ButtonRepeat
    Friend WithEvents ButtonShuffle1 As OmegaMusic.ButtonShuffle
    Friend WithEvents ButtonStop1 As OmegaMusic.ButtonStop
    Friend WithEvents ButtonSwitch1 As OmegaMusic.ButtonSwitch
    Friend WithEvents ButtonView1 As OmegaMusic.ButtonView
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonNext1 As OmegaMusic.ButtonNext
    Friend WithEvents ButtonNoSound1 As OmegaMusic.ButtonNoSound
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenUrlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaypauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlideSeek1 As OmegaMusic.SlideSeek
    Friend WithEvents SlideSeek2 As OmegaMusic.SlideSeek
    Friend WithEvents ButtonPlayPause2 As OmegaMusic.ButtonPlayPause
End Class
