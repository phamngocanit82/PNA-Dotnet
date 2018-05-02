Imports System
Imports System.Drawing
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
<ToolboxBitmap(GetType(ButtonStylePNA), ".ico"), Designer(GetType(DesignerButtonStylePNA)), Description("ButtonStylePNA")> _
Public Class ButtonStylePNA
    Public Enum EnumState
        Normal = 0
        MouseMove = 1
        Press = 2
    End Enum
    Public Enum EnumSkin
        Skins1 = 0
        Skins2 = 1
        Skins3 = 2
        Customer = 3
        Picture = 4
    End Enum
    Public Enum EnumType
        AExit = 0
        AExitBack = 1
        AClose = 2
        AMenu = 3
        ANext = 4
        APrevious = 5
    End Enum
    Private _State As EnumState = EnumState.Normal
    Private _Skin As EnumSkin = EnumSkin.Skins1
    Private _Type As EnumType = EnumType.AClose
    Private _bolFocus As Boolean = False
    Private _intIndex As Integer
#Region "Properties"
    Public Property Skin() As EnumSkin
        Get
            Return _Skin
        End Get
        Set(ByVal Value As EnumSkin)
            _Skin = Value
            Invalidate()
        End Set
    End Property
    Public Property Type() As EnumType
        Get
            Return _Type
        End Get
        Set(ByVal Value As EnumType)
            _Type = Value
            Invalidate()
        End Set
    End Property
    Public Property ToolTip() As String
        Get
            Return ToolTip1.GetToolTip(Me)
        End Get
        Set(ByVal Value As String)
            ToolTip1.RemoveAll()
            ToolTip1.SetToolTip(Me, Value)
        End Set
    End Property
    Public Property ToolTipTitle() As String
        Get
            Return ToolTip1.ToolTipTitle
        End Get
        Set(ByVal Value As String)
            ToolTip1.ToolTipTitle = Value
        End Set
    End Property
    Public Property ToolTipIcon() As ToolTipIcon
        Get
            Return ToolTip1.ToolTipIcon
        End Get
        Set(ByVal Value As ToolTipIcon)
            ToolTip1.ToolTipIcon = Value
        End Set
    End Property
    Public Property [Index]() As Integer
        Get
            Return _intIndex
        End Get
        Set(ByVal Value As Integer)
            _intIndex = Value
        End Set
    End Property
