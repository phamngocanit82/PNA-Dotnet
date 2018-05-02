'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports System.Windows.Forms
Public Class clsError
    Public Shared Sub ShowError(Optional ByVal oForm As Object = Nothing, Optional ByVal captionForm As String = "", _
                                Optional ByVal strErrorInformation As String = "", Optional ByVal enumIconType As IconType = IconType.Message)
        Try
            Dim oFrmError As New frmError
            oFrmError.Text = captionForm
            oFrmError.txtErrorInformation.Text = strErrorInformation
            If oForm Is Nothing Then
                oFrmError.ShowDialog()
            Else
                oFrmError.ShowDialog(oForm)
            End If
        Catch ex As Exception
            Throw New Exception("clsError: ShowError error!!")
        End Try
    End Sub
End Class
