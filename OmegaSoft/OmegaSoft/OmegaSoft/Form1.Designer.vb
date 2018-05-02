<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.ButtonStyle1PNA1 = New OmegaSkins.ButtonStyle1PNA(Me.components)
        Me.ButtonStyle2PNA1 = New OmegaSkins.ButtonStyle2PNA(Me.components)
        Me.ButtonStyle3PNA1 = New OmegaSkins.ButtonStyle3PNA(Me.components)
        Me.ButtonStyle4PNA1 = New OmegaSkins.ButtonStyle4PNA(Me.components)
        Me.ProgressBarPNA1 = New OmegaSkins.ProgressBarPNA
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonStyle1PNA1
        '
        Me.ButtonStyle1PNA1.BToolTip = Nothing
        Me.ButtonStyle1PNA1.Location = New System.Drawing.Point(247, 91)
        Me.ButtonStyle1PNA1.Name = "ButtonStyle1PNA1"
        Me.ButtonStyle1PNA1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStyle1PNA1.Style = OmegaSkins.ButtonStyle1PNA.StyleButton.Style1
        Me.ButtonStyle1PNA1.TabIndex = 0
        Me.ButtonStyle1PNA1.Text = "ButtonStyle1PNA1"
        Me.ButtonStyle1PNA1.UseVisualStyleBackColor = True
        '
        'ButtonStyle2PNA1
        '
        Me.ButtonStyle2PNA1.BToolTip = Nothing
        Me.ButtonStyle2PNA1.Location = New System.Drawing.Point(247, 178)
        Me.ButtonStyle2PNA1.Name = "ButtonStyle2PNA1"
        Me.ButtonStyle2PNA1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStyle2PNA1.Style = OmegaSkins.ButtonStyle2PNA.StyleButton.Style1
        Me.ButtonStyle2PNA1.TabIndex = 1
        Me.ButtonStyle2PNA1.Text = "ButtonStyle2PNA1"
        Me.ButtonStyle2PNA1.UseVisualStyleBackColor = True
        '
        'ButtonStyle3PNA1
        '
        Me.ButtonStyle3PNA1.BToolTip = Nothing
        Me.ButtonStyle3PNA1.Location = New System.Drawing.Point(247, 120)
        Me.ButtonStyle3PNA1.Name = "ButtonStyle3PNA1"
        Me.ButtonStyle3PNA1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStyle3PNA1.Style = OmegaSkins.ButtonStyle3PNA.StyleButton.Style1
        Me.ButtonStyle3PNA1.TabIndex = 2
        Me.ButtonStyle3PNA1.Text = "ButtonStyle3PNA1"
        Me.ButtonStyle3PNA1.UseVisualStyleBackColor = True
        '
        'ButtonStyle4PNA1
        '
        Me.ButtonStyle4PNA1.BToolTip = Nothing
        Me.ButtonStyle4PNA1.Location = New System.Drawing.Point(247, 149)
        Me.ButtonStyle4PNA1.Name = "ButtonStyle4PNA1"
        Me.ButtonStyle4PNA1.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStyle4PNA1.Style = OmegaSkins.ButtonStyle4PNA.StyleButton.Style1
        Me.ButtonStyle4PNA1.TabIndex = 3
        Me.ButtonStyle4PNA1.Text = "ButtonStyle4PNA1"
        Me.ButtonStyle4PNA1.UseVisualStyleBackColor = True
        '
        'ProgressBarPNA1
        '
        Me.ProgressBarPNA1.Location = New System.Drawing.Point(0, -7)
        Me.ProgressBarPNA1.Max = 100
        Me.ProgressBarPNA1.Min = 0
        Me.ProgressBarPNA1.Name = "ProgressBarPNA1"
        Me.ProgressBarPNA1.Size = New System.Drawing.Size(447, 150)
        Me.ProgressBarPNA1.Style = OmegaSkins.ProgressBarPNA.StyleProgressBar.Style1
        Me.ProgressBarPNA1.TabIndex = 4
        Me.ProgressBarPNA1.Value = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 264)
        Me.Controls.Add(Me.ProgressBarPNA1)
        Me.Controls.Add(Me.ButtonStyle4PNA1)
        Me.Controls.Add(Me.ButtonStyle3PNA1)
        Me.Controls.Add(Me.ButtonStyle2PNA1)
        Me.Controls.Add(Me.ButtonStyle1PNA1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonStyle1PNA1 As OmegaSkins.ButtonStyle1PNA
    Friend WithEvents ButtonStyle2PNA1 As OmegaSkins.ButtonStyle2PNA
    Friend WithEvents ButtonStyle3PNA1 As OmegaSkins.ButtonStyle3PNA
    Friend WithEvents ButtonStyle4PNA1 As OmegaSkins.ButtonStyle4PNA
    Friend WithEvents ProgressBarPNA1 As OmegaSkins.ProgressBarPNA
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
