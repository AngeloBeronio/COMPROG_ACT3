Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form7
    Dim frm9 As New Form9()

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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

End Class