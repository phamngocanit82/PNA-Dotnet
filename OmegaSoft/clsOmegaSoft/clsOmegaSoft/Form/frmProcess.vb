Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports vb = Microsoft.VisualBasic
Public Class frmProcess
#Region "ClassfrmProcess"
#Region "Struct"
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
#End Region
#Region "Api"
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hwnd As IntPtr, ByRef lpRect As RECT) As Integer
    End Function
#End Region
#Region "Variables"
    'Private _intX As Integer
    'Private _intY As Integer
#End Region
#Region "Properties"
    Public Property Value() As Double
        Get
            Return FrmProcessPNA1.Value
        End Get
        Set(ByVal Value As Double)
            FrmProcessPNA1.Value = Value
        End Set
    End Property
#End Region
#Region "Others"
    Public Sub showForm(ByVal frm As Form)
        'Dim winRect As New RECT
        'GetWindowRect(frm.Handle, winRect)
        '_intX = winRect.Left
        '_intY = winRect.Top      
        Show(frm)
    End Sub
#End Region
#End Region

    Private Sub frmProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FrmProcessPNA1.Refresh()
        FrmProcessPNA1.Value = 0
    End Sub
End Class