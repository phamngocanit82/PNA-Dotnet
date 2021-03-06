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
Public Class clsHRCommendDisciplineDB
    Private strIDCommendDiscipline As String
    Private strCommendDisciplineName As String
    Private strDescription As String
    Private dsData As DataSet
#Region "Properties"
    Public Property IDCommendDiscipline() As String
        Get
            Return strIDCommendDiscipline
        End Get
        Set(ByVal value As String)
            strIDCommendDiscipline = value
        End Set
    End Property
    Public Property CommendDisciplineName() As String
        Get
            Return strCommendDisciplineName
        End Get
        Set(ByVal value As String)
            strCommendDisciplineName = value
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
#End Region
#Region "SQL"
    Public Shared Function IsExist(ByVal strIDCommendDiscipline As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    oCommand.CommandText = "SELECT TOP 1 IDCommendDiscipline " & _
                                           "FROM HRCommendDiscipline " & _
                                           "WHERE IDCommendDiscipline=N'" & strIDCommendDiscipline & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:IsExist)", ex.Message.ToString, IconType.IsExist)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "INSERT INTO HRCommendDiscipline " & _
                                           "VALUES(" & TotalRow() + 1 & ",N'" & strIDCommendDiscipline & "',N'" & strCommendDisciplineName & _
                                                   "',N'" & strDescription & "')"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:Add)", ex.Message.ToString, IconType.Add)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDCommendDiscipline As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "DELETE FROM HRCommendDiscipline " & _
                                           "WHERE IDCommendDiscipline=N'" & strIDCommendDiscipline & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:Delete)", ex.Message.ToString, IconType.Delete)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "UPDATE HRCommendDiscipline " & _
                                           "SET CommendDisciplineName=N'" & strCommendDisciplineName & "',Description=N'" & strDescription & "' " & _
                                           "WHERE IDCommendDiscipline=N'" & IDCommendDiscipline & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:Update)", ex.Message.ToString, IconType.Update)
        End Try
    End Function
    Public Function QueryTable(Optional ByVal strSelect As String = "IDCommendDiscipline,CommendDisciplineName,Description", _
                               Optional ByVal intTop As Integer = 1, _
                               Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRCommendDiscipline " & _
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:QueryTable)", ex.Message.ToString, IconType.Query)
        End Try
        Return Nothing
    End Function
    Public Function Search(Optional ByVal strSelect As String = "IDCommendDiscipline,CommendDisciplineName,Description", _
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
                                               "FROM HRCommendDiscipline " & _
                                               "WHERE " & strField & " Like N'%" & strValue & "%' " & _
                                               "ORDER BY IDCommendDiscipline ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:Search)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchCondition(Optional ByVal strSelect As String = "IDCommendDiscipline,CommendDisciplineName,Description", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strWhere As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                           "FROM HRCommendDiscipline " & _
                                           "WHERE " & strWhere & " " & _
                                           "ORDER BY IDCommendDiscipline ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:SearchCondition)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchQuery(Optional ByVal strSelect As String = "IDCommendDiscipline,CommendDisciplineName,Description", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRCommendDiscipline " & _
                                               "ORDER BY IDCommendDiscipline ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:SearchQuery)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDCommendDiscipline As String, Optional ByVal strSelect As String = "IDCommendDiscipline,CommendDisciplineName,Description", _
                             Optional ByVal strField As String = "IDCommendDiscipline,CommendDisciplineName,Description") As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT " & strSelect & " " & _
                                           "FROM HRCommendDiscipline " & _
                                           "WHERE IDCommendDiscipline=N'" & strIDCommendDiscipline & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:GetInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Private Sub setInfor(ByVal oDataReader As SqlDataReader, ByVal strField As String)
        Try
            Dim s() As String = vb.Split(strField, ",")
            Dim i As Integer = 0
            For i = 0 To s.Length - 1
                Select Case s(i)
                    Case "IDCommendDiscipline"
                        strIDCommendDiscipline = oDataReader.Item(s(i)).ToString
                    Case "CommendDisciplineName"
                        strCommendDisciplineName = oDataReader.Item(s(i)).ToString
                    Case "Description"
                        strDescription = oDataReader.Item(s(i)).ToString
                End Select
            Next
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:setInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Function UnsetCommendDiscipline() As Boolean
        Try
            strIDCommendDiscipline = Nothing
            strCommendDisciplineName = Nothing
            strDescription = Nothing
            If Not dsData Is Nothing Then dsData.Dispose()
            dsData = Nothing
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:UnsetCommendDiscipline)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Public Shared Function AutoID() As String
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, strAutoID As String
                    oCommand.CommandText = "SELECT ID=ISNULL(MAX(CONVERT(INT,(RIGHT(IDCommendDiscipline,8))))+1,$1) " & _
                                           "FROM HRCommendDiscipline " & _
                                           "WHERE LEFT(IDCommendDiscipline,2) = N'#_'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:AutoID)", ex.Message.ToString, IconType.Message)
        End Try
        Return "ERROR"
    End Function
    Public Shared Function TotalRow() As Integer
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, intTotalRow As Integer
                    oCommand.CommandText = "SELECT COUNT(IDCommendDiscipline) as Totalrow " & _
                                           "FROM HRCommendDiscipline "
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRCommendDisciplineDB:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
        Return 0
    End Function
#End Region
End Class
