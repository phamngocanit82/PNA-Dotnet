<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.txtSearchTerm = New OmegaSkins1.TextBoxPNA
        Me.ButtonFormMainPNA11 = New OmegaSkins1.ButtonFormMainPNA1
        Me.chkMatchCase = New OmegaSkins1.CheckBoxPNA1(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnFind = New OmegaSkins1.ButtonPNA1
        Me.btnFindNext = New OmegaSkins1.ButtonPNA1
        Me.lblInfor = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearchTerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchTerm.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchTerm.Location = New System.Drawing.Point(78, 40)
        Me.txtSearchTerm.MaxLength = 32767
        Me.txtSearchTerm.Multiline = False
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchTerm.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearchTerm.Size = New System.Drawing.Size(204, 20)
        Me.txtSearchTerm.Style = OmegaSkins1.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearchTerm.TabIndex = 0
        Me.txtSearchTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchTerm.THeight = 20
        Me.txtSearchTerm.TReadOnly = False
        Me.txtSearchTerm.TText = ""
        '
        'ButtonFormMainPNA11
        '
        Me.ButtonFormMainPNA11.BackgroundImage = CType(resources.GetObject("ButtonFormMainPNA11.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFormMainPNA11.BToolTip = Nothing
        Me.ButtonFormMainPNA11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFormMainPNA11.Location = New System.Drawing.Point(331, 4)
        Me.ButtonFormMainPNA11.Name = "ButtonFormMainPNA11"
        Me.ButtonFormMainPNA11.Size = New System.Drawing.Size(30, 17)
        Me.ButtonFormMainPNA11.Style = OmegaSkins1.ButtonFormMainPNA1.StyleButton.Style1
        Me.ButtonFormMainPNA11.TabIndex = 1
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.BackColor = System.Drawing.Color.Transparent
        Me.chkMatchCase.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMatchCase.ForeColor = System.Drawing.Color.White
        Me.chkMatchCase.Location = New System.Drawing.Point(78, 64)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(83, 18)
        Me.chkMatchCase.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkMatchCase.TabIndex = 2
        Me.chkMatchCase.Text = "Match Case"
        Me.chkMatchCase.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search Term"
        '
        'btnFind
        '
        Me.btnFind.BToolTip = Nothing
        Me.btnFind.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnFind.Location = New System.Drawing.Point(284, 40)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(73, 21)
        Me.btnFind.Style = OmegaSkins1.ButtonPNA1.StyleButton.Style1
        Me.btnFind.TabIndex = 4
        Me.btnFind.TText = "&Find"
        '
        'btnFindNext
        '
        Me.btnFindNext.BToolTip = Nothing
        Me.btnFindNext.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnFindNext.Location = New System.Drawing.Point(284, 64)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(73, 21)
        Me.btnFindNext.Style = OmegaSkins1.ButtonPNA1.StyleButton.Style1
        Me.btnFindNext.TabIndex = 5
        Me.btnFindNext.TText = "Find &Next"
        '
        'lblInfor
        '
        Me.lblInfor.BackColor = System.Drawing.Color.Transparent
        Me.lblInfor.ForeColor = System.Drawing.Color.White
        Me.lblInfor.Location = New System.Drawing.Point(6, 3)
        Me.lblInfor.Name = "lblInfor"
        Me.lblInfor.Size = New System.Drawing.Size(355, 20)
        Me.lblInfor.TabIndex = 6
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(367, 129)
        Me.Controls.Add(Me.txtSearchTerm)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.ButtonFormMainPNA11)
        Me.Controls.Add(Me.lblInfor)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFind"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchTerm As OmegaSkins1.TextBoxPNA
    Friend WithEvents ButtonFormMainPNA11 As OmegaSkins1.ButtonFormMainPNA1
    Friend WithEvents chkMatchCase As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFind As OmegaSkins1.ButtonPNA1
    Friend WithEvents btnFindNext As OmegaSkins1.ButtonPNA1
    Friend WithEvents lblInfor As System.Windows.Forms.Label
End Class
