<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.mnuSystem = New DevExpress.XtraBars.BarSubItem
        Me.mnuTools = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem
        Me.BarSubItem10 = New DevExpress.XtraBars.BarSubItem
        Me.BarSubItem11 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.mnuStorage = New DevExpress.XtraBars.BarSubItem
        Me.mnuItems = New DevExpress.XtraBars.BarSubItem
        Me.mnuTasks = New DevExpress.XtraBars.BarSubItem
        Me.mnuView = New DevExpress.XtraBars.BarSubItem
        Me.mnuReports = New DevExpress.XtraBars.BarSubItem
        Me.mnuGeneral = New DevExpress.XtraBars.BarSubItem
        Me.mnuHelp = New DevExpress.XtraBars.BarSubItem
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.toolbarLanguage = New DevExpress.XtraBars.BarButtonItem
        Me.toolbarRefesh = New DevExpress.XtraBars.BarButtonItem
        Me.toolbarAdd = New DevExpress.XtraBars.BarButtonItem
        Me.toolbarDelete = New DevExpress.XtraBars.BarButtonItem
        Me.toolbarUpdate = New DevExpress.XtraBars.BarButtonItem
        Me.toolbarSave = New DevExpress.XtraBars.BarButtonItem
        Me.toolbarIDAuto = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.toolbarIDCustomize = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CalculatorStylePNA1 = New componentPNA.CalculatorStylePNA
        Me.ClockStylePNA1 = New componentPNA.ClockStylePNA
        Me.CalendarStylePNA1 = New componentPNA.CalendarStylePNA
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.panelBackground = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.DockPanel1.SuspendLayout()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackground.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.ImageList1
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mnuSystem, Me.mnuTools, Me.BarSubItem2, Me.mnuStorage, Me.mnuItems, Me.mnuTasks, Me.mnuView, Me.mnuReports, Me.mnuGeneral, Me.mnuHelp, Me.BarButtonItem1, Me.BarSubItem1, Me.BarSubItem10, Me.BarButtonItem2, Me.BarSubItem11, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.toolbarRefesh, Me.toolbarAdd, Me.toolbarDelete, Me.toolbarUpdate, Me.toolbarSave, Me.toolbarLanguage, Me.toolbarIDAuto, Me.toolbarIDCustomize, Me.BarStaticItem1, Me.BarStaticItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 54
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuSystem), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuTools), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuStorage), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuItems), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuTasks), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuView), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuReports), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuGeneral), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuHelp)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DisableClose = True
        Me.Bar2.OptionsBar.DisableCustomization = True
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'mnuSystem
        '
        Me.mnuSystem.Caption = "&System"
        Me.mnuSystem.Id = 4
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.OwnFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSystem.UseOwnFont = True
        '
        'mnuTools
        '
        Me.mnuTools.Caption = "&Tools"
        Me.mnuTools.Id = 22
        Me.mnuTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6)})
        Me.mnuTools.Name = "mnuTools"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "&Format"
        Me.BarButtonItem1.Id = 31
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Mail"
        Me.BarSubItem1.Id = 32
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarSubItem10
        '
        Me.BarSubItem10.Caption = "Faxes"
        Me.BarSubItem10.Id = 33
        Me.BarSubItem10.Name = "BarSubItem10"
        '
        'BarSubItem11
        '
        Me.BarSubItem11.Caption = "&Chat"
        Me.BarSubItem11.Id = 35
        Me.BarSubItem11.Name = "BarSubItem11"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "&Web"
        Me.BarButtonItem3.Id = 36
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "&Send request"
        Me.BarButtonItem4.Id = 37
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Forum"
        Me.BarButtonItem5.Id = 38
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "System control"
        Me.BarButtonItem6.Id = 39
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'mnuStorage
        '
        Me.mnuStorage.Caption = "&Storage"
        Me.mnuStorage.Id = 24
        Me.mnuStorage.Name = "mnuStorage"
        '
        'mnuItems
        '
        Me.mnuItems.Caption = "&Items"
        Me.mnuItems.Id = 25
        Me.mnuItems.Name = "mnuItems"
        '
        'mnuTasks
        '
        Me.mnuTasks.Caption = "&Process for tasks"
        Me.mnuTasks.Id = 26
        Me.mnuTasks.Name = "mnuTasks"
        '
        'mnuView
        '
        Me.mnuView.Caption = "&View"
        Me.mnuView.Id = 27
        Me.mnuView.Name = "mnuView"
        '
        'mnuReports
        '
        Me.mnuReports.Caption = "&Reports for tasks"
        Me.mnuReports.Id = 28
        Me.mnuReports.Name = "mnuReports"
        '
        'mnuGeneral
        '
        Me.mnuGeneral.Caption = "&General"
        Me.mnuGeneral.Id = 29
        Me.mnuGeneral.Name = "mnuGeneral"
        '
        'mnuHelp
        '
        Me.mnuHelp.Caption = "&Help"
        Me.mnuHelp.Id = 30
        Me.mnuHelp.Name = "mnuHelp"
        '
        'Bar3
        '
        Me.Bar3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bar3.Appearance.Options.UseFont = True
        Me.Bar3.Appearance.Options.UseForeColor = True
        Me.Bar3.Appearance.Options.UseImage = True
        Me.Bar3.Appearance.Options.UseTextOptions = True
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DisableClose = True
        Me.Bar3.OptionsBar.DisableCustomization = True
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.DrawSizeGrip = True
        Me.Bar3.OptionsBar.MultiLine = True
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Main toolbar"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 1
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarLanguage), New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarRefesh), New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarUpdate), New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarSave), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.toolbarIDAuto, "", True, True, True, 20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toolbarIDCustomize), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2)})
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Main toolbar"
        '
        'toolbarLanguage
        '
        Me.toolbarLanguage.Caption = "Language"
        Me.toolbarLanguage.Id = 45
        Me.toolbarLanguage.ImageIndex = 0
        Me.toolbarLanguage.Name = "toolbarLanguage"
        '
        'toolbarRefesh
        '
        Me.toolbarRefesh.Caption = "Refesh"
        Me.toolbarRefesh.Id = 40
        Me.toolbarRefesh.ImageIndex = 2
        Me.toolbarRefesh.Name = "toolbarRefesh"
        '
        'toolbarAdd
        '
        Me.toolbarAdd.Caption = "Add"
        Me.toolbarAdd.Id = 41
        Me.toolbarAdd.ImageIndex = 5
        Me.toolbarAdd.Name = "toolbarAdd"
        '
        'toolbarDelete
        '
        Me.toolbarDelete.Caption = "Delete"
        Me.toolbarDelete.Id = 42
        Me.toolbarDelete.ImageIndex = 6
        Me.toolbarDelete.Name = "toolbarDelete"
        '
        'toolbarUpdate
        '
        Me.toolbarUpdate.Caption = "Update"
        Me.toolbarUpdate.Id = 43
        Me.toolbarUpdate.ImageIndex = 4
        Me.toolbarUpdate.Name = "toolbarUpdate"
        '
        'toolbarSave
        '
        Me.toolbarSave.Caption = "Save"
        Me.toolbarSave.Id = 44
        Me.toolbarSave.ImageIndex = 3
        Me.toolbarSave.Name = "toolbarSave"
        '
        'toolbarIDAuto
        '
        Me.toolbarIDAuto.Caption = "BarEditItem1"
        Me.toolbarIDAuto.Edit = Me.RepositoryItemCheckEdit1
        Me.toolbarIDAuto.Id = 48
        Me.toolbarIDAuto.Name = "toolbarIDAuto"
        Me.toolbarIDAuto.Width = 18
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RepositoryItemCheckEdit1.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.RepositoryItemCheckEdit1.Appearance.BorderColor = System.Drawing.Color.White
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseBackColor = True
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseBorderColor = True
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarStaticItem1.Caption = "IDAuto"
        Me.BarStaticItem1.Id = 50
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'toolbarIDCustomize
        '
        Me.toolbarIDCustomize.Caption = "BarEditItem2"
        Me.toolbarIDCustomize.Edit = Me.RepositoryItemCheckEdit2
        Me.toolbarIDCustomize.Id = 49
        Me.toolbarIDCustomize.Name = "toolbarIDCustomize"
        Me.toolbarIDCustomize.Width = 18
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RepositoryItemCheckEdit2.Appearance.BackColor2 = System.Drawing.Color.Transparent
        Me.RepositoryItemCheckEdit2.Appearance.Options.UseBackColor = True
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.BarStaticItem2.Caption = "IDCustomize"
        Me.BarStaticItem2.Id = 51
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.Controls.Add(Me.DockPanel2)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(773, 52)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(19, 591)
        Me.hideContainerRight.Visible = False
        '
        'DockPanel2
        '
        Me.DockPanel2.BackColor = System.Drawing.Color.White
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("dda7a61a-3bcf-4450-a33f-e699c74ec65d")
        Me.DockPanel2.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.Options.AllowDockBottom = False
        Me.DockPanel2.Options.AllowDockFill = False
        Me.DockPanel2.Options.AllowDockLeft = False
        Me.DockPanel2.Options.AllowDockTop = False
        Me.DockPanel2.Options.AllowFloating = False
        Me.DockPanel2.Options.FloatOnDblClick = False
        Me.DockPanel2.Options.ShowCloseButton = False
        Me.DockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.SavedIndex = 0
        Me.DockPanel2.Size = New System.Drawing.Size(170, 696)
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Panel2)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(164, 668)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.CalculatorStylePNA1)
        Me.Panel2.Controls.Add(Me.ClockStylePNA1)
        Me.Panel2.Controls.Add(Me.CalendarStylePNA1)
        Me.Panel2.Location = New System.Drawing.Point(-5, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 670)
        Me.Panel2.TabIndex = 2
        '
        'CalculatorStylePNA1
        '
        Me.CalculatorStylePNA1.BackgroundImage = CType(resources.GetObject("CalculatorStylePNA1.BackgroundImage"), System.Drawing.Image)
        Me.CalculatorStylePNA1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorStylePNA1.Location = New System.Drawing.Point(8, 290)
        Me.CalculatorStylePNA1.Name = "CalculatorStylePNA1"
        Me.CalculatorStylePNA1.Size = New System.Drawing.Size(157, 175)
        Me.CalculatorStylePNA1.TabIndex = 13
        '
        'ClockStylePNA1
        '
        Me.ClockStylePNA1.BackColor = System.Drawing.Color.Transparent
        Me.ClockStylePNA1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockStylePNA1.Location = New System.Drawing.Point(-2, 11)
        Me.ClockStylePNA1.Name = "ClockStylePNA1"
        Me.ClockStylePNA1.Size = New System.Drawing.Size(170, 132)
        Me.ClockStylePNA1.TabIndex = 0
        '
        'CalendarStylePNA1
        '
        Me.CalendarStylePNA1.BackgroundImage = CType(resources.GetObject("CalendarStylePNA1.BackgroundImage"), System.Drawing.Image)
        Me.CalendarStylePNA1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalendarStylePNA1.Location = New System.Drawing.Point(8, 151)
        Me.CalendarStylePNA1.Name = "CalendarStylePNA1"
        Me.CalendarStylePNA1.Size = New System.Drawing.Size(157, 128)
        Me.CalendarStylePNA1.TabIndex = 1
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("c8799a61-652a-4dea-8ccc-ab92eaf59a6a")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.SavedIndex = 1
        Me.DockPanel1.Size = New System.Drawing.Size(151, 696)
        Me.DockPanel1.Text = "DockPanel1"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(145, 668)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Vietnam.ico")
        Me.ImageList1.Images.SetKeyName(1, "English.ico")
        Me.ImageList1.Images.SetKeyName(2, "Refresh.ico")
        Me.ImageList1.Images.SetKeyName(3, "Save.ico")
        Me.ImageList1.Images.SetKeyName(4, "Update.ico")
        Me.ImageList1.Images.SetKeyName(5, "Add.ico")
        Me.ImageList1.Images.SetKeyName(6, "Delete.ico")
        Me.ImageList1.Images.SetKeyName(7, "Undo.ico")
        Me.ImageList1.Images.SetKeyName(8, "Help.ico")
        Me.ImageList1.Images.SetKeyName(9, "Export.ico")
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "&Utility"
        Me.BarSubItem2.Id = 23
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "System &control "
        Me.BarButtonItem2.Id = 34
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.HeaderButtons = CType((DevExpress.XtraTab.TabButtons.Close Or DevExpress.XtraTab.TabButtons.[Default]), DevExpress.XtraTab.TabButtons)
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'panelBackground
        '
        Me.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelBackground.Controls.Add(Me.PictureBox1)
        Me.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBackground.Location = New System.Drawing.Point(0, 52)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(773, 591)
        Me.panelBackground.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(773, 591)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 666)
        Me.Controls.Add(Me.panelBackground)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "Office 2007 Blue"
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "applicationWINFORM - Email : phamngocanthi@yahoo.com"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.DockPanel1.ResumeLayout(False)
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackground.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Public WithEvents mnuSystem As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuTools As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuStorage As DevExpress.XtraBars.BarSubItem
    Public WithEvents mnuItems As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuTasks As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuView As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuReports As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuGeneral As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuHelp As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem10 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem11 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents ClockStylePNA1 As componentPNA.ClockStylePNA
    Friend WithEvents CalendarStylePNA1 As componentPNA.CalendarStylePNA
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CalculatorStylePNA1 As componentPNA.CalculatorStylePNA
    Public WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents toolbarRefesh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents toolbarAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents toolbarDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents toolbarUpdate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents toolbarSave As DevExpress.XtraBars.BarButtonItem
    Public WithEvents panelBackground As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents toolbarLanguage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents toolbarIDAuto As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents toolbarIDCustomize As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem

End Class
