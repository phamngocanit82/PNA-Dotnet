Imports System
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Public Class ContainFormChildButtonPNA
    Public Shadows Event CloseClick As System.EventHandler
    Public Enum EnumState
        Normal = 0
        MouseMove = 1
        Press = 2
        BackNormal = 3
        BackMouseMove = 4
        BackPress = 5
    End Enum
    Public Enum EnumSkin
        Skins1 = 0
        Skins2 = 1
        Skins3 = 2
        Customer = 3
        Picture = 4
    End Enum
    Private _State As EnumState = EnumState.Normal
    Private _Skin As EnumSkin = EnumSkin.Skins1
    Private _bolFocus As Boolean = False
    Private _bolBack As Boolean = False
    Private _img As Image
    Private _bitmap As Image
    Private _strText As String
    Private _intIndex As Integer
    Private _intLeft As Integer
#Region "Properties"
    Public Property Skin() As EnumSkin
        Get
            Return _Skin
        End Get
        Set(ByVal Value As EnumSkin)
            _Skin = Value
            Invalidate()
        End Set
    End Property
    Public Property State() As EnumState
        Get
            Return _State
        End Get
        Set(ByVal Value As EnumState)
            _State = Value
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
                _State = EnumState.Normal
                btnClose.Type = ButtonStylePNA.EnumType.AExit
            Else
                _State = EnumState.BackNormal
                btnClose.Type = ButtonStylePNA.EnumType.AExitBack
            End If
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
    Public Property [Bitmap]() As Bitmap
        Get
            Return _bitmap
        End Get
        Set(ByVal Value As Bitmap)
            _bitmap = Value
            Invalidate()
        End Set
    End Property
    Public Shadows Property [Left]() As Integer
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
            Return btnClose.Index
        End Get
        Set(ByVal value As Integer)
            btnClose.Index = value
        End Set
    End Property
    Public Property [Index]() As Integer
        Get
            Return _intIndex
        End Get
        Set(ByVal Value As Integer)
            _intIndex = Value
            btnClose.Index = Value
        End Set
    End Property
#End Region
#Region "ContainFormChildButtonPNA"
    Public Sub SetWidth()
        Dim g As Graphics = CreateGraphics()
        If _bitmap Is Nothing Then
            Me.Width = g.MeasureString(Text, Font).Width + 30
        Else
            Me.Width = g.MeasureString(Text, Font).Width + 46
        End If
    End Sub
    Private Sub DrawTextAndImage(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            Dim _color As Color
            Select Case _State
                Case EnumState.Normal, EnumState.MouseMove
                    _color = Color.FromArgb(0, 0, 0)
                Case EnumState.Press, EnumState.BackNormal, EnumState.BackPress
                    _color = Color.FromArgb(255, 255, 255)
                Case EnumState.BackMouseMove
                    _color = Color.FromArgb(0, 0, 0)
            End Select
            sf.LineAlignment = StringAlignment.Near
            sf.Alignment = StringAlignment.Near
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            If _bolFocus And Enabled Then ControlPaint.DrawFocusRectangle(g, New Rectangle(3, 3, Width - 4, Height - 21))
            If _bitmap Is Nothing Then
                If _bolBack = False Then
                    g.DrawString(Text, Font, New SolidBrush(_color), New RectangleF(16, 3, Width - 4, Height - 21), sf)
                Else
                    g.DrawString(Text, Font, New SolidBrush(_color), New RectangleF(16, 3, Width - 4, Height - 21), sf)
                End If
            Else
                g.DrawImage(_bitmap, 17, 4, 12, 12)
                If _bolBack = False Then
                    g.DrawString(Text, Font, New SolidBrush(_color), New RectangleF(30, 3, Width - 36, Height), sf)
                Else
                    g.DrawString(Text, Font, New SolidBrush(_color), New RectangleF(30, 3, Width - 36, Height), sf)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Skin1_Normal(ByRef e As System.Windows.Forms.PaintEventArgs)
        Try
            If _img Is Nothing Then
                Dim gTmp As Graphics
                _img = New Bitmap(Width, Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(220, 252, 255), Color.FromArgb(125, 195, 236), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            DrawTextAndImage(g)
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
            e.Graphics.DrawImage(imgTmp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle, GraphicsUnit.Pixel)
            imgTmp.Dispose() : imgTmp = Nothing
            g.Dispose() : g = Nothing
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Skin1_MouseMove(ByRef e As System.Windows.Forms.PaintEventArgs)
        Try
            If _img Is Nothing Then
                Dim gTmp As Graphics
                _img = New Bitmap(Width, Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(255, 253, 235), Color.FromArgb(255, 235, 182), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            DrawTextAndImage(g)
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
            e.Graphics.DrawImage(imgTmp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle, GraphicsUnit.Pixel)
            imgTmp.Dispose() : imgTmp = Nothing
            g.Dispose() : g = Nothing
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Skin1_Press(ByRef e As System.Windows.Forms.PaintEventArgs)
        Try
            If _img Is Nothing Then
                Dim gTmp As Graphics
                _img = New Bitmap(Width, Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(244, 185, 127), Color.FromArgb(244, 175, 71), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)
            DrawTextAndImage(g)
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
            e.Graphics.DrawImage(imgTmp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle, GraphicsUnit.Pixel)
            imgTmp.Dispose() : imgTmp = Nothing
            g.Dispose() : g = Nothing
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Skin1_BackNormal(ByRef e As System.Windows.Forms.PaintEventArgs)
        Try
            If _img Is Nothing Then
                Dim gTmp As Graphics
                _img = New Bitmap(Width, Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

            Dim BrushSize1 As Rectangle = New Rectangle(0, 3, Width - 3, Height)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize1, Color.FromArgb(223, 235, 251), Color.FromArgb(134, 164, 202), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width - 3, Height)

            DrawTextAndImage(g)
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
            e.Graphics.DrawImage(imgTmp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle, GraphicsUnit.Pixel)
            imgTmp.Dispose() : imgTmp = Nothing
            g.Dispose() : g = Nothing
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Skin1(ByVal e As System.Windows.Forms.PaintEventArgs)
        Select Case _State
            Case EnumState.Normal
                Skin1_Normal(e)
            Case EnumState.MouseMove
                Skin1_MouseMove(e)
            Case EnumState.Press
                Skin1_Press(e)
            Case EnumState.BackNormal
                Skin1_BackNormal(e)
                'Case EnumState.BackMouseMove
                '    _style1BackMouseMove(g)
                'Case EnumState.BackPress
                '    _style1BackPress(g)
        End Select
    End Sub
#End Region
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        RaiseEvent CloseClick(sender, e)
    End Sub
    Private Sub ContainFormChildButtonPNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = _intLeft : Me.Top = 0
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Skin1(e)
    End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
        Try
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
            If Not _img Is Nothing Then _img.Dispose()
            _img = Nothing
            MyBase.OnSizeChanged(e)
            Invalidate()
        Catch ex As Exception
        End Try
    End Sub
End Class
