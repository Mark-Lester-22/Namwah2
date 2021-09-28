Imports System.Data.SqlClient
Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BillingDS.Billings' table. You can move, or remove it, as needed.
        Me.BillingsTableAdapter.Fill(Me.BillingDS.Billings)
        billingsMonthlyDate.CustomFormat = "yyyy"
        billingsMonthlyDate.Format = DateTimePickerFormat.Custom

        orderMonthlyDate.CustomFormat = "yyyy"
        orderMonthlyDate.Format = DateTimePickerFormat.Custom

        deliveryMonthlyDate.CustomFormat = "yyyy"
        deliveryMonthlyDate.Format = DateTimePickerFormat.Custom

        reservationMonthlyDate.CustomFormat = "yyyy"
        reservationMonthlyDate.Format = DateTimePickerFormat.Custom

        getMonthlySales()
        getMonthlyOrderTransaction()
        getMonthlyDeliveryTransaction()
        getMonthlyReservationTransaction()

    End Sub

    Private Function getMonthlySales()
        Dim salesQuery As String = String.Empty
        Dim salesReader, febRead As SqlDataReader
        Dim listOfMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For x = 1 To 12 Step 1
            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0")
                con.Open()
                salesQuery = "SELECT SUM(CAST(TotalPrice as DECIMAL(9,2))) as TPrice FROM Billings WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear"
                Using cmd As New SqlCommand()
                    With cmd
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = salesQuery
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", billingsMonthlyDate.Value.Year)
                        salesReader = cmd.ExecuteReader()
                        salesReader.Read()
                        billingsSales.Series("Monthly Sales").Points.AddXY(listOfMonth(x - 1), salesReader("TPrice"))
                    End With
                End Using
            End Using

        Next
    End Function

    Private Function getMonthlyOrderTransaction()
        Dim cancelOrder As String = String.Empty
        Dim completeOrder As String = String.Empty
        Dim cancelOrderReader, completeOrderReader As SqlDataReader
        Dim listOfMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For x = 1 To 12 Step 1
            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0;MultipleActiveResultSets=true")
                con.Open()
                cancelOrder = "SELECT COUNT(Status) as StatusNum FROM Orders WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear AND Status='Cancelled'"
                Using cancelCMD As New SqlCommand()
                    With cancelCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = cancelOrder
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", orderMonthlyDate.Value.Year)
                        cancelOrderReader = cancelCMD.ExecuteReader()
                        cancelOrderReader.Read()
                        orderTransaction.Series("Cancel").Points.AddXY(listOfMonth(x - 1), cancelOrderReader("StatusNum"))
                    End With
                End Using
                completeOrder = "SELECT COUNT(Status) as StatusNum FROM Orders WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear AND Status='Complete'"
                Using completeCMD As New SqlCommand()
                    With completeCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = cancelOrder
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", orderMonthlyDate.Value.Year)
                        completeOrderReader = completeCMD.ExecuteReader()
                        completeOrderReader.Read()
                        orderTransaction.Series("Complete").Points.AddXY(listOfMonth(x - 1), cancelOrderReader("StatusNum"))
                    End With
                End Using
            End Using
        Next
    End Function

    Private Function getMonthlyDeliveryTransaction()
        Dim cancelDelivery As String = String.Empty
        Dim completeDelivery As String = String.Empty
        Dim cancelDeliveryReader, completeDeliveryReader As SqlDataReader
        Dim listOfMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For x = 1 To 12 Step 1
            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0;MultipleActiveResultSets=true")
                con.Open()
                cancelDelivery = "SELECT COUNT(Status) as StatusNum FROM Delivery WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear AND Status='Cancelled'"
                Using cancelCMD As New SqlCommand()
                    With cancelCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = cancelDelivery
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", deliveryMonthlyDate.Value.Year)
                        cancelDeliveryReader = cancelCMD.ExecuteReader()
                        cancelDeliveryReader.Read()
                        deliveryTransaction.Series("Cancel").Points.AddXY(listOfMonth(x - 1), cancelDeliveryReader("StatusNum"))
                    End With
                End Using
                completeDelivery = "SELECT COUNT(Status) as StatusNum FROM Orders WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear AND Status='Complete'"
                Using completeCMD As New SqlCommand()
                    With completeCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = completeDelivery
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", deliveryMonthlyDate.Value.Year)
                        completeDeliveryReader = completeCMD.ExecuteReader()
                        completeDeliveryReader.Read()
                        deliveryTransaction.Series("Complete").Points.AddXY(listOfMonth(x - 1), completeDeliveryReader("StatusNum"))
                    End With
                End Using
            End Using
        Next
    End Function

    Private Function getMonthlyReservationTransaction()
        Dim cancelReservation As String = String.Empty
        Dim reservedReservation As String = String.Empty
        Dim cancelReservationReader, reservedReservationReader As SqlDataReader
        Dim listOfMonth() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For x = 1 To 12 Step 1
            Using con As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True;Connection Timeout=0;MultipleActiveResultSets=true")
                con.Open()
                cancelReservation = "SELECT COUNT(Status) as StatusNum FROM Reservation WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear AND Status='Cancelled'"
                Using cancelCMD As New SqlCommand()
                    With cancelCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = cancelReservation
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", reservationMonthlyDate.Value.Year)
                        cancelReservationReader = cancelCMD.ExecuteReader()
                        cancelReservationReader.Read()
                        reservationTransaction.Series("Cancel").Points.AddXY(listOfMonth(x - 1), cancelReservationReader("StatusNum"))
                    End With
                End Using
                reservedReservation = "SELECT COUNT(Status) as StatusNum FROM Orders WHERE MONTH(createdDateTime) = @monthNum AND YEAR(createdDateTime) = @selectYear AND Status='Reserved'"
                Using reserverdCMD As New SqlCommand()
                    With reserverdCMD
                        .Connection = con
                        .CommandType = CommandType.Text
                        .CommandText = reservedReservation
                        .Parameters.AddWithValue("@monthNum", x.ToString())
                        .Parameters.AddWithValue("@selectYear", reservationMonthlyDate.Value.Year)
                        reservedReservationReader = reserverdCMD.ExecuteReader()
                        reservedReservationReader.Read()
                        reservationTransaction.Series("Reserved").Points.AddXY(listOfMonth(x - 1), reservedReservationReader("StatusNum"))
                    End With
                End Using
            End Using
        Next
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub billingsMonthlyDate_ValueChanged(sender As Object, e As EventArgs) Handles billingsMonthlyDate.ValueChanged
        billingsSales.Series("Monthly Sales").Points.Clear()
        getMonthlySales()
    End Sub

    Private Sub orderMonthlyDate_ValueChanged(sender As Object, e As EventArgs) Handles orderMonthlyDate.ValueChanged
        orderTransaction.Series("Cancel").Points.Clear()
        orderTransaction.Series("Complete").Points.Clear()
        getMonthlyOrderTransaction()
    End Sub

    Private Sub deliveryMonthlyDate_ValueChanged(sender As Object, e As EventArgs) Handles deliveryMonthlyDate.ValueChanged
        deliveryTransaction.Series("Cancel").Points.Clear()
        deliveryTransaction.Series("Complete").Points.Clear()
        getMonthlyDeliveryTransaction()
    End Sub

    Private Sub reservationMonthlyDate_ValueChanged(sender As Object, e As EventArgs) Handles reservationMonthlyDate.ValueChanged
        reservationTransaction.Series("Cancel").Points.Clear()
        reservationTransaction.Series("Reserved").Points.Clear()
        getMonthlyReservationTransaction()
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
End Class