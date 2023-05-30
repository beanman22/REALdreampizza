Imports System.Net.Mail
Imports System.Runtime.Remoting

Public Class recieptform
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
    End Sub
    Private Sub recieptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim storedetails As String
        storedetails = My.Computer.FileSystem.ReadAllText("storedetails.txt")
        LblReceipt.Text += storedetails & vbCrLf & "***" & vbCrLf & vbCrLf

        LblReceipt.Text += DateString & "  " & TimeOfDay & vbCrLf & "*******************************" & vbCrLf & vbCrLf


        LblReceipt.Text += "CUSTOMER DETAILS:" & vbCrLf
        LblReceipt.Text += Form1.details(0) & " " & Form1.details(1) & vbCrLf & Form1.details(2)
        LblReceipt.Text += vbCrLf & vbCrLf & "DELIVERY DETAILS:" & vbCrLf

        For i = 3 To 6
            LblReceipt.Text += Form1.details(i) & vbCrLf
        Next

        LblReceipt.Text += vbCrLf & "*******************************" & vbCrLf & vbCrLf

        For i = 0 To 11
            If Val(Form1.pizza(i, 2)) > 0 Then
                LblReceipt.Text += Form1.pizza(i, 2) & "x " & Form1.pizza(i, 0) & "        " & FormatCurrency(Form1.pizza(i, 3)) & vbCrLf
            End If
        Next

    End Sub
End Class