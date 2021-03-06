Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmULSupplier
#Region " Global Form"
    Private Shared _frmULSupplier As frmULSupplier
    Public Shared Property GlobalForm() As frmULSupplier
        Get
            If _frmULSupplier Is Nothing OrElse _frmULSupplier.IsDisposed Then
                _frmULSupplier = New frmULSupplier
            End If
            Return _frmULSupplier
        End Get
        Set(ByVal Value As frmULSupplier)
            _frmULSupplier = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OUL\XMLULSupplier.xml"
    Dim _clsULSupplier As clsULSupplier
    Dim _rptULSupplier As rptULSupplier
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getSkin)", "frmULSupplier._getSkin", True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDSupplier.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDescrible.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtBusiness.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtPhone.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtFax.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtEmail.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtWeb.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtAddress.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getFont)", "frmULSupplier._getFont", True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDSupplier.Text = clsConfig.GetLanguage(1, _strLang)
            lblSName.Text = clsConfig.GetLanguage(2, _strLang)
            lblDescrible.Text = clsConfig.GetLanguage(3, _strLang)
            lblBusiness.Text = clsConfig.GetLanguage(4, _strLang)
            lblPhone.Text = clsConfig.GetLanguage(5, _strLang)
            txtPhone.TextMenu1 = lblPhone.Text & "-1"
            txtPhone.TextMenu2 = lblPhone.Text & "-2"
            txtPhone.TextMenu3 = lblPhone.Text & "-3"
            txtPhone.Image1 = ImageList1.Images(0)
            txtPhone.Image2 = ImageList1.Images(0)
            txtPhone.Image3 = ImageList1.Images(0)
            lblFax.Text = clsConfig.GetLanguage(6, _strLang)
            txtFax.TextMenu1 = lblFax.Text & "-1"
            txtFax.TextMenu2 = lblFax.Text & "-2"
            txtFax.TextMenu3 = lblFax.Text & "-3"
            txtFax.Image1 = ImageList1.Images(1)
            txtFax.Image2 = ImageList1.Images(1)
            txtFax.Image3 = ImageList1.Images(1)
            lblEmail.Text = clsConfig.GetLanguage(7, _strLang)
            txtEmail.TextMenu1 = lblEmail.Text & "-1"
            txtEmail.TextMenu2 = lblEmail.Text & "-2"
            txtEmail.TextMenu3 = lblEmail.Text & "-3"
            txtEmail.Image1 = ImageList1.Images(2)
            txtEmail.Image2 = ImageList1.Images(2)
            txtEmail.Image3 = ImageList1.Images(2)
            lblWeb.Text = clsConfig.GetLanguage(8, _strLang)
            txtWeb.TextMenu1 = lblWeb.Text & "-1"
            txtWeb.TextMenu2 = lblWeb.Text & "-2"
            txtWeb.TextMenu3 = lblWeb.Text & "-3"
            txtWeb.Image1 = ImageList1.Images(3)
            txtWeb.Image2 = ImageList1.Images(3)
            txtWeb.Image3 = ImageList1.Images(3)
            lblAddress.Text = clsConfig.GetLanguage(9, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(10, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(11, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(12, _strLang)
            btnSave.Text = clsConfig.GetLanguage(13, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(14, _strLang)
            btnSearch.Text = "    &" & lblSearch.Text
            rdoIDSupplier.Text = clsConfig.GetLanguage(1, _strLang)
            rdoSName.Text = clsConfig.GetLanguage(2, _strLang)
            rdoAddress.Text = clsConfig.GetLanguage(9, _strLang)
            lblList.Text = clsConfig.GetLanguage(15, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(26, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(27, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(28, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(29, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getLang)", "frmULSupplier._getLang", True)
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
            If _clsULSupplier Is Nothing Then _clsULSupplier = New clsULSupplier
            grdSupplier.AllowUserToAddRows = False
            grdSupplier.AllowUserToDeleteRows = False
            grdSupplier.AllowUserToResizeRows = False
            grdSupplier.ReadOnly = True
            grdSupplier.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdSupplier.RowHeadersWidth = 24
            grdSupplier.DataSource = _clsULSupplier.GetTable()
            _setHeaderDataGrid()
            _clsULSupplier.DisposedSupplier() : _clsULSupplier = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._setDataGrid)", "frmULSupplier._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            Dim i As Integer
            For i = 0 To grdSupplier.Columns.Count - 1
                grdSupplier.Columns(i).HeaderText = clsConfig.GetLanguage(i + 1, _strLang)
                grdSupplier.Columns(i).ToolTipText = grdSupplier.Columns(i).HeaderText
            Next
            grdSupplier.Columns(0).Width = 115
            grdSupplier.Columns(1).Width = 250
            grdSupplier.Columns(2).Width = 200
            grdSupplier.Columns(3).Width = 200
            grdSupplier.Columns(4).Width = 200
            grdSupplier.Columns(5).Width = 200
            grdSupplier.Columns(6).Width = 200
            grdSupplier.Columns(7).Width = 200
            grdSupplier.Columns(8).Width = 300
            lblList.Text = clsConfig.GetLanguage(15, _strLang) & " : " & grdSupplier.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._setHeaderDataGrid)", "frmULSupplier._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            txtIDSupplier.Text = grdSupplier.Item(0, intRowIndex).Value.ToString
            txtSName.Text = grdSupplier.Item(1, intRowIndex).Value.ToString
            txtDescrible.Text = grdSupplier.Item(2, intRowIndex).Value.ToString
            txtBusiness.Text = grdSupplier.Item(3, intRowIndex).Value.ToString
            _setTextPNA1(txtPhone, grdSupplier.Item(4, intRowIndex).Value.ToString)
            _setTextPNA1(txtFax, grdSupplier.Item(5, intRowIndex).Value.ToString)
            _setTextPNA1(txtEmail, grdSupplier.Item(6, intRowIndex).Value.ToString)
            _setTextPNA1(txtWeb, grdSupplier.Item(7, intRowIndex).Value.ToString)
            txtAddress.Text = grdSupplier.Item(8, intRowIndex).Value.ToString
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getCellEnter)", "frmULSupplier._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdSupplier.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getCellCurrent)", "frmULSupplier._getCellCurrent", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._setTextPNA1)", "frmULSupplier._setTextPNA1", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDSupplier.TReadOnly = bolFlag
            txtSName.TReadOnly = bolFlag
            txtDescrible.TReadOnly = bolFlag
            txtBusiness.TReadOnly = bolFlag
            txtPhone.TReadOnly = bolFlag
            txtFax.TReadOnly = bolFlag
            txtEmail.TReadOnly = bolFlag
            txtWeb.TReadOnly = bolFlag
            txtAddress.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDSupplier.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._setReadOnly)", "frmULSupplier._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDSupplier.Text = ""
        txtSName.Text = ""
        txtDescrible.Text = ""
        txtBusiness.Text = ""
        txtPhone.Text = ""
        txtPhone.Text1 = ""
        txtPhone.Text2 = ""
        txtPhone.Text3 = ""
        txtFax.Text = ""
        txtFax.Text1 = ""
        txtFax.Text2 = ""
        txtFax.Text3 = ""
        txtEmail.Text = ""
        txtEmail.Text1 = ""
        txtEmail.Text2 = ""
        txtEmail.Text3 = ""
        txtWeb.Text = ""
        txtWeb.Text1 = ""
        txtWeb.Text2 = ""
        txtWeb.Text3 = ""
        txtAddress.Text = ""
    End Sub
    Private Sub _setSupplier()
        Try
            _clsULSupplier.IDSupplier = txtIDSupplier.Text.Trim
            _clsULSupplier.SName = txtSName.Text.Trim
            _clsULSupplier.Describle = txtDescrible.Text.Trim
            _clsULSupplier.Business = txtBusiness.Text.Trim
            _clsULSupplier.Phone = txtPhone.Text1.Trim & "," & txtPhone.Text2.Trim & "," & txtPhone.Text3.Trim
            _clsULSupplier.Fax = txtFax.Text1.Trim & "," & txtFax.Text2.Trim & "," & txtFax.Text3.Trim
            _clsULSupplier.Email = txtEmail.Text1.Trim & "," & txtEmail.Text2.Trim & "," & txtEmail.Text3.Trim
            _clsULSupplier.WebSite = txtWeb.Text1.Trim & "," & txtWeb.Text2.Trim & "," & txtWeb.Text3.Trim
            _clsULSupplier.Address = txtAddress.Text.Trim
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._setSupplier)", "frmULSupplier._setSupplier", True)
        End Try
    End Sub
    Private Sub _getSupplier()
        Try
            txtIDSupplier.Text = _clsULSupplier.IDSupplier
            txtSName.Text = _clsULSupplier.SName
            txtDescrible.Text = _clsULSupplier.Describle
            txtBusiness.Text = _clsULSupplier.Business
            _setTextPNA1(txtPhone, _clsULSupplier.Phone)
            _setTextPNA1(txtFax, _clsULSupplier.Fax)
            _setTextPNA1(txtEmail, _clsULSupplier.Email)
            _setTextPNA1(txtWeb, _clsULSupplier.WebSite)
            txtAddress.Text = _clsULSupplier.Address
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getSupplier)", "frmULSupplier._getSupplier", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._XMLNewRow)", "frmULSupplier._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _add()
        Try
            If CheckAdd("frmULSupplier") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._add)", "frmULSupplier._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDSupplier.Text = "" Then Exit Sub
            If CheckDelete("frmULSupplier") Then
                If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                    clsULSupplier.Delete(txtIDSupplier.Text)
                    _setDataGrid()
                    _getCellCurrent()
                Else
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._delete)", "frmULSupplier._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmULSupplier") Then
                _setReadOnly(False)
                txtSName.Focus()
                txtIDSupplier.TReadOnly = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(18, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._update)", "frmULSupplier._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDSupplier.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(22, _strLang), , InforButton.Ok)
                txtIDSupplier.Focus()
                Exit Sub
            End If
            If txtSName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
                txtSName.Focus()
                Exit Sub
            End If
            If txtBusiness.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(24, _strLang), , InforButton.Ok)
                txtBusiness.Focus()
                Exit Sub
            End If
            If txtAddress.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.Ok)
                txtAddress.Focus()
                Exit Sub
            End If
            If CheckSave("frmULSupplier") Then
                If clsULSupplier.IsExist(txtIDSupplier.Text) Then
                    If CheckUpdate("frmULSupplier") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(18, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(21, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsULSupplier Is Nothing Then _clsULSupplier = New clsULSupplier
                            _setSupplier()
                            _clsULSupplier.Update()
                            _clsULSupplier.DisposedSupplier() : _clsULSupplier = Nothing
                        Else
                            txtIDSupplier.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(21, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsULSupplier Is Nothing Then _clsULSupplier = New clsULSupplier
                        _setSupplier()
                        _clsULSupplier.Add()
                        _clsULSupplier.DisposedSupplier() : _clsULSupplier = Nothing
                    Else
                        txtIDSupplier.Focus()
                        Exit Sub
                    End If
                End If
                _setReadOnly(True)
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                _setDataGrid()
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(19, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._save)", "frmULSupplier._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsULSupplier Is Nothing Then _clsULSupplier = New clsULSupplier
            If txtSearch.Text = "" Then
                grdSupplier.DataSource = _clsULSupplier.GetTable()
            Else
                If rdoIDSupplier.Checked Then
                    grdSupplier.DataSource = _clsULSupplier.Search("IDSupplier", txtSearch.Text)
                Else
                    If rdoSName.Checked Then
                        grdSupplier.DataSource = _clsULSupplier.Search("SName", txtSearch.Text)
                    Else
                        If rdoAddress.Checked Then
                            grdSupplier.DataSource = _clsULSupplier.Search("Address", txtSearch.Text)
                        End If
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsULSupplier.DisposedSupplier() : _clsULSupplier = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._search)", "frmULSupplier._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Supplier"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("ULSupplier")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDSupplier.Text)
                _XMLNewRow(oDataTable, "1", txtSName.Text)
                _XMLNewRow(oDataTable, "2", txtDescrible.Text)
                _XMLNewRow(oDataTable, "3", txtBusiness.Text)
                _XMLNewRow(oDataTable, "4", txtPhone.Text1 & "," & txtPhone.Text2 & "," & txtPhone.Text3)
                _XMLNewRow(oDataTable, "5", txtFax.Text1 & "," & txtFax.Text2 & "," & txtFax.Text3)
                _XMLNewRow(oDataTable, "6", txtEmail.Text1 & "," & txtEmail.Text2 & "," & txtEmail.Text3)
                _XMLNewRow(oDataTable, "7", txtWeb.Text1 & "," & txtWeb.Text2 & "," & txtWeb.Text3)
                _XMLNewRow(oDataTable, "8", txtAddress.Text)
                _XMLNewRow(oDataTable, "9", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._saveFileDialog)", "frmULSupplier._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Supplier"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Supplier.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Supplier.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Supplier.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Supplier.xml")
                txtIDSupplier.Text = dsData.Tables(0).Rows(0)("Data")
                txtSName.Text = dsData.Tables(0).Rows(1)("Data")
                txtDescrible.Text = dsData.Tables(0).Rows(2)("Data")
                txtBusiness.Text = dsData.Tables(0).Rows(3)("Data")
                _setTextPNA1(txtPhone, dsData.Tables(0).Rows(4)("Data"))
                _setTextPNA1(txtFax, dsData.Tables(0).Rows(5)("Data"))
                _setTextPNA1(txtEmail, dsData.Tables(0).Rows(6)("Data"))
                _setTextPNA1(txtWeb, dsData.Tables(0).Rows(7)("Data"))
                txtAddress.Text = dsData.Tables(0).Rows(8)("Data")
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Supplier.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._openFileDialog)", "frmULSupplier._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        Try
            If Not _rptULSupplier Is Nothing Then Exit Sub
            If _rptULSupplier Is Nothing Then _rptULSupplier = New rptULSupplier
            If _clsULSupplier Is Nothing Then _clsULSupplier = New clsULSupplier
            _rptULSupplier.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
            _rptULSupplier.Database.Tables(0).SetDataSource(_clsULSupplier.GetTable)
            _rptULSupplier.Refresh()
            _rptULSupplier.SetParameterValue("lblSupplier", clsConfig.GetLanguage(15, _strLang, True))
            _rptULSupplier.SetParameterValue("lblIDSupplier", clsConfig.GetLanguage(1, _strLang, True))
            _rptULSupplier.SetParameterValue("lblSName", clsConfig.GetLanguage(2, _strLang, ))
            _rptULSupplier.SetParameterValue("lblDescrible", clsConfig.GetLanguage(3, _strLang, True))
            _rptULSupplier.SetParameterValue("lblBusiness", clsConfig.GetLanguage(4, _strLang, True))
            _rptULSupplier.SetParameterValue("lblPhone", clsConfig.GetLanguage(5, _strLang, True))
            _rptULSupplier.SetParameterValue("lblFax", clsConfig.GetLanguage(6, _strLang, True))
            _rptULSupplier.SetParameterValue("lblEmail", clsConfig.GetLanguage(7, _strLang, True))
            _rptULSupplier.SetParameterValue("lblWeb", clsConfig.GetLanguage(8, _strLang, True))
            _rptULSupplier.SetParameterValue("lblAddress", clsConfig.GetLanguage(9, _strLang, True))
            frmReview.GlobalForm.lblCaption.Text = clsConfig.GetLanguage(15, _strLang)
            frmReview.GlobalForm.rptViewer.ReportSource = _rptULSupplier
            frmReview.GlobalForm.ShowDialog(Me)
            _rptULSupplier.Dispose() : _rptULSupplier = Nothing
            _clsULSupplier.DisposedSupplier() : _clsULSupplier = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._Review)", "frmULSupplier._Review", True)
        End Try
    End Sub
    Private Sub _refesh()
        Try
            _setReadOnly(True)
            btnAdd.Enabled = True
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            _setDataGrid()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._refesh)", "frmULSupplier._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDSupplier.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtSName.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtSName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtDescrible.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtIDSupplier.Focus()
            End If
        End If
    End Sub
    Private Sub txtBusiness_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusiness.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtPhone.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtDescrible.Focus()
            End If
        End If
    End Sub
    Private Sub txtPhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtFax.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtBusiness.Focus()
            End If
        End If
    End Sub
    Private Sub txtFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtEmail.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtPhone.Focus()
            End If
        End If
    End Sub
    Private Sub txtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtWeb.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtFax.Focus()
            End If
        End If
    End Sub
    Private Sub txtWeb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWeb.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtAddress.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtEmail.Focus()
            End If
        End If
    End Sub
    Private Sub txtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            btnAdd.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtWeb.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "ULSupplier"
    Private Sub frmULSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmULSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDSupplier_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDSupplier.Validating
        Try
            If txtIDSupplier.Text <> "" Then
                If clsULSupplier.IsExist(txtIDSupplier.Text) Then
                    If _clsULSupplier Is Nothing Then _clsULSupplier = New clsULSupplier
                    _clsULSupplier.GetInfor(txtIDSupplier.Text)
                    _getSupplier()
                    _clsULSupplier.DisposedSupplier() : _clsULSupplier = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULSupplier._getSupplier)", "frmULSupplier.txtIDSupplier_Validating", True)
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
    Private Sub grdSupplier_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSupplier.CellEnter
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