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
Public Class clsHRDistrict
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRDistrict.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRDistrict.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRDistrict.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRDistrict.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRDistrict.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRDistrict.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRDistrict.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRDistrict.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRDistrict.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRDistrict.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRDistrict.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRDistrict.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRDistrict.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRDistrict.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRDistrict.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRDistrict.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRDistrict.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRDistrict.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRDistrict.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRDistrict.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRDistrict.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRDistrict.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRDistrict.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRDistrict.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRDistrict.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRDistrict.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRDistrict.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRDistrict.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRDistrict.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRDistrict.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRDistrict.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRDistrict.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRDistrict.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDDistrict.Text = GetLang("HRDistrict.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRDistrict.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRDistrict.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRDistrict.xml", 38, intLang, DirLang.HR)
                .lblCity.Text = GetLang("HRDistrict.xml", 39, intLang, DirLang.HR)
                .lblDistrictCode.Text = GetLang("HRDistrict.xml", 40, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRDistrict.xml", 41, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRDistrict.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRDistrict.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRDistrict.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRDistrict.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRDistrict.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRDistrict.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRDistrict.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRDistrict.xml", 40, intLang, DirLang.HR), _
                                                                   GetLang("HRDistrict.xml", 41, intLang, DirLang.HR), _
                                                                   GetLang("HRDistrict.xml", 39, intLang, DirLang.HR)})
                .cboSearch.SelectedIndex = 0

                .gridViewtable1.Columns("IDDistrict").Caption = Replace(GetLang("HRDistrict.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("DistrictName").Caption = Replace(GetLang("HRDistrict.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("DistrictCode").Caption = GetLang("HRDistrict.xml", 40, intLang, DirLang.HR)
                .gridViewtable1.Columns("Description").Caption = GetLang("HRDistrict.xml", 41, intLang, DirLang.HR)
                .gridViewtable1.Columns("CityName").Caption = GetLang("HRDistrict.xml", 39, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDDistrict").Caption = Replace(GetLang("HRDistrict.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("DistrictName").Caption = Replace(GetLang("HRDistrict.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("DistrictCode").Caption = GetLang("HRDistrict.xml", 40, intLang, DirLang.HR)
                .gridViewtable2.Columns("Description").Caption = GetLang("HRDistrict.xml", 41, intLang, DirLang.HR)
                .gridViewtable2.Columns("CityName").Caption = GetLang("HRDistrict.xml", 39, intLang, DirLang.HR)
                'Popup
                .lblPopupViewRecord.Text = GetLang("HRDistrict.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh.ToolTipText = GetLang("HRDistrict.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd.ToolTipText = GetLang("HRDistrict.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect.ToolTipText = GetLang("HRDistrict.xml", 45, intLang, DirLang.HR)
                .btnPopupExport.ToolTipText = GetLang("HRDistrict.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp.ToolTipText = GetLang("HRDistrict.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch.Text = GetLang("HRDistrict.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup.Properties.Items.Clear()
                .rdoGroupPopup.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRCity.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRCity.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRCity.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("HRCity.xml", 39, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(5, GetLang("HRCity.xml", 40, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(6, GetLang("HRCity.xml", 41, intLang, DirLang.HR))})
                .rdoGroupPopup.SelectedIndex = 0
                .gridViewPopup.Columns("IDCity").Caption = Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("CityName").Caption = Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("CityCode").Caption = GetLang("HRCity.xml", 40, intLang, DirLang.HR)
                .gridViewPopup.Columns("Description").Caption = GetLang("HRCity.xml", 41, intLang, DirLang.HR)
                .gridViewPopup.Columns("CountryName").Caption = GetLang("HRCity.xml", 39, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .toolbarPopup.Visible = True
                .txtIDDistrict.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .cboPopupCity.Enabled = Not boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtDistrictCode.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRDistrictDB As clsHRDistrictDB)
        Try
            With oForm
                _clsHRDistrictDB.IDCity = .strIDCity
                _clsHRDistrictDB.CityName = .strCityName
                _clsHRDistrictDB.IDDistrict = .txtIDDistrict.Text.Trim
                _clsHRDistrictDB.DistrictName = .txtName.Text.Trim
                _clsHRDistrictDB.DistrictCode = .txtDistrictCode.Text.Trim
                _clsHRDistrictDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRDistrictDB As clsHRDistrictDB)
        Try
            With oForm
                .strIDCity = _clsHRDistrictDB.IDCity
                .strCityName = _clsHRDistrictDB.CityName
                .txtIDDistrict.Text = _clsHRDistrictDB.IDDistrict
                If vb.Left(.txtIDDistrict.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRDistrictDB.DistrictName
                .txtDistrictCode.Text = _clsHRDistrictDB.DistrictCode
                .txtDescription.Text = _clsHRDistrictDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDDistrict.Text = ""
                    .txtName.Text = ""
                    .txtDistrictCode.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .strIDCity = .gridViewtable1.GetFocusedRowCellValue("IDCity").ToString
                .strCityName = .gridViewtable1.GetFocusedRowCellValue("CityName").ToString
                .cboPopupCity.Text = .gridViewtable1.GetFocusedRowCellValue("CityName").ToString
                .txtIDDistrict.Text = .gridViewtable1.GetFocusedRowCellValue("IDDistrict").ToString
                If vb.Left(.txtIDDistrict.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("DistrictName").ToString
                .txtDistrictCode.Text = .gridViewtable1.GetFocusedRowCellValue("DistrictCode").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .strIDCity = .gridViewtable2.GetFocusedRowCellValue("IDCity").ToString
                .strCityName = .gridViewtable2.GetFocusedRowCellValue("CityName").ToString
                .cboPopupCity.Text = .gridViewtable2.GetFocusedRowCellValue("CityName").ToString
                .txtIDDistrict.Text = .gridViewtable2.GetFocusedRowCellValue("IDDistrict").ToString
                If vb.Left(.txtIDDistrict.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("DistrictName").ToString
                .txtDistrictCode.Text = .gridViewtable2.GetFocusedRowCellValue("DistrictCode").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDDistrict").Width = 130
                .gridViewtable1.Columns("DistrictName").Width = 250
                .gridViewtable1.Columns("DistrictCode").Width = 130
                .gridViewtable1.Columns("Description").Width = 350
                .gridViewtable1.Columns("IDCity").Visible = False
                .gridViewtable1.Columns("CityName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDDistrict").Width = 130
                .gridViewtable2.Columns("DistrictName").Width = 250
                .gridViewtable2.Columns("DistrictCode").Width = 130
                .gridViewtable2.Columns("Description").Width = 350
                .gridViewtable2.Columns("IDCity").Visible = False
                .gridViewtable2.Columns("CityName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewPopup.Columns("IDCity").Width = 130
                .gridViewPopup.Columns("CityName").Width = 250
                .gridViewPopup.Columns("CityCode").Width = 130
                .gridViewPopup.Columns("Description").Width = 350
                .gridViewPopup.Columns("IDCountry").Visible = False
                .gridViewPopup.Columns("CountryName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setWidthHeaderGridPopup)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRDistrictDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRDistrict.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
                'Popup
                Dim intTotalRow = clsHRCityDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord.EditValue = 50
                Else
                    .txtPopupNumRecord.EditValue = intTotalRow
                End If
                .lblPopupSumRecord.Text = GetLang("HRDistrict.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDistrictDB As New clsHRDistrictDB
                .cboPopupCity.Properties.PopupControl = .pnlPopupSearch

                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRDistrictDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing

                _clsHRDistrictDB = New clsHRDistrictDB
                .gridControlTable2.DataSource = _clsHRDistrictDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing

                'Popup
                Dim _clsHRCityDB As New clsHRCityDB
                .gridControlPopup.DataSource = _clsHRCityDB.QueryTable(, .txtPopupNumRecord.EditValue)
                setWidthHeaderGridPopup(oForm)
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)

            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDistrictDB As New clsHRDistrictDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRDistrictDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRDistrictDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRDistrict.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRDistrict.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDDistrict.Text = clsHRDistrictDB.AutoID
                    .txtIDDistrict.Properties.ReadOnly = True
                Else
                    .txtIDDistrict.Text = ""
                    .txtIDDistrict.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtDistrictCode.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRDistrict.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRDistrict.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRDistrictDB.IsExist(.txtIDDistrict.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRDistrict.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRDistrict.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRDistrictDB.Delete(.txtIDDistrict.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDDistrict.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRDistrict.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRDistrict.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDDistrict.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDDistrict.Text.Trim = "" Then
                s = GetLang("HRDistrict.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRDistrict.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRDistrict.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRDistrict.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDDistrict.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRDistrict.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If .cboPopupCity.Text = "" Then
                ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRDistrict.xml", 39, .intLang, DirLang.HR) & " " & GetLang("HRDistrict.xml", 36, .intLang, DirLang.HR), _
                            .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRDistrict.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRDistrict.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRDistrictDB.IsExist(.txtIDDistrict.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRDistrict.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRDistrictDB As New clsHRDistrictDB
                    setProperty(oForm, _clsHRDistrictDB)
                    If clsHRDistrictDB.IsExist(.txtIDDistrict.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRDistrict.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRDistrictDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRDistrict.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRDistrict.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRDistrict.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRDistrict.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRDistrictDB As New clsHRDistrictDB
                    setProperty(oForm, _clsHRDistrictDB)
                    _clsHRDistrictDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDDistrict", .txtIDDistrict.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "DistrictName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "DistrictCode", .txtDistrictCode.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDDistrict.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDistrict:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDistrictDB As New clsHRDistrictDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRDistrictDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                              " a.IDDistrict,a.DistrictName,a.DistrictCode,a.Description,b.IDCity,b.CityName " & _
                                                                                        "FROM HRDistrict a,HRCity b " & _
                                                                                        "WHERE a.IDCity=b.IDCity " & _
                                                                                       "ORDER BY IDDistrict ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRDistrictDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRDistrictDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRDistrictDB.Search(, .txtNumRecord.EditValue, "a.IDDistrict", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRDistrictDB.Search(, .txtNumRecord.EditValue, "a.DistrictName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRDistrictDB.Search(, .txtNumRecord.EditValue, "a.DistrictCode", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsHRDistrictDB.Search(, .txtNumRecord.EditValue, "a.Description", .txtSearch.Text.Trim)
                    Case 7
                        .gridControlTable2.DataSource = _clsHRDistrictDB.Search(, .txtNumRecord.EditValue, "b.CityName", .txtSearch.Text.Trim)
                End Select
                _clsHRDistrictDB.UnsetDistrict() : _clsHRDistrictDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    'Popup
    Public Shared Sub ItemPopupSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCityDB As New clsHRCityDB
                Select Case .rdoGroupPopup.SelectedIndex
                    Case 0
                        .gridControlPopup.DataSource = _clsHRCityDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord.EditValue & _
                                                                                       " IDCity,CityName,CityCode,Description " & _
                                                                                       "FROM HRCity " & _
                                                                                       "ORDER BY IDCity ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup.DataSource = _clsHRCityDB.SearchCondition(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup.DataSource = _clsHRCityDB.SearchQuery(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord.EditValue, "IDCity", .txtPopupSearch.Text.Trim)
                    Case 4
                        .gridControlPopup.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord.EditValue, "CityName", .txtPopupSearch.Text.Trim)
                    Case 5
                        .gridControlPopup.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord.EditValue, "CountryName", .txtPopupSearch.Text.Trim)
                    Case 6
                        .gridControlPopup.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord.EditValue, "CityCode", .txtPopupSearch.Text.Trim)
                    Case 7
                        .gridControlPopup.DataSource = _clsHRCityDB.Search(, .txtPopupNumRecord.EditValue, "Description", .txtPopupSearch.Text.Trim)
                End Select
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
