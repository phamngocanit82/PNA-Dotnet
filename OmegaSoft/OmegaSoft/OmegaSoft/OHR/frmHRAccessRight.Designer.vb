<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRAccessRight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRAccessRight))
        Me.grdEmployee = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblEmployee = New System.Windows.Forms.Label
        Me.grdTask = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTask = New System.Windows.Forms.Label
        Me.tbrSave = New System.Windows.Forms.ToolStripButton
        Me.tbrRefesh = New System.Windows.Forms.ToolStripButton
        Me.tbrHRCompany = New System.Windows.Forms.ToolStrip
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tbrHRCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdEmployee
        '
        Me.grdEmployee.AllowEditing = False
        Me.grdEmployee.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.grdEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEmployee.BackColor = System.Drawing.SystemColors.Window
        Me.grdEmployee.ColumnInfo = "3,1,0,0,0,90,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:320;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:0;Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.grdEmployee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdEmployee.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grdEmployee.Location = New System.Drawing.Point(1, 40)
        Me.grdEmployee.Name = "grdEmployee"
        Me.grdEmployee.Size = New System.Drawing.Size(270, 544)
        Me.grdEmployee.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("grdEmployee.Styles"))
        Me.grdEmployee.TabIndex = 52
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackgroundImage = Global.OmegaSoft.My.Resources.Resources.Split01
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdEmployee)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdTask)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(788, 588)
        Me.SplitContainer1.SplitterDistance = 274
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 54
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.OmegaSoft.My.Resources.Resources.Tree
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblEmployee)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 37)
        Me.Panel1.TabIndex = 54
        '
        'lblEmployee
        '
        Me.lblEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployee.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployee.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblEmployee.Location = New System.Drawing.Point(0, 0)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(270, 37)
        Me.lblEmployee.TabIndex = 53
        Me.lblEmployee.Text = "Danh sách nhân viên"
        Me.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grdTask
        '
        Me.grdTask.AllowEditing = False
        Me.grdTask.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.grdTask.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTask.BackColor = System.Drawing.SystemColors.Window
        Me.grdTask.ColumnInfo = resources.GetString("grdTask.ColumnInfo")
        Me.grdTask.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTask.ForeColor = System.Drawing.SystemColors.WindowText
        Me.grdTask.Location = New System.Drawing.Point(1, 40)
        Me.grdTask.Name = "grdTask"
        Me.grdTask.Size = New System.Drawing.Size(505, 544)
        Me.grdTask.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("grdTask.Styles"))
        Me.grdTask.TabIndex = 56
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackgroundImage = Global.OmegaSoft.My.Resources.Resources.Tree
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblTask)
        Me.Panel2.Location = New System.Drawing.Point(1, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(505, 37)
        Me.Panel2.TabIndex = 55
        '
        'lblTask
        '
        Me.lblTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTask.BackColor = System.Drawing.Color.Transparent
        Me.lblTask.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lblTask.Location = New System.Drawing.Point(1, 0)
        Me.lblTask.Name = "lblTask"
        Me.lblTask.Size = New System.Drawing.Size(505, 37)
        Me.lblTask.TabIndex = 54
        Me.lblTask.Text = "Danh sách tác vụ"
        Me.lblTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbrSave
        '
        Me.tbrSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrSave.Image = Global.OmegaSoft.My.Resources.Resources.Save
        Me.tbrSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrSave.Name = "tbrSave"
        Me.tbrSave.Size = New System.Drawing.Size(23, 22)
        Me.tbrSave.Text = "Lưu tập tin"
        '
        'tbrRefesh
        '
        Me.tbrRefesh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRefesh.Image = Global.OmegaSoft.My.Resources.Resources.Refresh
        Me.tbrRefesh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrRefesh.Name = "tbrRefesh"
        Me.tbrRefesh.Size = New System.Drawing.Size(23, 22)
        Me.tbrRefesh.Text = "Cập nhật dữ liệu"
        '
        'tbrHRCompany
        '
        Me.tbrHRCompany.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbrHRCompany.AutoSize = False
        Me.tbrHRCompany.BackColor = System.Drawing.SystemColors.Control
        Me.tbrHRCompany.BackgroundImage = Global.OmegaSoft.My.Resources.Resources.ChildToolbar
        Me.tbrHRCompany.Dock = System.Windows.Forms.DockStyle.None
        Me.tbrHRCompany.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrSave, Me.tbrRefesh})
        Me.tbrHRCompany.Location = New System.Drawing.Point(0, 0)
        Me.tbrHRCompany.Name = "tbrHRCompany"
        Me.tbrHRCompany.Size = New System.Drawing.Size(863, 25)
        Me.tbrHRCompany.TabIndex = 51
        '
        'frmHRAccessRight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 616)
        Me.Controls.Add(Me.tbrHRCompany)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmHRAccessRight"
        Me.Text = "frmHRAccessRight"
        CType(Me.grdEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tbrHRCompany.ResumeLayout(False)
        Me.tbrHRCompany.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdEmployee As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblEmployee As System.Windows.Forms.Label
    Friend WithEvents lblTask As System.Windows.Forms.Label
    Friend WithEvents tbrSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrRefesh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrHRCompany As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grdTask As C1.Win.C1FlexGrid.C1FlexGrid
End Class
