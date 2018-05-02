Imports System.Drawing
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
<ToolboxBitmap(GetType(NumericStyle1PNA), "NumericPNA.bmp")> _
Public Class NumericStyle1PNA
    Public Shadows Event KeyDown As KeyEventHandler
    Public Shadows Event KeyUp As KeyEventHandler
    Public Shadows Event DoubleClick As System.EventHandler
    Public Shadows Event TextChanged As System.EventHandler
    Public Shadows Event Validating As System.ComponentModel.CancelEventHandler
#Region "ClassNumericStyle1PNA"
#Region "Enum"
    Public Enum StyleTextBox
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
    Public Enum StateTextBox
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _style As StyleTextBox = StyleTextBox.Style1
    Private _state As StateTextBox = StateTextBox.Normal
    Private _bolFocus As Boolean = False
#End Region
#Region "Properties"
    Public Property Style() As StyleTextBox
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleTextBox)
            _style = Value
            PaintTextBox()
        End Set
    End Property
    Public Property CharacterCasing() As CharacterCasing
        Get
            Return txtTextBox.CharacterCasing
        End Get
        Set(ByVal Value As CharacterCasing)
            txtTextBox.CharacterCasing = Value
        End Set
    End Property
    Public Property Value() As Double
        Get
            Return CDbl(txtTextBox.Text)
        End Get
        Set(ByVal Value As Double)
            txtTextBox.Text = Value.ToString
        End Set
    End Property
    Public Property MaxLength() As Integer
        Get
            Return txtTextBox.MaxLength
        End Get
        Set(ByVal Value As Integer)
            txtTextBox.MaxLength = Value
        End Set
    End Property
    Public Property Multiline() As Boolean
        Get
            Return txtTextBox.Multiline
        End Get
        Set(ByVal Value As Boolean)
            txtTextBox.Multiline = Value
            _textBoxResize()
        End Set
    End Property
    Public Property PasswordChar() As Char
        Get
            Return txtTextBox.PasswordChar
        End Get
        Set(ByVal Value As Char)
            txtTextBox.PasswordChar = Value
        End Set
    End Property
    Public Property ScrollBars() As ScrollBars
        Get
            Return txtTextBox.ScrollBars
        End Get
        Set(ByVal Value As ScrollBars)
            txtTextBox.ScrollBars = Value
        End Set
    End Property
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return txtTextBox.TextAlign
        End Get
        Set(ByVal Value As HorizontalAlignment)
            txtTextBox.TextAlign = Value
        End Set
    End Property
    Public Property TReadOnly() As Boolean
        Get
            Return txtTextBox.ReadOnly
        End Get
        Set(ByVal Value As Boolean)
            txtTextBox.ReadOnly = Value
        End Set
    End Property
    Public Shadows Property Enabled() As Boolean
        Get
            Return txtTextBox.Enabled
        End Get
        Set(ByVal Value As Boolean)
            txtTextBox.Enabled = Value
            If Value = False Then
                txtTextBox.BackColor = Color.Gainsboro
            Else
                txtTextBox.BackColor = Color.SeaShell
            End If
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _textBoxResize()
        Try
            GroupBox1.Top = 1
            GroupBox1.Left = 1
            GroupBox1.Width = Width - 2
            txtTextBox.Left = -1
            If txtTextBox.Multiline = False Then
                txtTextBox.Width = GroupBox1.Width + 3
                GroupBox1.Height = txtTextBox.Height - 3
                Height = GroupBox1.Height + 2
            Else
                If txtTextBox.ScrollBars = ScrollBars.Both Or txtTextBox.ScrollBars = ScrollBars.Vertical Then
                    txtTextBox.Width = GroupBox1.Width + 1
                Else
                    txtTextBox.Width = GroupBox1.Width + 2
                End If
                GroupBox1.Height = Height - 2
                txtTextBox.Height = GroupBox1.Height + 3
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style1TextBox()
        Try
            Select Case _state
                Case StateTextBox.Normal
                    txtTextBox.BackColor = Color.FromArgb(239, 255, 255)
                Case StateTextBox.MouseMove
                    txtTextBox.BackColor = Color.FromArgb(255, 253, 235)
                Case StateTextBox.Press
                    txtTextBox.BackColor = Color.White
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style2TextBox()
        Try
            Select Case _state
                Case StateTextBox.Normal
                    txtTextBox.BackColor = Color.FromArgb(255, 185, 193)
                Case StateTextBox.MouseMove
                    txtTextBox.BackColor = Color.FromArgb(255, 202, 214)
                Case StateTextBox.Press
                    txtTextBox.BackColor = Color.White
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _style3TextBox()
        Try
            Select Case _state
                Case StateTextBox.Normal
                    txtTextBox.BackColor = Color.FromArgb(222, 223, 255)
                Case StateTextBox.MouseMove
                    txtTextBox.BackColor = Color.FromArgb(232, 233, 255)
                Case StateTextBox.Press
                    txtTextBox.BackColor = Color.White
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub PaintTextBox()
        Try
            Select Case _style
                Case StyleTextBox.Style1
                    _style1TextBox()
                Case StyleTextBox.Style2
                    _style2TextBox()
                Case StyleTextBox.Style3
                    _style3TextBox()
            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub txtTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTextBox.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub txtTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.GotFocus
        _bolFocus = True
        txtTextBox.BackColor = Color.White
        BackColor = Color.Blue
    End Sub
    Private Sub txtTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.LostFocus
        _bolFocus = False
        BackColor = Color.ForestGreen
        _state = StateTextBox.Normal
        PaintTextBox()
    End Sub
    Private Sub txtTextBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTextBox.MouseMove
        Try
            If _bolFocus = False Then
                _state = StateTextBox.MouseMove
                PaintTextBox()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtTextBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.MouseLeave
        Try
            If _bolFocus = False Then
                _state = StateTextBox.Normal
                PaintTextBox()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTextBox.KeyPress
        Try
            If IsNumeric(e.KeyChar) Then
                e.Handled = Not IsNumeric(txtTextBox.Text & e.KeyChar)
            ElseIf Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        Catch ex As Exception
            txtTextBox.Text = "0"
        End Try
    End Sub
    Private Sub txtTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTextBox.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub
    Private Sub txtTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTextBox.KeyUp
        If txtTextBox.Text = "" Then txtTextBox.Text = Date.Now.Year
        RaiseEvent KeyUp(sender, e)
    End Sub
    Private Sub txtTextBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTextBox.MouseDown
        txtTextBox.Text = Replace(txtTextBox.Text, ",", "")
    End Sub
    Private Sub txtTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTextBox.Validating
        Try
            If CInt(txtTextBox.Text) < 1753 Or CInt(txtTextBox.Text) > 9998 Or txtTextBox.Text.Length < 4 Then
                txtTextBox.Text = Date.Today.Year
            End If
        Catch ex As Exception
            txtTextBox.Text = Date.Today.Year
        End Try
        RaiseEvent Validating(sender, e)
    End Sub
    Private Sub txtTextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.DoubleClick
        RaiseEvent DoubleClick(sender, e)
    End Sub
    Private Sub NumericStyle1PNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Enabled = False Then
                txtTextBox.BackColor = Color.Gainsboro
            Else
                PaintTextBox()
            End If
            BackColor = Color.ForestGreen
            txtTextBox.Text = Date.Today.Year
        Catch ex As Exception

        End Try
    End Sub
    Private Sub NumericStyle1PNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        _textBoxResize()
    End Sub
    Private Sub NumericStyle1PNA_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
        txtTextBox.Font = Font
        _textBoxResize()
    End Sub
    Private Sub NumericStyle1PNA_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ForeColorChanged
        txtTextBox.ForeColor = ForeColor
    End Sub
    Private Sub NumericStyle1PNA_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        If Enabled = False Then txtTextBox.BackColor = Color.Gainsboro
        txtTextBox.Enabled = Enabled
    End Sub
    Private Sub NumericStyle1PNA_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        txtTextBox.Visible = Visible
    End Sub
    Private Sub NumericStyle1PNA_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.CursorChanged
        txtTextBox.Cursor = Cursor
    End Sub
#End Region
#End Region
End Class
