<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcessPNA
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProcessPNA))
        Me.ProcessBarPNA1 = New OmegaSkins2.ProcessBarPNA
        Me.ButtonCloseProcess1 = New OmegaSkins2.ButtonCloseProcess
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblProcess = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ProcessBarPNA1
        '
        Me.ProcessBarPNA1.Location = New System.Drawing.Point(65, 55)
        Me.ProcessBarPNA1.Max = 100
        Me.ProcessBarPNA1.Min = 0
        Me.ProcessBarPNA1.Name = "ProcessBarPNA1"
        Me.ProcessBarPNA1.Size = New System.Drawing.Size(204, 6)
        Me.ProcessBarPNA1.Style = OmegaSkins2.ProcessBarPNA.StyleButton.Style1
        Me.ProcessBarPNA1.TabIndex = 1
        Me.ProcessBarPNA1.Value = 0
        '
        'ButtonCloseProcess1
        '
        Me.ButtonCloseProcess1.BToolTip = Nothing
        Me.ButtonCloseProcess1.Location = New System.Drawing.Point(293, 1)
        Me.ButtonCloseProcess1.Name = "ButtonCloseProcess1"
        Me.ButtonCloseProcess1.Size = New System.Drawing.Size(29, 11)
        Me.ButtonCloseProcess1.Style = OmegaSkins2.ButtonCloseProcess.StyleButton.Style1
        Me.ButtonCloseProcess1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(175, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "100%"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(120, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Loading"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcess
        '
        Me.lblProcess.BackColor = System.Drawing.Color.Transparent
        Me.lblProcess.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcess.ForeColor = System.Drawing.Color.White
        Me.lblProcess.Location = New System.Drawing.Point(0, 0)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(291, 11)
        Me.lblProcess.TabIndex = 4
        '
        'FrmProcessPNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.lblProcess)
        Me.Controls.Add(Me.ProcessBarPNA1)
        Me.Controls.Add(Me.ButtonCloseProcess1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmProcessPNA"
        Me.Size = New System.Drawing.Size(328, 72)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ButtonCloseProcess1 As OmegaSkins2.ButtonCloseProcess
    Friend WithEvents ProcessBarPNA1 As OmegaSkins2.ProcessBarPNA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblProcess As System.Windows.Forms.Label

End Class
