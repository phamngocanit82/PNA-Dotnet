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
Public Class clsMessage
    Public Shared Function ShowMessage(ByVal oForm As Form, ByVal captionForm As String, ByVal strMessageInfor As String, Optional ByVal intLang As Integer = 0, _
                                       Optional ByVal enumButtonType As ButtonType = ButtonType.Ok, Optional ByVal enumIconType As IconType = IconType.Message) As ButtonType
        Try
            Dim dsLang As New DataSet, oFrmMessage As New frmMessage, eButtonType As ButtonType
            oFrmMessage.Text = captionForm
            oFrmMessage.lblMessageInformation.Text = strMessageInfor
            If enumButtonType = ButtonType.Ok Then
                oFrmMessage.btnOk.Text = clsSystem.GetLang("System.xml", 0, intLang, clsSystem.DirLang.SYS)
                oFrmMessage.btnYes.Visible = False
                oFrmMessage.btnNo.Visible = False
                oFrmMessage.btnOk.Visible = True
                oFrmMessage.btnOk.Focus()
            Else
                oFrmMessage.btnNo.Text = clsSystem.GetLang("System.xml", 1, intLang, clsSystem.DirLang.SYS)
                oFrmMessage.btnYes.Text = clsSystem.GetLang("System.xml", 2, intLang, clsSystem.DirLang.SYS)
                oFrmMessage.btnOk.Visible = False
                oFrmMessage.btnYes.Visible = True
                oFrmMessage.btnNo.Visible = True
                oFrmMessage.btnYes.Focus()
            End If
            If oForm Is Nothing Then
                oFrmMessage.ShowDialog()
            Else
                oFrmMessage.ShowDialog(oForm)
            End If
            dsLang.Dispose() : dsLang = Nothing
            eButtonType = oFrmMessage.GetButtonType()
            oFrmMessage.Close() : oFrmMessage.Dispose() : oFrmMessage = Nothing
            oForm.Focus()
            Return eButtonType
        Catch ex As Exception
            Throw New Exception("clsMessage: ShowMessage error!!")
        End Try
    End Function
End Class
