Option Explicit On
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(LabelStyle1PNA), "LabelStyle1PNA.bmp")> _
Public Class LabelStyle1PNA
#Region "ClassLabelStyle1PNA"
#Region "Enum"
    Public Enum StateLabel
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _state As StateLabel = StateLabel.Normal
#End Region
#Region "Methods"
    Private Sub _drawTextAndImage(ByVal g As Graphics)
        Try
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            If Enabled Then
                Select Case _state
                    Case StateLabel.Normal
                        If Not Image Is Nothing Then g.DrawImage(Image, CInt(Width / 2 - Image.Width / 2), 5)
                        g.DrawString(Text, Font, New SolidBrush(ForeColor), New RectangleF(0, 20, Width, Height - 20), sf)
                    Case StateLabel.MouseMove
                        If Not Image Is Nothing Then g.DrawImage(Image, CInt(Width / 2 - Image.Width / 2), 4)
                        g.DrawString(Text, Font, New SolidBrush(ForeColor), New RectangleF(0, 19, Width, Height - 20), sf)
                    Case StateLabel.Press
                        If Not Image Is Nothing Then g.DrawImage(Image, CInt(Width / 2 - Image.Width / 2), 5)
                        g.DrawString(Text, Font, New SolidBrush(ForeColor), New RectangleF(0, 20, Width, Height - 20), sf)
                End Select
            Else
                If Not Image Is Nothing Then ControlPaint.DrawImageDisabled(g, Image, CInt(Width / 2 - Image.Width / 2), 5, Color.FromArgb(128, 128, 255))
                g.DrawString(Text, Font, New SolidBrush(Color.FromArgb(188, 188, 188)), New RectangleF(0, 20, Width, Height - 20), sf)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA._drawTextAndImage)", , True)
        End Try
    End Sub
    Private Sub _labelNormal(ByVal g As Graphics)
        Try
            g.FillRectangle(New SolidBrush(Color.FromArgb(255, 255, 255)), 0, 0, Width, Height)
            g.FillEllipse(New SolidBrush(Color.FromArgb(128, 128, 255)), 1, 1, 18, 18)
            g.FillEllipse(New SolidBrush(Color.FromArgb(128, 128, 255)), 1, Height - 19, 18, 18)
            g.FillRectangle(New SolidBrush(Color.FromArgb(128, 128, 255)), 1, 10, 18, Height - 19)

            g.FillEllipse(New SolidBrush(Color.FromArgb(128, 128, 255)), Width - 19, 1, 18, 18)
            g.FillEllipse(New SolidBrush(Color.FromArgb(128, 128, 255)), Width - 19, Height - 19, 18, 18)
            g.FillRectangle(New SolidBrush(Color.FromArgb(128, 128, 255)), Width - 19, 10, 18, Height - 19)
            g.FillRectangle(New SolidBrush(Color.FromArgb(128, 128, 255)), 10, 1, Width - 20, Height - 2)
            _drawTextAndImage(g)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA._labelNormal)", , True)
        End Try
    End Sub
    Private Sub _labelMouseMove(ByVal g As Graphics)
        Try
            g.FillRectangle(New SolidBrush(Color.FromArgb(255, 0, 0)), 0, 0, Width, Height)
            g.FillEllipse(New SolidBrush(Color.FromArgb(192, 255, 255)), 1, 1, 18, 18)
            g.FillEllipse(New SolidBrush(Color.FromArgb(192, 255, 255)), 1, Height - 19, 18, 18)
            g.FillRectangle(New SolidBrush(Color.FromArgb(192, 255, 255)), 1, 10, 18, Height - 19)

            g.FillEllipse(New SolidBrush(Color.FromArgb(192, 255, 255)), Width - 19, 1, 18, 18)
            g.FillEllipse(New SolidBrush(Color.FromArgb(192, 255, 255)), Width - 19, Height - 19, 18, 18)
            g.FillRectangle(New SolidBrush(Color.FromArgb(192, 255, 255)), Width - 19, 10, 18, Height - 19)
            g.FillRectangle(New SolidBrush(Color.FromArgb(192, 255, 255)), 10, 1, Width - 20, Height - 2)
            _drawTextAndImage(g)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA._labelMouseMove)", , True)
        End Try
    End Sub
    Private Sub _labelPress(ByVal g As Graphics)
        Try
            g.FillRectangle(New SolidBrush(Color.FromArgb(255, 128, 0)), 0, 0, Width, Height)
            g.FillEllipse(New SolidBrush(Color.FromArgb(0, 192, 0)), 1, 1, 18, 18)
            g.FillEllipse(New SolidBrush(Color.FromArgb(0, 192, 0)), 1, Height - 19, 18, 18)
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 192, 0)), 1, 10, 18, Height - 19)

            g.FillEllipse(New SolidBrush(Color.FromArgb(0, 192, 0)), Width - 19, 1, 18, 18)
            g.FillEllipse(New SolidBrush(Color.FromArgb(0, 192, 0)), Width - 19, Height - 19, 18, 18)
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 192, 0)), Width - 19, 10, 18, Height - 19)
            g.FillRectangle(New SolidBrush(Color.FromArgb(0, 192, 0)), 10, 1, Width - 20, Height - 2)
            _drawTextAndImage(g)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA._labelPress)", , True)
        End Try
    End Sub
    Protected Sub PaintLabel(ByVal g As Graphics)
        Try
            Select Case _state
                Case StateLabel.Normal
                    _labelNormal(g)
                Case StateLabel.MouseMove
                    _labelMouseMove(g)
                Case StateLabel.Press
                    _labelPress(g)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA.PaintLabel)", , True)
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA.OnMouseDown)", , True)
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA.OnMouseUp)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateLabel.MouseMove And _state <> StateLabel.Press Then
                _state = StateLabel.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA.OnMouseMove)", , True)
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
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA.OnMouseLeave)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintLabel(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Dim gp As New GraphicsPath
            gp.AddArc(0, 0, 18, 18, 180, 90)
            gp.AddLine(9, 0, Width - 9, 0)
            gp.AddArc(Width - 18, 0, 18, 18, 270, 90)
            gp.AddLine(Width, 9, Width, Height - 18)
            gp.AddArc(Width - 18, Height - 18, 18, 18, 0, 90)
            gp.AddLine(Width - 18, Height, 18, Height)
            gp.AddArc(0, Height - 18, 18, 18, 90, 90)
            gp.AddLine(0, Height - 18, 0, 18)
            Region = New Region(gp)
            Invalidate()
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(LabelStyle1PNA.OnResize)", , True)
        End Try
    End Sub
#End Region
#End Region
End Class
