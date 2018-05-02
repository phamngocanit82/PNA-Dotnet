Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
<ToolboxBitmap(GetType(LinePNA2), "LinePNA1.bmp")> _
Public Class LinePNA2
#Region "ClassLinePNA2"
#Region "Enum"
    Public Enum Styleline
        Style1 = 0
        Style2 = 1
    End Enum
#End Region
#Region "Variables"
    Private _style As Styleline = Styleline.Style1
#End Region
#Region "Properties"
    Public Property Style() As Styleline
        Get
            Return _style
        End Get
        Set(ByVal Value As Styleline)
            _style = Value
            Invalidate()
        End Set
    End Property
#End Region
    Private Sub LinePNA2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Select Case _style
            Case Styleline.Style1
                e.Graphics.DrawLine(New Pen(ForeColor), 0, 0, 0, Height)
                e.Graphics.DrawLine(New Pen(ForeColor), Width - 1, 0, Width - 1, Height)
            Case Styleline.Style2
                e.Graphics.DrawLine(New Pen(ForeColor), 0, 0, 0, Height)
        End Select
    End Sub
    Private Sub LinePNA2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Width = 3
        Invalidate()
    End Sub
#End Region
End Class
