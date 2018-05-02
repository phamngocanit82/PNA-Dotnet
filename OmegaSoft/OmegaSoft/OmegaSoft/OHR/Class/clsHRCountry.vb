Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRCountry
#Region "Variables"
    Private _strIDCountry As String
    Private _strCName As String
    Private _strDescrible As String
    Private _picPicture As Bitmap
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDCountry() As String
        Get
            Return _strIDCountry
        End Get
        Set(ByVal value As String)
            _strIDCountry = value
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
    Public Property CPicture() As Bitmap
        Get
            Return _picPicture
        End Get
        Set(ByVal value As Bitmap)
            _picPicture = value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Shared Function IsExistCompany(ByVal strIDCountry As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDCountry FROM HRCompany WHERE IDCountry=N'" & strIDCountry.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.IsExistCompany)", , True)
        End Try
    End Function
    Public Shared Function IsExist(ByVal strIDCountry As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDCountry FROM HRCountry WHERE IDCountry=N'" & strIDCountry.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            If _picPicture Is Nothing Then
                oCommand.CommandText = "INSERT INTO HRCountry " & _
                                       "VALUES(N'" & _strIDCountry & "',N'" & _strCName & "',N'" & _strDescrible & "',null)"
            Else
                oCommand.CommandText = "INSERT INTO HRCountry " & _
                                       "VALUES(N'" & _strIDCountry & "',N'" & _strCName & "',N'" & _strDescrible & "',@picPicture)"
                oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                oCommand.Parameters("@picPicture").Value = ImageToByte(_picPicture)
            End If
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDCountry As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRCountry WHERE IDCountry=N'" & strIDCountry.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            If _picPicture Is Nothing Then
                oCommand.CommandText = "UPDATE HRCountry SET " & _
                                       "CName=N'" & _strCName & "',Describle=N'" & _strDescrible & "',Picture=null " & _
                                       "WHERE IDCountry=N'" & IDCountry & "'"
            Else
                oCommand.CommandText = "UPDATE HRCountry SET " & _
                                       "CName=N'" & _strCName & "',Describle=N'" & _strDescrible & "',Picture=@picPicture " & _
                                       "WHERE IDCountry=N'" & IDCountry & "'"
                oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                oCommand.Parameters("@picPicture").Value = ImageToByte(_picPicture)
            End If
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRCountry ORDER BY IDCountry ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRCountry " & _
                                   "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                   "ORDER BY IDCountry ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDCountry As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRCountry WHERE IDCountry=N'" & strIDCountry.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDCountry = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDCountry = ""
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
                _picPicture = ByteToImage(oDataReader.GetValue(3))
            Catch ex As Exception
                _picPicture = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedCountry() As Boolean
        Try
            _strIDCountry = Nothing
            _strCName = Nothing
            _strDescrible = Nothing
            If Not _picPicture Is Nothing Then _picPicture.Dispose()
            _picPicture = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCountry.DisposedCountry)", , True)
        End Try
    End Function
#End Region
End Class
