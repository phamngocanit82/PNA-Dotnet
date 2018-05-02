Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmMain
#Region " Global Form "
    Private Shared _frmMain As frmMain
    Public Shared Property GlobalForm() As frmMain
        Get
            If _frmMain Is Nothing OrElse _frmMain.IsDisposed Then
                _frmMain = New frmMain
            End If
            Return _frmMain
        End Get
        Set(ByVal Value As frmMain)
            _frmMain = Value
        End Set
    End Property
#End Region
#Region "Struct"
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32")> _
     Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function FindWindowA(ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function SetParent(ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
    End Function

#End Region
#Region "Variables"
    Private _strLang As String = "Langague\XMLAccessRight.xml"
    Private _intMouseMove As Boolean
    Private _intX As Integer
    Private _intY As Integer
#End Region
#Region "Methods"
#Region "Config"
    Private Function _isInnerXYCaption() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblCaption.Handle, winRect)
            GetCursorPos(winPoint)
            If _intMouseMove Then
                Location = New Point(winPoint.X - _intX, winPoint.Y - _intY)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intX = winPoint.X - winRect.Left
                    _intY = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._isInnerXYCaption)", , True)
        End Try
    End Function
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(picTopMain.Handle, winRect)
            GetCursorPos(winPoint)
            If _intMouseMove Then
                Location = New Point(winPoint.X - _intX, winPoint.Y - _intY)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intX = winPoint.X - winRect.Left
                    _intY = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._isInnerXY)", , True)
        End Try
    End Function
    Private Sub _getResBitmapForm1(ByVal bolActivated As Boolean)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            If bolActivated Then
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Caption01.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form01.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form02.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form03.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form04.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form05.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form06.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form07.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form08.png"))
            Else
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Caption02.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form09.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form10.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form11.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form12.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form13.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form14.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form15.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form16.png"))
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._getResBitmapForm1)", , True)
        End Try
    End Sub
    Private Sub _getResBitmapForm2(ByVal bolActivated As Boolean)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            If bolActivated Then
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Caption03.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form17.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form18.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form19.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form20.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form21.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form22.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form23.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form24.png"))
            Else
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Caption04.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form25.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form26.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form27.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form28.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form29.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form30.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form31.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form32.png"))
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._getResBitmapForm2)", , True)
        End Try
    End Sub
    Private Sub _getResBitmapForm3(ByVal bolActivated As Boolean)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            If bolActivated Then
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Caption05.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form33.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form34.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form35.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form36.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form37.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form38.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form39.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form40.png"))
            Else
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Caption06.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form41.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form42.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form43.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form44.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form45.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form46.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form47.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Form48.png"))
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._getResBitmapForm3)", , True)
        End Try
    End Sub
    Private Sub _getSkin(ByVal bolActivated As Boolean)
        Try
            Select Case clsConfig.GetSkinPNA
                Case "Skins1"
                    _getResBitmapForm1(bolActivated)
                Case "Skins2"
                    _getResBitmapForm2(bolActivated)
                Case "Skins3"
                    _getResBitmapForm3(bolActivated)
            End Select

        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, "Langague\XMLMain.xml")
            lblCaption.Text = "        " & Me.Text
            btnFormClose.BToolTip = clsConfig.GetLanguage(1, "Langague\XMLMain.xml")
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(2, "Langague\XMLMain.xml")
            btnMinimize.BToolTip = clsConfig.GetLanguage(3, "Langague\XMLMain.xml")
            lblTask.Text = clsConfig.GetLanguage(6, "Langague\XMLMain.xml")
            MenuLang(Me)
            LoadTask(Me)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain._getLang)", , True)
        End Try
    End Sub
    Private Sub _loadConfig()
        _getLang()
    End Sub
