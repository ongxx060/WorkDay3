Option Strict On

Public Class Form1

    Private Property largerNum As Double

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largeNum As Double

        If IsNumeric(txtFirstNum.Text) Or IsNumeric(txtSecondNum.Text) Then
            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            If (num1 > num2) Then
                txtResult.Text = "Larger number is" & num1
            ElseIf (num2 < num1) Then

                txtResult.Text = "Larger number is" & num2

            Else
                txtResult.Text = "the two are equal"

            End If

        Else

            MessageBox.Show("Error: Please type a number")
            Return
        End If
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)
        If (num1 > num2) Then
            textresult.text = "larger number is" & num1
        ElseIf (num2 > num1) Then
            txtResult.Text = "larger number is" & num2
        Else
            txtResult.Text = "the two are equal"
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
