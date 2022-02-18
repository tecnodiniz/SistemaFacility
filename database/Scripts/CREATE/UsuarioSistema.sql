USE [dbFacility]
GO

/****** Object:  Table [dbo].[UsuarioSistema]    Script Date: 18/02/2022 16:12:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UsuarioSistema](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeUsuario] [varchar](255) NOT NULL,
	[Email] [varchar](150) NULL,
	[Login] [varchar](20) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[Grupo] [varchar](50) NULL,
	[Ramal] [smallint] NULL,
 CONSTRAINT [PK_UsuarioSistema_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

