Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports Microsoft.Win32
Imports System.Diagnostics
Imports vb = Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Public Class clsMethods
    <DllImport("user32.dll")> _
    Private Shared Function SetForegroundWindow(ByVal hwnd As IntPtr) As Long
    End Function
#Region "Enum"
    Public Enum InforButton
        Ok = 0
        Yes = 1
        No = 2
        YesNo = 3
    End Enum
#End Region
    Public Shared Function ShowInfor(ByVal _form As Form, ByVal strPrompt As String, Optional ByVal strDetail As String = "", _
                                     Optional ByVal enumInforButton As InforButton = InforButton.Ok, Optional ByVal bolError As Boolean = False, Optional ByVal strFileError As String = "") As InforButton
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Dim _dsLanguage As New DataSet
            Dim _frmInfor As New frmInfor, _InforButton As InforButton
            Dim _intLanguage As Integer
            Select Case clsConfig.GetLangPNA
                Case "VietNamese"
                    _intLanguage = 1
                Case "English"
                    _intLanguage = 2
            End Select
            _dsLanguage.ReadXml(AppAssembly.GetManifestResourceStream("clsOmegaSoft.XMLInfor.xml"))
            If bolError Then
                _writeError(strDetail, strFileError)
                _frmInfor.lblPrompt.Text = _dsLanguage.Tables(0).Rows(6).Item(_intLanguage)
                _frmInfor.lblInfor.Text = " &" & _dsLanguage.Tables(0).Rows(1).Item(_intLanguage)
                _frmInfor.llblDetail.Text = _dsLanguage.Tables(0).Rows(7).Item(_intLanguage)
                _frmInfor.tipDetail.SetToolTip(_frmInfor.llblDetail, strDetail)
            Else
                _frmInfor.lblPrompt.Text = strPrompt
                _frmInfor.lblInfor.Text = " &" & _dsLanguage.Tables(0).Rows(0).Item(_intLanguage)
                _frmInfor.llblDetail.Visible = False
            End If
            _frmInfor.tipDetail.SetToolTip(_frmInfor.btnClose, _dsLanguage.Tables(0).Rows(2).Item(_intLanguage))

            If enumInforButton = InforButton.Ok Then
                _frmInfor.btnOk.Text = _dsLanguage.Tables(0).Rows(3).Item(_intLanguage)
                _frmInfor.btnYes.Visible = False
                _frmInfor.btnNo.Visible = False
                _frmInfor.btnOk.Visible = True
                _frmInfor.btnOk.Focus()
            Else
                _frmInfor.btnNo.Text = _dsLanguage.Tables(0).Rows(4).Item(_intLanguage)
                _frmInfor.btnYes.Text = _dsLanguage.Tables(0).Rows(5).Item(_intLanguage)
                _frmInfor.btnOk.Visible = False
                _frmInfor.btnYes.Visible = True
                _frmInfor.btnNo.Visible = True
                _frmInfor.btnYes.Focus()
            End If
            If _form Is Nothing Then
                _frmInfor.Location = New Point(Screen.PrimaryScreen.Bounds.Left + (Screen.PrimaryScreen.Bounds.Width - _frmInfor.Width) / 2, Screen.PrimaryScreen.Bounds.Top + (Screen.PrimaryScreen.Bounds.Height - _frmInfor.Height) / 2)
            Else
                _frmInfor.Location = New Point(_form.Bounds.X + (_form.Width - _frmInfor.Width) / 2, _form.Bounds.Y + (_form.Height - _frmInfor.Height) / 2)
            End If
            _dsLanguage.Dispose() : _dsLanguage = Nothing
            _frmInfor.ShowDialog()
            _InforButton = _frmInfor.GetInforButton()
            _frmInfor.CloseForm() : _frmInfor = Nothing
            Return _InforButton
        Catch ex As Exception

        End Try
    End Function
    Public Shared Sub _writeError(ByVal strDetail As String, ByVal strFileError As String)

    End Sub
    Public Shared Sub WriteFile(ByVal strDetail As String)

    End Sub
