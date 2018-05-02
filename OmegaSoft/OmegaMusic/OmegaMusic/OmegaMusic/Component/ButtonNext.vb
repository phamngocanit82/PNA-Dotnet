Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonNext), "Next0.png")> _
Public Class ButtonNext
#Region "ClassButtonNext"
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
#End Region
#Region "Variables"
    Private _img(3) As Bitmap
    Private _strToolTip As String
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
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next0.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next1.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next2.png"))
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next0.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next1.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next2.png"))
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next0.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next1.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaMusic.Next2.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
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
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            BToolTip = _strToolTip
            _styleButton(g)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonNext_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Width = 46 : Height = 21
        _getResBitmap()
        Refresh()
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
            Width = 46 : Height = 21
            Dim gp As New GraphicsPath
            Dim points(27) As Point
            points(0).X = Width - 4 : points(0).Y = 0
            points(1).X = Width - 4 : points(1).Y = 1
            points(2).X = Width - 3 : points(2).Y = 2
            points(3).X = Width - 2 : points(3).Y = 3
            points(4).X = Width - 2 : points(4).Y = 4
            points(5).X = Width - 1 : points(5).Y = 5
            points(6).X = Width - 1 : points(6).Y = 7
            points(7).X = Width : points(7).Y = 8
            points(8).X = Width : points(8).Y = Height - 9
            points(9).X = Width - 1 : points(9).Y = Height - 8
            points(10).X = Width - 1 : points(10).Y = Height - 6
            points(11).X = Width - 2 : points(11).Y = Height - 5
            points(12).X = Width - 3 : points(12).Y = Height - 3
            points(13).X = Width - 5 : points(13).Y = Height
            points(14).X = 0 : points(14).Y = Height
            points(15).X = 0 : points(15).Y = Height - 1
            points(16).X = 1 : points(16).Y = Height - 2
            points(17).X = 1 : points(17).Y = Height - 3
            points(18).X = 2 : points(18).Y = Height - 3
            points(19).X = 2 : points(19).Y = Height - 7
            points(20).X = 3 : points(20).Y = Height - 7
            points(21).X = 3 : points(21).Y = 9
            points(22).X = 2 : points(22).Y = 9
            points(23).X = 2 : points(23).Y = 3
            points(24).X = 1 : points(24).Y = 3
            points(25).X = 1 : points(25).Y = 2
            points(26).X = 0 : points(26).Y = 0
            gp.AddLines(points)
            Region = New Region(gp)
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
#End Region
End Class
