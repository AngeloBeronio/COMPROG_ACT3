Public Class Form10
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyNavHover(Button2)
        ApplyNavHover(Button5)
        ApplyNavHover(Button3)

        ApplyColorHover(Button6, Color.White, Color.Green, Color.Green, Color.White)
        ApplyColorHover(Button1, Color.DodgerBlue, Color.MidnightBlue, Color.White, Color.White)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentNo As String = TextBox1.Text.Trim()
        If LoginStudent(studentNo, Me) Then
            Me.Hide()
            Form6.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Form7.Show()
    End Sub

End Class