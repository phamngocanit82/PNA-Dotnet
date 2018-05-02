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
Public Class clsHRJobtitle
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRJobtitle.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRJobtitle.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRJobtitle.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRJobtitle.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRJobtitle.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRJobtitle.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRJobtitle.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRJobtitle.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRJobtitle.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRJobtitle.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRJobtitle.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRJobtitle.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRJobtitle.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRJobtitle.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRJobtitle.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRJobtitle.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRJobtitle.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRJobtitle.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRJobtitle.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRJobtitle.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRJobtitle.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRJobtitle.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRJobtitle.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRJobtitle.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRJobtitle.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRJobtitle.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRJobtitle.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRJobtitle.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRJobtitle.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRJobtitle.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRJobtitle.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRJobtitle.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRJobtitle.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRJobtitle.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRJobtitle.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRJobtitle.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRJobtitle.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDJobtitle.Text = GetLang("HRJobtitle.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRJobtitle.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRJobtitle.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRJobtitle.xml", 38, intLang, DirLang.HR)
                .lblDepartment.Text = GetLang("HRJobtitle.xml", 39, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRJobtitle.xml", 40, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRJobtitle.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRJobtitle.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRJobtitle.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRJobtitle.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRJobtitle.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRJobtitle.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRJobtitle.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRJobtitle.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRJobtitle.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRJobtitle.xml", 40, intLang, DirLang.HR), _
                                                                   GetLang("HRJobtitle.xml", 39, intLang, DirLang.HR)})
                .cboSearch.SelectedIndex = 0

                .gridViewtable1.Columns("IDJobtitle").Caption = Replace(GetLang("HRJobtitle.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("JobtitleName").Caption = Replace(GetLang("HRJobtitle.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("HRJobtitle.xml", 40, intLang, DirLang.HR)
                .gridViewtable1.Columns("DepartmentName").Caption = GetLang("HRJobtitle.xml", 39, intLang, DirLang.HR)
                .gridViewtable1.Columns("CompanyName").Caption = GetLang("HRJobtitle.xml", 45, intLang, DirLang.HR)


                .gridViewtable2.Columns("IDJobtitle").Caption = Replace(GetLang("HRJobtitle.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("JobtitleName").Caption = Replace(GetLang("HRJobtitle.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("HRJobtitle.xml", 40, intLang, DirLang.HR)
                .gridViewtable2.Columns("DepartmentName").Caption = GetLang("HRJobtitle.xml", 39, intLang, DirLang.HR)
                .gridViewtable2.Columns("CompanyName").Caption = GetLang("HRJobtitle.xml", 45, intLang, DirLang.HR)
                'Popup
                .lblPopupViewRecord.Text = GetLang("HRJobtitle.xml", 41, intLang, DirLang.HR)
                .btnPopupRefesh.ToolTipText = GetLang("HRJobtitle.xml", 43, intLang, DirLang.HR)
                .btnPopupAdd.ToolTipText = GetLang("HRJobtitle.xml", 3, intLang, DirLang.HR)
                .btnPopupSelect.ToolTipText = GetLang("HRJobtitle.xml", 44, intLang, DirLang.HR)
                .btnPopupExport.ToolTipText = GetLang("HRJobtitle.xml", 14, intLang, DirLang.HR)
                .btnPopupHelp.ToolTipText = GetLang("HRJobtitle.xml", 15, intLang, DirLang.HR)
                .lblPopupSearch.Text = GetLang("HRJobtitle.xml", 18, intLang, DirLang.HR)
                .btnPopupSearch.Text = GetLang("HRJobtitle.xml", 18, intLang, DirLang.HR)

                .rdoGroupPopup.Properties.Items.Clear()
                .rdoGroupPopup.Properties.Items.AddRange(New RadioGroupItem() _
                                                             {New RadioGroupItem(0, GetLang("HRDepartment.xml", 19, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(1, GetLang("HRDepartment.xml", 20, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(2, GetLang("HRDepartment.xml", 21, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(3, Replace(GetLang("HRDepartment.xml", 33, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(4, Replace(GetLang("HRDepartment.xml", 38, intLang, DirLang.HR), "(*)", "")), _
                                                              New RadioGroupItem(6, GetLang("HRDepartment.xml", 40, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(7, GetLang("HRDepartment.xml", 41, intLang, DirLang.HR)), _
                                                              New RadioGroupItem(12, GetLang("HRDepartment.xml", 39, intLang, DirLang.HR))})
                .rdoGroupPopup.SelectedIndex = 0

                .gridViewPopup.Columns("IDDepartment").Caption = Replace(GetLang("HRDepartment.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("DepartmentName").Caption = Replace(GetLang("HRDepartment.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewPopup.Columns("Manager").Caption = GetLang("HRDepartment.xml", 40, intLang, DirLang.HR)
                .gridViewPopup.Columns("Description").Caption = GetLang("HRDepartment.xml", 41, intLang, DirLang.HR)
                .gridViewPopup.Columns("CompanyName").Caption = GetLang("HRDepartment.xml", 39, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .toolbarPopup.Visible = True
                .txtIDJobtitle.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .cboPopupDepartment.Enabled = Not boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRJobtitleDB As clsHRJobtitleDB)
        Try
            With oForm
                _clsHRJobtitleDB.IDDepartment = .strIDDepartment
                _clsHRJobtitleDB.DepartmentName = .strDepartmentName
                _clsHRJobtitleDB.IDJobtitle = .txtIDJobtitle.Text.Trim
                _clsHRJobtitleDB.JobtitleName = .txtName.Text.Trim
                _clsHRJobtitleDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRJobtitleDB As clsHRJobtitleDB)
        Try
            With oForm
                .strIDDepartment = _clsHRJobtitleDB.IDDepartment
                .strDepartmentName = _clsHRJobtitleDB.DepartmentName
                .txtIDJobtitle.Text = _clsHRJobtitleDB.IDJobtitle
                If vb.Left(.txtIDJobtitle.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRJobtitleDB.JobtitleName
                .txtDescription.Text = _clsHRJobtitleDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDJobtitle.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .strIDDepartment = .gridViewtable1.GetFocusedRowCellValue("IDDepartment").ToString
                .strDepartmentName = .gridViewtable1.GetFocusedRowCellValue("DepartmentName").ToString
                .cboPopupDepartment.Text = .gridViewtable1.GetFocusedRowCellValue("DepartmentName").ToString
                .txtIDJobtitle.Text = .gridViewtable1.GetFocusedRowCellValue("IDJobtitle").ToString
                If vb.Left(.txtIDJobtitle.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("JobtitleName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .strIDDepartment = .gridViewtable2.GetFocusedRowCellValue("IDDepartment").ToString
                .strDepartmentName = .gridViewtable2.GetFocusedRowCellValue("DepartmentName").ToString
                .cboPopupDepartment.Text = .gridViewtable2.GetFocusedRowCellValue("DepartmentName").ToString
                .txtIDJobtitle.Text = .gridViewtable2.GetFocusedRowCellValue("IDJobtitle").ToString
                If vb.Left(.txtIDJobtitle.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("JobtitleName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDJobtitle").Width = 130
                .gridViewtable1.Columns("JobtitleName").Width = 250
                .gridViewtable1.Columns("Description").Width = 300
                .gridViewtable1.Columns("IDDepartment").Visible = False
                .gridViewtable1.Columns("DepartmentName").Width = 250
                .gridViewtable1.Columns("CompanyName").Width = 250
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDJobtitle").Width = 130
                .gridViewtable2.Columns("JobtitleName").Width = 250
                .gridViewtable2.Columns("Description").Width = 300
                .gridViewtable2.Columns("IDDepartment").Visible = False
                .gridViewtable2.Columns("DepartmentName").Width = 250
                .gridViewtable2.Columns("CompanyName").Width = 250
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewPopup.Columns("IDDepartment").Width = 130
                .gridViewPopup.Columns("DepartmentName").Width = 250
                .gridViewPopup.Columns("Manager").Width = 200
                .gridViewPopup.Columns("Description").Width = 350
                .gridViewPopup.Columns("IDCompany").Visible = False
                .gridViewPopup.Columns("CompanyName").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRDepartment:setWidthHeaderGridPopup)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRJobtitleDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRJobtitle.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
                'Popup
                Dim intTotalRow = clsHRDepartmentDB.TotalRow()
                If intTotalRow > 50 Then
                    .txtPopupNumRecord.EditValue = 50
                Else
                    .txtPopupNumRecord.EditValue = intTotalRow
                End If
                .lblPopupSumRecord.Text = GetLang("HRJobtitle.xml", 42, .intLang, DirLang.HR) & "( " & intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRJobtitleDB As New clsHRJobtitleDB
                .cboPopupDepartment.Properties.PopupControl = .pnlPopupSearch

                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRJobtitleDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRJobtitleDB.UnsetJobtitle() : _clsHRJobtitleDB = Nothing

                _clsHRJobtitleDB = New clsHRJobtitleDB
                .gridControlTable2.DataSource = _clsHRJobtitleDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRJobtitleDB.UnsetJobtitle() : _clsHRJobtitleDB = Nothing

                'Popup
                Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                .gridControlPopup.DataSource = _clsHRDepartmentDB.QueryTable(, .txtPopupNumRecord.EditValue)
                setWidthHeaderGridPopup(oForm)
                _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)

            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRJobtitleDB As New clsHRJobtitleDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRJobtitleDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRJobtitleDB.UnsetJobtitle() : _clsHRJobtitleDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRJobtitleDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRJobtitleDB.UnsetJobtitle() : _clsHRJobtitleDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRJobtitle.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRJobtitle.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDJobtitle.Text = clsHRJobtitleDB.AutoID
                    .txtIDJobtitle.Properties.ReadOnly = True
                Else
                    .txtIDJobtitle.Text = ""
                    .txtIDJobtitle.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRJobtitle.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRJobtitle.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRJobtitleDB.IsExist(.txtIDJobtitle.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRJobtitle.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRJobtitle.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRJobtitleDB.Delete(.txtIDJobtitle.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDJobtitle.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRJobtitle.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRJobtitle.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDJobtitle.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDJobtitle.Text.Trim = "" Then
                s = GetLang("HRJobtitle.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRJobtitle.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRJobtitle.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRJobtitle.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRJobtitle.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDJobtitle.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRJobtitle.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRJobtitle.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If .cboPopupDepartment.Text = "" Then
                ShowMessage(oForm, GetLang("HRJobtitle.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRJobtitle.xml", 39, .intLang, DirLang.HR) & " " & GetLang("HRJobtitle.xml", 36, .intLang, DirLang.HR), _
                            .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRJobtitle.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRJobtitle.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRJobtitleDB.IsExist(.txtIDJobtitle.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRJobtitle.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRJobtitle.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRJobtitleDB As New clsHRJobtitleDB
                    setProperty(oForm, _clsHRJobtitleDB)
                    If clsHRJobtitleDB.IsExist(.txtIDJobtitle.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRJobtitle.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRJobtitle.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRJobtitleDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRJobtitle.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRJobtitle.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRJobtitle.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRJobtitle.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRJobtitleDB As New clsHRJobtitleDB
                    setProperty(oForm, _clsHRJobtitleDB)
                    _clsHRJobtitleDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDJobtitle", .txtIDJobtitle.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "JobtitleName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDJobtitle.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRJobtitle:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRJobtitleDB As New clsHRJobtitleDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRJobtitleDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                                " a.IDJobtitle,a.JobtitleName,a.Description,b.IDDepartment,b.DepartmentName,c.CompanyName " & _
                                                                                        "FROM HRJobtitle a,HRDepartment b,HRCompany c " & _
                                                                                        "WHERE a.IDDepartment=b.IDDepartment AND c.IDCompany=b.IDCompany " & _
                                                                                        "ORDER BY IDJobtitle ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRJobtitleDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRJobtitleDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRJobtitleDB.Search(, .txtNumRecord.EditValue, "a.IDJobtitle", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRJobtitleDB.Search(, .txtNumRecord.EditValue, "a.JobtitleName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRJobtitleDB.Search(, .txtNumRecord.EditValue, "a.Description", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsHRJobtitleDB.Search(, .txtNumRecord.EditValue, "b.DepartmentName", .txtSearch.Text.Trim)
                End Select
                _clsHRJobtitleDB.UnsetJobtitle() : _clsHRJobtitleDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
    'Popup
    Public Shared Sub ItemPopupSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRDepartmentDB As New clsHRDepartmentDB
                Select Case .rdoGroupPopup.SelectedIndex
                    Case 0
                        .gridControlPopup.DataSource = _clsHRDepartmentDB.Search(, , , , "SELECT TOP " & .txtPopupNumRecord.EditValue & _
                                                                                                 " a.IDDepartment,a.DepartmentName,a.Manager,a.Description,b.IDCompany,b.CompanyName " & _
                                                                                          "FROM HRDepartment a,HRCompany b " & _
                                                                                          "WHERE a.IDCompany=b.IDCompany " & _
                                                                                          "ORDER BY IDDepartment ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlPopup.DataSource = _clsHRDepartmentDB.SearchCondition(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlPopup.DataSource = _clsHRDepartmentDB.SearchQuery(, .txtPopupNumRecord.EditValue, .txtPopupSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlPopup.DataSource = _clsHRDepartmentDB.Search(, .txtPopupNumRecord.EditValue, "a.IDDepartment", .txtPopupSearch.Text.Trim)
                    Case 4
                        .gridControlPopup.DataSource = _clsHRDepartmentDB.Search(, .txtPopupNumRecord.EditValue, "a.DepartmentName", .txtPopupSearch.Text.Trim)
                    Case 5
                        .gridControlPopup.DataSource = _clsHRDepartmentDB.Search(, .txtPopupNumRecord.EditValue, "a.Manager", .txtPopupSearch.Text.Trim)
                    Case 6
                        .gridControlPopup.DataSource = _clsHRDepartmentDB.Search(, .txtPopupNumRecord.EditValue, "a.Description", .txtPopupSearch.Text.Trim)
                    Case 7
                        .gridControlPopup.DataSource = _clsHRDepartmentDB.Search(, .txtPopupNumRecord.EditValue, "b.CompanyName", .txtPopupSearch.Text.Trim)
                End Select
                _clsHRDepartmentDB.UnsetDepartment() : _clsHRDepartmentDB = Nothing

            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
