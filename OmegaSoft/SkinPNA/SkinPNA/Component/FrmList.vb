Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
<ToolboxBitmap(GetType(FrmList), "FrmList.bmp")> _
Public Class FrmList
#Region "ClassFrmList"
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
    <DllImport("user32.dll")> _
    Private Shared Function FindWindowA(ByVal lpClassName As String, ByVal lpWindowName As String) As Long
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function SetParent(ByVal hWndChild As Long, ByVal hWndNewParent As Long) As Long
    End Function

#End Region
#Region "Variables"
    Private _intMouseMove As Boolean
    Private _intX As Integer
    Private _intY As Integer
#End Region
#Region "Properties"
    Public Property VisibleToolBar() As Boolean
        Get
            Return tbrHRCountry.Visible
        End Get
        Set(ByVal value As Boolean)
            tbrHRCountry.Visible = value
        End Set
    End Property
#End Region
#Region "Methods"
    Private Function _isInnerXY() As Boolean
        Try
            Dim winRect As New RECT, winPoint As New Point
            GetWindowRect(picTopMain.Handle, winRect)
            GetCursorPos(winPoint)
            If _intMouseMove Then
                Me.ParentForm.Location = New Point(winPoint.X - _intX, winPoint.Y - _intY)
            Else

                If (winPoint.X >= winRect.Left) And (winPoint.X <= winRect.Right) And (winPoint.Y >= winRect.Top) And (winPoint.Y <= winRect.Top + 23) Then
                    _intX = winPoint.X - winRect.Left
                    _intY = winPoint.Y - winRect.Top
                    Return True
                End If
                Return False
            End If
            Return True
        Catch ex As Exception

        End Try
    End Function
    Private Sub _getResBitmapForm1(ByVal bolActivated As Boolean)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            If bolActivated Then
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Caption01.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form01.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form02.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form03.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form04.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form05.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form06.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form07.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form08.png"))
            Else
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Caption02.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form09.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form10.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form11.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form12.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form13.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form14.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form15.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form16.png"))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _getResBitmapForm2(ByVal bolActivated As Boolean)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            If bolActivated Then
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Caption03.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form17.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form18.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form19.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form20.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form21.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form22.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form23.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form24.png"))
            Else
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Caption04.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form25.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form26.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form27.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form28.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form29.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form30.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form31.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form32.png"))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _getResBitmapForm3(ByVal bolActivated As Boolean)
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            If bolActivated Then
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Caption05.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form33.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form34.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form35.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form36.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form37.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form38.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form39.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form40.png"))
            Else
                lblCaption.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Caption06.png"))
                Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form41.png"))
                Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form42.png"))
                Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form43.png"))
                Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form44.png"))
                Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form45.png"))
                Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form46.png"))
                Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form47.png"))
                Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Form48.png"))
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _getResBitmap(ByVal bolActivated As Boolean)
        Try
            Dim strSkin As String = "Skins1"
            Select Case strSkin
                Case "Skins1"
                    _getResBitmapForm1(bolActivated)
                Case "Skins2"
                    _getResBitmapForm2(bolActivated)
                Case "Skins3"
                    _getResBitmapForm3(bolActivated)
            End Select
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
#Region "picBorder"
#Region "lblCaption"
    Private Sub lblCaption_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                _intMouseMove = True
            Else
                _intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblCaption_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXY()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub lblCaption_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblCaption.MouseUp
        _intMouseMove = False
    End Sub
#End Region
#Region "picTopMain"
    Private Sub picTopMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseDown
        Try
            If _isInnerXY() And e.Button = Windows.Forms.MouseButtons.Left Then
                _intMouseMove = True
            Else
                _intMouseMove = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub picTopMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseMove
        Try
            If _intMouseMove Then
                _isInnerXY()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub picTopMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTopMain.MouseUp
        _intMouseMove = False
    End Sub
#End Region
#End Region
#End Region
#Region "Form"
    Private Sub FrmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        'Dim strPath As String, strLang As String = ""
        'Dim dsLang As New DataSet
        'strPath = Application.StartupPath & "\Files\XMLConfigs.xml"
        'dsLang.ReadXml(strPath, XmlReadMode.Auto)
        'strLang = dsLang.Tables(0).Rows(0).Item("Type")
        'dsLang.Dispose() : dsLang = Nothing
        'dsLang = New DataSet
        'dsLang.ReadXml(AppAssembly.GetManifestResourceStream("OmegaSkins.XMLButton.xml"))
        'Select Case strLang
        '    Case "VietNamese"
        '        btnFormClose.BToolTip = dsLang.Tables(0).Rows(0).Item(1)
        '    Case "English"
        '        btnFormClose.BToolTip = dsLang.Tables(0).Rows(0).Item(2)
        'End Select
        'dsLang.Dispose() : dsLang = Nothing
        _getResBitmap(True)
        Left = 0 : Top = 0
        Width = Me.ParentForm.Width : Height = Me.ParentForm.Height
    End Sub
    Private Sub FrmList_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        Try
            Left = 0 : Top = 0
            Width = Me.ParentForm.Width : Height = Me.ParentForm.Height
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FrmList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            Left = 0 : Top = 0
            Width = Me.ParentForm.Width : Height = Me.ParentForm.Height
        Catch ex As Exception

        End Try
    End Sub
#End Region
#End Region
End Class
