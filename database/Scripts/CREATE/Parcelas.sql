    USE dbFacility
	GO

	CREATE TABLE Parcelas(
	id int IDENTITY(1,1)NOT NULL,
	PropostaId int NOT NULL,
	Parcela int,
	PremioLiquido decimal(18,2),
	CustoApolice decimal(18,2),
	IOF decimal(18,4),
	Fracionamento decimal(18,2),
	Desconto decimal(18,2),
	Comissao decimal (18,2),

	NumeroBoleto int,
	DataBoleto datetime,
	DataEnvio datetime,

	TaxaJuros decimal(18,2),
    ValorParcela decimal(18,2),
	ValorLiquido decimal(18,2),

	DataPagto datetime,
	ValorPago decimal (18,2)
	CONSTRAINT [FK_Proposta_Id] FOREIGN KEY (PropostaId) REFERENCES Propostas (Id) 
    CONSTRAINT [PK_Parcelas_Id] PRIMARY KEY CLUSTERED
	(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE Parcelas ALTER COLUMN ValorParcela decimal(18,2)