#End Region
#Region "Forms"
    Private Sub FormLogin()
        Try
            Visible = False
            frmLogin.GlobalForm.ShowDialog()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormLogin)", , True)
        End Try
    End Sub
    Private Sub FormHRUser()
        Try
            If CheckRead("frmHRUser") = False Then
                Exit Sub
            End If
            Dim _frmHRUser As New frmHRUser
            _frmHRUser = New frmHRUser
            FormChildPNA1.AddForm(_frmHRUser)
            _frmHRUser.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRUser)", , True)
        End Try
    End Sub
    Private Sub FormHRChangePasss()
        Try
            If CheckRead("frmHRChangePass") = False Then
                Exit Sub
            End If
            Dim _frmHRChangePass As New frmHRChangePass
            _frmHRChangePass.ShowDialog()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRChangePasss)", , True)
        End Try
    End Sub
    Private Sub FormHRAccRight()
        Try
            If CheckRead("frmHRAccessRight") = False Then
                Exit Sub
            End If
            Dim _frmHRAccessRight As New frmHRAccessRight
            _frmHRAccessRight = New frmHRAccessRight
            FormChildPNA1.AddForm(_frmHRAccessRight)
            _frmHRAccessRight.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRAccRight)", , True)
        End Try
    End Sub
    Private Sub FormULProject()
        Try
            If CheckRead("frmProject") = False Then
                Exit Sub
            End If
            Dim _frmULProject As New frmULProject
            _frmULProject = New frmULProject
            FormChildPNA1.AddForm(_frmULProject)
            _frmULProject.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormULProject)", , True)
        End Try
    End Sub
    Private Sub FormULCustomer()
        Try
            If CheckRead("frmULCustomer") = False Then
                Exit Sub
            End If
            Dim _frmULCustomer As New frmULCustomer
            _frmULCustomer = New frmULCustomer
            FormChildPNA1.AddForm(_frmULCustomer)
            _frmULCustomer.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormULCustomer)", , True)
        End Try
    End Sub
    Private Sub FormULSupplier()
        Try
            If CheckRead("frmULSupplier") = False Then
                Exit Sub
            End If
            Dim _frmULSupplier As New frmULSupplier
            _frmULSupplier = New frmULSupplier
            FormChildPNA1.AddForm(_frmULSupplier)
            _frmULSupplier.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.mnuSupplier_Click)", , True)
        End Try
    End Sub
    Private Sub FormHRCountry()
        Try
            If CheckRead("frmHRCountry") = False Then
                Exit Sub
            End If
            Dim _frmHRCountry As New frmHRCountry
            _frmHRCountry = New frmHRCountry
            FormChildPNA1.AddForm(_frmHRCountry)
            _frmHRCountry.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRCountry)", , True)
        End Try
    End Sub
    Private Sub FormHRCompany()
        Try
            If CheckRead("frmHRCompany") = False Then
                Exit Sub
            End If
            Dim _frmHRCompany As New frmHRCompany
            _frmHRCompany = New frmHRCompany
            FormChildPNA1.AddForm(_frmHRCompany)
            _frmHRCompany.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRCompany)", , True)
        End Try
    End Sub
    Private Sub FormHRDepartment()
        Try
            If CheckRead("frmHRDepartment") = False Then
                Exit Sub
            End If
            Dim _frmHRDepartment As New frmHRDepartment
            _frmHRDepartment = New frmHRDepartment
            FormChildPNA1.AddForm(_frmHRDepartment)
            _frmHRDepartment.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.mnuHRDepartment_Click)", , True)
        End Try
    End Sub
    Private Sub FormHRJobTitle()
        Try
            If CheckRead("frmHRJobTitle") = False Then
                Exit Sub
            End If
            Dim _frmHRJobTitle As New frmHRJobTitle
            _frmHRJobTitle = New frmHRJobTitle
            FormChildPNA1.AddForm(_frmHRJobTitle)
            _frmHRJobTitle.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRJobTitle)", , True)
        End Try
    End Sub
    Private Sub FormHRLevel()
        Try
            If CheckRead("frmHRLevel") = False Then
                Exit Sub
            End If
            Dim _frmHRLevel As New frmHRLevel
            _frmHRLevel = New frmHRLevel
            FormChildPNA1.AddForm(_frmHRLevel)
            _frmHRLevel.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHRLevel)", , True)
        End Try
    End Sub
    Private Sub FormHREmployee()
        Try
            If CheckRead("frmEmployee") = False Then
                Exit Sub
            End If
            Dim _frmHREmployee As New frmHREmployee
            _frmHREmployee = New frmHREmployee
            FormChildPNA1.AddForm(_frmHREmployee)
            _frmHREmployee.Show()
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.FormHREmployee)", , True)
        End Try
    End Sub
