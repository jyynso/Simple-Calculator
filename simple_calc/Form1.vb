Public Class Calculator

    Dim firstNum As Double
    Dim operation As String

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text &= "1"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text &= "2"
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text &= "3"
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text &= "4"
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text &= "5"
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text &= "6"
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text &= "7"
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text &= "8"
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text &= "9"
    End Sub

    Private Sub Btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "+"
        txtDisplay.Text = ""
    End Sub

    Private Sub Btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "-"
        txtDisplay.Text = ""
    End Sub

    Private Sub Btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "*"
        txtDisplay.Text = ""
    End Sub

    Private Sub Btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "/"
        txtDisplay.Text = ""
    End Sub
    Private Sub Btnequals_Click(sender As Object, e As EventArgs) Handles btnequals.Click
        Dim secondNum As Double = CDbl(txtDisplay.Text)
        Dim result As Double

        Select Case operation
            Case "+"
                result = firstNum + secondNum
            Case "-"
                result = firstNum - secondNum
            Case "*"
                result = firstNum * secondNum
            Case "/"
                result = firstNum / secondNum
        End Select

        txtDisplay.Text = result.ToString()
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtDisplay.Text = ""
    End Sub


End Class

