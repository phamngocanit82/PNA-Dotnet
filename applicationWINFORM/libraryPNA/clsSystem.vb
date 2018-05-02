'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports Microsoft.Win32
Imports System.Drawing
Imports System.Windows.Forms
Imports vb = Microsoft.VisualBasic
Public Class clsSystem
    Public Enum DirLang
        ACC = 0
        HR = 1
        Others = 2
        PU = 3
        SYS = 4
        TOO = 5
        WH = 6
        HOTEL = 7
    End Enum
    Public Shared Function GetLang(ByVal strFileName As String, Optional ByVal indexRow As Integer = 0, Optional ByVal intLang As Integer = 0, _
                                   Optional ByVal numDirLang As DirLang = DirLang.Others, Optional ByVal strDirPath As String = "LanguageFiles") As String
        Try
            Dim dsConfigure As New DataSet, intColumnLang As Integer = 1, dsLang As New DataSet, strPath As String = "", strLang As String = ""
            dsConfigure.ReadXml(Application.StartupPath & "\LanguageFiles\SYS\Configure.xml", XmlReadMode.Auto)
            If intLang = 0 Then
                Select Case dsConfigure.Tables(0).Rows(0).Item(2)
                    Case "VietNamese"
                        intColumnLang = 1
                    Case "English"
                        intColumnLang = 2
                End Select
            Else
                intColumnLang = intLang
            End If
            If strDirPath = "LanguageFiles" Then
                Select Case numDirLang
                    Case DirLang.ACC
                        strPath = Application.StartupPath & "\" & strDirPath & "\ACC\" & strFileName
                    Case DirLang.HR
                        strPath = Application.StartupPath & "\" & strDirPath & "\HR\" & strFileName
                    Case DirLang.Others
                        strPath = Application.StartupPath & "\" & strDirPath & "\Others\" & strFileName
                    Case DirLang.PU
                        strPath = Application.StartupPath & "\" & strDirPath & "\PU\" & strFileName
                    Case DirLang.SYS
                        strPath = Application.StartupPath & "\" & strDirPath & "\SYS\" & strFileName
                    Case DirLang.TOO
                        strPath = Application.StartupPath & "\" & strDirPath & "\TOO\" & strFileName
                    Case DirLang.WH
                        strPath = Application.StartupPath & "\" & strDirPath & "\WH\" & strFileName
                    Case DirLang.HOTEL
                        strPath = Application.StartupPath & "\" & strDirPath & "\HOTEL\" & strFileName
                End Select
            Else
                strPath = Application.StartupPath & "\" & strDirPath & "\" & strFileName
            End If
            dsLang.ReadXml(strPath, XmlReadMode.Auto)
            strLang = dsLang.Tables(0).Rows(indexRow).Item(intColumnLang)
            dsConfigure.Dispose() : dsConfigure = Nothing
            dsLang.Dispose() : dsLang = Nothing
            Return strLang
        Catch ex As Exception

        End Try
        Return "(*)"
    End Function
    Private Shared Function readRegistry(ByVal strKeyName As String, ByVal strApplicationName As String) As Boolean
        Try
            Dim oRegistryKey As RegistryKey
            Dim strValue As String
            oRegistryKey = Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\run\", False)
            strValue = CType(oRegistryKey.GetValue(strKeyName, ""), String)
            If (strValue.ToUpper = strApplicationName.ToUpper) Then
                Return True
            Else
                Return False
            End If
            oRegistryKey.Close() : oRegistryKey = Nothing
        Catch ex As Exception
            Throw New Exception("clsSystem: readRegistry error!!")
        End Try
    End Function
    Public Shared Sub CreateRegistry(ByVal ValName As String, ByVal strApplicationName As String)
        Try
            Dim oRegistryKey As RegistryKey
            If Not readRegistry(ValName, strApplicationName) Then
                oRegistryKey = Registry.LocalMachine.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\run\")
                oRegistryKey.SetValue(ValName, strApplicationName)
                oRegistryKey.Close()
            End If
            oRegistryKey = Nothing
        Catch ex As Exception
            Throw New Exception("clsSystem: CreateRegistry error!!")
        End Try
    End Sub
    Public Shared Function IsApplication(Optional ByVal strApplicationName As String = "applicationFORM") As Boolean
        Try
            Dim oProcess As Process
            Dim i As Integer = 0
            For Each oProcess In Process.GetProcesses(System.Environment.MachineName)
                If oProcess.ProcessName.ToString = strApplicationName Then i = i + 1
                If i = 2 Then Return True
            Next
            Return False
        Catch ex As Exception
            Throw New Exception("clsSystem: IsApplication error!!")
        End Try
    End Function
    Public Shared Sub KillSlidebar()
        Dim oProcess() As Process, oProcessKill As Process, i As Integer
        Try
            oProcess = Process.GetProcesses(System.Environment.MachineName.ToString())
            For i = 0 To UBound(oProcess)
                If oProcess(i).ProcessName = "Slidebar" Then
                    oProcessKill = Process.GetProcessById(oProcess(i).Id)
                    oProcessKill.Kill()
                End If
            Next
        Catch ex As Exception
            Throw New Exception("clsSystem: KillSlidebar error!!")
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
            Throw New Exception("clsSystem: KillExcel error!!")
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
            Throw New Exception("clsSystem: KillWord error!!")
        End Try
    End Sub
End Class
