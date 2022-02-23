USE [dbFacility]
GO

/****** Object:  Table [dbo].[telefonesContato]    Script Date: 23/02/2022 11:09:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Telefones](
    [id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[dtInclusao] [nvarchar](255) NULL,
	[Telefone] [nvarchar](255) NULL,
	[Celular] [nvarchar](255) NULL
 CONSTRAINT [FK_Cliente_Id] FOREIGN KEY (ClienteId) REFERENCES Clientes(id)
 CONSTRAINT [PK_Telefone_Id] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


