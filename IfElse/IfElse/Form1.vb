Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        If num1 < num2 Then
            txtResult.Text = "The larger number is " & num2
        ElseIf num1 > num2 Then
            txtResult.Text = "The larger number is " & num1
        Else
            txtResult.Text = "They are equal"
        End If


    End Sub

End Class
