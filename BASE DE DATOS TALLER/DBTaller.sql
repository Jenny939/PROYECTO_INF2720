USE [master]
GO
/****** Object:  Database [DBTaller]    Script Date: 06/08/2020 21:48:49 ******/
CREATE DATABASE [DBTaller]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBTaller', FILENAME = N'D:\DATA\DBTaller.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBTaller_log', FILENAME = N'D:\DATA\DBTaller_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[cliente]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[det_producto]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[det_servicio]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[factura]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[producto]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[rampa]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[reservacion]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[servicio]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[tecnico]    Script Date: 06/08/2020 21:48:50 ******/
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
/****** Object:  Table [dbo].[usuario]    Script Date: 06/08/2020 21:48:50 ******/
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
SET IDENTITY_INSERT [dbo].[cliente] ON 

GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (1, N'Andrea', N'Kaisler', N'Lima', N'7465889', N'60405987', N'6 de octubre y cochabamba')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (2, N'Hilda', N'Ibañez', N'Vasquez', N'6787990', N'73456890', N'Av del valle')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (3, N'Lidia', N'Yucra', N'Jimenez', N'6078787', N'71256788', N'Petot y Murguia')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (4, N'Paola', N'Zarate', N'Espada', N'6566900', N'60487665', N'Cochabamba y potosi')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (5, N'Fabricio', N'Altamirano', N'Fernandez', N'4711906', N'71484923', N'Bolivar y pagador')
GO
INSERT [dbo].[cliente] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion]) VALUES (6, N'Zacarias', N'Mendoza', N'Padilla', N'6877001', N'71455905', N'Aroma y La Paz')
GO
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[det_producto] ON 

GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (1, 1, 1, 2, 38, 76)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (2, 1, 2, 4, 38, 152)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (3, 2, 3, 4, 52, 208)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (4, 1, 3, 1, 38, 38)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (5, 3, 4, 4, 90, 360)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (6, 4, 5, 2, 72, 144)
GO
INSERT [dbo].[det_producto] ([id], [id_producto], [id_factura], [cantidad], [precio_unitario], [subtotal]) VALUES (7, 5, 5, 1, 65, 65)
GO
SET IDENTITY_INSERT [dbo].[det_producto] OFF
GO
SET IDENTITY_INSERT [dbo].[det_servicio] ON 

GO
INSERT [dbo].[det_servicio] ([id], [id_factura], [id_servicio], [id_tecnico], [id_rampa], [cantidad], [precio_unitario], [subtotal]) VALUES (1, 4, 1, 1, 1, 1, 70, 70)
GO
SET IDENTITY_INSERT [dbo].[det_servicio] OFF
GO
SET IDENTITY_INSERT [dbo].[factura] ON 

GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (1, 99999, 1, 2, CAST(N'2020-08-02' AS Date), 76)
GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (2, 99999, 3, 2, CAST(N'2020-08-02' AS Date), 152)
GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (3, 99999, 3, 2, CAST(N'2020-08-02' AS Date), 246)
GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (4, 99999, 5, 2, CAST(N'2020-08-05' AS Date), 430)
GO
INSERT [dbo].[factura] ([id], [nro], [id_cliente], [id_usuario], [fecha], [total]) VALUES (5, 99999, 4, 2, CAST(N'2020-08-05' AS Date), 209)
GO
SET IDENTITY_INSERT [dbo].[factura] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

GO
INSERT [dbo].[producto] ([id], [nombre], [precio_compra], [precio_venta], [tipo], [stock], [marca], [modelo]) VALUES (1, N'Limpiador HGF', 33, 38, N'Filtro de Aceite', 40, N'HGF', N'HGF')
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_compra], [precio_venta], [tipo], [stock], [marca], [modelo]) VALUES (2, N'Llanta BR', 45, 52, N'', 38, N'BR', N'HT56')
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_compra], [precio_venta], [tipo], [stock], [marca], [modelo]) VALUES (3, N'Neumaticos D', 80, 90, N'', 40, N'Michelin Primacy', N'Duravis')
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_compra], [precio_venta], [tipo], [stock], [marca], [modelo]) VALUES (4, N'Neumaticos HPSPORT', 67, 72, N'', 20, N'Goodyear', N'HPSPORT')
GO
INSERT [dbo].[producto] ([id], [nombre], [precio_compra], [precio_venta], [tipo], [stock], [marca], [modelo]) VALUES (5, N'Frenos Ferodo', 55, 65, N'', 16, N'Ferodo', N'A129')
GO
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[rampa] ON 

