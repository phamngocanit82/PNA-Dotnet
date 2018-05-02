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
Public Class clsHRCountry
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRCountry.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRCountry.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRCountry.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRCountry.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRCountry.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRCountry.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRCountry.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRCountry.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRCountry.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRCountry.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRCountry.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRCountry.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRCountry.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRCountry.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRCountry.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRCountry.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRCountry.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRCountry.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRCountry.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRCountry.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRCountry.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRCountry.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRCountry.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRCountry.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRCountry.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRCountry.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRCountry.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRCountry.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRCountry.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRCountry.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRCountry.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRCountry.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRCountry.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRCountry.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRCountry.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRCountry.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRCountry.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDCountry.Text = GetLang("HRCountry.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRCountry.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRCountry.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRCountry.xml", 38, intLang, DirLang.HR)
                .lblCountryCode.Text = GetLang("HRCountry.xml", 39, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRCountry.xml", 40, intLang, DirLang.HR)
                .btnSelectPicture.Text = GetLang("HRCountry.xml", 41, intLang, DirLang.HR)
                .btnDeletePicture.Text = GetLang("HRCountry.xml", 42, intLang, DirLang.HR)
                .btnSavePicture.Text = GetLang("HRCountry.xml", 43, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRCountry.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRCountry.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRCountry.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRCountry.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRCountry.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRCountry.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRCountry.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRCountry.xml", 39, intLang, DirLang.HR), _
                                                                   GetLang("HRCountry.xml", 40, intLang, DirLang.HR)})

                .gridViewtable1.Columns("IDCountry").Caption = Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("CountryName").Caption = Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("CountryCode").Caption = GetLang("HRCountry.xml", 39, intLang, DirLang.HR)
                .gridViewtable1.Columns("Description").Caption = GetLang("HRCountry.xml", 40, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDCountry").Caption = Replace(GetLang("HRCountry.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("CountryName").Caption = Replace(GetLang("HRCountry.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("CountryCode").Caption = GetLang("HRCountry.xml", 39, intLang, DirLang.HR)
                .gridViewtable2.Columns("Description").Caption = GetLang("HRCountry.xml", 40, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDCountry.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setEnable)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setReadOnly(ByVal oForm As Object, ByVal boolValue As Boolean)
        Try
            With oForm
                .rdoIDAuto.Enabled = boolValue
                .rdoIDCustomize.Enabled = boolValue
                .txtName.Properties.ReadOnly = boolValue
                .txtCountryCode.Properties.ReadOnly = boolValue
                .txtDescription.Properties.ReadOnly = boolValue
                .btnSelectPicture.Enabled = Not boolValue
                .btnDeletePicture.Enabled = Not boolValue
                .btnSavePicture.Enabled = Not boolValue
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRCountryDB As clsHRCountryDB)
        Try
            With oForm
                _clsHRCountryDB.IDCountry = .txtIDCountry.Text.Trim
                _clsHRCountryDB.CountryName = .txtName.Text.Trim
                _clsHRCountryDB.CountryCode = .txtCountryCode.Text.Trim
                _clsHRCountryDB.Description = .txtDescription.Text.Trim
                Try
                    If Not .picPicture.Image Is Nothing Then
                        _clsHRCountryDB.CPicture = clsIO.ByteToImage(clsIO.ImageToByte(.picPicture.Image, .strExtension))
                        _clsHRCountryDB.Extension = .strExtension
                    Else
                        _clsHRCountryDB.CPicture = Nothing
                        _clsHRCountryDB.Extension = ""
                    End If
                Catch ex As Exception
                    _clsHRCountryDB.CPicture = Nothing
                    _clsHRCountryDB.Extension = ""
                End Try
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRCountryDB As clsHRCountryDB)
        Try
            With oForm
                .txtIDCountry.Text = _clsHRCountryDB.IDCountry
                If vb.Left(.txtIDCountry.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRCountryDB.CountryName
                .txtCountryCode.Text = _clsHRCountryDB.CountryCode
                .txtDescription.Text = _clsHRCountryDB.Description
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsHRCountryDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsHRCountryDB.Extension
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDCountry.Text = ""
                    .txtName.Text = ""
                    .txtCountryCode.Text = ""
                    .txtDescription.Text = ""
                    .picPicture.Image = Nothing
                    .strExtension = ""
                    Exit Sub
                End If
                Dim _clsHRCountryDB As New clsHRCountryDB
                .gridViewtable1.FocusedRowHandle = .intIndexTable1

                .txtIDCountry.Text = .gridViewtable1.GetFocusedRowCellValue("IDCountry").ToString
                If vb.Left(.txtIDCountry.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("CountryName").ToString
                .txtCountryCode.Text = .gridViewtable1.GetFocusedRowCellValue("CountryCode").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
                _clsHRCountryDB.GetInfor(.txtIDCountry.Text)
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsHRCountryDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsHRCountryDB.Extension
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                Dim _clsHRCountryDB As New clsHRCountryDB
                .txtIDCountry.Text = .gridViewtable2.GetFocusedRowCellValue("IDCountry").ToString
                If vb.Left(.txtIDCountry.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("CountryName").ToString
                .txtCountryCode.Text = .gridViewtable2.GetFocusedRowCellValue("CountryCode").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
                _clsHRCountryDB.GetInfor(.txtIDCountry.Text)
                Try
                    Dim oBitmap As New System.Drawing.Bitmap(_clsHRCountryDB.CPicture)
                    .picPicture.Image = oBitmap
                Catch ex As Exception
                    .picPicture.Image = Nothing
                End Try
                .strExtension = _clsHRCountryDB.Extension
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDCountry").Width = 105
                .gridViewtable1.Columns("CountryName").Width = 150
                .gridViewtable1.Columns("CountryCode").Width = 100
                .gridViewtable1.Columns("Description").Width = 300
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDCountry").Width = 105
                .gridViewtable2.Columns("CountryName").Width = 150
                .gridViewtable2.Columns("CountryCode").Width = 130
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRCountryDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRCountry.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCountryDB As New clsHRCountryDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRCountryDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing

                _clsHRCountryDB = New clsHRCountryDB
                .gridControlTable2.DataSource = _clsHRCountryDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCountryDB As New clsHRCountryDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRCountryDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRCountryDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRCountry.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRCountry.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDCountry.Text = clsHRCountryDB.AutoID
                    .txtIDCountry.Properties.ReadOnly = True
                Else
                    .txtIDCountry.Text = ""
                    .txtIDCountry.Properties.ReadOnly = False
                End If
                .txtName.Text = ""
                .txtCountryCode.Text = ""
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRCountry.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCountry.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRCountryDB.IsExist(.txtIDCountry.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRCountry.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRCountry.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRCountryDB.Delete(.txtIDCountry.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDCountry.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRCountry.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCountry.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDCountry.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDCountry.Text.Trim = "" Then
                s = GetLang("HRCountry.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRCountry.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRCountry.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRCountry.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRCountry.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDCountry.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRCountry.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRCountry.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRCountry.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRCountry.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRCountryDB.IsExist(.txtIDCountry.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRCountry.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCountry.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    Dim _clsHRCountryDB As New clsHRCountryDB
                    setProperty(oForm, _clsHRCountryDB)
                    If clsHRCountryDB.IsExist(.txtIDCountry.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRCountry.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRCountry.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRCountryDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRCountry.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRCountry.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRCountry.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCountry.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRCountryDB As New clsHRCountryDB
                    setProperty(oForm, _clsHRCountryDB)
                    _clsHRCountryDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDCountry", .txtIDCountry.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CountryName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CountryCode", .txtCountryCode.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDCountry.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountry:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCountryDB As New clsHRCountryDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRCountryDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDCountry,CountryName,CountryCode,Description " & _
                                                                                       "FROM HRCountry " & _
                                                                                       "ORDER BY IDCountry ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRCountryDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRCountryDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRCountryDB.Search(, .txtNumRecord.EditValue, "IDCountry", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRCountryDB.Search(, .txtNumRecord.EditValue, "CountryName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRCountryDB.Search(, .txtNumRecord.EditValue, "CountryCode", .txtSearch.Text.Trim)
                    Case 6
                        .gridControlTable2.DataSource = _clsHRCountryDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsHRCountryDB.UnsetCountry() : _clsHRCountryDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
