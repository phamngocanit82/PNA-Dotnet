<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContainFormChildPNA
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
        Me.pnlForm = New System.Windows.Forms.Panel
        Me.panelButton = New System.Windows.Forms.Panel
        Me.picTopMain = New System.Windows.Forms.PictureBox
        Me.picRight = New System.Windows.Forms.PictureBox
        Me.picRightBottom = New System.Windows.Forms.PictureBox
        Me.picBottom = New System.Windows.Forms.PictureBox
        Me.picLeftBottom = New System.Windows.Forms.PictureBox
        Me.picLeft = New System.Windows.Forms.PictureBox
        Me.picRightTop = New System.Windows.Forms.PictureBox
        Me.picLeftTop = New System.Windows.Forms.PictureBox
        Me.cmnuForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnRight = New componentPNA.ButtonStylePNA(Me.components)
        Me.btnClose = New componentPNA.ButtonStylePNA(Me.components)
        Me.btnLeft = New componentPNA.ButtonStylePNA(Me.components)
        Me.btnMenu = New componentPNA.ButtonStylePNA(Me.components)
        Me.SildeBar1 = New componentPNA.ContainFormChildBarPNA
        CType(Me.picTopMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlForm
        '
        Me.pnlForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlForm.Location = New System.Drawing.Point(5, 40)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(447, 281)
        Me.pnlForm.TabIndex = 28
        '
        'panelButton
        '
        Me.panelButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelButton.Location = New System.Drawing.Point(6, 0)
        Me.panelButton.Name = "panelButton"
        Me.panelButton.Size = New System.Drawing.Size(430, 38)
        Me.panelButton.TabIndex = 32
        '
        'picTopMain
        '
        Me.picTopMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTopMain.Location = New System.Drawing.Point(5, 35)
        Me.picTopMain.Name = "picTopMain"
        Me.picTopMain.Size = New System.Drawing.Size(447, 5)
        Me.picTopMain.TabIndex = 21
        Me.picTopMain.TabStop = False
        '
        'picRight
        '
        Me.picRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRight.Location = New System.Drawing.Point(452, 40)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(5, 281)
        Me.picRight.TabIndex = 27
        Me.picRight.TabStop = False
        '
        'picRightBottom
        '
        Me.picRightBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRightBottom.Location = New System.Drawing.Point(452, 321)
        Me.picRightBottom.Name = "picRightBottom"
        Me.picRightBottom.Size = New System.Drawing.Size(5, 5)
        Me.picRightBottom.TabIndex = 26
        Me.picRightBottom.TabStop = False
        '
        'picBottom
        '
        Me.picBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBottom.Location = New System.Drawing.Point(5, 321)
        Me.picBottom.Name = "picBottom"
        Me.picBottom.Size = New System.Drawing.Size(447, 5)
        Me.picBottom.TabIndex = 25
        Me.picBottom.TabStop = False
        '
        'picLeftBottom
        '
        Me.picLeftBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeftBottom.Location = New System.Drawing.Point(0, 321)
        Me.picLeftBottom.Name = "picLeftBottom"
        Me.picLeftBottom.Size = New System.Drawing.Size(5, 5)
        Me.picLeftBottom.TabIndex = 24
        Me.picLeftBottom.TabStop = False
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeft.Location = New System.Drawing.Point(0, 40)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(5, 281)
        Me.picLeft.TabIndex = 23
        Me.picLeft.TabStop = False
        '
        'picRightTop
        '
        Me.picRightTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRightTop.Location = New System.Drawing.Point(452, 35)
        Me.picRightTop.Name = "picRightTop"
        Me.picRightTop.Size = New System.Drawing.Size(5, 5)
        Me.picRightTop.TabIndex = 22
        Me.picRightTop.TabStop = False
        '
        'picLeftTop
        '
        Me.picLeftTop.Location = New System.Drawing.Point(0, 35)
        Me.picLeftTop.Name = "picLeftTop"
        Me.picLeftTop.Size = New System.Drawing.Size(5, 5)
        Me.picLeftTop.TabIndex = 20
        Me.picLeftTop.TabStop = False
        '
        'cmnuForm
        '
        Me.cmnuForm.Name = "cmnuForm"
        Me.cmnuForm.Size = New System.Drawing.Size(61, 4)
        '
        'btnRight
        '
        Me.btnRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRight.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.ForeColor = System.Drawing.Color.Black
        Me.btnRight.Index = 0
        Me.btnRight.Location = New System.Drawing.Point(397, 20)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(13, 13)
        Me.btnRight.Skin = componentPNA.ButtonStylePNA.EnumSkin.Skins1
        Me.btnRight.TabIndex = 37
        Me.btnRight.ToolTip = ""
        Me.btnRight.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None
        Me.btnRight.ToolTipTitle = ""
        Me.btnRight.Type = componentPNA.ButtonStylePNA.EnumType.ANext
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Index = 0
        Me.btnClose.Location = New System.Drawing.Point(439, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(13, 13)
        Me.btnClose.Skin = componentPNA.ButtonStylePNA.EnumSkin.Skins1
        Me.btnClose.TabIndex = 36
        Me.btnClose.ToolTip = ""
        Me.btnClose.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None
        Me.btnClose.ToolTipTitle = ""
        Me.btnClose.Type = componentPNA.ButtonStylePNA.EnumType.AClose
        '
        'btnLeft
        '
        Me.btnLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLeft.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.ForeColor = System.Drawing.Color.Black
        Me.btnLeft.Index = 0
        Me.btnLeft.Location = New System.Drawing.Point(382, 20)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(13, 13)
        Me.btnLeft.Skin = componentPNA.ButtonStylePNA.EnumSkin.Skins1
        Me.btnLeft.TabIndex = 35
        Me.btnLeft.ToolTip = ""
        Me.btnLeft.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None
        Me.btnLeft.ToolTipTitle = ""
        Me.btnLeft.Type = componentPNA.ButtonStylePNA.EnumType.APrevious
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Index = 0
        Me.btnMenu.Location = New System.Drawing.Point(412, 20)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(25, 13)
        Me.btnMenu.Skin = componentPNA.ButtonStylePNA.EnumSkin.Skins1
        Me.btnMenu.TabIndex = 34
        Me.btnMenu.ToolTip = ""
        Me.btnMenu.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None
        Me.btnMenu.ToolTipTitle = ""
        Me.btnMenu.Type = componentPNA.ButtonStylePNA.EnumType.AMenu
        '
        'SildeBar1
        '
        Me.SildeBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SildeBar1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SildeBar1.Location = New System.Drawing.Point(0, 18)
        Me.SildeBar1.Name = "SildeBar1"
        Me.SildeBar1.Size = New System.Drawing.Size(457, 17)
        Me.SildeBar1.Skin = componentPNA.ContainFormChildBarPNA.EnumSkin.Skins1
        Me.SildeBar1.TabIndex = 33
        '
        'ContainFormChildPNA
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.SildeBar1)
        Me.Controls.Add(Me.picTopMain)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picRightBottom)
        Me.Controls.Add(Me.picBottom)
        Me.Controls.Add(Me.picLeftBottom)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.picRightTop)
        Me.Controls.Add(Me.picLeftTop)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.panelButton)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ContainFormChildPNA"
        Me.Size = New System.Drawing.Size(457, 326)
        CType(Me.picTopMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picTopMain As System.Windows.Forms.PictureBox
    Friend WithEvents picRight As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picRightTop As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftTop As System.Windows.Forms.PictureBox
    Friend WithEvents pnlForm As System.Windows.Forms.Panel
    Friend WithEvents panelButton As System.Windows.Forms.Panel
    Friend WithEvents cmnuForm As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SildeBar1 As ContainFormChildBarPNA
    Friend WithEvents btnMenu As ButtonStylePNA
    Friend WithEvents btnLeft As ButtonStylePNA
    Friend WithEvents btnClose As ButtonStylePNA
    Friend WithEvents btnRight As ButtonStylePNA
End Class
