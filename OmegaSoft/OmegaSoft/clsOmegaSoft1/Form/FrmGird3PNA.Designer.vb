<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGird3PNA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGird3PNA))
        Me.tbrHRList = New System.Windows.Forms.ToolStrip
        Me.tbrAdd = New System.Windows.Forms.ToolStripButton
        Me.tbrCheck = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.tbrClose = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.grdList = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.btnClose = New OmegaSkins1.ButtonPNA4
        Me.lblList = New System.Windows.Forms.Label
        Me.tbrHRList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbrHRList
        '
        Me.tbrHRList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrHRList.AutoSize = False
        Me.tbrHRList.BackColor = System.Drawing.Color.Transparent
        Me.tbrHRList.BackgroundImage = CType(resources.GetObject("tbrHRList.BackgroundImage"), System.Drawing.Image)
        Me.tbrHRList.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrHRList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrAdd, Me.tbrCheck, Me.tbrRefesh, Me.tbrClose})
        Me.tbrHRList.Location = New System.Drawing.Point(8, 31)
        Me.tbrHRList.Name = "tbrHRList"
        Me.tbrHRList.Size = New System.Drawing.Size(625, 23)
        Me.tbrHRList.TabIndex = 23
        '
        'tbrAdd
        '
        Me.tbrAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrAdd.Image = Global.clsOmegaSoft1.My.Resources.Resources.Add0
        Me.tbrAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrAdd.Name = "tbrAdd"
        Me.tbrAdd.Size = New System.Drawing.Size(23, 20)
        Me.tbrAdd.Text = "Add item"
        '
        'tbrCheck
        '
        Me.tbrCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCheck.Image = Global.clsOmegaSoft1.My.Resources.Resources.check
        Me.tbrCheck.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCheck.Name = "tbrCheck"
        Me.tbrCheck.Size = New System.Drawing.Size(23, 20)
        Me.tbrCheck.Text = "Select item"
        '
        'tbrRefesh
        '
        Me.tbrRefesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRefesh.Image = Global.clsOmegaSoft1.My.Resources.Resources.Refresh
        Me.tbrRefesh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRefesh.Name = "tbrRefesh"
        Me.tbrRefesh.Size = New System.Drawing.Size(23, 20)
        Me.tbrRefesh.Text = "Refesh data"
        '
        'tbrClose
        '
        Me.tbrClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClose.Image = Global.clsOmegaSoft1.My.Resources.Resources.Close
        Me.tbrClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrClose.Name = "tbrClose"
        Me.tbrClose.Size = New System.Drawing.Size(23, 20)
        Me.tbrClose.Text = "Close"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.grdList)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblList)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 471)
        Me.Panel1.TabIndex = 24
        '
        'grdList
        '
        Me.grdList.AllowEditing = False
        Me.grdList.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.grdList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdList.BackColor = System.Drawing.SystemColors.Window
        Me.grdList.ColumnInfo = "3,1,0,0,0,90,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:583;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:0;Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.grdList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.grdList.Location = New System.Drawing.Point(9, 57)
        Me.grdList.Name = "grdList"
        Me.grdList.Size = New System.Drawing.Size(623, 404)
        Me.grdList.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("grdList.Styles"))
        Me.grdList.TabIndex = 53
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(617, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 17)
        Me.btnClose.Style = OmegaSkins1.ButtonPNA4.StyleButton.Style1
        Me.btnClose.TabIndex = 10
        Me.btnClose.TText = "Close"
        '
        'lblList
        '
        Me.lblList.BackColor = System.Drawing.Color.Transparent
        Me.lblList.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblList.ForeColor = System.Drawing.Color.White
        Me.lblList.Location = New System.Drawing.Point(8, 4)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(626, 25)
        Me.lblList.TabIndex = 0
        Me.lblList.Text = "Danh sách"
        Me.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmGird3PNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 471)
        Me.Controls.Add(Me.tbrHRList)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGird3PNA"
        Me.tbrHRList.ResumeLayout(False)
        Me.tbrHRList.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbrHRList As System.Windows.Forms.ToolStrip
    Public WithEvents tbrAdd As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrCheck As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Public WithEvents tbrClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblList As System.Windows.Forms.Label
    Friend WithEvents btnClose As OmegaSkins1.ButtonPNA4
    Public WithEvents grdList As C1.Win.C1FlexGrid.C1FlexGrid

End Class
