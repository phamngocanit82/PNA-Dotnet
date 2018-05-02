Public Class frmTaskbar
#Region " Global Form "
    Private Shared _frmTaskbar As frmTaskbar
    Public Shared Property GlobalForm() As frmTaskbar
        Get
            If _frmTaskbar Is Nothing OrElse _frmTaskbar.IsDisposed Then
                _frmTaskbar = New frmTaskbar
            End If
            Return _frmTaskbar
        End Get
        Set(ByVal Value As frmTaskbar)
            _frmTaskbar = Value
        End Set
    End Property
#End Region
    Private Sub frmTaskbar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmTaskbar.GlobalForm = Me
    End Sub
End Class