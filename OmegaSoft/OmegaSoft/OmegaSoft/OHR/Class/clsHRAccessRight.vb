Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRAccessRight
#Region "Variables"
    Private _strIDEmployee As String
    Private _strIDForm As String
    Private _strFName As String
    Private _bolCAdd As Boolean
    Private _bolCDelete As Boolean
    Private _bolCUpdate As Boolean
    Private _bolCSave As Boolean
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDEmployee() As String
        Get
            Return _strIDEmployee
        End Get
        Set(ByVal value As String)
            _strIDEmployee = value
        End Set
    End Property
    Public Property IDForm() As String
        Get
            Return _strIDForm
        End Get
        Set(ByVal value As String)
            _strIDForm = value
        End Set
    End Property
    Public Property FName() As String
        Get
            Return _strFName
        End Get
        Set(ByVal value As String)
            _strFName = value
        End Set
    End Property
    Public Property CAdd() As Boolean
        Get
            Return _bolCAdd
        End Get
        Set(ByVal value As Boolean)
            _bolCAdd = value
        End Set
    End Property
    Public Property CDelete() As Boolean
        Get
            Return _bolCDelete
        End Get
        Set(ByVal value As Boolean)
            _bolCDelete = value
        End Set
    End Property
    Public Property CUpdate() As Boolean
        Get
            Return _bolCUpdate
        End Get
        Set(ByVal value As Boolean)
            _bolCUpdate = value
        End Set
    End Property
    Public Property CSave() As Boolean
        Get
            Return _bolCSave
        End Get
        Set(ByVal value As Boolean)
            _bolCSave = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function IsExist(ByVal strIDEmployee As String, ByVal strFName As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDEmployee FROM HRAccessRight " & _
                                   "WHERE IDEmployee=N'" & strIDEmployee.Trim & "' AND FName=N'" & strFName.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader()
            If oDataReader.Read Then
                oDataReader.Close() : oDataReader = Nothing
                oCommand.Dispose() : oCommand = Nothing
                oConnect.CloseConnection() : oConnect = Nothing
                Return True
            Else
                oDataReader.Close() : oDataReader = Nothing
                oCommand.Dispose() : oCommand = Nothing
                oConnect.CloseConnection() : oConnect = Nothing
                Return False
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO HRAccessRight " & _
                                   "VALUES(N'" & _strIDEmployee & "',N'" & _strIDForm & "',N'" & _strFName & _
                                   "'," & CInt(_bolCAdd) & "," & CInt(_bolCDelete) & "," & CInt(_bolCUpdate) & "," & CInt(_bolCSave) & ")"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDEmployee As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRAccessRight WHERE IDEmployee=N'" & strIDEmployee.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.Delete)", , True)
        End Try
    End Function
    Public Function GetTableDepartment(ByVal strIDCompany As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.GetTableDepartment)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetTableEmployee(ByVal strIDDepartment As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.GetTableEmployee)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetTableFormList() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRFormList " & _
                                   "ORDER BY IDForm ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.GetTableFormList)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetTable(ByVal strIDEmployee As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRAccessRight " & _
                                   "WHERE IDEmployee=N'" & strIDEmployee.Trim & "' " & _
                                   "ORDER BY IDForm ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDEmployee As String, ByVal strIDForm As String, Optional ByVal strFName As String = "") As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            Dim flag As Boolean = False
            If strFName = "" Then
                oCommand.CommandText = "SELECT * FROM HRAccessRight WHERE IDEmployee=N'" & strIDEmployee.Trim & "' AND IDForm=N'" & strIDForm & "'"
            Else
                oCommand.CommandText = "SELECT * FROM HRAccessRight WHERE IDEmployee=N'" & strIDEmployee.Trim & "' AND FName=N'" & strFName & "'"
            End If
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
                flag = True
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return flag
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDEmployee = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDEmployee = ""
            End Try
            Try
                _strIDForm = oDataReader.GetString(1)
            Catch ex As Exception
                _strIDForm = ""
            End Try
            Try
                _strFName = oDataReader.GetString(2)
            Catch ex As Exception
                _strFName = ""
            End Try
            Try
                _bolCAdd = oDataReader.GetBoolean(3)
            Catch ex As Exception
                _bolCAdd = False
            End Try
            Try
                _bolCDelete = oDataReader.GetBoolean(4)
            Catch ex As Exception
                _bolCDelete = False
            End Try
            Try
                _bolCUpdate = oDataReader.GetBoolean(5)
            Catch ex As Exception
                _bolCUpdate = False
            End Try
            Try
                _bolCSave = oDataReader.GetBoolean(6)
            Catch ex As Exception
                _bolCSave = False
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedAccessRight() As Boolean
        Try
            _strIDEmployee = Nothing
            _strIDForm = Nothing
            _bolCAdd = Nothing
            _bolCDelete = Nothing
            _bolCUpdate = Nothing
            _bolCSave = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRAccessRight.DisposedAccessRight)", , True)
        End Try
    End Function
#End Region
End Class
