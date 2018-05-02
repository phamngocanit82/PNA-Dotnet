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
Public Class frmHRLaborContract
    'Public intLang As Integer = 1
    'Public strExtension As String = ""
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Private Sub frmHRLaborContract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsHRLaborContract.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRLaborContract.LoadLang(Me, 1)
    '    Else
    '        clsHRLaborContract.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRLaborContract.LoadLang(Me, 1)
    '    Else
    '        clsHRLaborContract.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemAdd(Me)
    'End Sub
    'Private Sub gridViewtable1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '    Dim row As DataRow = gridViewtable1.GetDataRow(e.RowHandle)
    '    row("IDLaborContract") = txtIDLaborContract.Text.Trim
    '    row("LaborContractName") = txtName.Text.Trim
    '    row("Description") = txtDescription.Text.Trim
    '    gridViewtable1.RefreshRow(gridViewtable1.FocusedRowHandle)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRLaborContract.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRLaborContract.LoadLang(Me, 1)
    '    Else
    '        clsHRLaborContract.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRLaborContract.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRLaborContract.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRLaborContract.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRLaborContract.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRLaborContract.ItemSave(Me)
    'End Sub
    ''Center
    'Private Sub gridViewtable1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If itemSave.Enabled Then Exit Sub
    '    intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '    clsHRLaborContract.getRowGrid1(Me)
    'End Sub
    'Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRCity.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRLaborContract.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRLaborContract.getRowGrid2(Me)
    'End Sub
End Class