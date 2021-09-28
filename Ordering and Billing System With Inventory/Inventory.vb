Imports System.Data.SqlClient
Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryDataSet.Inventory' table. You can move, or remove it, as needed.
        cbxMeasurement.SelectedIndex = 0
        cbxType.SelectedIndex = 0
        Me.InventoryTableAdapter.Fill(Me.InventoryDataSet.Inventory)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Empty

        If tbxName.Text = "" Then
            MsgBox("Please input customer name.")
        ElseIf cbxType.Text = "" Then
            MsgBox("Please input customer mobile number.")
        ElseIf cbxMeasurement.Text = "" Then
            MsgBox("Please input customer address.")
        ElseIf tbxTotalPrice.Text = "" Then
            MsgBox("Please input table number.")
        Else
            query = "INSERT INTO dbo.Inventory(Name,Type,Measurement,MeasurementCount,TotalPrice,createdDateTime)
            VALUES(@colName,@colType,@colMeasurement,@colMeasurementCount,@colTotalPrice,@colcreatedDateTime)"

            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@colName", tbxName.Text)
                        .Parameters.AddWithValue("@colType", cbxType.Text)
                        .Parameters.AddWithValue("@colMeasurement", cbxMeasurement.Text)
                        .Parameters.AddWithValue("@colMeasurementCount", measurementCount.Value)
                        .Parameters.AddWithValue("@colTotalPrice", tbxTotalPrice.Text)
                        .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                        Try
                            con.Open()
                            cmd.ExecuteNonQuery()
                            Me.InventoryTableAdapter.Fill(Me.InventoryDataSet.Inventory)
                            MsgBox("Successfully Added!", vbOKOnly, "Success")
                            tbxName.Text = ""
                            cbxType.SelectedIndex = 0
                            cbxMeasurement.SelectedIndex = 0
                            measurementCount.Value = 1
                            tbxTotalPrice.Text = ""
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End With
                End Using
            End Using
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxName.Text = ""
        cbxType.SelectedIndex = 0
        cbxMeasurement.SelectedIndex = 0
        measurementCount.Value = 1
        tbxTotalPrice.Text = ""
    End Sub
End Class