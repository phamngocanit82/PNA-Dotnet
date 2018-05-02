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
Public Class frmACCBank
    'Public intLang As Integer = 1
    'Public strExtension As String = ""
    'Public intButton As Integer = 0
    'Public intIndexTable1 = 0
    'Public intTotalRow As Integer = 0
    'Public strIDBank As String = ""
    'Public strIDCountry As String = ""
    'Public strCountryName As String = ""
    'Public strIDCity As String = ""
    'Public strCityName As String = ""
    'Public strIDDistrict As String = ""
    'Public strDistrictName As String = ""
    'Private flagPopupCountry As Boolean = False
    'Private flagPopupCity As Boolean = False
    'Private flagPopupDistrict As Boolean = False
    'Private Sub frmACCBank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    clsACCBank.LoadForm(Me)
    'End Sub
    ''Menu
    'Private Sub mnuVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsACCBank.LoadLang(Me, 1)
    '    Else
    '        clsACCBank.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub mnuRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.RefeshDatabase(Me)
    'End Sub
    'Private Sub mnuAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemAdd(Me)
    'End Sub
    'Private Sub mnuDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemDelete(Me)
    'End Sub
    'Private Sub mnuUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemEdit(Me)
    'End Sub
    'Private Sub mnuSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemSave(Me)
    'End Sub
    ''Toolbar
    'Private Sub btnVietnameseEnglish_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsACCBank.LoadLang(Me, 1)
    '    Else
    '        clsACCBank.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub btnRefesh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.RefeshDatabase(Me)
    'End Sub
    'Private Sub btnAdd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemAdd(Me)
    'End Sub
    'Private Sub btnDelete_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemDelete(Me)
    'End Sub
    'Private Sub btnUpdate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemEdit(Me)
    'End Sub
    'Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.ItemSave(Me)
    'End Sub
    'Private Sub btnUndo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
    '    clsACCBank.Undo(Me)
    'End Sub
    ''Submenu
    'Private Sub itemVietnameseEnglish_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    If itemVietnameseEnglish.Caption <> "English" Then
    '        clsACCBank.LoadLang(Me, 1)
    '    Else
    '        clsACCBank.LoadLang(Me, 2)
    '    End If
    'End Sub
    'Private Sub itemRefesh_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsACCBank.RefeshDatabase(Me)
    'End Sub
    'Private Sub itemAdd_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsACCBank.ItemAdd(Me)
    'End Sub
    'Private Sub itemDelete_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsACCBank.ItemDelete(Me)
    'End Sub
    'Private Sub itemUpdate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsACCBank.ItemEdit(Me)
    'End Sub
    'Private Sub itemSave_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
    '    clsACCBank.ItemSave(Me)
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
    '        clsACCBank.ItemSearch(Me)
    '    End If
    'End Sub
    'Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsACCBank.ItemSearch(Me)
    'End Sub
    'Private Sub gridControlTable2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsACCBank.getRowGrid2(Me)
    'End Sub
    ''Popup
    ''1
    'Private Sub txtPopupSearch1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Windows.Forms.Keys.Enter Then
    '        clsACCBank.ItemPopupSearch1(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsACCBank.ItemPopupSearch1(Me)
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
    '        clsACCBank.ItemPopupSearch2(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsACCBank.ItemPopupSearch2(Me)
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
    '        clsACCBank.ItemPopupSearch3(Me)
    '    End If
    'End Sub
    'Private Sub btnPopupSearch3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    clsACCBank.ItemPopupSearch3(Me)
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