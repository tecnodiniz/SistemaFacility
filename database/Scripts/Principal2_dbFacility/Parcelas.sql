USE [dbFacility]
GO


SET IDENTITY_INSERT dbFacility..Parcelas ON

INSERT INTO dbFacility..Parcelas(
       [id]
      ,[PropostaId]

      ,[Parcela]
      ,[PremioLiquido]
      ,[CustoApolice]
      ,[IOF]
      ,[Fracionamento]
      ,[Desconto]
      ,[Comissao]

      ,[DataBoleto]
      ,[DataEnvio]
	  ,[DataPagto]
      ,[ValorParcela]
      ,[ValorLiquido]
      )

 SELECT 
       [parcelaID]
      ,[PropostaID]

      ,[Parcela]
      ,[PremioLiquido]
      ,[CustoApolice]
      ,[IOF]
      ,[Adicional_Fracionamento]
      ,[Desconto]
      ,[Comissao]

      ,[DataVencimento]
	  ,[DataVencimento]
      ,[DataPagamento]
      ,[valorParcela]
      ,[valorParcelaLiquida]

  FROM Principal2..PropostaParcelas WHERE EXISTS(SELECT id FROM Propostas WHERE id = PropostaParcelas.PropostaID)

  SET IDENTITY_INSERT dbFacility..Parcelas OFF

GO


SELECT * FROM Parcelas

