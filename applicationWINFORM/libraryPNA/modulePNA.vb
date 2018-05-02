'*************************************************************'
' Author   : An Pham Ngoc (IT)                                ' 
' Mail     : phamngocanthi@yahoo.com, phamngocanthi@gmail.com ' 
' Gender   : Male                                             '
' Age      : 1982                                             '
' National : VietNam                                          ' 
' Jobtitle : HCM                                              ' 
' District : 7                                                ' 
'*************************************************************'
Imports libraryPNA.clsMessage
Public Module modulePNA
    Public Enum ButtonType
        Ok = 0
        Yes = 1
        No = 2
        YesNo = 3
    End Enum
    Public Enum IconType
        Message = 0
        ShowForm = 1
        Add = 2
        Delete = 3
        Update = 4
        Save = 5
        IsExist = 6
        Query = 7
        Search = 8
        Print = 9
    End Enum
    Public Enum AdminType
        Administrator = 0
        AdminACC = 1
        AdminHR = 2
        AdminPU = 3
        AdminWH = 6
        User = 10
    End Enum
    Public Enum SelectSQLType
        Normal = 0
        NormalAndCondition = 1
        NormarlAndConditionAndQuery = 2
    End Enum

    Public ConfigFont
    Public ConfigSkin
    Public ConfigLang
    Public ConfigFormat
    Public ConfigFile

    Public UserName As String = ""
    Public IDEmployee As String = ""
    Public Admin As AdminType = AdminType.User
    Public SelectSQL As SelectSQLType = SelectSQLType.Normal

    Public NumForm As Integer = 0
    Public FormMain As Object
    Public FormTmp As Object

    Public Sub NewForm(ByVal oForm As Object)
        Try
            If FormMain.panelBackground.Visible Then FormMain.panelBackground.Visible = False
            FormTmp = oForm
            oForm.MdiParent = FormMain
            oForm.Show()
            NumForm = NumForm + 1
        Catch ex As Exception

        End Try
    End Sub
    Public Function CheckShowForm(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
                                  Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
                                  Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
                                  Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
        Return True
        ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.ShowForm)

    End Function
    Public Function CheckAdd(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
                             Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
                             Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
                             Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
        Return True
        ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.Add)

    End Function
    Public Function CheckDelete(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
                                Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
                                Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
                                Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
        Return True
        ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.Delete)

    End Function
    Public Function CheckUpdate(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
                                Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
                                Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
                                Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
        Return True
        ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.Update)

    End Function
    Public Function CheckSave(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
                              Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
                              Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
                              Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
        Return True
        ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.Save)

    End Function
    Public Function CheckPrint(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
                               Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
                               Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
                               Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
        Return True
        ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.Print)

    End Function
    'Public Function CheckSearch(Optional ByVal oForm As Object = Nothing, Optional ByVal strCaptionForm As String = "", _
    '                            Optional ByVal strMessageInfor As String = "", Optional ByVal intLang As Integer = 0, _
    '                            Optional ByVal enumButonType As ButtonType = ButtonType.Ok, _
    '                            Optional ByVal enumIconType As IconType = IconType.Message) As Boolean
    '    Return True
    '    ShowMessage(oForm, strCaptionForm, strMessageInfor, intLang, ButtonType.Ok, IconType.Print)

    'End Function
End Module
