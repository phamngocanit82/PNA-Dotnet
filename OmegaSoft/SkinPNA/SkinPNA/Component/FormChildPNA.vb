Imports System.Windows.Forms
Imports System.Drawing
Imports OmegaSkins1
Imports OmegaSkins1.ButtonFormChildPNA2
Imports OmegaSkins1.SildeBarPNA1
Imports VB = Microsoft.VisualBasic
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
<ToolboxBitmap(GetType(FormChildPNA), "FormChildPNA.bmp")> _
Public Class FormChildPNA
#Region "ClassFormChildPNA"
#Region "Variables"
    Private _intIndex As Integer = 0
#End Region
#Region "Methods"
#Region "Config"
    Private Sub _getSkin()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Select Case clsConfig.GetSkinPNA
                Case "Skins1"
                    Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame01.png"))
                    Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame02.png"))
                    Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame03.png"))
                    Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame04.png"))
                    Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame05.png"))
                    Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame06.png"))
                    Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame07.png"))
                    Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame08.png"))
                Case "Skins2"
                    Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame09.png"))
                    Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame10.png"))
                    Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame11.png"))
                    Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame12.png"))
                    Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame13.png"))
                    Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame14.png"))
                    Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame15.png"))
                    Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame16.png"))
                Case "Skins3"
                    Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame17.png"))
                    Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame18.png"))
                    Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame19.png"))
                    Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame20.png"))
                    Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame21.png"))
                    Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame22.png"))
                    Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame23.png"))
                    Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("OmegaSkins.Frame24.png"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Public Sub LoadConfig()
        _getSkin()
    End Sub
#End Region
    Public Sub AddForm(ByVal frm As Form)
        Try
            Dim btnFormChild As New ButtonFormChildPNA2()

            'Form
            frm.FormBorderStyle = FormBorderStyle.None
            frm.ShowInTaskbar = False : frm.TopLevel = False
            frm.Anchor = pnlForm.Anchor
            frm.AutoScroll = True
            frm.Show()
            frm.Width = pnlForm.Width : frm.Height = pnlForm.Height
            pnlForm.Controls.Add(frm)

            'ButtonForm,ButtonClose
            btnFormChild.Text = frm.Text
            btnFormChild.TBitmap = frm.Icon.ToBitmap
            btnFormChild.BIndex = pnlForm.Controls.Count - 1
            btnFormChild.Tag = pnlForm.Controls.Count - 1
            btnFormChild.SetWidth() : btnFormChild.Refresh()
            panelButton.Controls.Add(btnFormChild)
            AddHandler btnFormChild.MouseClick, AddressOf Me.OnMouseClickButton
            AddHandler btnFormChild.MouseDown, AddressOf Me.OnMouseDownButton
            AddHandler btnFormChild.MouseUp, AddressOf Me.OnMouseUpButton
            AddHandler btnFormChild.MouseMove, AddressOf Me.OnMouseMoveButton
            AddHandler btnFormChild.MouseLeave, AddressOf Me.OnMouseLeaveButton
            AddHandler btnFormChild.CloseClick, AddressOf Me.OnCloseClick
            _addMenu(frm)
            _posAddNew(btnFormChild)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.AddForm)", , True)
        End Try
    End Sub
    Private Sub _posAddNew(ByVal btnFormChild As ButtonFormChildPNA2)
        Try
            Dim i As Integer
            If panelButton.Controls.Count > 1 Then
                DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = True
                pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
            End If
            i = panelButton.Controls.Count - 1
            _intIndex = i
            DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = False
            pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = True
            While i > 0
                panelButton.Controls(i - 1).Left = panelButton.Controls(i).Left + panelButton.Controls(i).Width
                If panelButton.Controls(i - 1).Left > 2000 Then Exit While
                i = i - 1
            End While
            _posSildeBar()
            _refeshResize()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _posSildeBar()
        Try
            If panelButton.Controls.Count > 0 Then
                If Visible = False Then Visible = True
                If panelButton.Controls(_intIndex).Visible = False Then
                    SildeBar1.LeftWith(0, 0)
                Else
                    SildeBar1.LeftWith(6 + panelButton.Controls(_intIndex).Left, panelButton.Controls(_intIndex).Width)
                End If
            Else
                Visible = False
                SildeBar1.LeftWith(0, 0)
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA._posSildeBar)", , True)
        End Try
    End Sub
    Private Sub _refeshResize()
        Try
            Dim i As Integer = panelButton.Controls.Count - 1
            While i >= 0
                If panelButton.Controls(i).Left + panelButton.Controls(i).Width >= Width - 33 Then
                    panelButton.Controls(i).Visible = False
                Else
                    If i > 0 Then panelButton.Controls(i - 1).Left = panelButton.Controls(i).Left + panelButton.Controls(i).Width
                    panelButton.Controls(i).Visible = True
                End If
                i = i - 1
            End While
            _posSildeBar()
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA._refeshResize)", , True)
        End Try
    End Sub
    Private Sub _posDetele()
        Try
            Dim i As Integer
            Dim _intBIndex As Integer, _intTag As Integer
            _intBIndex = DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).BIndex
            _intTag = DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).Tag
            cmnuForm.Items.RemoveAt(_intIndex)
            panelButton.Controls.RemoveAt(_intIndex)
            pnlForm.Controls.RemoveAt(_intIndex)
            If panelButton.Controls.Count = 0 Then Exit Sub
            i = panelButton.Controls.Count - 1
            While i >= 0
                If DirectCast(panelButton.Controls(i), ButtonFormChildPNA2).BIndex > _intBIndex Then
                    DirectCast(panelButton.Controls(i), ButtonFormChildPNA2).BIndex = DirectCast(panelButton.Controls(i), ButtonFormChildPNA2).BIndex - 1
                End If
                If DirectCast(panelButton.Controls(i), ButtonFormChildPNA2).Tag > _intTag Then
                    DirectCast(panelButton.Controls(i), ButtonFormChildPNA2).Tag = DirectCast(panelButton.Controls(i), ButtonFormChildPNA2).Tag - 1
                    cmnuForm.Items(i).Tag = cmnuForm.Items(i).Tag - 1
                End If
                i = i - 1
            End While
            If panelButton.Controls.Count = 0 Then
                Exit Sub
            Else
                _intIndex = _intIndex - 1
                If _intIndex < 0 Then _intIndex = 0
            End If
            panelButton.Controls(panelButton.Controls.Count - 1).Left = 0
            DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = False
            pnlForm.Controls(_intIndex).Visible = True
            _refeshResize()
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA._posDetele)", , True)
        End Try
    End Sub
    Private Sub _addMenu(ByVal frm As Form)
        Try
            Dim mItem As New ToolStripMenuItem
            mItem.Text = frm.Text
            mItem.Image = frm.Icon.ToBitmap
            mItem.Tag = panelButton.Controls.Count - 1
            cmnuForm.Items.Add(mItem)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA._addMenu)", , True)
        End Try
    End Sub
    Public Sub RemoveAll()
        Try
            While panelButton.Controls.Count > 0
                panelButton.Controls.RemoveAt(cmnuForm.Items.Count - 1)
                pnlForm.Controls.RemoveAt(cmnuForm.Items.Count - 1)
                cmnuForm.Items.RemoveAt(cmnuForm.Items.Count - 1)
            End While
            _intIndex = 0
            Visible = False
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.RemoveAll)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
#Region "ButtonFormChild2"
    Private Sub OnCloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim btnCloseChild As ButtonFormChildPNA1
            btnCloseChild = CType(sender, ButtonFormChildPNA1)
            If panelButton.Controls.Count = 0 Then Exit Sub
            DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = True
            pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
            _intIndex = btnCloseChild.BIndex
            _posDetele()
            _refeshResize()
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.OnCloseClick)", , True)
        End Try
    End Sub
    Private Sub OnMouseClickButton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            Dim btnFormChild As ButtonFormChildPNA2
            btnFormChild = CType(sender, ButtonFormChildPNA2)
            If _intIndex <> btnFormChild.BIndex Then
                DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = True
                pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
                _intIndex = btnFormChild.BIndex
                DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = False
                pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = True
                _posSildeBar()
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.OnMouseClickButton)", , True)
        End Try
    End Sub
    Private Sub OnMouseDownButton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            Dim btnFormChild As ButtonFormChildPNA2
            btnFormChild = CType(sender, ButtonFormChildPNA2)
            If _intIndex = btnFormChild.BIndex Then
                SildeBar1.State = SildeBarPNA1.StateButton.Press
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.OnMouseDownButton)", , True)
        End Try
    End Sub
    Private Sub OnMouseUpButton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            Dim btnFormChild As ButtonFormChildPNA2
            btnFormChild = CType(sender, ButtonFormChildPNA2)
            If SildeBar1.State <> SildeBarPNA1.StateButton.Normal Then
                If _intIndex = btnFormChild.BIndex Then
                    SildeBar1.State = SildeBarPNA1.StateButton.Normal
                End If
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.OnMouseUpButton)", , True)
        End Try
    End Sub
    Private Sub OnMouseMoveButton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            Dim btnFormChild As ButtonFormChildPNA2
            btnFormChild = CType(sender, ButtonFormChildPNA2)
            If SildeBar1.State <> SildeBarPNA1.StateButton.Press Then
                If _intIndex = btnFormChild.BIndex And SildeBar1.State <> SildeBarPNA1.StateButton.MouseMove Then
                    SildeBar1.State = SildeBarPNA1.StateButton.MouseMove
                End If
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.OnMouseMoveButton)", , True)
        End Try
    End Sub
    Private Sub OnMouseLeaveButton(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim btnFormChild As ButtonFormChildPNA2
            btnFormChild = CType(sender, ButtonFormChildPNA2)
            If _intIndex = btnFormChild.BIndex Then
                SildeBar1.State = SildeBarPNA1.StateButton.Normal
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.OnMouseLeaveButton)", , True)
        End Try
    End Sub
    Private Sub btnForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForm.Click
        cmnuForm.Show(btnForm, 0, btnForm.Height)
    End Sub
    Private Function _getIndexMenu(ByVal _intTag As Integer) As Integer
        Try
            Dim i As Integer
            For i = 0 To cmnuForm.Items.Count - 1
                If cmnuForm.Items(i).Tag = _intTag Then
                    Return i
                End If
            Next
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA._getIndexMenu)", , True)
        End Try
    End Function
    Private Sub cmnuForm_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles cmnuForm.ItemClicked
        Try
            If e.ClickedItem.Tag <> panelButton.Controls(_intIndex).Tag Then
                Dim _intTag As Integer
                _intTag = _getIndexMenu(e.ClickedItem.Tag)
                If panelButton.Controls(_intTag).Visible = False Then
                    Dim _strTmp As String
                    Dim _bitmap As Bitmap

                    _strTmp = cmnuForm.Items(_intIndex).Text
                    _bitmap = cmnuForm.Items(_intIndex).Image
                    cmnuForm.Items(_intIndex).Image = e.ClickedItem.Image
                    cmnuForm.Items(_intIndex).Tag = e.ClickedItem.Tag
                    cmnuForm.Items(_intIndex).Text = e.ClickedItem.Text
                    e.ClickedItem.Text = _strTmp
                    e.ClickedItem.Image = _bitmap

                    e.ClickedItem.Tag = panelButton.Controls(_intIndex).Tag

                    panelButton.Controls(_intTag).Text = e.ClickedItem.Text
                    DirectCast(panelButton.Controls(_intTag), ButtonFormChildPNA2).TBitmap = e.ClickedItem.Image
                    panelButton.Controls(_intTag).Tag = e.ClickedItem.Tag
                    DirectCast(panelButton.Controls(_intTag), ButtonFormChildPNA2).SetWidth()
                    DirectCast(panelButton.Controls(_intTag), ButtonFormChildPNA2).Refresh()

                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = False
                    panelButton.Controls(_intIndex).Text = cmnuForm.Items(_intIndex).Text
                    DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).TBitmap = cmnuForm.Items(_intIndex).Image
                    panelButton.Controls(_intIndex).Tag = cmnuForm.Items(_intIndex).Tag
                    DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SetWidth()
                    DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).Refresh()
                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = True
                    _refeshResize()
                Else
                    DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = True
                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = False
                    _intIndex = _intTag
                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = True
                    DirectCast(panelButton.Controls(_intIndex), ButtonFormChildPNA2).SendBack = False
                    _refeshResize()
                End If
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FormChildPNA.cmnuForm_ItemClicked)", , True)
        End Try
    End Sub
#End Region
#Region "FormChild"
    Private Sub FormChildPNA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If panelButton.Controls.Count = 0 Then
            Visible = False
        Else
            Visible = True
        End If
    End Sub
    Private Sub FormChildPNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        _refeshResize()
    End Sub
#End Region
#End Region
#End Region
End Class
