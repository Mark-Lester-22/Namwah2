Imports System.Data.SqlClient
Public Class Stocks
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StocksDataSet.Stocks' table. You can move, or remove it, as needed.
        Me.StocksTableAdapter.Fill(Me.StocksDataSet.Stocks)
        stockType.SelectedIndex = 0
        stockName.Text = ""
        stockQuantity.Text = ""
        stockDetails.Text = ""
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If stockQuantity.TextLength = 0 Or
           stockName.TextLength = 0 Then

            MsgBox("Fill the required fields.", vbOKOnly, "Missing fields")
            'MsgBox("Number Length" & menuNumber.TextLength & " Name Length" & menuName.TextLength, vbOKOnly, "Missing fields")
        Else
            'Dim con As SqlConnection
            'Dim cmd As SqlCommand
            'Dim rdr As SqlDataReader
            Dim query As String = String.Empty

            query = "INSERT INTO dbo.Stocks(Name,Type,Details,Quantity,createdDateTime)
            VALUES(@colName,@colType,@colDetails,@colQuantity,@colcreatedDateTime)"

            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@colName", stockName.Text)
                        .Parameters.AddWithValue("@colType", stockType.Text)
                        .Parameters.AddWithValue("@colDetails", stockDetails.Text)
                        .Parameters.AddWithValue("@colQuantity", stockQuantity.Text)
                        .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                    End With
                    Try
                        con.Open()
                        cmd.ExecuteNonQuery()
                        stockType.SelectedIndex = 0
                        stockName.Text = ""
                        stockQuantity.Text = ""
                        stockDetails.Text = ""
                        Me.StocksTableAdapter.Fill(Me.StocksDataSet.Stocks)
                        MsgBox("Successfully added!", vbOKOnly, "Success")
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message.ToString(), "Error Message")
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stockType.SelectedIndex = 0
        stockName.Text = ""
        stockQuantity.Text = ""
        stockDetails.Text = ""
    End Sub
End Class