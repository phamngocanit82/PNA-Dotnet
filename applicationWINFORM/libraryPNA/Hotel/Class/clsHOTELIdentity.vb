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
Public Class clsHOTELIdentity
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HOTELIdentity.xml", 0, intLang, DirLang.HOTEL)
                .mnuVietnameseEnglish.Caption = GetLang("HOTELIdentity.xml", 1, intLang, DirLang.HOTEL)
                .mnuRefesh.Caption = GetLang("HOTELIdentity.xml", 2, intLang, DirLang.HOTEL)
                .mnuAdd.Caption = GetLang("HOTELIdentity.xml", 3, intLang, DirLang.HOTEL)
                .mnuDelete.Caption = GetLang("HOTELIdentity.xml", 4, intLang, DirLang.HOTEL)
                .mnuUpdate.Caption = GetLang("HOTELIdentity.xml", 5, intLang, DirLang.HOTEL)
                .mnuSave.Caption = GetLang("HOTELIdentity.xml", 6, intLang, DirLang.HOTEL)
                .mnuProcess.Caption = GetLang("HOTELIdentity.xml", 11, intLang, DirLang.HOTEL)
                .mnuImportFile.Caption = GetLang("HOTELIdentity.xml", 13, intLang, DirLang.HOTEL)
                .mnuExportFile.Caption = GetLang("HOTELIdentity.xml", 14, intLang, DirLang.HOTEL)
                .mnuHelp.Caption = GetLang("HOTELIdentity.xml", 15, intLang, DirLang.HOTEL)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HOTELIdentity.xml", 1, intLang, DirLang.HOTEL)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HOTELIdentity.xml", 1, intLang, DirLang.HOTEL)
                .btnRefesh.Caption = GetLang("HOTELIdentity.xml", 2, intLang, DirLang.HOTEL)
                .btnRefesh.Hint = GetLang("HOTELIdentity.xml", 2, intLang, DirLang.HOTEL)
                .btnAdd.Caption = GetLang("HOTELIdentity.xml", 3, intLang, DirLang.HOTEL)
                .btnAdd.Hint = GetLang("HOTELIdentity.xml", 3, intLang, DirLang.HOTEL)
                .btnDelete.Caption = GetLang("HOTELIdentity.xml", 4, intLang, DirLang.HOTEL)
                .btnDelete.Hint = GetLang("HOTELIdentity.xml", 4, intLang, DirLang.HOTEL)
                .btnUpdate.Caption = GetLang("HOTELIdentity.xml", 5, intLang, DirLang.HOTEL)
                .btnUpdate.Hint = GetLang("HOTELIdentity.xml", 5, intLang, DirLang.HOTEL)
                .btnSave.Caption = GetLang("HOTELIdentity.xml", 6, intLang, DirLang.HOTEL)
                .btnSave.Hint = GetLang("HOTELIdentity.xml", 6, intLang, DirLang.HOTEL)
                .btnUndo.Caption = GetLang("HOTELIdentity.xml", 7, intLang, DirLang.HOTEL)
                .btnUndo.Hint = GetLang("HOTELIdentity.xml", 7, intLang, DirLang.HOTEL)
                .lblViewRecord.Caption = GetLang("HOTELIdentity.xml", 9, intLang, DirLang.HOTEL)
                'Submenu
                .bgroupProcess.Caption = GetLang("HOTELIdentity.xml", 11, intLang, DirLang.HOTEL)
                .dpanelFunctions.Text = GetLang("HOTELIdentity.xml", 12, intLang, DirLang.HOTEL)
                .itemVietnameseEnglish.Caption = GetLang("HOTELIdentity.xml", 1, intLang, DirLang.HOTEL)
                .itemRefesh.Caption = GetLang("HOTELIdentity.xml", 2, intLang, DirLang.HOTEL)
                .itemAdd.Caption = GetLang("HOTELIdentity.xml", 3, intLang, DirLang.HOTEL)
                .itemDelete.Caption = GetLang("HOTELIdentity.xml", 4, intLang, DirLang.HOTEL)
                .itemUpdate.Caption = GetLang("HOTELIdentity.xml", 5, intLang, DirLang.HOTEL)
                .itemSave.Caption = GetLang("HOTELIdentity.xml", 6, intLang, DirLang.HOTEL)
                .itemImportFile.Caption = GetLang("HOTELIdentity.xml", 13, intLang, DirLang.HOTEL)
                .itemExportFile.Caption = GetLang("HOTELIdentity.xml", 14, intLang, DirLang.HOTEL)
                .itemHelp.Caption = GetLang("HOTELIdentity.xml", 15, intLang, DirLang.HOTEL)
                'Center
                .lblIDIdentity.Text = GetLang("HOTELIdentity.xml", 33, intLang, DirLang.HOTEL)
                .rdoIDAuto.Text = GetLang("HOTELIdentity.xml", 34, intLang, DirLang.HOTEL)
                .rdoIDCustomize.Text = GetLang("HOTELIdentity.xml", 35, intLang, DirLang.HOTEL)
                .lblName.Text = GetLang("HOTELIdentity.xml", 38, intLang, DirLang.HOTEL)
                .lblDescription.Text = GetLang("HOTELIdentity.xml", 39, intLang, DirLang.HOTEL)
                .tabInformation.Text = GetLang("HOTELIdentity.xml", 16, intLang, DirLang.HOTEL)
                .tabList.Text = GetLang("HOTELIdentity.xml", 17, intLang, DirLang.HOTEL)
                .lblSearch.Text = GetLang("HOTELIdentity.xml", 18, intLang, DirLang.HOTEL)
                .btnSearch.Text = GetLang("HOTELIdentity.xml", 18, intLang, DirLang.HOTEL)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HOTELIdentity.xml", 19, intLang, DirLang.HOTEL), _
                                                                   GetLang("HOTELIdentity.xml", 20, intLang, DirLang.HOTEL), _
                                                                   GetLang("HOTELIdentity.xml", 21, intLang, DirLang.HOTEL), _
                                                                   Replace(GetLang("HOTELIdentity.xml", 33, intLang, DirLang.HOTEL), "(*)", ""), _
                                                                   Replace(GetLang("HOTELIdentity.xml", 38, intLang, DirLang.HOTEL), "(*)", ""), _
                                                                   GetLang("HOTELIdentity.xml", 39, intLang, DirLang.HOTEL)})

                .gridViewtable1.Columns("IDIdentity").Caption = Replace(GetLang("HOTELIdentity.xml", 33, intLang, DirLang.HOTEL), "(*)", "")
                .gridViewtable1.Columns("IdentityName").Caption = Replace(GetLang("HOTELIdentity.xml", 38, intLang, DirLang.HOTEL), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("HOTELIdentity.xml", 39, intLang, DirLang.HOTEL)

                .gridViewtable2.Columns("IDIdentity").Caption = Replace(GetLang("HOTELIdentity.xml", 33, intLang, DirLang.HOTEL), "(*)", "")
                .gridViewtable2.Columns("IdentityName").Caption = Replace(GetLang("HOTELIdentity.xml", 38, intLang, DirLang.HOTEL), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("HOTELIdentity.xml", 39, intLang, DirLang.HOTEL)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDIdentity.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:setEnable)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHOTELIdentityDB As clsHOTELIdentityDB)
        Try
            With oForm
                _clsHOTELIdentityDB.IDIdentity = .txtIDIdentity.Text.Trim
                _clsHOTELIdentityDB.IdentityName = .txtName.Text.Trim
                _clsHOTELIdentityDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHOTELIdentityDB As clsHOTELIdentityDB)
        Try
            With oForm
                .txtIDIdentity.Text = _clsHOTELIdentityDB.IDIdentity
                If vb.Left(.txtIDIdentity.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHOTELIdentityDB.IdentityName
                .txtDescription.Text = _clsHOTELIdentityDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDIdentity.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .txtIDIdentity.Text = .gridViewtable1.GetFocusedRowCellValue("IDIdentity").ToString
                If vb.Left(.txtIDIdentity.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("IdentityName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .txtIDIdentity.Text = .gridViewtable2.GetFocusedRowCellValue("IDIdentity").ToString
                If vb.Left(.txtIDIdentity.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("IdentityName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDIdentity").Width = 130
                .gridViewtable1.Columns("IdentityName").Width = 250
                .gridViewtable1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDIdentity").Width = 130
                .gridViewtable2.Columns("IdentityName").Width = 250
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHOTELIdentityDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HOTELIdentity.xml", 10, .intLang, DirLang.HOTEL) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHOTELIdentityDB As New clsHOTELIdentityDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHOTELIdentityDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHOTELIdentityDB.UnsetIdentity() : _clsHOTELIdentityDB = Nothing

                _clsHOTELIdentityDB = New clsHOTELIdentityDB
                .gridControlTable2.DataSource = _clsHOTELIdentityDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHOTELIdentityDB.UnsetIdentity() : _clsHOTELIdentityDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHOTELIdentityDB As New clsHOTELIdentityDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHOTELIdentityDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHOTELIdentityDB.UnsetIdentity() : _clsHOTELIdentityDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHOTELIdentityDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHOTELIdentityDB.UnsetIdentity() : _clsHOTELIdentityDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HOTELIdentity.xml", 22, .intLang, DirLang.HOTEL), _
                                GetLang("HOTELIdentity.xml", 23, .intLang, DirLang.HOTEL), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDIdentity.Text = clsHOTELIdentityDB.AutoID
                    .txtIDIdentity.Properties.ReadOnly = True
                Else
                    .txtIDIdentity.Text = ""
                    .txtIDIdentity.Properties.ReadOnly = False
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HOTELIdentity.xml", 22, .intLang, DirLang.HOTEL), _
                                   GetLang("HOTELIdentity.xml", 24, .intLang, DirLang.HOTEL), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHOTELIdentityDB.IsExist(.txtIDIdentity.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HOTELIdentity.xml", 30, .intLang, DirLang.HOTEL), _
                                   GetLang("HOTELIdentity.xml", 31, .intLang, DirLang.HOTEL), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHOTELIdentityDB.Delete(.txtIDIdentity.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDIdentity.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HOTELIdentity.xml", 22, .intLang, DirLang.HOTEL), _
                                   GetLang("HOTELIdentity.xml", 25, .intLang, DirLang.HOTEL), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDIdentity.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDIdentity.Text.Trim = "" Then
                s = GetLang("HOTELIdentity.xml", 33, .intLang, DirLang.HOTEL) & " " & GetLang("HOTELIdentity.xml", 36, .intLang, DirLang.HOTEL) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HOTELIdentity.xml", 38, .intLang, DirLang.HOTEL) & " " & GetLang("HOTELIdentity.xml", 36, .intLang, DirLang.HOTEL)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HOTELIdentity.xml", 27, .intLang, DirLang.HOTEL), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDIdentity.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HOTELIdentity.xml", 27, .intLang, DirLang.HOTEL), _
                            GetLang("HOTELIdentity.xml", 37, .intLang, DirLang.HOTEL), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HOTELIdentity.xml", 22, .intLang, DirLang.HOTEL), _
                             GetLang("HOTELIdentity.xml", 26, .intLang, DirLang.HOTEL), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHOTELIdentityDB.IsExist(.txtIDIdentity.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HOTELIdentity.xml", 27, .intLang, DirLang.HOTEL), _
                                   GetLang("HOTELIdentity.xml", 28, .intLang, DirLang.HOTEL), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHOTELIdentityDB As New clsHOTELIdentityDB
                    setProperty(oForm, _clsHOTELIdentityDB)
                    If clsHOTELIdentityDB.IsExist(.txtIDIdentity.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HOTELIdentity.xml", 27, .intLang, DirLang.HOTEL), _
                                           GetLang("HOTELIdentity.xml", 32, .intLang, DirLang.HOTEL), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHOTELIdentityDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HOTELIdentity.xml", 22, .intLang, DirLang.HOTEL), _
                                       GetLang("HOTELIdentity.xml", 25, .intLang, DirLang.HOTEL), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HOTELIdentity.xml", 27, .intLang, DirLang.HOTEL), _
                                   GetLang("HOTELIdentity.xml", 29, .intLang, DirLang.HOTEL), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHOTELIdentityDB As New clsHOTELIdentityDB
                    setProperty(oForm, _clsHOTELIdentityDB)
                    _clsHOTELIdentityDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDIdentity", .txtIDIdentity.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IdentityName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDIdentity.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHOTELIdentity:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHOTELIdentityDB As New clsHOTELIdentityDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHOTELIdentityDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDIdentity,IdentityName,Description " & _
                                                                                       "FROM HOTELIdentity " & _
                                                                                       "ORDER BY IDIdentity ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHOTELIdentityDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHOTELIdentityDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHOTELIdentityDB.Search(, .txtNumRecord.EditValue, "IDIdentity", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHOTELIdentityDB.Search(, .txtNumRecord.EditValue, "IdentityName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHOTELIdentityDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsHOTELIdentityDB.UnsetIdentity() : _clsHOTELIdentityDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
