Public Class frmFindReplace
    Public frm As RichtextStylePNA
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            Dim StartPosition As Integer
            Dim SearchType As CompareMethod
            If chkMatchCase.Checked = True Then
                SearchType = CompareMethod.Binary
            Else
                SearchType = CompareMethod.Text
            End If
            StartPosition = InStr(1, frm.TextPNA.Text, txtSearchTerm.Text, SearchType)
            If StartPosition = 0 Then
                '  MessageBox.Show("String: '" & txtSearchTerm.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            frm.TextPNA.Select(StartPosition - 1, txtSearchTerm.Text.Length)
            frm.TextPNA.ScrollToCaret()
            frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click
        Try
            Dim StartPosition As Integer = frm.TextPNA.SelectionStart + 2
            Dim SearchType As CompareMethod
            If chkMatchCase.Checked = True Then
                SearchType = CompareMethod.Binary
            Else
                SearchType = CompareMethod.Text
            End If
            StartPosition = InStr(StartPosition, frm.TextPNA.Text, txtSearchTerm.Text, SearchType)
            If StartPosition = 0 Then
                ' MessageBox.Show("String: '" & txtSearchTerm.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            frm.TextPNA.Select(StartPosition - 1, txtSearchTerm.Text.Length)
            frm.TextPNA.ScrollToCaret()
            frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        Try
            If frm.TextPNA.SelectedText.Length <> 0 Then
                frm.TextPNA.SelectedText = txtReplacementText.Text
            End If
            Dim StartPosition As Integer = frm.TextPNA.SelectionStart + 2
            Dim SearchType As CompareMethod
            If chkMatchCase.Checked = True Then
                SearchType = CompareMethod.Binary
            Else
                SearchType = CompareMethod.Text
            End If
            StartPosition = InStr(StartPosition, frm.TextPNA.Text, txtSearchTerm.Text, SearchType)

            If StartPosition = 0 Then
                ' MessageBox.Show("String: '" & txtSearchTerm.Text.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            frm.TextPNA.Select(StartPosition - 1, txtSearchTerm.Text.Length)
            frm.TextPNA.ScrollToCaret()
            frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click
        Try
            Dim currentPosition As Integer = frm.TextPNA.SelectionStart
            Dim currentSelect As Integer = frm.TextPNA.SelectionLength
            frm.TextPNA.Rtf = Replace(frm.TextPNA.Rtf, Trim(txtSearchTerm.Text), Trim(txtReplacementText.Text))
            frm.TextPNA.SelectionStart = currentPosition
            frm.TextPNA.SelectionLength = currentSelect
            frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class