#Region "Date"
    Public Shared Function GetDayOrMonth(ByVal value As Integer) As String
        If value < 10 Then
            GetDayOrMonth = "0" & value.ToString
        Else
            GetDayOrMonth = value.ToString
        End If
    End Function
    Public Shared Function GetDatePNA(ByVal value As String) As String
        Dim strDate As String = ""
        Select Case clsConfig.GetLangPNA
            Case "VietNamese"
                strDate = GetDayOrMonth(CInt(vb.Mid(value.Trim, 4, 2))) & "/" & GetDayOrMonth(CInt(vb.Left(value.Trim, 2))) & "/" & GetDayOrMonth(CInt(vb.Right(value.Trim, 4)))
            Case "English"
                strDate = value.Trim
        End Select
        Return strDate
    End Function
    Public Shared Function DisplayDate()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Dim _dsLanguage As New DataSet
            Dim _intLanguage As Integer = 0, strDisplayDate As String = ""
            Select Case clsConfig.GetLangPNA
                Case "VietNamese"
                    _intLanguage = 1
                Case "English"
                    _intLanguage = 2
            End Select
            _dsLanguage.ReadXml(AppAssembly.GetManifestResourceStream("clsOmegaSoft.XMLDate.xml"))
            With _dsLanguage.Tables(0)
                Select Case Now.DayOfWeek
                    Case DayOfWeek.Sunday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(0).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(0).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(0).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(0).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(0).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                    Case DayOfWeek.Monday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(1).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(1).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(1).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(1).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(1).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                    Case DayOfWeek.Tuesday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(2).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(2).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(2).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(2).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(2).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                    Case DayOfWeek.Wednesday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(3).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(3).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(3).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(3).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(3).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                    Case DayOfWeek.Thursday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(4).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(4).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(4).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(4).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(4).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                    Case DayOfWeek.Friday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(5).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(5).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(5).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(5).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(5).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                    Case DayOfWeek.Saturday
                        If _intLanguage = 1 Then
                            strDisplayDate = .Rows(6).Item(_intLanguage) & ", " & .Rows(19).Item(_intLanguage).ToString.ToLower & " " & Now.Day & " " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower.ToLower & " " & .Rows(21).Item(_intLanguage).ToString.ToLower & " " & Now.Year
                        Else
                            Select Case Now.Day
                                Case 1
                                    strDisplayDate = .Rows(6).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "st " & Now.Year
                                Case 2
                                    strDisplayDate = .Rows(6).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "nd " & Now.Year
                                Case 3
                                    strDisplayDate = .Rows(6).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "rd " & Now.Year
                            End Select
                            strDisplayDate = .Rows(6).Item(_intLanguage) & ", " & .Rows(Now.Month + 6).Item(_intLanguage).ToString.ToLower & " " & Now.Day & "th " & Now.Year
                        End If
                End Select
            End With
            _dsLanguage.Dispose() : _dsLanguage = Nothing
            Return strDisplayDate
        Catch ex As Exception
        End Try
        Return ""
    End Function
    Public Shared Function DisplayTimer()
        Return GetDayOrMonth(Now.Hour) & ":" & GetDayOrMonth(Now.Minute) & ":" & GetDayOrMonth(Now.Second) & " " & vb.Right(Date.UtcNow.ToString, 2)
    End Function
#End Region
#Region "File"
    Public Shared Function Encrypt(ByVal strValue As String) As String
        Dim strEncrypt As String = "", strLettter As String = ""
        Try
            Dim i As Integer
            For i = 1 To Len(strValue)
                strLettter = Mid(strValue, i, 1)
                strEncrypt = strEncrypt & Chr(Asc(strLettter) - 30)
            Next
            Return strEncrypt
        Catch ex As Exception

        End Try
        Return strEncrypt
    End Function
    Public Shared Function Decrypt(ByVal strValue As String) As String
        Dim strDecrypt As String = "", strLettter As String = ""
        Try
            Dim i As Integer
            For i = 1 To Len(strValue)
                strLettter = Mid(strValue, i, 1)
                strDecrypt = strDecrypt & Chr(Asc(strLettter) + 30)
            Next
            Return strDecrypt
        Catch ex As Exception

        End Try
        Return strDecrypt
    End Function
    Public Shared Function ReadBinary(ByVal strFilePath As String) As Byte()
        Dim oFStream As FileStream
        Dim oBReader As BinaryReader
        Dim mByte() As Byte
        oFStream = New FileStream(strFilePath, FileMode.Open, FileAccess.Read)
        oBReader = New BinaryReader(oFStream)
        mByte = oBReader.ReadBytes(oFStream.Length)
        oBReader.Close() : oBReader = Nothing
        oFStream.Close() : oFStream = Nothing
        Return mByte
    End Function
    Public Shared Sub WriteBinary(ByVal strFilePath As String, ByVal mBinary() As Byte)
        Try
            Dim oFStream As FileStream
            oFStream = New FileStream(strFilePath, FileMode.OpenOrCreate, FileAccess.Write)
            oFStream.Write(mBinary, 0, mBinary.Length)
            oFStream.Close() : oFStream = Nothing
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Bitmap"
    Public Shared Function ImageToByte(ByVal oPicture As Bitmap) As Byte()
        Try
            Dim oMStream As New MemoryStream
            oPicture.Save(oMStream, Imaging.ImageFormat.Jpeg)
            Return oMStream.ToArray()
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function ByteToImage(ByVal mByte As Byte()) As Bitmap
        Try
            Return Bitmap.FromStream(New MemoryStream(mByte))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "System"
    Private Shared Function _ReadRegistry(ByVal strKeyName As String, ByVal strApplicationName As String) As Boolean
        Dim oRegistryKey As RegistryKey
        Dim strValue As String
        Try
            oRegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\run\", False)
            strValue = CType(oRegistryKey.GetValue(strKeyName, ""), String)
            If (strValue.ToUpper = strApplicationName.ToUpper) Then
                Return True
            Else
                Return False
            End If
            oRegistryKey.Close() : oRegistryKey = Nothing
        Catch ex As Exception

        End Try
    End Function
    Public Shared Sub CreateRegistry(ByVal ValName As String, ByVal strApplicationName As String)
        Dim oRegistryKey As RegistryKey
        Try
            If Not _ReadRegistry(ValName, strApplicationName) Then
                oRegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\run\")
                oRegistryKey.SetValue(ValName, strApplicationName)
                oRegistryKey.Close()
            End If
            oRegistryKey = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Function IsApplication(Optional ByVal strApplicationName As String = "OmegaSoft") As Boolean
        Try
            Dim oProcess As Process
            Dim i As Integer = 0
            For Each oProcess In Process.GetProcesses(System.Environment.MachineName)
                If oProcess.ProcessName.ToString = strApplicationName Then i = i + 1
                If i = 2 Then Return True
            Next
            Return False
        Catch ex As Exception

        End Try
    End Function
    Public Shared Sub KillSlidebar()
        Dim oProcess() As Process, oProcessKill As Process, i As Integer
        Try
            oProcess = Process.GetProcesses(System.Environment.MachineName.ToString())
            For i = 0 To UBound(oProcess)
                If oProcess(i).ProcessName = "OmegaSlidebar" Then
                    oProcessKill = Process.GetProcessById(oProcess(i).Id)
                    oProcessKill.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub KillExcel()
        Dim oProcess() As Process, oProcessKill As Process, i As Integer
        Try
            oProcess = Process.GetProcesses(System.Environment.MachineName.ToString())
            For i = 0 To UBound(oProcess)
                If (oProcess(i).ProcessName.ToUpper = "EXCEL" And oProcess(i).MainWindowTitle.ToString() = "") Or oProcess(i).ProcessName.ToUpper = "DW20" Then
                    oProcessKill = Process.GetProcessById(oProcess(i).Id)
                    oProcessKill.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub KillWord()
        Dim oProcess() As Process, oProcessKill As Process, i As Integer
        Try
            oProcess = Process.GetProcesses(System.Environment.MachineName.ToString())
            For i = 0 To UBound(oProcess)
                If (oProcess(i).ProcessName.ToUpper = "WINWORD" And oProcess(i).MainWindowTitle.ToString() = "") Or oProcess(i).ProcessName.ToUpper = "DW20" Then
                    oProcessKill = Process.GetProcessById(oProcess(i).Id)
                    oProcessKill.Kill()
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Network"
#Region "Mail"

