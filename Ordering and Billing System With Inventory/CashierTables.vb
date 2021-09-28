Imports System.Data.SqlClient
Public Class CashierTables
    Private Sub CashierTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TableManagementDS.TableManagement' table. You can move, or remove it, as needed.
        Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)

    End Sub

    Private Sub tablesDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablesDGV.CellContentClick
        Dim row As DataGridViewRow = tablesDGV.Rows(e.RowIndex)
        If e.ColumnIndex = 5 Then
            If row.Cells("tableStatus").Value = "Available" Then
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                con.Open()
                Dim updateStatus As New SqlCommand("UPDATE TableManagement SET Status=@status WHERE ID=@id", con)
                updateStatus.Parameters.AddWithValue("@status", "Unavailable")
                updateStatus.Parameters.AddWithValue("@id", row.Cells("tableID").Value)
                updateStatus.ExecuteNonQuery()
                Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
                MsgBox("Status Change Complete!")
            Else
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                con.Open()
                Dim updateStatus As New SqlCommand("UPDATE TableManagement SET Status=@status WHERE ID=@id", con)
                updateStatus.Parameters.AddWithValue("@status", "Available")
                updateStatus.Parameters.AddWithValue("@id", row.Cells("tableID").Value)
                updateStatus.ExecuteNonQuery()
                Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
                MsgBox("Status Change Complete!")
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CashierDB.Show()
        Me.Hide()
    End Sub
End Class