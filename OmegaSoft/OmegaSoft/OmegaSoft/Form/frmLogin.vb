Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Imports VB = Microsoft.VisualBasic
Public Class frmLogin
#Region " Global Form "
    Private Shared _frmLogin As frmLogin
    Public Shared Property GlobalForm() As frmLogin
        Get
            If _frmLogin Is Nothing OrElse _frmLogin.IsDisposed Then
                _frmLogin = New frmLogin
            End If
            Return _frmLogin
        End Get
        Set(ByVal Value As frmLogin)
            _frmLogin = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _genie As AgentObjects.IAgentCtlCharacter
    Private _intLogin As String = "None"
#End Region
#Region "Methods"
#Region "Config"
    Private Sub _getSkin()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case clsConfig.GetSkinPNA
                Case "Skins1"
                    Me.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Login01.png"))
                    lblUserName.ForeColor = Color.White
                    lblPassword.ForeColor = Color.White
                    txtUserName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
                    txtPassword.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style1
                    chkRemember.ForeColor = Color.White
                    chkRemember.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style1
                    btnLogin.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
                    btnLogin.ForeColor = Color.Black
                    btnExit.Style = OmegaSkins.ButtonPNA.StyleButton.Style1
                    btnExit.ForeColor = Color.Black

                    AxAgent1.Characters.Load("Genie", "Genie.acs")
                    _genie = AxAgent1.Characters("Genie")
                Case "Skins2"
                    Me.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Login02.png"))
                    lblUserName.ForeColor = Color.Blue
                    lblPassword.ForeColor = Color.Blue
                    txtUserName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style2
                    txtPassword.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style2
                    chkRemember.ForeColor = Color.Blue
                    chkRemember.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style2
                    btnLogin.Style = OmegaSkins.ButtonPNA.StyleButton.Style2
                    btnLogin.ForeColor = Color.White
                    btnExit.Style = OmegaSkins.ButtonPNA.StyleButton.Style2
                    btnExit.ForeColor = Color.White

                    AxAgent1.Characters.Load("Peedy", "Peedy.acs")
                    _genie = AxAgent1.Characters("Peedy")
                Case "Skins3"
                    Me.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSoft.Login03.png"))
                    lblUserName.ForeColor = Color.White
                    lblPassword.ForeColor = Color.White
                    txtUserName.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style3
                    txtPassword.Style = OmegaSkins.TextBoxPNA.StyleTextBox.Style3
                    chkRemember.ForeColor = Color.White
                    chkRemember.Style = OmegaSkins1.CheckBoxPNA1.StyleCheckBox.Style3
                    btnLogin.Style = OmegaSkins.ButtonPNA.StyleButton.Style3
                    btnExit.Style = OmegaSkins.ButtonPNA.StyleButton.Style3

                    AxAgent1.Characters.Load("Merlin", "Merlin.acs")
                    _genie = AxAgent1.Characters("Merlin")
            End Select
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._getSkin)", , True)
        End Try
    End Sub
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtPassword.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtUserName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, "Langague\XMLLogin.xml")
            lblUserName.Text = clsConfig.GetLanguage(1, "Langague\XMLLogin.xml")
            lblPassword.Text = clsConfig.GetLanguage(2, "Langague\XMLLogin.xml")
            chkRemember.Text = clsConfig.GetLanguage(3, "Langague\XMLLogin.xml")
            btnLogin.Text = clsConfig.GetLanguage(4, "Langague\XMLLogin.xml")
            btnExit.Text = clsConfig.GetLanguage(5, "Langague\XMLLogin.xml")
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._getLang)", , True)
        End Try
    End Sub
    Private Sub _agentLoad()
        Try
            _genie.Left = Left + Width - Width / 3 + 10
            _genie.Top = Top + Height / 4 + 15
            _genie.Show()
            _genie.Play("Greet")
            _genie.Speak("Hello Welcome to OmegaSoft")
            _genie.Play("gestureRight")
            _intLogin = "None"
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._agentLoad)", , True)
        End Try
    End Sub
    Private Sub _agentOk()
        Try
            If clsHRUser.IsExistUser(txtUserName.Text, clsMethods.Encrypt(txtPassword.Text)) Then
                Dim _clsHRUser As New clsHRUser
                strOUserName = txtUserName.Text.Trim
                _clsHRUser.GetInfor(strOUserName)
                strOIDEmployee = _clsHRUser.IDEmployee
                bolOAdmin = _clsHRUser.Admin
                txtUserName.Enabled = False
                txtPassword.Enabled = False
                chkRemember.Enabled = False
                tmrLogin.Enabled = False
                btnLogin.Enabled = False
                btnExit.Enabled = False
                _genie.StopAll()
                _genie.Show()
                _genie.Play("Congratulate")
                _genie.Speak("Congratulate")
                _genie.Hide()
                _intLogin = "Ok"
                tmrLogin.Enabled = True
                _clsHRUser.DisposedUser() : _clsHRUser = Nothing
            End If
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._agentOk)", , True)
        End Try
    End Sub
    Private Sub _agentExit()
        Try
            txtUserName.Enabled = False
            txtPassword.Enabled = False
            chkRemember.Enabled = False
            tmrLogin.Enabled = False
            btnLogin.Enabled = False
            btnExit.Enabled = False
            _genie.StopAll()
            _genie.Show()
            _genie.Play("Wave")
            _genie.Speak("Bye")
            _genie.Hide()
            _intLogin = "Exit"
            tmrLogin.Enabled = True
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._agentExit)", , True)
        End Try
    End Sub
    Private Sub _loadConfig()
        _getSkin()
        _getFont()
        _getLang()
        _agentLoad()
    End Sub
#End Region
#End Region
#Region "Events"
#Region "KeyDown"
    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then txtPassword.Focus()
        If e.KeyCode = Keys.Up Then btnExit.Focus()
        If e.KeyCode = Keys.Enter And txtUserName.Text <> "" And txtPassword.Text <> "" Then _agentOk()
    End Sub
    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Down Then chkRemember.Focus()
        If e.KeyCode = Keys.Up Then txtUserName.Focus()
        If e.KeyCode = Keys.Enter And txtUserName.Text <> "" And txtPassword.Text <> "" Then _agentOk()
    End Sub
#End Region
#Region "Login"
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GlobalForm = Me
        _loadConfig()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        _agentOk()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        _agentExit()
    End Sub
    Private Sub tmrLogin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLogin.Tick
        Try
            Select Case _intLogin
                Case "Ok"
                    AxAgent1.Dispose() : AxAgent1 = Nothing
                    tmrLogin.Enabled = False
                    tmrAgent.Enabled = False
                    frmMain.GlobalForm.Visible = True
                    Close() : Dispose()
                Case "Exit"
                    Close() : Dispose()
                    Application.Exit()
            End Select
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin.tmrLogin_Tick)", , True)
        End Try
    End Sub
    Private Sub tmrAgent_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAgent.Tick
        Try
            _genie.StopAll()
            _genie.Show()
            _genie.Play("Idle3_1")
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin.tmrAgent_Tick)", , True)
        End Try
    End Sub
#End Region
#End Region
End Class