Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsULCustomer
#Region "Variables"
    Private _strIDCustomer As String
    Private _strCName As String
    Private _strDescrible As String
    Private _strPhone As String
    Private _strFax As String
    Private _strEmail As String
    Private _strWebSite As String
    Private _strAddress As String
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDCustomer() As String
        Get
            Return _strIDCustomer
        End Get
        Set(ByVal value As String)
            _strIDCustomer = value
        End Set
    End Property
    Public Property CName() As String
        Get
            Return _strCName
        End Get
        Set(ByVal value As String)
            _strCName = value
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
    Public Shared Function IsExist(ByVal strIDCustomer As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDCustomer FROM ULCustomer WHERE IDCustomer=N'" & strIDCustomer.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "INSERT INTO ULCustomer " & _
                                   "VALUES(N'" & _strIDCustomer & "',N'" & _strCName & "',N'" & _strDescrible & _
                                   "',N'" & _strPhone & "',N'" & _strFax & "',N'" & _strEmail & _
                                   "',N'" & _strWebSite & "',N'" & _strAddress & "')"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDCustomer As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM ULCustomer WHERE IDCustomer=N'" & strIDCustomer.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "UPDATE ULCustomer SET " & _
                                   "CName=N'" & _strCName & "',Describle=N'" & _strDescrible & "',Phone=N'" & _strPhone & _
                                   "',Fax=N'" & _strFax & "',Email=N'" & _strEmail & _
                                   "',WebSite=N'" & _strWebSite & "',Address=N'" & _strAddress & "' " & _
                                   "WHERE IDCustomer=N'" & IDCustomer & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM ULCustomer ORDER BY IDCustomer ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM ULCustomer " & _
                                   "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                   "ORDER BY IDCustomer ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDCustomer As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM ULCustomer WHERE IDCustomer=N'" & strIDCustomer.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDCustomer = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDCustomer = ""
            End Try
            Try
                _strCName = oDataReader.GetString(1)
            Catch ex As Exception
                _strCName = ""
            End Try
            Try
                _strDescrible = oDataReader.GetString(2)
            Catch ex As Exception
                _strDescrible = ""
            End Try
            Try
                _strPhone = oDataReader.GetString(3)
            Catch ex As Exception
                _strPhone = ""
            End Try
            Try
                _strFax = oDataReader.GetString(4)
            Catch ex As Exception
                _strFax = ""
            End Try
            Try
                _strEmail = oDataReader.GetString(5)
            Catch ex As Exception
                _strEmail = ""
            End Try
            Try
                _strWebSite = oDataReader.GetString(6)
            Catch ex As Exception
                _strWebSite = ""
            End Try
            Try
                _strAddress = oDataReader.GetString(7)
            Catch ex As Exception
                _strAddress = ""
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedCustomer() As Boolean
        Try
            _strIDCustomer = Nothing
            _strCName = Nothing
            _strDescrible = Nothing
            _strPhone = Nothing
            _strFax = Nothing
            _strEmail = Nothing
            _strWebSite = Nothing
            _strAddress = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsULCustomer.DisposedCustomer)", , True)
        End Try
    End Function
#End Region
End Class
