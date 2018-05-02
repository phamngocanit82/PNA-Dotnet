Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonFormChildPNA3), "ButtonFormMainPNA3.bmp")> _
Public Class ButtonFormChildPNA3
#Region "ClassButtonFormChildPNA3"
#Region "Enum/Struct"
    Public Enum ArrowButton
        AClose = 0
        ALeft = 1
        ARight = 2
    End Enum
    Public Enum StateButton
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _img(3) As Bitmap
    Private _strToolTip As String
    Private _tipButton As New ToolTip
    Private _arrow As ArrowButton = ArrowButton.AClose
    Private _state As StateButton = StateButton.Normal
    Private _width As Integer, _height As Integer
#End Region
#Region "Properties"
    Public Property Arrow() As ArrowButton
        Get
            Return _arrow
        End Get
        Set(ByVal Value As ArrowButton)
            _arrow = Value
            _getResBitmap()
            PaintButton()
        End Set
    End Property
    Public Property State() As StateButton
        Get
            Return _state
        End Get
        Set(ByVal Value As StateButton)
            _state = Value
            PaintButton()
        End Set
    End Property
    Public Property BToolTip() As String
        Get
            Return _strToolTip
        End Get
        Set(ByVal Value As String)
            _strToolTip = Value
            _tipButton.RemoveAll()
            _tipButton.SetToolTip(Me, Value)
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _arrow
                Case ArrowButton.AClose
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.AClose01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.AClose02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.AClose03.png"))
                    _width = 17 : _height = 13
                    Width = _width : Height = _height
                Case ArrowButton.ALeft
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ALeft01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ALeft02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ALeft03.png"))
                    _width = 13 : _height = 13
                    Width = _width : Height = _height
                Case ArrowButton.ARight
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ARight01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ARight02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ARight03.png"))
                    _width = 13 : _height = 13
                    Width = _width : Height = _height
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
    Private Sub _arrowNormal()
        Try
            BackgroundImage = _img(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _arrowMouseMove()
        Try
            BackgroundImage = _img(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _arrowPress()
        Try
            BackgroundImage = _img(2)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _arrowButton()
        Select Case _state
            Case StateButton.Normal
                _arrowNormal()
            Case StateButton.MouseMove
                _arrowMouseMove()
            Case StateButton.Press
                _arrowPress()
        End Select
    End Sub
#End Region
    Protected Sub PaintButton()
        Try
            BToolTip = _strToolTip
            _arrowButton()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonFormChildPNA3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _getResBitmap()
        PaintButton()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Press And e.KeyCode = Keys.Space Then
                _state = StateButton.Press
                PaintButton()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                PaintButton()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateButton.Press
                PaintButton()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                PaintButton()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.Press Then
                _state = StateButton.MouseMove
                PaintButton()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                PaintButton()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Width = _width : Height = _height
            PaintButton()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