#End Region
#Region "Process"
    Public Sub ClickTask(ByVal strValue As String)
        Select Case strValue
            Case clsConfig.GetLanguage(1, _strLang)
                FormLogin()
            Case clsConfig.GetLanguage(4, _strLang)
                FormHRUser()
            Case clsConfig.GetLanguage(5, _strLang)
                FormHRChangePasss()
            Case clsConfig.GetLanguage(6, _strLang)
                FormHRAccRight()
            Case clsConfig.GetLanguage(7, _strLang)
                If ShowInfor(Me, clsConfig.GetLanguage(5, "Langague\XMLMain.xml"), , InforButton.YesNo) = InforButton.Yes Then
                    Application.Exit()
                End If
            Case clsConfig.GetLanguage(12, _strLang)
                FormULProject()
            Case clsConfig.GetLanguage(13, _strLang)
                FormULCustomer()
            Case clsConfig.GetLanguage(14, _strLang)
                FormULSupplier()
            Case clsConfig.GetLanguage(17, _strLang)
                FormHRCountry()
            Case clsConfig.GetLanguage(18, _strLang)
                FormHRCompany()
            Case clsConfig.GetLanguage(19, _strLang)
                FormHRDepartment()
            Case clsConfig.GetLanguage(20, _strLang)
                FormHRJobTitle()
            Case clsConfig.GetLanguage(21, _strLang)
                FormHRLevel()
            Case clsConfig.GetLanguage(23, _strLang)
                FormHREmployee()
        End Select
    End Sub
#End Region
#End Region
#Region "Events"
#Region "picBorder"
#Region "lblCaption"
    Private Sub lblCaption_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCaption.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(2, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Normal
        Else
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(4, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub lblCaption_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseDown
        Try
            If _isInnerXYCaption() And e.Button = Windows.Forms.MouseButtons.Left Then
                _intMouseMove = True
            Else
                _intMouseMove = False
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.lblCaption_MouseDown)", , True)
        End Try
    End Sub
    Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXYCaption()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.lblCaption_MouseMove)", , True)
        End Try
    End Sub
    Private Sub lblCaption_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseUp
        _intMouseMove = False
    End Sub
#End Region
#Region "picTopMain"
    Private Sub picTopMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                _intMouseMove = True
            Else
                _intMouseMove = False
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picTopMain_MouseDown)", , True)
        End Try
    End Sub
    Private Sub picTopMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXY()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picTopMain_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picTopMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseUp
        _intMouseMove = False
    End Sub
