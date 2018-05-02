Imports System.Windows.Forms
Imports System.Drawing.Printing
Public Class TiffPNA
    Private oMODIDocument As MODI.Document
    Private Sub _showStatus()
        Try
            Label1.Text = docView.PageNum + 1 & "/" & docView.NumPages
            Dim img As MODI.Image = oMODIDocument.Images.Item(docView.PageNum)
            Label1.Text = Label1.Text & "     Width:" & img.PixelWidth & ",Height:" & img.PixelHeight
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ReadTiff(ByVal strPathFile As String)
        Try
            oMODIDocument = New MODI.Document
            oMODIDocument.Create(strPathFile)
            docView.Document = oMODIDocument
            docView.Visible = True
            _showStatus()
            docView.Refresh()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            SaveFileDialog1.FileName = "Save files"
            SaveFileDialog1.Filter = "files (*.tiff;*.tif)|*.tiff;*.tif"
            If SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                oMODIDocument.SaveAs(SaveFileDialog1.FileName, MODI.MiFILE_FORMAT.miFILE_FORMAT_TIFF_LOSSLESS, MODI.MiCOMP_LEVEL.miCOMP_LEVEL_LOW)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim oPrintDialog As New PrintDialog
            Dim oPrinterSettings As New PrinterSettings
            oPrintDialog.AllowSomePages = True
            oPrintDialog.AllowSelection = False
            oPrintDialog.PrintToFile = False
            oPrinterSettings.MinimumPage = 0
            oPrinterSettings.MaximumPage = oMODIDocument.Images.Count - 1
            oPrinterSettings.FromPage = 0
            oPrinterSettings.ToPage = oMODIDocument.Images.Count - 1
            oPrintDialog.PrinterSettings = oPrinterSettings
            If oPrintDialog.ShowDialog() = DialogResult.OK Then
                oMODIDocument.PrintOut(oPrintDialog.PrinterSettings.FromPage, oPrintDialog.PrinterSettings.ToPage, oPrintDialog.PrinterSettings.Copies, oPrintDialog.PrinterSettings.PrinterName, "", False, MODI.MiPRINT_FITMODES.miPRINT_ACTUALSIZE)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnPan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPan.Click
        Try
            docView.DocViewMode = MODI.MiDocviewMode.miDOCVIEWMODE_CONTINOUSPAGEVIEW
            docView.ActionState = MODI.MiActionState.miASTATE_PAN
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        Try
            docView.ActionState = MODI.MiActionState.miASTATE_SELECT
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomOut.Click
        Try
            Dim sx As Double = 0, sy As Double = 0
            docView.FitMode = MODI.MiFITMODE.miFree
            docView.GetScale(sx, sy)
            docView.SetScale(sx * 1.1, sx * 1.1)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZoomIn.Click
        Try
            Dim sx As Double = 0, sy As Double = 0
            docView.FitMode = MODI.MiFITMODE.miFree
            docView.GetScale(sx, sy)
            docView.SetScale(sx * 0.9, sx * 0.9)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnFitWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFitWidth.Click
        Try
            docView.FitMode = MODI.MiFITMODE.miByWidth
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnFitHeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFitHeight.Click
        Try
            docView.FitMode = MODI.MiFITMODE.miByHeight
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnShowSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSingle.Click
        Try
            docView.DocViewMode = MODI.MiDocviewMode.miDOCVIEWMODE_SINGLEPAGEVIEW
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnShowContinous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowContinous.Click
        Try
            docView.DocViewMode = MODI.MiDocviewMode.miDOCVIEWMODE_CONTINOUSPAGEVIEW
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnShowTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowTwo.Click
        Try
            docView.DocViewMode = MODI.MiDocviewMode.miDOCVIEWMODE_TWOCOLUMNS_CONTINOUSPAGEVIEW
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnRotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateLeft.Click
        Try
            Dim img As MODI.Image = oMODIDocument.Images.Item(docView.PageNum)
            img.Rotate(270)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnRotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRotateRight.Click
        Try
            Dim img As MODI.Image = oMODIDocument.Images.Item(docView.PageNum)
            img.Rotate(90)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Try
            If docView.PageNum > 0 Then
                docView.PageNum = docView.PageNum - 1
                _showStatus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Try
            If docView.PageNum < docView.NumPages - 1 Then
                docView.PageNum = docView.PageNum + 1
                _showStatus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub docView_CurPageNumChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles docView.CurPageNumChanged
        _showStatus()
    End Sub
End Class
