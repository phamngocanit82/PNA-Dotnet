<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRLCountry
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.rdoCName = New OmegaSkins1.RadioButtonPNA1
        Me.rdoIDCountry = New OmegaSkins1.RadioButtonPNA1
        Me.lblSearch = New System.Windows.Forms.Label
        Me.lblList = New System.Windows.Forms.Label
        Me.btnSearch = New OmegaSkins.ButtonPNA
        Me.txtSearch = New OmegaSkins.TextBoxPNA
        Me.FrmList1 = New OmegaSkins.FrmList
        Me.grdCountry = New System.Windows.Forms.DataGridView
        CType(Me.grdCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdoCName
        '
        Me.rdoCName.AutoSize = True
        Me.rdoCName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoCName.Location = New System.Drawing.Point(190, 87)
        Me.rdoCName.Name = "rdoCName"
        Me.rdoCName.Size = New System.Drawing.Size(96, 19)
        Me.rdoCName.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoCName.TabIndex = 5
        Me.rdoCName.TabStop = True
        Me.rdoCName.Text = "Tên quốc gia"
        Me.rdoCName.UseVisualStyleBackColor = True
        '
        'rdoIDCountry
        '
        Me.rdoIDCountry.AutoSize = True
        Me.rdoIDCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoIDCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.rdoIDCountry.Location = New System.Drawing.Point(93, 87)
        Me.rdoIDCountry.Name = "rdoIDCountry"
        Me.rdoIDCountry.Size = New System.Drawing.Size(91, 19)
        Me.rdoIDCountry.Style = OmegaSkins1.RadioButtonPNA1.StyleRadioButton.Style1
        Me.rdoIDCountry.TabIndex = 4
        Me.rdoIDCountry.TabStop = True
        Me.rdoIDCountry.Text = "Mã quốc gia"
        Me.rdoIDCountry.UseVisualStyleBackColor = True
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
        Me.lblList.Location = New System.Drawing.Point(10, 479)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(190, 20)
        Me.lblList.TabIndex = 1
        Me.lblList.Text = "Danh sách quốc gia"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Info
        Me.btnSearch.BToolTip = Nothing
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSearch.Image = Global.OmegaSoft.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(541, 62)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 22)
        Me.btnSearch.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "     &Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.ForestGreen
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(93, 62)
        Me.txtSearch.MaxLength = 100
        Me.txtSearch.Multiline = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch.Size = New System.Drawing.Size(446, 21)
        Me.txtSearch.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
        Me.txtSearch.TabIndex = 2
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.THeight = 21
        Me.txtSearch.TReadOnly = False
        Me.txtSearch.TText = ""
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
        Me.FrmList1.Size = New System.Drawing.Size(641, 505)
        Me.FrmList1.TabIndex = 0
        '
        'grdCountry
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCountry.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(220, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCountry.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCountry.Location = New System.Drawing.Point(13, 110)
        Me.grdCountry.Name = "grdCountry"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdCountry.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdCountry.Size = New System.Drawing.Size(615, 366)
        Me.grdCountry.TabIndex = 17
        '
        'frmHRLCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 505)
        Me.Controls.Add(Me.grdCountry)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.rdoCName)
        Me.Controls.Add(Me.rdoIDCountry)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.FrmList1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHRLCountry"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Omega Soft"
        CType(Me.grdCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FrmList1 As OmegaSkins.frmList
    Friend WithEvents btnSearch As OmegaSkins.ButtonPNA
    Friend WithEvents txtSearch As OmegaSkins.TextBoxPNA
    Friend WithEvents rdoCName As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents rdoIDCountry As OmegaSkins1.RadioButtonPNA1
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents grdCountry As System.Windows.Forms.DataGridView
End Class
