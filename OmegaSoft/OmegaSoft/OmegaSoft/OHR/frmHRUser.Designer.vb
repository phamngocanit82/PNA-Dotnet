<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRUser))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lblJobTitile = New System.Windows.Forms.Label
        Me.txtJobTitile = New OmegaSkins.TextBoxPNA
        Me.chkAdmin = New OmegaSkins1.CheckBoxPNA1
        Me.lblConfirmPass = New System.Windows.Forms.Label
        Me.txtConfirmPass = New OmegaSkins.TextBoxPNA
        Me.txtIDEmployee = New OmegaSkins.TextBoxPNA
        Me.lblIDEmployee = New System.Windows.Forms.Label
        Me.txtCName = New OmegaSkins.TextBoxPNA
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.lblCName = New System.Windows.Forms.Label
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.picPicture = New OmegaSkins.PicturePNA()
        Me.lblEmployeeName = New System.Windows.Forms.Label
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.lblPassword = New System.Windows.Forms.Label
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.txtPassword = New OmegaSkins.TextBoxPNA
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.lblUserName = New System.Windows.Forms.Label
        Me.txtDName = New OmegaSkins.TextBoxPNA
        Me.txtUserName = New OmegaSkins.TextBoxPNA
        Me.lblDName = New System.Windows.Forms.Label
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.grdUser = New System.Windows.Forms.DataGridView
        Me.lblList = New System.Windows.Forms.Label
        Me.lblSearch = New System.Windows.Forms.Label
        Me.rdoEmployeeName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoUserName = New OmegaSkins1.RadioButtonPNA1
        Me.tbrHRCountry = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCountry.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackgroundImage = CType(resources.GetObject("SplitContainer1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblJobTitile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtJobTitile)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkAdmin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblConfirmPass)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtConfirmPass)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDEmployee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDEmployee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picPicture)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmployeeName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPassword)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblUserName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtUserName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDName)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdUser)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoEmployeeName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoUserName)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 70
        '
        'lblJobTitile
        '
        Me.lblJobTitile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobTitile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblJobTitile.Location = New System.Drawing.Point(15, 84)
        Me.lblJobTitile.Name = "lblJobTitile"
        Me.lblJobTitile.Size = New System.Drawing.Size(110, 20)
        Me.lblJobTitile.TabIndex = 4
        Me.lblJobTitile.Text = "Chức vụ"
        '
        'txtJobTitile
        '
        Me.txtJobTitile.BackColor = System.Drawing.Color.ForestGreen
        Me.txtJobTitile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtJobTitile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobTitile.Location = New System.Drawing.Point(127, 84)
        Me.txtJobTitile.MaxLength = 20
        Me.txtJobTitile.Multiline = False
        Me.txtJobTitile.Name = "txtJobTitile"
        Me.txtJobTitile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJobTitile.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtJobTitile.Size = New System.Drawing.Size(459, 20)
        Me.txtJobTitile.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtJobTitile.TabIndex = 13
        Me.txtJobTitile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtJobTitile.THeight = 20
        Me.txtJobTitile.TReadOnly = True
        Me.txtJobTitile.TText = ""
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAdmin.Location = New System.Drawing.Point(127, 179)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Size = New System.Drawing.Size(99, 19)
        Me.chkAdmin.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkAdmin.TabIndex = 18
        Me.chkAdmin.Text = "Administrator"
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblConfirmPass.Location = New System.Drawing.Point(15, 153)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(110, 20)
        Me.lblConfirmPass.TabIndex = 7
        Me.lblConfirmPass.Text = "Nhập lại mật khẩu"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.ForestGreen
        Me.txtConfirmPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtConfirmPass.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.Location = New System.Drawing.Point(127, 153)
        Me.txtConfirmPass.MaxLength = 20
        Me.txtConfirmPass.Multiline = False
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmPass.Size = New System.Drawing.Size(459, 20)
        Me.txtConfirmPass.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtConfirmPass.TabIndex = 16
        Me.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtConfirmPass.THeight = 20
        Me.txtConfirmPass.TReadOnly = True
        Me.txtConfirmPass.TText = ""
        '
        'txtIDEmployee
        '
        Me.txtIDEmployee.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDEmployee.Location = New System.Drawing.Point(127, 15)
        Me.txtIDEmployee.MaxLength = 20
        Me.txtIDEmployee.Multiline = False
        Me.txtIDEmployee.Name = "txtIDEmployee"
        Me.txtIDEmployee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDEmployee.Size = New System.Drawing.Size(170, 20)
        Me.txtIDEmployee.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDEmployee.TabIndex = 10
        Me.txtIDEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDEmployee.THeight = 20
        Me.txtIDEmployee.TReadOnly = True
        Me.txtIDEmployee.TText = ""
        '
        'lblIDEmployee
        '
        Me.lblIDEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDEmployee.Location = New System.Drawing.Point(15, 15)
        Me.lblIDEmployee.Name = "lblIDEmployee"
        Me.lblIDEmployee.Size = New System.Drawing.Size(110, 20)
        Me.lblIDEmployee.TabIndex = 0
        Me.lblIDEmployee.Text = "Nhân viên"
        '
        'txtCName
        '
        Me.txtCName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtCName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCName.Location = New System.Drawing.Point(127, 38)
        Me.txtCName.MaxLength = 100
        Me.txtCName.Multiline = False
        Me.txtCName.Name = "txtCName"
        Me.txtCName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCName.Size = New System.Drawing.Size(459, 20)
        Me.txtCName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtCName.TabIndex = 11
        Me.txtCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCName.THeight = 20
        Me.txtCName.TReadOnly = True
        Me.txtCName.TText = ""
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(-2, 242)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 69
        '
        'lblCName
        '
        Me.lblCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCName.Location = New System.Drawing.Point(15, 37)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(110, 20)
        Me.lblCName.TabIndex = 2
        Me.lblCName.Text = "Công ty"
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(-2, 203)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 68
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Info
        Me.btnAdd.BToolTip = Nothing
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAdd.Image = Global.OmegaSoft.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(127, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'picPicture
        '
        Me.picPicture.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Image = Nothing
        Me.picPicture.Location = New System.Drawing.Point(592, 38)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(145, 135)
        Me.picPicture.Style = OmegaSkins.PicturePNA.StylePicture.Style1
        Me.picPicture.TabIndex = 17
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblEmployeeName.Location = New System.Drawing.Point(299, 16)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(391, 20)
        Me.lblEmployeeName.TabIndex = 1
        Me.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelete.BToolTip = Nothing
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnDelete.Image = Global.OmegaSoft.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(221, 212)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "&Xoá"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(15, 130)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(110, 20)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Mật khẩu"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdate.BToolTip = Nothing
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnUpdate.Image = Global.OmegaSoft.My.Resources.Resources.Update1
        Me.btnUpdate.Location = New System.Drawing.Point(315, 212)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "   &Cập nhật"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.ForestGreen
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(127, 130)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.Size = New System.Drawing.Size(459, 20)
        Me.txtPassword.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtPassword.TabIndex = 15
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPassword.THeight = 20
        Me.txtPassword.TReadOnly = True
        Me.txtPassword.TText = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Info
        Me.btnSave.BToolTip = Nothing
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSave.Image = Global.OmegaSoft.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(409, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(15, 107)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(110, 20)
        Me.lblUserName.TabIndex = 5
        Me.lblUserName.Text = "Tên đăng nhập"
        '
        'txtDName
        '
        Me.txtDName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.Location = New System.Drawing.Point(127, 61)
        Me.txtDName.MaxLength = 100
        Me.txtDName.Multiline = False
        Me.txtDName.Name = "txtDName"
        Me.txtDName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDName.Size = New System.Drawing.Size(459, 20)
        Me.txtDName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDName.TabIndex = 12
        Me.txtDName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDName.THeight = 20
        Me.txtDName.TReadOnly = True
        Me.txtDName.TText = ""
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(127, 107)
        Me.txtUserName.MaxLength = 20
        Me.txtUserName.Multiline = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUserName.Size = New System.Drawing.Size(459, 20)
        Me.txtUserName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtUserName.TabIndex = 14
        Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUserName.THeight = 20
        Me.txtUserName.TReadOnly = True
        Me.txtUserName.TText = ""
        '
        'lblDName
        '
        Me.lblDName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDName.Location = New System.Drawing.Point(15, 61)
        Me.lblDName.Name = "lblDName"
        Me.lblDName.Size = New System.Drawing.Size(110, 20)
        Me.lblDName.TabIndex = 3
        Me.lblDName.Text = "Phòng ban"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(650, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(127, 10)
        Me.txtSearch.MaxLength = 60
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(521, 21)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 23
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 21
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'grdUser
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdUser.Location = New System.Drawing.Point(18, 58)
        Me.grdUser.Name = "grdUser"
        Me.grdUser.Size = New System.Drawing.Size(719, 251)
        Me.grdUser.TabIndex = 27
        '
        'lblList
        '
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(15, 312)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 9
        Me.lblList.Text = "Danh sách người dùng"
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 8
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'rdoEmployeeName
        '
        Me.rdoEmployeeName.AutoSize = True
        Me.rdoEmployeeName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoEmployeeName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoEmployeeName.Location = New System.Drawing.Point(238, 35)
        Me.rdoEmployeeName.Name = "rdoEmployeeName"
        Me.rdoEmployeeName.Size = New System.Drawing.Size(102, 19)
        Me.rdoEmployeeName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoEmployeeName.TabIndex = 26
        Me.rdoEmployeeName.TabStop = True
        Me.rdoEmployeeName.Text = "Tên nhân viên"
        Me.rdoEmployeeName.UseVisualStyleBackColor = True
        '
        'rdoUserName
        '
        Me.rdoUserName.AutoSize = True
        Me.rdoUserName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoUserName.Location = New System.Drawing.Point(126, 35)
        Me.rdoUserName.Name = "rdoUserName"
        Me.rdoUserName.Size = New System.Drawing.Size(108, 19)
        Me.rdoUserName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoUserName.TabIndex = 25
        Me.rdoUserName.TabStop = True
        Me.rdoUserName.Text = "Tên đăng nhập"
        Me.rdoUserName.UseVisualStyleBackColor = True
        '
        'tbrHRCountry
        '
        Me.tbrHRCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrHRCountry.AutoSize = False
        Me.tbrHRCountry.BackColor = System.Drawing.SystemColors.Control
        Me.tbrHRCountry.BackgroundImage = Global.OmegaSoft.My.Resources.Resources.ChildToolbar
        Me.tbrHRCountry.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrHRCountry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrSave, Me.tbrOpen, Me.tbrExcel, Me.tbrReview, Me.tbrRefesh})
        Me.tbrHRCountry.Location = New System.Drawing.Point(0, 0)
        Me.tbrHRCountry.Name = "tbrHRCountry"
        Me.tbrHRCountry.Size = New System.Drawing.Size(829, 25)
        Me.tbrHRCountry.TabIndex = 50
        '
        'tbrSave
        '
        Me.tbrSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrSave.Image = Global.OmegaSoft.My.Resources.Resources.Save
        Me.tbrSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrSave.Name = "tbrSave"
        Me.tbrSave.Size = New System.Drawing.Size(23, 22)
        Me.tbrSave.Text = "Lưu tập tin"
        '
        'tbrOpen
        '
        Me.tbrOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrOpen.Image = Global.OmegaSoft.My.Resources.Resources.open
        Me.tbrOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrOpen.Name = "tbrOpen"
        Me.tbrOpen.Size = New System.Drawing.Size(23, 22)
        Me.tbrOpen.Text = "Mở tập tin"
        '
        'tbrExcel
        '
        Me.tbrExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrExcel.Image = CType(resources.GetObject("tbrExcel.Image"), System.Drawing.Image)
        Me.tbrExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrExcel.Name = "tbrExcel"
        Me.tbrExcel.Size = New System.Drawing.Size(23, 22)
        Me.tbrExcel.Text = "Export excel"
        '
        'tbrReview
        '
        Me.tbrReview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrReview.Image = Global.OmegaSoft.My.Resources.Resources.preview
        Me.tbrReview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrReview.Name = "tbrReview"
        Me.tbrReview.Size = New System.Drawing.Size(23, 22)
        Me.tbrReview.Text = "Hiển thị dữ liệu"
        '
        'tbrRefesh
        '
        Me.tbrRefesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRefesh.Image = Global.OmegaSoft.My.Resources.Resources.Refresh
        Me.tbrRefesh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRefesh.Name = "tbrRefesh"
        Me.tbrRefesh.Size = New System.Drawing.Size(23, 22)
        Me.tbrRefesh.Text = "Cập nhật dữ liệu"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All extensions (*.omega)|*.omega"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "All extensions (*.omega)|*.omega"
        '
        'frmHRUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tbrHRCountry)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHRUser"
        Me.ShowInTaskbar = False
        Me.Text = "frmHRUser"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCountry.ResumeLayout(False)
        Me.tbrHRCountry.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdUser As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoEmployeeName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoUserName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents picPicture As OmegaSkins.PicturePNA
    Friend WithEvents lblCName As System.Windows.Forms.Label
    Friend WithEvents txtCName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDEmployee As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As OmegaSkins.TextBoxPNA
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblDName As System.Windows.Forms.Label
    Friend WithEvents txtDName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tbrHRCountry As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtIDEmployee As OmegaSkins.TextBoxPNA
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents lblConfirmPass As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPass As OmegaSkins.TextBoxPNA
    Friend WithEvents chkAdmin As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents lblJobTitile As System.Windows.Forms.Label
    Friend WithEvents txtJobTitile As OmegaSkins.TextBoxPNA
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
