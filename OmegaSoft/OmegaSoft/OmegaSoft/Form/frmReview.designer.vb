<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReview))
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AaaaaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PhamNgocAnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.KjlioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IouiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblCaption = New System.Windows.Forms.Label
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.picRight = New System.Windows.Forms.PictureBox
        Me.picRightBottom = New System.Windows.Forms.PictureBox
        Me.picBottom = New System.Windows.Forms.PictureBox
        Me.picLeftBottom = New System.Windows.Forms.PictureBox
        Me.picLeft = New System.Windows.Forms.PictureBox
        Me.picRightTop = New System.Windows.Forms.PictureBox
        Me.picLeftTop = New System.Windows.Forms.PictureBox
        Me.picTopMain = New System.Windows.Forms.PictureBox
        Me.btnFormMaximize = New OmegaSkins1.ButtonFormMainPNA1
        Me.btnMinimize = New OmegaSkins1.ButtonFormMainPNA1
        Me.btnFormClose = New OmegaSkins1.ButtonFormMainPNA1
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(54, 21)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'AaaaaToolStripMenuItem
        '
        Me.AaaaaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhamNgocAnToolStripMenuItem})
        Me.AaaaaToolStripMenuItem.Name = "AaaaaToolStripMenuItem"
        Me.AaaaaToolStripMenuItem.Size = New System.Drawing.Size(101, 21)
        Me.AaaaaToolStripMenuItem.Text = "Pham Ngoc An"
        '
        'PhamNgocAnToolStripMenuItem
        '
        Me.PhamNgocAnToolStripMenuItem.Name = "PhamNgocAnToolStripMenuItem"
        Me.PhamNgocAnToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.PhamNgocAnToolStripMenuItem.Text = "Pham Ngoc An"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KjlioToolStripMenuItem, Me.IouiToolStripMenuItem})
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'KjlioToolStripMenuItem
        '
        Me.KjlioToolStripMenuItem.Name = "KjlioToolStripMenuItem"
        Me.KjlioToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.KjlioToolStripMenuItem.Text = "kjlio;"
        '
        'IouiToolStripMenuItem
        '
        Me.IouiToolStripMenuItem.Name = "IouiToolStripMenuItem"
        Me.IouiToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.IouiToolStripMenuItem.Text = "ioui"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 18)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(129, 15)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.Color.Transparent
        Me.lblCaption.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.White
        Me.lblCaption.Location = New System.Drawing.Point(5, 0)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(188, 30)
        Me.lblCaption.TabIndex = 21
        Me.lblCaption.Text = "Phần mềm công ty Omega"
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCaption.UseCompatibleTextRendering = True
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Location = New System.Drawing.Point(5, 30)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.SelectionFormula = ""
        Me.rptViewer.Size = New System.Drawing.Size(534, 422)
        Me.rptViewer.TabIndex = 22
        Me.rptViewer.ViewTimeSelectionFormula = ""
        '
        'picRight
        '
        Me.picRight.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRight.Location = New System.Drawing.Point(539, 30)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(5, 422)
        Me.picRight.TabIndex = 11
        Me.picRight.TabStop = False
        '
        'picRightBottom
        '
        Me.picRightBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRightBottom.Location = New System.Drawing.Point(539, 452)
        Me.picRightBottom.Name = "picRightBottom"
        Me.picRightBottom.Size = New System.Drawing.Size(5, 5)
        Me.picRightBottom.TabIndex = 10
        Me.picRightBottom.TabStop = False
        '
        'picBottom
        '
        Me.picBottom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBottom.Location = New System.Drawing.Point(5, 452)
        Me.picBottom.Name = "picBottom"
        Me.picBottom.Size = New System.Drawing.Size(534, 5)
        Me.picBottom.TabIndex = 9
        Me.picBottom.TabStop = False
        '
        'picLeftBottom
        '
        Me.picLeftBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeftBottom.Location = New System.Drawing.Point(0, 452)
        Me.picLeftBottom.Name = "picLeftBottom"
        Me.picLeftBottom.Size = New System.Drawing.Size(5, 5)
        Me.picLeftBottom.TabIndex = 8
        Me.picLeftBottom.TabStop = False
        '
        'picLeft
        '
        Me.picLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picLeft.Location = New System.Drawing.Point(0, 30)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(5, 422)
        Me.picLeft.TabIndex = 7
        Me.picLeft.TabStop = False
        '
        'picRightTop
        '
        Me.picRightTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picRightTop.Location = New System.Drawing.Point(539, 0)
        Me.picRightTop.Name = "picRightTop"
        Me.picRightTop.Size = New System.Drawing.Size(5, 30)
        Me.picRightTop.TabIndex = 6
        Me.picRightTop.TabStop = False
        '
        'picLeftTop
        '
        Me.picLeftTop.Location = New System.Drawing.Point(0, 0)
        Me.picLeftTop.Name = "picLeftTop"
        Me.picLeftTop.Size = New System.Drawing.Size(5, 30)
        Me.picLeftTop.TabIndex = 4
        Me.picLeftTop.TabStop = False
        '
        'picTopMain
        '
        Me.picTopMain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTopMain.Location = New System.Drawing.Point(5, 0)
        Me.picTopMain.Name = "picTopMain"
        Me.picTopMain.Size = New System.Drawing.Size(534, 30)
        Me.picTopMain.TabIndex = 5
        Me.picTopMain.TabStop = False
        '
        'btnFormMaximize
        '
        Me.btnFormMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFormMaximize.BackColor = System.Drawing.SystemColors.Control
        Me.btnFormMaximize.BackgroundImage = CType(resources.GetObject("btnFormMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnFormMaximize.BToolTip = Nothing
        Me.btnFormMaximize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormMaximize.Location = New System.Drawing.Point(477, 5)
        Me.btnFormMaximize.Name = "btnFormMaximize"
        Me.btnFormMaximize.Size = New System.Drawing.Size(30, 17)
        Me.btnFormMaximize.Style = OmegaSkins1.ButtonFormMainPNA1.StyleButton.Style2
        Me.btnFormMaximize.TabIndex = 14
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.SystemColors.Control
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BToolTip = Nothing
        Me.btnMinimize.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(446, 5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 17)
        Me.btnMinimize.Style = OmegaSkins1.ButtonFormMainPNA1.StyleButton.Style3
        Me.btnMinimize.TabIndex = 13
        '
        'btnFormClose
        '
        Me.btnFormClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFormClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnFormClose.BackgroundImage = CType(resources.GetObject("btnFormClose.BackgroundImage"), System.Drawing.Image)
        Me.btnFormClose.BToolTip = Nothing
        Me.btnFormClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFormClose.Location = New System.Drawing.Point(508, 5)
        Me.btnFormClose.Name = "btnFormClose"
        Me.btnFormClose.Size = New System.Drawing.Size(30, 17)
        Me.btnFormClose.Style = OmegaSkins1.ButtonFormMainPNA1.StyleButton.Style1
        Me.btnFormClose.TabIndex = 12
        '
        'frmReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(544, 457)
        Me.Controls.Add(Me.btnFormMaximize)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnFormClose)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picRightBottom)
        Me.Controls.Add(Me.picBottom)
        Me.Controls.Add(Me.picLeftBottom)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.picRightTop)
        Me.Controls.Add(Me.picLeftTop)
        Me.Controls.Add(Me.picTopMain)
        Me.Controls.Add(Me.rptViewer)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Omega Soft"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLeftTop As System.Windows.Forms.PictureBox
    Friend WithEvents picTopMain As System.Windows.Forms.PictureBox
    Friend WithEvents picRightTop As System.Windows.Forms.PictureBox
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picRight As System.Windows.Forms.PictureBox
    Friend WithEvents btnFormClose As OmegaSkins1.ButtonFormMainPNA1
    Friend WithEvents btnMinimize As OmegaSkins1.ButtonFormMainPNA1
    Friend WithEvents btnFormMaximize As OmegaSkins1.ButtonFormMainPNA1
    Friend WithEvents AaaaaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhamNgocAnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents KjlioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IouiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCaption As System.Windows.Forms.Label
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
