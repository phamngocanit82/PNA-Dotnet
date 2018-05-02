Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonFormChildPNA1), "ButtonFormChildPNA1.bmp")> _
Public Class ButtonFormChildPNA1
#Region "ClassButtonFormChildPNA1"
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
        MoveNo = 3
    End Enum
#End Region
#Region "Variables"
    Private _img(4) As Bitmap
    Private _strToolTip As String
    Private _tipButton As New ToolTip
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _bolBack As Boolean = False
    Private _intIndex As Integer
#End Region
#Region "Properties"
    Public Property Style() As StyleButton
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleButton)
            _style = Value
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
    Public Property SendBack() As Boolean
        Get
            Return _bolBack
        End Get
        Set(ByVal Value As Boolean)
            _bolBack = Value
            If _bolBack = False Then
                _state = StateButton.Normal
            Else
                _state = StateButton.MoveNo
            End If
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
    Public Property BIndex() As Integer
        Get
            Return _intIndex
        End Get
        Set(ByVal Value As Integer)
            _intIndex = Value
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close03.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close04.png"))
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close05.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close06.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close07.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close08.png"))
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close09.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close10.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close11.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Close12.png"))
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
    Private Sub _styleMoveNo()
        Try
            BackgroundImage = _img(3)
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
            Case StateButton.MoveNo
                _styleMoveNo()
        End Select
    End Sub
#End Region
    Protected Sub PaintButton()
        Try
            BToolTip = _strToolTip
            _styleButton()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonFormChildPNA1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Width = 10 : Height = 9
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
                If _bolBack = False Then
                    _state = StateButton.Normal
                Else
                    _state = StateButton.MoveNo
                End If
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
                If _bolBack = False Then
                    _state = StateButton.Normal
                Else
                    _state = StateButton.MoveNo
                End If
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
                If _bolBack = False Then
                    _state = StateButton.Normal
                Else
                    _state = StateButton.MoveNo
                End If
                PaintButton()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Width = 10 : Height = 9
            PaintButton()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
