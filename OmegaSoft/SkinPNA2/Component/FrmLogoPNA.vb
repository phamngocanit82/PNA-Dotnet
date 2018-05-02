Public Class FrmLogoPNA
    Private Sub FrmLogoPNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = 0 : Top = 0
        Me.ParentForm.Width = Width
        Me.ParentForm.Height = Height
        Me.ParentForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ParentForm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
    End Sub
    Private Sub FrmLogoPNA_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Try
            Left = 0 : Top = 0
            Width = 317 : Height = 144
            Me.ParentForm.Width = Width
            Me.ParentForm.Height = Height
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmLogoPNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Left = 0 : Top = 0
            Width = 317 : Height = 144
            Me.ParentForm.Width = Width
            Me.ParentForm.Height = Height
        Catch ex As Exception

        End Try
    End Sub
End Class
