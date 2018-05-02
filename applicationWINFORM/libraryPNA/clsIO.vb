'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports System.IO
Imports System.Drawing
Public Class clsIO
    Public Shared Function Encrypt(ByVal strValue As String) As String
        Try
            Dim strEncrypt As String = "", strLettter As String = ""
            Dim i As Integer
            For i = 1 To Len(strValue)
                strLettter = Mid(strValue, i, 1)
                strEncrypt = strEncrypt & Chr(Asc(strLettter) - 30)
            Next
            Return strEncrypt
        Catch ex As Exception
            Throw New Exception("clsIO: Encrypt error!!")
        End Try
    End Function
    Public Shared Function Decrypt(ByVal strValue As String) As String
        Try
            Dim strDecrypt As String = "", strLettter As String = ""
            Dim i As Integer
            For i = 1 To Len(strValue)
                strLettter = Mid(strValue, i, 1)
                strDecrypt = strDecrypt & Chr(Asc(strLettter) + 30)
            Next
            Return strDecrypt
        Catch ex As Exception
            Throw New Exception("clsIO: Decrypt error!!")
        End Try
    End Function
    Public Shared Function ReadInit(ByVal strFilePath As String, ByVal intRow As Integer) As String
        Try
            Dim oSReader As StreamReader
            Dim mString As String = "", i As Integer = 0
            oSReader = New StreamReader(strFilePath)
            For i = 0 To intRow
                mString = oSReader.ReadLine()
            Next
            oSReader.Close() : oSReader = Nothing
            Return mString
        Catch ex As Exception
            Throw New Exception("clsIO: ReadInit error!!")
        End Try
    End Function
    Public Shared Sub WriteInit(ByVal strFilePath As String, ByVal strValue As String)
        Try
            Dim oSWriter As New StreamWriter(strFilePath)
            oSWriter.Write(strValue)
            oSWriter.Close() : oSWriter = Nothing
        Catch ex As Exception
            Throw New Exception("clsIO: WriteInit error!!")
        End Try
    End Sub
    Public Shared Function ReadBinary(ByVal strFilePath As String) As Byte()
        Try
            Dim oFStream As FileStream
            Dim oBReader As BinaryReader
            Dim mByte() As Byte
            oFStream = New FileStream(strFilePath, FileMode.Open, FileAccess.Read)
            oBReader = New BinaryReader(oFStream)
            mByte = oBReader.ReadBytes(oFStream.Length)
            oBReader.Close() : oBReader = Nothing
            oFStream.Close() : oFStream = Nothing
            Return mByte
        Catch ex As Exception
            Throw New Exception("clsIO: ReadBinary error!!")
        End Try
    End Function
    Public Shared Sub WriteBinary(ByVal strFilePath As String, ByVal mBinary() As Byte)
        Try
            Dim oFStream As FileStream
            oFStream = New FileStream(strFilePath, FileMode.OpenOrCreate, FileAccess.Write)
            oFStream.Write(mBinary, 0, mBinary.Length)
            oFStream.Close() : oFStream = Nothing
        Catch ex As Exception
            Throw New Exception("clsIO: WriteBinary error!!")
        End Try
    End Sub
    Public Shared Function ImageToByte(ByVal oPicture As Bitmap, ByVal strExtension As String) As Byte()
        Try
            Dim oMStream As New MemoryStream
            Select Case strExtension
                Case "jpeg", "jpg"
                    oPicture.Save(oMStream, Imaging.ImageFormat.Jpeg)
                Case "Bmp"
                    oPicture.Save(oMStream, Imaging.ImageFormat.Bmp)
                Case "png"
                    oPicture.Save(oMStream, Imaging.ImageFormat.Png)
                Case "gif"
                    oPicture.Save(oMStream, Imaging.ImageFormat.Gif)
            End Select
            Return oMStream.ToArray()
        Catch ex As Exception
            Throw New Exception("clsIO: ImageToByte error!!")
        End Try
    End Function
    Public Shared Function ByteToImage(ByVal mByte As Byte()) As Bitmap
        Try
            Return Bitmap.FromStream(New MemoryStream(mByte))
        Catch ex As Exception
            Throw New Exception("clsIO: ByteToImage error!!")
        End Try
    End Function
End Class
