'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports System.Data.SqlClient
Public Class classDatabase
    Public Enum TypeName
        MSSQLServer = 0
        Oracle = 1
        MSAccess = 2
    End Enum
    Public Shared Function DatabaseType() As TypeName
        'To do something
        Return TypeName.MSSQLServer
    End Function
End Class
Public Class clsSQLServerDatabase
    Public Enum DatabaseName
        DB_ACC = 0
        DB_DOC = 1
        DB_HR = 2
        DB_PU = 3
        DB_TO = 4
        DB_UL = 5
        DB_WH = 6
        DB_WEB = 7
        DB_HOTEL = 8
    End Enum
    Private sqlConnection As SqlConnection
    Private strServerName As String, strUserName As String, strPassWord As String, strPrefixDatabase As String
    Private Sub databaseInfor()
        'To do something
        strServerName = "ANHONE023"
        strUserName = "sa"
        strPassWord = "phamngocan"
        strPrefixDatabase = "PNA"
    End Sub
    Public Function OpenConnection(ByVal Value As DatabaseName)
        Try
            Dim strConnectionString As String = ""
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            Select Case Value
                Case DatabaseName.DB_ACC
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "ACC" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_DOC
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "DOC" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_HR
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "HR" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_PU
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "PU" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_TO
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "TO" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_UL
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "UL" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_WH
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "WH" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
                Case DatabaseName.DB_WEB
                    strConnectionString = "Initial Catalog='" & PrefixDatabase() & "WEB" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            End Select
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnection error!!")
        End Try
    End Function
    Public Function OpenConnectionACC()
        Try
            Dim strConnectionString As String = ""
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "ACC" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionACC error!!")
        End Try
    End Function
    Public Function OpenConnectionDOC()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "DOC" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionDOC error!!")
        End Try
        sqlConnection = Nothing
        Return Nothing
    End Function
    Public Function OpenConnectionHR()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "HR" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionHR error!!")
        End Try
    End Function
    Public Function OpenConnectionPU()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "PU" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionPU error!!")
        End Try
    End Function
    Public Function OpenConnectionTO()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "TO" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionTO error!!")
        End Try
    End Function
    Public Function OpenConnectionUL()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "UL" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionUL error!!")
        End Try
    End Function
    Public Function OpenConnectionWH()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "WH" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionWH error!!")
        End Try
    End Function
    Public Function OpenConnectionWEB()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "WEB" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionWEB error!!")
        End Try
    End Function
    Public Function OpenConnectionHOTEL()
        Dim strConnectionString As String = ""
        Try
            If sqlConnection Is Nothing Then sqlConnection = New SqlConnection
            databaseInfor()
            strConnectionString = "Initial Catalog='" & PrefixDatabase() & "HOTEL" & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord & "';"
            sqlConnection.ConnectionString = strConnectionString
            sqlConnection.Open()
            Return sqlConnection
        Catch e As Exception
            Throw New Exception("clsSQLDatabase: OpenConnectionHOTEL error!!")
        End Try
    End Function
    Public Sub CloseConnection()
        Try
            sqlConnection.Close()
            sqlConnection = Nothing
        Catch ex As Exception
            Throw New Exception("clsSQLDatabase: CloseConnection error!!")
        End Try
    End Sub
    Public Shared Function PrefixDatabase() As String
        Return "PNA"
    End Function
    Public Shared Function GetDatabaseName(ByVal enumDatabaseName As DatabaseName) As String
        Select Case enumDatabaseName
            Case DatabaseName.DB_ACC
                Return PrefixDatabase() & "ACC.dbo."
            Case DatabaseName.DB_DOC
                Return PrefixDatabase() & "DOC.dbo."
            Case DatabaseName.DB_HR
                Return PrefixDatabase() & "HR.dbo."
            Case DatabaseName.DB_PU
                Return PrefixDatabase() & "PU.dbo."
            Case DatabaseName.DB_TO
                Return PrefixDatabase() & "TO.dbo."
            Case DatabaseName.DB_UL
                Return PrefixDatabase() & "UL.dbo."
            Case DatabaseName.DB_WEB
                Return PrefixDatabase() & "WEB.dbo."
            Case DatabaseName.DB_WH
                Return PrefixDatabase() & "WH.dbo."
            Case DatabaseName.DB_HOTEL
                Return PrefixDatabase() & "HOTEL.dbo."
        End Select
        Return ""
    End Function
End Class
Public Class clsOracleDatabase

End Class
Public Class clsAccessDatabase

End Class
