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
Public Class clsPUCustomerType1
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("PUCustomerType1.xml", 0, intLang, DirLang.PU)
                .mnuVietnameseEnglish.Caption = GetLang("PUCustomerType1.xml", 1, intLang, DirLang.PU)
                .mnuRefesh.Caption = GetLang("PUCustomerType1.xml", 2, intLang, DirLang.PU)
                .mnuAdd.Caption = GetLang("PUCustomerType1.xml", 3, intLang, DirLang.PU)
                .mnuDelete.Caption = GetLang("PUCustomerType1.xml", 4, intLang, DirLang.PU)
                .mnuUpdate.Caption = GetLang("PUCustomerType1.xml", 5, intLang, DirLang.PU)
                .mnuSave.Caption = GetLang("PUCustomerType1.xml", 6, intLang, DirLang.PU)
                .mnuProcess.Caption = GetLang("PUCustomerType1.xml", 11, intLang, DirLang.PU)
                .mnuImportFile.Caption = GetLang("PUCustomerType1.xml", 13, intLang, DirLang.PU)
                .mnuExportFile.Caption = GetLang("PUCustomerType1.xml", 14, intLang, DirLang.PU)
                .mnuHelp.Caption = GetLang("PUCustomerType1.xml", 15, intLang, DirLang.PU)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("PUCustomerType1.xml", 1, intLang, DirLang.PU)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("PUCustomerType1.xml", 1, intLang, DirLang.PU)
                .btnRefesh.Caption = GetLang("PUCustomerType1.xml", 2, intLang, DirLang.PU)
                .btnRefesh.Hint = GetLang("PUCustomerType1.xml", 2, intLang, DirLang.PU)
                .btnAdd.Caption = GetLang("PUCustomerType1.xml", 3, intLang, DirLang.PU)
                .btnAdd.Hint = GetLang("PUCustomerType1.xml", 3, intLang, DirLang.PU)
                .btnDelete.Caption = GetLang("PUCustomerType1.xml", 4, intLang, DirLang.PU)
                .btnDelete.Hint = GetLang("PUCustomerType1.xml", 4, intLang, DirLang.PU)
                .btnUpdate.Caption = GetLang("PUCustomerType1.xml", 5, intLang, DirLang.PU)
                .btnUpdate.Hint = GetLang("PUCustomerType1.xml", 5, intLang, DirLang.PU)
                .btnSave.Caption = GetLang("PUCustomerType1.xml", 6, intLang, DirLang.PU)
                .btnSave.Hint = GetLang("PUCustomerType1.xml", 6, intLang, DirLang.PU)
                .btnUndo.Caption = GetLang("PUCustomerType1.xml", 7, intLang, DirLang.PU)
                .btnUndo.Hint = GetLang("PUCustomerType1.xml", 7, intLang, DirLang.PU)
                .lblViewRecord.Caption = GetLang("PUCustomerType1.xml", 9, intLang, DirLang.PU)
                'Submenu
                .bgroupProcess.Caption = GetLang("PUCustomerType1.xml", 11, intLang, DirLang.PU)
                .dpanelFunctions.Text = GetLang("PUCustomerType1.xml", 12, intLang, DirLang.PU)
                .itemVietnameseEnglish.Caption = GetLang("PUCustomerType1.xml", 1, intLang, DirLang.PU)
                .itemRefesh.Caption = GetLang("PUCustomerType1.xml", 2, intLang, DirLang.PU)
                .itemAdd.Caption = GetLang("PUCustomerType1.xml", 3, intLang, DirLang.PU)
                .itemDelete.Caption = GetLang("PUCustomerType1.xml", 4, intLang, DirLang.PU)
                .itemUpdate.Caption = GetLang("PUCustomerType1.xml", 5, intLang, DirLang.PU)
                .itemSave.Caption = GetLang("PUCustomerType1.xml", 6, intLang, DirLang.PU)
                .itemImportFile.Caption = GetLang("PUCustomerType1.xml", 13, intLang, DirLang.PU)
                .itemExportFile.Caption = GetLang("PUCustomerType1.xml", 14, intLang, DirLang.PU)
                .itemHelp.Caption = GetLang("PUCustomerType1.xml", 15, intLang, DirLang.PU)
                'Center
                .lblIDCustomerType.Text = GetLang("PUCustomerType1.xml", 33, intLang, DirLang.PU)
                .rdoIDAuto.Text = GetLang("PUCustomerType1.xml", 34, intLang, DirLang.PU)
                .rdoIDCustomize.Text = GetLang("PUCustomerType1.xml", 35, intLang, DirLang.PU)
                .lblName.Text = GetLang("PUCustomerType1.xml", 38, intLang, DirLang.PU)
                .lblDescription.Text = GetLang("PUCustomerType1.xml", 39, intLang, DirLang.PU)
                .LabelControl1.Text = GetLang("PUCustomerType1.xml", 40, intLang, DirLang.PU)
                .tabInformation.Text = GetLang("PUCustomerType1.xml", 16, intLang, DirLang.PU)
                .tabList.Text = GetLang("PUCustomerType1.xml", 17, intLang, DirLang.PU)
                .lblSearch.Text = GetLang("PUCustomerType1.xml", 18, intLang, DirLang.PU)
                .btnSearch.Text = GetLang("PUCustomerType1.xml", 18, intLang, DirLang.PU)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("PUCustomerType1.xml", 19, intLang, DirLang.PU), _
                                                                   GetLang("PUCustomerType1.xml", 20, intLang, DirLang.PU), _
                                                                   GetLang("PUCustomerType1.xml", 21, intLang, DirLang.PU), _
                                                                   Replace(GetLang("PUCustomerType1.xml", 33, intLang, DirLang.PU), "(*)", ""), _
                                                                   Replace(GetLang("PUCustomerType1.xml", 38, intLang, DirLang.PU), "(*)", ""), _
                                                                   GetLang("PUCustomerType1.xml", 39, intLang, DirLang.PU)})

                .gridViewtable1.Columns("IDCustomerType").Caption = Replace(GetLang("PUCustomerType1.xml", 33, intLang, DirLang.PU), "(*)", "")
                .gridViewtable1.Columns("CustomerTypeName").Caption = Replace(GetLang("PUCustomerType1.xml", 38, intLang, DirLang.PU), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("PUCustomerType1.xml", 39, intLang, DirLang.PU)
                .gridViewtable1.Columns("tmp").Caption = GetLang("PUCustomerType1.xml", 40, intLang, DirLang.PU)

                .gridViewtable2.Columns("IDCustomerType").Caption = Replace(GetLang("PUCustomerType1.xml", 33, intLang, DirLang.PU), "(*)", "")
                .gridViewtable2.Columns("CustomerTypeName").Caption = Replace(GetLang("PUCustomerType1.xml", 38, intLang, DirLang.PU), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("PUCustomerType1.xml", 39, intLang, DirLang.PU)
                .gridViewtable2.Columns("tmp").Caption = GetLang("PUCustomerType1.xml", 40, intLang, DirLang.PU)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:LoadLang)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
                .txtTmp.Properties.ReadOnly = boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsPUCustomerType1DB As clsPUCustomerType1DB)
        Try
            With oForm
                _clsPUCustomerType1DB.IDCustomerType = .txtIDCustomerType.Text.Trim
                _clsPUCustomerType1DB.CustomerTypeName = .txtName.Text.Trim
                _clsPUCustomerType1DB.Description = .txtDescription.Text.Trim
                _clsPUCustomerType1DB.Tmp = .txtTmp.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsPUCustomerType1DB As clsPUCustomerType1DB)
        Try
            With oForm
                .txtIDCustomerType.Text = _clsPUCustomerType1DB.IDCustomerType
                If vb.Left(.txtIDCustomerType.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsPUCustomerType1DB.CustomerTypeName
                .txtDescription.Text = _clsPUCustomerType1DB.Description
                .txtTmp.Text = _clsPUCustomerType1DB.Tmp
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:getProperty)", ex.Message.ToString, IconType.Message)
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
                    .txtTmp.Text = ""
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
                .txtTmp.Text = .gridViewtable1.GetFocusedRowCellValue("tmp").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:getRowGrid1)", ex.Message.ToString, IconType.Message)
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
                .txtTmp.Text = .gridViewtable2.GetFocusedRowCellValue("tmp").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("tmp").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("tmp").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsPUCustomerType1DB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("PUCustomerType1.xml", 10, .intLang, DirLang.PU) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUCustomerType1DB As New clsPUCustomerType1DB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsPUCustomerType1DB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsPUCustomerType1DB.UnsetCustomerType() : _clsPUCustomerType1DB = Nothing

                _clsPUCustomerType1DB = New clsPUCustomerType1DB
                .gridControlTable2.DataSource = _clsPUCustomerType1DB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsPUCustomerType1DB.UnsetCustomerType() : _clsPUCustomerType1DB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUCustomerType1DB As New clsPUCustomerType1DB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsPUCustomerType1DB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsPUCustomerType1DB.UnsetCustomerType() : _clsPUCustomerType1DB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsPUCustomerType1DB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsPUCustomerType1DB.UnsetCustomerType() : _clsPUCustomerType1DB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("PUCustomerType1.xml", 22, .intLang, DirLang.PU), _
                                GetLang("PUCustomerType1.xml", 23, .intLang, DirLang.PU), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDCustomerType.Text = clsPUCustomerType1DB.AutoID
                    .txtIDCustomerType.Properties.ReadOnly = True
                Else
                    .txtIDCustomerType.Text = ""
                    .txtIDCustomerType.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtDescription.Text = ""
                .txtTmp.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("PUCustomerType1.xml", 22, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType1.xml", 24, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsPUCustomerType1DB.IsExist(.txtIDCustomerType.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("PUCustomerType1.xml", 30, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType1.xml", 31, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsPUCustomerType1DB.Delete(.txtIDCustomerType.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDCustomerType.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("PUCustomerType1.xml", 22, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType1.xml", 25, .intLang, DirLang.PU), .intLang, _
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:ItemEdit)", ex.Message.ToString, IconType.Message)
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
                s = GetLang("PUCustomerType1.xml", 33, .intLang, DirLang.PU) & " " & GetLang("PUCustomerType1.xml", 36, .intLang, DirLang.PU) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("PUCustomerType1.xml", 38, .intLang, DirLang.PU) & " " & GetLang("PUCustomerType1.xml", 36, .intLang, DirLang.PU)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("PUCustomerType1.xml", 27, .intLang, DirLang.PU), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDCustomerType.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("PUCustomerType1.xml", 27, .intLang, DirLang.PU), _
                            GetLang("PUCustomerType1.xml", 37, .intLang, DirLang.PU), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("PUCustomerType1.xml", 22, .intLang, DirLang.PU), _
                             GetLang("PUCustomerType1.xml", 26, .intLang, DirLang.PU), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsPUCustomerType1DB.IsExist(.txtIDCustomerType.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("PUCustomerType1.xml", 27, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType1.xml", 28, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsPUCustomerType1DB As New clsPUCustomerType1DB
                    setProperty(oForm, _clsPUCustomerType1DB)
                    If clsPUCustomerType1DB.IsExist(.txtIDCustomerType.Text.Trim) Then
                        ShowMessage(oForm, GetLang("PUCustomerType1.xml", 27, .intLang, DirLang.PU), _
                                           GetLang("PUCustomerType1.xml", 32, .intLang, DirLang.PU), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsPUCustomerType1DB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("PUCustomerType1.xml", 22, .intLang, DirLang.PU), _
                                       GetLang("PUCustomerType1.xml", 25, .intLang, DirLang.PU), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("PUCustomerType1.xml", 27, .intLang, DirLang.PU), _
                                   GetLang("PUCustomerType1.xml", 29, .intLang, DirLang.PU), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsPUCustomerType1DB As New clsPUCustomerType1DB
                    setProperty(oForm, _clsPUCustomerType1DB)
                    _clsPUCustomerType1DB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDCustomerType", .txtIDCustomerType.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CustomerTypeName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "tmp", .txtTmp.Text.Trim)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsPUCustomerType1:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsPUCustomerType1DB As New clsPUCustomerType1DB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsPUCustomerType1DB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDCustomerType,CustomerTypeName,Description " & _
                                                                                       "FROM PUCustomerType1 " & _
                                                                                       "ORDER BY IDCustomerType ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsPUCustomerType1DB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsPUCustomerType1DB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsPUCustomerType1DB.Search(, .txtNumRecord.EditValue, "IDCustomerType", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsPUCustomerType1DB.Search(, .txtNumRecord.EditValue, "CustomerTypeName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsPUCustomerType1DB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsPUCustomerType1DB.Search(, .txtNumRecord.EditValue, "tmp", .txtSearch.Text.Trim)
                End Select
                _clsPUCustomerType1DB.UnsetCustomerType() : _clsPUCustomerType1DB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
