<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHREmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHREmployee))
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.chkFemale = New OmegaSkins1.CheckBoxPNA1
        Me.chkMale = New OmegaSkins1.CheckBoxPNA1
        Me.rdoLevelName = New OmegaSkins1.RadioButtonPNA1
        Me.lblTemResident = New System.Windows.Forms.Label
        Me.lblHireDay = New System.Windows.Forms.Label
        Me.lblLevelName = New System.Windows.Forms.Label
        Me.rdoFemale = New OmegaSkins1.RadioButtonPNA1
        Me.rdoMale = New OmegaSkins1.RadioButtonPNA1
        Me.grdEmployee = New System.Windows.Forms.DataGridView
        Me.rdoJobTitleName = New OmegaSkins1.RadioButtonPNA1
        Me.lblJobTitleName = New System.Windows.Forms.Label
        Me.rdoEName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDEmployee = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        Me.lblResident = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblMobilePhone = New System.Windows.Forms.Label
        Me.lblHomePhone = New System.Windows.Forms.Label
        Me.lblLName = New System.Windows.Forms.Label
        Me.lblIDJobTitle = New System.Windows.Forms.Label
        Me.lblEName = New System.Windows.Forms.Label
        Me.lblIDEmployee = New System.Windows.Forms.Label
        Me.lblIDLevel = New System.Windows.Forms.Label
        Me.lblBirthDay = New System.Windows.Forms.Label
        Me.tbrHRCompany = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtIDLevel = New OmegaSkins.TextBoxPNA
        Me.txtIDJobTitle = New OmegaSkins.TextBoxPNA
        Me.txtTemResident = New OmegaSkins.TextBoxPNA
        Me.txtIDEmployee = New OmegaSkins.TextBoxPNA
        Me.txtHireDay = New OmegaSkins.DateTimePNA
        Me.txtEName = New OmegaSkins.TextBoxPNA
        Me.picPicture = New OmegaSkins.PicturePNA()
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.txtBirthDay = New OmegaSkins.DateTimePNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.txtEmail = New OmegaSkins.TextBoxStyle1PNA
        Me.txtMobilePhone = New OmegaSkins.TextBoxStyle1PNA
        Me.txtLName = New OmegaSkins.TextBoxPNA
        Me.txtHomePhone = New OmegaSkins.TextBoxStyle1PNA
        Me.txtResident = New OmegaSkins.TextBoxPNA
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCompany.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(-2, 329)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 72
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(-2, 290)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 71
        '
        'chkFemale
        '
        Me.chkFemale.AutoSize = True
        Me.chkFemale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFemale.Location = New System.Drawing.Point(643, 34)
        Me.chkFemale.Name = "chkFemale"
        Me.chkFemale.Size = New System.Drawing.Size(43, 19)
        Me.chkFemale.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkFemale.TabIndex = 42
        Me.chkFemale.Text = "Nữ"
        Me.chkFemale.UseVisualStyleBackColor = True
        '
        'chkMale
        '
        Me.chkMale.AutoSize = True
        Me.chkMale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMale.Location = New System.Drawing.Point(591, 34)
        Me.chkMale.Name = "chkMale"
        Me.chkMale.Size = New System.Drawing.Size(53, 19)
        Me.chkMale.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkMale.TabIndex = 41
        Me.chkMale.Text = "Nam"
        Me.chkMale.UseVisualStyleBackColor = True
        '
        'rdoLevelName
        '
        Me.rdoLevelName.AutoSize = True
        Me.rdoLevelName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoLevelName.Location = New System.Drawing.Point(487, 34)
        Me.rdoLevelName.Name = "rdoLevelName"
        Me.rdoLevelName.Size = New System.Drawing.Size(90, 19)
        Me.rdoLevelName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoLevelName.TabIndex = 40
        Me.rdoLevelName.TabStop = True
        Me.rdoLevelName.Text = "Tên trình độ"
        Me.rdoLevelName.UseVisualStyleBackColor = True
        '
        'lblTemResident
        '
        Me.lblTemResident.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemResident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblTemResident.Location = New System.Drawing.Point(15, 240)
        Me.lblTemResident.Name = "lblTemResident"
        Me.lblTemResident.Size = New System.Drawing.Size(133, 20)
        Me.lblTemResident.TabIndex = 11
        Me.lblTemResident.Text = "Địa chỉ tạm trú"
        '
        'lblHireDay
        '
        Me.lblHireDay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHireDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblHireDay.Location = New System.Drawing.Point(15, 152)
        Me.lblHireDay.Name = "lblHireDay"
        Me.lblHireDay.Size = New System.Drawing.Size(133, 20)
        Me.lblHireDay.TabIndex = 7
        Me.lblHireDay.Text = "Ngày nhận việc"
        '
        'lblLevelName
        '
        Me.lblLevelName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblLevelName.Location = New System.Drawing.Point(326, 38)
        Me.lblLevelName.Name = "lblLevelName"
        Me.lblLevelName.Size = New System.Drawing.Size(391, 20)
        Me.lblLevelName.TabIndex = 70
        Me.lblLevelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoFemale.Location = New System.Drawing.Point(419, 108)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(42, 19)
        Me.rdoFemale.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoFemale.TabIndex = 21
        Me.rdoFemale.Text = "Nữ"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Checked = True
        Me.rdoMale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoMale.Location = New System.Drawing.Point(349, 108)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(52, 19)
        Me.rdoMale.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoMale.TabIndex = 20
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Nam"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'grdEmployee
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdEmployee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEmployee.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdEmployee.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdEmployee.Location = New System.Drawing.Point(18, 59)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.Size = New System.Drawing.Size(727, 161)
        Me.grdEmployee.TabIndex = 43
        '
        'rdoJobTitleName
        '
        Me.rdoJobTitleName.AutoSize = True
        Me.rdoJobTitleName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJobTitleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoJobTitleName.Location = New System.Drawing.Point(385, 34)
        Me.rdoJobTitleName.Name = "rdoJobTitleName"
        Me.rdoJobTitleName.Size = New System.Drawing.Size(91, 19)
        Me.rdoJobTitleName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoJobTitleName.TabIndex = 39
        Me.rdoJobTitleName.TabStop = True
        Me.rdoJobTitleName.Text = "Tên chức vụ"
        Me.rdoJobTitleName.UseVisualStyleBackColor = True
        '
        'lblJobTitleName
        '
        Me.lblJobTitleName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobTitleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblJobTitleName.Location = New System.Drawing.Point(326, 15)
        Me.lblJobTitleName.Name = "lblJobTitleName"
        Me.lblJobTitleName.Size = New System.Drawing.Size(391, 20)
        Me.lblJobTitleName.TabIndex = 1
        Me.lblJobTitleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdoEName
        '
        Me.rdoEName.AutoSize = True
        Me.rdoEName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoEName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoEName.Location = New System.Drawing.Point(264, 34)
        Me.rdoEName.Name = "rdoEName"
        Me.rdoEName.Size = New System.Drawing.Size(102, 19)
        Me.rdoEName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoEName.TabIndex = 38
        Me.rdoEName.TabStop = True
        Me.rdoEName.Text = "Tên nhân viên"
        Me.rdoEName.UseVisualStyleBackColor = True
        '
        'rdoIDEmployee
        '
        Me.rdoIDEmployee.AutoSize = True
        Me.rdoIDEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDEmployee.Location = New System.Drawing.Point(148, 34)
        Me.rdoIDEmployee.Name = "rdoIDEmployee"
        Me.rdoIDEmployee.Size = New System.Drawing.Size(97, 19)
        Me.rdoIDEmployee.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDEmployee.TabIndex = 37
        Me.rdoIDEmployee.TabStop = True
        Me.rdoIDEmployee.Text = "Mã nhân viên"
        Me.rdoIDEmployee.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 13
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(15, 223)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 14
        Me.lblList.Text = "Danh sách nhân viên"
        '
        'lblResident
        '
        Me.lblResident.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResident.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblResident.Location = New System.Drawing.Point(15, 263)
        Me.lblResident.Name = "lblResident"
        Me.lblResident.Size = New System.Drawing.Size(133, 20)
        Me.lblResident.TabIndex = 12
        Me.lblResident.Text = "Địa chỉ cư trú"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(15, 218)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(133, 20)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Hộp thư (Email)"
        '
        'lblMobilePhone
        '
        Me.lblMobilePhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobilePhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblMobilePhone.Location = New System.Drawing.Point(15, 196)
        Me.lblMobilePhone.Name = "lblMobilePhone"
        Me.lblMobilePhone.Size = New System.Drawing.Size(133, 20)
        Me.lblMobilePhone.TabIndex = 9
        Me.lblMobilePhone.Text = "Điện thoại di động"
        '
        'lblHomePhone
        '
        Me.lblHomePhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomePhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblHomePhone.Location = New System.Drawing.Point(15, 174)
        Me.lblHomePhone.Name = "lblHomePhone"
        Me.lblHomePhone.Size = New System.Drawing.Size(133, 20)
        Me.lblHomePhone.TabIndex = 8
        Me.lblHomePhone.Text = "Điện thoại nhà"
        '
        'lblLName
        '
        Me.lblLName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblLName.Location = New System.Drawing.Point(15, 107)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(133, 20)
        Me.lblLName.TabIndex = 5
        Me.lblLName.Text = "Họ và tên lót nhân viên"
        '
        'lblIDJobTitle
        '
        Me.lblIDJobTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDJobTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDJobTitle.Location = New System.Drawing.Point(15, 15)
        Me.lblIDJobTitle.Name = "lblIDJobTitle"
        Me.lblIDJobTitle.Size = New System.Drawing.Size(133, 20)
        Me.lblIDJobTitle.TabIndex = 0
        Me.lblIDJobTitle.Text = "Chức vụ"
        '
        'lblEName
        '
        Me.lblEName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblEName.Location = New System.Drawing.Point(15, 84)
        Me.lblEName.Name = "lblEName"
        Me.lblEName.Size = New System.Drawing.Size(133, 20)
        Me.lblEName.TabIndex = 4
        Me.lblEName.Text = "Tên nhân viên"
        '
        'lblIDEmployee
        '
        Me.lblIDEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDEmployee.Location = New System.Drawing.Point(15, 61)
        Me.lblIDEmployee.Name = "lblIDEmployee"
        Me.lblIDEmployee.Size = New System.Drawing.Size(133, 20)
        Me.lblIDEmployee.TabIndex = 3
        Me.lblIDEmployee.Text = "Mã nhân viên"
        '
        'lblIDLevel
        '
        Me.lblIDLevel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDLevel.Location = New System.Drawing.Point(15, 38)
        Me.lblIDLevel.Name = "lblIDLevel"
        Me.lblIDLevel.Size = New System.Drawing.Size(133, 20)
        Me.lblIDLevel.TabIndex = 2
        Me.lblIDLevel.Text = "Trình độ"
        '
        'lblBirthDay
        '
        Me.lblBirthDay.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblBirthDay.Location = New System.Drawing.Point(15, 130)
        Me.lblBirthDay.Name = "lblBirthDay"
        Me.lblBirthDay.Size = New System.Drawing.Size(133, 20)
        Me.lblBirthDay.TabIndex = 6
        Me.lblBirthDay.Text = "Ngày sinh"
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
        Me.tbrHRCompany.TabIndex = 53
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDJobTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDLevel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBirthDay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDJobTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDLevel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDEmployee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHomePhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMobilePhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTemResident)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblResident)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTemResident)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDEmployee)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHireDay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHireDay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picPicture)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblLevelName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBirthDay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdoFemale)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.rdoMale)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblJobTitleName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMobilePhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtLName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtHomePhone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtResident)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkFemale)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkMale)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoEName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoLevelName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdEmployee)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoJobTitleName)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 336
        Me.SplitContainer1.TabIndex = 73
        '
        'txtIDLevel
        '
        Me.txtIDLevel.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDLevel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDLevel.Location = New System.Drawing.Point(150, 38)
        Me.txtIDLevel.MaxLength = 4
        Me.txtIDLevel.Multiline = False
        Me.txtIDLevel.Name = "txtIDLevel"
        Me.txtIDLevel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDLevel.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDLevel.Size = New System.Drawing.Size(170, 20)
        Me.txtIDLevel.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDLevel.TabIndex = 16
        Me.txtIDLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDLevel.THeight = 20
        Me.txtIDLevel.TReadOnly = True
        Me.txtIDLevel.TText = ""
        '
        'txtIDJobTitle
        '
        Me.txtIDJobTitle.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDJobTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDJobTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDJobTitle.Location = New System.Drawing.Point(150, 15)
        Me.txtIDJobTitle.MaxLength = 4
        Me.txtIDJobTitle.Multiline = False
        Me.txtIDJobTitle.Name = "txtIDJobTitle"
        Me.txtIDJobTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDJobTitle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDJobTitle.Size = New System.Drawing.Size(170, 20)
        Me.txtIDJobTitle.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDJobTitle.TabIndex = 15
        Me.txtIDJobTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDJobTitle.THeight = 20
        Me.txtIDJobTitle.TReadOnly = True
        Me.txtIDJobTitle.TText = ""
        '
        'txtTemResident
        '
        Me.txtTemResident.BackColor = System.Drawing.Color.ForestGreen
        Me.txtTemResident.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTemResident.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemResident.Location = New System.Drawing.Point(150, 240)
        Me.txtTemResident.MaxLength = 250
        Me.txtTemResident.Multiline = False
        Me.txtTemResident.Name = "txtTemResident"
        Me.txtTemResident.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTemResident.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTemResident.Size = New System.Drawing.Size(595, 20)
        Me.txtTemResident.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtTemResident.TabIndex = 28
        Me.txtTemResident.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTemResident.THeight = 20
        Me.txtTemResident.TReadOnly = True
        Me.txtTemResident.TText = ""
        '
        'txtIDEmployee
        '
        Me.txtIDEmployee.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDEmployee.Location = New System.Drawing.Point(150, 61)
        Me.txtIDEmployee.MaxLength = 20
        Me.txtIDEmployee.Multiline = False
        Me.txtIDEmployee.Name = "txtIDEmployee"
        Me.txtIDEmployee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDEmployee.Size = New System.Drawing.Size(170, 20)
        Me.txtIDEmployee.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDEmployee.TabIndex = 17
        Me.txtIDEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDEmployee.THeight = 20
        Me.txtIDEmployee.TReadOnly = False
        Me.txtIDEmployee.TText = ""
        '
        'txtHireDay
        '
        Me.txtHireDay.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtHireDay.Location = New System.Drawing.Point(150, 152)
        Me.txtHireDay.Name = "txtHireDay"
        Me.txtHireDay.SetDay = 0
        Me.txtHireDay.SetMonth = 0
        Me.txtHireDay.SetYear = 0
        Me.txtHireDay.Size = New System.Drawing.Size(191, 19)
        Me.txtHireDay.Style = OmegaSkins.DateTimePNA.StyleDateTime.Style1
        Me.txtHireDay.TabIndex = 23
        Me.txtHireDay.TReadOnly = True
        '
        'txtEName
        '
        Me.txtEName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtEName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEName.Location = New System.Drawing.Point(150, 84)
        Me.txtEName.MaxLength = 20
        Me.txtEName.Multiline = False
        Me.txtEName.Name = "txtEName"
        Me.txtEName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEName.Size = New System.Drawing.Size(170, 20)
        Me.txtEName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtEName.TabIndex = 18
        Me.txtEName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEName.THeight = 20
        Me.txtEName.TReadOnly = False
        Me.txtEName.TText = ""
        '
        'picPicture
        '
        Me.picPicture.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Image = Nothing
        Me.picPicture.Location = New System.Drawing.Point(349, 130)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(115, 107)
        Me.picPicture.Style = OmegaSkins.PicturePNA.StylePicture.Style1
        Me.picPicture.TabIndex = 27
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Info
        Me.btnAdd.BToolTip = Nothing
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAdd.Image = Global.OmegaSoft.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(150, 299)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtBirthDay
        '
        Me.txtBirthDay.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtBirthDay.Location = New System.Drawing.Point(150, 130)
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.SetDay = 0
        Me.txtBirthDay.SetMonth = 0
        Me.txtBirthDay.SetYear = 0
        Me.txtBirthDay.Size = New System.Drawing.Size(191, 19)
        Me.txtBirthDay.Style = OmegaSkins.DateTimePNA.StyleDateTime.Style1
        Me.txtBirthDay.TabIndex = 22
        Me.txtBirthDay.TReadOnly = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelete.BToolTip = Nothing
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnDelete.Image = Global.OmegaSoft.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(244, 299)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "&Xoá"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdate.BToolTip = Nothing
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnUpdate.Image = Global.OmegaSoft.My.Resources.Resources.Update1
        Me.btnUpdate.Location = New System.Drawing.Point(338, 299)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "   &Cập nhật"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Info
        Me.btnSave.BToolTip = Nothing
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSave.Image = Global.OmegaSoft.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(432, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Image1 = Nothing
        Me.txtEmail.Image2 = Nothing
        Me.txtEmail.Image3 = Nothing
        Me.txtEmail.Location = New System.Drawing.Point(150, 218)
        Me.txtEmail.MaxLength = 33
        Me.txtEmail.Multiline = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.Size = New System.Drawing.Size(191, 19)
        Me.txtEmail.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtEmail.TabIndex = 26
        Me.txtEmail.Text1 = Nothing
        Me.txtEmail.Text2 = Nothing
        Me.txtEmail.Text3 = Nothing
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtEmail.TextMenu1 = Nothing
        Me.txtEmail.TextMenu2 = Nothing
        Me.txtEmail.TextMenu3 = Nothing
        Me.txtEmail.TReadOnly = False
        Me.txtEmail.TText = ""
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMobilePhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilePhone.Image1 = Nothing
        Me.txtMobilePhone.Image2 = Nothing
        Me.txtMobilePhone.Image3 = Nothing
        Me.txtMobilePhone.Location = New System.Drawing.Point(150, 196)
        Me.txtMobilePhone.MaxLength = 20
        Me.txtMobilePhone.Multiline = False
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMobilePhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMobilePhone.Size = New System.Drawing.Size(191, 19)
        Me.txtMobilePhone.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtMobilePhone.TabIndex = 25
        Me.txtMobilePhone.Text1 = Nothing
        Me.txtMobilePhone.Text2 = Nothing
        Me.txtMobilePhone.Text3 = Nothing
        Me.txtMobilePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMobilePhone.TextMenu1 = Nothing
        Me.txtMobilePhone.TextMenu2 = Nothing
        Me.txtMobilePhone.TextMenu3 = Nothing
        Me.txtMobilePhone.TReadOnly = False
        Me.txtMobilePhone.TText = ""
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(150, 107)
        Me.txtLName.MaxLength = 40
        Me.txtLName.Multiline = False
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLName.Size = New System.Drawing.Size(170, 20)
        Me.txtLName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtLName.TabIndex = 19
        Me.txtLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLName.THeight = 20
        Me.txtLName.TReadOnly = False
        Me.txtLName.TText = ""
        '
        'txtHomePhone
        '
        Me.txtHomePhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHomePhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomePhone.Image1 = Nothing
        Me.txtHomePhone.Image2 = Nothing
        Me.txtHomePhone.Image3 = Nothing
        Me.txtHomePhone.Location = New System.Drawing.Point(150, 174)
        Me.txtHomePhone.MaxLength = 20
        Me.txtHomePhone.Multiline = False
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHomePhone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHomePhone.Size = New System.Drawing.Size(191, 19)
        Me.txtHomePhone.Style = OmegaSkins.TextBoxStyle1PNA.StyleTextBox.Style1
        Me.txtHomePhone.TabIndex = 24
        Me.txtHomePhone.Text1 = Nothing
        Me.txtHomePhone.Text2 = Nothing
        Me.txtHomePhone.Text3 = Nothing
        Me.txtHomePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtHomePhone.TextMenu1 = Nothing
        Me.txtHomePhone.TextMenu2 = Nothing
        Me.txtHomePhone.TextMenu3 = Nothing
        Me.txtHomePhone.TReadOnly = False
        Me.txtHomePhone.TText = ""
        '
        'txtResident
        '
        Me.txtResident.BackColor = System.Drawing.Color.ForestGreen
        Me.txtResident.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtResident.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResident.Location = New System.Drawing.Point(150, 263)
        Me.txtResident.MaxLength = 250
        Me.txtResident.Multiline = False
        Me.txtResident.Name = "txtResident"
        Me.txtResident.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtResident.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtResident.Size = New System.Drawing.Size(595, 20)
        Me.txtResident.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtResident.TabIndex = 30
        Me.txtResident.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtResident.THeight = 20
        Me.txtResident.TReadOnly = True
        Me.txtResident.TText = ""
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
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(150, 10)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(506, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 35
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Person2.ico")
        Me.ImageList1.Images.SetKeyName(1, "Person5.ico")
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
        'frmHREmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tbrHRCompany)
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHREmployee"
        Me.ShowInTaskbar = False
        Me.Text = "frmHREmployee"
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCompany.ResumeLayout(False)
        Me.tbrHRCompany.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEmail As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtMobilePhone As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents txtHomePhone As OmegaSkins.TextBoxStyle1PNA
    Friend WithEvents grdEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents rdoJobTitleName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtResident As OmegaSkins.TextBoxPNA
    Friend WithEvents lblResident As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblMobilePhone As System.Windows.Forms.Label
    Friend WithEvents lblHomePhone As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents txtLName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblJobTitleName As System.Windows.Forms.Label
    Friend WithEvents lblIDJobTitle As System.Windows.Forms.Label
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoEName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDEmployee As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents picPicture As OmegaSkins.PicturePNA
    Friend WithEvents txtEName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblEName As System.Windows.Forms.Label
    Friend WithEvents lblIDEmployee As System.Windows.Forms.Label
    Friend WithEvents txtIDEmployee As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDLevel As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents rdoFemale As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoMale As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtBirthDay As OmegaSkins.DateTimePNA
    Friend WithEvents lblLevelName As System.Windows.Forms.Label
    Friend WithEvents lblBirthDay As System.Windows.Forms.Label
    Friend WithEvents txtHireDay As OmegaSkins.DateTimePNA
    Friend WithEvents lblHireDay As System.Windows.Forms.Label
    Friend WithEvents txtTemResident As OmegaSkins.TextBoxPNA
    Friend WithEvents lblTemResident As System.Windows.Forms.Label
    Friend WithEvents rdoLevelName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents chkFemale As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents chkMale As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents txtIDJobTitle As OmegaSkins.TextBoxPNA
    Friend WithEvents txtIDLevel As OmegaSkins.TextBoxPNA
    Friend WithEvents tbrHRCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
