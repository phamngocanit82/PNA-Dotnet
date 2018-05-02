Imports System.Windows.Forms
Imports clsOmegaSoft.clsMethods
Public Class clsConfig
    Public Shared Function WriterXMLPNA(ByVal strValue As String, ByVal intRow As Integer, ByVal strFile As String) As Boolean
        Try
            Dim dsLang As New DataSet
            strFile = "\\10.0.0.1\OMEGA Soft\" & strFile
            dsLang.ReadXml(strFile, XmlReadMode.Auto)
            dsLang.Tables(0).Rows(intRow).Item("Type") = strValue
            dsLang.WriteXml(strFile)
            dsLang.Dispose() : dsLang = Nothing
            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function
    Public Shared Function GetLangPNA() As String
        Dim strPath As String, strLang As String = ""
        Try
            Dim dsLang As New DataSet
            strPath = Application.StartupPath & "\Files\XMLConfigs.xml"
            ' strPath = "C:\Project\OmegaSoft\OmegaSoft\bin\Files\XMLConfigs.xml"
            dsLang.ReadXml(strPath, XmlReadMode.Auto)
            strLang = dsLang.Tables(0).Rows(0).Item("Type")
            dsLang.Dispose() : dsLang = Nothing
            Return strLang
        Catch ex As Exception
        End Try
        Return ""
    End Function
    Public Shared Function GetSkinPNA() As String
        Dim strPath As String, strSkin As String = ""
        Try
            Dim dsSkin As New DataSet
            strPath = Application.StartupPath & "\Files\XMLConfigs.xml"
            dsSkin.ReadXml(strPath, XmlReadMode.Auto)
            strSkin = dsSkin.Tables(0).Rows(1).Item("Type")
            dsSkin.Dispose() : dsSkin = Nothing
            Return strSkin
        Catch ex As Exception

        End Try
        Return ""
    End Function
    Public Shared Function GetFontPNA() As String
        Dim strPath As String, strFont As String = ""
        Try
            Dim dsFont As New DataSet
            strPath = Application.StartupPath & "\Files\XMLConfigs.xml"
            dsFont.ReadXml(strPath, XmlReadMode.Auto)
            strFont = dsFont.Tables(0).Rows(1).Item("Type")
            dsFont.Dispose() : dsFont = Nothing
            Return strFont
        Catch ex As Exception

        End Try
        Return ""
    End Function
    Public Shared Function GetLanguage(ByVal intIndex As Integer, ByVal strFilePath As String, Optional ByVal bolReport As Boolean = False) As String
        Dim strPath As String, strLang As String = ""
        Try
            Dim dsLang As New DataSet
            strPath = Application.StartupPath & "\Files\" & strFilePath
            dsLang.ReadXml(strPath, XmlReadMode.Auto)
            If bolReport Then
                strLang = dsLang.Tables(0).Rows(intIndex).Item("VietNamese")
            Else
                strLang = dsLang.Tables(0).Rows(intIndex).Item(GetLangPNA)
            End If
            dsLang.Dispose() : dsLang = Nothing
            Return strLang
        Catch ex As Exception

        End Try
        Return ""
    End Function
    Public Shared Function GetUserDB() As String
        Return "sa"
    End Function
    Public Shared Function GetPasswordDB() As String
        Return ""
    End Function
    Public Shared Function GetServerDB() As String
        Return "10.0.0.3"
    End Function
    Public Shared Function GetDataBase() As String
        Return "Omega_Soft"
    End Function
End Class
