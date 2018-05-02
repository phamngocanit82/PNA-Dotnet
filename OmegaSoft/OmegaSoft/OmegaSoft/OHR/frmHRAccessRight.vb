Imports VB = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmHRAccessRight
#Region " Global Form"
    Private Shared _frmHRAccessRight As frmHRAccessRight
    Public Shared Property GlobalForm() As frmHRAccessRight
        Get
            If _frmHRAccessRight Is Nothing OrElse _frmHRAccessRight.IsDisposed Then
                _frmHRAccessRight = New frmHRAccessRight
            End If
            Return _frmHRAccessRight
        End Get
        Set(ByVal Value As frmHRAccessRight)
            _frmHRAccessRight = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\XMLAccessRight.xml"
    Private _strLang2 As String = "Langague\OHR\XMLHRAccessRight.xml"
    Private strIDEmployee As String
#End Region
#Region "Methods"
#Region "Config"
    Private Sub _getSkin()
        Try
            Select Case clsConfig.GetSkinPNA
                Case "Skins1"

                Case "Skins2"

                Case "Skins3"

            End Select
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang2)
            lblEmployee.Text = clsConfig.GetLanguage(1, _strLang2)
            lblTask.Text = clsConfig.GetLanguage(2, _strLang2)
            grdTask.Rows(0)(2) = clsConfig.GetLanguage(3, _strLang2)
            grdTask.Rows(0)(3) = clsConfig.GetLanguage(4, _strLang2)
            grdTask.Rows(0)(4) = clsConfig.GetLanguage(5, _strLang2)
            grdTask.Rows(0)(5) = clsConfig.GetLanguage(6, _strLang2)
            tbrSave.ToolTipText = clsConfig.GetLanguage(6, _strLang2)
            tbrRefesh.ToolTipText = clsConfig.GetLanguage(7, _strLang2)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._getLang)", , True)
        End Try
    End Sub
    Public Sub LoadConfig()
        _getSkin()
        _getLang()
    End Sub