#End Region
#Region "Chat"

#End Region
#End Region
#Region "Others"
    Public Shared Function MoneyString(ByVal dblValue As Double)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Dim strMoney As String = "", indexString As Integer = 1, strTmp As String = ""
            Dim _dsLanguage As New DataSet
            _dsLanguage.ReadXml(AppAssembly.GetManifestResourceStream("clsOmegaSoft.XMLMoney.xml"))
            strTmp = CStr(Math.Round(dblValue, 0))
            With _dsLanguage.Tables(0)
                If strTmp = "0" Then
                    strMoney = .Rows(0)(1) & " " & .Rows(11)(1)
                Else
                    While indexString <= strTmp.Length
                        If vb.Left(vb.Right(strTmp, indexString), 1) <> "0" Then
                            Select Case indexString
                                Case 1
                                    strMoney = .Rows(vb.Left(vb.Right(strTmp, indexString), 1))(1) & " " & strMoney
                                Case 4
                                    strMoney = .Rows(vb.Left(vb.Right(strTmp, indexString), 1))(1) & " " & .Rows(14)(1) & " " & strMoney
                                Case 7
                                    strMoney = .Rows(vb.Left(vb.Right(strTmp, indexString), 1))(1) & " " & .Rows(15)(1) & " " & strMoney
                                Case 10
                                    strMoney = .Rows(vb.Left(vb.Right(strTmp, indexString), 1))(1) & " " & .Rows(16)(1) & " " & strMoney

                                Case 2, 5, 8, 11
                                    If vb.Left(vb.Right(strTmp, indexString), 1) = "1" Then
                                        strMoney = .Rows(10)(1) & " " & strMoney
                                    Else
                                        strMoney = .Rows(vb.Left(vb.Right(strTmp, indexString), 1))(1) & " " & .Rows(12)(1) & " " & strMoney
                                    End If
                                Case 3, 6, 9, 12
                                    strMoney = .Rows(vb.Left(vb.Right(strTmp, indexString), 1))(1) & " " & .Rows(13)(1) & " " & strMoney
                            End Select
                        End If
                        indexString = indexString + 1
                    End While
                    strMoney = strMoney & " " & .Rows(11)(1)
                End If
            End With
            _dsLanguage.Dispose() : _dsLanguage = Nothing
            Return vb.Left(strMoney, 1).ToUpper & vb.Right(strMoney, strMoney.Length - 1)
        Catch ex As Exception
            Return ""
        End Try
        Return ""
    End Function
#End Region
End Class
