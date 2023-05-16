Imports System.Reflection.Metadata
Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1

    Const STANDARDPRICE As Decimal = 7.5 'declares the price of a standard pizza
    Const GOURMETPRICE As Decimal = 14.5 'declares the price of a gourmet pizza

    Public total As Decimal = 0 'declares variable for the total cost of all pizzas
    Public delivery As Boolean 'declares variable for the delivery option

    Public details(7) As String 'declares a one dimensional array for the customer details
    Public pizza(9, 3) As String 'declares 2d array for pizza details
    Public totals(10) As Decimal 'declares 1d array for final addition of pizza cost and delivery cost
End Class
