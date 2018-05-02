Imports VB = Microsoft.VisualBasic
Imports System.Globalization
Imports System.Drawing
Public Class CalendarStylePNA
    Private Sub _loadDay()
        Try
            Dim i As Integer
            Dim intDays As Integer, intWeek As Integer
            intDays = Date.DaysInMonth(Now.Year, Now.Month)
            Dim myDateTime As New DateTime(Now.Year, Now.Month, 1)
            intWeek = Weekday(myDateTime)
            For i = 0 To intWeek - 2
                Controls.Item(i).Text = ""
                Controls.Item(i).BackColor = Color.Transparent
            Next
            For i = 1 To intDays
                Controls.Item(intWeek - 1).Text = i
                If i = Now.Day Then
                    Controls.Item(intWeek - 1).BackColor = Color.LightSkyBlue
                Else
                    Controls.Item(intWeek - 1).BackColor = Color.Transparent
                End If
                intWeek = intWeek + 1
            Next
            While (intWeek - 1) < 42
                Controls.Item(intWeek - 1).Text = ""
                intWeek = intWeek + 1
            End While
            Select Case Now.Month
                Case 1
                    lblDate.Text = "January, " & Now.Year
                Case 2
                    lblDate.Text = "February, " & Now.Year
                Case 3
                    lblDate.Text = "March, " & Now.Year
                Case 4
                    lblDate.Text = "April, " & Now.Year
                Case 5
                    lblDate.Text = "May, " & Now.Year
                Case 6
                    lblDate.Text = "June, " & Now.Year
                Case 7
                    lblDate.Text = "July, " & Now.Year
                Case 8
                    lblDate.Text = "August, " & Now.Year
                Case 9
                    lblDate.Text = "Septemper, " & Now.Year
                Case 10
                    lblDate.Text = "October, " & Now.Year
                Case 11
                    lblDate.Text = "November, " & Now.Year
                Case 12
                    lblDate.Text = "December, " & Now.Year
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CalendarStylePNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _loadDay()
    End Sub
    Private Sub CCalendarStylePNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Width = 157 : Height = 128
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _loadDay()
    End Sub
End Class
