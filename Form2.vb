Public Class Form2
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim English As Double
        Dim Afrikaans As Double
        Dim Xhosa As Double
        Dim average As Double
        English = Val(TextBox1.Text)
        Afrikaans = Val(TextBox2.Text)
        Xhosa = Val(TextBox3.Text)
        average = (English + Afrikaans + Xhosa) / 3
        TextBox4.Text = average
        If (average <= 39) Then
            MsgBox("You have failed, You idiot")

        End If
        If (average >= 40) And (average < 49) Then
            MsgBox("You get to rewrite, try harder nigga")
        End If
        If (average >= 50) And (average < 74) Then
            MsgBox("You have passed, meh")
        End If
        If (average >= 75) And (average <= 100) Then
            MsgBox("You have a distinction, congratulations babe")
        End If
    End Sub
End Class