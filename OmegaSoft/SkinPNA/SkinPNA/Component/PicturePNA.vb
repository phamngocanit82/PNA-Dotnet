Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(PicturePNA), "PicturePNA.bmp")> _
Public Class PicturePNA
#Region "ClassPicturePNA"
#Region "Enum"
    Public Enum StylePicture
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
    Public Enum StatePicture
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _style As StylePicture = StylePicture.Style1
    Private _state As StatePicture = StatePicture.Normal
    Dim oMStream As New MemoryStream
    Private _intBitmap As Integer = 0
    Private _img As Bitmap
#End Region
#Region "Properties"
    Public Property Style() As StylePicture
        Get
            Return _style
        End Get
        Set(ByVal Value As StylePicture)
            _style = Value
            Invalidate()
        End Set
    End Property
    Public Property Image() As Bitmap
        Get
            Return _img
        End Get
        Set(ByVal Value As Bitmap)
            _img = Value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, CInt(Height / 2))
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(220, 252, 255), Color.FromArgb(125, 195, 236), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(93, 174, 221), Color.FromArgb(177, 252, 255), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.ForestGreen), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)

            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(93, 174, 221), Color.FromArgb(125, 195, 236), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            If _img Is Nothing Then
                g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            Else
                If _img.Width > Width Or _img.Height > Height Then
                    g.DrawImage(_img, New Rectangle(6, 6, Width - 12, Height - 12))
                Else
                    g.DrawImage(_img, CInt((Width - _img.Width) / 2), CInt((Height - _img.Height) / 2), _img.Width, _img.Height)
                End If
            End If
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style1Normal)", , True)
        End Try
    End Sub
    Private Sub _style1MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 253, 235), Color.FromArgb(255, 235, 182), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 214, 56), Color.FromArgb(255, 232, 167), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.ForestGreen), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)

            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 214, 56), Color.FromArgb(255, 235, 182), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            If Image Is Nothing Then
                g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            Else
                If _img.Width > Width Or _img.Height > Height Then
                    g.DrawImage(_img, New Rectangle(6, 6, Width - 12, Height - 12))
                Else
                    g.DrawImage(_img, CInt((Width - _img.Width) / 2), CInt((Height - _img.Height) / 2), _img.Width, _img.Height)
                End If
            End If
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style1MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(244, 185, 127), Color.FromArgb(244, 175, 71), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(244, 151, 8), Color.FromArgb(244, 196, 68), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)

            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(244, 151, 8), Color.FromArgb(244, 175, 71), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            If Image Is Nothing Then
                g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            Else
                If _img.Width > Width Or _img.Height > Height Then
                    g.DrawImage(_img, New Rectangle(6, 6, Width - 12, Height - 12))
                Else
                    g.DrawImage(_img, CInt((Width - _img.Width) / 2), CInt((Height - _img.Height) / 2), _img.Width, _img.Height)
                End If
            End If
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style1Press)", , True)
        End Try
    End Sub
    Private Sub _style1Picture(ByVal g As Graphics)
        Select Case _state
            Case StatePicture.Normal
                _style1Normal(g)
            Case StatePicture.MouseMove
                _style1MouseMove(g)
            Case StatePicture.Press
                _style1Press(g)
        End Select
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(231, 158, 148), Color.FromArgb(214, 134, 115), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 65, 41), Color.FromArgb(214, 134, 115), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)
            'Cornor
            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 65, 41), Color.FromArgb(214, 134, 115), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            If Image Is Nothing Then
                g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            Else
                'If BImage.Width < Width - 12 And BImage.Height < Height - 12 Then
                '    g.DrawImage(BImage, CInt((Width - BImage.Width) / 2), CInt((Height - BImage.Height) / 2))
                'Else
                '    g.DrawImage(BImage, New Rectangle(6, 6, Width - 12, Height - 12))
                'End If
            End If
            'Cornor1(g, Brush1)
            'Cornor2(g, Brush1)
            'Brush1.Dispose() : Brush1 = Nothing
            'Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 65, 41), Color.FromArgb(214, 134, 115), -90)
            'Cornor3(g, Brush1)
            'Cornor4(g, Brush1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style2Normal)", , True)
        End Try
    End Sub
    Private Sub _style2MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 186, 173), Color.FromArgb(239, 162, 62), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(214, 32, 0), Color.FromArgb(239, 162, 62), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)
            'Cornor
            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(214, 32, 0), Color.FromArgb(239, 162, 62), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            'If BImage Is Nothing Then
            '    g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            'Else
            '    If BImage.Width < Width - 12 And BImage.Height < Height - 12 Then
            '        g.DrawImage(BImage, CInt((Width - BImage.Width) / 2), CInt((Height - BImage.Height) / 2))
            '    Else
            '        g.DrawImage(BImage, New Rectangle(6, 6, Width - 12, Height - 12))
            '    End If
            'End If
            'Cornor1(g, Brush1)
            'Cornor2(g, Brush1)
            'Brush1.Dispose() : Brush1 = Nothing
            'Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(214, 32, 0), Color.FromArgb(239, 162, 62), -90)
            'Cornor3(g, Brush1)
            'Cornor4(g, Brush1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style2MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 142, 115), Color.FromArgb(198, 146, 74), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(132, 24, 0), Color.FromArgb(198, 146, 74), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)
            'Cornor
            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(132, 24, 0), Color.FromArgb(198, 146, 74), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            'If BImage Is Nothing Then
            '    g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            'Else
            '    If BImage.Width < Width - 12 And BImage.Height < Height - 12 Then
            '        g.DrawImage(BImage, CInt((Width - BImage.Width) / 2), CInt((Height - BImage.Height) / 2))
            '    Else
            '        g.DrawImage(BImage, New Rectangle(6, 6, Width - 12, Height - 12))
            '    End If
            'End If
            'Cornor1(g, Brush1)
            'Cornor2(g, Brush1)
            'Brush1.Dispose() : Brush1 = Nothing
            'Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(132, 24, 0), Color.FromArgb(198, 146, 74), -90)
            'Cornor3(g, Brush1)
            'Cornor4(g, Brush1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style2Press)", , True)
        End Try
    End Sub
    Private Sub _style2Picture(ByVal g As Graphics)
        Select Case _state
            Case StatePicture.Normal
                _style2Normal(g)
            Case StatePicture.MouseMove
                _style2MouseMove(g)
            Case StatePicture.Press
                _style2Press(g)
        End Select
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(198, 211, 231), Color.FromArgb(181, 211, 239), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(156, 178, 206), Color.FromArgb(181, 211, 239), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)
            'Cornor
            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(156, 178, 206), Color.FromArgb(181, 211, 239), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            'If BImage Is Nothing Then
            '    g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            'Else
            '    If BImage.Width < Width - 12 And BImage.Height < Height - 12 Then
            '        g.DrawImage(BImage, CInt((Width - BImage.Width) / 2), CInt((Height - BImage.Height) / 2))
            '    Else
            '        g.DrawImage(BImage, New Rectangle(6, 6, Width - 12, Height - 12))
            '    End If
            'End If
            'Cornor1(g, Brush1)
            'Cornor2(g, Brush1)
            'Brush1.Dispose() : Brush1 = Nothing
            'Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(156, 178, 206), Color.FromArgb(181, 211, 239), -90)
            'Cornor3(g, Brush1)
            'Cornor4(g, Brush1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style3Normal)", , True)
        End Try
    End Sub
    Private Sub _style3MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(148, 203, 239), Color.FromArgb(33, 199, 239), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 113, 165), Color.FromArgb(33, 199, 239), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)
            'Cornor
            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 113, 165), Color.FromArgb(33, 199, 239), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            'If BImage Is Nothing Then
            '    g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            'Else
            '    If BImage.Width < Width - 12 And BImage.Height < Height - 12 Then
            '        g.DrawImage(BImage, CInt((Width - BImage.Width) / 2), CInt((Height - BImage.Height) / 2))
            '    Else
            '        g.DrawImage(BImage, New Rectangle(6, 6, Width - 12, Height - 12))
            '    End If
            'End If
            'Cornor1(g, Brush1)
            'Cornor2(g, Brush1)
            'Brush1.Dispose() : Brush1 = Nothing
            'Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 113, 165), Color.FromArgb(33, 199, 239), -90)
            'Cornor3(g, Brush1)
            'Cornor4(g, Brush1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style3MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(107, 138, 156), Color.FromArgb(33, 203, 206), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(33, 56, 82), Color.FromArgb(33, 203, 206), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
            'Border
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2), Width, CInt(Height / 2))
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) - 2, Width, CInt(Height / 2) - 2)
            g.DrawLine(New Pen(Color.White), 0, CInt(Height / 2) + 2, Width, CInt(Height / 2) + 2)
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 5, 5, Width - 11, Height - 11)
            g.FillRectangle(New SolidBrush(Color.White), 6, 6, Width - 12, Height - 12)

            g.DrawLine(New Pen(Color.White), 4, 4, 26, 4)
            g.DrawLine(New Pen(Color.White), 4, 4, 4, 26)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 26, 4)
            g.DrawLine(New Pen(Color.White), Width - 5, 4, Width - 5, 25)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 25, Height - 5)
            g.DrawLine(New Pen(Color.White), 4, Height - 5, 4, Height - 26)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 25, Height - 5)
            g.DrawLine(New Pen(Color.White), Width - 5, Height - 5, Width - 5, Height - 25)
            'Cornor
            Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(33, 56, 82), Color.FromArgb(33, 203, 206), 90)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            'If BImage Is Nothing Then
            '    g.DrawString("Not Image", Font, Brush1, New RectangleF(0, 0, Width, Height), sf)
            'Else
            '    If BImage.Width < Width - 12 And BImage.Height < Height - 12 Then
            '        g.DrawImage(BImage, CInt((Width - BImage.Width) / 2), CInt((Height - BImage.Height) / 2))
            '    Else
            '        g.DrawImage(BImage, New Rectangle(6, 6, Width - 12, Height - 12))
            '    End If
            'End If
            'Cornor1(g, Brush1)
            'Cornor2(g, Brush1)
            'Brush1.Dispose() : Brush1 = Nothing
            'Brush1 = New LinearGradientBrush(BrushSize, Color.FromArgb(33, 56, 82), Color.FromArgb(33, 203, 206), -90)
            'Cornor3(g, Brush1)
            'Cornor4(g, Brush1)
            Brush1.Dispose() : Brush1 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA._style3Press)", , True)
        End Try
    End Sub
    Private Sub _style3Picture(ByVal g As Graphics)
        Select Case _state
            Case StatePicture.Normal
                _style3Normal(g)
            Case StatePicture.MouseMove
                _style3MouseMove(g)
            Case StatePicture.Press
                _style3Press(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintPicture(ByVal g As Graphics)
        Try
            Select Case _style
                Case StylePicture.Style1
                    _style1Picture(g)
                Case StylePicture.Style2
                    _style2Picture(g)
                Case StylePicture.Style3
                    _style3Picture(g)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PaintPicture)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnDoubleClick(ByVal e As System.EventArgs)
        Try
            OpenFileDialog1.FileName = "Picture"
            OpenFileDialog1.Filter = "files (*.jpg;*.bmp;*.gif;*.png;*.ico)|*.jpg;*.bmp;*.gif;*.png;*.ico"
            ' OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_DoubleClick)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Delete Then
                Image = Nothing
                Invalidate()
            End If
            If _state <> StatePicture.Press And e.KeyCode = Keys.Space Then
                _state = StatePicture.Press
                Invalidate()
            End If
            If e.KeyData = Keys.Control + Keys.F2 Then
                SaveFileDialog1.FileName = "Picture"
                SaveFileDialog1.Filter = "files (*.jpg;*.bmp;*.gif;*.png;*.ico)|*.jpg;*.bmp;*.gif;*.png;*.ico"
                ' OpenFileDialog1.FilterIndex = 1
                If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.Image.Save(SaveFileDialog1.FileName)
                End If
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_KeyDown)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StatePicture.Normal Then
                _state = StatePicture.Normal
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_KeyUp)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StatePicture.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StatePicture.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_MouseDown)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StatePicture.Normal Then
                _state = StatePicture.Normal
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_MouseUp)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StatePicture.MouseMove And _state <> StatePicture.Press Then
                _state = StatePicture.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_MouseMove)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StatePicture.Normal Then
                _state = StatePicture.Normal
                Invalidate()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(PicturePNA.PicturePNA_MouseLeave)", , True)
        End Try
    End Sub
    Private Sub PicturePNA_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        PaintPicture(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub
#End Region
#End Region
End Class
