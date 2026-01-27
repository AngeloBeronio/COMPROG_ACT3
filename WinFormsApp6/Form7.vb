Public Class Form7
    Dim frm9 As New Form9()

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyNavHover(Button2)
        ApplyNavHover(Button3)
        ApplyNavHover(Button4)
        ApplyNavHover(Button5)

        ApplyColorHover(Button1, Color.DodgerBlue, Color.MidnightBlue, Color.White, Color.White)

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox3.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox4.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox5.Text) OrElse
           ComboBox1.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(TextBox6.Text) OrElse
           String.IsNullOrWhiteSpace(TextBox7.Text) OrElse
           ComboBox2.SelectedItem Is Nothing OrElse
           String.IsNullOrWhiteSpace(TextBox8.Text) OrElse
           ComboBox3.SelectedItem Is Nothing Then

            MessageBox.Show("Please complete all required fields.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Form2.SelectedSex = ComboBox1.SelectedItem.ToString()
        Form2.SelectedGrade = ComboBox2.SelectedItem.ToString()

        If ComboBox3.SelectedItem.ToString() = "Yes" Then
            Form2.DiscountRate = 0.2D
        Else
            Form2.DiscountRate = 0D
        End If

        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class