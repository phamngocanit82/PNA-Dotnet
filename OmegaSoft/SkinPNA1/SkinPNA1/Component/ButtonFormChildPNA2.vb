Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonFormChildPNA2), "ButtonFormChildPNA2.bmp")> _
Public Class ButtonFormChildPNA2
    Public Shadows Event CloseClick As System.EventHandler
#Region "ClassButtonFormChild2"
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
        BackNormal = 3
        BackMouseMove = 4
        BackPress = 5
    End Enum
#End Region
#Region "Variables"
    Private _strToolTip As String
    Private _tipButton As New ToolTip
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _bolFocus As Boolean = False
    Private _bolBack As Boolean = False
    Private _strText As String
    Private _img As Bitmap
    Private _intLeft As Integer
    Private _intIndex As Integer
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
    Public Property SendBack() As Boolean
        Get
            Return _bolBack
        End Get
        Set(ByVal Value As Boolean)
            _bolBack = Value
            If _bolBack = False Then
                _state = StateButton.Normal
                btnClose.State = ButtonFormChildPNA1.StateButton.Normal
            Else
                _state = StateButton.BackNormal
                btnClose.State = ButtonFormChildPNA1.StateButton.MoveNo
            End If
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
            BToolTip = Value
            Invalidate()
        End Set
    End Property
    Public Property TBitmap() As Bitmap
        Get
            Return _img
        End Get
        Set(ByVal Value As Bitmap)
            _img = Value
            Invalidate()
        End Set
    End Property
    Public Property TLeft() As Integer
        Get
            Return _intLeft
        End Get
        Set(ByVal Value As Integer)
            _intLeft = Value
            Invalidate()
        End Set
    End Property
    Public Property CloseIndex() As Integer
        Get
            Return btnClose.BIndex
        End Get
        Set(ByVal value As Integer)
            btnClose.BIndex = value
        End Set
    End Property
    Public Property BIndex() As Integer
        Get
            Return _intIndex
        End Get
        Set(ByVal Value As Integer)
            _intIndex = Value
            btnClose.BIndex = Value
        End Set
    End Property
