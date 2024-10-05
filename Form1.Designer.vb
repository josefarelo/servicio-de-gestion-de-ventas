<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtClientPhone = New System.Windows.Forms.TextBox()
        Me.txtClientMail = New System.Windows.Forms.TextBox()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.btnShowClients = New System.Windows.Forms.Button()
        Me.btnUpdateClient = New System.Windows.Forms.Button()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.dataGridClients = New System.Windows.Forms.DataGridView()
        Me.btnClearClient = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClientFilter = New System.Windows.Forms.TextBox()
        Me.btnClientFilter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCategoryFilter = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProductFilter = New System.Windows.Forms.TextBox()
        Me.btnProductFilter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnShowProducts = New System.Windows.Forms.Button()
        Me.btnClearProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.txtProductCategory = New System.Windows.Forms.TextBox()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.dataGridProducts = New System.Windows.Forms.DataGridView()
        Me.dataGridSales = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkFilterByDate = New System.Windows.Forms.CheckBox()
        Me.dtpDateSaleFilter = New System.Windows.Forms.DateTimePicker()
        Me.txtClientSaleFilter = New System.Windows.Forms.TextBox()
        Me.txtProductSaleFilter = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnSaleFilter = New System.Windows.Forms.Button()
        Me.dtpSaleDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnShowSales = New System.Windows.Forms.Button()
        Me.btnClearSale = New System.Windows.Forms.Button()
        Me.btnAddSale = New System.Windows.Forms.Button()
        Me.btnUpdateSale = New System.Windows.Forms.Button()
        Me.btnDeleteSale = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalesPdf = New System.Windows.Forms.Button()
        Me.btnSalesExl = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnProductSalesExl = New System.Windows.Forms.Button()
        Me.btnProductSalesPDF = New System.Windows.Forms.Button()
        CType(Me.dataGridClients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dataGridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(68, 38)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(100, 20)
        Me.txtClientName.TabIndex = 0
        '
        'txtClientPhone
        '
        Me.txtClientPhone.Location = New System.Drawing.Point(68, 64)
        Me.txtClientPhone.Name = "txtClientPhone"
        Me.txtClientPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtClientPhone.TabIndex = 1
        '
        'txtClientMail
        '
        Me.txtClientMail.Location = New System.Drawing.Point(68, 88)
        Me.txtClientMail.Name = "txtClientMail"
        Me.txtClientMail.Size = New System.Drawing.Size(100, 20)
        Me.txtClientMail.TabIndex = 2
        '
        'btnAddClient
        '
        Me.btnAddClient.Location = New System.Drawing.Point(301, 65)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(96, 23)
        Me.btnAddClient.TabIndex = 3
        Me.btnAddClient.Text = "Agregar Cliente"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'btnShowClients
        '
        Me.btnShowClients.Location = New System.Drawing.Point(301, 36)
        Me.btnShowClients.Name = "btnShowClients"
        Me.btnShowClients.Size = New System.Drawing.Size(96, 23)
        Me.btnShowClients.TabIndex = 4
        Me.btnShowClients.Text = "Mostrar Clientes"
        Me.btnShowClients.UseVisualStyleBackColor = True
        '
        'btnUpdateClient
        '
        Me.btnUpdateClient.Location = New System.Drawing.Point(301, 94)
        Me.btnUpdateClient.Name = "btnUpdateClient"
        Me.btnUpdateClient.Size = New System.Drawing.Size(96, 23)
        Me.btnUpdateClient.TabIndex = 5
        Me.btnUpdateClient.Text = "Actualizar Cliente"
        Me.btnUpdateClient.UseVisualStyleBackColor = True
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Location = New System.Drawing.Point(301, 123)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(96, 23)
        Me.btnDeleteClient.TabIndex = 6
        Me.btnDeleteClient.Text = "Eliminar Cliente"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'dataGridClients
        '
        Me.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridClients.Location = New System.Drawing.Point(12, 12)
        Me.dataGridClients.Name = "dataGridClients"
        Me.dataGridClients.Size = New System.Drawing.Size(413, 441)
        Me.dataGridClients.TabIndex = 7
        '
        'btnClearClient
        '
        Me.btnClearClient.Location = New System.Drawing.Point(68, 114)
        Me.btnClearClient.Name = "btnClearClient"
        Me.btnClearClient.Size = New System.Drawing.Size(100, 26)
        Me.btnClearClient.TabIndex = 8
        Me.btnClearClient.Text = "Limpiar Campos"
        Me.btnClearClient.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtClientFilter)
        Me.GroupBox1.Controls.Add(Me.btnClientFilter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnShowClients)
        Me.GroupBox1.Controls.Add(Me.btnClearClient)
        Me.GroupBox1.Controls.Add(Me.btnAddClient)
        Me.GroupBox1.Controls.Add(Me.btnUpdateClient)
        Me.GroupBox1.Controls.Add(Me.txtClientMail)
        Me.GroupBox1.Controls.Add(Me.btnDeleteClient)
        Me.GroupBox1.Controls.Add(Me.txtClientPhone)
        Me.GroupBox1.Controls.Add(Me.txtClientName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 488)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 172)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Filtrar por Cliente"
        '
        'txtClientFilter
        '
        Me.txtClientFilter.Location = New System.Drawing.Point(185, 38)
        Me.txtClientFilter.Name = "txtClientFilter"
        Me.txtClientFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtClientFilter.TabIndex = 14
        '
        'btnClientFilter
        '
        Me.btnClientFilter.Location = New System.Drawing.Point(185, 64)
        Me.btnClientFilter.Name = "btnClientFilter"
        Me.btnClientFilter.Size = New System.Drawing.Size(100, 23)
        Me.btnClientFilter.TabIndex = 13
        Me.btnClientFilter.Text = "Filtrar"
        Me.btnClientFilter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCategoryFilter)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtProductFilter)
        Me.GroupBox2.Controls.Add(Me.btnProductFilter)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnShowProducts)
        Me.GroupBox2.Controls.Add(Me.btnClearProduct)
        Me.GroupBox2.Controls.Add(Me.btnAddProduct)
        Me.GroupBox2.Controls.Add(Me.btnUpdateProduct)
        Me.GroupBox2.Controls.Add(Me.txtProductCategory)
        Me.GroupBox2.Controls.Add(Me.btnDeleteProduct)
        Me.GroupBox2.Controls.Add(Me.txtProductPrice)
        Me.GroupBox2.Controls.Add(Me.txtProductName)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 488)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 172)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestión de Productos"
        '
        'txtCategoryFilter
        '
        Me.txtCategoryFilter.Location = New System.Drawing.Point(185, 88)
        Me.txtCategoryFilter.Name = "txtCategoryFilter"
        Me.txtCategoryFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoryFilter.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Filtrar por Categoría"
        '
        'txtProductFilter
        '
        Me.txtProductFilter.Location = New System.Drawing.Point(185, 38)
        Me.txtProductFilter.Name = "txtProductFilter"
        Me.txtProductFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtProductFilter.TabIndex = 14
        '
        'btnProductFilter
        '
        Me.btnProductFilter.Location = New System.Drawing.Point(185, 116)
        Me.btnProductFilter.Name = "btnProductFilter"
        Me.btnProductFilter.Size = New System.Drawing.Size(100, 23)
        Me.btnProductFilter.TabIndex = 13
        Me.btnProductFilter.Text = "Filtrar"
        Me.btnProductFilter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Filtrar por Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Categoría"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Precio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Producto"
        '
        'btnShowProducts
        '
        Me.btnShowProducts.Location = New System.Drawing.Point(301, 36)
        Me.btnShowProducts.Name = "btnShowProducts"
        Me.btnShowProducts.Size = New System.Drawing.Size(110, 23)
        Me.btnShowProducts.TabIndex = 4
        Me.btnShowProducts.Text = "Mostrar Productos"
        Me.btnShowProducts.UseVisualStyleBackColor = True
        '
        'btnClearProduct
        '
        Me.btnClearProduct.Location = New System.Drawing.Point(68, 114)
        Me.btnClearProduct.Name = "btnClearProduct"
        Me.btnClearProduct.Size = New System.Drawing.Size(100, 26)
        Me.btnClearProduct.TabIndex = 8
        Me.btnClearProduct.Text = "Limpiar Campos"
        Me.btnClearProduct.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(301, 65)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(110, 23)
        Me.btnAddProduct.TabIndex = 3
        Me.btnAddProduct.Text = "Agregar Producto"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(301, 94)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(110, 23)
        Me.btnUpdateProduct.TabIndex = 5
        Me.btnUpdateProduct.Text = "Actualizar Producto"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'txtProductCategory
        '
        Me.txtProductCategory.Location = New System.Drawing.Point(68, 88)
        Me.txtProductCategory.Name = "txtProductCategory"
        Me.txtProductCategory.Size = New System.Drawing.Size(100, 20)
        Me.txtProductCategory.TabIndex = 2
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Location = New System.Drawing.Point(301, 123)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(110, 23)
        Me.btnDeleteProduct.TabIndex = 6
        Me.btnDeleteProduct.Text = "Eliminar Producto"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(68, 64)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtProductPrice.TabIndex = 1
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(68, 38)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 0
        '
        'dataGridProducts
        '
        Me.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridProducts.Location = New System.Drawing.Point(431, 12)
        Me.dataGridProducts.Name = "dataGridProducts"
        Me.dataGridProducts.Size = New System.Drawing.Size(427, 441)
        Me.dataGridProducts.TabIndex = 11
        '
        'dataGridSales
        '
        Me.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSales.Location = New System.Drawing.Point(864, 12)
        Me.dataGridSales.Name = "dataGridSales"
        Me.dataGridSales.Size = New System.Drawing.Size(735, 441)
        Me.dataGridSales.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkFilterByDate)
        Me.GroupBox3.Controls.Add(Me.dtpDateSaleFilter)
        Me.GroupBox3.Controls.Add(Me.txtClientSaleFilter)
        Me.GroupBox3.Controls.Add(Me.txtProductSaleFilter)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.btnSaleFilter)
        Me.GroupBox3.Controls.Add(Me.dtpSaleDate)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtClientID)
        Me.GroupBox3.Controls.Add(Me.txtProductID)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtAmount)
        Me.GroupBox3.Controls.Add(Me.btnShowSales)
        Me.GroupBox3.Controls.Add(Me.btnClearSale)
        Me.GroupBox3.Controls.Add(Me.btnAddSale)
        Me.GroupBox3.Controls.Add(Me.btnUpdateSale)
        Me.GroupBox3.Controls.Add(Me.btnDeleteSale)
        Me.GroupBox3.Location = New System.Drawing.Point(864, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 172)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gestión de Ventas"
        '
        'chkFilterByDate
        '
        Me.chkFilterByDate.AutoSize = True
        Me.chkFilterByDate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFilterByDate.Location = New System.Drawing.Point(287, 92)
        Me.chkFilterByDate.Name = "chkFilterByDate"
        Me.chkFilterByDate.Size = New System.Drawing.Size(15, 14)
        Me.chkFilterByDate.TabIndex = 23
        Me.chkFilterByDate.UseVisualStyleBackColor = True
        '
        'dtpDateSaleFilter
        '
        Me.dtpDateSaleFilter.Location = New System.Drawing.Point(308, 90)
        Me.dtpDateSaleFilter.Name = "dtpDateSaleFilter"
        Me.dtpDateSaleFilter.Size = New System.Drawing.Size(100, 20)
        Me.dtpDateSaleFilter.TabIndex = 22
        '
        'txtClientSaleFilter
        '
        Me.txtClientSaleFilter.Location = New System.Drawing.Point(308, 39)
        Me.txtClientSaleFilter.Name = "txtClientSaleFilter"
        Me.txtClientSaleFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtClientSaleFilter.TabIndex = 20
        '
        'txtProductSaleFilter
        '
        Me.txtProductSaleFilter.Location = New System.Drawing.Point(308, 65)
        Me.txtProductSaleFilter.Name = "txtProductSaleFilter"
        Me.txtProductSaleFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtProductSaleFilter.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(193, 91)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Filtrar por Fecha"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Cantidad"
        '
        'btnSaleFilter
        '
        Me.btnSaleFilter.Location = New System.Drawing.Point(308, 117)
        Me.btnSaleFilter.Name = "btnSaleFilter"
        Me.btnSaleFilter.Size = New System.Drawing.Size(100, 23)
        Me.btnSaleFilter.TabIndex = 13
        Me.btnSaleFilter.Text = "Filtrar"
        Me.btnSaleFilter.UseVisualStyleBackColor = True
        '
        'dtpSaleDate
        '
        Me.dtpSaleDate.Location = New System.Drawing.Point(74, 114)
        Me.dtpSaleDate.Name = "dtpSaleDate"
        Me.dtpSaleDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpSaleDate.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(193, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Filtrar por ID Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(193, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Filtrar por ID Cliente"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "ID Producto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "ID Cliente"
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(74, 39)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(100, 20)
        Me.txtClientID.TabIndex = 0
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(74, 65)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Fecha"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(74, 89)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 2
        '
        'btnShowSales
        '
        Me.btnShowSales.Location = New System.Drawing.Point(428, 38)
        Me.btnShowSales.Name = "btnShowSales"
        Me.btnShowSales.Size = New System.Drawing.Size(110, 23)
        Me.btnShowSales.TabIndex = 4
        Me.btnShowSales.Text = "Mostrar Ventas"
        Me.btnShowSales.UseVisualStyleBackColor = True
        '
        'btnClearSale
        '
        Me.btnClearSale.Location = New System.Drawing.Point(74, 140)
        Me.btnClearSale.Name = "btnClearSale"
        Me.btnClearSale.Size = New System.Drawing.Size(100, 26)
        Me.btnClearSale.TabIndex = 8
        Me.btnClearSale.Text = "Limpiar Campos"
        Me.btnClearSale.UseVisualStyleBackColor = True
        '
        'btnAddSale
        '
        Me.btnAddSale.Location = New System.Drawing.Point(428, 67)
        Me.btnAddSale.Name = "btnAddSale"
        Me.btnAddSale.Size = New System.Drawing.Size(110, 23)
        Me.btnAddSale.TabIndex = 3
        Me.btnAddSale.Text = "Agregar Venta"
        Me.btnAddSale.UseVisualStyleBackColor = True
        '
        'btnUpdateSale
        '
        Me.btnUpdateSale.Location = New System.Drawing.Point(428, 96)
        Me.btnUpdateSale.Name = "btnUpdateSale"
        Me.btnUpdateSale.Size = New System.Drawing.Size(110, 23)
        Me.btnUpdateSale.TabIndex = 5
        Me.btnUpdateSale.Text = "Actualizar Venta"
        Me.btnUpdateSale.UseVisualStyleBackColor = True
        '
        'btnDeleteSale
        '
        Me.btnDeleteSale.Location = New System.Drawing.Point(428, 125)
        Me.btnDeleteSale.Name = "btnDeleteSale"
        Me.btnDeleteSale.Size = New System.Drawing.Size(110, 23)
        Me.btnDeleteSale.TabIndex = 6
        Me.btnDeleteSale.Text = "Eliminar Venta"
        Me.btnDeleteSale.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSalesExl)
        Me.GroupBox4.Controls.Add(Me.btnSalesPdf)
        Me.GroupBox4.Location = New System.Drawing.Point(1425, 488)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(174, 85)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reporte de Ventas General"
        '
        'btnSalesPdf
        '
        Me.btnSalesPdf.Location = New System.Drawing.Point(33, 19)
        Me.btnSalesPdf.Name = "btnSalesPdf"
        Me.btnSalesPdf.Size = New System.Drawing.Size(110, 22)
        Me.btnSalesPdf.TabIndex = 5
        Me.btnSalesPdf.Text = "PDF"
        Me.btnSalesPdf.UseVisualStyleBackColor = True
        '
        'btnSalesExl
        '
        Me.btnSalesExl.Location = New System.Drawing.Point(33, 47)
        Me.btnSalesExl.Name = "btnSalesExl"
        Me.btnSalesExl.Size = New System.Drawing.Size(110, 23)
        Me.btnSalesExl.TabIndex = 6
        Me.btnSalesExl.Text = "Excel"
        Me.btnSalesExl.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnProductSalesExl)
        Me.GroupBox5.Controls.Add(Me.btnProductSalesPDF)
        Me.GroupBox5.Location = New System.Drawing.Point(1425, 576)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(174, 84)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Reporte de Productos Vendidos"
        '
        'btnProductSalesExl
        '
        Me.btnProductSalesExl.Location = New System.Drawing.Point(33, 47)
        Me.btnProductSalesExl.Name = "btnProductSalesExl"
        Me.btnProductSalesExl.Size = New System.Drawing.Size(110, 23)
        Me.btnProductSalesExl.TabIndex = 6
        Me.btnProductSalesExl.Text = "Excel"
        Me.btnProductSalesExl.UseVisualStyleBackColor = True
        '
        'btnProductSalesPDF
        '
        Me.btnProductSalesPDF.Location = New System.Drawing.Point(33, 19)
        Me.btnProductSalesPDF.Name = "btnProductSalesPDF"
        Me.btnProductSalesPDF.Size = New System.Drawing.Size(110, 22)
        Me.btnProductSalesPDF.TabIndex = 5
        Me.btnProductSalesPDF.Text = "PDF"
        Me.btnProductSalesPDF.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 749)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dataGridSales)
        Me.Controls.Add(Me.dataGridProducts)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dataGridClients)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGridClients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dataGridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtClientName As TextBox
    Friend WithEvents txtClientPhone As TextBox
    Friend WithEvents txtClientMail As TextBox
    Friend WithEvents btnAddClient As Button
    Friend WithEvents btnShowClients As Button
    Friend WithEvents btnUpdateClient As Button
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents dataGridClients As DataGridView
    Friend WithEvents btnClearClient As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClientFilter As Button
    Friend WithEvents txtClientFilter As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductFilter As TextBox
    Friend WithEvents btnProductFilter As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnShowProducts As Button
    Friend WithEvents btnClearProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents txtProductCategory As TextBox
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents dataGridProducts As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCategoryFilter As TextBox
    Friend WithEvents dataGridSales As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSaleFilter As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnShowSales As Button
    Friend WithEvents btnClearSale As Button
    Friend WithEvents btnAddSale As Button
    Friend WithEvents btnUpdateSale As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnDeleteSale As Button
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtClientID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpSaleDate As DateTimePicker
    Friend WithEvents txtClientSaleFilter As TextBox
    Friend WithEvents txtProductSaleFilter As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpDateSaleFilter As DateTimePicker
    Friend WithEvents chkFilterByDate As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSalesExl As Button
    Friend WithEvents btnSalesPdf As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnProductSalesExl As Button
    Friend WithEvents btnProductSalesPDF As Button
End Class
