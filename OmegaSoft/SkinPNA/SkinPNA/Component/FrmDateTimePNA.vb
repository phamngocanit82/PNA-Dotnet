Imports VB = Microsoft.VisualBasic
Imports System.Globalization
Imports System.Drawing
Imports clsOmegaSoft
Imports clsOmegaSoft.clsMethods
Public Class FrmDateTimePNA
#Region "ClassFrmDateTimePNA"
#Region "Enum"
    Public Enum StyleDateTime
        Style1 = 0
        Style2 = 1
        Style3 = 2
    End Enum
#End Region
#Region "Variables"
    Private _style As StyleDateTime = StyleDateTime.Style1
    Private _dsLanguage As New DataSet
    Private _intLanguage As Integer
    Private _intDay As Integer
    Private _intMonth As Integer
    Private _intYear As Integer
    Public _intLeft As Integer
    Public _intTop As Integer
#End Region
#Region "Properties"
    Public Property Style() As StyleDateTime
        Get
            Return _style
        End Get
        Set(ByVal Value As StyleDateTime)
            _style = Value
            cmbMonth.Style = Value
            txtYear.Style = Value
            btnLeft.Style = Value
            btnRight.Style = Value
            btnToday.Style = Value
        End Set
    End Property
    Public Property TDateTime() As String
        Get
            Dim _strTmp As String = ""
            Select Case _intLanguage
                Case 0
                    _strTmp = _getDayOrMonth(_intDay) & "/" & _getDayOrMonth(_intMonth) & "/" & _getDayOrMonth(_intYear)
                Case 1
                    _strTmp = _getDayOrMonth(_intMonth) & "/" & _getDayOrMonth(_intDay) & "/" & _getDayOrMonth(_intYear)
            End Select
            Return _strTmp
        End Get
        Set(ByVal Value As String)
            Select Case _intLanguage
                Case 0
                    _intDay = VB.Left(Value, 2)
                    _intMonth = VB.Mid(Value, 4, 2)
                    _intYear = VB.Right(Value, 4)
                Case 1
                    _intDay = VB.Mid(Value, 4, 2)
                    _intMonth = VB.Left(Value, 2)
                    _intYear = VB.Right(Value, 4)
            End Select
        End Set
    End Property
