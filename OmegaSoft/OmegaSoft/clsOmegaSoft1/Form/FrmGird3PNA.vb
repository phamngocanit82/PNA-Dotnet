Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports VB = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Imports System.Data.SqlClient
Public Class FrmGird3PNA
    Public Shadows Event KeyDown As KeyEventHandler
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
    Private _strText As String
    Private _bolCheck As Boolean
#End Region
#Region "Properties"
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
        lblList.Text = _strText & " - " & grdList.Rows.Count
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
    Public Function GetTableCompany() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            Dim _dsData As New DataSet
            oCommand.CommandText = "SELECT HRCom.IDCountry,HRCom.IDCompany,HRCom.CName,HRCom.Branch,HRCom.Director," & _
                                   "HRCom.TaxCode,HRCom.Business,HRCom.Phone,HRCom.Fax,HRCom.Email,HRCom.WebSite,HRCom.Address,HRCon.CName " & _
                                   "FROM HRCountry HRCon,HRCompany HRCom " & _
                                   "WHERE HRCom.IDCountry=HRCon.IDCountry " & _
                                   "ORDER BY HRCom.IDCompany ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            '  ShowInfor(Nothing, "", ex.Message.ToString & "(FrmGird3PNA.GetTableCompany)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetTableDepartment(ByVal strIDCompany As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            Dim _dsData As New DataSet
            oCommand.CommandText = "SELECT * FROM HRDepartment " & _
                                   "WHERE IDCompany=N'" & strIDCompany.Trim & "' " & _
                                   "ORDER BY IDDepartment ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            'ShowInfor(Nothing, "", ex.Message.ToString & "(FrmGird3PNA.GetTableDepartment)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetTableEmployee(ByVal strIDDepartment As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            Dim _dsData As New DataSet
            oCommand.CommandText = "SELECT HREmp.IDEmployee,EName=HREmp.LastName+' '+HREmp.FirstName+' - '+ HRJob.JName " & _
                                   "FROM HRDepartment HRDep,HRJobTitle HRJob,HREmployee HREmp " & _
                                   "WHERE HRDep.IDDepartment=N'" & strIDDepartment.Trim & "' AND HRJob.IDDepartment=HRDep.IDDepartment " & _
                                   "AND HREmp.IDJobTitle=HRJob.IDJobTitle " & _
                                   "ORDER BY HRJob.IDJobTitle ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FrmGird3PNA.GetTableEmployee)", , True)
        End Try
        Return Nothing
    End Function
    Private Sub _setDataSource()
        Try
            Dim oTableCompany As New DataTable
            Dim oTableDepartment As DataTable = Nothing
            Dim oTableEmployee As DataTable = Nothing
            Dim i As Integer, j As Integer, k As Integer, nRow As Integer = 1
            oTableCompany = GetTableCompany()
            grdList.Rows.Count = 1
            grdList.Tree.Column = 1
            For i = 0 To oTableCompany.Rows.Count - 1
                grdList.Rows.InsertNode(nRow, 0)
                grdList.Rows(nRow)(1) = oTableCompany.Rows(i)(2)
                grdList.Rows(nRow).StyleNew.BackColor = Color.FromArgb(27, 153, 234)
                grdList.Rows(nRow).StyleNew.ForeColor = Color.White
                nRow = nRow + 1
                If oTableDepartment Is Nothing Then
                    oTableDepartment = New DataTable
                End If
                oTableDepartment = GetTableDepartment(oTableCompany.Rows(i)(1))
                For j = 0 To oTableDepartment.Rows.Count - 1
                    grdList.Rows.InsertNode(nRow, 1)
                    grdList.Rows(nRow)(1) = oTableDepartment.Rows(j)(2)
                    grdList.Rows(nRow).StyleNew.BackColor = Color.FromArgb(149, 216, 251)
                    nRow = nRow + 1
                    If oTableEmployee Is Nothing Then
                        oTableEmployee = New DataTable
                    End If
                    oTableEmployee = GetTableEmployee(oTableDepartment.Rows(j)(1))
                    For k = 0 To oTableEmployee.Rows.Count - 1
                        grdList.Rows.InsertNode(nRow, 2)
                        grdList.Rows(nRow)(1) = oTableEmployee.Rows(k)(1)
                        grdList.Rows(nRow)(2) = oTableEmployee.Rows(k)(0)
                        grdList.Rows(nRow).StyleNew.BackColor = Color.White
                        nRow = nRow + 1
                    Next
                    oTableEmployee.Dispose() : oTableEmployee = Nothing
                Next
                oTableDepartment.Dispose() : oTableDepartment = Nothing
            Next
            grdList.Tree.Show(1)
            oTableCompany.Dispose() : oTableCompany = Nothing
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
#Region "FrmGird2PNA"
    Private Sub FrmGird2PNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = _intX
        Top = _intY
        _setDataSource()
    End Sub
    Private Sub FrmGird1PNA_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Visible = False
    End Sub
#End Region
#End Region
#Region "Others"
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
        _setDataSource()
    End Sub
    Private Sub grdList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdList.Click
        Try
            If grdList.Rows(grdList.RowSel)(2) = "" Then
                grdList.Rows(0)(1) = ""
            Else
                grdList.Rows(0)(1) = grdList.Rows(grdList.RowSel)(1)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub grdList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdList.DoubleClick
        If grdList.Rows.Count > 0 Then
            If grdList.Rows(grdList.RowSel)(2) <> "" Then
                PNAChecked = True
                Me.Visible = False
            End If
        End If
    End Sub
    Private Sub grdList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdList.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyData = Keys.Control + Keys.S) And grdList.Rows.Count > 0 Then
            If grdList.Rows(grdList.RowSel)(2) <> "" Then
                PNAChecked = True
                Me.Visible = False
            End If
        End If
    End Sub
#End Region
End Class
