Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Metadata
Imports System.Resources.ResXFileRef
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1

    Const STANDARDPRICE As Decimal = 7.5 'declares the price of a standard pizza
    Const GOURMETPRICE As Decimal = 14.5 'declares the price of a gourmet pizza

    Public total As Decimal = 0 'declares variable for the total cost of all pizzas
    Public delivery As Boolean 'declares variable for the delivery option

    Public details(6) As String 'declares a one dimensional array for the customer details
    Public pizza(11, 3) As String 'declares 2d array for pizza details - name,  individual cost, quantity, subtotal cost
    Public totals(11) As Decimal 'declares 1d array for final addition of pizza cost and delivery cost

    Public upperb As Integer
    Public lowerb As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'defines upper and lowers values for pizza array
        upperb = UBound(pizza)
        lowerb = LBound(pizza)

        Dim pricesPath As String = "pizzaprices.txt" ' gets filepath for pizzaprices.txt
        Dim prices() As String = File.ReadAllLines(pricesPath) ' Read all lines from the text file into an array
        Dim namePath As String = "pizzanames.txt" ' gets filepath for pizzanames.txt
        Dim names() As String = File.ReadAllLines(namePath) ' Read all lines from the text file into an array


        Dim PricesArray(prices.Length - 1) As String   'outputs each line from pizzaprices.txt and stores it in the prices array
        For i As Integer = 0 To prices.Length - 1
            PricesArray(i) = prices(i)
        Next
        For i = lowerb To upperb
            pizza(i, 1) = prices(i) 'inputs the values from the prices array into the pizza array
        Next


        Dim NamesArray(names.Length - 1) As String   'outputs each line from pizzaprices.txt and stores it in the prices array
        For i As Integer = 0 To names.Length - 1
            NamesArray(i) = names(i)
        Next
        For i = lowerb To upperb
            pizza(i, 0) = names(i) 'inputs the values from the names array into the pizza array
        Next

        'sets the pizza names labels to the names stored in the array
        LblPizza1.Text = pizza(0, 0)
        LblPizza2.Text = pizza(1, 0)
        LblPizza3.Text = pizza(2, 0)
        LblPizza4.Text = pizza(3, 0)
        LblPizza5.Text = pizza(4, 0)
        LblPizza6.Text = pizza(5, 0)
        LblPizza7.Text = pizza(6, 0)
        LblPizza8.Text = pizza(7, 0)
        LblPizza9.Text = pizza(8, 0)
        LblPizza10.Text = pizza(9, 0)
        LblPizza11.Text = pizza(10, 0)
        LblPizza12.Text = pizza(11, 0)


    End Sub
    Private Sub NudQty1_ValueChanged(sender As Object, e As EventArgs) Handles NudQty1.ValueChanged, NudQty2.ValueChanged, NudQty3.ValueChanged, NudQty4.ValueChanged, NudQty5.ValueChanged, NudQty6.ValueChanged, NudQty7.ValueChanged, NudQty8.ValueChanged, NudQty9.ValueChanged, NudQty10.ValueChanged, NudQty11.ValueChanged, NudQty12.ValueChanged

        'defines upper and lowers values for pizza array
        upperb = UBound(pizza)
        lowerb = LBound(pizza)

        'pulls data from NudQty objects and inputs it into pizza array
        pizza(0, 2) = NudQty1.Value
        pizza(1, 2) = NudQty2.Value
        pizza(2, 2) = NudQty3.Value
        pizza(3, 2) = NudQty4.Value
        pizza(4, 2) = NudQty5.Value
        pizza(5, 2) = NudQty6.Value
        pizza(6, 2) = NudQty7.Value
        pizza(7, 2) = NudQty8.Value
        pizza(8, 2) = NudQty9.Value
        pizza(9, 2) = NudQty10.Value
        pizza(10, 2) = NudQty11.Value
        pizza(11, 2) = NudQty12.Value

        For i = 0 To 11
            pizza(i, 3) = Val(pizza(i, 2)) * Val(pizza(i, 1)) 'calculates the subtotal price of each pizza flavour
        Next

        'displays subtotal prices
        LblSubtotal1.Text = FormatCurrency(pizza(0, 3))
        LblSubtotal2.Text = FormatCurrency(pizza(1, 3))
        LblSubtotal3.Text = FormatCurrency(pizza(2, 3))
        LblSubtotal4.Text = FormatCurrency(pizza(3, 3))
        LblSubtotal5.Text = FormatCurrency(pizza(4, 3))
        LblSubtotal6.Text = FormatCurrency(pizza(5, 3))
        LblSubtotal7.Text = FormatCurrency(pizza(6, 3))
        LblSubtotal8.Text = FormatCurrency(pizza(7, 3))
        LblSubtotal9.Text = FormatCurrency(pizza(8, 3))
        LblSubtotal10.Text = FormatCurrency(pizza(9, 3))
        LblSubtotal11.Text = FormatCurrency(pizza(10, 3))
        LblSubtotal12.Text = FormatCurrency(pizza(11, 3))

        If ChkDelivery.Checked = True Then
            total = 3 'sets total to 3
            For i = lowerb To upperb
                total = total + pizza(i, 3) 'iterates through the third coloum of the 2d array
                LblTotal.Text = "total: " + FormatCurrency(total) 'displays the total and formats it as currency
            Next
        Else
            total = 0 'sets total to zero
            For i = lowerb To upperb
                total = total + pizza(i, 3) 'iterates through the third coloum of the 2d array
                LblTotal.Text = "total: " + FormatCurrency(total) 'displays the total and formats it as currency
            Next
        End If

    End Sub
    Private Sub ChkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged


        If ChkDelivery.Checked = True Then 'checks if delivery box is checked
            delivery = True
            LblDelivery.Show() 'shows lbldelivery
            LblAddress.Show() 'shows lbladdress
            LblCode.Show() 'shows lblcode
            LblCity.Show() 'shows lbltown
            LblSuburb.Show() 'shows lblsuburb
            TxtAddress.Show() 'shows txtaddress
            TxtCity.Show() 'shows txtcity
            TxtCode.Show() 'shows txtpost
            TxtSuburb.Show() 'txtsuburb
            LblDelivery.Show() 'shows lbldelivery
            total = 3 'sets total to 3
            For i = lowerb To upperb
                total = total + pizza(i, 3) 'iterates through the third coloum of the 2d array
                LblTotal.Text = "total: " + FormatCurrency(total) 'displays the total and formats it as currency
            Next
        Else 'if box is not checked
            delivery = False
            LblDelivery.Hide() 'hides lbldelivery
            LblAddress.Hide() 'hides lbladdress
            LblCode.Hide() 'hides lblcode
            LblCity.Hide() 'hides lbltown
            LblSuburb.Hide() 'hides lblsuburb
            TxtAddress.Hide() 'hides txtaddress
            TxtCity.Hide() 'hides txtcity
            TxtCode.Hide() 'hides txtpost
            TxtSuburb.Hide() 'hides txtsuburb
            LblDelivery.Hide() 'hides lbldelivery
            total = 0 'sets total to 0
            For i = lowerb To upperb
                total = total + pizza(i, 3) 'iterates through the third coloum of the 2d array
                LblTotal.Text = "total: " + FormatCurrency(total) 'displays the total and formats it as currency
            Next
        End If 'ends the process
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'displays a messagebox asking if the user wants to quit the program, with two dialoge options, If the user choses no nothing happens, if the user choses yes the application closes.
        If MessageBox.Show("Are you sure you want" + vbCrLf + "to exit the program?" + vbCrLf + "changes will not be saved", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        Dim TrimmedTxtFname As String
        Dim TrimmedTxtLname As String
        Dim TrimmedTxtMobile As String
        Dim TrimmedTxtAddress As String
        Dim TrimmedTxtcity As String
        Dim TrimmedTxtSuburb As String
        Dim TrimmedTxtCode As String

        TrimmedTxtLname = TxtLname.Text.Trim
        TrimmedTxtFname = TxtFname.Text.Trim
        TrimmedTxtMobile = TxtFname.Text.Trim
        TrimmedTxtAddress = TxtFname.Text.Trim
        TrimmedTxtcity = TxtFname.Text.Trim
        TrimmedTxtSuburb = TxtFname.Text.Trim
        TrimmedTxtCode = TxtFname.Text.Trim


        If delivery = False Then
            If TrimmedTxtFname = "" Or TrimmedTxtLname = "" Or TrimmedTxtMobile = "" Then
                MessageBox.Show("please input full name and phone number")

            ElseIf delivery = False Then

                details(0) = TxtFname.Text
                details(1) = TxtLname.Text
                details(2) = TxtMobile.Text
                details(3) = TxtAddress.Text
                details(4) = TxtCity.Text
                details(5) = TxtSuburb.Text
                details(6) = TxtCode.Text

                recieptform.Show()
                Me.Hide()
            End If
        ElseIf delivery = True Then
            If TrimmedTxtFname = "" Or TrimmedTxtLname = "" Or TrimmedTxtMobile = "" Or TrimmedTxtAddress = "" Or TrimmedTxtcity = "" Or TrimmedTxtSuburb = "" Or TrimmedTxtCode = "" Then
                MessageBox.Show("please input all customer and delivery details")

            ElseIf delivery = True Then

                details(0) = TxtFname.Text
                details(1) = TxtLname.Text
                details(2) = TxtMobile.Text
                details(3) = TxtAddress.Text
                details(4) = TxtCity.Text
                details(5) = TxtSuburb.Text
                details(6) = TxtCode.Text

                recieptform.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
