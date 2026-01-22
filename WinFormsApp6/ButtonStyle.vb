Module ButtonStyle
    Private navFont As New Font("Segoe UI", 21.75F, FontStyle.Bold)
    Private navHoverFont As New Font("Segoe UI", 22.0F, FontStyle.Bold)

    Public Sub ApplyNavHover(btn As Button)

        btn.Font = navFont
        btn.FlatStyle = FlatStyle.Flat
        btn.UseVisualStyleBackColor = False
        btn.BackColor = btn.Parent.BackColor
        btn.ForeColor = Color.DimGray
        btn.FlatAppearance.BorderSize = 0

        AddHandler btn.MouseEnter, AddressOf NavMouseEnter
        AddHandler btn.MouseLeave, AddressOf NavMouseLeave
    End Sub

    Private Sub NavMouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        btn.ForeColor = Color.MidnightBlue
        btn.Font = navHoverFont
    End Sub

    Private Sub NavMouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)

        btn.ForeColor = Color.DimGray
        btn.Font = navFont
    End Sub

    Public Sub ApplyColorHover(
        btn As Button,
        normalBack As Color,
        hoverBack As Color,
        normalText As Color,
        hoverText As Color)

        btn.BackColor = normalBack
        btn.ForeColor = normalText

        btn.Tag = New ButtonColors(
            normalBack,
            hoverBack,
            normalText,
            hoverText,
            btn.Size,
            btn.Location
        )

        AddHandler btn.MouseEnter, AddressOf ColorMouseEnter
        AddHandler btn.MouseLeave, AddressOf ColorMouseLeave
    End Sub

    Private Sub ColorMouseEnter(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim colors As ButtonColors = CType(btn.Tag, ButtonColors)

        btn.BackColor = colors.HoverBack
        btn.ForeColor = colors.HoverText

        btn.Location = New Point(
            colors.OriginalLocation.X - 4,
            colors.OriginalLocation.Y - 4
        )

        btn.Size = New Size(
            colors.OriginalSize.Width + 8,
            colors.OriginalSize.Height + 8
        )
    End Sub

    Private Sub ColorMouseLeave(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim colors As ButtonColors = CType(btn.Tag, ButtonColors)

        btn.BackColor = colors.NormalBack
        btn.ForeColor = colors.NormalText
        btn.Size = colors.OriginalSize
        btn.Location = colors.OriginalLocation
    End Sub

    Private Class ButtonColors
        Public NormalBack As Color
        Public HoverBack As Color
        Public NormalText As Color
        Public HoverText As Color
        Public OriginalSize As Size
        Public OriginalLocation As Point

        Public Sub New(
            nb As Color,
            hb As Color,
            nt As Color,
            ht As Color,
            size As Size,
            location As Point)

            NormalBack = nb
            HoverBack = hb
            NormalText = nt
            HoverText = ht
            OriginalSize = size
            OriginalLocation = location
        End Sub
    End Class
End Module
