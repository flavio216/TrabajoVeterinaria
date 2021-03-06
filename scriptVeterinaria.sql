USE [master]
GO
/****** Object:  Database [Veterinaria]    Script Date: 25/11/2019 16:38:05 ******/
CREATE DATABASE [Veterinaria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Veterinaria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Veterinaria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Veterinaria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Veterinaria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Veterinaria] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Veterinaria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Veterinaria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Veterinaria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Veterinaria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Veterinaria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Veterinaria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Veterinaria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Veterinaria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Veterinaria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Veterinaria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Veterinaria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Veterinaria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Veterinaria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Veterinaria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Veterinaria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Veterinaria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Veterinaria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Veterinaria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Veterinaria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Veterinaria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Veterinaria] SET  MULTI_USER 
GO
ALTER DATABASE [Veterinaria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Veterinaria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Veterinaria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Veterinaria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Veterinaria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Veterinaria] SET QUERY_STORE = OFF
GO
USE [Veterinaria]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[TipoDoc] [int] NOT NULL,
	[Documento] [int] NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[Telefono] [float] NULL,
	[IdLocalidad] [int] NULL,
	[Direccion] [varchar](50) NULL,
	[Numero] [int] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consultas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consultas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[consulta] [varchar](150) NULL,
	[precio] [decimal](10, 2) NULL,
	[IdVeterinario] [int] NULL,
 CONSTRAINT [pk_consultas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Facturas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Facturas](
	[nro_factura] [int] NOT NULL,
	[cod_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[pre_unitario] [float] NOT NULL,
	[IdTurno] [int] NULL,
 CONSTRAINT [PK_Detalle_Facturas] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[nro_factura] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[IdVeterinario] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[nro_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[Id] [int] NOT NULL,
	[Localidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascotas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascotas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[IdTipo] [int] NOT NULL,
	[IdRaza] [int] NOT NULL,
	[Estado] [bit] NULL,
	[IdCliente] [int] NULL,
	[IdSexo] [int] NULL,
 CONSTRAINT [PK_Mascotas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Precio] [float] NULL,
	[Stock] [int] NULL,
	[IdTipo] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Razas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Razas](
	[Id] [int] NOT NULL,
	[Raza] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Razas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SexoMascota]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SexoMascota](
	[Id] [int] NOT NULL,
	[Sexo] [varchar](30) NULL,
 CONSTRAINT [pk_sexomascota] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Documentos]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Documentos](
	[Id] [int] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Documentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Producto]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Producto](
	[Id] [int] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Tipo_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMascota]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMascota](
	[Id] [int] NOT NULL,
	[Tipo] [varchar](50) NULL,
 CONSTRAINT [PK_TipoMascota] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[Id] [int] NOT NULL,
	[Fecha_Turno] [datetime] NOT NULL,
	[IdMascota] [int] NOT NULL,
	[IdVeterinario] [int] NOT NULL,
 CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Veterinarios]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Veterinarios](
	[Matricula] [int] NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[password] [varchar](60) NULL,
	[Estado] [int] NULL,
 CONSTRAINT [PK_Veterinarios] PRIMARY KEY CLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Localidades] FOREIGN KEY([IdLocalidad])
