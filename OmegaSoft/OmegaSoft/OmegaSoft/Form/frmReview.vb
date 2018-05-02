Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class frmReview
#Region " Global Form "
    Private Shared _frmReview As frmReview
    Public Shared Property GlobalForm() As frmReview
        Get
            If _frmReview Is Nothing OrElse _frmReview.IsDisposed Then
                _frmReview = New frmReview
            End If
            Return _frmReview
        End Get
        Set(ByVal Value As frmReview)
            _frmReview = Value
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
    Private _intMouseMove As Boolean
    Private _intX As Integer
    Private _intY As Integer
#End Region
#Region "Methods"
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview._isInnerXYCaption)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview._isInnerXY)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview._getResBitmapForm1)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview._getResBitmapForm2)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview._getResBitmapForm3)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, "Langague\XMLMain.xml")
            btnFormClose.BToolTip = clsConfig.GetLanguage(1, "Langague\XMLMain.xml")
            btnFormMaximize.BToolTip = clsConfig.GetLanguage(2, "Langague\XMLMain.xml")
            btnMinimize.BToolTip = clsConfig.GetLanguage(3, "Langague\XMLMain.xml")
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._getLang)", , True)
        End Try
    End Sub
    Private Sub _loadConfig()
        _getLang()
    End Sub
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.lblCaption_MouseDown)", , True)
        End Try
    End Sub
    Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXYCaption()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.lblCaption_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picTopMain_MouseDown)", , True)
        End Try
    End Sub
    Private Sub picTopMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXY()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picTopMain_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picLeft_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picLeftTop_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picLeftBottom_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picBottom_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picRightBottom_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picRight_MouseMove)", , True)
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
            ShowInfor(Me, "", ex.Message.ToString & "(frmReview.picRightTop_MouseMove)", , True)
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
        Me.Close()
        Me.Dispose()
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
#Region "Review"
    Private Sub frmReview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _loadConfig()
        GlobalForm = Me
    End Sub
    Private Sub frmReview_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _getSkin(True)
    End Sub
    Private Sub frmReview_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        _getSkin(False)
    End Sub
#End Region
#End Region
End Class