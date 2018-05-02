Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports VB = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(DateTimePNA), "DateTimePNA.bmp")> _
Public Class DateTimePNA
     Private frmDateTime As FrmDateTimePNA
    Private _intLanguage As Integer
#Region "ClassDateTimePNA"
#Region "Enum/Struct"
    Public Enum StyleDateTime
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
#End Region
#Region "Variables"
    Private _intDay As Integer
    Private _intMonth As Integer
    Private _intYear As Integer
    Private _bolShow As Boolean = False
    Private _bolReadOnly As Boolean = False
    Private _style As StyleDateTime = StyleDateTime.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleDateTime
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleDateTime)
            _style = Value
            txtDateTime.Style = Value
            btnDateTime.Style = Value
        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            Return txtDateTime.Text.Trim
        End Get
        Set(ByVal Value As String)
            txtDateTime.Text = " " & Value
        End Set
    End Property
    Public Property SetDay() As Integer
        Get
            Return _intDay
        End Get
        Set(ByVal Value As Integer)
            _intDay = Value
        End Set
    End Property
    Public Property SetMonth() As Integer
        Get
            Return _intMonth
        End Get
        Set(ByVal Value As Integer)
            _intMonth = Value
        End Set
    End Property
    Public Property SetYear() As Integer
        Get
            Return _intYear
        End Get
        Set(ByVal Value As Integer)
            _intYear = Value
        End Set
    End Property
    Public Property TReadOnly() As Boolean
        Get
            Return _bolReadOnly
        End Get
        Set(ByVal Value As Boolean)
            _bolReadOnly = Value
        End Set
    End Property
    Public ReadOnly Property GetDay() As Integer
        Get
            Dim intDay As Integer
            Select Case _intLanguage
                Case 0
                    intDay = CInt(VB.Left(txtDateTime.Text.Trim, 2))
                Case 1
                    intDay = CInt(VB.Mid(txtDateTime.Text.Trim, 4, 2))
            End Select
            Return intDay
        End Get
    End Property
    Public ReadOnly Property GetMonth() As Integer
        Get
            Dim intMonth As Integer
            Select Case _intLanguage
                Case 0
                    intMonth = CInt(VB.Mid(txtDateTime.Text.Trim, 4, 2))
                Case 1
                    intMonth = CInt(VB.Left(txtDateTime.Text.Trim, 2))
            End Select
            Return intMonth
        End Get
    End Property
    Public ReadOnly Property GetYear() As Integer
        Get
            Dim intYear As Integer
            Select Case _intLanguage
                Case 0
                    intYear = CInt(VB.Right(txtDateTime.Text.Trim, 4))
                Case 1
                    intYear = CInt(VB.Right(txtDateTime.Text.Trim, 4))
            End Select
            Return intYear
        End Get
    End Property
