Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class frmFind
    Public frm As RichtextStylePNA
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            Dim StartPosition As Integer
            Dim SearchType As StringComparison
            If chkMatchCase.Checked = True Then
                SearchType = StringComparison.Ordinal
            Else
                SearchType = StringComparison.OrdinalIgnoreCase
            End If
            StartPosition = frm.TextPNA.Text.IndexOf(txtSearchTerm.Text, SearchType)
            If StartPosition = 0 Then
                MessageBox.Show("String: " + txtSearchTerm.Text.ToString() + " not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
            End If
            frm.TextPNA.Select(StartPosition, txtSearchTerm.Text.Length)
            frm.TextPNA.ScrollToCaret()
            frm.Focus()
            btnFindNext.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnFindNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindNext.Click
        Try
            Dim StartPosition As Integer = frm.TextPNA.SelectionStart + 1
            Dim SearchType As StringComparison
            If chkMatchCase.Checked = True Then
                SearchType = StringComparison.Ordinal
            Else
                SearchType = StringComparison.OrdinalIgnoreCase
            End If
            StartPosition = frm.TextPNA.Text.IndexOf(txtSearchTerm.Text, StartPosition, SearchType)
            If StartPosition = 0 Or StartPosition < 0 Then
                frm.TextPNA.SelectionStart = 0
                StartPosition = frm.TextPNA.Text.IndexOf(txtSearchTerm.Text, StartPosition, SearchType)
                'MessageBox.Show("String: " + txtSearchTerm.Text.ToString() + " not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                'Exit Sub
            End If
            frm.TextPNA.Select(StartPosition, txtSearchTerm.Text.Length)
            frm.TextPNA.ScrollToCaret()
            frm.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class