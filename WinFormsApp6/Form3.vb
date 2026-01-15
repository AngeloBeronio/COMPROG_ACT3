Public Class Form3
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form4.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(
    "Not working.",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
    )
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(
    "Not working.",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
    )
    End Sub
End Class