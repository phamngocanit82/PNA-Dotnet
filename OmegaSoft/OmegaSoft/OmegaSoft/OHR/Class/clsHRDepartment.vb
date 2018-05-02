Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRDepartment
#Region "Variables"
    Private _strIDCompany As String
    Private _strIDDepartment As String
    Private _strDName As String
    Private _strDescrible As String
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDCompany() As String
        Get
            Return _strIDCompany
        End Get
        Set(ByVal value As String)
            _strIDCompany = value
        End Set
    End Property
    Public Property IDDepartment() As String
        Get
            Return _strIDDepartment
        End Get
        Set(ByVal value As String)
            _strIDDepartment = value
        End Set
    End Property
    Public Property DName() As String
        Get
            Return _strDName
        End Get
        Set(ByVal value As String)
            _strDName = value
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
    Public Shared Function IsExistJobTitle(ByVal strIDDepartment As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDDepartment FROM HRJobTitle WHERE IDDepartment=N'" & strIDDepartment.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.IsExistJobTitle)", , True)
        End Try
    End Function
    Public Shared Function IsExist(ByVal strIDDepartment As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDDepartment FROM HRDepartment WHERE IDDepartment=N'" & strIDDepartment.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO HRDepartment " & _
                                   "VALUES(N'" & _strIDCompany & "',N'" & _strIDDepartment & "',N'" & _strDName & _
                                   "',N'" & _strDescrible & "')"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDDepartment As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRDepartment WHERE IDDepartment=N'" & strIDDepartment.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "UPDATE HRDepartment SET " & _
                                   "IDCompany=N'" & _strIDCompany & "',DName=N'" & _strDName & "',Describle=N'" & _strDescrible & "' " & _
                                   "WHERE IDDepartment=N'" & _strIDDepartment & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRDepartment ORDER BY IDDepartment ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            If strField = "HRCom.CName" Then
                oCommand.CommandText = "SELECT HRDep.* " & _
                                       "FROM HRCompany HRCom,HRDepartment HRDep " & _
                                       "WHERE HRDep.IDCompany=HRCom.IDCompany AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                       "ORDER BY IDDepartment ASC"
            Else
                oCommand.CommandText = "SELECT * FROM HRDepartment " & _
                                       "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                       "ORDER BY IDDepartment ASC"
            End If
            
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDDepartment As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRDepartment WHERE IDDepartment=N'" & strIDDepartment.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDCompany = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDCompany = ""
            End Try
            Try
                _strIDDepartment = oDataReader.GetString(1)
            Catch ex As Exception
                _strIDDepartment = ""
            End Try
            Try
                _strDName = oDataReader.GetString(2)
            Catch ex As Exception
                _strDName = ""
            End Try
            Try
                _strDescrible = oDataReader.GetString(3)
            Catch ex As Exception
                _strDescrible = ""
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedDepartment() As Boolean
        Try
            _strIDCompany = Nothing
            _strIDDepartment = Nothing
            _strDName = Nothing
            _strDescrible = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRDepartment.DisposedDepartment)", , True)
        End Try
    End Function
#End Region
End Class
