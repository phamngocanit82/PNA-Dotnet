<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfor))
        Me.btnYes = New OmegaSkins1.ButtonPNA1
        Me.btnClose = New OmegaSkins1.ButtonFormMainPNA1
        Me.btnOk = New OmegaSkins1.ButtonPNA1
        Me.lblInfor = New System.Windows.Forms.Label
        Me.btnNo = New OmegaSkins1.ButtonPNA1
        Me.imgInfor = New System.Windows.Forms.ImageList(Me.components)
        Me.tipDetail = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPrompt = New System.Windows.Forms.Label
        Me.llblDetail = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYes.BToolTip = Nothing
        Me.btnYes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(84, 122)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(73, 21)
        Me.btnYes.Style = OmegaSkins1.ButtonPNA1.StyleButton.Style1
        Me.btnYes.TabIndex = 1
        Me.btnYes.TText = Nothing
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BToolTip = Nothing
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(281, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 17)
        Me.btnClose.Style = OmegaSkins1.ButtonFormMainPNA1.StyleButton.Style1
        Me.btnClose.TabIndex = 8
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.BToolTip = Nothing
        Me.btnOk.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(128, 122)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(73, 21)
        Me.btnOk.Style = OmegaSkins1.ButtonPNA1.StyleButton.Style1
        Me.btnOk.TabIndex = 0
        Me.btnOk.TText = Nothing
        '
        'lblInfor
        '
        Me.lblInfor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfor.BackColor = System.Drawing.Color.Transparent
        Me.lblInfor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblInfor.ForeColor = System.Drawing.Color.White
        Me.lblInfor.Location = New System.Drawing.Point(0, 0)
        Me.lblInfor.Name = "lblInfor"
        Me.lblInfor.Size = New System.Drawing.Size(317, 23)
        Me.lblInfor.TabIndex = 14
        Me.lblInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNo
        '
        Me.btnNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNo.BToolTip = Nothing
        Me.btnNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(168, 122)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(73, 21)
        Me.btnNo.Style = OmegaSkins1.ButtonPNA1.StyleButton.Style1
        Me.btnNo.TabIndex = 2
        Me.btnNo.TText = Nothing
        '
        'imgInfor
        '
        Me.imgInfor.ImageStream = CType(resources.GetObject("imgInfor.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgInfor.TransparentColor = System.Drawing.Color.Transparent
        Me.imgInfor.Images.SetKeyName(0, "Infor01.png")
        Me.imgInfor.Images.SetKeyName(1, "Infor02.png")
        Me.imgInfor.Images.SetKeyName(2, "Infor03.png")
        Me.imgInfor.Images.SetKeyName(3, "Infor04.png")
        Me.imgInfor.Images.SetKeyName(4, "Infor05.png")
        Me.imgInfor.Images.SetKeyName(5, "Infor06.png")
        '
        'lblPrompt
        '
        Me.lblPrompt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrompt.BackColor = System.Drawing.Color.Transparent
        Me.lblPrompt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.White
        Me.lblPrompt.Location = New System.Drawing.Point(48, 46)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(219, 53)
        Me.lblPrompt.TabIndex = 13
        Me.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'llblDetail
        '
        Me.llblDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblDetail.AutoSize = True
        Me.llblDetail.BackColor = System.Drawing.Color.Transparent
        Me.llblDetail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblDetail.ForeColor = System.Drawing.Color.Black
        Me.llblDetail.LinkColor = System.Drawing.Color.Black
        Me.llblDetail.Location = New System.Drawing.Point(48, 105)
        Me.llblDetail.Name = "llblDetail"
        Me.llblDetail.Size = New System.Drawing.Size(39, 15)
        Me.llblDetail.TabIndex = 11
        Me.llblDetail.TabStop = True
        Me.llblDetail.Text = "Detail"
        '
        'frmInfor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 171)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblInfor)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.llblDetail)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInfor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmInfor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnYes As OmegaSkins1.ButtonPNA1
    Friend WithEvents btnClose As OmegaSkins1.ButtonFormMainPNA1
    Friend WithEvents btnOk As OmegaSkins1.ButtonPNA1
    Friend WithEvents lblInfor As System.Windows.Forms.Label
    Friend WithEvents btnNo As OmegaSkins1.ButtonPNA1
    Friend WithEvents imgInfor As System.Windows.Forms.ImageList
    Friend WithEvents tipDetail As System.Windows.Forms.ToolTip
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents llblDetail As System.Windows.Forms.LinkLabel
End Class
