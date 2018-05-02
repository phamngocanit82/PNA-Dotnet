<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiffPNA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TiffPNA))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.docView = New AxMODI.AxMiDocView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnSave = New OmegaSkins.ButtonPNA(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSelect = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnPrint = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnPan = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnNext = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnZoomOut = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnPrev = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnZoomIn = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnRotateRight = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnFitWidth = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnRotateLeft = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnFitHeight = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnShowTwo = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnShowSingle = New OmegaSkins.ButtonPNA(Me.components)
        Me.btnShowContinous = New OmegaSkins.ButtonPNA(Me.components)
        Me.PictureBox9 = New System.Windows.Forms.PictureBox
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1.SuspendLayout()
        CType(Me.docView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.docView)
        Me.Panel1.Location = New System.Drawing.Point(5, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 327)
        Me.Panel1.TabIndex = 23
        '
        'docView
        '
        Me.docView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.docView.Enabled = True
        Me.docView.Location = New System.Drawing.Point(0, 0)
        Me.docView.Name = "docView"
        Me.docView.OcxState = CType(resources.GetObject("docView.OcxState"), System.Windows.Forms.AxHost.State)
        Me.docView.Size = New System.Drawing.Size(551, 327)
        Me.docView.TabIndex = 24
        Me.docView.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.Toolbar
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSelect)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnPan)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Controls.Add(Me.btnZoomOut)
        Me.Panel2.Controls.Add(Me.btnPrev)
        Me.Panel2.Controls.Add(Me.btnZoomIn)
        Me.Panel2.Controls.Add(Me.btnRotateRight)
        Me.Panel2.Controls.Add(Me.btnFitWidth)
        Me.Panel2.Controls.Add(Me.btnRotateLeft)
        Me.Panel2.Controls.Add(Me.btnFitHeight)
        Me.Panel2.Controls.Add(Me.btnShowTwo)
        Me.Panel2.Controls.Add(Me.btnShowSingle)
        Me.Panel2.Controls.Add(Me.btnShowContinous)
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(551, 28)
        Me.Panel2.TabIndex = 26
        '
        'btnSave
        '
        Me.btnSave.BToolTip = "Save"
        Me.btnSave.Image = Global.OmegaSkins.My.Resources.Resources.Save
        Me.btnSave.Location = New System.Drawing.Point(3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(27, 21)
        Me.btnSave.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSave.TabIndex = 25
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(442, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Page 1/5"
        '
        'btnSelect
        '
        Me.btnSelect.BToolTip = "Select"
        Me.btnSelect.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Image = Global.OmegaSkins.My.Resources.Resources._31
        Me.btnSelect.Location = New System.Drawing.Point(90, 2)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(27, 21)
        Me.btnSelect.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSelect.TabIndex = 25
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.BToolTip = "Print"
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(32, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(27, 21)
        Me.btnPrint.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnPrint.TabIndex = 23
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPan
        '
        Me.btnPan.BToolTip = "Pan"
        Me.btnPan.Image = Global.OmegaSkins.My.Resources.Resources._4
        Me.btnPan.Location = New System.Drawing.Point(61, 2)
        Me.btnPan.Name = "btnPan"
        Me.btnPan.Size = New System.Drawing.Size(27, 21)
        Me.btnPan.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnPan.TabIndex = 24
        Me.btnPan.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.BToolTip = "Next page"
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(409, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(27, 21)
        Me.btnNext.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnNext.TabIndex = 36
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnZoomOut
        '
        Me.btnZoomOut.BToolTip = "Zoom out"
        Me.btnZoomOut.Image = Global.OmegaSkins.My.Resources.Resources._10
        Me.btnZoomOut.Location = New System.Drawing.Point(119, 2)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(27, 21)
        Me.btnZoomOut.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnZoomOut.TabIndex = 26
        Me.btnZoomOut.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.BToolTip = "Previous page"
        Me.btnPrev.Image = Global.OmegaSkins.My.Resources.Resources._2
        Me.btnPrev.Location = New System.Drawing.Point(380, 2)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(27, 21)
        Me.btnPrev.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnPrev.TabIndex = 35
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnZoomIn
        '
        Me.btnZoomIn.BToolTip = "Zoom in"
        Me.btnZoomIn.Image = Global.OmegaSkins.My.Resources.Resources._12
        Me.btnZoomIn.Location = New System.Drawing.Point(148, 2)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(27, 21)
        Me.btnZoomIn.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnZoomIn.TabIndex = 27
        Me.btnZoomIn.UseVisualStyleBackColor = True
        '
        'btnRotateRight
        '
        Me.btnRotateRight.BToolTip = "Rotate right"
        Me.btnRotateRight.Image = Global.OmegaSkins.My.Resources.Resources._5
        Me.btnRotateRight.Location = New System.Drawing.Point(351, 2)
        Me.btnRotateRight.Name = "btnRotateRight"
        Me.btnRotateRight.Size = New System.Drawing.Size(27, 21)
        Me.btnRotateRight.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnRotateRight.TabIndex = 34
        Me.btnRotateRight.UseVisualStyleBackColor = True
        '
        'btnFitWidth
        '
        Me.btnFitWidth.BToolTip = "Fit width"
        Me.btnFitWidth.Image = Global.OmegaSkins.My.Resources.Resources._8
        Me.btnFitWidth.Location = New System.Drawing.Point(177, 2)
        Me.btnFitWidth.Name = "btnFitWidth"
        Me.btnFitWidth.Size = New System.Drawing.Size(27, 21)
        Me.btnFitWidth.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnFitWidth.TabIndex = 28
        Me.btnFitWidth.UseVisualStyleBackColor = True
        '
        'btnRotateLeft
        '
        Me.btnRotateLeft.BToolTip = "Rotate left"
        Me.btnRotateLeft.Image = Global.OmegaSkins.My.Resources.Resources._13
        Me.btnRotateLeft.Location = New System.Drawing.Point(322, 2)
        Me.btnRotateLeft.Name = "btnRotateLeft"
        Me.btnRotateLeft.Size = New System.Drawing.Size(27, 21)
        Me.btnRotateLeft.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnRotateLeft.TabIndex = 33
        Me.btnRotateLeft.UseVisualStyleBackColor = True
        '
        'btnFitHeight
        '
        Me.btnFitHeight.BToolTip = "Fit height"
        Me.btnFitHeight.Image = Global.OmegaSkins.My.Resources.Resources._3
        Me.btnFitHeight.Location = New System.Drawing.Point(206, 2)
        Me.btnFitHeight.Name = "btnFitHeight"
        Me.btnFitHeight.Size = New System.Drawing.Size(27, 21)
        Me.btnFitHeight.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnFitHeight.TabIndex = 29
        Me.btnFitHeight.UseVisualStyleBackColor = True
        '
        'btnShowTwo
        '
        Me.btnShowTwo.BToolTip = "Show two page"
        Me.btnShowTwo.Image = Global.OmegaSkins.My.Resources.Resources._6
        Me.btnShowTwo.Location = New System.Drawing.Point(293, 2)
        Me.btnShowTwo.Name = "btnShowTwo"
        Me.btnShowTwo.Size = New System.Drawing.Size(27, 21)
        Me.btnShowTwo.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnShowTwo.TabIndex = 32
        Me.btnShowTwo.UseVisualStyleBackColor = True
        '
        'btnShowSingle
        '
        Me.btnShowSingle.BToolTip = "Show single page"
        Me.btnShowSingle.Image = Global.OmegaSkins.My.Resources.Resources._7
        Me.btnShowSingle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShowSingle.Location = New System.Drawing.Point(235, 2)
        Me.btnShowSingle.Name = "btnShowSingle"
        Me.btnShowSingle.Size = New System.Drawing.Size(27, 21)
        Me.btnShowSingle.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnShowSingle.TabIndex = 30
        Me.btnShowSingle.UseVisualStyleBackColor = True
        '
        'btnShowContinous
        '
        Me.btnShowContinous.BToolTip = "Show continous page"
        Me.btnShowContinous.Image = Global.OmegaSkins.My.Resources.Resources._14
        Me.btnShowContinous.Location = New System.Drawing.Point(264, 2)
        Me.btnShowContinous.Name = "btnShowContinous"
        Me.btnShowContinous.Size = New System.Drawing.Size(27, 21)
        Me.btnShowContinous.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnShowContinous.TabIndex = 31
        Me.btnShowContinous.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.left_bottom
        Me.PictureBox9.Location = New System.Drawing.Point(0, 360)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(5, 4)
        Me.PictureBox9.TabIndex = 8
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.right_bottom
        Me.PictureBox8.Location = New System.Drawing.Point(556, 360)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(5, 4)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.right_top
        Me.PictureBox7.Location = New System.Drawing.Point(556, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(5, 5)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.left_top
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(5, 5)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.right_main
        Me.PictureBox5.Location = New System.Drawing.Point(556, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(5, 364)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.left_main
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(5, 364)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.top_main
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(561, 5)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.OmegaSkins.My.Resources.Resources.bottom_main
        Me.PictureBox2.Location = New System.Drawing.Point(0, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(562, 4)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TiffPNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "TiffPNA"
        Me.Size = New System.Drawing.Size(561, 364)
        Me.Panel1.ResumeLayout(False)
        CType(Me.docView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents docView As AxMODI.AxMiDocView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSelect As OmegaSkins.ButtonPNA
    Friend WithEvents btnPrint As OmegaSkins.ButtonPNA
    Friend WithEvents btnPan As OmegaSkins.ButtonPNA
    Friend WithEvents btnNext As OmegaSkins.ButtonPNA
    Friend WithEvents btnZoomOut As OmegaSkins.ButtonPNA
    Friend WithEvents btnPrev As OmegaSkins.ButtonPNA
    Friend WithEvents btnZoomIn As OmegaSkins.ButtonPNA
    Friend WithEvents btnRotateRight As OmegaSkins.ButtonPNA
    Friend WithEvents btnFitWidth As OmegaSkins.ButtonPNA
    Friend WithEvents btnRotateLeft As OmegaSkins.ButtonPNA
    Friend WithEvents btnFitHeight As OmegaSkins.ButtonPNA
    Friend WithEvents btnShowTwo As OmegaSkins.ButtonPNA
    Friend WithEvents btnShowSingle As OmegaSkins.ButtonPNA
    Friend WithEvents btnShowContinous As OmegaSkins.ButtonPNA
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As OmegaSkins.ButtonPNA
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
