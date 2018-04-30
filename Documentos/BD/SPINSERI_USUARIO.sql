CREATE PROCEDURE SPINSERI_USUARIO 
    @sLogin AS NVARCHAR(20) ,
	@sSenha AS NVARCHAR(4) ,
	@pkPerfil AS INTEGER,
    @pkPessoa AS INTEGER
AS
INSERT INTO dbo.USUARIO
        (  
		  [LOGIN] ,
		  SENHA,
		  COD_PERFIL_USUARIO,
		  COD_PESSOA
        )
VALUES  (  
           @sLogin,
		   @sSenha,
		   @pkPerfil,
		   @pkPessoa
        )
GO	