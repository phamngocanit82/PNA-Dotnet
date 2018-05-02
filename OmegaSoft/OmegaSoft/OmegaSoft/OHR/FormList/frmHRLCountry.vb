Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRLCountry
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
    Dim _clsHRCountry As clsHRCountry
    Private _strLang As String = "Langague\OHR\XMLHRCountry.xml"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCountry._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCountry._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            FrmList1.lblCaption.Text = clsConfig.GetLanguage(9, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(8, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDCountry.Text = clsConfig.GetLanguage(1, _strLang)
            rdoCName.Text = clsConfig.GetLanguage(2, _strLang)
            lblList.Text = clsConfig.GetLanguage(9, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCountry._getLang)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCountry._setDataGrid)", "frmHRLCountry._setDataGrid", True)
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
            grdCountry.Columns(2).Width = 200
            grdCountry.Columns(3).Width = 100
            lblList.Text = clsConfig.GetLanguage(9, _strLang) & " : " & grdCountry.Rows.Count
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCountry._setHeaderDataGrid)", "frmHRLCountry._setHeaderDataGrid", True)
        End Try
    End Sub
#End Region
#Region "Process"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLCountry._search)", "frmHRLCountry._search", True)
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
    Private Sub grdCountry_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdCountry.DoubleClick
        If grdCountry.Rows.Count > 0 Then Me.Visible = False
    End Sub
    Private Sub grdCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdCountry.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdCountry.Rows.Count > 0 Then Me.Visible = False
    End Sub
#End Region
#End Region
End Class