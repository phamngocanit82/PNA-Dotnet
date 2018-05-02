<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton
        Me.btnNo = New DevExpress.XtraEditors.SimpleButton
        Me.btnYes = New DevExpress.XtraEditors.SimpleButton
        Me.lblMessageInformation = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Appearance.Options.UseFont = True
        Me.btnOk.Location = New System.Drawing.Point(123, 92)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 26)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&Ok"
        '
        'btnNo
        '
        Me.btnNo.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Appearance.Options.UseFont = True
        Me.btnNo.Location = New System.Drawing.Point(173, 92)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(90, 26)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "&No"
        '
        'btnYes
        '
        Me.btnYes.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Appearance.Options.UseFont = True
        Me.btnYes.Location = New System.Drawing.Point(76, 92)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(90, 26)
        Me.btnYes.TabIndex = 1
        Me.btnYes.Text = "&Yes"
        '
        'lblMessageInformation
        '
        Me.lblMessageInformation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageInformation.ForeColor = System.Drawing.Color.Black
        Me.lblMessageInformation.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblMessageInformation.Location = New System.Drawing.Point(12, 11)
        Me.lblMessageInformation.Name = "lblMessageInformation"
        Me.lblMessageInformation.Size = New System.Drawing.Size(305, 75)
        Me.lblMessageInformation.TabIndex = 3
        Me.lblMessageInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessageInformation.UseCompatibleTextRendering = True
        '
        'frmMessage
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 130)
        Me.Controls.Add(Me.lblMessageInformation)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Information about message"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnNo As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnYes As DevExpress.XtraEditors.SimpleButton
    Public WithEvents lblMessageInformation As System.Windows.Forms.Label
End Class
