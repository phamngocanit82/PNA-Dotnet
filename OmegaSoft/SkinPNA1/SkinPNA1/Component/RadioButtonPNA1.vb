Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(RadioButtonPNA1), "RadioButtonPNA1.bmp")> _
Public Class RadioButtonPNA1
#Region "ClassRadioButtonPNA1"
#Region "Enum"
    Private Enum StateRadioButton
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
    Public Enum StyleRadioButton
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _img(8) As Bitmap
    Private _state As StateRadioButton = StateRadioButton.Normal
    Private _style As StyleRadioButton = StyleRadioButton.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleRadioButton
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleRadioButton)
            _style = Value
            _getResBitmap()
            Invalidate()
        End Set
    End Property
#End Region
#Region "Methods"
    Private Sub _getResBitmap()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case _style
                Case StyleRadioButton.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton03.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton04.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton05.png"))
                    _img(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton06.png"))
                    _img(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton07.png"))
                    _img(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton08.png"))
                Case StyleRadioButton.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton09.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton10.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton11.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton12.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton13.png"))
                    _img(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton14.png"))
                    _img(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton15.png"))
                    _img(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton16.png"))
                Case StyleRadioButton.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton17.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton18.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton19.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton20.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton21.png"))
                    _img(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton22.png"))
                    _img(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton23.png"))
                    _img(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.RadioButton24.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
    Private Sub _styleNormal(ByVal g As Graphics)
        Try
            g.DrawImage(_img(0), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_img(1), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePress(ByVal g As Graphics)
        Try
            g.DrawImage(_img(2), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleDisable(ByVal g As Graphics)
        Try
            g.DrawImage(_img(6), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleNormalCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(3), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMoveCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(4), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePressCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(5), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleDisableCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(7), 0, CInt(Height / 2) - 7, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleRadioButton(ByVal g As Graphics)
        Try
            If Enabled Then
                Select Case _state
                    Case StateRadioButton.Normal
                        If Checked Then
                            _styleNormalCheck(g)
                        Else
                            _styleNormal(g)
                        End If
                    Case StateRadioButton.MouseMove
                        If Checked Then
                            _styleMouseMoveCheck(g)
                        Else
                            _styleMouseMove(g)
                        End If
                    Case StateRadioButton.Press
                        If Checked Then
                            _stylePressCheck(g)
                        Else
                            _stylePress(g)
                        End If
                End Select
            Else
                If Checked Then
                    _styleDisableCheck(g)
                Else
                    _styleDisable(g)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Protected Sub PaintRadioButton(ByVal g As Graphics)
        Try
            _styleRadioButton(g)
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateRadioButton.Press And e.KeyCode = Keys.Space Then
                _state = StateRadioButton.Press
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateRadioButton.Normal Then
                _state = StateRadioButton.Normal
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateRadioButton.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateRadioButton.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateRadioButton.Normal Then
                _state = StateRadioButton.Normal
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateRadioButton.MouseMove And _state <> StateRadioButton.Press Then
                _state = StateRadioButton.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateRadioButton.Normal Then
                _state = StateRadioButton.Normal
                Invalidate()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintRadioButton(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub
#End Region
#End Region
End Class
