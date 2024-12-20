<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn1 = New Button()
        txtDisplay = New TextBox()
        btn2 = New Button()
        btn3 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btndivide = New Button()
        btnmultiply = New Button()
        btnminus = New Button()
        btnclear = New Button()
        btn0 = New Button()
        btnplus = New Button()
        btnequals = New Button()
        SuspendLayout()
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.White
        btn1.FlatStyle = FlatStyle.Popup
        btn1.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Location = New Point(44, 357)
        btn1.Name = "btn1"
        btn1.Size = New Size(84, 60)
        btn1.TabIndex = 0
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Font = New Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDisplay.Location = New Point(84, 57)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(382, 42)
        txtDisplay.TabIndex = 1
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.White
        btn2.FlatStyle = FlatStyle.Popup
        btn2.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Location = New Point(172, 357)
        btn2.Name = "btn2"
        btn2.Size = New Size(84, 60)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.White
        btn3.FlatStyle = FlatStyle.Popup
        btn3.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Location = New Point(293, 357)
        btn3.Name = "btn3"
        btn3.Size = New Size(84, 60)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.White
        btn6.FlatStyle = FlatStyle.Popup
        btn6.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn6.Location = New Point(293, 250)
        btn6.Name = "btn6"
        btn6.Size = New Size(84, 60)
        btn6.TabIndex = 6
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.White
        btn5.FlatStyle = FlatStyle.Popup
        btn5.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn5.Location = New Point(172, 250)
        btn5.Name = "btn5"
        btn5.Size = New Size(84, 60)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.White
        btn4.FlatStyle = FlatStyle.Popup
        btn4.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Location = New Point(44, 250)
        btn4.Name = "btn4"
        btn4.Size = New Size(84, 60)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.White
        btn9.FlatStyle = FlatStyle.Popup
        btn9.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn9.Location = New Point(293, 147)
        btn9.Name = "btn9"
        btn9.Size = New Size(84, 60)
        btn9.TabIndex = 9
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.White
        btn8.FlatStyle = FlatStyle.Popup
        btn8.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn8.Location = New Point(172, 147)
        btn8.Name = "btn8"
        btn8.Size = New Size(84, 60)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.White
        btn7.FlatStyle = FlatStyle.Popup
        btn7.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn7.Location = New Point(44, 147)
        btn7.Name = "btn7"
        btn7.Size = New Size(84, 60)
        btn7.TabIndex = 7
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btndivide
        ' 
        btndivide.BackColor = Color.White
        btndivide.FlatStyle = FlatStyle.Popup
        btndivide.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndivide.Location = New Point(414, 147)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(84, 60)
        btndivide.TabIndex = 10
        btndivide.Text = "÷"
        btndivide.UseVisualStyleBackColor = False
        ' 
        ' btnmultiply
        ' 
        btnmultiply.BackColor = Color.White
        btnmultiply.FlatStyle = FlatStyle.Popup
        btnmultiply.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmultiply.Location = New Point(414, 250)
        btnmultiply.Name = "btnmultiply"
        btnmultiply.Size = New Size(84, 60)
        btnmultiply.TabIndex = 11
        btnmultiply.Text = "x"
        btnmultiply.UseVisualStyleBackColor = False
        ' 
        ' btnminus
        ' 
        btnminus.BackColor = Color.White
        btnminus.FlatStyle = FlatStyle.Popup
        btnminus.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnminus.Location = New Point(414, 357)
        btnminus.Name = "btnminus"
        btnminus.Size = New Size(84, 60)
        btnminus.TabIndex = 12
        btnminus.Text = "-"
        btnminus.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.White
        btnclear.FlatStyle = FlatStyle.Popup
        btnclear.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnclear.Location = New Point(172, 463)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(84, 60)
        btnclear.TabIndex = 13
        btnclear.Text = "Clear"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = Color.White
        btn0.FlatStyle = FlatStyle.Popup
        btn0.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn0.Location = New Point(44, 463)
        btn0.Name = "btn0"
        btn0.Size = New Size(84, 60)
        btn0.TabIndex = 14
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btnplus
        ' 
        btnplus.BackColor = Color.White
        btnplus.FlatStyle = FlatStyle.Popup
        btnplus.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnplus.Location = New Point(414, 463)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(84, 60)
        btnplus.TabIndex = 15
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = False
        ' 
        ' btnequals
        ' 
        btnequals.BackColor = Color.White
        btnequals.FlatStyle = FlatStyle.Popup
        btnequals.Font = New Font("Montserrat Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnequals.Location = New Point(293, 463)
        btnequals.Name = "btnequals"
        btnequals.Size = New Size(84, 60)
        btnequals.TabIndex = 16
        btnequals.Text = "="
        btnequals.UseVisualStyleBackColor = False
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(561, 603)
        Controls.Add(btnequals)
        Controls.Add(btnplus)
        Controls.Add(btn0)
        Controls.Add(btnclear)
        Controls.Add(btnminus)
        Controls.Add(btnmultiply)
        Controls.Add(btndivide)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(txtDisplay)
        Controls.Add(btn1)
        Name = "Calculator"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "   "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btnequals As Button

End Class
