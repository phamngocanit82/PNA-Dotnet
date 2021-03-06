'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Drawing
Imports libraryPNA.clsSystem
Imports libraryPNA.clsError
Public Class clsHRCountryDB
    Private strIDCountry As String
    Private strCountryName As String
    Private strCountryCode As String
    Private strDescription As String
    Private _picPicture As Bitmap
    Private _strExtension As String
    Private dsData As DataSet
#Region "Properties"
    Public Property IDCountry() As String
        Get
            Return strIDCountry
        End Get
        Set(ByVal value As String)
            strIDCountry = value
        End Set
    End Property
    Public Property CountryName() As String
        Get
            Return strCountryName
        End Get
        Set(ByVal value As String)
            strCountryName = value
        End Set
    End Property
    Public Property CountryCode() As String
        Get
            Return strCountryCode
        End Get
        Set(ByVal value As String)
            strCountryCode = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return strDescription
        End Get
        Set(ByVal value As String)
            strDescription = value
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
    Public Property Extension() As String
        Get
            Return _strExtension
        End Get
        Set(ByVal value As String)
            _strExtension = value
        End Set
    End Property
#End Region
#Region "SQL"
    Public Shared Function IsExist(ByVal strIDCountry As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    oCommand.CommandText = "SELECT TOP 1 IDCountry " & _
                                           "FROM HRCountry " & _
                                           "WHERE IDCountry=N'" & strIDCountry & "'"
                    oCommand.Connection = oConnect.OpenConnectionHR()
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
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:IsExist)", ex.Message.ToString, IconType.IsExist)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    If _picPicture Is Nothing Then
                        oCommand.CommandText = "INSERT INTO HRCountry " & _
                                               "VALUES(" & TotalRow() + 1 & ",N'" & strIDCountry & "',N'" & strCountryName & _
                                                       "',N'" & strCountryCode & "',N'" & strDescription & "',null,N'" & _
                                                       _strExtension & "')"
                    Else
                        oCommand.CommandText = "INSERT INTO HRCountry " & _
                                               "VALUES(" & TotalRow() + 1 & ",N'" & strIDCountry & "',N'" & strCountryName & _
                                                       "',N'" & strCountryCode & "',N'" & strDescription & "',@picPicture,N'" & _
                                                       _strExtension & "')"
                        oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                        oCommand.Parameters("@picPicture").Value = clsIO.ImageToByte(_picPicture, _strExtension)
                    End If
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oCommand.ExecuteNonQuery()
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return True
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:Add)", ex.Message.ToString, IconType.Add)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDCountry As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "DELETE FROM HRCountry " & _
                                           "WHERE IDCountry=N'" & strIDCountry & "'"
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oCommand.ExecuteNonQuery()
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return True
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:Delete)", ex.Message.ToString, IconType.Delete)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    If _picPicture Is Nothing Then
                        oCommand.CommandText = "UPDATE HRCountry " & _
                                               "SET CountryName=N'" & strCountryName & "',CountryCode=N'" & strCountryCode & _
                                                    "',Description=N'" & strDescription & "',CPicture=null,Extension=N'" & _
                                                    _strExtension & "' " & _
                                               "WHERE IDCountry=N'" & IDCountry & "'"
                    Else
                        oCommand.CommandText = "UPDATE HRCountry " & _
                                               "SET CountryName=N'" & strCountryName & "',CountryCode=N'" & strCountryCode & _
                                                    "',Description=N'" & strDescription & "',CPicture=@picPicture,Extension=N'" & _
                                                    _strExtension & "' " & _
                                               "WHERE IDCountry=N'" & IDCountry & "'"
                        oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                        oCommand.Parameters("@picPicture").Value = clsIO.ImageToByte(_picPicture, _strExtension)
                    End If
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oCommand.ExecuteNonQuery()
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return True
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:Update)", ex.Message.ToString, IconType.Update)
        End Try
    End Function
    Public Function QueryTable(Optional ByVal strSelect As String = "IDCountry,CountryName,CountryCode,Description", _
                               Optional ByVal intTop As Integer = 1, _
                               Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRCountry " & _
                                               "ORDER BY Num DESC"
                    Else
                        oCommand.CommandText = strQuery
                    End If
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataAdapter.SelectCommand = oCommand
                    oDataAdapter.Fill(dsData)
                    oDataAdapter.Dispose() : oDataAdapter = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return dsData.Tables(indexTable)
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:QueryTable)", ex.Message.ToString, IconType.Query)
        End Try
        Return Nothing
    End Function
    Public Function Search(Optional ByVal strSelect As String = "IDCountry,CountryName,CountryCode,Description", _
                           Optional ByVal intTop As Integer = 1, _
                           Optional ByVal strField As String = "", Optional ByVal strValue As String = "", _
                           Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRCountry " & _
                                               "WHERE " & strField & " Like N'%" & strValue & "%' " & _
                                               "ORDER BY IDCountry ASC"
                    Else
                        oCommand.CommandText = strQuery
                    End If
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataAdapter.SelectCommand = oCommand
                    oDataAdapter.Fill(dsData)
                    oDataAdapter.Dispose() : oDataAdapter = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return dsData.Tables(indexTable)
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:Search)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchCondition(Optional ByVal strSelect As String = "IDCountry,CountryName,CountryCode,Description", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strWhere As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                           "FROM HRCountry " & _
                                           "WHERE " & strWhere & " " & _
                                           "ORDER BY IDCountry ASC"
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataAdapter.SelectCommand = oCommand
                    oDataAdapter.Fill(dsData)
                    oDataAdapter.Dispose() : oDataAdapter = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return dsData.Tables(indexTable)
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:SearchCondition)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchQuery(Optional ByVal strSelect As String = "IDCountry,CountryName,CountryCode,Description", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRCountry " & _
                                               "ORDER BY IDCountry ASC"
                    Else
                        oCommand.CommandText = strQuery
                    End If
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataAdapter.SelectCommand = oCommand
                    oDataAdapter.Fill(dsData)
                    oDataAdapter.Dispose() : oDataAdapter = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return dsData.Tables(indexTable)
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:SearchQuery)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDCountry As String, Optional ByVal strSelect As String = "IDCountry,CountryName,CountryCode,Description,CPicture,Extension", _
                             Optional ByVal strField As String = "IDCountry,CountryName,CountryCode,Description,CPicture,Extension") As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT " & strSelect & " " & _
                                           "FROM HRCountry " & _
                                           "WHERE IDCountry=N'" & strIDCountry & "'"
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataReader = oCommand.ExecuteReader
                    If oDataReader.Read Then
                        setInfor(oDataReader, strField)
                    End If
                    oDataReader.Close() : oDataReader = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:GetInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Private Sub setInfor(ByVal oDataReader As SqlDataReader, ByVal strField As String)
        Try
            Dim s() As String = vb.Split(strField, ",")
            Dim i As Integer = 0
            For i = 0 To s.Length - 1
                Select Case s(i)
                    Case "IDCountry"
                        strIDCountry = oDataReader.Item(s(i)).ToString
                    Case "CountryName"
                        strCountryName = oDataReader.Item(s(i)).ToString
                    Case "CountryCode"
                        strCountryCode = oDataReader.Item(s(i)).ToString
                    Case "Description"
                        strDescription = oDataReader.Item(s(i)).ToString
                    Case "CPicture"
                        Try
                            _picPicture = clsIO.ByteToImage(oDataReader.Item(s(i)))
                        Catch ex As Exception
                            _picPicture = Nothing
                        End Try
                    Case "Extension"
                        _strExtension = oDataReader.Item(s(i)).ToString
                End Select
            Next
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:setInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Function UnsetCountry() As Boolean
        Try
            strIDCountry = Nothing
            strCountryName = Nothing
            strCountryCode = Nothing
            strDescription = Nothing
            If Not _picPicture Is Nothing Then _picPicture.Dispose()
            _picPicture = Nothing
            If Not dsData Is Nothing Then dsData.Dispose()
            _strExtension = Nothing
            dsData = Nothing
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:UnsetCountry)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Public Shared Function AutoID() As String
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, strAutoID As String
                    oCommand.CommandText = "SELECT ID=ISNULL(MAX(CONVERT(INT,(RIGHT(IDCountry,8))))+1,$1) " & _
                                           "FROM HRCountry " & _
                                           "WHERE LEFT(IDCountry,2) = N'#_'"
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataReader = oCommand.ExecuteReader()
                    oDataReader.Read()
                    strAutoID = Left("#_00000000", Len("#_00000000") - oDataReader.Item(0).ToString.Length) & oDataReader.Item(0)
                    oDataReader.Close() : oDataReader = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return strAutoID
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:AutoID)", ex.Message.ToString, IconType.Message)
        End Try
        Return "ERROR"
    End Function
    Public Shared Function TotalRow() As Integer
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, intTotalRow As Integer
                    oCommand.CommandText = "SELECT COUNT(IDCountry) as Totalrow " & _
                                           "FROM HRCountry "
                    oCommand.Connection = oConnect.OpenConnectionHR()
                    oDataReader = oCommand.ExecuteReader()
                    oDataReader.Read()
                    intTotalRow = oDataReader.Item(0)
                    oDataReader.Close() : oDataReader = Nothing
                    oCommand.Dispose() : oCommand = Nothing
                    oConnect.CloseConnection() : oConnect = Nothing
                    Return intTotalRow
                Case classDatabase.TypeName.Oracle
                    'To do something
                Case classDatabase.TypeName.MSAccess
                    'To do something
            End Select
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCountryDB:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
        Return 0
    End Function
#End Region
End Class
