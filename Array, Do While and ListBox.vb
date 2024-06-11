Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strName(4) As String
        Dim intCount As Integer
        strName(0) = "Elam"
        strName(1) = "Christine"
        strName(2) = "Samantha"
        strName(3) = "Mariam"

        intCount = 0
        Do While intCount < strName.Length - 1
            ListBox1.Items.Add(strName(intCount)).ToString()
            intCount += 1
        Loop

    End Sub
End Class
