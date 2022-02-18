USE dbFacility
GO

INSERT INTO dbFacility..Modalidade(Id,ramo,modalidade,descricao)
			VALUES(99,99,'DF','Não Selecionada')

GO
SET IDENTITY_INSERT dbo.Modalidade ON;

INSERT INTO dbFacility..Modalidade(
              Id,
			  ramo,
			  modalidade,
			  descricao)
			  SELECT
			  modalidadeId,
			  ramo,
			  modalidade,
			  descricao
			  FROM Principal2..modalidade

			  SET IDENTITY_INSERT dbo.Modalidade OFF;
GO