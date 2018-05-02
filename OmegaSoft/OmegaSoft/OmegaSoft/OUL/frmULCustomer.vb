Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmULCustomer
#Region " Global Form"
    Private Shared _frmULCustomer As frmULCustomer
    Public Shared Property GlobalForm() As frmULCustomer
        Get
            If _frmULCustomer Is Nothing OrElse _frmULCustomer.IsDisposed Then
                _frmULCustomer = New frmULCustomer
            End If
            Return _frmULCustomer
        End Get
        Set(ByVal Value As frmULCustomer)
            _frmULCustomer = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OUL\XMLULCustomer.xml"
    Dim _clsULCustomer As clsULCustomer
    Dim _rptULCustomer As rptULCustomer
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDCustomer.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtCName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDescrible.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtPhone.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtFax.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtEmail.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtWeb.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtAddress.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDCustomer.Text = clsConfig.GetLanguage(1, _strLang)
            lblCName.Text = clsConfig.GetLanguage(2, _strLang)
            lblDescrible.Text = clsConfig.GetLanguage(3, _strLang)
            lblPhone.Text = clsConfig.GetLanguage(4, _strLang)
            txtPhone.TextMenu1 = lblPhone.Text & "-1"
            txtPhone.TextMenu2 = lblPhone.Text & "-2"
            txtPhone.TextMenu3 = lblPhone.Text & "-3"
            txtPhone.Image1 = ImageList1.Images(0)
            txtPhone.Image2 = ImageList1.Images(0)
            txtPhone.Image3 = ImageList1.Images(0)
            lblFax.Text = clsConfig.GetLanguage(5, _strLang)
            txtFax.TextMenu1 = lblFax.Text & "-1"
            txtFax.TextMenu2 = lblFax.Text & "-2"
            txtFax.TextMenu3 = lblFax.Text & "-3"
            txtFax.Image1 = ImageList1.Images(1)
            txtFax.Image2 = ImageList1.Images(1)
            txtFax.Image3 = ImageList1.Images(1)
            lblEmail.Text = clsConfig.GetLanguage(6, _strLang)
            txtEmail.TextMenu1 = lblEmail.Text & "-1"
            txtEmail.TextMenu2 = lblEmail.Text & "-2"
            txtEmail.TextMenu3 = lblEmail.Text & "-3"
            txtEmail.Image1 = ImageList1.Images(2)
            txtEmail.Image2 = ImageList1.Images(2)
            txtEmail.Image3 = ImageList1.Images(2)
            lblWeb.Text = clsConfig.GetLanguage(7, _strLang)
            txtWeb.TextMenu1 = lblWeb.Text & "-1"
            txtWeb.TextMenu2 = lblWeb.Text & "-2"
            txtWeb.TextMenu3 = lblWeb.Text & "-3"
            txtWeb.Image1 = ImageList1.Images(3)
            txtWeb.Image2 = ImageList1.Images(3)
            txtWeb.Image3 = ImageList1.Images(3)
            lblAddress.Text = clsConfig.GetLanguage(8, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(9, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(10, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(11, _strLang)
            btnSave.Text = clsConfig.GetLanguage(12, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(13, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDCustomer.Text = clsConfig.GetLanguage(1, _strLang)
            rdoCName.Text = clsConfig.GetLanguage(2, _strLang)
            rdoAddress.Text = clsConfig.GetLanguage(8, _strLang)
            lblList.Text = clsConfig.GetLanguage(14, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(24, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(25, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(26, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(27, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._getLang)", , True)
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
            If _clsULCustomer Is Nothing Then _clsULCustomer = New clsULCustomer
            grdCustomer.AllowUserToAddRows = False
            grdCustomer.AllowUserToDeleteRows = False
            grdCustomer.AllowUserToResizeRows = False
            grdCustomer.ReadOnly = True
            grdCustomer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdCustomer.RowHeadersWidth = 24
            grdCustomer.DataSource = _clsULCustomer.GetTable()
            _setHeaderDataGrid()
            _clsULCustomer.DisposedCustomer() : _clsULCustomer = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._setDataGrid)", "frmULCustomer._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            Dim i As Integer
            For i = 0 To grdCustomer.Columns.Count - 1
                grdCustomer.Columns(i).HeaderText = clsConfig.GetLanguage(i + 1, _strLang)
                grdCustomer.Columns(i).ToolTipText = grdCustomer.Columns(i).HeaderText
            Next
            grdCustomer.Columns(0).Width = 115
            grdCustomer.Columns(1).Width = 250
            grdCustomer.Columns(2).Width = 200
            grdCustomer.Columns(3).Width = 200
            grdCustomer.Columns(4).Width = 200
            grdCustomer.Columns(5).Width = 200
            grdCustomer.Columns(6).Width = 200
            grdCustomer.Columns(7).Width = 300
            lblList.Text = clsConfig.GetLanguage(14, _strLang) & " : " & grdCustomer.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._setHeaderDataGrid)", "frmULCustomer._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            txtIDCustomer.Text = grdCustomer.Item(0, intRowIndex).Value.ToString
            txtCName.Text = grdCustomer.Item(1, intRowIndex).Value.ToString
            txtDescrible.Text = grdCustomer.Item(2, intRowIndex).Value.ToString
            _setTextPNA1(txtPhone, grdCustomer.Item(3, intRowIndex).Value.ToString)
            _setTextPNA1(txtFax, grdCustomer.Item(4, intRowIndex).Value.ToString)
            _setTextPNA1(txtEmail, grdCustomer.Item(5, intRowIndex).Value.ToString)
            _setTextPNA1(txtWeb, grdCustomer.Item(6, intRowIndex).Value.ToString)
            txtAddress.Text = grdCustomer.Item(7, intRowIndex).Value.ToString
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._getCellEnter)", "frmULCustomer._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdCustomer.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._getCellCurrent)", "frmULCustomer._getCellCurrent", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._setTextPNA1)", "frmULCustomer._setTextPNA1", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDCustomer.TReadOnly = bolFlag
            txtCName.TReadOnly = bolFlag
            txtDescrible.TReadOnly = bolFlag
            txtPhone.TReadOnly = bolFlag
            txtFax.TReadOnly = bolFlag
            txtEmail.TReadOnly = bolFlag
            txtWeb.TReadOnly = bolFlag
            txtAddress.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDCustomer.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._setReadOnly)", "frmULCustomer._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDCustomer.Text = ""
        txtCName.Text = ""
        txtDescrible.Text = ""
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
    Private Sub _setCustomer()
        Try
            _clsULCustomer.IDCustomer = txtIDCustomer.Text.Trim
            _clsULCustomer.CName = txtCName.Text.Trim
            _clsULCustomer.Describle = txtDescrible.Text.Trim
            _clsULCustomer.Phone = txtPhone.Text1.Trim & "," & txtPhone.Text2.Trim & "," & txtPhone.Text3.Trim
            _clsULCustomer.Fax = txtFax.Text1.Trim & "," & txtFax.Text2.Trim & "," & txtFax.Text3.Trim
            _clsULCustomer.Email = txtEmail.Text1.Trim & "," & txtEmail.Text2.Trim & "," & txtEmail.Text3.Trim
            _clsULCustomer.WebSite = txtWeb.Text1.Trim & "," & txtWeb.Text2.Trim & "," & txtWeb.Text3.Trim
            _clsULCustomer.Address = txtAddress.Text.Trim
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._setCustomer)", "frmULCustomer._setCustomer", True)
        End Try
    End Sub
    Private Sub _getCustomer()
        Try
            txtIDCustomer.Text = _clsULCustomer.IDCustomer
            txtCName.Text = _clsULCustomer.CName
            txtDescrible.Text = _clsULCustomer.Describle
            _setTextPNA1(txtPhone, _clsULCustomer.Phone)
            _setTextPNA1(txtFax, _clsULCustomer.Fax)
            _setTextPNA1(txtEmail, _clsULCustomer.Email)
            _setTextPNA1(txtWeb, _clsULCustomer.WebSite)
            txtAddress.Text = _clsULCustomer.Address
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._getCustomer)", "frmULCustomer._getCustomer", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._XMLNewRow)", "frmULCustomer._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _add()
        Try
            If CheckAdd("frmULCustomer") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._add)", "frmULCustomer._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDCustomer.Text = "" Then Exit Sub
            If CheckDelete("frmULCustomer") Then
                If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(19, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                    clsULCustomer.Delete(txtIDCustomer.Text)
                    _setDataGrid()
                    _getCellCurrent()
                Else
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._delete)", "frmULCustomer._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmULCustomer") Then
                _setReadOnly(False)
                txtCName.Focus()
                txtIDCustomer.TReadOnly = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._update)", "frmULSupplier._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDCustomer.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(21, _strLang), , InforButton.Ok)
                txtIDCustomer.Focus()
                Exit Sub
            End If
            If txtCName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(22, _strLang), , InforButton.Ok)
                txtCName.Focus()
                Exit Sub
            End If
            If txtAddress.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
                txtAddress.Focus()
                Exit Sub
            End If
            If CheckSave("frmULCustomer") Then
                If clsULCustomer.IsExist(txtIDCustomer.Text) Then
                    If CheckUpdate("frmULCustomer") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsULCustomer Is Nothing Then _clsULCustomer = New clsULCustomer
                            _setCustomer()
                            _clsULCustomer.Update()
                            _clsULCustomer.DisposedCustomer() : _clsULCustomer = Nothing
                        Else
                            txtIDCustomer.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsULCustomer Is Nothing Then _clsULCustomer = New clsULCustomer
                        _setCustomer()
                        _clsULCustomer.Add()
                        _clsULCustomer.DisposedCustomer() : _clsULCustomer = Nothing
                    Else
                        txtIDCustomer.Focus()
                        Exit Sub
                    End If
                End If
                _setReadOnly(True)
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                _setDataGrid()
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(18, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._save)", "frmULCustomer._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsULCustomer Is Nothing Then _clsULCustomer = New clsULCustomer
            If txtSearch.Text = "" Then
                grdCustomer.DataSource = _clsULCustomer.GetTable()
            Else
                If rdoIDCustomer.Checked Then
                    grdCustomer.DataSource = _clsULCustomer.Search("IDCustomer", txtSearch.Text)
                Else
                    If rdoCName.Checked Then
                        grdCustomer.DataSource = _clsULCustomer.Search("CName", txtSearch.Text)
                    Else
                        If rdoAddress.Checked Then
                            grdCustomer.DataSource = _clsULCustomer.Search("Address", txtSearch.Text)
                        End If
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsULCustomer.DisposedCustomer() : _clsULCustomer = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._search)", "frmULCustomer._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Customer"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("ULCustomer")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDCustomer.Text)
                _XMLNewRow(oDataTable, "1", txtCName.Text)
                _XMLNewRow(oDataTable, "2", txtDescrible.Text)
                _XMLNewRow(oDataTable, "3", txtPhone.Text1 & "," & txtPhone.Text2 & "," & txtPhone.Text3)
                _XMLNewRow(oDataTable, "4", txtFax.Text1 & "," & txtFax.Text2 & "," & txtFax.Text3)
                _XMLNewRow(oDataTable, "5", txtEmail.Text1 & "," & txtEmail.Text2 & "," & txtEmail.Text3)
                _XMLNewRow(oDataTable, "6", txtWeb.Text1 & "," & txtWeb.Text2 & "," & txtWeb.Text3)
                _XMLNewRow(oDataTable, "7", txtAddress.Text)
                _XMLNewRow(oDataTable, "8", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._saveFileDialog)", "frmULCustomer._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Customer"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Customer.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Customer.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Customer.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Customer.xml")
                txtIDCustomer.Text = dsData.Tables(0).Rows(0)("Data")
                txtCName.Text = dsData.Tables(0).Rows(1)("Data")
                txtDescrible.Text = dsData.Tables(0).Rows(2)("Data")
                _setTextPNA1(txtPhone, dsData.Tables(0).Rows(3)("Data"))
                _setTextPNA1(txtFax, dsData.Tables(0).Rows(4)("Data"))
                _setTextPNA1(txtEmail, dsData.Tables(0).Rows(5)("Data"))
                _setTextPNA1(txtWeb, dsData.Tables(0).Rows(6)("Data"))
                txtAddress.Text = dsData.Tables(0).Rows(7)("Data")
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Customer.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._openFileDialog)", "frmULCustomer._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        Try
            If Not _rptULCustomer Is Nothing Then Exit Sub
            If _rptULCustomer Is Nothing Then _rptULCustomer = New rptULCustomer
            If _clsULCustomer Is Nothing Then _clsULCustomer = New clsULCustomer
            _rptULCustomer.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
            _rptULCustomer.Database.Tables(0).SetDataSource(_clsULCustomer.GetTable)
            _rptULCustomer.Refresh()
            _rptULCustomer.SetParameterValue("lblCustomer", clsConfig.GetLanguage(14, _strLang, True))
            _rptULCustomer.SetParameterValue("lblIDCustomer", clsConfig.GetLanguage(1, _strLang, True))
            _rptULCustomer.SetParameterValue("lblCName", clsConfig.GetLanguage(2, _strLang, ))
            _rptULCustomer.SetParameterValue("lblDescrible", clsConfig.GetLanguage(3, _strLang, True))
            _rptULCustomer.SetParameterValue("lblPhone", clsConfig.GetLanguage(4, _strLang, True))
            _rptULCustomer.SetParameterValue("lblFax", clsConfig.GetLanguage(5, _strLang, True))
            _rptULCustomer.SetParameterValue("lblEmail", clsConfig.GetLanguage(6, _strLang, True))
            _rptULCustomer.SetParameterValue("lblWeb", clsConfig.GetLanguage(7, _strLang, True))
            _rptULCustomer.SetParameterValue("lblAddress", clsConfig.GetLanguage(8, _strLang, True))
            frmReview.GlobalForm.lblCaption.Text = clsConfig.GetLanguage(14, _strLang)
            frmReview.GlobalForm.rptViewer.ReportSource = _rptULCustomer
            frmReview.GlobalForm.ShowDialog(Me)
            _rptULCustomer.Dispose() : _rptULCustomer = Nothing
            _clsULCustomer.DisposedCustomer() : _clsULCustomer = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._Review)", "frmULCustomer._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer._refesh)", "frmULCustomer._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDCustomer.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtCName.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtCName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtDescrible.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtIDCustomer.Focus()
            End If
        End If
    End Sub
    Private Sub txtPhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Right Then
            txtFax.Focus()
        Else
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Left Then
                txtDescrible.Focus()
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
#Region "ULCustomer"
    Private Sub frmULCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmULCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDCustomer_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDCustomer.Validating
        Try
            If txtIDCustomer.Text <> "" Then
                If clsULCustomer.IsExist(txtIDCustomer.Text) Then
                    If _clsULCustomer Is Nothing Then _clsULCustomer = New clsULCustomer
                    _clsULCustomer.GetInfor(txtIDCustomer.Text)
                    _getCustomer()
                    _clsULCustomer.DisposedCustomer() : _clsULCustomer = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmULCustomer.txtIDCustomer_Validating)", "frmULCustomer.txtIDCustomer_Validating", True)
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
    Private Sub grdCustomer_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCustomer.CellEnter
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