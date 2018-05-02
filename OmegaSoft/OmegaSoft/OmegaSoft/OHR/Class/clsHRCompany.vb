Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHRCompany
#Region "Variables"
    Private _strIDCountry As String
    Private _strIDCompany As String
    Private _strCName As String
    Private _bolBranch As Boolean
    Private _strDirector As String
    Private _strTaxCode As String
    Private _strBusiness As String
    Private _strPhone As String
    Private _strFax As String
    Private _strEmail As String
    Private _strWebSite As String
    Private _strAddress As String
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
    Public Property IDCompany() As String
        Get
            Return _strIDCompany
        End Get
        Set(ByVal value As String)
            _strIDCompany = value
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
    Public Property Branch() As Boolean
        Get
            Return _bolBranch
        End Get
        Set(ByVal value As Boolean)
            _bolBranch = value
        End Set
    End Property
    Public Property Director() As String
        Get
            Return _strDirector
        End Get
        Set(ByVal value As String)
            _strDirector = value
        End Set
    End Property
    Public Property TaxCode() As String
        Get
            Return _strTaxCode
        End Get
        Set(ByVal value As String)
            _strTaxCode = value
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
    Public Shared Function IsExistDepartment(ByVal strIDCompany As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDCompany FROM HRDepartment WHERE IDCompany=N'" & strIDCompany.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.IsExistDepartment)", , True)
        End Try
    End Function
    Public Shared Function IsExist(ByVal strIDCompany As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDCompany FROM HRCompany WHERE IDCompany=N'" & strIDCompany.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            If _picPicture Is Nothing Then
                oCommand.CommandText = "INSERT INTO HRCompany " & _
                                       "VALUES(N'" & _strIDCountry & "',N'" & _strIDCompany & "',N'" & _strCName & _
                                       "'," & CInt(_bolBranch) & ",N'" & _strDirector & "',N'" & _strTaxCode & _
                                       "',N'" & _strBusiness & "',N'" & _strPhone & "',N'" & _strFax & _
                                       "',N'" & _strEmail & "',N'" & _strWebSite & "',N'" & _strAddress & "',null)"
            Else
                oCommand.CommandText = "INSERT INTO HRCompany " & _
                                       "VALUES(N'" & _strIDCountry & "',N'" & _strIDCompany & "',N'" & _strCName & _
                                       "'," & CInt(_bolBranch) & ",N'" & _strDirector & "',N'" & _strTaxCode & _
                                       "',N'" & _strBusiness & "',N'" & _strPhone & "',N'" & _strFax & _
                                       "',N'" & _strEmail & "',N'" & _strWebSite & "',N'" & _strAddress & "',@picPicture)"
                oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                oCommand.Parameters("@picPicture").Value = ImageToByte(_picPicture)
            End If
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDCompany As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HRCompany WHERE IDCompany=N'" & strIDCompany.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            If _picPicture Is Nothing Then
                oCommand.CommandText = "UPDATE HRCompany SET " & _
                                       "IDCountry=N'" & _strIDCountry & "',CName=N'" & _strCName & "',Branch=" & CInt(_bolBranch) & _
                                       ",Director=N'" & _strDirector & "',TaxCode=N'" & _strTaxCode & "',Business=N'" & _strBusiness & _
                                       "',Phone=N'" & _strPhone & "',Fax=N'" & _strFax & "',Email=N'" & _strEmail & _
                                       "',WebSite=N'" & _strWebSite & "',Address=N'" & _strAddress & "',Picture=null " & _
                                       "WHERE IDCompany=N'" & IDCompany & "'"
            Else
                oCommand.CommandText = "UPDATE HRCompany SET " & _
                                       "IDCountry=N'" & _strIDCountry & "',CName=N'" & _strCName & "',Branch=" & CInt(_bolBranch) & _
                                       ",Director=N'" & _strDirector & "',TaxCode=N'" & _strTaxCode & "',Business=N'" & _strBusiness & _
                                       "',Phone=N'" & _strPhone & "',Fax=N'" & _strFax & "',Email=N'" & _strEmail & _
                                       "',WebSite=N'" & _strWebSite & "',Address=N'" & _strAddress & "',Picture=@picPicture " & _
                                       "WHERE IDCompany=N'" & IDCompany & "'"
                oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                oCommand.Parameters("@picPicture").Value = ImageToByte(_picPicture)
            End If
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HRCompany ORDER BY IDCompany ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            If strField = "HRCon.CName" Then
                oCommand.CommandText = "SELECT HRCom.* " & _
                                       "FROM HRCountry HRCon,HRCompany HRCom " & _
                                       "WHERE HRCom.IDCountry = HRCon.IDCountry AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                       "ORDER BY HRCom.IDCompany ASC"
            Else
                oCommand.CommandText = "SELECT * FROM HRCompany " & _
                                       "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                       "ORDER BY IDCompany ASC"
            End If
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDCompany As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HRCompany WHERE IDCompany=N'" & strIDCompany.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.GetInfor)", , True)
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
                _strIDCompany = oDataReader.GetString(1)
            Catch ex As Exception
                _strIDCompany = ""
            End Try
            Try
                _strCName = oDataReader.GetString(2)
            Catch ex As Exception
                _strCName = ""
            End Try
            Try
                _bolBranch = oDataReader.GetBoolean(3)
            Catch ex As Exception
                _bolBranch = False
            End Try
            Try
                _strDirector = oDataReader.GetString(4)
            Catch ex As Exception
                _strDirector = ""
            End Try
            Try
                _strTaxCode = oDataReader.GetString(5)
            Catch ex As Exception
                _strTaxCode = ""
            End Try
            Try
                _strBusiness = oDataReader.GetString(6)
            Catch ex As Exception
                _strBusiness = ""
            End Try
            Try
                _strPhone = oDataReader.GetString(7)
            Catch ex As Exception
                _strPhone = ""
            End Try
            Try
                _strFax = oDataReader.GetString(8)
            Catch ex As Exception
                _strFax = ""
            End Try
            Try
                _strEmail = oDataReader.GetString(9)
            Catch ex As Exception
                _strEmail = ""
            End Try
            Try
                _strWebSite = oDataReader.GetString(10)
            Catch ex As Exception
                _strWebSite = ""
            End Try
            Try
                _strAddress = oDataReader.GetString(11)
            Catch ex As Exception
                _strAddress = ""
            End Try
            Try
                _picPicture = ByteToImage(oDataReader.GetValue(12))
            Catch ex As Exception
                _picPicture = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedCompany() As Boolean
        Try
            _strIDCountry = Nothing
            _strIDCompany = Nothing
            _strCName = Nothing
            _bolBranch = Nothing
            _strDirector = Nothing
            _strTaxCode = Nothing
            _strBusiness = Nothing
            _strPhone = Nothing
            _strFax = Nothing
            _strEmail = Nothing
            _strWebSite = Nothing
            _strAddress = Nothing
            If Not _picPicture Is Nothing Then _picPicture.Dispose()
            _picPicture = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHRCompany.DisposedCompany)", , True)
        End Try
    End Function
#End Region
End Class
