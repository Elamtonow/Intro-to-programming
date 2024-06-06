Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hoursworked As Double
        Dim hourlyrate As Double
        Dim gross As Double
        Dim deductions As Double
        Dim nettpay As Double
        hoursworked = Val(TextBox1.Text)
        hourlyrate = Val(TextBox2.Text)
        gross = hoursworked * hourlyrate
        deductions = gross * 0.2
        nettpay = gross - deductions
        TextBox3.Text = gross
        TextBox4.Text = deductions
        TextBox5.Text = nettpay

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
