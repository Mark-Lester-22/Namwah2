Imports System.Data.SqlClient
Public Class Delivery
    Private Sub Delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NamwahDataSet.Menus' table. You can move, or remove it, as needed.
        Dim query As String = String.Empty
        Dim ordNum As Integer
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader

        con.Open()

        query = "SELECT MAX(CAST(DeliveryNumber as INT)) as DeliveryNumber FROM Delivery"
        Dim cmd As New SqlCommand(query, con)
        reader = cmd.ExecuteReader()
        If reader.Read() = False Then
            tbxDeliveryNum.Text = "1"
        Else
            If Not IsDBNull(reader("DeliveryNumber")) Then
                tbxDeliveryNum.Text = Convert.ToInt32(reader("DeliveryNumber")) + 1
            Else
                tbxDeliveryNum.Text = "1"
            End If
        End If

        Me.MenusTableAdapter.Fill(Me.NamwahDataSet.Menus)
        cbxServiceCharge.SelectedIndex = 0
    End Sub

    Private Sub menusDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles menusDataGrid.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim row As DataGridViewRow = menusDataGrid.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("menusQuantity").Value Is Nothing Or row.Cells("menusQuantity").Value = "0" Then
                listofmenus.Items.Add(row.Cells("menusName").Value)
                listofprices.Items.Add(row.Cells("menusPrice").Value)
                listofids.Items.Add(row.Cells("menusID").Value)
                listofquantity.Items.Add("1")
                initial = Convert.ToInt32(initialPrice.Text) + row.Cells("menusPrice").Value
                initialPrice.Text = initial
                If cbxServiceCharge.Text = "Yes" Then
                    discPrice = 50
                    totalPrice.Text = initial + discPrice
                Else
                    totalPrice.Text = initial
                End If
            Else
                Try
                    listofprices.Items.Add(row.Cells("menusPrice").Value * row.Cells("menusQuantity").Value)
                    listofmenus.Items.Add(row.Cells("menusName").Value)
                    listofquantity.Items.Add(row.Cells("menusQuantity").Value)
                    listofids.Items.Add(row.Cells("menusID").Value)
                    initial = Convert.ToInt32(initialPrice.Text) + (Convert.ToInt32(row.Cells("menusPrice").Value) * Convert.ToInt32(row.Cells("menusQuantity").Value))
                    initialPrice.Text = initial
                    If cbxServiceCharge.Text = "Yes" Then
                        discPrice = 50
                        totalPrice.Text = initial + discPrice
                    Else
                        totalPrice.Text = initial
                    End If
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try

            End If
        End If
    End Sub

    Private Sub drinksDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles drinksDataGrid.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim row As DataGridViewRow = drinksDataGrid.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("drinksQuantity").Value Is Nothing Or row.Cells("drinksQuantity").Value = "0" Then
                listofmenus.Items.Add(row.Cells("drinksName").Value)
                listofprices.Items.Add(row.Cells("drinksPrice").Value)
                listofids.Items.Add(row.Cells("drinksID").Value)
                listofquantity.Items.Add("1")
                initial = Convert.ToInt32(initialPrice.Text) + row.Cells("drinksPrice").Value
                initialPrice.Text = initial
                If cbxServiceCharge.Text = "Yes" Then
                    discPrice = 50
                    totalPrice.Text = initial + discPrice
                Else
                    totalPrice.Text = initial
                End If
            Else
                Try
                    listofprices.Items.Add(row.Cells("drinksPrice").Value * row.Cells("drinksQuantity").Value)
                    listofmenus.Items.Add(row.Cells("drinksName").Value)
                    listofquantity.Items.Add(row.Cells("drinksQuantity").Value)
                    listofids.Items.Add(row.Cells("drinksID").Value)
                    initial = Convert.ToInt32(initialPrice.Text) + (Convert.ToInt32(row.Cells("drinksPrice").Value) * Convert.ToInt32(row.Cells("drinksQuantity").Value))
                    initialPrice.Text = initial
                    If cbxServiceCharge.Text = "Yes" Then
                        discPrice = 50
                        totalPrice.Text = initial + discPrice
                    Else
                        totalPrice.Text = initial
                    End If
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Empty
        Dim stringofmenus As String = String.Join(",", listofmenus.Items.Cast(Of Object))
        Dim stringofids As String = String.Join(",", listofids.Items.Cast(Of Object))
        Dim stringofprices As String = String.Join(",", listofprices.Items.Cast(Of Object))
        Dim stringofquantity As String = String.Join(",", listofquantity.Items.Cast(Of Object))

        If totalPrice.TextLength = 0 Or totalPrice.Text = "0" Then
            MsgBox("Please make some order before submitting it.")
        Else
            If tbxCustomerName.TextLength = 0 Then
                MsgBox("Please fill out the customer details")
            ElseIf tbxMobileNum.TextLength = 0 Then
                MsgBox("Please fill out the customer details")
            ElseIf tbxAddress.TextLength = 0 Then
                MsgBox("Please fill out the customer details")
            Else
                query = "INSERT INTO dbo.Delivery(MenusID,DeliveryNumber,ListOfMenu,ListOfPrice,MenuQuantity,InitialPrice,TotalPrice,CustomerName,MobileNumber,Address,Status,Discounted,createdDateTime)
                VALUES(@colMenusID,@colDeliveryNumber,@colListOfMenu,@colListOfPrice,@colMenuQuantity,@colInitialPrice,@colTotalPrice,@colCustomerName,@colMobileNumber,@colAddress,@colStatus,@colDiscounted,@colcreatedDateTime)"

                Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                    Using cmd As New SqlCommand()
                        With cmd
                            .Connection = con
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@colMenusID", stringofids.ToString())
                            .Parameters.AddWithValue("@colDeliveryNumber", tbxDeliveryNum.Text)
                            .Parameters.AddWithValue("@colListOfMenu", stringofmenus.ToString())
                            .Parameters.AddWithValue("@colListOfPrice", stringofprices.ToString())
                            .Parameters.AddWithValue("@colMenuQuantity", stringofquantity.ToString())
                            .Parameters.AddWithValue("@colInitialPrice", initialPrice.Text)
                            .Parameters.AddWithValue("@colTotalPrice", totalPrice.Text)
                            .Parameters.AddWithValue("@colStatus", "Pending")
                            .Parameters.AddWithValue("@colCustomerName", tbxCustomerName.Text)
                            .Parameters.AddWithValue("@colMobileNumber", tbxMobileNum.Text)
                            .Parameters.AddWithValue("@colAddress", tbxAddress.Text)
                            .Parameters.AddWithValue("@colDiscounted", cbxServiceCharge.Text)
                            .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                            Try
                                con.Open()
                                cmd.ExecuteNonQuery()
                                MsgBox("Successfully added!", vbOKOnly, "Success")
                                CashierDB.Show()
                                Me.Hide()
                            Catch ex As SqlException
                                MessageBox.Show(ex.Message.ToString(), "Error Message")
                            End Try
                        End With
                    End Using
                End Using
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listofmenus.Items.Clear()
        listofprices.Items.Clear()
        listofquantity.Items.Clear()
        initialPrice.Text = 0
        totalPrice.Text = 0
        tbxCustomerName.Text = ""
        tbxMobileNum.Text = ""
        tbxAddress.Text = ""
        cbxServiceCharge.SelectedIndex = 0

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CashierDB.Show()
        Me.Hide()
    End Sub

    Private Sub cbxServiceCharge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServiceCharge.SelectedIndexChanged
        Dim discPrice As Double
        If cbxServiceCharge.Text = "Yes" Then
            discPrice = 50
            totalPrice.Text = initialPrice.Text + discPrice
        Else
            totalPrice.Text = initialPrice.Text
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub listofids_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listofids.SelectedIndexChanged

    End Sub

    Private Sub btnPrintBill_Click(sender As Object, e As EventArgs) Handles btnPrintBill.Click
        'Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        'Dim con As New SqlConnection(constring)
        'Dim orderReader As SqlDataReader
        'con.Open()
        'Dim getOrder As New SqlCommand("SELECT * FROM Orders WHERE ID = @orderID", con)
        'getOrder.Parameters.AddWithValue("@orderID", tbxOrderID.Text)
        'orderReader = getOrder.ExecuteReader()
        If tbxCustomerName.Text = "" And tbxAddress.Text = "" And tbxMobileNum.Text = "" Then
            MsgBox("Please fill out customer details!")
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
            strPrint = strPrint & "Delivery No.    : " & tbxDeliveryNum.Text & vbCrLf
            strPrint = strPrint & "Customer.       : " & tbxCustomerName.Text & vbCrLf
            strPrint = strPrint & "Address.        : " & tbxAddress.Text & vbCrLf
            strPrint = strPrint & "Phone.          : " & tbxMobileNum.Text & vbCrLf
            strPrint = strPrint & " " & vbCrLf

            strPrint = strPrint & "OFFICIAL DELIVERY RECEIPT" & vbCrLf
            strPrint = strPrint & " " & vbCrLf
            strPrint = strPrint & "Item    Qty.      Cost.      SubTotal" & vbCrLf
            strPrint = strPrint & "----------------------------------" & vbCrLf
            'Dim menuStrArray As String() = orderReader("ListOfMenu").Split(","c)
            'Dim PriceStrArray As String() = orderReader("ListOfPrice").Split(","c)
            'Dim qtyStrArray As String() = orderReader("MenuQuantity").Split(","c)
            For x = 1 To listofmenus.Items.Count() Step 1
                strPrint = strPrint & listofmenus.Items.Item(x - 1) & "  " & listofquantity.Items.Item(x - 1) & "  " & Convert.ToDecimal(listofprices.Items.Item(x - 1)) / Convert.ToInt32(listofquantity.Items.Item(x - 1)) & "  P" & listofprices.Items.Item(x - 1) & vbCrLf
            Next
            strPrint = strPrint & "----------------------------------" & vbCrLf
            strPrint = strPrint & " " & vbCrLf
            strPrint = strPrint & "(Delivery Charges is P50.00 if the area was not in Meycauayan City of the delivery)" & vbCrLf
            strPrint = strPrint & " " & vbCrLf
            strPrint = strPrint & "Total        :    " & totalPrice.Text & vbCrLf
            Printer.Print(strPrint)
        End If
    End Sub
End Class