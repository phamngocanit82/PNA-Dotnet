Public Class UserControl1
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents AxMiDocView1 As AxMODI.AxMiDocView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UserControl1))
        Me.AxMiDocView1 = New AxMODI.AxMiDocView
        CType(Me.AxMiDocView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxMiDocView1
        '
        Me.AxMiDocView1.Enabled = True
        Me.AxMiDocView1.Location = New System.Drawing.Point(16, 16)
        Me.AxMiDocView1.Name = "AxMiDocView1"
        Me.AxMiDocView1.OcxState = CType(resources.GetObject("AxMiDocView1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMiDocView1.Size = New System.Drawing.Size(192, 192)
        Me.AxMiDocView1.TabIndex = 0
        '
        'UserControl1
        '
        Me.Controls.Add(Me.AxMiDocView1)
        Me.Name = "UserControl1"
        CType(Me.AxMiDocView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
