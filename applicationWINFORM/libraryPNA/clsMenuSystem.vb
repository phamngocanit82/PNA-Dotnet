'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports DevExpress
Imports DevExpress.XtraBars
Public Class clsMenuSystem
#Region "InitialMenuSystem"
    Private frmMain As Object
    Private mnuSysSkins As New BarSubItem
    Public Sub InitialMenuSystem(ByRef oForm As Object)
        With oForm
            Dim mnuSysLogout As New BarButtonItem
            mnuSysLogout.Name = "mnuSysLogout"
            mnuSysLogout.Id = .BarManager1.GetNewItemId()
            mnuSysLogout.Caption = "&Logout"
            .mnuSystem.AddItem(mnuSysLogout)
            AddHandler mnuSysLogout.ItemClick, AddressOf onclick_mnuSysLogout

            Dim mnuSysChangePassword As New BarButtonItem
            mnuSysChangePassword.Name = "mnuSysChangePassword"
            mnuSysChangePassword.Id = .BarManager1.GetNewItemId()
            mnuSysChangePassword.Caption = "&Change password"
            .mnuSystem.AddItem(mnuSysChangePassword)
            AddHandler mnuSysChangePassword.ItemClick, AddressOf onclick_mnuSysChangePassword

            Dim mnuSysConfigure As New BarButtonItem
            mnuSysConfigure.Name = "mnuSysConfigure"
            mnuSysConfigure.Id = .BarManager1.GetNewItemId()
            mnuSysConfigure.Caption = "Confi&gure"
            .mnuSystem.AddItem(mnuSysConfigure)
            AddHandler mnuSysConfigure.ItemClick, AddressOf onclick_mnuSysConfigure

            Dim mnuSysBackupDatabase As New BarButtonItem
            mnuSysBackupDatabase.Name = "mnuSysBackupDatabase"
            mnuSysBackupDatabase.Id = .BarManager1.GetNewItemId()
            mnuSysBackupDatabase.Caption = "&Backup database"
            .mnuSystem.AddItem(mnuSysBackupDatabase)
            AddHandler mnuSysBackupDatabase.ItemClick, AddressOf onclick_mnuSysBackupDatabase

            Dim mnuSysRestoreDatabase As New BarButtonItem
            mnuSysRestoreDatabase.Name = "mnuSysRestoreDatabase"
            mnuSysRestoreDatabase.Id = .BarManager1.GetNewItemId()
            mnuSysRestoreDatabase.Caption = "&Restore database"
            .mnuSystem.AddItem(mnuSysRestoreDatabase)
            AddHandler mnuSysRestoreDatabase.ItemClick, AddressOf onclick_mnuSysRestoreDatabase

            Dim mnuSysAccessRight As New BarSubItem
            mnuSysAccessRight.Name = "mnuSysAccessRight"
            mnuSysAccessRight.Id = .BarManager1.GetNewItemId()
            mnuSysAccessRight.Caption = "Access right"
            .mnuSystem.AddItem(mnuSysAccessRight)

            Dim mnuSysInitialUsers As New BarButtonItem
            mnuSysInitialUsers.Name = "mnuSysInitialUsers"
            mnuSysInitialUsers.Id = .BarManager1.GetNewItemId()
            mnuSysInitialUsers.Caption = "&Initial users"
            mnuSysAccessRight.AddItem(mnuSysInitialUsers)
            AddHandler mnuSysInitialUsers.ItemClick, AddressOf onclick_mnuSysInitialUsers

            Dim mnuSysPermissionUsers As New BarButtonItem
            mnuSysPermissionUsers.Name = "mnuSysPermissionUsers"
            mnuSysPermissionUsers.Id = .BarManager1.GetNewItemId()
            mnuSysPermissionUsers.Caption = "&Permission for users"
            mnuSysAccessRight.AddItem(mnuSysPermissionUsers)
            AddHandler mnuSysPermissionUsers.ItemClick, AddressOf onclick_mnuSysPermissionUsers

            Dim mnuSysUsersManagement As New BarButtonItem
            mnuSysUsersManagement.Name = "mnuSysUsersManagement"
            mnuSysUsersManagement.Id = .BarManager1.GetNewItemId()
            mnuSysUsersManagement.Caption = "Users &management"
            mnuSysAccessRight.AddItem(mnuSysUsersManagement)
            AddHandler mnuSysUsersManagement.ItemClick, AddressOf onclick_mnuSysUsersManagement

            Dim mnuSysLanguages As New BarSubItem
            mnuSysLanguages.Name = "mnuSysLanguages"
            mnuSysLanguages.Id = .BarManager1.GetNewItemId()
            mnuSysLanguages.Caption = "Languages"
            .mnuSystem.AddItem(mnuSysLanguages)

            Dim mnuSysEnglish As New BarCheckItem
            mnuSysEnglish.Name = "mnuSysEnglish"
            mnuSysEnglish.Id = .BarManager1.GetNewItemId()
            mnuSysEnglish.Caption = "&English"
            mnuSysLanguages.AddItem(mnuSysEnglish)
            AddHandler mnuSysEnglish.ItemClick, AddressOf onclick_mnuSysEnglish

            Dim mnuSysVietnamese As New BarCheckItem
            mnuSysVietnamese.Name = "mnuSysVietnamese"
            mnuSysVietnamese.Id = .BarManager1.GetNewItemId()
            mnuSysVietnamese.Caption = "&Vietnamese"
            mnuSysLanguages.AddItem(mnuSysVietnamese)
            AddHandler mnuSysVietnamese.ItemClick, AddressOf onclick_mnuSysVietnamese

            Dim mnuSysCalculator As New BarButtonItem
            mnuSysCalculator.Name = "mnuSysLanguages"
            mnuSysCalculator.Id = .BarManager1.GetNewItemId()
            mnuSysCalculator.Caption = "Calculator"
            .mnuSystem.AddItem(mnuSysCalculator)
            AddHandler mnuSysCalculator.ItemClick, AddressOf onclick_mnuSysCalculator

            mnuSysSkins.Name = "mnuSysSkins"
            mnuSysSkins.Id = .BarManager1.GetNewItemId()
            mnuSysSkins.Caption = "Skins"
            .mnuSystem.AddItem(mnuSysSkins)

            Dim strArray As String() = {"Windows XP", "Office XP", "Office 2000", "Office 2003"}
            For i As Integer = 0 To strArray.Length - 1
                Dim item As BarCheckItem = New BarCheckItem()
                item.Name = strArray(i)
                item.Id = .BarManager1.GetNewItemId()
                item.Caption = strArray(i)
                mnuSysSkins.AddItem(item)
                AddHandler item.ItemClick, AddressOf onSkinsWindowXP
            Next
            For Each cnt As DevExpress.Skins.SkinContainer In DevExpress.Skins.SkinManager.Default.Skins
                Dim item As BarCheckItem = New BarCheckItem()
                item.Name = cnt.SkinName
                item.Id = .BarManager1.GetNewItemId()
                item.Caption = cnt.SkinName
                mnuSysSkins.AddItem(item)
                AddHandler item.ItemClick, AddressOf onSkinsOthers
            Next cnt

            Dim mnuSysExit As New BarButtonItem
            mnuSysExit.Name = "mnuSysExit"
            mnuSysExit.Id = .BarManager1.GetNewItemId()
            mnuSysExit.Caption = "&Exit"
            .mnuSystem.AddItem(mnuSysExit)
            AddHandler mnuSysExit.ItemClick, AddressOf onclick_mnuSysExit

        End With
        If frmMain Is Nothing Then frmMain = oForm
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue")
    End Sub
    Private Sub onclick_mnuSysLogout(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysChangePassword(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysConfigure(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysBackupDatabase(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysRestoreDatabase(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysInitialUsers(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysPermissionUsers(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysUsersManagement(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysEnglish(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysVietnamese(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onclick_mnuSysCalculator(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
    Private Sub onSkinsWindowXP(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        frmMain.BarManager1.GetController().PaintStyleName = Replace(e.Item.Caption, " ", "")
        DevExpress.Skins.SkinManager.DisableFormSkins()
        DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        For i As Integer = 0 To mnuSysSkins.ItemLinks.Count - 1
            If e.Item.Caption <> mnuSysSkins.ItemLinks(i).Caption Then
                DirectCast(mnuSysSkins.ItemLinks(i).Item, BarCheckItem).Checked = False
            End If
        Next
    End Sub
    Private Sub onSkinsOthers(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        frmMain.BarManager1.GetController().PaintStyleName = e.Item.Caption
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption)
        For i As Integer = 0 To mnuSysSkins.ItemLinks.Count - 1
            If e.Item.Caption <> mnuSysSkins.ItemLinks(i).Caption Then
                DirectCast(mnuSysSkins.ItemLinks(i).Item, BarCheckItem).Checked = False
            End If
        Next
    End Sub
    Private Sub onclick_mnuSysExit(ByVal sender As Object, ByVal e As ItemClickEventArgs)
    End Sub
   
#End Region
    Public Sub setFontmnuSystem(ByRef cn As Windows.Forms.Control)

    End Sub
End Class
