USE [dbFacility]
GO

/****** Object:  Table [dbo].[Propostas]    Script Date: 18/02/2022 16:20:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Propostas](
	[id] [int] NOT NULL,
	[SeguradoraId] [int] NOT NULL,
	[SeguradoId] [int] NOT NULL,
	[ProdutorId] [int] NOT NULL,
	[RamoId] [int] NOT NULL,
	[ModalidadeId] [int] NOT NULL,
	[Fechada] [datetime] NULL,
	[Protocolada] [datetime] NULL,
	[Emitida] [datetime] NULL,
	[FisicoRecebido] [datetime] NULL,
	[InicioVigencia] [datetime] NULL,
	[TerminoVigencia] [datetime] NULL,
	[Apolice] [varchar](255) NULL,
	[ApoliceAnterior] [varchar](255) NULL,
	[CI] [varchar](255) NULL,
	[CiaAnterior] [varchar](255) NULL,
	[ValorEmRisco] [decimal](18, 4) NULL,
	[PremioLiquido] [decimal](18, 4) NULL,
	[IOF] [decimal](18, 4) NULL,
	[PremioTotal] [decimal](18, 4) NULL,
	[Fracionamento] [decimal](18, 4) NULL,
	[CustoApolice] [decimal](18, 4) NULL,
	[Comissao] [decimal](18, 4) NULL,
	[nParcelas] [int] NULL,
 CONSTRAINT [PK_PropostaId] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Propostas]  WITH CHECK ADD  CONSTRAINT [FK_ModalidadeId] FOREIGN KEY([ModalidadeId])
REFERENCES [dbo].[Modalidade] ([id])
GO

ALTER TABLE [dbo].[Propostas] CHECK CONSTRAINT [FK_ModalidadeId]
GO

ALTER TABLE [dbo].[Propostas]  WITH CHECK ADD  CONSTRAINT [FK_ProdutorId] FOREIGN KEY([ProdutorId])
REFERENCES [dbo].[UsuarioSistema] ([Id])
GO

ALTER TABLE [dbo].[Propostas] CHECK CONSTRAINT [FK_ProdutorId]
GO

ALTER TABLE [dbo].[Propostas]  WITH CHECK ADD  CONSTRAINT [FK_RamoId] FOREIGN KEY([RamoId])
REFERENCES [dbo].[Ramo] ([id])
GO

ALTER TABLE [dbo].[Propostas] CHECK CONSTRAINT [FK_RamoId]
GO

ALTER TABLE [dbo].[Propostas]  WITH CHECK ADD  CONSTRAINT [FK_SeguradoId] FOREIGN KEY([SeguradoId])
REFERENCES [dbo].[Clientes] ([id])
GO

ALTER TABLE [dbo].[Propostas] CHECK CONSTRAINT [FK_SeguradoId]
GO

ALTER TABLE [dbo].[Propostas]  WITH CHECK ADD  CONSTRAINT [FK_SeguradoraId] FOREIGN KEY([SeguradoraId])
REFERENCES [dbo].[Seguradoras] ([id])
GO

ALTER TABLE [dbo].[Propostas] CHECK CONSTRAINT [FK_SeguradoraId]
GO

