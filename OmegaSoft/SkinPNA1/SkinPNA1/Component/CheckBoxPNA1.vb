Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
<ToolboxBitmap(GetType(CheckBoxPNA1), "CheckBoxPNA1.bmp")> _
Public Class CheckBoxPNA1
#Region "ClassCheckBoxPNA1"
#Region "Enum"
    Private Enum StateCheckBox
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
    Public Enum StyleCheckBox
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _img(8) As Bitmap
    Private _state As StateCheckBox = StateCheckBox.Normal
    Private _style As StyleCheckBox = StyleCheckBox.Style1
#End Region
#Region "Properties"
    Public Property Style() As StyleCheckBox
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleCheckBox)
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
                Case StyleCheckBox.Style1
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox01.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox02.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox03.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox04.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox05.png"))
                    _img(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox06.png"))
                    _img(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox07.png"))
                    _img(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox08.png"))
                Case StyleCheckBox.Style2
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox09.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox10.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox11.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox12.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox13.png"))
                    _img(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox14.png"))
                    _img(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox15.png"))
                    _img(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox16.png"))
                Case StyleCheckBox.Style3
                    _img(0) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox17.png"))
                    _img(1) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox18.png"))
                    _img(2) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox19.png"))
                    _img(3) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox20.png"))
                    _img(4) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox21.png"))
                    _img(5) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox22.png"))
                    _img(6) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox23.png"))
                    _img(7) = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins1.CheckBox24.png"))
            End Select
        Catch ex As Exception

        End Try
    End Sub
#Region "Style"
    Private Sub _styleNormal(ByVal g As Graphics)
        Try
            g.DrawImage(_img(0), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMove(ByVal g As Graphics)
        Try
            g.DrawImage(_img(1), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePress(ByVal g As Graphics)
        Try
            g.DrawImage(_img(2), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleDisable(ByVal g As Graphics)
        Try
            g.DrawImage(_img(6), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleNormalCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(3), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleMouseMoveCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(4), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _stylePressCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(5), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleDisableCheck(ByVal g As Graphics)
        Try
            g.DrawImage(_img(7), 0, CInt(Height / 2) - 8, 13, 13)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub _styleCheckBox(ByVal g As Graphics)
        Try
            If Enabled Then
                Select Case _state
                    Case StateCheckBox.Normal
                        If Checked Then
                            _styleNormalCheck(g)
                        Else
                            _styleNormal(g)
                        End If
                    Case StateCheckBox.MouseMove
                        If Checked Then
                            _styleMouseMoveCheck(g)
                        Else
                            _styleMouseMove(g)
                        End If
                    Case StateCheckBox.Press
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
    Protected Sub PaintCheckBox(ByVal g As Graphics)
        Try
            _styleCheckBox(g)
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Events"
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateCheckBox.Press And e.KeyCode = Keys.Space Then
                _state = StateCheckBox.Press
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _state <> StateCheckBox.Normal Then
                _state = StateCheckBox.Normal
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateCheckBox.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _state = StateCheckBox.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateCheckBox.Normal Then
                _state = StateCheckBox.Normal
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _state <> StateCheckBox.MouseMove And _state <> StateCheckBox.Press Then
                _state = StateCheckBox.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _state <> StateCheckBox.Normal Then
                _state = StateCheckBox.Normal
                Invalidate()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception

        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        PaintCheckBox(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Invalidate()
    End Sub
#End Region
#End Region
End Class
