Public Class Form9
    Public DiscountRate As Decimal = 0D
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyNavHover(Button2)
        ApplyNavHover(Button3)
        ApplyNavHover(Button5)

        ApplyColorHover(Button1, Color.DodgerBlue, Color.MidnightBlue, Color.White, Color.White)
        ApplyColorHover(Button6, Color.White, Color.Green, Color.Green, Color.White)

        cartItems.Add(New CartItem With {.checkBox = CheckBox1, .quantityUpDown = NumericUpDown1, .itemName = "Student Uniform", .unitPrice = 600D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox2, .quantityUpDown = NumericUpDown2, .itemName = "PE Attire", .unitPrice = 800D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox3, .quantityUpDown = NumericUpDown3, .itemName = "Lanyard", .unitPrice = 80D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox4, .quantityUpDown = NumericUpDown4, .itemName = "Shirt", .unitPrice = 700D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox5, .quantityUpDown = NumericUpDown5, .itemName = "Cap", .unitPrice = 350D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox6, .quantityUpDown = NumericUpDown6, .itemName = "Hoodie", .unitPrice = 1000D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox7, .quantityUpDown = NumericUpDown7, .itemName = "Umbrella", .unitPrice = 350D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox8, .quantityUpDown = NumericUpDown8, .itemName = "Pouch", .unitPrice = 200D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox9, .quantityUpDown = NumericUpDown9, .itemName = "Flask", .unitPrice = 700D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox10, .quantityUpDown = NumericUpDown10, .itemName = "Pen", .unitPrice = 30D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox11, .quantityUpDown = NumericUpDown11, .itemName = "Pencil", .unitPrice = 15D})
        cartItems.Add(New CartItem With {.checkBox = CheckBox12, .quantityUpDown = NumericUpDown12, .itemName = "Stickers", .unitPrice = 30D})
        UpdateQuantityStates()
        UpdateCart()
    End Sub

    Private Class CartItem
        Public checkBox As CheckBox
        Public quantityUpDown As NumericUpDown
        Public itemName As String
        Public unitPrice As Decimal
    End Class

    Private cartItems As New List(Of CartItem)

    Private Sub UpdateQuantityStates()
        For Each item In cartItems
            item.quantityUpDown.Enabled = item.checkBox.Checked
        Next
    End Sub

    Private Sub UpdateCart()
        Dim subtotal As Decimal = 0D
        CartList.Items.Clear()

        For Each item In cartItems
            If item.checkBox.Checked AndAlso item.quantityUpDown.Value > 0 Then
                Dim itemSubtotal = item.unitPrice * item.quantityUpDown.Value
                CartList.Items.Add(item.itemName & " x" & item.quantityUpDown.Value & " - ₱" & itemSubtotal.ToString("N2"))
                subtotal += itemSubtotal
            End If
        Next
        Dim discountAmount As Decimal = subtotal * DiscountRate
        Dim finalTotal As Decimal = subtotal - discountAmount

        Label35.Text = "Total: ₱" & finalTotal.ToString("N2")
    End Sub

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) _
        Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged,
                CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged,
                CheckBox7.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged,
                CheckBox10.CheckedChanged, CheckBox11.CheckedChanged, CheckBox12.CheckedChanged

        UpdateQuantityStates()
        UpdateCart()
    End Sub

    Private Sub QuantityUpDowns_ValueChanged(sender As Object, e As EventArgs) _
        Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged,
                NumericUpDown4.ValueChanged, NumericUpDown5.ValueChanged, NumericUpDown6.ValueChanged,
                NumericUpDown7.ValueChanged, NumericUpDown8.ValueChanged, NumericUpDown9.ValueChanged,
                NumericUpDown10.ValueChanged, NumericUpDown11.ValueChanged, NumericUpDown12.ValueChanged

        UpdateCart()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form5.Show()
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