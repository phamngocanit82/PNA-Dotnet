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
Public Class clsPUSupplierType
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("PUSupplierType.xml", 0, intLang, DirLang.PU)
                .mnuVietnameseEnglish.Caption = GetLang("PUSupplierType.xml", 1, intLang, DirLang.PU)
                .mnuRefesh.Caption = GetLang("PUSupplierType.xml", 2, intLang, DirLang.PU)
                .mnuAdd.Caption = GetLang("PUSupplierType.xml", 3, intLang, DirLang.PU)
                .mnuDelete.Caption = GetLang("PUSupplierType.xml", 4, intLang, DirLang.PU)
                .mnuUpdate.Caption = GetLang("PUSupplierType.xml", 5, intLang, DirLang.PU)
                .mnuSave.Caption = GetLang("PUSupplierType.xml", 6, intLang, DirLang.PU)
                .mnuProcess.Caption = GetLang("PUSupplierType.xml", 11, intLang, DirLang.PU)
                .mnuImportFile.Caption = GetLang("PUSupplierType.xml", 13, intLang, DirLang.PU)
                .mnuExportFile.Caption = GetLang("PUSupplierType.xml", 14, intLang, DirLang.PU)
                .mnuHelp.Caption = GetLang("PUSupplierType.xml", 15, intLang, DirLang.PU)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("PUSupplierType.xml", 1, intLang, DirLang.PU)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("PUSupplierType.xml", 1, intLang, DirLang.PU)
                .btnRefesh.Caption = GetLang("PUSupplierType.xml", 2, intLang, DirLang.PU)
                .btnRefesh.Hint = GetLang("PUSupplierType.xml", 2, intLang, DirLang.PU)
                .btnAdd.Caption = GetLang("PUSupplierType.xml", 3, intLang, DirLang.PU)
                .btnAdd.Hint = GetLang("PUSupplierType.xml", 3, intLang, DirLang.PU)
                .btnDelete.Caption = GetLang("PUSupplierType.xml", 4, intLang, DirLang.PU)
                .btnDelete.Hint = GetLang("PUSupplierType.xml", 4, intLang, DirLang.PU)
                .btnUpdate.Caption = GetLang("PUSupplierType.xml", 5, intLang, DirLang.PU)
                .btnUpdate.Hint = GetLang("PUSupplierType.xml", 5, intLang, DirLang.PU)
                .btnSave.Caption = GetLang("PUSupplierType.xml", 6, intLang, DirLang.PU)
                .btnSave.Hint = GetLang("PUSupplierType.xml", 6, intLang, DirLang.PU)
                .btnUndo.Caption = GetLang("PUSupplierType.xml", 7, intLang, DirLang.PU)
                .btnUndo.Hint = GetLang("PUSupplierType.xml", 7, intLang, DirLang.PU)
                .lblViewRecord.Caption = GetLang("PUSupplierType.xml", 9, intLang, DirLang.PU)
                'Submenu
                .bgroupProcess.Caption = GetLang("PUSupplierType.xml", 11, intLang, DirLang.PU)
                .dpanelFunctions.Text = GetLang("PUSupplierType.xml", 12, intLang, DirLang.PU)
                .itemVietnameseEnglish.Caption = GetLang("PUSupplierType.xml", 1, intLang, DirLang.PU)
                .itemRefesh.Caption = GetLang("PUSupplierType.xml", 2, intLang, DirLang.PU)
                .itemAdd.Caption = GetLang("PUSupplierType.xml", 3, intLang, DirLang.PU)
                .itemDelete.Caption = GetLang("PUSupplierType.xml", 4, intLang, DirLang.PU)
                .itemUpdate.Caption = GetLang("PUSupplierType.xml", 5, intLang, DirLang.PU)
                .itemSave.Caption = GetLang("PUSupplierType.xml", 6, intLang, DirLang.PU)
                .itemImportFile.Caption = GetLang("PUSupplierType.xml", 13, intLang, DirLang.PU)
                .itemExportFile.Caption = GetLang("PUSupplierType.xml", 14, intLang, DirLang.PU)
                .itemHelp.Caption = GetLang("PUSupplierType.xml", 15, intLang, DirLang.PU)
                'Center
                .lblIDSupplierType.Text = GetLang("PUSupplierType.xml", 33, intLang, DirLang.PU)
                .rdoIDAuto.Text = GetLang("PUSupplierType.xml", 34, intLang, DirLang.PU)
                .rdoIDCustomize.Text = GetLang("PUSupplierType.xml", 35, intLang, DirLang.PU)
                .lblName.Text = GetLang("PUSupplierType.xml", 38, intLang, DirLang.PU)
                .lblDescription.Text = GetLang("PUSupplierType.xml", 39, intLang, DirLang.PU)
                .tabInformation.Text = GetLang("PUSupplierType.xml", 16, intLang, DirLang.PU)
                .tabList.Text = GetLang("PUSupplierType.xml", 17, intLang, DirLang.PU)
                .lblSearch.Text = GetLang("PUSupplierType.xml", 18, intLang, DirLang.PU)
                .btnSearch.Text = GetLang("PUSupplierType.xml", 18, intLang, DirLang.PU)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("PUSupplierType.xml", 19, intLang, DirLang.PU), _
                                                                   GetLang("PUSupplierType.xml", 20, intLang, DirLang.PU), _
                                                                   GetLang("PUSupplierType.xml", 21, intLang, DirLang.PU), _
                                                                   Replace(GetLang("PUSupplierType.xml", 33, intLang, DirLang.PU), "(*)", ""), _
                                                                   Replace(GetLang("PUSupplierType.xml", 38, intLang, DirLang.PU), "(*)", ""), _
                                                                   GetLang("PUSupplierType.xml", 39, intLang, DirLang.PU)})

                .gridViewtable1.Columns("IDSupplierType").Caption = Replace(GetLang("PUSupplierType.xml", 33, intLang, DirLang.PU), "(*)", "")
                .gridViewtable1.Columns("SupplierTypeName").Caption = Replace(GetLang("PUSupplierType.xml", 38, intLang, DirLang.PU), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("PUSupplierType.xml", 39, intLang, DirLang.PU)

                .gridViewtable2.Columns("IDSupplierType").Caption = Replace(GetLang("PUSupplierType.xml", 33, intLang, DirLang.PU), "(*)", "")
                .gridViewtable2.Columns("SupplierTypeName").Caption = Replace(GetLang("PUSupplierType.xml", 38, intLang, DirLang.PU), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("PUSupplierType.xml", 39, intLang, DirLang.PU)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDSupplierType.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:setEnable)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsPUSupplierTypeDB As clsPUSupplierTypeDB)
        Try
            With oForm
                _clsPUSupplierTypeDB.IDSupplierType = .txtIDSupplierType.Text.Trim
                _clsPUSupplierTypeDB.SupplierTypeName = .txtName.Text.Trim
                _clsPUSupplierTypeDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsPUSupplierTypeDB As clsPUSupplierTypeDB)
        Try
            With oForm
                .txtIDSupplierType.Text = _clsPUSupplierTypeDB.IDSupplierType
                If vb.Left(.txtIDSupplierType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsPUSupplierTypeDB.SupplierTypeName
                .txtDescription.Text = _clsPUSupplierTypeDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDSupplierType.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .txtIDSupplierType.Text = .gridViewtable1.GetFocusedRowCellValue("IDSupplierType").ToString
                If vb.Left(.txtIDSupplierType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("SupplierTypeName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .txtIDSupplierType.Text = .gridViewtable2.GetFocusedRowCellValue("IDSupplierType").ToString
                If vb.Left(.txtIDSupplierType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("SupplierTypeName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDSupplierType").Width = 130
                .gridViewtable1.Columns("SupplierTypeName").Width = 250
                .gridViewtable1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDSupplierType").Width = 130
                .gridViewtable2.Columns("SupplierTypeName").Width = 250
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsPUSupplierTypeDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("PUSupplierType.xml", 10, .intLang, DirLang.PU) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUSupplierTypeDB As New clsPUSupplierTypeDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsPUSupplierTypeDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsPUSupplierTypeDB.UnsetSupplierType() : _clsPUSupplierTypeDB = Nothing

                _clsPUSupplierTypeDB = New clsPUSupplierTypeDB
                .gridControlTable2.DataSource = _clsPUSupplierTypeDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsPUSupplierTypeDB.UnsetSupplierType() : _clsPUSupplierTypeDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUSupplierTypeDB As New clsPUSupplierTypeDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsPUSupplierTypeDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsPUSupplierTypeDB.UnsetSupplierType() : _clsPUSupplierTypeDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsPUSupplierTypeDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsPUSupplierTypeDB.UnsetSupplierType() : _clsPUSupplierTypeDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("PUSupplierType.xml", 22, .intLang, DirLang.PU), _
                                GetLang("PUSupplierType.xml", 23, .intLang, DirLang.PU), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDSupplierType.Text = clsPUSupplierTypeDB.AutoID
                    .txtIDSupplierType.Properties.ReadOnly = True
                Else
                    .txtIDSupplierType.Text = ""
                    .txtIDSupplierType.Properties.ReadOnly = False
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("PUSupplierType.xml", 22, .intLang, DirLang.PU), _
                                   GetLang("PUSupplierType.xml", 24, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsPUSupplierTypeDB.IsExist(.txtIDSupplierType.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("PUSupplierType.xml", 30, .intLang, DirLang.PU), _
                                   GetLang("PUSupplierType.xml", 31, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsPUSupplierTypeDB.Delete(.txtIDSupplierType.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDSupplierType.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("PUSupplierType.xml", 22, .intLang, DirLang.PU), _
                                   GetLang("PUSupplierType.xml", 25, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDSupplierType.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDSupplierType.Text.Trim = "" Then
                s = GetLang("PUSupplierType.xml", 33, .intLang, DirLang.PU) & " " & GetLang("PUSupplierType.xml", 36, .intLang, DirLang.PU) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("PUSupplierType.xml", 38, .intLang, DirLang.PU) & " " & GetLang("PUSupplierType.xml", 36, .intLang, DirLang.PU)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("PUSupplierType.xml", 27, .intLang, DirLang.PU), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDSupplierType.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("PUSupplierType.xml", 27, .intLang, DirLang.PU), _
                            GetLang("PUSupplierType.xml", 37, .intLang, DirLang.PU), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("PUSupplierType.xml", 22, .intLang, DirLang.PU), _
                             GetLang("PUSupplierType.xml", 26, .intLang, DirLang.PU), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsPUSupplierTypeDB.IsExist(.txtIDSupplierType.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("PUSupplierType.xml", 27, .intLang, DirLang.PU), _
                                   GetLang("PUSupplierType.xml", 28, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsPUSupplierTypeDB As New clsPUSupplierTypeDB
                    setProperty(oForm, _clsPUSupplierTypeDB)
                    If clsPUSupplierTypeDB.IsExist(.txtIDSupplierType.Text.Trim) Then
                        ShowMessage(oForm, GetLang("PUSupplierType.xml", 27, .intLang, DirLang.PU), _
                                           GetLang("PUSupplierType.xml", 32, .intLang, DirLang.PU), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsPUSupplierTypeDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("PUSupplierType.xml", 22, .intLang, DirLang.PU), _
                                       GetLang("PUSupplierType.xml", 25, .intLang, DirLang.PU), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("PUSupplierType.xml", 27, .intLang, DirLang.PU), _
                                   GetLang("PUSupplierType.xml", 29, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsPUSupplierTypeDB As New clsPUSupplierTypeDB
                    setProperty(oForm, _clsPUSupplierTypeDB)
                    _clsPUSupplierTypeDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDSupplierType", .txtIDSupplierType.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "SupplierTypeName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDSupplierType.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUSupplierType:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUSupplierTypeDB As New clsPUSupplierTypeDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsPUSupplierTypeDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDSupplierType,SupplierTypeName,Description " & _
                                                                                       "FROM PUSupplierType " & _
                                                                                       "ORDER BY IDSupplierType ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsPUSupplierTypeDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsPUSupplierTypeDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsPUSupplierTypeDB.Search(, .txtNumRecord.EditValue, "IDSupplierType", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsPUSupplierTypeDB.Search(, .txtNumRecord.EditValue, "SupplierTypeName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsPUSupplierTypeDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsPUSupplierTypeDB.UnsetSupplierType() : _clsPUSupplierTypeDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
