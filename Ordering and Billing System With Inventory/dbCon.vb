Imports System.Data
Imports System.Data.SqlClient
Public Class dbCon
    Public Sub main()
        Dim con As SqlConnection
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        con.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=namwah;Integrated Security=True"


        Try
            con.Open()
            cmd.Connection = con
        Catch ex As Exception
            'errormessage
            Console.WriteLine("Database connection failed!")
        End Try
        Console.WriteLine("Database connection success!")
    End Sub
End Class
