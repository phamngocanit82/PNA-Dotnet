'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'**************************************************************
Imports DevExpress
Imports DevExpress.XtraBars
Imports libraryPNA
Public Class frmMain
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _clsMenuSystem As New libraryPNA.clsMenuSystem
        Dim _clsMenuItems As New libraryPNA.clsMenuItems
        Dim _frmLogin As New frmLogin
        _clsMenuItems.InitialMenuItems(Me)
        _clsMenuSystem.InitialMenuSystem(Me)
        FormMain = Me
        _frmLogin.Show(Me)
    End Sub
    Private Sub XtraTabbedMdiManager1_PageRemoved(ByVal sender As System.Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        NumForm = NumForm - 1
        If NumForm = 0 Then panelBackground.Visible = True
    End Sub
    
End Class