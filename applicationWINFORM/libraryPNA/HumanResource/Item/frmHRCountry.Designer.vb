<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHRCountry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHRCountry))
        Me.tabFunctions = New DevExpress.XtraTab.XtraTabControl
        Me.tabInformation = New DevExpress.XtraTab.XtraTabPage
        Me.gridControlTable1 = New DevExpress.XtraGrid.GridControl
        Me.gridViewtable1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnSavePicture = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit
        Me.btnDeletePicture = New DevExpress.XtraEditors.SimpleButton
        Me.btnSelectPicture = New DevExpress.XtraEditors.SimpleButton
        Me.txtCountryCode = New DevExpress.XtraEditors.TextEdit
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.txtIDCountry = New DevExpress.XtraEditors.TextEdit
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl
        Me.lblCountryCode = New DevExpress.XtraEditors.LabelControl
        Me.lblName = New DevExpress.XtraEditors.LabelControl
        Me.lblIDCountry = New DevExpress.XtraEditors.LabelControl
        Me.picPicture = New DevExpress.XtraEditors.PictureEdit
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
        CType(Me.txtCountryCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIDCountry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabInformation.Controls.Add(Me.btnSavePicture)
        Me.tabInformation.Controls.Add(Me.txtDescription)
        Me.tabInformation.Controls.Add(Me.btnDeletePicture)
        Me.tabInformation.Controls.Add(Me.btnSelectPicture)
        Me.tabInformation.Controls.Add(Me.txtCountryCode)
        Me.tabInformation.Controls.Add(Me.txtName)
        Me.tabInformation.Controls.Add(Me.txtIDCountry)
        Me.tabInformation.Controls.Add(Me.lblDescription)
        Me.tabInformation.Controls.Add(Me.lblCountryCode)
        Me.tabInformation.Controls.Add(Me.lblName)
        Me.tabInformation.Controls.Add(Me.lblIDCountry)
        Me.tabInformation.Controls.Add(Me.picPicture)
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
        Me.gridControlTable1.Location = New System.Drawing.Point(20, 264)
        Me.gridControlTable1.MainView = Me.gridViewtable1
        Me.gridControlTable1.Name = "gridControlTable1"
        Me.gridControlTable1.Size = New System.Drawing.Size(743, 366)
        Me.gridControlTable1.TabIndex = 12
        Me.gridControlTable1.UseEmbeddedNavigator = True
        Me.gridControlTable1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewtable1})
        '
        'gridViewtable1
        '
        Me.gridViewtable1.GridControl = Me.gridControlTable1
        Me.gridViewtable1.Name = "gridViewtable1"
        Me.gridViewtable1.OptionsSelection.MultiSelect = True
        Me.gridViewtable1.OptionsView.ShowDetailButtons = False
        Me.gridViewtable1.OptionsView.ShowGroupPanel = False
        Me.gridViewtable1.PaintStyleName = "Skin"
        '
        'btnSavePicture
        '
        Me.btnSavePicture.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePicture.Appearance.Options.UseFont = True
        Me.btnSavePicture.Location = New System.Drawing.Point(205, 233)
        Me.btnSavePicture.Name = "btnSavePicture"
        Me.btnSavePicture.Size = New System.Drawing.Size(100, 25)
        Me.btnSavePicture.TabIndex = 11
        Me.btnSavePicture.Text = "Save picture"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.EditValue = ""
        Me.txtDescription.Location = New System.Drawing.Point(115, 92)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(648, 77)
        Me.txtDescription.TabIndex = 6
        '
        'btnDeletePicture
        '
        Me.btnDeletePicture.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePicture.Appearance.Options.UseFont = True
        Me.btnDeletePicture.Location = New System.Drawing.Point(205, 203)
        Me.btnDeletePicture.Name = "btnDeletePicture"
        Me.btnDeletePicture.Size = New System.Drawing.Size(100, 25)
        Me.btnDeletePicture.TabIndex = 9
        Me.btnDeletePicture.Text = "Delete picture"
        '
        'btnSelectPicture
        '
        Me.btnSelectPicture.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectPicture.Appearance.Options.UseFont = True
        Me.btnSelectPicture.Location = New System.Drawing.Point(205, 172)
        Me.btnSelectPicture.Name = "btnSelectPicture"
        Me.btnSelectPicture.Size = New System.Drawing.Size(100, 25)
        Me.btnSelectPicture.TabIndex = 8
        Me.btnSelectPicture.Text = "Select picture"
        '
        'txtCountryCode
        '
        Me.txtCountryCode.EditValue = ""
        Me.txtCountryCode.Location = New System.Drawing.Point(115, 68)
        Me.txtCountryCode.Name = "txtCountryCode"
        Me.txtCountryCode.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtCountryCode.Properties.Appearance.Options.UseFont = True
        Me.txtCountryCode.Properties.MaxLength = 20
        Me.txtCountryCode.Size = New System.Drawing.Size(125, 21)
        Me.txtCountryCode.TabIndex = 5
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
        'txtIDCountry
        '
        Me.txtIDCountry.EditValue = ""
        Me.txtIDCountry.Location = New System.Drawing.Point(115, 20)
        Me.txtIDCountry.Name = "txtIDCountry"
        Me.txtIDCountry.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtIDCountry.Properties.Appearance.Options.UseFont = True
        Me.txtIDCountry.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDCountry.Properties.MaxLength = 15
        Me.txtIDCountry.Size = New System.Drawing.Size(125, 21)
        Me.txtIDCountry.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDescription.Appearance.Options.UseFont = True
        Me.lblDescription.Location = New System.Drawing.Point(20, 95)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 15)
        Me.lblDescription.TabIndex = 4
        Me.lblDescription.Text = "Description"
        '
        'lblCountryCode
        '
        Me.lblCountryCode.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblCountryCode.Appearance.Options.UseFont = True
        Me.lblCountryCode.Location = New System.Drawing.Point(20, 71)
        Me.lblCountryCode.Name = "lblCountryCode"
        Me.lblCountryCode.Size = New System.Drawing.Size(72, 15)
        Me.lblCountryCode.TabIndex = 3
        Me.lblCountryCode.Text = "Country code"
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
        'lblIDCountry
        '
        Me.lblIDCountry.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblIDCountry.Appearance.Options.UseFont = True
        Me.lblIDCountry.Location = New System.Drawing.Point(20, 23)
        Me.lblIDCountry.Name = "lblIDCountry"
        Me.lblIDCountry.Size = New System.Drawing.Size(54, 15)
        Me.lblIDCountry.TabIndex = 1
        Me.lblIDCountry.Text = "IDCountry"
        '
        'picPicture
        '
        Me.picPicture.Location = New System.Drawing.Point(115, 172)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picPicture.Properties.Appearance.Options.UseFont = True
        Me.picPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.picPicture.Size = New System.Drawing.Size(86, 86)
        Me.picPicture.TabIndex = 7
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
        'frmHRCountry
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 666)
        Me.Controls.Add(Me.tabFunctions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Money Twins"
        Me.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.Name = "frmHRCountry"
        Me.Text = "Country"
        CType(Me.tabFunctions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFunctions.ResumeLayout(False)
        Me.tabInformation.ResumeLayout(False)
        Me.tabInformation.PerformLayout()
        CType(Me.gridControlTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewtable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCountryCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIDCountry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public WithEvents btnSavePicture As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Public WithEvents btnDeletePicture As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSelectPicture As DevExpress.XtraEditors.SimpleButton
    Public WithEvents txtCountryCode As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Public WithEvents txtIDCountry As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblCountryCode As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Public WithEvents lblIDCountry As DevExpress.XtraEditors.LabelControl
    Public WithEvents picPicture As DevExpress.XtraEditors.PictureEdit
    Public WithEvents tabList As DevExpress.XtraTab.XtraTabPage
    Public WithEvents gridControlTable2 As DevExpress.XtraGrid.GridControl
    Public WithEvents gridViewtable2 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Public WithEvents cboSearch As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Public WithEvents lblSearch As DevExpress.XtraEditors.LabelControl
End Class
