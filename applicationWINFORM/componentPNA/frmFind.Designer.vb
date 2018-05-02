<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.lblIDCountry = New DevExpress.XtraEditors.LabelControl
        Me.txtSearchTerm = New DevExpress.XtraEditors.TextEdit
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton
        Me.btnFindNext = New DevExpress.XtraEditors.SimpleButton
        Me.chkMatchCase = New DevExpress.XtraEditors.CheckEdit
        CType(Me.txtSearchTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMatchCase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIDCountry
        '
        Me.lblIDCountry.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIDCountry.Appearance.Options.UseFont = True
        Me.lblIDCountry.Location = New System.Drawing.Point(11, 29)
        Me.lblIDCountry.Name = "lblIDCountry"
        Me.lblIDCountry.Size = New System.Drawing.Size(67, 15)
        Me.lblIDCountry.TabIndex = 2
        Me.lblIDCountry.Text = "Search term"
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.EditValue = ""
        Me.txtSearchTerm.Location = New System.Drawing.Point(87, 26)
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtSearchTerm.Properties.Appearance.Options.UseFont = True
        Me.txtSearchTerm.Properties.MaxLength = 20
        Me.txtSearchTerm.Size = New System.Drawing.Size(237, 21)
        Me.txtSearchTerm.TabIndex = 6
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Location = New System.Drawing.Point(327, 26)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 25)
        Me.btnFind.TabIndex = 9
        Me.btnFind.Text = "Find"
        '
        'btnFindNext
        '
        Me.btnFindNext.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindNext.Appearance.Options.UseFont = True
        Me.btnFindNext.Location = New System.Drawing.Point(327, 54)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(100, 25)
        Me.btnFindNext.TabIndex = 10
        Me.btnFindNext.Text = "Find next"
        '
        'chkMatchCase
        '
        Me.chkMatchCase.Location = New System.Drawing.Point(85, 52)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Properties.Caption = "Match case"
        Me.chkMatchCase.Size = New System.Drawing.Size(75, 19)
        Me.chkMatchCase.TabIndex = 11
        '
        'frmFind
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 100)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtSearchTerm)
        Me.Controls.Add(Me.lblIDCountry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find"
        CType(Me.txtSearchTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMatchCase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblIDCountry As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtSearchTerm As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnFindNext As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkMatchCase As DevExpress.XtraEditors.CheckEdit
End Class
