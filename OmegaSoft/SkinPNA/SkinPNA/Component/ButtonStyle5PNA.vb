Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(ButtonStyle5PNA), "ButtonStyle5PNA.bmp")> _
Public Class ButtonStyle5PNA
#Region "ClassButtonStyle5PNA"
#Region "Enum/Struct"
    Public Enum ArrowButton
        ArrowLeft = 0
        ArrowRight = 1
        ArrowTop = 2
        ArrowBottom = 3
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
#End Region
#Region "Api"
    <DllImport("user32")> _
     Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetForegroundWindow() As IntPtr
    End Function
#End Region
#Region "Variables"
    Private _strToolTip As String
    Private _tipButton As New ToolTip
    Private _Arrow As ArrowButton = ArrowButton.ArrowLeft
    Private _Style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _bolFocus As Boolean = False
#End Region
#Region "Properties"
    Public Property Arrow() As ArrowButton
        Get
            Return _Arrow
        End Get
        Set(ByVal Value As ArrowButton)
            _Arrow = Value
            Invalidate()
        End Set
    End Property
    Public Property Style() As StyleButton
        Get
            Return _Style
        End Get
        Set(ByVal Value As StyleButton)
            _Style = Value
            Invalidate()
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
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(MyBase.Handle, winRect)
            GetCursorPos(winPoint)
            If winPoint.X < winRect.Left Or winPoint.X > winRect.Right Then Return False
            If winPoint.Y < winRect.Top Or winPoint.Y > winRect.Bottom Then Return False
            Return True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._isInnerXY)", , True)
        End Try
    End Function
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 220, 252, 255), Color.FromArgb(i, 125, 195, 236), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 93, 174, 221), Color.FromArgb(i, 177, 252, 255), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.White), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style1Normal)", , True)
        End Try
    End Sub
    Private Sub _style1MouseMove(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 255, 253, 235), Color.FromArgb(i, 255, 235, 182), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 255, 214, 56), Color.FromArgb(i, 255, 232, 167), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.White), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style1MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 244, 185, 127), Color.FromArgb(i, 244, 175, 71), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 244, 151, 8), Color.FromArgb(i, 244, 196, 68), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                g.FillRectangle(Brush1, 2, 2, Width - 3, CInt(Height / 2) - 1)
                g.FillRectangle(Brush2, 2, CInt(Height / 2) - 1, Width - 3, Height - 2)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.FromArgb(241, 167, 74)), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style1Press)", , True)
        End Try
    End Sub
    Private Sub _style1Button(ByVal g As Graphics)
        Select Case _state
            Case StateButton.Normal
                _style1Normal(g)
            Case StateButton.MouseMove
                _style1MouseMove(g)
            Case StateButton.Press
                _style1Press(g)
        End Select
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Normal(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 231, 158, 148), Color.FromArgb(i, 214, 134, 115), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 189, 65, 41), Color.FromArgb(i, 214, 134, 115), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.White), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style2Normal)", , True)
        End Try
    End Sub
    Private Sub _style2MouseMove(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 255, 186, 173), Color.FromArgb(i, 239, 162, 62), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 214, 32, 0), Color.FromArgb(i, 239, 162, 62), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.White), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style2MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 189, 142, 115), Color.FromArgb(i, 198, 146, 74), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 132, 24, 0), Color.FromArgb(i, 198, 146, 74), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                g.FillRectangle(Brush1, 2, 2, Width - 3, CInt(Height / 2) - 1)
                g.FillRectangle(Brush2, 2, CInt(Height / 2) - 1, Width - 3, Height - 2)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.FromArgb(241, 167, 74)), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style2Press)", , True)
        End Try
    End Sub
    Private Sub _style2Button(ByVal g As Graphics)
        Select Case _state
            Case StateButton.Normal
                _style2Normal(g)
            Case StateButton.MouseMove
                _style2MouseMove(g)
            Case StateButton.Press
                _style2Press(g)
        End Select
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Normal(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 198, 211, 231), Color.FromArgb(i, 181, 211, 239), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 156, 178, 206), Color.FromArgb(i, 181, 211, 239), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.White), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style3Normal)", , True)
        End Try
    End Sub
    Private Sub _style3MouseMove(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 148, 203, 239), Color.FromArgb(i, 33, 199, 239), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 41, 113, 165), Color.FromArgb(i, 33, 199, 239), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.White), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(179, 201, 214)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(121, 157, 182)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style3MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            Dim i As Integer
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            For i = 1 To 40
                Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 107, 138, 156), Color.FromArgb(i, 33, 203, 206), 90)
                Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(i, 33, 56, 82), Color.FromArgb(i, 33, 203, 206), -90)
                Brush1.WrapMode = WrapMode.TileFlipXY
                Brush2.WrapMode = WrapMode.TileFlipXY
                g.FillRectangle(Brush1, 1, 1, Width - 2, CInt(Height / 2))
                g.FillRectangle(Brush2, 1, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)
                g.FillRectangle(Brush1, 2, 2, Width - 3, CInt(Height / 2) - 1)
                g.FillRectangle(Brush2, 2, CInt(Height / 2) - 1, Width - 3, Height - 2)
                Brush1.Dispose() : Brush1 = Nothing
                Brush2.Dispose() : Brush2 = Nothing
            Next
            'Arrow
            Select Case _Arrow
                Case ArrowButton.ArrowLeft
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 4, CInt(Height / 2) - 1, CInt(Width / 2) + 3, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 2, CInt(Width / 2) + 3, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2), CInt(Width / 2) + 3, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) + 1, CInt(Width / 2) + 3, CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 4, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 2, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowRight
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 1, CInt(Width / 2) + 4, CInt(Height / 2) - 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 2, CInt(Width / 2) + 2, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2), CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2), CInt(Height / 2) - 3)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 1, CInt(Width / 2), CInt(Height / 2) + 1)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 4, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 2, CInt(Width / 2) - 2, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowTop
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 3, CInt(Width / 2) - 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 3, CInt(Width / 2) + 1, CInt(Height / 2) - 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2) + 3, CInt(Width / 2) - 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) + 3, CInt(Width / 2) + 2, CInt(Height / 2))
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) + 3, CInt(Width / 2) - 3, CInt(Height / 2) + 2)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 3, CInt(Height / 2) + 3, CInt(Width / 2) + 3, CInt(Height / 2) + 2)
                Case ArrowButton.ArrowBottom
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2), CInt(Height / 2) + 3, CInt(Width / 2), CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 1, CInt(Height / 2) + 1, CInt(Width / 2) - 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 1, CInt(Height / 2) + 1, CInt(Width / 2) + 1, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 2, CInt(Height / 2) - 1, CInt(Width / 2) - 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 2, CInt(Height / 2) - 1, CInt(Width / 2) + 2, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) - 3, CInt(Height / 2) - 3, CInt(Width / 2) - 3, CInt(Height / 2) - 4)
                    g.DrawLine(New Pen(Color.FromArgb(0, 255, 255)), CInt(Width / 2) + 3, CInt(Height / 2) - 3, CInt(Width / 2) + 3, CInt(Height / 2) - 4)
            End Select
            'Border
            g.DrawRectangle(New Pen(Color.FromArgb(241, 167, 74)), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), 1, 1, 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), Width - 2, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), 1, Height - 2, 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(153, 126, 92)), Width - 2, Height - 2, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 0, 1, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), Width - 1, 1, Width - 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 1, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(147, 125, 90)), 1, Height - 1, Width - 2, Height - 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA._style3Press)", , True)
        End Try
    End Sub
    Private Sub _style3Button(ByVal g As Graphics)
        Select Case _state
            Case StateButton.Normal
                _style3Normal(g)
            Case StateButton.MouseMove
                _style3MouseMove(g)
            Case StateButton.Press
                _style3Press(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            Dim rect As Rectangle = New Rectangle(3, 3, Width - 6, Height - 6)
            Text = ""
            Select Case _Style
                Case StyleButton.Style1
                    _style1Button(g)
                Case StyleButton.Style2
                    _style2Button(g)
                Case StyleButton.Style3
                    _style3Button(g)
            End Select
            If _bolFocus And Enabled Then ControlPaint.DrawFocusRectangle(g, rect)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.PaintButton)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonStyle5PNA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub ButtonStyle5PNA_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        _bolFocus = False
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Press And e.KeyCode = Keys.Space Then
                _state = StateButton.Press
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnKeyDown)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
                tmrButton.Enabled = False
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnKeyUp)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateButton.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnMouseDown)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
                tmrButton.Enabled = False
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnMouseUp)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.Press Then
                _state = StateButton.MouseMove
                Invalidate()
                tmrButton.Enabled = True
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnMouseMove)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
                tmrButton.Enabled = False
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnMouseLeave)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButton(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            ' Size = New System.Drawing.Size(25, 20)
            Dim gp As New GraphicsPath
            gp.AddLine(0, 1, 1, 0)
            gp.AddLine(1, 0, Width - 2, 0)
            gp.AddLine(Width - 1, 0, Width, 1)
            gp.AddLine(Width, 1, Width - 1, Height - 2)
            gp.AddLine(Width, Height - 2, Width - 2, Height)
            gp.AddLine(0, Height, 1, Height)
            gp.AddLine(0, Height - 2, 0, Height)
            gp.AddLine(0, Height - 1, 0, 1)
            Region = New Region(gp)
            Invalidate()
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.OnResize)", , True)
        End Try
    End Sub
    Private Sub tmrButton_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrButton.Tick
        Try
            If _isInnerXY() = False Then
                _state = StateButton.Normal
                tmrButton.Enabled = False
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ButtonStyle5PNA.tmrButton_Tick)", , True)
        End Try
    End Sub
#End Region
#End Region
End Class
