<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmULSupplier
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmULSupplier))
        Me.txtBusiness = New OmegaSkins.TextBoxPNA
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.txtDescrible = New OmegaSkins.TextBoxPNA
        Me.lblDescrible = New System.Windows.Forms.Label
        Me.txtIDSupplier = New OmegaSkins.TextBoxPNA
        Me.txtWeb = New OmegaSkins.TextBoxStyle1PNA
        Me.txtEmail = New OmegaSkins.TextBoxStyle1PNA
        Me.txtFax = New OmegaSkins.TextBoxStyle1PNA
        Me.txtPhone = New OmegaSkins.TextBoxStyle1PNA
        Me.grdSupplier = New System.Windows.Forms.DataGridView
        Me.rdoAddress = New OmegaSkins1.RadioButtonPNA1
        Me.txtAddress = New OmegaSkins.TextBoxPNA
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblWeb = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblIDSupplier = New System.Windows.Forms.Label
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.rdoSName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDSupplier = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.lblSName = New System.Windows.Forms.Label
        Me.txtSName = New OmegaSkins.TextBoxPNA
        Me.lblList = New System.Windows.Forms.Label
        Me.lblBusiness = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tbrHRCountry = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.grdSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCountry.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBusiness
        '
        Me.txtBusiness.BackColor = System.Drawing.Color.ForestGreen
        Me.txtBusiness.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtBusiness.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusiness.Location = New System.Drawing.Point(137, 113)
        Me.txtBusiness.MaxLength = 150
        Me.txtBusiness.Multiline = False
        Me.txtBusiness.Name = "txtBusiness"
        Me.txtBusiness.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBusiness.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBusiness.Size = New System.Drawing.Size(603, 20)
        Me.txtBusiness.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtBusiness.TabIndex = 14
        Me.txtBusiness.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtBusiness.THeight = 20
        Me.txtBusiness.TReadOnly = True
        Me.txtBusiness.TText = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(653, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(-5, 290)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(1177, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 68
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(-8, 251)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(1177, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 67
        '
        'txtDescrible
        '
        Me.txtDescrible.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDescrible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrible.Location = New System.Drawing.Point(137, 61)
        Me.txtDescrible.MaxLength = 32767
        Me.txtDescrible.Multiline = True
        Me.txtDescrible.Name = "txtDescrible"
        Me.txtDescrible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrible.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescrible.Size = New System.Drawing.Size(603, 49)
        Me.txtDescrible.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDescrible.TabIndex = 13
        Me.txtDescrible.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDescrible.THeight = 49
        Me.txtDescrible.TReadOnly = True
        Me.txtDescrible.TText = ""
        '
        'lblDescrible
        '
        Me.lblDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDescrible.Location = New System.Drawing.Point(15, 61)
        Me.lblDescrible.Name = "lblDescrible"
        Me.lblDescrible.Size = New System.Drawing.Size(122, 20)
        Me.lblDescrible.TabIndex = 2
        Me.lblDescrible.Text = "Ghi chú"
        '
        'txtIDSupplier
        '
        Me.txtIDSupplier.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDSupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSupplier.Location = New System.Drawing.Point(137, 15)
        Me.txtIDSupplier.MaxLength = 10
        Me.txtIDSupplier.Multiline = False
        Me.txtIDSupplier.Name = "txtIDSupplier"
        Me.txtIDSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDSupplier.Size = New System.Drawing.Size(170, 20)
        Me.txtIDSupplier.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDSupplier.TabIndex = 11
        Me.txtIDSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDSupplier.THeight = 20
        Me.txtIDSupplier.TReadOnly = True
        Me.txtIDSupplier.TText = ""
        '
        'txtWeb
        '
        Me.txtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWeb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeb.Image1 = Nothing
        Me.txtWeb.Image2 = Nothing
        Me.txtWeb.Image3 = Nothing
        Me.txtWeb.Location = New System.Drawing.Point(137, 202)
        Me.txtWeb.MaxLength = 33
        Me.txtWeb.Multiline = False
        Me.txtWeb.Name = "txtWeb"
        Me.txtWeb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWeb.Size = New System.Drawing.Size(191, 19)
        Me.txtWeb.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtWeb.TabIndex = 18
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
        Me.txtEmail.Location = New System.Drawing.Point(137, 180)
        Me.txtEmail.MaxLength = 33
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.Size = New System.Drawing.Size(191, 19)
        Me.txtEmail.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtEmail.TabIndex = 17
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
        Me.txtFax.Location = New System.Drawing.Point(137, 158)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Multiline = False
        Me.txtFax.Name = "txtFax"
        Me.txtFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFax.Size = New System.Drawing.Size(191, 19)
        Me.txtFax.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtFax.TabIndex = 16
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
        Me.txtPhone.Location = New System.Drawing.Point(137, 136)
        Me.txtPhone.MaxLength = 20
        Me.txtPhone.Multiline = False
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhone.Size = New System.Drawing.Size(191, 19)
        Me.txtPhone.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtPhone.TabIndex = 15
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
        'grdSupplier
        '
        Me.grdSupplier.AllowUserToAddRows = False
        Me.grdSupplier.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSupplier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdSupplier.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdSupplier.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSupplier.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdSupplier.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdSupplier.Location = New System.Drawing.Point(18, 57)
        Me.grdSupplier.Name = "grdSupplier"
        Me.grdSupplier.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdSupplier.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdSupplier.RowHeadersWidth = 24
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdSupplier.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.grdSupplier.Size = New System.Drawing.Size(722, 203)
        Me.grdSupplier.TabIndex = 29
        '
        'rdoAddress
        '
        Me.rdoAddress.AutoSize = True
        Me.rdoAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoAddress.Location = New System.Drawing.Point(389, 34)
        Me.rdoAddress.Name = "rdoAddress"
        Me.rdoAddress.Size = New System.Drawing.Size(63, 19)
        Me.rdoAddress.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoAddress.TabIndex = 28
        Me.rdoAddress.Text = "Địa chỉ"
        Me.rdoAddress.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.ForestGreen
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(137, 224)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Multiline = False
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(603, 20)
        Me.txtAddress.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtAddress.TabIndex = 19
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddress.THeight = 20
        Me.txtAddress.TReadOnly = True
        Me.txtAddress.TText = ""
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(15, 224)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(122, 20)
        Me.lblAddress.TabIndex = 8
        Me.lblAddress.Text = "Địa chỉ"
        '
        'lblWeb
        '
        Me.lblWeb.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblWeb.Location = New System.Drawing.Point(15, 202)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(122, 20)
        Me.lblWeb.TabIndex = 7
        Me.lblWeb.Text = "Trang web"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(15, 180)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(122, 20)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Hộp thư (Email)"
        '
        'lblFax
        '
        Me.lblFax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblFax.Location = New System.Drawing.Point(15, 158)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(122, 20)
        Me.lblFax.TabIndex = 5
        Me.lblFax.Text = "Điện tín (Fax)"
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblPhone.Location = New System.Drawing.Point(15, 136)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(122, 20)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Số điện thoại"
        '
        'lblIDSupplier
        '
        Me.lblIDSupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDSupplier.Location = New System.Drawing.Point(15, 15)
        Me.lblIDSupplier.Name = "lblIDSupplier"
        Me.lblIDSupplier.Size = New System.Drawing.Size(122, 20)
        Me.lblIDSupplier.TabIndex = 0
        Me.lblIDSupplier.Text = "Mã nhà cung cấp"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(137, 10)
        Me.txtSearch.MaxLength = 200
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(514, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 24
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'rdoSName
        '
        Me.rdoSName.AutoSize = True
        Me.rdoSName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoSName.Location = New System.Drawing.Point(263, 34)
        Me.rdoSName.Name = "rdoSName"
        Me.rdoSName.Size = New System.Drawing.Size(123, 19)
        Me.rdoSName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoSName.TabIndex = 27
        Me.rdoSName.Text = "Tên nhà cung cấp"
        Me.rdoSName.UseVisualStyleBackColor = True
        '
        'rdoIDSupplier
        '
        Me.rdoIDSupplier.AutoSize = True
        Me.rdoIDSupplier.Checked = True
        Me.rdoIDSupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDSupplier.Location = New System.Drawing.Point(137, 34)
        Me.rdoIDSupplier.Name = "rdoIDSupplier"
        Me.rdoIDSupplier.Size = New System.Drawing.Size(118, 19)
        Me.rdoIDSupplier.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDSupplier.TabIndex = 26
        Me.rdoIDSupplier.TabStop = True
        Me.rdoIDSupplier.Text = "Mã nhà cung cấp"
        Me.rdoIDSupplier.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 9
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
        Me.btnSave.Location = New System.Drawing.Point(422, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 23
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
        Me.btnUpdate.Location = New System.Drawing.Point(327, 260)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 22
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
        Me.btnDelete.Location = New System.Drawing.Point(232, 260)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 21
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
        Me.btnAdd.Location = New System.Drawing.Point(137, 260)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblSName
        '
        Me.lblSName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSName.Location = New System.Drawing.Point(15, 38)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(122, 20)
        Me.lblSName.TabIndex = 1
        Me.lblSName.Text = "Tên nhà cung cấp"
        '
        'txtSName
        '
        Me.txtSName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSName.Location = New System.Drawing.Point(137, 38)
        Me.txtSName.MaxLength = 200
        Me.txtSName.Multiline = False
        Me.txtSName.Name = "txtSName"
        Me.txtSName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSName.Size = New System.Drawing.Size(603, 20)
        Me.txtSName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSName.TabIndex = 12
        Me.txtSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSName.THeight = 20
        Me.txtSName.TReadOnly = True
        Me.txtSName.TText = ""
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(9, 263)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 10
        Me.lblList.Text = "Danh sách nhà cung cấp"
        '
        'lblBusiness
        '
        Me.lblBusiness.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusiness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblBusiness.Location = New System.Drawing.Point(15, 113)
        Me.lblBusiness.Name = "lblBusiness"
        Me.lblBusiness.Size = New System.Drawing.Size(122, 20)
        Me.lblBusiness.TabIndex = 3
        Me.lblBusiness.Text = "Lĩnh vực kinh doanh"
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
        Me.tbrHRCountry.Size = New System.Drawing.Size(808, 25)
        Me.tbrHRCountry.TabIndex = 21
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
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "All extensions (*.omega)|*.omega"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All extensions (*.omega)|*.omega"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDSupplier)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBusiness)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBusiness)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtSName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblSName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDSupplier)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtWeb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFax)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblWeb)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAddress)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdSupplier)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDSupplier)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoAddress)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoSName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 297
        Me.SplitContainer1.TabIndex = 69
        '
        'frmULSupplier
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
        Me.Name = "frmULSupplier"
        Me.Text = "frmULSupplier"
        CType(Me.grdSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCountry.ResumeLayout(False)
        Me.tbrHRCountry.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbrHRCountry As System.Windows.Forms.ToolStrip
    Friend WithEvents txtDescrible As OmegaSkins.TextBoxPNA
    Friend WithEvents lblDescrible As System.Windows.Forms.Label
    Friend WithEvents txtIDSupplier As OmegaSkins.TextBoxPNA
    Friend WithEvents txtWeb As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtEmail As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtFax As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtPhone As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents grdSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents rdoAddress As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtAddress As OmegaSkins.TextBoxPNA
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblIDSupplier As System.Windows.Forms.Label
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoSName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDSupplier As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents lblSName As System.Windows.Forms.Label
    Friend WithEvents txtSName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents lblBusiness As System.Windows.Forms.Label
    Friend WithEvents txtBusiness As OmegaSkins.TextBoxPNA
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
