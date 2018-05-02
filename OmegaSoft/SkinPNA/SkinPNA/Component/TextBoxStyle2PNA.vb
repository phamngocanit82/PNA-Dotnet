Imports System.Drawing
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
'<ToolboxBitmap(GetType(TextBoxStyle2PNA), "TextBoxPNA.bmp")> _
Public Class TextBoxStyle2PNA
    Public Shadows Event KeyDown As KeyEventHandler
    Public Shadows Event DoubleClick As System.EventHandler
    Public Shadows Event TextChanged As System.EventHandler
    Public Shadows Event Validating As System.ComponentModel.CancelEventHandler
    Public Shadows Event Click As System.EventHandler
#Region "ClassTextBoxStyle2PNA"
#Region "Enum"
    Public Enum StyleTextBox
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _style As StyleTextBox = StyleTextBox.Style1
    Private _strText
    Private _intIndex As Integer = 0
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
    Public Property TText() As String
        Get
            Return txtTextBox.Text
        End Get
        Set(ByVal Value As String)
            txtTextBox.Text = Value
        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            Return txtTextBox.Text
        End Get
        Set(ByVal Value As String)
            txtTextBox.Text = Value
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
            Return txtTextBox.TReadOnly
        End Get
        Set(ByVal Value As Boolean)
            txtTextBox.TReadOnly = Value
        End Set
    End Property
    Public Shadows Property Enabled() As Boolean
        Get
            Return txtTextBox.Enabled
        End Get
        Set(ByVal Value As Boolean)
            txtTextBox.Enabled = Value
            btnButton.Enabled = Value
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _textBoxResize()
        Try
            txtTextBox.Left = 0 : txtTextBox.Top = 0
            btnButton.Width = 20
            btnButton.Left = Width - btnButton.Width : btnButton.Top = 0
            txtTextBox.Width = Width - btnButton.Width - 1
            Height = txtTextBox.Height
            btnButton.Height = txtTextBox.THeight
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub PaintTextBox()
        Try
            txtTextBox.Style = _style
            btnButton.Style = _style
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub txtTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTextBox.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub txtTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTextBox.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub
    Private Sub txtTextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTextBox.Validating
        RaiseEvent Validating(sender, e)
    End Sub
    Private Sub txtTextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.DoubleClick
        RaiseEvent DoubleClick(sender, e)
    End Sub
    Private Sub TextBoxStyle2PNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PaintTextBox()
        _textBoxResize()
    End Sub
    Private Sub TextBoxStyle2PNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        _textBoxResize()
    End Sub
    Private Sub TextBoxStyle2PNA_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
        txtTextBox.Font = Font
        _textBoxResize()
    End Sub
    Private Sub TextBoxStyle2PNA_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ForeColorChanged
        txtTextBox.ForeColor = ForeColor
    End Sub
    Private Sub TextBoxStyle2PNA_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        txtTextBox.Enabled = Enabled
    End Sub
    Private Sub TextBoxStyle2PNA_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        txtTextBox.Visible = Visible
    End Sub
    Private Sub TextBoxStyle2PNA_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.CursorChanged
        txtTextBox.Cursor = Cursor
    End Sub
    Private Sub btnButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton.Click
        RaiseEvent Click(sender, e)
    End Sub
#End Region
#End Region
End Class
