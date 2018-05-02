Imports System.Drawing
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
<ToolboxBitmap(GetType(TextBoxStyle1PNA), "TextBoxPNA.bmp")> _
Public Class TextBoxStyle1PNA
    Public Shadows Event KeyDown As KeyEventHandler
    Public Shadows Event DoubleClick As System.EventHandler
    Public Shadows Event TextChanged As System.EventHandler
    Public Shadows Event Validating As System.ComponentModel.CancelEventHandler
#Region "ClassTextBoxStyle1PNA"
#Region "Enum"
    Public Enum StyleTextBox
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _style As StyleTextBox = StyleTextBox.Style1
    Private _strText(3) As String
    Private _strMenu(3) As String
    Private _imgMenu(3) As Bitmap
    Private _intIndex As Integer = 0
#End Region
#Region "Properties"
    Public Property Text1() As String
        Get
            Return _strText(0)
        End Get
        Set(ByVal Value As String)
            _strText(0) = Value
        End Set
    End Property
    Public Property Text2() As String
        Get
            Return _strText(1)
        End Get
        Set(ByVal Value As String)
            _strText(1) = Value
        End Set
    End Property
    Public Property Text3() As String
        Get
            Return _strText(2)
        End Get
        Set(ByVal Value As String)
            _strText(2) = Value
        End Set
    End Property
    Public Property TextMenu1() As String
        Get
            Return _strMenu(0)
        End Get
        Set(ByVal Value As String)
            _strMenu(0) = Value
        End Set
    End Property
    Public Property TextMenu2() As String
        Get
            Return _strMenu(1)
        End Get
        Set(ByVal Value As String)
            _strMenu(1) = Value
        End Set
    End Property
    Public Property TextMenu3() As String
        Get
            Return _strMenu(2)
        End Get
        Set(ByVal Value As String)
            _strMenu(2) = Value
        End Set
    End Property
    Public Property Image1() As Bitmap
        Get
            Return _imgMenu(0)
        End Get
        Set(ByVal Value As Bitmap)
            _imgMenu(0) = Value
        End Set
    End Property
    Public Property Image2() As Bitmap
        Get
            Return _imgMenu(1)
        End Get
        Set(ByVal Value As Bitmap)
            _imgMenu(1) = Value
        End Set
    End Property
    Public Property Image3() As Bitmap
        Get
            Return _imgMenu(2)
        End Get
        Set(ByVal Value As Bitmap)
            _imgMenu(2) = Value
        End Set
    End Property
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
    Private Sub _loadItem()
        Try
            If cmnuTextBox.Items.Count > 0 Then Exit Sub
            Dim i As Integer
            For i = 0 To 2
                Dim mItem As New ToolStripMenuItem
                mItem.Text = _strMenu(i)
                mItem.Image = _imgMenu(i)
                mItem.Tag = i
                cmnuTextBox.Items.Add(mItem)
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _textBoxResize()
        Try
            txtTextBox.Left = 0 : txtTextBox.Top = 0
            txtTextBox.Width = Width - btnButton.Width - 1
            btnButton.Left = Width - btnButton.Width : btnButton.Top = 0
            btnButton.Height = txtTextBox.Height
            Height = txtTextBox.Height
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
        _strText(_intIndex) = txtTextBox.Text
        RaiseEvent Validating(sender, e)
    End Sub
    Private Sub txtTextBox_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTextBox.DoubleClick
        RaiseEvent DoubleClick(sender, e)
    End Sub
    Private Sub TextBoxStyle1PNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PaintTextBox()
        _textBoxResize()
    End Sub
    Private Sub TextBoxStyle1PNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        _textBoxResize()
    End Sub
    Private Sub TextBoxStyle1PNA_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
        txtTextBox.Font = Font
        _textBoxResize()
    End Sub
    Private Sub TextBoxStyle1PNA_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ForeColorChanged
        txtTextBox.ForeColor = ForeColor
    End Sub
    Private Sub TextBoxStyle1PNA_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.EnabledChanged
        txtTextBox.Enabled = Enabled
    End Sub
    Private Sub TextBoxStyle1PNA_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        txtTextBox.Visible = Visible
    End Sub
    Private Sub TextBoxStyle1PNA_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.CursorChanged
        txtTextBox.Cursor = Cursor
    End Sub
    Private Sub btnButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButton.Click
        _loadItem()
        cmnuTextBox.Show(btnButton, 0, btnButton.Height)
    End Sub
    Private Sub cmnuTextBox_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles cmnuTextBox.ItemClicked
        Try
            Select Case e.ClickedItem.Tag
                Case 0
                    txtTextBox.Text = _strText(0)
                Case 1
                    txtTextBox.Text = _strText(1)
                Case 2
                    txtTextBox.Text = _strText(2)
            End Select
            _intIndex = e.ClickedItem.Tag
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
