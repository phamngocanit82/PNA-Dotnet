<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTimePNA
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
        Me.components = New System.ComponentModel.Container
        Me.txtDateTime = New OmegaSkins.TextBoxPNA
        Me.btnDateTime = New OmegaSkins.ButtonStyle5PNA(Me.components)
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtDateTime
        '
        Me.txtDateTime.BackColor = System.Drawing.Color.ForestGreen
        Me.txtDateTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDateTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTime.Location = New System.Drawing.Point(0, 0)
        Me.txtDateTime.MaxLength = 32767
        Me.txtDateTime.Multiline = False
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDateTime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDateTime.Size = New System.Drawing.Size(89, 20)
        Me.txtDateTime.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtDateTime.TabIndex = 1
        Me.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDateTime.THeight = 20
        Me.txtDateTime.TReadOnly = True
        Me.txtDateTime.TText = ""
        '
        'btnDateTime
        '
        Me.btnDateTime.Arrow = OmegaSkins.ButtonStyle5PNA.ArrowButton.ArrowBottom
        Me.btnDateTime.BackColor = System.Drawing.SystemColors.Info
        Me.btnDateTime.BToolTip = Nothing
        Me.btnDateTime.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDateTime.Location = New System.Drawing.Point(90, 0)
        Me.btnDateTime.Name = "btnDateTime"
        Me.btnDateTime.Size = New System.Drawing.Size(20, 20)
        Me.btnDateTime.Style = OmegaSkins.ButtonStyle5PNA.StyleButton.Style1
        Me.btnDateTime.TabIndex = 0
        Me.btnDateTime.UseVisualStyleBackColor = False
        '
        'tmrDateTime
        '
        '
        'DateTimePNA
        '
        Me.Controls.Add(Me.btnDateTime)
        Me.Controls.Add(Me.txtDateTime)
        Me.Name = "DateTimePNA"
        Me.Size = New System.Drawing.Size(129, 28)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDateTime As OmegaSkins.TextBoxPNA
    Friend WithEvents btnDateTime As OmegaSkins.ButtonStyle5PNA
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
End Class
