USE dbFacility
GO

SET IDENTITY_INSERT dbo.UsuarioSistema ON;

INSERT INTO dbFacility..UsuarioSistema(id, NomeUsuario,Email,Login,Senha,Grupo,Ramal)
SELECT usuarioID, nomeUsuario,Email,login,Senha,Grupo,Ramal
FROM Principal2..usuarioSistema

SET IDENTITY_INSERT dbo.UsuarioSistema OFF;

GO