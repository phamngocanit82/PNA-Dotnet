Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class ButtonPlayPause
#Region "Variables"
    Public Enum PlayPauseButton
        Play = 0
        Pause = 1
    End Enum
    Public Enum StyleButton
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
    Public Enum StateButton
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
    <DllImport("user32")> _
     Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
    Private _PlayPause As PlayPauseButton = PlayPauseButton.Play
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _img(3) As Bitmap
    Private _strToolTip As String
#End Region
#Region "Properties"
    Public Property PlayPause() As PlayPauseButton
        Get
            Return _PlayPause
        End Get
        Set(ByVal Value As PlayPauseButton)
            _PlayPause = Value
            _getResBitmap()
            Invalidate()
        End Set
    End Property
    Public Property Style() As StyleButton
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleButton)
            _style = Value
            _getResBitmap()
            Invalidate()
        End Set
    End Property
    Public Property BToolTip() As String
        Get
            Return _strToolTip
        End Get
        Set(ByVal Value As String)
            _strToolTip = Value
            tipButton.RemoveAll()
            tipButton.SetToolTip(Me, Value)
        End Set
    End Property
#End Region
#Region "Methods"
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(MyBase.Handle, winRect)
            GetCursorPos(winPoint)
            If winPoint.X < winRect.Left Or winPoint.X > winRect.Right Then Return False
            If winPoint.Y < winRect.Top Or winPoint.Y > winRect.Bottom Then Return False
            Return True
        Catch ex As Exception

        End Try
    End Function
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    If _PlayPause = PlayPauseButton.Play Then
                        _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play0.png"))
                        _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play1.png"))
                        _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play2.png"))
                    Else
                        _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause0.png"))
                        _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause1.png"))
                        _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause2.png"))
                    End If
                Case StyleButton.Style2
                    If _PlayPause = PlayPauseButton.Play Then
                        _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play0.png"))
                        _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play1.png"))
                        _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play2.png"))
                    Else
                        _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause0.png"))
                        _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause1.png"))
                        _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause2.png"))
                    End If
                Case StyleButton.Style3
                    If _PlayPause = PlayPauseButton.Play Then
                        _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play0.png"))
                        _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play1.png"))
                        _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Play2.png"))
                    Else
                        _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause0.png"))
                        _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause1.png"))
                        _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Pause2.png"))
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleNormal(ByVal g As Graphics)
        g.DrawImage(_img(0), 0, 0, Width, Height)
    End Sub
    Private Sub _styleMouseMove(ByVal g As Graphics)
        g.DrawImage(_img(1), 0, 0, Width, Height)
    End Sub
    Private Sub _stylePress(ByVal g As Graphics)
        g.DrawImage(_img(2), 0, 0, Width, Height)
    End Sub
    Private Sub _styleButton(ByVal g As Graphics)
        Select Case _state
            Case StateButton.Normal
                _styleNormal(g)
            Case StateButton.MouseMove
                _styleMouseMove(g)
            Case StateButton.Press
                _stylePress(g)
        End Select
    End Sub
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            BToolTip = _strToolTip
            _styleButton(g)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    'Private Sub ButtonPlayPause_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Width = 36 : Height = 36
    '    Dim gp As New GraphicsPath
    '    gp.AddPie(0, 0, Width - 1, Height - 1, 0, 360)
    '    Region = New Region(gp)
    '    Invalidate()
    'End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateButton.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
                tmrButtonForm.Enabled = False
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.Press Then
                _state = StateButton.MouseMove
                Invalidate()
                tmrButtonForm.Enabled = True
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
                tmrButtonForm.Enabled = False
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButton(e.Graphics)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            If _PlayPause = PlayPauseButton.Play Then
                Width = 36 : Height = 36
                Dim gp As New GraphicsPath
                gp.AddPie(-1, -1, Width + 1, Height + 1, 0, 360)
                Region = New Region(gp)
            Else
                Width = 35 : Height = 35
                Dim gp As New GraphicsPath
                gp.AddPie(0, 0, Width - 2, Height - 2, 0, 360)
                Region = New Region(gp)
            End If
            Invalidate()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tmrButton_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrButtonForm.Tick
        Try
            If _isInnerXY() = False Then
                _state = StateButton.Normal
                tmrButtonForm.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
