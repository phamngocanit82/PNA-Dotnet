Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRJobTitle
#Region "Variables"
    Private _strIDDepartment As String
    Private _strIDJobTitle As String
    Private _strJName As String
    Private _strDescrible As String
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDDepartment() As String
        Get
            Return _strIDDepartment
        End Get
        Set(ByVal value As String)
            _strIDDepartment = value
        End Set
    End Property
    Public Property IDJobTitle() As String
        Get
            Return _strIDJobTitle
        End Get
        Set(ByVal value As String)
            _strIDJobTitle = value
        End Set
    End Property
    Public Property JName() As String
        Get
            Return _strJName
        End Get
        Set(ByVal value As String)
            _strJName = value
        End Set
    End Property
    Public Property Describle() As String
        Get
            Return _strDescrible
        End Get
        Set(ByVal value As String)
            _strDescrible = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function IsExistEmployee(ByVal strIDJobTitle As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDJobTitle FROM HREmployee WHERE IDJobTitle=N'" & strIDJobTitle.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.IsExistEmployee)", , True)
        End Try
    End Function
    Public Shared Function IsExist(ByVal strIDJobTitle As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDJobTitle FROM HRJobTitle WHERE IDJobTitle=N'" & strIDJobTitle.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO HRJobTitle " & _
                                   "VALUES(N'" & _strIDDepartment & "',N'" & _strIDJobTitle & "',N'" & _strJName & _
                                   "',N'" & _strDescrible & "')"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDJobTitle As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRJobTitle WHERE IDJobTitle=N'" & strIDJobTitle.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "UPDATE HRJobTitle SET " & _
                                   "IDDepartment=N'" & _strIDDepartment & "',JName=N'" & _strJName & "',Describle=N'" & _strDescrible & "' " & _
                                   "WHERE IDJobTitle=N'" & _strIDJobTitle & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRJobTitle ORDER BY IDJobTitle ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            If strField = "HRCom.CName" Then
                oCommand.CommandText = "SELECT HRJob.* " & _
                                       "FROM HRDepartment HRDep,HRJobTitle HRJob " & _
                                       "WHERE HRJob.IDDepartment=HRDep.IDDepartment AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                       "ORDER BY IDJobTitle ASC"
            Else
                oCommand.CommandText = "SELECT * FROM HRJobTitle " & _
                                       "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                       "ORDER BY IDJobTitle ASC"
            End If

            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDJobTitle As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRJobTitle WHERE IDJobTitle=N'" & strIDJobTitle.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDDepartment = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDDepartment = ""
            End Try
            Try
                _strIDJobTitle = oDataReader.GetString(1)
            Catch ex As Exception
                _strIDJobTitle = ""
            End Try
            Try
                _strJName = oDataReader.GetString(2)
            Catch ex As Exception
                _strJName = ""
            End Try
            Try
                _strDescrible = oDataReader.GetString(3)
            Catch ex As Exception
                _strDescrible = ""
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedJobTitle() As Boolean
        Try
            _strIDDepartment = Nothing
            _strIDJobTitle = Nothing
            _strJName = Nothing
            _strDescrible = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRJobTitle.DisposedJobTitle)", , True)
        End Try
    End Function
#End Region
End Class
