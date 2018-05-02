'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Public Class frmMessage
    Private enumButtonType As ButtonType = ButtonType.No
    Public ReadOnly Property GetButtonType() As ButtonType
        Get
            Return enumButtonType
        End Get
    End Property
    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Visible = False
        enumButtonType = ButtonType.Ok
    End Sub
    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Me.Visible = False
        enumButtonType = ButtonType.Yes
    End Sub
    Private Sub btnNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.Visible = False
        enumButtonType = ButtonType.No
    End Sub
    Private Sub frmMessage_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
End Class