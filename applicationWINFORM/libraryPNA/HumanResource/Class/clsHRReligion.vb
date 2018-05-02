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
Imports libraryPNA.clsSystem
Imports libraryPNA.clsMessage
Imports libraryPNA.clsError
Public Class clsHRReligion
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRReligion.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRReligion.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRReligion.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRReligion.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRReligion.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRReligion.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRReligion.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRReligion.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRReligion.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRReligion.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRReligion.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRReligion.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRReligion.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRReligion.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRReligion.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRReligion.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRReligion.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRReligion.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRReligion.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRReligion.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRReligion.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRReligion.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRReligion.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRReligion.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRReligion.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRReligion.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRReligion.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRReligion.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRReligion.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRReligion.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRReligion.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRReligion.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRReligion.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRReligion.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRReligion.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRReligion.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRReligion.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDReligion.Text = GetLang("HRReligion.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRReligion.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRReligion.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRReligion.xml", 38, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRReligion.xml", 39, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRReligion.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRReligion.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRReligion.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRReligion.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRReligion.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRReligion.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRReligion.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRReligion.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRReligion.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRReligion.xml", 39, intLang, DirLang.HR)})

                .gridViewtable1.Columns("IDReligion").Caption = Replace(GetLang("HRReligion.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("ReligionName").Caption = Replace(GetLang("HRReligion.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("HRReligion.xml", 39, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDReligion").Caption = Replace(GetLang("HRReligion.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("ReligionName").Caption = Replace(GetLang("HRReligion.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("HRReligion.xml", 39, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDReligion.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRReligionDB As clsHRReligionDB)
        Try
            With oForm
                _clsHRReligionDB.IDReligion = .txtIDReligion.Text.Trim
                _clsHRReligionDB.ReligionName = .txtName.Text.Trim
                _clsHRReligionDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRReligionDB As clsHRReligionDB)
        Try
            With oForm
                .txtIDReligion.Text = _clsHRReligionDB.IDReligion
                If vb.Left(.txtIDReligion.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRReligionDB.ReligionName
                .txtDescription.Text = _clsHRReligionDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDReligion.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .txtIDReligion.Text = .gridViewtable1.GetFocusedRowCellValue("IDReligion").ToString
                If vb.Left(.txtIDReligion.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("ReligionName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .txtIDReligion.Text = .gridViewtable2.GetFocusedRowCellValue("IDReligion").ToString
                If vb.Left(.txtIDReligion.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("ReligionName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDReligion").Width = 130
                .gridViewtable1.Columns("ReligionName").Width = 250
                .gridViewtable1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDReligion").Width = 130
                .gridViewtable2.Columns("ReligionName").Width = 250
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRReligionDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRReligion.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRReligionDB As New clsHRReligionDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRReligionDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRReligionDB.UnsetReligion() : _clsHRReligionDB = Nothing

                _clsHRReligionDB = New clsHRReligionDB
                .gridControlTable2.DataSource = _clsHRReligionDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRReligionDB.UnsetReligion() : _clsHRReligionDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRReligionDB As New clsHRReligionDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRReligionDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRReligionDB.UnsetReligion() : _clsHRReligionDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRReligionDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRReligionDB.UnsetReligion() : _clsHRReligionDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRReligion.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRReligion.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDReligion.Text = clsHRReligionDB.AutoID
                    .txtIDReligion.Properties.ReadOnly = True
                Else
                    .txtIDReligion.Text = ""
                    .txtIDReligion.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtDescription.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRReligion.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRReligion.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRReligionDB.IsExist(.txtIDReligion.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRReligion.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRReligion.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRReligionDB.Delete(.txtIDReligion.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDReligion.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRReligion.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRReligion.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDReligion.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDReligion.Text.Trim = "" Then
                s = GetLang("HRReligion.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRReligion.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRReligion.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRReligion.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRReligion.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDReligion.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRReligion.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRReligion.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRReligion.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRReligion.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRReligionDB.IsExist(.txtIDReligion.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRReligion.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRReligion.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRReligionDB As New clsHRReligionDB
                    setProperty(oForm, _clsHRReligionDB)
                    If clsHRReligionDB.IsExist(.txtIDReligion.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRReligion.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRReligion.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRReligionDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRReligion.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRReligion.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRReligion.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRReligion.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRReligionDB As New clsHRReligionDB
                    setProperty(oForm, _clsHRReligionDB)
                    _clsHRReligionDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDReligion", .txtIDReligion.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "ReligionName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDReligion.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRReligion:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRReligionDB As New clsHRReligionDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRReligionDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDReligion,ReligionName,Description " & _
                                                                                       "FROM HRReligion " & _
                                                                                       "ORDER BY IDReligion ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRReligionDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRReligionDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRReligionDB.Search(, .txtNumRecord.EditValue, "IDReligion", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRReligionDB.Search(, .txtNumRecord.EditValue, "ReligionName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRReligionDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsHRReligionDB.UnsetReligion() : _clsHRReligionDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
