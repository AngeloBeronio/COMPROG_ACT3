Module LoginModule
    Public Function LoginStudent(studentNo As String, currentForm As Form) As Boolean
        Select Case studentNo
            Case "03-0100-25"
                Form9.DiscountRate = 0.2D
                Form9.Label9.Text = "Male Uniform"
                Form6.Label17.Text = "Dela Cruz, Juan S."

            Case "03-0101-25"
                Form9.DiscountRate = 0D
                Form9.Label9.Text = "Female Uniform"
                Form6.Label17.Text = "Dimapa, Janine B."

            Case "04-0103-25"
                Form9.DiscountRate = 0D
                Form9.Label9.Text = "Male Uniform"
                Form6.Label17.Text = "De Castro, Noli C."

            Case Else
                MsgBox(
                    "Invalid student number.",
                    MsgBoxStyle.OkOnly,
                    "Verification Failed"
                )
                Return False
        End Select
        Return True
    End Function

End Module