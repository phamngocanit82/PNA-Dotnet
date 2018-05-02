Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHREmployee
#Region " Global Form"
    Private Shared _frmHREmployee As frmHREmployee
    Public Shared Property GlobalForm() As frmHREmployee
        Get
            If _frmHREmployee Is Nothing OrElse _frmHREmployee.IsDisposed Then
                _frmHREmployee = New frmHREmployee
            End If
            Return _frmHREmployee
        End Get
        Set(ByVal Value As frmHREmployee)
            _frmHREmployee = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHREmployee.xml"
    Dim _clsHREmployee As clsHREmployee
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDJobTitle.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtIDLevel.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtIDEmployee.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtEName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtLName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtHomePhone.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtMobilePhone.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtEmail.Font = New System.Drawing.Font(strFont, 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtTemResident.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtResident.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDJobTitle.Text = clsConfig.GetLanguage(1, _strLang)
            lblIDLevel.Text = clsConfig.GetLanguage(2, _strLang)
            lblIDEmployee.Text = clsConfig.GetLanguage(3, _strLang)
            lblEName.Text = clsConfig.GetLanguage(4, _strLang)
            lblLName.Text = clsConfig.GetLanguage(5, _strLang)
            rdoMale.Text = clsConfig.GetLanguage(6, _strLang)
            rdoFemale.Text = clsConfig.GetLanguage(7, _strLang)
            lblBirthDay.Text = clsConfig.GetLanguage(8, _strLang)
            lblHireDay.Text = clsConfig.GetLanguage(9, _strLang)
            lblHomePhone.Text = clsConfig.GetLanguage(10, _strLang)
            txtHomePhone.TextMenu1 = lblHomePhone.Text & "-1"
            txtHomePhone.TextMenu2 = lblHomePhone.Text & "-2"
            txtHomePhone.TextMenu3 = lblHomePhone.Text & "-3"
            txtHomePhone.Image1 = ImageList1.Images(0)
            txtHomePhone.Image2 = ImageList1.Images(0)
            txtHomePhone.Image3 = ImageList1.Images(0)
            lblMobilePhone.Text = clsConfig.GetLanguage(11, _strLang)
            txtMobilePhone.TextMenu1 = lblMobilePhone.Text & "-1"
            txtMobilePhone.TextMenu2 = lblMobilePhone.Text & "-2"
            txtMobilePhone.TextMenu3 = lblMobilePhone.Text & "-3"
            txtMobilePhone.Image1 = ImageList1.Images(0)
            txtMobilePhone.Image2 = ImageList1.Images(0)
            txtMobilePhone.Image3 = ImageList1.Images(0)
            lblEmail.Text = clsConfig.GetLanguage(12, _strLang)
            txtEmail.TextMenu1 = lblEmail.Text & "-1"
            txtEmail.TextMenu2 = lblEmail.Text & "-2"
            txtEmail.TextMenu3 = lblEmail.Text & "-3"
            txtEmail.Image1 = ImageList1.Images(1)
            txtEmail.Image2 = ImageList1.Images(1)
            txtEmail.Image3 = ImageList1.Images(1)
            lblTemResident.Text = clsConfig.GetLanguage(13, _strLang)
            lblResident.Text = clsConfig.GetLanguage(14, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(15, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(16, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(17, _strLang)
            btnSave.Text = clsConfig.GetLanguage(18, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(19, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDEmployee.Text = clsConfig.GetLanguage(3, _strLang)
            rdoEName.Text = clsConfig.GetLanguage(4, _strLang)
            rdoJobTitleName.Text = clsConfig.GetLanguage(20, _strLang)
            rdoLevelName.Text = clsConfig.GetLanguage(21, _strLang)
            chkMale.Text = clsConfig.GetLanguage(6, _strLang)
            chkFemale.Text = clsConfig.GetLanguage(7, _strLang)
            lblList.Text = clsConfig.GetLanguage(22, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(36, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(37, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(38, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(39, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._getLang)", , True)
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
            If _clsHREmployee Is Nothing Then _clsHREmployee = New clsHREmployee
            grdEmployee.AllowUserToAddRows = False
            grdEmployee.AllowUserToDeleteRows = False
            grdEmployee.ReadOnly = True
            grdEmployee.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdEmployee.RowHeadersWidth = 24
            grdEmployee.DataSource = _clsHREmployee.GetTable()
            _setHeaderDataGrid()
            _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._setDataGrid)", "frmHREmployee._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            grdEmployee.Columns(0).HeaderText = clsConfig.GetLanguage(1, _strLang)
            grdEmployee.Columns(0).ToolTipText = grdEmployee.Columns(0).HeaderText
            grdEmployee.Columns(1).HeaderText = clsConfig.GetLanguage(2, _strLang)
            grdEmployee.Columns(1).ToolTipText = grdEmployee.Columns(1).HeaderText
            grdEmployee.Columns(2).HeaderText = clsConfig.GetLanguage(3, _strLang)
            grdEmployee.Columns(2).ToolTipText = grdEmployee.Columns(2).HeaderText
            grdEmployee.Columns(3).HeaderText = clsConfig.GetLanguage(4, _strLang)
            grdEmployee.Columns(3).ToolTipText = grdEmployee.Columns(3).HeaderText
            grdEmployee.Columns(4).HeaderText = clsConfig.GetLanguage(5, _strLang)
            grdEmployee.Columns(4).ToolTipText = grdEmployee.Columns(4).HeaderText
            grdEmployee.Columns(5).HeaderText = clsConfig.GetLanguage(6, _strLang)
            grdEmployee.Columns(5).ToolTipText = grdEmployee.Columns(5).HeaderText
            grdEmployee.Columns(6).HeaderText = clsConfig.GetLanguage(8, _strLang)
            grdEmployee.Columns(6).ToolTipText = grdEmployee.Columns(6).HeaderText
            grdEmployee.Columns(7).HeaderText = clsConfig.GetLanguage(9, _strLang)
            grdEmployee.Columns(7).ToolTipText = grdEmployee.Columns(7).HeaderText
            grdEmployee.Columns(8).HeaderText = clsConfig.GetLanguage(10, _strLang)
            grdEmployee.Columns(8).ToolTipText = grdEmployee.Columns(8).HeaderText
            grdEmployee.Columns(9).HeaderText = clsConfig.GetLanguage(11, _strLang)
            grdEmployee.Columns(9).ToolTipText = grdEmployee.Columns(9).HeaderText
            grdEmployee.Columns(10).HeaderText = clsConfig.GetLanguage(12, _strLang)
            grdEmployee.Columns(10).ToolTipText = grdEmployee.Columns(10).HeaderText
            grdEmployee.Columns(11).HeaderText = clsConfig.GetLanguage(13, _strLang)
            grdEmployee.Columns(11).ToolTipText = grdEmployee.Columns(11).HeaderText
            grdEmployee.Columns(12).HeaderText = clsConfig.GetLanguage(14, _strLang)
            grdEmployee.Columns(12).ToolTipText = grdEmployee.Columns(12).HeaderText
            grdEmployee.Columns(13).HeaderText = clsConfig.GetLanguage(40, _strLang)
            grdEmployee.Columns(13).ToolTipText = grdEmployee.Columns(13).HeaderText
            grdEmployee.Columns(0).Width = 100
            grdEmployee.Columns(1).Width = 100
            grdEmployee.Columns(2).Width = 100
            grdEmployee.Columns(3).Width = 100
            grdEmployee.Columns(4).Width = 180
            grdEmployee.Columns(5).Width = 40
            grdEmployee.Columns(6).Width = 100
            grdEmployee.Columns(7).Width = 100
            grdEmployee.Columns(8).Width = 200
            grdEmployee.Columns(9).Width = 200
            grdEmployee.Columns(10).Width = 200
            grdEmployee.Columns(11).Width = 200
            grdEmployee.Columns(12).Width = 200
            grdEmployee.Columns(12).Width = 200
            Select Case clsConfig.GetLangPNA
                Case "VietNamese"
                    grdEmployee.Columns(6).DefaultCellStyle.Format = "dd/MM/yyyy"
                    grdEmployee.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy"
                Case "English"
                    grdEmployee.Columns(6).DefaultCellStyle.Format = "MM/dd/yyyy"
                    grdEmployee.Columns(7).DefaultCellStyle.Format = "MM/dd/yyyy"
            End Select
            lblList.Text = clsConfig.GetLanguage(22, _strLang) & " : " & grdEmployee.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._setHeaderDataGrid)", "frmHREmployee._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            Dim _clsHRJobTitle As New clsHRJobTitle
            Dim _clsHRLevel As New clsHRLevel
            _clsHRJobTitle.GetInfor(grdEmployee.Item(0, intRowIndex).Value.ToString)
            _clsHRLevel.GetInfor(grdEmployee.Item(1, intRowIndex).Value.ToString)
            txtIDJobTitle.Text = _clsHRJobTitle.IDJobTitle
            lblJobTitleName.Text = _clsHRJobTitle.JName
            txtIDLevel.Text = _clsHRLevel.IDLevel
            lblLevelName.Text = _clsHRLevel.LName
            txtIDEmployee.Text = grdEmployee.Item(2, intRowIndex).Value.ToString
            txtEName.Text = grdEmployee.Item(3, intRowIndex).Value.ToString
            txtLName.Text = grdEmployee.Item(4, intRowIndex).Value.ToString
            If CBool(grdEmployee.Item(5, intRowIndex).Value) = False Then
                rdoFemale.Checked = True
            Else
                rdoMale.Checked = True
            End If
            If grdEmployee.Columns(6).DefaultCellStyle.Format = "" Then
                Select Case clsConfig.GetLangPNA
                    Case "VietNamese"
                        grdEmployee.Columns(6).DefaultCellStyle.Format = "dd/MM/yyyy"
                        grdEmployee.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy"
                    Case "English"
                        grdEmployee.Columns(6).DefaultCellStyle.Format = "MM/dd/yyyy"
                        grdEmployee.Columns(7).DefaultCellStyle.Format = "MM/dd/yyyy"
                End Select
            End If
            txtBirthDay.Text = grdEmployee.Item(6, intRowIndex).FormattedValue
            txtHireDay.Text = grdEmployee.Item(7, intRowIndex).FormattedValue
            _setTextPNA1(txtHomePhone, grdEmployee.Item(8, intRowIndex).Value.ToString)
            _setTextPNA1(txtMobilePhone, grdEmployee.Item(9, intRowIndex).Value.ToString)
            _setTextPNA1(txtEmail, grdEmployee.Item(10, intRowIndex).Value.ToString)
            txtTemResident.Text = grdEmployee.Item(11, intRowIndex).Value.ToString
            txtResident.Text = grdEmployee.Item(12, intRowIndex).Value.ToString
            Try
                picPicture.Image = ByteToImage(grdEmployee.Item(13, intRowIndex).Value)
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
            _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._getCellEnter)", "frmHREmployee._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdEmployee.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._getCellCurrent)", "frmHREmployee._getCellCurrent", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._setTextPNA1)", "frmHREmployee._setTextPNA1", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDEmployee.TReadOnly = bolFlag
            txtEName.TReadOnly = bolFlag
            txtLName.TReadOnly = bolFlag
            txtBirthDay.TReadOnly = bolFlag
            txtHireDay.TReadOnly = bolFlag
            txtHomePhone.TReadOnly = bolFlag
            txtMobilePhone.TReadOnly = bolFlag
            txtEmail.TReadOnly = bolFlag
            txtTemResident.TReadOnly = bolFlag
            txtResident.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDJobTitle.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._setReadOnly)", "frmHREmployee._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDJobTitle.Text = ""
        lblJobTitleName.Text = ""
        txtIDLevel.Text = ""
        lblLevelName.Text = ""
        txtIDEmployee.Text = ""
        txtEName.Text = ""
        txtLName.Text = ""
        txtBirthDay.LoadDate()
        txtHireDay.LoadDate()
        txtHomePhone.Text = "" : txtHomePhone.Text1 = "" : txtHomePhone.Text2 = "" : txtHomePhone.Text3 = ""
        txtMobilePhone.Text = "" : txtMobilePhone.Text1 = "" : txtMobilePhone.Text2 = "" : txtMobilePhone.Text3 = ""
        txtEmail.Text = "" : txtEmail.Text1 = "" : txtEmail.Text2 = "" : txtEmail.Text3 = ""
        txtTemResident.Text = ""
        txtResident.Text = ""
        picPicture.Image = Nothing
    End Sub
    Private Sub _setEmployee()
        Try
            _clsHREmployee.IDJobTitle = txtIDJobTitle.Text.Trim
            _clsHREmployee.IDLevel = txtIDLevel.Text.Trim
            _clsHREmployee.IDEmployee = txtIDEmployee.Text.Trim
            _clsHREmployee.FirstName = txtEName.Text.Trim
            _clsHREmployee.LastName = txtLName.Text.Trim
            _clsHREmployee.Gender = rdoMale.Checked
            _clsHREmployee.BirthDate = txtBirthDay.GetDate
            _clsHREmployee.HireDate = txtHireDay.GetDate
            _clsHREmployee.HomePhone = txtHomePhone.Text1.Trim & "," & txtHomePhone.Text2.Trim & "," & txtHomePhone.Text3.Trim
            _clsHREmployee.MobilePhone = txtMobilePhone.Text1.Trim & "," & txtMobilePhone.Text2.Trim & "," & txtMobilePhone.Text3.Trim
            _clsHREmployee.Email = txtEmail.Text1.Trim & "," & txtEmail.Text2.Trim & "," & txtEmail.Text3.Trim
            _clsHREmployee.TempResident = txtTemResident.Text.Trim
            _clsHREmployee.Resident = txtResident.Text.Trim
            Try
                _clsHREmployee.CPicture = picPicture.Image
            Catch ex As Exception
                _clsHREmployee.CPicture = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._setEmployee)", "frmHREmployee._setEmployee", True)
        End Try
    End Sub
    Private Sub _getEmployee()
        Try
            Dim _clsHRJobTitle As New clsHRJobTitle
            Dim _clsHRLevel As New clsHRLevel
            _clsHRJobTitle.GetInfor(_clsHREmployee.IDJobTitle)
            _clsHRLevel.GetInfor(_clsHREmployee.IDLevel)
            txtIDJobTitle.Text = _clsHRJobTitle.IDJobTitle
            lblJobTitleName.Text = _clsHRJobTitle.JName
            txtIDLevel.Text = _clsHRLevel.IDLevel
            lblLevelName.Text = _clsHRLevel.LName
            txtIDEmployee.Text = _clsHREmployee.IDEmployee
            txtEName.Text = _clsHREmployee.FirstName
            txtLName.Text = _clsHREmployee.LastName
            If _clsHREmployee.Gender Then
                rdoMale.Checked = True
            Else
                rdoFemale.Checked = True
            End If
            txtBirthDay.Text = _clsHREmployee.BirthDate
            txtHireDay.Text = _clsHREmployee.HireDate
            _setTextPNA1(txtHomePhone, _clsHREmployee.HomePhone)
            _setTextPNA1(txtMobilePhone, _clsHREmployee.MobilePhone)
            _setTextPNA1(txtEmail, _clsHREmployee.Email)
            txtTemResident.Text = _clsHREmployee.TempResident
            txtResident.Text = _clsHREmployee.Resident
            Try
                Dim oBitmap As New Bitmap(_clsHREmployee.CPicture)
                picPicture.Image = oBitmap
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
            _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._getEmployee)", "frmHREmployee._getEmployee", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._XMLNewRow)", "frmHREmployee._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _showHRLJobTitle()
        Try
            Dim _frmHRLJobTitle As New frmHRLJobTitle
            _frmHRLJobTitle.showForm(Me)
            If _frmHRLJobTitle.IsDisposed = False And Not _frmHRLJobTitle Is Nothing Then
                txtIDJobTitle.Text = _frmHRLJobTitle.grdJobTitle.Item(1, _frmHRLJobTitle.grdJobTitle.CurrentCell.RowIndex).Value
                lblJobTitleName.Text = _frmHRLJobTitle.grdJobTitle.Item(2, _frmHRLJobTitle.grdJobTitle.CurrentCell.RowIndex).Value
                _frmHRLJobTitle.Close()
                _frmHRLJobTitle.Dispose() : _frmHRLJobTitle = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._showHRLJobTitle)", "frmHREmployee._showHRLJobTitle", True)
        End Try
    End Sub
    Private Sub _showHRLLevel()
        Try
            Dim _frmHRLLevel As New frmHRLLevel
            _frmHRLLevel.showForm(Me)
            If _frmHRLLevel.IsDisposed = False And Not _frmHRLLevel Is Nothing Then
                txtIDLevel.Text = _frmHRLLevel.grdLevel.Item(0, _frmHRLLevel.grdLevel.CurrentCell.RowIndex).Value
                lblLevelName.Text = _frmHRLLevel.grdLevel.Item(1, _frmHRLLevel.grdLevel.CurrentCell.RowIndex).Value
                _frmHRLLevel.Close()
                _frmHRLLevel.Dispose() : _frmHRLLevel = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._showHRLLevel)", "frmHREmployee._showHRLLevel", True)
        End Try
    End Sub
    Private Sub _add()
        Try
            If CheckAdd("frmEmployee") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._add)", "frmHREmployee._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDEmployee.Text = "" Then Exit Sub
            If CheckDelete("frmEmployee") Then
                If clsHREmployee.IsExistEmployee(txtIDEmployee.Text) = False Then
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(27, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        clsHREmployee.Delete(txtIDEmployee.Text)
                        _setDataGrid()
                        _getCellCurrent()
                    End If
                Else
                    ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(41, _strLang), , InforButton.Ok)
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(24, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._delete)", "frmHREmployee._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmEmployee") Then
                _setReadOnly(False)
                txtIDJobTitle.Focus()
                txtIDEmployee.TReadOnly = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._update)", "frmHREmployee._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDJobTitle.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(29, _strLang), , InforButton.Ok)
                txtIDJobTitle.Focus()
                Exit Sub
            End If
            If txtIDLevel.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(30, _strLang), , InforButton.Ok)
                txtIDLevel.Focus()
                Exit Sub
            End If
            If txtIDEmployee.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(31, _strLang), , InforButton.Ok)
                txtIDEmployee.Focus()
                Exit Sub
            End If
            If txtEName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(32, _strLang), , InforButton.Ok)
                txtEName.Focus()
                Exit Sub
            End If
            If txtLName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(33, _strLang), , InforButton.Ok)
                txtLName.Focus()
                Exit Sub
            End If
            If txtTemResident.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(34, _strLang), , InforButton.Ok)
                txtTemResident.Focus()
                Exit Sub
            End If
            If txtResident.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(35, _strLang), , InforButton.Ok)
                txtResident.Focus()
                Exit Sub
            End If
            If clsHREmployee.IsExistEmployee(txtIDEmployee.Text) = True Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(41, _strLang), , InforButton.Ok)
                Exit Sub
            End If
            If CheckSave("frmEmployee") Then
                If clsHREmployee.IsExist(txtIDEmployee.Text) Then
                    If CheckUpdate("frmEmployee") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(28, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHREmployee Is Nothing Then _clsHREmployee = New clsHREmployee
                            _setEmployee()
                            _clsHREmployee.Update()
                            _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
                        Else
                            txtIDJobTitle.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(28, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHREmployee Is Nothing Then _clsHREmployee = New clsHREmployee
                        _setEmployee()
                        _clsHREmployee.Add()
                        _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
                    Else
                        txtIDJobTitle.Focus()
                        Exit Sub
                    End If
                End If
                _setReadOnly(True)
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                _setDataGrid()
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(26, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._save)", "frmHREmployee._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHREmployee Is Nothing Then _clsHREmployee = New clsHREmployee
            If (txtSearch.Text = "" Or txtSearch.Text = "*") And ((chkMale.Checked = True And chkFemale.Checked = True) Or (chkMale.Checked = False And chkFemale.Checked = False)) Then
                grdEmployee.DataSource = _clsHREmployee.GetTable()
            Else
                If rdoIDEmployee.Checked Then
                    If chkMale.Checked = True And chkFemale.Checked = False Then
                        grdEmployee.DataSource = _clsHREmployee.Search("IDEmployee", 0, txtSearch.Text)
                    Else
                        If chkFemale.Checked = True And chkMale.Checked = False Then
                            grdEmployee.DataSource = _clsHREmployee.Search("IDEmployee", 1, txtSearch.Text)
                        Else
                            grdEmployee.DataSource = _clsHREmployee.Search("IDEmployee", 2, txtSearch.Text)
                        End If
                    End If
                Else
                    If rdoEName.Checked Then
                        If chkMale.Checked = True And chkFemale.Checked = False Then
                            grdEmployee.DataSource = _clsHREmployee.Search("FirstName", 0, txtSearch.Text)
                        Else
                            If chkFemale.Checked = True And chkMale.Checked = False Then
                                grdEmployee.DataSource = _clsHREmployee.Search("FirstName", 1, txtSearch.Text)
                            Else
                                grdEmployee.DataSource = _clsHREmployee.Search("FirstName", 2, txtSearch.Text)
                            End If
                        End If
                    Else
                        If rdoJobTitleName.Checked Then
                            If chkMale.Checked = True And chkFemale.Checked = False Then
                                grdEmployee.DataSource = _clsHREmployee.Search("HRJob.JName", 0, txtSearch.Text)
                            Else
                                If chkFemale.Checked = True And chkMale.Checked = False Then
                                    grdEmployee.DataSource = _clsHREmployee.Search("HRJob.JName", 1, txtSearch.Text)
                                Else
                                    grdEmployee.DataSource = _clsHREmployee.Search("HRJob.JName", 2, txtSearch.Text)
                                End If
                            End If
                        Else
                            If rdoLevelName.Checked Then
                                If chkMale.Checked = True And chkFemale.Checked = False Then
                                    grdEmployee.DataSource = _clsHREmployee.Search("HRLev.LName", 0, txtSearch.Text)
                                Else
                                    If chkFemale.Checked = True And chkMale.Checked = False Then
                                        grdEmployee.DataSource = _clsHREmployee.Search("HRLev.LName", 1, txtSearch.Text)
                                    Else
                                        grdEmployee.DataSource = _clsHREmployee.Search("HRLev.LName", 2, txtSearch.Text)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._search)", "frmHREmployee._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Employee"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HREmployee")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDJobTitle.Text)
                _XMLNewRow(oDataTable, "1", lblJobTitleName.Text)
                _XMLNewRow(oDataTable, "2", txtIDLevel.Text)
                _XMLNewRow(oDataTable, "3", lblLevelName.Text)
                _XMLNewRow(oDataTable, "4", txtIDEmployee.Text)
                _XMLNewRow(oDataTable, "5", txtEName.Text)
                _XMLNewRow(oDataTable, "6", txtLName.Text)
                If rdoMale.Checked = True Then
                    _XMLNewRow(oDataTable, "7", "1")
                Else
                    _XMLNewRow(oDataTable, "7", "0")
                End If
                _XMLNewRow(oDataTable, "8", txtBirthDay.GetDate)
                _XMLNewRow(oDataTable, "9", txtHireDay.GetDate)
                _XMLNewRow(oDataTable, "10", txtHomePhone.Text1 & "," & txtHomePhone.Text2 & "," & txtHomePhone.Text3)
                _XMLNewRow(oDataTable, "11", txtMobilePhone.Text1 & "," & txtMobilePhone.Text2 & "," & txtMobilePhone.Text3)
                _XMLNewRow(oDataTable, "12", txtEmail.Text1 & "," & txtEmail.Text2 & "," & txtEmail.Text3)
                _XMLNewRow(oDataTable, "13", txtTemResident.Text)
                _XMLNewRow(oDataTable, "14", txtResident.Text)
                _XMLNewRow(oDataTable, "15", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._saveFileDialog)", "frmHREmployee._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Employee"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Employee.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Employee.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Employee.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Employee.xml")
                txtIDJobTitle.Text = dsData.Tables(0).Rows(0)("Data")
                lblJobTitleName.Text = dsData.Tables(0).Rows(1)("Data")
                txtIDLevel.Text = dsData.Tables(0).Rows(2)("Data")
                lblLevelName.Text = dsData.Tables(0).Rows(3)("Data")
                If txtIDEmployee.TReadOnly = False Then
                    txtIDEmployee.Text = dsData.Tables(0).Rows(4)("Data")
                End If
                txtEName.Text = dsData.Tables(0).Rows(5)("Data")
                txtLName.Text = dsData.Tables(0).Rows(6)("Data")
                If dsData.Tables(0).Rows(7)("Data") = "1" Then
                    rdoMale.Checked = True
                Else
                    rdoFemale.Checked = True
                End If
                txtBirthDay.Text = clsMethods.GetDatePNA(dsData.Tables(0).Rows(8)("Data"))
                txtHireDay.Text = clsMethods.GetDatePNA(dsData.Tables(0).Rows(9)("Data"))
                _setTextPNA1(txtHomePhone, dsData.Tables(0).Rows(10)("Data"))
                _setTextPNA1(txtMobilePhone, dsData.Tables(0).Rows(11)("Data"))
                _setTextPNA1(txtEmail, dsData.Tables(0).Rows(12)("Data"))
                txtTemResident.Text = dsData.Tables(0).Rows(13)("Data")
                txtResident.Text = dsData.Tables(0).Rows(14)("Data")
                Try
                    picPicture.Image = Image.FromFile(OpenFileDialog1.FileName & ".jpg")
                Catch ex As Exception
                    picPicture.Image = Nothing
                End Try
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Employee.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._openFileDialog)", "frmHREmployee._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        'Try
        '    If Not _rptHREmployee Is Nothing Then Exit Sub
        '    If _rptHREmployee Is Nothing Then _rptHREmployee = New rptHREmployee
        '    If _clsHREmployee Is Nothing Then _clsHREmployee = New clsHREmployee
        '    _rptHREmployee.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
        '    _rptHREmployee.Database.Tables(0).SetDataSource(_clsHREmployee.GetTable)
        '    _rptHREmployee.Refresh()
        '    _rptHREmployee.SetParameterValue("lblEmployee", clsConfig.GetLanguage(9, _strLang, True))
        '    _rptHREmployee.SetParameterValue("lblIDEmployee", clsConfig.GetLanguage(1, _strLang, True))
        '    _rptHREmployee.SetParameterValue("lblCName", clsConfig.GetLanguage(2, _strLang, ))
        '    _rptHREmployee.SetParameterValue("lblDescrible", clsConfig.GetLanguage(3, _strLang, True))
        '    _rptHREmployee.SetParameterValue("lblPicture", clsConfig.GetLanguage(22, _strLang, True))
        '    frmReview.GlobalForm.lblCaption.Text = clsConfig.GetLanguage(9, _strLang)
        '    frmReview.GlobalForm.rptViewer.ReportSource = _rptHREmployee
        '    frmReview.GlobalForm.ShowDialog(Me)
        '    _rptHREmployee.Dispose() : _rptHREmployee = Nothing
        '    _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
        'Catch ex As Exception
        '    ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._Review)", "frmHREmployee._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee._refesh)", "frmHREmployee._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDJobTitle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDJobTitle.DoubleClick
        _showHRLJobTitle()
    End Sub
    Private Sub txtIDJobTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDJobTitle.KeyDown
        If e.KeyCode = Keys.F4 Then
            _showHRLJobTitle()
            Exit Sub
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtIDLevel.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtIDLevel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDLevel.DoubleClick
        _showHRLLevel()
    End Sub
    Private Sub txtIDLevel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDLevel.KeyDown
        If e.KeyCode = Keys.F4 Then
            _showHRLLevel()
            Exit Sub
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtIDEmployee.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDJobTitle.Focus()
            End If
        End If
    End Sub
    Private Sub txtIDEmployee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDEmployee.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtEName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDLevel.Focus()
            End If
        End If
    End Sub
    Private Sub txtEName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtLName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDEmployee.Focus()
            End If
        End If
    End Sub
    Private Sub txtLName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtBirthDay.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtEName.Focus()
            End If
        End If
    End Sub
    Private Sub txtBirthDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBirthDay.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtHireDay.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtLName.Focus()
            End If
        End If
    End Sub
    Private Sub txtHireDay_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHireDay.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtHomePhone.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtBirthDay.Focus()
            End If
        End If
    End Sub
    Private Sub txtHomePhone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtHomePhone.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtMobilePhone.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtHireDay.Focus()
            End If
        End If
    End Sub
    Private Sub txtMobilePhone_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMobilePhone.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtEmail.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtHomePhone.Focus()
            End If
        End If
    End Sub
    Private Sub txtEmail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtTemResident.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtMobilePhone.Focus()
            End If
        End If
    End Sub
    Private Sub txtTemResident_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTemResident.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtResident.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtEmail.Focus()
            End If
        End If
    End Sub
    Private Sub txtResident_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtResident.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            btnAdd.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtTemResident.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HREmployee"
    Private Sub frmHREmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHREmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDEmployee_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDEmployee.Validating
        Try
            If txtIDEmployee.Text <> "" Then
                If clsHREmployee.IsExist(txtIDEmployee.Text) Then
                    If _clsHREmployee Is Nothing Then _clsHREmployee = New clsHREmployee
                    _clsHREmployee.GetInfor(txtIDEmployee.Text)
                    _getEmployee()
                    _clsHREmployee.DisposedEmployee() : _clsHREmployee = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHREmployee.txtIDEmployee_Validating)", "frmHREmployee.txtIDEmployee_Validating", True)
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
    Private Sub grdEmployee_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdEmployee.CellEnter
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