<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRHospital
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRHospital))
        Me.tabFunctions = New DevExpress.XtraTab.XtraTabControl
        Me.tabInformation = New DevExpress.XtraTab.XtraTabPage
        Me.cboPopupDistrict = New DevExpress.XtraEditors.PopupContainerEdit
        Me.cboPopupCity = New DevExpress.XtraEditors.PopupContainerEdit
        Me.cboPopupCountry = New DevExpress.XtraEditors.PopupContainerEdit
        Me.lblDistrict = New DevExpress.XtraEditors.LabelControl
        Me.lblCity = New DevExpress.XtraEditors.LabelControl
        Me.lblCountry = New DevExpress.XtraEditors.LabelControl
        Me.txtWebPage = New DevExpress.XtraEditors.TextEdit
        Me.txtFaxes = New DevExpress.XtraEditors.TextEdit
        Me.lblChiefAccountant = New DevExpress.XtraEditors.LabelControl
        Me.txtChiefAccountant = New DevExpress.XtraEditors.TextEdit
        Me.lblDirectorName = New DevExpress.XtraEditors.LabelControl
        Me.txtDirectorName = New DevExpress.XtraEditors.TextEdit
        Me.lblEmail = New DevExpress.XtraEditors.LabelControl
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit
        Me.lblWebPage = New DevExpress.XtraEditors.LabelControl
        Me.lblFaxes = New DevExpress.XtraEditors.LabelControl
        Me.lblMobilePhone = New DevExpress.XtraEditors.LabelControl
        Me.lblTelephone = New DevExpress.XtraEditors.LabelControl
        Me.txtMobilePhone = New DevExpress.XtraEditors.TextEdit
        Me.txtTelephone = New DevExpress.XtraEditors.TextEdit
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit
        Me.lblAddress = New DevExpress.XtraEditors.LabelControl
        Me.btnSavePicture = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit
        Me.btnDeletePicture = New DevExpress.XtraEditors.SimpleButton
        Me.btnSelectPicture = New DevExpress.XtraEditors.SimpleButton
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtIDHospital = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.lblIDHospital = New DevExpress.XtraEditors.LabelControl
        Me.picPicture = New DevExpress.XtraEditors.PictureEdit
        Me.tabList = New DevExpress.XtraTab.XtraTabPage
        Me.gridControlTable2 = New DevExpress.XtraGrid.GridControl
        Me.gridViewtable2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cboSearch = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        CType(Me.tabFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFunctions.SuspendLayout()
        Me.tabInformation.SuspendLayout()
        CType(Me.cboPopupDistrict.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPopupCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPopupCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWebPage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaxes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChiefAccountant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirectorName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobilePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelephone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDHospital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabList.SuspendLayout()
        CType(Me.gridControlTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewtable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabFunctions
        '
        Me.tabFunctions.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.tabFunctions.Appearance.Options.UseFont = True
        Me.tabFunctions.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.tabFunctions.AppearancePage.Header.Options.UseFont = True
        Me.tabFunctions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabFunctions.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.tabFunctions.Location = New System.Drawing.Point(0, 0)
        Me.tabFunctions.Name = "tabFunctions"
        Me.tabFunctions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabFunctions.SelectedTabPage = Me.tabInformation
        Me.tabFunctions.Size = New System.Drawing.Size(792, 666)
        Me.tabFunctions.TabIndex = 12
        Me.tabFunctions.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInformation, Me.tabList})
        '
        'tabInformation
        '
        Me.tabInformation.AutoScroll = True
        Me.tabInformation.Controls.Add(Me.cboPopupDistrict)
        Me.tabInformation.Controls.Add(Me.cboPopupCity)
        Me.tabInformation.Controls.Add(Me.cboPopupCountry)
        Me.tabInformation.Controls.Add(Me.lblDistrict)
        Me.tabInformation.Controls.Add(Me.lblCity)
        Me.tabInformation.Controls.Add(Me.lblCountry)
        Me.tabInformation.Controls.Add(Me.txtWebPage)
        Me.tabInformation.Controls.Add(Me.txtFaxes)
        Me.tabInformation.Controls.Add(Me.lblChiefAccountant)
        Me.tabInformation.Controls.Add(Me.txtChiefAccountant)
        Me.tabInformation.Controls.Add(Me.lblDirectorName)
        Me.tabInformation.Controls.Add(Me.txtDirectorName)
        Me.tabInformation.Controls.Add(Me.lblEmail)
        Me.tabInformation.Controls.Add(Me.txtEmail)
        Me.tabInformation.Controls.Add(Me.lblWebPage)
        Me.tabInformation.Controls.Add(Me.lblFaxes)
        Me.tabInformation.Controls.Add(Me.lblMobilePhone)
        Me.tabInformation.Controls.Add(Me.lblTelephone)
        Me.tabInformation.Controls.Add(Me.txtMobilePhone)
        Me.tabInformation.Controls.Add(Me.txtTelephone)
        Me.tabInformation.Controls.Add(Me.txtAddress)
        Me.tabInformation.Controls.Add(Me.lblAddress)
        Me.tabInformation.Controls.Add(Me.btnSavePicture)
        Me.tabInformation.Controls.Add(Me.txtDescription)
        Me.tabInformation.Controls.Add(Me.btnDeletePicture)
        Me.tabInformation.Controls.Add(Me.btnSelectPicture)
        Me.tabInformation.Controls.Add(Me.txtName)
        Me.tabInformation.Controls.Add(Me.txtIDHospital)
        Me.tabInformation.Controls.Add(Me.lblDescription)
        Me.tabInformation.Controls.Add(Me.lblName)
        Me.tabInformation.Controls.Add(Me.lblIDHospital)
        Me.tabInformation.Controls.Add(Me.picPicture)
        Me.tabInformation.Name = "tabInformation"
        Me.tabInformation.Size = New System.Drawing.Size(783, 633)
        Me.tabInformation.Text = "Information"
        '
        'cboPopupDistrict
        '
        Me.cboPopupDistrict.EditValue = ""
        Me.cboPopupDistrict.Location = New System.Drawing.Point(125, 116)
        Me.cboPopupDistrict.Name = "cboPopupDistrict"
        Me.cboPopupDistrict.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPopupDistrict.Properties.Appearance.Options.UseFont = True
        Me.cboPopupDistrict.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPopupDistrict.Size = New System.Drawing.Size(300, 21)
        Me.cboPopupDistrict.TabIndex = 81
        '
        'cboPopupCity
        '
        Me.cboPopupCity.EditValue = ""
        Me.cboPopupCity.Location = New System.Drawing.Point(125, 92)
        Me.cboPopupCity.Name = "cboPopupCity"
        Me.cboPopupCity.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPopupCity.Properties.Appearance.Options.UseFont = True
        Me.cboPopupCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPopupCity.Size = New System.Drawing.Size(300, 21)
        Me.cboPopupCity.TabIndex = 80
        '
        'cboPopupCountry
        '
        Me.cboPopupCountry.EditValue = ""
        Me.cboPopupCountry.Location = New System.Drawing.Point(125, 68)
        Me.cboPopupCountry.Name = "cboPopupCountry"
        Me.cboPopupCountry.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPopupCountry.Properties.Appearance.Options.UseFont = True
        Me.cboPopupCountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPopupCountry.Size = New System.Drawing.Size(300, 21)
        Me.cboPopupCountry.TabIndex = 79
        '
        'lblDistrict
        '
        Me.lblDistrict.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDistrict.Appearance.Options.UseFont = True
        Me.lblDistrict.Location = New System.Drawing.Point(20, 119)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(38, 15)
        Me.lblDistrict.TabIndex = 78
        Me.lblDistrict.Text = "District"
        '
        'lblCity
        '
        Me.lblCity.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCity.Appearance.Options.UseFont = True
        Me.lblCity.Location = New System.Drawing.Point(20, 95)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(20, 15)
        Me.lblCity.TabIndex = 77
        Me.lblCity.Text = "City"
        '
        'lblCountry
        '
        Me.lblCountry.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCountry.Appearance.Options.UseFont = True
        Me.lblCountry.Location = New System.Drawing.Point(20, 71)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(42, 15)
        Me.lblCountry.TabIndex = 76
        Me.lblCountry.Text = "Country"
        '
        'txtWebPage
        '
        Me.txtWebPage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWebPage.EditValue = ""
        Me.txtWebPage.Location = New System.Drawing.Point(125, 236)
        Me.txtWebPage.Name = "txtWebPage"
        Me.txtWebPage.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtWebPage.Properties.Appearance.Options.UseFont = True
        Me.txtWebPage.Properties.MaxLength = 100
        Me.txtWebPage.Size = New System.Drawing.Size(639, 21)
        Me.txtWebPage.TabIndex = 75
        '
        'txtFaxes
        '
        Me.txtFaxes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFaxes.EditValue = ""
        Me.txtFaxes.Location = New System.Drawing.Point(125, 212)
        Me.txtFaxes.Name = "txtFaxes"
        Me.txtFaxes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtFaxes.Properties.Appearance.Options.UseFont = True
        Me.txtFaxes.Properties.MaxLength = 50
        Me.txtFaxes.Size = New System.Drawing.Size(639, 21)
        Me.txtFaxes.TabIndex = 74
        '
        'lblChiefAccountant
        '
        Me.lblChiefAccountant.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblChiefAccountant.Appearance.Options.UseFont = True
        Me.lblChiefAccountant.Location = New System.Drawing.Point(20, 311)
        Me.lblChiefAccountant.Name = "lblChiefAccountant"
        Me.lblChiefAccountant.Size = New System.Drawing.Size(91, 15)
        Me.lblChiefAccountant.TabIndex = 73
        Me.lblChiefAccountant.Text = "Chief HRountant"
        '
        'txtChiefAccountant
        '
        Me.txtChiefAccountant.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChiefAccountant.EditValue = ""
        Me.txtChiefAccountant.Location = New System.Drawing.Point(125, 308)
        Me.txtChiefAccountant.Name = "txtChiefAccountant"
        Me.txtChiefAccountant.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtChiefAccountant.Properties.Appearance.Options.UseFont = True
        Me.txtChiefAccountant.Properties.MaxLength = 100
        Me.txtChiefAccountant.Size = New System.Drawing.Size(639, 21)
        Me.txtChiefAccountant.TabIndex = 65
        '
        'lblDirectorName
        '
        Me.lblDirectorName.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDirectorName.Appearance.Options.UseFont = True
        Me.lblDirectorName.Location = New System.Drawing.Point(20, 287)
        Me.lblDirectorName.Name = "lblDirectorName"
        Me.lblDirectorName.Size = New System.Drawing.Size(43, 15)
        Me.lblDirectorName.TabIndex = 72
        Me.lblDirectorName.Text = "Director"
        '
        'txtDirectorName
        '
        Me.txtDirectorName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirectorName.EditValue = ""
        Me.txtDirectorName.Location = New System.Drawing.Point(125, 284)
        Me.txtDirectorName.Name = "txtDirectorName"
        Me.txtDirectorName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtDirectorName.Properties.Appearance.Options.UseFont = True
        Me.txtDirectorName.Properties.MaxLength = 100
        Me.txtDirectorName.Size = New System.Drawing.Size(639, 21)
        Me.txtDirectorName.TabIndex = 64
        '
        'lblEmail
        '
        Me.lblEmail.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblEmail.Appearance.Options.UseFont = True
        Me.lblEmail.Location = New System.Drawing.Point(20, 263)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 15)
        Me.lblEmail.TabIndex = 70
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.EditValue = ""
        Me.txtEmail.Location = New System.Drawing.Point(125, 260)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Properties.MaxLength = 100
        Me.txtEmail.Size = New System.Drawing.Size(639, 21)
        Me.txtEmail.TabIndex = 62
        '
        'lblWebPage
        '
        Me.lblWebPage.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblWebPage.Appearance.Options.UseFont = True
        Me.lblWebPage.Location = New System.Drawing.Point(20, 239)
        Me.lblWebPage.Name = "lblWebPage"
        Me.lblWebPage.Size = New System.Drawing.Size(56, 15)
        Me.lblWebPage.TabIndex = 69
        Me.lblWebPage.Text = "Web page"
        '
        'lblFaxes
        '
        Me.lblFaxes.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblFaxes.Appearance.Options.UseFont = True
        Me.lblFaxes.Location = New System.Drawing.Point(20, 215)
        Me.lblFaxes.Name = "lblFaxes"
        Me.lblFaxes.Size = New System.Drawing.Size(33, 15)
        Me.lblFaxes.TabIndex = 68
        Me.lblFaxes.Text = "Faxes"
        '
        'lblMobilePhone
        '
        Me.lblMobilePhone.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblMobilePhone.Appearance.Options.UseFont = True
        Me.lblMobilePhone.Location = New System.Drawing.Point(20, 191)
        Me.lblMobilePhone.Name = "lblMobilePhone"
        Me.lblMobilePhone.Size = New System.Drawing.Size(74, 15)
        Me.lblMobilePhone.TabIndex = 67
        Me.lblMobilePhone.Text = "Mobile phone"
        '
        'lblTelephone
        '
        Me.lblTelephone.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTelephone.Appearance.Options.UseFont = True
        Me.lblTelephone.Location = New System.Drawing.Point(20, 167)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(36, 15)
        Me.lblTelephone.TabIndex = 66
        Me.lblTelephone.Text = "Phone"
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMobilePhone.EditValue = ""
        Me.txtMobilePhone.Location = New System.Drawing.Point(125, 188)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtMobilePhone.Properties.Appearance.Options.UseFont = True
        Me.txtMobilePhone.Properties.MaxLength = 150
        Me.txtMobilePhone.Size = New System.Drawing.Size(639, 21)
        Me.txtMobilePhone.TabIndex = 61
        '
        'txtTelephone
        '
        Me.txtTelephone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelephone.EditValue = ""
        Me.txtTelephone.Location = New System.Drawing.Point(125, 164)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtTelephone.Properties.Appearance.Options.UseFont = True
        Me.txtTelephone.Properties.MaxLength = 50
        Me.txtTelephone.Size = New System.Drawing.Size(639, 21)
        Me.txtTelephone.TabIndex = 60
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.EditValue = ""
        Me.txtAddress.Location = New System.Drawing.Point(125, 140)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Properties.MaxLength = 100
        Me.txtAddress.Size = New System.Drawing.Size(639, 21)
        Me.txtAddress.TabIndex = 14
        '
        'lblAddress
        '
        Me.lblAddress.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAddress.Appearance.Options.UseFont = True
        Me.lblAddress.Location = New System.Drawing.Point(20, 143)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(46, 15)
        Me.lblAddress.TabIndex = 13
        Me.lblAddress.Text = "Address"
        '
        'btnSavePicture
        '
        Me.btnSavePicture.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePicture.Appearance.Options.UseFont = True
        Me.btnSavePicture.Location = New System.Drawing.Point(216, 436)
        Me.btnSavePicture.Name = "btnSavePicture"
        Me.btnSavePicture.Size = New System.Drawing.Size(100, 25)
        Me.btnSavePicture.TabIndex = 11
        Me.btnSavePicture.Text = "Save picture"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(125, 332)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(639, 40)
        Me.txtDescription.TabIndex = 6
        '
        'btnDeletePicture
        '
        Me.btnDeletePicture.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePicture.Appearance.Options.UseFont = True
        Me.btnDeletePicture.Location = New System.Drawing.Point(216, 406)
        Me.btnDeletePicture.Name = "btnDeletePicture"
        Me.btnDeletePicture.Size = New System.Drawing.Size(100, 25)
        Me.btnDeletePicture.TabIndex = 9
        Me.btnDeletePicture.Text = "Delete picture"
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPicture.Appearance.Options.UseFont = True
        Me.btnSelectPicture.Location = New System.Drawing.Point(216, 375)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(100, 25)
        Me.btnSelectPicture.TabIndex = 8
        Me.btnSelectPicture.Text = "Select picture"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(125, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.MaxLength = 100
        Me.txtName.Size = New System.Drawing.Size(639, 21)
        Me.txtName.TabIndex = 4
        '
        'txtIDHospital
        '
        Me.txtIDHospital.EditValue = ""
        Me.txtIDHospital.Location = New System.Drawing.Point(125, 20)
        Me.txtIDHospital.Name = "txtIDHospital"
        Me.txtIDHospital.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtIDHospital.Properties.Appearance.Options.UseFont = True
        Me.txtIDHospital.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDHospital.Properties.MaxLength = 15
        Me.txtIDHospital.Size = New System.Drawing.Size(125, 21)
        Me.txtIDHospital.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDescription.Appearance.Options.UseFont = True
        Me.lblDescription.Location = New System.Drawing.Point(20, 335)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 15)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblName.Appearance.Options.UseFont = True
        Me.lblName.Location = New System.Drawing.Point(20, 47)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(34, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblIDHospital
        '
        Me.lblIDHospital.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIDHospital.Appearance.Options.UseFont = True
        Me.lblIDHospital.Location = New System.Drawing.Point(20, 23)
        Me.lblIDHospital.Name = "lblIDHospital"
        Me.lblIDHospital.Size = New System.Drawing.Size(58, 15)
        Me.lblIDHospital.TabIndex = 1
        Me.lblIDHospital.Text = "IDHospital"
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(125, 375)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Properties.Appearance.Options.UseFont = True
        Me.picPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picPicture.Size = New System.Drawing.Size(86, 86)
        Me.picPicture.TabIndex = 7
        '
        'tabList
        '
        Me.tabList.AutoScroll = True
        Me.tabList.Controls.Add(Me.gridControlTable2)
        Me.tabList.Controls.Add(Me.btnSearch)
        Me.tabList.Controls.Add(Me.cboSearch)
        Me.tabList.Controls.Add(Me.txtSearch)
        Me.tabList.Controls.Add(Me.lblSearch)
        Me.tabList.Name = "tabList"
        Me.tabList.Size = New System.Drawing.Size(783, 633)
        Me.tabList.Text = "List"
        '
        'gridControlTable2
        '
        Me.gridControlTable2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControlTable2.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridControlTable2.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.gridControlTable2.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Name = ""
        Me.gridControlTable2.Location = New System.Drawing.Point(20, 71)
        Me.gridControlTable2.MainView = Me.gridViewtable2
        Me.gridControlTable2.Name = "gridControlTable2"
        Me.gridControlTable2.Size = New System.Drawing.Size(743, 559)
        Me.gridControlTable2.TabIndex = 16
        Me.gridControlTable2.UseEmbeddedNavigator = True
        Me.gridControlTable2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewtable2})
        '
        'gridViewtable2
        '
        Me.gridViewtable2.GridControl = Me.gridControlTable2
        Me.gridViewtable2.Name = "gridViewtable2"
        Me.gridViewtable2.OptionsView.ShowDetailButtons = False
        Me.gridViewtable2.OptionsView.ShowGroupPanel = False
        Me.gridViewtable2.PaintStyleName = "Skin"
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.Location = New System.Drawing.Point(419, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 25)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        '
        'cboSearch
        '
        Me.cboSearch.EditValue = ""
        Me.cboSearch.Location = New System.Drawing.Point(115, 44)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.Properties.Appearance.Options.UseFont = True
        Me.cboSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSearch.Size = New System.Drawing.Size(300, 21)
        Me.cboSearch.TabIndex = 13
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(115, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Size = New System.Drawing.Size(648, 21)
        Me.txtSearch.TabIndex = 12
        '
        'lblSearch
        '
        Me.lblSearch.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSearch.Appearance.Options.UseFont = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 23)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(39, 15)
        Me.lblSearch.TabIndex = 15
        Me.lblSearch.Text = "Search"
        '
        'frmHRHospital
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 666)
        Me.Controls.Add(Me.tabFunctions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHRHospital"
        Me.Text = "Hospital"
        CType(Me.tabFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFunctions.ResumeLayout(False)
        Me.tabInformation.ResumeLayout(False)
        Me.tabInformation.PerformLayout()
        CType(Me.cboPopupDistrict.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPopupCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPopupCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWebPage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaxes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChiefAccountant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirectorName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobilePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelephone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDHospital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabList.ResumeLayout(False)
        Me.tabList.PerformLayout()
        CType(Me.gridControlTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewtable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents tabFunctions As DevExpress.XtraTab.XtraTabControl
    Public WithEvents tabInformation As DevExpress.XtraTab.XtraTabPage
    Public WithEvents cboPopupDistrict As DevExpress.XtraEditors.PopupContainerEdit
    Public WithEvents cboPopupCity As DevExpress.XtraEditors.PopupContainerEdit
    Public WithEvents cboPopupCountry As DevExpress.XtraEditors.PopupContainerEdit
    Public WithEvents lblDistrict As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblCity As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblCountry As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtWebPage As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtFaxes As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblChiefAccountant As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtChiefAccountant As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblDirectorName As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtDirectorName As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblEmail As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblWebPage As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblFaxes As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblMobilePhone As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblTelephone As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtMobilePhone As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtTelephone As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnSavePicture As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Public WithEvents btnDeletePicture As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSelectPicture As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtIDHospital As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblIDHospital As DevExpress.XtraEditors.LabelControl
    Public WithEvents picPicture As DevExpress.XtraEditors.PictureEdit
    Public WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gridControlTable2 As DevExpress.XtraGrid.GridControl
    Public WithEvents gridViewtable2 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cboSearch As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblSearch As DevExpress.XtraEditors.LabelControl

End Class
