USE [dbFacility]
GO

/****** Object:  Table [dbo].[Seguradoras]    Script Date: 18/02/2022 16:14:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Seguradoras](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](40) NULL,
	[CNPJ] [varchar](25) NULL,
	[Telefone] [varchar](24) NULL,
	[Celular] [varchar](24) NULL,
	[Email] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[Numero] [varchar](50) NULL,
	[Complemento] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](50) NULL,
	[UF] [varchar](2) NULL,
	[CEP] [varchar](10) NULL,
	[Contato] [varchar](50) NULL,
 CONSTRAINT [PK_Seguradora_id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

