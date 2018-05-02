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
Public Class clsHRCompany
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRCompany.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRCompany.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRCompany.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRCompany.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRCompany.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRCompany.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRCompany.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRCompany.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRCompany.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRCompany.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRCompany.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRCompany.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRCompany.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRCompany.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRCompany.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRCompany.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRCompany.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRCompany.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRCompany.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRCompany.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRCompany.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRCompany.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRCompany.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRCompany.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRCompany.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRCompany.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRCompany.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRCompany.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRCompany.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRCompany.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRCompany.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRCompany.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRCompany.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRCompany.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRCompany.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRCompany.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRCompany.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDCompany.Text = GetLang("HRCompany.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRCompany.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRCompany.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRCompany.xml", 38, intLang, DirLang.HR)
                .lblBusiness.Text = GetLang("HRCompany.xml", 39, intLang, DirLang.HR)
                .lblTaxCode.Text = GetLang("HRCompany.xml", 40, intLang, DirLang.HR)
                .lblCountry.Text = GetLang("HRCompany.xml", 41, intLang, DirLang.HR)
                .lblCity.Text = GetLang("HRCompany.xml", 42, intLang, DirLang.HR)
                .lblDistrict.Text = GetLang("HRCompany.xml", 43, intLang, DirLang.HR)
                .lblBank.Text = GetLang("HRCompany.xml", 44, intLang, DirLang.HR)
                .lblAccountNumber.Text = GetLang("HRCompany.xml", 45, intLang, DirLang.HR)
                .lblAddress.Text = GetLang("HRCompany.xml", 46, intLang, DirLang.HR)
                .lblTelephone.Text = GetLang("HRCompany.xml", 47, intLang, DirLang.HR)
                .lblMobilePhone.Text = GetLang("HRCompany.xml", 48, intLang, DirLang.HR)
                .lblFaxes.Text = GetLang("HRCompany.xml", 49, intLang, DirLang.HR)
                .lblWebPage.Text = GetLang("HRCompany.xml", 50, intLang, DirLang.HR)
                .lblEmail.Text = GetLang("HRCompany.xml", 51, intLang, DirLang.HR)
                .lblDirectorName.Text = GetLang("HRCompany.xml", 52, intLang, DirLang.HR)
                .lblChiefAccountant.Text = GetLang("HRCompany.xml", 53, intLang, DirLang.HR)
                .lblHRManager.Text = GetLang("HRCompany.xml", 54, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRCompany.xml", 55, intLang, DirLang.HR)
                .btnSelectPicture.Text = GetLang("HRCompany.xml", 56, intLang, DirLang.HR)
                .btnDeletePicture.Text = GetLang("HRCompany.xml", 57, intLang, DirLang.HR)
                .btnSavePicture.Text = GetLang("HRCompany.xml", 58, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRCompany.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRCompany.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRCompany.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRCompany.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRCompany.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRCompany.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRCompany.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRCompany.xml", 39, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 40, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 46, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 52, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 53, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 54, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 41, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 42, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 43, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 44, intLang, DirLang.HR), _
                                                                   GetLang("HRCompany.xml", 45, intLang, DirLang.HR)})

                .gridViewtable2.Columns("IDCompany").Caption = Replace(GetLang("HRCompany.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("CompanyName").Caption = Replace(GetLang("HRCompany.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("Business").Caption = GetLang("HRCompany.xml", 39, intLang, DirLang.HR)
                .gridViewtable2.Columns("TaxCode").Caption = GetLang("HRCompany.xml", 40, intLang, DirLang.HR)
                .gridViewtable2.Columns("Address").Caption = GetLang("HRCompany.xml", 46, intLang, DirLang.HR)
                .gridViewtable2.Columns("Telephone").Caption = GetLang("HRCompany.xml", 47, intLang, DirLang.HR)
                .gridViewtable2.Columns("MobilePhone").Caption = GetLang("HRCompany.xml", 48, intLang, DirLang.HR)
                .gridViewtable2.Columns("Faxes").Caption = GetLang("HRCompany.xml", 49, intLang, DirLang.HR)
                .gridViewtable2.Columns("WebPage").Caption = GetLang("HRCompany.xml", 50, intLang, DirLang.HR)
                .gridViewtable2.Columns("Email").Caption = GetLang("HRCompany.xml", 51, intLang, DirLang.HR)
                .gridViewtable2.Columns("DirectorName").Caption = GetLang("HRCompany.xml", 52, intLang, DirLang.HR)
                .gridViewtable2.Columns("ChiefAccountant").Caption = GetLang("HRCompany.xml", 53, intLang, DirLang.HR)
                .gridViewtable2.Columns("HRManager").Caption = GetLang("HRCompany.xml", 54, intLang, DirLang.HR)
                .gridViewtable2.Columns("Description").Caption = GetLang("HRCompany.xml", 55, intLang, DirLang.HR)
                .gridViewtable2.Columns("CountryName").Caption = GetLang("HRCompany.xml", 41, intLang, DirLang.HR)
                .gridViewtable2.Columns("CityName").Caption = GetLang("HRCompany.xml", 42, intLang, DirLang.HR)
                .gridViewtable2.Columns("DistrictName").Caption = GetLang("HRCompany.xml", 43, intLang, DirLang.HR)
                .gridViewtable2.Columns("BankName").Caption = GetLang("HRCompany.xml", 44, intLang, DirLang.HR)
                .gridViewtable2.Columns("AccountNumber").Caption = GetLang("HRCompany.xml", 45, intLang, DirLang.HR)

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
                '4
                .lblPopupViewRecord4.Text = GetLang("HRDistrict.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh4.ToolTipText = GetLang("HRDistrict.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd4.ToolTipText = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect4.ToolTipText = GetLang("HRDistrict.xml", 45, intLang, DirLang.HR)
                .btnPopupExport4.ToolTipText = GetLang("HRDistrict.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp4.ToolTipText = GetLang("HRDistrict.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch4.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch4.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup4.Properties.Items.Clear()
                .rdoGroupPopup4.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("ACCBank.xml", 19, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(1, GetLang("ACCBank.xml", 20, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(2, GetLang("ACCBank.xml", 21, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(3, Replace(GetLang("ACCBank.xml", 33, intLang, DirLang.ACC), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("ACCBank.xml", 38, intLang, DirLang.ACC), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("ACCBank.xml", 42, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(6, GetLang("ACCBank.xml", 48, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(7, GetLang("ACCBank.xml", 49, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(8, GetLang("ACCBank.xml", 39, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(9, GetLang("ACCBank.xml", 40, intLang, DirLang.ACC)), _
                                                              New RadioGroupItem(10, GetLang("ACCBank.xml", 41, intLang, DirLang.ACC))})
                .rdoGroupPopup4.SelectedIndex = 0

                .gridViewPopup4.Columns("IDBank").Caption = Replace(GetLang("ACCBank.xml", 33, intLang, DirLang.ACC), "(*)", "")
                .gridViewPopup4.Columns("BankName").Caption = Replace(GetLang("ACCBank.xml", 38, intLang, DirLang.ACC), "(*)", "")
                .gridViewPopup4.Columns("Address").Caption = GetLang("ACCBank.xml", 42, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("Telephone").Caption = GetLang("ACCBank.xml", 43, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("MobilePhone").Caption = GetLang("ACCBank.xml", 44, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("Faxes").Caption = GetLang("ACCBank.xml", 45, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("WebPage").Caption = GetLang("ACCBank.xml", 46, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("Email").Caption = GetLang("ACCBank.xml", 47, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("DirectorName").Caption = GetLang("ACCBank.xml", 48, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("ChiefAccountant").Caption = GetLang("ACCBank.xml", 49, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("Description").Caption = GetLang("ACCBank.xml", 50, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("CountryName").Caption = GetLang("ACCBank.xml", 39, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("CityName").Caption = GetLang("ACCBank.xml", 40, intLang, DirLang.ACC)
                .gridViewPopup4.Columns("DistrictName").Caption = GetLang("ACCBank.xml", 41, intLang, DirLang.ACC)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:LoadLang)", ex.Message.ToString, IconType.Message)
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
                .toolbarPopup4.Visible = True
                .txtIDCompany.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:setEnable)", ex.Message.ToString, IconType.Message)
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
                .cboPopupBank.Enabled = Not boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtBusiness.Properties.ReadOnly = boolValue
                .txtTaxCode.Properties.ReadOnly = boolValue
                .txtAccountNumber.Properties.ReadOnly = boolValue
                .txtAddress.Properties.ReadOnly = boolValue
                .txtTelephone.Properties.ReadOnly = boolValue
                .txtMobilePhone.Properties.ReadOnly = boolValue
                .txtFaxes.Properties.ReadOnly = boolValue
                .txtWebPage.Properties.ReadOnly = boolValue
                .txtEmail.Properties.ReadOnly = boolValue
                .txtDirectorName.Properties.ReadOnly = boolValue
                .txtChiefAccountant.Properties.ReadOnly = boolValue
                .txtHRManager.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
                .btnSelectPicture.Enabled = Not boolValue
                .btnDeletePicture.Enabled = Not boolValue
                .btnSavePicture.Enabled = Not boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRCompanyDB As clsHRCompanyDB)
        Try
            With oForm
                _clsHRCompanyDB.IDCountry = .strIDCountry.ToString.Trim
                _clsHRCompanyDB.CountryName = .strCountryName.ToString.Trim
                _clsHRCompanyDB.IDCity = .strIDCity.ToString.Trim
                _clsHRCompanyDB.CityName = .strCityName.ToString.Trim
                _clsHRCompanyDB.IDDistrict = .strIDDistrict.ToString.Trim
                _clsHRCompanyDB.DistrictName = .strDistrictName.ToString.Trim
                _clsHRCompanyDB.IDBank = .strIDBank.ToString.Trim
                _clsHRCompanyDB.BankName = .strBankName.ToString.Trim
                _clsHRCompanyDB.IDCompany = .txtIDCompany.Text.ToString.Trim
                _clsHRCompanyDB.CompanyName = .txtName.Text.ToString.Trim
                _clsHRCompanyDB.Business = .txtBusiness.Text.ToString.Trim
                _clsHRCompanyDB.TaxCode = .txtTaxCode.Text.ToString.Trim
                _clsHRCompanyDB.AccountNumber = .txtAccountNumber.Text.ToString.Trim
                _clsHRCompanyDB.Address = .txtAddress.Text.ToString.Trim
                _clsHRCompanyDB.Telephone = .txtTelephone.Text.ToString.Trim
                _clsHRCompanyDB.MobilePhone = .txtMobilePhone.Text.ToString.Trim
                _clsHRCompanyDB.Faxes = .txtFaxes.Text.ToString.Trim
                _clsHRCompanyDB.WebPage = .txtWebPage.Text.ToString.Trim
                _clsHRCompanyDB.Email = .txtEmail.Text.ToString.Trim
                _clsHRCompanyDB.DirectorName = .txtDirectorName.Text.ToString.Trim
                _clsHRCompanyDB.ChiefAccountant = .txtChiefAccountant.Text.ToString.Trim
                _clsHRCompanyDB.HRManager = .txtHRManager.Text.ToString.Trim
                _clsHRCompanyDB.Description = .txtDescription.Text.ToString.Trim
                Try
                    If Not .picPicture.Image Is Nothing Then
                        _clsHRCompanyDB.CPicture = clsIO.ByteToImage(clsIO.ImageToByte(.picPicture.Image, .strExtension))
                        _clsHRCompanyDB.Extension = .strExtension
                    Else
                        _clsHRCompanyDB.CPicture = Nothing
                        _clsHRCompanyDB.Extension = ""
                    End If
                Catch ex As Exception
                    _clsHRCompanyDB.CPicture = Nothing
                    _clsHRCompanyDB.Extension = ""
                End Try
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRCompanyDB As clsHRCompanyDB)
        Try
            With oForm
                .txtIDCompany.Text = _clsHRCompanyDB.IDCompany
                If vb.Left(.txtIDCompany.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .strIDCountry = _clsHRCompanyDB.IDCountry
                .strCountryName = _clsHRCompanyDB.CountryName
                .cboPopupCountry.Text = _clsHRCompanyDB.CountryName
                .strIDCity = _clsHRCompanyDB.IDCity
                .strCityName = _clsHRCompanyDB.CityName
                .cboPopupCity.Text = _clsHRCompanyDB.CityName
                .strIDDistrict = _clsHRCompanyDB.IDDistrict
                .strDistrictName = _clsHRCompanyDB.DistrictName
                .cboPopupDistrict.Text = _clsHRCompanyDB.DistrictName
                .strIDBank = _clsHRCompanyDB.IDBank
                .strBankName = _clsHRCompanyDB.BankName
                .cboPopupBank.Text = _clsHRCompanyDB.BankName

                .txtIDCompany.Text = _clsHRCompanyDB.IDCompany
                .txtName.Text = _clsHRCompanyDB.CompanyName
                .txtBusiness.Text = _clsHRCompanyDB.Business
                .txtTaxCode.Text = _clsHRCompanyDB.TaxCode
                .txtAccountNumber.Text = _clsHRCompanyDB.AccountNumber
                .txtAddress.Text = _clsHRCompanyDB.Address
                .txtTelephone.Text = _clsHRCompanyDB.Telephone
                .txtMobilePhone.Text = _clsHRCompanyDB.MobilePhone
                .txtFaxes.Text = _clsHRCompanyDB.Faxes
                .txtWebPage.Text = _clsHRCompanyDB.WebPage
                .txtEmail.Text = _clsHRCompanyDB.Email
                .txtDirectorName.Text = _clsHRCompanyDB.DirectorName
                .txtChiefAccountant.Text = _clsHRCompanyDB.ChiefAccountant
                .txtHRManager.Text = _clsHRCompanyDB.HRManager
                .txtDescription.Text = _clsHRCompanyDB.Description
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsHRCompanyDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsHRCompanyDB.Extension
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then
                    Exit Sub
                End If
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                .txtIDCompany.Text = .gridViewtable2.GetFocusedRowCellValue("IDCompany").ToString
                If vb.Left(.txtIDCompany.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .strIDCompany = .txtIDCompany.Text
                _clsHRCompanyDB.GetInfor(.txtIDCompany.Text)
                .strIDCountry = _clsHRCompanyDB.IDCountry
                .strCountryName = _clsHRCompanyDB.CountryName
                .cboPopupCountry.Text = _clsHRCompanyDB.CountryName
                .strIDCity = _clsHRCompanyDB.IDCity
                .strCityName = _clsHRCompanyDB.CityName
                .cboPopupCity.Text = _clsHRCompanyDB.CityName
                .strIDDistrict = _clsHRCompanyDB.IDDistrict
                .strDistrictName = _clsHRCompanyDB.DistrictName
                .cboPopupDistrict.Text = _clsHRCompanyDB.DistrictName
                .strIDBank = _clsHRCompanyDB.IDBank
                .strBankName = _clsHRCompanyDB.BankName
                .cboPopupBank.Text = _clsHRCompanyDB.BankName

                .txtIDCompany.Text = _clsHRCompanyDB.IDCompany
                .txtName.Text = _clsHRCompanyDB.CompanyName
                .txtBusiness.Text = _clsHRCompanyDB.Business
                .txtTaxCode.Text = _clsHRCompanyDB.TaxCode
                .txtAccountNumber.Text = _clsHRCompanyDB.AccountNumber
                .txtAddress.Text = _clsHRCompanyDB.Address
                .txtTelephone.Text = _clsHRCompanyDB.Telephone
                .txtMobilePhone.Text = _clsHRCompanyDB.MobilePhone
                .txtFaxes.Text = _clsHRCompanyDB.Faxes
                .txtWebPage.Text = _clsHRCompanyDB.WebPage
                .txtEmail.Text = _clsHRCompanyDB.Email
                .txtDirectorName.Text = _clsHRCompanyDB.DirectorName
                .txtChiefAccountant.Text = _clsHRCompanyDB.ChiefAccountant
                .txtHRManager.Text = _clsHRCompanyDB.HRManager
                .txtDescription.Text = _clsHRCompanyDB.Description
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsHRCompanyDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsHRCompanyDB.Extension
                _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDCompany").Width = 130
                .gridViewtable2.Columns("CompanyName").Width = 250
                .gridViewtable2.Columns("Business").Width = 250
                .gridViewtable2.Columns("TaxCode").Width = 200
                .gridViewtable2.Columns("Address").Width = 300
                .gridViewtable2.Columns("Telephone").Width = 200
                .gridViewtable2.Columns("MobilePhone").Width = 200
                .gridViewtable2.Columns("Faxes").Width = 200
                .gridViewtable2.Columns("WebPage").Width = 200
                .gridViewtable2.Columns("Email").Width = 200
                .gridViewtable2.Columns("DirectorName").Width = 200
                .gridViewtable2.Columns("ChiefAccountant").Width = 200
                .gridViewtable2.Columns("HRManager").Width = 200
                .gridViewtable2.Columns("Description").Width = 200
                .gridViewtable2.Columns("IDCountry").Visible = False
                .gridViewtable2.Columns("CountryName").Width = 200
                .gridViewtable2.Columns("IDCity").Visible = False
                .gridViewtable2.Columns("CityName").Width = 200
                .gridViewtable2.Columns("IDDistrict").Visible = False
                .gridViewtable2.Columns("DistrictName").Width = 200
                .gridViewtable2.Columns("IDBank").Visible = False
                .gridViewtable2.Columns("BankName").Width = 200
                .gridViewtable2.Columns("AccountNumber").Width = 200
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:setWidthHeaderGrid2)", ex.Message.ToString, IconType.Message)
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
    Public Shared Sub setWidthHeaderGridPopup4(ByVal oForm As Object)
        Try
            With oForm
                .gridViewPopup4.OptionsCustomization.AllowColumnMoving = False
                .gridViewPopup4.OptionsFilter.AllowFilterEditor = False
                .gridViewPopup4.OptionsBehavior.Editable = False
                .gridViewPopup4.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewPopup4.OptionsView.ColumnAutoWidth = False
                .gridViewPopup4.Columns("IDBank").Width = 130
                .gridViewPopup4.Columns("BankName").Width = 250
                .gridViewPopup4.Columns("Address").Width = 300
                .gridViewPopup4.Columns("Telephone").Width = 200
                .gridViewPopup4.Columns("MobilePhone").Width = 200
                .gridViewPopup4.Columns("Faxes").Width = 200
                .gridViewPopup4.Columns("WebPage").Width = 200
                .gridViewPopup4.Columns("Email").Width = 200
                .gridViewPopup4.Columns("DirectorName").Width = 200
                .gridViewPopup4.Columns("ChiefAccountant").Width = 200
                .gridViewPopup4.Columns("Description").Width = 200
                .gridViewPopup4.Columns("IDCountry").Visible = False
                .gridViewPopup4.Columns("CountryName").Width = 200
                .gridViewPopup4.Columns("IDCity").Visible = False
                .gridViewPopup4.Columns("CityName").Width = 200
                .gridViewPopup4.Columns("IDDistrict").Visible = False
                .gridViewPopup4.Columns("DistrictName").Width = 200
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setWidthHeaderGridPopup4)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRCompanyDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRCompany.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
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
                '4
                intTotalRow = clsACCBankDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord4.EditValue = 50
                Else
                    .txtPopupNumRecord4.EditValue = intTotalRow
                End If
                .lblPopupSumRecord4.Text = GetLang("HRCity.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                .cboPopupCountry.Properties.PopupControl = .pnlPopupSearch1
                .cboPopupCity.Properties.PopupControl = .pnlPopupSearch2
                .cboPopupDistrict.Properties.PopupControl = .pnlPopupSearch3
                .cboPopupBank.Properties.PopupControl = .pnlPopupSearch4
                TotalRow(oForm)

                .gridControlTable2.DataSource = _clsHRCompanyDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing

                'Popup
                '1
                Dim _clsHRCountryDB = New clsHRCountryDB
                .gridControlPopup1.DataSource = _clsHRCountryDB.QueryTable(, .txtPopupNumRecord1.EditValue)
                setWidthHeaderGridPopup1(oForm)
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
                '2
                Dim _clsHRCityDB = New clsHRCityDB
                .gridControlPopup2.DataSource = _clsHRCityDB.QueryTable(, .txtPopupNumRecord2.EditValue)
                setWidthHeaderGridPopup2(oForm)
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
                '3
                Dim _clsHRDistrictDB = New clsHRDistrictDB
                .gridControlPopup3.DataSource = _clsHRDistrictDB.QueryTable(, .txtPopupNumRecord3.EditValue)
                setWidthHeaderGridPopup3(oForm)
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing
                '3
                Dim _clsACCBankDB As New clsACCBankDB
                .gridControlPopup4.DataSource = _clsACCBankDB.QueryTable(, .txtPopupNumRecord4.EditValue)
                setWidthHeaderGridPopup4(oForm)
                _clsACCBankDB.UnsetBank() : _clsACCBankDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid2(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:LoadForm)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub Undo(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then Exit Sub
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                If clsHRCompanyDB.IsExist(.strIDCompany) Then
                    _clsHRCompanyDB.GetInfor(.strIDCompany)
                    getProperty(oForm, _clsHRCompanyDB)
                Else
                    .txtIDCompany.Text = ""
                    .txtName.Text = ""
                    .txtBusiness.Text = ""
                    .txtTaxCode.Text = ""
                    .txtAccountNumber.Text = ""
                    .txtAddress.Text = ""
                    .txtTelephone.Text = ""
                    .txtMobilePhone.Text = ""
                    .txtFaxes.Text = ""
                    .txtWebPage.Text = ""
                    .txtEmail.Text = ""
                    .txtDirectorName.Text = ""
                    .txtChiefAccountant.Text = ""
                    .txtHRManager.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                End If
                setReadOnly(oForm, True)
                setEnable(oForm)
                _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRCompanyDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing
                    Exit Sub
                End If
                If clsHRCompanyDB.IsExist(.strIDCompany) Then
                    _clsHRCompanyDB.GetInfor(.strIDCompany)
                    getProperty(oForm, _clsHRCompanyDB)
                Else
                    .txtIDCompany.Text = ""
                    .txtName.Text = ""
                    .txtBusiness.Text = ""
                    .txtTaxCode.Text = ""
                    .txtAccountNumber.Text = ""
                    .txtAddress.Text = ""
                    .txtTelephone.Text = ""
                    .txtMobilePhone.Text = ""
                    .txtFaxes.Text = ""
                    .txtWebPage.Text = ""
                    .txtEmail.Text = ""
                    .txtDirectorName.Text = ""
                    .txtChiefAccountant.Text = ""
                    .txtHRManager.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                End If
                setReadOnly(oForm, True)
                setEnable(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRCompany.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRCompany.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                .strIDCompany = .txtIDCompany.Text
                If .rdoIDAuto.Checked Then
                    .txtIDCompany.Text = clsHRCompanyDB.AutoID
                    .txtIDCompany.Properties.ReadOnly = True
                Else
                    .txtIDCompany.Text = ""
                    .txtIDCompany.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtBusiness.Text = ""
                .txtTaxCode.Text = ""
                .txtAccountNumber.Text = ""
                .txtAddress.Text = ""
                .txtTelephone.Text = ""
                .txtMobilePhone.Text = ""
                .txtFaxes.Text = ""
                .txtWebPage.Text = ""
                .txtEmail.Text = ""
                .txtDirectorName.Text = ""
                .txtChiefAccountant.Text = ""
                .txtHRManager.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRCompany.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCompany.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub
                If clsHRCompanyDB.IsExist(.txtIDCompany.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRCompany.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRCompany.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRCompanyDB.Delete(.txtIDCompany.Text.Trim)
                    .txtIDCompany.Text = ""
                    .txtName.Text = ""
                    .txtBusiness.Text = ""
                    .txtTaxCode.Text = ""
                    .txtAccountNumber.Text = ""
                    .txtAddress.Text = ""
                    .txtTelephone.Text = ""
                    .txtMobilePhone.Text = ""
                    .txtFaxes.Text = ""
                    .txtWebPage.Text = ""
                    .txtEmail.Text = ""
                    .txtDirectorName.Text = ""
                    .txtChiefAccountant.Text = ""
                    .txtHRManager.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDCompany.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRCompany.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCompany.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDCompany.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDCompany.Text.Trim = "" Then
                s = GetLang("HRCompany.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRCompany.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRCompany.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRCompany.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRCompany.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDCompany.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRCompany.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRCompany.xml", 37, .intLang, DirLang.HR), .intLang, _
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
            If Not CheckSave(oForm, GetLang("HRCompany.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRCompany.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRCompanyDB.IsExist(.txtIDCompany.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRCompany.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCompany.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRCompanyDB As New clsHRCompanyDB
                    setProperty(oForm, _clsHRCompanyDB)
                    If clsHRCompanyDB.IsExist(.txtIDCompany.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRCompany.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRCompany.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        Exit Sub
                    End If
                    _clsHRCompanyDB.Add()
                    .strIDCompany = .txtIDCompany.Text
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRCompany.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRCompany.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRCompany.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCompany.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRCompanyDB As New clsHRCompanyDB
                    setProperty(oForm, _clsHRCompanyDB)
                    _clsHRCompanyDB.Update()
                    TotalRow(oForm)
                End If
                .txtIDCompany.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                           " a.IDCompany,a.CompanyName,a.Business,a.TaxCode,a.Address,a.Telephone,a.MobilePhone,a.Faxes," & _
                                                                                           "a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.HRManager,a.Description," & _
                                                                                           "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName,e.IDBank,e.BankName,a.AccountNumber", _
                                                                                      "FROM HRCompany a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                                                                       "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                                                                       "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                                                                                       "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_ACC) & "ACCBank e ON e.IDBank=a.IDBank " & _
                                                                                      "ORDER BY a.IDCompany ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRCompanyDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRCompanyDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.IDCompany", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.CompanyName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.Business", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.TaxCode", .txtSearch.Text.Trim)
                    Case 7
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.Address", .txtSearch.Text.Trim)
                    Case 8
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.DirectorName", .txtSearch.Text.Trim)
                    Case 9
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.ChiefAccountant", .txtSearch.Text.Trim)
                    Case 10
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.HRManager", .txtSearch.Text.Trim)
                    Case 11
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "b.CountryName", .txtSearch.Text.Trim)
                    Case 12
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "c.CityName", .txtSearch.Text.Trim)
                    Case 13
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "d.DistrictName", .txtSearch.Text.Trim)
                    Case 14
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "e.BankName", .txtSearch.Text.Trim)
                    Case 15
                        .gridControlTable2.DataSource = _clsHRCompanyDB.Search(, .txtNumRecord.EditValue, "a.AccountNumber", .txtSearch.Text.Trim)
                End Select
                _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing
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
    Public Shared Sub ItemPopupSearch4(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsACCBankDB As New clsACCBankDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlPopup3.DataSource = _clsACCBankDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                            " a.IDBank,a.BankName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                                            "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description," & _
                                                                                            "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName " & _
                                                                                     "FROM ACCBank a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                                                                    "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                                                                    "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                                                                     "ORDER BY a.IDBank ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup3.DataSource = _clsACCBankDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup3.DataSource = _clsACCBankDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
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
End Class
