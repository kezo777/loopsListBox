Public Class Form1
    Private Sub btnCalk_Click(sender As Object, e As EventArgs) Handles btnCalk.Click
        Dim resultLine As String
        Dim symbol As String = "*"

        Output.Text = ""

        For index = 1 To 7
            resultLine = ""
            For i = 1 To index
                resultLine += symbol
            Next
            Output.Text += resultLine & vbNewLine
        Next

    End Sub

    Private Sub btnTask2_Click(sender As Object, e As EventArgs) Handles btnTask2.Click
        Dim resultLine As String
        Dim symbol As String = "*"

        Output.Text = ""

        For index = 7 To 1 Step -1
            resultLine = ""
            For i = index To 1 Step -1
                resultLine += symbol
            Next
            Output.Text += resultLine & vbNewLine
        Next
    End Sub
End Class