#End Region
#Region "Methods"
    Private Function _getDayOrMonth(ByVal value As Integer) As String
        If value < 10 Then
            _getDayOrMonth = "0" & value.ToString
        Else
            _getDayOrMonth = value.ToString
        End If
    End Function
    Public Sub SetDate(ByVal intDay As Integer, ByVal intMonth As Integer, ByVal intYear As Integer)
        Try
            _intDay = intDay
            _intMonth = intMonth
            _intYear = intYear
            Select Case _intLanguage
                Case 0
                    txtDateTime.Text = " " & _getDayOrMonth(_intDay) & "/" & _getDayOrMonth(_intMonth) & "/" & _getDayOrMonth(_intYear)
                Case 1
                    txtDateTime.Text = " " & _getDayOrMonth(_intMonth) & "/" & _getDayOrMonth(_intDay) & "/" & _getDayOrMonth(_intYear)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(DateTimePNA.SetDate)", , True)
        End Try
    End Sub
    Public Function GetDate() As String
        Dim strDate As String = ""
        Select Case _intLanguage
            Case 0
                _intDay = CInt(VB.Left(txtDateTime.Text.Trim, 2))
                _intMonth = CInt(VB.Mid(txtDateTime.Text.Trim, 4, 2))
                _intYear = CInt(VB.Right(txtDateTime.Text.Trim, 4))
                strDate = _getDayOrMonth(_intMonth) & "/" & _getDayOrMonth(_intDay) & "/" & _getDayOrMonth(_intYear)
            Case 1
                _intDay = CInt(VB.Mid(txtDateTime.Text.Trim, 4, 2))
                _intMonth = CInt(VB.Left(txtDateTime.Text.Trim, 2))
                _intYear = CInt(VB.Right(txtDateTime.Text.Trim, 4))
                strDate = txtDateTime.Text.Trim
        End Select
        Return strDate
    End Function
    Public Sub LoadDate()
        Try
            Select Case _intLanguage
                Case 0
                    txtDateTime.Text = " " & _getDayOrMonth(Now.Day) & "/" & _getDayOrMonth(Now.Month) & "/" & _getDayOrMonth(Now.Year)
                Case 1
                    txtDateTime.Text = " " & _getDayOrMonth(Now.Month) & "/" & _getDayOrMonth(Now.Day) & "/" & _getDayOrMonth(Now.Year)
            End Select
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(DateTimePNA._loadDate)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
    Private Sub DateTimePNA_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FontChanged
        txtDateTime.Font = Font
        Height = txtDateTime.THeight
        btnDateTime.Height = txtDateTime.Height
    End Sub
    Private Sub btnDateTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDateTime.Click
        Try
            If _bolReadOnly Then Exit Sub
            Dim mRect As New RECT
            Dim mLeft As Integer, mTop As Integer
            GetWindowRect(Me.Handle, mRect)
            If frmDateTime Is Nothing OrElse frmDateTime.IsDisposed Then frmDateTime = New FrmDateTimePNA
            If mRect.Left + frmDateTime.Width > Screen.PrimaryScreen.Bounds.Right Then
                mLeft = Screen.PrimaryScreen.Bounds.Right - frmDateTime.Width
            Else
                mLeft = mRect.Left
            End If
            If mRect.Bottom + frmDateTime.Height > Screen.PrimaryScreen.Bounds.Bottom Then
                mTop = mRect.Top - frmDateTime.Height - 2
            Else
                mTop = mRect.Bottom + 2
            End If
            If mLeft < 0 Then mLeft = 0
            If mTop < 0 Then mTop = 0
            If _bolShow = False Then
                frmDateTime._intLeft = mLeft
                frmDateTime._intTop = mTop
                _bolShow = True
            Else
                frmDateTime.Left = mLeft
                frmDateTime.Top = mTop
            End If
            frmDateTime.Visible = True
            frmDateTime.Style = _style
            frmDateTime.LoadDay()
            tmrDateTime.Enabled = True
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(DateTimePNA.btnDateTime_Click)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            btnDateTime.Left = Width - btnDateTime.Width
            txtDateTime.Width = Width - btnDateTime.Width - 1
            Height = txtDateTime.THeight
            btnDateTime.Height = txtDateTime.THeight
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(DateTimePNA.OnResize)", , True)
        End Try
    End Sub
    Private Sub DateTimePNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case clsConfig.GetLangPNA
                Case "VietNamese"
                    _intLanguage = 0
                Case "English"
                    _intLanguage = 1
            End Select
            LoadDate()
        Catch ex As Exception
            '   ShowInfor(Nothing, "", ex.Message.ToString & "(DateTimePNA.DateTimePNA_Load)", , True)
        End Try
    End Sub
    Private Sub tmrDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDateTime.Tick
        If frmDateTime.Visible = False Then
            txtDateTime.Text = " " & frmDateTime.TDateTime
            tmrDateTime.Enabled = False
        End If
    End Sub
#End Region
#End Region
End Class
