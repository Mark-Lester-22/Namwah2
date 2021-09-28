Public Class AdminDB
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnMenus.Click
        MenuForm.MenusTableAdapter.Fill(MenuForm.NamwahDataSet.Menus)
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        Accounts.AccountsTableAdapter.Fill(Accounts.AccountsDataSet.Accounts)
        Accounts.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
        Login.tbxPassword.Text = ""
        Login.tbxUserName.Text = ""
        MsgBox("Account is logout!")
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Reservation.ReservationTableAdapter.Fill(Reservation.ReservationDS.Reservation)
        Reservation.cbxEventType.SelectedIndex = 0
        Reservation.peopleCount.Value = 1
        Reservation.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Maintenance.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeString
    End Sub

    Private Sub AdminDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateString
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.Show()
        Me.Hide()

    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        Stocks.Show()
        Me.Hide()
    End Sub
End Class
