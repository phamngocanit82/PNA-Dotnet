Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports OmegaSkins1
Public Class frmInfor
#Region "Struct"
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32")> _
     Public Shared Function GetCursorPos(ByRef lpPoint As Point) As Integer
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
#End Region
#Region "Variables"
    Private intMouseMove As Boolean
    Private _intWidth As Integer
    Private _intHeight As Integer
    '
    Private _intInforButton As clsMethods.InforButton
    Private _img As Bitmap
#End Region
#Region "Properties"
    Public ReadOnly Property GetInforButton() As clsMethods.InforButton
        Get
            Return _intInforButton
        End Get
    End Property
#End Region
#Region "Methods"
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(lblInfor.Handle, winRect)
            GetCursorPos(winPoint)
            If intMouseMove Then
                Location = New Point(winPoint.X - _intWidth, winPoint.Y - _intHeight)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intWidth = winPoint.X - winRect.Left
                    _intHeight = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception

        End Try
    End Function
    Public Sub CloseForm()
        Try
            'Visible = False
            Close()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case clsConfig.GetSkinPNA
                Case "Skins1"
                    _img = New Bitmap(AppAssembly.GetManifestResourceStream("clsOmegaSoft.Infor01.png"))
                    btnOk.Style = ButtonPNA1.StyleButton.Style1
                    btnYes.Style = ButtonPNA1.StyleButton.Style1
                    btnNo.Style = ButtonPNA1.StyleButton.Style1
                Case "Skins2"
                    _img = New Bitmap(AppAssembly.GetManifestResourceStream("clsOmegaSoft.Infor02.png"))
                    btnOk.Style = ButtonPNA1.StyleButton.Style2
                    btnYes.Style = ButtonPNA1.StyleButton.Style2
                    btnNo.Style = ButtonPNA1.StyleButton.Style2
                Case "Skins3"
                    _img = New Bitmap(AppAssembly.GetManifestResourceStream("clsOmegaSoft.Infor03.png"))
                    btnOk.Style = ButtonPNA1.StyleButton.Style3
                    btnYes.Style = ButtonPNA1.StyleButton.Style3
                    btnNo.Style = ButtonPNA1.StyleButton.Style3
            End Select
            Me.BackgroundImage = _img
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
#Region "LabelInfor"
    Private Sub FrmInfor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _getResBitmap()
        intMouseMove = False
        _intInforButton = clsMethods.InforButton.No
    End Sub
    Private Sub lblInfor_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblInfor.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                intMouseMove = True
            Else
                intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblInfor_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblInfor.MouseMove
        If intMouseMove Then
            _isInnerXY()
        End If
    End Sub
    Private Sub lblInfor_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblInfor.MouseUp
        intMouseMove = False
    End Sub
#End Region
#Region "Others"
    Private Sub btnOk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnOk.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Visible = False
            _intInforButton = clsMethods.InforButton.Ok
        End If
    End Sub
    Private Sub btnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Visible = False
        _intInforButton = clsMethods.InforButton.Ok
    End Sub
    Private Sub btnYes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnYes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Visible = False
            _intInforButton = clsMethods.InforButton.Yes
        End If
    End Sub
    Private Sub btnYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnYes.Click
        Me.Visible = False
        _intInforButton = clsMethods.InforButton.Yes
    End Sub
    Private Sub btnNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Visible = False
            _intInforButton = clsMethods.InforButton.No
        End If
    End Sub
    Private Sub btnNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNo.Click
        Me.Visible = False
        _intInforButton = clsMethods.InforButton.No
    End Sub
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Visible = False
        _intInforButton = clsMethods.InforButton.No
    End Sub
#End Region
#End Region
End Class