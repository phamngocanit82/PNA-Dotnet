Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Public Class SlideSeek
#Region "Variables"
    Private _strToolTip As String
    Private _dblMax As Double = 100
    Private _dblMin As Double = 0
    Private _dblPosition As Double = 0
    Private _dblDistance As Double
    Private _intX As Integer
    Private _intMouseMove As Boolean
#End Region
#Region "Properties"
    Public Property Max() As Double
        Get
            Return _dblMax
        End Get
        Set(ByVal Value As Double)
            _dblMax = Value
        End Set
    End Property
    Public Property Min() As Double
        Get
            Return _dblMin
        End Get
        Set(ByVal Value As Double)
            _dblMin = 0
        End Set
    End Property
    Public Property Position() As Double
        Get
            Return _dblPosition
        End Get
        Set(ByVal Value As Double)
            _dblPosition = Value
            If _dblPosition < 0 Then
                _dblPosition = 0
                btnSeek.Left = 0
                panelSeek2.Width = btnSeek.Left + 2
            Else
                If _dblPosition >= Max Then
                    _dblPosition = Max
                    btnSeek.Left = panelSeek1.Width - btnSeek.Width
                    panelSeek2.Width = panelSeek1.Width
                Else
                    btnSeek.Left = Math.Round(_dblPosition * (panelSeek1.Width - btnSeek.Width) / Max)
                    panelSeek2.Width = btnSeek.Left + 2
                End If
            End If
        End Set
    End Property
    Public Property Distance() As Double
        Get
            Return _dblDistance
        End Get
        Set(ByVal Value As Double)
            _dblDistance = Value
        End Set
    End Property
    Public Property BToolTip() As String
        Get
            Return _strToolTip
        End Get
        Set(ByVal Value As String)
            _strToolTip = Value
            tipButton.RemoveAll()
            btnSeek.BToolTip = Value
            tipButton.SetToolTip(Me, Value)
        End Set
    End Property
#End Region
    Private Sub _loadPosition()
        Try
            btnSeek.Left = 0
            panelSeek2.Width = btnSeek.Left + 2
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SlideSeek_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _loadPosition()
    End Sub
    Private Sub SlideSeek_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Height = 7
    End Sub
    Private Sub btnSeek_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSeek.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            _intMouseMove = True
        Else
            _intMouseMove = False
        End If
    End Sub
    Private Sub btnSeek_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSeek.MouseMove
        If _intMouseMove Then
            If btnSeek.Left + e.X < panelSeek2.Left Then
                btnSeek.Left = 0
                panelSeek2.Width = btnSeek.Left + 2
                Position = 0
            Else
                If btnSeek.Left + btnSeek.Width + e.X > panelSeek1.Width Then
                    btnSeek.Left = panelSeek1.Width - btnSeek.Width
                    panelSeek2.Width = panelSeek1.Width
                    Position = Max
                Else
                    btnSeek.Left = btnSeek.Left + e.X
                    panelSeek2.Width = btnSeek.Left + 2
                    Position = CInt((btnSeek.Left) / (panelSeek1.Width - btnSeek.Width) * Max)
                End If
            End If
        End If
    End Sub
    Private Sub btnSeek_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSeek.MouseUp
        _intMouseMove = False
    End Sub
End Class
