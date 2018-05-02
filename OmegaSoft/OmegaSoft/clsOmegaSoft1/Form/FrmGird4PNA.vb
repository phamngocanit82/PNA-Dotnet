Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class FrmGird4PNA
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
    Private intMouseMove As Boolean
    Private _intWidth As Integer
    Private _intHeight As Integer
#End Region
#Region "Properties"

#End Region
#Region "Methods"
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblList.Handle, winRect)
            GetCursorPos(winPoint)
            If intMouseMove Then
                Location = New Point(winPoint.X - _intWidth, winPoint.Y - _intHeight)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intWidth = winPoint.X - winRect.Left
                    _intHeight = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception

        End Try
    End Function
#End Region
#Region "LabelList"
    Private Sub lblList_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblList.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                intMouseMove = True
            Else
                intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblList_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblList.MouseMove
        If intMouseMove Then
            _isInnerXY()
        End If
    End Sub
    Private Sub lblList_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblList.MouseUp
        intMouseMove = False
    End Sub
#End Region

End Class
