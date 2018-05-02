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
Public Class clsHRCommendDiscipline
    Public Shared Sub LoadLang(ByVal oForm As Object, Optional ByVal intLang As Integer = 1)
        Try
            With oForm
                .intlang = intLang
                'Menu
                .Text = GetLang("HRCommendDiscipline.xml", 0, intLang, DirLang.HR)
                .mnuVietnameseEnglish.Caption = GetLang("HRCommendDiscipline.xml", 1, intLang, DirLang.HR)
                .mnuRefesh.Caption = GetLang("HRCommendDiscipline.xml", 2, intLang, DirLang.HR)
                .mnuAdd.Caption = GetLang("HRCommendDiscipline.xml", 3, intLang, DirLang.HR)
                .mnuDelete.Caption = GetLang("HRCommendDiscipline.xml", 4, intLang, DirLang.HR)
                .mnuUpdate.Caption = GetLang("HRCommendDiscipline.xml", 5, intLang, DirLang.HR)
                .mnuSave.Caption = GetLang("HRCommendDiscipline.xml", 6, intLang, DirLang.HR)
                .mnuProcess.Caption = GetLang("HRCommendDiscipline.xml", 11, intLang, DirLang.HR)
                .mnuImportFile.Caption = GetLang("HRCommendDiscipline.xml", 13, intLang, DirLang.HR)
                .mnuExportFile.Caption = GetLang("HRCommendDiscipline.xml", 14, intLang, DirLang.HR)
                .mnuHelp.Caption = GetLang("HRCommendDiscipline.xml", 15, intLang, DirLang.HR)
                'Toolbar
                .btnVietnameseEnglish.Caption = GetLang("HRCommendDiscipline.xml", 1, intLang, DirLang.HR)
                If .btnVietnameseEnglish.Caption = "English" Then
                    .mnuVietnameseEnglish.ImageIndex = 1
                    .btnVietnameseEnglish.ImageIndex = 1
                Else
                    .mnuVietnameseEnglish.ImageIndex = 0
                    .btnVietnameseEnglish.ImageIndex = 0
                End If
                .btnVietnameseEnglish.Hint = GetLang("HRCommendDiscipline.xml", 1, intLang, DirLang.HR)
                .btnRefesh.Caption = GetLang("HRCommendDiscipline.xml", 2, intLang, DirLang.HR)
                .btnRefesh.Hint = GetLang("HRCommendDiscipline.xml", 2, intLang, DirLang.HR)
                .btnAdd.Caption = GetLang("HRCommendDiscipline.xml", 3, intLang, DirLang.HR)
                .btnAdd.Hint = GetLang("HRCommendDiscipline.xml", 3, intLang, DirLang.HR)
                .btnDelete.Caption = GetLang("HRCommendDiscipline.xml", 4, intLang, DirLang.HR)
                .btnDelete.Hint = GetLang("HRCommendDiscipline.xml", 4, intLang, DirLang.HR)
                .btnUpdate.Caption = GetLang("HRCommendDiscipline.xml", 5, intLang, DirLang.HR)
                .btnUpdate.Hint = GetLang("HRCommendDiscipline.xml", 5, intLang, DirLang.HR)
                .btnSave.Caption = GetLang("HRCommendDiscipline.xml", 6, intLang, DirLang.HR)
                .btnSave.Hint = GetLang("HRCommendDiscipline.xml", 6, intLang, DirLang.HR)
                .btnUndo.Caption = GetLang("HRCommendDiscipline.xml", 7, intLang, DirLang.HR)
                .btnUndo.Hint = GetLang("HRCommendDiscipline.xml", 7, intLang, DirLang.HR)
                .lblViewRecord.Caption = GetLang("HRCommendDiscipline.xml", 9, intLang, DirLang.HR)
                'Submenu
                .bgroupProcess.Caption = GetLang("HRCommendDiscipline.xml", 11, intLang, DirLang.HR)
                .dpanelFunctions.Text = GetLang("HRCommendDiscipline.xml", 12, intLang, DirLang.HR)
                .itemVietnameseEnglish.Caption = GetLang("HRCommendDiscipline.xml", 1, intLang, DirLang.HR)
                .itemRefesh.Caption = GetLang("HRCommendDiscipline.xml", 2, intLang, DirLang.HR)
                .itemAdd.Caption = GetLang("HRCommendDiscipline.xml", 3, intLang, DirLang.HR)
                .itemDelete.Caption = GetLang("HRCommendDiscipline.xml", 4, intLang, DirLang.HR)
                .itemUpdate.Caption = GetLang("HRCommendDiscipline.xml", 5, intLang, DirLang.HR)
                .itemSave.Caption = GetLang("HRCommendDiscipline.xml", 6, intLang, DirLang.HR)
                .itemImportFile.Caption = GetLang("HRCommendDiscipline.xml", 13, intLang, DirLang.HR)
                .itemExportFile.Caption = GetLang("HRCommendDiscipline.xml", 14, intLang, DirLang.HR)
                .itemHelp.Caption = GetLang("HRCommendDiscipline.xml", 15, intLang, DirLang.HR)
                'Center
                .lblIDCommendDiscipline.Text = GetLang("HRCommendDiscipline.xml", 33, intLang, DirLang.HR)
                .rdoIDAuto.Text = GetLang("HRCommendDiscipline.xml", 34, intLang, DirLang.HR)
                .rdoIDCustomize.Text = GetLang("HRCommendDiscipline.xml", 35, intLang, DirLang.HR)
                .lblName.Text = GetLang("HRCommendDiscipline.xml", 38, intLang, DirLang.HR)
                .lblDescription.Text = GetLang("HRCommendDiscipline.xml", 39, intLang, DirLang.HR)
                .tabInformation.Text = GetLang("HRCommendDiscipline.xml", 16, intLang, DirLang.HR)
                .tabList.Text = GetLang("HRCommendDiscipline.xml", 17, intLang, DirLang.HR)
                .lblSearch.Text = GetLang("HRCommendDiscipline.xml", 18, intLang, DirLang.HR)
                .btnSearch.Text = GetLang("HRCommendDiscipline.xml", 18, intLang, DirLang.HR)
                .cboSearch.Properties.Items.Clear()
                .cboSearch.Properties.Items.AddRange(New Object() {GetLang("HRCommendDiscipline.xml", 19, intLang, DirLang.HR), _
                                                                   GetLang("HRCommendDiscipline.xml", 20, intLang, DirLang.HR), _
                                                                   GetLang("HRCommendDiscipline.xml", 21, intLang, DirLang.HR), _
                                                                   Replace(GetLang("HRCommendDiscipline.xml", 33, intLang, DirLang.HR), "(*)", ""), _
                                                                   Replace(GetLang("HRCommendDiscipline.xml", 38, intLang, DirLang.HR), "(*)", ""), _
                                                                   GetLang("HRCommendDiscipline.xml", 39, intLang, DirLang.HR)})

                .gridViewtable1.Columns("IDCommendDiscipline").Caption = Replace(GetLang("HRCommendDiscipline.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("CommendDisciplineName").Caption = Replace(GetLang("HRCommendDiscipline.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable1.Columns("Description").Caption = GetLang("HRCommendDiscipline.xml", 39, intLang, DirLang.HR)

                .gridViewtable2.Columns("IDCommendDiscipline").Caption = Replace(GetLang("HRCommendDiscipline.xml", 33, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("CommendDisciplineName").Caption = Replace(GetLang("HRCommendDiscipline.xml", 38, intLang, DirLang.HR), "(*)", "")
                .gridViewtable2.Columns("Description").Caption = GetLang("HRCommendDiscipline.xml", 39, intLang, DirLang.HR)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:LoadLang)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadFont()

    End Sub
    Public Shared Sub setEnable(ByVal oForm As Object)
        Try
            With oForm
                .txtIDCommendDiscipline.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:setEnable)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:setReadOnly)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub setProperty(ByVal oForm As Object, ByVal _clsHRCommendDisciplineDB As clsHRCommendDisciplineDB)
        Try
            With oForm
                _clsHRCommendDisciplineDB.IDCommendDiscipline = .txtIDCommendDiscipline.Text.Trim
                _clsHRCommendDisciplineDB.CommendDisciplineName = .txtName.Text.Trim
                _clsHRCommendDisciplineDB.Description = .txtDescription.Text.Trim
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:setProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getProperty(ByVal oForm As Object, ByVal _clsHRCommendDisciplineDB As clsHRCommendDisciplineDB)
        Try
            With oForm
                .txtIDCommendDiscipline.Text = _clsHRCommendDisciplineDB.IDCommendDiscipline
                If vb.Left(.txtIDCommendDiscipline.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = _clsHRCommendDisciplineDB.CommendDisciplineName
                .txtDescription.Text = _clsHRCommendDisciplineDB.Description
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:getProperty)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid1(ByVal oForm As Object)
        Try
            With oForm
                If .gridViewtable1.RowCount = 0 Then
                    .intIndexTable1 = 0
                    .txtIDCommendDiscipline.Text = ""
                    .txtName.Text = ""
                    .txtDescription.Text = ""
                    Exit Sub
                End If
                .gridViewtable1.FocusedRowHandle = .intIndexTable1
                .txtIDCommendDiscipline.Text = .gridViewtable1.GetFocusedRowCellValue("IDCommendDiscipline").ToString
                If vb.Left(.txtIDCommendDiscipline.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable1.GetFocusedRowCellValue("CommendDisciplineName").ToString
                .txtDescription.Text = .gridViewtable1.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:getRowGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub getRowGrid2(ByVal oForm As Object)
        Try
            With oForm
                .tabFunctions.SelectedTabPageIndex = 0
                If .gridViewtable2.RowCount = 0 Then Exit Sub
                .txtIDCommendDiscipline.Text = .gridViewtable2.GetFocusedRowCellValue("IDCommendDiscipline").ToString
                If vb.Left(.txtIDCommendDiscipline.Text.Trim, 2) = "#_" Then
                    .rdoIDAuto.Checked = True
                Else
                    .rdoIDCustomize.Checked = True
                End If
                .txtName.Text = .gridViewtable2.GetFocusedRowCellValue("CommendDisciplineName").ToString
                .txtDescription.Text = .gridViewtable2.GetFocusedRowCellValue("Description").ToString
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:getRowGrid2)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable1.Columns("IDCommendDiscipline").Width = 130
                .gridViewtable1.Columns("CommendDisciplineName").Width = 250
                .gridViewtable1.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
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
                .gridViewtable2.Columns("IDCommendDiscipline").Width = 130
                .gridViewtable2.Columns("CommendDisciplineName").Width = 250
                .gridViewtable2.Columns("Description").Width = 350
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:setWidthHeaderGrid1)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Private Shared Sub TotalRow(ByVal oForm As Object)
        Try
            With oForm
                .intTotalRow = clsHRCommendDisciplineDB.TotalRow()
                If .intTotalRow > 50 Then
                    .txtNumRecord.EditValue = 50
                Else
                    .txtNumRecord.EditValue = .intTotalRow
                End If
                .lblSumRecord.Caption = GetLang("HRCommendDiscipline.xml", 10, .intLang, DirLang.HR) & "( " & .intTotalRow & " )"
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub LoadForm(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCommendDisciplineDB As New clsHRCommendDisciplineDB
                TotalRow(oForm)

                .gridControlTable1.DataSource = _clsHRCommendDisciplineDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRCommendDisciplineDB.UnsetCommendDiscipline() : _clsHRCommendDisciplineDB = Nothing

                _clsHRCommendDisciplineDB = New clsHRCommendDisciplineDB
                .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid2(oForm)
                _clsHRCommendDisciplineDB.UnsetCommendDiscipline() : _clsHRCommendDisciplineDB = Nothing

                LoadLang(oForm)
                setReadOnly(oForm, True)
                setEnable(oForm)
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:LoadForm)", ex.Message.ToString, IconType.Message)
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:Undo)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub RefeshDatabase(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCommendDisciplineDB As New clsHRCommendDisciplineDB
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.QueryTable(, .txtNumRecord.EditValue)
                    setWidthHeaderGrid2(oForm)
                    _clsHRCommendDisciplineDB.UnsetCommendDiscipline() : _clsHRCommendDisciplineDB = Nothing
                    Exit Sub
                End If
                .gridControlTable1.DataSource = _clsHRCommendDisciplineDB.QueryTable(, .txtNumRecord.EditValue)
                setWidthHeaderGrid1(oForm)
                _clsHRCommendDisciplineDB.UnsetCommendDiscipline() : _clsHRCommendDisciplineDB = Nothing
                setReadOnly(oForm, True)
                setEnable(oForm)
                .intIndexTable1 = 0
                getRowGrid1(oForm)
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:RefeshDatabase)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemAdd(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckAdd(oForm, GetLang("HRCommendDiscipline.xml", 22, .intLang, DirLang.HR), _
                                GetLang("HRCommendDiscipline.xml", 23, .intLang, DirLang.HR), .intLang, _
                                ButtonType.Ok, IconType.Add) Then Exit Sub
                If .rdoIDAuto.Checked Then
                    .txtIDCommendDiscipline.Text = clsHRCommendDisciplineDB.AutoID
                    .txtIDCommendDiscipline.Properties.ReadOnly = True
                Else
                    .txtIDCommendDiscipline.Text = ""
                    .txtIDCommendDiscipline.Properties.ReadOnly = False
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:ItemAdd)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemDelete(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckDelete(oForm, GetLang("HRCommendDiscipline.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCommendDiscipline.xml", 24, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Delete) Then Exit Sub

                If clsHRCommendDisciplineDB.IsExist(.txtIDCommendDiscipline.Text.Trim) Then
                    If ShowMessage(oForm, GetLang("HRCommendDiscipline.xml", 30, .intLang, DirLang.HR), _
                                   GetLang("HRCommendDiscipline.xml", 31, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Delete) = ButtonType.No Then Exit Sub
                    clsHRCommendDisciplineDB.Delete(.txtIDCommendDiscipline.Text.Trim)
                    .gridViewtable1.DeleteRow(.intIndexTable1)
                    setReadOnly(oForm, True)
                    setEnable(oForm)
                    getRowGrid1(oForm)
                    TotalRow(oForm)
                End If
            End With
        Catch ex As Exception
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:ItemDelete)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemEdit(ByVal oForm As Object)
        Try
            With oForm
                If .tabFunctions.SelectedTabPageIndex <> 0 Or .txtIDCommendDiscipline.Text.Trim() = "" Then
                    .tabFunctions.SelectedTabPageIndex = 0
                    Exit Sub
                End If
                If Not CheckUpdate(oForm, GetLang("HRCommendDiscipline.xml", 22, .intLang, DirLang.HR), _
                                   GetLang("HRCommendDiscipline.xml", 25, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.Ok, IconType.Update) Then Exit Sub
                .txtIDCommendDiscipline.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:ItemEdit)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Function ErrorValidateSave(ByVal oForm As Object) As Boolean
        With oForm
            If .tabFunctions.SelectedTabPageIndex <> 0 Then
                .tabFunctions.SelectedTabPageIndex = 0
                Return True
            End If
            Dim s As String = ""
            If .txtIDCommendDiscipline.Text.Trim = "" Then
                s = GetLang("HRCommendDiscipline.xml", 33, .intLang, DirLang.HR) & " " & GetLang("HRCommendDiscipline.xml", 36, .intLang, DirLang.HR) & vbNewLine
            End If
            If .txtName.Text.Trim = "" Then
                s = s & GetLang("HRCommendDiscipline.xml", 38, .intLang, DirLang.HR) & " " & GetLang("HRCommendDiscipline.xml", 36, .intLang, DirLang.HR)
            End If
            If s <> "" Then
                ShowMessage(oForm, GetLang("HRCommendDiscipline.xml", 27, .intLang, DirLang.HR), s, .intLang, ButtonType.Ok, IconType.Save)
                Return True
            End If
            If vb.Left(.txtIDCommendDiscipline.Text.Trim, 2) = "#_" And .rdoIDCustomize.Checked = True Then
                ShowMessage(oForm, GetLang("HRCommendDiscipline.xml", 27, .intLang, DirLang.HR), _
                            GetLang("HRCommendDiscipline.xml", 37, .intLang, DirLang.HR), .intLang, _
                            ButtonType.Ok, IconType.Save)
                Return True
            End If
            If Not CheckSave(oForm, GetLang("HRCommendDiscipline.xml", 22, .intLang, DirLang.HR), _
                             GetLang("HRCommendDiscipline.xml", 26, .intLang, DirLang.HR), .intLang, _
                             ButtonType.Ok, IconType.Save) Then Return True
        End With
        Return False
    End Function
    Public Shared Sub ItemSave(ByVal oForm As Object)
        Try
            With oForm
                If ErrorValidateSave(oForm) Then Exit Sub
                If Not clsHRCommendDisciplineDB.IsExist(.txtIDCommendDiscipline.Text.Trim) Or .intButton = 1 Then
                    If ShowMessage(oForm, GetLang("HRCommendDiscipline.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCommendDiscipline.xml", 28, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Save) = ButtonType.No Then Exit Sub
                    .intButton = 0
                    Dim _clsHRCommendDisciplineDB As New clsHRCommendDisciplineDB
                    setProperty(oForm, _clsHRCommendDisciplineDB)
                    If clsHRCommendDisciplineDB.IsExist(.txtIDCommendDiscipline.Text.Trim) Then
                        ShowMessage(oForm, GetLang("HRCommendDiscipline.xml", 27, .intLang, DirLang.HR), _
                                           GetLang("HRCommendDiscipline.xml", 32, .intLang, DirLang.HR), .intLang, _
                                           ButtonType.Ok, IconType.Message)
                        setReadOnly(oForm, True)
                        setEnable(oForm)
                        getRowGrid1(oForm)
                        Exit Sub
                    End If
                    _clsHRCommendDisciplineDB.Add()
                    .gridViewtable1.AddNewRow()
                    .intIndexTable1 = .gridViewtable1.GetSelectedRows()(0)
                    TotalRow(oForm)
                Else
                    If Not CheckUpdate(oForm, GetLang("HRCommendDiscipline.xml", 22, .intLang, DirLang.HR), _
                                       GetLang("HRCommendDiscipline.xml", 25, .intLang, DirLang.HR), .intLang, _
                                       ButtonType.Ok, IconType.Update) Then Exit Sub

                    If ShowMessage(oForm, GetLang("HRCommendDiscipline.xml", 27, .intLang, DirLang.HR), _
                                   GetLang("HRCommendDiscipline.xml", 29, .intLang, DirLang.HR), .intLang, _
                                   ButtonType.YesNo, IconType.Update) = ButtonType.No Then Exit Sub
                    Dim _clsHRCommendDisciplineDB As New clsHRCommendDisciplineDB
                    setProperty(oForm, _clsHRCommendDisciplineDB)
                    _clsHRCommendDisciplineDB.Update()
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "IDCommendDiscipline", .txtIDCommendDiscipline.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "CommendDisciplineName", .txtName.Text.Trim)
                    .gridViewtable1.SetRowCellValue(.intIndexTable1, "Description", .txtDescription.Text.Trim)
                    TotalRow(oForm)
                End If
                .txtIDCommendDiscipline.Properties.ReadOnly = True
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
            ShowError(oForm, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDiscipline:ItemSave)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Shared Sub ItemSearch(ByVal oForm As Object)
        Try
            With oForm
                Dim _clsHRCommendDisciplineDB As New clsHRCommendDisciplineDB
                Select Case .cboSearch.SelectedIndex
                    Case 0
                        .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.Search(, , , , "SELECT TOP " & .txtNumRecord.EditValue & _
                                                                                       " IDCommendDiscipline,CommendDisciplineName,Description " & _
                                                                                       "FROM HRCommendDiscipline " & _
                                                                                       "ORDER BY IDCommendDiscipline ASC")
                    Case 1
                        If SelectSQL = SelectSQLType.NormalAndCondition Then
                            .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.SearchCondition(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 2
                        If SelectSQL = SelectSQLType.NormarlAndConditionAndQuery Then
                            .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.SearchQuery(, .txtNumRecord.EditValue, .txtSearch.Text.Trim)
                        End If
                    Case 3
                        .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.Search(, .txtNumRecord.EditValue, "IDCommendDiscipline", .txtSearch.Text.Trim)
                    Case 4
                        .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.Search(, .txtNumRecord.EditValue, "CommendDisciplineName", .txtSearch.Text.Trim)
                    Case 5
                        .gridControlTable2.DataSource = _clsHRCommendDisciplineDB.Search(, .txtNumRecord.EditValue, "Description", .txtSearch.Text.Trim)
                End Select
                _clsHRCommendDisciplineDB.UnsetCommendDiscipline() : _clsHRCommendDisciplineDB = Nothing
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class
