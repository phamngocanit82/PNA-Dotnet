<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRLEmployee
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
        Me.chkFemale = New OmegaSkins1.CheckBoxPNA1
        Me.chkMale = New OmegaSkins1.CheckBoxPNA1
        Me.rdoLevelName = New OmegaSkins1.RadioButtonPNA1
        Me.grdEmployee = New System.Windows.Forms.DataGridView
        Me.rdoJobTitleName = New OmegaSkins1.RadioButtonPNA1
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.rdoEName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDEmployee = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        Me.btnSearch = New OmegaSkins.ButtonPNA
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FrmList1.Size = New System.Drawing.Size(708, 549)
        Me.FrmList1.TabIndex = 0
        '
        'chkFemale
        '
        Me.chkFemale.AutoSize = True
        Me.chkFemale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFemale.Location = New System.Drawing.Point(585, 86)
        Me.chkFemale.Name = "chkFemale"
        Me.chkFemale.Size = New System.Drawing.Size(43, 19)
        Me.chkFemale.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkFemale.TabIndex = 9
        Me.chkFemale.Text = "Nữ"
        Me.chkFemale.UseVisualStyleBackColor = True
        '
        'chkMale
        '
        Me.chkMale.AutoSize = True
        Me.chkMale.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMale.Location = New System.Drawing.Point(533, 86)
        Me.chkMale.Name = "chkMale"
        Me.chkMale.Size = New System.Drawing.Size(53, 19)
        Me.chkMale.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
        Me.chkMale.TabIndex = 8
        Me.chkMale.Text = "Nam"
        Me.chkMale.UseVisualStyleBackColor = True
        '
        'rdoLevelName
        '
        Me.rdoLevelName.AutoSize = True
        Me.rdoLevelName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLevelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoLevelName.Location = New System.Drawing.Point(413, 86)
        Me.rdoLevelName.Name = "rdoLevelName"
        Me.rdoLevelName.Size = New System.Drawing.Size(90, 19)
        Me.rdoLevelName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoLevelName.TabIndex = 7
        Me.rdoLevelName.TabStop = True
        Me.rdoLevelName.Text = "Tên trình độ"
        Me.rdoLevelName.UseVisualStyleBackColor = True
        '
        'grdEmployee
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdEmployee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEmployee.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdEmployee.Location = New System.Drawing.Point(13, 109)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.Size = New System.Drawing.Size(674, 376)
        Me.grdEmployee.TabIndex = 10
        '
        'rdoJobTitleName
        '
        Me.rdoJobTitleName.AutoSize = True
        Me.rdoJobTitleName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJobTitleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoJobTitleName.Location = New System.Drawing.Point(319, 86)
        Me.rdoJobTitleName.Name = "rdoJobTitleName"
        Me.rdoJobTitleName.Size = New System.Drawing.Size(91, 19)
        Me.rdoJobTitleName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoJobTitleName.TabIndex = 6
        Me.rdoJobTitleName.TabStop = True
        Me.rdoJobTitleName.Text = "Tên chức vụ"
        Me.rdoJobTitleName.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(93, 62)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(505, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'rdoEName
        '
        Me.rdoEName.AutoSize = True
        Me.rdoEName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoEName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoEName.Location = New System.Drawing.Point(205, 86)
        Me.rdoEName.Name = "rdoEName"
        Me.rdoEName.Size = New System.Drawing.Size(102, 19)
        Me.rdoEName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoEName.TabIndex = 5
        Me.rdoEName.TabStop = True
        Me.rdoEName.Text = "Tên nhân viên"
        Me.rdoEName.UseVisualStyleBackColor = True
        '
        'rdoIDEmployee
        '
        Me.rdoIDEmployee.AutoSize = True
        Me.rdoIDEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDEmployee.Location = New System.Drawing.Point(93, 86)
        Me.rdoIDEmployee.Name = "rdoIDEmployee"
        Me.rdoIDEmployee.Size = New System.Drawing.Size(97, 19)
        Me.rdoIDEmployee.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDEmployee.TabIndex = 4
        Me.rdoIDEmployee.TabStop = True
        Me.rdoIDEmployee.Text = "Mã nhân viên"
        Me.rdoIDEmployee.UseVisualStyleBackColor = True
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
        Me.lblList.Location = New System.Drawing.Point(10, 488)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 1
        Me.lblList.Text = "Danh sách nhân viên"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(600, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmHRLEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 515)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.chkFemale)
        Me.Controls.Add(Me.chkMale)
        Me.Controls.Add(Me.rdoLevelName)
        Me.Controls.Add(Me.grdEmployee)
        Me.Controls.Add(Me.rdoJobTitleName)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.rdoEName)
        Me.Controls.Add(Me.rdoIDEmployee)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.FrmList1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHRLEmployee"
        Me.Text = "frmHRLEmployee"
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FrmList1 As OmegaSkins.FrmList
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents chkFemale As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents chkMale As OmegaSkins1.CheckBoxPNA1
    Friend WithEvents rdoLevelName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents grdEmployee As System.Windows.Forms.DataGridView
    Friend WithEvents rdoJobTitleName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoEName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDEmployee As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
End Class
