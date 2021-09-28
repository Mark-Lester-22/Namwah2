Imports System.Data.SqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim username, password, name As String
        Dim accounts As New List(Of String)

        username = tbxUserName.Text
        password = tbxPassword.Text
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader

        con.Open()

        Dim cmd As New SqlCommand("SELECT * FROM Accounts WHERE Username=@user AND Password=@pass AND Status='Active'", con)
        cmd.Parameters.AddWithValue("@user", username)
        cmd.Parameters.AddWithValue("@pass", password)
        reader = cmd.ExecuteReader()
        If reader.Read() = False Then
            MsgBox("User can't find!", vbOKOnly, "Error Message!")
        Else
            If reader("AccountType") = "Cashier" Then
                name = reader("Name")
                CashierDB.tbxCashierName.Text = name
                CashierDB.Show()
                Me.Hide()
            ElseIf reader("AccountType") = "Admin" Then
                name = reader("Name")
                AdminDB.Show()
                Me.Hide()
            ElseIf reader("AccountType") = "Kitchen" Then
                name = reader("Name")
                ViewOrder.Show()
                Me.Hide()
            Else
                MsgBox("Can't find the account type", vbOKOnly, "Error Message!")
            End If
        End If


        'MsgBox("User can't find!", vbOKOnly, "Error Message!")

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnGoKiosk_Click(sender As Object, e As EventArgs) Handles btnGoKiosk.Click
        OrderKiosk.MenusTableAdapter.Fill(OrderKiosk.MenusDataSet.Menus)
        OrderKiosk.TableManagementTableAdapter.Fill(OrderKiosk.TableManagementDS.TableManagement)
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
            OrderKiosk.tableNumber.DataSource = tablesTable
            OrderKiosk.tableNumber.DisplayMember = "TableNum"
            OrderKiosk.tableNumber.ValueMember = "ID"

            reader = cmd.ExecuteReader()
            If reader.Read() = False Then
                OrderKiosk.orderNumber.Text = "1"
            Else
                If Not IsDBNull(reader("OrderNumber")) Then
                    OrderKiosk.orderNumber.Text = Convert.ToInt32(reader("OrderNumber")) + 1
                Else
                    OrderKiosk.orderNumber.Text = "1"
                End If
            End If

            OrderKiosk.orderType.SelectedIndex = 0
            'OrdersForm.discounted.SelectedIndex = 0
            OrderKiosk.tableNumber.SelectedIndex = 0
            OrderKiosk.totalPrice.Text = "0.00"
            OrderKiosk.initialPrice.Text = "0.00"

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
        OrderKiosk.Show()
        Me.Hide()
    End Sub
    Private Sub btnForgotPass_Click(sender As Object, e As EventArgs) Handles btnForgotPass.Click
        ForgotPassword.Show()
        Me.Hide()
    End Sub
End Class