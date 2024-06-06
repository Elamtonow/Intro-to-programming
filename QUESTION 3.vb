Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Iraq")
        ComboBox1.Items.Add("Germany")
        ComboBox1.Items.Add("South Africa")
        ComboBox1.Items.Add("Zimbabwe")
        ComboBox1.Items.Add("France")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strCountry As String
        Dim strCapital As String
        strCountry = ComboBox1.Text
        strCapital = TextBox1.Text
        If strCountry = "" Then

        End If
    End Sub
End Class
