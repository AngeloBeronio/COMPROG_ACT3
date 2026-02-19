Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Enabled = False
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        ComboBox5.Enabled = False

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ComboBox1.Enabled = CheckBox1.Checked
        If Not CheckBox1.Checked Then
            ComboBox1.SelectedIndex = 0
            ListBox1.Items.Remove("Basketball - Php 3000")
            ListBox1.Items.Remove("Basketball - Php 3500")
            ListBox1.Items.Remove("Basketball - Php 5000")
            GetTotal()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ComboBox3.Enabled = CheckBox2.Checked
        If Not CheckBox2.Checked Then
            ComboBox3.SelectedIndex = 0
            ListBox1.Items.Remove("Volleyball - Php 5000")
            ListBox1.Items.Remove("Volleyball - Php 6000")
            ListBox1.Items.Remove("Volleyball - Php 7000")
            GetTotal()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ComboBox4.Enabled = CheckBox3.Checked
        If Not CheckBox3.Checked Then
            ComboBox4.SelectedIndex = 0
            ListBox1.Items.Remove("Swimming - Php 3000")
            ListBox1.Items.Remove("Swimming - Php 3500")
            ListBox1.Items.Remove("Swimming - Php 5000")
            GetTotal()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        ComboBox5.Enabled = CheckBox4.Checked
        If Not CheckBox4.Checked Then
            ComboBox5.SelectedIndex = 0
            ListBox1.Items.Remove("Ballet - Php 5000")
            ListBox1.Items.Remove("Ballet - Php 6000")
            ListBox1.Items.Remove("Ballet - Php 7000")
            GetTotal()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        ComboBox2.Enabled = CheckBox5.Checked
        If Not CheckBox5.Checked Then
            ComboBox2.SelectedIndex = 0
            ListBox1.Items.Remove("Volleyball - Php 5000")
            ListBox1.Items.Remove("Volleyball - Php 6000")
            ListBox1.Items.Remove("Volleyball - Php 7000")
            GetTotal()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If CheckBox1.Checked Then
            ListBox1.Items.Remove("Basketball - Php 3000")
            ListBox1.Items.Remove("Basketball - Php 3500")
            ListBox1.Items.Remove("Basketball - Php 5000")
            Select Case ComboBox1.SelectedItem.ToString()
                Case "Basic - ₱3000" : ListBox1.Items.Add("Basketball - Php 3000")
                Case "Intermediate - ₱3500" : ListBox1.Items.Add("Basketball - Php 3500")
                Case "Advanced - ₱5000" : ListBox1.Items.Add("Basketball - Php 5000")
            End Select
            GetTotal()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If CheckBox5.Checked Then
            ListBox1.Items.Remove("Ballet - Php 5000")
            ListBox1.Items.Remove("Ballet - Php 6000")
            ListBox1.Items.Remove("Ballet - Php 7000")
            Select Case ComboBox2.SelectedItem.ToString()
                Case "Basic - ₱5000" : ListBox1.Items.Add("Ballet - Php 5000")
                Case "Intermediate - ₱6000" : ListBox1.Items.Add("Ballet - Php 6000")
                Case "Advanced - ₱7000" : ListBox1.Items.Add("Ballet - Php 7000")
            End Select
            GetTotal()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If CheckBox2.Checked Then
            ListBox1.Items.Remove("Volleyball - Php 3000")
            ListBox1.Items.Remove("Volleyball - Php 4500")
            ListBox1.Items.Remove("Volleyball - Php 5000")
            Select Case ComboBox3.SelectedItem.ToString()
                Case "Basic - ₱3000" : ListBox1.Items.Add("Volleyball - Php 3000")
                Case "Intermediate - ₱3500" : ListBox1.Items.Add("Volleyball - Php 3500")
                Case "Advanced - ₱5000" : ListBox1.Items.Add("Volleyball - Php 5000")
            End Select
            GetTotal()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If CheckBox3.Checked Then
            ListBox1.Items.Remove("Badminton - Php 3000")
            ListBox1.Items.Remove("Badminton - Php 3500")
            ListBox1.Items.Remove("Badminton - Php 5000")
            Select Case ComboBox4.SelectedItem.ToString()
                Case "Basic - ₱3000" : ListBox1.Items.Add("Badminton - Php 3000")
                Case "Intermediate - ₱3500" : ListBox1.Items.Add("Badminton - Php 3500")
                Case "Advanced - ₱5000" : ListBox1.Items.Add("Badminton - Php 5000")
            End Select
            GetTotal()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If CheckBox4.Checked Then
            ListBox1.Items.Remove("Swimming - Php 5000")
            ListBox1.Items.Remove("Swimming - Php 6000")
            ListBox1.Items.Remove("Swimming - Php 7000")
            Select Case ComboBox5.SelectedItem.ToString()
                Case "Basic - ₱5000" : ListBox1.Items.Add("Swimming - Php 5000")
                Case "Intermediate - ₱6000" : ListBox1.Items.Add("Swimming - Php 6000")
                Case "Advanced - ₱7000" : ListBox1.Items.Add("Swimming - Php 7000")
            End Select
            GetTotal()
        End If
    End Sub

    Private Sub UpdateComboStates()
        ComboBox1.Enabled = CheckBox1.Checked
        ComboBox4.Enabled = CheckBox3.Checked
        ComboBox5.Enabled = CheckBox4.Checked
        ComboBox2.Enabled = CheckBox5.Checked
        GetTotal()
    End Sub

    Private Sub ComboChanged()

    End Sub

    Private Sub GetTotal()
        Dim total As Decimal = 0D
        For Each item As String In ListBox1.Items
            If item.Contains("Php") Then
                Dim pricePart As String = item.Substring(item.LastIndexOf("Php") + 3).Trim()
                Dim price As Decimal
                If Decimal.TryParse(pricePart, price) Then
                    total += price
                End If
            End If
        Next
        Label14.Text = "Total: ₱ " & total.ToString("N2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Sent Application!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        Form3.Show()
    End Sub
End Class