Option Strict On

Public Class Form1

    Private Property largerNum As Double

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largeNum As Double
        num1 = CDbl(txtFirstNum.Text)
        num1 = CDbl(txtSecondNum.Text)
        If (num1 > num2) Then
            txtResult.Text = "the larger number is" & num1
            largerNum = num1
        ElseIf (num1 < num2) Then
            largeNum = num2
            txtResult.Text = "The larger number is" & num2

        Else
            txtResult.Text = "they are equal"

        End If

    End Sub
End Class
