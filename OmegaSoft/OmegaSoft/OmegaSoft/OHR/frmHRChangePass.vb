Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Imports VB = Microsoft.VisualBasic
Public Class frmHRChangePass
#Region " Global Form "
    Private Shared _frmHRChangePass As frmHRChangePass
    Public Shared Property GlobalForm() As frmHRChangePass
        Get
            If _frmHRChangePass Is Nothing OrElse _frmHRChangePass.IsDisposed Then
                _frmHRChangePass = New frmHRChangePass
            End If
            Return _frmHRChangePass
        End Get
        Set(ByVal Value As frmHRChangePass)
            _frmHRChangePass = Value
        End Set
    End Property
#End Region
#Region "Variables"
    Private _strLang As String = "Langague\OHR\XMLHRChangePass.xml"
    Dim _clsHRUser As clsHRUser
#End Region
#Region "Config"
    Private Sub _getFont()
        Try
            Dim strFont As String
            strFont = clsConfig.GetFontPNA
            txtUserName.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtPassword.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            txtConfirm.Font = New System.Drawing.Font(strFont, 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRChangePass._getFont)", , True)
        End Try
    End Sub
    Private Sub _getLang()
        Try
            Me.Text = clsConfig.GetLanguage(0, _strLang)
            lblUserName.Text = clsConfig.GetLanguage(1, _strLang)
            lblPassword.Text = clsConfig.GetLanguage(2, _strLang)
            lblConfirm.Text = clsConfig.GetLanguage(3, _strLang)
            btnYes.Text = clsConfig.GetLanguage(4, _strLang)
            btnExit.Text = clsConfig.GetLanguage(5, _strLang)
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmLogin._getLang)", , True)
        End Try
    End Sub
    Private Sub _loadConfig()
        _getFont()
        _getLang()
    End Sub
#End Region
#Region "Others"
    Private Sub _setUser()
        Try
            _clsHRUser.IDEmployee = strOIDEmployee
            _clsHRUser.UName = strOUserName
            _clsHRUser.UPass = clsMethods.Encrypt(txtPassword.Text.Trim)
            _clsHRUser.Admin = bolOAdmin
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRChangePass._setUser)", "frmHRChangePass._setUser", True)
        End Try
    End Sub
#End Region
#Region "Process"
    Private Sub _save()
        Try
            If txtPassword.Text.Trim = "" Then
                ShowInfor(Nothing, clsConfig.GetLanguage(6, _strLang), , InforButton.Ok)
                txtPassword.Focus()
                Exit Sub
            End If
            If txtConfirm.Text.Trim <> txtPassword.Text.Trim Then
                ShowInfor(Nothing, clsConfig.GetLanguage(7, _strLang), , InforButton.Ok)
                txtConfirm.Focus()
                Exit Sub
            End If
            If _clsHRUser Is Nothing Then _clsHRUser = New clsHRUser
            _setUser()
            _clsHRUser.Update()
            _clsHRUser.DisposedUser() : _clsHRUser = Nothing
        Catch ex As Exception
            ShowInfor(Me, "", ex.Message.ToString & "(frmHRChangePass._save)", "frmHRChangePass._save", True)
        End Try
    End Sub
#End Region
    Private Sub frmHRChangePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GlobalForm = Me
        _loadConfig()
        txtUserName.Text = strOUserName
    End Sub
    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        _save()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close() : Dispose()
    End Sub
End Class