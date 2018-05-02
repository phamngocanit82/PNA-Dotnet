Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRLJobTitle
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
    Dim _clsHRJobTitle As clsHRJobTitle
    Private _strLang As String = "Langague\OHR\XMLHRJobTitle.xml"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLJobTitle._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtSearch.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLJobTitle._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            FrmList1.lblCaption.Text = clsConfig.GetLanguage(11, _strLang)
            lblSearch.Text = clsConfig.GetLanguage(9, _strLang)
            btnSearch.Text = "     &" & lblSearch.Text
            rdoIDJobTitle.Text = clsConfig.GetLanguage(2, _strLang)
            rdoJName.Text = clsConfig.GetLanguage(3, _strLang)
            rdoDepartmentName.Text = clsConfig.GetLanguage(10, _strLang)
            lblList.Text = clsConfig.GetLanguage(11, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLJobTitle._getLang)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLJobTitle._setDataGrid)", "frmHRLJobTitle._setDataGrid", True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLJobTitle._setHeaderDataGrid)", "frmHRLJobTitle._setHeaderDataGrid", True)
        End Try
    End Sub
#End Region
#Region "Process"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRLJobTitle._search)", "frmHRLJobTitle._search", True)
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
#Region "HRLDepartment"
    Private Sub frmHRLJobTitle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Private Sub grdJobTitle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdJobTitle.DoubleClick
        If grdJobTitle.Rows.Count > 0 Then Me.Visible = False
    End Sub
    Private Sub grdDepartment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdJobTitle.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdJobTitle.Rows.Count > 0 Then Me.Visible = False
    End Sub
#End Region
#End Region
End Class