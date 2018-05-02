Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRLevel
#Region "Variables"
    Private _strIDLevel As String
    Private _strLName As String
    Private _strDescrible As String
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDLevel() As String
        Get
            Return _strIDLevel
        End Get
        Set(ByVal value As String)
            _strIDLevel = value
        End Set
    End Property
    Public Property LName() As String
        Get
            Return _strLName
        End Get
        Set(ByVal value As String)
            _strLName = value
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
    Public Shared Function IsExistEmployee(ByVal strIDLevel As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDLevel FROM HREmployee WHERE IDLevel=N'" & strIDLevel.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.IsExistEmployee)", , True)
        End Try
    End Function
    Public Shared Function IsExist(ByVal strIDLevel As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDLevel FROM HRLevel WHERE IDLevel=N'" & strIDLevel.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO HRLevel " & _
                                   "VALUES(N'" & _strIDLevel & "',N'" & _strLName & "',N'" & _strDescrible & "')"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDLevel As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRLevel WHERE IDLevel=N'" & strIDLevel.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "UPDATE HRLevel SET " & _
                                   "LName=N'" & _strLName & "',Describle=N'" & _strDescrible & "' " & _
                                   "WHERE IDLevel=N'" & _strIDLevel & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRLevel ORDER BY IDLevel ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRLevel " & _
                                   "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                   "ORDER BY IDLevel ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDLevel As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRLevel WHERE IDLevel=N'" & strIDLevel.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDLevel = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDLevel = ""
            End Try
            Try
                _strLName = oDataReader.GetString(1)
            Catch ex As Exception
                _strLName = ""
            End Try
            Try
                _strDescrible = oDataReader.GetString(2)
            Catch ex As Exception
                _strDescrible = ""
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedLevel() As Boolean
        Try
            _strIDLevel = Nothing
            _strLName = Nothing
            _strDescrible = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRLevel.DisposedLevel)", , True)
        End Try
    End Function
#End Region
End Class
