<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRCompany
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRCompany))
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.txtIDCountry = New OmegaSkins.TextBoxPNA
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.txtWeb = New OmegaSkins.TextBoxStyle1PNA
        Me.txtEmail = New OmegaSkins.TextBoxStyle1PNA
        Me.txtFax = New OmegaSkins.TextBoxStyle1PNA
        Me.txtPhone = New OmegaSkins.TextBoxStyle1PNA
        Me.grdCompany = New System.Windows.Forms.DataGridView
        Me.rdoHead = New OmegaSkins1.RadioButtonPNA1
        Me.rdoBranch = New OmegaSkins1.RadioButtonPNA1
        Me.txtAddress = New OmegaSkins.TextBoxPNA
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblWeb = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtBusiness = New OmegaSkins.TextBoxPNA
        Me.lblBusiness = New System.Windows.Forms.Label
        Me.lblTax = New System.Windows.Forms.Label
        Me.txtTax = New OmegaSkins.TextBoxPNA
        Me.lblIDCountry = New System.Windows.Forms.Label
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.lblSearch = New System.Windows.Forms.Label
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.picPicture = New OmegaSkins.PicturePNA()
        Me.txtDirector = New OmegaSkins.TextBoxPNA
        Me.lblDirector = New System.Windows.Forms.Label
        Me.lblCName = New System.Windows.Forms.Label
        Me.txtCName = New OmegaSkins.TextBoxPNA
        Me.lblIDCompany = New System.Windows.Forms.Label
        Me.txtIDCompany = New OmegaSkins.TextBoxPNA
        Me.lblList = New System.Windows.Forms.Label
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.rdoCountryName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoCName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDCompany = New OmegaSkins1.RadioButtonPNA1
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbrHRCompany = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lblCountryName = New System.Windows.Forms.Label
        CType(Me.grdCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCompany.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(658, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtIDCountry
        '
        Me.txtIDCountry.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCountry.Location = New System.Drawing.Point(138, 15)
        Me.txtIDCountry.MaxLength = 4
        Me.txtIDCountry.Multiline = False
        Me.txtIDCountry.Name = "txtIDCountry"
        Me.txtIDCountry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDCountry.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDCountry.Size = New System.Drawing.Size(170, 20)
        Me.txtIDCountry.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDCountry.TabIndex = 15
        Me.txtIDCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDCountry.THeight = 20
        Me.txtIDCountry.TReadOnly = True
        Me.txtIDCountry.TText = ""
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(-2, 308)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 68
        '
        'txtWeb
        '
        Me.txtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWeb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.Image1 = Nothing
        Me.txtWeb.Image2 = Nothing
        Me.txtWeb.Image3 = Nothing
        Me.txtWeb.Location = New System.Drawing.Point(138, 219)
        Me.txtWeb.MaxLength = 33
        Me.txtWeb.Multiline = False
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWeb.Size = New System.Drawing.Size(191, 19)
        Me.txtWeb.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtWeb.TabIndex = 26
        Me.txtWeb.Text1 = Nothing
        Me.txtWeb.Text2 = Nothing
        Me.txtWeb.Text3 = Nothing
        Me.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtWeb.TextMenu1 = Nothing
        Me.txtWeb.TextMenu2 = Nothing
        Me.txtWeb.TextMenu3 = Nothing
        Me.txtWeb.TReadOnly = True
        Me.txtWeb.TText = ""
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Image1 = Nothing
        Me.txtEmail.Image2 = Nothing
        Me.txtEmail.Image3 = Nothing
        Me.txtEmail.Location = New System.Drawing.Point(138, 197)
        Me.txtEmail.MaxLength = 33
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.Size = New System.Drawing.Size(191, 19)
        Me.txtEmail.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtEmail.TabIndex = 25
        Me.txtEmail.Text1 = Nothing
        Me.txtEmail.Text2 = Nothing
        Me.txtEmail.Text3 = Nothing
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmail.TextMenu1 = Nothing
        Me.txtEmail.TextMenu2 = Nothing
        Me.txtEmail.TextMenu3 = Nothing
        Me.txtEmail.TReadOnly = True
        Me.txtEmail.TText = ""
        '
        'txtFax
        '
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Image1 = Nothing
        Me.txtFax.Image2 = Nothing
        Me.txtFax.Image3 = Nothing
        Me.txtFax.Location = New System.Drawing.Point(138, 175)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Multiline = False
        Me.txtFax.Name = "txtFax"
        Me.txtFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFax.Size = New System.Drawing.Size(191, 19)
        Me.txtFax.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtFax.TabIndex = 24
        Me.txtFax.Text1 = Nothing
        Me.txtFax.Text2 = Nothing
        Me.txtFax.Text3 = Nothing
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFax.TextMenu1 = Nothing
        Me.txtFax.TextMenu2 = Nothing
        Me.txtFax.TextMenu3 = Nothing
        Me.txtFax.TReadOnly = True
        Me.txtFax.TText = ""
        '
        'txtPhone
        '
        Me.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Image1 = Nothing
        Me.txtPhone.Image2 = Nothing
        Me.txtPhone.Image3 = Nothing
        Me.txtPhone.Location = New System.Drawing.Point(138, 153)
        Me.txtPhone.MaxLength = 20
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.Size = New System.Drawing.Size(191, 19)
        Me.txtPhone.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtPhone.TabIndex = 23
        Me.txtPhone.Text1 = Nothing
        Me.txtPhone.Text2 = Nothing
        Me.txtPhone.Text3 = Nothing
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPhone.TextMenu1 = Nothing
        Me.txtPhone.TextMenu2 = Nothing
        Me.txtPhone.TextMenu3 = Nothing
        Me.txtPhone.TReadOnly = True
        Me.txtPhone.TText = ""
        '
        'grdCompany
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCompany.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdCompany.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCompany.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCompany.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdCompany.Location = New System.Drawing.Point(18, 57)
        Me.grdCompany.Name = "grdCompany"
        Me.grdCompany.Size = New System.Drawing.Size(727, 184)
        Me.grdCompany.TabIndex = 38
        '
        'rdoHead
        '
        Me.rdoHead.AutoSize = True
        Me.rdoHead.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoHead.Location = New System.Drawing.Point(427, 39)
        Me.rdoHead.Name = "rdoHead"
        Me.rdoHead.Size = New System.Drawing.Size(94, 19)
        Me.rdoHead.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoHead.TabIndex = 18
        Me.rdoHead.Text = "Trụ sở chính"
        Me.rdoHead.UseVisualStyleBackColor = True
        '
        'rdoBranch
        '
        Me.rdoBranch.AutoSize = True
        Me.rdoBranch.Checked = True
        Me.rdoBranch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoBranch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoBranch.Location = New System.Drawing.Point(334, 38)
        Me.rdoBranch.Name = "rdoBranch"
        Me.rdoBranch.Size = New System.Drawing.Size(82, 19)
        Me.rdoBranch.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoBranch.TabIndex = 17
        Me.rdoBranch.TabStop = True
        Me.rdoBranch.Text = "Chi nhánh"
        Me.rdoBranch.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.ForestGreen
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(138, 241)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Multiline = False
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(607, 20)
        Me.txtAddress.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtAddress.TabIndex = 28
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddress.THeight = 20
        Me.txtAddress.TReadOnly = True
        Me.txtAddress.TText = ""
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(15, 241)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(121, 20)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Địa chỉ"
        '
        'lblWeb
        '
        Me.lblWeb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblWeb.Location = New System.Drawing.Point(15, 219)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(121, 20)
        Me.lblWeb.TabIndex = 11
        Me.lblWeb.Text = "Trang web"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(15, 197)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(121, 20)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Hộp thư (Email)"
        '
        'lblFax
        '
        Me.lblFax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblFax.Location = New System.Drawing.Point(15, 175)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(121, 20)
        Me.lblFax.TabIndex = 9
        Me.lblFax.Text = "Điện tín (Fax)"
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(15, 153)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(121, 20)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Số điện thoại"
        '
        'txtBusiness
        '
        Me.txtBusiness.BackColor = System.Drawing.Color.ForestGreen
        Me.txtBusiness.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusiness.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusiness.Location = New System.Drawing.Point(138, 130)
        Me.txtBusiness.MaxLength = 150
        Me.txtBusiness.Multiline = False
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusiness.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBusiness.Size = New System.Drawing.Size(607, 20)
        Me.txtBusiness.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtBusiness.TabIndex = 22
        Me.txtBusiness.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBusiness.THeight = 20
        Me.txtBusiness.TReadOnly = True
        Me.txtBusiness.TText = ""
        '
        'lblBusiness
        '
        Me.lblBusiness.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusiness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblBusiness.Location = New System.Drawing.Point(15, 130)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(121, 20)
        Me.lblBusiness.TabIndex = 7
        Me.lblBusiness.Text = "Lĩnh vực kinh doanh"
        '
        'lblTax
        '
        Me.lblTax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(15, 107)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(121, 20)
        Me.lblTax.TabIndex = 6
        Me.lblTax.Text = "Mã số thuế"
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.ForestGreen
        Me.txtTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(138, 107)
        Me.txtTax.MaxLength = 20
        Me.txtTax.Multiline = False
        Me.txtTax.Name = "txtTax"
        Me.txtTax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTax.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTax.Size = New System.Drawing.Size(170, 20)
        Me.txtTax.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtTax.TabIndex = 21
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTax.THeight = 20
        Me.txtTax.TReadOnly = True
        Me.txtTax.TText = ""
        '
        'lblIDCountry
        '
        Me.lblIDCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDCountry.Location = New System.Drawing.Point(15, 15)
        Me.lblIDCountry.Name = "lblIDCountry"
        Me.lblIDCountry.Size = New System.Drawing.Size(121, 20)
        Me.lblIDCountry.TabIndex = 0
        Me.lblIDCountry.Text = "Quốc gia"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(138, 10)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(518, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 33
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(121, 20)
        Me.lblSearch.TabIndex = 13
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Info
        Me.btnSave.BToolTip = Nothing
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSave.Image = Global.OmegaSoft.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(420, 277)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 32
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdate.BToolTip = Nothing
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnUpdate.Image = Global.OmegaSoft.My.Resources.Resources.Update1
        Me.btnUpdate.Location = New System.Drawing.Point(326, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "   &Cập nhật"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelete.BToolTip = Nothing
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnDelete.Image = Global.OmegaSoft.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(232, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "&Xoá"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Info
        Me.btnAdd.BToolTip = Nothing
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAdd.Image = Global.OmegaSoft.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(138, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'picPicture
        '
        Me.picPicture.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Image = Nothing
        Me.picPicture.Location = New System.Drawing.Point(334, 153)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(97, 85)
        Me.picPicture.Style = OmegaSkins.PicturePNA.StylePicture.Style1
        Me.picPicture.TabIndex = 27
        '
        'txtDirector
        '
        Me.txtDirector.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDirector.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDirector.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirector.Location = New System.Drawing.Point(138, 84)
        Me.txtDirector.MaxLength = 50
        Me.txtDirector.Multiline = False
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDirector.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDirector.Size = New System.Drawing.Size(607, 20)
        Me.txtDirector.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDirector.TabIndex = 20
        Me.txtDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDirector.THeight = 20
        Me.txtDirector.TReadOnly = True
        Me.txtDirector.TText = ""
        '
        'lblDirector
        '
        Me.lblDirector.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDirector.Location = New System.Drawing.Point(15, 84)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(121, 20)
        Me.lblDirector.TabIndex = 5
        Me.lblDirector.Text = "Tên giám đốc"
        '
        'lblCName
        '
        Me.lblCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCName.Location = New System.Drawing.Point(15, 61)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(121, 20)
        Me.lblCName.TabIndex = 4
        Me.lblCName.Text = "Tên công ty"
        '
        'txtCName
        '
        Me.txtCName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtCName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCName.Location = New System.Drawing.Point(138, 61)
        Me.txtCName.MaxLength = 100
        Me.txtCName.Multiline = False
        Me.txtCName.Name = "txtCName"
        Me.txtCName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCName.Size = New System.Drawing.Size(607, 20)
        Me.txtCName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtCName.TabIndex = 19
        Me.txtCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCName.THeight = 20
        Me.txtCName.TReadOnly = True
        Me.txtCName.TText = ""
        '
        'lblIDCompany
        '
        Me.lblIDCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDCompany.Location = New System.Drawing.Point(15, 38)
        Me.lblIDCompany.Name = "lblIDCompany"
        Me.lblIDCompany.Size = New System.Drawing.Size(121, 20)
        Me.lblIDCompany.TabIndex = 3
        Me.lblIDCompany.Text = "Mã công ty"
        '
        'txtIDCompany
        '
        Me.txtIDCompany.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCompany.Location = New System.Drawing.Point(138, 38)
        Me.txtIDCompany.MaxLength = 10
        Me.txtIDCompany.Multiline = False
        Me.txtIDCompany.Name = "txtIDCompany"
        Me.txtIDCompany.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDCompany.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDCompany.Size = New System.Drawing.Size(170, 20)
        Me.txtIDCompany.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDCompany.TabIndex = 16
        Me.txtIDCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDCompany.THeight = 20
        Me.txtIDCompany.TReadOnly = True
        Me.txtIDCompany.TText = ""
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(15, 244)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 14
        Me.lblList.Text = "Danh sách công ty"
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(-2, 267)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 67
        '
        'rdoCountryName
        '
        Me.rdoCountryName.AutoSize = True
        Me.rdoCountryName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCountryName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCountryName.Location = New System.Drawing.Point(365, 34)
        Me.rdoCountryName.Name = "rdoCountryName"
        Me.rdoCountryName.Size = New System.Drawing.Size(96, 19)
        Me.rdoCountryName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCountryName.TabIndex = 37
        Me.rdoCountryName.Text = "Tên quốc gia"
        Me.rdoCountryName.UseVisualStyleBackColor = True
        '
        'rdoCName
        '
        Me.rdoCName.AutoSize = True
        Me.rdoCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCName.Location = New System.Drawing.Point(252, 34)
        Me.rdoCName.Name = "rdoCName"
        Me.rdoCName.Size = New System.Drawing.Size(87, 19)
        Me.rdoCName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCName.TabIndex = 36
        Me.rdoCName.Text = "Tên công ty"
        Me.rdoCName.UseVisualStyleBackColor = True
        '
        'rdoIDCompany
        '
        Me.rdoIDCompany.AutoSize = True
        Me.rdoIDCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDCompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDCompany.Location = New System.Drawing.Point(138, 34)
        Me.rdoIDCompany.Name = "rdoIDCompany"
        Me.rdoIDCompany.Size = New System.Drawing.Size(82, 19)
        Me.rdoIDCompany.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDCompany.TabIndex = 35
        Me.rdoIDCompany.Text = "Mã công ty"
        Me.rdoIDCompany.UseVisualStyleBackColor = True
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
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Person2.ico")
        Me.ImageList1.Images.SetKeyName(1, "Fax0.ico")
        Me.ImageList1.Images.SetKeyName(2, "Person5.ico")
        Me.ImageList1.Images.SetKeyName(3, "Internet0.ico")
        '
        'tbrHRCompany
        '
        Me.tbrHRCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrHRCompany.AutoSize = False
        Me.tbrHRCompany.BackColor = System.Drawing.SystemColors.Control
        Me.tbrHRCompany.BackgroundImage = Global.OmegaSoft.My.Resources.Resources.ChildToolbar
        Me.tbrHRCompany.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrHRCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrSave, Me.tbrOpen, Me.tbrExcel, Me.tbrReview, Me.tbrRefesh})
        Me.tbrHRCompany.Location = New System.Drawing.Point(0, 0)
        Me.tbrHRCompany.Name = "tbrHRCompany"
        Me.tbrHRCompany.Size = New System.Drawing.Size(793, 25)
        Me.tbrHRCompany.TabIndex = 50
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCountryName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBusiness)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtWeb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDirector)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDirector)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picPicture)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdoHead)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdoBranch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblWeb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBusiness)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPhone)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoCountryName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoCName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDCompany)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdCompany)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 316
        Me.SplitContainer1.TabIndex = 70
        '
        'lblCountryName
        '
        Me.lblCountryName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountryName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCountryName.Location = New System.Drawing.Point(312, 16)
        Me.lblCountryName.Name = "lblCountryName"
        Me.lblCountryName.Size = New System.Drawing.Size(433, 20)
        Me.lblCountryName.TabIndex = 2
        '
        'frmHRCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tbrHRCompany)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHRCompany"
        Me.ShowInTaskbar = False
        Me.Text = "frmHRCompany"
        CType(Me.grdCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCompany.ResumeLayout(False)
        Me.tbrHRCompany.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents grdCompany As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents picPicture As OmegaSkins.PicturePNA
    Friend WithEvents txtDirector As OmegaSkins.TextBoxPNA
    Friend WithEvents lblDirector As System.Windows.Forms.Label
    Friend WithEvents lblCName As System.Windows.Forms.Label
    Friend WithEvents txtCName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDCompany As System.Windows.Forms.Label
    Friend WithEvents txtIDCompany As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDCountry As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtTax As OmegaSkins.TextBoxPNA
    Friend WithEvents txtBusiness As OmegaSkins.TextBoxPNA
    Friend WithEvents lblBusiness As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtAddress As OmegaSkins.TextBoxPNA
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents rdoHead As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoBranch As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtWeb As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtEmail As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtFax As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtPhone As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents tbrHRCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents rdoCountryName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoCName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDCompany As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtIDCountry As OmegaSkins.TextBoxPNA
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblCountryName As System.Windows.Forms.Label
End Class
