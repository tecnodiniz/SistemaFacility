USE [dbFacility]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 18/02/2022 16:23:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[CNPJ] [varchar](30) NULL,
	[Email] [nvarchar](200) NULL,
	[Endereco] [nvarchar](255) NULL,
	[Numero] [nvarchar](20) NULL,
	[Complemento] [nvarchar](255) NULL,
	[CEP] [nvarchar](25) NULL,
	[UF] [nvarchar](50) NULL,
	[Cidade] [nvarchar](150) NULL,
	[Bairro] [nvarchar](150) NULL,
 CONSTRAINT [PK_ClienteId] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

