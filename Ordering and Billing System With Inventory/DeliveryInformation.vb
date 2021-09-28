Imports System.Data.SqlClient
Public Class DeliveryInformation
    Private Sub DeliveryInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DeliveryDS.Delivery' table. You can move, or remove it, as needed.
        Me.DeliveryTableAdapter.Fill(Me.DeliveryDS.Delivery)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CashierDB.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles deliveryDGV.CellContentClick
        Dim row As DataGridViewRow = deliveryDGV.Rows(e.RowIndex)
        If e.ColumnIndex = 16 Then
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Delivery SET Status=@status WHERE ID=@id", con)
            cancelOrder.Parameters.AddWithValue("@status", "Complete")
            cancelOrder.Parameters.AddWithValue("@id", row.Cells("deliveryID").Value)
            cancelOrder.ExecuteNonQuery()
            Me.DeliveryTableAdapter.Fill(Me.DeliveryDS.Delivery)
            MsgBox("Delivery Complete!")

        ElseIf e.ColumnIndex = 17 Then
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Delivery SET Status=@status WHERE ID=@id", con)
            cancelOrder.Parameters.AddWithValue("@status", "Cancelled")
            cancelOrder.Parameters.AddWithValue("@id", row.Cells("deliveryID").Value)
            cancelOrder.ExecuteNonQuery()
            Me.DeliveryTableAdapter.Fill(Me.DeliveryDS.Delivery)
            MsgBox("Delivery Cancelled!")
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.DeliveryTableAdapter.Fill(Me.DeliveryDS.Delivery)
    End Sub
End Class