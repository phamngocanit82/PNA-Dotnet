Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class ButtonTabPNA
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
    Private _imgBackGround(18) As Bitmap
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
            Else
                _state = StateButton.BackNormal
            End If
            Height = 10
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
    Public Property BIndex() As Integer
        Get
            Return _intIndex
        End Get
        Set(ByVal Value As Integer)
            _intIndex = Value
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
        ''Try
        ''    Dim sf As New StringFormat
        ''    sf.LineAlignment = StringAlignment.Near
        ''    sf.Alignment = StringAlignment.Near
        ''    sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show
        ''    If _bolFocus And Enabled Then ControlPaint.DrawFocusRectangle(g, New Rectangle(3, 3, Width - 4, Height - 21))
        ''    If _img Is Nothing Then
        ''        If _bolBack = False Then
        ''            g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(16, 3, Width - 4, Height - 21), sf)
        ''        Else
        ''            g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(16, 3, Width - 4, Height - 21), sf)
        ''        End If
        ''    Else
        ''        g.DrawImage(_img, 17, 4, 12, 12)
        ''        If _bolBack = False Then
        ''            g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(30, 3, Width - 36, Height), sf)
        ''        Else
        ''            g.DrawString(Text, Font, New SolidBrush(Me.ForeColor), New RectangleF(30, 3, Width - 36, Height), sf)
        ''        End If
        ''    End If
        ''Catch ex As Exception

        'End Try
    End Sub
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    _imgBackGround(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab01.png"))
                    _imgBackGround(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab02.png"))
                    _imgBackGround(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab03.png"))
                    _imgBackGround(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab04.png"))
                    _imgBackGround(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab05.png"))
                    _imgBackGround(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab06.png"))
                    _imgBackGround(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab07.png"))
                    _imgBackGround(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab08.png"))
                    _imgBackGround(8) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab09.png"))
                    _imgBackGround(9) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab10.png"))
                    _imgBackGround(10) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab11.png"))
                    _imgBackGround(11) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab12.png"))
                    _imgBackGround(12) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab13.png"))
                    _imgBackGround(13) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab14.png"))
                    _imgBackGround(14) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab15.png"))
                    _imgBackGround(15) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab16.png"))
                    _imgBackGround(16) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab17.png"))
                    _imgBackGround(17) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab18.png"))
                Case StyleButton.Style2
                    _imgBackGround(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab01.png"))
                    _imgBackGround(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab02.png"))
                    _imgBackGround(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab03.png"))
                    _imgBackGround(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab04.png"))
                    _imgBackGround(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab05.png"))
                    _imgBackGround(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab06.png"))
                    _imgBackGround(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab07.png"))
                    _imgBackGround(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab08.png"))
                    _imgBackGround(8) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab09.png"))
                    _imgBackGround(9) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab10.png"))
                    _imgBackGround(10) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab11.png"))
                    _imgBackGround(11) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab12.png"))
                    _imgBackGround(12) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab13.png"))
                    _imgBackGround(13) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab14.png"))
                    _imgBackGround(14) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab15.png"))
                    _imgBackGround(15) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab16.png"))
                    _imgBackGround(16) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab17.png"))
                    _imgBackGround(17) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab18.png"))
                    _imgBackGround(17) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.ButtonTab18.png"))
                Case StyleButton.Style3
                    _imgBackGround(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab01.png"))
                    _imgBackGround(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab02.png"))
                    _imgBackGround(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab03.png"))
                    _imgBackGround(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab04.png"))
                    _imgBackGround(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab05.png"))
                    _imgBackGround(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab06.png"))
                    _imgBackGround(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab07.png"))
                    _imgBackGround(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab08.png"))
                    _imgBackGround(8) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab09.png"))
                    _imgBackGround(9) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab10.png"))
                    _imgBackGround(10) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab11.png"))
                    _imgBackGround(11) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab12.png"))
                    _imgBackGround(12) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab13.png"))
                    _imgBackGround(13) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab14.png"))
                    _imgBackGround(14) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab15.png"))
                    _imgBackGround(15) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab16.png"))
                    _imgBackGround(16) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab17.png"))
                    _imgBackGround(17) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.ButtonTab18.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style1"
    Private Sub _style1Normal(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(0), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(1), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(2), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style1MouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(3), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(4), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(5), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style1Press(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(6), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(7), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(8), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style1BackNormal(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(9), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(10), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(11), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style1BackMouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(12), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(13), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(14), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style1BackPress(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(15), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(16), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(17), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
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
            g.DrawImage(_imgBackGround(0), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(1), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(2), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style2MouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(3), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(4), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(5), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style2Press(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(6), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(7), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(8), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style2BackNormal(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(9), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(10), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(11), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style2BackMouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(12), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(13), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(14), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style2BackPress(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(15), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(16), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(17), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
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
            g.DrawImage(_imgBackGround(0), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(1), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(2), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style3MouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(3), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(4), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(5), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style3Press(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(6), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(7), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(8), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style3BackNormal(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(9), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(10), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(11), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style3BackMouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(12), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(13), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(14), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _style3BackPress(ByVal g As Graphics)
        Try
            g.DrawImage(_imgBackGround(15), 0, 0, 3, Height)
            g.DrawImage(_imgBackGround(16), 3, 0, Width - 21, Height)
            g.DrawImage(_imgBackGround(17), Width - 19, 0, 19, Height)
            _drawTextAndImage(g)
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
    Private Sub ButtonTabPNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _getResBitmap()
        ' Me.Left = _intLeft : Me.Top = 0
    End Sub
    Private Sub ButtonTabPNA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub ButtonTabPNA_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
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
                Refresh()
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
                Else
                    _state = StateButton.BackNormal
                End If
                Refresh()
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
                Refresh()
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
                Else
                    _state = StateButton.BackNormal
                End If
                Refresh()
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
                Refresh()
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
                Else
                    _state = StateButton.BackNormal
                End If
                Refresh()
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
            Height = 25
            If _bolBack = False Then
                gp.AddLine(1, 0, Width - 19, 0)
                gp.AddLine(Width - 18, 0, Width - 6, 12)
                gp.AddLine(Width - 6, 12, Width - 5, 12)
                gp.AddLine(Width - 6, 12, Width - 6, 15)
                gp.AddLine(Width - 5, 15, Width, Height - 4)
                gp.AddLine(Width, Height - 4, Width, Height)
                gp.AddLine(Width, Height, 0, Height)
                gp.AddLine(0, Height, 0, 1)
                gp.AddLine(0, 1, 1, 0)
                Region = New Region(gp)
            Else
                gp.AddLine(1, 0, Width - 16, 0)
                gp.AddLine(Width - 16, 0, Width - 5, 11)
                gp.AddLine(Width - 5, 11, Width - 4, 11)
                gp.AddLine(Width - 5, 11, Width - 5, 14)
                gp.AddLine(Width - 4, 14, Width, Height - 6)
                gp.AddLine(Width, Height - 6, 0, Height - 6)
                gp.AddLine(0, Height - 6, 0, 1)
                gp.AddLine(0, 1, 1, 0)
                Region = New Region(gp)
            End If
            Refresh()
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
