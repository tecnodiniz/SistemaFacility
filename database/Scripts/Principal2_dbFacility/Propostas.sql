USE Principal2
GO



INSERT INTO dbFacility..Propostas
           ([id]
		   ,[SeguradoraId]
           ,[SeguradoId]
           ,[ProdutorId]
           ,[RamoId]
           ,[ModalidadeId]

           ,[Fechada]
           ,[Protocolada]
           ,[Emitida]
           ,[FisicoRecebido]

           ,[InicioVigencia]
           ,[TerminoVigencia]
           ,[Apolice]
		   ,[ApoliceAnterior]

           ,[PremioLiquido]
           ,[IOF]
           ,[PremioTotal]
           ,[Fracionamento]
           ,[CustoApolice]
           ,[Comissao]
		   ,[nParcelas]
           )
	SELECT 
		   [PropostaID]
		  ,[SeguradoraID]
          ,[clienteID]
           ,CASE
		   WHEN [ProdutorID] IS NULL THEN 1
		   ELSE [ProdutorId]
		   END AS Produtor
           ,[Principal2]..ramo.idRamo

           ,CASE 
			WHEN ModalidadeID IS NULL THEN 99
			WHEN ModalidadeID = 0 THEN 99
			ELSE [ModalidadeID]
			END AS ModalidadeID

           ,[PropostaData]
           ,[PropostaData]
           ,[Emissao]
           ,[PropostaData]

           ,[Inicio_Vigencia]
           ,[Fim_Vigencia]
           ,[Apolice]
           ,[ApoliceAnterior]
   
           ,[Premio_Liquido]
           ,[IOF]
           ,[PremioTotal]
           ,[Adicional_Fracionamento]
           ,[Custo_Apolice]
           ,[Percentual_Comissao]
		   ,[Qtd_Parcelas] 

		   FROM Principal2..Propostas 
		   INNER JOIN Principal2..ramo ON Principal2..Propostas.ramo = Principal2..ramo.ramo
		   WHERE EXISTS (SELECT SeguradoraID FROM Principal2..Seguradoras WHERE Principal2..Seguradoras.SeguradoraID = Principal2..Propostas.SeguradoraID)
		  AND EXISTS (SELECT ID FROM Principal2..Contatos WHERE Principal2..Contatos.ID = Principal2..Propostas.clienteID)
		  AND EXISTS (SELECT usuarioID FROM Principal2..usuarioSistema WHERE Principal2..usuarioSistema.usuarioID = Principal2..Propostas.ProdutorId)
		  AND EXISTS (SELECT modalidadeId FROM Principal2..modalidade WHERE Principal2..modalidade.modalidadeId= Principal2..Propostas.modalidadeId)
GO



		


		