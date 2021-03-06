USE [74507]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[n_perfil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (2, N'Tester')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (3, N'Desarrollador')
INSERT [dbo].[Perfiles] ([id_perfil], [n_perfil]) VALUES (4, N'Responsable de Reportes')
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
/****** Object:  Table [dbo].[MetodoDePago]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MetodoDePago](
	[id_metodo_pago] [int] NOT NULL,
	[n_metodo_pago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MetodoDePago] PRIMARY KEY CLUSTERED 
(
	[id_metodo_pago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MetodoDePago] ([id_metodo_pago], [n_metodo_pago]) VALUES (1, N'Efectivo')
INSERT [dbo].[MetodoDePago] ([id_metodo_pago], [n_metodo_pago]) VALUES (2, N'Tarjeta de Credito')
INSERT [dbo].[MetodoDePago] ([id_metodo_pago], [n_metodo_pago]) VALUES (3, N'Tarjeta de Debito')
/****** Object:  Table [dbo].[Formularios]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[n_formulario] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[n_estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (1, N'Nuevo')
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (2, N'Asignado')
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (3, N'Cerrado')
INSERT [dbo].[Estados] ([id_estado], [n_estado]) VALUES (4, N'Borrado')
SET IDENTITY_INSERT [dbo].[Estados] OFF
/****** Object:  Table [dbo].[Criticidades]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Criticidades](
	[id_criticidad] [int] IDENTITY(1,1) NOT NULL,
	[n_criticidad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Criticidades] PRIMARY KEY CLUSTERED 
(
	[id_criticidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Criticidades] ON
INSERT [dbo].[Criticidades] ([id_criticidad], [n_criticidad]) VALUES (1, N'LEVE')
INSERT [dbo].[Criticidades] ([id_criticidad], [n_criticidad]) VALUES (2, N'GRAVE')
INSERT [dbo].[Criticidades] ([id_criticidad], [n_criticidad]) VALUES (3, N'INVALIDANTE')
SET IDENTITY_INSERT [dbo].[Criticidades] OFF
/****** Object:  Table [dbo].[Compras]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compras](
	[id_compra] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [int] NOT NULL,
	[proveedor] [int] NOT NULL,
	[metodo_pago] [int] NOT NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Compras] ON
INSERT [dbo].[Compras] ([id_compra], [producto], [cantidad], [precio], [proveedor], [metodo_pago], [estado]) VALUES (1, N'Leche descremada', 150, 10000, 3, 2, N'S')
INSERT [dbo].[Compras] ([id_compra], [producto], [cantidad], [precio], [proveedor], [metodo_pago], [estado]) VALUES (2, N'Leche entera', 25, 5000, 1, 1, N'S')
INSERT [dbo].[Compras] ([id_compra], [producto], [cantidad], [precio], [proveedor], [metodo_pago], [estado]) VALUES (5, N'milky', 25, 200000, 2, 1, N'N')
SET IDENTITY_INSERT [dbo].[Compras] OFF
/****** Object:  Table [dbo].[Proveedor]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[n_proveedor] [varchar](100) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON
INSERT [dbo].[Proveedor] ([id_proveedor], [n_proveedor]) VALUES (1, N'The Food Team')
INSERT [dbo].[Proveedor] ([id_proveedor], [n_proveedor]) VALUES (2, N'MIGEXPORT')
INSERT [dbo].[Proveedor] ([id_proveedor], [n_proveedor]) VALUES (3, N'Waldo Control')
INSERT [dbo].[Proveedor] ([id_proveedor], [n_proveedor]) VALUES (4, N'Cyrsa Comercial')
INSERT [dbo].[Proveedor] ([id_proveedor], [n_proveedor]) VALUES (5, N'Pro Lactoingredientes')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
/****** Object:  Table [dbo].[Productos]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre]) VALUES (1, N'SOFTWARE GESTION II')
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Prioridades]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[n_prioridad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Prioridades] ON
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (1, N'BAJA')
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (2, N'MEDIA')
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (3, N'ALTA')
INSERT [dbo].[Prioridades] ([id_prioridad], [n_prioridad]) VALUES (4, N'URGENTE')
SET IDENTITY_INSERT [dbo].[Prioridades] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[n_usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([id_usuario], [n_usuario], [password], [email], [id_perfil]) VALUES (1, N'ADMIN', N'123', N'admin@bt.com', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Permisos]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bugs]    Script Date: 09/13/2017 19:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bugs](
	[id_bug] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[asignado_a] [int] NULL,
	[id_estado] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[fecha_ultimo_cambio] [date] NOT NULL,
 CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED 
(
	[id_bug] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Bugs_Criticidades]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Criticidades]
GO
/****** Object:  ForeignKey [FK_Bugs_Estados]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Estados]
GO
/****** Object:  ForeignKey [FK_Bugs_Prioridades]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Prioridades]
GO
/****** Object:  ForeignKey [FK_Bugs_Productos]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Productos]
GO
/****** Object:  ForeignKey [FK_Permisos_Formularios]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
/****** Object:  ForeignKey [FK_Permisos_Perfiles]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
/****** Object:  ForeignKey [FK_Users_Perfiles]    Script Date: 09/13/2017 19:33:08 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Perfiles]
GO
