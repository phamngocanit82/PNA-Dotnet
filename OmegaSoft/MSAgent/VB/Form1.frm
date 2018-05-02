VERSION 5.00
Object = "{F5BE8BC2-7DE6-11D0-91FE-00C04FD701A5}#2.0#0"; "AGENTCTL.DLL"
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "How to use MS Agent and make a seequens with it (By Paw Jershauge)"
   ClientHeight    =   5025
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7215
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5025
   ScaleWidth      =   7215
   StartUpPosition =   2  'CenterScreen
   Begin VB.CheckBox Check1 
      Caption         =   "View intro when program starts"
      Height          =   495
      Left            =   2640
      TabIndex        =   10
      Top             =   4440
      Width           =   1815
   End
   Begin VB.ListBox Infolist 
      Height          =   450
      ItemData        =   "Form1.frx":0000
      Left            =   6960
      List            =   "Form1.frx":00E8
      TabIndex        =   9
      Top             =   120
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Frame Frame2 
      Caption         =   "Animation names"
      Height          =   4815
      Left            =   4560
      TabIndex        =   7
      Top             =   120
      Width           =   2535
      Begin VB.ListBox List2 
         Height          =   4350
         ItemData        =   "Form1.frx":0807
         Left            =   120
         List            =   "Form1.frx":08EF
         TabIndex        =   8
         Top             =   360
         Width           =   2295
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "Program a Seequens"
      Height          =   4815
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2415
      Begin VB.ListBox List1 
         Height          =   2010
         Left            =   120
         TabIndex        =   6
         Top             =   1200
         Width           =   2175
      End
      Begin VB.CommandButton Command5 
         Caption         =   "Play"
         Height          =   375
         Left            =   120
         TabIndex        =   5
         Top             =   4320
         Width           =   2175
      End
      Begin VB.CommandButton Command4 
         Caption         =   "Remove all from list"
         Height          =   375
         Left            =   120
         TabIndex        =   4
         Top             =   3840
         Width           =   2175
      End
      Begin VB.CommandButton Command3 
         Caption         =   "Remove from list"
         Height          =   375
         Left            =   120
         TabIndex        =   3
         Top             =   3360
         Width           =   2175
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Add animation"
         Height          =   375
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   2175
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Add talk"
         Height          =   375
         Left            =   120
         TabIndex        =   1
         Top             =   240
         Width           =   2175
      End
   End
   Begin AgentObjectsCtl.Agent Agent1 
      Left            =   2640
      Top             =   240
      _cx             =   847
      _cy             =   847
   End
   Begin VB.Menu REG 
      Caption         =   ""
      Visible         =   0   'False
      Begin VB.Menu mnuEdit 
         Caption         =   "&Edit"
      End
      Begin VB.Menu mnuCopy 
         Caption         =   "&Copy"
      End
   End
   Begin VB.Menu Ani 
      Caption         =   ""
      Visible         =   0   'False
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   0
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   1
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   2
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   3
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   4
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   5
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   6
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   7
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   8
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   9
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   10
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   11
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   12
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   13
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   14
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   15
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   16
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   17
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   18
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   19
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   20
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   21
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   22
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   23
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   24
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   25
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   26
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   27
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   28
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   29
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   30
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   31
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   32
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   33
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   34
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   35
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   36
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   37
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   38
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   39
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   40
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   41
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   42
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   43
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   44
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   45
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   46
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   47
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   48
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   49
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   50
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   51
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   52
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   53
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   54
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   55
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   56
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   57
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   58
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   59
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   60
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   61
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   62
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   63
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   64
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   65
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   66
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   67
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   68
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   69
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   70
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   71
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   72
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   73
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   74
      End
      Begin VB.Menu L1 
         Caption         =   ""
         Index           =   75
      End
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Dim genie As IAgentCtlCharacterEx  ' Make the name "Genie" An Agent Character
Public EditListIndex As Integer

Private Sub Check1_Click()
If Check1.Value = 0 Then
SaveSetting App.EXEName, "Loadintro", "Load", "False"
Else
SaveSetting App.EXEName, "Loadintro", "Load", "True"
End If
End Sub

Private Sub Form_Load()
Dim xload As String
Agent1.Characters.Load "Genie", "Genie.acs" 'Asign the Genie file to the Agent
Set genie = Agent1.Characters("Genie")      'Load the Agent and the Character into the Genie name
genie.LanguageID = &H409                    'Set Language to english = &H409
genie.Show                                  'Show the Character
genie.Play "Greet"
genie.Speak "Hallo, and wellcome, to the, How, to use, MS, Agent. By Paw Jershauge." 'Say something
'genie.Stop
genie.Left = 500                            'Horizontal plasement
genie.Top = 350                             'Vertical Plasement
'genie.Hide                                  'Hide the Character (NOT UNLOAD)

xload = GetSetting(App.EXEName, "LoadIntro", "Load", True)
'A littel intoduction__________________________
Loadintro xload
'Load animation names into menu
For x = 0 To List2.ListCount - 1
L1(x).Caption = List2.List(x)
Next x
'______________________________
End Sub

