<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRChangePass))
        Me.btnExit = New OmegaSkins.ButtonPNA
        Me.btnYes = New OmegaSkins.ButtonPNA
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New OmegaSkins.TextBoxPNA
        Me.txtUserName = New OmegaSkins.TextBoxPNA
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblConfirm = New System.Windows.Forms.Label
        Me.txtConfirm = New OmegaSkins.TextBoxPNA
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Info
        Me.btnExit.BToolTip = Nothing
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(369, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 24)
        Me.btnExit.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Thoát"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.SystemColors.Info
        Me.btnYes.BToolTip = Nothing
        Me.btnYes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.ForeColor = System.Drawing.Color.Black
        Me.btnYes.Location = New System.Drawing.Point(294, 222)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(74, 24)
        Me.btnYes.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnYes.TabIndex = 11
        Me.btnYes.Text = "&Đồng ý"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(158, 171)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 15)
        Me.lblPassword.TabIndex = 8
        Me.lblPassword.Text = "&Mật khẩu mới"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.ForestGreen
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(294, 171)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.Size = New System.Drawing.Size(149, 20)
        Me.txtPassword.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtPassword.TabIndex = 10
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
        Me.txtUserName.Location = New System.Drawing.Point(294, 147)
        Me.txtUserName.MaxLength = 20
        Me.txtUserName.Multiline = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUserName.Size = New System.Drawing.Size(149, 20)
        Me.txtUserName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtUserName.TabIndex = 9
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserName.THeight = 20
        Me.txtUserName.TReadOnly = True
        Me.txtUserName.TText = ""
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(158, 147)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(90, 15)
        Me.lblUserName.TabIndex = 7
        Me.lblUserName.Text = "&Tên đăng nhập"
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirm.ForeColor = System.Drawing.Color.White
        Me.lblConfirm.Location = New System.Drawing.Point(158, 195)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(132, 15)
        Me.lblConfirm.TabIndex = 13
        Me.lblConfirm.Text = "&Nhập lại mật khẩu mới"
        '
        'txtConfirm
        '
        Me.txtConfirm.BackColor = System.Drawing.Color.ForestGreen
        Me.txtConfirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtConfirm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(294, 195)
        Me.txtConfirm.MaxLength = 20
        Me.txtConfirm.Multiline = False
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirm.Size = New System.Drawing.Size(149, 20)
        Me.txtConfirm.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtConfirm.TabIndex = 14
        Me.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirm.THeight = 20
        Me.txtConfirm.TReadOnly = False
        Me.txtConfirm.TText = ""
        '
        'frmHRChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmHRChangePass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHRChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As OmegaSkins.ButtonPNA
    Friend WithEvents btnYes As OmegaSkins.ButtonPNA
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As OmegaSkins.TextBoxPNA
    Friend WithEvents txtUserName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As OmegaSkins.TextBoxPNA
End Class
