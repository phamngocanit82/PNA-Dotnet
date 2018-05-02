Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports VB = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Imports System.Data.SqlClient
Public Class FrmGird1PNA
#Region "Struct"
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32")> _
     Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
#End Region
#Region "Variables"
    Private intMouseMove As Boolean
    Private _intWidth As Integer
    Private _intHeight As Integer
    Private _intX As Integer
    Private _intY As Integer
    Private _strSQL As String
    Private _strText As String
    Private _strSelect As String
    Private _strOrder As String
    Private _bolCheck As Boolean
#End Region
#Region "Properties"
    Public Property PNASQL() As String
        Get
            Return _strSQL
        End Get
        Set(ByVal value As String)
            _strSQL = value
            _setDataSource(_strSQL)
        End Set
    End Property
    Public Property PNAChecked() As Boolean
        Get
            Return _bolCheck
        End Get
        Set(ByVal value As Boolean)
            _bolCheck = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Sub showForm(ByVal frm As Form, Optional ByVal strText As String = "")
        Dim winRect As New RECT
        GetWindowRect(frm.Handle, winRect)
        _intX = winRect.Left
        _intY = winRect.Top
        _strText = strText
        lblList.Text = _strText & " - " & grdList.RowCount
        Show(frm)
    End Sub
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblList.Handle, winRect)
            GetCursorPos(winPoint)
            If intMouseMove Then
                Location = New Point(winPoint.X - _intWidth, winPoint.Y - _intHeight)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intWidth = winPoint.X - winRect.Left
                    _intHeight = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception

        End Try
    End Function
#End Region
#Region "Process"
    Private Sub _setDataSource(ByVal strSQL As String)
        Try
            If strSQL = "" Then Exit Sub
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            Dim _dsData As New DataSet
            oCommand.CommandText = strSQL
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            grdList.DataSource = _dsData.Tables(0)
            lblList.Text = _strText & " - " & grdList.RowCount
            _dsData.Dispose() : _dsData = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PNASetGridColumns(ByVal strText As String, ByVal strWidth As String)
        Try
            Dim i As Integer
            Dim s1() As String, s2() As String
            s1 = strText.Split("|")
            s2 = strWidth.Split("|")
            grdList.RowHeadersWidth = 24
            grdList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            grdList.AllowUserToAddRows = False
            grdList.AllowUserToDeleteRows = False
            grdList.ReadOnly = True
            For i = 0 To s1.Length - 1
                grdList.Columns(i).HeaderText = s1(i)
                grdList.Columns(i).ToolTipText = s1(i)
                grdList.Columns(i).Width = s2(i)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PNASetComboSearch(ByVal strText As String, ByVal strField As String)
        Try
            Dim i As Integer
            Dim s1() As String, s2() As String
            s1 = strText.Split("|")
            s2 = strField.Split("|")
            cmbSearch.Items.Clear()
            For i = 0 To s1.Length - 1
                cmbSearch.Items.Add(s1(i))
                cmbSearch.Tag = strField
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub PNASetSelectOrder(ByVal strSelect As String, ByVal strOrder As String)
        Try
            _strSelect = strSelect
            _strOrder = strOrder
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _search()
        Try
            Dim strSQL As String
            Dim s() As String
            s = cmbSearch.Tag.Split("|")
            strSQL = _strSelect & " " & s(cmbSearch.SelectedIndex) & " Like N'%" & txtSearch.Text.Trim & "%' " & _strOrder
            _setDataSource(strSQL)
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Events"
#Region "LabelList"
    Private Sub lblList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblList.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                intMouseMove = True
            Else
                intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblList_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblList.MouseMove
        If intMouseMove Then
            _isInnerXY()
        End If
    End Sub
    Private Sub lblList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblList.MouseUp
        intMouseMove = False
    End Sub
#End Region
#Region "FrmGird1PNA"
    Private Sub FrmGird1PNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GlobalForm = Me
        Left = _intX
        Top = _intY
    End Sub
    Private Sub FrmGird1PNA_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Visible = False
    End Sub
#End Region
#End Region
#Region "Others"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        _search()
    End Sub
    Private Sub tbrClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrClose.Click
        PNAChecked = False
        Me.Visible = False
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        PNAChecked = False
        Me.Visible = False
    End Sub
    Private Sub tbrCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrCheck.Click
        PNAChecked = True
        Me.Visible = False
    End Sub
    Private Sub tbrRefesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrRefesh.Click
        _setDataSource(_strSQL)
    End Sub
    Private Sub grdList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdList.DoubleClick
        If grdList.Rows.Count > 0 Then
            PNAChecked = True
            Me.Visible = False
        End If
    End Sub
    Private Sub grdList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdList.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdList.Rows.Count > 0 Then
            PNAChecked = True
            Me.Visible = False
        End If
    End Sub
#End Region
End Class
