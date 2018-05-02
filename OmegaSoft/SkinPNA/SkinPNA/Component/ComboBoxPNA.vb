Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(ComboBoxPNA), "ComboBoxPNA.bmp")> _
Public Class ComboBoxPNA
#Region "ClassComboBoxPNA"
#Region "Enum"
    Public Enum StyleComboBox
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
    Private Enum StateComboBox
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _bolFocus As Boolean = False
    Private _state As StateComboBox = StateComboBox.Normal
    Private _style As StyleComboBox = StyleComboBox.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleComboBox
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleComboBox)
            _style = Value
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _drawText(ByVal g As Graphics)
        Try
            Dim strTmp As String = "", TextLocation As PointF
            If Me.DropDownStyle <> ComboBoxStyle.DropDownList Then Exit Sub
            If g.MeasureString(Me.Text, Me.Font).Width > Me.Width - 18 Then
                Dim i As Integer = -1
                Do
                    i += 1
                    If g.MeasureString(Me.Text, Me.Font).Width > Me.Width - 18 Then Exit Do
                    strTmp = strTmp & Me.Text.Substring(i, 1)
                Loop
            Else
                strTmp = Me.Text
            End If
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                TextLocation = New PointF(1, 4)
            Else
                Dim temp As Single = Me.Width - (g.MeasureString(strTmp, Me.Font).Width)
                TextLocation = New PointF(temp, 4)
            End If
            If Enabled Then
                g.DrawString(Text, Me.Font, New SolidBrush(Me.ForeColor), TextLocation)
            Else
                g.DrawString(Text, Me.Font, New SolidBrush(Color.DarkGray), TextLocation)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._drawText)", , True)
        End Try
    End Sub
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(220, 252, 255), Color.FromArgb(125, 195, 236), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(93, 174, 221), Color.FromArgb(177, 252, 255), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style1Normal)", , True)
        End Try
    End Sub
    Private Sub _style1MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 253, 235), Color.FromArgb(255, 235, 182), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 214, 56), Color.FromArgb(255, 232, 167), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style1MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(244, 185, 127), Color.FromArgb(244, 175, 71), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(244, 151, 8), Color.FromArgb(244, 196, 68), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style1Press)", , True)
        End Try
    End Sub
    Private Sub _style1ComboBox(ByVal g As Graphics)
        Select Case _state
            Case StateComboBox.Normal
                _style1Normal(g)
            Case StateComboBox.MouseMove
                _style1MouseMove(g)
            Case StateComboBox.Press
                _style1Press(g)
        End Select
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(231, 158, 148), Color.FromArgb(214, 134, 115), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 65, 41), Color.FromArgb(214, 134, 115), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style2Normal)", , True)
        End Try
    End Sub
    Private Sub _style2MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(255, 186, 173), Color.FromArgb(239, 162, 62), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(214, 32, 0), Color.FromArgb(239, 162, 62), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style2MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(189, 142, 115), Color.FromArgb(198, 146, 74), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(132, 24, 0), Color.FromArgb(198, 146, 74), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style2Press)", , True)
        End Try
    End Sub
    Private Sub _style2ComboBox(ByVal g As Graphics)
        Select Case _state
            Case StateComboBox.Normal
                _style2Normal(g)
            Case StateComboBox.MouseMove
                _style2MouseMove(g)
            Case StateComboBox.Press
                _style2Press(g)
        End Select
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Normal(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(198, 211, 231), Color.FromArgb(181, 211, 239), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(156, 178, 206), Color.FromArgb(181, 211, 239), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 98, 173)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style3Normal)", , True)
        End Try
    End Sub
    Private Sub _style3MouseMove(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(148, 203, 239), Color.FromArgb(33, 199, 239), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(41, 113, 165), Color.FromArgb(33, 199, 239), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 173)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style3MouseMove)", , True)
        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            Dim BrushSize As Rectangle
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                BrushSize = New Rectangle(Me.Width - 18, 1, 17, Me.Height - 2)
            Else
                BrushSize = New Rectangle(1, 1, 17, Me.Height - 2)
            End If
            Dim Brush1 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(107, 138, 156), Color.FromArgb(33, 203, 206), 90)
            Dim Brush2 As LinearGradientBrush = New LinearGradientBrush(BrushSize, Color.FromArgb(33, 56, 82), Color.FromArgb(33, 203, 206), -90)
            Brush1.WrapMode = WrapMode.TileFlipXY
            Brush2.WrapMode = WrapMode.TileFlipXY
            If Me.RightToLeft = Windows.Forms.RightToLeft.No Then
                g.FillRectangle(Brush1, Me.Width - 18, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, Me.Width - 18, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), Me.Width - 18, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), Me.Width - 19, 1, Me.Width - 19, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 13, CInt(Me.Height / 2) - 4, Me.Width - 7, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 12, CInt(Me.Height / 2) - 3, Me.Width - 8, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 12, CInt(Me.Height / 2) - 2, Me.Width - 8, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 11, CInt(Me.Height / 2) - 1, Me.Width - 9, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 11, CInt(Me.Height / 2), Me.Width - 9, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), Me.Width - 10, CInt(Me.Height / 2), Me.Width - 10, CInt(Me.Height / 2) + 2)
            Else
                g.FillRectangle(Brush1, 1, 1, 17, CInt(Me.Height / 2) - 1)
                g.FillRectangle(Brush2, 1, CInt(Me.Height / 2), 17, CInt(Me.Height / 2) - 1)
                g.DrawRectangle(New Pen(Color.White), 1, 1, 16, Me.Height - 3)
                If _bolFocus Then
                    g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(0, 0, 255)), 0, 0, Me.Width - 1, Me.Height - 1)
                Else
                    g.DrawLine(New Pen(Color.FromArgb(90, 109, 140)), 18, 1, 18, Me.Height - 1)
                    g.DrawRectangle(New Pen(Color.FromArgb(90, 109, 140)), 0, 0, Me.Width - 1, Me.Height - 1)
                End If
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 6, CInt(Me.Height / 2) - 4, 12, CInt(Me.Height / 2) - 4)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 7, CInt(Me.Height / 2) - 3, 11, CInt(Me.Height / 2) - 3)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 7, CInt(Me.Height / 2) - 2, 11, CInt(Me.Height / 2) - 2)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 8, CInt(Me.Height / 2) - 1, 10, CInt(Me.Height / 2) - 1)
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 8, CInt(Me.Height / 2), 10, CInt(Me.Height / 2))
                g.DrawLine(New Pen(Color.FromArgb(0, 0, 255)), 9, CInt(Me.Height / 2), 9, CInt(Me.Height / 2) + 2)
            End If
            Brush1.Dispose() : Brush1 = Nothing
            Brush2.Dispose() : Brush2 = Nothing
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA._style3Press)", , True)
        End Try
    End Sub
    Private Sub _style3ComboBox(ByVal g As Graphics)
        Select Case _state
            Case StateComboBox.Normal
                _style3Normal(g)
            Case StateComboBox.MouseMove
                _style3MouseMove(g)
            Case StateComboBox.Press
                _style3Press(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            _drawText(g)
            Select Case _style
                Case StyleComboBox.Style1
                    _style1ComboBox(g)
                Case StyleComboBox.Style2
                    _style2ComboBox(g)
                Case StyleComboBox.Style3
                    _style3ComboBox(g)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA.PaintButton)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ComboBoxPNA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub ComboBoxPNA_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        _bolFocus = False
        Invalidate()
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Try
            MyBase.WndProc(m)
            Select Case m.Msg
                Case &HF 'WM_PAINT
                    If Me.DropDownStyle = ComboBoxStyle.Simple Then Exit Sub
                    Dim g As Graphics = Me.CreateGraphics
                    If Me.Enabled Then
                        g.Clear(Color.White)
                    Else
                        g.Clear(Color.FromName("Control"))
                    End If
                    PaintButton(g)
                Case &H201  'WM_LBUTTONDOWN
                    If _state <> StateComboBox.Press Then
                        _state = StateComboBox.Press
                        Invalidate()
                    End If
                Case &H202 'WM_LBUTTONUP
                    If _state <> StateComboBox.Normal Then
                        _state = StateComboBox.Normal
                        Invalidate()
                    End If
                Case &H200 'WM_MOUSEMOVE
                    If _state <> StateComboBox.MouseMove And _state <> StateComboBox.Press Then
                        _state = StateComboBox.MouseMove
                        Invalidate()
                    End If
                Case &H2A3 'WM_MOUSELEAVE 
                    If _state <> StateComboBox.Normal Then
                        _state = StateComboBox.Normal
                        Invalidate()
                    End If
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(ComboBoxPNA.WndProc)", , True)
        End Try
    End Sub
#End Region
#End Region
End Class
