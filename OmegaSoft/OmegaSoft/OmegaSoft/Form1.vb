Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBarPNA1.Value = ProgressBarPNA1.Value + 1
        If ProgressBarPNA1.Value = ProgressBarPNA1.Max Then ProgressBarPNA1.Value = 0
    End Sub
End Class