USE [master]
GO
/****** Object:  Database [DBTaller]    Script Date: 24/04/2020 15:48:39 ******/
CREATE DATABASE [DBTaller]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTaller', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBTaller.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBTaller_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBTaller_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBTaller] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBTaller].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBTaller] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBTaller] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBTaller] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBTaller] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBTaller] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBTaller] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBTaller] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBTaller] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBTaller] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBTaller] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBTaller] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBTaller] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBTaller] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBTaller] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBTaller] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBTaller] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBTaller] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBTaller] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBTaller] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBTaller] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBTaller] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBTaller] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBTaller] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBTaller] SET  MULTI_USER 
GO
ALTER DATABASE [DBTaller] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBTaller] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBTaller] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBTaller] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBTaller] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBTaller]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[ap_paterno] [varchar](50) NULL,
	[ap_materno] [varchar](50) NULL,
	[ci] [varchar](10) NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[det_producto]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[det_producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK_det_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[det_servicio]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[det_servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
	[id_tecnico] [int] NOT NULL,
	[id_rampa] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK_det_servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[factura]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro] [bigint] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[total] [float] NOT NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[producto]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio_compra] [float] NULL,
	[precio_venta] [float] NULL,
	[tipo] [varchar](50) NULL,
	[stock] [int] NULL,
	[marca] [varchar](50) NULL,
	[modelo] [varchar](50) NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rampa]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rampa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_rampa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservacion]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reservacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_rampa] [int] NULL,
	[horario] [time](7) NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](50) NULL,
 CONSTRAINT [PK_reservacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[servicio]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
	[precio] [float] NULL,
 CONSTRAINT [PK_servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tecnico]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tecnico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[ap_paterno] [varchar](50) NULL,
	[ap_materno] [varchar](50) NULL,
	[ci] [varchar](15) NULL,
	[telefono] [varchar](20) NULL,
	[direccion] [varchar](100) NULL,
	[especialidad] [varchar](50) NULL,
	[activo] [int] NULL,
 CONSTRAINT [PK_tecnico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 24/04/2020 15:48:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[ap_paterno] [varchar](50) NULL,
	[ap_materno] [varchar](50) NULL,
	[ci] [varchar](15) NULL,
	[telefono] [varchar](20) NULL,
	[direccion] [varchar](100) NULL,
	[tipo] [varchar](50) NULL,
	[cuenta] [varchar](50) NULL,
	[pass] [varchar](256) NULL,
	[activo] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[det_producto]  WITH CHECK ADD  CONSTRAINT [FK_det_producto_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id])
GO
ALTER TABLE [dbo].[det_producto] CHECK CONSTRAINT [FK_det_producto_factura]
GO
ALTER TABLE [dbo].[det_producto]  WITH CHECK ADD  CONSTRAINT [FK_det_producto_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[det_producto] CHECK CONSTRAINT [FK_det_producto_producto]
GO
ALTER TABLE [dbo].[det_servicio]  WITH CHECK ADD  CONSTRAINT [FK_det_servicio_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id])
GO
ALTER TABLE [dbo].[det_servicio] CHECK CONSTRAINT [FK_det_servicio_factura]
GO
ALTER TABLE [dbo].[det_servicio]  WITH CHECK ADD  CONSTRAINT [FK_det_servicio_rampa] FOREIGN KEY([id_rampa])
REFERENCES [dbo].[rampa] ([id])
GO
ALTER TABLE [dbo].[det_servicio] CHECK CONSTRAINT [FK_det_servicio_rampa]
GO
ALTER TABLE [dbo].[det_servicio]  WITH CHECK ADD  CONSTRAINT [FK_det_servicio_servicio] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[servicio] ([id])
GO
ALTER TABLE [dbo].[det_servicio] CHECK CONSTRAINT [FK_det_servicio_servicio]
GO
ALTER TABLE [dbo].[det_servicio]  WITH CHECK ADD  CONSTRAINT [FK_det_servicio_tecnico] FOREIGN KEY([id_tecnico])
REFERENCES [dbo].[tecnico] ([id])
GO
ALTER TABLE [dbo].[det_servicio] CHECK CONSTRAINT [FK_det_servicio_tecnico]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_cliente]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [FK_factura_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [FK_factura_usuario]
GO
ALTER TABLE [dbo].[reservacion]  WITH CHECK ADD  CONSTRAINT [FK_reservacion_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[reservacion] CHECK CONSTRAINT [FK_reservacion_cliente]
GO
ALTER TABLE [dbo].[reservacion]  WITH CHECK ADD  CONSTRAINT [FK_reservacion_rampa] FOREIGN KEY([id_rampa])
REFERENCES [dbo].[rampa] ([id])
GO
ALTER TABLE [dbo].[reservacion] CHECK CONSTRAINT [FK_reservacion_rampa]
GO
USE [master]
GO
ALTER DATABASE [DBTaller] SET  READ_WRITE 
GO
