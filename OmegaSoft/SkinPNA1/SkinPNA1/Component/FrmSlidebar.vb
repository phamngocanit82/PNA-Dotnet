Imports System.Drawing
<ToolboxBitmap(GetType(FrmSlidebar), "FrmSlidebar.bmp")> _
Public Class FrmSlidebar
    Private Sub FrmSlidebar_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Try
            Left = 0 : Top = 0
            Height = Me.ParentForm.Height
            Me.ParentForm.Width = Width
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmSlidebar_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Resize
        Width = 170
    End Sub
End Class
