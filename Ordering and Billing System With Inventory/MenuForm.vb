Imports System.Data.SqlClient
Public Class MenuForm
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles menuType.SelectedIndexChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NamwahDataSet.Menus' table. You can move, or remove it, as needed.
        Dim query As String = String.Empty
        Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
        Dim con As New SqlConnection(constring)
        Dim reader As SqlDataReader


        Try
            con.Open()
            query = "SELECT MAX(CAST(MenuNumber as INT)) as MenuNumber FROM Menus"
            Dim cmd As New SqlCommand(query, con)
            reader = cmd.ExecuteReader()
            If reader.Read() = False Then
                menuNumber.Text = "1"
            Else
                If Not IsDBNull(reader("MenuNumber")) Then
                    menuNumber.Text = Convert.ToInt32(reader("MenuNumber")) + 1
                Else
                    menuNumber.Text = "1"
                End If
            End If
            menuType.SelectedIndex = 0
            menuStatus.SelectedIndex = 0
            menuDiscount.SelectedIndex = 0
            menuPrice.Text = "0.00"
            Me.MenusTableAdapter.Fill(Me.NamwahDataSet.Menus)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Error Message")
        End Try
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If menuNumber.TextLength = 0 Or
           menuName.TextLength = 0 Or
           menuPrice.TextLength = 0 Then

            MsgBox("Fill the required fields.", vbOKOnly, "Missing fields")
            'MsgBox("Number Length" & menuNumber.TextLength & " Name Length" & menuName.TextLength, vbOKOnly, "Missing fields")
        Else
            'Dim con As SqlConnection
            'Dim cmd As SqlCommand
            'Dim rdr As SqlDataReader
            Dim query As String = String.Empty
            Dim menuNum As Integer

            query = "INSERT INTO dbo.Menus(MenuNumber,Name,Details,Price,Type,Status,Discount,createdDateTime)
            VALUES(@colMenuNumber,@colName,@colDetails,@colPrice,@colType,@colStatus,@colDiscount,@colcreatedDateTime)"

            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@colMenuNumber", menuNumber.Text)
                        .Parameters.AddWithValue("@colName", menuName.Text)
                        .Parameters.AddWithValue("@colDetails", menuDetails.Text)
                        .Parameters.AddWithValue("@colPrice", menuPrice.Text)
                        .Parameters.AddWithValue("@colType", menuType.Text)
                        .Parameters.AddWithValue("@colStatus", menuStatus.Text)
                        .Parameters.AddWithValue("@colDiscount", menuDiscount.Text)
                        .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                    End With
                    Try
                        con.Open()
                        cmd.ExecuteNonQuery()
                        menuNum = Convert.ToInt32(menuNumber.Text) + 1
                        menuNumber.Text = menuNum.ToString()
                        menuType.SelectedIndex = 0
                        menuStatus.SelectedIndex = 0
                        menuDiscount.SelectedIndex = 0
                        menuPrice.Text = "0.00"
                        menuName.Text = ""
                        Me.MenusTableAdapter.Fill(Me.NamwahDataSet.Menus)
                        MsgBox("Successfully added!", vbOKOnly, "Success")
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub menuPrice_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles menuPrice.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)

    End Sub

    Private Sub menuNumber_KeyPress(ByVal sender As Object, e As KeyPressEventArgs) Handles menuNumber.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        menuName.Text = ""
        menuPrice.Text = ""
        menuDetails.Text = ""
    End Sub

    Private Sub menusTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles menusTable.CellContentClick
        If e.ColumnIndex = 8 Then
            Dim row As DataGridViewRow = menusTable.Rows(e.RowIndex)
            If MessageBox.Show("Do you want to delete this menu ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                    Using cmd As New SqlCommand("DELETE FROM dbo.Menus WHERE ID = @ID", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@ID", row.Cells("ID").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Me.MenusTableAdapter.Fill(Me.NamwahDataSet.Menus)
            End If
        ElseIf e.ColumnIndex = 9 Then
            Dim row As DataGridViewRow = menusTable.Rows(e.RowIndex)
            Dim query As String = String.Empty
            Dim con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
            query = "UPDATE Menus SET Status = @status WHERE ID = @id"
            con.Open()
            If row.Cells("menusStatus").Value = "Available" Then
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@status", "Unavailable")
                cmd.Parameters.AddWithValue("@id", row.Cells("ID").Value)
                Try
                    cmd.ExecuteNonQuery()
                    Me.MenusTableAdapter.Fill(Me.NamwahDataSet.Menus)
                    MsgBox("Status updated!", vbOKOnly, "Success")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            Else
                Dim cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@status", "Available")
                cmd.Parameters.AddWithValue("@id", row.Cells("ID").Value)
                Try
                    cmd.ExecuteNonQuery()
                    Me.MenusTableAdapter.Fill(Me.NamwahDataSet.Menus)
                    MsgBox("Status updated!", vbOKOnly, "Success")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End If

        End If
    End Sub
End Class