USE [master]
GO
/****** Object:  Database [PuntoVentaFinal]    Script Date: 13/09/2023 17:12:27 ******/
CREATE DATABASE [PuntoVentaFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PuntoVentaFinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PuntoVentaFinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PuntoVentaFinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PuntoVentaFinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PuntoVentaFinal] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PuntoVentaFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PuntoVentaFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PuntoVentaFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PuntoVentaFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PuntoVentaFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PuntoVentaFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET RECOVERY FULL 
GO
ALTER DATABASE [PuntoVentaFinal] SET  MULTI_USER 
GO
ALTER DATABASE [PuntoVentaFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PuntoVentaFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PuntoVentaFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PuntoVentaFinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PuntoVentaFinal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PuntoVentaFinal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PuntoVentaFinal', N'ON'
GO
ALTER DATABASE [PuntoVentaFinal] SET QUERY_STORE = ON
GO
ALTER DATABASE [PuntoVentaFinal] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PuntoVentaFinal]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[IdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[IdGrupo] [int] NULL,
	[Codigo] [varchar](100) NULL,
	[Precio] [decimal](12, 2) NULL,
	[Activo] [bit] NULL,
	[Cantidad] [decimal](12, 2) NULL,
	[UnidadMedida] [varchar](10) NULL,
	[Img] [image] NULL,
	[Descripcion] [varchar](256) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[IdGrupo] [int] IDENTITY(1,1) NOT NULL,
	[NomGrupo] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Dni] [varchar](12) NULL,
	[Email] [varchar](100) NULL,
	[Tlf] [int] NULL,
	[FechaNac] [date] NULL,
	[IdRol] [int] NULL,
	[Img] [image] NULL,
	[Usuario] [varchar](50) NULL,
	[Patron] [varchar](50) NULL,
	[Contrasena] [varchar](500) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[No_Factura] [varchar](20) NULL,
	[Fecha_Venta] [datetime] NULL,
	[Cantidad_Total] [decimal](12, 2) NULL,
	[Id_Usuario] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas_Detalle]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas_Detalle](
	[Id_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venta] [int] NULL,
	[Id_Articulo] [int] NULL,
	[Cantidad] [decimal](18, 0) NULL,
	[Precio_Venta] [decimal](12, 2) NULL,
	[Total] [decimal](12, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_A_Actualizar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_A_Actualizar]
@IdArticulo int,
@Nombre varchar(100),
@IdGrupo int,
@Codigo Varchar(100),
@Precio Decimal(12,2),
@Activo bit,
@Cantidad Decimal(12,2),
@UnidadMedida Varchar(10),
@Descripcion Varchar(256)
as begin
update Articulos set Nombre=@Nombre, IdGrupo=@IdGrupo, Codigo=@Codigo, Precio=@Precio, Activo=@Activo, Cantidad=@Cantidad, UnidadMedida=@UnidadMedida, Descripcion=@Descripcion
where IdArticulo = @IdArticulo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_A_ActualizarIMG]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_A_ActualizarIMG]
@IdArticulo int,
@Img image
as begin
update Articulos set Img = @Img where IdArticulo=@IdArticulo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_A_Buscar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_A_Buscar]
@Nombre varchar(50) as begin
select * from Articulos where Nombre like @Nombre+'%' or Codigo like @Nombre+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_A_CargarArticulos]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_A_CargarArticulos]
as begin
select * from Articulos inner join Grupo on Grupo.IdGrupo = Articulos.IdGrupo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_A_Consultar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_A_Consultar]
@IdArticulo int
as begin
select * from Articulos where IdArticulo = @IdArticulo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_A_Eliminar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_A_Eliminar]
@IdArticulo int
as begin
delete from Articulos where IdArticulo = @IdArticulo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_A_Insertar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_A_Insertar]
@Nombre varchar(100),
@IdGrupo int,
@Codigo varchar(100),
@Precio decimal(12,2),
@Activo bit,
@Cantidad decimal(12,2),
@UnidadMedida varchar(10),
@Img image,
@Descripcion varchar(256) as begin
insert into Articulos values (@Nombre, @IdGrupo, @Codigo, @Precio, @Activo, @Cantidad, @UnidadMedida, @Img, @Descripcion)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_C_Buscar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_C_Buscar]
@buscar varchar(100)
as begin
select * from Articulos where Nombre like @buscar+'%' or Codigo like @buscar+'%' and Activo=1
end
GO
/****** Object:  StoredProcedure [dbo].[SP_C_Venta]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_C_Venta]
@No_Factura varchar(20),
@Fecha datetime,
@Total decimal(12,2),
@IdUsuario int
as begin
insert into Ventas values (@No_Factura, @Fecha, @Total, @IdUsuario)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_C_Venta_Detalle]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_C_Venta_Detalle]
@codigo varchar(50),
@cantidad decimal(12,2),
@No_Factura varchar(20),
@Total decimal(12,2)
as begin
declare @Id_Venta int=(select IdVenta from Ventas where No_Factura=@No_Factura);
declare @Idarticulo int = (select IdArticulo from Articulos where Codigo=@codigo);
declare @precio decimal(12,2) = (select Precio from Articulos where Codigo=@codigo);
insert into Ventas_Detalle values (@Id_Venta, @idarticulo, @cantidad, @precio, @total);
update Articulos set Cantidad=Cantidad-@Cantidad where Codigo=@codigo;
end
GO
/****** Object:  StoredProcedure [dbo].[SP_D_Articulos]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_D_Articulos]
as begin
select SUM(Cantidad) from Articulos
end
GO
/****** Object:  StoredProcedure [dbo].[SP_D_CantidadVentas]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_D_CantidadVentas]
as begin
select top 1* from Ventas order by IdVenta desc
end
GO
/****** Object:  StoredProcedure [dbo].[SP_D_Grafico]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_D_Grafico]
as begin
select top 10* from ventas order by Fecha_Venta desc
end
GO
/****** Object:  StoredProcedure [dbo].[SP_G_CargarGrupos]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_G_CargarGrupos]
as begin
select * from Grupo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_G_IdGrupo]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_G_IdGrupo]
@NombreGrupo varchar(50)
as begin
select IdGrupo from Grupo where NomGrupo = @NombreGrupo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_G_Nombre]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_G_Nombre]
@IdGrupo int
as begin
select NomGrupo from Grupo where IdGrupo = @IdGrupo
end
GO
/****** Object:  StoredProcedure [dbo].[SP_P_CargarRoles]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_P_CargarRoles]
as Begin
select NombreRol from Roles
end
GO
/****** Object:  StoredProcedure [dbo].[SP_P_IdRol]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_P_IdRol]
@NombreRol varchar(50)	
as begin
select IdRol from Roles where NombreRol=@NombreRol
end
GO
/****** Object:  StoredProcedure [dbo].[SP_P_NombreRol]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_P_NombreRol]
@IdRol int
as Begin
select NombreRol from Roles where IdRol=@IdRol
end
GO
/****** Object:  StoredProcedure [dbo].[SP_U_ActualizarDatos]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_ActualizarDatos]
@IdUsuario int,
@Nombre varchar(50),
@Apellidos varchar(50),
@Dni varchar(12),
@Email varchar(100),
@Tlf int,
@FechaNac date,
@IdRol int,
@Usuario varchar(100)
as Begin
update Usuarios set Nombre=@Nombre, Apellidos=@Apellidos, DNI=@Dni, EMail=@Email, Tlf=@Tlf, FechaNac=@FechaNac, IdRol=@IdRol, Usuario=@Usuario where IdUsuario = @IdUsuario
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_ActualizarIMG]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_U_ActualizarIMG]
@IdUsuario int,
@Img image
as Begin
Update Usuarios set Img=@Img where IdUsuario=@IdUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[SP_U_ActualizarPass]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_ActualizarPass]
@IdUsuario int,
@Contrasena varchar(500),
@patron varchar(50)
as Begin
Update Usuarios set Contrasena=@Contrasena where IdUsuario=@IdUsuario
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_Buscar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_U_Buscar]
@buscar varchar(50)
as begin
select * from Usuarios inner join Roles on usuarios.IdRol=Roles.IdRol where Nombre like @buscar+'%' or Apellidos like @buscar+'%'
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_CargarUsuarios]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_CargarUsuarios]
as Begin
select * from Usuarios inner join Roles on Usuarios.IdRol=Roles.IdRol
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_Consultar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_Consultar]
@IdUsuario int
as Begin
select * from Usuarios where IdUsuario=@IdUsuario
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_Eliminar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_Eliminar]
@IdUsuario int as Begin
Delete from Usuarios where IdUsuario = @IdUsuario
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_GetPasswordEnc]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_U_GetPasswordEnc]
@Usuario varchar(50)
as Begin
select Contrasena, IdUsuario, Usuarios.IdRol from Usuarios inner join Roles on Usuarios.IdRol=Roles.IdRol and Usuario = @Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[SP_U_Insertar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_Insertar]
@Nombre varchar(50),
@Apellidos varchar(50),
@Dni varchar(12),
@Email varchar(100),
@Tlf int,
@FechaNac date,
@IdRol int,
@Img varchar(max),
@Usuario varchar(100),
@Patron varchar(50),
@Contrasena varchar(500)
as Begin
insert into Usuarios (Nombre, Apellidos, Dni, Email, Tlf, FechaNac, IdRol, Img, Usuario, Patron, Contrasena) values (@Nombre, @Apellidos, @Dni, @Email, @Tlf, @FechaNac, @IdRol, @Img, @Usuario, @Patron, @Contrasena)
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_U_Validar]    Script Date: 13/09/2023 17:12:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_U_Validar]
@Usuario varchar(30),
@Contrasena varchar(500)
as begin
select Usuario, Roles.IdRol from Usuarios inner join Roles on Roles.IdRol=Usuarios.IdRol and Usuario=@Usuario and Contrasena=@Contrasena
end
GO
USE [master]
GO
ALTER DATABASE [PuntoVentaFinal] SET  READ_WRITE 
GO
