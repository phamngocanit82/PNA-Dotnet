Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonPNA2), "ButtonPNA2.bmp")> _
Public Class ButtonPNA2
#Region "ClassButtonPNA2"
#Region "Enum/Struct"
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
#End Region
#Region "Variables"
    Private _img(3) As Bitmap
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _width As Integer, _height As Integer
    Private _bolFocus As Boolean = False
    Private _strText As String
#End Region
#Region "Properties"
    Public Property Style() As StyleButton
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleButton)
            _style = Value
            _getResBitmap()
            _styleButton()
            Invalidate()
        End Set
    End Property
    Public Property TText() As String
        Get
            Return _strText
        End Get
        Set(ByVal Value As String)
            _strText = Value
            Invalidate()
        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            Return _strText
        End Get
        Set(ByVal Value As String)
            _strText = Value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _drawTextAndImage(ByVal g As Graphics)
        Try
            Dim rect As Rectangle = New Rectangle(3, 3, Width - 6, Height - 6)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            If _bolFocus And Enabled Then ControlPaint.DrawFocusRectangle(g, rect)
            Select Case _state
                Case StateButton.Normal
                    Select Case _style
                        Case StyleButton.Style1
                            g.DrawString(_strText, Font, New SolidBrush(Color.White), New RectangleF(0, 0, Width, Height), sf)
                        Case StyleButton.Style2
                            g.DrawString(_strText, Font, New SolidBrush(Color.Yellow), New RectangleF(0, 0, Width, Height), sf)
                        Case StyleButton.Style3
                            g.DrawString(_strText, Font, New SolidBrush(Color.Yellow), New RectangleF(0, 0, Width, Height), sf)
                    End Select
                Case StateButton.MouseMove
                    Select Case _style
                        Case StyleButton.Style1
                            g.DrawString(_strText, Font, New SolidBrush(Color.Black), New RectangleF(0, 0, Width, Height), sf)
                        Case StyleButton.Style2
                            g.DrawString(_strText, Font, New SolidBrush(Color.Black), New RectangleF(0, 0, Width, Height), sf)
                        Case StyleButton.Style3
                            g.DrawString(_strText, Font, New SolidBrush(Color.Black), New RectangleF(0, 0, Width, Height), sf)
                    End Select
                Case StateButton.Press
                    Select Case _style
                        Case StyleButton.Style1
                            g.DrawString(_strText, Font, New SolidBrush(Color.White), New RectangleF(0, 0, Width, Height), sf)
                        Case StyleButton.Style2
                            g.DrawString(_strText, Font, New SolidBrush(Color.White), New RectangleF(0, 0, Width, Height), sf)
                        Case StyleButton.Style3
                            g.DrawString(_strText, Font, New SolidBrush(Color.White), New RectangleF(0, 0, Width, Height), sf)
                    End Select
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal03.png"))
                    _width = 31 : _height = 20
                    Width = _width : Height = _height
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal04.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal05.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal06.png"))
                    _width = 31 : _height = 14
                    Width = _width : Height = _height
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal07.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal08.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Cal09.png"))
                    _width = 66 : _height = 14
                    Width = _width : Height = _height
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
    Private Sub _styleNormal()
        Try
            BackgroundImage = _img(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMove()
        Try
            BackgroundImage = _img(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePress()
        Try
            BackgroundImage = _img(2)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleButton()
        Select Case _state
            Case StateButton.Normal
                _styleNormal()
            Case StateButton.MouseMove
                _styleMouseMove()
            Case StateButton.Press
                _stylePress()
        End Select
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            _drawTextAndImage(g)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonPNA2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _getResBitmap()
    End Sub
    Private Sub ButtonPNA2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub ButtonPNA2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        _bolFocus = False
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Press And e.KeyCode = Keys.Space Then
                _state = StateButton.Press
                _styleButton()
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                _styleButton()
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateButton.Press
                _styleButton()
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
                _styleButton()
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.Press Then
                _state = StateButton.MouseMove
                _styleButton()
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                _styleButton()
                Invalidate()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButton(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Width = _width : Height = _height
            _styleButton()
            Invalidate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
