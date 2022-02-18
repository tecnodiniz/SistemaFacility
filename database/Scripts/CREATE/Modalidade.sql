USE [dbFacility]
GO

/****** Object:  Table [dbo].[Modalidade]    Script Date: 18/02/2022 16:22:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Modalidade](
	[id] [int] NOT NULL,
	[ramo] [varchar](2) NOT NULL,
	[modalidade] [varchar](2) NOT NULL,
	[descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ModalidadeId] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

