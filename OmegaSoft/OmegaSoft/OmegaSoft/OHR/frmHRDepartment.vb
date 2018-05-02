Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRDepartment
#Region " Global Form"
    Private Shared _frmHRDepartment As frmHRDepartment
    Public Shared Property GlobalForm() As frmHRDepartment
        Get
            If _frmHRDepartment Is Nothing OrElse _frmHRDepartment.IsDisposed Then
                _frmHRDepartment = New frmHRDepartment
            End If
            Return _frmHRDepartment
        End Get
        Set(ByVal Value As frmHRDepartment)
            _frmHRDepartment = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRDepartment.xml"
    Dim _clsHRDepartment As clsHRDepartment
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDCompany.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtIDDepartment.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDescrible.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDCompany.Text = clsConfig.GetLanguage(1, _strLang)
            lblIDDepartment.Text = clsConfig.GetLanguage(2, _strLang)
            lblDName.Text = clsConfig.GetLanguage(3, _strLang)
            lblDescrible.Text = clsConfig.GetLanguage(4, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(5, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(6, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(7, _strLang)
            btnSave.Text = clsConfig.GetLanguage(8, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(9, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDDepartment.Text = clsConfig.GetLanguage(2, _strLang)
            rdoDName.Text = clsConfig.GetLanguage(3, _strLang)
            rdoCompanyName.Text = clsConfig.GetLanguage(10, _strLang)
            lblList.Text = clsConfig.GetLanguage(11, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(21, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(22, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(23, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(24, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._getLang)", , True)
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
            If _clsHRDepartment Is Nothing Then _clsHRDepartment = New clsHRDepartment
            grdDepartment.AllowUserToAddRows = False
            grdDepartment.AllowUserToDeleteRows = False
            grdDepartment.ReadOnly = True
            grdDepartment.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdDepartment.RowHeadersWidth = 24
            grdDepartment.DataSource = _clsHRDepartment.GetTable()
            _setHeaderDataGrid()
            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._setDataGrid)", "frmHRDepartment._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            Dim i As Integer
            For i = 0 To grdDepartment.Columns.Count - 1
                grdDepartment.Columns(i).HeaderText = clsConfig.GetLanguage(i + 1, _strLang)
                grdDepartment.Columns(i).ToolTipText = grdDepartment.Columns(i).HeaderText
            Next
            grdDepartment.Columns(0).Width = 100
            grdDepartment.Columns(1).Width = 200
            grdDepartment.Columns(2).Width = 200
            grdDepartment.Columns(3).Width = 200
            lblList.Text = clsConfig.GetLanguage(11, _strLang) & " : " & grdDepartment.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._setHeaderDataGrid)", "frmHRDepartment._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            Dim _clsHRCompany As New clsHRCompany
            _clsHRCompany.GetInfor(grdDepartment.Item(0, intRowIndex).Value.ToString)
            txtIDCompany.Text = _clsHRCompany.IDCompany
            lblCompanyName.Text = _clsHRCompany.CName
            txtIDDepartment.Text = grdDepartment.Item(1, intRowIndex).Value.ToString
            txtDName.Text = grdDepartment.Item(2, intRowIndex).Value.ToString
            txtDescrible.Text = grdDepartment.Item(3, intRowIndex).Value.ToString
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._getCellEnter)", "frmHRDepartment._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdDepartment.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._getCellCurrent)", "frmHRDepartment._getCellCurrent", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDDepartment.TReadOnly = bolFlag
            txtDName.TReadOnly = bolFlag
            txtDescrible.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDCompany.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._setReadOnly)", "frmHRDepartment._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDCompany.Text = ""
        lblCompanyName.Text = ""
        txtIDDepartment.Text = ""
        txtDName.Text = ""
        txtDescrible.Text = ""
    End Sub
    Private Sub _setDepartment()
        Try
            _clsHRDepartment.IDCompany = txtIDCompany.Text.Trim
            _clsHRDepartment.IDDepartment = txtIDDepartment.Text.Trim
            _clsHRDepartment.DName = txtDName.Text.Trim
            _clsHRDepartment.Describle = txtDescrible.Text.Trim
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._setDepartment)", "frmHRDepartment._setDepartment", True)
        End Try
    End Sub
    Private Sub _getDepartment()
        Try
            Dim _clsHRCompany As New clsHRCompany
            _clsHRCompany.GetInfor(_clsHRDepartment.IDCompany)
            txtIDCompany.Text = _clsHRCompany.IDCompany
            lblCompanyName.Text = _clsHRCompany.CName
            txtIDDepartment.Text = _clsHRDepartment.IDDepartment
            txtDName.Text = _clsHRDepartment.DName
            txtDescrible.Text = _clsHRDepartment.Describle
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._getCompany)", "frmHRDepartment._getCompany", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._XMLNewRow)", "frmHRDepartment._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _showHRLCompany()
        Try
            Dim _frmHRLCompany As New frmHRLCompany
            _frmHRLCompany.showForm(Me)
            If _frmHRLCompany.IsDisposed = False And Not _frmHRLCompany Is Nothing Then
                txtIDCompany.Text = _frmHRLCompany.grdCompany.Item(1, _frmHRLCompany.grdCompany.CurrentCell.RowIndex).Value
                lblCompanyName.Text = _frmHRLCompany.grdCompany.Item(2, _frmHRLCompany.grdCompany.CurrentCell.RowIndex).Value
                _frmHRLCompany.Close()
                _frmHRLCompany.Dispose() : _frmHRLCompany = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._showHRLCompany)", "frmHRDepartment._showHRLCompany", True)
        End Try
    End Sub
    Private Sub _add()
        Try
            If CheckAdd("frmHRDepartment") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._add)", "frmHRDepartment._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDDepartment.Text = "" Then Exit Sub
            If CheckDelete("frmHRDepartment") Then
                If clsHRDepartment.IsExistJobTitle(txtIDDepartment.Text) = False Then
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        clsHRDepartment.Delete(txtIDDepartment.Text)
                        _setDataGrid()
                        _getCellCurrent()
                    End If
                Else
                    ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.Ok)
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(13, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._delete)", "frmHRDepartment._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmHRDepartment") Then
                _setReadOnly(False)
                txtIDCompany.Focus()
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(14, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._update)", "frmHRDepartment._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDCompany.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(18, _strLang), , InforButton.Ok)
                txtIDCompany.Focus()
                Exit Sub
            End If
            If txtIDDepartment.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(19, _strLang), , InforButton.Ok)
                txtIDCompany.Focus()
                Exit Sub
            End If
            If txtDName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.Ok)
                txtDName.Focus()
                Exit Sub
            End If
            If clsHRDepartment.IsExistJobTitle(txtIDDepartment.Text) = True Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.Ok)
                Exit Sub
            End If
            If CheckSave("frmHRDepartment") Then
                If clsHRDepartment.IsExist(txtIDDepartment.Text) Then
                    If CheckUpdate("frmHRDepartment") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(14, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHRDepartment Is Nothing Then _clsHRDepartment = New clsHRDepartment
                            _setDepartment()
                            _clsHRDepartment.Update()
                            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
                        Else
                            txtIDCompany.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHRDepartment Is Nothing Then _clsHRDepartment = New clsHRDepartment
                        _setDepartment()
                        _clsHRDepartment.Add()
                        _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
                    Else
                        txtIDCompany.Focus()
                        Exit Sub
                    End If
                End If
                _setReadOnly(True)
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                _setDataGrid()
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._save)", "frmHRDepartment._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHRDepartment Is Nothing Then _clsHRDepartment = New clsHRDepartment
            If txtSearch.Text = "" Or txtSearch.Text = "*" Then
                grdDepartment.DataSource = _clsHRDepartment.GetTable()
            Else
                If rdoIDDepartment.Checked Then
                    grdDepartment.DataSource = _clsHRDepartment.Search("IDDepartment", txtSearch.Text)
                Else
                    If rdoDName.Checked Then
                        grdDepartment.DataSource = _clsHRDepartment.Search("DName", txtSearch.Text)
                    Else
                        If rdoCompanyName.Checked Then
                            grdDepartment.DataSource = _clsHRDepartment.Search("HRCom.CName", txtSearch.Text)
                        End If
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._search)", "frmHRDepartment._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Department"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HRDepartment")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDCompany.Text)
                _XMLNewRow(oDataTable, "1", lblCompanyName.Text)
                _XMLNewRow(oDataTable, "2", txtIDDepartment.Text)
                _XMLNewRow(oDataTable, "3", txtDName.Text)
                _XMLNewRow(oDataTable, "4", txtDescrible.Text)
                _XMLNewRow(oDataTable, "5", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._saveFileDialog)", "frmHRDepartment._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Department"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Department.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Department.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Department.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Department.xml")
                txtIDCompany.Text = dsData.Tables(0).Rows(0)("Data")
                lblCompanyName.Text = dsData.Tables(0).Rows(1)("Data")
                If txtIDDepartment.TReadOnly = False Then
                    txtIDDepartment.Text = dsData.Tables(0).Rows(2)("Data")
                End If
                txtDName.Text = dsData.Tables(0).Rows(3)("Data")
                txtDescrible.Text = dsData.Tables(0).Rows(4)("Data")
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Department.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._openFileDialog)", "frmHRDepartment._openFileDialog", True)
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
        '    ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._Review)", "frmHRDepartment._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment._refesh)", "frmHRDepartment._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDCompany_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDCompany.DoubleClick
        _showHRLCompany()
    End Sub
    Private Sub txtIDCompany_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDCompany.KeyDown
        If e.KeyCode = Keys.F4 Then
            _showHRLCompany()
            Exit Sub
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtIDDepartment.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtIDDepartment_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDDepartment.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDCompany.Focus()
            End If
        End If
    End Sub
    Private Sub txtDName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDescrible.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDDepartment.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HRDepartment"
    Private Sub frmHRDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHRDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDDepartment_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDDepartment.Validating
        Try
            If txtIDDepartment.Text <> "" Then
                If clsHRDepartment.IsExist(txtIDDepartment.Text) Then
                    If _clsHRDepartment Is Nothing Then _clsHRDepartment = New clsHRDepartment
                    _clsHRDepartment.GetInfor(txtIDDepartment.Text)
                    _getDepartment()
                    _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRDepartment.txtIDDepartment_Validating)", "frmHRDepartment.txtIDDepartment_Validating", True)
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
    Private Sub grdDepartment_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDepartment.CellEnter
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