#End Region
#Region "Methods"
    Public Sub SetDate(ByVal intDay As Integer, ByVal intMonth As Integer, ByVal intYear As Integer)
        _intDay = intDay
        _intMonth = intMonth
        _intYear = intYear
    End Sub
    Private Function _getDayOrMonth(ByVal value As Integer) As String
        If value < 10 Then
            _getDayOrMonth = "0" & value.ToString
        Else
            _getDayOrMonth = value.ToString
        End If
    End Function
    Private Sub _setDay(ByVal value As OmegaSkins.LabelStyle2PNA)
        _intDay = CInt(value.Text)
        _intMonth = cmbMonth.SelectedIndex + 1
        _intYear = CInt(txtYear.Value)
        Visible = False
    End Sub
    Private Sub _loadMonth()
        Try
            Dim AppAssembly As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
            Dim i As Integer
            _dsLanguage.ReadXml(AppAssembly.GetManifestResourceStream("OmegaSkins.XMLDateTime.xml"))
            For i = 0 To 11
                cmbMonth.Items.Add(_dsLanguage.Tables(0).Rows(i).Item(_intLanguage + 1))
            Next i
            cmbMonth.SelectedIndex = CInt(Date.Today.Month) - 1
            lblDays1.Text = _dsLanguage.Tables(0).Rows(12).Item(_intLanguage + 1)
            lblDays2.Text = _dsLanguage.Tables(0).Rows(13).Item(_intLanguage + 1)
            lblDays3.Text = _dsLanguage.Tables(0).Rows(14).Item(_intLanguage + 1)
            lblDays4.Text = _dsLanguage.Tables(0).Rows(15).Item(_intLanguage + 1)
            lblDays5.Text = _dsLanguage.Tables(0).Rows(16).Item(_intLanguage + 1)
            lblDays6.Text = _dsLanguage.Tables(0).Rows(17).Item(_intLanguage + 1)
            lblDays7.Text = _dsLanguage.Tables(0).Rows(18).Item(_intLanguage + 1)
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FrmDateTimePNA._loadMonth)", , True)
        End Try
    End Sub
    Public Sub LoadDay()
        Try
            Dim i As Integer
            Dim intToday As Integer, intMonth As Integer, intYear As Integer
            Dim intDays As Integer, intWeek As Integer
            Dim myDateTime As New DateTime(txtYear.Value, cmbMonth.SelectedIndex + 1, 1)
            intDays = Date.DaysInMonth(txtYear.Value, cmbMonth.SelectedIndex + 1)
            intWeek = Weekday(myDateTime)
            intToday = Now.Day
            intMonth = Now.Month
            intYear = Now.Year
            If intWeek = 1 Then intWeek = 8
            For i = 2 To intWeek - 1
                Controls.Item(i - 2).Text = ""
                Controls.Item(i - 2).Enabled = False
                CType(Controls.Item(i - 2), OmegaSkins.LabelStyle2PNA).Style = LabelStyle2PNA.StyleLabel.Style3
            Next i
            For i = 1 To intDays
                Controls.Item(intWeek - 2).Text = i
                Controls.Item(intWeek - 2).Enabled = True
                If i = _intDay And _intMonth = (cmbMonth.SelectedIndex + 1) And _intYear = CInt(txtYear.Value) Then
                    CType(Controls.Item(intWeek - 2), OmegaSkins.LabelStyle2PNA).Style = LabelStyle2PNA.StyleLabel.Style1
                Else
                    If _intDay = i Or (intToday = i And intMonth = cmbMonth.SelectedIndex + 1 And intYear = CInt(txtYear.Value)) Then
                        If _intDay = i Then
                            CType(Controls.Item(intWeek - 2), OmegaSkins.LabelStyle2PNA).Style = LabelStyle2PNA.StyleLabel.Style2
                        Else
                            CType(Controls.Item(intWeek - 2), OmegaSkins.LabelStyle2PNA).Style = LabelStyle2PNA.StyleLabel.Style4
                        End If
                    Else
                        CType(Controls.Item(intWeek - 2), OmegaSkins.LabelStyle2PNA).Style = LabelStyle2PNA.StyleLabel.Style3
                    End If
                End If
                intWeek = intWeek + 1
            Next
            While (intWeek - 2) < 42
                Controls.Item(intWeek - 2).Text = ""
                Controls.Item(intWeek - 2).Enabled = False
                CType(Controls.Item(intWeek - 2), OmegaSkins.LabelStyle2PNA).Style = LabelStyle2PNA.StyleLabel.Style3
                intWeek = intWeek + 1
            End While
            btnToday.Text = _dsLanguage.Tables(0).Rows(19).Item(_intLanguage + 1)
            If _intLanguage = 0 Then
                btnToday.Text = btnToday.Text & ": " & _getDayOrMonth(Now.Day) & "/" & _getDayOrMonth(Now.Month) & "/" & Now.Year
            Else
                btnToday.Text = btnToday.Text & ": " & _getDayOrMonth(Now.Month) & "/" & _getDayOrMonth(Now.Day) & "/" & Now.Year
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FrmDateTimePNA.LoadDay)", , True)
        End Try
    End Sub
