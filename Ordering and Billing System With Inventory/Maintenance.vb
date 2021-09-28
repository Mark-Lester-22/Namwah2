Imports System.Data.SqlClient
Public Class Maintenance
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DiscountManagementTableAdapter.Fill(Me.DiscountMangement.DiscountManagement)
        Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String

        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF

        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub btnAddTable_Click(sender As Object, e As EventArgs) Handles btnAddTable.Click
        If tbxTableNum.Text Is Nothing Or tbxTableNum.Text = "" Then
            MsgBox("Please Fill up the field before adding.")
        Else
            Dim query As String = String.Empty
            Dim reader As SqlDataReader
            query = "INSERT INTO dbo.TableManagement(TableNum,Details,Status,createdDateTime)
            VALUES(@colTableNum,@colDetails,@colStatus,@colcreatedDateTime)"

            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0")
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@colTableNum", tbxTableNum.Text)
                        .Parameters.AddWithValue("@colDetails", tbxTableDetails.Text)
                        .Parameters.AddWithValue("@colStatus", "Available")
                        .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                        Try
                            con.Open()
                            cmd.ExecuteNonQuery()
                            Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
                            MsgBox("Added Successfully!", vbOKOnly, "Success")
                            tbxTableNum.Text = ""
                            tbxTableDetails.Text = ""
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End With
                End Using
            End Using
        End If
    End Sub

    Private Sub TableManagementDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableManagementDGV.CellContentClick
        Dim row As DataGridViewRow = TableManagementDGV.Rows(e.RowIndex)
        If e.ColumnIndex = 5 Then
            If row.Cells("tableManagementStatus").Value = "Available" Then
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                con.Open()
                Dim updateStatus As New SqlCommand("UPDATE TableManagement SET Status=@status WHERE ID=@id", con)
                updateStatus.Parameters.AddWithValue("@status", "Unavailable")
                updateStatus.Parameters.AddWithValue("@id", row.Cells("tableManagementID").Value)
                updateStatus.ExecuteNonQuery()
                Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
                MsgBox("Status Change Complete!")
            Else
                Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
                Dim con As New SqlConnection(constring)
                con.Open()
                Dim updateStatus As New SqlCommand("UPDATE TableManagement SET Status=@status WHERE ID=@id", con)
                updateStatus.Parameters.AddWithValue("@status", "Available")
                updateStatus.Parameters.AddWithValue("@id", row.Cells("tableManagementID").Value)
                updateStatus.ExecuteNonQuery()
                Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
                MsgBox("Status Change Complete!")
            End If
        ElseIf e.ColumnIndex = 6 Then
            If MessageBox.Show("Do you want to delete this table ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True")
                    Using cmd As New SqlCommand("DELETE FROM dbo.TableManagement WHERE ID = @ID", con)
                        cmd.CommandType = CommandType.Text
                        cmd.Parameters.AddWithValue("@ID", row.Cells("tableManagementID").Value)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
                Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
            End If
        End If
    End Sub

    Private Sub tbxTableNum_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxTableNum.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub btnClearTable_Click(sender As Object, e As EventArgs) Handles btnClearTable.Click
        tbxTableNum.Text = ""
        tbxTableDetails.Text = ""
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles discountManagementGrid.CellContentClick
        Dim row As DataGridViewRow = discountManagementGrid.Rows(e.RowIndex)
        If e.ColumnIndex = 5 Then
            discountName.Text = ""
            discountPercentage.Text = "0"
            discountDetails.Text = ""
            discountID.Text = ""

            discountName.Text = row.Cells("discountManagementName").Value
            discountPercentage.Text = row.Cells("DiscountPercent").Value
            discountDetails.Text = row.Cells("Details").Value
            discountID.Text = row.Cells("discountManagementID").Value.ToString()

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If discountName.TextLength = 0 Then
            MsgBox("Missing Field Required", vbOKOnly, "Failed")
        Else
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
            Dim con As New SqlConnection(constring)
            con.Open()
            If discountID.TextLength = 0 Then
                Dim insertDiscount As New SqlCommand("INSERT INTO DiscountManagement (Name,Details,DiscountPercent,createdDateTime) VALUES (@discountName,@discountDetails,@discountPercent,@createdDateTime)", con)
                insertDiscount.Parameters.AddWithValue("@discountName", discountName.Text)
                insertDiscount.Parameters.AddWithValue("@discountDetails", discountDetails.Text)
                insertDiscount.Parameters.AddWithValue("@discountPercent", discountPercentage.Text)
                insertDiscount.Parameters.AddWithValue("@createdDateTime", DateTime.Now())
                insertDiscount.ExecuteNonQuery()
                Me.DiscountManagementTableAdapter.Fill(Me.DiscountMangement.DiscountManagement)
                discountName.Text = ""
                discountPercentage.Text = "0"
                discountDetails.Text = ""
                discountID.Text = ""
                MsgBox("Successfully added!")
            Else
                Dim updateStatus As New SqlCommand("UPDATE DiscountManagement SET Name=@name,Details=@details,DiscountPercent=@discountPercent WHERE ID=@discountID", con)
                updateStatus.Parameters.AddWithValue("@name", discountName.Text)
                updateStatus.Parameters.AddWithValue("@details", discountDetails.Text)
                updateStatus.Parameters.AddWithValue("@discountPercent", discountPercentage.Text)
                updateStatus.Parameters.AddWithValue("@discountID", discountID.Text)
                updateStatus.ExecuteNonQuery()
                Me.DiscountManagementTableAdapter.Fill(Me.DiscountMangement.DiscountManagement)
                discountName.Text = ""
                discountPercentage.Text = "0"
                discountDetails.Text = ""
                discountID.Text = ""
                MsgBox("Update Complete!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If discountID.TextLength = 0 Then
            MsgBox("Please select into the list before deleting/you can't delete your current adding discount must be add first before deleting.", vbOKOnly, "Failed")
        Else
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim deleteDiscount As New SqlCommand("DELETE FROM DiscountManagement WHERE ID=@discountID", con)
            deleteDiscount.Parameters.AddWithValue("@discountID", discountID.Text)
            deleteDiscount.ExecuteNonQuery()
            Me.DiscountManagementTableAdapter.Fill(Me.DiscountMangement.DiscountManagement)
            discountName.Text = ""
            discountPercentage.Text = "0"
            discountDetails.Text = ""
            discountID.Text = ""
            MsgBox("Deleted!")
        End If
    End Sub
End Class

'Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
'Dim con As New SqlConnection(constring)
'con.Open()
'Dim updateStatus As New SqlCommand("UPDATE TableManagement SET Status=@status WHERE ID=@id", con)
'updateStatus.Parameters.AddWithValue("@status", "Unavailable")
'updateStatus.Parameters.AddWithValue("@id", row.Cells("tableManagementID").Value)
'updateStatus.ExecuteNonQuery()
'Me.TableManagementTableAdapter.Fill(Me.TableManagementDS.TableManagement)
'MsgBox("Status Change Complete!")