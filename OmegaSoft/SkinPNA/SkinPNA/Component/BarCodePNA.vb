Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports vb = Microsoft.VisualBasic
<ToolboxBitmap(GetType(BarCodePNA), "PicturePNA.bmp")> _
Public Class BarCodePNA
#Region "ClassBarCodePNA"
#Region "Variables"
    Private _bmp As Bitmap
    Private _graph As Graphics
    Private _strBarCode As String
#End Region
#Region "Properties"
    Public Property BarCode() As String
        Get
            Return _strBarCode
        End Get
        Set(ByVal Value As String)
            _strBarCode = Value
            _strBarCode = UCase(_strBarCode)
            If vb.Left(_strBarCode, 1) <> UCase(vb.Chr(1)) Then _strBarCode = vb.Chr(1) & _strBarCode & vb.Chr(2)
            Invalidate()
        End Set
    End Property
    Public Property GetImage() As Bitmap
        Get
            Return _bmp
        End Get
        Set(ByVal Value As Bitmap)

        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _drawBarCode()
        Try
            If _strBarCode.Trim = "" Then Exit Sub
            Dim bc(90) As String
            Dim intPos As Integer = 0
            Dim intY1 As Integer = 0
            Dim intY2 As Integer = 0
            Dim intdw As Integer = 0
            Dim bc_pattern As String
            Dim n As Integer, c As Integer, i As Integer
            If _bmp Is Nothing Then
                _bmp = New Bitmap(229, 23)
                _graph = Graphics.FromImage(_bmp)
            End If
            bc(1) = "1 1221" : bc(2) = "1 1221" : bc(48) = "11 221"
            bc(49) = "21 112" : bc(50) = "12 112" : bc(51) = "22 111"
            bc(52) = "11 212" : bc(53) = "21 211" : bc(54) = "12 211"
            bc(55) = "11 122" : bc(56) = "21 121" : bc(57) = "12 121"
            bc(65) = "211 12" : bc(66) = "121 12" : bc(67) = "221 11"
            bc(68) = "112 12" : bc(69) = "212 11" : bc(70) = "122 11"
            bc(71) = "111 22" : bc(72) = "211 21" : bc(73) = "121 21"
            bc(74) = "112 21" : bc(75) = "2111 2" : bc(76) = "1211 2"
            bc(77) = "2211 1" : bc(78) = "1121 2" : bc(79) = "2121 1"
            bc(80) = "1221 1" : bc(81) = "1112 2" : bc(82) = "2112 1"
            bc(83) = "1212 1" : bc(84) = "1122 1" : bc(85) = "2 1112"
            bc(86) = "1 2112" : bc(87) = "2 2111" : bc(88) = "1 1212"
            bc(89) = "2 1211" : bc(90) = "1 2211" : bc(32) = "1 2121"
            bc(35) = "" : bc(36) = "1 1 1 11" : bc(37) = "11 1 1 1"
            bc(43) = "1 11 1 1" : bc(45) = "1 1122" : bc(47) = "1 1 11 1"
            bc(46) = "2 1121" : bc(64) = "" : bc(42) = "1 1221"
            intY1 = 0
            intY2 = 23
            intdw = CInt(23 / 40)
            If intdw < 1 Then intdw = 1
            For n = 1 To Len(_strBarCode)
                c = vb.Asc(vb.Mid(_strBarCode, n, 1))
                If c > 90 Then c = 0
                bc_pattern = bc(c)
                For i = 1 To vb.Len(bc_pattern)
                    Select Case vb.Mid(bc_pattern, i, 1)
                        Case " "
                            _graph.FillRectangle(Brushes.White, intPos, intY1, intPos + 1 * intdw, intY2)
                            intPos = intPos + intdw
                        Case "1"
                            _graph.FillRectangle(Brushes.White, intPos, intY1, intPos + 1 * intdw, intY2)
                            intPos = intPos + intdw
                            _graph.FillRectangle(Brushes.Black, intPos, intY1, intPos + 1 * intdw, intY2)
                            intPos = intPos + intdw
                        Case "2"
                            _graph.FillRectangle(Brushes.White, intPos, intY1, intPos + 1 * intdw, intY2)
                            intPos = intPos + intdw
                            _graph.FillRectangle(Brushes.Black, intPos, intY1, intPos + 2 * intdw, intY2)
                            intPos = intPos + 2 * intdw
                    End Select
                Next
            Next
            _graph.FillRectangle(Brushes.White, intPos, intY1, intPos + 1 * intdw, intY2)
        Catch ex As Exception
        End Try
    End Sub
    Protected Sub PaintPicture(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle = New Rectangle(0, 0, Width, Height / 2)
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(220, 252, 255), Color.FromArgb(125, 195, 236), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(93, 174, 221), Color.FromArgb(177, 252, 255), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            g.Clear(Color.White)
            g.FillRectangle(Brush1, 0, 0, Width, CInt(Height / 2))
            g.FillRectangle(Brush2, 0, CInt(Height / 2), Width, CInt(Height / 2) - 1)

            'Border
            g.DrawRectangle(New Pen(Color.Blue), 0, 0, Width - 1, Height - 1)
            g.DrawRectangle(New Pen(Color.Black), 3, 3, Width - 7, Height - 7)
            g.FillRectangle(New SolidBrush(Color.White), 4, 4, Width - 8, Height - 8)

            g.DrawLine(New Pen(Color.White), 2, 2, 5, 2)
            g.DrawLine(New Pen(Color.White), 2, 2, 2, 5)
            g.DrawLine(New Pen(Color.White), Width - 3, 2, Width - 6, 2)
            g.DrawLine(New Pen(Color.White), Width - 3, 2, Width - 3, 5)
            g.DrawLine(New Pen(Color.White), Width - 3, Height - 3, Width - 3, Height - 6)
            g.DrawLine(New Pen(Color.White), Width - 3, Height - 3, Width - 6, Height - 3)
            g.DrawLine(New Pen(Color.White), 2, Height - 3, 5, Height - 3)
            g.DrawLine(New Pen(Color.White), 2, Height - 3, 2, Height - 6)
            _drawBarCode()
            If Not _bmp Is Nothing Then
                g.DrawImage(_bmp, 5, 5, Width - 10, Height - 10)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintPicture(e.Graphics)
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
