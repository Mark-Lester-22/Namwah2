Imports System.Data.SqlClient
Public Class ViewOrder
    Private Sub ViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrdersDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.OrdersDataSet.Orders)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ordersDataGrid.CellContentClick
        Dim row As DataGridViewRow = ordersDataGrid.Rows(e.RowIndex)
        If e.ColumnIndex = 3 Then
            lbxMenuItem.Items.Clear()
            lbxMenuQuantity.Items.Clear()
            tbxOrderNum.Text = ""
            tbxLocation.Text = ""
            tbxOrderID.Text = ""

            Dim listofitem, listofitemquantity As String
            Dim items, quantity As List(Of String)
            listofitem = row.Cells("ListOfMenu").Value
            listofitemquantity = row.Cells("MenuQuantity").Value

            tbxOrderNum.Text = row.Cells("OrderNumber").Value
            tbxLocation.Text = row.Cells("Location").Value
            tbxOrderID.Text = row.Cells("ID").Value.ToString()
            lbxMenuItem.Items.AddRange(listofitem.Split(","))
            lbxMenuQuantity.Items.AddRange(listofitemquantity.Split(","))
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.OrdersTableAdapter.Fill(Me.OrdersDataSet.Orders)
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If tbxOrderNum.TextLength = 0 Or tbxOrderID.TextLength = 0 Or tbxLocation.TextLength = 0 Then
            MsgBox("Please Select on orderlist before completing.", vbOKOnly, "Failed")
        Else
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Orders SET Status=@status WHERE ID=@id", con)
            cancelOrder.Parameters.AddWithValue("@status", "Complete")
            cancelOrder.Parameters.AddWithValue("@id", tbxOrderID.Text)
            cancelOrder.ExecuteNonQuery()

            MsgBox("Orders Complete!")

            lbxMenuItem.Items.Clear()
            lbxMenuQuantity.Items.Clear()
            tbxOrderNum.Text = ""
            tbxLocation.Text = ""
            tbxOrderID.Text = ""
            Me.OrdersTableAdapter.Fill(Me.OrdersDataSet.Orders)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Me.Hide()
        Login.tbxPassword.Text = ""
        Login.tbxUserName.Text = ""
        MsgBox("Account is logout!")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class