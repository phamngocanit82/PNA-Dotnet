Imports vb = Microsoft.VisualBasic
Imports libraryPNA.clsSystem
Imports libraryPNA.clsMessage
Imports DevExpress.XtraGrid.Columns
Public Class frmHRCountry
    '    Public intLang As Integer = 1
    '    Public strExtension As String = ""
    '    Public intButton As Integer = 0
    '    Public intIndexTable1 = 0
    '    Public intTotalRow As Integer = 0
    '    Private Sub frmHRCountry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        clsHRCountry.LoadForm(Me)

    '    End Sub
    '    'Menu
    '    Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        If itemVietnameseEnglish.Caption <> "English" Then
    '            clsHRCountry.LoadLang(Me, 1)
    '        Else
    '            clsHRCountry.LoadLang(Me, 2)
    '        End If
    '    End Sub
    '    Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.RefeshDatabase(Me)
    '    End Sub
    '    Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemAdd(Me)
    '    End Sub
    '    Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemDelete(Me)
    '    End Sub
    '    Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemEdit(Me)
    '    End Sub
    '    Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemSave(Me)
    '    End Sub
    '    'Toolbar
    '    Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        If itemVietnameseEnglish.Caption <> "English" Then
    '            clsHRCountry.LoadLang(Me, 1)
    '        Else
    '            clsHRCountry.LoadLang(Me, 2)
    '        End If
    '    End Sub
    '    Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.RefeshDatabase(Me)
    '    End Sub
    '    Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemAdd(Me)
    '    End Sub
    '    Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemDelete(Me)
    '    End Sub
    '    Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemEdit(Me)
    '    End Sub
    '    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.ItemSave(Me)
    '    End Sub
    '    Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '        clsHRCountry.Undo(Me)
    '    End Sub
    '    'Submenu
    '    Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '        If itemVietnameseEnglish.Caption <> "English" Then
    '            clsHRCountry.LoadLang(Me, 1)
    '        Else
    '            clsHRCountry.LoadLang(Me, 2)
    '        End If
    '    End Sub
    '    Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '        clsHRCountry.RefeshDatabase(Me)
    '    End Sub
    '    Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '        clsHRCountry.ItemAdd(Me)
    '    End Sub
    '    Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '        clsHRCountry.ItemDelete(Me)
    '    End Sub
    '    Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '        clsHRCountry.ItemEdit(Me)
    '    End Sub
    '    Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '        clsHRCountry.ItemSave(Me)
    '    End Sub
    '    'Center
    '    Private Sub gridViewtable1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '        If itemSave.Enabled Then Exit Sub
    '        intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '        clsHRCountry.getRowGrid1(Me)
    '    End Sub
    '    Private Sub gridViewtable1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If itemSave.Enabled Then Exit Sub
    '        intIndexTable1 = gridViewtable1.GetSelectedRows()(0)
    '        clsHRCountry.getRowGrid1(Me)
    '    End Sub
    '    Private Sub gridViewtable1_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
    '        Dim row As DataRow = gridViewtable1.GetDataRow(e.RowHandle)
    '        row("IDCountry") = txtIDCountry.Text.Trim
    '        row("CountryName") = txtName.Text.Trim
    '        row("CountryCode") = txtCountryCode.Text.Trim
    '        row("Description") = txtDescription.Text.Trim
    '        gridViewtable1.RefreshRow(gridViewtable1.FocusedRowHandle)
    '    End Sub
    '    Private Sub btnSelectPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            picPicture.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    '            Dim s() As String
    '            s = Split(OpenFileDialog1.FileName, ".")
    '            strExtension = s(s.Length - 1)
    '        End If
    '    End Sub
    '    Private Sub btnDeletePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        picPicture.Image = Nothing
    '    End Sub
    '    Private Sub btnSavePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If picPicture.Image Is Nothing Then Exit Sub
    '        If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            picPicture.Image.Save(SaveFileDialog1.FileName)
    '        End If
    '    End Sub
    '    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        If e.KeyCode = Windows.Forms.Keys.Enter Then
    '            clsHRCity.ItemSearch(Me)
    '        End If
    '    End Sub
    '    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        clsHRCountry.ItemSearch(Me)
    '    End Sub
    '    Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        clsHRCountry.getRowGrid2(Me)
    '    End Sub
End Class