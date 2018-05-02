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
Public Class clsPUCustomerType
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("PUCustomerType.xml", 0, intLang, DirLang.PU)
                .mnuVietnameseEnglish.Caption = GetLang("PUCustomerType.xml", 1, intLang, DirLang.PU)
                .mnuRefesh.Caption = GetLang("PUCustomerType.xml", 2, intLang, DirLang.PU)
                .mnuAdd.Caption = GetLang("PUCustomerType.xml", 3, intLang, DirLang.PU)
                .mnuDelete.Caption = GetLang("PUCustomerType.xml", 4, intLang, DirLang.PU)
                .mnuUpdate.Caption = GetLang("PUCustomerType.xml", 5, intLang, DirLang.PU)
                .mnuSave.Caption = GetLang("PUCustomerType.xml", 6, intLang, DirLang.PU)
                .mnuProcess.Caption = GetLang("PUCustomerType.xml", 11, intLang, DirLang.PU)
                .mnuImportFile.Caption = GetLang("PUCustomerType.xml", 13, intLang, DirLang.PU)
                .mnuExportFile.Caption = GetLang("PUCustomerType.xml", 14, intLang, DirLang.PU)
                .mnuHelp.Caption = GetLang("PUCustomerType.xml", 15, intLang, DirLang.PU)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("PUCustomerType.xml", 1, intLang, DirLang.PU)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("PUCustomerType.xml", 1, intLang, DirLang.PU)
                .btnRefesh.Caption = GetLang("PUCustomerType.xml", 2, intLang, DirLang.PU)
                .btnRefesh.Hint = GetLang("PUCustomerType.xml", 2, intLang, DirLang.PU)
                .btnAdd.Caption = GetLang("PUCustomerType.xml", 3, intLang, DirLang.PU)
                .btnAdd.Hint = GetLang("PUCustomerType.xml", 3, intLang, DirLang.PU)
                .btnDelete.Caption = GetLang("PUCustomerType.xml", 4, intLang, DirLang.PU)
                .btnDelete.Hint = GetLang("PUCustomerType.xml", 4, intLang, DirLang.PU)
                .btnUpdate.Caption = GetLang("PUCustomerType.xml", 5, intLang, DirLang.PU)
                .btnUpdate.Hint = GetLang("PUCustomerType.xml", 5, intLang, DirLang.PU)
                .btnSave.Caption = GetLang("PUCustomerType.xml", 6, intLang, DirLang.PU)
                .btnSave.Hint = GetLang("PUCustomerType.xml", 6, intLang, DirLang.PU)
                .btnUndo.Caption = GetLang("PUCustomerType.xml", 7, intLang, DirLang.PU)
                .btnUndo.Hint = GetLang("PUCustomerType.xml", 7, intLang, DirLang.PU)
                .lblViewRecord.Caption = GetLang("PUCustomerType.xml", 9, intLang, DirLang.PU)
                'Submenu
                .bgroupProcess.Caption = GetLang("PUCustomerType.xml", 11, intLang, DirLang.PU)
                .dpanelFunctions.Text = GetLang("PUCustomerType.xml", 12, intLang, DirLang.PU)
                .itemVietnameseEnglish.Caption = GetLang("PUCustomerType.xml", 1, intLang, DirLang.PU)
                .itemRefesh.Caption = GetLang("PUCustomerType.xml", 2, intLang, DirLang.PU)
                .itemAdd.Caption = GetLang("PUCustomerType.xml", 3, intLang, DirLang.PU)
                .itemDelete.Caption = GetLang("PUCustomerType.xml", 4, intLang, DirLang.PU)
                .itemUpdate.Caption = GetLang("PUCustomerType.xml", 5, intLang, DirLang.PU)
                .itemSave.Caption = GetLang("PUCustomerType.xml", 6, intLang, DirLang.PU)
                .itemImportFile.Caption = GetLang("PUCustomerType.xml", 13, intLang, DirLang.PU)
                .itemExportFile.Caption = GetLang("PUCustomerType.xml", 14, intLang, DirLang.PU)
                .itemHelp.Caption = GetLang("PUCustomerType.xml", 15, intLang, DirLang.PU)
                'Center
                .lblIDCustomerType.Text = GetLang("PUCustomerType.xml", 33, intLang, DirLang.PU)
                .rdoIDAuto.Text = GetLang("PUCustomerType.xml", 34, intLang, DirLang.PU)
                .rdoIDCustomize.Text = GetLang("PUCustomerType.xml", 35, intLang, DirLang.PU)
                .lblName.Text = GetLang("PUCustomerType.xml", 38, intLang, DirLang.PU)
                .lblDescription.Text = GetLang("PUCustomerType.xml", 39, intLang, DirLang.PU)
                .tabInformation.Text = GetLang("PUCustomerType.xml", 16, intLang, DirLang.PU)
                .tabList.Text = GetLang("PUCustomerType.xml", 17, intLang, DirLang.PU)
                .lblSearch.Text = GetLang("PUCustomerType.xml", 18, intLang, DirLang.PU)
                .btnSearch.Text = GetLang("PUCustomerType.xml", 18, intLang, DirLang.PU)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("PUCustomerType.xml", 19, intLang, DirLang.PU), _
                                                                   GetLang("PUCustomerType.xml", 20, intLang, DirLang.PU), _
                                                                   GetLang("PUCustomerType.xml", 21, intLang, DirLang.PU), _
                                                                   Replace(GetLang("PUCustomerType.xml", 33, intLang, DirLang.PU), "(*)", ""), _
                                                                   Replace(GetLang("PUCustomerType.xml", 38, intLang, DirLang.PU), "(*)", ""), _
                                                                   GetLang("PUCustomerType.xml", 39, intLang, DirLang.PU)})

                .gridViewtable1.Columns("IDCustomerType").Caption = Replace(GetLang("PUCustomerType.xml", 33, intLang, DirLang.PU), "(*)", "")
                .gridViewtable1.Columns("CustomerTypeName").Caption = Replace(GetLang("PUCustomerType.xml", 38, intLang, DirLang.PU), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("PUCustomerType.xml", 39, intLang, DirLang.PU)

                .gridViewtable2.Columns("IDCustomerType").Caption = Replace(GetLang("PUCustomerType.xml", 33, intLang, DirLang.PU), "(*)", "")
                .gridViewtable2.Columns("CustomerTypeName").Caption = Replace(GetLang("PUCustomerType.xml", 38, intLang, DirLang.PU), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("PUCustomerType.xml", 39, intLang, DirLang.PU)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDCustomerType.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:setEnable)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsPUCustomerTypeDB As clsPUCustomerTypeDB)
        Try
            With oForm
                _clsPUCustomerTypeDB.IDCustomerType = .txtIDCustomerType.Text.Trim
                _clsPUCustomerTypeDB.CustomerTypeName = .txtName.Text.Trim
                _clsPUCustomerTypeDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsPUCustomerTypeDB As clsPUCustomerTypeDB)
        Try
            With oForm
                .txtIDCustomerType.Text = _clsPUCustomerTypeDB.IDCustomerType
                If vb.Left(.txtIDCustomerType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsPUCustomerTypeDB.CustomerTypeName
                .txtDescription.Text = _clsPUCustomerTypeDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDCustomerType.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .txtIDCustomerType.Text = .gridViewtable1.GetFocusedRowCellValue("IDCustomerType").ToString
                If vb.Left(.txtIDCustomerType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("CustomerTypeName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .txtIDCustomerType.Text = .gridViewtable2.GetFocusedRowCellValue("IDCustomerType").ToString
                If vb.Left(.txtIDCustomerType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("CustomerTypeName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDCustomerType").Width = 130
                .gridViewtable1.Columns("CustomerTypeName").Width = 250
                .gridViewtable1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDCustomerType").Width = 130
                .gridViewtable2.Columns("CustomerTypeName").Width = 250
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsPUCustomerTypeDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("PUCustomerType.xml", 10, .intLang, DirLang.PU) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUCustomerTypeDB As New clsPUCustomerTypeDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsPUCustomerTypeDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsPUCustomerTypeDB.UnsetCustomerType() : _clsPUCustomerTypeDB = Nothing

                _clsPUCustomerTypeDB = New clsPUCustomerTypeDB
                .gridControlTable2.DataSource = _clsPUCustomerTypeDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsPUCustomerTypeDB.UnsetCustomerType() : _clsPUCustomerTypeDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUCustomerTypeDB As New clsPUCustomerTypeDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsPUCustomerTypeDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsPUCustomerTypeDB.UnsetCustomerType() : _clsPUCustomerTypeDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsPUCustomerTypeDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsPUCustomerTypeDB.UnsetCustomerType() : _clsPUCustomerTypeDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("PUCustomerType.xml", 22, .intLang, DirLang.PU), _
                                GetLang("PUCustomerType.xml", 23, .intLang, DirLang.PU), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDCustomerType.Text = clsPUCustomerTypeDB.AutoID
                    .txtIDCustomerType.Properties.ReadOnly = True
                Else
                    .txtIDCustomerType.Text = ""
                    .txtIDCustomerType.Properties.ReadOnly = False
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("PUCustomerType.xml", 22, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType.xml", 24, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsPUCustomerTypeDB.IsExist(.txtIDCustomerType.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("PUCustomerType.xml", 30, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType.xml", 31, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsPUCustomerTypeDB.Delete(.txtIDCustomerType.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDCustomerType.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("PUCustomerType.xml", 22, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType.xml", 25, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDCustomerType.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDCustomerType.Text.Trim = "" Then
                s = GetLang("PUCustomerType.xml", 33, .intLang, DirLang.PU) & " " & GetLang("PUCustomerType.xml", 36, .intLang, DirLang.PU) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("PUCustomerType.xml", 38, .intLang, DirLang.PU) & " " & GetLang("PUCustomerType.xml", 36, .intLang, DirLang.PU)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("PUCustomerType.xml", 27, .intLang, DirLang.PU), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDCustomerType.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("PUCustomerType.xml", 27, .intLang, DirLang.PU), _
                            GetLang("PUCustomerType.xml", 37, .intLang, DirLang.PU), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("PUCustomerType.xml", 22, .intLang, DirLang.PU), _
                             GetLang("PUCustomerType.xml", 26, .intLang, DirLang.PU), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsPUCustomerTypeDB.IsExist(.txtIDCustomerType.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("PUCustomerType.xml", 27, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType.xml", 28, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsPUCustomerTypeDB As New clsPUCustomerTypeDB
                    setProperty(oForm, _clsPUCustomerTypeDB)
                    If clsPUCustomerTypeDB.IsExist(.txtIDCustomerType.Text.Trim) Then
                        ShowMessage(oForm, GetLang("PUCustomerType.xml", 27, .intLang, DirLang.PU), _
                                           GetLang("PUCustomerType.xml", 32, .intLang, DirLang.PU), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsPUCustomerTypeDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("PUCustomerType.xml", 22, .intLang, DirLang.PU), _
                                       GetLang("PUCustomerType.xml", 25, .intLang, DirLang.PU), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("PUCustomerType.xml", 27, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType.xml", 29, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsPUCustomerTypeDB As New clsPUCustomerTypeDB
                    setProperty(oForm, _clsPUCustomerTypeDB)
                    _clsPUCustomerTypeDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDCustomerType", .txtIDCustomerType.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CustomerTypeName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDCustomerType.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUCustomerTypeDB As New clsPUCustomerTypeDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsPUCustomerTypeDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDCustomerType,CustomerTypeName,Description " & _
                                                                                       "FROM PUCustomerType " & _
                                                                                       "ORDER BY IDCustomerType ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsPUCustomerTypeDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsPUCustomerTypeDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsPUCustomerTypeDB.Search(, .txtNumRecord.EditValue, "IDCustomerType", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsPUCustomerTypeDB.Search(, .txtNumRecord.EditValue, "CustomerTypeName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsPUCustomerTypeDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsPUCustomerTypeDB.UnsetCustomerType() : _clsPUCustomerTypeDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
