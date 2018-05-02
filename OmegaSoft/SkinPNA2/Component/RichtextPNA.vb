Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Public Class RichtextPNA
    Private Sub mnuUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUndo.Click
        Try
            If TextPNA.CanUndo Then
                TextPNA.Undo()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRedo.Click
        Try
            If TextPNA.CanRedo Then
                TextPNA.Redo()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim _frmfind As New frmFind
        _frmfind.showForm(Me)
    End Sub
    Private Sub mnuFindReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFindReplace.Click
        Dim _frmFindReplace As New frmFindReplace
        _frmFindReplace.showForm(Me)
    End Sub
    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        Try
            TextPNA.SelectAll()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        Try
            TextPNA.Copy()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        Try
            TextPNA.Cut()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaste.Click
        Try
            TextPNA.Paste()
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub mnuInsertImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsertImage.Click
    '    Try
    '        OpenFileDialog1.Title = "Insert image file"
    '        OpenFileDialog1.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif"
    '        OpenFileDialog1.FilterIndex = 1
    '        OpenFileDialog1.ShowDialog()
    '        If OpenFileDialog1.FileName <> "" Then
    '            Dim img As Image
    '            img = Image.FromFile(OpenFileDialog1.FileName)
    '            Clipboard.SetDataObject(img)
    '            Dim df As DataFormats.Format
    '            df = DataFormats.GetFormat(DataFormats.Bitmap)
    '            If TextPNA.CanPaste(df) Then
    '                TextPNA.Paste(df)
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub mnuSelectFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectFont.Click
        Try
            If TextPNA.SelectionFont Is Nothing Then
                FontDialog1.Font = TextPNA.SelectionFont
            Else
                FontDialog1.Font = Nothing
            End If
            FontDialog1.ShowApply = True
            If FontDialog1.ShowDialog() = DialogResult.OK Then
                TextPNA.SelectionFont = FontDialog1.Font
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFontColor.Click
        Try
            ColorDialog1.Color = TextPNA.ForeColor
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                TextPNA.SelectionColor = ColorDialog1.Color
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBold.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Bold
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItalic.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Italic
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnderline.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Underline
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNormal.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Regular
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuPageColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPageColor.Click
        Try
            ColorDialog1.Color = TextPNA.BackColor
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                TextPNA.BackColor = ColorDialog1.Color
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuNone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNone.Click
        Try
            TextPNA.SelectionIndent = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnu5Pts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu5Pts.Click
        Try
            TextPNA.SelectionIndent = 5
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnu10Pts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu10Pts.Click
        Try
            TextPNA.SelectionIndent = 10
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnu15Pts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu15Pts.Click
        Try
            TextPNA.SelectionIndent = 15
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnu20Pts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu20Pts.Click
        Try
            TextPNA.SelectionIndent = 20
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLeft.Click
        Try
            TextPNA.SelectionAlignment = HorizontalAlignment.Left
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCenter.Click
        Try
            TextPNA.SelectionAlignment = HorizontalAlignment.Center
        Catch ex As Exception
        End Try
    End Sub
    Private Sub mnuRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRight.Click
        Try
            TextPNA.SelectionAlignment = HorizontalAlignment.Right
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub mnuAddBullets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddBullets.Click
    '    Try
    '        TextPNA.BulletIndent = 10
    '        TextPNA.SelectionBullet = True
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub mnuRemoveBullets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRemoveBullets.Click
    '    Try
    '        TextPNA.SelectionBullet = False
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub tbrFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrFont.Click
        Try
            If TextPNA.SelectionFont Is Nothing Then
                FontDialog1.Font = TextPNA.SelectionFont
            Else
                FontDialog1.Font = Nothing
            End If
            FontDialog1.ShowApply = True
            If FontDialog1.ShowDialog() = DialogResult.OK Then
                TextPNA.SelectionFont = FontDialog1.Font
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrColor.Click
        Try
            ColorDialog1.Color = TextPNA.ForeColor
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                TextPNA.SelectionColor = ColorDialog1.Color
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrLeft.Click
        Try
            TextPNA.SelectionAlignment = HorizontalAlignment.Left
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrCenter.Click
        Try
            TextPNA.SelectionAlignment = HorizontalAlignment.Center
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrRight.Click
        Try
            TextPNA.SelectionAlignment = HorizontalAlignment.Right
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrBold.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Bold
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrItalic.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Italic
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrUnderline.Click
        Try
            If Not TextPNA.SelectionFont Is Nothing Then
                Dim currentFont As System.Drawing.Font
                Dim newFontStyle As System.Drawing.FontStyle
                currentFont = TextPNA.SelectionFont
                newFontStyle = FontStyle.Underline
                TextPNA.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tbrFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrFind.Click
        Dim _frmfind As New frmFind
        _frmfind.showForm(Me)
    End Sub
    Private Sub tbrFindReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbrFindReplace.Click
        Dim _frmFindReplace As New frmFindReplace
        _frmFindReplace.showForm(Me)
    End Sub
End Class
