Imports System.Data.SqlClient
Public Class OrderKiosk
    Private Sub OrderKiosk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = String.Empty
        Dim ordNum As Integer
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader


        Try
            con.Open()
            query = "SELECT MAX(CAST(OrderNumber as INT)) as OrderNumber FROM Orders"
            Dim cmd As New SqlCommand(query, con)

            'Dim queryTablesCMD As New SqlCommand("SELECT * FROM TableManagement WHERE Status='Available'", con)
            'Dim adapterTable As New SqlDataAdapter(queryTablesCMD)
            'Dim tablesTable As New DataTable()
            'adapterTable.Fill(tablesTable)
            'tableNumber.DataSource = tablesTable
            'tableNumber.DisplayMember = "TableNum"
            'tableNumber.ValueMember = "ID"

            reader = cmd.ExecuteReader()
            If reader.Read() = False Then
                orderNumber.Text = "1"
            Else
                If Not IsDBNull(reader("OrderNumber")) Then
                    orderNumber.Text = Convert.ToInt32(reader("OrderNumber")) + 1
                Else
                    orderNumber.Text = "1"
                End If
            End If
            Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
            Me.MenusTableAdapter.Fill(Me.MenusDataSet.Menus)
            Me.DiscountManagementTableAdapter.Fill(Me.NamwahDataSet2.DiscountManagement)
            orderType.SelectedIndex = 0
            'discounted.SelectedIndex = 0
            'tableNumber.SelectedIndex = 0
            initialPrice.Text = "0.00"
            totalPrice.Text = "0.00"

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try

    End Sub

    Private Sub mainDishTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles mainDishTable.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewRow = mainDishTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("mainDishQuantity").Value Is Nothing Or row.Cells("mainDishQuantity").Value = "0" Then
                lbxMenuItems.Items.Add(row.Cells("mainDishName").Value)
                lbxMenuPrice.Items.Add(row.Cells("mainDishPrice").Value)
                lbxMenuID.Items.Add(row.Cells("mainDishID").Value)
                lbxMenuQuantity.Items.Add("1")
                initial = Convert.ToDecimal(initialPrice.Text) + row.Cells("mainDishPrice").Value
                initialPrice.Text = initial
                Dim discountQuery As String = String.Empty
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                Dim discountReader As SqlDataReader

                con.Open()
                discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                Dim cmd As New SqlCommand(discountQuery, con)
                cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                discountReader = cmd.ExecuteReader()
                If discountReader.Read() = False Then
                    MsgBox("No data found in discount!", vbOKOnly, "Failed")
                Else
                    If Not IsDBNull(discountReader("Name")) Then
                        discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                        totalPrice.Text = (initial - discPrice)
                    Else
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    End If
                End If
            Else
                Try
                    lbxMenuPrice.Items.Add(row.Cells("mainDishPrice").Value * row.Cells("mainDishQuantity").Value)
                    lbxMenuItems.Items.Add(row.Cells("mainDishName").Value)
                    lbxMenuQuantity.Items.Add(row.Cells("mainDishQuantity").Value)
                    lbxMenuID.Items.Add(row.Cells("mainDishID").Value)
                    initial = Convert.ToDecimal(initialPrice.Text) + (Convert.ToDecimal(row.Cells("mainDishPrice").Value) * Convert.ToDecimal(row.Cells("mainDishQuantity").Value))
                    initialPrice.Text = initial
                    Dim discountQuery As String = String.Empty
                    Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                    Dim con As New SqlConnection(constring)
                    Dim discountReader As SqlDataReader

                    con.Open()
                    discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                    Dim cmd As New SqlCommand(discountQuery, con)
                    cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                    discountReader = cmd.ExecuteReader()
                    If discountReader.Read() = False Then
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    Else
                        If Not IsDBNull(discountReader("Name")) Then
                            discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                            totalPrice.Text = (initial - discPrice)
                        Else
                            MsgBox("No data found in discount!", vbOKOnly, "Failed")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try

            End If
        End If
    End Sub

    Private Sub appetizerTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles appetizerTable.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewRow = appetizerTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double

            If row.Cells("appetizerQuantity").Value Is Nothing Or row.Cells("appetizerQuantity").Value = "0" Then
                lbxMenuItems.Items.Add(row.Cells("appetizerName").Value)
                lbxMenuPrice.Items.Add(row.Cells("appetizerPrice").Value)
                lbxMenuID.Items.Add(row.Cells("appetizerID").Value)
                lbxMenuQuantity.Items.Add("1")
                initial = Convert.ToDecimal(initialPrice.Text) + row.Cells("appetizerPrice").Value
                initialPrice.Text = initial
                Dim discountQuery As String = String.Empty
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                Dim discountReader As SqlDataReader

                con.Open()
                discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                Dim cmd As New SqlCommand(discountQuery, con)
                cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                discountReader = cmd.ExecuteReader()
                If discountReader.Read() = False Then
                    MsgBox("No data found in discount!", vbOKOnly, "Failed")
                Else
                    If Not IsDBNull(discountReader("Name")) Then
                        discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                        totalPrice.Text = (initial - discPrice)
                    Else
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    End If
                End If

            Else
                Try
                    lbxMenuPrice.Items.Add(row.Cells("appetizerPrice").Value * row.Cells("appetizerQuantity").Value)
                    lbxMenuItems.Items.Add(row.Cells("appetizerName").Value)
                    lbxMenuQuantity.Items.Add(row.Cells("appetizerQuantity").Value)
                    lbxMenuID.Items.Add(row.Cells("appetizerID").Value)
                    initial = Convert.ToDecimal(initialPrice.Text) + (Convert.ToDecimal(row.Cells("appetizerPrice").Value) * Convert.ToDecimal(row.Cells("appetizerQuantity").Value))
                    initialPrice.Text = initial
                    Dim discountQuery As String = String.Empty
                    Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                    Dim con As New SqlConnection(constring)
                    Dim discountReader As SqlDataReader

                    con.Open()
                    discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                    Dim cmd As New SqlCommand(discountQuery, con)
                    cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                    discountReader = cmd.ExecuteReader()
                    If discountReader.Read() = False Then
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    Else
                        If Not IsDBNull(discountReader("Name")) Then
                            discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                            totalPrice.Text = (initial - discPrice)
                        Else
                            MsgBox("No data found in discount!", vbOKOnly, "Failed")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try
            End If
        End If
    End Sub

    Private Sub dessertTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dessertTable.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewRow = dessertTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("dessertQuantity").Value Is Nothing Or row.Cells("dessertQuantity").Value = "0" Then
                lbxMenuItems.Items.Add(row.Cells("dessertName").Value)
                lbxMenuPrice.Items.Add(row.Cells("dessertPrice").Value)
                lbxMenuID.Items.Add(row.Cells("dessertID").Value)
                lbxMenuQuantity.Items.Add("1")
                initial = Convert.ToDecimal(initialPrice.Text) + row.Cells("dessertPrice").Value
                initialPrice.Text = initial
                Dim discountQuery As String = String.Empty
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                Dim discountReader As SqlDataReader

                con.Open()
                discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                Dim cmd As New SqlCommand(discountQuery, con)
                cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                discountReader = cmd.ExecuteReader()
                If discountReader.Read() = False Then
                    MsgBox("No data found in discount!", vbOKOnly, "Failed")
                Else
                    If Not IsDBNull(discountReader("Name")) Then
                        discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                        totalPrice.Text = (initial - discPrice)
                    Else
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    End If
                End If
            Else
                Try
                    lbxMenuPrice.Items.Add(row.Cells("dessertPrice").Value * row.Cells("dessertQuantity").Value)
                    lbxMenuItems.Items.Add(row.Cells("dessertName").Value)
                    lbxMenuQuantity.Items.Add(row.Cells("dessertQuantity").Value)
                    lbxMenuID.Items.Add(row.Cells("dessertID").Value)
                    initial = Convert.ToDecimal(initialPrice.Text) + (Convert.ToDecimal(row.Cells("dessertPrice").Value) * Convert.ToDecimal(row.Cells("dessertQuantity").Value))
                    initialPrice.Text = initial
                    Dim discountQuery As String = String.Empty
                    Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                    Dim con As New SqlConnection(constring)
                    Dim discountReader As SqlDataReader

                    con.Open()
                    discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                    Dim cmd As New SqlCommand(discountQuery, con)
                    cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                    discountReader = cmd.ExecuteReader()
                    If discountReader.Read() = False Then
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    Else
                        If Not IsDBNull(discountReader("Name")) Then
                            discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                            totalPrice.Text = (initial - discPrice)
                        Else
                            MsgBox("No data found in discount!", vbOKOnly, "Failed")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try
            End If
        End If
    End Sub

    Private Sub drinksTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles drinksTable.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim row As DataGridViewRow = drinksTable.Rows(e.RowIndex)
            Dim initial As Integer
            Dim discPrice As Double
            If row.Cells("drinksQuantity").Value Is Nothing Or row.Cells("drinksQuantity").Value = "0" Then
                lbxMenuItems.Items.Add(row.Cells("drinksName").Value)
                lbxMenuPrice.Items.Add(row.Cells("drinksPrice").Value)
                lbxMenuID.Items.Add(row.Cells("DrinksID").Value)
                lbxMenuQuantity.Items.Add("1")
                initial = Convert.ToDecimal(initialPrice.Text) + row.Cells("drinksPrice").Value
                initialPrice.Text = initial
                Dim discountQuery As String = String.Empty
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                Dim discountReader As SqlDataReader

                con.Open()
                discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                Dim cmd As New SqlCommand(discountQuery, con)
                cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                discountReader = cmd.ExecuteReader()
                If discountReader.Read() = False Then
                    MsgBox("No data found in discount!", vbOKOnly, "Failed")
                Else
                    If Not IsDBNull(discountReader("Name")) Then
                        discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                        totalPrice.Text = (initial - discPrice)
                    Else
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    End If
                End If
            Else
                Try
                    lbxMenuPrice.Items.Add(row.Cells("drinksPrice").Value * row.Cells("drinksQuantity").Value)
                    lbxMenuItems.Items.Add(row.Cells("drinksName").Value)
                    lbxMenuQuantity.Items.Add(row.Cells("drinksQuantity").Value)
                    lbxMenuID.Items.Add(row.Cells("DrinksID").Value)
                    initial = Convert.ToDecimal(initialPrice.Text) + (Convert.ToDecimal(row.Cells("drinksPrice").Value) * Convert.ToDecimal(row.Cells("drinksQuantity").Value))
                    initialPrice.Text = initial
                    Dim discountQuery As String = String.Empty
                    Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                    Dim con As New SqlConnection(constring)
                    Dim discountReader As SqlDataReader

                    con.Open()
                    discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                    Dim cmd As New SqlCommand(discountQuery, con)
                    cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                    discountReader = cmd.ExecuteReader()
                    If discountReader.Read() = False Then
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    Else
                        If Not IsDBNull(discountReader("Name")) Then
                            discPrice = initial * CDbl(discountReader("DiscountPercent") / 100)
                            totalPrice.Text = (initial - discPrice)
                        Else
                            MsgBox("No data found in discount!", vbOKOnly, "Failed")
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Please input the quantity")
                End Try

            End If

        End If
    End Sub

    Private Sub btnRemoveLastItem_Click(sender As Object, e As EventArgs) Handles btnRemoveLastItem.Click
        If totalPrice.TextLength = 0 Or totalPrice.Text = "0" Then
            MsgBox("Please make some order before removing!")
        Else
            Try
                Dim selectedIndex As Integer
                Dim discPrice As Double

                selectedIndex = lbxMenuItems.SelectedIndex
                If selectedIndex = lbxMenuItems.Items.Count - 1 Then
                    initialPrice.Text = Convert.ToDecimal(initialPrice.Text) - lbxMenuPrice.Items.Item(lbxMenuPrice.Items.Count - 1)
                    lbxMenuItems.Items.RemoveAt(lbxMenuItems.Items.Count - 1)
                    lbxMenuPrice.Items.RemoveAt(lbxMenuPrice.Items.Count - 1)
                    lbxMenuQuantity.Items.RemoveAt(lbxMenuQuantity.Items.Count - 1)
                    lbxMenuID.Items.RemoveAt(lbxMenuID.Items.Count - 1)
                    Dim discountQuery As String = String.Empty
                    Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                    Dim con As New SqlConnection(constring)
                    Dim discountReader As SqlDataReader

                    con.Open()
                    discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                    Dim cmd As New SqlCommand(discountQuery, con)
                    cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                    discountReader = cmd.ExecuteReader()
                    If discountReader.Read() = False Then
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    Else
                        If Not IsDBNull(discountReader("Name")) Then
                            discPrice = initialPrice.Text * CDbl(discountReader("DiscountPercent") / 100)
                            totalPrice.Text = (initialPrice.Text - discPrice)
                        Else
                            MsgBox("No data found in discount!", vbOKOnly, "Failed")
                        End If
                    End If
                Else
                    initialPrice.Text = Convert.ToDecimal(initialPrice.Text) - lbxMenuPrice.Items.Item(selectedIndex)
                    lbxMenuItems.Items.RemoveAt(selectedIndex)
                    lbxMenuPrice.Items.RemoveAt(selectedIndex)
                    lbxMenuQuantity.Items.RemoveAt(selectedIndex)
                    lbxMenuID.Items.RemoveAt(selectedIndex)
                    Dim discountQuery As String = String.Empty
                    Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                    Dim con As New SqlConnection(constring)
                    Dim discountReader As SqlDataReader

                    con.Open()
                    discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
                    Dim cmd As New SqlCommand(discountQuery, con)
                    cmd.Parameters.AddWithValue("@discountName", discounted.Text)

                    discountReader = cmd.ExecuteReader()
                    If discountReader.Read() = False Then
                        MsgBox("No data found in discount!", vbOKOnly, "Failed")
                    Else
                        If Not IsDBNull(discountReader("Name")) Then
                            discPrice = initialPrice.Text * CDbl(discountReader("DiscountPercent") / 100)
                            totalPrice.Text = (initialPrice.Text - discPrice)
                        Else
                            MsgBox("No data found in discount!", vbOKOnly, "Failed")
                        End If
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Select some item", "Error Message")
            End Try
        End If
    End Sub

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click
        lbxMenuItems.Items.Clear()
        lbxMenuPrice.Items.Clear()
        lbxMenuQuantity.Items.Clear()
        lbxMenuID.Items.Clear()
        initialPrice.Text = "0.00"
        totalPrice.Text = "0.00"
    End Sub

    Private Sub discounted_SelectedIndexChanged(sender As Object, e As EventArgs) Handles discounted.SelectedIndexChanged
        Dim discPrice As Double
        'If discounted.Text = "Yes" Then
        '    discPrice = initialPrice.Text * 0.2
        '    totalPrice.Text = (initialPrice.Text - discPrice)
        'Else
        '    totalPrice.Text = initialPrice.Text
        'End If

        Dim discountQuery As String = String.Empty
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim discountReader As SqlDataReader

        con.Open()
        discountQuery = "SELECT * FROM DiscountManagement WHERE Name=@discountName"
        Dim cmd As New SqlCommand(discountQuery, con)
        cmd.Parameters.AddWithValue("@discountName", discounted.Text)

        discountReader = cmd.ExecuteReader()
        If discountReader.Read() = False Then
            MsgBox("No data found in discount!", vbOKOnly, "Failed")
        Else
            If Not IsDBNull(discountReader("Name")) Then
                discPrice = initialPrice.Text * CDbl(discountReader("DiscountPercent") / 100)
                totalPrice.Text = (initialPrice.Text - discPrice)
            Else
                MsgBox("No data found in discount!", vbOKOnly, "Failed")
            End If
        End If
    End Sub

    Private Sub orderNumber_TextChanged(sender As Object, e As KeyPressEventArgs) Handles orderNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tableNumber_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tableNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Empty
        Dim updateTable As String = String.Empty
        Dim stringofmenus As String = String.Join(",", lbxMenuItems.Items.Cast(Of Object))
        Dim stringofids As String = String.Join(",", lbxMenuID.Items.Cast(Of Object))
        Dim stringofprices As String = String.Join(",", lbxMenuPrice.Items.Cast(Of Object))
        Dim stringofquantity As String = String.Join(",", lbxMenuQuantity.Items.Cast(Of Object))
        Dim reader As SqlDataReader
        Dim ordNum As Integer

        If totalPrice.TextLength = 0 Or totalPrice.Text = "0.00" Then
            MsgBox("Please make some order before submitting it.")
        Else
            query = "INSERT INTO dbo.Orders(MenusID,OrderNumber,ListOfMenu,ListOfPrice,MenuQuantity,InitialPrice,TotalPrice,Location,MenusType,Status,Discounted,createdDateTime)
            VALUES(@colMenusID,@colOrderNumber,@colListOfMenu,@colListOfPrice,@colMenuQuantity,@colInitialPrice,@colTotalPrice,@colLocation,@colMenusType,@colStatus,@colDiscounted,@colcreatedDateTime)"
            updateTable = "UPDATE TableManagement SET Status=@tableStatus WHERE ID=@tableID"
            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0")
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@colMenusID", stringofids.ToString())
                        .Parameters.AddWithValue("@colOrderNumber", orderNumber.Text)
                        .Parameters.AddWithValue("@colListOfMenu", stringofmenus.ToString())
                        .Parameters.AddWithValue("@colListOfPrice", stringofprices.ToString())
                        .Parameters.AddWithValue("@colMenuQuantity", stringofquantity.ToString())
                        .Parameters.AddWithValue("@colInitialPrice", initialPrice.Text)
                        .Parameters.AddWithValue("@colTotalPrice", totalPrice.Text)
                        .Parameters.AddWithValue("@colStatus", "Pending")
                        .Parameters.AddWithValue("@colLocation", tableNumber.Text)
                        .Parameters.AddWithValue("@colMenusType", orderType.Text)
                        .Parameters.AddWithValue("@colDiscounted", discounted.Text)
                        .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                        Try
                            con.Open()
                            cmd.ExecuteNonQuery()
                            MsgBox("Successfully added!", vbOKOnly, "Success")
                            ordNum = Convert.ToInt32(orderNumber.Text) + 1
                            orderNumber.Text = ordNum.ToString()
                            lbxMenuItems.Items.Clear()
                            lbxMenuPrice.Items.Clear()
                            lbxMenuQuantity.Items.Clear()
                            lbxMenuID.Items.Clear()
                            initialPrice.Text = "0.00"
                            totalPrice.Text = "0.00"
                            Login.Show()
                            Me.Hide()
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End With
                End Using
                Using updateTableCMD As New SqlCommand()
                    With updateTableCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = updateTable
                        .Parameters.AddWithValue("@tableStatus", "Unavailable")
                        .Parameters.AddWithValue("@tableID", tableNumber.SelectedValue)
                        Try
                            updateTableCMD.ExecuteNonQuery()

                            'Dim queryTablesCMD As New SqlCommand("SELECT * FROM TableManagement WHERE Status='Available'", con)
                            'Dim adapterTable As New SqlDataAdapter(queryTablesCMD)
                            'Dim tablesTable As New DataTable()
                            'adapterTable.Fill(tablesTable)
                            'tableNumber.DataSource = tablesTable
                            'tableNumber.DisplayMember = "TableNum"
                            'tableNumber.ValueMember = "ID"
                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End With
                End Using
            End Using
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        lbxMenuItems.Items.Clear()
        lbxMenuPrice.Items.Clear()
        lbxMenuQuantity.Items.Clear()
        lbxMenuID.Items.Clear()
        tableNumber.SelectedIndex = 0
        initialPrice.Text = "0.00"
        totalPrice.Text = "0.00"
        Login.Show()
        Me.Hide()
    End Sub
End Class