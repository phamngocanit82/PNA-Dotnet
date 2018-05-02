Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRLevel
#Region " Global Form"
    Private Shared _frmHRLevel As frmHRLevel
    Public Shared Property GlobalForm() As frmHRLevel
        Get
            If _frmHRLevel Is Nothing OrElse _frmHRLevel.IsDisposed Then
                _frmHRLevel = New frmHRLevel
            End If
            Return _frmHRLevel
        End Get
        Set(ByVal Value As frmHRLevel)
            _frmHRLevel = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRLevel.xml"
    Dim _clsHRLevel As clsHRLevel
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDLevel.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtLName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDescrible.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDLevel.Text = clsConfig.GetLanguage(1, _strLang)
            lblLName.Text = clsConfig.GetLanguage(2, _strLang)
            lblDescrible.Text = clsConfig.GetLanguage(3, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(4, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(5, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(6, _strLang)
            btnSave.Text = clsConfig.GetLanguage(7, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(8, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDLevel.Text = clsConfig.GetLanguage(1, _strLang)
            rdoLName.Text = clsConfig.GetLanguage(2, _strLang)
            lblList.Text = clsConfig.GetLanguage(9, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(18, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(19, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(20, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(21, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._getLang)", , True)
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
            If _clsHRLevel Is Nothing Then _clsHRLevel = New clsHRLevel
            grdLevel.AllowUserToAddRows = False
            grdLevel.AllowUserToDeleteRows = False
            grdLevel.ReadOnly = True
            grdLevel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdLevel.RowHeadersWidth = 24
            grdLevel.DataSource = _clsHRLevel.GetTable()
            _setHeaderDataGrid()
            _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._setDataGrid)", "frmHRLevel._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            Dim i As Integer
            For i = 0 To grdLevel.Columns.Count - 1
                grdLevel.Columns(i).HeaderText = clsConfig.GetLanguage(i + 1, _strLang)
                grdLevel.Columns(i).ToolTipText = grdLevel.Columns(i).HeaderText
            Next
            grdLevel.Columns(0).Width = 100
            grdLevel.Columns(1).Width = 200
            grdLevel.Columns(2).Width = 385
            lblList.Text = clsConfig.GetLanguage(9, _strLang) & " : " & grdLevel.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._setHeaderDataGrid)", "frmHRLevel._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            txtIDLevel.Text = grdLevel.Item(0, intRowIndex).Value.ToString
            txtLName.Text = grdLevel.Item(1, intRowIndex).Value.ToString
            txtDescrible.Text = grdLevel.Item(2, intRowIndex).Value.ToString
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._getCellEnter)", "frmHRLevel._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdLevel.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._getCellCurrent)", "frmHRLevel._getCellCurrent", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDLevel.TReadOnly = bolFlag
            txtLName.TReadOnly = bolFlag
            txtDescrible.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDLevel.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._setReadOnly)", "frmHRLevel._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDLevel.Text = ""
        txtLName.Text = ""
        txtDescrible.Text = ""
    End Sub
    Private Sub _setLevel()
        Try
            _clsHRLevel.IDLevel = txtIDLevel.Text.Trim
            _clsHRLevel.LName = txtLName.Text.Trim
            _clsHRLevel.Describle = txtDescrible.Text.Trim
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._setLevel)", "frmHRLevel._setLevel", True)
        End Try
    End Sub
    Private Sub _getLevel()
        Try
            txtIDLevel.Text = _clsHRLevel.IDLevel
            txtLName.Text = _clsHRLevel.LName
            txtDescrible.Text = _clsHRLevel.Describle
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._getLevel)", "frmHRLevel._getLevel", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._XMLNewRow)", "frmHRLevel._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _add()
        Try
            If CheckAdd("frmHRLevel") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(10, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._add)", "frmHRLevel._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDLevel.Text = "" Then Exit Sub
            If CheckDelete("frmHRLevel") Then
                If clsHRLevel.IsExistEmployee(txtIDLevel.Text) = False Then
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(14, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        clsHRLevel.Delete(txtIDLevel.Text)
                        _setDataGrid()
                        _getCellCurrent()
                    End If
                Else
                    ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(22, _strLang), , InforButton.Ok)
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(11, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._delete)", "frmHRLevel._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmHRLevel") Then
                _setReadOnly(False)
                txtIDLevel.TReadOnly = True
                txtLName.Focus()
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._update)", "frmHRLevel._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDLevel.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.Ok)
                txtIDLevel.Focus()
                Exit Sub
            End If
            If txtLName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.Ok)
                txtLName.Focus()
                Exit Sub
            End If
            If clsHRLevel.IsExistEmployee(txtIDLevel.Text) = True Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(22, _strLang), , InforButton.Ok)
                Exit Sub
            End If
            If CheckSave("frmHRLevel") Then
                If clsHRLevel.IsExist(txtIDLevel.Text) Then
                    If CheckUpdate("frmHRLevel") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHRLevel Is Nothing Then _clsHRLevel = New clsHRLevel
                            _setLevel()
                            _clsHRLevel.Update()
                            _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
                        Else
                            txtIDLevel.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHRLevel Is Nothing Then _clsHRLevel = New clsHRLevel
                        _setLevel()
                        _clsHRLevel.Add()
                        _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
                    Else
                        txtIDLevel.Focus()
                        Exit Sub
                    End If
                End If
                _setReadOnly(True)
                btnAdd.Enabled = True
                btnDelete.Enabled = True
                btnUpdate.Enabled = True
                _setDataGrid()
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(13, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._save)", "frmHRLevel._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHRLevel Is Nothing Then _clsHRLevel = New clsHRLevel
            If txtSearch.Text = "" Or txtSearch.Text = "*" Then
                grdLevel.DataSource = _clsHRLevel.GetTable()
            Else
                If rdoIDLevel.Checked Then
                    grdLevel.DataSource = _clsHRLevel.Search("IDLevel", txtSearch.Text)
                Else
                    If rdoLName.Checked Then
                        grdLevel.DataSource = _clsHRLevel.Search("LName", txtSearch.Text)
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._search)", "frmHRLevel._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Level"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HRLevel")
                Dim oDataColumn As DataColumn
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Fields"
                oDataTable.Columns.Add(oDataColumn)
                oDataColumn = New DataColumn()
                oDataColumn.DataType = System.Type.GetType("System.String")
                oDataColumn.ColumnName = "Data"
                oDataTable.Columns.Add(oDataColumn)
                _XMLNewRow(oDataTable, "0", txtIDLevel.Text)
                _XMLNewRow(oDataTable, "1", txtLName.Text)
                _XMLNewRow(oDataTable, "2", txtDescrible.Text)
                _XMLNewRow(oDataTable, "3", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
                oDataTable.WriteXml(SaveFileDialog1.FileName)
                oDataColumn.Dispose() : oDataColumn = Nothing
                oDataTable.Dispose() : oDataTable = Nothing
                File.Encrypt(SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._saveFileDialog)", "frmHRLevel._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Level"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Level.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Level.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Level.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Level.xml")
                If txtIDLevel.TReadOnly = False Then
                    txtIDLevel.Text = dsData.Tables(0).Rows(0)("Data")
                End If
                txtLName.Text = dsData.Tables(0).Rows(1)("Data")
                txtDescrible.Text = dsData.Tables(0).Rows(2)("Data")
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Level.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._openFileDialog)", "frmHRLevel._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        'Try
        '    If Not _rptHRCountry Is Nothing Then Exit Sub
        '    If _rptHRCountry Is Nothing Then _rptHRCountry = New rptHRCountry
        '    If _clsHRLevel Is Nothing Then _clsHRLevel = New clsHRLevel
        '    _rptHRCountry.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
        '    _rptHRCountry.Database.Tables(0).SetDataSource(_clsHRLevel.GetTable)
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
        '    _clsHRLevel.DisposedCountry() : _clsHRLevel = Nothing
        'Catch ex As Exception
        '    ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._Review)", "frmHRLevel._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel._refesh)", "frmHRLevel._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDLevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDLevel.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtLName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtLName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDescrible.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDLevel.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HRLevel"
    Private Sub frmHRLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHRLevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDLevel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDLevel.Validating
        Try
            If txtIDLevel.Text <> "" Then
                If clsHRLevel.IsExist(txtIDLevel.Text) Then
                    If _clsHRLevel Is Nothing Then _clsHRLevel = New clsHRLevel
                    _clsHRLevel.GetInfor(txtIDLevel.Text)
                    _getLevel()
                    _clsHRLevel.DisposedLevel() : _clsHRLevel = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLevel.txtIDLevel_Validating)", "frmHRLevel.txtIDLevel_Validating", True)
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
    Private Sub grdLevel_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLevel.CellEnter
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