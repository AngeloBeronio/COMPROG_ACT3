Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyNavHover(Button2)
        ApplyNavHover(Button3)
        ApplyNavHover(Button5)

        ApplyColorHover(Button1, Color.DodgerBlue, Color.MidnightBlue, Color.White, Color.White)
        ApplyColorHover(Button6, Color.White, Color.Green, Color.Green, Color.White)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentNo As String = TextBox1.Text.Trim()
        Dim frm9 As New Form9()

        If studentNo = "03-0100-25" Then
            frm9.DiscountRate = 0.2D
            frm9.Label9.Text = "Male Uniform"

        ElseIf studentNo = "03-0101-25" Then
            frm9.DiscountRate = 0D
            frm9.Label9.Text = "Female Uniform"

        ElseIf studentNo = "04-0103-25" Then
            frm9.DiscountRate = 0D
            frm9.Label9.Text = "Male Uniform"

        Else
            MessageBox.Show(
            "Invalid student number.",
            "Verification Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
            Exit Sub
        End If

        frm9.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Form6.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Form7.Show()
    End Sub
End Class
