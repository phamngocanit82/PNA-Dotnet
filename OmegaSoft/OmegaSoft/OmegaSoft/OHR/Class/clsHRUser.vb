Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRUser
#Region "Variables"
    Private _strIDEmployee As String
    Private _strUName As String
    Private _strUPass As String
    Private _bolAdmin As Boolean
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
    Public Property UName() As String
        Get
            Return _strUName
        End Get
        Set(ByVal value As String)
            _strUName = value
        End Set
    End Property
    Public Property UPass() As String
        Get
            Return _strUPass
        End Get
        Set(ByVal value As String)
            _strUPass = value
        End Set
    End Property
    Public Property Admin() As Boolean
        Get
            Return _bolAdmin
        End Get
        Set(ByVal value As Boolean)
            _bolAdmin = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function IsExistEmployee(ByVal strIDEmployee As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDEmployee FROM HREmployee WHERE IDEmployee=N'" & strIDEmployee.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.IsExistEmployee)", , True)
        End Try
    End Function
    Public Shared Function IsExist(ByVal strUName As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 UName FROM HRUser WHERE UName=N'" & strUName.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.IsExist)", , True)
        End Try
    End Function
    Public Shared Function IsExistUser(ByVal strUName As String, ByVal strUPass As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 UName FROM HRUser WHERE UName=N'" & strUName.Trim & "' AND UPass=N'" & strUPass & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.IsExistUser)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO HRUser " & _
                                   "VALUES(N'" & _strIDEmployee & "',N'" & _strUName & "',N'" & _strUPass & "'," & _
                                   CInt(_bolAdmin) & ")"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strUName As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRUser WHERE UName=N'" & strUName.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "UPDATE HRUser SET " & _
                                   "IDEmployee=N'" & _strIDEmployee & "',UPass=N'" & _strUPass & "',Admin=" & CInt(_bolAdmin) & "  " & _
                                   "WHERE UName=N'" & _strUName & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRUser ORDER BY UName ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            Select Case strField
                Case "UName"
                    oCommand.CommandText = "SELECT * FROM HRUser " & _
                                           "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                           "ORDER BY IDLevel ASC"
                Case "EmployeeName"
                    oCommand.CommandText = "SELECT HRUse.* " & _
                                           "FROM HREmployee HREmp,HRUser HRUse " & _
                                           "WHERE HREmp.FirstName LIKE N'%" & strValue & "%' AND HRUse.IDEmployee=HREmp.IDEmployee " & _
                                           "ORDER BY HRUse.IDEmployee ASC"
            End Select
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strUName As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRUser WHERE UName=N'" & strUName.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.GetInfor)", , True)
        End Try
    End Function
    Public Function GetInforEmployee(ByVal strIDEmployee As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRUser WHERE IDEmployee=N'" & strIDEmployee.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.GetInforEmployee)", , True)
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
                _strUName = oDataReader.GetString(1)
            Catch ex As Exception
                _strUName = ""
            End Try
            Try
                _strUPass = oDataReader.GetString(2)
            Catch ex As Exception
                _strUPass = ""
            End Try
            Try
                _bolAdmin = oDataReader.GetBoolean(3)
            Catch ex As Exception
                _bolAdmin = False
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedUser() As Boolean
        Try
            _strIDEmployee = Nothing
            _strUName = Nothing
            _strUPass = Nothing
            _bolAdmin = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRUser.DisposedUser)", , True)
        End Try
    End Function
#End Region
End Class
