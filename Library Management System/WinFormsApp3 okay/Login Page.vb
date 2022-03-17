Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Usernme As String
        Dim Password As String
        Usernme = txtuser.Text
        Password = txtpass.Text
        If (Usernme.Equals("User") And Password.Equals("User")) Then
            MessageBox.Show("Sucessfully Logged in", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (Usernme.Equals("User") And Password.Equals("User")) Then
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
