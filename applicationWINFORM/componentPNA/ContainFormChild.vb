Imports System.Windows.Forms
Imports System.Drawing
Imports VB = Microsoft.VisualBasic
Public Class ContainFormChildPNA
    Private _intIndex As Integer = 0
#Region "ContainFormChildPNA"
    Private Sub GetSkin()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Dim skin = "Skin1"
            Select Case skin
                Case "Skin1"
                    Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame01.png"))
                    Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame02.png"))
                    Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame03.png"))
                    Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame04.png"))
                    Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame05.png"))
                    Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame06.png"))
                    Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame07.png"))
                    Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame08.png"))
                Case "Skin2"
                    Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame09.png"))
                    Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame10.png"))
                    Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame11.png"))
                    Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame12.png"))
                    Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame13.png"))
                    Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame14.png"))
                    Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame15.png"))
                    Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame16.png"))
                Case "Skin3"
                    Me.picLeftTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame17.png"))
                    Me.picTopMain.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame18.png"))
                    Me.picRightTop.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame19.png"))
                    Me.picLeft.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame20.png"))
                    Me.picLeftBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame21.png"))
                    Me.picBottom.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame22.png"))
                    Me.picRightBottom.Image = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame23.png"))
                    Me.picRight.BackgroundImage = New Bitmap(AppAssembly.GetManifestResourceStream("componentPNA.Frame24.png"))
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Public Sub AddForm(ByVal frm As Form)
        Try
            Dim btnFormChild As New ContainFormChildButtonPNA()

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
            btnFormChild.Bitmap = frm.Icon.ToBitmap
            btnFormChild.Index = pnlForm.Controls.Count - 1
            btnFormChild.Tag = pnlForm.Controls.Count - 1
            btnFormChild.SetWidth() : btnFormChild.Refresh()
            panelButton.Controls.Add(btnFormChild)
            AddHandler btnFormChild.MouseClick, AddressOf Me.OnMouseClickButton
            AddHandler btnFormChild.CloseClick, AddressOf Me.OnCloseClick
            _addMenu(frm)
            _posAddNew(btnFormChild)
            frm.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _posAddNew(ByVal btnFormChild As ContainFormChildButtonPNA)
        Try
            Dim i As Integer
            If panelButton.Controls.Count > 1 Then
                DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = True
                pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
            End If
            i = panelButton.Controls.Count - 1
            _intIndex = i
            DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = False
            pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = True
            While i > 0
                panelButton.Controls(i - 1).Left = panelButton.Controls(i).Left + panelButton.Controls(i).Width
                If panelButton.Controls(i - 1).Left > 2000 Then Exit While
                i = i - 1
            End While
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
                'Visible = False
                SildeBar1.LeftWith(0, 0)
            End If
        Catch ex As Exception
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
        End Try
    End Sub
    Private Sub _posDetele()
        Try
            Dim i As Integer
            Dim _intBIndex As Integer, _intTag As Integer
            _intBIndex = DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).Index
            _intTag = DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).Tag
            cmnuForm.Items.RemoveAt(_intIndex)
            Dim frm As Form
            frm = pnlForm.Controls(_intIndex)
            panelButton.Controls.RemoveAt(_intIndex)
            pnlForm.Controls.RemoveAt(_intIndex)
            frm.Close() : frm = Nothing
            If panelButton.Controls.Count = 0 Then Exit Sub
            i = panelButton.Controls.Count - 1
            While i >= 0
                If DirectCast(panelButton.Controls(i), ContainFormChildButtonPNA).Index > _intBIndex Then
                    DirectCast(panelButton.Controls(i), ContainFormChildButtonPNA).Index = DirectCast(panelButton.Controls(i), ContainFormChildButtonPNA).Index - 1
                End If
                If DirectCast(panelButton.Controls(i), ContainFormChildButtonPNA).Tag > _intTag Then
                    DirectCast(panelButton.Controls(i), ContainFormChildButtonPNA).Tag = DirectCast(panelButton.Controls(i), ContainFormChildButtonPNA).Tag - 1
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
            DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = False
            pnlForm.Controls(_intIndex).Visible = True
            _refeshResize()
        Catch ex As Exception
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
            ' Visible = False
        Catch ex As Exception
        End Try
    End Sub
    Private Sub _swapForm(ByVal intIndex1 As Integer, ByVal intIndex2 As Integer)


    End Sub
#End Region
    Private Sub OnMouseClickButton(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            Dim btnFormChild As ContainFormChildButtonPNA
            btnFormChild = CType(sender, ContainFormChildButtonPNA)
            If _intIndex <> btnFormChild.Index Then
                DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = True
                pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
                _intIndex = btnFormChild.Index
                DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = False
                pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = True
                _posSildeBar()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub OnCloseClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim btnCloseChild As ButtonStylePNA
            btnCloseChild = CType(sender, ButtonStylePNA)
            If panelButton.Controls.Count = 0 Then Exit Sub
            DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = True
            pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
            _intIndex = btnCloseChild.Index
            _posDetele()
            _refeshResize()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        cmnuForm.Show(btnMenu, 0, btnMenu.Height)
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
                    DirectCast(panelButton.Controls(_intTag), ContainFormChildButtonPNA).Bitmap = e.ClickedItem.Image
                    panelButton.Controls(_intTag).Tag = e.ClickedItem.Tag
                    DirectCast(panelButton.Controls(_intTag), ContainFormChildButtonPNA).SetWidth()
                    DirectCast(panelButton.Controls(_intTag), ContainFormChildButtonPNA).Refresh()

                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = False
                    panelButton.Controls(_intIndex).Text = cmnuForm.Items(_intIndex).Text
                    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).Bitmap = cmnuForm.Items(_intIndex).Image
                    panelButton.Controls(_intIndex).Tag = cmnuForm.Items(_intIndex).Tag
                    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SetWidth()
                    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).Refresh()
                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = True
                    _refeshResize()
                Else
                    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = True
                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = False
                    _intIndex = _intTag
                    pnlForm.Controls(CInt(panelButton.Controls(_intIndex).Tag)).Visible = True
                    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = False
                    _refeshResize()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ContainFormChildPNA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            GetSkin()
            'If panelButton.Controls.Count = 0 Then
            '    Visible = False
            'Else
            '    Visible = True
            'End If
            _refeshResize()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ContainFormChildPNA_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        _refeshResize()
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click

        'If _intIndex <> 0 Then
        '    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = True
        '    pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
        '    _intIndex = _intIndex - 1
        '    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = False
        '    pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = True
        '    If panelButton.Controls(_intIndex).Visible = False Then
        '        MsgBox("aaa")
        '    Else
        '        _posSildeBar()
        '    End If
        'End If

    End Sub
    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click

        'If _intIndex < panelButton.Controls.Count - 1 Then
        '    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = True
        '    pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = False
        '    _intIndex = _intIndex + 1
        '    DirectCast(panelButton.Controls(_intIndex), ContainFormChildButtonPNA).SendBack = False
        '    pnlForm.Controls(panelButton.Controls(_intIndex).Tag).Visible = True
        '    _posSildeBar()
        'End If

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            If panelButton.Controls.Count = 0 Then Exit Sub
            _posDetele()
            _refeshResize()
        Catch ex As Exception
        End Try
    End Sub
End Class
