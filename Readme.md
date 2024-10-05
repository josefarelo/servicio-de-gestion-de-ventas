# Sistema de Gestión de Ventas

## Descripción

**Sistema de Gestión de Ventas** es una aplicación de escritorio desarrollada en **Visual Basic .NET** utilizando **Visual Studio 2019** y **SQL Server** como sistema de gestión de bases de datos. La aplicación está diseñada para gestionar información relacionada con clientes, productos, ventas y los ítems de cada venta. Además, incluye funcionalidades avanzadas para generar reportes en formatos PDF y Excel, facilitando así el análisis y la toma de decisiones empresariales.

## Características

- **Gestión de Clientes y Productos:** Permite crear, actualizar, eliminar y visualizar información de clientes y productos.
- **Procesamiento de Ventas:** Facilita la creación, actualización y eliminación de ventas, así como la gestión de los ítems asociados a cada venta.
- **Generación de Reportes:** Proporciona reportes mensuales de ventas en formatos PDF y Excel utilizando las librerías **iTextSharp** y **OfficeOpenXml**.
- **Interfaz de Usuario Intuitiva:** Diseñada con formularios amigables que permiten una interacción sencilla y eficiente.
- **Validaciones y Manejo de Errores:** Implementa validaciones para asegurar la integridad de los datos y maneja excepciones para una operación robusta.

## Tecnologías Utilizadas

- **Lenguaje de Programación:** Visual Basic .NET
- **Entorno de Desarrollo:** Visual Studio 2019
- **Base de Datos:** SQL Server
- **Librerías Externas:**
  - **iTextSharp:** Para la generación de documentos PDF.
  - **OfficeOpenXml (EPPlus):** Para la creación y manipulación de archivos Excel.
- **Framework:** .NET Framework 4.7.2

## Estructura del Proyecto

### Base de Datos (`pruebademo.sql`)

La base de datos `pruebademo` está compuesta por cuatro tablas principales:

1. **clientes**
   - `ID` (int, clave primaria, identidad)
   - `Cliente` (varchar(255), nombre del cliente)
   - `Telefono` (varchar(255), teléfono del cliente)
   - `Correo` (varchar(255), correo electrónico del cliente)

2. **productos**
   - `ID` (int, clave primaria, identidad)
   - `Nombre` (varchar(255), nombre del producto)
   - `Precio` (float, precio unitario del producto)
   - `Categoria` (varchar(255), categoría del producto)

3. **ventas**
   - `ID` (int, clave primaria, identidad)
   - `IDCliente` (int, clave foránea referenciando a `clientes.ID`)
   - `Fecha` (datetime, fecha de la venta)
   - `Total` (float, total de la venta)

4. **ventasitems**
   - `ID` (int, clave primaria, identidad)
   - `IDVenta` (int, clave foránea referenciando a `ventas.ID`)
   - `IDProducto` (int, clave foránea referenciando a `productos.ID`)
   - `PrecioUnitario` (float, precio unitario del producto en la venta)
   - `Cantidad` (float, cantidad vendida)
   - `PrecioTotal` (float, total por ítem de la venta)

### Configuración de la Aplicación (`App.config`)

El archivo `App.config` contiene la cadena de conexión a la base de datos y otras configuraciones necesarias para la correcta ejecución de la aplicación.