Imports System.Data.SqlClient
Public Class OrdersAdditional
    Private Sub OrdersAdditional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrdersDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.OrdersDataSet.Orders)
        'TODO: This line of code loads data into the 'MenusDataSet.Menus' table. You can move, or remove it, as needed.
        'Dim query As String = String.Empty
        'Dim ordNum As Integer
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        'Dim reader As SqlDataReader
        Dim queryTablesCMD As New SqlCommand("SELECT * FROM Orders WHERE Status='Pending' OR Status='Complete' AND createdDateTime BETWEEN DATEADD(Hour, -2, GETDATE()) AND GETDATE()  ", con)
        Dim adapterTable As New SqlDataAdapter(queryTablesCMD)
        Dim tablesTable As New DataTable()
        adapterTable.Fill(tablesTable)
        cbxOrderNumber.DataSource = tablesTable
        cbxOrderNumber.DisplayMember = "OrderNumber"
        cbxOrderNumber.ValueMember = "ID"
        Me.MenusTableAdapter.Fill(Me.MenusDataSet.Menus)

    End Sub

    Private Sub mainDishTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles mainDishTable.CellContentClick
        If e.ColumnIndex = 10 Then
            Dim row As DataGridViewRow = mainDishTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("mainDishQuantity").Value Is Nothing Or row.Cells("mainDishQuantity").Value = "0" Then
                listofmenus.Items.Add(row.Cells("mainDishName").Value + "(ADD)")
                listofprices.Items.Add(row.Cells("mainDishPrice").Value)
                listofids.Items.Add(row.Cells("mainDishID").Value)
                listofquantity.Items.Add("1")
                initial = Convert.ToDouble(initialPrice.Text) + row.Cells("mainDishPrice").Value
                initialPrice.Text = initial
                totalPrice.Text = initial
            Else
                Try
                    listofprices.Items.Add(row.Cells("mainDishPrice").Value * row.Cells("mainDishQuantity").Value)
                    listofmenus.Items.Add(row.Cells("mainDishName").Value + "(ADD)")
                    listofquantity.Items.Add(row.Cells("mainDishQuantity").Value)
                    listofids.Items.Add(row.Cells("mainDishID").Value)
                    initial = Convert.ToDouble(initialPrice.Text) + (Convert.ToDouble(row.Cells("mainDishPrice").Value) * Convert.ToInt32(row.Cells("mainDishQuantity").Value))
                    initialPrice.Text = initial
                    totalPrice.Text = initial
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try

            End If
        End If
    End Sub
    Private Sub appetizerTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles appetizerTable.CellContentClick
        If e.ColumnIndex = 10 Then
            Dim row As DataGridViewRow = appetizerTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double

            If row.Cells("appetizerQuantity").Value Is Nothing Or row.Cells("appetizerQuantity").Value = "0" Then
                listofmenus.Items.Add(row.Cells("appetizerName").Value + "(ADD)")
                listofprices.Items.Add(row.Cells("appetizerPrice").Value)
                listofids.Items.Add(row.Cells("appetizerID").Value)
                listofquantity.Items.Add("1")
                initial = Convert.ToDouble(initialPrice.Text) + row.Cells("appetizerPrice").Value
                initialPrice.Text = initial
                totalPrice.Text = initial

            Else
                Try
                    listofprices.Items.Add(row.Cells("appetizerPrice").Value * row.Cells("appetizerQuantity").Value)
                    listofmenus.Items.Add(row.Cells("appetizerName").Value + "(ADD)")
                    listofquantity.Items.Add(row.Cells("appetizerQuantity").Value)
                    listofids.Items.Add(row.Cells("appetizerID").Value)
                    initial = Convert.ToDouble(initialPrice.Text) + (Convert.ToDouble(row.Cells("appetizerPrice").Value) * Convert.ToInt32(row.Cells("appetizerQuantity").Value))
                    initialPrice.Text = initial
                    totalPrice.Text = initial
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try
            End If
        End If
    End Sub
    Private Sub dessertTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dessertTable.CellContentClick
        If e.ColumnIndex = 10 Then
            Dim row As DataGridViewRow = dessertTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("dessertQuantity").Value Is Nothing Or row.Cells("dessertQuantity").Value = "0" Then
                listofmenus.Items.Add(row.Cells("dessertName").Value + "(ADD)")
                listofprices.Items.Add(row.Cells("dessertPrice").Value)
                listofids.Items.Add(row.Cells("dessertID").Value)
                listofquantity.Items.Add("1")
                initial = Convert.ToDouble(initialPrice.Text) + row.Cells("dessertPrice").Value
                initialPrice.Text = initial
                totalPrice.Text = initial
            Else
                Try
                    listofprices.Items.Add(row.Cells("dessertPrice").Value * row.Cells("dessertQuantity").Value)
                    listofmenus.Items.Add(row.Cells("dessertName").Value + "(ADD)")
                    listofquantity.Items.Add(row.Cells("dessertQuantity").Value)
                    listofids.Items.Add(row.Cells("dessertID").Value)
                    initial = Convert.ToDouble(initialPrice.Text) + (Convert.ToDouble(row.Cells("dessertPrice").Value) * Convert.ToInt32(row.Cells("dessertQuantity").Value))
                    initialPrice.Text = initial
                    totalPrice.Text = initial
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try
            End If
        End If
    End Sub
    Private Sub drinksTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles drinksTable.CellContentClick
        If e.ColumnIndex = 10 Then
            Dim row As DataGridViewRow = drinksTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("drinksQuantity").Value Is Nothing Or row.Cells("drinksQuantity").Value = "0" Then
                listofmenus.Items.Add(row.Cells("drinksName").Value + "(ADD)")
                listofprices.Items.Add(row.Cells("drinksPrice").Value)
                listofids.Items.Add(row.Cells("DrinksID").Value)
                listofquantity.Items.Add("1")
                initial = Convert.ToDouble(initialPrice.Text) + row.Cells("drinksPrice").Value
                initialPrice.Text = initial
                totalPrice.Text = initial
            Else
                Try
                    listofprices.Items.Add(row.Cells("drinksPrice").Value * row.Cells("drinksQuantity").Value)
                    listofmenus.Items.Add(row.Cells("drinksName").Value + "(ADD)")
                    listofquantity.Items.Add(row.Cells("drinksQuantity").Value)
                    listofids.Items.Add(row.Cells("DrinksID").Value)
                    initial = Convert.ToDouble(initialPrice.Text) + (Convert.ToDouble(row.Cells("drinksPrice").Value) * Convert.ToInt32(row.Cells("drinksQuantity").Value))
                    initialPrice.Text = initial
                    totalPrice.Text = initial
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try

            End If

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CashierDB.Show()
        Me.Hide()
    End Sub
    'Public Function Split(ByVal ParamArray separator() As Char) As String()

    'End Function
    Private Sub cbxOrderNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrderNumber.SelectedIndexChanged
        Dim strArr() As String
        Dim listOfMenu As List(Of String)
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim orderReader As SqlDataReader
        'Dim orderNumID As New Guid()
        'orderNumID = Guid.Parse(cbxOrderNumber.SelectedValue.ToString())
        con.Open()
        Dim queryOrders As New SqlCommand("SELECT * FROM Orders WHERE OrderNumber=@orderID ", con)
        queryOrders.Parameters.AddWithValue("@orderID", cbxOrderNumber.Text)
        orderReader = queryOrders.ExecuteReader()
        Try
            listofmenus.Items.Clear()
            listofprices.Items.Clear()
            listofquantity.Items.Clear()
            listofids.Items.Clear()
            If orderReader.Read() = False Then
                MsgBox("No order found!")
            Else
                Dim menuStrArray As String() = orderReader("ListOfMenu").Split(","c)
                For Each menuitem As String In menuStrArray
                    listofmenus.Items.Add(menuitem.Trim())
                Next

                Dim PriceStrArray As String() = orderReader("ListOfPrice").Split(","c)
                For Each priceitem As String In PriceStrArray
                    listofprices.Items.Add(priceitem.Trim())
                Next

                Dim qtyStrArray As String() = orderReader("MenuQuantity").Split(","c)
                For Each qtyitem As String In qtyStrArray
                    listofquantity.Items.Add(qtyitem.Trim())
                Next

                Dim menuIDStrArray As String() = orderReader("MenusID").Split(","c)
                For Each menuIDitem As String In menuIDStrArray
                    listofids.Items.Add(menuIDitem.Trim())
                Next

                tbxTableNumber.Text = orderReader("Location")
                tbxOrderType.Text = orderReader("MenusType")
                initialPrice.Text = orderReader("InitialPrice")
                totalPrice.Text = orderReader("TotalPrice")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
    End Sub

    Private Sub btnRemoveLastItem_Click(sender As Object, e As EventArgs) Handles btnRemoveLastItem.Click
        If totalPrice.TextLength = 0 Or totalPrice.Text = "0" Then
            MsgBox("Please make some order before removing!")
        Else
            Try
                Dim selectedIndex As Integer
                Dim discPrice As Double
                selectedIndex = listofmenus.SelectedIndex
                If selectedIndex = listofmenus.Items.Count - 1 Then
                    initialPrice.Text = Convert.ToInt32(initialPrice.Text) - listofprices.Items.Item(listofprices.Items.Count - 1)
                    listofmenus.Items.RemoveAt(listofmenus.Items.Count - 1)
                    listofprices.Items.RemoveAt(listofprices.Items.Count - 1)
                    listofquantity.Items.RemoveAt(listofquantity.Items.Count - 1)
                    listofids.Items.RemoveAt(listofids.Items.Count - 1)
                    totalPrice.Text = initialPrice.Text
                Else
                    listofmenus.Items.RemoveAt(selectedIndex)
                    listofprices.Items.RemoveAt(selectedIndex)
                    listofquantity.Items.RemoveAt(selectedIndex)
                    listofids.Items.RemoveAt(selectedIndex)
                    initialPrice.Text = Convert.ToInt32(initialPrice.Text) - listofprices.Items.Item(selectedIndex)
                    totalPrice.Text = initialPrice.Text
                End If
            Catch ex As Exception
                MessageBox.Show("Select some item", "Error Message")
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Empty
        Dim updateTable As String = String.Empty
        Dim stringofmenus As String = String.Join(",", listofmenus.Items.Cast(Of Object))
        Dim stringofids As String = String.Join(",", listofids.Items.Cast(Of Object))
        Dim stringofprices As String = String.Join(",", listofprices.Items.Cast(Of Object))
        Dim stringofquantity As String = String.Join(",", listofquantity.Items.Cast(Of Object))
        Dim reader As SqlDataReader
        Dim ordNum As Integer

        If totalPrice.TextLength = 0 Or totalPrice.Text = "0" Then
            MsgBox("Please make some order before submitting it.")
        Else
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Orders SET ListOfMenu=@listofmenu, ListOfPrice=@listofprice, MenuQuantity=@menuqty, MenusID=@menuID, InitialPrice=@initialprice, TotalPrice=@totalprice, Status=@status WHERE OrderNumber=@ordernumber", con)
            cancelOrder.Parameters.AddWithValue("@listofmenu", stringofmenus.ToString())
            cancelOrder.Parameters.AddWithValue("@listofprice", stringofprices.ToString())
            cancelOrder.Parameters.AddWithValue("@menuqty", stringofquantity.ToString())
            cancelOrder.Parameters.AddWithValue("@menuID", stringofids.ToString())
            cancelOrder.Parameters.AddWithValue("@initialprice", initialPrice.Text)
            cancelOrder.Parameters.AddWithValue("@totalprice", totalPrice.Text)
            cancelOrder.Parameters.AddWithValue("@status", "Additional")
            cancelOrder.Parameters.AddWithValue("@ordernumber", cbxOrderNumber.Text)
            cancelOrder.ExecuteNonQuery()

            Dim queryTablesCMD As New SqlCommand("SELECT * FROM Orders WHERE Status='Pending' OR Status='Complete' AND createdDateTime BETWEEN DATEADD(Hour, -2, GETDATE()) AND GETDATE()  ", con)
            Dim adapterTable As New SqlDataAdapter(queryTablesCMD)
            Dim tablesTable As New DataTable()
            adapterTable.Fill(tablesTable)
            cbxOrderNumber.DataSource = tablesTable
            cbxOrderNumber.DisplayMember = "OrderNumber"
            cbxOrderNumber.ValueMember = "ID"
            Me.OrdersTableAdapter.Fill(Me.OrdersDataSet.Orders)
            Me.MenusTableAdapter.Fill(Me.MenusDataSet.Menus)
            MsgBox("Successfully updated!")
        End If
    End Sub

    Private Sub btnPrintBill_Click(sender As Object, e As EventArgs) Handles btnPrintBill.Click
        'Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        'Dim con As New SqlConnection(constring)
        'Dim orderReader As SqlDataReader
        'con.Open()
        'Dim getOrder As New SqlCommand("SELECT * FROM Orders WHERE ID = @orderID", con)
        'getOrder.Parameters.AddWithValue("@orderID", tbxOrderID.Text)
        'orderReader = getOrder.ExecuteReader()
        If totalPrice.Text = "" Then
            MsgBox("No order found!")
        Else
            Dim strPrint, cashName, RestaurantName, Address, Phone As String
            Dim cashierName As String() = CashierDB.lblWelcomeMsg.Text.Split(","c)
            RestaurantName = "Namwah Cuisine"
            Address = "269 Meycauayan Camalig, Meycauayan"
            Phone = "0936 231 1325"

            strPrint = RestaurantName & vbCrLf
            strPrint = strPrint & Address & vbCrLf
            strPrint = strPrint & Phone & vbCrLf
            strPrint = strPrint & "Date Printed: " & DateTime.Now() & vbCrLf
            strPrint = strPrint & "----------------------------------" & vbCrLf
            strPrint = strPrint & "Order No.    : " & cbxOrderNumber.Text & vbCrLf
            strPrint = strPrint & "Table No.    : " & tbxTableNumber.Text & vbCrLf
            strPrint = strPrint & "Cashier      : " & cashierName(1).Trim().ToString() & vbCrLf
            strPrint = strPrint & " " & vbCrLf

            strPrint = strPrint & "OFFICIAL RECEIPT" & vbCrLf
            strPrint = strPrint & " " & vbCrLf
            strPrint = strPrint & "Item    Qty.      Cost.      SubTotal" & vbCrLf
            strPrint = strPrint & "----------------------------------" & vbCrLf
            'Dim menuStrArray As String() = orderReader("ListOfMenu").Split(","c)
            'Dim PriceStrArray As String() = orderReader("ListOfPrice").Split(","c)
            'Dim qtyStrArray As String() = orderReader("MenuQuantity").Split(","c)
            For x = 1 To listofmenus.Items.Count() Step 1
                strPrint = strPrint & listofmenus.Items.Item(x - 1) & "  " & listofquantity.Items.Item(x - 1) & "  " & Convert.ToDecimal(listofprices.Items.Item(x - 1)) / Convert.ToInt32(listofquantity.Items.Item(x - 1)) & "  P" & listofprices.Items.Item(x - 1) & vbCrLf
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
            strPrint = strPrint & " " & vbCrLf
            strPrint = strPrint & "(For additional orders, receipt from previous will be updated and the total will change. Please make sure to pay the additional orders)" & vbCrLf
            strPrint = strPrint & " " & vbCrLf
            strPrint = strPrint & "Total        :    " & totalPrice.Text & vbCrLf
            Printer.Print(strPrint)
            'MsgBox(menuStrArray.Length())
        End If
    End Sub

    Private Sub TotalPriceLabel_Click(sender As Object, e As EventArgs) Handles TotalPriceLabel.Click

    End Sub
End Class