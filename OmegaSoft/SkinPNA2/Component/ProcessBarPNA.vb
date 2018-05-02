Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class ProcessBarPNA
#Region "ClassProcessBarPNA"
#Region "Enum"
    Public Enum StyleButton
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _img(2) As Bitmap
    Private _intWidth As Integer
    Private _intMax As Double = 100
    Private _intMin As Long = 0
    Private _intValue As Double = 0
    Private _style As StyleButton = StyleButton.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleButton
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleButton)
            _style = Value
            Invalidate()
        End Set
    End Property
    Public Property Max() As Double
        Get
            Return 100
        End Get
        Set(ByVal Value As Double)
            _intMax = 100
        End Set
    End Property
    Public Property Min() As Double
        Get
            Return 0
        End Get
        Set(ByVal Value As Double)
            _intMin = 0
        End Set
    End Property
    Public Property Value() As Double
        Get
            Return _intValue
        End Get
        Set(ByVal Value As Double)
            _intValue = Value
            If Value > _intMax Then _intValue = 100
            If Value < _intMin Then _intValue = 0
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
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormProcess04.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormProcess05.png"))
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormProcess04.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormProcess05.png"))
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormProcess04.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormProcess05.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style1"
    Private Sub _style1(ByVal g As Graphics)
        Try
            Dim intPos As Integer
            intPos = Width - (Width - CInt(_intValue / 100 * Width))
            g.DrawImage(_img(0), intPos, 0, Width, Height)
            g.DrawImage(_img(1), 0, 0, intPos, Height)
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2(ByVal g As Graphics)
        Try
            Dim intPos As Integer
            intPos = Width - (Width - CInt(_intValue / 100 * Width))
            g.DrawImage(_img(0), intPos, 0, Width, Height)
            g.DrawImage(_img(1), 0, 0, intPos, Height)
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "Style3"
    Private Sub _style3(ByVal g As Graphics)
        Try
            Dim intPos As Integer
            intPos = Width - (Width - CInt(_intValue / 100 * Width))
            g.DrawImage(_img(0), intPos, 0, Width, Height)
            g.DrawImage(_img(1), 0, 0, intPos, Height)
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            g.Clear(Color.White)
            Select Case _style
                Case StyleButton.Style1
                    _style1(g)
                Case StyleButton.Style2
                    _style2(g)
                Case StyleButton.Style3
                    _style3(g)
            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonTabPNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _getResBitmap()
        ' Me.Left = _intLeft : Me.Top = 0
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButton(e.Graphics)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Height = 6
        Dim gp As New GraphicsPath
        gp.AddLine(1, 0, Width - 1, 0)
        gp.AddLine(Width - 1, 0, Width, 1)
        gp.AddLine(Width, 1, Width, Height - 2)
        gp.AddLine(Width, Height - 2, Width - 2, Height)
        gp.AddLine(Width - 2, Height, 1, Height)
        gp.AddLine(1, Height, 0, Height - 2)
        gp.AddLine(0, Height - 2, 0, 1)
        gp.AddLine(0, 1, 1, 0)
        Region = New Region(gp)
        Invalidate()
    End Sub
#End Region
#End Region
End Class
