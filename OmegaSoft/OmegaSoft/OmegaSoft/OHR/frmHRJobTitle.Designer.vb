<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRJobTitle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRJobTitle))
        Me.txtIDDepartment = New OmegaSkins.TextBoxPNA
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.txtDescrible = New OmegaSkins.TextBoxPNA
        Me.grdJobTitle = New System.Windows.Forms.DataGridView
        Me.rdoDepartmentName = New OmegaSkins1.RadioButtonPNA1
        Me.lblDepartmentName = New System.Windows.Forms.Label
        Me.lblIDDepartment = New System.Windows.Forms.Label
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.rdoJName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDJobTitle = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.lblDescrible = New System.Windows.Forms.Label
        Me.lblJName = New System.Windows.Forms.Label
        Me.txtJName = New OmegaSkins.TextBoxPNA
        Me.lblIDJobTitle = New System.Windows.Forms.Label
        Me.txtIDJobTitle = New OmegaSkins.TextBoxPNA
        Me.lblList = New System.Windows.Forms.Label
        Me.tbrHRCompany = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.grdJobTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCompany.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIDDepartment
        '
        Me.txtIDDepartment.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDDepartment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDDepartment.Location = New System.Drawing.Point(98, 15)
        Me.txtIDDepartment.MaxLength = 4
        Me.txtIDDepartment.Multiline = False
        Me.txtIDDepartment.Name = "txtIDDepartment"
        Me.txtIDDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDDepartment.Size = New System.Drawing.Size(170, 20)
        Me.txtIDDepartment.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDDepartment.TabIndex = 7
        Me.txtIDDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDDepartment.THeight = 20
        Me.txtIDDepartment.TReadOnly = True
        Me.txtIDDepartment.TText = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(657, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(1, 244)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(965, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 68
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(1, 204)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(965, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 67
        '
        'txtDescrible
        '
        Me.txtDescrible.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDescrible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrible.Location = New System.Drawing.Point(98, 84)
        Me.txtDescrible.MaxLength = 32767
        Me.txtDescrible.Multiline = True
        Me.txtDescrible.Name = "txtDescrible"
        Me.txtDescrible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrible.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescrible.Size = New System.Drawing.Size(646, 114)
        Me.txtDescrible.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDescrible.TabIndex = 10
        Me.txtDescrible.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDescrible.THeight = 114
        Me.txtDescrible.TReadOnly = True
        Me.txtDescrible.TText = ""
        '
        'grdJobTitle
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdJobTitle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdJobTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdJobTitle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdJobTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdJobTitle.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdJobTitle.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdJobTitle.Location = New System.Drawing.Point(14, 58)
        Me.grdJobTitle.Name = "grdJobTitle"
        Me.grdJobTitle.Size = New System.Drawing.Size(728, 249)
        Me.grdJobTitle.TabIndex = 20
        '
        'rdoDepartmentName
        '
        Me.rdoDepartmentName.AutoSize = True
        Me.rdoDepartmentName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDepartmentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoDepartmentName.Location = New System.Drawing.Point(324, 34)
        Me.rdoDepartmentName.Name = "rdoDepartmentName"
        Me.rdoDepartmentName.Size = New System.Drawing.Size(108, 19)
        Me.rdoDepartmentName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoDepartmentName.TabIndex = 19
        Me.rdoDepartmentName.TabStop = True
        Me.rdoDepartmentName.Text = "Tên phòng ban"
        Me.rdoDepartmentName.UseVisualStyleBackColor = True
        '
        'lblDepartmentName
        '
        Me.lblDepartmentName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDepartmentName.Location = New System.Drawing.Point(274, 15)
        Me.lblDepartmentName.Name = "lblDepartmentName"
        Me.lblDepartmentName.Size = New System.Drawing.Size(470, 20)
        Me.lblDepartmentName.TabIndex = 1
        Me.lblDepartmentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIDDepartment
        '
        Me.lblIDDepartment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDDepartment.Location = New System.Drawing.Point(15, 15)
        Me.lblIDDepartment.Name = "lblIDDepartment"
        Me.lblIDDepartment.Size = New System.Drawing.Size(82, 20)
        Me.lblIDDepartment.TabIndex = 0
        Me.lblIDDepartment.Text = "Phòng ban"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(98, 10)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(557, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 15
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'rdoJName
        '
        Me.rdoJName.AutoSize = True
        Me.rdoJName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoJName.Location = New System.Drawing.Point(210, 34)
        Me.rdoJName.Name = "rdoJName"
        Me.rdoJName.Size = New System.Drawing.Size(91, 19)
        Me.rdoJName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoJName.TabIndex = 18
        Me.rdoJName.TabStop = True
        Me.rdoJName.Text = "Tên chức vụ"
        Me.rdoJName.UseVisualStyleBackColor = True
        '
        'rdoIDJobTitle
        '
        Me.rdoIDJobTitle.AutoSize = True
        Me.rdoIDJobTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDJobTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDJobTitle.Location = New System.Drawing.Point(97, 34)
        Me.rdoIDJobTitle.Name = "rdoIDJobTitle"
        Me.rdoIDJobTitle.Size = New System.Drawing.Size(86, 19)
        Me.rdoIDJobTitle.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDJobTitle.TabIndex = 17
        Me.rdoIDJobTitle.TabStop = True
        Me.rdoIDJobTitle.Text = "Mã chức vụ"
        Me.rdoIDJobTitle.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 5
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
        Me.btnSave.Location = New System.Drawing.Point(380, 213)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 14
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
        Me.btnUpdate.Location = New System.Drawing.Point(286, 213)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 13
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
        Me.btnDelete.Location = New System.Drawing.Point(192, 213)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 12
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
        Me.btnAdd.Location = New System.Drawing.Point(98, 213)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblDescrible
        '
        Me.lblDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDescrible.Location = New System.Drawing.Point(15, 84)
        Me.lblDescrible.Name = "lblDescrible"
        Me.lblDescrible.Size = New System.Drawing.Size(82, 20)
        Me.lblDescrible.TabIndex = 4
        Me.lblDescrible.Text = "Ghi chú"
        '
        'lblJName
        '
        Me.lblJName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblJName.Location = New System.Drawing.Point(15, 61)
        Me.lblJName.Name = "lblJName"
        Me.lblJName.Size = New System.Drawing.Size(82, 20)
        Me.lblJName.TabIndex = 3
        Me.lblJName.Text = "Tên chức vụ"
        '
        'txtJName
        '
        Me.txtJName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtJName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtJName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJName.Location = New System.Drawing.Point(98, 61)
        Me.txtJName.MaxLength = 100
        Me.txtJName.Multiline = False
        Me.txtJName.Name = "txtJName"
        Me.txtJName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtJName.Size = New System.Drawing.Size(646, 20)
        Me.txtJName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtJName.TabIndex = 9
        Me.txtJName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtJName.THeight = 20
        Me.txtJName.TReadOnly = True
        Me.txtJName.TText = ""
        '
        'lblIDJobTitle
        '
        Me.lblIDJobTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDJobTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDJobTitle.Location = New System.Drawing.Point(15, 38)
        Me.lblIDJobTitle.Name = "lblIDJobTitle"
        Me.lblIDJobTitle.Size = New System.Drawing.Size(82, 20)
        Me.lblIDJobTitle.TabIndex = 2
        Me.lblIDJobTitle.Text = "Mã chức vụ"
        '
        'txtIDJobTitle
        '
        Me.txtIDJobTitle.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDJobTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDJobTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDJobTitle.Location = New System.Drawing.Point(98, 38)
        Me.txtIDJobTitle.MaxLength = 4
        Me.txtIDJobTitle.Multiline = False
        Me.txtIDJobTitle.Name = "txtIDJobTitle"
        Me.txtIDJobTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDJobTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDJobTitle.Size = New System.Drawing.Size(170, 20)
        Me.txtIDJobTitle.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDJobTitle.TabIndex = 8
        Me.txtIDJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDJobTitle.THeight = 20
        Me.txtIDJobTitle.TReadOnly = True
        Me.txtIDJobTitle.TText = ""
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(11, 310)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 6
        Me.lblList.Text = "Danh sách chức vụ"
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
        Me.tbrHRCompany.TabIndex = 52
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDDepartment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDDepartment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDJobTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDJobTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtJName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblJName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDepartmentName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdJobTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoDepartmentName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDJobTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoJName)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 69
        '
        'frmHRJobTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tbrHRCompany)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHRJobTitle"
        Me.Text = "frmHRJobTitle"
        CType(Me.grdJobTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCompany.ResumeLayout(False)
        Me.tbrHRCompany.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescrible As OmegaSkins.TextBoxPNA
    Friend WithEvents grdJobTitle As System.Windows.Forms.DataGridView
    Friend WithEvents rdoDepartmentName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblDepartmentName As System.Windows.Forms.Label
    Friend WithEvents lblIDDepartment As System.Windows.Forms.Label
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoJName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDJobTitle As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents lblDescrible As System.Windows.Forms.Label
    Friend WithEvents lblJName As System.Windows.Forms.Label
    Friend WithEvents txtJName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDJobTitle As System.Windows.Forms.Label
    Friend WithEvents txtIDJobTitle As OmegaSkins.TextBoxPNA
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents txtIDDepartment As OmegaSkins.TextBoxPNA
    Friend WithEvents tbrHRCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
