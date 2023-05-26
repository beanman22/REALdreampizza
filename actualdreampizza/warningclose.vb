Public Class warningclose
    Private Sub LblContinue_Click(sender As Object, e As EventArgs) Handles LblContinue.Click

        LoginForm1.Close() 'closes login form and ends application

    End Sub
    Private Sub LblCancel_Click(sender As Object, e As EventArgs) Handles LblCancel.Click
        Me.Close() 'closes warning form
    End Sub
End Class