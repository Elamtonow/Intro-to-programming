Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strStudents(10) As String
        Dim intMarks(10) As Integer
        Dim intCount As Integer

        strStudents(0) = "Nthando "
        strStudents(1) = "Elam"
        strStudents(2) = "Christine"
        strStudents(3) = "Samantha"
        strStudents(4) = "Sphumze"
        strStudents(5) = "Likho"
        strStudents(6) = "Olefile"
        strStudents(7) = "Shaunice"
        strStudents(8) = "Mariam"
        strStudents(9) = "Tinashe"



        intMarks(0) = "30 "
        intMarks(1) = "100"
        intMarks(2) = "80"
        intMarks(3) = "70"
        intMarks(4) = "5"
        intMarks(5) = "90"
        intMarks(6) = "100"
        intMarks(7) = "30"
        intMarks(8) = "50"
        intMarks(9) = "2"

        intCount = 0
        Do While intCount < intMarks.Length - 1
            MsgBox(strStudents(intCount) + " :  " + intMarks(intCount).ToString)
            intCount += 1
        Loop






    End Sub
End Class
