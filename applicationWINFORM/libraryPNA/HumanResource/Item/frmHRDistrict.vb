'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
'Imports vb = Microsoft.VisualBasic
'Imports libraryPNA.clsSystem
'Imports libraryPNA.clsMessage
'Imports DevExpress.XtraGrid.Columns
Public Class frmHRDistrict
    'Public intLang As Integer = 1
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Public strIDCity As String = ""
    'Public strCityName As String = ""
    'Private flagPopupCity As Boolean = False
    'Private Sub frmHRDistrict_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsHRDistrict.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRDistrict.LoadLang(Me, 1)
    '    Else
    '        clsHRDistrict.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRDistrict.LoadLang(Me, 1)
    '    Else
    '        clsHRDistrict.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemAdd(Me)
    'End Sub
    'Private Sub gridViewtable1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    Dim row As DataRow = gridViewtable1.GetDataRow(e.RowHandle)
    '    row("IDDistrict") = txtIDDistrict.Text.Trim
    '    row("DistrictName") = txtName.Text.Trim
    '    row("DistrictCode") = txtDistrictCode.Text.Trim
    '    row("Description") = txtDescription.Text.Trim
    '    row("IDCity") = strIDCity
    '    row("CityName") = strCityName
    '    gridViewtable1.RefreshRow(gridViewtable1.FocusedRowHandle)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRDistrict.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRDistrict.LoadLang(Me, 1)
    '    Else
    '        clsHRDistrict.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRDistrict.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRDistrict.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRDistrict.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRDistrict.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRDistrict.ItemSave(Me)
    'End Sub
    ''Center
    'Private Sub gridViewtable1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If itemSave.Enabled Then Exit Sub
    '    intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '    clsHRDistrict.getRowGrid1(Me)
    'End Sub
    'Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRDistrict.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRDistrict.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRDistrict.getRowGrid2(Me)
    'End Sub
    ''Popup
    'Private Sub txtPopupSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRDistrict.ItemPopupSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRDistrict.ItemPopupSearch(Me)
    'End Sub
    'Private Sub btnPopupSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch.OwnerEdit Is Nothing Then
    '        flagPopupCity = True
    '        pnlPopupSearch.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub gridControlPopup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch.OwnerEdit Is Nothing Then
    '        flagPopupCity = True
    '        pnlPopupSearch.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub cboPopupCity_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
    '    If flagPopupCity = True Then
    '        If gridViewPopup.RowCount > 0 Then
    '            strIDCity = gridViewPopup.GetFocusedRowCellValue("IDCity").ToString
    '            strCityName = gridViewPopup.GetFocusedRowCellValue("CityName").ToString
    '            e.Value = gridViewPopup.GetFocusedRowCellValue("CityName").ToString
    '        Else
    '            e.Value = ""
    '        End If
    '        flagPopupCity = False
    '    End If
    'End Sub
End Class