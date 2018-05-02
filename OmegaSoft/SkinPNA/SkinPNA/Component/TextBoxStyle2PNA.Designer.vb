<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBoxStyle2PNA
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
        Me.btnButton = New OmegaSkins.ButtonStyle5PNA(Me.components)
        Me.txtTextBox = New OmegaSkins.TextBoxPNA
        Me.SuspendLayout()
        '
        'btnButton
        '
        Me.btnButton.Arrow = OmegaSkins.ButtonStyle5PNA.ArrowButton.ArrowBottom
        Me.btnButton.BackColor = System.Drawing.SystemColors.Info
        Me.btnButton.BToolTip = Nothing
        Me.btnButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton.Location = New System.Drawing.Point(97, 2)
        Me.btnButton.Name = "btnButton"
        Me.btnButton.Size = New System.Drawing.Size(20, 20)
        Me.btnButton.Style = OmegaSkins.ButtonStyle5PNA.StyleButton.Style1
        Me.btnButton.TabIndex = 2
        Me.btnButton.UseVisualStyleBackColor = True
        '
        'txtTextBox
        '
        Me.txtTextBox.BackColor = System.Drawing.Color.ForestGreen
        Me.txtTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTextBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTextBox.Location = New System.Drawing.Point(2, 2)
        Me.txtTextBox.MaxLength = 32767
        Me.txtTextBox.Multiline = False
        Me.txtTextBox.Name = "txtTextBox"
        Me.txtTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTextBox.Size = New System.Drawing.Size(94, 20)
        Me.txtTextBox.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtTextBox.TabIndex = 1
        Me.txtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTextBox.THeight = 20
        Me.txtTextBox.TReadOnly = False
        Me.txtTextBox.TText = ""
        '
        'TextBoxStyle2PNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnButton)
        Me.Controls.Add(Me.txtTextBox)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Name = "TextBoxStyle2PNA"
        Me.Size = New System.Drawing.Size(149, 38)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTextBox As OmegaSkins.TextBoxPNA
    Friend WithEvents btnButton As OmegaSkins.ButtonStyle5PNA
End Class
