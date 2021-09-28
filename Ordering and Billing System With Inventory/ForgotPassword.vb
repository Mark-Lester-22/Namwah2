Imports System.Data.SqlClient
Public Class ForgotPassword
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim accountQuery As String = String.Empty
        Dim updateQuery As String = String.Empty
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim accountReader As SqlDataReader

        con.Open()
        accountQuery = "SELECT * FROM Accounts WHERE PassRecovery=@passRecovery"
        Dim cmd As New SqlCommand(accountQuery, con)
        cmd.Parameters.AddWithValue("@passRecovery", tbxRecoveryPassword.Text)

        accountReader = cmd.ExecuteReader()
        If accountReader.Read() = False Then
            MsgBox("No data found in account!", vbOKOnly, "Failed")
        Else
            If Not IsDBNull(accountQuery) Then
                accountReader.Close()
                updateQuery = "UPDATE Accounts SET Password=@newPassword WHERE PassRecovery=@passRecovery"
                Dim updateCMD As New SqlCommand(updateQuery, con)
                updateCMD.Parameters.AddWithValue("@newPassword", tbxNewPassword.Text)
                updateCMD.Parameters.AddWithValue("@passRecovery", tbxRecoveryPassword.Text)
                updateCMD.ExecuteNonQuery()
                tbxNewPassword.Text = ""
                tbxRecoveryPassword.Text = ""
                MsgBox("Successfully update!", vbOKOnly, "Success")
            Else
                MsgBox("No data found in account!", vbOKOnly, "Failed")
            End If
        End If
    End Sub
End Class