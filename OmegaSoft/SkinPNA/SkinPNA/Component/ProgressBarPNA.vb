Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(ProgressBarPNA), "ProgressBarPNA.bmp")> _
Public Class ProgressBarPNA
#Region "ClassProgressBarPNA"
#Region "Enum"
    Public Enum StyleProgressBar
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _intWidth As Integer
    Private _intMax As Double = 100
    Private _intMin As Long = 0
    Private _intValue As Double = 0
    Private _style As StyleProgressBar = StyleProgressBar.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleProgressBar
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleProgressBar)
            _style = Value
            Invalidate()
        End Set
    End Property
    Public Property Max() As Double
        Get
            Return _intMax
        End Get
        Set(ByVal Value As Double)
            _intMax = Value
        End Set
    End Property
    Public Property Min() As Double
        Get
            Return _intMin
        End Get
        Set(ByVal Value As Double)
            _intMin = Value
        End Set
    End Property
    Public Property Value() As Double
        Get
            Return _intValue
        End Get
        Set(ByVal Value As Double)
            If Value > _intMax Or Value < _intMin Then Exit Property
            _intValue = Value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
#Region "Style1"
    Private Sub _style1Border(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(220, 252, 255), Color.FromArgb(125, 195, 236), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(93, 174, 221), Color.FromArgb(177, 252, 255), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, _intWidth, 1, Width - 2, CInt(Height / 2))
            g.FillRectangle(Brush2, _intWidth, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)

            g.DrawRectangle(New Pen(Color.FromArgb(222, 231, 247)), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 1, 0, 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 0, 1, 0, 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 1, Height - 1, 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 0, Height - 3, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 3, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 1, 1, Width - 1, 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 3, Height - 1, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 1, Height - 2, Width - 1, Height - 3)

            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 2, 0, Width - 3, 0)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 2, Height - 1, Width - 3, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 0, 2, 0, Height - 3)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Width - 1, 2, Width - 1, Height - 3)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA._style1Border)", , True)
        End Try
    End Sub
    Private Sub _style1ProgressBar(ByVal g As Graphics)
        Try
            _style1Border(g)
            If _intValue = 0 Then
                g.DrawString(_intValue & "%", New Font("Arial", 10), New SolidBrush(ForeColor), Width / 2 - 10, Height / 2 - 8)
                Exit Sub
            End If
            If _intValue = _intMax Then
                _intWidth = Width - 4
            Else
                _intWidth = CInt((Width / _intMax) * _intValue) - 4
            End If
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 253, 235), Color.FromArgb(255, 235, 182), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 214, 56), Color.FromArgb(255, 232, 167), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 2, 2, _intWidth, CInt(Height / 2))
            g.FillRectangle(Brush2, 2, CInt(Height / 2), _intWidth, CInt(Height / 2) - 2)

            g.DrawString(_intValue & "%", New Font("Arial", 10), New SolidBrush(ForeColor), Width / 2 - 10, Height / 2 - 8)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA._style1ProgressBar)", , True)
        End Try
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Border(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(231, 158, 148), Color.FromArgb(214, 134, 115), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 65, 41), Color.FromArgb(214, 134, 115), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, _intWidth, 1, Width - 2, CInt(Height / 2))
            g.FillRectangle(Brush2, _intWidth, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)

            g.DrawRectangle(New Pen(Color.FromArgb(222, 231, 247)), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 1, 0, 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 0, 1, 0, 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 1, Height - 1, 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 0, Height - 3, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 3, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 1, 1, Width - 1, 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 3, Height - 1, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 1, Height - 2, Width - 1, Height - 3)

            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 2, 0, Width - 3, 0)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 2, Height - 1, Width - 3, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 0, 2, 0, Height - 3)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Width - 1, 2, Width - 1, Height - 3)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA._style2Border)", , True)
        End Try
    End Sub
    Private Sub _style2ProgressBar(ByVal g As Graphics)
        Try
            _style2Border(g)
            If _intValue = 0 Then

                g.DrawString(_intValue & "%", New Font("Arial", 10), New SolidBrush(ForeColor), Width / 2 - 10, Height / 2 - 8)
                Exit Sub
            End If
            If _intValue = _intMax Then
                _intWidth = Width - 4
            Else
                _intWidth = CInt((Width / _intMax) * _intValue) - 4
            End If
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 186, 173), Color.FromArgb(239, 162, 62), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(214, 32, 0), Color.FromArgb(239, 162, 62), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 2, 2, _intWidth, CInt(Height / 2))
            g.FillRectangle(Brush2, 2, CInt(Height / 2), _intWidth, CInt(Height / 2) - 2)

            g.DrawString(_intValue & "%", New Font("Arial", 10), New SolidBrush(ForeColor), Width / 2 - 10, Height / 2 - 8)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA._style2ProgressBar)", , True)
        End Try
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Border(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(198, 211, 231), Color.FromArgb(181, 211, 239), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(156, 178, 206), Color.FromArgb(181, 211, 239), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, _intWidth, 1, Width - 2, CInt(Height / 2))
            g.FillRectangle(Brush2, _intWidth, CInt(Height / 2), Width - 2, CInt(Height / 2) - 1)

            g.DrawRectangle(New Pen(Color.FromArgb(222, 231, 247)), New Rectangle(1, 1, Width - 3, Height - 3))
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 1, 0, 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 0, 1, 0, 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 1, Height - 1, 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), 0, Height - 3, 0, Height - 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 3, 0, Width - 2, 0)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 1, 1, Width - 1, 2)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 3, Height - 1, Width - 2, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(148, 170, 198)), Width - 1, Height - 2, Width - 1, Height - 3)

            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 2, 0, Width - 3, 0)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 2, Height - 1, Width - 3, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 0, 2, 0, Height - 3)
            g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Width - 1, 2, Width - 1, Height - 3)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA._style3Border)", , True)
        End Try
    End Sub
    Private Sub _style3ProgressBar(ByVal g As Graphics)
        Try
            _style3Border(g)
            If _intValue = 0 Then
                g.DrawString(_intValue & "%", New Font("Arial", 10), New SolidBrush(ForeColor), Width / 2 - 10, Height / 2 - 8)
                Exit Sub
            End If
            If _intValue = _intMax Then
                _intWidth = Width - 4
            Else
                _intWidth = CInt((Width / _intMax) * _intValue) - 4
            End If
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(148, 203, 239), Color.FromArgb(33, 199, 239), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 113, 165), Color.FromArgb(33, 199, 239), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 2, 2, _intWidth, CInt(Height / 2))
            g.FillRectangle(Brush2, 2, CInt(Height / 2), _intWidth, CInt(Height / 2) - 2)

            g.DrawString(_intValue & "%", New Font("Arial", 10), New SolidBrush(ForeColor), Width / 2 - 10, Height / 2 - 8)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA._style3ProgressBar)", , True)
        End Try
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            Select Case _style
                Case StyleProgressBar.Style1
                    _style1ProgressBar(g)
                Case StyleProgressBar.Style2
                    _style2ProgressBar(g)
                Case StyleProgressBar.Style3
                    _style3ProgressBar(g)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ProgressBarPNA.PaintButton)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButton(e.Graphics)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub
#End Region
#End Region
End Class