#End Region
#Region "ContainFormChild"
#Region "AExit"
    Private Sub Skin1_AExit(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 11 : Height = 9
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin2_AExit(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 11 : Height = 9
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin3_AExit(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 11 : Height = 9
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExit3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Customer_AExit(ByVal g As Graphics)

    End Sub
    Private Sub Picturer_AExit(ByVal g As Graphics)

    End Sub
    Private Sub Skin_AExit(ByVal g As Graphics)
        Select Case _Skin
            Case EnumSkin.Skins1
                Skin1_AExit(g)
            Case EnumSkin.Skins2
                Skin2_AExit(g)
            Case EnumSkin.Skins3
                Skin3_AExit(g)
            Case EnumSkin.Customer
                Customer_AExit(g)
            Case EnumSkin.Picture
                Picturer_AExit(g)
        End Select
    End Sub
#End Region
#Region "AExitBack"
    Private Sub Skin1_AExitBack(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 11 : Height = 9
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin2_AExitBack(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 11 : Height = 9
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitback2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin3_AExitBack(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 11 : Height = 9
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AExitBack3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Customer_AExitBack(ByVal g As Graphics)

    End Sub
    Private Sub Picturer_AExitBack(ByVal g As Graphics)

    End Sub
    Private Sub Skin_AExitBack(ByVal g As Graphics)
        Select Case _Skin
            Case EnumSkin.Skins1
                Skin1_AExitBack(g)
            Case EnumSkin.Skins2
                Skin2_AExitBack(g)
            Case EnumSkin.Skins3
                Skin3_AExitBack(g)
            Case EnumSkin.Customer
                Customer_AExitBack(g)
            Case EnumSkin.Picture
                Picturer_AExitBack(g)
        End Select
    End Sub
#End Region
#Region "AClose"
    Private Sub Skin1_AClose(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin2_AClose(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin3_AClose(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AClose3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Customer_AClose(ByVal g As Graphics)

    End Sub
    Private Sub Picturer_AClose(ByVal g As Graphics)

    End Sub
    Private Sub Skin_AClose(ByVal g As Graphics)
        Select Case _Skin
            Case EnumSkin.Skins1
                Skin1_AClose(g)
            Case EnumSkin.Skins2
                Skin2_AClose(g)
            Case EnumSkin.Skins3
                Skin3_AClose(g)
            Case EnumSkin.Customer
                Customer_AClose(g)
            Case EnumSkin.Picture
                Picturer_AClose(g)
        End Select
    End Sub
#End Region
#Region "AMenu"
    Private Sub Skin1_AMenu(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 25 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin2_AMenu(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 25 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin3_AMenu(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 25 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.AMenu3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Customer_AMenu(ByVal g As Graphics)

    End Sub
    Private Sub Picturer_AMenu(ByVal g As Graphics)

    End Sub
    Private Sub Skin_AMenu(ByVal g As Graphics)
        Select Case _Skin
            Case EnumSkin.Skins1
                Skin1_AMenu(g)
            Case EnumSkin.Skins2
                Skin2_AMenu(g)
            Case EnumSkin.Skins3
                Skin3_AMenu(g)
            Case EnumSkin.Customer
                Customer_AMenu(g)
            Case EnumSkin.Picture
                Picturer_AMenu(g)
        End Select
    End Sub
#End Region
#Region "ANext"
    Private Sub Skin1_ANext(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin2_ANext(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin3_ANext(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.ANext3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Customer_ANext(ByVal g As Graphics)

    End Sub
    Private Sub Picturer_ANext(ByVal g As Graphics)

    End Sub
    Private Sub Skin_ANext(ByVal g As Graphics)
        Select Case _Skin
            Case EnumSkin.Skins1
                Skin1_ANext(g)
            Case EnumSkin.Skins2
                Skin2_ANext(g)
            Case EnumSkin.Skins3
                Skin3_ANext(g)
            Case EnumSkin.Customer
                Customer_ANext(g)
            Case EnumSkin.Picture
                Picturer_ANext(g)
        End Select
    End Sub
#End Region
#Region "APrevious"
    Private Sub Skin1_APrevious(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin2_APrevious(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Skin3_APrevious(ByVal g As Graphics)
        Dim _img As Bitmap = Nothing
        Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        Width = 13 : Height = 13
        Select Case _State
            Case EnumState.Normal
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious1.png"))
            Case EnumState.MouseMove
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious2.png"))
            Case EnumState.Press
                _img = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.APrevious3.png"))
        End Select
        g.DrawImage(_img, 0, 0, Width, Height)
        _img.Dispose() : _img = Nothing
    End Sub
    Private Sub Customer_APrevious(ByVal g As Graphics)

    End Sub
    Private Sub Picturer_APrevious(ByVal g As Graphics)

    End Sub
    Private Sub Skin_APrevious(ByVal g As Graphics)
        Select Case _Skin
            Case EnumSkin.Skins1
                Skin1_APrevious(g)
            Case EnumSkin.Skins2
                Skin2_APrevious(g)
            Case EnumSkin.Skins3
                Skin3_APrevious(g)
            Case EnumSkin.Customer
                Customer_APrevious(g)
            Case EnumSkin.Picture
                Picturer_APrevious(g)
        End Select
    End Sub
#End Region
#End Region
    Protected Sub ButtonPaint(ByVal g As Graphics)
        Try
            g.Clear(Color.White)
            BackgroundImage = Nothing
            Select Case _Type
                Case EnumType.AExit
                    Skin_AExit(g)
                Case EnumType.AExitBack
                    Skin_AExitBack(g)
                Case EnumType.AClose
                    Skin_AClose(g)
                Case EnumType.AMenu
                    Skin_AMenu(g)
                Case EnumType.ANext
                    Skin_ANext(g)
                Case EnumType.APrevious
                    Skin_APrevious(g)
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PNA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        _bolFocus = True
        Invalidate()
    End Sub
    Private Sub PNA_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        _bolFocus = False
        Invalidate()
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If (_State <> EnumState.Press And e.KeyCode = Keys.Space) Or (_State <> EnumState.Press And e.KeyCode = Keys.Enter) Then
                _State = EnumState.Press
                Invalidate()
            End If
            MyBase.OnKeyDown(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If _State <> EnumState.Normal Then
                _State = EnumState.Normal
                Invalidate()
            End If
            MyBase.OnKeyUp(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _State <> EnumState.Press And e.Button = Windows.Forms.MouseButtons.Left Then
                _State = EnumState.Press
                Invalidate()
            End If
            MyBase.OnMouseDown(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _State <> EnumState.Normal Then
                _State = EnumState.Normal
                Invalidate()
            End If
            MyBase.OnMouseUp(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If _State <> EnumState.MouseMove And _State <> EnumState.Press Then
                _State = EnumState.MouseMove
                Invalidate()
            End If
            MyBase.OnMouseMove(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        Try
            If _State <> EnumState.Normal Then
                _State = EnumState.Normal
                Invalidate()
            End If
            MyBase.OnMouseLeave(e)
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        ButtonPaint(e.Graphics)
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Try
            MyBase.OnResize(e)
            Select Case _Type
                Case EnumType.AExit
                    Width = 11 : Height = 9
                Case EnumType.AClose, EnumType.ANext, EnumType.APrevious
                    Width = 13 : Height = 13
                Case EnumType.AMenu
                    Width = 25 : Height = 13
                    Dim gp As New GraphicsPath
                    gp.AddLine(0, 5, 0, 0)
                    gp.AddLine(0, 0, Width, 0)
                    gp.AddLine(Width, 0, Width, 5)
                    gp.AddLine(Width, 5, Width - 12, Height)
                    gp.AddLine(Width - 12, Height, 11, Height)
                    Region = New Region(gp)
            End Select
            Invalidate()
        Catch ex As Exception
        End Try
    End Sub
End Class
Public Class DesignerButtonStylePNA
    Inherits ControlDesigner
    Private _ButtonStylePNA As ButtonStylePNA
    Public Overrides Sub Initialize(ByVal component As System.ComponentModel.IComponent)
        MyBase.Initialize(component)
        _ButtonStylePNA = DirectCast(component, ButtonStylePNA)
    End Sub
    Public Overrides ReadOnly Property Verbs() As System.ComponentModel.Design.DesignerVerbCollection
        Get
            Dim v As New DesignerVerbCollection()
            v.Add(New DesignerVerb("Author: Pham Ngoc An", AddressOf OnAdd))
            v.Add(New DesignerVerb("Select option PNA", AddressOf OnAdd))
            v.Item(0).Description = "phamngocanthi@yahoo.com,phamngocanthi@gmail.com"
            v.Item(1).Description = "Show form"
            Return v
        End Get
    End Property
    Private Sub OnAdd(ByVal sender As Object, ByVal e As EventArgs)
        Select Case DirectCast(sender, DesignerVerb).Text
            Case "Author: Pham Ngoc An"
            Case "Select option PNA"
                'Dim _frmDesignerPNA As New frmDesignerPNA
                '_frmDesignerPNA.ShowDialog(_PNA)
        End Select
    End Sub
End Class