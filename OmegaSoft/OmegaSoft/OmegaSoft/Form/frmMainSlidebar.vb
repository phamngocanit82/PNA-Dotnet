Public Class frmMainSlidebar
#Region " Global Form "
    Private Shared _frmMainSlidebar As frmMainSlidebar
    Public Shared Property GlobalForm() As frmMainSlidebar
        Get
            If _frmMainSlidebar Is Nothing OrElse _frmMainSlidebar.IsDisposed Then
                _frmMainSlidebar = New frmMainSlidebar
            End If
            Return _frmMainSlidebar
        End Get
        Set(ByVal Value As frmMainSlidebar)
            _frmMainSlidebar = Value
        End Set
    End Property
#End Region
    Private Sub frmMainSlidebar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = Screen.PrimaryScreen.Bounds.Width - Width : Me.Top = 0
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        GlobalForm = Me
    End Sub
End Class