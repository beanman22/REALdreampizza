﻿Imports System.Net.Mail
Imports System.Runtime.Remoting

Public Class recieptform
    Private Sub recieptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim storedetails As String
        Dim spacing(11) As String
        Dim stringlenth(11) As Double
        Dim finalspacing(11) As String


        For i = 0 To 11

            spacing(i) = "                          "
            stringlenth(i) = Form1.pizza(i, 0).Length
            finalspacing(i) = spacing(i).Remove(0, stringlenth(i))

        Next



        LblReceipt.Text += "Rotorua Dream Pizza LTD" & vbCrLf 'adds 
        storedetails = My.Computer.FileSystem.ReadAllText("storedetails.txt")
        LblReceipt.Text += storedetails & vbCrLf & vbCrLf & "---------------------------------" & vbCrLf
        LblReceipt.Text += DateString & "  " & TimeOfDay & vbCrLf & "---------------------------------" & vbCrLf & vbCrLf


        LblReceipt.Text += "CUSTOMER DETAILS:" & vbCrLf
        LblReceipt.Text += Form1.details(0) & " " & Form1.details(1) & vbCrLf & Form1.details(2)


        If Form1.delivery = True Then
            LblReceipt.Text += vbCrLf & vbCrLf & "DELIVERY DETAILS:" & vbCrLf
            For i = 3 To 6
                LblReceipt.Text += Form1.details(i) & vbCrLf
            Next
        Else
            LblReceipt.Text += vbCrLf
        End If


        LblReceipt.Text += vbCrLf & "*********************************" & vbCrLf & vbCrLf


        For i = 0 To 11
            If Val(Form1.pizza(i, 2)) > 0 Then
                LblReceipt.Text += Form1.pizza(i, 2) & "x   " & Form1.pizza(i, 0) & finalspacing(i) & FormatCurrency(Form1.pizza(i, 3)) & vbCrLf
            End If
        Next




        LblReceipt.Text += vbCrLf & "*********************************" & vbCrLf & vbCrLf
        If Form1.delivery = True Then
            LblReceipt.Text += "delivery cost: $3"
        Else
            LblReceipt.Text += ""
        End If
        LblReceipt.Text += vbCrLf & "total cost: " & FormatCurrency(Form1.total)

    End Sub
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(LblReceipt.Text, New Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20)
    End Sub
End Class