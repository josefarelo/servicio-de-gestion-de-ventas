Imports System.Data.SqlClient
Imports System.Configuration
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports OfficeOpenXml
Public Class SalesDAL
    Private connectionString As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString

    ' Get the price of a product by ID
    Public Function GetProductPrice(productID As Integer) As Decimal
        Dim price As Decimal = 0

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT Precio FROM productos WHERE ID = @ProductID"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ProductID", productID)

            conn.Open()
            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                price = Convert.ToDecimal(result)
            End If
        End Using

        Return price
    End Function

    ' Create new sale
    Public Function AddSale(sale As Sales, salesItems As List(Of SalesItems)) As Integer
        Dim saleID As Integer
        Dim totalGeneral As Decimal = 0

        Using conn As New SqlConnection(connectionString)
            ' Start transaction
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                ' Insert Sale
                Dim querySale As String = "INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@IDClient, @SaleDate, @Total)"
                Dim cmdSale As New SqlCommand(querySale, conn, transaction)
                cmdSale.Parameters.AddWithValue("@IDClient", sale.IDClient)
                cmdSale.Parameters.AddWithValue("@SaleDate", sale.SaleDate)
                cmdSale.Parameters.AddWithValue("@Total", totalGeneral)

                ' Get newly created sale id
                saleID = Convert.ToInt32(cmdSale.ExecuteScalar())

                For Each item As SalesItems In salesItems
                    ' Get unit price from the products table
                    item.UnitPrice = GetProductPrice(item.ProductID)
                    item.TotalPrice = item.UnitPrice * item.Amount

                    ' Insert sales items
                    Dim queryItem As String = "INSERT INTO ventasitems (IDVenta, IDProducto, Cantidad, PrecioUnitario, PrecioTotal) VALUES (@SaleID, @ProductID, @Amount, @UnitPrice, @TotalPrice); SELECT SCOPE_IDENTITY();"
                    Dim cmdItem As New SqlCommand(queryItem, conn, transaction)
                    cmdItem.Parameters.AddWithValue("@SaleID", saleID)
                    cmdItem.Parameters.AddWithValue("@ProductID", item.ProductID)
                    cmdItem.Parameters.AddWithValue("@Amount", item.Amount)
                    cmdItem.Parameters.AddWithValue("@UnitPrice", item.UnitPrice)
                    cmdItem.Parameters.AddWithValue("@TotalPrice", item.TotalPrice)

                    cmdItem.ExecuteNonQuery()

                    totalGeneral += item.TotalPrice
                Next

                ' Update the Total
                Dim queryUpdate As String = "UPDATE ventas SET Total = @Total WHERE ID = @SaleID"
                Dim cmdUpdate As New SqlCommand(queryUpdate, conn, transaction)
                cmdUpdate.Parameters.AddWithValue("@Total", totalGeneral)
                cmdUpdate.Parameters.AddWithValue("@SaleID", saleID)

                cmdUpdate.ExecuteNonQuery()

                'Confirm transaction
                transaction.Commit()
            Catch ex As Exception
                ' Reverse the transaction in case of error
                transaction.Rollback()
                Throw New Exception("Error creating the sale" & ex.Message)
            End Try
        End Using

        Return saleID
    End Function

    ' Get sales
    Public Function GetSales() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT v.ID, v.Fecha, v.IDCliente, c.Cliente, vi.Cantidad, vi.IDProducto, p.Nombre, vi.PrecioUnitario, v.Total
                                   FROM ventas v
                                   JOIN clientes c ON v.IDCliente = c.ID
                                   JOIN ventasitems vi ON v.ID = vi.IDVenta
                                   JOIN productos p ON vi.IDProducto = p.ID"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using
        Return dt
    End Function

    ' Update a sale
    Public Sub UpdateSale(saleID As Integer, sale As Sales, salesItems As List(Of SalesItems))
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                Dim queryUpdateSale As String = "UPDATE ventas SET IDCliente = @IDClient, Fecha = @SaleDate Where ID = @SaleID"
                Dim cmdUpdateSale As New SqlCommand(queryUpdateSale, conn, transaction)
                cmdUpdateSale.Parameters.AddWithValue("@IDClient", sale.IDClient)
                cmdUpdateSale.Parameters.AddWithValue("@SaleDate", sale.SaleDate)
                cmdUpdateSale.Parameters.AddWithValue("@SaleID", saleID)

                cmdUpdateSale.ExecuteNonQuery()

                ' Clear SalesItems for the sale
                Dim queryDeleteItems As String = "DELETE FROM ventasitems WHERE IDVenta = @SaleID"
                Dim cmdDeleteItems As New SqlCommand(queryDeleteItems, conn, transaction)
                cmdDeleteItems.Parameters.AddWithValue("@SaleID", saleID)
                cmdDeleteItems.ExecuteNonQuery()

                Dim totalGeneral As Decimal = 0

                ' Insert updated SalesItems
                For Each item As SalesItems In salesItems
                    item.UnitPrice = GetProductPrice(item.ProductID)
                    item.TotalPrice = item.UnitPrice * item.Amount

                    Dim queryItem As String = "INSERT INTO ventasitems (IDVenta, IDProducto, Cantidad, PrecioUnitario, PrecioTotal) VALUES (@SaleID, @ProductID, @Amount, @UnitPrice, @TotalPrice)"
                    Dim cmdItem As New SqlCommand(queryItem, conn, transaction)
                    cmdItem.Parameters.AddWithValue("@SaleID", saleID)
                    cmdItem.Parameters.AddWithValue("@ProductID", item.ProductID)
                    cmdItem.Parameters.AddWithValue("@Amount", item.Amount)
                    cmdItem.Parameters.AddWithValue("@UnitPrice", item.UnitPrice)
                    cmdItem.Parameters.AddWithValue("@TotalPrice", item.TotalPrice)

                    cmdItem.ExecuteNonQuery()

                    totalGeneral += item.TotalPrice
                Next

                ' Update the Total
                Dim queryUpdate As String = "UPDATE ventas SET Total = @Total WHERE ID = @SaleID"
                Dim cmdUpdate As New SqlCommand(queryUpdate, conn, transaction)
                cmdUpdate.Parameters.AddWithValue("@Total", totalGeneral)
                cmdUpdate.Parameters.AddWithValue("@SaleID", saleID)

                cmdUpdate.ExecuteNonQuery()

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                Throw New Exception("Error updating sale: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete a sale
    Public Sub DeleteSale(saleId As Integer)
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim transaction As SqlTransaction = conn.BeginTransaction()

            Try
                Dim queryDeleteItems As String = "DELETE FROM ventasitems WHERE IDVenta = @SaleID"
                Dim cmdDeleteItems As New SqlCommand(queryDeleteItems, conn, transaction)
                cmdDeleteItems.Parameters.AddWithValue("@SaleID", saleId)
                cmdDeleteItems.ExecuteNonQuery()

                Dim queryDeleteSale As String = "DELETE FROM ventas WHERE ID = @SaleID"
                Dim cmdDeleteSale As New SqlCommand(queryDeleteSale, conn, transaction)
                cmdDeleteSale.Parameters.AddWithValue("@SaleID", saleId)
                cmdDeleteSale.ExecuteNonQuery()

                transaction.Commit()
            Catch ex As Exception
                transaction.Rollback()
                Throw New Exception("Error deleting sale: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Get monthly sales report
    Public Function GetMonthlySalesReport() As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Dim query As String = "SELECT p.ID, p.Nombre AS ProductName, SUM(vi.Cantidad) AS TotalSold, FORMAT(v.Fecha, 'MMMM yyyy') AS MonthYear 
                                   FROM ventasitems vi 
                                   JOIN ventas v ON vi.IDVenta = v.ID
                                   JOIN productos p ON vi.IDProducto = p.ID
                                   GROUP BY p.ID, p.Nombre, FORMAT(v.Fecha, 'MMMM yyyy')
                                   ORDER BY MonthYear, ProductName;"
            Dim cmd As New SqlCommand(query, conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using

        Return dt
    End Function

    ' Export MonthlySales PDF
    Public Sub ExportMonthlySalesReportToPdf(monthlySalesData As DataTable, filePath As String)
        Using pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
            PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))
            pdfDoc.Open()

            ' Create table in PDF
            Dim pdfTable As New PdfPTable(monthlySalesData.Columns.Count)
            pdfTable.WidthPercentage = 100

            ' Add columns
            For Each column As DataColumn In monthlySalesData.Columns
                Dim cell As New PdfPCell(New Phrase(column.ColumnName))
                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(cell)
            Next

            ' Add rows
            For Each row As DataRow In monthlySalesData.Rows
                For Each cell In row.ItemArray
                    pdfTable.AddCell(cell.ToString())
                Next
            Next

            ' Add the table to the document
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()

        End Using
    End Sub

    ' Export MonthlySales Excel
    Public Sub ExportMonthlySalesReportToExcel(monthlySalesData As DataTable, filePath As String)
        ' Fixes EPPlus non commercial license error
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using package As New ExcelPackage(New FileInfo(filePath))
            Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Add("Monthly Sales Report")

            ' Add columns
            For col As Integer = 1 To monthlySalesData.Columns.Count
                ws.Cells(1, col).Value = monthlySalesData.Columns(col - 1).ColumnName
            Next

            ' Add rows
            For row As Integer = 0 To monthlySalesData.Rows.Count - 1
                For col As Integer = 0 To monthlySalesData.Columns.Count - 1
                    ws.Cells(row + 2, col + 1).Value = monthlySalesData.Rows(row)(col)
                Next
            Next

            ' Save File
            package.Save()
        End Using
    End Sub
End Class