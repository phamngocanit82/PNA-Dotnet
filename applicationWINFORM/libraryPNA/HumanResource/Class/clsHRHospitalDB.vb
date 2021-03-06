'*************************************************************'***'
'Author   : An Pham Ngoc                                          ' 
'Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com      '
'Web      : Developing : PHP(Framework Codeigniter-MVC) and ASPNet'
'Gender   : Male                                                  '
'Age      : 26                                                    ' 
'National : VietNam                                               '
'City     : HCM                                                   '
'District : 7                                                     '
'*************************************************************'***'
Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Drawing
Imports libraryPNA.clsSystem
Imports libraryPNA.clsError
Imports libraryPNA.clsSQLServerDatabase
Public Class clsHRHospitalDB
    Private strIDCountry As String
    Private strCountryName As String
    Private strIDCity As String
    Private strCityName As String
    Private strIDDistrict As String
    Private strDistrictName As String
    Private strIDHospital As String
    Private strHospitalName As String
    Private strAddress As String
    Private strTelephone As String
    Private strMobilePhone As String
    Private strFaxes As String
    Private strWebPage As String
    Private strEmail As String
    Private strDirectorName As String
    Private strChiefAccountant As String
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
    Public Property IDCity() As String
        Get
            Return strIDCity
        End Get
        Set(ByVal value As String)
            strIDCity = value
        End Set
    End Property
    Public Property CityName() As String
        Get
            Return strCityName
        End Get
        Set(ByVal value As String)
            strCityName = value
        End Set
    End Property
    Public Property IDDistrict() As String
        Get
            Return strIDDistrict
        End Get
        Set(ByVal value As String)
            strIDDistrict = value
        End Set
    End Property
    Public Property DistrictName() As String
        Get
            Return strDistrictName
        End Get
        Set(ByVal value As String)
            strDistrictName = value
        End Set
    End Property
    Public Property IDHospital() As String
        Get
            Return strIDHospital
        End Get
        Set(ByVal value As String)
            strIDHospital = value
        End Set
    End Property
    Public Property HospitalName() As String
        Get
            Return strHospitalName
        End Get
        Set(ByVal value As String)
            strHospitalName = value
        End Set
    End Property
    Public Property Address() As String
        Get
            Return strAddress
        End Get
        Set(ByVal value As String)
            strAddress = value
        End Set
    End Property
    Public Property Telephone() As String
        Get
            Return strTelephone
        End Get
        Set(ByVal value As String)
            strTelephone = value
        End Set
    End Property
    Public Property MobilePhone() As String
        Get
            Return strMobilePhone
        End Get
        Set(ByVal value As String)
            strMobilePhone = value
        End Set
    End Property
    Public Property Faxes() As String
        Get
            Return strFaxes
        End Get
        Set(ByVal value As String)
            strFaxes = value
        End Set
    End Property
    Public Property WebPage() As String
        Get
            Return strWebPage
        End Get
        Set(ByVal value As String)
            strWebPage = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property
    Public Property DirectorName() As String
        Get
            Return strDirectorName
        End Get
        Set(ByVal value As String)
            strDirectorName = value
        End Set
    End Property
    Public Property ChiefAccountant() As String
        Get
            Return strChiefAccountant
        End Get
        Set(ByVal value As String)
            strChiefAccountant = value
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
    Public Shared Function IsExist(ByVal strIDHospital As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    oCommand.CommandText = "SELECT TOP 1 IDHospital " & _
                                           "FROM HRHospital " & _
                                           "WHERE IDHospital=N'" & strIDHospital & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:IsExist)", ex.Message.ToString, IconType.IsExist)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    If _picPicture Is Nothing Then
                        oCommand.CommandText = "INSERT INTO HRHospital " & _
                                               "VALUES(" & TotalRow() + 1 & ",N'" & strIDCountry & "',N'" & strIDCity & _
                                                       "',N'" & strIDDistrict & "',N'" & strIDHospital & _
                                                       "',N'" & strHospitalName & "',N'" & strAddress & _
                                                       "',N'" & strTelephone & "',N'" & strMobilePhone & _
                                                       "',N'" & strFaxes & "',N'" & strWebPage & _
                                                       "',N'" & strEmail & "',N'" & strDirectorName & _
                                                       "',N'" & strChiefAccountant & "',N'" & strDescription & _
                                                       "',null,N'" & _strExtension & "')"
                    Else
                        oCommand.CommandText = "INSERT INTO HRHospital " & _
                                               "VALUES(" & TotalRow() + 1 & ",N'" & strIDCountry & "',N'" & strIDCity & _
                                                       "',N'" & strIDDistrict & "',N'" & strIDHospital & _
                                                       "',N'" & strHospitalName & "',N'" & strAddress & _
                                                       "',N'" & strTelephone & "',N'" & strMobilePhone & _
                                                       "',N'" & strFaxes & "',N'" & strWebPage & _
                                                       "',N'" & strEmail & "',N'" & strDirectorName & _
                                                       "',N'" & strChiefAccountant & "',N'" & strDescription & _
                                                       "',@picPicture,N'" & _strExtension & "')"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:Add)", ex.Message.ToString, IconType.Add)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDHospital As String) As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    oCommand.CommandText = "DELETE FROM HRHospital " & _
                                           "WHERE IDHospital=N'" & strIDHospital & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:Delete)", ex.Message.ToString, IconType.Delete)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand
                    If _picPicture Is Nothing Then
                        oCommand.CommandText = "UPDATE HRHospital " & _
                                               "SET IDCountry=N'" & strIDCountry & "',IDCity=N'" & strIDCity & _
                                                    "',IDDistrict=N'" & strIDDistrict & "',HospitalName=N'" & strHospitalName & _
                                                    "',Address=N'" & strAddress & "',Telephone=N'" & strTelephone & _
                                                    "',MobilePhone=N'" & strMobilePhone & "',Faxes=N'" & strFaxes & _
                                                    "',WebPage=N'" & strWebPage & "',Email=N'" & strEmail & _
                                                    "',DirectorName=N'" & strDirectorName & "',ChiefAccountant=N'" & strChiefAccountant & _
                                                    "',Description=N'" & strDescription & "',CPicture=null,Extension=N'" & _
                                                    _strExtension & "' " & _
                                               "WHERE IDHospital=N'" & IDHospital & "'"
                    Else
                        oCommand.CommandText = "UPDATE HRHospital " & _
                                            "SET IDCountry=N'" & strIDCountry & "',IDCity=N'" & strIDCity & _
                                                 "',IDDistrict=N'" & strIDDistrict & "',HospitalName=N'" & strHospitalName & _
                                                 "',Address=N'" & strAddress & "',Telephone=N'" & strTelephone & _
                                                 "',MobilePhone=N'" & strMobilePhone & "',Faxes=N'" & strFaxes & _
                                                 "',WebPage=N'" & strWebPage & "',Email=N'" & strEmail & _
                                                 "',DirectorName=N'" & strDirectorName & "',ChiefAccountant=N'" & strChiefAccountant & _
                                                 "',Description=N'" & strDescription & "',CPicture=@picPicture,Extension=N'" & _
                                                 _strExtension & "' " & _
                                            "WHERE IDHospital=N'" & IDHospital & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:Update)", ex.Message.ToString, IconType.Update)
        End Try
    End Function
    Public Function QueryTable(Optional ByVal strSelect As String = "a.IDHospital,a.HospitalName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                    "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description," & _
                                                                    "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName", _
                               Optional ByVal intTop As Integer = 1, _
                               Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRHospital a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                              "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                              "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                               "ORDER BY a.Num DESC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:QueryTable)", ex.Message.ToString, IconType.Query)
        End Try
        Return Nothing
    End Function
    Public Function Search(Optional ByVal strSelect As String = "a.IDHospital,a.HospitalName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description," & _
                                                                "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName", _
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
                                               "FROM HRHospital a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                              "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                              "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                               "WHERE " & strField & " Like N'%" & strValue & "%' " & _
                                               "ORDER BY a.IDHospital ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:Search)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchCondition(Optional ByVal strSelect As String = "a.IDHospital,a.HospitalName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                         "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description," & _
                                                                         "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName", _
                                    Optional ByVal intTop As Integer = 1, _
                                    Optional ByVal strWhere As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                           "FROM HRHospital a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                          "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                          "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                           "WHERE " & strWhere & " " & _
                                           "ORDER BY a.IDHospital ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:SearchCondition)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function SearchQuery(Optional ByVal strSelect As String = "a.IDHospital,a.HospitalName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                     "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description," & _
                                                                     "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName", _
                                Optional ByVal intTop As Integer = 1, _
                                Optional ByVal strQuery As String = "", Optional ByVal indexTable As Integer = 0) As DataTable
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
                    If dsData Is Nothing Then dsData = New DataSet
                    If strQuery = "" Then
                        oCommand.CommandText = "SELECT TOP " & intTop & " " & strSelect & " " & _
                                               "FROM HRHospital a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                              "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                              "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                               "ORDER BY a.IDHospital ASC"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:SearchQuery)", ex.Message.ToString, IconType.Search)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDHospital As String, _
                             Optional ByVal strSelect As String = "a.IDHospital,a.HospitalName,a.Address,a.Telephone,a.MobilePhone," & _
                                                                  "a.Faxes,a.WebPage,a.Email,a.DirectorName,a.ChiefAccountant,a.Description,a.CPicture,a.Extension," & _
                                                                  "b.IDCountry,b.CountryName,a.IDCity,c.CityName,d.IDDistrict,d.DistrictName", _
                             Optional ByVal strField As String = "IDHospital,HospitalName,Address,Telephone,MobilePhone," & _
                                                                 "Faxes,WebPage,Email,DirectorName,ChiefAccountant,Description,CPicture,Extension," & _
                                                                 "IDCountry,CountryName,IDCity,CityName,IDDistrict,DistrictName") As Boolean
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader
                    If dsData Is Nothing Then dsData = New DataSet
                    oCommand.CommandText = "SELECT " & strSelect & " " & _
                                            "FROM HRHospital a LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCountry b ON b.IDCountry=a.IDCountry " & _
                                                           "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRCity c ON c.IDCity=a.IDCity " & _
                                                           "LEFT OUTER JOIN " & GetDatabaseName(DatabaseName.DB_HR) & "HRDistrict d ON d.IDDistrict=a.IDDistrict " & _
                                           "WHERE a.IDHospital=N'" & strIDHospital & "'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:GetInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Private Sub setInfor(ByVal oDataReader As SqlDataReader, ByVal strField As String)
        Try
            Dim s() As String = vb.Split(strField, ",")
            Dim i As Integer = 0
            For i = 0 To s.Length - 1
                Select Case s(i)
                    Case "IDHospital"
                        strIDHospital = oDataReader.Item(s(i)).ToString
                    Case "HospitalName"
                        strHospitalName = oDataReader.Item(s(i)).ToString
                    Case "Address"
                        strAddress = oDataReader.Item(s(i)).ToString
                    Case "Telephone"
                        strTelephone = oDataReader.Item(s(i)).ToString
                    Case "MobilePhone"
                        strMobilePhone = oDataReader.Item(s(i)).ToString
                    Case "Faxes"
                        strFaxes = oDataReader.Item(s(i)).ToString
                    Case "WebPage"
                        strWebPage = oDataReader.Item(s(i)).ToString
                    Case "Email"
                        strEmail = oDataReader.Item(s(i)).ToString
                    Case "DirectorName"
                        strDirectorName = oDataReader.Item(s(i)).ToString
                    Case "ChiefAccountant"
                        strChiefAccountant = oDataReader.Item(s(i)).ToString
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
                    Case "IDCountry"
                        strIDCountry = oDataReader.Item(s(i)).ToString
                    Case "CountryName"
                        strCountryName = oDataReader.Item(s(i)).ToString
                    Case "IDCity"
                        strIDCity = oDataReader.Item(s(i)).ToString
                    Case "CityName"
                        strCityName = oDataReader.Item(s(i)).ToString
                    Case "IDDistrict"
                        strIDDistrict = oDataReader.Item(s(i)).ToString
                    Case "DistrictName"
                        strDistrictName = oDataReader.Item(s(i)).ToString
                End Select
            Next
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:setInfor)", ex.Message.ToString, IconType.Message)
        End Try
    End Sub
    Public Function UnsetHospital() As Boolean
        Try
            strIDCountry = Nothing
            strCountryName = Nothing
            strIDCity = Nothing
            strCityName = Nothing
            strIDDistrict = Nothing
            strDistrictName = Nothing
            strIDHospital = Nothing
            strHospitalName = Nothing
            strAddress = Nothing
            strTelephone = Nothing
            strMobilePhone = Nothing
            strFaxes = Nothing
            strWebPage = Nothing
            strEmail = Nothing
            strDirectorName = Nothing
            strChiefAccountant = Nothing
            strDescription = Nothing
            If Not _picPicture Is Nothing Then _picPicture.Dispose()
            _picPicture = Nothing
            If Not dsData Is Nothing Then dsData.Dispose()
            _strExtension = Nothing
            dsData = Nothing
        Catch ex As Exception
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:UnsetHospital)", ex.Message.ToString, IconType.Message)
        End Try
    End Function
    Public Shared Function AutoID() As String
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, strAutoID As String
                    oCommand.CommandText = "SELECT ID=ISNULL(MAX(CONVERT(INT,(RIGHT(IDHospital,8))))+1,$1) " & _
                                           "FROM HRHospital " & _
                                           "WHERE LEFT(IDHospital,2) = N'#_'"
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:AutoID)", ex.Message.ToString, IconType.Message)
        End Try
        Return "ERROR"
    End Function
    Public Shared Function TotalRow() As Integer
        Try
            Select Case classDatabase.DatabaseType
                Case classDatabase.TypeName.MSSQLServer
                    Dim oConnect As New clsSQLServerDatabase, oCommand As New SqlCommand, oDataReader As SqlDataReader, intTotalRow As Integer
                    oCommand.CommandText = "SELECT COUNT(IDHospital) as Totalrow " & _
                                           "FROM HRHospital "
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
            ShowError(Nothing, GetLang("Error.xml", 0, , DirLang.SYS) & " (clsHRHospitalDB:TotalRow)", ex.Message.ToString, IconType.Message)
        End Try
        Return 0
    End Function
#End Region
End Class
