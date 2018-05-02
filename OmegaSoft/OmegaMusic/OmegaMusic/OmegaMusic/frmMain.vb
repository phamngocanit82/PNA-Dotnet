Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Public Class frmMain
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
#End Region
#Region "Variables"
    Private _intMouseMove As Boolean
    Private _intX As Integer
    Private _intY As Integer
#End Region
#Region "Methods"
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblCaption.Handle, winRect)
            GetCursorPos(winPoint)
            If _intMouseMove Then
                Location = New Point(winPoint.X - _intX, winPoint.Y - _intY)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 26) Then
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
#Region "lblCaption"
    Private Sub lblCaption_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                _intMouseMove = True
            Else
                _intMouseMove = False
            End If
        Catch ex As Exception
         End Try
    End Sub
    Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXY()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub lblCaption_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseUp
        _intMouseMove = False
    End Sub
#End Region
#End Region
    Private Sub ButtonClose1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClose1.Click
        Application.Exit()
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub ButtonMinimize1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMinimize1.Click
        Visible = False
    End Sub

    Private Sub ButtonNoSound1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNoSound1.Click
        ButtonPlayPause2.PlayPause = Not ButtonPlayPause2.PlayPause

    End Sub
End Class
