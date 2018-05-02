VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmMain 
   AutoRedraw      =   -1  'True
   BorderStyle     =   0  'None
   Caption         =   "CPG-WFU"
   ClientHeight    =   2205
   ClientLeft      =   105
   ClientTop       =   105
   ClientWidth     =   4425
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2205
   ScaleWidth      =   4425
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   615
      Left            =   840
      TabIndex        =   0
      Top             =   120
      Width           =   2415
      _ExtentX        =   4260
      _ExtentY        =   1085
      _Version        =   393216
      BorderStyle     =   1
      Appearance      =   0
      Scrolling       =   1
   End
   Begin VB.Timer Timer1 
      Interval        =   1
      Left            =   1560
      Top             =   1080
   End
   Begin VB.TextBox txtMain 
      Height          =   495
      Left            =   240
      TabIndex        =   2
      Text            =   "Type anything in here..."
      Top             =   1440
      Width           =   1815
   End
   Begin VB.CommandButton cmdMain 
      Caption         =   "Click Me!"
      Height          =   495
      Left            =   2400
      TabIndex        =   1
      Top             =   1200
      Width           =   1695
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False



Private Sub Form_Load()
    Me.Show
    
    Call AttachForm(Me, 150, 30, True)
End Sub

Private Sub Form_Unload(Cancel As Integer)
    Call DetachForm
End Sub

Private Sub ProgressBar1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    'display the popmenu if this control is clicked
    If Button = 2 Then frmMenu.PopupMenu frmMenu.mnuMain
End Sub

Private Sub cmdMain_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
    'display the popmenu if this control is right-clicked
    If Button = 2 Then Me.PopupMenu frmMenu.mnuMain
End Sub

Private Sub cmdMain_Click()
    MsgBox "Command button clicked!", vbInformation + vbOKOnly
End Sub

Private Sub Timer1_Timer()
    'this timer simply keeps the progressbar moving for the visual effect
    If ProgressBar1.Value = ProgressBar1.Max Then
        ProgressBar1.Value = 0
    ElseIf ProgressBar1.Value < ProgressBar1.Max Then
        ProgressBar1.Value = ProgressBar1.Value + 1
    End If
   
End Sub

Private Sub Form_Paint()
    Me.Hide
    With ProgressBar1
        .Top = 0
        .Left = 0
        .Width = Me.Width
        .Height = Me.Height
    End With
    With cmdMain
        .Top = 0
        .Left = 0
        .Width = Me.Width
        .Height = Me.Height
    End With
    With txtMain
        .Top = 0
        .Left = 0
        .Width = Me.Width
        .Height = Me.Height
    End With
    Me.Show
End Sub

Private Sub Form_Resize()
    Call Form_Paint
End Sub


