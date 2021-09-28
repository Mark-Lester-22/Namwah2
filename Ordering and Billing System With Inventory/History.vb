Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient

Public Class History
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminDB.Show()
        Me.Hide()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OrdersDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.OrdersDataSet.Orders)
        'TODO: This line of code loads data into the 'DeliveryDS.Delivery' table. You can move, or remove it, as needed.
        Me.DeliveryTableAdapter.Fill(Me.DeliveryDS.Delivery)
        'TODO: This line of code loads data into the 'ReservationDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.ReservationDataSet.Reservation)

    End Sub

    Private Sub btnOrderExport_Click(sender As Object, e As EventArgs) Handles btnOrderExport.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To DataGridView3.RowCount - 2
            For j = 0 To DataGridView3.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                    DataGridView3(j, i).Value.ToString()
            Next
        Next
        xlWorkSheet.SaveAs("D:\OrdersReport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("You're excel file is exported in D:\")
    End Sub

    Private Sub btnDeliveryExport_Click(sender As Object, e As EventArgs) Handles btnDeliveryExport.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To DataGridView2.RowCount - 2
            For j = 0 To DataGridView2.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                    DataGridView2(j, i).Value.ToString()
            Next
        Next
        xlWorkSheet.SaveAs("D:\DeliveryReport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("You're excel file is exported in D:\")
    End Sub
    Private Sub btnReservationExport_Click(sender As Object, e As EventArgs) Handles btnReservationExport.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(i + 1, j + 1) =
                    DataGridView1(j, i).Value.ToString()
            Next
        Next
        xlWorkSheet.SaveAs("D:\ReservationReport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("You're excel file is exported in D:\")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class