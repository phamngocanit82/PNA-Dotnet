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
Public Class clsHRCity
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRCity.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRCity.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRCity.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRCity.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRCity.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRCity.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRCity.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRCity.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRCity.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRCity.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRCity.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRCity.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRCity.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRCity.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRCity.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRCity.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRCity.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRCity.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRCity.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRCity.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRCity.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRCity.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRCity.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRCity.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRCity.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRCity.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRCity.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRCity.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRCity.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRCity.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRCity.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRCity.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRCity.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRCity.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRCity.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRCity.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRCity.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDCity.Text = GetLang("HRCity.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRCity.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRCity.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRCity.xml", 38, intLang, DirLang.HR)
                .lblCountry.Text = GetLang("HRCity.xml", 39, intLang, DirLang.HR)
                .lblCityCode.Text = GetLang("HRCity.xml", 40, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRCity.xml", 41, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRCity.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRCity.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRCity.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRCity.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRCity.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRCity.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRCity.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRCity.xml", 40, intLang, DirLang.HR), _
                                                                   GetLang("HRCity.xml", 41, intLang, DirLang.HR), _
                                                                   GetLang("HRCity.xml", 39, intLang, DirLang.HR)})
                .cboSearch.SelectedIndex = 0

                .gridViewtable1.Columns("IDCity").Caption = Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("CityName").Caption = Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("CityCode").Caption = GetLang("HRCity.xml", 40, intLang, DirLang.HR)
                .gridViewtable1.Columns("Description").Caption = GetLang("HRCity.xml", 41, intLang, DirLang.HR)
                .gridViewtable1.Columns("CountryName").Caption = GetLang("HRCity.xml", 39, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDCity").Caption = Replace(GetLang("HRCity.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("CityName").Caption = Replace(GetLang("HRCity.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("CityCode").Caption = GetLang("HRCity.xml", 40, intLang, DirLang.HR)
                .gridViewtable2.Columns("Description").Caption = GetLang("HRCity.xml", 41, intLang, DirLang.HR)
                .gridViewtable2.Columns("CountryName").Caption = GetLang("HRCity.xml", 39, intLang, DirLang.HR)
                'Popup
                .lblPopupViewRecord.Text = GetLang("HRCity.xml", 42, intLang, DirLang.HR)
                .btnPopupRefesh.ToolTipText = GetLang("HRCity.xml", 44, intLang, DirLang.HR)
                .btnPopupAdd.ToolTipText = GetLang("HRCity.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect.ToolTipText = GetLang("HRCity.xml", 45, intLang, DirLang.HR)
                .btnPopupExport.ToolTipText = GetLang("HRCity.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp.ToolTipText = GetLang("HRCity.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch.Text = GetLang("HRCity.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch.Text = GetLang("HRCity.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup.Properties.Items.Clear()
                .rdoGroupPopup.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRCountry.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRCountry.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRCountry.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(5, GetLang("HRCountry.xml", 39, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(6, GetLang("HRCountry.xml", 40, intLang, DirLang.HR))})
                .rdoGroupPopup.SelectedIndex = 0

                .gridViewPopup.Columns("IDCountry").Caption = Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("CountryName").Caption = Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("CountryCode").Caption = GetLang("HRCountry.xml", 39, intLang, DirLang.HR)
                .gridViewPopup.Columns("Description").Caption = GetLang("HRCountry.xml", 40, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .toolbarPopup.Visible = True
                .txtIDCity.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .cboPopupCountry.Enabled = Not boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtCityCode.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRCityDB As clsHRCityDB)
        Try
            With oForm
                _clsHRCityDB.IDCountry = .strIDCountry
                _clsHRCityDB.CountryName = .strCountryName
                _clsHRCityDB.IDCity = .txtIDCity.Text.Trim
                _clsHRCityDB.CityName = .txtName.Text.Trim
                _clsHRCityDB.CityCode = .txtCityCode.Text.Trim
                _clsHRCityDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRCityDB As clsHRCityDB)
        Try
            With oForm
                .strIDCountry = _clsHRCityDB.IDCountry
                .strCountryName = _clsHRCityDB.CountryName
                .txtIDCity.Text = _clsHRCityDB.IDCity
                If vb.Left(.txtIDCity.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRCityDB.CityName
                .txtCityCode.Text = _clsHRCityDB.CityCode
                .txtDescription.Text = _clsHRCityDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDCity.Text = ""
                    .txtName.Text = ""
                    .txtCityCode.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .strIDCountry = .gridViewtable1.GetFocusedRowCellValue("IDCountry").ToString
                .strCountryName = .gridViewtable1.GetFocusedRowCellValue("CountryName").ToString
                .cboPopupCountry.Text = .gridViewtable1.GetFocusedRowCellValue("CountryName").ToString
                .txtIDCity.Text = .gridViewtable1.GetFocusedRowCellValue("IDCity").ToString
                If vb.Left(.txtIDCity.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("CityName").ToString
                .txtCityCode.Text = .gridViewtable1.GetFocusedRowCellValue("CityCode").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .strIDCountry = .gridViewtable2.GetFocusedRowCellValue("IDCountry").ToString
                .strCountryName = .gridViewtable2.GetFocusedRowCellValue("CountryName").ToString
                .cboPopupCountry.Text = .gridViewtable2.GetFocusedRowCellValue("CountryName").ToString
                .txtIDCity.Text = .gridViewtable2.GetFocusedRowCellValue("IDCity").ToString
                If vb.Left(.txtIDCity.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("CityName").ToString
                .txtCityCode.Text = .gridViewtable2.GetFocusedRowCellValue("CityCode").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDCity").Width = 130
                .gridViewtable1.Columns("CityName").Width = 250
                .gridViewtable1.Columns("CityCode").Width = 130
                .gridViewtable1.Columns("Description").Width = 350
                .gridViewtable1.Columns("IDCountry").Visible = False
                .gridViewtable1.Columns("CountryName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDCity").Width = 130
                .gridViewtable2.Columns("CityName").Width = 250
                .gridViewtable2.Columns("CityCode").Width = 130
                .gridViewtable2.Columns("Description").Width = 350
                .gridViewtable2.Columns("IDCountry").Visible = False
                .gridViewtable2.Columns("CountryName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewPopup.Columns("IDCountry").Width = 130
                .gridViewPopup.Columns("CountryName").Width = 250
                .gridViewPopup.Columns("CountryCode").Width = 130
                .gridViewPopup.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setWidthHeaderGridPopup)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRCityDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRCity.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
                'Popup
                Dim intTotalRow = clsHRCountryDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord.EditValue = 50
                Else
                    .txtPopupNumRecord.EditValue = intTotalRow
                End If
                .lblPopupSumRecord.Text = GetLang("HRCity.xml", 43, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCityDB As New clsHRCityDB
                .cboPopupCountry.Properties.PopupControl = .pnlPopupSearch

                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRCityDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing

                _clsHRCityDB = New clsHRCityDB
                .gridControlTable2.DataSource = _clsHRCityDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing

                'Popup
                Dim _clsHRCountryDB As New clsHRCountryDB
                .gridControlPopup.DataSource = _clsHRCountryDB.QueryTable(, .txtPopupNumRecord.EditValue)
                setWidthHeaderGridPopup(oForm)
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)

            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCityDB As New clsHRCityDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRCityDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRCityDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRCity.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRCity.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDCity.Text = clsHRCityDB.AutoID
                    .txtIDCity.Properties.ReadOnly = True
                Else
                    .txtIDCity.Text = ""
                    .txtIDCity.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtCityCode.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRCity.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCity.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRCityDB.IsExist(.txtIDCity.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRCity.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRCity.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRCityDB.Delete(.txtIDCity.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDCity.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRCity.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCity.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDCity.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDCity.Text.Trim = "" Then
                s = GetLang("HRCity.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRCity.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRCity.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRCity.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDCity.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRCity.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If .cboPopupCountry.Text = "" Then
                ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRCity.xml", 39, .intLang, DirLang.HR) & " " & GetLang("HRCity.xml", 36, .intLang, DirLang.HR), _
                            .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRCity.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRCity.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRCityDB.IsExist(.txtIDCity.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCity.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRCityDB As New clsHRCityDB
                    setProperty(oForm, _clsHRCityDB)
                    If clsHRCityDB.IsExist(.txtIDCity.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRCity.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRCityDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRCity.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRCity.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRCity.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCity.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRCityDB As New clsHRCityDB
                    setProperty(oForm, _clsHRCityDB)
                    _clsHRCityDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDCity", .txtIDCity.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CityName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CityCode", .txtCityCode.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDCity.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCity:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCityDB As New clsHRCityDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRCityDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                          " a.IDCity,a.CityName,a.CityCode,a.Description,b.IDCountry,b.CountryName " & _
                                                                                    "FROM HRCity a,HRCountry b " & _
                                                                                    "WHERE a.IDCountry=b.IDCountry " & _
                                                                                    "ORDER BY IDCity ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRCityDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRCityDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRCityDB.Search(, .txtNumRecord.EditValue, "a.IDCity", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRCityDB.Search(, .txtNumRecord.EditValue, "a.CityName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRCityDB.Search(, .txtNumRecord.EditValue, "a.CityCode", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsHRCityDB.Search(, .txtNumRecord.EditValue, "a.Description", .txtSearch.Text.Trim)
                    Case 7
                        .gridControlTable2.DataSource = _clsHRCityDB.Search(, .txtNumRecord.EditValue, "b.CountryName", .txtSearch.Text.Trim)
                End Select
                _clsHRCityDB.UnsetCity() : _clsHRCityDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    'Popup
    Public Shared Sub ItemPopupSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCountryDB As New clsHRCountryDB
                Select Case .rdoGroupPopup.SelectedIndex
                    Case 0
                        .gridControlPopup.DataSource = _clsHRCountryDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord.EditValue & _
                                                                                       " IDCountry,CountryName,CountryCode,Description " & _
                                                                                       "FROM HRCountry " & _
                                                                                       "ORDER BY IDCountry ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup.DataSource = _clsHRCountryDB.SearchCondition(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup.DataSource = _clsHRCountryDB.SearchQuery(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord.EditValue, "IDCountry", .txtPopupSearch.Text.Trim)
                    Case 4
                        .gridControlPopup.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord.EditValue, "CountryName", .txtPopupSearch.Text.Trim)
                    Case 5
                        .gridControlPopup.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord.EditValue, "CountryCode", .txtPopupSearch.Text.Trim)
                    Case 6
                        .gridControlPopup.DataSource = _clsHRCountryDB.Search(, .txtPopupNumRecord.EditValue, "Description", .txtPopupSearch.Text.Trim)
                End Select
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
