IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Venta')
BEGIN
  CREATE DATABASE Venta;
END;
GO

CREATE TABLE Usuario(
	 id int identity(1,1) primary key NOT NULL,
	 nombre nvarchar(200) NOT NULL,
	 apellido nvarchar(200) NOT NULL,
	 edad int NOT NULL,
	 correo_electronico nvarchar(200) NOT NULL,
	 tipo_usuario nvarchar(200) NOT NULL
);

CREATE TABLE Factura(
	 id int identity(1,1) primary key NOT NULL,
	 id_usuario varchar(200) NOT NULL,
	 folio nvarchar(200) NOT NULL,
	 saldo int NOT NULL,
	 fecha_facturacion datetime2(7) NOT NULL,
	 fecha_creacion datetime2(7) NOT NULL
);