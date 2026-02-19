Public Class Form6

    Dim MaxBorrow As Integer = 5
    Dim BorrowDays As Integer = 1

    Public Class Book
        Public Property ID As Integer
        Public Property Title As String
        Public Property Author As String
        Public Property Category As String
        Public Property IsAvailable As Boolean

        Public Sub New(id As Integer, title As String, author As String, category As String, available As Boolean)
            Me.ID = id
            Me.Title = title
            Me.Author = author
            Me.Category = category
            Me.IsAvailable = available
        End Sub
    End Class

    Private AllBooks As New List(Of Book)

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyNavHover(Button2)
        ApplyNavHover(Button5)
        ApplyNavHover(Button3)

        ApplyColorHover(Button6, Color.White, Color.Green, Color.Green, Color.White)
        ApplyColorHover(Button1, Color.DodgerBlue, Color.MidnightBlue, Color.White, Color.White)

        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Name"
        DataGridView1.Columns(2).Name = "Author"
        DataGridView1.Columns(3).Name = "Category"
        DataGridView1.Columns(4).Name = "Status"
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False

        CheckedListBox1.Items.Clear()
        For i As Integer = 1 To 140
            CheckedListBox1.Items.Add(i)
        Next

        LoadBooks()

        For Each cb As CheckBox In Panel7.Controls.OfType(Of CheckBox)()
            cb.Checked = True
        Next

        LoadSelectedCategories()
    End Sub

    Private Sub LoadBooks()
        AllBooks.Add(New Book(1, "Elementary Algebra", "Harold R. Jacobs", "Math", True))
        AllBooks.Add(New Book(2, "College Algebra", "Ron Larson", "Math", True))
        AllBooks.Add(New Book(3, "Basic Mathematics", "Serge Lang", "Math", True))
        AllBooks.Add(New Book(4, "Calculus Made Easy", "Silvanus P. Thompson", "Math", True))
        AllBooks.Add(New Book(5, "Calculus: Early Transcendentals", "James Stewart", "Math", True))
        AllBooks.Add(New Book(6, "Geometry Essentials", "John A. Van de Walle", "Math", True))
        AllBooks.Add(New Book(7, "Trigonometry", "Cynthia Y. Young", "Math", True))
        AllBooks.Add(New Book(8, "Linear Algebra", "David C. Lay", "Math", True))
        AllBooks.Add(New Book(9, "Discrete Mathematics", "Kenneth H. Rosen", "Math", True))
        AllBooks.Add(New Book(10, "Probability and Statistics", "Morris H. DeGroot", "Math", True))
        AllBooks.Add(New Book(11, "Advanced Algebra", "Anthony W. Knapp", "Math", True))
        AllBooks.Add(New Book(12, "Applied Mathematics", "J. David Logan", "Math", True))
        AllBooks.Add(New Book(13, "Engineering Mathematics", "K. A. Stroud", "Math", True))
        AllBooks.Add(New Book(14, "Modern Mathematics", "Ian Stewart", "Math", True))
        '
        AllBooks.Add(New Book(15, "General Science", "Paul G. Hewitt", "Science", True))
        AllBooks.Add(New Book(16, "Physics for Beginners", "Louis A. Bloomfield", "Science", True))
        AllBooks.Add(New Book(17, "Physics for Scientists and Engineers", "Raymond A. Serway", "Science", True))
        AllBooks.Add(New Book(18, "Biology Today", "Cecie Starr", "Science", True))
        AllBooks.Add(New Book(19, "Biology", "Neil A. Campbell", "Science", True))
        AllBooks.Add(New Book(20, "Chemistry Basics", "Karen C. Timberlake", "Science", True))
        AllBooks.Add(New Book(21, "Chemistry: The Central Science", "Theodore L. Brown", "Science", True))
        AllBooks.Add(New Book(22, "Earth Science", "Edward J. Tarbuck", "Science", True))
        AllBooks.Add(New Book(23, "Environmental Science", "G. Tyler Miller", "Science", True))
        AllBooks.Add(New Book(24, "Astronomy", "Michael A. Seeds", "Science", True))
        AllBooks.Add(New Book(25, "Human Anatomy", "Elaine N. Marieb", "Science", True))
        AllBooks.Add(New Book(26, "Microbiology", "Joan L. Slonczewski", "Science", True))
        AllBooks.Add(New Book(27, "Genetics", "Benjamin A. Pierce", "Science", True))
        AllBooks.Add(New Book(28, "Marine Science", "Alan A. Trujillo", "Science", True))
        '
        AllBooks.Add(New Book(29, "English Grammar in Use", "Raymond Murphy", "English", True))
        AllBooks.Add(New Book(30, "The Elements of Style", "William Strunk Jr.", "English", True))
        AllBooks.Add(New Book(31, "Practical English Usage", "Michael Swan", "English", True))
        AllBooks.Add(New Book(32, "Reading Comprehension Skills", "Harvey S. Wiener", "English", True))
        AllBooks.Add(New Book(33, "To Kill a Mockingbird", "Harper Lee", "English", True))
        AllBooks.Add(New Book(34, "Romeo and Juliet", "William Shakespeare", "English", True))
        AllBooks.Add(New Book(35, "The Great Gatsby", "F. Scott Fitzgerald", "English", True))
        AllBooks.Add(New Book(36, "1984", "George Orwell", "English", True))
        AllBooks.Add(New Book(37, "Animal Farm", "George Orwell", "English", True))
        AllBooks.Add(New Book(38, "Of Mice and Men", "John Steinbeck", "English", True))
        AllBooks.Add(New Book(39, "The Catcher in the Rye", "J. D. Salinger", "English", True))
        AllBooks.Add(New Book(40, "Lord of the Flies", "William Golding", "English", True))
        AllBooks.Add(New Book(41, "Macbeth", "William Shakespeare", "English", True))
        AllBooks.Add(New Book(42, "Pride and Prejudice", "Jane Austen", "English", True))
        '
        AllBooks.Add(New Book(43, "Noli Me Tangere", "Jose Rizal", "Filipino", True))
        AllBooks.Add(New Book(44, "El Filibusterismo", "Jose Rizal", "Filipino", True))
        AllBooks.Add(New Book(45, "Florante at Laura", "Francisco Balagtas", "Filipino", True))
        AllBooks.Add(New Book(46, "Ibong Adarna", "Anonymous", "Filipino", True))
        AllBooks.Add(New Book(47, "Banaag at Sikat", "Lope K. Santos", "Filipino", True))
        AllBooks.Add(New Book(48, "Mga Ibong Mandaragit", "Amado V. Hernandez", "Filipino", True))
        AllBooks.Add(New Book(49, "Dekada ’70", "Lualhati Bautista", "Filipino", True))
        AllBooks.Add(New Book(50, "Sa mga Kuko ng Liwanag", "Edgardo Reyes", "Filipino", True))
        AllBooks.Add(New Book(51, "Luha ng Buwaya", "Amado V. Hernandez", "Filipino", True))
        AllBooks.Add(New Book(52, "Ang Pagong at ang Matsing", "Jose Rizal", "Filipino", True))
        AllBooks.Add(New Book(53, "Alamat ng Pinya", "Anonymous", "Filipino", True))
        AllBooks.Add(New Book(54, "Alamat ng Sampaguita", "Anonymous", "Filipino", True))
        AllBooks.Add(New Book(55, "Florante at Laura (Illustrated)", "Francisco Balagtas", "Filipino", True))
        AllBooks.Add(New Book(56, "Balarila ng Wikang Filipino", "Lope K. Santos", "Filipino", True))
        '
        AllBooks.Add(New Book(57, "Health Today", "John W. Santrock", "Health", True))
        AllBooks.Add(New Book(58, "Physical Education Essentials", "Deborah A. Wuest", "Health", True))
        AllBooks.Add(New Book(59, "Nutrition Basics", "Judith E. Brown", "Health", True))
        AllBooks.Add(New Book(60, "Mental Health Awareness", "James Morrison", "Health", True))
        AllBooks.Add(New Book(61, "Human Wellness", "Travis Heath", "Health", True))
        AllBooks.Add(New Book(62, "Healthy Living", "William C. Shiel Jr.", "Health", True))
        AllBooks.Add(New Book(63, "First Aid Manual", "American Red Cross", "Health", True))
        AllBooks.Add(New Book(64, "Personal Fitness", "Charles B. Corbin", "Health", True))
        AllBooks.Add(New Book(65, "Stress Management", "Edward P. Sarafino", "Health", True))
        AllBooks.Add(New Book(66, "Public Health 101", "Richard Riegelman", "Health", True))
        AllBooks.Add(New Book(67, "Health and Safety", "Paul Insel", "Health", True))
        AllBooks.Add(New Book(68, "Teen Health", "Glencoe McGraw-Hill", "Health", True))
        AllBooks.Add(New Book(69, "Food and Nutrition", "Sari Edelstein", "Health", True))
        AllBooks.Add(New Book(70, "Mental Wellness", "Kay Redfield Jamison", "Health", True))
        '
        AllBooks.Add(New Book(71, "Geography of the World", "H. J. de Blij", "Geography", True))
        AllBooks.Add(New Book(72, "Human Geography", "Alexander B. Murphy", "Geography", True))
        AllBooks.Add(New Book(73, "Physical Geography", "James F. Petersen", "Geography", True))
        AllBooks.Add(New Book(74, "World Atlas", "National Geographic Society", "Geography", True))
        AllBooks.Add(New Book(75, "Cultural Geography", "Paul Knox", "Geography", True))
        AllBooks.Add(New Book(76, "Economic Geography", "Gordon L. Clark", "Geography", True))
        AllBooks.Add(New Book(77, "Population Geography", "John I. Clarke", "Geography", True))
        AllBooks.Add(New Book(78, "Urban Geography", "Tim Hall", "Geography", True))
        AllBooks.Add(New Book(79, "Environmental Geography", "Andrew Goudie", "Geography", True))
        AllBooks.Add(New Book(80, "Climate Change Geography", "David E. Alexander", "Geography", True))
        AllBooks.Add(New Book(81, "Maps and Mapping", "Jerry Brotton", "Geography", True))
        AllBooks.Add(New Book(82, "Geopolitics", "Gearóid Ó Tuathail", "Geography", True))
        AllBooks.Add(New Book(83, "Earth Landscapes", "Michael Summerfield", "Geography", True))
        AllBooks.Add(New Book(84, "Regional Geography", "Peter Haggett", "Geography", True))
        '
        AllBooks.Add(New Book(85, "Philippine History", "Teodoro A. Agoncillo", "History", True))
        AllBooks.Add(New Book(86, "World History", "Howard Spodek", "History", True))
        AllBooks.Add(New Book(87, "History of the Filipino People", "Teodoro A. Agoncillo", "History", True))
        AllBooks.Add(New Book(88, "Asian Civilizations", "Norman Lowe", "History", True))
        AllBooks.Add(New Book(89, "A Short History of the Philippines", "Renato Constantino", "History", True))
        AllBooks.Add(New Book(90, "The Philippines: A Past Revisited", "Renato Constantino", "History", True))
        AllBooks.Add(New Book(91, "The Rise and Fall of Great Powers", "Paul Kennedy", "History", True))
        AllBooks.Add(New Book(92, "Guns, Germs, and Steel", "Jared Diamond", "History", True))
        AllBooks.Add(New Book(93, "Sapiens", "Yuval Noah Harari", "History", True))
        AllBooks.Add(New Book(94, "The Cold War", "John Lewis Gaddis", "History", True))
        AllBooks.Add(New Book(95, "Medieval Europe", "Chris Wickham", "History", True))
        AllBooks.Add(New Book(96, "Modern World History", "Ben Walsh", "History", True))
        AllBooks.Add(New Book(97, "Ancient Civilizations", "Charles Freeman", "History", True))
        AllBooks.Add(New Book(98, "Contemporary History", "Geoff Stewart", "History", True))
        '
        AllBooks.Add(New Book(99, "Oxford English Dictionary 2025", "Oxford University Press", "Dictionary", True))
        AllBooks.Add(New Book(100, "Merriam-Webster Dictionary 2024", "Merriam-Webster", "Dictionary", True))
        AllBooks.Add(New Book(101, "Cambridge English Dictionary", "Cambridge University Press", "Dictionary", True))
        AllBooks.Add(New Book(102, "Collins English Dictionary", "HarperCollins", "Dictionary", True))
        AllBooks.Add(New Book(103, "Longman Dictionary", "Pearson", "Dictionary", True))
        AllBooks.Add(New Book(104, "American Heritage Dictionary", "Houghton Mifflin", "Dictionary", True))
        AllBooks.Add(New Book(105, "Filipino-English Dictionary", "Leo James English", "Dictionary", True))
        AllBooks.Add(New Book(106, "English-Filipino Dictionary", "SWF", "Dictionary", True))
        AllBooks.Add(New Book(107, "Science Dictionary", "Oxford University Press", "Dictionary", True))
        AllBooks.Add(New Book(108, "Mathematics Dictionary", "James & James", "Dictionary", True))
        AllBooks.Add(New Book(109, "Medical Dictionary", "Dorland", "Dictionary", True))
        AllBooks.Add(New Book(110, "Legal Dictionary", "Bryan A. Garner", "Dictionary", True))
        AllBooks.Add(New Book(111, "Visual Dictionary", "DK Publishing", "Dictionary", True))
        AllBooks.Add(New Book(112, "Children's Picture Dictionary", "DK", "Dictionary", True))
        '
        AllBooks.Add(New Book(113, "Chess Set", "", "Board Game", True))
        AllBooks.Add(New Book(114, "Scrabble", "", "Board Game", True))
        AllBooks.Add(New Book(115, "Checkers", "", "Board Game", True))
        AllBooks.Add(New Book(116, "Monopoly", "", "Board Game", True))
        AllBooks.Add(New Book(117, "Uno", "", "Board Game", True))
        AllBooks.Add(New Book(118, "Clue", "", "Board Game", True))
        AllBooks.Add(New Book(119, "Risk", "", "Board Game", True))
        AllBooks.Add(New Book(120, "Battleship", "", "Board Game", True))
        AllBooks.Add(New Book(121, "Connect Four", "", "Board Game", True))
        AllBooks.Add(New Book(122, "Jenga", "", "Board Game", True))
        AllBooks.Add(New Book(123, "Snakes and Ladders", "", "Board Game", True))
        AllBooks.Add(New Book(124, "Ludo", "", "Board Game", True))
        AllBooks.Add(New Book(125, "Othello", "", "Board Game", True))
        AllBooks.Add(New Book(126, "Backgammon", "", "Board Game", True))
        '
        AllBooks.Add(New Book(127, "Pencil Set", "", "Drawing Material", True))
        AllBooks.Add(New Book(128, "Color Pencils", "", "Drawing Material", True))
        AllBooks.Add(New Book(129, "Charcoal Pencils", "", "Drawing Material", True))
        AllBooks.Add(New Book(130, "Graphite Sticks", "", "Drawing Material", True))
        AllBooks.Add(New Book(131, "Watercolor Set", "", "Drawing Material", True))
        AllBooks.Add(New Book(132, "Acrylic Paint Set", "", "Drawing Material", True))
        AllBooks.Add(New Book(133, "Oil Pastels", "", "Drawing Material", True))
        AllBooks.Add(New Book(134, "Sketch Pad", "", "Drawing Material", True))
        AllBooks.Add(New Book(135, "Drawing Board", "", "Drawing Material", True))
        AllBooks.Add(New Book(136, "Brush Set", "", "Drawing Material", True))
        AllBooks.Add(New Book(137, "Ink Pens", "", "Drawing Material", True))
        AllBooks.Add(New Book(138, "Eraser Set", "", "Drawing Material", True))
        AllBooks.Add(New Book(139, "Ruler and Compass Set", "", "Drawing Material", True))
        AllBooks.Add(New Book(140, "Calligraphy Pens", "", "Drawing Material", True))
    End Sub


    Private Sub LoadSelectedCategories()
        DataGridView1.Rows.Clear()

        Dim selectedCategories As New List(Of String)

        If CheckBox1.Checked Then selectedCategories.Add("Math")
        If CheckBox2.Checked Then selectedCategories.Add("Science")
        If CheckBox3.Checked Then selectedCategories.Add("English")
        If CheckBox4.Checked Then selectedCategories.Add("Filipino")
        If CheckBox5.Checked Then selectedCategories.Add("Health")
        If CheckBox6.Checked Then selectedCategories.Add("Geography")
        If CheckBox7.Checked Then selectedCategories.Add("History")
        If CheckBox8.Checked Then selectedCategories.Add("Dictionary")
        If CheckBox9.Checked Then selectedCategories.Add("Board Game")
        If CheckBox10.Checked Then selectedCategories.Add("Drawing Material")

        For Each b In AllBooks
            If selectedCategories.Contains(b.Category) Then
                Dim statusText As String = If(b.IsAvailable, "Available", "Unavailable")
                DataGridView1.Rows.Add(b.ID, b.Title, b.Author, b.Category, statusText)
            End If
        Next
    End Sub

    Private Sub Category_CheckedChanged(sender As Object, e As EventArgs)
        For Each cb As CheckBox In Panel7.Controls.OfType(Of CheckBox)()
            AddHandler cb.CheckedChanged, AddressOf Category_CheckedChanged
        Next

        LoadSelectedCategories()
    End Sub

    Private Sub UpdateBorrowList()
        ListBox1.Items.Clear()

        If CheckedListBox1.CheckedItems.Count = 0 Then
            Label14.Text = "Total Items: 0"
            Exit Sub
        End If

        If CheckedListBox1.CheckedItems.Count > MaxBorrow Then
            MessageBox.Show("You can only borrow up to 5 items.")
            Exit Sub
        End If

        For Each checkedId As Integer In CheckedListBox1.CheckedItems
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.IsNewRow Then Continue For

                If CInt(row.Cells(0).Value) = checkedId Then
                    If row.Cells(4).Value.ToString() = "Unavailable" Then
                        MessageBox.Show("This item is Unavailable.")
                        CheckedListBox1.SetItemChecked(
                        CheckedListBox1.CheckedItems.IndexOf(checkedId),
                        False
                    )
                        Exit Sub
                    End If
                    ListBox1.Items.Add(row.Cells(1).Value & " — " & row.Cells(3).Value)
                    Exit For
                End If
            Next
        Next

        Label14.Text = "Total Items: " & CheckedListBox1.CheckedItems.Count
    End Sub


    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) _
        Handles CheckedListBox1.ItemCheck
        BeginInvoke(New Action(AddressOf UpdateBorrowList))
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ListBox1.SelectedIndexChanged
        Label14.Text = "Total Items: " & ListBox1.Items.Count
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then BorrowDays = 1
        UpdateDueDate()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then BorrowDays = 3
        UpdateDueDate()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then BorrowDays = 7
        UpdateDueDate()
    End Sub

    Private Sub UpdateDueDate()
        If Not RadioButton1.Checked AndAlso
           Not RadioButton2.Checked AndAlso
           Not RadioButton3.Checked Then
            Label15.Text = "Due Date: None Selected"
            Return
        End If

        Label15.Text = "Due Date: " &
            Date.Now.AddDays(BorrowDays).ToString("MMMM dd, yyyy")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        For Each cb As CheckBox In Panel7.Controls.OfType(Of CheckBox)()
            cb.Checked = False
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each checkedId As Integer In CheckedListBox1.CheckedItems
            Dim book = AllBooks.FirstOrDefault(Function(b) b.ID = checkedId)
            If book IsNot Nothing Then
                book.IsAvailable = False
            End If
        Next

        LoadSelectedCategories()

        For Each rb As RadioButton In Panel12.Controls.OfType(Of RadioButton)()
            rb.Checked = False
        Next
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
        MsgBox("Borrow request submitted!", MsgBoxStyle.Information, "Success")
        Me.Hide()
        Form3.Show()
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
End Class
