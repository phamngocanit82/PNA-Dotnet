<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmList))
        Me.lblCaption = New System.Windows.Forms.Label
        Me.picLeftBottom = New System.Windows.Forms.PictureBox
        Me.picRightBottom = New System.Windows.Forms.PictureBox
        Me.picBottom = New System.Windows.Forms.PictureBox
        Me.picLeft = New System.Windows.Forms.PictureBox
        Me.picRight = New System.Windows.Forms.PictureBox
        Me.btnFormClose = New OmegaSkins1.ButtonFormMainPNA1
        Me.picRightTop = New System.Windows.Forms.PictureBox
        Me.picLeftTop = New System.Windows.Forms.PictureBox
        Me.picTopMain = New System.Windows.Forms.PictureBox
        Me.tbrHRCountry = New System.Windows.Forms.ToolStrip
        Me.tbrCheck = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.tbrClose = New System.Windows.Forms.ToolStripButton
        Me.tbrAdd = New System.Windows.Forms.ToolStripButton
        CType(Me.picLeftBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbrHRCountry.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.Color.Transparent
        Me.lblCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(5, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(300, 30)
        Me.lblCaption.TabIndex = 23
        Me.lblCaption.Text = "      Phần mềm công ty Omega"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCaption.UseCompatibleTextRendering = True
        '
        'picLeftBottom
        '
        Me.picLeftBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeftBottom.Location = New System.Drawing.Point(0, 412)
        Me.picLeftBottom.Name = "picLeftBottom"
        Me.picLeftBottom.Size = New System.Drawing.Size(5, 5)
        Me.picLeftBottom.TabIndex = 17
        Me.picLeftBottom.TabStop = False
        '
        'picRightBottom
        '
        Me.picRightBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRightBottom.Location = New System.Drawing.Point(592, 412)
        Me.picRightBottom.Name = "picRightBottom"
        Me.picRightBottom.Size = New System.Drawing.Size(5, 5)
        Me.picRightBottom.TabIndex = 19
        Me.picRightBottom.TabStop = False
        '
        'picBottom
        '
        Me.picBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBottom.Location = New System.Drawing.Point(5, 412)
        Me.picBottom.Name = "picBottom"
        Me.picBottom.Size = New System.Drawing.Size(587, 5)
        Me.picBottom.TabIndex = 18
        Me.picBottom.TabStop = False
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeft.Location = New System.Drawing.Point(0, 30)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(5, 382)
        Me.picLeft.TabIndex = 16
        Me.picLeft.TabStop = False
        '
        'picRight
        '
        Me.picRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRight.Location = New System.Drawing.Point(592, 30)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(5, 382)
        Me.picRight.TabIndex = 20
        Me.picRight.TabStop = False
        '
        'btnFormClose
        '
        Me.btnFormClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFormClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnFormClose.BackgroundImage = CType(resources.GetObject("btnFormClose.BackgroundImage"), System.Drawing.Image)
        Me.btnFormClose.BToolTip = Nothing
        Me.btnFormClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormClose.Location = New System.Drawing.Point(561, 5)
        Me.btnFormClose.Name = "btnFormClose"
        Me.btnFormClose.Size = New System.Drawing.Size(30, 17)
        Me.btnFormClose.Style = OmegaSkins1.ButtonFormMainPNA1.StyleButton.Style1
        Me.btnFormClose.TabIndex = 21
        '
        'picRightTop
        '
        Me.picRightTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRightTop.Location = New System.Drawing.Point(592, 0)
        Me.picRightTop.Name = "picRightTop"
        Me.picRightTop.Size = New System.Drawing.Size(5, 32)
        Me.picRightTop.TabIndex = 15
        Me.picRightTop.TabStop = False
        '
        'picLeftTop
        '
        Me.picLeftTop.Location = New System.Drawing.Point(0, 0)
        Me.picLeftTop.Name = "picLeftTop"
        Me.picLeftTop.Size = New System.Drawing.Size(5, 32)
        Me.picLeftTop.TabIndex = 13
        Me.picLeftTop.TabStop = False
        '
        'picTopMain
        '
        Me.picTopMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTopMain.Location = New System.Drawing.Point(5, 0)
        Me.picTopMain.Name = "picTopMain"
        Me.picTopMain.Size = New System.Drawing.Size(587, 32)
        Me.picTopMain.TabIndex = 14
        Me.picTopMain.TabStop = False
        '
        'tbrHRCountry
        '
        Me.tbrHRCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrHRCountry.AutoSize = False
        Me.tbrHRCountry.BackColor = System.Drawing.SystemColors.Control
        Me.tbrHRCountry.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.childtoolbar
        Me.tbrHRCountry.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrHRCountry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrAdd, Me.tbrCheck, Me.tbrRefesh, Me.tbrClose})
        Me.tbrHRCountry.Location = New System.Drawing.Point(5, 32)
        Me.tbrHRCountry.Name = "tbrHRCountry"
        Me.tbrHRCountry.Size = New System.Drawing.Size(587, 25)
        Me.tbrHRCountry.TabIndex = 22
        '
        'tbrCheck
        '
        Me.tbrCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCheck.Image = Global.OmegaSkins.My.Resources.Resources.check
        Me.tbrCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCheck.Name = "tbrCheck"
        Me.tbrCheck.Size = New System.Drawing.Size(23, 22)
        Me.tbrCheck.Text = "Select item"
        '
        'tbrRefesh
        '
        Me.tbrRefesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRefesh.Image = Global.OmegaSkins.My.Resources.Resources.Refresh
        Me.tbrRefesh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRefesh.Name = "tbrRefesh"
        Me.tbrRefesh.Size = New System.Drawing.Size(23, 22)
        Me.tbrRefesh.Text = "Refesh data"
        '
        'tbrClose
        '
        Me.tbrClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClose.Image = Global.OmegaSkins.My.Resources.Resources.cloce
        Me.tbrClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrClose.Name = "tbrClose"
        Me.tbrClose.Size = New System.Drawing.Size(23, 22)
        Me.tbrClose.Text = "Close"
        '
        'tbrAdd
        '
        Me.tbrAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrAdd.Image = Global.OmegaSkins.My.Resources.Resources.Add0
        Me.tbrAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrAdd.Name = "tbrAdd"
        Me.tbrAdd.Size = New System.Drawing.Size(23, 22)
        Me.tbrAdd.Text = "Add item"
        '
        'FrmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.picLeftBottom)
        Me.Controls.Add(Me.picRightBottom)
        Me.Controls.Add(Me.picBottom)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.btnFormClose)
        Me.Controls.Add(Me.picRightTop)
        Me.Controls.Add(Me.picLeftTop)
        Me.Controls.Add(Me.picTopMain)
        Me.Controls.Add(Me.tbrHRCountry)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmList"
        Me.Size = New System.Drawing.Size(597, 417)
        CType(Me.picLeftBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbrHRCountry.ResumeLayout(False)
        Me.tbrHRCountry.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btnFormClose As OmegaSkins1.ButtonFormMainPNA1
    Friend WithEvents picRight As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picRightTop As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftTop As System.Windows.Forms.PictureBox
    Friend WithEvents tbrHRCountry As System.Windows.Forms.ToolStrip
    Public WithEvents tbrCheck As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents picTopMain As System.Windows.Forms.PictureBox
    Public WithEvents lblCaption As System.Windows.Forms.Label
    Public WithEvents tbrAdd As System.Windows.Forms.ToolStripButton

End Class
