Public Class recieptform
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
    End Sub
    Private Sub recieptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblReceipt.Text = ("Customer details:" & vbCrLf & Form1.details(0) & " " & Form1.details(1) & vbCrLf & Form1.details(2) & vbCrLf & vbCrLf & "delivery details" & vbCrLf & Form1.details(3) & vbCrLf & Form1.details(4) & vbCrLf & Form1.details(5) & vbCrLf & Form1.details(6))

    End Sub
End Class