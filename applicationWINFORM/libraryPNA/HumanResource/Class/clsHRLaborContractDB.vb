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
Public Class clsHRLaborContractDB
    Private strIDLaborContract As String
    Private strLaborContractName As String
    Private strDescription As String
    Private dsData As DataSet
#Region "Properties"
    Public Property IDLaborContract() As String
        Get
            Return strIDLaborContract
        End Get
        Set(ByVal value As String)
            strIDLaborContract = value
        End Set
    End Property
    Public Property LaborContractName() As String
        Get
            Return strLaborContractName
        End Get
        Set(ByVal value As String)
            strLaborContractName = value
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
    Public Shared Function IsExist(ByVal strIDLaborContract As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    oCommand.CommandText = "SELECT TOP 1 IDLaborContract " & _
                                           "FROM HRLaborContract " & _
                                           "WHERE IDLaborContract=N'" & strIDLaborContract & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:IsExist)", ex.Message.ToString, IconType.IsExist)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "INSERT INTO HRLaborContract " & _
                                           "VALUES(" & TotalRow() + 1 & ",N'" & strIDLaborContract & "',N'" & strLaborContractName & _
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:Add)", ex.Message.ToString, IconType.Add)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDLaborContract As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "DELETE FROM HRLaborContract " & _
                                           "WHERE IDLaborContract=N'" & strIDLaborContract & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:Delete)", ex.Message.ToString, IconType.Delete)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "UPDATE HRLaborContract " & _
                                           "SET LaborContractName=N'" & strLaborContractName & "',Description=N'" & strDescription & "' " & _
                                           "WHERE IDLaborContract=N'" & IDLaborContract & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:Update)", ex.Message.ToString, IconType.Update)
        End Try
    End Function
    Public Function QueryTable(Optional ByVal strSelect As String = "IDLaborContract,LaborContractName,Description", _
                               Optional ByVal intTop As Integer = 1, _
                               Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRLaborContract " & _
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:QueryTable)", ex.Message.ToString, IconType.Query)
        End Try
        Return Nothing
    End Function
    Public Function Search(Optional ByVal strSelect As String = "IDLaborContract,LaborContractName,Description", _
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
                                               "FROM HRLaborContract " & _
                                               "WHERE " & strField & " Like N'%" & strValue & "%' " & _
                                               "ORDER BY IDLaborContract ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:Search)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchCondition(Optional ByVal strSelect As String = "IDLaborContract,LaborContractName,Description", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strWhere As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                           "FROM HRLaborContract " & _
                                           "WHERE " & strWhere & " " & _
                                           "ORDER BY IDLaborContract ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:SearchCondition)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchQuery(Optional ByVal strSelect As String = "IDLaborContract,LaborContractName,Description", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRLaborContract " & _
                                               "ORDER BY IDLaborContract ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:SearchQuery)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDLaborContract As String, Optional ByVal strSelect As String = "IDLaborContract,LaborContractName,Description", _
                             Optional ByVal strField As String = "IDLaborContract,LaborContractName,Description") As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT " & strSelect & " " & _
                                           "FROM HRLaborContract " & _
                                           "WHERE IDLaborContract=N'" & strIDLaborContract & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:GetInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Private Sub setInfor(ByVal oDataReader As SqlDataReader, ByVal strField As String)
        Try
            Dim s() As String = vb.Split(strField, ",")
            Dim i As Integer = 0
            For i = 0 To s.Length - 1
                Select Case s(i)
                    Case "IDLaborContract"
                        strIDLaborContract = oDataReader.Item(s(i)).ToString
                    Case "LaborContractName"
                        strLaborContractName = oDataReader.Item(s(i)).ToString
                    Case "Description"
                        strDescription = oDataReader.Item(s(i)).ToString
                End Select
            Next
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:setInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Function UnsetLaborContract() As Boolean
        Try
            strIDLaborContract = Nothing
            strLaborContractName = Nothing
            strDescription = Nothing
            If Not dsData Is Nothing Then dsData.Dispose()
            dsData = Nothing
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:UnsetLaborContract)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Public Shared Function AutoID() As String
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, strAutoID As String
                    oCommand.CommandText = "SELECT ID=ISNULL(MAX(CONVERT(INT,(RIGHT(IDLaborContract,8))))+1,$1) " & _
                                           "FROM HRLaborContract " & _
                                           "WHERE LEFT(IDLaborContract,2) = N'#_'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:AutoID)", ex.Message.ToString, IconType.Message)
        End Try
        Return "ERROR"
    End Function
    Public Shared Function TotalRow() As Integer
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, intTotalRow As Integer
                    oCommand.CommandText = "SELECT COUNT(IDLaborContract) as Totalrow " & _
                                           "FROM HRLaborContract "
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRLaborContractDB:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
        Return 0
    End Function
#End Region
End Class
