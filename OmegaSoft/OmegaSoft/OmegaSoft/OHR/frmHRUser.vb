Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRUser
#Region " Global Form"
    Private Shared _frmHRUser As frmHRUser
    Public Shared Property GlobalForm() As frmHRUser
        Get
            If _frmHRUser Is Nothing OrElse _frmHRUser.IsDisposed Then
                _frmHRUser = New frmHRUser
            End If
            Return _frmHRUser
        End Get
        Set(ByVal Value As frmHRUser)
            _frmHRUser = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRUser.xml"
    Dim _clsHRUser As clsHRUser
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDEmployee.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtCName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtUserName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtPassword.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDEmployee.Text = clsConfig.GetLanguage(1, _strLang)
            lblCName.Text = clsConfig.GetLanguage(2, _strLang)
            lblDName.Text = clsConfig.GetLanguage(3, _strLang)
            lblJobTitile.Text = clsConfig.GetLanguage(4, _strLang)
            lblUserName.Text = clsConfig.GetLanguage(5, _strLang)
            lblPassword.Text = clsConfig.GetLanguage(6, _strLang)
            lblConfirmPass.Text = clsConfig.GetLanguage(7, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(8, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(9, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(10, _strLang)
            btnSave.Text = clsConfig.GetLanguage(11, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(12, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoUserName.Text = clsConfig.GetLanguage(5, _strLang)
            rdoEmployeeName.Text = clsConfig.GetLanguage(13, _strLang)
            lblList.Text = clsConfig.GetLanguage(14, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._getLang)", , True)
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
            If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
            grdUser.AllowUserToAddRows = False
            grdUser.AllowUserToDeleteRows = False
            grdUser.ReadOnly = True
            grdUser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdUser.RowHeadersWidth = 24
            grdUser.DataSource = _clsHRUser.GetTable()
            _setHeaderDataGrid()
            _clsHRUser.DisposedUser() : _clsHRUser = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._setDataGrid)", "frmHRUser._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            grdUser.Columns(0).HeaderText = clsConfig.GetLanguage(1, _strLang)
            grdUser.Columns(0).ToolTipText = grdUser.Columns(0).HeaderText
            grdUser.Columns(1).HeaderText = clsConfig.GetLanguage(5, _strLang)
            grdUser.Columns(1).ToolTipText = grdUser.Columns(1).HeaderText
            grdUser.Columns(2).HeaderText = clsConfig.GetLanguage(6, _strLang)
            grdUser.Columns(2).ToolTipText = grdUser.Columns(1).HeaderText
            grdUser.Columns(3).HeaderText = "Administrator"
            grdUser.Columns(3).ToolTipText = "Administrator"
            grdUser.Columns(0).Width = 150
            grdUser.Columns(1).Width = 250
            grdUser.Columns(2).Width = 200
            grdUser.Columns(3).Width = 100
            lblList.Text = clsConfig.GetLanguage(14, _strLang) & " : " & grdUser.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._setHeaderDataGrid)", "frmHRUser._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            Dim _clsHREmployee As New clsHREmployee
            Dim _clsHRJobTitle As New clsHRJobTitle
            Dim _clsHRDepartment As New clsHRDepartment
            Dim _clsHRCompany As New clsHRCompany
            txtIDEmployee.Text = grdUser.Item(0, intRowIndex).Value.ToString
            _clsHREmployee.GetInfor(txtIDEmployee.Text)
            lblEmployeeName.Text = _clsHREmployee.LastName & " " & _clsHREmployee.FirstName
            Try
                picPicture.Image = _clsHREmployee.CPicture
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
            _clsHRJobTitle.GetInfor(_clsHREmployee.IDJobTitle)
            _clsHRDepartment.GetInfor(_clsHRJobTitle.IDDepartment)
            _clsHRCompany.GetInfor(_clsHRDepartment.IDCompany)
            txtJobTitile.Text = _clsHRJobTitle.JName
            txtDName.Text = _clsHRDepartment.DName
            txtCName.Text = _clsHRCompany.CName
            txtUserName.Text = grdUser.Item(1, intRowIndex).Value.ToString
            txtPassword.Text = clsMethods.Decrypt(grdUser.Item(2, intRowIndex).Value.ToString)
            txtConfirmPass.Text = txtPassword.Text
            chkAdmin.Checked = CBool(grdUser.Item(3, intRowIndex).Value)
            _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._getCellEnter)", "frmHRUser._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdUser.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._getCellCurrent)", "frmHRUser._getCellCurrent", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtUserName.TReadOnly = bolFlag
            txtPassword.TReadOnly = bolFlag
            txtConfirmPass.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDEmployee.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._setReadOnly)", "frmHRUser._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDEmployee.Text = ""
        lblEmployeeName.Text = ""
        txtCName.Text = ""
        txtDName.Text = ""
        txtJobTitile.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        txtConfirmPass.Text = ""
    End Sub
    Private Sub _setUser()
        Try
            _clsHRUser.IDEmployee = txtIDEmployee.Text.Trim
            _clsHRUser.UName = txtUserName.Text.Trim
            _clsHRUser.UPass = clsMethods.Encrypt(txtPassword.Text.Trim)
            _clsHRUser.Admin = chkAdmin.Checked
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._setUser)", "frmHRUser._setUser", True)
        End Try
    End Sub
    Private Sub _getUser()
        Try
            Dim _clsHREmployee As New clsHREmployee
            Dim _clsHRJobTitle As New clsHRJobTitle
            Dim _clsHRDepartment As New clsHRDepartment
            Dim _clsHRCompany As New clsHRCompany
            txtIDEmployee.Text = _clsHRUser.IDEmployee
            _clsHREmployee.GetInfor(txtIDEmployee.Text)
            lblEmployeeName.Text = _clsHREmployee.LastName & " " & _clsHREmployee.FirstName
            Try
                picPicture.Image = _clsHREmployee.CPicture
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
            _clsHRJobTitle.GetInfor(_clsHREmployee.IDJobTitle)
            _clsHRDepartment.GetInfor(_clsHRJobTitle.IDDepartment)
            _clsHRCompany.GetInfor(_clsHRDepartment.IDCompany)
            txtJobTitile.Text = _clsHRJobTitle.JName
            txtDName.Text = _clsHRDepartment.DName
            txtCName.Text = _clsHRCompany.CName
            txtUserName.Text = _clsHRUser.UName
            txtPassword.Text = clsMethods.Decrypt(_clsHRUser.UPass)
            txtConfirmPass.Text = txtPassword.Text
            chkAdmin.Checked = _clsHRUser.Admin
            _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._getUser)", "frmHRUser._getUser", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._XMLNewRow)", "frmHRUser._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _add()
        Try
            If CheckAdd("frmHRUser") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._add)", "frmHRUser._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtUserName.Text = "" Then Exit Sub
            If CheckDelete("frmHRUser") Then
                If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(19, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                    clsHRUser.Delete(txtUserName.Text)
                    _setDataGrid()
                    _getCellCurrent()
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._delete)", "frmHRUser._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmHRUser") Then
                _setReadOnly(False)
                txtUserName.TReadOnly = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._update)", "frmHRUser._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDEmployee.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(21, _strLang), , InforButton.Ok)
                txtIDEmployee.Focus()
                Exit Sub
            End If
            If txtUserName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(22, _strLang), , InforButton.Ok)
                txtUserName.Focus()
                Exit Sub
            End If
            If txtPassword.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
                txtPassword.Focus()
                Exit Sub
            End If
            If txtPassword.Text <> txtConfirmPass.Text Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(7, _strLang), , InforButton.Ok)
                txtConfirmPass.Focus()
                Exit Sub
            End If
            If CheckSave("frmHRUser") Then
                If clsHRUser.IsExist(txtUserName.Text) Then
                    If CheckUpdate("frmHRUser") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
                            _setUser()
                            _clsHRUser.Update()
                            _clsHRUser.DisposedUser() : _clsHRUser = Nothing
                        Else
                            txtIDEmployee.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
                        _setUser()
                        _clsHRUser.Add()
                        _clsHRUser.DisposedUser() : _clsHRUser = Nothing
                    Else
                        txtIDEmployee.Focus()
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._save)", "frmHRUser._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
            If txtSearch.Text = "" Or txtSearch.Text = "*" Then
                grdUser.DataSource = _clsHRUser.GetTable()
            Else
                If rdoUserName.Checked Then
                    grdUser.DataSource = _clsHRUser.Search("UName", txtSearch.Text)
                Else
                    If rdoEmployeeName.Checked Then
                        grdUser.DataSource = _clsHRUser.Search("EmployeeName", txtSearch.Text)
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHRUser.DisposedUser() : _clsHRUser = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._search)", "frmHRUser._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "User"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HRUser")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDEmployee.Text)
                _XMLNewRow(oDataTable, "1", txtUserName.Text)
                _XMLNewRow(oDataTable, "2", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._saveFileDialog)", "frmHRUser._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "User"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\User.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\User.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\User.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\User.xml")
                txtIDEmployee.Text = dsData.Tables(0).Rows(0)("Data")
                If txtIDEmployee.Text <> "" Then
                    Dim _clsHREmployee As New clsHREmployee
                    Dim _clsHRJobTitle As New clsHRJobTitle
                    Dim _clsHRDepartment As New clsHRDepartment
                    Dim _clsHRCompany As New clsHRCompany
                    _clsHREmployee.GetInfor(txtIDEmployee.Text)
                    lblEmployeeName.Text = _clsHREmployee.LastName & " " & _clsHREmployee.FirstName
                    Try
                        picPicture.Image = _clsHREmployee.CPicture
                    Catch ex As Exception
                        picPicture.Image = Nothing
                    End Try
                    _clsHRJobTitle.GetInfor(_clsHREmployee.IDJobTitle)
                    _clsHRDepartment.GetInfor(_clsHRJobTitle.IDDepartment)
                    _clsHRCompany.GetInfor(_clsHRDepartment.IDCompany)
                    txtJobTitile.Text = _clsHRJobTitle.JName
                    txtDName.Text = _clsHRDepartment.DName
                    txtCName.Text = _clsHRCompany.CName
                    _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
                    _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
                    _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
                    _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
                End If
                If txtUserName.TReadOnly = False Then
                    txtUserName.Text = dsData.Tables(0).Rows(1)("Data")
                End If
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\User.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._openFileDialog)", "frmHRUser._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        'Try
        '    If Not _rptHRCountry Is Nothing Then Exit Sub
        '    If _rptHRCountry Is Nothing Then _rptHRCountry = New rptHRCountry
        '    If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
        '    _rptHRCountry.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
        '    _rptHRCountry.Database.Tables(0).SetDataSource(_clsHRUser.GetTable)
        '    _rptHRCountry.Refresh()
        '    _rptHRCountry.SetParameterValue("lblCountry", clsConfig.GetLanguage(9, _strLang, True))
        '    _rptHRCountry.SetParameterValue("lblIDCountry", clsConfig.GetLanguage(1, _strLang, True))
        '    _rptHRCountry.SetParameterValue("lblCName", clsConfig.GetLanguage(2, _strLang, ))
        '    _rptHRCountry.SetParameterValue("lblDescrible", clsConfig.GetLanguage(3, _strLang, True))
        '    _rptHRCountry.SetParameterValue("lblPicture", clsConfig.GetLanguage(22, _strLang, True))
        '    frmReview.GlobalForm.lblCaption.Text = clsConfig.GetLanguage(9, _strLang)
        '    frmReview.GlobalForm.rptViewer.ReportSource = _rptHRCountry
        '    frmReview.GlobalForm.ShowDialog(Me)
        '    _rptHRCountry.Dispose() : _rptHRCountry = Nothing
        '    _clsHRUser.DisposedCountry() : _clsHRUser = Nothing
        'Catch ex As Exception
        '    ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._Review)", "frmHRUser._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._refesh)", "frmHRUser._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub _showHRLEmployee()
        Try
            Dim _frmHRLEmployee As New frmHRLEmployee
            _frmHRLEmployee.showForm(Me)
            If _frmHRLEmployee.IsDisposed = False And Not _frmHRLEmployee Is Nothing Then
                Dim _clsHRJobTitle As New clsHRJobTitle
                Dim _clsHRDepartment As New clsHRDepartment
                Dim _clsHRCompany As New clsHRCompany
                txtIDEmployee.Text = _frmHRLEmployee.grdEmployee.Item(2, _frmHRLEmployee.grdEmployee.CurrentCell.RowIndex).Value
                lblEmployeeName.Text = _frmHRLEmployee.grdEmployee.Item(4, _frmHRLEmployee.grdEmployee.CurrentCell.RowIndex).Value & " " & _frmHRLEmployee.grdEmployee.Item(3, _frmHRLEmployee.grdEmployee.CurrentCell.RowIndex).Value
                Try
                    picPicture.Image = clsMethods.ByteToImage(_frmHRLEmployee.grdEmployee.Item(13, _frmHRLEmployee.grdEmployee.CurrentCell.RowIndex).Value)
                Catch ex As Exception
                    picPicture.Image = Nothing
                End Try
                _clsHRJobTitle.GetInfor(_frmHRLEmployee.grdEmployee.Item(0, _frmHRLEmployee.grdEmployee.CurrentCell.RowIndex).Value)
                _clsHRDepartment.GetInfor(_clsHRJobTitle.IDDepartment)
                _clsHRCompany.GetInfor(_clsHRDepartment.IDCompany)
                txtJobTitile.Text = _clsHRJobTitle.JName
                txtDName.Text = _clsHRDepartment.DName
                txtCName.Text = _clsHRCompany.CName
                _frmHRLEmployee.Close()
                _frmHRLEmployee.Dispose() : _frmHRLEmployee = Nothing
                _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
                _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
                _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser._showHRLEmployee)", "frmHRUser._showHRLEmployee", True)
        End Try
    End Sub
    Private Sub txtIDEmployee_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDEmployee.DoubleClick
        _showHRLEmployee()
    End Sub
    Private Sub txtIDEmployee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDEmployee.KeyDown
        If e.KeyCode = Keys.F4 Then
            _showHRLEmployee()
            Exit Sub
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtCName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                chkAdmin.Focus()
            End If
        End If
    End Sub
    Private Sub txtCName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDEmployee.Focus()
            End If
        End If
    End Sub
    Private Sub txtDName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtJobTitile.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtCName.Focus()
            End If
        End If
    End Sub
    Private Sub txtJobTitile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJobTitile.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtUserName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtDName.Focus()
            End If
        End If
    End Sub
    Private Sub txtUserName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtJobTitile.Focus()
            End If
        End If
    End Sub
    Private Sub txtPassword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtConfirmPass.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtUserName.Focus()
            End If
        End If
    End Sub
    Private Sub txtConfirmPass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConfirmPass.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            chkAdmin.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtPassword.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HRUser"
    Private Sub frmHRUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHRUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtUserName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserName.Validating
        Try
            If txtUserName.Text <> "" Then
                If clsHRUser.IsExist(txtUserName.Text) Then
                    If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
                    _clsHRUser.GetInfor(txtUserName.Text)
                    _getUser()
                    _clsHRUser.DisposedUser() : _clsHRUser = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRUser.txtIDUser_Validating)", "frmHRUser.txtIDUser_Validating", True)
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
    Private Sub grdUser_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUser.CellEnter
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