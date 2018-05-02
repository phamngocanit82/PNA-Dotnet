Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class CalculatorStylePNA
    Dim _dblResult As Double = 0
    Dim _dblCurrent As Double = 0
    Dim _strTmp As String = ""
    Dim _strChr As String = ""
    Dim _flag As Boolean = False
#Region "Methods"
    Private Sub _reset()
        _dblResult = 0
        _dblCurrent = 0
        _strTmp = ""
        _strChr = ""
        _flag = False
        txtResult.Text = _dblResult
    End Sub
    Private Sub _setNumber(ByVal btn As DevExpress.XtraEditors.SimpleButton)
        Try
            If _strChr <> "" Then
                _dblResult = CDbl(txtResult.Text)
                _strTmp = _strChr
                txtResult.Text = "0"
                _strChr = ""
            End If
            Select Case btn.Text.Trim
                Case "0"
                    If txtResult.Text.Trim = "0" Then Exit Select
                    txtResult.Text = txtResult.Text & btn.Text.Trim
                Case "1", "2", "3", "4", "5", "6", "7", "8", "9"
                    If txtResult.Text.Trim = "0" Then
                        txtResult.Text = ""
                    End If
                    txtResult.Text = txtResult.Text & btn.Text.Trim
                Case "."
                    If _flag = False Then
                        If txtResult.Text.Trim = "0" Then
                            txtResult.Text = "0"
                            _flag = True
                            txtResult.Text = txtResult.Text & btn.Text.Trim
                        ElseIf txtResult.Text.Trim <> "0" Then
                            txtResult.Text = txtResult.Text & btn.Text.Trim
                            _flag = True
                        Else
                            Exit Select
                        End If
                    End If
                Case "DEL"
                    If txtResult.Text.Trim = "0" Then Exit Select
                    If txtResult.Text.Length < 1 Then Exit Select
                    txtResult.Text = _dblCurrent
                    txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1)
                    If txtResult.Text = "" Then txtResult.Text = "0"
            End Select
            _dblCurrent = CDbl(txtResult.Text)
        Catch ex As Exception
            _reset()
        End Try
    End Sub
    Private Sub _setChr(ByVal btn As DevExpress.XtraEditors.SimpleButton)
        Try
            Select Case btn.Text.Trim
                Case "+", "-", "x", "/"
                    If _strTmp <> "" Then _calculator()
                    _strChr = btn.Text.Trim()
                Case "="
                    If _strTmp <> "" Then _calculator()
                    _dblCurrent = _dblResult
                Case "Sqrt"
                    If _dblCurrent < 0 Then
                        _dblCurrent = 0
                    Else
                        _dblCurrent = Math.Sqrt(_dblCurrent)
                    End If
                Case "1/x"
                    If _dblCurrent = 0 Then
                        _dblCurrent = 0
                    Else
                        _dblCurrent = 1 / _dblCurrent
                    End If
                Case "%"
                    _dblCurrent = _dblCurrent / 100
                Case "+/-"
                    If _dblCurrent > 0 Then
                        _dblCurrent = -_dblCurrent
                    Else
                        _dblCurrent = -_dblCurrent
                    End If
                Case "CE"
                    _dblCurrent = 0
            End Select
            _dblResult = _dblCurrent
            txtResult.Text = _dblResult
            _flag = False
        Catch ex As Exception
            _reset()
        End Try
    End Sub
    Private Sub _calculator()
        Try
            Select Case _strTmp
                Case "+"
                    _dblResult = _dblResult + _dblCurrent
                Case "-"
                    _dblResult = _dblResult - _dblCurrent
                Case "x"
                    _dblResult = _dblResult * _dblCurrent
                Case "/"
                    If _dblCurrent = 0 Then
                        _dblResult = 0
                    Else
                        _dblResult = _dblResult / _dblCurrent
                    End If
            End Select
            _strTmp = ""
            txtResult.Text = _dblResult
        Catch ex As Exception
            _reset()
        End Try
    End Sub
#End Region
    Private Sub CalculatorStylePNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _reset()
    End Sub
    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        _setNumber(btn0)
    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        _setNumber(btn1)
    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        _setNumber(btn2)
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        _setNumber(btn3)
    End Sub
    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        _setNumber(btn4)
    End Sub
    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        _setNumber(btn5)
    End Sub
    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        _setNumber(btn6)
    End Sub
    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        _setNumber(btn7)
    End Sub
    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        _setNumber(btn8)
    End Sub
    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        _setNumber(btn9)
    End Sub
    Private Sub btnPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoint.Click
        _setNumber(btnPoint)
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        _setChr(btnAdd)
    End Sub
    Private Sub btnLess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLess.Click
        _setChr(btnLess)
    End Sub
    Private Sub btnMutiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMutiply.Click
        _setChr(btnMutiply)
    End Sub
    Private Sub btnDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivide.Click
        _setChr(btnDivide)
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        _reset()
    End Sub
    Private Sub btnAqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAqual.Click
        _setChr(btnAqual)
    End Sub
    Private Sub btnAddLess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLess.Click
        _setChr(btnAddLess)
    End Sub
    Private Sub btnSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSqrt.Click
        _setChr(btnSqrt)
    End Sub
    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        _setChr(btnX)
    End Sub
    Private Sub btnPercent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPercent.Click
        _setChr(btnPercent)
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        _setNumber(btnDel)
    End Sub
    Private Sub btnCe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCe.Click
        _setChr(btnCe)
    End Sub
End Class
