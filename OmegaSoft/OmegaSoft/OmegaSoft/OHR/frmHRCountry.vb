Imports VB = Microsoft.VisualBasic
Imports System.IO
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRCountry
#Region " Global Form"
    Private Shared _frmHRCountry As frmHRCountry
    Public Shared Property GlobalForm() As frmHRCountry
        Get
            If _frmHRCountry Is Nothing OrElse _frmHRCountry.IsDisposed Then
                _frmHRCountry = New frmHRCountry
            End If
            Return _frmHRCountry
        End Get
        Set(ByVal Value As frmHRCountry)
            _frmHRCountry = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRCountry.xml"
    Dim _clsHRCountry As clsHRCountry
    Dim _rptHRCountry As rptHRCountry
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtIDCountry.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtCName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtDescrible.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblIDCountry.Text = clsConfig.GetLanguage(1, _strLang)
            lblCName.Text = clsConfig.GetLanguage(2, _strLang)
            lblDescrible.Text = clsConfig.GetLanguage(3, _strLang)
            btnAdd.Text = clsConfig.GetLanguage(4, _strLang)
            btnDelete.Text = clsConfig.GetLanguage(5, _strLang)
            btnUpdate.Text = clsConfig.GetLanguage(6, _strLang)
            btnSave.Text = clsConfig.GetLanguage(7, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(8, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDCountry.Text = clsConfig.GetLanguage(1, _strLang)
            rdoCName.Text = clsConfig.GetLanguage(2, _strLang)
            lblList.Text = clsConfig.GetLanguage(9, _strLang)
            tbrSave.ToolTipText = clsConfig.GetLanguage(18, _strLang)
            tbrOpen.ToolTipText = clsConfig.GetLanguage(19, _strLang)
            tbrReview.ToolTipText = clsConfig.GetLanguage(20, _strLang)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(21, _strLang)
            _setReadOnly(True)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._getLang)", , True)
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
            If _clsHRCountry Is Nothing Then _clsHRCountry = New clsHRCountry
            grdCountry.AllowUserToAddRows = False
            grdCountry.AllowUserToDeleteRows = False
            grdCountry.ReadOnly = True
            grdCountry.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdCountry.RowHeadersWidth = 24
            grdCountry.DataSource = _clsHRCountry.GetTable()
            _setHeaderDataGrid()
            _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._setDataGrid)", "frmHRCountry._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            Dim i As Integer
            For i = 0 To grdCountry.Columns.Count - 2
                grdCountry.Columns(i).HeaderText = clsConfig.GetLanguage(i + 1, _strLang)
                grdCountry.Columns(i).ToolTipText = grdCountry.Columns(i).HeaderText
            Next
            grdCountry.Columns(i).HeaderText = clsConfig.GetLanguage(22, _strLang)
            grdCountry.Columns(i).ToolTipText = grdCountry.Columns(i).HeaderText
            grdCountry.Columns(0).Width = 100
            grdCountry.Columns(1).Width = 200
            grdCountry.Columns(2).Width = 289
            grdCountry.Columns(3).Width = 100
            lblList.Text = clsConfig.GetLanguage(9, _strLang) & " : " & grdCountry.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._setHeaderDataGrid)", "frmHRCountry._setHeaderDataGrid", True)
        End Try
    End Sub
    Private Sub _getCellEnter(ByVal intRowIndex As Integer)
        Try
            txtIDCountry.Text = grdCountry.Item(0, intRowIndex).Value.ToString
            txtCName.Text = grdCountry.Item(1, intRowIndex).Value.ToString
            txtDescrible.Text = grdCountry.Item(2, intRowIndex).Value.ToString
            Try
                picPicture.Image = ByteToImage(grdCountry.Item(3, intRowIndex).Value)
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._getCellEnter)", "frmHRCountry._getCellEnter", True)
        End Try
    End Sub
    Private Sub _getCellCurrent()
        Try
            If grdCountry.Rows.Count = 0 Then
                _setText()
            Else
                _getCellEnter(0)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._getCellCurrent)", "frmHRCountry._getCellCurrent", True)
        End Try
    End Sub
    Private Sub _setReadOnly(ByVal bolFlag As Boolean)
        Try
            txtIDCountry.TReadOnly = bolFlag
            txtCName.TReadOnly = bolFlag
            txtDescrible.TReadOnly = bolFlag
            btnSave.Enabled = Not bolFlag
            txtIDCountry.Focus()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._setReadOnly)", "frmHRCountry._setReadOnly", True)
        End Try
    End Sub
    Private Sub _setText()
        txtIDCountry.Text = ""
        txtCName.Text = ""
        txtDescrible.Text = ""
        picPicture.Image = Nothing
    End Sub
    Private Sub _setCountry()
        Try
            _clsHRCountry.IDCountry = txtIDCountry.Text.Trim
            _clsHRCountry.CName = txtCName.Text.Trim
            _clsHRCountry.Describle = txtDescrible.Text.Trim
            Try
                _clsHRCountry.CPicture = picPicture.Image
            Catch ex As Exception
                _clsHRCountry.CPicture = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._setCountry)", "frmHRCountry._setCountry", True)
        End Try
    End Sub
    Private Sub _getCountry()
        Try
            txtIDCountry.Text = _clsHRCountry.IDCountry
            txtCName.Text = _clsHRCountry.CName
            txtDescrible.Text = _clsHRCountry.Describle
            Try
                Dim oBitmap As New Bitmap(_clsHRCountry.CPicture)
                picPicture.Image = oBitmap
            Catch ex As Exception
                picPicture.Image = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._getCountry)", "frmHRCountry._getCountry", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._XMLNewRow)", "frmHRCountry._XMLNewRow", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _add()
        Try
            If CheckAdd("frmHRCountry") Then
                _setText()
                _setReadOnly(False)
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(10, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._add)", "frmHRCountry._add", True)
        End Try
    End Sub
    Private Sub _delete()
        Try
            If txtIDCountry.Text = "" Then Exit Sub
            If CheckDelete("frmHRCountry") Then
                If clsHRCountry.IsExistCompany(txtIDCountry.Text) = False Then
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(14, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        clsHRCountry.Delete(txtIDCountry.Text)
                        _setDataGrid()
                        _getCellCurrent()
                    End If
                Else
                    ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
                End If
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(11, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._delete)", "frmHRCountry._delete", True)
        End Try
    End Sub
    Private Sub _update()
        Try
            If CheckUpdate("frmHRCountry") Then
                _setReadOnly(False)
                txtCName.Focus()
                txtIDCountry.TReadOnly = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
            Else
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._update)", "frmHRCountry._update", True)
        End Try
    End Sub
    Private Sub _save()
        Try
            If txtIDCountry.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(16, _strLang), , InforButton.Ok)
                txtIDCountry.Focus()
                Exit Sub
            End If
            If txtCName.Text = "" Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(17, _strLang), , InforButton.Ok)
                txtCName.Focus()
                Exit Sub
            End If
            If clsHRCountry.IsExistCompany(txtIDCountry.Text) = True Then
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(23, _strLang), , InforButton.Ok)
                Exit Sub
            End If
            If CheckSave("frmHRCountry") Then
                If clsHRCountry.IsExist(txtIDCountry.Text) Then
                    If CheckUpdate("frmHRCountry") = False Then
                        ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(12, _strLang), , InforButton.Ok)
                        Exit Sub
                    Else
                        If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                            If _clsHRCountry Is Nothing Then _clsHRCountry = New clsHRCountry
                            _setCountry()
                            _clsHRCountry.Update()
                            _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
                        Else
                            txtIDCountry.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(15, _strLang), , InforButton.YesNo) = InforButton.Yes Then
                        If _clsHRCountry Is Nothing Then _clsHRCountry = New clsHRCountry
                        _setCountry()
                        _clsHRCountry.Add()
                        _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
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
                ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(13, _strLang), , InforButton.Ok)
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._save)", "frmHRCountry._save", True)
        End Try
    End Sub
    Private Sub _search()
        Try
            If _clsHRCountry Is Nothing Then _clsHRCountry = New clsHRCountry
            If txtSearch.Text = "" Or txtSearch.Text = "*" Then
                grdCountry.DataSource = _clsHRCountry.GetTable()
            Else
                If rdoIDCountry.Checked Then
                    grdCountry.DataSource = _clsHRCountry.Search("IDCountry", txtSearch.Text)
                Else
                    If rdoCName.Checked Then
                        grdCountry.DataSource = _clsHRCountry.Search("CName", txtSearch.Text)
                    End If
                End If
            End If
            _setHeaderDataGrid()
            _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._search)", "frmHRCountry._search", True)
        End Try
    End Sub
    Private Sub _saveFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            SaveFileDialog1.FileName = "Country"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If File.Exists(SaveFileDialog1.FileName) Then
                    File.Delete(SaveFileDialog1.FileName)
                End If
                Dim oDataTable As New DataTable("HRCountry")
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
                _XMLNewRow(oDataTable, "1", txtCName.Text)
                _XMLNewRow(oDataTable, "2", txtDescrible.Text)
                _XMLNewRow(oDataTable, "3", Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._saveFileDialog)", "frmHRCountry._saveFileDialog", True)
        End Try
    End Sub
    Private Sub _openFileDialog()
        Try
            If btnSave.Enabled = False Then Exit Sub
            OpenFileDialog1.FileName = "Country"
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dsData As New DataSet
                If File.Exists(Application.StartupPath & "\FileTMP\Country.xml") Then
                    File.Delete(Application.StartupPath & "\FileTMP\Country.xml")
                End If
                File.Copy(OpenFileDialog1.FileName, Application.StartupPath & "\FileTMP\Country.xml")
                dsData.ReadXml(Application.StartupPath & "\FileTMP\Country.xml")
                If txtIDCountry.TReadOnly = False Then
                    txtIDCountry.Text = dsData.Tables(0).Rows(0)("Data")
                End If
                txtCName.Text = dsData.Tables(0).Rows(1)("Data")
                txtDescrible.Text = dsData.Tables(0).Rows(2)("Data")
                Try
                    picPicture.Image = Image.FromFile(OpenFileDialog1.FileName & ".jpg")
                Catch ex As Exception
                    picPicture.Image = Nothing
                End Try
                dsData.Dispose() : dsData = Nothing
                File.Delete(Application.StartupPath & "\FileTMP\Country.xml")
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._openFileDialog)", "frmHRCountry._openFileDialog", True)
        End Try
    End Sub
    Private Sub _review()
        Try
            If Not _rptHRCountry Is Nothing Then Exit Sub
            If _rptHRCountry Is Nothing Then _rptHRCountry = New rptHRCountry
            If _clsHRCountry Is Nothing Then _clsHRCountry = New clsHRCountry
            _rptHRCountry.SetDatabaseLogon(clsConfig.GetUserDB, clsConfig.GetPasswordDB, clsConfig.GetServerDB, clsConfig.GetDataBase)
            _rptHRCountry.Database.Tables(0).SetDataSource(_clsHRCountry.GetTable)
            _rptHRCountry.Refresh()
            _rptHRCountry.SetParameterValue("lblCountry", clsConfig.GetLanguage(9, _strLang, True))
            _rptHRCountry.SetParameterValue("lblIDCountry", clsConfig.GetLanguage(1, _strLang, True))
            _rptHRCountry.SetParameterValue("lblCName", clsConfig.GetLanguage(2, _strLang, ))
            _rptHRCountry.SetParameterValue("lblDescrible", clsConfig.GetLanguage(3, _strLang, True))
            _rptHRCountry.SetParameterValue("lblPicture", clsConfig.GetLanguage(22, _strLang, True))
            frmReview.GlobalForm.lblCaption.Text = clsConfig.GetLanguage(9, _strLang)
            frmReview.GlobalForm.rptViewer.ReportSource = _rptHRCountry
            frmReview.GlobalForm.ShowDialog(Me)
            _rptHRCountry.Dispose() : _rptHRCountry = Nothing
            _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._Review)", "frmHRCountry._Review", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry._refesh)", "frmHRCountry._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtIDCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIDCountry.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtCName.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                btnAdd.Focus()
            End If
        End If
    End Sub
    Private Sub txtCName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCName.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            txtDescrible.Focus()
        Else
            If e.KeyCode = Keys.Up Then
                txtIDCountry.Focus()
            End If
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "HRContry"
    Private Sub frmHRCountry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadConfig()
        _setDataGrid()
    End Sub
    Private Sub frmHRCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub txtIDCountry_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIDCountry.Validating
        Try
            If txtIDCountry.Text <> "" Then
                If clsHRCountry.IsExist(txtIDCountry.Text) Then
                    If _clsHRCountry Is Nothing Then _clsHRCountry = New clsHRCountry
                    _clsHRCountry.GetInfor(txtIDCountry.Text)
                    _getCountry()
                    _clsHRCountry.DisposedCountry() : _clsHRCountry = Nothing
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRCountry.txtIDCountry_Validating)", "frmHRCountry.txtIDCountry_Validating", True)
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
    Private Sub grdCountry_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCountry.CellEnter
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