Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRJobTitle
#Region " Global Form"
    Private Shared _frmHRJobTitle As frmHRJobTitle
    Public Shared Property GlobalForm() As frmHRJobTitle
        Get
            If _frmHRJobTitle Is Nothing OrElse _frmHRJobTitle.IsDisposed Then
                _frmHRJobTitle = New frmHRJobTitle
            End If
            Return _frmHRJobTitle
        End Get
        Set(ByVal Value As frmHRJobTitle)
            _frmHRJobTitle = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRJobTitle.xml"
    Dim _clsHRJobTitle As clsHRJobTitle
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDDepartment.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtIDJobTitle.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtJName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDescrible.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDDepartment.Text = clsConfig.GetLanguage(1, _strLang)
            lblIDJobTitle.Text = clsConfig.GetLanguage(2, _strLang)
            lblJName.Text = clsConfig.GetLanguage(3, _strLang)
            lblDescrible.Text = clsConfig.GetLanguage(4, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(5, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(6, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(7, _strLang)
            btnSave.Text = clsConfig.GetLanguage(8, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(9, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDJobTitle.Text = clsConfig.GetLanguage(2, _strLang)
            rdoJName.Text = clsConfig.GetLanguage(3, _strLang)
            rdoDepartmentName.Text = clsConfig.GetLanguage(10, _strLang)
            lblList.Text = clsConfig.GetLanguage(11, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(21, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(22, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(23, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(24, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._getLang)", , True)
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
            If _clsHRJobTitle Is Nothing Then _clsHRJobTitle = New clsHRJobTitle
            grdJobTitle.AllowUserToAddRows = False
            grdJobTitle.AllowUserToDeleteRows = False
            grdJobTitle.ReadOnly = True
            grdJobTitle.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdJobTitle.RowHeadersWidth = 24
            grdJobTitle.DataSource = _clsHRJobTitle.GetTable()
            _setHeaderDataGrid()
            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._setDataGrid)", "frmHRJobTitle._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            Dim i As Integer
            For i = 0 To grdJobTitle.Columns.Count - 1
                grdJobTitle.Columns(i).HeaderText = clsConfig.GetLanguage(i + 1, _strLang)
                grdJobTitle.Columns(i).ToolTipText = grdJobTitle.Columns(i).HeaderText
            Next
            grdJobTitle.Columns(0).Width = 100
            grdJobTitle.Columns(1).Width = 200
            grdJobTitle.Columns(2).Width = 200
            grdJobTitle.Columns(3).Width = 200
            lblList.Text = clsConfig.GetLanguage(11, _strLang) & " : " & grdJobTitle.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._setHeaderDataGrid)", "frmHRJobTitle._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            Dim _clsHRDepartment As New clsHRDepartment
            _clsHRDepartment.GetInfor(grdJobTitle.Item(0, intRowIndex).Value.ToString)
            txtIDDepartment.Text = _clsHRDepartment.IDDepartment
            lblDepartmentName.Text = _clsHRDepartment.DName
            txtIDJobTitle.Text = grdJobTitle.Item(1, intRowIndex).Value.ToString
            txtJName.Text = grdJobTitle.Item(2, intRowIndex).Value.ToString
            txtDescrible.Text = grdJobTitle.Item(3, intRowIndex).Value.ToString
            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._getCellEnter)", "frmHRJobTitle._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdJobTitle.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._getCellCurrent)", "frmHRJobTitle._getCellCurrent", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDJobTitle.TReadOnly = bolFlag
            txtJName.TReadOnly = bolFlag
            txtDescrible.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDDepartment.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._setReadOnly)", "frmHRJobTitle._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDDepartment.Text = ""
        lblDepartmentName.Text = ""
        txtIDJobTitle.Text = ""
        txtJName.Text = ""
        txtDescrible.Text = ""
    End Sub
    Private Sub _setJobTitle()
        Try
            _clsHRJobTitle.IDDepartment = txtIDDepartment.Text.Trim
            _clsHRJobTitle.IDJobTitle = txtIDJobTitle.Text.Trim
            _clsHRJobTitle.JName = txtJName.Text.Trim
            _clsHRJobTitle.Describle = txtDescrible.Text.Trim
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._setJobTitle)", "frmHRJobTitle._setJobTitle", True)
        End Try
    End Sub
    Private Sub _getJobTitle()
        Try
            Dim _clsHRDepartment As New clsHRDepartment
            _clsHRDepartment.GetInfor(_clsHRJobTitle.IDDepartment)
            txtIDDepartment.Text = _clsHRDepartment.IDDepartment
            lblDepartmentName.Text = _clsHRDepartment.DName
            txtIDJobTitle.Text = _clsHRJobTitle.IDJobTitle
            txtJName.Text = _clsHRJobTitle.JName
            txtDescrible.Text = _clsHRJobTitle.Describle
            _clsHRDepartment.DisposedDepartment() : _clsHRDepartment = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._getJobTitle)", "frmHRJobTitle._getJobTitle", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._XMLNewRow)", "frmHRJobTitle._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _showHRLDepartment()
        Try
            Dim _frmHRLDepartment As New frmHRLDepartment
            _frmHRLDepartment.showForm(Me)
            If _frmHRLDepartment.IsDisposed = False And Not _frmHRLDepartment Is Nothing Then
                txtIDDepartment.Text = _frmHRLDepartment.grdDepartment.Item(1, _frmHRLDepartment.grdDepartment.CurrentCell.RowIndex).Value
                lblDepartmentName.Text = _frmHRLDepartment.grdDepartment.Item(2, _frmHRLDepartment.grdDepartment.CurrentCell.RowIndex).Value
                _frmHRLDepartment.Close()
                _frmHRLDepartment.Dispose() : _frmHRLDepartment = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._showHRLDepartment)", "frmHRJobTitle._showHRLDepartment", True)
        End Try
    End Sub
    Private Sub _add()
        Try
            If CheckAdd("frmHRJobTitle") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._add)", "frmHRJobTitle._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDJobTitle.Text = "" Then Exit Sub
            If CheckDelete("frmHRJobTitle") Then
                If clsHRJobTitle.IsExistEmployee(txtIDJobTitle.Text) = False Then
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        clsHRJobTitle.Delete(txtIDJobTitle.Text)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._delete)", "frmHRJobTitle._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmHRJobTitle") Then
                _setReadOnly(False)
                txtIDDepartment.Focus()
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(14, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._update)", "frmHRJobTitle._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDDepartment.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(18, _strLang), , InforButton.Ok)
                txtIDDepartment.Focus()
                Exit Sub
            End If
            If txtIDJobTitle.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(19, _strLang), , InforButton.Ok)
                txtIDJobTitle.Focus()
                Exit Sub
            End If
            If txtJName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(20, _strLang), , InforButton.Ok)
                txtJName.Focus()
                Exit Sub
            End If
            If clsHRJobTitle.IsExistEmployee(txtIDJobTitle.Text) = True Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(25, _strLang), , InforButton.Ok)
                Exit Sub
            End If
            If CheckSave("frmHRJobTitle") Then
                If clsHRJobTitle.IsExist(txtIDJobTitle.Text) Then
                    If CheckUpdate("frmHRJobTitle") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(14, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHRJobTitle Is Nothing Then _clsHRJobTitle = New clsHRJobTitle
                            _setJobTitle()
                            _clsHRJobTitle.Update()
                            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
                        Else
                            txtIDDepartment.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHRJobTitle Is Nothing Then _clsHRJobTitle = New clsHRJobTitle
                        _setJobTitle()
                        _clsHRJobTitle.Add()
                        _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
                    Else
                        txtIDDepartment.Focus()
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._save)", "frmHRJobTitle._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHRJobTitle Is Nothing Then _clsHRJobTitle = New clsHRJobTitle
            If txtSearch.Text = "" Or txtSearch.Text = "*" Then
                grdJobTitle.DataSource = _clsHRJobTitle.GetTable()
            Else
                If rdoIDJobTitle.Checked Then
                    grdJobTitle.DataSource = _clsHRJobTitle.Search("IDJobTitle", txtSearch.Text)
                Else
                    If rdoJName.Checked Then
                        grdJobTitle.DataSource = _clsHRJobTitle.Search("JName", txtSearch.Text)
                    Else
                        If rdoDepartmentName.Checked Then
                            grdJobTitle.DataSource = _clsHRJobTitle.Search("HRDep.DName", txtSearch.Text)
                        End If
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._search)", "frmHRJobTitle._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "JobTitle"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HRJobTitle")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDDepartment.Text)
                _XMLNewRow(oDataTable, "1", lblDepartmentName.Text)
                _XMLNewRow(oDataTable, "2", txtIDJobTitle.Text)
                _XMLNewRow(oDataTable, "3", txtJName.Text)
                _XMLNewRow(oDataTable, "4", txtDescrible.Text)
                _XMLNewRow(oDataTable, "5", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._saveFileDialog)", "frmHRJobTitle._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "JobTitle"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\JobTitle.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\JobTitle.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\JobTitle.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\JobTitle.xml")
                txtIDDepartment.Text = dsData.Tables(0).Rows(0)("Data")
                lblDepartmentName.Text = dsData.Tables(0).Rows(1)("Data")
                If txtIDJobTitle.TReadOnly = False Then
                    txtIDJobTitle.Text = dsData.Tables(0).Rows(2)("Data")
                End If
                txtJName.Text = dsData.Tables(0).Rows(3)("Data")
                txtDescrible.Text = dsData.Tables(0).Rows(4)("Data")
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\JobTitle.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._openFileDialog)", "frmHRJobTitle._openFileDialog", True)
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
        '    ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._Review)", "frmHRJobTitle._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle._refesh)", "frmHRJobTitle._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDDepartment_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDDepartment.DoubleClick
        _showHRLDepartment()
    End Sub
    Private Sub txtIDDepartment_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDDepartment.KeyDown
        If e.KeyCode = Keys.F4 Then
            _showHRLDepartment()
            Exit Sub
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtIDJobTitle.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtIDJobTitle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDJobTitle.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtJName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDDepartment.Focus()
            End If
        End If
    End Sub
    Private Sub txtJName_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtJName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDescrible.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDJobTitle.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HRJobTitle"
    Private Sub frmHRJobTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHRJobTitle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDJobTitle_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDJobTitle.Validating
        Try
            If txtIDJobTitle.Text <> "" Then
                If clsHRJobTitle.IsExist(txtIDJobTitle.Text) Then
                    If _clsHRJobTitle Is Nothing Then _clsHRJobTitle = New clsHRJobTitle
                    _clsHRJobTitle.GetInfor(txtIDJobTitle.Text)
                    _getJobTitle()
                    _clsHRJobTitle.DisposedJobTitle() : _clsHRJobTitle = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRJobTitle.txtIDJobTitle_Validating)", "frmHRJobTitle.txtIDJobTitle_Validating", True)
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
    Private Sub grdJobTitle_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdJobTitle.CellEnter
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