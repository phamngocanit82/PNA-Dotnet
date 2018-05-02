Imports System.Data.SqlClient
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class clsHREmployee
#Region "Variables"
    Private _strIDJobTitle As String
    Private _strIDLevel As String
    Private _strIDEmployee As String
    Private _strFirstName As String
    Private _strLastName As String
    Private _bolGender As Boolean
    Private _strBirthDate As String
    Private _strHireDate As String
    Private _strHomePhone As String
    Private _strMobilePhone As String
    Private _strEmail As String
    Private _strTempResident As String
    Private _strResident As String
    Private _picPicture As Bitmap
    Private _dsData As DataSet
#End Region
#Region "Properties"
    Public Property IDJobTitle() As String
        Get
            Return _strIDJobTitle
        End Get
        Set(ByVal value As String)
            _strIDJobTitle = value
        End Set
    End Property
    Public Property IDLevel() As String
        Get
            Return _strIDLevel
        End Get
        Set(ByVal value As String)
            _strIDLevel = value
        End Set
    End Property
    Public Property IDEmployee() As String
        Get
            Return _strIDEmployee
        End Get
        Set(ByVal value As String)
            _strIDEmployee = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _strFirstName
        End Get
        Set(ByVal value As String)
            _strFirstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return _strLastName
        End Get
        Set(ByVal value As String)
            _strLastName = value
        End Set
    End Property
    Public Property Gender() As Boolean
        Get
            Return _bolGender
        End Get
        Set(ByVal value As Boolean)
            _bolGender = value
        End Set
    End Property
    Public Property BirthDate() As String
        Get
            Return _strBirthDate
        End Get
        Set(ByVal value As String)
            _strBirthDate = value
        End Set
    End Property
    Public Property HireDate() As String
        Get
            Return _strHireDate
        End Get
        Set(ByVal value As String)
            _strHireDate = value
        End Set
    End Property
    Public Property HomePhone() As String
        Get
            Return _strHomePhone
        End Get
        Set(ByVal value As String)
            _strHomePhone = value
        End Set
    End Property
    Public Property MobilePhone() As String
        Get
            Return _strMobilePhone
        End Get
        Set(ByVal value As String)
            _strMobilePhone = value
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
    Public Property TempResident() As String
        Get
            Return _strTempResident
        End Get
        Set(ByVal value As String)
            _strTempResident = value
        End Set
    End Property
    Public Property Resident() As String
        Get
            Return _strResident
        End Get
        Set(ByVal value As String)
            _strResident = value
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
    Public Shared Function IsExistEmployee(ByVal strIDEmployee As String) As Boolean
        Return False
    End Function
    Public Shared Function IsExist(ByVal strIDEmployee As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT Top 1 IDEmployee FROM HREmployee WHERE IDEmployee=N'" & strIDEmployee.Trim & "'"
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.IsExist)", , True)
        End Try
    End Function
    Public Function Add() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            If _picPicture Is Nothing Then
                oCommand.CommandText = "INSERT INTO HREmployee " & _
                                       "VALUES(N'" & _strIDJobTitle & "',N'" & _strIDLevel & "',N'" & _strIDEmployee & _
                                       "',N'" & _strFirstName & "',N'" & _strLastName & "'," & CInt(_bolGender) & _
                                       ",'" & _strBirthDate & "','" & _strHireDate & "',N'" & _strHomePhone & _
                                       "',N'" & _strMobilePhone & "',N'" & _strEmail & "',N'" & _strTempResident & _
                                       "',N'" & _strResident & "',null)"
            Else
                oCommand.CommandText = "INSERT INTO HREmployee " & _
                                       "VALUES(N'" & _strIDJobTitle & "',N'" & _strIDLevel & "',N'" & _strIDEmployee & _
                                       "',N'" & _strFirstName & "',N'" & _strLastName & "'," & CInt(_bolGender) & _
                                       ",'" & _strBirthDate & "','" & _strHireDate & "',N'" & _strHomePhone & _
                                       "',N'" & _strMobilePhone & "',N'" & _strEmail & "',N'" & _strTempResident & _
                                       "',N'" & _strResident & "',@picPicture)"
                oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                oCommand.Parameters("@picPicture").Value = ImageToByte(_picPicture)
            End If
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.Add)", , True)
        End Try
    End Function
    Public Shared Function Delete(ByVal strIDEmployee As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            oCommand.CommandText = "DELETE FROM HREmployee WHERE IDEmployee=N'" & strIDEmployee.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.Delete)", , True)
        End Try
    End Function
    Public Function Update() As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand
            If _picPicture Is Nothing Then
                oCommand.CommandText = "UPDATE HREmployee SET " & _
                                       "IDJobTitle=N'" & _strIDJobTitle & "',IDLevel=N'" & _strIDLevel & "',FirstName=N'" & _strFirstName & _
                                       "',LastName=N'" & _strLastName & "',Gender=" & CInt(_bolGender) & ",BirthDate='" & _strBirthDate & _
                                       "',HireDate='" & _strHireDate & "',HomePhone=N'" & _strHomePhone & "',MobilePhone=N'" & _strMobilePhone & _
                                       "',TempResident=N'" & _strTempResident & "',Resident=N'" & _strResident & "',Email=N'" & _strEmail & _
                                       "',Picture=null " & _
                                       "WHERE IDEmployee=N'" & IDEmployee & "'"
            Else
                oCommand.CommandText = "UPDATE HREmployee SET " & _
                                       "IDJobTitle=N'" & _strIDJobTitle & "',IDLevel=N'" & _strIDLevel & "',FirstName=N'" & _strFirstName & _
                                       "',LastName=N'" & _strLastName & "',Gender=" & CInt(_bolGender) & ",BirthDate='" & _strBirthDate & _
                                       "',HireDate='" & _strHireDate & "',HomePhone=N'" & _strHomePhone & "',MobilePhone=N'" & _strMobilePhone & _
                                       "',TempResident=N'" & _strTempResident & "',Resident=N'" & _strResident & "',Email=N'" & _strEmail & _
                                       "',Picture=@picPicture " & _
                                       "WHERE IDEmployee=N'" & IDEmployee & "'"
                oCommand.Parameters.Add("@picPicture", SqlDbType.Image)
                oCommand.Parameters("@picPicture").Value = ImageToByte(_picPicture)
            End If
            oCommand.Connection = oConnect.GetConnection()
            oCommand.ExecuteNonQuery()
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.Update)", , True)
        End Try
    End Function
    Public Function GetTable() As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            oCommand.CommandText = "SELECT * FROM HREmployee ORDER BY IDEmployee ASC"
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.GetTable)", , True)
        End Try
        Return Nothing
    End Function
    Public Function Search(ByVal strField As String, ByVal intValue As Integer, ByVal strValue As String) As DataTable
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataAdapter As New SqlDataAdapter
            If _dsData Is Nothing Then _dsData = New DataSet
            If strField = "HRJob.JName" Then
                Select Case intValue
                    Case 0
                        oCommand.CommandText = "SELECT HREmp.* FROM HREmployee HREmp,HRJobTitle HRJob " & _
                                               "WHERE HREmp.IDJobTitle=HRJob.IDJobTitle AND Gender=1 AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                               "ORDER BY HREmp.IDEmployee ASC"
                    Case 1
                        oCommand.CommandText = "SELECT HREmp.* FROM HREmployee HREmp,HRJobTitle HRJob " & _
                                               "WHERE HREmp.IDJobTitle=HRJob.IDJobTitle AND Gender=0 AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                               "ORDER BY HREmp.IDEmployee ASC"
                    Case 2
                        oCommand.CommandText = "SELECT HREmp.* FROM HREmployee HREmp,HRJobTitle HRJob " & _
                                               "WHERE HREmp.IDJobTitle=HRJob.IDJobTitle AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                               "ORDER BY HREmp.IDEmployee ASC"
                End Select
            Else
                If strField = "HRLev.LName" Then
                    Select Case intValue
                        Case 0
                            oCommand.CommandText = "SELECT HREmp.* FROM HREmployee HREmp,HRLevel HRLev " & _
                                                   "WHERE HREmp.IDLevel=HRLev.IDLevel AND Gender=1 AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                                   "ORDER BY HREmp.IDEmployee ASC"
                        Case 1
                            oCommand.CommandText = "SELECT HREmp.* FROM HREmployee HREmp,HRLevel HRLev " & _
                                                   "WHERE HREmp.IDLevel=HRLev.IDLevel AND Gender=0 AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                                   "ORDER BY HREmp.IDEmployee ASC"
                        Case 2
                            oCommand.CommandText = "SELECT HREmp.* FROM HREmployee HREmp,HRLevel HRLev " & _
                                                   "WHERE HREmp.IDLevel=HRLev.IDLevel  AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                                   "ORDER BY HREmp.IDEmployee ASC"
                    End Select
                Else
                    Select Case intValue
                        Case 0
                            oCommand.CommandText = "SELECT * FROM HREmployee " & _
                                                   "WHERE Gender=1 AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                                   "ORDER BY IDEmployee ASC"
                        Case 1
                            oCommand.CommandText = "SELECT * FROM HREmployee " & _
                                                   "WHERE Gender=0 AND " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                                   "ORDER BY IDEmployee ASC"
                        Case 2
                            oCommand.CommandText = "SELECT * FROM HREmployee " & _
                                                   "WHERE " & strField & " Like N'%" & strValue.Trim & "%' " & _
                                                   "ORDER BY IDEmployee ASC"
                    End Select
                End If
            End If
            oCommand.Connection = oConnect.GetConnection()
            oDataAdapter.SelectCommand = oCommand
            oDataAdapter.Fill(_dsData)
            oDataAdapter.Dispose() : oDataAdapter = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
            Return _dsData.Tables(0)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.Search)", , True)
        End Try
        Return Nothing
    End Function
    Public Function GetInfor(ByVal strIDEmployee As String) As Boolean
        Try
            Dim oConnect As New clsConnection
            Dim oCommand As New SqlCommand, oDataReader As SqlDataReader
            oCommand.CommandText = "SELECT * FROM HREmployee WHERE IDEmployee=N'" & strIDEmployee.Trim & "'"
            oCommand.Connection = oConnect.GetConnection()
            oDataReader = oCommand.ExecuteReader
            If oDataReader.Read Then
                _setInfor(oDataReader)
            End If
            oDataReader.Close() : oDataReader = Nothing
            oCommand.Dispose() : oCommand = Nothing
            oConnect.CloseConnection() : oConnect = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.GetInfor)", , True)
        End Try
    End Function
    Private Sub _setInfor(ByVal oDataReader As SqlDataReader)
        Try
            Try
                _strIDJobTitle = oDataReader.GetString(0)
            Catch ex As Exception
                _strIDJobTitle = ""
            End Try
            Try
                _strIDLevel = oDataReader.GetString(1)
            Catch ex As Exception
                _strIDLevel = ""
            End Try
            Try
                _strIDEmployee = oDataReader.GetString(2)
            Catch ex As Exception
                _strIDEmployee = ""
            End Try
            Try
                _strFirstName = oDataReader.GetString(3)
            Catch ex As Exception
                _strFirstName = ""
            End Try
            Try
                _strLastName = oDataReader.GetString(4)
            Catch ex As Exception
                _strLastName = ""
            End Try
            Try
                _bolGender = oDataReader.GetBoolean(5)
            Catch ex As Exception
                _bolGender = False
            End Try
            Try
                Select Case clsConfig.GetLangPNA
                    Case "VietNamese"
                        _strBirthDate = GetDayOrMonth(oDataReader.GetDateTime(6).Day) & "/" & GetDayOrMonth(oDataReader.GetDateTime(6).Month) & "/" & GetDayOrMonth(oDataReader.GetDateTime(6).Year)
                        _strHireDate = GetDayOrMonth(oDataReader.GetDateTime(7).Day) & "/" & GetDayOrMonth(oDataReader.GetDateTime(7).Month) & "/" & GetDayOrMonth(oDataReader.GetDateTime(7).Year)
                    Case "English"
                        _strBirthDate = GetDayOrMonth(oDataReader.GetDateTime(6).Month) & "/" & GetDayOrMonth(oDataReader.GetDateTime(6).Day) & "/" & GetDayOrMonth(oDataReader.GetDateTime(6).Year)
                        _strHireDate = GetDayOrMonth(oDataReader.GetDateTime(7).Month) & "/" & GetDayOrMonth(oDataReader.GetDateTime(7).Day) & "/" & GetDayOrMonth(oDataReader.GetDateTime(7).Year)
                End Select
            Catch ex As Exception
                _strBirthDate = ""
                _strHireDate = ""
            End Try
            Try
                _strHomePhone = oDataReader.GetString(8)
            Catch ex As Exception
                _strHomePhone = ""
            End Try
            Try
                _strMobilePhone = oDataReader.GetString(9)
            Catch ex As Exception
                _strMobilePhone = ""
            End Try
            Try
                _strEmail = oDataReader.GetString(10)
            Catch ex As Exception
                _strEmail = ""
            End Try
            Try
                _strTempResident = oDataReader.GetString(11)
            Catch ex As Exception
                _strTempResident = ""
            End Try
            Try
                _strResident = oDataReader.GetString(12)
            Catch ex As Exception
                _strResident = ""
            End Try
            Try
                _picPicture = ByteToImage(oDataReader.GetValue(13))
            Catch ex As Exception
                _picPicture = Nothing
            End Try
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee._setInfor)", , True)
        End Try
    End Sub
    Public Function DisposedEmployee() As Boolean
        Try
            _strIDJobTitle = Nothing
            _strIDLevel = Nothing
            _strIDEmployee = Nothing
            _strFirstName = Nothing
            _strLastName = Nothing
            _bolGender = Nothing
            _strBirthDate = Nothing
            _strHireDate = Nothing
            _strTempResident = Nothing
            _strResident = Nothing
            _strHomePhone = Nothing
            _strMobilePhone = Nothing
            _strEmail = Nothing
            If Not _picPicture Is Nothing Then _picPicture.Dispose()
            _picPicture = Nothing
            If Not _dsData Is Nothing Then _dsData.Dispose()
            _dsData = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(clsHREmployee.DisposedEmployee)", , True)
        End Try
    End Function
#End Region
End Class
