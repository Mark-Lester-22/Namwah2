Imports System.Data.SqlClient
Public Class Billing
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = String.Empty
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader

        con.Open()

        query = "SELECT MAX(CAST(BillingNumber as INT)) as BillingNumber FROM Billings"
        Dim cmd As New SqlCommand(query, con)
        reader = cmd.ExecuteReader()
        If reader.Read() = False Then
            txtboxBillingNum.Text = "1"
        Else
            If Not IsDBNull(reader("BillingNumber")) Then
                txtboxBillingNum.Text = Convert.ToInt32(reader("BillingNumber")) + 1
            Else
                txtboxBillingNum.Text = "1"
            End If
        End If

        'TODO: This line of code loads data into the 'NamwahOrdersDataSet.Orders' table. You can move, or remove it, as needed.
        txtboxTotal.Text = "0.00"
        txtboxPayments.Text = "0.00"
        txtboxChange.Text = "0.00"
        Me.OrdersTableAdapter.Fill(Me.NamwahOrdersDataSet.Orders)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ordersDataView.CellContentClick
        Dim row As DataGridViewRow = ordersDataView.Rows(e.RowIndex)
        If e.ColumnIndex = 7 Then
            Dim OrderNum, TableNum, TotalPrice As String
            txtboxOrderNum.Text = row.Cells("orderNum").Value
            txtboxTableNum.Text = row.Cells("location").Value
            txtboxTotal.Text = row.Cells("totalPrice").Value
            tbxOrderID.Text = row.Cells("ordersID").Value.ToString()
        ElseIf e.ColumnIndex = 8 Then
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Orders SET Status=@status WHERE ID=@id", con)
            cancelOrder.Parameters.AddWithValue("@status", "Cancelled")
            cancelOrder.Parameters.AddWithValue("@id", row.Cells("ordersID").Value)
            cancelOrder.ExecuteNonQuery()
            Me.OrdersTableAdapter.Fill(Me.NamwahOrdersDataSet.Orders)
        End If
    End Sub

    Private Sub txtboxPayments_TextChanged(sender As Object, e As EventArgs) Handles txtboxPayments.TextChanged, txtboxPayments.KeyPress

        Dim change, total, payments As Double
        If txtboxTotal.Text Is Nothing Or txtboxTotal.Text = "" Then
            txtboxTotal.Text = "0.00"
        Else
            If txtboxPayments.Text Is Nothing Or txtboxPayments.Text = "" Then
                txtboxPayments.Text = "0.00"
            Else
                Try
                    payments = txtboxPayments.Text
                    total = txtboxTotal.Text
                    change = Math.Round(payments - total, 2)
                    txtboxChange.Text = change
                Catch ex As Exception
                    MsgBox("Please input correct numbers in field")
                End Try
            End If
        End If
    End Sub
    Private Sub txtboxPayments_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtboxPayments.KeyPress
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
        Dim billnum, ordernum, location, cashName, payments, change As String
        Dim insertBill As String = String.Empty

        billnum = txtboxBillingNum.Text
        ordernum = txtboxOrderNum.Text
        location = txtboxTableNum.Text
        payments = txtboxPayments.Text
        change = txtboxChange.Text
        cashName = CashierDB.lblWelcomeMsg.Text

        If ordernum.Length = 0 Then
            MsgBox("Select an order to process.")
        Else
            Dim con As New SqlConnection(constring)
            Dim orderReader As SqlDataReader

            con.Open()

            Dim getOrder As New SqlCommand("SELECT * FROM Orders WHERE OrderNumber = @ordernum AND Location = @loc AND Status = 'Pending' ", con)
            getOrder.Parameters.AddWithValue("@ordernum", ordernum)
            getOrder.Parameters.AddWithValue("@loc", location)
            orderReader = getOrder.ExecuteReader()
            If orderReader.Read() = False Then
                MsgBox("No order found!")
            Else
                If Convert.ToDecimal(txtboxPayments.Text) >= Convert.ToDecimal(txtboxTotal.Text) Then
                    Dim updateOrder As New SqlCommand("UPDATE Orders SET Status=@status WHERE ID=@orderID", con)
                    updateOrder.Parameters.AddWithValue("@status", "Paid")
                    updateOrder.Parameters.AddWithValue("@orderID", orderReader("ID"))
                    insertBill = "INSERT INTO Billings(OrderID,BillingNumber,InitialPrice,TotalPrice,Payments,Change,TableNumber,OrderNumber,ListOfMenu,ListOfPrice,MenuQuantity,Status,OrderType,Discounted,CashierName,createdDateTime)
                    VALUES(@colOrderID,@colBillingNumber,@colInitialPrice,@colTotalPrice,@colPayments,@colChange,@colTableNumber,@colOrderNumber,@colListOfMenu,@colListOfPrice,@colMenuQuantity,@colStatus,@colOrderType,@colDiscounted,@colCashierName,@colcreatedDateTime)"
                    Dim insertBilling As New SqlCommand(insertBill, con)
                    insertBilling.Parameters.AddWithValue("@colOrderID", orderReader("ID"))
                    insertBilling.Parameters.AddWithValue("@colBillingNumber", billnum)
                    insertBilling.Parameters.AddWithValue("@colInitialPrice", orderReader("InitialPrice"))
                    insertBilling.Parameters.AddWithValue("@colTotalPrice", orderReader("TotalPrice"))
                    insertBilling.Parameters.AddWithValue("@colPayments", payments)
                    insertBilling.Parameters.AddWithValue("@colChange", change)
                    insertBilling.Parameters.AddWithValue("@colTableNumber", location)
                    insertBilling.Parameters.AddWithValue("@colOrderNumber", ordernum)
                    insertBilling.Parameters.AddWithValue("@colListOfMenu", orderReader("ListOfMenu"))
                    insertBilling.Parameters.AddWithValue("@colListOfPrice", orderReader("ListOfPrice"))
                    insertBilling.Parameters.AddWithValue("@colMenuQuantity", orderReader("MenuQuantity"))
                    insertBilling.Parameters.AddWithValue("@colStatus", "Paid")
                    insertBilling.Parameters.AddWithValue("@colOrderType", orderReader("MenusType"))
                    insertBilling.Parameters.AddWithValue("@colDiscounted", orderReader("Discounted"))
                    insertBilling.Parameters.AddWithValue("@colCashierName", cashName)
                    insertBilling.Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())

                    orderReader.Close()
                    updateOrder.ExecuteNonQuery()
                    insertBilling.ExecuteNonQuery()

                    Me.OrdersTableAdapter.Fill(Me.NamwahOrdersDataSet.Orders)

                    txtboxOrderNum.Text = ""
                    txtboxTableNum.Text = ""
                    txtboxTotal.Text = "0.00"
                    txtboxPayments.Text = "0.00"
                    txtboxChange.Text = "0.00"

                    Dim query As String = String.Empty
                    Dim reader As SqlDataReader

                    query = "SELECT MAX(CAST(BillingNumber as INT)) as BillingNumber FROM Billings"
                    Dim cmd As New SqlCommand(query, con)
                    reader = cmd.ExecuteReader()
                    If reader.Read() = False Then
                        txtboxBillingNum.Text = "1"
                    Else
                        If Not IsDBNull(reader("BillingNumber")) Then
                            txtboxBillingNum.Text = Convert.ToInt32(reader("BillingNumber")) + 1
                        Else
                            txtboxBillingNum.Text = "1"
                        End If
                    End If

                    MsgBox("Order has been paid.")
                Else
                    MsgBox("Payment should be higher to total")
                End If

            End If


        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        txtboxOrderNum.Text = ""
        txtboxTableNum.Text = ""
        txtboxTotal.Text = "0.00"
        txtboxPayments.Text = "0.00"
        txtboxChange.Text = "0.00"
        CashierDB.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxOrderNum.Text = ""
        txtboxTableNum.Text = ""
        txtboxTotal.Text = "0.00"
        txtboxPayments.Text = "0.00"
        txtboxChange.Text = "0.00"
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim orderReader As SqlDataReader
        con.Open()
        Dim getOrder As New SqlCommand("SELECT * FROM Orders WHERE ID = @orderID", con)
        getOrder.Parameters.AddWithValue("@orderID", tbxOrderID.Text)
        orderReader = getOrder.ExecuteReader()
        If tbxOrderID.Text = "" Then
            MsgBox("No order found!")
        Else
            If orderReader.Read() = False Then
                MsgBox("No order found!")
            Else

                Dim strPrint, cashName, RestaurantName, Address, Phone As String
                Dim cashierName = CashierDB.tbxCashierName.Text
                RestaurantName = "Namwah Cuisine"
                Address = "269 Meycauayan Camalig, Meycauayan"
                Phone = "0936 231 1325"

                strPrint = RestaurantName & vbCrLf
                strPrint = strPrint & Address & vbCrLf
                strPrint = strPrint & Phone & vbCrLf
                strPrint = strPrint & "Date Printed: " & DateTime.Now() & vbCrLf
                strPrint = strPrint & "----------------------------------" & vbCrLf
                strPrint = strPrint & "Bill No.     : " & txtboxBillingNum.Text & vbCrLf
                strPrint = strPrint & "Order No.    : " & txtboxOrderNum.Text & vbCrLf
                strPrint = strPrint & "Table No.    : " & txtboxTableNum.Text & vbCrLf
                strPrint = strPrint & "Cashier      : " & cashierName & vbCrLf
                strPrint = strPrint & " " & vbCrLf

                strPrint = strPrint & "OFFICIAL RECEIPT" & vbCrLf
                strPrint = strPrint & " " & vbCrLf
                strPrint = strPrint & "Item    Qty.      Cost.      SubTotal" & vbCrLf
                strPrint = strPrint & "----------------------------------" & vbCrLf
                Dim menuStrArray As String() = orderReader("ListOfMenu").Split(","c)
                Dim PriceStrArray As String() = orderReader("ListOfPrice").Split(","c)
                Dim qtyStrArray As String() = orderReader("MenuQuantity").Split(","c)
                For x = 1 To menuStrArray.Length() Step 1
                    strPrint = strPrint & menuStrArray(x - 1).Trim() & "  " & qtyStrArray(x - 1).Trim() & "  " & Convert.ToDecimal(PriceStrArray(x - 1).Trim()) / Convert.ToInt32(qtyStrArray(x - 1).Trim()) & "  P" & PriceStrArray(x - 1).Trim() & vbCrLf
                Next
                'For Each menuitem As String In menuStrArray
                '    For Each priceitem As String In PriceStrArray
                '        For Each qtyitem As String In qtyStrArray
                '            strPrint = strPrint & menuitem.Trim() & " " & qtyitem.Trim() & " " & priceitem.Trim() & " P" & Convert.ToDecimal(priceitem.Trim()) * Convert.ToInt32(qtyitem.Trim()) & vbCrLf
                '        Next
                '    Next
                'Next
                'strPrint = strPrint & "Sauce    2   5000    10000" & vbCrLf
                'strPrint = strPrint & "Coffe    3   1000     3000" & vbCrLf
                'strPrint = strPrint & "Sugar    1   8000     3000" & vbCrLf
                strPrint = strPrint & "----------------------------------" & vbCrLf
                strPrint = strPrint & "Total        :    " & txtboxTotal.Text & vbCrLf
                strPrint = strPrint & "Payment      :    " & txtboxPayments.Text & vbCrLf
                strPrint = strPrint & "Change       :    " & txtboxChange.Text & vbCrLf
                Printer.Print(strPrint)
                'MsgBox(menuStrArray.Length())
            End If
        End If

    End Sub
End Class