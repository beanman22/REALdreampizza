Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim passwordpath As String = My.Computer.FileSystem.ReadAllText("password.txt") 'creates new variable and stores all text in password.txt
        Dim usernamepath As String = My.Computer.FileSystem.ReadAllText("username.txt") 'creates new variable and stores all text in username.txt

        If PasswordTextBox.Text = passwordpath And UsernameTextBox.Text = usernamepath Then 'checks if username and password are correct
            Me.Hide() 'hides login form
            Form1.Show() 'shows form1
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close() 'closes application
    End Sub
End Class
