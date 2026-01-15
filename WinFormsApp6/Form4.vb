Public Class Form4
    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form1.Show()
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