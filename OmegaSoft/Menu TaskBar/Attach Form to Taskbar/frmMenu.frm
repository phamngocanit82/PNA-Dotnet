VERSION 5.00
Begin VB.Form frmMenu 
   Caption         =   "Form1"
   ClientHeight    =   2250
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   4155
   LinkTopic       =   "Form1"
   ScaleHeight     =   2250
   ScaleWidth      =   4155
   StartUpPosition =   3  'Windows Default
   Begin VB.Menu mnuMain 
      Caption         =   "Main"
      Begin VB.Menu mnuExit 
         Caption         =   "E&xit"
      End
      Begin VB.Menu mnuSep1 
         Caption         =   "-"
      End
      Begin VB.Menu mnuProgress 
         Caption         =   "Show &Progress Bar"
      End
      Begin VB.Menu mnuCommand 
         Caption         =   "Show &Command Button"
      End
   End
End
Attribute VB_Name = "frmMenu"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub mnuCommand_Click()
    frmMain.ProgressBar1.Visible = False
    frmMain.cmdMain.Visible = True
    frmMain.txtMain.Visible = False
End Sub

Private Sub mnuExit_Click()
    Unload frmMain
    Unload Me
    End
End Sub

Private Sub mnuProgress_Click()
    frmMain.ProgressBar1.Visible = True
    frmMain.cmdMain.Visible = False
    frmMain.txtMain.Visible = False
End Sub

