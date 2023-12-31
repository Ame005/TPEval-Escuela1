USE [master]
GO
CREATE DATABASE [BDEscuelas]
GO
ALTER DATABASE [BDEscuelas] SET  READ_WRITE 
GO
USE [BDEscuelas]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[IdAlumno] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [int] NULL,
	[NombreAlumno] [varchar](150) NOT NULL,
	[FotoAlumno] [varchar](150) NULL,
	[IdCurso] [int] NULL,
	[FechaNacimientoAlumno] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[NombreCurso] [varchar](50) NULL,
	[Especialidad] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Docentes](
	[IdDocente] [int] IDENTITY(1,1) NOT NULL,
	[NombreDocente] [varchar](150) NULL,
	[FotoDocente] [varchar](150) NULL,
	[IdMateria] [int] NULL,
	[AntiguedadDocente] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escuelas](
	[IdEscuela] [int] IDENTITY(1,1) NOT NULL,
	[NombreEscuela] [varchar](150) NULL,
	[IdProvincia] [int] NULL,
	[FechaFundacion] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materias](
	[IdMateria] [int] IDENTITY(1,1) NOT NULL,
	[NombreMateria] [varchar](50) NULL,
	[Año] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[NombreProvincia] [varchar](150) NULL,
	[Pais] [varchar](50) NULL
) ON [PRIMARY]
GO

INSERT INTO Provincias 
VALUES ('Buenos Aires', 'Argentina');
INSERT INTO Provincias
VALUES ('Catamarca', 'Argentina');
INSERT INTO Provincias
VALUES ('Chaco', 'Argentina');
INSERT INTO Provincias
VALUES ('Chubut', 'Argentina');
INSERT INTO Provincias
VALUES ('Córdoba', 'Argentina');
INSERT INTO Provincias
VALUES ('Corrientes', 'Argentina');
INSERT INTO Provincias
VALUES ('Entre Ríos', 'Argentina');

INSERT INTO Materias
VALUES ('Proyecto Final', 5)
INSERT INTO Materias
VALUES ('EFSI', 5)
INSERT INTO Materias
VALUES ('ARTE', 4)
INSERT INTO Materias
VALUES ('Programación 4to', 4)
INSERT INTO Materias
VALUES ('Programación 5to', 5)

INSERT INTO Cursos
VALUES ('NI4A', 'Informática')
INSERT INTO Cursos
VALUES ('NI4B', 'Informática')
INSERT INTO Cursos
VALUES ('NI4C', 'Informática')
INSERT INTO Cursos
VALUES ('NI4D', 'Informática')