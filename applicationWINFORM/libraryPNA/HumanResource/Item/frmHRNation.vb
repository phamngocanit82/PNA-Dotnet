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
Imports DevExpress.XtraGrid.Columns
Public Class frmHRNation
    'Public intLang As Integer = 1
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Public strIDCountry As String = ""
    'Public strCountryName As String = ""
    'Private flagPopupCountry As Boolean = False
    'Private Sub frmHRNation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsHRNation.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRNation.LoadLang(Me, 1)
    '    Else
    '        clsHRNation.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRNation.LoadLang(Me, 1)
    '    Else
    '        clsHRNation.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemAdd(Me)
    'End Sub
    'Private Sub gridViewtable1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    Dim row As DataRow = gridViewtable1.GetDataRow(e.RowHandle)
    '    row("IDNation") = txtIDNation.Text.Trim
    '    row("NationName") = txtName.Text.Trim
    '    row("Description") = txtDescription.Text.Trim
    '    row("IDCountry") = strIDCountry
    '    row("CountryName") = strCountryName
    '    gridViewtable1.RefreshRow(gridViewtable1.FocusedRowHandle)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRNation.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRNation.LoadLang(Me, 1)
    '    Else
    '        clsHRNation.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRNation.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRNation.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRNation.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRNation.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRNation.ItemSave(Me)
    'End Sub
    ''Center
    'Private Sub gridViewtable1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If itemSave.Enabled Then Exit Sub
    '    intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '    clsHRNation.getRowGrid1(Me)
    'End Sub
    'Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRNation.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRNation.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRNation.getRowGrid2(Me)
    'End Sub
    ''Popup
    'Private Sub txtPopupSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRNation.ItemPopupSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRNation.ItemPopupSearch(Me)
    'End Sub
    'Private Sub btnPopupSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch.OwnerEdit Is Nothing Then
    '        flagPopupCountry = True
    '        pnlPopupSearch.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub gridControlPopup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch.OwnerEdit Is Nothing Then
    '        flagPopupCountry = True
    '        pnlPopupSearch.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub cboPopupCountry_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
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