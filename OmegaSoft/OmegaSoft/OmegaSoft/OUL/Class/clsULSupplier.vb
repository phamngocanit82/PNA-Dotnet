Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsULSupplier
#Region "Variables"
    Private _strIDSupplier As String
    Private _strSName As String
    Private _strDescrible As String
    Private _strBusiness As String
    Private _strPhone As String
    Private _strFax As String
    Private _strEmail As String
    Private _strWebSite As String
    Private _strAddress As String
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDSupplier() As String
        Get
            Return _strIDSupplier
        End Get
        Set(ByVal value As String)
            _strIDSupplier = value
        End Set
    End Property
    Public Property SName() As String
        Get
            Return _strSName
        End Get
        Set(ByVal value As String)
            _strSName = value
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
    Public Property Business() As String
        Get
            Return _strBusiness
        End Get
        Set(ByVal value As String)
            _strBusiness = value
        End Set
    End Property
    Public Property Phone() As String
        Get
            Return _strPhone
        End Get
        Set(ByVal value As String)
            _strPhone = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return _strFax
        End Get
        Set(ByVal value As String)
            _strFax = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _strEmail
        End Get
        Set(ByVal value As String)
            _strEmail = value
        End Set
    End Property
    Public Property WebSite() As String
        Get
            Return _strWebSite
        End Get
        Set(ByVal value As String)
            _strWebSite = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return _strAddress
        End Get
        Set(ByVal value As String)
            _strAddress = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function IsExist(ByVal strIDSupplier As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDSupplier FROM ULSupplier WHERE IDSupplier=N'" & strIDSupplier.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO ULSupplier " & _
                                   "VALUES(N'" & _strIDSupplier & "',N'" & _strSName & "',N'" & _strDescrible & _
                                   "',N'" & _strBusiness & "',N'" & _strPhone & "',N'" & _strFax & _
                                   "',N'" & _strEmail & "',N'" & _strWebSite & "',N'" & _strAddress & "')"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDSupplier As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM ULSupplier WHERE IDSupplier=N'" & strIDSupplier.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "UPDATE ULSupplier SET " & _
                                   "SName=N'" & _strSName & "',Describle=N'" & _strDescrible & "',Business=N'" & _strBusiness & _
                                   "',Phone=N'" & _strPhone & "',Fax=N'" & _strFax & "',Email=N'" & _strEmail & _
                                   "',WebSite=N'" & _strWebSite & "',Address=N'" & _strAddress & "' " & _
                                   "WHERE IDSupplier=N'" & IDSupplier & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM ULSupplier ORDER BY IDSupplier ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM ULSupplier " & _
                                   "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                   "ORDER BY IDSupplier ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDSupplier As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM ULSupplier WHERE IDSupplier=N'" & strIDSupplier.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDSupplier = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDSupplier = ""
            End Try
            Try
                _strSName = oDataReader.GetString(1)
            Catch ex As Exception
                _strSName = ""
            End Try
            Try
                _strDescrible = oDataReader.GetString(2)
            Catch ex As Exception
                _strDescrible = ""
            End Try
            Try
                _strBusiness = oDataReader.GetString(3)
            Catch ex As Exception
                _strBusiness = ""
            End Try
            Try
                _strPhone = oDataReader.GetString(4)
            Catch ex As Exception
                _strPhone = ""
            End Try
            Try
                _strFax = oDataReader.GetString(5)
            Catch ex As Exception
                _strFax = ""
            End Try
            Try
                _strEmail = oDataReader.GetString(6)
            Catch ex As Exception
                _strEmail = ""
            End Try
            Try
                _strWebSite = oDataReader.GetString(7)
            Catch ex As Exception
                _strWebSite = ""
            End Try
            Try
                _strAddress = oDataReader.GetString(8)
            Catch ex As Exception
                _strAddress = ""
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedSupplier() As Boolean
        Try
            _strIDSupplier = Nothing
            _strSName = Nothing
            _strDescrible = Nothing
            _strBusiness = Nothing
            _strPhone = Nothing
            _strFax = Nothing
            _strEmail = Nothing
            _strWebSite = Nothing
            _strAddress = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULSupplier.DisposedSupplier)", , True)
        End Try
    End Function
#End Region
End Class