REFERENCES [dbo].[Localidades] ([Id])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Localidades]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Documentos] FOREIGN KEY([TipoDoc])
REFERENCES [dbo].[Tipo_Documentos] ([Id])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Documentos]
GO
ALTER TABLE [dbo].[Consultas]  WITH CHECK ADD  CONSTRAINT [fk_consultas_veterinarios] FOREIGN KEY([IdVeterinario])
REFERENCES [dbo].[Veterinarios] ([Matricula])
GO
ALTER TABLE [dbo].[Consultas] CHECK CONSTRAINT [fk_consultas_veterinarios]
GO
ALTER TABLE [dbo].[Detalle_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Facturas_Facturas] FOREIGN KEY([nro_factura])
REFERENCES [dbo].[Facturas] ([nro_factura])
GO
ALTER TABLE [dbo].[Detalle_Facturas] CHECK CONSTRAINT [FK_Detalle_Facturas_Facturas]
GO
ALTER TABLE [dbo].[Detalle_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Facturas_Productos] FOREIGN KEY([cod_producto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Detalle_Facturas] CHECK CONSTRAINT [FK_Detalle_Facturas_Productos]
GO
ALTER TABLE [dbo].[Detalle_Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Facturas_Turnos] FOREIGN KEY([IdTurno])
REFERENCES [dbo].[Turnos] ([Id])
GO
ALTER TABLE [dbo].[Detalle_Facturas] CHECK CONSTRAINT [FK_Detalle_Facturas_Turnos]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [fk_mascota_sexo] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[SexoMascota] ([Id])
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [fk_mascota_sexo]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [fk_Mascotas_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [fk_Mascotas_Clientes]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [FK_Mascotas_Razas] FOREIGN KEY([IdRaza])
REFERENCES [dbo].[Razas] ([Id])
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [FK_Mascotas_Razas]
GO
ALTER TABLE [dbo].[Mascotas]  WITH CHECK ADD  CONSTRAINT [FK_Mascotas_TipoMascota] FOREIGN KEY([IdTipo])
REFERENCES [dbo].[TipoMascota] ([Id])
GO
ALTER TABLE [dbo].[Mascotas] CHECK CONSTRAINT [FK_Mascotas_TipoMascota]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Tipo_Producto] FOREIGN KEY([IdTipo])
REFERENCES [dbo].[Tipo_Producto] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Tipo_Producto]
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Veterinarios] FOREIGN KEY([IdVeterinario])
REFERENCES [dbo].[Veterinarios] ([Matricula])
GO
ALTER TABLE [dbo].[Turnos] CHECK CONSTRAINT [FK_Turnos_Veterinarios]
GO
/****** Object:  StoredProcedure [dbo].[prActivarVeterinario]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[prActivarVeterinario]
@cod int = 0
as
UPDATE Veterinarios Set
Estado = 1 
where Matricula = @cod
GO
/****** Object:  StoredProcedure [dbo].[prBuscarClienteMascota]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prBuscarClienteMascota]
@txt int = 0
as
select Id, Apellido + ' ' + Nombre AS Cliente
from Clientes 
where Estado = 1 and Id = @txt
GO
/****** Object:  StoredProcedure [dbo].[prBuscarCon]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prBuscarCon]@consulta varchar(150)asselect *from Consultaswhere consulta=@consulta
GO
/****** Object:  StoredProcedure [dbo].[prBuscarMascota]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prBuscarMascota]
@txt varchar(60) = '%'
as
select m.Nombre, sm.sexo ,m.FechaNac, tp.Tipo, r.Raza,
c.Apellido +' '+ c.Nombre as Cliente
from Mascotas m
inner join TipoMascota tp
on m.IdTipo = tp.Id
inner join Razas r
on m.IdRaza = r.Id
inner join Clientes c
on c.Id = m.IdCliente
inner join SexoMascota sm
on sm.Id = m.IdSexo
where m.Estado = 1 and Apellido like @txt+'%'
GO
/****** Object:  StoredProcedure [dbo].[prCliente]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prCliente]
AS 
select c.Id, Apellido, Nombre, c.TipoDoc ,td.Tipo, Documento, FechaNac, Telefono, IdLocalidad ,l.Localidad, Direccion,
Numero, Estado
from Clientes c
inner join Tipo_Documentos Td
on c.TipoDoc = td.Id
inner join Localidades l
on c.IdLocalidad = l.IdWhere Estado = 1;
GO
/****** Object:  StoredProcedure [dbo].[prClienteBaja]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prClienteBaja]
AS 
select c.Id, Apellido, Nombre, c.TipoDoc ,td.Tipo, Documento, FechaNac, Telefono, c.IdLocalidad ,l.Localidad, Direccion,
Numero, Estado
from Clientes c
inner join Tipo_Documentos Td
on c.TipoDoc = td.Id
inner join Localidades l
on c.IdLocalidad = l.IdWhere Estado = 0;
GO
/****** Object:  StoredProcedure [dbo].[prConsultas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[prConsultas]
as
select c.Id, consulta as Consulta, precio as Precio, c.IdVeterinario
as Matricula, v.Apellido + ' ' + v.Nombre as Veterinario
from Consultas c
inner join Veterinarios v
on v.Matricula = c.IdVeterinario
GO
/****** Object:  StoredProcedure [dbo].[prDesactivarVeterinario]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[prDesactivarVeterinario]
@cod int = 0
as
UPDATE Veterinarios Set
Estado = 0 
where Matricula = @cod
GO
/****** Object:  StoredProcedure [dbo].[prMascota]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prMascota]
AS 
select m.id, m.Nombre, sm.sexo as Sexo ,m.FechaNac, m.IdTipo, tp.Tipo, m.IdRaza, r.Raza, IdCliente,
c.Apellido +' '+ c.Nombre as Cliente, m.Estado
from Mascotas m
inner join TipoMascota tp
on m.IdTipo = tp.Id
inner join Razas r
on m.IdRaza = r.Id
inner join Clientes c
on c.Id = m.IdCliente
inner join SexoMascota sm
on m.IdSexo = sm.Id
where m.Estado = 1;
GO
/****** Object:  StoredProcedure [dbo].[prMascotaBaja]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[prMascotaBaja]
AS 
select m.id, m.Nombre, sm.sexo as Sexo ,m.FechaNac, m.IdTipo, tp.Tipo, m.IdRaza, r.Raza, IdCliente,
c.Apellido +' '+ c.Nombre as Cliente, m.Estado
from Mascotas m
inner join TipoMascota tp
on m.IdTipo = tp.Id
inner join Razas r
on m.IdRaza = r.Id
inner join Clientes c
on c.Id = m.IdCliente
inner join SexoMascota sm
on sm.Id = m.IdSexo
where m.Estado = 0;
GO
/****** Object:  StoredProcedure [dbo].[spBuscararticulos]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spBuscararticulos]
as
select *
from Productos
GO
/****** Object:  StoredProcedure [dbo].[spConsultas]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spConsultas]asselect * from Consultas
GO
/****** Object:  StoredProcedure [dbo].[spProductos]    Script Date: 25/11/2019 16:38:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spProductos]
as
select p.*, tipo
from Productos p
inner join Tipo_Producto tp
on tp.Id = p.IdTipo
GO
USE [master]
GO
ALTER DATABASE [Veterinaria] SET  READ_WRITE 
GO
