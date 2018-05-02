Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class frmFindReplace
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
    Private intMouseMove As Boolean
    Private _intWidth As Integer
    Private _intHeight As Integer

    Dim _frm As RichtextPNA
    Private _intX As Integer
    Private _intY As Integer
    Public Sub showForm(ByVal frm As RichtextPNA)
        Dim winRect As New RECT
        GetWindowRect(frm.Handle, winRect)
        _intX = winRect.Left + (winRect.Right - winRect.Left) / 4
        _intY = winRect.Top + (winRect.Bottom - winRect.Top) / 4
        _frm = frm
        Show(frm)
    End Sub
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblInfor.Handle, winRect)
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
#Region "LabelInfor"
    Private Sub lblInfor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblInfor.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                intMouseMove = True
            Else
                intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblInfor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblInfor.MouseMove
        If intMouseMove Then
            _isInnerXY()
        End If
    End Sub
    Private Sub lblInfor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblInfor.MouseUp
        intMouseMove = False
    End Sub
#End Region
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            Dim StartPosition As Integer
            Dim SearchType As CompareMethod
            If chkMatchCase.Checked = True Then
                SearchType = CompareMethod.Binary
            Else
                SearchType = CompareMethod.Text
            End If
            StartPosition = InStr(1, _frm.TextPNA.Text, txtSearchTerm.Text, SearchType)
            If StartPosition = 0 Then
                MessageBox.Show("String: '" & txtSearchTerm.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            _frm.TextPNA.Select(StartPosition - 1, txtSearchTerm.Text.Length)
            _frm.TextPNA.ScrollToCaret()
            _frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click
        Try
            Dim StartPosition As Integer = _frm.TextPNA.SelectionStart + 2
            Dim SearchType As CompareMethod
            If chkMatchCase.Checked = True Then
                SearchType = CompareMethod.Binary
            Else
                SearchType = CompareMethod.Text
            End If
            StartPosition = InStr(StartPosition, _frm.TextPNA.Text, txtSearchTerm.Text, SearchType)
            If StartPosition = 0 Then
                MessageBox.Show("String: '" & txtSearchTerm.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            _frm.TextPNA.Select(StartPosition - 1, txtSearchTerm.Text.Length)
            _frm.TextPNA.ScrollToCaret()
            _frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Try
            If _frm.TextPNA.SelectedText.Length <> 0 Then
                _frm.TextPNA.SelectedText = txtReplacementText.Text
            End If
            Dim StartPosition As Integer = _frm.TextPNA.SelectionStart + 2
            Dim SearchType As CompareMethod
            If chkMatchCase.Checked = True Then
                SearchType = CompareMethod.Binary
            Else
                SearchType = CompareMethod.Text
            End If
            StartPosition = InStr(StartPosition, _frm.TextPNA.Text, txtSearchTerm.Text, SearchType)

            If StartPosition = 0 Then
                MessageBox.Show("String: '" & txtSearchTerm.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            _frm.TextPNA.Select(StartPosition - 1, txtSearchTerm.Text.Length)
            _frm.TextPNA.ScrollToCaret()
            _frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click
        Try
            Dim currentPosition As Integer = _frm.TextPNA.SelectionStart
            Dim currentSelect As Integer = _frm.TextPNA.SelectionLength
            _frm.TextPNA.Rtf = Replace(_frm.TextPNA.Rtf, Trim(txtSearchTerm.Text), Trim(txtReplacementText.Text))
            _frm.TextPNA.SelectionStart = currentPosition
            _frm.TextPNA.SelectionLength = currentSelect
            _frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ButtonFormMainPNA11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFormMainPNA11.Click
        Close() : Dispose()
    End Sub
    Private Sub frmFindReplace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = _intX
        Top = _intY
    End Sub
End Class