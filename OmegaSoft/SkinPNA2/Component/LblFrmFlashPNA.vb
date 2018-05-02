Option Explicit On
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class LblFrmFlashPNA
#Region "ClassLblFrmFlashPNA"
#Region "Enum"
    Public Enum StyleButton
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
    Public Enum StateButton
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
#End Region
#Region "Variables"
    Private _img(3) As Bitmap
    Private _style As StyleButton = StyleButton.Style1
    Private _state As StateButton = StateButton.Normal
#End Region
#Region "Methods"
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleButton.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash03.png"))
                Case StyleButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash03.png"))
                Case StyleButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins2.FormFlash03.png"))
            End Select
            Me.AutoSize = False
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Style"
    Private Sub _styleNormal()
        Try
            Image = _img(0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMove()
        Try
            Image = _img(1)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePress()
        Try
            Image = _img(2)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleButton()
        Select Case _state
            Case StateButton.Normal
                _styleNormal()
            Case StateButton.MouseMove
                _styleMouseMove()
            Case StateButton.Press
                _stylePress()
        End Select
    End Sub
#End Region
    Protected Sub PaintButton()
        Try
            _styleButton()
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateButton.Press
                Refresh()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Refresh()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateButton.MouseMove And _state <> StateButton.Press Then
                _state = StateButton.MouseMove
                Refresh()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateButton.Normal Then
                _state = StateButton.Normal
                Refresh()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintButton()
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            'MyBase.OnResize(e)
            Width = 178 : Height = 126
            'Dim gp As New GraphicsPath
            'gp.AddLine(0, 1, 1, 0)
            'gp.AddLine(1, 0, Width - 2, 0)
            'gp.AddLine(Width - 1, 0, Width, 1)
            'gp.AddLine(Width, 1, Width - 1, Height - 2)
            'gp.AddLine(Width, Height - 2, Width - 2, Height)
            'gp.AddLine(0, Height, 1, Height)
            'gp.AddLine(0, Height - 2, 0, Height)
            'gp.AddLine(0, Height - 1, 0, 1)
            'Region = New Region(gp)
            'Invalidate()
        Catch ex As Exception

        End Try
    End Sub
#End Region
End Class
