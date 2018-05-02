Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRLCompany
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
    Dim _clsHRCompany As clsHRCompany
    Private _strLang As String = "Langague\OHR\XMLHRCompany.xml"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCompany._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCompany._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            FrmList1.lblCaption.Text = clsConfig.GetLanguage(20, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(18, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDCompany.Text = clsConfig.GetLanguage(4, _strLang)
            rdoCName.Text = clsConfig.GetLanguage(5, _strLang)
            rdoCountryName.Text = clsConfig.GetLanguage(19, _strLang)
            lblList.Text = clsConfig.GetLanguage(20, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCompany._getLang)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCompany._setDataGrid)", "frmHRLCompany._setDataGrid", True)
        End Try
    End Sub
    Private Sub _setHeaderDataGrid()
        Try
            grdCompany.Columns(0).HeaderText = clsConfig.GetLanguage(1, _strLang)
            grdCompany.Columns(0).ToolTipText = grdCompany.Columns(1).HeaderText
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCompany._setHeaderDataGrid)", "frmHRLCompany._setHeaderDataGrid", True)
        End Try
    End Sub
#End Region
#Region "Process"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCompany._search)", "frmHRLCompany._search", True)
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
#Region "HRLContry"
    Private Sub frmHRLCompany_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Private Sub grdCompany_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdCompany.DoubleClick
        If grdCompany.Rows.Count > 0 Then Me.Visible = False
    End Sub
    Private Sub grdCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdCompany.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdCompany.Rows.Count > 0 Then Me.Visible = False
    End Sub
#End Region
#End Region
End Class