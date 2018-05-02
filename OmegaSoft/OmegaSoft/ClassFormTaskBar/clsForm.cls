VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Public Sub setAttachForm(ByVal m_Hwnd As Long, ByVal m_width As Integer, ByVal m_height As Integer, ByVal m_ForceWidth As Integer, ByVal m_ForceHeight As Integer)
   Call AttachForm(m_Hwnd, m_width, m_height, m_ForceWidth, m_ForceHeight, True)
End Sub
Public Sub setDetachForm()
    Call DetachForm
End Sub
