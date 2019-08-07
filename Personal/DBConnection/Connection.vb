Imports System.Data.SqlClient

Public Class Connection
    Public Shared Function getConnection() As SqlConnection
        Return New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=PersonalsDB; Integrated Security=SSPI;")
    End Function
End Class