#End Region
#Region "picLeft"
    Private Sub picLeft_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeft.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intX = e.X
        End If
    End Sub
    Private Sub picLeft_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeft.MouseMove
        Try
            Cursor = Cursors.SizeWE
            If _intMouseMove Then
                Me.Refresh()
                If _intX > e.X Then
                    SetBounds(Me.Left - Math.Abs(e.X), Me.Top, Me.Width + Math.Abs(e.X), Me.Height)
                Else
                    If Me.Width - Math.Abs(e.X) > 200 Then
                        SetBounds(Me.Left + Math.Abs(e.X), Me.Top, Me.Width - Math.Abs(e.X), Me.Height)
                    Else
                        SetBounds(Me.Right - 200, Me.Top, 200, Me.Height)
                    End If
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picLeft_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picLeft_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeft.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picLeft_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLeft.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#Region "picLeftTop"
    Private Sub picLeftTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeftTop.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intX = e.X
        End If
    End Sub
    Private Sub picLeftTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeftTop.MouseMove
        Try
            Cursor = Cursors.SizeWE
            If _intMouseMove Then
                Me.Refresh()
                If _intX > e.X Then
                    SetBounds(Me.Left - Math.Abs(e.X), Me.Top, Me.Width + Math.Abs(e.X), Me.Height)
                Else
                    If Me.Width - Math.Abs(e.X) > 200 Then
                        SetBounds(Me.Left + Math.Abs(e.X), Me.Top, Me.Width - Math.Abs(e.X), Me.Height)
                    Else
                        SetBounds(Me.Right - 200, Me.Top, 200, Me.Height)
                    End If
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picLeftTop_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picLeftTop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeftTop.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picLeftTop_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLeftTop.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#Region "picLeftBottom"
    Private Sub picLeftBottom_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeftBottom.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intX = e.X
            _intY = e.Y
        End If
    End Sub
    Private Sub picLeftBottom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeftBottom.MouseMove
        Try
            Cursor = Cursors.SizeNESW
            If _intMouseMove Then
                Me.Refresh()
                If _intX > e.X Then
                    SetBounds(Me.Left - Math.Abs(e.X), Me.Top, Me.Width + Math.Abs(e.X), Me.Height)
                Else
                    If Me.Width - Math.Abs(e.X) > 200 Then
                        SetBounds(Me.Left + Math.Abs(e.X), Me.Top, Me.Width - Math.Abs(e.X), Me.Height)
                    Else
                        SetBounds(Me.Right - 200, Me.Top, 200, Me.Height)
                    End If
                End If
                If _intY > e.Y Then
                    If Me.Height - Math.Abs(e.Y) > 100 Then
                        SetBounds(Me.Left, Me.Top, Me.Width, Me.Height - Math.Abs(e.Y))
                    Else
                        SetBounds(Me.Left, Me.Top, Me.Width, 100)
                    End If
                Else
                    SetBounds(Me.Left, Me.Top, Me.Width, Me.Height + Math.Abs(e.Y))
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picLeftBottom_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picLeftBottom_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picLeftBottom.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picLeftBottom_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picLeftBottom.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#Region "picBottom"
    Private Sub picBottom_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBottom.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intY = e.Y
        End If
    End Sub
    Private Sub picBottom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBottom.MouseMove
        Try
            Cursor = Cursors.SizeNS
            If _intMouseMove Then
                Me.Refresh()
                If _intY > e.Y Then
                    If Me.Height - Math.Abs(e.Y) > 100 Then
                        SetBounds(Me.Left, Me.Top, Me.Width, Me.Height - Math.Abs(e.Y))
                    Else
                        SetBounds(Me.Left, Me.Top, Me.Width, 100)
                    End If
                Else
                    SetBounds(Me.Left, Me.Top, Me.Width, Me.Height + Math.Abs(e.Y))
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picBottom_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picBottom_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBottom.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picBottom_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBottom.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#Region "picRightBottom"
    Private Sub picRightBottom_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRightBottom.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intX = e.X
            _intY = e.Y
        End If
    End Sub
    Private Sub picRightBottom_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRightBottom.MouseMove
        Try
            Cursor = Cursors.SizeNWSE
            If _intMouseMove Then
                Me.Refresh()
                If _intX > e.X Then
                    If Me.Width - Math.Abs(e.X) > 200 Then
                        SetBounds(Me.Left, Me.Top, Me.Width - Math.Abs(e.X), Me.Height)
                    Else
                        SetBounds(Me.Left, Me.Top, 200, Me.Height)
                    End If
                Else
                    SetBounds(Me.Left, Me.Top, Me.Width + Math.Abs(e.X), Me.Height)
                End If
                If _intY > e.Y Then
                    If Me.Height - Math.Abs(e.Y) > 100 Then
                        SetBounds(Me.Left, Me.Top, Me.Width, Me.Height - Math.Abs(e.Y))
                    Else
                        SetBounds(Me.Left, Me.Top, Me.Width, 100)
                    End If
                Else
                    SetBounds(Me.Left, Me.Top, Me.Width, Me.Height + Math.Abs(e.Y))
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picRightBottom_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picRightBottom_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRightBottom.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picRightBottom_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRightBottom.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#Region "picRight"
    Private Sub picRight_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRight.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intX = e.X
        End If
    End Sub
    Private Sub picRight_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRight.MouseMove
        Try
            Cursor = Cursors.SizeWE
            If _intMouseMove Then
                Me.Refresh()
                If _intX > e.X Then
                    If Me.Width - Math.Abs(e.X) > 200 Then
                        SetBounds(Me.Left, Me.Top, Me.Width - Math.Abs(e.X), Me.Height)
                    Else
                        SetBounds(Me.Left, Me.Top, 200, Me.Height)
                    End If
                Else
                    SetBounds(Me.Left, Me.Top, Me.Width + Math.Abs(e.X), Me.Height)
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picRight_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picRight_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRight.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picRight_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRight.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#Region "picRightTop"
    Private Sub picRightTop_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRightTop.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
            _intX = e.X
        End If
    End Sub
    Private Sub picRightTop_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRightTop.MouseMove
        Try
            Cursor = Cursors.SizeWE
            If _intMouseMove Then
                Me.Refresh()
                If _intX > e.X Then
                    If Me.Width - Math.Abs(e.X) > 200 Then
                        SetBounds(Me.Left, Me.Top, Me.Width - Math.Abs(e.X), Me.Height)
                    Else
                        SetBounds(Me.Left, Me.Top, 200, Me.Height)
                    End If
                Else
                    SetBounds(Me.Left, Me.Top, Me.Width + Math.Abs(e.X), Me.Height)
                End If
                Me.Refresh()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmMain.picRightTop_MouseMove)", , True)
        End Try
    End Sub
    Private Sub picRightTop_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picRightTop.MouseUp
        _intMouseMove = False
    End Sub
    Private Sub picRightTop_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRightTop.MouseLeave
        Cursor = Cursors.Default
        _intMouseMove = False
    End Sub
