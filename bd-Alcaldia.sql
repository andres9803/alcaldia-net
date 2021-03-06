USE [alcaldia]
GO
/****** Object:  Table [dbo].[alcaldia]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alcaldia](
	[idAlcaldia] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[direccion] [varchar](25) NOT NULL,
	[telefono] [bigint] NOT NULL,
 CONSTRAINT [PK_alcaldia] PRIMARY KEY CLUSTERED 
(
	[idAlcaldia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[asistencia]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[asistencia](
	[idAsistencia] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NULL,
	[idRolEstudiante] [bigint] NOT NULL,
 CONSTRAINT [PK_asistencia] PRIMARY KEY CLUSTERED 
(
	[idAsistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[curso]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[curso](
	[idCurso] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
	[horario] [varchar](25) NOT NULL,
	[fechaInicial] [datetime] NULL,
	[fechaFinal] [datetime] NULL,
	[valor] [bigint] NULL,
	[totalHoras] [int] NOT NULL,
	[maximoAsistentes] [int] NOT NULL,
	[fechaInicialInscripciones] [datetime] NULL,
	[fechaFinalInscripciones] [datetime] NULL,
	[idInstituto] [bigint] NOT NULL,
	[valoracionCurso] [int] NULL,
 CONSTRAINT [PK_curso] PRIMARY KEY CLUSTERED 
(
	[idCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[instituto]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[instituto](
	[idInstituto] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[direccion] [varchar](25) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[idAlcadia] [bigint] NOT NULL,
 CONSTRAINT [PK_instituto] PRIMARY KEY CLUSTERED 
(
	[idInstituto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rol]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[idRol] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rolEstudiante]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rolEstudiante](
	[idRolEstudiante] [bigint] NOT NULL,
	[calificacion] [int] NULL,
 CONSTRAINT [PK_rolEstudiante] PRIMARY KEY CLUSTERED 
(
	[idRolEstudiante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[rolSecretaria]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rolSecretaria](
	[idRolSecretaria] [bigint] NOT NULL,
	[codigo] [varchar](25) NULL,
	[idSecretaria] [bigint] NOT NULL,
 CONSTRAINT [PK_rolSecretaria] PRIMARY KEY CLUSTERED 
(
	[idRolSecretaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[secretaria]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[secretaria](
	[idSecretaria] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NOT NULL,
	[direccion] [varchar](25) NOT NULL,
	[telefono] [bigint] NOT NULL,
	[idAlcaldia] [bigint] NOT NULL,
 CONSTRAINT [PK_secretaria] PRIMARY KEY CLUSTERED 
(
	[idSecretaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 19/06/2016 22:05:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[documento] [bigint] NOT NULL,
	[tipoDocumento] [varchar](2) NOT NULL,
	[telefono] [bigint] NULL,
	[celular] [bigint] NULL,
	[direccion] [varchar](50) NULL,
	[barrio] [varchar](25) NULL,
	[correo] [varchar](50) NOT NULL,
	[clave] [varchar](25) NOT NULL,
	[idRol] [bigint] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[asistencia]  WITH CHECK ADD  CONSTRAINT [FK_asistencia_rolEstudiante] FOREIGN KEY([idRolEstudiante])
REFERENCES [dbo].[rolEstudiante] ([idRolEstudiante])
GO
ALTER TABLE [dbo].[asistencia] CHECK CONSTRAINT [FK_asistencia_rolEstudiante]
GO
ALTER TABLE [dbo].[curso]  WITH CHECK ADD  CONSTRAINT [FK_curso_instituto] FOREIGN KEY([idInstituto])
REFERENCES [dbo].[instituto] ([idInstituto])
GO
ALTER TABLE [dbo].[curso] CHECK CONSTRAINT [FK_curso_instituto]
GO
ALTER TABLE [dbo].[instituto]  WITH CHECK ADD  CONSTRAINT [FK_instituto_alcaldia] FOREIGN KEY([idAlcadia])
REFERENCES [dbo].[alcaldia] ([idAlcaldia])
GO
ALTER TABLE [dbo].[instituto] CHECK CONSTRAINT [FK_instituto_alcaldia]
GO
ALTER TABLE [dbo].[rolEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_rolEstudiante_usuario] FOREIGN KEY([idRolEstudiante])
REFERENCES [dbo].[usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[rolEstudiante] CHECK CONSTRAINT [FK_rolEstudiante_usuario]
GO
ALTER TABLE [dbo].[rolSecretaria]  WITH CHECK ADD  CONSTRAINT [FK_rolSecretaria_secretaria] FOREIGN KEY([idSecretaria])
REFERENCES [dbo].[secretaria] ([idSecretaria])
GO
ALTER TABLE [dbo].[rolSecretaria] CHECK CONSTRAINT [FK_rolSecretaria_secretaria]
GO
ALTER TABLE [dbo].[rolSecretaria]  WITH CHECK ADD  CONSTRAINT [FK_rolSecretaria_usuario1] FOREIGN KEY([idRolSecretaria])
REFERENCES [dbo].[usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[rolSecretaria] CHECK CONSTRAINT [FK_rolSecretaria_usuario1]
GO
ALTER TABLE [dbo].[secretaria]  WITH CHECK ADD  CONSTRAINT [FK_secretaria_alcaldia] FOREIGN KEY([idAlcaldia])
REFERENCES [dbo].[alcaldia] ([idAlcaldia])
GO
ALTER TABLE [dbo].[secretaria] CHECK CONSTRAINT [FK_secretaria_alcaldia]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[rol] ([idRol])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_rol]
GO
