<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.lblNewEmployee = New DevComponents.DotNetBar.LabelX
        Me.lblMyID = New DevExpress.XtraEditors.LabelControl
        Me.lblPassword = New DevExpress.XtraEditors.LabelControl
        Me.btnSignIn = New DevExpress.XtraEditors.SimpleButton
        Me.btnExit = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit
        Me.chkID = New DevExpress.XtraEditors.CheckEdit
        Me.chkMyIDPassword = New DevExpress.XtraEditors.CheckEdit
        Me.hideContainerTop = New DevExpress.XtraBars.Docking.AutoHideContainer
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMyIDPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerTop})
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DockPanel1.Appearance.Options.UseFont = True
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DockPanel1.ID = New System.Guid("9910893f-9e69-4c4b-8993-346da52a3e42")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowDockBottom = False
        Me.DockPanel1.Options.AllowDockFill = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Top
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(419, 48)
        Me.DockPanel1.TabsPosition = DevExpress.XtraBars.Docking.TabsPosition.Top
        Me.DockPanel1.TabsScroll = True
        Me.DockPanel1.Text = "Information for My ID"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.lblNewEmployee)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(413, 20)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'lblNewEmployee
        '
        Me.lblNewEmployee.AutoSize = True
        Me.lblNewEmployee.Location = New System.Drawing.Point(52, 2)
        Me.lblNewEmployee.Name = "lblNewEmployee"
        Me.lblNewEmployee.Size = New System.Drawing.Size(291, 16)
        Me.lblNewEmployee.TabIndex = 0
        Me.lblNewEmployee.Text = "New empployee -> My &ID : view , &Password : view "
        '
        'lblMyID
        '
        Me.lblMyID.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyID.Appearance.Options.UseFont = True
        Me.lblMyID.Location = New System.Drawing.Point(45, 52)
        Me.lblMyID.Name = "lblMyID"
        Me.lblMyID.Size = New System.Drawing.Size(34, 16)
        Me.lblMyID.TabIndex = 2
        Me.lblMyID.Text = "My &ID"
        '
        'lblPassword
        '
        Me.lblPassword.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Appearance.Options.UseFont = True
        Me.lblPassword.Location = New System.Drawing.Point(45, 74)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 16)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "&Password"
        '
        'btnSignIn
        '
        Me.btnSignIn.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.Appearance.Options.UseFont = True
        Me.btnSignIn.Location = New System.Drawing.Point(131, 143)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(90, 26)
        Me.btnSignIn.TabIndex = 5
        Me.btnSignIn.Text = "&Sign in"
        '
        'btnExit
        '
        Me.btnExit.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Appearance.Options.UseFont = True
        Me.btnExit.Location = New System.Drawing.Point(224, 143)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 26)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(131, 49)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Size = New System.Drawing.Size(238, 22)
        Me.TextEdit1.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(131, 74)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Size = New System.Drawing.Size(238, 22)
        Me.txtPassword.TabIndex = 8
        '
        'chkID
        '
        Me.chkID.Location = New System.Drawing.Point(129, 98)
        Me.chkID.Name = "chkID"
        Me.chkID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkID.Properties.Appearance.Options.UseFont = True
        Me.chkID.Properties.Caption = "Remember my ID"
        Me.chkID.Size = New System.Drawing.Size(240, 21)
        Me.chkID.TabIndex = 4
        '
        'chkMyIDPassword
        '
        Me.chkMyIDPassword.Location = New System.Drawing.Point(129, 119)
        Me.chkMyIDPassword.Name = "chkMyIDPassword"
        Me.chkMyIDPassword.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMyIDPassword.Properties.Appearance.Options.UseFont = True
        Me.chkMyIDPassword.Properties.Caption = "Remember my ID && password"
        Me.chkMyIDPassword.Size = New System.Drawing.Size(240, 21)
        Me.chkMyIDPassword.TabIndex = 9
        '
        'hideContainerTop
        '
        Me.hideContainerTop.Controls.Add(Me.DockPanel1)
        Me.hideContainerTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.hideContainerTop.Location = New System.Drawing.Point(0, 0)
        Me.hideContainerTop.Name = "hideContainerTop"
        Me.hideContainerTop.Size = New System.Drawing.Size(419, 19)
        '
        'frmLogin
        '
        Me.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(419, 175)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.chkMyIDPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.chkID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblMyID)
        Me.Controls.Add(Me.hideContainerTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMyIDPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerTop.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lblNewEmployee As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSignIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMyID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMyIDPassword As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkID As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents hideContainerTop As DevExpress.XtraBars.Docking.AutoHideContainer
End Class
