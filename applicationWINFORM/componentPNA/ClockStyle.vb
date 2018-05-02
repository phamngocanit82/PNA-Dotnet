Imports System.Drawing
Imports System.Math
Public Class ClockStylePNA
    Private xCenter As Integer, yCenter As Integer
    Private intR As Integer = 42
    Private dxHour As Integer, dyHour As Integer
    Private dxMinute As Integer, dyMinute As Integer
    Private dxSecond As Integer, dySecond As Integer
    Private Sub ClockStylePNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Width = 170 : Height = 132
    End Sub
    Private Sub Label1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Label1.Paint
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter, yCenter, xCenter + dxHour, yCenter + dyHour)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter, yCenter - 1, xCenter + dxHour, yCenter + dyHour)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter, yCenter + 1, xCenter + dxHour, yCenter + dyHour)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter - 1, yCenter, xCenter + dxHour, yCenter + dyHour)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter + 1, yCenter, xCenter + dxHour, yCenter + dyHour)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter - 1, yCenter - 1, xCenter + dxHour, yCenter + dyHour)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter + 1, yCenter + 1, xCenter + dxHour, yCenter + dyHour)

        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter, yCenter, xCenter + dxMinute, yCenter + dyMinute)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter, yCenter - 1, xCenter + dxMinute, yCenter + dyMinute)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter, yCenter + 1, xCenter + dxMinute, yCenter + dyMinute)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter - 1, yCenter, xCenter + dxMinute, yCenter + dyMinute)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter + 1, yCenter, xCenter + dxMinute, yCenter + dyMinute)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter - 1, yCenter - 1, xCenter + dxMinute, yCenter + dyMinute)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(63, 206, 237)), xCenter + 1, yCenter + 1, xCenter + dxMinute, yCenter + dyMinute)

        e.Graphics.DrawLine(Pens.Red, xCenter, yCenter, xCenter + dxSecond, yCenter + dySecond)
        e.Graphics.DrawLine(Pens.Red, xCenter, yCenter - 1, xCenter + dxSecond, yCenter + dySecond)
        e.Graphics.DrawLine(Pens.Red, xCenter, yCenter + 1, xCenter + dxSecond, yCenter + dySecond)
        e.Graphics.DrawLine(Pens.Red, xCenter - 1, yCenter, xCenter + dxSecond, yCenter + dySecond)
        e.Graphics.DrawLine(Pens.Red, xCenter + 1, yCenter, xCenter + dxSecond, yCenter + dySecond)
        e.Graphics.DrawLine(Pens.Red, xCenter - 1, yCenter - 1, xCenter + dxSecond, yCenter + dySecond)
        e.Graphics.DrawLine(Pens.Red, xCenter + 1, yCenter + 1, xCenter + dxSecond, yCenter + dySecond)

        e.Graphics.DrawLine(Pens.White, xCenter - 1, yCenter - 2, xCenter + 1, yCenter - 2)
        e.Graphics.DrawLine(Pens.White, xCenter - 2, yCenter - 1, xCenter + 2, yCenter - 1)
        e.Graphics.DrawLine(Pens.White, xCenter - 2, yCenter, xCenter + 2, yCenter)
        e.Graphics.DrawLine(Pens.White, xCenter - 2, yCenter + 1, xCenter + 2, yCenter + 1)
        e.Graphics.DrawLine(Pens.White, xCenter - 1, yCenter + 2, xCenter + 1, yCenter + 2)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        dxHour = Math.Cos((Math.PI / 180) * (Now.Hour * 30 + 270 + Now.Minute / 2)) * (intR - 20)
        dyHour = Math.Sin((Math.PI / 180) * (Now.Hour * 30 + 270 + Now.Minute / 2)) * (intR - 20)
        dxMinute = Math.Cos((Math.PI / 180) * (Now.Minute * 6 + 270)) * (intR - 10)
        dyMinute = Math.Sin((Math.PI / 180) * (Now.Minute * 6 + 270)) * (intR - 10)
        dxSecond = Math.Cos((Math.PI / 180) * (Now.Second * 6 + 270)) * intR
        dySecond = Math.Sin((Math.PI / 180) * (Now.Second * 6 + 270)) * intR
        Invalidate()
    End Sub
    Private Sub ClockStylePNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xCenter = CInt(Label1.Width / 2)
        yCenter = CInt(Label1.Height / 2)
        dxHour = Math.Cos((Math.PI / 180) * (Now.Hour * 6 + 270)) * (intR - 20)
        dyHour = Math.Sin((Math.PI / 180) * (Now.Hour * 6 + 270)) * (intR - 20)
        dxMinute = Math.Cos((Math.PI / 180) * (Now.Minute * 6 + 270)) * (intR - 10)
        dyMinute = Math.Sin((Math.PI / 180) * (Now.Minute * 6 + 270)) * (intR - 10)
        dxSecond = Math.Cos((Math.PI / 180) * (Now.Second * 6 + 270)) * intR
        dySecond = Math.Sin((Math.PI / 180) * (Now.Second * 6 + 270)) * intR
    End Sub
End Class
