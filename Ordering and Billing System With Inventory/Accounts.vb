Imports System.Data.SqlClient
Public Class Accounts
    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AccountsDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
        tbxType.SelectedIndex = 0
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles accountsDataGrid.CellContentClick
        If e.ColumnIndex = 9 Then
            Dim row As DataGridViewRow = accountsDataGrid.Rows(e.RowIndex)
            If MessageBox.Show("Do you want to delete this accounts ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                    Using cmd As New SqlCommand("DELETE FROM dbo.Accounts WHERE ID = @ID", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@ID", row.Cells("accountsID").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
            End If

        ElseIf e.ColumnIndex = 10 Then
            Dim row As DataGridViewRow = accountsDataGrid.Rows(e.RowIndex)
            Dim name, email, username, password, type, passrecovery, id As String
            name = row.Cells("accountsName").Value
            email = row.Cells("accountsEmail").Value
            username = row.Cells("accountsUsername").Value
            password = row.Cells("accountsPassword").Value
            type = row.Cells("accountsType").Value
            passrecovery = row.Cells("accountsPassRecovery").Value
            id = row.Cells("accountsID").Value.ToString()

            tbxName.Text = name
            tbxEmail.Text = email
            tbxUsername.Text = username
            tbxPassword.Text = password
            tbxType.Text = type
            tbxRecoveryPass.Text = passrecovery
            tbxID.Text = id

        ElseIf e.ColumnIndex = 11 Then
            Dim row As DataGridViewRow = accountsDataGrid.Rows(e.RowIndex)
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
            Dim con As New SqlConnection(constring)
            con.Open()

            If row.Cells("accountsStatus").Value = "Active" Then
                Dim updateStatus As New SqlCommand("UPDATE Accounts SET Status = @status WHERE ID = @id", con)
                updateStatus.Parameters.AddWithValue("@status", "Inactive")
                updateStatus.Parameters.AddWithValue("@id", row.Cells("accountsID").Value)
                updateStatus.ExecuteNonQuery()
                con.Close()
                Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
                MsgBox("Status Inactive!")
            Else
                Dim updateStatus As New SqlCommand("UPDATE Accounts SET Status = @status WHERE ID = @id", con)
                updateStatus.Parameters.AddWithValue("@status", "Active")
                updateStatus.Parameters.AddWithValue("@id", row.Cells("accountsID").Value)
                updateStatus.ExecuteNonQuery()
                con.Close()
                Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
                MsgBox("Status Active!")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"
        Dim name, email, username, password, type, passrecovery As String
        Dim updateString As String = String.Empty

        name = tbxName.Text
        email = tbxEmail.Text
        username = tbxUsername.Text
        password = tbxPassword.Text
        type = tbxType.Text
        passrecovery = tbxRecoveryPass.Text

        Dim con As New SqlConnection(constring)
        con.Open()

        If tbxName.Text = "" Or tbxName.Text.Length = 0 And tbxUsername.Text = "" Or tbxUsername.Text.Length = 0 And tbxPassword.Text = "" Or tbxPassword.Text.Length = 0 And tbxEmail.Text = "" Or tbxEmail.Text.Length = 0 And tbxRecoveryPass.Text = "" Or tbxRecoveryPass.Text.Length = 0 Then
            MsgBox("No input found, please select the data that you want to edit or fill up all fields completely.")
        Else
            If tbxID.Text Is Nothing Or tbxID.Text = "" Or tbxID.Text.Length = 0 Then
                MsgBox("Please select the account you want to edit")
            Else
                updateString = "UPDATE Accounts SET Name=@name, Username=@username, Password=@password, 
                Email=@email, PassRecovery=@passrecovery, AccountType=@type WHERE ID=@accountID"
                Dim updateAccounts As New SqlCommand(updateString, con)
                updateAccounts.Parameters.AddWithValue("@name", name)
                updateAccounts.Parameters.AddWithValue("@username", username)
                updateAccounts.Parameters.AddWithValue("@password", password)
                updateAccounts.Parameters.AddWithValue("@email", email)
                updateAccounts.Parameters.AddWithValue("@passrecovery", passrecovery)
                updateAccounts.Parameters.AddWithValue("@type", type)
                updateAccounts.Parameters.AddWithValue("@accountID", tbxID.Text)
                updateAccounts.ExecuteNonQuery()
                tbxName.Text = ""
                tbxEmail.Text = ""
                tbxUsername.Text = ""
                tbxPassword.Text = ""
                tbxType.SelectedIndex = 0
                tbxRecoveryPass.Text = ""
                tbxID.Text = ""
                con.Close()
                Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
                MsgBox("Successfully Update!")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxName.Text = ""
        tbxEmail.Text = ""
        tbxUsername.Text = ""
        tbxPassword.Text = ""
        tbxType.SelectedIndex = 0
        tbxRecoveryPass.Text = ""
        tbxID.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0;MultipleActiveResultSets=true"
        Dim name, email, username, password, type, passrecovery As String
        Dim insertString As String = String.Empty
        Dim checkAccountExistReader As SqlDataReader

        name = tbxName.Text
        email = tbxEmail.Text
        username = tbxUsername.Text
        password = tbxPassword.Text
        type = tbxType.Text
        passrecovery = tbxRecoveryPass.Text

        Dim con As New SqlConnection(constring)
        con.Open()

        If tbxName.Text = "" Or tbxName.Text.Length = 0 Then
            MsgBox("Complete to fill out the inputs before adding the account.")
        ElseIf tbxUsername.Text = "" Or tbxUsername.Text.Length = 0 Then
            MsgBox("Complete to fill out the inputs before adding the account.")
        ElseIf tbxPassword.Text = "" Or tbxPassword.Text.Length = 0 Then
            MsgBox("Complete to fill out the inputs before adding the account.")
        ElseIf tbxEmail.Text = "" Or tbxEmail.Text.Length = 0 Then
            MsgBox("Complete to fill out the inputs before adding the account.")
        ElseIf tbxRecoveryPass.Text = "" Or tbxRecoveryPass.Text.Length = 0 Then
            MsgBox("Complete to fill out the inputs before adding the account.")
        ElseIf tbxPassword.Text = "" Or tbxPassword.Text.Length = 0 Then
            MsgBox("Complete to fill out the inputs before adding the account.")
        Else
            If tbxID.Text Is Nothing Or tbxID.Text = "" Or tbxID.Text.Length = 0 Then
                Dim checkAccountExist As New SqlCommand("SELECT * FROM Accounts WHERE Name=@name AND Email=@email AND Username=@username AND Password=@password", con)
                checkAccountExist.Parameters.AddWithValue("@name", name)
                checkAccountExist.Parameters.AddWithValue("@email", email)
                checkAccountExist.Parameters.AddWithValue("@username", username)
                checkAccountExist.Parameters.AddWithValue("@password", password)
                checkAccountExistReader = checkAccountExist.ExecuteReader()

                If checkAccountExistReader.Read() = True Then
                    MsgBox("Account is already exist", vbOKOnly, "Error Message!")

                Else
                    insertString = "INSERT INTO Accounts(Name,Username,Password,AccountType,Email,PassRecovery,Status,createdDateTime)
                    VALUES(@colName,@colUsername,@colPassword,@colAccountType,@colEmail,@colPassRecovery,@colStatus,@colcreatedDateTime)"
                    Dim insertAccount As New SqlCommand(insertString, con)
                    insertAccount.Parameters.AddWithValue("@colName", name)
                    insertAccount.Parameters.AddWithValue("@colUsername", username)
                    insertAccount.Parameters.AddWithValue("@colPassword", password)
                    insertAccount.Parameters.AddWithValue("@colAccountType", type)
                    insertAccount.Parameters.AddWithValue("@colEmail", email)
                    insertAccount.Parameters.AddWithValue("@colPassRecovery", passrecovery)
                    insertAccount.Parameters.AddWithValue("@colStatus", "Active")
                    insertAccount.Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                    insertAccount.ExecuteNonQuery()
                    tbxName.Text = ""
                    tbxEmail.Text = ""
                    tbxUsername.Text = ""
                    tbxPassword.Text = ""
                    tbxType.SelectedIndex = 0
                    tbxRecoveryPass.Text = ""
                    con.Close()
                    Me.AccountsTableAdapter.Fill(Me.AccountsDataSet.Accounts)
                    MsgBox("Successfully Added!")
                End If
            Else
                MsgBox("You're trying to add the exisiting account, if you want to create new account please click the clear button and then fill up all fields. But if you're trying to edit it, please click the button save.")
            End If
        End If
    End Sub
End Class