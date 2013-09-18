Option Strict On

Public Class Form1

    Private Property largerNum As Double

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largeNum As Double
        num1 = CDbl(txtFirstNum.Text)
        num1 = CDbl(txtSecondNum.Text)
        If (num1 > num2) Then
            largerNum = num1
        Else
            largeNum = num2

        End If
        txtResult.Text = "The larger number is" & largerNum
    End Sub
End Class
