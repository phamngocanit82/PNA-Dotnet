<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmULLCustomer
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
        Me.FrmList1 = New OmegaSkins.FrmList
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.grdCustomer = New System.Windows.Forms.DataGridView
        Me.rdoAddress = New OmegaSkins1.RadioButtonPNA1
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.rdoCName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDCustomer = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FrmList1.Size = New System.Drawing.Size(674, 487)
        Me.FrmList1.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(573, 61)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grdCustomer
        '
        Me.grdCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCustomer.Location = New System.Drawing.Point(13, 109)
        Me.grdCustomer.Name = "grdCustomer"
        Me.grdCustomer.Size = New System.Drawing.Size(647, 348)
        Me.grdCustomer.TabIndex = 7
        '
        'rdoAddress
        '
        Me.rdoAddress.AutoSize = True
        Me.rdoAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoAddress.Location = New System.Drawing.Point(330, 86)
        Me.rdoAddress.Name = "rdoAddress"
        Me.rdoAddress.Size = New System.Drawing.Size(63, 19)
        Me.rdoAddress.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoAddress.TabIndex = 6
        Me.rdoAddress.TabStop = True
        Me.rdoAddress.Text = "Địa chỉ"
        Me.rdoAddress.UseVisualStyleBackColor = True
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
        Me.txtSearch.Size = New System.Drawing.Size(478, 20)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 20
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
        '
        'rdoCName
        '
        Me.rdoCName.AutoSize = True
        Me.rdoCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCName.Location = New System.Drawing.Point(211, 86)
        Me.rdoCName.Name = "rdoCName"
        Me.rdoCName.Size = New System.Drawing.Size(113, 19)
        Me.rdoCName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCName.TabIndex = 5
        Me.rdoCName.TabStop = True
        Me.rdoCName.Text = "Tên khách hàng"
        Me.rdoCName.UseVisualStyleBackColor = True
        '
        'rdoIDCustomer
        '
        Me.rdoIDCustomer.AutoSize = True
        Me.rdoIDCustomer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDCustomer.Location = New System.Drawing.Point(93, 86)
        Me.rdoIDCustomer.Name = "rdoIDCustomer"
        Me.rdoIDCustomer.Size = New System.Drawing.Size(108, 19)
        Me.rdoIDCustomer.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDCustomer.TabIndex = 4
        Me.rdoIDCustomer.TabStop = True
        Me.rdoIDCustomer.Text = "Mã khách hàng"
        Me.rdoIDCustomer.UseVisualStyleBackColor = True
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
        Me.lblList.Location = New System.Drawing.Point(10, 460)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 1
        Me.lblList.Text = "Danh sách khách hàng"
        '
        'frmULLCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 487)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.grdCustomer)
        Me.Controls.Add(Me.rdoAddress)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.rdoCName)
        Me.Controls.Add(Me.rdoIDCustomer)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.FrmList1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmULLCustomer"
        Me.Text = "frmULLCustomer"
        CType(Me.grdCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FrmList1 As OmegaSkins.FrmList
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents grdCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents rdoAddress As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoCName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDCustomer As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
End Class
