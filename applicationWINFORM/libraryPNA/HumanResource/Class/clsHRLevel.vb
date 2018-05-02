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
Public Class clsHRLevel
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRLevel.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRLevel.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRLevel.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRLevel.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRLevel.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRLevel.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRLevel.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRLevel.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRLevel.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRLevel.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRLevel.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRLevel.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRLevel.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRLevel.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRLevel.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRLevel.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRLevel.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRLevel.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRLevel.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRLevel.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRLevel.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRLevel.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRLevel.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRLevel.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRLevel.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRLevel.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRLevel.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRLevel.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRLevel.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRLevel.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRLevel.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRLevel.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRLevel.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRLevel.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRLevel.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRLevel.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRLevel.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDLevel.Text = GetLang("HRLevel.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRLevel.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRLevel.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRLevel.xml", 38, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRLevel.xml", 39, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRLevel.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRLevel.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRLevel.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRLevel.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRLevel.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRLevel.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRLevel.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRLevel.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRLevel.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRLevel.xml", 39, intLang, DirLang.HR)})

                .gridViewtable1.Columns("IDLevel").Caption = Replace(GetLang("HRLevel.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("LevelName").Caption = Replace(GetLang("HRLevel.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("HRLevel.xml", 39, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDLevel").Caption = Replace(GetLang("HRLevel.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("LevelName").Caption = Replace(GetLang("HRLevel.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("HRLevel.xml", 39, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDLevel.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:setEnable)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRLevelDB As clsHRLevelDB)
        Try
            With oForm
                _clsHRLevelDB.IDLevel = .txtIDLevel.Text.Trim
                _clsHRLevelDB.LevelName = .txtName.Text.Trim
                _clsHRLevelDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRLevelDB As clsHRLevelDB)
        Try
            With oForm
                .txtIDLevel.Text = _clsHRLevelDB.IDLevel
                If vb.Left(.txtIDLevel.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRLevelDB.LevelName
                .txtDescription.Text = _clsHRLevelDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDLevel.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .txtIDLevel.Text = .gridViewtable1.GetFocusedRowCellValue("IDLevel").ToString
                If vb.Left(.txtIDLevel.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("LevelName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .txtIDLevel.Text = .gridViewtable2.GetFocusedRowCellValue("IDLevel").ToString
                If vb.Left(.txtIDLevel.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("LevelName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDLevel").Width = 130
                .gridViewtable1.Columns("LevelName").Width = 250
                .gridViewtable1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDLevel").Width = 130
                .gridViewtable2.Columns("LevelName").Width = 250
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRLevelDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRLevel.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRLevelDB As New clsHRLevelDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRLevelDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRLevelDB.UnsetLevel() : _clsHRLevelDB = Nothing

                _clsHRLevelDB = New clsHRLevelDB
                .gridControlTable2.DataSource = _clsHRLevelDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRLevelDB.UnsetLevel() : _clsHRLevelDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRLevelDB As New clsHRLevelDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRLevelDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRLevelDB.UnsetLevel() : _clsHRLevelDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRLevelDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRLevelDB.UnsetLevel() : _clsHRLevelDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRLevel.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRLevel.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDLevel.Text = clsHRLevelDB.AutoID
                    .txtIDLevel.Properties.ReadOnly = True
                Else
                    .txtIDLevel.Text = ""
                    .txtIDLevel.Properties.ReadOnly = False
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRLevel.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRLevel.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRLevelDB.IsExist(.txtIDLevel.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRLevel.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRLevel.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRLevelDB.Delete(.txtIDLevel.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDLevel.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRLevel.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRLevel.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDLevel.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDLevel.Text.Trim = "" Then
                s = GetLang("HRLevel.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRLevel.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRLevel.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRLevel.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRLevel.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDLevel.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRLevel.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRLevel.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRLevel.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRLevel.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRLevelDB.IsExist(.txtIDLevel.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRLevel.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRLevel.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRLevelDB As New clsHRLevelDB
                    setProperty(oForm, _clsHRLevelDB)
                    If clsHRLevelDB.IsExist(.txtIDLevel.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRLevel.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRLevel.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRLevelDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRLevel.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRLevel.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRLevel.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRLevel.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRLevelDB As New clsHRLevelDB
                    setProperty(oForm, _clsHRLevelDB)
                    _clsHRLevelDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDLevel", .txtIDLevel.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "LevelName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDLevel.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLevel:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRLevelDB As New clsHRLevelDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRLevelDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDLevel,LevelName,Description " & _
                                                                                       "FROM HRLevel " & _
                                                                                       "ORDER BY IDLevel ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRLevelDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRLevelDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRLevelDB.Search(, .txtNumRecord.EditValue, "IDLevel", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRLevelDB.Search(, .txtNumRecord.EditValue, "LevelName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRLevelDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsHRLevelDB.UnsetLevel() : _clsHRLevelDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
