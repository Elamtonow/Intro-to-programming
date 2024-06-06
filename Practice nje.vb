Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intEnterthenumber As Integer
        intEnterthenumber = TextBox1.Text
        If intEnterthenumber < 5 Then
            TextBox2.Text = "Nope order more babe"

        ElseIf intEnterthenumber <= 20 Then
            TextBox2.Text = "Scooter Delivery"
        ElseIf intEnterthenumber > 20 And intEnterthenumber <= 50 Then
            TextBox2.Text = "Car Delivery"
        ElseIf intEnterthenumber > 50 And IntEnterthenumber <= 100 Then
            TextBox2.Text = "Come and collect"
        ElseIf intEnterthenumber > 100 Then
            MsgBox("Can't make the order")
        End If
    End Sub
End Class
