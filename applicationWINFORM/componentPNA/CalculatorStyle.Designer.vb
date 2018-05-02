<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorStylePNA
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorStylePNA))
        Me.txtResult = New DevExpress.XtraEditors.TextEdit
        Me.btnDel = New DevExpress.XtraEditors.SimpleButton
        Me.btnCe = New DevExpress.XtraEditors.SimpleButton
        Me.btnC = New DevExpress.XtraEditors.SimpleButton
        Me.btnSqrt = New DevExpress.XtraEditors.SimpleButton
        Me.btnPercent = New DevExpress.XtraEditors.SimpleButton
        Me.btnX = New DevExpress.XtraEditors.SimpleButton
        Me.btnDivide = New DevExpress.XtraEditors.SimpleButton
        Me.btn7 = New DevExpress.XtraEditors.SimpleButton
        Me.btn8 = New DevExpress.XtraEditors.SimpleButton
        Me.btn9 = New DevExpress.XtraEditors.SimpleButton
        Me.btn4 = New DevExpress.XtraEditors.SimpleButton
        Me.btn5 = New DevExpress.XtraEditors.SimpleButton
        Me.btn6 = New DevExpress.XtraEditors.SimpleButton
        Me.btn1 = New DevExpress.XtraEditors.SimpleButton
        Me.btn2 = New DevExpress.XtraEditors.SimpleButton
        Me.btn3 = New DevExpress.XtraEditors.SimpleButton
        Me.btn0 = New DevExpress.XtraEditors.SimpleButton
        Me.btnAddLess = New DevExpress.XtraEditors.SimpleButton
        Me.btnPoint = New DevExpress.XtraEditors.SimpleButton
        Me.btnMutiply = New DevExpress.XtraEditors.SimpleButton
        Me.btnLess = New DevExpress.XtraEditors.SimpleButton
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton
        Me.btnAqual = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtResult.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtResult
        '
        Me.txtResult.EditValue = "0"
        Me.txtResult.Location = New System.Drawing.Point(8, 12)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txtResult.Properties.Appearance.Options.UseFont = True
        Me.txtResult.Properties.Appearance.Options.UseTextOptions = True
        Me.txtResult.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtResult.Properties.MaxLength = 20
        Me.txtResult.Size = New System.Drawing.Size(140, 21)
        Me.txtResult.TabIndex = 6
        '
        'btnDel
        '
        Me.btnDel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnDel.Appearance.Options.UseFont = True
        Me.btnDel.Appearance.Options.UseForeColor = True
        Me.btnDel.Location = New System.Drawing.Point(8, 38)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(68, 18)
        Me.btnDel.TabIndex = 9
        Me.btnDel.Text = "DEL"
        '
        'btnCe
        '
        Me.btnCe.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCe.Appearance.Options.UseFont = True
        Me.btnCe.Location = New System.Drawing.Point(80, 38)
        Me.btnCe.Name = "btnCe"
        Me.btnCe.Size = New System.Drawing.Size(32, 18)
        Me.btnCe.TabIndex = 10
        Me.btnCe.Text = "CE"
        '
        'btnC
        '
        Me.btnC.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Appearance.Options.UseFont = True
        Me.btnC.Location = New System.Drawing.Point(116, 38)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(32, 18)
        Me.btnC.TabIndex = 11
        Me.btnC.Text = "C"
        '
        'btnSqrt
        '
        Me.btnSqrt.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqrt.Appearance.Options.UseFont = True
        Me.btnSqrt.Location = New System.Drawing.Point(8, 60)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(32, 18)
        Me.btnSqrt.TabIndex = 12
        Me.btnSqrt.Text = "Sqrt"
        '
        'btnPercent
        '
        Me.btnPercent.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercent.Appearance.Options.UseFont = True
        Me.btnPercent.Location = New System.Drawing.Point(44, 60)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(32, 18)
        Me.btnPercent.TabIndex = 13
        Me.btnPercent.Text = "%"
        '
        'btnX
        '
        Me.btnX.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.Appearance.Options.UseFont = True
        Me.btnX.Location = New System.Drawing.Point(80, 60)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(32, 18)
        Me.btnX.TabIndex = 14
        Me.btnX.Text = "1/X"
        '
        'btnDivide
        '
        Me.btnDivide.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Appearance.Options.UseFont = True
        Me.btnDivide.Location = New System.Drawing.Point(116, 60)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(32, 18)
        Me.btnDivide.TabIndex = 15
        Me.btnDivide.Text = "/"
        '
        'btn7
        '
        Me.btn7.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Appearance.Options.UseFont = True
        Me.btn7.Location = New System.Drawing.Point(8, 82)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(32, 18)
        Me.btn7.TabIndex = 16
        Me.btn7.Text = "7"
        '
        'btn8
        '
        Me.btn8.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Appearance.Options.UseFont = True
        Me.btn8.Location = New System.Drawing.Point(44, 82)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(32, 18)
        Me.btn8.TabIndex = 17
        Me.btn8.Text = "8"
        '
        'btn9
        '
        Me.btn9.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Appearance.Options.UseFont = True
        Me.btn9.Location = New System.Drawing.Point(80, 82)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(32, 18)
        Me.btn9.TabIndex = 18
        Me.btn9.Text = "9"
        '
        'btn4
        '
        Me.btn4.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Appearance.Options.UseFont = True
        Me.btn4.Location = New System.Drawing.Point(8, 103)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(32, 18)
        Me.btn4.TabIndex = 19
        Me.btn4.Text = "4"
        '
        'btn5
        '
        Me.btn5.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Appearance.Options.UseFont = True
        Me.btn5.Location = New System.Drawing.Point(44, 103)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(32, 18)
        Me.btn5.TabIndex = 20
        Me.btn5.Text = "5"
        '
        'btn6
        '
        Me.btn6.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Appearance.Options.UseFont = True
        Me.btn6.Location = New System.Drawing.Point(80, 103)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(32, 18)
        Me.btn6.TabIndex = 21
        Me.btn6.Text = "6"
        '
        'btn1
        '
        Me.btn1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Appearance.Options.UseFont = True
        Me.btn1.Location = New System.Drawing.Point(8, 125)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(32, 18)
        Me.btn1.TabIndex = 22
        Me.btn1.Text = "1"
        '
        'btn2
        '
        Me.btn2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Appearance.Options.UseFont = True
        Me.btn2.Location = New System.Drawing.Point(44, 125)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(32, 18)
        Me.btn2.TabIndex = 23
        Me.btn2.Text = "2"
        '
        'btn3
        '
        Me.btn3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Appearance.Options.UseFont = True
        Me.btn3.Location = New System.Drawing.Point(80, 125)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(32, 18)
        Me.btn3.TabIndex = 24
        Me.btn3.Text = "3"
        '
        'btn0
        '
        Me.btn0.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Appearance.Options.UseFont = True
        Me.btn0.Location = New System.Drawing.Point(8, 147)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(32, 18)
        Me.btn0.TabIndex = 25
        Me.btn0.Text = "0"
        '
        'btnAddLess
        '
        Me.btnAddLess.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLess.Appearance.Options.UseFont = True
        Me.btnAddLess.Location = New System.Drawing.Point(44, 147)
        Me.btnAddLess.Name = "btnAddLess"
        Me.btnAddLess.Size = New System.Drawing.Size(32, 18)
        Me.btnAddLess.TabIndex = 26
        Me.btnAddLess.Text = "+/-"
        '
        'btnPoint
        '
        Me.btnPoint.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoint.Appearance.Options.UseFont = True
        Me.btnPoint.Appearance.Options.UseTextOptions = True
        Me.btnPoint.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.btnPoint.Location = New System.Drawing.Point(80, 147)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(32, 18)
        Me.btnPoint.TabIndex = 27
        Me.btnPoint.Text = "."
        '
        'btnMutiply
        '
        Me.btnMutiply.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMutiply.Appearance.Options.UseFont = True
        Me.btnMutiply.Location = New System.Drawing.Point(116, 82)
        Me.btnMutiply.Name = "btnMutiply"
        Me.btnMutiply.Size = New System.Drawing.Size(32, 18)
        Me.btnMutiply.TabIndex = 28
        Me.btnMutiply.Text = "x"
        '
        'btnLess
        '
        Me.btnLess.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLess.Appearance.Options.UseFont = True
        Me.btnLess.Location = New System.Drawing.Point(116, 103)
        Me.btnLess.Name = "btnLess"
        Me.btnLess.Size = New System.Drawing.Size(32, 18)
        Me.btnLess.TabIndex = 29
        Me.btnLess.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.Location = New System.Drawing.Point(116, 125)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 18)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "+"
        '
        'btnAqual
        '
        Me.btnAqual.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAqual.Appearance.Options.UseFont = True
        Me.btnAqual.Location = New System.Drawing.Point(116, 147)
        Me.btnAqual.Name = "btnAqual"
        Me.btnAqual.Size = New System.Drawing.Size(32, 18)
        Me.btnAqual.TabIndex = 31
        Me.btnAqual.Text = "="
        '
        'CalculatorStylePNA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.btnAqual)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnLess)
        Me.Controls.Add(Me.btnMutiply)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btnAddLess)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnPercent)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnCe)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtResult)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CalculatorStylePNA"
        Me.Size = New System.Drawing.Size(157, 175)
        CType(Me.txtResult.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents txtResult As DevExpress.XtraEditors.TextEdit
    Public WithEvents btnDel As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnCe As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnC As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnSqrt As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnPercent As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnX As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnDivide As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn7 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn8 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn9 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn4 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn5 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn6 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn1 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn2 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn3 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btn0 As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAddLess As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnPoint As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnMutiply As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnLess As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Public WithEvents btnAqual As DevExpress.XtraEditors.SimpleButton

End Class
