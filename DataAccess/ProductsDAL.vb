Imports System.Data.SqlClient
Imports System.Configuration
Public Class ProductsDAL
    Private connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString

    ' Add a product
    Public Sub AddProduct(product As Products)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Name, @Price, @Category)"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Name", product.Name)
            cmd.Parameters.AddWithValue("@Price", product.Price)
            cmd.Parameters.AddWithValue("@Category", product.Category)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Update a product
    Public Sub UpdateProduct(product As Products)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "UPDATE productos SET Nombre = @Name, Precio = @Price, Categoria = @Category WHERE ID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", product.ID)
            cmd.Parameters.AddWithValue("@Name", product.Name)
            cmd.Parameters.AddWithValue("@Price", product.Price)
            cmd.Parameters.AddWithValue("@Category", product.Category)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Delete a product
    Public Sub DeleteProduct(productID As Integer)
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM productos WHERE ID = @ID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", productID)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' Get all products
    Public Function GetProducts() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM productos"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using
        Return dt
    End Function
End Class