Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(ButtonPNA1), "ButtonPNA1.bmp")> _
Public Class ButtonPNA1
#Region "ClassButtonPNA1"
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
    End Enum
#End Region
#Region "Variables"
    Private _img(5) As Bitmap
    Private _strToolTip As String
    Private _tipButton As New ToolTip
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
    Private _bolFocus As Boolean = False
    Private _strText As String
#End Region
#Region "Properties"
    Public Property Style() As StyleButton
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleButton)
            _style = Value
            _getResBitmap()
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
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _drawTextAndImage(ByVal g As Graphics)
        Try
            Dim rect As Rectangle = New Rectangle(3, 3, Width - 6, Height - 6)
            Dim sf As New StringFormat
            sf.LineAlignment = StringAlignment.Center
            sf.Alignment = StringAlignment.Center
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
            If Enabled = False Then
                g.DrawImage(_img(4), 0, 0, Width, Height)
                ControlPaint.DrawStringDisabled(g, _strText, Font, Color.White, New RectangleF(0, -1, Width, Height), sf)
            Else
                If _bolFocus And Enabled And _state = StateButton.Normal Then g.DrawImage(_img(3), 0, 0, Width, Height)
                If _bolFocus And Enabled Then ControlPaint.DrawFocusRectangle(g, rect)
                Select Case _state
                    Case StateButton.Normal
                        g.DrawString(_strText, Font, New SolidBrush(ForeColor), New RectangleF(0, 0, Width, Height), sf)
                    Case StateButton.MouseMove
                        g.DrawString(_strText, Font, New SolidBrush(ForeColor), New RectangleF(0, -1, Width, Height), sf)
                    Case StateButton.Press
                        g.DrawString(_strText, Font, New SolidBrush(ForeColor), New RectangleF(0, 0, Width, Height), sf)
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor03.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor04.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor05.png"))
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor06.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor07.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor08.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor09.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor10.png"))
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor11.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor12.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor13.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor14.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.ButtonInfor15.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
    Private Sub _styleNormal(ByVal g As Graphics)
        Try
            g.DrawImage(_img(0), 0, 0, Width, Height)
            _drawTextAndImage(g)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_img(1), 0, 0, Width, Height)
            _drawTextAndImage(g)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePress(ByVal g As Graphics)
        Try
            g.DrawImage(_img(2), 0, 0, Width, Height)
            _drawTextAndImage(g)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleDisable(ByVal g As Graphics)
        Try
            g.DrawImage(_img(4), 0, 0, Width, Height)
            _drawTextAndImage(g)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleButton(ByVal g As Graphics)
        Select Case _state
            Case StateButton.Normal
                _styleNormal(g)
            Case StateButton.MouseMove
                _styleMouseMove(g)
            Case StateButton.Press
                _stylePress(g)
        End Select
    End Sub
#End Region
    Protected Sub PaintButton(ByVal g As Graphics)
        Try
            g.Clear(Color.White)
            _styleButton(g)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub ButtonPNA1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Width = 73 : Height = 21
        _getResBitmap()
    End Sub
    Private Sub ButtonPNA1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub ButtonPNA1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        _bolFocus = False
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Press And e.KeyCode = Keys.Space Then
                _state = StateButton.Press
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateButton.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.Press Then
                _state = StateButton.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
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
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Width = 73 : Height = 21
            Dim gp As New GraphicsPath
            gp.AddLine(0, 1, 1, 0)
            gp.AddLine(1, 0, Width - 2, 0)
            gp.AddLine(Width - 1, 0, Width, 1)
            gp.AddLine(Width, 1, Width - 1, Height - 2)
            gp.AddLine(Width, Height - 2, Width - 2, Height)
            gp.AddLine(0, Height, 1, Height)
            gp.AddLine(0, Height - 2, 0, Height)
            gp.AddLine(0, Height - 1, 0, 1)
            Region = New Region(gp)
            Invalidate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
