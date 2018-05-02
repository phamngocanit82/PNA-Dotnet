Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Public Class FrmProcessPNA
#Region "Struct"
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32")> _
     Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function FindWindowA(ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function SetParent(ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
    End Function
#End Region
#Region "Variables"
    Private _intMouseMove As Boolean
    Private _intX As Integer
    Private _intY As Integer
#End Region
#Region "Properties"
    Public Property Value() As Double
        Get
            Return ProcessBarPNA1.Value
        End Get
        Set(ByVal Value As Double)
            ProcessBarPNA1.Value = Value
            Label1.Text = ProcessBarPNA1.Value & "%"
            ProcessBarPNA1.Refresh()
            Label1.Refresh()
        End Set
    End Property
#End Region
#Region "Methods"
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblProcess.Handle, winRect)
            GetCursorPos(winPoint)
            If _intMouseMove Then
                Me.ParentForm.Location = New Point(winPoint.X - _intX, winPoint.Y - _intY)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intX = winPoint.X - winRect.Left
                    _intY = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception

        End Try
    End Function
#End Region
#Region "Events"
#Region "picBorder"
#Region "lblProcess"
    Private Sub lblProcess_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblProcess.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                _intMouseMove = True
            Else
                _intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblProcess_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblProcess.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXY()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblProcess_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblProcess.MouseUp
        _intMouseMove = False
    End Sub
#End Region
#End Region
#End Region
#Region "Form"
    Private Sub FrmProcessPNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = 0 : Top = 0
        Me.ParentForm.Width = Width
        Me.ParentForm.Height = Height
        Me.ParentForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub
    Private Sub FrmProcessPNA_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Try
            Left = 0 : Top = 0
            Width = 328 : Height = 72
            Me.ParentForm.Width = Width
            Me.ParentForm.Height = Height
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmProcessPNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Left = 0 : Top = 0
            Width = 328 : Height = 72
            Me.ParentForm.Width = Width
            Me.ParentForm.Height = Height
        Catch ex As Exception

        End Try
    End Sub
#End Region
    
End Class
