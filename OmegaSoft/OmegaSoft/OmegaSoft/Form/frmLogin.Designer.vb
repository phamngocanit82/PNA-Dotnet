<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.AxAgent1 = New AxAgentObjects.AxAgent
        Me.tmrLogin = New System.Windows.Forms.Timer(Me.components)
        Me.tmrAgent = New System.Windows.Forms.Timer(Me.components)
        Me.chkRemember = New OmegaSkins1.CheckBoxPNA1
        Me.btnExit = New OmegaSkins.ButtonPNA
        Me.btnLogin = New OmegaSkins.ButtonPNA
        Me.txtPassword = New OmegaSkins.TextBoxPNA
        Me.txtUserName = New OmegaSkins.TextBoxPNA
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 23)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(182, 143)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(90, 15)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "&Tên đăng nhập"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(182, 170)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 15)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "&Mật khẩu"
        '
        'AxAgent1
        '
        Me.AxAgent1.Enabled = True
        Me.AxAgent1.Location = New System.Drawing.Point(0, 0)
        Me.AxAgent1.Name = "AxAgent1"
        Me.AxAgent1.OcxState = CType(resources.GetObject("AxAgent1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAgent1.Size = New System.Drawing.Size(32, 32)
        Me.AxAgent1.TabIndex = 7
        '
        'tmrLogin
        '
        Me.tmrLogin.Enabled = True
        Me.tmrLogin.Interval = 6000
        '
        'tmrAgent
        '
        Me.tmrAgent.Enabled = True
        Me.tmrAgent.Interval = 30000
        '
        'chkRemember
        '
        Me.chkRemember.AutoSize = True
        Me.chkRemember.BackColor = System.Drawing.Color.Transparent
        Me.chkRemember.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRemember.Location = New System.Drawing.Point(273, 198)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Size = New System.Drawing.Size(152, 19)
        Me.chkRemember.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkRemember.TabIndex = 4
        Me.chkRemember.Text = "&Ghi nhớ tên đăng nhập"
        Me.chkRemember.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Info
        Me.btnExit.BToolTip = Nothing
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(348, 224)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 24)
        Me.btnExit.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Thoát"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.Info
        Me.btnLogin.BToolTip = Nothing
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(273, 224)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 24)
        Me.btnLogin.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "&Đăng nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.ForestGreen
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(273, 170)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.Size = New System.Drawing.Size(149, 20)
        Me.txtPassword.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.THeight = 20
        Me.txtPassword.TReadOnly = False
        Me.txtPassword.TText = ""
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(273, 143)
        Me.txtUserName.MaxLength = 20
        Me.txtUserName.Multiline = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUserName.Size = New System.Drawing.Size(149, 20)
        Me.txtUserName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtUserName.TabIndex = 2
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserName.THeight = 20
        Me.txtUserName.TReadOnly = False
        Me.txtUserName.TText = ""
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.AxAgent1)
        Me.Controls.Add(Me.chkRemember)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.AxAgent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtUserName As OmegaSkins.TextBoxPNA
    Friend WithEvents txtPassword As OmegaSkins.TextBoxPNA
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnLogin As OmegaSkins.ButtonPNA
    Friend WithEvents btnExit As OmegaSkins.ButtonPNA
    Friend WithEvents chkRemember As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents AxAgent1 As AxAgentObjects.AxAgent
    Friend WithEvents tmrLogin As System.Windows.Forms.Timer
    Friend WithEvents tmrAgent As System.Windows.Forms.Timer
End Class