Function Loadintro(Load As String)
If Load = "True" Then
Check1.Value = 1
genie.Speak "If you look"
genie.Play "gestureleft"
genie.Speak "To your right, you can see the animation that i can make"
genie.Speak "Try dobble click on one of the animations and i will show them to you"
genie.Speak "But please wait ontill i'm finished"
genie.Play "gestureRight"
genie.Speak "Please look to your left"
genie.Speak "This is where you can make your own seequens with me"
genie.Speak "Just add some speechs and animation and you are on your way"
genie.Play "Greet"
genie.Speak "Good luck"
List1.AddItem "Play: Greet"
List1.AddItem "Talk: Greatings, Maaster. Ahhhh. it is nise, to be free, again"
List1.AddItem "Play: Suggest"
List1.AddItem "Talk: I have an, i dear. Go to. the. Planet Source Code, web page. And"
List1.AddItem "Talk: Take the time, to vote for me. I would be very pleased. Thanks. Your, the best."
List1.AddItem "Play: Pleased"
Else
Check1.Value = 0
End If
End Function

Private Sub List2_Click()
List2.ToolTipText = Infolist.List(List2.ListIndex)
End Sub

Private Sub List2_DblClick()
genie.Stop
genie.Play List2.List(List2.ListIndex)
End Sub

'Users seequens############################################################################################

Private Sub Command1_Click()
Dim userinput As String
userinput = InputBox("What to say ???", "Add talk")
If userinput <> "" Then 'If user has typed something then add the text
List1.AddItem "Talk: " & userinput
Else 'Else if not then display a message
MsgBox "The Character must say somethink", vbCritical, "Talk error"
End If
End Sub

Private Sub Command2_Click()
Me.PopupMenu Ani 'Show Animation menu
End Sub


Private Sub Command3_Click()
If List1.ListIndex < 0 Then 'Check if there has been select anything, if not then display an message
MsgBox "You must first select somethink to remove", vbInformation, "Nothing to remove"
Else ' else remove it
List1.RemoveItem List1.ListIndex
End If
End Sub

Private Sub Command4_Click()
List1.Clear ' Delete all
End Sub

Private Sub Command5_Click()
For x = 0 To List1.ListCount
If Left(List1.List(x), 5) = "Talk:" Then 'Check if its a speech or a animation (IF SPEECH THEN THIS)
genie.Speak Mid(List1.List(x), 7, Len(List1.List(x))) 'remove (Talk:) and insert only the speech
ElseIf Left(List1.List(x), 5) = "Play:" Then 'Check if its a speech or a animation (IF ANIMATION THEN THIS)
genie.Play Mid(List1.List(x), 7, Len(List1.List(x))) 'remove (Play:) and insert only the animation
End If
Next x
End Sub

Private Sub L1_Click(Index As Integer)
If EditListIndex > 0 Then
List1.List(EditListIndex) = "Play: " & L1(Index).Caption 'Add animation to List
Else
List1.AddItem "Play: " & L1(Index).Caption 'Add animation to List
End If
EditListIndex = -1
End Sub

Private Sub mnuEdit_Click()
Dim userinput
If List1.ListIndex >= 0 Then
    userinput = MsgBox("Do want to edit " & List1.List(List1.ListIndex), vbYesNo, "Edit seequens")
    If userinput = vbYes Then
        If Left(List1.List(List1.ListIndex), 5) = "Talk:" Then  'Check if its a speech or a animation (IF SPEECH THEN THIS)
        userinput = InputBox("What to say ???", "Add talk")
            If userinput <> "" Then 'If user has typed something then add the text
            List1.List(List1.ListIndex) = "Talk: " & userinput
            Else 'Else if not then display a message
            MsgBox "The Character must say somethink", vbCritical, "Talk error"
            End If
        ElseIf Left(List1.List(List1.ListIndex), 5) = "Play:" Then  'Check if its a speech or a animation (IF ANIMATION THEN THIS)
        MsgBox "To change the animation, please click [add animation]" & vbCrLf & "and let the one you want to change be highligthed"
        EditListIndex = List1.ListIndex
        End If
    Else
    'Beep
    End If
End If
End Sub

Private Sub List1_MouseDown(Button As Integer, Shift As Integer, x As Single, Y As Single)
Select Case Button
Case 0
MsgBox "0"
Case 1
If Left(List1.List(List1.ListIndex), 5) = "Talk:" Then  'Check if its a speech or a animation (IF SPEECH THEN THIS)
genie.Speak Mid(List1.List(List1.ListIndex), 7, Len(List1.List(List1.ListIndex)))   'remove (Talk:) and insert only the speech
ElseIf Left(List1.List(List1.ListIndex), 5) = "Play:" Then  'Check if its a speech or a animation (IF ANIMATION THEN THIS)
genie.Play Mid(List1.List(List1.ListIndex), 7, Len(List1.List(List1.ListIndex)))   'remove (Play:) and insert only the animation
End If
Case 2
Me.PopupMenu REG
End Select
End Sub


'Users seequens############################################################################################

