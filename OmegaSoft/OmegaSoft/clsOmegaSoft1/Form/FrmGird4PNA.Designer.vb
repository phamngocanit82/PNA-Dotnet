<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGird4PNA
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGird4PNA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tbrHRCountry = New System.Windows.Forms.ToolStrip
        Me.tbrAdd = New System.Windows.Forms.ToolStripButton
        Me.tbrCheck = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.tbrClose = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtTo = New OmegaSkins.DateTimePNA
        Me.txtFromDate = New OmegaSkins.DateTimePNA
        Me.btnSearch = New OmegaSkins.ButtonPNA(Me.components)
        Me.TextBoxPNA1 = New OmegaSkins.TextBoxPNA
        Me.grdList = New System.Windows.Forms.DataGridView
        Me.ComboBoxPNA1 = New OmegaSkins.ComboBoxPNA(Me.components)
        Me.lblList = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFromDate = New System.Windows.Forms.Label
        Me.lblSearch = New System.Windows.Forms.Label
        Me.tbrHRCountry.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbrHRCountry
        '
        Me.tbrHRCountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrHRCountry.AutoSize = False
        Me.tbrHRCountry.BackColor = System.Drawing.Color.Transparent
        Me.tbrHRCountry.BackgroundImage = CType(resources.GetObject("tbrHRCountry.BackgroundImage"), System.Drawing.Image)
        Me.tbrHRCountry.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrHRCountry.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrAdd, Me.tbrCheck, Me.tbrRefesh, Me.tbrClose})
        Me.tbrHRCountry.Location = New System.Drawing.Point(9, 33)
        Me.tbrHRCountry.Name = "tbrHRCountry"
        Me.tbrHRCountry.Size = New System.Drawing.Size(624, 25)
        Me.tbrHRCountry.TabIndex = 23
        '
        'tbrAdd
        '
        Me.tbrAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrAdd.Image = Global.clsOmegaSoft1.My.Resources.Resources.Add0
        Me.tbrAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrAdd.Name = "tbrAdd"
        Me.tbrAdd.Size = New System.Drawing.Size(23, 22)
        Me.tbrAdd.Text = "Add item"
        '
        'tbrCheck
        '
        Me.tbrCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCheck.Image = Global.clsOmegaSoft1.My.Resources.Resources.check
        Me.tbrCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCheck.Name = "tbrCheck"
        Me.tbrCheck.Size = New System.Drawing.Size(23, 22)
        Me.tbrCheck.Text = "Select item"
        '
        'tbrRefesh
        '
        Me.tbrRefesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRefesh.Image = Global.clsOmegaSoft1.My.Resources.Resources.Refresh
        Me.tbrRefesh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRefesh.Name = "tbrRefesh"
        Me.tbrRefesh.Size = New System.Drawing.Size(23, 22)
        Me.tbrRefesh.Text = "Refesh data"
        '
        'tbrClose
        '
        Me.tbrClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClose.Image = Global.clsOmegaSoft1.My.Resources.Resources.Close
        Me.tbrClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrClose.Name = "tbrClose"
        Me.tbrClose.Size = New System.Drawing.Size(23, 22)
        Me.tbrClose.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.txtFromDate)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.TextBoxPNA1)
        Me.Panel1.Controls.Add(Me.grdList)
        Me.Panel1.Controls.Add(Me.ComboBoxPNA1)
        Me.Panel1.Controls.Add(Me.lblList)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblFromDate)
        Me.Panel1.Controls.Add(Me.lblSearch)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 471)
        Me.Panel1.TabIndex = 24
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(87, 107)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.SetDay = 0
        Me.txtTo.SetMonth = 0
        Me.txtTo.SetYear = 0
        Me.txtTo.Size = New System.Drawing.Size(118, 20)
        Me.txtTo.Style = OmegaSkins.DateTimePNA.StyleDateTime.Style1
        Me.txtTo.TabIndex = 10
        Me.txtTo.TReadOnly = False
        '
        'txtFromDate
        '
        Me.txtFromDate.Location = New System.Drawing.Point(87, 84)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.SetDay = 0
        Me.txtFromDate.SetMonth = 0
        Me.txtFromDate.SetYear = 0
        Me.txtFromDate.Size = New System.Drawing.Size(118, 20)
        Me.txtFromDate.Style = OmegaSkins.DateTimePNA.StyleDateTime.Style1
        Me.txtFromDate.TabIndex = 9
        Me.txtFromDate.TReadOnly = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(543, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 20)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "     &Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBoxPNA1
        '
        Me.TextBoxPNA1.BackColor = System.Drawing.Color.ForestGreen
        Me.TextBoxPNA1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TextBoxPNA1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPNA1.Location = New System.Drawing.Point(87, 61)
        Me.TextBoxPNA1.MaxLength = 32767
        Me.TextBoxPNA1.Multiline = False
        Me.TextBoxPNA1.Name = "TextBoxPNA1"
        Me.TextBoxPNA1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxPNA1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TextBoxPNA1.Size = New System.Drawing.Size(455, 20)
        Me.TextBoxPNA1.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.TextBoxPNA1.TabIndex = 2
        Me.TextBoxPNA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxPNA1.THeight = 20
        Me.TextBoxPNA1.TReadOnly = False
        Me.TextBoxPNA1.TText = ""
        '
        'grdList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdList.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdList.GridColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.grdList.Location = New System.Drawing.Point(9, 130)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(624, 332)
        Me.grdList.TabIndex = 6
        '
        'ComboBoxPNA1
        '
        Me.ComboBoxPNA1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ComboBoxPNA1.FormattingEnabled = True
        Me.ComboBoxPNA1.Location = New System.Drawing.Point(208, 84)
        Me.ComboBoxPNA1.Name = "ComboBoxPNA1"
        Me.ComboBoxPNA1.Size = New System.Drawing.Size(239, 23)
        Me.ComboBoxPNA1.Style = OmegaSkins.ComboBoxPNA.StyleComboBox.Style1
        Me.ComboBoxPNA1.TabIndex = 1
        '
        'lblList
        '
        Me.lblList.BackColor = System.Drawing.Color.Transparent
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(9, 4)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(624, 27)
        Me.lblList.TabIndex = 0
        Me.lblList.Text = "Danh sách"
        Me.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "To date"
        '
        'lblFromDate
        '
        Me.lblFromDate.BackColor = System.Drawing.Color.Transparent
        Me.lblFromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblFromDate.Location = New System.Drawing.Point(12, 84)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(82, 20)
        Me.lblFromDate.TabIndex = 11
        Me.lblFromDate.Text = "From date"
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(12, 61)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 7
        Me.lblSearch.Text = "Search"
        '
        'FrmGird3PNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 471)
        Me.Controls.Add(Me.tbrHRCountry)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGird3PNA"
        Me.tbrHRCountry.ResumeLayout(False)
        Me.tbrHRCountry.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbrHRCountry As System.Windows.Forms.ToolStrip
    Public WithEvents tbrAdd As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrCheck As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents TextBoxPNA1 As OmegaSkins.TextBoxPNA
    Friend WithEvents ComboBoxPNA1 As OmegaSkins.ComboBoxPNA
    Friend WithEvents grdList As System.Windows.Forms.DataGridView
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFromDate As System.Windows.Forms.Label
    Friend WithEvents txtTo As OmegaSkins.DateTimePNA
    Friend WithEvents txtFromDate As OmegaSkins.DateTimePNA

End Class
