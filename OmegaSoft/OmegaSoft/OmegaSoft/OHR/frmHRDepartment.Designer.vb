<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRDepartment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.lblIDCompany = New System.Windows.Forms.Label
        Me.txtIDCompany = New OmegaSkins.TextBoxPNA
        Me.lblIDDepartment = New System.Windows.Forms.Label
        Me.lblDName = New System.Windows.Forms.Label
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.lblDescrible = New System.Windows.Forms.Label
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.txtIDDepartment = New OmegaSkins.TextBoxPNA
        Me.txtDescrible = New OmegaSkins.TextBoxPNA
        Me.txtDName = New OmegaSkins.TextBoxPNA
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.lblSearch = New System.Windows.Forms.Label
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.rdoIDDepartment = New OmegaSkins1.RadioButtonPNA1
        Me.rdoCompanyName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoDName = New OmegaSkins1.RadioButtonPNA1
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.lblList = New System.Windows.Forms.Label
        Me.grdDepartment = New System.Windows.Forms.DataGridView
        Me.tbrHRCompany = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCompany.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDDepartment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDDepartment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCompanyName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDDepartment)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoCompanyName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoDName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdDepartment)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 249
        Me.SplitContainer1.TabIndex = 69
        '
        'lblIDCompany
        '
        Me.lblIDCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDCompany.Location = New System.Drawing.Point(15, 15)
        Me.lblIDCompany.Name = "lblIDCompany"
        Me.lblIDCompany.Size = New System.Drawing.Size(103, 20)
        Me.lblIDCompany.TabIndex = 0
        Me.lblIDCompany.Text = "Công ty"
        '
        'txtIDCompany
        '
        Me.txtIDCompany.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCompany.Location = New System.Drawing.Point(119, 15)
        Me.txtIDCompany.MaxLength = 10
        Me.txtIDCompany.Multiline = False
        Me.txtIDCompany.Name = "txtIDCompany"
        Me.txtIDCompany.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDCompany.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDCompany.Size = New System.Drawing.Size(170, 20)
        Me.txtIDCompany.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDCompany.TabIndex = 7
        Me.txtIDCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDCompany.THeight = 20
        Me.txtIDCompany.TReadOnly = True
        Me.txtIDCompany.TText = ""
        '
        'lblIDDepartment
        '
        Me.lblIDDepartment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDDepartment.Location = New System.Drawing.Point(15, 38)
        Me.lblIDDepartment.Name = "lblIDDepartment"
        Me.lblIDDepartment.Size = New System.Drawing.Size(103, 20)
        Me.lblIDDepartment.TabIndex = 2
        Me.lblIDDepartment.Text = "Mã phòng ban"
        '
        'lblDName
        '
        Me.lblDName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDName.Location = New System.Drawing.Point(15, 61)
        Me.lblDName.Name = "lblDName"
        Me.lblDName.Size = New System.Drawing.Size(103, 20)
        Me.lblDName.TabIndex = 3
        Me.lblDName.Text = "Tên phòng ban"
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(-2, 242)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 68
        '
        'lblDescrible
        '
        Me.lblDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDescrible.Location = New System.Drawing.Point(15, 84)
        Me.lblDescrible.Name = "lblDescrible"
        Me.lblDescrible.Size = New System.Drawing.Size(103, 20)
        Me.lblDescrible.TabIndex = 4
        Me.lblDescrible.Text = "Ghi chú"
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(-2, 203)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 67
        '
        'txtIDDepartment
        '
        Me.txtIDDepartment.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDDepartment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDDepartment.Location = New System.Drawing.Point(119, 38)
        Me.txtIDDepartment.MaxLength = 4
        Me.txtIDDepartment.Multiline = False
        Me.txtIDDepartment.Name = "txtIDDepartment"
        Me.txtIDDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDDepartment.Size = New System.Drawing.Size(170, 20)
        Me.txtIDDepartment.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDDepartment.TabIndex = 8
        Me.txtIDDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDDepartment.THeight = 20
        Me.txtIDDepartment.TReadOnly = True
        Me.txtIDDepartment.TText = ""
        '
        'txtDescrible
        '
        Me.txtDescrible.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDescrible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrible.Location = New System.Drawing.Point(119, 84)
        Me.txtDescrible.MaxLength = 32767
        Me.txtDescrible.Multiline = True
        Me.txtDescrible.Name = "txtDescrible"
        Me.txtDescrible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrible.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescrible.Size = New System.Drawing.Size(630, 113)
        Me.txtDescrible.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDescrible.TabIndex = 10
        Me.txtDescrible.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDescrible.THeight = 113
        Me.txtDescrible.TReadOnly = True
        Me.txtDescrible.TText = ""
        '
        'txtDName
        '
        Me.txtDName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDName.Location = New System.Drawing.Point(119, 61)
        Me.txtDName.MaxLength = 100
        Me.txtDName.Multiline = False
        Me.txtDName.Name = "txtDName"
        Me.txtDName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDName.Size = New System.Drawing.Size(630, 20)
        Me.txtDName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDName.TabIndex = 9
        Me.txtDName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDName.THeight = 20
        Me.txtDName.TReadOnly = True
        Me.txtDName.TText = ""
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Info
        Me.btnAdd.BToolTip = Nothing
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAdd.Image = Global.OmegaSoft.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(119, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelete.BToolTip = Nothing
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnDelete.Image = Global.OmegaSoft.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(213, 212)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "&Xoá"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCompanyName.Location = New System.Drawing.Point(295, 15)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(454, 20)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Info
        Me.btnUpdate.BToolTip = Nothing
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnUpdate.Image = Global.OmegaSoft.My.Resources.Resources.Update1
        Me.btnUpdate.Location = New System.Drawing.Point(307, 212)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 13
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
        Me.btnSave.Location = New System.Drawing.Point(401, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(103, 20)
        Me.lblSearch.TabIndex = 5
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(662, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'rdoIDDepartment
        '
        Me.rdoIDDepartment.AutoSize = True
        Me.rdoIDDepartment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDDepartment.Location = New System.Drawing.Point(118, 34)
        Me.rdoIDDepartment.Name = "rdoIDDepartment"
        Me.rdoIDDepartment.Size = New System.Drawing.Size(103, 19)
        Me.rdoIDDepartment.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDDepartment.TabIndex = 17
        Me.rdoIDDepartment.TabStop = True
        Me.rdoIDDepartment.Text = "Mã phòng ban"
        Me.rdoIDDepartment.UseVisualStyleBackColor = True
        '
        'rdoCompanyName
        '
        Me.rdoCompanyName.AutoSize = True
        Me.rdoCompanyName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCompanyName.Location = New System.Drawing.Point(370, 34)
        Me.rdoCompanyName.Name = "rdoCompanyName"
        Me.rdoCompanyName.Size = New System.Drawing.Size(87, 19)
        Me.rdoCompanyName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCompanyName.TabIndex = 19
        Me.rdoCompanyName.TabStop = True
        Me.rdoCompanyName.Text = "Tên công ty"
        Me.rdoCompanyName.UseVisualStyleBackColor = True
        '
        'rdoDName
        '
        Me.rdoDName.AutoSize = True
        Me.rdoDName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoDName.Location = New System.Drawing.Point(243, 34)
        Me.rdoDName.Name = "rdoDName"
        Me.rdoDName.Size = New System.Drawing.Size(108, 19)
        Me.rdoDName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoDName.TabIndex = 18
        Me.rdoDName.TabStop = True
        Me.rdoDName.Text = "Tên phòng ban"
        Me.rdoDName.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(119, 10)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(541, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 15
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(15, 311)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 6
        Me.lblList.Text = "Danh sách phòng ban"
        '
        'grdDepartment
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdDepartment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDepartment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDepartment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDepartment.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdDepartment.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdDepartment.Location = New System.Drawing.Point(18, 58)
        Me.grdDepartment.Name = "grdDepartment"
        Me.grdDepartment.Size = New System.Drawing.Size(731, 250)
        Me.grdDepartment.TabIndex = 20
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
        Me.tbrHRCompany.TabIndex = 51
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
        'frmHRDepartment
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
        Me.Name = "frmHRDepartment"
        Me.ShowInTaskbar = False
        Me.Text = "frmHRDepartment"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCompany.ResumeLayout(False)
        Me.tbrHRCompany.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdDepartment As System.Windows.Forms.DataGridView
    Friend WithEvents rdoCompanyName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblIDCompany As System.Windows.Forms.Label
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoDName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDDepartment As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents lblDescrible As System.Windows.Forms.Label
    Friend WithEvents lblDName As System.Windows.Forms.Label
    Friend WithEvents txtDName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDDepartment As System.Windows.Forms.Label
    Friend WithEvents txtIDDepartment As OmegaSkins.TextBoxPNA
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents txtDescrible As OmegaSkins.TextBoxPNA
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents txtIDCompany As OmegaSkins.TextBoxPNA
    Friend WithEvents tbrHRCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
