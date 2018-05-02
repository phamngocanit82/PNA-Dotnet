Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(LabelStyle2PNA), "LabelStyle2PNA.bmp")> _
Public Class LabelStyle2PNA
#Region "ClassLabelStyle2PNA"
#Region "Enum"
    Public Enum StyleLabel
        Style1 = 0
        Style2 = 1
        Style3 = 2
        Style4 = 3
    End Enum
    Public Enum StateLabel
        Normal = 0
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _state As StateLabel = StateLabel.Normal
    Private _style As StyleLabel = StyleLabel.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleLabel
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleLabel)
            _style = Value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(BackColor), 0, 0, Width, Height)
            g.FillEllipse(New SolidBrush(Color.FromArgb(132, 130, 255)), 0, 0, Width, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 4, 3, 17, 3)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 5, 4, 21, 4)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 18, 5, 23, 5)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 21, 6, 24, 6)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 24, 7, 24, 13)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 25, 7, 25, 11)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 23, 11, 23, 14)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 22, 13, 22, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 21, 14, 21, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 20, 14, 20, 16)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 8, 15, 19, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 5, 15, 19, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 7, 16, 19, 16)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 4, 14, 7, 14)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 3, 13, 5, 13)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 2, 12, 4, 12)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 3, 11, 5, 11)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 4, 10, 7, 10)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 5, 9, 13, 9)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 0)), 7, 8, 12, 8)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.White), New RectangleF(0, 0, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style1Normal)", , True)
        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(BackColor), 0, 0, Width, Height)
            g.FillEllipse(New SolidBrush(Color.FromArgb(0, 0, 255)), 0, 0, Width, Height - 1)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 4, 3, 17, 3)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 5, 4, 21, 4)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 18, 5, 23, 5)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 21, 6, 24, 6)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 24, 7, 24, 13)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 25, 7, 25, 11)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 23, 11, 23, 14)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 22, 13, 22, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 21, 14, 21, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 20, 14, 20, 16)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 8, 15, 19, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 5, 15, 19, 15)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 7, 16, 19, 16)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 4, 14, 7, 14)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 3, 13, 5, 13)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 2, 12, 4, 12)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 3, 11, 5, 11)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 4, 10, 7, 10)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 5, 9, 13, 9)
            g.DrawLine(New Pen(Color.FromArgb(255, 0, 255)), 7, 8, 12, 8)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.White), New RectangleF(0, 1, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style1Press)", , True)
        End Try
    End Sub
    Private Sub _style1Label(ByVal g As Graphics)
        Select Case _state
            Case StateLabel.Normal
                _style1Normal(g)
            Case StateLabel.Press
                _style1Press(g)
        End Select
    End Sub
#End Region
#Region "Style2"
    Private Sub _style2Normal(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(Color.FromArgb(198, 195, 255)), 0, 0, Width, Height)
            g.DrawRectangle(New Pen(Color.FromArgb(255, 0, 128)), 1, 1, Width - 3, Height - 3)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(0, 255, 255)), New RectangleF(0, 0, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style2Normal)", , True)
        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 0, 255)), 0, 0, Width, Height)
            g.DrawRectangle(New Pen(Color.FromArgb(255, 0, 0)), 1, 1, Width - 3, Height - 3)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.White), New RectangleF(0, 1, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style2Press)", , True)
        End Try
    End Sub
    Private Sub _style2Label(ByVal g As Graphics)
        Select Case _state
            Case StateLabel.Normal
                _style2Normal(g)
            Case StateLabel.Press
                _style2Press(g)
        End Select
    End Sub
#End Region
#Region "Style3"
    Private Sub _style3Normal(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(BackColor), 0, 0, Width, Height)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.Black), New RectangleF(0, 0, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style3Normal)", , True)
        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 0, 255)), 0, 0, Width, Height)
            ControlPaint.DrawFocusRectangle(g, New Rectangle(1, 1, Width - 2, Height - 2), Color.White, Color.Blue)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.White), New RectangleF(0, 1, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style3Press)", , True)
        End Try
    End Sub
    Private Sub _style3Label(ByVal g As Graphics)
        Select Case _state
            Case StateLabel.Normal
                _style3Normal(g)
            Case StateLabel.Press
                _style3Press(g)
        End Select
    End Sub
#End Region
#Region "Style4"
    Private Sub _style4Normal(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 0, 255)), 0, 0, Width, Height)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.White), New RectangleF(0, 0, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style4Normal)", , True)
        End Try
    End Sub
    Private Sub _style4Press(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 0, 255)), 0, 0, Width, Height)
            ControlPaint.DrawFocusRectangle(g, New Rectangle(1, 1, Width - 2, Height - 2), Color.White, Color.Blue)
            If Enabled Then
                g.DrawString(Text, Font, New SolidBrush(Color.White), New RectangleF(0, 1, Width, Height), sf)
            Else
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 0, Width, Height), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA._style4Press)", , True)
        End Try
    End Sub
    Private Sub _style4Label(ByVal g As Graphics)
        Select Case _state
            Case StateLabel.Normal
                _style4Normal(g)
            Case StateLabel.Press
                _style4Press(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintLabel(ByVal g As Graphics)
        Try
            Select Case _style
                Case StyleLabel.Style1
                    _style1Label(g)
                Case StyleLabel.Style2
                    _style2Label(g)
                Case StyleLabel.Style3
                    _style3Label(g)
                Case StyleLabel.Style4
                    _style4Label(g)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA.PaintLabel)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateLabel.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateLabel.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA.OnMouseDown)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateLabel.Normal Then
                _state = StateLabel.Normal
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA.OnMouseUp)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateLabel.Normal Then
                _state = StateLabel.Normal
                Invalidate()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA.OnMouseLeave)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintLabel(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Width = 28 : Height = 18
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle2PNA.OnResize)", , True)
        End Try
    End Sub
#End Region
#End Region
End Class
