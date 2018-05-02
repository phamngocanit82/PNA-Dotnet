Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Public Class clsConnection
    Private _sqlConnection As SqlConnection
#Region "Methods"
    Public Function GetConnection(Optional ByVal strDataBaseName As String = "Omega_Soft")
        Dim strServerName As String, strUserName As String, strPassWord As String, strConnectionString As String
        Try
            If _sqlConnection Is Nothing Then _sqlConnection = New SqlConnection
            strServerName = "10.0.0.4"
            strUserName = "sa"
            strPassWord = "phamngocan"
            strConnectionString = "Initial Catalog='" & strDataBaseName & "';Data Source='" & strServerName & "';User ID='" & strUserName & "' ;Password='" & strPassWord.Trim & "';"
            _sqlConnection.ConnectionString = strConnectionString
            _sqlConnection.Open()
            Return _sqlConnection
        Catch e As Exception
            Throw New Exception("clsConnection: GetConnection error!!")
        End Try
    End Function
    Public Sub CloseConnection()
        Try
            _sqlConnection.Close()
            _sqlConnection = Nothing
        Catch ex As Exception
            Throw New Exception("clsConnection: CloseConnection error!!")
        End Try
    End Sub
#End Region
End Class
