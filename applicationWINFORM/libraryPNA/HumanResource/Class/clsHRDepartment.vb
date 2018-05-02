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
Public Class clsHRDepartment
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRDepartment.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRDepartment.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRDepartment.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRDepartment.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRDepartment.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRDepartment.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRDepartment.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRDepartment.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRDepartment.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRDepartment.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRDepartment.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRDepartment.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRDepartment.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRDepartment.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRDepartment.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRDepartment.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRDepartment.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRDepartment.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRDepartment.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRDepartment.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRDepartment.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRDepartment.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRDepartment.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRDepartment.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRDepartment.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRDepartment.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRDepartment.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRDepartment.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRDepartment.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRDepartment.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRDepartment.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRDepartment.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRDepartment.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRDepartment.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRDepartment.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRDepartment.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRDepartment.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDDepartment.Text = GetLang("HRDepartment.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRDepartment.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRDepartment.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRDepartment.xml", 38, intLang, DirLang.HR)
                .lblCompany.Text = GetLang("HRDepartment.xml", 39, intLang, DirLang.HR)
                .lblManager.Text = GetLang("HRDepartment.xml", 40, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRDepartment.xml", 41, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRDepartment.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRDepartment.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRDepartment.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRDepartment.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRDepartment.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRDepartment.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRDepartment.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRDepartment.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRDepartment.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRDepartment.xml", 40, intLang, DirLang.HR), _
                                                                   GetLang("HRDepartment.xml", 41, intLang, DirLang.HR), _
                                                                   GetLang("HRDepartment.xml", 39, intLang, DirLang.HR)})
                .cboSearch.SelectedIndex = 0

                .gridViewtable1.Columns("IDDepartment").Caption = Replace(GetLang("HRDepartment.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("DepartmentName").Caption = Replace(GetLang("HRDepartment.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("Manager").Caption = GetLang("HRDepartment.xml", 40, intLang, DirLang.HR)
                .gridViewtable1.Columns("Description").Caption = GetLang("HRDepartment.xml", 41, intLang, DirLang.HR)
                .gridViewtable1.Columns("CompanyName").Caption = GetLang("HRDepartment.xml", 39, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDDepartment").Caption = Replace(GetLang("HRDepartment.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("DepartmentName").Caption = Replace(GetLang("HRDepartment.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("Manager").Caption = GetLang("HRDepartment.xml", 40, intLang, DirLang.HR)
                .gridViewtable2.Columns("Description").Caption = GetLang("HRDepartment.xml", 41, intLang, DirLang.HR)
                .gridViewtable2.Columns("CompanyName").Caption = GetLang("HRDepartment.xml", 39, intLang, DirLang.HR)
                'Popup
                .lblPopupViewRecord.Text = GetLang("HRDepartment.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh.ToolTipText = GetLang("HRDepartment.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd.ToolTipText = GetLang("HRDepartment.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect.ToolTipText = GetLang("HRDepartment.xml", 45, intLang, DirLang.HR)
                .btnPopupExport.ToolTipText = GetLang("HRDepartment.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp.ToolTipText = GetLang("HRDepartment.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch.Text = GetLang("HRDepartment.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch.Text = GetLang("HRDepartment.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup.Properties.Items.Clear()
                .rdoGroupPopup.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRCompany.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRCompany.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRCompany.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRCompany.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRCompany.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("HRCompany.xml", 39, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(6, GetLang("HRCompany.xml", 40, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(7, GetLang("HRCompany.xml", 46, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(8, GetLang("HRCompany.xml", 52, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(9, GetLang("HRCompany.xml", 53, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(10, GetLang("HRCompany.xml", 54, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(11, GetLang("HRCompany.xml", 41, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(11, GetLang("HRCompany.xml", 42, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(11, GetLang("HRCompany.xml", 43, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(11, GetLang("HRCompany.xml", 44, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(12, GetLang("HRCompany.xml", 45, intLang, DirLang.HR))})
                .rdoGroupPopup.SelectedIndex = 0

                .gridViewPopup.Columns("IDCompany").Caption = Replace(GetLang("HRCompany.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("CompanyName").Caption = Replace(GetLang("HRCompany.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("Business").Caption = GetLang("HRCompany.xml", 39, intLang, DirLang.HR)
                .gridViewPopup.Columns("TaxCode").Caption = GetLang("HRCompany.xml", 40, intLang, DirLang.HR)
                .gridViewPopup.Columns("Address").Caption = GetLang("HRCompany.xml", 46, intLang, DirLang.HR)
                .gridViewPopup.Columns("Telephone").Caption = GetLang("HRCompany.xml", 47, intLang, DirLang.HR)
                .gridViewPopup.Columns("MobilePhone").Caption = GetLang("HRCompany.xml", 48, intLang, DirLang.HR)
                .gridViewPopup.Columns("Faxes").Caption = GetLang("HRCompany.xml", 49, intLang, DirLang.HR)
                .gridViewPopup.Columns("WebPage").Caption = GetLang("HRCompany.xml", 50, intLang, DirLang.HR)
                .gridViewPopup.Columns("Email").Caption = GetLang("HRCompany.xml", 51, intLang, DirLang.HR)
                .gridViewPopup.Columns("DirectorName").Caption = GetLang("HRCompany.xml", 52, intLang, DirLang.HR)
                .gridViewPopup.Columns("ChiefAccountant").Caption = GetLang("HRCompany.xml", 53, intLang, DirLang.HR)
                .gridViewPopup.Columns("HRManager").Caption = GetLang("HRCompany.xml", 54, intLang, DirLang.HR)
                .gridViewPopup.Columns("Description").Caption = GetLang("HRCompany.xml", 55, intLang, DirLang.HR)
                .gridViewPopup.Columns("CountryName").Caption = GetLang("HRCompany.xml", 41, intLang, DirLang.HR)
                .gridViewPopup.Columns("CityName").Caption = GetLang("HRCompany.xml", 42, intLang, DirLang.HR)
                .gridViewPopup.Columns("DistrictName").Caption = GetLang("HRCompany.xml", 43, intLang, DirLang.HR)
                .gridViewPopup.Columns("BankName").Caption = GetLang("HRCompany.xml", 44, intLang, DirLang.HR)
                .gridViewPopup.Columns("AccountNumber").Caption = GetLang("HRCompany.xml", 45, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .toolbarPopup.Visible = True
                .txtIDDepartment.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .cboPopupCompany.Enabled = Not boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtManager.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRDepartmentDB As clsHRDepartmentDB)
        Try
            With oForm
                _clsHRDepartmentDB.IDCompany = .strIDCompany
                _clsHRDepartmentDB.CompanyName = .strCompanyName
                _clsHRDepartmentDB.IDDepartment = .txtIDDepartment.Text.Trim
                _clsHRDepartmentDB.DepartmentName = .txtName.Text.Trim
                _clsHRDepartmentDB.Manager = .txtManager.Text.Trim
                _clsHRDepartmentDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRDepartmentDB As clsHRDepartmentDB)
        Try
            With oForm
                .strIDCompany = _clsHRDepartmentDB.IDCompany
                .strCompanyName = _clsHRDepartmentDB.CompanyName
                .txtIDDepartment.Text = _clsHRDepartmentDB.IDDepartment
                If vb.Left(.txtIDDepartment.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRDepartmentDB.DepartmentName
                .txtManager.Text = _clsHRDepartmentDB.Manager
                .txtDescription.Text = _clsHRDepartmentDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDDepartment.Text = ""
                    .txtName.Text = ""
                    .txtManager.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .strIDCompany = .gridViewtable1.GetFocusedRowCellValue("IDCompany").ToString
                .strCompanyName = .gridViewtable1.GetFocusedRowCellValue("CompanyName").ToString
                .cboPopupCompany.Text = .gridViewtable1.GetFocusedRowCellValue("CompanyName").ToString
                .txtIDDepartment.Text = .gridViewtable1.GetFocusedRowCellValue("IDDepartment").ToString
                If vb.Left(.txtIDDepartment.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("DepartmentName").ToString
                .txtManager.Text = .gridViewtable1.GetFocusedRowCellValue("Manager").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .strIDCompany = .gridViewtable2.GetFocusedRowCellValue("IDCompany").ToString
                .strCompanyName = .gridViewtable2.GetFocusedRowCellValue("CompanyName").ToString
                .cboPopupCompany.Text = .gridViewtable2.GetFocusedRowCellValue("CompanyName").ToString
                .txtIDDepartment.Text = .gridViewtable2.GetFocusedRowCellValue("IDDepartment").ToString
                If vb.Left(.txtIDDepartment.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("DepartmentName").ToString
                .txtManager.Text = .gridViewtable2.GetFocusedRowCellValue("Manager").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:getRowGrid2)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setWidthHeaderGrid1(ByVal oForm As Object)
        Try
            With oForm
                .gridViewtable1.OptionsCustomization.AllowColumnMoving = False
                .gridViewtable1.OptionsFilter.AllowFilterEditor = False
                .gridViewtable1.OptionsBehavior.Editable = False
                .gridViewtable1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewtable1.OptionsView.ColumnAutoWidth = False
                .gridViewtable1.Columns("IDDepartment").Width = 130
                .gridViewtable1.Columns("DepartmentName").Width = 250
                .gridViewtable1.Columns("Manager").Width = 200
                .gridViewtable1.Columns("Description").Width = 350
                .gridViewtable1.Columns("IDCompany").Visible = False
                .gridViewtable1.Columns("CompanyName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDDepartment").Width = 130
                .gridViewtable2.Columns("DepartmentName").Width = 250
                .gridViewtable2.Columns("Manager").Width = 200
                .gridViewtable2.Columns("Description").Width = 350
                .gridViewtable2.Columns("IDCompany").Visible = False
                .gridViewtable2.Columns("CompanyName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setWidthHeaderGridPopup(ByVal oForm As Object)
        Try
            With oForm
                .gridViewPopup.OptionsCustomization.AllowColumnMoving = False
                .gridViewPopup.OptionsFilter.AllowFilterEditor = False
                .gridViewPopup.OptionsBehavior.Editable = False
                .gridViewPopup.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                .gridViewPopup.OptionsView.ColumnAutoWidth = False
                .gridViewPopup.Columns("IDCompany").Width = 130
                .gridViewPopup.Columns("CompanyName").Width = 250
                .gridViewPopup.Columns("Business").Width = 250
                .gridViewPopup.Columns("TaxCode").Width = 200
                .gridViewPopup.Columns("Address").Width = 300
                .gridViewPopup.Columns("Telephone").Width = 200
                .gridViewPopup.Columns("MobilePhone").Width = 200
                .gridViewPopup.Columns("Faxes").Width = 200
                .gridViewPopup.Columns("WebPage").Width = 200
                .gridViewPopup.Columns("Email").Width = 200
                .gridViewPopup.Columns("DirectorName").Width = 200
                .gridViewPopup.Columns("ChiefAccountant").Width = 200
                .gridViewPopup.Columns("HRManager").Width = 200
                .gridViewPopup.Columns("Description").Width = 200
                .gridViewPopup.Columns("IDCountry").Visible = False
                .gridViewPopup.Columns("CountryName").Width = 200
                .gridViewPopup.Columns("IDCity").Visible = False
                .gridViewPopup.Columns("CityName").Width = 200
                .gridViewPopup.Columns("IDDistrict").Visible = False
                .gridViewPopup.Columns("DistrictName").Width = 200
                .gridViewPopup.Columns("IDBank").Visible = False
                .gridViewPopup.Columns("BankName").Width = 200
                .gridViewPopup.Columns("AccountNumber").Width = 200
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCompany:setWidthHeaderGridPopup)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRDepartmentDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRDepartment.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
                'Popup
                Dim intTotalRow = clsHRCompanyDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord.EditValue = 50
                Else
                    .txtPopupNumRecord.EditValue = intTotalRow
                End If
                .lblPopupSumRecord.Text = GetLang("HRDepartment.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                .cboPopupCompany.Properties.PopupControl = .pnlPopupSearch

                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRDepartmentDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing

                _clsHRDepartmentDB = New clsHRDepartmentDB
                .gridControlTable2.DataSource = _clsHRDepartmentDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing

                'Popup
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                .gridControlPopup.DataSource = _clsHRCompanyDB.QueryTable(, .txtPopupNumRecord.EditValue)
                setWidthHeaderGridPopup(oForm)
                _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)

            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:LoadForm)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub Undo(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then Exit Sub
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRDepartmentDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRDepartmentDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRDepartment.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRDepartment.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDDepartment.Text = clsHRDepartmentDB.AutoID
                    .txtIDDepartment.Properties.ReadOnly = True
                Else
                    .txtIDDepartment.Text = ""
                    .txtIDDepartment.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtManager.Text = ""
                .txtDescription.Text = ""
                Try
                    .picPicture.Image = Nothing
                Catch ex As Exception
                End Try
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRDepartment.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRDepartment.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRDepartmentDB.IsExist(.txtIDDepartment.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRDepartment.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRDepartment.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRDepartmentDB.Delete(.txtIDDepartment.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDDepartment.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRDepartment.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRDepartment.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDDepartment.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDDepartment.Text.Trim = "" Then
                s = GetLang("HRDepartment.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRDepartment.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRDepartment.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRDepartment.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRDepartment.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDDepartment.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRDepartment.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRDepartment.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If .cboPopupCompany.Text = "" Then
                ShowMessage(oForm, GetLang("HRDepartment.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRDepartment.xml", 39, .intLang, DirLang.HR) & " " & GetLang("HRDepartment.xml", 36, .intLang, DirLang.HR), _
                            .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRDepartment.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRDepartment.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRDepartmentDB.IsExist(.txtIDDepartment.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRDepartment.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRDepartment.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                    setProperty(oForm, _clsHRDepartmentDB)
                    If clsHRDepartmentDB.IsExist(.txtIDDepartment.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRDepartment.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRDepartment.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRDepartmentDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRDepartment.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRDepartment.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRDepartment.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRDepartment.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                    setProperty(oForm, _clsHRDepartmentDB)
                    _clsHRDepartmentDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDDepartment", .txtIDDepartment.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "DepartmentName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Manager", .txtManager.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDDepartment.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRDepartmentDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                                 " a.IDDepartment,a.DepartmentName,a.Manager,a.Description,b.IDCompany,b.CompanyName " & _
                                                                                          "FROM HRDepartment a,HRCompany b " & _
                                                                                          "WHERE a.IDCompany=b.IDCompany " & _
                                                                                          "ORDER BY IDDepartment ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRDepartmentDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRDepartmentDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRDepartmentDB.Search(, .txtNumRecord.EditValue, "a.IDDepartment", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRDepartmentDB.Search(, .txtNumRecord.EditValue, "a.DepartmentName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRDepartmentDB.Search(, .txtNumRecord.EditValue, "a.Manager", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsHRDepartmentDB.Search(, .txtNumRecord.EditValue, "a.Description", .txtSearch.Text.Trim)
                    Case 7
                        .gridControlTable2.DataSource = _clsHRDepartmentDB.Search(, .txtNumRecord.EditValue, "b.CompanyName", .txtSearch.Text.Trim)
                End Select
                _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    'Popup
    Public Shared Sub ItemPopupSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCompanyDB As New clsHRCompanyDB
                Select Case .rdoGroupPopup.SelectedIndex
                    Case 0
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord.EditValue & _
                                                                                           " a.IDCompany,a.CompanyName,a.Business,a.TaxCode,a.Address,a.Telephone,a.MobilePhone,a.Faxes," & _
                                                                                           "a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.HRManager,a.Description," & _
                                                                                           "b.IDCountry,b.CountryName,a.IDDepartment,c.DepartmentName,d.IDDistrict,d.DistrictName,e.IDBank,e.BankName,a.AccountNumber", _
                                                                                      "FROM HRCompany a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                                                                       "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDepartment c ON c.IDDepartment=a.IDDepartment " & _
                                                                                                       "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                                                                                       "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_ACC) & "ACCBank e ON e.IDBank=a.IDBank " & _
                                                                                      "ORDER BY a.IDCompany ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup.DataSource = _clsHRCompanyDB.SearchCondition(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup.DataSource = _clsHRCompanyDB.SearchQuery(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.IDCompany", .txtPopupSearch.Text.Trim)
                    Case 4
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.CompanyName", .txtPopupSearch.Text.Trim)
                    Case 5
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.Business", .txtPopupSearch.Text.Trim)
                    Case 6
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.TaxCode", .txtPopupSearch.Text.Trim)
                    Case 7
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.Address", .txtPopupSearch.Text.Trim)
                    Case 8
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.DirectorName", .txtPopupSearch.Text.Trim)
                    Case 9
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.ChiefAccountant", .txtPopupSearch.Text.Trim)
                    Case 10
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.HRManager", .txtPopupSearch.Text.Trim)
                    Case 11
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "b.CountryName", .txtPopupSearch.Text.Trim)
                    Case 12
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "c.DepartmentName", .txtPopupSearch.Text.Trim)
                    Case 13
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "d.DistrictName", .txtPopupSearch.Text.Trim)
                    Case 14
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "e.BankName", .txtPopupSearch.Text.Trim)
                    Case 15
                        .gridControlPopup.DataSource = _clsHRCompanyDB.Search(, .txtPopupNumRecord.EditValue, "a.AccountNumber", .txtPopupSearch.Text.Trim)
                End Select
                _clsHRCompanyDB.UnsetCompany() : _clsHRCompanyDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
