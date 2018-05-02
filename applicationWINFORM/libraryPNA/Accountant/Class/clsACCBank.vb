'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports vb = Microsoft.VisualBasic
Imports DevExpress.XtraEditors.Controls
Imports libraryPNA.clsSystem
Imports libraryPNA.clsMessage
Imports libraryPNA.clsError
Imports libraryPNA.clsSQLServerDatabase
Public Class clsACCBank
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("ACCBank.xml", 0, intLang, DirLang.ACC)
                .mnuVietnameseEnglish.Caption = GetLang("ACCBank.xml", 1, intLang, DirLang.ACC)
                .mnuRefesh.Caption = GetLang("ACCBank.xml", 2, intLang, DirLang.ACC)
                .mnuAdd.Caption = GetLang("ACCBank.xml", 3, intLang, DirLang.ACC)
                .mnuDelete.Caption = GetLang("ACCBank.xml", 4, intLang, DirLang.ACC)
                .mnuUpdate.Caption = GetLang("ACCBank.xml", 5, intLang, DirLang.ACC)
                .mnuSave.Caption = GetLang("ACCBank.xml", 6, intLang, DirLang.ACC)
                .mnuProcess.Caption = GetLang("ACCBank.xml", 11, intLang, DirLang.ACC)
                .mnuImportFile.Caption = GetLang("ACCBank.xml", 13, intLang, DirLang.ACC)
                .mnuExportFile.Caption = GetLang("ACCBank.xml", 14, intLang, DirLang.ACC)
                .mnuHelp.Caption = GetLang("ACCBank.xml", 15, intLang, DirLang.ACC)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("ACCBank.xml", 1, intLang, DirLang.ACC)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("ACCBank.xml", 1, intLang, DirLang.ACC)
                .btnRefesh.Caption = GetLang("ACCBank.xml", 2, intLang, DirLang.ACC)
                .btnRefesh.Hint = GetLang("ACCBank.xml", 2, intLang, DirLang.ACC)
                .btnAdd.Caption = GetLang("ACCBank.xml", 3, intLang, DirLang.ACC)
                .btnAdd.Hint = GetLang("ACCBank.xml", 3, intLang, DirLang.ACC)
                .btnDelete.Caption = GetLang("ACCBank.xml", 4, intLang, DirLang.ACC)
                .btnDelete.Hint = GetLang("ACCBank.xml", 4, intLang, DirLang.ACC)
                .btnUpdate.Caption = GetLang("ACCBank.xml", 5, intLang, DirLang.ACC)
                .btnUpdate.Hint = GetLang("ACCBank.xml", 5, intLang, DirLang.ACC)
                .btnSave.Caption = GetLang("ACCBank.xml", 6, intLang, DirLang.ACC)
                .btnSave.Hint = GetLang("ACCBank.xml", 6, intLang, DirLang.ACC)
                .btnUndo.Caption = GetLang("ACCBank.xml", 7, intLang, DirLang.ACC)
                .btnUndo.Hint = GetLang("ACCBank.xml", 7, intLang, DirLang.ACC)
                .lblViewRecord.Caption = GetLang("ACCBank.xml", 9, intLang, DirLang.ACC)
                'Submenu
                .bgroupProcess.Caption = GetLang("ACCBank.xml", 11, intLang, DirLang.ACC)
                .dpanelFunctions.Text = GetLang("ACCBank.xml", 12, intLang, DirLang.ACC)
                .itemVietnameseEnglish.Caption = GetLang("ACCBank.xml", 1, intLang, DirLang.ACC)
                .itemRefesh.Caption = GetLang("ACCBank.xml", 2, intLang, DirLang.ACC)
                .itemAdd.Caption = GetLang("ACCBank.xml", 3, intLang, DirLang.ACC)
                .itemDelete.Caption = GetLang("ACCBank.xml", 4, intLang, DirLang.ACC)
                .itemUpdate.Caption = GetLang("ACCBank.xml", 5, intLang, DirLang.ACC)
                .itemSave.Caption = GetLang("ACCBank.xml", 6, intLang, DirLang.ACC)
                .itemImportFile.Caption = GetLang("ACCBank.xml", 13, intLang, DirLang.ACC)
                .itemExportFile.Caption = GetLang("ACCBank.xml", 14, intLang, DirLang.ACC)
                .itemHelp.Caption = GetLang("ACCBank.xml", 15, intLang, DirLang.ACC)
                'Center
                .lblIDBank.Text = GetLang("ACCBank.xml", 33, intLang, DirLang.ACC)
                .rdoIDAuto.Text = GetLang("ACCBank.xml", 34, intLang, DirLang.ACC)
                .rdoIDCustomize.Text = GetLang("ACCBank.xml", 35, intLang, DirLang.ACC)
                .lblName.Text = GetLang("ACCBank.xml", 38, intLang, DirLang.ACC)
                .lblCountry.Text = GetLang("ACCBank.xml", 39, intLang, DirLang.ACC)
                .lblCity.Text = GetLang("ACCBank.xml", 40, intLang, DirLang.ACC)
                .lblDistrict.Text = GetLang("ACCBank.xml", 41, intLang, DirLang.ACC)
                .lblAddress.Text = GetLang("ACCBank.xml", 42, intLang, DirLang.ACC)
                .lblTelephone.Text = GetLang("ACCBank.xml", 43, intLang, DirLang.ACC)
                .lblMobilePhone.Text = GetLang("ACCBank.xml", 44, intLang, DirLang.ACC)
                .lblFaxes.Text = GetLang("ACCBank.xml", 45, intLang, DirLang.ACC)
                .lblWebPage.Text = GetLang("ACCBank.xml", 46, intLang, DirLang.ACC)
                .lblEmail.Text = GetLang("ACCBank.xml", 47, intLang, DirLang.ACC)
                .lblDirectorName.Text = GetLang("ACCBank.xml", 48, intLang, DirLang.ACC)
                .lblChiefAccountant.Text = GetLang("ACCBank.xml", 49, intLang, DirLang.ACC)
                .lblDescription.Text = GetLang("ACCBank.xml", 50, intLang, DirLang.ACC)
                .btnSelectPicture.Text = GetLang("ACCBank.xml", 51, intLang, DirLang.ACC)
                .btnDeletePicture.Text = GetLang("ACCBank.xml", 52, intLang, DirLang.ACC)
                .btnSavePicture.Text = GetLang("ACCBank.xml", 53, intLang, DirLang.ACC)
                .tabInformation.Text = GetLang("ACCBank.xml", 16, intLang, DirLang.ACC)
                .tabList.Text = GetLang("ACCBank.xml", 17, intLang, DirLang.ACC)
                .lblSearch.Text = GetLang("ACCBank.xml", 18, intLang, DirLang.ACC)
                .btnSearch.Text = GetLang("ACCBank.xml", 18, intLang, DirLang.ACC)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("ACCBank.xml", 19, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 20, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 21, intLang, DirLang.ACC), _
                                                                   Replace(GetLang("ACCBank.xml", 33, intLang, DirLang.ACC), "(*)", ""), _
                                                                   Replace(GetLang("ACCBank.xml", 38, intLang, DirLang.ACC), "(*)", ""), _
                                                                   GetLang("ACCBank.xml", 42, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 48, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 49, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 39, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 40, intLang, DirLang.ACC), _
                                                                   GetLang("ACCBank.xml", 41, intLang, DirLang.ACC)})

                .gridViewtable2.Columns("IDBank").Caption = Replace(GetLang("ACCBank.xml", 33, intLang, DirLang.ACC), "(*)", "")
                .gridViewtable2.Columns("BankName").Caption = Replace(GetLang("ACCBank.xml", 38, intLang, DirLang.ACC), "(*)", "")
                .gridViewtable2.Columns("Address").Caption = GetLang("ACCBank.xml", 42, intLang, DirLang.ACC)
                .gridViewtable2.Columns("Telephone").Caption = GetLang("ACCBank.xml", 43, intLang, DirLang.ACC)
                .gridViewtable2.Columns("MobilePhone").Caption = GetLang("ACCBank.xml", 44, intLang, DirLang.ACC)
                .gridViewtable2.Columns("Faxes").Caption = GetLang("ACCBank.xml", 45, intLang, DirLang.ACC)
                .gridViewtable2.Columns("WebPage").Caption = GetLang("ACCBank.xml", 46, intLang, DirLang.ACC)
                .gridViewtable2.Columns("Email").Caption = GetLang("ACCBank.xml", 47, intLang, DirLang.ACC)
                .gridViewtable2.Columns("DirectorName").Caption = GetLang("ACCBank.xml", 48, intLang, DirLang.ACC)
                .gridViewtable2.Columns("ChiefAccountant").Caption = GetLang("ACCBank.xml", 49, intLang, DirLang.ACC)
                .gridViewtable2.Columns("Description").Caption = GetLang("ACCBank.xml", 50, intLang, DirLang.ACC)
                .gridViewtable2.Columns("CountryName").Caption = GetLang("ACCBank.xml", 39, intLang, DirLang.ACC)
                .gridViewtable2.Columns("CityName").Caption = GetLang("ACCBank.xml", 40, intLang, DirLang.ACC)
                .gridViewtable2.Columns("DistrictName").Caption = GetLang("ACCBank.xml", 41, intLang, DirLang.ACC)

                'Popup
                '1
                .lblPopupViewRecord1.Text = GetLang("HRCity.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh1.ToolTipText = GetLang("HRCity.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd1.ToolTipText = GetLang("HRCity.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect1.ToolTipText = GetLang("HRCity.xml", 45, intLang, DirLang.HR)
                .btnPopupExport1.ToolTipText = GetLang("HRCity.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp1.ToolTipText = GetLang("HRCity.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch1.Text = GetLang("HRCity.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch1.Text = GetLang("HRCity.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup1.Properties.Items.Clear()
                .rdoGroupPopup1.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRCountry.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRCountry.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRCountry.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("HRCountry.xml", 39, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(6, GetLang("HRCountry.xml", 40, intLang, DirLang.HR))})
                .rdoGroupPopup1.SelectedIndex = 0

                .gridViewPopup1.Columns("IDCountry").Caption = Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup1.Columns("CountryName").Caption = Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup1.Columns("CountryCode").Caption = GetLang("HRCountry.xml", 39, intLang, DirLang.HR)
                .gridViewPopup1.Columns("Description").Caption = GetLang("HRCountry.xml", 40, intLang, DirLang.HR)
                '2
                .lblPopupViewRecord2.Text = GetLang("HRDistrict.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh2.ToolTipText = GetLang("HRDistrict.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd2.ToolTipText = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect2.ToolTipText = GetLang("HRDistrict.xml", 45, intLang, DirLang.HR)
                .btnPopupExport2.ToolTipText = GetLang("HRDistrict.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp2.ToolTipText = GetLang("HRDistrict.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch2.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch2.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup2.Properties.Items.Clear()
                .rdoGroupPopup2.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRCity.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRCity.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRCity.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("HRCity.xml", 40, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(5, GetLang("HRCity.xml", 41, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(6, GetLang("HRCity.xml", 39, intLang, DirLang.HR))})
                .rdoGroupPopup2.SelectedIndex = 0
                .gridViewPopup2.Columns("IDCity").Caption = Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup2.Columns("CityName").Caption = Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup2.Columns("CityCode").Caption = GetLang("HRCity.xml", 40, intLang, DirLang.HR)
                .gridViewPopup2.Columns("Description").Caption = GetLang("HRCity.xml", 41, intLang, DirLang.HR)
                .gridViewPopup2.Columns("CountryName").Caption = GetLang("HRCity.xml", 39, intLang, DirLang.HR)
                '3
                .lblPopupViewRecord3.Text = GetLang("HRDistrict.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh3.ToolTipText = GetLang("HRDistrict.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd3.ToolTipText = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect3.ToolTipText = GetLang("HRDistrict.xml", 45, intLang, DirLang.HR)
                .btnPopupExport3.ToolTipText = GetLang("HRDistrict.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp3.ToolTipText = GetLang("HRDistrict.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch3.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch3.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup3.Properties.Items.Clear()
                .rdoGroupPopup3.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRDistrict.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRDistrict.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRDistrict.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRDistrict.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRDistrict.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("HRDistrict.xml", 40, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(5, GetLang("HRDistrict.xml", 41, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(6, GetLang("HRDistrict.xml", 39, intLang, DirLang.HR))})
                .rdoGroupPopup3.SelectedIndex = 0

                .gridViewPopup3.Columns("IDDistrict").Caption = Replace(GetLang("HRDistrict.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup3.Columns("DistrictName").Caption = Replace(GetLang("HRDistrict.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup3.Columns("DistrictCode").Caption = GetLang("HRDistrict.xml", 40, intLang, DirLang.HR)
                .gridViewPopup3.Columns("Description").Caption = GetLang("HRDistrict.xml", 41, intLang, DirLang.HR)
                .gridViewPopup3.Columns("CityName").Caption = GetLang("HRDistrict.xml", 39, intLang, DirLang.HR)

            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .toolbarPopup1.Visible = True
                .toolbarPopup2.Visible = True
                .toolbarPopup3.Visible = True
                .txtIDBank.Properties.ReadOnly = True
                .rdoIDAuto.Checked = True
                .mnuAdd.Enabled = True
                .btnAdd.Enabled = True
                .itemAdd.Enabled = True
                .mnuDelete.Enabled = True
                .btnDelete.Enabled = True
                .itemDelete.Enabled = True
                .mnuUpdate.Enabled = True
                .btnUpdate.Enabled = True
                .itemUpdate.Enabled = True
                .mnuSave.Enabled = False
                .btnSave.Enabled = False
                .itemSave.Enabled = False
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .cboPopupCountry.Enabled = Not boolValue
                .cboPopupCity.Enabled = Not boolValue
                .cboPopupDistrict.Enabled = Not boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtAddress.Properties.ReadOnly = boolValue
                .txtTelephone.Properties.ReadOnly = boolValue
                .txtMobilePhone.Properties.ReadOnly = boolValue
                .txtFaxes.Properties.ReadOnly = boolValue
                .txtWebPage.Properties.ReadOnly = boolValue
                .txtEmail.Properties.ReadOnly = boolValue
                .txtDirectorName.Properties.ReadOnly = boolValue
                .txtChiefAccountant.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
                .btnSelectPicture.Enabled = Not boolValue
                .btnDeletePicture.Enabled = Not boolValue
                .btnSavePicture.Enabled = Not boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsACCBankDB As clsACCBankDB)
        Try
            With oForm
                _clsACCBankDB.IDCountry = .strIDCountry.ToString.Trim
                _clsACCBankDB.CountryName = .strCountryName.ToString.Trim
                _clsACCBankDB.IDCity = .strIDCity.ToString.Trim
                _clsACCBankDB.CityName = .strCityName.ToString.Trim
                _clsACCBankDB.IDDistrict = .strIDDistrict.ToString.Trim
                _clsACCBankDB.DistrictName = .strDistrictName.ToString.Trim
                _clsACCBankDB.IDBank = .txtIDBank.Text.ToString.Trim
                _clsACCBankDB.BankName = .txtName.Text.ToString.Trim
                _clsACCBankDB.Address = .txtAddress.Text.ToString.Trim
                _clsACCBankDB.Telephone = .txtTelephone.Text.ToString.Trim
                _clsACCBankDB.MobilePhone = .txtMobilePhone.Text.ToString.Trim
                _clsACCBankDB.Faxes = .txtFaxes.Text.ToString.Trim
                _clsACCBankDB.WebPage = .txtWebPage.Text.ToString.Trim
                _clsACCBankDB.Email = .txtEmail.Text.ToString.Trim
                _clsACCBankDB.DirectorName = .txtDirectorName.Text.ToString.Trim
                _clsACCBankDB.ChiefAccountant = .txtChiefAccountant.Text.ToString.Trim
                _clsACCBankDB.Description = .txtDescription.Text.ToString.Trim
                Try
                    If Not .picPicture.Image Is Nothing Then
                        _clsACCBankDB.CPicture = clsIO.ByteToImage(clsIO.ImageToByte(.picPicture.Image, .strExtension))
                        _clsACCBankDB.Extension = .strExtension
                    Else
                        _clsACCBankDB.CPicture = Nothing
                        _clsACCBankDB.Extension = ""
                    End If
                Catch ex As Exception
                    _clsACCBankDB.CPicture = Nothing
                    _clsACCBankDB.Extension = ""
                End Try
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsACCBankDB As clsACCBankDB)
        Try
            With oForm
                .txtIDBank.Text = _clsACCBankDB.IDBank
                If vb.Left(.txtIDBank.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .strIDCountry = _clsACCBankDB.IDCountry
                .strCountryName = _clsACCBankDB.CountryName
                .cboPopupCountry.Text = _clsACCBankDB.CountryName
                .strIDCity = _clsACCBankDB.IDCity
                .strCityName = _clsACCBankDB.CityName
                .cboPopupCity.Text = _clsACCBankDB.CityName
                .strIDDistrict = _clsACCBankDB.IDDistrict
                .strDistrictName = _clsACCBankDB.DistrictName
                .cboPopupDistrict.Text = _clsACCBankDB.DistrictName
                .txtIDBank.Text = _clsACCBankDB.IDBank
                .txtName.Text = _clsACCBankDB.BankName
                .txtAddress.Text = _clsACCBankDB.Address
                .txtTelephone.Text = _clsACCBankDB.Telephone
                .txtMobilePhone.Text = _clsACCBankDB.MobilePhone
                .txtFaxes.Text = _clsACCBankDB.Faxes
                .txtWebPage.Text = _clsACCBankDB.WebPage
                .txtEmail.Text = _clsACCBankDB.Email
                .txtDirectorName.Text = _clsACCBankDB.DirectorName
                .txtChiefAccountant.Text = _clsACCBankDB.ChiefAccountant
                .txtDescription.Text = _clsACCBankDB.Description
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsACCBankDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsACCBankDB.Extension
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then
                    Exit Sub
                End If
                Dim _clsACCBankDB As New clsACCBankDB
                .txtIDBank.Text = .gridViewtable2.GetFocusedRowCellValue("IDBank").ToString
                If vb.Left(.txtIDBank.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .strIDBank = .txtIDBank.Text
                _clsACCBankDB.GetInfor(.txtIDBank.Text)
                .strIDCountry = _clsACCBankDB.IDCountry
                .strCountryName = _clsACCBankDB.CountryName
                .cboPopupCountry.Text = _clsACCBankDB.CountryName
                .strIDCity = _clsACCBankDB.IDCity
                .strCityName = _clsACCBankDB.CityName
                .cboPopupCity.Text = _clsACCBankDB.CityName
                .strIDDistrict = _clsACCBankDB.IDDistrict
                .strDistrictName = _clsACCBankDB.DistrictName
                .cboPopupDistrict.Text = _clsACCBankDB.DistrictName
                .txtIDBank.Text = _clsACCBankDB.IDBank
                .txtName.Text = _clsACCBankDB.BankName
                .txtAddress.Text = _clsACCBankDB.Address
                .txtTelephone.Text = _clsACCBankDB.Telephone
                .txtMobilePhone.Text = _clsACCBankDB.MobilePhone
                .txtFaxes.Text = _clsACCBankDB.Faxes
                .txtWebPage.Text = _clsACCBankDB.WebPage
                .txtEmail.Text = _clsACCBankDB.Email
                .txtDirectorName.Text = _clsACCBankDB.DirectorName
                .txtChiefAccountant.Text = _clsACCBankDB.ChiefAccountant
                .txtDescription.Text = _clsACCBankDB.Description
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsACCBankDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsACCBankDB.Extension
                _clsACCBankDB.UnsetBank() : _clsACCBankDB = Nothing
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:getRowGrid2)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setWidthHeaderGrid2(ByVal oForm As Object)
        Try
            With oForm
                .gridViewtable2.OptionsCustomization.AllowColumnMoving = False
                .gridViewtable2.OptionsFilter.AllowFilterEditor = False
                .gridViewtable2.OptionsBehavior.Editable = False
                .gridViewtable2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewtable2.OptionsView.ColumnAutoWidth = False
                .gridViewtable2.Columns("IDBank").Width = 130
                .gridViewtable2.Columns("BankName").Width = 250
                .gridViewtable2.Columns("Address").Width = 300
                .gridViewtable2.Columns("Telephone").Width = 200
                .gridViewtable2.Columns("MobilePhone").Width = 200
                .gridViewtable2.Columns("Faxes").Width = 200
                .gridViewtable2.Columns("WebPage").Width = 200
                .gridViewtable2.Columns("Email").Width = 200
                .gridViewtable2.Columns("DirectorName").Width = 200
                .gridViewtable2.Columns("ChiefAccountant").Width = 200
                .gridViewtable2.Columns("Description").Width = 200
                .gridViewtable2.Columns("IDCountry").Visible = False
                .gridViewtable2.Columns("CountryName").Width = 200
                .gridViewtable2.Columns("IDCity").Visible = False
                .gridViewtable2.Columns("CityName").Width = 200
                .gridViewtable2.Columns("IDDistrict").Visible = False
                .gridViewtable2.Columns("DistrictName").Width = 200
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:setWidthHeaderGrid2)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setWidthHeaderGridPopup1(ByVal oForm As Object)
        Try
            With oForm
                .gridViewPopup1.OptionsCustomization.AllowColumnMoving = False
                .gridViewPopup1.OptionsFilter.AllowFilterEditor = False
                .gridViewPopup1.OptionsBehavior.Editable = False
                .gridViewPopup1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewPopup1.OptionsView.ColumnAutoWidth = False
                .gridViewPopup1.Columns("IDCountry").Width = 130
                .gridViewPopup1.Columns("CountryName").Width = 250
                .gridViewPopup1.Columns("CountryCode").Width = 130
                .gridViewPopup1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setWidthHeaderGridPopup1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setWidthHeaderGridPopup2(ByVal oForm As Object)
        Try
            With oForm
                .gridViewPopup2.OptionsCustomization.AllowColumnMoving = False
                .gridViewPopup2.OptionsFilter.AllowFilterEditor = False
                .gridViewPopup2.OptionsBehavior.Editable = False
                .gridViewPopup2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewPopup2.OptionsView.ColumnAutoWidth = False
                .gridViewPopup2.Columns("IDCity").Width = 130
                .gridViewPopup2.Columns("CityName").Width = 250
                .gridViewPopup2.Columns("CityCode").Width = 130
                .gridViewPopup2.Columns("Description").Width = 350
                .gridViewPopup2.Columns("IDCountry").Visible = False
                .gridViewPopup2.Columns("CountryName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setWidthHeaderGridPopup2)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setWidthHeaderGridPopup3(ByVal oForm As Object)
        Try
            With oForm
                .gridViewPopup3.OptionsCustomization.AllowColumnMoving = False
                .gridViewPopup3.OptionsFilter.AllowFilterEditor = False
                .gridViewPopup3.OptionsBehavior.Editable = False
                .gridViewPopup3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewPopup3.OptionsView.ColumnAutoWidth = False
                .gridViewPopup3.Columns("IDDistrict").Width = 130
                .gridViewPopup3.Columns("DistrictName").Width = 250
                .gridViewPopup3.Columns("DistrictCode").Width = 130
                .gridViewPopup3.Columns("Description").Width = 350
                .gridViewPopup3.Columns("IDCity").Visible = False
                .gridViewPopup3.Columns("CityName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setWidthHeaderGridPopup3)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsACCBankDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("ACCBank.xml", 10, .intLang, DirLang.ACC) & "( " & .intTotalRow & " )"
                'Popup
                '1
                Dim intTotalRow = clsHRCountryDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord1.EditValue = 50
                Else
                    .txtPopupNumRecord1.EditValue = intTotalRow
                End If
                .lblPopupSumRecord1.Text = GetLang("HRCity.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
                '2
                intTotalRow = clsHRCityDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord2.EditValue = 50
                Else
                    .txtPopupNumRecord2.EditValue = intTotalRow
                End If
                .lblPopupSumRecord2.Text = GetLang("HRCity.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
                '3
                intTotalRow = clsHRDistrictDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord3.EditValue = 50
                Else
                    .txtPopupNumRecord3.EditValue = intTotalRow
                End If
                .lblPopupSumRecord3.Text = GetLang("HRCity.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"

            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsACCBankDB As New clsACCBankDB
                .cboPopupCountry.Properties.PopupControl = .pnlPopupSearch1
                .cboPopupCity.Properties.PopupControl = .pnlPopupSearch2
                .cboPopupDistrict.Properties.PopupControl = .pnlPopupSearch3
                TotalRow(oForm)

                .gridControlTable2.DataSource = _clsACCBankDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsACCBankDB.UnsetBank() : _clsACCBankDB = Nothing

                'Popup
                '1
                Dim _clsHRCountryDB As New clsHRCountryDB
                .gridControlPopup1.DataSource = _clsHRCountryDB.QueryTable(, .txtPopupNumRecord1.EditValue)
                setWidthHeaderGridPopup1(oForm)
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
                '2
                Dim _clsHRCityDB As New clsHRCityDB
                .gridControlPopup2.DataSource = _clsHRCityDB.QueryTable(, .txtPopupNumRecord2.EditValue)
                setWidthHeaderGridPopup2(oForm)
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
                '3
                Dim _clsHRDistrictDB As New clsHRDistrictDB
                .gridControlPopup3.DataSource = _clsHRDistrictDB.QueryTable(, .txtPopupNumRecord3.EditValue)
                setWidthHeaderGridPopup3(oForm)
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid2(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:LoadForm)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub Undo(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then Exit Sub
                Dim _clsACCBankDB As New clsACCBankDB
                If clsACCBankDB.IsExist(.strIDBank) Then
                    _clsACCBankDB.GetInfor(.strIDBank)
                    getProperty(oForm, _clsACCBankDB)
                Else
                    .txtIDBank.Text = ""
                    .txtName.Text = ""
                    .txtAddress.Text = ""
                    .txtTelephone.Text = ""
                    .txtMobilePhone.Text = ""
                    .txtFaxes.Text = ""
                    .txtWebPage.Text = ""
                    .txtEmail.Text = ""
                    .txtDirectorName.Text = ""
                    .txtChiefAccountant.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                End If
                setReadOnly(oForm, True)
                setEnable(oForm)
                _clsACCBankDB.UnsetBank() : _clsACCBankDB = Nothing
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsACCBankDB As New clsACCBankDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsACCBankDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsACCBankDB.UnsetBank() : _clsACCBankDB = Nothing
                    Exit Sub
                End If
                If clsACCBankDB.IsExist(.strIDBank) Then
                    _clsACCBankDB.GetInfor(.strIDBank)
                    getProperty(oForm, _clsACCBankDB)
                Else
                    .txtIDBank.Text = ""
                    .txtName.Text = ""
                    .txtAddress.Text = ""
                    .txtTelephone.Text = ""
                    .txtMobilePhone.Text = ""
                    .txtFaxes.Text = ""
                    .txtWebPage.Text = ""
                    .txtEmail.Text = ""
                    .txtDirectorName.Text = ""
                    .txtChiefAccountant.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                End If
                setReadOnly(oForm, True)
                setEnable(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("ACCBank.xml", 22, .intLang, DirLang.ACC), _
                                GetLang("ACCBank.xml", 23, .intLang, DirLang.ACC), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                .strIDBank = .txtIDBank.Text
                If .rdoIDAuto.Checked Then
                    .txtIDBank.Text = clsACCBankDB.AutoID
                    .txtIDBank.Properties.ReadOnly = True
                Else
                    .txtIDBank.Text = ""
                    .txtIDBank.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtAddress.Text = ""
                .txtTelephone.Text = ""
                .txtMobilePhone.Text = ""
                .txtFaxes.Text = ""
                .txtWebPage.Text = ""
                .txtEmail.Text = ""
                .txtDirectorName.Text = ""
                .txtChiefAccountant.Text = ""
                .txtDescription.Text = ""
                .picPicture.Image = Nothing

                setReadOnly(oForm, False)
                .mnuAdd.Enabled = False
                .btnAdd.Enabled = False
                .itemAdd.Enabled = False
                .mnuDelete.Enabled = False
                .btnDelete.Enabled = False
                .itemDelete.Enabled = False
                .mnuUpdate.Enabled = False
                .btnUpdate.Enabled = False
                .itemUpdate.Enabled = False
                .mnuSave.Enabled = True
                .btnSave.Enabled = True
                .itemSave.Enabled = True
                .intButton = 1
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("ACCBank.xml", 22, .intLang, DirLang.ACC), _
                                   GetLang("ACCBank.xml", 24, .intLang, DirLang.ACC), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub
                If clsACCBankDB.IsExist(.txtIDBank.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("ACCBank.xml", 30, .intLang, DirLang.ACC), _
                                   GetLang("ACCBank.xml", 31, .intLang, DirLang.ACC), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsACCBankDB.Delete(.txtIDBank.Text.Trim)
                    .txtIDBank.Text = ""
                    .txtName.Text = ""
                    .txtAddress.Text = ""
                    .txtTelephone.Text = ""
                    .txtMobilePhone.Text = ""
                    .txtFaxes.Text = ""
                    .txtWebPage.Text = ""
                    .txtEmail.Text = ""
                    .txtDirectorName.Text = ""
                    .txtChiefAccountant.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDBank.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("ACCBank.xml", 22, .intLang, DirLang.ACC), _
                                   GetLang("ACCBank.xml", 25, .intLang, DirLang.ACC), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDBank.Properties.ReadOnly = True
                setReadOnly(oForm, False)
                .mnuAdd.Enabled = False
                .btnAdd.Enabled = False
                .itemAdd.Enabled = False
                .mnuDelete.Enabled = False
                .btnDelete.Enabled = False
                .itemDelete.Enabled = False
                .mnuUpdate.Enabled = False
                .btnUpdate.Enabled = False
                .itemUpdate.Enabled = False
                .mnuSave.Enabled = True
                .btnSave.Enabled = True
                .itemSave.Enabled = True
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDBank.Text.Trim = "" Then
                s = GetLang("ACCBank.xml", 33, .intLang, DirLang.ACC) & " " & GetLang("ACCBank.xml", 36, .intLang, DirLang.ACC) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("ACCBank.xml", 38, .intLang, DirLang.ACC) & " " & GetLang("ACCBank.xml", 36, .intLang, DirLang.ACC)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("ACCBank.xml", 27, .intLang, DirLang.ACC), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDBank.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("ACCBank.xml", 27, .intLang, DirLang.ACC), _
                            GetLang("ACCBank.xml", 37, .intLang, DirLang.ACC), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If .cboPopupCity.Text.ToString() <> "" And clsHRCityDB.IsExistPK_FK(.strIDCity, .strIDCountry) = False Then
                ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRCity.xml", 46, .intLang, DirLang.HR), _
                            .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If .cboPopupDistrict.Text.ToString() <> "" And clsHRDistrictDB.IsExistPK_FK(.strIDDistrict, .strIDCity) = False Then
                ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRDistrict.xml", 46, .intLang, DirLang.HR), _
                            .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("ACCBank.xml", 22, .intLang, DirLang.ACC), _
                             GetLang("ACCBank.xml", 26, .intLang, DirLang.ACC), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsACCBankDB.IsExist(.txtIDBank.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("ACCBank.xml", 27, .intLang, DirLang.ACC), _
                                   GetLang("ACCBank.xml", 28, .intLang, DirLang.ACC), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsACCBankDB As New clsACCBankDB
                    setProperty(oForm, _clsACCBankDB)
                    If clsACCBankDB.IsExist(.txtIDBank.Text.Trim) Then
                        ShowMessage(oForm, GetLang("ACCBank.xml", 27, .intLang, DirLang.ACC), _
                                           GetLang("ACCBank.xml", 32, .intLang, DirLang.ACC), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        Exit Sub
                    End If
                    _clsACCBankDB.Add()
                    .strIDBank = .txtIDBank.Text
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("ACCBank.xml", 22, .intLang, DirLang.ACC), _
                                       GetLang("ACCBank.xml", 25, .intLang, DirLang.ACC), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("ACCBank.xml", 27, .intLang, DirLang.ACC), _
                                   GetLang("ACCBank.xml", 29, .intLang, DirLang.ACC), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsACCBankDB As New clsACCBankDB
                    setProperty(oForm, _clsACCBankDB)
                    _clsACCBankDB.Update()
                    TotalRow(oForm)
                End If
                .txtIDBank.Properties.ReadOnly = True
                setReadOnly(oForm, True)
                .mnuAdd.Enabled = True
                .btnAdd.Enabled = True
                .itemAdd.Enabled = True
                .mnuDelete.Enabled = True
                .btnDelete.Enabled = True
                .itemDelete.Enabled = True
                .mnuUpdate.Enabled = True
                .btnUpdate.Enabled = True
                .itemUpdate.Enabled = True
                .mnuSave.Enabled = False
                .btnSave.Enabled = False
                .itemSave.Enabled = False
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsACCBank:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsACCBankDB As New clsACCBankDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                           " a.IDBank,a.BankName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                                           "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description," & _
                                                                                           "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName " & _
                                                                                      "FROM ACCBank a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                                                           "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                                                           "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                                                                      "ORDER BY a.IDBank ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsACCBankDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsACCBankDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "a.IDBank", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "a.BankName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "a.Address", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "a.DirectorName", .txtSearch.Text.Trim)
                    Case 7
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "a.ChiefAccountant", .txtSearch.Text.Trim)
                    Case 8
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "b.CountryName", .txtSearch.Text.Trim)
                    Case 9
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "c.CityName", .txtSearch.Text.Trim)
                    Case 10
                        .gridControlTable2.DataSource = _clsACCBankDB.Search(, .txtNumRecord.EditValue, "d.DistrictName", .txtSearch.Text.Trim)
                End Select
                _clsACCBankDB.UnsetBank() : _clsACCBankDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    'Popup
    Public Shared Sub ItemPopupSearch1(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCountryDB As New clsHRCountryDB
                Select Case .rdoGroupPopup1.SelectedIndex
                    Case 0
                        .gridControlPopup1.DataSource = _clsHRCountryDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord1.EditValue & _
                                                                                       " IDCountry,CountryName,CountryCode,Description " & _
                                                                                       "FROM HRCountry " & _
                                                                                       "ORDER BY IDCountry ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup1.DataSource = _clsHRCountryDB.SearchCondition(, .txtPopupNumRecord1.EditValue, .txtPopupSearch1.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup1.DataSource = _clsHRCountryDB.SearchQuery(, .txtPopupNumRecord1.EditValue, .txtPopupSearch1.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup1.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord1.EditValue, "IDCountry", .txtPopupSearch1.Text.Trim)
                    Case 4
                        .gridControlPopup1.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord1.EditValue, "CountryName", .txtPopupSearch1.Text.Trim)
                    Case 5
                        .gridControlPopup1.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord1.EditValue, "CountryCode", .txtPopupSearch1.Text.Trim)
                    Case 6
                        .gridControlPopup1.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord1.EditValue, "Description", .txtPopupSearch1.Text.Trim)
                End Select
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub ItemPopupSearch2(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCityDB As New clsHRCityDB
                Select Case .rdoGroupPopup2.SelectedIndex
                    Case 0
                        .gridControlPopup2.DataSource = _clsHRCityDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord2.EditValue & _
                                                                                          " a.IDCity,a.CityName,a.CityCode,a.Description,b.IDCountry,b.CountryName " & _
                                                                                    "FROM HRCity a,HRCountry b " & _
                                                                                    "WHERE a.IDCountry=b.IDCountry " & _
                                                                                    "ORDER BY IDCity ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup2.DataSource = _clsHRCityDB.SearchCondition(, .txtPopupNumRecord2.EditValue, .txtPopupSearch2.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup2.DataSource = _clsHRCityDB.SearchQuery(, .txtPopupNumRecord2.EditValue, .txtPopupSearch2.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup2.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord2.EditValue, "a.IDCity", .txtPopupSearch2.Text.Trim)
                    Case 4
                        .gridControlPopup2.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord2.EditValue, "a.CityName", .txtPopupSearch2.Text.Trim)
                    Case 5
                        .gridControlPopup2.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord2.EditValue, "a.CityCode", .txtPopupSearch2.Text.Trim)
                    Case 6
                        .gridControlPopup2.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord2.EditValue, "a.Description", .txtPopupSearch2.Text.Trim)
                    Case 7
                        .gridControlPopup2.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord2.EditValue, "b.CountryName", .txtPopupSearch2.Text.Trim)
                End Select
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub ItemPopupSearch3(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDistrictDB As New clsHRDistrictDB
                Select Case .rdoGroupPopup3.SelectedIndex
                    Case 0
                        .gridControlPopup3.DataSource = _clsHRDistrictDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord3.EditValue & _
                                                                                              " a.IDDistrict,a.DistrictName,a.DistrictCode,a.Description,b.IDCity,b.CityName " & _
                                                                                        "FROM HRDistrict a,HRCity b " & _
                                                                                        "WHERE a.IDCity=b.IDCity " & _
                                                                                       "ORDER BY IDDistrict ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup3.DataSource = _clsHRDistrictDB.SearchCondition(, .txtPopupNumRecord3.EditValue, .txtPopupSearch3.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup3.DataSource = _clsHRDistrictDB.SearchQuery(, .txtPopupNumRecord3.EditValue, .txtPopupSearch3.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup3.DataSource = _clsHRDistrictDB.Search(, .txtPopupNumRecord3.EditValue, "a.IDDistrict", .txtPopupSearch3.Text.Trim)
                    Case 4
                        .gridControlPopup3.DataSource = _clsHRDistrictDB.Search(, .txtPopupNumRecord3.EditValue, "a.DistrictName", .txtPopupSearch3.Text.Trim)
                    Case 5
                        .gridControlPopup3.DataSource = _clsHRDistrictDB.Search(, .txtPopupNumRecord3.EditValue, "a.DistrictCode", .txtPopupSearch3.Text.Trim)
                    Case 6
                        .gridControlPopup3.DataSource = _clsHRDistrictDB.Search(, .txtPopupNumRecord3.EditValue, "a.Description", .txtPopupSearch3.Text.Trim)
                    Case 7
                        .gridControlPopup3.DataSource = _clsHRDistrictDB.Search(, .txtPopupNumRecord3.EditValue, "b.CityName", .txtPopupSearch3.Text.Trim)
                End Select
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
