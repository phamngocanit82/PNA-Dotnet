Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRCompany
#Region " Global Form"
    Private Shared _frmHRCompany As frmHRCompany
    Public Shared Property GlobalForm() As frmHRCompany
        Get
            If _frmHRCompany Is Nothing OrElse _frmHRCompany.IsDisposed Then
                _frmHRCompany = New frmHRCompany
            End If
            Return _frmHRCompany
        End Get
        Set(ByVal Value As frmHRCompany)
            _frmHRCompany = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRCompany.xml"
    Dim _clsHRCompany As clsHRCompany
    Dim _rptHRCompany As rptHRCompany
#End Region
#Region "Methods"
#Region "Config"
    Private Sub _getSkin()
        Try
            Select Case clsConfig.GetSkinPNA
                Case "Skins1"

                Case "Skins2"

                Case "Skins3"

            End Select
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDCountry.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtIDCompany.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtCName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDirector.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtTax.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtBusiness.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtPhone.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtFax.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtEmail.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtWeb.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtAddress.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDCountry.Text = clsConfig.GetLanguage(1, _strLang)
            rdoBranch.Text = clsConfig.GetLanguage(2, _strLang)
            rdoHead.Text = clsConfig.GetLanguage(3, _strLang)
            lblIDCompany.Text = clsConfig.GetLanguage(4, _strLang)
            lblCName.Text = clsConfig.GetLanguage(5, _strLang)
            lblDirector.Text = clsConfig.GetLanguage(6, _strLang)
            lblTax.Text = clsConfig.GetLanguage(7, _strLang)
            lblBusiness.Text = clsConfig.GetLanguage(8, _strLang)
            lblPhone.Text = clsConfig.GetLanguage(9, _strLang)
            txtPhone.TextMenu1 = lblPhone.Text & "-1"
            txtPhone.TextMenu2 = lblPhone.Text & "-2"
            txtPhone.TextMenu3 = lblPhone.Text & "-3"
            txtPhone.Image1 = ImageList1.Images(0)
            txtPhone.Image2 = ImageList1.Images(0)
            txtPhone.Image3 = ImageList1.Images(0)
            lblFax.Text = clsConfig.GetLanguage(10, _strLang)
            txtFax.TextMenu1 = lblFax.Text & "-1"
            txtFax.TextMenu2 = lblFax.Text & "-2"
            txtFax.TextMenu3 = lblFax.Text & "-3"
            txtFax.Image1 = ImageList1.Images(1)
            txtFax.Image2 = ImageList1.Images(1)
            txtFax.Image3 = ImageList1.Images(1)
            lblEmail.Text = clsConfig.GetLanguage(11, _strLang)
            txtEmail.TextMenu1 = lblEmail.Text & "-1"
            txtEmail.TextMenu2 = lblEmail.Text & "-2"
            txtEmail.TextMenu3 = lblEmail.Text & "-3"
            txtEmail.Image1 = ImageList1.Images(2)
            txtEmail.Image2 = ImageList1.Images(2)
            txtEmail.Image3 = ImageList1.Images(2)
            lblWeb.Text = clsConfig.GetLanguage(12, _strLang)
            txtWeb.TextMenu1 = lblWeb.Text & "-1"
            txtWeb.TextMenu2 = lblWeb.Text & "-2"
            txtWeb.TextMenu3 = lblWeb.Text & "-3"
            txtWeb.Image1 = ImageList1.Images(3)
            txtWeb.Image2 = ImageList1.Images(3)
            txtWeb.Image3 = ImageList1.Images(3)
            lblAddress.Text = clsConfig.GetLanguage(13, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(14, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(15, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(16, _strLang)
            btnSave.Text = clsConfig.GetLanguage(17, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(18, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDCompany.Text = clsConfig.GetLanguage(4, _strLang)
            rdoCName.Text = clsConfig.GetLanguage(5, _strLang)
            rdoCountryName.Text = clsConfig.GetLanguage(19, _strLang)
            lblList.Text = clsConfig.GetLanguage(20, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(31, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(32, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(33, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(34, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._getLang)", , True)
        End Try
    End Sub
    Public Sub LoadConfig()
        _getSkin()
        _getFont()
        _getLang()
    End Sub
#End Region
#Region "Others"
    Private Sub _setDataGrid()
        Try
            If _clsHRCompany Is Nothing Then _clsHRCompany = New clsHRCompany
            grdCompany.AllowUserToAddRows = False
            grdCompany.AllowUserToDeleteRows = False
            grdCompany.ReadOnly = True
            grdCompany.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdCompany.RowHeadersWidth = 24
            grdCompany.DataSource = _clsHRCompany.GetTable()
            _setHeaderDataGrid()
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._setDataGrid)", "frmHRCompany._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            grdCompany.Columns(0).HeaderText = clsConfig.GetLanguage(1, _strLang)
            grdCompany.Columns(0).ToolTipText = grdCompany.Columns(0).HeaderText
            grdCompany.Columns(1).HeaderText = clsConfig.GetLanguage(4, _strLang)
            grdCompany.Columns(1).ToolTipText = grdCompany.Columns(1).HeaderText
            grdCompany.Columns(2).HeaderText = clsConfig.GetLanguage(5, _strLang)
            grdCompany.Columns(2).ToolTipText = grdCompany.Columns(2).HeaderText
            grdCompany.Columns(3).HeaderText = clsConfig.GetLanguage(2, _strLang)
            grdCompany.Columns(3).ToolTipText = grdCompany.Columns(3).HeaderText

            grdCompany.Columns(4).HeaderText = clsConfig.GetLanguage(6, _strLang)
            grdCompany.Columns(4).ToolTipText = grdCompany.Columns(4).HeaderText
            grdCompany.Columns(5).HeaderText = clsConfig.GetLanguage(7, _strLang)
            grdCompany.Columns(5).ToolTipText = grdCompany.Columns(5).HeaderText
            grdCompany.Columns(6).HeaderText = clsConfig.GetLanguage(8, _strLang)
            grdCompany.Columns(6).ToolTipText = grdCompany.Columns(6).HeaderText
            grdCompany.Columns(7).HeaderText = clsConfig.GetLanguage(9, _strLang)
            grdCompany.Columns(7).ToolTipText = grdCompany.Columns(7).HeaderText

            grdCompany.Columns(8).HeaderText = clsConfig.GetLanguage(10, _strLang)
            grdCompany.Columns(8).ToolTipText = grdCompany.Columns(8).HeaderText
            grdCompany.Columns(9).HeaderText = clsConfig.GetLanguage(11, _strLang)
            grdCompany.Columns(9).ToolTipText = grdCompany.Columns(9).HeaderText
            grdCompany.Columns(10).HeaderText = clsConfig.GetLanguage(12, _strLang)
            grdCompany.Columns(10).ToolTipText = grdCompany.Columns(10).HeaderText
            grdCompany.Columns(11).HeaderText = clsConfig.GetLanguage(13, _strLang)
            grdCompany.Columns(11).ToolTipText = grdCompany.Columns(11).HeaderText

            grdCompany.Columns(12).HeaderText = clsConfig.GetLanguage(35, _strLang)
            grdCompany.Columns(12).ToolTipText = grdCompany.Columns(12).HeaderText
            grdCompany.Columns(0).Width = 100
            grdCompany.Columns(1).Width = 200
            grdCompany.Columns(2).Width = 200
            grdCompany.Columns(3).Width = 80
            grdCompany.Columns(4).Width = 200
            grdCompany.Columns(5).Width = 200
            grdCompany.Columns(6).Width = 200
            grdCompany.Columns(7).Width = 200
            grdCompany.Columns(8).Width = 200
            grdCompany.Columns(9).Width = 200
            grdCompany.Columns(10).Width = 200
            grdCompany.Columns(11).Width = 200
            grdCompany.Columns(12).Width = 100
            lblList.Text = clsConfig.GetLanguage(20, _strLang) & " : " & grdCompany.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._setHeaderDataGrid)", "frmHRCompany._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            Dim _clsHRCountry As New clsHRCountry
            _clsHRCountry.GetInfor(grdCompany.Item(0, intRowIndex).Value.ToString)
            txtIDCountry.Text = _clsHRCountry.IDCountry
            lblCountryName.Text = _clsHRCountry.CName
            txtIDCompany.Text = grdCompany.Item(1, intRowIndex).Value.ToString
            txtCName.Text = grdCompany.Item(2, intRowIndex).Value.ToString
            If CBool(grdCompany.Item(3, intRowIndex).Value) = False Then
                rdoHead.Checked = True
            Else
                rdoBranch.Checked = True
            End If
            txtDirector.Text = grdCompany.Item(4, intRowIndex).Value.ToString
            txtTax.Text = grdCompany.Item(5, intRowIndex).Value.ToString
            txtBusiness.Text = grdCompany.Item(6, intRowIndex).Value.ToString
            _setTextPNA1(txtPhone, grdCompany.Item(7, intRowIndex).Value.ToString)
            _setTextPNA1(txtFax, grdCompany.Item(8, intRowIndex).Value.ToString)
            _setTextPNA1(txtEmail, grdCompany.Item(9, intRowIndex).Value.ToString)
            _setTextPNA1(txtWeb, grdCompany.Item(10, intRowIndex).Value.ToString)
            txtAddress.Text = grdCompany.Item(11, intRowIndex).Value.ToString
            Try
                picPicture.Image = ByteToImage(grdCompany.Item(12, intRowIndex).Value)
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
            _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._getCellEnter)", "frmHRCompany._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdCompany.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._getCellCurrent)", "frmHRCompany._getCellCurrent", True)
        End Try
    End Sub
    Private Sub _setTextPNA1(ByRef txtTextBox As OmegaSkins.TextBoxStyle1PNA, ByVal strValue As String)
        Try
            Dim strTmp(3) As String
            strTmp = VB.Split(strValue, ",")
            txtTextBox.Text = strTmp(0)
            txtTextBox.Text1 = strTmp(0)
            Select Case strTmp.Length
                Case 1
                    txtTextBox.Text2 = ""
                    txtTextBox.Text3 = ""
                Case 2
                    txtTextBox.Text2 = strTmp(1)
                    txtTextBox.Text3 = ""
                Case 3
                    txtTextBox.Text2 = strTmp(1)
                    txtTextBox.Text3 = strTmp(2)
            End Select
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._setTextPNA1)", "frmHRCompany._setTextPNA1", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDCompany.TReadOnly = bolFlag
            txtCName.TReadOnly = bolFlag
            txtDirector.TReadOnly = bolFlag
            txtTax.TReadOnly = bolFlag
            txtBusiness.TReadOnly = bolFlag
            txtPhone.TReadOnly = bolFlag
            txtFax.TReadOnly = bolFlag
            txtEmail.TReadOnly = bolFlag
            txtWeb.TReadOnly = bolFlag
            txtAddress.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDCountry.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._setReadOnly)", "frmHRCompany._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDCountry.Text = ""
        lblCountryName.Text = ""
        txtIDCompany.Text = ""
        txtCName.Text = ""
        rdoBranch.Checked = True
        txtDirector.Text = ""
        txtTax.Text = ""
        txtBusiness.Text = ""
        txtPhone.Text = "" : txtPhone.Text1 = "" : txtPhone.Text2 = "" : txtPhone.Text3 = ""
        txtFax.Text = "" : txtFax.Text1 = "" : txtFax.Text2 = "" : txtFax.Text3 = ""
        txtEmail.Text = "" : txtEmail.Text1 = "" : txtEmail.Text2 = "" : txtEmail.Text3 = ""
        txtWeb.Text = "" : txtWeb.Text1 = "" : txtWeb.Text2 = "" : txtWeb.Text3 = ""
        txtAddress.Text = ""
        picPicture.Image = Nothing
    End Sub
    Private Sub _setCompany()
        Try
            _clsHRCompany.IDCountry = txtIDCountry.Text.Trim
            _clsHRCompany.IDCompany = txtIDCompany.Text.Trim
            _clsHRCompany.CName = txtCName.Text.Trim
            _clsHRCompany.Branch = rdoBranch.Checked
            _clsHRCompany.Director = txtDirector.Text.Trim
            _clsHRCompany.TaxCode = txtTax.Text.Trim
            _clsHRCompany.Business = txtBusiness.Text.Trim
            _clsHRCompany.Phone = txtPhone.Text1.Trim & "," & txtPhone.Text2.Trim & "," & txtPhone.Text3.Trim
            _clsHRCompany.Fax = txtFax.Text1.Trim & "," & txtFax.Text2.Trim & "," & txtFax.Text3.Trim
            _clsHRCompany.Email = txtEmail.Text1.Trim & "," & txtEmail.Text2.Trim & "," & txtEmail.Text3.Trim
            _clsHRCompany.WebSite = txtWeb.Text1.Trim & "," & txtWeb.Text2.Trim & "," & txtWeb.Text3.Trim
            _clsHRCompany.Address = txtAddress.Text.Trim
            Try
                _clsHRCompany.CPicture = picPicture.Image
            Catch ex As Exception
                _clsHRCompany.CPicture = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._setCompany)", "frmHRCompany._setCompany", True)
        End Try
    End Sub
    Private Sub _getCompany()
        Try
            Dim _clsHRCountry As New clsHRCountry
            _clsHRCountry.GetInfor(_clsHRCompany.IDCountry)
            txtIDCountry.Text = _clsHRCountry.IDCountry
            lblCountryName.Text = _clsHRCountry.CName
            txtIDCompany.Text = _clsHRCompany.IDCompany
            txtCName.Text = _clsHRCompany.CName
            If _clsHRCompany.Branch Then
                rdoBranch.Checked = True
            Else
                rdoHead.Checked = True
            End If
            txtDirector.Text = _clsHRCompany.Director
            txtTax.Text = _clsHRCompany.TaxCode
            txtBusiness.Text = _clsHRCompany.Business
            _setTextPNA1(txtPhone, _clsHRCompany.Phone)
            _setTextPNA1(txtFax, _clsHRCompany.Fax)
            _setTextPNA1(txtEmail, _clsHRCompany.Email)
            _setTextPNA1(txtWeb, _clsHRCompany.WebSite)
            txtAddress.Text = _clsHRCompany.Address
            Try
                Dim oBitmap As New Bitmap(_clsHRCompany.CPicture)
                picPicture.Image = oBitmap
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
            _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._getCompany)", "frmHRCompany._getCompany", True)
        End Try
    End Sub
    Private Sub _XMLNewRow(ByRef oDataTable As DataTable, ByVal strFields As String, ByVal strData As String)
        Try
            Dim oDataRow As DataRow
            oDataRow = oDataTable.NewRow
            oDataRow("Fields") = strFields
            oDataRow("Data") = strData
            oDataTable.Rows.Add(oDataRow)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._XMLNewRow)", "frmHRCompany._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _showHRLCountry()
        Try
            Dim _frmHRLCountry As New frmHRLCountry
            _frmHRLCountry.showForm(Me)
            If _frmHRLCountry.IsDisposed = False And Not _frmHRLCountry Is Nothing Then
                txtIDCountry.Text = _frmHRLCountry.grdCountry.Item(0, _frmHRLCountry.grdCountry.CurrentCell.RowIndex).Value
                lblCountryName.Text = _frmHRLCountry.grdCountry.Item(1, _frmHRLCountry.grdCountry.CurrentCell.RowIndex).Value
                _frmHRLCountry.Close()
                _frmHRLCountry.Dispose() : _frmHRLCountry = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._showHRLCountry)", "frmHRCompany._showHRLCountry", True)
        End Try
    End Sub
    Private Sub _add()
        Try
            If CheckAdd("frmHRCompany") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(21, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._add)", "frmHRCompany._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDCompany.Text = "" Then Exit Sub
            If CheckDelete("frmHRCompany") Then
                If clsHRCompany.IsExistDepartment(txtIDCompany.Text) = False Then
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        clsHRCompany.Delete(txtIDCompany.Text)
                        _setDataGrid()
                        _getCellCurrent()
                    End If
                Else
                    ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(36, _strLang), , InforButton.Ok)
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(22, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._delete)", "frmHRCompany._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmHRCompany") Then
                _setReadOnly(False)
                txtIDCountry.Focus()
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._update)", "frmHRCompany._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDCountry.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(27, _strLang), , InforButton.Ok)
                txtIDCountry.Focus()
                Exit Sub
            End If
            If txtIDCompany.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(28, _strLang), , InforButton.Ok)
                txtIDCompany.Focus()
                Exit Sub
            End If
            If txtCName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(29, _strLang), , InforButton.Ok)
                txtCName.Focus()
                Exit Sub
            End If
            If txtDirector.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(30, _strLang), , InforButton.Ok)
                txtCName.Focus()
                Exit Sub
            End If
            If clsHRCompany.IsExistDepartment(txtIDCompany.Text) = True Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(36, _strLang), , InforButton.Ok)
                Exit Sub
            End If
            If CheckSave("frmHRCompany") Then
                If clsHRCompany.IsExist(txtIDCompany.Text) Then
                    If CheckUpdate("frmHRCompany") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(26, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHRCompany Is Nothing Then _clsHRCompany = New clsHRCompany
                            _setCompany()
                            _clsHRCompany.Update()
                            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
                        Else
                            txtIDCountry.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(26, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHRCompany Is Nothing Then _clsHRCompany = New clsHRCompany
                        _setCompany()
                        _clsHRCompany.Add()
                        _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
                    Else
                        txtIDCountry.Focus()
                        Exit Sub
                    End If
                End If
                _setReadOnly(True)
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                _setDataGrid()
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(24, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._save)", "frmHRCompany._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHRCompany Is Nothing Then _clsHRCompany = New clsHRCompany
            If txtSearch.Text = "" Or txtSearch.Text = "*" Then
                grdCompany.DataSource = _clsHRCompany.GetTable()
            Else
                If rdoIDCompany.Checked Then
                    grdCompany.DataSource = _clsHRCompany.Search("IDCompany", txtSearch.Text)
                Else
                    If rdoCName.Checked Then
                        grdCompany.DataSource = _clsHRCompany.Search("CName", txtSearch.Text)
                    Else
                        If rdoCountryName.Checked Then
                            grdCompany.DataSource = _clsHRCompany.Search("HRCon.CName", txtSearch.Text)
                        End If
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._search)", "frmHRCompany._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Company"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HRCompany")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDCountry.Text)
                _XMLNewRow(oDataTable, "1", lblCountryName.Text)
                _XMLNewRow(oDataTable, "2", txtIDCompany.Text)
                _XMLNewRow(oDataTable, "3", txtCName.Text)
                If rdoBranch.Checked = True Then
                    _XMLNewRow(oDataTable, "4", "1")
                Else
                    _XMLNewRow(oDataTable, "4", "0")
                End If
                _XMLNewRow(oDataTable, "5", txtDirector.Text)
                _XMLNewRow(oDataTable, "6", txtTax.Text)
                _XMLNewRow(oDataTable, "7", txtBusiness.Text)
                _XMLNewRow(oDataTable, "8", txtPhone.Text1 & "," & txtPhone.Text2 & "," & txtPhone.Text3)
                _XMLNewRow(oDataTable, "9", txtFax.Text1 & "," & txtFax.Text2 & "," & txtFax.Text3)
                _XMLNewRow(oDataTable, "10", txtEmail.Text1 & "," & txtEmail.Text2 & "," & txtEmail.Text3)
                _XMLNewRow(oDataTable, "11", txtWeb.Text1 & "," & txtWeb.Text2 & "," & txtWeb.Text3)
                _XMLNewRow(oDataTable, "12", txtAddress.Text)
                _XMLNewRow(oDataTable, "13", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                Try
                    picPicture.Image.Save(SaveFileDialog1.FileName & ".jpg")
                Catch ex As Exception

                End Try
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._saveFileDialog)", "frmHRCompany._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Company"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Company.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Company.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Company.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Company.xml")
                txtIDCountry.Text = dsData.Tables(0).Rows(0)("Data")
                lblCountryName.Text = dsData.Tables(0).Rows(1)("Data")
                If txtIDCompany.TReadOnly = False Then
                    txtIDCompany.Text = dsData.Tables(0).Rows(2)("Data")
                End If
                txtCName.Text = dsData.Tables(0).Rows(3)("Data")
                If dsData.Tables(0).Rows(4)("Data") = "1" Then
                    rdoBranch.Checked = True
                Else
                    rdoHead.Checked = True
                End If
                txtDirector.Text = dsData.Tables(0).Rows(5)("Data")
                txtTax.Text = dsData.Tables(0).Rows(6)("Data")
                txtBusiness.Text = dsData.Tables(0).Rows(7)("Data")
                _setTextPNA1(txtPhone, dsData.Tables(0).Rows(8)("Data"))
                _setTextPNA1(txtFax, dsData.Tables(0).Rows(9)("Data"))
                _setTextPNA1(txtEmail, dsData.Tables(0).Rows(10)("Data"))
                _setTextPNA1(txtWeb, dsData.Tables(0).Rows(11)("Data"))
                txtAddress.Text = dsData.Tables(0).Rows(12)("Data")
                Try
                    picPicture.Image = Image.FromFile(OpenFileDialog1.FileName & ".jpg")
                Catch ex As Exception
                    picPicture.Image = Nothing
                End Try
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Company.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._openFileDialog)", "frmHRCompany._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        'Try
        '    If Not _rptHRCompany Is Nothing Then Exit Sub
        '    If _rptHRCompany Is Nothing Then _rptHRCompany = New rptHRCompany
        '    If _clsHRCompany Is Nothing Then _clsHRCompany = New clsHRCompany
        '    _rptHRCompany.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
        '    _rptHRCompany.Database.Tables(0).SetDataSource(_clsHRCompany.GetTable)
        '    _rptHRCompany.Refresh()
        '    _rptHRCompany.SetParameterValue("lblCountry", clsConfig.GetLanguage(9, _strLang, True))
        '    _rptHRCompany.SetParameterValue("lblIDCountry", clsConfig.GetLanguage(1, _strLang, True))
        '    _rptHRCompany.SetParameterValue("lblCName", clsConfig.GetLanguage(2, _strLang, ))
        '    _rptHRCompany.SetParameterValue("lblDescrible", clsConfig.GetLanguage(3, _strLang, True))
        '    _rptHRCompany.SetParameterValue("lblPicture", clsConfig.GetLanguage(22, _strLang, True))
        '    frmReview.GlobalForm.lblCaption.Text = clsConfig.GetLanguage(9, _strLang)
        '    frmReview.GlobalForm.rptViewer.ReportSource = _rptHRCompany
        '    frmReview.GlobalForm.ShowDialog(Me)
        '    _rptHRCompany.Dispose() : _rptHRCompany = Nothing
        '    _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        'Catch ex As Exception
        '    ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._Review)", "frmHRCompany._Review", True)
        'End Try
    End Sub
    Private Sub _refesh()
        Try
            _setReadOnly(True)
            btnAdd.Enabled = True
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            _setDataGrid()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCompany._refesh)", "frmHRCompany._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDCountry_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIDCountry.DoubleClick
        _showHRLCountry()
    End Sub
    Private Sub txtIDCountry_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDCountry.KeyDown
        If e.KeyCode = Keys.F4 Then
            _showHRLCountry()
            Exit Sub
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtIDCompany.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtIDCompany_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDCompany.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtCName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDCountry.Focus()
            End If
        End If
    End Sub
    Private Sub txtCName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDirector.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDCompany.Focus()
            End If
        End If
    End Sub
    Private Sub txtDirector_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDirector.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtTax.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtCName.Focus()
            End If
        End If
    End Sub
    Private Sub txtTax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTax.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtBusiness.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtDirector.Focus()
            End If
        End If
    End Sub
    Private Sub txtBusiness_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusiness.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtPhone.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtTax.Focus()
            End If
        End If
    End Sub
    Private Sub txtPhone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtFax.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtBusiness.Focus()
            End If
        End If
    End Sub
    Private Sub txtFax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtPhone.Focus()
            End If
        End If
    End Sub
    Private Sub txtEmail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtWeb.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtFax.Focus()
            End If
        End If
    End Sub
    Private Sub txtWeb_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWeb.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtAddress.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtEmail.Focus()
            End If
        End If
    End Sub
    Private Sub txtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtWeb.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HRCompany"
    Private Sub frmHRCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHRCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.A Then
            _add()
        Else
            If e.KeyData = Keys.Control + Keys.D Then
                _delete()
            Else
                If e.KeyData = Keys.Control + Keys.U Then
                    _update()
                Else
                    If e.KeyData = Keys.Control + Keys.S Then
                        _save()
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "Others"
    Private Sub txtIDCompany_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDCompany.Validating
        Try
            If txtIDCompany.Text <> "" Then
                If clsHRCompany.IsExist(txtIDCompany.Text) Then
                    If _clsHRCompany Is Nothing Then _clsHRCompany = New clsHRCompany
                    _clsHRCompany.GetInfor(txtIDCompany.Text)
                    _getCompany()
                    _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry.txtIDCompany_Validating)", "frmHRCountry.txtIDCompany_Validating", True)
        End Try
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        _add()
    End Sub
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        _delete()
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        _update()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        _save()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        _search()
    End Sub
    Private Sub grdCompany_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCompany.CellEnter
        _getCellEnter(e.RowIndex)
    End Sub
    Private Sub tbrSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrSave.Click
        _saveFileDialog()
    End Sub
    Private Sub tbrOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrOpen.Click
        _openFileDialog()
    End Sub
    Private Sub tbrReview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrReview.Click
        _review()
    End Sub
    Private Sub tbrRefesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrRefesh.Click
        _refesh()
    End Sub
#End Region
#End Region
End Class