<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRCountry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRCountry))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.picPicture = New OmegaSkins.PicturePNA()
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.LinePNA12 = New OmegaSkins1.LinePNA1
        Me.LinePNA11 = New OmegaSkins1.LinePNA1
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.rdoCName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDCountry = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        Me.btnSave = New OmegaSkins.ButtonPNA
        Me.btnUpdate = New OmegaSkins.ButtonPNA
        Me.btnDelete = New OmegaSkins.ButtonPNA
        Me.btnAdd = New OmegaSkins.ButtonPNA
        Me.txtDescrible = New OmegaSkins.TextBoxPNA
        Me.lblDescrible = New System.Windows.Forms.Label
        Me.lblCName = New System.Windows.Forms.Label
        Me.txtCName = New OmegaSkins.TextBoxPNA
        Me.lblIDCountry = New System.Windows.Forms.Label
        Me.txtIDCountry = New OmegaSkins.TextBoxPNA
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.tbrHRCountry = New System.Windows.Forms.ToolStrip
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrOpen = New System.Windows.Forms.ToolStripButton
        Me.tbrExcel = New System.Windows.Forms.ToolStripButton
        Me.tbrReview = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grdCountry = New System.Windows.Forms.DataGridView
        Me.tbrHRCountry.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Image = Nothing
        Me.picPicture.Location = New System.Drawing.Point(625, 61)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(125, 111)
        Me.picPicture.Style = OmegaSkins.PicturePNA.StylePicture.Style1
        Me.picPicture.TabIndex = 8
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(663, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'LinePNA12
        '
        Me.LinePNA12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA12.ForeColor = System.Drawing.Color.White
        Me.LinePNA12.Location = New System.Drawing.Point(1, 219)
        Me.LinePNA12.Name = "LinePNA12"
        Me.LinePNA12.Size = New System.Drawing.Size(790, 4)
        Me.LinePNA12.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA12.TabIndex = 67
        '
        'LinePNA11
        '
        Me.LinePNA11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinePNA11.ForeColor = System.Drawing.Color.White
        Me.LinePNA11.Location = New System.Drawing.Point(1, 178)
        Me.LinePNA11.Name = "LinePNA11"
        Me.LinePNA11.Size = New System.Drawing.Size(790, 4)
        Me.LinePNA11.Style = OmegaSkins1.LinePNA1.Styleline.Style1
        Me.LinePNA11.TabIndex = 66
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(102, 10)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(559, 21)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 13
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 21
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'rdoCName
        '
        Me.rdoCName.AutoSize = True
        Me.rdoCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCName.Location = New System.Drawing.Point(199, 36)
        Me.rdoCName.Name = "rdoCName"
        Me.rdoCName.Size = New System.Drawing.Size(96, 19)
        Me.rdoCName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCName.TabIndex = 16
        Me.rdoCName.TabStop = True
        Me.rdoCName.Text = "Tên quốc gia"
        Me.rdoCName.UseVisualStyleBackColor = True
        '
        'rdoIDCountry
        '
        Me.rdoIDCountry.AutoSize = True
        Me.rdoIDCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDCountry.Location = New System.Drawing.Point(102, 36)
        Me.rdoIDCountry.Name = "rdoIDCountry"
        Me.rdoIDCountry.Size = New System.Drawing.Size(91, 19)
        Me.rdoIDCountry.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDCountry.TabIndex = 15
        Me.rdoIDCountry.TabStop = True
        Me.rdoIDCountry.Text = "Mã quốc gia"
        Me.rdoIDCountry.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(15, 10)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'lblList
        '
        Me.lblList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(15, 336)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 4
        Me.lblList.Text = "Danh sách quốc gia"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Info
        Me.btnSave.BToolTip = Nothing
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSave.Image = Global.OmegaSoft.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(384, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 25)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 12
        Me.btnSave.Tag = "0"
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
        Me.btnUpdate.Location = New System.Drawing.Point(290, 188)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 25)
        Me.btnUpdate.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Tag = "0"
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
        Me.btnDelete.Location = New System.Drawing.Point(196, 188)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 25)
        Me.btnDelete.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Tag = "0"
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
        Me.btnAdd.Location = New System.Drawing.Point(102, 188)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 25)
        Me.btnAdd.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Tag = "0"
        Me.btnAdd.Text = "&Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtDescrible
        '
        Me.txtDescrible.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDescrible.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrible.Location = New System.Drawing.Point(102, 61)
        Me.txtDescrible.MaxLength = 32767
        Me.txtDescrible.Multiline = True
        Me.txtDescrible.Name = "txtDescrible"
        Me.txtDescrible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescrible.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescrible.Size = New System.Drawing.Size(517, 111)
        Me.txtDescrible.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDescrible.TabIndex = 7
        Me.txtDescrible.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDescrible.THeight = 111
        Me.txtDescrible.TReadOnly = True
        Me.txtDescrible.TText = ""
        '
        'lblDescrible
        '
        Me.lblDescrible.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrible.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblDescrible.Location = New System.Drawing.Point(15, 61)
        Me.lblDescrible.Name = "lblDescrible"
        Me.lblDescrible.Size = New System.Drawing.Size(82, 20)
        Me.lblDescrible.TabIndex = 2
        Me.lblDescrible.Text = "Ghi chú"
        '
        'lblCName
        '
        Me.lblCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblCName.Location = New System.Drawing.Point(15, 38)
        Me.lblCName.Name = "lblCName"
        Me.lblCName.Size = New System.Drawing.Size(82, 20)
        Me.lblCName.TabIndex = 1
        Me.lblCName.Text = "Tên quốc gia"
        '
        'txtCName
        '
        Me.txtCName.BackColor = System.Drawing.Color.ForestGreen
        Me.txtCName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCName.Location = New System.Drawing.Point(102, 38)
        Me.txtCName.MaxLength = 100
        Me.txtCName.Multiline = False
        Me.txtCName.Name = "txtCName"
        Me.txtCName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCName.Size = New System.Drawing.Size(648, 20)
        Me.txtCName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtCName.TabIndex = 6
        Me.txtCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCName.THeight = 20
        Me.txtCName.TReadOnly = True
        Me.txtCName.TText = ""
        '
        'lblIDCountry
        '
        Me.lblIDCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblIDCountry.Location = New System.Drawing.Point(15, 15)
        Me.lblIDCountry.Name = "lblIDCountry"
        Me.lblIDCountry.Size = New System.Drawing.Size(82, 20)
        Me.lblIDCountry.TabIndex = 0
        Me.lblIDCountry.Text = "Mã quốc gia"
        '
        'txtIDCountry
        '
        Me.txtIDCountry.BackColor = System.Drawing.Color.ForestGreen
        Me.txtIDCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCountry.Location = New System.Drawing.Point(102, 15)
        Me.txtIDCountry.MaxLength = 4
        Me.txtIDCountry.Multiline = False
        Me.txtIDCountry.Name = "txtIDCountry"
        Me.txtIDCountry.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIDCountry.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIDCountry.Size = New System.Drawing.Size(170, 20)
        Me.txtIDCountry.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtIDCountry.TabIndex = 5
        Me.txtIDCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIDCountry.THeight = 20
        Me.txtIDCountry.TReadOnly = True
        Me.txtIDCountry.TText = ""
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
        Me.tbrHRCountry.Size = New System.Drawing.Size(793, 25)
        Me.tbrHRCountry.TabIndex = 18
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIDCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picPicture)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtIDCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LinePNA11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescrible)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSave)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSearch)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoIDCountry)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rdoCName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdCountry)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblList)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 225
        Me.SplitContainer1.TabIndex = 69
        '
        'grdCountry
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCountry.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdCountry.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCountry.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCountry.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdCountry.Location = New System.Drawing.Point(18, 60)
        Me.grdCountry.Name = "grdCountry"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCountry.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdCountry.Size = New System.Drawing.Size(732, 272)
        Me.grdCountry.TabIndex = 17
        '
        'frmHRCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.tbrHRCountry)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHRCountry"
        Me.ShowInTaskbar = False
        Me.Text = "frmHRCountry"
        Me.tbrHRCountry.ResumeLayout(False)
        Me.tbrHRCountry.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbrHRCountry As System.Windows.Forms.ToolStrip
    Friend WithEvents tbrOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents btnUpdate As OmegaSkins.ButtonPNA
    Friend WithEvents btnDelete As OmegaSkins.ButtonPNA
    Friend WithEvents btnAdd As OmegaSkins.ButtonPNA
    Friend WithEvents txtDescrible As OmegaSkins.TextBoxPNA
    Friend WithEvents lblDescrible As System.Windows.Forms.Label
    Friend WithEvents lblCName As System.Windows.Forms.Label
    Friend WithEvents txtCName As OmegaSkins.TextBoxPNA
    Friend WithEvents lblIDCountry As System.Windows.Forms.Label
    Friend WithEvents txtIDCountry As OmegaSkins.TextBoxPNA
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoCName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDCountry As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents LinePNA11 As OmegaSkins1.LinePNA1
    Friend WithEvents LinePNA12 As OmegaSkins1.LinePNA1
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents tbrExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrReview As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents picPicture As OmegaSkins.PicturePNA
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grdCountry As System.Windows.Forms.DataGridView
End Class