#End Region
#End Region
#Region "ButtonForm"
    Private Sub btnFormClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormClose.Click
        If ShowInfor(Me, clsConfig.GetLanguage(5, "Langague\XMLMain.xml"), , InforButton.YesNo) = InforButton.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub btnFormMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(2, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Normal
        Else
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(4, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub picTopMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picTopMain.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(2, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Normal
        Else
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(4, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        Else
            btnMinimize.BToolTip = clsConfig.GetLanguage(3, "Langague\XMLMain.xml")
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
#End Region
#Region "Main"
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Visible = False
        'GlobalForm() = Me
        'frmLogin.GlobalForm.ShowDialog()
        '_loadConfig()
        'FormChildPNA1.LoadConfig()
        'Left = 0 : Top = 0
        'Width = Screen.PrimaryScreen.Bounds.Width - 170
        'Height = Screen.PrimaryScreen.Bounds.Height
        'frmMainSlidebar.GlobalForm.Show()
    End Sub
    Private Sub frmMain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _getSkin(True)
    End Sub
    Private Sub frmMain_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        _getSkin(False)
    End Sub
#End Region
#End Region
    Private Sub mnuLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogout.Click
        FormLogin()
    End Sub
    Private Sub mnuUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUser.Click
        FormHRUser()
        FormChildPNA1.RemoveAll()
    End Sub
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If ShowInfor(Me, clsConfig.GetLanguage(5, "Langague\XMLMain.xml"), , InforButton.YesNo) = InforButton.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub mnuProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProject.Click
        FormULProject()
    End Sub
    Private Sub mnuSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSupplier.Click
        FormULSupplier()
    End Sub
    Private Sub mnuCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomer.Click
        FormULCustomer()
    End Sub
#Region "HR"
    Private Sub mnuHRCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHRCountry.Click
        FormHRCountry()
    End Sub
    Private Sub mnuHRCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHRCompany.Click
        FormHRCompany()
    End Sub
    Private Sub mnuHRDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHRDepartment.Click
        FormHRDepartment()
    End Sub
    Private Sub mnuHRJobTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHRJobTitle.Click
        FormHRJobTitle()
    End Sub
    Private Sub mnuHRHRLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHRHRLevel.Click
        FormHRLevel()
    End Sub
    Private Sub mnuHREmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHREmployee.Click
        FormHREmployee()
    End Sub
#End Region
    Private Sub mnuChaPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChaPass.Click
        FormHRChangePasss()
    End Sub
    Private Sub mnuAccRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAccRight.Click
        FormHRAccRight()
    End Sub
    Private Sub btnResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResize.Click
        Me.WindowState = FormWindowState.Normal
        Left = 0 : Top = 0
        Width = Screen.PrimaryScreen.Bounds.Width - 170
        Height = Screen.PrimaryScreen.Bounds.Height
        frmMainSlidebar.GlobalForm.Select()
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        ClickTask(TreeView1.SelectedNode().Text())
    End Sub
End Class