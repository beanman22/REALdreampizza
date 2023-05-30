Imports System.Net.Mail

Public Class recieptform
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
    End Sub
    Private Sub recieptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'LblReceipt.Text = ("Customer details:" & vbCrLf & Form1.details(0) & " " & Form1.details(1) & vbCrLf & Form1.details(2) & vbCrLf & vbCrLf & "delivery details:" _
        '& vbCrLf & Form1.details(3) & vbCrLf & Form1.details(4) & vbCrLf & Form1.details(5) & vbCrLf & Form1.details(6) & vbCrLf & vbCrLf & vbCrLf & "order:" & vbCrLf)

        For i = 0 To 2
            LblReceipt.Text += Form1.details(i) & vbCrLf
        Next
        LblReceipt.Text += "delivery details:" & vbCrLf
        For i = 3 To 6
            LblReceipt.Text += Form1.details(i) & vbCrLf
        Next

        For i = 0 To 11
            If Val(Form1.pizza(i, 2)) > 0 Then
                LblReceipt.Text += Form1.pizza(i, 2) & "x " & Form1.pizza(i, 0) & vbCrLf
            End If
        Next

    End Sub
End Class