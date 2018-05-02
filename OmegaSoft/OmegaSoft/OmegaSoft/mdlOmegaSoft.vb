Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Module mdlOmegaSoft
    Public strOIDEmployee As String = "ODI1-PDHUY", strOUserName As String = "huypham", bolOAdmin As Boolean = True
    Private _strLang As String = "Langague\XMLAccessRight.xml"
    Public Function CheckRead(ByVal strFName As String) As Boolean
        If bolOAdmin Then Return True
        Return clsHRAccessRight.IsExist(strOIDEmployee, strFName)
    End Function
    Public Function CheckAdd(ByVal strFName As String) As Boolean
        Try
            Dim bolFlag As Boolean = False
            Dim _clsHRAccessRight As New clsHRAccessRight
            _clsHRAccessRight.GetInfor(strOIDEmployee, "", strFName)
            bolFlag = _clsHRAccessRight.CAdd
            _clsHRAccessRight.DisposedAccessRight() : _clsHRAccessRight = Nothing
            Return bolFlag
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(mdlOmegaSoft.CheckAdd)", , True)
        End Try
    End Function
    Public Function CheckDelete(ByVal strFName As String) As Boolean
        Try
            Dim bolFlag As Boolean = False
            Dim _clsHRAccessRight As New clsHRAccessRight
            _clsHRAccessRight.GetInfor(strOIDEmployee, "", strFName)
            bolFlag = _clsHRAccessRight.CDelete
            _clsHRAccessRight.DisposedAccessRight() : _clsHRAccessRight = Nothing
            Return bolFlag
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(mdlOmegaSoft.CheckDelete)", , True)
        End Try
    End Function
    Public Function CheckUpdate(ByVal strFName As String) As Boolean
        Try
            Dim bolFlag As Boolean = False
            Dim _clsHRAccessRight As New clsHRAccessRight
            _clsHRAccessRight.GetInfor(strOIDEmployee, "", strFName)
            bolFlag = _clsHRAccessRight.CUpdate
            _clsHRAccessRight.DisposedAccessRight() : _clsHRAccessRight = Nothing
            Return bolFlag
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(mdlOmegaSoft.CheckUpdate)", , True)
        End Try
    End Function
    Public Function CheckSave(ByVal strFName As String) As Boolean
        Try
            Dim bolFlag As Boolean = False
            Dim _clsHRAccessRight As New clsHRAccessRight
            _clsHRAccessRight.GetInfor(strOIDEmployee, "", strFName)
            bolFlag = _clsHRAccessRight.CSave
            _clsHRAccessRight.DisposedAccessRight() : _clsHRAccessRight = Nothing
            Return bolFlag
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(mdlOmegaSoft.CheckSave)", , True)
        End Try
    End Function
    Public Sub MenuLang(ByVal frm As frmMain)
        Try
            With frm
                .mnuSystem.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLSystem.xml")
                .mnuLogout.Text = clsConfig.GetLanguage(1, "Langague\Menu\XMLSystem.xml")
                .mnuLanguage.Text = clsConfig.GetLanguage(2, "Langague\Menu\XMLSystem.xml")
                .mnuManUser.Text = clsConfig.GetLanguage(3, "Langague\Menu\XMLSystem.xml")
                .mnuUser.Text = clsConfig.GetLanguage(4, "Langague\Menu\XMLSystem.xml")
                .mnuChaPass.Text = clsConfig.GetLanguage(5, "Langague\Menu\XMLSystem.xml")
                .mnuAccRight.Text = clsConfig.GetLanguage(6, "Langague\Menu\XMLSystem.xml")
                .mnuExit.Text = clsConfig.GetLanguage(7, "Langague\Menu\XMLSystem.xml")

                .mnuTool.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTool.xml")
                .mnuFax.Text = clsConfig.GetLanguage(1, "Langague\Menu\XMLTool.xml")
                .mnuMail.Text = clsConfig.GetLanguage(2, "Langague\Menu\XMLTool.xml")

                .mnuUltility.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLUltility.xml")
                .mnuProject.Text = clsConfig.GetLanguage(1, "Langague\Menu\XMLUltility.xml")
                .mnuCustomer.Text = clsConfig.GetLanguage(2, "Langague\Menu\XMLUltility.xml")
                .mnuSupplier.Text = clsConfig.GetLanguage(3, "Langague\Menu\XMLUltility.xml")

                .mnuTask.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskHR.xml")
                .mnuHR.Text = clsConfig.GetLanguage(1, "Langague\Menu\XMLTaskHR.xml")
                .mnuHRCountry.Text = clsConfig.GetLanguage(2, "Langague\Menu\XMLTaskHR.xml")
                .mnuHRCompany.Text = clsConfig.GetLanguage(3, "Langague\Menu\XMLTaskHR.xml")
                .mnuHRDepartment.Text = clsConfig.GetLanguage(4, "Langague\Menu\XMLTaskHR.xml")
                .mnuHRJobTitle.Text = clsConfig.GetLanguage(5, "Langague\Menu\XMLTaskHR.xml")
                .mnuHRHRLevel.Text = clsConfig.GetLanguage(6, "Langague\Menu\XMLTaskHR.xml")
                .mnuHRManager.Text = clsConfig.GetLanguage(7, "Langague\Menu\XMLTaskHR.xml")
                .mnuHREmployee.Text = clsConfig.GetLanguage(8, "Langague\Menu\XMLTaskHR.xml")

                .mnuBus.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskBU.xml")
                .mnuStr.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskST.xml")
                .mnuArc.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskAR.xml")
                .mnuME.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskME.xml")
                .mnuPU.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskPU.xml")
                .mnuFin.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLTaskFI.xml")

                .mnuItem.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLList.xml")
                .mnuCusList.Text = clsConfig.GetLanguage(1, "Langague\Menu\XMLList.xml")
                .mnuSupList.Text = clsConfig.GetLanguage(2, "Langague\Menu\XMLList.xml")
                .mnuEmpList.Text = clsConfig.GetLanguage(3, "Langague\Menu\XMLList.xml")
                .mnuReport.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLReport.xml")
                .mnuEnt.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLEntertainment.xml")
                .mnuHelp.Text = clsConfig.GetLanguage(0, "Langague\Menu\XMLHelp.xml")
            End With
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(mdlOmegaSoft.MenuLang)", , True)
        End Try
    End Sub
    Public Sub LoadTask(ByVal frm As frmMain)
        Try
            Dim _clsTask As New clsHRAccessRight
            Dim oTableTask As New DataTable
            Dim nRow As Integer
            Dim intIndexNode1 As Integer = 0, intIndexNode2 As Integer = 0
            Dim intIndexNode3 As Integer = 0, intIndexNode4 As Integer = 0
            Dim intIndexNode5 As Integer = 0
            oTableTask = _clsTask.GetTableFormList()
            With frm.TreeView1
                .Nodes.Clear()
                .Nodes.Add("omega soft")
                For nRow = 0 To oTableTask.Rows.Count - 1
                    Select Case Len(oTableTask.Rows(nRow)(0)) - 1
                        Case 0
                            .Nodes(0).Nodes.Add(clsConfig.GetLanguage(oTableTask.Rows(nRow)(2), _strLang))
                            .Nodes(0).Nodes(intIndexNode1).ImageIndex = 1
                            .Nodes(0).Nodes(intIndexNode1).SelectedImageIndex = 1
                            intIndexNode1 = intIndexNode1 + 1
                            intIndexNode2 = 0
                        Case 1
                            .Nodes(0).Nodes(intIndexNode1 - 1).Nodes.Add(clsConfig.GetLanguage(oTableTask.Rows(nRow)(2), _strLang))
                            intIndexNode2 = intIndexNode2 + 1
                            intIndexNode3 = 0
                            If oTableTask.Rows(nRow)(1).ToString = "" Then
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).ImageIndex = 1
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).SelectedImageIndex = 1
                            Else
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).ImageIndex = 2
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).SelectedImageIndex = 2
                            End If
                        Case 2
                            .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes.Add(clsConfig.GetLanguage(oTableTask.Rows(nRow)(2), _strLang))
                            intIndexNode3 = intIndexNode3 + 1
                            intIndexNode4 = 0
                            If oTableTask.Rows(nRow)(1).ToString = "" Then
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).ImageIndex = 1
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).SelectedImageIndex = 1
                            Else
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).ImageIndex = 2
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).SelectedImageIndex = 2
                            End If
                        Case 3
                            .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes.Add(clsConfig.GetLanguage(oTableTask.Rows(nRow)(2), _strLang))
                            intIndexNode4 = intIndexNode4 + 1
                            intIndexNode5 = 0
                            If oTableTask.Rows(nRow)(1).ToString = "" Then
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).ImageIndex = 1
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).SelectedImageIndex = 1
                            Else
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).ImageIndex = 2
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).SelectedImageIndex = 2
                            End If
                        Case 4
                            .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).Nodes.Add(clsConfig.GetLanguage(oTableTask.Rows(nRow)(2), _strLang))
                            intIndexNode5 = intIndexNode5 + 1
                            If oTableTask.Rows(nRow)(1).ToString = "" Then
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).Nodes(intIndexNode5 - 1).ImageIndex = 1
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).Nodes(intIndexNode5 - 1).SelectedImageIndex = 1
                            Else
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).Nodes(intIndexNode5 - 1).ImageIndex = 2
                                .Nodes(0).Nodes(intIndexNode1 - 1).Nodes(intIndexNode2 - 1).Nodes(intIndexNode3 - 1).Nodes(intIndexNode4 - 1).Nodes(intIndexNode5 - 1).SelectedImageIndex = 2
                            End If
                    End Select
                Next
                .ExpandAll()
            End With
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(mdlOmegaSoft.LoadTask)", , True)
        End Try
    End Sub
End Module
