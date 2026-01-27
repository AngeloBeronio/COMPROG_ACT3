Public Class Form6
    Dim total As Double

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyNavHover(Button2)
        ApplyNavHover(Button5)
        ApplyNavHover(Button3)

        ApplyColorHover(Button6, Color.White, Color.Green, Color.Green, Color.White)
        ApplyColorHover(Button1, Color.DodgerBlue, Color.MidnightBlue, Color.White, Color.White)
        DataGridView1.ColumnCount = 5

        For i As Integer = 1 To 140
            CheckedListBox1.Items.Add(i)
        Next

        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Name"
        DataGridView1.Columns(2).Name = "Author"
        DataGridView1.Columns(3).Name = "Categories"
        DataGridView1.Columns(4).Name = "Available"

    End Sub
    Private Sub radioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(1, "Elementary Algebra", "Harold R. Jacobs", "Math", 5)
        DataGridView1.Rows.Add(2, "College Algebra", "Ron Larson", "Math", 4)
        DataGridView1.Rows.Add(3, "Basic Mathematics", "Serge Lang", "Math", 6)
        DataGridView1.Rows.Add(4, "Calculus Made Easy", "Silvanus P. Thompson", "Math", 3)
        DataGridView1.Rows.Add(5, "Calculus: Early Transcendentals", "James Stewart", "Math", 2)
        DataGridView1.Rows.Add(6, "Geometry Essentials", "John A. Van de Walle", "Math", 5)
        DataGridView1.Rows.Add(7, "Trigonometry", "Cynthia Y. Young", "Math", 4)
        DataGridView1.Rows.Add(8, "Linear Algebra", "David C. Lay", "Math", 3)
        DataGridView1.Rows.Add(9, "Discrete Mathematics", "Kenneth H. Rosen", "Math", 4)
        DataGridView1.Rows.Add(10, "Probability and Statistics", "Morris H. DeGroot", "Math", 2)
        DataGridView1.Rows.Add(11, "Advanced Algebra", "Anthony W. Knapp", "Math", 3)
        DataGridView1.Rows.Add(12, "Applied Mathematics", "J. David Logan", "Math", 4)
        DataGridView1.Rows.Add(13, "Engineering Mathematics", "K. A. Stroud", "Math", 5)
        DataGridView1.Rows.Add(14, "Modern Mathematics", "Ian Stewart", "Math", 3)
    End Sub

    Private Sub radioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(15, "General Science", "Paul G. Hewitt", "Science", 5)
        DataGridView1.Rows.Add(16, "Physics for Beginners", "Louis A. Bloomfield", "Science", 3)
        DataGridView1.Rows.Add(17, "Physics for Scientists and Engineers", "Raymond A. Serway", "Science", 2)
        DataGridView1.Rows.Add(18, "Biology Today", "Cecie Starr", "Science", 5)
        DataGridView1.Rows.Add(19, "Biology", "Neil A. Campbell", "Science", 4)
        DataGridView1.Rows.Add(20, "Chemistry Basics", "Karen C. Timberlake", "Science", 4)
        DataGridView1.Rows.Add(21, "Chemistry: The Central Science", "Theodore L. Brown", "Science", 3)
        DataGridView1.Rows.Add(22, "Earth Science", "Edward J. Tarbuck", "Science", 4)
        DataGridView1.Rows.Add(23, "Environmental Science", "G. Tyler Miller", "Science", 2)
        DataGridView1.Rows.Add(24, "Astronomy", "Michael A. Seeds", "Science", 3)
        DataGridView1.Rows.Add(25, "Human Anatomy", "Elaine N. Marieb", "Science", 4)
        DataGridView1.Rows.Add(26, "Microbiology", "Joan L. Slonczewski", "Science", 3)
        DataGridView1.Rows.Add(27, "Genetics", "Benjamin A. Pierce", "Science", 2)
        DataGridView1.Rows.Add(28, "Marine Science", "Alan P. Trujillo", "Science", 3)
    End Sub
    Private Sub radioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(29, "English Grammar in Use", "Raymond Murphy", "English", 5)
        DataGridView1.Rows.Add(30, "The Elements of Style", "William Strunk Jr. and E. B. White", "English", 4)
        DataGridView1.Rows.Add(31, "Practical English Usage", "Michael Swan", "English", 3)
        DataGridView1.Rows.Add(32, "Reading Comprehension Skills", "Harvey S. Wiener", "English", 4)
        DataGridView1.Rows.Add(33, "To Kill a Mockingbird", "Nelle Harper Lee", "English", 5)
        DataGridView1.Rows.Add(34, "Romeo and Juliet", "William Shakespeare", "English", 6)
        DataGridView1.Rows.Add(35, "The Great Gatsby", "Francis Scott Key Fitzgerald", "English", 3)
        DataGridView1.Rows.Add(36, "1984", "George Orwell", "English", 4)
        DataGridView1.Rows.Add(37, "Animal Farm", "George Orwell", "English", 5)
        DataGridView1.Rows.Add(38, "Of Mice and Men", "John Steinbeck", "English", 3)
        DataGridView1.Rows.Add(39, "The Catcher in the Rye", "Jerome David Salinger", "English", 2)
        DataGridView1.Rows.Add(40, "Lord of the Flies", "William Golding", "English", 4)
        DataGridView1.Rows.Add(41, "Macbeth", "William Shakespeare", "English", 3)
        DataGridView1.Rows.Add(42, "Pride and Prejudice", "Jane Austen", "English", 5)
    End Sub
    Private Sub radioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(43, "Noli Me Tangere", "José Protasio Rizal Mercado y Alonso Realonda", "Filipino", 5)
        DataGridView1.Rows.Add(44, "El Filibusterismo", "José Protasio Rizal Mercado y Alonso Realonda", "Filipino", 4)
        DataGridView1.Rows.Add(45, "Florante at Laura", "Francisco Balagtas y de la Cruz", "Filipino", 3)
        DataGridView1.Rows.Add(46, "Ibong Adarna", "Anonymous", "Filipino", 6)
        DataGridView1.Rows.Add(47, "Banaag at Sikat", "Lope K. Santos", "Filipino", 3)
        DataGridView1.Rows.Add(48, "Mga Ibong Mandaragit", "Amado V. Hernandez", "Filipino", 4)
        DataGridView1.Rows.Add(49, "Dekada ’70", "Lualhati Bautista", "Filipino", 5)
        DataGridView1.Rows.Add(50, "Sa mga Kuko ng Liwanag", "Edgardo M. Reyes", "Filipino", 4)
        DataGridView1.Rows.Add(51, "Luha ng Buwaya", "Amado V. Hernandez", "Filipino", 3)
        DataGridView1.Rows.Add(52, "Ang Pagong at ang Matsing", "Jose Rizal", "Filipino", 6)
        DataGridView1.Rows.Add(53, "Alamat ng Pinya", "Anonymous", "Filipino", 5)
        DataGridView1.Rows.Add(54, "Alamat ng Sampaguita", "Anonymous", "Filipino", 4)
        DataGridView1.Rows.Add(55, "Florante at Laura (Illustrated)", "Francisco Balagtas", "Filipino", 2)
        DataGridView1.Rows.Add(56, "Balarila ng Wikang Filipino", "Lope K. Santos", "Filipino", 3)
    End Sub
    Private Sub radioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(57, "Health Today", "John W. Santrock", "Health", 5)
        DataGridView1.Rows.Add(58, "Physical Education Essentials", "Deborah A. Wuest", "Health", 4)
        DataGridView1.Rows.Add(59, "Nutrition Basics", "Judith E. Brown", "Health", 6)
        DataGridView1.Rows.Add(60, "Mental Health Awareness", "James Morrison", "Health", 3)
        DataGridView1.Rows.Add(61, "Human Wellness", "Travis Heath", "Health", 4)
        DataGridView1.Rows.Add(62, "Healthy Living", "William C. Shiel Jr.", "Health", 5)
        DataGridView1.Rows.Add(63, "First Aid Manual", "American Red Cross", "Health", 6)
        DataGridView1.Rows.Add(64, "Personal Fitness", "Charles B. Corbin", "Health", 3)
        DataGridView1.Rows.Add(65, "Stress Management", "Edward P. Sarafino", "Health", 4)
        DataGridView1.Rows.Add(66, "Public Health 101", "Richard Riegelman", "Health", 2)
        DataGridView1.Rows.Add(67, "Health and Safety", "Paul Insel", "Health", 5)
        DataGridView1.Rows.Add(68, "Teen Health", "Glencoe McGraw-Hill", "Health", 4)
        DataGridView1.Rows.Add(69, "Food and Nutrition", "Sari Edelstein", "Health", 3)
        DataGridView1.Rows.Add(70, "Mental Wellness", "Kay Redfield Jamison", "Health", 2)
    End Sub
    Private Sub radioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(71, "Geography of the World", "H. J. de Blij", "Geography", 5)
        DataGridView1.Rows.Add(72, "Human Geography", "Alexander B. Murphy", "Geography", 4)
        DataGridView1.Rows.Add(73, "Physical Geography", "James F. Petersen", "Geography", 3)
        DataGridView1.Rows.Add(74, "World Atlas", "National Geographic Society", "Geography", 6)
        DataGridView1.Rows.Add(75, "Cultural Geography", "Paul Knox", "Geography", 3)
        DataGridView1.Rows.Add(76, "Economic Geography", "Gordon L. Clark", "Geography", 4)
        DataGridView1.Rows.Add(77, "Population Geography", "John I. Clarke", "Geography", 2)
        DataGridView1.Rows.Add(78, "Urban Geography", "Tim Hall", "Geography", 4)
        DataGridView1.Rows.Add(79, "Environmental Geography", "Andrew Goudie", "Geography", 3)
        DataGridView1.Rows.Add(80, "Climate Change Geography", "David E. Alexander", "Geography", 2)
        DataGridView1.Rows.Add(81, "Maps and Mapping", "Jerry Brotton", "Geography", 5)
        DataGridView1.Rows.Add(82, "Geopolitics", "Gearóid Ó Tuathail", "Geography", 3)
        DataGridView1.Rows.Add(83, "Earth Landscapes", "Michael Summerfield", "Geography", 4)
        DataGridView1.Rows.Add(84, "Regional Geography", "Peter Haggett", "Geography", 2)
    End Sub
    Private Sub radioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(85, "Philippine History", "Teodoro A. Agoncillo", "History", 5)
        DataGridView1.Rows.Add(86, "World History", "Howard Spodek", "History", 4)
        DataGridView1.Rows.Add(87, "History of the Filipino People", "Teodoro A. Agoncillo", "History", 3)
        DataGridView1.Rows.Add(88, "Asian Civilizations", "Norman Lowe", "History", 4)
        DataGridView1.Rows.Add(89, "A Short History of the Philippines", "Renato Constantino", "History", 5)
        DataGridView1.Rows.Add(90, "The Philippines: A Past Revisited", "Renato Constantino", "History", 2)
        DataGridView1.Rows.Add(91, "The Rise and Fall of Great Powers", "Paul Kennedy", "History", 3)
        DataGridView1.Rows.Add(92, "Guns, Germs, and Steel", "Jared Diamond", "History", 4)
        DataGridView1.Rows.Add(93, "Sapiens: A Brief History of Humankind", "Yuval Noah Harari", "History", 5)
        DataGridView1.Rows.Add(94, "The Cold War", "John Lewis Gaddis", "History", 3)
        DataGridView1.Rows.Add(95, "Medieval Europe", "Chris Wickham", "History", 2)
        DataGridView1.Rows.Add(96, "Modern World History", "Ben Walsh", "History", 4)
        DataGridView1.Rows.Add(97, "Ancient Civilizations", "Charles Freeman", "History", 3)
        DataGridView1.Rows.Add(98, "Contemporary History", "Geoff Stewart", "History", 2)
    End Sub
    Private Sub radioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(99, "Oxford English Dictionary 2025", "Oxford University Press", "Dictionary", 5)
        DataGridView1.Rows.Add(100, "Merriam-Webster Dictionary 2024", "Merriam-Webster Inc.", "Dictionary", 4)
        DataGridView1.Rows.Add(101, "Cambridge English Dictionary", "Cambridge University Press", "Dictionary", 3)
        DataGridView1.Rows.Add(102, "Collins English Dictionary", "HarperCollins Publishers", "Dictionary", 4)
        DataGridView1.Rows.Add(103, "Longman Dictionary of Contemporary English", "Pearson Education", "Dictionary", 5)
        DataGridView1.Rows.Add(104, "American Heritage Dictionary", "Houghton Mifflin Harcourt", "Dictionary", 3)
        DataGridView1.Rows.Add(105, "Filipino-English Dictionary", "Leo James English", "Dictionary", 4)
        DataGridView1.Rows.Add(106, "English-Filipino Dictionary", "Sentrong Wikang Filipino", "Dictionary", 3)
        DataGridView1.Rows.Add(107, "Science Dictionary", "Oxford University Press", "Dictionary", 4)
        DataGridView1.Rows.Add(108, "Mathematics Dictionary", "James & James Publishers", "Dictionary", 2)
        DataGridView1.Rows.Add(109, "Medical Dictionary", "Dorland Publishing", "Dictionary", 3)
        DataGridView1.Rows.Add(110, "Legal Dictionary", "Bryan A. Garner", "Dictionary", 2)
        DataGridView1.Rows.Add(111, "Visual Dictionary", "DK Publishing", "Dictionary", 5)
        DataGridView1.Rows.Add(112, "Children's Picture Dictionary", "Dorling Kindersley", "Dictionary", 6)
    End Sub

    Private Sub radioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(113, "Chess Set", "", "Board Game", 6)
        DataGridView1.Rows.Add(114, "Scrabble", "", "Board Game", 5)
        DataGridView1.Rows.Add(115, "Checkers", "", "Board Game", 4)
        DataGridView1.Rows.Add(116, "Monopoly", "", "Board Game", 3)
        DataGridView1.Rows.Add(117, "Uno", "", "Board Game", 6)
        DataGridView1.Rows.Add(118, "Clue", "", "Board Game", 2)
        DataGridView1.Rows.Add(119, "Risk", "", "Board Game", 3)
        DataGridView1.Rows.Add(120, "Battleship", "", "Board Game", 4)
        DataGridView1.Rows.Add(121, "Connect Four", "", "Board Game", 5)
        DataGridView1.Rows.Add(122, "Jenga", "", "Board Game", 6)
        DataGridView1.Rows.Add(123, "Snakes and Ladders", "", "Board Game", 5)
        DataGridView1.Rows.Add(124, "Ludo", "", "Board Game", 4)
        DataGridView1.Rows.Add(125, "Othello", "", "Board Game", 3)
        DataGridView1.Rows.Add(126, "Backgammon", "", "Board Game", 2)
    End Sub
    Private Sub radioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(127, "Pencil Set", "", "Drawing Material", 10)
        DataGridView1.Rows.Add(128, "Color Pencils", "", "Drawing Material", 8)
        DataGridView1.Rows.Add(129, "Charcoal Pencils", "", "Drawing Material", 6)
        DataGridView1.Rows.Add(130, "Graphite Sticks", "", "Drawing Material", 5)
        DataGridView1.Rows.Add(131, "Watercolor Set", "", "Drawing Material", 4)
        DataGridView1.Rows.Add(132, "Acrylic Paint Set", "", "Drawing Material", 3)
        DataGridView1.Rows.Add(133, "Oil Pastels", "", "Drawing Material", 6)
        DataGridView1.Rows.Add(134, "Sketch Pad", "", "Drawing Material", 7)
        DataGridView1.Rows.Add(135, "Drawing Board", "", "Drawing Material", 2)
        DataGridView1.Rows.Add(136, "Brush Set", "", "Drawing Material", 5)
        DataGridView1.Rows.Add(137, "Ink Pens", "", "Drawing Material", 6)
        DataGridView1.Rows.Add(138, "Eraser Set", "", "Drawing Material", 8)
        DataGridView1.Rows.Add(139, "Ruler and Compass Set", "", "Drawing Material", 4)
        DataGridView1.Rows.Add(140, "Calligraphy Pens", "", "Drawing Material", 3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Form7.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckedListBox1.CheckedItems.Count = 0 Then
            MessageBox.Show("No books selected.")
            Exit Sub
        End If

        Dim borrowed As String = ""

        For Each checkedId As Integer In CheckedListBox1.CheckedItems

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.IsNewRow Then Continue For

                If Convert.ToInt32(row.Cells(0).Value) = checkedId Then
                    borrowed &= "- " & row.Cells(1).Value.ToString() & vbCrLf
                    Exit For
                End If
            Next

        Next

        MessageBox.Show(
            "You have borrowed:" & vbCrLf & vbCrLf & borrowed,
            "Borrowed Books"
        )

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class