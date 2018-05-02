Imports VB = Microsoft.VisualBasic
Imports System.Globalization
Imports System.Drawing
<ToolboxBitmap(GetType(CalendarPNA1), "CalendarPNA1.bmp")> _
Public Class CalendarPNA1
#Region "ClassCalendarPNA1"
    Private Sub _loadDay()
        Try
            Dim i As Integer
            Dim intDays As Integer, intWeek As Integer
            Dim myDateTime As New DateTime(Now.Year, Now.Month, 1)
            intDays = Date.DaysInMonth(Now.Year, Now.Month)
            intWeek = Weekday(myDateTime)
            For i = 2 To intWeek - 1
                Controls.Item(i - 2).Text = ""
                Controls.Item(i - 2).BackColor = Color.Transparent
            Next
            For i = 1 To intDays
                Controls.Item(intWeek - 2).Text = i
                If i = Now.Day Then
                    Controls.Item(intWeek - 2).BackColor = Color.LightSkyBlue
                Else
                    Controls.Item(intWeek - 2).BackColor = Color.Transparent
                End If
                intWeek = intWeek + 1
            Next
            While (intWeek - 2) < 42
                Controls.Item(intWeek - 2).Text = ""
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
    Private Sub CalendarPNA1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _loadDay()
    End Sub
    Private Sub CalendarPNA1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Width = 157 : Height = 128
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        _loadDay()
    End Sub
#End Region
End Class
