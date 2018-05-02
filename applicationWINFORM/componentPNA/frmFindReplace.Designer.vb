<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindReplace
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
        Me.chkMatchCase = New DevExpress.XtraEditors.CheckEdit
        Me.btnFindNext = New DevExpress.XtraEditors.SimpleButton
        Me.btnFind = New DevExpress.XtraEditors.SimpleButton
        Me.txtSearchTerm = New DevExpress.XtraEditors.TextEdit
        Me.lblIDCountry = New DevExpress.XtraEditors.LabelControl
        Me.txtReplacementText = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btnReplace = New DevExpress.XtraEditors.SimpleButton
        Me.btnReplaceAll = New DevExpress.XtraEditors.SimpleButton
        CType(Me.chkMatchCase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearchTerm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReplacementText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkMatchCase
        '
        Me.chkMatchCase.Location = New System.Drawing.Point(122, 75)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Properties.Caption = "Match case"
        Me.chkMatchCase.Size = New System.Drawing.Size(75, 19)
        Me.chkMatchCase.TabIndex = 16
        '
        'btnFindNext
        '
        Me.btnFindNext.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindNext.Appearance.Options.UseFont = True
        Me.btnFindNext.Location = New System.Drawing.Point(124, 100)
        Me.btnFindNext.Name = "btnFindNext"
        Me.btnFindNext.Size = New System.Drawing.Size(100, 25)
        Me.btnFindNext.TabIndex = 15
        Me.btnFindNext.Text = "Find next"
        '
        'btnFind
        '
        Me.btnFind.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Appearance.Options.UseFont = True
        Me.btnFind.Location = New System.Drawing.Point(22, 100)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 25)
        Me.btnFind.TabIndex = 14
        Me.btnFind.Text = "Find"
        '
        'txtSearchTerm
        '
        Me.txtSearchTerm.EditValue = ""
        Me.txtSearchTerm.Location = New System.Drawing.Point(124, 26)
        Me.txtSearchTerm.Name = "txtSearchTerm"
        Me.txtSearchTerm.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtSearchTerm.Properties.Appearance.Options.UseFont = True
        Me.txtSearchTerm.Properties.MaxLength = 20
        Me.txtSearchTerm.Size = New System.Drawing.Size(303, 21)
        Me.txtSearchTerm.TabIndex = 13
        '
        'lblIDCountry
        '
        Me.lblIDCountry.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIDCountry.Appearance.Options.UseFont = True
        Me.lblIDCountry.Location = New System.Drawing.Point(20, 29)
        Me.lblIDCountry.Name = "lblIDCountry"
        Me.lblIDCountry.Size = New System.Drawing.Size(67, 15)
        Me.lblIDCountry.TabIndex = 12
        Me.lblIDCountry.Text = "Search term"
        '
        'txtReplacementText
        '
        Me.txtReplacementText.EditValue = ""
        Me.txtReplacementText.Location = New System.Drawing.Point(124, 50)
        Me.txtReplacementText.Name = "txtReplacementText"
        Me.txtReplacementText.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtReplacementText.Properties.Appearance.Options.UseFont = True
        Me.txtReplacementText.Properties.MaxLength = 20
        Me.txtReplacementText.Size = New System.Drawing.Size(303, 21)
        Me.txtReplacementText.TabIndex = 18
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 15)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Replacement text"
        '
        'btnReplace
        '
        Me.btnReplace.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplace.Appearance.Options.UseFont = True
        Me.btnReplace.Location = New System.Drawing.Point(226, 100)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(100, 25)
        Me.btnReplace.TabIndex = 19
        Me.btnReplace.Text = "Replace"
        '
        'btnReplaceAll
        '
        Me.btnReplaceAll.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReplaceAll.Appearance.Options.UseFont = True
        Me.btnReplaceAll.Location = New System.Drawing.Point(328, 100)
        Me.btnReplaceAll.Name = "btnReplaceAll"
        Me.btnReplaceAll.Size = New System.Drawing.Size(100, 25)
        Me.btnReplaceAll.TabIndex = 20
        Me.btnReplaceAll.Text = "Replace all"
        '
        'frmFindReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 147)
        Me.Controls.Add(Me.btnReplaceAll)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtReplacementText)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.btnFindNext)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtSearchTerm)
        Me.Controls.Add(Me.lblIDCountry)
        Me.Name = "frmFindReplace"
        Me.Text = "Find replace"
        CType(Me.chkMatchCase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearchTerm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReplacementText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkMatchCase As DevExpress.XtraEditors.CheckEdit
    Public WithEvents btnFindNext As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnFind As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtSearchTerm As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblIDCountry As DevExpress.XtraEditors.LabelControl
    Public WithEvents txtReplacementText As DevExpress.XtraEditors.TextEdit
    Public WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents btnReplace As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnReplaceAll As DevExpress.XtraEditors.SimpleButton
End Class
