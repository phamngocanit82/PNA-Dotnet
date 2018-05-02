Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonArrowPNA1), "ButtonArrowPNA1.bmp")> _
Public Class ButtonArrowPNA1
#Region "ClassButtonArrowPNA1"
#Region "Enum/Struct"
    Public Enum StyleButton
        Style1 = 0
        Style2 = 1
        Style3 = 2
        Style4 = 3
        Style5 = 4
        Style6 = 5
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
#End Region
#Region "Properties"
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
#End Region
#Region "Methods"
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Arrow01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Arrow02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Arrow03.png"))
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Arrow04.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Arrow05.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Arrow06.png"))
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Minimize1.bmp"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Minimize2.bmp"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.Minimize3.bmp"))
                Case StyleButton.Style4
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm03.png"))
                Case StyleButton.Style5
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm04.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm05.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm06.png"))
                Case StyleButton.Style6
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm07.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm08.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonForm09.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
    Private Sub _styleNormal()
        BackgroundImage = _img(0)
    End Sub
    Private Sub _styleMouseMove()
        BackgroundImage = _img(1)
    End Sub
    Private Sub _stylePress()
        BackgroundImage = _img(2)
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
    Protected Sub PaintButtonForm()
        Try
            _styleButton()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonArrowPNA1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Width = 30 : Height = 17
        _getResBitmap()
        PaintButtonForm()
    End Sub
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
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButtonForm()
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Width = 24 : Height = 24
            Invalidate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
