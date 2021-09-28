Imports System.Data.SqlClient
Public Class Reservation
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReservationDS.Reservation' table. You can move, or remove it, as needed.
        tbxAmount.Text = "0.00"
        tbxDownPayment.Text = "0.00"
        cbxEventType.SelectedIndex = 0
        schedDateTime.Format = DateTimePickerFormat.Custom
        schedDateTime.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"
        tbxCode.Text = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds).ToString()
        Me.ReservationTableAdapter.Fill(Me.ReservationDS.Reservation)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = String.Empty
        Dim reader As SqlDataReader
        Dim ordNum As Integer

        If tbxName.Text = "" Then
            MsgBox("Please input customer name.")
        ElseIf tbxMobileNum.Text = "" Then
            MsgBox("Please input customer mobile number.")
        ElseIf tbxAddress.Text = "" Then
            MsgBox("Please input customer address.")
        ElseIf tbxTableNum.Text = "" Then
            MsgBox("Please input table number.")
        ElseIf tbxAmount.Text = "" Then
            MsgBox("Please input the amount of reservation.")
        ElseIf tbxDownPayment.Text = "" Then
            MsgBox("Please input the amount of reservation.")
        Else
            query = "INSERT INTO dbo.Reservation(Code,CustomerName,Email,Address,MobileNum,TableNumber,NumOfPeople,Status,SchedDateTime,Price,DownPayment,EventName,EventType,createdDateTime)
            VALUES(@colCode,@colCustomerName,@colEmail,@colAddress,@colMobileNum,@colTableNumber,@colNumOfPeople,@colStatus,@colSchedDateTime,@colPrice,@colDownPayment,@colEventName,@colEventType,@colcreatedDateTime)"

            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0")
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@colCode", tbxCode.Text)
                        .Parameters.AddWithValue("@colCustomerName", tbxName.Text)
                        .Parameters.AddWithValue("@colEmail", tbxEmail.Text)
                        .Parameters.AddWithValue("@colAddress", tbxAddress.Text)
                        .Parameters.AddWithValue("@colMobileNum", tbxMobileNum.Text)
                        .Parameters.AddWithValue("@colTableNumber", tbxTableNum.Text)
                        .Parameters.AddWithValue("@colNumOfPeople", peopleCount.Value)
                        .Parameters.AddWithValue("@colStatus", "Reserved")
                        .Parameters.AddWithValue("@colSchedDateTime", schedDateTime.Value)
                        .Parameters.AddWithValue("@colPrice", tbxAmount.Text)
                        .Parameters.AddWithValue("@colDownPayment", tbxDownPayment.Text)
                        .Parameters.AddWithValue("@colEventName", tbxEventName.Text)
                        .Parameters.AddWithValue("@colEventType", cbxEventType.Text)
                        .Parameters.AddWithValue("@colcreatedDateTime", DateTime.Now())
                        Try
                            con.Open()
                            cmd.ExecuteNonQuery()
                            Me.ReservationTableAdapter.Fill(Me.ReservationDS.Reservation)
                            MsgBox("Reserved Successfully!", vbOKOnly, "Success")
                            tbxName.Text = ""
                            tbxEmail.Text = ""
                            tbxMobileNum.Text = ""
                            tbxTableNum.Text = ""
                            tbxAddress.Text = ""
                            tbxAmount.Text = "0.00"
                            tbxDownPayment.Text = "0.00"
                            tbxEventName.Text = ""
                            cbxEventType.SelectedIndex = 0
                            peopleCount.Value = 1
                        Catch ex As SqlException
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End With
                End Using
            End Using
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxName.Text = ""
        tbxEmail.Text = ""
        tbxMobileNum.Text = ""
        tbxTableNum.Text = ""
        tbxAddress.Text = ""
        tbxAmount.Text = "0.00"
        tbxDownPayment.Text = "0.00"
        tbxEventName.Text = ""
        cbxEventType.SelectedIndex = 0
        peopleCount.Value = 1
        tbxCode.Text = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds).ToString()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub tbxMobileNum_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxMobileNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbxTableNum_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxTableNum.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tbxAmount_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxAmount.KeyPress
        'Dim stateSlsTax As Decimal
        'stateSlsTax = Convert.ToDecimal(tbxAmount.Text)
        'tbxAmount.Text = stateSlsTax.ToString("n2")
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If
    End Sub


    Private Sub tbxDownPayment_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxDownPayment.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub reservationDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles reservationDataGrid.CellContentClick
        Dim row As DataGridViewRow = reservationDataGrid.Rows(e.RowIndex)
        If e.ColumnIndex = 16 Then
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Reservation SET Status=@status WHERE ID=@id", con)
            cancelOrder.Parameters.AddWithValue("@status", "Cancelled")
            cancelOrder.Parameters.AddWithValue("@id", row.Cells("reservationID").Value)
            cancelOrder.ExecuteNonQuery()
            Me.ReservationTableAdapter.Fill(Me.ReservationDS.Reservation)
        ElseIf e.ColumnIndex = 17 Then
            Dim constring As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0"
            Dim con As New SqlConnection(constring)
            con.Open()
            Dim cancelOrder As New SqlCommand("UPDATE Reservation SET Status=@status WHERE ID=@id", con)
            cancelOrder.Parameters.AddWithValue("@status", "Complete")
            cancelOrder.Parameters.AddWithValue("@id", row.Cells("reservationID").Value)
            cancelOrder.ExecuteNonQuery()
            Me.ReservationTableAdapter.Fill(Me.ReservationDS.Reservation)
        End If
    End Sub

    Private Sub cbxEventType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEventType.SelectedValueChanged
        If cbxEventType.SelectedIndex = 0 Then
            peopleCount.ReadOnly = False
            tbxAmount.ReadOnly = False
        ElseIf cbxEventType.SelectedIndex = 1 Then
            peopleCount.Value = "4"
            tbxAmount.Text = "400"
            peopleCount.ReadOnly = True
            tbxAmount.ReadOnly = True
        ElseIf cbxEventType.SelectedIndex = 2 Then
            peopleCount.Value = "8"
            tbxAmount.Text = "800"
            peopleCount.ReadOnly = True
            tbxAmount.ReadOnly = True
        ElseIf cbxEventType.SelectedIndex = 3 Then
            peopleCount.Value = "10"
            tbxAmount.Text = "1000"
            peopleCount.ReadOnly = True
            tbxAmount.ReadOnly = True
        ElseIf cbxEventType.SelectedIndex = 4 Then
            peopleCount.Value = "12"
            tbxAmount.Text = "1200"
            peopleCount.ReadOnly = True
            tbxAmount.ReadOnly = True
        Else
            MsgBox("Missing Package Type!", vbOKOnly, "Danger")
        End If
    End Sub
End Class