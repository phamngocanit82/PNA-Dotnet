Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRLLevel
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
    Dim _clsHRLevel As clsHRLevel
    Private _strLang As String = "Langague\OHR\XMLHRLevel.xml"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLLevel._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLLevel._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            FrmList1.lblCaption.Text = clsConfig.GetLanguage(9, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(8, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDLevel.Text = clsConfig.GetLanguage(1, _strLang)
            rdoLName.Text = clsConfig.GetLanguage(2, _strLang)
            lblList.Text = clsConfig.GetLanguage(9, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLLevel._getLang)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLLevel._setDataGrid)", "frmHRLLevel._setDataGrid", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLLevel._setHeaderDataGrid)", "frmHRLLevel._setHeaderDataGrid", True)
        End Try
    End Sub
#End Region
#Region "Process"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLLevel._search)", "frmHRLLevel._search", True)
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
    Private Sub frmHRLLevel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Private Sub grdLevel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdLevel.DoubleClick
        If grdLevel.Rows.Count > 0 Then Me.Visible = False
    End Sub
    Private Sub grdLevel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdLevel.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdLevel.Rows.Count > 0 Then Me.Visible = False
    End Sub
#End Region
#End Region
End Class