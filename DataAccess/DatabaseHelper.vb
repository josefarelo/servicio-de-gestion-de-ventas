Imports System.Data.SqlClient
Imports System.Configuration

Public Class DatabaseHelper
    Private connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class