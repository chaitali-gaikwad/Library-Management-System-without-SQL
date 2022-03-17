Public Class Borrow_Book
    Dim choice As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            choice = "The Private Life of an Indian Prince"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox3.Checked Then
            choice = "Geeta"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox4.Checked Then
            choice = "Ramayan"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox5.Checked Then
            choice = "The Wings of Fire"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox17.Checked Then
            choice = "Start with Why"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox8.Checked Then
            choice = "The Old Man and his God"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox16.Checked Then
            choice = "Good Vibes Good Life"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox15.Checked Then
            choice = "The Alchemist"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox18.Checked Then
            choice = "The Monk who sold his Ferrari"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox12.Checked Then
            choice = "The Beginning after the End"
            ListBox1.Items.Add(choice)
        End If


        If CheckBox14.Checked Then
            choice = "The Power of Habit"
            ListBox1.Items.Add(choice)
        End If
        MsgBox("Selected books has been Borrowed")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        Dim chkbox As CheckBox = DirectCast(sender, CheckBox)
        If chkbox.Checked = True Then
            MsgBox("Selected book is currently not available, Book can be reserved in reservation section")
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Dim chkbox As CheckBox = DirectCast(sender, CheckBox)
        If chkbox.Checked = True Then
            MsgBox("Selected book is currently not available, Book can be reserved in reservation section")
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim chkbox As CheckBox = DirectCast(sender, CheckBox)
        If chkbox.Checked = True Then
            MsgBox("Selected book is currently not available, Book can be reserved in reservation section")
        End If
    End Sub

End Class