Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(SildeBarPNA1), "SildeBarPNA1.bmp")> _
Public Class SildeBarPNA1
#Region "ClassSildeBarPNA1"
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
        SendBack = 3
    End Enum
#End Region
#Region "Variables"
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _intLeft As Integer = 0
    Private _intWidth As Integer = 0
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
    Public Property State() As StateButton
        Get
            Return _state
        End Get
        Set(ByVal Value As StateButton)
            _state = Value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
    Public Sub LeftWith(ByVal intLeft As Integer, ByVal intWidth As Integer)
        _intLeft = intLeft
        _intWidth = intWidth
        Invalidate()
    End Sub
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height - 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(93, 174, 221), Color.FromArgb(177, 252, 255), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, Height - 2)
            'Top
            If _intLeft = 0 Then
                g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, 0, Width - 1, 0)
                g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), 1, 1, Width - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 2, Width - 3, 2)
            Else
                g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, 0, _intLeft, 0)
                g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), 1, 1, _intLeft + 1, 1)
                g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), _intLeft + 1, 0, _intLeft + 1, 1)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 2, _intLeft + 2, 2)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), _intLeft + 2, 0, _intLeft + 2, 2)

                g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), _intLeft + _intWidth - 1, 0, Width - 1, 0)
                g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), _intLeft + _intWidth - 2, 1, Width - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), _intLeft + _intWidth - 2, 0, _intLeft + _intWidth - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), _intLeft + _intWidth - 3, 2, Width - 3, 2)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), _intLeft + _intWidth - 3, 0, _intLeft + _intWidth - 3, 2)
            End If
            'Left
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, 0, 0, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), 1, 1, 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 2, 2, Height - 3)
            'Right
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), Width - 2, 1, Width - 2, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 3, 2, Width - 3, Height - 3)
            'Bottom
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, Height - 3, Width - 3, Height - 3)
            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), 1, Height - 2, Width - 2, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, Height - 1, Width - 1, Height - 1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height - 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 214, 56), Color.FromArgb(255, 232, 167), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, Height - 2)
            'Top
            If _intLeft = 0 Then
                g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), 0, 0, Width - 1, 0)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 1, 1, Width - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 2, Width - 3, 2)
            Else
                g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), 0, 0, _intLeft, 0)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 1, 1, _intLeft + 1, 1)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), _intLeft + 1, 0, _intLeft + 1, 1)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 2, _intLeft + 2, 2)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), _intLeft + 2, 0, _intLeft + 2, 2)

                g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), _intLeft + _intWidth - 1, 0, Width - 1, 0)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), _intLeft + _intWidth - 2, 1, Width - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), _intLeft + _intWidth - 2, 0, _intLeft + _intWidth - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), _intLeft + _intWidth - 3, 2, Width - 3, 2)
                g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), _intLeft + _intWidth - 3, 0, _intLeft + _intWidth - 3, 2)
            End If
            'Left
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), 0, 0, 0, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 1, 1, 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 2, 2, Height - 3)
            'Right
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), Width - 1, 0, Width - 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 2, 1, Width - 2, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 3, 2, Width - 3, Height - 3)
            'Bottom
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, Height - 3, Width - 3, Height - 3)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 1, Height - 2, Width - 2, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), 0, Height - 1, Width - 1, Height - 1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height - 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(244, 151, 8), Color.FromArgb(244, 196, 68), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, Height - 2)
            'Top
            If _intLeft = 0 Then
                g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), 0, 0, Width - 1, 0)
                g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 1, 1, Width - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 2, 2, Width - 3, 2)
            Else
                g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), 0, 0, _intLeft, 0)
                g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 1, 1, _intLeft + 1, 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), _intLeft + 1, 0, _intLeft + 1, 1)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 2, 2, _intLeft + 2, 2)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), _intLeft + 2, 0, _intLeft + 2, 2)

                g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), _intLeft + _intWidth - 1, 0, Width - 1, 0)
                g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), _intLeft + _intWidth - 2, 1, Width - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), _intLeft + _intWidth - 2, 0, _intLeft + _intWidth - 2, 1)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), _intLeft + _intWidth - 3, 2, Width - 3, 2)
                g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), _intLeft + _intWidth - 3, 0, _intLeft + _intWidth - 3, 2)
            End If
            'Left
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), 0, 0, 0, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 1, 1, 1, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 2, 2, 2, Height - 3)
            'Right
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), Width - 1, 0, Width - 1, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), Width - 2, 1, Width - 2, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 3, 2, Width - 3, Height - 3)
            'Bottom
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 2, Height - 3, Width - 3, Height - 3)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 1, Height - 2, Width - 2, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), 0, Height - 1, Width - 1, Height - 1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1SendBack(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(27, 83, 157), Color.FromArgb(186, 210, 243), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(179, 200, 226)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(79, 123, 179)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(16, 71, 142)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(186, 212, 245)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

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
            Case StateButton.SendBack
                _style1SendBack(g)
        End Select
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(190, 72, 22), Color.FromArgb(233, 162, 86), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(224, 87, 28), Color.FromArgb(251, 168, 88), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(187, 90, 48), Color.FromArgb(229, 193, 177), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2SendBack(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(27, 83, 157), Color.FromArgb(186, 210, 243), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

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
            Case StateButton.SendBack
                _style2SendBack(g)
        End Select
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(23, 69, 127), Color.FromArgb(25, 78, 169), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 93, 157), Color.FromArgb(16, 182, 218), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 93, 157), Color.FromArgb(220, 229, 239), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3SendBack(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(22, 70, 127), Color.FromArgb(24, 78, 169), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, 19, Width, 19)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

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
            Case StateButton.SendBack
                _style3SendBack(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            Select Case _style
                Case StyleButton.Style1
                    _style1Button(g)
                Case StyleButton.Style2
                    _style2Button(g)
                Case StyleButton.Style3
                    _style3Button(g)
            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub SildeBarPNA1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Height = 17
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
            Height = 17
            Invalidate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
