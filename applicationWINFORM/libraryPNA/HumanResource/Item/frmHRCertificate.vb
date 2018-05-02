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
Public Class frmHRCertificate
    'Public intLang As Integer = 1
    'Public strExtension As String = ""
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Private Sub frmHRCertificate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsHRCertificate.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuVietnameseEnglish.ItemClick
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRCertificate.LoadLang(Me, 1)
    '    Else
    '        clsHRCertificate.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuRefesh.ItemClick
    '    clsHRCertificate.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuAdd.ItemClick
    '    clsHRCertificate.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDelete.ItemClick
    '    clsHRCertificate.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUpdate.ItemClick
    '    clsHRCertificate.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSave.ItemClick
    '    clsHRCertificate.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVietnameseEnglish.ItemClick
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRCertificate.LoadLang(Me, 1)
    '    Else
    '        clsHRCertificate.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefesh.ItemClick
    '    clsHRCertificate.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick
    '    clsHRCertificate.ItemAdd(Me)
    'End Sub
    'Private Sub gridViewtable1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gridViewtable1.InitNewRow
    '    Dim row As DataRow = gridViewtable1.GetDataRow(e.RowHandle)
    '    row("IDCertificate") = txtIDCertificate.Text.Trim
    '    row("CertificateName") = txtName.Text.Trim
    '    row("Description") = txtDescription.Text.Trim
    '    gridViewtable1.RefreshRow(gridViewtable1.FocusedRowHandle)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
    '    clsHRCertificate.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUpdate.ItemClick
    '    clsHRCertificate.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
    '    clsHRCertificate.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUndo.ItemClick
    '    clsHRCertificate.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemVietnameseEnglish.LinkClicked
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRCertificate.LoadLang(Me, 1)
    '    Else
    '        clsHRCertificate.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemRefesh.LinkClicked
    '    clsHRCertificate.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemAdd.LinkClicked
    '    clsHRCertificate.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemDelete.LinkClicked
    '    clsHRCertificate.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemUpdate.LinkClicked
    '    clsHRCertificate.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles itemSave.LinkClicked
    '    clsHRCertificate.ItemSave(Me)
    'End Sub
    ''Center
    'Private Sub gridViewtable1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridViewtable1.DoubleClick
    '    If itemSave.Enabled Then Exit Sub
    '    intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '    clsHRCertificate.getRowGrid1(Me)
    'End Sub
    'Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRCity.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
    '    clsHRCertificate.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridControlTable2.DoubleClick
    '    clsHRCertificate.getRowGrid2(Me)
    'End Sub
End Class