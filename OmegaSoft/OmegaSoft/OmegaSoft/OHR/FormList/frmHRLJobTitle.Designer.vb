<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRLJobTitle
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.FrmList1 = New OmegaSkins.FrmList
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.grdJobTitle = New System.Windows.Forms.DataGridView
        Me.rdoDepartmentName = New OmegaSkins1.RadioButtonPNA1
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.rdoJName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDJobTitle = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        CType(Me.grdJobTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FrmList1
        '
        Me.FrmList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrmList1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FrmList1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrmList1.Location = New System.Drawing.Point(0, 0)
        Me.FrmList1.Name = "FrmList1"
        Me.FrmList1.Size = New System.Drawing.Size(649, 539)
        Me.FrmList1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(541, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grdJobTitle
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdJobTitle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdJobTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdJobTitle.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdJobTitle.Location = New System.Drawing.Point(13, 110)
        Me.grdJobTitle.Name = "grdJobTitle"
        Me.grdJobTitle.Size = New System.Drawing.Size(615, 366)
        Me.grdJobTitle.TabIndex = 7
        '
        'rdoDepartmentName
        '
        Me.rdoDepartmentName.AutoSize = True
        Me.rdoDepartmentName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDepartmentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoDepartmentName.Location = New System.Drawing.Point(321, 86)
        Me.rdoDepartmentName.Name = "rdoDepartmentName"
        Me.rdoDepartmentName.Size = New System.Drawing.Size(108, 19)
        Me.rdoDepartmentName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoDepartmentName.TabIndex = 6
        Me.rdoDepartmentName.TabStop = True
        Me.rdoDepartmentName.Text = "Tên phòng ban"
        Me.rdoDepartmentName.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(94, 62)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(445, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'rdoJName
        '
        Me.rdoJName.AutoSize = True
        Me.rdoJName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoJName.Location = New System.Drawing.Point(207, 86)
        Me.rdoJName.Name = "rdoJName"
        Me.rdoJName.Size = New System.Drawing.Size(91, 19)
        Me.rdoJName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoJName.TabIndex = 5
        Me.rdoJName.TabStop = True
        Me.rdoJName.Text = "Tên chức vụ"
        Me.rdoJName.UseVisualStyleBackColor = True
        '
        'rdoIDJobTitle
        '
        Me.rdoIDJobTitle.AutoSize = True
        Me.rdoIDJobTitle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDJobTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDJobTitle.Location = New System.Drawing.Point(94, 86)
        Me.rdoIDJobTitle.Name = "rdoIDJobTitle"
        Me.rdoIDJobTitle.Size = New System.Drawing.Size(86, 19)
        Me.rdoIDJobTitle.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDJobTitle.TabIndex = 4
        Me.rdoIDJobTitle.TabStop = True
        Me.rdoIDJobTitle.Text = "Mã chức vụ"
        Me.rdoIDJobTitle.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(10, 62)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(82, 20)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Tìm kiếm"
        '
        'lblList
        '
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblList.Location = New System.Drawing.Point(10, 478)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 1
        Me.lblList.Text = "Danh sách chức vụ"
        '
        'frmHRLJobTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 505)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.grdJobTitle)
        Me.Controls.Add(Me.rdoDepartmentName)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.rdoJName)
        Me.Controls.Add(Me.rdoIDJobTitle)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.FrmList1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHRLJobTitle"
        Me.Text = "frmHRLJobTitle"
        CType(Me.grdJobTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FrmList1 As OmegaSkins.FrmList
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents grdJobTitle As System.Windows.Forms.DataGridView
    Friend WithEvents rdoDepartmentName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoJName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDJobTitle As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
End Class