GO
INSERT [dbo].[rampa] ([id], [nombre], [tipo]) VALUES (1, N'Rampa 1', N'Mantenimiento')
GO
INSERT [dbo].[rampa] ([id], [nombre], [tipo]) VALUES (2, N'Rampa 2', N'Limpieza')
GO
INSERT [dbo].[rampa] ([id], [nombre], [tipo]) VALUES (3, N'Rampa 3', N'Limpieza')
GO
SET IDENTITY_INSERT [dbo].[rampa] OFF
GO
SET IDENTITY_INSERT [dbo].[reservacion] ON 

GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_rampa], [horario], [fecha], [observacion]) VALUES (1, 1, 1, CAST(N'09:30:00' AS Time), CAST(N'2020-08-21' AS Date), N'Ninguna')
GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_rampa], [horario], [fecha], [observacion]) VALUES (2, 4, 1, CAST(N'15:00:00' AS Time), CAST(N'2020-08-24' AS Date), N'Ninguna')
GO
INSERT [dbo].[reservacion] ([id], [id_cliente], [id_rampa], [horario], [fecha], [observacion]) VALUES (3, 6, 2, CAST(N'17:00:00' AS Time), CAST(N'2020-08-24' AS Date), N'RESERVACION CANCELADA')
GO
SET IDENTITY_INSERT [dbo].[reservacion] OFF
GO
SET IDENTITY_INSERT [dbo].[servicio] ON 

GO
INSERT [dbo].[servicio] ([id], [nombre], [tipo], [precio]) VALUES (1, N'Cambio de neumaticos', N'Mantenimiento', 70)
GO
INSERT [dbo].[servicio] ([id], [nombre], [tipo], [precio]) VALUES (4, N'Cambio de frenos', N'Mnatenimiento', 80)
GO
INSERT [dbo].[servicio] ([id], [nombre], [tipo], [precio]) VALUES (5, N'Limpieza simple', N'Limpieza', 35)
GO
INSERT [dbo].[servicio] ([id], [nombre], [tipo], [precio]) VALUES (6, N'Limpieza completa', N'Limpieza', 50)
GO
SET IDENTITY_INSERT [dbo].[servicio] OFF
GO
SET IDENTITY_INSERT [dbo].[tecnico] ON 

GO
INSERT [dbo].[tecnico] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [especialidad], [activo]) VALUES (1, N'Fernando', N'Gomez', N'Lopez', N'7287889', N'71478908', N'6 de agosto', N'Mantenimiento', 1)
GO
INSERT [dbo].[tecnico] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [especialidad], [activo]) VALUES (2, N'Johannes', N'Loria', N'Zurita', N'7499021', N'60505966', N'Bolivar y potosi', N'Mantenimiento', 1)
GO
SET IDENTITY_INSERT [dbo].[tecnico] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

GO
INSERT [dbo].[usuario] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [tipo], [cuenta], [pass], [activo]) VALUES (1, N'Belen', N'Fernandez', N'Montecinos', N'7665453', N'61478990', N'Bolivar y 6 de octubre', N'Administrador', N'Admin', N'123', 1)
GO
INSERT [dbo].[usuario] ([id], [nombre], [ap_paterno], [ap_materno], [ci], [telefono], [direccion], [tipo], [cuenta], [pass], [activo]) VALUES (2, N'Saul', N'Terrazas', N'Perez', N'7345676', N'71433876', N'Petot y Murguia', N'Operador', N'Operador', N'123', 1)
GO
SET IDENTITY_INSERT [dbo].[usuario] OFF
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
