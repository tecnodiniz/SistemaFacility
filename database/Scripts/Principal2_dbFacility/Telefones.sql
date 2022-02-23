USE dbFacility
GO

SET IDENTITY_INSERT [dbo].[Telefones] ON

INSERT INTO [dbo].[Telefones]
           ([id]
		   ,[ClienteId]
           ,[dtInclusao]
           ,[Celular])

SELECT 
       [idTel]
      ,[idContatos]
      ,[dtInclusao]
      ,[telefone]
     
   
  FROM [Principal2].[dbo].[telefonesContato] WHERE idTel BETWEEN  8246 AND 9314 AND idContatos IS NOT NULL
  AND EXISTS (SELECT ID FROM Principal2..Contatos WHERE Principal2..telefonesContato.idContatos = ID)

  SET IDENTITY_INSERT [dbo].[Telefones] OFF
GO