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
Public Class frmHRHospital
    'Public intLang As Integer = 1
    'Public strExtension As String = ""
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Public strIDHospital As String = ""
    'Public strIDCountry As String = ""
    'Public strCountryName As String = ""
    'Public strIDCity As String = ""
    'Public strCityName As String = ""
    'Public strIDDistrict As String = ""
    'Public strDistrictName As String = ""
    'Private flagPopupCountry As Boolean = False
    'Private flagPopupCity As Boolean = False
    'Private flagPopupDistrict As Boolean = False
    'Private Sub frmHRHospital_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsHRHospital.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRHospital.LoadLang(Me, 1)
    '    Else
    '        clsHRHospital.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRHospital.LoadLang(Me, 1)
    '    Else
    '        clsHRHospital.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemAdd(Me)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsHRHospital.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsHRHospital.LoadLang(Me, 1)
    '    Else
    '        clsHRHospital.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRHospital.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRHospital.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRHospital.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRHospital.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsHRHospital.ItemSave(Me)
    'End Sub
    ''Center
    'Private Sub btnSelectPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '        picPicture.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
    '        Dim s() As String
    '        s = Split(OpenFileDialog1.FileName, ".")
    '        strExtension = s(s.Length - 1)
    '    End If
    'End Sub
    'Private Sub btnDeletePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    picPicture.Image = Nothing
    'End Sub
    'Private Sub btnSavePicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If picPicture.Image Is Nothing Then Exit Sub
    '    If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '        picPicture.Image.Save(SaveFileDialog1.FileName)
    '    End If
    'End Sub
    'Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRHospital.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRHospital.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRHospital.getRowGrid2(Me)
    'End Sub
    ''Popup
    ''1
    'Private Sub txtPopupSearch1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRHospital.ItemPopupSearch1(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRHospital.ItemPopupSearch1(Me)
    'End Sub
    'Private Sub btnPopupSelect1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch1.OwnerEdit Is Nothing Then
    '        flagPopupCountry = True
    '        pnlPopupSearch1.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub gridControlPopup1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch1.OwnerEdit Is Nothing Then
    '        flagPopupCountry = True
    '        pnlPopupSearch1.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub cboPopupCountry1_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
    '    If flagPopupCountry = True Then
    '        If gridViewPopup1.RowCount > 0 Then
    '            strIDCountry = gridViewPopup1.GetFocusedRowCellValue("IDCountry").ToString
    '            strCountryName = gridViewPopup1.GetFocusedRowCellValue("CountryName").ToString
    '            e.Value = gridViewPopup1.GetFocusedRowCellValue("CountryName").ToString
    '            flagPopupCountry = False
    '            Exit Sub
    '        End If
    '        e.Value = ""
    '        strIDCountry = ""
    '        strCountryName = ""
    '        flagPopupCountry = False
    '    End If
    'End Sub
    ''2
    'Private Sub txtPopupSearch2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRHospital.ItemPopupSearch2(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRHospital.ItemPopupSearch2(Me)
    'End Sub
    'Private Sub btnPopupSelect2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch2.OwnerEdit Is Nothing Then
    '        flagPopupCity = True
    '        pnlPopupSearch2.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub gridControlPopup2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch2.OwnerEdit Is Nothing Then
    '        flagPopupCity = True
    '        pnlPopupSearch2.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub cboPopupCity_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
    '    If flagPopupCity = True Then
    '        If gridViewPopup2.RowCount > 0 Then
    '            strIDCity = gridViewPopup2.GetFocusedRowCellValue("IDCity").ToString
    '            strCityName = gridViewPopup2.GetFocusedRowCellValue("CityName").ToString
    '            e.Value = gridViewPopup2.GetFocusedRowCellValue("CityName").ToString
    '            flagPopupCity = False
    '            Exit Sub
    '        End If
    '        e.Value = ""
    '        strIDCity = ""
    '        strCityName = ""
    '        flagPopupCity = False
    '    End If
    'End Sub
    ''3
    'Private Sub txtPopupSearch3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsHRHospital.ItemPopupSearch3(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsHRHospital.ItemPopupSearch3(Me)
    'End Sub
    'Private Sub btnPopupSelect3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch3.OwnerEdit Is Nothing Then
    '        flagPopupDistrict = True
    '        pnlPopupSearch3.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub gridControlPopup3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not pnlPopupSearch3.OwnerEdit Is Nothing Then
    '        flagPopupDistrict = True
    '        pnlPopupSearch3.OwnerEdit.ClosePopup()
    '    End If
    'End Sub
    'Private Sub cboPopupDistrict_QueryResultValue(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
    '    If flagPopupDistrict = True Then
    '        If gridViewPopup3.RowCount > 0 Then
    '            strIDDistrict = gridViewPopup3.GetFocusedRowCellValue("IDDistrict").ToString
    '            strDistrictName = gridViewPopup3.GetFocusedRowCellValue("DistrictName").ToString
    '            e.Value = gridViewPopup3.GetFocusedRowCellValue("DistrictName").ToString
    '            flagPopupDistrict = False
    '            Exit Sub
    '        End If
    '        e.Value = ""
    '        strIDDistrict = ""
    '        strDistrictName = ""
    '        flagPopupDistrict = False
    '    End If
    'End Sub
End Class