USE [MediCsharp]
GO

/****** Object:  Table [dbo].[Paciente]    Script Date: 07/02/2019 19:42:02 ******/

CREATE TABLE [dbo].[Paciente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CIPaciente] [varchar](255) NULL,
	[NombrePaciente] [varchar](255) NULL,
	[ApellidoPaciente] [varchar](255) NULL,
	[sexo] [int] NULL,
	[Edad] [int] NULL,
	[FechaNacimiento] [datetime] NULL,
	[Telefono] [int] NULL,
	[EstadoCivil] [int] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Doctor]    Script Date: 07/02/2019 19:42:02 ******/

CREATE TABLE [dbo].[Doctor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreDoctor] [varchar](255) NULL,
	[ApellidoDoctor] [varchar](255) NULL,
	[especialidad] [int] NULL,
	[sexo] [int] NULL,
	[Edad] [int] NULL,
	[FechaNacimiento] [datetime] NULL,
	[Telefono] [varchar](255) NULL,
	[DiasGuardia] [varchar](255) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Medicamento]    Script Date: 07/02/2019 19:42:02 ******/

CREATE TABLE [dbo].[Medicamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreMedicamento] [varchar](255) NULL,
	[DescripcionMedicamento] [varchar](255) NULL,
	[origen] [int] NULL,
	[ObservacionMedicamento][varchar](255) NULL,
	[tipomedicamento] [int] NULL,
	
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



/****** Object:  Table [dbo].[Reposo]    Script Date: 07/02/2019 19:42:02 ******/


CREATE TABLE [Reposo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Doctor] [int] NOT NULL,
	[Paciente] [int] NOT NULL,
	[CantidadDias] [int] NOT NULL,
 CONSTRAINT [PK_Reposo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 07/02/2019 19:42:02 ******/

CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Sucursal]    Script Date: 07/02/2019 19:42:02 ******/


CREATE TABLE [Sucursal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreSucursal] [varchar](255) NOT NULL,
	[Direccion] [varchar](255) NOT NULL,
	[CantidadPisos] [int] NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Consulta_Detalle]    Script Date: 07/02/2019 19:42:02 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Consulta_Detalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[consulta_id] [int] NOT NULL,
	[Diagnostico] [varchar](50) NULL,
	[doctor] [int] NULL,
	[FechaConsuLTA] [datetime] NULL,
 CONSTRAINT [PK_Consulta_Detalle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO




/****** Object:  Table [dbo].[Consulta]    Script Date: 07/02/2019 19:42:02 ******/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[paciente] [int] NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
