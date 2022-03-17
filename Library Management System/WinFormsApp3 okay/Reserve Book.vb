Public Class Form3
    Dim choice As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox2.Checked Then
            choice = "The secret"
            ListBox1.Items.Add(choice)
        End If

        If CheckBox7.Checked Then
            choice = "Wise an Otherwise"
            ListBox1.Items.Add(choice)
        End If


        If CheckBox12.Checked Then
            choice = "The Beginning after the End"
            ListBox1.Items.Add(choice)
        End If
        MsgBox("Selected books has been reserved")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class