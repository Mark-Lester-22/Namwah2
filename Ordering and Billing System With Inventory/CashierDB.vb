Imports System.Data.SqlClient
Public Class CashierDB
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblWelcomeMsg.Click

    End Sub

    Private Sub CashierDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateString
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        OrdersForm.MenusTableAdapter.Fill(OrdersForm.NamwahDataSet.Menus)
        OrdersForm.TableManagementTableAdapter.Fill(OrdersForm.TableManagementDS.TableManagement)
        Dim query As String = String.Empty
        Dim ordNum As Integer
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader

        Try
            con.Open()
            query = "SELECT MAX(CAST(OrderNumber as INT)) as OrderNumber FROM Orders"
            Dim cmd As New SqlCommand(query, con)

            Dim queryTablesCMD As New SqlCommand("SELECT * FROM TableManagement WHERE Status='Available' ORDER BY TableNum", con)
            Dim adapterTable As New SqlDataAdapter(queryTablesCMD)
            Dim tablesTable As New DataTable()
            adapterTable.Fill(tablesTable)
            OrdersForm.tableNumber.DataSource = tablesTable
            OrdersForm.tableNumber.DisplayMember = "TableNum"
            OrdersForm.tableNumber.ValueMember = "ID"

            reader = cmd.ExecuteReader()
            If reader.Read() = False Then
                OrdersForm.orderNumber.Text = "1"
            Else
                If Not IsDBNull(reader("OrderNumber")) Then
                    OrdersForm.orderNumber.Text = Convert.ToInt32(reader("OrderNumber")) + 1
                Else
                    OrdersForm.orderNumber.Text = "1"
                End If
            End If

            OrdersForm.orderType.SelectedIndex = 0
            'OrdersForm.discounted.SelectedIndex = 0
            OrdersForm.tableNumber.SelectedIndex = 0
            OrdersForm.totalPrice.Text = "0.00"
            OrdersForm.initialPrice.Text = "0.00"

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        OrdersForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        Billing.OrdersTableAdapter.Fill(Billing.NamwahOrdersDataSet.Orders)
        Dim query As String = String.Empty
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader

        con.Open()

        query = "SELECT MAX(CAST(BillingNumber as INT)) as BillingNumber FROM Billings"
        Dim cmd As New SqlCommand(query, con)
        reader = cmd.ExecuteReader()
        If reader.Read() = False Then
            Billing.txtboxBillingNum.Text = "1"
        Else
            If Not IsDBNull(reader("BillingNumber")) Then
                Billing.txtboxBillingNum.Text = Convert.ToInt32(reader("BillingNumber")) + 1
            Else
                Billing.txtboxBillingNum.Text = "1"
            End If
        End If
        'TODO: This line of code loads data into the 'NamwahOrdersDataSet.Orders' table. You can move, or remove it, as needed.
        Billing.txtboxTotal.Text = "0.00"
        Billing.txtboxPayments.Text = "0.00"
        Billing.txtboxChange.Text = "0.00"
        Billing.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()

        Login.tbxPassword.Text = ""
        Login.tbxUserName.Text = ""
        MsgBox("Account is logout!")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Delivery.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeliveryInformation.DeliveryTableAdapter.Fill(DeliveryInformation.DeliveryDS.Delivery)
        DeliveryInformation.Show()
        Me.Hide()
    End Sub

    Private Sub btnTables_Click(sender As Object, e As EventArgs) Handles btnTables.Click
        CashierTables.TableManagementTableAdapter.Fill(CashierTables.TableManagementDS.TableManagement)
        CashierTables.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        'Dim reader As SqlDataReader
        Dim queryTablesCMD As New SqlCommand("SELECT * FROM Orders WHERE Status='Pending' OR Status='Complete' AND createdDateTime BETWEEN DATEADD(Hour, -2, GETDATE()) AND GETDATE()  ", con)
        Dim adapterTable As New SqlDataAdapter(queryTablesCMD)
        Dim tablesTable As New DataTable()
        adapterTable.Fill(tablesTable)
        OrdersAdditional.cbxOrderNumber.DataSource = tablesTable
        OrdersAdditional.cbxOrderNumber.DisplayMember = "OrderNumber"
        OrdersAdditional.cbxOrderNumber.ValueMember = "ID"
        OrdersAdditional.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class