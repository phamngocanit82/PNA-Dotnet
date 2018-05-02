
Public Class frmMain
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oProcess As Process
        Dim i As Integer = 0
        For Each oProcess In Process.GetProcesses(System.Environment.MachineName)
            If oProcess.ProcessName.ToString = "OmegaSlidebar" Then i = i + 1
            If i = 2 Then Application.Exit()
        Next
        Me.Left = Screen.PrimaryScreen.Bounds.Width - Width : Me.Top = 0
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        AddHandler FrmSlidebar1.ButtonPNA41.MouseClick, AddressOf Me.OnMouseClickButton
    End Sub
    Private Sub OnMouseClickButton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Visible = False
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class