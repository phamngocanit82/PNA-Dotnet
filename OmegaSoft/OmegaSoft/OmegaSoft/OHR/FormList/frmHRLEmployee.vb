Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRLEmployee
#Region "Struct"
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
#End Region
#Region "Variables"
    Private _intX As Integer
    Private _intY As Integer
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLEmployee._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLEmployee._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            FrmList1.lblCaption.Text = clsConfig.GetLanguage(22, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(19, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDEmployee.Text = clsConfig.GetLanguage(3, _strLang)
            rdoEName.Text = clsConfig.GetLanguage(4, _strLang)
            rdoJobTitleName.Text = clsConfig.GetLanguage(20, _strLang)
            rdoLevelName.Text = clsConfig.GetLanguage(21, _strLang)
            chkMale.Text = clsConfig.GetLanguage(6, _strLang)
            chkFemale.Text = clsConfig.GetLanguage(7, _strLang)
            lblList.Text = clsConfig.GetLanguage(22, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLEmployee._getLang)", , True)
        End Try
    End Sub
    Public Sub LoadConfig()
        _getSkin()
        _getFont()
        _getLang()
    End Sub
#End Region
#Region "Others"
    Public Sub showForm(ByVal frm As Form)
        Dim winRect As New RECT
        GetWindowRect(frm.Handle, winRect)
        _intX = winRect.Left
        _intY = winRect.Top
        ShowDialog()
    End Sub
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLEmployee._setDataGrid)", "frmHRLEmployee._setDataGrid", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLEmployee._setHeaderDataGrid)", "frmHRLEmployee._setHeaderDataGrid", True)
        End Try
    End Sub
#End Region
#Region "Process"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLEmployee._search)", "frmHRLEmployee._search", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then _search()
    End Sub
#End Region
#Region "frmHRLEmployee"
    Private Sub frmHRLCountry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Left = _intX
        Top = _intY
        LoadConfig()
        _setDataGrid()
        AddHandler FrmList1.btnFormClose.Click, AddressOf Me.btnFormClose_Click
        AddHandler FrmList1.tbrClose.Click, AddressOf Me.tbrClose_Click
        AddHandler FrmList1.tbrCheck.Click, AddressOf Me.tbrCheck_Click
        AddHandler FrmList1.tbrRefesh.Click, AddressOf Me.tbrRefesh_Click
    End Sub
#End Region
#Region "Others"
    Private Sub btnFormClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub tbrClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub tbrCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
    End Sub
    Private Sub tbrRefesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _setDataGrid()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        _search()
    End Sub
    Private Sub grdEmployee_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEmployee.DoubleClick
        If grdEmployee.Rows.Count > 0 Then Me.Visible = False
    End Sub
    Private Sub grdEmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdEmployee.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdEmployee.Rows.Count > 0 Then Me.Visible = False
    End Sub
#End Region
#End Region
End Class