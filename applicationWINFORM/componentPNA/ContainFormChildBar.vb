Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class ContainFormChildBarPNA
    Public Enum EnumState
        Normal = 0
        MouseMove = 1
        Press = 2
        SendBack = 3
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
    Private _img As Image
    Private _intLeft As Integer = 0
    Private _intWidth As Integer = 0
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
#End Region
#Region "ContainFormChildBarPNA"
    Public Sub LeftWith(ByVal intLeft As Integer, ByVal intWidth As Integer)
        _intLeft = intLeft
        _intWidth = intWidth
        Invalidate()
    End Sub
    Private Sub Skin1_Normal(ByRef e As System.Windows.Forms.PaintEventArgs)
        Try
            If _img Is Nothing Then
                Dim gTmp As Graphics
                _img = New Bitmap(Me.Width, Me.Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

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
                _img = New Bitmap(Me.Width, Me.Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

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
                _img = New Bitmap(Me.Width, Me.Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

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
            e.Graphics.DrawImage(imgTmp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle, GraphicsUnit.Pixel)
            imgTmp.Dispose() : imgTmp = Nothing
            g.Dispose() : g = Nothing
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Skin1_SendBack(ByRef e As System.Windows.Forms.PaintEventArgs)
        Try
            If _img Is Nothing Then
                Dim gTmp As Graphics
                _img = New Bitmap(Me.Width, Me.Height)
                gTmp = Graphics.FromImage(_img)
                gTmp.Clear(Color.White)
                gTmp.Dispose() : gTmp = Nothing
            End If

            Dim imgTmp As New Bitmap(_img)
            Dim g As Graphics
            g = Graphics.FromImage(imgTmp)

            Dim BrushSize As Rectangle = New Rectangle(0, 3, Width, Height - 5)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(27, 83, 157), Color.FromArgb(186, 210, 243), 90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 3, Width, Height - 5)
            g.DrawLine(New Pen(Color.FromArgb(179, 200, 226)), 0, 0, Width, 0)
            g.DrawLine(New Pen(Color.FromArgb(0, 65, 148)), 0, 1, Width, 1)
            g.DrawLine(New Pen(Color.FromArgb(79, 123, 179)), 0, 2, Width, 2)
            g.DrawLine(New Pen(Color.FromArgb(16, 71, 142)), 0, 18, Width, 18)
            g.DrawLine(New Pen(Color.FromArgb(186, 212, 245)), 0, 19, Width, 19)
            e.Graphics.DrawImage(imgTmp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle, GraphicsUnit.Pixel)
            imgTmp.Dispose() : imgTmp = Nothing
            g.Dispose() : g = Nothing
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Skin1_Normal(e)
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
    Protected Overrides Sub OnSizeChanged(ByVal e As System.EventArgs)
        Try
            Height = 17
            If Not _img Is Nothing Then _img.Dispose()
            _img = Nothing
            MyBase.OnSizeChanged(e)
            Invalidate()
        Catch ex As Exception
        End Try
    End Sub
End Class
