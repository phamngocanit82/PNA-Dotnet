<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRLevel
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRLevel))
        Me.tabFunctions = New DevExpress.XtraTab.XtraTabControl
        Me.tabInformation = New DevExpress.XtraTab.XtraTabPage
        Me.gridControlTable1 = New DevExpress.XtraGrid.GridControl
        Me.gridViewtable1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtIDLevel = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.lblIDLevel = New DevExpress.XtraEditors.LabelControl
        Me.tabList = New DevExpress.XtraTab.XtraTabPage
        Me.gridControlTable2 = New DevExpress.XtraGrid.GridControl
        Me.gridViewtable2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cboSearch = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        CType(Me.tabFunctions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFunctions.SuspendLayout()
        Me.tabInformation.SuspendLayout()
        CType(Me.gridControlTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewtable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDLevel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabList.SuspendLayout()
        CType(Me.gridControlTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewtable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabFunctions
        '
        Me.tabFunctions.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.tabFunctions.Appearance.Options.UseFont = True
        Me.tabFunctions.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.tabFunctions.AppearancePage.Header.Options.UseFont = True
        Me.tabFunctions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabFunctions.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom
        Me.tabFunctions.Location = New System.Drawing.Point(0, 0)
        Me.tabFunctions.Name = "tabFunctions"
        Me.tabFunctions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabFunctions.SelectedTabPage = Me.tabInformation
        Me.tabFunctions.Size = New System.Drawing.Size(792, 666)
        Me.tabFunctions.TabIndex = 12
        Me.tabFunctions.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabInformation, Me.tabList})
        '
        'tabInformation
        '
        Me.tabInformation.AutoScroll = True
        Me.tabInformation.Controls.Add(Me.gridControlTable1)
        Me.tabInformation.Controls.Add(Me.txtDescription)
        Me.tabInformation.Controls.Add(Me.txtName)
        Me.tabInformation.Controls.Add(Me.txtIDLevel)
        Me.tabInformation.Controls.Add(Me.lblDescription)
        Me.tabInformation.Controls.Add(Me.lblName)
        Me.tabInformation.Controls.Add(Me.lblIDLevel)
        Me.tabInformation.Name = "tabInformation"
        Me.tabInformation.Size = New System.Drawing.Size(783, 633)
        Me.tabInformation.Text = "Information"
        '
        'gridControlTable1
        '
        Me.gridControlTable1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControlTable1.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridControlTable1.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.gridControlTable1.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gridControlTable1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gridControlTable1.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gridControlTable1.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gridControlTable1.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.gridControlTable1.EmbeddedNavigator.Name = ""
        Me.gridControlTable1.Location = New System.Drawing.Point(20, 151)
        Me.gridControlTable1.MainView = Me.gridViewtable1
        Me.gridControlTable1.Name = "gridControlTable1"
        Me.gridControlTable1.Size = New System.Drawing.Size(743, 479)
        Me.gridControlTable1.TabIndex = 12
        Me.gridControlTable1.UseEmbeddedNavigator = True
        Me.gridControlTable1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewtable1})
        '
        'gridViewtable1
        '
        Me.gridViewtable1.GridControl = Me.gridControlTable1
        Me.gridViewtable1.Name = "gridViewtable1"
        Me.gridViewtable1.OptionsView.ShowDetailButtons = False
        Me.gridViewtable1.OptionsView.ShowGroupPanel = False
        Me.gridViewtable1.PaintStyleName = "Skin"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(115, 68)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(648, 77)
        Me.txtDescription.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(115, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtName.Properties.Appearance.Options.UseFont = True
        Me.txtName.Properties.MaxLength = 100
        Me.txtName.Size = New System.Drawing.Size(648, 21)
        Me.txtName.TabIndex = 4
        '
        'txtIDLevel
        '
        Me.txtIDLevel.EditValue = ""
        Me.txtIDLevel.Location = New System.Drawing.Point(115, 20)
        Me.txtIDLevel.Name = "txtIDLevel"
        Me.txtIDLevel.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtIDLevel.Properties.Appearance.Options.UseFont = True
        Me.txtIDLevel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDLevel.Properties.MaxLength = 15
        Me.txtIDLevel.Size = New System.Drawing.Size(125, 21)
        Me.txtIDLevel.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDescription.Appearance.Options.UseFont = True
        Me.lblDescription.Location = New System.Drawing.Point(20, 71)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 15)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblName.Appearance.Options.UseFont = True
        Me.lblName.Location = New System.Drawing.Point(20, 47)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(34, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'lblIDLevel
        '
        Me.lblIDLevel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIDLevel.Appearance.Options.UseFont = True
        Me.lblIDLevel.Location = New System.Drawing.Point(20, 23)
        Me.lblIDLevel.Name = "lblIDLevel"
        Me.lblIDLevel.Size = New System.Drawing.Size(41, 15)
        Me.lblIDLevel.TabIndex = 1
        Me.lblIDLevel.Text = "IDLevel"
        '
        'tabList
        '
        Me.tabList.AutoScroll = True
        Me.tabList.Controls.Add(Me.gridControlTable2)
        Me.tabList.Controls.Add(Me.btnSearch)
        Me.tabList.Controls.Add(Me.cboSearch)
        Me.tabList.Controls.Add(Me.txtSearch)
        Me.tabList.Controls.Add(Me.lblSearch)
        Me.tabList.Name = "tabList"
        Me.tabList.Size = New System.Drawing.Size(783, 633)
        Me.tabList.Text = "List"
        '
        'gridControlTable2
        '
        Me.gridControlTable2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridControlTable2.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridControlTable2.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.gridControlTable2.EmbeddedNavigator.Buttons.Append.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.CancelEdit.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.Edit.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.EndEdit.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Buttons.Remove.Enabled = False
        Me.gridControlTable2.EmbeddedNavigator.Name = ""
        Me.gridControlTable2.Location = New System.Drawing.Point(20, 71)
        Me.gridControlTable2.MainView = Me.gridViewtable2
        Me.gridControlTable2.Name = "gridControlTable2"
        Me.gridControlTable2.Size = New System.Drawing.Size(743, 559)
        Me.gridControlTable2.TabIndex = 16
        Me.gridControlTable2.UseEmbeddedNavigator = True
        Me.gridControlTable2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewtable2})
        '
        'gridViewtable2
        '
        Me.gridViewtable2.GridControl = Me.gridControlTable2
        Me.gridViewtable2.Name = "gridViewtable2"
        Me.gridViewtable2.OptionsView.ShowDetailButtons = False
        Me.gridViewtable2.OptionsView.ShowGroupPanel = False
        Me.gridViewtable2.PaintStyleName = "Skin"
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.Location = New System.Drawing.Point(419, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 25)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        '
        'cboSearch
        '
        Me.cboSearch.EditValue = ""
        Me.cboSearch.Location = New System.Drawing.Point(115, 44)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearch.Properties.Appearance.Options.UseFont = True
        Me.cboSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboSearch.Size = New System.Drawing.Size(300, 21)
        Me.cboSearch.TabIndex = 13
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(115, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Size = New System.Drawing.Size(648, 21)
        Me.txtSearch.TabIndex = 12
        '
        'lblSearch
        '
        Me.lblSearch.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblSearch.Appearance.Options.UseFont = True
        Me.lblSearch.Location = New System.Drawing.Point(20, 23)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(39, 15)
        Me.lblSearch.TabIndex = 15
        Me.lblSearch.Text = "Search"
        '
        'frmHRLevel
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 666)
        Me.Controls.Add(Me.tabFunctions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHRLevel"
        Me.Text = "Level"
        CType(Me.tabFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFunctions.ResumeLayout(False)
        Me.tabInformation.ResumeLayout(False)
        Me.tabInformation.PerformLayout()
        CType(Me.gridControlTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewtable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDLevel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabList.ResumeLayout(False)
        Me.tabList.PerformLayout()
        CType(Me.gridControlTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewtable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents tabFunctions As DevExpress.XtraTab.XtraTabControl
    Public WithEvents tabInformation As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gridControlTable1 As DevExpress.XtraGrid.GridControl
    Public WithEvents gridViewtable1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Public WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtIDLevel As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblIDLevel As DevExpress.XtraEditors.LabelControl
    Public WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gridControlTable2 As DevExpress.XtraGrid.GridControl
    Public WithEvents gridViewtable2 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cboSearch As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblSearch As DevExpress.XtraEditors.LabelControl
End Class
