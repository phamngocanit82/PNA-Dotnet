<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmULProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmULProject))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tbrHRCompany = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblInvestment = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.chkComplete = New OmegaSkins1.CheckBoxPNA1
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.lblIDProject = New System.Windows.Forms.Label
        Me.lblPName = New System.Windows.Forms.Label
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.lblDescrible = New System.Windows.Forms.Label
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblFinishDate = New System.Windows.Forms.Label
        Me.lblCompanyName = New System.Windows.Forms.Label
        Me.lblJobTitleName = New System.Windows.Forms.Label
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        Me.rdoIDProject = New OmegaSkins1.RadioButtonPNA1
        Me.rdoPName = New OmegaSkins1.RadioButtonPNA1
        Me.grdProject = New System.Windows.Forms.DataGridView
        Me.rdoCompanyName = New OmegaSkins1.RadioButtonPNA1
        Me.txtTotal = New OmegaSkins.NumericPNA
        Me.txtVariation = New OmegaSkins.NumericPNA
        Me.txtInvestment = New OmegaSkins.TextBoxPNA
        Me.cboCompany = New OmegaSkins.ComboBoxPNA
        Me.txtIDProject = New OmegaSkins.TextBoxPNA
        Me.txtAddress = New OmegaSkins.TextBoxPNA
        Me.txtPName = New OmegaSkins.TextBoxPNA
        Me.txtFinishDate = New OmegaSkins.DateTimePNA
        Me.txtDescrible = New OmegaSkins.TextBoxPNA
        Me.picPicture = New OmegaSkins.PicturePNA()
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.txtStartDate = New OmegaSkins.DateTimePNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.ComboBoxPNA1 = New OmegaSkins.ComboBoxPNA
        Me.ComboBoxPNA2 = New OmegaSkins.ComboBoxPNA
        Me.tbrHRCompany.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.tbrHRCompany.Size = New System.Drawing.Size(829, 25)
        Me.tbrHRCompany.TabIndex = 54
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxPNA2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxPNA1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTotal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtVariation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtInvestment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblInvestment)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCompany)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDProject)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkComplete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblStartDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDProject)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTotal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAddress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFinishDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblFinishDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picPicture)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCompanyName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtStartDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblJobTitleName)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDProject)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoPName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdProject)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoCompanyName)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 349
        Me.SplitContainer1.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Số tiền phát sinh"
        '
        'lblInvestment
        '
        Me.lblInvestment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblInvestment.Location = New System.Drawing.Point(15, 144)
        Me.lblInvestment.Name = "lblInvestment"
        Me.lblInvestment.Size = New System.Drawing.Size(133, 20)
        Me.lblInvestment.TabIndex = 5
        Me.lblInvestment.Text = "Người đầu tư"
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCompany.Location = New System.Drawing.Point(15, 15)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(133, 20)
        Me.lblCompany.TabIndex = 0
        Me.lblCompany.Text = "Công ty"
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComplete.Location = New System.Drawing.Point(150, 282)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(90, 19)
        Me.chkComplete.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkComplete.TabIndex = 24
        Me.chkComplete.Text = "Hoàn thành"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'lblStartDate
        '
        Me.lblStartDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblStartDate.Location = New System.Drawing.Point(15, 190)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(133, 20)
        Me.lblStartDate.TabIndex = 7
        Me.lblStartDate.Text = "Ngày bắt đầu"
        '
        'lblIDProject
        '
        Me.lblIDProject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDProject.Location = New System.Drawing.Point(15, 40)
        Me.lblIDProject.Name = "lblIDProject"
        Me.lblIDProject.Size = New System.Drawing.Size(133, 20)
        Me.lblIDProject.TabIndex = 2
        Me.lblIDProject.Text = "Mã công trình"
        '
        'lblPName
        '
        Me.lblPName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblPName.Location = New System.Drawing.Point(15, 63)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(133, 20)
        Me.lblPName.TabIndex = 3
        Me.lblPName.Text = "Tên công trình"
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(-2, 342)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 72
        '
        'lblDescrible
        '
        Me.lblDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDescrible.Location = New System.Drawing.Point(15, 86)
        Me.lblDescrible.Name = "lblDescrible"
        Me.lblDescrible.Size = New System.Drawing.Size(133, 20)
        Me.lblDescrible.TabIndex = 4
        Me.lblDescrible.Text = "Ghi chú"
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(-2, 303)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(802, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 71
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(15, 234)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 20)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "Số tiền"
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(15, 167)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(133, 20)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Địa chỉ"
        '
        'lblFinishDate
        '
        Me.lblFinishDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblFinishDate.Location = New System.Drawing.Point(15, 212)
        Me.lblFinishDate.Name = "lblFinishDate"
        Me.lblFinishDate.Size = New System.Drawing.Size(133, 20)
        Me.lblFinishDate.TabIndex = 8
        Me.lblFinishDate.Text = "Ngày hoàn thành"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCompanyName.Location = New System.Drawing.Point(326, 15)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(391, 20)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 11
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(15, 210)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 12
        Me.lblList.Text = "Danh sách công trình"
        '
        'rdoIDProject
        '
        Me.rdoIDProject.AutoSize = True
        Me.rdoIDProject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDProject.Location = New System.Drawing.Point(148, 34)
        Me.rdoIDProject.Name = "rdoIDProject"
        Me.rdoIDProject.Size = New System.Drawing.Size(98, 19)
        Me.rdoIDProject.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDProject.TabIndex = 31
        Me.rdoIDProject.TabStop = True
        Me.rdoIDProject.Text = "Mã công trình"
        Me.rdoIDProject.UseVisualStyleBackColor = True
        '
        'rdoPName
        '
        Me.rdoPName.AutoSize = True
        Me.rdoPName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoPName.Location = New System.Drawing.Point(264, 34)
        Me.rdoPName.Name = "rdoPName"
        Me.rdoPName.Size = New System.Drawing.Size(103, 19)
        Me.rdoPName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoPName.TabIndex = 32
        Me.rdoPName.TabStop = True
        Me.rdoPName.Text = "Tên công trình"
        Me.rdoPName.UseVisualStyleBackColor = True
        '
        'grdProject
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdProject.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdProject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdProject.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdProject.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdProject.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdProject.Location = New System.Drawing.Point(18, 59)
        Me.grdProject.Name = "grdProject"
        Me.grdProject.Size = New System.Drawing.Size(727, 148)
        Me.grdProject.TabIndex = 34
        '
        'rdoCompanyName
        '
        Me.rdoCompanyName.AutoSize = True
        Me.rdoCompanyName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCompanyName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCompanyName.Location = New System.Drawing.Point(385, 34)
        Me.rdoCompanyName.Name = "rdoCompanyName"
        Me.rdoCompanyName.Size = New System.Drawing.Size(87, 19)
        Me.rdoCompanyName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCompanyName.TabIndex = 33
        Me.rdoCompanyName.TabStop = True
        Me.rdoCompanyName.Text = "Tên công ty"
        Me.rdoCompanyName.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.ForestGreen
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(150, 234)
        Me.txtTotal.MaxLength = 25
        Me.txtTotal.Multiline = False
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.Size = New System.Drawing.Size(142, 20)
        Me.txtTotal.StrFormat = "###,###,###,###,###,###.00"
        Me.txtTotal.Style = OmegaSkins.NumericPNA.StyleTextBox.Style1
        Me.txtTotal.TabIndex = 21
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.TReadOnly = False
        Me.txtTotal.Value = 0
        '
        'txtVariation
        '
        Me.txtVariation.BackColor = System.Drawing.Color.ForestGreen
        Me.txtVariation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVariation.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVariation.Location = New System.Drawing.Point(150, 257)
        Me.txtVariation.MaxLength = 25
        Me.txtVariation.Multiline = False
        Me.txtVariation.Name = "txtVariation"
        Me.txtVariation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVariation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtVariation.Size = New System.Drawing.Size(142, 20)
        Me.txtVariation.StrFormat = "###,###,###,###,###,###.00"
        Me.txtVariation.Style = OmegaSkins.NumericPNA.StyleTextBox.Style1
        Me.txtVariation.TabIndex = 22
        Me.txtVariation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVariation.TReadOnly = False
        Me.txtVariation.Value = 0
        '
        'txtInvestment
        '
        Me.txtInvestment.BackColor = System.Drawing.Color.ForestGreen
        Me.txtInvestment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtInvestment.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvestment.Location = New System.Drawing.Point(150, 144)
        Me.txtInvestment.MaxLength = 250
        Me.txtInvestment.Multiline = False
        Me.txtInvestment.Name = "txtInvestment"
        Me.txtInvestment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInvestment.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInvestment.Size = New System.Drawing.Size(595, 20)
        Me.txtInvestment.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtInvestment.TabIndex = 17
        Me.txtInvestment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtInvestment.THeight = 20
        Me.txtInvestment.TReadOnly = True
        Me.txtInvestment.TText = ""
        '
        'cboCompany
        '
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(150, 15)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(170, 22)
        Me.cboCompany.Style = OmegaSkins.ComboBoxPNA.StyleComboBox.Style1
        Me.cboCompany.TabIndex = 13
        '
        'txtIDProject
        '
        Me.txtIDProject.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDProject.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDProject.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDProject.Location = New System.Drawing.Point(150, 40)
        Me.txtIDProject.MaxLength = 4
        Me.txtIDProject.Multiline = False
        Me.txtIDProject.Name = "txtIDProject"
        Me.txtIDProject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDProject.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDProject.Size = New System.Drawing.Size(170, 20)
        Me.txtIDProject.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDProject.TabIndex = 14
        Me.txtIDProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDProject.THeight = 20
        Me.txtIDProject.TReadOnly = True
        Me.txtIDProject.TText = ""
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.ForestGreen
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(150, 167)
        Me.txtAddress.MaxLength = 250
        Me.txtAddress.Multiline = False
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(595, 20)
        Me.txtAddress.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtAddress.TabIndex = 18
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAddress.THeight = 20
        Me.txtAddress.TReadOnly = True
        Me.txtAddress.TText = ""
        '
        'txtPName
        '
        Me.txtPName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtPName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPName.Location = New System.Drawing.Point(150, 63)
        Me.txtPName.MaxLength = 20
        Me.txtPName.Multiline = False
        Me.txtPName.Name = "txtPName"
        Me.txtPName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPName.Size = New System.Drawing.Size(595, 20)
        Me.txtPName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtPName.TabIndex = 15
        Me.txtPName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPName.THeight = 20
        Me.txtPName.TReadOnly = False
        Me.txtPName.TText = ""
        '
        'txtFinishDate
        '
        Me.txtFinishDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtFinishDate.Location = New System.Drawing.Point(150, 212)
        Me.txtFinishDate.Name = "txtFinishDate"
        Me.txtFinishDate.SetDay = 0
        Me.txtFinishDate.SetMonth = 0
        Me.txtFinishDate.SetYear = 0
        Me.txtFinishDate.Size = New System.Drawing.Size(191, 19)
        Me.txtFinishDate.Style = OmegaSkins.DateTimePNA.StyleDateTime.Style1
        Me.txtFinishDate.TabIndex = 20
        Me.txtFinishDate.TReadOnly = True
        '
        'txtDescrible
        '
        Me.txtDescrible.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDescrible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrible.Location = New System.Drawing.Point(150, 86)
        Me.txtDescrible.MaxLength = 32767
        Me.txtDescrible.Multiline = True
        Me.txtDescrible.Name = "txtDescrible"
        Me.txtDescrible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrible.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescrible.Size = New System.Drawing.Size(595, 55)
        Me.txtDescrible.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDescrible.TabIndex = 16
        Me.txtDescrible.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDescrible.THeight = 55
        Me.txtDescrible.TReadOnly = False
        Me.txtDescrible.TText = ""
        '
        'picPicture
        '
        Me.picPicture.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Image = Nothing
        Me.picPicture.Location = New System.Drawing.Point(346, 190)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(121, 87)
        Me.picPicture.Style = OmegaSkins.PicturePNA.StylePicture.Style1
        Me.picPicture.TabIndex = 23
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Info
        Me.btnAdd.BToolTip = Nothing
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnAdd.Image = Global.OmegaSoft.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(150, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtStartDate
        '
        Me.txtStartDate.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txtStartDate.Location = New System.Drawing.Point(150, 190)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.SetDay = 0
        Me.txtStartDate.SetMonth = 0
        Me.txtStartDate.SetYear = 0
        Me.txtStartDate.Size = New System.Drawing.Size(191, 19)
        Me.txtStartDate.Style = OmegaSkins.DateTimePNA.StyleDateTime.Style1
        Me.txtStartDate.TabIndex = 19
        Me.txtStartDate.TReadOnly = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Info
        Me.btnDelete.BToolTip = Nothing
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnDelete.Image = Global.OmegaSoft.My.Resources.Resources.delete
        Me.btnDelete.Location = New System.Drawing.Point(244, 312)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 26
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
        Me.btnUpdate.Location = New System.Drawing.Point(338, 312)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 27
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
        Me.btnSave.Location = New System.Drawing.Point(432, 312)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
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
        Me.btnSearch.TabIndex = 30
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
        Me.txtSearch.TabIndex = 29
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'ComboBoxPNA1
        '
        Me.ComboBoxPNA1.FormattingEnabled = True
        Me.ComboBoxPNA1.Location = New System.Drawing.Point(294, 232)
        Me.ComboBoxPNA1.Name = "ComboBoxPNA1"
        Me.ComboBoxPNA1.Size = New System.Drawing.Size(47, 22)
        Me.ComboBoxPNA1.Style = OmegaSkins.ComboBoxPNA.StyleComboBox.Style1
        Me.ComboBoxPNA1.TabIndex = 73
        Me.ComboBoxPNA1.Text = "USD"
        '
        'ComboBoxPNA2
        '
        Me.ComboBoxPNA2.FormattingEnabled = True
        Me.ComboBoxPNA2.Location = New System.Drawing.Point(294, 255)
        Me.ComboBoxPNA2.Name = "ComboBoxPNA2"
        Me.ComboBoxPNA2.Size = New System.Drawing.Size(47, 22)
        Me.ComboBoxPNA2.Style = OmegaSkins.ComboBoxPNA.StyleComboBox.Style1
        Me.ComboBoxPNA2.TabIndex = 74
        Me.ComboBoxPNA2.Text = "USD"
        '
        'frmULProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tbrHRCompany)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmULProject"
        Me.Text = "frmULProject"
        Me.tbrHRCompany.ResumeLayout(False)
        Me.tbrHRCompany.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbrHRCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblCompany As System.Windows.Forms.Label
    Friend WithEvents txtIDProject As OmegaSkins.TextBoxPNA
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents lblIDProject As System.Windows.Forms.Label
    Friend WithEvents lblPName As System.Windows.Forms.Label
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents lblDescrible As System.Windows.Forms.Label
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents txtAddress As OmegaSkins.TextBoxPNA
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtPName As OmegaSkins.TextBoxPNA
    Friend WithEvents txtFinishDate As OmegaSkins.DateTimePNA
    Friend WithEvents txtDescrible As OmegaSkins.TextBoxPNA
    Friend WithEvents lblFinishDate As System.Windows.Forms.Label
    Friend WithEvents picPicture As OmegaSkins.PicturePNA
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents txtStartDate As OmegaSkins.DateTimePNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents lblJobTitleName As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents rdoIDProject As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents chkComplete As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents rdoPName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents grdProject As System.Windows.Forms.DataGridView
    Friend WithEvents rdoCompanyName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents cboCompany As OmegaSkins.ComboBoxPNA
    Friend WithEvents txtInvestment As OmegaSkins.TextBoxPNA
    Friend WithEvents lblInvestment As System.Windows.Forms.Label
    Friend WithEvents txtTotal As OmegaSkins.NumericPNA
    Friend WithEvents txtVariation As OmegaSkins.NumericPNA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPNA1 As OmegaSkins.ComboBoxPNA
    Friend WithEvents ComboBoxPNA2 As OmegaSkins.ComboBoxPNA
End Class
