Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim studentNo As String = TextBox1.Text.Trim()
        Dim frm2 As New Form2()

        If studentNo = "03-0100-25" Then
            frm2.DiscountRate = 0.2D   ' 20% discount

        ElseIf studentNo = "03-0101-25" Then
            frm2.DiscountRate = 0D     ' no discount

        Else
            MessageBox.Show(
            "Invalid student number.",
            "Verification Failed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )
            Exit Sub
        End If

        frm2.Show()
        Me.Hide()

    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MessageBox.Show(
    "Not working.",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MessageBox.Show(
    "Not working.",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
)
    End Sub
End Class
