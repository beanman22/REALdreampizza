Imports System.Reflection.Metadata
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1

    Const STANDARDPRICE As Decimal = 7.5 'declares the price of a standard pizza
    Const GOURMETPRICE As Decimal = 14.5 'declares the price of a gourmet pizza

    Public total As Decimal = 0 'declares variable for the total cost of all pizzas
    Public delivery As Boolean 'declares variable for the delivery option

    Public details(7) As String 'declares a one dimensional array for the customer details
    Public pizza(11, 3) As String 'declares 2d array for pizza details - name,  individual cost, quantity, subtotal cost
    Public totals(11) As Decimal 'declares 1d array for final addition of pizza cost and delivery cost

    Public upperb As Integer
    Public lowerb As Integer
    Private Sub NudQty1_ValueChanged(sender As Object, e As EventArgs) Handles NudQty1.ValueChanged, NudQty2.ValueChanged, NudQty3.ValueChanged, NudQty4.ValueChanged, NudQty5.ValueChanged, NudQty6.ValueChanged, NudQty7.ValueChanged, NudQty8.ValueChanged, NudQty9.ValueChanged, NudQty10.ValueChanged, NudQty11.ValueChanged, NudQty12.ValueChanged

        upperb = UBound(pizza)
        lowerb = LBound(pizza)

        pizza(0, 1) = 7.5
        pizza(1, 1) = 7.5
        pizza(2, 1) = 7.5
        pizza(3, 1) = 7.5
        pizza(4, 1) = 7.5
        pizza(5, 1) = 7.5
        pizza(6, 1) = 7.5
        pizza(7, 1) = 7.5
        pizza(8, 1) = 7.5
        pizza(9, 1) = 7.5
        pizza(10, 1) = 7.5
        pizza(11, 1) = 7.5
        'test code

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



        total = 0 'sets total to 0
        For i = lowerb To upperb
            total = total + pizza(i, 3) 'iterates through the third coloum of the 2d array
            LblTotal.Text = "total: " + FormatCurrency(total) 'displays the total and formats it as currency
        Next
    End Sub
    Private Sub ChkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDelivery.CheckedChanged


        If ChkDelivery.Checked = True Then 'checks if delivery box is checked
            LblDelivery.Show() 'shows lbldelivery
            LblAddress.Show() 'shows lbladdress
            LblCode.Show() 'shows lblcode
            LblCity.Show() 'shows lbltown
            LblSuburb.Show() 'shows lblsuburb
            TxtAddress.Show() 'shows txtaddress
            TxtCity.Show() 'shows txtcity
            TxtCode.Show() 'shows txtpost
            TxtSuburb.Show() 'txtsuburb
            subtotals(10) = 3 'makes the tenth value in the subtotals array equal to 3
        Else 'if box is not checked
            LblDelivery.Hide() 'hides lbldelivery
            LblAddress.Hide() 'hides lbladdress
            LblCode.Hide() 'hides lblcode
            LblTown.Hide() 'hides lbltown
            LblSuburb.Hide() 'hides lblsuburb
            TxtAddress.Hide() 'hides txtaddress
            TxtCity.Hide() 'hides txtcity
            TxtPost.Hide() 'hides txtpost
            TxtSuburb.Hide() 'hides txtsuburb
            subtotals(10) = 0 'makes the tenth value in the subtotals array equal to zero
        End If 'ends the process

        total = subtotals.Sum() 'calculates the sum of all values in the array and inputs it into the variable for the total
        LblTotal.Text = "total: " + FormatCurrency(total) 'displays the total and formats it as currency

    End Sub
End Class
