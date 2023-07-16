Imports System.Net.Mail
Imports System.Runtime.Remoting

Public Class recieptform
    Private Sub recieptform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim storedetails As String 'declares a variable for the store details
        Dim spacing(11) As String 'declares an array for spacing
        Dim stringlenth(11) As Double 'declares an array for the lenth of each pizza name
        Dim finalspacing(11) As String 'declares an array for the final amount of spaces between the pizza names and prices
        Dim Instructions As String = Form1.TxtInstructions.Text 'declares a variable for the instructions and pull the data from form 1
        Dim random As New Random 'declares a random variable for the random order number

        For i = 0 To 11
            spacing(i) = "                          " 'sets the lenth of the spacing array
            stringlenth(i) = Form1.pizza(i, 0).Length 'gets the lenth of each name and stores it as an integer
            finalspacing(i) = spacing(i).Remove(0, stringlenth(i)) 'remove the amount of spacesof stringlenth from spacing and inputs it into finalspacing
        Next



        LblReceipt.Text += "Rotorua Dream Pizza LTD" & vbCrLf 'adds the name of the store
        storedetails = My.Computer.FileSystem.ReadAllText("storedetails.txt") 'pulls the stores details and pts them into an array
        LblReceipt.Text += storedetails & vbCrLf & vbCrLf & "-------------------------------------" & vbCrLf 'adds the details, and a divider
        LblReceipt.Text += DateString & "  " & TimeOfDay & "  Order:" & Convert.ToString(random.Next(1000, 9999)) & vbCrLf & "-------------------------------------" & vbCrLf & vbCrLf 'adds time and date and another divider
        LblReceipt.Text += "CUSTOMER DETAILS:" & vbCrLf
        LblReceipt.Text += Form1.details(0) & " " & Form1.details(1) & vbCrLf & Form1.details(2) 'adds customer details


        If Form1.delivery = True Then ' checks if delivery is checked
            LblReceipt.Text += vbCrLf & vbCrLf & "DELIVERY DETAILS:" & vbCrLf
            For i = 3 To 6
                LblReceipt.Text += Form1.details(i) & vbCrLf 'adds delivery details
            Next
        Else
            LblReceipt.Text += vbCrLf
        End If


        LblReceipt.Text += vbCrLf & "*************************************" & vbCrLf & vbCrLf 'adds divider


        For i = 0 To 11
            If Val(Form1.pizza(i, 2)) > 0 Then
                LblReceipt.Text += Form1.pizza(i, 2) & "x   " & Form1.pizza(i, 0) & finalspacing(i) & FormatCurrency(Form1.pizza(i, 3)) & vbCrLf 'adds each selected pizza to the recipt
            End If
        Next




        LblReceipt.Text += vbCrLf & "*************************************" & vbCrLf & vbCrLf 'adds divider
        If Form1.delivery = True Then
            LblReceipt.Text += "delivery cost: $3" 'adds delivery cost of delivery is checked
        Else
            LblReceipt.Text += ""
        End If

        LblReceipt.Text += vbCrLf & "total cost: " & FormatCurrency(Form1.total) 'adds total price
        LblReceipt.Text += vbCrLf & vbCrLf & "special order instructions:" & vbCrLf & Instructions 'adds custom instructions

    End Sub
    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click

        PrintPreviewDialog1.Document = PrintDocument1 'sets print preview to printdocument
        PrintPreviewDialog1.ShowDialog() 'show the print preview


    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(LblReceipt.Text, New Font("Lucida Console", 12, FontStyle.Regular), Brushes.Black, 20, 20) 'adds recipt to the print form
    End Sub
End Class