#End Region
#Region "Methods"
    Public Sub SetWidth()
        Dim g As Graphics = CreateGraphics()
        If _img Is Nothing Then
            Me.Width = g.MeasureString(Text, Font).Width + 30
        Else
            Me.Width = g.MeasureString(Text, Font).Width + 46
        End If
    End Sub
    Private Sub _drawTextAndImage(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Near
            sf.Alignment = StringAlignment.Near
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            If _bolFocus And Enabled Then ControlPaint.DrawFocusRectangle(g, New Rectangle(3, 3, Width - 4, Height - 21))
            If _img Is Nothing Then
                If _bolBack = False Then
                    g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(16, 3, Width - 4, Height - 21), sf)
                Else
                    g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(16, 3, Width - 4, Height - 21), sf)
                End If
            Else
                g.DrawImage(_img, 17, 4, 12, 12)
                If _bolBack = False Then
                    g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(30, 3, Width - 36, Height), sf)
                Else
                    g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(30, 3, Width - 36, Height), sf)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(220, 252, 255), Color.FromArgb(125, 195, 236), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, 18, 18, 0)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 18, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 1, Height)

            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), 1, 18, 18, 1)
            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), 18, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(190, 255, 222)), Width - 2, 2, Width - 2, Height)

            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 18, 18, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 18, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 3, 3, Width - 3, Height)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(255, 253, 235), Color.FromArgb(255, 235, 182), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), 0, 18, 18, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), 18, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), Width - 1, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 156, 0)), Width - 1, 0, Width - 1, Height)

            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 1, 18, 18, 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 18, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 2, 2, Width - 2, Height)

            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 18, 18, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 18, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 3, 3, Width - 3, Height)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(244, 185, 127), Color.FromArgb(244, 175, 71), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), 0, 18, 18, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), 18, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), Width - 1, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 255, 0)), Width - 1, 0, Width - 1, Height)

            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 1, 18, 18, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 18, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), Width - 2, 2, Width - 2, Height)

            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 2, 18, 18, 2)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 18, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 3, 3, Width - 3, Height)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1BackNormal(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(223, 235, 251), Color.FromArgb(134, 164, 202), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)

            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, 18, 18, 0)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 18, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 1, Height)

            g.DrawLine(New Pen(Color.FromArgb(0, 106, 30)), 1, 18, 18, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 106, 30)), 18, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 106, 30)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 106, 30)), Width - 2, 2, Width - 2, Height)

            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 18, 18, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 18, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 3, 3, Width - 3, Height)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1BackMouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(248, 235, 251), Color.FromArgb(255, 255, 255), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 0, 18, 18, 0)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), 18, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(119, 156, 204)), Width - 1, 0, Width - 1, Height)

            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 1, 18, 18, 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), 18, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), Width - 2, 2, Width - 2, Height)

            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 2, 18, 18, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), 18, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(80, 103, 179)), Width - 3, 3, Width - 3, Height)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1BackPress(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(13, 72, 149), Color.FromArgb(244, 247, 251), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(247, 206, 140)), 0, 18, 18, 0)
            g.DrawLine(New Pen(Color.FromArgb(247, 206, 140)), 18, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(247, 206, 140)), Width - 1, 0, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(247, 206, 140)), Width - 1, 0, Width - 1, Height)

            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 1, 18, 18, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 18, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), Width - 2, 2, Width - 2, Height)

            g.DrawLine(New Pen(Color.FromArgb(248, 213, 158)), 2, 18, 18, 2)
            g.DrawLine(New Pen(Color.FromArgb(248, 213, 158)), 18, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(248, 213, 158)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(248, 213, 158)), Width - 3, 3, Width - 3, Height)
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
            Case StateButton.BackNormal
                _style1BackNormal(g)
            Case StateButton.BackMouseMove
                _style1BackMouseMove(g)
            Case StateButton.BackPress
                _style1BackPress(g)
        End Select
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Normal(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(236, 170, 139), Color.FromArgb(215, 125, 85), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(190, 72, 22), Color.FromArgb(233, 162, 86), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(250, 163, 122), Color.FromArgb(237, 127, 79), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(224, 87, 28), Color.FromArgb(251, 168, 88), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(179, 73, 27), Color.FromArgb(183, 81, 36), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(187, 90, 48), Color.FromArgb(229, 193, 177), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2BackNormal(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(236, 170, 139), Color.FromArgb(215, 125, 85), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(190, 72, 22), Color.FromArgb(233, 162, 86), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(224, 164, 137)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(206, 118, 80)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2BackMouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(250, 163, 122), Color.FromArgb(237, 127, 79), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(224, 87, 28), Color.FromArgb(251, 168, 88), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(232, 187, 167)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(172, 11, 0)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(231, 129, 86)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2BackPress(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(186, 90, 48), Color.FromArgb(251, 246, 243), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(187, 90, 48), Color.FromArgb(229, 193, 177), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(215, 179, 163)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(211, 172, 155)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(120, 44, 11)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(202, 157, 138)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
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
            Case StateButton.BackNormal
                _style2BackNormal(g)
            Case StateButton.BackMouseMove
                _style2BackMouseMove(g)
            Case StateButton.BackPress
                _style2BackPress(g)
        End Select
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Normal(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(162, 190, 242), Color.FromArgb(100, 136, 190), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(23, 69, 127), Color.FromArgb(25, 78, 169), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(144, 174, 231), Color.FromArgb(96, 137, 196), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(41, 93, 157), Color.FromArgb(16, 182, 218), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(41, 93, 157), Color.FromArgb(64, 111, 167), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(41, 93, 157), Color.FromArgb(220, 229, 239), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3BackNormal(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(162, 190, 242), Color.FromArgb(100, 136, 190), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(23, 69, 127), Color.FromArgb(25, 78, 169), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(164, 180, 204)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(28, 84, 154)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(109, 139, 175)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3BackMouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(144, 174, 231), Color.FromArgb(96, 137, 196), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(41, 93, 157), Color.FromArgb(16, 182, 218), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(198, 208, 223)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(248, 134, 32)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3BackPress(ByVal g As Graphics)
        Try
            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height - 20)
            Dim BrushSize2 As Rectangle = New Rectangle(0, Height - 17, Width, 15)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(31, 64, 105), Color.FromArgb(247, 248, 249), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize2, Color.FromArgb(41, 93, 157), Color.FromArgb(220, 229, 239), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height - 20)
            g.FillRectangle(Brush2, 0, Height - 17, Width, 15)
            g.DrawLine(New Pen(Color.FromArgb(20, 59, 108)), 0, Height - 2, Width, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(189, 209, 238)), 0, Height - 1, Width, Height - 1)
            _drawTextAndImage(g)
            'Border
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), 0, 16, 16, 0)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), 16, 0, Width - 1, 0)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), Width - 1, 0, Width - 1, 1)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), Width - 1, 1, Width - 2, 1)
            g.DrawLine(New Pen(Color.FromArgb(219, 226, 235)), Width - 1, 1, Width - 1, Height - 20)

            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), 0, 17, 16, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), 17, 1, Width - 3, 1)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), Width - 3, 1, Width - 3, 2)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), Width - 2, 2, Width - 2, Height - 19)
            g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), Width - 2, Height - 19, Width - 1, Height - 19)

            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 0, 18, 16, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), 16, 2, Width - 4, 2)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 4, 2, Width - 4, 3)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, 3, Width - 3, Height - 18)
            g.DrawLine(New Pen(Color.FromArgb(121, 153, 194)), Width - 3, Height - 18, Width - 1, Height - 18)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
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
            Case StateButton.BackNormal
                _style3BackNormal(g)
            Case StateButton.BackMouseMove
                _style3BackMouseMove(g)
            Case StateButton.BackPress
                _style3BackPress(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            g.Clear(Color.White)
            BToolTip = _strToolTip
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
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        RaiseEvent CloseClick(sender, e)
    End Sub
    Private Sub OmegaButtonFormChild2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Left = _intLeft : Me.Top = 0
            'Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            'Dim strPath As String, strLang As String = ""
            'Dim dsLang As New DataSet
            'strPath = Application.StartupPath & "\Files\XMLConfigs.xml"
            'dsLang.ReadXml(strPath, XmlReadMode.Auto)
            'strLang = dsLang.Tables(0).Rows(0).Item("Type")
            'dsLang.Dispose() : dsLang = Nothing
            'dsLang = New DataSet
            'dsLang.ReadXml(AppAssembly.GetManifestResourceStream("OmegaSkins1.XMLButton.xml"))
            'Select Case strLang
            '    Case "VietNamese"
            '        btnClose.BToolTip = dsLang.Tables(0).Rows(0).Item(1)
            '    Case "English"
            '        btnClose.BToolTip = dsLang.Tables(0).Rows(0).Item(2)
            'End Select
            'dsLang.Dispose() : dsLang = Nothing
            btnClose.BToolTip = "Close"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ButtonFormChildPNA2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub ButtonFormChildPNA2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        _bolFocus = False
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Press And _state <> StateButton.BackPress And e.KeyCode = Keys.Space Then
                If _bolBack = False Then
                    _state = StateButton.Press
                Else
                    _state = StateButton.BackPress
                End If
                btnClose.State = ButtonFormChildPNA1.StateButton.Press
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Normal And _state <> StateButton.BackNormal Then
                If _bolBack = False Then
                    _state = StateButton.Normal
                    btnClose.State = ButtonFormChildPNA1.StateButton.Normal
                Else
                    _state = StateButton.BackNormal
                    btnClose.State = ButtonFormChildPNA1.StateButton.MoveNo
                End If
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And _state <> StateButton.BackPress And e.Button = Windows.Forms.MouseButtons.Left Then
                If _bolBack = False Then
                    _state = StateButton.Press
                Else
                    _state = StateButton.BackPress
                End If
                btnClose.State = ButtonFormChildPNA1.StateButton.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Normal And _state <> StateButton.BackNormal Then
                If _bolBack = False Then
                    _state = StateButton.Normal
                    btnClose.State = ButtonFormChildPNA1.StateButton.Normal
                Else
                    _state = StateButton.BackNormal
                    btnClose.State = ButtonFormChildPNA1.StateButton.MoveNo
                End If
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.BackMouseMove And _state <> StateButton.Press And _state <> StateButton.BackPress Then
                If _bolBack = False Then
                    _state = StateButton.MouseMove
                Else
                    _state = StateButton.BackMouseMove
                End If
                btnClose.State = ButtonFormChildPNA1.StateButton.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal And _state <> StateButton.BackNormal Then
                If _bolBack = False Then
                    _state = StateButton.Normal
                    btnClose.State = ButtonFormChildPNA1.StateButton.Normal
                Else
                    _state = StateButton.BackNormal
                    btnClose.State = ButtonFormChildPNA1.StateButton.MoveNo
                End If
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
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Dim gp As New GraphicsPath
            Height = 18
            gp.AddLine(0, 18, 18, 0)
            gp.AddLine(18, 0, Width - 1, 0)
            gp.AddLine(Width - 1, 0, Width - 1, 1)
            gp.AddLine(Width - 1, 1, Width, 1)
            gp.AddLine(Width, 1, Width, Height)
            gp.AddLine(Width, Height, 0, Height)
            gp.AddLine(0, Height, 0, 18)
            Region = New Region(gp)
            Invalidate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
