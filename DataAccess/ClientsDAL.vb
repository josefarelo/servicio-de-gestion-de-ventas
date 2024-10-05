Imports System.Data.SqlClient
Imports System.Configuration
Public Class ClientsDAL
    Private connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString

    ' Add a client
    Public Sub AddClient(client As Clients)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Name, @Phone, @Mail)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Name", client.Name)
            cmd.Parameters.AddWithValue("@Phone", client.Phone)
            cmd.Parameters.AddWithValue("@Mail", client.Mail)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Update a client
    Public Sub UpdateClient(client As Clients)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE clientes SET Cliente = @Name, Telefono = @Phone, Correo = @Mail WHERE ID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", client.ID)
            cmd.Parameters.AddWithValue("@Name", client.Name)
            cmd.Parameters.AddWithValue("@Phone", client.Phone)
            cmd.Parameters.AddWithValue("@Mail", client.Mail)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Delete a client
    Public Sub DeleteClient(clientID As Integer)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM clientes WHERE ID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", clientID)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Get all clients
    Public Function GetClients() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM clientes"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using
        Return dt
    End Function
End Class