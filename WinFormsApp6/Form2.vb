Public Class Form2

    Public DiscountRate As Decimal = 0D

    Dim tuitionFee As Decimal = 6000D
    Dim booksFee As Decimal = 3500D
    Dim uniformFee As Decimal = 450D
    Dim peAttireFee As Decimal = 900D
    Dim schoolServiceFee As Decimal = 5000D

    Private Function GetQty(cmb As ComboBox) As Integer
        If cmb.SelectedItem Is Nothing Then Return 0

        Dim qty As Integer
        If Integer.TryParse(cmb.SelectedItem.ToString().Trim(), qty) Then
            Return qty
        End If

        Return 0
    End Function

    Private Sub CalculateTotal()
        Dim total As Decimal = 0D


        If CheckBox1.Checked Then
            Dim rowTotal = tuitionFee * GetQty(ComboBox1)
            Label26.Text = "₱" & rowTotal.ToString("N2")
            total += rowTotal
        Else
            Label26.Text = "₱0.00"
        End If


        If CheckBox2.Checked Then
            Dim rowTotal = booksFee * GetQty(ComboBox3)
            Label27.Text = "₱" & rowTotal.ToString("N2")
            total += rowTotal
        Else
            Label27.Text = "₱0.00"
        End If


        If CheckBox3.Checked Then
            Dim rowTotal = uniformFee * GetQty(ComboBox4)
            Label28.Text = "₱" & rowTotal.ToString("N2")
            total += rowTotal
        Else
            Label28.Text = "₱0.00"
        End If


        If CheckBox4.Checked Then
            Dim rowTotal = peAttireFee * GetQty(ComboBox5)
            Label29.Text = "₱" & rowTotal.ToString("N2")
            total += rowTotal
        Else
            Label29.Text = "₱0.00"
        End If


        If CheckBox5.Checked Then
            Dim rowTotal = schoolServiceFee * GetQty(ComboBox2)
            Label30.Text = "₱" & rowTotal.ToString("N2")
            total += rowTotal
        Else
            Label30.Text = "₱0.00"
        End If

        Dim discountedTotal As Decimal = total - (total * DiscountRate)

        Label31.Text = "₱" & discountedTotal.ToString("N2")
    End Sub


    Private Sub UpdateComboStates()
        ComboBox1.Enabled = CheckBox1.Checked
        ComboBox3.Enabled = CheckBox2.Checked
        ComboBox4.Enabled = CheckBox3.Checked
        ComboBox5.Enabled = CheckBox4.Checked
        ComboBox2.Enabled = CheckBox5.Checked
    End Sub

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) _
    Handles CheckBox1.CheckedChanged,
            CheckBox2.CheckedChanged,
            CheckBox3.CheckedChanged,
            CheckBox4.CheckedChanged,
            CheckBox5.CheckedChanged

        If CheckBox2.Checked Then
            ComboBox2.SelectedItem = 1
        Else
            ComboBox2.SelectedIndex = 0
        End If

        UpdateComboStates()
        CalculateTotal()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label21.Text = "₱" & tuitionFee.ToString("N2")
        Label22.Text = "₱" & booksFee.ToString("N2")
        Label23.Text = "₱" & uniformFee.ToString("N2")
        Label24.Text = "₱" & peAttireFee.ToString("N2")
        Label25.Text = "₱" & schoolServiceFee.ToString("N2")


        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        ComboBox5.SelectedIndex = 0

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False

        UpdateComboStates()
    End Sub

    Private Sub ComboBoxes_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboBox1.SelectedIndexChanged,
                ComboBox2.SelectedIndexChanged,
                ComboBox3.SelectedIndexChanged,
                ComboBox4.SelectedIndexChanged,
                ComboBox5.SelectedIndexChanged

        CalculateTotal()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form3.Show()
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
        Me.Hide()
        Form5.Show()
    End Sub
End Class