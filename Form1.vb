Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports OfficeOpenXml


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGridClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        LoadSalesData()

        Dim db As New DatabaseHelper()

        Try
            Dim conn As SqlConnection = db.GetConnection()
            conn.Open()
            MessageBox.Show("Conexión exitosa a la base de datos")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSalesData()
        Dim salesDAL As New SalesDAL()
        Dim salesTable As DataTable = salesDAL.GetSales()
        dataGridSales.DataSource = salesTable
    End Sub

    ' ---------- Client ----------

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        ' Validate the entered data
        If String.IsNullOrWhiteSpace(txtClientName.Text) OrElse
            String.IsNullOrWhiteSpace(txtClientPhone.Text) OrElse
            String.IsNullOrWhiteSpace(txtClientMail.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Create a new client with the entered data
        Dim newClient As New Clients() With {
            .Name = txtClientName.Text,
            .Phone = txtClientPhone.Text,
            .Mail = txtClientMail.Text
        }

        Try
            ' Use ClientDAL to add a client
            Dim clientDAL As New ClientsDAL()
            clientDAL.AddClient(newClient)
            MessageBox.Show("Client added successfully.")
            btnClearClient.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error adding client: " & ex.Message)
        End Try
    End Sub

    Private Sub btnShowClients_Click(sender As Object, e As EventArgs) Handles btnShowClients.Click
        Dim clientDAL As New ClientsDAL()
        Dim dt As DataTable = clientDAL.GetClients() ' Get clients using ClientDAL
        dataGridClients.DataSource = dt
    End Sub

    Private Sub btnUpdateClient_Click(sender As Object, e As EventArgs) Handles btnUpdateClient.Click
        ' Validate the entered data 
        If String.IsNullOrWhiteSpace(txtClientName.Text) OrElse String.IsNullOrWhiteSpace(txtClientPhone.Text) OrElse String.IsNullOrWhiteSpace(txtClientMail.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If dataGridClients.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a client to update.")
            Return
        End If

        Dim clientID As Integer = Convert.ToInt32(dataGridClients.SelectedRows(0).Cells(0).Value) ' Get the selected client ID 
        Dim updatedClient As New Clients() With {
            .ID = clientID,
            .Name = txtClientName.Text,
            .Phone = txtClientPhone.Text,
            .Mail = txtClientMail.Text
        }

        Try
            Dim clientDAL As New ClientsDAL()
            clientDAL.UpdateClient(updatedClient)
            MessageBox.Show("Client updated successfully.")
            btnClearClient.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error updating client: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        If dataGridClients.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a client to delete.")
            Return
        End If

        Dim clientID As Integer = Convert.ToInt32(dataGridClients.SelectedRows(0).Cells(0).Value) ' Get the selected client ID
        Try
            Dim clientDAL As New ClientsDAL()
            clientDAL.DeleteClient(clientID)
            MessageBox.Show("Client deleted successfully.")
            btnClearClient.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error deleting client: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClearClient_Click(sender As Object, e As EventArgs) Handles btnClearClient.Click
        ' clear all fields and the selection in the DataGridClients
        txtClientName.Clear()
        txtClientPhone.Clear()
        txtClientMail.Clear()
        dataGridClients.ClearSelection()
    End Sub

    Private Sub btnClientFilter_Click(sender As Object, e As EventArgs) Handles btnClientFilter.Click
        Dim dt As New DataTable()

        Using conn As SqlConnection = (New DatabaseHelper()).GetConnection()
            Dim cmd As New SqlCommand("SELECT * FROM clientes WHERE Cliente LIKE @Filter", conn)
            cmd.Parameters.AddWithValue("@Filter", "%" & txtClientFilter.Text & "%") ' Filter by client name

            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader) ' Load the filtered data into the DataTable

            dataGridClients.DataSource = dt ' Show the filtered clients in the DataGridClients
        End Using
    End Sub

    ' ---------- Product ----------

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        ' Validate the entered data
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
            String.IsNullOrWhiteSpace(txtProductPrice.Text) OrElse
            String.IsNullOrWhiteSpace(txtProductCategory.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Create a new product with the entered data
        Dim newProduct As New Products() With {
            .Name = txtProductName.Text,
            .Price = Decimal.Parse(txtProductPrice.Text),
            .Category = txtProductCategory.Text
        }

        Try
            ' Use ProductDAL to add a product
            Dim productDAL As New ProductsDAL()
            productDAL.AddProduct(newProduct)
            MessageBox.Show("Product added successfully.")
            btnClearProduct.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub

    Private Sub btnShowProducts_Click(sender As Object, e As EventArgs) Handles btnShowProducts.Click
        Dim productDAL As New ProductsDAL()
        Dim dt As DataTable = productDAL.GetProducts() ' Get products using ProductDAL
        dataGridProducts.DataSource = dt
    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        ' Validate the entered data 
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
            String.IsNullOrWhiteSpace(txtProductPrice.Text) OrElse
            String.IsNullOrWhiteSpace(txtProductCategory.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If dataGridProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to update.")
            Return
        End If

        Dim productID As Integer = Convert.ToInt32(dataGridProducts.SelectedRows(0).Cells(0).Value) ' Get the selected product ID 
        Dim updatedProduct As New Products() With {
            .ID = productID,
            .Name = txtProductName.Text,
            .Price = Decimal.Parse(txtProductPrice.Text),
            .Category = txtProductCategory.Text
        }

        Try
            Dim productDAL As New ProductsDAL()
            productDAL.UpdateProduct(updatedProduct)
            MessageBox.Show("Product updated successfully.")
            btnClearProduct.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        If dataGridProducts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.")
            Return
        End If

        Dim productID As Integer = Convert.ToInt32(dataGridProducts.SelectedRows(0).Cells(0).Value) ' Get the selected product ID
        Try
            Dim productDAL As New ProductsDAL()
            productDAL.DeleteProduct(productID)
            MessageBox.Show("Product deleted successfully.")
            btnClearProduct.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClearProduct_Click(sender As Object, e As EventArgs) Handles btnClearProduct.Click
        ' clear all fields and the selection in the DataGridProducts
        txtProductName.Clear()
        txtProductPrice.Clear()
        txtProductCategory.Clear()
        dataGridProducts.ClearSelection()
    End Sub

    Private Sub btnProductFilter_Click(sender As Object, e As EventArgs) Handles btnProductFilter.Click
        Dim dt As New DataTable()

        ' Simplification of queries
        Dim query As String = "SELECT * FROM productos WHERE 1 = 1"

        ' Filter by product name if provided
        If Not String.IsNullOrWhiteSpace(txtProductFilter.Text) Then
            query &= " AND Nombre LIKE @ProductName"
        End If

        ' Filter by category if provided
        If Not String.IsNullOrWhiteSpace(txtCategoryFilter.Text) Then
            query &= " AND Categoria LIKE @ProductCategory"
        End If

        Using conn As SqlConnection = (New DatabaseHelper()).GetConnection()
            conn.Open()

            Dim cmd As New SqlCommand(query, conn)

            ' Add parameters only if there are values in the filters
            If Not String.IsNullOrWhiteSpace(txtProductFilter.Text) Then
                cmd.Parameters.AddWithValue("@ProductName", "%" & txtProductFilter.Text & "%")
            End If

            If Not String.IsNullOrWhiteSpace(txtCategoryFilter.Text) Then
                cmd.Parameters.AddWithValue("@ProductCategory", "%" & txtCategoryFilter.Text & "%")
            End If

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
            dataGridProducts.DataSource = dt
        End Using
    End Sub

    ' ---------- Sale ----------

    Private Sub btnAddSale_Click(sender As Object, e As EventArgs) Handles btnAddSale.Click
        ' Validate the entered data
        If String.IsNullOrWhiteSpace(txtClientID.Text) OrElse
            String.IsNullOrWhiteSpace(txtProductID.Text) OrElse
            String.IsNullOrWhiteSpace(txtAmount.Text) OrElse
            String.IsNullOrWhiteSpace(dtpSaleDate.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Create a new sale with the entered data
        Dim newSale As New Sales() With {
            .IDClient = Convert.ToInt32(txtClientID.Text),
            .SaleDate = dtpSaleDate.Value
        }

        ' Create sales items
        Dim saleItems As New List(Of SalesItems) From {
            New SalesItems() With {
                .ProductID = Convert.ToInt32(txtProductID.Text),
                .Amount = Convert.ToInt32(txtAmount.Text)
            }
        }

        ' Add sale to database
        Dim salesDAL As New SalesDAL()
        Dim saleID As Integer = salesDAL.AddSale(newSale, saleItems)

        MessageBox.Show($"Sale added successfully with ID: {saleID}")
        btnClearSale.PerformClick()
    End Sub

    Private Sub btnShowSales_Click(sender As Object, e As EventArgs) Handles btnShowSales.Click
        Dim salesDAL As New SalesDAL()
        Dim salesTable As DataTable = salesDAL.GetSales()
        dataGridSales.DataSource = salesTable
    End Sub

    Private Sub btnUpdateSale_Click(sender As Object, e As EventArgs) Handles btnUpdateSale.Click
        If dataGridSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a sale to update")
            Return
        End If

        Dim saleID As Integer = Convert.ToInt32(dataGridSales.SelectedRows(0).Cells("ID").Value)

        ' Take the data from the form
        Dim updateSale As New Sales() With {
            .IDClient = Convert.ToInt32(txtClientID.Text),
            .SaleDate = dtpSaleDate.Value
        }

        ' Take the data from SalesItems
        Dim saleItems As New List(Of SalesItems) From {
            New SalesItems() With {
                .ProductID = Convert.ToInt32(txtProductID.Text),
                .Amount = Convert.ToInt32(txtAmount.Text)
            }
        }

        Try
            Dim salesDAL As New SalesDAL()
            salesDAL.UpdateSale(saleID, updateSale, saleItems)
            MessageBox.Show("Sale updated successfully.")
            btnShowSales.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error updating sale: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteSale_Click(sender As Object, e As EventArgs) Handles btnDeleteSale.Click
        If dataGridSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a sale to delete")
            Return
        End If

        Dim saleID As Integer = Convert.ToInt32(dataGridSales.SelectedRows(0).Cells("ID").Value)

        Try
            Dim salesDAL As New SalesDAL()
            salesDAL.DeleteSale(saleID)
            MessageBox.Show("Sale deleted successfully.")
            btnShowSales.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error deleting sale: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClearSale_Click(sender As Object, e As EventArgs) Handles btnClearSale.Click
        txtClientID.Clear()
        txtProductID.Clear()
        txtAmount.Clear()
        dtpSaleDate.Value = DateTime.Now
    End Sub

    Private Sub btnSaleFilter_Click(sender As Object, e As EventArgs) Handles btnSaleFilter.Click
        Dim salesDAL As New SalesDAL()
        Dim dt As DataTable = salesDAL.GetSales()

        Dim filterQuery As String = "SELECT v.ID, v.Fecha, v.IDCliente, c.Cliente, vi.Cantidad, vi.IDProducto, p.Nombre, vi.PrecioUnitario, v.Total 
                                     FROM ventas v 
                                     JOIN clientes c ON v.IDCliente = c.ID 
                                     JOIN ventasitems vi ON v.ID = vi.IDVenta 
                                     JOIN productos p ON vi.IDProducto = p.ID 
                                     WHERE 1=1"

        ' Filter by IDCliente
        If Not String.IsNullOrWhiteSpace(txtClientSaleFilter.Text) Then
            filterQuery &= " AND v.IDCliente = @IDClient"
        End If

        ' Filter by IDProduct
        If Not String.IsNullOrWhiteSpace(txtProductSaleFilter.Text) Then
            filterQuery &= " AND vi.IDProducto = @IDProduct"
        End If

        ' Filter by SaleDate if the checkbox is checked
        If chkFilterByDate.Checked Then
            filterQuery &= " AND CAST (v.Fecha AS DATE) = @SaleDate"
        End If

        Using conn As SqlConnection = (New DatabaseHelper()).GetConnection()
            conn.Open()
            Dim cmd As New SqlCommand(filterQuery, conn)

            ' Add parameters
            If Not String.IsNullOrWhiteSpace(txtClientSaleFilter.Text) Then
                cmd.Parameters.AddWithValue("@IDClient", Convert.ToInt32(txtClientSaleFilter.Text))
            End If

            If Not String.IsNullOrWhiteSpace(txtProductSaleFilter.Text) Then
                cmd.Parameters.AddWithValue("@IDProduct", Convert.ToInt32(txtProductSaleFilter.Text))
            End If

            If chkFilterByDate.Checked Then
                cmd.Parameters.AddWithValue("@SaleDate", dtpDateSaleFilter.Value.Date)
            End If

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim filteredTable As New DataTable()
            filteredTable.Load(reader)

            dataGridSales.DataSource = filteredTable
        End Using
    End Sub

    Private Sub chkFilterByDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilterByDate.CheckedChanged
        dtpDateSaleFilter.Enabled = chkFilterByDate.Checked
    End Sub

    ' ---------- Reports ----------

    Private Sub btnSalesPdf_Click(sender As Object, e As EventArgs) Handles btnSalesPdf.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveFileDialog.DefaultExt = "pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Check if there are columns in the DataGridView
                If dataGridSales.Columns.Count = 0 Then
                    LoadSalesData()
                    MessageBox.Show("There are no columns to export in the PDF.")
                    Return
                End If

                Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
                PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
                pdfDoc.Open()

                ' Create table in PDF
                Dim pdfTable As New PdfPTable(dataGridSales.Columns.Count)
                pdfTable.WidthPercentage = 100

                ' Add columns
                For Each column As DataGridViewColumn In dataGridSales.Columns
                    Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY
                    pdfTable.AddCell(cell)
                Next

                ' Add rows
                For Each row As DataGridViewRow In dataGridSales.Rows
                    If Not row.IsNewRow Then
                        For Each cell As DataGridViewCell In row.Cells
                            pdfTable.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), String.Empty))
                        Next
                    End If
                Next

                ' Add the table to the document
                pdfDoc.Add(pdfTable)
                pdfDoc.Close()

                MessageBox.Show("PDF successfully generated.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSalesExl_Click(sender As Object, e As EventArgs) Handles btnSalesExl.Click
        Try
            ' Fixes EPPlus non commercial license error
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveFileDialog.DefaultExt = "xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' Check if there are columns in the DataGridView
                If dataGridSales.Columns.Count = 0 Then
                    LoadSalesData()
                    MessageBox.Show("There are no columns to export in the Excel.")
                    Return
                End If

                ' Create the Excel file
                Using package As New ExcelPackage(New FileInfo(saveFileDialog.FileName))
                    Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Add("Sales Report")
                    ' Add columns
                    For col As Integer = 1 To dataGridSales.Columns.Count
                        ws.Cells(1, col).Value = dataGridSales.Columns(col - 1).HeaderText
                    Next

                    ' Add rows
                    For row As Integer = 0 To dataGridSales.Rows.Count - 1
                        If Not dataGridSales.Rows(row).IsNewRow Then
                            For col As Integer = 0 To dataGridSales.Columns.Count - 1
                                Dim cellValue As Object = dataGridSales.Rows(row).Cells(col).Value
                                If cellValue IsNot Nothing Then
                                    If dataGridSales.Columns(col).Name = "Fecha" Then
                                        Dim dateValue As DateTime = Convert.ToDateTime(cellValue)
                                        ws.Cells(row + 2, col + 1).Value = dateValue

                                        ' Apply date format
                                        ws.Cells(row + 2, col + 1).Style.Numberformat.Format = "dd/MM/yyyy"
                                    Else
                                        ws.Cells(row + 2, col + 1).Value = cellValue.ToString()
                                    End If
                                Else
                                    ws.Cells(row + 2, col + 1).Value = String.Empty
                                End If
                            Next
                        End If
                    Next

                    ' Adjust the column widths
                    For col As Integer = 1 To dataGridSales.Columns.Count
                        ws.Column(col).AutoFit()
                    Next

                    ' Save file
                    package.Save()
                End Using

                MessageBox.Show("Excel successfully generated.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating Excel: " & ex.Message)
        End Try
    End Sub

    Private Sub btnProductSalesPDF_Click(sender As Object, e As EventArgs) Handles btnProductSalesPDF.Click
        Try
            Dim salesDAL As New SalesDAL()
            Dim monthlySalesData As DataTable = salesDAL.GetMonthlySalesReport()

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveFileDialog.DefaultExt = "pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                salesDAL.ExportMonthlySalesReportToPdf(monthlySalesData, saveFileDialog.FileName)
                MessageBox.Show("PDF successfully generated.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub btnProductSalesExl_Click(sender As Object, e As EventArgs) Handles btnProductSalesExl.Click
        Try
            Dim salesDAL As New SalesDAL()
            Dim monthlySalesData As DataTable = salesDAL.GetMonthlySalesReport()

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveFileDialog.DefaultExt = "xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                salesDAL.ExportMonthlySalesReportToExcel(monthlySalesData, saveFileDialog.FileName)
                MessageBox.Show("Excel successfully generated.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error generating Excel: " & ex.Message)
        End Try
    End Sub
End Class