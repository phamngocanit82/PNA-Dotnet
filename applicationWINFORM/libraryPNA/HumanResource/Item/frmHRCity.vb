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
Public Class frmHRCity
    'Public intLang As Integer = 1
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Public strIDCountry As String = ""
    'Public strCountryName As String = ""
    'Private flagPopupCountry As Boolean = False
    'Private Sub frmHRCity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsHRCity.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuVietnameseEnglish.ItemClick
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRCity.LoadLang(Me, 1)
    '    Else
    '        clsHRCity.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuRefesh.ItemClick
    '    clsHRCity.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuAdd.ItemClick
    '    clsHRCity.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDelete.ItemClick
    '    clsHRCity.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUpdate.ItemClick
    '    clsHRCity.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSave.ItemClick
    '    clsHRCity.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVietnameseEnglish.ItemClick
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRCity.LoadLang(Me, 1)
    '    Else
    '        clsHRCity.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefesh.ItemClick
    '    clsHRCity.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
    '    clsHRCity.ItemAdd(Me)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
    '    clsHRCity.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdate.ItemClick
    '    clsHRCity.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
    '    clsHRCity.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
    '    clsHRCity.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemVietnameseEnglish.LinkClicked
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRCity.LoadLang(Me, 1)
    '    Else
    '        clsHRCity.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemRefesh.LinkClicked
    '    clsHRCity.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemAdd.LinkClicked
    '    clsHRCity.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemDelete.LinkClicked
    '    clsHRCity.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemUpdate.LinkClicked
    '    clsHRCity.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemSave.LinkClicked
    '    clsHRCity.ItemSave(Me)
    'End Sub
    ''Center
    'Private Sub gridViewtable1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridViewtable1.Click
    '    If itemSave.Enabled Then Exit Sub
    '    intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '    clsHRCity.getRowGrid1(Me)
    'End Sub
    'Private Sub gridViewtable1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridViewtable1.DoubleClick
    '    If itemSave.Enabled Then Exit Sub
    '    intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '    clsHRCity.getRowGrid1(Me)
    'End Sub
    'Private Sub gridViewtable1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridViewtable1.InitNewRow
    '    Dim row As DataRow = gridViewtable1.GetDataRow(e.RowHandle)
    '    row("IDCity") = txtIDCity.Text.Trim
    '    row("CityName") = txtName.Text.Trim
    '    row("CityCode") = txtCityCode.Text.Trim
    '    row("Description") = txtDescription.Text.Trim
    '    row("IDCountry") = strIDCountry
    '    row("CountryName") = strCountryName
    '    gridViewtable1.RefreshRow(gridViewtable1.FocusedRowHandle)
    'End Sub
    'Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRCity.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    '    clsHRCity.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridControlTable2.DoubleClick
    '    clsHRCity.getRowGrid2(Me)
    'End Sub
    ''Popup
    'Private Sub txtPopupSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPopupSearch.KeyDown
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRCity.ItemPopupSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopupSearch.Click
    '    clsHRCity.ItemPopupSearch(Me)
    'End Sub
    'Private Sub btnPopupSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopupSelect.Click
    '    If Not pnlPopupSearch.OwnerEdit Is Nothing Then
    '        flagPopupCountry = True
    '        pnlPopupSearch.OwnerEdit.ClosePopup()
    '    End If
    'End Sub

    'Private Sub gridControlPopup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridControlPopup.DoubleClick
    '    If Not pnlPopupSearch.OwnerEdit Is Nothing Then
    '        flagPopupCountry = True
    '        pnlPopupSearch.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub cboPopupCountry_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles cboPopupCountry.QueryResultValue
    '    If flagPopupCountry = True Then
    '        If gridViewPopup.RowCount > 0 Then
    '            strIDCountry = gridViewPopup.GetFocusedRowCellValue("IDCountry").ToString
    '            strCountryName = gridViewPopup.GetFocusedRowCellValue("CountryName").ToString
    '            e.Value = gridViewPopup.GetFocusedRowCellValue("CountryName").ToString
    '        Else
    '            e.Value = ""
    '            strIDCountry = ""
    '            strCountryName = ""
    '        End If
    '        flagPopupCountry = False
    '    End If
    'End Sub
End Class