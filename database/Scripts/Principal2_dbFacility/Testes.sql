

SELECT 
CASE Propostas.TomadorID 
WHEN 0 THEN Propostas.SeguradoID
ELSE Propostas.TomadorID
END AS Tomador
FROM Propostas WHERE TomadorID IS NOT NULL ORDER BY TomadorID ASC
GO
create table teste2(
	id int identity(1,1) not null,
	ClienteId int not null)
GO

SET IDENTITY_INSERT teste2 ON
GO
INSERT INTO teste2(
					ClienteId)
					SELECT 
					CASE TomadorID
					WHEN 0 THEN SeguradoID
					ELSE TomadorID
					END AS TomadorID
					FROM Propostas WHERE TomadorID IS NOT NULL order by TomadorID
GO

SET IDENTITY_INSERT teste2 OFF
GO

SELECT * FROM teste2


SELECT * FROM Principal2..Contatos WHERE Principal2..Contatos.ID = 4098

SELECT * FROM  Principal2..Propostas where TomadorID = 1 

SELECT * FROM  Principal2..Segurados_NEW WHERE SeguradoID = 4098

GO

SELECT * FROM  Principal2..Sinistros WHERE Principal2..Sinistros.apolice = '5177201649310816953'