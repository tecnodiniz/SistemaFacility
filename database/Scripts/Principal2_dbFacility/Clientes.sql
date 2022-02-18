
USE dbFacility
GO

SET IDENTITY_INSERT dbo.Clientes ON;

INSERT INTO dbFacility..Clientes (id, Nome, CNPJ,Email,Endereco,Numero,Complemento,CEP,UF,Cidade,Bairro)
SELECT id, Nome, CNPJ,Email,Endereco,Numero,Complemento,CEP,UF,Cidade,Bairro FROM Principal2..Contatos

SET IDENTITY_INSERT dbo.Clientes Off;
GO

SELECT * FROM dbo.Clientes