#End Region
#Region "Others"
    Private Sub _loadGridEmployee()
        Try
            Dim _clsHRCompany As New clsHRCompany
            Dim _clsHRDepartment As clsHRAccessRight = Nothing
            Dim _clsHREmployee As clsHRAccessRight = Nothing
            Dim oTableCompany As New DataTable
            Dim oTableDepartment As DataTable = Nothing
            Dim oTableEmployee As DataTable = Nothing
            Dim i As Integer, j As Integer, k As Integer, nRow As Integer = 1
            oTableCompany = _clsHRCompany.GetTable
            grdEmployee.Rows.Count = 1
            grdEmployee.Tree.Column = 1
            For i = 0 To oTableCompany.Rows.Count - 1
                grdEmployee.Rows.InsertNode(nRow, 0)
                grdEmployee.Rows(nRow)(1) = oTableCompany.Rows(i)(2)
                grdEmployee.Rows(nRow).StyleNew.BackColor = Color.FromArgb(27, 153, 234)
                grdEmployee.Rows(nRow).StyleNew.ForeColor = Color.White
                nRow = nRow + 1
                If oTableDepartment Is Nothing Then
                    oTableDepartment = New DataTable
                    _clsHRDepartment = New clsHRAccessRight
                End If
                oTableDepartment = _clsHRDepartment.GetTableDepartment(oTableCompany.Rows(i)(1))
                For j = 0 To oTableDepartment.Rows.Count - 1
                    grdEmployee.Rows.InsertNode(nRow, 1)
                    grdEmployee.Rows(nRow)(1) = oTableDepartment.Rows(j)(2)
                    grdEmployee.Rows(nRow).StyleNew.BackColor = Color.FromArgb(149, 216, 251)
                    nRow = nRow + 1
                    If oTableEmployee Is Nothing Then
                        oTableEmployee = New DataTable
                        _clsHREmployee = New clsHRAccessRight
                    End If
                    oTableEmployee = _clsHREmployee.GetTableEmployee(oTableDepartment.Rows(j)(1))
                    For k = 0 To oTableEmployee.Rows.Count - 1
                        grdEmployee.Rows.InsertNode(nRow, 2)
                        grdEmployee.Rows(nRow)(1) = oTableEmployee.Rows(k)(1)
                        grdEmployee.Rows(nRow)(2) = oTableEmployee.Rows(k)(0)
                        grdEmployee.Rows(nRow).StyleNew.BackColor = Color.White
                        nRow = nRow + 1
                    Next
                    oTableEmployee.Dispose() : oTableEmployee = Nothing
                    _clsHREmployee.DisposedAccessRight() : _clsHREmployee = Nothing
                Next
                oTableDepartment.Dispose() : oTableDepartment = Nothing
                _clsHRDepartment.DisposedAccessRight() : _clsHRDepartment = Nothing
            Next
            grdEmployee.Refresh()
            oTableCompany.Dispose() : oTableCompany = Nothing
            _clsHRCompany.DisposedCompany() : _clsHRCompany = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._loadGridEmployee)", , True)
        End Try
    End Sub
    Private Sub _loadGridTask()
        Try
            Dim _clsTask As New clsHRAccessRight
            Dim oTableTask As New DataTable
            Dim nRow As Integer
            oTableTask = _clsTask.GetTableFormList()
            grdTask.Rows.Count = 1
            grdTask.Tree.Column = 1
            For nRow = 0 To oTableTask.Rows.Count - 1
                grdTask.Rows.InsertNode(nRow + 1, Len(oTableTask.Rows(nRow)(0)) - 1)
                grdTask.Rows(nRow + 1)(1) = clsConfig.GetLanguage(oTableTask.Rows(nRow)(2), _strLang)
                grdTask.Rows(nRow + 1)(7) = oTableTask.Rows(nRow)(0)
                Select Case Len(oTableTask.Rows(nRow)(0)) - 1
                    Case 0
                        grdTask.Rows(nRow + 1).StyleNew.BackColor = Color.FromArgb(27, 153, 234)
                        grdTask.Rows(nRow + 1).StyleNew.ForeColor = Color.White
                    Case 1, 2, 3, 4
                        If oTableTask.Rows(nRow)(1).ToString = "" Then
                            grdTask.Rows(nRow + 1).StyleNew.BackColor = Color.FromArgb(149, 216, 251)
                        Else
                            grdTask.Rows(nRow + 1)(6) = oTableTask.Rows(nRow)(1)
                            grdTask.Rows(nRow + 1).StyleNew.BackColor = Color.White
                            grdTask.SetCellCheck(nRow + 1, 1, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                            grdTask.SetCellCheck(nRow + 1, 2, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                            grdTask.SetCellCheck(nRow + 1, 3, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                            grdTask.SetCellCheck(nRow + 1, 4, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                            grdTask.SetCellCheck(nRow + 1, 5, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                        End If
                End Select
            Next
            grdTask.AutoResize = True
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._loadGridTask)", , True)
        End Try
    End Sub
    Private Sub _loadAccessRight(ByVal strIDEmployee As String)
        Try
            Dim oTableAccessRight As New DataTable
            Dim _clsHRAccessRight As New clsHRAccessRight
            Dim i As Integer, j As Integer
            oTableAccessRight = _clsHRAccessRight.GetTable(strIDEmployee)
            For i = 0 To oTableAccessRight.Rows.Count - 1
                For j = 1 To grdTask.Rows.Count - 1
                    If oTableAccessRight.Rows(i)(1) = grdTask.Rows(j)(7) Then
                        grdTask.SetCellCheck(j, 1, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        If CBool(oTableAccessRight.Rows(i)(3)) Then
                            grdTask.SetCellCheck(j, 2, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        Else
                            grdTask.SetCellCheck(j, 2, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                        End If
                        If CBool(oTableAccessRight.Rows(i)(4)) Then
                            grdTask.SetCellCheck(j, 3, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        Else
                            grdTask.SetCellCheck(j, 3, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                        End If
                        If CBool(oTableAccessRight.Rows(i)(5)) Then
                            grdTask.SetCellCheck(j, 4, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        Else
                            grdTask.SetCellCheck(j, 4, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                        End If
                        If CBool(oTableAccessRight.Rows(i)(6)) Then
                            grdTask.SetCellCheck(j, 5, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        Else
                            grdTask.SetCellCheck(j, 5, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                        End If
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._loadAccessRight)", , True)
        End Try
    End Sub
    Private Sub _setAccessRight(ByVal _clsHRAccessRight As clsHRAccessRight, ByVal i As Integer)
        Try
            _clsHRAccessRight.IDEmployee = strIDEmployee
            _clsHRAccessRight.IDForm = grdTask.Rows(i)(7)
            _clsHRAccessRight.FName = grdTask.Rows(i)(6)
            If grdTask.GetCellCheck(i, 2) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                _clsHRAccessRight.CAdd = True
            Else
                _clsHRAccessRight.CAdd = False
            End If
            If grdTask.GetCellCheck(i, 3) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                _clsHRAccessRight.CDelete = True
            Else
                _clsHRAccessRight.CDelete = False
            End If
            If grdTask.GetCellCheck(i, 4) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                _clsHRAccessRight.CUpdate = True
            Else
                _clsHRAccessRight.CUpdate = False
            End If
            If grdTask.GetCellCheck(i, 5) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                _clsHRAccessRight.CSave = True
            Else
                _clsHRAccessRight.CSave = False
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._setAccessRight)", , True)
        End Try
    End Sub
    Private Sub _grdEmployeeClick()
        Try
            If grdEmployee.Rows(grdEmployee.RowSel)(2) = "" Then
                strIDEmployee = ""
                grdEmployee.Rows(0)(1) = ""
                _refeshTaskCheck()
            Else
                'Dim _clsHRUser As New clsHRUser
                strIDEmployee = grdEmployee.Rows(grdEmployee.RowSel)(2)
                grdEmployee.Rows(0)(1) = grdEmployee.Rows(grdEmployee.RowSel)(1)
                '_clsHRUser.GetInforEmployee(strIDEmployee)
                'If _clsHRUser.Admin Then
                '_refeshTaskCheck(True)
                'Else
                _refeshTaskCheck()
                _loadAccessRight(strIDEmployee)
                'End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._grdEmployeeClick)", , True)
        End Try
    End Sub
    Private Sub _grdTaskClick()
        Try
            If strIDEmployee = "" Then Exit Sub
            If grdTask.GetCellCheck(grdTask.RowSel, grdTask.ColSel) <> C1.Win.C1FlexGrid.CheckEnum.None Then
                If grdTask.ColSel = 1 Then
                    If grdTask.GetCellCheck(grdTask.RowSel, grdTask.ColSel) = C1.Win.C1FlexGrid.CheckEnum.Unchecked Then
                        grdTask.SetCellCheck(grdTask.RowSel, grdTask.ColSel, C1.Win.C1FlexGrid.CheckEnum.Checked)
                    Else
                        grdTask.SetCellCheck(grdTask.RowSel, grdTask.ColSel, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    End If
                Else
                    If grdTask.GetCellCheck(grdTask.RowSel, 1) = C1.Win.C1FlexGrid.CheckEnum.Checked And grdTask.GetCellCheck(grdTask.RowSel, 2) <> C1.Win.C1FlexGrid.CheckEnum.None Then
                        If grdTask.GetCellCheck(grdTask.RowSel, grdTask.ColSel) = C1.Win.C1FlexGrid.CheckEnum.Unchecked Then
                            grdTask.SetCellCheck(grdTask.RowSel, grdTask.ColSel, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        Else
                            grdTask.SetCellCheck(grdTask.RowSel, grdTask.ColSel, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                        End If
                    End If
                End If
                If grdTask.ColSel = 1 And grdTask.GetCellCheck(grdTask.RowSel, 1) = C1.Win.C1FlexGrid.CheckEnum.Unchecked And grdTask.GetCellCheck(grdTask.RowSel, 2) <> C1.Win.C1FlexGrid.CheckEnum.None Then
                    grdTask.SetCellCheck(grdTask.RowSel, 2, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(grdTask.RowSel, 3, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(grdTask.RowSel, 4, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(grdTask.RowSel, 5, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                End If
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._grdTaskClick)", , True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _save()
        Try
            If strIDEmployee = "" Then Exit Sub
            If ShowInfor(frmMain.GlobalForm, clsConfig.GetLanguage(8, _strLang2), , InforButton.YesNo) = InforButton.Yes Then
                Dim i As Integer
                Dim _clsHRAccessRight As New clsHRAccessRight
                clsHRAccessRight.Delete(strIDEmployee)
                For i = 1 To grdTask.Rows.Count - 1
                    If grdTask.GetCellCheck(i, 1) <> C1.Win.C1FlexGrid.CheckEnum.None Then
                        If grdTask.GetCellCheck(i, 1) = C1.Win.C1FlexGrid.CheckEnum.Checked Then
                            _setAccessRight(_clsHRAccessRight, i)
                            _clsHRAccessRight.Add()
                        End If
                    End If
                Next
                _clsHRAccessRight.DisposedAccessRight() : _clsHRAccessRight = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._save)", "frmHRAccessRight._save", True)
        End Try
    End Sub
    Private Sub _refeshTaskCheck(Optional ByVal bolAdmin As Boolean = False)
        Try
            Dim i As Integer
            For i = 1 To grdTask.Rows.Count - 1
                If bolAdmin = False And grdTask.GetCellCheck(i, 1) <> C1.Win.C1FlexGrid.CheckEnum.None Then
                    grdTask.SetCellCheck(i, 1, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(i, 2, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(i, 3, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(i, 4, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                    grdTask.SetCellCheck(i, 5, C1.Win.C1FlexGrid.CheckEnum.Unchecked)
                Else
                    If bolAdmin And grdTask.GetCellCheck(i, 1) <> C1.Win.C1FlexGrid.CheckEnum.None Then
                        grdTask.SetCellCheck(i, 1, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        grdTask.SetCellCheck(i, 2, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        grdTask.SetCellCheck(i, 3, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        grdTask.SetCellCheck(i, 4, C1.Win.C1FlexGrid.CheckEnum.Checked)
                        grdTask.SetCellCheck(i, 5, C1.Win.C1FlexGrid.CheckEnum.Checked)
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _refesh()
        Try
            _loadGridEmployee()
            _loadGridTask()
            grdEmployee.Cols(0).Width = 20
            grdEmployee.Cols(1).Width = 320
            grdTask.Cols(0).Width = 20
            grdTask.Cols(1).Width = 340
            grdTask.Cols(2).Width = 60
            grdTask.Cols(3).Width = 60
            grdTask.Cols(4).Width = 60
            grdTask.Cols(5).Width = 60
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRAccessRight._refesh)", "frmHRAccessRight._refesh", True)
        End Try
    End Sub
#End Region
#End Region
#Region "Events"
#Region "HRAccessRight"
    Private Sub frmHRAccessRight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GlobalForm = Me
        LoadConfig()
        _loadGridEmployee()
        _loadGridTask()
    End Sub
    Private Sub frmHRAccessRight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.Control + Keys.S Then
            _save()
        End If
    End Sub
#End Region
#Region "Others"
    Private Sub tbrSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrSave.Click
        _save()
    End Sub
    Private Sub tbrRefesh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrRefesh.Click
        _refesh()
    End Sub
    Private Sub grdEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdEmployee.Click
        _grdEmployeeClick()
    End Sub
    Private Sub grdTask_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdTask.KeyDown
        If e.KeyCode = Keys.Space Then _grdTaskClick()
    End Sub
    Private Sub grdTask_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdTask.MouseDoubleClick
        _grdTaskClick()
    End Sub
#End Region
#End Region
End Class