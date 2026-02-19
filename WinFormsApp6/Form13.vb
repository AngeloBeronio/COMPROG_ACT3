Public Class Form13
    Public Class Classes
        Public Property SubjectID As String
        Public Property SubjectName As String
        Public Property GradeNo As Integer
        Public Property Section As String
        Public Property Teacher As String
    End Class

    Private ClassList As New List(Of Classes)

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChart()
        RefreshGrid(ClassList)

        PopulateGradeCombo(ComboBox1)
        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("All")
        ComboBox4.SelectedIndex = 0
        ComboBox7.Items.Clear()
        ComboBox7.Items.Add("All")
        For Each t In ClassList.Select(Function(c) c.Teacher).Distinct().OrderBy(Function(x) x)
            ComboBox7.Items.Add(t)
        Next
        ComboBox7.SelectedIndex = 0

        PopulateGradeCombo(ComboBox2)
        PopulateGradeCombo(ComboBox5)
        ComboBox6.Items.Clear()
    End Sub

    Private Sub LoadChart()
        ' -------------------- GRADE 1 --------------------
        ' Quartz
        ClassList.Add(New Classes With {.SubjectID = "MTH101", .SubjectName = "Mathematics", .GradeNo = 1, .Section = "Quartz", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG101", .SubjectName = "English", .GradeNo = 1, .Section = "Quartz", .Teacher = "Ron Delmundo"})
        ClassList.Add(New Classes With {.SubjectID = "AP101", .SubjectName = "Araling Panlipunan", .GradeNo = 1, .Section = "Quartz", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "FIL101", .SubjectName = "Filipino", .GradeNo = 1, .Section = "Quartz", .Teacher = "Gian Carlo Reyes"})
        ClassList.Add(New Classes With {.SubjectID = "MPE101", .SubjectName = "MAPEH", .GradeNo = 1, .Section = "Quartz", .Teacher = "Riley Bayani"})
        ClassList.Add(New Classes With {.SubjectID = "MTH102", .SubjectName = "Mathematics", .GradeNo = 1, .Section = "Quartz", .Teacher = "Aliyah Gomez"})

        ' Feldspar
        ClassList.Add(New Classes With {.SubjectID = "MTH101", .SubjectName = "Mathematics", .GradeNo = 1, .Section = "Feldspar", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG101", .SubjectName = "English", .GradeNo = 1, .Section = "Feldspar", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "AP101", .SubjectName = "Araling Panlipunan", .GradeNo = 1, .Section = "Feldspar", .Teacher = "Riley Bayani"})
        ClassList.Add(New Classes With {.SubjectID = "FIL101", .SubjectName = "Filipino", .GradeNo = 1, .Section = "Feldspar", .Teacher = "Gian Carlo Reyes"})
        ClassList.Add(New Classes With {.SubjectID = "MPE101", .SubjectName = "MAPEH", .GradeNo = 1, .Section = "Feldspar", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MTH102", .SubjectName = "Mathematics", .GradeNo = 1, .Section = "Feldspar", .Teacher = "Jason Rodriguez"})

        ' -------------------- GRADE 2 --------------------
        ' Calcite
        ClassList.Add(New Classes With {.SubjectID = "MTH201", .SubjectName = "Mathematics", .GradeNo = 2, .Section = "Calcite", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG201", .SubjectName = "English", .GradeNo = 2, .Section = "Calcite", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "AP201", .SubjectName = "Araling Panlipunan", .GradeNo = 2, .Section = "Calcite", .Teacher = "Darren Ronaldo"})
        ClassList.Add(New Classes With {.SubjectID = "FIL201", .SubjectName = "Filipino", .GradeNo = 2, .Section = "Calcite", .Teacher = "Gian Carlo Reyes"})
        ClassList.Add(New Classes With {.SubjectID = "MPE201", .SubjectName = "MAPEH", .GradeNo = 2, .Section = "Calcite", .Teacher = "Riley Bayani"})
        ClassList.Add(New Classes With {.SubjectID = "MTH202", .SubjectName = "Mathematics", .GradeNo = 2, .Section = "Calcite", .Teacher = "Aliyah Gomez"})

        ' Gypsum
        ClassList.Add(New Classes With {.SubjectID = "MTH201", .SubjectName = "Mathematics", .GradeNo = 2, .Section = "Gypsum", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG201", .SubjectName = "English", .GradeNo = 2, .Section = "Gypsum", .Teacher = "Ron Delmundo"})
        ClassList.Add(New Classes With {.SubjectID = "AP201", .SubjectName = "Araling Panlipunan", .GradeNo = 2, .Section = "Gypsum", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "FIL201", .SubjectName = "Filipino", .GradeNo = 2, .Section = "Gypsum", .Teacher = "Gian Carlo Reyes"})
        ClassList.Add(New Classes With {.SubjectID = "MPE201", .SubjectName = "MAPEH", .GradeNo = 2, .Section = "Gypsum", .Teacher = "Riley Bayani"})
        ClassList.Add(New Classes With {.SubjectID = "MTH202", .SubjectName = "Mathematics", .GradeNo = 2, .Section = "Gypsum", .Teacher = "Jason Rodriguez"})

        ' -------------------- GRADE 3 --------------------
        ' Marble
        ClassList.Add(New Classes With {.SubjectID = "MTH301", .SubjectName = "Mathematics", .GradeNo = 3, .Section = "Marble", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG301", .SubjectName = "English", .GradeNo = 3, .Section = "Marble", .Teacher = "Ron Delmundo"})
        ClassList.Add(New Classes With {.SubjectID = "SCI301", .SubjectName = "Science", .GradeNo = 3, .Section = "Marble", .Teacher = "Darren Ronaldo"})
        ClassList.Add(New Classes With {.SubjectID = "AP301", .SubjectName = "Araling Panlipunan", .GradeNo = 3, .Section = "Marble", .Teacher = "Marco Magising"})
        ClassList.Add(New Classes With {.SubjectID = "FIL301", .SubjectName = "Filipino", .GradeNo = 3, .Section = "Marble", .Teacher = "Gian Carlo Reyes"})
        ClassList.Add(New Classes With {.SubjectID = "MPE301", .SubjectName = "MAPEH", .GradeNo = 3, .Section = "Marble", .Teacher = "Riley Bayani"})

        ' Granite
        ClassList.Add(New Classes With {.SubjectID = "MTH301", .SubjectName = "Mathematics", .GradeNo = 3, .Section = "Granite", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG301", .SubjectName = "English", .GradeNo = 3, .Section = "Granite", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "SCI301", .SubjectName = "Science", .GradeNo = 3, .Section = "Granite", .Teacher = "Joseph Garcia"})
        ClassList.Add(New Classes With {.SubjectID = "AP301", .SubjectName = "Araling Panlipunan", .GradeNo = 3, .Section = "Granite", .Teacher = "Riley Bayani"})
        ClassList.Add(New Classes With {.SubjectID = "FIL301", .SubjectName = "Filipino", .GradeNo = 3, .Section = "Granite", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MPE301", .SubjectName = "MAPEH", .GradeNo = 3, .Section = "Granite", .Teacher = "Marco Magising"})

        ' -------------------- GRADE 4 --------------------
        ' Obsidian
        ClassList.Add(New Classes With {.SubjectID = "MTH401", .SubjectName = "Mathematics", .GradeNo = 4, .Section = "Obsidian", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG401", .SubjectName = "English", .GradeNo = 4, .Section = "Obsidian", .Teacher = "Ron Delmundo"})
        ClassList.Add(New Classes With {.SubjectID = "SCI401", .SubjectName = "Science", .GradeNo = 4, .Section = "Obsidian", .Teacher = "Darren Ronaldo"})
        ClassList.Add(New Classes With {.SubjectID = "AP401", .SubjectName = "Araling Panlipunan", .GradeNo = 4, .Section = "Obsidian", .Teacher = "Riley Bayani"})
        ClassList.Add(New Classes With {.SubjectID = "FIL401", .SubjectName = "Filipino", .GradeNo = 4, .Section = "Obsidian", .Teacher = "Gian Carlo Reyes"})
        ClassList.Add(New Classes With {.SubjectID = "MPE401", .SubjectName = "MAPEH", .GradeNo = 4, .Section = "Obsidian", .Teacher = "Riley Bayani"})

        ' Basalt
        ClassList.Add(New Classes With {.SubjectID = "MTH401", .SubjectName = "Mathematics", .GradeNo = 4, .Section = "Basalt", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG401", .SubjectName = "English", .GradeNo = 4, .Section = "Basalt", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "SCI401", .SubjectName = "Science", .GradeNo = 4, .Section = "Basalt", .Teacher = "Joseph Garcia"})
        ClassList.Add(New Classes With {.SubjectID = "AP401", .SubjectName = "Araling Panlipunan", .GradeNo = 4, .Section = "Basalt", .Teacher = "Marco Magising"})
        ClassList.Add(New Classes With {.SubjectID = "FIL401", .SubjectName = "Filipino", .GradeNo = 4, .Section = "Basalt", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MPE401", .SubjectName = "MAPEH", .GradeNo = 4, .Section = "Basalt", .Teacher = "Riley Bayani"})

        ' -------------------- GRADE 5 --------------------
        ' Sapphire
        ClassList.Add(New Classes With {.SubjectID = "MTH501", .SubjectName = "Mathematics", .GradeNo = 5, .Section = "Sapphire", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG501", .SubjectName = "English", .GradeNo = 5, .Section = "Sapphire", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "SCI501", .SubjectName = "Science", .GradeNo = 5, .Section = "Sapphire", .Teacher = "Joseph Garcia"})
        ClassList.Add(New Classes With {.SubjectID = "AP501", .SubjectName = "Araling Panlipunan", .GradeNo = 5, .Section = "Sapphire", .Teacher = "Marco Magising"})
        ClassList.Add(New Classes With {.SubjectID = "FIL501", .SubjectName = "Filipino", .GradeNo = 5, .Section = "Sapphire", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MPE501", .SubjectName = "MAPEH Enrichment", .GradeNo = 5, .Section = "Sapphire", .Teacher = "Riley Bayani"})

        ' Emerald
        ClassList.Add(New Classes With {.SubjectID = "MTH501", .SubjectName = "Mathematics", .GradeNo = 5, .Section = "Emerald", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG501", .SubjectName = "English", .GradeNo = 5, .Section = "Emerald", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "SCI501", .SubjectName = "Science", .GradeNo = 5, .Section = "Emerald", .Teacher = "Joseph Garcia"})
        ClassList.Add(New Classes With {.SubjectID = "AP501", .SubjectName = "Araling Panlipunan", .GradeNo = 5, .Section = "Emerald", .Teacher = "Marco Magising"})
        ClassList.Add(New Classes With {.SubjectID = "FIL501", .SubjectName = "Filipino", .GradeNo = 5, .Section = "Emerald", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MPE501", .SubjectName = "MAPEH Enrichment", .GradeNo = 5, .Section = "Emerald", .Teacher = "Riley Bayani"})

        ' -------------------- GRADE 6 --------------------
        ' Ruby
        ClassList.Add(New Classes With {.SubjectID = "MTH601", .SubjectName = "Mathematics", .GradeNo = 6, .Section = "Ruby", .Teacher = "Jason Rodriguez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG601", .SubjectName = "English", .GradeNo = 6, .Section = "Ruby", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "SCI601", .SubjectName = "Science", .GradeNo = 6, .Section = "Ruby", .Teacher = "Joseph Garcia"})
        ClassList.Add(New Classes With {.SubjectID = "AP601", .SubjectName = "Araling Panlipunan", .GradeNo = 6, .Section = "Ruby", .Teacher = "Marco Magising"})
        ClassList.Add(New Classes With {.SubjectID = "FIL601", .SubjectName = "Filipino", .GradeNo = 6, .Section = "Ruby", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MPE601", .SubjectName = "MAPEH", .GradeNo = 6, .Section = "Ruby", .Teacher = "Riley Bayani"})

        ' Topaz
        ClassList.Add(New Classes With {.SubjectID = "MTH601", .SubjectName = "Mathematics", .GradeNo = 6, .Section = "Topaz", .Teacher = "Aliyah Gomez"})
        ClassList.Add(New Classes With {.SubjectID = "ENG601", .SubjectName = "English", .GradeNo = 6, .Section = "Topaz", .Teacher = "Ron Delmundo"})
        ClassList.Add(New Classes With {.SubjectID = "SCI601", .SubjectName = "Science", .GradeNo = 6, .Section = "Topaz", .Teacher = "Joseph Garcia"})
        ClassList.Add(New Classes With {.SubjectID = "AP601", .SubjectName = "Araling Panlipunan", .GradeNo = 6, .Section = "Topaz", .Teacher = "Marco Magising"})
        ClassList.Add(New Classes With {.SubjectID = "FIL601", .SubjectName = "Filipino", .GradeNo = 6, .Section = "Topaz", .Teacher = "Derry Romualdez"})
        ClassList.Add(New Classes With {.SubjectID = "MPE601", .SubjectName = "MAPEH", .GradeNo = 6, .Section = "Topaz", .Teacher = "Riley Bayani"})
    End Sub

    Private Sub PopulateGradeCombo(cmb As ComboBox)
        cmb.Items.Clear()
        cmb.Items.Add("Select")
        For i As Integer = 1 To 6
            cmb.Items.Add(i)
        Next
        cmb.SelectedIndex = 0
    End Sub

    Private Function GetSectionsForGrade(grade As Integer) As List(Of String)
        Return ClassList.Where(Function(c) c.GradeNo = grade) _
                        .Select(Function(c) c.Section) _
                        .Distinct() _
                        .OrderBy(Function(s) s) _
                        .ToList()
    End Function

    Private Sub RefreshGrid(source As List(Of Classes))
        Dim sorted = source.OrderBy(Function(c) c.GradeNo) _
                           .ThenBy(Function(c) c.Section) _
                           .ThenBy(Function(c) c.SubjectName) _
                           .ToList()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = sorted
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub ClearEditPanel()
        ComboBox2.SelectedIndex = 0
        ComboBox3.Items.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox4.Items.Clear()
        ComboBox4.Items.Add("All")
        If ComboBox1.SelectedIndex > 0 Then
            Dim grade As Integer = CInt(ComboBox1.SelectedItem)
            For Each s In GetSectionsForGrade(grade)
                ComboBox4.Items.Add(s)
            Next
        End If
        ComboBox4.SelectedIndex = 0
        ApplyFilter()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        Dim filtered = ClassList.AsEnumerable()

        If ComboBox1.SelectedIndex > 0 Then
            Dim grade As Integer = CInt(ComboBox1.SelectedItem)
            filtered = filtered.Where(Function(c) c.GradeNo = grade)
        End If

        If ComboBox4.SelectedIndex > 0 Then
            Dim sec As String = ComboBox4.SelectedItem.ToString()
            filtered = filtered.Where(Function(c) c.Section = sec)
        End If

        If ComboBox7.SelectedIndex > 0 Then
            Dim teacher As String = ComboBox7.SelectedItem.ToString()
            filtered = filtered.Where(Function(c) c.Teacher = teacher)
        End If

        RefreshGrid(filtered.ToList())
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count = 0 Then Return

        Dim row = DataGridView1.SelectedRows(0)
        Dim selectedGrade As Integer = CInt(row.Cells("GradeNo").Value)
        Dim selectedSection As String = row.Cells("Section").Value.ToString()
        Dim selectedSubjectID As String = row.Cells("SubjectID").Value.ToString()
        Dim selectedSubjectName As String = row.Cells("SubjectName").Value.ToString()
        Dim selectedTeacher As String = row.Cells("Teacher").Value.ToString()

        ' Grade combo
        ComboBox2.SelectedItem = selectedGrade

        ' Section combo – populate then select
        ComboBox3.Items.Clear()
        For Each s In GetSectionsForGrade(selectedGrade)
            ComboBox3.Items.Add(s)
        Next
        ComboBox3.SelectedItem = selectedSection

        ' Fill text fields
        TextBox5.Text = selectedSubjectID
        TextBox6.Text = selectedSubjectName
        TextBox7.Text = selectedTeacher
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        If ComboBox2.SelectedIndex > 0 Then
            Dim grade As Integer = CInt(ComboBox2.SelectedItem)
            For Each s In GetSectionsForGrade(grade)
                ComboBox3.Items.Add(s)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate
        If ComboBox2.SelectedIndex <= 0 Then
            MessageBox.Show("Please select a Grade Level.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If ComboBox3.SelectedIndex < 0 OrElse String.IsNullOrWhiteSpace(ComboBox3.SelectedItem?.ToString()) Then
            MessageBox.Show("Please select a Section.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please enter a Subject ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If String.IsNullOrWhiteSpace(TextBox6.Text) Then
            MessageBox.Show("Please enter a Subject Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If String.IsNullOrWhiteSpace(TextBox7.Text) Then
            MessageBox.Show("Please enter an Assigned Teacher.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If

        Dim row = DataGridView1.SelectedRows(0)
        Dim origSubjectID As String = row.Cells("SubjectID").Value.ToString()
        Dim origSection As String = row.Cells("Section").Value.ToString()
        Dim origGrade As Integer = CInt(row.Cells("GradeNo").Value)

        Dim target = ClassList.FirstOrDefault(Function(c) c.SubjectID = origSubjectID AndAlso
                                                           c.Section = origSection AndAlso
                                                           c.GradeNo = origGrade)
        If target Is Nothing Then
            MessageBox.Show("Record not found in master list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) : Return
        End If

        target.GradeNo = CInt(ComboBox2.SelectedItem)
        target.Section = ComboBox3.SelectedItem.ToString()
        target.SubjectID = TextBox5.Text.Trim()
        target.SubjectName = TextBox6.Text.Trim()
        target.Teacher = TextBox7.Text.Trim()

        Dim currentTeacher = ComboBox7.SelectedItem?.ToString()
        ComboBox7.Items.Clear()
        ComboBox7.Items.Add("All")
        For Each t In ClassList.Select(Function(c) c.Teacher).Distinct().OrderBy(Function(x) x)
            ComboBox7.Items.Add(t)
        Next
        ComboBox7.SelectedItem = If(currentTeacher, "All")

        ApplyFilter()
        MessageBox.Show("Row updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Return

        Dim row = DataGridView1.SelectedRows(0)
        Dim origSubjectID As String = row.Cells("SubjectID").Value.ToString()
        Dim origSection As String = row.Cells("Section").Value.ToString()
        Dim origGrade As Integer = CInt(row.Cells("GradeNo").Value)

        Dim target = ClassList.FirstOrDefault(Function(c) c.SubjectID = origSubjectID AndAlso
                                                           c.Section = origSection AndAlso
                                                           c.GradeNo = origGrade)
        If target IsNot Nothing Then
            ClassList.Remove(target)
        End If

        ClearEditPanel()
        ApplyFilter()
        MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        ComboBox6.Items.Clear()
        If ComboBox5.SelectedIndex > 0 Then
            Dim grade As Integer = CInt(ComboBox5.SelectedItem)
            For Each s In GetSectionsForGrade(grade)
                ComboBox6.Items.Add(s)
            Next
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ComboBox5.SelectedIndex <= 0 Then
            MessageBox.Show("Please select a Grade Level.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If ComboBox6.SelectedIndex < 0 OrElse String.IsNullOrWhiteSpace(ComboBox6.SelectedItem?.ToString()) Then
            MessageBox.Show("Please select a Section.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter a Subject ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter a Subject Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If
        If String.IsNullOrWhiteSpace(TextBox8.Text) Then
            MessageBox.Show("Please enter an Assigned Teacher.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Return
        End If

        Dim newGrade As Integer = CInt(ComboBox5.SelectedItem)
        Dim newSection As String = ComboBox6.SelectedItem.ToString()
        Dim newSubjectID As String = TextBox1.Text.Trim()

        Dim duplicate = ClassList.Any(Function(c) c.SubjectID = newSubjectID AndAlso
                                                   c.Section = newSection AndAlso
                                                   c.GradeNo = newGrade)
        If duplicate Then
            MessageBox.Show("A record with the same Subject ID, Section, and Grade already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ClassList.Add(New Classes With {
            .GradeNo = newGrade,
            .Section = newSection,
            .SubjectID = newSubjectID,
            .SubjectName = TextBox2.Text.Trim(),
            .Teacher = TextBox8.Text.Trim()
        })

        ComboBox7.Items.Clear()
        ComboBox7.Items.Add("All")
        For Each t In ClassList.Select(Function(c) c.Teacher).Distinct().OrderBy(Function(x) x)
            ComboBox7.Items.Add(t)
        Next
        ComboBox7.SelectedIndex = 0

        ComboBox5.SelectedIndex = 0
        ComboBox6.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox8.Clear()

        ApplyFilter()
        MessageBox.Show("Row added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class