#End Region
#Region "Events"
#Region "Days"
    Private Sub Day1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day1.Click
        _setDay(Day1)
    End Sub
    Private Sub Day2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day2.Click
        _setDay(Day2)
    End Sub
    Private Sub Day3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day3.Click
        _setDay(Day3)
    End Sub
    Private Sub Day4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day4.Click
        _setDay(Day4)
    End Sub
    Private Sub Day5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day5.Click
        _setDay(Day5)
    End Sub
    Private Sub Day6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day6.Click
        _setDay(Day6)
    End Sub
    Private Sub Day7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day7.Click
        _setDay(Day7)
    End Sub
    Private Sub Day8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day8.Click
        _setDay(Day8)
    End Sub
    Private Sub Day9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day9.Click
        _setDay(Day9)
    End Sub
    Private Sub Day10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day10.Click
        _setDay(Day10)
    End Sub
    Private Sub Day11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day11.Click
        _setDay(Day11)
    End Sub
    Private Sub Day12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day12.Click
        _setDay(Day12)
    End Sub
    Private Sub Day13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day13.Click
        _setDay(Day13)
    End Sub
    Private Sub Day14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day14.Click
        _setDay(Day14)
    End Sub
    Private Sub Day15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day15.Click
        _setDay(Day15)
    End Sub
    Private Sub Day16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day16.Click
        _setDay(Day16)
    End Sub
    Private Sub Day17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day17.Click
        _setDay(Day17)
    End Sub
    Private Sub Day18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day18.Click
        _setDay(Day18)
    End Sub
    Private Sub Day19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day19.Click
        _setDay(Day19)
    End Sub
    Private Sub Day20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day20.Click
        _setDay(Day20)
    End Sub
    Private Sub Day21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day21.Click
        _setDay(Day21)
    End Sub
    Private Sub Day22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day22.Click
        _setDay(Day22)
    End Sub
    Private Sub Day23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day23.Click
        _setDay(Day23)
    End Sub
    Private Sub Day24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day24.Click
        _setDay(Day24)
    End Sub
    Private Sub Day25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day25.Click
        _setDay(Day25)
    End Sub
    Private Sub Day26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day26.Click
        _setDay(Day26)
    End Sub
    Private Sub Day27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day27.Click
        _setDay(Day27)
    End Sub
    Private Sub Day28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day28.Click
        _setDay(Day28)
    End Sub
    Private Sub Day29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day29.Click
        _setDay(Day29)
    End Sub
    Private Sub Day30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day30.Click
        _setDay(Day30)
    End Sub
    Private Sub Day31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day31.Click
        _setDay(Day31)
    End Sub
    Private Sub Day32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day32.Click
        _setDay(Day32)
    End Sub
    Private Sub Day33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day33.Click
        _setDay(Day33)
    End Sub
    Private Sub Day34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day34.Click
        _setDay(Day34)
    End Sub
    Private Sub Day35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day35.Click
        _setDay(Day35)
    End Sub
    Private Sub Day36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day36.Click
        _setDay(Day36)
    End Sub
    Private Sub Day37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day37.Click
        _setDay(Day37)
    End Sub
    Private Sub Day38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day38.Click
        _setDay(Day38)
    End Sub
    Private Sub Day39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day39.Click
        _setDay(Day39)
    End Sub
    Private Sub Day40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day40.Click
        _setDay(Day40)
    End Sub
    Private Sub Day41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day41.Click
        _setDay(Day41)
    End Sub
    Private Sub Day42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Day42.Click
        _setDay(Day42)
    End Sub
#End Region
    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        Try
            SetDate(Now.Day, Now.Month, Now.Year)
            Visible = False
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FrmDateTimePNA.btnToday_Click)", , True)
        End Try
    End Sub
    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        Try
            If txtYear.Value > 1753 Then
                txtYear.Value = txtYear.Value - 1
                LoadDay()
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FrmDateTimePNA.btnLeft_Click)", , True)
        End Try
    End Sub
    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        Try
            If txtYear.Value < 9998 Then
                txtYear.Value = txtYear.Value + 1
                LoadDay()
            End If
        Catch ex As Exception
            ShowInfor(Nothing, "", ex.Message.ToString & "(FrmDateTimePNA.btnRight_Click)", , True)
        End Try
    End Sub
    Private Sub txtYear_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYear.KeyUp
        Try
            If txtYear.Value >= 1753 And txtYear.Value <= 9998 Then
                LoadDay()
            End If
        Catch ex As Exception
            _intYear = Now.Year
        End Try
    End Sub
    Private Sub cmbMonth_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedValueChanged
        LoadDay()
    End Sub
    Private Sub FrmDateTimePNA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Location = New Point(_intLeft, _intTop)
            Select Case clsConfig.GetLangPNA
                Case "VietNamese"
                    _intLanguage = 0
                Case "English"
                    _intLanguage = 1
            End Select
            _intDay = Now.Day
            _intMonth = Now.Month
            _intYear = Now.Year
            _loadMonth()
        Catch ex As Exception
            'ShowInfor(Nothing, "", ex.Message.ToString & "(FrmDateTimePNA.FrmDateTimePNA_Load)", , True)
        End Try
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Size = New System.Drawing.Size(198, 175)
    End Sub
    Private Sub FrmDateTimePNA_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Visible = False
    End Sub
#End Region
#End Region
End Class