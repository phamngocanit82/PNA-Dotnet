Imports System.Windows.Forms
Imports clsOmegaSoft.clsMethods
Public Class frmFlash
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents axFlashIntro As AxShockwaveFlashObjects.AxShockwaveFlash
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlash))
        Me.axFlashIntro = New AxShockwaveFlashObjects.AxShockwaveFlash
        CType(Me.axFlashIntro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'axFlashIntro
        '
        Me.axFlashIntro.Enabled = True
        Me.axFlashIntro.Location = New System.Drawing.Point(0, 0)
        Me.axFlashIntro.Name = "axFlashIntro"
        Me.axFlashIntro.OcxState = CType(resources.GetObject("axFlashIntro.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axFlashIntro.Size = New System.Drawing.Size(600, 400)
        Me.axFlashIntro.TabIndex = 0
        '
        'frmFlash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.axFlashIntro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmFlash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flash"
        Me.TopMost = True
        CType(Me.axFlashIntro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " Global Form "
    Private Shared _frmFlash As frmFlash
    Public Shared Property GlobalForm() As frmFlash
        Get
            If _frmFlash Is Nothing OrElse _frmFlash.IsDisposed Then
                _frmFlash = New frmFlash
            End If
            Return _frmFlash
        End Get
        Set(ByVal Value As frmFlash)
            _frmFlash = Value
        End Set
    End Property
#End Region
#Region "Events"
    Private Sub frmFlash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim strSkin As String = "Skins3"
            frmFlash.GlobalForm = Me
            axFlashIntro.Menu = False
            axFlashIntro.Enabled = False
            Select Case strSkin
                Case "Skins1"
                    axFlashIntro.Movie = (Application.StartupPath & "\Flashes\Intro1.swf")
                Case "Skins2"
                    axFlashIntro.Movie = (Application.StartupPath & "\Flashes\Intro2.swf")
                Case "Skins3"
                    axFlashIntro.Movie = (Application.StartupPath & "\Flashes\Intro3.swf")
            End Select
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmFlash.Load)", , True)
        End Try
    End Sub
    Private Sub frmFlash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyData = Keys.Alt + Keys.F4 Or (e.KeyData = Keys.Control + Keys.Enter) Or (e.KeyData = Keys.Alt + Keys.Enter) Or (e.KeyData = Keys.Shift + Keys.Enter) Or e.KeyData = Keys.Enter Then
                Close() : Dispose()
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmFlash.KeyDown)", , True)
        End Try
    End Sub
#End Region
End Class
